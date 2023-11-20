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
///-- Create date: <Create Date 2010-03-02>
///-- Description:	<Description,Class :BundleMappingReport, Data Report Control>
///-- =============================================
namespace PCCW.RWL.CORE
{
    public class BundleMappingReport : IDisposable
    {
        #region Constructor & Destructor
        public BundleMappingReport(Page x_oPage, string x_sContentType)
        {
            if (x_sContentType != null) x_sContentType = x_sContentType.Trim();
            if (x_oPage != null && !string.IsNullOrEmpty(x_sContentType))
            {
                this.Page = x_oPage;
                this.ContentType = x_sContentType;
                this.BundleMappingInfo = BundleMappingInfo.CreateInfoInstanceObject();
                this.TableSetUp();
                this.Ds = BundleMappingBal.ToEmptyDataSet(this.BundleMappingInfo);
                this.Dt = this.Ds.Tables[BundleMapping.Para.TableName()];
                this.ReportHtmlTable = new HtmlTable();
                this.ReportHtmlTable.Border = 1;
            }
        }
        ~BundleMappingReport() { }
        #endregion Constructor & Destructor
        #region Export Report
        public bool ExportReport()
        {
            if (this.Ds == null) { return false; }
            if (this.Dt == null) { return false; }
            if (this.Page == null) { return false; }
            if (this.ReportHtmlTable == null) { return false; }
            if (this.BundleMappingInfo == null) { return false; }
            if (string.IsNullOrEmpty(this.FileName)) { return false; }
            if (string.IsNullOrEmpty(this.ContentType)) { return false; }
            DataSet _oDs = this.GetDataSet();
            if (_oDs != null)
            {
                HtmlTable _oHtmlTable = this.GetReportHtmlTable();
                HtmlTableRow _oHeadRow = new HtmlTableRow();
                BundleMappingInfo _oBundleMappingInfo = this.GetBundleMappingInfo();
                SortedDictionary<int, HtmlTableCell> _oKeyHtmlHead = new SortedDictionary<int, HtmlTableCell>();
                SortedDictionary<int, int> _oKeyHtmlRowMap = new SortedDictionary<int, int>();
                for (int i = 0; i < _oDs.Tables[BundleMapping.Para.TableName()].Columns.Count; i++)
                {
                    DataColumn _oCol = _oDs.Tables[BundleMapping.Para.TableName()].Columns[i];
                    HtmlTableCell _oHtmlTableCell = new HtmlTableCell();
                    Field _oField = _oBundleMappingInfo.GetTableSet().Fields(_oCol.ColumnName);
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
                for (int i = 0; i < _oDs.Tables[BundleMapping.Para.TableName()].Rows.Count; i++)
                {
                    DataRow _oDataRow = _oDs.Tables[BundleMapping.Para.TableName()].Rows[i];
                    HtmlTableRow _oTableRow = new HtmlTableRow();
                    SortedDictionary<int, HtmlTableCell> _oKeyHtmlRow = new SortedDictionary<int, HtmlTableCell>();
                    for (int r = 0; r < _oDs.Tables[BundleMapping.Para.TableName()].Columns.Count; r++)
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
            if (this.BundleMappingInfo == null) return null;
            if (string.IsNullOrEmpty(this.FileName)) return null;
            if (string.IsNullOrEmpty(this.ContentType)) return null;
            IList<BundleMappingEntity> _oBundleMappingList = BundleMappingDalDAO.FindAll(this.StartRecordIndex, this.LimitRecordIndex, BundleMapping.Para.id);
            for (int i = 0; i < _oBundleMappingList.Count; i++)
            {
                DataRow _oRw = this.Dt.NewRow();
                if (this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.id).IsView) { _oRw[BundleMapping.Para.id] = _oBundleMappingList[i].id; }
                if (this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.cdate).IsView) { _oRw[BundleMapping.Para.cdate] = _oBundleMappingList[i].cdate; }
                if (this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.cid).IsView) { _oRw[BundleMapping.Para.cid] = _oBundleMappingList[i].cid; }
                if (this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.active).IsView) { _oRw[BundleMapping.Para.active] = _oBundleMappingList[i].active; }
                if (this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.vas_field).IsView) { _oRw[BundleMapping.Para.vas_field] = _oBundleMappingList[i].vas_field; }
                if (this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.edate).IsView) { _oRw[BundleMapping.Para.edate] = _oBundleMappingList[i].edate; }
                if (this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.program).IsView) { _oRw[BundleMapping.Para.program] = _oBundleMappingList[i].program; }
                if (this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.bundle_name).IsView) { _oRw[BundleMapping.Para.bundle_name] = _oBundleMappingList[i].bundle_name; }
                if (this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.normal_rebate_type).IsView) { _oRw[BundleMapping.Para.normal_rebate_type] = _oBundleMappingList[i].normal_rebate_type; }
                if (this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.rate_plan).IsView) { _oRw[BundleMapping.Para.rate_plan] = _oBundleMappingList[i].rate_plan; }
                if (this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.did).IsView) { _oRw[BundleMapping.Para.did] = _oBundleMappingList[i].did; }
                if (this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.ddate).IsView) { _oRw[BundleMapping.Para.ddate] = _oBundleMappingList[i].ddate; }
                if (this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.sdate).IsView) { _oRw[BundleMapping.Para.sdate] = _oBundleMappingList[i].sdate; }
                if (this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.issue_type).IsView) { _oRw[BundleMapping.Para.issue_type] = _oBundleMappingList[i].issue_type; }
                this.Dt.Rows.Add(_oRw);
            }
            return this.Ds;
        }
        #endregion
        #region TableSetUp
        public bool TableSetUp()
        {
            if (this.BundleMappingInfo == null) return false;
            #region Report Column Index Setting
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.id).ReportColumnIndex = 0;
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.cdate).ReportColumnIndex = 1;
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.cid).ReportColumnIndex = 2;
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.active).ReportColumnIndex = 3;
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.vas_field).ReportColumnIndex = 4;
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.edate).ReportColumnIndex = 5;
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.program).ReportColumnIndex = 6;
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.bundle_name).ReportColumnIndex = 7;
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.issue_type).ReportColumnIndex = 8;
            
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.rate_plan).ReportColumnIndex = 9;
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.did).ReportColumnIndex = 10;
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.ddate).ReportColumnIndex = 11;
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.sdate).ReportColumnIndex = 12;
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.normal_rebate_type).ReportColumnIndex = 13;
            
            #endregion
            #region Report Column Name Setting
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.id).ReportColumnName = "id";
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.cdate).ReportColumnName = "cdate";
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.cid).ReportColumnName = "cid";
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.active).ReportColumnName = "active";
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.vas_field).ReportColumnName = "vas_field";
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.edate).ReportColumnName = "edate";
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.program).ReportColumnName = "program";
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.bundle_name).ReportColumnName = "bundle_name";
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.normal_rebate_type).ReportColumnName = "normal_rebate_type";
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.rate_plan).ReportColumnName = "rate_plan";
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.did).ReportColumnName = "did";
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.ddate).ReportColumnName = "ddate";
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.sdate).ReportColumnName = "sdate";
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.issue_type).ReportColumnName = "issue_type";
            #endregion
            #region Report View Setting
            SetAllView(true);
            #endregion
            return true;
        }
        #endregion

        #region ResetTable
        public void ResetTable(BundleMappingInfo x_oBundleMappingInfo)
        {
            this.BundleMappingInfo = x_oBundleMappingInfo;
            this.Ds = BundleMappingBal.ToEmptyDataSet(this.BundleMappingInfo);
            this.Dt = this.Ds.Tables[BundleMapping.Para.TableName()];
        }
        #endregion

        #region SetAllView
        public void SetAllView(bool x_bView)
        {
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.id).IsView = true;
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.cdate).IsView = true;
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.cid).IsView = true;
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.active).IsView = true;
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.vas_field).IsView = true;
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.edate).IsView = true;
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.program).IsView = true;
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.bundle_name).IsView = true;
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.normal_rebate_type).IsView = true;
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.rate_plan).IsView = true;
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.did).IsView = true;
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.ddate).IsView = true;
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.sdate).IsView = true;
            this.BundleMappingInfo.GetTableSet().Fields(BundleMapping.Para.issue_type).IsView = true;
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
        protected BundleMappingInfo n_oBundleMappingInfo = null;
        #region BundleMappingInfo
        public BundleMappingInfo BundleMappingInfo
        {
            get
            {
                return this.n_oBundleMappingInfo;
            }
            set
            {
                this.n_oBundleMappingInfo = value;
            }
        }
        #endregion BundleMappingInfo

        #region Get & Set
        public int GetStartRecordIndex() { return this.StartRecordIndex; }
        public int GetLimitRecordIndex() { return this.LimitRecordIndex; }
        public HtmlTable GetReportHtmlTable() { return this.ReportHtmlTable; }
        public DataSet GetDs() { return this.Ds; }
        public string GetFileName() { return this.FileName; }
        public Page GetPage() { return this.Page; }
        public string GetContentType() { return this.ContentType; }
        public DataTable GetDt() { return this.Dt; }
        public BundleMappingInfo GetBundleMappingInfo() { return this.BundleMappingInfo; }
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
        public bool SetBundleMappingInfo(BundleMappingInfo value)
        {
            this.BundleMappingInfo = value;
            return true;
        }
        #endregion
        #region Equals
        public bool Equals(BundleMappingReport x_oObj)
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
            if (!this.BundleMappingInfo.Equals(x_oObj.BundleMappingInfo)) { return false; }
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
            this.BundleMappingInfo = null;
        }
        #endregion Release
        #region Clone
        public BundleMappingReport DeepClone()
        {
            BundleMappingReport BundleMappingReport_Clone = new BundleMappingReport(null, null);
            BundleMappingReport_Clone.SetStartRecordIndex(this.StartRecordIndex);
            BundleMappingReport_Clone.SetLimitRecordIndex(this.LimitRecordIndex);
            BundleMappingReport_Clone.SetReportHtmlTable(this.ReportHtmlTable);
            BundleMappingReport_Clone.SetDs(this.Ds);
            BundleMappingReport_Clone.SetFileName(this.FileName);
            BundleMappingReport_Clone.SetPage(this.Page);
            BundleMappingReport_Clone.SetContentType(this.ContentType);
            BundleMappingReport_Clone.SetDt(this.Dt);
            BundleMappingReport_Clone.SetBundleMappingInfo(this.BundleMappingInfo);
            return BundleMappingReport_Clone;
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
