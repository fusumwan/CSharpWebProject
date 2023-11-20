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

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.WEB.UI;
public partial class UI_RWLControlMenu : System.Web.UI.UserControl
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
                LoadingBar _oLoadingBar = new LoadingBar();
                _oLoadingBar.SrcImage = "../Resources/Images/indicator_white.gif";
                if (RWLLoadingPlace == null)
                    RWLLoadingPlace = new PlaceHolder();
                RWLLoadingPlace.Controls.Add(_oLoadingBar);
                _oLoadingBar.PageLoading(300);
            }
        }
        try
        {
            if (!string.IsNullOrEmpty(RWLFramework.CurrentUser[this.Page].Uid.ToString()))
                MobileRetentionOrderMenu.FindItem("User ID").Text = RWLFramework.CurrentUser[this.Page].Uid.ToString();

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "MobileRetentionOrderAddView"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Order Record/Add Web Log");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Order Record").ChildItems.Remove(_oItem);
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "SearchRetentionOrderView"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Order Record/View | Modify Web Log");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Order Record").ChildItems.Remove(_oItem);
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "LetterView"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Order Record/Check Redemption Letter");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Order Record").ChildItems.Remove(_oItem);
            }

            if (Configurator.IsUat())
            {
                if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "CustomerAccountSearch"))
                {
                    MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Order Record/Change Customer Details");
                    if (_oItem != null) MobileRetentionOrderMenu.FindItem("Order Record").ChildItems.Remove(_oItem);
                }
            }
            else
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Order Record/Change Customer Details");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Order Record").ChildItems.Remove(_oItem);
            }

            
            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "ChangeVasSearch"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Order Record/Change VAS");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Order Record").ChildItems.Remove(_oItem);
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "IncompleteDeliveryDateReport"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Order Record/Incomplete Delivery Order");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Order Record").ChildItems.Remove(_oItem);
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "AdminView"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Order Record/View | Retrieve Order - PY Operations");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Order Record").ChildItems.Remove(_oItem);
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "AccessPageManagement"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Order Record/Access Right Control");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Order Record").ChildItems.Remove(_oItem);
            }


            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "HandSetView"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Handset_Mapping/View_Modify_Handset_Rebate_Mapping");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Handset_Mapping").ChildItems.Remove(_oItem);
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "ItemCodeViewAction"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Handset_Mapping/Handset_Item_Code_Mapping");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Handset_Mapping").ChildItems.Remove(_oItem);
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "HandSetMappingAdd"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Handset_Mapping/Add_Handset_Rebate_Mapping");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Handset_Mapping").ChildItems.Remove(_oItem);
            }


            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "HandSetStockView"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Order Record/Handset Stock");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Order Record").ChildItems.Remove(_oItem);
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "TierAutoSelectionExcelUpload"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Order Record/Upload Tier");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Order Record").ChildItems.Remove(_oItem);
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "BusinessTradeAdd"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Trade Field Mapping/Add Trade Field Mapping");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Trade Field Mapping").ChildItems.Remove(_oItem);
            }
            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "BusinessTradeView"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Trade Field Mapping/View Modify Trade Field Mapping");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Trade Field Mapping").ChildItems.Remove(_oItem);
            }


            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "ReleaseOrder"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Other/Release Restriction");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Other").ChildItems.Remove(_oItem);
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "DeliveryAddress"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Trade Field Mapping/Delivery Address mapping");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Trade Field Mapping").ChildItems.Remove(_oItem);
            }

            

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "RebateGPViewImplement"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Mapping/HS Program Group Mapping");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Mapping").ChildItems.Remove(_oItem);
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "HandSetUpload"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Other/Upload HS Mapping with excel");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Other").ChildItems.Remove(_oItem);
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "DeleteRate"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Other/Cancellation Rate");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Other").ChildItems.Remove(_oItem);
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "ViewArpuModule"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Other/ARPU In | Out");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Other").ChildItems.Remove(_oItem);
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "K610iSpecial"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Other/Special Tracking");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Other").ChildItems.Remove(_oItem);
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "DailyCount"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Other/Daily Gross issue");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Other").ChildItems.Remove(_oItem);
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "HandSetCountView"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Other/View Handset Premium Count");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Other").ChildItems.Remove(_oItem);
            }


            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "FoManagement"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Fallout_Case/3G_CPE_Fallout_Case");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Fallout_Case").ChildItems.Remove(_oItem);
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "SalesFollowCSA"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Fallout_Case/Fallout_By_PY_Operations");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Fallout_Case").ChildItems.Remove(_oItem);
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "FallOutDeltailCase"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Fallout_Case/Delivery_Fallout_Case");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Fallout_Case").ChildItems.Remove(_oItem);
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "AmendReportView"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Other/Counting Of Amendment Report");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Other").ChildItems.Remove(_oItem);
            }
            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "HandSetUpload"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Other/Upload HS Mapping with excel");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Other").ChildItems.Remove(_oItem);
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "VasControlMain"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Other/VAS CONTROL");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Other").ChildItems.Remove(_oItem);
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "OrderRetentionAO"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Other/AO Case");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Other").ChildItems.Remove(_oItem);
            }


            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "ProgramIDAdd"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Other/Add New Program ID");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Other").ChildItems.Remove(_oItem);
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "UploadRedemptionLetter"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Other/Upload Redemption Letters List");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Other").ChildItems.Remove(_oItem);
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "ProgramProductView"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Other/Modifty Program ID");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Other").ChildItems.Remove(_oItem);
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "GiftCodeViewAction"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Mapping/Free Gift Item Code Mapping");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Mapping").ChildItems.Remove(_oItem);
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "AccessoryViewAction"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Mapping/Accessory Item Code Mapping");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Mapping").ChildItems.Remove(_oItem);
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "PlanRetentionViewAction"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Mapping/Plan_Code_Plan_Fee_Mapping");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Mapping").ChildItems.Remove(_oItem);
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "RebateGPViewImplement"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Mapping/HS Program Group Mapping");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Mapping").ChildItems.Remove(_oItem);
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "SpecialPremiumViewImplement"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Mapping/Special Premium Mapping");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Mapping").ChildItems.Remove(_oItem);
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "TariffFeeViewImplement"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Mapping/Existing Customer Type");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Mapping").ChildItems.Remove(_oItem);
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "FreeMonthViewImplement"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Mapping/Free Monthly Fee Mapping");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Mapping").ChildItems.Remove(_oItem);
            }


            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "TotalAllMappingReport"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Report_DownLoad/Download_All_Mapping_Table");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Report_DownLoad").ChildItems.Remove(_oItem);
            }

            if (!WebFunc.PagePrivilegeCheck(RWLFramework.CurrentUser[this.Page], "ReportAllFoCSA"))
            {
                MenuItem _oItem = (MenuItem)MobileRetentionOrderMenu.FindItem("Report_DownLoad/Download_All_Fallout_Cases_By_CSA");
                if (_oItem != null) MobileRetentionOrderMenu.FindItem("Report_DownLoad").ChildItems.Remove(_oItem);
            }



        }
        catch (Exception exp)
        {
            string error = exp.ToString();
        }
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
