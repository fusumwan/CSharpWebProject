using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Globalization;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;
public partial class Web_AccessRight_MobileOrderIssueOrderRestrictionColumnProfile : System.Web.UI.Page
{
    string[] _oFormat = new string[] { 
        "dd/MM/yyyy HH:mm:ss","dd/M/yyyy HH:mm:ss","d/MM/yyyy HH:mm:ss",  "d/M/yyyy HH:mm:ss"
    };
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
        if (!IsPostBack)
        {
            MobileOrderIssueRestrictionProfile_restriction_id.DataSource = GetRestrictionDS();
            MobileOrderIssueRestrictionProfile_restriction_id.DataBind();
        }
    }

    public DataSet GetRestrictionDS()
    {
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("SELECT top 1 'restriction_id'='', 'name'='' FROM MobileOrderIssueRestriction UNION SELECT restriction_id,name FROM MobileOrderIssueRestriction WITH (NOLOCK) WHERE active=1");
        return SYSConn<MSSQLConn>.Connect().GetDS(_oQuery.ToString());
    }
    protected void MobileOrderIssueRestrictionProfileFV_ItemCreated(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (MobileOrderIssueRestrictionProfileFV.DefaultMode == FormViewMode.Insert)
            {
                TextBox _oCid = (TextBox)MobileOrderIssueRestrictionProfileFV.Row.FindControl("MobileOrderIssueRestrictionProfile_cid");
                _oCid.Text = RWLFramework.CurrentUser[this.Page].Uid;
                _oCid.ReadOnly = true;
            }
        }
    }
    protected void MobileOrderIssueRestrictionProfile_restriction_id_SelectedIndexChanged(object sender, EventArgs e)
    {
        MobileOrderIssueRestrictionProfileGV.DataBind();
    }
    protected void MobileOrderIssueRestrictionProfileObj_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        if (!string.IsNullOrEmpty(MobileOrderIssueRestrictionProfile_restriction_id.SelectedValue))
            e.InputParameters.Add("x_sRestriction_id", MobileOrderIssueRestrictionProfile_restriction_id.SelectedValue);
        else
            e.InputParameters.Add("x_sRestriction_id", string.Empty);
    }
    protected void MobileOrderIssueRestrictionProfileGV_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        if (e.RowIndex != -1)
        {
            GridView _oGridView = (GridView)sender;
            GridViewRow _oGridViewRow = (GridViewRow)_oGridView.Rows[e.RowIndex];
            Literal _oCdate = (Literal)_oGridViewRow.FindControl("MobileOrderIssueRestrictionProfile_cdate");
            if (_oCdate.Text != string.Empty)
            {
                DateTime _dCdate;
                if (DateTime.TryParseExact(_oCdate.Text, _oFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dCdate))
                    e.NewValues["MobileOrderIssueRestrictionProfile_cdate"] = _dCdate;
                else
                    e.NewValues["MobileOrderIssueRestrictionProfile_cdate"] = null;
            }
        }
    }
}
