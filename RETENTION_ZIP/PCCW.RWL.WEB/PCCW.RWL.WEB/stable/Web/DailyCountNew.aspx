<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DailyCountNew.aspx.cs" Inherits="DailyCountNew" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
<script type="text/javascript">

function ChkLogDate(){
	var now_date=((new Date().getMonth())+1)+"/"+(new Date().getDate())+"/"+(new Date().getYear())
		if (document.form1.chk_logdate.checked==true){
		document.form1.chk_logdate_bymonth.checked=false
		document.form1.log_date_month.disabled=true
		document.form1.log_date2_month.disabled=true
		document.form1.log_date_month.value=""
		document.form1.log_date2_month.value=""
		document.form1.log_date.value=now_date
		document.form1.log_date2.value=now_date
		document.form1.log_date_month.style.background="#DDDDDD"
		document.form1.log_date2_month.style.background="#DDDDDD"
		document.form1.log_date.disabled=false
		document.form1.log_date2.disabled=false
		document.form1.log_date.style.background="#FFFFFF"
		document.form1.log_date2.style.background="#FFFFFF"
		}
}

function ChkLogDate2(){
		var now_date=((new Date().getMonth())+1)+"/"+(new Date().getYear())
		if (document.form1.chk_logdate_bymonth.checked==true){
		document.form1.chk_logdate.checked=false
		document.form1.log_date_month.disabled=false
		document.form1.log_date2_month.disabled=false
		document.form1.log_date.disabled=true
		document.form1.log_date2.disabled=true
		document.form1.log_date.value=""
		document.form1.log_date2.value=""
		document.form1.log_date_month.value=now_date
		document.form1.log_date2_month.value=now_date
		document.form1.log_date.style.background="#DDDDDD"
		document.form1.log_date2.style.background="#DDDDDD"
		document.form1.log_date_month.style.background="#FFFFFF"
		document.form1.log_date2_month.style.background="#FFFFFF"
		}
}

function chk_save(ThisForm){
	if(document.getElementById('form1').format.value=="WEB")
		document.getElementById('form1').action="DailyCountAction_new.aspx";
	else if(document.getElementById('form1').format.value=="EXCEL")
		document.getElementById('form1').action="DailyCountExport_new.aspx";

	ThisForm.submit()
}

</script>

</head>
<body>
    <form id="form1" action="DailyCountNew.aspx" method="post" name="newform" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
        <asp:ScriptManager ID="AddWebLogScriptManager" runat="server"></asp:ScriptManager>
              <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <th height="28" colspan="4">Daily Gross issue new</th>
                </tr>
                <tr> 
                  <td height="23" colspan="4" class="row2"> <input type="button" name="submit2" value="SEARCH" class="mainoption"  onclick="chk_save(this.form);" onKeyDown="return false;" style="font-size:7pt"/> 
                    <span class="explaintitle"> </span><span class="gensmall"> 
                    </span></td>
                </tr>
                <tr> 
                  <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">Log 
                    Date(By Date)</span></td>
                  <td width="77%" height="25" class="row1"> 
                  
                  <asp:CheckBox ID = "chk_logdate" runat="server" Checked="true" onclick="ChkLogDate();" />
                  
                  <asp:TextBox ID="log_date" Font-Size="7pt" ReadOnly="false" MaxLength="10" runat="server"></asp:TextBox>
                   <asp:ImageButton runat="server" ID="CalenderImageSDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                   
                   (MM/DD/YYYY) TO 
                   <asp:TextBox ID="log_date2" Font-Size="7pt" ReadOnly="false" MaxLength="10"  runat="server"></asp:TextBox>
                    <asp:ImageButton runat="server" ID="CalenderImageEDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                    
                    (MM/DD/YYYY)</td>
                </tr>
                <tr> 
                  <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">Log 
                    Date (By Month)</span></td>
                  <td width="77%" height="25" class="row1"> 
                  
                  <asp:CheckBox ID = "chk_logdate_bymonth" runat="server" onclick="ChkLogDate2();" />
                  
                  <asp:TextBox ID="log_date_month" Font-Size="7pt" ReadOnly="false" MaxLength="7" runat="server" Enabled="false"></asp:TextBox>               
                   (MM/YYYY) TO 
                   <asp:TextBox ID="log_date2_month" Font-Size="7pt" ReadOnly="false" MaxLength="7"  runat="server" Enabled="false"></asp:TextBox>                  
                    (MM/YYYY)</td>
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
</body>
</html>
