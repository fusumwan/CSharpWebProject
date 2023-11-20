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
///-- Description:	<Description,Table :[SuspendEventDetail],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [SuspendEventDetail] Business layer
    /// </summary>

    public abstract class SuspendEventDetailBalBase
    {

        #region Constructor


        // ******************************
        // *  Handler for Class Constructor
        // ******************************

        public SuspendEventDetailBalBase()
        {
        }
        ~SuspendEventDetailBalBase()
        {
            this.Release();
        }
        #endregion


        #region ToDataSet


        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************

        public static global::System.Data.DataSet ToDataSet(SuspendEventDetail x_oSuspendEventDetail)
        {
            return GetDataSet(x_oSuspendEventDetail, null, SuspendEventDetailInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(SuspendEventDetail x_oSuspendEventDetail, global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oSuspendEventDetail, x_oMergeDSet, SuspendEventDetailInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(SuspendEventDetail x_oSuspendEventDetail, SuspendEventDetailInfo x_oTableSet)
        {
            return GetDataSet(x_oSuspendEventDetail, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToDataSet(SuspendEventDetail x_oSuspendEventDetail, global::System.Data.DataSet x_oMergeDSet, SuspendEventDetailInfo x_oTableSet)
        {
            return GetDataSet(x_oSuspendEventDetail, x_oMergeDSet, x_oTableSet);
        }


        protected static global::System.Data.DataSet GetDataSet(SuspendEventDetail x_oSuspendEventDetail, global::System.Data.DataSet x_oMergeDSet, SuspendEventDetailInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = SuspendEventDetailInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(SuspendEventDetail.Para.TableName());
            if (x_oTableSet.Fields(SuspendEventDetail.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[SuspendEventDetail.Para.TableName()].Columns.Add(SuspendEventDetail.Para.mid); }
            if (x_oTableSet.Fields(SuspendEventDetail.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[SuspendEventDetail.Para.TableName()].Columns.Add(SuspendEventDetail.Para.active); }
            if (x_oTableSet.Fields(SuspendEventDetail.Para.reasons).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[SuspendEventDetail.Para.TableName()].Columns.Add(SuspendEventDetail.Para.reasons); }
            if (x_oSuspendEventDetail != null)
            {
                global::System.Data.DataRow _oDRow = _oDSet.Tables[SuspendEventDetail.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(SuspendEventDetail.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDRow[SuspendEventDetail.Para.mid] = x_oSuspendEventDetail.GetMid(); }
                if (x_oTableSet.Fields(SuspendEventDetail.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[SuspendEventDetail.Para.active] = x_oSuspendEventDetail.GetActive(); }
                if (x_oTableSet.Fields(SuspendEventDetail.Para.reasons).IsView || x_oTableSet.GetViewAll()) { _oDRow[SuspendEventDetail.Para.reasons] = x_oSuspendEventDetail.GetReasons(); }
                _oDSet.Tables[SuspendEventDetail.Para.TableName()].Rows.Add(_oDRow);
            }
            if (x_oMergeDSet != null) { _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }


        protected static global::System.Data.DataSet ToEmptyDataSetProcess(SuspendEventDetailInfo x_oTableSet)
        {
            return SuspendEventDetailBal.GetDataSet(null, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return SuspendEventDetailBal.ToEmptyDataSetProcess(SuspendEventDetailInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToEmptyDataSet(SuspendEventDetailInfo x_oTableSet)
        {
            return SuspendEventDetailBal.ToEmptyDataSetProcess(x_oTableSet);
        }


        #endregion ToDataSet

        #region To Table

        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(SuspendEventDetail x_oSuspendEventDetail, SuspendEventDetailInfo x_oTableSet)
        {
            return SuspendEventDetailBal.GetDataSet(null, null, x_oTableSet).Tables[SuspendEventDetail.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(SuspendEventDetail x_oSuspendEventDetail)
        {
            return SuspendEventDetailBal.GetDataSet(x_oSuspendEventDetail, null, SuspendEventDetailInfoDLL.CreateInfoInstanceObject()).Tables[SuspendEventDetail.Para.TableName()];
        }
        #endregion

        #region To Row

        // ******************************
        // *  Handler for Data DataRow
        // ******************************


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            return Row(x_oTable, x_oDB, x_iMid, SuspendEventDetailInfoDLL.CreateInfoInstanceObject());
        }


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid, SuspendEventDetailInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB, x_iMid, x_oTableSet);
        }

        public static DataRow Row(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid, SuspendEventDetailInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = SuspendEventDetailInfoDLL.CreateInfoInstanceObject();
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                string _sQuery = "SELECT [SuspendEventDetail].[active] AS SUSPENDEVENTDETAIL_ACTIVE,[SuspendEventDetail].[mid] AS SUSPENDEVENTDETAIL_MID,[SuspendEventDetail].[reasons] AS SUSPENDEVENTDETAIL_REASONS  FROM  [SuspendEventDetail]  WHERE  [SuspendEventDetail].[mid] = \'" + x_iMid.ToString() + "\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[SuspendEventDetail]", "[" + Configurator.MSSQLTablePrefix + "SuspendEventDetail]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read())
                    {
                        if (x_oTableSet.Fields(SuspendEventDetail.Para.active).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["SUSPENDEVENTDETAIL_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(SuspendEventDetail.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SuspendEventDetail.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["SUSPENDEVENTDETAIL_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SuspendEventDetail.Para.active).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(SuspendEventDetail.Para.mid).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["SUSPENDEVENTDETAIL_MID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(SuspendEventDetail.Para.mid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SuspendEventDetail.Para.mid).AliasName].ToString()] = (global::System.Nullable<int>)_oData["SUSPENDEVENTDETAIL_MID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SuspendEventDetail.Para.mid).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(SuspendEventDetail.Para.reasons).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["SUSPENDEVENTDETAIL_REASONS"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(SuspendEventDetail.Para.reasons).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SuspendEventDetail.Para.reasons).AliasName].ToString()] = (string)_oData["SUSPENDEVENTDETAIL_REASONS"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(SuspendEventDetail.Para.reasons).AliasName].ToString()] = string.Empty;
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

        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet, SuspendEventDetail x_oSuspendEventDetailRow)
        {
            return SetByDataSetRowProc(x_iROW, SuspendEventDetail.Para.TableName(), x_oDataSet, x_oSuspendEventDetailRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, SuspendEventDetail x_oSuspendEventDetailRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet, x_oSuspendEventDetailRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, SuspendEventDetail x_oSuspendEventDetailRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                SuspendEventDetailInfo _oTableSet = SuspendEventDetailInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(SuspendEventDetail.Para.mid).AliasName))
                    x_oSuspendEventDetailRow.mid = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(SuspendEventDetail.Para.mid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(SuspendEventDetail.Para.active).AliasName))
                    x_oSuspendEventDetailRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(SuspendEventDetail.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(SuspendEventDetail.Para.reasons).AliasName))
                    x_oSuspendEventDetailRow.reasons = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(SuspendEventDetail.Para.reasons).AliasName];
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
            return SuspendEventDetailRepository.GetCount(x_oDB);
        }
        #endregion


        #region Get

        // ******************************
        // *  Handler for Data Getting
        // ******************************

        public static SuspendEventDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            return SuspendEventDetailRepository.GetArrayObj(x_oDB, x_oColumnName, x_oArrayItemId);
        }

        public static SuspendEventDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder)
        {
            return SuspendEventDetailRepository.GetArrayObj(x_oDB, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        #endregion


        #region List

        // ******************************
        // *  Handler for Data Listing
        // ******************************

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return SuspendEventDetailRepository.GetDataSet(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return SuspendEventDetailRepository.GetSearch(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            return SuspendEventDetailRepository.GetDataSet(x_oDB, x_sFilter);
        }
        #endregion

        #region Insert

        // ******************************
        // *  Handler for Data Inserting
        // ******************************

        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bActive, string x_sReasons)
        {
            return SuspendEventDetailRepository.Insert(x_oDB, x_bActive, x_sReasons);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, SuspendEventDetail x_oSuspendEventDetail)
        {
            return SuspendEventDetailRepository.InsertWithOutLastID(x_oDB, x_oSuspendEventDetail);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bActive, string x_sReasons)
        {
            return SuspendEventDetailRepository.InsertReturnLastID_SP(x_oDB, x_bActive, x_sReasons);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, SuspendEventDetail x_oSuspendEventDetail)
        {
            return SuspendEventDetailRepository.InsertReturnLastID_SP(x_oDB, x_oSuspendEventDetail);
        }

        #endregion

        #region Delete

        // ******************************
        // *  Handler for Data Deleting
        // ******************************

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            return SuspendEventDetailRepository.DeleteAll(x_oDB);
        }

        public static bool DeleteFilter(MSSQLConnect x_oDB, string x_sFilter)
        {
            return SuspendEventDetailRepository.DeleteFilter(x_oDB, x_sFilter);
        }

        public static bool Delete(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            return SuspendEventDetailRepository.Delete(x_oDB, x_iMid);
        }


        #endregion

        #region Delete Uploaded Files

        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(SuspendEventDetail x_oSuspendEventDetailRow)
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

