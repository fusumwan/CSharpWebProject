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
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2010-04-19>
///-- Description:	<Description,Class :SpecialCustomerReport, Data Report Control>
///-- =============================================
namespace PCCW.RWL.CORE{
    public class SpecialCustomerReport : IDisposable
    {
        #region Constructor & Destructor
        public SpecialCustomerReport(Page x_oPage, string x_sContentType)
        {
            if (x_sContentType != null) x_sContentType = x_sContentType.Trim();
            if (x_oPage != null && !string.IsNullOrEmpty(x_sContentType))
            {
                this.Page = x_oPage;
                this.ContentType = x_sContentType;
                this.SpecialCustomerInfo = SpecialCustomerInfo.CreateInfoInstanceObject();
                this.TableSetUp();
                this.Ds = SpecialCustomerBal.ToEmptyDataSet(this.SpecialCustomerInfo);
                this.Dt = this.Ds.Tables[SpecialCustomer.Para.TableName()];
                this.ReportHtmlTable = new HtmlTable();
                this.ReportHtmlTable.Border = 1;
            }
        }
        ~SpecialCustomerReport() { }
        #endregion Constructor & Destructor
        #region Export Report
        public bool ExportReport()
        {
            if (this.Ds == null) { return false; }
            if (this.Dt == null) { return false; }
            if (this.Page == null) { return false; }
            if (this.ReportHtmlTable == null) { return false; }
            if (this.SpecialCustomerInfo == null) { return false; }
            if (string.IsNullOrEmpty(this.FileName)) { return false; }
            if (string.IsNullOrEmpty(this.ContentType)) { return false; }
            DataSet _oDs = this.GetDataSet();
            if (_oDs != null)
            {
                HtmlTable _oHtmlTable = this.GetReportHtmlTable();
                HtmlTableRow _oHeadRow = new HtmlTableRow();
                SpecialCustomerInfo _oSpecialCustomerInfo = this.GetSpecialCustomerInfo();
                SortedDictionary<int, HtmlTableCell> _oKeyHtmlHead = new SortedDictionary<int, HtmlTableCell>();
                SortedDictionary<int, int> _oKeyHtmlRowMap = new SortedDictionary<int, int>();
                for (int i = 0; i < _oDs.Tables[SpecialCustomer.Para.TableName()].Columns.Count; i++)
                {
                    DataColumn _oCol = _oDs.Tables[SpecialCustomer.Para.TableName()].Columns[i];
                    HtmlTableCell _oHtmlTableCell = new HtmlTableCell();
                    Field _oField = _oSpecialCustomerInfo.GetTableSet().Fields(_oCol.ColumnName);
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
                for (int i = 0; i < _oDs.Tables[SpecialCustomer.Para.TableName()].Rows.Count; i++)
                {
                    DataRow _oDataRow = _oDs.Tables[SpecialCustomer.Para.TableName()].Rows[i];
                    HtmlTableRow _oTableRow = new HtmlTableRow();
                    SortedDictionary<int, HtmlTableCell> _oKeyHtmlRow = new SortedDictionary<int, HtmlTableCell>();
                    for (int r = 0; r < _oDs.Tables[SpecialCustomer.Para.TableName()].Columns.Count; r++)
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
            if (this.SpecialCustomerInfo == null) return null;
            if (string.IsNullOrEmpty(this.FileName)) return null;
            if (string.IsNullOrEmpty(this.ContentType)) return null;
            IList<SpecialCustomerEntity> _oSpecialCustomerList = SpecialCustomerDalDAO.FindAll(this.StartRecordIndex, this.LimitRecordIndex, SpecialCustomer.Para.id);
            for (int i = 0; i < _oSpecialCustomerList.Count; i++)
            {
                DataRow _oRw = this.Dt.NewRow();
                if (this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.id).IsView) { _oRw[SpecialCustomer.Para.id] = _oSpecialCustomerList[i].id; }
                if (this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.cdate).IsView) { _oRw[SpecialCustomer.Para.cdate] = _oSpecialCustomerList[i].cdate; }
                if (this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.cid).IsView) { _oRw[SpecialCustomer.Para.cid] = _oSpecialCustomerList[i].cid; }
                if (this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.condition4).IsView) { _oRw[SpecialCustomer.Para.condition4] = _oSpecialCustomerList[i].condition4; }
                if (this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.status).IsView) { _oRw[SpecialCustomer.Para.status] = _oSpecialCustomerList[i].status; }
                if (this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.active).IsView) { _oRw[SpecialCustomer.Para.active] = _oSpecialCustomerList[i].active; }
                if (this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.condition3).IsView) { _oRw[SpecialCustomer.Para.condition3] = _oSpecialCustomerList[i].condition3; }
                if (this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.condition5).IsView) { _oRw[SpecialCustomer.Para.condition5] = _oSpecialCustomerList[i].condition5; }
                if (this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.hkid).IsView) { _oRw[SpecialCustomer.Para.hkid] = _oSpecialCustomerList[i].hkid; }
                if (this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.condition1).IsView) { _oRw[SpecialCustomer.Para.condition1] = _oSpecialCustomerList[i].condition1; }
                if (this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.ddate).IsView) { _oRw[SpecialCustomer.Para.ddate] = _oSpecialCustomerList[i].ddate; }
                if (this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.count).IsView) { _oRw[SpecialCustomer.Para.count] = _oSpecialCustomerList[i].count; }
                if (this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.did).IsView) { _oRw[SpecialCustomer.Para.did] = _oSpecialCustomerList[i].did; }
                if (this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.condition2).IsView) { _oRw[SpecialCustomer.Para.condition2] = _oSpecialCustomerList[i].condition2; }
                this.Dt.Rows.Add(_oRw);
            }
            return this.Ds;
        }
        #endregion
        #region TableSetUp
        public bool TableSetUp()
        {
            if (this.SpecialCustomerInfo == null) return false;
            #region Report Column Index Setting
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.id).ReportColumnIndex = 0;
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.cdate).ReportColumnIndex = 1;
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.cid).ReportColumnIndex = 2;
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.condition4).ReportColumnIndex = 3;
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.status).ReportColumnIndex = 4;
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.active).ReportColumnIndex = 5;
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.condition3).ReportColumnIndex = 6;
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.condition5).ReportColumnIndex = 7;
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.hkid).ReportColumnIndex = 8;
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.condition1).ReportColumnIndex = 9;
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.ddate).ReportColumnIndex = 10;
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.count).ReportColumnIndex = 11;
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.did).ReportColumnIndex = 12;
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.condition2).ReportColumnIndex = 13;
            #endregion
            #region Report Column Name Setting
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.id).ReportColumnName = "id";
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.cdate).ReportColumnName = "cdate";
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.cid).ReportColumnName = "cid";
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.condition4).ReportColumnName = "condition4";
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.status).ReportColumnName = "status";
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.active).ReportColumnName = "active";
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.condition3).ReportColumnName = "condition3";
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.condition5).ReportColumnName = "condition5";
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.hkid).ReportColumnName = "hkid";
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.condition1).ReportColumnName = "condition1";
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.ddate).ReportColumnName = "ddate";
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.count).ReportColumnName = "count";
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.did).ReportColumnName = "did";
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.condition2).ReportColumnName = "condition2";
            #endregion
            #region Report View Setting
            SetAllView(true);
            #endregion
            return true;
        }
        #endregion
        
        #region ResetTable
        public void ResetTable(SpecialCustomerInfo x_oSpecialCustomerInfo)
        {
            this.SpecialCustomerInfo = x_oSpecialCustomerInfo;
            this.Ds = SpecialCustomerBal.ToEmptyDataSet(this.SpecialCustomerInfo);
            this.Dt = this.Ds.Tables[SpecialCustomer.Para.TableName()];
        }
        #endregion
        
        #region SetAllView
        public void SetAllView(bool x_bView)
        {
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.id).IsView = true;
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.cdate).IsView = true;
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.cid).IsView = true;
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.condition4).IsView = true;
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.status).IsView = true;
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.active).IsView = true;
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.condition3).IsView = true;
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.condition5).IsView = true;
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.hkid).IsView = true;
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.condition1).IsView = true;
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.ddate).IsView = true;
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.count).IsView = true;
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.did).IsView = true;
            this.SpecialCustomerInfo.GetTableSet().Fields(SpecialCustomer.Para.condition2).IsView = true;
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
        protected SpecialCustomerInfo n_oSpecialCustomerInfo = null;
        #region SpecialCustomerInfo
        public SpecialCustomerInfo SpecialCustomerInfo
        {
            get
            {
                return this.n_oSpecialCustomerInfo;
            }
            set
            {
                this.n_oSpecialCustomerInfo = value;
            }
        }
        #endregion SpecialCustomerInfo
        
        #region Get & Set
        public int GetStartRecordIndex() { return this.StartRecordIndex; }
        public int GetLimitRecordIndex() { return this.LimitRecordIndex; }
        public HtmlTable GetReportHtmlTable() { return this.ReportHtmlTable; }
        public DataSet GetDs() { return this.Ds; }
        public string GetFileName() { return this.FileName; }
        public Page GetPage() { return this.Page; }
        public string GetContentType() { return this.ContentType; }
        public DataTable GetDt() { return this.Dt; }
        public SpecialCustomerInfo GetSpecialCustomerInfo() { return this.SpecialCustomerInfo; }
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
        public bool SetSpecialCustomerInfo(SpecialCustomerInfo value)
        {
            this.SpecialCustomerInfo = value;
            return true;
        }
        #endregion
        #region Equals
        public bool Equals(SpecialCustomerReport x_oObj)
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
            if (!this.SpecialCustomerInfo.Equals(x_oObj.SpecialCustomerInfo)) { return false; }
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
            this.SpecialCustomerInfo = null;
        }
        #endregion Release
        #region Clone
        public SpecialCustomerReport DeepClone()
        {
            SpecialCustomerReport SpecialCustomerReport_Clone = new SpecialCustomerReport(null,null);
            SpecialCustomerReport_Clone.SetStartRecordIndex(this.StartRecordIndex);
            SpecialCustomerReport_Clone.SetLimitRecordIndex(this.LimitRecordIndex);
            SpecialCustomerReport_Clone.SetReportHtmlTable(this.ReportHtmlTable);
            SpecialCustomerReport_Clone.SetDs(this.Ds);
            SpecialCustomerReport_Clone.SetFileName(this.FileName);
            SpecialCustomerReport_Clone.SetPage(this.Page);
            SpecialCustomerReport_Clone.SetContentType(this.ContentType);
            SpecialCustomerReport_Clone.SetDt(this.Dt);
            SpecialCustomerReport_Clone.SetSpecialCustomerInfo(this.SpecialCustomerInfo);
            return SpecialCustomerReport_Clone;
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

