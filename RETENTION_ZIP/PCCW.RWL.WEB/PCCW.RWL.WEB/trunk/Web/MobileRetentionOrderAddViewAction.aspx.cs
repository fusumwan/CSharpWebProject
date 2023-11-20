using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
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
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;
using System.Text;


public partial class MobileRetentionOrderAddViewAction : NEURON.WEB.UI.BasePage
{
    MSSQLConnect n_oDB = new MSSQLConnect();
    MobileOrderViewControler n_oMobileOrderViewControler = new MobileOrderViewControler();
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
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

        WebFunc.PrivilegeCheck(this.Page);
        if (Request["AutoSelection"] != null)
            AutoSelection.Value = Request["AutoSelection"].ToString();
        if (WebFunc.RequestQuery("AllPageInScreen") != null)
            AllPageInScreen.Value = WebFunc.RequestQuery("AllPageInScreen").ToString();

        string _sMrt = WebFunc.RequestQuery("mrt");
        if (_sMrt == string.Empty)
        {
            RunJavascriptFunc("alert('Please Enter MRT No!')");
            return;
        }

        string _sISSUE_TYPE = Func.RQ(Request["ISSUE_TYPE"]).Trim();




        n_oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
        n_oMobileOrderViewControler.SetDB(n_oDB);
        n_oMobileOrderViewControler.SetPrefix(Configurator.MSSQLTablePrefix);
        if (Session["lv"] != null){
            if(Func.IsParseInt(Session["lv"].ToString())) n_oMobileOrderViewControler.SetProg_Lv(Convert.ToInt32(Session["lv"].ToString()));
        }
        n_oMobileOrderViewControler.SetMrt(_sMrt);
        n_oMobileOrderViewControler.Issue_type = _sISSUE_TYPE;
        n_oMobileOrderViewControler.SetUid(RWLFramework.CurrentUser[this.Page].Uid);
        bool _bPass = false;
        if (_sISSUE_TYPE == "UPGRADE")
        {
            _bPass = true;
            n_oMobileOrderViewControler.SetAdd_flag(1);
        }
        else if (n_oMobileOrderViewControler.InitDataByMRT())
            _bPass = true;

        if (_bPass)
        {
            string _sAlert = string.Empty;
            for (int i = 0; i < n_oMobileOrderViewControler.GetResponseMsg().Count; i++)
            {
                _sAlert += n_oMobileOrderViewControler.GetResponseMsg()[i].ToString() + "\\n";
            }
            if (_sAlert != string.Empty)
            {
                WebFunc.RegisterScriptEX(this.Page, _sAlert);
                WebFunc.RegisterScript(this.Page, "window.location.href='MobileRetentionOrderAddView.aspx';");
            }
            else
            {
                if (n_oMobileOrderViewControler.GetDup_flag() == 1)
                {
                    string _sHs_model = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar("SELECT hs_model FROM MobileRetentionOrder WHERE order_id='" + n_oMobileOrderViewControler.GetRwlOrderID().ToString() + "'");
                    if (_sHs_model.Trim().Equals(string.Empty))
                        Response.Redirect("MobileRetentionOrderAddModify.aspx?" + WebFunc.qsOrder_idName + "=" + Func.IDAdd100000(n_oMobileOrderViewControler.GetRwlOrderID()).ToString().Trim() + "&AutoSelection=" + AutoSelection.Value.ToString() + "&AllPageInScreen=" + AllPageInScreen.Value.ToString() + "&ISSUE_TYPE=" + _sISSUE_TYPE);
                    else
                        Response.Redirect("MobileRetentionOrderAddView.aspx");
                }
                else if (n_oMobileOrderViewControler.GetAdd_flag() == 1)
                {
                    if (!isAutomation(_sMrt, _sISSUE_TYPE))
                    {
                        Response.Redirect("MobileRetentionOrderCreate.aspx?mrt=" + _sMrt + "&AutoSelection=" + AutoSelection.Value.ToString() + "&AllPageInScreen=" + AllPageInScreen.Value.ToString() + "&ISSUE_TYPE=" + _sISSUE_TYPE);
                    }
                    else
                    {
                        Response.Redirect("OfferAutomationPage.aspx?mrt=" + _sMrt + "&AutoSelection=" + AutoSelection.Value.ToString() + "&AllPageInScreen=" + AllPageInScreen.Value.ToString() + "&ISSUE_TYPE=" + _sISSUE_TYPE);
                    }
                }
                else if (n_oMobileOrderViewControler.GetAdd_flag() == 0)
                    Response.Redirect("MobileRetentionOrderAddView.aspx");

                if (n_oMobileOrderViewControler.GetDone_flag() == 0)
                {
                    RunJavascriptFunc("alert('Please modify old order " + Func.IDAdd100000(n_oMobileOrderViewControler.GetRwlOrderID()).ToString().Trim() + "')");
                    Response.Redirect("SearchRetentionOrderViewDetail.aspx?" + WebFunc.qsOrder_idName + "=" + Func.IDAdd100000(n_oMobileOrderViewControler.GetRwlOrderID()) + "&AutoSelection=" + AutoSelection.Value.ToString() + "&AllPageInScreen=" + AllPageInScreen.Value.ToString() + "&ISSUE_TYPE=" + _sISSUE_TYPE);
                }
            }
        }
    }


    public bool isAutomation(string x_sMrt,string x_sISSUE_TYPE)
    {
        bool _bFound = false;
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("SELECT distinct offer_name,trade_field_id FROM OfferAutomation a LEFT JOIN CallListUploadProfile b ON ");
        _oQuery.Append("a.call_list_program_id=b.call_list_program_id LEFT JOIN CallListUploadMrtNo c ");
        _oQuery.Append("ON a.call_list_program_id=c.call_list_program_id WHERE ");
        _oQuery.Append("a.active =1 AND b.active=1 AND c.mrt_no='" + x_sMrt + "' and b.issue_type='" + x_sISSUE_TYPE + "' AND a.offer_name!='' and a.offer_name IS NOT NULL ");
       SqlDataReader _oDr= SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
       if (_oDr.Read())
       {
           _bFound = true;
       }
       _oDr.Close();
       _oDr.Dispose();
       return _bFound;
    }


    #region Run Javascript Function
    public void RunJavascriptFunc(string x_sFunc)
    {
        string _sFunc = ((x_sFunc.IndexOf(';') > 0) ? x_sFunc : x_sFunc + ";");
        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sFunc + (new Random()).Next(1, 1000).ToString()+Guid.NewGuid().ToString(), string.Format("<script>{0}</script>", _sFunc), false);
    }
    #endregion
}
