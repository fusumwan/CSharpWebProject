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
///-- Description:	<Description,Table :[ProductItemCode],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [ProductItemCode] Business layer
    /// </summary>

    public abstract class ProductItemCodeBalBase
    {

        #region Constructor


        // ******************************
        // *  Handler for Class Constructor
        // ******************************

        public ProductItemCodeBalBase()
        {
        }
        ~ProductItemCodeBalBase()
        {
            this.Release();
        }
        #endregion


        #region ToDataSet


        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************

        public static global::System.Data.DataSet ToDataSet(ProductItemCode x_oProductItemCode)
        {
            return GetDataSet(x_oProductItemCode, null, ProductItemCodeInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(ProductItemCode x_oProductItemCode, global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oProductItemCode, x_oMergeDSet, ProductItemCodeInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(ProductItemCode x_oProductItemCode, ProductItemCodeInfo x_oTableSet)
        {
            return GetDataSet(x_oProductItemCode, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToDataSet(ProductItemCode x_oProductItemCode, global::System.Data.DataSet x_oMergeDSet, ProductItemCodeInfo x_oTableSet)
        {
            return GetDataSet(x_oProductItemCode, x_oMergeDSet, x_oTableSet);
        }


        protected static global::System.Data.DataSet GetDataSet(ProductItemCode x_oProductItemCode, global::System.Data.DataSet x_oMergeDSet, ProductItemCodeInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = ProductItemCodeInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(ProductItemCode.Para.TableName());
            if (x_oTableSet.Fields(ProductItemCode.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProductItemCode.Para.TableName()].Columns.Add(ProductItemCode.Para.active); }
            if (x_oTableSet.Fields(ProductItemCode.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProductItemCode.Para.TableName()].Columns.Add(ProductItemCode.Para.cdate); }
            if (x_oTableSet.Fields(ProductItemCode.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProductItemCode.Para.TableName()].Columns.Add(ProductItemCode.Para.cid); }
            if (x_oTableSet.Fields(ProductItemCode.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProductItemCode.Para.TableName()].Columns.Add(ProductItemCode.Para.did); }
            if (x_oTableSet.Fields(ProductItemCode.Para.type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProductItemCode.Para.TableName()].Columns.Add(ProductItemCode.Para.type); }
            if (x_oTableSet.Fields(ProductItemCode.Para.hs_model).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProductItemCode.Para.TableName()].Columns.Add(ProductItemCode.Para.hs_model); }
            if (x_oTableSet.Fields(ProductItemCode.Para.last_stock).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProductItemCode.Para.TableName()].Columns.Add(ProductItemCode.Para.last_stock); }
            if (x_oTableSet.Fields(ProductItemCode.Para.item_code).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProductItemCode.Para.TableName()].Columns.Add(ProductItemCode.Para.item_code); }
            if (x_oTableSet.Fields(ProductItemCode.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProductItemCode.Para.TableName()].Columns.Add(ProductItemCode.Para.edate); }
            if (x_oTableSet.Fields(ProductItemCode.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProductItemCode.Para.TableName()].Columns.Add(ProductItemCode.Para.ddate); }
            if (x_oTableSet.Fields(ProductItemCode.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProductItemCode.Para.TableName()].Columns.Add(ProductItemCode.Para.mid); }
            if (x_oTableSet.Fields(ProductItemCode.Para.sdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProductItemCode.Para.TableName()].Columns.Add(ProductItemCode.Para.sdate); }
            if (x_oTableSet.Fields(ProductItemCode.Para.quota).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[ProductItemCode.Para.TableName()].Columns.Add(ProductItemCode.Para.quota); }
            if (x_oProductItemCode != null)
            {
                global::System.Data.DataRow _oDRow = _oDSet.Tables[ProductItemCode.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(ProductItemCode.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProductItemCode.Para.active] = x_oProductItemCode.GetActive(); }
                if (x_oTableSet.Fields(ProductItemCode.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProductItemCode.Para.cdate] = x_oProductItemCode.GetCdate(); }
                if (x_oTableSet.Fields(ProductItemCode.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProductItemCode.Para.cid] = x_oProductItemCode.GetCid(); }
                if (x_oTableSet.Fields(ProductItemCode.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProductItemCode.Para.did] = x_oProductItemCode.GetDid(); }
                if (x_oTableSet.Fields(ProductItemCode.Para.type).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProductItemCode.Para.type] = x_oProductItemCode.GetType(); }
                if (x_oTableSet.Fields(ProductItemCode.Para.hs_model).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProductItemCode.Para.hs_model] = x_oProductItemCode.GetHs_model(); }
                if (x_oTableSet.Fields(ProductItemCode.Para.last_stock).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProductItemCode.Para.last_stock] = x_oProductItemCode.GetLast_stock(); }
                if (x_oTableSet.Fields(ProductItemCode.Para.item_code).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProductItemCode.Para.item_code] = x_oProductItemCode.GetItem_code(); }
                if (x_oTableSet.Fields(ProductItemCode.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProductItemCode.Para.edate] = x_oProductItemCode.GetEdate(); }
                if (x_oTableSet.Fields(ProductItemCode.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProductItemCode.Para.ddate] = x_oProductItemCode.GetDdate(); }
                if (x_oTableSet.Fields(ProductItemCode.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProductItemCode.Para.mid] = x_oProductItemCode.GetMid(); }
                if (x_oTableSet.Fields(ProductItemCode.Para.sdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProductItemCode.Para.sdate] = x_oProductItemCode.GetSdate(); }
                if (x_oTableSet.Fields(ProductItemCode.Para.quota).IsView || x_oTableSet.GetViewAll()) { _oDRow[ProductItemCode.Para.quota] = x_oProductItemCode.GetQuota(); }
                _oDSet.Tables[ProductItemCode.Para.TableName()].Rows.Add(_oDRow);
            }
            if (x_oMergeDSet != null) { _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }


        protected static global::System.Data.DataSet ToEmptyDataSetProcess(ProductItemCodeInfo x_oTableSet)
        {
            return ProductItemCodeBal.GetDataSet(null, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return ProductItemCodeBal.ToEmptyDataSetProcess(ProductItemCodeInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToEmptyDataSet(ProductItemCodeInfo x_oTableSet)
        {
            return ProductItemCodeBal.ToEmptyDataSetProcess(x_oTableSet);
        }


        #endregion ToDataSet

        #region To Table

        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(ProductItemCode x_oProductItemCode, ProductItemCodeInfo x_oTableSet)
        {
            return ProductItemCodeBal.GetDataSet(null, null, x_oTableSet).Tables[ProductItemCode.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(ProductItemCode x_oProductItemCode)
        {
            return ProductItemCodeBal.GetDataSet(x_oProductItemCode, null, ProductItemCodeInfoDLL.CreateInfoInstanceObject()).Tables[ProductItemCode.Para.TableName()];
        }
        #endregion

        #region To Row

        // ******************************
        // *  Handler for Data DataRow
        // ******************************


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            return Row(x_oTable, x_oDB, x_iMid, ProductItemCodeInfoDLL.CreateInfoInstanceObject());
        }


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid, ProductItemCodeInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB, x_iMid, x_oTableSet);
        }

        public static DataRow Row(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid, ProductItemCodeInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = ProductItemCodeInfoDLL.CreateInfoInstanceObject();
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                string _sQuery = "SELECT [ProductItemCode].[cid] AS PRODUCTITEMCODE_CID,[ProductItemCode].[active] AS PRODUCTITEMCODE_ACTIVE,[ProductItemCode].[cdate] AS PRODUCTITEMCODE_CDATE,[ProductItemCode].[hs_model] AS PRODUCTITEMCODE_HS_MODEL,[ProductItemCode].[did] AS PRODUCTITEMCODE_DID,[ProductItemCode].[type] AS PRODUCTITEMCODE_TYPE,[ProductItemCode].[last_stock] AS PRODUCTITEMCODE_LAST_STOCK,[ProductItemCode].[item_code] AS PRODUCTITEMCODE_ITEM_CODE,[ProductItemCode].[edate] AS PRODUCTITEMCODE_EDATE,[ProductItemCode].[ddate] AS PRODUCTITEMCODE_DDATE,[ProductItemCode].[mid] AS PRODUCTITEMCODE_MID,[ProductItemCode].[sdate] AS PRODUCTITEMCODE_SDATE,[ProductItemCode].[quota] AS PRODUCTITEMCODE_QUOTA  FROM  [ProductItemCode]  WHERE  [ProductItemCode].[mid] = \'" + x_iMid.ToString() + "\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProductItemCode]", "[" + Configurator.MSSQLTablePrefix + "ProductItemCode]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read())
                    {
                        if (x_oTableSet.Fields(ProductItemCode.Para.cid).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProductItemCode.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProductItemCode.Para.cid).AliasName].ToString()] = (string)_oData["PRODUCTITEMCODE_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProductItemCode.Para.cid).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(ProductItemCode.Para.active).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProductItemCode.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProductItemCode.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["PRODUCTITEMCODE_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProductItemCode.Para.active).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(ProductItemCode.Para.cdate).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProductItemCode.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProductItemCode.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["PRODUCTITEMCODE_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProductItemCode.Para.cdate).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(ProductItemCode.Para.hs_model).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_HS_MODEL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProductItemCode.Para.hs_model).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProductItemCode.Para.hs_model).AliasName].ToString()] = (string)_oData["PRODUCTITEMCODE_HS_MODEL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProductItemCode.Para.hs_model).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(ProductItemCode.Para.did).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProductItemCode.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProductItemCode.Para.did).AliasName].ToString()] = (string)_oData["PRODUCTITEMCODE_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProductItemCode.Para.did).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(ProductItemCode.Para.type).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProductItemCode.Para.type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProductItemCode.Para.type).AliasName].ToString()] = (string)_oData["PRODUCTITEMCODE_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProductItemCode.Para.type).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(ProductItemCode.Para.last_stock).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_LAST_STOCK"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProductItemCode.Para.last_stock).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProductItemCode.Para.last_stock).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["PRODUCTITEMCODE_LAST_STOCK"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProductItemCode.Para.last_stock).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(ProductItemCode.Para.item_code).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_ITEM_CODE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProductItemCode.Para.item_code).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProductItemCode.Para.item_code).AliasName].ToString()] = (string)_oData["PRODUCTITEMCODE_ITEM_CODE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProductItemCode.Para.item_code).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(ProductItemCode.Para.edate).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_EDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProductItemCode.Para.edate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProductItemCode.Para.edate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["PRODUCTITEMCODE_EDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProductItemCode.Para.edate).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(ProductItemCode.Para.ddate).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProductItemCode.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProductItemCode.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["PRODUCTITEMCODE_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProductItemCode.Para.ddate).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(ProductItemCode.Para.mid).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_MID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProductItemCode.Para.mid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProductItemCode.Para.mid).AliasName].ToString()] = (global::System.Nullable<int>)_oData["PRODUCTITEMCODE_MID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProductItemCode.Para.mid).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(ProductItemCode.Para.sdate).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_SDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProductItemCode.Para.sdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProductItemCode.Para.sdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["PRODUCTITEMCODE_SDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProductItemCode.Para.sdate).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(ProductItemCode.Para.quota).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["PRODUCTITEMCODE_QUOTA"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(ProductItemCode.Para.quota).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProductItemCode.Para.quota).AliasName].ToString()] = (string)_oData["PRODUCTITEMCODE_QUOTA"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(ProductItemCode.Para.quota).AliasName].ToString()] = string.Empty;
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

        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet, ProductItemCode x_oProductItemCodeRow)
        {
            return SetByDataSetRowProc(x_iROW, ProductItemCode.Para.TableName(), x_oDataSet, x_oProductItemCodeRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, ProductItemCode x_oProductItemCodeRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet, x_oProductItemCodeRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, ProductItemCode x_oProductItemCodeRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                ProductItemCodeInfo _oTableSet = ProductItemCodeInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProductItemCode.Para.active).AliasName))
                    x_oProductItemCodeRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProductItemCode.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProductItemCode.Para.cdate).AliasName))
                    x_oProductItemCodeRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProductItemCode.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProductItemCode.Para.cid).AliasName))
                    x_oProductItemCodeRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProductItemCode.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProductItemCode.Para.did).AliasName))
                    x_oProductItemCodeRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProductItemCode.Para.did).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProductItemCode.Para.type).AliasName))
                    x_oProductItemCodeRow.type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProductItemCode.Para.type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProductItemCode.Para.hs_model).AliasName))
                    x_oProductItemCodeRow.hs_model = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProductItemCode.Para.hs_model).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProductItemCode.Para.last_stock).AliasName))
                    x_oProductItemCodeRow.last_stock = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProductItemCode.Para.last_stock).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProductItemCode.Para.item_code).AliasName))
                    x_oProductItemCodeRow.item_code = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProductItemCode.Para.item_code).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProductItemCode.Para.edate).AliasName))
                    x_oProductItemCodeRow.edate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProductItemCode.Para.edate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProductItemCode.Para.ddate).AliasName))
                    x_oProductItemCodeRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProductItemCode.Para.ddate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProductItemCode.Para.mid).AliasName))
                    x_oProductItemCodeRow.mid = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProductItemCode.Para.mid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProductItemCode.Para.sdate).AliasName))
                    x_oProductItemCodeRow.sdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProductItemCode.Para.sdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProductItemCode.Para.quota).AliasName))
                    x_oProductItemCodeRow.quota = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProductItemCode.Para.quota).AliasName];
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
            return ProductItemCodeRepository.GetCount(x_oDB);
        }
        #endregion


        #region Get

        // ******************************
        // *  Handler for Data Getting
        // ******************************

        public static ProductItemCodeEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            return ProductItemCodeRepository.GetArrayObj(x_oDB, x_oColumnName, x_oArrayItemId);
        }

        public static ProductItemCodeEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder)
        {
            return ProductItemCodeRepository.GetArrayObj(x_oDB, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        #endregion


        #region List

        // ******************************
        // *  Handler for Data Listing
        // ******************************

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return ProductItemCodeRepository.GetDataSet(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return ProductItemCodeRepository.GetSearch(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            return ProductItemCodeRepository.GetDataSet(x_oDB, x_sFilter);
        }
        #endregion

        #region Insert

        // ******************************
        // *  Handler for Data Inserting
        // ******************************

        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bActive, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sDid, string x_sType, string x_sHs_model, global::System.Nullable<bool> x_bLast_stock, string x_sItem_code, global::System.Nullable<DateTime> x_dEdate, global::System.Nullable<DateTime> x_dDdate, global::System.Nullable<DateTime> x_dSdate, string x_sQuota)
        {
            return ProductItemCodeRepository.Insert(x_oDB, x_bActive, x_dCdate, x_sCid, x_sDid, x_sType, x_sHs_model, x_bLast_stock, x_sItem_code, x_dEdate, x_dDdate, x_dSdate, x_sQuota);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, ProductItemCode x_oProductItemCode)
        {
            return ProductItemCodeRepository.InsertWithOutLastID(x_oDB, x_oProductItemCode);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bActive, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sDid, string x_sType, string x_sHs_model, global::System.Nullable<bool> x_bLast_stock, string x_sItem_code, global::System.Nullable<DateTime> x_dEdate, global::System.Nullable<DateTime> x_dDdate, global::System.Nullable<DateTime> x_dSdate, string x_sQuota)
        {
            return ProductItemCodeRepository.InsertReturnLastID_SP(x_oDB, x_bActive, x_dCdate, x_sCid, x_sDid, x_sType, x_sHs_model, x_bLast_stock, x_sItem_code, x_dEdate, x_dDdate, x_dSdate, x_sQuota);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, ProductItemCode x_oProductItemCode)
        {
            return ProductItemCodeRepository.InsertReturnLastID_SP(x_oDB, x_oProductItemCode);
        }

        #endregion

        #region Delete

        // ******************************
        // *  Handler for Data Deleting
        // ******************************

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            return ProductItemCodeRepository.DeleteAll(x_oDB);
        }

        public static bool DeleteFilter(MSSQLConnect x_oDB, string x_sFilter)
        {
            return ProductItemCodeRepository.DeleteFilter(x_oDB, x_sFilter);
        }

        public static bool Delete(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            return ProductItemCodeRepository.Delete(x_oDB, x_iMid);
        }


        #endregion

        #region Delete Uploaded Files

        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(ProductItemCode x_oProductItemCodeRow)
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

