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
using NEURON.ENTITY.FRAMEWORK.STOCK;


public partial class VasBundleMappingModify : NEURON.WEB.UI.BasePage
{
    DataSet n_oProgramDS = null;
    DataSet n_oVasFieldDS = null;
    DataSet n_oHsmodelDS = null;
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
        if (!IsPostBack) InitFrame();
    }

    public void InitFrame()
    {

    }
    public DataSet DrpHsmodel()
    {
        if(n_oHsmodelDS==null)
            n_oHsmodelDS = BusinessTradeBal.DsHsModeList(true);
        return n_oHsmodelDS;
    }
    public DataSet ProgramBind()
    {
        if (n_oProgramDS == null) n_oProgramDS = BusinessTradeBal.DsProgramList();
        return n_oProgramDS;
    }

    public DataSet VasFieldBind()
    {
        if (n_oVasFieldDS == null) n_oVasFieldDS = BusinessVasBal.DsVasList(true);
        return n_oVasFieldDS;
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
    protected void vas_gp_DataBound(object sender, EventArgs e)
    {
        
    }
    protected void vas_gp_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if ((e.Row.RowState & DataControlRowState.Edit) != 0)
            {

            }
            else
            {
                Literal _oNormal_rebate_type = (Literal)e.Row.FindControl("normal_rebate_type");
                Literal _oVas_field = (Literal)e.Row.FindControl("vas_field");
                if (_oVas_field != null){
                    _oVas_field.Text = GetDB().GetExecuteScalar("SELECT TOP 1 vas_name FROM " + Configurator.MSSQLTablePrefix + "BusinessVas WHERE vas_field='" + _oVas_field.Text +"'");
                }
            }
        }
    }
    protected void vas_source_Init(object sender, EventArgs e)
    {
        vas_source.ConnectionString = SYSConn<MSSQLConnect>.Connect().ConnectionStr;
        vas_source.DeleteCommand = "DELETE FROM ["+Configurator.MSSQLTablePrefix+"BundleMapping] WHERE [id] = @id";
        vas_source.InsertCommand = "INSERT INTO [" + Configurator.MSSQLTablePrefix + "BundleMapping] ([program], [rate_plan], [vas_field], [normal_rebate_type], [bundle_name],[hs_model],[issue_type], [edate], [sdate]) VALUES (@program, @rate_plan, @vas_field, @normal_rebate_type, @bundle_name,@hs_model,@issue_type, @edate, @sdate)";
        vas_source.SelectCommand = "SELECT id, program, rate_plan, vas_field, normal_rebate_type, bundle_name,hs_model,issue_type, edate, sdate FROM " + Configurator.MSSQLTablePrefix + "BundleMapping WHERE (id = @id)";
        vas_source.UpdateCommand = "UPDATE [" + Configurator.MSSQLTablePrefix + "BundleMapping] SET [program] = @program, [rate_plan] = @rate_plan, [vas_field] = @vas_field, [normal_rebate_type] = @normal_rebate_type, [bundle_name] = @bundle_name,[hs_model]=@hs_model, [edate] = @edate, [sdate] = @sdate , [issue_type]=@issue_type WHERE [id] = @id";
    }


    public string RetentionSelectValue(string x_sValue)
    {
        string _sHRESULT = string.Empty;
        switch (x_sValue)
        {
            case "1":
                _sHRESULT = "Retention";
                break;
            case "0":
                _sHRESULT = "Retention+";
                break;
            case "2":
                _sHRESULT = "Loyal Retention+";
                break;
            case "3":
                _sHRESULT = "Special Retention";
                break;
            case "4":
                _sHRESULT = "T-5 Upselling";
                break;
            case "5":
                _sHRESULT = "Sim Only T-5 Upselling";
                break;
            case "6":
                _sHRESULT = "Special Marker Retention";
                break;
        }
        return _sHRESULT;
    }

    protected void issue_type_Init(object sender, EventArgs e)
    {
        if (sender is DropDownList)
        {
            DropDownList issue_type = (DropDownList)sender;
            if (issue_type != null)
            {
                issue_type.Items.Clear();
                ObjectArr _oIssueType = BusinessTradeBal.GetIssueTypeList(false);
                for (int i = 0; i < _oIssueType.Count; i++)
                {
                    issue_type.Items.Add(new ListItem(_oIssueType[i].ToString(), _oIssueType[i].ToString()));
                }
            }
        }
    }

    protected void normal_rebate_type_Init(object sender, EventArgs e)
    {
        if (sender is DropDownList)
        {
            DropDownList normal_rebate_type = (DropDownList)sender;
            if (normal_rebate_type != null)
            {

                normal_rebate_type.Items.Clear();
                ObjectArr _oNormalRebateType = FromRegisterControler.GetNormalRebateTypeList(true);
                for (int i = 0; i < _oNormalRebateType.Count; i++)
                {
                    object _sKey = _oNormalRebateType.KeyFind(i);
                    object _sValue = _oNormalRebateType.ValueFind(i);
                    normal_rebate_type.Items.Add(new ListItem(_sKey.ToString(), _sValue.ToString()));
                    if (true)
                    {
                        if (_sKey.Equals("ALL"))
                            normal_rebate_type.SelectedValue = "";
                    }
                    else
                        normal_rebate_type.SelectedValue = "RETENTION";
                }
            }
        }
    }
}
