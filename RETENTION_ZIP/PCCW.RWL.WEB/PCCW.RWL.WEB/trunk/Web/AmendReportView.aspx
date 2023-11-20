<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AmendReportView.aspx.cs" Inherits="AmendReportView" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<head runat="server">
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<script type="text/javascript">

function chk_date2(dtobj,chkempty,gtToday){
	var today = new Date()
	if(dtobj.value != "" || chkempty==1) {
		if(dtobj.value.match(/^\d{8}$/)==null) {
		}
		else {
			txt=dtobj.value.substring(0,2)+"/"+dtobj.value.substring(2,4)+"/"+dtobj.value.substring(4,8)
			dtobj.value=txt
		}
		dt="";
	//	if(today.getMonth()+1<10)
	//		dt="0"

		dt+=today.getDate();
		dt+="/"
		dt+=today.getMonth()+1;
		dt+="/";
		dt+=today.getYear();

		//alert (dt);
		var datePat = /^(\d{1,2})(\/|-)(\d{1,2})\2(\d{2}|\d{4})$/;
		var matchArray = dtobj.value.match(datePat); // is the format ok?
		if (matchArray == null) {
			alert("Date is not in a valid format.")
			
			if (gtToday!=2)
				dtobj.value=dt;
			else
				dtobj.value="";
				
			return false;
		}
		month = matchArray[3]; // parse date into variables
		day = matchArray[1];
		year = matchArray[4];
		if (month < 1 || month > 12) { // check month range
			alert("Month must be between 1 and 12.");
			dtobj.value=dt;
			return false;
		}
		if (day < 1 || day > 31) {
			alert("Day must be between 1 and 31.");
			dtobj.value=dt;
			return false;
		}
		if ((month==4 || month==6 || month==9 || month==11) && day==31) {
			alert("Month "+month+" doesn't have 31 days!")
			dtobj.value=dt;
			return false
		}
		if (month == 2) { // check for february 29th
			var isleap = (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
			if (day>29 || (day==29 && !isleap)) {
				alert("February " + year + " doesn't have " + day + " days!");
				dtobj.value=dt;
				return false;
			}
		}
		var today = new Date()
		var myDate = new Date()

		myDate.setFullYear(year,month-1,day) 
		
		if (gtToday==1){
			if (myDate<today){
				alert ("Input Date should greater than Today!")
				dtobj.value=dt;
				return false;
			}
		}

		if (gtToday==2){
			if (myDate>=today){
				alert ("Input Date should smaller than Today!")
				dtobj.value="";
				return false;
			}
		}

		return true;
	}
}

function chk_save(ThisForm){
	if(document.getElementById('form1').format.value=="WEB")
		document.getElementById('form1').action="AmendReportViewImplement.aspx";
	else if(document.getElementById('form1').format.value=="EXCEL")
		//document.getElementById('form1').action="SearchRetentionOrderViewExport.aspx";
		document.getElementById('form1').action="AmendReportViewExport.aspx";
		

	ThisForm.submit()
}

</script>


</head>
<body>
    <form action="SearchRetentionOrderViewFinding.aspx" method="post" name="form1" id="form1" runat="server" >
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
     <asp:ScriptManager ID="AddWebLogScriptManager" runat="server"></asp:ScriptManager>
    <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <th height="28" colspan="4">&nbsp;<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span>(Counting Of Amendment Report)</th>
                </tr>
                <tr> 
                  <td height="23" colspan="4" class="row2"> <input type="button" name="submit2" value="SEARCH" class="mainoption"  onclick="chk_save(this.form);" onKeyDown="return false;" style="font-size:7pt"/> 
                    <span class="explaintitle"> </span><span class="gensmall"> 
                    </span></td>
                </tr>
                <tr> 
                  <td width="23%" height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Amendment Date</span></td>
                  <td width="77%" height="0" class="row1"> 
                  
                    <asp:TextBox ID="amend_date" Font-Size="7pt" ReadOnly="false" MaxLength="10" runat="server"></asp:TextBox>
                   <asp:ImageButton runat="server" ID="CalenderImageSDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                    (MM/DD/YYYY) TO 
                   
                    <asp:TextBox ID="amend_date2" Font-Size="7pt" ReadOnly="false" MaxLength="10"  runat="server"></asp:TextBox>
                    <asp:ImageButton runat="server" ID="CalenderImageEDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                    (MM/DD/YYYY)</td>
                </tr>
                <tr> 
                  <td width="23%" height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Channel</span></td>
                  <td width="77%" height="0" class="row1"><input type="radio" name="channel"   value="ALL" checked>ALL
				  																	 <input type="radio" name="channel"   value="OB">OB
				  																	 <input type="radio" name="channel"  value="IB">IB
																					 <input type="radio" name="channel"  value="IMS">IMS
				  </td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Format</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                    <select name="format" id="format" style="font-size:7pt" >
                      <option value="WEB">WEB</option>
                      <option value="EXCEL">EXCEL</option>
                    </select>
                    </span></td>
                </tr>
                <tr> 
                  <td class="cat" colspan="2">&nbsp;</td>
                </tr>
              </table>
<table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; View 
<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
</table>       
    
    <cc1:CalendarExtender runat="server" 
        ID="CalendarSDateFormat"
        TargetControlID="amend_date"
        Format="MM/dd/yyyy"
        PopupButtonID="CalenderImageSDate" /> 
              
        <cc1:CalendarExtender runat="server" 
        ID="CalendarEDateFormat"
        TargetControlID="amend_date2"
        Format="MM/dd/yyyy"
        PopupButtonID="CalenderImageEDate" />
    </div>
    </form>
</body>
</html>
