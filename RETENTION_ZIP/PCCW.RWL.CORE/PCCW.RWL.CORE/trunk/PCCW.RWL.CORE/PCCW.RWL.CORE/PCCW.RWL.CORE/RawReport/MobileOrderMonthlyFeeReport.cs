﻿using System;
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
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-10-05>
///-- Description:	<Description,Class :MobileOrderMonthlyFeeReport, Data Report Control>
///-- =============================================
namespace PCCW.RWL.CORE
{
    public class MobileOrderMonthlyFeeReport : IDisposable
    {
        #region Constructor & Destructor
        public MobileOrderMonthlyFeeReport(Page x_oPage, string x_sContentType)
        {
            if (x_sContentType != null) x_sContentType = x_sContentType.Trim();
            if (x_oPage != null && !string.IsNullOrEmpty(x_sContentType))
            {
                this.Page = x_oPage;
                this.ContentType = x_sContentType;
                this.MobileOrderMonthlyFeeInfo = MobileOrderMonthlyFeeInfo.CreateInfoInstanceObject();
                this.TableSetUp();
                this.Ds = MobileOrderMonthlyFeeBal.ToEmptyDataSet(this.MobileOrderMonthlyFeeInfo);
                this.Dt = this.Ds.Tables[MobileOrderMonthlyFee.Para.TableName()];
                this.ReportHtmlTable = new HtmlTable();
                this.ReportHtmlTable.Border = 1;
            }
        }
        ~MobileOrderMonthlyFeeReport() { }
        #endregion Constructor & Destructor
        #region Export Report
        public bool ExportReport()
        {
            if (this.Ds == null) { return false; }
            if (this.Dt == null) { return false; }
            if (this.Page == null) { return false; }
            if (this.ReportHtmlTable == null) { return false; }
            if (this.MobileOrderMonthlyFeeInfo == null) { return false; }
            if (string.IsNullOrEmpty(this.FileName)) { return false; }
            if (string.IsNullOrEmpty(this.ContentType)) { return false; }
            DataSet _oDs = this.GetDataSet();
            if (_oDs != null)
            {
                HtmlTable _oHtmlTable = this.GetReportHtmlTable();
                HtmlTableRow _oHeadRow = new HtmlTableRow();
                MobileOrderMonthlyFeeInfo _oMobileOrderMonthlyFeeInfo = this.GetMobileOrderMonthlyFeeInfo();
                SortedDictionary<int, HtmlTableCell> _oKeyHtmlHead = new SortedDictionary<int, HtmlTableCell>();
                SortedDictionary<int, int> _oKeyHtmlRowMap = new SortedDictionary<int, int>();
                for (int i = 0; i < _oDs.Tables[MobileOrderMonthlyFee.Para.TableName()].Columns.Count; i++)
                {
                    DataColumn _oCol = _oDs.Tables[MobileOrderMonthlyFee.Para.TableName()].Columns[i];
                    HtmlTableCell _oHtmlTableCell = new HtmlTableCell();
                    Field _oField = _oMobileOrderMonthlyFeeInfo.GetTableSet().Fields(_oCol.ColumnName);
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
                for (int i = 0; i < _oDs.Tables[MobileOrderMonthlyFee.Para.TableName()].Rows.Count; i++)
                {
                    DataRow _oDataRow = _oDs.Tables[MobileOrderMonthlyFee.Para.TableName()].Rows[i];
                    HtmlTableRow _oTableRow = new HtmlTableRow();
                    SortedDictionary<int, HtmlTableCell> _oKeyHtmlRow = new SortedDictionary<int, HtmlTableCell>();
                    for (int r = 0; r < _oDs.Tables[MobileOrderMonthlyFee.Para.TableName()].Columns.Count; r++)
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
            if (this.MobileOrderMonthlyFeeInfo == null) return null;
            if (string.IsNullOrEmpty(this.FileName)) return null;
            if (string.IsNullOrEmpty(this.ContentType)) return null;
            IList<MobileOrderMonthlyFeeEntity> _oMobileOrderMonthlyFeeList = MobileOrderMonthlyFeeDalDAO.FindAll(this.StartRecordIndex, this.LimitRecordIndex, MobileOrderMonthlyFee.Para.mid);
            for (int i = 0; i < _oMobileOrderMonthlyFeeList.Count; i++)
            {
                if (_oMobileOrderMonthlyFeeList[i].active == true)
                {
                    DataRow _oRw = this.Dt.NewRow();
                    if (this.MobileOrderMonthlyFeeInfo.GetTableSet().Fields(MobileOrderMonthlyFee.Para.mid).IsView) { _oRw[MobileOrderMonthlyFee.Para.mid] = _oMobileOrderMonthlyFeeList[i].mid; }
                    if (this.MobileOrderMonthlyFeeInfo.GetTableSet().Fields(MobileOrderMonthlyFee.Para.mon).IsView) { _oRw[MobileOrderMonthlyFee.Para.mon] = _oMobileOrderMonthlyFeeList[i].mon; }
                    if (this.MobileOrderMonthlyFeeInfo.GetTableSet().Fields(MobileOrderMonthlyFee.Para.fee).IsView) { _oRw[MobileOrderMonthlyFee.Para.fee] = _oMobileOrderMonthlyFeeList[i].fee; }
                    if (this.MobileOrderMonthlyFeeInfo.GetTableSet().Fields(MobileOrderMonthlyFee.Para.active).IsView) { _oRw[MobileOrderMonthlyFee.Para.active] = _oMobileOrderMonthlyFeeList[i].active; }
                    if (this.MobileOrderMonthlyFeeInfo.GetTableSet().Fields(MobileOrderMonthlyFee.Para.free_mon).IsView) { _oRw[MobileOrderMonthlyFee.Para.free_mon] = _oMobileOrderMonthlyFeeList[i].free_mon; }
                    this.Dt.Rows.Add(_oRw);
                }
            }
            return this.Ds;
        }
        #endregion
        #region TableSetUp
        public bool TableSetUp()
        {
            if (this.MobileOrderMonthlyFeeInfo == null) return false;
            #region Report Column Index Setting
            this.MobileOrderMonthlyFeeInfo.GetTableSet().Fields(MobileOrderMonthlyFee.Para.mid).ReportColumnIndex = 0;
            this.MobileOrderMonthlyFeeInfo.GetTableSet().Fields(MobileOrderMonthlyFee.Para.mon).ReportColumnIndex = 1;
            this.MobileOrderMonthlyFeeInfo.GetTableSet().Fields(MobileOrderMonthlyFee.Para.fee).ReportColumnIndex = 2;
            this.MobileOrderMonthlyFeeInfo.GetTableSet().Fields(MobileOrderMonthlyFee.Para.active).ReportColumnIndex = 3;
            this.MobileOrderMonthlyFeeInfo.GetTableSet().Fields(MobileOrderMonthlyFee.Para.free_mon).ReportColumnIndex = 4;
            #endregion
            #region Report Column Name Setting
            this.MobileOrderMonthlyFeeInfo.GetTableSet().Fields(MobileOrderMonthlyFee.Para.mid).ReportColumnName = "mid";
            this.MobileOrderMonthlyFeeInfo.GetTableSet().Fields(MobileOrderMonthlyFee.Para.mon).ReportColumnName = "mon";
            this.MobileOrderMonthlyFeeInfo.GetTableSet().Fields(MobileOrderMonthlyFee.Para.fee).ReportColumnName = "fee";
            this.MobileOrderMonthlyFeeInfo.GetTableSet().Fields(MobileOrderMonthlyFee.Para.active).ReportColumnName = "active";
            this.MobileOrderMonthlyFeeInfo.GetTableSet().Fields(MobileOrderMonthlyFee.Para.free_mon).ReportColumnName = "free_mon";
            #endregion
            #region Report View Setting
            this.MobileOrderMonthlyFeeInfo.GetTableSet().Fields(MobileOrderMonthlyFee.Para.mid).IsView = true;
            this.MobileOrderMonthlyFeeInfo.GetTableSet().Fields(MobileOrderMonthlyFee.Para.mon).IsView = true;
            this.MobileOrderMonthlyFeeInfo.GetTableSet().Fields(MobileOrderMonthlyFee.Para.fee).IsView = true;
            this.MobileOrderMonthlyFeeInfo.GetTableSet().Fields(MobileOrderMonthlyFee.Para.active).IsView = true;
            this.MobileOrderMonthlyFeeInfo.GetTableSet().Fields(MobileOrderMonthlyFee.Para.free_mon).IsView = true;
            #endregion
            return true;
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
        protected MobileOrderMonthlyFeeInfo n_oMobileOrderMonthlyFeeInfo = null;
        #region MobileOrderMonthlyFeeInfo
        public MobileOrderMonthlyFeeInfo MobileOrderMonthlyFeeInfo
        {
            get
            {
                return this.n_oMobileOrderMonthlyFeeInfo;
            }
            set
            {
                this.n_oMobileOrderMonthlyFeeInfo = value;
            }
        }
        #endregion MobileOrderMonthlyFeeInfo

        #region Get & Set
        public int GetStartRecordIndex() { return this.StartRecordIndex; }
        public int GetLimitRecordIndex() { return this.LimitRecordIndex; }
        public HtmlTable GetReportHtmlTable() { return this.ReportHtmlTable; }
        public DataSet GetDs() { return this.Ds; }
        public string GetFileName() { return this.FileName; }
        public Page GetPage() { return this.Page; }
        public string GetContentType() { return this.ContentType; }
        public DataTable GetDt() { return this.Dt; }
        public MobileOrderMonthlyFeeInfo GetMobileOrderMonthlyFeeInfo() { return this.MobileOrderMonthlyFeeInfo; }
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
        public bool SetMobileOrderMonthlyFeeInfo(MobileOrderMonthlyFeeInfo value)
        {
            this.MobileOrderMonthlyFeeInfo = value;
            return true;
        }
        #endregion
        #region Equals
        public bool Equals(MobileOrderMonthlyFeeReport x_oObj)
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
            if (!this.MobileOrderMonthlyFeeInfo.Equals(x_oObj.MobileOrderMonthlyFeeInfo)) { return false; }
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
            this.MobileOrderMonthlyFeeInfo = null;
        }
        #endregion Release
        #region Clone
        public MobileOrderMonthlyFeeReport DeepClone()
        {
            MobileOrderMonthlyFeeReport MobileOrderMonthlyFeeReport_Clone = new MobileOrderMonthlyFeeReport(null, null);
            MobileOrderMonthlyFeeReport_Clone.SetStartRecordIndex(this.StartRecordIndex);
            MobileOrderMonthlyFeeReport_Clone.SetLimitRecordIndex(this.LimitRecordIndex);
            MobileOrderMonthlyFeeReport_Clone.SetReportHtmlTable(this.ReportHtmlTable);
            MobileOrderMonthlyFeeReport_Clone.SetDs(this.Ds);
            MobileOrderMonthlyFeeReport_Clone.SetFileName(this.FileName);
            MobileOrderMonthlyFeeReport_Clone.SetPage(this.Page);
            MobileOrderMonthlyFeeReport_Clone.SetContentType(this.ContentType);
            MobileOrderMonthlyFeeReport_Clone.SetDt(this.Dt);
            MobileOrderMonthlyFeeReport_Clone.SetMobileOrderMonthlyFeeInfo(this.MobileOrderMonthlyFeeInfo);
            return MobileOrderMonthlyFeeReport_Clone;
        }
        #endregion Clone
        void global::System.IDisposable.Dispose()
        {
            this.Dispose();
        }
        public void Dispose()
        {
        }
    }
}
