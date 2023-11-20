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
///-- Create date: <Create Date 2009-09-29>
///-- Description:	<Description,Table :[CustomerAccount],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [CustomerAccount] Business layer
    /// </summary>

    public abstract class CustomerAccountBalBase
    {

        #region Constructor


        // ******************************
        // *  Handler for Class Constructor
        // ******************************

        public CustomerAccountBalBase()
        {
        }
        ~CustomerAccountBalBase()
        {
            this.Release();
        }
        #endregion


        #region ToDataSet


        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************

        public static global::System.Data.DataSet ToDataSet(CustomerAccount x_oCustomerAccount)
        {
            return GetDataSet(x_oCustomerAccount, null, CustomerAccountInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(CustomerAccount x_oCustomerAccount, global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oCustomerAccount, x_oMergeDSet, CustomerAccountInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(CustomerAccount x_oCustomerAccount, CustomerAccountInfo x_oTableSet)
        {
            return GetDataSet(x_oCustomerAccount, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToDataSet(CustomerAccount x_oCustomerAccount, global::System.Data.DataSet x_oMergeDSet, CustomerAccountInfo x_oTableSet)
        {
            return GetDataSet(x_oCustomerAccount, x_oMergeDSet, x_oTableSet);
        }


        protected static global::System.Data.DataSet GetDataSet(CustomerAccount x_oCustomerAccount, global::System.Data.DataSet x_oMergeDSet, CustomerAccountInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = CustomerAccountInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(CustomerAccount.Para.TableName());
            if (x_oTableSet.Fields(CustomerAccount.Para.remarks).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[CustomerAccount.Para.TableName()].Columns.Add(CustomerAccount.Para.remarks); }
            if (x_oTableSet.Fields(CustomerAccount.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[CustomerAccount.Para.TableName()].Columns.Add(CustomerAccount.Para.id); }
            if (x_oTableSet.Fields(CustomerAccount.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[CustomerAccount.Para.TableName()].Columns.Add(CustomerAccount.Para.cdate); }
            if (x_oTableSet.Fields(CustomerAccount.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[CustomerAccount.Para.TableName()].Columns.Add(CustomerAccount.Para.cid); }
            if (x_oTableSet.Fields(CustomerAccount.Para.mrt_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[CustomerAccount.Para.TableName()].Columns.Add(CustomerAccount.Para.mrt_no); }
            if (x_oTableSet.Fields(CustomerAccount.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[CustomerAccount.Para.TableName()].Columns.Add(CustomerAccount.Para.active); }
            if (x_oTableSet.Fields(CustomerAccount.Para.ac_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[CustomerAccount.Para.TableName()].Columns.Add(CustomerAccount.Para.ac_no); }
            if (x_oTableSet.Fields(CustomerAccount.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[CustomerAccount.Para.TableName()].Columns.Add(CustomerAccount.Para.order_id); }
            if (x_oTableSet.Fields(CustomerAccount.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[CustomerAccount.Para.TableName()].Columns.Add(CustomerAccount.Para.ddate); }
            if (x_oTableSet.Fields(CustomerAccount.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[CustomerAccount.Para.TableName()].Columns.Add(CustomerAccount.Para.did); }
            if (x_oCustomerAccount != null)
            {
                global::System.Data.DataRow _oDRow = _oDSet.Tables[CustomerAccount.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(CustomerAccount.Para.remarks).IsView || x_oTableSet.GetViewAll()) { _oDRow[CustomerAccount.Para.remarks] = x_oCustomerAccount.GetRemarks(); }
                if (x_oTableSet.Fields(CustomerAccount.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[CustomerAccount.Para.id] = x_oCustomerAccount.GetId(); }
                if (x_oTableSet.Fields(CustomerAccount.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[CustomerAccount.Para.cdate] = x_oCustomerAccount.GetCdate(); }
                if (x_oTableSet.Fields(CustomerAccount.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[CustomerAccount.Para.cid] = x_oCustomerAccount.GetCid(); }
                if (x_oTableSet.Fields(CustomerAccount.Para.mrt_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[CustomerAccount.Para.mrt_no] = x_oCustomerAccount.GetMrt_no(); }
                if (x_oTableSet.Fields(CustomerAccount.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[CustomerAccount.Para.active] = x_oCustomerAccount.GetActive(); }
                if (x_oTableSet.Fields(CustomerAccount.Para.ac_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[CustomerAccount.Para.ac_no] = x_oCustomerAccount.GetAc_no(); }
                if (x_oTableSet.Fields(CustomerAccount.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[CustomerAccount.Para.order_id] = x_oCustomerAccount.GetOrder_id(); }
                if (x_oTableSet.Fields(CustomerAccount.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[CustomerAccount.Para.ddate] = x_oCustomerAccount.GetDdate(); }
                if (x_oTableSet.Fields(CustomerAccount.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[CustomerAccount.Para.did] = x_oCustomerAccount.GetDid(); }
                _oDSet.Tables[CustomerAccount.Para.TableName()].Rows.Add(_oDRow);
            }
            if (x_oMergeDSet != null) { _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }


        protected static global::System.Data.DataSet ToEmptyDataSetProcess(CustomerAccountInfo x_oTableSet)
        {
            return CustomerAccountBal.GetDataSet(null, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return CustomerAccountBal.ToEmptyDataSetProcess(CustomerAccountInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToEmptyDataSet(CustomerAccountInfo x_oTableSet)
        {
            return CustomerAccountBal.ToEmptyDataSetProcess(x_oTableSet);
        }


        #endregion ToDataSet

        #region To Table

        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(CustomerAccount x_oCustomerAccount, CustomerAccountInfo x_oTableSet)
        {
            return CustomerAccountBal.GetDataSet(null, null, x_oTableSet).Tables[CustomerAccount.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(CustomerAccount x_oCustomerAccount)
        {
            return CustomerAccountBal.GetDataSet(x_oCustomerAccount, null, CustomerAccountInfoDLL.CreateInfoInstanceObject()).Tables[CustomerAccount.Para.TableName()];
        }
        #endregion

        #region To Row

        // ******************************
        // *  Handler for Data DataRow
        // ******************************


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            return Row(x_oTable, x_oDB, x_iId, CustomerAccountInfoDLL.CreateInfoInstanceObject());
        }


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iId, CustomerAccountInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB, x_iId, x_oTableSet);
        }

        public static DataRow Row(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iId, CustomerAccountInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = CustomerAccountInfoDLL.CreateInfoInstanceObject();
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                string _sQuery = "SELECT [CustomerAccount].[id] AS CUSTOMERACCOUNT_ID,[CustomerAccount].[cdate] AS CUSTOMERACCOUNT_CDATE,[CustomerAccount].[cid] AS CUSTOMERACCOUNT_CID,[CustomerAccount].[mrt_no] AS CUSTOMERACCOUNT_MRT_NO,[CustomerAccount].[active] AS CUSTOMERACCOUNT_ACTIVE,[CustomerAccount].[ac_no] AS CUSTOMERACCOUNT_AC_NO,[CustomerAccount].[order_id] AS CUSTOMERACCOUNT_ORDER_ID,[CustomerAccount].[did] AS CUSTOMERACCOUNT_DID,[CustomerAccount].[ddate] AS CUSTOMERACCOUNT_DDATE,[CustomerAccount].[remarks] AS CUSTOMERACCOUNT_REMARKS  FROM  [CustomerAccount]  WHERE  [CustomerAccount].[id] = \'" + x_iId.ToString() + "\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[CustomerAccount]", "[" + Configurator.MSSQLTablePrefix + "CustomerAccount]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read())
                    {
                        if (x_oTableSet.Fields(CustomerAccount.Para.id).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(CustomerAccount.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CustomerAccount.Para.id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["CUSTOMERACCOUNT_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CustomerAccount.Para.id).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(CustomerAccount.Para.cdate).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(CustomerAccount.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CustomerAccount.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["CUSTOMERACCOUNT_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CustomerAccount.Para.cdate).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(CustomerAccount.Para.cid).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(CustomerAccount.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CustomerAccount.Para.cid).AliasName].ToString()] = (string)_oData["CUSTOMERACCOUNT_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CustomerAccount.Para.cid).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(CustomerAccount.Para.mrt_no).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_MRT_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(CustomerAccount.Para.mrt_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CustomerAccount.Para.mrt_no).AliasName].ToString()] = (string)_oData["CUSTOMERACCOUNT_MRT_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CustomerAccount.Para.mrt_no).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(CustomerAccount.Para.active).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(CustomerAccount.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CustomerAccount.Para.active).AliasName].ToString()] = (string)_oData["CUSTOMERACCOUNT_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CustomerAccount.Para.active).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(CustomerAccount.Para.ac_no).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_AC_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(CustomerAccount.Para.ac_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CustomerAccount.Para.ac_no).AliasName].ToString()] = (string)_oData["CUSTOMERACCOUNT_AC_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CustomerAccount.Para.ac_no).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(CustomerAccount.Para.order_id).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_ORDER_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(CustomerAccount.Para.order_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CustomerAccount.Para.order_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["CUSTOMERACCOUNT_ORDER_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CustomerAccount.Para.order_id).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(CustomerAccount.Para.did).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(CustomerAccount.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CustomerAccount.Para.did).AliasName].ToString()] = (string)_oData["CUSTOMERACCOUNT_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CustomerAccount.Para.did).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(CustomerAccount.Para.ddate).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(CustomerAccount.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CustomerAccount.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["CUSTOMERACCOUNT_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CustomerAccount.Para.ddate).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(CustomerAccount.Para.remarks).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["CUSTOMERACCOUNT_REMARKS"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(CustomerAccount.Para.remarks).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CustomerAccount.Para.remarks).AliasName].ToString()] = (string)_oData["CUSTOMERACCOUNT_REMARKS"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(CustomerAccount.Para.remarks).AliasName].ToString()] = string.Empty;
                        }
                    }
                    _oData.Close();
                    _oData.Dispose();
                }
                catch (Exception exp) { string _sError = exp.ToString(); }
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

        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet, CustomerAccount x_oCustomerAccountRow)
        {
            return SetByDataSetRowProc(x_iROW, CustomerAccount.Para.TableName(), x_oDataSet, x_oCustomerAccountRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, CustomerAccount x_oCustomerAccountRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet, x_oCustomerAccountRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, CustomerAccount x_oCustomerAccountRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                CustomerAccountInfo _oTableSet = CustomerAccountInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(CustomerAccount.Para.remarks).AliasName))
                    x_oCustomerAccountRow.remarks = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(CustomerAccount.Para.remarks).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(CustomerAccount.Para.id).AliasName))
                    x_oCustomerAccountRow.id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(CustomerAccount.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(CustomerAccount.Para.cdate).AliasName))
                    x_oCustomerAccountRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(CustomerAccount.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(CustomerAccount.Para.cid).AliasName))
                    x_oCustomerAccountRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(CustomerAccount.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(CustomerAccount.Para.mrt_no).AliasName))
                    x_oCustomerAccountRow.mrt_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(CustomerAccount.Para.mrt_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(CustomerAccount.Para.active).AliasName))
                    x_oCustomerAccountRow.active = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(CustomerAccount.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(CustomerAccount.Para.ac_no).AliasName))
                    x_oCustomerAccountRow.ac_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(CustomerAccount.Para.ac_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(CustomerAccount.Para.order_id).AliasName))
                    x_oCustomerAccountRow.order_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(CustomerAccount.Para.order_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(CustomerAccount.Para.ddate).AliasName))
                    x_oCustomerAccountRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(CustomerAccount.Para.ddate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(CustomerAccount.Para.did).AliasName))
                    x_oCustomerAccountRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(CustomerAccount.Para.did).AliasName];
                return true;
            }
            return false;
        }

        #endregion SetByDataSet


        #region Count

        // ******************************
        // *  Handler for Data Counting
        // ******************************

        public static int GetCount(MSSQLConnect x_oDB)
        {
            return CustomerAccountRepository.GetCount(x_oDB);
        }
        #endregion


        #region Get

        // ******************************
        // *  Handler for Data Getting
        // ******************************

        public static CustomerAccountEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            return CustomerAccountRepository.GetArrayObj(x_oDB, x_oColumnName, x_oArrayItemId);
        }

        public static CustomerAccountEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder)
        {
            return CustomerAccountRepository.GetArrayObj(x_oDB, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        #endregion


        #region List

        // ******************************
        // *  Handler for Data Listing
        // ******************************

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return CustomerAccountRepository.GetDataSet(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return CustomerAccountRepository.GetSearch(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            return CustomerAccountRepository.GetDataSet(x_oDB, x_sFilter);
        }
        #endregion

        #region Insert

        // ******************************
        // *  Handler for Data Inserting
        // ******************************

        public static bool Insert(MSSQLConnect x_oDB, string x_sRemarks, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sMrt_no, string x_sActive, string x_sAc_no, global::System.Nullable<int> x_iOrder_id, global::System.Nullable<DateTime> x_dDdate, string x_sDid)
        {
            return CustomerAccountRepository.Insert(x_oDB, x_sRemarks, x_dCdate, x_sCid, x_sMrt_no, x_sActive, x_sAc_no, x_iOrder_id, x_dDdate, x_sDid);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, CustomerAccount x_oCustomerAccount)
        {
            return CustomerAccountRepository.InsertWithOutLastID(x_oDB, x_oCustomerAccount);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, string x_sRemarks, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sMrt_no, string x_sActive, string x_sAc_no, global::System.Nullable<int> x_iOrder_id, global::System.Nullable<DateTime> x_dDdate, string x_sDid)
        {
            return CustomerAccountRepository.InsertReturnLastID_SP(x_oDB, x_sRemarks, x_dCdate, x_sCid, x_sMrt_no, x_sActive, x_sAc_no, x_iOrder_id, x_dDdate, x_sDid);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, CustomerAccount x_oCustomerAccount)
        {
            return CustomerAccountRepository.InsertReturnLastID_SP(x_oDB, x_oCustomerAccount);
        }

        #endregion

        #region Delete

        // ******************************
        // *  Handler for Data Deleting
        // ******************************

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            return CustomerAccountRepository.DeleteAll(x_oDB);
        }

        public static bool DeleteFilter(MSSQLConnect x_oDB, string x_sFilter)
        {
            return CustomerAccountRepository.DeleteFilter(x_oDB, x_sFilter);
        }

        public static bool Delete(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            return CustomerAccountRepository.Delete(x_oDB, x_iId);
        }


        #endregion

        #region Delete Uploaded Files

        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(CustomerAccount x_oCustomerAccountRow)
        {
            String sFile = String.Empty;
        }

        #endregion

        #region Release

        // ******************************
        // *  Handler for Release Memory
        // ******************************

        public void Release() { }
        #endregion
    }
}

