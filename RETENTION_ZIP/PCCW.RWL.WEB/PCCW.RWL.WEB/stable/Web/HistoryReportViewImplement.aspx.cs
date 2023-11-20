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

public partial class HistoryReportViewImplement : NEURON.WEB.UI.BasePage
{
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion
    MSSQLConnect n_oDB = new MSSQLConnect();

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
    string _sCurrentQuery = string.Empty;
    string _sHisQuery = string.Empty;
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
        InitFrame();
    }

    protected void InitFrame()
    {

        StringBuilder _oAccept = new StringBuilder();
        _oAccept.Append(" 'rwl_accept' = case ");
        _oAccept.Append(" WHEN a.accept ='Y' AND (a.accept IS NOT NULL AND a.accept<>'') THEN 'Accept Autoroll' ");
        _oAccept.Append(" WHEN a.accept ='reject' AND (a.accept IS NOT NULL AND a.accept<>'') THEN 'Reject Autoroll (change to FTG)' ");
        _oAccept.Append(" WHEN a.accept = 'No Comment' AND (a.accept IS NOT NULL AND a.accept<>'') THEN 'No Comment' ");
        _oAccept.Append(" ELSE '' ");
        _oAccept.Append(" END ");

        StringBuilder _oVasHeader = new StringBuilder();
        StringBuilder _oVasQuery = new StringBuilder();
        StringBuilder _oVasQuery2 = new StringBuilder();
        foreach (KeyValuePair<string, string> _oItem in n_oVasNameData)
        {
            if (_oVasQuery.ToString() != string.Empty) { _oVasQuery.Append(","); }
            if (_oVasQuery2.ToString() != string.Empty) { _oVasQuery2.Append(","); }
            string _sVas_Field = _oItem.Key.ToString();
            string _sVas_Name = _oItem.Value.ToString();
            if (!_sVas_Name.Trim().Equals(string.Empty))
            {
                _oVasQuery.Append("'" + _sVas_Field + "'=");
                _oVasQuery.Append(" (SELECT TOP 1 '" + _sVas_Field + "'= CASE ");
                _oVasQuery.Append(" WHEN v.vas_value is not null AND v.fee is not null AND v.fee<>'' AND v2.vas_desc is not null AND v2.fee<>'' THEN v.vas_value +','+v2.vas_desc ");
                _oVasQuery.Append(" WHEN v.vas_value is not null THEN v.vas_value ");
                _oVasQuery.Append(" ELSE '' ");
                _oVasQuery.Append(" END FROM MobileOrderVas v with (nolock)  LEFT JOIN BusinessVasDescription v2 with (nolock) ON (v.multi_id=v2.id AND v.multi_id IS NOT NULL AND v.multi_id!='') WHERE v.vas_field='" + _sVas_Field + "' AND v.order_id=a.order_id ) ");


                _oVasQuery2.Append("'" + _sVas_Field + "'=");
                _oVasQuery2.Append(" (SELECT TOP 1 '" + _sVas_Field + "'= CASE ");
                _oVasQuery2.Append(" WHEN v.vas_value is not null AND v.fee is not null AND v.fee<>'' AND v2.vas_desc is not null AND v2.fee<>'' THEN v.vas_value +','+v2.vas_desc ");
                _oVasQuery2.Append(" WHEN v.vas_value is not null THEN v.vas_value ");
                _oVasQuery2.Append(" ELSE '' ");
                _oVasQuery2.Append(" END FROM MobileOrderVasRevision v with (nolock)  LEFT JOIN BusinessVasDescription v2 with (nolock) ON (v.multi_id=v2.id AND v.multi_id IS NOT NULL AND v.multi_id!='') WHERE v.vas_field='" + _sVas_Field + "' AND v.his_order_id=a.order_id ) ");
            }
        }

        _sCurrentQuery = "SELECT  CONVERT(VARCHAR, a.date_of_birth,101) AS 'rwl_date_of_birth', CONVERT(VARCHAR, a.plan_eff_date,101) AS 'rwl_plan_eff_date', CONVERT(VARCHAR, a.con_eff_date,101) AS 'rwl_con_eff_date', CONVERT(VARCHAR, a.d_date,101) AS 'delivery_date' , CONVERT(VARCHAR,a.action_eff_date,101) AS 'suspend_date'  ,*," + _oAccept.ToString() + "," + _oVasQuery.ToString() + " FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder a WITH (nolock) WHERE a.order_id='" + Func.RQ(WebFunc.qsOrder_id) + "' order by a.ddate desc";
        _sHisQuery = "SELECT  CONVERT(VARCHAR, a.date_of_birth,101) AS 'rwl_date_of_birth', CONVERT(VARCHAR, a.plan_eff_date,101) AS 'rwl_plan_eff_date', CONVERT(VARCHAR, a.con_eff_date,101) AS 'rwl_con_eff_date', CONVERT(VARCHAR, a.d_date,101) AS 'delivery_date' , CONVERT(VARCHAR,a.action_eff_date,101) AS 'suspend_date'  ,*," + _oAccept.ToString() + "," + _oVasQuery2.ToString() + "FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionPreviousOrder a WITH (nolock) WHERE a.rec_no='" + Func.RQ(WebFunc.qsOrder_id) + "' order by a.ddate desc";

    }

    public void SearchReportShow1()
    {
        if (_sCurrentQuery != string.Empty)
        {
            int _iViewid = 0;
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sCurrentQuery);
            while (_oDr.Read())
            {
                _iViewid += 1;
                StringBuilder _oReportWrite = new StringBuilder();
                _oReportWrite.AppendLine("<tr>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + _iViewid.ToString() + "</span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["cdate"]).Trim()+"</span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["cid"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["ddate"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["did"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["edf_no"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["old_ord_id"]).Trim()+"</span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["log_date"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["family_name"]) +" "+Func.FR(_oDr["given_name"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["cust_type"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["ac_no"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["issue_type"]).Trim() + "</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["mrt_no"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["hkid"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["vip_case"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["exist_cust_plan"]).Trim()+"</span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" +Func.FR(_oDr["org_ftg"]).Trim() + "</span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["org_fee"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["rwl_accept"]).Trim()+"</span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["program"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["rate_plan"]).Trim()+" - "+Func.FR(_oDr["normal_rebate_type"]).Trim()+"</span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["lob"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["lob_ac"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["con_per"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["trade_field"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["bundle_name"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["rebate"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["m_rebate_amount"]).Trim()+"</span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["rebate_amount"]).Trim()+"</span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["r_offer"]).Trim()+"</span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["extra_rebate"]).Trim()+"</span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["extra_rebate_amount"]).Trim()+"</span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["free_mon"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["cancel_renew"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["gift_code"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["gift_imei"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["gift_desc"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["gift_code2"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["gift_imei2"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["gift_desc2"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["gift_code3"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["gift_imei3"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["gift_desc3"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["gift_code4"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["gift_imei4"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["gift_desc4"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["accessory_code"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["accessory_imei"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["accessory_desc"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["accessory_price"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:9px\">"+Func.FR(_oDr["aig_gift"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["special_approval"]).Trim()+"</span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["fast_start"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\"> "+Func.FR(_oDr["vas_eff_date"]).Trim()+"</span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["plan_eff"]).Trim()+" "+Func.FR(_oDr["rwl_plan_eff_date"]).Trim()+"</span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["rwl_con_eff_date"]).Trim()+"</span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["pos_ref_no"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["hs_model"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["sku"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["imei_no"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["premium"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["s_premium"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["s_premium1"]).Trim() + "</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["s_premium2"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["s_premium3"]).Trim() + "</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["s_premium4"]).Trim() + "</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["sp_d_date"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["sp_ref_no"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["d_address"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\"> " + Func.FR(_oDr["delivery_date"]).Trim() + " " + Func.FR(_oDr["d_time"]).Trim() + " </span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">$"+Func.FR(_oDr["extra_d_charge"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["contact_person"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["contact_no"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["ext_place_tel"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["pay_method"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["card_type"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["card_no"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["card_holder"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["card_exp_month"]).Trim()+"<span class=\"gensmall\" >  / </span><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["card_exp_year"]).Trim()+"<span class=\"gensmall\" ></span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["bank_code"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["bank_name"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">$"+Func.FR(_oDr["amount"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["remarks"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["action_required"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["waive"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["suspend_date"]).Trim() + " </span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["exist_plan"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["reasons"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["staff_no"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["staff_name"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["teamcode"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["tl_name"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["salesmancode"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["channel"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["ref_staff_no"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["ref_salesmancode"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["ord_place_by"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["ord_place_rel"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["ord_place_id_type"]).Trim()+"&nbsp;"+Func.FR(_oDr["ord_place_hkid"]).Trim()+"</span> </td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["ord_place_tel"]).Trim()+" </td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["monthly_payment_type"]).Trim()+"</span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["m_card_type"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["m_card_no"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["m_card_holder2"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["m_card_exp_month"]).Trim()+"<span class=\"gensmall\" >  / </span><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["m_card_exp_year"]).Trim()+"<span class=\"gensmall\" ></span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["ob_program_id"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["bill_cut_num"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["change_payment_type"]).Trim() + "</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["gender"]).Trim() + "</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["rwl_date_of_birth"]).Trim() + "</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["redemption_notice_option"]).Trim() + "</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["bill_medium_email"]).Trim() + "</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["accessory_waive"]).Trim() + "</td>");
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
            _oDr.Close();
            _oDr.Dispose();
        }
    }

    public void SearchReportShow2()
    {
        if (_sHisQuery != string.Empty)
        {
            int _iViewid = 0;
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sHisQuery);
            while (_oDr.Read())
            {
                _iViewid += 1;
                StringBuilder _oReportWrite = new StringBuilder();
                _oReportWrite.AppendLine("<tr>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+_iViewid.ToString()+"</span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["cdate"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["cid"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["ddate"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["did"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["edf_no"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["old_ord_id"]).Trim()+"</span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["log_date"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["family_name"]) +" "+Func.FR(_oDr["given_name"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["cust_type"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["ac_no"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["issue_type"]).Trim() + "</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["mrt_no"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["hkid"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["vip_case"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["exist_cust_plan"]).Trim()+"</span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["org_ftg"]).Trim() + "</span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["org_fee"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["accept"]).Trim()+"</span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["program"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["rate_plan"]).Trim()+"- "+Func.FR(_oDr["normal_rebate_type"]).Trim()+"</span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["lob"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["lob_ac"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["con_per"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["trade_field"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["bundle_name"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["rebate"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["m_rebate_amount"]).Trim()+"</span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["rebate_amount"]).Trim()+"</span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["r_offer"]).Trim()+"</span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\"> </span><span class=\"gensmall\" style=\"font-size:9px\">"+Func.FR(_oDr["extra_rebate"]).Trim()+"</span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["extra_rebate_amount"]).Trim()+"</span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["free_mon"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["cancel_renew"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["gift_code"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["gift_imei"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["gift_desc"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["gift_code2"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["gift_imei2"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["gift_desc2"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["gift_code3"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["gift_imei3"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["gift_desc3"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["gift_code4"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["gift_imei4"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["gift_desc4"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["accessory_code"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["accessory_imei"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["accessory_desc"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["accessory_price"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:9px\">"+Func.FR(_oDr["aig_gift"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["special_approval"]).Trim()+"</span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["fast_start"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["vas_eff_date"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["plan_eff"]).Trim()+" "+Func.FR(_oDr["rwl_plan_eff_date"]).Trim()+" </span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\"> "+Func.FR(_oDr["rwl_con_eff_date"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["pos_ref_no"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["hs_model"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["sku"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["imei_no"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["premium"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["s_premium"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["s_premium1"]).Trim() + "</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["s_premium2"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["s_premium3"]).Trim() + "</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["s_premium4"]).Trim() + "</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["sp_d_date"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["sp_ref_no"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["d_address"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\"> " + Func.FR(_oDr["delivery_date"]).Trim() + " " + Func.FR(_oDr["d_time"]).Trim() + " </span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">$"+Func.FR(_oDr["extra_d_charge"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["contact_person"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["contact_no"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["ext_place_tel"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["pay_method"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["card_type"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["card_no"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["card_holder"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["card_exp_month"]).Trim()+"<span class=\"gensmall\" > / </span><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["card_exp_year"]).Trim()+"<span class=\"gensmall\" ></span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["bank_code"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["bank_name"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">$"+Func.FR(_oDr["amount"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["remarks"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["action_required"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["waive"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\"> " + Func.FR(_oDr["suspend_date"]).Trim() + "</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["exist_plan"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["reasons"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["staff_no"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["staff_name"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["teamcode"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["tl_name"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["salesmancode"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["channel"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["ref_staff_no"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["ref_salesmancode"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["ord_place_by"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["ord_place_rel"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["ord_place_id_type"]).Trim()+"&nbsp;"+Func.FR(_oDr["ord_place_hkid"]).Trim()+"</span> </td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["ord_place_tel"]).Trim()+" </td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["monthly_payment_type"]).Trim()+"</span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["m_card_type"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["m_card_no"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["m_card_holder2"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["m_card_exp_month"]).Trim()+"<span class=\"gensmall\" > / </span><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["m_card_exp_year"]).Trim()+"<span class=\"gensmall\" ></span></td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["ob_program_id"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"+Func.FR(_oDr["bill_cut_num"]).Trim()+"</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["change_payment_type"]).Trim() + "</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["gender"]).Trim() + "</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["rwl_date_of_birth"]).Trim() + "</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["redemption_notice_option"]).Trim() + "</td>");
				_oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["bill_medium_email"]).Trim() + "</td>");
                _oReportWrite.AppendLine("<td nowrap class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["accessory_waive"]).Trim() + "</td>");
                foreach (KeyValuePair<string, string> _oItem in n_oVasNameData)
                {
                    string _sVas_Field = _oItem.Key.ToString();
                    string _sVas_Name = _oItem.Value.ToString();
                    if (!_sVas_Name.Trim().Equals(string.Empty))
                        _oReportWrite.AppendLine("<td nowrap=\"nowrap\" class=\"row2\"><span class=\"gensmall\" style=\"font-size:7pt\">"  + Func.FR(_oDr[_sVas_Field]) + "</span></td>\n");
                }

                _oReportWrite.AppendLine("</tr>");
                Response.Write(_oReportWrite.ToString());
            }
            _oDr.Close();
            _oDr.Dispose();
        }
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
        IDSQuery _oDr = IDSQuery.CreateDsCriteria(n_oVasCreateHolderControl.GetDs(), BusinessVas.Para.TableName());
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

    protected void admin_view_rp1_ItemDataBound(object sender, RepeaterItemEventArgs e)
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
                    _oVas_PlaceHolder.Controls.Add(new LiteralControl(n_oVasCreateHolderControl.ReportTableTrShow(_iOrder_id,false).ToString()));


            }
            */

            Literal _oOld_ord_id = (Literal)e.Item.FindControl("old_ord_id");
            if (!"0".Equals(_oOld_ord_id.Text) && !"".Equals(_oOld_ord_id.Text.Trim()))
                _oOld_ord_id.Text = Func.IDAdd100000(Convert.ToInt32(_oOld_ord_id.Text));
            /*
            Literal _oLicense_waiver = (Literal)e.Item.FindControl("license_waiver");
            if (_oLicense_waiver.Text.Length > 1)
                _oLicense_waiver.Text = _oLicense_waiver.Text.Substring(0, 1);
            */
            Literal _oOrg_ftg = (Literal)e.Item.FindControl("org_ftg");
            if (_oOrg_ftg.Text.Trim() == "ftg")
                _oOrg_ftg.Text = "FTG";

            Literal _oAccept = (Literal)e.Item.FindControl("accept");
            if ("Y".Equals(_oAccept.Text.ToLower()))
                _oAccept.Text = "Accept Autoroll";
            else if ("reject".Equals(_oAccept.Text.ToLower()))
                _oAccept.Text = "Reject Autoroll (change to FTG) ";
            else if ("no_comment".Equals(_oAccept.Text.ToLower()))
                _oAccept.Text = "No Comment";

            Literal _oMonthly_payment_method = (Literal)e.Item.FindControl("monthly_payment_method");
            if (_oMonthly_payment_method.Text == "change_payment_method")
                _oMonthly_payment_method.Text = "Change Payment Method";
            else
                _oMonthly_payment_method.Text = "Keep Existing Payment Method";

        }
    }

    protected void admin_view_rp2_ItemDataBound(object sender, RepeaterItemEventArgs e)
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
            if (_oMobileRetentionOrder_id != null && _oVas_PlaceHolder != null){

                int _iOrder_id;
                if (int.TryParse(_oMobileRetentionOrder_id.Text, out _iOrder_id))
                    _oVas_PlaceHolder.Controls.Add(new LiteralControl(n_oVasCreateHolderControl.ReportTableTrShow(_iOrder_id,false).ToString()));
            }
            */
            Literal _oOld_ord_id = (Literal)e.Item.FindControl("old_ord_id");
            if (!"0".Equals(_oOld_ord_id.Text) && !"".Equals(_oOld_ord_id.Text.Trim()))
                _oOld_ord_id.Text = Func.IDAdd100000(Convert.ToInt32(_oOld_ord_id.Text));

            Literal _oOrg_ftg = (Literal)e.Item.FindControl("org_ftg");
            if (_oOrg_ftg.Text.Trim() == "ftg")
                _oOrg_ftg.Text = "FTG";
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
