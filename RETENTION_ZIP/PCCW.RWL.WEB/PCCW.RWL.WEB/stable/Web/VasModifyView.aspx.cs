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



public partial class VasModifyView : NEURON.WEB.UI.BasePage
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
        if (!IsPostBack)
        {
            try
            {
                InitFrame();
                FormBind();
            }
            catch (Exception exp)
            {
                string error = exp.ToString();
            }
        }
    }

    public void InitFrame()
    {

        VasDataBind();
    }

    public void VasDataBind()
    {
        vas_field.DataSource = VasFieldDataBind();
        vas_field.DataBind();
    }

    public void FormBind()
    {

        BusinessVasEntity[] _oBusinessVass = BusinessVasBal.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), "vas_field='" + vas_field.SelectedValue + "' AND active=1", null, null);
        if (_oBusinessVass != null)
        {
            if (_oBusinessVass.Length >= 1)
            {
                vas_name.Text = Func.FR(_oBusinessVass[0].vas_name);
                vas_chi_name.Text = Func.LatinToBig5(Func.FR(_oBusinessVass[0].vas_chi_name));
                multi.Checked = (_oBusinessVass[0].multi != null) ? (bool)_oBusinessVass[0].multi : false;
                active.Checked = (_oBusinessVass[0].active != null) ? (bool)_oBusinessVass[0].active : false;
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
    
    protected void vas_modify_Init(object sender, EventArgs e)
    {
        vas_source.ConnectionString = SYSConn<MSSQLConnect>.Connect().ConnectionStr;

        vas_source.DeleteCommand = "DELETE FROM [" + Configurator.MSSQLTablePrefix + "BusinessVas] WHERE [id] = @id";
        vas_source.InsertCommand = "INSERT INTO [" + Configurator.MSSQLTablePrefix + "BusinessVas] ([vas_field], [vas_value], [vas_name], [vas_chi_name], [active]) VALUES (@vas_field, @vas_value, @vas_name, @vas_chi_name, @active)";
        vas_source.SelectCommand = "SELECT [id], [vas_field], [vas_value], [vas_name], [vas_chi_name], [active] FROM [" + Configurator.MSSQLTablePrefix + "BusinessVas]";
        vas_source.UpdateCommand = "UPDATE [" + Configurator.MSSQLTablePrefix + "BusinessVas] SET [vas_field] = @vas_field, [vas_value] = @vas_value, [vas_name] = @vas_name,  [active] = @active WHERE [id] = @id";
    }

    protected void vas_modify_DataBinding(object sender, EventArgs e)
    {
        
    }

    public DataSet VasNameDataBind()
    {
        return SYSConn<MSSQLConnect>.Connect().GetDS("SELECT '' AS vas_name FROM BusinessVas UNION SELECT DISTINCT vas_name FROM " + Configurator.MSSQLTablePrefix + "BusinessVas ");
    }
    public DataSet VasFieldDataBind()
    {
        return SYSConn<MSSQLConnect>.Connect().GetDS("SELECT '' AS vas_field FROM BusinessVas UNION SELECT DISTINCT vas_field FROM " + Configurator.MSSQLTablePrefix + "BusinessVas ");
    }

    protected void vas_modify_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if ((e.Row.RowState & DataControlRowState.Edit) != 0)
            {
                Literal _oLiteral = (Literal)e.Row.FindControl("vas_chi_name");
                _oLiteral.Text = Func.LatinToBig5(_oLiteral.Text);
            }
            else
            {
                Literal _oLiteral = (Literal)e.Row.FindControl("vas_chi_name");
                _oLiteral.Text = Func.LatinToBig5(_oLiteral.Text);
            }
        }
    }
    protected void vas_modify_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        
        GridView _oGridView = (GridView)sender;
        GridViewRow _oGridViewRow = (GridViewRow)_oGridView.Rows[e.RowIndex];
        Literal _oVas_chi_name = (Literal)_oGridViewRow.FindControl("vas_chi_name");
        if (_oVas_chi_name != null) _oVas_chi_name.Text = Func.LatinToBig5(_oVas_chi_name.Text);
    }
    protected void vas_source_Updating(object sender, SqlDataSourceCommandEventArgs e)
    {
       
        if (e.Command.Parameters.Contains("@id"))
        {
            if (e.Command.Parameters["@id"].Value != null)
            {
                if (String.IsNullOrEmpty(e.Command.Parameters["@id"].Value.ToString()))
                {
                    string _sScript = "alert('ID Is Empty!')";
                    Page.ClientScript.RegisterStartupScript(e.GetType(), "error", _sScript, true);
                    e.Cancel = true;
                }
            }
        }
        if (e.Command.Parameters.Contains("@vas_field"))
        {
            if (e.Command.Parameters["@vas_field"].Value != null)
            {
                if (String.IsNullOrEmpty(e.Command.Parameters["@vas_field"].Value.ToString()))
                {
                    string _sScript = "alert('Vas Name Is Empty!')";
                    Page.ClientScript.RegisterStartupScript(e.GetType(), "error", _sScript, true);
                    e.Cancel = true;
                }
            }
        }
        if (e.Command.Parameters.Contains("@vas_value"))
        {
            if (e.Command.Parameters["@vas_value"].Value != null)
            {
                if (String.IsNullOrEmpty(e.Command.Parameters["@vas_value"].Value.ToString()))
                {
                    string _sScript = "alert('Vas Value Is Empty!')";
                    Page.ClientScript.RegisterStartupScript(e.GetType(), "error", _sScript, true);
                    e.Cancel = true;
                }
            }
        }
        if (e.Command.Parameters.Contains("@vas_name"))
        {
            if (e.Command.Parameters["@vas_name"].Value != null)
            {
                if (String.IsNullOrEmpty(e.Command.Parameters["@vas_name"].Value.ToString()))
                {
                    string _sScript = "alert('Vas Name Is Empty!')";
                    Page.ClientScript.RegisterStartupScript(e.GetType(), "error", _sScript, true);
                    e.Cancel = true;
                }
            }
        }
        
        if (e.Command.Parameters.Contains("@active"))
        {
            if (e.Command.Parameters["@active"].Value != null)
            {
                if (String.IsNullOrEmpty(e.Command.Parameters["@active"].Value.ToString()))
                {
                    string _sScript = "alert('Active Is Empty!')";
                    Page.ClientScript.RegisterStartupScript(e.GetType(), "error", _sScript, true);
                    e.Cancel = true;
                }
            }
        }

        if (e.Command.Parameters["@vas_field"].Value != null && e.Command.Parameters["@vas_name"].Value != null)
        {
            e.Command.Parameters["@vas_field"].Value = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar("SELECT DISTINCT vas_field FROM " + Configurator.MSSQLTablePrefix + "BusinessVas WHERE vas_name='" + e.Command.Parameters["@vas_name"].Value + "'");
        }

    }
    protected void vas_modify_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.ToUpper().Equals("EDIT"))
        {
            
        }
    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        bool _bFlag = true;
        vas_name.Text = vas_name.Text.Trim();
        vas_chi_name.Text = vas_chi_name.Text.Trim();
        if (vas_name.Text.Equals(string.Empty))
        {
            RunJavascriptFunc("alert('Please input vas name!');");
            _bFlag = false;
        }
        if (vas_field.SelectedValue.Trim().Equals(string.Empty)) _bFlag = false;

        if (_bFlag)
        {
            string _sVas_name = string.Empty;
            string _sVas_chi_name = string.Empty;
            string _sMulti = string.Empty;
            string _sActive = string.Empty;
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT DISTINCT vas_name,vas_chi_name,multi,active FROM " + Configurator.MSSQLTablePrefix + "BusinessVas WHERE vas_field='"+vas_field.SelectedValue+"'");
            if (_oDr.Read())
            {
                _sVas_name = Func.FR(_oDr["vas_name"]).Trim();
                _sVas_chi_name = Func.FR(_oDr["vas_chi_name"]);
                _sMulti = (Func.FR(_oDr["multi"]).Trim().ToUpper().Equals("TRUE"))?"1":"0" ;
                _sActive = (Func.FR(_oDr["active"]).Trim().ToUpper().Equals("TRUE"))?"1":"0";
            }
            _oDr.Close();
            _oDr.Dispose();
            if (SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery("UPDATE " + Configurator.MSSQLTablePrefix + "BusinessVas SET vas_name='" + vas_name.Text.Trim() + "', vas_chi_name='" + Func.Big5ToLatin(vas_chi_name.Text.Trim()) + "', multi='" + ((multi.Checked) ? "1" : "0") + "', active='" + ((active.Checked) ? "1" : "0") + "' WHERE vas_field='" + vas_field.SelectedValue.Trim() + "' AND vas_name='" + _sVas_name + "' AND (vas_chi_name='" + _sVas_chi_name + "' " + ((_sVas_chi_name == string.Empty) ? "OR vas_chi_name is null" : string.Empty) + "  ) AND multi='" + _sMulti + "' AND active='" + _sActive + "'"))
            {
                VasCreateHolderControl.Instance().PreLoadDataToMemory(true);
                RunJavascriptFunc("alert('Update success!');");     
            }
            else
                RunJavascriptFunc("alert('Update Fail!');");
        }
        else
            RunJavascriptFunc("alert('Update Fail!');");

        
        vas_modify.DataBind();
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
    protected void vas_field_SelectedIndexChanged(object sender, EventArgs e)
    {
        FormBind();
    }
}
