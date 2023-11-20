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

public partial class DailyCountExport : NEURON.WEB.UI.BasePage
{
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack) InitFrame();
        WebFunc.ExportExcel(this.Page, "RetentionOrderExcelResult.xls");
    }

    public void InitFrame()
    {
        Nullable<DateTime> _dLog_date = WebFunc.qsLog_date;
        Nullable<DateTime> _dLog_date2 = WebFunc.qsLog_date2;

        if (_dLog_date != null && _dLog_date2 != null)
        {
            string _sQuery = "SELECT DISTINCT channel from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' ";
            SqlDataReader _oDr8 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
            while (_oDr8.Read())
            {
                wr("<table width=\"100%\" border=\"0\" cellpadding=\"3\" cellspacing=\"1\" class=\"forumline\">");
                wr("<tr>");
                wr("<th colspan=\"100\">" + _oDr8[MobileRetentionOrder.Para.channel].ToString() + " Gross Issue</th>");
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
                wr("<td  class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">Cancelled");
                wr("Handset Order </span></td>");
                wr("<td  class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">Modification</span></td>");
                wr("</tr>");
                _sQuery = "SELECT DISTINCT salesmancode from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where channel='" + _oDr8[MobileRetentionOrder.Para.channel].ToString().Trim() + "' and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' ";
                SqlDataReader _oDr9 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
               while(_oDr9.Read())
                {
                    double _dDate_diff = Func.DateDiff("day", (DateTime)_dLog_date, (DateTime)_dLog_date2);

                    _sQuery = "SELECT DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=0 ";
                    _sQuery += "and channel='" + _oDr8[MobileRetentionOrder.Para.channel].ToString().Trim() + "' and salesmancode='" + _oDr9["salesmancode"].ToString().Trim() + "' and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                    SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                    _sQuery = "SELECT DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=1 and action_required='suspend' ";
                    _sQuery += "and channel='" + _oDr8[MobileRetentionOrder.Para.channel].ToString().Trim() + "' and salesmancode='" + _oDr9["salesmancode"].ToString().Trim() + "' and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                    SqlDataReader _oDr2 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                    _sQuery = "SELECT DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=1 and action_required<>'suspend' ";
                    _sQuery += "and channel='" + _oDr8[MobileRetentionOrder.Para.channel].ToString().Trim() + "' and salesmancode='" + _oDr9["salesmancode"].ToString().Trim() + "' and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                    SqlDataReader _oDr3 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                    _sQuery = "SELECT DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where ";
                    _sQuery += "channel='" + _oDr8[MobileRetentionOrder.Para.channel].ToString().Trim() + "' and salesmancode='" + _oDr9["salesmancode"].ToString().Trim() + "' and  log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                    SqlDataReader _oDr4 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                    _sQuery = "SELECT DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionPreviousOrder with (nolock) where ";
                    _sQuery += "channel='" + _oDr8[MobileRetentionOrder.Para.channel].ToString().Trim() + "' and salesmancode='" + _oDr9["salesmancode"].ToString().Trim() + "' and  log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                    SqlDataReader _oDr5 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                    _sQuery = "SELECT DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=1 and hs_model<>'' ";
                    _sQuery += "and channel='" + _oDr8[MobileRetentionOrder.Para.channel].ToString().Trim() + "' and salesmancode='" + _oDr9["salesmancode"].ToString().Trim() + "' and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                    SqlDataReader _oDr6 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                    _sQuery = "SELECT DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=0 and hs_model<>''  ";
                    _sQuery += "and channel='" + _oDr8[MobileRetentionOrder.Para.channel].ToString().Trim() + "' and salesmancode='" + _oDr9["salesmancode"].ToString().Trim() + "' and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
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
                        wr("<td  class=\"row2\"><span class=\"gensmall\" >", ((DateTime)_dLog_date).AddDays(i).ToString("MM/dd/yyyy"), "</span></td>");
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
                }

                wr("<tr>");
                wr("<td height=\"20\" colspan=\"10\" class=\"row3\" align=\"center\"><span class=\"gensmall\"><b>Summary</b></span></td>");
                wr("</tr>");
                {
                    double _dDate_diff = Func.DateDiff("day", (DateTime)_dLog_date, (DateTime)_dLog_date2);
                    _sQuery = "SELECT DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=0 ";
                    _sQuery += "and channel='" + _oDr8[MobileRetentionOrder.Para.channel].ToString().Trim() + "' and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                    SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                    _sQuery = "SELECT DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=1 and action_required='suspend' ";
                    _sQuery += "and channel='" + _oDr8[MobileRetentionOrder.Para.channel].ToString().Trim() + "' and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                    SqlDataReader _oDr2 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                    _sQuery = "SELECT DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=1 and action_required<>'suspend' ";
                    _sQuery += "and channel='" + _oDr8[MobileRetentionOrder.Para.channel].ToString().Trim() + "' and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                    SqlDataReader _oDr3 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                    _sQuery = "SELECT DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where ";
                    _sQuery += "channel='" + _oDr8[MobileRetentionOrder.Para.channel].ToString().Trim() + "' and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                    SqlDataReader _oDr4 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                    _sQuery = "SELECT DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionPreviousOrder with (nolock) where ";
                    _sQuery += "channel='" + _oDr8[MobileRetentionOrder.Para.channel].ToString().Trim() + "' and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                    SqlDataReader _oDr5 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                    _sQuery = "SELECT DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=1 and hs_model<>'' ";
                    _sQuery += "and channel='" + _oDr8[MobileRetentionOrder.Para.channel].ToString().Trim() + "' and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                    SqlDataReader _oDr6 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                    _sQuery = "SELECT DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=0 and hs_model<>''  ";
                    _sQuery += "and channel='" + _oDr8[MobileRetentionOrder.Para.channel].ToString().Trim() + "' and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
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
                        wr("<td  class=\"row2\"><span class=\"gensmall\" >", ((DateTime)_dLog_date).AddDays(i).ToString("MM/dd/yyyy"), "</span></td>");
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
            wr("<td  class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">Cancelled");
            wr("Handset Order </span></td>");
            wr("<td  class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">Modification</span></td>");
            wr("</tr>");

            {
                double _dDate_diff = Func.DateDiff("day", (DateTime)_dLog_date, (DateTime)_dLog_date2);

                _sQuery = "SELECT DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=0 ";
                _sQuery += "and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                _sQuery = "SELECT DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=1 and action_required='suspend' ";
                _sQuery += "and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                SqlDataReader _oDr2 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                _sQuery = "SELECT DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=1 and action_required<>'suspend' ";
                _sQuery += "and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                SqlDataReader _oDr3 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                _sQuery = "SELECT DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where ";
                _sQuery += "log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                SqlDataReader _oDr4 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                _sQuery = "SELECT DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionPreviousOrder with (nolock) where ";
                _sQuery += "log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                SqlDataReader _oDr5 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                _sQuery = "SELECT DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=1 and hs_model<>'' ";
                _sQuery += "and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                SqlDataReader _oDr6 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                _sQuery = "SELECT DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=0 and hs_model<>''  ";
                _sQuery += "and log_date>='" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(d,'" + ((DateTime)_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                SqlDataReader _oDr7 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);



                if (_oDr != null) _oDr.Close();
                if (_oDr2 != null) _oDr2.Close();
                if (_oDr3 != null) _oDr3.Close();
                if (_oDr4 != null) _oDr4.Close();
                if (_oDr5 != null) _oDr5.Close();
                if (_oDr6 != null) _oDr6.Close();
                if (_oDr7 != null) _oDr7.Close();
                if (_oDr8 != null) _oDr8.Close();
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
        _oDB.SetConnStr(Configurator.DBName.ORADNS+((Configurator.IsUat()) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion

}
