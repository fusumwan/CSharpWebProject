using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.Xml;
using NEURON.ENTITY.FRAMEWORK;

using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-03-Wed>
///-- Description:	<Description,Class :MobileSequentialCountProfile, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{
    public enum ModelType
    {
        HS_MODEL = 1,
        PREMIUM = 2
    }

    public class MobileSequentialCountProfile
    {

        protected global::System.Collections.Generic.List<string> n_oHscountcode = new global::System.Collections.Generic.List<string>();

        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        public string GetSearchType(ModelType x_oModelType)
        {
            string _sSearchType = string.Empty;
            switch (x_oModelType)
            {
                case ModelType.HS_MODEL:
                    _sSearchType = "hs_model";
                    break;
                case ModelType.PREMIUM:
                    _sSearchType = "premium";
                    break;
                default:
                    _sSearchType = "hs_model";
                    break;
            }
            return _sSearchType;
        }

        #region DAY COUNT
        protected void DayCountHsmodel(int x_iNum, string x_sModel, string x_sChannel, string x_sSalemancodeList, ModelType x_oModelType)
        {
            n_dDate_diff = (Func.DateDiff("day", (DateTime)n_dLog_date, (DateTime)n_dLog_date2)) + 1;
            /*if (n_dDate_diff == 0)
                n_dDate_diff = 1;*/
            string _sTypeField = GetSearchType(x_oModelType);
            string[] _sSalemancodeList = x_sSalemancodeList.Split(","[0]);
            int _iCountHsTotal = 0;


            string _sQuery = "SELECT hs_model,item_code FROM " + Configurator.MSSQLTablePrefix + "ProductItemCode with (nolock) WHERE active=1 ";
            if (x_sModel.Trim() == "ALL")
            {
                _sQuery += " AND hs_model <> '' ";
            }
            else if (!string.IsNullOrEmpty(x_sModel))
            {
                _sQuery += " AND hs_model in ('" + x_sModel.Replace("'", "''").Replace(",", "','") + "')";
            }/*
            else
            {
                _sQuery += " AND hs_model == '' ";
            }*/

            if (_sTypeField == "hs_model")
            {
                _sQuery += " AND type='HS'";
            }
            else if (_sTypeField == "premium")
            {
                _sQuery += " AND (type='PMU' or type='SPMU2')";
            }


            _sQuery += " group by hs_model,item_code";

            /*
            string _sQuery = "SELECT " + _sTypeField + ",sku FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) WHERE active=1 ";
            if (!string.IsNullOrEmpty(x_sModel))
                _sQuery += " AND " + _sTypeField + " in ('" + x_sModel.Replace("'", "''").Replace(",", "','") + "')";
            else
                _sQuery += " AND " + _sTypeField + " <> '' ";

            if (x_sChannel.Trim() == "All")
            {

            }
            else if (!string.IsNullOrEmpty(x_sChannel.Trim()))
            {
                _sQuery += " AND channel ='" + x_sChannel.Trim().Replace(",", "','") + "'";
            }
            else if (x_sChannel.Trim() == "")
            {
                _sQuery += " AND channel =''";
            }

            if (!string.IsNullOrEmpty(x_sSalemancodeList) && _sSalemancodeList.Length > x_iNum)
                _sQuery += " AND salesmancode='" + _sSalemancodeList[x_iNum].ToString() + "' ";

            _sQuery += " AND log_date>='" + ((DateTime)n_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' AND log_date<='" + ((DateTime)n_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' group by hs_model,sku";*/

            //wr("<tr><td colspan=5>" + _sQuery + "</td></tr>");


            global::System.Data.SqlClient.SqlDataReader _oDr2 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
            while (_oDr2.Read())
            {
                /*
                _sQuery = "SELECT DATEDIFF(d,'" + ((DateTime)n_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder WHERE active=1 AND " + _sTypeField + "='" + Func.FR(_oDr2[_sTypeField]) + "'  ";
                if (x_sChannel.Trim() == "All")
                {

                }
                else if (!string.IsNullOrEmpty(x_sChannel.Trim()))
                {
                    _sQuery += " AND channel ='" + x_sChannel.Trim().Replace(",", "','") + "'";
                }
                else if (x_sChannel.Trim() == "")
                {
                    _sQuery += " AND channel =''";
                }

                if (!string.IsNullOrEmpty(x_sSalemancodeList) && _sSalemancodeList.Length > x_iNum)
                    _sQuery += " AND salesmancode='" + _sSalemancodeList[x_iNum].ToString() + "' ";

                _sQuery += "AND log_date>='" + ((DateTime)n_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' AND log_date<='" + ((DateTime)n_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' AND log_date is not null group by DATEDIFF(d,'" + ((DateTime)n_dLog_date).ToString("dd/MM/yyyy") + "',log_date) ORDER BY DATEDIFF(d,'" + ((DateTime)n_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
                */

                _sQuery = "select a.date_diff, count(1)-1 as count from (";

                //_sQuery += "SELECT DATEDIFF(d,'" + ((DateTime)n_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder WHERE active=1 AND " + _sTypeField + "='" + Func.FR(_oDr2[_sTypeField]) + "'  ";
                _sQuery += "SELECT DATEDIFF(d,'" + ((DateTime)n_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder WHERE active=1 AND " + _sTypeField + "='" + Func.FR(_oDr2["hs_model"]) + "'  ";
                if (x_sChannel.Trim() == "All")
                {
                }
                else if (x_sChannel.Trim() == "Others" || string.IsNullOrEmpty(x_sChannel.Trim()))
                {
                    _sQuery += " AND channel <>'IB' AND channel <>'OB' AND channel <>'IMS'";
                }
                else if (!string.IsNullOrEmpty(x_sChannel.Trim()))
                {
                    _sQuery += " AND channel ='" + x_sChannel.Trim().Replace(",", "','") + "'";
                }

                if (!string.IsNullOrEmpty(x_sSalemancodeList) && _sSalemancodeList.Length > x_iNum)
                    _sQuery += " AND salesmancode='" + _sSalemancodeList[x_iNum].ToString() + "' ";

                _sQuery += " AND log_date>='" + ((DateTime)n_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' AND log_date<='" + ((DateTime)n_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' AND log_date is not null";

                for (int i = 0; i < n_dDate_diff; i++)
                {
                    _sQuery += " union all select " + i;
                }
                _sQuery += " ) a group by a.date_diff order by a.date_diff";

                //wr("<tr><td colspan=5>" + _sQuery + "</td></tr>");
                SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
                wr("<tr>");
                wr("<td height=\"0\" class=\"row2\"><span class=\"gensmall\">");
                if (x_oModelType == ModelType.HS_MODEL)
                    //wr(FR(_oDr2[_sTypeField]).ToString() + "-" + _oDr2["sku"].ToString());
                    wr(FR(_oDr2["hs_model"]).ToString() + "-" + _oDr2["item_code"].ToString());
                else
                    wr(FR(_oDr2["hs_model"]).ToString());

                wr("</span></td>");

                int _iDate_diff = -1;
                if (_oDr.Read())
                {
                    string _sDate_diff = Func.FR(_oDr["date_diff"]);
                    int.TryParse(_sDate_diff, out _iDate_diff);
                }
                _iCountHsTotal = 0;
                for (int i = 0; i < n_dDate_diff; i++)
                {
                    wr("<td  height=\"0\" class=\"row2\"><span class=\"gensmall\">");
                    if (_iDate_diff == i)
                    {
                        _iCountHsTotal = _iCountHsTotal + (int)_oDr["count"];
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
                }
                _oDr.Close();
                _oDr.Dispose();

                wr("<td height=\"0\" class=\"row1\"><b><span class=\"gensmall\">");
                wr(_iCountHsTotal.ToString());
                //wr(CountHsmodel(x_iNum, x_sModel, x_sChannel, x_sSalemancodeList, false, x_oModelType).ToString());
                wr("</span></b></td>");
                wr("</tr>");
            }
            _oDr2.Close();
            _oDr2.Dispose();
        }
        #endregion

        #region SUB TOTAL COUNT
        protected void SubTotalCountHsmodel(int x_iNum, string x_sModel, string x_sChannel, string x_sSalemancodeList, ModelType x_oModelType)
        {
            n_dDate_diff = (Func.DateDiff("day", (DateTime)n_dLog_date, (DateTime)n_dLog_date2)) + 1;
            /*if (n_dDate_diff == 0)
                n_dDate_diff = 1;*/
            string[] _sSalemancodeList = x_sSalemancodeList.Split(","[0]);
            string _sTypeField = GetSearchType(x_oModelType);

            /*
            string _sQuery = "SELECT DATEDIFF(d,'" + ((DateTime)n_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=1 ";
            if (!string.IsNullOrEmpty(x_sModel))
                _sQuery += " AND " + _sTypeField + " in ('" + x_sModel.Replace("'", "''").Replace(",", "','") + "')";
            else
                _sQuery += " AND " + _sTypeField + " in <>'' ";

            if (x_sChannel.Trim() == "All")
            {

            }
            else if (!string.IsNullOrEmpty(x_sChannel.Trim()))
            {
                _sQuery += " AND channel ='" + x_sChannel.Trim().Replace(",", "','") + "'";
            }
            else if (x_sChannel.Trim() == "")
            {
                _sQuery += " AND channel =''";
            }

            if (!string.IsNullOrEmpty(x_sSalemancodeList) && _sSalemancodeList.Length>=x_iNum)
                _sQuery += " AND salesmancode ='" + _sSalemancodeList[x_iNum].ToString() + "'";

            _sQuery += "  AND log_date>='" + ((DateTime)n_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' AND log_date<='" + ((DateTime)n_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' and log_date is not null group by DATEDIFF(d,'" + ((DateTime)n_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(d,'" + ((DateTime)n_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
             */

            string _sQuery = "select a.date_diff, count(1)-1 as count from (";
            _sQuery += "SELECT DATEDIFF(d,'" + ((DateTime)n_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=1 ";
            if (x_sModel.Trim() == "ALL")
                _sQuery += " AND " + _sTypeField + " in <>'' ";
            else if (!string.IsNullOrEmpty(x_sModel))
                _sQuery += " AND " + _sTypeField + " in ('" + x_sModel.Replace("'", "''").Replace(",", "','") + "')";
            /*else
                _sQuery += " AND " + _sTypeField + " in <>'' ";
             */

            if (x_sChannel.Trim() == "All")
            {
            }
            else if (x_sChannel.Trim() == "Others" || string.IsNullOrEmpty(x_sChannel.Trim()))
            {
                _sQuery += " AND channel <>'IB' AND channel <>'OB' AND channel <>'IMS'";
            }
            else if (!string.IsNullOrEmpty(x_sChannel.Trim()))
            {
                _sQuery += " AND channel ='" + x_sChannel.Trim().Replace(",", "','") + "'";
            }

            if (!string.IsNullOrEmpty(x_sSalemancodeList) && _sSalemancodeList.Length >= x_iNum)
                _sQuery += " AND salesmancode ='" + _sSalemancodeList[x_iNum].ToString() + "'";

            _sQuery += "  AND log_date>='" + ((DateTime)n_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' AND log_date<='" + ((DateTime)n_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' and log_date is not null";

            for (int i = 0; i < n_dDate_diff; i++)
            {
                _sQuery += " union all select " + i;
            }
            _sQuery += " ) a group by a.date_diff order by a.date_diff";


            global::System.Data.SqlClient.SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
            if (_oDr.HasRows)
            {
                wr("<tr>");
                wr("<td height=\"0\" class=\"row2\"><b><span class=\"gensmall\">Sub Total</span></b></td>");

                int _iDate_diff = -1;
                if (_oDr.Read())
                {
                    string _sDate_diff = Func.FR(_oDr["date_diff"]);
                    int.TryParse(_sDate_diff, out _iDate_diff);
                }
                for (int i = 0; i < n_dDate_diff; i++)
                {
                    wr("<td  height=\"0\" class=\"row2\"><span class=\"gensmall\">");
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
                }
                _oDr.Close();
                _oDr.Dispose();
                wr("<td height=\"0\" class=\"row1\"><b><span class=\"gensmall\">");
                wr(CountHsmodel(x_iNum, x_sModel, x_sChannel, x_sSalemancodeList, false, x_oModelType).ToString());
                wr("</span></b></td>");
                wr("</tr>");
            }
            else
            {
                _oDr.Close();
                _oDr.Dispose();
            }
        }
        #endregion

        #region TOTAL COUNT
        protected void TotalCountHsmodel(string x_sModel, string x_sChannel, string x_sSalemancodeList, ModelType x_oModelType)
        {
            n_dDate_diff = (Func.DateDiff("day", (DateTime)n_dLog_date, (DateTime)n_dLog_date2)) + 1;
            /*if (n_dDate_diff == 0)
                n_dDate_diff = 1;*/
            string _sTypeField = GetSearchType(x_oModelType);
            /*
            string _sQuery = "SELECT DATEDIFF(d,'" + ((DateTime)n_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=1 ";
            if (!string.IsNullOrEmpty(x_sModel))
                _sQuery += " AND " + _sTypeField + " in ('" + x_sModel.Replace("'", "''").Replace(",", "','").ToString() + "') ";
            else
                _sQuery += " AND " + _sTypeField + " <> ''";

            if (x_sChannel.Trim() == "All"){
            }else if (!string.IsNullOrEmpty(x_sChannel.Trim())){
                _sQuery += " AND channel ='" + x_sChannel.Trim().Replace(",", "','") + "'";
            }else if (x_sChannel.Trim() == ""){
                _sQuery += " AND channel =''";
            }

            if (!string.IsNullOrEmpty(x_sSalemancodeList)) _sQuery += " AND salesmancode in ('" + x_sSalemancodeList.Replace("'", "''").Replace(",", "','").ToString().Trim() + "')";
            _sQuery += "  AND log_date>='" + ((DateTime)n_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' AND log_date<='" + ((DateTime)n_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' and log_date is not null group by DATEDIFF(d,'" + ((DateTime)n_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(d,'" + ((DateTime)n_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
             */

            string _sQuery = "select a.date_diff, count(1)-1 as count from(";
            _sQuery += "SELECT DATEDIFF(d,'" + ((DateTime)n_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=1 ";
            if (x_sModel.Trim() == "ALL")
                _sQuery += " AND " + _sTypeField + " <> ''";
            else if (!string.IsNullOrEmpty(x_sModel))
                _sQuery += " AND " + _sTypeField + " in ('" + x_sModel.Replace("'", "''").Replace(",", "','").ToString() + "') ";
            /*
        else
            _sQuery += " AND " + _sTypeField + " <> ''";
             */
            if (x_sChannel.Trim() == "All")
            {
            }
            else if (x_sChannel.Trim() == "Others" || string.IsNullOrEmpty(x_sChannel.Trim()))
            {
                _sQuery += " AND channel <>'IB' AND channel <>'OB' AND channel <>'IMS'";
            }
            else if (!string.IsNullOrEmpty(x_sChannel.Trim()))
            {
                _sQuery += " AND channel ='" + x_sChannel.Trim().Replace(",", "','") + "'";
            }
            if (!string.IsNullOrEmpty(x_sSalemancodeList)) _sQuery += " AND salesmancode in ('" + x_sSalemancodeList.Replace("'", "''").Replace(",", "','").ToString().Trim() + "')";
            _sQuery += "  AND log_date>='" + ((DateTime)n_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' AND log_date<='" + ((DateTime)n_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' and log_date is not null";

            for (int i = 0; i < n_dDate_diff; i++)
            {
                _sQuery += " union all select " + i;
            }
            _sQuery += " ) a group by a.date_diff order by a.date_diff";



            global::System.Data.SqlClient.SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
            wr("	<tr>");
            wr("	<td height=\"0\" class=\"row1\"><b><span class=\"gensmall\">SUB Total</span></b></td>");
            int _iDate_diff = -1;
            if (_oDr.Read())
            {
                string _sDate_diff = Func.FR(_oDr["date_diff"]);
                int.TryParse(_sDate_diff, out _iDate_diff);
            }
            for (int i = 0; i < n_dDate_diff; i++)
            {
                wr("<td  height=\"0\" class=\"row2\"><span class=\"gensmall\">");
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
            }
            _oDr.Close();
            _oDr.Dispose();


            wr("	<td height=\"0\" class=\"row1\"><b><span class=\"gensmall\">");
            wr(CountHsmodel(0, x_sModel, x_sChannel, x_sSalemancodeList, true, x_oModelType).ToString());
            wr("	</span></b></td>");
            wr("	</tr>");
        }
        #endregion

        #region GRAND TOTAL COUNT
        protected void GrandTotalCountHsmodel(string x_sModel, string x_sChannel, string x_sSalemancodeList, bool x_bAllSales, ModelType x_oModelType)
        {
            n_dDate_diff = (Func.DateDiff("day", (DateTime)n_dLog_date, (DateTime)n_dLog_date2)) + 1;
            /*if (n_dDate_diff == 0)
                n_dDate_diff = 1;*/
            string _sTypeField = GetSearchType(x_oModelType);
            /*
            string _sQuery = "SELECT DATEDIFF(d,'" + ((DateTime)n_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff , count(1) as count FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=1 ";
            if (!string.IsNullOrEmpty(x_sModel))
                _sQuery += " AND " + _sTypeField + " in ('" + x_sModel.Replace("'", "''").Replace(",", "','").ToString() + "') ";
            else
                _sQuery += " AND " + _sTypeField + " <> ''";

            if (x_sChannel.Trim() == "All")
            {

            }
            else if (!string.IsNullOrEmpty(x_sChannel.Trim()))
            {
                _sQuery += " AND channel ='" + x_sChannel.Trim().Replace(",", "','") + "'";
            }
            else if (x_sChannel.Trim() == "")
            {
                _sQuery += " AND channel =''";
            }

            if (!string.IsNullOrEmpty(x_sSalemancodeList)) _sQuery += " AND salesmancode in ('" + x_sSalemancodeList.Replace("'", "''").Replace(",", "','") + "') ";
            _sQuery += "  AND log_date>='" + ((DateTime)n_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' AND log_date<='" + ((DateTime)n_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' and log_date is not null group by DATEDIFF(d,'" + ((DateTime)n_dLog_date).ToString("dd/MM/yyyy") + "',log_date) order by DATEDIFF(d,'" + ((DateTime)n_dLog_date).ToString("dd/MM/yyyy") + "',log_date)";
             */

            string _sQuery = "select a.date_diff, count(1)-1 as count from(";
            _sQuery += " SELECT DATEDIFF(d,'" + ((DateTime)n_dLog_date).ToString("dd/MM/yyyy") + "',log_date) as date_diff FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=1 ";
            if (x_sModel.Trim() == "ALL")
                _sQuery += " AND " + _sTypeField + " <> ''";
            else if (!string.IsNullOrEmpty(x_sModel))
                _sQuery += " AND " + _sTypeField + " in ('" + x_sModel.Replace("'", "''").Replace(",", "','").ToString() + "') ";
            /*else
                _sQuery += " AND " + _sTypeField + " <> ''";
             */

            if (x_sChannel.Trim() == "All")
            {
            }
            else if (x_sChannel.Trim() == "Others" || string.IsNullOrEmpty(x_sChannel.Trim()))
            {
                _sQuery += " AND channel <>'IB' AND channel <>'OB' AND channel <>'IMS'";
            }
            else if (!string.IsNullOrEmpty(x_sChannel.Trim()))
            {
                _sQuery += " AND channel ='" + x_sChannel.Trim().Replace(",", "','") + "'";
            }

            if (!string.IsNullOrEmpty(x_sSalemancodeList)) _sQuery += " AND salesmancode in ('" + x_sSalemancodeList.Replace("'", "''").Replace(",", "','") + "') ";
            _sQuery += "  AND log_date>='" + ((DateTime)n_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' AND log_date<='" + ((DateTime)n_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' and log_date is not null";

            for (int i = 0; i < n_dDate_diff; i++)
            {
                _sQuery += " union all select " + i;
            }
            _sQuery += " ) a group by a.date_diff order by a.date_diff";

            global::System.Data.SqlClient.SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
            wr("<tr>");
            wr("<td height=\"0\" class=\"row3\"><b><span class=\"gensmall\">Grand Total </span></b></td>");
            int _iDate_diff = -1;
            if (_oDr.Read())
            {
                string _sDate_diff = Func.FR(_oDr["date_diff"]);
                int.TryParse(_sDate_diff, out _iDate_diff);
            }
            for (int i = 0; i < n_dDate_diff; i++)
            {
                wr("<td  height=\"0\" class=\"row2\"><span class=\"gensmall\">");
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
            }
            _oDr.Close();
            _oDr.Dispose();


            wr("<td height=\"0\" class=\"row3\"><b><span class=\"gensmall\">");
            wr(CountHsmodel(0, x_sModel, x_sChannel, x_sSalemancodeList, true, x_oModelType).ToString());
            wr("</span></b></td>");
            wr("</tr>");

        }
        #endregion

        #region COUNT HSMODEL
        protected int CountHsmodel(int x_iNum, string x_sModel, string x_sChannel, string x_sSalemancodeList, bool x_bAllSales, ModelType x_oModelType)
        {
            string _sTypeField = GetSearchType(x_oModelType);
            string[] _sSalemancodeList = x_sSalemancodeList.Split(","[0]);
            string _sQuery = "SELECT count(1) as count FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) WHERE active=1 ";
            if (x_sModel.Trim() == "ALL")
                _sQuery += " AND " + _sTypeField + " <>'' ";
            else if (!string.IsNullOrEmpty(x_sModel))
                _sQuery += " AND " + _sTypeField + " in ('" + x_sModel.Replace("'", "''").Replace(",", "','") + "')";
            /*else
                _sQuery += " AND " + _sTypeField + " <>'' ";*/


            if (x_sChannel.Trim() == "All")
            {
            }
            else if (x_sChannel.Trim() == "Others" || string.IsNullOrEmpty(x_sChannel.Trim()))
            {
                _sQuery += " AND channel <>'IB' AND channel <>'OB' AND channel <>'IMS'";
            }
            else if (!string.IsNullOrEmpty(x_sChannel.Trim()))
            {
                _sQuery += " AND channel ='" + x_sChannel.Trim().Replace(",", "','") + "'";
            }


            if (string.IsNullOrEmpty(x_sSalemancodeList))
            {
                //_sQuery += " AND salesmancode ='" + _sSalemancodeList[x_iNum].ToString() + "'";
            }
            else if (!string.IsNullOrEmpty(x_sSalemancodeList) && _sSalemancodeList.Length > x_iNum && !x_bAllSales)
            {
                _sQuery += " AND salesmancode ='" + _sSalemancodeList[x_iNum].ToString() + "'";
            }
            else
            {
                _sQuery += " AND salesmancode in ('" + x_sSalemancodeList.Replace("'", "''").Replace(",", "','") + "') ";
            }

            _sQuery += "  AND log_date>='" + ((DateTime)n_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' AND log_date<='" + ((DateTime)n_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59'";
            string _sCount = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar(_sQuery);
            int _iCnt = 0;
            if (int.TryParse(_sCount, out _iCnt)) { }
            return _iCnt;
        }
        #endregion

        #region HANDSET REPORT
        protected void HANDSET_REPORT(string x_sChannel, string x_sSalemancodeList, string x_sHs_model)
        {
            ModelType x_oModelType = ModelType.HS_MODEL;
            wr("<table width=\"100%\" border=\"0\" cellpadding=\"3\" cellspacing=\"1\" class=\"forumline\">");
            wr("<tr>");
            wr("<th colspan=\"100\">Handset</th>");
            wr("</tr>");

            wr("<tr>");
            wr("<td height=\"0\" class=\"row2\"></td>");
            n_dDate_diff = (Func.DateDiff("day", (DateTime)n_dLog_date, (DateTime)n_dLog_date2)) + 1;
            /*if (n_dDate_diff == 0)
                n_dDate_diff = 1;*/
            for (int i = 0; i < n_dDate_diff; i++)
            {
                wr("<td height=\"0\" class=\"row2\"><span class=\"explaintitle\" style=\"font-size:7pt\">" + ((DateTime)n_dLog_date).AddDays(i).ToString("MM/dd/yyyy") + "</span></td>");
            }
            wr("<td height=\"0\" class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">Total</span></td>");
            wr("</tr>");

            int _iDisplayCol = (int)n_dDate_diff + 2;

            string _sQuery = "SELECT DISTINCT channel from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder WITH (nolock) WHERE active=1 ";
            if (x_sChannel.Trim() == "All")
            {
                _sQuery += " and channel <>'' and channel is not null";
                _sQuery += " union all";
                _sQuery += " SELECT ''";
            }
            else if (x_sChannel.Trim() == "Others")
            {
                _sQuery += " AND channel <>'IB' AND channel <>'OB' AND channel <>'IMS'";
            }
            else if (!string.IsNullOrEmpty(x_sChannel.Trim()))
            {
                _sQuery += " AND channel ='" + x_sChannel.Trim().Replace(",", "','") + "'";
            }

            /*
            _sQuery += " AND log_date>='" + ((DateTime)n_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' AND log_date<='" + ((DateTime)n_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' order by channel";
             */
            global::System.Data.SqlClient.SqlDataReader _oDr3 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
            while (_oDr3.Read())
            {
                wr("<tr>");
                wr("<td colspan=\"" + _iDisplayCol);
                wr("\" class=\"row3\"><span class=\"explaintitle\" style=\"font-size:7pt\">" + ((Func.FR(_oDr3["channel"]).Trim() == string.Empty) ? "Others" : Func.FR(_oDr3["channel"]).Trim()) + "</span></td>");
                wr("</tr>");
                string[] _sSalemancodeList = x_sSalemancodeList.Split(","[0]);
                for (int num = 0; num < _sSalemancodeList.Length; num++)
                {
                    n_iCnt = CountHsmodel(num, x_sHs_model, Func.FR(_oDr3["channel"]).Trim(), x_sSalemancodeList, true, x_oModelType);
                    //if (!(0).Equals(n_iCnt))
                    //{
                    wr("<tr>");
                    wr("<td colspan=\"" + _iDisplayCol);
                    wr("\" class=\"row3\"><span class=\"explaintitle\" style=\"font-size:7pt\">" + _sSalemancodeList[num].ToString() + "</span></td>");
                    wr("</tr>");
                    DayCountHsmodel(num, x_sHs_model, Func.FR(_oDr3["channel"]).Trim(), x_sSalemancodeList, x_oModelType);
                    //SubTotalCountHsmodel(num, x_sHs_model, Func.FR(_oDr3["channel"]).Trim(), x_sSalemancodeList, x_oModelType);
                    //}
                }
                TotalCountHsmodel(x_sHs_model, Func.FR(_oDr3["channel"]).Trim(), x_sSalemancodeList, x_oModelType);
            }
            if (_oDr3 != null) _oDr3.Close(); _oDr3.Dispose();
            GrandTotalCountHsmodel(x_sHs_model, x_sChannel.Trim(), x_sSalemancodeList, false, x_oModelType);

            wr("<tr>");
            wr("<td class=\"cat\" colspan=\"" + _iDisplayCol);
            wr("100\"></td>");
            wr("</tr>");
            wr("</table>");
        }
        #endregion

        #region PREMIUM REPORT
        protected void PREMIUM_REPORT(string x_sChannel, string x_sSalemancodeList, string x_sPremium)
        {
            ModelType x_oModelType = ModelType.PREMIUM;
            wr("<table width=\"100%\" border=\"0\" cellpadding=\"3\" cellspacing=\"1\" class=\"forumline\">");
            wr("<tr>");
            wr("<th colspan=\"100\">Premium</th>");
            wr("</tr>");
            wr("<tr>");
            wr("<td height=\"0\" class=\"row2\"></td>");

            n_dDate_diff = (Func.DateDiff("day", (DateTime)n_dLog_date, (DateTime)n_dLog_date2)) + 1;
            /*if (n_dDate_diff == 0)
                n_dDate_diff = 1;*/
            for (int i = 0; i < n_dDate_diff; i++)
            {
                wr("<td height=\"0\" class=\"row2\"><span class=\"explaintitle\" style=\"font-size:7pt\">" + ((DateTime)n_dLog_date).AddDays(i).ToString("MM/dd/yyyy") + "</span></td>");
            }
            wr("<td height=\"0\" class=\"row1\"><span class=\"explaintitle\" style=\"font-size:7pt\">Total</span></td>");
            wr("</tr>");

            int _iDisplayCol = (int)n_dDate_diff + 2;
            string _sQuery = "SELECT DISTINCT channel from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=1 ";
            if (x_sChannel.Trim() == "All")
            {
                _sQuery += " and channel <>'' and channel is not null";
                _sQuery += " union all";
                _sQuery += " SELECT ''";
            }
            else if (x_sChannel.Trim() == "Others")
            {
                _sQuery += " AND channel <>'IB' AND channel <>'OB' AND channel <>'IMS'";
            }
            else if (!string.IsNullOrEmpty(x_sChannel.Trim()))
            {
                _sQuery += " AND channel ='" + x_sChannel.Trim().Replace(",", "','") + "'";
            }
            /*
           _sQuery += " and log_date>='" + ((DateTime)n_dLog_date).ToString("dd/MM/yyyy") + " 00:00:00' and log_date<='" + ((DateTime)n_dLog_date2).ToString("dd/MM/yyyy") + " 23:59:59' order by channel";
             */

            SqlDataReader _oDr3 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
            while (_oDr3.Read())
            {
                wr("<tr>");
                wr("<td colspan=\"" + _iDisplayCol);
                wr("\" class=\"row3\"><span class=\"explaintitle\" style=\"font-size:7pt\">" + ((Func.FR(_oDr3["channel"]).Trim() == string.Empty) ? "Others" : Func.FR(_oDr3["channel"]).Trim()) + "</span></td>");
                wr("</tr>");
                string[] _sSalemancodeList = x_sSalemancodeList.Split(","[0]);
                for (int num = 0; num < _sSalemancodeList.Length; num++)
                {
                    n_iCnt = CountHsmodel(num, x_sPremium, Func.FR(_oDr3["channel"]).Trim(), x_sSalemancodeList, false, x_oModelType);
                    //if (!(0).Equals(n_iCnt))
                    //{
                    wr("<tr>");
                    wr("<td colspan=\"" + _iDisplayCol);
                    wr("\" class=\"row3\"><span class=\"explaintitle\" style=\"font-size:7pt\">");
                    wr("</span></td>");
                    wr("</tr>");
                    DayCountHsmodel(num, x_sPremium, Func.FR(_oDr3["channel"]).Trim(), x_sSalemancodeList, x_oModelType);
                    //SubTotalCountHsmodel(num, x_sPremium, Func.FR(_oDr3["channel"]).Trim(), x_sSalemancodeList, x_oModelType);
                    //}
                }
                TotalCountHsmodel(x_sPremium, Func.FR(_oDr3["channel"]).Trim(), x_sSalemancodeList, x_oModelType);
            }
            _oDr3.Close();
            _oDr3.Dispose();
            GrandTotalCountHsmodel(x_sPremium, x_sChannel.Trim(), x_sSalemancodeList, true, x_oModelType);

            wr("<tr>");
            wr("<td class=\"cat\" colspan=\"" + _iDisplayCol);
            wr("100\">&nbsp;</td>");
            wr("</tr>");
            wr("</table>");
        }
        #endregion

        #region Get Hs count htmlcode
        public global::System.Collections.Generic.List<string> GetHscountHtmlcode(string x_sChannel, string x_sSalemancodeList, string x_sHs_model, string x_sPremium)
        {
            //if (x_sChannel == null) throw new ArgumentNullException("x_sChannel");
            //if (x_sHs_model == null) throw new ArgumentNullException("x_sHs_model");
            //if (x_sPremium == null) throw new ArgumentNullException("x_sPremium");
            n_oHscountcode.Clear();
            if (n_dLog_date != null && n_dLog_date2 != null)
            {
                if (!string.IsNullOrEmpty(x_sHs_model))
                {
                    HANDSET_REPORT(x_sChannel.Trim(), x_sSalemancodeList, x_sHs_model);
                }
                wr("<br>");
                if (!string.IsNullOrEmpty(x_sPremium))
                {
                    PREMIUM_REPORT(x_sChannel.Trim(), x_sSalemancodeList, x_sPremium);
                }
            }
            return n_oHscountcode;
        }
        #endregion

        public string FR(object x_oObj)
        {
            if (Func.IsDBNullOrEmpty(x_oObj)) return string.Empty;
            return x_oObj.ToString();
        }

        public void wr(string x_sCode)
        {
            n_oHscountcode.Add(x_sCode + "\r\n");
        }

        #region m_oHscountcode
        protected global::System.Collections.Generic.List<string> m_oHscountcode
        {
            get
            {
                return this.n_oHscountcode;
            }
            set
            {
                this.n_oHscountcode = value;
            }
        }
        #endregion m_oHscountcode

        protected double n_dDate_diff = 1.0f;
        #region m_dDate_diff
        protected double m_dDate_diff
        {
            get
            {
                return this.n_dDate_diff;
            }
            set
            {
                this.n_dDate_diff = value;
            }
        }
        #endregion m_dDate_diff

        protected global::System.Nullable<DateTime> n_dLog_date2 = null;
        #region m_dLog_date2
        protected global::System.Nullable<DateTime> m_dLog_date2
        {
            get
            {
                return this.n_dLog_date2;
            }
            set
            {
                this.n_dLog_date2 = value;
            }
        }
        #endregion m_dLog_date2

        protected int n_iCnt = -1;
        #region m_iCnt
        protected int m_iCnt
        {
            get
            {
                return this.n_iCnt;
            }
            set
            {
                this.n_iCnt = value;
            }
        }
        #endregion m_iCnt

        protected global::System.Nullable<DateTime> n_dLog_date = null;
        #region m_dLog_date
        protected global::System.Nullable<DateTime> m_dLog_date
        {
            get
            {
                return this.n_dLog_date;
            }
            set
            {
                this.n_dLog_date = value;
            }
        }
        #endregion m_dLog_date

        protected string n_sChannel = string.Empty;
        #region m_sChannel
        protected string m_sChannel
        {
            get
            {
                return this.n_sChannel;
            }
            set
            {
                this.n_sChannel = value;
            }

        }
        #endregion

        #region Constructor & Destructor
        public MobileSequentialCountProfile() { }

        public MobileSequentialCountProfile(List<string> x_oHscountcode, double x_dDate_diff, System.Nullable<DateTime> x_dLog_date2, int x_iCnt, System.Nullable<DateTime> x_dLog_date, string x_sChannel)
        {
            m_oHscountcode = x_oHscountcode;
            m_dDate_diff = x_dDate_diff;
            m_dLog_date2 = x_dLog_date2;
            m_iCnt = x_iCnt;
            m_dLog_date = x_dLog_date;
            m_sChannel = x_sChannel;
        }

        ~MobileSequentialCountProfile() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public global::System.Collections.Generic.List<string> GetHscountcode() { return this.m_oHscountcode; }
        public double GetDate_diff() { return this.m_dDate_diff; }
        public global::System.Nullable<DateTime> GetLog_date2() { return this.m_dLog_date2; }
        public int GetCnt() { return this.m_iCnt; }
        public global::System.Nullable<DateTime> GetLog_date() { return this.m_dLog_date; }
        protected string GetChannel() { return this.m_sChannel; }

        public bool SetHscountcode(List<string> value)
        {
            this.m_oHscountcode = value;
            return true;
        }
        public bool SetDate_diff(double value)
        {
            this.m_dDate_diff = value;
            return true;
        }
        public bool SetLog_date2(global::System.Nullable<DateTime> value)
        {
            this.m_dLog_date2 = value;
            return true;
        }
        public bool SetCnt(int value)
        {
            this.m_iCnt = value;
            return true;
        }
        public bool SetLog_date(global::System.Nullable<DateTime> value)
        {
            this.m_dLog_date = value;
            return true;
        }
        public bool SetChannel(string value)
        {
            this.m_sChannel = value;
            return true;
        }

        #endregion

        #region Get DB
        protected ODBCConnect GetORDB()
        {
            ODBCConnect _oDB = new ODBCConnect();
            _oDB.SetConnStr(Configurator.DBName.ORADNS + ((Configurator.IsUat()) ? "2" : string.Empty));
            return _oDB;
        }

        protected MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            _oDB.bWithNoLock = true;
            return _oDB;
        }
        #endregion

        #region Equals
        public bool Equals(MobileSequentialCountProfile x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.m_oHscountcode.Equals(x_oObj.m_oHscountcode)) { return false; }
            if (!this.m_dDate_diff.Equals(x_oObj.m_dDate_diff)) { return false; }
            if (!this.m_dLog_date2.Equals(x_oObj.m_dLog_date2)) { return false; }
            if (!this.m_iCnt.Equals(x_oObj.m_iCnt)) { return false; }
            if (!this.m_dLog_date.Equals(x_oObj.m_dLog_date)) { return false; }
            if (!this.m_sChannel.Equals(x_oObj.m_sChannel)) { return false; }
            return true;
        }
        #endregion Equals

        #region Release
        public void Release()
        {
            this.m_oHscountcode = null;
            this.m_dDate_diff = 1.0f;
            this.m_dLog_date2 = null;
            this.m_iCnt = -1;
            this.m_dLog_date = null;
            this.m_sChannel = string.Empty;
        }
        #endregion Release

        #region DeepClone
        public MobileSequentialCountProfile DeepClone()
        {
            MobileSequentialCountProfile MobileSequentialCountProfile_Clone = new MobileSequentialCountProfile();
            MobileSequentialCountProfile_Clone.SetHscountcode(this.m_oHscountcode);
            MobileSequentialCountProfile_Clone.SetDate_diff(this.m_dDate_diff);
            MobileSequentialCountProfile_Clone.SetLog_date2(this.m_dLog_date2);
            MobileSequentialCountProfile_Clone.SetCnt(this.m_iCnt);
            MobileSequentialCountProfile_Clone.SetLog_date(this.m_dLog_date);
            MobileSequentialCountProfile_Clone.SetChannel(this.m_sChannel);
            return MobileSequentialCountProfile_Clone;
        }
        #endregion Clone

    }
}