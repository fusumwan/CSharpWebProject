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
///-- Create date: <Create Date 2009-10-21>
///-- Description:	<Description,Table :[PublicHousingOffer],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [PublicHousingOffer] Business layer
    /// </summary>

    public abstract class PublicHousingOfferBalBase
    {

        #region Constructor


        // ******************************
        // *  Handler for Class Constructor
        // ******************************

        public PublicHousingOfferBalBase()
        {
        }
        ~PublicHousingOfferBalBase()
        {
            this.Release();
        }
        #endregion


        #region ToDataSet


        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************

        public static global::System.Data.DataSet ToDataSet(PublicHousingOffer x_oPublicHousingOffer)
        {
            return GetDataSet(x_oPublicHousingOffer, null, PublicHousingOfferInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(PublicHousingOffer x_oPublicHousingOffer, global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oPublicHousingOffer, x_oMergeDSet, PublicHousingOfferInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(PublicHousingOffer x_oPublicHousingOffer, PublicHousingOfferInfo x_oTableSet)
        {
            return GetDataSet(x_oPublicHousingOffer, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToDataSet(PublicHousingOffer x_oPublicHousingOffer, global::System.Data.DataSet x_oMergeDSet, PublicHousingOfferInfo x_oTableSet)
        {
            return GetDataSet(x_oPublicHousingOffer, x_oMergeDSet, x_oTableSet);
        }


        protected static global::System.Data.DataSet GetDataSet(PublicHousingOffer x_oPublicHousingOffer, global::System.Data.DataSet x_oMergeDSet, PublicHousingOfferInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = PublicHousingOfferInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(PublicHousingOffer.Para.TableName());
            if (x_oTableSet.Fields(PublicHousingOffer.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[PublicHousingOffer.Para.TableName()].Columns.Add(PublicHousingOffer.Para.id); }
            if (x_oTableSet.Fields(PublicHousingOffer.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[PublicHousingOffer.Para.TableName()].Columns.Add(PublicHousingOffer.Para.cdate); }
            if (x_oTableSet.Fields(PublicHousingOffer.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[PublicHousingOffer.Para.TableName()].Columns.Add(PublicHousingOffer.Para.cid); }
            if (x_oTableSet.Fields(PublicHousingOffer.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[PublicHousingOffer.Para.TableName()].Columns.Add(PublicHousingOffer.Para.active); }
            if (x_oTableSet.Fields(PublicHousingOffer.Para.sdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[PublicHousingOffer.Para.TableName()].Columns.Add(PublicHousingOffer.Para.sdate); }
            if (x_oTableSet.Fields(PublicHousingOffer.Para.s_premium2).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[PublicHousingOffer.Para.TableName()].Columns.Add(PublicHousingOffer.Para.s_premium2); }
            if (x_oTableSet.Fields(PublicHousingOffer.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[PublicHousingOffer.Para.TableName()].Columns.Add(PublicHousingOffer.Para.edate); }
            if (x_oTableSet.Fields(PublicHousingOffer.Para.program).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[PublicHousingOffer.Para.TableName()].Columns.Add(PublicHousingOffer.Para.program); }
            if (x_oTableSet.Fields(PublicHousingOffer.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[PublicHousingOffer.Para.TableName()].Columns.Add(PublicHousingOffer.Para.ddate); }
            if (x_oTableSet.Fields(PublicHousingOffer.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[PublicHousingOffer.Para.TableName()].Columns.Add(PublicHousingOffer.Para.did); }
            if (x_oPublicHousingOffer != null)
            {
                global::System.Data.DataRow _oDRow = _oDSet.Tables[PublicHousingOffer.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(PublicHousingOffer.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[PublicHousingOffer.Para.id] = x_oPublicHousingOffer.GetId(); }
                if (x_oTableSet.Fields(PublicHousingOffer.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[PublicHousingOffer.Para.cdate] = x_oPublicHousingOffer.GetCdate(); }
                if (x_oTableSet.Fields(PublicHousingOffer.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[PublicHousingOffer.Para.cid] = x_oPublicHousingOffer.GetCid(); }
                if (x_oTableSet.Fields(PublicHousingOffer.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[PublicHousingOffer.Para.active] = x_oPublicHousingOffer.GetActive(); }
                if (x_oTableSet.Fields(PublicHousingOffer.Para.sdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[PublicHousingOffer.Para.sdate] = x_oPublicHousingOffer.GetSdate(); }
                if (x_oTableSet.Fields(PublicHousingOffer.Para.s_premium2).IsView || x_oTableSet.GetViewAll()) { _oDRow[PublicHousingOffer.Para.s_premium2] = x_oPublicHousingOffer.GetS_premium2(); }
                if (x_oTableSet.Fields(PublicHousingOffer.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDRow[PublicHousingOffer.Para.edate] = x_oPublicHousingOffer.GetEdate(); }
                if (x_oTableSet.Fields(PublicHousingOffer.Para.program).IsView || x_oTableSet.GetViewAll()) { _oDRow[PublicHousingOffer.Para.program] = x_oPublicHousingOffer.GetProgram(); }
                if (x_oTableSet.Fields(PublicHousingOffer.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[PublicHousingOffer.Para.ddate] = x_oPublicHousingOffer.GetDdate(); }
                if (x_oTableSet.Fields(PublicHousingOffer.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[PublicHousingOffer.Para.did] = x_oPublicHousingOffer.GetDid(); }
                _oDSet.Tables[PublicHousingOffer.Para.TableName()].Rows.Add(_oDRow);
            }
            if (x_oMergeDSet != null) { _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }


        protected static global::System.Data.DataSet ToEmptyDataSetProcess(PublicHousingOfferInfo x_oTableSet)
        {
            return PublicHousingOfferBal.GetDataSet(null, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return PublicHousingOfferBal.ToEmptyDataSetProcess(PublicHousingOfferInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToEmptyDataSet(PublicHousingOfferInfo x_oTableSet)
        {
            return PublicHousingOfferBal.ToEmptyDataSetProcess(x_oTableSet);
        }


        #endregion ToDataSet

        #region To Table

        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(PublicHousingOffer x_oPublicHousingOffer, PublicHousingOfferInfo x_oTableSet)
        {
            return PublicHousingOfferBal.GetDataSet(null, null, x_oTableSet).Tables[PublicHousingOffer.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(PublicHousingOffer x_oPublicHousingOffer)
        {
            return PublicHousingOfferBal.GetDataSet(x_oPublicHousingOffer, null, PublicHousingOfferInfoDLL.CreateInfoInstanceObject()).Tables[PublicHousingOffer.Para.TableName()];
        }
        #endregion

        #region To Row

        // ******************************
        // *  Handler for Data DataRow
        // ******************************


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            return Row(x_oTable, x_oDB, x_iId, PublicHousingOfferInfoDLL.CreateInfoInstanceObject());
        }


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iId, PublicHousingOfferInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB, x_iId, x_oTableSet);
        }

        public static DataRow Row(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iId, PublicHousingOfferInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = PublicHousingOfferInfoDLL.CreateInfoInstanceObject();
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                string _sQuery = "SELECT [PublicHousingOffer].[id] AS PUBLICHOUSINGOFFER_ID,[PublicHousingOffer].[cdate] AS PUBLICHOUSINGOFFER_CDATE,[PublicHousingOffer].[cid] AS PUBLICHOUSINGOFFER_CID,[PublicHousingOffer].[did] AS PUBLICHOUSINGOFFER_DID,[PublicHousingOffer].[sdate] AS PUBLICHOUSINGOFFER_SDATE,[PublicHousingOffer].[active] AS PUBLICHOUSINGOFFER_ACTIVE,[PublicHousingOffer].[edate] AS PUBLICHOUSINGOFFER_EDATE,[PublicHousingOffer].[program] AS PUBLICHOUSINGOFFER_PROGRAM,[PublicHousingOffer].[ddate] AS PUBLICHOUSINGOFFER_DDATE,[PublicHousingOffer].[s_premium2] AS PUBLICHOUSINGOFFER_S_PREMIUM2  FROM  [PublicHousingOffer]  WHERE  [PublicHousingOffer].[id] = \'" + x_iId.ToString() + "\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[PublicHousingOffer]", "[" + Configurator.MSSQLTablePrefix + "PublicHousingOffer]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read())
                    {
                        if (x_oTableSet.Fields(PublicHousingOffer.Para.id).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(PublicHousingOffer.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(PublicHousingOffer.Para.id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["PUBLICHOUSINGOFFER_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(PublicHousingOffer.Para.id).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(PublicHousingOffer.Para.cdate).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(PublicHousingOffer.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(PublicHousingOffer.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["PUBLICHOUSINGOFFER_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(PublicHousingOffer.Para.cdate).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(PublicHousingOffer.Para.cid).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(PublicHousingOffer.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(PublicHousingOffer.Para.cid).AliasName].ToString()] = (string)_oData["PUBLICHOUSINGOFFER_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(PublicHousingOffer.Para.cid).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(PublicHousingOffer.Para.did).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(PublicHousingOffer.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(PublicHousingOffer.Para.did).AliasName].ToString()] = (string)_oData["PUBLICHOUSINGOFFER_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(PublicHousingOffer.Para.did).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(PublicHousingOffer.Para.sdate).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_SDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(PublicHousingOffer.Para.sdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(PublicHousingOffer.Para.sdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["PUBLICHOUSINGOFFER_SDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(PublicHousingOffer.Para.sdate).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(PublicHousingOffer.Para.active).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(PublicHousingOffer.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(PublicHousingOffer.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["PUBLICHOUSINGOFFER_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(PublicHousingOffer.Para.active).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(PublicHousingOffer.Para.edate).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_EDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(PublicHousingOffer.Para.edate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(PublicHousingOffer.Para.edate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["PUBLICHOUSINGOFFER_EDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(PublicHousingOffer.Para.edate).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(PublicHousingOffer.Para.program).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_PROGRAM"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(PublicHousingOffer.Para.program).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(PublicHousingOffer.Para.program).AliasName].ToString()] = (string)_oData["PUBLICHOUSINGOFFER_PROGRAM"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(PublicHousingOffer.Para.program).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(PublicHousingOffer.Para.ddate).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(PublicHousingOffer.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(PublicHousingOffer.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["PUBLICHOUSINGOFFER_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(PublicHousingOffer.Para.ddate).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(PublicHousingOffer.Para.s_premium2).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_S_PREMIUM2"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(PublicHousingOffer.Para.s_premium2).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(PublicHousingOffer.Para.s_premium2).AliasName].ToString()] = (string)_oData["PUBLICHOUSINGOFFER_S_PREMIUM2"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(PublicHousingOffer.Para.s_premium2).AliasName].ToString()] = string.Empty;
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

        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet, PublicHousingOffer x_oPublicHousingOfferRow)
        {
            return SetByDataSetRowProc(x_iROW, PublicHousingOffer.Para.TableName(), x_oDataSet, x_oPublicHousingOfferRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, PublicHousingOffer x_oPublicHousingOfferRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet, x_oPublicHousingOfferRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, PublicHousingOffer x_oPublicHousingOfferRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                PublicHousingOfferInfo _oTableSet = PublicHousingOfferInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(PublicHousingOffer.Para.id).AliasName))
                    x_oPublicHousingOfferRow.id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(PublicHousingOffer.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(PublicHousingOffer.Para.cdate).AliasName))
                    x_oPublicHousingOfferRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(PublicHousingOffer.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(PublicHousingOffer.Para.cid).AliasName))
                    x_oPublicHousingOfferRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(PublicHousingOffer.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(PublicHousingOffer.Para.active).AliasName))
                    x_oPublicHousingOfferRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(PublicHousingOffer.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(PublicHousingOffer.Para.sdate).AliasName))
                    x_oPublicHousingOfferRow.sdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(PublicHousingOffer.Para.sdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(PublicHousingOffer.Para.s_premium2).AliasName))
                    x_oPublicHousingOfferRow.s_premium2 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(PublicHousingOffer.Para.s_premium2).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(PublicHousingOffer.Para.edate).AliasName))
                    x_oPublicHousingOfferRow.edate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(PublicHousingOffer.Para.edate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(PublicHousingOffer.Para.program).AliasName))
                    x_oPublicHousingOfferRow.program = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(PublicHousingOffer.Para.program).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(PublicHousingOffer.Para.ddate).AliasName))
                    x_oPublicHousingOfferRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(PublicHousingOffer.Para.ddate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(PublicHousingOffer.Para.did).AliasName))
                    x_oPublicHousingOfferRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(PublicHousingOffer.Para.did).AliasName];
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
            return PublicHousingOfferRepository.GetCount(x_oDB);
        }
        #endregion


        #region Get

        // ******************************
        // *  Handler for Data Getting
        // ******************************

        public static PublicHousingOfferEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            return PublicHousingOfferRepository.GetArrayObj(x_oDB, x_oColumnName, x_oArrayItemId);
        }

        public static PublicHousingOfferEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder)
        {
            return PublicHousingOfferRepository.GetArrayObj(x_oDB, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        #endregion


        #region List

        // ******************************
        // *  Handler for Data Listing
        // ******************************

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return PublicHousingOfferRepository.GetDataSet(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return PublicHousingOfferRepository.GetSearch(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            return PublicHousingOfferRepository.GetDataSet(x_oDB, x_sFilter);
        }
        #endregion

        #region Insert

        // ******************************
        // *  Handler for Data Inserting
        // ******************************

        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate, string x_sCid, global::System.Nullable<bool> x_bActive, global::System.Nullable<DateTime> x_dSdate, string x_sS_premium2, global::System.Nullable<DateTime> x_dEdate, string x_sProgram, global::System.Nullable<DateTime> x_dDdate, string x_sDid)
        {
            return PublicHousingOfferRepository.Insert(x_oDB, x_dCdate, x_sCid, x_bActive, x_dSdate, x_sS_premium2, x_dEdate, x_sProgram, x_dDdate, x_sDid);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, PublicHousingOffer x_oPublicHousingOffer)
        {
            return PublicHousingOfferRepository.InsertWithOutLastID(x_oDB, x_oPublicHousingOffer);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate, string x_sCid, global::System.Nullable<bool> x_bActive, global::System.Nullable<DateTime> x_dSdate, string x_sS_premium2, global::System.Nullable<DateTime> x_dEdate, string x_sProgram, global::System.Nullable<DateTime> x_dDdate, string x_sDid)
        {
            return PublicHousingOfferRepository.InsertReturnLastID_SP(x_oDB, x_dCdate, x_sCid, x_bActive, x_dSdate, x_sS_premium2, x_dEdate, x_sProgram, x_dDdate, x_sDid);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, PublicHousingOffer x_oPublicHousingOffer)
        {
            return PublicHousingOfferRepository.InsertReturnLastID_SP(x_oDB, x_oPublicHousingOffer);
        }

        #endregion

        #region Delete

        // ******************************
        // *  Handler for Data Deleting
        // ******************************

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            return PublicHousingOfferRepository.DeleteAll(x_oDB);
        }

        public static bool DeleteFilter(MSSQLConnect x_oDB, string x_sFilter)
        {
            return PublicHousingOfferRepository.DeleteFilter(x_oDB, x_sFilter);
        }

        public static bool Delete(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            return PublicHousingOfferRepository.Delete(x_oDB, x_iId);
        }


        #endregion

        #region Delete Uploaded Files

        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(PublicHousingOffer x_oPublicHousingOfferRow)
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

