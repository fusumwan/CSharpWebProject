﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VasAssignValue.aspx.cs" Inherits="Web_VasAssignValue" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>3G Retention - Web Log</title>
    <link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
    <link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
    <style type="text/css">
        .style1
        {
            width: 400px;
            background: #d9e2ec;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
               <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <th height="28" colspan="4">&nbsp;Create Vas</th>
                </tr>
                <tr>
          <td height="23" colspan="3" class="row2">
              <asp:Button ID="VasMainPage" runat="server" Text="Vas Main Page" CssClass="mainoption" PostBackUrl="~/Web/VasControlMain.aspx" />
          </td>
          <td class="row2">
          </td>
        </tr>
                <tr> 
                
                  <td height="23" colspan="4" class="row2">
                  
                  <asp:Button ID="add_vas_value" CssClass="mainoption" Text="ADD NEW VAS VALUE" runat="server"  ValidationGroup="vas_group" 
                          Font-Size="7pt" onclick="add_vas_value_Click" />

                    &nbsp;&nbsp; &nbsp;&nbsp; <span class="explaintitle"> </span><span class="gensmall"> 
                    </span></td>
                </tr>
                
                <tr> 
                  <td height="27"  class="style1"><span class="explaintitle" style="font-size:7pt">Vas ID Name</span></td>
                  <td height="27" class="row1"><asp:DropDownList ID="vas_field" 
                          AppendDataBoundItems="true" runat="server" AutoPostBack="true" 
                          onselectedindexchanged="vas_field_SelectedIndexChanged"></asp:DropDownList></td>
                </tr>
                
                <tr> 
                  <td height="27"  class="style1"><span class="explaintitle" style="font-size:7pt">Vas Name </span></td>
                  <td height="27" class="row1"><asp:Label ID="vas_name" runat="server" BackColor="#FFFFbb" ReadOnly="true"></asp:Label></td>
                </tr>
                
                <tr>
                  <td height="27"  class="style1"><span class="explaintitle" style="font-size:7pt">Vas Chinese Name </span></td>
                  <td height="27" class="row1"><asp:Label ID="vas_chi_name"  BackColor="#FFFFbb" runat="server" ReadOnly="true"></asp:Label></td>
                </tr>
                
                <tr> 
                  <td height="27"  class="style1"><span class="explaintitle" style="font-size:7pt">Assign Vas Value </span></td>
                  <td height="27" class="row1">
                  <asp:TextBox ID="vas_value" runat="server"  ValidationGroup="vas_group" ></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredVasValue" ControlToValidate="vas_value" ValidationGroup="vas_group" runat="server" ErrorMessage="Required Vas Value"></asp:RequiredFieldValidator>
                  </td>
                </tr>

                <tr> 
                  <td height="27"  class="style1"><span class="explaintitle" style="font-size:7pt">Multi</span></td>
                  <td height="27" class="row1"><asp:CheckBox ID="multi" runat="server" ReadOnly="true" Enabled="false"></asp:CheckBox></td>
                </tr>
                
                <tr> 
                  <td class="cat" colspan="2">&nbsp; </td>
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
