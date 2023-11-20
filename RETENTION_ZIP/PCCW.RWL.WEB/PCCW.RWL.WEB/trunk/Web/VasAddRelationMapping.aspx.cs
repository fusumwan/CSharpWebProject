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


public partial class VasAddRelationMapping : NEURON.WEB.UI.BasePage
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
        SqlDataReader _oDr = BundleMappingBal.GetSearch(SYSConn<MSSQLConnect>.Connect(), "top 1 id,vas_field ", "active=1 and vas_field is null",null,null);
        if (_oDr.Read())
        {
            Response.Write("<script>alert('Some of the VAS field is missing ,Please update the VAS field first')</script>");
            Response.Write("<script>window.location='VasBundleMappingModify.aspx?id=" + Func.FR(_oDr[BundleMapping.Para.id]) + "&pass=pass'</script>");
        }
        _oDr.Close();
        _oDr.Dispose();
        call_date.Value = DateTime.Now.ToString("MM/dd/yyyy");
        call_time.Value = DateTime.Now.ToString("HH:mm:ss");
        read_date.Text = DateTime.Now.ToString("MM/dd/yyyy");
        log_date.Value = DateTime.Now.ToString("MM/dd/yyyy");
        now_time.Text = DateTime.Now.ToString("HH:mm:ss");
        log_time.Value = DateTime.Now.ToString("HH:mm:ss");

        staff_uid.Value = RWLFramework.CurrentUser[this.Page].Uid;
        sdate.Text = DateTime.Now.ToString("MM/dd/yyyy");
        edate.Text = DateTime.Now.ToString("12/31/2099");

        NormalRebateTypeBindData(true);

        program.Items.Clear();
        program.Items.Add(new ListItem(string.Empty, string.Empty));
        List<string> _oProgramList = BusinessTradeBal.DrpProgramList();
        for (int i = 0; i < _oProgramList.Count; i++)
        {
            program.Items.Add(new ListItem(_oProgramList[i].ToString(), _oProgramList[i].ToString()));
        }
        rate_plan.Items.Clear();
        rate_plan.Items.Add(new ListItem(string.Empty, string.Empty));
        List<string> _oRate_planList = BusinessTradeBal.DrpRatePlanList();
        for (int i = 0; i < _oRate_planList.Count; i++)
        {
            rate_plan.Items.Add(new ListItem(_oRate_planList[i].ToString(), _oRate_planList[i].ToString()));
        }
        bundle_name.Items.Clear();
        bundle_name.Items.Add(new ListItem(string.Empty, string.Empty));
        List<string> _oBundle_nameList = BusinessTradeBal.DrpBundleNameList();
        for (int i = 0; i < _oBundle_nameList.Count; i++)
        {
            bundle_name.Items.Add(new ListItem(_oBundle_nameList[i].ToString(), _oBundle_nameList[i].ToString()));
        }

        List<string> _oHsmodelList = BusinessTradeBal.DrpHsModelList();
        hs_model.Items.Clear();
        hs_model.Items.Add(new ListItem(string.Empty, string.Empty));
        for (int i = 0; i < _oHsmodelList.Count; i++)
        {
            hs_model.Items.Add(new ListItem(_oHsmodelList[i].ToString(), _oHsmodelList[i].ToString()));
        }

        vas_field.Items.Clear();
        vas_field.Items.Add(new ListItem(string.Empty, string.Empty));
        Hashtable _oVasList = BusinessVasBal.DrpVasList();
        IDictionaryEnumerator _oItem = _oVasList.GetEnumerator();
        while (_oItem.MoveNext())
        {
            vas_field.Items.Add(new ListItem(_oItem.Key.ToString(), _oItem.Value.ToString()));
        }
        IssueTypeBind();

        if (Func.RQ(Request["Success"]) == "YES")
        {
            RegisterJavaScript(string.Empty, "jAlert('Create Success!','System Message');", true);
        }

    }

    public void IssueTypeBind()
    {
        ObjectArr _oItemList = BusinessTradeBal.GetIssueTypeList(false);
        for (int i = 0; i < _oItemList.Count; i++)
        {
            issue_type.Items.Add(new ListItem(_oItemList[i].ToString(), _oItemList[i].ToString()));
        }
    }


    #region NormalRebateTypeBindData
    protected void NormalRebateTypeBindData(bool x_bIncludeAll)
    {
        if (normal_rebate_type != null)
        {
            normal_rebate_type.Items.Clear();
            ObjectArr _oNormalRebateType = FromRegisterControler.GetNormalRebateTypeList(x_bIncludeAll);
            for (int i = 0; i < _oNormalRebateType.Count; i++)
            {
                object _sKey = _oNormalRebateType.KeyFind(i);
                object _sValue = _oNormalRebateType.ValueFind(i);
                normal_rebate_type.Items.Add(new ListItem(_sKey.ToString(), _sValue.ToString()));
                if (x_bIncludeAll)
                {
                    if (_sKey.Equals("ALL"))
                        normal_rebate_type.SelectedValue = "";
                }
                else
                    normal_rebate_type.SelectedValue = "RETENTION";
            }
        }
    }
    #endregion
    #region RegisterJavaScript
    protected void RegisterJavaScript(string x_sID, string x_sScript, bool x_bIncludeScript)
    {
        if (x_bIncludeScript) x_sScript = "<script>" + x_sScript + "</script>";
        ScriptManager.RegisterStartupScript(this.Page, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), x_sScript, false);
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

}
