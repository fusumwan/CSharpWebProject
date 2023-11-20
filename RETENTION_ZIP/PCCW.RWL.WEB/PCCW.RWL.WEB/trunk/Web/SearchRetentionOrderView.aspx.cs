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
using System.Data.SqlTypes;
using System.Data.Odbc;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;

public partial class SearchRetentionOrderView : NEURON.WEB.UI.BasePage
{
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion
    static DataSet _oOBProgramDataSet;
    static List<string> _oHsmodelList;
    static List<string> _oSalesmancodeList;
    static DataSet _oTeamcode;
    static DataSet _oTariffFeeDataSet;
    static DataSet _oOrgFeeDataSet;
    static DataSet _oProgramDataSet;
    static DataSet _oRatePlanDataSet;
    static DataSet _oContractPeriodDataSet;
    static List<string> _oSPremiumTypeList;

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
        RWLFramework.InitModel();
        submitform.Disabled = false;
        try
        {
            if (!IsPostBack) InitFrame();
        }
        catch(Exception error)
        {
            Logger.ErrorFormat("SearchRetentionOrderView: {0}", error.ToString());
        }
    }
    protected void InitFrame()
    {
        if ("1".Equals(RWLFramework.CurrentUser[this.Page].Lv)){
            SetHtmlControlValue("staff_no", RWLFramework.CurrentUser[this.Page].Uid.ToString(), true);

        }
        //SetHtmlControlValue("log_date", DateTime.Now.ToString("dd/MM/yyyy"), true);
        BindData();
    }

    protected void BindData()
    {
        SalesmanCodeBind();
        HsmodelList();
        TeamListDataBind();
        ExistingCustomerTypeDataBind();
        OrgFeeDataBind();
        OBProgramIDBDataBind();
        ProgramDataBind();
        RatePlanDataBind();
        ContractPeriodDataBind();
        SpecialPremium1DataBind();
        SpecialPremium2DataBind();
        VasCreateHolderControl.Instance().PreLoadDataToMemory(true);
    }




    protected void Release()
    {
        _oOBProgramDataSet = null;
        _oHsmodelList = null;
        _oSalesmancodeList = null;
        _oTeamcode = null;
        _oTariffFeeDataSet = null;
        _oOrgFeeDataSet = null;
        _oProgramDataSet = null;
        _oRatePlanDataSet = null;
        _oContractPeriodDataSet = null;
        _oSPremiumTypeList = null;
    }

    protected void Refresh()
    {
        Release();
        BindData();
    }


    #region Hsmodel List
    protected void HsmodelList()
    {
        if(_oHsmodelList==null)
            _oHsmodelList = ProductItemCodeBal.DrpHsmodelList("HS", null);
        hs_model_value.Items.Clear();
        hs_model_value.Items.Add(new ListItem(string.Empty, string.Empty));
        for (int i = 0; i < _oHsmodelList.Count; i++)
            hs_model_value.Items.Add(new ListItem(_oHsmodelList[i].ToString(), _oHsmodelList[i].ToString()));
    }
    #endregion

    #region SalesmanCode
    public void SalesmanCodeBind()
    {
        salesmancode_value.Items.Clear();
        salesmancode_value.Items.Add(new ListItem(string.Empty, string.Empty));
        if(_oSalesmancodeList==null)
            _oSalesmancodeList = SaleManCodeProfile.GetAllSalemanCode();

        for (int i = 0; i < _oSalesmancodeList.Count; i++)
        {
            string _sSalesman_code = _oSalesmancodeList[i].ToString();
            salesmancode_value.Items.Add(new ListItem(_sSalesman_code, _sSalesman_code));
        }
    }
    #endregion

    #region TeamList
    public void TeamListDataBind()
    {
        teamcode_value.Items.Clear();
        teamcode_value.Items.Add(new ListItem(string.Empty, string.Empty));
        if(_oTeamcode==null)
            _oTeamcode = SYSConn<MSSQLConnect>.Connect("CSSDB").GetDS("SELECT distinct teamcode FROM teamlist with (nolock)  WHERE active=1");

        IDSQuery _oDr = IDSQuery.CreateDsCriteria(_oTeamcode, "");
        while (_oDr.Read())
        {
            teamcode_value.Items.Add(new ListItem(Func.FR(_oDr["teamcode"]).Trim(), Func.FR(_oDr["teamcode"]).Trim()));
        }
        _oDr.Close();
    }
    #endregion

    #region Existing Customer Type TariffFee
    public void ExistingCustomerTypeDataBind()
    {
        if(_oTariffFeeDataSet==null)
            _oTariffFeeDataSet = TariffFeeScheduleBal.GetDataSet(SYSConn<MSSQLConnect>.Connect(), "distinct program", "active=1", null, null);
        if (_oTariffFeeDataSet.Tables.Count <= 0) return;
        exist_cust_plan_value.Items.Clear();
        exist_cust_plan_value.Items.Add(new ListItem(string.Empty, string.Empty));
        for (int i = 0; i < _oTariffFeeDataSet.Tables[0].Rows.Count; i++){
            if (!"".Equals(_oTariffFeeDataSet.Tables[0].Rows[i][0].ToString().Trim())) exist_cust_plan_value.Items.Add(new ListItem(_oTariffFeeDataSet.Tables[0].Rows[i][0].ToString(), _oTariffFeeDataSet.Tables[0].Rows[i][0].ToString()));
        }
    }
    #endregion

    #region Org Fee
    public void OrgFeeDataBind()
    {
        if(_oOrgFeeDataSet==null)
            _oOrgFeeDataSet = TariffFeeScheduleBal.GetDataSet(SYSConn<MSSQLConnect>.Connect(), "distinct org_fee", "active=1", null, null);
        if (_oOrgFeeDataSet.Tables.Count <= 0) return;
        org_fee_value.Items.Clear();
        org_fee_value.Items.Add(new ListItem(string.Empty, string.Empty));
        for (int i = 0; i < _oOrgFeeDataSet.Tables[0].Rows.Count; i++)
        {
            if (!"".Equals(_oOrgFeeDataSet.Tables[0].Rows[i][0].ToString().Trim())) org_fee_value.Items.Add(new ListItem(_oOrgFeeDataSet.Tables[0].Rows[i][0].ToString(), _oOrgFeeDataSet.Tables[0].Rows[i][0].ToString()));
        }
    }
    #endregion

    #region OB Program ID
    public void OBProgramIDBDataBind()
    {
        if (_oOBProgramDataSet == null)
            _oOBProgramDataSet = SYSConn<MSSQLConnect>.Connect().GetDS("SELECT ob_program_id FROM OBProgramProfile WITH (NOLOCK) ( WHERE active=1");

        if (_oOBProgramDataSet.Tables.Count <= 0) return;
        ob_program_id_value.Items.Clear();
        ob_program_id_value.Items.Add(new ListItem(string.Empty, string.Empty));
        for(int i=0;i<_oOBProgramDataSet.Tables[0].Rows.Count;i++){
            if (!"".Equals(_oOBProgramDataSet.Tables[0].Rows[i][0].ToString().Trim())) ob_program_id_value.Items.Add(new ListItem(_oOBProgramDataSet.Tables[0].Rows[i][0].ToString(), _oOBProgramDataSet.Tables[0].Rows[i][0].ToString()));
        }

    }
    #endregion

    #region Program
    public void ProgramDataBind()
    {
        if(_oProgramDataSet==null)
            _oProgramDataSet = BusinessTradeBal.GetDataSet(SYSConn<MSSQLConnect>.Connect(), "distinct program", "active=1", null, "program");
        if (_oProgramDataSet.Tables.Count <= 0) return;
        program_value.Items.Clear();
        program_value.Items.Add(new ListItem(string.Empty, string.Empty));
        for (int i = 0; i < _oProgramDataSet.Tables[0].Rows.Count; i++){
            if (!"".Equals(_oProgramDataSet.Tables[0].Rows[i][0].ToString().Trim())) program_value.Items.Add(new ListItem(_oProgramDataSet.Tables[0].Rows[i][0].ToString(), _oProgramDataSet.Tables[0].Rows[i][0].ToString()));
        }
    }
    #endregion

    #region RatePlan
    public void RatePlanDataBind()
    {
        if(_oRatePlanDataSet==null)
            _oRatePlanDataSet = BusinessTradeBal.GetDataSet(SYSConn<MSSQLConnect>.Connect(), "distinct rate_plan", "active=1", null, null);
        if (_oRatePlanDataSet.Tables.Count <= 0) return;
        rate_plan_value.Items.Clear();
        rate_plan_value.Items.Add(new ListItem(string.Empty, string.Empty));
        for (int i = 0; i < _oRatePlanDataSet.Tables[0].Rows.Count; i++){
            if (!"".Equals(_oRatePlanDataSet.Tables[0].Rows[i][0].ToString().Trim())) rate_plan_value.Items.Add(new ListItem(_oRatePlanDataSet.Tables[0].Rows[i][0].ToString(), _oRatePlanDataSet.Tables[0].Rows[i][0].ToString()));
        }
    }
    #endregion

    #region Contract  Period
    public void ContractPeriodDataBind()
    {
        if(_oContractPeriodDataSet==null)
            _oContractPeriodDataSet = BusinessTradeBal.GetDataSet(SYSConn<MSSQLConnect>.Connect(), "distinct con_per", "active=1", null, null);
        if (_oContractPeriodDataSet.Tables.Count <= 0) return;
        con_per_value.Items.Clear();
        con_per_value.Items.Add(new ListItem(string.Empty, string.Empty));
        for (int i = 0; i < _oContractPeriodDataSet.Tables[0].Rows.Count; i++){
            if (!"".Equals(_oContractPeriodDataSet.Tables[0].Rows[i][0].ToString().Trim())) con_per_value.Items.Add(new ListItem(_oContractPeriodDataSet.Tables[0].Rows[i][0].ToString(), _oContractPeriodDataSet.Tables[0].Rows[i][0].ToString()));
        }
    }
    #endregion

    #region Special Premium 1
    public void SpecialPremium1DataBind()
    {
        if (_oSPremiumTypeList == null)
            _oSPremiumTypeList = RWLFramework.Control<HandSetEnvironment>().Get_SPremiumType1Hs();
        s_premium1_value.Items.Clear();
        s_premium1_value.Items.Add(new ListItem(string.Empty, string.Empty));
        s_premium1_value.Items.Add(new ListItem("ALL", "ALL"));
        for (int i = 0; i < _oSPremiumTypeList.Count; i++)
        {
            s_premium1_value.Items.Add(new ListItem(_oSPremiumTypeList[i].ToString().ToUpper(), _oSPremiumTypeList[i].ToString().ToUpper()));
        }
    }
    #endregion

    #region Special  Premium 2 
    public void SpecialPremium2DataBind()
    {
        if (_oSPremiumTypeList == null)
            _oSPremiumTypeList = RWLFramework.Control<HandSetEnvironment>().Get_SPremiumType2Hs();
        s_premium2_value.Items.Clear();
        s_premium2_value.Items.Add(new ListItem(string.Empty, string.Empty));
        s_premium2_value.Items.Add(new ListItem("ALL", "ALL"));
        for (int i = 0; i < _oSPremiumTypeList.Count; i++)
        {
            s_premium2_value.Items.Add(new ListItem(_oSPremiumTypeList[i].ToString().ToUpper(), _oSPremiumTypeList[i].ToString().ToUpper()));
        }
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
        _oDB.SetConnStr(Configurator.DBName.ORADNS+((Configurator.IsUat()) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion

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
            _sScript = string.Format("<script>if(document.getElementById('{0}')!=undefined) document.getElementById('{1}').className='{2}';</script>", x_sID, x_sID, x_sValue);
        else{
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
    protected void Refresh_Click(object sender, EventArgs e)
    {
        Refresh();
    }
}
