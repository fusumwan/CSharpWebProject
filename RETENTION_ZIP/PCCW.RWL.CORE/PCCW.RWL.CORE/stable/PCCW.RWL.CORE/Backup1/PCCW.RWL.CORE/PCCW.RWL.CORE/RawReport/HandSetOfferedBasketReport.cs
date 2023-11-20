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
///-- Description:	<Description,Class :HandSetOfferedBasketReport, Data Report Control>
///-- =============================================
namespace PCCW.RWL.CORE
{
    public class HandSetOfferedBasketReport : IDisposable
    {
        protected DataSet OfferSet = null;


        #region Constructor & Destructor
        public HandSetOfferedBasketReport(Page x_oPage, string x_sContentType)
        {
            if (x_sContentType != null) x_sContentType = x_sContentType.Trim();
            if (x_oPage != null && !string.IsNullOrEmpty(x_sContentType))
            {
                this.Page = x_oPage;
                this.ContentType = x_sContentType;
                this.HandSetOfferedBasketInfo = HandSetOfferedBasketInfo.CreateInfoInstanceObject();
                this.TableSetUp();
                this.Ds = HandSetOfferedBasketBal.ToEmptyDataSet(this.HandSetOfferedBasketInfo);
                this.Dt = this.Ds.Tables[HandSetOfferedBasket.Para.TableName()];
                this.ReportHtmlTable = new HtmlTable();
                this.ReportHtmlTable.Border = 0;
                this.ReportHtmlTable.Rows.Clear();
                this.OfferSet = GetOfferSetList();
            }
        }
        ~HandSetOfferedBasketReport() { }

        protected DataSet GetOfferSetList()
        {
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("SELECT * FROM HandSetOfferType");
            return SYSConn<MSSQLConnect>.Connect().GetDS(_oQuery.ToString());
        }

        #endregion Constructor & Destructor
        #region Export Report
        public bool ExportReport(bool x_bRealExcel, bool x_bZip)
        {
            if (this.Ds == null) { return false; }
            if (this.Dt == null) { return false; }
            if (this.Page == null) { return false; }
            if (this.ReportHtmlTable == null) { return false; }
            if (this.HandSetOfferedBasketInfo == null) { return false; }
            if (string.IsNullOrEmpty(this.FileName)) { return false; }
            if (string.IsNullOrEmpty(this.ContentType)) { return false; }
            DataSet _oDs = this.GetDataSetRS();
            if (_oDs != null)
            {
                if (x_bRealExcel == true)
                {
                    WebFunc.ExportDataSetToExcelAndZip(_oDs, HandSetOfferedBasket.Para.TableName(), x_bZip, Encoding.UTF8, PCCW.RWL.CORE.WEBFUNC.WebFunc.ExportContentType.Excel);
                }
                else
                {
                    HtmlTable _oHtmlTable = this.GetReportHtmlTable();
                    HtmlTableRow _oHeadRow = new HtmlTableRow();
                    HandSetOfferedBasketInfo _oHandSetOfferedBasketInfo = this.GetHandSetOfferedBasketInfo();
                    SortedDictionary<int, HtmlTableCell> _oKeyHtmlHead = new SortedDictionary<int, HtmlTableCell>();
                    SortedDictionary<int, int> _oKeyHtmlRowMap = new SortedDictionary<int, int>();
                    for (int i = 0; i < _oDs.Tables[HandSetOfferedBasket.Para.TableName()].Columns.Count; i++)
                    {
                        DataColumn _oCol = _oDs.Tables[HandSetOfferedBasket.Para.TableName()].Columns[i];
                        HtmlTableCell _oHtmlTableCell = new HtmlTableCell();
                        Field _oField = _oHandSetOfferedBasketInfo.GetTableSet().Fields(_oCol.ColumnName);
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
                    for (int i = 0; i < _oDs.Tables[HandSetOfferedBasket.Para.TableName()].Rows.Count; i++)
                    {
                        DataRow _oDataRow = _oDs.Tables[HandSetOfferedBasket.Para.TableName()].Rows[i];
                        HtmlTableRow _oTableRow = new HtmlTableRow();
                        SortedDictionary<int, HtmlTableCell> _oKeyHtmlRow = new SortedDictionary<int, HtmlTableCell>();
                        for (int r = 0; r < _oDs.Tables[HandSetOfferedBasket.Para.TableName()].Columns.Count; r++)
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

        #region ResetTable
        public void ResetTable(HandSetOfferedBasketInfo x_oHandSetOfferedBasketInfo)
        {
            this.HandSetOfferedBasketInfo = x_oHandSetOfferedBasketInfo;
            this.Ds = HandSetOfferedBasketBal.ToEmptyDataSet(this.HandSetOfferedBasketInfo);
            //this.Ds = new DataSet();
            //this.Dt = this.Ds.Tables[0];
            this.Dt = this.Ds.Tables[HandSetOfferedBasket.Para.TableName()];
        }
        #endregion

        protected DataSet GetDataSetRS()
        {
            Dictionary<int, string> _oColumnSort = new Dictionary<int, string>();

            if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.mid).IsView)
                _oColumnSort.Add(this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.mid).ReportColumnIndex, HandSetOfferedBasket.Para.mid);
            if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.plan_fee).IsView)
                _oColumnSort.Add(this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.plan_fee).ReportColumnIndex, HandSetOfferedBasket.Para.plan_fee);
            if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.rebate_gp).IsView)
                _oColumnSort.Add(this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.rebate_gp).ReportColumnIndex, HandSetOfferedBasket.Para.rebate_gp);
            if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.normal_rebate_type).IsView)
                _oColumnSort.Add(this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.normal_rebate_type).ReportColumnIndex, HandSetOfferedBasket.Para.normal_rebate_type);
            string _sOffer_type_id = "'offer_type_id'=(SELECT TOP 1 name FROM " + HandSetOfferType.Para.TableName() + " WHERE id=offer_type_id)";

            if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.offer_type_id).IsView)
                _oColumnSort.Add(this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.offer_type_id).ReportColumnIndex, _sOffer_type_id);

            if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.con_per).IsView)
                _oColumnSort.Add(this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.con_per).ReportColumnIndex, HandSetOfferedBasket.Para.con_per);
            if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.hs_model).IsView)
                _oColumnSort.Add(this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.hs_model).ReportColumnIndex, HandSetOfferedBasket.Para.hs_model);
            if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.premium).IsView)
                _oColumnSort.Add(this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.premium).ReportColumnIndex, HandSetOfferedBasket.Para.premium);
            if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.r_offer).IsView)
                _oColumnSort.Add(this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.r_offer).ReportColumnIndex, HandSetOfferedBasket.Para.r_offer);
            if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.rebate_amount).IsView)
                _oColumnSort.Add(this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.rebate_amount).ReportColumnIndex, HandSetOfferedBasket.Para.rebate_amount);
            if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.amount).IsView)
                _oColumnSort.Add(this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.amount).ReportColumnIndex, HandSetOfferedBasket.Para.amount);
            if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.extra_rebate).IsView)
                _oColumnSort.Add(this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.extra_rebate).ReportColumnIndex, HandSetOfferedBasket.Para.extra_rebate);
            if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.extra_rebate_amount).IsView)
                _oColumnSort.Add(this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.extra_rebate_amount).ReportColumnIndex, HandSetOfferedBasket.Para.extra_rebate_amount);
            if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.payment).IsView)
                _oColumnSort.Add(this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.payment).ReportColumnIndex, HandSetOfferedBasket.Para.payment);
            if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.sdate).IsView)
                _oColumnSort.Add(this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.sdate).ReportColumnIndex, HandSetOfferedBasket.Para.sdate);
            if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.edate).IsView)
                _oColumnSort.Add(this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.edate).ReportColumnIndex, HandSetOfferedBasket.Para.edate);
            if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.active).IsView)
                _oColumnSort.Add(this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.active).ReportColumnIndex, HandSetOfferedBasket.Para.active);
            if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.cid).IsView)
                _oColumnSort.Add(this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.cid).ReportColumnIndex, HandSetOfferedBasket.Para.cid);
            if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.cdate).IsView)
                _oColumnSort.Add(this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.cdate).ReportColumnIndex, HandSetOfferedBasket.Para.cdate);
            if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.did).IsView)
                _oColumnSort.Add(this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.did).ReportColumnIndex, HandSetOfferedBasket.Para.did);
            if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.ddate).IsView)
                _oColumnSort.Add(this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.ddate).ReportColumnIndex, HandSetOfferedBasket.Para.ddate);
            if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.item_code).IsView)
                _oColumnSort.Add(this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.item_code).ReportColumnIndex, HandSetOfferedBasket.Para.item_code);
            /*
            if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.issue_type).IsView)
                _oColumnSort.Add(this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.issue_type).ReportColumnIndex, HandSetOfferedBasket.Para.issue_type);
            */

            

            StringBuilder _oFilter = new StringBuilder();
            _oFilter.Append(" ( ");
            _oFilter.Append(" (normal_rebate_type!='' AND normal_rebate_type IS NOT NULL) OR ");
            _oFilter.Append(" (con_per!='' AND con_per IS NOT NULL) OR");
            _oFilter.Append(" (hs_model!='' AND hs_model IS NOT NULL) OR");
            _oFilter.Append(" (plan_fee!='' AND plan_fee IS NOT NULL) OR ");
            _oFilter.Append(" (rebate_gp!='' AND rebate_gp IS NOT NULL) OR ");
            _oFilter.Append(" (hs_model!='' AND hs_model IS NOT NULL) OR ");
            _oFilter.Append(" (premium!='' AND premium IS NOT NULL) OR ");
            _oFilter.Append(" (r_offer!='' AND r_offer IS NOT NULL) OR ");
            _oFilter.Append(" (rebate_amount!='' AND rebate_amount IS NOT NULL) OR ");
            _oFilter.Append(" (amount!='' AND amount IS NOT NULL)  ");
            _oFilter.Append(" ) AND ");
            _oFilter.Append("active=1");

            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append(" SELECT  ");
            StringBuilder _oColumns = new StringBuilder();

            foreach (KeyValuePair<int, string> _oItem in _oColumnSort)
            {
                if (_oColumns.ToString() != string.Empty) _oColumns.Append(",");
                _oColumns.Append(_oItem.Value.ToString());
            }

            _oQuery.Append(_oColumns.ToString());
            _oQuery.Append(" FROM ");
            _oQuery.Append(" " + HandSetOfferedBasket.Para.TableName() + " WHERE " + _oFilter.ToString() + " ORDER BY mid");

            return SYSConn<MSSQLConnect>.Connect().GetDS(_oQuery.ToString());
        }

        #region GetDataSet
        protected DataSet GetDataSet()
        {
            if (this.Ds == null) return null;
            if (this.Dt == null) return null;
            if (this.Page == null) return null;
            if (this.ReportHtmlTable == null) return null;
            if (this.HandSetOfferedBasketInfo == null) return null;
            if (string.IsNullOrEmpty(this.FileName)) return null;
            if (string.IsNullOrEmpty(this.ContentType)) return null;

            IList<HandSetOfferedBasketEntity> _oHandSetOfferedBasketList = HandSetOfferedBasketDalDAO.FindAll(this.StartRecordIndex, this.LimitRecordIndex, HandSetOfferedBasket.Para.mid, "active=1");
            for (int i = 0; i < _oHandSetOfferedBasketList.Count; i++)
            {
                if (_oHandSetOfferedBasketList[i].active == true)
                {
                    DataRow _oRw = this.Dt.NewRow();
                    if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.mid).IsView)
                    {
                        if (_oHandSetOfferedBasketList[i].mid != null)
                            _oRw[HandSetOfferedBasket.Para.mid] = _oHandSetOfferedBasketList[i].mid;
                        else
                            _oRw[HandSetOfferedBasket.Para.mid] = DBNull.Value;
                    }
                    if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.r_offer).IsView)
                    {
                        if (!string.IsNullOrEmpty(_oHandSetOfferedBasketList[i].r_offer))
                            _oRw[HandSetOfferedBasket.Para.r_offer] = _oHandSetOfferedBasketList[i].r_offer;
                        else
                            _oRw[HandSetOfferedBasket.Para.r_offer] = string.Empty;
                    }
                    if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.extra_rebate_amount).IsView)
                    {
                        if (!string.IsNullOrEmpty(_oHandSetOfferedBasketList[i].extra_rebate_amount))
                            _oRw[HandSetOfferedBasket.Para.extra_rebate_amount] = _oHandSetOfferedBasketList[i].extra_rebate_amount;
                        else
                            _oRw[HandSetOfferedBasket.Para.extra_rebate_amount] = string.Empty;
                    }
                    if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.cdate).IsView)
                    {
                        if (_oHandSetOfferedBasketList[i].cdate != null)
                            _oRw[HandSetOfferedBasket.Para.cdate] = _oHandSetOfferedBasketList[i].cdate;
                        else
                            _oRw[HandSetOfferedBasket.Para.cdate] = DBNull.Value;
                    }
                    if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.amount).IsView)
                    {
                        if (!string.IsNullOrEmpty(_oHandSetOfferedBasketList[i].amount))
                            _oRw[HandSetOfferedBasket.Para.amount] = _oHandSetOfferedBasketList[i].amount;
                        else
                            _oRw[HandSetOfferedBasket.Para.amount] = DBNull.Value;
                    }
                    if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.cid).IsView)
                    {
                        if (!string.IsNullOrEmpty(_oHandSetOfferedBasketList[i].cid))
                            _oRw[HandSetOfferedBasket.Para.cid] = _oHandSetOfferedBasketList[i].cid;
                        else
                            _oRw[HandSetOfferedBasket.Para.cid] = DBNull.Value;
                    }
                    if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.did).IsView)
                    {
                        if (!string.IsNullOrEmpty(_oHandSetOfferedBasketList[i].did))
                            _oRw[HandSetOfferedBasket.Para.did] = _oHandSetOfferedBasketList[i].did;
                        else
                            _oRw[HandSetOfferedBasket.Para.did] = DBNull.Value;
                    }
                    if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.edate).IsView)
                    {
                        if (_oHandSetOfferedBasketList[i].edate != null)
                            _oRw[HandSetOfferedBasket.Para.edate] = _oHandSetOfferedBasketList[i].edate;
                        else
                            _oRw[HandSetOfferedBasket.Para.edate] = DBNull.Value;
                    }
                    if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.payment).IsView)
                    {
                        if (!string.IsNullOrEmpty(_oHandSetOfferedBasketList[i].payment))
                            _oRw[HandSetOfferedBasket.Para.payment] = _oHandSetOfferedBasketList[i].payment;
                        else
                            _oRw[HandSetOfferedBasket.Para.payment] = DBNull.Value;
                    }
                    if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.normal_rebate_type).IsView)
                    {
                        if (!string.IsNullOrEmpty(_oHandSetOfferedBasketList[i].normal_rebate_type))
                            _oRw[HandSetOfferedBasket.Para.normal_rebate_type] = _oHandSetOfferedBasketList[i].normal_rebate_type;
                        else
                            _oRw[HandSetOfferedBasket.Para.normal_rebate_type] = DBNull.Value;
                    }
                    if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.con_per).IsView)
                    {
                        if (!string.IsNullOrEmpty(_oHandSetOfferedBasketList[i].con_per))
                            _oRw[HandSetOfferedBasket.Para.con_per] = _oHandSetOfferedBasketList[i].con_per;
                        else
                            _oRw[HandSetOfferedBasket.Para.con_per] = string.Empty;
                    }
                    if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.ddate).IsView)
                    {
                        if (_oHandSetOfferedBasketList[i].ddate != null)
                            _oRw[HandSetOfferedBasket.Para.ddate] = _oHandSetOfferedBasketList[i].ddate;
                        else
                            _oRw[HandSetOfferedBasket.Para.ddate] = DBNull.Value;
                    }
                    if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.premium).IsView)
                    {
                        if (!string.IsNullOrEmpty(_oHandSetOfferedBasketList[i].premium))
                            _oRw[HandSetOfferedBasket.Para.premium] = _oHandSetOfferedBasketList[i].premium;
                        else
                            _oRw[HandSetOfferedBasket.Para.premium] = string.Empty;
                    }
                    if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.extra_rebate).IsView)
                    {
                        if (!string.IsNullOrEmpty(_oHandSetOfferedBasketList[i].extra_rebate))
                            _oRw[HandSetOfferedBasket.Para.extra_rebate] = _oHandSetOfferedBasketList[i].extra_rebate;
                        else
                            _oRw[HandSetOfferedBasket.Para.extra_rebate] = string.Empty;
                    }
                    if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.rebate_gp).IsView)
                    {
                        if (!string.IsNullOrEmpty(_oHandSetOfferedBasketList[i].rebate_gp))
                            _oRw[HandSetOfferedBasket.Para.rebate_gp] = _oHandSetOfferedBasketList[i].rebate_gp;
                        else
                            _oRw[HandSetOfferedBasket.Para.rebate_gp] = string.Empty;
                    }
                    if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.hs_model).IsView)
                    {
                        if (!string.IsNullOrEmpty(_oHandSetOfferedBasketList[i].hs_model))
                            _oRw[HandSetOfferedBasket.Para.hs_model] = _oHandSetOfferedBasketList[i].hs_model;
                        else
                            _oRw[HandSetOfferedBasket.Para.hs_model] = string.Empty;
                    }
                    if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.active).IsView)
                    {
                        if (_oHandSetOfferedBasketList[i].active != null)
                            _oRw[HandSetOfferedBasket.Para.active] = _oHandSetOfferedBasketList[i].active;
                        else
                            _oRw[HandSetOfferedBasket.Para.active] = DBNull.Value;
                    }
                    if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.rebate_amount).IsView)
                    {
                        if (!string.IsNullOrEmpty(_oHandSetOfferedBasketList[i].rebate_amount))
                            _oRw[HandSetOfferedBasket.Para.rebate_amount] = _oHandSetOfferedBasketList[i].rebate_amount;
                        else
                            _oRw[HandSetOfferedBasket.Para.rebate_amount] = DBNull.Value;
                    }
                    if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.plan_fee).IsView)
                    {
                        if (!string.IsNullOrEmpty(_oHandSetOfferedBasketList[i].plan_fee))
                            _oRw[HandSetOfferedBasket.Para.plan_fee] = _oHandSetOfferedBasketList[i].plan_fee;
                        else
                            _oRw[HandSetOfferedBasket.Para.plan_fee] = string.Empty;
                    }
                    if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.item_code).IsView)
                    {
                        if (!string.IsNullOrEmpty(_oHandSetOfferedBasketList[i].item_code))
                            _oRw[HandSetOfferedBasket.Para.item_code] = _oHandSetOfferedBasketList[i].item_code;
                        else
                            _oRw[HandSetOfferedBasket.Para.item_code] = string.Empty;
                    }
                    if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.sdate).IsView)
                    {
                        if (_oHandSetOfferedBasketList[i].sdate != null)
                            _oRw[HandSetOfferedBasket.Para.sdate] = _oHandSetOfferedBasketList[i].sdate;
                        else
                            _oRw[HandSetOfferedBasket.Para.sdate] = DBNull.Value;
                    }
                    if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.offer_type_id).IsView)
                    {
                        if (_oHandSetOfferedBasketList[i].offer_type_id != null)
                        {
                            _oRw[HandSetOfferedBasket.Para.offer_type_id] = GetOfferTypeIdValue(_oHandSetOfferedBasketList[i].offer_type_id);
                        }
                        else
                            _oRw[HandSetOfferedBasket.Para.offer_type_id] = DBNull.Value;
                    }
                    /*
                    if (this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.issue_type).IsView)
                    {
                        if (_oHandSetOfferedBasketList[i].issue_type != null)
                        {
                            _oRw[HandSetOfferedBasket.Para.issue_type] = _oHandSetOfferedBasketList[i].issue_type;
                        }
                        else
                            _oRw[HandSetOfferedBasket.Para.issue_type] = DBNull.Value;
                    }
                    */

                    this.Dt.Rows.Add(_oRw);
                }
            }
            return this.Ds;
        }

        protected string GetOfferTypeIdValue(int? x_iOffer_type_id)
        {
            if (x_iOffer_type_id != null)
            {
                if (OfferSet == null) { OfferSet = GetOfferSetList(); }
                if (OfferSet != null)
                {
                    string _sResult = string.Empty;
                    IDSQuery _oDr = IDSQuery.CreateDsCriteria(OfferSet, null)
                        .Add(DsExpression.Eq(HandSetOfferType.Para.id, x_iOffer_type_id));
                    if (_oDr.Read())
                    {
                        _sResult = _oDr[HandSetOfferType.Para.name] as string;
                    }
                    _oDr.Close();
                    return _sResult.Trim().ToUpper();
                }
            }
            return string.Empty;
        }

        #endregion
        #region TableSetUp
        public bool TableSetUp()
        {
            if (this.HandSetOfferedBasketInfo == null) return false;
            #region Report Column Index Setting
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.mid).ReportColumnIndex = 0;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.plan_fee).ReportColumnIndex = 1;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.rebate_gp).ReportColumnIndex = 2;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.normal_rebate_type).ReportColumnIndex = 3;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.offer_type_id).ReportColumnIndex = 4;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.con_per).ReportColumnIndex = 5;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.hs_model).ReportColumnIndex = 6;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.premium).ReportColumnIndex = 7;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.r_offer).ReportColumnIndex = 8;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.rebate_amount).ReportColumnIndex = 9;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.amount).ReportColumnIndex = 10;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.extra_rebate).ReportColumnIndex = 11;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.extra_rebate_amount).ReportColumnIndex = 12;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.payment).ReportColumnIndex = 13;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.sdate).ReportColumnIndex = 14;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.edate).ReportColumnIndex = 15;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.active).ReportColumnIndex = 16;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.cid).ReportColumnIndex = 17;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.cdate).ReportColumnIndex = 18;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.did).ReportColumnIndex = 19;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.ddate).ReportColumnIndex = 20;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.item_code).ReportColumnIndex = 21;
            //this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.issue_type).ReportColumnIndex = 22;
            #endregion

            #region Report Column Name Setting
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.mid).ReportColumnName = "mid";
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.r_offer).ReportColumnName = "r_offer";
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.extra_rebate_amount).ReportColumnName = "extra_rebate_amount";
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.cdate).ReportColumnName = "cdate";
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.amount).ReportColumnName = "amount";
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.cid).ReportColumnName = "cid";
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.did).ReportColumnName = "did";
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.edate).ReportColumnName = "edate";
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.payment).ReportColumnName = "payment";
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.normal_rebate_type).ReportColumnName = "normal_rebate_type";
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.con_per).ReportColumnName = "con_per";
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.ddate).ReportColumnName = "ddate";
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.premium).ReportColumnName = "premium";
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.extra_rebate).ReportColumnName = "extra_rebate";
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.rebate_gp).ReportColumnName = "rebate_gp";
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.hs_model).ReportColumnName = "hs_model";
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.active).ReportColumnName = "active";
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.rebate_amount).ReportColumnName = "rebate_amount";
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.plan_fee).ReportColumnName = "plan_fee";
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.item_code).ReportColumnName = "item_code";
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.sdate).ReportColumnName = "sdate";
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.offer_type_id).ReportColumnName = "offer_type_id";
            //this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.issue_type).ReportColumnName = "issue_type";
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
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.mid).IsView = x_bView;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.r_offer).IsView = x_bView;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.extra_rebate_amount).IsView = x_bView;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.cdate).IsView = x_bView;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.amount).IsView = x_bView;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.cid).IsView = x_bView;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.did).IsView = x_bView;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.edate).IsView = x_bView;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.payment).IsView = x_bView;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.normal_rebate_type).IsView = x_bView;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.con_per).IsView = x_bView;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.ddate).IsView = x_bView;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.premium).IsView = x_bView;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.extra_rebate).IsView = x_bView;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.rebate_gp).IsView = x_bView;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.normal_rebate).IsView = x_bView;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.hs_model).IsView = x_bView;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.active).IsView = x_bView;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.rebate_amount).IsView = x_bView;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.plan_fee).IsView = x_bView;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.item_code).IsView = x_bView;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.sdate).IsView = x_bView;
            this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.offer_type_id).IsView = x_bView;
            //this.HandSetOfferedBasketInfo.GetTableSet().Fields(HandSetOfferedBasket.Para.issue_type).IsView = x_bView;
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
        protected HandSetOfferedBasketInfo n_oHandSetOfferedBasketInfo = null;
        #region HandSetOfferedBasketInfo
        public HandSetOfferedBasketInfo HandSetOfferedBasketInfo
        {
            get
            {
                return this.n_oHandSetOfferedBasketInfo;
            }
            set
            {
                this.n_oHandSetOfferedBasketInfo = value;
            }
        }
        #endregion HandSetOfferedBasketInfo

        #region Get & Set
        public int GetStartRecordIndex() { return this.StartRecordIndex; }
        public int GetLimitRecordIndex() { return this.LimitRecordIndex; }
        public HtmlTable GetReportHtmlTable() { return this.ReportHtmlTable; }
        public DataSet GetDs() { return this.Ds; }
        public string GetFileName() { return this.FileName; }
        public Page GetPage() { return this.Page; }
        public string GetContentType() { return this.ContentType; }
        public DataTable GetDt() { return this.Dt; }
        public HandSetOfferedBasketInfo GetHandSetOfferedBasketInfo() { return this.HandSetOfferedBasketInfo; }
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
        public bool SetHandSetOfferedBasketInfo(HandSetOfferedBasketInfo value)
        {
            this.HandSetOfferedBasketInfo = value;
            return true;
        }
        #endregion
        #region Equals
        public bool Equals(HandSetOfferedBasketReport x_oObj)
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
            if (!this.HandSetOfferedBasketInfo.Equals(x_oObj.HandSetOfferedBasketInfo)) { return false; }
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
            this.HandSetOfferedBasketInfo = null;
        }
        #endregion Release
        #region Clone
        public HandSetOfferedBasketReport DeepClone()
        {
            HandSetOfferedBasketReport HandSetOfferedBasketReport_Clone = new HandSetOfferedBasketReport(null, null);
            HandSetOfferedBasketReport_Clone.SetStartRecordIndex(this.StartRecordIndex);
            HandSetOfferedBasketReport_Clone.SetLimitRecordIndex(this.LimitRecordIndex);
            HandSetOfferedBasketReport_Clone.SetReportHtmlTable(this.ReportHtmlTable);
            HandSetOfferedBasketReport_Clone.SetDs(this.Ds);
            HandSetOfferedBasketReport_Clone.SetFileName(this.FileName);
            HandSetOfferedBasketReport_Clone.SetPage(this.Page);
            HandSetOfferedBasketReport_Clone.SetContentType(this.ContentType);
            HandSetOfferedBasketReport_Clone.SetDt(this.Dt);
            HandSetOfferedBasketReport_Clone.SetHandSetOfferedBasketInfo(this.HandSetOfferedBasketInfo);
            return HandSetOfferedBasketReport_Clone;
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
