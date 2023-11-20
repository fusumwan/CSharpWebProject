using System;
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
using System.Text;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.WEB.UI;

public partial class UI_GlobalNavigation : System.Web.UI.UserControl
{
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
        RWLFramework.DataBaseConfigSetting();
        if (!string.IsNullOrEmpty(n_sSessionUid)) { RWLFramework.CurrentUser[this.Page].SetUid(n_sSessionUid); }
        if (!string.IsNullOrEmpty(n_sSessionLv)) { RWLFramework.CurrentUser[this.Page].SetLv(n_sSessionLv); }
        if (!string.IsNullOrEmpty(n_sSessionArprog)) { RWLFramework.CurrentUser[this.Page].SetArprog(n_sSessionArprog); }
        if (!string.IsNullOrEmpty(n_sSessionChannel)) { RWLFramework.CurrentUser[this.Page].SetChannel(n_sSessionChannel); }
        if (LoadingPageCheck())
        {
            if (!IsPostBack)
            {
                /*
                LoadingBar _oLoadingBar = new LoadingBar();
                _oLoadingBar.SrcImage = "../Resources/Images/indicator_white.gif";
                if (RWLLoadingPlace == null)
                    RWLLoadingPlace = new PlaceHolder();
                RWLLoadingPlace.Controls.Add(_oLoadingBar);
                _oLoadingBar.PageLoading(300);
                */
            }
        }
        try
        {
            if (!string.IsNullOrEmpty(RWLFramework.CurrentUser[this.Page].Uid.ToString()))
                StaffNumber.Text = RWLFramework.CurrentUser[this.Page].Uid.ToString();

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "MobileRetentionOrderAddView"))
            {
                Add_Web_LogLI.Visible = false;
            }
            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "SearchRetentionOrderView"))
            {
                View_Modify_Web_LogLI.Visible = false;
            }
            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "LetterView"))
            {
                Check_Redemption_LetterLI.Visible = false;
            }
            if (Configurator.IsUat())
            {
                if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "CustomerAccountSearch"))
                {
                    Change_Customer_DetailsLI.Visible = false;
                }
            }
            else
            {
                Change_Customer_DetailsLI.Visible = false;
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "ChangeVasSearch"))
            {
                Change_VASLI.Visible = false;
            }
            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "AdminView"))
            {
                View_Retrieve_Order_PY_OperationsLI.Visible = false;
            }
            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "AccessPageManagement"))
            {
                Access_Right_Control.Visible = false;
            }
            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "HandSetView"))
            {
                View_Modify_Handset_Rebate_MappingLI.Visible = false;
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "ItemCodeViewAction"))
            {
                Handset_Item_Code_MappingLI.Visible = false;
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "HandSetMappingAdd"))
            {
                Add_Handset_Rebate_MappingLI.Visible = false;
            }
            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "HandSetStockView"))
            {
                Handset_StockLI.Visible = false;
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "TierAutoSelectionExcelUpload"))
            {
                Upload_TierLI.Visible = false;
            }
            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "BusinessTradeAdd"))
            {
                Add_Trade_Field_MappingLI.Visible = false;
            }
            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "BusinessTradeView"))
            {
                View_Modify_Trade_Field_MappingLI.Visible = false;
            }
            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "ReleaseOrder"))
            {
                Release_RestrictionLI.Visible = false;
            }
            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "DeliveryAddress"))
            {
                Delivery_Address_MappingLI.Visible = false;
            }
            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "RebateGPViewImplement"))
            {
                HS_Program_Group_MappingLI.Visible = false;
            }
            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "HandSetUpload"))
            {
                Upload_HS_Mapping_With_ExcelLI.Visible = false;
            }
            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "DeleteRate"))
            {
                Cancellation_RateLI.Visible = false;
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "ViewArpuModule"))
            {
                ARPU_In_OutLI.Visible = false;
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "K610iSpecial"))
            {
                Special_TrackingLI.Visible = false;
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "DailyCount"))
            {
                Daily_Gross_IssueLI.Visible = false;
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "HandSetCountView"))
            {
                View_Handset_Premium_CountLI.Visible = false;
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "FoManagement"))
            {
                THREEG_CPE_Fallout_CaseLI.Visible = false;
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "SalesFollowCSA"))
            {
                Fallout_By_PY_OperationsLI.Visible = false;
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "FallOutDeltailCase"))
            {
                Delivery_Fallout_CaseLI.Visible = false;
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "AmendReportView"))
            {
                Counting_Of_Amendment_ReportLI.Visible = false;
            }
            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "HandSetUpload"))
            {
                Upload_HS_Mapping_With_ExcelLI.Visible = false;
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "VasControlMain"))
            {
                VAS_CONTROLLI.Visible = false;
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "OrderRetentionAO"))
            {
                AO_CaseLI.Visible = false;
            }
            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "ProgramIDAdd"))
            {
                Add_New_Program_IDLI.Visible = false;
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "UploadRedemptionLetter"))
            {
                Upload_Redemption_Letters_ListLI.Visible = false;
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "ProgramProductView"))
            {
                Modifty_Program_IDLI.Visible = false;
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "GiftCodeViewAction"))
            {
                Free_Gift_Item_Code_MappingLI.Visible = false;
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "AccessoryViewAction"))
            {
                Accessory_Item_Code_MappingLI.Visible = false;
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "PlanRetentionViewAction"))
            {
                Plan_Code_Plan_Fee_MappingLI.Visible = false;
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "RebateGPViewImplement"))
            {
                HS_Program_Group_MappingLI.Visible = false;
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "SpecialPremiumViewImplement"))
            {
                Special_Premium_MappingLI.Visible = false;
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "TariffFeeViewImplement"))
            {
                Existing_Customer_TypeLI.Visible = false;
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "FreeMonthViewImplement"))
            {
                Free_Monthly_Fee_MappingLI.Visible = false;
            }


            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "TotalAllMappingReport"))
            {
                Download_All_Mapping_TableLI.Visible = false;
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "ReportAllFoCSA"))
            {
                Download_All_Fallout_Cases_By_CSALI.Visible = false;
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "BankCodeMapping"))
            {
                Bank_Code_MappingLI.Visible = false;
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "AssignMobileIMEI"))
            {
                AssignMobileIMEILI.Visible = false;
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page],"ManagementIMEI"))
            {
                ManagementIMEI.Visible = false;
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "MobileOneManagement"))
            {
                MobileOneManagement.Visible = false;
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "BasicBackEndManagement"))
            {
                BasicBackEndManagement.Visible = false;
            }
        }
        catch (Exception exp)
        {
            string error = exp.ToString();
        }

        StringBuilder _oQuery=new StringBuilder();

        _oQuery.Append("<script language=\"JavaScript\">");
        _oQuery.Append(" function key(){ ");
        _oQuery.Append(" if(event.shiftKey || event.keyCode==116){");
        _oQuery.Append(" window.close();}");
        _oQuery.Append(" return false;}");
        _oQuery.Append(" document.onkeydown=key;");
        _oQuery.Append(" if (window.Event){");
        _oQuery.Append(" try{document.captureEvents(Event.MOUSEUP);}catch(e){}  }");
         _oQuery.Append(" </script>");
         BlockShiftKey.Text = _oQuery.ToString();
         
         if (WebFunc.PageName.Equals("MobileRetentionMain.aspx"))
         {

             if (RWLFramework.CurrentUser[this.Page].Uid.Equals("1022243") ||
                 RWLFramework.CurrentUser[this.Page].Uid.Equals("A3150498"))
             {
                 BlockShiftKey.Visible = false;
             }
         }
         else
             BlockShiftKey.Visible = false;
    }

    public bool LoadingPageCheck()
    {
        if (this.Page.Request.Url.ToString().ToLower().IndexOf("MobileRetentionOrderCreate.aspx".ToLower()) >= 0)
            return false;
        else if (this.Page.Request.Url.ToString().ToLower().IndexOf("MobileRetentionOrderAddModify.aspx".ToLower()) >= 0)
            return false;
        else if (this.Page.Request.Url.ToString().ToLower().IndexOf("PreviousOrderModifyNoCheck.aspx".ToLower()) >= 0)
            return false;
        else if (this.Page.Request.Url.ToString().ToLower().IndexOf("PreviousOrderModify.aspx".ToLower()) >= 0)
            return false;
        return true;
    }
}
