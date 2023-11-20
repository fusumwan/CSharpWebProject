using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.Xml;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using NEURON.WEB.UI.HTMLCONTROL.HTMLSELECT;
using NEURON.WEB.UI.HTMLCONTROL.HTMLTABLE;
using NEURON.WEB.UI.HTMLCONTROL.HTMLTABLECELL;
using NEURON.WEB.UI.HTMLCONTROL;
using log4net;
using System.Linq;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-10-23>
///-- Description:	<Description,Class :VasCreateHolderControl, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class VasCreateHolderControl : IDisposable
    {
        protected bool IsLock = false;
        protected DateTime? StartLockTime = DateTime.Now;
        protected DateTime? EndLockTime = DateTime.Now.AddMinutes(5);
        private string DSQuery = "SELECT DISTINCT vas_field,vas_name,vas_chi_name,multi,active FROM " + Configurator.MSSQLTablePrefix + "BusinessVas";
        private string MobileOrderVasRightJoinBusinessVasQuery = "SELECT a.vas_value vas_value, a.fee fee, b.vas_field vas_field, a.order_id order_id FROM " + Configurator.MSSQLTablePrefix + "MobileOrderVas a RIGHT JOIN " + Configurator.MSSQLTablePrefix + "BusinessVas b ON a.vas_id=b.id WHERE a.active=1 ";

        BusinessVasDescriptionRepositoryBase _oBusinessVasDescriptionRepositoryBase = BusinessVasDescriptionRepositoryBase.Instance();
        ProfileTeamDetailRepositoryBase _oProfileTeamDetailRepositoryBase = ProfileTeamDetailRepositoryBase.Instance();
        MobileRetentionOrderRepositoryBase n_oMobileRetentionOrderRepositoryBase = MobileRetentionOrderRepositoryBase.Instance();
        Hashtable n_oVim_vas_desc = new Hashtable();
        Hashtable n_oMcam_vas_desc = new Hashtable();
        Hashtable n_oNet_vas_desc = new Hashtable();
        Hashtable n_oNow_hd_vas_desc = new Hashtable();
        Hashtable n_oGprs_vas_desc = new Hashtable();
        Hashtable n_oSms_vas_desc = new Hashtable();
        Hashtable n_oVm_vas_desc = new Hashtable();
        #region ReBuildVasControl
        public string ReBuildHtmlVasControl(bool x_bModifyPage, int x_iDeli_flag, int x_iCon_flag)
        {
            StringBuilder _oHtmlVas = new StringBuilder();
            if (this.DB == null)
                this.DB = SYSConn<MSSQLConnect>.Connect();

            if (this.Ds == null)
                this.Ds = this.DB.GetDS(this.DSQuery);

            if (this.GetDs() == null) { return string.Empty; }
            List<string> _oListID = new List<string>();

            IDSQuery _oReader1 = IDSQuery.CreateDsCriteria(this.Ds, BusinessVas.Para.TableName())
                .Add(DsExpression.Eq(BusinessVas.Para.active, 1));

            while (_oReader1.Read())
            {
                if (!_oListID.Contains(_oReader1[BusinessVas.Para.vas_field].ToString().Trim()))
                {
                    NHtmlTableCell _oTr = new NHtmlTableCell("tr");
                    NHtmlTableCell _oTd1 = new NHtmlTableCell("td");
                    NHtmlTableCell _oTd2 = new NHtmlTableCell("td");
                    NHtmlTableCell _oSpan1 = new NHtmlTableCell("span");
                    NHtmlTableCell _oSpan2 = new NHtmlTableCell("span");
                    _oListID.Add(_oReader1[BusinessVas.Para.vas_field].ToString().Trim());
                    _oTr.Id = _oReader1[BusinessVas.Para.vas_field].ToString().Trim() + "2";
                    _oTr.AssignStyle(HtmlTextWriterStyle.Display.ToString(), "none");

                    _oTd1.Height = this.Td1_height;
                    _oTd1.CssClass = this.Td1_class;
                    _oTd1.Width = this.Td1_width;
                    _oSpan1.Id = "span1";
                    _oSpan1.CssClass = this.Span1_class;
                    _oSpan1.AssignStyle(HtmlTextWriterStyle.FontSize.ToString(), this.Span1_FontSize);
                    _oSpan1.InnerText = _oReader1[BusinessVas.Para.vas_name].ToString().Trim() + " " + Func.LatinToBig5(_oReader1[BusinessVas.Para.vas_chi_name].ToString().Trim());
                    _oTd1.ControlsAdd(_oSpan1);

                    _oTd2.Height = this.Td2_height;
                    _oTd2.CssClass = this.Td2_class;
                    _oTd2.ColSpan = this.Td2_colspan;
                    _oSpan2.Id = "span2";
                    _oSpan2.CssClass = this.Span2_class;
                    _oSpan2.AssignStyle(HtmlTextWriterStyle.FontSize.ToString(), this.Span2_FontSize);

                    NHtmlSelect _oDrp1 = new NHtmlSelect(_oReader1[BusinessVas.Para.vas_field].ToString().Trim());
                    _oDrp1.Id = _oReader1[BusinessVas.Para.vas_field].ToString().Trim();
                    _oDrp1.Name = _oReader1[BusinessVas.Para.vas_field].ToString().Trim();
                    _oDrp1.Disabled = true;

                    _oDrp1.Events.OnChange = "Vas1Change();";
                    _oDrp1.AssignStyle(HtmlTextWriterStyle.FontSize.ToString(), this.Drp1_FontSize);
                    _oDrp1.Items.Add(new NHtmlSelectOptions(string.Empty, string.Empty, false));

                    if (this.Ds2 == null)
                        this.Ds2 = this.DB.GetDataSet(BusinessVas.Para.TableName(), "vas_value,vas_field", "active=1", null, "vas_value", BusinessVas.Para.TableName());

                    IDSQuery _oReader2 = IDSQuery.CreateDsCriteria(this.Ds2, BusinessVas.Para.TableName())
                        .Add(DsExpression.Eq(BusinessVas.Para.vas_field, _oReader1[BusinessVas.Para.vas_field].ToString().Trim()));

                    if (_oReader2 != null)
                    {
                        while (_oReader2.Read())
                        {
                            NHtmlSelectOptions _oListItem = new NHtmlSelectOptions(_oReader2[BusinessVas.Para.vas_value].ToString().ToUpper().Trim(), _oReader2[BusinessVas.Para.vas_value].ToString().ToUpper().Trim(), false);
                            if ("NO".Equals(_oReader2[BusinessVas.Para.vas_value].ToString())) _oListItem.Selected = true;
                            _oDrp1.Items.Add(_oListItem);
                        }
                        _oReader2.Close();
                    }

                    if (x_bModifyPage)
                    {
                        if (_oDrp1.SelectedValue == string.Empty) _oDrp1.Disabled = true;
                        if (x_iCon_flag == 0)
                        {
                            _oDrp1.Disabled = true;
                        }
                    }
                    _oSpan2.ControlsAdd(_oDrp1);

                    if (!Convert.IsDBNull(_oReader1[BusinessVas.Para.multi]) && _oReader1[BusinessVas.Para.multi].ToString().ToUpper() == "TRUE")
                    {
                        NHtmlSelect _oDrp2 = new NHtmlSelect(_oReader1[BusinessVas.Para.vas_field].ToString().Trim() + "1");
                        _oDrp2.AssignStyle(HtmlTextWriterStyle.FontSize.ToString(), this.Drp2_FontSize);
                        _oDrp2.Disabled = true;
                        _oDrp2.Id = _oReader1[BusinessVas.Para.vas_field].ToString().Trim() + "1";
                        _oDrp2.Name = _oReader1[BusinessVas.Para.vas_field].ToString().Trim() + "1";
                        _oDrp2.Items.Add(new NHtmlSelectOptions(string.Empty, string.Empty,false));
                        _oDrp2.Events.OnChange = "Vas2Change();";
                        if (this.Ds3 == null)
                            this.Ds3 = this.DB.GetDataSet(BusinessVasDescription.Para.TableName(), "vas_desc,fee,vas", "active=1", null, null, BusinessVasDescription.Para.TableName());

                        IDSQuery _oReader3 = IDSQuery.CreateDsCriteria(this.Ds3, BusinessVasDescription.Para.TableName())
                            .Add(DsExpression.Eq(BusinessVasDescription.Para.vas, _oReader1[BusinessVas.Para.vas_field].ToString().Trim()));

                        if (_oReader3 != null)
                        {
                            while (_oReader3.Read()) { _oDrp2.Items.Add(new NHtmlSelectOptions(_oReader3[BusinessVasDescription.Para.vas_desc].ToString().ToUpper().Trim(), _oReader3[BusinessVasDescription.Para.fee].ToString().Trim(),false)); }
                            _oReader3.Close();
                        }

                        if (x_bModifyPage){
                            if (x_iCon_flag == 0){
                                _oDrp2.Disabled = true;
                            }
                        }
                        _oSpan2.ControlsAdd(_oDrp2);
                    }
                    _oTd2.ControlsAdd(_oSpan2);
                    _oTd1.Id = "td1";
                    _oTd2.Id = "td2";
                    _oTr.ControlsAdd(_oTd1);
                    _oTr.ControlsAdd(_oTd2);
                    _oHtmlVas.Append(_oTr.ToInnerHtml());
                }
            }
            _oReader1.Close();
            return _oHtmlVas.ToString();
        }

        #endregion

        #region Report Table Tr Show
        public StringBuilder ReportTableTrShow(int x_iOrder_id)
        {
            return ReportTableTrShow2(x_iOrder_id, true);
        }

        public StringBuilder ReportTableTrShow2(int x_iOrder_id, bool x_bAllActive)
        {
            StringBuilder _oPlace = new StringBuilder();
            List<string> _oListID = new List<string>();
            if (this.GetDs() == null) return _oPlace;
            if (this.GetMobileOrderVasRightJoinBusinessVas() == null) return _oPlace;
            IDSQuery _oDr = IDSQuery.CreateDsCriteria(this.Ds, string.Empty);
            if (x_bAllActive)
            {
                _oDr = IDSQuery.CreateDsCriteria(this.Ds, string.Empty)
                    .Add(DsExpression.Eq(BusinessVas.Para.active, 1));
            }
            else
                _oDr = IDSQuery.CreateDsCriteria(this.Ds, string.Empty);

            while (_oDr.Read())
            {
                if (!_oListID.Contains(_oDr[BusinessVas.Para.vas_field].ToString().Trim()))
                {
                    _oListID.Add(_oDr[BusinessVas.Para.vas_field].ToString().Trim());
                    string _sVas_field = _oDr["vas_field"].ToString();
                    SqlDataReader _oDr2 = SYSConn<MSSQLConnect>.Connect().GetSearch(this.MobileOrderVasRightJoinBusinessVasQuery + " AND order_id='" + x_iOrder_id + "' AND vas_field='" + _sVas_field + "'");
                    

                    if (_oDr2.Read())
                    {
                        if (_sVas_field == "license_waiver")
                        {
                            string _sFree = (_sVas_field.Length > 1) ? _sVas_field.Substring(0, 1) : string.Empty;
                            _oPlace.Append("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr2["vas_value"]) + "</td>");
                        }
                        else if (bSpecialVas(_sVas_field))
                        {
                            string _sFee = ShowSpecialVas(_oDr2["fee"].ToString().Trim(), _sVas_field);

                            IDSQuery _oVasDescDr = IDSQuery.CreateDsCriteria(this.GetDs3(), BusinessVasDescription.Para.TableName())
                                .Add(DsExpression.Eq("fee", _sFee));
                            string _sVasDescShow = string.Empty;
                            if (_oVasDescDr.Read())
                                _sVasDescShow = _oVasDescDr["vas_desc"].ToString();
                            _oVasDescDr.Close();
                            _oPlace.Append("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + _sVasDescShow + "</td>");
                        }
                        else
                        {

                            string _sFee = Func.FR(_oDr2["fee"]).ToString().Trim();
                            IDSQuery _oVasDescDr = IDSQuery.CreateDsCriteria(this.GetDs3(), BusinessVasDescription.Para.TableName())
                                .Add(DsExpression.Eq("fee", _sFee));
                            string _sVasDescShow = string.Empty;
                            if (_oVasDescDr.Read())
                                _sVasDescShow = _oVasDescDr["vas_desc"].ToString();
                            _oVasDescDr.Close();

                            _sVasDescShow = (_sVasDescShow != string.Empty) ? "," + _sVasDescShow : string.Empty;
                            _oPlace.Append("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr2["vas_value"]) + _sVasDescShow + "</td>");
                        }
                    }
                    else
                    {
                        _oPlace.Append("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\"></span></td>");
                    }
                    _oDr2.Close();
                    _oDr2.Dispose();
                }
            }
            _oDr.Close();
            return _oPlace;
        }


        public StringBuilder ReportTableTrShow(int x_iOrder_id, bool x_bAllActive)
        {
            StringBuilder _oPlace = new StringBuilder();
            List<string> _oListID = new List<string>();
            if (this.GetDs() == null) return _oPlace;
            if (this.GetMobileOrderVasRightJoinBusinessVas() == null) return _oPlace;
            IDSQuery _oDr = IDSQuery.CreateDsCriteria(this.Ds, string.Empty);
            if (x_bAllActive)
            {
                _oDr=IDSQuery.CreateDsCriteria(this.Ds, string.Empty)
                    .Add(DsExpression.Eq(BusinessVas.Para.active,1));
            }
            else
                _oDr = IDSQuery.CreateDsCriteria(this.Ds, string.Empty);

            while (_oDr.Read())
            {
                if (!_oListID.Contains(_oDr[BusinessVas.Para.vas_field].ToString().Trim()))
                {
                    _oListID.Add(_oDr[BusinessVas.Para.vas_field].ToString().Trim());
                    string _sVas_field = _oDr[BusinessVas.Para.vas_field].ToString();

                    IDSQuery _oDr2 = IDSQuery.CreateDsCriteria(this.MobileOrderVasRightJoinBusinessVas, string.Empty)
                        .Add(DsExpression.Eq(MobileOrderVas.Para.order_id, x_iOrder_id))
                        .Add(DsExpression.Eq(MobileOrderVas.Para.vas_field, _sVas_field));

                    if (_oDr2.Read())
                    {
                        if (_sVas_field == "license_waiver")
                        {
                            string _sFree = (_sVas_field.Length > 1) ? _sVas_field.Substring(0, 1) : string.Empty;
                            _oPlace.Append("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr2["vas_value"]) + "</td>");
                        }
                        else if (bSpecialVas(_sVas_field))
                        {
                            string _sFee = ShowSpecialVas(_oDr2[BusinessVasDescription.Para.fee].ToString().Trim(), _sVas_field);

                            IDSQuery _oVasDescDr = IDSQuery.CreateDsCriteria(this.GetDs3(), BusinessVasDescription.Para.TableName())
                                .Add(DsExpression.Eq(BusinessVasDescription.Para.fee, _sFee));
                            string _sVasDescShow = string.Empty;
                            if (_oVasDescDr.Read())
                                _sVasDescShow = _oVasDescDr[BusinessVasDescription.Para.vas_desc].ToString();
                            _oVasDescDr.Close();
                            _oPlace.Append("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + _sVasDescShow + "</td>");
                        }
                        else
                        {

                            string _sFee = _oDr2["fee"].ToString().Trim();
                            IDSQuery _oVasDescDr = IDSQuery.CreateDsCriteria(this.GetDs3(), BusinessVasDescription.Para.TableName())
                                .Add(DsExpression.Eq("fee", _sFee));
                            string _sVasDescShow = string.Empty;
                            if (_oVasDescDr.Read())
                                _sVasDescShow = _oVasDescDr["vas_desc"].ToString();
                            _oVasDescDr.Close();

                            _sVasDescShow = (_sVasDescShow != string.Empty) ? "," + _sVasDescShow : string.Empty;
                            _oPlace.Append("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr2["vas_value"]) + _sVasDescShow + "</td>");
                        }
                    }
                    else
                    {
                        _oPlace.Append("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\"></span></td>");
                    }
                    _oDr2.Close();
                }
            }
            _oDr.Close();
            return _oPlace;
        }
        #endregion

        public bool bSpecialVas(string x_sVasField)
        {

            if (x_sVasField == "gprs_vas" ||
                x_sVasField == "vmin_vas" ||
                x_sVasField == "mcam_vas" ||
                x_sVasField == "net_vas" ||
                x_sVasField == "now_hd_vas" ||
                x_sVasField == "gprs_vas" ||
                x_sVasField == "sms_vas" ||
                x_sVasField == "vm_vas")
            {
                return true;
            }

            return false;
        }

        public string ShowSpecialVas(string x_sFee, string x_sVasField)
        {

            string _sResult = x_sFee;
            if (!"".Equals(x_sFee))
            {
                if (x_sFee.IndexOf(",") > -1)
                {
                    string[] _oVal = x_sFee.Split((",")[0]);
                    _sResult = _oVal[0];
                    if (_oVal.Length > 1)
                    {
                        if (!"".Equals(_oVal[1]))
                        {

                            switch (x_sFee)
                            {
                                case "net_vas":
                                    if (n_oNet_vas_desc.Contains(_oVal[1]))
                                        _sResult += n_oNet_vas_desc[_oVal[1]].ToString();
                                    break;
                                case "gprs_vas":
                                    if (n_oGprs_vas_desc.Contains(_oVal[1]))
                                        _sResult += n_oGprs_vas_desc[_oVal[1]].ToString();
                                    break;
                                case "vmin_vas":
                                    if (n_oVim_vas_desc.Contains(_oVal[1]))
                                        _sResult += n_oVim_vas_desc[_oVal[1]].ToString();
                                    break;
                                case "mcam_vas":
                                    if (n_oMcam_vas_desc.Contains(_oVal[1]))
                                        _sResult += n_oMcam_vas_desc[_oVal[1]].ToString();
                                    break;
                                case "now_hd_vas":
                                    if (n_oNow_hd_vas_desc.Contains(_oVal[1]))
                                        _sResult += n_oNow_hd_vas_desc[_oVal[1]].ToString();
                                    break;
                                case "sms_vas":
                                    if (n_oSms_vas_desc.Contains(_oVal[1]))
                                        _sResult += n_oSms_vas_desc[_oVal[1]].ToString();
                                    break;
                                case "vm_vas":
                                    if (n_oVm_vas_desc.Contains(_oVal[1]))
                                        _sResult += n_oVm_vas_desc[_oVal[1]].ToString();
                                    break;
                            }
                        }
                    }
                }
            }
            return _sResult;
        }


        #region PreLoadDataToMemory
        public void PreLoadDataToMemory(bool x_bMustReload)
        {
            if (this.IsLock == false)
            {
                this.IsLock = true;
                this.InitStyle();
                this.DB = SYSConn<MSSQLConnect>.Connect();
                if (this.Ds == null || x_bMustReload)
                    this.Ds = this.DB.GetDS(this.DSQuery);
                if (this.Ds2 == null || x_bMustReload)
                    this.Ds2 = this.DB.GetDataSet(BusinessVas.Para.TableName(), "vas_value,vas_field", "active=1", null, "vas_value", BusinessVas.Para.TableName());
                if (this.Ds3 == null || x_bMustReload)
                    this.Ds3 = this.DB.GetDataSet(BusinessVasDescription.Para.TableName(), "id,vas_desc,fee,vas", "active=1", null, null, BusinessVasDescription.Para.TableName());

                /*
                if (this.MobileOrderVasRightJoinBusinessVas ==null || x_bMustReload)
                    this.MobileOrderVasRightJoinBusinessVas = this.DB.GetDS(this.MobileOrderVasRightJoinBusinessVasQuery);
                */
                if (this.BusinessVasDescriptionList == null || x_bMustReload)
                {
                    try
                    {
                        #region Vas Desc Clear
                        n_oVim_vas_desc.Clear();
                        n_oMcam_vas_desc.Clear();
                        n_oNet_vas_desc.Clear();
                        n_oNow_hd_vas_desc.Clear();
                        n_oGprs_vas_desc.Clear();
                        n_oSms_vas_desc.Clear();
                        n_oVm_vas_desc.Clear();
                        #endregion
                        this.BusinessVasDescriptionList = from sRwlVasDescList in _oBusinessVasDescriptionRepositoryBase.BusinessVasDescriptions
                                                          where (sRwlVasDescList.vas == "vmin_vas") ||
                                                          (sRwlVasDescList.vas == "mcam_vas") ||
                                                          (sRwlVasDescList.vas == "net_vas") ||
                                                          (sRwlVasDescList.vas == "now_hd_vas") ||
                                                          (sRwlVasDescList.vas == "gprs_vas" && sRwlVasDescList.active == true) ||
                                                          (sRwlVasDescList.vas == "sms_vas" && sRwlVasDescList.active == true) ||
                                                          (sRwlVasDescList.vas == "vm_vas")
                                                          orderby sRwlVasDescList.id
                                                          select sRwlVasDescList;
                        if (this.BusinessVasDescriptionList.Count<BusinessVasDescriptionEntity>() > 0)
                        {
                            foreach (BusinessVasDescriptionEntity _oItem in this.BusinessVasDescriptionList)
                            {
                                switch (_oItem.vas)
                                {
                                    case "vmin_vas":
                                        if (!n_oVim_vas_desc.ContainsKey(_oItem.fee))
                                            n_oVim_vas_desc.Add(_oItem.fee, _oItem.vas_desc);
                                        break;
                                    case "mcam_vas":
                                        if (!n_oMcam_vas_desc.ContainsKey(_oItem.fee))
                                            n_oMcam_vas_desc.Add(_oItem.fee, _oItem.vas_desc);
                                        break;
                                    case "net_vas":
                                        if (!n_oNet_vas_desc.ContainsKey(_oItem.fee))
                                            n_oNet_vas_desc.Add(_oItem.fee, _oItem.vas_desc);
                                        break;
                                    case "now_hd_vas":
                                        if (!n_oNow_hd_vas_desc.ContainsKey(_oItem.fee))
                                            n_oNow_hd_vas_desc.Add(_oItem.fee, _oItem.vas_desc);
                                        break;
                                    case "gprs_vas":
                                        if (!n_oGprs_vas_desc.ContainsKey(_oItem.fee))
                                            n_oGprs_vas_desc.Add(_oItem.fee, _oItem.vas_desc);
                                        break;
                                    case "sms_vas":
                                        if (!n_oSms_vas_desc.ContainsKey(_oItem.fee))
                                            n_oSms_vas_desc.Add(_oItem.fee, _oItem.vas_desc);
                                        break;
                                    case "vm_vas":
                                        if (!n_oVm_vas_desc.ContainsKey(_oItem.fee))
                                            n_oVm_vas_desc.Add(_oItem.fee, _oItem.vas_desc);
                                        break;
                                }
                            }
                        }
                    }
                    catch (Exception exp)
                    {

                    }
                }
                this.IsLock = false;
            }
            else
            {
                if (this.StartLockTime == null || this.EndLockTime == null)
                {
                    this.StartLockTime = DateTime.Now;
                    this.EndLockTime = DateTime.Now.AddMinutes(5);
                }
                if (DateTime.Compare(DateTime.Now, (DateTime)this.EndLockTime) > 0)
                {
                    this.IsLock = false;
                    PreLoadDataToMemory(x_bMustReload);
                }
            }
        }
        public void PreLoadDataToMemory()
        {
            PreLoadDataToMemory(false);
        }
        #endregion

        #region InitStyle
        public void InitStyle()
        {
            this.Td1_height = "28";
            this.Td1_width = "28%";
            this.Td1_class = "row2";
            this.Span1_class = "explaintitle";
            this.Span1_FontSize = "12pt";

            this.Td2_height = "28";
            this.Td2_class = "row1";
            this.Td2_colspan = "3";
            this.Span2_class = "gensmall";
            this.Span2_FontSize = "12pt";

            this.Drp1_FontSize = "12pt";
            this.Drp2_FontSize = "12pt";
        }
        #endregion

        protected IQueryable<BusinessVasDescriptionEntity> n_oBusinessVasDescriptionList = null;
        public IQueryable<BusinessVasDescriptionEntity> BusinessVasDescriptionList
        {
            get
            {
                return this.n_oBusinessVasDescriptionList;
            }
            set
            {
                this.n_oBusinessVasDescriptionList = value;
            }
        }

        protected EventHandler n_oDrp2EventHandler = null;
        #region Drp2EventHandler
        public EventHandler Drp2EventHandler
        {
            get
            {
                return this.n_oDrp2EventHandler;
            }
            set
            {
                this.n_oDrp2EventHandler = value;
            }
        }
        #endregion Drp2EventHandler


        protected DataSet n_oDs3 = null;
        #region Ds3
        public DataSet Ds3
        {
            get
            {
                return this.n_oDs3;
            }
            set
            {
                this.n_oDs3 = value;
            }
        }
        #endregion Ds3

        protected DataSet n_oMobileOrderVasRightJoinBusinessVas = null;
        #region MobileOrderVasRightJoinBusinessVas
        public DataSet MobileOrderVasRightJoinBusinessVas
        {
            get
            {
                return this.n_oMobileOrderVasRightJoinBusinessVas;
            }
            set
            {
                this.n_oMobileOrderVasRightJoinBusinessVas = value;
            }
        }
        #endregion


        protected MSSQLConnect n_oDB = null;
        #region DB
        public MSSQLConnect DB
        {
            get
            {
                return this.n_oDB;
            }
            set
            {
                this.n_oDB = value;
            }
        }
        #endregion DB


        protected DataSet n_oDs2 = null;
        #region Ds2
        public DataSet Ds2
        {
            get
            {
                return this.n_oDs2;
            }
            set
            {
                this.n_oDs2 = value;
            }
        }
        #endregion Ds2

        

        protected string n_sSpan2_FontSize = global::System.String.Empty;
        #region Span2_FontSize
        public string Span2_FontSize
        {
            get
            {
                return this.n_sSpan2_FontSize;
            }
            set
            {
                this.n_sSpan2_FontSize = value;
            }
        }
        #endregion Span2_FontSize


        protected string n_sSpan1_FontSize = global::System.String.Empty;
        #region Span1_FontSize
        public string Span1_FontSize
        {
            get
            {
                return this.n_sSpan1_FontSize;
            }
            set
            {
                this.n_sSpan1_FontSize = value;
            }
        }
        #endregion Span1_FontSize


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


        protected string n_sSpan1_class = global::System.String.Empty;
        #region Span1_class
        public string Span1_class
        {
            get
            {
                return this.n_sSpan1_class;
            }
            set
            {
                this.n_sSpan1_class = value;
            }
        }
        #endregion Span1_class


        protected string n_sTd1_height = global::System.String.Empty;
        #region Td1_height
        public string Td1_height
        {
            get
            {
                return this.n_sTd1_height;
            }
            set
            {
                this.n_sTd1_height = value;
            }
        }
        #endregion Td1_height


        protected PlaceHolder n_oGiftVasCreate_Holder = null;
        #region GiftVasCreate_Holder
        public PlaceHolder GiftVasCreate_Holder
        {
            get
            {
                return this.n_oGiftVasCreate_Holder;
            }
            set
            {
                this.n_oGiftVasCreate_Holder = value;
            }
        }
        #endregion GiftVasCreate_Holder


        protected string n_sDrp1_FontSize = global::System.String.Empty;
        #region Drp1_FontSize
        public string Drp1_FontSize
        {
            get
            {
                return this.n_sDrp1_FontSize;
            }
            set
            {
                this.n_sDrp1_FontSize = value;
            }
        }
        #endregion Drp1_FontSize


        protected string n_sTd2_height = global::System.String.Empty;
        #region Td2_height
        public string Td2_height
        {
            get
            {
                return this.n_sTd2_height;
            }
            set
            {
                this.n_sTd2_height = value;
            }
        }
        #endregion Td2_height


        protected Dictionary<string, DropDownList> n_oVasDrp2List = null;
        #region VasDrp2List
        public Dictionary<string, DropDownList> VasDrp2List
        {
            get
            {
                return this.n_oVasDrp2List;
            }
            set
            {
                this.n_oVasDrp2List = value;
            }
        }
        #endregion VasDrp2List


        protected Dictionary<string, DropDownList> n_oVasDrp1List = null;
        #region VasDrp1List
        public Dictionary<string, DropDownList> VasDrp1List
        {
            get
            {
                return this.n_oVasDrp1List;
            }
            set
            {
                this.n_oVasDrp1List = value;
            }
        }
        #endregion VasDrp1List


        protected string n_sTd2_class = global::System.String.Empty;
        #region Td2_class
        public string Td2_class
        {
            get
            {
                return this.n_sTd2_class;
            }
            set
            {
                this.n_sTd2_class = value;
            }
        }
        #endregion Td2_class


        protected string n_sTd2_colspan = global::System.String.Empty;
        #region Td2_colspan
        public string Td2_colspan
        {
            get
            {
                return this.n_sTd2_colspan;
            }
            set
            {
                this.n_sTd2_colspan = value;
            }
        }
        #endregion Td2_colspan


        protected string n_sDrp2_FontSize = global::System.String.Empty;
        #region Drp2_FontSize
        public string Drp2_FontSize
        {
            get
            {
                return this.n_sDrp2_FontSize;
            }
            set
            {
                this.n_sDrp2_FontSize = value;
            }
        }
        #endregion Drp2_FontSize


        protected string n_sTd1_width = global::System.String.Empty;
        #region Td1_width
        public string Td1_width
        {
            get
            {
                return this.n_sTd1_width;
            }
            set
            {
                this.n_sTd1_width = value;
            }
        }
        #endregion Td1_width


        protected string n_sTd1_class = global::System.String.Empty;
        #region Td1_class
        public string Td1_class
        {
            get
            {
                return this.n_sTd1_class;
            }
            set
            {
                this.n_sTd1_class = value;
            }
        }
        #endregion Td1_class


        protected EventHandler n_oDrp1EventHandler = null;
        #region Drp1EventHandler
        public EventHandler Drp1EventHandler
        {
            get
            {
                return this.n_oDrp1EventHandler;
            }
            set
            {
                this.n_oDrp1EventHandler = value;
            }
        }
        #endregion Drp1EventHandler


        protected string n_sSpan2_class = global::System.String.Empty;
        #region Span2_class
        public string Span2_class
        {
            get
            {
                return this.n_sSpan2_class;
            }
            set
            {
                this.n_sSpan2_class = value;
            }
        }
        #endregion Span2_class

        #region Para
        public class Para
        {
            public const string Drp2EventHandler = "Drp2EventHandler";
            public const string Ds3 = "Ds3";
            public const string DB = "DB";
            public const string Ds2 = "Ds2";
            public const string Span2_FontSize = "Span2_FontSize";
            public const string Span1_FontSize = "Span1_FontSize";
            public const string Ds = "Ds";
            public const string Span1_class = "Span1_class";
            public const string Td1_height = "Td1_height";
            public const string GiftVasCreate_Holder = "GiftVasCreate_Holder";
            public const string Drp1_FontSize = "Drp1_FontSize";
            public const string Td2_height = "Td2_height";
            public const string VasDrp2List = "VasDrp2List";
            public const string VasDrp1List = "VasDrp1List";
            public const string Td2_class = "Td2_class";
            public const string Td2_colspan = "Td2_colspan";
            public const string Drp2_FontSize = "Drp2_FontSize";
            public const string Td1_width = "Td1_width";
            public const string Td1_class = "Td1_class";
            public const string Drp1EventHandler = "Drp1EventHandler";
            public const string Span2_class = "Span2_class";
            public const string MobileOrderVasRightJoinBusinessVas = "MobileOrderVasRightJoinBusinessVas";
        }
        #endregion Para

        #region Instance
        private static VasCreateHolderControl instance;
        #endregion


        #region Constructor & Destructor
        protected VasCreateHolderControl() {
            this.InitStyle();
        }

        protected VasCreateHolderControl(EventHandler x_oDrp2EventHandler, DataSet x_oDs3, MSSQLConnect x_oDB, DataSet x_oDs2, string x_sSpan2_FontSize, string x_sSpan1_FontSize, DataSet x_oDs, string x_sSpan1_class, string x_sTd1_height, PlaceHolder x_oGiftVasCreate_Holder, string x_sDrp1_FontSize, string x_sTd2_height, Dictionary<string, DropDownList> x_oVasDrp2List, Dictionary<string, DropDownList> x_oVasDrp1List, string x_sTd2_class, string x_sTd2_colspan, string x_sDrp2_FontSize, string x_sTd1_width, string x_sTd1_class, EventHandler x_oDrp1EventHandler, string x_sSpan2_class, DataSet x_oMobileOrderVasRightJoinBusinessVas)
        {
            this.InitStyle();
            Drp2EventHandler = x_oDrp2EventHandler;
            Ds3 = x_oDs3;
            DB = x_oDB;
            Ds2 = x_oDs2;
            Span2_FontSize = x_sSpan2_FontSize;
            Span1_FontSize = x_sSpan1_FontSize;
            Ds = x_oDs;
            Span1_class = x_sSpan1_class;
            Td1_height = x_sTd1_height;
            GiftVasCreate_Holder = x_oGiftVasCreate_Holder;
            Drp1_FontSize = x_sDrp1_FontSize;
            Td2_height = x_sTd2_height;
            VasDrp2List = x_oVasDrp2List;
            VasDrp1List = x_oVasDrp1List;
            Td2_class = x_sTd2_class;
            Td2_colspan = x_sTd2_colspan;
            Drp2_FontSize = x_sDrp2_FontSize;
            Td1_width = x_sTd1_width;
            Td1_class = x_sTd1_class;
            Drp1EventHandler = x_oDrp1EventHandler;
            Span2_class = x_sSpan2_class;
            MobileOrderVasRightJoinBusinessVas = x_oMobileOrderVasRightJoinBusinessVas;
        }

        public static VasCreateHolderControl Instance()
        {
            if (instance == null)
                instance = new VasCreateHolderControl();
            return instance;
        }

        public static VasCreateHolderControl Instance(EventHandler x_oDrp2EventHandler, DataSet x_oDs3, MSSQLConnect x_oDB, DataSet x_oDs2, string x_sSpan2_FontSize, string x_sSpan1_FontSize, DataSet x_oDs, string x_sSpan1_class, string x_sTd1_height, PlaceHolder x_oGiftVasCreate_Holder, string x_sDrp1_FontSize, string x_sTd2_height, Dictionary<string, DropDownList> x_oVasDrp2List, Dictionary<string, DropDownList> x_oVasDrp1List, string x_sTd2_class, string x_sTd2_colspan, string x_sDrp2_FontSize, string x_sTd1_width, string x_sTd1_class, EventHandler x_oDrp1EventHandler, string x_sSpan2_class, DataSet x_oMobileOrderVasRightJoinBusinessVas)
        {
            if (instance == null)
                instance = new VasCreateHolderControl(x_oDrp2EventHandler, x_oDs3, x_oDB, x_oDs2, x_sSpan2_FontSize, x_sSpan1_FontSize, x_oDs, x_sSpan1_class, x_sTd1_height, x_oGiftVasCreate_Holder, x_sDrp1_FontSize, x_sTd2_height, x_oVasDrp2List, x_oVasDrp1List, x_sTd2_class, x_sTd2_colspan, x_sDrp2_FontSize, x_sTd1_width, x_sTd1_class, x_oDrp1EventHandler, x_sSpan2_class, x_oMobileOrderVasRightJoinBusinessVas);
            return instance;
        }

        ~VasCreateHolderControl() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public IQueryable<BusinessVasDescriptionEntity> GetBusinessVasDescriptionList() { return this.BusinessVasDescriptionList;}
        public EventHandler GetDrp2EventHandler() { return this.Drp2EventHandler; }
        public DataSet GetDs3() {
            if (this.Ds3 == null)
                this.Ds3 = this.DB.GetDataSet(BusinessVasDescription.Para.TableName(), "id,vas_desc,fee,vas", "active=1", null, null, BusinessVasDescription.Para.TableName());
            return this.Ds3; 
        }
        public MSSQLConnect GetDB() {
            if (this.DB == null)
                this.DB = SYSConn<MSSQLConnect>.Connect();
            return this.DB; 
        }
        public DataSet GetDs2() { return this.Ds2; }
        public string GetSpan2_FontSize() { return this.Span2_FontSize; }
        public string GetSpan1_FontSize() { return this.Span1_FontSize; }
        public DataSet GetDs() {
            if (this.Ds == null)
                this.Ds = this.GetDB().GetDS(this.DSQuery);
            return this.Ds; 
        }
        public string GetSpan1_class() { return this.Span1_class; }
        public string GetTd1_height() { return this.Td1_height; }
        public PlaceHolder GetGiftVasCreate_Holder() { return this.GiftVasCreate_Holder; }
        public string GetDrp1_FontSize() { return this.Drp1_FontSize; }
        public string GetTd2_height() { return this.Td2_height; }
        public Dictionary<string, DropDownList> GetVasDrp2List() { return this.VasDrp2List; }
        public Dictionary<string, DropDownList> GetVasDrp1List() { return this.VasDrp1List; }
        public string GetTd2_class() { return this.Td2_class; }
        public string GetTd2_colspan() { return this.Td2_colspan; }
        public string GetDrp2_FontSize() { return this.Drp2_FontSize; }
        public string GetTd1_width() { return this.Td1_width; }
        public string GetTd1_class() { return this.Td1_class; }
        public EventHandler GetDrp1EventHandler() { return this.Drp1EventHandler; }
        public string GetSpan2_class() { return this.Span2_class; }
        public DataSet GetMobileOrderVasRightJoinBusinessVas()
        {
            if(this.MobileOrderVasRightJoinBusinessVas==null)
                this.MobileOrderVasRightJoinBusinessVas = this.GetDB().GetDS(this.MobileOrderVasRightJoinBusinessVasQuery);
            return this.MobileOrderVasRightJoinBusinessVas;
        }

        public bool SetBusinessVasDescriptionList(IQueryable<BusinessVasDescriptionEntity> value)
        {
            this.BusinessVasDescriptionList = value;
            return true;
        }

        public bool SetMobileOrderVasRightJoinBusinessVas(DataSet value)
        {
            this.MobileOrderVasRightJoinBusinessVas = value;
            return true;
        }
        public bool SetDrp2EventHandler(EventHandler value)
        {
            this.Drp2EventHandler = value;
            return true;
        }
        public bool SetDs3(DataSet value)
        {
            this.Ds3 = value;
            return true;
        }
        public bool SetDB(MSSQLConnect value)
        {
            this.DB = value;
            return true;
        }
        public bool SetDs2(DataSet value)
        {
            this.Ds2 = value;
            return true;
        }
        public bool SetSpan2_FontSize(string value)
        {
            this.Span2_FontSize = value;
            return true;
        }
        public bool SetSpan1_FontSize(string value)
        {
            this.Span1_FontSize = value;
            return true;
        }
        public bool SetDs(DataSet value)
        {
            this.Ds = value;
            return true;
        }
        public bool SetSpan1_class(string value)
        {
            this.Span1_class = value;
            return true;
        }
        public bool SetTd1_height(string value)
        {
            this.Td1_height = value;
            return true;
        }
        public bool SetGiftVasCreate_Holder(PlaceHolder value)
        {
            this.GiftVasCreate_Holder = value;
            return true;
        }
        public bool SetDrp1_FontSize(string value)
        {
            this.Drp1_FontSize = value;
            return true;
        }
        public bool SetTd2_height(string value)
        {
            this.Td2_height = value;
            return true;
        }
        public bool SetVasDrp2List(Dictionary<string, DropDownList> value)
        {
            this.VasDrp2List = value;
            return true;
        }
        public bool SetVasDrp1List(Dictionary<string, DropDownList> value)
        {
            this.VasDrp1List = value;
            return true;
        }
        public bool SetTd2_class(string value)
        {
            this.Td2_class = value;
            return true;
        }
        public bool SetTd2_colspan(string value)
        {
            this.Td2_colspan = value;
            return true;
        }
        public bool SetDrp2_FontSize(string value)
        {
            this.Drp2_FontSize = value;
            return true;
        }
        public bool SetTd1_width(string value)
        {
            this.Td1_width = value;
            return true;
        }
        public bool SetTd1_class(string value)
        {
            this.Td1_class = value;
            return true;
        }
        public bool SetDrp1EventHandler(EventHandler value)
        {
            this.Drp1EventHandler = value;
            return true;
        }
        public bool SetSpan2_class(string value)
        {
            this.Span2_class = value;
            return true;
        }
        #endregion


        #region Equals
        public bool Equals(VasCreateHolderControl x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.BusinessVasDescriptionList.Equals(x_oObj.BusinessVasDescriptionList)) { return false; }
            if (!this.Drp2EventHandler.Equals(x_oObj.Drp2EventHandler)) { return false; }
            if (!this.Ds3.Equals(x_oObj.Ds3)) { return false; }
            if (!this.DB.Equals(x_oObj.DB)) { return false; }
            if (!this.Ds2.Equals(x_oObj.Ds2)) { return false; }
            if (!this.Span2_FontSize.Equals(x_oObj.Span2_FontSize)) { return false; }
            if (!this.Span1_FontSize.Equals(x_oObj.Span1_FontSize)) { return false; }
            if (!this.Ds.Equals(x_oObj.Ds)) { return false; }
            if (!this.Span1_class.Equals(x_oObj.Span1_class)) { return false; }
            if (!this.Td1_height.Equals(x_oObj.Td1_height)) { return false; }
            if (!this.GiftVasCreate_Holder.Equals(x_oObj.GiftVasCreate_Holder)) { return false; }
            if (!this.Drp1_FontSize.Equals(x_oObj.Drp1_FontSize)) { return false; }
            if (!this.Td2_height.Equals(x_oObj.Td2_height)) { return false; }
            if (!this.VasDrp2List.Equals(x_oObj.VasDrp2List)) { return false; }
            if (!this.VasDrp1List.Equals(x_oObj.VasDrp1List)) { return false; }
            if (!this.Td2_class.Equals(x_oObj.Td2_class)) { return false; }
            if (!this.Td2_colspan.Equals(x_oObj.Td2_colspan)) { return false; }
            if (!this.Drp2_FontSize.Equals(x_oObj.Drp2_FontSize)) { return false; }
            if (!this.Td1_width.Equals(x_oObj.Td1_width)) { return false; }
            if (!this.Td1_class.Equals(x_oObj.Td1_class)) { return false; }
            if (!this.Drp1EventHandler.Equals(x_oObj.Drp1EventHandler)) { return false; }
            if (!this.Span2_class.Equals(x_oObj.Span2_class)) { return false; }
            if (!this.MobileOrderVasRightJoinBusinessVas.Equals(x_oObj.MobileOrderVasRightJoinBusinessVas)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.Drp2EventHandler = null;
            this.Ds3 = null;
            this.DB = null;
            this.Ds2 = null;
            this.Span2_FontSize = global::System.String.Empty;
            this.Span1_FontSize = global::System.String.Empty;
            this.Ds = null;
            this.Span1_class = global::System.String.Empty;
            this.Td1_height = global::System.String.Empty;
            this.GiftVasCreate_Holder = null;
            this.Drp1_FontSize = global::System.String.Empty;
            this.Td2_height = global::System.String.Empty;
            this.VasDrp2List = null;
            this.VasDrp1List = null;
            this.Td2_class = global::System.String.Empty;
            this.Td2_colspan = global::System.String.Empty;
            this.Drp2_FontSize = global::System.String.Empty;
            this.Td1_width = global::System.String.Empty;
            this.Td1_class = global::System.String.Empty;
            this.Drp1EventHandler = null;
            this.Span2_class = global::System.String.Empty;
            this.MobileOrderVasRightJoinBusinessVas = null;
            this.BusinessVasDescriptionList = null;
        }
        #endregion Release


        #region Clone
        public VasCreateHolderControl DeepClone()
        {
            VasCreateHolderControl VasCreateHolderControl_Clone = new VasCreateHolderControl();
            VasCreateHolderControl_Clone.SetDrp2EventHandler(this.Drp2EventHandler);
            VasCreateHolderControl_Clone.SetDs3(this.Ds3);
            VasCreateHolderControl_Clone.SetDB(this.DB);
            VasCreateHolderControl_Clone.SetDs2(this.Ds2);
            VasCreateHolderControl_Clone.SetSpan2_FontSize(this.Span2_FontSize);
            VasCreateHolderControl_Clone.SetSpan1_FontSize(this.Span1_FontSize);
            VasCreateHolderControl_Clone.SetDs(this.Ds);
            VasCreateHolderControl_Clone.SetSpan1_class(this.Span1_class);
            VasCreateHolderControl_Clone.SetTd1_height(this.Td1_height);
            VasCreateHolderControl_Clone.SetGiftVasCreate_Holder(this.GiftVasCreate_Holder);
            VasCreateHolderControl_Clone.SetDrp1_FontSize(this.Drp1_FontSize);
            VasCreateHolderControl_Clone.SetTd2_height(this.Td2_height);
            VasCreateHolderControl_Clone.SetVasDrp2List(this.VasDrp2List);
            VasCreateHolderControl_Clone.SetVasDrp1List(this.VasDrp1List);
            VasCreateHolderControl_Clone.SetTd2_class(this.Td2_class);
            VasCreateHolderControl_Clone.SetTd2_colspan(this.Td2_colspan);
            VasCreateHolderControl_Clone.SetDrp2_FontSize(this.Drp2_FontSize);
            VasCreateHolderControl_Clone.SetTd1_width(this.Td1_width);
            VasCreateHolderControl_Clone.SetTd1_class(this.Td1_class);
            VasCreateHolderControl_Clone.SetDrp1EventHandler(this.Drp1EventHandler);
            VasCreateHolderControl_Clone.SetSpan2_class(this.Span2_class);
            VasCreateHolderControl_Clone.SetMobileOrderVasRightJoinBusinessVas(this.MobileOrderVasRightJoinBusinessVas);
            VasCreateHolderControl_Clone.SetBusinessVasDescriptionList(this.BusinessVasDescriptionList);
            return VasCreateHolderControl_Clone;
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
