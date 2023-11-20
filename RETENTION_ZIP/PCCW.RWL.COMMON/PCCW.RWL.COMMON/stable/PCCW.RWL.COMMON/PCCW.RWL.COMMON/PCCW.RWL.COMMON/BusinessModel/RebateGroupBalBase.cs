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
///-- Description:	<Description,Table :[RebateGroup],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [RebateGroup] Business layer
    /// </summary>

    public abstract class RebateGroupBalBase
    {

        #region Constructor


        // ******************************
        // *  Handler for Class Constructor
        // ******************************

        public RebateGroupBalBase()
        {
        }
        ~RebateGroupBalBase()
        {
            this.Release();
        }
        #endregion


        #region ToDataSet


        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************

        public static global::System.Data.DataSet ToDataSet(RebateGroup x_oRebateGroup)
        {
            return GetDataSet(x_oRebateGroup, null, RebateGroupInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(RebateGroup x_oRebateGroup, global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oRebateGroup, x_oMergeDSet, RebateGroupInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(RebateGroup x_oRebateGroup, RebateGroupInfo x_oTableSet)
        {
            return GetDataSet(x_oRebateGroup, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToDataSet(RebateGroup x_oRebateGroup, global::System.Data.DataSet x_oMergeDSet, RebateGroupInfo x_oTableSet)
        {
            return GetDataSet(x_oRebateGroup, x_oMergeDSet, x_oTableSet);
        }


        protected static global::System.Data.DataSet GetDataSet(RebateGroup x_oRebateGroup, global::System.Data.DataSet x_oMergeDSet, RebateGroupInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = RebateGroupInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(RebateGroup.Para.TableName());
            if (x_oTableSet.Fields(RebateGroup.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[RebateGroup.Para.TableName()].Columns.Add(RebateGroup.Para.active); }
            if (x_oTableSet.Fields(RebateGroup.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[RebateGroup.Para.TableName()].Columns.Add(RebateGroup.Para.cdate); }
            if (x_oTableSet.Fields(RebateGroup.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[RebateGroup.Para.TableName()].Columns.Add(RebateGroup.Para.cid); }
            if (x_oTableSet.Fields(RebateGroup.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[RebateGroup.Para.TableName()].Columns.Add(RebateGroup.Para.did); }
            if (x_oTableSet.Fields(RebateGroup.Para.gp).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[RebateGroup.Para.TableName()].Columns.Add(RebateGroup.Para.gp); }
            if (x_oTableSet.Fields(RebateGroup.Para.program).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[RebateGroup.Para.TableName()].Columns.Add(RebateGroup.Para.program); }
            if (x_oTableSet.Fields(RebateGroup.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[RebateGroup.Para.TableName()].Columns.Add(RebateGroup.Para.ddate); }
            if (x_oTableSet.Fields(RebateGroup.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[RebateGroup.Para.TableName()].Columns.Add(RebateGroup.Para.mid); }
            if (x_oRebateGroup != null)
            {
                global::System.Data.DataRow _oDRow = _oDSet.Tables[RebateGroup.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(RebateGroup.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[RebateGroup.Para.active] = x_oRebateGroup.GetActive(); }
                if (x_oTableSet.Fields(RebateGroup.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[RebateGroup.Para.cdate] = x_oRebateGroup.GetCdate(); }
                if (x_oTableSet.Fields(RebateGroup.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[RebateGroup.Para.cid] = x_oRebateGroup.GetCid(); }
                if (x_oTableSet.Fields(RebateGroup.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[RebateGroup.Para.did] = x_oRebateGroup.GetDid(); }
                if (x_oTableSet.Fields(RebateGroup.Para.gp).IsView || x_oTableSet.GetViewAll()) { _oDRow[RebateGroup.Para.gp] = x_oRebateGroup.GetGp(); }
                if (x_oTableSet.Fields(RebateGroup.Para.program).IsView || x_oTableSet.GetViewAll()) { _oDRow[RebateGroup.Para.program] = x_oRebateGroup.GetProgram(); }
                if (x_oTableSet.Fields(RebateGroup.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[RebateGroup.Para.ddate] = x_oRebateGroup.GetDdate(); }
                if (x_oTableSet.Fields(RebateGroup.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDRow[RebateGroup.Para.mid] = x_oRebateGroup.GetMid(); }
                _oDSet.Tables[RebateGroup.Para.TableName()].Rows.Add(_oDRow);
            }
            if (x_oMergeDSet != null) { _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }


        protected static global::System.Data.DataSet ToEmptyDataSetProcess(RebateGroupInfo x_oTableSet)
        {
            return RebateGroupBal.GetDataSet(null, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return RebateGroupBal.ToEmptyDataSetProcess(RebateGroupInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToEmptyDataSet(RebateGroupInfo x_oTableSet)
        {
            return RebateGroupBal.ToEmptyDataSetProcess(x_oTableSet);
        }


        #endregion ToDataSet

        #region To Table

        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(RebateGroup x_oRebateGroup, RebateGroupInfo x_oTableSet)
        {
            return RebateGroupBal.GetDataSet(null, null, x_oTableSet).Tables[RebateGroup.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(RebateGroup x_oRebateGroup)
        {
            return RebateGroupBal.GetDataSet(x_oRebateGroup, null, RebateGroupInfoDLL.CreateInfoInstanceObject()).Tables[RebateGroup.Para.TableName()];
        }
        #endregion

        #region To Row

        // ******************************
        // *  Handler for Data DataRow
        // ******************************


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            return Row(x_oTable, x_oDB, x_iMid, RebateGroupInfoDLL.CreateInfoInstanceObject());
        }


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid, RebateGroupInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB, x_iMid, x_oTableSet);
        }

        public static DataRow Row(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid, RebateGroupInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = RebateGroupInfoDLL.CreateInfoInstanceObject();
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                string _sQuery = "SELECT [RebateGroup].[active] AS REBATEGROUP_ACTIVE,[RebateGroup].[cdate] AS REBATEGROUP_CDATE,[RebateGroup].[cid] AS REBATEGROUP_CID,[RebateGroup].[did] AS REBATEGROUP_DID,[RebateGroup].[program] AS REBATEGROUP_PROGRAM,[RebateGroup].[ddate] AS REBATEGROUP_DDATE,[RebateGroup].[gp] AS REBATEGROUP_GP,[RebateGroup].[mid] AS REBATEGROUP_MID  FROM  [RebateGroup]  WHERE  [RebateGroup].[mid] = \'" + x_iMid.ToString() + "\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[RebateGroup]", "[" + Configurator.MSSQLTablePrefix + "RebateGroup]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read())
                    {
                        if (x_oTableSet.Fields(RebateGroup.Para.active).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["REBATEGROUP_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(RebateGroup.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(RebateGroup.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["REBATEGROUP_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(RebateGroup.Para.active).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(RebateGroup.Para.cdate).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["REBATEGROUP_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(RebateGroup.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(RebateGroup.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["REBATEGROUP_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(RebateGroup.Para.cdate).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(RebateGroup.Para.cid).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["REBATEGROUP_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(RebateGroup.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(RebateGroup.Para.cid).AliasName].ToString()] = (string)_oData["REBATEGROUP_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(RebateGroup.Para.cid).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(RebateGroup.Para.did).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["REBATEGROUP_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(RebateGroup.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(RebateGroup.Para.did).AliasName].ToString()] = (string)_oData["REBATEGROUP_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(RebateGroup.Para.did).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(RebateGroup.Para.program).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["REBATEGROUP_PROGRAM"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(RebateGroup.Para.program).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(RebateGroup.Para.program).AliasName].ToString()] = (string)_oData["REBATEGROUP_PROGRAM"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(RebateGroup.Para.program).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(RebateGroup.Para.ddate).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["REBATEGROUP_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(RebateGroup.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(RebateGroup.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["REBATEGROUP_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(RebateGroup.Para.ddate).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(RebateGroup.Para.gp).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["REBATEGROUP_GP"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(RebateGroup.Para.gp).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(RebateGroup.Para.gp).AliasName].ToString()] = (string)_oData["REBATEGROUP_GP"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(RebateGroup.Para.gp).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(RebateGroup.Para.mid).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["REBATEGROUP_MID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(RebateGroup.Para.mid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(RebateGroup.Para.mid).AliasName].ToString()] = (global::System.Nullable<int>)_oData["REBATEGROUP_MID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(RebateGroup.Para.mid).AliasName].ToString()] = string.Empty;
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

        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet, RebateGroup x_oRebateGroupRow)
        {
            return SetByDataSetRowProc(x_iROW, RebateGroup.Para.TableName(), x_oDataSet, x_oRebateGroupRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, RebateGroup x_oRebateGroupRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet, x_oRebateGroupRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, RebateGroup x_oRebateGroupRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                RebateGroupInfo _oTableSet = RebateGroupInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(RebateGroup.Para.active).AliasName))
                    x_oRebateGroupRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(RebateGroup.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(RebateGroup.Para.cdate).AliasName))
                    x_oRebateGroupRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(RebateGroup.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(RebateGroup.Para.cid).AliasName))
                    x_oRebateGroupRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(RebateGroup.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(RebateGroup.Para.did).AliasName))
                    x_oRebateGroupRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(RebateGroup.Para.did).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(RebateGroup.Para.gp).AliasName))
                    x_oRebateGroupRow.gp = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(RebateGroup.Para.gp).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(RebateGroup.Para.program).AliasName))
                    x_oRebateGroupRow.program = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(RebateGroup.Para.program).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(RebateGroup.Para.ddate).AliasName))
                    x_oRebateGroupRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(RebateGroup.Para.ddate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(RebateGroup.Para.mid).AliasName))
                    x_oRebateGroupRow.mid = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(RebateGroup.Para.mid).AliasName];
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
            return RebateGroupRepository.GetCount(x_oDB);
        }
        #endregion


        #region Get

        // ******************************
        // *  Handler for Data Getting
        // ******************************

        public static RebateGroupEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            return RebateGroupRepository.GetArrayObj(x_oDB, x_oColumnName, x_oArrayItemId);
        }

        public static RebateGroupEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder)
        {
            return RebateGroupRepository.GetArrayObj(x_oDB, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        #endregion


        #region List

        // ******************************
        // *  Handler for Data Listing
        // ******************************

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return RebateGroupRepository.GetDataSet(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return RebateGroupRepository.GetSearch(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            return RebateGroupRepository.GetDataSet(x_oDB, x_sFilter);
        }
        #endregion

        #region Insert

        // ******************************
        // *  Handler for Data Inserting
        // ******************************

        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bActive, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sDid, string x_sGp, string x_sProgram, global::System.Nullable<DateTime> x_dDdate)
        {
            return RebateGroupRepository.Insert(x_oDB, x_bActive, x_dCdate, x_sCid, x_sDid, x_sGp, x_sProgram, x_dDdate);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, RebateGroup x_oRebateGroup)
        {
            return RebateGroupRepository.InsertWithOutLastID(x_oDB, x_oRebateGroup);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bActive, global::System.Nullable<DateTime> x_dCdate, string x_sCid, string x_sDid, string x_sGp, string x_sProgram, global::System.Nullable<DateTime> x_dDdate)
        {
            return RebateGroupRepository.InsertReturnLastID_SP(x_oDB, x_bActive, x_dCdate, x_sCid, x_sDid, x_sGp, x_sProgram, x_dDdate);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, RebateGroup x_oRebateGroup)
        {
            return RebateGroupRepository.InsertReturnLastID_SP(x_oDB, x_oRebateGroup);
        }

        #endregion

        #region Delete

        // ******************************
        // *  Handler for Data Deleting
        // ******************************

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            return RebateGroupRepository.DeleteAll(x_oDB);
        }

        public static bool DeleteFilter(MSSQLConnect x_oDB, string x_sFilter)
        {
            return RebateGroupRepository.DeleteFilter(x_oDB, x_sFilter);
        }

        public static bool Delete(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            return RebateGroupRepository.Delete(x_oDB, x_iMid);
        }


        #endregion

        #region Delete Uploaded Files

        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(RebateGroup x_oRebateGroupRow)
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

