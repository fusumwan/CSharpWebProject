using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using DnaExpress.Web.UI.WebControls.AspxGridViewCommon;
using PCCW.RWL.CORE;
using System.Data;
using System.Text;
public partial class UI_MasterDetailRetentionPlanUsage : DnaExpress.Web.UI.UserControl
{
    static DataSet RatePlanVas = null;
    static DataSet RatePlanDS = null;
    [Bindable(true)]
    [Category("Data")]
    [Description("rate_plan")]
    [DefaultValue(-1)]
    public string rate_plan
    {
        get
        {
            object o = ViewState["rate_plan"];
            return o == null ? string.Empty : o.ToString();
        }
        set
        {
            ViewState["rate_plan"] = value;
            RetentionPlanUsageObj.SelectParameters[0].DefaultValue = value.ToString();
        }
    }

    protected bool IsLoad
    {
        get
        {
            if (ViewState["IsLoad"] == null)
                ViewState["IsLoad"] = false;
            return (bool)ViewState["IsLoad"];
        }
        set
        {
            ViewState["IsLoad"] = value;
        }
    }


    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack || IsLoad == false)
        {
            IsLoad = true;
            RetentionPlanUsageObj.ConnectionString = SYSConn<MSSQLConnect>.Connect().ConnectionStr;
            if (MasterDetailCommandArgument != null)
            {
                rate_plan = MasterDetailCommandArgument.ToString();
                RetentionPlanUsageObj.DataBind();
            }
        }
        RetentionPlanUsageObj.ConnectionString = SYSConn<MSSQLConnect>.Connect().ConnectionStr;
        if (!IsPostBack)
        {
            RatePlanVas = null;
            RatePlanDS = null;
        }
    }

    public DataSet RatePlanVasDataBind()
    {
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("SELECT distinct rate_plan_vas FROM RetentionPlanUsage");
        if (RatePlanVas == null)
        {
            RatePlanVas = SYSConn<MSSQLConnect>.Connect().GetDS(_oQuery.ToString());
        }
        return RatePlanVas;
    }

    public DataSet RatePlanDataBind()
    {
        if (RatePlanDS == null)
        {
            RatePlanDS = BusinessTradeBal.DsRatePlanList(true);
        }
        return RatePlanDS;
    }
    protected void RetentionPlanUsageObj_Init(object sender, EventArgs e)
    {
        RetentionPlanUsageObj.ConnectionString = SYSConn<MSSQLConnect>.Connect().ConnectionStr;
    }
}
