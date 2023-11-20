using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Text;
using System.Xml.Linq;
using PCCW.RWL.CORE;
public partial class _500 : System.Web.UI.Page
{
    ErrorMonitor _oErrorMonitor = new ErrorMonitor();
    private Exception LastError { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SetError();
            LastError = Server.GetLastError();
            if (LastError is HttpUnhandledException)
            {
                LastError = ((HttpUnhandledException)LastError).InnerException;
            }
            string heading;
            string description;
            if (LastError is BusinessObjectNotFoundException)
            {
                heading = "Not found";
                description = "System cannot find the data you asked for. Please make sure your input is correct and try again.";
            }
            else if (LastError is WebFormArgumentException)
            {
                heading = "Wrong input";
                description = "Your input contained wrong data. Please make sure your input is correct and try again.";
            }
            else if (LastError is UnauthorizedAccessException)
            {
                heading = "Unauthorized";
                description = "The action you are trying to perform is not allowed.";
            }
            else
            {
                heading = "Too Busy";
                description = "System is currently too busy. Please try again later.";
            }

            Heading.Text = heading;
            Description.Text = description;
            UserInformation.Text = getUserInformationString();
            Server.ClearError();
        }
    }

    protected void SetError()
    {
        

        ErrorMonitor _oErrorMonitor = new ErrorMonitor();
        String pageErrorOccured = (HttpContext.Current.Session[ErrorMonitor.SessionErrLog.PageErrorOccured] != null) ? Convert.ToString(Session[ErrorMonitor.SessionErrLog.PageErrorOccured]) : string.Empty;

        //String errorSource =(HttpContext.Current.Session[ErrorMonitor.SessionErrLog.ErrorSource]!=null) ? Convert.ToString(Session[ErrorMonitor.SessionErrLog.ErrorSource]) : string.Empty;
        String errorMsg = (HttpContext.Current.Session[ErrorMonitor.SessionErrLog.ErrorMsg] != null) ? Convert.ToString(Session[ErrorMonitor.SessionErrLog.ErrorMsg]) : string.Empty;
        String stackTrace = (HttpContext.Current.Session[ErrorMonitor.SessionErrLog.StackTrace] != null) ? Convert.ToString(Session[ErrorMonitor.SessionErrLog.StackTrace]) : string.Empty;
        //String errorForm =(HttpContext.Current.Session[ErrorMonitor.SessionErrLog.ErrorForm]!=null) ? Convert.ToString(Session[ErrorMonitor.SessionErrLog.ErrorForm]) : string.Empty;
        //String errorQuesryString =(Session[ErrorMonitor.SessionErrLog.ErrorQueryString]!=null) ? Convert.ToString(Session[ErrorMonitor.SessionErrLog.ErrorQueryString]) : string.Empty;
        String targetSite = (HttpContext.Current.Session[ErrorMonitor.SessionErrLog.TargetSite] != null) ? Convert.ToString(Session[ErrorMonitor.SessionErrLog.TargetSite]) : string.Empty;
        String userHostAddress = (HttpContext.Current.Session[ErrorMonitor.SessionErrLog.UserHostAddress] != null) ? Convert.ToString(Session[ErrorMonitor.SessionErrLog.UserHostAddress]) : string.Empty;
        String uid = (HttpContext.Current.Session["uid"] == null) ? Convert.ToString(Session["uid"]) : string.Empty;
        String innerException = (HttpContext.Current.Session[ErrorMonitor.SessionErrLog.InnerException] != null) ? Convert.ToString(Session[ErrorMonitor.SessionErrLog.InnerException]) : string.Empty;
        String errorUrl = (HttpContext.Current.Session[ErrorMonitor.SessionErrLog.ErrorUrl] != null) ? Convert.ToString(Session[ErrorMonitor.SessionErrLog.ErrorUrl]) : string.Empty;

        if (pageErrorOccured != "")
        {
            GoBackLink.PostBackUrl = pageErrorOccured;
            _oErrorMonitor.ErrorOccured(uid, errorUrl, innerException, stackTrace, userHostAddress); //insert to database and get the dataset data
        }
        else
        {
            GoBackLink.OnClientClick = "javascript:history.go(-1)";
        }

        //Clear the session about error to release resource
        HttpContext.Current.Session[ErrorMonitor.SessionErrLog.PageErrorOccured] = null;
        HttpContext.Current.Session[ErrorMonitor.SessionErrLog.ErrorMsg] = null;
        HttpContext.Current.Session[ErrorMonitor.SessionErrLog.StackTrace] = null;
        HttpContext.Current.Session[ErrorMonitor.SessionErrLog.TargetSite] = null;
        HttpContext.Current.Session[ErrorMonitor.SessionErrLog.UserHostAddress] = null;
        HttpContext.Current.Session[ErrorMonitor.SessionErrLog.InnerException] = null;
        HttpContext.Current.Session[ErrorMonitor.SessionErrLog.ErrorUrl] = null;
    }


    protected string getUserInformationString()
    {
        StringBuilder builder = new StringBuilder();

        builder.Append(string.Format("Time: {0}", DateTime.Now.ToString("dd MMM yyyy HH:mm:ss.fff")));
        //RWLFramework.CurrentUser[this.Page].
        if (!string.IsNullOrEmpty(RWLFramework.CurrentUser[this.Page].Uid))
        {
            builder.Append(string.Format("<br />User id: {0}", RWLFramework.CurrentUser[this.Page].Uid));
        }
        if (!string.IsNullOrEmpty(Request.UserHostAddress))
        {
            builder.Append(string.Format("<br />Address: {0}", Request.UserHostAddress));
        }
        if (!string.IsNullOrEmpty(Request.Url.AbsolutePath))
        {
            builder.Append(string.Format("<br />Path: {0}", Request.Url.AbsolutePath));
        }

        return builder.ToString();
    }


}
