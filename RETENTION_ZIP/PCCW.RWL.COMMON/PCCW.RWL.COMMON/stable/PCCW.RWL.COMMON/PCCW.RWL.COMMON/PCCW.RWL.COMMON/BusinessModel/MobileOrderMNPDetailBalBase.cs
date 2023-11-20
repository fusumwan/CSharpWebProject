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
///-- Description:	<Description,Table :[MobileOrderMNPDetail],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderMNPDetail] Business layer
    /// </summary>
    
    public abstract class MobileOrderMNPDetailBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public MobileOrderMNPDetailBalBase(){
        }
        ~MobileOrderMNPDetailBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderMNPDetail x_oMobileOrderMNPDetail)
        {
            return GetDataSet(x_oMobileOrderMNPDetail,null,MobileOrderMNPDetailInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderMNPDetail x_oMobileOrderMNPDetail,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oMobileOrderMNPDetail,x_oMergeDSet,MobileOrderMNPDetailInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderMNPDetail x_oMobileOrderMNPDetail,MobileOrderMNPDetailInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderMNPDetail,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderMNPDetail x_oMobileOrderMNPDetail,global::System.Data.DataSet x_oMergeDSet,MobileOrderMNPDetailInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderMNPDetail,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(MobileOrderMNPDetail x_oMobileOrderMNPDetail,global::System.Data.DataSet x_oMergeDSet,MobileOrderMNPDetailInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderMNPDetailInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(MobileOrderMNPDetail.Para.TableName());
            if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.service_activation_time).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMNPDetail.Para.TableName()].Columns.Add(MobileOrderMNPDetail.Para.service_activation_time); }
            if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.ticker_number).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMNPDetail.Para.TableName()].Columns.Add(MobileOrderMNPDetail.Para.ticker_number); }
            if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.id_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMNPDetail.Para.TableName()].Columns.Add(MobileOrderMNPDetail.Para.id_type); }
            if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_idd_roaming_deposit).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMNPDetail.Para.TableName()].Columns.Add(MobileOrderMNPDetail.Para.transfer_idd_roaming_deposit); }
            if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.company_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMNPDetail.Para.TableName()].Columns.Add(MobileOrderMNPDetail.Para.company_name); }
            if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.service_activation_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMNPDetail.Para.TableName()].Columns.Add(MobileOrderMNPDetail.Para.service_activation_date); }
            if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.mnp_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMNPDetail.Para.TableName()].Columns.Add(MobileOrderMNPDetail.Para.mnp_id); }
            if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_others_deposit).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMNPDetail.Para.TableName()].Columns.Add(MobileOrderMNPDetail.Para.transfer_others_deposit); }
            if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.hkid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMNPDetail.Para.TableName()].Columns.Add(MobileOrderMNPDetail.Para.hkid); }
            if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_to_3g).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMNPDetail.Para.TableName()].Columns.Add(MobileOrderMNPDetail.Para.transfer_to_3g); }
            if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_idd_deposit).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMNPDetail.Para.TableName()].Columns.Add(MobileOrderMNPDetail.Para.transfer_idd_deposit); }
            if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_no_add_proof_deposit).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMNPDetail.Para.TableName()].Columns.Add(MobileOrderMNPDetail.Para.transfer_no_add_proof_deposit); }
            if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMNPDetail.Para.TableName()].Columns.Add(MobileOrderMNPDetail.Para.order_id); }
            if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.registered_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMNPDetail.Para.TableName()].Columns.Add(MobileOrderMNPDetail.Para.registered_name); }
            if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_no_hk_id_holder_deposit).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMNPDetail.Para.TableName()].Columns.Add(MobileOrderMNPDetail.Para.transfer_no_hk_id_holder_deposit); }
            if (x_oMobileOrderMNPDetail != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[MobileOrderMNPDetail.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.service_activation_time).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMNPDetail.Para.service_activation_time] = x_oMobileOrderMNPDetail.GetService_activation_time(); }
                if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.ticker_number).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMNPDetail.Para.ticker_number] = x_oMobileOrderMNPDetail.GetTicker_number(); }
                if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.id_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMNPDetail.Para.id_type] = x_oMobileOrderMNPDetail.GetId_type(); }
                if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_idd_roaming_deposit).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMNPDetail.Para.transfer_idd_roaming_deposit] = x_oMobileOrderMNPDetail.GetTransfer_idd_roaming_deposit(); }
                if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.company_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMNPDetail.Para.company_name] = x_oMobileOrderMNPDetail.GetCompany_name(); }
                if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.service_activation_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMNPDetail.Para.service_activation_date] = x_oMobileOrderMNPDetail.GetService_activation_date(); }
                if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.mnp_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMNPDetail.Para.mnp_id] = x_oMobileOrderMNPDetail.GetMnp_id(); }
                if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_others_deposit).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMNPDetail.Para.transfer_others_deposit] = x_oMobileOrderMNPDetail.GetTransfer_others_deposit(); }
                if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.hkid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMNPDetail.Para.hkid] = x_oMobileOrderMNPDetail.GetHkid(); }
                if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_to_3g).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMNPDetail.Para.transfer_to_3g] = x_oMobileOrderMNPDetail.GetTransfer_to_3g(); }
                if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_idd_deposit).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMNPDetail.Para.transfer_idd_deposit] = x_oMobileOrderMNPDetail.GetTransfer_idd_deposit(); }
                if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_no_add_proof_deposit).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMNPDetail.Para.transfer_no_add_proof_deposit] = x_oMobileOrderMNPDetail.GetTransfer_no_add_proof_deposit(); }
                if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMNPDetail.Para.order_id] = x_oMobileOrderMNPDetail.GetOrder_id(); }
                if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.registered_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMNPDetail.Para.registered_name] = x_oMobileOrderMNPDetail.GetRegistered_name(); }
                if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_no_hk_id_holder_deposit).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMNPDetail.Para.transfer_no_hk_id_holder_deposit] = x_oMobileOrderMNPDetail.GetTransfer_no_hk_id_holder_deposit(); }
                _oDSet.Tables[MobileOrderMNPDetail.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(MobileOrderMNPDetailInfo x_oTableSet)
        {
            return MobileOrderMNPDetailBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return MobileOrderMNPDetailBal.ToEmptyDataSetProcess(MobileOrderMNPDetailInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(MobileOrderMNPDetailInfo x_oTableSet)
        {
            return MobileOrderMNPDetailBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(MobileOrderMNPDetail x_oMobileOrderMNPDetail, MobileOrderMNPDetailInfo x_oTableSet)
        {
            return MobileOrderMNPDetailBal.GetDataSet(null, null, x_oTableSet).Tables[MobileOrderMNPDetail.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(MobileOrderMNPDetail x_oMobileOrderMNPDetail)
        {
            return MobileOrderMNPDetailBal.GetDataSet(x_oMobileOrderMNPDetail, null, MobileOrderMNPDetailInfoDLL.CreateInfoInstanceObject()).Tables[MobileOrderMNPDetail.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<long> x_lMnp_id)
        {
            return Row(x_oTable, x_oDB,x_lMnp_id,MobileOrderMNPDetailInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<long> x_lMnp_id, MobileOrderMNPDetailInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_lMnp_id, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<long> x_lMnp_id,MobileOrderMNPDetailInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderMNPDetailInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [MobileOrderMNPDetail].[service_activation_time] AS MOBILEORDERMNPDETAIL_SERVICE_ACTIVATION_TIME,[MobileOrderMNPDetail].[ticker_number] AS MOBILEORDERMNPDETAIL_TICKER_NUMBER,[MobileOrderMNPDetail].[id_type] AS MOBILEORDERMNPDETAIL_ID_TYPE,[MobileOrderMNPDetail].[transfer_idd_roaming_deposit] AS MOBILEORDERMNPDETAIL_TRANSFER_IDD_ROAMING_DEPOSIT,[MobileOrderMNPDetail].[transfer_idd_deposit] AS MOBILEORDERMNPDETAIL_TRANSFER_IDD_DEPOSIT,[MobileOrderMNPDetail].[service_activation_date] AS MOBILEORDERMNPDETAIL_SERVICE_ACTIVATION_DATE,[MobileOrderMNPDetail].[mnp_id] AS MOBILEORDERMNPDETAIL_MNP_ID,[MobileOrderMNPDetail].[transfer_others_deposit] AS MOBILEORDERMNPDETAIL_TRANSFER_OTHERS_DEPOSIT,[MobileOrderMNPDetail].[registered_name] AS MOBILEORDERMNPDETAIL_REGISTERED_NAME,[MobileOrderMNPDetail].[hkid] AS MOBILEORDERMNPDETAIL_HKID,[MobileOrderMNPDetail].[transfer_to_3g] AS MOBILEORDERMNPDETAIL_TRANSFER_TO_3G,[MobileOrderMNPDetail].[order_id] AS MOBILEORDERMNPDETAIL_ORDER_ID,[MobileOrderMNPDetail].[transfer_no_add_proof_deposit] AS MOBILEORDERMNPDETAIL_TRANSFER_NO_ADD_PROOF_DEPOSIT,[MobileOrderMNPDetail].[company_name] AS MOBILEORDERMNPDETAIL_COMPANY_NAME,[MobileOrderMNPDetail].[transfer_no_hk_id_holder_deposit] AS MOBILEORDERMNPDETAIL_TRANSFER_NO_HK_ID_HOLDER_DEPOSIT  FROM  [MobileOrderMNPDetail]  WHERE  [MobileOrderMNPDetail].[mnp_id] = \'"+x_lMnp_id.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMNPDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMNPDetail]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.service_activation_time).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_SERVICE_ACTIVATION_TIME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMNPDetail.Para.service_activation_time).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetail.Para.service_activation_time).AliasName].ToString()] = (string)_oData["MOBILEORDERMNPDETAIL_SERVICE_ACTIVATION_TIME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetail.Para.service_activation_time).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.ticker_number).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_TICKER_NUMBER"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMNPDetail.Para.ticker_number).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetail.Para.ticker_number).AliasName].ToString()] = (string)_oData["MOBILEORDERMNPDETAIL_TICKER_NUMBER"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetail.Para.ticker_number).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.id_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_ID_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMNPDetail.Para.id_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetail.Para.id_type).AliasName].ToString()] = (string)_oData["MOBILEORDERMNPDETAIL_ID_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetail.Para.id_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_idd_roaming_deposit).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_TRANSFER_IDD_ROAMING_DEPOSIT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_idd_roaming_deposit).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_idd_roaming_deposit).AliasName].ToString()] = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAIL_TRANSFER_IDD_ROAMING_DEPOSIT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_idd_roaming_deposit).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_idd_deposit).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_TRANSFER_IDD_DEPOSIT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_idd_deposit).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_idd_deposit).AliasName].ToString()] = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAIL_TRANSFER_IDD_DEPOSIT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_idd_deposit).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.service_activation_date).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_SERVICE_ACTIVATION_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMNPDetail.Para.service_activation_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetail.Para.service_activation_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEORDERMNPDETAIL_SERVICE_ACTIVATION_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetail.Para.service_activation_date).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.mnp_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_MNP_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMNPDetail.Para.mnp_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetail.Para.mnp_id).AliasName].ToString()] = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAIL_MNP_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetail.Para.mnp_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_others_deposit).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_TRANSFER_OTHERS_DEPOSIT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_others_deposit).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_others_deposit).AliasName].ToString()] = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAIL_TRANSFER_OTHERS_DEPOSIT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_others_deposit).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.registered_name).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_REGISTERED_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMNPDetail.Para.registered_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetail.Para.registered_name).AliasName].ToString()] = (string)_oData["MOBILEORDERMNPDETAIL_REGISTERED_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetail.Para.registered_name).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.hkid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_HKID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMNPDetail.Para.hkid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetail.Para.hkid).AliasName].ToString()] = (string)_oData["MOBILEORDERMNPDETAIL_HKID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetail.Para.hkid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_to_3g).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_TRANSFER_TO_3G"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_to_3g).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_to_3g).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILEORDERMNPDETAIL_TRANSFER_TO_3G"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_to_3g).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.order_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_ORDER_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMNPDetail.Para.order_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetail.Para.order_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERMNPDETAIL_ORDER_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetail.Para.order_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_no_add_proof_deposit).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_TRANSFER_NO_ADD_PROOF_DEPOSIT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_no_add_proof_deposit).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_no_add_proof_deposit).AliasName].ToString()] = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAIL_TRANSFER_NO_ADD_PROOF_DEPOSIT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_no_add_proof_deposit).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.company_name).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_COMPANY_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMNPDetail.Para.company_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetail.Para.company_name).AliasName].ToString()] = (string)_oData["MOBILEORDERMNPDETAIL_COMPANY_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetail.Para.company_name).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_no_hk_id_holder_deposit).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_TRANSFER_NO_HK_ID_HOLDER_DEPOSIT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_no_hk_id_holder_deposit).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_no_hk_id_holder_deposit).AliasName].ToString()] = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAIL_TRANSFER_NO_HK_ID_HOLDER_DEPOSIT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_no_hk_id_holder_deposit).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,MobileOrderMNPDetail x_oMobileOrderMNPDetailRow)
        {
            return SetByDataSetRowProc(x_iROW, MobileOrderMNPDetail.Para.TableName(), x_oDataSet,x_oMobileOrderMNPDetailRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderMNPDetail x_oMobileOrderMNPDetailRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oMobileOrderMNPDetailRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderMNPDetail x_oMobileOrderMNPDetailRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                MobileOrderMNPDetailInfo _oTableSet=MobileOrderMNPDetailInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMNPDetail.Para.service_activation_time).AliasName))
                    x_oMobileOrderMNPDetailRow.service_activation_time = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMNPDetail.Para.service_activation_time).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMNPDetail.Para.ticker_number).AliasName))
                    x_oMobileOrderMNPDetailRow.ticker_number = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMNPDetail.Para.ticker_number).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMNPDetail.Para.id_type).AliasName))
                    x_oMobileOrderMNPDetailRow.id_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMNPDetail.Para.id_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_idd_roaming_deposit).AliasName))
                    x_oMobileOrderMNPDetailRow.transfer_idd_roaming_deposit = (global::System.Nullable<long>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_idd_roaming_deposit).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMNPDetail.Para.company_name).AliasName))
                    x_oMobileOrderMNPDetailRow.company_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMNPDetail.Para.company_name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMNPDetail.Para.service_activation_date).AliasName))
                    x_oMobileOrderMNPDetailRow.service_activation_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMNPDetail.Para.service_activation_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMNPDetail.Para.mnp_id).AliasName))
                    x_oMobileOrderMNPDetailRow.mnp_id = (global::System.Nullable<long>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMNPDetail.Para.mnp_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_others_deposit).AliasName))
                    x_oMobileOrderMNPDetailRow.transfer_others_deposit = (global::System.Nullable<long>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_others_deposit).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMNPDetail.Para.hkid).AliasName))
                    x_oMobileOrderMNPDetailRow.hkid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMNPDetail.Para.hkid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_to_3g).AliasName))
                    x_oMobileOrderMNPDetailRow.transfer_to_3g = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_to_3g).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_idd_deposit).AliasName))
                    x_oMobileOrderMNPDetailRow.transfer_idd_deposit = (global::System.Nullable<long>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_idd_deposit).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_no_add_proof_deposit).AliasName))
                    x_oMobileOrderMNPDetailRow.transfer_no_add_proof_deposit = (global::System.Nullable<long>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_no_add_proof_deposit).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMNPDetail.Para.order_id).AliasName))
                    x_oMobileOrderMNPDetailRow.order_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMNPDetail.Para.order_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMNPDetail.Para.registered_name).AliasName))
                    x_oMobileOrderMNPDetailRow.registered_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMNPDetail.Para.registered_name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_no_hk_id_holder_deposit).AliasName))
                    x_oMobileOrderMNPDetailRow.transfer_no_hk_id_holder_deposit = (global::System.Nullable<long>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMNPDetail.Para.transfer_no_hk_id_holder_deposit).AliasName];
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
            return MobileOrderMNPDetailRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static MobileOrderMNPDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return MobileOrderMNPDetailRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static MobileOrderMNPDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return MobileOrderMNPDetailRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderMNPDetailRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderMNPDetailRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderMNPDetailRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sService_activation_time,string x_sTicker_number,string x_sId_type,global::System.Nullable<long> x_lTransfer_idd_roaming_deposit,string x_sCompany_name,global::System.Nullable<DateTime> x_dService_activation_date,global::System.Nullable<long> x_lTransfer_others_deposit,string x_sHkid,global::System.Nullable<bool> x_bTransfer_to_3g,global::System.Nullable<long> x_lTransfer_idd_deposit,global::System.Nullable<long> x_lTransfer_no_add_proof_deposit,global::System.Nullable<int> x_iOrder_id,string x_sRegistered_name,global::System.Nullable<long> x_lTransfer_no_hk_id_holder_deposit)
        {
            return MobileOrderMNPDetailRepository.Insert(x_oDB, x_sService_activation_time,x_sTicker_number,x_sId_type,x_lTransfer_idd_roaming_deposit,x_sCompany_name,x_dService_activation_date,x_lTransfer_others_deposit,x_sHkid,x_bTransfer_to_3g,x_lTransfer_idd_deposit,x_lTransfer_no_add_proof_deposit,x_iOrder_id,x_sRegistered_name,x_lTransfer_no_hk_id_holder_deposit);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderMNPDetail x_oMobileOrderMNPDetail)
        {
            return MobileOrderMNPDetailRepository.InsertWithOutLastID(x_oDB,x_oMobileOrderMNPDetail);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sService_activation_time,string x_sTicker_number,string x_sId_type,global::System.Nullable<long> x_lTransfer_idd_roaming_deposit,string x_sCompany_name,global::System.Nullable<DateTime> x_dService_activation_date,global::System.Nullable<long> x_lTransfer_others_deposit,string x_sHkid,global::System.Nullable<bool> x_bTransfer_to_3g,global::System.Nullable<long> x_lTransfer_idd_deposit,global::System.Nullable<long> x_lTransfer_no_add_proof_deposit,global::System.Nullable<int> x_iOrder_id,string x_sRegistered_name,global::System.Nullable<long> x_lTransfer_no_hk_id_holder_deposit)
        {
            return MobileOrderMNPDetailRepository.InsertReturnLastID_SP(x_oDB,x_sService_activation_time,x_sTicker_number,x_sId_type,x_lTransfer_idd_roaming_deposit,x_sCompany_name,x_dService_activation_date,x_lTransfer_others_deposit,x_sHkid,x_bTransfer_to_3g,x_lTransfer_idd_deposit,x_lTransfer_no_add_proof_deposit,x_iOrder_id,x_sRegistered_name,x_lTransfer_no_hk_id_holder_deposit);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderMNPDetail x_oMobileOrderMNPDetail)
        {
            return MobileOrderMNPDetailRepository.InsertReturnLastID_SP(x_oDB,x_oMobileOrderMNPDetail);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return MobileOrderMNPDetailRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderMNPDetailRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<long> x_lMnp_id)
        {
            return MobileOrderMNPDetailRepository.Delete(x_oDB, x_lMnp_id);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(MobileOrderMNPDetail x_oMobileOrderMNPDetailRow){
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


