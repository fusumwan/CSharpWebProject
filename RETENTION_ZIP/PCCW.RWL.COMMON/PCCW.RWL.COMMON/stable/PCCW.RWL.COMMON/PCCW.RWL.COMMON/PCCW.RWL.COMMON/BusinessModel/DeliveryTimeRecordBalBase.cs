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
///-- Create date: <Create Date 2009-12-21>
///-- Description:	<Description,Table :[DeliveryTimeRecord],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [DeliveryTimeRecord] Business layer
    /// </summary>

    public abstract class DeliveryTimeRecordBalBase
    {

        #region Constructor


        // ******************************
        // *  Handler for Class Constructor
        // ******************************

        public DeliveryTimeRecordBalBase()
        {
        }
        ~DeliveryTimeRecordBalBase()
        {
            this.Release();
        }
        #endregion


        #region ToDataSet


        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************

        public static global::System.Data.DataSet ToDataSet(DeliveryTimeRecord x_oDeliveryTimeRecord)
        {
            return GetDataSet(x_oDeliveryTimeRecord, null, DeliveryTimeRecordInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(DeliveryTimeRecord x_oDeliveryTimeRecord, global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oDeliveryTimeRecord, x_oMergeDSet, DeliveryTimeRecordInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(DeliveryTimeRecord x_oDeliveryTimeRecord, DeliveryTimeRecordInfo x_oTableSet)
        {
            return GetDataSet(x_oDeliveryTimeRecord, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToDataSet(DeliveryTimeRecord x_oDeliveryTimeRecord, global::System.Data.DataSet x_oMergeDSet, DeliveryTimeRecordInfo x_oTableSet)
        {
            return GetDataSet(x_oDeliveryTimeRecord, x_oMergeDSet, x_oTableSet);
        }


        protected static global::System.Data.DataSet GetDataSet(DeliveryTimeRecord x_oDeliveryTimeRecord, global::System.Data.DataSet x_oMergeDSet, DeliveryTimeRecordInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = DeliveryTimeRecordInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(DeliveryTimeRecord.Para.TableName());
            if (x_oTableSet.Fields(DeliveryTimeRecord.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DeliveryTimeRecord.Para.TableName()].Columns.Add(DeliveryTimeRecord.Para.id); }
            if (x_oTableSet.Fields(DeliveryTimeRecord.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DeliveryTimeRecord.Para.TableName()].Columns.Add(DeliveryTimeRecord.Para.cdate); }
            if (x_oTableSet.Fields(DeliveryTimeRecord.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DeliveryTimeRecord.Para.TableName()].Columns.Add(DeliveryTimeRecord.Para.cid); }
            if (x_oTableSet.Fields(DeliveryTimeRecord.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DeliveryTimeRecord.Para.TableName()].Columns.Add(DeliveryTimeRecord.Para.active); }
            if (x_oTableSet.Fields(DeliveryTimeRecord.Para.pm8_10).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DeliveryTimeRecord.Para.TableName()].Columns.Add(DeliveryTimeRecord.Para.pm8_10); }
            if (x_oTableSet.Fields(DeliveryTimeRecord.Para.location).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DeliveryTimeRecord.Para.TableName()].Columns.Add(DeliveryTimeRecord.Para.location); }
            if (x_oTableSet.Fields(DeliveryTimeRecord.Para.pm7_9).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DeliveryTimeRecord.Para.TableName()].Columns.Add(DeliveryTimeRecord.Para.pm7_9); }
            if (x_oTableSet.Fields(DeliveryTimeRecord.Para.area).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DeliveryTimeRecord.Para.TableName()].Columns.Add(DeliveryTimeRecord.Para.area); }
            if (x_oTableSet.Fields(DeliveryTimeRecord.Para.pm6_8).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DeliveryTimeRecord.Para.TableName()].Columns.Add(DeliveryTimeRecord.Para.pm6_8); }
            if (x_oTableSet.Fields(DeliveryTimeRecord.Para.pm).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DeliveryTimeRecord.Para.TableName()].Columns.Add(DeliveryTimeRecord.Para.pm); }
            if (x_oTableSet.Fields(DeliveryTimeRecord.Para.am).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DeliveryTimeRecord.Para.TableName()].Columns.Add(DeliveryTimeRecord.Para.am); }
            if (x_oTableSet.Fields(DeliveryTimeRecord.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DeliveryTimeRecord.Para.TableName()].Columns.Add(DeliveryTimeRecord.Para.ddate); }
            if (x_oTableSet.Fields(DeliveryTimeRecord.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DeliveryTimeRecord.Para.TableName()].Columns.Add(DeliveryTimeRecord.Para.did); }
            if (x_oTableSet.Fields(DeliveryTimeRecord.Para.delivery_fee).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[DeliveryTimeRecord.Para.TableName()].Columns.Add(DeliveryTimeRecord.Para.delivery_fee); }
            if (x_oDeliveryTimeRecord != null)
            {
                global::System.Data.DataRow _oDRow = _oDSet.Tables[DeliveryTimeRecord.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(DeliveryTimeRecord.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[DeliveryTimeRecord.Para.id] = x_oDeliveryTimeRecord.GetId(); }
                if (x_oTableSet.Fields(DeliveryTimeRecord.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[DeliveryTimeRecord.Para.cdate] = x_oDeliveryTimeRecord.GetCdate(); }
                if (x_oTableSet.Fields(DeliveryTimeRecord.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[DeliveryTimeRecord.Para.cid] = x_oDeliveryTimeRecord.GetCid(); }
                if (x_oTableSet.Fields(DeliveryTimeRecord.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[DeliveryTimeRecord.Para.active] = x_oDeliveryTimeRecord.GetActive(); }
                if (x_oTableSet.Fields(DeliveryTimeRecord.Para.pm8_10).IsView || x_oTableSet.GetViewAll()) { _oDRow[DeliveryTimeRecord.Para.pm8_10] = x_oDeliveryTimeRecord.GetPm8_10(); }
                if (x_oTableSet.Fields(DeliveryTimeRecord.Para.location).IsView || x_oTableSet.GetViewAll()) { _oDRow[DeliveryTimeRecord.Para.location] = x_oDeliveryTimeRecord.GetLocation(); }
                if (x_oTableSet.Fields(DeliveryTimeRecord.Para.pm7_9).IsView || x_oTableSet.GetViewAll()) { _oDRow[DeliveryTimeRecord.Para.pm7_9] = x_oDeliveryTimeRecord.GetPm7_9(); }
                if (x_oTableSet.Fields(DeliveryTimeRecord.Para.area).IsView || x_oTableSet.GetViewAll()) { _oDRow[DeliveryTimeRecord.Para.area] = x_oDeliveryTimeRecord.GetArea(); }
                if (x_oTableSet.Fields(DeliveryTimeRecord.Para.pm6_8).IsView || x_oTableSet.GetViewAll()) { _oDRow[DeliveryTimeRecord.Para.pm6_8] = x_oDeliveryTimeRecord.GetPm6_8(); }
                if (x_oTableSet.Fields(DeliveryTimeRecord.Para.pm).IsView || x_oTableSet.GetViewAll()) { _oDRow[DeliveryTimeRecord.Para.pm] = x_oDeliveryTimeRecord.GetPm(); }
                if (x_oTableSet.Fields(DeliveryTimeRecord.Para.am).IsView || x_oTableSet.GetViewAll()) { _oDRow[DeliveryTimeRecord.Para.am] = x_oDeliveryTimeRecord.GetAm(); }
                if (x_oTableSet.Fields(DeliveryTimeRecord.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[DeliveryTimeRecord.Para.ddate] = x_oDeliveryTimeRecord.GetDdate(); }
                if (x_oTableSet.Fields(DeliveryTimeRecord.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[DeliveryTimeRecord.Para.did] = x_oDeliveryTimeRecord.GetDid(); }
                if (x_oTableSet.Fields(DeliveryTimeRecord.Para.delivery_fee).IsView || x_oTableSet.GetViewAll()) { _oDRow[DeliveryTimeRecord.Para.delivery_fee] = x_oDeliveryTimeRecord.GetDelivery_fee(); }
                _oDSet.Tables[DeliveryTimeRecord.Para.TableName()].Rows.Add(_oDRow);
            }
            if (x_oMergeDSet != null) { _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }


        protected static global::System.Data.DataSet ToEmptyDataSetProcess(DeliveryTimeRecordInfo x_oTableSet)
        {
            return DeliveryTimeRecordBal.GetDataSet(null, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return DeliveryTimeRecordBal.ToEmptyDataSetProcess(DeliveryTimeRecordInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToEmptyDataSet(DeliveryTimeRecordInfo x_oTableSet)
        {
            return DeliveryTimeRecordBal.ToEmptyDataSetProcess(x_oTableSet);
        }


        #endregion ToDataSet

        #region To Table

        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(DeliveryTimeRecord x_oDeliveryTimeRecord, DeliveryTimeRecordInfo x_oTableSet)
        {
            return DeliveryTimeRecordBal.GetDataSet(null, null, x_oTableSet).Tables[DeliveryTimeRecord.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(DeliveryTimeRecord x_oDeliveryTimeRecord)
        {
            return DeliveryTimeRecordBal.GetDataSet(x_oDeliveryTimeRecord, null, DeliveryTimeRecordInfoDLL.CreateInfoInstanceObject()).Tables[DeliveryTimeRecord.Para.TableName()];
        }
        #endregion

        #region To Row

        // ******************************
        // *  Handler for Data DataRow
        // ******************************


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            return Row(x_oTable, x_oDB, x_iId, DeliveryTimeRecordInfoDLL.CreateInfoInstanceObject());
        }


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iId, DeliveryTimeRecordInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB, x_iId, x_oTableSet);
        }

        public static DataRow Row(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iId, DeliveryTimeRecordInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = DeliveryTimeRecordInfoDLL.CreateInfoInstanceObject();
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                string _sQuery = "SELECT   [DeliveryTimeRecord].[id] AS DELIVERYTIMERECORD_ID,[DeliveryTimeRecord].[cdate] AS DELIVERYTIMERECORD_CDATE,[DeliveryTimeRecord].[cid] AS DELIVERYTIMERECORD_CID,[DeliveryTimeRecord].[active] AS DELIVERYTIMERECORD_ACTIVE,[DeliveryTimeRecord].[pm8_10] AS DELIVERYTIMERECORD_PM8_10,[DeliveryTimeRecord].[location] AS DELIVERYTIMERECORD_LOCATION,[DeliveryTimeRecord].[pm7_9] AS DELIVERYTIMERECORD_PM7_9,[DeliveryTimeRecord].[area] AS DELIVERYTIMERECORD_AREA,[DeliveryTimeRecord].[pm6_8] AS DELIVERYTIMERECORD_PM6_8,[DeliveryTimeRecord].[am] AS DELIVERYTIMERECORD_AM,[DeliveryTimeRecord].[did] AS DELIVERYTIMERECORD_DID,[DeliveryTimeRecord].[ddate] AS DELIVERYTIMERECORD_DDATE,[DeliveryTimeRecord].[pm] AS DELIVERYTIMERECORD_PM,[DeliveryTimeRecord].[delivery_fee] AS DELIVERYTIMERECORD_DELIVERY_FEE  FROM  [DeliveryTimeRecord]  WHERE  [DeliveryTimeRecord].[id] = \'" + x_iId.ToString() + "\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[DeliveryTimeRecord]", "[" + Configurator.MSSQLTablePrefix + "DeliveryTimeRecord]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read())
                    {
                        if (x_oTableSet.Fields(DeliveryTimeRecord.Para.id).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DeliveryTimeRecord.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTimeRecord.Para.id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["DELIVERYTIMERECORD_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTimeRecord.Para.id).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(DeliveryTimeRecord.Para.cdate).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DeliveryTimeRecord.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTimeRecord.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["DELIVERYTIMERECORD_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTimeRecord.Para.cdate).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(DeliveryTimeRecord.Para.cid).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DeliveryTimeRecord.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTimeRecord.Para.cid).AliasName].ToString()] = (string)_oData["DELIVERYTIMERECORD_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTimeRecord.Para.cid).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(DeliveryTimeRecord.Para.active).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DeliveryTimeRecord.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTimeRecord.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["DELIVERYTIMERECORD_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTimeRecord.Para.active).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(DeliveryTimeRecord.Para.pm8_10).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_PM8_10"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DeliveryTimeRecord.Para.pm8_10).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTimeRecord.Para.pm8_10).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["DELIVERYTIMERECORD_PM8_10"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTimeRecord.Para.pm8_10).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(DeliveryTimeRecord.Para.location).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_LOCATION"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DeliveryTimeRecord.Para.location).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTimeRecord.Para.location).AliasName].ToString()] = (string)_oData["DELIVERYTIMERECORD_LOCATION"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTimeRecord.Para.location).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(DeliveryTimeRecord.Para.pm7_9).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_PM7_9"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DeliveryTimeRecord.Para.pm7_9).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTimeRecord.Para.pm7_9).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["DELIVERYTIMERECORD_PM7_9"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTimeRecord.Para.pm7_9).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(DeliveryTimeRecord.Para.area).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_AREA"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DeliveryTimeRecord.Para.area).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTimeRecord.Para.area).AliasName].ToString()] = (string)_oData["DELIVERYTIMERECORD_AREA"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTimeRecord.Para.area).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(DeliveryTimeRecord.Para.pm6_8).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_PM6_8"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DeliveryTimeRecord.Para.pm6_8).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTimeRecord.Para.pm6_8).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["DELIVERYTIMERECORD_PM6_8"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTimeRecord.Para.pm6_8).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(DeliveryTimeRecord.Para.am).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_AM"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DeliveryTimeRecord.Para.am).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTimeRecord.Para.am).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["DELIVERYTIMERECORD_AM"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTimeRecord.Para.am).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(DeliveryTimeRecord.Para.did).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DeliveryTimeRecord.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTimeRecord.Para.did).AliasName].ToString()] = (string)_oData["DELIVERYTIMERECORD_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTimeRecord.Para.did).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(DeliveryTimeRecord.Para.ddate).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DeliveryTimeRecord.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTimeRecord.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["DELIVERYTIMERECORD_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTimeRecord.Para.ddate).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(DeliveryTimeRecord.Para.pm).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_PM"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DeliveryTimeRecord.Para.pm).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTimeRecord.Para.pm).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["DELIVERYTIMERECORD_PM"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTimeRecord.Para.pm).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(DeliveryTimeRecord.Para.delivery_fee).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["DELIVERYTIMERECORD_DELIVERY_FEE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(DeliveryTimeRecord.Para.delivery_fee).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTimeRecord.Para.delivery_fee).AliasName].ToString()] = (global::System.Nullable<int>)_oData["DELIVERYTIMERECORD_DELIVERY_FEE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(DeliveryTimeRecord.Para.delivery_fee).AliasName].ToString()] = string.Empty;
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

        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet, DeliveryTimeRecord x_oDeliveryTimeRecordRow)
        {
            return SetByDataSetRowProc(x_iROW, DeliveryTimeRecord.Para.TableName(), x_oDataSet, x_oDeliveryTimeRecordRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, DeliveryTimeRecord x_oDeliveryTimeRecordRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet, x_oDeliveryTimeRecordRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, DeliveryTimeRecord x_oDeliveryTimeRecordRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                DeliveryTimeRecordInfo _oTableSet = DeliveryTimeRecordInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DeliveryTimeRecord.Para.id).AliasName))
                    x_oDeliveryTimeRecordRow.id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DeliveryTimeRecord.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DeliveryTimeRecord.Para.cdate).AliasName))
                    x_oDeliveryTimeRecordRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DeliveryTimeRecord.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DeliveryTimeRecord.Para.cid).AliasName))
                    x_oDeliveryTimeRecordRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DeliveryTimeRecord.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DeliveryTimeRecord.Para.active).AliasName))
                    x_oDeliveryTimeRecordRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DeliveryTimeRecord.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DeliveryTimeRecord.Para.pm8_10).AliasName))
                    x_oDeliveryTimeRecordRow.pm8_10 = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DeliveryTimeRecord.Para.pm8_10).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DeliveryTimeRecord.Para.location).AliasName))
                    x_oDeliveryTimeRecordRow.location = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DeliveryTimeRecord.Para.location).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DeliveryTimeRecord.Para.pm7_9).AliasName))
                    x_oDeliveryTimeRecordRow.pm7_9 = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DeliveryTimeRecord.Para.pm7_9).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DeliveryTimeRecord.Para.area).AliasName))
                    x_oDeliveryTimeRecordRow.area = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DeliveryTimeRecord.Para.area).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DeliveryTimeRecord.Para.pm6_8).AliasName))
                    x_oDeliveryTimeRecordRow.pm6_8 = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DeliveryTimeRecord.Para.pm6_8).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DeliveryTimeRecord.Para.pm).AliasName))
                    x_oDeliveryTimeRecordRow.pm = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DeliveryTimeRecord.Para.pm).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DeliveryTimeRecord.Para.am).AliasName))
                    x_oDeliveryTimeRecordRow.am = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DeliveryTimeRecord.Para.am).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DeliveryTimeRecord.Para.ddate).AliasName))
                    x_oDeliveryTimeRecordRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DeliveryTimeRecord.Para.ddate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DeliveryTimeRecord.Para.did).AliasName))
                    x_oDeliveryTimeRecordRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DeliveryTimeRecord.Para.did).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(DeliveryTimeRecord.Para.delivery_fee).AliasName))
                    x_oDeliveryTimeRecordRow.delivery_fee = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(DeliveryTimeRecord.Para.delivery_fee).AliasName];
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
            return DeliveryTimeRecordRepository.GetCount(x_oDB);
        }
        #endregion


        #region Get

        // ******************************
        // *  Handler for Data Getting
        // ******************************

        public static DeliveryTimeRecordEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            return DeliveryTimeRecordRepository.GetArrayObj(x_oDB, x_oColumnName, x_oArrayItemId);
        }

        public static DeliveryTimeRecordEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder)
        {
            return DeliveryTimeRecordRepository.GetArrayObj(x_oDB, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        #endregion


        #region List

        // ******************************
        // *  Handler for Data Listing
        // ******************************

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return DeliveryTimeRecordRepository.GetDataSet(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return DeliveryTimeRecordRepository.GetSearch(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            return DeliveryTimeRecordRepository.GetDataSet(x_oDB, x_sFilter);
        }
        #endregion

        #region Insert

        // ******************************
        // *  Handler for Data Inserting
        // ******************************

        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate, string x_sCid, global::System.Nullable<bool> x_bActive, global::System.Nullable<bool> x_bPm8_10, string x_sLocation, global::System.Nullable<bool> x_bPm7_9, string x_sArea, global::System.Nullable<bool> x_bPm6_8, global::System.Nullable<bool> x_bPm, global::System.Nullable<bool> x_bAm, global::System.Nullable<DateTime> x_dDdate, string x_sDid, global::System.Nullable<int> x_iDelivery_fee)
        {
            return DeliveryTimeRecordRepository.Insert(x_oDB, x_dCdate, x_sCid, x_bActive, x_bPm8_10, x_sLocation, x_bPm7_9, x_sArea, x_bPm6_8, x_bPm, x_bAm, x_dDdate, x_sDid, x_iDelivery_fee);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, DeliveryTimeRecord x_oDeliveryTimeRecord)
        {
            return DeliveryTimeRecordRepository.InsertWithOutLastID(x_oDB, x_oDeliveryTimeRecord);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate, string x_sCid, global::System.Nullable<bool> x_bActive, global::System.Nullable<bool> x_bPm8_10, string x_sLocation, global::System.Nullable<bool> x_bPm7_9, string x_sArea, global::System.Nullable<bool> x_bPm6_8, global::System.Nullable<bool> x_bPm, global::System.Nullable<bool> x_bAm, global::System.Nullable<DateTime> x_dDdate, string x_sDid, global::System.Nullable<int> x_iDelivery_fee)
        {
            return DeliveryTimeRecordRepository.InsertReturnLastID_SP(x_oDB, x_dCdate, x_sCid, x_bActive, x_bPm8_10, x_sLocation, x_bPm7_9, x_sArea, x_bPm6_8, x_bPm, x_bAm, x_dDdate, x_sDid, x_iDelivery_fee);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, DeliveryTimeRecord x_oDeliveryTimeRecord)
        {
            return DeliveryTimeRecordRepository.InsertReturnLastID_SP(x_oDB, x_oDeliveryTimeRecord);
        }

        #endregion

        #region Delete

        // ******************************
        // *  Handler for Data Deleting
        // ******************************

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            return DeliveryTimeRecordRepository.DeleteAll(x_oDB);
        }

        public static bool DeleteFilter(MSSQLConnect x_oDB, string x_sFilter)
        {
            return DeliveryTimeRecordRepository.DeleteFilter(x_oDB, x_sFilter);
        }

        public static bool Delete(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            return DeliveryTimeRecordRepository.Delete(x_oDB, x_iId);
        }


        #endregion

        #region Delete Uploaded Files

        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(DeliveryTimeRecord x_oDeliveryTimeRecordRow)
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

