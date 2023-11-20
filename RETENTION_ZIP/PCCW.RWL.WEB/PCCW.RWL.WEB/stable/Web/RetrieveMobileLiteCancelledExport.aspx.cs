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
using System.Data.Odbc;
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

public partial class RetrieveMobileLiteCancelledExport : NEURON.WEB.UI.BasePage
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
    DateTime n_oNow = DateTime.Now;
    Dictionary<string, string> n_oVasNameData = GetVasNameList();
    VasCreateHolderControl n_oVasCreateHolderControl = VasCreateHolderControl.Instance();
    protected void Page_Load(object sender, EventArgs e)
    {
        WebFunc.PrivilegeCheck(this.Page);


    }

    public void ExportExcel()
    {
        WebFunc.ExportExcel(this.Page, "RetrieveViewExport.xls");
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


        StringBuilder _oRegAddr = new StringBuilder();
        _oRegAddr.Append("'d_reg_addr'= ");
        _oRegAddr.Append("(SELECT TOP 1 v3.d_type+' '+v3.d_room+' '+v3.d_floor+' '+v3.d_blk+' '+v3.d_build+' '+v3.d_street+' '+v3.d_district+' '+ ");
        _oRegAddr.Append("(CASE WHEN v3.d_region=0  THEN 'HK' ");
        _oRegAddr.Append(" WHEN v3.d_region=1  THEN 'KLN' ");
        _oRegAddr.Append(" WHEN v3.d_region=2  THEN 'NT' ");
        _oRegAddr.Append(" WHEN v3.d_region=3  THEN 'LT' ELSE '' END ");
        _oRegAddr.Append(") 'd_reg_addr' FROM MobileOrderAddress v3 with (nolock) ");
        _oRegAddr.Append("WHERE v3.address_type='REGISTERED_ADDRESS' AND v3.order_id=a.order_id ");
        _oRegAddr.Append(") ");

        StringBuilder _oBillAddr = new StringBuilder();
        _oBillAddr.Append("'d_bill_addr'= ");
        _oBillAddr.Append("(SELECT TOP 1 v3.d_type+' '+v3.d_room+' '+v3.d_floor+' '+v3.d_blk+' '+v3.d_build+' '+v3.d_street+' '+v3.d_district+' '+ ");
        _oBillAddr.Append("(CASE WHEN v3.d_region=0  THEN 'HK' ");
        _oBillAddr.Append(" WHEN v3.d_region=1  THEN 'KLN' ");
        _oBillAddr.Append(" WHEN v3.d_region=2  THEN 'NT' ");
        _oBillAddr.Append(" WHEN v3.d_region=3  THEN 'LT' ELSE '' END ");
        _oBillAddr.Append(") 'd_reg_addr' FROM MobileOrderAddress v3 with (nolock) ");
        _oBillAddr.Append("WHERE v3.address_type='BILLING_ADDRESS' AND v3.order_id=a.order_id ");
        _oBillAddr.Append(") ");

        StringBuilder _oMNPDetail = new StringBuilder();
        _oMNPDetail.Append("'mnp1'= (Select top 1 v4.company_name FROM MobileOrderMNPDetail v4 with (nolock) WHERE v4.order_id=a.order_id),");
        _oMNPDetail.Append("'mnp2'= (Select top 1 v4.Registered_name FROM MobileOrderMNPDetail v4 with (nolock) WHERE v4.order_id=a.order_id),");
        _oMNPDetail.Append("'mnp3'= (Select top 1 v4.Hkid FROM MobileOrderMNPDetail v4 with (nolock) WHERE v4.order_id=a.order_id),");
        _oMNPDetail.Append("'mnp4'= (Select top 1 (CASE WHEN v4.Transfer_to_3g=1  THEN 'YES' ELSE 'NO' END) FROM MobileOrderMNPDetail v4 with (nolock) WHERE v4.order_id=a.order_id),");
        _oMNPDetail.Append("'mnp5'= (Select top 1 CONVERT(nvarchar(15),v4.Transfer_idd_deposit) FROM MobileOrderMNPDetail v4 with (nolock) WHERE v4.order_id=a.order_id),");
        _oMNPDetail.Append("'mnp6'= (Select top 1 CONVERT(nvarchar(15),v4.Transfer_idd_roaming_deposit) FROM MobileOrderMNPDetail v4 with (nolock) WHERE v4.order_id=a.order_id),");
        _oMNPDetail.Append("'mnp7'= (Select top 1 CONVERT(nvarchar(15),v4.Transfer_no_hk_id_holder_deposit) FROM MobileOrderMNPDetail v4 with (nolock) WHERE v4.order_id=a.order_id),");
        _oMNPDetail.Append("'mnp8'= (Select top 1 CONVERT(nvarchar(15),v4.Transfer_no_add_proof_deposit) FROM MobileOrderMNPDetail v4 with (nolock) WHERE v4.order_id=a.order_id),");
        _oMNPDetail.Append("'mnp9'= (Select top 1 CONVERT(nvarchar(15),v4.Transfer_others_deposit) FROM MobileOrderMNPDetail v4 with (nolock) WHERE v4.order_id=a.order_id),");
        _oMNPDetail.Append("'mnp10'= (Select top 1 CONVERT (nvarchar(10),v4.Service_activation_date,101) FROM MobileOrderMNPDetail v4 with (nolock) WHERE v4.order_id=a.order_id),");
        _oMNPDetail.Append("'mnp11'= (Select top 1 v4.Service_activation_time FROM MobileOrderMNPDetail v4 with (nolock) WHERE v4.order_id=a.order_id),");
        _oMNPDetail.Append("'mnp12'= (Select top 1 v4.Ticker_number FROM MobileOrderMNPDetail v4 with (nolock) WHERE v4.order_id=a.order_id)");

        StringBuilder _oBillMedium = new StringBuilder();
        _oBillMedium.Append("'bill_medium1'= ");
        _oBillMedium.Append("(CASE WHEN a.bill_medium='0' THEN 'SMS bill $0: SMS number- '+a.sms_mrt ");
        _oBillMedium.Append(" WHEN a.bill_medium='1' THEN 'Email bill $0: Email- '+a.bill_medium_email ");
        _oBillMedium.Append(" WHEN a.bill_medium='2' THEN 'Paper bill $10' ");
        _oBillMedium.Append(" WHEN a.bill_medium='3' THEN 'SMS bill $0 + Email bill $0: SMS number-'+a.sms_mrt+',Email- '+a.bill_medium_email END ) + ");
        _oBillMedium.Append(" (CASE WHEN a.bill_medium_waive=1 THEN ' (WAIVED)' else '' END ) ");

        StringBuilder _oPrepayWaive = new StringBuilder();
        _oPrepayWaive.Append("'prepayment_waived'= ");
        _oPrepayWaive.Append(" (CASE WHEN a.prepayment_waive=1 THEN 'YES' ");
        _oPrepayWaive.Append(" WHEN a.prepayment_waive=0 THEN 'NO' ");
        _oPrepayWaive.Append(" ELSE '' END) ");

        StringBuilder _o3rdParty = new StringBuilder();
        _o3rdParty.Append("'3rd_party_receive_SIM' =");
        _o3rdParty.Append(" (select '3rd Party :'+(CASE WHEN v5.three_party =1 THEN 'TRUE ID_type:'+v5.type+' hkid: '+v5.hkid+' contact person: '+v5.plural+' '+v5.arthurization_person+' contact_number: '+v5.contact_no END)");
        _o3rdParty.Append(" from MobileOrderThreeParty v5 with (nolock) ");
        _o3rdParty.Append(" WHERE v5.order_id=a.order_id)");



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
        _oQuery.Append("SELECT a.*,a.order_id+100000 'record_id', b.mid , b.email_date, b.report_type, b.fallout_remark, b.fallout_reply, b.order_status, b.fallout_main_category , b.fallout_reason, b.retrieve_sn, b.retrieve_date, b.cid as admin_sn, b.cdate as admin_date," + _oPlan_eff.ToString() + "," + _oCon_eff_date.ToString() + "," + _oCooling_offer.ToString() + "," + _oCooling_date.ToString() + "," + _oAccept.ToString() + "," + _oRegAddr.ToString() + "," + _oBillMedium.ToString() + "," + _oBillAddr.ToString() + "," + _oMNPDetail.ToString() + "," + _oPrepayWaive.ToString() + "," + _o3rdParty.ToString() + "," + _oVasQuery.ToString() + " FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder a with (nolock), " + Configurator.MSSQLTablePrefix + "MobileOrderReport b with (nolock) WHERE a.order_id=b.order_id AND b.active=1   ");

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
        /*
        if (Func.RB(WebFunc.qsLog_date))
            _oQuery.Append(" and a.log_date>='" + ((DateTime)WebFunc.qsLog_date).ToString("yyyyMMdd") + " 00:00'");

        if (Func.RB(WebFunc.qsLog_date2))
            _oQuery.Append(" and a.log_date<='" + ((DateTime)WebFunc.qsLog_date2).ToString("yyyyMMdd") + " 23:59'");
        */
        /*
        if (Func.RB(WebFunc.qsD_date))
            _oQuery.Append(" and a.d_date >='" + ((DateTime)WebFunc.qsD_date).ToString("yyyyMMdd") + " 00:00'");

        if (Func.RB(WebFunc.qsD_date2))
            _oQuery.Append(" and a.d_date <='" + ((DateTime)WebFunc.qsD_date2).ToString("yyyyMMdd") + " 23:59'");
        */
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

        if (Func.RB(WebFunc.qsRetrieve_id))
            _oQuery.Append(" AND b.mid in (" + WebFunc.qsRetrieve_id.ToString() + ") ");

        _oQuery.Append("and a.program like '%MOBILE LITE%' order by a.order_id");

        int _iViewid = 0;

        SqlDataReader _oDr = GetDB().GetSearch(_oQuery.ToString());
        while (_oDr.Read())
        {
            string _sSim_card_no = "&nbsp;";
            if (!string.IsNullOrEmpty(Func.FR(_oDr["edf_no"])))
            {
                string _sRecordid = Func.FR(_oDr["record_id"]);
                OdbcDataReader _oDr2 = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT SIM_CARD_NO FROM SUNDAY_FORM WHERE Agree_no='" + _sRecordid + "'");
                if (_oDr2.Read())
                {
                    _sSim_card_no = ""+Func.FR(_oDr2["SIM_CARD_NO"]).Trim();
                }
                _oDr2.Close();
                _oDr2.Dispose();
            }

            _iViewid += 1;
            StringBuilder _oReportWrite = new StringBuilder();
            _oReportWrite.AppendLine("<tr>");
            _oReportWrite.AppendLine("<td nowrap >" + _iViewid.ToString() + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["record_id"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["email_date"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["edf_no"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["mrt_no"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["gender"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["family_name"]) +" "+Func.FR(_oDr["given_name"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >(" + Func.FR(_oDr["id_type"]) + ") " + Func.FR(_oDr["hkid"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["date_of_birth"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["d_reg_addr"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["d_bill_addr"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["change_payment_type"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap style='mso-number-format:\\@'>" + Func.FR(_oDr["m_card_no"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["m_card_holder2"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["m_card_exp_month"]) + "/" + Func.FR(_oDr["m_card_exp_year"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap style='mso-number-format:\\@'>" + _sSim_card_no + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["sim_item_code"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["rate_plan"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["trade_field"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["bundle_name"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["free_mon"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["rebate_amount"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["hs_model"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["amount"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["rebate"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["order_status"]) + "</td>");
	    	_oReportWrite.AppendLine("<td nowrap >"+Func.FR(_oDr["fallout_main_category"])+"</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["fallout_reason"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["fallout_remark"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap class=\"row2\">" + Func.FR(_oDr["fallout_reply"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["remarks2PY"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["d_date"]) + " </td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["mnp10"]) + " " + Func.FR(_oDr["mnp11"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["mnp1"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["mnp2"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["mnp3"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["mnp4"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["mnp5"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["mnp6"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["mnp7"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["mnp8"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["mnp9"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["mnp12"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["third_party_credit_card"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["card_holder"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["third_party_id_type"]) + " " + Func.FR(_oDr["third_party_hkid"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap style='mso-number-format:\\@'>" + Func.FR(_oDr["card_no"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["card_type"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["card_exp_month"]) + "/" + Func.FR(_oDr["card_exp_year"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["bill_medium1"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["prepayment_waived"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["3rd_party_receive_SIM"]) + "</td>");

            foreach (KeyValuePair<string, string> _oItem in n_oVasNameData)
            {
                string _sVas_Field = _oItem.Key.ToString();
                string _sVas_Name = _oItem.Value.ToString();
                if (!_sVas_Name.Trim().Equals(string.Empty))
                    _oReportWrite.AppendLine("<td nowrap=\"nowrap\" class=\"row2\">" + Func.FR(_oDr[_sVas_Field]) + "</td>\n");
            }

            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["channel"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["staff_no"]) + "</td>");
            _oReportWrite.AppendLine("<td nowrap >" + Func.FR(_oDr["salesmancode"]) + "</td>");
            _oReportWrite.AppendLine("</tr>");
            Response.Write(_oReportWrite.ToString());
        }
        if (_oDr != null)
        {
            _oDr.Close();
            _oDr.Dispose();
        }

        if (!RWLFramework.CurrentUser[this.Page].Uid.Equals("A8350006") &&
           !RWLFramework.CurrentUser[this.Page].Uid.Equals("1022243"))
        {
            RecordRetrieve();
        }
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
            {
                if (String.Compare(_sVas_Name, "IDD") == 0 || String.Compare(_sVas_Name, "Mob0060") == 0
                    || String.Compare(_sVas_Name, "$12 License Fee Waiver") == 0 || String.Compare(_sVas_Name, "Roaming") == 0
                    || String.Compare(_sVas_Name, "SMS") == 0)
                {
                    _oVasHeader.Append("<td class=\"row1\">" + _sVas_Name + "</td>");
                }
            }
        }
        Response.Write(_oVasHeader.ToString());
    }
    #endregion

    protected static Dictionary<string, string> GetVasNameList()
    {
        Dictionary<string, string> _oVasNameData = new Dictionary<string, string>();
        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT DISTINCT vas_field,vas_name FROM " + Configurator.MSSQLTablePrefix + "BusinessVas WHERE active=1 and (vas_name in ('IDD','Mob0060','$12 License Fee Waiver','Roaming','SMS')) ORDER BY vas_field");
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

    #region RecordRetrieve
    protected void RecordRetrieve()
    {
        if (!WebFunc.qsRetrieve_id.Equals(string.Empty))
        {
            StringBuilder _oQuery1 = new StringBuilder();
            _oQuery1.Append("INSERT INTO " + Configurator.MSSQLTablePrefix + "MobileOrderReportHistory(rec_no,order_id,email_date,report_type,order_status,fallout_reason,fallout_reply,fallout_remark,retrieve_sn,retrieve_date,active,cid,cdate,did,ddate,idd_vas,ext_place_tel,reactive_sn,reactive_date)");
            _oQuery1.Append("SELECT mid,order_id,email_date,report_type,order_status,fallout_reason,fallout_reply,fallout_remark,retrieve_sn,retrieve_date,active,cid,cdate,'" + RWLFramework.CurrentUser[this.Page].Uid.ToString() + "','" + n_oNow.ToString("dd/MM/yyyy HH:mm:ss") + "',idd_vas,ext_place_tel ,reactive_sn,reactive_date  FROM " + Configurator.MSSQLTablePrefix + "MobileOrderReport ");
            _oQuery1.Append(" WHERE mid in (" + WebFunc.qsRetrieve_id.ToString() + ") ");
            SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_oQuery1.ToString());

            StringBuilder _oQuery2 = new StringBuilder();
            _oQuery2.Append("UPDATE " + Configurator.MSSQLTablePrefix + "MobileOrderReport SET retrieve_sn='" + RWLFramework.CurrentUser[this.Page].Uid.ToString() + "',retrieve_date='" + n_oNow.ToString("dd/MM/yyyy HH:mm:ss") + "',sent_again=0 WHERE mid in (" + WebFunc.qsRetrieve_id.ToString() + ")");
            SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_oQuery2.ToString());
        }
    }
    #endregion

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
        _oDB.SetConnStr(Configurator.DBName.ORADNS + ((Configurator.IsUat()) ? "2" : string.Empty));
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
                if (String.Compare(_sVas_name, "IDD") == 0 || String.Compare(_sVas_name, "Mob0060") == 0
                    || String.Compare(_sVas_name, "$12 License Fee Waiver") == 0 || String.Compare(_sVas_name, "Roaming") == 0
                    || String.Compare(_sVas_name, "SMS") == 0)
                {
                    Response.Write("<td class=\"row1\">" + _sVas_name + "</td>");
                }
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
            PlaceHolder _oVas_PlaceHolder = (PlaceHolder)e.Item.FindControl("vas_placeholder");
            StringBuilder _oPlace = new StringBuilder();
            /*
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
