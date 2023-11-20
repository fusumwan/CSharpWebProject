using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Text;
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

public partial class Web_SimAOCase : NEURON.WEB.UI.BasePage
{
    MSSQLConnect n_oDB = null;
    private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
    string[] n_sDateTimeList = { "M/dd/yyyy", "MM/d/yyyy", "M/d/yyyy", "M/dd/yyyy hh:mm:ss", "MM/d/yyyy hh:mm:ss", "M/d/yyyy hh:mm:ss" }; 
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

        if (!IsPostBack) { InitFrame(); }
    }

    protected void InitFrame()
    {
        RWLFramework.DataBaseConfigSetting();
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.AppendLine("SELECT order_id,mrt_no,sim_item_name, sim_item_number,sim_item_code FROM MobileRetentionOrder WHERE ");
        _oQuery.AppendLine("(sim_item_code<>'' AND sim_item_code is not null) AND active=1 AND ");
        _oQuery.AppendLine("(sim_item_number='' OR sim_item_number is null OR sim_item_number='AO') ORDER BY sim_item_code,cdate desc");

        SimAoGV.DataSource = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
        SimAoGV.DataBind();
    }
    public static int AddOne(int x_iRow)
    {
        return x_iRow + 1;
    }
}
