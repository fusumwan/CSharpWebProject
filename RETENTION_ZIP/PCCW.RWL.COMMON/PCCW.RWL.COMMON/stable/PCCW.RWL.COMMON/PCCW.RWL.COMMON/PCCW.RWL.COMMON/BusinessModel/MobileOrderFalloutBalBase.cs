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
///-- Description:	<Description,Table :[MobileOrderFallout],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderFallout] Business layer
    /// </summary>
    
    public abstract class MobileOrderFalloutBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public MobileOrderFalloutBalBase(){
        }
        ~MobileOrderFalloutBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderFallout x_oMobileOrderFallout)
        {
            return GetDataSet(x_oMobileOrderFallout,null,MobileOrderFalloutInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderFallout x_oMobileOrderFallout,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oMobileOrderFallout,x_oMergeDSet,MobileOrderFalloutInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderFallout x_oMobileOrderFallout,MobileOrderFalloutInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderFallout,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderFallout x_oMobileOrderFallout,global::System.Data.DataSet x_oMergeDSet,MobileOrderFalloutInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderFallout,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(MobileOrderFallout x_oMobileOrderFallout,global::System.Data.DataSet x_oMergeDSet,MobileOrderFalloutInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderFalloutInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(MobileOrderFallout.Para.TableName());
            if (x_oTableSet.Fields(MobileOrderFallout.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderFallout.Para.TableName()].Columns.Add(MobileOrderFallout.Para.active); }
            if (x_oTableSet.Fields(MobileOrderFallout.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderFallout.Para.TableName()].Columns.Add(MobileOrderFallout.Para.cdate); }
            if (x_oTableSet.Fields(MobileOrderFallout.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderFallout.Para.TableName()].Columns.Add(MobileOrderFallout.Para.cid); }
            if (x_oTableSet.Fields(MobileOrderFallout.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderFallout.Para.TableName()].Columns.Add(MobileOrderFallout.Para.did); }
            if (x_oTableSet.Fields(MobileOrderFallout.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderFallout.Para.TableName()].Columns.Add(MobileOrderFallout.Para.ddate); }
            if (x_oTableSet.Fields(MobileOrderFallout.Para.fo_reason).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderFallout.Para.TableName()].Columns.Add(MobileOrderFallout.Para.fo_reason); }
            if (x_oTableSet.Fields(MobileOrderFallout.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderFallout.Para.TableName()].Columns.Add(MobileOrderFallout.Para.mid); }
            if (x_oTableSet.Fields(MobileOrderFallout.Para.follow_by).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderFallout.Para.TableName()].Columns.Add(MobileOrderFallout.Para.follow_by); }
            if (x_oMobileOrderFallout != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[MobileOrderFallout.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(MobileOrderFallout.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderFallout.Para.active] = x_oMobileOrderFallout.GetActive(); }
                if (x_oTableSet.Fields(MobileOrderFallout.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderFallout.Para.cdate] = x_oMobileOrderFallout.GetCdate(); }
                if (x_oTableSet.Fields(MobileOrderFallout.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderFallout.Para.cid] = x_oMobileOrderFallout.GetCid(); }
                if (x_oTableSet.Fields(MobileOrderFallout.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderFallout.Para.did] = x_oMobileOrderFallout.GetDid(); }
                if (x_oTableSet.Fields(MobileOrderFallout.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderFallout.Para.ddate] = x_oMobileOrderFallout.GetDdate(); }
                if (x_oTableSet.Fields(MobileOrderFallout.Para.fo_reason).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderFallout.Para.fo_reason] = x_oMobileOrderFallout.GetFo_reason(); }
                if (x_oTableSet.Fields(MobileOrderFallout.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderFallout.Para.mid] = x_oMobileOrderFallout.GetMid(); }
                if (x_oTableSet.Fields(MobileOrderFallout.Para.follow_by).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderFallout.Para.follow_by] = x_oMobileOrderFallout.GetFollow_by(); }
                _oDSet.Tables[MobileOrderFallout.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(MobileOrderFalloutInfo x_oTableSet)
        {
            return MobileOrderFalloutBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return MobileOrderFalloutBal.ToEmptyDataSetProcess(MobileOrderFalloutInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(MobileOrderFalloutInfo x_oTableSet)
        {
            return MobileOrderFalloutBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(MobileOrderFallout x_oMobileOrderFallout, MobileOrderFalloutInfo x_oTableSet)
        {
            return MobileOrderFalloutBal.GetDataSet(null, null, x_oTableSet).Tables[MobileOrderFallout.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(MobileOrderFallout x_oMobileOrderFallout)
        {
            return MobileOrderFalloutBal.GetDataSet(x_oMobileOrderFallout, null, MobileOrderFalloutInfoDLL.CreateInfoInstanceObject()).Tables[MobileOrderFallout.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            return Row(x_oTable, x_oDB,x_iMid,MobileOrderFalloutInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid, MobileOrderFalloutInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iMid, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid,MobileOrderFalloutInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderFalloutInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [MobileOrderFallout].[did] AS MOBILEORDERFALLOUT_DID,[MobileOrderFallout].[cdate] AS MOBILEORDERFALLOUT_CDATE,[MobileOrderFallout].[cid] AS MOBILEORDERFALLOUT_CID,[MobileOrderFallout].[follow_by] AS MOBILEORDERFALLOUT_FOLLOW_BY,[MobileOrderFallout].[active] AS MOBILEORDERFALLOUT_ACTIVE,[MobileOrderFallout].[ddate] AS MOBILEORDERFALLOUT_DDATE,[MobileOrderFallout].[fo_reason] AS MOBILEORDERFALLOUT_FO_REASON,[MobileOrderFallout].[mid] AS MOBILEORDERFALLOUT_MID  FROM  [MobileOrderFallout]  WHERE  [MobileOrderFallout].[mid] = \'"+x_iMid.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderFallout]","["+ Configurator.MSSQLTablePrefix + "MobileOrderFallout]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(MobileOrderFallout.Para.did).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERFALLOUT_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderFallout.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderFallout.Para.did).AliasName].ToString()] = (string)_oData["MOBILEORDERFALLOUT_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderFallout.Para.did).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderFallout.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERFALLOUT_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderFallout.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderFallout.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERFALLOUT_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderFallout.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderFallout.Para.cid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERFALLOUT_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderFallout.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderFallout.Para.cid).AliasName].ToString()] = (string)_oData["MOBILEORDERFALLOUT_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderFallout.Para.cid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderFallout.Para.follow_by).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERFALLOUT_FOLLOW_BY"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderFallout.Para.follow_by).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderFallout.Para.follow_by).AliasName].ToString()] = (string)_oData["MOBILEORDERFALLOUT_FOLLOW_BY"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderFallout.Para.follow_by).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderFallout.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERFALLOUT_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderFallout.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderFallout.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILEORDERFALLOUT_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderFallout.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderFallout.Para.ddate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERFALLOUT_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderFallout.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderFallout.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERFALLOUT_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderFallout.Para.ddate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderFallout.Para.fo_reason).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERFALLOUT_FO_REASON"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderFallout.Para.fo_reason).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderFallout.Para.fo_reason).AliasName].ToString()] = (string)_oData["MOBILEORDERFALLOUT_FO_REASON"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderFallout.Para.fo_reason).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderFallout.Para.mid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERFALLOUT_MID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderFallout.Para.mid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderFallout.Para.mid).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERFALLOUT_MID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderFallout.Para.mid).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,MobileOrderFallout x_oMobileOrderFalloutRow)
        {
            return SetByDataSetRowProc(x_iROW, MobileOrderFallout.Para.TableName(), x_oDataSet,x_oMobileOrderFalloutRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderFallout x_oMobileOrderFalloutRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oMobileOrderFalloutRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderFallout x_oMobileOrderFalloutRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                MobileOrderFalloutInfo _oTableSet=MobileOrderFalloutInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderFallout.Para.active).AliasName))
                    x_oMobileOrderFalloutRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderFallout.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderFallout.Para.cdate).AliasName))
                    x_oMobileOrderFalloutRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderFallout.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderFallout.Para.cid).AliasName))
                    x_oMobileOrderFalloutRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderFallout.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderFallout.Para.did).AliasName))
                    x_oMobileOrderFalloutRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderFallout.Para.did).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderFallout.Para.ddate).AliasName))
                    x_oMobileOrderFalloutRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderFallout.Para.ddate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderFallout.Para.fo_reason).AliasName))
                    x_oMobileOrderFalloutRow.fo_reason = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderFallout.Para.fo_reason).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderFallout.Para.mid).AliasName))
                    x_oMobileOrderFalloutRow.mid = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderFallout.Para.mid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderFallout.Para.follow_by).AliasName))
                    x_oMobileOrderFalloutRow.follow_by = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderFallout.Para.follow_by).AliasName];
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
            return MobileOrderFalloutRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static MobileOrderFalloutEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return MobileOrderFalloutRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static MobileOrderFalloutEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return MobileOrderFalloutRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderFalloutRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderFalloutRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderFalloutRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,global::System.Nullable<DateTime> x_dDdate,string x_sFo_reason,string x_sFollow_by)
        {
            return MobileOrderFalloutRepository.Insert(x_oDB, x_bActive,x_dCdate,x_sCid,x_sDid,x_dDdate,x_sFo_reason,x_sFollow_by);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderFallout x_oMobileOrderFallout)
        {
            return MobileOrderFalloutRepository.InsertWithOutLastID(x_oDB,x_oMobileOrderFallout);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,global::System.Nullable<DateTime> x_dDdate,string x_sFo_reason,string x_sFollow_by)
        {
            return MobileOrderFalloutRepository.InsertReturnLastID_SP(x_oDB,x_bActive,x_dCdate,x_sCid,x_sDid,x_dDdate,x_sFo_reason,x_sFollow_by);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderFallout x_oMobileOrderFallout)
        {
            return MobileOrderFalloutRepository.InsertReturnLastID_SP(x_oDB,x_oMobileOrderFallout);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return MobileOrderFalloutRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderFalloutRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            return MobileOrderFalloutRepository.Delete(x_oDB, x_iMid);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(MobileOrderFallout x_oMobileOrderFalloutRow){
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


