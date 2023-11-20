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
///-- Create date: <Create Date 2009-11-17>
///-- Description:	<Description,Table :[MobileGoWirelessDetail],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [MobileGoWirelessDetail] Business layer
    /// </summary>

    public abstract class MobileGoWirelessDetailBalBase
    {

        #region Constructor


        // ******************************
        // *  Handler for Class Constructor
        // ******************************

        public MobileGoWirelessDetailBalBase()
        {
        }
        ~MobileGoWirelessDetailBalBase()
        {
            this.Release();
        }
        #endregion


        #region ToDataSet


        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************

        public static global::System.Data.DataSet ToDataSet(MobileGoWirelessDetail x_oMobileGoWirelessDetail)
        {
            return GetDataSet(x_oMobileGoWirelessDetail, null, MobileGoWirelessDetailInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(MobileGoWirelessDetail x_oMobileGoWirelessDetail, global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oMobileGoWirelessDetail, x_oMergeDSet, MobileGoWirelessDetailInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(MobileGoWirelessDetail x_oMobileGoWirelessDetail, MobileGoWirelessDetailInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileGoWirelessDetail, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToDataSet(MobileGoWirelessDetail x_oMobileGoWirelessDetail, global::System.Data.DataSet x_oMergeDSet, MobileGoWirelessDetailInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileGoWirelessDetail, x_oMergeDSet, x_oTableSet);
        }


        protected static global::System.Data.DataSet GetDataSet(MobileGoWirelessDetail x_oMobileGoWirelessDetail, global::System.Data.DataSet x_oMergeDSet, MobileGoWirelessDetailInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileGoWirelessDetailInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(MobileGoWirelessDetail.Para.TableName());
            if (x_oTableSet.Fields(MobileGoWirelessDetail.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileGoWirelessDetail.Para.TableName()].Columns.Add(MobileGoWirelessDetail.Para.cid); }
            if (x_oTableSet.Fields(MobileGoWirelessDetail.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileGoWirelessDetail.Para.TableName()].Columns.Add(MobileGoWirelessDetail.Para.id); }
            if (x_oTableSet.Fields(MobileGoWirelessDetail.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileGoWirelessDetail.Para.TableName()].Columns.Add(MobileGoWirelessDetail.Para.cdate); }
            if (x_oTableSet.Fields(MobileGoWirelessDetail.Para.assign).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileGoWirelessDetail.Para.TableName()].Columns.Add(MobileGoWirelessDetail.Para.assign); }
            if (x_oTableSet.Fields(MobileGoWirelessDetail.Para.mrt_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileGoWirelessDetail.Para.TableName()].Columns.Add(MobileGoWirelessDetail.Para.mrt_no); }
            if (x_oTableSet.Fields(MobileGoWirelessDetail.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileGoWirelessDetail.Para.TableName()].Columns.Add(MobileGoWirelessDetail.Para.active); }
            if (x_oTableSet.Fields(MobileGoWirelessDetail.Para.assign_staff).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileGoWirelessDetail.Para.TableName()].Columns.Add(MobileGoWirelessDetail.Para.assign_staff); }
            if (x_oTableSet.Fields(MobileGoWirelessDetail.Para.assign_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileGoWirelessDetail.Para.TableName()].Columns.Add(MobileGoWirelessDetail.Para.assign_date); }
            if (x_oTableSet.Fields(MobileGoWirelessDetail.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileGoWirelessDetail.Para.TableName()].Columns.Add(MobileGoWirelessDetail.Para.order_id); }
            if (x_oTableSet.Fields(MobileGoWirelessDetail.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileGoWirelessDetail.Para.TableName()].Columns.Add(MobileGoWirelessDetail.Para.ddate); }
            if (x_oTableSet.Fields(MobileGoWirelessDetail.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileGoWirelessDetail.Para.TableName()].Columns.Add(MobileGoWirelessDetail.Para.did); }
            if (x_oMobileGoWirelessDetail != null)
            {
                global::System.Data.DataRow _oDRow = _oDSet.Tables[MobileGoWirelessDetail.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(MobileGoWirelessDetail.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileGoWirelessDetail.Para.cid] = x_oMobileGoWirelessDetail.GetCid(); }
                if (x_oTableSet.Fields(MobileGoWirelessDetail.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileGoWirelessDetail.Para.id] = x_oMobileGoWirelessDetail.GetId(); }
                if (x_oTableSet.Fields(MobileGoWirelessDetail.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileGoWirelessDetail.Para.cdate] = x_oMobileGoWirelessDetail.GetCdate(); }
                if (x_oTableSet.Fields(MobileGoWirelessDetail.Para.assign).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileGoWirelessDetail.Para.assign] = x_oMobileGoWirelessDetail.GetAssign(); }
                if (x_oTableSet.Fields(MobileGoWirelessDetail.Para.mrt_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileGoWirelessDetail.Para.mrt_no] = x_oMobileGoWirelessDetail.GetMrt_no(); }
                if (x_oTableSet.Fields(MobileGoWirelessDetail.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileGoWirelessDetail.Para.active] = x_oMobileGoWirelessDetail.GetActive(); }
                if (x_oTableSet.Fields(MobileGoWirelessDetail.Para.assign_staff).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileGoWirelessDetail.Para.assign_staff] = x_oMobileGoWirelessDetail.GetAssign_staff(); }
                if (x_oTableSet.Fields(MobileGoWirelessDetail.Para.assign_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileGoWirelessDetail.Para.assign_date] = x_oMobileGoWirelessDetail.GetAssign_date(); }
                if (x_oTableSet.Fields(MobileGoWirelessDetail.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileGoWirelessDetail.Para.order_id] = x_oMobileGoWirelessDetail.GetOrder_id(); }
                if (x_oTableSet.Fields(MobileGoWirelessDetail.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileGoWirelessDetail.Para.ddate] = x_oMobileGoWirelessDetail.GetDdate(); }
                if (x_oTableSet.Fields(MobileGoWirelessDetail.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileGoWirelessDetail.Para.did] = x_oMobileGoWirelessDetail.GetDid(); }
                _oDSet.Tables[MobileGoWirelessDetail.Para.TableName()].Rows.Add(_oDRow);
            }
            if (x_oMergeDSet != null) { _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }


        protected static global::System.Data.DataSet ToEmptyDataSetProcess(MobileGoWirelessDetailInfo x_oTableSet)
        {
            return MobileGoWirelessDetailBal.GetDataSet(null, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return MobileGoWirelessDetailBal.ToEmptyDataSetProcess(MobileGoWirelessDetailInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToEmptyDataSet(MobileGoWirelessDetailInfo x_oTableSet)
        {
            return MobileGoWirelessDetailBal.ToEmptyDataSetProcess(x_oTableSet);
        }


        #endregion ToDataSet

        #region To Table

        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(MobileGoWirelessDetail x_oMobileGoWirelessDetail, MobileGoWirelessDetailInfo x_oTableSet)
        {
            return MobileGoWirelessDetailBal.GetDataSet(null, null, x_oTableSet).Tables[MobileGoWirelessDetail.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(MobileGoWirelessDetail x_oMobileGoWirelessDetail)
        {
            return MobileGoWirelessDetailBal.GetDataSet(x_oMobileGoWirelessDetail, null, MobileGoWirelessDetailInfoDLL.CreateInfoInstanceObject()).Tables[MobileGoWirelessDetail.Para.TableName()];
        }
        #endregion

        #region To Row

        // ******************************
        // *  Handler for Data DataRow
        // ******************************


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            return Row(x_oTable, x_oDB, x_iId, MobileGoWirelessDetailInfoDLL.CreateInfoInstanceObject());
        }


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iId, MobileGoWirelessDetailInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB, x_iId, x_oTableSet);
        }

        public static DataRow Row(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iId, MobileGoWirelessDetailInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileGoWirelessDetailInfoDLL.CreateInfoInstanceObject();
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                string _sQuery = "SELECT   [MobileGoWirelessDetail].[cid] AS MOBILEGOWIRELESSDETAIL_CID,[MobileGoWirelessDetail].[id] AS MOBILEGOWIRELESSDETAIL_ID,[MobileGoWirelessDetail].[cdate] AS MOBILEGOWIRELESSDETAIL_CDATE,[MobileGoWirelessDetail].[assign] AS MOBILEGOWIRELESSDETAIL_ASSIGN,[MobileGoWirelessDetail].[mrt_no] AS MOBILEGOWIRELESSDETAIL_MRT_NO,[MobileGoWirelessDetail].[active] AS MOBILEGOWIRELESSDETAIL_ACTIVE,[MobileGoWirelessDetail].[assign_staff] AS MOBILEGOWIRELESSDETAIL_ASSIGN_STAFF,[MobileGoWirelessDetail].[assign_date] AS MOBILEGOWIRELESSDETAIL_ASSIGN_DATE,[MobileGoWirelessDetail].[order_id] AS MOBILEGOWIRELESSDETAIL_ORDER_ID,[MobileGoWirelessDetail].[ddate] AS MOBILEGOWIRELESSDETAIL_DDATE,[MobileGoWirelessDetail].[did] AS MOBILEGOWIRELESSDETAIL_DID  FROM  [MobileGoWirelessDetail]  WHERE  [MobileGoWirelessDetail].[id] = \'" + x_iId.ToString() + "\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileGoWirelessDetail]", "[" + Configurator.MSSQLTablePrefix + "MobileGoWirelessDetail]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read())
                    {
                        if (x_oTableSet.Fields(MobileGoWirelessDetail.Para.cid).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEGOWIRELESSDETAIL_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileGoWirelessDetail.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileGoWirelessDetail.Para.cid).AliasName].ToString()] = (string)_oData["MOBILEGOWIRELESSDETAIL_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileGoWirelessDetail.Para.cid).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileGoWirelessDetail.Para.id).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEGOWIRELESSDETAIL_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileGoWirelessDetail.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileGoWirelessDetail.Para.id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEGOWIRELESSDETAIL_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileGoWirelessDetail.Para.id).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileGoWirelessDetail.Para.cdate).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEGOWIRELESSDETAIL_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileGoWirelessDetail.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileGoWirelessDetail.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEGOWIRELESSDETAIL_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileGoWirelessDetail.Para.cdate).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileGoWirelessDetail.Para.assign).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEGOWIRELESSDETAIL_ASSIGN"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileGoWirelessDetail.Para.assign).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileGoWirelessDetail.Para.assign).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILEGOWIRELESSDETAIL_ASSIGN"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileGoWirelessDetail.Para.assign).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileGoWirelessDetail.Para.mrt_no).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEGOWIRELESSDETAIL_MRT_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileGoWirelessDetail.Para.mrt_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileGoWirelessDetail.Para.mrt_no).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEGOWIRELESSDETAIL_MRT_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileGoWirelessDetail.Para.mrt_no).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileGoWirelessDetail.Para.active).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEGOWIRELESSDETAIL_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileGoWirelessDetail.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileGoWirelessDetail.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILEGOWIRELESSDETAIL_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileGoWirelessDetail.Para.active).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileGoWirelessDetail.Para.assign_staff).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEGOWIRELESSDETAIL_ASSIGN_STAFF"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileGoWirelessDetail.Para.assign_staff).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileGoWirelessDetail.Para.assign_staff).AliasName].ToString()] = (string)_oData["MOBILEGOWIRELESSDETAIL_ASSIGN_STAFF"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileGoWirelessDetail.Para.assign_staff).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileGoWirelessDetail.Para.assign_date).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEGOWIRELESSDETAIL_ASSIGN_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileGoWirelessDetail.Para.assign_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileGoWirelessDetail.Para.assign_date).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEGOWIRELESSDETAIL_ASSIGN_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileGoWirelessDetail.Para.assign_date).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileGoWirelessDetail.Para.order_id).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEGOWIRELESSDETAIL_ORDER_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileGoWirelessDetail.Para.order_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileGoWirelessDetail.Para.order_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEGOWIRELESSDETAIL_ORDER_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileGoWirelessDetail.Para.order_id).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileGoWirelessDetail.Para.ddate).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEGOWIRELESSDETAIL_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileGoWirelessDetail.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileGoWirelessDetail.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["MOBILEGOWIRELESSDETAIL_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileGoWirelessDetail.Para.ddate).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileGoWirelessDetail.Para.did).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEGOWIRELESSDETAIL_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileGoWirelessDetail.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileGoWirelessDetail.Para.did).AliasName].ToString()] = (string)_oData["MOBILEGOWIRELESSDETAIL_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileGoWirelessDetail.Para.did).AliasName].ToString()] = string.Empty;
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

        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet, MobileGoWirelessDetail x_oMobileGoWirelessDetailRow)
        {
            return SetByDataSetRowProc(x_iROW, MobileGoWirelessDetail.Para.TableName(), x_oDataSet, x_oMobileGoWirelessDetailRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, MobileGoWirelessDetail x_oMobileGoWirelessDetailRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet, x_oMobileGoWirelessDetailRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, MobileGoWirelessDetail x_oMobileGoWirelessDetailRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                MobileGoWirelessDetailInfo _oTableSet = MobileGoWirelessDetailInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileGoWirelessDetail.Para.cid).AliasName))
                    x_oMobileGoWirelessDetailRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileGoWirelessDetail.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileGoWirelessDetail.Para.id).AliasName))
                    x_oMobileGoWirelessDetailRow.id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileGoWirelessDetail.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileGoWirelessDetail.Para.cdate).AliasName))
                    x_oMobileGoWirelessDetailRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileGoWirelessDetail.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileGoWirelessDetail.Para.assign).AliasName))
                    x_oMobileGoWirelessDetailRow.assign = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileGoWirelessDetail.Para.assign).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileGoWirelessDetail.Para.mrt_no).AliasName))
                    x_oMobileGoWirelessDetailRow.mrt_no = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileGoWirelessDetail.Para.mrt_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileGoWirelessDetail.Para.active).AliasName))
                    x_oMobileGoWirelessDetailRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileGoWirelessDetail.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileGoWirelessDetail.Para.assign_staff).AliasName))
                    x_oMobileGoWirelessDetailRow.assign_staff = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileGoWirelessDetail.Para.assign_staff).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileGoWirelessDetail.Para.assign_date).AliasName))
                    x_oMobileGoWirelessDetailRow.assign_date = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileGoWirelessDetail.Para.assign_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileGoWirelessDetail.Para.order_id).AliasName))
                    x_oMobileGoWirelessDetailRow.order_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileGoWirelessDetail.Para.order_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileGoWirelessDetail.Para.ddate).AliasName))
                    x_oMobileGoWirelessDetailRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileGoWirelessDetail.Para.ddate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileGoWirelessDetail.Para.did).AliasName))
                    x_oMobileGoWirelessDetailRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileGoWirelessDetail.Para.did).AliasName];
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
            return MobileGoWirelessDetailRepository.GetCount(x_oDB);
        }
        #endregion


        #region Get

        // ******************************
        // *  Handler for Data Getting
        // ******************************

        public static MobileGoWirelessDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            return MobileGoWirelessDetailRepository.GetArrayObj(x_oDB, x_oColumnName, x_oArrayItemId);
        }

        public static MobileGoWirelessDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder)
        {
            return MobileGoWirelessDetailRepository.GetArrayObj(x_oDB, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        #endregion


        #region List

        // ******************************
        // *  Handler for Data Listing
        // ******************************

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return MobileGoWirelessDetailRepository.GetDataSet(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return MobileGoWirelessDetailRepository.GetSearch(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            return MobileGoWirelessDetailRepository.GetDataSet(x_oDB, x_sFilter);
        }
        #endregion

        #region Insert

        // ******************************
        // *  Handler for Data Inserting
        // ******************************

        public static bool Insert(MSSQLConnect x_oDB, string x_sCid, global::System.Nullable<DateTime> x_dCdate, global::System.Nullable<bool> x_bAssign, global::System.Nullable<int> x_iMrt_no, global::System.Nullable<bool> x_bActive, string x_sAssign_staff, global::System.Nullable<DateTime> x_dAssign_date, global::System.Nullable<int> x_iOrder_id, global::System.Nullable<DateTime> x_dDdate, string x_sDid)
        {
            return MobileGoWirelessDetailRepository.Insert(x_oDB, x_sCid, x_dCdate, x_bAssign, x_iMrt_no, x_bActive, x_sAssign_staff, x_dAssign_date, x_iOrder_id, x_dDdate, x_sDid);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, MobileGoWirelessDetail x_oMobileGoWirelessDetail)
        {
            return MobileGoWirelessDetailRepository.InsertWithOutLastID(x_oDB, x_oMobileGoWirelessDetail);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, string x_sCid, global::System.Nullable<DateTime> x_dCdate, global::System.Nullable<bool> x_bAssign, global::System.Nullable<int> x_iMrt_no, global::System.Nullable<bool> x_bActive, string x_sAssign_staff, global::System.Nullable<DateTime> x_dAssign_date, global::System.Nullable<int> x_iOrder_id, global::System.Nullable<DateTime> x_dDdate, string x_sDid)
        {
            return MobileGoWirelessDetailRepository.InsertReturnLastID_SP(x_oDB, x_sCid, x_dCdate, x_bAssign, x_iMrt_no, x_bActive, x_sAssign_staff, x_dAssign_date, x_iOrder_id, x_dDdate, x_sDid);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileGoWirelessDetail x_oMobileGoWirelessDetail)
        {
            return MobileGoWirelessDetailRepository.InsertReturnLastID_SP(x_oDB, x_oMobileGoWirelessDetail);
        }

        #endregion

        #region Delete

        // ******************************
        // *  Handler for Data Deleting
        // ******************************

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            return MobileGoWirelessDetailRepository.DeleteAll(x_oDB);
        }

        public static bool DeleteFilter(MSSQLConnect x_oDB, string x_sFilter)
        {
            return MobileGoWirelessDetailRepository.DeleteFilter(x_oDB, x_sFilter);
        }

        public static bool Delete(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            return MobileGoWirelessDetailRepository.Delete(x_oDB, x_iId);
        }


        #endregion

        #region Delete Uploaded Files

        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(MobileGoWirelessDetail x_oMobileGoWirelessDetailRow)
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

