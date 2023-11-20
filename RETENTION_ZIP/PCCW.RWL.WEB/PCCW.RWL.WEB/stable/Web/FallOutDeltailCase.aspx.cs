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
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;

public partial class Web_FallOutDeltailCase : System.Web.UI.Page
{
    MSSQLConnect n_oDB = null;
    BusinessDeliveryFalloutProfile n_oBusinessDeliveryFalloutProfile = new BusinessDeliveryFalloutProfile();
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion
    public string sortOrder { get { if (ViewState["sortOrder"].ToString() == "desc") { ViewState["sortOrder"] = "asc"; } else { ViewState["sortOrder"] = "desc"; } return ViewState["sortOrder"].ToString(); } set { ViewState["sortOrder"] = value; } }

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
        if (!IsPostBack)
        {
            Session["FallOutDeltailCaseSql"] = "";
            ViewState["sortOrder"] = "";
            BindData(GetGridViewFilterSql(string.Empty, string.Empty));
        }
    }

    protected void BindData(string x_sQuery)
    {
        FallOutDeltailCaseGV.DataSource = SYSConn<ODBCConnect>.Connect().GetDS(x_sQuery);
        FallOutDeltailCaseGV.DataBind();
        Session["FallOutDeltailCaseSql"] = x_sQuery;
    }

    protected void FallOutDeltailCaseGV_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        FallOutDeltailCaseGV.PageIndex = e.NewPageIndex;
        BindData(GetGridViewFilterSql(FallOutDeltailCaseGV.GridViewSortExpression, FallOutDeltailCaseGV.GridViewSortOrder));
    }

    protected void FallOutDeltailCaseGV_Sorting(object sender, GridViewSortEventArgs e)
    {
        BindData(GetGridViewFilterSql(e.SortExpression, FallOutDeltailCaseGV.GridViewSortOrder));
    }

    public string GetGridViewFilterSql(string x_sSortExp, string x_sSortDir)
    {
        if (n_oDB == null) { (n_oDB = new MSSQLConnect()).SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty)); }
        if (RWLFramework.CurrentUser[this.Page].Lv != null) n_oBusinessDeliveryFalloutProfile.SetLv(RWLFramework.CurrentUser[this.Page].Lv.ToString());
        if (RWLFramework.CurrentUser[this.Page].Uid != null) n_oBusinessDeliveryFalloutProfile.SetUid(RWLFramework.CurrentUser[this.Page].Uid.ToString());
        n_oBusinessDeliveryFalloutProfile.SetSalemancodelist(n_oBusinessDeliveryFalloutProfile.Get_SalesManList());
        string _sQuery = string.Empty;

        _sQuery = n_oBusinessDeliveryFalloutProfile.GetQuery(FallOutDeltailCaseGV.GridViewFilterExpression,(string.IsNullOrEmpty(x_sSortExp)) ? "agree_no" : x_sSortExp, (string.IsNullOrEmpty(x_sSortDir)) ? "asc" : x_sSortDir);
        Session["FallOutDeltailCaseSql"] = _sQuery;
        
        return _sQuery;
    }

    protected void FallOutDeltailCaseGV_FilterCommand(object sender, DnaExpress.Web.UI.WebControls.FilterCommandEventArgs e)
    {
        if (e != null)
        {
            BindData(GetGridViewFilterSql(FallOutDeltailCaseGV.GridViewSortExpression, FallOutDeltailCaseGV.GridViewSortOrder));
        }
    }
}
