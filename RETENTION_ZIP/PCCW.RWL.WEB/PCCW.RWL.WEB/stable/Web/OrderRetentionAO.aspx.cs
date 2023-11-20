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

public partial class OrderRetentionAO : NEURON.WEB.UI.BasePage
{

    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion
    EDFAOControler n_oEDFAOControler = new EDFAOControler();
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
        WebFunc.PrivilegeCheck(this.Page);
        if (!IsPostBack) InitFrame();
        
    }

    #region InitFrame
    protected void InitFrame()
    {
        ao_placeholder.Controls.Clear();
        wr("<table width=\"100%\" border=\"0\" cellpadding=\"3\" cellspacing=\"1\" class=\"forumline\">");
        wr("<tr>");
        wr("<th height=\"29\" colspan=\"20\">AO Case</th>");
        wr("</tr>");
        wr("<tr>");
        wr("<td height=\"0\" class=\"row2\" colspan=\"20\">&nbsp; </td>");
        wr("</tr>");
        wr("<tr>");
        wr("<td  height=\"0\" class=\"row1\">&nbsp;</td>");
        wr("<td height=\"0\" class=\"row1\"><span class=\"explaintitle\">Record ID </span></td>");
        
        wr("<td height=\"0\" class=\"row1\"><span class=\"explaintitle\">SKU</span></td>");
        wr("<td  height=\"0\" class=\"row1\"><span class=\"explaintitle\">HS Model</span></td>");
        wr("<td  height=\"0\" class=\"row1\"><span class=\"explaintitle\">Salesman ID</span></td>");
        wr("<td  height=\"0\" class=\"row1\"><span class=\"explaintitle\">Salesman Name</span></td>");
        wr("<td  height=\"0\" class=\"row1\"><span class=\"explaintitle\">Salesman Code</span></td>");
        wr("<td  height=\"0\" class=\"row1\"><span class=\"explaintitle\">MRT</span></td>");
        wr("<td height=\"0\" class=\"row1\"><span class=\"explaintitle\">Log date</span></td>");
        wr("<td  height=\"0\" class=\"row1\"><span class=\"explaintitle\">Expected Delivery Date</span></td>");
        wr("<td  height=\"0\" class=\"row1\"><span class=\"explaintitle\">Status</span></td>");
        if ("65535".Equals(RWLFramework.CurrentUser[this.Page].Lv))
            wr("<td  height=\"0\" class=\"row1\"><span class=\"explaintitle\">Queue</span></td>");

        wr("<td  height=\"0\" class=\"row1\"><span class=\"explaintitle\">Follow Up</span></td>");
        wr("</tr>");
        try
        {
            List<string> _oCodeList = n_oEDFAOControler.GetAoHtmlCode(RWLFramework.CurrentUser[this.Page].Uid, RWLFramework.CurrentUser[this.Page].Lv);
            for (int i = 0; i < _oCodeList.Count; i++)
                wr(_oCodeList[i].ToString());
        }
        catch (Exception exp)
        {
            string _sError = exp.ToString();

        }
       wr("</table>");
    }
    #endregion

    protected void wr(params string[] x_sObj)
    {
        for (int i = 0; i < x_sObj.Length; i++)
            if (!string.IsNullOrEmpty(x_sObj[i])) { ao_placeholder.Controls.Add(new LiteralControl(x_sObj[i])); }
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
