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
using System.Xml.Linq;
using System.Globalization;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;

public partial class MessageViewAction : NEURON.WEB.UI.BasePage
{
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion

    #region SessionUid
    string n_sSessionUid
    {
        get
        {
            if (Session["uid"] != null)
            {
                return Session["uid"].ToString();
            }
            else
                return string.Empty;
        }
    }
    #endregion

    #region SessionLv
    string n_sSessionLv
    {
        get
        {
            if (Session["lv"] != null)
            {
                return Session["lv"].ToString();
            }
            else
                return string.Empty;
        }
    }
    #endregion

    #region SessionArprog
    string n_sSessionArprog
    {
        get
        {
            if (Session["arprog"] != null)
            {
                return Session["arprog"].ToString();
            }
            else
                return string.Empty;
        }
    }
    #endregion

    #region SessionChannel
    string n_sSessionChannel
    {
        get
        {
            if (Session["channel"] != null)
            {
                return Session["channel"].ToString();
            }
            else
                return string.Empty;
        }
    }
    #endregion

    string[] _oFormat = new string[] { 
        "dd/MM/yyyy","dd/M/yyyy","d/MM/yyyy",  "d/M/yyyy"
        };
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

        

    }
    protected void EventMsgDetailGw_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
       
        if (e.RowIndex != -1)
        {
            GridView _oGridView = (GridView)sender;
            GridViewRow _oGridViewRow = (GridViewRow)_oGridView.Rows[e.RowIndex];
            TextBox _oEventMsgDetail_sdate = (TextBox)_oGridViewRow.FindControl("EventMsgDetail_sdate");
            TextBox _oEventMsgDetail_edate = (TextBox)_oGridViewRow.FindControl("EventMsgDetail_edate");
            TextBox _oEventMsgDetail_cdate = (TextBox)_oGridViewRow.FindControl("EventMsgDetail_cdate");
            TextBox _oEventMsgDetail_ddate = (TextBox)_oGridViewRow.FindControl("EventMsgDetail_ddate");
            if (_oEventMsgDetail_sdate.Text != string.Empty)
            {
                DateTime _dSdate;
                if (DateTime.TryParseExact(_oEventMsgDetail_sdate.Text, _oFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dSdate))
                {
                    e.NewValues["EventMsgDetail_sdate"] = _dSdate;
                }
            }
            if (_oEventMsgDetail_edate.Text != string.Empty)
            {
                DateTime _dEdate;
                if (DateTime.TryParseExact(_oEventMsgDetail_edate.Text, _oFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dEdate))
                {
                    e.NewValues["EventMsgDetail_edate"] = _dEdate;
                }
            }

            if (_oEventMsgDetail_cdate.Text!=string.Empty)
            {
                DateTime _dCdate;
                if (DateTime.TryParseExact(_oEventMsgDetail_cdate.Text, _oFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dCdate))
                {
                    e.NewValues["EventMsgDetail_cdate"] = _dCdate;
                }
            }
            if (_oEventMsgDetail_ddate.Text != string.Empty)
            {
                DateTime _dDdate;
                if (DateTime.TryParseExact(_oEventMsgDetail_ddate.Text, _oFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dDdate))
                {
                    e.NewValues["EventMsgDetail_ddate"] = _dDdate;
                }
            }
        }
    }

    protected void EventMsgDetailFormView_ItemInserting(object sender, FormViewInsertEventArgs e)
    {
        
        if (e.Values["EventMsgDetail_sdate"] != null)
        {
            DateTime _dSdate;
            if (DateTime.TryParseExact(e.Values["EventMsgDetail_sdate"].ToString(), _oFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dSdate))
            {
                e.Values["EventMsgDetail_sdate"] = _dSdate;
            }
            else
            {
                e.Values["EventMsgDetail_sdate"] = null;
            }
        }
        if (e.Values["EventMsgDetail_edate"] != null)
        {
            DateTime _dEdate;
            if (DateTime.TryParseExact(e.Values["EventMsgDetail_edate"].ToString(), _oFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dEdate))
            {
                e.Values["EventMsgDetail_edate"] = _dEdate;
            }
            else
            {
                e.Values["EventMsgDetail_edate"] = null;
            }
        }
 
        e.Values["EventMsgDetail_cid"] = n_sSessionUid;
        
    }

    public string RunJavascriptFunc(string x_sFunc, bool x_bIncludeScript)
    {
        string _sFunc = ((x_sFunc.IndexOf(';') > 0) ? x_sFunc : x_sFunc + ";");
        if (x_bIncludeScript) _sFunc = "<script>" + _sFunc + "</script>";

        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sFunc + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), _sFunc, false);

        return _sFunc;
    }

    protected void EventMsgDetailFormView_ItemInserted(object sender, FormViewInsertedEventArgs e)
    {
        RunJavascriptFunc("alert('Create Message Success!')",true);
        EventMsgDetailGw.DataBind();
    }
    protected void EventMsgDetailObjSource_Init(object sender, EventArgs e)
    {
        EventMsgDetailObjSource.SelectParameters.Add("x_sFilter", string.Empty);
    }
}
