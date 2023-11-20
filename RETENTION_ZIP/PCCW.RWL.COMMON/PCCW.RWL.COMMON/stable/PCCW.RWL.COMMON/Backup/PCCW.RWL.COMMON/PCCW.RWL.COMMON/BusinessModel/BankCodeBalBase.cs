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
///-- Create date: <Create Date 2010-05-17>
///-- Description:	<Description,Table :[BankCode],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [BankCode] Business layer
    /// </summary>

    public abstract class BankCodeBalBase
    {

        #region Constructor


        // ******************************
        // *  Handler for Class Constructor
        // ******************************

        public BankCodeBalBase()
        {
        }
        ~BankCodeBalBase()
        {
            this.Release();
        }
        #endregion


        #region ToDataSet


        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************

        public static global::System.Data.DataSet ToDataSet(BankCode x_oBankCode)
        {
            return GetDataSet(x_oBankCode, null, BankCodeInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(BankCode x_oBankCode, global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oBankCode, x_oMergeDSet, BankCodeInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(BankCode x_oBankCode, BankCodeInfo x_oTableSet)
        {
            return GetDataSet(x_oBankCode, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToDataSet(BankCode x_oBankCode, global::System.Data.DataSet x_oMergeDSet, BankCodeInfo x_oTableSet)
        {
            return GetDataSet(x_oBankCode, x_oMergeDSet, x_oTableSet);
        }


        protected static global::System.Data.DataSet GetDataSet(BankCode x_oBankCode, global::System.Data.DataSet x_oMergeDSet, BankCodeInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = BankCodeInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(BankCode.Para.TableName());
            if (x_oTableSet.Fields(BankCode.Para.bank_code).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BankCode.Para.TableName()].Columns.Add(BankCode.Para.bank_code); }
            if (x_oTableSet.Fields(BankCode.Para.bank_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BankCode.Para.TableName()].Columns.Add(BankCode.Para.bank_name); }
            if (x_oTableSet.Fields(BankCode.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BankCode.Para.TableName()].Columns.Add(BankCode.Para.mid); }
            if (x_oTableSet.Fields(BankCode.Para.installment_period).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BankCode.Para.TableName()].Columns.Add(BankCode.Para.installment_period); }
            if (x_oTableSet.Fields(BankCode.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BankCode.Para.TableName()].Columns.Add(BankCode.Para.active); }
            if (x_oTableSet.Fields(BankCode.Para.min_amount).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BankCode.Para.TableName()].Columns.Add(BankCode.Para.min_amount); }
            if (x_oBankCode != null)
            {
                global::System.Data.DataRow _oDRow = _oDSet.Tables[BankCode.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(BankCode.Para.bank_code).IsView || x_oTableSet.GetViewAll()) { _oDRow[BankCode.Para.bank_code] = x_oBankCode.GetBank_code(); }
                if (x_oTableSet.Fields(BankCode.Para.bank_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[BankCode.Para.bank_name] = x_oBankCode.GetBank_name(); }
                if (x_oTableSet.Fields(BankCode.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDRow[BankCode.Para.mid] = x_oBankCode.GetMid(); }
                if (x_oTableSet.Fields(BankCode.Para.installment_period).IsView || x_oTableSet.GetViewAll()) { _oDRow[BankCode.Para.installment_period] = x_oBankCode.GetInstallment_period(); }
                if (x_oTableSet.Fields(BankCode.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[BankCode.Para.active] = x_oBankCode.GetActive(); }
                if (x_oTableSet.Fields(BankCode.Para.min_amount).IsView || x_oTableSet.GetViewAll()) { _oDRow[BankCode.Para.min_amount] = x_oBankCode.GetMin_amount(); }
                _oDSet.Tables[BankCode.Para.TableName()].Rows.Add(_oDRow);
            }
            if (x_oMergeDSet != null) { _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }


        protected static global::System.Data.DataSet ToEmptyDataSetProcess(BankCodeInfo x_oTableSet)
        {
            return BankCodeBal.GetDataSet(null, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return BankCodeBal.ToEmptyDataSetProcess(BankCodeInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToEmptyDataSet(BankCodeInfo x_oTableSet)
        {
            return BankCodeBal.ToEmptyDataSetProcess(x_oTableSet);
        }


        #endregion ToDataSet

        #region To Table

        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(BankCode x_oBankCode, BankCodeInfo x_oTableSet)
        {
            return BankCodeBal.GetDataSet(null, null, x_oTableSet).Tables[BankCode.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(BankCode x_oBankCode)
        {
            return BankCodeBal.GetDataSet(x_oBankCode, null, BankCodeInfoDLL.CreateInfoInstanceObject()).Tables[BankCode.Para.TableName()];
        }
        #endregion

        #region To Row

        // ******************************
        // *  Handler for Data DataRow
        // ******************************


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            return Row(x_oTable, x_oDB, x_iMid, BankCodeInfoDLL.CreateInfoInstanceObject());
        }


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid, BankCodeInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB, x_iMid, x_oTableSet);
        }

        public static DataRow Row(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid, BankCodeInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = BankCodeInfoDLL.CreateInfoInstanceObject();
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                string _sQuery = "SELECT   [BankCode].[active] AS BANKCODE_ACTIVE,[BankCode].[bank_code] AS BANKCODE_BANK_CODE,[BankCode].[bank_name] AS BANKCODE_BANK_NAME,[BankCode].[installment_period] AS BANKCODE_INSTALLMENT_PERIOD,[BankCode].[mid] AS BANKCODE_MID,[BankCode].[min_amount] AS BANKCODE_MIN_AMOUNT  FROM  [BankCode]  WHERE  [BankCode].[mid] = \'" + x_iMid.ToString() + "\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BankCode]", "[" + Configurator.MSSQLTablePrefix + "BankCode]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read())
                    {
                        if (x_oTableSet.Fields(BankCode.Para.active).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["BANKCODE_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BankCode.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BankCode.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["BANKCODE_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BankCode.Para.active).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(BankCode.Para.bank_code).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["BANKCODE_BANK_CODE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BankCode.Para.bank_code).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BankCode.Para.bank_code).AliasName].ToString()] = (string)_oData["BANKCODE_BANK_CODE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BankCode.Para.bank_code).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(BankCode.Para.bank_name).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["BANKCODE_BANK_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BankCode.Para.bank_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BankCode.Para.bank_name).AliasName].ToString()] = (string)_oData["BANKCODE_BANK_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BankCode.Para.bank_name).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(BankCode.Para.installment_period).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["BANKCODE_INSTALLMENT_PERIOD"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BankCode.Para.installment_period).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BankCode.Para.installment_period).AliasName].ToString()] = (string)_oData["BANKCODE_INSTALLMENT_PERIOD"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BankCode.Para.installment_period).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(BankCode.Para.mid).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["BANKCODE_MID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BankCode.Para.mid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BankCode.Para.mid).AliasName].ToString()] = (global::System.Nullable<int>)_oData["BANKCODE_MID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BankCode.Para.mid).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(BankCode.Para.min_amount).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["BANKCODE_MIN_AMOUNT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BankCode.Para.min_amount).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BankCode.Para.min_amount).AliasName].ToString()] = (string)_oData["BANKCODE_MIN_AMOUNT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BankCode.Para.min_amount).AliasName].ToString()] = string.Empty;
                        }
                    }
                    _oData.Close();
                    _oData.Dispose();
                }
                catch { }
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

        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet, BankCode x_oBankCodeRow)
        {
            return SetByDataSetRowProc(x_iROW, BankCode.Para.TableName(), x_oDataSet, x_oBankCodeRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, BankCode x_oBankCodeRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet, x_oBankCodeRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, BankCode x_oBankCodeRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                BankCodeInfo _oTableSet = BankCodeInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BankCode.Para.bank_code).AliasName))
                    x_oBankCodeRow.bank_code = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BankCode.Para.bank_code).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BankCode.Para.bank_name).AliasName))
                    x_oBankCodeRow.bank_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BankCode.Para.bank_name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BankCode.Para.mid).AliasName))
                    x_oBankCodeRow.mid = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BankCode.Para.mid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BankCode.Para.installment_period).AliasName))
                    x_oBankCodeRow.installment_period = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BankCode.Para.installment_period).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BankCode.Para.active).AliasName))
                    x_oBankCodeRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BankCode.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BankCode.Para.min_amount).AliasName))
                    x_oBankCodeRow.min_amount = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BankCode.Para.min_amount).AliasName];
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
            return BankCodeRepository.GetCount(x_oDB);
        }
        #endregion


        #region Get

        // ******************************
        // *  Handler for Data Getting
        // ******************************

        public static BankCodeEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            return BankCodeRepository.GetArrayObj(x_oDB, x_oColumnName, x_oArrayItemId);
        }

        public static BankCodeEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder)
        {
            return BankCodeRepository.GetArrayObj(x_oDB, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        #endregion


        #region List

        // ******************************
        // *  Handler for Data Listing
        // ******************************

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return BankCodeRepository.GetDataSet(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return BankCodeRepository.GetSearch(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            return BankCodeRepository.GetDataSet(x_oDB, x_sFilter);
        }
        #endregion

        #region Insert

        // ******************************
        // *  Handler for Data Inserting
        // ******************************

        public static bool Insert(MSSQLConnect x_oDB, string x_sBank_code, string x_sBank_name, string x_sInstallment_period, global::System.Nullable<bool> x_bActive, string x_sMin_amount)
        {
            return BankCodeRepository.Insert(x_oDB, x_sBank_code, x_sBank_name, x_sInstallment_period, x_bActive, x_sMin_amount);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, BankCode x_oBankCode)
        {
            return BankCodeRepository.InsertWithOutLastID(x_oDB, x_oBankCode);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, string x_sBank_code, string x_sBank_name, string x_sInstallment_period, global::System.Nullable<bool> x_bActive, string x_sMin_amount)
        {
            return BankCodeRepository.InsertReturnLastID_SP(x_oDB, x_sBank_code, x_sBank_name, x_sInstallment_period, x_bActive, x_sMin_amount);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, BankCode x_oBankCode)
        {
            return BankCodeRepository.InsertReturnLastID_SP(x_oDB, x_oBankCode);
        }

        #endregion

        #region Delete

        // ******************************
        // *  Handler for Data Deleting
        // ******************************

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            return BankCodeRepository.DeleteAll(x_oDB);
        }

        public static bool DeleteFilter(MSSQLConnect x_oDB, string x_sFilter)
        {
            return BankCodeRepository.DeleteFilter(x_oDB, x_sFilter);
        }

        public static bool Delete(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            return BankCodeRepository.Delete(x_oDB, x_iMid);
        }


        #endregion

        #region Delete Uploaded Files

        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(BankCode x_oBankCodeRow)
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

