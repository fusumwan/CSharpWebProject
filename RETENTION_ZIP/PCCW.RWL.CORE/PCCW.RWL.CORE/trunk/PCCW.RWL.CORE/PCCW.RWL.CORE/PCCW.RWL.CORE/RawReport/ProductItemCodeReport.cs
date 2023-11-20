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
///-- Description:	<Description,Class :ProductItemCodeReport, Data Report Control>
///-- =============================================
namespace PCCW.RWL.CORE
{
    public class ProductItemCodeReport : IDisposable
    {
        #region Constructor & Destructor
        public ProductItemCodeReport(Page x_oPage, string x_sContentType)
        {
            if (x_sContentType != null) x_sContentType = x_sContentType.Trim();
            if (x_oPage != null && !string.IsNullOrEmpty(x_sContentType))
            {
                this.Page = x_oPage;
                this.ContentType = x_sContentType;
                this.ProductItemCodeInfo = ProductItemCodeInfo.CreateInfoInstanceObject();
                this.TableSetUp();
                this.Ds = ProductItemCodeBal.ToEmptyDataSet(this.ProductItemCodeInfo);
                this.Dt = this.Ds.Tables[ProductItemCode.Para.TableName()];
                this.ReportHtmlTable = new HtmlTable();
                this.ReportHtmlTable.Border = 1;
            }
        }
        ~ProductItemCodeReport() { }
        #endregion Constructor & Destructor
        #region Export Report
        public bool ExportReport()
        {
            if (this.Ds == null) { return false; }
            if (this.Dt == null) { return false; }
            if (this.Page == null) { return false; }
            if (this.ReportHtmlTable == null) { return false; }
            if (this.ProductItemCodeInfo == null) { return false; }
            if (string.IsNullOrEmpty(this.FileName)) { return false; }
            if (string.IsNullOrEmpty(this.ContentType)) { return false; }
            DataSet _oDs = this.GetDataSet();
            if (_oDs != null)
            {
                HtmlTable _oHtmlTable = this.GetReportHtmlTable();
                HtmlTableRow _oHeadRow = new HtmlTableRow();
                ProductItemCodeInfo _oProductItemCodeInfo = this.GetProductItemCodeInfo();
                SortedDictionary<int, HtmlTableCell> _oKeyHtmlHead = new SortedDictionary<int, HtmlTableCell>();
                SortedDictionary<int, int> _oKeyHtmlRowMap = new SortedDictionary<int, int>();
                for (int i = 0; i < _oDs.Tables[ProductItemCode.Para.TableName()].Columns.Count; i++)
                {
                    DataColumn _oCol = _oDs.Tables[ProductItemCode.Para.TableName()].Columns[i];
                    HtmlTableCell _oHtmlTableCell = new HtmlTableCell();
                    Field _oField = _oProductItemCodeInfo.GetTableSet().Fields(_oCol.ColumnName);
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
                for (int i = 0; i < _oDs.Tables[ProductItemCode.Para.TableName()].Rows.Count; i++)
                {
                    DataRow _oDataRow = _oDs.Tables[ProductItemCode.Para.TableName()].Rows[i];
                    HtmlTableRow _oTableRow = new HtmlTableRow();
                    SortedDictionary<int, HtmlTableCell> _oKeyHtmlRow = new SortedDictionary<int, HtmlTableCell>();
                    for (int r = 0; r < _oDs.Tables[ProductItemCode.Para.TableName()].Columns.Count; r++)
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
            if (this.ProductItemCodeInfo == null) return null;
            if (string.IsNullOrEmpty(this.FileName)) return null;
            if (string.IsNullOrEmpty(this.ContentType)) return null;
            IList<ProductItemCodeEntity> _oProductItemCodeList = ProductItemCodeDalDAO.FindAll(this.StartRecordIndex, this.LimitRecordIndex, ProductItemCode.Para.mid);
            for (int i = 0; i < _oProductItemCodeList.Count; i++)
            {
                if (_oProductItemCodeList[i].active == true)
                {
                    DataRow _oRw = this.Dt.NewRow();
                    if (this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.active).IsView) { _oRw[ProductItemCode.Para.active] = _oProductItemCodeList[i].active; }
                    if (this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.cdate).IsView) { _oRw[ProductItemCode.Para.cdate] = _oProductItemCodeList[i].cdate; }
                    if (this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.cid).IsView) { _oRw[ProductItemCode.Para.cid] = _oProductItemCodeList[i].cid; }
                    if (this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.did).IsView) { _oRw[ProductItemCode.Para.did] = _oProductItemCodeList[i].did; }
                    if (this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.type).IsView) { _oRw[ProductItemCode.Para.type] = _oProductItemCodeList[i].type; }
                    if (this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.hs_model).IsView) { _oRw[ProductItemCode.Para.hs_model] = _oProductItemCodeList[i].hs_model; }
                    if (this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.last_stock).IsView) { _oRw[ProductItemCode.Para.last_stock] = _oProductItemCodeList[i].last_stock; }
                    if (this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.item_code).IsView) { _oRw[ProductItemCode.Para.item_code] = _oProductItemCodeList[i].item_code; }
                    if (this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.edate).IsView) { _oRw[ProductItemCode.Para.edate] = _oProductItemCodeList[i].edate; }
                    if (this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.ddate).IsView) { _oRw[ProductItemCode.Para.ddate] = _oProductItemCodeList[i].ddate; }
                    if (this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.mid).IsView) { _oRw[ProductItemCode.Para.mid] = _oProductItemCodeList[i].mid; }
                    if (this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.sdate).IsView) { _oRw[ProductItemCode.Para.sdate] = _oProductItemCodeList[i].sdate; }
                    if (this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.quota).IsView) { _oRw[ProductItemCode.Para.quota] = _oProductItemCodeList[i].quota; }
                    this.Dt.Rows.Add(_oRw);
                }
            }
            return this.Ds;
        }
        #endregion
        #region TableSetUp
        public bool TableSetUp()
        {
            if (this.ProductItemCodeInfo == null) return false;
            #region Report Column Index Setting
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.active).ReportColumnIndex = 0;
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.cdate).ReportColumnIndex = 1;
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.cid).ReportColumnIndex = 2;
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.did).ReportColumnIndex = 3;
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.type).ReportColumnIndex = 4;
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.hs_model).ReportColumnIndex = 5;
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.last_stock).ReportColumnIndex = 6;
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.item_code).ReportColumnIndex = 7;
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.edate).ReportColumnIndex = 8;
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.ddate).ReportColumnIndex = 9;
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.mid).ReportColumnIndex = 10;
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.sdate).ReportColumnIndex = 11;
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.quota).ReportColumnIndex = 12;
            #endregion
            #region Report Column Name Setting
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.active).ReportColumnName = "active";
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.cdate).ReportColumnName = "cdate";
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.cid).ReportColumnName = "cid";
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.did).ReportColumnName = "did";
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.type).ReportColumnName = "type";
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.hs_model).ReportColumnName = "hs_model";
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.last_stock).ReportColumnName = "last_stock";
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.item_code).ReportColumnName = "item_code";
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.edate).ReportColumnName = "edate";
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.ddate).ReportColumnName = "ddate";
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.mid).ReportColumnName = "mid";
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.sdate).ReportColumnName = "sdate";
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.quota).ReportColumnName = "quota";
            #endregion
            #region Report View Setting
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.active).IsView = true;
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.cdate).IsView = true;
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.cid).IsView = true;
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.did).IsView = true;
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.type).IsView = true;
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.hs_model).IsView = true;
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.last_stock).IsView = true;
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.item_code).IsView = true;
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.edate).IsView = true;
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.ddate).IsView = true;
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.mid).IsView = true;
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.sdate).IsView = true;
            this.ProductItemCodeInfo.GetTableSet().Fields(ProductItemCode.Para.quota).IsView = true;
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
        protected ProductItemCodeInfo n_oProductItemCodeInfo = null;
        #region ProductItemCodeInfo
        public ProductItemCodeInfo ProductItemCodeInfo
        {
            get
            {
                return this.n_oProductItemCodeInfo;
            }
            set
            {
                this.n_oProductItemCodeInfo = value;
            }
        }
        #endregion ProductItemCodeInfo

        #region Get & Set
        public int GetStartRecordIndex() { return this.StartRecordIndex; }
        public int GetLimitRecordIndex() { return this.LimitRecordIndex; }
        public HtmlTable GetReportHtmlTable() { return this.ReportHtmlTable; }
        public DataSet GetDs() { return this.Ds; }
        public string GetFileName() { return this.FileName; }
        public Page GetPage() { return this.Page; }
        public string GetContentType() { return this.ContentType; }
        public DataTable GetDt() { return this.Dt; }
        public ProductItemCodeInfo GetProductItemCodeInfo() { return this.ProductItemCodeInfo; }
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
        public bool SetProductItemCodeInfo(ProductItemCodeInfo value)
        {
            this.ProductItemCodeInfo = value;
            return true;
        }
        #endregion
        #region Equals
        public bool Equals(ProductItemCodeReport x_oObj)
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
            if (!this.ProductItemCodeInfo.Equals(x_oObj.ProductItemCodeInfo)) { return false; }
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
            this.ProductItemCodeInfo = null;
        }
        #endregion Release
        #region Clone
        public ProductItemCodeReport DeepClone()
        {
            ProductItemCodeReport ProductItemCodeReport_Clone = new ProductItemCodeReport(null, null);
            ProductItemCodeReport_Clone.SetStartRecordIndex(this.StartRecordIndex);
            ProductItemCodeReport_Clone.SetLimitRecordIndex(this.LimitRecordIndex);
            ProductItemCodeReport_Clone.SetReportHtmlTable(this.ReportHtmlTable);
            ProductItemCodeReport_Clone.SetDs(this.Ds);
            ProductItemCodeReport_Clone.SetFileName(this.FileName);
            ProductItemCodeReport_Clone.SetPage(this.Page);
            ProductItemCodeReport_Clone.SetContentType(this.ContentType);
            ProductItemCodeReport_Clone.SetDt(this.Dt);
            ProductItemCodeReport_Clone.SetProductItemCodeInfo(this.ProductItemCodeInfo);
            return ProductItemCodeReport_Clone;
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
