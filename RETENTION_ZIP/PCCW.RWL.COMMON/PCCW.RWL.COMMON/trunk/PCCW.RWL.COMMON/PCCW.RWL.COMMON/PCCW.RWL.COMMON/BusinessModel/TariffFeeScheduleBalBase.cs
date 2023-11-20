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
///-- Description:	<Description,Table :[TariffFeeSchedule],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [TariffFeeSchedule] Business layer
    /// </summary>

    public abstract class TariffFeeScheduleBalBase
    {

        #region Constructor


        // ******************************
        // *  Handler for Class Constructor
        // ******************************

        public TariffFeeScheduleBalBase()
        {
        }
        ~TariffFeeScheduleBalBase()
        {
            this.Release();
        }
        #endregion


        #region ToDataSet


        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************

        public static global::System.Data.DataSet ToDataSet(TariffFeeSchedule x_oTariffFeeSchedule)
        {
            return GetDataSet(x_oTariffFeeSchedule, null, TariffFeeScheduleInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(TariffFeeSchedule x_oTariffFeeSchedule, global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oTariffFeeSchedule, x_oMergeDSet, TariffFeeScheduleInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(TariffFeeSchedule x_oTariffFeeSchedule, TariffFeeScheduleInfo x_oTableSet)
        {
            return GetDataSet(x_oTariffFeeSchedule, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToDataSet(TariffFeeSchedule x_oTariffFeeSchedule, global::System.Data.DataSet x_oMergeDSet, TariffFeeScheduleInfo x_oTableSet)
        {
            return GetDataSet(x_oTariffFeeSchedule, x_oMergeDSet, x_oTableSet);
        }


        protected static global::System.Data.DataSet GetDataSet(TariffFeeSchedule x_oTariffFeeSchedule, global::System.Data.DataSet x_oMergeDSet, TariffFeeScheduleInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = TariffFeeScheduleInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(TariffFeeSchedule.Para.TableName());
            if (x_oTableSet.Fields(TariffFeeSchedule.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[TariffFeeSchedule.Para.TableName()].Columns.Add(TariffFeeSchedule.Para.id); }
            if (x_oTableSet.Fields(TariffFeeSchedule.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[TariffFeeSchedule.Para.TableName()].Columns.Add(TariffFeeSchedule.Para.cdate); }
            if (x_oTableSet.Fields(TariffFeeSchedule.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[TariffFeeSchedule.Para.TableName()].Columns.Add(TariffFeeSchedule.Para.cid); }
            if (x_oTableSet.Fields(TariffFeeSchedule.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[TariffFeeSchedule.Para.TableName()].Columns.Add(TariffFeeSchedule.Para.active); }
            if (x_oTableSet.Fields(TariffFeeSchedule.Para.program).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[TariffFeeSchedule.Para.TableName()].Columns.Add(TariffFeeSchedule.Para.program); }
            if (x_oTableSet.Fields(TariffFeeSchedule.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[TariffFeeSchedule.Para.TableName()].Columns.Add(TariffFeeSchedule.Para.ddate); }
            if (x_oTableSet.Fields(TariffFeeSchedule.Para.org_fee).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[TariffFeeSchedule.Para.TableName()].Columns.Add(TariffFeeSchedule.Para.org_fee); }
            if (x_oTableSet.Fields(TariffFeeSchedule.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[TariffFeeSchedule.Para.TableName()].Columns.Add(TariffFeeSchedule.Para.did); }
            if (x_oTableSet.Fields(TariffFeeSchedule.Para.fee).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[TariffFeeSchedule.Para.TableName()].Columns.Add(TariffFeeSchedule.Para.fee); }
            if (x_oTariffFeeSchedule != null)
            {
                global::System.Data.DataRow _oDRow = _oDSet.Tables[TariffFeeSchedule.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(TariffFeeSchedule.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[TariffFeeSchedule.Para.id] = x_oTariffFeeSchedule.GetId(); }
                if (x_oTableSet.Fields(TariffFeeSchedule.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[TariffFeeSchedule.Para.cdate] = x_oTariffFeeSchedule.GetCdate(); }
                if (x_oTableSet.Fields(TariffFeeSchedule.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[TariffFeeSchedule.Para.cid] = x_oTariffFeeSchedule.GetCid(); }
                if (x_oTableSet.Fields(TariffFeeSchedule.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[TariffFeeSchedule.Para.active] = x_oTariffFeeSchedule.GetActive(); }
                if (x_oTableSet.Fields(TariffFeeSchedule.Para.program).IsView || x_oTableSet.GetViewAll()) { _oDRow[TariffFeeSchedule.Para.program] = x_oTariffFeeSchedule.GetProgram(); }
                if (x_oTableSet.Fields(TariffFeeSchedule.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[TariffFeeSchedule.Para.ddate] = x_oTariffFeeSchedule.GetDdate(); }
                if (x_oTableSet.Fields(TariffFeeSchedule.Para.org_fee).IsView || x_oTableSet.GetViewAll()) { _oDRow[TariffFeeSchedule.Para.org_fee] = x_oTariffFeeSchedule.GetOrg_fee(); }
                if (x_oTableSet.Fields(TariffFeeSchedule.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[TariffFeeSchedule.Para.did] = x_oTariffFeeSchedule.GetDid(); }
                if (x_oTableSet.Fields(TariffFeeSchedule.Para.fee).IsView || x_oTableSet.GetViewAll()) { _oDRow[TariffFeeSchedule.Para.fee] = x_oTariffFeeSchedule.GetFee(); }
                _oDSet.Tables[TariffFeeSchedule.Para.TableName()].Rows.Add(_oDRow);
            }
            if (x_oMergeDSet != null) { _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }


        protected static global::System.Data.DataSet ToEmptyDataSetProcess(TariffFeeScheduleInfo x_oTableSet)
        {
            return TariffFeeScheduleBal.GetDataSet(null, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return TariffFeeScheduleBal.ToEmptyDataSetProcess(TariffFeeScheduleInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToEmptyDataSet(TariffFeeScheduleInfo x_oTableSet)
        {
            return TariffFeeScheduleBal.ToEmptyDataSetProcess(x_oTableSet);
        }


        #endregion ToDataSet

        #region To Table

        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(TariffFeeSchedule x_oTariffFeeSchedule, TariffFeeScheduleInfo x_oTableSet)
        {
            return TariffFeeScheduleBal.GetDataSet(null, null, x_oTableSet).Tables[TariffFeeSchedule.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(TariffFeeSchedule x_oTariffFeeSchedule)
        {
            return TariffFeeScheduleBal.GetDataSet(x_oTariffFeeSchedule, null, TariffFeeScheduleInfoDLL.CreateInfoInstanceObject()).Tables[TariffFeeSchedule.Para.TableName()];
        }
        #endregion

        #region To Row

        // ******************************
        // *  Handler for Data DataRow
        // ******************************


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            return Row(x_oTable, x_oDB, x_iId, TariffFeeScheduleInfoDLL.CreateInfoInstanceObject());
        }


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iId, TariffFeeScheduleInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB, x_iId, x_oTableSet);
        }

        public static DataRow Row(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iId, TariffFeeScheduleInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = TariffFeeScheduleInfoDLL.CreateInfoInstanceObject();
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                string _sQuery = "SELECT [TariffFeeSchedule].[id] AS TARIFFFEESCHEDULE_ID,[TariffFeeSchedule].[cdate] AS TARIFFFEESCHEDULE_CDATE,[TariffFeeSchedule].[cid] AS TARIFFFEESCHEDULE_CID,[TariffFeeSchedule].[active] AS TARIFFFEESCHEDULE_ACTIVE,[TariffFeeSchedule].[program] AS TARIFFFEESCHEDULE_PROGRAM,[TariffFeeSchedule].[ddate] AS TARIFFFEESCHEDULE_DDATE,[TariffFeeSchedule].[fee] AS TARIFFFEESCHEDULE_FEE,[TariffFeeSchedule].[org_fee] AS TARIFFFEESCHEDULE_ORG_FEE,[TariffFeeSchedule].[did] AS TARIFFFEESCHEDULE_DID  FROM  [TariffFeeSchedule]  WHERE  [TariffFeeSchedule].[id] = \'" + x_iId.ToString() + "\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[TariffFeeSchedule]", "[" + Configurator.MSSQLTablePrefix + "TariffFeeSchedule]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read())
                    {
                        if (x_oTableSet.Fields(TariffFeeSchedule.Para.id).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(TariffFeeSchedule.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(TariffFeeSchedule.Para.id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["TARIFFFEESCHEDULE_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(TariffFeeSchedule.Para.id).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(TariffFeeSchedule.Para.cdate).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(TariffFeeSchedule.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(TariffFeeSchedule.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["TARIFFFEESCHEDULE_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(TariffFeeSchedule.Para.cdate).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(TariffFeeSchedule.Para.cid).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(TariffFeeSchedule.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(TariffFeeSchedule.Para.cid).AliasName].ToString()] = (string)_oData["TARIFFFEESCHEDULE_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(TariffFeeSchedule.Para.cid).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(TariffFeeSchedule.Para.active).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(TariffFeeSchedule.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(TariffFeeSchedule.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["TARIFFFEESCHEDULE_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(TariffFeeSchedule.Para.active).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(TariffFeeSchedule.Para.program).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_PROGRAM"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(TariffFeeSchedule.Para.program).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(TariffFeeSchedule.Para.program).AliasName].ToString()] = (string)_oData["TARIFFFEESCHEDULE_PROGRAM"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(TariffFeeSchedule.Para.program).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(TariffFeeSchedule.Para.ddate).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(TariffFeeSchedule.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(TariffFeeSchedule.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["TARIFFFEESCHEDULE_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(TariffFeeSchedule.Para.ddate).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(TariffFeeSchedule.Para.fee).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_FEE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(TariffFeeSchedule.Para.fee).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(TariffFeeSchedule.Para.fee).AliasName].ToString()] = (string)_oData["TARIFFFEESCHEDULE_FEE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(TariffFeeSchedule.Para.fee).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(TariffFeeSchedule.Para.org_fee).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_ORG_FEE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(TariffFeeSchedule.Para.org_fee).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(TariffFeeSchedule.Para.org_fee).AliasName].ToString()] = (global::System.Nullable<int>)_oData["TARIFFFEESCHEDULE_ORG_FEE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(TariffFeeSchedule.Para.org_fee).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(TariffFeeSchedule.Para.did).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["TARIFFFEESCHEDULE_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(TariffFeeSchedule.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(TariffFeeSchedule.Para.did).AliasName].ToString()] = (string)_oData["TARIFFFEESCHEDULE_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(TariffFeeSchedule.Para.did).AliasName].ToString()] = string.Empty;
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

        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet, TariffFeeSchedule x_oTariffFeeScheduleRow)
        {
            return SetByDataSetRowProc(x_iROW, TariffFeeSchedule.Para.TableName(), x_oDataSet, x_oTariffFeeScheduleRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, TariffFeeSchedule x_oTariffFeeScheduleRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet, x_oTariffFeeScheduleRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, TariffFeeSchedule x_oTariffFeeScheduleRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                TariffFeeScheduleInfo _oTableSet = TariffFeeScheduleInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(TariffFeeSchedule.Para.id).AliasName))
                    x_oTariffFeeScheduleRow.id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(TariffFeeSchedule.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(TariffFeeSchedule.Para.cdate).AliasName))
                    x_oTariffFeeScheduleRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(TariffFeeSchedule.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(TariffFeeSchedule.Para.cid).AliasName))
                    x_oTariffFeeScheduleRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(TariffFeeSchedule.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(TariffFeeSchedule.Para.active).AliasName))
                    x_oTariffFeeScheduleRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(TariffFeeSchedule.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(TariffFeeSchedule.Para.program).AliasName))
                    x_oTariffFeeScheduleRow.program = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(TariffFeeSchedule.Para.program).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(TariffFeeSchedule.Para.ddate).AliasName))
                    x_oTariffFeeScheduleRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(TariffFeeSchedule.Para.ddate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(TariffFeeSchedule.Para.org_fee).AliasName))
                    x_oTariffFeeScheduleRow.org_fee = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(TariffFeeSchedule.Para.org_fee).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(TariffFeeSchedule.Para.did).AliasName))
                    x_oTariffFeeScheduleRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(TariffFeeSchedule.Para.did).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(TariffFeeSchedule.Para.fee).AliasName))
                    x_oTariffFeeScheduleRow.fee = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(TariffFeeSchedule.Para.fee).AliasName];
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
            return TariffFeeScheduleRepository.GetCount(x_oDB);
        }
        #endregion


        #region Get

        // ******************************
        // *  Handler for Data Getting
        // ******************************

        public static TariffFeeScheduleEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            return TariffFeeScheduleRepository.GetArrayObj(x_oDB, x_oColumnName, x_oArrayItemId);
        }

        public static TariffFeeScheduleEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder)
        {
            return TariffFeeScheduleRepository.GetArrayObj(x_oDB, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        #endregion


        #region List

        // ******************************
        // *  Handler for Data Listing
        // ******************************

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return TariffFeeScheduleRepository.GetDataSet(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return TariffFeeScheduleRepository.GetSearch(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            return TariffFeeScheduleRepository.GetDataSet(x_oDB, x_sFilter);
        }
        #endregion

        #region Insert

        // ******************************
        // *  Handler for Data Inserting
        // ******************************

        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate, string x_sCid, global::System.Nullable<bool> x_bActive, string x_sProgram, global::System.Nullable<DateTime> x_dDdate, global::System.Nullable<int> x_iOrg_fee, string x_sDid, string x_sFee)
        {
            return TariffFeeScheduleRepository.Insert(x_oDB, x_dCdate, x_sCid, x_bActive, x_sProgram, x_dDdate, x_iOrg_fee, x_sDid, x_sFee);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, TariffFeeSchedule x_oTariffFeeSchedule)
        {
            return TariffFeeScheduleRepository.InsertWithOutLastID(x_oDB, x_oTariffFeeSchedule);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate, string x_sCid, global::System.Nullable<bool> x_bActive, string x_sProgram, global::System.Nullable<DateTime> x_dDdate, global::System.Nullable<int> x_iOrg_fee, string x_sDid, string x_sFee)
        {
            return TariffFeeScheduleRepository.InsertReturnLastID_SP(x_oDB, x_dCdate, x_sCid, x_bActive, x_sProgram, x_dDdate, x_iOrg_fee, x_sDid, x_sFee);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, TariffFeeSchedule x_oTariffFeeSchedule)
        {
            return TariffFeeScheduleRepository.InsertReturnLastID_SP(x_oDB, x_oTariffFeeSchedule);
        }

        #endregion

        #region Delete

        // ******************************
        // *  Handler for Data Deleting
        // ******************************

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            return TariffFeeScheduleRepository.DeleteAll(x_oDB);
        }

        public static bool DeleteFilter(MSSQLConnect x_oDB, string x_sFilter)
        {
            return TariffFeeScheduleRepository.DeleteFilter(x_oDB, x_sFilter);
        }

        public static bool Delete(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            return TariffFeeScheduleRepository.Delete(x_oDB, x_iId);
        }


        #endregion

        #region Delete Uploaded Files

        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(TariffFeeSchedule x_oTariffFeeScheduleRow)
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

