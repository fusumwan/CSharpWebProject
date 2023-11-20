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


public partial class Web_VasAssignValue : NEURON.WEB.UI.BasePage
{
    static IDictionary<string, BusinessVas> n_oBusinessVasList;
    static IDictionary<string, BusinessVas> _oBusinessVasList
    {
        get
        {
            if (n_oBusinessVasList == null)
            {
                n_oBusinessVasList = new Dictionary<string, BusinessVas>();
            }
            return n_oBusinessVasList;
        }
    }
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

        if (!IsPostBack)
        {
            InitFrame();

        }
    }

    protected void InitFrame()
    {
        List<string> _oItemList = new List<string>();
        vas_field.Items.Clear();
        vas_field.Items.Add(new ListItem(string.Empty, string.Empty));
        SqlDataReader _oReader = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT distinct vas_field,vas_name,vas_chi_name,multi FROM " + Configurator.MSSQLTablePrefix + "BusinessVas WHERE active=1");
        while (_oReader.Read())
        {
            if (!Func.FR(_oReader["vas_field"]).Equals(string.Empty))
            {
                vas_field.Items.Add(new ListItem(Func.FR(_oReader["vas_field"]), Func.FR(_oReader["vas_field"])));
                BusinessVas _oBusinessVas = BusinessVasRepository.CreateEntityInstanceObject();
                _oBusinessVas.SetVas_field(Func.FR(_oReader["vas_field"]));
                _oBusinessVas.SetVas_name(Func.FR(_oReader["vas_name"]));
                if (!Func.FR(_oReader["vas_chi_name"]).Equals(string.Empty))
                {
                    if (Func.LatinToBig5(Func.FR(_oReader["vas_chi_name"])).Trim() != string.Empty)
                    {
                        _oBusinessVas.SetVas_chi_name(Func.LatinToBig5(Func.FR(_oReader["vas_chi_name"])));
                    }
                    else
                    {
                        _oBusinessVas.SetVas_chi_name(Func.FR(_oReader["vas_chi_name"]));
                    }
                }

                bool _bMulti;
                if (bool.TryParse(Func.FR(_oReader["multi"]), out _bMulti))
                {
                    _oBusinessVas.SetMulti(_bMulti);
                }


                if (!_oBusinessVasList.ContainsKey(_oBusinessVas.GetVas_field()) &&
                    !_oItemList.Contains(_oBusinessVas.GetVas_field()))
                {
                    _oItemList.Add(_oBusinessVas.GetVas_field());
                    _oBusinessVasList.Add(_oBusinessVas.GetVas_field(), _oBusinessVas);
                }
            }
        }
        _oReader.Close();
        _oReader.Dispose();
    }
    protected void vas_field_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (_oBusinessVasList.ContainsKey(vas_field.SelectedValue))
        {
            vas_name.Text = _oBusinessVasList[vas_field.SelectedValue].GetVas_name();
            vas_chi_name.Text = _oBusinessVasList[vas_field.SelectedValue].GetVas_chi_name();
            if( _oBusinessVasList[vas_field.SelectedValue].GetMulti()!=null)
                multi.Checked = (bool)_oBusinessVasList[vas_field.SelectedValue].GetMulti();

        }
    }
    protected void add_vas_value_Click(object sender, EventArgs e)
    {
        if (vas_field.SelectedValue != string.Empty)
        {
            BusinessVas _oBusinessVas = BusinessVasRepository.CreateEntityInstanceObject();
            _oBusinessVas.SetActive(true);
            _oBusinessVas.SetMulti(multi.Checked);
            _oBusinessVas.SetVas_field(vas_field.SelectedValue);
            _oBusinessVas.SetVas_name(vas_name.Text);
            _oBusinessVas.SetVas_chi_name(Func.Big5ToLatin(vas_chi_name.Text));
            _oBusinessVas.SetVas_value(vas_value.Text);
            SqlDataReader _oDr2 = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT * FROM " + Configurator.MSSQLTablePrefix + "BusinessVas WHERE vas_field='" + vas_field.SelectedValue + "' AND vas_chi_name='" + vas_chi_name.Text + "' AND vas_value='" + vas_value.Text + "'");
            if (!_oDr2.Read())
            {
                if (BusinessVasBal.InsertReturnLastID_SP(SYSConn<MSSQLConnect>.Connect(), _oBusinessVas) > -1)
                {
                    VasCreateHolderControl.Instance().PreLoadDataToMemory(true);
                    RunJavascriptFunc("alert('Assign vas value sucess');");
                    Response.Redirect("VasModifyView.aspx");
                }
                else
                {
                    RunJavascriptFunc("alert('Create vas fail');");
                }
            }
            else
            {
                RunJavascriptFunc("alert('This value has alreadly created');");
            }
        }
    }

    #region Set HtmlControl Style By Javascript
    public void SetHtmlControlStyle(string x_sID, HtmlTextWriterStyle x_oStyle, string x_sValue, bool x_bStr)
    {
        Random ran = new Random();
        string _sScript = string.Empty;
        if (x_bStr)
            _sScript = string.Format("<script>document.getElementById('{0}').style.{1}='{2}';</script>", x_sID, x_oStyle.ToString().ToLower(), x_sValue);
        else
            _sScript = string.Format("<script>document.getElementById('{0}').style.{1}={2};</script>", x_sID, x_oStyle.ToString().ToLower(), x_sValue);
        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), _sScript, false);
    }
    #endregion

    #region Set HtmlContorl Attributes By Javascript
    public void SetHtmlControlAtt(string x_sID, HtmlTextWriterAttribute x_oAtt, string x_sValue, bool x_bStr)
    {
        string _sScript = string.Empty;
        if (x_bStr)
            _sScript = string.Format("<script>document.getElementById('{0}').{1}='{2}';</script>", x_sID, x_oAtt.ToString().ToLower(), x_sValue);
        else
            _sScript = string.Format("<script>document.getElementById('{0}').{1}={2};</script>", x_sID, x_oAtt.ToString().ToLower(), x_sValue);
        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), _sScript, false);
    }
    #endregion

    #region Set HtmlContorl Value By Javascript
    public void SetHtmlControlValue(string x_sID, string x_sValue, bool x_bStr)
    {
        string _sScript = string.Empty;
        if (x_bStr)
            _sScript = string.Format("<script>document.getElementById('{0}').value='{1}';</script>", x_sID, x_sValue);
        else
            _sScript = string.Format("<script>document.getElementById('{0}').value={1};</script>", x_sID, x_sValue);
        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), _sScript, false);
    }
    #endregion

    #region Run Javascript Function
    public void RunJavascriptFunc(string x_sFunc)
    {
        string _sFunc = ((x_sFunc.IndexOf(';') > 0) ? x_sFunc : x_sFunc + ";");
        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sFunc + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), string.Format("<script>{0}</script>", _sFunc), false);
    }
    #endregion

}
