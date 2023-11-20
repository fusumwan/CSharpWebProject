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
using DnaExpress.Web.UI.WebControls;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using System.Globalization;


public partial class Web_ProgramRebateMapping : System.Web.UI.Page
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
    static DataSet ProgramDS = null;
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
        if (!IsPostBack) InitFrame();
        ProgramRebateMappingObj.ConnectionString = SYSConn<MSSQLConnect>.Connect().ConnectionStr;

        Session["ProgramRebateMappingSql"] = "SELECT [id], [program], [issue_type], [use_rebate_mapping],  [active], CONVERT(nvarchar(30),edate,103) ,  CONVERT(nvarchar(30),sdate,103) FROM [ProgramRebateMapping]";

    }

    public void InitFrame()
    {
        program.DataSource = BusinessTradeBal.DsProgramList(true);
        program.DataBind();
    }


    public DataSet ProgramDataBind()
    {
        if (ProgramDS == null)
        {
            ProgramDS = BusinessTradeBal.DsProgramList(true);
        }
        return ProgramDS;
    }


    protected void AspxProgramRebateMappingGV_Init(object sender, EventArgs e)
    {

    }
    protected void ProgramRebateMappingObj_Init(object sender, EventArgs e)
    {
        ProgramRebateMappingObj.ConnectionString = SYSConn<MSSQLConnect>.Connect().ConnectionStr;
    }
    protected void SubmitBtn_Click(object sender, EventArgs e)
    {
        ProgramRebateMapping _oProgramRebateMapping = new ProgramRebateMapping(SYSConn<MSSQLConnect>.Connect());
        _oProgramRebateMapping.SetActive(true);
        _oProgramRebateMapping.SetCdate(DateTime.Now);
        _oProgramRebateMapping.SetUse_rebate_mapping(use_rebate_mapping.Checked);
        _oProgramRebateMapping.SetProgram(program.SelectedValue);
        _oProgramRebateMapping.SetIssue_type(issue_type.SelectedValue);

        DateTime _dSdate;
        if (DateTime.TryParseExact(sdate.DateTimeValue, _oFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dSdate))
            _oProgramRebateMapping.SetSdate(_dSdate);

        DateTime _dEdate;
        if (DateTime.TryParseExact(edate.DateTimeValue, _oFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dEdate))
            _oProgramRebateMapping.SetEdate(_dEdate);

        if (ProgramRebateMappingRepository.Insert(SYSConn<MSSQLConnect>.Connect(), _oProgramRebateMapping))
        {
            RegisterJavaScript(string.Empty, "jAlert('Create Success!','System Message');", true);
            AspxProgramRebateMappingGV.DataBind();
        }

    }

    #region RegisterJavaScript
    protected void RegisterJavaScript(string x_sID, string x_sScript, bool x_bIncludeScript)
    {
        if (x_bIncludeScript) x_sScript = "<script>" + x_sScript + "</script>";
        ScriptManager.RegisterStartupScript(this.Page, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), x_sScript, false);
    }
    #endregion
    protected void AspxProgramRebateMappingGV_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        if (e.RowIndex != -1)
        {
            GridView _oGridView = (GridView)sender;
            GridViewRow _oGridViewRow = (GridViewRow)_oGridView.Rows[e.RowIndex];
            TextBox _oSdate = (TextBox)_oGridViewRow.FindControl("sdate");
            TextBox _oEdate = (TextBox)_oGridViewRow.FindControl("edate");

            if (!string.IsNullOrEmpty(_oSdate.Text))
            {
                DateTime _dSdate;
                if (DateTime.TryParseExact(_oSdate.Text, _oFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dSdate))
                    e.NewValues["sdate"] = _dSdate;
                else
                    e.NewValues["sdate"] = null;
            }

            if (!string.IsNullOrEmpty(_oEdate.Text))
            {
                DateTime _dEdate;
                if (DateTime.TryParseExact(_oEdate.Text, _oFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dEdate))
                    e.NewValues["edate"] = _dEdate;
                else
                    e.NewValues["edate"] = null;
            }
        }
    }
}
