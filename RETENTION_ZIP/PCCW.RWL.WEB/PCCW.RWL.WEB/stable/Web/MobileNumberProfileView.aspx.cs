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
using System.Text;
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
using System.Globalization;
using DnaExpress.Web.UI.WebControls;
public partial class Web_MobileNumberProfileView : System.Web.UI.Page
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
    string[] _oFormat = new string[] { "dd/MM/yyyy", "d/MM/yyyy", "dd/M/yyyy", "d/M/yyyy" };
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
        RWLFramework.DataBaseConfigSetting();
        MobileNumberProfileObj.ConnectionString = SYSConn<MSSQLConnect>.Connect().ConnectionStr;
    }

    protected void AspxMobileNumberProfileGV_Init(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
        MobileNumberProfileObj.ConnectionString = SYSConn<MSSQLConnect>.Connect().ConnectionStr;
    }

    protected void MobileNumberProfileObj_Init(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
        MobileNumberProfileObj.ConnectionString = SYSConn<MSSQLConnect>.Connect().ConnectionStr;
    }

    protected void AspxMobileNumberProfileGV_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Disable")
        {
            int _iIndex;
            if (int.TryParse(e.CommandArgument.ToString(), out _iIndex))
            {
                GridView _oGridView = (GridView)sender;
                GridViewRow _oGridViewRow = (GridViewRow)AspxMobileNumberProfileGV.Rows[_iIndex];
                string _sMid = _oGridViewRow.Cells[1].Text;
                if (!string.IsNullOrEmpty(_sMid))
                {
                    int _iMid;
                    bool _bFlag = false;
                    if (int.TryParse(_sMid, out _iMid))
                    {
                        MobileNumberProfile _oMobileNumberProfile = new MobileNumberProfile(SYSConn<MSSQLConnect>.Connect(), _iMid);
                        if (_oMobileNumberProfile.GetFound())
                        {
                            _oMobileNumberProfile.SetDid(RWLFramework.CurrentUser[this.Page].Uid);
                            _oMobileNumberProfile.SetDdate(DateTime.Now);
                            _oMobileNumberProfile.SetActive(false);
                            _bFlag = _oMobileNumberProfile.Save();
                        }
                        else
                            _bFlag = false;

                        if (_bFlag)
                        {
                            AspxMobileNumberProfileGV.DataBind();
                            RegisterJavaScript(string.Empty, "jAlert('Update Success!', 'System Message');", true);
                        }
                        else
                            RegisterJavaScript(string.Empty, "jAlert('Update Fail!', 'System Message');", true);
                    }
                }
            }
        }
    }
    

    protected void AspxMobileNumberProfileGV_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        if (e.RowIndex != -1)
        {
            GridView _oGridView = (GridView)sender;
            GridViewRow _oGridViewRow = (GridViewRow)_oGridView.Rows[e.RowIndex];

            Literal _oCdate = (Literal)_oGridViewRow.FindControl("cdate");
            if (_oCdate != null)
            {
                if (_oCdate.Text != string.Empty)
                {
                    DateTime _dCdate;
                    if (DateTime.TryParseExact(_oCdate.Text, _oFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dCdate))
                        e.NewValues["cdate"] = _dCdate;
                    else
                        e.NewValues["cdate"] = null;
                }
            }



        }
    }

    #region RegisterJavaScript
    protected void RegisterJavaScript(string x_sID, string x_sScript, bool x_bIncludeScript)
    {
        if (x_bIncludeScript) x_sScript = "<script>" + x_sScript + "</script>";
        ScriptManager.RegisterStartupScript(this.Page, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), x_sScript, false);
    }
    #endregion
    
}
