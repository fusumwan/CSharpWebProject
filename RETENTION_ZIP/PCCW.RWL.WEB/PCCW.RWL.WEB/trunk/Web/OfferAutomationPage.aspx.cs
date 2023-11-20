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
using System.Globalization;

public partial class Web_OfferAutomationPage : System.Web.UI.Page
{
    string[] _oFormat = new string[] { 
        "dd/MM/yyyy", "dd/MM/yyyy HH:mm","dd/MM/yyyy H:mm","dd/MM/yyyy H:m","dd/MM/yyyy H:mm:ss","dd/MM/yyyy H:m:ss",  "dd/MM/yyyy HH:mm:ss",
        "dd/MM/yyyy tt ", "dd/MM/yyyy HH:mm tt ","dd/MM/yyyy H:mm tt","dd/MM/yyyy H:m tt","dd/MM/yyyy H:mm:ss tt","dd/MM/yyyy H:m:ss tt",  "dd/MM/yyyy HH:mm:ss tt",
        "dd/MM/yyyy tt ", "dd/MM/yyyy hh:mm tt ","dd/MM/yyyy h:mm tt","dd/MM/yyyy h:m tt","dd/MM/yyyy h:mm:ss tt","dd/MM/yyyy h:m:ss tt",  "dd/MM/yyyy hh:mm:ss tt",
        "dd/MM/yyyy tt ", "dd/MM/yyyy tt hh:mm ","dd/MM/yyyy tt h:mm","dd/MM/yyyy tt h:m","dd/MM/yyyy tt h:mm:ss","dd/MM/yyyy tt h:m:ss",  "dd/MM/yyyy tt hh:mm:ss",


        "dd/M/yyyy", "dd/M/yyyy HH:mm", "dd/M/yyyy H:mm", "dd/M/yyyy H:m","dd/M/yyyy H:mm:ss", "dd/M/yyyy H:m:ss", "dd/M/yyyy HH:mm:ss",
        "dd/M/yyyy tt", "dd/M/yyyy HH:mm tt", "dd/M/yyyy H:mm tt", "dd/M/yyyy H:m tt","dd/M/yyyy H:mm:ss tt", "dd/M/yyyy H:m:ss tt", "dd/M/yyyy HH:mm:ss tt",
        "dd/M/yyyy tt", "dd/M/yyyy hh:mm tt", "dd/M/yyyy h:mm tt", "dd/M/yyyy h:m tt","dd/M/yyyy h:mm:ss tt", "dd/M/yyyy h:m:ss tt", "dd/M/yyyy h:mm:ss tt",
        "dd/M/yyyy tt", "dd/M/yyyy hh:mm", "dd/M/yyyy tt h:mm", "dd/M/yyyy tt h:m","dd/M/yyyy tt h:mm:ss", "dd/M/yyyy tt h:m:ss", "dd/M/yyyy tt h:mm:ss",


        "dd/M/yyyy", "dd/M/yyyy HH:mm","dd/M/yyyy H:mm","dd/M/yyyy H:m","dd/M/yyyy H:mm:ss","dd/M/yyyy H:m:ss", "dd/M/yyyy HH:mm:ss",
        "dd/M/yyyy tt", "dd/M/yyyy HH:mm tt","dd/M/yyyy H:mm tt","dd/M/yyyy H:m tt","dd/M/yyyy H:mm:ss tt","dd/M/yyyy H:m:ss tt", "dd/M/yyyy HH:mm:ss tt",
        "dd/M/yyyy tt", "dd/M/yyyy hh:mm tt","dd/M/yyyy h:mm tt","dd/M/yyyy h:m tt","dd/M/yyyy h:mm:ss tt","dd/M/yyyy h:m:ss tt", "dd/M/yyyy hh:mm:ss tt",
        "dd/M/yyyy tt", "dd/M/yyyy tt hh:mm","dd/M/yyyy tt h:mm","dd/M/yyyy tt h:m","dd/M/yyyy tt h:mm:ss","dd/M/yyyy h:m:ss tt", "dd/M/yyyy tt hh:mm:ss",

        "d/M/yyyy", "d/M/yyyy HH:mm","d/M/yyyy H:mm","d/M/yyyy H:m","d/M/yyyy H:mm:ss","d/M/yyyy H:m:ss", "d/M/yyyy HH:mm:ss",
        "d/M/yyyy tt", "d/M/yyyy HH:mm tt","d/M/yyyy H:mm tt","d/M/yyyy H:m tt","d/M/yyyy H:mm:ss tt","d/M/yyyy H:m:ss tt", "d/M/yyyy HH:mm:ss tt",
        "d/M/yyyy tt", "d/M/yyyy hh:mm tt","d/M/yyyy h:mm tt","d/M/yyyy h:m tt","d/M/yyyy h:mm:ss tt","d/M/yyyy h:m:ss tt", "d/M/yyyy hh:mm:ss tt",
        "d/M/yyyy tt", "d/M/yyyy tt hh:mm","d/M/yyyy tt h:mm","d/M/yyyy tt h:m","d/M/yyyy tt h:mm:ss","d/M/yyyy tt h:m:ss", "d/M/yyyy tt hh:mm:ss"
        };
    SessionFactory<MSSQLConnect> _oSessionFactory = new SessionFactory<MSSQLConnect>();
    string Mrt = "";
    string AutoSelection = "";
    string AllPageInScreen = "";
    string ISSUE_TYPE = "";
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

        Mrt = Func.RQ(Request["mrt"]);
        AutoSelection = Func.RQ(Request["AutoSelection"]);
        AllPageInScreen = Func.RQ(Request["AllPageInScreen"]);
        ISSUE_TYPE = Func.RQ(Request["ISSUE_TYPE"]);

        RWLFramework.DataBaseConfigSetting();
        //WebFunc.PrivilegeCheck(this.Page);
        if (!IsPostBack) InitFrame();


    }

    private void InitFrame()
    {
        OfferNameDataBind();

    }

    public void OfferNameDataBind()
    {
        StringBuilder _oQuery = new StringBuilder();

        _oQuery.Append("SELECT distinct offer_name,trade_field_id FROM OfferAutomation a LEFT JOIN CallListUploadProfile b ON ");
        _oQuery.Append("a.call_list_program_id=b.call_list_program_id LEFT JOIN CallListUploadMrtNo c ");
        _oQuery.Append("ON a.call_list_program_id=c.call_list_program_id WHERE ");
        _oQuery.Append("a.active =1 AND b.active=1 AND c.mrt_no='" + Mrt + "' and b.issue_type='" + ISSUE_TYPE + "' ");



        offer_name.DataSource = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
        offer_name.DataBind();

        if (offer_name.Items.Count > 0)
            offer_name.SelectedIndex = 0;

    }


    protected void SubmitBit_Click(object sender, EventArgs e)
    {
        if (offer_name.Items.Count > 0)
            Response.Redirect("MobileRetentionOrderCreate.aspx?auto_trade_field_id=" + offer_name.SelectedValue.ToString() + "&mrt=" + Mrt + "&AutoSelection=" + AutoSelection + "&AllPageInScreen=" + AllPageInScreen + "&ISSUE_TYPE=" + ISSUE_TYPE);
    }
    protected void SkipBit_Click(object sender, EventArgs e)
    {
        Response.Redirect("MobileRetentionOrderCreate.aspx?mrt=" + Mrt + "&AutoSelection=" + AutoSelection + "&AllPageInScreen=" + AllPageInScreen + "&ISSUE_TYPE=" + ISSUE_TYPE);
    }
}
