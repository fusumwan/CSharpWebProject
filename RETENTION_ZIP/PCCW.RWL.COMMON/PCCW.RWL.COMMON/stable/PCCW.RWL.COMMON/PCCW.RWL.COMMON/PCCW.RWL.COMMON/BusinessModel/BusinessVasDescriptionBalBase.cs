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
///-- Description:	<Description,Table :[BusinessVasDescription],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [BusinessVasDescription] Business layer
    /// </summary>

    public abstract class BusinessVasDescriptionBalBase
    {

        #region Constructor


        // ******************************
        // *  Handler for Class Constructor
        // ******************************

        public BusinessVasDescriptionBalBase()
        {
        }
        ~BusinessVasDescriptionBalBase()
        {
            this.Release();
        }
        #endregion


        #region ToDataSet


        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************

        public static global::System.Data.DataSet ToDataSet(BusinessVasDescription x_oBusinessVasDescription)
        {
            return GetDataSet(x_oBusinessVasDescription, null, BusinessVasDescriptionInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(BusinessVasDescription x_oBusinessVasDescription, global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oBusinessVasDescription, x_oMergeDSet, BusinessVasDescriptionInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(BusinessVasDescription x_oBusinessVasDescription, BusinessVasDescriptionInfo x_oTableSet)
        {
            return GetDataSet(x_oBusinessVasDescription, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToDataSet(BusinessVasDescription x_oBusinessVasDescription, global::System.Data.DataSet x_oMergeDSet, BusinessVasDescriptionInfo x_oTableSet)
        {
            return GetDataSet(x_oBusinessVasDescription, x_oMergeDSet, x_oTableSet);
        }


        protected static global::System.Data.DataSet GetDataSet(BusinessVasDescription x_oBusinessVasDescription, global::System.Data.DataSet x_oMergeDSet, BusinessVasDescriptionInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = BusinessVasDescriptionInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(BusinessVasDescription.Para.TableName());
            if (x_oTableSet.Fields(BusinessVasDescription.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVasDescription.Para.TableName()].Columns.Add(BusinessVasDescription.Para.id); }
            if (x_oTableSet.Fields(BusinessVasDescription.Para.fee).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVasDescription.Para.TableName()].Columns.Add(BusinessVasDescription.Para.fee); }
            if (x_oTableSet.Fields(BusinessVasDescription.Para.vas_desc).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVasDescription.Para.TableName()].Columns.Add(BusinessVasDescription.Para.vas_desc); }
            if (x_oTableSet.Fields(BusinessVasDescription.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVasDescription.Para.TableName()].Columns.Add(BusinessVasDescription.Para.active); }
            if (x_oTableSet.Fields(BusinessVasDescription.Para.vas).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[BusinessVasDescription.Para.TableName()].Columns.Add(BusinessVasDescription.Para.vas); }
            if (x_oBusinessVasDescription != null)
            {
                global::System.Data.DataRow _oDRow = _oDSet.Tables[BusinessVasDescription.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(BusinessVasDescription.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVasDescription.Para.id] = x_oBusinessVasDescription.GetId(); }
                if (x_oTableSet.Fields(BusinessVasDescription.Para.fee).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVasDescription.Para.fee] = x_oBusinessVasDescription.GetFee(); }
                if (x_oTableSet.Fields(BusinessVasDescription.Para.vas_desc).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVasDescription.Para.vas_desc] = x_oBusinessVasDescription.GetVas_desc(); }
                if (x_oTableSet.Fields(BusinessVasDescription.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVasDescription.Para.active] = x_oBusinessVasDescription.GetActive(); }
                if (x_oTableSet.Fields(BusinessVasDescription.Para.vas).IsView || x_oTableSet.GetViewAll()) { _oDRow[BusinessVasDescription.Para.vas] = x_oBusinessVasDescription.GetVas(); }
                _oDSet.Tables[BusinessVasDescription.Para.TableName()].Rows.Add(_oDRow);
            }
            if (x_oMergeDSet != null) { _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }


        protected static global::System.Data.DataSet ToEmptyDataSetProcess(BusinessVasDescriptionInfo x_oTableSet)
        {
            return BusinessVasDescriptionBal.GetDataSet(null, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return BusinessVasDescriptionBal.ToEmptyDataSetProcess(BusinessVasDescriptionInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToEmptyDataSet(BusinessVasDescriptionInfo x_oTableSet)
        {
            return BusinessVasDescriptionBal.ToEmptyDataSetProcess(x_oTableSet);
        }


        #endregion ToDataSet

        #region To Table

        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(BusinessVasDescription x_oBusinessVasDescription, BusinessVasDescriptionInfo x_oTableSet)
        {
            return BusinessVasDescriptionBal.GetDataSet(null, null, x_oTableSet).Tables[BusinessVasDescription.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(BusinessVasDescription x_oBusinessVasDescription)
        {
            return BusinessVasDescriptionBal.GetDataSet(x_oBusinessVasDescription, null, BusinessVasDescriptionInfoDLL.CreateInfoInstanceObject()).Tables[BusinessVasDescription.Para.TableName()];
        }
        #endregion

        #region To Row

        // ******************************
        // *  Handler for Data DataRow
        // ******************************


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            return Row(x_oTable, x_oDB, x_iId, BusinessVasDescriptionInfoDLL.CreateInfoInstanceObject());
        }


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iId, BusinessVasDescriptionInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB, x_iId, x_oTableSet);
        }

        public static DataRow Row(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iId, BusinessVasDescriptionInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = BusinessVasDescriptionInfoDLL.CreateInfoInstanceObject();
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                string _sQuery = "SELECT [BusinessVasDescription].[active] AS BUSINESSVASDESCRIPTION_ACTIVE,[BusinessVasDescription].[vas_desc] AS BUSINESSVASDESCRIPTION_VAS_DESC,[BusinessVasDescription].[fee] AS BUSINESSVASDESCRIPTION_FEE,[BusinessVasDescription].[vas] AS BUSINESSVASDESCRIPTION_VAS,[BusinessVasDescription].[id] AS BUSINESSVASDESCRIPTION_ID  FROM  [BusinessVasDescription]  WHERE  [BusinessVasDescription].[id] = \'" + x_iId.ToString() + "\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVasDescription]", "[" + Configurator.MSSQLTablePrefix + "BusinessVasDescription]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read())
                    {
                        if (x_oTableSet.Fields(BusinessVasDescription.Para.active).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDESCRIPTION_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVasDescription.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDescription.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["BUSINESSVASDESCRIPTION_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDescription.Para.active).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessVasDescription.Para.vas_desc).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDESCRIPTION_VAS_DESC"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVasDescription.Para.vas_desc).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDescription.Para.vas_desc).AliasName].ToString()] = (string)_oData["BUSINESSVASDESCRIPTION_VAS_DESC"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDescription.Para.vas_desc).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessVasDescription.Para.fee).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDESCRIPTION_FEE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVasDescription.Para.fee).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDescription.Para.fee).AliasName].ToString()] = (string)_oData["BUSINESSVASDESCRIPTION_FEE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDescription.Para.fee).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessVasDescription.Para.vas).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDESCRIPTION_VAS"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVasDescription.Para.vas).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDescription.Para.vas).AliasName].ToString()] = (string)_oData["BUSINESSVASDESCRIPTION_VAS"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDescription.Para.vas).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(BusinessVasDescription.Para.id).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDESCRIPTION_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(BusinessVasDescription.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDescription.Para.id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["BUSINESSVASDESCRIPTION_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(BusinessVasDescription.Para.id).AliasName].ToString()] = string.Empty;
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

        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet, BusinessVasDescription x_oBusinessVasDescriptionRow)
        {
            return SetByDataSetRowProc(x_iROW, BusinessVasDescription.Para.TableName(), x_oDataSet, x_oBusinessVasDescriptionRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, BusinessVasDescription x_oBusinessVasDescriptionRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet, x_oBusinessVasDescriptionRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, BusinessVasDescription x_oBusinessVasDescriptionRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                BusinessVasDescriptionInfo _oTableSet = BusinessVasDescriptionInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVasDescription.Para.id).AliasName))
                    x_oBusinessVasDescriptionRow.id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVasDescription.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVasDescription.Para.fee).AliasName))
                    x_oBusinessVasDescriptionRow.fee = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVasDescription.Para.fee).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVasDescription.Para.vas_desc).AliasName))
                    x_oBusinessVasDescriptionRow.vas_desc = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVasDescription.Para.vas_desc).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVasDescription.Para.active).AliasName))
                    x_oBusinessVasDescriptionRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVasDescription.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(BusinessVasDescription.Para.vas).AliasName))
                    x_oBusinessVasDescriptionRow.vas = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(BusinessVasDescription.Para.vas).AliasName];
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
            return BusinessVasDescriptionRepository.GetCount(x_oDB);
        }
        #endregion


        #region Get

        // ******************************
        // *  Handler for Data Getting
        // ******************************

        public static BusinessVasDescriptionEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            return BusinessVasDescriptionRepository.GetArrayObj(x_oDB, x_oColumnName, x_oArrayItemId);
        }

        public static BusinessVasDescriptionEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder)
        {
            return BusinessVasDescriptionRepository.GetArrayObj(x_oDB, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        #endregion


        #region List

        // ******************************
        // *  Handler for Data Listing
        // ******************************

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return BusinessVasDescriptionRepository.GetDataSet(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return BusinessVasDescriptionRepository.GetSearch(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            return BusinessVasDescriptionRepository.GetDataSet(x_oDB, x_sFilter);
        }
        #endregion

        #region Insert

        // ******************************
        // *  Handler for Data Inserting
        // ******************************

        public static bool Insert(MSSQLConnect x_oDB, string x_sFee, string x_sVas_desc, global::System.Nullable<bool> x_bActive, string x_sVas)
        {
            return BusinessVasDescriptionRepository.Insert(x_oDB, x_sFee, x_sVas_desc, x_bActive, x_sVas);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, BusinessVasDescription x_oBusinessVasDescription)
        {
            return BusinessVasDescriptionRepository.InsertWithOutLastID(x_oDB, x_oBusinessVasDescription);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, string x_sFee, string x_sVas_desc, global::System.Nullable<bool> x_bActive, string x_sVas)
        {
            return BusinessVasDescriptionRepository.InsertReturnLastID_SP(x_oDB, x_sFee, x_sVas_desc, x_bActive, x_sVas);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, BusinessVasDescription x_oBusinessVasDescription)
        {
            return BusinessVasDescriptionRepository.InsertReturnLastID_SP(x_oDB, x_oBusinessVasDescription);
        }

        #endregion

        #region Delete

        // ******************************
        // *  Handler for Data Deleting
        // ******************************

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            return BusinessVasDescriptionRepository.DeleteAll(x_oDB);
        }

        public static bool DeleteFilter(MSSQLConnect x_oDB, string x_sFilter)
        {
            return BusinessVasDescriptionRepository.DeleteFilter(x_oDB, x_sFilter);
        }

        public static bool Delete(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            return BusinessVasDescriptionRepository.Delete(x_oDB, x_iId);
        }


        #endregion

        #region Delete Uploaded Files

        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(BusinessVasDescription x_oBusinessVasDescriptionRow)
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

