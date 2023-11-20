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



public partial class Web_MobileRetentionMain : NEURON.WEB.UI.BasePage
{
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion

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

    EDFStatusProfile _oEDFStatusProfile = new EDFStatusProfile();
    protected void Page_Load(object sender, EventArgs e)
    {
        string _sPath = Request.ApplicationPath;
        _sPath = "";
        this.HeaderScripts.Text = string.Format(
        @"<script type=""text/javascript"" src=""{0}/Resources/Scripts/jquery-1.3.2.min.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/global.js""></script>
        <!--[if lte IE 6]><script defer type=""text/javascript"" src=""{0}/Resources/Scripts/pngfix.js""></script><![endif]-->
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/norefresh.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/script.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/jquery-ui-1.8.2.custom.min.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/jquery.alerts.js""></script>
        <link rel=""stylesheet"" href=""{0}/Resources/Styles/jquery.alerts.css"" type=""text/css"" />"
       , _sPath);

        //Session["uid"] = "109892";
        //Session["uid"] = "264275";
        //Session["uid"] = "1116532";

        Session["uid"] = "A8350006";
        Session["lv"] = "65535";
        Session["arprog"] = "RWLN";
        Session["channel"] = string.Empty;

        WebFunc.PrivilegeCheck(this.Page);
        RWLFramework.DataBaseConfigSetting();
        RWLFramework.InitModel();
        RWLFramework.CurrentUser[this.Page].SetUid(n_sSessionUid);
        RWLFramework.CurrentUser[this.Page].SetLv(n_sSessionLv);
        RWLFramework.CurrentUser[this.Page].SetArprog(n_sSessionArprog);
        RWLFramework.CurrentUser[this.Page].SetChannel(n_sSessionChannel);
        try
        {


        }
        catch (Exception exp)
        {
            Session["uid"] = string.Empty;
            Session["lv"] = string.Empty;
            Session["arprog"] = string.Empty;
            Response.Redirect("MobileOrderLockMessage.aspx?OrderLockMsg=EDF System error!");
        }
        InitFrame();
    }



    protected void Check()
    {
        string _sQuery = "SELECT TOP 1 auto_name FROM [MobileAutoProgram] WHERE auto_name='RWLAUTO' ";
        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
        if (!_oDr.Read())
        {
            MobileAutoProgram _oMobileAutoProgram = new MobileAutoProgram(SYSConn<MSSQLConnect>.Connect());
            _oMobileAutoProgram.SetAuto_name("RWLAUTO");
            _oMobileAutoProgram.SetRdate(DateTime.Now);
            _oMobileAutoProgram.SetActive(true);
            MobileAutoProgramBal.InsertWithOutLastID(SYSConn<MSSQLConnect>.Connect(), _oMobileAutoProgram);
        }
        _oDr.Close();
        _oDr.Dispose();
    }

    #region Run Javascript Function
    public void RunJavascriptFunc(string x_sFunc)
    {
        string _sFunc = ((x_sFunc.IndexOf(';') > 0) ? x_sFunc : x_sFunc + ";");
        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sFunc + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), string.Format("<script>{0}</script>", _sFunc), false);
    }
    #endregion

    protected void SetHtmlAnchorDisabled(HtmlAnchor x_oHtmlAnchor, bool x_bDisabled)
    {
        if (x_bDisabled)
        {
            x_oHtmlAnchor.Disabled = x_bDisabled;
            x_oHtmlAnchor.Attributes["onclick"] = "javascript:none();";
            x_oHtmlAnchor.Visible = false;
        }
        else
        {
            //x_oHtmlAnchor.Attributes.Remove("onclick");
            x_oHtmlAnchor.Visible = true;
        }
    }


    protected void InitFrame()
    {

        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "MessageViewAction"))
            SetHtmlAnchorDisabled(MessageViewAction, false);
        else
            SetHtmlAnchorDisabled(MessageViewAction, true);

        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "MobileRetentionOrderAddView"))
            SetHtmlAnchorDisabled(MobileRetentionOrderAddView, false);
        else
            SetHtmlAnchorDisabled(MobileRetentionOrderAddView, true);

        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "CustomerAccountSearch"))
            SetHtmlAnchorDisabled(CustomerAccountSearch, false);
        else
            SetHtmlAnchorDisabled(CustomerAccountSearch, true);

        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "HandSetMappingAdd"))
            SetHtmlAnchorDisabled(HandSetMappingAdd, false);
        else
            SetHtmlAnchorDisabled(HandSetMappingAdd, true);

        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "HandSetView"))
            SetHtmlAnchorDisabled(HandSetView, false);
        else
            SetHtmlAnchorDisabled(HandSetView, true);

        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "ItemCodeViewAction"))
            SetHtmlAnchorDisabled(ItemCodeViewAction, false);
        else
            SetHtmlAnchorDisabled(ItemCodeViewAction, true);

        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "HandSetStockView"))
            SetHtmlAnchorDisabled(HandSetStockView, false);
        else
            SetHtmlAnchorDisabled(HandSetStockView, true);

        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "BusinessTradeView"))
            SetHtmlAnchorDisabled(BusinessTradeView, false);
        else
            SetHtmlAnchorDisabled(BusinessTradeView, true);

        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "HandSetCountView"))
            SetHtmlAnchorDisabled(HandSetCountView, false);
        else
            SetHtmlAnchorDisabled(HandSetCountView, true);

        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "ReleaseOrder"))
            SetHtmlAnchorDisabled(ReleaseOrder, false);
        else
            SetHtmlAnchorDisabled(ReleaseOrder, true);

        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "DeliveryAddress"))
            SetHtmlAnchorDisabled(DeliveryAddress, false);
        else
            SetHtmlAnchorDisabled(DeliveryAddress, true);

        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "TotalAllMappingReport"))
            SetHtmlAnchorDisabled(TotalAllMappingReport, false);
        else
            SetHtmlAnchorDisabled(TotalAllMappingReport, true);

        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "RebateGPViewImplement"))
            SetHtmlAnchorDisabled(RebateGPViewImplement, false);
        else
            SetHtmlAnchorDisabled(RebateGPViewImplement, true);

        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "HandSetUpload"))
            SetHtmlAnchorDisabled(HandSetUpload, false);
        else
            SetHtmlAnchorDisabled(HandSetUpload, true);

        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "DailyCountNew"))
            SetHtmlAnchorDisabled(DailyCountNew, false);
        else
            SetHtmlAnchorDisabled(DailyCountNew, true);

        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "AmendReportView"))
            SetHtmlAnchorDisabled(AmendReportView, false);
        else
            SetHtmlAnchorDisabled(AmendReportView, true);

        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "HandSetUpload"))
            SetHtmlAnchorDisabled(HandSetUpload, false);
        else
            SetHtmlAnchorDisabled(HandSetUpload, true);
        /*
        if ((RWLFramework.CurrentUser[this.Page].Uid == "1022243" || RWLFramework.CurrentUser[this.Page].Uid == "A3150498") || RWLFramework.CurrentUser[this.Page].Uid == "A8350006" || RWLFramework.CurrentUser[this.Page].Uid == "A9020005")
            ar_rights.Visible = true;
        else
            ar_rights.Visible = false;
        */
        ar_rights.Visible = false;



        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "VasControlMain"))
            SetHtmlAnchorDisabled(VasControlMain, false);
        else
            SetHtmlAnchorDisabled(VasControlMain, true);

        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "ProgramIDAdd"))
            SetHtmlAnchorDisabled(ProgramIDAdd, false);
        else
            SetHtmlAnchorDisabled(ProgramIDAdd, true);

        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "ProgramProductView"))
            SetHtmlAnchorDisabled(ProgramProductView, false);
        else
            SetHtmlAnchorDisabled(ProgramProductView, true);

        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "GiftCodeViewAction"))
            SetHtmlAnchorDisabled(GiftCodeViewAction, false);
        else
            SetHtmlAnchorDisabled(GiftCodeViewAction, true);

        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "AccessoryViewAction"))
            SetHtmlAnchorDisabled(AccessoryViewAction, false);
        else
            SetHtmlAnchorDisabled(AccessoryViewAction, true);

        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "PlanRetentionViewAction"))
            SetHtmlAnchorDisabled(PlanRetentionViewAction, false);
        else
            SetHtmlAnchorDisabled(PlanRetentionViewAction, true);


        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "RebateGPViewImplement"))
            SetHtmlAnchorDisabled(RebateGPViewImplement, false);
        else
            SetHtmlAnchorDisabled(RebateGPViewImplement, true);

        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "SpecialPremiumViewImplement"))
            SetHtmlAnchorDisabled(SpecialPremiumViewImplement, false);
        else
            SetHtmlAnchorDisabled(SpecialPremiumViewImplement, true);

        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "TariffFeeViewImplement"))
            SetHtmlAnchorDisabled(TariffFeeViewImplement, false);
        else
            SetHtmlAnchorDisabled(TariffFeeViewImplement, true);

        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "FreeMonthViewImplement"))
            SetHtmlAnchorDisabled(FreeMonthViewImplement, false);
        else
            SetHtmlAnchorDisabled(FreeMonthViewImplement, true);



        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "AccessPageManagement"))
            SetHtmlAnchorDisabled(AccessPageManagement, false);
        else
            SetHtmlAnchorDisabled(AccessPageManagement, true);


        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "HandSetUpload"))
            SetHtmlAnchorDisabled(HandSetUpload, false);
        else
            SetHtmlAnchorDisabled(HandSetUpload, true);



        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "LetterView"))
            SetHtmlAnchorDisabled(LetterView, false);
        else
            SetHtmlAnchorDisabled(LetterView, true);


        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "AdminView"))
            SetHtmlAnchorDisabled(AdminView, false);
        else
            SetHtmlAnchorDisabled(AdminView, true);


        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "FS_AdminView"))
            FS_AdminView.Visible = true;
        else
            FS_AdminView.Visible = false;


        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "IncompleteDeliveryDateReport"))
            SetHtmlAnchorDisabled(IncompleteDeliveryDateReport, false);
        else
            SetHtmlAnchorDisabled(IncompleteDeliveryDateReport, true);

        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "FoManagement"))
            SetHtmlAnchorDisabled(FoManagement, false);
        else
            SetHtmlAnchorDisabled(FoManagement, true);

        /*
        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "OrderRetentionAO"))
            SetHtmlAnchorDisabled(OrderRetentionAO, false);
        else
            SetHtmlAnchorDisabled(OrderRetentionAO, false);
        */
        OrderRetentionAO.Visible = true;

        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "BusinessTradeAdd"))
            SetHtmlAnchorDisabled(BusinessTradeAdd, false);
        else
            SetHtmlAnchorDisabled(BusinessTradeAdd, true);

        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "SalesFollowCSA"))
            SetHtmlAnchorDisabled(SalesFollowCSA, false);
        else
            SetHtmlAnchorDisabled(SalesFollowCSA, true);


        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "FallOutDeltailCase"))
            SetHtmlAnchorDisabled(FallOutDeltailCase, false);
        else
            SetHtmlAnchorDisabled(FallOutDeltailCase, true);


        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "DailyCount"))
            SetHtmlAnchorDisabled(DailyCount, false);
        else
            SetHtmlAnchorDisabled(DailyCount, true);


        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "UploadRedemptionLetter"))
            SetHtmlAnchorDisabled(UploadRedemptionLetter, false);
        else
            SetHtmlAnchorDisabled(UploadRedemptionLetter, true);


        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "GiftCodeViewAction"))
            SetHtmlAnchorDisabled(GiftCodeViewAction, false);
        else
            SetHtmlAnchorDisabled(GiftCodeViewAction, true);


        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "DeleteRate"))
            SetHtmlAnchorDisabled(DeleteRate, false);
        else
            SetHtmlAnchorDisabled(DeleteRate, true);



        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "ViewArpuModule"))
            SetHtmlAnchorDisabled(ViewArpuModule, false);
        else
            SetHtmlAnchorDisabled(ViewArpuModule, true);



        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "ReportAllFoCSA"))
            SetHtmlAnchorDisabled(ReportAllFoCSA, false);
        else
            SetHtmlAnchorDisabled(ReportAllFoCSA, true);


        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "K610iSpecial"))
            SetHtmlAnchorDisabled(K610iSpecial, false);
        else
            SetHtmlAnchorDisabled(K610iSpecial, true);



        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "TierAutoSelectionExcelUpload"))
            SetHtmlAnchorDisabled(TierAutoSelectionExcelUpload, false);
        else
            SetHtmlAnchorDisabled(TierAutoSelectionExcelUpload, true);


        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "ChangeVasSearch"))
            SetHtmlAnchorDisabled(ChangeVasSearch, false);
        else
            SetHtmlAnchorDisabled(ChangeVasSearch, true);

        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "ChangeStaffNoCurrentAccessRight"))
            SetHtmlAnchorDisabled(ChangeStaffNoCurrentAccessRight, false);
        else
            SetHtmlAnchorDisabled(ChangeStaffNoCurrentAccessRight, true);


        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "BankCodeMapping"))
            SetHtmlAnchorDisabled(BankCodeMapping, false);
        else
            SetHtmlAnchorDisabled(BankCodeMapping, true);


        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "AssignMobileIMEI"))
            SetHtmlAnchorDisabled(AssignMobileIMEI, false);
        else
            SetHtmlAnchorDisabled(AssignMobileIMEI, true);

        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "ManagementIMEI"))
            SetHtmlAnchorDisabled(ManagementIMEI, false);
        else
            SetHtmlAnchorDisabled(ManagementIMEI, true);

        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "MobileOneManagement"))
            SetHtmlAnchorDisabled(MobileOneManagement, false);
        else
            SetHtmlAnchorDisabled(MobileOneManagement, true);

        if (WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "BasicBackEndManagement"))
            SetHtmlAnchorDisabled(BasicBackEndManagement, false);
        else
            SetHtmlAnchorDisabled(BasicBackEndManagement, true);


    }
}