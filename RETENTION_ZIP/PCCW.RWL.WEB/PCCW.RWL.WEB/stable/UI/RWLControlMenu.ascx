<%@ Control Language="C#" AutoEventWireup="true" CodeFile="RWLControlMenu.ascx.cs" Inherits="UI_RWLControlMenu" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>


<asp:PlaceHolder ID="RWLLoadingPlace" runat="server"></asp:PlaceHolder>

 
 <table border="0" width="100%" style="vertical-align:top;">
    <tr style="margin:0px 0px 0px 0px;">
    <td style="margin:0px 0px 0px 0px;">
        <table border="0" style="vertical-align:top;" width="100%">
        <tr style="margin:0px 0px 0px 0px;">
            <td style="margin:0px 0px 0px 0px;">
            <img src="../MasterImage/pccw.gif" />
            </td>
            <td valign="top" align="right" style="margin:0px 0px 0px 0px;">
            <script language="javascript">function none() {}</script>
            <asp:Menu ID="MobileRetentionOrderMenu" runat="server" BackColor="#EFEFEF" 
                    DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="12px" Font-Bold="false" 
                    ForeColor="Black" StaticSubMenuIndent="10px" Orientation="Horizontal" 
                    StaticEnableDefaultPopOutImage="False">
                <Items>
                <asp:MenuItem Text="Home" Value="Home" NavigateUrl="~/Web/MobileRetentionMain.aspx"></asp:MenuItem>
                <asp:MenuItem Text = "Order Record" Value="Order Record" NavigateUrl="javascript:none()"> 
                    <asp:MenuItem Text = "Add Web Log" Value="Add Web Log" NavigateUrl="~/Web/MobileRetentionOrderAddView.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="View / Modify Web Log" Value="View | Modify Web Log" NavigateUrl="~/Web/SearchRetentionOrderView.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Check Redemption Letter" Value="Check Redemption Letter" NavigateUrl="~/Web/LetterView.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Handset Stock" Value="Handset Stock" NavigateUrl="~/Web/HandSetStockView.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Upload Tier" Value="Upload Tier" NavigateUrl="~/Web/TierAutoSelectionExcelUpload.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Change Customer Details" Value="Change Customer Details" NavigateUrl="~/Web/CustomerAccountSearch.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Change VAS" Value="Change VAS" NavigateUrl="~/Web/ChangeVasSearch.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="View/Retrieve Order - PY Operations" Value="View | Retrieve Order - PY Operations" NavigateUrl="~/Web/AdminView.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Incomplete Delivery Order" Value="Incomplete Delivery Order" NavigateUrl="~/Web/IncompleteDeliveryDateReport.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Access Right Control" Value="Access Right Control" NavigateUrl="~/Web/AccesRight/AccessPageManagement.aspx"></asp:MenuItem>
               </asp:MenuItem>
               <asp:MenuItem Text = "Handset Mapping" Value="Handset_Mapping" NavigateUrl="javascript:none()"> 
                   <asp:MenuItem Text = "Add Handset Rebate Mapping" Value="Add_Handset_Rebate_Mapping"  NavigateUrl="~/Web/HandSetMappingAdd.aspx"></asp:MenuItem>
                   <asp:MenuItem Text = "View/ Modify Handset Rebate Mapping" Value="View_Modify_Handset_Rebate_Mapping"  NavigateUrl="~/Web/HandSetView.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Handset Item Code Mapping" Value="Handset_Item_Code_Mapping" NavigateUrl="~/Web/ItemCodeViewAction.aspx"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Fallout Case" Value="Fallout_Case"  NavigateUrl="javascript:none()">
                        <asp:MenuItem Text="3G &amp; CPE Fallout Case"  Value="3G_CPE_Fallout_Case" NavigateUrl="~/Web/FoManagement.aspx"></asp:MenuItem>
                        <asp:MenuItem Text="Fallout By PY Operations" Value="Fallout_By_PY_Operations" NavigateUrl="~/Web/SalesFollowCSA.aspx"></asp:MenuItem>
                        <asp:MenuItem Text="Delivery Fallout Case" Value="Delivery_Fallout_Case" NavigateUrl="~/Web/FallOutDeltailCase.aspx"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Trade Field Mapping" Value="Trade Field Mapping" NavigateUrl="javascript:none()">
                    <asp:MenuItem Text="Add Trade Field Mapping" Value="Add Trade Field Mapping" NavigateUrl="~/Web/BusinessTradeAdd.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="View/ Modify Trade Field Mapping"  Value="View Modify Trade Field Mapping" NavigateUrl="~/Web/BusinessTradeView.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Delivery Address mapping" Value="Delivery Address mapping" NavigateUrl="~/Web/DeliveryAddress.aspx"> </asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Mapping" Value="Mapping" NavigateUrl="javascript:none()">
                    <asp:MenuItem Text="Free Gift Item Code Mapping" Value="Free Gift Item Code Mapping" NavigateUrl="~/Web/GiftCodeViewAction.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Accessory Item Code Mapping" Value="Accessory Item Code Mapping" NavigateUrl="~/Web/AccessoryViewAction.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Plan Code &amp; Plan Fee Mapping"  Value="Plan_Code_Plan_Fee_Mapping" NavigateUrl="~/Web/PlanRetentionViewAction.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="HS Program Group Mapping" Value="HS Program Group Mapping" NavigateUrl="~/Web/RebateGPViewImplement.aspx"> </asp:MenuItem>
                    <asp:MenuItem Text="Special Premium Mapping" Value="Special Premium Mapping"  NavigateUrl="~/Web/SpecialPremiumViewImplement.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Existing Customer Type" Value="Existing Customer Type" NavigateUrl="~/Web/TariffFeeViewImplement.aspx"> </asp:MenuItem>
                    <asp:MenuItem Text="Free Monthly Fee Mapping" Value="Free Monthly Fee Mapping" NavigateUrl="~/Web/FreeMonthViewImplement.aspx"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Report DownLoad" Value="Report_DownLoad" NavigateUrl="javascript:none()">
                    <asp:MenuItem Text="Download All Fallout Cases By CSA"  Value="Download_All_Fallout_Cases_By_CSA" NavigateUrl="~/Web/ReportAllFoCSA.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Download All Mapping Table" Value="Download_All_Mapping_Table" NavigateUrl="~/Web/TotalAllMappingReport.aspx"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Other" Value="Other" NavigateUrl="javascript:none()">
                    <asp:MenuItem Text="AO Case" Value="AO Case" NavigateUrl="~/Web/OrderRetentionAO.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="View Handset /Premium Count" Value="View Handset Premium Count" NavigateUrl="~/Web/HandSetCountView.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Release Restriction" Value="Release Restriction"  NavigateUrl="~/Web/ReleaseOrder.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Upload HS Mapping with excel" Value="Upload HS Mapping with excel"  NavigateUrl="~/Web/HandSetUpload.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Daily Gross issue" Value="Daily Gross issue"  NavigateUrl="~/Web/DailyCount.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Cancellation Rate" Value="Cancellation Rate"  NavigateUrl="~/Web/DeleteRate.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="ARPU In/Out" Value="ARPU In | Out" NavigateUrl="~/Web/ViewArpuModule.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Special Tracking" Value="Special Tracking" NavigateUrl="~/Web/K610iSpecial.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Counting Of Amendment Report" Value="Counting Of Amendment Report" NavigateUrl="~/Web/AmendReportView.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Add New Program ID" Value="Add New Program ID" NavigateUrl="~/Web/ProgramIDAdd.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Upload Redemption Letters List" Value="Upload Redemption Letters List" NavigateUrl="~/Web/UploadRedemptionLetter.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="VAS CONTROL" Value="VAS CONTROL" NavigateUrl="~/Web/VasControlMain.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Modifty Program ID" Value="Modifty Program ID" NavigateUrl="~/Web/ProgramProductView.aspx"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="User ID" Value="User ID" NavigateUrl="javascript:none()">
                    <asp:MenuItem Text="Logout" Value="Logout" NavigateUrl="~/Logout.aspx"></asp:MenuItem>
                </asp:MenuItem>
                </Items>
                    <StaticSelectedStyle BackColor="#1C5E55" />
                    <StaticMenuItemStyle HorizontalPadding="12px" VerticalPadding="12px" />
                    <DynamicHoverStyle BackColor="#666666" Font-Bold="False" ForeColor="White" />
                    <DynamicMenuStyle BackColor="#E3EAEB" />
                    <DynamicSelectedStyle BackColor="#1C5E55" />
                    <DynamicMenuItemStyle HorizontalPadding="12px" VerticalPadding="12px" />
                    <StaticHoverStyle BackColor="#666666" Font-Bold="False" ForeColor="White" />
                </asp:Menu>
            </td>
        </tr>
        </table>
    </td>
    </tr>
</table>