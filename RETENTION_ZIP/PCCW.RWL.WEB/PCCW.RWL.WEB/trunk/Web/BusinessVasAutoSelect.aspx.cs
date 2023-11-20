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
using System.Data.Sql;
using System.Data.SqlClient;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;
using System.Text;
using System.Globalization;
using DnaExpress.Web.UI.WebControls;
public partial class Web_BusinessVasAutoSelect : DnaExpress.Web.UI.Page
{
    static DataSet ProgramDS = null;
    static DataSet RatePlanDS = null;
    static DataSet ConPerDS = null;
    static DataSet TradeFieldDS = null;
    static DataSet BundleNameDS = null;
    static DataSet HsModelDS = null;
    static DataSet Vas1DS = null;
    static DataSet BusinessVasDB = null;
     DataSet Value1DS = null;
     DataSet Value2DS = null;
     static DataSet VasDescription = null;
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
        //WebFunc.PrivilegeCheck(this.Page);
        if (!IsPostBack || BusinessVasDefaultSetGW.EnableViewState == false) InitFrame();
    }

    
    public void InitFrame()
    {
        if (!IsPostBack || BusinessVasDefaultSetGW.EnableViewState==false)
        {
            ProgramDS = null;
            RatePlanDS = null;
            ConPerDS = null;
            TradeFieldDS = null;
            BundleNameDS = null;
            HsModelDS = null;
            Vas1DS = null;
            Value1DS = null;
            Value2DS = null;
            VasDescription = null;
            Session["BusinessVasDefaultSetSql"] = "";
            ViewState["sortOrder"] = "";
            BindData("", "");
        }
    }

    protected void BindData(string x_sSortExp, string x_sSortDir)
    {
        BindData(GetGridViewFilterSql(), x_sSortExp, x_sSortDir);
    }


    public string GetVasDesc(string x_sVas, string x_sFee)
    {
        if (string.IsNullOrEmpty(x_sVas)) return string.Empty;
        if (string.IsNullOrEmpty(x_sFee)) return string.Empty;

        if (VasDescription == null)
            VasDescription = SYSConn<MSSQLConnect>.Connect().GetDS("SELECT id,vas,fee,vas_desc,sdate,edate,active FROM BusinessVasDescription");
        string _sDesc=string.Empty;
        IDSQuery _oDr = IDSQuery.CreateDsCriteria(VasDescription, "BusinessVasDescription")
            .Add(DsExpression.Eq("vas", x_sVas))
            .Add(DsExpression.Eq("fee", x_sFee));
        if(_oDr.Read()){
            _sDesc=_oDr["vas_desc"].ToString();
        }
        _oDr.Close();
        
        return _sDesc;
    }

    public string GetGridViewFilterSql()
    {
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append(" SELECT ");
        _oQuery.Append(" mid,program,rate_plan,con_per,trade_field,bundle_name,hs_model,issue_type,vas1,vas_name,display1,enabled1, value1,vas2,display2,enabled2,value2,cid,cdate,edate,active ");
        _oQuery.Append(" FROM (");
        _oQuery.Append(" SELECT  [mid]");
        _oQuery.Append(" ,'program'=isnull(program,'') ");
        _oQuery.Append("  ,'rate_plan'=isnull(rate_plan,'') ");
        _oQuery.Append("   ,'con_per'=isnull(con_per,'') ");
        _oQuery.Append("   ,'trade_field'=isnull(trade_field,'') ");
        _oQuery.Append("   ,'bundle_name'=isnull(bundle_name,'') ");
        _oQuery.Append("   ,'hs_model'=isnull(hs_model,'') ");
        _oQuery.Append("  ,'issue_type'=isnull(issue_type,'') ");
        _oQuery.Append("  ,'vas1'=isnull(vas1,'') ");
        _oQuery.Append("  ,'vas_name'=(SELECT TOP 1 vas_name FROM BusinessVas WHERE vas_field=isnull(vas1,'')) ");
        _oQuery.Append("   ,'display1'=isnull(display1,0)");
        _oQuery.Append("   ,'enabled1'=isnull(enabled1,0)");
        _oQuery.Append("   ,'value1'=isnull(value1,'')");
        _oQuery.Append("  ,'vas2'=isnull(vas2,'')");
        _oQuery.Append("  ,'display2'=isnull(display2,0)");
        _oQuery.Append("   ,'enabled2'=isnull(enabled2,0)");
        _oQuery.Append("  ,'value2'=isnull(value2,'')");
        _oQuery.Append("  ,'cid'=isnull(cid,'')");
        _oQuery.Append("  ,cdate");
        _oQuery.Append("  ,edate");
        _oQuery.Append("  ,'active'=isnull(active,'')");
        _oQuery.Append("    FROM [BusinessVasDefaultSet]");
        _oQuery.Append(") BusinessVasDefaultSetView");

        string _sFilterQuery = ((!string.IsNullOrEmpty(BusinessVasDefaultSetGW.GridViewFilterExpression.Trim())) ? BusinessVasDefaultSetGW.GridViewFilterExpression : string.Empty);
        if (!string.IsNullOrEmpty(_sFilterQuery))
        {
            _oQuery.Append(" WHERE mid is not null ");
            _oQuery.Append(" AND " + _sFilterQuery);
        }

        return _oQuery.ToString();

    }

    protected void BindData(string x_sQuery, string x_sSortExp, string x_sSortDir)
    {
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append(x_sQuery);
        if (string.IsNullOrEmpty(x_sSortExp))
            _oQuery.Append(" ORDER BY mid " + x_sSortDir);
        else
            _oQuery.Append(" ORDER BY " + x_sSortExp + " " + x_sSortDir);
        Session["BusinessVasDefaultSetSql"] = _oQuery.ToString();
        BusinessVasDefaultSetGW.DataSource = SYSConn<MSSQLConnect>.Connect().GetDS(_oQuery.ToString());
        BusinessVasDefaultSetGW.DataBind();
    }
    

    protected void BusinessVasDefaultSetGW_FilterCommand(object sender, DnaExpress.Web.UI.WebControls.FilterCommandEventArgs e)
    {
        if (e != null)
        {
            BindData(GetGridViewFilterSql(), BusinessVasDefaultSetGW.GridViewSortExpression, BusinessVasDefaultSetGW.GridViewSortOrder);
        }
    }
    protected void BusinessVasDefaultSetGW_Sorting(object sender, GridViewSortEventArgs e)
    {
        BindData(GetGridViewFilterSql(), e.SortExpression, BusinessVasDefaultSetGW.GridViewSortOrder);
    }

    protected void BusinessVasDefaultSetGW_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        BusinessVasDefaultSetGW.PageIndex = e.NewPageIndex;
        BindData(GetGridViewFilterSql(), BusinessVasDefaultSetGW.GridViewSortExpression, BusinessVasDefaultSetGW.GridViewSortOrder);
    }
    protected void BusinessVasDefaultSetGW_RowCommand(object sender, GridViewCommandEventArgs e)
    {
         if (e.CommandName == "Edit")
        {
            
        }
    }

    #region RegisterJavaScript
    protected void RegisterJavaScript(string x_sID, string x_sScript, bool x_bIncludeScript)
    {
        if (x_bIncludeScript) x_sScript = "<script>" + x_sScript + "</script>";
        ScriptManager.RegisterStartupScript(this.Page, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), x_sScript, false);
    }
    #endregion
    protected void BusinessVasDefaultSetGW_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            GridView _oGridView = (GridView)sender;
            GridViewRow _oGridViewRow = (GridViewRow)_oGridView.Rows[e.RowIndex];
            HiddenField _oMid = (HiddenField)_oGridViewRow.FindControl("mid");
            AspxDropDownList _oProgram = (AspxDropDownList)_oGridViewRow.FindControl("program");
            AspxDropDownList _oRate_plan = (AspxDropDownList)_oGridViewRow.FindControl("rate_plan");
            AspxDropDownList _oCon_per = (AspxDropDownList)_oGridViewRow.FindControl("con_per");
            AspxDropDownList _oTrade_field = (AspxDropDownList)_oGridViewRow.FindControl("trade_field");
            AspxDropDownList _oBundle_name = (AspxDropDownList)_oGridViewRow.FindControl("bundle_name");
            AspxDropDownList _oHs_model = (AspxDropDownList)_oGridViewRow.FindControl("hs_model");
            AspxDropDownList _oIssue_type = (AspxDropDownList)_oGridViewRow.FindControl("issue_type");
            AspxDropDownList _oVas1 = (AspxDropDownList)_oGridViewRow.FindControl("vas1");
            CheckBox _oDisplay1= (CheckBox)_oGridViewRow.FindControl("display1");
            CheckBox _oEnabled1 = (CheckBox)_oGridViewRow.FindControl("enabled1");
            HiddenField _oValue1 = (HiddenField)_oGridViewRow.FindControl("value1");

            CheckBox _oDisplay2 = (CheckBox)_oGridViewRow.FindControl("display2");
            CheckBox _oEnabled2 = (CheckBox)_oGridViewRow.FindControl("enabled2");
            HiddenField _oValue2 = (HiddenField)_oGridViewRow.FindControl("value2");

            AspxDropDownList _oValue1_drp = (AspxDropDownList)_oGridViewRow.FindControl("value1_drp");
            AspxDropDownList _oValue2_drp = (AspxDropDownList)_oGridViewRow.FindControl("value2_drp");

            TextBox _oCdate = (TextBox)_oGridViewRow.FindControl("cdate");
            TextBox _oEdate = (TextBox)_oGridViewRow.FindControl("edate");
            CheckBox _oActive = (CheckBox)_oGridViewRow.FindControl("active");

            if (_oMid != null && _oProgram != null &&
                _oRate_plan != null && _oCon_per != null &&
                _oTrade_field != null && _oBundle_name != null &&
                _oHs_model != null && _oIssue_type != null &&
                _oVas1 != null && _oDisplay1 != null &&
                _oEnabled1 != null && _oValue1 != null &&
                 _oDisplay2 != null && _oValue1_drp!=null && _oValue2_drp !=null &&
                _oEnabled2 != null && _oValue2 != null &&
                _oCdate != null && _oEdate != null &&
                _oActive != null)
            {

                string _sMid = _oMid.Value;
                if (!string.IsNullOrEmpty(_sMid))
                {
                    int _iMid;
                    bool _bFlag = false;
                    if (int.TryParse(_sMid, out _iMid))
                    {
                        BusinessVasDefaultSet _oBusinessVasDefaultSet = new BusinessVasDefaultSet(SYSConn<MSSQLConnect>.Connect(), _iMid);
                        if (_oBusinessVasDefaultSet.GetFound())
                        {
                            _oBusinessVasDefaultSet.SetProgram(_oProgram.SelectedValue);
                            _oBusinessVasDefaultSet.SetRate_plan(_oRate_plan.SelectedValue);
                            _oBusinessVasDefaultSet.SetCon_per(_oCon_per.SelectedValue);
                            _oBusinessVasDefaultSet.SetTrade_field(_oTrade_field.SelectedValue);
                            _oBusinessVasDefaultSet.SetBundle_name(_oBundle_name.SelectedValue);
                            _oBusinessVasDefaultSet.SetHs_model(_oHs_model.SelectedValue);
                            _oBusinessVasDefaultSet.SetVas1(_oVas1.SelectedValue);
                            _oBusinessVasDefaultSet.SetDisplay1(_oDisplay1.Checked);
                            _oBusinessVasDefaultSet.SetEnabled1(_oEnabled1.Checked);
                            _oBusinessVasDefaultSet.SetValue1(_oValue1_drp.SelectedValue);
                            _oBusinessVasDefaultSet.SetIssue_type(_oIssue_type.SelectedValue);
                            if (!string.IsNullOrEmpty(_oVas1.SelectedValue))
                            {
                                _oBusinessVasDefaultSet.SetVas2(_oVas1.SelectedValue + "1");
                            }
                            else
                            {
                                _oBusinessVasDefaultSet.SetVas2(string.Empty);
                            }
                            _oBusinessVasDefaultSet.SetDisplay2(_oDisplay2.Checked);
                            _oBusinessVasDefaultSet.SetEnabled2(_oEnabled2.Checked);
                            _oBusinessVasDefaultSet.SetValue2(_oValue2_drp.SelectedValue);
                            DateTime _dCdate;
                            if (DateTime.TryParseExact(_oCdate.Text.ToString(), _oFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dCdate))
                                _oBusinessVasDefaultSet.SetCdate(_dCdate);
                            else
                                _oBusinessVasDefaultSet.SetCdate(null);

                            DateTime _dEdate;
                            if (DateTime.TryParseExact(_oEdate.Text.ToString(), _oFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dEdate))
                                _oBusinessVasDefaultSet.SetEdate(_dEdate);
                            else
                                _oBusinessVasDefaultSet.SetEdate(null);
                            _oBusinessVasDefaultSet.SetActive(_oActive.Checked);

                            _bFlag = _oBusinessVasDefaultSet.Save();
                        }
                        else
                            _bFlag = false;

                        if (_bFlag)
                        {
                            //BusinessVasDefaultSetGW.DataBind();
                            //RegisterJavaScript(string.Empty, "jAlert('Update Success!','System Message');", true);
                            BusinessVasDefaultSetGW.EditIndex = -1;
                            BindData(GetGridViewFilterSql(), BusinessVasDefaultSetGW.GridViewSortExpression, BusinessVasDefaultSetGW.GridViewSortOrder);
                            VasAutoSetScript.Instance().Reload();
                        }
                        else
                            RegisterJavaScript(string.Empty, "jAlert('Update Fail!','System Message');", true);
                    }
                    else
                        RegisterJavaScript(string.Empty, "jAlert('Update Fail!','System Message');", true);
                }
                else
                    RegisterJavaScript(string.Empty, "jAlert('Update Fail!','System Message');", true);
            }
            else
            {
                RegisterJavaScript(string.Empty, "jAlert('Update Fail!','System Message');", true);
            }
        }
    }
    protected void BusinessVasDefaultSetGW_RowEditing(object sender, GridViewEditEventArgs e)
    {
        BusinessVasDefaultSetGW.EditIndex = e.NewEditIndex;
        BindData(GetGridViewFilterSql(), BusinessVasDefaultSetGW.GridViewSortExpression, BusinessVasDefaultSetGW.GridViewSortOrder);
    }



    #region DropDownList DataBind
    public DataSet ProgramDataBind()
    {
        if (ProgramDS == null)
        {
            ProgramDS = BusinessTradeBal.DsProgramList(true);
        }
        return ProgramDS;
    }

    public DataSet RatePlanDataBind()
    {
        if (RatePlanDS == null)
        {
            RatePlanDS = BusinessTradeBal.DsRatePlanList(true);
        }
        return RatePlanDS;
    }

    public DataSet ConPerDataBind()
    {
        if (ConPerDS == null)
        {
            ConPerDS = BusinessTradeBal.DsCon_perList(true);
        }
        return ConPerDS;
    }

    public DataSet TradeFieldDataBind()
    {

        if (TradeFieldDS == null)
        {
            TradeFieldDS = BusinessTradeBal.DsTradeFieldList(true);
        }
        return TradeFieldDS;
    }

    public DataSet BundleNameDataBind()
    {
        if (BundleNameDS == null)
        {
            BundleNameDS = BusinessTradeBal.DsBundleNameList(true);
        }
        return BundleNameDS;
    }

    public DataSet HsModelDataBind()
    {
        if (HsModelDS == null)
        {
            HsModelDS = BusinessTradeBal.DsHsModeList(true);
        }
        return HsModelDS;
    }

    public DataSet Vas1DataBind()
    {
        if (Vas1DS == null)
        {
            Vas1DS = SYSConn<MSSQLConnect>.Connect().GetDS("SELECT '' vas_name, '' vas_field,'' multi union all SELECT DISTINCT vas_name,vas_field,multi FROM " + Configurator.MSSQLTablePrefix + "BusinessVas WHERE active=1");
        }
        return Vas1DS;
    }

    public DataSet Value1DataBind(string x_sVas_field)
    {

        Value1DS = SYSConn<MSSQLConnect>.Connect().GetDS("SELECT '' vas_value union all SELECT DISTINCT vas_value FROM " + Configurator.MSSQLTablePrefix + "BusinessVas WHERE active=1 " + ((!string.IsNullOrEmpty(x_sVas_field)) ? " AND vas_field='" + x_sVas_field + "' " : string.Empty));

        return Value1DS;
    }

    public DataSet Value2DataBind()
    {
      
        Value2DS = SYSConn<MSSQLConnect>.Connect().GetDS("SELECT '' vas_desc, '' fee union all SELECT DISTINCT vas_desc,fee FROM " + Configurator.MSSQLTablePrefix + "BusinessVasDescription WHERE active=1");
        
        return Value2DS;
    }

    public DataSet Value2DataBind(string x_sVas)
    {

        Value2DS = SYSConn<MSSQLConnect>.Connect().GetDS("SELECT '' vas_desc, '' fee union all SELECT DISTINCT vas_desc,fee FROM " + Configurator.MSSQLTablePrefix + "BusinessVasDescription WHERE active=1 " + ((!string.IsNullOrEmpty(x_sVas)) ? " AND VAS='" + x_sVas + "' " : string.Empty));

        return Value2DS;
    }
    #endregion
    protected void BusinessVasDefaultSetGW_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        BusinessVasDefaultSetGW.EditIndex = -1;
        BindData(GetGridViewFilterSql(), BusinessVasDefaultSetGW.GridViewSortExpression, BusinessVasDefaultSetGW.GridViewSortOrder);
    }
    protected void BusinessVasDefaultSetGW_RowCreated(object sender, GridViewRowEventArgs e)
    {

        
    }
    protected void BusinessVasDefaultSetGW_DataBound(object sender, EventArgs e)
    {

    }
    protected void BusinessVasDefaultSetGW_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowIndex >= 0 && BusinessVasDefaultSetGW.EditIndex >= 0)
        {
            if ((e.Row.RowState & DataControlRowState.Edit) != 0)
            {

                AspxDropDownList _oVas1 = (AspxDropDownList)e.Row.FindControl("vas1");
                HiddenField _oValue1 = (HiddenField)e.Row.FindControl("value1");
                HiddenField _oValue2 = (HiddenField)e.Row.FindControl("value2");
                AspxDropDownList _oValue1_drp = (AspxDropDownList)e.Row.FindControl("value1_drp");
                AspxDropDownList _oValue2_drp = (AspxDropDownList)e.Row.FindControl("value2_drp");
                AspxTextBox _oCid = (AspxTextBox)e.Row.FindControl("cid");
                _oCid.Attributes["readOnly"] = "readOnly";
                if (!string.IsNullOrEmpty(_oVas1.SelectedValue))
                {
                    _oValue1_drp.DataSource = Value1DataBind(_oVas1.SelectedValue);
                    _oValue1_drp.DataBind();
                    if (!string.IsNullOrEmpty(_oValue1.Value))
                    {
                        DropListSelectedValue(ref _oValue1_drp, _oValue1.Value);
                    }
                    _oValue1_drp.Rows = ((_oValue1_drp.Items.Count > 1) ? _oValue1_drp.Items.Count : 2);
                    if (_oValue1_drp.Items.Count <= 1 && _oValue1.Value == string.Empty) { _oValue1_drp.Items.Clear(); }
                    if (_oValue1_drp.Rows > 10) { _oValue1_drp.Rows = 10; }
                    _oValue2_drp.DataSource = Value2DataBind(_oVas1.SelectedValue);
                    _oValue2_drp.DataBind();
                    if (!string.IsNullOrEmpty(_oValue2.Value))
                    {
                        DropListSelectedValue(ref _oValue2_drp, _oValue2.Value);
                    }
                    _oValue2_drp.Rows = ((_oValue2_drp.Items.Count>1)?_oValue2_drp.Items.Count:2) ;
                    if (_oValue2_drp.Items.Count <= 1 && _oValue2.Value == string.Empty) { _oValue2_drp.Items.Clear(); }
                    if (_oValue2_drp.Rows > 10) { _oValue2_drp.Rows = 10; }
                }
            }
        }
    }

    #region DropListSelectedValue
    public void DropListSelectedValue(ref AspxDropDownList x_oDrp, string x_sValue)
    {
        DropListSelectedValue(ref x_oDrp, x_sValue, true);
    }
    public void DropListSelectedValue(ref AspxDropDownList x_oDrp, string x_sValue, bool x_bMustSelect)
    {
        bool _bFlag = false;
        for (int i = 0; i < x_oDrp.Items.Count; i++)
        {
            if (x_oDrp.Items[i].Value.ToUpper().Trim() == x_sValue.ToUpper().Trim())
            {
                x_oDrp.SelectedIndex = i;
                x_oDrp.SelectedValue = x_sValue;
                _bFlag = true;
            }
        }

        if (x_bMustSelect && !_bFlag && !x_sValue.Trim().Equals(string.Empty))
        {
            x_oDrp.Items.Add(new ListItem(x_sValue, x_sValue));
            x_oDrp.SelectedValue = x_sValue;
        }
    }
    #endregion

    protected void PageSizeRefresh_Click(object sender, EventArgs e)
    {

        if (GvPageSize != null)
        {
            int _iPageSize;
            if (int.TryParse(GvPageSize.Text, out _iPageSize))
            {
                if (_iPageSize > 0)
                {
                    BusinessVasDefaultSetGW.PageSize = _iPageSize;
                }
            }
            else
            {
                GvPageSize.Text = "15";
                BusinessVasDefaultSetGW.PageSize = 15;
            }
        }

        BindData(GetGridViewFilterSql(), BusinessVasDefaultSetGW.GridViewSortExpression, BusinessVasDefaultSetGW.GridViewSortOrder);
    }



    protected void vas1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (sender != null && BusinessVasDefaultSetGW.EditIndex>=0)
        {
            AspxDropDownList _oVas1 = (AspxDropDownList)sender;
            GridViewRow _oGridViewRow = (GridViewRow)BusinessVasDefaultSetGW.Rows[BusinessVasDefaultSetGW.EditIndex];

            HiddenField _oValue1 = (HiddenField)_oGridViewRow.FindControl("value1");
            HiddenField _oValue2 = (HiddenField)_oGridViewRow.FindControl("value2");
            AspxDropDownList _oValue1_drp = (AspxDropDownList)_oGridViewRow.FindControl("value1_drp");
            AspxDropDownList _oValue2_drp = (AspxDropDownList)_oGridViewRow.FindControl("value2_drp");
            _oValue1_drp.Items.Clear();
            _oValue2_drp.Items.Clear();
            _oValue1.Value = string.Empty;
            _oValue2.Value = string.Empty;

            if (!string.IsNullOrEmpty(_oVas1.SelectedValue))
            {
                _oValue1_drp.DataSource = Value1DataBind(_oVas1.SelectedValue);
                _oValue1_drp.DataBind();

                DropListSelectedValue(ref _oValue1_drp, _oValue1.Value);
                _oValue1_drp.Rows = ((_oValue1_drp.Items.Count > 1) ? _oValue1_drp.Items.Count : 2);
                if (_oValue1_drp.Items.Count <= 1) { _oValue1_drp.Items.Clear(); }
                if (_oValue1_drp.Items.Count <= 1 && _oValue1.Value == string.Empty) { _oValue1_drp.Items.Clear(); }
                if (_oValue1_drp.Rows > 10) { _oValue1_drp.Rows = 10; }
                _oValue2_drp.DataSource = Value2DataBind(_oVas1.SelectedValue);
                _oValue2_drp.DataBind();

                DropListSelectedValue(ref _oValue2_drp, _oValue2.Value);
                _oValue2_drp.Rows = ((_oValue2_drp.Items.Count > 1) ? _oValue2_drp.Items.Count : 2);
                if (_oValue2_drp.Items.Count <= 1 && _oValue2.Value==string.Empty) { _oValue2_drp.Items.Clear(); }
                if (_oValue2_drp.Rows > 10) { _oValue2_drp.Rows = 10; }
            }

        }
    }
    protected void ReloadMemoryBut_Click(object sender, EventArgs e)
    {
        VasAutoSetScript.Instance().Reload();
        RegisterJavaScript(string.Empty, "jAlert('Reload Memory Success!','System Message');", true);
    }
    protected void BusinessVasDefaultSetGW_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            GridView _oGridView = (GridView)sender;
            GridViewRow _oGridViewRow = (GridViewRow)_oGridView.Rows[e.RowIndex];
            Literal _oMid = (Literal)_oGridViewRow.FindControl("mid");

             string _sMid = _oMid.Text;
             if (!string.IsNullOrEmpty(_sMid))
             {
                 int _iMid;
                 if (int.TryParse(_sMid, out _iMid))
                 {
                     BusinessVasDefaultSet _oBusinessVasDefaultSet = new BusinessVasDefaultSet(SYSConn<MSSQLConnect>.Connect(), _iMid);
                     if (_oBusinessVasDefaultSet.GetFound())
                     {
                         if (_oBusinessVasDefaultSet.Delete())
                         {

                             //RegisterJavaScript(string.Empty, "jAlert('Delete Record Success!','System Message');", true);
                             BindData(GetGridViewFilterSql(), BusinessVasDefaultSetGW.GridViewSortExpression, BusinessVasDefaultSetGW.GridViewSortOrder);
                             VasAutoSetScript.Instance().Reload();
                         }
                         else
                         {
                             RegisterJavaScript(string.Empty, "jAlert('Delete Record Fail!','System Message');", true);
                         }
                     }
                     else
                     {
                         RegisterJavaScript(string.Empty, "jAlert('Delete Record Fail!','System Message');", true);
                     }
                 }
             }
        }
    }
}
