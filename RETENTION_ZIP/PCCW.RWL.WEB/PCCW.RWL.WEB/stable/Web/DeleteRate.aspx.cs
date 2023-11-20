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
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;


public partial class DeleteRate : NEURON.WEB.UI.BasePage
{
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
        try
        {
            if (!IsPostBack) { InitFrame(); }
        }
        catch (Exception exp)
        {
            Logger.ErrorFormat("DeleteRate ERROR :{0}", exp.ToString());
            Response.Redirect("MobileRetentionMain.aspx");
        }
    }

    protected void InitFrame()
    {
        string _sQuery = "SELECT  distinct channel FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder WITH (nolock)";
        SqlDataReader _oDr3 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
        while (_oDr3.Read())
        {
            wr("<table width=\"100%\" border=\"0\" cellpadding=\"3\" cellspacing=\"1\" class=\"forumline\">");
            wr("<TR>");
            wr("<th colspan=\"10\">", _oDr3["channel"].ToString(), "Cancellation Rate</th>");
            wr("</TR>");
            wr("<TR>");
            wr("<TD  class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">Month</span></TD>");
            wr("<TD  class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">Total");
            wr("Order </span></TD>");
            wr("<TD  class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">Cancelled");
            wr("Order </span></TD>");
            wr("<TD  class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">Cancellation Rate</span></TD>");
            wr("</TR>");

            _sQuery = "SELECT  distinct salesmancode FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder WITH (nolock) where channel='" + _oDr3["channel"].ToString().Trim() + "'";
            SqlDataReader _oDr4 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
            wr("<TR>");
            string _sSalesmancode = string.Empty;
            if (_oDr4.Read())
            {
                _sSalesmancode=(!Convert.IsDBNull(_oDr4[MobileRetentionOrder.Para.salesmancode]) ? _oDr4[MobileRetentionOrder.Para.salesmancode].ToString() : string.Empty);
                wr("<TD height=\"15\" colspan=\"4\" class=\"row1\"><span class=\"gensmall\"><b>", _sSalesmancode, "</b></span></TD>");
            }
            else
            {
                wr("<TD height=\"15\" colspan=\"4\" class=\"row1\"><span class=\"gensmall\"><b></b></span></TD>");
            }
            wr("</TR>");
            if(_oDr4!=null) _oDr4.Close();
            _sQuery = "SELECT  DATEDIFF(m,'" + DateTime.Now.ToString("dd/MM/yyyy") + "',log_date) as date_diff, count(1) as count FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where channel='" + _oDr3["channel"].ToString().Trim() + "' and salesmancode='" + _sSalesmancode + "' group by DATEDIFF(m,'" + DateTime.Now.ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(m,'" + DateTime.Now.ToString("dd/MM/yyyy") + "',log_date) ";
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

            _sQuery = "SELECT  DATEDIFF(m,'" + DateTime.Now.ToString("dd/MM/yyyy") + "',log_date) as date_diff, count(1) as count FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=0 and channel='" + _oDr3["channel"].ToString().Trim() + "' and salesmancode='" + _sSalesmancode + "' group by DATEDIFF(m,'" + DateTime.Now.ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(m,'" + DateTime.Now.ToString("dd/MM/yyyy") + "',log_date) ";
            SqlDataReader _oDr2 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

            while (_oDr.Read())
            {
                wr("<TR>");
                string _sDateAdd = string.Empty;
                if (Func.IsParseDateTime(_oDr["date_diff"].ToString()))
                {
                    DateTime _dDataAdd = DateTime.Now.AddMonths(Convert.ToInt32(_oDr["date_diff"].ToString()));
                    _sDateAdd = _dDataAdd.ToString("MMM yyyy");
                }
                wr("<TD  class=\"row2\"><span class=\"gensmall\">", _sDateAdd.Trim(), "</span></TD>");
                wr("<TD  class=\"row2\"><span class=\"gensmall\">", _oDr["count"].ToString().Trim(), "</span></TD>");
                string _sCnt = "0";
                if (_oDr2.Read())
                {
                    if (!Convert.IsDBNull(_oDr["count"]) && !Convert.IsDBNull(_oDr2["count"]))
                    {
                        if (_oDr["count"].ToString().Trim() == _oDr2["count"].ToString().Trim())
                        {
                            _sCnt = _oDr2["count"].ToString().Trim();
                        }
                    }
                }

                double _dCnt = Convert.ToDouble(_sCnt);
                double _dRound = (_dCnt / Convert.ToDouble(_oDr["count"].ToString())) * 100.0;
                wr("<TD  class=\"row2\"><span class=\"gensmall\">", _sCnt, "</span></TD>");
                wr("<TD  class=\"row2\"><span class=\"gensmall\">", Math.Round(_dRound, 2).ToString(), "%</span></TD>");
                wr("</TR>");
            }
            if(_oDr!=null) _oDr.Close();
            if(_oDr2!=null) _oDr2.Close();

            wr("<TR>");
            wr("<TD height=\"20\" colspan=\"4\" class=\"row3\" align=\"center\"><span class=\"gensmall\"><b>");
            wr("Summary</b></span></TD>");
            wr("</TR>");

            _sQuery = "SELECT  DATEDIFF(m,'" + DateTime.Now.ToString("dd/MM/yyyy") + "',log_date) as date_diff, count(1) as count FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where channel='" + _oDr3["channel"].ToString() + "' group by DATEDIFF(m,'" + DateTime.Now.ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(m,'" + DateTime.Now.ToString("dd/MM/yyyy") + "',log_date) ";
            _oDr.Close();
            _oDr.Dispose();
            _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

            _sQuery = "SELECT  DATEDIFF(m,'" + DateTime.Now.ToString("dd/MM/yyyy") + "',log_date) as date_diff, count(1) as count FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=0 and channel='" + _oDr3["channel"].ToString() + "' group by DATEDIFF(m,'" + DateTime.Now.ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(m,'" + DateTime.Now.ToString("dd/MM/yyyy") + "',log_date) ";
            _oDr2.Close();
            _oDr2.Dispose();
            _oDr2 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

            while (_oDr.Read())
            {
                wr("<TR>");
                string _sDateAdd = string.Empty;
                if (Func.IsParseInt(_oDr["date_diff"].ToString()))
                {
                    DateTime _dDataAdd = DateTime.Now.AddMonths(Convert.ToInt32(_oDr["date_diff"].ToString()));
                    _sDateAdd = _dDataAdd.ToString("MMM yyyy");
                }
                wr("<TD  class=\"row2\"><span class=\"gensmall\">", _sDateAdd, "</span></TD>");
                wr("<TD  class=\"row2\"><span class=\"gensmall\">", _oDr["count"].ToString(), "</span></TD>");
                string _sCnt = "0";
                if (_oDr2.Read())
                {
                    if (!Convert.IsDBNull(_oDr["count"]) && !Convert.IsDBNull(_oDr2["count"]))
                    {
                        if (_oDr["count"].ToString().Trim() == _oDr2["count"].ToString().Trim()){
                            _sCnt = _oDr2["count"].ToString().Trim();
                        }
                    }
                }
                double _dCnt = Convert.ToDouble(_sCnt);
                double _dRound = (_dCnt / Convert.ToDouble(_oDr["count"].ToString())) * 100.0;
                wr("<TD  class=\"row2\"><span class=\"gensmall\">", _sCnt, "</span></TD>");
                wr("<TD  class=\"row2\"><span class=\"gensmall\">", Math.Round(_dRound, 2).ToString(), "%</span></TD>");
                wr("</TR>");
            }
            if(_oDr!=null) _oDr.Close();
            if(_oDr2!=null) _oDr2.Close();

            wr("<TR>");
            wr("<TD class=\"cat\" colspan=\"10\">&nbsp;</TD>");
            wr("</TR>");
            wr("</TABLE>");
            wr("<br>");
        }

        wr("<br>	");
        wr("<table width=\"100%\" border=\"0\" cellpadding=\"3\" cellspacing=\"1\" class=\"forumline\">");
        wr("<TR>");
        wr("<th colspan=\"10\">Total Cancellation Rate</th>");
        wr("</TR>");
        wr("<TR>");
        wr("<TD height=\"0\" class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">Month</span></TD>");
        wr("<TD height=\"0\" class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">Total");
        wr("Order </span></TD>");
        wr("<TD height=\"0\" class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">Cancelled");
        wr("Order </span></TD>");
        wr("<TD height=\"0\" class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">Cancellation Rate</span></TD>");
        wr("</TR>");
        {
            _sQuery = "SELECT  DATEDIFF(m,'" + DateTime.Now.ToString("dd/MM/yyyy") + "',log_date) as date_diff, count(1) as count FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) group by DATEDIFF(m,'" + DateTime.Now.ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(m,'" + DateTime.Now.ToString("dd/MM/yyyy") + "',log_date) ";
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
            _sQuery = "SELECT  DATEDIFF(m,'" + DateTime.Now.ToString("dd/MM/yyyy") + "',log_date) as date_diff, count(1) as count FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=0 group by DATEDIFF(m,'" + DateTime.Now.ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(m,'" + DateTime.Now.ToString("dd/MM/yyyy") + "',log_date) ";
            SqlDataReader _oDr2 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
            while (_oDr.Read())
            {
                wr("<TR>");
                string _sDateAdd = string.Empty;
                if (Func.IsParseInt(_oDr["date_diff"].ToString()))
                {
                    DateTime _dDataAdd = DateTime.Now.AddMonths(Convert.ToInt32(_oDr["date_diff"].ToString()));
                    _sDateAdd = _dDataAdd.ToString("MMM yyyy");
                }
                wr("<TD  class=\"row2\"><span class=\"gensmall\">", _sDateAdd, "</span></TD>");
                wr("<TD  class=\"row2\"><span class=\"gensmall\">", _oDr["count"].ToString(), "</span></TD>");
                string _sCnt = "0";
                if (_oDr2.Read())
                {
                    if (!Convert.IsDBNull(_oDr["count"]) && !Convert.IsDBNull(_oDr2["count"]))
                    {
                        if (_oDr["count"].ToString().Trim() == _oDr2["count"].ToString().Trim())
                        {
                            _sCnt = _oDr2["count"].ToString().Trim();
                        }
                    }
                }
                double _dCnt = Convert.ToDouble(_sCnt);
                double _dRound = (_dCnt / Convert.ToDouble(_oDr["count"].ToString())) * 100.0;
                wr("<TD  class=\"row2\"><span class=\"gensmall\">", _sCnt, "</span></TD>");
                wr("<TD  class=\"row2\"><span class=\"gensmall\">", Math.Round(_dRound, 2).ToString(), "%</span></TD>");
                wr("</TR>");
            }
            if(_oDr!=null) _oDr.Close();
            if(_oDr2!=null) _oDr2.Close();
            wr("<TR>");
            wr("<TD class=\"cat\" colspan=\"10\">&nbsp;</TD>");
            wr("</TR>");
            wr("</TABLE>");
        }
        if(_oDr3!=null) _oDr3.Close();
    }

    protected void wr(params string[] x_sObj)
    {
        for (int i = 0; i < x_sObj.Length; i++)
            if (!string.IsNullOrEmpty(x_sObj[i])) { del_rate_placeholder.Controls.Add(new LiteralControl(x_sObj[i])); }
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
