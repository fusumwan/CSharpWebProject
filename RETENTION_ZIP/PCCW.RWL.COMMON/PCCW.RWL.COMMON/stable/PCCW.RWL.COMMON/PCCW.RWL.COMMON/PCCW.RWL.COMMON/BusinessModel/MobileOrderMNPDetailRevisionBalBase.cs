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
///-- Description:	<Description,Table :[MobileOrderMNPDetailRevision],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderMNPDetailRevision] Business layer
    /// </summary>
    
    public abstract class MobileOrderMNPDetailRevisionBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public MobileOrderMNPDetailRevisionBalBase(){
        }
        ~MobileOrderMNPDetailRevisionBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderMNPDetailRevision x_oMobileOrderMNPDetailRevision)
        {
            return GetDataSet(x_oMobileOrderMNPDetailRevision,null,MobileOrderMNPDetailRevisionInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderMNPDetailRevision x_oMobileOrderMNPDetailRevision,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oMobileOrderMNPDetailRevision,x_oMergeDSet,MobileOrderMNPDetailRevisionInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderMNPDetailRevision x_oMobileOrderMNPDetailRevision,MobileOrderMNPDetailRevisionInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderMNPDetailRevision,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderMNPDetailRevision x_oMobileOrderMNPDetailRevision,global::System.Data.DataSet x_oMergeDSet,MobileOrderMNPDetailRevisionInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderMNPDetailRevision,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(MobileOrderMNPDetailRevision x_oMobileOrderMNPDetailRevision,global::System.Data.DataSet x_oMergeDSet,MobileOrderMNPDetailRevisionInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderMNPDetailRevisionInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(MobileOrderMNPDetailRevision.Para.TableName());
            if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.service_activation_time).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMNPDetailRevision.Para.TableName()].Columns.Add(MobileOrderMNPDetailRevision.Para.service_activation_time); }
            if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.ticker_number).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMNPDetailRevision.Para.TableName()].Columns.Add(MobileOrderMNPDetailRevision.Para.ticker_number); }
            if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.id_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMNPDetailRevision.Para.TableName()].Columns.Add(MobileOrderMNPDetailRevision.Para.id_type); }
            if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_idd_roaming_deposit).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMNPDetailRevision.Para.TableName()].Columns.Add(MobileOrderMNPDetailRevision.Para.transfer_idd_roaming_deposit); }
            if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.company_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMNPDetailRevision.Para.TableName()].Columns.Add(MobileOrderMNPDetailRevision.Para.company_name); }
            if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.service_activation_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMNPDetailRevision.Para.TableName()].Columns.Add(MobileOrderMNPDetailRevision.Para.service_activation_date); }
            if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.mnp_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMNPDetailRevision.Para.TableName()].Columns.Add(MobileOrderMNPDetailRevision.Para.mnp_id); }
            if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_others_deposit).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMNPDetailRevision.Para.TableName()].Columns.Add(MobileOrderMNPDetailRevision.Para.transfer_others_deposit); }
            if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMNPDetailRevision.Para.TableName()].Columns.Add(MobileOrderMNPDetailRevision.Para.mid); }
            if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.hkid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMNPDetailRevision.Para.TableName()].Columns.Add(MobileOrderMNPDetailRevision.Para.hkid); }
            if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_to_3g).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMNPDetailRevision.Para.TableName()].Columns.Add(MobileOrderMNPDetailRevision.Para.transfer_to_3g); }
            if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_idd_deposit).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMNPDetailRevision.Para.TableName()].Columns.Add(MobileOrderMNPDetailRevision.Para.transfer_idd_deposit); }
            if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_no_add_proof_deposit).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMNPDetailRevision.Para.TableName()].Columns.Add(MobileOrderMNPDetailRevision.Para.transfer_no_add_proof_deposit); }
            if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMNPDetailRevision.Para.TableName()].Columns.Add(MobileOrderMNPDetailRevision.Para.order_id); }
            if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.registered_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMNPDetailRevision.Para.TableName()].Columns.Add(MobileOrderMNPDetailRevision.Para.registered_name); }
            if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_no_hk_id_holder_deposit).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMNPDetailRevision.Para.TableName()].Columns.Add(MobileOrderMNPDetailRevision.Para.transfer_no_hk_id_holder_deposit); }
            if (x_oMobileOrderMNPDetailRevision != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[MobileOrderMNPDetailRevision.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.service_activation_time).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMNPDetailRevision.Para.service_activation_time] = x_oMobileOrderMNPDetailRevision.GetService_activation_time(); }
                if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.ticker_number).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMNPDetailRevision.Para.ticker_number] = x_oMobileOrderMNPDetailRevision.GetTicker_number(); }
                if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.id_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMNPDetailRevision.Para.id_type] = x_oMobileOrderMNPDetailRevision.GetId_type(); }
                if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_idd_roaming_deposit).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMNPDetailRevision.Para.transfer_idd_roaming_deposit] = x_oMobileOrderMNPDetailRevision.GetTransfer_idd_roaming_deposit(); }
                if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.company_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMNPDetailRevision.Para.company_name] = x_oMobileOrderMNPDetailRevision.GetCompany_name(); }
                if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.service_activation_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMNPDetailRevision.Para.service_activation_date] = x_oMobileOrderMNPDetailRevision.GetService_activation_date(); }
                if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.mnp_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMNPDetailRevision.Para.mnp_id] = x_oMobileOrderMNPDetailRevision.GetMnp_id(); }
                if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_others_deposit).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMNPDetailRevision.Para.transfer_others_deposit] = x_oMobileOrderMNPDetailRevision.GetTransfer_others_deposit(); }
                if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMNPDetailRevision.Para.mid] = x_oMobileOrderMNPDetailRevision.GetMid(); }
                if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.hkid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMNPDetailRevision.Para.hkid] = x_oMobileOrderMNPDetailRevision.GetHkid(); }
                if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_to_3g).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMNPDetailRevision.Para.transfer_to_3g] = x_oMobileOrderMNPDetailRevision.GetTransfer_to_3g(); }
                if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_idd_deposit).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMNPDetailRevision.Para.transfer_idd_deposit] = x_oMobileOrderMNPDetailRevision.GetTransfer_idd_deposit(); }
                if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_no_add_proof_deposit).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMNPDetailRevision.Para.transfer_no_add_proof_deposit] = x_oMobileOrderMNPDetailRevision.GetTransfer_no_add_proof_deposit(); }
                if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMNPDetailRevision.Para.order_id] = x_oMobileOrderMNPDetailRevision.GetOrder_id(); }
                if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.registered_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMNPDetailRevision.Para.registered_name] = x_oMobileOrderMNPDetailRevision.GetRegistered_name(); }
                if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_no_hk_id_holder_deposit).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMNPDetailRevision.Para.transfer_no_hk_id_holder_deposit] = x_oMobileOrderMNPDetailRevision.GetTransfer_no_hk_id_holder_deposit(); }
                _oDSet.Tables[MobileOrderMNPDetailRevision.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(MobileOrderMNPDetailRevisionInfo x_oTableSet)
        {
            return MobileOrderMNPDetailRevisionBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return MobileOrderMNPDetailRevisionBal.ToEmptyDataSetProcess(MobileOrderMNPDetailRevisionInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(MobileOrderMNPDetailRevisionInfo x_oTableSet)
        {
            return MobileOrderMNPDetailRevisionBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(MobileOrderMNPDetailRevision x_oMobileOrderMNPDetailRevision, MobileOrderMNPDetailRevisionInfo x_oTableSet)
        {
            return MobileOrderMNPDetailRevisionBal.GetDataSet(null, null, x_oTableSet).Tables[MobileOrderMNPDetailRevision.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(MobileOrderMNPDetailRevision x_oMobileOrderMNPDetailRevision)
        {
            return MobileOrderMNPDetailRevisionBal.GetDataSet(x_oMobileOrderMNPDetailRevision, null, MobileOrderMNPDetailRevisionInfoDLL.CreateInfoInstanceObject()).Tables[MobileOrderMNPDetailRevision.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<long> x_lMid)
        {
            return Row(x_oTable, x_oDB,x_lMid,MobileOrderMNPDetailRevisionInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<long> x_lMid, MobileOrderMNPDetailRevisionInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_lMid, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<long> x_lMid,MobileOrderMNPDetailRevisionInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderMNPDetailRevisionInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [MobileOrderMNPDetailRevision].[service_activation_time] AS MOBILEORDERMNPDETAILREVISION_SERVICE_ACTIVATION_TIME,[MobileOrderMNPDetailRevision].[ticker_number] AS MOBILEORDERMNPDETAILREVISION_TICKER_NUMBER,[MobileOrderMNPDetailRevision].[id_type] AS MOBILEORDERMNPDETAILREVISION_ID_TYPE,[MobileOrderMNPDetailRevision].[transfer_idd_roaming_deposit] AS MOBILEORDERMNPDETAILREVISION_TRANSFER_IDD_ROAMING_DEPOSIT,[MobileOrderMNPDetailRevision].[transfer_idd_deposit] AS MOBILEORDERMNPDETAILREVISION_TRANSFER_IDD_DEPOSIT,[MobileOrderMNPDetailRevision].[service_activation_date] AS MOBILEORDERMNPDETAILREVISION_SERVICE_ACTIVATION_DATE,[MobileOrderMNPDetailRevision].[mnp_id] AS MOBILEORDERMNPDETAILREVISION_MNP_ID,[MobileOrderMNPDetailRevision].[transfer_others_deposit] AS MOBILEORDERMNPDETAILREVISION_TRANSFER_OTHERS_DEPOSIT,[MobileOrderMNPDetailRevision].[registered_name] AS MOBILEORDERMNPDETAILREVISION_REGISTERED_NAME,[MobileOrderMNPDetailRevision].[hkid] AS MOBILEORDERMNPDETAILREVISION_HKID,[MobileOrderMNPDetailRevision].[transfer_to_3g] AS MOBILEORDERMNPDETAILREVISION_TRANSFER_TO_3G,[MobileOrderMNPDetailRevision].[order_id] AS MOBILEORDERMNPDETAILREVISION_ORDER_ID,[MobileOrderMNPDetailRevision].[transfer_no_add_proof_deposit] AS MOBILEORDERMNPDETAILREVISION_TRANSFER_NO_ADD_PROOF_DEPOSIT,[MobileOrderMNPDetailRevision].[mid] AS MOBILEORDERMNPDETAILREVISION_MID,[MobileOrderMNPDetailRevision].[company_name] AS MOBILEORDERMNPDETAILREVISION_COMPANY_NAME,[MobileOrderMNPDetailRevision].[transfer_no_hk_id_holder_deposit] AS MOBILEORDERMNPDETAILREVISION_TRANSFER_NO_HK_ID_HOLDER_DEPOSIT  FROM  [MobileOrderMNPDetailRevision]  WHERE  [MobileOrderMNPDetailRevision].[mid] = \'"+x_lMid.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMNPDetailRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMNPDetailRevision]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.service_activation_time).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_SERVICE_ACTIVATION_TIME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.service_activation_time).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.service_activation_time).AliasName].ToString()] = (string)_oData["MOBILEORDERMNPDETAILREVISION_SERVICE_ACTIVATION_TIME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.service_activation_time).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.ticker_number).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_TICKER_NUMBER"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.ticker_number).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.ticker_number).AliasName].ToString()] = (string)_oData["MOBILEORDERMNPDETAILREVISION_TICKER_NUMBER"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.ticker_number).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.id_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_ID_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.id_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.id_type).AliasName].ToString()] = (string)_oData["MOBILEORDERMNPDETAILREVISION_ID_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.id_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_idd_roaming_deposit).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_IDD_ROAMING_DEPOSIT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_idd_roaming_deposit).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_idd_roaming_deposit).AliasName].ToString()] = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_IDD_ROAMING_DEPOSIT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_idd_roaming_deposit).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_idd_deposit).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_IDD_DEPOSIT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_idd_deposit).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_idd_deposit).AliasName].ToString()] = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_IDD_DEPOSIT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_idd_deposit).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.service_activation_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_SERVICE_ACTIVATION_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.service_activation_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.service_activation_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERMNPDETAILREVISION_SERVICE_ACTIVATION_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.service_activation_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.mnp_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_MNP_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.mnp_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.mnp_id).AliasName].ToString()] = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAILREVISION_MNP_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.mnp_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_others_deposit).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_OTHERS_DEPOSIT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_others_deposit).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_others_deposit).AliasName].ToString()] = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_OTHERS_DEPOSIT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_others_deposit).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.registered_name).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_REGISTERED_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.registered_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.registered_name).AliasName].ToString()] = (string)_oData["MOBILEORDERMNPDETAILREVISION_REGISTERED_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.registered_name).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.hkid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_HKID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.hkid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.hkid).AliasName].ToString()] = (string)_oData["MOBILEORDERMNPDETAILREVISION_HKID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.hkid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_to_3g).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_TO_3G"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_to_3g).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_to_3g).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_TO_3G"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_to_3g).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.order_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_ORDER_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.order_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.order_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERMNPDETAILREVISION_ORDER_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.order_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_no_add_proof_deposit).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_NO_ADD_PROOF_DEPOSIT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_no_add_proof_deposit).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_no_add_proof_deposit).AliasName].ToString()] = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_NO_ADD_PROOF_DEPOSIT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_no_add_proof_deposit).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.mid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_MID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.mid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.mid).AliasName].ToString()] = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAILREVISION_MID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.mid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.company_name).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_COMPANY_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.company_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.company_name).AliasName].ToString()] = (string)_oData["MOBILEORDERMNPDETAILREVISION_COMPANY_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.company_name).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_no_hk_id_holder_deposit).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_NO_HK_ID_HOLDER_DEPOSIT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_no_hk_id_holder_deposit).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_no_hk_id_holder_deposit).AliasName].ToString()] = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_NO_HK_ID_HOLDER_DEPOSIT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_no_hk_id_holder_deposit).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,MobileOrderMNPDetailRevision x_oMobileOrderMNPDetailRevisionRow)
        {
            return SetByDataSetRowProc(x_iROW, MobileOrderMNPDetailRevision.Para.TableName(), x_oDataSet,x_oMobileOrderMNPDetailRevisionRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderMNPDetailRevision x_oMobileOrderMNPDetailRevisionRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oMobileOrderMNPDetailRevisionRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderMNPDetailRevision x_oMobileOrderMNPDetailRevisionRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                MobileOrderMNPDetailRevisionInfo _oTableSet=MobileOrderMNPDetailRevisionInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.service_activation_time).AliasName))
                    x_oMobileOrderMNPDetailRevisionRow.service_activation_time = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.service_activation_time).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.ticker_number).AliasName))
                    x_oMobileOrderMNPDetailRevisionRow.ticker_number = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.ticker_number).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.id_type).AliasName))
                    x_oMobileOrderMNPDetailRevisionRow.id_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.id_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_idd_roaming_deposit).AliasName))
                    x_oMobileOrderMNPDetailRevisionRow.transfer_idd_roaming_deposit = (global::System.Nullable<long>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_idd_roaming_deposit).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.company_name).AliasName))
                    x_oMobileOrderMNPDetailRevisionRow.company_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.company_name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.service_activation_date).AliasName))
                    x_oMobileOrderMNPDetailRevisionRow.service_activation_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.service_activation_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.mnp_id).AliasName))
                    x_oMobileOrderMNPDetailRevisionRow.mnp_id = (global::System.Nullable<long>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.mnp_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_others_deposit).AliasName))
                    x_oMobileOrderMNPDetailRevisionRow.transfer_others_deposit = (global::System.Nullable<long>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_others_deposit).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.mid).AliasName))
                    x_oMobileOrderMNPDetailRevisionRow.mid = (global::System.Nullable<long>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.mid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.hkid).AliasName))
                    x_oMobileOrderMNPDetailRevisionRow.hkid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.hkid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_to_3g).AliasName))
                    x_oMobileOrderMNPDetailRevisionRow.transfer_to_3g = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_to_3g).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_idd_deposit).AliasName))
                    x_oMobileOrderMNPDetailRevisionRow.transfer_idd_deposit = (global::System.Nullable<long>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_idd_deposit).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_no_add_proof_deposit).AliasName))
                    x_oMobileOrderMNPDetailRevisionRow.transfer_no_add_proof_deposit = (global::System.Nullable<long>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_no_add_proof_deposit).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.order_id).AliasName))
                    x_oMobileOrderMNPDetailRevisionRow.order_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.order_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.registered_name).AliasName))
                    x_oMobileOrderMNPDetailRevisionRow.registered_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.registered_name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_no_hk_id_holder_deposit).AliasName))
                    x_oMobileOrderMNPDetailRevisionRow.transfer_no_hk_id_holder_deposit = (global::System.Nullable<long>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMNPDetailRevision.Para.transfer_no_hk_id_holder_deposit).AliasName];
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
            return MobileOrderMNPDetailRevisionRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static MobileOrderMNPDetailRevisionEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return MobileOrderMNPDetailRevisionRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static MobileOrderMNPDetailRevisionEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return MobileOrderMNPDetailRevisionRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderMNPDetailRevisionRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderMNPDetailRevisionRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderMNPDetailRevisionRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sService_activation_time,string x_sTicker_number,string x_sId_type,global::System.Nullable<long> x_lTransfer_idd_roaming_deposit,string x_sCompany_name,global::System.Nullable<DateTime> x_dService_activation_date,global::System.Nullable<long> x_lMnp_id,global::System.Nullable<long> x_lTransfer_others_deposit,string x_sHkid,global::System.Nullable<bool> x_bTransfer_to_3g,global::System.Nullable<long> x_lTransfer_idd_deposit,global::System.Nullable<long> x_lTransfer_no_add_proof_deposit,global::System.Nullable<int> x_iOrder_id,string x_sRegistered_name,global::System.Nullable<long> x_lTransfer_no_hk_id_holder_deposit)
        {
            return MobileOrderMNPDetailRevisionRepository.Insert(x_oDB, x_sService_activation_time,x_sTicker_number,x_sId_type,x_lTransfer_idd_roaming_deposit,x_sCompany_name,x_dService_activation_date,x_lMnp_id,x_lTransfer_others_deposit,x_sHkid,x_bTransfer_to_3g,x_lTransfer_idd_deposit,x_lTransfer_no_add_proof_deposit,x_iOrder_id,x_sRegistered_name,x_lTransfer_no_hk_id_holder_deposit);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderMNPDetailRevision x_oMobileOrderMNPDetailRevision)
        {
            return MobileOrderMNPDetailRevisionRepository.InsertWithOutLastID(x_oDB,x_oMobileOrderMNPDetailRevision);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sService_activation_time,string x_sTicker_number,string x_sId_type,global::System.Nullable<long> x_lTransfer_idd_roaming_deposit,string x_sCompany_name,global::System.Nullable<DateTime> x_dService_activation_date,global::System.Nullable<long> x_lMnp_id,global::System.Nullable<long> x_lTransfer_others_deposit,string x_sHkid,global::System.Nullable<bool> x_bTransfer_to_3g,global::System.Nullable<long> x_lTransfer_idd_deposit,global::System.Nullable<long> x_lTransfer_no_add_proof_deposit,global::System.Nullable<int> x_iOrder_id,string x_sRegistered_name,global::System.Nullable<long> x_lTransfer_no_hk_id_holder_deposit)
        {
            return MobileOrderMNPDetailRevisionRepository.InsertReturnLastID_SP(x_oDB,x_sService_activation_time,x_sTicker_number,x_sId_type,x_lTransfer_idd_roaming_deposit,x_sCompany_name,x_dService_activation_date,x_lMnp_id,x_lTransfer_others_deposit,x_sHkid,x_bTransfer_to_3g,x_lTransfer_idd_deposit,x_lTransfer_no_add_proof_deposit,x_iOrder_id,x_sRegistered_name,x_lTransfer_no_hk_id_holder_deposit);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderMNPDetailRevision x_oMobileOrderMNPDetailRevision)
        {
            return MobileOrderMNPDetailRevisionRepository.InsertReturnLastID_SP(x_oDB,x_oMobileOrderMNPDetailRevision);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return MobileOrderMNPDetailRevisionRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderMNPDetailRevisionRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<long> x_lMid)
        {
            return MobileOrderMNPDetailRevisionRepository.Delete(x_oDB, x_lMid);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(MobileOrderMNPDetailRevision x_oMobileOrderMNPDetailRevisionRow){
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


