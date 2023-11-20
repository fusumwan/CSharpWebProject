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
///-- Create date: <Create Date 2011-03-08>
///-- Description:	<Description,Table :[MobileOrderVas],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderVas] Business layer
    /// </summary>
    
    public abstract class MobileOrderVasBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public MobileOrderVasBalBase(){
        }
        ~MobileOrderVasBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderVas x_oMobileOrderVas)
        {
            return GetDataSet(x_oMobileOrderVas,null,MobileOrderVasInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderVas x_oMobileOrderVas,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oMobileOrderVas,x_oMergeDSet,MobileOrderVasInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderVas x_oMobileOrderVas,MobileOrderVasInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderVas,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderVas x_oMobileOrderVas,global::System.Data.DataSet x_oMergeDSet,MobileOrderVasInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderVas,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(MobileOrderVas x_oMobileOrderVas,global::System.Data.DataSet x_oMergeDSet,MobileOrderVasInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderVasInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(MobileOrderVas.Para.TableName());
            if (x_oTableSet.Fields(MobileOrderVas.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderVas.Para.TableName()].Columns.Add(MobileOrderVas.Para.id); }
            if (x_oTableSet.Fields(MobileOrderVas.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderVas.Para.TableName()].Columns.Add(MobileOrderVas.Para.cdate); }
            if (x_oTableSet.Fields(MobileOrderVas.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderVas.Para.TableName()].Columns.Add(MobileOrderVas.Para.active); }
            if (x_oTableSet.Fields(MobileOrderVas.Para.vas_field).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderVas.Para.TableName()].Columns.Add(MobileOrderVas.Para.vas_field); }
            if (x_oTableSet.Fields(MobileOrderVas.Para.vas_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderVas.Para.TableName()].Columns.Add(MobileOrderVas.Para.vas_id); }
            if (x_oTableSet.Fields(MobileOrderVas.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderVas.Para.TableName()].Columns.Add(MobileOrderVas.Para.order_id); }
            if (x_oTableSet.Fields(MobileOrderVas.Para.fee).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderVas.Para.TableName()].Columns.Add(MobileOrderVas.Para.fee); }
            if (x_oTableSet.Fields(MobileOrderVas.Para.vas_value).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderVas.Para.TableName()].Columns.Add(MobileOrderVas.Para.vas_value); }
            if (x_oTableSet.Fields(MobileOrderVas.Para.multi_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderVas.Para.TableName()].Columns.Add(MobileOrderVas.Para.multi_id); }
            if (x_oMobileOrderVas != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[MobileOrderVas.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(MobileOrderVas.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderVas.Para.id] = x_oMobileOrderVas.GetId(); }
                if (x_oTableSet.Fields(MobileOrderVas.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderVas.Para.cdate] = x_oMobileOrderVas.GetCdate(); }
                if (x_oTableSet.Fields(MobileOrderVas.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderVas.Para.active] = x_oMobileOrderVas.GetActive(); }
                if (x_oTableSet.Fields(MobileOrderVas.Para.vas_field).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderVas.Para.vas_field] = x_oMobileOrderVas.GetVas_field(); }
                if (x_oTableSet.Fields(MobileOrderVas.Para.vas_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderVas.Para.vas_id] = x_oMobileOrderVas.GetVas_id(); }
                if (x_oTableSet.Fields(MobileOrderVas.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderVas.Para.order_id] = x_oMobileOrderVas.GetOrder_id(); }
                if (x_oTableSet.Fields(MobileOrderVas.Para.fee).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderVas.Para.fee] = x_oMobileOrderVas.GetFee(); }
                if (x_oTableSet.Fields(MobileOrderVas.Para.vas_value).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderVas.Para.vas_value] = x_oMobileOrderVas.GetVas_value(); }
                if (x_oTableSet.Fields(MobileOrderVas.Para.multi_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderVas.Para.multi_id] = x_oMobileOrderVas.GetMulti_id(); }
                _oDSet.Tables[MobileOrderVas.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(MobileOrderVasInfo x_oTableSet)
        {
            return MobileOrderVasBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return MobileOrderVasBal.ToEmptyDataSetProcess(MobileOrderVasInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(MobileOrderVasInfo x_oTableSet)
        {
            return MobileOrderVasBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(MobileOrderVas x_oMobileOrderVas, MobileOrderVasInfo x_oTableSet)
        {
            return MobileOrderVasBal.GetDataSet(null, null, x_oTableSet).Tables[MobileOrderVas.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(MobileOrderVas x_oMobileOrderVas)
        {
            return MobileOrderVasBal.GetDataSet(x_oMobileOrderVas, null, MobileOrderVasInfoDLL.CreateInfoInstanceObject()).Tables[MobileOrderVas.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return Row(x_oTable, x_oDB,x_iId,MobileOrderVasInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId, MobileOrderVasInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iId, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId,MobileOrderVasInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderVasInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [MobileOrderVas].[id] AS MOBILEORDERVAS_ID,[MobileOrderVas].[cdate] AS MOBILEORDERVAS_CDATE,[MobileOrderVas].[active] AS MOBILEORDERVAS_ACTIVE,[MobileOrderVas].[multi_id] AS MOBILEORDERVAS_MULTI_ID,[MobileOrderVas].[vas_field] AS MOBILEORDERVAS_VAS_FIELD,[MobileOrderVas].[vas_id] AS MOBILEORDERVAS_VAS_ID,[MobileOrderVas].[order_id] AS MOBILEORDERVAS_ORDER_ID,[MobileOrderVas].[fee] AS MOBILEORDERVAS_FEE,[MobileOrderVas].[vas_value] AS MOBILEORDERVAS_VAS_VALUE  FROM  [MobileOrderVas]  WHERE  [MobileOrderVas].[id] = \'"+x_iId.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderVas]","["+ Configurator.MSSQLTablePrefix + "MobileOrderVas]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(MobileOrderVas.Para.id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVAS_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderVas.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVas.Para.id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERVAS_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVas.Para.id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderVas.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVAS_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderVas.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVas.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERVAS_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVas.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderVas.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVAS_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderVas.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVas.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILEORDERVAS_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVas.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderVas.Para.multi_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVAS_MULTI_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderVas.Para.multi_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVas.Para.multi_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERVAS_MULTI_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVas.Para.multi_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderVas.Para.vas_field).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVAS_VAS_FIELD"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderVas.Para.vas_field).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVas.Para.vas_field).AliasName].ToString()] = (string)_oData["MOBILEORDERVAS_VAS_FIELD"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVas.Para.vas_field).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderVas.Para.vas_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVAS_VAS_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderVas.Para.vas_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVas.Para.vas_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERVAS_VAS_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVas.Para.vas_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderVas.Para.order_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVAS_ORDER_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderVas.Para.order_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVas.Para.order_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERVAS_ORDER_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVas.Para.order_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderVas.Para.fee).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVAS_FEE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderVas.Para.fee).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVas.Para.fee).AliasName].ToString()] = (string)_oData["MOBILEORDERVAS_FEE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVas.Para.fee).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderVas.Para.vas_value).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVAS_VAS_VALUE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderVas.Para.vas_value).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVas.Para.vas_value).AliasName].ToString()] = (string)_oData["MOBILEORDERVAS_VAS_VALUE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderVas.Para.vas_value).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,MobileOrderVas x_oMobileOrderVasRow)
        {
            return SetByDataSetRowProc(x_iROW, MobileOrderVas.Para.TableName(), x_oDataSet,x_oMobileOrderVasRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderVas x_oMobileOrderVasRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oMobileOrderVasRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderVas x_oMobileOrderVasRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                MobileOrderVasInfo _oTableSet=MobileOrderVasInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderVas.Para.id).AliasName))
                    x_oMobileOrderVasRow.id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderVas.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderVas.Para.cdate).AliasName))
                    x_oMobileOrderVasRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderVas.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderVas.Para.active).AliasName))
                    x_oMobileOrderVasRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderVas.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderVas.Para.vas_field).AliasName))
                    x_oMobileOrderVasRow.vas_field = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderVas.Para.vas_field).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderVas.Para.vas_id).AliasName))
                    x_oMobileOrderVasRow.vas_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderVas.Para.vas_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderVas.Para.order_id).AliasName))
                    x_oMobileOrderVasRow.order_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderVas.Para.order_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderVas.Para.fee).AliasName))
                    x_oMobileOrderVasRow.fee = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderVas.Para.fee).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderVas.Para.vas_value).AliasName))
                    x_oMobileOrderVasRow.vas_value = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderVas.Para.vas_value).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderVas.Para.multi_id).AliasName))
                    x_oMobileOrderVasRow.multi_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderVas.Para.multi_id).AliasName];
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
            return MobileOrderVasRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static MobileOrderVasEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return MobileOrderVasRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static MobileOrderVasEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return MobileOrderVasRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderVasRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderVasRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderVasRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate,global::System.Nullable<bool> x_bActive,string x_sVas_field,global::System.Nullable<int> x_iVas_id,global::System.Nullable<int> x_iOrder_id,string x_sFee,string x_sVas_value,global::System.Nullable<int> x_iMulti_id)
        {
            return MobileOrderVasRepository.Insert(x_oDB, x_dCdate,x_bActive,x_sVas_field,x_iVas_id,x_iOrder_id,x_sFee,x_sVas_value,x_iMulti_id);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderVas x_oMobileOrderVas)
        {
            return MobileOrderVasRepository.InsertWithOutLastID(x_oDB,x_oMobileOrderVas);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,global::System.Nullable<bool> x_bActive,string x_sVas_field,global::System.Nullable<int> x_iVas_id,global::System.Nullable<int> x_iOrder_id,string x_sFee,string x_sVas_value,global::System.Nullable<int> x_iMulti_id)
        {
            return MobileOrderVasRepository.InsertReturnLastID_SP(x_oDB,x_dCdate,x_bActive,x_sVas_field,x_iVas_id,x_iOrder_id,x_sFee,x_sVas_value,x_iMulti_id);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderVas x_oMobileOrderVas)
        {
            return MobileOrderVasRepository.InsertReturnLastID_SP(x_oDB,x_oMobileOrderVas);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return MobileOrderVasRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderVasRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return MobileOrderVasRepository.Delete(x_oDB, x_iId);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(MobileOrderVas x_oMobileOrderVasRow){
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


