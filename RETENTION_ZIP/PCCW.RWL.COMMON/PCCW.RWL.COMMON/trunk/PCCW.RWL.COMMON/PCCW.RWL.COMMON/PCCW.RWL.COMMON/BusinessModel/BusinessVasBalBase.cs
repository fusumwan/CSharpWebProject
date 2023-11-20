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
///-- Description:	<Description,Table :[BusinessVas],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [BusinessVas] Business layer
    /// </summary>

    public abstract class BusinessVasBalBase
    {

        #region Constructor


        // ******************************
        // *  Handler for Class Constructor
        // ******************************

        public BusinessVasBalBase()
        {
        }
        ~BusinessVasBalBase()
        {
            this.Release();
        }
        #endregion


        #region ToDataSet


        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************

        public static global::System.Data.DataSet ToDataSet(BusinessVas x_oBusinessVas)
        {
            return GetDataSet(x_oBusinessVas, null, BusinessVasInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(BusinessVas x_oBusinessVas, global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oBusinessVas, x_oMergeDSet, BusinessVasInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(BusinessVas x_oBusinessVas, BusinessVasInfo x_oTableSet)
        {
            return GetDataSet(x_oBusinessVas, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToDataSet(BusinessVas x_oBusinessVas, global::System.Data.DataSet x_oMergeDSet, BusinessVasInfo x_oTableSet)
        {
            return GetDataSet(x_oBusinessVas, x_oMergeDSet, x_oTableSet);
        }


        protected static global::System.Data.DataSet GetDataSet(BusinessVas x_oBusinessVas, global::System.Data.DataSet x_oMergeDSet, BusinessVasInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = BusinessVasInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(BusinessVas.Para.TableName());
            if (x_oTableSet.Fields(BusinessVas.Para.vas_field).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVas.Para.TableName()].Columns.Add(BusinessVas.Para.vas_field); }
            if (x_oTableSet.Fields(BusinessVas.Para.vas_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVas.Para.TableName()].Columns.Add(BusinessVas.Para.vas_name); }
            if (x_oTableSet.Fields(BusinessVas.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVas.Para.TableName()].Columns.Add(BusinessVas.Para.active); }
            if (x_oTableSet.Fields(BusinessVas.Para.vas_value).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVas.Para.TableName()].Columns.Add(BusinessVas.Para.vas_value); }
            if (x_oTableSet.Fields(BusinessVas.Para.multi).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVas.Para.TableName()].Columns.Add(BusinessVas.Para.multi); }
            if (x_oTableSet.Fields(BusinessVas.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVas.Para.TableName()].Columns.Add(BusinessVas.Para.id); }
            if (x_oTableSet.Fields(BusinessVas.Para.vas_chi_name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVas.Para.TableName()].Columns.Add(BusinessVas.Para.vas_chi_name); }
            if (x_oBusinessVas != null)
            {
                global::System.Data.DataRow _oDRow = _oDSet.Tables[BusinessVas.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(BusinessVas.Para.vas_field).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVas.Para.vas_field] = x_oBusinessVas.GetVas_field(); }
                if (x_oTableSet.Fields(BusinessVas.Para.vas_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVas.Para.vas_name] = x_oBusinessVas.GetVas_name(); }
                if (x_oTableSet.Fields(BusinessVas.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVas.Para.active] = x_oBusinessVas.GetActive(); }
                if (x_oTableSet.Fields(BusinessVas.Para.vas_value).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVas.Para.vas_value] = x_oBusinessVas.GetVas_value(); }
                if (x_oTableSet.Fields(BusinessVas.Para.multi).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVas.Para.multi] = x_oBusinessVas.GetMulti(); }
                if (x_oTableSet.Fields(BusinessVas.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVas.Para.id] = x_oBusinessVas.GetId(); }
                if (x_oTableSet.Fields(BusinessVas.Para.vas_chi_name).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVas.Para.vas_chi_name] = x_oBusinessVas.GetVas_chi_name(); }
                _oDSet.Tables[BusinessVas.Para.TableName()].Rows.Add(_oDRow);
            }
            if (x_oMergeDSet != null) { _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }


        protected static global::System.Data.DataSet ToEmptyDataSetProcess(BusinessVasInfo x_oTableSet)
        {
            return BusinessVasBal.GetDataSet(null, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return BusinessVasBal.ToEmptyDataSetProcess(BusinessVasInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToEmptyDataSet(BusinessVasInfo x_oTableSet)
        {
            return BusinessVasBal.ToEmptyDataSetProcess(x_oTableSet);
        }


        #endregion ToDataSet

        #region To Table

        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(BusinessVas x_oBusinessVas, BusinessVasInfo x_oTableSet)
        {
            return BusinessVasBal.GetDataSet(null, null, x_oTableSet).Tables[BusinessVas.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(BusinessVas x_oBusinessVas)
        {
            return BusinessVasBal.GetDataSet(x_oBusinessVas, null, BusinessVasInfoDLL.CreateInfoInstanceObject()).Tables[BusinessVas.Para.TableName()];
        }
        #endregion

        #region To Row

        // ******************************
        // *  Handler for Data DataRow
        // ******************************


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            return Row(x_oTable, x_oDB, x_iId, BusinessVasInfoDLL.CreateInfoInstanceObject());
        }


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iId, BusinessVasInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB, x_iId, x_oTableSet);
        }

        public static DataRow Row(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iId, BusinessVasInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = BusinessVasInfoDLL.CreateInfoInstanceObject();
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                string _sQuery = "SELECT [BusinessVas].[vas_field] AS BUSINESSVAS_VAS_FIELD,[BusinessVas].[multi] AS BUSINESSVAS_MULTI,[BusinessVas].[vas_name] AS BUSINESSVAS_VAS_NAME,[BusinessVas].[active] AS BUSINESSVAS_ACTIVE,[BusinessVas].[vas_value] AS BUSINESSVAS_VAS_VALUE,[BusinessVas].[id] AS BUSINESSVAS_ID,[BusinessVas].[vas_chi_name] AS BUSINESSVAS_VAS_CHI_NAME  FROM  [BusinessVas]  WHERE  [BusinessVas].[id] = \'" + x_iId.ToString() + "\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVas]", "[" + Configurator.MSSQLTablePrefix + "BusinessVas]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read())
                    {
                        if (x_oTableSet.Fields(BusinessVas.Para.vas_field).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVAS_VAS_FIELD"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVas.Para.vas_field).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVas.Para.vas_field).AliasName].ToString()] = (string)_oData["BUSINESSVAS_VAS_FIELD"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVas.Para.vas_field).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessVas.Para.multi).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVAS_MULTI"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVas.Para.multi).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVas.Para.multi).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["BUSINESSVAS_MULTI"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVas.Para.multi).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessVas.Para.vas_name).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVAS_VAS_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVas.Para.vas_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVas.Para.vas_name).AliasName].ToString()] = (string)_oData["BUSINESSVAS_VAS_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVas.Para.vas_name).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessVas.Para.active).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVAS_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVas.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVas.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["BUSINESSVAS_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVas.Para.active).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessVas.Para.vas_value).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVAS_VAS_VALUE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVas.Para.vas_value).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVas.Para.vas_value).AliasName].ToString()] = (string)_oData["BUSINESSVAS_VAS_VALUE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVas.Para.vas_value).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessVas.Para.id).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVAS_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVas.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVas.Para.id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["BUSINESSVAS_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVas.Para.id).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessVas.Para.vas_chi_name).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVAS_VAS_CHI_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVas.Para.vas_chi_name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVas.Para.vas_chi_name).AliasName].ToString()] = (string)_oData["BUSINESSVAS_VAS_CHI_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVas.Para.vas_chi_name).AliasName].ToString()] = string.Empty;
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

        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet, BusinessVas x_oBusinessVasRow)
        {
            return SetByDataSetRowProc(x_iROW, BusinessVas.Para.TableName(), x_oDataSet, x_oBusinessVasRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, BusinessVas x_oBusinessVasRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet, x_oBusinessVasRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, BusinessVas x_oBusinessVasRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                BusinessVasInfo _oTableSet = BusinessVasInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVas.Para.vas_field).AliasName))
                    x_oBusinessVasRow.vas_field = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVas.Para.vas_field).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVas.Para.vas_name).AliasName))
                    x_oBusinessVasRow.vas_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVas.Para.vas_name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVas.Para.active).AliasName))
                    x_oBusinessVasRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVas.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVas.Para.vas_value).AliasName))
                    x_oBusinessVasRow.vas_value = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVas.Para.vas_value).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVas.Para.multi).AliasName))
                    x_oBusinessVasRow.multi = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVas.Para.multi).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVas.Para.id).AliasName))
                    x_oBusinessVasRow.id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVas.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVas.Para.vas_chi_name).AliasName))
                    x_oBusinessVasRow.vas_chi_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVas.Para.vas_chi_name).AliasName];
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
            return BusinessVasRepository.GetCount(x_oDB);
        }
        #endregion


        #region Get

        // ******************************
        // *  Handler for Data Getting
        // ******************************

        public static BusinessVasEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            return BusinessVasRepository.GetArrayObj(x_oDB, x_oColumnName, x_oArrayItemId);
        }

        public static BusinessVasEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder)
        {
            return BusinessVasRepository.GetArrayObj(x_oDB, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        #endregion


        #region List

        // ******************************
        // *  Handler for Data Listing
        // ******************************

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return BusinessVasRepository.GetDataSet(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return BusinessVasRepository.GetSearch(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            return BusinessVasRepository.GetDataSet(x_oDB, x_sFilter);
        }
        #endregion

        #region Insert

        // ******************************
        // *  Handler for Data Inserting
        // ******************************

        public static bool Insert(MSSQLConnect x_oDB, string x_sVas_field, string x_sVas_name, global::System.Nullable<bool> x_bActive, string x_sVas_value, global::System.Nullable<bool> x_bMulti, string x_sVas_chi_name)
        {
            return BusinessVasRepository.Insert(x_oDB, x_sVas_field, x_sVas_name, x_bActive, x_sVas_value, x_bMulti, x_sVas_chi_name);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, BusinessVas x_oBusinessVas)
        {
            return BusinessVasRepository.InsertWithOutLastID(x_oDB, x_oBusinessVas);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, string x_sVas_field, string x_sVas_name, global::System.Nullable<bool> x_bActive, string x_sVas_value, global::System.Nullable<bool> x_bMulti, string x_sVas_chi_name)
        {
            return BusinessVasRepository.InsertReturnLastID_SP(x_oDB, x_sVas_field, x_sVas_name, x_bActive, x_sVas_value, x_bMulti, x_sVas_chi_name);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, BusinessVas x_oBusinessVas)
        {
            return BusinessVasRepository.InsertReturnLastID_SP(x_oDB, x_oBusinessVas);
        }

        #endregion

        #region Delete

        // ******************************
        // *  Handler for Data Deleting
        // ******************************

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            return BusinessVasRepository.DeleteAll(x_oDB);
        }

        public static bool DeleteFilter(MSSQLConnect x_oDB, string x_sFilter)
        {
            return BusinessVasRepository.DeleteFilter(x_oDB, x_sFilter);
        }

        public static bool Delete(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            return BusinessVasRepository.Delete(x_oDB, x_iId);
        }


        #endregion

        #region Delete Uploaded Files

        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(BusinessVas x_oBusinessVasRow)
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

