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
///-- Create date: <Create Date 2011-03-08>
///-- Description:	<Description,Table :[MobileOrderVasRevision],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderVasRevision] Business layer
    /// </summary>
    
    public abstract class MobileOrderVasRevisionBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public MobileOrderVasRevisionBalBase(){
        }
        ~MobileOrderVasRevisionBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderVasRevision x_oMobileOrderVasRevision)
        {
            return GetDataSet(x_oMobileOrderVasRevision,null,MobileOrderVasRevisionInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderVasRevision x_oMobileOrderVasRevision,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oMobileOrderVasRevision,x_oMergeDSet,MobileOrderVasRevisionInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderVasRevision x_oMobileOrderVasRevision,MobileOrderVasRevisionInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderVasRevision,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderVasRevision x_oMobileOrderVasRevision,global::System.Data.DataSet x_oMergeDSet,MobileOrderVasRevisionInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderVasRevision,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(MobileOrderVasRevision x_oMobileOrderVasRevision,global::System.Data.DataSet x_oMergeDSet,MobileOrderVasRevisionInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderVasRevisionInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(MobileOrderVasRevision.Para.TableName());
            if (x_oTableSet.Fields(MobileOrderVasRevision.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderVasRevision.Para.TableName()].Columns.Add(MobileOrderVasRevision.Para.id); }
            if (x_oTableSet.Fields(MobileOrderVasRevision.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderVasRevision.Para.TableName()].Columns.Add(MobileOrderVasRevision.Para.cdate); }
            if (x_oTableSet.Fields(MobileOrderVasRevision.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderVasRevision.Para.TableName()].Columns.Add(MobileOrderVasRevision.Para.active); }
            if (x_oTableSet.Fields(MobileOrderVasRevision.Para.vas_field).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderVasRevision.Para.TableName()].Columns.Add(MobileOrderVasRevision.Para.vas_field); }
            if (x_oTableSet.Fields(MobileOrderVasRevision.Para.vas_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderVasRevision.Para.TableName()].Columns.Add(MobileOrderVasRevision.Para.vas_id); }
            if (x_oTableSet.Fields(MobileOrderVasRevision.Para.his_order_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderVasRevision.Para.TableName()].Columns.Add(MobileOrderVasRevision.Para.his_order_id); }
            if (x_oTableSet.Fields(MobileOrderVasRevision.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderVasRevision.Para.TableName()].Columns.Add(MobileOrderVasRevision.Para.order_id); }
            if (x_oTableSet.Fields(MobileOrderVasRevision.Para.fee).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderVasRevision.Para.TableName()].Columns.Add(MobileOrderVasRevision.Para.fee); }
            if (x_oTableSet.Fields(MobileOrderVasRevision.Para.vas_value).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderVasRevision.Para.TableName()].Columns.Add(MobileOrderVasRevision.Para.vas_value); }
            if (x_oTableSet.Fields(MobileOrderVasRevision.Para.multi_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderVasRevision.Para.TableName()].Columns.Add(MobileOrderVasRevision.Para.multi_id); }
            if (x_oMobileOrderVasRevision != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[MobileOrderVasRevision.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(MobileOrderVasRevision.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderVasRevision.Para.id] = x_oMobileOrderVasRevision.GetId(); }
                if (x_oTableSet.Fields(MobileOrderVasRevision.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderVasRevision.Para.cdate] = x_oMobileOrderVasRevision.GetCdate(); }
                if (x_oTableSet.Fields(MobileOrderVasRevision.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderVasRevision.Para.active] = x_oMobileOrderVasRevision.GetActive(); }
                if (x_oTableSet.Fields(MobileOrderVasRevision.Para.vas_field).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderVasRevision.Para.vas_field] = x_oMobileOrderVasRevision.GetVas_field(); }
                if (x_oTableSet.Fields(MobileOrderVasRevision.Para.vas_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderVasRevision.Para.vas_id] = x_oMobileOrderVasRevision.GetVas_id(); }
                if (x_oTableSet.Fields(MobileOrderVasRevision.Para.his_order_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderVasRevision.Para.his_order_id] = x_oMobileOrderVasRevision.GetHis_order_id(); }
                if (x_oTableSet.Fields(MobileOrderVasRevision.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderVasRevision.Para.order_id] = x_oMobileOrderVasRevision.GetOrder_id(); }
                if (x_oTableSet.Fields(MobileOrderVasRevision.Para.fee).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderVasRevision.Para.fee] = x_oMobileOrderVasRevision.GetFee(); }
                if (x_oTableSet.Fields(MobileOrderVasRevision.Para.vas_value).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderVasRevision.Para.vas_value] = x_oMobileOrderVasRevision.GetVas_value(); }
                if (x_oTableSet.Fields(MobileOrderVasRevision.Para.multi_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderVasRevision.Para.multi_id] = x_oMobileOrderVasRevision.GetMulti_id(); }
                _oDSet.Tables[MobileOrderVasRevision.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(MobileOrderVasRevisionInfo x_oTableSet)
        {
            return MobileOrderVasRevisionBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return MobileOrderVasRevisionBal.ToEmptyDataSetProcess(MobileOrderVasRevisionInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(MobileOrderVasRevisionInfo x_oTableSet)
        {
            return MobileOrderVasRevisionBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(MobileOrderVasRevision x_oMobileOrderVasRevision, MobileOrderVasRevisionInfo x_oTableSet)
        {
            return MobileOrderVasRevisionBal.GetDataSet(null, null, x_oTableSet).Tables[MobileOrderVasRevision.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(MobileOrderVasRevision x_oMobileOrderVasRevision)
        {
            return MobileOrderVasRevisionBal.GetDataSet(x_oMobileOrderVasRevision, null, MobileOrderVasRevisionInfoDLL.CreateInfoInstanceObject()).Tables[MobileOrderVasRevision.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return Row(x_oTable, x_oDB,x_iId,MobileOrderVasRevisionInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId, MobileOrderVasRevisionInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iId, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId,MobileOrderVasRevisionInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderVasRevisionInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [MobileOrderVasRevision].[id] AS MOBILEORDERVASREVISION_ID,[MobileOrderVasRevision].[cdate] AS MOBILEORDERVASREVISION_CDATE,[MobileOrderVasRevision].[active] AS MOBILEORDERVASREVISION_ACTIVE,[MobileOrderVasRevision].[multi_id] AS MOBILEORDERVASREVISION_MULTI_ID,[MobileOrderVasRevision].[vas_field] AS MOBILEORDERVASREVISION_VAS_FIELD,[MobileOrderVasRevision].[vas_id] AS MOBILEORDERVASREVISION_VAS_ID,[MobileOrderVasRevision].[his_order_id] AS MOBILEORDERVASREVISION_HIS_ORDER_ID,[MobileOrderVasRevision].[order_id] AS MOBILEORDERVASREVISION_ORDER_ID,[MobileOrderVasRevision].[fee] AS MOBILEORDERVASREVISION_FEE,[MobileOrderVasRevision].[vas_value] AS MOBILEORDERVASREVISION_VAS_VALUE  FROM  [MobileOrderVasRevision]  WHERE  [MobileOrderVasRevision].[id] = \'"+x_iId.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderVasRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderVasRevision]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(MobileOrderVasRevision.Para.id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVASREVISION_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderVasRevision.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVasRevision.Para.id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERVASREVISION_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVasRevision.Para.id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderVasRevision.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVASREVISION_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderVasRevision.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVasRevision.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERVASREVISION_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVasRevision.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderVasRevision.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVASREVISION_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderVasRevision.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVasRevision.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILEORDERVASREVISION_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVasRevision.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderVasRevision.Para.multi_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVASREVISION_MULTI_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderVasRevision.Para.multi_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVasRevision.Para.multi_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERVASREVISION_MULTI_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVasRevision.Para.multi_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderVasRevision.Para.vas_field).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVASREVISION_VAS_FIELD"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderVasRevision.Para.vas_field).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVasRevision.Para.vas_field).AliasName].ToString()] = (string)_oData["MOBILEORDERVASREVISION_VAS_FIELD"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVasRevision.Para.vas_field).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderVasRevision.Para.vas_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVASREVISION_VAS_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderVasRevision.Para.vas_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVasRevision.Para.vas_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERVASREVISION_VAS_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVasRevision.Para.vas_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderVasRevision.Para.his_order_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVASREVISION_HIS_ORDER_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderVasRevision.Para.his_order_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVasRevision.Para.his_order_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERVASREVISION_HIS_ORDER_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVasRevision.Para.his_order_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderVasRevision.Para.order_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVASREVISION_ORDER_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderVasRevision.Para.order_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVasRevision.Para.order_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERVASREVISION_ORDER_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVasRevision.Para.order_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderVasRevision.Para.fee).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVASREVISION_FEE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderVasRevision.Para.fee).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVasRevision.Para.fee).AliasName].ToString()] = (string)_oData["MOBILEORDERVASREVISION_FEE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVasRevision.Para.fee).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderVasRevision.Para.vas_value).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVASREVISION_VAS_VALUE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderVasRevision.Para.vas_value).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVasRevision.Para.vas_value).AliasName].ToString()] = (string)_oData["MOBILEORDERVASREVISION_VAS_VALUE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVasRevision.Para.vas_value).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,MobileOrderVasRevision x_oMobileOrderVasRevisionRow)
        {
            return SetByDataSetRowProc(x_iROW, MobileOrderVasRevision.Para.TableName(), x_oDataSet,x_oMobileOrderVasRevisionRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderVasRevision x_oMobileOrderVasRevisionRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oMobileOrderVasRevisionRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderVasRevision x_oMobileOrderVasRevisionRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                MobileOrderVasRevisionInfo _oTableSet=MobileOrderVasRevisionInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderVasRevision.Para.id).AliasName))
                    x_oMobileOrderVasRevisionRow.id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderVasRevision.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderVasRevision.Para.cdate).AliasName))
                    x_oMobileOrderVasRevisionRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderVasRevision.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderVasRevision.Para.active).AliasName))
                    x_oMobileOrderVasRevisionRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderVasRevision.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderVasRevision.Para.vas_field).AliasName))
                    x_oMobileOrderVasRevisionRow.vas_field = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderVasRevision.Para.vas_field).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderVasRevision.Para.vas_id).AliasName))
                    x_oMobileOrderVasRevisionRow.vas_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderVasRevision.Para.vas_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderVasRevision.Para.his_order_id).AliasName))
                    x_oMobileOrderVasRevisionRow.his_order_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderVasRevision.Para.his_order_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderVasRevision.Para.order_id).AliasName))
                    x_oMobileOrderVasRevisionRow.order_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderVasRevision.Para.order_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderVasRevision.Para.fee).AliasName))
                    x_oMobileOrderVasRevisionRow.fee = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderVasRevision.Para.fee).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderVasRevision.Para.vas_value).AliasName))
                    x_oMobileOrderVasRevisionRow.vas_value = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderVasRevision.Para.vas_value).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderVasRevision.Para.multi_id).AliasName))
                    x_oMobileOrderVasRevisionRow.multi_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderVasRevision.Para.multi_id).AliasName];
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
            return MobileOrderVasRevisionRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static MobileOrderVasRevisionEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return MobileOrderVasRevisionRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static MobileOrderVasRevisionEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return MobileOrderVasRevisionRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderVasRevisionRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderVasRevisionRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderVasRevisionRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate,global::System.Nullable<bool> x_bActive,string x_sVas_field,global::System.Nullable<int> x_iVas_id,global::System.Nullable<int> x_iHis_order_id,global::System.Nullable<int> x_iOrder_id,string x_sFee,string x_sVas_value,global::System.Nullable<int> x_iMulti_id)
        {
            return MobileOrderVasRevisionRepository.Insert(x_oDB, x_dCdate,x_bActive,x_sVas_field,x_iVas_id,x_iHis_order_id,x_iOrder_id,x_sFee,x_sVas_value,x_iMulti_id);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderVasRevision x_oMobileOrderVasRevision)
        {
            return MobileOrderVasRevisionRepository.InsertWithOutLastID(x_oDB,x_oMobileOrderVasRevision);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,global::System.Nullable<bool> x_bActive,string x_sVas_field,global::System.Nullable<int> x_iVas_id,global::System.Nullable<int> x_iHis_order_id,global::System.Nullable<int> x_iOrder_id,string x_sFee,string x_sVas_value,global::System.Nullable<int> x_iMulti_id)
        {
            return MobileOrderVasRevisionRepository.InsertReturnLastID_SP(x_oDB,x_dCdate,x_bActive,x_sVas_field,x_iVas_id,x_iHis_order_id,x_iOrder_id,x_sFee,x_sVas_value,x_iMulti_id);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderVasRevision x_oMobileOrderVasRevision)
        {
            return MobileOrderVasRevisionRepository.InsertReturnLastID_SP(x_oDB,x_oMobileOrderVasRevision);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return MobileOrderVasRevisionRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderVasRevisionRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return MobileOrderVasRevisionRepository.Delete(x_oDB, x_iId);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(MobileOrderVasRevision x_oMobileOrderVasRevisionRow){
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


