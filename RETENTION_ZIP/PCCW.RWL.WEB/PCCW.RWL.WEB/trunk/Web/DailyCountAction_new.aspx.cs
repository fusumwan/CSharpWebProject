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

public partial class DailyCountAction_new : NEURON.WEB.UI.BasePage
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
            Logger.ErrorFormat("DailyCountActionNew ERROR :{0}", exp.ToString());
            Response.Redirect("MobileRetentionMain.aspx");
        }
    }

    public void InitFrame()
    {
        Nullable<DateTime> _dLog_date = WebFunc.qsLog_date;
        Nullable<DateTime> _dLog_date2 = WebFunc.qsLog_date2;
        string _dLog_date_month = Func.RQ(Request.Form["log_date_month"]).ToString();
        string _dLog_date2_month = Func.RQ(Request.Form["log_date2_month"]).ToString();
        string _sChk_logdate = Func.RQ(Request.Form["chk_logdate"]).ToString();
        string _sChk_logdate_bymonth = Func.RQ(Request.Form["chk_logdate_bymonth"]).ToString();
        int _iDay_flag = 0;
        int _iMonth_flag = 0;
        int _iCheckday = 0;
        int _iCheckmonth = 0;
        string _sD = string.Empty;

        if (_sChk_logdate_bymonth.Equals("on"))
        {
            _iCheckday = 0;
            _iCheckmonth = 1;
            _sD = "m";
        }
        else
        {
            _iCheckday = 1;
            _iCheckmonth = 0;
            _sD = "d";
        }

        if (_dLog_date_month != "" && _dLog_date2_month != "")
        {
            DateTime dt;
            int log_day_start = 1;
            int log_day_end;

            string[] Ints = _dLog_date_month.Split('/');
            string[] Ints2 = _dLog_date2_month.Split('/');

            int month = Convert.ToInt16(Ints[0]);
            int year = Convert.ToInt16(Ints[1]);
            _dLog_date = new System.DateTime(year, month, log_day_start);

            int month2 = Convert.ToInt16(Ints2[0]);
            int year2 = Convert.ToInt16(Ints2[1]);

            if (month2 == 1 || month2 == 3)
                log_day_end = 31;
            else if (month2 == 8 || month2 == 10 || month2 == 12)
                log_day_end = 31;
            else if (month2 == 2)
                log_day_end = 28;
            else
                log_day_end = 30;

            _dLog_date2 = new System.DateTime(year2, month2, log_day_end);
        }

        if (_iCheckmonth == 1)
        {
            _sD = "m";
        }
        else if (_iCheckday == 1)
        {
            _sD = "d";

        }

        if (_dLog_date != null && _dLog_date2 != null)
        {

            string _sQuery = "SELECT DISTINCT channel from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' ";
            SqlDataReader _oDr8 = SYSConn<MSSQLConn>.Connect().GetSearch(_sQuery);
            while (_oDr8.Read())
            {
                wr("<table width=\"100%\" border=\"0\" cellpadding=\"3\" cellspacing=\"1\" class=\"forumline\">");
                wr("<tr>");
                wr("<th colspan=\"100\">" + _oDr8[MobileRetentionOrder.Para.channel].ToString().Trim() + " Daily Gross Issue New</th>");
                wr("</tr>");
                wr("");
                wr("<tr>");
                wr("<td  class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">Date</span></td>");
                wr("<td  class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">Cancelled");
                wr("Order </span></td>");
                wr("<td  class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">Suspend");
                wr("Order</span></td>");
                wr("<td  class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">Normal");
                wr("Order </span></td>");
                wr("<td class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">Total");
                wr("Order </span></td>");
                wr("<td  class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">Handset");
                wr("Order </span></td>");
                wr("<td  class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">OPT");
                wr("Order </span></td>");
                wr("<td  class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">Cancelled");
                wr("Handset Order </span></td>");
                wr("<td  class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">Modification</span></td>");
                wr("</tr>");
                _sQuery = "SELECT DISTINCT salesmancode from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where channel='" + _oDr8[MobileRetentionOrder.Para.channel].ToString().Trim() + "' and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' ";
                SqlDataReader _oDr9 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
                while (_oDr9.Read())
                {
                    wr("<tr>");
                    wr("<td height=\"15\" colspan=\"10\" class=\"row3\"><span class=\"gensmall\"><b>" + Func.FR(_oDr9["salesmancode"]).ToString() + "</b></span></td>");
                    wr("</tr>");

                    double _dDate_diff = Func.DateDiff(((_iCheckday == 1) ? "day" : "month"), (DateTime)_dLog_date, (DateTime)_dLog_date2);


                    _sQuery = "SELECT DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=0 ";
                    _sQuery += "and channel='" + _oDr8[MobileRetentionOrder.Para.channel].ToString().Trim() + "' and salesmancode='" + _oDr9["salesmancode"].ToString().Trim() + "' and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                    SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                    _sQuery = "SELECT DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=1 and action_required='suspend' ";
                    _sQuery += "and channel='" + _oDr8[MobileRetentionOrder.Para.channel].ToString().Trim() + "' and salesmancode='" + _oDr9["salesmancode"].ToString().Trim() + "' and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                    SqlDataReader _oDr2 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                    _sQuery = "SELECT DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=1 and action_required<>'suspend' ";
                    _sQuery += "and channel='" + _oDr8[MobileRetentionOrder.Para.channel].ToString().Trim() + "' and salesmancode='" + _oDr9["salesmancode"].ToString().Trim() + "' and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                    SqlDataReader _oDr3 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                    _sQuery = "SELECT DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where ";
                    _sQuery += "channel='" + _oDr8[MobileRetentionOrder.Para.channel].ToString().Trim() + "' and salesmancode='" + _oDr9["salesmancode"].ToString().Trim() + "' and  log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                    SqlDataReader _oDr4 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                    _sQuery = "SELECT DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionPreviousOrder with (nolock) where ";
                    _sQuery += "channel='" + _oDr8[MobileRetentionOrder.Para.channel].ToString().Trim() + "' and salesmancode='" + _oDr9["salesmancode"].ToString().Trim() + "' and  log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                    SqlDataReader _oDr5 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                    _sQuery = "SELECT DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=1 and hs_model<>'' ";
                    _sQuery += "and channel='" + _oDr8[MobileRetentionOrder.Para.channel].ToString().Trim() + "' and salesmancode='" + _oDr9["salesmancode"].ToString().Trim() + "' and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                    SqlDataReader _oDr6 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                    _sQuery = "SELECT DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=1 and action_required='opt_out' ";
                    _sQuery += "and channel='" + _oDr8[MobileRetentionOrder.Para.channel].ToString().Trim() + "' and salesmancode='" + _oDr9["salesmancode"].ToString().Trim() + "' and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                    SqlDataReader _oDr10 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                    _sQuery = "SELECT DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=0 and hs_model<>''  ";
                    _sQuery += "and channel='" + _oDr8[MobileRetentionOrder.Para.channel].ToString().Trim() + "' and salesmancode='" + _oDr9["salesmancode"].ToString().Trim() + "' and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                    SqlDataReader _oDr7 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);


                    int _iDate_diff = -1;
                    if (_oDr.Read())
                    {
                        string _sDate_diff = Func.FR(_oDr["date_diff"]);
                        int.TryParse(_sDate_diff, out _iDate_diff);
                    }

                    int _iDate_diff2 = -1;
                    if (_oDr2.Read())
                    {
                        string _sDate_diff2 = Func.FR(_oDr2["date_diff"]);
                        int.TryParse(_sDate_diff2, out _iDate_diff2);
                    }

                    int _iDate_diff3 = -1;
                    if (_oDr3.Read())
                    {
                        string _sDate_diff3 = Func.FR(_oDr3["date_diff"]);
                        int.TryParse(_sDate_diff3, out _iDate_diff3);
                    }

                    int _iDate_diff4 = -1;
                    if (_oDr4.Read())
                    {
                        string _sDate_diff4 = Func.FR(_oDr4["date_diff"]);
                        int.TryParse(_sDate_diff4, out _iDate_diff4);
                    }

                    int _iDate_diff6 = -1;
                    if (_oDr6.Read())
                    {
                        string _sDate_diff6 = Func.FR(_oDr6["date_diff"]);
                        int.TryParse(_sDate_diff6, out _iDate_diff6);
                    }

                    int _iDate_diff10 = -1;
                    if (_oDr10.Read())
                    {
                        string _sDate_diff10 = Func.FR(_oDr10["date_diff"]);
                        int.TryParse(_sDate_diff10, out _iDate_diff10);
                    }

                    int _iDate_diff7 = -1;
                    if (_oDr7.Read())
                    {
                        string _sDate_diff7 = Func.FR(_oDr7["date_diff"]);
                        int.TryParse(_sDate_diff7, out _iDate_diff7);
                    }

                    int _iDate_diff5 = -1;
                    if (_oDr5.Read())
                    {
                        string _sDate_diff5 = Func.FR(_oDr5["date_diff"]);
                        int.TryParse(_sDate_diff5, out _iDate_diff5);
                    }


                    for (double i = 0.0; i < _dDate_diff; i += 1.0)
                    {
                        wr("<tr>");

                        string _sDateShow = string.Empty;
                        if (_iCheckday == 1)
                            _sDateShow = ((DateTime)_dLog_date).AddDays(i).ToString("MM/dd/yyyy");
                        else if (_iCheckmonth == 1)
                            _sDateShow = ((DateTime)_dLog_date).AddMonths(Convert.ToInt32(i)).ToString("MM/yyyy");

                        wr("<td  class=\"row2\"><span class=\"gensmall\" >", _sDateShow, "</span></td>");
                        wr("<td  class=\"row2\"><span class=\"gensmall\">");

                        if (_iDate_diff == i)
                        {
                            wr(_oDr["count"].ToString());
                            if (_oDr.Read())
                            {
                                string _sDate_diff = Func.FR(_oDr["date_diff"]);
                                int.TryParse(_sDate_diff, out _iDate_diff);
                            }
                        }
                        else
                            wr("0");
                        wr("</span></td>");

                        wr("<td  class=\"row2\"><span class=\"gensmall\">");
                        if (_iDate_diff2 == i)
                        {
                            wr(_oDr2["count"].ToString());
                            if (_oDr2.Read())
                            {
                                string _sDate_diff2 = Func.FR(_oDr2["date_diff"]);
                                int.TryParse(_sDate_diff2, out _iDate_diff2);
                            }
                        }
                        else
                            wr("0");
                        wr("</span></td>");

                        wr("<td  class=\"row2\"><span class=\"gensmall\">");
                        if (_iDate_diff3 == i)
                        {
                            wr(_oDr3["count"].ToString());
                            if (_oDr3.Read())
                            {
                                string _sDate_diff3 = Func.FR(_oDr3["date_diff"]);
                                int.TryParse(_sDate_diff3, out _iDate_diff3);
                            }
                        }
                        else
                            wr("0");
                        wr("</span></td>");

                        wr("<td  class=\"row2\"><span class=\"gensmall\">");
                        if (_iDate_diff4 == i)
                        {
                            wr(_oDr4["count"].ToString());
                            if (_oDr4.Read())
                            {
                                string _sDate_diff4 = Func.FR(_oDr4["date_diff"]);
                                int.TryParse(_sDate_diff4, out _iDate_diff4);
                            }
                        }
                        else
                            wr("0");
                        wr("</span></td>");

                        wr("<td  class=\"row2\"><span class=\"gensmall\">");
                        if (_iDate_diff6 == i)
                        {
                            wr(_oDr6["count"].ToString());
                            if (_oDr6.Read())
                            {
                                string _sDate_diff6 = Func.FR(_oDr6["date_diff"]);
                                int.TryParse(_sDate_diff6, out _iDate_diff6);
                            }
                        }
                        else
                            wr("0");
                        wr("</span></td>");

                        wr("<td  class=\"row2\"><span class=\"gensmall\">");
                        if (_iDate_diff10 == i)
                        {
                            wr(_oDr10["count"].ToString());
                            if (_oDr10.Read())
                            {
                                string _sDate_diff10 = Func.FR(_oDr10["date_diff"]);
                                int.TryParse(_sDate_diff10, out _iDate_diff10);
                            }
                        }
                        else
                            wr("0");
                        wr("</span></td>");

                        wr("<td  class=\"row2\"><span class=\"gensmall\">");
                        if (_iDate_diff7 == i)
                        {
                            wr(_oDr7["count"].ToString());
                            if (_oDr7.Read())
                            {
                                string _sDate_diff7 = Func.FR(_oDr7["date_diff"]);
                                int.TryParse(_sDate_diff7, out _iDate_diff7);
                            }
                        }
                        else
                            wr("0");
                        wr("</span></td>");

                        wr("<td  class=\"row2\"><span class=\"gensmall\">");
                        if (_iDate_diff5 == i)
                        {
                            wr(_oDr5["count"].ToString());
                            if (_oDr5.Read())
                            {
                                string _sDate_diff5 = Func.FR(_oDr5["date_diff"]);
                                int.TryParse(_sDate_diff5, out _iDate_diff5);
                            }
                        }
                        else
                            wr("0");
                        wr("</span></td>");
                        wr("</tr>");


                    }
                    if (_oDr != null) _oDr.Close();
                    if (_oDr2 != null) _oDr2.Close();
                    if (_oDr3 != null) _oDr3.Close();
                    if (_oDr4 != null) _oDr4.Close();
                    if (_oDr5 != null) _oDr5.Close();
                    if (_oDr6 != null) _oDr6.Close();
                    if (_oDr7 != null) _oDr7.Close();
                    if (_oDr10 != null) _oDr10.Close();
                }

                wr("<tr>");
                wr("<td height=\"20\" colspan=\"10\" class=\"row3\" align=\"center\"><span class=\"gensmall\"><b>Summary</b></span></td>");
                wr("</tr>");
                {
                    double _dDate_diff = Func.DateDiff(((_iCheckday == 1) ? "day" : "month"), (DateTime)_dLog_date, (DateTime)_dLog_date2);

                    _sQuery = "SELECT DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=0 ";
                    _sQuery += "and channel='" + _oDr8[MobileRetentionOrder.Para.channel].ToString().Trim() + "' and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                    SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                    _sQuery = "SELECT DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=1 and action_required='suspend' ";
                    _sQuery += "and channel='" + _oDr8[MobileRetentionOrder.Para.channel].ToString().Trim() + "' and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                    SqlDataReader _oDr2 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                    _sQuery = "SELECT DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=1 and action_required<>'suspend' ";
                    _sQuery += "and channel='" + _oDr8[MobileRetentionOrder.Para.channel].ToString().Trim() + "' and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                    SqlDataReader _oDr3 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                    _sQuery = "SELECT DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where ";
                    _sQuery += "channel='" + _oDr8[MobileRetentionOrder.Para.channel].ToString().Trim() + "' and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                    SqlDataReader _oDr4 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                    _sQuery = "SELECT DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionPreviousOrder with (nolock) where ";
                    _sQuery += "channel='" + _oDr8[MobileRetentionOrder.Para.channel].ToString().Trim() + "' and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                    SqlDataReader _oDr5 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                    _sQuery = "SELECT DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=1 and hs_model<>'' ";
                    _sQuery += "and channel='" + _oDr8[MobileRetentionOrder.Para.channel].ToString().Trim() + "' and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                    SqlDataReader _oDr6 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                    _sQuery = "SELECT DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=1 and action_required='opt_out' ";
                    _sQuery += "and channel='" + _oDr8[MobileRetentionOrder.Para.channel].ToString().Trim() + "' and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                    SqlDataReader _oDr10 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                    _sQuery = "SELECT DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=0 and hs_model<>''  ";
                    _sQuery += "and channel='" + _oDr8[MobileRetentionOrder.Para.channel].ToString().Trim() + "' and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                    SqlDataReader _oDr7 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);



                    int _iDate_diff1 = -1;
                    if (_oDr.Read())
                    {
                        string _sDate_diff1 = Func.FR(_oDr["date_diff"]);
                        int.TryParse(_sDate_diff1, out _iDate_diff1);
                    }

                    int _iDate_diff2 = -1;
                    if (_oDr2.Read())
                    {
                        string _sDate_diff2 = Func.FR(_oDr2["date_diff"]);
                        int.TryParse(_sDate_diff2, out _iDate_diff2);
                    }

                    int _iDate_diff3 = -1;
                    if (_oDr3.Read())
                    {
                        string _sDate_diff3 = Func.FR(_oDr3["date_diff"]);
                        int.TryParse(_sDate_diff3, out _iDate_diff3);
                    }

                    int _iDate_diff4 = -1;
                    if (_oDr4.Read())
                    {
                        string _sDate_diff4 = Func.FR(_oDr4["date_diff"]);
                        int.TryParse(_sDate_diff4, out _iDate_diff4);
                    }

                    int _iDate_diff6 = -1;
                    if (_oDr6.Read())
                    {
                        string _sDate_diff6 = Func.FR(_oDr6["date_diff"]);
                        int.TryParse(_sDate_diff6, out _iDate_diff6);
                    }

                    int _iDate_diff10 = -1;
                    if (_oDr10.Read())
                    {
                        string _sDate_diff10 = Func.FR(_oDr10["date_diff"]);
                        int.TryParse(_sDate_diff10, out _iDate_diff10);
                    }

                    int _iDate_diff7 = -1;
                    if (_oDr7.Read())
                    {
                        string _sDate_diff7 = Func.FR(_oDr7["date_diff"]);
                        int.TryParse(_sDate_diff7, out _iDate_diff7);
                    }

                    int _iDate_diff5 = -1;
                    if (_oDr5.Read())
                    {
                        string _sDate_diff5 = Func.FR(_oDr5["date_diff"]);
                        int.TryParse(_sDate_diff5, out _iDate_diff5);
                    }

                    for (double i = 0.0; i < _dDate_diff; i += 1.0)
                    {
                        wr("<tr>");
                        string _sDateShow = string.Empty;
                        if (_iCheckday == 1)
                            _sDateShow = ((DateTime)_dLog_date).AddDays(i).ToString("MM/dd/yyyy");
                        else if (_iCheckmonth == 1)
                            _sDateShow = ((DateTime)_dLog_date).AddMonths(Convert.ToInt32(i)).ToString("MM/yyyy");

                        wr("<td  class=\"row2\"><span class=\"gensmall\" >", _sDateShow, "</span></td>");
                        wr("<td  class=\"row2\"><span class=\"gensmall\">");
                        if (_iDate_diff1 == i)
                        {
                            wr(_oDr["count"].ToString());
                            if (_oDr.Read())
                            {
                                string _sDate_diff1 = Func.FR(_oDr["date_diff"]);
                                int.TryParse(_sDate_diff1, out _iDate_diff1);
                            }
                        }
                        else
                            wr("0");
                        wr("</span></td>");

                        wr("<td  class=\"row2\"><span class=\"gensmall\">");
                        if (_iDate_diff2 == i)
                        {
                            wr(_oDr2["count"].ToString());
                            if (_oDr2.Read())
                            {
                                string _sDate_diff2 = Func.FR(_oDr2["date_diff"]);
                                int.TryParse(_sDate_diff2, out _iDate_diff2);
                            }
                        }
                        else
                            wr("0");
                        wr("</span></td>");

                        wr("<td  class=\"row2\"><span class=\"gensmall\">");
                        if (_iDate_diff3 == i)
                        {
                            wr(_oDr3["count"].ToString());
                            if (_oDr3.Read())
                            {
                                string _sDate_diff3 = Func.FR(_oDr3["date_diff"]);
                                int.TryParse(_sDate_diff3, out _iDate_diff3);
                            }
                        }
                        else
                            wr("0");
                        wr("</span></td>");

                        wr("<td  class=\"row2\"><span class=\"gensmall\">");
                        if (_iDate_diff4 == i)
                        {
                            wr(_oDr4["count"].ToString());
                            if (_oDr4.Read())
                            {
                                string _sDate_diff4 = Func.FR(_oDr4["date_diff"]);
                                int.TryParse(_sDate_diff4, out _iDate_diff4);
                            }
                        }
                        else
                            wr("0");
                        wr("</span></td>");

                        wr("<td  class=\"row2\"><span class=\"gensmall\">");
                        if (_iDate_diff6 == i)
                        {
                            wr(_oDr6["count"].ToString());
                            if (_oDr6.Read())
                            {
                                string _sDate_diff6 = Func.FR(_oDr6["date_diff"]);
                                int.TryParse(_sDate_diff6, out _iDate_diff6);
                            }
                        }
                        else
                            wr("0");
                        wr("</span></td>");

                        wr("<td  class=\"row2\"><span class=\"gensmall\">");
                        if (_iDate_diff10 == i)
                        {
                            wr(_oDr10["count"].ToString());
                            if (_oDr10.Read())
                            {
                                string _sDate_diff10 = Func.FR(_oDr10["date_diff"]);
                                int.TryParse(_sDate_diff10, out _iDate_diff10);
                            }
                        }
                        else
                            wr("0");
                        wr("</span></td>");

                        wr("<td  class=\"row2\"><span class=\"gensmall\">");
                        if (_iDate_diff7 == i)
                        {
                            wr(_oDr7["count"].ToString());
                            if (_oDr7.Read())
                            {
                                string _sDate_diff7 = Func.FR(_oDr7["date_diff"]);
                                int.TryParse(_sDate_diff7, out _iDate_diff7);
                            }
                        }
                        else
                            wr("0");
                        wr("</span></td>");

                        wr("<td  class=\"row2\"><span class=\"gensmall\">");
                        if (_iDate_diff5 == i)
                        {
                            wr(_oDr5["count"].ToString());
                            if (_oDr5.Read())
                            {
                                string _sDate_diff5 = Func.FR(_oDr5["date_diff"]);
                                int.TryParse(_sDate_diff5, out _iDate_diff5);
                            }
                        }
                        else
                            wr("0");
                        wr("</span></td>");
                        wr("</tr>");
                    }
                    if (_oDr != null) _oDr.Close();
                    if (_oDr2 != null) _oDr2.Close();
                    if (_oDr3 != null) _oDr3.Close();
                    if (_oDr4 != null) _oDr4.Close();
                    if (_oDr5 != null) _oDr5.Close();
                    if (_oDr6 != null) _oDr6.Close();
                    if (_oDr7 != null) _oDr7.Close();
                    if (_oDr10 != null) _oDr10.Close();
                }
                wr("<tr>");
                wr("<td class=\"cat\" colspan=\"100\">&nbsp;</td>");
                wr("</tr>");
                wr("</table>");
                wr("<br>");
            }

            wr("<br>");
            wr("<table width=\"100%\" border=\"0\" cellpadding=\"3\" cellspacing=\"1\" class=\"forumline\">");
            wr("<tr>");
            wr("<th colspan=\"100\">Total Daily Gross issue</th>");
            wr("</tr>");
            wr("<tr>");
            wr("<td  class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">Date</span></td>");
            wr("<td  class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">Cancelled");
            wr("Order </span></td>");
            wr("<td  class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">Suspend");
            wr("Order</span></td>");
            wr("<td  class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">Normal");
            wr("Order </span></td>");
            wr("<td class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">Total");
            wr("Order </span></td>");
            wr("<td  class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">Handset");
            wr("Order </span></td>");
            wr("<td  class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">OPT");
            wr("Order </span></td>");
            wr("<td  class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">Cancelled");
            wr("Handset Order </span></td>");
            wr("<td  class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">Modification</span></td>");
            wr("</tr>");

            {
                double _dDate_diff = Func.DateDiff(((_iCheckday == 1) ? "day" : "month"), (DateTime)_dLog_date, (DateTime)_dLog_date2);

                _sQuery = "SELECT DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=0 ";
                _sQuery += "and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                _sQuery = "SELECT DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=1 and action_required='suspend' ";
                _sQuery += "and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                SqlDataReader _oDr2 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                _sQuery = "SELECT DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=1 and action_required<>'suspend' ";
                _sQuery += "and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                SqlDataReader _oDr3 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                _sQuery = "SELECT DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where ";
                _sQuery += "log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                SqlDataReader _oDr4 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                _sQuery = "SELECT DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionPreviousOrder with (nolock) where ";
                _sQuery += "log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                SqlDataReader _oDr5 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                _sQuery = "SELECT DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=1 and hs_model<>'' ";
                _sQuery += "and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                SqlDataReader _oDr6 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                _sQuery = "SELECT DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=1 and action_required='opt_out' ";
                _sQuery += "and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                SqlDataReader _oDr10 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                _sQuery = "SELECT DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=0 and hs_model<>''  ";
                _sQuery += "and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(" + _sD + ",'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                SqlDataReader _oDr7 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);



                int _iDate_diff1 = -1;
                if (_oDr.Read())
                {
                    string _sDate_diff1 = Func.FR(_oDr["date_diff"]);
                    int.TryParse(_sDate_diff1, out _iDate_diff1);
                }

                int _iDate_diff2 = -1;
                if (_oDr2.Read())
                {
                    string _sDate_diff2 = Func.FR(_oDr2["date_diff"]);
                    int.TryParse(_sDate_diff2, out _iDate_diff2);
                }

                int _iDate_diff3 = -1;
                if (_oDr3.Read())
                {
                    string _sDate_diff3 = Func.FR(_oDr3["date_diff"]);
                    int.TryParse(_sDate_diff3, out _iDate_diff3);
                }

                int _iDate_diff4 = -1;
                if (_oDr4.Read())
                {
                    string _sDate_diff4 = Func.FR(_oDr4["date_diff"]);
                    int.TryParse(_sDate_diff4, out _iDate_diff4);
                }

                int _iDate_diff6 = -1;
                if (_oDr6.Read())
                {
                    string _sDate_diff6 = Func.FR(_oDr6["date_diff"]);
                    int.TryParse(_sDate_diff6, out _iDate_diff6);
                }

                int _iDate_diff10 = -1;
                if (_oDr10.Read())
                {
                    string _sDate_diff10 = Func.FR(_oDr10["date_diff"]);
                    int.TryParse(_sDate_diff10, out _iDate_diff10);
                }

                int _iDate_diff7 = -1;
                if (_oDr7.Read())
                {
                    string _sDate_diff7 = Func.FR(_oDr7["date_diff"]);
                    int.TryParse(_sDate_diff7, out _iDate_diff7);
                }

                int _iDate_diff5 = -1;
                if (_oDr5.Read())
                {
                    string _sDate_diff5 = Func.FR(_oDr5["date_diff"]);
                    int.TryParse(_sDate_diff5, out _iDate_diff5);
                }

                for (double i = 0.0; i < _dDate_diff; i += 1.0)
                {
                    wr("<tr>");
                    string _sDateShow = string.Empty;
                    if (_iCheckday == 1)
                        _sDateShow = ((DateTime)_dLog_date).AddDays(i).ToString("MM/dd/yyyy");
                    else if (_iCheckmonth == 1)
                        _sDateShow = ((DateTime)_dLog_date).AddMonths(Convert.ToInt32(i)).ToString("MM/yyyy");

                    wr("<td  class=\"row2\"><span class=\"gensmall\" >", _sDateShow, "</span></td>");
                    wr("<td  class=\"row2\"><span class=\"gensmall\">");
                    if (_iDate_diff1 == i)
                    {
                        wr(_oDr["count"].ToString());
                        if (_oDr.Read())
                        {
                            string _sDate_diff1 = Func.FR(_oDr["date_diff"]);
                            int.TryParse(_sDate_diff1, out _iDate_diff1);
                        }
                    }
                    else
                        wr("0");
                    wr("</span></td>");

                    wr("<td  class=\"row2\"><span class=\"gensmall\">");
                    if (_iDate_diff2 == i)
                    {
                        wr(_oDr2["count"].ToString());
                        if (_oDr2.Read())
                        {
                            string _sDate_diff2 = Func.FR(_oDr2["date_diff"]);
                            int.TryParse(_sDate_diff2, out _iDate_diff2);
                        }
                    }
                    else
                        wr("0");
                    wr("</span></td>");

                    wr("<td  class=\"row2\"><span class=\"gensmall\">");
                    if (_iDate_diff3 == i)
                    {
                        wr(_oDr3["count"].ToString());
                        if (_oDr3.Read())
                        {
                            string _sDate_diff3 = Func.FR(_oDr3["date_diff"]);
                            int.TryParse(_sDate_diff3, out _iDate_diff3);
                        }
                    }
                    else
                        wr("0");
                    wr("</span></td>");

                    wr("<td  class=\"row2\"><span class=\"gensmall\">");
                    if (_iDate_diff4 == i)
                    {
                        wr(_oDr4["count"].ToString());
                        if (_oDr4.Read())
                        {
                            string _sDate_diff4 = Func.FR(_oDr4["date_diff"]);
                            int.TryParse(_sDate_diff4, out _iDate_diff4);
                        }
                    }
                    else
                        wr("0");
                    wr("</span></td>");

                    wr("<td  class=\"row2\"><span class=\"gensmall\">");
                    if (_iDate_diff6 == i)
                    {
                        wr(_oDr6["count"].ToString());
                        if (_oDr6.Read())
                        {
                            string _sDate_diff6 = Func.FR(_oDr6["date_diff"]);
                            int.TryParse(_sDate_diff6, out _iDate_diff6);
                        }
                    }
                    else
                        wr("0");
                    wr("</span></td>");

                    wr("<td  class=\"row2\"><span class=\"gensmall\">");
                    if (_iDate_diff10 == i)
                    {
                        wr(_oDr10["count"].ToString());
                        if (_oDr10.Read())
                        {
                            string _sDate_diff10 = Func.FR(_oDr10["date_diff"]);
                            int.TryParse(_sDate_diff10, out _iDate_diff10);
                        }
                    }
                    else
                        wr("0");
                    wr("</span></td>");

                    wr("<td  class=\"row2\"><span class=\"gensmall\">");
                    if (_iDate_diff7 == i)
                    {
                        wr(_oDr7["count"].ToString());
                        if (_oDr7.Read())
                        {
                            string _sDate_diff7 = Func.FR(_oDr7["date_diff"]);
                            int.TryParse(_sDate_diff7, out _iDate_diff7);
                        }
                    }
                    else
                        wr("0");
                    wr("</span></td>");

                    wr("<td  class=\"row2\"><span class=\"gensmall\">");
                    if (_iDate_diff5 == i)
                    {
                        wr(_oDr5["count"].ToString());
                        if (_oDr5.Read())
                        {
                            string _sDate_diff5 = Func.FR(_oDr5["date_diff"]);
                            int.TryParse(_sDate_diff5, out _iDate_diff5);
                        }
                    }
                    else
                        wr("0");
                    wr("</span></td>");
                    wr("</tr>");
                }


                if (_oDr != null) _oDr.Close();
                if (_oDr2 != null) _oDr2.Close();
                if (_oDr3 != null) _oDr3.Close();
                if (_oDr4 != null) _oDr4.Close();
                if (_oDr5 != null) _oDr5.Close();
                if (_oDr6 != null) _oDr6.Close();
                if (_oDr7 != null) _oDr7.Close();
                if (_oDr8 != null) _oDr8.Close();
                if (_oDr10 != null) _oDr10.Close();
            }
            wr("<tr>");
            wr("<td class=\"cat\" colspan=\"100\">&nbsp;</td>");
            wr("</tr>");
            wr("</table>");

            if (_oDr8 != null) _oDr8.Close();
        }
    }

    protected void wr(params string[] x_sObj)
    {

        for (int i = 0; i < x_sObj.Length; i++)
            if (!string.IsNullOrEmpty(x_sObj[i])) { daily_placeholder.Controls.Add(new LiteralControl(x_sObj[i])); }
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
        _oDB.SetConnStr(Configurator.DBName.ORADNS + ((Configurator.IsUat()) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion
}
