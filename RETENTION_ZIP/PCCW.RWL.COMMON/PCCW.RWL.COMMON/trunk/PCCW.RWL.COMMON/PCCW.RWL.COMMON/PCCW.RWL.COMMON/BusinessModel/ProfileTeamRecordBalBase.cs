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
///-- Create date: <Create Date 2011-01-11>
///-- Description:	<Description,Table :[ProfileTeamRecord],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [ProfileTeamRecord] Business layer
    /// </summary>
    
    public abstract class ProfileTeamRecordBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public ProfileTeamRecordBalBase(){
        }
        ~ProfileTeamRecordBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(ProfileTeamRecord x_oProfileTeamRecord)
        {
            return GetDataSet(x_oProfileTeamRecord,null,ProfileTeamRecordInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(ProfileTeamRecord x_oProfileTeamRecord,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oProfileTeamRecord,x_oMergeDSet,ProfileTeamRecordInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(ProfileTeamRecord x_oProfileTeamRecord,ProfileTeamRecordInfo x_oTableSet)
        {
            return GetDataSet(x_oProfileTeamRecord,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(ProfileTeamRecord x_oProfileTeamRecord,global::System.Data.DataSet x_oMergeDSet,ProfileTeamRecordInfo x_oTableSet)
        {
            return GetDataSet(x_oProfileTeamRecord,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(ProfileTeamRecord x_oProfileTeamRecord,global::System.Data.DataSet x_oMergeDSet,ProfileTeamRecordInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = ProfileTeamRecordInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(ProfileTeamRecord.Para.TableName());
            if (x_oTableSet.Fields(ProfileTeamRecord.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProfileTeamRecord.Para.TableName()].Columns.Add(ProfileTeamRecord.Para.id); }
            if (x_oTableSet.Fields(ProfileTeamRecord.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProfileTeamRecord.Para.TableName()].Columns.Add(ProfileTeamRecord.Para.cdate); }
            if (x_oTableSet.Fields(ProfileTeamRecord.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProfileTeamRecord.Para.TableName()].Columns.Add(ProfileTeamRecord.Para.cid); }
            if (x_oTableSet.Fields(ProfileTeamRecord.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProfileTeamRecord.Para.TableName()].Columns.Add(ProfileTeamRecord.Para.did); }
            if (x_oTableSet.Fields(ProfileTeamRecord.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProfileTeamRecord.Para.TableName()].Columns.Add(ProfileTeamRecord.Para.active); }
            if (x_oTableSet.Fields(ProfileTeamRecord.Para.remark).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProfileTeamRecord.Para.TableName()].Columns.Add(ProfileTeamRecord.Para.remark); }
            if (x_oTableSet.Fields(ProfileTeamRecord.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProfileTeamRecord.Para.TableName()].Columns.Add(ProfileTeamRecord.Para.edate); }
            if (x_oTableSet.Fields(ProfileTeamRecord.Para.salesman_code).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProfileTeamRecord.Para.TableName()].Columns.Add(ProfileTeamRecord.Para.salesman_code); }
            if (x_oTableSet.Fields(ProfileTeamRecord.Para.staff_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProfileTeamRecord.Para.TableName()].Columns.Add(ProfileTeamRecord.Para.staff_no); }
            if (x_oTableSet.Fields(ProfileTeamRecord.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProfileTeamRecord.Para.TableName()].Columns.Add(ProfileTeamRecord.Para.ddate); }
            if (x_oTableSet.Fields(ProfileTeamRecord.Para.sdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProfileTeamRecord.Para.TableName()].Columns.Add(ProfileTeamRecord.Para.sdate); }
            if (x_oProfileTeamRecord != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[ProfileTeamRecord.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(ProfileTeamRecord.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProfileTeamRecord.Para.id] = x_oProfileTeamRecord.GetId(); }
                if (x_oTableSet.Fields(ProfileTeamRecord.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProfileTeamRecord.Para.cdate] = x_oProfileTeamRecord.GetCdate(); }
                if (x_oTableSet.Fields(ProfileTeamRecord.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProfileTeamRecord.Para.cid] = x_oProfileTeamRecord.GetCid(); }
                if (x_oTableSet.Fields(ProfileTeamRecord.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProfileTeamRecord.Para.did] = x_oProfileTeamRecord.GetDid(); }
                if (x_oTableSet.Fields(ProfileTeamRecord.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProfileTeamRecord.Para.active] = x_oProfileTeamRecord.GetActive(); }
                if (x_oTableSet.Fields(ProfileTeamRecord.Para.remark).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProfileTeamRecord.Para.remark] = x_oProfileTeamRecord.GetRemark(); }
                if (x_oTableSet.Fields(ProfileTeamRecord.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProfileTeamRecord.Para.edate] = x_oProfileTeamRecord.GetEdate(); }
                if (x_oTableSet.Fields(ProfileTeamRecord.Para.salesman_code).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProfileTeamRecord.Para.salesman_code] = x_oProfileTeamRecord.GetSalesman_code(); }
                if (x_oTableSet.Fields(ProfileTeamRecord.Para.staff_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProfileTeamRecord.Para.staff_no] = x_oProfileTeamRecord.GetStaff_no(); }
                if (x_oTableSet.Fields(ProfileTeamRecord.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProfileTeamRecord.Para.ddate] = x_oProfileTeamRecord.GetDdate(); }
                if (x_oTableSet.Fields(ProfileTeamRecord.Para.sdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProfileTeamRecord.Para.sdate] = x_oProfileTeamRecord.GetSdate(); }
                _oDSet.Tables[ProfileTeamRecord.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(ProfileTeamRecordInfo x_oTableSet)
        {
            return ProfileTeamRecordBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return ProfileTeamRecordBal.ToEmptyDataSetProcess(ProfileTeamRecordInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(ProfileTeamRecordInfo x_oTableSet)
        {
            return ProfileTeamRecordBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(ProfileTeamRecord x_oProfileTeamRecord, ProfileTeamRecordInfo x_oTableSet)
        {
            return ProfileTeamRecordBal.GetDataSet(null, null, x_oTableSet).Tables[ProfileTeamRecord.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(ProfileTeamRecord x_oProfileTeamRecord)
        {
            return ProfileTeamRecordBal.GetDataSet(x_oProfileTeamRecord, null, ProfileTeamRecordInfoDLL.CreateInfoInstanceObject()).Tables[ProfileTeamRecord.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return Row(x_oTable, x_oDB,x_iId,ProfileTeamRecordInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId, ProfileTeamRecordInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iId, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId,ProfileTeamRecordInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = ProfileTeamRecordInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [ProfileTeamRecord].[id] AS PROFILETEAMRECORD_ID,[ProfileTeamRecord].[cdate] AS PROFILETEAMRECORD_CDATE,[ProfileTeamRecord].[cid] AS PROFILETEAMRECORD_CID,[ProfileTeamRecord].[did] AS PROFILETEAMRECORD_DID,[ProfileTeamRecord].[active] AS PROFILETEAMRECORD_ACTIVE,[ProfileTeamRecord].[remark] AS PROFILETEAMRECORD_REMARK,[ProfileTeamRecord].[edate] AS PROFILETEAMRECORD_EDATE,[ProfileTeamRecord].[salesman_code] AS PROFILETEAMRECORD_SALESMAN_CODE,[ProfileTeamRecord].[staff_no] AS PROFILETEAMRECORD_STAFF_NO,[ProfileTeamRecord].[ddate] AS PROFILETEAMRECORD_DDATE,[ProfileTeamRecord].[sdate] AS PROFILETEAMRECORD_SDATE  FROM  [ProfileTeamRecord]  WHERE  [ProfileTeamRecord].[id] = \'"+x_iId.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProfileTeamRecord]","["+ Configurator.MSSQLTablePrefix + "ProfileTeamRecord]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(ProfileTeamRecord.Para.id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORD_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProfileTeamRecord.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecord.Para.id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["PROFILETEAMRECORD_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecord.Para.id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(ProfileTeamRecord.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORD_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProfileTeamRecord.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecord.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["PROFILETEAMRECORD_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecord.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(ProfileTeamRecord.Para.cid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORD_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProfileTeamRecord.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecord.Para.cid).AliasName].ToString()] = (string)_oData["PROFILETEAMRECORD_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecord.Para.cid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(ProfileTeamRecord.Para.did).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORD_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProfileTeamRecord.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecord.Para.did).AliasName].ToString()] = (string)_oData["PROFILETEAMRECORD_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecord.Para.did).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(ProfileTeamRecord.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORD_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProfileTeamRecord.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecord.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["PROFILETEAMRECORD_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecord.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(ProfileTeamRecord.Para.remark).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORD_REMARK"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProfileTeamRecord.Para.remark).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecord.Para.remark).AliasName].ToString()] = (string)_oData["PROFILETEAMRECORD_REMARK"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecord.Para.remark).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(ProfileTeamRecord.Para.edate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORD_EDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProfileTeamRecord.Para.edate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecord.Para.edate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["PROFILETEAMRECORD_EDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecord.Para.edate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(ProfileTeamRecord.Para.salesman_code).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORD_SALESMAN_CODE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProfileTeamRecord.Para.salesman_code).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecord.Para.salesman_code).AliasName].ToString()] = (string)_oData["PROFILETEAMRECORD_SALESMAN_CODE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecord.Para.salesman_code).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(ProfileTeamRecord.Para.staff_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORD_STAFF_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProfileTeamRecord.Para.staff_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecord.Para.staff_no).AliasName].ToString()] = (string)_oData["PROFILETEAMRECORD_STAFF_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecord.Para.staff_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(ProfileTeamRecord.Para.ddate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORD_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProfileTeamRecord.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecord.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["PROFILETEAMRECORD_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecord.Para.ddate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(ProfileTeamRecord.Para.sdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMRECORD_SDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProfileTeamRecord.Para.sdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecord.Para.sdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["PROFILETEAMRECORD_SDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProfileTeamRecord.Para.sdate).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,ProfileTeamRecord x_oProfileTeamRecordRow)
        {
            return SetByDataSetRowProc(x_iROW, ProfileTeamRecord.Para.TableName(), x_oDataSet,x_oProfileTeamRecordRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,ProfileTeamRecord x_oProfileTeamRecordRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oProfileTeamRecordRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,ProfileTeamRecord x_oProfileTeamRecordRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                ProfileTeamRecordInfo _oTableSet=ProfileTeamRecordInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProfileTeamRecord.Para.id).AliasName))
                    x_oProfileTeamRecordRow.id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProfileTeamRecord.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProfileTeamRecord.Para.cdate).AliasName))
                    x_oProfileTeamRecordRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProfileTeamRecord.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProfileTeamRecord.Para.cid).AliasName))
                    x_oProfileTeamRecordRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProfileTeamRecord.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProfileTeamRecord.Para.did).AliasName))
                    x_oProfileTeamRecordRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProfileTeamRecord.Para.did).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProfileTeamRecord.Para.active).AliasName))
                    x_oProfileTeamRecordRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProfileTeamRecord.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProfileTeamRecord.Para.remark).AliasName))
                    x_oProfileTeamRecordRow.remark = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProfileTeamRecord.Para.remark).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProfileTeamRecord.Para.edate).AliasName))
                    x_oProfileTeamRecordRow.edate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProfileTeamRecord.Para.edate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProfileTeamRecord.Para.salesman_code).AliasName))
                    x_oProfileTeamRecordRow.salesman_code = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProfileTeamRecord.Para.salesman_code).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProfileTeamRecord.Para.staff_no).AliasName))
                    x_oProfileTeamRecordRow.staff_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProfileTeamRecord.Para.staff_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProfileTeamRecord.Para.ddate).AliasName))
                    x_oProfileTeamRecordRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProfileTeamRecord.Para.ddate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProfileTeamRecord.Para.sdate).AliasName))
                    x_oProfileTeamRecordRow.sdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProfileTeamRecord.Para.sdate).AliasName];
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
            return ProfileTeamRecordRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static ProfileTeamRecordEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return ProfileTeamRecordRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static ProfileTeamRecordEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return ProfileTeamRecordRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return ProfileTeamRecordRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return ProfileTeamRecordRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return ProfileTeamRecordRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,global::System.Nullable<bool> x_bActive,string x_sRemark,global::System.Nullable<DateTime> x_dEdate,string x_sSalesman_code,string x_sStaff_no,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<DateTime> x_dSdate)
        {
            return ProfileTeamRecordRepository.Insert(x_oDB, x_dCdate,x_sCid,x_sDid,x_bActive,x_sRemark,x_dEdate,x_sSalesman_code,x_sStaff_no,x_dDdate,x_dSdate);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,ProfileTeamRecord x_oProfileTeamRecord)
        {
            return ProfileTeamRecordRepository.InsertWithOutLastID(x_oDB,x_oProfileTeamRecord);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,global::System.Nullable<bool> x_bActive,string x_sRemark,global::System.Nullable<DateTime> x_dEdate,string x_sSalesman_code,string x_sStaff_no,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<DateTime> x_dSdate)
        {
            return ProfileTeamRecordRepository.InsertReturnLastID_SP(x_oDB,x_dCdate,x_sCid,x_sDid,x_bActive,x_sRemark,x_dEdate,x_sSalesman_code,x_sStaff_no,x_dDdate,x_dSdate);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, ProfileTeamRecord x_oProfileTeamRecord)
        {
            return ProfileTeamRecordRepository.InsertReturnLastID_SP(x_oDB,x_oProfileTeamRecord);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return ProfileTeamRecordRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return ProfileTeamRecordRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return ProfileTeamRecordRepository.Delete(x_oDB, x_iId);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(ProfileTeamRecord x_oProfileTeamRecordRow){
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


