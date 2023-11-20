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
///-- Description:	<Description,Class :MobileOrderReportReport, Data Report Control>
///-- =============================================
namespace PCCW.RWL.CORE{
    public class MobileOrderReportReport : IDisposable
    {
        #region Constructor & Destructor
        public MobileOrderReportReport(Page x_oPage, string x_sContentType)
        {
            if (x_sContentType != null) x_sContentType = x_sContentType.Trim();
            if (x_oPage != null && !string.IsNullOrEmpty(x_sContentType))
            {
                this.Page = x_oPage;
                this.ContentType = x_sContentType;
                this.MobileOrderReportInfo = MobileOrderReportInfo.CreateInfoInstanceObject();
                this.TableSetUp();
                this.Ds = MobileOrderReportBal.ToEmptyDataSet(this.MobileOrderReportInfo);
                this.Dt = this.Ds.Tables[MobileOrderReport.Para.TableName()];
                this.ReportHtmlTable = new HtmlTable();
                this.ReportHtmlTable.Border = 1;
            }
        }
        ~MobileOrderReportReport() { }
        #endregion Constructor & Destructor
        #region Export Report
        public bool ExportReport()
        {
            if (this.Ds == null) { return false; }
            if (this.Dt == null) { return false; }
            if (this.Page == null) { return false; }
            if (this.ReportHtmlTable == null) { return false; }
            if (this.MobileOrderReportInfo == null) { return false; }
            if (string.IsNullOrEmpty(this.FileName)) { return false; }
            if (string.IsNullOrEmpty(this.ContentType)) { return false; }
            DataSet _oDs = this.GetDataSet();
            if (_oDs != null)
            {
                HtmlTable _oHtmlTable = this.GetReportHtmlTable();
                HtmlTableRow _oHeadRow = new HtmlTableRow();
                MobileOrderReportInfo _oMobileOrderReportInfo = this.GetMobileOrderReportInfo();
                SortedDictionary<int, HtmlTableCell> _oKeyHtmlHead = new SortedDictionary<int, HtmlTableCell>();
                SortedDictionary<int, int> _oKeyHtmlRowMap = new SortedDictionary<int, int>();
                for (int i = 0; i < _oDs.Tables[MobileOrderReport.Para.TableName()].Columns.Count; i++)
                {
                    DataColumn _oCol = _oDs.Tables[MobileOrderReport.Para.TableName()].Columns[i];
                    HtmlTableCell _oHtmlTableCell = new HtmlTableCell();
                    Field _oField = _oMobileOrderReportInfo.GetTableSet().Fields(_oCol.ColumnName);
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
                for (int i = 0; i < _oDs.Tables[MobileOrderReport.Para.TableName()].Rows.Count; i++)
                {
                    DataRow _oDataRow = _oDs.Tables[MobileOrderReport.Para.TableName()].Rows[i];
                    HtmlTableRow _oTableRow = new HtmlTableRow();
                    SortedDictionary<int, HtmlTableCell> _oKeyHtmlRow = new SortedDictionary<int, HtmlTableCell>();
                    for (int r = 0; r < _oDs.Tables[MobileOrderReport.Para.TableName()].Columns.Count; r++)
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
            if (this.MobileOrderReportInfo == null) return null;
            if (string.IsNullOrEmpty(this.FileName)) return null;
            if (string.IsNullOrEmpty(this.ContentType)) return null;
            IList<MobileOrderReportEntity> _oMobileOrderReportList = MobileOrderReportDalDAO.FindAll(this.StartRecordIndex, this.LimitRecordIndex, MobileOrderReport.Para.mid);
            for (int i = 0; i < _oMobileOrderReportList.Count; i++)
            {
                DataRow _oRw = this.Dt.NewRow();
                if (this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.order_status).IsView) { _oRw[MobileOrderReport.Para.order_status] = _oMobileOrderReportList[i].order_status; }
                if (this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.gw_retrieve_sn).IsView) { _oRw[MobileOrderReport.Para.gw_retrieve_sn] = _oMobileOrderReportList[i].gw_retrieve_sn; }
                if (this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.sent_again).IsView) { _oRw[MobileOrderReport.Para.sent_again] = _oMobileOrderReportList[i].sent_again; }
                if (this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.mid).IsView) { _oRw[MobileOrderReport.Para.mid] = _oMobileOrderReportList[i].mid; }
                if (this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.email_date).IsView) { _oRw[MobileOrderReport.Para.email_date] = _oMobileOrderReportList[i].email_date; }
                if (this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.retrieve_cnt).IsView) { _oRw[MobileOrderReport.Para.retrieve_cnt] = _oMobileOrderReportList[i].retrieve_cnt; }
                if (this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.cdate).IsView) { _oRw[MobileOrderReport.Para.cdate] = _oMobileOrderReportList[i].cdate; }
                if (this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.retrieve_sn).IsView) { _oRw[MobileOrderReport.Para.retrieve_sn] = _oMobileOrderReportList[i].retrieve_sn; }
                if (this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.cid).IsView) { _oRw[MobileOrderReport.Para.cid] = _oMobileOrderReportList[i].cid; }
                if (this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.did).IsView) { _oRw[MobileOrderReport.Para.did] = _oMobileOrderReportList[i].did; }
                if (this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.idd_vas).IsView) { _oRw[MobileOrderReport.Para.idd_vas] = _oMobileOrderReportList[i].idd_vas; }
                if (this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.active).IsView) { _oRw[MobileOrderReport.Para.active] = _oMobileOrderReportList[i].active; }
                if (this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.fallout_reason).IsView) { _oRw[MobileOrderReport.Para.fallout_reason] = _oMobileOrderReportList[i].fallout_reason; }
                if (this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.fallout_remark).IsView) { _oRw[MobileOrderReport.Para.fallout_remark] = _oMobileOrderReportList[i].fallout_remark; }
                if (this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.fallout_main_category).IsView) { _oRw[MobileOrderReport.Para.fallout_main_category] = _oMobileOrderReportList[i].fallout_main_category; }
                if (this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.report_type).IsView) { _oRw[MobileOrderReport.Para.report_type] = _oMobileOrderReportList[i].report_type; }
                if (this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.fallout_reply).IsView) { _oRw[MobileOrderReport.Para.fallout_reply] = _oMobileOrderReportList[i].fallout_reply; }
                if (this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.reactive_sn).IsView) { _oRw[MobileOrderReport.Para.reactive_sn] = _oMobileOrderReportList[i].reactive_sn; }
                if (this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.ddate).IsView) { _oRw[MobileOrderReport.Para.ddate] = _oMobileOrderReportList[i].ddate; }
                if (this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.ext_place_tel).IsView) { _oRw[MobileOrderReport.Para.ext_place_tel] = _oMobileOrderReportList[i].ext_place_tel; }
                if (this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.reactive_date).IsView) { _oRw[MobileOrderReport.Para.reactive_date] = _oMobileOrderReportList[i].reactive_date; }
                if (this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.gw_retrieve_date).IsView) { _oRw[MobileOrderReport.Para.gw_retrieve_date] = _oMobileOrderReportList[i].gw_retrieve_date; }
                if (this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.order_id).IsView) { _oRw[MobileOrderReport.Para.order_id] = _oMobileOrderReportList[i].order_id; }
                if (this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.retrieve_date).IsView) { _oRw[MobileOrderReport.Para.retrieve_date] = _oMobileOrderReportList[i].retrieve_date; }
                this.Dt.Rows.Add(_oRw);
            }
            return this.Ds;
        }
        #endregion
        #region TableSetUp
        public bool TableSetUp()
        {
            if (this.MobileOrderReportInfo == null) return false;
            #region Report Column Index Setting
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.order_status).ReportColumnIndex = 0;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.gw_retrieve_sn).ReportColumnIndex = 1;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.sent_again).ReportColumnIndex = 2;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.mid).ReportColumnIndex = 3;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.email_date).ReportColumnIndex = 4;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.retrieve_cnt).ReportColumnIndex = 5;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.cdate).ReportColumnIndex = 6;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.retrieve_sn).ReportColumnIndex = 7;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.cid).ReportColumnIndex = 8;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.did).ReportColumnIndex = 9;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.idd_vas).ReportColumnIndex = 10;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.active).ReportColumnIndex = 11;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.fallout_reason).ReportColumnIndex = 12;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.fallout_remark).ReportColumnIndex = 13;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.fallout_main_category).ReportColumnIndex = 14;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.report_type).ReportColumnIndex = 15;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.fallout_reply).ReportColumnIndex = 16;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.reactive_sn).ReportColumnIndex = 17;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.ddate).ReportColumnIndex = 18;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.ext_place_tel).ReportColumnIndex = 19;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.reactive_date).ReportColumnIndex = 20;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.gw_retrieve_date).ReportColumnIndex = 21;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.order_id).ReportColumnIndex = 22;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.retrieve_date).ReportColumnIndex = 23;
            #endregion
            #region Report Column Name Setting
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.order_status).ReportColumnName = "order_status";
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.gw_retrieve_sn).ReportColumnName = "gw_retrieve_sn";
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.sent_again).ReportColumnName = "sent_again";
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.mid).ReportColumnName = "mid";
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.email_date).ReportColumnName = "email_date";
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.retrieve_cnt).ReportColumnName = "retrieve_cnt";
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.cdate).ReportColumnName = "cdate";
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.retrieve_sn).ReportColumnName = "retrieve_sn";
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.cid).ReportColumnName = "cid";
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.did).ReportColumnName = "did";
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.idd_vas).ReportColumnName = "idd_vas";
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.active).ReportColumnName = "active";
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.fallout_reason).ReportColumnName = "fallout_reason";
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.fallout_remark).ReportColumnName = "fallout_remark";
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.fallout_main_category).ReportColumnName = "fallout_main_category";
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.report_type).ReportColumnName = "report_type";
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.fallout_reply).ReportColumnName = "fallout_reply";
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.reactive_sn).ReportColumnName = "reactive_sn";
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.ddate).ReportColumnName = "ddate";
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.ext_place_tel).ReportColumnName = "ext_place_tel";
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.reactive_date).ReportColumnName = "reactive_date";
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.gw_retrieve_date).ReportColumnName = "gw_retrieve_date";
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.order_id).ReportColumnName = "order_id";
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.retrieve_date).ReportColumnName = "retrieve_date";
            #endregion
            #region Report View Setting
            SetAllView(true);
            #endregion
            return true;
        }
        #endregion
        
        #region ResetTable
        public void ResetTable(MobileOrderReportInfo x_oMobileOrderReportInfo)
        {
            this.MobileOrderReportInfo = x_oMobileOrderReportInfo;
            this.Ds = MobileOrderReportBal.ToEmptyDataSet(this.MobileOrderReportInfo);
            this.Dt = this.Ds.Tables[MobileOrderReport.Para.TableName()];
        }
        #endregion
        
        #region SetAllView
        public void SetAllView(bool x_bView)
        {
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.order_status).IsView = true;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.gw_retrieve_sn).IsView = true;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.sent_again).IsView = true;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.mid).IsView = true;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.email_date).IsView = true;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.retrieve_cnt).IsView = true;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.cdate).IsView = true;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.retrieve_sn).IsView = true;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.cid).IsView = true;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.did).IsView = true;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.idd_vas).IsView = true;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.active).IsView = true;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.fallout_reason).IsView = true;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.fallout_remark).IsView = true;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.fallout_main_category).IsView = true;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.report_type).IsView = true;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.fallout_reply).IsView = true;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.reactive_sn).IsView = true;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.ddate).IsView = true;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.ext_place_tel).IsView = true;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.reactive_date).IsView = true;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.gw_retrieve_date).IsView = true;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.order_id).IsView = true;
            this.MobileOrderReportInfo.GetTableSet().Fields(MobileOrderReport.Para.retrieve_date).IsView = true;
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
        protected MobileOrderReportInfo n_oMobileOrderReportInfo = null;
        #region MobileOrderReportInfo
        public MobileOrderReportInfo MobileOrderReportInfo
        {
            get
            {
                return this.n_oMobileOrderReportInfo;
            }
            set
            {
                this.n_oMobileOrderReportInfo = value;
            }
        }
        #endregion MobileOrderReportInfo
        
        #region Get & Set
        public int GetStartRecordIndex() { return this.StartRecordIndex; }
        public int GetLimitRecordIndex() { return this.LimitRecordIndex; }
        public HtmlTable GetReportHtmlTable() { return this.ReportHtmlTable; }
        public DataSet GetDs() { return this.Ds; }
        public string GetFileName() { return this.FileName; }
        public Page GetPage() { return this.Page; }
        public string GetContentType() { return this.ContentType; }
        public DataTable GetDt() { return this.Dt; }
        public MobileOrderReportInfo GetMobileOrderReportInfo() { return this.MobileOrderReportInfo; }
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
        public bool SetMobileOrderReportInfo(MobileOrderReportInfo value)
        {
            this.MobileOrderReportInfo = value;
            return true;
        }
        #endregion
        #region Equals
        public bool Equals(MobileOrderReportReport x_oObj)
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
            if (!this.MobileOrderReportInfo.Equals(x_oObj.MobileOrderReportInfo)) { return false; }
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
            this.MobileOrderReportInfo = null;
        }
        #endregion Release
        #region Clone
        public MobileOrderReportReport DeepClone()
        {
            MobileOrderReportReport MobileOrderReportReport_Clone = new MobileOrderReportReport(null,null);
            MobileOrderReportReport_Clone.SetStartRecordIndex(this.StartRecordIndex);
            MobileOrderReportReport_Clone.SetLimitRecordIndex(this.LimitRecordIndex);
            MobileOrderReportReport_Clone.SetReportHtmlTable(this.ReportHtmlTable);
            MobileOrderReportReport_Clone.SetDs(this.Ds);
            MobileOrderReportReport_Clone.SetFileName(this.FileName);
            MobileOrderReportReport_Clone.SetPage(this.Page);
            MobileOrderReportReport_Clone.SetContentType(this.ContentType);
            MobileOrderReportReport_Clone.SetDt(this.Dt);
            MobileOrderReportReport_Clone.SetMobileOrderReportInfo(this.MobileOrderReportInfo);
            return MobileOrderReportReport_Clone;
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

