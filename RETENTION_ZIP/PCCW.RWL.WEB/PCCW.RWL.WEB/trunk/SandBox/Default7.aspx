<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default7.aspx.cs" Inherits="SandBox_Default7" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
    
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    
<link rel="stylesheet"  href="../Resources/Styles/global.css" type="text/css" />
<link rel="stylesheet"  href="../Resources/Styles/rwlstyle.css" type="text/css" />
<asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <cc1:ToolkitScriptManager ID="AddWebLogScriptManager" runat="server" EnablePartialRendering="true" ScriptMode="Release" LoadScriptsBeforeUI="false" EnablePageMethods="true"></cc1:ToolkitScriptManager>
    
    <script language="javascript">

        
        
    </script>
    
    <user:MobileOrderAddressUserControl ID="RegisteredAddressControl" runat="server" TableTagVisable="true" DrpClass="disablerow" Enabled="true" TitleNameLbl="Delivery Address 送貨地址"
     TitleFontSize=8  TdOneClass="Ts1" TdTwoClass="Ts2" RblClass="highlightrow" ToolkitScriptManagerID="AddWebLogScriptManager" 
     LoadingImgSrc="../Web/images/loading.gif"
     DTypeClass="RegisterAddressDTypeClass" 
     DRegionClass="RegisterAddressDRegionClass" 
     DDistrictClass="RegisterAddressDDistrictClass" 
     DRoomClass="RegisterAddressDRoomClass" 
     DFloorClass="RegisterAddressDFloorClass" 
     DBlkClass="RegisterAddressDBlkClass" 
     DBuildClass="RegisterAddressDBuildClass" 
     DStreetClass="RegisterAddressDStreetClass" 
      />
      <table>
     <tr id="same_register_address_show" class="same_register_address_show">
				  <td height="0"  class ="Ts1"><span class="Fs1" style="font-size:8pt">Billing Address</span></td>
				  <td height="0"  class ="Ts2"><span class="Fs2" style="font-size:8pt">
				      Same as Registered Address? ( Yes<input id="same_register_address_0" name="same_register_address" onclick="CopyRegisterAddress('RegisteredAddressControl','BillingAddressControl')" type="radio" />
				      No<input id="same_register_address_1" name="same_register_address" checked="checked" type="radio" />
				      )
				  </span>
				  </td>
				</tr>
				</table>
     <user:MobileOrderAddressUserControl ID="BillingAddressControl" TableTagVisable="false" runat="server"  DrpClass="disablerow" Enabled="true" TitleNameLbl=""
     TitleFontSize="8"  TdOneClass="Ts1" TdTwoClass="Ts2" RblClass="highlightrow" ToolkitScriptManagerID="AddWebLogScriptManager" 
     LoadingImgSrc="../Web/images/loading.gif" 
     DTypeClass="BillingAddressDTypeClass" 
     DRegionClass="BillingAddressDRegionClass" 
     DDistrictClass="BillingAddressDDistrictClass" 
     DRoomClass="BillingAddressDRoomClass" 
     DFloorClass="BillingAddressDFloorClass" 
     DBlkClass="BillingAddressDBlkClass" 
     DBuildClass="BillingAddressDBuildClass" 
     DStreetClass="BillingAddressDStreetClass" 
     />
     
     <br />
     <user:MobileOrderThreePartyUserControl ID="MobileOrderThreePartyControl" TableTagVisable="true" runat="server"  DrpClass="disablerow" Enabled="true" TitleNameLbl=""
     TitleFontSize="8"  TdOneClass="Ts1" TdTwoClass="Ts2" RblClass="highlightrow" ToolkitScriptManagerID="AddWebLogScriptManager" />
     
     <user:MobileOrderMNPDetailUserControl ID="MobileOrderMNPDetailControl" TableTagVisable="false" runat="server"  DrpClass="disablerow" Enabled="true" TitleNameLbl=""
     TitleFontSize="8"  TdOneClass="Ts1" TdTwoClass="Ts2" RblClass="highlightrow" ToolkitScriptManagerID="AddWebLogScriptManager"/>
 
     <asp:UpdatePanel ID="update_panel_montly_payment_method" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                      <span  style="font-size:8pt" class="Fs2 monthly_payment_method_span"> 
				  	  <input type="radio" name="monthly_payment_method" id="monthly_payment_method_0" class="monthly_payment_method" value="keep_existing_payment_method"  checked onclick="" runat="server"/>Keep2G 
                        Existing Payment Method 
				  	  <input type="radio" name="monthly_payment_method" id="monthly_payment_method_1" class="monthly_payment_method" value= "change_payment_method" onclick="" runat="server"/>Change 
                        Payment Method
				  	  </span>
				  	  </ContentTemplate>
				  	  </asp:UpdatePanel>
				  	  <script>
				  	      function MonthPayMentMethodDefault(Val) {
				  	          if (Val == 'change_payment_method') {
				  	              document.getElementById('monthly_payment_method_1').checked = true;
				  	              MonthlyPayment('change_payment_method');
				  	          }
				  	          else {
				  	              document.getElementById('monthly_payment_method_0').checked = true;
				  	              MonthlyPayment('keep_existing_payment_method');
				  	          }
				  	      }
				  	  </script>
     
      <br />
      <input type="button" value="CopyRegisterAddress" onclick="CopyRegisterAddress('RegisterAddress','BillingAddress')" runat="server" />

    </div>
    </form>
</body>
</html>
