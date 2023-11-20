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
///-- Create date: <Create Date 2009-10-05>
///-- Description:	<Description,Table :[SpecialPremium],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [SpecialPremium] Business layer
    /// </summary>

    public abstract class SpecialPremiumBalBase
    {

        #region Constructor


        // ******************************
        // *  Handler for Class Constructor
        // ******************************

        public SpecialPremiumBalBase()
        {
        }
        ~SpecialPremiumBalBase()
        {
            this.Release();
        }
        #endregion


        #region ToDataSet


        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************

        public static global::System.Data.DataSet ToDataSet(SpecialPremium x_oSpecialPremium)
        {
            return GetDataSet(x_oSpecialPremium, null, SpecialPremiumInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(SpecialPremium x_oSpecialPremium, global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oSpecialPremium, x_oMergeDSet, SpecialPremiumInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(SpecialPremium x_oSpecialPremium, SpecialPremiumInfo x_oTableSet)
        {
            return GetDataSet(x_oSpecialPremium, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToDataSet(SpecialPremium x_oSpecialPremium, global::System.Data.DataSet x_oMergeDSet, SpecialPremiumInfo x_oTableSet)
        {
            return GetDataSet(x_oSpecialPremium, x_oMergeDSet, x_oTableSet);
        }


        protected static global::System.Data.DataSet GetDataSet(SpecialPremium x_oSpecialPremium, global::System.Data.DataSet x_oMergeDSet, SpecialPremiumInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = SpecialPremiumInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(SpecialPremium.Para.TableName());
            if (x_oTableSet.Fields(SpecialPremium.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[SpecialPremium.Para.TableName()].Columns.Add(SpecialPremium.Para.active); }
            if (x_oTableSet.Fields(SpecialPremium.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[SpecialPremium.Para.TableName()].Columns.Add(SpecialPremium.Para.cdate); }
            if (x_oTableSet.Fields(SpecialPremium.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[SpecialPremium.Para.TableName()].Columns.Add(SpecialPremium.Para.cid); }
            if (x_oTableSet.Fields(SpecialPremium.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[SpecialPremium.Para.TableName()].Columns.Add(SpecialPremium.Para.did); }
            if (x_oTableSet.Fields(SpecialPremium.Para.con_per).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[SpecialPremium.Para.TableName()].Columns.Add(SpecialPremium.Para.con_per); }
            if (x_oTableSet.Fields(SpecialPremium.Para.rate_plan).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[SpecialPremium.Para.TableName()].Columns.Add(SpecialPremium.Para.rate_plan); }
            if (x_oTableSet.Fields(SpecialPremium.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[SpecialPremium.Para.TableName()].Columns.Add(SpecialPremium.Para.ddate); }
            if (x_oTableSet.Fields(SpecialPremium.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[SpecialPremium.Para.TableName()].Columns.Add(SpecialPremium.Para.mid); }
            if (x_oTableSet.Fields(SpecialPremium.Para.s_premium).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[SpecialPremium.Para.TableName()].Columns.Add(SpecialPremium.Para.s_premium); }
            if (x_oSpecialPremium != null)
            {
                global::System.Data.DataRow _oDRow = _oDSet.Tables[SpecialPremium.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(SpecialPremium.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[SpecialPremium.Para.active] = x_oSpecialPremium.GetActive(); }
                if (x_oTableSet.Fields(SpecialPremium.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[SpecialPremium.Para.cdate] = x_oSpecialPremium.GetCdate(); }
                if (x_oTableSet.Fields(SpecialPremium.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[SpecialPremium.Para.cid] = x_oSpecialPremium.GetCid(); }
                if (x_oTableSet.Fields(SpecialPremium.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[SpecialPremium.Para.did] = x_oSpecialPremium.GetDid(); }
                if (x_oTableSet.Fields(SpecialPremium.Para.con_per).IsView || x_oTableSet.GetViewAll()) { _oDRow[SpecialPremium.Para.con_per] = x_oSpecialPremium.GetCon_per(); }
                if (x_oTableSet.Fields(SpecialPremium.Para.rate_plan).IsView || x_oTableSet.GetViewAll()) { _oDRow[SpecialPremium.Para.rate_plan] = x_oSpecialPremium.GetRate_plan(); }
                if (x_oTableSet.Fields(SpecialPremium.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[SpecialPremium.Para.ddate] = x_oSpecialPremium.GetDdate(); }
                if (x_oTableSet.Fields(SpecialPremium.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDRow[SpecialPremium.Para.mid] = x_oSpecialPremium.GetMid(); }
                if (x_oTableSet.Fields(SpecialPremium.Para.s_premium).IsView || x_oTableSet.GetViewAll()) { _oDRow[SpecialPremium.Para.s_premium] = x_oSpecialPremium.GetS_premium(); }
                _oDSet.Tables[SpecialPremium.Para.TableName()].Rows.Add(_oDRow);
            }
            if (x_oMergeDSet != null) { _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }


        protected static global::System.Data.DataSet ToEmptyDataSetProcess(SpecialPremiumInfo x_oTableSet)
        {
            return SpecialPremiumBal.GetDataSet(null, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return SpecialPremiumBal.ToEmptyDataSetProcess(SpecialPremiumInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToEmptyDataSet(SpecialPremiumInfo x_oTableSet)
        {
            return SpecialPremiumBal.ToEmptyDataSetProcess(x_oTableSet);
        }


        #endregion ToDataSet

        #region To Table

        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(SpecialPremium x_oSpecialPremium, SpecialPremiumInfo x_oTableSet)
        {
            return SpecialPremiumBal.GetDataSet(null, null, x_oTableSet).Tables[SpecialPremium.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(SpecialPremium x_oSpecialPremium)
        {
            return SpecialPremiumBal.GetDataSet(x_oSpecialPremium, null, SpecialPremiumInfoDLL.CreateInfoInstanceObject()).Tables[SpecialPremium.Para.TableName()];
        }
        #endregion

        #region To Row

        // ******************************
        // *  Handler for Data DataRow
        // ******************************


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            return Row(x_oTable, x_oDB, x_iMid, SpecialPremiumInfoDLL.CreateInfoInstanceObject());
        }


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid, SpecialPremiumInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB, x_iMid, x_oTableSet);
        }

        public static DataRow Row(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid, SpecialPremiumInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = SpecialPremiumInfoDLL.CreateInfoInstanceObject();
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                string _sQuery = "SELECT [SpecialPremium].[rate_plan] AS SPECIALPREMIUM_RATE_PLAN,[SpecialPremium].[cdate] AS SPECIALPREMIUM_CDATE,[SpecialPremium].[cid] AS SPECIALPREMIUM_CID,[SpecialPremium].[active] AS SPECIALPREMIUM_ACTIVE,[SpecialPremium].[ddate] AS SPECIALPREMIUM_DDATE,[SpecialPremium].[did] AS SPECIALPREMIUM_DID,[SpecialPremium].[con_per] AS SPECIALPREMIUM_CON_PER,[SpecialPremium].[mid] AS SPECIALPREMIUM_MID,[SpecialPremium].[s_premium] AS SPECIALPREMIUM_S_PREMIUM  FROM  [SpecialPremium]  WHERE  [SpecialPremium].[mid] = \'" + x_iMid.ToString() + "\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[SpecialPremium]", "[" + Configurator.MSSQLTablePrefix + "SpecialPremium]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read())
                    {
                        if (x_oTableSet.Fields(SpecialPremium.Para.rate_plan).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_RATE_PLAN"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(SpecialPremium.Para.rate_plan).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialPremium.Para.rate_plan).AliasName].ToString()] = (string)_oData["SPECIALPREMIUM_RATE_PLAN"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialPremium.Para.rate_plan).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(SpecialPremium.Para.cdate).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(SpecialPremium.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialPremium.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["SPECIALPREMIUM_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialPremium.Para.cdate).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(SpecialPremium.Para.cid).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(SpecialPremium.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialPremium.Para.cid).AliasName].ToString()] = (string)_oData["SPECIALPREMIUM_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialPremium.Para.cid).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(SpecialPremium.Para.active).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(SpecialPremium.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialPremium.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["SPECIALPREMIUM_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialPremium.Para.active).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(SpecialPremium.Para.ddate).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(SpecialPremium.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialPremium.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["SPECIALPREMIUM_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialPremium.Para.ddate).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(SpecialPremium.Para.did).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(SpecialPremium.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialPremium.Para.did).AliasName].ToString()] = (string)_oData["SPECIALPREMIUM_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialPremium.Para.did).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(SpecialPremium.Para.con_per).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_CON_PER"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(SpecialPremium.Para.con_per).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialPremium.Para.con_per).AliasName].ToString()] = (string)_oData["SPECIALPREMIUM_CON_PER"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialPremium.Para.con_per).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(SpecialPremium.Para.mid).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_MID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(SpecialPremium.Para.mid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialPremium.Para.mid).AliasName].ToString()] = (global::System.Nullable<int>)_oData["SPECIALPREMIUM_MID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialPremium.Para.mid).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(SpecialPremium.Para.s_premium).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["SPECIALPREMIUM_S_PREMIUM"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(SpecialPremium.Para.s_premium).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialPremium.Para.s_premium).AliasName].ToString()] = (string)_oData["SPECIALPREMIUM_S_PREMIUM"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SpecialPremium.Para.s_premium).AliasName].ToString()] = string.Empty;
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

        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet, SpecialPremium x_oSpecialPremiumRow)
        {
            return SetByDataSetRowProc(x_iROW, SpecialPremium.Para.TableName(), x_oDataSet, x_oSpecialPremiumRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, SpecialPremium x_oSpecialPremiumRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet, x_oSpecialPremiumRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, SpecialPremium x_oSpecialPremiumRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                SpecialPremiumInfo _oTableSet = SpecialPremiumInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(SpecialPremium.Para.active).AliasName))
                    x_oSpecialPremiumRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(SpecialPremium.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(SpecialPremium.Para.cdate).AliasName))
                    x_oSpecialPremiumRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(SpecialPremium.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(SpecialPremium.Para.cid).AliasName))
                    x_oSpecialPremiumRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(SpecialPremium.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(SpecialPremium.Para.did).AliasName))
                    x_oSpecialPremiumRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(SpecialPremium.Para.did).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(SpecialPremium.Para.con_per).AliasName))
                    x_oSpecialPremiumRow.con_per = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(SpecialPremium.Para.con_per).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(SpecialPremium.Para.rate_plan).AliasName))
                    x_oSpecialPremiumRow.rate_plan = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(SpecialPremium.Para.rate_plan).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(SpecialPremium.Para.ddate).AliasName))
                    x_oSpecialPremiumRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(SpecialPremium.Para.ddate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(SpecialPremium.Para.mid).AliasName))
                    x_oSpecialPremiumRow.mid = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(SpecialPremium.Para.mid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(SpecialPremium.Para.s_premium).AliasName))
                    x_oSpecialPremiumRow.s_premium = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(SpecialPremium.Para.s_premium).AliasName];
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
            return SpecialPremiumRepository.GetCount(x_oDB);
        }
        #endregion


        #region Get

        // ******************************
        // *  Handler for Data Getting
        // ******************************

        public static SpecialPremiumEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            return SpecialPremiumRepository.GetArrayObj(x_oDB, x_oColumnName, x_oArrayItemId);
        }

        public static SpecialPremiumEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder)
        {
            return SpecialPremiumRepository.GetArrayObj(x_oDB, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        #endregion


        #region List

        // ******************************
        // *  Handler for Data Listing
        // ******************************

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return SpecialPremiumRepository.GetDataSet(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return SpecialPremiumRepository.GetSearch(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            return SpecialPremiumRepository.GetDataSet(x_oDB, x_sFilter);
        }
        #endregion

        #region Insert

        // ******************************
        // *  Handler for Data Inserting
        // ******************************

        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bActive, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sDid, string x_sCon_per, string x_sRate_plan, global::System.Nullable<DateTime> x_dDdate, string x_sS_premium)
        {
            return SpecialPremiumRepository.Insert(x_oDB, x_bActive, x_dCdate, x_sCid, x_sDid, x_sCon_per, x_sRate_plan, x_dDdate, x_sS_premium);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, SpecialPremium x_oSpecialPremium)
        {
            return SpecialPremiumRepository.InsertWithOutLastID(x_oDB, x_oSpecialPremium);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bActive, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sDid, string x_sCon_per, string x_sRate_plan, global::System.Nullable<DateTime> x_dDdate, string x_sS_premium)
        {
            return SpecialPremiumRepository.InsertReturnLastID_SP(x_oDB, x_bActive, x_dCdate, x_sCid, x_sDid, x_sCon_per, x_sRate_plan, x_dDdate, x_sS_premium);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, SpecialPremium x_oSpecialPremium)
        {
            return SpecialPremiumRepository.InsertReturnLastID_SP(x_oDB, x_oSpecialPremium);
        }

        #endregion

        #region Delete

        // ******************************
        // *  Handler for Data Deleting
        // ******************************

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            return SpecialPremiumRepository.DeleteAll(x_oDB);
        }

        public static bool DeleteFilter(MSSQLConnect x_oDB, string x_sFilter)
        {
            return SpecialPremiumRepository.DeleteFilter(x_oDB, x_sFilter);
        }

        public static bool Delete(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            return SpecialPremiumRepository.Delete(x_oDB, x_iMid);
        }


        #endregion

        #region Delete Uploaded Files

        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(SpecialPremium x_oSpecialPremiumRow)
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

