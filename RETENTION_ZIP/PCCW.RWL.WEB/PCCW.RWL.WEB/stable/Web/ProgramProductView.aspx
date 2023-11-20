<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProgramProductView.aspx.cs" Inherits="ProgramProductView" %>
<%@ Register TagPrefix="RWLMenu" TagName="RWLMenu" Src="~/UI/RWLControlMenu.ascx" %> 
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<meta http-equiv="Content-Style-Type" content="text/css" />
<title>Quota System</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>

<script type="text/javascript">

function chk_focus(){
//	document.getElementById('form1').serv_no.focus();
}



</script>

</head>
<body onload="chk_focus()">
    <form id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
    <asp:ScriptManager ID="AddWebLogScriptManager" runat="server"></asp:ScriptManager>
<a name="top" id="top"></a>
<table class="bodyline" width="100%" cellspacing="0" cellpadding="0" border="0">
<tr>
<td valign="top">
      <table width="100%" border="0" cellspacing="0" cellpadding="2">
        <tr>
          <td align="right" class="topnav">&nbsp;<a href="javascript:close_win();"></a>&nbsp;</td>
</tr>
</table>
<table width="100%" border="0" cellspacing="0" cellpadding="10">
<tr>
<td>

              <table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
		          <td class="maintitle">Program ID</td>
</tr>
<tr>
                  <td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; 
                    View Log Record </td>
</tr>
</table>              
              <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <th height="28" colspan="3">Product Record</th>
                </tr>
                <tr> 
                  <td height="23" colspan="2" class="row2"> 
                    
                    <asp:Button ID="submitout" runat="server" Text="SEARCH" CssClass="mainoption" PostBackUrl="~/Web/ProgramProductViewImplement.aspx" />
                   
                    <input name="submit22" type="button" class="button" value="RESET" onclick="location.href=location.href;" />
                    &nbsp;&nbsp; </td>
                  <td height="23" class="row2" width="25%">&nbsp;</td>
                </tr>
                <tr> 
                  <td class="row1"><span class="explaintitle">Program ID</span></td>
                  <td colspan="2" class="row2"> <input type="text" name="program_id" id="program_id" size="5" maxlength="4" />
                  </td>
                </tr>
                <tr> 
                  <td class="row1"><span class="explaintitle">Create Date</span></td>
                  <td colspan="2" class="row2"> <span class="gensmall"> </span><span class="gensmall"> 
                   <asp:TextBox ID="cdate" Font-Size="7pt" ReadOnly="true" MaxLength="10" runat="server"></asp:TextBox>
                   <asp:ImageButton runat="server" ID="CalenderImageSDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                    
                    TO 
                    <asp:TextBox ID="cdate2" Font-Size="7pt" ReadOnly="true" MaxLength="10"  runat="server"></asp:TextBox>
                    <asp:ImageButton runat="server" ID="CalenderImageEDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                    (MM/DD/YYYY) </span></td>
                </tr>
                <tr> 
                  <td class="cat" colspan="3">&nbsp;</td>
                </tr>
              </table>
              <table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
                  <td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; 
                    View Log Record </td>
</tr>
</table>


            <div align="center" class="gensmall">&nbsp;</div>
<a name="bot" id="bot"></a></td></tr></table></td>
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
<cc1:CalendarExtender runat="server" 
        ID="CalendarSDateFormat"
        TargetControlID="cdate"
        Format="MM/dd/yyyy"
        PopupButtonID="CalenderImageSDate" /> 
              
        <cc1:CalendarExtender runat="server" 
        ID="CalendarEDateFormat"
        TargetControlID="cdate2"
        Format="MM/dd/yyyy"
        PopupButtonID="CalenderImageEDate" />
    </div>
    </form>
</body>
</html>
