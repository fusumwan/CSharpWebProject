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
using PCCW.RWL.COMMON;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using PCCW.RWL.CORE.WEBFUNC;
///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-10-05>
///-- Description:	<Description,Class :BusinessTradeReport, Data Report Control>
///-- =============================================
namespace PCCW.RWL.CORE
{
    public class BusinessTradeReport : IDisposable
    {
        
        #region Constructor & Destructor
        public BusinessTradeReport(Page x_oPage, string x_sContentType)
        {
            if (x_sContentType != null) x_sContentType = x_sContentType.Trim();
            if (x_oPage != null && !string.IsNullOrEmpty(x_sContentType))
            {
                this.Page = x_oPage;
                this.ContentType = x_sContentType;
                this.BusinessTradeInfo = BusinessTradeInfo.CreateInfoInstanceObject();
                this.TableSetUp();
                this.Ds = BusinessTradeBal.ToEmptyDataSet(this.BusinessTradeInfo);
                this.Dt = this.Ds.Tables[BusinessTrade.Para.TableName()];
                this.ReportHtmlTable = new HtmlTable();
                this.ReportHtmlTable.Border = 1;
            }
        }

        ~BusinessTradeReport() { }
        #endregion Constructor & Destructor

        #region ResetTable
        public void ResetTable(BusinessTradeInfo x_oBusinessTradeInfo)
        {
            this.BusinessTradeInfo = x_oBusinessTradeInfo;
            this.Ds = BusinessTradeBal.ToEmptyDataSet(this.BusinessTradeInfo);
            //this.Ds = GetEmptyDataSet();
            //this.Ds = new DataSet();
            if(this.Dt==null)
                this.Dt = this.Ds.Tables[BusinessTrade.Para.TableName()];
        }
        #endregion

        #region Export Report
        public bool ExportReport(bool x_bRealExcel, bool x_bZip)
        {
            if (this.Ds == null) { return false; }
            if (this.Dt == null) { return false; }
            if (this.Page == null) { return false; }
            if (this.ReportHtmlTable == null) { return false; }
            if (this.BusinessTradeInfo == null) { return false; }
            if (string.IsNullOrEmpty(this.FileName)) { return false; }
            if (string.IsNullOrEmpty(this.ContentType)) { return false; }
            DataSet _oDs = this.GetDataSetRS();
            
            
            if (_oDs != null)
            {
                if (x_bRealExcel == true)
                {
                    WebFunc.ExportDataSetToExcelAndZip(_oDs, BusinessTrade.Para.TableName(), x_bZip, Encoding.UTF8, PCCW.RWL.CORE.WEBFUNC.WebFunc.ExportContentType.Excel);
                }
                else
                {
                    HtmlTable _oHtmlTable = this.GetReportHtmlTable();
                    HtmlTableRow _oHeadRow = new HtmlTableRow();
                    BusinessTradeInfo _oBusinessTradeInfo = this.GetBusinessTradeInfo();
                    SortedDictionary<int, HtmlTableCell> _oKeyHtmlHead = new SortedDictionary<int, HtmlTableCell>();
                    SortedDictionary<int, int> _oKeyHtmlRowMap = new SortedDictionary<int, int>();
                    for (int i = 0; i < _oDs.Tables[BusinessTrade.Para.TableName()].Columns.Count; i++)
                    {
                        DataColumn _oCol = _oDs.Tables[BusinessTrade.Para.TableName()].Columns[i];
                        HtmlTableCell _oHtmlTableCell = new HtmlTableCell();
                        Field _oField = _oBusinessTradeInfo.GetTableSet().Fields(_oCol.ColumnName);
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
                    for (int i = 0; i < _oDs.Tables[BusinessTrade.Para.TableName()].Rows.Count; i++)
                    {

                        DataRow _oDataRow = _oDs.Tables[BusinessTrade.Para.TableName()].Rows[i];
                        HtmlTableRow _oTableRow = new HtmlTableRow();
                        SortedDictionary<int, HtmlTableCell> _oKeyHtmlRow = new SortedDictionary<int, HtmlTableCell>();
                        for (int r = 0; r < _oDs.Tables[BusinessTrade.Para.TableName()].Columns.Count; r++)
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
            }
            else
                return false;
            return true;
        }
        #endregion

        protected DataSet GetDataSetRS()
        {
            Dictionary<int, string> _oColumnSort = new Dictionary<int, string>();

            if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.mid).IsView) 
                _oColumnSort.Add(this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.mid).ReportColumnIndex, BusinessTrade.Para.mid);
            if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.issue_type).IsView)
                _oColumnSort.Add(this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.issue_type).ReportColumnIndex, BusinessTrade.Para.issue_type);
            if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.program).IsView) 
                _oColumnSort.Add(this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.program).ReportColumnIndex, BusinessTrade.Para.program);
            if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.normal_rebate_type).IsView)
                _oColumnSort.Add(this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.normal_rebate_type).ReportColumnIndex, BusinessTrade.Para.normal_rebate_type);
            if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.rate_plan).IsView) 
                _oColumnSort.Add(this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.rate_plan).ReportColumnIndex, BusinessTrade.Para.rate_plan);
            if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.con_per).IsView) 
                _oColumnSort.Add(this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.con_per).ReportColumnIndex, BusinessTrade.Para.con_per);
            if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.rebate).IsView) 
                _oColumnSort.Add(this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.rebate).ReportColumnIndex, BusinessTrade.Para.rebate);
            if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.free_mon).IsView) 
                _oColumnSort.Add(this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.free_mon).ReportColumnIndex, BusinessTrade.Para.free_mon);
            if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.hs_model).IsView) 
                _oColumnSort.Add(this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.hs_model).ReportColumnIndex, BusinessTrade.Para.hs_model);
            if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.hs_model_name).IsView) 
                _oColumnSort.Add(this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.hs_model_name).ReportColumnIndex, BusinessTrade.Para.hs_model_name);
            if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.premium_1).IsView) 
                _oColumnSort.Add(this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.premium_1).ReportColumnIndex, BusinessTrade.Para.premium_1);
            if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.premium_2).IsView) 
                _oColumnSort.Add(this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.premium_2).ReportColumnIndex, BusinessTrade.Para.premium_2);
            if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.trade_field).IsView) 
                _oColumnSort.Add(this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.trade_field).ReportColumnIndex, BusinessTrade.Para.trade_field);
            if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.bundle_name).IsView) 
                _oColumnSort.Add(this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.bundle_name).ReportColumnIndex, BusinessTrade.Para.bundle_name);
            if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.plan_fee).IsView) 
                _oColumnSort.Add(this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.plan_fee).ReportColumnIndex, BusinessTrade.Para.plan_fee);
            if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.channel).IsView) 
                _oColumnSort.Add(this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.channel).ReportColumnIndex, BusinessTrade.Para.channel);
            if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.sdate).IsView) 
                _oColumnSort.Add(this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.sdate).ReportColumnIndex, BusinessTrade.Para.sdate);
            if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.edate).IsView) 
                _oColumnSort.Add(this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.edate).ReportColumnIndex, BusinessTrade.Para.edate);
            if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.cid).IsView) 
                _oColumnSort.Add(this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.cid).ReportColumnIndex, BusinessTrade.Para.cid);
            if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.cdate).IsView) 
                _oColumnSort.Add(this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.cdate).ReportColumnIndex, BusinessTrade.Para.cdate);
            if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.did).IsView) 
                _oColumnSort.Add(this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.did).ReportColumnIndex, BusinessTrade.Para.did);
            if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.extra_offer).IsView) 
                _oColumnSort.Add(this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.extra_offer).ReportColumnIndex, BusinessTrade.Para.extra_offer);
            if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.ddate).IsView) 
                _oColumnSort.Add(this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.ddate).ReportColumnIndex, BusinessTrade.Para.ddate);
            if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.active).IsView) 
                _oColumnSort.Add(this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.active).ReportColumnIndex, BusinessTrade.Para.active);
            if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.cancel_renew).IsView) 
                _oColumnSort.Add(this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.cancel_renew).ReportColumnIndex, BusinessTrade.Para.cancel_renew);
            if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.ob_early).IsView) 
                _oColumnSort.Add(this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.ob_early).ReportColumnIndex, BusinessTrade.Para.ob_early);
            if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.po_date).IsView) 
                _oColumnSort.Add(this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.po_date).ReportColumnIndex, BusinessTrade.Para.po_date);
            if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.remarks).IsView) 
                _oColumnSort.Add(this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.remarks).ReportColumnIndex, BusinessTrade.Para.remarks);





            StringBuilder _oFilter = new StringBuilder();
            _oFilter.Append(" ( ");
            _oFilter.Append(" (program!='' AND program IS NOT NULL) OR  ");
            _oFilter.Append(" (normal_rebate_type!='' AND normal_rebate_type IS NOT NULL) OR  ");
            _oFilter.Append(" (rate_plan!='' AND rate_plan IS NOT NULL) OR  ");
            _oFilter.Append(" (con_per!='' AND con_per IS NOT NULL) OR  ");
            _oFilter.Append(" (rebate!='' AND rebate IS NOT NULL) OR  ");
            _oFilter.Append(" (free_mon!='' AND free_mon IS NOT NULL) OR  ");
            _oFilter.Append(" (hs_model!='' AND hs_model IS NOT NULL) OR  ");
            _oFilter.Append(" (hs_model_name!='' AND hs_model_name IS NOT NULL) OR  ");
            _oFilter.Append(" (premium_1!='' AND premium_1 IS NOT NULL) OR  ");
            _oFilter.Append(" (premium_2!='' AND premium_2 IS NOT NULL) OR  ");
            _oFilter.Append(" (trade_field!='' AND trade_field IS NOT NULL) OR  ");
            _oFilter.Append(" (bundle_name!='' AND bundle_name IS NOT NULL)  ");
            _oFilter.Append(" ) AND ");
            _oFilter.Append(" active=1 ");

            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append(" SELECT ");
            StringBuilder _oColumns = new StringBuilder();

            foreach (KeyValuePair<int, string> _oItem in _oColumnSort)
            {
                if (_oColumns.ToString() != string.Empty) _oColumns.Append(",");
                _oColumns.Append(_oItem.Value.ToString());
            }



            _oQuery.Append(_oColumns.ToString());
            _oQuery.Append(" FROM ");
            _oQuery.Append(" " + this.BusinessTradeInfo.GetTableSet().TableName + " WHERE  " + _oFilter.ToString() + " ORDER BY mid");

            return SYSConn<MSSQLConnect>.Connect().GetDS(_oQuery.ToString());
        }


        #region GetDataSet
        protected DataSet GetDataSet()
        {
            if (this.Ds == null) return null;
            if (this.Dt == null) return null;
            if (this.Page == null) return null;
            if (this.ReportHtmlTable == null) return null;
            if (this.BusinessTradeInfo == null) return null;
            if (string.IsNullOrEmpty(this.FileName)) return null;
            if (string.IsNullOrEmpty(this.ContentType)) return null;
            if (this.Ds.Tables.Count >= 1)
            {
                this.Ds.Tables[0].Rows.Clear();
            }
            IList<BusinessTradeEntity> _oBusinessTradeList = BusinessTradeDalDAO.FindAll(this.StartRecordIndex, this.LimitRecordIndex, BusinessTrade.Para.mid, "active=1");
            for (int i = 0; i < _oBusinessTradeList.Count; i++)
            {
                if (_oBusinessTradeList[i].active == true)
                {
                    DataRow _oRw = this.Dt.NewRow();
                    if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.mid).IsView) {
                        if (_oBusinessTradeList[i].mid != null)
                            _oRw[BusinessTrade.Para.mid] = _oBusinessTradeList[i].mid;
                        else
                            _oRw[BusinessTrade.Para.mid] = DBNull.Value;
                    }
                    if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.channel).IsView) {
                        if (!string.IsNullOrEmpty(_oBusinessTradeList[i].channel))
                            _oRw[BusinessTrade.Para.channel] = _oBusinessTradeList[i].channel;
                        else
                            _oRw[BusinessTrade.Para.channel] = DBNull.Value;
                    }
                    if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.cdate).IsView) {
                        if (_oBusinessTradeList[i].cdate!=null)
                            _oRw[BusinessTrade.Para.cdate] = _oBusinessTradeList[i].cdate;
                        else
                            _oRw[BusinessTrade.Para.cdate] = DBNull.Value;
                    }
                    if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.bundle_name).IsView) {
                        if (!string.IsNullOrEmpty(_oBusinessTradeList[i].bundle_name))
                            _oRw[BusinessTrade.Para.bundle_name] = _oBusinessTradeList[i].bundle_name;
                        else
                            _oRw[BusinessTrade.Para.bundle_name] = string.Empty;
                    }
                    if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.hs_model_name).IsView) {
                        if (!string.IsNullOrEmpty(_oBusinessTradeList[i].hs_model_name))
                            _oRw[BusinessTrade.Para.hs_model_name] = _oBusinessTradeList[i].hs_model_name;
                        else
                            _oRw[BusinessTrade.Para.hs_model_name] = string.Empty;
                    }

                    if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.trade_field).IsView) {
                        if (!string.IsNullOrEmpty(_oBusinessTradeList[i].trade_field))
                            _oRw[BusinessTrade.Para.trade_field] = _oBusinessTradeList[i].trade_field;
                        else
                            _oRw[BusinessTrade.Para.trade_field] = string.Empty;
                    }
                    if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.did).IsView) {
                        if (!string.IsNullOrEmpty(_oBusinessTradeList[i].did))
                            _oRw[BusinessTrade.Para.did] = _oBusinessTradeList[i].did;
                        else
                            _oRw[BusinessTrade.Para.did] = string.Empty;
                    }
                    if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.premium_1).IsView) {
                        if (!string.IsNullOrEmpty(_oBusinessTradeList[i].premium_1))
                            _oRw[BusinessTrade.Para.premium_1] = _oBusinessTradeList[i].premium_1;
                        else
                            _oRw[BusinessTrade.Para.premium_1] = string.Empty;
                    }
                    if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.sdate).IsView) {
                        if (_oBusinessTradeList[i].sdate!=null)
                            _oRw[BusinessTrade.Para.sdate] = _oBusinessTradeList[i].sdate;
                        else
                            _oRw[BusinessTrade.Para.sdate] = DBNull.Value;
                    }
                    if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.rebate).IsView) {
                        if (_oBusinessTradeList[i].rebate != null)
                            _oRw[BusinessTrade.Para.rebate] = _oBusinessTradeList[i].rebate;
                        else
                            _oRw[BusinessTrade.Para.rebate] = DBNull.Value;
                    }
                    if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.premium_2).IsView) {
                        if (!string.IsNullOrEmpty(_oBusinessTradeList[i].premium_2))
                            _oRw[BusinessTrade.Para.premium_2] = _oBusinessTradeList[i].premium_2;
                        else
                            _oRw[BusinessTrade.Para.premium_2] = string.Empty;
                    }
                    if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.normal_rebate_type).IsView) {
                        if (!string.IsNullOrEmpty(_oBusinessTradeList[i].normal_rebate_type))
                            _oRw[BusinessTrade.Para.normal_rebate_type] = _oBusinessTradeList[i].normal_rebate_type;
                        else
                            _oRw[BusinessTrade.Para.normal_rebate_type] = string.Empty;
                    }
                    if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.extra_offer).IsView) {
                        if (!string.IsNullOrEmpty(_oBusinessTradeList[i].extra_offer))
                            _oRw[BusinessTrade.Para.extra_offer] = _oBusinessTradeList[i].extra_offer;
                        else
                            _oRw[BusinessTrade.Para.extra_offer] = string.Empty;
                    }
                    if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.edate).IsView) {
                        if (_oBusinessTradeList[i].edate != null)
                            _oRw[BusinessTrade.Para.edate] = _oBusinessTradeList[i].edate;
                        else
                            _oRw[BusinessTrade.Para.edate] = DBNull.Value;
                    }
                    if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.program).IsView) {
                        if (!string.IsNullOrEmpty(_oBusinessTradeList[i].program))
                            _oRw[BusinessTrade.Para.program] = _oBusinessTradeList[i].program;
                        else
                            _oRw[BusinessTrade.Para.program] = string.Empty;
                    }
                    if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.con_per).IsView) {
                        if (!string.IsNullOrEmpty(_oBusinessTradeList[i].con_per))
                            _oRw[BusinessTrade.Para.con_per] = _oBusinessTradeList[i].con_per;
                        else
                            _oRw[BusinessTrade.Para.con_per] = string.Empty;
                    }
                    if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.rate_plan).IsView) {
                        if (!string.IsNullOrEmpty(_oBusinessTradeList[i].rate_plan))
                            _oRw[BusinessTrade.Para.rate_plan] = _oBusinessTradeList[i].rate_plan;
                        else
                            _oRw[BusinessTrade.Para.rate_plan] = string.Empty;
                    }
                    if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.ddate).IsView) {
                        if (_oBusinessTradeList[i].ddate != null)
                            _oRw[BusinessTrade.Para.ddate] = _oBusinessTradeList[i].ddate;
                        else
                            _oRw[BusinessTrade.Para.ddate] = DBNull.Value;
                    }
                    if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.active).IsView) {
                        if (_oBusinessTradeList[i].active != null)
                            _oRw[BusinessTrade.Para.active] = _oBusinessTradeList[i].active;
                        else
                            _oRw[BusinessTrade.Para.active] = DBNull.Value;
                    }
                    if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.free_mon).IsView) {
                        if (!string.IsNullOrEmpty(_oBusinessTradeList[i].free_mon))
                            _oRw[BusinessTrade.Para.free_mon] = _oBusinessTradeList[i].free_mon;
                        else
                            _oRw[BusinessTrade.Para.free_mon] = string.Empty;
                    }
                    if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.cid).IsView) {
                        if (!string.IsNullOrEmpty(_oBusinessTradeList[i].cid))
                            _oRw[BusinessTrade.Para.cid] = _oBusinessTradeList[i].cid;
                        else
                            _oRw[BusinessTrade.Para.cid] = string.Empty;
                    }
                    if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.cancel_renew).IsView) {
                        if (_oBusinessTradeList[i].cancel_renew!=null)
                            _oRw[BusinessTrade.Para.cancel_renew] = _oBusinessTradeList[i].cancel_renew;
                        else
                            _oRw[BusinessTrade.Para.cancel_renew] = DBNull.Value;
                    }
                    if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.ob_early).IsView) {
                        if (!string.IsNullOrEmpty(_oBusinessTradeList[i].ob_early))
                            _oRw[BusinessTrade.Para.ob_early] = _oBusinessTradeList[i].ob_early;
                        else
                            _oRw[BusinessTrade.Para.ob_early] = string.Empty;
                    }
                    if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.hs_model).IsView) {
                        if (!string.IsNullOrEmpty(_oBusinessTradeList[i].hs_model))
                            _oRw[BusinessTrade.Para.hs_model] = _oBusinessTradeList[i].hs_model;
                        else
                            _oRw[BusinessTrade.Para.hs_model] = string.Empty;
                    }
                    if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.plan_fee).IsView) {
                        if (!string.IsNullOrEmpty(_oBusinessTradeList[i].plan_fee))
                            _oRw[BusinessTrade.Para.plan_fee] = _oBusinessTradeList[i].plan_fee;
                        else
                            _oRw[BusinessTrade.Para.plan_fee] = string.Empty;
                    }
                    if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.po_date).IsView) {
                        if (_oBusinessTradeList[i].po_date != null)
                            _oRw[BusinessTrade.Para.po_date] = _oBusinessTradeList[i].po_date;
                        else
                            _oRw[BusinessTrade.Para.po_date] = DBNull.Value;
                    }
                    if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.remarks).IsView) {
                        if (!string.IsNullOrEmpty(_oBusinessTradeList[i].remarks))
                            _oRw[BusinessTrade.Para.remarks] = _oBusinessTradeList[i].remarks;
                        else
                            _oRw[BusinessTrade.Para.remarks] = string.Empty;
                    }

                    if (this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.issue_type).IsView)
                    {
                        if (!string.IsNullOrEmpty(_oBusinessTradeList[i].issue_type))
                            _oRw[BusinessTrade.Para.issue_type] = _oBusinessTradeList[i].issue_type;
                        else
                            _oRw[BusinessTrade.Para.issue_type] = string.Empty;
                    }
                    this.Dt.Rows.Add(_oRw);
                }
            }
            return this.Ds;
        }
        #endregion
        #region TableSetUp
        public bool TableSetUp()
        {
            if (this.BusinessTradeInfo == null) return false;
            #region Report Column Index Setting
           
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.mid).ReportColumnIndex = 0;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.issue_type).ReportColumnIndex = 1;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.program).ReportColumnIndex = 2;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.normal_rebate_type).ReportColumnIndex = 3;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.rate_plan).ReportColumnIndex = 4;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.con_per).ReportColumnIndex = 5;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.rebate).ReportColumnIndex = 6;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.free_mon).ReportColumnIndex = 7;
            
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.hs_model).ReportColumnIndex = 8;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.hs_model_name).ReportColumnIndex = 9;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.premium_1).ReportColumnIndex = 10;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.premium_2).ReportColumnIndex = 11;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.trade_field).ReportColumnIndex = 12;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.bundle_name).ReportColumnIndex = 13;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.plan_fee).ReportColumnIndex = 14;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.channel).ReportColumnIndex = 15;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.sdate).ReportColumnIndex = 16;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.edate).ReportColumnIndex = 17;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.cid).ReportColumnIndex = 18;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.cdate).ReportColumnIndex = 19;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.did).ReportColumnIndex = 20;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.extra_offer).ReportColumnIndex = 21;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.ddate).ReportColumnIndex = 22;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.active).ReportColumnIndex = 23;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.cancel_renew).ReportColumnIndex =24;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.ob_early).ReportColumnIndex = 25;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.po_date).ReportColumnIndex = 26;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.remarks).ReportColumnIndex = 27;
            
            #endregion
            #region Report Column Name Setting
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.mid).ReportColumnName = "mid";
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.channel).ReportColumnName = "channel";
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.cdate).ReportColumnName = "cdate";
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.bundle_name).ReportColumnName = "bundle_name";
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.hs_model_name).ReportColumnName = "hs_model_name";
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.trade_field).ReportColumnName = "trade_field";
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.did).ReportColumnName = "did";
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.premium_1).ReportColumnName = "premium_1";
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.sdate).ReportColumnName = "sdate";
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.rebate).ReportColumnName = "rebate";
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.premium_2).ReportColumnName = "premium_2";
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.extra_offer).ReportColumnName = "extra_offer";
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.edate).ReportColumnName = "edate";
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.program).ReportColumnName = "program";
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.con_per).ReportColumnName = "con_per";
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.rate_plan).ReportColumnName = "rate_plan";
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.ddate).ReportColumnName = "ddate";
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.active).ReportColumnName = "active";
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.free_mon).ReportColumnName = "free_mon";
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.cid).ReportColumnName = "cid";
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.cancel_renew).ReportColumnName = "cancel_renew";
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.ob_early).ReportColumnName = "ob_early";
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.hs_model).ReportColumnName = "hs_model";
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.plan_fee).ReportColumnName = "plan_fee";
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.po_date).ReportColumnName = "po_date";
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.remarks).ReportColumnName = "remarks";
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.normal_rebate_type).ReportColumnName = "normal_rebate_type";
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.issue_type).ReportColumnName = "issue_type";
            #endregion
            #region Report View Setting
            SetAllView(true);
            #endregion
            return true;
        }
        #endregion

        public void SetAllView(bool x_bView)
        {
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.mid).IsView = x_bView;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.channel).IsView = x_bView;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.cdate).IsView = x_bView;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.bundle_name).IsView = x_bView;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.hs_model_name).IsView = x_bView;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.trade_field).IsView = x_bView;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.did).IsView = x_bView;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.premium_1).IsView = x_bView;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.sdate).IsView = x_bView;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.rebate).IsView = x_bView;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.premium_2).IsView = x_bView;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.extra_offer).IsView = x_bView;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.edate).IsView = x_bView;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.program).IsView = x_bView;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.con_per).IsView = x_bView;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.rate_plan).IsView = x_bView;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.ddate).IsView = x_bView;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.active).IsView = x_bView;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.free_mon).IsView = x_bView;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.cid).IsView = x_bView;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.cancel_renew).IsView = x_bView;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.ob_early).IsView = x_bView;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.hs_model).IsView = x_bView;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.plan_fee).IsView = x_bView;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.po_date).IsView = x_bView;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.remarks).IsView = x_bView;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.normal_rebate_type).IsView = x_bView;
            this.BusinessTradeInfo.GetTableSet().Fields(BusinessTrade.Para.issue_type).IsView = x_bView;
        }

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
        protected BusinessTradeInfo n_oBusinessTradeInfo = null;
        #region BusinessTradeInfo
        public BusinessTradeInfo BusinessTradeInfo
        {
            get
            {
                return this.n_oBusinessTradeInfo;
            }
            set
            {
                this.n_oBusinessTradeInfo = value;
            }
        }
        #endregion BusinessTradeInfo

        #region Get & Set
        public int GetStartRecordIndex() { return this.StartRecordIndex; }
        public int GetLimitRecordIndex() { return this.LimitRecordIndex; }
        public HtmlTable GetReportHtmlTable() { return this.ReportHtmlTable; }
        public DataSet GetDs() { return this.Ds; }
        public string GetFileName() { return this.FileName; }
        public Page GetPage() { return this.Page; }
        public string GetContentType() { return this.ContentType; }
        public DataTable GetDt() { return this.Dt; }
        public BusinessTradeInfo GetBusinessTradeInfo() { return this.BusinessTradeInfo; }
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
        public bool SetBusinessTradeInfo(BusinessTradeInfo value)
        {
            this.BusinessTradeInfo = value;
            return true;
        }
        #endregion
        #region Equals
        public bool Equals(BusinessTradeReport x_oObj)
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
            if (!this.BusinessTradeInfo.Equals(x_oObj.BusinessTradeInfo)) { return false; }
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
            this.BusinessTradeInfo = null;
        }
        #endregion Release
        #region Clone
        public BusinessTradeReport DeepClone()
        {
            BusinessTradeReport BusinessTradeReport_Clone = new BusinessTradeReport(null, null);
            BusinessTradeReport_Clone.SetStartRecordIndex(this.StartRecordIndex);
            BusinessTradeReport_Clone.SetLimitRecordIndex(this.LimitRecordIndex);
            BusinessTradeReport_Clone.SetReportHtmlTable(this.ReportHtmlTable);
            BusinessTradeReport_Clone.SetDs(this.Ds);
            BusinessTradeReport_Clone.SetFileName(this.FileName);
            BusinessTradeReport_Clone.SetPage(this.Page);
            BusinessTradeReport_Clone.SetContentType(this.ContentType);
            BusinessTradeReport_Clone.SetDt(this.Dt);
            BusinessTradeReport_Clone.SetBusinessTradeInfo(this.BusinessTradeInfo);
            return BusinessTradeReport_Clone;
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
