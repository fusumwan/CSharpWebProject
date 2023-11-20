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
///-- Description:	<Description,Table :[EventLetterDetail],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [EventLetterDetail] Business layer
    /// </summary>

    public abstract class EventLetterDetailBalBase
    {

        #region Constructor


        // ******************************
        // *  Handler for Class Constructor
        // ******************************

        public EventLetterDetailBalBase()
        {
        }
        ~EventLetterDetailBalBase()
        {
            this.Release();
        }
        #endregion


        #region ToDataSet


        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************

        public static global::System.Data.DataSet ToDataSet(EventLetterDetail x_oEventLetterDetail)
        {
            return GetDataSet(x_oEventLetterDetail, null, EventLetterDetailInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(EventLetterDetail x_oEventLetterDetail, global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oEventLetterDetail, x_oMergeDSet, EventLetterDetailInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(EventLetterDetail x_oEventLetterDetail, EventLetterDetailInfo x_oTableSet)
        {
            return GetDataSet(x_oEventLetterDetail, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToDataSet(EventLetterDetail x_oEventLetterDetail, global::System.Data.DataSet x_oMergeDSet, EventLetterDetailInfo x_oTableSet)
        {
            return GetDataSet(x_oEventLetterDetail, x_oMergeDSet, x_oTableSet);
        }


        protected static global::System.Data.DataSet GetDataSet(EventLetterDetail x_oEventLetterDetail, global::System.Data.DataSet x_oMergeDSet, EventLetterDetailInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = EventLetterDetailInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(EventLetterDetail.Para.TableName());
            if (x_oTableSet.Fields(EventLetterDetail.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EventLetterDetail.Para.TableName()].Columns.Add(EventLetterDetail.Para.id); }
            if (x_oTableSet.Fields(EventLetterDetail.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EventLetterDetail.Para.TableName()].Columns.Add(EventLetterDetail.Para.cdate); }
            if (x_oTableSet.Fields(EventLetterDetail.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EventLetterDetail.Para.TableName()].Columns.Add(EventLetterDetail.Para.cid); }
            if (x_oTableSet.Fields(EventLetterDetail.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EventLetterDetail.Para.TableName()].Columns.Add(EventLetterDetail.Para.active); }
            if (x_oTableSet.Fields(EventLetterDetail.Para.mob_num).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EventLetterDetail.Para.TableName()].Columns.Add(EventLetterDetail.Para.mob_num); }
            if (x_oTableSet.Fields(EventLetterDetail.Para.doc_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EventLetterDetail.Para.TableName()].Columns.Add(EventLetterDetail.Para.doc_id); }
            if (x_oTableSet.Fields(EventLetterDetail.Para.name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EventLetterDetail.Para.TableName()].Columns.Add(EventLetterDetail.Para.name); }
            if (x_oTableSet.Fields(EventLetterDetail.Para.prem_desc).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EventLetterDetail.Para.TableName()].Columns.Add(EventLetterDetail.Para.prem_desc); }
            if (x_oTableSet.Fields(EventLetterDetail.Para.Remarks).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EventLetterDetail.Para.TableName()].Columns.Add(EventLetterDetail.Para.Remarks); }
            if (x_oTableSet.Fields(EventLetterDetail.Para.accnt_cd).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EventLetterDetail.Para.TableName()].Columns.Add(EventLetterDetail.Para.accnt_cd); }
            if (x_oTableSet.Fields(EventLetterDetail.Para.lett_sent_date).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EventLetterDetail.Para.TableName()].Columns.Add(EventLetterDetail.Para.lett_sent_date); }
            if (x_oEventLetterDetail != null)
            {
                global::System.Data.DataRow _oDRow = _oDSet.Tables[EventLetterDetail.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(EventLetterDetail.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[EventLetterDetail.Para.id] = x_oEventLetterDetail.GetId(); }
                if (x_oTableSet.Fields(EventLetterDetail.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[EventLetterDetail.Para.cdate] = x_oEventLetterDetail.GetCdate(); }
                if (x_oTableSet.Fields(EventLetterDetail.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[EventLetterDetail.Para.cid] = x_oEventLetterDetail.GetCid(); }
                if (x_oTableSet.Fields(EventLetterDetail.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[EventLetterDetail.Para.active] = x_oEventLetterDetail.GetActive(); }
                if (x_oTableSet.Fields(EventLetterDetail.Para.mob_num).IsView || x_oTableSet.GetViewAll()) { _oDRow[EventLetterDetail.Para.mob_num] = x_oEventLetterDetail.GetMob_num(); }
                if (x_oTableSet.Fields(EventLetterDetail.Para.doc_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[EventLetterDetail.Para.doc_id] = x_oEventLetterDetail.GetDoc_id(); }
                if (x_oTableSet.Fields(EventLetterDetail.Para.name).IsView || x_oTableSet.GetViewAll()) { _oDRow[EventLetterDetail.Para.name] = x_oEventLetterDetail.GetName(); }
                if (x_oTableSet.Fields(EventLetterDetail.Para.prem_desc).IsView || x_oTableSet.GetViewAll()) { _oDRow[EventLetterDetail.Para.prem_desc] = x_oEventLetterDetail.GetPrem_desc(); }
                if (x_oTableSet.Fields(EventLetterDetail.Para.Remarks).IsView || x_oTableSet.GetViewAll()) { _oDRow[EventLetterDetail.Para.Remarks] = x_oEventLetterDetail.GetRemarks(); }
                if (x_oTableSet.Fields(EventLetterDetail.Para.accnt_cd).IsView || x_oTableSet.GetViewAll()) { _oDRow[EventLetterDetail.Para.accnt_cd] = x_oEventLetterDetail.GetAccnt_cd(); }
                if (x_oTableSet.Fields(EventLetterDetail.Para.lett_sent_date).IsView || x_oTableSet.GetViewAll()) { _oDRow[EventLetterDetail.Para.lett_sent_date] = x_oEventLetterDetail.GetLett_sent_date(); }
                _oDSet.Tables[EventLetterDetail.Para.TableName()].Rows.Add(_oDRow);
            }
            if (x_oMergeDSet != null) { _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }


        protected static global::System.Data.DataSet ToEmptyDataSetProcess(EventLetterDetailInfo x_oTableSet)
        {
            return EventLetterDetailBal.GetDataSet(null, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return EventLetterDetailBal.ToEmptyDataSetProcess(EventLetterDetailInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToEmptyDataSet(EventLetterDetailInfo x_oTableSet)
        {
            return EventLetterDetailBal.ToEmptyDataSetProcess(x_oTableSet);
        }


        #endregion ToDataSet

        #region To Table

        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(EventLetterDetail x_oEventLetterDetail, EventLetterDetailInfo x_oTableSet)
        {
            return EventLetterDetailBal.GetDataSet(null, null, x_oTableSet).Tables[EventLetterDetail.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(EventLetterDetail x_oEventLetterDetail)
        {
            return EventLetterDetailBal.GetDataSet(x_oEventLetterDetail, null, EventLetterDetailInfoDLL.CreateInfoInstanceObject()).Tables[EventLetterDetail.Para.TableName()];
        }
        #endregion

        #region To Row

        // ******************************
        // *  Handler for Data DataRow
        // ******************************


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            return Row(x_oTable, x_oDB, x_iId, EventLetterDetailInfoDLL.CreateInfoInstanceObject());
        }


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iId, EventLetterDetailInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB, x_iId, x_oTableSet);
        }

        public static DataRow Row(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iId, EventLetterDetailInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = EventLetterDetailInfoDLL.CreateInfoInstanceObject();
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                string _sQuery = "SELECT [EventLetterDetail].[id] AS EVENTLETTERDETAIL_ID,[EventLetterDetail].[cdate] AS EVENTLETTERDETAIL_CDATE,[EventLetterDetail].[cid] AS EVENTLETTERDETAIL_CID,[EventLetterDetail].[accnt_cd] AS EVENTLETTERDETAIL_ACCNT_CD,[EventLetterDetail].[mob_num] AS EVENTLETTERDETAIL_MOB_NUM,[EventLetterDetail].[doc_id] AS EVENTLETTERDETAIL_DOC_ID,[EventLetterDetail].[active] AS EVENTLETTERDETAIL_ACTIVE,[EventLetterDetail].[name] AS EVENTLETTERDETAIL_NAME,[EventLetterDetail].[Remarks] AS EVENTLETTERDETAIL_REMARKS,[EventLetterDetail].[prem_desc] AS EVENTLETTERDETAIL_PREM_DESC,[EventLetterDetail].[lett_sent_date] AS EVENTLETTERDETAIL_LETT_SENT_DATE  FROM  [EventLetterDetail]  WHERE  [EventLetterDetail].[id] = \'" + x_iId.ToString() + "\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[EventLetterDetail]", "[" + Configurator.MSSQLTablePrefix + "EventLetterDetail]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read())
                    {
                        if (x_oTableSet.Fields(EventLetterDetail.Para.id).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EventLetterDetail.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventLetterDetail.Para.id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["EVENTLETTERDETAIL_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventLetterDetail.Para.id).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(EventLetterDetail.Para.cdate).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EventLetterDetail.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventLetterDetail.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["EVENTLETTERDETAIL_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventLetterDetail.Para.cdate).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(EventLetterDetail.Para.cid).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EventLetterDetail.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventLetterDetail.Para.cid).AliasName].ToString()] = (string)_oData["EVENTLETTERDETAIL_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventLetterDetail.Para.cid).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(EventLetterDetail.Para.accnt_cd).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_ACCNT_CD"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EventLetterDetail.Para.accnt_cd).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventLetterDetail.Para.accnt_cd).AliasName].ToString()] = (string)_oData["EVENTLETTERDETAIL_ACCNT_CD"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventLetterDetail.Para.accnt_cd).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(EventLetterDetail.Para.mob_num).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_MOB_NUM"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EventLetterDetail.Para.mob_num).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventLetterDetail.Para.mob_num).AliasName].ToString()] = (string)_oData["EVENTLETTERDETAIL_MOB_NUM"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventLetterDetail.Para.mob_num).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(EventLetterDetail.Para.doc_id).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_DOC_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EventLetterDetail.Para.doc_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventLetterDetail.Para.doc_id).AliasName].ToString()] = (string)_oData["EVENTLETTERDETAIL_DOC_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventLetterDetail.Para.doc_id).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(EventLetterDetail.Para.active).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EventLetterDetail.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventLetterDetail.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["EVENTLETTERDETAIL_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventLetterDetail.Para.active).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(EventLetterDetail.Para.name).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EventLetterDetail.Para.name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventLetterDetail.Para.name).AliasName].ToString()] = (string)_oData["EVENTLETTERDETAIL_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventLetterDetail.Para.name).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(EventLetterDetail.Para.Remarks).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_REMARKS"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EventLetterDetail.Para.Remarks).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventLetterDetail.Para.Remarks).AliasName].ToString()] = (string)_oData["EVENTLETTERDETAIL_REMARKS"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventLetterDetail.Para.Remarks).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(EventLetterDetail.Para.prem_desc).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_PREM_DESC"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EventLetterDetail.Para.prem_desc).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventLetterDetail.Para.prem_desc).AliasName].ToString()] = (string)_oData["EVENTLETTERDETAIL_PREM_DESC"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventLetterDetail.Para.prem_desc).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(EventLetterDetail.Para.lett_sent_date).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["EVENTLETTERDETAIL_LETT_SENT_DATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EventLetterDetail.Para.lett_sent_date).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventLetterDetail.Para.lett_sent_date).AliasName].ToString()] = (string)_oData["EVENTLETTERDETAIL_LETT_SENT_DATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventLetterDetail.Para.lett_sent_date).AliasName].ToString()] = string.Empty;
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

        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet, EventLetterDetail x_oEventLetterDetailRow)
        {
            return SetByDataSetRowProc(x_iROW, EventLetterDetail.Para.TableName(), x_oDataSet, x_oEventLetterDetailRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, EventLetterDetail x_oEventLetterDetailRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet, x_oEventLetterDetailRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, EventLetterDetail x_oEventLetterDetailRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                EventLetterDetailInfo _oTableSet = EventLetterDetailInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EventLetterDetail.Para.id).AliasName))
                    x_oEventLetterDetailRow.id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EventLetterDetail.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EventLetterDetail.Para.cdate).AliasName))
                    x_oEventLetterDetailRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EventLetterDetail.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EventLetterDetail.Para.cid).AliasName))
                    x_oEventLetterDetailRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EventLetterDetail.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EventLetterDetail.Para.active).AliasName))
                    x_oEventLetterDetailRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EventLetterDetail.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EventLetterDetail.Para.mob_num).AliasName))
                    x_oEventLetterDetailRow.mob_num = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EventLetterDetail.Para.mob_num).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EventLetterDetail.Para.doc_id).AliasName))
                    x_oEventLetterDetailRow.doc_id = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EventLetterDetail.Para.doc_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EventLetterDetail.Para.name).AliasName))
                    x_oEventLetterDetailRow.name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EventLetterDetail.Para.name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EventLetterDetail.Para.prem_desc).AliasName))
                    x_oEventLetterDetailRow.prem_desc = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EventLetterDetail.Para.prem_desc).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EventLetterDetail.Para.Remarks).AliasName))
                    x_oEventLetterDetailRow.Remarks = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EventLetterDetail.Para.Remarks).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EventLetterDetail.Para.accnt_cd).AliasName))
                    x_oEventLetterDetailRow.accnt_cd = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EventLetterDetail.Para.accnt_cd).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EventLetterDetail.Para.lett_sent_date).AliasName))
                    x_oEventLetterDetailRow.lett_sent_date = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EventLetterDetail.Para.lett_sent_date).AliasName];
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
            return EventLetterDetailRepository.GetCount(x_oDB);
        }
        #endregion


        #region Get

        // ******************************
        // *  Handler for Data Getting
        // ******************************

        public static EventLetterDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            return EventLetterDetailRepository.GetArrayObj(x_oDB, x_oColumnName, x_oArrayItemId);
        }

        public static EventLetterDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder)
        {
            return EventLetterDetailRepository.GetArrayObj(x_oDB, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        #endregion


        #region List

        // ******************************
        // *  Handler for Data Listing
        // ******************************

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return EventLetterDetailRepository.GetDataSet(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return EventLetterDetailRepository.GetSearch(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            return EventLetterDetailRepository.GetDataSet(x_oDB, x_sFilter);
        }
        #endregion

        #region Insert

        // ******************************
        // *  Handler for Data Inserting
        // ******************************

        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate, string x_sCid, global::System.Nullable<bool> x_bActive, string x_sMob_num, string x_sDoc_id, string x_sName, string x_sPrem_desc, string x_sRemarks, string x_sAccnt_cd, string x_sLett_sent_date)
        {
            return EventLetterDetailRepository.Insert(x_oDB, x_dCdate, x_sCid, x_bActive, x_sMob_num, x_sDoc_id, x_sName, x_sPrem_desc, x_sRemarks, x_sAccnt_cd, x_sLett_sent_date);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, EventLetterDetail x_oEventLetterDetail)
        {
            return EventLetterDetailRepository.InsertWithOutLastID(x_oDB, x_oEventLetterDetail);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate, string x_sCid, global::System.Nullable<bool> x_bActive, string x_sMob_num, string x_sDoc_id, string x_sName, string x_sPrem_desc, string x_sRemarks, string x_sAccnt_cd, string x_sLett_sent_date)
        {
            return EventLetterDetailRepository.InsertReturnLastID_SP(x_oDB, x_dCdate, x_sCid, x_bActive, x_sMob_num, x_sDoc_id, x_sName, x_sPrem_desc, x_sRemarks, x_sAccnt_cd, x_sLett_sent_date);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, EventLetterDetail x_oEventLetterDetail)
        {
            return EventLetterDetailRepository.InsertReturnLastID_SP(x_oDB, x_oEventLetterDetail);
        }

        #endregion

        #region Delete

        // ******************************
        // *  Handler for Data Deleting
        // ******************************

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            return EventLetterDetailRepository.DeleteAll(x_oDB);
        }

        public static bool DeleteFilter(MSSQLConnect x_oDB, string x_sFilter)
        {
            return EventLetterDetailRepository.DeleteFilter(x_oDB, x_sFilter);
        }

        public static bool Delete(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            return EventLetterDetailRepository.Delete(x_oDB, x_iId);
        }


        #endregion

        #region Delete Uploaded Files

        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(EventLetterDetail x_oEventLetterDetailRow)
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

