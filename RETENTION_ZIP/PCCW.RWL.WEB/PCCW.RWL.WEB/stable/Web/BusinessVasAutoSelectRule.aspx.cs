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
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;
using System.Text;
using System.Globalization;
using DnaExpress.Web.UI.WebControls;

public partial class Web_BusinessVasAutoSelectRule : DnaExpress.Web.UI.Page
{
    static DataSet ProgramDS = null;
    static DataSet RatePlanDS = null;
    static DataSet ConPerDS = null;
    static DataSet TradeFieldDS = null;
    static DataSet BundleNameDS = null;
    static DataSet HsModelDS = null;
    static DataSet Vas1DS = null;
    DataSet Value1DS = null;
    DataSet Value2DS = null;
    string[] _oFormat = new string[] { "dd/MM/yyyy", "d/MM/yyyy", "dd/M/yyyy", "d/M/yyyy" };
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
        if (!IsPostBack) { InitFrame(); }
    }


    public void InitFrame()
    {
        if (!IsPostBack)
        {
            ProgramDS = null;
            RatePlanDS = null;
            ConPerDS = null;
            TradeFieldDS = null;
            BundleNameDS = null;
            HsModelDS = null;
            Vas1DS = null;
            Value1DS = null;
            Value2DS = null;

            program.DataSource = ProgramDataBind();
            program.DataBind();
            rate_plan.DataSource = RatePlanDataBind();
            rate_plan.DataBind();
            con_per.DataSource = ConPerDataBind();
            con_per.DataBind();
            trade_field.DataSource = TradeFieldDataBind();
            trade_field.DataBind();
            bundle_name.DataSource = BundleNameDataBind();
            bundle_name.DataBind();
            hs_model.DataSource = HsModelDataBind();
            hs_model.DataBind();
            vas1.DataSource = Vas1DataBind();
            vas1.DataBind();
            active.Checked = true;
            cid.Text = RWLFramework.CurrentUser[this.Page].Uid;
            cid.Attributes["readOnly"] = "readOnly";
        }
    }

    #region DropDownList DataBind
    public DataSet ProgramDataBind()
    {
        if (ProgramDS == null)
        {
            ProgramDS = BusinessTradeBal.DsProgramList(true);
        }
        return ProgramDS;
    }

    public DataSet RatePlanDataBind()
    {
        if (RatePlanDS == null)
        {
            RatePlanDS = BusinessTradeBal.DsRatePlanList(true);
        }
        return RatePlanDS;
    }

    public DataSet ConPerDataBind()
    {
        if (ConPerDS == null)
        {
            ConPerDS = BusinessTradeBal.DsCon_perList(true);
        }
        return ConPerDS;
    }

    public DataSet TradeFieldDataBind()
    {

        if (TradeFieldDS == null)
        {
            TradeFieldDS = BusinessTradeBal.DsTradeFieldList(true);
        }
        return TradeFieldDS;
    }

    public DataSet BundleNameDataBind()
    {
        if (BundleNameDS == null)
        {
            BundleNameDS = BusinessTradeBal.DsBundleNameList(true);
        }
        return BundleNameDS;
    }

    public DataSet HsModelDataBind()
    {
        if (HsModelDS == null)
        {
            HsModelDS = BusinessTradeBal.DsHsModeList(true);
        }
        return HsModelDS;
    }

    public DataSet Vas1DataBind()
    {
        if (Vas1DS == null)
        {
            Vas1DS = SYSConn<MSSQLConnect>.Connect().GetDS("SELECT '' vas_name, '' vas_field,'' multi union all SELECT DISTINCT vas_name,vas_field,multi FROM " + Configurator.MSSQLTablePrefix + "BusinessVas WHERE active=1");
        }
        return Vas1DS;
    }

    public DataSet Value1DataBind(string x_sVas_field)
    {

        Value1DS = SYSConn<MSSQLConnect>.Connect().GetDS("SELECT '' vas_value union all SELECT DISTINCT vas_value FROM " + Configurator.MSSQLTablePrefix + "BusinessVas WHERE active=1 " + ((!string.IsNullOrEmpty(x_sVas_field)) ? " AND vas_field='" + x_sVas_field + "' " : string.Empty));

        return Value1DS;
    }

    public DataSet Value2DataBind()
    {

        Value2DS = SYSConn<MSSQLConnect>.Connect().GetDS("SELECT '' vas_desc, '' fee union all SELECT DISTINCT vas_desc,fee FROM " + Configurator.MSSQLTablePrefix + "BusinessVasDescription WHERE active=1");

        return Value2DS;
    }

    public DataSet Value2DataBind(string x_sVas)
    {

        Value2DS = SYSConn<MSSQLConnect>.Connect().GetDS("SELECT '' vas_desc, '' fee union all SELECT DISTINCT vas_desc,fee FROM " + Configurator.MSSQLTablePrefix + "BusinessVasDescription WHERE active=1 " + ((!string.IsNullOrEmpty(x_sVas)) ? " AND VAS='" + x_sVas + "' " : string.Empty));

        return Value2DS;
    }
    #endregion


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

    protected void VasRuleAdd_Click(object sender, EventArgs e)
    {
        BusinessVasDefaultSet _oBusinessVasDefaultSet = new BusinessVasDefaultSet(SYSConn<MSSQLConnect>.Connect());

        _oBusinessVasDefaultSet.SetProgram(program.SelectedValue);
        _oBusinessVasDefaultSet.SetRate_plan(rate_plan.SelectedValue);
        _oBusinessVasDefaultSet.SetCon_per(con_per.SelectedValue);
        _oBusinessVasDefaultSet.SetTrade_field(trade_field.SelectedValue);
        _oBusinessVasDefaultSet.SetBundle_name(bundle_name.SelectedValue);
        _oBusinessVasDefaultSet.SetHs_model(hs_model.SelectedValue);
        _oBusinessVasDefaultSet.SetVas1(vas1.SelectedValue);
        _oBusinessVasDefaultSet.SetDisplay1(display1.Checked);
        _oBusinessVasDefaultSet.SetEnabled1(enabled1.Checked);
        _oBusinessVasDefaultSet.SetValue1(value1_drp.SelectedValue);
        _oBusinessVasDefaultSet.SetIssue_type(issue_type.SelectedValue);
        if (!string.IsNullOrEmpty(vas1.SelectedValue))
        {
            _oBusinessVasDefaultSet.SetVas2(vas1.SelectedValue + "1");
        }
        else
        {
            _oBusinessVasDefaultSet.SetVas2(string.Empty);
        }
        _oBusinessVasDefaultSet.SetDisplay2(display2.Checked);
        _oBusinessVasDefaultSet.SetEnabled2(enabled2.Checked);
        _oBusinessVasDefaultSet.SetValue2(value2_drp.SelectedValue);
        _oBusinessVasDefaultSet.SetCid(cid.Text);
        _oBusinessVasDefaultSet.SetCdate(DateTime.Now);

        DateTime _dEdate;
        if (DateTime.TryParseExact(edate.Text.ToString(), _oFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dEdate))
            _oBusinessVasDefaultSet.SetEdate(_dEdate);
        else
            _oBusinessVasDefaultSet.SetEdate(null);

        _oBusinessVasDefaultSet.SetActive(active.Checked);
        if (_oBusinessVasDefaultSet.GetVas1() == string.Empty)
        {
            RegisterJavaScript(string.Empty, "jAlert('Please kindly select vas name!','System Message');", true);
            return;
        }
        if (_oBusinessVasDefaultSet.GetCid() == string.Empty)
        {
            RegisterJavaScript(string.Empty, "jAlert('Cannot missing user id!','System Message');", true);
            return;
        }
        if (_oBusinessVasDefaultSet.GetIssue_type() == string.Empty)
        {
            RegisterJavaScript(string.Empty, "jAlert('Please kindly select issue type!','System Message');", true);
            return;
        }
        if (BusinessVasDefaultSetBal.InsertWithOutLastID(SYSConn<MSSQLConnect>.Connect(), _oBusinessVasDefaultSet))
        {
            RegisterJavaScript(string.Empty, "jAlert('Insert Success!','System Message');", true);
            VasAutoSetScript.Instance().Reload();
        }
        else
        {
            RegisterJavaScript(string.Empty, "jAlert('Insert Faill!','System Message');", true);
        }
    }

    #region RegisterJavaScript
    protected void RegisterJavaScript(string x_sID, string x_sScript, bool x_bIncludeScript)
    {
        if (x_bIncludeScript) x_sScript = "<script>" + x_sScript + "</script>";
        ScriptManager.RegisterStartupScript(this.Page, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), x_sScript, false);
    }
    #endregion

    protected void vas1_SelectedIndexChanged(object sender, EventArgs e)
    {
        value1_drp.Items.Clear();
        value2_drp.Items.Clear();

        if (!string.IsNullOrEmpty(vas1.SelectedValue))
        {
            value1_drp.DataSource = Value1DataBind(vas1.SelectedValue);
            value1_drp.DataBind();
            if (value1_drp.Items.Count <= 1) { value1_drp.Items.Clear(); }
            value1_drp.Rows = ((value1_drp.Items.Count > 1) ? 10 : 2);
           

            value2_drp.DataSource = Value2DataBind(vas1.SelectedValue);
            value2_drp.DataBind();
            if (value2_drp.Items.Count <= 1) { value2_drp.Items.Clear(); }
            value2_drp.Rows = ((value2_drp.Items.Count > 1) ? 10 : 2);
            
            
        }
    }
}
