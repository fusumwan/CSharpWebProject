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
///-- Create date: <Create Date 2009-10-05>
///-- Description:	<Description,Class :GiftBasketReport, Data Report Control>
///-- =============================================
namespace PCCW.RWL.CORE
{
    public class GiftBasketReport : IDisposable
    {
        #region Constructor & Destructor
        public GiftBasketReport(Page x_oPage, string x_sContentType)
        {
            if (x_sContentType != null) x_sContentType = x_sContentType.Trim();
            if (x_oPage != null && !string.IsNullOrEmpty(x_sContentType))
            {
                this.Page = x_oPage;
                this.ContentType = x_sContentType;
                this.GiftBasketInfo = GiftBasketInfo.CreateInfoInstanceObject();
                this.TableSetUp();
                this.Ds = GiftBasketBal.ToEmptyDataSet(this.GiftBasketInfo);
                this.Dt = this.Ds.Tables[GiftBasket.Para.TableName()];
                this.ReportHtmlTable = new HtmlTable();
                this.ReportHtmlTable.Border = 1;
            }
        }
        ~GiftBasketReport() { }
        #endregion Constructor & Destructor
        #region Export Report
        public bool ExportReport()
        {
            if (this.Ds == null) { return false; }
            if (this.Dt == null) { return false; }
            if (this.Page == null) { return false; }
            if (this.ReportHtmlTable == null) { return false; }
            if (this.GiftBasketInfo == null) { return false; }
            if (string.IsNullOrEmpty(this.FileName)) { return false; }
            if (string.IsNullOrEmpty(this.ContentType)) { return false; }
            DataSet _oDs = this.GetDataSet();
            if (_oDs != null)
            {
                HtmlTable _oHtmlTable = this.GetReportHtmlTable();
                HtmlTableRow _oHeadRow = new HtmlTableRow();
                GiftBasketInfo _oGiftBasketInfo = this.GetGiftBasketInfo();
                SortedDictionary<int, HtmlTableCell> _oKeyHtmlHead = new SortedDictionary<int, HtmlTableCell>();
                SortedDictionary<int, int> _oKeyHtmlRowMap = new SortedDictionary<int, int>();
                for (int i = 0; i < _oDs.Tables[GiftBasket.Para.TableName()].Columns.Count; i++)
                {
                    DataColumn _oCol = _oDs.Tables[GiftBasket.Para.TableName()].Columns[i];
                    HtmlTableCell _oHtmlTableCell = new HtmlTableCell();
                    Field _oField = _oGiftBasketInfo.GetTableSet().Fields(_oCol.ColumnName);
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
                for (int i = 0; i < _oDs.Tables[GiftBasket.Para.TableName()].Rows.Count; i++)
                {
                    DataRow _oDataRow = _oDs.Tables[GiftBasket.Para.TableName()].Rows[i];
                    HtmlTableRow _oTableRow = new HtmlTableRow();
                    SortedDictionary<int, HtmlTableCell> _oKeyHtmlRow = new SortedDictionary<int, HtmlTableCell>();
                    for (int r = 0; r < _oDs.Tables[GiftBasket.Para.TableName()].Columns.Count; r++)
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
            if (this.GiftBasketInfo == null) return null;
            if (string.IsNullOrEmpty(this.FileName)) return null;
            if (string.IsNullOrEmpty(this.ContentType)) return null;
            IList<GiftBasketEntity> _oGiftBasketList = GiftBasketDalDAO.FindAll(this.StartRecordIndex, this.LimitRecordIndex, GiftBasket.Para.mid);
            for (int i = 0; i < _oGiftBasketList.Count; i++)
            {
                if (_oGiftBasketList[i].active == true)
                {
                    DataRow _oRw = this.Dt.NewRow();
                    if (this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.active).IsView) { _oRw[GiftBasket.Para.active] = _oGiftBasketList[i].active; }
                    if (this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.cdate).IsView) { _oRw[GiftBasket.Para.cdate] = _oGiftBasketList[i].cdate; }
                    if (this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.cid).IsView) { _oRw[GiftBasket.Para.cid] = _oGiftBasketList[i].cid; }
                    if (this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.gift_code).IsView) { _oRw[GiftBasket.Para.gift_code] = _oGiftBasketList[i].gift_code; }
                    if (this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.sdate).IsView) { _oRw[GiftBasket.Para.sdate] = _oGiftBasketList[i].sdate; }
                    if (this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.last_stock).IsView) { _oRw[GiftBasket.Para.last_stock] = _oGiftBasketList[i].last_stock; }
                    if (this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.edate).IsView) { _oRw[GiftBasket.Para.edate] = _oGiftBasketList[i].edate; }
                    if (this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.gift_desc).IsView) { _oRw[GiftBasket.Para.gift_desc] = _oGiftBasketList[i].gift_desc; }
                    if (this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.gift_gp).IsView) { _oRw[GiftBasket.Para.gift_gp] = _oGiftBasketList[i].gift_gp; }
                    if (this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.ddate).IsView) { _oRw[GiftBasket.Para.ddate] = _oGiftBasketList[i].ddate; }
                    if (this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.mid).IsView) { _oRw[GiftBasket.Para.mid] = _oGiftBasketList[i].mid; }
                    if (this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.did).IsView) { _oRw[GiftBasket.Para.did] = _oGiftBasketList[i].did; }
                    if (this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.quota).IsView) { _oRw[GiftBasket.Para.quota] = _oGiftBasketList[i].quota; }
                    this.Dt.Rows.Add(_oRw);
                }
            }
            return this.Ds;
        }
        #endregion
        #region TableSetUp
        public bool TableSetUp()
        {
            if (this.GiftBasketInfo == null) return false;
            #region Report Column Index Setting
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.active).ReportColumnIndex = 0;
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.cdate).ReportColumnIndex = 1;
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.cid).ReportColumnIndex = 2;
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.gift_code).ReportColumnIndex = 3;
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.sdate).ReportColumnIndex = 4;
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.last_stock).ReportColumnIndex = 5;
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.edate).ReportColumnIndex = 6;
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.gift_desc).ReportColumnIndex = 7;
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.gift_gp).ReportColumnIndex = 8;
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.ddate).ReportColumnIndex = 9;
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.mid).ReportColumnIndex = 10;
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.did).ReportColumnIndex = 11;
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.quota).ReportColumnIndex = 12;
            #endregion
            #region Report Column Name Setting
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.active).ReportColumnName = "active";
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.cdate).ReportColumnName = "cdate";
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.cid).ReportColumnName = "cid";
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.gift_code).ReportColumnName = "gift_code";
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.sdate).ReportColumnName = "sdate";
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.last_stock).ReportColumnName = "last_stock";
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.edate).ReportColumnName = "edate";
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.gift_desc).ReportColumnName = "gift_desc";
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.gift_gp).ReportColumnName = "gift_gp";
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.ddate).ReportColumnName = "ddate";
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.mid).ReportColumnName = "mid";
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.did).ReportColumnName = "did";
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.quota).ReportColumnName = "quota";
            #endregion
            #region Report View Setting
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.active).IsView = true;
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.cdate).IsView = true;
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.cid).IsView = true;
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.gift_code).IsView = true;
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.sdate).IsView = true;
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.last_stock).IsView = true;
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.edate).IsView = true;
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.gift_desc).IsView = true;
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.gift_gp).IsView = true;
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.ddate).IsView = true;
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.mid).IsView = true;
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.did).IsView = true;
            this.GiftBasketInfo.GetTableSet().Fields(GiftBasket.Para.quota).IsView = true;
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
        protected GiftBasketInfo n_oGiftBasketInfo = null;
        #region GiftBasketInfo
        public GiftBasketInfo GiftBasketInfo
        {
            get
            {
                return this.n_oGiftBasketInfo;
            }
            set
            {
                this.n_oGiftBasketInfo = value;
            }
        }
        #endregion GiftBasketInfo

        #region Get & Set
        public int GetStartRecordIndex() { return this.StartRecordIndex; }
        public int GetLimitRecordIndex() { return this.LimitRecordIndex; }
        public HtmlTable GetReportHtmlTable() { return this.ReportHtmlTable; }
        public DataSet GetDs() { return this.Ds; }
        public string GetFileName() { return this.FileName; }
        public Page GetPage() { return this.Page; }
        public string GetContentType() { return this.ContentType; }
        public DataTable GetDt() { return this.Dt; }
        public GiftBasketInfo GetGiftBasketInfo() { return this.GiftBasketInfo; }
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
        public bool SetGiftBasketInfo(GiftBasketInfo value)
        {
            this.GiftBasketInfo = value;
            return true;
        }
        #endregion
        #region Equals
        public bool Equals(GiftBasketReport x_oObj)
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
            if (!this.GiftBasketInfo.Equals(x_oObj.GiftBasketInfo)) { return false; }
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
            this.GiftBasketInfo = null;
        }
        #endregion Release
        #region Clone
        public GiftBasketReport DeepClone()
        {
            GiftBasketReport GiftBasketReport_Clone = new GiftBasketReport(null, null);
            GiftBasketReport_Clone.SetStartRecordIndex(this.StartRecordIndex);
            GiftBasketReport_Clone.SetLimitRecordIndex(this.LimitRecordIndex);
            GiftBasketReport_Clone.SetReportHtmlTable(this.ReportHtmlTable);
            GiftBasketReport_Clone.SetDs(this.Ds);
            GiftBasketReport_Clone.SetFileName(this.FileName);
            GiftBasketReport_Clone.SetPage(this.Page);
            GiftBasketReport_Clone.SetContentType(this.ContentType);
            GiftBasketReport_Clone.SetDt(this.Dt);
            GiftBasketReport_Clone.SetGiftBasketInfo(this.GiftBasketInfo);
            return GiftBasketReport_Clone;
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
