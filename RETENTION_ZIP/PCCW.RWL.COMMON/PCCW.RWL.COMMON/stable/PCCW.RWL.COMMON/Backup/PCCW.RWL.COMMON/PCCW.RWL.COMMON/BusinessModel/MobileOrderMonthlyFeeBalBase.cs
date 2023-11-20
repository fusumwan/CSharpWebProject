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
///-- Description:	<Description,Table :[MobileOrderMonthlyFee],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [MobileOrderMonthlyFee] Business layer
    /// </summary>

    public abstract class MobileOrderMonthlyFeeBalBase
    {

        #region Constructor


        // ******************************
        // *  Handler for Class Constructor
        // ******************************

        public MobileOrderMonthlyFeeBalBase()
        {
        }
        ~MobileOrderMonthlyFeeBalBase()
        {
            this.Release();
        }
        #endregion


        #region ToDataSet


        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************

        public static global::System.Data.DataSet ToDataSet(MobileOrderMonthlyFee x_oMobileOrderMonthlyFee)
        {
            return GetDataSet(x_oMobileOrderMonthlyFee, null, MobileOrderMonthlyFeeInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(MobileOrderMonthlyFee x_oMobileOrderMonthlyFee, global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oMobileOrderMonthlyFee, x_oMergeDSet, MobileOrderMonthlyFeeInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(MobileOrderMonthlyFee x_oMobileOrderMonthlyFee, MobileOrderMonthlyFeeInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderMonthlyFee, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToDataSet(MobileOrderMonthlyFee x_oMobileOrderMonthlyFee, global::System.Data.DataSet x_oMergeDSet, MobileOrderMonthlyFeeInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderMonthlyFee, x_oMergeDSet, x_oTableSet);
        }


        protected static global::System.Data.DataSet GetDataSet(MobileOrderMonthlyFee x_oMobileOrderMonthlyFee, global::System.Data.DataSet x_oMergeDSet, MobileOrderMonthlyFeeInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderMonthlyFeeInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(MobileOrderMonthlyFee.Para.TableName());
            if (x_oTableSet.Fields(MobileOrderMonthlyFee.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMonthlyFee.Para.TableName()].Columns.Add(MobileOrderMonthlyFee.Para.mid); }
            if (x_oTableSet.Fields(MobileOrderMonthlyFee.Para.mon).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMonthlyFee.Para.TableName()].Columns.Add(MobileOrderMonthlyFee.Para.mon); }
            if (x_oTableSet.Fields(MobileOrderMonthlyFee.Para.fee).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMonthlyFee.Para.TableName()].Columns.Add(MobileOrderMonthlyFee.Para.fee); }
            if (x_oTableSet.Fields(MobileOrderMonthlyFee.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMonthlyFee.Para.TableName()].Columns.Add(MobileOrderMonthlyFee.Para.active); }
            if (x_oTableSet.Fields(MobileOrderMonthlyFee.Para.free_mon).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderMonthlyFee.Para.TableName()].Columns.Add(MobileOrderMonthlyFee.Para.free_mon); }
            if (x_oMobileOrderMonthlyFee != null)
            {
                global::System.Data.DataRow _oDRow = _oDSet.Tables[MobileOrderMonthlyFee.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(MobileOrderMonthlyFee.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMonthlyFee.Para.mid] = x_oMobileOrderMonthlyFee.GetMid(); }
                if (x_oTableSet.Fields(MobileOrderMonthlyFee.Para.mon).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMonthlyFee.Para.mon] = x_oMobileOrderMonthlyFee.GetMon(); }
                if (x_oTableSet.Fields(MobileOrderMonthlyFee.Para.fee).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMonthlyFee.Para.fee] = x_oMobileOrderMonthlyFee.GetFee(); }
                if (x_oTableSet.Fields(MobileOrderMonthlyFee.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMonthlyFee.Para.active] = x_oMobileOrderMonthlyFee.GetActive(); }
                if (x_oTableSet.Fields(MobileOrderMonthlyFee.Para.free_mon).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderMonthlyFee.Para.free_mon] = x_oMobileOrderMonthlyFee.GetFree_mon(); }
                _oDSet.Tables[MobileOrderMonthlyFee.Para.TableName()].Rows.Add(_oDRow);
            }
            if (x_oMergeDSet != null) { _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }


        protected static global::System.Data.DataSet ToEmptyDataSetProcess(MobileOrderMonthlyFeeInfo x_oTableSet)
        {
            return MobileOrderMonthlyFeeBal.GetDataSet(null, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return MobileOrderMonthlyFeeBal.ToEmptyDataSetProcess(MobileOrderMonthlyFeeInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToEmptyDataSet(MobileOrderMonthlyFeeInfo x_oTableSet)
        {
            return MobileOrderMonthlyFeeBal.ToEmptyDataSetProcess(x_oTableSet);
        }


        #endregion ToDataSet

        #region To Table

        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(MobileOrderMonthlyFee x_oMobileOrderMonthlyFee, MobileOrderMonthlyFeeInfo x_oTableSet)
        {
            return MobileOrderMonthlyFeeBal.GetDataSet(null, null, x_oTableSet).Tables[MobileOrderMonthlyFee.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(MobileOrderMonthlyFee x_oMobileOrderMonthlyFee)
        {
            return MobileOrderMonthlyFeeBal.GetDataSet(x_oMobileOrderMonthlyFee, null, MobileOrderMonthlyFeeInfoDLL.CreateInfoInstanceObject()).Tables[MobileOrderMonthlyFee.Para.TableName()];
        }
        #endregion

        #region To Row

        // ******************************
        // *  Handler for Data DataRow
        // ******************************


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            return Row(x_oTable, x_oDB, x_iMid, MobileOrderMonthlyFeeInfoDLL.CreateInfoInstanceObject());
        }


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid, MobileOrderMonthlyFeeInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB, x_iMid, x_oTableSet);
        }

        public static DataRow Row(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid, MobileOrderMonthlyFeeInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderMonthlyFeeInfoDLL.CreateInfoInstanceObject();
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                string _sQuery = "SELECT [MobileOrderMonthlyFee].[active] AS MOBILEORDERMONTHLYFEE_ACTIVE,[MobileOrderMonthlyFee].[mon] AS MOBILEORDERMONTHLYFEE_MON,[MobileOrderMonthlyFee].[fee] AS MOBILEORDERMONTHLYFEE_FEE,[MobileOrderMonthlyFee].[mid] AS MOBILEORDERMONTHLYFEE_MID,[MobileOrderMonthlyFee].[free_mon] AS MOBILEORDERMONTHLYFEE_FREE_MON  FROM  [MobileOrderMonthlyFee]  WHERE  [MobileOrderMonthlyFee].[mid] = \'" + x_iMid.ToString() + "\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMonthlyFee]", "[" + Configurator.MSSQLTablePrefix + "MobileOrderMonthlyFee]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read())
                    {
                        if (x_oTableSet.Fields(MobileOrderMonthlyFee.Para.active).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMONTHLYFEE_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMonthlyFee.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMonthlyFee.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILEORDERMONTHLYFEE_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMonthlyFee.Para.active).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMonthlyFee.Para.mon).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMONTHLYFEE_MON"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMonthlyFee.Para.mon).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMonthlyFee.Para.mon).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERMONTHLYFEE_MON"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMonthlyFee.Para.mon).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMonthlyFee.Para.fee).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMONTHLYFEE_FEE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMonthlyFee.Para.fee).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMonthlyFee.Para.fee).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERMONTHLYFEE_FEE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMonthlyFee.Para.fee).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMonthlyFee.Para.mid).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMONTHLYFEE_MID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMonthlyFee.Para.mid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMonthlyFee.Para.mid).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERMONTHLYFEE_MID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMonthlyFee.Para.mid).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderMonthlyFee.Para.free_mon).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMONTHLYFEE_FREE_MON"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderMonthlyFee.Para.free_mon).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMonthlyFee.Para.free_mon).AliasName].ToString()] = (string)_oData["MOBILEORDERMONTHLYFEE_FREE_MON"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderMonthlyFee.Para.free_mon).AliasName].ToString()] = string.Empty;
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

        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet, MobileOrderMonthlyFee x_oMobileOrderMonthlyFeeRow)
        {
            return SetByDataSetRowProc(x_iROW, MobileOrderMonthlyFee.Para.TableName(), x_oDataSet, x_oMobileOrderMonthlyFeeRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, MobileOrderMonthlyFee x_oMobileOrderMonthlyFeeRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet, x_oMobileOrderMonthlyFeeRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, MobileOrderMonthlyFee x_oMobileOrderMonthlyFeeRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                MobileOrderMonthlyFeeInfo _oTableSet = MobileOrderMonthlyFeeInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMonthlyFee.Para.mid).AliasName))
                    x_oMobileOrderMonthlyFeeRow.mid = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMonthlyFee.Para.mid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMonthlyFee.Para.mon).AliasName))
                    x_oMobileOrderMonthlyFeeRow.mon = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMonthlyFee.Para.mon).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMonthlyFee.Para.fee).AliasName))
                    x_oMobileOrderMonthlyFeeRow.fee = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMonthlyFee.Para.fee).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMonthlyFee.Para.active).AliasName))
                    x_oMobileOrderMonthlyFeeRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMonthlyFee.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderMonthlyFee.Para.free_mon).AliasName))
                    x_oMobileOrderMonthlyFeeRow.free_mon = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderMonthlyFee.Para.free_mon).AliasName];
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
            return MobileOrderMonthlyFeeRepository.GetCount(x_oDB);
        }
        #endregion


        #region Get

        // ******************************
        // *  Handler for Data Getting
        // ******************************

        public static MobileOrderMonthlyFeeEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            return MobileOrderMonthlyFeeRepository.GetArrayObj(x_oDB, x_oColumnName, x_oArrayItemId);
        }

        public static MobileOrderMonthlyFeeEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder)
        {
            return MobileOrderMonthlyFeeRepository.GetArrayObj(x_oDB, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        #endregion


        #region List

        // ******************************
        // *  Handler for Data Listing
        // ******************************

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return MobileOrderMonthlyFeeRepository.GetDataSet(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return MobileOrderMonthlyFeeRepository.GetSearch(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            return MobileOrderMonthlyFeeRepository.GetDataSet(x_oDB, x_sFilter);
        }
        #endregion

        #region Insert

        // ******************************
        // *  Handler for Data Inserting
        // ******************************

        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMon, global::System.Nullable<int> x_iFee, global::System.Nullable<bool> x_bActive, string x_sFree_mon)
        {
            return MobileOrderMonthlyFeeRepository.Insert(x_oDB, x_iMon, x_iFee, x_bActive, x_sFree_mon);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, MobileOrderMonthlyFee x_oMobileOrderMonthlyFee)
        {
            return MobileOrderMonthlyFeeRepository.InsertWithOutLastID(x_oDB, x_oMobileOrderMonthlyFee);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMon, global::System.Nullable<int> x_iFee, global::System.Nullable<bool> x_bActive, string x_sFree_mon)
        {
            return MobileOrderMonthlyFeeRepository.InsertReturnLastID_SP(x_oDB, x_iMon, x_iFee, x_bActive, x_sFree_mon);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderMonthlyFee x_oMobileOrderMonthlyFee)
        {
            return MobileOrderMonthlyFeeRepository.InsertReturnLastID_SP(x_oDB, x_oMobileOrderMonthlyFee);
        }

        #endregion

        #region Delete

        // ******************************
        // *  Handler for Data Deleting
        // ******************************

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            return MobileOrderMonthlyFeeRepository.DeleteAll(x_oDB);
        }

        public static bool DeleteFilter(MSSQLConnect x_oDB, string x_sFilter)
        {
            return MobileOrderMonthlyFeeRepository.DeleteFilter(x_oDB, x_sFilter);
        }

        public static bool Delete(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            return MobileOrderMonthlyFeeRepository.Delete(x_oDB, x_iMid);
        }


        #endregion

        #region Delete Uploaded Files

        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(MobileOrderMonthlyFee x_oMobileOrderMonthlyFeeRow)
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

