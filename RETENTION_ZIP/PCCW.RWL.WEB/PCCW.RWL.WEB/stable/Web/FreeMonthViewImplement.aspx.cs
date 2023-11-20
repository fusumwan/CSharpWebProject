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


public partial class FreeMonthViewImplement : NEURON.WEB.UI.BasePage
{
    MSSQLConnect n_oDB = null;
    DataSet n_oFreeMonList = new DataSet();
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

        WebFunc.PrivilegeCheck(this.Page);
        if (!IsPostBack)
        {
            BindData();
        }
    }


    public void BindData()
    {
        if (n_oDB == null) { (n_oDB = new MSSQLConnect()).SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty)); }
        n_oFreeMonList = n_oDB.GetDS("select distinct free_mon from " +Configurator.MSSQLTablePrefix+ "BusinessTrade with (nolock) where active=1 and (free_mon<>'' and free_mon is not null and free_mon<>'0')");

        drpFREE_MON_ADD.Items.Clear();
        drpFREE_MON_ADD.Items.Add(new ListItem(string.Empty, string.Empty));

        MobileOrderMonthlyFee_VIEW_RP.DataSource = n_oDB.GetDS("SELECT mid,free_mon,mon,fee FROM " + Configurator.MSSQLTablePrefix + "MobileOrderMonthlyFee WHERE active=1 and (free_mon<>'' and free_mon is not null and free_mon<>'0' ) and active=1 order by mid");
        MobileOrderMonthlyFee_VIEW_RP.DataBind();

        for (int i = 0; i < n_oFreeMonList.Tables[0].Rows.Count; i++)
        {
            string _sValue = n_oFreeMonList.Tables[0].Rows[i][0].ToString();
            drpFREE_MON_ADD.Items.Add(new ListItem(_sValue, _sValue));
        }
        drpFREE_MON_ADD.SelectedIndex = 0;
    }

    protected DataSet BindFreeMon()
    {
        return n_oFreeMonList;
    }

    protected void submitbut_Click(object sender, EventArgs e)
    {

        if (drpFREE_MON_ADD.SelectedValue == string.Empty) { WebFunc.RegisterScriptEX(this.Page, "Please select plan!"); }
        MobileOrderMonthlyFee _oMobileOrderMonthlyFee = (MobileOrderMonthlyFee)MobileOrderMonthlyFeeRepository.CreateEntityInstanceObject();

        _oMobileOrderMonthlyFee.SetFree_mon(drpFREE_MON_ADD.SelectedValue);
        _oMobileOrderMonthlyFee.SetMon(Convert.ToInt32(txtMON_ADD.Text));
        _oMobileOrderMonthlyFee.SetFee(Convert.ToInt32(txtFEE_ADD.Text));
        _oMobileOrderMonthlyFee.SetActive(true);
        if (n_oDB == null) { (n_oDB = new MSSQLConnect()).SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty)); }
        if (MobileOrderMonthlyFeeRepository.InsertWithOutLastID(n_oDB, _oMobileOrderMonthlyFee))
        {
            BindData();
            drpFREE_MON_ADD.SelectedIndex = 0;
            txtMON_ADD.Text = string.Empty;
            txtFEE_ADD.Text = string.Empty;
        }
        else
        {
            WebFunc.RegisterScriptEX(this.Page, "Insert Error!");
        }
    }

    protected void MobileOrderMonthlyFee_VIEW_RP_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (n_oDB == null) { (n_oDB = new MSSQLConnect()).SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty)); }
        if ("Modify".Equals(e.CommandName))
        {
            Label _txtmid = (Label)e.Item.FindControl("txtmid");
            int _iFreeMon_id = Convert.ToInt32(_txtmid.Text);

            DropDownList _drpFREE_MON = (DropDownList)e.Item.FindControl("drpFREE_MON");
            TextBox _txtMON = (TextBox)e.Item.FindControl("txtMON");
            TextBox _txtFEE = (TextBox)e.Item.FindControl("txtFEE");

            MobileOrderMonthlyFee _oMobileOrderMonthlyFee = (MobileOrderMonthlyFee)MobileOrderMonthlyFeeRepository.CreateEntityInstanceObject();
            _oMobileOrderMonthlyFee.SetMid(_iFreeMon_id);
            _oMobileOrderMonthlyFee.Retrieve();

            if (_drpFREE_MON.SelectedValue != string.Empty) { _oMobileOrderMonthlyFee.SetFree_mon(_drpFREE_MON.SelectedValue); }
            if (_txtMON.Text != string.Empty) { _oMobileOrderMonthlyFee.SetMon(Convert.ToInt32(_txtMON.Text)); }
            if (_txtFEE.Text != string.Empty) { _oMobileOrderMonthlyFee.SetFee(Convert.ToInt32(_txtFEE.Text)); }

            if (_oMobileOrderMonthlyFee.Save())
                BindData();
            else
                WebFunc.RegisterScriptEX(this.Page, "Modify Error!");
        }
        else if ("Delete".Equals(e.CommandName))
        {
            Label _txtmid = (Label)e.Item.FindControl("txtmid");
            int _iFeeMon_id = Convert.ToInt32(_txtmid.Text);
            if (MobileOrderMonthlyFeeRepository.Delete(n_oDB, _iFeeMon_id))
            {
                BindData();
            }
        }
    }

    protected void MobileOrderMonthlyFee_VIEW_RP_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (!e.Item.ItemIndex.Equals(-1)){
            if (n_oFreeMonList.Tables.Count > 0)
            {
                DropDownList _drpFREE_MON = (DropDownList)e.Item.FindControl("drpFREE_MON");
                Label _txtFreeMon = (Label)e.Item.FindControl("txtFREE_MON");
                _drpFREE_MON.Items.Clear();
                _drpFREE_MON.Items.Add(new ListItem(string.Empty, string.Empty));
                _drpFREE_MON.SelectedIndex = 0;
                for (int i = 0; i < n_oFreeMonList.Tables[0].Rows.Count; i++){
                    _drpFREE_MON.Items.Add(new ListItem(n_oFreeMonList.Tables[0].Rows[i][0].ToString(), n_oFreeMonList.Tables[0].Rows[i][0].ToString()));
                    if (_txtFreeMon.Text.ToUpper().Trim() == n_oFreeMonList.Tables[0].Rows[i][0].ToString().ToUpper().Trim())
                        _drpFREE_MON.SelectedValue = n_oFreeMonList.Tables[0].Rows[i][0].ToString();
                }
            }
            int orderID = e.Item.ItemIndex + 1;
            Label _FreeMonNum = (Label)e.Item.FindControl("FreeMonNum");
            _FreeMonNum.Text = orderID.ToString();
        }
    }
}
