using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using log4net;
using System.Reflection;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

public partial class Web_PlanRetentionViewCreateAction : System.Web.UI.Page
{
    static DataSet RatePlanDS = null;
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

        RWLFramework.DataBaseConfigSetting();
        //WebFunc.PrivilegeCheck(this.Page);
        if (!IsPostBack) InitFrame();
    }

    protected void InitFrame()
    {
        RatePlanDS = null;
        rate_plan.DataSource = RatePlanDataBind();
        rate_plan.DataBind();
        rate_plan.SelectedIndex = 0;
    }
    public DataSet RatePlanDataBind()
    {
        if (RatePlanDS == null)
        {
            RatePlanDS = BusinessTradeBal.DsRatePlanList(false);
        }
        return RatePlanDS;
    }

    protected void CreateRecord_Click(object sender, EventArgs e)
    {
        if (!IsCreated())
        {
            RetentionPlan _oRetentionPlan = new RetentionPlan(SYSConn<MSSQLConnect>.Connect());
            double _dPlan_fee;
            if (double.TryParse(plan_fee.Text, out _dPlan_fee))
            {
                _oRetentionPlan.SetPlan_fee(_dPlan_fee);
                _oRetentionPlan.SetPlan_code(rate_plan.SelectedValue);
                _oRetentionPlan.SetCid(RWLFramework.CurrentUser[this.Page].Uid);
                _oRetentionPlan.SetCdate(DateTime.Now);
                _oRetentionPlan.SetActive(true);
                if(RetentionPlanRepository.Insert(SYSConn<MSSQLConnect>.Connect(), _oRetentionPlan))
                    RegisterJavaScript(string.Empty, "jAlert('Create Success!','System Message');", true);
                else
                    RegisterJavaScript(string.Empty, "jAlert('Create Fail!','System Message');", true);

            }
            else
            {
                RegisterJavaScript(string.Empty, "jAlert('Create Fail : Plan fee must be integer!','System Message');", true);
            }
        }
        else
        {
            RegisterJavaScript(string.Empty, "jAlert('Create Fail : Duplicate record!','System Message');", true);
        }
    }

    #region RegisterJavaScript
    protected void RegisterJavaScript(string x_sID, string x_sScript, bool x_bIncludeScript)
    {
        if (x_bIncludeScript) x_sScript = "<script>" + x_sScript + "</script>";
        ScriptManager.RegisterStartupScript(this.Page, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), x_sScript, false);
    }
    #endregion

    protected bool IsCreated()
    {
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("SELECT ID FROM RetentionPlan WHERE plan_code='"+rate_plan.SelectedValue+"' ");
        string _sResult = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar(_oQuery.ToString());
        if (string.IsNullOrEmpty(_sResult))
        {
            return false;
        }
        return true;
    }
}
