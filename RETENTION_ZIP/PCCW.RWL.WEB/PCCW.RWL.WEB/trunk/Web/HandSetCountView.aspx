<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HandSetCountView.aspx.cs" Inherits="HandSetCountView" %>

<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    

<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
<script type="text/javascript">

function chk_save(ThisForm){

	if(document.getElementById("form1").format.options[document.getElementById("form1").format.selectedIndex].value==""){
		alert ("Please Select Format!");
		document.getElementById("form1").format.focus();
		event.returnValue=false;
		document.getElementById("form1").submit2.disabled=false;
	}

	if(document.getElementById("form1").format.value=="WEB")
		document.getElementById("form1").action="HandSetCountViewAction.aspx";
	else if(document.getElementById("form1").format.value=="EXCEL")
		document.getElementById("form1").action="HandSetCountViewExport.aspx";

	if(event.returnValue!=false)
		ThisForm.submit()
}
</script>
<asp:Literal ID="load_channel_script" runat="server"></asp:Literal>
</head>
<body onLoad="load_channel()">
    <form id="form1" action="HandSetCountViewAction.aspx" method="post" name="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
    <asp:ScriptManager ID="AddWebLogScriptManager" runat="server"></asp:ScriptManager>
    
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
    
              <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <th height="28" colspan="4">&nbsp;<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></th>
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
                    
                    
                    <asp:TextBox ID="log_date2" Font-Size="7pt" ReadOnly="false" MaxLength="10" runat="server"></asp:TextBox>
                <asp:ImageButton runat="server" ID="CalenderImageEDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                    (MM/DD/YYYY)</td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Handset</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:ListBox ID="hs_model" Font-Size="7pt" SelectionMode="Multiple" runat="server">
                  </asp:ListBox>
                  
                    </span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Premium</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:ListBox ID="premium" Font-Size="7pt" runat="server"></asp:ListBox>                    
                    </span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Salesmancode</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <%--<asp:ListBox ID="salesman_code" Font-Size="7pt" runat="server" SelectionMode=Multiple></asp:ListBox>--%>
                  <asp:ListBox ID="salesman_code" Font-Size="7pt" runat="server"></asp:ListBox>
                    </span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Channel</span></td>
                  <td height="27" colspan="3" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:RadioButtonList ID="channel" runat="server" RepeatDirection="Horizontal">
                  <asp:ListItem Text="All" Selected=True></asp:ListItem>
                  <asp:ListItem Text="IB" ></asp:ListItem>
                  <asp:ListItem Text="OB" ></asp:ListItem>
                  <asp:ListItem Text="IMS" ></asp:ListItem>
                  <asp:ListItem Text="Others" ></asp:ListItem>
                  </asp:RadioButtonList>

				</span></td>
                </tr>
                 <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Format</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                    <select name="format" id="format" style="font-size:7pt" >
                      <option value=""></option>
                      <option value="WEB">WEB</option>
                      <option value="EXCEL">EXCEL</option>
                    </select>
                    </span></td>
                </tr>
               <tr> 
                  <td class="cat" colspan="2">&nbsp;</td>
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
