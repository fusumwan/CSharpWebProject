<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MobileOneManagement.aspx.cs" Inherits="Web_MobileOneManagement" %>

<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet"  href="../Resources/Styles/global.css" type="text/css" />
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />

<asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<script language="javascript">
    var chk_mobile = function() {
        var objC = $("[id$='txt_mobile_number']");
        if (objC.val().length != 0) {
            if (objC.val().match(/^\d{8}$/) == null) {
                alert("Invalid Contact Number!");
                objC.select();
                return false;
            }
            else if (objC.val().substring(0, 1) != "5" && objC.val().substring(0, 1) != "6" && objC.val().substring(0, 1) != "7" && objC.val().substring(0, 1) != "8" && objC.val().substring(0, 1) != "9") {
                alert("Invalid Contact Number! Please begins with 5/6/7/8/9!");
                objC.select();
                return false;
            }
            return true;
        }
        else
            return false;
    }
    $(document).ready(function() {
        $("[id$='txt_mobile_number']").blur(chk_mobile);
    });
</script>
<asp:Literal ID="NeuronJSLibrary" runat="server"></asp:Literal>

</head>
<body style="background-color:#ffffff">
  <form method="post" name="form1" id="form1" runat="server" >
  <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>  
            <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
              <tr> 
                <th width="100%" height="28" colspan="30">&nbsp;<%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></th>
              </tr>
              <tr>
              <td class="row1" colspan="10"><span class="explaintitle"><asp:Button ID="But_Back" Text="BACK" runat="server" PostBackUrl="~/Web/MobileRetentionMain.aspx" CssClass=button /></span></td>
              </tr>
               <tr> 
                <td width="3%" class="row1">&nbsp;</td>
                <td width="32%" class="row1"><span class="explaintitle">Mobile Number</span></td>
                <td width="32%" class="row1"><span class="explaintitle">HK ID</span></td>
                <td width="32%" class="row1"><span class="explaintitle">Mobile One Type</span></td>

              </tr>
                <tr> 
                  <td width="3%" nowrap="nowrap" class="row2"></td>
                  <td width="8%" nowrap="nowrap" class="row2" >
                  <asp:TextBox ID="txt_mobile_number" runat="server"  Text='' MaxLength="60" Font-Size="7pt" Width="300"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="txt_mobile_number_requiredfield" ControlToValidate="txt_mobile_number" ValidationGroup="addmobileone"  CssClass="explaintitle"  ErrorMessage="Please Enter Mobile Number" runat="server"></asp:RequiredFieldValidator>
                  </td>
                  <td width="8%" nowrap="nowrap" class="row2">
                  <asp:TextBox ID="txt_hk_id" runat="server" Text='' MaxLength="60" Width="300" Font-Size="7pt"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="txt_hk_id_requiredfield" ControlToValidate="txt_hk_id" ValidationGroup="addmobileone"  CssClass="explaintitle"  ErrorMessage="Please Enter HK ID" runat="server"></asp:RequiredFieldValidator>
                  </td>
                  <td width="8%" nowrap="nowrap" class="row2">
                  <asp:DropDownList ID="drp_mobile_type" runat="server" >
                  <asp:ListItem Text="MobileOne Premier" Value="MobileOneT1"></asp:ListItem>
                  <asp:ListItem Text="MobileOneT2" Value="MobileOneT2"></asp:ListItem>
                  <asp:ListItem Text="MobileOneT3" Value="MobileOneT3"></asp:ListItem>
                  </asp:DropDownList>
                  </td>
              </tr>
              <tr>
              <td class="row2">
              </td>
              <td colspan="4" class="row2">
              <asp:Button ID="But_Add" runat="server" Text="ADD" CssClass="button" ValidationGroup="addmobileone" onclick="But_Add_Click" />
              </td>
              </tr>
              
              <tr>
              <td class="row2">
              </td>
              <td colspan="4" class="row2">
              
              </td>
              </tr>
              <tr>
              <td class="row2">
              </td>
              <td colspan="4" class="row2">
              <asp:TextBox ID="txt_search_mrt" runat="server"  ValidationGroup="searchmobileone"  ></asp:TextBox>
                  <asp:RequiredFieldValidator ID="txt_search_mrt_requiredfield" 
                      ControlToValidate="txt_search_mrt" ValidationGroup="searchmobileone"  
                      CssClass="explaintitle"  ErrorMessage="Please Enter Mobile Number" 
                      runat="server"></asp:RequiredFieldValidator>
              </td>
              </tr>
              <tr>
              <td class="row2">
              </td>
              <td colspan="4" class="row2">
              <asp:Button ID="But_Search" runat="server" Text="SEARCH" CssClass="button" ValidationGroup="searchmobileone" onclick="But_Search_Click" />
              </td>
              </tr>
              <tr>
              <td class="row2">
              </td>
              <td colspan="4" class="row2">
                <table width="100%" border="0" cellpadding="3" cellspacing="1" runat="server" class="forumline" id="search_result" bgcolor="white">
                    <tr>
                        <td  class="row1">MRT</td>
                        <td  class="row1">HKID</td>
                        <td  class="row1">MobileOne Type</td>
                        <td  class="row1">Created Date</td>
                    </tr>
                    <tr>
                        <td class="row2"><span class="gensmall"><asp:Literal ID="result_mrt" runat="server"></asp:Literal></span></td>
                        <td class="row2"><span class="gensmall"><asp:Literal ID="result_hkid" runat="server"></asp:Literal></span></td>
                        <td class="row2"><span class="gensmall"><asp:Literal ID="result_type" runat="server"></asp:Literal></span></td>
                        <td class="row2"><span class="gensmall"><asp:Literal ID="result_cdate" runat="server"></asp:Literal></span></td>
                    </tr>
                    <tr>
                        <td class="row2" colspan="4">
                            <asp:HiddenField ID="result_id" runat="server" />
                            <asp:HiddenField ID="result_cmpgn_id" runat="server" />
                            <asp:HiddenField ID="result_campaign_name" runat="server" />
                            <asp:HiddenField ID="result_ct_type" runat="server" />
                            <asp:HiddenField ID="result_active" runat="server" />
                            <asp:Button ID="But_Disable" runat="server" Text="DISABLE" CssClass="button" onclick="But_Disable_Click" Visible="false"/>
                            <asp:Button ID="But_Enable" runat="server" Text="ENABLE" CssClass="button" onclick="But_Enable_Click" Visible="false"/>
                            <asp:Button ID="But_Delete" runat="server" Text="DELETE" CssClass="button" onclick="But_Delete_Click" Visible="false"/>
                        </td>
                    </tr>
                </table>
              </td>
              </tr>
              <tr> 
                <td class="cat" colspan="4">&nbsp;</td>
              </tr>
              
            </table>
            </div>
            </form>
<table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; View 
<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
</table>            
</body>
</html>
