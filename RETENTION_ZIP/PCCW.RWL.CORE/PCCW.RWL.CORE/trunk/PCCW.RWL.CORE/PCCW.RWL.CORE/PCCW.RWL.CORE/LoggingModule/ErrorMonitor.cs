using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Net.Mail;
using System.Globalization;
using PCCW.RWL.CORE;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
namespace PCCW.RWL.CORE
{
    public class ErrorMonitor
    {
        public class SessionErrLog
        {
            public const string PageErrorOccured = "PageErrorOccured";
            public const string ErrorMsg = "ErrorMsg";
            public const string StackTrace = "StackTrace";
            public const string TargetSite = "TargetSite";
            public const string UserHostAddress = "UserHostAddress";
            public const string Uid = "uid";
            public const string InnerException = "InnerException";
            public const string ErrorUrl = "ErrorUrl";
            public const string ErrorSource = "ErrorSource";
            public const string ErrorForm = "ErrorForm";
            public const string ErrorQueryString = "ErrorQueryString";
            public const string ExceptionType = "ExceptionType";
        }
        public ErrorLog ErrorLogProfile = new ErrorLog();
        /// <summary>
        /// Error Ocrrured
        /// </summary>
        /// <param name="x_sUid"></param>
        /// <param name="x_sErrorUrl"></param>
        /// <param name="x_sInnerException"></param>
        /// <param name="x_sStackTrace"></param>
        /// <param name="x_sUserHostAddress"></param>
        public void ErrorOccured(String x_sUid, String x_sErrorUrl, String x_sInnerException, String x_sStackTrace, String x_sUserHostAddress)
        {
            RWLFramework.DataBaseConfigSetting();
            DataSet _oErrorDataSet = InsertNewError(x_sUid, x_sErrorUrl, x_sInnerException, x_sStackTrace, x_sUserHostAddress);
            List<FaultReporterEntity> _oFaultReporterList = ListOutFaultReporter();
            SendEmail(_oFaultReporterList, _oErrorDataSet);
        }
        /// <summary>
        /// Find Out List Of Fault Report
        /// </summary>
        /// <returns></returns>
        protected List<FaultReporterEntity> ListOutFaultReporter()
        {
            List<FaultReporterEntity> FaultReporterList = FaultReporterRepository.GetListObj(SYSConn<MSSQLConnect>.Connect(), 0, null, null, "id");
            if (FaultReporterList == null) FaultReporterList = new List<FaultReporterEntity>();
            return FaultReporterList;
        }
        /// <summary>
        /// Email for error email reporting
        /// </summary>
        /// <param name="x_oFaultReporterList"></param>
        /// <param name="x_oErrorDataSet"></param>
        /// <returns></returns>
        private String SendEmail(List<FaultReporterEntity> x_oFaultReporterList, DataSet x_oErrorDataSet)
        {
            if (x_oFaultReporterList == null) { return string.Empty; }
            if (x_oErrorDataSet == null) { return string.Empty; }
            if (x_oErrorDataSet.Tables.Count <= 0) { return string.Empty; }
            if (x_oErrorDataSet.Tables[0].Rows.Count <= 0) { return string.Empty; }
            StringBuilder _oEmailContentStyleBuilder = new StringBuilder();
            _oEmailContentStyleBuilder.Append("<html><head><title>Retention Web Platform - Error Log</title></head><body>");
            _oEmailContentStyleBuilder.Append(@"<style type=""text/css"">");
            _oEmailContentStyleBuilder.Append("<!--" + Environment.NewLine);
            _oEmailContentStyleBuilder.Append("body{background:#ecf0f6;color:#000000;font:12px Verdana,Arial,Helvetica,sans-serif;margin:6px;padding:0;" + Environment.NewLine);
            _oEmailContentStyleBuilder.Append("scrollbar-3dlight-color:#d1d7dc;" + Environment.NewLine);
            _oEmailContentStyleBuilder.Append("scrollbar-arrow-color:#006699;" + Environment.NewLine);
            _oEmailContentStyleBuilder.Append("scrollbar-darkshadow-color:#98aab1;" + Environment.NewLine);
            _oEmailContentStyleBuilder.Append("scrollbar-face-color:#dee3e7;" + Environment.NewLine);
            _oEmailContentStyleBuilder.Append("scrollbar-highlight-color:#ffffff;" + Environment.NewLine);
            _oEmailContentStyleBuilder.Append("scrollbar-shadow-color:#dee3e7;" + Environment.NewLine);
            _oEmailContentStyleBuilder.Append("scrollbar-track-color:#efefef}" + Environment.NewLine);
            _oEmailContentStyleBuilder.Append(".font,th,td,p{font:12px Verdana,Arial,Helvetica,sans-serif}" + Environment.NewLine);
            _oEmailContentStyleBuilder.Append(".gensmall{font-size:10px}" + Environment.NewLine);
            _oEmailContentStyleBuilder.Append("td.genmed,.genmed{font-size:11px}" + Environment.NewLine);
            _oEmailContentStyleBuilder.Append(".explaintitle{font-size:11px;font-weight:bold;color:#5c81b1}" + Environment.NewLine);
            _oEmailContentStyleBuilder.Append(".forumline{background:#ffffff;border:1px solid #006699}" + Environment.NewLine);
            _oEmailContentStyleBuilder.Append("td.cat{font-weight:bold;letter-spacing:1px;background:#d9e2ec url(images/cellpic1.gif);" + Environment.NewLine);
            _oEmailContentStyleBuilder.Append("height:29px;text-indent:4px}" + Environment.NewLine);
            _oEmailContentStyleBuilder.Append(".row1{background:#eaedf4}" + Environment.NewLine);
            _oEmailContentStyleBuilder.Append(".row2,.helpline{background:#d9e2ec}" + Environment.NewLine);
            _oEmailContentStyleBuilder.Append("td.cat1{background:#EDCBE2}" + Environment.NewLine);
            _oEmailContentStyleBuilder.Append("td.spacerow{background:#cad9ea}" + Environment.NewLine);
            _oEmailContentStyleBuilder.Append("td.rowpic{background:url(images/cellpic2.jpg) #ffffff repeat-y}" + Environment.NewLine);
            _oEmailContentStyleBuilder.Append("th{background:#005eb2 url(images/cellpic3.gif);color:#deeef3;font-size:11px;" + Environment.NewLine);
            _oEmailContentStyleBuilder.Append("font-weight:bold;height:27px;white-space:nowrap;text-align:center;padding-left:8px;padding-right:8px}" + Environment.NewLine);
            _oEmailContentStyleBuilder.Append("input.button,input.liteoption{border:1px solid #000000;background:#fafafa;font-size:9px}");
            _oEmailContentStyleBuilder.Append(".forumline{background:#ffffff;border:1px solid #006699}" + Environment.NewLine);
            _oEmailContentStyleBuilder.Append("-->" + Environment.NewLine);
            _oEmailContentStyleBuilder.Append("</style>");

            string _sSubject = "Retention Web Platform  - Error Log";  //Email Subject

            string _sStack_trace = string.Empty;
            string _sId = string.Empty;
            string _sLog_date = string.Empty;
            string _sUid = string.Empty;
            string _sIp = string.Empty;
            string _sPage = string.Empty;
            string _sErr_msg = string.Empty;
            IDSQuery _oDSQuery = IDSQuery.CreateDsCriteria(x_oErrorDataSet, "ErrorLog");
            while (_oDSQuery.Read())
            {
                _sStack_trace = _oDSQuery[ErrorLog.Para.stack_trace].ToString();
                _sId = _oDSQuery[ErrorLog.Para.id].ToString();
                _sLog_date = _oDSQuery[ErrorLog.Para.log_date].ToString();
                _sUid = _oDSQuery[ErrorLog.Para.uid].ToString();
                _sIp = _oDSQuery[ErrorLog.Para.ip].ToString();
                _sPage = _oDSQuery[ErrorLog.Para.page].ToString();
                _sErr_msg = _oDSQuery[ErrorLog.Para.err_msg].ToString();
            }
            _oDSQuery.Close();
            Hashtable _oToAddrContent = new Hashtable();
            for (int i = 0; i < x_oFaultReporterList.Count; i++)
            {
                FaultReporterEntity _oFaultReporter = x_oFaultReporterList[i];
                StringBuilder _oEmailContent = new StringBuilder();
                _oEmailContent.Append(_oEmailContentStyleBuilder.ToString());
                _oEmailContent.Append("<html><head><title>Retention Web Platform - Error Log</title></head><body>");
                _oEmailContent.Append("Dear " + _oFaultReporter.name + ",<br><br>");
                _oEmailContent.Append("Retention Web Log system reported an error. Details are summarized as below:<br><br>");
                _oEmailContent.Append(@"<table width=""100%"">");
                _oEmailContent.Append(@"<tr><th colspan=""2"">Call Center &amp; Retail Web Platform - Error Logs</th></tr>");
                _oEmailContent.Append(@"<tr><td colspan=""2""><input type=""button"" class=""button"" value=""PRINT"" name=""PRN"" onClick=""window.print()""></td></tr>");
                _oEmailContent.Append(@"<tr><td class=""row1"" width=""20%""><span class=""explaintitle"">Reference Number</span></td><td class=""row2""><span class=""gensmall"">" + _sId + " </span></td></tr>");
                _oEmailContent.Append(@"<tr><td class=""row1"" width=""20%""><span class=""explaintitle"">Date/Time</span></td><td class=""row2""><span class=""gensmall"">" + _sLog_date + "</span></td></tr>");
                _oEmailContent.Append(@"<tr><td class=""row1"" width=""20%""><span class=""explaintitle"">Sender</span></td><td class=""row2""><span class=""gensmall"">" + _sUid + "</span></td></tr>");
                _oEmailContent.Append(@"<tr><td class=""row1"" width=""20%""><span class=""explaintitle"">IP Address</span></td><td class=""row2""><span class=""gensmall"">" + _sIp + "</span></td></tr>");
                _oEmailContent.Append(@"<tr><td class=""row1"" width=""20%""><span class=""explaintitle"">Page</span></td><td class=""row2""><span class=""gensmall"">" + _sPage + "</span></td></tr>");
                _oEmailContent.Append(@"<tr><td class=""row1"" width=""20%""><span class=""explaintitle"">Details</span></td><td class=""row2""><span class=""gensmall"">" + _sErr_msg + "<br /><br />");
                _oEmailContent.Append(_sStack_trace);
                _oEmailContent.Append(@"</span></td></tr>");
                _oEmailContent.Append("</table><br>");
                _oEmailContent.Append("Best Regards,<br><br>Automatic Error Reporting System<br><br>(This is a computer generated email, please do not reply!)<br><br>");
                _oEmailContent.Append("</body></html>");
                if (string.IsNullOrEmpty(_oFaultReporter.email))
                {
                    if (_oToAddrContent.ContainsKey(_oFaultReporter.email))
                    {
                        //Get the owner addresses
                        _oToAddrContent.Add(_oFaultReporter.email, _oEmailContent.ToString());
                    }
                }
            }
            try
            {
                IDictionaryEnumerator _oItem = _oToAddrContent.GetEnumerator();
                while (_oItem.MoveNext())
                {
                    MailMessage _oMailMsg = new MailMessage();
                    string _sSMTPServer = "136.139.22.21";   //SMTP Server IP Address
                    string _sFromAddr = "PCCW-OICSupport@pccw.com";   //Email address from 

                    MailAddress _oFrom = new MailAddress(_sFromAddr); // Add From Email Address
                    _oMailMsg.To.Add(_oItem.Key.ToString());//Add To Email addresses 
                    _oMailMsg.Body = _oItem.Value.ToString();
                    _oMailMsg.Subject = _sSubject;
                    _oMailMsg.From = _oFrom;
                    _oMailMsg.IsBodyHtml = true;
                    _oMailMsg.BodyEncoding = System.Text.Encoding.UTF8;
                    SmtpClient _oEmailClient = new SmtpClient(_sSMTPServer);
                    _oEmailClient.Port = 2525;
                    _oEmailClient.Send(_oMailMsg);
                }

            }//End Try
            catch
            {

            }

            return String.Empty;
        }



        /// <summary>
        /// When the system is getting the error will insert to database for reference.
        /// </summary>
        /// <param name="x_sUid"></param>
        /// <param name="x_sErrorUrl"></param>
        /// <param name="x_sInnerException"></param>
        /// <param name="x_sStackTrace"></param>
        /// <param name="x_sUserHostAddress"></param>
        /// <returns></returns>
        public DataSet InsertNewError(String x_sUid, String x_sErrorUrl, String x_sInnerException, String x_sStackTrace, String x_sUserHostAddress)
        {
            int _iID = -1;
            SessionFactory<MSSQLConnect> _oSessionFactory = new SessionFactory<MSSQLConnect>();
            ISession<MSSQLConnect> _oSession = null;
            using (_oSession = _oSessionFactory.OpenSession())
            using (ITransaction _oTransaction = _oSession.BeginTransaction())
            {
                bool _bRollBack = false;
                ErrorLogProfile.SetDB(SYSConn<MSSQLConnect>.Connect());
                ErrorLogProfile.SetLog_date(DateTime.Now);
                ErrorLogProfile.SetUid(x_sUid);
                ErrorLogProfile.SetPage(x_sErrorUrl);
                ErrorLogProfile.SetErr_msg(x_sInnerException);
                ErrorLogProfile.SetStack_trace(x_sStackTrace);
                ErrorLogProfile.SetIp(x_sUserHostAddress);
                _iID = _oSession.InsertReturnID(ErrorLogProfile, true);
                if (_iID <= 0) { _bRollBack = true; }
                ErrorLogProfile.SetId(_iID);
                if (!_bRollBack)
                    _oTransaction.Commit();
                else
                    _oTransaction.Rollback();
            }
            return ErrorLogBal.GetDataSet(SYSConn<MSSQLConnect>.Connect(), "id,log_date,uid,page,err_msg,stack_trace,ip", "id='" + _iID.ToString() + "'", null, null);
        }

    }
}
