<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdateOrderStatusImplement.aspx.cs" Inherits="UpdateOrderStatusImplement" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>

</head>
<body style="background-color:#ffffff">
    <form id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
    <table class="bodyline" width="100%" cellspacing="0" cellpadding="0" border="0">
<tr>
<td valign="top">
      <table width="100%" border="0" cellspacing="0" cellpadding="2">
        <tr>
          <td align="right" class="topnav">&nbsp;<a href="javascript:close_win();"><b>X</b></a>&nbsp;</td>
</tr>
</table>
<table width="100%" border="0" cellspacing="0" cellpadding="10">
<tr>
<td>
              <table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
	              
                <td class="maintitle"><span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
<tr>
                  
                <td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; &nbsp;Retrieve 
                  Order - CS Admin<br />
 				  
                  </td>
</tr>
</table>              

              <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <th height="28" colspan="4">&nbsp;<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></th>
                </tr>
              <tr> 
                  <td width="75%" height="235" class="row2" align="center"> <span class="gensmall"> 
                    Status Updated!</span><br />
                  <asp:Button ID="submit22" CssClass="button" Text="BACK" PostBackUrl="~/Web/AdminView.aspx" Font-Size="7pt" runat="server" />
                   </td>
              </tr>
                <tr> 
                  <td class="cat" >&nbsp;</td>
                </tr>
              </table>


<table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; View 
<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
</table>       
</td></tr></table></td>
</tr></table>
    </div>
    </form>
</body>
</html>
