using System;
using System.Collections;
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
using System.Data.SqlClient;
using System.Globalization;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;


public partial class GoWirelessUpdateStatusViewImplement : NEURON.WEB.UI.BasePage
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
        if (!IsPostBack) InitFrame();
    }

    protected void InitFrame()
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
        */
        StringBuilder _oQuery = new StringBuilder();
        if (Session["update_sql"] == null)
        {
            _oQuery.Append("SELECT a.*, b.mid , b.email_date, b.report_type, b.order_status, b.fallout_main_category , b.fallout_reason, b.fallout_remark, b.fallout_reply, b.retrieve_sn, b.retrieve_date, b.cid as admin_sn, b.cdate as admin_date, c.vas_value as gowireless_vas from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder a with (nolock) LEFT JOIN " + Configurator.MSSQLTablePrefix + "MobileOrderReport b with (nolock) on a.order_id=b.order_id LEFT JOIN "+Configurator.MSSQLTablePrefix+"MobileOrderVas c on c.order_id=a.order_id WHERE b.active=1 AND a.active=1 AND b.gw_retrieve_sn is not null ");
            if (WebFunc.qsOrder_id != null && !string.IsNullOrEmpty(WebFunc.qsOrder_id2))
                _oQuery.Append(" AND a.order_id>=" + Func.IDSubtract100000(WebFunc.qsOrder_id) + " ");
            else if (!Func.IDSubtract100000(WebFunc.qsOrder_id).Equals(string.Empty))
                _oQuery.Append(" AND a.order_id='" + Func.IDSubtract100000(WebFunc.qsOrder_id) + "' ");

            if (!string.IsNullOrEmpty(WebFunc.qsOrder_id2))
                _oQuery.Append(" AND a.order_id<=" + Func.IDSubtract100000(Convert.ToInt32(WebFunc.qsOrder_id2)) + " ");

            if (WebFunc.qsEmail_date != null)
            {
                DateTime _oDate;
                if (DateTime.TryParseExact(Func.RQ(Request[WebFunc.qsEmail_dateName]), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _oDate))
                {
                    _oQuery.Append(" AND b.email_date>='" + _oDate.ToString("dd/MM/yyyy 00:00") + "'");
                }
            }

            if (WebFunc.qsEmail_date2 != null)
            {
                DateTime _oDate;
                if (DateTime.TryParseExact(Func.RQ(Request[WebFunc.qsEmail_date2Name]), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _oDate))
                {
                    _oQuery.Append(" AND b.email_date>='" + _oDate.ToString("dd/MM/yyyy 23:59") + "'");
                }
            }

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

            if (!string.IsNullOrEmpty(WebFunc.qsMrt_no))
                _oQuery.Append(" AND a.mrt_no='" + WebFunc.qsMrt_no + "'");


            if (Func.RB(WebFunc.qsOrder_status))
            {
                if ("no_follow".Equals(WebFunc.qsOrder_status))
                    _oQuery.Append(" AND (b.order_status='' or b.order_status is null)");
                else if ("no_follow_t4".Equals(WebFunc.qsOrder_status))
                    _oQuery.Append(" AND (b.order_status='' or b.order_status is null) AND DATEDIFF(d,b.email_date,getdate())>4 ");
                else
                    _oQuery.Append(" AND b.order_status='" + WebFunc.qsOrder_status.ToString() + "'");
            }


            if (Func.RB(WebFunc.qsFallout_main_category))
                _oQuery.Append(" AND b.fallout_main_category='" + WebFunc.qsFallout_main_category.ToString() + "' ");

            if (Func.RB(WebFunc.qsFallout_reason))
                _oQuery.Append(" AND b.fallout_reason='" + WebFunc.qsFallout_reason.ToString() + "' ");


            _oQuery.Append(" order by a.order_id ");

            Session["update_sql"] = _oQuery.ToString();

        }
        else
            _oQuery.Append(Session["update_sql"].ToString());

        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
        admin_view_rp.DataSource = _oDr;
        admin_view_rp.DataBind();
        //record_cnt.Value = _oDr.RecordsAffected.ToString();
        record_cnt.Value = admin_view_rp.Items.Count.ToString();
    }
    protected void admin_view_rp_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (!e.Item.ItemIndex.Equals(-1))
        {
            int _iOrderID = e.Item.ItemIndex + 1;
            Literal _oViewid = (Literal)e.Item.FindControl("viewid");
            _oViewid.Text = _iOrderID.ToString();
            Literal _oMid = (Literal)e.Item.FindControl("mid");
            CheckBox _oUpdate_status = (CheckBox)e.Item.FindControl("update_status");
            if (_oUpdate_status != null && _oMid!=null){
                _oUpdate_status.Attributes["value"] = _oMid.Text;
            }
            Literal _oD_date = (Literal)e.Item.FindControl("d_date");
            Literal _oNew_date = (Literal)e.Item.FindControl("new_date");
            if (_oD_date != null && _oNew_date!=null)
            {
                DateTime _oDate;
                if (DateTime.TryParseExact(_oD_date.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _oDate))
                {
                    _oDate = _oDate.AddDays(3);
                    _oNew_date.Text = _oDate.ToString("dd/MM/yyyy");
                }

            }
        }
    }
}
