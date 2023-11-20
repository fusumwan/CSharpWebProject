using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

public class PYReportFunc : System.Web.UI.Page
{
    public PYReportFunc() { }
    ~PYReportFunc() { }

    public static StringBuilder appendDDate_PlanEffDateToReportSQL(DateTime? x_dD_dateFrom, DateTime? x_dD_dateTo, DateTime? x_dPlan_eff_dateFrom, DateTime? x_dPlan_eff_dateTo, bool x_bUseDailyRule)
    {
        bool b_dPlan_eff_dateFrom = false;
        bool b_dPlan_eff_dateTo = false;
        if (Func.RB(x_dPlan_eff_dateFrom))
            b_dPlan_eff_dateFrom = true;
        if (Func.RB(x_dPlan_eff_dateTo))
            b_dPlan_eff_dateTo = true;

        StringBuilder _oSql = new StringBuilder();
        if (!x_bUseDailyRule)
        {
            // D_DATE
            if (Func.RB(x_dD_dateFrom))
                _oSql.Append(" and a.d_date>='" + ((DateTime)x_dD_dateFrom).ToString("yyyyMMdd") + " 00:00'");
            if (Func.RB(x_dD_dateTo))
                _oSql.Append(" and a.d_date<='" + ((DateTime)x_dD_dateTo).ToString("yyyyMMdd") + " 23:59'");

            // PLAN_EFF_DATE
            if (b_dPlan_eff_dateFrom || b_dPlan_eff_dateTo)
            {
                _oSql.Append(" and ((");
                if (b_dPlan_eff_dateFrom)
                    _oSql.Append("a.plan_eff_date>='" + ((DateTime)x_dPlan_eff_dateFrom).ToString("yyyyMMdd") + " 00:00'");
                if (b_dPlan_eff_dateFrom && b_dPlan_eff_dateTo)
                    _oSql.Append(" and ");
                if (b_dPlan_eff_dateTo)
                    _oSql.Append("a.plan_eff_date<='" + ((DateTime)x_dPlan_eff_dateTo).ToString("yyyyMMdd") + " 23:59'");
                _oSql.Append(") or (a.plan_eff  = 'Next Bill Date' AND (");
                if (b_dPlan_eff_dateFrom)
                    _oSql.Append("dateadd(d,1,a.bill_cut_date) >= '" + ((DateTime)x_dPlan_eff_dateFrom).ToString("yyyyMMdd") + " 00:00'");
                if (b_dPlan_eff_dateFrom && b_dPlan_eff_dateTo)
                    _oSql.Append(" and ");
                if (b_dPlan_eff_dateTo)
                    _oSql.Append("dateadd(d,1,a.bill_cut_date) <= '" + ((DateTime)x_dPlan_eff_dateTo).ToString("yyyyMMdd") + " 23:59'");
                _oSql.Append(")))");
            }
        }
        else if (x_bUseDailyRule)
        {
            if (Func.RB(x_dD_dateFrom) && Func.RB(x_dPlan_eff_dateFrom))
            {
                _oSql.Append(" and (((a.d_date>='" + ((DateTime)x_dD_dateFrom).ToString("yyyyMMdd") + " 00:00'");
                _oSql.Append(" and a.d_date<='" + ((DateTime)x_dD_dateFrom).ToString("yyyyMMdd") + " 23:59')");
                _oSql.Append(" and (a.d_date<=a.plan_eff_date or (a.plan_eff = 'Next Bill Date' AND a.d_date<=dateadd(d,1,a.bill_cut_date))))");

                _oSql.Append(" or (((a.plan_eff_date>='" + ((DateTime)x_dPlan_eff_dateFrom).ToString("yyyyMMdd") + " 00:00'");
                _oSql.Append(" and a.plan_eff_date<='" + ((DateTime)x_dPlan_eff_dateFrom).ToString("yyyyMMdd") + " 23:59')");
                _oSql.Append(" or (a.plan_eff  = 'Next Bill Date'");
                _oSql.Append(" AND (dateadd(d,1,a.bill_cut_date) >= '" + ((DateTime)x_dPlan_eff_dateFrom).ToString("yyyyMMdd") + " 00:00'");
                _oSql.Append(" AND dateadd(d,1,a.bill_cut_date) <= '" + ((DateTime)x_dPlan_eff_dateFrom).ToString("yyyyMMdd") + " 23:59')))");
                _oSql.Append(" and (a.plan_eff_date<=a.d_date or (a.plan_eff  = 'Next Bill Date' AND dateadd(d,1,a.bill_cut_date)<=a.d_date))))");
            }
            else if (Func.RB(x_dD_dateFrom))
            {
                /*
                _oSql.Append(" and (a.d_date>='" + ((DateTime)x_dD_dateFrom).ToString("yyyyMMdd") + " 00:00'");
                _oSql.Append(" and a.d_date<='" + ((DateTime)x_dD_dateFrom).ToString("yyyyMMdd") + " 23:59')");
                _oSql.Append(" and (a.d_date<=a.plan_eff_date or (a.plan_eff = 'Next Bill Date' AND a.d_date<=dateadd(d,1,a.bill_cut_date)))");
                 * */
                _oSql.Append(" and (a.d_date>='" + ((DateTime)x_dD_dateFrom).ToString("yyyyMMdd") + " 00:00'");
                _oSql.Append(" and a.d_date<='" + ((DateTime)x_dD_dateFrom).ToString("yyyyMMdd") + " 23:59')");
                _oSql.Append(" and (dateadd(d,3,a.d_date)<=a.plan_eff_date or (a.plan_eff = 'Next Bill Date' AND dateadd(d,3,a.d_date)<=dateadd(d,1,a.bill_cut_date)))");
            }
            else if (Func.RB(x_dPlan_eff_dateFrom))
            {
                /*
                _oSql.Append(" and ((a.plan_eff_date>='" + ((DateTime)x_dPlan_eff_dateFrom).ToString("yyyyMMdd") + " 00:00'");
                _oSql.Append(" and a.plan_eff_date<='" + ((DateTime)x_dPlan_eff_dateFrom).ToString("yyyyMMdd") + " 23:59')");
                _oSql.Append(" or (a.plan_eff  = 'Next Bill Date'");
                _oSql.Append(" AND (dateadd(d,1,a.bill_cut_date) >= '" + ((DateTime)x_dPlan_eff_dateFrom).ToString("yyyyMMdd") + " 00:00'");
                _oSql.Append(" AND dateadd(d,1,a.bill_cut_date) <= '" + ((DateTime)x_dPlan_eff_dateFrom).ToString("yyyyMMdd") + " 23:59')))");
                _oSql.Append(" and (a.plan_eff_date<=a.d_date or (a.plan_eff  = 'Next Bill Date' AND dateadd(d,1,a.bill_cut_date)<=a.d_date))");
                 * */
                _oSql.Append(" and ((a.plan_eff_date>='" + ((DateTime)x_dPlan_eff_dateFrom).ToString("yyyyMMdd") + " 00:00'");
                _oSql.Append(" and a.plan_eff_date<='" + ((DateTime)x_dPlan_eff_dateFrom).ToString("yyyyMMdd") + " 23:59')");
                _oSql.Append(" or (a.plan_eff  = 'Next Bill Date'");
                _oSql.Append(" AND (dateadd(d,1,a.bill_cut_date) >= '" + ((DateTime)x_dPlan_eff_dateFrom).ToString("yyyyMMdd") + " 00:00'");
                _oSql.Append(" AND dateadd(d,1,a.bill_cut_date) <= '" + ((DateTime)x_dPlan_eff_dateFrom).ToString("yyyyMMdd") + " 23:59')))");
                _oSql.Append(" and (a.plan_eff_date<=dateadd(d,3,a.d_date) or (a.plan_eff  = 'Next Bill Date' AND dateadd(d,1,a.bill_cut_date)<=dateadd(d,3,a.d_date)))");
            }
        }
        return _oSql;
    }

    /*
public static StringBuilder appendDDate_PlanEffDateToReportSQL(DateTime? x_dD_dateFrom, DateTime? x_dD_dateTo, DateTime? x_dPlan_eff_dateFrom, DateTime? x_dPlan_eff_dateTo, bool x_bUseDailyRule)
    {
        StringBuilder _oSql = new StringBuilder();
        if (!x_bUseDailyRule)
        {
            // D_DATE
            if (Func.RB(x_dD_dateFrom))
                _oSql.Append(" and a.d_date>='" + ((DateTime)x_dD_dateFrom).ToString("yyyyMMdd") + " 00:00'");
            if (Func.RB(x_dD_dateTo))
                _oSql.Append(" and a.d_date<='" + ((DateTime)x_dD_dateTo).ToString("yyyyMMdd") + " 23:59'");

            // PLAN_EFF_DATE
            if (Func.RB(x_dPlan_eff_dateFrom))
                _oSql.Append(" and a.plan_eff_date>='" + ((DateTime)x_dPlan_eff_dateFrom).ToString("yyyyMMdd") + " 00:00'");
            if (Func.RB(x_dPlan_eff_dateTo))
                _oSql.Append(" and a.plan_eff_date<='" + ((DateTime)x_dPlan_eff_dateTo).ToString("yyyyMMdd") + " 23:59'");
        }
        else if (x_bUseDailyRule)
        {
            if (Func.RB(x_dD_dateFrom) && Func.RB(x_dPlan_eff_dateFrom))
            {
                _oSql.Append(" and (((a.d_date>='" + ((DateTime)x_dD_dateFrom).ToString("yyyyMMdd") + " 00:00'");
                _oSql.Append(" and a.d_date<='" + ((DateTime)x_dD_dateFrom).ToString("yyyyMMdd") + " 23:59')");
                _oSql.Append(" and a.d_date<=a.plan_eff_date)");
                _oSql.Append(" or ((a.plan_eff_date>='" + ((DateTime)x_dPlan_eff_dateFrom).ToString("yyyyMMdd") + " 00:00'");
                _oSql.Append(" and a.plan_eff_date<='" + ((DateTime)x_dPlan_eff_dateFrom).ToString("yyyyMMdd") + " 23:59')");
                _oSql.Append(" and a.plan_eff_date<=a.d_date))");
            }
            else if (Func.RB(x_dD_dateFrom))
            {
                _oSql.Append(" and (a.d_date>='" + ((DateTime)x_dD_dateFrom).ToString("yyyyMMdd") + " 00:00'");
                _oSql.Append(" and a.d_date<='" + ((DateTime)x_dD_dateFrom).ToString("yyyyMMdd") + " 23:59')");
            }
            else if (Func.RB(x_dPlan_eff_dateFrom))
            {
                _oSql.Append(" and (a.plan_eff_date>='" + ((DateTime)x_dPlan_eff_dateFrom).ToString("yyyyMMdd") + " 00:00'");
                _oSql.Append(" and a.plan_eff_date<='" + ((DateTime)x_dPlan_eff_dateFrom).ToString("yyyyMMdd") + " 23:59')");
            }
        }
        return _oSql;
    }
*/

    public static StringBuilder appendHSAmountSQL(String x_sHSAmountSQL)
    {
        StringBuilder _oSql = new StringBuilder();
        _oSql.Append("");
        if (x_sHSAmountSQL != null)
        {
            if (x_sHSAmountSQL == "amount>0")
                _oSql.Append(" and a.amount>0");
            else if (x_sHSAmountSQL == "amount=0")
                _oSql.Append(" and a.amount=0");
            else if (x_sHSAmountSQL == "")
                _oSql.Append("");
        }
        return _oSql;
    }
}
