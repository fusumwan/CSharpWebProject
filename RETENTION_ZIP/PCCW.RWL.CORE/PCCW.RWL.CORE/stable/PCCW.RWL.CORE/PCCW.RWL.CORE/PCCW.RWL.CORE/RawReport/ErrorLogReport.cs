using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Text;
using System.IO;
///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2010-07-29>
///-- Description:	<Description,Class :ErrorLogReport, Data Report Control>
///-- =============================================
namespace PCCW.RWL.CORE{
    public class ErrorLogReport : IDisposable
    {
        #region Constructor & Destructor
        public ErrorLogReport(Page x_oPage, string x_sContentType)
        {
            if (x_sContentType != null) x_sContentType = x_sContentType.Trim();
            if (x_oPage != null && !string.IsNullOrEmpty(x_sContentType))
            {
                this.Page = x_oPage;
                this.ContentType = x_sContentType;
                this.ErrorLogInfo = ErrorLogInfo.CreateInfoInstanceObject();
                this.TableSetUp();
                this.Ds = ErrorLogBal.ToEmptyDataSet(this.ErrorLogInfo);
                this.Dt = this.Ds.Tables[ErrorLog.Para.TableName()];
                this.ReportHtmlTable = new HtmlTable();
                this.ReportHtmlTable.Border = 1;
            }
        }
        ~ErrorLogReport() { }
        #endregion Constructor & Destructor
        #region Export Report
        public bool ExportReport()
        {
            if (this.Ds == null) { return false; }
            if (this.Dt == null) { return false; }
            if (this.Page == null) { return false; }
            if (this.ReportHtmlTable == null) { return false; }
            if (this.ErrorLogInfo == null) { return false; }
            if (string.IsNullOrEmpty(this.FileName)) { return false; }
            if (string.IsNullOrEmpty(this.ContentType)) { return false; }
            DataSet _oDs = this.GetDataSet();
            if (_oDs != null)
            {
                HtmlTable _oHtmlTable = this.GetReportHtmlTable();
                HtmlTableRow _oHeadRow = new HtmlTableRow();
                ErrorLogInfo _oErrorLogInfo = this.GetErrorLogInfo();
                SortedDictionary<int, HtmlTableCell> _oKeyHtmlHead = new SortedDictionary<int, HtmlTableCell>();
                SortedDictionary<int, int> _oKeyHtmlRowMap = new SortedDictionary<int, int>();
                for (int i = 0; i < _oDs.Tables[ErrorLog.Para.TableName()].Columns.Count; i++)
                {
                    DataColumn _oCol = _oDs.Tables[ErrorLog.Para.TableName()].Columns[i];
                    HtmlTableCell _oHtmlTableCell = new HtmlTableCell();
                    Field _oField = _oErrorLogInfo.GetTableSet().Fields(_oCol.ColumnName);
                    _oHtmlTableCell.Controls.Add(new LiteralControl(_oField.ReportColumnName.ToString()));
                    if (_oField.ReportColumnIndex >= 0 && !_oKeyHtmlHead.ContainsKey(_oField.ReportColumnIndex) && !_oKeyHtmlRowMap.ContainsKey(i))
                    {
                        _oKeyHtmlHead.Add(_oField.ReportColumnIndex, _oHtmlTableCell);
                        _oKeyHtmlRowMap.Add(i, _oField.ReportColumnIndex);
                    }
                }
                foreach (KeyValuePair<int, HtmlTableCell> _oKeyHead in _oKeyHtmlHead)
                _oHeadRow.Controls.Add(_oKeyHead.Value);
                _oHtmlTable.Controls.Add(_oHeadRow);
                for (int i = 0; i < _oDs.Tables[ErrorLog.Para.TableName()].Rows.Count; i++)
                {
                    DataRow _oDataRow = _oDs.Tables[ErrorLog.Para.TableName()].Rows[i];
                    HtmlTableRow _oTableRow = new HtmlTableRow();
                    SortedDictionary<int, HtmlTableCell> _oKeyHtmlRow = new SortedDictionary<int, HtmlTableCell>();
                    for (int r = 0; r < _oDs.Tables[ErrorLog.Para.TableName()].Columns.Count; r++)
                    {
                        HtmlTableCell _oHtmlTableCell = new HtmlTableCell();
                        _oHtmlTableCell.Controls.Add(new LiteralControl(_oDataRow[r].ToString()));
                        if (_oKeyHtmlRowMap.ContainsKey(r))
                        _oKeyHtmlRow.Add(_oKeyHtmlRowMap[r], _oHtmlTableCell);
                    }
                    foreach (KeyValuePair<int, HtmlTableCell> _oKeyRow in _oKeyHtmlRow)
                    _oTableRow.Controls.Add(_oKeyRow.Value);
                    _oHtmlTable.Controls.Add(_oTableRow);
                }
                this.Page.Response.Clear();
                this.Page.Response.Buffer = true;
                this.Page.Response.AddHeader("content-disposition", "attachment; filename=" + this.FileName);
                this.Page.Response.ContentType = this.ContentType;
                StringWriter _oTw = new StringWriter();
                HtmlTextWriter _oHw = new HtmlTextWriter(_oTw);
                _oHtmlTable.RenderControl(_oHw);
                this.Page.Response.Write(_oTw.ToString());
                this.Page.Response.Flush();
            }
            else
            return false;
            return true;
        }
        #endregion
        #region GetDataSet
        protected DataSet GetDataSet()
        {
            if (this.Ds == null) return null;
            if (this.Dt == null) return null;
            if (this.Page == null) return null;
            if (this.ReportHtmlTable == null) return null;
            if (this.ErrorLogInfo == null) return null;
            if (string.IsNullOrEmpty(this.FileName)) return null;
            if (string.IsNullOrEmpty(this.ContentType)) return null;
            IList<ErrorLogEntity> _oErrorLogList = ErrorLogDalDAO.FindAll(this.StartRecordIndex, this.LimitRecordIndex, ErrorLog.Para.id);
            for (int i = 0; i < _oErrorLogList.Count; i++)
            {
                DataRow _oRw = this.Dt.NewRow();
                if (this.ErrorLogInfo.GetTableSet().Fields(ErrorLog.Para.uid).IsView) { _oRw[ErrorLog.Para.uid] = _oErrorLogList[i].uid; }
                if (this.ErrorLogInfo.GetTableSet().Fields(ErrorLog.Para.id).IsView) { _oRw[ErrorLog.Para.id] = _oErrorLogList[i].id; }
                if (this.ErrorLogInfo.GetTableSet().Fields(ErrorLog.Para.ip).IsView) { _oRw[ErrorLog.Para.ip] = _oErrorLogList[i].ip; }
                if (this.ErrorLogInfo.GetTableSet().Fields(ErrorLog.Para.page).IsView) { _oRw[ErrorLog.Para.page] = _oErrorLogList[i].page; }
                if (this.ErrorLogInfo.GetTableSet().Fields(ErrorLog.Para.stack_trace).IsView) { _oRw[ErrorLog.Para.stack_trace] = _oErrorLogList[i].stack_trace; }
                if (this.ErrorLogInfo.GetTableSet().Fields(ErrorLog.Para.log_date).IsView) { _oRw[ErrorLog.Para.log_date] = _oErrorLogList[i].log_date; }
                if (this.ErrorLogInfo.GetTableSet().Fields(ErrorLog.Para.err_msg).IsView) { _oRw[ErrorLog.Para.err_msg] = _oErrorLogList[i].err_msg; }
                this.Dt.Rows.Add(_oRw);
            }
            return this.Ds;
        }
        #endregion
        #region TableSetUp
        public bool TableSetUp()
        {
            if (this.ErrorLogInfo == null) return false;
            #region Report Column Index Setting
            this.ErrorLogInfo.GetTableSet().Fields(ErrorLog.Para.uid).ReportColumnIndex = 0;
            this.ErrorLogInfo.GetTableSet().Fields(ErrorLog.Para.id).ReportColumnIndex = 1;
            this.ErrorLogInfo.GetTableSet().Fields(ErrorLog.Para.ip).ReportColumnIndex = 2;
            this.ErrorLogInfo.GetTableSet().Fields(ErrorLog.Para.page).ReportColumnIndex = 3;
            this.ErrorLogInfo.GetTableSet().Fields(ErrorLog.Para.stack_trace).ReportColumnIndex = 4;
            this.ErrorLogInfo.GetTableSet().Fields(ErrorLog.Para.log_date).ReportColumnIndex = 5;
            this.ErrorLogInfo.GetTableSet().Fields(ErrorLog.Para.err_msg).ReportColumnIndex = 6;
            #endregion
            #region Report Column Name Setting
            this.ErrorLogInfo.GetTableSet().Fields(ErrorLog.Para.uid).ReportColumnName = "uid";
            this.ErrorLogInfo.GetTableSet().Fields(ErrorLog.Para.id).ReportColumnName = "id";
            this.ErrorLogInfo.GetTableSet().Fields(ErrorLog.Para.ip).ReportColumnName = "ip";
            this.ErrorLogInfo.GetTableSet().Fields(ErrorLog.Para.page).ReportColumnName = "page";
            this.ErrorLogInfo.GetTableSet().Fields(ErrorLog.Para.stack_trace).ReportColumnName = "stack_trace";
            this.ErrorLogInfo.GetTableSet().Fields(ErrorLog.Para.log_date).ReportColumnName = "log_date";
            this.ErrorLogInfo.GetTableSet().Fields(ErrorLog.Para.err_msg).ReportColumnName = "err_msg";
            #endregion
            #region Report View Setting
            SetAllView(true);
            #endregion
            return true;
        }
        #endregion
        
        #region ResetTable
        public void ResetTable(ErrorLogInfo x_oErrorLogInfo)
        {
            this.ErrorLogInfo = x_oErrorLogInfo;
            this.Ds = ErrorLogBal.ToEmptyDataSet(this.ErrorLogInfo);
            this.Dt = this.Ds.Tables[ErrorLog.Para.TableName()];
        }
        #endregion
        
        #region SetAllView
        public void SetAllView(bool x_bView)
        {
            this.ErrorLogInfo.GetTableSet().Fields(ErrorLog.Para.uid).IsView = true;
            this.ErrorLogInfo.GetTableSet().Fields(ErrorLog.Para.id).IsView = true;
            this.ErrorLogInfo.GetTableSet().Fields(ErrorLog.Para.ip).IsView = true;
            this.ErrorLogInfo.GetTableSet().Fields(ErrorLog.Para.page).IsView = true;
            this.ErrorLogInfo.GetTableSet().Fields(ErrorLog.Para.stack_trace).IsView = true;
            this.ErrorLogInfo.GetTableSet().Fields(ErrorLog.Para.log_date).IsView = true;
            this.ErrorLogInfo.GetTableSet().Fields(ErrorLog.Para.err_msg).IsView = true;
        }
        #endregion
        protected int n_oStartRecordIndex = -1;
        #region StartRecordIndex
        public int StartRecordIndex
        {
            get
            {
                return this.n_oStartRecordIndex;
            }
            set
            {
                this.n_oStartRecordIndex = value;
            }
        }
        #endregion StartRecordIndex
        protected int n_oLimitRecordIndex = -1;
        #region LimitRecordIndex
        public int LimitRecordIndex
        {
            get
            {
                return this.n_oLimitRecordIndex;
            }
            set
            {
                this.n_oLimitRecordIndex = value;
            }
        }
        #endregion LimitRecordIndex
        protected HtmlTable n_oReportHtmlTable = null;
        #region ReportHtmlTable
        public HtmlTable ReportHtmlTable
        {
            get
            {
                return this.n_oReportHtmlTable;
            }
            set
            {
                this.n_oReportHtmlTable = value;
            }
        }
        #endregion ReportHtmlTable
        protected DataSet n_oDs = null;
        #region Ds
        public DataSet Ds
        {
            get
            {
                return this.n_oDs;
            }
            set
            {
                this.n_oDs = value;
            }
        }
        #endregion Ds
        protected string n_sFileName = global::System.String.Empty;
        #region FileName
        public string FileName
        {
            get
            {
                return this.n_sFileName;
            }
            set
            {
                this.n_sFileName = value;
            }
        }
        #endregion FileName
        protected Page n_oPage = new Page();
        #region Page
        public Page Page
        {
            get
            {
                return this.n_oPage;
            }
            set
            {
                this.n_oPage = value;
            }
        }
        #endregion Page
        protected string n_sContentType = global::System.String.Empty; //"application/x-excel";
        #region ContentType
        public string ContentType
        {
            get
            {
                return this.n_sContentType;
            }
            set
            {
                this.n_sContentType = value;
            }
        }
        #endregion ContentType
        protected DataTable n_oDt = null;
        #region Dt
        public DataTable Dt
        {
            get
            {
                return this.n_oDt;
            }
            set
            {
                this.n_oDt = value;
            }
        }
        #endregion Dt
        protected ErrorLogInfo n_oErrorLogInfo = null;
        #region ErrorLogInfo
        public ErrorLogInfo ErrorLogInfo
        {
            get
            {
                return this.n_oErrorLogInfo;
            }
            set
            {
                this.n_oErrorLogInfo = value;
            }
        }
        #endregion ErrorLogInfo
        
        #region Get & Set
        public int GetStartRecordIndex() { return this.StartRecordIndex; }
        public int GetLimitRecordIndex() { return this.LimitRecordIndex; }
        public HtmlTable GetReportHtmlTable() { return this.ReportHtmlTable; }
        public DataSet GetDs() { return this.Ds; }
        public string GetFileName() { return this.FileName; }
        public Page GetPage() { return this.Page; }
        public string GetContentType() { return this.ContentType; }
        public DataTable GetDt() { return this.Dt; }
        public ErrorLogInfo GetErrorLogInfo() { return this.ErrorLogInfo; }
        public bool SetStartRecordIndex(int value)
        {
            this.StartRecordIndex = value;
            return true;
        }
        public bool SetLimitRecordIndex(int value)
        {
            this.LimitRecordIndex = value;
            return true;
        }
        public bool SetReportHtmlTable(HtmlTable value)
        {
            this.ReportHtmlTable = value;
            return true;
        }
        public bool SetDs(DataSet value)
        {
            this.Ds = value;
            return true;
        }
        public bool SetFileName(string value)
        {
            this.FileName = value;
            return true;
        }
        public bool SetPage(Page value)
        {
            this.Page = value;
            return true;
        }
        public bool SetContentType(string value)
        {
            this.ContentType = value;
            return true;
        }
        public bool SetDt(DataTable value)
        {
            this.Dt = value;
            return true;
        }
        public bool SetErrorLogInfo(ErrorLogInfo value)
        {
            this.ErrorLogInfo = value;
            return true;
        }
        #endregion
        #region Equals
        public bool Equals(ErrorLogReport x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.StartRecordIndex.Equals(x_oObj.StartRecordIndex)) { return false; }
            if (!this.LimitRecordIndex.Equals(x_oObj.LimitRecordIndex)) { return false; }
            if (!this.ReportHtmlTable.Equals(x_oObj.ReportHtmlTable)) { return false; }
            if (!this.Ds.Equals(x_oObj.Ds)) { return false; }
            if (!this.FileName.Equals(x_oObj.FileName)) { return false; }
            if (!this.Page.Equals(x_oObj.Page)) { return false; }
            if (!this.ContentType.Equals(x_oObj.ContentType)) { return false; }
            if (!this.Dt.Equals(x_oObj.Dt)) { return false; }
            if (!this.ErrorLogInfo.Equals(x_oObj.ErrorLogInfo)) { return false; }
            return true;
        }
        #endregion Equals
        #region Release
        public void Release()
        {
            this.StartRecordIndex = -1;
            this.LimitRecordIndex = -1;
            this.ReportHtmlTable = null;
            this.Ds = null;
            this.FileName = global::System.String.Empty;
            this.Page = null;
            this.ContentType = global::System.String.Empty;
            this.Dt = null;
            this.ErrorLogInfo = null;
        }
        #endregion Release
        #region Clone
        public ErrorLogReport DeepClone()
        {
            ErrorLogReport ErrorLogReport_Clone = new ErrorLogReport(null,null);
            ErrorLogReport_Clone.SetStartRecordIndex(this.StartRecordIndex);
            ErrorLogReport_Clone.SetLimitRecordIndex(this.LimitRecordIndex);
            ErrorLogReport_Clone.SetReportHtmlTable(this.ReportHtmlTable);
            ErrorLogReport_Clone.SetDs(this.Ds);
            ErrorLogReport_Clone.SetFileName(this.FileName);
            ErrorLogReport_Clone.SetPage(this.Page);
            ErrorLogReport_Clone.SetContentType(this.ContentType);
            ErrorLogReport_Clone.SetDt(this.Dt);
            ErrorLogReport_Clone.SetErrorLogInfo(this.ErrorLogInfo);
            return ErrorLogReport_Clone;
        }
        #endregion Clone
        void IDisposable.Dispose()
        {
            this.Dispose();
        }
        public void Dispose()
        {
        }
    }
}

