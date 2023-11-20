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
///-- Create date: <Create Date 2011-02-02>
///-- Description:	<Description,Table :[MobileRetentionOrderAddRuleExceptionList],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileRetentionOrderAddRuleExceptionList] Business layer
    /// </summary>
    
    public abstract class MobileRetentionOrderAddRuleExceptionListBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public MobileRetentionOrderAddRuleExceptionListBalBase(){
        }
        ~MobileRetentionOrderAddRuleExceptionListBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(MobileRetentionOrderAddRuleExceptionList x_oMobileRetentionOrderAddRuleExceptionList)
        {
            return GetDataSet(x_oMobileRetentionOrderAddRuleExceptionList,null,MobileRetentionOrderAddRuleExceptionListInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileRetentionOrderAddRuleExceptionList x_oMobileRetentionOrderAddRuleExceptionList,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oMobileRetentionOrderAddRuleExceptionList,x_oMergeDSet,MobileRetentionOrderAddRuleExceptionListInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileRetentionOrderAddRuleExceptionList x_oMobileRetentionOrderAddRuleExceptionList,MobileRetentionOrderAddRuleExceptionListInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileRetentionOrderAddRuleExceptionList,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileRetentionOrderAddRuleExceptionList x_oMobileRetentionOrderAddRuleExceptionList,global::System.Data.DataSet x_oMergeDSet,MobileRetentionOrderAddRuleExceptionListInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileRetentionOrderAddRuleExceptionList,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(MobileRetentionOrderAddRuleExceptionList x_oMobileRetentionOrderAddRuleExceptionList,global::System.Data.DataSet x_oMergeDSet,MobileRetentionOrderAddRuleExceptionListInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileRetentionOrderAddRuleExceptionListInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(MobileRetentionOrderAddRuleExceptionList.Para.TableName());
            if (x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrderAddRuleExceptionList.Para.TableName()].Columns.Add(MobileRetentionOrderAddRuleExceptionList.Para.id); }
            if (x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrderAddRuleExceptionList.Para.TableName()].Columns.Add(MobileRetentionOrderAddRuleExceptionList.Para.cdate); }
            if (x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrderAddRuleExceptionList.Para.TableName()].Columns.Add(MobileRetentionOrderAddRuleExceptionList.Para.cid); }
            if (x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.mrt_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrderAddRuleExceptionList.Para.TableName()].Columns.Add(MobileRetentionOrderAddRuleExceptionList.Para.mrt_no); }
            if (x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrderAddRuleExceptionList.Para.TableName()].Columns.Add(MobileRetentionOrderAddRuleExceptionList.Para.active); }
            if (x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.filename).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrderAddRuleExceptionList.Para.TableName()].Columns.Add(MobileRetentionOrderAddRuleExceptionList.Para.filename); }
            if (x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.used).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrderAddRuleExceptionList.Para.TableName()].Columns.Add(MobileRetentionOrderAddRuleExceptionList.Para.used); }
            if (x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrderAddRuleExceptionList.Para.TableName()].Columns.Add(MobileRetentionOrderAddRuleExceptionList.Para.order_id); }
            if (x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrderAddRuleExceptionList.Para.TableName()].Columns.Add(MobileRetentionOrderAddRuleExceptionList.Para.ddate); }
            if (x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileRetentionOrderAddRuleExceptionList.Para.TableName()].Columns.Add(MobileRetentionOrderAddRuleExceptionList.Para.did); }
            if (x_oMobileRetentionOrderAddRuleExceptionList != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[MobileRetentionOrderAddRuleExceptionList.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrderAddRuleExceptionList.Para.id] = x_oMobileRetentionOrderAddRuleExceptionList.GetId(); }
                if (x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrderAddRuleExceptionList.Para.cdate] = x_oMobileRetentionOrderAddRuleExceptionList.GetCdate(); }
                if (x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrderAddRuleExceptionList.Para.cid] = x_oMobileRetentionOrderAddRuleExceptionList.GetCid(); }
                if (x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.mrt_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrderAddRuleExceptionList.Para.mrt_no] = x_oMobileRetentionOrderAddRuleExceptionList.GetMrt_no(); }
                if (x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrderAddRuleExceptionList.Para.active] = x_oMobileRetentionOrderAddRuleExceptionList.GetActive(); }
                if (x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.filename).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrderAddRuleExceptionList.Para.filename] = x_oMobileRetentionOrderAddRuleExceptionList.GetFilename(); }
                if (x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.used).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrderAddRuleExceptionList.Para.used] = x_oMobileRetentionOrderAddRuleExceptionList.GetUsed(); }
                if (x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrderAddRuleExceptionList.Para.order_id] = x_oMobileRetentionOrderAddRuleExceptionList.GetOrder_id(); }
                if (x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrderAddRuleExceptionList.Para.ddate] = x_oMobileRetentionOrderAddRuleExceptionList.GetDdate(); }
                if (x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileRetentionOrderAddRuleExceptionList.Para.did] = x_oMobileRetentionOrderAddRuleExceptionList.GetDid(); }
                _oDSet.Tables[MobileRetentionOrderAddRuleExceptionList.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(MobileRetentionOrderAddRuleExceptionListInfo x_oTableSet)
        {
            return MobileRetentionOrderAddRuleExceptionListBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return MobileRetentionOrderAddRuleExceptionListBal.ToEmptyDataSetProcess(MobileRetentionOrderAddRuleExceptionListInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(MobileRetentionOrderAddRuleExceptionListInfo x_oTableSet)
        {
            return MobileRetentionOrderAddRuleExceptionListBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(MobileRetentionOrderAddRuleExceptionList x_oMobileRetentionOrderAddRuleExceptionList, MobileRetentionOrderAddRuleExceptionListInfo x_oTableSet)
        {
            return MobileRetentionOrderAddRuleExceptionListBal.GetDataSet(null, null, x_oTableSet).Tables[MobileRetentionOrderAddRuleExceptionList.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(MobileRetentionOrderAddRuleExceptionList x_oMobileRetentionOrderAddRuleExceptionList)
        {
            return MobileRetentionOrderAddRuleExceptionListBal.GetDataSet(x_oMobileRetentionOrderAddRuleExceptionList, null, MobileRetentionOrderAddRuleExceptionListInfoDLL.CreateInfoInstanceObject()).Tables[MobileRetentionOrderAddRuleExceptionList.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,string x_sMrt_no,string x_sFilename)
        {
            return Row(x_oTable, x_oDB,x_sMrt_no,x_sFilename,MobileRetentionOrderAddRuleExceptionListInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,string x_sMrt_no,string x_sFilename, MobileRetentionOrderAddRuleExceptionListInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_sMrt_no,x_sFilename, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,string x_sMrt_no,string x_sFilename,MobileRetentionOrderAddRuleExceptionListInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileRetentionOrderAddRuleExceptionListInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [MobileRetentionOrderAddRuleExceptionList].[id] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ID,[MobileRetentionOrderAddRuleExceptionList].[cdate] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_CDATE,[MobileRetentionOrderAddRuleExceptionList].[cid] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_CID,[MobileRetentionOrderAddRuleExceptionList].[filename] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_FILENAME,[MobileRetentionOrderAddRuleExceptionList].[active] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ACTIVE,[MobileRetentionOrderAddRuleExceptionList].[mrt_no] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_MRT_NO,[MobileRetentionOrderAddRuleExceptionList].[used] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_USED,[MobileRetentionOrderAddRuleExceptionList].[order_id] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ORDER_ID,[MobileRetentionOrderAddRuleExceptionList].[ddate] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_DDATE,[MobileRetentionOrderAddRuleExceptionList].[did] AS MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_DID  FROM  [MobileRetentionOrderAddRuleExceptionList]  WHERE  [MobileRetentionOrderAddRuleExceptionList].[mrt_no] = \'"+x_sMrt_no.ToString()+"\'  AND  [MobileRetentionOrderAddRuleExceptionList].[filename] = \'"+x_sFilename.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileRetentionOrderAddRuleExceptionList]","["+ Configurator.MSSQLTablePrefix + "MobileRetentionOrderAddRuleExceptionList]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.cid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.cid).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.cid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.filename).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_FILENAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.filename).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.filename).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_FILENAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.filename).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.mrt_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_MRT_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.mrt_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.mrt_no).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_MRT_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.mrt_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.used).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_USED"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.used).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.used).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_USED"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.used).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.order_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ORDER_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.order_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.order_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_ORDER_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.order_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.ddate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.ddate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.did).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.did).AliasName].ToString()] = (string)_oData["MOBILERETENTIONORDERADDRULEEXCEPTIONLIST_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.did).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,MobileRetentionOrderAddRuleExceptionList x_oMobileRetentionOrderAddRuleExceptionListRow)
        {
            return SetByDataSetRowProc(x_iROW, MobileRetentionOrderAddRuleExceptionList.Para.TableName(), x_oDataSet,x_oMobileRetentionOrderAddRuleExceptionListRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileRetentionOrderAddRuleExceptionList x_oMobileRetentionOrderAddRuleExceptionListRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oMobileRetentionOrderAddRuleExceptionListRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileRetentionOrderAddRuleExceptionList x_oMobileRetentionOrderAddRuleExceptionListRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                MobileRetentionOrderAddRuleExceptionListInfo _oTableSet=MobileRetentionOrderAddRuleExceptionListInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.id).AliasName))
                    x_oMobileRetentionOrderAddRuleExceptionListRow.id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.cdate).AliasName))
                    x_oMobileRetentionOrderAddRuleExceptionListRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.cid).AliasName))
                    x_oMobileRetentionOrderAddRuleExceptionListRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.mrt_no).AliasName))
                    x_oMobileRetentionOrderAddRuleExceptionListRow.mrt_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.mrt_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.active).AliasName))
                    x_oMobileRetentionOrderAddRuleExceptionListRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.filename).AliasName))
                    x_oMobileRetentionOrderAddRuleExceptionListRow.filename = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.filename).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.used).AliasName))
                    x_oMobileRetentionOrderAddRuleExceptionListRow.used = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.used).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.order_id).AliasName))
                    x_oMobileRetentionOrderAddRuleExceptionListRow.order_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.order_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.ddate).AliasName))
                    x_oMobileRetentionOrderAddRuleExceptionListRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.ddate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.did).AliasName))
                    x_oMobileRetentionOrderAddRuleExceptionListRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileRetentionOrderAddRuleExceptionList.Para.did).AliasName];
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
            return MobileRetentionOrderAddRuleExceptionListRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static MobileRetentionOrderAddRuleExceptionListEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return MobileRetentionOrderAddRuleExceptionListRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static MobileRetentionOrderAddRuleExceptionListEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return MobileRetentionOrderAddRuleExceptionListRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileRetentionOrderAddRuleExceptionListRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileRetentionOrderAddRuleExceptionListRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return MobileRetentionOrderAddRuleExceptionListRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sMrt_no,global::System.Nullable<bool> x_bActive,string x_sFilename,global::System.Nullable<bool> x_bUsed,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dDdate,string x_sDid)
        {
            return MobileRetentionOrderAddRuleExceptionListRepository.Insert(x_oDB, x_dCdate,x_sCid,x_sMrt_no,x_bActive,x_sFilename,x_bUsed,x_iOrder_id,x_dDdate,x_sDid);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileRetentionOrderAddRuleExceptionList x_oMobileRetentionOrderAddRuleExceptionList)
        {
            return MobileRetentionOrderAddRuleExceptionListRepository.InsertWithOutLastID(x_oDB,x_oMobileRetentionOrderAddRuleExceptionList);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sMrt_no,global::System.Nullable<bool> x_bActive,string x_sFilename,global::System.Nullable<bool> x_bUsed,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dDdate,string x_sDid)
        {
            return MobileRetentionOrderAddRuleExceptionListRepository.InsertReturnLastID_SP(x_oDB,x_dCdate,x_sCid,x_sMrt_no,x_bActive,x_sFilename,x_bUsed,x_iOrder_id,x_dDdate,x_sDid);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileRetentionOrderAddRuleExceptionList x_oMobileRetentionOrderAddRuleExceptionList)
        {
            return MobileRetentionOrderAddRuleExceptionListRepository.InsertReturnLastID_SP(x_oDB,x_oMobileRetentionOrderAddRuleExceptionList);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return MobileRetentionOrderAddRuleExceptionListRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return MobileRetentionOrderAddRuleExceptionListRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,string x_sMrt_no,string x_sFilename)
        {
            return MobileRetentionOrderAddRuleExceptionListRepository.Delete(x_oDB, x_sMrt_no,x_sFilename);
        }
        
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return MobileRetentionOrderAddRuleExceptionListRepository.Delete(x_oDB, x_iId);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(MobileRetentionOrderAddRuleExceptionList x_oMobileRetentionOrderAddRuleExceptionListRow){
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


