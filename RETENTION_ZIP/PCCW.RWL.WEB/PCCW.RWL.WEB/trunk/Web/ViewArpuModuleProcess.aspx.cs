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

public partial class ViewArpuModuleProcess : NEURON.WEB.UI.BasePage
{

    private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
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
        if (!IsPostBack) InitFrame();
    }

    public bool ChkRS(SqlDataReader x_oRs, string x_sFieldName)
    {
        if (x_oRs != null && !string.IsNullOrEmpty(x_sFieldName))
        {
            if (x_oRs.GetOrdinal("date_diff") >= 0)
            {
                if (!x_oRs.IsDBNull(x_oRs.GetOrdinal("date_diff")))
                    return true;
            }
        }
        return false;
    }
    #region InitFrame
    public void InitFrame()
    {
        
        if (WebFunc.qsLog_date != null && WebFunc.qsLog_date2 != null)
        {
            DateTime _dLog_date = (DateTime)WebFunc.qsLog_date;
            DateTime _dLog_date2 = (DateTime)WebFunc.qsLog_date2;

            double _dDate_diff = Func.DateDiff("day", _dLog_date, _dLog_date2);
            string _sStr_report_date = _dLog_date.ToString("MM/dd/yyyy");
            string _sStr_ereport_date = _dLog_date2.ToString("MM/dd/yyyy");
            DateTime _dStr_report_date = _dLog_date;
            DateTime _dStr_ereport_date = _dLog_date2;

            string _sQuery = "SELECT distinct channel from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where log_date>='" + _dLog_date.ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + _dLog_date2.ToString("dd/MM/yyyy") + " 23:59:59' and (action_required='' or action_required is null) ";
            SqlDataReader _oDr8 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
            if (_oDr8.Read())
            {
                string _sChannel = (!Func.IsDBNullOrEmpty(_oDr8[MobileRetentionOrder.Para.channel])) ? _oDr8[MobileRetentionOrder.Para.channel].ToString().Trim() : string.Empty;
                wr("<table width=\"100%\" border=\"0\" cellpadding=\"3\" cellspacing=\"1\" class=\"forumline\">");
                wr("<tr>");
                wr("<th colspan=\"5\">", _sChannel, " ARPU In/Out</th>");
                wr("</tr>");
                wr("<tr>");
                wr("<td  class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">DATE</span></td>");
                wr("<td  class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">TOTAL RETAINED ORDER</span></td>");
                wr("<td  class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">ARPU");
                wr("IN</span></td>");
                wr("<td  class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">ARPU");
                wr("OUT</span></td>");
                wr("<td  class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">CHANGE");
                wr("(ARPU OUT-ARPU IN)</span></td>");
                wr("</tr>");
                _sQuery = "SELECT distinct exist_cust_plan from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=1 ";
                _sQuery += "and channel='" + _sChannel + "' and log_date>='" + _dLog_date.ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + _dLog_date2.ToString("dd/MM/yyyy") + " 23:59:59'  and (action_required='' or action_required is null) ";
                _sQuery += " order by exist_cust_plan";
                SqlDataReader _oDr5 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
                string _sExist_cust_plan = string.Empty;
                if (_oDr5.Read())
                {
                    _sExist_cust_plan = (!Func.IsDBNullOrEmpty(_oDr5[MobileRetentionOrder.Para.exist_cust_plan])) ? _oDr5[MobileRetentionOrder.Para.exist_cust_plan].ToString().Trim() : string.Empty;
                    wr("<tr>");
                    wr("<td class=\"row3\" colspan=\"5\"><span class=\"explaintitle\">", _sExist_cust_plan, "</span></td>");
                    wr("</tr>");
                    _sQuery = "SELECT DATEDIFF(d,'" + _dLog_date.ToString("dd/MM/yyyy") + "',a.log_date)/7 as date_diff,";
                    _sQuery += " sum(b.org_fee) as sum_org_fee, sum((((convert(int,a.con_per)-convert(int,d.mon))*convert(int,c.plan_fee))-convert(int,d.fee))/convert(int,a.con_per)) as sum_fee ";
                    _sQuery += " from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder a with (nolock), " + Configurator.MSSQLTablePrefix + "TariffFeeSchedule b with (nolock), " + Configurator.MSSQLTablePrefix + "RetentionPlan c with (nolock), " + Configurator.MSSQLTablePrefix + "MobileOrderMonthlyFee d with (nolock) ";
                    _sQuery += " where d.active=1 and a.active=1 and c.active=1 and b.active=1 and a.org_fee=b.fee and a.exist_cust_plan=b.program and c.plan_code=a.rate_plan and a.free_mon<>'' and d.free_mon=a.free_mon ";
                    _sQuery += " and a.log_date>='" + _dLog_date.ToString("dd/MM/yyyy") + " 00:00:00' and a.log_date<='" + _dLog_date2.ToString("dd/MM/yyyy") + " 23:59:59' ";
                    _sQuery += " and a.exist_cust_plan='" + _sExist_cust_plan + "' and a.channel='" + _sChannel + "' and (a.action_required='' or a.action_required is null)  ";
                    _sQuery += " group by DATEDIFF(d,'" + _dLog_date.ToString("dd/MM/yyyy") + "',a.log_date)/7  order by DATEDIFF(d,'" + _dLog_date.ToString("dd/MM/yyyy") + "',a.log_date)/7";
                    SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                    _sQuery = "SELECT DATEDIFF(d,'" + _dLog_date.ToString("dd/MM/yyyy") + "',a.log_date)/7 as date_diff,";
                    _sQuery += " sum(b.org_fee) as sum_org_fee ,sum((convert(int,c.plan_fee)-convert(int,a.rebate))) as sum_fee ";
                    _sQuery += " from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder a with (nolock), " + Configurator.MSSQLTablePrefix + "TariffFeeSchedule b with (nolock), " + Configurator.MSSQLTablePrefix + "RetentionPlan c with (nolock) ";
                    _sQuery += " where a.active=1 and c.active=1 and b.active=1 and a.org_fee=b.fee and a.exist_cust_plan=b.program and c.plan_code=a.rate_plan and a.rebate<>'' ";
                    _sQuery += " and a.log_date>='" + _dLog_date.ToString("dd/MM/yyyy") + " 00:00:00' and a.log_date<='" + _dLog_date2.ToString("dd/MM/yyyy") + " 23:59:59' ";
                    _sQuery += " and a.exist_cust_plan='" + _sExist_cust_plan + "' and a.channel='" + _sChannel + "' and (a.action_required='' or a.action_required is null)  ";
                    _sQuery += " group by DATEDIFF(d,'" + _dLog_date.ToString("dd/MM/yyyy") + "',a.log_date)/7  order by DATEDIFF(d,'" + _dLog_date.ToString("dd/MM/yyyy") + "',a.log_date)/7";
                    SqlDataReader _oDr2 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                    _sQuery = "SELECT DATEDIFF(d,'" + _dLog_date.ToString("dd/MM/yyyy") + "',a.log_date)/7 as date_diff,";
                    _sQuery += " sum(b.org_fee) as sum_org_fee, sum(c.plan_fee) as sum_fee ";
                    _sQuery += " from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder a with (nolock), " + Configurator.MSSQLTablePrefix + "TariffFeeSchedule b with (nolock), " + Configurator.MSSQLTablePrefix + "RetentionPlan c with (nolock) where a.active=1 and c.active=1 and b.active=1 ";
                    _sQuery += " and a.org_fee=b.fee and a.exist_cust_plan=b.program and c.plan_code=a.rate_plan and ((a.free_mon=' ' or a.free_mon is null) and (a.rebate is null or a.rebate=' ')) ";
                    _sQuery += " and a.log_date>='" + _dLog_date.ToString("dd/MM/yyyy") + " 00:00:00' and a.log_date<='" + _dLog_date2.ToString("dd/MM/yyyy") + " 23:59:59' ";
                    _sQuery += " and a.exist_cust_plan='" + _sExist_cust_plan + "' and a.channel='" + _sChannel + "' and (a.action_required='' or a.action_required is null)  ";
                    _sQuery += " group by DATEDIFF(d,'" + _dLog_date.ToString("dd/MM/yyyy") + "',a.log_date)/7  order by DATEDIFF(d,'" + _dLog_date.ToString("dd/MM/yyyy") + "',a.log_date)/7";
                    SqlDataReader _oDr3 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                    _sQuery = "SELECT DATEDIFF(d,'" + _dLog_date.ToString("dd/MM/yyyy") + "',log_date)/7 as date_diff, count(1) as num_sum from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=1 ";
                    _sQuery += " and exist_cust_plan='" + _sExist_cust_plan + "' and channel='" + _sChannel + "' and log_date>='" + _dLog_date.ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + _dLog_date2.ToString("dd/MM/yyyy") + " 23:59:59'  and (action_required='' or action_required is null) ";
                    _sQuery += " group by DATEDIFF(d,'" + _dLog_date.ToString("dd/MM/yyyy") + "',log_date)/7  order by DATEDIFF(d,'" + _dLog_date.ToString("dd/MM/yyyy") + "',log_date)/7";
                    SqlDataReader _oDr4 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                    bool _bDr = false;
                    bool _bDr2 = false;
                    bool _bDr3 = false;
                    bool _bDr4 = false;

                    for (double i = 0.0; i < _dDate_diff; i += 1.0){

                        if (i == 0.0)
                        {
                            _bDr=_oDr.Read();
                            _bDr2=_oDr2.Read();
                            _bDr3=_oDr3.Read();
                            _bDr4=_oDr4.Read();
                        }
                        wr("<tr>");
                        wr("<td  class=\"row2\"><span class=\"gensmall\">", _dStr_report_date.AddDays(7 * i).ToString("MM/dd/yyyy"));
                        if (i == _dDate_diff)
                            wr(" "+_sStr_ereport_date);
                        else
                            wr(" "+_dStr_report_date.AddDays(-1).AddDays(7 * (i + 1)).ToString("MM/dd/yyyy"));
                        wr("</span></td>");
                        wr("<td class=\"row2\"><span class=\"gensmall\">");
                        int _iSum = 0;
                        if (_oDr4.HasRows && _bDr4)
                        {
                            if (ChkRS(_oDr4, "date_diff") && ChkRS(_oDr4, "num_sum"))
                            {
                                if (!Func.IsDBNullOrEmpty(_oDr4["date_diff"]) && !Func.IsDBNullOrEmpty(_oDr4["num_sum"]))
                                    if (_oDr4["date_diff"].ToString() == i.ToString()) _iSum = Convert.ToInt32(_oDr4["num_sum"].ToString());
                            }
                        }
                        wr(_iSum.ToString());

                        wr("</span></td>");
                        wr("<td class=\"row2\"><span class=\"gensmall\">");

                        int _iCnt1 = 0;
                        int _iCnt2 = 0;
                        int _iCnt3 = 0;
                        int _iArpu_in = 0;

                        if (_oDr4.HasRows)
                        {
                            if (_oDr.HasRows && _bDr)
                            {
                                if (ChkRS(_oDr, "date_diff") && ChkRS(_oDr, "sum_org_fee"))
                                {
                                    if (!Func.IsDBNullOrEmpty(_oDr["date_diff"]) && !Func.IsDBNullOrEmpty(_oDr["sum_org_fee"]))
                                        if (_oDr["date_diff"].ToString() == i.ToString()) _iCnt1 = Convert.ToInt32(_oDr["sum_org_fee"].ToString());
                                }
                            }
                            if (_oDr2.HasRows && _bDr2)
                            {
                                if (ChkRS(_oDr2, "date_diff") && ChkRS(_oDr2, "sum_org_fee"))
                                {
                                    if (!Func.IsDBNullOrEmpty(_oDr2["date_diff"]) && !Func.IsDBNullOrEmpty(_oDr2["sum_org_fee"]))
                                        if (_oDr2["date_diff"].ToString() == i.ToString()) _iCnt2 = Convert.ToInt32(_oDr2["sum_org_fee"].ToString());
                                }
                            }
                            if (_oDr3.HasRows && _bDr3)
                            {
                                if (ChkRS(_oDr3, "date_diff") && ChkRS(_oDr3, "sum_org_fee"))
                                {
                                    if (!Func.IsDBNullOrEmpty(_oDr3["date_diff"]) && !Func.IsDBNullOrEmpty(_oDr3["sum_org_fee"]))
                                        if (_oDr3["date_diff"].ToString() == i.ToString()) _iCnt3 = Convert.ToInt32(_oDr3["sum_org_fee"].ToString());
                                }
                            }
                            if (_iSum != 0)
                            {
                                _iArpu_in = Convert.ToInt32(Math.Round((Convert.ToDouble(_iCnt1) + Convert.ToDouble(_iCnt2) + Convert.ToDouble(_iCnt3)) / Convert.ToDouble(_iSum), 2));
                                wr(_iArpu_in.ToString());
                            }
                            else
                            {
                                wr("NA");
                            }
                        }
                        wr("</span></td>");
                        wr("<td   class=\"row2\"><span class=\"gensmall\">");

                        _iCnt1 = 0;
                        _iCnt2 = 0;
                        _iCnt3 = 0;
                        int _iArpu_out = 0;

                        if (_oDr4.HasRows)
                        {
                            if (_oDr.HasRows && _bDr)
                            {
                                if (ChkRS(_oDr, "date_diff") && ChkRS(_oDr, "sum_fee"))
                                {
                                    if (!Func.IsDBNullOrEmpty(_oDr["date_diff"]) && !Func.IsDBNullOrEmpty(_oDr["sum_fee"]))
                                    {
                                        if (_oDr["date_diff"].ToString() == i.ToString()) _iCnt1 = Convert.ToInt32(_oDr["sum_fee"].ToString());
                                        _bDr=_oDr.Read();
                                    }
                                }
                            }
                            if (_oDr2.HasRows && _bDr2)
                            {
                                if (ChkRS(_oDr2, "date_diff") && ChkRS(_oDr2, "sum_fee"))
                                {
                                    if (!Func.IsDBNullOrEmpty(_oDr2["date_diff"]) && !Func.IsDBNullOrEmpty(_oDr2["sum_fee"]))
                                    {
                                        if (_oDr2["date_diff"].ToString() == i.ToString()) _iCnt2 = Convert.ToInt32(_oDr2["sum_fee"].ToString());
                                        _bDr2= _oDr2.Read();
                                    }
                                }
                            }
                            if (_oDr3.HasRows && _bDr3)
                            {
                                if (ChkRS(_oDr3, "date_diff") && ChkRS(_oDr3, "sum_fee"))
                                {
                                    if (!Func.IsDBNullOrEmpty(_oDr3["date_diff"]) && !Func.IsDBNullOrEmpty(_oDr3["sum_fee"]))
                                    {
                                        if (_oDr3["date_diff"].ToString() == i.ToString()) _iCnt3 = Convert.ToInt32(_oDr3["sum_fee"].ToString());
                                        _bDr3 = _oDr3.Read();
                                    }
                                }
                            }
                            if (_iSum != 0)
                            {
                                _iArpu_out = Convert.ToInt32(Math.Round((Convert.ToDouble(_iCnt1) + Convert.ToDouble(_iCnt2) + Convert.ToDouble(_iCnt3)) / Convert.ToDouble(_iSum), 2));
                                wr(_iArpu_in.ToString());
                            }
                            else
                                wr("NA");

                            if (ChkRS(_oDr4, "date_diff"))
                            {
                                if (Func.IsDBNullOrEmpty(_oDr4["date_diff"]))
                                {
                                    if (_oDr4["date_diff"].ToString() == i.ToString())
                                        _bDr4 = _oDr4.Read();
                                }
                            }
                        }
                        wr("</span></td>");
                        wr("<td   class=\"row2\"><span class=\"gensmall\">", (_iArpu_out - _iArpu_in).ToString());
                        wr("</span></td>");
                        wr("</tr>");

                    }
                    if (_oDr != null) _oDr.Close(); _oDr.Close(); _bDr = false;
                    if (_oDr2 != null) _oDr2.Close(); _oDr2.Close(); _bDr2 = false;
                    if (_oDr3 != null) _oDr3.Close(); _oDr3.Dispose(); _bDr3 = false;
                    if (_oDr4 != null) _oDr4.Close(); _oDr4.Dispose(); _bDr4 = false;

                }
                wr("<tr>");
                wr("<td class=\"cat\" colspan=\"5\">&nbsp;</td>");
                wr("</tr>");
                wr("</table>");
                wr("<br>");
            }
            wr("<table width=\"100%\" border=\"0\" cellpadding=\"3\" cellspacing=\"1\" class=\"forumline\">");
            wr("<tr>");
            wr("<th colspan=\"5\">Total ARPU In/Out</th>");
            wr("</tr>");
            wr("<tr>");
            wr("<td  class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">DATE</span></td>");
            wr("<td  class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">TOTAL RETAINED ORDER</span></td>");
            wr("<td  class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">ARPU");
            wr("IN</span></td>");
            wr("<td  class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">ARPU");
            wr("OUT</span></td>");
            wr("<td  class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">CHANGE");
            wr("(ARPU OUT-ARPU IN)</span></td>");
            wr("</tr>");
            {
                _sQuery = "SELECT distinct exist_cust_plan from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=1 ";
                _sQuery += " and log_date>='" + _dLog_date.ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + _dLog_date2.ToString("dd/MM/yyyy") + " 23:59:59'  and (action_required='' or action_required is null) ";
                _sQuery += " order by exist_cust_plan";
                SqlDataReader _oDr5 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
                string _sExist_cust_plan = string.Empty;
                if (_oDr5.Read())
                {
                    _sExist_cust_plan = (!Func.IsDBNullOrEmpty(_oDr5[MobileRetentionOrder.Para.exist_cust_plan])) ? _oDr5[MobileRetentionOrder.Para.exist_cust_plan].ToString().Trim() : string.Empty;
                    wr("<tr>");
                    wr("<td class=\"row3\" colspan=\"5\"><span class=\"explaintitle\">", _sExist_cust_plan, "</span></td>");
                    wr("</tr>");

                    _sQuery = "SELECT DATEDIFF(d,'" + _dLog_date.ToString("dd/MM/yyyy") + "',a.log_date)/7 as date_diff,";
                    _sQuery += " sum(b.org_fee) as sum_org_fee, sum((((convert(int,a.con_per)-convert(int,d.mon))*convert(int,c.plan_fee))-convert(int,d.fee))/convert(int,a.con_per)) as sum_fee ";
                    _sQuery += " from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder a with (nolock), " + Configurator.MSSQLTablePrefix + "TariffFeeSchedule b with (nolock), " + Configurator.MSSQLTablePrefix + "RetentionPlan c with (nolock), " + Configurator.MSSQLTablePrefix + "MobileOrderMonthlyFee d with (nolock) ";
                    _sQuery += " where d.active=1 and a.active=1 and c.active=1 and b.active=1 and a.org_fee=b.fee and a.exist_cust_plan=b.program and c.plan_code=a.rate_plan and a.free_mon<>'' and d.free_mon=a.free_mon ";
                    _sQuery += " and a.log_date>='" + _dLog_date.ToString("dd/MM/yyyy") + " 00:00:00' and a.log_date<='" + _dLog_date2.ToString("dd/MM/yyyy") + " 23:59:59' ";
                    _sQuery += " and a.exist_cust_plan='" + _sExist_cust_plan + "' and (a.action_required='' or a.action_required is null)  ";
                    _sQuery += " group by DATEDIFF(d,'" + _dLog_date.ToString("dd/MM/yyyy") + "',a.log_date)/7  order by DATEDIFF(d,'" + _dLog_date.ToString("dd/MM/yyyy") + "',a.log_date)/7";
                    SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                    _sQuery = "SELECT DATEDIFF(d,'" + _dLog_date.ToString("dd/MM/yyyy") + "',a.log_date)/7 as date_diff,";
                    _sQuery += " sum(b.org_fee) as sum_org_fee ,sum((convert(int,c.plan_fee)-convert(int,a.rebate))) as sum_fee ";
                    _sQuery += " from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder a with (nolock), " + Configurator.MSSQLTablePrefix + "TariffFeeSchedule b with (nolock), " + Configurator.MSSQLTablePrefix + "RetentionPlan c with (nolock) ";
                    _sQuery += " where a.active=1 and c.active=1 and b.active=1 and a.org_fee=b.fee and a.exist_cust_plan=b.program and c.plan_code=a.rate_plan and a.rebate<>'' ";
                    _sQuery += " and a.log_date>='" + _dLog_date.ToString("dd/MM/yyyy") + " 00:00:00' and a.log_date<='" + _dLog_date2.ToString("dd/MM/yyyy") + " 23:59:59' ";
                    _sQuery += " and a.exist_cust_plan='" + _sExist_cust_plan + "' and (a.action_required='' or a.action_required is null)  ";
                    _sQuery += " group by DATEDIFF(d,'" + _dLog_date.ToString("dd/MM/yyyy") + "',a.log_date)/7  order by DATEDIFF(d,'" + _dLog_date.ToString("dd/MM/yyyy") + "',a.log_date)/7";
                    SqlDataReader _oDr2 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                    _sQuery = "SELECT DATEDIFF(d,'" + _dLog_date.ToString("dd/MM/yyyy") + "',a.log_date)/7 as date_diff,";
                    _sQuery += " sum(b.org_fee) as sum_org_fee, sum(c.plan_fee) as sum_fee ";
                    _sQuery += " from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder a with (nolock), " + Configurator.MSSQLTablePrefix + "TariffFeeSchedule b with (nolock), " + Configurator.MSSQLTablePrefix + "RetentionPlan c with (nolock) where a.active=1 and c.active=1 and b.active=1 ";
                    _sQuery += " and a.org_fee=b.fee and a.exist_cust_plan=b.program and c.plan_code=a.rate_plan and ((a.free_mon=' ' or a.free_mon is null) and (a.rebate is null or a.rebate=' ')) ";
                    _sQuery += " and a.log_date>='" + _dLog_date.ToString("dd/MM/yyyy") + " 00:00:00' and a.log_date<='" + _dLog_date2.ToString("dd/MM/yyyy") + " 23:59:59' ";
                    _sQuery += " and a.exist_cust_plan='" + _sExist_cust_plan + "' and (a.action_required='' or a.action_required is null)  ";
                    _sQuery += " group by DATEDIFF(d,'" + _dLog_date.ToString("dd/MM/yyyy") + "',a.log_date)/7  order by DATEDIFF(d,'" + _dLog_date.ToString("dd/MM/yyyy") + "',a.log_date)/7";
                    SqlDataReader _oDr3 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

                    _sQuery = "SELECT DATEDIFF(d,'" + _dLog_date.ToString("dd/MM/yyyy") + "',log_date)/7 as date_diff, count(1) as num_sum from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=1 ";
                    _sQuery += " and exist_cust_plan='" + _sExist_cust_plan + "' and log_date>='" + _dLog_date.ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + _dLog_date2.ToString("dd/MM/yyyy") + " 23:59:59'  and (action_required='' or action_required is null) ";
                    _sQuery += " group by DATEDIFF(d,'" + _dLog_date.ToString("dd/MM/yyyy") + "',log_date)/7  order by DATEDIFF(d,'" + _dLog_date.ToString("dd/MM/yyyy") + "',log_date)/7";
                    SqlDataReader _oDr4 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
                    bool _bDr = false;
                    bool _bDr2 = false;
                    bool _bDr3 = false;
                    bool _bDr4 = false;
                    for (double i = 0.0; i < _dDate_diff; i += 1.0)
                    {
                        if (i == 0.0)
                        {
                            _bDr=_oDr.Read();
                            _bDr2= _oDr2.Read();
                            _bDr3= _oDr3.Read();
                            _bDr4= _oDr4.Read();
                        }
                        wr("<tr>");
                        wr("<td  class=\"row2\"><span class=\"gensmall\">", _dStr_report_date.AddDays(7 * i).ToString("MM/dd/yyyy"));
                        if (i == _dDate_diff)
                            wr(" "+_sStr_ereport_date);
                        else
                            wr(" "+_dStr_report_date.AddDays(-1).AddDays(7 * (i + 1)).ToString("MM/dd/yyyy"));
                        wr("</span></td>");
                        wr("<td class=\"row2\"><span class=\"gensmall\">");
                        int _iSum = 0;
                        if (_oDr4.HasRows && _bDr4)
                        {
                            if (ChkRS(_oDr4, "date_diff") && ChkRS(_oDr4, "num_sum"))
                            {
                                if (!Func.IsDBNullOrEmpty(_oDr4["date_diff"]) && !Func.IsDBNullOrEmpty(_oDr4["num_sum"]))
                                    if (_oDr4["date_diff"].ToString() == i.ToString()) _iSum = Convert.ToInt32(_oDr4["num_sum"].ToString());
                            }
                        }
                        wr(_iSum.ToString());

                        wr("</span></td>");
                        wr("<td class=\"row2\"><span class=\"gensmall\">");
                        int _iCnt1 = 0;
                        int _iCnt2 = 0;
                        int _iCnt3 = 0;
                        int _iArpu_in = 0;

                        if (_oDr4.HasRows)
                        {
                            if (_oDr.HasRows && _bDr)
                            {
                                if (ChkRS(_oDr, "date_diff") && ChkRS(_oDr, "sum_org_fee"))
                                {
                                    if (!Func.IsDBNullOrEmpty(_oDr["date_diff"]) && !Func.IsDBNullOrEmpty(_oDr["sum_org_fee"]))
                                        if (_oDr["date_diff"].ToString() == i.ToString()) _iCnt1 = Convert.ToInt32(_oDr["sum_org_fee"].ToString());
                                }
                            }
                            if (_oDr2.HasRows && _bDr2)
                            {
                                if (ChkRS(_oDr2, "date_diff") && ChkRS(_oDr2, "sum_org_fee"))
                                {
                                    if (!Func.IsDBNullOrEmpty(_oDr2["date_diff"]) && !Func.IsDBNullOrEmpty(_oDr2["sum_org_fee"]))
                                        if (_oDr2["date_diff"].ToString() == i.ToString()) _iCnt2 = Convert.ToInt32(_oDr2["sum_org_fee"].ToString());
                                }
                            }
                            if (_oDr3.HasRows && _bDr3)
                            {
                                if (ChkRS(_oDr3, "date_diff") && ChkRS(_oDr3, "sum_org_fee"))
                                {
                                    if (!Func.IsDBNullOrEmpty(_oDr3["date_diff"]) && !Func.IsDBNullOrEmpty(_oDr3["sum_org_fee"]))
                                        if (_oDr3["date_diff"].ToString() == i.ToString()) _iCnt3 = Convert.ToInt32(_oDr3["sum_org_fee"].ToString());
                                }
                            }
                            if (_iSum != 0)
                            {
                                _iArpu_in = Convert.ToInt32(Math.Round((Convert.ToDouble(_iCnt1) + Convert.ToDouble(_iCnt2) + Convert.ToDouble(_iCnt3)) / Convert.ToDouble(_iSum), 2));
                                wr(_iArpu_in.ToString());
                            }
                            else
                            {
                                wr("NA");
                            }
                        }
                        wr("</span></td>");
                        wr("<td   class=\"row2\"><span class=\"gensmall\">");
                        _iCnt1 = 0;
                        _iCnt2 = 0;
                        _iCnt3 = 0;
                        int _iArpu_out = 0;

                        if (_oDr4.HasRows)
                        {
                            if (_oDr.HasRows && _bDr)
                            {
                                if (ChkRS(_oDr, "date_diff") && ChkRS(_oDr, "sum_fee"))
                                {
                                    if (!Func.IsDBNullOrEmpty(_oDr["date_diff"]) && !Func.IsDBNullOrEmpty(_oDr["sum_fee"]))
                                    {
                                        if (_oDr["date_diff"].ToString() == i.ToString()) _iCnt1 = Convert.ToInt32(_oDr["sum_fee"].ToString());
                                        _bDr=_oDr.Read();
                                    }
                                }
                            }
                            if (_oDr2.HasRows && _bDr2)
                            {
                                if (ChkRS(_oDr2, "date_diff") && ChkRS(_oDr2, "sum_fee"))
                                {
                                    if (!Func.IsDBNullOrEmpty(_oDr2["date_diff"]) && !Func.IsDBNullOrEmpty(_oDr2["sum_fee"]))
                                    {
                                        if (_oDr2["date_diff"].ToString() == i.ToString()) _iCnt2 = Convert.ToInt32(_oDr2["sum_fee"].ToString());
                                        _bDr2= _oDr2.Read();
                                    }
                                }
                            }
                            if (_oDr3.HasRows && _bDr3)
                            {
                                if (ChkRS(_oDr3, "date_diff") && ChkRS(_oDr3, "sum_fee"))
                                {
                                    if (!Func.IsDBNullOrEmpty(_oDr3["date_diff"]) && !Func.IsDBNullOrEmpty(_oDr3["sum_fee"]))
                                    {
                                        if (_oDr3["date_diff"].ToString() == i.ToString()) _iCnt3 = Convert.ToInt32(_oDr3["sum_fee"].ToString());
                                        _bDr3= _oDr3.Read();
                                    }
                                }
                            }
                            if (_iSum != 0)
                            {
                                _iArpu_out = Convert.ToInt32(Math.Round((Convert.ToDouble(_iCnt1) + Convert.ToDouble(_iCnt2) + Convert.ToDouble(_iCnt3)) / Convert.ToDouble(_iSum), 2));
                                wr(_iArpu_in.ToString());
                            }
                            else
                                wr("NA");

                            if (ChkRS(_oDr4, "date_diff"))
                            {
                                if (Func.IsDBNullOrEmpty(_oDr4["date_diff"]))
                                {
                                    if (_oDr4["date_diff"].ToString() == i.ToString())
                                        _oDr4.Read();
                                }
                            }
                        }
                        wr("</span></td>");
                        wr("<td   class=\"row2\"><span class=\"gensmall\">", (_iArpu_out - _iArpu_in).ToString());
                        wr("</span></td>");
                        wr("</tr>");

                    }
                    if (_oDr != null) _oDr.Close(); _oDr.Dispose(); _bDr = false;
                    if (_oDr2 != null) _oDr2.Close(); _oDr2.Dispose(); _bDr2 = false;
                    if (_oDr3 != null) _oDr3.Close(); _oDr3.Dispose(); _bDr3 = false;
                    if (_oDr4 != null) _oDr4.Close(); _oDr4.Dispose(); _bDr4 = false;
                }
                wr("<tr>");
                wr("<td class=\"cat\" colspan=\"5\">&nbsp;</td>");
                wr("</tr>");
                wr("</table>");
                wr("<br>");
                if(_oDr5!=null) _oDr5.Close();
            }
            if(_oDr8!=null) _oDr8.Close();    
        }
        
    }
    #endregion

    protected void wr(params string[] x_sObj)
    {
        for (int i = 0; i < x_sObj.Length; i++)
            if (!string.IsNullOrEmpty(x_sObj[i])) { arpu_placeholder.Controls.Add(new LiteralControl(x_sObj[i])); }
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
