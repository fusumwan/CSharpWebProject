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

public partial class Web_FoManagement : DnaExpress.Web.UI.Page
{

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

    public void InitFrame()
    {
        if (!IsPostBack)
        {
            Session["CPESql"] = "";
            ViewState["sortOrder"] = "";
            BindData("", "");
        }
    }

    protected void BindData(string x_sSortExp, string x_sSortDir)
    {
        BindData(GetGridViewFilterSql(), x_sSortExp, x_sSortDir);
    }

    protected void BindData(string x_sQuery, string x_sSortExp, string x_sSortDir)
    {
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append(x_sQuery);
        if (string.IsNullOrEmpty(x_sSortExp))
            _oQuery.Append(" ORDER BY a.RECORD_ID " + x_sSortDir);
        else
            _oQuery.Append(" ORDER BY a." + x_sSortExp + " " + x_sSortDir);
        Session["CPESql"] = _oQuery.ToString();
        FoManagement_RP.DataSource = SYSConn<ODBCConnect>.Connect().GetDS(_oQuery.ToString());
        FoManagement_RP.DataBind();
    }


    protected void FoManagement_RP_Sorting(object sender, GridViewSortEventArgs e)
    {
        BindData(GetGridViewFilterSql(), e.SortExpression, FoManagement_RP.GridViewSortOrder);
    }
    protected void FoManagement_RP_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        FoManagement_RP.PageIndex = e.NewPageIndex;
        BindData(GetGridViewFilterSql(), FoManagement_RP.GridViewSortExpression, FoManagement_RP.GridViewSortOrder);
    }
    public string GetGridViewFilterSql()
    {

        SaleManCodeProfile _oSaleManCodeProfile = new SaleManCodeProfile();
        _oSaleManCodeProfile.SetLv(RWLFramework.CurrentUser[this.Page].Lv);
        _oSaleManCodeProfile.SetUid(RWLFramework.CurrentUser[this.Page].Uid);
        List<string> _oSalesmanList = _oSaleManCodeProfile.Get_SalemanCodeList();
        string _sSalesManList = string.Empty;
        string _sLv = RWLFramework.CurrentUser[this.Page].Lv;

        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append(" SELECT ");
        _oQuery.Append(" a.RECORD_ID,a.SM_NO,a.SALESMAN_ID,");
        _oQuery.Append(" (SELECT b.salename FROM saleinfo b WHERE b.saleid1 = a.SALESMAN_ID AND ROWNUM<=1) as STAFF_NAME,");
        _oQuery.Append(" a.MOBILE_NO,a.FALLOUT_DATE,a.STATUS ");
        _oQuery.Append(" FROM FTS_CPE_FORM  a");
        _oQuery.Append(" WHERE (a.STATUS='AWAIT SALES REPLY' or a.STATUS='(RE-FALLOUT) AWAIT SALES REPLY') ");
        if (!_sLv.Equals("65535"))
        {
            if (_oSalesmanList.Count > 0)
                _sSalesManList = Func.ExplodeList(_oSalesmanList, ",", true).Trim();

            if ((_sLv.Equals("10") || _sLv.Equals("4")) && !string.IsNullOrEmpty(_sSalesManList))
                _oQuery.Append("  AND a.SALESMAN_CODE in ( " + _sSalesManList + " )");
            else
                _oQuery.Append(" AND a.SALESMAN_ID='" + RWLFramework.CurrentUser[this.Page].Uid + "'");
        }


        string _sFilterQuery = ((!string.IsNullOrEmpty(FoManagement_RP.GridViewFilterExpression.Trim())) ? FoManagement_RP.GridViewFilterExpression : string.Empty);
        if (!string.IsNullOrEmpty(_sFilterQuery))
            _oQuery.Append(" AND " + _sFilterQuery);

        return _oQuery.ToString();

    }
    protected void FoManagement_RP_FilterCommand(object sender, DnaExpress.Web.UI.WebControls.FilterCommandEventArgs e)
    {
        if (e != null)
        {
            BindData(GetGridViewFilterSql(), FoManagement_RP.GridViewSortExpression, FoManagement_RP.GridViewSortOrder);
        }
    }
}
