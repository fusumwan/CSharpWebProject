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
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;
using log4net;
using System.Reflection;

using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using NEURON.ENTITY.FRAMEWORK.STOCK;

public partial class Web_BusinessTradeView : DnaExpress.Web.UI.Page
{
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion
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

        Session["tradesql"] = string.Empty;
         WebFunc.PrivilegeCheck(this.Page);
         InitFrame();
    }

    protected void InitFrame()
    {
        program.Items.Clear();
        program.DataSource = ProgramDataBind();
        program.DataBind();

        rate_plan.Items.Clear();
        rate_plan.DataSource = RatePlanDataBind();
        rate_plan.DataBind();

        con_per.Items.Clear();
        con_per.DataSource = ConPerDataBind();
        con_per.DataBind();

        trade_field.Items.Clear();
        trade_field.DataSource = TradeFieldDataBind();
        trade_field.DataBind();

        NormalRebateTypeBindData(true);
    }

    #region DropDownList DataBind


    protected void NormalRebateTypeBindData(bool x_bIncludeAll)
    {
        if (normal_rebate_type != null)
        {
            normal_rebate_type.Items.Clear();
            ObjectArr _oNormalRebateType = FromRegisterControler.GetNormalRebateTypeList(x_bIncludeAll);
            for (int i = 0; i < _oNormalRebateType.Count; i++)
            {
                object _sKey = _oNormalRebateType.KeyFind(i);
                object _sValue = _oNormalRebateType.ValueFind(i);
                normal_rebate_type.Items.Add(new ListItem(_sKey.ToString(), _sValue.ToString()));
                if (x_bIncludeAll)
                {
                    if (_sKey.Equals("ALL"))
                        normal_rebate_type.SelectedValue = "";
                }
                else
                    normal_rebate_type.SelectedValue = "RETENTION";
            }
        }
    }


    public DataSet ProgramDataBind()
    {
        if (issue_type.SelectedIndex > 0)
        {
            return BusinessTradeBal.DsProgramList(true, " AND Issue_type='" +issue_type.SelectedValue+"' ",string.Empty);
        }
        return BusinessTradeBal.DsProgramList(true);
    }

    public DataSet RatePlanDataBind()
    {
        if (issue_type.SelectedIndex > 0)
        {
            return BusinessTradeBal.DsRatePlanList(true, " AND Issue_type='" +issue_type.SelectedValue+"' ", string.Empty);
        }
        return BusinessTradeBal.DsRatePlanList(true);
    }

    public DataSet ConPerDataBind()
    {
        if (issue_type.SelectedIndex > 0)
        {
            return BusinessTradeBal.DsCon_perList(true, " AND Issue_type='" +issue_type.SelectedValue+"' ", string.Empty);
        }
        return BusinessTradeBal.DsCon_perList(true);
    }

    public DataSet TradeFieldDataBind()
    {
        if (issue_type.SelectedIndex > 0)
        {
            return BusinessTradeBal.DsTradeFieldList(true, " AND Issue_type='" +issue_type.SelectedValue+"' ", string.Empty);
        }
        return BusinessTradeBal.DsTradeFieldList(true);
    }

    #endregion
}
