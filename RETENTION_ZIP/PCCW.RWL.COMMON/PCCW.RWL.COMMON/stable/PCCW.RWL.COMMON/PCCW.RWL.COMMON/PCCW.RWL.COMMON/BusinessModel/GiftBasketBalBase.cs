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
///-- Description:	<Description,Table :[GiftBasket],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [GiftBasket] Business layer
    /// </summary>

    public abstract class GiftBasketBalBase
    {

        #region Constructor


        // ******************************
        // *  Handler for Class Constructor
        // ******************************

        public GiftBasketBalBase()
        {
        }
        ~GiftBasketBalBase()
        {
            this.Release();
        }
        #endregion


        #region ToDataSet


        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************

        public static global::System.Data.DataSet ToDataSet(GiftBasket x_oGiftBasket)
        {
            return GetDataSet(x_oGiftBasket, null, GiftBasketInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(GiftBasket x_oGiftBasket, global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oGiftBasket, x_oMergeDSet, GiftBasketInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(GiftBasket x_oGiftBasket, GiftBasketInfo x_oTableSet)
        {
            return GetDataSet(x_oGiftBasket, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToDataSet(GiftBasket x_oGiftBasket, global::System.Data.DataSet x_oMergeDSet, GiftBasketInfo x_oTableSet)
        {
            return GetDataSet(x_oGiftBasket, x_oMergeDSet, x_oTableSet);
        }


        protected static global::System.Data.DataSet GetDataSet(GiftBasket x_oGiftBasket, global::System.Data.DataSet x_oMergeDSet, GiftBasketInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = GiftBasketInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(GiftBasket.Para.TableName());
            if (x_oTableSet.Fields(GiftBasket.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[GiftBasket.Para.TableName()].Columns.Add(GiftBasket.Para.active); }
            if (x_oTableSet.Fields(GiftBasket.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[GiftBasket.Para.TableName()].Columns.Add(GiftBasket.Para.cdate); }
            if (x_oTableSet.Fields(GiftBasket.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[GiftBasket.Para.TableName()].Columns.Add(GiftBasket.Para.cid); }
            if (x_oTableSet.Fields(GiftBasket.Para.gift_code).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[GiftBasket.Para.TableName()].Columns.Add(GiftBasket.Para.gift_code); }
            if (x_oTableSet.Fields(GiftBasket.Para.sdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[GiftBasket.Para.TableName()].Columns.Add(GiftBasket.Para.sdate); }
            if (x_oTableSet.Fields(GiftBasket.Para.last_stock).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[GiftBasket.Para.TableName()].Columns.Add(GiftBasket.Para.last_stock); }
            if (x_oTableSet.Fields(GiftBasket.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[GiftBasket.Para.TableName()].Columns.Add(GiftBasket.Para.edate); }
            if (x_oTableSet.Fields(GiftBasket.Para.gift_desc).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[GiftBasket.Para.TableName()].Columns.Add(GiftBasket.Para.gift_desc); }
            if (x_oTableSet.Fields(GiftBasket.Para.gift_gp).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[GiftBasket.Para.TableName()].Columns.Add(GiftBasket.Para.gift_gp); }
            if (x_oTableSet.Fields(GiftBasket.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[GiftBasket.Para.TableName()].Columns.Add(GiftBasket.Para.ddate); }
            if (x_oTableSet.Fields(GiftBasket.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[GiftBasket.Para.TableName()].Columns.Add(GiftBasket.Para.mid); }
            if (x_oTableSet.Fields(GiftBasket.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[GiftBasket.Para.TableName()].Columns.Add(GiftBasket.Para.did); }
            if (x_oTableSet.Fields(GiftBasket.Para.quota).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[GiftBasket.Para.TableName()].Columns.Add(GiftBasket.Para.quota); }
            if (x_oGiftBasket != null)
            {
                global::System.Data.DataRow _oDRow = _oDSet.Tables[GiftBasket.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(GiftBasket.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[GiftBasket.Para.active] = x_oGiftBasket.GetActive(); }
                if (x_oTableSet.Fields(GiftBasket.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[GiftBasket.Para.cdate] = x_oGiftBasket.GetCdate(); }
                if (x_oTableSet.Fields(GiftBasket.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[GiftBasket.Para.cid] = x_oGiftBasket.GetCid(); }
                if (x_oTableSet.Fields(GiftBasket.Para.gift_code).IsView || x_oTableSet.GetViewAll()) { _oDRow[GiftBasket.Para.gift_code] = x_oGiftBasket.GetGift_code(); }
                if (x_oTableSet.Fields(GiftBasket.Para.sdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[GiftBasket.Para.sdate] = x_oGiftBasket.GetSdate(); }
                if (x_oTableSet.Fields(GiftBasket.Para.last_stock).IsView || x_oTableSet.GetViewAll()) { _oDRow[GiftBasket.Para.last_stock] = x_oGiftBasket.GetLast_stock(); }
                if (x_oTableSet.Fields(GiftBasket.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDRow[GiftBasket.Para.edate] = x_oGiftBasket.GetEdate(); }
                if (x_oTableSet.Fields(GiftBasket.Para.gift_desc).IsView || x_oTableSet.GetViewAll()) { _oDRow[GiftBasket.Para.gift_desc] = x_oGiftBasket.GetGift_desc(); }
                if (x_oTableSet.Fields(GiftBasket.Para.gift_gp).IsView || x_oTableSet.GetViewAll()) { _oDRow[GiftBasket.Para.gift_gp] = x_oGiftBasket.GetGift_gp(); }
                if (x_oTableSet.Fields(GiftBasket.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[GiftBasket.Para.ddate] = x_oGiftBasket.GetDdate(); }
                if (x_oTableSet.Fields(GiftBasket.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDRow[GiftBasket.Para.mid] = x_oGiftBasket.GetMid(); }
                if (x_oTableSet.Fields(GiftBasket.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[GiftBasket.Para.did] = x_oGiftBasket.GetDid(); }
                if (x_oTableSet.Fields(GiftBasket.Para.quota).IsView || x_oTableSet.GetViewAll()) { _oDRow[GiftBasket.Para.quota] = x_oGiftBasket.GetQuota(); }
                _oDSet.Tables[GiftBasket.Para.TableName()].Rows.Add(_oDRow);
            }
            if (x_oMergeDSet != null) { _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }


        protected static global::System.Data.DataSet ToEmptyDataSetProcess(GiftBasketInfo x_oTableSet)
        {
            return GiftBasketBal.GetDataSet(null, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return GiftBasketBal.ToEmptyDataSetProcess(GiftBasketInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToEmptyDataSet(GiftBasketInfo x_oTableSet)
        {
            return GiftBasketBal.ToEmptyDataSetProcess(x_oTableSet);
        }


        #endregion ToDataSet

        #region To Table

        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(GiftBasket x_oGiftBasket, GiftBasketInfo x_oTableSet)
        {
            return GiftBasketBal.GetDataSet(null, null, x_oTableSet).Tables[GiftBasket.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(GiftBasket x_oGiftBasket)
        {
            return GiftBasketBal.GetDataSet(x_oGiftBasket, null, GiftBasketInfoDLL.CreateInfoInstanceObject()).Tables[GiftBasket.Para.TableName()];
        }
        #endregion

        #region To Row

        // ******************************
        // *  Handler for Data DataRow
        // ******************************


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            return Row(x_oTable, x_oDB, x_iMid, GiftBasketInfoDLL.CreateInfoInstanceObject());
        }


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid, GiftBasketInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB, x_iMid, x_oTableSet);
        }

        public static DataRow Row(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid, GiftBasketInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = GiftBasketInfoDLL.CreateInfoInstanceObject();
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                string _sQuery = "SELECT [GiftBasket].[gift_code] AS GIFTBASKET_GIFT_CODE,[GiftBasket].[cdate] AS GIFTBASKET_CDATE,[GiftBasket].[cid] AS GIFTBASKET_CID,[GiftBasket].[active] AS GIFTBASKET_ACTIVE,[GiftBasket].[last_stock] AS GIFTBASKET_LAST_STOCK,[GiftBasket].[edate] AS GIFTBASKET_EDATE,[GiftBasket].[did] AS GIFTBASKET_DID,[GiftBasket].[gift_desc] AS GIFTBASKET_GIFT_DESC,[GiftBasket].[gift_gp] AS GIFTBASKET_GIFT_GP,[GiftBasket].[ddate] AS GIFTBASKET_DDATE,[GiftBasket].[mid] AS GIFTBASKET_MID,[GiftBasket].[sdate] AS GIFTBASKET_SDATE,[GiftBasket].[quota] AS GIFTBASKET_QUOTA  FROM  [GiftBasket]  WHERE  [GiftBasket].[mid] = \'" + x_iMid.ToString() + "\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[GiftBasket]", "[" + Configurator.MSSQLTablePrefix + "GiftBasket]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read())
                    {
                        if (x_oTableSet.Fields(GiftBasket.Para.gift_code).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_GIFT_CODE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(GiftBasket.Para.gift_code).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(GiftBasket.Para.gift_code).AliasName].ToString()] = (string)_oData["GIFTBASKET_GIFT_CODE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(GiftBasket.Para.gift_code).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(GiftBasket.Para.cdate).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(GiftBasket.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(GiftBasket.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["GIFTBASKET_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(GiftBasket.Para.cdate).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(GiftBasket.Para.cid).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(GiftBasket.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(GiftBasket.Para.cid).AliasName].ToString()] = (string)_oData["GIFTBASKET_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(GiftBasket.Para.cid).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(GiftBasket.Para.active).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(GiftBasket.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(GiftBasket.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["GIFTBASKET_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(GiftBasket.Para.active).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(GiftBasket.Para.last_stock).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_LAST_STOCK"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(GiftBasket.Para.last_stock).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(GiftBasket.Para.last_stock).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["GIFTBASKET_LAST_STOCK"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(GiftBasket.Para.last_stock).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(GiftBasket.Para.edate).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_EDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(GiftBasket.Para.edate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(GiftBasket.Para.edate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["GIFTBASKET_EDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(GiftBasket.Para.edate).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(GiftBasket.Para.did).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(GiftBasket.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(GiftBasket.Para.did).AliasName].ToString()] = (string)_oData["GIFTBASKET_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(GiftBasket.Para.did).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(GiftBasket.Para.gift_desc).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_GIFT_DESC"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(GiftBasket.Para.gift_desc).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(GiftBasket.Para.gift_desc).AliasName].ToString()] = (string)_oData["GIFTBASKET_GIFT_DESC"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(GiftBasket.Para.gift_desc).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(GiftBasket.Para.gift_gp).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_GIFT_GP"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(GiftBasket.Para.gift_gp).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(GiftBasket.Para.gift_gp).AliasName].ToString()] = (string)_oData["GIFTBASKET_GIFT_GP"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(GiftBasket.Para.gift_gp).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(GiftBasket.Para.ddate).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(GiftBasket.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(GiftBasket.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["GIFTBASKET_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(GiftBasket.Para.ddate).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(GiftBasket.Para.mid).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_MID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(GiftBasket.Para.mid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(GiftBasket.Para.mid).AliasName].ToString()] = (global::System.Nullable<int>)_oData["GIFTBASKET_MID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(GiftBasket.Para.mid).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(GiftBasket.Para.sdate).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_SDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(GiftBasket.Para.sdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(GiftBasket.Para.sdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["GIFTBASKET_SDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(GiftBasket.Para.sdate).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(GiftBasket.Para.quota).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["GIFTBASKET_QUOTA"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(GiftBasket.Para.quota).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(GiftBasket.Para.quota).AliasName].ToString()] = (string)_oData["GIFTBASKET_QUOTA"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(GiftBasket.Para.quota).AliasName].ToString()] = string.Empty;
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

        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet, GiftBasket x_oGiftBasketRow)
        {
            return SetByDataSetRowProc(x_iROW, GiftBasket.Para.TableName(), x_oDataSet, x_oGiftBasketRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, GiftBasket x_oGiftBasketRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet, x_oGiftBasketRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, GiftBasket x_oGiftBasketRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                GiftBasketInfo _oTableSet = GiftBasketInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(GiftBasket.Para.active).AliasName))
                    x_oGiftBasketRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(GiftBasket.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(GiftBasket.Para.cdate).AliasName))
                    x_oGiftBasketRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(GiftBasket.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(GiftBasket.Para.cid).AliasName))
                    x_oGiftBasketRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(GiftBasket.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(GiftBasket.Para.gift_code).AliasName))
                    x_oGiftBasketRow.gift_code = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(GiftBasket.Para.gift_code).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(GiftBasket.Para.sdate).AliasName))
                    x_oGiftBasketRow.sdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(GiftBasket.Para.sdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(GiftBasket.Para.last_stock).AliasName))
                    x_oGiftBasketRow.last_stock = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(GiftBasket.Para.last_stock).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(GiftBasket.Para.edate).AliasName))
                    x_oGiftBasketRow.edate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(GiftBasket.Para.edate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(GiftBasket.Para.gift_desc).AliasName))
                    x_oGiftBasketRow.gift_desc = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(GiftBasket.Para.gift_desc).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(GiftBasket.Para.gift_gp).AliasName))
                    x_oGiftBasketRow.gift_gp = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(GiftBasket.Para.gift_gp).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(GiftBasket.Para.ddate).AliasName))
                    x_oGiftBasketRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(GiftBasket.Para.ddate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(GiftBasket.Para.mid).AliasName))
                    x_oGiftBasketRow.mid = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(GiftBasket.Para.mid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(GiftBasket.Para.did).AliasName))
                    x_oGiftBasketRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(GiftBasket.Para.did).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(GiftBasket.Para.quota).AliasName))
                    x_oGiftBasketRow.quota = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(GiftBasket.Para.quota).AliasName];
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
            return GiftBasketRepository.GetCount(x_oDB);
        }
        #endregion


        #region Get

        // ******************************
        // *  Handler for Data Getting
        // ******************************

        public static GiftBasketEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            return GiftBasketRepository.GetArrayObj(x_oDB, x_oColumnName, x_oArrayItemId);
        }

        public static GiftBasketEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder)
        {
            return GiftBasketRepository.GetArrayObj(x_oDB, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        #endregion


        #region List

        // ******************************
        // *  Handler for Data Listing
        // ******************************

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return GiftBasketRepository.GetDataSet(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return GiftBasketRepository.GetSearch(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            return GiftBasketRepository.GetDataSet(x_oDB, x_sFilter);
        }
        #endregion

        #region Insert

        // ******************************
        // *  Handler for Data Inserting
        // ******************************

        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bActive, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sGift_code, global::System.Nullable<DateTime> x_dSdate, global::System.Nullable<bool> x_bLast_stock, global::System.Nullable<DateTime> x_dEdate, string x_sGift_desc, string x_sGift_gp, global::System.Nullable<DateTime> x_dDdate, string x_sDid, string x_sQuota)
        {
            return GiftBasketRepository.Insert(x_oDB, x_bActive, x_dCdate, x_sCid, x_sGift_code, x_dSdate, x_bLast_stock, x_dEdate, x_sGift_desc, x_sGift_gp, x_dDdate, x_sDid, x_sQuota);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, GiftBasket x_oGiftBasket)
        {
            return GiftBasketRepository.InsertWithOutLastID(x_oDB, x_oGiftBasket);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bActive, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sGift_code, global::System.Nullable<DateTime> x_dSdate, global::System.Nullable<bool> x_bLast_stock, global::System.Nullable<DateTime> x_dEdate, string x_sGift_desc, string x_sGift_gp, global::System.Nullable<DateTime> x_dDdate, string x_sDid, string x_sQuota)
        {
            return GiftBasketRepository.InsertReturnLastID_SP(x_oDB, x_bActive, x_dCdate, x_sCid, x_sGift_code, x_dSdate, x_bLast_stock, x_dEdate, x_sGift_desc, x_sGift_gp, x_dDdate, x_sDid, x_sQuota);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, GiftBasket x_oGiftBasket)
        {
            return GiftBasketRepository.InsertReturnLastID_SP(x_oDB, x_oGiftBasket);
        }

        #endregion

        #region Delete

        // ******************************
        // *  Handler for Data Deleting
        // ******************************

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            return GiftBasketRepository.DeleteAll(x_oDB);
        }

        public static bool DeleteFilter(MSSQLConnect x_oDB, string x_sFilter)
        {
            return GiftBasketRepository.DeleteFilter(x_oDB, x_sFilter);
        }

        public static bool Delete(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            return GiftBasketRepository.Delete(x_oDB, x_iMid);
        }


        #endregion

        #region Delete Uploaded Files

        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(GiftBasket x_oGiftBasketRow)
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

