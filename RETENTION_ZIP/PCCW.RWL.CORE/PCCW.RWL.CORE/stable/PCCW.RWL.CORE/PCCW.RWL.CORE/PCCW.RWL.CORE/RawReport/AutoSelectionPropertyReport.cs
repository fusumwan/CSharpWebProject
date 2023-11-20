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
///-- Create date: <Create Date 2009-10-08>
///-- Description:	<Description,Class :AutoSelectionPropertyReport, Data Report Control>
///-- =============================================
namespace PCCW.RWL.CORE
{
    public class AutoSelectionPropertyReport : IDisposable
    {
        #region Constructor & Destructor
        public AutoSelectionPropertyReport(Page x_oPage, string x_sContentType)
        {
            if (x_sContentType != null) x_sContentType = x_sContentType.Trim();
            if (x_oPage != null && !string.IsNullOrEmpty(x_sContentType))
            {
                this.Page = x_oPage;
                this.ContentType = x_sContentType;
                this.AutoSelectionPropertyInfo = AutoSelectionPropertyInfo.CreateInfoInstanceObject();
                this.TableSetUp();
                this.Ds = AutoSelectionPropertyBal.ToEmptyDataSet(this.AutoSelectionPropertyInfo);
                this.Dt = this.Ds.Tables[AutoSelectionProperty.Para.TableName()];
                this.ReportHtmlTable = new HtmlTable();
                this.ReportHtmlTable.Border = 1;
            }
        }
        ~AutoSelectionPropertyReport() { }
        #endregion Constructor & Destructor

        #region ResetTable
        public void ResetTable(AutoSelectionPropertyInfo x_oAutoSelectionPropertyInfo)
        {
            this.AutoSelectionPropertyInfo = x_oAutoSelectionPropertyInfo;
            this.Ds = AutoSelectionPropertyBal.ToEmptyDataSet(this.AutoSelectionPropertyInfo);
            this.Dt = this.Ds.Tables[AutoSelectionProperty.Para.TableName()];
        }
        #endregion

        #region Export Report
        public bool ExportReport()
        {
            if (this.Ds == null) { return false; }
            if (this.Dt == null) { return false; }
            if (this.Page == null) { return false; }
            if (this.ReportHtmlTable == null) { return false; }
            if (this.AutoSelectionPropertyInfo == null) { return false; }
            if (string.IsNullOrEmpty(this.FileName)) { return false; }
            if (string.IsNullOrEmpty(this.ContentType)) { return false; }
            DataSet _oDs = this.GetDataSet();
            if (_oDs != null)
            {
                HtmlTable _oHtmlTable = this.GetReportHtmlTable();
                HtmlTableRow _oHeadRow = new HtmlTableRow();
                AutoSelectionPropertyInfo _oAutoSelectionPropertyInfo = this.GetAutoSelectionPropertyInfo();
                SortedDictionary<int, HtmlTableCell> _oKeyHtmlHead = new SortedDictionary<int, HtmlTableCell>();
                SortedDictionary<int, int> _oKeyHtmlRowMap = new SortedDictionary<int, int>();
                for (int i = 0; i < _oDs.Tables[AutoSelectionProperty.Para.TableName()].Columns.Count; i++)
                {
                    DataColumn _oCol = _oDs.Tables[AutoSelectionProperty.Para.TableName()].Columns[i];
                    HtmlTableCell _oHtmlTableCell = new HtmlTableCell();
                    Field _oField = _oAutoSelectionPropertyInfo.GetTableSet().Fields(_oCol.ColumnName);
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
                for (int i = 0; i < _oDs.Tables[AutoSelectionProperty.Para.TableName()].Rows.Count; i++)
                {
                    DataRow _oDataRow = _oDs.Tables[AutoSelectionProperty.Para.TableName()].Rows[i];
                    HtmlTableRow _oTableRow = new HtmlTableRow();
                    SortedDictionary<int, HtmlTableCell> _oKeyHtmlRow = new SortedDictionary<int, HtmlTableCell>();
                    for (int r = 0; r < _oDs.Tables[AutoSelectionProperty.Para.TableName()].Columns.Count; r++)
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
            if (this.AutoSelectionPropertyInfo == null) return null;
            if (string.IsNullOrEmpty(this.FileName)) return null;
            if (string.IsNullOrEmpty(this.ContentType)) return null;
            IList<AutoSelectionPropertyEntity> _oAutoSelectionPropertyList = AutoSelectionPropertyDalDAO.FindAll(this.StartRecordIndex, this.LimitRecordIndex, AutoSelectionProperty.Para.id);
            for (int i = 0; i < _oAutoSelectionPropertyList.Count; i++)
            {
                DataRow _oRw = this.Dt.NewRow();
                if (this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.id).IsView) { _oRw[AutoSelectionProperty.Para.id] = _oAutoSelectionPropertyList[i].id; }
                if (this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.period).IsView) { _oRw[AutoSelectionProperty.Para.period] = _oAutoSelectionPropertyList[i].period; }
                if (this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.start_date).IsView) {
                    if (_oAutoSelectionPropertyList[i].start_date != null)
                        _oRw[AutoSelectionProperty.Para.start_date] = ((DateTime)_oAutoSelectionPropertyList[i].start_date).ToString("dd-MM-yyyy");
                    else
                        _oRw[AutoSelectionProperty.Para.start_date] = string.Empty;
                }
                if (this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.obprogram).IsView) { _oRw[AutoSelectionProperty.Para.obprogram] = _oAutoSelectionPropertyList[i].obprogram; }
                if (this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.channel).IsView) { _oRw[AutoSelectionProperty.Para.channel] = _oAutoSelectionPropertyList[i].channel; }
                if (this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.tier).IsView) { _oRw[AutoSelectionProperty.Para.tier] = _oAutoSelectionPropertyList[i].tier; }
                if (this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.tradefield_mid).IsView) { _oRw[AutoSelectionProperty.Para.tradefield_mid] = _oAutoSelectionPropertyList[i].tradefield_mid; }
                if (this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.uid).IsView) { _oRw[AutoSelectionProperty.Para.uid] = _oAutoSelectionPropertyList[i].uid; }
                if (this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.end_date).IsView) {
                    if (_oAutoSelectionPropertyList[i].end_date != null)
                        _oRw[AutoSelectionProperty.Para.end_date] = ((DateTime)_oAutoSelectionPropertyList[i].end_date).ToString("dd-MM-yyyy");
                    else
                        _oRw[AutoSelectionProperty.Para.end_date] = string.Empty;
                }
                if (this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.plan_fee).IsView) { _oRw[AutoSelectionProperty.Para.plan_fee] = _oAutoSelectionPropertyList[i].plan_fee; }
                if (this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.remarks).IsView) { _oRw[AutoSelectionProperty.Para.remarks] = _oAutoSelectionPropertyList[i].remarks; }
                if (this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.po_date).IsView) {
                    if (_oAutoSelectionPropertyList[i].po_date != null)
                        _oRw[AutoSelectionProperty.Para.po_date] = ((DateTime)_oAutoSelectionPropertyList[i].po_date).ToString("dd-MM-yyyy");
                    else
                        _oRw[AutoSelectionProperty.Para.po_date] = string.Empty;
                }
                this.Dt.Rows.Add(_oRw);
            }
            return this.Ds;
        }
        #endregion
        #region TableSetUp
        public bool TableSetUp()
        {
            if (this.AutoSelectionPropertyInfo == null) return false;
            #region Report Column Index Setting

            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.obprogram).ReportColumnIndex = 0;
            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.period).ReportColumnIndex = 1;
            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.plan_fee).ReportColumnIndex = 2;
            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.tier).ReportColumnIndex = 3;
            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.tradefield_mid).ReportColumnIndex = 4;
            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.channel).ReportColumnIndex = 5;
            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.start_date).ReportColumnIndex = 6;
            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.end_date).ReportColumnIndex = 7;
            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.uid).ReportColumnIndex = 8;
            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.po_date).ReportColumnIndex = 9;
            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.remarks).ReportColumnIndex = 10;

            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.id).ReportColumnIndex = 11;
            
            #endregion
            #region Report Column Name Setting
            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.id).ReportColumnName = "id";
            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.period).ReportColumnName = "period";
            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.start_date).ReportColumnName = "start_date";
            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.obprogram).ReportColumnName = "obprogram";
            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.channel).ReportColumnName = "channel";
            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.tier).ReportColumnName = "tier";
            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.tradefield_mid).ReportColumnName = "tradefield_mid";
            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.uid).ReportColumnName = "uid";
            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.end_date).ReportColumnName = "end_date";
            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.plan_fee).ReportColumnName = "plan_fee";
            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.remarks).ReportColumnName = "remarks";
            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.po_date).ReportColumnName = "po_date";
            #endregion
            #region Report View Setting
            SetAllView(true);
            #endregion
            return true;
        }
        #endregion

        #region SetAllView
        public void SetAllView(bool x_bView)
        {
            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.id).IsView = x_bView;
            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.period).IsView = x_bView;
            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.start_date).IsView = x_bView;
            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.obprogram).IsView = x_bView;
            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.channel).IsView = x_bView;
            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.tier).IsView = x_bView;
            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.tradefield_mid).IsView = x_bView;
            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.uid).IsView = x_bView;
            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.end_date).IsView = x_bView;
            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.plan_fee).IsView = x_bView;
            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.remarks).IsView = x_bView;
            this.AutoSelectionPropertyInfo.GetTableSet().Fields(AutoSelectionProperty.Para.po_date).IsView = x_bView;
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
        protected AutoSelectionPropertyInfo n_oAutoSelectionPropertyInfo = null;
        #region AutoSelectionPropertyInfo
        public AutoSelectionPropertyInfo AutoSelectionPropertyInfo
        {
            get
            {
                return this.n_oAutoSelectionPropertyInfo;
            }
            set
            {
                this.n_oAutoSelectionPropertyInfo = value;
            }
        }
        #endregion AutoSelectionPropertyInfo

        #region Get & Set
        public int GetStartRecordIndex() { return this.StartRecordIndex; }
        public int GetLimitRecordIndex() { return this.LimitRecordIndex; }
        public HtmlTable GetReportHtmlTable() { return this.ReportHtmlTable; }
        public DataSet GetDs() { return this.Ds; }
        public string GetFileName() { return this.FileName; }
        public Page GetPage() { return this.Page; }
        public string GetContentType() { return this.ContentType; }
        public DataTable GetDt() { return this.Dt; }
        public AutoSelectionPropertyInfo GetAutoSelectionPropertyInfo() { return this.AutoSelectionPropertyInfo; }
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
        public bool SetAutoSelectionPropertyInfo(AutoSelectionPropertyInfo value)
        {
            this.AutoSelectionPropertyInfo = value;
            return true;
        }
        #endregion
        #region Equals
        public bool Equals(AutoSelectionPropertyReport x_oObj)
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
            if (!this.AutoSelectionPropertyInfo.Equals(x_oObj.AutoSelectionPropertyInfo)) { return false; }
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
            this.AutoSelectionPropertyInfo = null;
        }
        #endregion Release
        #region Clone
        public AutoSelectionPropertyReport DeepClone()
        {
            AutoSelectionPropertyReport AutoSelectionPropertyReport_Clone = new AutoSelectionPropertyReport(null, null);
            AutoSelectionPropertyReport_Clone.SetStartRecordIndex(this.StartRecordIndex);
            AutoSelectionPropertyReport_Clone.SetLimitRecordIndex(this.LimitRecordIndex);
            AutoSelectionPropertyReport_Clone.SetReportHtmlTable(this.ReportHtmlTable);
            AutoSelectionPropertyReport_Clone.SetDs(this.Ds);
            AutoSelectionPropertyReport_Clone.SetFileName(this.FileName);
            AutoSelectionPropertyReport_Clone.SetPage(this.Page);
            AutoSelectionPropertyReport_Clone.SetContentType(this.ContentType);
            AutoSelectionPropertyReport_Clone.SetDt(this.Dt);
            AutoSelectionPropertyReport_Clone.SetAutoSelectionPropertyInfo(this.AutoSelectionPropertyInfo);
            return AutoSelectionPropertyReport_Clone;
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
