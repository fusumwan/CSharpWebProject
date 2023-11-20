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




public partial class VasAssignNew : NEURON.WEB.UI.BasePage
{
    private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
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

    protected void add_vas_Click(object sender, EventArgs e)
    {
        string _sVas_field = vas_field.Text.Trim();
        string _sVas_name = vas_name.Text.Trim();
        string _sVas_chi_name = vas_chi_name.Text.Trim();
        string _sVas_value = vas_value.Text.Trim();
        bool _bMulti = multi.Checked;
        bool _bFlag = true;

        if (_sVas_field.Equals(string.Empty)){
            _bFlag = false;
            RunJavascriptFunc("alert('Please enter vas id name!');");
        }
        if (_sVas_name.Equals(string.Empty))
        {
            _bFlag = false;
            RunJavascriptFunc("alert('Please enter vas name!');");
        }
        /*
        if (_sVas_chi_name.Equals(string.Empty))
        {
            _bFlag = false;
            RunJavascriptFunc("alert('Please enter vas chinese name!');");
        }
        */
        if (_sVas_value.Equals(string.Empty))
        {
            _bFlag = false;
            RunJavascriptFunc("alert('Please enter vas value!');");
        }

        if (_bFlag)
        {
            bool _bVasIdName = true;
            bool _bVasName = true;
            bool _bVasChiName = true;
            bool _bVasValue = true;
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT * FROM " + Configurator.MSSQLTablePrefix + "BusinessVas WHERE vas_field='" + _sVas_field + "'");
            if (_oDr.Read())
            {
                _bVasIdName = false;
                RunJavascriptFunc("alert('Already have vas id name!');");
                vas_field.Text = string.Empty;
            }
            _oDr.Close();
            _oDr.Dispose();

            if (_bVasIdName)
            {
                SqlDataReader _oDr2 = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT * FROM " + Configurator.MSSQLTablePrefix + "BusinessVas WHERE vas_field='" + _sVas_field + "' AND vas_name='"+_sVas_name+"'");
                if (_oDr2.Read())
                {
                    _bVasName = false;
                    RunJavascriptFunc("alert('Already have vas name!');");
                    vas_name.Text = string.Empty;
                }
                _oDr2.Close();
                _oDr2.Dispose();
            }

            if (_bVasIdName)
            {
                SqlDataReader _oDr2 = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT * FROM " + Configurator.MSSQLTablePrefix + "BusinessVas WHERE vas_field='" + _sVas_field + "' AND vas_chi_name='" + Func.Big5ToLatin(_sVas_chi_name) + "'");
                if (_oDr2.Read())
                {
                    _bVasName = false;
                    RunJavascriptFunc("alert('Already have vas chinese name!');");
                    vas_chi_name.Text = string.Empty;
                }
                _oDr2.Close();
                _oDr2.Dispose();
            }

            if (_bVasIdName)
            {
                SqlDataReader _oDr2 = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT * FROM " + Configurator.MSSQLTablePrefix + "BusinessVas WHERE vas_field='" + _sVas_field + "' AND vas_value='" + _sVas_value + "'");
                if (_oDr2.Read())
                {
                    _bVasName = false;
                    RunJavascriptFunc("alert('Already have vas value!');");
                    vas_chi_name.Text = string.Empty;
                }
                _oDr2.Close();
                _oDr2.Dispose();
            }

            if (_bVasIdName && _bVasName && _bVasChiName && _bVasValue)
            {
                BusinessVas _oBusinessVas = BusinessVasRepository.CreateEntityInstanceObject();
                _oBusinessVas.SetActive(true);
                _oBusinessVas.SetMulti(_bMulti);
                _oBusinessVas.SetVas_field(_sVas_field);
                _oBusinessVas.SetVas_name(_sVas_name);
                _oBusinessVas.SetVas_chi_name(Func.Big5ToLatin(_sVas_chi_name));
                _oBusinessVas.SetVas_value(_sVas_value);
                if (BusinessVasBal.InsertReturnLastID_SP(SYSConn<MSSQLConnect>.Connect(), _oBusinessVas)>-1)
                {
                    VasCreateHolderControl.Instance().PreLoadDataToMemory(true);
                    RunJavascriptFunc("alert('Create vas success');");
                    Response.Redirect("VasModifyView.aspx");
                }
                else
                {
                    RunJavascriptFunc("alert('Create vas fail');");
                }
            }
        }

    }


    #region GetDB
    public static MSSQLConnect GetDB()
    {
        MSSQLConnect _oDB = new MSSQLConnect();
        _oDB.bWithNoLock = true;
        _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion

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
        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sFunc + (new Random()).Next(1, 1000).ToString()+Guid.NewGuid().ToString(), string.Format("<script>{0}</script>", _sFunc), false);
    }
    #endregion
}
