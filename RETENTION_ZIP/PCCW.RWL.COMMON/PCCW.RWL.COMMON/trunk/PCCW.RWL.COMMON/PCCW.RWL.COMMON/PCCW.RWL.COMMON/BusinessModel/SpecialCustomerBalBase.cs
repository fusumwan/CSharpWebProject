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
///-- Create date: <Create Date 2010-04-19>
///-- Description:	<Description,Table :[SpecialCustomer],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [SpecialCustomer] Business layer
    /// </summary>
    
    public abstract class SpecialCustomerBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public SpecialCustomerBalBase(){
        }
        ~SpecialCustomerBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(SpecialCustomer x_oSpecialCustomer)
        {
            return GetDataSet(x_oSpecialCustomer,null,SpecialCustomerInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(SpecialCustomer x_oSpecialCustomer,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oSpecialCustomer,x_oMergeDSet,SpecialCustomerInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(SpecialCustomer x_oSpecialCustomer,SpecialCustomerInfo x_oTableSet)
        {
            return GetDataSet(x_oSpecialCustomer,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(SpecialCustomer x_oSpecialCustomer,global::System.Data.DataSet x_oMergeDSet,SpecialCustomerInfo x_oTableSet)
        {
            return GetDataSet(x_oSpecialCustomer,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(SpecialCustomer x_oSpecialCustomer,global::System.Data.DataSet x_oMergeDSet,SpecialCustomerInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = SpecialCustomerInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(SpecialCustomer.Para.TableName());
            if (x_oTableSet.Fields(SpecialCustomer.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[SpecialCustomer.Para.TableName()].Columns.Add(SpecialCustomer.Para.id); }
            if (x_oTableSet.Fields(SpecialCustomer.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[SpecialCustomer.Para.TableName()].Columns.Add(SpecialCustomer.Para.cdate); }
            if (x_oTableSet.Fields(SpecialCustomer.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[SpecialCustomer.Para.TableName()].Columns.Add(SpecialCustomer.Para.cid); }
            if (x_oTableSet.Fields(SpecialCustomer.Para.condition4).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[SpecialCustomer.Para.TableName()].Columns.Add(SpecialCustomer.Para.condition4); }
            if (x_oTableSet.Fields(SpecialCustomer.Para.status).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[SpecialCustomer.Para.TableName()].Columns.Add(SpecialCustomer.Para.status); }
            if (x_oTableSet.Fields(SpecialCustomer.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[SpecialCustomer.Para.TableName()].Columns.Add(SpecialCustomer.Para.active); }
            if (x_oTableSet.Fields(SpecialCustomer.Para.condition3).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[SpecialCustomer.Para.TableName()].Columns.Add(SpecialCustomer.Para.condition3); }
            if (x_oTableSet.Fields(SpecialCustomer.Para.condition5).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[SpecialCustomer.Para.TableName()].Columns.Add(SpecialCustomer.Para.condition5); }
            if (x_oTableSet.Fields(SpecialCustomer.Para.hkid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[SpecialCustomer.Para.TableName()].Columns.Add(SpecialCustomer.Para.hkid); }
            if (x_oTableSet.Fields(SpecialCustomer.Para.condition1).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[SpecialCustomer.Para.TableName()].Columns.Add(SpecialCustomer.Para.condition1); }
            if (x_oTableSet.Fields(SpecialCustomer.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[SpecialCustomer.Para.TableName()].Columns.Add(SpecialCustomer.Para.ddate); }
            if (x_oTableSet.Fields(SpecialCustomer.Para.count).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[SpecialCustomer.Para.TableName()].Columns.Add(SpecialCustomer.Para.count); }
            if (x_oTableSet.Fields(SpecialCustomer.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[SpecialCustomer.Para.TableName()].Columns.Add(SpecialCustomer.Para.did); }
            if (x_oTableSet.Fields(SpecialCustomer.Para.condition2).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[SpecialCustomer.Para.TableName()].Columns.Add(SpecialCustomer.Para.condition2); }
            if (x_oSpecialCustomer != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[SpecialCustomer.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(SpecialCustomer.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[SpecialCustomer.Para.id] = x_oSpecialCustomer.GetId(); }
                if (x_oTableSet.Fields(SpecialCustomer.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[SpecialCustomer.Para.cdate] = x_oSpecialCustomer.GetCdate(); }
                if (x_oTableSet.Fields(SpecialCustomer.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[SpecialCustomer.Para.cid] = x_oSpecialCustomer.GetCid(); }
                if (x_oTableSet.Fields(SpecialCustomer.Para.condition4).IsView || x_oTableSet.GetViewAll()) { _oDRow[SpecialCustomer.Para.condition4] = x_oSpecialCustomer.GetCondition4(); }
                if (x_oTableSet.Fields(SpecialCustomer.Para.status).IsView || x_oTableSet.GetViewAll()) { _oDRow[SpecialCustomer.Para.status] = x_oSpecialCustomer.GetStatus(); }
                if (x_oTableSet.Fields(SpecialCustomer.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[SpecialCustomer.Para.active] = x_oSpecialCustomer.GetActive(); }
                if (x_oTableSet.Fields(SpecialCustomer.Para.condition3).IsView || x_oTableSet.GetViewAll()) { _oDRow[SpecialCustomer.Para.condition3] = x_oSpecialCustomer.GetCondition3(); }
                if (x_oTableSet.Fields(SpecialCustomer.Para.condition5).IsView || x_oTableSet.GetViewAll()) { _oDRow[SpecialCustomer.Para.condition5] = x_oSpecialCustomer.GetCondition5(); }
                if (x_oTableSet.Fields(SpecialCustomer.Para.hkid).IsView || x_oTableSet.GetViewAll()) { _oDRow[SpecialCustomer.Para.hkid] = x_oSpecialCustomer.GetHkid(); }
                if (x_oTableSet.Fields(SpecialCustomer.Para.condition1).IsView || x_oTableSet.GetViewAll()) { _oDRow[SpecialCustomer.Para.condition1] = x_oSpecialCustomer.GetCondition1(); }
                if (x_oTableSet.Fields(SpecialCustomer.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[SpecialCustomer.Para.ddate] = x_oSpecialCustomer.GetDdate(); }
                if (x_oTableSet.Fields(SpecialCustomer.Para.count).IsView || x_oTableSet.GetViewAll()) { _oDRow[SpecialCustomer.Para.count] = x_oSpecialCustomer.GetCount(); }
                if (x_oTableSet.Fields(SpecialCustomer.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[SpecialCustomer.Para.did] = x_oSpecialCustomer.GetDid(); }
                if (x_oTableSet.Fields(SpecialCustomer.Para.condition2).IsView || x_oTableSet.GetViewAll()) { _oDRow[SpecialCustomer.Para.condition2] = x_oSpecialCustomer.GetCondition2(); }
                _oDSet.Tables[SpecialCustomer.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(SpecialCustomerInfo x_oTableSet)
        {
            return SpecialCustomerBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return SpecialCustomerBal.ToEmptyDataSetProcess(SpecialCustomerInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(SpecialCustomerInfo x_oTableSet)
        {
            return SpecialCustomerBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(SpecialCustomer x_oSpecialCustomer, SpecialCustomerInfo x_oTableSet)
        {
            return SpecialCustomerBal.GetDataSet(null, null, x_oTableSet).Tables[SpecialCustomer.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(SpecialCustomer x_oSpecialCustomer)
        {
            return SpecialCustomerBal.GetDataSet(x_oSpecialCustomer, null, SpecialCustomerInfoDLL.CreateInfoInstanceObject()).Tables[SpecialCustomer.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return Row(x_oTable, x_oDB,x_iId,SpecialCustomerInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId, SpecialCustomerInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iId, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId,SpecialCustomerInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = SpecialCustomerInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [SpecialCustomer].[cid] AS SPECIALCUSTOMER_CID,[SpecialCustomer].[id] AS SPECIALCUSTOMER_ID,[SpecialCustomer].[cdate] AS SPECIALCUSTOMER_CDATE,[SpecialCustomer].[condition1] AS SPECIALCUSTOMER_CONDITION1,[SpecialCustomer].[condition4] AS SPECIALCUSTOMER_CONDITION4,[SpecialCustomer].[status] AS SPECIALCUSTOMER_STATUS,[SpecialCustomer].[active] AS SPECIALCUSTOMER_ACTIVE,[SpecialCustomer].[condition3] AS SPECIALCUSTOMER_CONDITION3,[SpecialCustomer].[condition5] AS SPECIALCUSTOMER_CONDITION5,[SpecialCustomer].[hkid] AS SPECIALCUSTOMER_HKID,[SpecialCustomer].[ddate] AS SPECIALCUSTOMER_DDATE,[SpecialCustomer].[count] AS SPECIALCUSTOMER_COUNT,[SpecialCustomer].[did] AS SPECIALCUSTOMER_DID,[SpecialCustomer].[condition2] AS SPECIALCUSTOMER_CONDITION2  FROM  [SpecialCustomer]  WHERE  [SpecialCustomer].[id] = \'"+x_iId.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[SpecialCustomer]","["+ Configurator.MSSQLTablePrefix + "SpecialCustomer]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(SpecialCustomer.Para.cid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(SpecialCustomer.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialCustomer.Para.cid).AliasName].ToString()] = (string)_oData["SPECIALCUSTOMER_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialCustomer.Para.cid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(SpecialCustomer.Para.id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(SpecialCustomer.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialCustomer.Para.id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["SPECIALCUSTOMER_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialCustomer.Para.id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(SpecialCustomer.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(SpecialCustomer.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialCustomer.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["SPECIALCUSTOMER_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialCustomer.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(SpecialCustomer.Para.condition1).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_CONDITION1"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(SpecialCustomer.Para.condition1).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialCustomer.Para.condition1).AliasName].ToString()] = (string)_oData["SPECIALCUSTOMER_CONDITION1"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialCustomer.Para.condition1).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(SpecialCustomer.Para.condition4).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_CONDITION4"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(SpecialCustomer.Para.condition4).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialCustomer.Para.condition4).AliasName].ToString()] = (string)_oData["SPECIALCUSTOMER_CONDITION4"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialCustomer.Para.condition4).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(SpecialCustomer.Para.status).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_STATUS"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(SpecialCustomer.Para.status).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialCustomer.Para.status).AliasName].ToString()] = (string)_oData["SPECIALCUSTOMER_STATUS"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialCustomer.Para.status).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(SpecialCustomer.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(SpecialCustomer.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialCustomer.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["SPECIALCUSTOMER_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialCustomer.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(SpecialCustomer.Para.condition3).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_CONDITION3"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(SpecialCustomer.Para.condition3).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialCustomer.Para.condition3).AliasName].ToString()] = (string)_oData["SPECIALCUSTOMER_CONDITION3"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialCustomer.Para.condition3).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(SpecialCustomer.Para.condition5).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_CONDITION5"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(SpecialCustomer.Para.condition5).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialCustomer.Para.condition5).AliasName].ToString()] = (string)_oData["SPECIALCUSTOMER_CONDITION5"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialCustomer.Para.condition5).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(SpecialCustomer.Para.hkid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_HKID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(SpecialCustomer.Para.hkid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialCustomer.Para.hkid).AliasName].ToString()] = (string)_oData["SPECIALCUSTOMER_HKID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialCustomer.Para.hkid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(SpecialCustomer.Para.ddate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(SpecialCustomer.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialCustomer.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["SPECIALCUSTOMER_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialCustomer.Para.ddate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(SpecialCustomer.Para.count).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_COUNT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(SpecialCustomer.Para.count).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialCustomer.Para.count).AliasName].ToString()] = (global::System.Nullable<int>)_oData["SPECIALCUSTOMER_COUNT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialCustomer.Para.count).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(SpecialCustomer.Para.did).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(SpecialCustomer.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialCustomer.Para.did).AliasName].ToString()] = (string)_oData["SPECIALCUSTOMER_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialCustomer.Para.did).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(SpecialCustomer.Para.condition2).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_CONDITION2"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(SpecialCustomer.Para.condition2).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialCustomer.Para.condition2).AliasName].ToString()] = (string)_oData["SPECIALCUSTOMER_CONDITION2"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialCustomer.Para.condition2).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,SpecialCustomer x_oSpecialCustomerRow)
        {
            return SetByDataSetRowProc(x_iROW, SpecialCustomer.Para.TableName(), x_oDataSet,x_oSpecialCustomerRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,SpecialCustomer x_oSpecialCustomerRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oSpecialCustomerRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,SpecialCustomer x_oSpecialCustomerRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                SpecialCustomerInfo _oTableSet=SpecialCustomerInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(SpecialCustomer.Para.id).AliasName))
                    x_oSpecialCustomerRow.id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(SpecialCustomer.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(SpecialCustomer.Para.cdate).AliasName))
                    x_oSpecialCustomerRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(SpecialCustomer.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(SpecialCustomer.Para.cid).AliasName))
                    x_oSpecialCustomerRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(SpecialCustomer.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(SpecialCustomer.Para.condition4).AliasName))
                    x_oSpecialCustomerRow.condition4 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(SpecialCustomer.Para.condition4).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(SpecialCustomer.Para.status).AliasName))
                    x_oSpecialCustomerRow.status = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(SpecialCustomer.Para.status).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(SpecialCustomer.Para.active).AliasName))
                    x_oSpecialCustomerRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(SpecialCustomer.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(SpecialCustomer.Para.condition3).AliasName))
                    x_oSpecialCustomerRow.condition3 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(SpecialCustomer.Para.condition3).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(SpecialCustomer.Para.condition5).AliasName))
                    x_oSpecialCustomerRow.condition5 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(SpecialCustomer.Para.condition5).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(SpecialCustomer.Para.hkid).AliasName))
                    x_oSpecialCustomerRow.hkid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(SpecialCustomer.Para.hkid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(SpecialCustomer.Para.condition1).AliasName))
                    x_oSpecialCustomerRow.condition1 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(SpecialCustomer.Para.condition1).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(SpecialCustomer.Para.ddate).AliasName))
                    x_oSpecialCustomerRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(SpecialCustomer.Para.ddate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(SpecialCustomer.Para.count).AliasName))
                    x_oSpecialCustomerRow.count = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(SpecialCustomer.Para.count).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(SpecialCustomer.Para.did).AliasName))
                    x_oSpecialCustomerRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(SpecialCustomer.Para.did).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(SpecialCustomer.Para.condition2).AliasName))
                    x_oSpecialCustomerRow.condition2 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(SpecialCustomer.Para.condition2).AliasName];
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
            return SpecialCustomerRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static SpecialCustomerEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return SpecialCustomerRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static SpecialCustomerEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return SpecialCustomerRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return SpecialCustomerRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return SpecialCustomerRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return SpecialCustomerRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sCondition4,string x_sStatus,global::System.Nullable<bool> x_bActive,string x_sCondition3,string x_sCondition5,string x_sHkid,string x_sCondition1,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<int> x_iCount,string x_sDid,string x_sCondition2)
        {
            return SpecialCustomerRepository.Insert(x_oDB, x_dCdate,x_sCid,x_sCondition4,x_sStatus,x_bActive,x_sCondition3,x_sCondition5,x_sHkid,x_sCondition1,x_dDdate,x_iCount,x_sDid,x_sCondition2);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,SpecialCustomer x_oSpecialCustomer)
        {
            return SpecialCustomerRepository.InsertWithOutLastID(x_oDB,x_oSpecialCustomer);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sCondition4,string x_sStatus,global::System.Nullable<bool> x_bActive,string x_sCondition3,string x_sCondition5,string x_sHkid,string x_sCondition1,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<int> x_iCount,string x_sDid,string x_sCondition2)
        {
            return SpecialCustomerRepository.InsertReturnLastID_SP(x_oDB,x_dCdate,x_sCid,x_sCondition4,x_sStatus,x_bActive,x_sCondition3,x_sCondition5,x_sHkid,x_sCondition1,x_dDdate,x_iCount,x_sDid,x_sCondition2);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, SpecialCustomer x_oSpecialCustomer)
        {
            return SpecialCustomerRepository.InsertReturnLastID_SP(x_oDB,x_oSpecialCustomer);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return SpecialCustomerRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return SpecialCustomerRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return SpecialCustomerRepository.Delete(x_oDB, x_iId);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(SpecialCustomer x_oSpecialCustomerRow){
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


