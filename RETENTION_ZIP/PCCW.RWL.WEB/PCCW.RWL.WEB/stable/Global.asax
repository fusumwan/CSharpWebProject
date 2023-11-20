<%@ Application Language="C#" %>
<%@ Import Namespace="PCCW.RWL.CORE" %>
<script runat="server">
    void Application_BeginRequest(object sender, EventArgs e)
    {
         ConfigureLogging();
    }
    void Application_Start(object sender, EventArgs e) 
    {
        // Code that runs on application startup
       

    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown

    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        
        // Code that runs when an unhandled error occurs
        if (Request.CurrentExecutionFilePath != string.Empty)
        {
            Exception _oServerLastError = Server.GetLastError();
            if (HttpContext.Current.Session != null && _oServerLastError != null)
            {
                HttpContext.Current.Session[ErrorMonitor.SessionErrLog.ErrorMsg] = "No error information was available";
                HttpContext.Current.Session[ErrorMonitor.SessionErrLog.ExceptionType] = null;
                HttpContext.Current.Session[ErrorMonitor.SessionErrLog.PageErrorOccured] = Request.CurrentExecutionFilePath;
                HttpContext.Current.Session[ErrorMonitor.SessionErrLog.StackTrace] = null;
                HttpContext.Current.Session[ErrorMonitor.SessionErrLog.PageErrorOccured] = Request.CurrentExecutionFilePath;
                //HttpContext.Current.Session[ErrorMonitor.SessionErrLog.ErrorSource] = _oServerLastError.Source;
                HttpContext.Current.Session[ErrorMonitor.SessionErrLog.InnerException] = _oServerLastError.InnerException;
                if (!string.IsNullOrEmpty(_oServerLastError.Message))
                    HttpContext.Current.Session[ErrorMonitor.SessionErrLog.ErrorMsg] = _oServerLastError.Message;

                HttpContext.Current.Session[ErrorMonitor.SessionErrLog.StackTrace] = _oServerLastError.StackTrace;
                ///HttpContext.Current.Session[ErrorMonitor.SessionErrLog.ErrorForm] = Request.Form.ToString();
                //HttpContext.Current.Session[ErrorMonitor.SessionErrLog.ErrorQueryString] = Request.QueryString.ToString();
                HttpContext.Current.Session[ErrorMonitor.SessionErrLog.TargetSite] = _oServerLastError.TargetSite;
                HttpContext.Current.Session[ErrorMonitor.SessionErrLog.UserHostAddress] = Request.UserHostAddress;
                HttpContext.Current.Session[ErrorMonitor.SessionErrLog.ErrorUrl] = Request.Url.ToString();
                Server.Transfer("~/500.aspx");
            }
        }
        
    }

    void Session_Start(object sender, EventArgs e) 
    {
        // Code that runs when a new session is started

    }

    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }
    protected void ConfigureLogging()
    {
        string logFile = HttpContext.Current.Request.PhysicalApplicationPath + "log4net.config";
        if (System.IO.File.Exists(logFile))
        {
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new System.IO.FileInfo(logFile));
        }
    }

    
</script>
