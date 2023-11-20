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
using log4net;
using System.Reflection;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

public partial class RetrieveViewAction : NEURON.WEB.UI.BasePage
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
        this.HeaderScripts.Text = string.Format(
        @"<script type=""text/javascript"" src=""{0}/Resources/Scripts/jquery-1.3.2.min.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/global.js""></script>
        <!--[if lte IE 6]><script defer type=""text/javascript"" src=""{0}/Resources/Scripts/pngfix.js""></script><![endif]-->
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/norefresh.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/script.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/jquery-ui-1.8.2.custom.min.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/jquery.alerts.js""></script>
        <link rel=""stylesheet"" href=""{0}/Resources/Styles/jquery.alerts.css"" type=""text/css"" />"
       , Request.ApplicationPath);

        WebFunc.PrivilegeCheck(this.Page);

    }




    protected void SearchReportShow()
    {
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

        StringBuilder _oCooling_offer = new StringBuilder();
        _oCooling_offer.Append(" 'rwl_cooling_offer' = case ");
        _oCooling_offer.Append(" WHEN a.cooling_offer = 'YES' THEN 'YES' ");
        _oCooling_offer.Append(" ELSE 'NO' ");
        _oCooling_offer.Append(" END ");

        StringBuilder _oCooling_date = new StringBuilder();
        _oCooling_date.Append(" 'rwl_cooling_date' = case ");
        _oCooling_date.Append(" WHEN a.cooling_offer = 'YES' AND (a.cooling_date IS NOT NULL AND a.cooling_date<>'') THEN convert(varchar(10),a.cooling_date,101) ");
        _oCooling_date.Append(" ELSE '' ");
        _oCooling_date.Append(" END ");

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
                _oVasQuery.Append(" END FROM MobileOrderVas v with (nolock) LEFT JOIN BusinessVasDescription v2 with (nolock) ON v.multi_id=v2.id WHERE v.vas_field='" + _sVas_Field + "' AND v.order_id=a.order_id ) ");
            }
        }

        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("SELECT a.*,a.order_id+100000 'record_id', b.mid , b.email_date, b.report_type, b.order_status, b.fallout_remark, b.fallout_reply, b.fallout_main_category, b.fallout_reason, b.retrieve_sn, b.retrieve_date, b.cid as admin_sn, b.cdate as admin_date," + _oPlan_eff.ToString() + "," + _oCon_eff_date.ToString() + "," + _oCooling_offer.ToString() + "," + _oCooling_date.ToString() + "," + _oAccept.ToString() + "," + _oVasQuery.ToString() + " FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder a with (nolock), " + Configurator.MSSQLTablePrefix + "MobileOrderReport b with (nolock) WHERE a.order_id=b.order_id AND b.active=1   ");

        if (RWLFramework.CurrentUser[this.Page].Uid != "A8350006")
        {
            _oQuery.Append("AND retrieve_date is null");
        }

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

        if (Func.RB(WebFunc.qsMrt_no))
            _oQuery.Append(" and a.mrt_no='" + WebFunc.qsMrt_no.ToString() + "'");

        if (Func.RB(WebFunc.qsReport_type))
            _oQuery.Append(" and b.report_type='" + WebFunc.qsReport_type.ToString() + "'");
        else
            _oQuery.Append(" and b.report_type<>'rwl_cust'");

        if (Func.RB(WebFunc.qsOrder_status))
        {
            if ("no_follow".Equals(WebFunc.qsOrder_status))
                _oQuery.Append(" and (b.order_status='' or b.order_status is null)");
            else if ("no_follow_t4".Equals(WebFunc.qsOrder_status))
                _oQuery.Append(" and (b.order_status='' or b.order_status is null) and DATEDIFF(d,b.email_date,getdate())>4 ");
            else
                _oQuery.Append(" and b.order_status='" + WebFunc.qsOrder_status.ToString() + "'");
        }


        if (Func.RB(WebFunc.qsFallout_main_category))
            _oQuery.Append(" AND b.fallout_main_category='" + WebFunc.qsFallout_main_category.ToString() + "' ");

        if (Func.RB(WebFunc.qsFallout_reason))
            _oQuery.Append(" AND b.fallout_reason='" + WebFunc.qsFallout_reason.ToString() + "' ");


        if (!WebFunc.qsGo_wireless.Equals("ALL"))
        {
            if (WebFunc.qsGo_wireless.Equals("YES"))
                _oQuery.Append(" AND (a.go_wireless is not null AND a.go_wireless <>'NO' AND  a.go_wireless <>'') ");
            else if (WebFunc.qsGo_wireless.Equals("NO"))
                _oQuery.Append(" AND (a.go_wireless is null or a.go_wireless ='NO' or a.go_wireless='') ");
        }

        _oQuery.Append(" order by a.order_id");

        int _iViewid = 0;

        SqlDataReader _oDr = GetDB().GetSearch(_oQuery.ToString());
        while (_oDr.Read())
        {
            _iViewid += 1;
            StringBuilder _oReportWrite = new StringBuilder();
            _oReportWrite.AppendLine("<tr>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+_iViewid.ToString()+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"> <input type=\"checkbox\" name=\"retrieve_id\" id=\"retrieve_id\" value=\""+Func.FR(_oDr["mid"])+"\" checked/>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\"><a href=\"#\" onclick='window.open(\"HistoryReportViewImplement.aspx?order_id="+Func.FR(_oDr["order_id"])+"\",\"_blank\",\"toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=yes, copyhistory=no, width=600, height=200\")'>Order History</a></span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\"><a href=\"#\" onClick='window.open(\"AdminViewHistoryImplement.aspx?order_id="+Func.FR(_oDr["order_id"])+"\",\"_blank\",\"toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=yes, copyhistory=no, width=600, height=200\")'>"+Func.FR(_oDr["record_id"])+"</a></span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["email_date"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["report_type"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["log_date"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["family_name"]) +" "+Func.FR(_oDr["given_name"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["ac_no"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["mrt_no"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["rwl_accept"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["rate_plan"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["con_per"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["trade_field"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["bundle_name"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["free_mon"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["rebate"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["cancel_renew"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["hs_model"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["premium"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["vas_eff_date"])+"  </span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["rwl_plan_eff"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["rwl_con_eff_date"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["bill_cut_num"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["action_required"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["waive"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["action_eff_date"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["exist_plan"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["reasons"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["staff_no"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["salesmancode"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["order_status"])+"</span></td>");
			_oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["fallout_main_category"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["fallout_reason"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["fallout_remark"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["fallout_reply"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["retrieve_sn"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["retrieve_date"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["admin_sn"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["admin_date"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["ord_place_by"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["ord_place_rel"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["ord_place_id_type"])+"&nbsp;"+Func.FR(_oDr["ord_place_hkid"])+"</span> </td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["s_premium"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:9px\">" + Func.FR(_oDr["s_premium1"]) + "</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:9px\">"+Func.FR(_oDr["s_premium2"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:9px\">" + Func.FR(_oDr["s_premium3"]) + "</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:9px\">" + Func.FR(_oDr["s_premium4"]) + "</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["edf_no"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["d_date"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["cust_staff_no"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["remarks2PY"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["old_ord_id"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["monthly_payment_type"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["m_card_type"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["m_card_no"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["m_card_holder2"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["m_card_exp_month"])+""+Func.FR(_oDr["m_card_exp_year"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["extra_rebate_amount"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["extra_rebate"])+"</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["amount"]) + "</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["rebate_amount"]) + "</span></td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["redemption_notice_option"]).Trim() + "</span></td>");
			_oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["bill_medium_email"]).Trim() + "</span></td>");

			foreach (KeyValuePair<string, string> _oItem in n_oVasNameData)
            {
                string _sVas_Field = _oItem.Key.ToString();
                string _sVas_Name = _oItem.Value.ToString();
                if (!_sVas_Name.Trim().Equals(string.Empty))
                    _oReportWrite.AppendLine("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr[_sVas_Field]) + "</span></td>\n");
            }

            _oReportWrite.AppendLine("</tr>");
            Response.Write(_oReportWrite.ToString());
        }
        if (_oDr != null)
        {
            _oDr.Close();
            _oDr.Dispose();
        }
        record_cnt.Value = _iViewid.ToString();
        
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
        _oDB.SetConnStr(Configurator.DBName.ORADNS+((Configurator.IsUat()) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion




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
                _oVasHeader.Append("<td class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">" + _sVas_Name + "</span></td>");
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

                Response.Write("<td class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">" + _sVas_name + "</span></td>");
            }
        }
        _oDr.Close();
    }

    protected void admin_view_rp_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (!e.Item.ItemIndex.Equals(-1))
        {
            int _iOrderID = e.Item.ItemIndex + 1;
            Literal _oViewid = (Literal)e.Item.FindControl("viewid");
            _oViewid.Text = _iOrderID.ToString();

            Literal _oMobileRetentionOrder_id = (Literal)e.Item.FindControl("MobileRetentionOrder_id");
            
            /*
            PlaceHolder _oVas_PlaceHolder = (PlaceHolder)e.Item.FindControl("vas_placeholder");
            StringBuilder _oPlace = new StringBuilder();
            if (_oMobileRetentionOrder_id != null && _oVas_PlaceHolder != null)
            {
                int _iOrder_id;
                if (int.TryParse(_oMobileRetentionOrder_id.Text, out _iOrder_id))
                    _oVas_PlaceHolder.Controls.Add(new LiteralControl(n_oVasCreateHolderControl.ReportTableTrShow(_iOrder_id).ToString()));
            }
            */

            Literal _oAccept = (Literal)e.Item.FindControl("accept");
            if ("Y".Equals(_oAccept.Text.ToLower()))
                _oAccept.Text = "Accept Autoroll";
            else if ("reject".Equals(_oAccept.Text.ToLower()))
                _oAccept.Text = "Reject Autoroll (change to FTG) ";
            else if ("no_comment".Equals(_oAccept.Text.ToLower()))
                _oAccept.Text = "No Comment";

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
