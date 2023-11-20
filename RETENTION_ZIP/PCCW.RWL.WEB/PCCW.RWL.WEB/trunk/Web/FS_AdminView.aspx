<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FS_AdminView.aspx.cs" Inherits="FS_AdminView" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<script type="text/javascript">

function chk_null(tobj){
	if(tobj.value=="")
		tobj.value = "";
}

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

function chk_save1(ThisForm){
    if ($('#format').val() == "EXCEL" && $('#order_status').val() != "FALLOUT REPLIED" && $('#report_type').val() == "") {
		alert ("Please Select ONE Report Name  or  Select FALLOUT REPLIED in Status!");
		event.returnValue=false;
		document.getElementById('form1').submit2.disabled=false;
	}

	if(document.getElementById('form1').format.value=="EXCEL"){
		if(document.getElementById('form1').order_status.value!="FALLOUT REPLIED" ){
			if(document.getElementById('form1').report_type.value=="rwl_w_hs")
				document.getElementById('form1').action="FS_AdminOrdViewExport.aspx";
			else if(document.getElementById('form1').report_type.value=="rwl_mod" || document.getElementById('form1').report_type.value=="rwl_del")
				document.getElementById('form1').action="FS_AdminModifyViewExport.aspx";
			else if(document.getElementById('form1').report_type.value=="rwl_mod_w_con")
			    document.getElementById('form1').action = "FS_AdminToPyViewExport.aspx";
			/*else if (document.getElementById('form1').report_type.value == "rwl_ml")
			{
			    if (document.getElementById('form1').order_status.value=="FALLOUT")
			    {
			        document.getElementById('form1').action = "AdminMobileLiteFalloutExport.aspx";
			    }
			    else
			    {
			        document.getElementById('form1').action = "AdminMobileLiteExport.aspx";
			    } 			        
			}
			else if (document.getElementById('form1').report_type.value == "rwl_ml_mod")
			    document.getElementById('form1').action = "AdminMobileLiteModifiedExport.aspx";
			else if (document.getElementById('form1').report_type.value == "rwl_ml_del")
			    document.getElementById('form1').action = "AdminMobileLiteCancelledExport.aspx";
			    */			    
			else
				document.getElementById('form1').action="FS_AdminViewExport.aspx";
		}
		else{
		    if (document.getElementById('form1').report_type.value == "rwl_cust") {
		        //document.getElementById('form1').action = "AdminForCustomerViewExport.aspx";
		    } else {
		        document.getElementById('form1').action = "FS_AdminForViewExport.aspx";
		    }
		}
	}
	else{


	    if (document.getElementById('form1').report_type.value == "rwl_mod_w_con")
	        document.getElementById('form1').action = "FS_AdminToPyViewImplement.aspx";
	    else if (document.getElementById('form1').report_type.value == "rwl_ml") {
	        /*if (document.getElementById('form1').order_status.value=="FALLOUT")
	        {
	        document.getElementById('form1').action = "AdminMobileLiteFalloutImplement.aspx";
	        }
	        else
	        {
	        document.getElementById('form1').action = "AdminMobileLiteViewImplement.aspx";
	        }*/
	    }
	    else if (document.getElementById('form1').report_type.value == "rwl_ml_mod") {
	        //document.getElementById('form1').action = "AdminMobileLiteModifiedImplement.aspx";
	    } else if (document.getElementById('form1').report_type.value == "rwl_ml_del") {
	        //document.getElementById('form1').action = "AdminMobileLiteCancelledImplement.aspx";
	    } else {
	        document.getElementById('form1').action = "FS_AdminViewProcess.aspx";
	    }
	}

	if(event.returnValue!=false)
		ThisForm.submit()
}

function chk_save2(ThisForm){
	if(document.getElementById('form1').report_type.value=="" &&  document.getElementById('form1').order_status.value!="FALLOUT REPLIED"){
		alert ("Please Select ONE Report Name!");
		event.returnValue=false;
		document.getElementById('form1').submit2.disabled=false;
	}

	if(document.getElementById('form1').report_type.value=="rwl_w_hs" )
		document.getElementById('form1').action="FS_RetrieveOrderViewAction.aspx";
	else if(document.getElementById('form1').report_type.value=="rwl_mod" || document.getElementById('form1').report_type.value=="rwl_del")
		document.getElementById('form1').action="FS_RetrieveModifyViewAction.aspx";
	else if(document.getElementById('form1').report_type.value=="rwl_mod_w_con")
		document.getElementById('form1').action="FS_RetrieveToPyViewAction.aspx";
	else
		document.getElementById('form1').action="FS_RetrieveViewAction.aspx";
		
	if(event.returnValue!=false)
		ThisForm.submit()
}

function chk_save3(ThisForm){
    if (document.getElementById('form1').report_type.value == "rwl_cust") {
        //document.getElementById('form1').action = "UpdateCustomerStatusViewImplement.aspx";
    } else if (document.getElementById('form1').report_type.value == "rwl_go_wireless") {
        //document.getElementById('form1').action = "GoWirelessUpdateStatusViewImplement.aspx";
    } else if (document.getElementById('form1').report_type.value == "rwl_ml" || document.getElementById('form1').report_type.value == "rwl_ml_mod" || document.getElementById('form1').report_type.value == "rwl_ml_del") {
        //document.getElementById('form1').action = "UpdateOrderStatusMobileLiteViewImplement.aspx";
    } else {
        document.getElementById('form1').action = "UpdateOrderStatusViewImplement.aspx";
    }

	if(event.returnValue!=false)
		ThisForm.submit()
}

function isNum(tobj){
	if(tobj.value!=""){
	a= Number(tobj.value);
	if (!(a) && tobj.value!="0"){
		alert ("Number Only!");
		tobj.value = "";
		}
	}
	else
		tobj.value = "";
}

</script>
</head>
<body style="background-color:#ffffff">
    <form id="form1" action="AdminViewProcess.aspx" method="post" name="newform" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
    <asp:ScriptManager ID="AddWebLogScriptManager" runat="server"></asp:ScriptManager>
              <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <th height="28" colspan="4">&nbsp;<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></th>
                </tr>
                <tr> 
                  <td height="23" colspan="4" class="row2"> <input type="button" name="submit2" value="SEARCH" class="mainoption"  onclick="chk_save1(this.form);" onKeyDown="return false;" style="font-size:7pt"/> 
                    <input type="button" name="submit23" value="RETRIEVE" class="button" onClick="chk_save2(this.form);" width="200" /> 
                    <input type="button" name="submit232" value="UPDATE STATUS" class="button" onClick="chk_save3(this.form);"  width="200"/>
                    <span class="explaintitle"> </span><span class="gensmall"> 
                    </span></td>
                </tr>
                <tr> 
                  <td width="23%" height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Record 
                    ID</span></td>
                  <td width="77%" height="0" class="row1"> <input name="<%=WebFunc.qsOrder_idName %>" type="text" id="order_id" style="font-size:7pt" size="10" maxlength="10" onBlur="isNum(this);"/>
                    TO 
                    <input name="order_id2" type="text" id="<%=WebFunc.qsOrder_id2Name %>" style="font-size:7pt" size="10" maxlength="10" onBlur="isNum(this);"/></td>
                </tr>
                <tr> 
                  <td width="23%" height="0" class="row2"><span class="explaintitle" style="font-size:7pt">EDF Number</span></td>
                  <td width="77%" height="0" class="row1"> <input name="<%=WebFunc.qsEdf_noName %>" type="text" id="edf_no" style="font-size:7pt" size="10" maxlength="10" /></td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Create 
                  Date /Modify Date</span></td>
                  <td height="0" class="row1">
                  <asp:TextBox ID="email_date" Font-Size="7pt" ReadOnly="false" MaxLength="10" runat="server" ></asp:TextBox>
                  <asp:ImageButton runat="server" ID="CalenderImageSDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                    (MM/DD/YYYY) TO 
                   <asp:TextBox ID="email_date2" Font-Size="7pt" ReadOnly="false" MaxLength="10" runat="server" ></asp:TextBox>
                    <asp:ImageButton runat="server" ID="CalenderImageEDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                    (MM/DD/YYYY)</td>
                </tr>
                
                <%/* <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">PY Retrieved Date</span></td>
                  <td height="0" class="row1">
                  <asp:TextBox ID="retrieve_date" Font-Size="7pt" ReadOnly="false" MaxLength="10" runat="server" ></asp:TextBox>
                  <asp:ImageButton runat="server" ID="retrieveDateImageButton" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                    (MM/DD/YYYY) For Search Only</td>
                </tr>*/%>
                <tr>
                    <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">
                        <asp:Label ID="Label1" runat="server" Text="Expected Delivery Date"></asp:Label></span></td>
                    <td height="0" class="row1">
                        <asp:TextBox ID="d_date" Font-Size="7pt" ReadOnly="false" MaxLength="10" runat="server" ></asp:TextBox>
                        <asp:ImageButton runat="server" ID="fromDeliveryDateImageButton" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                        (MM/DD/YYYY) TO                     
                        <asp:TextBox ID="d_date2" Font-Size="7pt" ReadOnly="false" MaxLength="10" runat="server" ></asp:TextBox>
                        <asp:ImageButton runat="server" ID="toDeliveryDateImageButton" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                        (MM/DD/YYYY)
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                                ErrorMessage="*" ControlToValidate="d_date" Display="Dynamic" Enabled="True" ValidationExpression="^[0-1]\d\/[0-3]\d\/[1,2]\d{3}" Text="*"></asp:RegularExpressionValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server"
                                ErrorMessage="RegularExpressionValidator" ControlToValidate="d_date2" Display="Dynamic" Enabled="True" ValidationExpression="^[0-1]\d\/[0-3]\d\/[1,2]\d{3}" Text="*"></asp:RegularExpressionValidator>
                    </td>
                    
                </tr>
                <tr>
                    <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">
                        <asp:Label ID="Label2" runat="server" Text="Rate Plan Effective Date"></asp:Label></span></td>
                    <td height="0" class="row1">
                        <asp:TextBox ID="plan_eff_date" Font-Size="7pt" ReadOnly="false" MaxLength="10" runat="server" ></asp:TextBox>
                        <asp:ImageButton runat="server" ID="fromRatePlanEffectiveDateImageButton" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                        (MM/DD/YYYY) TO                     
                        <asp:TextBox ID="plan_eff_date2" Font-Size="7pt" ReadOnly="false" MaxLength="10" runat="server" ></asp:TextBox>
                        <asp:ImageButton runat="server" ID="toRatePlanEffectiveDateImageButton" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                        (MM/DD/YYYY)
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server"
                                ErrorMessage="*" ControlToValidate="plan_eff_date" Display="Dynamic" Enabled="True" ValidationExpression="^[0-1]\d\/[0-3]\d\/[1,2]\d{3}" Text="*"></asp:RegularExpressionValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server"
                                ErrorMessage="RegularExpressionValidator" ControlToValidate="plan_eff_date2" Display="Dynamic" Enabled="True" ValidationExpression="^[0-1]\d\/[0-3]\d\/[1,2]\d{3}" Text="*"></asp:RegularExpressionValidator>
                    </td>
                    
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Bill Cut date</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                    <select name="<%=WebFunc.qsBill_cut_numName %>" id="bill_cut_num" style="font-size:7pt" >
                      <option value=""></option>
                      <option value="6">6</option>
                      <option value="9">9</option>
                      <option value="13">13</option>
                      <option value="16">16</option>
                      <option value="23">23</option>
					  </select>
                    </span></td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">MRT 
                    No </span></td>
                  <td width="77%" height="0" class="row1"> <input name="<%=WebFunc.qsMrt_noName %>" type="text" id="mrt_no" style="font-size:7pt" size="10" maxlength="8" onBlur="isNum(this);"/> 
                  </td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Report 
                    Name</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                    <select name="<%=WebFunc.qsReport_typeName %>" id="report_type" style="font-size:7pt" >
                      <option value="rwl_w_hs" selected>New HS Order (rwl_w_hs)</option>
                      <option value="rwl_del">Cancellation (rwl_del)</option>
                      <option value="rwl_mod">Modification (rwl_mod)</option>
                      <option value="rwl_mod_w_con">Modification With Contract(rwl_mod_w_con)</option>
					  </select>
                    </span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Status 
                    </span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  
                    <select name="<%=WebFunc.qsOrder_statusName %>" id="order_status" style="font-size:7pt" >
                      <option value="">All</option>
                      <option value="DONE">DONE</option>
                      <option value="FALLOUT REPLIED">FALLOUT REPLIED</option>
                    </select>
                    </span></td>
                </tr>
                <tr> 
                  <td width="23%" height="0" class="row2"><span class="explaintitle" style="font-size:7pt">HS Amount</span></td>
                  <td width="77%" height="0" class="row1"> > $ <input name="<%=WebFunc.qsAmountName %>" type="text" id="amount" style="font-size:7pt" size="10" maxlength="10" value="0"/></td>
                </tr>
                <tr>
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Format</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt">
                  
                    <select name="<%=WebFunc.qsFormatName %>" id="format" style="font-size:7pt" >
                      <option value="WEB">WEB</option>
                      <option value="EXCEL">EXCEL</option>
                    </select>
                    </span></td>
                </tr>
                <tr> 
                    <td  height="27" class="row2"><span class="explaintitle" style="font-size:7pt">&nbsp;</span></td>
                    <td  height="27" class="row1"><span class="explaintitle" style="font-size:7pt"> * Each order can only be retrieved by one party like mobile lite orders.</span></td>
                </tr>
                <tr> 
                  <td class="cat" colspan="2">&nbsp;</td>
                </tr>
              </table>
              
        <cc1:CalendarExtender runat="server" 
        ID="CalendarSDateFormat"
        TargetControlID="email_date"
        Format="MM/dd/yyyy"
        PopupButtonID="CalenderImageSDate" /> 
              
        <cc1:CalendarExtender runat="server" 
        ID="CalendarEDateFormat"
        TargetControlID="email_date2"
        Format="MM/dd/yyyy"
        PopupButtonID="CalenderImageEDate" />
        
        <cc1:CalendarExtender runat="server" 
        ID="deliveryDateCalendarExtender"
        TargetControlID="d_date"
        Format="MM/dd/yyyy"
        PopupButtonID="fromDeliveryDateImageButton" />
        
        <cc1:CalendarExtender runat="server" 
        ID="deliveryDateCalendarExtender2"
        TargetControlID="d_date2"
        Format="MM/dd/yyyy"
        PopupButtonID="toDeliveryDateImageButton" /> 
        
        <cc1:CalendarExtender runat="server" 
        ID="planEffDateCalendarExtender"
        TargetControlID="plan_eff_date"
        Format="MM/dd/yyyy"
        PopupButtonID="fromRatePlanEffectiveDateImageButton" />
        
        <cc1:CalendarExtender runat="server" 
        ID="planEffDateCalendarExtender2"
        TargetControlID="plan_eff_date2"
        Format="MM/dd/yyyy"
        PopupButtonID="toRatePlanEffectiveDateImageButton" /> 
        
        <%/* 
        <cc1:CalendarExtender runat="server" 
        ID="retrieveDateCalendarExtender"
        TargetControlID="retrieve_date"
        Format="MM/dd/yyyy"
        PopupButtonID="retrieveDateImageButton" /> 
        */%>
        
    </div>
    </form>
<table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; View 
<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
</table>
<script type="text/javascript" src="/js/dopageunload.js" language="JavaScript"></script>
</body>
</html>