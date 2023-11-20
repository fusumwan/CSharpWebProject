<%@ Control Language="C#" AutoEventWireup="true" CodeFile="GlobalNavigation2.ascx.cs" Inherits="UI_GlobalNavigation2" %>
<table id="LoadingTbl" cellpadding="0" cellspacing="0" runat="server" style="padding:0px 0px 0px 0px; margin:0px 0px 0px 0px; height:0px;">
<tr>
<td style="height:0px;">
    <div id="pccw_logo">
    <div id="global-navigation" >
        <ul class="toplevel">
            <li class="toplevel">
                <asp:HyperLink ID="MainWebLink" runat="server" NavigateUrl="~/Web/MobileRetentionMain.aspx" CssClass="toplevel">HOME</asp:HyperLink><br />
                <ul class="sublevel vertical">
                    <li>
                        <asp:HyperLink ID="Home" runat="server" NavigateUrl="~/Web/MobileRetentionMain.aspx">Home</asp:HyperLink>
                    </li>
                </ul>
            </li>
            
            <li id="Order_RecordLI" class="toplevel" runat="server">
                <asp:HyperLink ID="Order_Record" runat="server" CssClass="toplevel">Order Record</asp:HyperLink><br />
                <ul class="sublevel vertical">
                    <li id="Add_Web_LogLI" runat="server">
                        <asp:HyperLink ID="Add_Web_Log" runat="server" NavigateUrl="~/Web/MobileRetentionOrderAddView.aspx">Add Web Log</asp:HyperLink>
                    </li>

                    <li id="View_Modify_Web_LogLI" runat="server">
                        <asp:HyperLink ID="View_Modify_Web_Log" runat="server" NavigateUrl="~/Web/SearchRetentionOrderView.aspx">View / Modify Web Log</asp:HyperLink>
                    </li>
                    <li id="Check_Redemption_LetterLI" runat="server">
                        <asp:HyperLink ID="Check_Redemption_Letter" runat="server" NavigateUrl="~/Web/LetterView.aspx">Check Redemption Letter</asp:HyperLink>
                    </li>
                    <li id="Handset_StockLI" runat="server">
                        <asp:HyperLink ID="Handset_Stock" runat="server" NavigateUrl="~/Web/HandSetStockView.aspx">Handset Stock</asp:HyperLink>
                    </li>
                    <li id="Upload_TierLI" runat="server">
                        <asp:HyperLink ID="Upload_Tier" runat="server" NavigateUrl="~/Web/TierAutoSelectionExcelUpload.aspx">Upload Tier</asp:HyperLink>
                    </li>
                    <li id="Change_Customer_DetailsLI" runat="server">
                        <asp:HyperLink ID="Change_Customer_Details" runat="server" NavigateUrl="~/Web/CustomerAccountSearch.aspx">Change Customer Details</asp:HyperLink>
                    </li>
                    <li id="Change_VASLI" runat="server">
                        <asp:HyperLink ID="Change_VAS" runat="server" NavigateUrl="~/Web/ChangeVasSearch.aspx">Change VAS</asp:HyperLink>
                    </li>
                    <li id="View_Retrieve_Order_PY_OperationsLI" runat="server">
                        <asp:HyperLink ID="View_Retrieve_Order_PY_Operations" runat="server" NavigateUrl="~/Web/AdminView.aspx">View/Retrieve Order - PY Operations</asp:HyperLink>
                    </li>
                    <li id="Incomplete_Delivery_OrderLI" runat="server">
                        <asp:HyperLink ID="Incomplete_Delivery_Order" runat="server" NavigateUrl="~/Web/IncompleteDeliveryDateReport.aspx">Incomplete Delivery Order</asp:HyperLink>
                    </li>
                    <li id="Access_Right_ControlLI" runat="server">
                        <asp:HyperLink ID="Access_Right_Control" runat="server" NavigateUrl="~/Web/AccessRight/AccessPageManagement.aspx">Access Right Control</asp:HyperLink>
                    </li>
                    <li id="AssignMobileIMEILI" runat="server">
                        <asp:HyperLink ID="AssignMobileIMEI" runat="server" NavigateUrl="~/Web/AssignMobileIMEI.aspx">Assign Mobile IMEI By Manual</asp:HyperLink>
                    </li>
                    <li id="ManagementIMEILI" runat="server">
                        <asp:HyperLink ID="ManagementIMEI" runat="server" NavigateUrl="~/Web/IMEIManagement/ManagementIMEI.aspx">Management IMEI</asp:HyperLink>
                    </li>
                    <li id="BasicBackEndManagementLI" runat="server">
                        <asp:HyperLink ID="BasicBackEndManagement" runat="server" NavigateUrl="~/Web/BasicBackEndManagement.aspx">Basic Back End Management</asp:HyperLink>
                    </li>


                </ul>
            </li>


            <li id="Handset_MappingLI" class="toplevel" runat="server">
                <asp:HyperLink ID="Handset_Mapping" runat="server" CssClass="toplevel">Handset Mapping</asp:HyperLink><br />
                <ul class="sublevel vertical">
                    <li id="Add_Handset_Rebate_MappingLI" runat="server">
                        <asp:HyperLink ID="Add_Handset_Rebate_Mapping" runat="server" NavigateUrl="~/Web/HandSetMappingAdd.aspx">Add Handset Rebate Mapping</asp:HyperLink>
                    </li>
                    <li id="View_Modify_Handset_Rebate_MappingLI" runat="server">
                        <asp:HyperLink ID="View_Modify_Handset_Rebate_Mapping" runat="server" NavigateUrl="~/Web/HandSetView.aspx">View / Modify Handset Rebate Mapping</asp:HyperLink>
                    </li>
                    <li id="Handset_Item_Code_MappingLI" runat="server">
                        <asp:HyperLink ID="Handset_Item_Code_Mapping" runat="server" NavigateUrl="~/Web/ItemCodeViewAction.aspx">Handset Item Code Mapping</asp:HyperLink>
                    </li>
                    <li id="MobileOneManagementLI" runat="server">
                        <asp:HyperLink ID="MobileOneManagement" runat="server" NavigateUrl="~/Web/MobileOneManagement.aspx">Mobile One Management</asp:HyperLink>
                    </li>
                </ul>
            </li>



            <li id="Fallout_CaseLI" class="toplevel" runat="server">
                <asp:HyperLink ID="Fallout_Case" runat="server" CssClass="toplevel">Fallout Case</asp:HyperLink><br />
                <ul class="sublevel vertical">
                    <li id="THREEG_CPE_Fallout_CaseLI" runat="server">
                        <asp:HyperLink ID="THREEG_CPE_Fallout_Case" runat="server" NavigateUrl="~/Web/FoManagement.aspx">3G &amp; CPE Fallout Case</asp:HyperLink>
                    </li>
                    <li id="Fallout_By_PY_OperationsLI" runat="server">
                        <asp:HyperLink ID="Fallout_By_PY_Operations" runat="server" NavigateUrl="~/Web/SalesFollowCSA.aspx">Fallout By PY Operations</asp:HyperLink>
                    </li>
                    <li id="Delivery_Fallout_CaseLI" runat="server">
                        <asp:HyperLink ID="Delivery_Fallout_Case" runat="server" NavigateUrl="~/Web/FallOutDeltailCase.aspx">Delivery Fallout Case</asp:HyperLink>
                    </li>
                </ul>
            </li>

            <li id="Trade_Field_MappingLI" class="toplevel" runat="server">
                <asp:HyperLink ID="Trade_Field_Mapping" runat="server" CssClass="toplevel">Trade Field Mapping</asp:HyperLink><br />
                <ul class="sublevel vertical">
                    <li id="Add_Trade_Field_MappingLI" runat="server">
                        <asp:HyperLink ID="Add_Trade_Field_Mapping" runat="server" NavigateUrl="~/Web/BusinessTradeAdd.aspx">Add Trade Field Mapping</asp:HyperLink>
                    </li>
                    <li id="View_Modify_Trade_Field_MappingLI" runat="server">
                        <asp:HyperLink ID="View_Modify_Trade_Field_Mapping" runat="server" NavigateUrl="~/Web/BusinessTradeView.aspx">View Modify Trade Field Mapping</asp:HyperLink>
                    </li>
                    <li id="Delivery_Address_MappingLI" runat="server">
                        <asp:HyperLink ID="Delivery_Address_Mapping" runat="server" NavigateUrl="~/Web/DeliveryAddress.aspx">Delivery Address Mapping</asp:HyperLink>
                    </li>
                </ul>
            </li>


            
            <li id="MappingLI" class="toplevel" runat="server">
                <asp:HyperLink ID="Mapping" runat="server" CssClass="toplevel">Mapping</asp:HyperLink><br />
                <ul class="sublevel vertical">
                    <li id="Free_Gift_Item_Code_MappingLI" runat="server">
                        <asp:HyperLink ID="Free_Gift_Item_Code_Mapping" runat="server" NavigateUrl="~/Web/GiftCodeViewAction.aspx">Free Gift Item Code Mapping</asp:HyperLink>
                    </li>
                    <li id="Accessory_Item_Code_MappingLI" runat="server">
                        <asp:HyperLink ID="Accessory_Item_Code_Mapping" runat="server" NavigateUrl="~/Web/AccessoryViewAction.aspx">Accessory Item Code Mapping</asp:HyperLink>
                    </li>
                    <li id="Plan_Code_Plan_Fee_MappingLI" runat="server">
                        <asp:HyperLink ID="Plan_Code_Plan_Fee_Mapping" runat="server" NavigateUrl="~/Web/PlanRetentionViewAction.aspx">Plan Code &amp; Plan Fee Mapping</asp:HyperLink>
                    </li>
                    <li id="HS_Program_Group_MappingLI" runat="server">
                        <asp:HyperLink ID="HS_Program_Group_Mapping" runat="server" NavigateUrl="~/Web/RebateGPViewImplement.aspx">HS Program Group Mapping</asp:HyperLink>
                    </li>
                    <li id="Special_Premium_MappingLI" runat="server">
                        <asp:HyperLink ID="Special_Premium_Mapping" runat="server" NavigateUrl="~/Web/SpecialPremiumViewImplement.aspx">Special Premium Mapping</asp:HyperLink>
                    </li>
                    <li id="Existing_Customer_TypeLI" runat="server">
                        <asp:HyperLink ID="Existing_Customer_Type" runat="server" NavigateUrl="~/Web/TariffFeeViewImplement.aspx">Existing Customer Type</asp:HyperLink>
                    </li>
                    <li id="Free_Monthly_Fee_MappingLI" runat="server">
                        <asp:HyperLink ID="Free_Monthly_Fee_Mapping" runat="server" NavigateUrl="~/Web/FreeMonthViewImplement.aspx">Free Monthly Fee Mapping</asp:HyperLink>
                    </li>
                    <li id="Bank_Code_MappingLI" runat="server">
                        <asp:HyperLink ID="Bank_Code_Mapping" runat="server" NavigateUrl="~/Web/BankCodeMapping.aspx">Bank Code Mapping</asp:HyperLink>
                    </li>
                </ul>
            </li>

            <li id="Report_DownLoadLI" class="toplevel" runat="server">
                <asp:HyperLink ID="Report_DownLoad" runat="server" CssClass="toplevel">Report DownLoad</asp:HyperLink><br />
                <ul class="sublevel vertical">
                    <li id="Download_All_Fallout_Cases_By_CSALI" runat="server">
                        <asp:HyperLink ID="Download_All_Fallout_Cases_By_CSA" runat="server" NavigateUrl="~/Web/ReportAllFoCSA.aspx">Download All Fallout Cases By CSA</asp:HyperLink>
                    </li>
                    <li id="Download_All_Mapping_TableLI" runat="server">
                        <asp:HyperLink ID="Download_All_Mapping_Table" runat="server" NavigateUrl="~/Web/TotalAllMappingReport.aspx">Download All Mapping Table</asp:HyperLink>
                    </li>
                </ul>
            </li>


            
            <li id="OtherLI" class="toplevel" runat="server">
                <asp:HyperLink ID="Other" runat="server" CssClass="toplevel">Other</asp:HyperLink><br />
                <ul class="sublevel vertical">
                    <li id="AO_CaseLI" runat="server">
                        <asp:HyperLink ID="AO_Case" runat="server" NavigateUrl="~/Web/OrderRetentionAO.aspx">AO Case</asp:HyperLink>
                    </li>
                    <li id="View_Handset_Premium_CountLI" runat="server">
                        <asp:HyperLink ID="View_Handset_Premium_Count" runat="server" NavigateUrl="~/Web/HandSetCountView.aspx">View Handset /Premium Count</asp:HyperLink>
                    </li>
                    <li id="Release_RestrictionLI" runat="server">
                        <asp:HyperLink ID="Release_Restriction" runat="server" NavigateUrl="~/Web/ReleaseOrder.aspx">Release Restriction</asp:HyperLink>
                    </li>
                    <li id="Upload_HS_Mapping_With_ExcelLI" runat="server">
                        <asp:HyperLink ID="Upload_HS_Mapping_With_Excel" runat="server" NavigateUrl="~/Web/HandSetUpload.aspx">Upload HS Mapping With Excel</asp:HyperLink>
                    </li>
                    <li id="Daily_Gross_IssueLI" runat="server">
                        <asp:HyperLink ID="Daily_Gross_Issue" runat="server" NavigateUrl="~/Web/DailyCount.aspx">Daily Gross Issue</asp:HyperLink>
                    </li>
                    <li id="Cancellation_RateLI" runat="server">
                        <asp:HyperLink ID="Cancellation_Rate" runat="server" NavigateUrl="~/Web/DeleteRate.aspx">Cancellation Rate</asp:HyperLink>
                    </li>
                    <li id="ARPU_In_OutLI" runat="server">
                        <asp:HyperLink ID="ARPU_In_Out" runat="server" NavigateUrl="~/Web/ViewArpuModule.aspx">ARPU In/Out</asp:HyperLink>
                    </li>
                    <li id="Special_TrackingLI" runat="server">
                        <asp:HyperLink ID="Special_Tracking" runat="server" NavigateUrl="~/Web/K610iSpecial.aspx">Special Tracking</asp:HyperLink>
                    </li>
                    <li id="Counting_Of_Amendment_ReportLI" runat="server">
                        <asp:HyperLink ID="Counting_Of_Amendment_Report" runat="server" NavigateUrl="~/Web/AmendReportView.aspx">Counting Of Amendment Report</asp:HyperLink>
                    </li>
                    <li id="Add_New_Program_IDLI" runat="server">
                        <asp:HyperLink ID="Add_New_Program_ID" runat="server" NavigateUrl="~/Web/ProgramIDAdd.aspx">Add New Program ID</asp:HyperLink>
                    </li>
                    <li id="Upload_Redemption_Letters_ListLI" runat="server">
                        <asp:HyperLink ID="Upload_Redemption_Letters_List" runat="server" NavigateUrl="~/Web/UploadRedemptionLetter.aspx">Upload Redemption Letters List</asp:HyperLink>
                    </li>
                    <li id="VAS_CONTROLLI" runat="server">
                        <asp:HyperLink ID="VAS_CONTROL" runat="server" NavigateUrl="~/Web/VasControlMain.aspx">VAS CONTROL</asp:HyperLink>
                    </li>
                    <li id="Modifty_Program_IDLI" runat="server">
                        <asp:HyperLink ID="Modifty_Program_ID" runat="server" NavigateUrl="~/Web/ProgramProductView.aspx">Modifty Program ID</asp:HyperLink>
                    </li>
                    <li id="SimAOCaseLI" runat="server">
                        <asp:HyperLink ID="SimAOCase" runat="server" NavigateUrl="~/Web/SimAOCase.aspx">Sim AO Case</asp:HyperLink>
                    </li>
                </ul>
            </li>

            <li id="global-navigation-account" class="toplevel"><a href="#" class="toplevel">
                <asp:Literal ID="StaffNumber" runat="server"></asp:Literal></a><br />
                <ul class="sublevel vertical">
                    <li id="LogoutLI" runat="server">
                        <asp:HyperLink ID="Logout" runat="server" NavigateUrl="~/Logout.aspx">Logout</asp:HyperLink>
                    </li>
                </ul>
            </li>

         </ul>
        <span class="stopfloating"></span>
        <asp:Literal ID="BlockShiftKey" runat="server"></asp:Literal>
    </div>
    </div>
</td>
</tr>

<tr>
<td style="position:relative">
<div id="global-loading" style="display:none">Loading...</div>
</td>
</tr>
</table>