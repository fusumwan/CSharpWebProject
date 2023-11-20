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
using System.Globalization;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using log4net;
using System.Reflection;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

public partial class SearchRetentionOrderViewFinding : NEURON.WEB.UI.BasePage
{
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion
    BusinessVasDescriptionRepositoryBase _oBusinessVasDescriptionRepositoryBase = BusinessVasDescriptionRepositoryBase.Instance();
    ProfileTeamDetailRepositoryBase _oProfileTeamDetailRepositoryBase = ProfileTeamDetailRepositoryBase.Instance();
    MobileRetentionOrderRepositoryBase n_oMobileRetentionOrderRepositoryBase = MobileRetentionOrderRepositoryBase.Instance();
    Hashtable n_oVim_vas_desc = new Hashtable(new HsComparer());
    Hashtable n_oMcam_vas_desc = new Hashtable(new HsComparer());
    Hashtable n_oNet_vas_desc = new Hashtable(new HsComparer());
    Hashtable n_oNow_hd_vas_desc = new Hashtable(new HsComparer());
    Hashtable n_oGprs_vas_desc = new Hashtable(new HsComparer());
    Hashtable n_oSms_vas_desc = new Hashtable(new HsComparer());
    Hashtable n_oVm_vas_desc = new Hashtable(new HsComparer());
    List<string> n_oVasFieldFilter = BusinessVasBal.VasFieldFilter();
    Dictionary<string, string> n_oVasNameData = GetVasNameList();

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


    }


    protected void Frame_Load(object sender, EventArgs e)
    {
        WebFunc.PrivilegeCheck(this.Page);
        if (!IsPostBack)
        {
            //InitFrame();
        }
    }

    protected void Page_LoadComplete(object sender, EventArgs e)
    {
        
    }

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

    #region SearchReportShow
    protected void SearchReportShow()
    {

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
        try
        {
            if (_oBusinessVasDescriptionList != null)
            {
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
        }
        catch (Exception exp)
        {

        }
        List<string> _oSalesmancodeList = new List<string>();
        SaleManCodeProfile _oSaleManCodeProfile = new SaleManCodeProfile();
        _oSaleManCodeProfile.SetLv(RWLFramework.CurrentUser[this.Page].Lv);
        _oSaleManCodeProfile.SetUid(RWLFramework.CurrentUser[this.Page].Uid);
        _oSalesmancodeList = _oSaleManCodeProfile.Get_SalemanCodeList();

        

        StringBuilder _oReportStatusSelect = new StringBuilder();
        _oReportStatusSelect.Append(" 'report_status' = CASE ");
        _oReportStatusSelect.Append(" WHEN p.report_type ='rwl_suspend' THEN  (case  when order_status is not null then 'Suspension:'+order_status else 'Suspension:' end) ");
        _oReportStatusSelect.Append(" WHEN p.report_type ='rwl_fast' THEN (case  when order_status is not null then 'Early Start:'+order_status else 'Early Start:' end) ");
        _oReportStatusSelect.Append(" WHEN p.report_type ='rwl' THEN (case  when order_status is not null then 'New Order:'+order_status else 'New Order:' end) ");
        _oReportStatusSelect.Append(" WHEN p.report_type ='rwl_mod' THEN  (case  when order_status is not null then 'Modification:'+order_status else 'Modification:' end) ");
        _oReportStatusSelect.Append(" WHEN p.report_type ='rwl_NDS' THEN (case  when order_status is not null then 'New NDS Order:'+order_status else 'New NDS Order:' end) ");
        _oReportStatusSelect.Append(" WHEN p.report_type ='rwl_wo_hs' THEN (case  when order_status is not null then 'New non-HS Order:'+order_status else 'New non-HS Order:' end)  ");
        _oReportStatusSelect.Append(" WHEN p.report_type ='rwl_w_hs' THEN (case  when order_status is not null then 'New HS Order:'+order_status else 'New HS Order:' end) ");
        _oReportStatusSelect.Append(" WHEN p.report_type ='rwl_del' THEN (case  when order_status is not null then 'Cancellation:'+order_status else 'Cancellation:' end) ");
        _oReportStatusSelect.Append(" WHEN p.report_type ='rwl_vas' THEN (case  when order_status is not null then 'Change VAS:'+order_status else 'Change VAS:' end) ");
        _oReportStatusSelect.Append(" WHEN p.report_type ='rwl_opt_out' THEN (case  when order_status is not null then 'Opt Out Order:'+order_status else 'Opt Out Order:' end) ");
        _oReportStatusSelect.Append(" WHEN p.report_type ='rwl_ml' THEN (case  when order_status is not null then 'Mobile Lite Order:'+order_status else 'Mobile Lite Order:' end) ");
        _oReportStatusSelect.Append(" WHEN p.report_type ='rwl_ml_mod' THEN (case  when order_status is not null then 'Mobile Lite Order Modification:'+order_status else 'Mobile Lite Order Modification:' end) ");
        _oReportStatusSelect.Append(" WHEN p.report_type ='rwl_ml_cancel' THEN (case  when order_status is not null then 'Mobile Lite Order Cancellation:'+order_status else 'Mobile Lite Order Cancellation:' end) ");
        _oReportStatusSelect.Append(" WHEN p.report_type ='rwl_2g' THEN (case  when order_status is not null then 'New 2G Order:'+order_status else 'New 2G Order:' end) ");
        _oReportStatusSelect.Append(" WHEN p.report_type ='rwl_2g_cxl' THEN (case  when order_status is not null then '2G Cancellation:'+order_status else '2G Cancellation:' end) ");
        _oReportStatusSelect.Append(" WHEN p.report_type ='rwl_2g_mod' THEN (case  when order_status is not null then '2G Modification:'+order_status else '2G Modification:' end) ");
        _oReportStatusSelect.Append(" ELSE p.report_type END ");

  



        StringBuilder _oActiveSelect = new StringBuilder();
        _oActiveSelect.Append(" 'rwl_active' = case ");
        _oActiveSelect.Append(" WHEN o.active != 1 then 'Order Cancelled' ");
        _oActiveSelect.Append(" ELSE '' ");
        _oActiveSelect.Append(" END ");


        StringBuilder _oOldOrdIdSelect = new StringBuilder();
        _oOldOrdIdSelect.Append(" 'rwl_old_ord_id' = case ");
        _oOldOrdIdSelect.Append(" WHEN (o.old_ord_id = '' or o.old_ord_id='0') then '' ");
        _oOldOrdIdSelect.Append(" WHEN (cast(o.old_ord_id as int)>0) then (cast(o.old_ord_id as int)+100000) ");
        _oOldOrdIdSelect.Append(" ELSE '' ");
        _oOldOrdIdSelect.Append(" END ");

        StringBuilder _oHkidSelect = new StringBuilder();
        _oHkidSelect.Append(" 'rwl_hkid' = case ");
        _oHkidSelect.Append(" WHEN len(o.hkid)>=5 then SUBSTRING(o.hkid,0,5)+'****' ");
        _oHkidSelect.Append(" ELSE o.hkid ");
        _oHkidSelect.Append(" END ");


        StringBuilder _oAcceptSelect = new StringBuilder();
        _oAcceptSelect.Append(" 'rwl_accept' = case  ");
        _oAcceptSelect.Append(" WHEN o.accept='Y' then 'Accept Autoroll' ");
        _oAcceptSelect.Append(" WHEN o.accept='reject' then 'Reject Autoroll (change to FTG)' ");
        _oAcceptSelect.Append(" WHEN o.accept='no_comment' then 'No Comment' ");
        _oAcceptSelect.Append(" ELSE ''");
        _oAcceptSelect.Append("END");

        StringBuilder _oCardNoSelect = new StringBuilder();
        _oCardNoSelect.Append(" 'rwl_card_no' =  case ");
        _oCardNoSelect.Append(" WHEN (len(o.card_no)>=4 and len(o.card_no)<16) then SUBSTRING(o.card_no,0,5) ");
        _oCardNoSelect.Append(" WHEN len(o.card_no)>=16 then SUBSTRING(o.card_no,0,5)+'************' ");
        _oCardNoSelect.Append(" ELSE '' ");
        _oCardNoSelect.Append(" END ");

        StringBuilder _oCardExpYearSelect = new StringBuilder();
        _oCardExpYearSelect.Append(" 'rwl_card_exp_year' =  case ");
        _oCardExpYearSelect.Append(" WHEN len(o.card_exp_year)>=2 then SUBSTRING(o.card_no,0,3)+'**' ");
        _oCardExpYearSelect.Append(" ELSE '' ");
        _oCardExpYearSelect.Append(" END ");

        StringBuilder _oOrdPlaceHkid = new StringBuilder();
        _oOrdPlaceHkid.Append(" 'rwl_ord_place_hkid' = case ");
        _oOrdPlaceHkid.Append(" WHEN len(o.ord_place_hkid)>=4 then SUBSTRING(o.ord_place_hkid,0,5) +'****' ");
        _oOrdPlaceHkid.Append(" ELSE ''");
        _oOrdPlaceHkid.Append(" END ");

        StringBuilder _oMonthlyPaymentMethod = new StringBuilder();
        _oMonthlyPaymentMethod.Append(" 'rwl_monthly_payment_method' = case ");
        _oMonthlyPaymentMethod.Append(" WHEN o.monthly_payment_method='change_payment_method' then 'Change Payment Method' ");
        _oMonthlyPaymentMethod.Append(" ELSE 'Keep Existing Payment' ");
        _oMonthlyPaymentMethod.Append(" END ");

        StringBuilder _oCardExpYear = new StringBuilder();
        _oCardExpYear.Append(" 'rwl_m_card_exp_year' = case ");
        _oCardExpYear.Append(" WHEN len(o.m_card_exp_year)>=2 then SUBSTRING(o.m_card_exp_year,0,2) + '**' ");
        _oCardExpYear.Append(" ELSE '' ");
        _oCardExpYear.Append(" END ");


        StringBuilder _oPlanEff = new StringBuilder();
        _oPlanEff.Append(" 'rwl_plan_eff' = case ");
        _oPlanEff.Append(" WHEN o.plan_eff  = 'Next Bill Date'  AND (o.bill_cut_date IS NOT NULL AND o.bill_cut_date <>'' ) THEN convert(varchar(10),dateadd(d,1,o.bill_cut_date),101) ");
        _oPlanEff.Append(" WHEN o.plan_eff  = 'Next Bill Date'  AND (o.bill_cut_date IS NULL OR o.bill_cut_date='' ) THEN 'Next Bill Date' ");
        _oPlanEff.Append(" ELSE convert(varchar(10),o.plan_eff_date,101) ");
        _oPlanEff.Append(" END ");


        StringBuilder _oConEffDate = new StringBuilder();
        _oConEffDate.Append(" 'rwl_con_eff_date' = case ");
        _oConEffDate.Append(" WHEN o.next_bill = 1 AND ( o.bill_cut_date IS NOT NULL AND o.bill_cut_date<>'') THEN convert(varchar(10),o.bill_cut_date,101) ");
        _oConEffDate.Append(" WHEN o.next_bill = 1 AND ( o.bill_cut_date IS NULL OR o.bill_cut_date='')  THEN 'Next Bill Cut Date' ");
        _oConEffDate.Append(" ELSE convert(varchar(10),o.con_eff_date,101) ");
        _oConEffDate.Append(" END ");

        StringBuilder _oPcd_paid_go_wireless = new StringBuilder();
        _oPcd_paid_go_wireless.Append(" 'rwl_pcd_paid_go_wireless' = case ");
        _oPcd_paid_go_wireless.Append(" WHEN o.pcd_paid_go_wireless=1 THEN 'YES' ");
        _oPcd_paid_go_wireless.Append(" ELSE '' ");
        _oPcd_paid_go_wireless.Append(" END ");

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
                _oVasQuery.Append(" END FROM MobileOrderVas v  with (nolock)  LEFT JOIN BusinessVasDescription v2  with (nolock)  ON v.multi_id=v2.id WHERE v.vas_field='" + _sVas_Field + "' AND v.order_id=o.order_id ) ");
            }
        }

        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("SELECT CONVERT(VARCHAR,o.action_eff_date,101) AS 'suspend_date',  'rwl_d_date'=CONVERT(nvarchar(30),d_date,101), *,p.order_status order_status," + _oReportStatusSelect.ToString() + "," + _oActiveSelect.ToString() + "," + _oOldOrdIdSelect.ToString() + "," + _oHkidSelect.ToString() + "," + _oAcceptSelect.ToString() + "," + _oCardNoSelect.ToString() + "," + _oCardExpYearSelect.ToString() + "," + _oOrdPlaceHkid.ToString() + "," + _oOrdPlaceHkid.ToString() + "," + _oMonthlyPaymentMethod.ToString() + "," + _oCardExpYear.ToString() + "," + _oConEffDate.ToString() + "," + _oPcd_paid_go_wireless.ToString() + "," + _oPlanEff.ToString() + "," + _oVasQuery.ToString() + " FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder as o  with (nolock)  LEFT OUTER JOIN MobileOrderReport p  with (nolock)  on p.order_id=o.order_id where (o.active=1 or o.active=0)  ");

        StringBuilder _oFilter = new StringBuilder();
        if (WebFunc.qsOrder_status != string.Empty) { _oFilter.Append(" AND p.order_status='" + WebFunc.qsOrder_status + "' "); }


        if (WebFunc.qsOrder_id != null)
        {
            if ((Convert.ToInt32(WebFunc.qsOrder_id)) != -1 && !string.IsNullOrEmpty(Func.RQ(WebFunc.qsOrder_id)))
            {
                if (WebFunc.qsOrder_id2.Trim() != string.Empty)
                    _oFilter.Append(" AND o.order_id >=" + Func.IDSubtract100000((int)WebFunc.qsOrder_id) + "  ");
                else
                    _oFilter.Append(" AND o.order_id =" + Func.IDSubtract100000((int)WebFunc.qsOrder_id) + "  ");
            }
        }

        if (!string.IsNullOrEmpty(WebFunc.qsOrder_id2) && !string.IsNullOrEmpty(Func.RQ(WebFunc.qsOrder_id2)))
            _oFilter.Append(" AND o.order_id <=" + Func.IDSubtract100000(Convert.ToInt32(WebFunc.qsOrder_id2)));

        if (!string.IsNullOrEmpty(WebFunc.qsEdf_no))
            _oFilter.Append(" AND o.edf_no ='" + WebFunc.qsEdf_no + "'");

        if (!string.IsNullOrEmpty(WebFunc.qsIssue_type))
            _oFilter.Append(" AND o.issue_type ='" + WebFunc.qsIssue_type + "'  ");

        if (!string.IsNullOrEmpty(WebFunc.qsCust_type))
            _oFilter.Append(" AND o.cust_type ='" + WebFunc.qsCust_type + "'  ");

        if (!string.IsNullOrEmpty(WebFunc.qsCust_name))
            _oFilter.Append(" AND o.cust_name ='" + WebFunc.qsCust_name + "' ");

        if (!string.IsNullOrEmpty(WebFunc.qsBill_medium_email))
            _oFilter.Append(" AND o.bill_medium_email ='" + WebFunc.qsBill_medium_email + "' ");

        if (!string.IsNullOrEmpty(WebFunc.qsOrder_status))
            _oFilter.Append(" AND order_status='" + WebFunc.qsOrder_status + "' ");

        if (!string.IsNullOrEmpty(WebFunc.qsTeamcode))
            _oFilter.Append(" AND o.teamcode ='" + WebFunc.qsTeamcode + "'  ");

        if (!string.IsNullOrEmpty(WebFunc.qsSalesman_code))
            _oFilter.Append(" AND o.salesman_code='" + WebFunc.qsSalesman_code + "'");

        if (!string.IsNullOrEmpty(WebFunc.qsHs_model))
            _oFilter.Append(" AND o.hs_model='" + WebFunc.qsHs_model + "' ");

        if (!string.IsNullOrEmpty(WebFunc.qsSku))
            _oFilter.Append(" AND o.sku='" + WebFunc.qsSku+"' ");

        if ("Y".Equals(WebFunc.qsHs))
            _oFilter.Append(" AND (o.hs_model is not null and o.hs_model<>'')");
        else if ("N".Equals(WebFunc.qsHs))
            _oFilter.Append(" AND (o.hs_model is null or o.hs_model='')");

        if ("Y".Equals(WebFunc.qsPremium))
            _oFilter.Append(" AND (o.premium is not null and o.premium<>'')");
        else if ("N".Equals(WebFunc.qsPremium))
            _oFilter.Append(" and (o.premium is null or o.premium='')");

        if ("Y".Equals(WebFunc.qsSpecial_approval))
            _oFilter.Append(" AND (o.special_approval ='Y')");
        else if ("N".Equals(WebFunc.qsSpecial_approval))
            _oFilter.Append(" AND (o.special_approval ='N')");

        if (!string.IsNullOrEmpty(WebFunc.qsStaff_no.Trim()))
            _oFilter.Append(" AND o.staff_no='" + WebFunc.qsStaff_no + "'");

        if ("ALL".Equals(WebFunc.qsS_premium1))
            _oQuery.Append(" AND (o.s_premium1 <> null or o.s_premium1<>'')");
        else if (!"ALL".Equals(WebFunc.qsS_premium1) && !string.IsNullOrEmpty(WebFunc.qsS_premium1))
            _oFilter.Append(" AND o.s_premium1='" + WebFunc.qsS_premium1+ "'");

        if ("ALL".Equals(WebFunc.qsS_premium2))
            _oQuery.Append(" AND (o.s_premium2 <> null or o.s_premium2<>'')");
        else if (!"ALL".Equals(WebFunc.qsS_premium2) && !string.IsNullOrEmpty(WebFunc.qsS_premium2))
            _oFilter.Append(" AND o.s_premium2='" + WebFunc.qsS_premium2 + "'");

        if (!string.IsNullOrEmpty(WebFunc.qsAc_no))
            _oFilter.Append(" AND o.ac_no='" + WebFunc.qsAc_no + "'");

        if (!string.IsNullOrEmpty(WebFunc.qsChannel))
            _oFilter.Append(" AND o.channel='" + WebFunc.qsChannel + "'");

        if ("suspend".Equals(WebFunc.qsAction_required))
            _oFilter.Append(" AND o.action_required='" + WebFunc.qsAction_required + "'");

        else if ("opt_out".Equals(WebFunc.qsAction_required2))
            _oFilter.Append(" AND o.action_required='" + WebFunc.qsAction_required2 + "'");

        if (!string.IsNullOrEmpty(WebFunc.qsOrg_ftg))
            _oFilter.Append(" AND o.org_ftg='" + WebFunc.qsOrg_ftg + "'");

        if (!string.IsNullOrEmpty(WebFunc.qsOb_program_id))
            _oFilter.Append(" AND o.ob_program_id='" + WebFunc.qsOb_program_id + "'");

        if (!string.IsNullOrEmpty(WebFunc.qsOrg_fee))
            _oFilter.Append(" AND o.org_fee ='" + WebFunc.qsOrg_fee + "'");

        if (!string.IsNullOrEmpty(WebFunc.qsExisting_contract_end_month) || !string.IsNullOrEmpty(WebFunc.qsExisting_contract_end_year))
            _oFilter.Append(" AND o.existing_contract_end_date='" + (WebFunc.qsExisting_contract_end_month + "/" + WebFunc.qsExisting_contract_end_year) + "'");

        if (!string.IsNullOrEmpty(WebFunc.qsExist_cust_plan))
            _oFilter.Append(" AND o.exist_cust_plan='" + WebFunc.qsExist_cust_plan + "'");

        if (!string.IsNullOrEmpty(WebFunc.qsMrt_no))
            _oFilter.Append(" AND o.mrt_no='" + WebFunc.qsMrt_no + "'");

        if (!string.IsNullOrEmpty(WebFunc.qsContact_no))
            _oFilter.Append(" AND o.contact_no='" + WebFunc.qsContact_no + "'");

        if (!string.IsNullOrEmpty(WebFunc.qsHkid) && !string.IsNullOrEmpty(WebFunc.qsHkid2))
            _oFilter.Append(" AND o.hkid='" + (WebFunc.qsHkid + WebFunc.qsHkid2) + "'");

        if (!string.IsNullOrEmpty(WebFunc.qsProgram))
            _oFilter.Append(" AND o.program='" + WebFunc.qsProgram + "'");

        if (!string.IsNullOrEmpty(WebFunc.qsRate_plan))
            _oFilter.Append(" AND o.rate_plan='" + WebFunc.qsRate_plan + "'");

        if (!string.IsNullOrEmpty(WebFunc.qsCon_per))
            _oFilter.Append(" AND o.con_per='" + WebFunc.qsCon_per + "'");

        if (!string.IsNullOrEmpty(WebFunc.qsFree_mon))
            _oFilter.Append(" AND o.free_mon='" + WebFunc.qsFree_mon + "'");

        if (!string.IsNullOrEmpty(WebFunc.qsCooling_offer))
            _oFilter.Append(" AND o.cooling_offer='" + WebFunc.qsCooling_offer + "'");

        if (Request[WebFunc.qsLog_dateName] != null)
        {
            DateTime _oDate;
            if (DateTime.TryParseExact(Func.RQ(Request[WebFunc.qsLog_dateName]), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _oDate))
            {
                _oFilter.Append(" AND o.log_date>='" + _oDate.ToString("dd/MM/yyyy 00:00") + "'");
            }
        }

        if (Request[WebFunc.qsLog_date2Name] != null)
        {
            DateTime _oDate;
            if (DateTime.TryParseExact(Func.RQ(Request[WebFunc.qsLog_date2Name]), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _oDate))
            {
                _oFilter.Append(" AND o.log_date<='" + _oDate.ToString("dd/MM/yyyy 23:59") + " '");
            }
        }

        if (Request[WebFunc.qsD_dateName] != null)
        {
            DateTime _oDate;
            if (DateTime.TryParseExact(Func.RQ(Request[WebFunc.qsD_dateName]), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _oDate))
            {
                _oFilter.Append(" AND o.d_date>='" + _oDate.ToString("dd/MM/yyyy 00:00") + " '");
            }
        }

        if (Request[WebFunc.qsD_date2Name] != null)
        {
            DateTime _oDate;
            if (DateTime.TryParseExact(Func.RQ(Request[WebFunc.qsD_date2Name]), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _oDate))
            {
                _oFilter.Append(" AND o.d_date<='" + _oDate.ToString("dd/MM/yyyy 23:59") + "'");
            }
        }

        if (Request["pcd_paid_go_wireless"] != null)
        {
            string _sPcd_paid_go_wireless = (Request["pcd_paid_go_wireless"] != null) ? Request["pcd_paid_go_wireless"].ToString().Trim() : string.Empty;
            bool _bPcd_paid_go_wireless = (_sPcd_paid_go_wireless == "on" || _sPcd_paid_go_wireless == "1") ? true : false;
            if (_bPcd_paid_go_wireless)
                _oFilter.Append(" AND pcd_paid_go_wireless=1 ");
            else if (Request["pcd_paid_go_wireless"] != null)
                _oFilter.Append(" AND (pcd_paid_go_wireless=0 or pcd_paid_go_wireless is null) ");
        }

        if (Request[WebFunc.qsVas_eff_dateName] != null)
        {
            DateTime _oDate;
            if (DateTime.TryParseExact(Func.RQ(Request[WebFunc.qsVas_eff_dateName]), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _oDate))
            {
                _oFilter.Append(" AND o.vas_eff_date>='" + _oDate.ToString("dd/MM/yyyy") + " 00:00'");
            }
        }

        if (Request[WebFunc.qsVas_eff_date2Name] != null)
        {
            DateTime _oDate;
            if (DateTime.TryParseExact(Func.RQ(Request[WebFunc.qsVas_eff_date2Name]), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _oDate))
            {
                _oFilter.Append(" AND o.vas_eff_date<='" + _oDate.ToString("dd/MM/yyyy") + " 23:59'");
            }
        }

        if (Request[WebFunc.qsPlan_eff_dateName] != null)
        {
            DateTime _oDate;
            if (DateTime.TryParseExact(Func.RQ(Request[WebFunc.qsPlan_eff_dateName]), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _oDate))
            {
                _oFilter.Append(" AND o.plan_eff_date>='" + _oDate.ToString("dd/MM/yyyy 00:00") + "'");
            }
        }

        if (Request[WebFunc.qsPlan_eff_date2Name] != null)
        {
            DateTime _oDate;
            if (DateTime.TryParseExact(Func.RQ(Request[WebFunc.qsPlan_eff_date2Name]), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _oDate))
            {
                _oFilter.Append(" AND o.plan_eff_date<='" + _oDate.ToString("dd/MM/yyyy 23:59") + "'");
            }
        }

        if (Request[WebFunc.qsCon_eff_dateName] != null)
        {
            DateTime _oDate;
            if (DateTime.TryParseExact(Func.RQ(Request[WebFunc.qsCon_eff_dateName]), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _oDate))
            {
                _oFilter.Append(" AND o.con_eff_date>='" + _oDate.ToString("dd/MM/yyyy 00:00") + "'");
            }
        }

        if (Request[WebFunc.qsCon_eff_date2Name] != null)
        {
            DateTime _oDate;
            if (DateTime.TryParseExact(Func.RQ(Request[WebFunc.qsCon_eff_date2Name]), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _oDate))
            {
                _oFilter.Append(" AND o.con_eff_date<='" + _oDate.ToString("dd/MM/yyyy 23:59") + "'");
            }
        }

        if (Request[WebFunc.qsAction_eff_dateName] != null)
        {
            DateTime _oDate;
            if (DateTime.TryParseExact(Func.RQ(Request[WebFunc.qsAction_eff_dateName]), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _oDate))
            {
                _oFilter.Append(" AND o.action_eff_date>='" + _oDate.ToString("dd/MM/yyyy 00:00") + "'");
            }
        }

        if (Request[WebFunc.qsAction_eff_date2Name] != null)
        {
            DateTime _oDate;
            if (DateTime.TryParseExact(Func.RQ(Request[WebFunc.qsAction_eff_date2Name]), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _oDate))
            {
                _oFilter.Append(" AND o.action_eff_date<='" + _oDate.ToString("dd/MM/yyyy 23:59") + "'");
            }
        }

        if (Request[WebFunc.qsMin_vasName] != null)
        {
            if (WebFunc.qsMin_vas.Trim() != string.Empty)
                _oFilter.Append(" AND (o.order_id in (SELECT top 1 order_id FROM " + Configurator.MSSQLTablePrefix + "MobileOrderVas a1 WHERE a1.order_id=o.order_id and 'N'<>'" + Func.Left(WebFunc.qsMin_vas.Trim(), 1) + "'))");
        }
        if (Request[WebFunc.qsNow_vasName] != null)
        {
            if (WebFunc.qsNow_vas.Trim() != string.Empty)
                _oFilter.Append(" AND (o.order_id in (SELECT top 1 order_id FROM " + Configurator.MSSQLTablePrefix + "MobileOrderVas a2 WHERE a2.order_id=o.order_id and a2.vas_field='now_vas' and a2.vas_value='" + WebFunc.qsNow_vas + "'))");
        }
        if (Request[WebFunc.qsFoot_vasName] != null)
        {
            if (WebFunc.qsFoot_vas.Trim() != string.Empty)
                _oFilter.Append(" AND (o.order_id in (SELECT top 1 order_id FROM " + Configurator.MSSQLTablePrefix + "MobileOrderVas a3 WHERE a3.order_id=o.order_id and a3.vas_field='foot_vas' and a3.vas_value='" + WebFunc.qsFoot_vas + "'))");
        }
        if (Request[WebFunc.qsHorse_vasName] != null)
        {
            if (WebFunc.qsHorse_vas.Trim() != string.Empty)
                _oFilter.Append(" AND (o.order_id in (SELECT top 1 order_id FROM " + Configurator.MSSQLTablePrefix + "MobileOrderVas a4 WHERE a4.order_id=o.order_id and a4.vas_field='horse_vas' and a4.vas_value='" + WebFunc.qsHorse_vas + "'))");
        }
        if (Request[WebFunc.qsMoov_vasName] != null)
        {
            if (WebFunc.qsMoov_vas.Trim() != string.Empty)
                _oFilter.Append(" AND (o.order_id in (SELECT top 1 order_id FROM " + Configurator.MSSQLTablePrefix + "MobileOrderVas a5 WHERE a5.order_id=o.order_id and a5.vas_field='moov_vas' and a5.vas_value='" + WebFunc.qsMoov_vas + "'))");
        }
        if (Request[WebFunc.qsGprs_vasName] != null)
        {
            if (WebFunc.qsGprs_vas.Trim() != string.Empty)
                _oFilter.Append(" AND (o.order_id in (SELECT top 1 order_id FROM " + Configurator.MSSQLTablePrefix + "MobileOrderVas a6 WHERE a6.order_id=o.order_id and a6.vas_field='gprs_vas' and a6.vas_value like '" + WebFunc.qsGprs_vas + "'))");
        }
        if (Request[WebFunc.qsGprs_vas2Name] != null)
        {
            if (WebFunc.qsGprs_vas2.Trim() != string.Empty && n_oGprs_vas_desc.ContainsValue(WebFunc.qsGprs_vas2.Trim()))
                _oFilter.Append(" AND (o.order_id in (SELECT top 1 order_id FROM " + Configurator.MSSQLTablePrefix + "MobileOrderVas a7 WHERE a7.order_id=o.order_id and a7.vas_field='gprs_vas' and a7.fee like '" + WebFunc.qsGprs_vas2 + "'))");
        }
        if (Request[WebFunc.qsWifi_vasName] != null)
        {
            if (WebFunc.qsWifi_vas.Trim() != string.Empty)
                _oFilter.Append(" AND (o.order_id in (SELECT top 1 order_id FROM " + Configurator.MSSQLTablePrefix + "MobileOrderVas a8 WHERE a8.order_id=o.order_id and a8.vas_field='wifi_vas' and a8.vas_value = '" + WebFunc.qsWifi_vas + "'))");
        }
        if (Request[WebFunc.qsSms_vasName] != null)
        {
            if (WebFunc.qsSms_vas.Trim() != string.Empty)
                _oFilter.Append(" AND (o.order_id in (SELECT top 1 order_id FROM " + Configurator.MSSQLTablePrefix + "MobileOrderVas a9 WHERE a9.order_id=o.order_id and a9.vas_field='sms_vas' and a9.vas_value like '" + WebFunc.qsSms_vas + "'))");
        }
        if (Request[WebFunc.qsSms_vas2Name] != null)
        {
            if (WebFunc.qsSms_vas2.Trim() != string.Empty && n_oSms_vas_desc.ContainsValue(WebFunc.qsSms_vas2.Trim()))
                _oFilter.Append(" AND (o.order_id in (SELECT top 1 order_id FROM " + Configurator.MSSQLTablePrefix + "MobileOrderVas a10 WHERE a10.order_id=o.order_id and a10.vas_field='sms_vas' and a10.fee like '" + WebFunc.qsSms_vas2 + "'))");
        }
        if (Request[WebFunc.qsMsn_vasName] != null)
        {
            if (WebFunc.qsMsn_vas.Trim() != string.Empty)
                _oFilter.Append(" AND (o.order_id in (SELECT top 1 order_id FROM " + Configurator.MSSQLTablePrefix + "MobileOrderVas a11 WHERE a11.order_id=o.order_id and a11.vas_field='msn_vas' and a11.vas_value = '" + WebFunc.qsMsn_vas + "'))");
        }
        if (Request[WebFunc.qsCt_vasName] != null)
        {
            if (WebFunc.qsCt_vas.Trim() != string.Empty)
                _oFilter.Append(" AND (o.order_id in (SELECT top 1 order_id FROM " + Configurator.MSSQLTablePrefix + "MobileOrderVas a12 WHERE a12.order_id=o.order_id and a12.vas_field='ct_vas' and a12.vas_value = '" + WebFunc.qsCt_vas + "'))");
        }

        if (!string.IsNullOrEmpty(WebFunc.qsPay_method))
        {
            _oFilter.Append(" AND o.pay_method ='" + WebFunc.qsPay_method + "' ");
        }

        if (!string.IsNullOrEmpty(WebFunc.qsMonthly_payment_method))
        {
            _oFilter.Append(" AND o.monthly_payment_method ='" + WebFunc.qsMonthly_payment_method + "' ");
        }

        if (_oFilter.ToString().Trim().Equals(string.Empty))
            _oFilter.Append(" AND o.order_id=-1 ");

        _oFilter.Append(" ORDER BY o.order_id");
        if (!_oFilter.ToString().Equals(string.Empty))
        {
            int _iViewId = 1;

            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString() + _oFilter.ToString());
            while (_oDr.Read())
            {
                StringBuilder _oReportWrite = new StringBuilder();
                _oReportWrite.Append("<tr>");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + _iViewId.ToString() + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\"><a href=\"SearchRetentionOrderViewDetail.aspx?order_id=" + Func.IDAdd100000(Convert.ToInt32(Func.FR(_oDr["order_id"]))) + "\">" + Func.IDAdd100000(Convert.ToInt32(Func.FR(_oDr["order_id"]))) + "</a></span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["rwl_active"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\"><a href=\"#\" onclick='window.open(\"AdminViewHistoryImplement.aspx?order_id=" + Func.FR(_oDr["order_id"]) + "\",\"_blank\",\"toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=yes, copyhistory=no, width=600, height=300\")'>" + Func.FR(_oDr["report_status"]) + "</a></span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["edf_no"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["rwl_old_ord_id"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["log_date"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["family_name"]) +" "+Func.FR(_oDr["given_name"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["cust_type"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["ac_no"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["issue_type"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["mrt_no"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["rwl_hkid"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["vip_case"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["exist_cust_plan"]) + " " + Func.FR(_oDr["org_ftg"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["org_fee"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["rwl_accept"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["rwl_pcd_paid_go_wireless"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["program"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["rate_plan"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["normal_rebate_type"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["lob"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["lob_ac"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["con_per"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["trade_field"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["bundle_name"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["rebate"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["m_rebate_amount"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["rebate_amount"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["r_offer"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["extra_rebate"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["extra_rebate_amount"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["free_mon"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["cancel_renew"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["gift_code"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["gift_imei"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["gift_desc"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["gift_code2"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["gift_imei2"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["gift_desc2"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["gift_code3"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["gift_imei3"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["gift_desc3"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["gift_code4"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["gift_imei4"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["gift_desc4"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["accessory_code"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["accessory_imei"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["accessory_desc"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["accessory_price"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["aig_gift"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["special_approval"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["fast_start"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["vas_eff_date"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["rwl_plan_eff"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["rwl_con_eff_date"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["bill_cut_num"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["pos_ref_no"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["hs_model"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["sku"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["imei_no"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["premium"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["s_premium"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["sp_d_date"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["sp_ref_no"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["s_premium1"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["s_premium2"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["s_premium3"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["s_premium4"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["d_address"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["rwl_d_date"]) + " " + Func.FR(_oDr["d_time"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["extra_d_charge"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["contact_person"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["contact_no"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["pay_method"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["card_type"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["rwl_card_no"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["card_holder"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["card_exp_month"]) + "/" + Func.FR(_oDr["rwl_card_exp_year"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["bank_code"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["bank_name"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["amount"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["remarks"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["remarks2EDF"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["remarks2PY"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["action_required"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + ((Func.FR(_oDr["waive"]).Trim() != string.Empty) ? (((Func.FR(_oDr["waive"]).Trim().ToLower() == "true") ? "Y" : "N")) : string.Empty) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["suspend_date"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["exist_plan"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["reasons"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["staff_no"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["staff_name"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["teamcode"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["tl_name"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["salesmancode"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["ref_staff_no"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["ref_salesmancode"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["channel"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["ob_program_id"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["existing_contract_end_date"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["ord_place_by"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["ord_place_rel"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["ord_place_id_type"]) + " " + Func.FR(_oDr["ord_place_hkid"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["ord_place_tel"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["ext_place_tel"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["monthly_payment_type"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["m_card_type"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["m_card_no"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["m_card_holder2"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["m_card_exp_month"]) + "/" + Func.FR(_oDr["rwl_m_card_exp_year"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["sim_item_name"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["sim_item_code"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["redemption_notice_option"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["bill_medium_email"]) + "</span></td>\n");
                _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["accessory_waive"]) + "</span></td>\n");
				foreach (KeyValuePair<string, string> _oItem in n_oVasNameData)
                {
                    string _sVas_Field = _oItem.Key.ToString();
                    string _sVas_Name = _oItem.Value.ToString();
                    if (!_sVas_Name.Trim().Equals(string.Empty))
                        _oReportWrite.Append("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr[_sVas_Field]) + "</span></td>\n");
                }

                _oReportWrite.Append("</tr>");
                Response.Write(_oReportWrite.ToString());
                _iViewId += 1;

            }

            _oDr.Close();
            _oDr.Dispose();


        }
        HideLoading();
    }
    #endregion


    public void HideLoading()
    {

        RunJavascriptFunc("HideLoading()");
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
        if (!string.IsNullOrEmpty(x_sFee))
        {
            if (x_sFee.IndexOf(",") > -1)
            {
                string[] _oVal = x_sFee.Split((",")[0]);
                _sResult = _oVal[0];
                if (_oVal.Length > 1)
                {
                    if (!string.IsNullOrEmpty(_oVal[1]))
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



    protected int CompareDate(Nullable<DateTime> x_dT1, Nullable<DateTime> x_dT2)
    {
        if (x_dT1 == null) return -2;
        if (x_dT2 == null) return -3;
        return DateTime.Compare(Convert.ToDateTime(x_dT1),Convert.ToDateTime(x_dT2));
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
        _oDB.SetConnStr(Configurator.DBName.ORADNS + ((Configurator.IsUat()) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion

    public string Attributes()
    {
        return "<tr style=\"cursor:hand\" onmouseover=\"style.backgroundColor=\'LightBlue\'\" onmouseout=\"style.backgroundColor\'\'\">";
    }

    #region Set HtmlControl Style By Javascript
    public void SetHtmlControlStyle(string x_sID, HtmlTextWriterStyle x_oStyle, string x_sValue, bool x_bStr)
    {
        Random ran = new Random();
        string _sScript = string.Empty;
        if (x_bStr)
            _sScript = string.Format("<script>if(document.getElementById('{0}')!=undefined) document.getElementById('{1}').style.{2}='{3}'; </script>", x_sID, x_sID, x_oStyle.ToString().ToLower(), x_sValue);
        else
            _sScript = string.Format("<script>if(document.getElementById('{0}')!=undefined) document.getElementById('{1}').style.{2}={3}; </script>", x_sID, x_sID, x_oStyle.ToString().ToLower(), x_sValue);
        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), _sScript, false);
    }
    #endregion

    #region Set HtmlContorl Attributes By Javascript
    public void SetHtmlControlAtt(string x_sID, HtmlTextWriterAttribute x_oAtt, string x_sValue, bool x_bStr)
    {
        string _sScript = string.Empty;
        if (x_oAtt == HtmlTextWriterAttribute.Class)
            _sScript = string.Format("<script>if(document.getElementById('{0}')!=undefined) document.getElementById('{1}').className='{2}';</script>", x_sID, x_sID, x_sValue);
        else
        {
            if (x_bStr)
                _sScript = string.Format("<script>if(document.getElementById('{0}')!=undefined) document.getElementById('{1}').{2}='{3}';</script>", x_sID, x_sID, x_oAtt.ToString().ToLower(), x_sValue);
            else
                _sScript = string.Format("<script>if(document.getElementById('{0}')!=undefined) document.getElementById('{1}').{2}={3};</script>", x_sID, x_sID, x_oAtt.ToString().ToLower(), x_sValue);
        }
        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), _sScript, false);
    }
    #endregion

    #region Set HtmlContorl Value By Javascript
    public void SetHtmlControlValue(string x_sID, string x_sValue, bool x_bStr)
    {
        string _sScript = string.Empty;
        if (x_bStr)
            _sScript = string.Format("<script>if(document.getElementById('{0}')!=undefined) document.getElementById('{1}').value='{2}';</script>", x_sID, x_sID, x_sValue);
        else
            _sScript = string.Format("<script>if(document.getElementById('{0}')!=undefined) document.getElementById('{1}').value={2};</script>", x_sID, x_sID, x_sValue);
        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), _sScript, false);
    }
    #endregion

    #region Run Javascript Function
    public void RunJavascriptFunc(string x_sFunc)
    {
        string _sFunc = ((x_sFunc.IndexOf(';') > 0) ? x_sFunc : x_sFunc + ";");
        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sFunc + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), string.Format("<script>{0}</script>", _sFunc), false);
    }
    #endregion
}
