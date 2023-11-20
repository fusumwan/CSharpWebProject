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
///-- Create date: <Create Date 2009-10-05>
///-- Description:	<Description,Class :AccessoryReport, Data Report Control>
///-- =============================================
namespace PCCW.RWL.CORE
{
    public class AccessoryReport : IDisposable
    {
        #region Constructor & Destructor
        public AccessoryReport(Page x_oPage, string x_sContentType)
        {
            if (x_sContentType != null) x_sContentType = x_sContentType.Trim();
            if (x_oPage != null && !string.IsNullOrEmpty(x_sContentType))
            {
                this.Page = x_oPage;
                this.ContentType = x_sContentType;
                this.AccessoryInfo = AccessoryInfo.CreateInfoInstanceObject();
                this.TableSetUp();
                this.Ds = AccessoryBal.ToEmptyDataSet(this.AccessoryInfo);
                this.Dt = this.Ds.Tables[Accessory.Para.TableName()];
                this.ReportHtmlTable = new HtmlTable();
                this.ReportHtmlTable.Border = 1;
            }
        }
        ~AccessoryReport() { }
        #endregion Constructor & Destructor
        #region Export Report
        public bool ExportReport()
        {
            if (this.Ds == null) { return false; }
            if (this.Dt == null) { return false; }
            if (this.Page == null) { return false; }
            if (this.ReportHtmlTable == null) { return false; }
            if (this.AccessoryInfo == null) { return false; }
            if (string.IsNullOrEmpty(this.FileName)) { return false; }
            if (string.IsNullOrEmpty(this.ContentType)) { return false; }
            DataSet _oDs = this.GetDataSet();
            if (_oDs != null)
            {
                HtmlTable _oHtmlTable = this.GetReportHtmlTable();
                HtmlTableRow _oHeadRow = new HtmlTableRow();
                AccessoryInfo _oAccessoryInfo = this.GetAccessoryInfo();
                SortedDictionary<int, HtmlTableCell> _oKeyHtmlHead = new SortedDictionary<int, HtmlTableCell>();
                SortedDictionary<int, int> _oKeyHtmlRowMap = new SortedDictionary<int, int>();
                for (int i = 0; i < _oDs.Tables[Accessory.Para.TableName()].Columns.Count; i++)
                {
                    DataColumn _oCol = _oDs.Tables[Accessory.Para.TableName()].Columns[i];
                    HtmlTableCell _oHtmlTableCell = new HtmlTableCell();
                    Field _oField = _oAccessoryInfo.GetTableSet().Fields(_oCol.ColumnName);
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
                for (int i = 0; i < _oDs.Tables[Accessory.Para.TableName()].Rows.Count; i++)
                {
                    DataRow _oDataRow = _oDs.Tables[Accessory.Para.TableName()].Rows[i];
                    HtmlTableRow _oTableRow = new HtmlTableRow();
                    SortedDictionary<int, HtmlTableCell> _oKeyHtmlRow = new SortedDictionary<int, HtmlTableCell>();
                    for (int r = 0; r < _oDs.Tables[Accessory.Para.TableName()].Columns.Count; r++)
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
            if (this.AccessoryInfo == null) return null;
            if (string.IsNullOrEmpty(this.FileName)) return null;
            if (string.IsNullOrEmpty(this.ContentType)) return null;
            IList<AccessoryEntity> _oAccessoryList = AccessoryDalDAO.FindAll(this.StartRecordIndex, this.LimitRecordIndex, Accessory.Para.mid);
            for (int i = 0; i < _oAccessoryList.Count; i++)
            {
                if (_oAccessoryList[i].active == true)
                {
                    DataRow _oRw = this.Dt.NewRow();
                    if (this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.active).IsView) { _oRw[Accessory.Para.active] = _oAccessoryList[i].active; }
                    if (this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.cdate).IsView) { _oRw[Accessory.Para.cdate] = _oAccessoryList[i].cdate; }
                    if (this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.cid).IsView) { _oRw[Accessory.Para.cid] = _oAccessoryList[i].cid; }
                    if (this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.accessory_price).IsView) { _oRw[Accessory.Para.accessory_price] = _oAccessoryList[i].accessory_price; }
                    if (this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.sdate).IsView) { _oRw[Accessory.Para.sdate] = _oAccessoryList[i].sdate; }
                    if (this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.accessory_desc).IsView) { _oRw[Accessory.Para.accessory_desc] = _oAccessoryList[i].accessory_desc; }
                    if (this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.last_stock).IsView) { _oRw[Accessory.Para.last_stock] = _oAccessoryList[i].last_stock; }
                    if (this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.edate).IsView) { _oRw[Accessory.Para.edate] = _oAccessoryList[i].edate; }
                    if (this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.accessory_code).IsView) { _oRw[Accessory.Para.accessory_code] = _oAccessoryList[i].accessory_code; }
                    if (this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.ddate).IsView) { _oRw[Accessory.Para.ddate] = _oAccessoryList[i].ddate; }
                    if (this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.mid).IsView) { _oRw[Accessory.Para.mid] = _oAccessoryList[i].mid; }
                    if (this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.did).IsView) { _oRw[Accessory.Para.did] = _oAccessoryList[i].did; }
                    if (this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.quota).IsView) { _oRw[Accessory.Para.quota] = _oAccessoryList[i].quota; }
                    this.Dt.Rows.Add(_oRw);
                }
            }
            return this.Ds;
        }
        #endregion
        #region TableSetUp
        public bool TableSetUp()
        {
            if (this.AccessoryInfo == null) return false;
            #region Report Column Index Setting
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.active).ReportColumnIndex = 0;
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.cdate).ReportColumnIndex = 1;
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.cid).ReportColumnIndex = 2;
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.accessory_price).ReportColumnIndex = 3;
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.sdate).ReportColumnIndex = 4;
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.accessory_desc).ReportColumnIndex = 5;
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.last_stock).ReportColumnIndex = 6;
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.edate).ReportColumnIndex = 7;
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.accessory_code).ReportColumnIndex = 8;
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.ddate).ReportColumnIndex = 9;
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.mid).ReportColumnIndex = 10;
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.did).ReportColumnIndex = 11;
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.quota).ReportColumnIndex = 12;
            #endregion
            #region Report Column Name Setting
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.active).ReportColumnName = "active";
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.cdate).ReportColumnName = "cdate";
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.cid).ReportColumnName = "cid";
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.accessory_price).ReportColumnName = "accessory_price";
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.sdate).ReportColumnName = "sdate";
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.accessory_desc).ReportColumnName = "accessory_desc";
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.last_stock).ReportColumnName = "last_stock";
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.edate).ReportColumnName = "edate";
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.accessory_code).ReportColumnName = "accessory_code";
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.ddate).ReportColumnName = "ddate";
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.mid).ReportColumnName = "mid";
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.did).ReportColumnName = "did";
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.quota).ReportColumnName = "quota";
            #endregion
            #region Report View Setting
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.active).IsView = true;
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.cdate).IsView = true;
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.cid).IsView = true;
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.accessory_price).IsView = true;
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.sdate).IsView = true;
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.accessory_desc).IsView = true;
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.last_stock).IsView = true;
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.edate).IsView = true;
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.accessory_code).IsView = true;
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.ddate).IsView = true;
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.mid).IsView = true;
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.did).IsView = true;
            this.AccessoryInfo.GetTableSet().Fields(Accessory.Para.quota).IsView = true;
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
        protected AccessoryInfo n_oAccessoryInfo = null;
        #region AccessoryInfo
        public AccessoryInfo AccessoryInfo
        {
            get
            {
                return this.n_oAccessoryInfo;
            }
            set
            {
                this.n_oAccessoryInfo = value;
            }
        }
        #endregion AccessoryInfo

        #region Get & Set
        public int GetStartRecordIndex() { return this.StartRecordIndex; }
        public int GetLimitRecordIndex() { return this.LimitRecordIndex; }
        public HtmlTable GetReportHtmlTable() { return this.ReportHtmlTable; }
        public DataSet GetDs() { return this.Ds; }
        public string GetFileName() { return this.FileName; }
        public Page GetPage() { return this.Page; }
        public string GetContentType() { return this.ContentType; }
        public DataTable GetDt() { return this.Dt; }
        public AccessoryInfo GetAccessoryInfo() { return this.AccessoryInfo; }
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
        public bool SetAccessoryInfo(AccessoryInfo value)
        {
            this.AccessoryInfo = value;
            return true;
        }
        #endregion
        #region Equals
        public bool Equals(AccessoryReport x_oObj)
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
            if (!this.AccessoryInfo.Equals(x_oObj.AccessoryInfo)) { return false; }
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
            this.AccessoryInfo = null;
        }
        #endregion Release
        #region Clone
        public AccessoryReport DeepClone()
        {
            AccessoryReport AccessoryReport_Clone = new AccessoryReport(null, null);
            AccessoryReport_Clone.SetStartRecordIndex(this.StartRecordIndex);
            AccessoryReport_Clone.SetLimitRecordIndex(this.LimitRecordIndex);
            AccessoryReport_Clone.SetReportHtmlTable(this.ReportHtmlTable);
            AccessoryReport_Clone.SetDs(this.Ds);
            AccessoryReport_Clone.SetFileName(this.FileName);
            AccessoryReport_Clone.SetPage(this.Page);
            AccessoryReport_Clone.SetContentType(this.ContentType);
            AccessoryReport_Clone.SetDt(this.Dt);
            AccessoryReport_Clone.SetAccessoryInfo(this.AccessoryInfo);
            return AccessoryReport_Clone;
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
