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
///-- Create date: <Create Date 2009-10-05>
///-- Description:	<Description,Table :[RetentionPlan],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [RetentionPlan] Business layer
    /// </summary>

    public abstract class RetentionPlanBalBase
    {

        #region Constructor


        // ******************************
        // *  Handler for Class Constructor
        // ******************************

        public RetentionPlanBalBase()
        {
        }
        ~RetentionPlanBalBase()
        {
            this.Release();
        }
        #endregion


        #region ToDataSet


        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************

        public static global::System.Data.DataSet ToDataSet(RetentionPlan x_oRetentionPlan)
        {
            return GetDataSet(x_oRetentionPlan, null, RetentionPlanInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(RetentionPlan x_oRetentionPlan, global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oRetentionPlan, x_oMergeDSet, RetentionPlanInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(RetentionPlan x_oRetentionPlan, RetentionPlanInfo x_oTableSet)
        {
            return GetDataSet(x_oRetentionPlan, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToDataSet(RetentionPlan x_oRetentionPlan, global::System.Data.DataSet x_oMergeDSet, RetentionPlanInfo x_oTableSet)
        {
            return GetDataSet(x_oRetentionPlan, x_oMergeDSet, x_oTableSet);
        }


        protected static global::System.Data.DataSet GetDataSet(RetentionPlan x_oRetentionPlan, global::System.Data.DataSet x_oMergeDSet, RetentionPlanInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = RetentionPlanInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(RetentionPlan.Para.TableName());
            if (x_oTableSet.Fields(RetentionPlan.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[RetentionPlan.Para.TableName()].Columns.Add(RetentionPlan.Para.id); }
            if (x_oTableSet.Fields(RetentionPlan.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[RetentionPlan.Para.TableName()].Columns.Add(RetentionPlan.Para.cdate); }
            if (x_oTableSet.Fields(RetentionPlan.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[RetentionPlan.Para.TableName()].Columns.Add(RetentionPlan.Para.cid); }
            if (x_oTableSet.Fields(RetentionPlan.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[RetentionPlan.Para.TableName()].Columns.Add(RetentionPlan.Para.did); }
            if (x_oTableSet.Fields(RetentionPlan.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[RetentionPlan.Para.TableName()].Columns.Add(RetentionPlan.Para.active); }
            if (x_oTableSet.Fields(RetentionPlan.Para.plan_code).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[RetentionPlan.Para.TableName()].Columns.Add(RetentionPlan.Para.plan_code); }
            if (x_oTableSet.Fields(RetentionPlan.Para.plan_fee).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[RetentionPlan.Para.TableName()].Columns.Add(RetentionPlan.Para.plan_fee); }
            if (x_oTableSet.Fields(RetentionPlan.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[RetentionPlan.Para.TableName()].Columns.Add(RetentionPlan.Para.ddate); }
            if (x_oRetentionPlan != null)
            {
                global::System.Data.DataRow _oDRow = _oDSet.Tables[RetentionPlan.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(RetentionPlan.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[RetentionPlan.Para.id] = x_oRetentionPlan.GetId(); }
                if (x_oTableSet.Fields(RetentionPlan.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[RetentionPlan.Para.cdate] = x_oRetentionPlan.GetCdate(); }
                if (x_oTableSet.Fields(RetentionPlan.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[RetentionPlan.Para.cid] = x_oRetentionPlan.GetCid(); }
                if (x_oTableSet.Fields(RetentionPlan.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[RetentionPlan.Para.did] = x_oRetentionPlan.GetDid(); }
                if (x_oTableSet.Fields(RetentionPlan.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[RetentionPlan.Para.active] = x_oRetentionPlan.GetActive(); }
                if (x_oTableSet.Fields(RetentionPlan.Para.plan_code).IsView || x_oTableSet.GetViewAll()) { _oDRow[RetentionPlan.Para.plan_code] = x_oRetentionPlan.GetPlan_code(); }
                if (x_oTableSet.Fields(RetentionPlan.Para.plan_fee).IsView || x_oTableSet.GetViewAll()) { _oDRow[RetentionPlan.Para.plan_fee] = x_oRetentionPlan.GetPlan_fee(); }
                if (x_oTableSet.Fields(RetentionPlan.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[RetentionPlan.Para.ddate] = x_oRetentionPlan.GetDdate(); }
                _oDSet.Tables[RetentionPlan.Para.TableName()].Rows.Add(_oDRow);
            }
            if (x_oMergeDSet != null) { _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }


        protected static global::System.Data.DataSet ToEmptyDataSetProcess(RetentionPlanInfo x_oTableSet)
        {
            return RetentionPlanBal.GetDataSet(null, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return RetentionPlanBal.ToEmptyDataSetProcess(RetentionPlanInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToEmptyDataSet(RetentionPlanInfo x_oTableSet)
        {
            return RetentionPlanBal.ToEmptyDataSetProcess(x_oTableSet);
        }


        #endregion ToDataSet

        #region To Table

        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(RetentionPlan x_oRetentionPlan, RetentionPlanInfo x_oTableSet)
        {
            return RetentionPlanBal.GetDataSet(null, null, x_oTableSet).Tables[RetentionPlan.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(RetentionPlan x_oRetentionPlan)
        {
            return RetentionPlanBal.GetDataSet(x_oRetentionPlan, null, RetentionPlanInfoDLL.CreateInfoInstanceObject()).Tables[RetentionPlan.Para.TableName()];
        }
        #endregion

        #region To Row

        // ******************************
        // *  Handler for Data DataRow
        // ******************************


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            return Row(x_oTable, x_oDB, x_iId, RetentionPlanInfoDLL.CreateInfoInstanceObject());
        }


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iId, RetentionPlanInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB, x_iId, x_oTableSet);
        }

        public static DataRow Row(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iId, RetentionPlanInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = RetentionPlanInfoDLL.CreateInfoInstanceObject();
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                string _sQuery = "SELECT [RetentionPlan].[id] AS RETENTIONPLAN_ID,[RetentionPlan].[cdate] AS RETENTIONPLAN_CDATE,[RetentionPlan].[cid] AS RETENTIONPLAN_CID,[RetentionPlan].[did] AS RETENTIONPLAN_DID,[RetentionPlan].[active] AS RETENTIONPLAN_ACTIVE,[RetentionPlan].[plan_code] AS RETENTIONPLAN_PLAN_CODE,[RetentionPlan].[plan_fee] AS RETENTIONPLAN_PLAN_FEE,[RetentionPlan].[ddate] AS RETENTIONPLAN_DDATE  FROM  [RetentionPlan]  WHERE  [RetentionPlan].[id] = \'" + x_iId.ToString() + "\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RetentionPlan]", "[" + Configurator.MSSQLTablePrefix + "RetentionPlan]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read())
                    {
                        if (x_oTableSet.Fields(RetentionPlan.Para.id).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLAN_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(RetentionPlan.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(RetentionPlan.Para.id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["RETENTIONPLAN_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(RetentionPlan.Para.id).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(RetentionPlan.Para.cdate).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLAN_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(RetentionPlan.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(RetentionPlan.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["RETENTIONPLAN_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(RetentionPlan.Para.cdate).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(RetentionPlan.Para.cid).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLAN_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(RetentionPlan.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(RetentionPlan.Para.cid).AliasName].ToString()] = (string)_oData["RETENTIONPLAN_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(RetentionPlan.Para.cid).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(RetentionPlan.Para.did).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLAN_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(RetentionPlan.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(RetentionPlan.Para.did).AliasName].ToString()] = (string)_oData["RETENTIONPLAN_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(RetentionPlan.Para.did).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(RetentionPlan.Para.active).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLAN_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(RetentionPlan.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(RetentionPlan.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["RETENTIONPLAN_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(RetentionPlan.Para.active).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(RetentionPlan.Para.plan_code).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLAN_PLAN_CODE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(RetentionPlan.Para.plan_code).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(RetentionPlan.Para.plan_code).AliasName].ToString()] = (string)_oData["RETENTIONPLAN_PLAN_CODE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(RetentionPlan.Para.plan_code).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(RetentionPlan.Para.plan_fee).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLAN_PLAN_FEE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(RetentionPlan.Para.plan_fee).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(RetentionPlan.Para.plan_fee).AliasName].ToString()] = (global::System.Nullable<double>)_oData["RETENTIONPLAN_PLAN_FEE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(RetentionPlan.Para.plan_fee).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(RetentionPlan.Para.ddate).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["RETENTIONPLAN_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(RetentionPlan.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(RetentionPlan.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["RETENTIONPLAN_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(RetentionPlan.Para.ddate).AliasName].ToString()] = string.Empty;
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

        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet, RetentionPlan x_oRetentionPlanRow)
        {
            return SetByDataSetRowProc(x_iROW, RetentionPlan.Para.TableName(), x_oDataSet, x_oRetentionPlanRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, RetentionPlan x_oRetentionPlanRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet, x_oRetentionPlanRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, RetentionPlan x_oRetentionPlanRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                RetentionPlanInfo _oTableSet = RetentionPlanInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(RetentionPlan.Para.id).AliasName))
                    x_oRetentionPlanRow.id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(RetentionPlan.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(RetentionPlan.Para.cdate).AliasName))
                    x_oRetentionPlanRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(RetentionPlan.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(RetentionPlan.Para.cid).AliasName))
                    x_oRetentionPlanRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(RetentionPlan.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(RetentionPlan.Para.did).AliasName))
                    x_oRetentionPlanRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(RetentionPlan.Para.did).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(RetentionPlan.Para.active).AliasName))
                    x_oRetentionPlanRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(RetentionPlan.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(RetentionPlan.Para.plan_code).AliasName))
                    x_oRetentionPlanRow.plan_code = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(RetentionPlan.Para.plan_code).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(RetentionPlan.Para.plan_fee).AliasName))
                    x_oRetentionPlanRow.plan_fee = (global::System.Nullable<double>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(RetentionPlan.Para.plan_fee).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(RetentionPlan.Para.ddate).AliasName))
                    x_oRetentionPlanRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(RetentionPlan.Para.ddate).AliasName];
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
            return RetentionPlanRepository.GetCount(x_oDB);
        }
        #endregion


        #region Get

        // ******************************
        // *  Handler for Data Getting
        // ******************************

        public static RetentionPlanEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            return RetentionPlanRepository.GetArrayObj(x_oDB, x_oColumnName, x_oArrayItemId);
        }

        public static RetentionPlanEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder)
        {
            return RetentionPlanRepository.GetArrayObj(x_oDB, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        #endregion


        #region List

        // ******************************
        // *  Handler for Data Listing
        // ******************************

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return RetentionPlanRepository.GetDataSet(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return RetentionPlanRepository.GetSearch(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            return RetentionPlanRepository.GetDataSet(x_oDB, x_sFilter);
        }
        #endregion

        #region Insert

        // ******************************
        // *  Handler for Data Inserting
        // ******************************

        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sDid, global::System.Nullable<bool> x_bActive, string x_sPlan_code, global::System.Nullable<double> x_dPlan_fee, global::System.Nullable<DateTime> x_dDdate)
        {
            return RetentionPlanRepository.Insert(x_oDB, x_dCdate, x_sCid, x_sDid, x_bActive, x_sPlan_code, x_dPlan_fee, x_dDdate);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, RetentionPlan x_oRetentionPlan)
        {
            return RetentionPlanRepository.InsertWithOutLastID(x_oDB, x_oRetentionPlan);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sDid, global::System.Nullable<bool> x_bActive, string x_sPlan_code, global::System.Nullable<double> x_dPlan_fee, global::System.Nullable<DateTime> x_dDdate)
        {
            return RetentionPlanRepository.InsertReturnLastID_SP(x_oDB, x_dCdate, x_sCid, x_sDid, x_bActive, x_sPlan_code, x_dPlan_fee, x_dDdate);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, RetentionPlan x_oRetentionPlan)
        {
            return RetentionPlanRepository.InsertReturnLastID_SP(x_oDB, x_oRetentionPlan);
        }

        #endregion

        #region Delete

        // ******************************
        // *  Handler for Data Deleting
        // ******************************

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            return RetentionPlanRepository.DeleteAll(x_oDB);
        }

        public static bool DeleteFilter(MSSQLConnect x_oDB, string x_sFilter)
        {
            return RetentionPlanRepository.DeleteFilter(x_oDB, x_sFilter);
        }

        public static bool Delete(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            return RetentionPlanRepository.Delete(x_oDB, x_iId);
        }


        #endregion

        #region Delete Uploaded Files

        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(RetentionPlan x_oRetentionPlanRow)
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

