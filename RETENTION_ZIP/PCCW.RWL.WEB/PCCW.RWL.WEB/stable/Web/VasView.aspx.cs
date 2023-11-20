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
using NEURON.ENTITY.FRAMEWORK.STOCK;

public partial class Web_VasView : DnaExpress.Web.UI.Page
{
    static DataSet ProgramDS = null;
    static DataSet RatePlanDS = null;
    static DataSet ConPerDS = null;
    static DataSet TradeFieldDS = null;
    static DataSet BundleNameDS = null;
    static DataSet HsModelDS = null;
    static DataSet VasFieldDS = null;
    static ObjectArr NormalRebateTypeDS = null;
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
        BundleMappingObj.ConnectionString = SYSConn<MSSQLConnect>.Connect().ConnectionStr;
    }

    protected void InitFrame()
    {

        ProgramDS = null;
        RatePlanDS = null;
        ConPerDS = null;
        TradeFieldDS = null;
        BundleNameDS = null;
        HsModelDS = null;
        VasFieldDS = null;
        NormalRebateTypeDS = null;
    }



    protected void PageSizeRefresh_Click(object sender, EventArgs e)
    {

        if (GvPageSize != null)
        {
            int _iPageSize;
            if (int.TryParse(GvPageSize.Text, out _iPageSize))
            {
                if (_iPageSize > 0)
                {
                    BundleMappingGW.PageSize = _iPageSize;
                }
            }
            else
            {
                GvPageSize.Text = "15";
                BundleMappingGW.PageSize = 15;
            }
        }

        BundleMappingGW.DataBind();

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

    public DataSet VasFieldDataBind()
    {
        if (VasFieldDS == null)
        {
            VasFieldDS = SYSConn<MSSQLConnect>.Connect().GetDS("SELECT '' vas_name, '' vas_field,'' multi union all SELECT DISTINCT vas_name,vas_field,multi FROM " + Configurator.MSSQLTablePrefix + "BusinessVas WHERE active=1");
        }
        return VasFieldDS;
    }

    public ObjectArr NormalRebateTypeDataBind()
    {
        if (NormalRebateTypeDS == null)
        {
            NormalRebateTypeDS = FromRegisterControler.GetNormalRebateTypeList(true);

        }
        return NormalRebateTypeDS;
    }
   
    #endregion

    #region RegisterJavaScript
    protected void RegisterJavaScript(string x_sID, string x_sScript, bool x_bIncludeScript)
    {
        if (x_bIncludeScript) x_sScript = "<script>" + x_sScript + "</script>";
        ScriptManager.RegisterStartupScript(this.Page, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), x_sScript, false);
    }
    #endregion
    protected void BundleMappingObj_Inserting(object sender, SqlDataSourceCommandEventArgs e)
    {

    }
    protected void BundleMappingObj_Init(object sender, EventArgs e)
    {
        BundleMappingObj.ConnectionString = SYSConn<MSSQLConnect>.Connect().ConnectionStr;
    }
    protected void BundleMappingObj_Updating(object sender, SqlDataSourceCommandEventArgs e)
    {

    }
    protected void BundleMappingGW_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridView _oGridView = (GridView)sender;
        GridViewRow _oGridViewRow = (GridViewRow)_oGridView.Rows[e.RowIndex];
        AspxTextBox _oSdate = (AspxTextBox)_oGridViewRow.FindControl("sdate");
        if (_oSdate.Text != string.Empty)
        {
            DateTime _dSdate;
            if (DateTime.TryParseExact(_oSdate.Text, _oFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dSdate))
                e.NewValues["sdate"] = _dSdate;
            else
                e.NewValues["sdate"] = null;
        }


        AspxTextBox _oEdate = (AspxTextBox)_oGridViewRow.FindControl("edate");
        if (_oEdate.Text != string.Empty)
        {
            DateTime _dEdate;
            if (DateTime.TryParseExact(_oEdate.Text, _oFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dEdate))
                e.NewValues["edate"] = _dEdate;
            else
                e.NewValues["edate"] = null;
        }


        
        
    }
    protected void BundleMappingGW_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowIndex >= 0 && BundleMappingGW.EditIndex >= 0)
        {
            if ((e.Row.RowState & DataControlRowState.Edit) != 0)
            {
                AspxTextBox _oCid = (AspxTextBox)e.Row.FindControl("cid");
                _oCid.Attributes["readOnly"] = "readOnly";
            }
        }
    }
    protected void BundleMappingGW_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Edit")
        {

            PageSizeRefresh.Enabled = false;
        }
        else if (e.CommandName == "Cancel")
        {
            PageSizeRefresh.Enabled = true;
        }
    }
    protected void BundleMappingGW_RowUpdated(object sender, GridViewUpdatedEventArgs e)
    {
        PageSizeRefresh.Enabled = true;
    }
    protected void BundleMappingGW_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        PageSizeRefresh.Enabled = true;
    }
}
