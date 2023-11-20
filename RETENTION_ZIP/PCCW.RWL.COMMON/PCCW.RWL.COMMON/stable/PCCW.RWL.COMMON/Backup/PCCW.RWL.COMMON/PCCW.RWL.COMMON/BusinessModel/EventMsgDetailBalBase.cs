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
///-- Description:	<Description,Table :[EventMsgDetail],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [EventMsgDetail] Business layer
    /// </summary>

    public abstract class EventMsgDetailBalBase
    {

        #region Constructor


        // ******************************
        // *  Handler for Class Constructor
        // ******************************

        public EventMsgDetailBalBase()
        {
        }
        ~EventMsgDetailBalBase()
        {
            this.Release();
        }
        #endregion


        #region ToDataSet


        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************

        public static global::System.Data.DataSet ToDataSet(EventMsgDetail x_oEventMsgDetail)
        {
            return GetDataSet(x_oEventMsgDetail, null, EventMsgDetailInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(EventMsgDetail x_oEventMsgDetail, global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oEventMsgDetail, x_oMergeDSet, EventMsgDetailInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToDataSet(EventMsgDetail x_oEventMsgDetail, EventMsgDetailInfo x_oTableSet)
        {
            return GetDataSet(x_oEventMsgDetail, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToDataSet(EventMsgDetail x_oEventMsgDetail, global::System.Data.DataSet x_oMergeDSet, EventMsgDetailInfo x_oTableSet)
        {
            return GetDataSet(x_oEventMsgDetail, x_oMergeDSet, x_oTableSet);
        }


        protected static global::System.Data.DataSet GetDataSet(EventMsgDetail x_oEventMsgDetail, global::System.Data.DataSet x_oMergeDSet, EventMsgDetailInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = EventMsgDetailInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(EventMsgDetail.Para.TableName());
            if (x_oTableSet.Fields(EventMsgDetail.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EventMsgDetail.Para.TableName()].Columns.Add(EventMsgDetail.Para.cdate); }
            if (x_oTableSet.Fields(EventMsgDetail.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EventMsgDetail.Para.TableName()].Columns.Add(EventMsgDetail.Para.active); }
            if (x_oTableSet.Fields(EventMsgDetail.Para.access_right).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EventMsgDetail.Para.TableName()].Columns.Add(EventMsgDetail.Para.access_right); }
            if (x_oTableSet.Fields(EventMsgDetail.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EventMsgDetail.Para.TableName()].Columns.Add(EventMsgDetail.Para.cid); }
            if (x_oTableSet.Fields(EventMsgDetail.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EventMsgDetail.Para.TableName()].Columns.Add(EventMsgDetail.Para.did); }
            if (x_oTableSet.Fields(EventMsgDetail.Para.message).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EventMsgDetail.Para.TableName()].Columns.Add(EventMsgDetail.Para.message); }
            if (x_oTableSet.Fields(EventMsgDetail.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EventMsgDetail.Para.TableName()].Columns.Add(EventMsgDetail.Para.edate); }
            if (x_oTableSet.Fields(EventMsgDetail.Para.subject).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EventMsgDetail.Para.TableName()].Columns.Add(EventMsgDetail.Para.subject); }
            if (x_oTableSet.Fields(EventMsgDetail.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EventMsgDetail.Para.TableName()].Columns.Add(EventMsgDetail.Para.ddate); }
            if (x_oTableSet.Fields(EventMsgDetail.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EventMsgDetail.Para.TableName()].Columns.Add(EventMsgDetail.Para.mid); }
            if (x_oTableSet.Fields(EventMsgDetail.Para.sdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[EventMsgDetail.Para.TableName()].Columns.Add(EventMsgDetail.Para.sdate); }
            if (x_oEventMsgDetail != null)
            {
                global::System.Data.DataRow _oDRow = _oDSet.Tables[EventMsgDetail.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(EventMsgDetail.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[EventMsgDetail.Para.cdate] = x_oEventMsgDetail.GetCdate(); }
                if (x_oTableSet.Fields(EventMsgDetail.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[EventMsgDetail.Para.active] = x_oEventMsgDetail.GetActive(); }
                if (x_oTableSet.Fields(EventMsgDetail.Para.access_right).IsView || x_oTableSet.GetViewAll()) { _oDRow[EventMsgDetail.Para.access_right] = x_oEventMsgDetail.GetAccess_right(); }
                if (x_oTableSet.Fields(EventMsgDetail.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[EventMsgDetail.Para.cid] = x_oEventMsgDetail.GetCid(); }
                if (x_oTableSet.Fields(EventMsgDetail.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[EventMsgDetail.Para.did] = x_oEventMsgDetail.GetDid(); }
                if (x_oTableSet.Fields(EventMsgDetail.Para.message).IsView || x_oTableSet.GetViewAll()) { _oDRow[EventMsgDetail.Para.message] = x_oEventMsgDetail.GetMessage(); }
                if (x_oTableSet.Fields(EventMsgDetail.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDRow[EventMsgDetail.Para.edate] = x_oEventMsgDetail.GetEdate(); }
                if (x_oTableSet.Fields(EventMsgDetail.Para.subject).IsView || x_oTableSet.GetViewAll()) { _oDRow[EventMsgDetail.Para.subject] = x_oEventMsgDetail.GetSubject(); }
                if (x_oTableSet.Fields(EventMsgDetail.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[EventMsgDetail.Para.ddate] = x_oEventMsgDetail.GetDdate(); }
                if (x_oTableSet.Fields(EventMsgDetail.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDRow[EventMsgDetail.Para.mid] = x_oEventMsgDetail.GetMid(); }
                if (x_oTableSet.Fields(EventMsgDetail.Para.sdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[EventMsgDetail.Para.sdate] = x_oEventMsgDetail.GetSdate(); }
                _oDSet.Tables[EventMsgDetail.Para.TableName()].Rows.Add(_oDRow);
            }
            if (x_oMergeDSet != null) { _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }


        protected static global::System.Data.DataSet ToEmptyDataSetProcess(EventMsgDetailInfo x_oTableSet)
        {
            return EventMsgDetailBal.GetDataSet(null, null, x_oTableSet);
        }


        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return EventMsgDetailBal.ToEmptyDataSetProcess(EventMsgDetailInfoDLL.CreateInfoInstanceObject());
        }


        public static global::System.Data.DataSet ToEmptyDataSet(EventMsgDetailInfo x_oTableSet)
        {
            return EventMsgDetailBal.ToEmptyDataSetProcess(x_oTableSet);
        }


        #endregion ToDataSet

        #region To Table

        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(EventMsgDetail x_oEventMsgDetail, EventMsgDetailInfo x_oTableSet)
        {
            return EventMsgDetailBal.GetDataSet(null, null, x_oTableSet).Tables[EventMsgDetail.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(EventMsgDetail x_oEventMsgDetail)
        {
            return EventMsgDetailBal.GetDataSet(x_oEventMsgDetail, null, EventMsgDetailInfoDLL.CreateInfoInstanceObject()).Tables[EventMsgDetail.Para.TableName()];
        }
        #endregion

        #region To Row

        // ******************************
        // *  Handler for Data DataRow
        // ******************************


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            return Row(x_oTable, x_oDB, x_iMid, EventMsgDetailInfoDLL.CreateInfoInstanceObject());
        }


        public static DataRow ToRow(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid, EventMsgDetailInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB, x_iMid, x_oTableSet);
        }

        public static DataRow Row(DataTable x_oTable, MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid, EventMsgDetailInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = EventMsgDetailInfoDLL.CreateInfoInstanceObject();
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                string _sQuery = "SELECT [EventMsgDetail].[cdate] AS EVENTMSGDETAIL_CDATE,[EventMsgDetail].[active] AS EVENTMSGDETAIL_ACTIVE,[EventMsgDetail].[access_right] AS EVENTMSGDETAIL_ACCESS_RIGHT,[EventMsgDetail].[cid] AS EVENTMSGDETAIL_CID,[EventMsgDetail].[did] AS EVENTMSGDETAIL_DID,[EventMsgDetail].[message] AS EVENTMSGDETAIL_MESSAGE,[EventMsgDetail].[edate] AS EVENTMSGDETAIL_EDATE,[EventMsgDetail].[subject] AS EVENTMSGDETAIL_SUBJECT,[EventMsgDetail].[ddate] AS EVENTMSGDETAIL_DDATE,[EventMsgDetail].[mid] AS EVENTMSGDETAIL_MID,[EventMsgDetail].[sdate] AS EVENTMSGDETAIL_SDATE  FROM  [EventMsgDetail]  WHERE  [EventMsgDetail].[mid] = \'" + x_iMid.ToString() + "\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[EventMsgDetail]", "[" + Configurator.MSSQLTablePrefix + "EventMsgDetail]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read())
                    {
                        if (x_oTableSet.Fields(EventMsgDetail.Para.cdate).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EventMsgDetail.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventMsgDetail.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["EVENTMSGDETAIL_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventMsgDetail.Para.cdate).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(EventMsgDetail.Para.active).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EventMsgDetail.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventMsgDetail.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["EVENTMSGDETAIL_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventMsgDetail.Para.active).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(EventMsgDetail.Para.access_right).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_ACCESS_RIGHT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EventMsgDetail.Para.access_right).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventMsgDetail.Para.access_right).AliasName].ToString()] = (string)_oData["EVENTMSGDETAIL_ACCESS_RIGHT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventMsgDetail.Para.access_right).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(EventMsgDetail.Para.cid).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EventMsgDetail.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventMsgDetail.Para.cid).AliasName].ToString()] = (string)_oData["EVENTMSGDETAIL_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventMsgDetail.Para.cid).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(EventMsgDetail.Para.did).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EventMsgDetail.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventMsgDetail.Para.did).AliasName].ToString()] = (string)_oData["EVENTMSGDETAIL_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventMsgDetail.Para.did).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(EventMsgDetail.Para.message).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_MESSAGE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EventMsgDetail.Para.message).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventMsgDetail.Para.message).AliasName].ToString()] = (string)_oData["EVENTMSGDETAIL_MESSAGE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventMsgDetail.Para.message).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(EventMsgDetail.Para.edate).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_EDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EventMsgDetail.Para.edate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventMsgDetail.Para.edate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["EVENTMSGDETAIL_EDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventMsgDetail.Para.edate).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(EventMsgDetail.Para.subject).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_SUBJECT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EventMsgDetail.Para.subject).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventMsgDetail.Para.subject).AliasName].ToString()] = (string)_oData["EVENTMSGDETAIL_SUBJECT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventMsgDetail.Para.subject).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(EventMsgDetail.Para.ddate).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EventMsgDetail.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventMsgDetail.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["EVENTMSGDETAIL_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventMsgDetail.Para.ddate).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(EventMsgDetail.Para.mid).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_MID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EventMsgDetail.Para.mid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventMsgDetail.Para.mid).AliasName].ToString()] = (global::System.Nullable<int>)_oData["EVENTMSGDETAIL_MID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventMsgDetail.Para.mid).AliasName].ToString()] = string.Empty;
                        }
                        if (x_oTableSet.Fields(EventMsgDetail.Para.sdate).IsView || x_oTableSet.GetViewAll())
                        {
                            if (!global::System.Convert.IsDBNull(_oData["EVENTMSGDETAIL_SDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(EventMsgDetail.Para.sdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventMsgDetail.Para.sdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["EVENTMSGDETAIL_SDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(EventMsgDetail.Para.sdate).AliasName].ToString()] = string.Empty;
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

        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet, EventMsgDetail x_oEventMsgDetailRow)
        {
            return SetByDataSetRowProc(x_iROW, EventMsgDetail.Para.TableName(), x_oDataSet, x_oEventMsgDetailRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, EventMsgDetail x_oEventMsgDetailRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet, x_oEventMsgDetailRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet, EventMsgDetail x_oEventMsgDetailRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                EventMsgDetailInfo _oTableSet = EventMsgDetailInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EventMsgDetail.Para.cdate).AliasName))
                    x_oEventMsgDetailRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EventMsgDetail.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EventMsgDetail.Para.active).AliasName))
                    x_oEventMsgDetailRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EventMsgDetail.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EventMsgDetail.Para.access_right).AliasName))
                    x_oEventMsgDetailRow.access_right = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EventMsgDetail.Para.access_right).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EventMsgDetail.Para.cid).AliasName))
                    x_oEventMsgDetailRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EventMsgDetail.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EventMsgDetail.Para.did).AliasName))
                    x_oEventMsgDetailRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EventMsgDetail.Para.did).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EventMsgDetail.Para.message).AliasName))
                    x_oEventMsgDetailRow.message = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EventMsgDetail.Para.message).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EventMsgDetail.Para.edate).AliasName))
                    x_oEventMsgDetailRow.edate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EventMsgDetail.Para.edate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EventMsgDetail.Para.subject).AliasName))
                    x_oEventMsgDetailRow.subject = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EventMsgDetail.Para.subject).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EventMsgDetail.Para.ddate).AliasName))
                    x_oEventMsgDetailRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EventMsgDetail.Para.ddate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EventMsgDetail.Para.mid).AliasName))
                    x_oEventMsgDetailRow.mid = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EventMsgDetail.Para.mid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(EventMsgDetail.Para.sdate).AliasName))
                    x_oEventMsgDetailRow.sdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(EventMsgDetail.Para.sdate).AliasName];
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
            return EventMsgDetailRepository.GetCount(x_oDB);
        }
        #endregion


        #region Get

        // ******************************
        // *  Handler for Data Getting
        // ******************************

        public static EventMsgDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            return EventMsgDetailRepository.GetArrayObj(x_oDB, x_oColumnName, x_oArrayItemId);
        }

        public static EventMsgDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder)
        {
            return EventMsgDetailRepository.GetArrayObj(x_oDB, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        #endregion


        #region List

        // ******************************
        // *  Handler for Data Listing
        // ******************************

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return EventMsgDetailRepository.GetDataSet(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return EventMsgDetailRepository.GetSearch(x_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            return EventMsgDetailRepository.GetDataSet(x_oDB, x_sFilter);
        }
        #endregion

        #region Insert

        // ******************************
        // *  Handler for Data Inserting
        // ******************************

        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate, global::System.Nullable<bool> x_bActive, string x_sAccess_right, string x_sCid, string x_sDid, string x_sMessage, global::System.Nullable<DateTime> x_dEdate, string x_sSubject, global::System.Nullable<DateTime> x_dDdate, global::System.Nullable<DateTime> x_dSdate)
        {
            return EventMsgDetailRepository.Insert(x_oDB, x_dCdate, x_bActive, x_sAccess_right, x_sCid, x_sDid, x_sMessage, x_dEdate, x_sSubject, x_dDdate, x_dSdate);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, EventMsgDetail x_oEventMsgDetail)
        {
            return EventMsgDetailRepository.InsertWithOutLastID(x_oDB, x_oEventMsgDetail);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate, global::System.Nullable<bool> x_bActive, string x_sAccess_right, string x_sCid, string x_sDid, string x_sMessage, global::System.Nullable<DateTime> x_dEdate, string x_sSubject, global::System.Nullable<DateTime> x_dDdate, global::System.Nullable<DateTime> x_dSdate)
        {
            return EventMsgDetailRepository.InsertReturnLastID_SP(x_oDB, x_dCdate, x_bActive, x_sAccess_right, x_sCid, x_sDid, x_sMessage, x_dEdate, x_sSubject, x_dDdate, x_dSdate);
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, EventMsgDetail x_oEventMsgDetail)
        {
            return EventMsgDetailRepository.InsertReturnLastID_SP(x_oDB, x_oEventMsgDetail);
        }

        #endregion

        #region Delete

        // ******************************
        // *  Handler for Data Deleting
        // ******************************

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            return EventMsgDetailRepository.DeleteAll(x_oDB);
        }

        public static bool DeleteFilter(MSSQLConnect x_oDB, string x_sFilter)
        {
            return EventMsgDetailRepository.DeleteFilter(x_oDB, x_sFilter);
        }

        public static bool Delete(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            return EventMsgDetailRepository.Delete(x_oDB, x_iMid);
        }


        #endregion

        #region Delete Uploaded Files

        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(EventMsgDetail x_oEventMsgDetailRow)
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

