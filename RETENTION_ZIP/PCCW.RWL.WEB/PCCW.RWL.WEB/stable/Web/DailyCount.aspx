<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DailyCount.aspx.cs" Inherits="DailyCount" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
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
<script type="text/javascript">

function chk_save(ThisForm){
	if(document.getElementById('form1').format.value=="WEB")
		document.getElementById('form1').action="DailyCountAction.aspx";
	else if(document.getElementById('form1').format.value=="EXCEL")
		document.getElementById('form1').action="DailyCountExport.aspx";

	ThisForm.submit()
}

</script>
</head>
<body style="background-color:#ffffff">

    <form id="form1" action="DailyCountAction.aspx" method="post" name="newform" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
    <asp:ScriptManager ID="AddWebLogScriptManager" runat="server"></asp:ScriptManager>
              <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <th height="28" colspan="4">Daily Gross issue</th>
                </tr>
                <tr> 
                  <td height="23" colspan="4" class="row2"> <input type="button" name="submit2" value="SEARCH" class="mainoption"  onclick="chk_save(this.form);" onKeyDown="return false;" style="font-size:7pt"/> 
                    <span class="explaintitle"> </span><span class="gensmall"> 
                    </span></td>
                </tr>
                <tr> 
                  <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">Log 
                    Date</span></td>
                  <td width="77%" height="25" class="row1"> 
                  
                  <asp:TextBox ID="log_date" Font-Size="7pt" ReadOnly="false" MaxLength="10" runat="server"></asp:TextBox>
                   <asp:ImageButton runat="server" ID="CalenderImageSDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                   
                   (MM/DD/YYYY) TO 
                   <asp:TextBox ID="log_date2" Font-Size="7pt" ReadOnly="false" MaxLength="10"  runat="server"></asp:TextBox>
                    <asp:ImageButton runat="server" ID="CalenderImageEDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                    
                    (MM/DD/YYYY)</td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Format</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:DropDownList ID="format" Font-Size="7pt" AppendDataBoundItems="true" runat="server">
                  </asp:DropDownList>
                    </span></td>
                </tr>
                <tr> 
                  <td class="cat" colspan="2">&nbsp;</td>
                </tr>
              </table>
              <cc1:CalendarExtender runat="server" 
        ID="CalendarSDateFormat"
        TargetControlID="log_date"
        Format="MM/dd/yyyy"
        PopupButtonID="CalenderImageSDate" /> 
              
        <cc1:CalendarExtender runat="server" 
        ID="CalendarEDateFormat"
        TargetControlID="log_date2"
        Format="MM/dd/yyyy"
        PopupButtonID="CalenderImageEDate" />
    </div>
    </form>
<table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; View 
<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
</table>         
</td></tr></table></td>
</tr></table>
</body>
</html>
