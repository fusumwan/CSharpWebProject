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
///-- Description:	<Description,Table :[BusinessVasNameRecord],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [BusinessVasNameRecord] Business layer
    /// </summary>

    public abstract class BusinessVasNameRecordBalBase
    {

        #region Constructor


        // ******************************
        // *  Handler for Class Constructor
        // ******************************

        public BusinessVasNameRecordBalBase()
        {
        }
        ~BusinessVasNameRecordBalBase()
        {
            this.Release();
        }
        #endregion


        #region ToDataSet


        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************

        public static global::System.Data.DataSet ToDataSet(BusinessVasNameRecord x_oBusinessVasNameRecord)
        {
            return GetDataSet(x_oBusinessVasNameRecord, null, BusinessVasNameRecordInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(BusinessVasNameRecord x_oBusinessVasNameRecord, global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oBusinessVasNameRecord, x_oMergeDSet, BusinessVasNameRecordInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(BusinessVasNameRecord x_oBusinessVasNameRecord, BusinessVasNameRecordInfo x_oTableSet)
        {
            return GetDataSet(x_oBusinessVasNameRecord, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToDataSet(BusinessVasNameRecord x_oBusinessVasNameRecord, global::System.Data.DataSet x_oMergeDSet, BusinessVasNameRecordInfo x_oTableSet)
        {
            return GetDataSet(x_oBusinessVasNameRecord, x_oMergeDSet, x_oTableSet);
        }


        protected static global::System.Data.DataSet GetDataSet(BusinessVasNameRecord x_oBusinessVasNameRecord, global::System.Data.DataSet x_oMergeDSet, BusinessVasNameRecordInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = BusinessVasNameRecordInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(BusinessVasNameRecord.Para.TableName());
            if (x_oTableSet.Fields(BusinessVasNameRecord.Para.vas_field).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVasNameRecord.Para.TableName()].Columns.Add(BusinessVasNameRecord.Para.vas_field); }
            if (x_oTableSet.Fields(BusinessVasNameRecord.Para.vas_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVasNameRecord.Para.TableName()].Columns.Add(BusinessVasNameRecord.Para.vas_name); }
            if (x_oTableSet.Fields(BusinessVasNameRecord.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVasNameRecord.Para.TableName()].Columns.Add(BusinessVasNameRecord.Para.id); }
            if (x_oTableSet.Fields(BusinessVasNameRecord.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVasNameRecord.Para.TableName()].Columns.Add(BusinessVasNameRecord.Para.active); }
            if (x_oTableSet.Fields(BusinessVasNameRecord.Para.vas_chi_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVasNameRecord.Para.TableName()].Columns.Add(BusinessVasNameRecord.Para.vas_chi_name); }
            if (x_oBusinessVasNameRecord != null)
            {
                global::System.Data.DataRow _oDRow = _oDSet.Tables[BusinessVasNameRecord.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(BusinessVasNameRecord.Para.vas_field).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVasNameRecord.Para.vas_field] = x_oBusinessVasNameRecord.GetVas_field(); }
                if (x_oTableSet.Fields(BusinessVasNameRecord.Para.vas_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVasNameRecord.Para.vas_name] = x_oBusinessVasNameRecord.GetVas_name(); }
                if (x_oTableSet.Fields(BusinessVasNameRecord.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVasNameRecord.Para.id] = x_oBusinessVasNameRecord.GetId(); }
                if (x_oTableSet.Fields(BusinessVasNameRecord.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVasNameRecord.Para.active] = x_oBusinessVasNameRecord.GetActive(); }
                if (x_oTableSet.Fields(BusinessVasNameRecord.Para.vas_chi_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVasNameRecord.Para.vas_chi_name] = x_oBusinessVasNameRecord.GetVas_chi_name(); }
                _oDSet.Tables[BusinessVasNameRecord.Para.TableName()].Rows.Add(_oDRow);
            }
            if (x_oMergeDSet != null) { _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }


        protected static global::System.Data.DataSet ToEmptyDataSetProcess(BusinessVasNameRecordInfo x_oTableSet)
        {
            return BusinessVasNameRecordBal.GetDataSet(null, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return BusinessVasNameRecordBal.ToEmptyDataSetProcess(BusinessVasNameRecordInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToEmptyDataSet(BusinessVasNameRecordInfo x_oTableSet)
        {
            return BusinessVasNameRecordBal.ToEmptyDataSetProcess(x_oTableSet);
        }


        #endregion ToDataSet

        #region To Table

        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(BusinessVasNameRecord x_oBusinessVasNameRecord, BusinessVasNameRecordInfo x_oTableSet)
        {
            return BusinessVasNameRecordBal.GetDataSet(null, null, x_oTableSet).Tables[BusinessVasNameRecord.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(BusinessVasNameRecord x_oBusinessVasNameRecord)
        {
            return BusinessVasNameRecordBal.GetDataSet(x_oBusinessVasNameRecord, null, BusinessVasNameRecordInfoDLL.CreateInfoInstanceObject()).Tables[BusinessVasNameRecord.Para.TableName()];
        }
        #endregion

        #region To Row

        // ******************************
        // *  Handler for Data DataRow
        // ******************************


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            return Row(x_oTable, x_oDB, x_iId, BusinessVasNameRecordInfoDLL.CreateInfoInstanceObject());
        }


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iId, BusinessVasNameRecordInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB, x_iId, x_oTableSet);
        }

        public static DataRow Row(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iId, BusinessVasNameRecordInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = BusinessVasNameRecordInfoDLL.CreateInfoInstanceObject();
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                string _sQuery = "SELECT [BusinessVasNameRecord].[vas_field] AS BUSINESSVASNAMERECORD_VAS_FIELD,[BusinessVasNameRecord].[vas_name] AS BUSINESSVASNAMERECORD_VAS_NAME,[BusinessVasNameRecord].[active] AS BUSINESSVASNAMERECORD_ACTIVE,[BusinessVasNameRecord].[id] AS BUSINESSVASNAMERECORD_ID,[BusinessVasNameRecord].[vas_chi_name] AS BUSINESSVASNAMERECORD_VAS_CHI_NAME  FROM  [BusinessVasNameRecord]  WHERE  [BusinessVasNameRecord].[id] = \'" + x_iId.ToString() + "\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVasNameRecord]", "[" + Configurator.MSSQLTablePrefix + "BusinessVasNameRecord]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read())
                    {
                        if (x_oTableSet.Fields(BusinessVasNameRecord.Para.vas_field).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASNAMERECORD_VAS_FIELD"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVasNameRecord.Para.vas_field).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasNameRecord.Para.vas_field).AliasName].ToString()] = (string)_oData["BUSINESSVASNAMERECORD_VAS_FIELD"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasNameRecord.Para.vas_field).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessVasNameRecord.Para.vas_name).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASNAMERECORD_VAS_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVasNameRecord.Para.vas_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasNameRecord.Para.vas_name).AliasName].ToString()] = (string)_oData["BUSINESSVASNAMERECORD_VAS_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasNameRecord.Para.vas_name).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessVasNameRecord.Para.active).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASNAMERECORD_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVasNameRecord.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasNameRecord.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["BUSINESSVASNAMERECORD_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasNameRecord.Para.active).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessVasNameRecord.Para.id).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASNAMERECORD_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVasNameRecord.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasNameRecord.Para.id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["BUSINESSVASNAMERECORD_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasNameRecord.Para.id).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessVasNameRecord.Para.vas_chi_name).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASNAMERECORD_VAS_CHI_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVasNameRecord.Para.vas_chi_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasNameRecord.Para.vas_chi_name).AliasName].ToString()] = (string)_oData["BUSINESSVASNAMERECORD_VAS_CHI_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasNameRecord.Para.vas_chi_name).AliasName].ToString()] = string.Empty;
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

        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet, BusinessVasNameRecord x_oBusinessVasNameRecordRow)
        {
            return SetByDataSetRowProc(x_iROW, BusinessVasNameRecord.Para.TableName(), x_oDataSet, x_oBusinessVasNameRecordRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, BusinessVasNameRecord x_oBusinessVasNameRecordRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet, x_oBusinessVasNameRecordRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, BusinessVasNameRecord x_oBusinessVasNameRecordRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                BusinessVasNameRecordInfo _oTableSet = BusinessVasNameRecordInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVasNameRecord.Para.vas_field).AliasName))
                    x_oBusinessVasNameRecordRow.vas_field = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVasNameRecord.Para.vas_field).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVasNameRecord.Para.vas_name).AliasName))
                    x_oBusinessVasNameRecordRow.vas_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVasNameRecord.Para.vas_name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVasNameRecord.Para.id).AliasName))
                    x_oBusinessVasNameRecordRow.id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVasNameRecord.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVasNameRecord.Para.active).AliasName))
                    x_oBusinessVasNameRecordRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVasNameRecord.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVasNameRecord.Para.vas_chi_name).AliasName))
                    x_oBusinessVasNameRecordRow.vas_chi_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVasNameRecord.Para.vas_chi_name).AliasName];
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
            return BusinessVasNameRecordRepository.GetCount(x_oDB);
        }
        #endregion


        #region Get

        // ******************************
        // *  Handler for Data Getting
        // ******************************

        public static BusinessVasNameRecordEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            return BusinessVasNameRecordRepository.GetArrayObj(x_oDB, x_oColumnName, x_oArrayItemId);
        }

        public static BusinessVasNameRecordEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder)
        {
            return BusinessVasNameRecordRepository.GetArrayObj(x_oDB, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        #endregion


        #region List

        // ******************************
        // *  Handler for Data Listing
        // ******************************

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return BusinessVasNameRecordRepository.GetDataSet(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return BusinessVasNameRecordRepository.GetSearch(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            return BusinessVasNameRecordRepository.GetDataSet(x_oDB, x_sFilter);
        }
        #endregion

        #region Insert

        // ******************************
        // *  Handler for Data Inserting
        // ******************************

        public static bool Insert(MSSQLConnect x_oDB, string x_sVas_field, string x_sVas_name, global::System.Nullable<bool> x_bActive, string x_sVas_chi_name)
        {
            return BusinessVasNameRecordRepository.Insert(x_oDB, x_sVas_field, x_sVas_name, x_bActive, x_sVas_chi_name);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, BusinessVasNameRecord x_oBusinessVasNameRecord)
        {
            return BusinessVasNameRecordRepository.InsertWithOutLastID(x_oDB, x_oBusinessVasNameRecord);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, string x_sVas_field, string x_sVas_name, global::System.Nullable<bool> x_bActive, string x_sVas_chi_name)
        {
            return BusinessVasNameRecordRepository.InsertReturnLastID_SP(x_oDB, x_sVas_field, x_sVas_name, x_bActive, x_sVas_chi_name);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, BusinessVasNameRecord x_oBusinessVasNameRecord)
        {
            return BusinessVasNameRecordRepository.InsertReturnLastID_SP(x_oDB, x_oBusinessVasNameRecord);
        }

        #endregion

        #region Delete

        // ******************************
        // *  Handler for Data Deleting
        // ******************************

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            return BusinessVasNameRecordRepository.DeleteAll(x_oDB);
        }

        public static bool DeleteFilter(MSSQLConnect x_oDB, string x_sFilter)
        {
            return BusinessVasNameRecordRepository.DeleteFilter(x_oDB, x_sFilter);
        }

        public static bool Delete(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            return BusinessVasNameRecordRepository.Delete(x_oDB, x_iId);
        }


        #endregion

        #region Delete Uploaded Files

        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(BusinessVasNameRecord x_oBusinessVasNameRecordRow)
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

