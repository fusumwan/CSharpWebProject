using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
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

public partial class Web_AccessPageManagement : NEURON.WEB.UI.BasePage
{
    Hashtable AccessPageArr = new Hashtable();
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

        /*
       Session["lv"] = "65535";
       Session["uid"] = "1022243";
       Session["arprog"] = "RWL";
       RWLFramework.DataBaseConfigSetting();
       RWLFramework.CurrentUser[this.Page].SetUid(n_sSessionUid);
       RWLFramework.CurrentUser[this.Page].SetLv(n_sSessionLv);
       RWLFramework.CurrentUser[this.Page].SetArprog(n_sSessionArprog);
       RWLFramework.CurrentUser[this.Page].SetChannel(n_sSessionChannel);
       */
       WebFunc.PrivilegeCheck(this.Page);
       AccessRightControl.Instance().PreLoadDataToMemory(true);
       Init();   
    }

    protected void Init()
    {

        RWLFramework.DataBaseConfigSetting();
        SearchDrpInit();
        if (!IsPostBack)
        {
            SearchDrpDataBind();
        }
    }

    protected void SearchDrpInit()
    {
        if (AccessPageArr == null)
            AccessPageArr = new Hashtable();
        AccessPageArr.Clear();
        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT id, access_page FROM AccessPage WHERE active=1 order by access_page");
        while (_oDr.Read())
        {
            string _sAccessPage = Func.FR(_oDr["access_page"]);
            string _sId = Func.FR(_oDr["id"]);
            if (!string.IsNullOrEmpty(_sAccessPage) && !string.IsNullOrEmpty(_sId))
            {
                if (!AccessPageArr.ContainsKey(_sId)) { AccessPageArr.Add(_sId, _sAccessPage); }
            }
        }
        _oDr.Close();
        _oDr.Dispose();
    }


    protected void SearchDrpDataBind()
    {
        AccessPageDrp1.Items.Clear();
        AccessPageDrp1.DataSource = GetAccessPageList(true);
        AccessPageDrp1.DataBind();

        AccessPageDrp2.Items.Clear();
        AccessPageDrp2.DataSource = GetAccessPageList(true);
        AccessPageDrp2.DataBind();
    }

    public string GetAccessPageById(string x_sId)
    {
        if (!string.IsNullOrEmpty(x_sId))
        {
            if (AccessPageArr.ContainsKey(x_sId))
                return AccessPageArr[x_sId].ToString();

        }
        return string.Empty;
    }

    public DataTable GetAccessPageList()
    {
        return GetAccessPageList(false);
    }

    public DataTable GetAccessPageList(bool x_bAllSelection)
    {
        DataTable _oAccessPageDT = new DataTable();
        _oAccessPageDT.Columns.Add(new DataColumn("id", System.Type.GetType("System.Int32")));
        _oAccessPageDT.Columns.Add(new DataColumn("access_page", System.Type.GetType("System.String")));

        if (x_bAllSelection)
        {
            DataRow _oRow = _oAccessPageDT.NewRow();
            _oRow["id"] = -1;
            _oRow["access_page"] = "ALL";
            _oAccessPageDT.Rows.Add(_oRow);
        }
        
        IDictionaryEnumerator _oItem = AccessPageArr.GetEnumerator();
        while (_oItem.MoveNext())
        {
            string _sAccessPage = _oItem.Value.ToString();
            string _sId = _oItem.Key.ToString();
            if (!string.IsNullOrEmpty(_sAccessPage) && !string.IsNullOrEmpty(_sId))
            {
                DataRow _oRow = _oAccessPageDT.NewRow();
                int _iId;
                if (int.TryParse(_sId, out _iId))
                    _oRow["id"] = _iId;

                _oRow["access_page"] = _sAccessPage;
                _oAccessPageDT.Rows.Add(_oRow);
            }
        }
        return _oAccessPageDT;
    }

    protected string GetUID()
    {
        return RWLFramework.CurrentUser[this.Page].Uid;
    }

    protected void cidTextBox_Init(object sender, EventArgs e)
    {
        ((TextBox)sender).Text = GetUID();
    }

    protected void activeCheckBox_Init(object sender, EventArgs e)
    {
        ((CheckBox)sender).Checked = true;
    }

    #region AccessPage
    protected void AccessPageSqlDataSource_Init(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
        AccessPageSqlDataSource.ConnectionString = SYSConn<MSSQLConnect>.Connect().GetConfigurationSetting();
    }

    protected void AccessPageSearchBtn_Click(object sender, EventArgs e)
    {
        AccessPageDrp1Value.Value = AccessPageDrp1.SelectedItem.Value.ToString();
        AccessPageSearching();
    }

    protected void AccessPageSearching()
    {
        string _sFilter = string.Empty;
        if (AccessPageDrp1Value.Value != string.Empty && AccessPageDrp1Value.Value!="-1")
            _sFilter += " WHERE id = '" + AccessPageDrp1Value.Value.ToString() + "'";
        if (!_sFilter.Equals(string.Empty))
        {
            AccessPageSqlDataSource.SelectCommand = "SELECT [access_page],[page_desc], [id], [cid], [active] FROM [AccessPage] " + _sFilter;
        }
        else
        {
            AccessPageSqlDataSource.SelectCommand = "SELECT [access_page],[page_desc], [id], [cid], [active] FROM [AccessPage] ";
        }
    }

    protected void AccessPageGV_PageIndexChanged(object sender, EventArgs e)
    {
        AccessPageSearching();
    }

    protected void AccessPageGV_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Update")
        {
            AccessPageSearchBtn.Enabled = true;
            AccessPageDrp1.Enabled = true;
        }
        else if (e.CommandName == "Edit")
        {
            AccessPageSearchBtn.Enabled = false;
            AccessPageDrp1.Enabled = false;
            AccessPageSearching();
        }
        else if (e.CommandName == "Delete")
        {
            AccessPageSearchBtn.Enabled = true;
            AccessPageDrp1.Enabled = true;
        }
        else
        {
            AccessPageSearchBtn.Enabled = true;
            AccessPageDrp1.Enabled = true;
        }
    }

    protected void AccessPageFV_ItemCommand(object sender, FormViewCommandEventArgs e)
    {
        SearchDrpDataBind();
    }
    protected void AccessPageSqlDataSource_Updating(object sender, SqlDataSourceCommandEventArgs e)
    {
        AccessPageSearching();
    }
    #endregion

    #region AccessPageProfile
    protected void AccessPageProfileSqlDataSource_Init(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
        AccessPageProfileSqlDataSource.ConnectionString = SYSConn<MSSQLConnect>.Connect().GetConfigurationSetting();
    }
    protected void AccessPageProfileSearchBtn_Click(object sender, EventArgs e)
    {
        AccessPageDrp2Value.Value = AccessPageDrp2.SelectedItem.Value.ToString();
        AccessPageProfileSearching();
    }
    protected void AccessPageProfileSearching()
    {
        string _sFilter = string.Empty;
        if (AccessPageDrp2Value.Value != string.Empty && AccessPageDrp2Value.Value!="-1")
            _sFilter += " WHERE access_page_id = '" + AccessPageDrp2Value.Value.ToString() + "'";
        if (!_sFilter.Equals(string.Empty))
        {
            AccessPageProfileSqlDataSource.SelectCommand = "SELECT [id], [access_page_id], [access_level], [active],[sp_uid], [cid] FROM [AccessPageProfile]" + _sFilter;
        }
        else
        {
            AccessPageProfileSqlDataSource.SelectCommand = "SELECT [id], [access_page_id], [access_level], [active],[sp_uid], [cid] FROM [AccessPageProfile]";
        }
    }
    protected void AccessPageProfileGV_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        AccessPageProfileSearching();
    }
    protected void AccessPageProfileGV_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Update")
        {
            AccessPageProfileSearchBtn.Enabled = true;
            AccessPageDrp2.Enabled = true;
        }
        else if (e.CommandName == "Edit")
        {
            AccessPageProfileSearchBtn.Enabled = false;
            AccessPageDrp2.Enabled = false;
            AccessPageProfileSearching();
        }
        else if (e.CommandName == "Delete")
        {
            AccessPageProfileSearchBtn.Enabled = true;
            AccessPageDrp2.Enabled = true;
        }
        else
        {
            AccessPageProfileSearchBtn.Enabled = true;
            AccessPageDrp2.Enabled = true;
        }
    }
    protected void AccessPageProfileFV_ItemCommand(object sender, FormViewCommandEventArgs e)
    {
        SearchDrpDataBind();
    }
    protected void AccessPageProfileSqlDataSource_Updating(object sender, SqlDataSourceCommandEventArgs e)
    {
        AccessPageProfileSearching();
    }
    protected void AccessPageProfileSqlDataSource_Deleting(object sender, SqlDataSourceCommandEventArgs e)
    {
        AccessPageProfileSearching();
    }

    #endregion


    protected void AccessPageFV_ItemInserted(object sender, FormViewInsertedEventArgs e)
    {
        AccessRightControl.Instance().PreLoadDataToMemory(true);
        SearchDrpInit();
        SearchDrpDataBind();
        
    }
    protected void AccessPageProfileFV_ItemInserted(object sender, FormViewInsertedEventArgs e)
    {
        AccessRightControl.Instance().PreLoadDataToMemory(true);
        SearchDrpInit();
        SearchDrpDataBind();
    }
}
