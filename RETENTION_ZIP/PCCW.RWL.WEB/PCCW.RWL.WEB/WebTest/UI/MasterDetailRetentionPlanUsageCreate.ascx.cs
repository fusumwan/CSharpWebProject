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
using DnaExpress.Web.UI.WebControls;

public partial class UI_MasterDetailRetentionPlanUsageCreate : DnaExpress.Web.UI.UserControl
{
    static DataSet RatePlanVas = null;
    static DataSet RatePlanDS = null;
    [Bindable(true)]
    [Category("Data")]
    [Description("rate_plan_val")]
    [DefaultValue(-1)]
    public string rate_plan_val
    {
        get
        {
            object o = ViewState["rate_plan_val"];
            return o == null ? string.Empty : o.ToString();
        }
        set
        {
            ViewState["rate_plan_val"] = value;

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
        RWLFramework.DataBaseConfigSetting();
        if (IsPostBack)
        {
            InitFrame();
        }

    }


    protected void InitFrame()
    {
        if (!IsPostBack)
        {
            RatePlanVas = null;
            RatePlanDS = null;
        }
        rate_plan.DataSource = RatePlanDataBind();
        rate_plan.DataBind();
        rate_plan_vas.DataSource = RatePlanVasDataBind();
        rate_plan_vas.DataBind();


        if (!IsPostBack || IsLoad == false)
        {
            IsLoad = true;

            if (MasterDetailCommandArgument != null)
            {
                rate_plan_val = MasterDetailCommandArgument.ToString();
                DropListSelectedValue(ref rate_plan, rate_plan_val);
            }
        }
    }

    #region DropListSelectedValue
    public void DropListSelectedValue(ref AspxDropDownList x_oDrp, string x_sValue)
    {
        DropListSelectedValue(ref x_oDrp, x_sValue, true);
    }
    public void DropListSelectedValue(ref AspxDropDownList x_oDrp, string x_sValue, bool x_bMustSelect)
    {
        bool _bFlag = false;
        for (int i = 0; i < x_oDrp.Items.Count; i++)
        {
            if (x_oDrp.Items[i].Value.ToUpper().Trim() == x_sValue.ToUpper().Trim())
            {
                x_oDrp.SelectedIndex = i;
                x_oDrp.SelectedValue = x_sValue;
                _bFlag = true;
            }
        }

        if (x_bMustSelect && !_bFlag && !x_sValue.Trim().Equals(string.Empty))
        {
            x_oDrp.Items.Add(new ListItem(x_sValue, x_sValue));
            x_oDrp.SelectedValue = x_sValue;
        }
    }
    #endregion

    protected void CreateRecord_Click(object sender, EventArgs e)
    {
        RetentionPlanUsage _oRetentionPlanUsage = new RetentionPlanUsage(SYSConn<MSSQLConnect>.Connect());
        _oRetentionPlanUsage.SetActive(true);
        _oRetentionPlanUsage.SetCdate(DateTime.Now);
        _oRetentionPlanUsage.SetRate_plan(rate_plan.SelectedValue);
        _oRetentionPlanUsage.SetRate_plan_vas(rate_plan_vas.SelectedValue);
        _oRetentionPlanUsage.SetRate_plan_vas_value(rate_plan_vas_value.Text);
        if (RetentionPlanUsageBal.InsertWithOutLastID(SYSConn<MSSQLConnect>.Connect(), _oRetentionPlanUsage))
        {
            
            (((MasterDetailItemData)this.NamingContainer).FindControl("MasterDetailRetentionPlanUsageControl")).DataBind();
            RegisterJavaScript(string.Empty, "jAlert('Create Success!','System Message');UpdatePanelRefesh('Up1');", true);

            RatePlanVas = null;
            RatePlanDS = null;
            rate_plan.DataSource = RatePlanDataBind();
            rate_plan.DataBind();
            rate_plan_vas.DataSource = RatePlanVasDataBind();
            rate_plan_vas.DataBind();
        }
        else
        {
            RegisterJavaScript(string.Empty, "jAlert('Create Fail!','System Message');", true);
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

    #region RegisterJavaScript
    protected void RegisterJavaScript(string x_sID, string x_sScript, bool x_bIncludeScript)
    {
        if (x_bIncludeScript) x_sScript = "<script>" + x_sScript + "</script>";
        ScriptManager.RegisterStartupScript(this.Up2, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), x_sScript, false);
    }
    #endregion
}
