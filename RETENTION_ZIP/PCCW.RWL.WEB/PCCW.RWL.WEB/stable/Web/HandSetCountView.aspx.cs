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
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using log4net;
using System.Reflection;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

public partial class HandSetCountView : NEURON.WEB.UI.BasePage
{
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion
    string n_sTeamcode = string.Empty;
    string n_sChannel = string.Empty;
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
            InitFrame();
            InitLoadChannel();
        }
    }

    #region InitFrame
    protected void InitFrame()
    {
        log_date.Text = DateTime.Now.ToString("MM/dd/yyyy");
        log_date2.Text = DateTime.Now.ToString("MM/dd/yyyy");
        hs_model.Items.Clear();
        hs_model.Items.Add(new ListItem("ALL", "ALL"));
        List<string> _oHs_modelList = MobileRetentionOrderBal.DrpHsmodelList();
        for (int i = 0; i < _oHs_modelList.Count; i++)
            hs_model.Items.Add(new ListItem(_oHs_modelList[i].ToString(), _oHs_modelList[i].ToString()));

        premium.Items.Clear();
        premium.Items.Add(new ListItem("ALL", "ALL"));
        List<string> _oPremiumList = MobileRetentionOrderBal.DrpPremiumList();
        for (int i = 0; i < _oPremiumList.Count; i++)
            premium.Items.Add(new ListItem(_oPremiumList[i].ToString(), _oPremiumList[i].ToString()));

        salesman_code.Items.Clear();
        salesman_code.Items.Add(new ListItem(string.Empty, string.Empty));
        List<string> _oSalesmancodeList = MobileRetentionOrderBal.DrpSalemancodeList();
        for (int i = 0; i < _oSalesmancodeList.Count; i++)
            salesman_code.Items.Add(new ListItem(_oSalesmancodeList[i].ToString(), _oSalesmancodeList[i].ToString()));
        if (salesman_code.SelectedItem == null)
            salesman_code.SelectedIndex = 0;

    }
    #endregion

    #region load_channel
    public void InitLoadChannel()
    {
        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT teamcode FROM [CSSDB].[csc].[staffinfo_new] WHERE active=1 AND staff_no2='" + RWLFramework.CurrentUser[this.Page].Uid + "' AND active=1 AND (edate is null or edate > getdate()-1) AND sdate<=getdate()");
        if (_oDr.Read())
            n_sTeamcode = _oDr["teamcode"].ToString();
        if (_oDr != null) _oDr.Close(); _oDr.Dispose();
        _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT channel FROM [CSSDB].[dbo].[channel_team_map] WHERE active=1 AND teamcode='" + n_sTeamcode + "'");
        if (_oDr.Read())
            n_sChannel = _oDr["channel"].ToString();
        load_channel(n_sChannel);
        if (_oDr != null) _oDr.Close(); _oDr.Dispose();
    }


    public void load_channel(string x_sChannel)
    {

        string _scriptText = "<script type=\"text/javascript\">";
        _scriptText += "function load_channel(){";
        if ("10".Equals(RWLFramework.CurrentUser[this.Page].Lv) || "4".Equals(RWLFramework.CurrentUser[this.Page].Lv))
        {
            _scriptText += "	if(\"IB\"==\"" + x_sChannel + "\"){";
            _scriptText += "		document.getElementById(\"form1\").channel[0].disabled=true";
            _scriptText += "		document.getElementById(\"form1\").channel[1].checked=true";
            _scriptText += "		document.getElementById(\"form1\").channel[2].disabled=true";
            _scriptText += "		document.getElementById(\"form1\").channel[3].disabled=true";
            _scriptText += "		document.getElementById(\"form1\").channel[4].disabled=true";
            _scriptText += "	}";
            _scriptText += "	else if(\"OB\"==\"" + x_sChannel + "\"){";
            _scriptText += "		document.getElementById(\"form1\").channel[0].disabled=true";
            _scriptText += "		document.getElementById(\"form1\").channel[1].disabled=true";
            _scriptText += "		document.getElementById(\"form1\").channel[2].checked=true";
            _scriptText += "		document.getElementById(\"form1\").channel[3].disabled=true";
            _scriptText += "		document.getElementById(\"form1\").channel[4].disabled=true";
            _scriptText += "	}";
            _scriptText += "	else if(\"IMS\"==\"" + x_sChannel + "\"){";
            _scriptText += "		document.getElementById(\"form1\").channel[0].disabled=true";
            _scriptText += "		document.getElementById(\"form1\").channel[1].disabled=true";
            _scriptText += "		document.getElementById(\"form1\").channel[2].disabled=true";
            _scriptText += "		document.getElementById(\"form1\").channel[3].checked=true";
            _scriptText += "		document.getElementById(\"form1\").channel[4].disabled=true";
            _scriptText += "	}";
            _scriptText += "	else";
            _scriptText += "		document.getElementById(\"form1\").channel[0].checked=true";
        }

        _scriptText += "}";
        _scriptText += "</script>";

        load_channel_script.Text = _scriptText;
    }
    #endregion
    
    public void Rr(string x_sCode)
    {
        Response.Write(x_sCode);
    }

    #region GetDB
    protected MSSQLConnect GetDB()
    {
        MSSQLConnect _oDB = new MSSQLConnect();
        _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
        _oDB.bWithNoLock = true;
        return _oDB;
    }
    #endregion

    #region Get Oracle DB
    protected ODBCConnect GetORDB()
    {
        ODBCConnect _oDB = new ODBCConnect();
        _oDB.SetConnStr(Configurator.DBName.ORADNS+((Configurator.IsUat()) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion

}
