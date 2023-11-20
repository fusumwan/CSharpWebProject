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
///-- Description:	<Description,Table :[Accessory],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [Accessory] Business layer
    /// </summary>

    public abstract class AccessoryBalBase
    {

        #region Constructor


        // ******************************
        // *  Handler for Class Constructor
        // ******************************

        public AccessoryBalBase()
        {
        }
        ~AccessoryBalBase()
        {
            this.Release();
        }
        #endregion


        #region ToDataSet


        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************

        public static global::System.Data.DataSet ToDataSet(Accessory x_oAccessory)
        {
            return GetDataSet(x_oAccessory, null, AccessoryInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(Accessory x_oAccessory, global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oAccessory, x_oMergeDSet, AccessoryInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(Accessory x_oAccessory, AccessoryInfo x_oTableSet)
        {
            return GetDataSet(x_oAccessory, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToDataSet(Accessory x_oAccessory, global::System.Data.DataSet x_oMergeDSet, AccessoryInfo x_oTableSet)
        {
            return GetDataSet(x_oAccessory, x_oMergeDSet, x_oTableSet);
        }


        protected static global::System.Data.DataSet GetDataSet(Accessory x_oAccessory, global::System.Data.DataSet x_oMergeDSet, AccessoryInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = AccessoryInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(Accessory.Para.TableName());
            if (x_oTableSet.Fields(Accessory.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[Accessory.Para.TableName()].Columns.Add(Accessory.Para.active); }
            if (x_oTableSet.Fields(Accessory.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[Accessory.Para.TableName()].Columns.Add(Accessory.Para.cdate); }
            if (x_oTableSet.Fields(Accessory.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[Accessory.Para.TableName()].Columns.Add(Accessory.Para.cid); }
            if (x_oTableSet.Fields(Accessory.Para.accessory_price).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[Accessory.Para.TableName()].Columns.Add(Accessory.Para.accessory_price); }
            if (x_oTableSet.Fields(Accessory.Para.sdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[Accessory.Para.TableName()].Columns.Add(Accessory.Para.sdate); }
            if (x_oTableSet.Fields(Accessory.Para.accessory_desc).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[Accessory.Para.TableName()].Columns.Add(Accessory.Para.accessory_desc); }
            if (x_oTableSet.Fields(Accessory.Para.last_stock).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[Accessory.Para.TableName()].Columns.Add(Accessory.Para.last_stock); }
            if (x_oTableSet.Fields(Accessory.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[Accessory.Para.TableName()].Columns.Add(Accessory.Para.edate); }
            if (x_oTableSet.Fields(Accessory.Para.accessory_code).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[Accessory.Para.TableName()].Columns.Add(Accessory.Para.accessory_code); }
            if (x_oTableSet.Fields(Accessory.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[Accessory.Para.TableName()].Columns.Add(Accessory.Para.ddate); }
            if (x_oTableSet.Fields(Accessory.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[Accessory.Para.TableName()].Columns.Add(Accessory.Para.mid); }
            if (x_oTableSet.Fields(Accessory.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[Accessory.Para.TableName()].Columns.Add(Accessory.Para.did); }
            if (x_oTableSet.Fields(Accessory.Para.quota).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[Accessory.Para.TableName()].Columns.Add(Accessory.Para.quota); }
            if (x_oAccessory != null)
            {
                global::System.Data.DataRow _oDRow = _oDSet.Tables[Accessory.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(Accessory.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[Accessory.Para.active] = x_oAccessory.GetActive(); }
                if (x_oTableSet.Fields(Accessory.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[Accessory.Para.cdate] = x_oAccessory.GetCdate(); }
                if (x_oTableSet.Fields(Accessory.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[Accessory.Para.cid] = x_oAccessory.GetCid(); }
                if (x_oTableSet.Fields(Accessory.Para.accessory_price).IsView || x_oTableSet.GetViewAll()) { _oDRow[Accessory.Para.accessory_price] = x_oAccessory.GetAccessory_price(); }
                if (x_oTableSet.Fields(Accessory.Para.sdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[Accessory.Para.sdate] = x_oAccessory.GetSdate(); }
                if (x_oTableSet.Fields(Accessory.Para.accessory_desc).IsView || x_oTableSet.GetViewAll()) { _oDRow[Accessory.Para.accessory_desc] = x_oAccessory.GetAccessory_desc(); }
                if (x_oTableSet.Fields(Accessory.Para.last_stock).IsView || x_oTableSet.GetViewAll()) { _oDRow[Accessory.Para.last_stock] = x_oAccessory.GetLast_stock(); }
                if (x_oTableSet.Fields(Accessory.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDRow[Accessory.Para.edate] = x_oAccessory.GetEdate(); }
                if (x_oTableSet.Fields(Accessory.Para.accessory_code).IsView || x_oTableSet.GetViewAll()) { _oDRow[Accessory.Para.accessory_code] = x_oAccessory.GetAccessory_code(); }
                if (x_oTableSet.Fields(Accessory.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[Accessory.Para.ddate] = x_oAccessory.GetDdate(); }
                if (x_oTableSet.Fields(Accessory.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDRow[Accessory.Para.mid] = x_oAccessory.GetMid(); }
                if (x_oTableSet.Fields(Accessory.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[Accessory.Para.did] = x_oAccessory.GetDid(); }
                if (x_oTableSet.Fields(Accessory.Para.quota).IsView || x_oTableSet.GetViewAll()) { _oDRow[Accessory.Para.quota] = x_oAccessory.GetQuota(); }
                _oDSet.Tables[Accessory.Para.TableName()].Rows.Add(_oDRow);
            }
            if (x_oMergeDSet != null) { _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }


        protected static global::System.Data.DataSet ToEmptyDataSetProcess(AccessoryInfo x_oTableSet)
        {
            return AccessoryBal.GetDataSet(null, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return AccessoryBal.ToEmptyDataSetProcess(AccessoryInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToEmptyDataSet(AccessoryInfo x_oTableSet)
        {
            return AccessoryBal.ToEmptyDataSetProcess(x_oTableSet);
        }


        #endregion ToDataSet

        #region To Table

        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(Accessory x_oAccessory, AccessoryInfo x_oTableSet)
        {
            return AccessoryBal.GetDataSet(null, null, x_oTableSet).Tables[Accessory.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(Accessory x_oAccessory)
        {
            return AccessoryBal.GetDataSet(x_oAccessory, null, AccessoryInfoDLL.CreateInfoInstanceObject()).Tables[Accessory.Para.TableName()];
        }
        #endregion

        #region To Row

        // ******************************
        // *  Handler for Data DataRow
        // ******************************


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            return Row(x_oTable, x_oDB, x_iMid, AccessoryInfoDLL.CreateInfoInstanceObject());
        }


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid, AccessoryInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB, x_iMid, x_oTableSet);
        }

        public static DataRow Row(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid, AccessoryInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = AccessoryInfoDLL.CreateInfoInstanceObject();
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                string _sQuery = "SELECT [Accessory].[active] AS ACCESSORY_ACTIVE,[Accessory].[cdate] AS ACCESSORY_CDATE,[Accessory].[cid] AS ACCESSORY_CID,[Accessory].[accessory_price] AS ACCESSORY_ACCESSORY_PRICE,[Accessory].[accessory_desc] AS ACCESSORY_ACCESSORY_DESC,[Accessory].[last_stock] AS ACCESSORY_LAST_STOCK,[Accessory].[edate] AS ACCESSORY_EDATE,[Accessory].[accessory_code] AS ACCESSORY_ACCESSORY_CODE,[Accessory].[did] AS ACCESSORY_DID,[Accessory].[ddate] AS ACCESSORY_DDATE,[Accessory].[mid] AS ACCESSORY_MID,[Accessory].[sdate] AS ACCESSORY_SDATE,[Accessory].[quota] AS ACCESSORY_QUOTA  FROM  [Accessory]  WHERE  [Accessory].[mid] = \'" + x_iMid.ToString() + "\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[Accessory]", "[" + Configurator.MSSQLTablePrefix + "Accessory]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read())
                    {
                        if (x_oTableSet.Fields(Accessory.Para.active).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(Accessory.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(Accessory.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["ACCESSORY_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(Accessory.Para.active).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(Accessory.Para.cdate).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(Accessory.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(Accessory.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["ACCESSORY_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(Accessory.Para.cdate).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(Accessory.Para.cid).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(Accessory.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(Accessory.Para.cid).AliasName].ToString()] = (string)_oData["ACCESSORY_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(Accessory.Para.cid).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(Accessory.Para.accessory_price).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_ACCESSORY_PRICE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(Accessory.Para.accessory_price).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(Accessory.Para.accessory_price).AliasName].ToString()] = (string)_oData["ACCESSORY_ACCESSORY_PRICE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(Accessory.Para.accessory_price).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(Accessory.Para.accessory_desc).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_ACCESSORY_DESC"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(Accessory.Para.accessory_desc).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(Accessory.Para.accessory_desc).AliasName].ToString()] = (string)_oData["ACCESSORY_ACCESSORY_DESC"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(Accessory.Para.accessory_desc).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(Accessory.Para.last_stock).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_LAST_STOCK"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(Accessory.Para.last_stock).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(Accessory.Para.last_stock).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["ACCESSORY_LAST_STOCK"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(Accessory.Para.last_stock).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(Accessory.Para.edate).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_EDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(Accessory.Para.edate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(Accessory.Para.edate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["ACCESSORY_EDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(Accessory.Para.edate).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(Accessory.Para.accessory_code).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_ACCESSORY_CODE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(Accessory.Para.accessory_code).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(Accessory.Para.accessory_code).AliasName].ToString()] = (string)_oData["ACCESSORY_ACCESSORY_CODE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(Accessory.Para.accessory_code).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(Accessory.Para.did).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(Accessory.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(Accessory.Para.did).AliasName].ToString()] = (string)_oData["ACCESSORY_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(Accessory.Para.did).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(Accessory.Para.ddate).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(Accessory.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(Accessory.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["ACCESSORY_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(Accessory.Para.ddate).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(Accessory.Para.mid).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_MID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(Accessory.Para.mid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(Accessory.Para.mid).AliasName].ToString()] = (global::System.Nullable<int>)_oData["ACCESSORY_MID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(Accessory.Para.mid).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(Accessory.Para.sdate).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_SDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(Accessory.Para.sdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(Accessory.Para.sdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["ACCESSORY_SDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(Accessory.Para.sdate).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(Accessory.Para.quota).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["ACCESSORY_QUOTA"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(Accessory.Para.quota).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(Accessory.Para.quota).AliasName].ToString()] = (string)_oData["ACCESSORY_QUOTA"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(Accessory.Para.quota).AliasName].ToString()] = string.Empty;
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

        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet, Accessory x_oAccessoryRow)
        {
            return SetByDataSetRowProc(x_iROW, Accessory.Para.TableName(), x_oDataSet, x_oAccessoryRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, Accessory x_oAccessoryRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet, x_oAccessoryRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, Accessory x_oAccessoryRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                AccessoryInfo _oTableSet = AccessoryInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Accessory.Para.active).AliasName))
                    x_oAccessoryRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Accessory.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Accessory.Para.cdate).AliasName))
                    x_oAccessoryRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Accessory.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Accessory.Para.cid).AliasName))
                    x_oAccessoryRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Accessory.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Accessory.Para.accessory_price).AliasName))
                    x_oAccessoryRow.accessory_price = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Accessory.Para.accessory_price).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Accessory.Para.sdate).AliasName))
                    x_oAccessoryRow.sdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Accessory.Para.sdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Accessory.Para.accessory_desc).AliasName))
                    x_oAccessoryRow.accessory_desc = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Accessory.Para.accessory_desc).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Accessory.Para.last_stock).AliasName))
                    x_oAccessoryRow.last_stock = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Accessory.Para.last_stock).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Accessory.Para.edate).AliasName))
                    x_oAccessoryRow.edate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Accessory.Para.edate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Accessory.Para.accessory_code).AliasName))
                    x_oAccessoryRow.accessory_code = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Accessory.Para.accessory_code).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Accessory.Para.ddate).AliasName))
                    x_oAccessoryRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Accessory.Para.ddate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Accessory.Para.mid).AliasName))
                    x_oAccessoryRow.mid = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Accessory.Para.mid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Accessory.Para.did).AliasName))
                    x_oAccessoryRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Accessory.Para.did).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Accessory.Para.quota).AliasName))
                    x_oAccessoryRow.quota = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Accessory.Para.quota).AliasName];
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
            return AccessoryRepository.GetCount(x_oDB);
        }
        #endregion


        #region Get

        // ******************************
        // *  Handler for Data Getting
        // ******************************

        public static AccessoryEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            return AccessoryRepository.GetArrayObj(x_oDB, x_oColumnName, x_oArrayItemId);
        }

        public static AccessoryEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder)
        {
            return AccessoryRepository.GetArrayObj(x_oDB, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        #endregion


        #region List

        // ******************************
        // *  Handler for Data Listing
        // ******************************

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return AccessoryRepository.GetDataSet(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return AccessoryRepository.GetSearch(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            return AccessoryRepository.GetDataSet(x_oDB, x_sFilter);
        }
        #endregion

        #region Insert

        // ******************************
        // *  Handler for Data Inserting
        // ******************************

        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bActive, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sAccessory_price, global::System.Nullable<DateTime> x_dSdate, string x_sAccessory_desc, global::System.Nullable<bool> x_bLast_stock, global::System.Nullable<DateTime> x_dEdate, string x_sAccessory_code, global::System.Nullable<DateTime> x_dDdate, string x_sDid, string x_sQuota)
        {
            return AccessoryRepository.Insert(x_oDB, x_bActive, x_dCdate, x_sCid, x_sAccessory_price, x_dSdate, x_sAccessory_desc, x_bLast_stock, x_dEdate, x_sAccessory_code, x_dDdate, x_sDid, x_sQuota);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, Accessory x_oAccessory)
        {
            return AccessoryRepository.InsertWithOutLastID(x_oDB, x_oAccessory);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bActive, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sAccessory_price, global::System.Nullable<DateTime> x_dSdate, string x_sAccessory_desc, global::System.Nullable<bool> x_bLast_stock, global::System.Nullable<DateTime> x_dEdate, string x_sAccessory_code, global::System.Nullable<DateTime> x_dDdate, string x_sDid, string x_sQuota)
        {
            return AccessoryRepository.InsertReturnLastID_SP(x_oDB, x_bActive, x_dCdate, x_sCid, x_sAccessory_price, x_dSdate, x_sAccessory_desc, x_bLast_stock, x_dEdate, x_sAccessory_code, x_dDdate, x_sDid, x_sQuota);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, Accessory x_oAccessory)
        {
            return AccessoryRepository.InsertReturnLastID_SP(x_oDB, x_oAccessory);
        }

        #endregion

        #region Delete

        // ******************************
        // *  Handler for Data Deleting
        // ******************************

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            return AccessoryRepository.DeleteAll(x_oDB);
        }

        public static bool DeleteFilter(MSSQLConnect x_oDB, string x_sFilter)
        {
            return AccessoryRepository.DeleteFilter(x_oDB, x_sFilter);
        }

        public static bool Delete(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            return AccessoryRepository.Delete(x_oDB, x_iMid);
        }


        #endregion

        #region Delete Uploaded Files

        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(Accessory x_oAccessoryRow)
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

