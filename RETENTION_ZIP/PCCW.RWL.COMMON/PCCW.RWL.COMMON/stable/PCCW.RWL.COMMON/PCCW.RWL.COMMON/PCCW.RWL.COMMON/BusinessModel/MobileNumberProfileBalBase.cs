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
///-- Create date: <Create Date 2011-09-01>
///-- Description:	<Description,Table :[MobileNumberProfile],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileNumberProfile] Business layer
    /// </summary>
    
    public abstract class MobileNumberProfileBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public MobileNumberProfileBalBase(){
        }
        ~MobileNumberProfileBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(MobileNumberProfile x_oMobileNumberProfile)
        {
            return GetDataSet(x_oMobileNumberProfile,null,MobileNumberProfileInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileNumberProfile x_oMobileNumberProfile,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oMobileNumberProfile,x_oMergeDSet,MobileNumberProfileInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileNumberProfile x_oMobileNumberProfile,MobileNumberProfileInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileNumberProfile,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileNumberProfile x_oMobileNumberProfile,global::System.Data.DataSet x_oMergeDSet,MobileNumberProfileInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileNumberProfile,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(MobileNumberProfile x_oMobileNumberProfile,global::System.Data.DataSet x_oMergeDSet,MobileNumberProfileInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileNumberProfileInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(MobileNumberProfile.Para.TableName());
            if (x_oTableSet.Fields(MobileNumberProfile.Para.pool).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileNumberProfile.Para.TableName()].Columns.Add(MobileNumberProfile.Para.pool); }
            if (x_oTableSet.Fields(MobileNumberProfile.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileNumberProfile.Para.TableName()].Columns.Add(MobileNumberProfile.Para.id); }
            if (x_oTableSet.Fields(MobileNumberProfile.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileNumberProfile.Para.TableName()].Columns.Add(MobileNumberProfile.Para.cdate); }
            if (x_oTableSet.Fields(MobileNumberProfile.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileNumberProfile.Para.TableName()].Columns.Add(MobileNumberProfile.Para.cid); }
            if (x_oTableSet.Fields(MobileNumberProfile.Para.mrt_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileNumberProfile.Para.TableName()].Columns.Add(MobileNumberProfile.Para.mrt_no); }
            if (x_oTableSet.Fields(MobileNumberProfile.Para.status).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileNumberProfile.Para.TableName()].Columns.Add(MobileNumberProfile.Para.status); }
            if (x_oTableSet.Fields(MobileNumberProfile.Para.mrt_group).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileNumberProfile.Para.TableName()].Columns.Add(MobileNumberProfile.Para.mrt_group); }
            if (x_oTableSet.Fields(MobileNumberProfile.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileNumberProfile.Para.TableName()].Columns.Add(MobileNumberProfile.Para.active); }
            if (x_oTableSet.Fields(MobileNumberProfile.Para.edf_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileNumberProfile.Para.TableName()].Columns.Add(MobileNumberProfile.Para.edf_no); }
            if (x_oTableSet.Fields(MobileNumberProfile.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileNumberProfile.Para.TableName()].Columns.Add(MobileNumberProfile.Para.order_id); }
            if (x_oTableSet.Fields(MobileNumberProfile.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileNumberProfile.Para.TableName()].Columns.Add(MobileNumberProfile.Para.ddate); }
            if (x_oTableSet.Fields(MobileNumberProfile.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileNumberProfile.Para.TableName()].Columns.Add(MobileNumberProfile.Para.did); }
            if (x_oMobileNumberProfile != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[MobileNumberProfile.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(MobileNumberProfile.Para.pool).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileNumberProfile.Para.pool] = x_oMobileNumberProfile.GetPool(); }
                if (x_oTableSet.Fields(MobileNumberProfile.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileNumberProfile.Para.id] = x_oMobileNumberProfile.GetId(); }
                if (x_oTableSet.Fields(MobileNumberProfile.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileNumberProfile.Para.cdate] = x_oMobileNumberProfile.GetCdate(); }
                if (x_oTableSet.Fields(MobileNumberProfile.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileNumberProfile.Para.cid] = x_oMobileNumberProfile.GetCid(); }
                if (x_oTableSet.Fields(MobileNumberProfile.Para.mrt_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileNumberProfile.Para.mrt_no] = x_oMobileNumberProfile.GetMrt_no(); }
                if (x_oTableSet.Fields(MobileNumberProfile.Para.status).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileNumberProfile.Para.status] = x_oMobileNumberProfile.GetStatus(); }
                if (x_oTableSet.Fields(MobileNumberProfile.Para.mrt_group).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileNumberProfile.Para.mrt_group] = x_oMobileNumberProfile.GetMrt_group(); }
                if (x_oTableSet.Fields(MobileNumberProfile.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileNumberProfile.Para.active] = x_oMobileNumberProfile.GetActive(); }
                if (x_oTableSet.Fields(MobileNumberProfile.Para.edf_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileNumberProfile.Para.edf_no] = x_oMobileNumberProfile.GetEdf_no(); }
                if (x_oTableSet.Fields(MobileNumberProfile.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileNumberProfile.Para.order_id] = x_oMobileNumberProfile.GetOrder_id(); }
                if (x_oTableSet.Fields(MobileNumberProfile.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileNumberProfile.Para.ddate] = x_oMobileNumberProfile.GetDdate(); }
                if (x_oTableSet.Fields(MobileNumberProfile.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileNumberProfile.Para.did] = x_oMobileNumberProfile.GetDid(); }
                _oDSet.Tables[MobileNumberProfile.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(MobileNumberProfileInfo x_oTableSet)
        {
            return MobileNumberProfileBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return MobileNumberProfileBal.ToEmptyDataSetProcess(MobileNumberProfileInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(MobileNumberProfileInfo x_oTableSet)
        {
            return MobileNumberProfileBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(MobileNumberProfile x_oMobileNumberProfile, MobileNumberProfileInfo x_oTableSet)
        {
            return MobileNumberProfileBal.GetDataSet(null, null, x_oTableSet).Tables[MobileNumberProfile.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(MobileNumberProfile x_oMobileNumberProfile)
        {
            return MobileNumberProfileBal.GetDataSet(x_oMobileNumberProfile, null, MobileNumberProfileInfoDLL.CreateInfoInstanceObject()).Tables[MobileNumberProfile.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return Row(x_oTable, x_oDB,x_iId,MobileNumberProfileInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId, MobileNumberProfileInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iId, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId,MobileNumberProfileInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileNumberProfileInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [MobileNumberProfile].[cid] AS MOBILENUMBERPROFILE_CID,[MobileNumberProfile].[id] AS MOBILENUMBERPROFILE_ID,[MobileNumberProfile].[cdate] AS MOBILENUMBERPROFILE_CDATE,[MobileNumberProfile].[pool] AS MOBILENUMBERPROFILE_POOL,[MobileNumberProfile].[mrt_no] AS MOBILENUMBERPROFILE_MRT_NO,[MobileNumberProfile].[status] AS MOBILENUMBERPROFILE_STATUS,[MobileNumberProfile].[mrt_group] AS MOBILENUMBERPROFILE_MRT_GROUP,[MobileNumberProfile].[active] AS MOBILENUMBERPROFILE_ACTIVE,[MobileNumberProfile].[edf_no] AS MOBILENUMBERPROFILE_EDF_NO,[MobileNumberProfile].[order_id] AS MOBILENUMBERPROFILE_ORDER_ID,[MobileNumberProfile].[ddate] AS MOBILENUMBERPROFILE_DDATE,[MobileNumberProfile].[did] AS MOBILENUMBERPROFILE_DID  FROM  [MobileNumberProfile]  WHERE  [MobileNumberProfile].[id] = \'"+x_iId.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileNumberProfile]","["+ Configurator.MSSQLTablePrefix + "MobileNumberProfile]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(MobileNumberProfile.Para.cid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileNumberProfile.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileNumberProfile.Para.cid).AliasName].ToString()] = (string)_oData["MOBILENUMBERPROFILE_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileNumberProfile.Para.cid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileNumberProfile.Para.id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileNumberProfile.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileNumberProfile.Para.id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILENUMBERPROFILE_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileNumberProfile.Para.id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileNumberProfile.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileNumberProfile.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileNumberProfile.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILENUMBERPROFILE_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileNumberProfile.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileNumberProfile.Para.pool).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_POOL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileNumberProfile.Para.pool).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileNumberProfile.Para.pool).AliasName].ToString()] = (string)_oData["MOBILENUMBERPROFILE_POOL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileNumberProfile.Para.pool).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileNumberProfile.Para.mrt_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_MRT_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileNumberProfile.Para.mrt_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileNumberProfile.Para.mrt_no).AliasName].ToString()] = (global::System.Nullable<long>)_oData["MOBILENUMBERPROFILE_MRT_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileNumberProfile.Para.mrt_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileNumberProfile.Para.status).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_STATUS"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileNumberProfile.Para.status).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileNumberProfile.Para.status).AliasName].ToString()] = (string)_oData["MOBILENUMBERPROFILE_STATUS"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileNumberProfile.Para.status).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileNumberProfile.Para.mrt_group).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_MRT_GROUP"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileNumberProfile.Para.mrt_group).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileNumberProfile.Para.mrt_group).AliasName].ToString()] = (string)_oData["MOBILENUMBERPROFILE_MRT_GROUP"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileNumberProfile.Para.mrt_group).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileNumberProfile.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileNumberProfile.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileNumberProfile.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILENUMBERPROFILE_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileNumberProfile.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileNumberProfile.Para.edf_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_EDF_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileNumberProfile.Para.edf_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileNumberProfile.Para.edf_no).AliasName].ToString()] = (string)_oData["MOBILENUMBERPROFILE_EDF_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileNumberProfile.Para.edf_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileNumberProfile.Para.order_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_ORDER_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileNumberProfile.Para.order_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileNumberProfile.Para.order_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILENUMBERPROFILE_ORDER_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileNumberProfile.Para.order_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileNumberProfile.Para.ddate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileNumberProfile.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileNumberProfile.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILENUMBERPROFILE_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileNumberProfile.Para.ddate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileNumberProfile.Para.did).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileNumberProfile.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileNumberProfile.Para.did).AliasName].ToString()] = (string)_oData["MOBILENUMBERPROFILE_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileNumberProfile.Para.did).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,MobileNumberProfile x_oMobileNumberProfileRow)
        {
            return SetByDataSetRowProc(x_iROW, MobileNumberProfile.Para.TableName(), x_oDataSet,x_oMobileNumberProfileRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileNumberProfile x_oMobileNumberProfileRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oMobileNumberProfileRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileNumberProfile x_oMobileNumberProfileRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                MobileNumberProfileInfo _oTableSet=MobileNumberProfileInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileNumberProfile.Para.pool).AliasName))
                    x_oMobileNumberProfileRow.pool = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileNumberProfile.Para.pool).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileNumberProfile.Para.id).AliasName))
                    x_oMobileNumberProfileRow.id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileNumberProfile.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileNumberProfile.Para.cdate).AliasName))
                    x_oMobileNumberProfileRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileNumberProfile.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileNumberProfile.Para.cid).AliasName))
                    x_oMobileNumberProfileRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileNumberProfile.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileNumberProfile.Para.mrt_no).AliasName))
                    x_oMobileNumberProfileRow.mrt_no = (global::System.Nullable<long>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileNumberProfile.Para.mrt_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileNumberProfile.Para.status).AliasName))
                    x_oMobileNumberProfileRow.status = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileNumberProfile.Para.status).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileNumberProfile.Para.mrt_group).AliasName))
                    x_oMobileNumberProfileRow.mrt_group = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileNumberProfile.Para.mrt_group).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileNumberProfile.Para.active).AliasName))
                    x_oMobileNumberProfileRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileNumberProfile.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileNumberProfile.Para.edf_no).AliasName))
                    x_oMobileNumberProfileRow.edf_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileNumberProfile.Para.edf_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileNumberProfile.Para.order_id).AliasName))
                    x_oMobileNumberProfileRow.order_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileNumberProfile.Para.order_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileNumberProfile.Para.ddate).AliasName))
                    x_oMobileNumberProfileRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileNumberProfile.Para.ddate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileNumberProfile.Para.did).AliasName))
                    x_oMobileNumberProfileRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileNumberProfile.Para.did).AliasName];
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
            return MobileNumberProfileRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static MobileNumberProfileEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return MobileNumberProfileRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static MobileNumberProfileEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return MobileNumberProfileRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileNumberProfileRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileNumberProfileRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return MobileNumberProfileRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sPool,global::System.Nullable<DateTime> x_dCdate,string x_sCid,global::System.Nullable<long> x_lMrt_no,string x_sStatus,string x_sMrt_group,global::System.Nullable<bool> x_bActive,string x_sEdf_no,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dDdate,string x_sDid)
        {
            return MobileNumberProfileRepository.Insert(x_oDB, x_sPool,x_dCdate,x_sCid,x_lMrt_no,x_sStatus,x_sMrt_group,x_bActive,x_sEdf_no,x_iOrder_id,x_dDdate,x_sDid);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileNumberProfile x_oMobileNumberProfile)
        {
            return MobileNumberProfileRepository.InsertWithOutLastID(x_oDB,x_oMobileNumberProfile);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sPool,global::System.Nullable<DateTime> x_dCdate,string x_sCid,global::System.Nullable<long> x_lMrt_no,string x_sStatus,string x_sMrt_group,global::System.Nullable<bool> x_bActive,string x_sEdf_no,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dDdate,string x_sDid)
        {
            return MobileNumberProfileRepository.InsertReturnLastID_SP(x_oDB,x_sPool,x_dCdate,x_sCid,x_lMrt_no,x_sStatus,x_sMrt_group,x_bActive,x_sEdf_no,x_iOrder_id,x_dDdate,x_sDid);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileNumberProfile x_oMobileNumberProfile)
        {
            return MobileNumberProfileRepository.InsertReturnLastID_SP(x_oDB,x_oMobileNumberProfile);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return MobileNumberProfileRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return MobileNumberProfileRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return MobileNumberProfileRepository.Delete(x_oDB, x_iId);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(MobileNumberProfile x_oMobileNumberProfileRow){
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


