using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.IO;
using log4net;
namespace PCCW.RWL.CORE
{
    public class LoggingModule : IHttpModule
    {
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public LoggingModule() { }
        public static string[] blackList = { "\\'", "--", " OR ", "1=1" };
        public void PostAuthenticateRequest(object sender, EventArgs e)
        {
            try
            {
                log4net.LogicalThreadContext.Properties["Identity"] =
                    HttpContext.Current.User.Identity.Name;
            }
            catch (NullReferenceException)
            {
                // do nothing
            }
        }


        //Running check request values
        private void CheckInput(string x_sParameter, ref bool x_bErrorFlag){
            for (int i = 0; i < blackList.Length; i++){
                if ((x_sParameter.IndexOf(blackList[i], StringComparison.OrdinalIgnoreCase) >= 0)){
                    //Find out the error value 
                    x_bErrorFlag = true;
                    Logger.ErrorFormat("Error request value : {0}", x_sParameter);
                    break;
                }
            }
        }
        public String ModuleName{get { return "LoggingModule"; }}
        // In the Init function, register for HttpApplication 
        // events by adding your handlers.
        public void Init(HttpApplication application)
        {
            log4net.Config.XmlConfigurator.Configure();

            application.Error += new EventHandler(Application_Error);
            application.PostAuthenticateRequest += new EventHandler(PostAuthenticateRequest);

            application.BeginRequest +=
                (new EventHandler(Application_BeginRequest));
            application.EndRequest +=
                (new EventHandler(Application_EndRequest));
        }


        private void Application_BeginRequest(Object source, EventArgs e){

            if (source == null) throw new ArgumentNullException("sender");

            HttpApplication app = source as HttpApplication;
            if (app == null) throw new ArgumentException(
                string.Format("The specified sender must be of type HttpApplication. Got '{1}'.",
                source.GetType()), "sender");

            // specify the location of log4net config file
            // TODO: Read application settings to get the file location
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo(
                app.Server.MapPath("~/log4net.config")));

            log4net.LogicalThreadContext.Properties["Path"] =
                HttpContext.Current.Request.Path;
            log4net.LogicalThreadContext.Properties["ClientIP"] =
                HttpContext.Current.Request.UserHostAddress;

            bool _bErrorFlag = false;
            HttpRequest Request = (source as HttpApplication).Context.Request;
            if (!_bErrorFlag){
                foreach (string key in Request.QueryString)
                    CheckInput(Request.QueryString[key], ref _bErrorFlag);
            }
            if (!_bErrorFlag){
                foreach (string key in Request.Form)
                    CheckInput(Request.Form[key], ref _bErrorFlag);
            }
            if (!_bErrorFlag){
                foreach (string key in Request.Cookies)
                    CheckInput(Request.Cookies[key].Value, ref _bErrorFlag);
            }
            if (_bErrorFlag)
                HttpContext.Current.Response.Redirect("~/Web/Error/ApplicationError.aspx?ErrorRequestProcess=true");

            if (Request["ErrorRequestProcess"] == "true"){
                // Create HttpApplication and HttpContext objects to access
                // request and response properties.
                HttpApplication application = (HttpApplication)source;
                HttpContext context = application.Context;
                context.Response.Write("<h1><font color=red> Retention web log : Beginning of Request Error! </font></h1><hr><hr><h1><font color=red><a href='../../../chk_login.asp'> Return to CCWEB main page!</a></font></h1>");
            }
        }

        public void Application_Error(object sender, EventArgs e)
        {
            HttpContext context = HttpContext.Current;
            Exception ex = context.Server.GetLastError();
            ILog logger = LogManager.GetLogger("Default");

            if (ex == null || !(ex is HttpUnhandledException))
            {
                logger.Fatal("An unknown exception has occurred. No Exception object is returned or the returned object is not a HttpUnhandledException.");
                return;
            }

            if (ex.InnerException == null)
            {
                logger.Fatal(ex.Message, ex);
                return;
            }
            else
            {
                logger.Fatal(ex.InnerException.Message, ex.InnerException);
            }
        }

        private void Application_EndRequest(Object source, EventArgs e)
        {
            /*
            HttpApplication application = (HttpApplication)source;
            HttpContext context = application.Context;
            context.Response.Write("<hr><h1><font color=red><a href='../../../chk_login.asp'> Return to CCWEB main page!</a></font></h1>");
             */
        }

        public void Dispose()
        {
            //no-op    
        }
    }
}
