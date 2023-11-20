using System;
using System.Collections;
using System.Collections.ObjectModel;
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
using System.Text;
using System.Xml.Linq;
using System.Data.Sql;
using System.Data.SqlClient;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;


public partial class AdminToPyViewExport : NEURON.WEB.UI.BasePage
{
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion
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

    Dictionary<string, string> n_oVasNameData = GetVasNameList();

    VasCreateHolderControl n_oVasCreateHolderControl = VasCreateHolderControl.Instance();
    protected void Page_Load(object sender, EventArgs e)
    {

        WebFunc.PrivilegeCheck(this.Page);
    }

    public void ExportExcel()
    {
        WebFunc.ExportExcel(this.Page, "RetentionOrderExcelResult.xls");
    }

    public void SearchReportShow()
    {
        /*
        IQueryable<BusinessVasDescriptionEntity> _oBusinessVasDescriptionList = from sRwlVasDescList in _oBusinessVasDescriptionRepositoryBase.BusinessVasDescriptions
                                                          where (sRwlVasDescList.vas == "vmin_vas") ||
                                                          (sRwlVasDescList.vas == "mcam_vas") ||
                                                          (sRwlVasDescList.vas == "net_vas") ||
                                                          (sRwlVasDescList.vas == "now_hd_vas") ||
                                                          (sRwlVasDescList.vas == "gprs_vas" && sRwlVasDescList.active == true) ||
                                                          (sRwlVasDescList.vas == "sms_vas" && sRwlVasDescList.active == true) ||
                                                          (sRwlVasDescList.vas == "vm_vas")
                                                          orderby sRwlVasDescList.id
                                                          select sRwlVasDescList;
        if (_oBusinessVasDescriptionList.Count<BusinessVasDescriptionEntity>() > 0)
        {
            foreach (BusinessVasDescriptionEntity _oItem in _oBusinessVasDescriptionList)
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
                        if (_oItem.GetActive() != null)
                        {
                            if (Convert.ToBoolean(_oItem.GetActive()))
                            {
                                if (!n_oSms_vas_desc.ContainsKey(_oItem.fee))
                                    n_oSms_vas_desc.Add(_oItem.fee, _oItem.vas_desc);
                            }
                        }
                        break;
                    case "vm_vas":
                        if (!n_oVm_vas_desc.ContainsKey(_oItem.fee))
                            n_oVm_vas_desc.Add(_oItem.fee, _oItem.vas_desc);
                        break;
                }
            }
        }
        */
        StringBuilder _oPcd_paid_go_wireless = new StringBuilder();
        _oPcd_paid_go_wireless.Append(" 'rwl_pcd_paid_go_wireless' = case ");
        _oPcd_paid_go_wireless.Append(" WHEN a.pcd_paid_go_wireless = 1 then 'YES' ");
        _oPcd_paid_go_wireless.Append(" ELSE '' ");
        _oPcd_paid_go_wireless.Append(" END ");

        StringBuilder _oPlan_eff = new StringBuilder();
        _oPlan_eff.Append(" 'rwl_plan_eff' = case ");
        _oPlan_eff.Append(" WHEN a.plan_eff  = 'Next Bill Date'  AND (a.bill_cut_date IS NOT NULL AND a.bill_cut_date <>'' ) THEN convert(varchar(10),dateadd(d,1,a.bill_cut_date),101) ");
        _oPlan_eff.Append(" WHEN a.plan_eff  = 'Next Bill Date'  AND (a.bill_cut_date IS NULL OR a.bill_cut_date='' ) THEN 'Next Bill Date' ");
        _oPlan_eff.Append(" ELSE convert(varchar(10),a.plan_eff_date,101) ");
        _oPlan_eff.Append(" END ");

        StringBuilder _oCon_eff_date = new StringBuilder();
        _oCon_eff_date.Append(" 'rwl_con_eff_date' = case ");
        _oCon_eff_date.Append(" WHEN a.next_bill = 1 AND ( a.bill_cut_date IS NOT NULL AND a.bill_cut_date<>'') THEN convert(varchar(10),a.bill_cut_date,101) ");
        _oCon_eff_date.Append(" WHEN a.next_bill = 1 AND ( a.bill_cut_date IS NOT NULL OR a.bill_cut_date<>'')  THEN 'Next Bill Cut Date' ");
        _oCon_eff_date.Append(" ELSE convert(varchar(10),a.con_eff_date,101) ");
        _oCon_eff_date.Append(" END ");

        StringBuilder _oAccept = new StringBuilder();
        _oAccept.Append(" 'rwl_accept' = case ");
        _oAccept.Append(" WHEN a.accept ='Y' AND (a.accept IS NOT NULL AND a.accept<>'') THEN 'Accept Autoroll' ");
        _oAccept.Append(" WHEN a.accept ='reject' AND (a.accept IS NOT NULL AND a.accept<>'') THEN 'Reject Autoroll (change to FTG)' ");
        _oAccept.Append(" WHEN a.accept = 'No Comment' AND (a.accept IS NOT NULL AND a.accept<>'') THEN 'No Comment' ");
        _oAccept.Append(" ELSE '' ");
        _oAccept.Append(" END ");

        StringBuilder _oVasHeader = new StringBuilder();
        StringBuilder _oVasQuery = new StringBuilder();
        foreach (KeyValuePair<string, string> _oItem in n_oVasNameData)
        {
            if (_oVasQuery.ToString() != string.Empty) { _oVasQuery.Append(","); }
            string _sVas_Field = _oItem.Key.ToString();
            string _sVas_Name = _oItem.Value.ToString();
            if (!_sVas_Name.Trim().Equals(string.Empty))
            {
                _oVasQuery.Append("'" + _sVas_Field + "'=");
                _oVasQuery.Append(" (SELECT TOP 1 '" + _sVas_Field + "'= CASE ");
                _oVasQuery.Append(" WHEN v.vas_value is not null AND v.fee is not null THEN v.vas_value +','+v2.vas_desc ");
                _oVasQuery.Append(" WHEN v.vas_value is not null THEN v.vas_value ");
                _oVasQuery.Append(" ELSE '' ");
                _oVasQuery.Append(" END FROM MobileOrderVas v with (nolock)  LEFT JOIN BusinessVasDescription v2 with (nolock) ON v.multi_id=v2.id WHERE v.vas_field='" + _sVas_Field + "' AND v.order_id=a.order_id ) ");
            }
        }









        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("select  a.*,a.order_id+100000 'record_id', b.mid, b.email_date, b.report_type, b.fallout_remark, b.fallout_reply, b.order_status, b.fallout_main_category , b.fallout_reason, b.retrieve_sn, b.retrieve_date, b.cid as admin_sn, b.cdate as admin_date," + _oPcd_paid_go_wireless.ToString() + "," + _oPlan_eff.ToString() + "," + _oCon_eff_date.ToString() + "," + _oAccept.ToString() + "," + _oVasQuery.ToString() + " FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder a with (nolock), " + Configurator.MSSQLTablePrefix + "MobileOrderReport b with (nolock) WHERE a.order_id=b.order_id and b.active=1 and b.retrieve_date is not null ");
        if (Func.RB(WebFunc.qsOrder_id) && (Func.RB(WebFunc.qsOrder_id2) && !WebFunc.qsOrder_id2.Equals(string.Empty)))
            _oQuery.Append(" and a.order_id>='" + Func.IDSubtract100000(WebFunc.qsOrder_id).ToString() + "'");
        else if (Func.RB(WebFunc.qsOrder_id))
            _oQuery.Append(" and a.order_id='" + Func.IDSubtract100000(WebFunc.qsOrder_id).ToString() + "'");

        if (Func.RB(WebFunc.qsOrder_id2))
            _oQuery.Append(" and a.order_id<='" + Func.IDSubtract100000(Convert.ToInt32(WebFunc.qsOrder_id2)).ToString() + "'");

        if (Func.RB(WebFunc.qsEmail_date))
            _oQuery.Append(" and b.email_date>='" + ((DateTime)WebFunc.qsEmail_date).ToString("yyyyMMdd") + " 00:00'");

        if (Func.RB(WebFunc.qsEmail_date2))
            _oQuery.Append(" and b.email_date<='" + ((DateTime)WebFunc.qsEmail_date2).ToString("yyyyMMdd") + " 23:59'");

        if (Func.RB(WebFunc.qsLog_date))
            _oQuery.Append(" and a.log_date>='" + ((DateTime)WebFunc.qsLog_date).ToString("yyyyMMdd") + " 00:00'");

        if (Func.RB(WebFunc.qsLog_date2))
            _oQuery.Append(" and a.log_date<='" + ((DateTime)WebFunc.qsLog_date2).ToString("yyyyMMdd") + " 23:59'");

        /* Added on 16DEC2010 by Ben
 * Normal Search: by D_date, Plan_eff_date
 * Special PY Rule: D_date+1 if D_date is earlier, Plan_eff_date+3 if Plan_eff_date is earlier */

        _oQuery.Append(PYReportFunc.appendDDate_PlanEffDateToReportSQL((DateTime?)WebFunc.qsD_date, (DateTime?)WebFunc.qsD_date2, (DateTime?)WebFunc.qsPlan_eff_date, (DateTime?)WebFunc.qsPlan_eff_date2, (HttpContext.Current.Request["D_datePlan_eff_dateRule"] != null)));

        /* End */

        /* Added on 31DEC2010 by Ben
* For rwl_w_hs : amount>0 or amount=0 */

        string _sHandset_amount = (HttpContext.Current.Request["handset_amount"] == null ? "" : HttpContext.Current.Request["handset_amount"]);
        _oQuery.Append(PYReportFunc.appendHSAmountSQL(_sHandset_amount));

        /* End */

        if (Func.RQ(WebFunc.qsReport_type) == "rwl_mod_w_con")
        {
            _oQuery.Append(" and b.sent_again=1 ");
        }
        if (Func.RQ(WebFunc.qsReport_type) == "rwl_2g_mod_w_con")
        {
            _oQuery.Append(" and b.sent_again=2 ");
        }


        if (Func.RB(WebFunc.qsMrt_no))
            _oQuery.Append(" and a.mrt_no='" + WebFunc.qsMrt_no.ToString() + "'");
        _oQuery.Append(" and a.program<>'MOBILE LITE (SIM ONLY)' and a.program<>'MOBILE LITE (HS OFFER)'");
        _oQuery.Append(" order by a.order_id");

        int _iViewid = 0;

        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
        while (_oDr.Read())
        {
            _iViewid += 1;
            StringBuilder _oReportWrite = new StringBuilder();
            _oReportWrite.AppendLine("<tr>");
            _oReportWrite.AppendLine("<td nowrap >" + _iViewid.ToString()+ "</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["record_id"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["active"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["report_type"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["log_date"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["family_name"]) +" "+Func.FR(_oDr["given_name"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["ac_no"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["mrt_no"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["rwl_accept"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["rwl_pcd_paid_go_wireless"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["rate_plan"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["con_per"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["trade_field"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["bundle_name"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["free_mon"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["rebate"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["cancel_renew"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["hs_model"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["premium"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["rwl_plan_eff"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["rwl_con_eff_date"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["bill_cut_num"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["action_required"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["waive"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["action_eff_date"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["ord_place_by"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["ord_place_rel"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["ord_place_id_type"]).Trim()+"&nbsp;"+Func.FR(_oDr["ord_place_hkid"]).Trim()+" </td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["s_premium"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["s_premium1"]).Trim() + "</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["s_premium2"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["s_premium3"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["s_premium4"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["edf_no"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["d_date"]).Trim()+" </td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["cust_staff_no"]).Trim()+"</td>");            
			_oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["order_status"]).Trim()+"</td>");
	    	_oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["fallout_main_category"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["fallout_reason"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["fallout_remark"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["remarks2PY"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["old_ord_id"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["staff_no"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["monthly_payment_type"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["m_card_type"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >'"+Func.FR(_oDr["m_card_no"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["m_card_holder2"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["m_card_exp_month"]).Trim()+" / "+Func.FR(_oDr["m_card_exp_year"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["extra_rebate_amount"]).Trim()+"</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["extra_rebate"]).Trim() + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["amount"]).Trim() + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["rebate_amount"]).Trim() + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["redemption_notice_option"]).Trim() + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["bill_medium_email"]) + "</td>");

            foreach (KeyValuePair<string, string> _oItem in n_oVasNameData)
            {
                string _sVas_Field = _oItem.Key.ToString();
                string _sVas_Name = _oItem.Value.ToString();
                if (!_sVas_Name.Trim().Equals(string.Empty))
                    _oReportWrite.AppendLine("<td nowrap=\"nowrap\" class=\"row2\">" + Func.FR(_oDr[_sVas_Field]) + "</td>\n");
            }

            _oReportWrite.AppendLine("</tr>");
            Response.Write(_oReportWrite.ToString());

        }
        _oDr.Close();
        _oDr.Dispose();
    }

    #region GetDB
    protected MSSQLConnect GetDB()
    {
        MSSQLConnect _oDB = new MSSQLConnect();
        _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
        _oDB.bWithNoLock = true;
        return _oDB;
    }
    #endregion

    #region Get Oracle DB
    protected ODBCConnect GetORDB()
    {
        ODBCConnect _oDB = new ODBCConnect();
        _oDB.SetConnStr(Configurator.DBName.ORADNS + ((!"".Equals(Configurator.IsUat())) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion

    public void VasHeader()
    {
        List<string> _oList = new List<string>();
        IDSQuery _oDr = IDSQuery.CreateDsCriteria(n_oVasCreateHolderControl.GetDs(), BusinessVas.Para.TableName())
            .Add(DsExpression.Eq(BusinessVas.Para.active, 1));
        while (_oDr.Read())
        {
            string _sVas_name = _oDr[BusinessVas.Para.vas_name].ToString();
            if (!_oList.Contains(_sVas_name))
            {
                _oList.Add(_sVas_name);

                Response.Write("<td class=\"row1\">" + _sVas_name + "</td>");
            }
        }
        _oDr.Close();
    }



    #region VasHeaderShow
    protected void VasHeaderShow()
    {
        StringBuilder _oVasHeader = new StringBuilder();
        StringBuilder _oVasQuery = new StringBuilder();

        foreach (KeyValuePair<string, string> _oItem in n_oVasNameData)
        {
            if (_oVasQuery.ToString() != string.Empty) { _oVasQuery.Append(","); }
            string _sVas_Field = _oItem.Key.ToString();
            string _sVas_Name = _oItem.Value.ToString();
            if (!_sVas_Name.Trim().Equals(string.Empty))
                _oVasHeader.Append("<td class=\"row1\">" + _sVas_Name + "</td>");
        }
        Response.Write(_oVasHeader.ToString());
    }
    #endregion

    protected static Dictionary<string, string> GetVasNameList()
    {
        Dictionary<string, string> _oVasNameData = new Dictionary<string, string>();
        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT DISTINCT vas_field,vas_name FROM " + Configurator.MSSQLTablePrefix + "BusinessVas WHERE active=1 ORDER BY vas_field");
        while (_oDr.Read())
        {
            string _sVas_Field = Func.FR(_oDr["vas_field"]).ToString().Trim();
            string _sVas_Name = Func.FR(_oDr["vas_name"]).ToString().Trim();
            if (!_oVasNameData.ContainsKey(_sVas_Field))
                _oVasNameData.Add(_sVas_Field, _sVas_Name);
        }
        _oDr.Close();
        _oDr.Dispose();
        return _oVasNameData;
    }

    protected void admin_view_rp_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (!e.Item.ItemIndex.Equals(-1))
        {
            int _iOrderID = e.Item.ItemIndex + 1;
            Literal _oViewid = (Literal)e.Item.FindControl("viewid");
            _oViewid.Text = _iOrderID.ToString();

            Literal _oMobileRetentionOrder_id = (Literal)e.Item.FindControl("MobileRetentionOrder_id");
            PlaceHolder _oVas_PlaceHolder = (PlaceHolder)e.Item.FindControl("vas_placeholder");
            StringBuilder _oPlace = new StringBuilder();
            if (_oMobileRetentionOrder_id != null && _oVas_PlaceHolder != null)
            {
                /*
                SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT DISTINCT vas_field FROM " + Configurator.MSSQLTablePrefix + "BusinessVas WHERE active=1");
                while (_oDr.Read())
                {

                    SqlDataReader _oDr2 = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT a.vas_value vas_value, a.fee fee  FROM " + Configurator.MSSQLTablePrefix + "MobileOrderVas a RIGHT JOIN " + Configurator.MSSQLTablePrefix + "BusinessVas b ON a.vas_id=b.id WHERE a.active=1 AND a.order_id='" + _oMobileRetentionOrder_id.Text + "' AND b.vas_field='" + Func.FR(_oDr["vas_field"]) + "'");
                    if (_oDr2.Read())
                    {
                        string _sVas_field = Func.FR(_oDr["vas_field"]);

                        if (_sVas_field == "license_waiver")
                        {
                            string _sFree = (_sVas_field.Length > 1) ? _sVas_field.Substring(0, 1) : string.Empty;
                            _oPlace.Append("<td nowrap class=\"row2\">" + Func.FR(_oDr2["vas_value"]) + "</td>");
                        }
                        else if (bSpecialVas(Func.FR(_oDr["vas_field"])))
                        {
                            string _sFee = ShowSpecialVas(Func.FR(_oDr2["fee"]).Trim(), Func.FR(_oDr["vas_field"]));
                            _oPlace.Append("<td nowrap class=\"row2\">" + _sFee + "</td>");
                        }
                        else
                        {
                            string _sFree = Func.FR(_oDr2["fee"]).Trim();
                            string _sFeeShow = (_sFree != string.Empty) ? "," + _sFree : string.Empty;
                            _oPlace.Append("<td nowrap class=\"row2\">" + Func.FR(_oDr2["vas_value"]) + _sFeeShow + "</td>");
                        }
                    }
                    else
                    {
                        _oPlace.Append("<td nowrap ></td>");
                    }
                    _oDr2.Close();
                    _oDr2.Dispose();
                }
                _oDr.Close();
                _oDr.Dispose();

                _oVas_PlaceHolder.Controls.Add(new LiteralControl(_oPlace.ToString()));
                */

                int _iOrder_id;
              
                /*
                if (int.TryParse(_oMobileRetentionOrder_id.Text, out _iOrder_id))
                    _oVas_PlaceHolder.Controls.Add(new LiteralControl(n_oVasCreateHolderControl.ReportTableTrShow(_iOrder_id).ToString()));
            */
            }

            /*
            Literal _oLicense_waiver = (Literal)e.Item.FindControl("license_waiver");
            if (_oLicense_waiver.Text.Length > 1)
                _oLicense_waiver.Text = _oLicense_waiver.Text.Substring(0, 1);
            */
            Literal _oAccept = (Literal)e.Item.FindControl("accept");
            if ("Y".Equals(_oAccept.Text.ToLower()))
                _oAccept.Text = "Accept Autoroll";
            else if ("reject".Equals(_oAccept.Text.ToLower()))
                _oAccept.Text = "Reject Autoroll (change to FTG) ";
            else if ("no_comment".Equals(_oAccept.Text.ToLower()))
                _oAccept.Text = "No Comment";

            /*
            Literal _oGprs_vas = (Literal)e.Item.FindControl("gprs_vas");
            string _sGrps_vastxt = string.Empty;
            if (!"".Equals(_oGprs_vas.Text))
            {
                if (_oGprs_vas.Text.IndexOf(",") > -1)
                {
                    string[] _oGprs = _oGprs_vas.Text.Split((",")[0]);
                    _sGrps_vastxt = _oGprs[0];
                    if (_oGprs.Length > 1)
                    {
                        if (!"".Equals(_oGprs[1]))
                        {
                            if (n_oGprs_vas_desc.Contains(_oGprs[1]))
                                _sGrps_vastxt += n_oGprs_vas_desc[_oGprs[1]].ToString();
                        }
                    }
                }
            }
            _oGprs_vas.Text = _sGrps_vastxt;

            Literal _oSms_vas = (Literal)e.Item.FindControl("sms_vas");
            string _sSmstxt = string.Empty;
            if (!"".Equals(_oSms_vas.Text))
            {
                if (_oSms_vas.Text.IndexOf(",") > -1)
                {
                    string[] _oSms = _oSms_vas.Text.Split((",")[0]);
                    _sSmstxt = _oSms[0];
                    if (_oSms.Length > 1)
                    {
                        if (!"".Equals(_oSms[1]))
                        {
                            if (n_oSms_vas_desc.Contains(_oSms[1]))
                                _sSmstxt += n_oSms_vas_desc[_oSms[1]].ToString();
                        }
                    }
                }
            }
            _oSms_vas.Text = _sSmstxt;

            Literal _oWaive = (Literal)e.Item.FindControl("waive");
            if ("TRUE".Equals(_oWaive.Text.ToUpper()) || "1".Equals(_oWaive.Text.ToUpper()))
                _oWaive.Text = "YES";
            else
                _oWaive.Text = "NO";


            Literal _oNow_hd_vas = (Literal)e.Item.FindControl("now_hd_vas");
            string _oNowtxt = string.Empty;
            if (!"".Equals(_oNow_hd_vas.Text))
            {
                if (_oNow_hd_vas.Text.IndexOf(",") > -1)
                {
                    string[] _oNow = _oNow_hd_vas.Text.Split((",")[0]);
                    _oNowtxt = _oNow[0];
                    if (_oNow.Length > 1)
                    {
                        if (!"".Equals(_oNow[1]))
                        {
                            if (n_oNow_hd_vas_desc.Contains(_oNow[1]))
                                _oNowtxt += n_oNow_hd_vas_desc[_oNow[1]].ToString();
                        }
                    }
                }
            }
            _oNow_hd_vas.Text = _oNowtxt;

            Literal _oOld_ord_id = (Literal)e.Item.FindControl("old_ord_id");
            if (!"0".Equals(_oOld_ord_id.Text) && !"".Equals(_oOld_ord_id.Text.Trim()))
                _oOld_ord_id.Text = Func.IDAdd100000(Convert.ToInt32(_oOld_ord_id.Text));

            Literal _oNet_vas = (Literal)e.Item.FindControl("net_vas");
            string _oNet_vasTxt = string.Empty;
            if (!"".Equals(_oNet_vas.Text))
            {
                if (_oNet_vas.Text.IndexOf(",") > -1)
                {
                    string[] _oNet = _oNet_vas.Text.Split((",")[0]);
                    _oNet_vasTxt = _oNet[0];
                    if (_oNet.Length > 1)
                    {
                        if (!"".Equals(_oNet[1]))
                        {
                            if (n_oNet_vas_desc.Contains(_oNet[1]))
                                _oNet_vasTxt += n_oNet_vas_desc[_oNet[1]].ToString();
                        }
                    }
                }
            }
            _oNet_vas.Text = _oNet_vasTxt;

            Literal _oVmin_vas = (Literal)e.Item.FindControl("vmin_vas");
            string _oVmin_vasTxt = string.Empty;
            if (!"".Equals(_oVmin_vas.Text))
            {
                if (_oVmin_vas.Text.IndexOf(",") > -1)
                {
                    string[] _oVim = _oVmin_vas.Text.Split((",")[0]);
                    _oVmin_vasTxt = _oVim[0];
                    if (_oVim.Length > 1)
                    {
                        if (!"".Equals(_oVim[1]))
                        {
                            if (n_oVim_vas_desc.Contains(_oVim[1]))
                                _oVmin_vasTxt += n_oVim_vas_desc[_oVim[1]].ToString();
                        }
                    }
                }
            }
            _oVmin_vas.Text = _oVmin_vasTxt;

            Literal _oMcam_vas = (Literal)e.Item.FindControl("mcam_vas");
            string _oMcam_vasTxt = string.Empty;
            if (!"".Equals(_oMcam_vas.Text))
            {
                if (_oMcam_vas.Text.IndexOf(",") > -1)
                {
                    string[] _oMcam = _oMcam_vas.Text.Split((",")[0]);
                    _oMcam_vasTxt = _oMcam[0];
                    if (_oMcam.Length > 1)
                    {
                        if (!"".Equals(_oMcam[1]))
                        {
                            if (n_oMcam_vas_desc.Contains(_oMcam[1]))
                                _oMcam_vasTxt += n_oMcam_vas_desc[_oMcam[1]].ToString();
                        }
                    }
                }
            }
            _oMcam_vas.Text = _oMcam_vasTxt;

            Literal _oVm_vas = (Literal)e.Item.FindControl("vm_vas");
            string _oVm_vasTxt = string.Empty;
            if (!"".Equals(_oVm_vas.Text))
            {
                if (_oVm_vas.Text.IndexOf(",") > -1)
                {
                    string[] _oVm = _oVm_vas.Text.Split((",")[0]);
                    _oVm_vasTxt = _oVm[0];
                    if (_oVm.Length > 1)
                    {
                        if (!"".Equals(_oVm[1]))
                        {
                            if (n_oVm_vas_desc.Contains(_oVm[1]))
                                _oVm_vasTxt += n_oVm_vas_desc[_oVm[1]].ToString();
                        }
                    }
                }
            }
            _oVm_vas.Text = _oVm_vasTxt;
             * */
        }
    }

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

        string _sResult = string.Empty;
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
}
