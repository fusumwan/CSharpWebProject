using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
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

public partial class Web_ProfileTeamManagement : NEURON.WEB.UI.BasePage
{
    string[] _oFormat = new string[] { "dd/MM/yyyy", "d/MM/yyyy", "dd/M/yyyy", "d/M/yyyy" };
    StringBuilder RegisterJSScript = new StringBuilder();
    static List<string> _oSalemanCode;
    public string sortOrder { get { if (ViewState["sortOrder"].ToString() == "desc") { ViewState["sortOrder"] = "asc"; } else { ViewState["sortOrder"] = "desc"; } return ViewState["sortOrder"].ToString(); } set { ViewState["sortOrder"] = value; } }

    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
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

        WebFunc.PrivilegeCheck(this.Page);
        if (!IsPostBack) { InitFrame(); }
    }
    #region PageLoadComplete
    protected void Page_LoadComplete(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Session["ProfileTeamSql"] = "";
            ViewState["sortOrder"] = "";
            BindData("", "");
        }
    }
    #endregion

    protected void Page_Render(HtmlTextWriter x_oWriter)
    {
        base.Render(x_oWriter);
    }

    protected void Page_PreRenderComplete(object sender, EventArgs arg)
    {
        RegisterJavaScript(string.Empty, RegisterJSScript.ToString(), true);
    }


    protected void Page_Unload(object sender, EventArgs e)
    {
        
    }
    

    protected void InitFrame()
    {
        if (!IsPostBack){
            if (SortDirection.Ascending == ProfileTeamRecordGV.SortDirection)
                BindData(ProfileTeamRecordGV.SortExpression, "asc");
            else
                BindData(ProfileTeamRecordGV.SortExpression, "desc");
        }
    }

    protected void BindData(string x_sSortExp, string x_sSortDir)
    {
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("SELECT * FROM [ProfileTeamRecord]");

        if (string.IsNullOrEmpty(x_sSortExp))
            _oQuery.Append(" ORDER BY id " + x_sSortDir);
        else
            _oQuery.Append(" ORDER BY " + x_sSortExp + " " + x_sSortDir);

        Session["ProfileTeamSql"] = _oQuery.ToString();
        ProfileTeamRecordGV.DataSource = SYSConn<MSSQLConnect>.Connect().GetDS(_oQuery.ToString());
        ProfileTeamRecordGV.DataBind();
    }

    public bool CheckActive(object x_bActive)
    {
        
        if (x_bActive == null) return false;
        if (((bool)x_bActive) == false) return false; 
        return true;
    }

    protected List<string> GetAllSalemanCode()
    {
        if (_oSalemanCode == null || !IsPostBack)
            _oSalemanCode = SaleManCodeProfile.GetAllSalemanCode();

        return _oSalemanCode;
    }

    protected void ProfileTeamRecordGV_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        
    }

    protected void ProfileTeamFV_ItemCommand(object sender, FormViewCommandEventArgs e)
    {
        if (e.CommandName == "EDIT")
        {
            GridView _oGridView = (GridView)sender;
            GridViewRow _oGridViewRow = (GridViewRow)ProfileTeamRecordGV.Rows[_oGridView.EditIndex];
            TextBox _oSdate = (TextBox)_oGridViewRow.FindControl("sdate");
            //_oSdate.ReadOnly = true;
            //SetReadOnly(_oSdate.ClientID.ToString());

            TextBox _oEdate = (TextBox)_oGridViewRow.FindControl("edate");
            //_oEdate.ReadOnly = true;
            //SetReadOnly(_oEdate.ClientID.ToString());
        }
    }


    #region Run Javascript Function
    public string RunJavascriptFunc(string x_sFunc, bool x_bIncludeScript, bool x_bRunRegister)
    {
        string _sFunc = ((x_sFunc.IndexOf(';') > 0) ? x_sFunc : x_sFunc + ";");
        if (x_bIncludeScript) _sFunc = "<script>" + _sFunc + "</script>";
        if (x_bRunRegister)
            ScriptManager.RegisterStartupScript(this, this.GetType(), x_sFunc + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), _sFunc, false);
        else
            RegisterJSScript.AppendLine(_sFunc);
        return _sFunc;
    }


    public string RunJavascriptFunc(string x_sFunc)
    {
        return RunJavascriptFunc(x_sFunc, false, false);
    }
    #endregion

    #region RegisterJavaScript
    protected void RegisterJavaScript(string x_sID, string x_sScript, bool x_bIncludeScript)
    {
        if (x_bIncludeScript) x_sScript = "<script>" + x_sScript + "</script>";
        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), x_sScript, false);
    }
    #endregion
    protected void ProfileTeamFV_ItemInserting(object sender, FormViewInsertEventArgs e)
    {
        bool _bFlag = true;

        ProfileTeamRecord _oProfileTeamRecord = new ProfileTeamRecord(SYSConn<MSSQLConnect>.Connect());
        TextBox _oStaff_no = (TextBox)ProfileTeamFV.FindControl("staff_no");
        DropDownList _oSalesman_code = (DropDownList)ProfileTeamFV.FindControl("salesman_code");
        TextBox _oSdate = (TextBox)ProfileTeamFV.FindControl("sdate");
        TextBox _oEdate = (TextBox)ProfileTeamFV.FindControl("edate");
        if (_oStaff_no == null) { _bFlag = false; }
        if (_oSalesman_code == null) { _bFlag = false; }
        if (_oSdate == null) { _bFlag = false; }
        if (_oEdate == null) { _bFlag = false; }
        if (_bFlag)
        {
            _oProfileTeamRecord.SetStaff_no(_oStaff_no.Text.ToString());
            _oProfileTeamRecord.SetSalesman_code(_oSalesman_code.SelectedValue.ToString());
            _oProfileTeamRecord.SetCid(RWLFramework.CurrentUser[this.Page].Uid);
            _oProfileTeamRecord.SetActive(true);
            _oProfileTeamRecord.SetCdate(DateTime.Now);
            _oProfileTeamRecord.SetRemark(string.Empty);
            DateTime _dSdate;
            if (DateTime.TryParseExact(_oSdate.Text.ToString(), _oFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dSdate))
                _oProfileTeamRecord.SetSdate(_dSdate);

            DateTime _dEdate;
            if (DateTime.TryParseExact(_oEdate.Text.ToString(), _oFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dEdate))
                _oProfileTeamRecord.SetEdate(_dEdate);

            if (ProfileTeamRecordRepository.Insert(SYSConn<MSSQLConnect>.Connect(), _oProfileTeamRecord))
            {
                if (SortDirection.Ascending == ProfileTeamRecordGV.SortDirection)
                    BindData(ProfileTeamRecordGV.SortExpression, "asc");
                else
                    BindData(ProfileTeamRecordGV.SortExpression, "desc");
                RunJavascriptFunc("alert('New record has been created!');");
            }
        }
        else
        {
            RunJavascriptFunc("alert('Create record fail!');");
        }
    }
    protected void ProfileTeamRecordGV_RowEditing(object sender, GridViewEditEventArgs e)
    {
        ProfileTeamRecordGV.EditIndex = e.NewEditIndex;
        if (SortDirection.Ascending == ProfileTeamRecordGV.SortDirection)
            BindData(ProfileTeamRecordGV.SortExpression, "asc");
        else
            BindData(ProfileTeamRecordGV.SortExpression, "desc");
    }
    protected void ProfileTeamRecordGV_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        if (e.RowIndex >=0)
        {
            GridView _oGridView = (GridView)sender;
            GridViewRow _oGridViewRow = (GridViewRow)_oGridView.Rows[e.RowIndex];
            HiddenField _oId = (HiddenField)_oGridViewRow.FindControl("id");
            TextBox _oStaff_no = (TextBox)_oGridViewRow.FindControl("staff_no");
            DropDownList _oSalesman_code = (DropDownList)_oGridViewRow.FindControl("salesman_code");
            TextBox _oSdate = (TextBox)_oGridViewRow.FindControl("sdate");
            TextBox _oEdate = (TextBox)_oGridViewRow.FindControl("edate");
            CheckBox _oActive = (CheckBox)_oGridViewRow.FindControl("active");
            if (_oId != null &&
                _oStaff_no != null &&
                _oSalesman_code != null &&
                _oSdate != null &&
                _oEdate != null &&
                _oActive != null)
            {
                int _iId;
                if (int.TryParse(_oId.Value, out _iId))
                {
                    ProfileTeamRecord _oProfileTeamRecord = new ProfileTeamRecord(SYSConn<MSSQLConnect>.Connect(), _iId);
                    if (_oProfileTeamRecord.GetFound())
                    {
                        
                        _oProfileTeamRecord.SetStaff_no(_oStaff_no.Text.ToString().Trim());
                        _oProfileTeamRecord.SetSalesman_code(_oSalesman_code.SelectedValue.ToString().Trim());

                        DateTime _dSdate;
                        if (DateTime.TryParseExact(_oSdate.Text.ToString(), _oFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dSdate))
                            _oProfileTeamRecord.SetSdate(_dSdate);
                        else
                            _oProfileTeamRecord.SetSdate(null);

                        DateTime _dEdate;
                        if (DateTime.TryParseExact(_oEdate.Text.ToString(), _oFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dEdate))
                            _oProfileTeamRecord.SetEdate(_dEdate);
                        else
                            _oProfileTeamRecord.SetEdate(null);

                        _oProfileTeamRecord.SetActive(_oActive.Checked);
                        if (_oProfileTeamRecord.Save())
                        {
                            ProfileTeamRecordHistory _oProfileTeamRecordHistory = new ProfileTeamRecordHistory(SYSConn<MSSQLConnect>.Connect());
                            _oProfileTeamRecordHistory.action_type = "UPDATE";
                            _oProfileTeamRecordHistory.active = _oProfileTeamRecord.active;
                            _oProfileTeamRecordHistory.cdate = _oProfileTeamRecord.cdate;
                            _oProfileTeamRecordHistory.cid = _oProfileTeamRecord.cid;
                            _oProfileTeamRecordHistory.ddate = DateTime.Now;
                            _oProfileTeamRecordHistory.did = RWLFramework.CurrentUser[this.Page].Uid;
                            _oProfileTeamRecordHistory.edate = _oProfileTeamRecord.edate;
                            _oProfileTeamRecordHistory.rec_no = _oProfileTeamRecord.id;
                            _oProfileTeamRecordHistory.remark = _oProfileTeamRecord.remark;
                            _oProfileTeamRecordHistory.salesman_code = _oProfileTeamRecord.salesman_code;
                            _oProfileTeamRecordHistory.sdate = _oProfileTeamRecord.sdate;
                            _oProfileTeamRecordHistory.staff_no = _oProfileTeamRecord.staff_no;
                            ProfileTeamRecordHistoryRepository.Insert(SYSConn<MSSQLConnect>.Connect(), _oProfileTeamRecordHistory);
                        }
                        ProfileTeamRecordGV.EditIndex = -1;
                        if (SortDirection.Ascending == ProfileTeamRecordGV.SortDirection)
                            BindData(ProfileTeamRecordGV.SortExpression, "asc");
                        else
                            BindData(ProfileTeamRecordGV.SortExpression, "desc");
                        
                    }
                }
            }
        }
    }
    protected void ProfileTeamRecordGV_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        ProfileTeamRecordGV.EditIndex = -1;
        if (SortDirection.Ascending == ProfileTeamRecordGV.SortDirection)
            BindData(ProfileTeamRecordGV.SortExpression, "asc");
        else
            BindData(ProfileTeamRecordGV.SortExpression, "desc");
    }
    protected void ProfileTeamFV_ItemCreated(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (ProfileTeamFV.DefaultMode == FormViewMode.Insert)
            {
                TextBox _oSdate= (TextBox)ProfileTeamFV.Row.FindControl("sdate");
                //SetReadOnly(_oSdate.ClientID.ToString());

                //_oSdate.ReadOnly = true;
                TextBox _oEdate = (TextBox)ProfileTeamFV.Row.FindControl("edate");
                //_oEdate.ReadOnly = true;
                //SetReadOnly(_oEdate.ClientID.ToString());
            }
        }
    }

    protected void SetReadOnly(string x_sClientID)
    {
        RunJavascriptFunc("document.getElementById('" + x_sClientID + "').readOnly=true;");
    }
    protected void ProfileTeamRecordGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            GridView _oGridView = (GridView)sender;
            GridViewRow _oGridViewRow = (GridViewRow)_oGridView.Rows[e.RowIndex];
            HiddenField _oId = (HiddenField)_oGridViewRow.FindControl("id");
            if (_oId != null)
            {
                int _iId;
                if (int.TryParse(_oId.Value, out _iId))
                {
                    ProfileTeamRecord _oProfileTeamRecord = new ProfileTeamRecord(SYSConn<MSSQLConnect>.Connect(), _iId);
                    if (_oProfileTeamRecord.GetFound())
                    {
                        if (ProfileTeamRecordBal.Delete(SYSConn<MSSQLConnect>.Connect(), _iId))
                        {
                            ProfileTeamRecordHistory _oProfileTeamRecordHistory = new ProfileTeamRecordHistory(SYSConn<MSSQLConnect>.Connect());
                            _oProfileTeamRecordHistory.action_type = "DELETE";
                            _oProfileTeamRecordHistory.active = _oProfileTeamRecord.active;
                            _oProfileTeamRecordHistory.cdate = _oProfileTeamRecord.cdate;
                            _oProfileTeamRecordHistory.cid = _oProfileTeamRecord.cid;
                            _oProfileTeamRecordHistory.ddate = DateTime.Now;
                            _oProfileTeamRecordHistory.did = RWLFramework.CurrentUser[this.Page].Uid;
                            _oProfileTeamRecordHistory.edate = _oProfileTeamRecord.edate;
                            _oProfileTeamRecordHistory.rec_no = _oProfileTeamRecord.id;
                            _oProfileTeamRecordHistory.remark = _oProfileTeamRecord.remark;
                            _oProfileTeamRecordHistory.salesman_code = _oProfileTeamRecord.salesman_code;
                            _oProfileTeamRecordHistory.sdate = _oProfileTeamRecord.sdate;
                            _oProfileTeamRecordHistory.staff_no = _oProfileTeamRecord.staff_no;
                            ProfileTeamRecordHistoryRepository.Insert(SYSConn<MSSQLConnect>.Connect(), _oProfileTeamRecordHistory);
                        }
                    }
                    if (SortDirection.Ascending == ProfileTeamRecordGV.SortDirection)
                        BindData(ProfileTeamRecordGV.SortExpression, "asc");
                    else
                        BindData(ProfileTeamRecordGV.SortExpression, "desc");
                }
            }
        }
    }
    protected void ProfileTeamRecordGV_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        ProfileTeamRecordGV.PageIndex = e.NewPageIndex;
        if (SortDirection.Ascending == ProfileTeamRecordGV.SortDirection)
            BindData(ProfileTeamRecordGV.SortExpression, "asc");
        else
            BindData(ProfileTeamRecordGV.SortExpression, "desc");
    }
    protected void ProfileTeamRecordGV_Sorting(object sender, GridViewSortEventArgs e)
    {
        BindData(e.SortExpression, sortOrder);
    }
}
