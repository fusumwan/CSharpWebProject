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
///-- Create date: <Create Date 2011-09-15>
///-- Description:	<Description,Table :[OfferAutomation],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [OfferAutomation] Business layer
    /// </summary>
    
    public abstract class OfferAutomationBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public OfferAutomationBalBase(){
        }
        ~OfferAutomationBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(OfferAutomation x_oOfferAutomation)
        {
            return GetDataSet(x_oOfferAutomation,null,OfferAutomationInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(OfferAutomation x_oOfferAutomation,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oOfferAutomation,x_oMergeDSet,OfferAutomationInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(OfferAutomation x_oOfferAutomation,OfferAutomationInfo x_oTableSet)
        {
            return GetDataSet(x_oOfferAutomation,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(OfferAutomation x_oOfferAutomation,global::System.Data.DataSet x_oMergeDSet,OfferAutomationInfo x_oTableSet)
        {
            return GetDataSet(x_oOfferAutomation,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(OfferAutomation x_oOfferAutomation,global::System.Data.DataSet x_oMergeDSet,OfferAutomationInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = OfferAutomationInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(OfferAutomation.Para.TableName());
            if (x_oTableSet.Fields(OfferAutomation.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[OfferAutomation.Para.TableName()].Columns.Add(OfferAutomation.Para.id); }
            if (x_oTableSet.Fields(OfferAutomation.Para.offer_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[OfferAutomation.Para.TableName()].Columns.Add(OfferAutomation.Para.offer_name); }
            if (x_oTableSet.Fields(OfferAutomation.Para.call_list_program_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[OfferAutomation.Para.TableName()].Columns.Add(OfferAutomation.Para.call_list_program_id); }
            if (x_oTableSet.Fields(OfferAutomation.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[OfferAutomation.Para.TableName()].Columns.Add(OfferAutomation.Para.active); }
            if (x_oTableSet.Fields(OfferAutomation.Para.trade_field_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[OfferAutomation.Para.TableName()].Columns.Add(OfferAutomation.Para.trade_field_id); }
            if (x_oOfferAutomation != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[OfferAutomation.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(OfferAutomation.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[OfferAutomation.Para.id] = x_oOfferAutomation.GetId(); }
                if (x_oTableSet.Fields(OfferAutomation.Para.offer_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[OfferAutomation.Para.offer_name] = x_oOfferAutomation.GetOffer_name(); }
                if (x_oTableSet.Fields(OfferAutomation.Para.call_list_program_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[OfferAutomation.Para.call_list_program_id] = x_oOfferAutomation.GetCall_list_program_id(); }
                if (x_oTableSet.Fields(OfferAutomation.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[OfferAutomation.Para.active] = x_oOfferAutomation.GetActive(); }
                if (x_oTableSet.Fields(OfferAutomation.Para.trade_field_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[OfferAutomation.Para.trade_field_id] = x_oOfferAutomation.GetTrade_field_id(); }
                _oDSet.Tables[OfferAutomation.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(OfferAutomationInfo x_oTableSet)
        {
            return OfferAutomationBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return OfferAutomationBal.ToEmptyDataSetProcess(OfferAutomationInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(OfferAutomationInfo x_oTableSet)
        {
            return OfferAutomationBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(OfferAutomation x_oOfferAutomation, OfferAutomationInfo x_oTableSet)
        {
            return OfferAutomationBal.GetDataSet(null, null, x_oTableSet).Tables[OfferAutomation.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(OfferAutomation x_oOfferAutomation)
        {
            return OfferAutomationBal.GetDataSet(x_oOfferAutomation, null, OfferAutomationInfoDLL.CreateInfoInstanceObject()).Tables[OfferAutomation.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return Row(x_oTable, x_oDB,x_iId,OfferAutomationInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId, OfferAutomationInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iId, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId,OfferAutomationInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = OfferAutomationInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [OfferAutomation].[active] AS OFFERAUTOMATION_ACTIVE,[OfferAutomation].[offer_name] AS OFFERAUTOMATION_OFFER_NAME,[OfferAutomation].[call_list_program_id] AS OFFERAUTOMATION_CALL_LIST_PROGRAM_ID,[OfferAutomation].[id] AS OFFERAUTOMATION_ID,[OfferAutomation].[trade_field_id] AS OFFERAUTOMATION_TRADE_FIELD_ID  FROM  [OfferAutomation]  WHERE  [OfferAutomation].[id] = \'"+x_iId.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[OfferAutomation]","["+ Configurator.MSSQLTablePrefix + "OfferAutomation]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(OfferAutomation.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["OFFERAUTOMATION_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(OfferAutomation.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(OfferAutomation.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["OFFERAUTOMATION_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(OfferAutomation.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(OfferAutomation.Para.offer_name).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["OFFERAUTOMATION_OFFER_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(OfferAutomation.Para.offer_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(OfferAutomation.Para.offer_name).AliasName].ToString()] = (string)_oData["OFFERAUTOMATION_OFFER_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(OfferAutomation.Para.offer_name).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(OfferAutomation.Para.call_list_program_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["OFFERAUTOMATION_CALL_LIST_PROGRAM_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(OfferAutomation.Para.call_list_program_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(OfferAutomation.Para.call_list_program_id).AliasName].ToString()] = (global::System.Nullable<long>)_oData["OFFERAUTOMATION_CALL_LIST_PROGRAM_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(OfferAutomation.Para.call_list_program_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(OfferAutomation.Para.id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["OFFERAUTOMATION_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(OfferAutomation.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(OfferAutomation.Para.id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["OFFERAUTOMATION_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(OfferAutomation.Para.id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(OfferAutomation.Para.trade_field_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["OFFERAUTOMATION_TRADE_FIELD_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(OfferAutomation.Para.trade_field_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(OfferAutomation.Para.trade_field_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["OFFERAUTOMATION_TRADE_FIELD_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(OfferAutomation.Para.trade_field_id).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,OfferAutomation x_oOfferAutomationRow)
        {
            return SetByDataSetRowProc(x_iROW, OfferAutomation.Para.TableName(), x_oDataSet,x_oOfferAutomationRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,OfferAutomation x_oOfferAutomationRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oOfferAutomationRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,OfferAutomation x_oOfferAutomationRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                OfferAutomationInfo _oTableSet=OfferAutomationInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(OfferAutomation.Para.id).AliasName))
                    x_oOfferAutomationRow.id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(OfferAutomation.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(OfferAutomation.Para.offer_name).AliasName))
                    x_oOfferAutomationRow.offer_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(OfferAutomation.Para.offer_name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(OfferAutomation.Para.call_list_program_id).AliasName))
                    x_oOfferAutomationRow.call_list_program_id = (global::System.Nullable<long>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(OfferAutomation.Para.call_list_program_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(OfferAutomation.Para.active).AliasName))
                    x_oOfferAutomationRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(OfferAutomation.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(OfferAutomation.Para.trade_field_id).AliasName))
                    x_oOfferAutomationRow.trade_field_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(OfferAutomation.Para.trade_field_id).AliasName];
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
            return OfferAutomationRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static OfferAutomationEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return OfferAutomationRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static OfferAutomationEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return OfferAutomationRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return OfferAutomationRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return OfferAutomationRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return OfferAutomationRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sOffer_name,global::System.Nullable<long> x_lCall_list_program_id,global::System.Nullable<bool> x_bActive,global::System.Nullable<int> x_iTrade_field_id)
        {
            return OfferAutomationRepository.Insert(x_oDB, x_sOffer_name,x_lCall_list_program_id,x_bActive,x_iTrade_field_id);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,OfferAutomation x_oOfferAutomation)
        {
            return OfferAutomationRepository.InsertWithOutLastID(x_oDB,x_oOfferAutomation);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sOffer_name,global::System.Nullable<long> x_lCall_list_program_id,global::System.Nullable<bool> x_bActive,global::System.Nullable<int> x_iTrade_field_id)
        {
            return OfferAutomationRepository.InsertReturnLastID_SP(x_oDB,x_sOffer_name,x_lCall_list_program_id,x_bActive,x_iTrade_field_id);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, OfferAutomation x_oOfferAutomation)
        {
            return OfferAutomationRepository.InsertReturnLastID_SP(x_oDB,x_oOfferAutomation);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return OfferAutomationRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return OfferAutomationRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return OfferAutomationRepository.Delete(x_oDB, x_iId);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(OfferAutomation x_oOfferAutomationRow){
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


