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
///-- Create date: <Create Date 2010-04-20>
///-- Description:	<Description,Class :DOAProfileRecordReport, Data Report Control>
///-- =============================================
namespace PCCW.RWL.CORE{
    public class DOAProfileRecordReport : IDisposable
    {
        #region Constructor & Destructor
        public DOAProfileRecordReport(Page x_oPage, string x_sContentType)
        {
            if (x_sContentType != null) x_sContentType = x_sContentType.Trim();
            if (x_oPage != null && !string.IsNullOrEmpty(x_sContentType))
            {
                this.Page = x_oPage;
                this.ContentType = x_sContentType;
                this.DOAProfileRecordInfo = DOAProfileRecordInfo.CreateInfoInstanceObject();
                this.TableSetUp();
                this.Ds = DOAProfileRecordBal.ToEmptyDataSet(this.DOAProfileRecordInfo);
                this.Dt = this.Ds.Tables[DOAProfileRecord.Para.TableName()];
                this.ReportHtmlTable = new HtmlTable();
                this.ReportHtmlTable.Border = 1;
            }
        }
        ~DOAProfileRecordReport() { }
        #endregion Constructor & Destructor
        #region Export Report
        public bool ExportReport()
        {
            if (this.Ds == null) { return false; }
            if (this.Dt == null) { return false; }
            if (this.Page == null) { return false; }
            if (this.ReportHtmlTable == null) { return false; }
            if (this.DOAProfileRecordInfo == null) { return false; }
            if (string.IsNullOrEmpty(this.FileName)) { return false; }
            if (string.IsNullOrEmpty(this.ContentType)) { return false; }
            DataSet _oDs = this.GetDataSet();
            if (_oDs != null)
            {
                HtmlTable _oHtmlTable = this.GetReportHtmlTable();
                HtmlTableRow _oHeadRow = new HtmlTableRow();
                DOAProfileRecordInfo _oDOAProfileRecordInfo = this.GetDOAProfileRecordInfo();
                SortedDictionary<int, HtmlTableCell> _oKeyHtmlHead = new SortedDictionary<int, HtmlTableCell>();
                SortedDictionary<int, int> _oKeyHtmlRowMap = new SortedDictionary<int, int>();
                for (int i = 0; i < _oDs.Tables[DOAProfileRecord.Para.TableName()].Columns.Count; i++)
                {
                    DataColumn _oCol = _oDs.Tables[DOAProfileRecord.Para.TableName()].Columns[i];
                    HtmlTableCell _oHtmlTableCell = new HtmlTableCell();
                    Field _oField = _oDOAProfileRecordInfo.GetTableSet().Fields(_oCol.ColumnName);
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
                for (int i = 0; i < _oDs.Tables[DOAProfileRecord.Para.TableName()].Rows.Count; i++)
                {
                    DataRow _oDataRow = _oDs.Tables[DOAProfileRecord.Para.TableName()].Rows[i];
                    HtmlTableRow _oTableRow = new HtmlTableRow();
                    SortedDictionary<int, HtmlTableCell> _oKeyHtmlRow = new SortedDictionary<int, HtmlTableCell>();
                    for (int r = 0; r < _oDs.Tables[DOAProfileRecord.Para.TableName()].Columns.Count; r++)
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
            if (this.DOAProfileRecordInfo == null) return null;
            if (string.IsNullOrEmpty(this.FileName)) return null;
            if (string.IsNullOrEmpty(this.ContentType)) return null;
            IList<DOAProfileRecordEntity> _oDOAProfileRecordList = DOAProfileRecordDalDAO.FindAll(this.StartRecordIndex, this.LimitRecordIndex, DOAProfileRecord.Para.id);
            for (int i = 0; i < _oDOAProfileRecordList.Count; i++)
            {
                DataRow _oRw = this.Dt.NewRow();
                if (this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.id).IsView) { _oRw[DOAProfileRecord.Para.id] = _oDOAProfileRecordList[i].id; }
                if (this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.cdate).IsView) { _oRw[DOAProfileRecord.Para.cdate] = _oDOAProfileRecordList[i].cdate; }
                if (this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.cid).IsView) { _oRw[DOAProfileRecord.Para.cid] = _oDOAProfileRecordList[i].cid; }
                if (this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.did).IsView) { _oRw[DOAProfileRecord.Para.did] = _oDOAProfileRecordList[i].did; }
                if (this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.status).IsView) { _oRw[DOAProfileRecord.Para.status] = _oDOAProfileRecordList[i].status; }
                if (this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.active).IsView) { _oRw[DOAProfileRecord.Para.active] = _oDOAProfileRecordList[i].active; }
                if (this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.imei_stock_remark).IsView) { _oRw[DOAProfileRecord.Para.imei_stock_remark] = _oDOAProfileRecordList[i].imei_stock_remark; }
                if (this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.edate).IsView) { _oRw[DOAProfileRecord.Para.edate] = _oDOAProfileRecordList[i].edate; }
                if (this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.edf_no).IsView) { _oRw[DOAProfileRecord.Para.edf_no] = _oDOAProfileRecordList[i].edf_no; }
                if (this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.used).IsView) { _oRw[DOAProfileRecord.Para.used] = _oDOAProfileRecordList[i].used; }
                if (this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.order_id).IsView) { _oRw[DOAProfileRecord.Para.order_id] = _oDOAProfileRecordList[i].order_id; }
                if (this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.order_dn_remark).IsView) { _oRw[DOAProfileRecord.Para.order_dn_remark] = _oDOAProfileRecordList[i].order_dn_remark; }
                if (this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.ddate).IsView) { _oRw[DOAProfileRecord.Para.ddate] = _oDOAProfileRecordList[i].ddate; }
                if (this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.imei_no).IsView) { _oRw[DOAProfileRecord.Para.imei_no] = _oDOAProfileRecordList[i].imei_no; }
                if (this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.order_remark).IsView) { _oRw[DOAProfileRecord.Para.order_remark] = _oDOAProfileRecordList[i].order_remark; }
                this.Dt.Rows.Add(_oRw);
            }
            return this.Ds;
        }
        #endregion
        #region TableSetUp
        public bool TableSetUp()
        {
            if (this.DOAProfileRecordInfo == null) return false;
            #region Report Column Index Setting
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.id).ReportColumnIndex = 0;
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.cdate).ReportColumnIndex = 1;
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.cid).ReportColumnIndex = 2;
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.did).ReportColumnIndex = 3;
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.status).ReportColumnIndex = 4;
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.active).ReportColumnIndex = 5;
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.imei_stock_remark).ReportColumnIndex = 6;
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.edate).ReportColumnIndex = 7;
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.edf_no).ReportColumnIndex = 8;
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.used).ReportColumnIndex = 9;
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.order_id).ReportColumnIndex = 10;
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.order_dn_remark).ReportColumnIndex = 11;
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.ddate).ReportColumnIndex = 12;
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.imei_no).ReportColumnIndex = 13;
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.order_remark).ReportColumnIndex = 14;
            #endregion
            #region Report Column Name Setting
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.id).ReportColumnName = "id";
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.cdate).ReportColumnName = "cdate";
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.cid).ReportColumnName = "cid";
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.did).ReportColumnName = "did";
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.status).ReportColumnName = "status";
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.active).ReportColumnName = "active";
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.imei_stock_remark).ReportColumnName = "imei_stock_remark";
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.edate).ReportColumnName = "edate";
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.edf_no).ReportColumnName = "edf_no";
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.used).ReportColumnName = "used";
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.order_id).ReportColumnName = "order_id";
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.order_dn_remark).ReportColumnName = "order_dn_remark";
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.ddate).ReportColumnName = "ddate";
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.imei_no).ReportColumnName = "imei_no";
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.order_remark).ReportColumnName = "order_remark";
            #endregion
            #region Report View Setting
            SetAllView(true);
            #endregion
            return true;
        }
        #endregion
        
        #region ResetTable
        public void ResetTable(DOAProfileRecordInfo x_oDOAProfileRecordInfo)
        {
            this.DOAProfileRecordInfo = x_oDOAProfileRecordInfo;
            this.Ds = DOAProfileRecordBal.ToEmptyDataSet(this.DOAProfileRecordInfo);
            this.Dt = this.Ds.Tables[DOAProfileRecord.Para.TableName()];
        }
        #endregion
        
        #region SetAllView
        public void SetAllView(bool x_bView)
        {
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.id).IsView = true;
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.cdate).IsView = true;
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.cid).IsView = true;
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.did).IsView = true;
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.status).IsView = true;
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.active).IsView = true;
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.imei_stock_remark).IsView = true;
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.edate).IsView = true;
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.edf_no).IsView = true;
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.used).IsView = true;
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.order_id).IsView = true;
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.order_dn_remark).IsView = true;
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.ddate).IsView = true;
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.imei_no).IsView = true;
            this.DOAProfileRecordInfo.GetTableSet().Fields(DOAProfileRecord.Para.order_remark).IsView = true;
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
        protected DOAProfileRecordInfo n_oDOAProfileRecordInfo = null;
        #region DOAProfileRecordInfo
        public DOAProfileRecordInfo DOAProfileRecordInfo
        {
            get
            {
                return this.n_oDOAProfileRecordInfo;
            }
            set
            {
                this.n_oDOAProfileRecordInfo = value;
            }
        }
        #endregion DOAProfileRecordInfo
        
        #region Get & Set
        public int GetStartRecordIndex() { return this.StartRecordIndex; }
        public int GetLimitRecordIndex() { return this.LimitRecordIndex; }
        public HtmlTable GetReportHtmlTable() { return this.ReportHtmlTable; }
        public DataSet GetDs() { return this.Ds; }
        public string GetFileName() { return this.FileName; }
        public Page GetPage() { return this.Page; }
        public string GetContentType() { return this.ContentType; }
        public DataTable GetDt() { return this.Dt; }
        public DOAProfileRecordInfo GetDOAProfileRecordInfo() { return this.DOAProfileRecordInfo; }
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
        public bool SetDOAProfileRecordInfo(DOAProfileRecordInfo value)
        {
            this.DOAProfileRecordInfo = value;
            return true;
        }
        #endregion
        #region Equals
        public bool Equals(DOAProfileRecordReport x_oObj)
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
            if (!this.DOAProfileRecordInfo.Equals(x_oObj.DOAProfileRecordInfo)) { return false; }
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
            this.DOAProfileRecordInfo = null;
        }
        #endregion Release
        #region Clone
        public DOAProfileRecordReport DeepClone()
        {
            DOAProfileRecordReport DOAProfileRecordReport_Clone = new DOAProfileRecordReport(null,null);
            DOAProfileRecordReport_Clone.SetStartRecordIndex(this.StartRecordIndex);
            DOAProfileRecordReport_Clone.SetLimitRecordIndex(this.LimitRecordIndex);
            DOAProfileRecordReport_Clone.SetReportHtmlTable(this.ReportHtmlTable);
            DOAProfileRecordReport_Clone.SetDs(this.Ds);
            DOAProfileRecordReport_Clone.SetFileName(this.FileName);
            DOAProfileRecordReport_Clone.SetPage(this.Page);
            DOAProfileRecordReport_Clone.SetContentType(this.ContentType);
            DOAProfileRecordReport_Clone.SetDt(this.Dt);
            DOAProfileRecordReport_Clone.SetDOAProfileRecordInfo(this.DOAProfileRecordInfo);
            return DOAProfileRecordReport_Clone;
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

