<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VasAddRelationMapping.aspx.cs" Inherits="VasAddRelationMapping" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<Html>
<head id="Head1" runat="server">
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>

<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>

<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../Resources/Scripts/calendarDateInput.js"></script>
<script type="text/javascript" src="../Resources/Scripts/creditcard.js"></script>
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<script type="text/javascript">
    function upload_vas() {
		document.getElementById("form1").action="VasRawDataBatchUpload.aspx";
		//alert(document.getElementById('form1').action="VasAddRelationMapping.aspx?sort_by="+sort_type+"&view=1&order_by=1")
		document.getElementById("form1").submit();
	}
	
function chk_date(dtobj,chkempty,gtToday){
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

</script>
</head>
<body>
	<form action="VasAddRelationMappingImplement.aspx" method="post" id="form1" runat="server" >
<div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
<asp:ScriptManager ID="AddWebLogScriptManager" runat="server"></asp:ScriptManager>
	  <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
	  <tr>
	 	<td valign="top">
	  <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
        <tr>
          <th height="28" colspan="4"><span class="explaintitle" style="font-size:8pt">VAS CONTROL</span></th>
        </tr>
        <tr>
          <td height="23" colspan="3" class="row2">
              <asp:Button ID="VasMainPage" runat="server" Text="Vas Main Page" CssClass="mainoption" PostBackUrl="~/Web/VasControlMain.aspx" />
          </td>
          <td class="row2">
          </td>
           <td class="row2"></td>
        </tr>
        <tr>
          <td height="23" colspan="3" class="row2">
          
          <asp:Button Text="ADD" CssClass="mainoption" runat="server" PostBackUrl="~/Web/VasAddRelationMappingImplement.aspx" />

            &nbsp;&nbsp;
            <input name="reset" type="reset" class="button" value="RESET" />
            &nbsp;&nbsp; </td>
          <td height="23" class="row2"><span class="gensmall">
            
            <input name="call_date" type="hidden" id="call_date" runat="server" size="10" maxlength="10" onBlur="chk_date(this,1);"/>
            <input name="call_time" type="hidden" id="call_time" runat="server" size="6" maxlength="5"/>
			
			<input type="button" name="upload_vas1" id="upload_vas1" value="Import From Execl" class="mainoption" onClick="upload_vas()" visible="false"/>
          </span></td>
           <td width="20%" class="row2"></td>
        </tr>
        <tr>
          <td width="20%" class="row1"><span class="explaintitle">Log 
            Date</span></td>
          <td width="20%" class="row2"><span class="gensmall">
          <asp:Literal ID="read_date" runat="server"></asp:Literal>
            <input name="log_date" type="hidden" id="log_date" runat="server" size="10" maxlength="10" readonly="" />
            (MM/DD/YYYY) </span> </td>
          <td width="20%" class="row1"><span class="explaintitle">Log 
            Time</span></td>
          <td width="20%" class="row2"><span class="gensmall">
            <asp:Literal ID="now_time" runat="server"></asp:Literal>
            <input name="log_time" type="hidden" id="log_time" runat="server" size="6" maxlength="5" readonly=""/>
            (HH:MM)</span></td>
            
            <td width="20%" class="row2"></td>
        </tr>
        <tr>
          <td class="row1" width="25%"><span class="explaintitle">Create By</span></td>
          <td width="25%" class="row2"><span class="gensmall">
            <input name="staff_uid" type="text" id="staff_uid"  value="" runat="server" size="30" maxlength="50" readonly="readonly" />
          </span></td>
		  <td class="row2"></td>
		  <td class="row2"></td>
		  <td class="row2"></td>
	    </tr>
		<tr>
			          <td width="20%" class="row1"><span class="explaintitle">Start Date:</span></td>
					  <td width="20%" class="row2">
                
                <asp:TextBox ID="sdate" Font-Size="7pt" ReadOnly="true" MaxLength="10" runat="server"></asp:TextBox>
                <asp:ImageButton runat="server" ID="CalenderImageSDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
            (MM/DD/YYYY)
                    </td>
          <td width="20%" class="row1"><span class="explaintitle">End Date:</span></td>
		  <td width="20%" class="row2">
 
                <asp:TextBox ID="edate" Font-Size="7pt" ReadOnly="true" MaxLength="10" Text="12/31/2099" runat="server"></asp:TextBox>
                <asp:ImageButton runat="server" ID="CalenderImageEDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                
                
            (MM/DD/YYYY)
                   </td>
                   <td width="20%" class="row2"></td>
		</tr>
		<tr>
			<td width="20%" class="row2"><span class="explaintitle">Program</span></td>
			<td width="20%" class="row2"><span class="explaintitle">Rate Plan</span></td>
			<td width="20%" class="row2"><span class="explaintitle">Bundle Name</span></td>
			<td width="20%" class="row2"><span class="explaintitle">Hs model</span></td>
			<td width="20%" class="row2"><span class="explaintitle">VAS</span></td>
			
		</tr>
		<tr>
          <td class="row2">
          
          <asp:DropDownList ID="program" runat="server" AppendDataBoundItems="true">
          
          </asp:DropDownList>

          </td>
          <td class="row2">
          <asp:DropDownList ID="rate_plan" runat="server" AppendDataBoundItems="true">
          
          </asp:DropDownList>
         
          </td>
          <td class="row2">
          <asp:DropDownList ID="bundle_name" runat="server" AppendDataBoundItems="true">
          </asp:DropDownList>
          
          </td>
          
          <td class="row2">
          <asp:DropDownList ID="hs_model" runat="server" AppendDataBoundItems="true">
          </asp:DropDownList>
          
          </td>
          
          <td class="row2">
          <asp:DropDownList ID="vas_field" runat="server" AppendDataBoundItems="true">
          
          </asp:DropDownList>
          </td>
        </tr>
      </table>
	  <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
		  <tr>
		      	<td width="10%" class="row1"><span class="explaintitle">Normal Rebate Type</span></td>
				<td width="90%" class="row2">

				<asp:DropDownList ID="normal_rebate_type" AppendDataBoundItems="true" runat="server" Font-Size="7pt" CssClass="explaintitle" >
    
                  </asp:DropDownList>
				
				
				</td>
		</tr>
      </table>
      <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
		  <tr>
		      	<td width="10%" class="row1"><span class="explaintitle">Issue Type</span></td>
				<td width="90%" class="row2">

				<asp:DropDownList ID="issue_type" DataTextField="Key" DataValueField="Value" AppendDataBoundItems="true" runat="server" Font-Size="7pt" CssClass="explaintitle" >
    
                  </asp:DropDownList>
				
				
				</td>
		</tr>
      </table>
		</td>
	</tr></table>
	
	<cc1:CalendarExtender runat="server" 
        ID="CalendarSDateFormat"
        TargetControlID="sdate"
        Format="MM/dd/yyyy"
        PopupButtonID="CalenderImageSDate" /> 
              
        <cc1:CalendarExtender runat="server" 
        ID="CalendarEDateFormat"
        TargetControlID="edate"
        Format="MM/dd/yyyy"
        PopupButtonID="CalenderImageEDate" />
	
	
	</form>
</body>
</html>