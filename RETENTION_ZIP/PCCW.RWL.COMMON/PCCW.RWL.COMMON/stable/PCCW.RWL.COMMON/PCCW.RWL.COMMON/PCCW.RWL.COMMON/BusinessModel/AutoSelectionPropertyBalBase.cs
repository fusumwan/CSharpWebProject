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
///-- Create date: <Create Date 2009-09-29>
///-- Description:	<Description,Table :[AutoSelectionProperty],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [AutoSelectionProperty] Business layer
    /// </summary>

    public abstract class AutoSelectionPropertyBalBase
    {

        #region Constructor


        // ******************************
        // *  Handler for Class Constructor
        // ******************************

        public AutoSelectionPropertyBalBase()
        {
        }
        ~AutoSelectionPropertyBalBase()
        {
            this.Release();
        }
        #endregion


        #region ToDataSet


        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************

        public static global::System.Data.DataSet ToDataSet(AutoSelectionProperty x_oAutoSelectionProperty)
        {
            return GetDataSet(x_oAutoSelectionProperty, null, AutoSelectionPropertyInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(AutoSelectionProperty x_oAutoSelectionProperty, global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oAutoSelectionProperty, x_oMergeDSet, AutoSelectionPropertyInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(AutoSelectionProperty x_oAutoSelectionProperty, AutoSelectionPropertyInfo x_oTableSet)
        {
            return GetDataSet(x_oAutoSelectionProperty, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToDataSet(AutoSelectionProperty x_oAutoSelectionProperty, global::System.Data.DataSet x_oMergeDSet, AutoSelectionPropertyInfo x_oTableSet)
        {
            return GetDataSet(x_oAutoSelectionProperty, x_oMergeDSet, x_oTableSet);
        }


        protected static global::System.Data.DataSet GetDataSet(AutoSelectionProperty x_oAutoSelectionProperty, global::System.Data.DataSet x_oMergeDSet, AutoSelectionPropertyInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = AutoSelectionPropertyInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(AutoSelectionProperty.Para.TableName());
            if (x_oTableSet.Fields(AutoSelectionProperty.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[AutoSelectionProperty.Para.TableName()].Columns.Add(AutoSelectionProperty.Para.id); }
            if (x_oTableSet.Fields(AutoSelectionProperty.Para.period).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[AutoSelectionProperty.Para.TableName()].Columns.Add(AutoSelectionProperty.Para.period); }
            if (x_oTableSet.Fields(AutoSelectionProperty.Para.start_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[AutoSelectionProperty.Para.TableName()].Columns.Add(AutoSelectionProperty.Para.start_date); }
            if (x_oTableSet.Fields(AutoSelectionProperty.Para.obprogram).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[AutoSelectionProperty.Para.TableName()].Columns.Add(AutoSelectionProperty.Para.obprogram); }
            if (x_oTableSet.Fields(AutoSelectionProperty.Para.channel).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[AutoSelectionProperty.Para.TableName()].Columns.Add(AutoSelectionProperty.Para.channel); }
            if (x_oTableSet.Fields(AutoSelectionProperty.Para.tier).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[AutoSelectionProperty.Para.TableName()].Columns.Add(AutoSelectionProperty.Para.tier); }
            if (x_oTableSet.Fields(AutoSelectionProperty.Para.tradefield_mid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[AutoSelectionProperty.Para.TableName()].Columns.Add(AutoSelectionProperty.Para.tradefield_mid); }
            if (x_oTableSet.Fields(AutoSelectionProperty.Para.uid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[AutoSelectionProperty.Para.TableName()].Columns.Add(AutoSelectionProperty.Para.uid); }
            if (x_oTableSet.Fields(AutoSelectionProperty.Para.end_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[AutoSelectionProperty.Para.TableName()].Columns.Add(AutoSelectionProperty.Para.end_date); }
            if (x_oTableSet.Fields(AutoSelectionProperty.Para.plan_fee).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[AutoSelectionProperty.Para.TableName()].Columns.Add(AutoSelectionProperty.Para.plan_fee); }
            if (x_oTableSet.Fields(AutoSelectionProperty.Para.remarks).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[AutoSelectionProperty.Para.TableName()].Columns.Add(AutoSelectionProperty.Para.remarks); }
            if (x_oTableSet.Fields(AutoSelectionProperty.Para.po_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[AutoSelectionProperty.Para.TableName()].Columns.Add(AutoSelectionProperty.Para.po_date); }
            if (x_oAutoSelectionProperty != null)
            {
                global::System.Data.DataRow _oDRow = _oDSet.Tables[AutoSelectionProperty.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(AutoSelectionProperty.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[AutoSelectionProperty.Para.id] = x_oAutoSelectionProperty.GetId(); }
                if (x_oTableSet.Fields(AutoSelectionProperty.Para.period).IsView || x_oTableSet.GetViewAll()) { _oDRow[AutoSelectionProperty.Para.period] = x_oAutoSelectionProperty.GetPeriod(); }
                if (x_oTableSet.Fields(AutoSelectionProperty.Para.start_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[AutoSelectionProperty.Para.start_date] = x_oAutoSelectionProperty.GetStart_date(); }
                if (x_oTableSet.Fields(AutoSelectionProperty.Para.obprogram).IsView || x_oTableSet.GetViewAll()) { _oDRow[AutoSelectionProperty.Para.obprogram] = x_oAutoSelectionProperty.GetObprogram(); }
                if (x_oTableSet.Fields(AutoSelectionProperty.Para.channel).IsView || x_oTableSet.GetViewAll()) { _oDRow[AutoSelectionProperty.Para.channel] = x_oAutoSelectionProperty.GetChannel(); }
                if (x_oTableSet.Fields(AutoSelectionProperty.Para.tier).IsView || x_oTableSet.GetViewAll()) { _oDRow[AutoSelectionProperty.Para.tier] = x_oAutoSelectionProperty.GetTier(); }
                if (x_oTableSet.Fields(AutoSelectionProperty.Para.tradefield_mid).IsView || x_oTableSet.GetViewAll()) { _oDRow[AutoSelectionProperty.Para.tradefield_mid] = x_oAutoSelectionProperty.GetTradefield_mid(); }
                if (x_oTableSet.Fields(AutoSelectionProperty.Para.uid).IsView || x_oTableSet.GetViewAll()) { _oDRow[AutoSelectionProperty.Para.uid] = x_oAutoSelectionProperty.GetUid(); }
                if (x_oTableSet.Fields(AutoSelectionProperty.Para.end_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[AutoSelectionProperty.Para.end_date] = x_oAutoSelectionProperty.GetEnd_date(); }
                if (x_oTableSet.Fields(AutoSelectionProperty.Para.plan_fee).IsView || x_oTableSet.GetViewAll()) { _oDRow[AutoSelectionProperty.Para.plan_fee] = x_oAutoSelectionProperty.GetPlan_fee(); }
                if (x_oTableSet.Fields(AutoSelectionProperty.Para.remarks).IsView || x_oTableSet.GetViewAll()) { _oDRow[AutoSelectionProperty.Para.remarks] = x_oAutoSelectionProperty.GetRemarks(); }
                if (x_oTableSet.Fields(AutoSelectionProperty.Para.po_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[AutoSelectionProperty.Para.po_date] = x_oAutoSelectionProperty.GetPo_date(); }
                _oDSet.Tables[AutoSelectionProperty.Para.TableName()].Rows.Add(_oDRow);
            }
            if (x_oMergeDSet != null) { _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }


        protected static global::System.Data.DataSet ToEmptyDataSetProcess(AutoSelectionPropertyInfo x_oTableSet)
        {
            return AutoSelectionPropertyBal.GetDataSet(null, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return AutoSelectionPropertyBal.ToEmptyDataSetProcess(AutoSelectionPropertyInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToEmptyDataSet(AutoSelectionPropertyInfo x_oTableSet)
        {
            return AutoSelectionPropertyBal.ToEmptyDataSetProcess(x_oTableSet);
        }


        #endregion ToDataSet

        #region To Table

        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(AutoSelectionProperty x_oAutoSelectionProperty, AutoSelectionPropertyInfo x_oTableSet)
        {
            return AutoSelectionPropertyBal.GetDataSet(null, null, x_oTableSet).Tables[AutoSelectionProperty.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(AutoSelectionProperty x_oAutoSelectionProperty)
        {
            return AutoSelectionPropertyBal.GetDataSet(x_oAutoSelectionProperty, null, AutoSelectionPropertyInfoDLL.CreateInfoInstanceObject()).Tables[AutoSelectionProperty.Para.TableName()];
        }
        #endregion

        #region To Row

        // ******************************
        // *  Handler for Data DataRow
        // ******************************


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            return Row(x_oTable, x_oDB, x_iId, AutoSelectionPropertyInfoDLL.CreateInfoInstanceObject());
        }


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iId, AutoSelectionPropertyInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB, x_iId, x_oTableSet);
        }

        public static DataRow Row(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iId, AutoSelectionPropertyInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = AutoSelectionPropertyInfoDLL.CreateInfoInstanceObject();
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                string _sQuery = "SELECT [AutoSelectionProperty].[remarks] AS AUTOSELECTIONPROPERTY_REMARKS,[AutoSelectionProperty].[id] AS AUTOSELECTIONPROPERTY_ID,[AutoSelectionProperty].[period] AS AUTOSELECTIONPROPERTY_PERIOD,[AutoSelectionProperty].[start_date] AS AUTOSELECTIONPROPERTY_START_DATE,[AutoSelectionProperty].[obprogram] AS AUTOSELECTIONPROPERTY_OBPROGRAM,[AutoSelectionProperty].[channel] AS AUTOSELECTIONPROPERTY_CHANNEL,[AutoSelectionProperty].[tier] AS AUTOSELECTIONPROPERTY_TIER,[AutoSelectionProperty].[tradefield_mid] AS AUTOSELECTIONPROPERTY_TRADEFIELD_MID,[AutoSelectionProperty].[uid] AS AUTOSELECTIONPROPERTY_UID,[AutoSelectionProperty].[plan_fee] AS AUTOSELECTIONPROPERTY_PLAN_FEE,[AutoSelectionProperty].[end_date] AS AUTOSELECTIONPROPERTY_END_DATE,[AutoSelectionProperty].[po_date] AS AUTOSELECTIONPROPERTY_PO_DATE  FROM  [AutoSelectionProperty]  WHERE  [AutoSelectionProperty].[id] = \'" + x_iId.ToString() + "\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[AutoSelectionProperty]", "[" + Configurator.MSSQLTablePrefix + "AutoSelectionProperty]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read())
                    {
                        if (x_oTableSet.Fields(AutoSelectionProperty.Para.remarks).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_REMARKS"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(AutoSelectionProperty.Para.remarks).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(AutoSelectionProperty.Para.remarks).AliasName].ToString()] = (string)_oData["AUTOSELECTIONPROPERTY_REMARKS"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(AutoSelectionProperty.Para.remarks).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(AutoSelectionProperty.Para.id).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(AutoSelectionProperty.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(AutoSelectionProperty.Para.id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["AUTOSELECTIONPROPERTY_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(AutoSelectionProperty.Para.id).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(AutoSelectionProperty.Para.period).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_PERIOD"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(AutoSelectionProperty.Para.period).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(AutoSelectionProperty.Para.period).AliasName].ToString()] = (string)_oData["AUTOSELECTIONPROPERTY_PERIOD"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(AutoSelectionProperty.Para.period).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(AutoSelectionProperty.Para.start_date).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_START_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(AutoSelectionProperty.Para.start_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(AutoSelectionProperty.Para.start_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["AUTOSELECTIONPROPERTY_START_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(AutoSelectionProperty.Para.start_date).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(AutoSelectionProperty.Para.obprogram).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_OBPROGRAM"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(AutoSelectionProperty.Para.obprogram).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(AutoSelectionProperty.Para.obprogram).AliasName].ToString()] = (string)_oData["AUTOSELECTIONPROPERTY_OBPROGRAM"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(AutoSelectionProperty.Para.obprogram).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(AutoSelectionProperty.Para.channel).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_CHANNEL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(AutoSelectionProperty.Para.channel).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(AutoSelectionProperty.Para.channel).AliasName].ToString()] = (string)_oData["AUTOSELECTIONPROPERTY_CHANNEL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(AutoSelectionProperty.Para.channel).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(AutoSelectionProperty.Para.tier).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_TIER"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(AutoSelectionProperty.Para.tier).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(AutoSelectionProperty.Para.tier).AliasName].ToString()] = (string)_oData["AUTOSELECTIONPROPERTY_TIER"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(AutoSelectionProperty.Para.tier).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(AutoSelectionProperty.Para.tradefield_mid).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_TRADEFIELD_MID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(AutoSelectionProperty.Para.tradefield_mid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(AutoSelectionProperty.Para.tradefield_mid).AliasName].ToString()] = (global::System.Nullable<int>)_oData["AUTOSELECTIONPROPERTY_TRADEFIELD_MID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(AutoSelectionProperty.Para.tradefield_mid).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(AutoSelectionProperty.Para.uid).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_UID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(AutoSelectionProperty.Para.uid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(AutoSelectionProperty.Para.uid).AliasName].ToString()] = (string)_oData["AUTOSELECTIONPROPERTY_UID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(AutoSelectionProperty.Para.uid).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(AutoSelectionProperty.Para.plan_fee).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_PLAN_FEE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(AutoSelectionProperty.Para.plan_fee).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(AutoSelectionProperty.Para.plan_fee).AliasName].ToString()] = (string)_oData["AUTOSELECTIONPROPERTY_PLAN_FEE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(AutoSelectionProperty.Para.plan_fee).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(AutoSelectionProperty.Para.end_date).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_END_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(AutoSelectionProperty.Para.end_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(AutoSelectionProperty.Para.end_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["AUTOSELECTIONPROPERTY_END_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(AutoSelectionProperty.Para.end_date).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(AutoSelectionProperty.Para.po_date).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["AUTOSELECTIONPROPERTY_PO_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(AutoSelectionProperty.Para.po_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(AutoSelectionProperty.Para.po_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["AUTOSELECTIONPROPERTY_PO_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(AutoSelectionProperty.Para.po_date).AliasName].ToString()] = string.Empty;
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

        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet, AutoSelectionProperty x_oAutoSelectionPropertyRow)
        {
            return SetByDataSetRowProc(x_iROW, AutoSelectionProperty.Para.TableName(), x_oDataSet, x_oAutoSelectionPropertyRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, AutoSelectionProperty x_oAutoSelectionPropertyRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet, x_oAutoSelectionPropertyRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, AutoSelectionProperty x_oAutoSelectionPropertyRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                AutoSelectionPropertyInfo _oTableSet = AutoSelectionPropertyInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(AutoSelectionProperty.Para.id).AliasName))
                    x_oAutoSelectionPropertyRow.id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(AutoSelectionProperty.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(AutoSelectionProperty.Para.period).AliasName))
                    x_oAutoSelectionPropertyRow.period = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(AutoSelectionProperty.Para.period).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(AutoSelectionProperty.Para.start_date).AliasName))
                    x_oAutoSelectionPropertyRow.start_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(AutoSelectionProperty.Para.start_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(AutoSelectionProperty.Para.obprogram).AliasName))
                    x_oAutoSelectionPropertyRow.obprogram = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(AutoSelectionProperty.Para.obprogram).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(AutoSelectionProperty.Para.channel).AliasName))
                    x_oAutoSelectionPropertyRow.channel = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(AutoSelectionProperty.Para.channel).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(AutoSelectionProperty.Para.tier).AliasName))
                    x_oAutoSelectionPropertyRow.tier = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(AutoSelectionProperty.Para.tier).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(AutoSelectionProperty.Para.tradefield_mid).AliasName))
                    x_oAutoSelectionPropertyRow.tradefield_mid = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(AutoSelectionProperty.Para.tradefield_mid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(AutoSelectionProperty.Para.uid).AliasName))
                    x_oAutoSelectionPropertyRow.uid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(AutoSelectionProperty.Para.uid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(AutoSelectionProperty.Para.end_date).AliasName))
                    x_oAutoSelectionPropertyRow.end_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(AutoSelectionProperty.Para.end_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(AutoSelectionProperty.Para.plan_fee).AliasName))
                    x_oAutoSelectionPropertyRow.plan_fee = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(AutoSelectionProperty.Para.plan_fee).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(AutoSelectionProperty.Para.remarks).AliasName))
                    x_oAutoSelectionPropertyRow.remarks = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(AutoSelectionProperty.Para.remarks).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(AutoSelectionProperty.Para.po_date).AliasName))
                    x_oAutoSelectionPropertyRow.po_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(AutoSelectionProperty.Para.po_date).AliasName];
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
            return AutoSelectionPropertyRepository.GetCount(x_oDB);
        }
        #endregion


        #region Get

        // ******************************
        // *  Handler for Data Getting
        // ******************************

        public static AutoSelectionPropertyEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            return AutoSelectionPropertyRepository.GetArrayObj(x_oDB, x_oColumnName, x_oArrayItemId);
        }

        public static AutoSelectionPropertyEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder)
        {
            return AutoSelectionPropertyRepository.GetArrayObj(x_oDB, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        #endregion


        #region List

        // ******************************
        // *  Handler for Data Listing
        // ******************************

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return AutoSelectionPropertyRepository.GetDataSet(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return AutoSelectionPropertyRepository.GetSearch(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            return AutoSelectionPropertyRepository.GetDataSet(x_oDB, x_sFilter);
        }
        #endregion

        #region Insert

        // ******************************
        // *  Handler for Data Inserting
        // ******************************

        public static bool Insert(MSSQLConnect x_oDB, string x_sPeriod, global::System.Nullable<DateTime> x_dStart_date, string x_sObprogram, string x_sChannel, string x_sTier, global::System.Nullable<int> x_iTradefield_mid, string x_sUid, global::System.Nullable<DateTime> x_dEnd_date, string x_sPlan_fee, string x_sRemarks, global::System.Nullable<DateTime> x_dPo_date)
        {
            return AutoSelectionPropertyRepository.Insert(x_oDB, x_sPeriod, x_dStart_date, x_sObprogram, x_sChannel, x_sTier, x_iTradefield_mid, x_sUid, x_dEnd_date, x_sPlan_fee, x_sRemarks, x_dPo_date);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, AutoSelectionProperty x_oAutoSelectionProperty)
        {
            return AutoSelectionPropertyRepository.InsertWithOutLastID(x_oDB, x_oAutoSelectionProperty);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, string x_sPeriod, global::System.Nullable<DateTime> x_dStart_date, string x_sObprogram, string x_sChannel, string x_sTier, global::System.Nullable<int> x_iTradefield_mid, string x_sUid, global::System.Nullable<DateTime> x_dEnd_date, string x_sPlan_fee, string x_sRemarks, global::System.Nullable<DateTime> x_dPo_date)
        {
            return AutoSelectionPropertyRepository.InsertReturnLastID_SP(x_oDB, x_sPeriod, x_dStart_date, x_sObprogram, x_sChannel, x_sTier, x_iTradefield_mid, x_sUid, x_dEnd_date, x_sPlan_fee, x_sRemarks, x_dPo_date);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, AutoSelectionProperty x_oAutoSelectionProperty)
        {
            return AutoSelectionPropertyRepository.InsertReturnLastID_SP(x_oDB, x_oAutoSelectionProperty);
        }

        #endregion

        #region Delete

        // ******************************
        // *  Handler for Data Deleting
        // ******************************

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            return AutoSelectionPropertyRepository.DeleteAll(x_oDB);
        }

        public static bool DeleteFilter(MSSQLConnect x_oDB, string x_sFilter)
        {
            return AutoSelectionPropertyRepository.DeleteFilter(x_oDB, x_sFilter);
        }

        public static bool Delete(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            return AutoSelectionPropertyRepository.Delete(x_oDB, x_iId);
        }


        #endregion

        #region Delete Uploaded Files

        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(AutoSelectionProperty x_oAutoSelectionPropertyRow)
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

