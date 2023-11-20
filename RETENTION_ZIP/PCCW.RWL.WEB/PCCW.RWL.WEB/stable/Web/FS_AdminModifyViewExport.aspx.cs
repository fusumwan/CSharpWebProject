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
public partial class AdminModifyViewExport : NEURON.WEB.UI.BasePage
{

    private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
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

        WebFunc.PrivilegeCheck(this.Page);
        if (!IsPostBack)
        {
            InitFrame();
            WebFunc.ExportExcel(this.Page, "RetentionOrderExcelResult.xls");
        }
    }

    #region InitFrame
    protected void InitFrame()
    {
        StringBuilder _oPrepayWaive = new StringBuilder();
        _oPrepayWaive.Append("'prepayment_waived'= ");
        _oPrepayWaive.Append(" (CASE WHEN a.prepayment_waive=1 THEN 'YES' ");
        _oPrepayWaive.Append(" WHEN a.prepayment_waive=0 THEN 'NO' ");
        _oPrepayWaive.Append(" ELSE '' END) ");


        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("select a.*, b.mid , b.email_date, b.report_type,  b.fallout_remark, b.fallout_reply, b.order_status, b.fallout_main_category , b.fallout_reason, b.retrieve_sn, b.retrieve_date, b.cid as admin_sn, b.cdate as admin_date, " + _oPrepayWaive.ToString() + " from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder a with (nolock)," + Configurator.MSSQLTablePrefix + "MobileOrderReport b with (nolock) where a.order_id=b.order_id and b.active=1 ");
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


        // EDF_NO
        if (Func.RB(WebFunc.qsEdf_no))
            _oQuery.Append(" and a.edf_no='" + WebFunc.qsEdf_no.ToString() + "'");

        // D_DATE
        if (Func.RB(WebFunc.qsD_date))
            _oQuery.Append(" and a.d_date>='" + ((DateTime)WebFunc.qsD_date).ToString("yyyyMMdd") + " 00:00'");

        if (Func.RB(WebFunc.qsD_date2))
            _oQuery.Append(" and a.d_date<='" + ((DateTime)WebFunc.qsD_date2).ToString("yyyyMMdd") + " 23:59'");

        // PLAN_EFF_DATE
        if (Func.RB(WebFunc.qsPlan_eff_date))
            _oQuery.Append(" and a.plan_eff_date>='" + ((DateTime)WebFunc.qsPlan_eff_date).ToString("yyyyMMdd") + " 00:00'");

        if (Func.RB(WebFunc.qsPlan_eff_date2))
            _oQuery.Append(" and a.plan_eff_date<='" + ((DateTime)WebFunc.qsPlan_eff_date2).ToString("yyyyMMdd") + " 23:59'");

        // BILL_CUT_NUM
        if (Func.RB(WebFunc.qsBill_cut_num))
            _oQuery.Append(" and a.bill_cut_num='" + WebFunc.qsBill_cut_num.ToString() + "'");

        // PY RETRIEVED
        //if (Func.RB(WebFunc.qsBill_cut_num))
        //    _oQuery.Append(" and a.bill_cut_num='" + WebFunc.qsBill_cut_num.ToString() + "'");

        // AMOUNT
        if (Func.RB(WebFunc.qsAmount))
            _oQuery.Append(" and a.amount>'" + WebFunc.qsAmount.ToString() + "'");

        _oQuery.Append(" and a.program<>'MOBILE LITE (SIM ONLY)' and a.program<>'MOBILE LITE (HS OFFER)'");
        _oQuery.Append(" order by a.order_id");
        admin_view_rp.DataSource = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
        admin_view_rp.DataBind();
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
        _oDB.SetConnStr(Configurator.DBName.ORADNS + ((!"".Equals(Configurator.IsUat())) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion
    protected void admin_view_rp_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (!e.Item.ItemIndex.Equals(-1))
        {
            int _iOrderID = e.Item.ItemIndex + 1;
            Literal _oViewid = (Literal)e.Item.FindControl("viewid");
            _oViewid.Text = _iOrderID.ToString();

            Literal _oAccept = (Literal)e.Item.FindControl("accept");
            if ("Y".Equals(_oAccept.Text.ToLower()))
                _oAccept.Text = "Accept Autoroll";
            else if ("reject".Equals(_oAccept.Text.ToLower()))
                _oAccept.Text = "Reject Autoroll (change to FTG) ";
            else if ("no_comment".Equals(_oAccept.Text.ToLower()))
                _oAccept.Text = "No Comment";
        }
    }
}
