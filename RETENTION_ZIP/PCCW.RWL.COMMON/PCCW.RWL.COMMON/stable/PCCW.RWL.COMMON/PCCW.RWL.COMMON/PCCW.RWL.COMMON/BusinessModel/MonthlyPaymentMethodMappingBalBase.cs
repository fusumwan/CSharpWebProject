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
///-- Create date: <Create Date 2011-11-09>
///-- Description:	<Description,Table :[MonthlyPaymentMethodMapping],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MonthlyPaymentMethodMapping] Business layer
    /// </summary>
    
    public abstract class MonthlyPaymentMethodMappingBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public MonthlyPaymentMethodMappingBalBase(){
        }
        ~MonthlyPaymentMethodMappingBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(MonthlyPaymentMethodMapping x_oMonthlyPaymentMethodMapping)
        {
            return GetDataSet(x_oMonthlyPaymentMethodMapping,null,MonthlyPaymentMethodMappingInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MonthlyPaymentMethodMapping x_oMonthlyPaymentMethodMapping,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oMonthlyPaymentMethodMapping,x_oMergeDSet,MonthlyPaymentMethodMappingInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MonthlyPaymentMethodMapping x_oMonthlyPaymentMethodMapping,MonthlyPaymentMethodMappingInfo x_oTableSet)
        {
            return GetDataSet(x_oMonthlyPaymentMethodMapping,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MonthlyPaymentMethodMapping x_oMonthlyPaymentMethodMapping,global::System.Data.DataSet x_oMergeDSet,MonthlyPaymentMethodMappingInfo x_oTableSet)
        {
            return GetDataSet(x_oMonthlyPaymentMethodMapping,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(MonthlyPaymentMethodMapping x_oMonthlyPaymentMethodMapping,global::System.Data.DataSet x_oMergeDSet,MonthlyPaymentMethodMappingInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MonthlyPaymentMethodMappingInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(MonthlyPaymentMethodMapping.Para.TableName());
            if (x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.cash_group).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MonthlyPaymentMethodMapping.Para.TableName()].Columns.Add(MonthlyPaymentMethodMapping.Para.cash_group); }
            if (x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MonthlyPaymentMethodMapping.Para.TableName()].Columns.Add(MonthlyPaymentMethodMapping.Para.id); }
            if (x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MonthlyPaymentMethodMapping.Para.TableName()].Columns.Add(MonthlyPaymentMethodMapping.Para.active); }
            if (x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.credit_card_group).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MonthlyPaymentMethodMapping.Para.TableName()].Columns.Add(MonthlyPaymentMethodMapping.Para.credit_card_group); }
            if (x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.payment_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MonthlyPaymentMethodMapping.Para.TableName()].Columns.Add(MonthlyPaymentMethodMapping.Para.payment_type); }
            if (x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.program).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MonthlyPaymentMethodMapping.Para.TableName()].Columns.Add(MonthlyPaymentMethodMapping.Para.program); }
            if (x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.issue_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MonthlyPaymentMethodMapping.Para.TableName()].Columns.Add(MonthlyPaymentMethodMapping.Para.issue_type); }
            if (x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.third_party_credit_card).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MonthlyPaymentMethodMapping.Para.TableName()].Columns.Add(MonthlyPaymentMethodMapping.Para.third_party_credit_card); }
            if (x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.bank_account_group).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MonthlyPaymentMethodMapping.Para.TableName()].Columns.Add(MonthlyPaymentMethodMapping.Para.bank_account_group); }
            if (x_oMonthlyPaymentMethodMapping != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[MonthlyPaymentMethodMapping.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.cash_group).IsView || x_oTableSet.GetViewAll()) { _oDRow[MonthlyPaymentMethodMapping.Para.cash_group] = x_oMonthlyPaymentMethodMapping.GetCash_group(); }
                if (x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MonthlyPaymentMethodMapping.Para.id] = x_oMonthlyPaymentMethodMapping.GetId(); }
                if (x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[MonthlyPaymentMethodMapping.Para.active] = x_oMonthlyPaymentMethodMapping.GetActive(); }
                if (x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.credit_card_group).IsView || x_oTableSet.GetViewAll()) { _oDRow[MonthlyPaymentMethodMapping.Para.credit_card_group] = x_oMonthlyPaymentMethodMapping.GetCredit_card_group(); }
                if (x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.payment_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MonthlyPaymentMethodMapping.Para.payment_type] = x_oMonthlyPaymentMethodMapping.GetPayment_type(); }
                if (x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.program).IsView || x_oTableSet.GetViewAll()) { _oDRow[MonthlyPaymentMethodMapping.Para.program] = x_oMonthlyPaymentMethodMapping.GetProgram(); }
                if (x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.issue_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MonthlyPaymentMethodMapping.Para.issue_type] = x_oMonthlyPaymentMethodMapping.GetIssue_type(); }
                if (x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.third_party_credit_card).IsView || x_oTableSet.GetViewAll()) { _oDRow[MonthlyPaymentMethodMapping.Para.third_party_credit_card] = x_oMonthlyPaymentMethodMapping.GetThird_party_credit_card(); }
                if (x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.bank_account_group).IsView || x_oTableSet.GetViewAll()) { _oDRow[MonthlyPaymentMethodMapping.Para.bank_account_group] = x_oMonthlyPaymentMethodMapping.GetBank_account_group(); }
                _oDSet.Tables[MonthlyPaymentMethodMapping.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(MonthlyPaymentMethodMappingInfo x_oTableSet)
        {
            return MonthlyPaymentMethodMappingBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return MonthlyPaymentMethodMappingBal.ToEmptyDataSetProcess(MonthlyPaymentMethodMappingInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(MonthlyPaymentMethodMappingInfo x_oTableSet)
        {
            return MonthlyPaymentMethodMappingBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(MonthlyPaymentMethodMapping x_oMonthlyPaymentMethodMapping, MonthlyPaymentMethodMappingInfo x_oTableSet)
        {
            return MonthlyPaymentMethodMappingBal.GetDataSet(null, null, x_oTableSet).Tables[MonthlyPaymentMethodMapping.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(MonthlyPaymentMethodMapping x_oMonthlyPaymentMethodMapping)
        {
            return MonthlyPaymentMethodMappingBal.GetDataSet(x_oMonthlyPaymentMethodMapping, null, MonthlyPaymentMethodMappingInfoDLL.CreateInfoInstanceObject()).Tables[MonthlyPaymentMethodMapping.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return Row(x_oTable, x_oDB,x_iId,MonthlyPaymentMethodMappingInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId, MonthlyPaymentMethodMappingInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iId, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId,MonthlyPaymentMethodMappingInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MonthlyPaymentMethodMappingInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [MonthlyPaymentMethodMapping].[cash_group] AS MONTHLYPAYMENTMETHODMAPPING_CASH_GROUP,[MonthlyPaymentMethodMapping].[id] AS MONTHLYPAYMENTMETHODMAPPING_ID,[MonthlyPaymentMethodMapping].[active] AS MONTHLYPAYMENTMETHODMAPPING_ACTIVE,[MonthlyPaymentMethodMapping].[credit_card_group] AS MONTHLYPAYMENTMETHODMAPPING_CREDIT_CARD_GROUP,[MonthlyPaymentMethodMapping].[payment_type] AS MONTHLYPAYMENTMETHODMAPPING_PAYMENT_TYPE,[MonthlyPaymentMethodMapping].[program] AS MONTHLYPAYMENTMETHODMAPPING_PROGRAM,[MonthlyPaymentMethodMapping].[issue_type] AS MONTHLYPAYMENTMETHODMAPPING_ISSUE_TYPE,[MonthlyPaymentMethodMapping].[bank_account_group] AS MONTHLYPAYMENTMETHODMAPPING_BANK_ACCOUNT_GROUP,[MonthlyPaymentMethodMapping].[third_party_credit_card] AS MONTHLYPAYMENTMETHODMAPPING_THIRD_PARTY_CREDIT_CARD  FROM  [MonthlyPaymentMethodMapping]  WHERE  [MonthlyPaymentMethodMapping].[id] = \'"+x_iId.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MonthlyPaymentMethodMapping]","["+ Configurator.MSSQLTablePrefix + "MonthlyPaymentMethodMapping]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.cash_group).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_CASH_GROUP"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.cash_group).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.cash_group).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MONTHLYPAYMENTMETHODMAPPING_CASH_GROUP"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.cash_group).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MONTHLYPAYMENTMETHODMAPPING_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MONTHLYPAYMENTMETHODMAPPING_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.credit_card_group).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_CREDIT_CARD_GROUP"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.credit_card_group).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.credit_card_group).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MONTHLYPAYMENTMETHODMAPPING_CREDIT_CARD_GROUP"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.credit_card_group).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.payment_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_PAYMENT_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.payment_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.payment_type).AliasName].ToString()] = (string)_oData["MONTHLYPAYMENTMETHODMAPPING_PAYMENT_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.payment_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.program).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_PROGRAM"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.program).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.program).AliasName].ToString()] = (string)_oData["MONTHLYPAYMENTMETHODMAPPING_PROGRAM"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.program).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.issue_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_ISSUE_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.issue_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.issue_type).AliasName].ToString()] = (string)_oData["MONTHLYPAYMENTMETHODMAPPING_ISSUE_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.issue_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.bank_account_group).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_BANK_ACCOUNT_GROUP"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.bank_account_group).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.bank_account_group).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MONTHLYPAYMENTMETHODMAPPING_BANK_ACCOUNT_GROUP"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.bank_account_group).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.third_party_credit_card).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_THIRD_PARTY_CREDIT_CARD"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.third_party_credit_card).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.third_party_credit_card).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MONTHLYPAYMENTMETHODMAPPING_THIRD_PARTY_CREDIT_CARD"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.third_party_credit_card).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,MonthlyPaymentMethodMapping x_oMonthlyPaymentMethodMappingRow)
        {
            return SetByDataSetRowProc(x_iROW, MonthlyPaymentMethodMapping.Para.TableName(), x_oDataSet,x_oMonthlyPaymentMethodMappingRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MonthlyPaymentMethodMapping x_oMonthlyPaymentMethodMappingRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oMonthlyPaymentMethodMappingRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MonthlyPaymentMethodMapping x_oMonthlyPaymentMethodMappingRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                MonthlyPaymentMethodMappingInfo _oTableSet=MonthlyPaymentMethodMappingInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.cash_group).AliasName))
                    x_oMonthlyPaymentMethodMappingRow.cash_group = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.cash_group).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.id).AliasName))
                    x_oMonthlyPaymentMethodMappingRow.id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.active).AliasName))
                    x_oMonthlyPaymentMethodMappingRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.credit_card_group).AliasName))
                    x_oMonthlyPaymentMethodMappingRow.credit_card_group = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.credit_card_group).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.payment_type).AliasName))
                    x_oMonthlyPaymentMethodMappingRow.payment_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.payment_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.program).AliasName))
                    x_oMonthlyPaymentMethodMappingRow.program = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.program).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.issue_type).AliasName))
                    x_oMonthlyPaymentMethodMappingRow.issue_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.issue_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.third_party_credit_card).AliasName))
                    x_oMonthlyPaymentMethodMappingRow.third_party_credit_card = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.third_party_credit_card).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.bank_account_group).AliasName))
                    x_oMonthlyPaymentMethodMappingRow.bank_account_group = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MonthlyPaymentMethodMapping.Para.bank_account_group).AliasName];
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
            return MonthlyPaymentMethodMappingRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static MonthlyPaymentMethodMappingEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return MonthlyPaymentMethodMappingRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static MonthlyPaymentMethodMappingEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return MonthlyPaymentMethodMappingRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MonthlyPaymentMethodMappingRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MonthlyPaymentMethodMappingRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return MonthlyPaymentMethodMappingRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bCash_group,global::System.Nullable<bool> x_bActive,global::System.Nullable<bool> x_bCredit_card_group,string x_sPayment_type,string x_sProgram,string x_sIssue_type,global::System.Nullable<bool> x_bThird_party_credit_card,global::System.Nullable<bool> x_bBank_account_group)
        {
            return MonthlyPaymentMethodMappingRepository.Insert(x_oDB, x_bCash_group,x_bActive,x_bCredit_card_group,x_sPayment_type,x_sProgram,x_sIssue_type,x_bThird_party_credit_card,x_bBank_account_group);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MonthlyPaymentMethodMapping x_oMonthlyPaymentMethodMapping)
        {
            return MonthlyPaymentMethodMappingRepository.InsertWithOutLastID(x_oDB,x_oMonthlyPaymentMethodMapping);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<bool> x_bCash_group,global::System.Nullable<bool> x_bActive,global::System.Nullable<bool> x_bCredit_card_group,string x_sPayment_type,string x_sProgram,string x_sIssue_type,global::System.Nullable<bool> x_bThird_party_credit_card,global::System.Nullable<bool> x_bBank_account_group)
        {
            return MonthlyPaymentMethodMappingRepository.InsertReturnLastID_SP(x_oDB,x_bCash_group,x_bActive,x_bCredit_card_group,x_sPayment_type,x_sProgram,x_sIssue_type,x_bThird_party_credit_card,x_bBank_account_group);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MonthlyPaymentMethodMapping x_oMonthlyPaymentMethodMapping)
        {
            return MonthlyPaymentMethodMappingRepository.InsertReturnLastID_SP(x_oDB,x_oMonthlyPaymentMethodMapping);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return MonthlyPaymentMethodMappingRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return MonthlyPaymentMethodMappingRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return MonthlyPaymentMethodMappingRepository.Delete(x_oDB, x_iId);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(MonthlyPaymentMethodMapping x_oMonthlyPaymentMethodMappingRow){
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


