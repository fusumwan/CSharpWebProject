<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage/RWLMenu.master" CodeFile="MobileRetentionMain.aspx.cs" Inherits="MobileRetentionMain" %>

<asp:Content ContentPlaceHolderID="RWLHeaderContentPlace" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<meta http-equiv="Content-Style-Type" content="text/css" />
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />

<style type="text/css">
<!--
.row_red {background:#FFCC99}
.row_yellow {background:#FFFFbb}
-->
</style>

<asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>

<script type="text/javascript">
<!--
    function none() {
        event.returnValue = false;
    }

    function close_win() {
        //return window.location = "../board.aspx"
        return top.location="../../chk_login.asp"
    }
//-->
</script>
</asp:Content>
<asp:Content ContentPlaceHolderID="RWLContentPlace" runat="server">
    <a name="top" id="top"></a>
<table width="100%" cellspacing="10" >
<tr>
<td>

<table class="bodyline" width="100%" cellspacing="0" cellpadding="0" border="0">
<tr>
    <td height="572" valign="top" >
      <table width="100%" border="0" cellspacing="0" cellpadding="2">
        <tr>
          <td align="right"><a href="javascript:close_win();"><b>X</b></a></td>
        </tr>
      </table>

<table width="100%" border="0" cellspacing="0" cellpadding="10">
<tr>
<td>
              <table width="100%" cellspacing="2" cellpadding="3" border="0">
                <tr> 
                  <td colspan="2" class="maintitle"><span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
                </tr>
                <tr> 
                  <td class="nav">Main Page » &nbsp;</td>
                <td align="right" class="nav"> 
                  <a href="MessageViewAction.aspx" runat="server" id="MessageViewAction">
                    <img src="images/pc_25_01.gif" height="20" /></a>
                </td>
                </tr>
              </table>
              
            <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
              <tr> 
                <th width="33%"  style="background: url('../images/titlebg.jpg');"><asp:Image ID="order_record" runat="server" ImageUrl="images/order_record.jpg"/></th>
                <th width="34%">&nbsp;</th>
                <th width="34%" > 
                   <asp:Image ID="HandsetMapping" runat="server" ImageUrl="images/handset_mapping.jpg" />

                </th>
              </tr>
              <tr align="center"> 
                <td width="33%" class="row1"><span class="explaintitle"> 
                  
                  <a href="MobileRetentionOrderAddView.aspx" id="MobileRetentionOrderAddView" runat="server">
                    Add Web Log</a> 
                  
                  </span></td>
                <td width="34%" class="row1"><span class="explaintitle"> 
                  <a href="CustomerAccountSearch.aspx" runat="server" id="CustomerAccountSearch">
                    Change Customer Details</a> 
                  </span> </td>
                <td width="34%" class="row1"><span class="explaintitle"> 
                  <a href="HandSetMappingAdd.aspx" runat="server" id="HandSetMappingAdd">Add Handset Rebate Mapping</a>
                  </span> </td>
              </tr>
              <tr align="center">
                <td width="33%" height="21" class="row1"> <span class="explaintitle">
                    <a href="SearchRetentionOrderView.aspx">View/ Modify Web Log</a></span> </td>
                <td class="row1"><span class="explaintitle">
                  <a href="ChangeVasSearch.aspx" runat="server" id="ChangeVasSearch">Change VAS</a>
                  </span></td>
                <td class="row1"><span class="explaintitle">
                  <a href="HandSetView.aspx" runat="server" id="HandSetView">View/ Modify Handset Rebate Mapping</a>
                  </span></td>
              </tr>
              <tr align="center">
                <td width="33%" height="21" class="row1"><span class="explaintitle">
                    <a href="LetterView.aspx" runat="server" id="LetterView">Check Redemption Letter</a></span></td>
                <td class="row1"><span class="explaintitle">
                  <a href="~/Web/AccessRight/AccessPageManagement.aspx" runat="server" id="AccessPageManagement">Access Right Control Page</a> 
                  </span></td>
                <td class="row1"><span class="explaintitle"><a href="ItemCodeViewAction.aspx" runat="server" id="ItemCodeViewAction">
                    Handset Item Code Mapping</a></span></td>
              </tr>
              <tr align="center">
                <td width="33%" height="21" class="row1"><span class="explaintitle">
                  <a href="HandSetStockView.aspx" runat="server" id="HandSetStockView">Handset Stock</a> 
                  </span></td>
                <td class="row1">
                  <span class="explaintitle"><a href="AdminView.aspx" runat="server" id="AdminView">
                    View/Retrieve Order - PY Operations</a></span> 
                </td>
                <td class="row1"><span class="explaintitle"><a href="MobileOneManagement.aspx" runat="server" id="MobileOneManagement">
                    Mobile One Management</a></td>
              </tr>
              
              <tr align="center"> 
                <td width="33%" height="21" class="row1"><span class="explaintitle">
                    <a href="TierAutoSelectionExcelUpload.aspx" runat="server" id="TierAutoSelectionExcelUpload">Upload Tier</a> </span></td>
                <td class="row1">  <span class="explaintitle"><a href="IncompleteDeliveryDateReport.aspx" runat="server" id="IncompleteDeliveryDateReport">Incomplete Delivery Order</a></span></td>
                <td class="row1"></td>
              </tr>
              <tr align="center"> 
              <td width="33%" height="21" class="row1">
              <span class="explaintitle"><a href="ChangeStaffNoCurrentAccessRight.aspx" runat="server" id="ChangeStaffNoCurrentAccessRight">Change Session Staff Access Level</a> </span></td>
                <td class="row1"><span class="explaintitle"><a href="AssignMobileIMEI.aspx" runat="server" id="AssignMobileIMEI">Assign Mobile IMEI By Manual</a></span></td>
                <td class="row1"></td>
              </tr>
              <tr align="center">
              <td width="33%" height="21" class="row1">
              <span class="explaintitle"><a href="~/Web/IMEIManagement/ManagementIMEI.aspx" runat="server" id="ManagementIMEI">Mangement IMEI</a> </span>
              </td>
                <td class="row1"><span class="explaintitle">

                </span></td>
                <td class="row1"></td>
              </tr>
              <tr align="center">
                <td width="33%" height="21" class="row1">
                    <span class="explaintitle">
                  <a href="BasicBackEndManagement.aspx" runat="server" id="BasicBackEndManagement">Basic Back End Management</a>
                   </span>
                </td>
                <td class="row1">
                  <span class="explaintitle"><a href="FS_AdminView.aspx" runat="server" id="FS_AdminView">
                    View/Retrieve order - F&S colleagues</a></span> 
                </td>
                <td class="row1"><span class="explaintitle">&nbsp;</td>
              </tr>
              

              <tr align="center"> 
                <th width="33%"><asp:Image ID="Image1" runat="server" ImageUrl="images/fallout_case.jpg"/></th>
                <th width="34%">&nbsp;</th>
                <th width="34%"> 
                <asp:Image ID="TradeFieldMapping" runat="server" ImageUrl="images/trade_field_mapping.jpg" />

                </th>
              </tr>
              <tr align="center"> 
                <td width="33%" class="row1"><span class="explaintitle"><a href="FoManagement.aspx" 
                        runat="server" id="FoManagement">3G &amp; CPE Fallout Case</a></span></td>
                <td width="34%" class="row1"><span class="explaintitle"><a href="OrderRetentionAO.aspx" 
                        runat="server" id="OrderRetentionAO">AO Case</a></span></td>
                <td width="34%" class="row1"> 
                  <span class="explaintitle"><a href="BusinessTradeAdd.aspx" runat="server" id="BusinessTradeAdd">Add Trade Field Mapping</a></span> 
                </td>
              </tr>
              <tr align="center"> 
                <td width="33%" class="row1"><span class="explaintitle">
                    <a href="SalesFollowCSA.aspx" runat="server" id="SalesFollowCSA">Fallout By PY Operations</a> </span></td>
                <td class="row1"> 
                  
                  <span class="explaintitle"><a href="HandSetCountView.aspx" runat="server" 
                        id="HandSetCountView">View Handset /Premium Count</a></span> 
                  
                </td>
                <td width="34%" class="row1" ><span class="explaintitle"> 
                  <a href="BusinessTradeView.aspx" runat="server" id="BusinessTradeView">View / Modify Trade Field Mapping</a> 
                  </span> </td>
              </tr>
              <tr align="center"> 
                <td width="33%" height="21" class="row1"><span class="explaintitle">
                    <a href="FallOutDeltailCase.aspx" runat="server" id="FallOutDeltailCase">
                    Delivery Fallout Case </a> </span></td>
                <td class="row1"><span class="explaintitle"> 
                  
                  <span class="explaintitle"><a href="ReleaseOrder.aspx" runat="server" 
                        id="ReleaseOrder">Release Restriction</a></span> 
                  
                  </span></td>
                <td width="34%" class="row1"><span class="explaintitle">
                    <a href="DeliveryAddress.aspx" id="DeliveryAddress" runat="server">Delivery 
                    Address mapping</a></span></td>
              </tr>
			  <tr>
				<td width="33%" height="21" class="row1" align="center"><span class="explaintitle">

				</span></td>
				
				<td width="34%" height="21" class="row1" align="center"><span class="explaintitle">
				<a href="HandSetUpload.aspx" runat="server" id="HandSetUpload" runat="server">Upload HS Mapping with excel</a>
				</span></td>
				<td width="33%" height="21" class="row1"></td>
			  </tr>
              <tr> 
                <th width="33%">&nbsp;</th>
                <th width="34%">&nbsp;</th>
                <th width="34%"><asp:Image ID="Mapping" runat="server" ImageUrl="images/mapping.jpg" /></th>
              </tr>
              <tr align="center"> 
                <td width="33%" class="row1"><span class="explaintitle">
                    <a href="DailyCount.aspx" runat="server" id="DailyCount">Daily Gross issue</a>
				  <br/>
				  <a href="DailyCountNew.aspx" runat="server" id="DailyCountNew">
                    Daily Gross issue new</a>
				  </span></td>
                <td width="34%" class="row1"><span class="explaintitle">
                    <a href="UploadRedemptionLetter.aspx" runat="server" id="UploadRedemptionLetter">
                    Upload Redemption Letters List</a> </span></td>
                <td width="34%" class="row1"><span class="explaintitle">
                    <a href="GiftCodeViewAction.aspx" runat="server" id="GiftCodeViewAction">Free 
                    Gift Item Code Mapping</a> </span></td>
              </tr>
              <tr align="center"> 
                <td class="row1"><span class="explaintitle"><a href="DeleteRate.aspx" 
                        runat="server" id="DeleteRate">Cancellation Rate</a> </span></td>
                <td class="row1">&nbsp;</td>
                <td class="row1"><span class="explaintitle"><a href="AccessoryViewAction.aspx" 
                        runat="server" id="AccessoryViewAction">Accessory Item Code Mapping</a></span> </td>
              </tr>
              <tr align="center"> 
                <td width="33%" height="21" class="row1"><span class="explaintitle">
                    <a href="ViewArpuModule.aspx" runat="server" id="ViewArpuModule">ARPU In/Out</a> </span></td>
                <td class="row1"><span class="explaintitle"><a href="ReportAllFoCSA.aspx" 
                        runat="server" id="ReportAllFoCSA">Download All Fallout Cases by CSA</a> </span></td>
                <td class="row1"><span class="explaintitle"><a href="PlanRetentionViewAction.aspx" 
                        runat="server" id="PlanRetentionViewAction">Plan Code &amp; Plan Fee Mapping</a> </span></td>
              </tr>
              <tr align="center"> 
                <td width="33%" height="21" class="row1"><span class="explaintitle">
                    <a href="K610iSpecial.aspx" runat="server" id="K610iSpecial">Special Tracking</a> </span></td>
                <td class="row1"><span class="explaintitle"><a href="TotalAllMappingReport.aspx" runat="server" id="TotalAllMappingReport">
                    Download All Mapping Table</a></span></td>
                <td class="row1"><span class="explaintitle"><a href="RebateGPViewImplement.aspx"  
                        runat="server" id="RebateGPViewImplement">HS Program Group Mapping</a></span> </td>
              </tr>
              <tr align="center"> 
                <td width="33%" height="21" class="row1">
				<span class="explaintitle"><a href="AmendReportView.aspx" runat="server" 
                        id="AmendReportView">Counting Of Amendment Report</a> </span>
				</td>
				
                <td class="row1">
                <span class="explaintitle">

                </span>
                </td>
                <td width="34%" class="row1"><span class="explaintitle">
                    <a href="SpecialPremiumViewImplement.aspx" runat="server" id="SpecialPremiumViewImplement">
                    Special Premium Mapping</a></span> <span class="explaintitle"> </span></td>
              </tr>
              <tr align="center"> 
                <td width="33%" height="21" class="row1">
                <input type="button" class="mainoption" value="Rights" onClick="javascript:window.open('ar_rights.aspx')" id="ar_rights" runat="server"></td>
                <td class="row1"><span class="explaintitle"><a href="VasControlMain.aspx" 
                        id="VasControlMain" runat="server">VAS CONTROL</a></span></td>
                <td width="34%" class="row1"><span class="explaintitle">
                    <a href="TariffFeeViewImplement.aspx" runat="server" id="TariffFeeViewImplement">
                    Existing Customer Type &amp;<br />
                    Original Tariff Fee Mapping</a> </span></td>
              </tr>
              <tr align="center"> 
                <td width="33%" height="21" class="row1">
                </td>
                <td class="row1"><span class="explaintitle"></span></td>
                <td width="34%" class="row1"><span class="explaintitle">
                    <a href="FreeMonthViewImplement.aspx" runat="server" id="FreeMonthViewImplement">Free Monthly Fee Mapping</a> </span></td>
              </tr>
              <tr align="center"> 
                <td width="33%" height="21" class="row1"><span class="explaintitle">
                    <a href="ProgramIDAdd.aspx" runat="server" id="ProgramIDAdd">Add New Program ID</a></span></td>
                <td width="33%" height="21" class="row1"><span class="explaintitle">
                <a href="ProgramProductView.aspx" runat="server" id="ProgramProductView">Modify Program ID</a></span></td>
                <td width="33%" height="21" class="row1"><span class="explaintitle">
                <a href="BankCodeMapping.aspx" runat="server" id="BankCodeMapping">Bank Code Mapping</a></span></td>
              </tr>

              <tr> 
                <td class="cat" colspan="3"><span class="explaintitle">&nbsp; </span></td>
              </tr>
            </table>
	            </td></tr></table></td>
<table width="100%" border="0" cellspacing="2" cellpadding="2">
  <tr>
    <td width="20%"><div align="center"></div></td>
    <td width="60%"><div align="center"></div></td>
    <td width="20%"><div align="center"></div></td>
  </tr>
  <tr>
    <td width="20%"><div align="center"></div></td>
    <td width="60%"><div align="center"></div></td>
    <td width="20%"><div align="center"></div></td>
  </tr>
</table>
</tr></table>
</td>
</tr>
</table>
</asp:Content>





    

