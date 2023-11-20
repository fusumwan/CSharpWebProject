﻿using System;
using System.Xml;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Threading;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.GZip;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;

/// <summary>
/// Summary description for WebFunc
/// </summary>
///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2008-1-1>
///-- Description:	<Description,Class :WEBFUNC, Web common function>
///-- =============================================
namespace PCCW.RWL.CORE.WEBFUNC
{
    public class WebFunc : WebFuncBase
    {
        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        public WebFunc() 
            : base()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public static class ExportContentType
        {
            public const string Excel = "application/ms-excel";
            public const string Word = "application/ms-word";
        }

        public static void ExportDataSetToExcelAndZip(DataSet x_sDS, string x_sReportName, bool x_bZip, Encoding x_oEncoding, string x_sContentType, bool x_bFlush, bool x_bClose, bool x_bEnd)
        {
            if (x_sDS == null)
                throw new BusinessObjectNotFoundException("Error: x_sDS cannot be null!");
            if (string.IsNullOrEmpty(x_sContentType))
                throw new BusinessObjectNotFoundException("Error: x_sContentType cannot be null/empty !");

            HttpResponse _oResponse;
            Encoding _oEncoding = x_oEncoding;
            string _sContentType = x_sContentType;
            _oResponse = HttpContext.Current.Response;
            MemoryStream _oMs = new MemoryStream();
            _oMs = GetExcelMemoryStream(x_sDS, x_sReportName);
            byte[] _oBytes = _oMs.ToArray();
            _oResponse.Clear();
            _oResponse.AddHeader("Content-Disposition", string.Format("attachment; filename=" + x_sReportName + ((x_bZip) ? ".zip" : ".xls")));
            _oResponse.ContentEncoding = _oEncoding;
            _oResponse.Charset = _oEncoding.WebName;
            _oResponse.ContentType = _sContentType;
            if (x_bZip)
            {
                MemoryStream _oMemStreamZip = new MemoryStream();
                using (ZipOutputStream _oGzOs = new ZipOutputStream(_oMemStreamZip))
                {
                    ZipEntry _oEntry = new ZipEntry(x_sReportName + ".xls");
                    _oGzOs.SetLevel(6);
                    _oGzOs.PutNextEntry(_oEntry);
                    _oGzOs.Write(_oBytes, 0, _oBytes.Length);
                    _oGzOs.CloseEntry();
                    //_oGzOs.Password = "Password";
                    _oGzOs.Close();
                }
                _oResponse.BinaryWrite(_oMemStreamZip.ToArray());
            }
            else
            {
                _oResponse.BinaryWrite(_oBytes);
            }
            if (x_bFlush)
                _oResponse.Flush();
            if (x_bClose)
                _oResponse.Close();
            if (x_bEnd)
                _oResponse.End();
        }

        public static void ExportDataSetToExcelAndZip(DataSet x_sDS, string x_sReportName, bool x_bZip,Encoding x_oEncoding, string x_sContentType)
        {
            ExportDataSetToExcelAndZip(x_sDS, x_sReportName, x_bZip, x_oEncoding, x_sContentType,false,false,true);
        }



        public static MemoryStream GetExcelMemoryStream(DataSet x_sDS, string x_sReportName)
        {
            HSSFWorkbook _oWorkbook = new HSSFWorkbook();
            MemoryStream _oMs = new MemoryStream();
            if (x_sDS == null) { return _oMs; }
            if (x_sDS.Tables.Count == 0) { return _oMs; }
            if (string.IsNullOrEmpty(x_sReportName)) { return _oMs; }

            Sheet _oSheet = _oWorkbook.CreateSheet(x_sReportName);
            Row _oHeaderRow = _oSheet.CreateRow(0);

            // Handling Header.
            foreach (DataColumn _oColumn in x_sDS.Tables[0].Columns)
                _oHeaderRow.CreateCell(_oColumn.Ordinal).SetCellValue(_oColumn.ColumnName);

            // Handling Value.
            int RowIndex = 1;
            foreach (DataRow _oRow in x_sDS.Tables[0].Rows)
            {
                Row _oDataRow = _oSheet.CreateRow(RowIndex);
                foreach (DataColumn _oColumn in x_sDS.Tables[0].Columns)
                    _oDataRow.CreateCell(_oColumn.Ordinal).SetCellValue(_oRow[_oColumn].ToString());
                RowIndex++;
            }
            _oWorkbook.Write(_oMs);
            return _oMs;
        }

        public static byte[] CompressBytes(byte[] _oData)
        {
            MemoryStream _oMemoryStream = new MemoryStream();
            Stream _oStream = new ICSharpCode.SharpZipLib.BZip2.BZip2OutputStream(_oMemoryStream);
            _oStream.Write(_oData, 0, _oData.Length);
            _oStream.Close();
            _oMemoryStream.Flush();
            _oMemoryStream.Close();
            return _oMemoryStream.ToArray();
        }

        #region DateTime Convert
        public static DateTime? DateTimeConvert(string x_sDateTime,string[] x_sFormat)
        {
            DateTime _dDate;
            if (DateTime.TryParseExact(x_sDateTime, x_sFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dDate))
                return _dDate;
            else
                return null;
        }
        #endregion


        #region PagePrivilegeCheck
        public static bool PagePrivilegeCheck(CurrentUserSetting x_oCurrentUserSetting, string x_sAccess_Page)
        {
            return AccessRightControl.Instance().PagePrivilegeCheck(x_oCurrentUserSetting, x_sAccess_Page);
        }
        #endregion

        public static bool SaveQuery(Page x_oPage,string x_sSql)
        {
            if (!string.IsNullOrEmpty(x_oPage.Request.UserHostAddress))
            {
                Sqll _oSqllEntity = new Sqll()
                {
                    cdate = DateTime.Now,
                    ip = x_oPage.Request.UserHostAddress,
                    txt = x_sSql.ToString()
                };
                return SqllRepositoryBase.Insert(SYSConn<MSSQLConnect>.Connect("CSSSQLDB"), _oSqllEntity);
            }
            return false;
        }

        public static bool SaveQuery(string x_sQuery)
        {
            Sqll _oSqllEntity = new Sqll()
            {
                cdate = DateTime.Now,
                ip = "136.139.31.224",
                txt = x_sQuery.ToString()
            };
            return SqllRepositoryBase.Insert(SYSConn<MSSQLConnect>.Connect("CSSSQLDB"), _oSqllEntity);
        }

        #region PrivilegeCheck
        public static void PrivilegeCheck(Page x_oPage)
        {
            x_oPage.Server.ScriptTimeout = 999;
            if ("TRUE".Equals(ConfigurationManager.AppSettings["PRIVILEGE_CHECK"].ToString()))
            {
                bool _bFlag = false;
                if (x_oPage.Session["lv"] != null && x_oPage.Session["uid"] != null && x_oPage.Session["arprog"] != null)
                {
                    if (x_oPage.Session["lv"].ToString().Trim().Equals(string.Empty) ||
                        x_oPage.Session["uid"].ToString().Trim().Equals(string.Empty) ||
                        x_oPage.Session["arprog"].ToString().Trim().Equals(string.Empty))
                    {
                        _bFlag = true;
                    }
                }
                else
                {
                    _bFlag = true;
                }

                if (_bFlag) x_oPage.Response.Redirect("~/Board.aspx");
            }
            if (x_oPage.Session["uid"] != null)
                RWLFramework.CurrentUser[x_oPage].SetUid(x_oPage.Session["uid"].ToString());
            if (x_oPage.Session["lv"] != null)
                RWLFramework.CurrentUser[x_oPage].SetLv(x_oPage.Session["lv"].ToString());
            if (x_oPage.Session["arprog"] != null)
                RWLFramework.CurrentUser[x_oPage].SetArprog(x_oPage.Session["arprog"].ToString());
            if (x_oPage.Session["channel"] != null)
                RWLFramework.CurrentUser[x_oPage].SetArprog(x_oPage.Session["channel"].ToString());

            if (RWLFramework.CurrentUser[x_oPage].Uid.Trim().Equals(string.Empty) || RWLFramework.CurrentUser[x_oPage].Lv.Trim().Equals(string.Empty))
                x_oPage.Response.Redirect("~/Board.aspx");

            WebFunc.SpecialList(RWLFramework.CurrentUser[x_oPage].Uid.Trim(),  x_oPage.Request.ServerVariables["REMOTE_ADDR"].ToString());
            try
            {
                RWLFramework.DataBaseConfigSetting();
                SYSConn<MSSQLConnect>.Connect().GetExecuteScalar("SELECT @@VERSION");
                //SYSConn<MSSQLConnect>.Connect("CRM").GetExecuteScalar("SELECT @@VERSION");
                SYSConn<ODBCConnect>.Connect().GetExecuteScalar("SELECT banner FROM v$version WHERE banner LIKE 'Oracle%'");

            }
            catch (Exception Exp)
            {
                x_oPage.Response.Redirect("~/500.aspx");
            }
        }
        #endregion

        protected static void SpecialList(string x_sUID,string x_sIP)
        {
            if (x_sUID.Equals("A8350011") ||
                x_sUID.Equals("A8350012") ||
                x_sUID.Equals("686436") ||
                x_sUID.Equals("A0350002") ||
                x_sUID.Equals("A0350003") ||
                x_sUID.Equals("A0350006") || 
                x_sUID.Equals("A0350002") || 
                x_sUID.Equals("1092600") || 
                x_sUID.Equals("A4350003") ||
                x_sUID.Equals("A4350002") || 
                x_sUID.Equals("1173681") || 
                x_sUID.Equals("1033398") || 
                x_sUID.Equals("1020874"))
            {
                if (!string .IsNullOrEmpty(x_sUID) && !string.IsNullOrEmpty(x_sIP))
                {
                    SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT TOP 1 IP FROM SpecialList WHERE UID='" + x_sUID + "' ");
                    if (_oDr.Read())
                    {
                        SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery("UPDATE SpecialList SET IP='"+x_sIP+"' WHERE UID='"+x_sUID+"'");
                    }
                    else
                    {
                        SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery("INSERT INTO SpecialList (UID,IP) VALUES ('" + x_sUID + "','" + x_sIP + "') ");
                    }
                    _oDr.Close();
                    _oDr.Dispose();
                }
            }
        }


        #region QueryString Parameter
        #region [third_party_hkid2]   qsThird_party_hkid2Name & qsThird_party_hkid2
        public const string qsThird_party_hkid2Name = "third_party_hkid2";
        public static string qsThird_party_hkid2
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsThird_party_hkid2Name]))
                {
                    return HttpContext.Current.Request[qsThird_party_hkid2Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion


        #region [retrieve_id]   qsRetrieve_idName & qsRetrieve_id
        public const string qsRetrieve_idName = "retrieve_id";
        public static string qsRetrieve_id
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsRetrieve_idName]))
                {
                    return HttpContext.Current.Request[qsRetrieve_idName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [typeorder]   qsTypeorderName & qsTypeorder
        public const string qsTypeorderName = "typeorder";
        public static string qsTypeorder
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsTypeorderName]))
                {
                    return HttpContext.Current.Request[qsTypeorderName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [log_date2_m]   qsLog_date2_mName & qsLog_date2_m
        public const string qsLog_date2_mName = "log_date2_m";
        public static System.Nullable<DateTime> qsLog_date2_m
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsLog_date2_mName]))
                {
                    if (!WebFunc.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsLog_date2_mName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsLog_date2_mName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion

        #region [log_date_m]   qsLog_date_mName & qsLog_date_m
        public const string qsLog_date_mName = "log_date_m";
        public static System.Nullable<DateTime> qsLog_date_m
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsLog_date_mName]))
                {
                    if (!WebFunc.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsLog_date_mName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsLog_date_mName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion

        #region [checkday]   qsCheckdayName & qsCheckday
        public const string qsCheckdayName = "checkday";
        public static string qsCheckday
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsCheckdayName]))
                {
                    return HttpContext.Current.Request[qsCheckdayName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [checkmonth]   qsCheckmonthName & qsCheckmonth
        public const string qsCheckmonthName = "checkmonth";
        public static string qsCheckmonth
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsCheckmonthName]))
                {
                    return HttpContext.Current.Request[qsCheckmonthName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [Update_status]   qsUpdate_statusName & qsUpdate_status
        public const string qsUpdate_statusName = "Update_status";
        public static string qsUpdate_status
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsUpdate_statusName]))
                {
                    return HttpContext.Current.Request[qsUpdate_statusName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [normal_rebate_str]   qsNormal_rebate_strName & qsNormal_rebate_str
        public const string qsNormal_rebate_strName = "normal_rebate_str";
        public static string qsNormal_rebate_str
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsNormal_rebate_strName]))
                {
                    return HttpContext.Current.Request[qsNormal_rebate_strName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [area]   qsAreaName & qsArea
        public const string qsAreaName = "area";
        public static string qsArea
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsAreaName]))
                {
                    return HttpContext.Current.Request[qsAreaName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [update]   qsUpdateName & qsUpdate
        public const string qsUpdateName = "update";
        public static string qsUpdate
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsUpdateName]))
                {
                    return HttpContext.Current.Request[qsUpdateName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [Cdate2]   qsCdate2Name & qsCdate2
        public const string qsCdate2Name = "Cdate2";
        public static System.Nullable<DateTime> qsCdate2
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsCdate2Name]))
                {
                    if (!WebFunc.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsCdate2Name].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsCdate2Name].ToString());
                    }
                }
                return null;
            }
        }
        #endregion

        #region [view]   qsViewName & qsView
        public const string qsViewName = "view";
        public static string qsView
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsViewName]))
                {
                    return HttpContext.Current.Request[qsViewName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [modflag]   qsModflagName & qsModflag
        public const string qsModflagName = "modflag";
        public static string qsModflag
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsModflagName]))
                {
                    return HttpContext.Current.Request[qsModflagName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [d_date2]   qsD_date2Name & qsD_date2
        public const string qsD_date2Name = "d_date2";
        public static Nullable<DateTime> qsD_date2
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsD_date2Name]))
                {
                    if (!WebFunc.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsD_date2Name].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsD_date2Name].ToString());
                    }
                }
                return null;
            }
        }
        #endregion

        #region [fo_reply]   qsFo_replyName & qsFo_reply
        public const string qsFo_replyName = "fo_reply";
        public static string qsFo_reply
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsFo_replyName]))
                {
                    return HttpContext.Current.Request[qsFo_replyName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [card_no1]   qsCard_no1Name & qsCard_no1
        public const string qsCard_no1Name = "card_no1";
        public static string qsCard_no1
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsCard_no1Name]))
                {
                    return HttpContext.Current.Request[qsCard_no1Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [card_no2]   qsCard_no2Name & qsCard_no2
        public const string qsCard_no2Name = "card_no2";
        public static string qsCard_no2
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsCard_no2Name]))
                {
                    return HttpContext.Current.Request[qsCard_no2Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [card_no3]   qsCard_no3Name & qsCard_no3
        public const string qsCard_no3Name = "card_no3";
        public static string qsCard_no3
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsCard_no3Name]))
                {
                    return HttpContext.Current.Request[qsCard_no3Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [card_no4]   qsCard_no4Name & qsCard_no4
        public const string qsCard_no4Name = "card_no4";
        public static string qsCard_no4
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsCard_no4Name]))
                {
                    return HttpContext.Current.Request[qsCard_no4Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [amend_date2]   qsAmend_date2Name & qsAmend_date2
        public const string qsAmend_date2Name = "amend_date2";
        public static System.Nullable<DateTime> qsAmend_date2
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsAmend_date2Name]))
                {
                    if (!WebFunc.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsAmend_date2Name].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsAmend_date2Name].ToString());
                    }
                }
                return null;
            }
        }
        #endregion

        #region [amend_date]   qsAmend_dateName & qsAmend_date
        public const string qsAmend_dateName = "amend_date";
        public static System.Nullable<DateTime> qsAmend_date
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsAmend_dateName]))
                {
                    if (!WebFunc.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsAmend_dateName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsAmend_dateName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion

        #region [email_date2]   qsEmail_date2Name & qsEmail_date2
        public const string qsEmail_date2Name = "email_date2";
        public static System.Nullable<DateTime> qsEmail_date2
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsEmail_date2Name]))
                {
                    if (!WebFunc.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsEmail_date2Name].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsEmail_date2Name].ToString());
                    }
                }
                return null;
            }
        }
        #endregion

        #region [r_offer5]   qsR_offer5Name & qsR_offer5
        public const string qsR_offer5Name = "r_offer5";
        public static string qsR_offer5
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsR_offer5Name]))
                {
                    return HttpContext.Current.Request[qsR_offer5Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [extra_rebate_amount5]   qsExtra_rebate_amount5Name & qsExtra_rebate_amount5
        public const string qsExtra_rebate_amount5Name = "extra_rebate_amount5";
        public static string qsExtra_rebate_amount5
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsExtra_rebate_amount5Name]))
                {

                    return HttpContext.Current.Request[qsExtra_rebate_amount5Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [rebate_amount5]   qsRebate_amount5Name & qsRebate_amount5
        public const string qsRebate_amount5Name = "rebate_amount5";
        public static string qsRebate_amount5
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsRebate_amount5Name]))
                {
                    return HttpContext.Current.Request[qsRebate_amount5Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [table_name]   qsTable_Name & qsTable
        public const string qsTable_Name = "table_name";
        public static string qsTable
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsTable_Name]))
                {
                    return HttpContext.Current.Request[qsTable_Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [action_eff_date2]   qsAction_eff_date2Name & qsAction_eff_date2
        public const string qsAction_eff_date2Name = "action_eff_date2";
        public static Nullable<DateTime> qsAction_eff_date2
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsAction_eff_date2Name]))
                {
                    if (!WebFunc.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsAction_eff_date2Name].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsAction_eff_date2Name].ToString());
                    }
                }
                return null;
            }
        }
        #endregion

        #region [con_eff_date2]   qsCon_eff_date2Name & qsCon_eff_date2
        public const string qsCon_eff_date2Name = "con_eff_date2";
        public static Nullable<DateTime> qsCon_eff_date2
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsCon_eff_date2Name]))
                {
                    if (!WebFunc.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsCon_eff_date2Name].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsCon_eff_date2Name].ToString());
                    }
                }
                return null;
            }
        }
        #endregion

        #region [plan_eff_date2]   qsPlan_eff_date2Name & qsPlan_eff_date2
        public const string qsPlan_eff_date2Name = "plan_eff_date2";
        public static Nullable<DateTime> qsPlan_eff_date2
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsPlan_eff_date2Name]))
                {
                    if (!WebFunc.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsPlan_eff_date2Name].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsPlan_eff_date2Name].ToString());
                    }
                }
                return null;
            }
        }
        #endregion

        #region [vas_eff_date2]   qsVas_eff_date2Name & qsVas_eff_date2
        public const string qsVas_eff_date2Name = "vas_eff_date2";
        public static Nullable<DateTime> qsVas_eff_date2
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsVas_eff_date2Name]))
                {
                    if (!WebFunc.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsVas_eff_date2Name].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsVas_eff_date2Name].ToString());
                    }
                }
                return null;
            }
        }
        #endregion

        #region [retrieve_date2]   qsRetrieve_date2Name & qsRetrieve_date2
        public const string qsRetrieve_date2Name = "retrieve_date2";
        public static System.Nullable<DateTime> qsRetrieve_date2
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsRetrieve_date2Name]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsRetrieve_date2Name].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsRetrieve_date2Name].ToString());
                    }
                }
                return null;
            }
        }
        #endregion

        #region [log_date2]   qsLog_date2Name & qsLog_date2
        public const string qsLog_date2Name = "log_date2";
        public static Nullable<DateTime> qsLog_date2
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsLog_date2Name]))
                {
                    if (!WebFunc.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsLog_date2Name].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsLog_date2Name].ToString());
                    }
                }
                return null;
            }
        }
        #endregion

        #region [ct_vas]   qsCt_vasName & qsCt_vas
        public const string qsCt_vasName = "ct_vas";
        public static string qsCt_vas
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsCt_vasName]))
                {
                    return HttpContext.Current.Request[qsCt_vasName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [msn_vas]   qsMsn_vasName & qsMsn_vas
        public const string qsMsn_vasName = "msn_vas";
        public static string qsMsn_vas
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsMsn_vasName]))
                {
                    return HttpContext.Current.Request[qsMsn_vasName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [sms_vas2]   qsSms_vas2Name & qsSms_vas2
        public const string qsSms_vas2Name = "sms_vas2";
        public static string qsSms_vas2
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsSms_vas2Name]))
                {
                    return HttpContext.Current.Request[qsSms_vas2Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [sms_vas]   qsSms_vasName & qsSms_vas
        public const string qsSms_vasName = "sms_vas";
        public static string qsSms_vas
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsSms_vasName]))
                {
                    return HttpContext.Current.Request[qsSms_vasName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [min_vas]   qsMin_vasName & qsMin_vas
        public const string qsMin_vasName = "min_vas";
        public static string qsMin_vas
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsMin_vasName]))
                {
                    return HttpContext.Current.Request[qsMin_vasName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [wifi_vas]   qsWifi_vasName & qsWifi_vas
        public const string qsWifi_vasName = "wifi_vas";
        public static string qsWifi_vas
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsWifi_vasName]))
                {
                    return HttpContext.Current.Request[qsWifi_vasName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [gprs_vas2]   qsGprs_vas2Name & qsGprs_vas2
        public const string qsGprs_vas2Name = "gprs_vas2";
        public static string qsGprs_vas2
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsGprs_vas2Name]))
                {
                    return HttpContext.Current.Request[qsGprs_vas2Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [gprs_vas]   qsGprs_vasName & qsGprs_vas
        public const string qsGprs_vasName = "gprs_vas";
        public static string qsGprs_vas
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsGprs_vasName]))
                {
                    return HttpContext.Current.Request[qsGprs_vasName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [moov_vas]   qsMoov_vasName & qsMoov_vas
        public const string qsMoov_vasName = "moov_vas";
        public static string qsMoov_vas
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsMoov_vasName]))
                {
                    return HttpContext.Current.Request[qsMoov_vasName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [horse_vas]   qsHorse_vasName & qsHorse_vas
        public const string qsHorse_vasName = "horse_vas";
        public static string qsHorse_vas
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsHorse_vasName]))
                {
                    return HttpContext.Current.Request[qsHorse_vasName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [order_id2]   qsOrder_id2Name & qsOrder_id2
        public const string qsOrder_id2Name = "order_id2";
        public static string qsOrder_id2
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsOrder_id2Name]))
                {
                    return HttpContext.Current.Request[qsOrder_id2Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [format]   qsFormatName & qsFormat
        public const string qsFormatName = "format";
        public static string qsFormat
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsFormatName]))
                {
                    return HttpContext.Current.Request[qsFormatName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [fast_start]   qsFast_startName & qsFast_start
        public const string qsFast_startName = "fast_start";
        public static string qsFast_start
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsFast_startName]))
                {
                    return HttpContext.Current.Request[qsFast_startName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [hschk]   qsHsName & qsHs
        public const string qsHsName = "hs";
        public static string qsHs
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsHsName]))
                {
                    return HttpContext.Current.Request[qsHsName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [action]   qsActionName & qsAction
        public const string qsActionName = "action";
        public static string qsAction
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsActionName]))
                {
                    return HttpContext.Current.Request[qsActionName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [pam]   qsProgramName & qsProgram
        public const string qsProgramName = "program";
        public static string qsProgram
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsProgramName]))
                {
                    return HttpContext.Current.Request[qsProgramName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [normal_rebate_list]   qsNormal_rebate_listName & qsNormal_rebate_list
        public const string qsNormal_rebate_listName = "normal_rebate_list";
        public static string qsNormal_rebate_list
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsNormal_rebate_listName]))
                {
                    return HttpContext.Current.Request[qsNormal_rebate_listName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [pee]   qsPlan_feeName & qsPlan_fee
        public const string qsPlan_feeName = "plan_fee";
        public static string qsPlan_fee
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsPlan_feeName]))
                {
                    return HttpContext.Current.Request[qsPlan_feeName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [cer]   qsCon_perName & qsCon_per
        public const string qsCon_perName = "con_per";
        public static string qsCon_per
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsCon_perName]))
                {
                    return HttpContext.Current.Request[qsCon_perName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [rte]   qsRebateName & qsRebate
        public const string qsRebateName = "rebate";
        public static string qsRebate
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsRebateName]))
                {
                    return HttpContext.Current.Request[qsRebateName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [fon]   qsFree_monName & qsFree_mon
        public const string qsFree_monName = "free_mon";
        public static string qsFree_mon
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsFree_monName]))
                {
                    return HttpContext.Current.Request[qsFree_monName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [hel]   qsHs_modelName & qsHs_model
        public const string qsHs_modelName = "hs_model";
        public static string qsHs_model
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsHs_modelName]))
                {
                    return HttpContext.Current.Request[qsHs_modelName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [pum]   qsPremiumName & qsPremium
        public const string qsPremiumName = "premium";
        public static string qsPremium
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsPremiumName]))
                {
                    return HttpContext.Current.Request[qsPremiumName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [sum]   qsS_premiumName & qsS_premium
        public const string qsS_premiumName = "s_premium";
        public static string qsS_premium
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsS_premiumName]))
                {
                    return HttpContext.Current.Request[qsS_premiumName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [sm2]   qsS_premium2Name & qsS_premium2
        public const string qsS_premium2Name = "s_premium2";
        public static string qsS_premium2
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsS_premium2Name]))
                {
                    return HttpContext.Current.Request[qsS_premium2Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [tld]   qsTrade_fieldName & qsTrade_field
        public const string qsTrade_fieldName = "trade_field";
        public static string qsTrade_field
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsTrade_fieldName]))
                {
                    return HttpContext.Current.Request[qsTrade_fieldName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [bundle_name]   qsBundle_nameName & qsBundle_name
        public const string qsBundle_nameName = "bundle_name";
        public static string qsBundle_name
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsBundle_nameName]))
                {
                    return HttpContext.Current.Request[qsBundle_nameName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion


        #region [rebate_amount4]   qsRebate_amount4Name & qsRebate_amount4
        public const string qsRebate_amount4Name = "rebate_amount4";
        public static string qsRebate_amount4
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsRebate_amount4Name]))
                {
                    return HttpContext.Current.Request[qsRebate_amount4Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [R_offer4]   qsR_offer4Name & qsR_offer4
        public const string qsR_offer4Name = "R_offer4";
        public static string qsR_offer4
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsR_offer4Name]))
                {
                    return HttpContext.Current.Request[qsR_offer4Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [extra_rebate_amount4]   qsExtra_rebate_amount4Name & qsExtra_rebate_amount4
        public const string qsExtra_rebate_amount4Name = "extra_rebate_amount4";
        public static string qsExtra_rebate_amount4
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsExtra_rebate_amount4Name]))
                {
                    return HttpContext.Current.Request[qsExtra_rebate_amount4Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [extra_rebate4]   qsExtra_rebate4Name & qsExtra_rebate4
        public const string qsExtra_rebate4Name = "extra_rebate4";
        public static string qsExtra_rebate4
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsExtra_rebate4Name]))
                {
                    return HttpContext.Current.Request[qsExtra_rebate4Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion


        #region [gift_desc1]   qsGift_desc1Name & qsGift_desc1
        public const string qsGift_desc1Name = "gift_desc1";
        public static string qsGift_desc1
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsGift_desc1Name]))
                {
                    return HttpContext.Current.Request[qsGift_desc1Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion


        #region [gift_desc2]   qsGift_desc2Name & qsGift_desc2
        public const string qsGift_desc2Name = "gift_desc2";
        public static string qsGift_desc2
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsGift_desc2Name]))
                {
                    return HttpContext.Current.Request[qsGift_desc2Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [gift_desc3]   qsGift_desc3Name & qsGift_desc3
        public const string qsGift_desc3Name = "gift_desc3";
        public static string qsGift_desc3
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsGift_desc3Name]))
                {
                    return HttpContext.Current.Request[qsGift_desc3Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [gift_desc4]   qsGift_desc4Name & qsGift_desc4
        public const string qsGift_desc4Name = "gift_desc4";
        public static string qsGift_desc4
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsGift_desc4Name]))
                {
                    return HttpContext.Current.Request[qsGift_desc4Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [accessory_desc1]   qsAccessory_desc1Name & qsAccessory_desc1
        public const string qsAccessory_desc1Name = "accessory_desc1";
        public static string qsAccessory_desc1
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsAccessory_desc1Name]))
                {
                    return HttpContext.Current.Request[qsAccessory_desc1Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [d_district]   qsD_districtName & qsD_district
        public const string qsD_districtName = "d_district";
        public static string qsD_district
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsD_districtName]))
                {
                    return HttpContext.Current.Request[qsD_districtName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [ord_place_hkid2]   qsOrd_place_hkid2Name & qsOrd_place_hkid2
        public const string qsOrd_place_hkid2Name = "ord_place_hkid2";
        public static string qsOrd_place_hkid2
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsOrd_place_hkid2Name]))
                {
                    return HttpContext.Current.Request[qsOrd_place_hkid2Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [mno1]   qsM_card_no1Name & qsM_card_no1
        public const string qsM_card_no1Name = "m_card_no1";
        public static string qsM_card_no1
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsM_card_no1Name]))
                {
                    return HttpContext.Current.Request[qsM_card_no1Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [mno2]   qsM_card_no2Name & qsM_card_no2
        public const string qsM_card_no2Name = "m_card_no2";
        public static string qsM_card_no2
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsM_card_no2Name]))
                {
                    return HttpContext.Current.Request[qsM_card_no2Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [mno3]   qsM_card_no3Name & qsM_card_no3
        public const string qsM_card_no3Name = "m_card_no3";
        public static string qsM_card_no3
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsM_card_no3Name]))
                {
                    return HttpContext.Current.Request[qsM_card_no3Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [mno4]   qsM_card_no4Name & qsM_card_no4
        public const string qsM_card_no4Name = "m_card_no4";
        public static string qsM_card_no4
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsM_card_no4Name]))
                {
                    return HttpContext.Current.Request[qsM_card_no4Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [hkid2]   qsHkid2Name & qsHkid2
        public const string qsHkid2Name = "hkid2";
        public static string qsHkid2
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsHkid2Name]))
                {
                    return HttpContext.Current.Request[qsHkid2Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [aed2]   qsAction_requiredName2 & qsAction_required2
        public const string qsAction_requiredName2 = "aed2";
        public static string qsAction_required2
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsAction_requiredName2]))
                {
                    return HttpContext.Current.Request[qsAction_requiredName2].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [dtype]   qsD_typeName & qsD_type
        public const string qsD_typeName = "d_type";
        public static string qsD_type
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsD_typeName]))
                {
                    return HttpContext.Current.Request[qsD_typeName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [droom]   qsD_roomName & qsD_room
        public const string qsD_roomName = "d_room";
        public static string qsD_room
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsD_roomName]))
                {
                    return HttpContext.Current.Request[qsD_roomName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [dfloor]   qsD_floorName & qsD_floor
        public const string qsD_floorName = "d_floor";
        public static string qsD_floor
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsD_floorName]))
                {
                    return HttpContext.Current.Request[qsD_floorName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [dblk]   qsD_blkName & qsD_blk
        public const string qsD_blkName = "d_blk";
        public static string qsD_blk
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsD_blkName]))
                {
                    return HttpContext.Current.Request[qsD_blkName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [dbuild]   qsD_buildName & qsD_build
        public const string qsD_buildName = "d_build";
        public static string qsD_build
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsD_buildName]))
                {
                    return HttpContext.Current.Request[qsD_buildName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [dstreet]   qsD_streetName & qsD_street
        public const string qsD_streetName = "d_street";
        public static string qsD_street
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsD_streetName]))
                {
                    return HttpContext.Current.Request[qsD_streetName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [dregion]   qsD_regionName & qsD_region
        public const string qsD_regionName = "d_region";
        public static string qsD_region
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsD_regionName]))
                {
                    return HttpContext.Current.Request[qsD_regionName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [existmon]   qsExisting_contract_end_monthName & qsExisting_contract_end_month
        public const string qsExisting_contract_end_monthName = "existing_contract_end_month";
        public static string qsExisting_contract_end_month
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsExisting_contract_end_monthName]))
                {
                    return HttpContext.Current.Request[qsExisting_contract_end_monthName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [existyear]   qsExisting_contract_end_yearName & qsExisting_contract_end_year
        public const string qsExisting_contract_end_yearName = "existing_contract_end_year";
        public static string qsExisting_contract_end_year
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsExisting_contract_end_yearName]))
                {
                    return HttpContext.Current.Request[qsExisting_contract_end_yearName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [reactive_date2]   qsReactive_date2Name & qsReactive_date2
        public const string qsReactive_date2Name = "reactive_date2";
        public static System.Nullable<DateTime> qsReactive_date2
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsReactive_date2Name]))
                {
                    if (!WebFunc.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsReactive_date2Name].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsReactive_date2Name].ToString());
                    }
                }
                return null;
            }
        }
        #endregion

 

        #endregion
    }
}