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

public partial class VasDescriptionNew : NEURON.WEB.UI.BasePage
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

        WebFunc.PrivilegeCheck(this.Page);
        if(!IsPostBack) InitFrame();
    }

    public void InitFrame()
    {
        vas_desc_form.DefaultMode = FormViewMode.Insert;
    }

    public DataSet VasBindData()
    {
        return SYSConn<MSSQLConnect>.Connect().GetDS("SELECT DISTINCT vas_field FROM "+Configurator.MSSQLTablePrefix+"BusinessVas WHERE multi=1 AND active=1");
    }

    protected void vas_desc_gv_RowEditing(object sender, GridViewEditEventArgs e)
    {
        
    }
    protected void back_but_Click(object sender, EventArgs e)
    {
        Response.Redirect("VasControlMain.aspx");
    }
    protected void vas_desc_form_ItemInserting(object sender, FormViewInsertEventArgs e)
    {
        try
        {
            string _sVas = e.Values["vas"].ToString();
            string _sFee = e.Values["fee"].ToString();
            string _sVas_desc = e.Values["vas_desc"].ToString();
            
            if (_sFee.Trim().Equals(string.Empty))
            {
                RunJavascriptFunc("alert('Please input fee');");
                e.Cancel = true;
                return;
            }

            if (_sVas_desc.Trim().Equals(string.Empty))
            {
                RunJavascriptFunc("alert('Please input vas description');");
                e.Cancel = true;
                return;
            }
            
            if (!string.IsNullOrEmpty(SYSConn<MSSQLConnect>.Connect().GetExecuteScalar("SELECT vas FROM " + Configurator.MSSQLTablePrefix + "BusinessVasDescription WHERE vas='" + _sVas + "' AND fee='" + _sFee + "'")))
            {
                RunJavascriptFunc("alert('Database alreadly have this record!');");
                e.Cancel = true;
            }

            if (!string.IsNullOrEmpty(SYSConn<MSSQLConnect>.Connect().GetExecuteScalar("SELECT vas FROM " + Configurator.MSSQLTablePrefix + "BusinessVasDescription WHERE vas='" + _sVas + "' AND vas_desc='" + _sVas_desc + "'")))
            {
                RunJavascriptFunc("alert('Database already have this description');");
                e.Cancel = true;
            }
        }
        catch
        {
            RunJavascriptFunc("alert('Insert Fail');");
            e.Cancel = true;
        }
    }
    protected void vas_desc_gv_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        try
        {
            string _sVasOld = e.OldValues["vas"].ToString();
            string _sFeeOld = e.OldValues["fee"].ToString();
            string _sDescOld = e.OldValues["vas_desc"].ToString();
            string _sVas = e.NewValues["vas"].ToString();
            string _sFee = e.NewValues["fee"].ToString();
            string _sDesc = e.NewValues["vas_desc"].ToString();
            if (!_sVas.Equals(_sVasOld) && !_sFee.Equals(_sFeeOld) && !_sDesc.Equals(_sDescOld))
            {
                if (!string.IsNullOrEmpty(SYSConn<MSSQLConnect>.Connect().GetExecuteScalar("SELECT vas FROM " + Configurator.MSSQLTablePrefix + "BusinessVasDescription WHERE vas='" + _sVas + "' AND fee='" + _sFee + "' AND vas_desc='" + _sDesc + "'")))
                {
                    RunJavascriptFunc("alert('Database alreadly have this record!');");
                    e.Cancel = true;
                }
            }
        }
        catch
        {
            RunJavascriptFunc("alert('Update Fail');");
            e.Cancel = true;
        }
    }

    #region Set HtmlControl Style By Javascript
    public void SetHtmlControlStyle(string x_sID, HtmlTextWriterStyle x_oStyle, string x_sValue, bool x_bStr)
    {
        Random ran = new Random();
        string _sScript = string.Empty;
        if (x_bStr)
            _sScript = string.Format("<script>if(document.getElementById('{0}')!=undefined) document.getElementById('{1}').style.{2}='{3}'; </script>", x_sID, x_sID, x_oStyle.ToString().ToLower(), x_sValue);
        else
            _sScript = string.Format("<script>if(document.getElementById('{0}')!=undefined) document.getElementById('{1}').style.{2}={3}; </script>", x_sID, x_sID, x_oStyle.ToString().ToLower(), x_sValue);
        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), _sScript, false);
    }
    #endregion

    #region Set HtmlContorl Attributes By Javascript
    public void SetHtmlControlAtt(string x_sID, HtmlTextWriterAttribute x_oAtt, string x_sValue, bool x_bStr)
    {
        string _sScript = string.Empty;
        if (x_oAtt == HtmlTextWriterAttribute.Class)
        {
            _sScript = string.Format("<script>if(document.getElementById('{0}')!=undefined) document.getElementById('{1}').className='{2}';</script>", x_sID, x_sID, x_sValue);

        }
        else
        {
            if (x_bStr)
                _sScript = string.Format("<script>if(document.getElementById('{0}')!=undefined) document.getElementById('{1}').{2}='{3}';</script>", x_sID, x_sID, x_oAtt.ToString().ToLower(), x_sValue);
            else
                _sScript = string.Format("<script>if(document.getElementById('{0}')!=undefined) document.getElementById('{1}').{2}={3};</script>", x_sID, x_sID, x_oAtt.ToString().ToLower(), x_sValue);
        }
        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), _sScript, false);
    }
    #endregion

    #region Set HtmlContorl Value By Javascript
    public void SetHtmlControlValue(string x_sID, string x_sValue, bool x_bStr)
    {
        string _sScript = string.Empty;
        if (x_bStr)
            _sScript = string.Format("<script>if(document.getElementById('{0}')!=undefined) document.getElementById('{1}').value='{2}';</script>", x_sID, x_sID, x_sValue);
        else
            _sScript = string.Format("<script>if(document.getElementById('{0}')!=undefined) document.getElementById('{1}').value={2};</script>", x_sID, x_sID, x_sValue);
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

    #region GetDB
    protected MSSQLConnect GetDB()
    {
        MSSQLConnect _oDB = new MSSQLConnect();
        _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
        _oDB.bWithNoLock = true;
        return _oDB;
    }
    #endregion

    #region Get Oracle DB
    protected ODBCConnect GetORDB()
    {
        ODBCConnect _oDB = new ODBCConnect();
        _oDB.SetConnStr(Configurator.DBName.ORADNS + ((!"".Equals(Configurator.IsUat())) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion

    protected void vas_desc_source_Init(object sender, EventArgs e)
    {
        vas_desc_source.ConnectionString = SYSConn<MSSQLConnect>.Connect().ConnectionStr;
    }
    protected void vas_desc_source_Updated(object sender, SqlDataSourceStatusEventArgs e)
    {
        VasCreateHolderControl.Instance().PreLoadDataToMemory(true);
    }
    protected void vas_desc_source_Inserted(object sender, SqlDataSourceStatusEventArgs e)
    {
        VasCreateHolderControl.Instance().PreLoadDataToMemory(true);
    }
    protected void vas_desc_source_Deleted(object sender, SqlDataSourceStatusEventArgs e)
    {
        VasCreateHolderControl.Instance().PreLoadDataToMemory(true);
    }
}
