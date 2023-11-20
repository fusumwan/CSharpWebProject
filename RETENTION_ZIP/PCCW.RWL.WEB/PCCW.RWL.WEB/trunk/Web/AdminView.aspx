<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminView.aspx.cs" Inherits="AdminView" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
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
<script type="text/javascript" src="../Resources/Scripts/fallout_items.js" language="javascript"></script>
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
				alert("Input Date should greater than Today!")
				dtobj.value=dt;
				return false;
			}
		}

		if (gtToday==2){
			if (myDate>=today){
				alert("Input Date should smaller than Today!")
				dtobj.value="";
				return false;
			}
		}
		return true;
	}
}

function chk_save1(ThisForm){
	if(document.getElementById('form1').format.value=="EXCEL" && document.getElementById('form1').order_status.value!="FALLOUT REPLIED" && document.getElementById('form1').report_type.value=="" ){
		alert("Please Select ONE Report Name  or  Select FALLOUT REPLIED in Status!");
		event.returnValue=false;
		document.getElementById('form1').submit2.disabled=false;
	}

	if(document.getElementById('form1').format.value=="EXCEL"){
		if(document.getElementById('form1').order_status.value!="FALLOUT REPLIED" ){
			if(document.getElementById('form1').report_type.value=="rwl_w_hs" || document.getElementById('form1').report_type.value=="rwl_wo_hs" || document.getElementById('form1').report_type.value=="rwl_fast" )
				document.getElementById('form1').action="AdminOrdViewExport.aspx";
            else if (document.getElementById('form1').report_type.value == "rwl_mod" || document.getElementById('form1').report_type.value == "rwl_2g_mod" || document.getElementById('form1').report_type.value == "rwl_del" || document.getElementById('form1').report_type.value == "rwl_2g_cxl")
				document.getElementById('form1').action="AdminModifyViewExport.aspx";
			else if(document.getElementById('form1').report_type.value=="rwl_suspend")
				document.getElementById('form1').action="AdminSuViewExport.aspx";
			else if(document.getElementById('form1').report_type.value=="rwl_cust")
				document.getElementById('form1').action="AdminCustomerViewExport.aspx";
			else if(document.getElementById('form1').report_type.value=="rwl_opt_out")
				document.getElementById('form1').action="AdminOptOutViewExport.aspx";
else if (document.getElementById('form1').report_type.value == "rwl_mod_w_con" || document.getElementById('form1').report_type.value == "rwl_2g_mod_w_con")
			    document.getElementById('form1').action = "AdminToPyViewExport.aspx";
			else if (document.getElementById('form1').report_type.value == "rwl_ml")
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
			else
				document.getElementById('form1').action="AdminViewExport.aspx";
		}
		else{
			if(document.getElementById('form1').report_type.value=="rwl_cust")
				document.getElementById('form1').action="AdminForCustomerViewExport.aspx";		    		    
			else
				document.getElementById('form1').action="AdminForViewExport.aspx";
		}
	}
	else{
		if(document.getElementById('form1').report_type.value=="rwl_cust")
			document.getElementById('form1').action="AdminCustomerViewAction.aspx";
		else if(document.getElementById('form1').report_type.value=="rwl_go_wireless")
			document.getElementById('form1').action="RetrieveGoWirelessAction.aspx";        else if (document.getElementById('form1').report_type.value == "rwl_mod_w_con" || document.getElementById('form1').report_type.value == "rwl_2g_mod_w_con")
			document.getElementById('form1').action="AdminToPyViewImplement.aspx";
		else if(document.getElementById('form1').report_type.value=="rwl_opt_out")
			document.getElementById('form1').action="AdminOptOutViewImplement.aspx";
		else if (document.getElementById('form1').report_type.value == "rwl_ml")
		{
		    if (document.getElementById('form1').order_status.value=="FALLOUT")
			{
			    document.getElementById('form1').action = "AdminMobileLiteFalloutImplement.aspx";
			}
			else
			{
			    document.getElementById('form1').action = "AdminMobileLiteViewImplement.aspx";
			}
        }
		else if (document.getElementById('form1').report_type.value == "rwl_ml_mod")
		    document.getElementById('form1').action = "AdminMobileLiteModifiedImplement.aspx";
		else if (document.getElementById('form1').report_type.value == "rwl_ml_del")
		    document.getElementById('form1').action = "AdminMobileLiteCancelledImplement.aspx";
		else
			document.getElementById('form1').action="AdminViewProcess.aspx";
	}

	if(event.returnValue!=false)
		ThisForm.submit()
}

function chk_save2(ThisForm){
	if(document.getElementById('form1').report_type.value=="" &&  document.getElementById('form1').order_status.value!="FALLOUT REPLIED"){
		alert("Please Select ONE Report Name!");
		event.returnValue=false;
		document.getElementById('form1').submit2.disabled=false;
	}
/*	else if(document.getElementById('form1').order_status.value!="no_retrieve" ){
		alert("Please Select NOT YET RETRIEVED in Status!");
		event.returnValue=false;
		document.getElementById('form1').submit2.disabled=false;
	}*/

	if(document.getElementById('form1').report_type.value=="rwl_w_hs" || document.getElementById('form1').report_type.value=="rwl_wo_hs" || document.getElementById('form1').report_type.value=="rwl_fast" )
		document.getElementById('form1').action="RetrieveOrderViewAction.aspx";
    else if (document.getElementById('form1').report_type.value == "rwl_mod" || document.getElementById('form1').report_type.value == "rwl_del" || document.getElementById('form1').report_type.value == "rwl_2g_cxl" || document.getElementById('form1').report_type.value == "rwl_2g_mod")
		document.getElementById('form1').action="RetrieveModifyViewAction.aspx";
	else if(document.getElementById('form1').report_type.value=="rwl_suspend")
		document.getElementById('form1').action="RetrieveSuViewAction.aspx";
	else if(document.getElementById('form1').report_type.value=="rwl_cust")
		document.getElementById('form1').action="RetrieveCustomerViewAction.aspx";
else if (document.getElementById('form1').report_type.value == "rwl_mod_w_con" || document.getElementById('form1').report_type.value == "rwl_2g_mod_w_con")
		document.getElementById('form1').action="RetrieveToPyViewAction.aspx";
	else if(document.getElementById('form1').report_type.value=="rwl_go_wireless")
	    document.getElementById('form1').action = "RetrieveGoWirelessAction.aspx";
	else if (document.getElementById('form1').report_type.value == "rwl_ml") 
	{
	    if (document.getElementById('form1').order_status.value == "FALLOUT") 
	    {
	        document.getElementById('form1').action = "RetrieveMobileLiteFalloutAction.aspx";
	    }
	    else 
	    {
	        document.getElementById('form1').action = "RetrieveMobileLiteAction.aspx";
	    }
	}
	else if (document.getElementById('form1').report_type.value == "rwl_ml_mod")
	    document.getElementById('form1').action = "RetrieveMobileLiteModifiedAction.aspx";
	else if (document.getElementById('form1').report_type.value == "rwl_ml_del")
	    document.getElementById('form1').action = "RetrieveMobileLiteCancelledAction.aspx";
	else
		document.getElementById('form1').action="RetrieveViewAction.aspx";
		
	if(event.returnValue!=false)
		ThisForm.submit()
}

function chk_save3(ThisForm){
	if(document.getElementById('form1').report_type.value=="rwl_cust")
		document.getElementById('form1').action="UpdateCustomerStatusViewImplement.aspx";
	else if(document.getElementById('form1').report_type.value=="rwl_go_wireless")
		document.getElementById('form1').action="GoWirelessUpdateStatusViewImplement.aspx";
    else if (document.getElementById('form1').report_type.value == "rwl_ml" || document.getElementById('form1').report_type.value == "rwl_ml_mod" || document.getElementById('form1').report_type.value == "rwl_ml_del")
        document.getElementById('form1').action = "UpdateOrderStatusMobileLiteViewImplement.aspx";
    else
		document.getElementById('form1').action="UpdateOrderStatusViewImplement.aspx";

	if(event.returnValue!=false)
		ThisForm.submit()
}

function chk_save4(ThisForm) {
    document.getElementById('form1').action = "OrderRetrieveHistorySearch.aspx";
    if (event.returnValue != false)
        ThisForm.submit()
}

function isNum(tobj){
	if(tobj.value!=""){
	a= Number(tobj.value);
	if (!(a) && tobj.value!="0"){
		alert("Number Only!");
		tobj.value = "";
		}
	}
	else
		tobj.value = "";
}

function setDDatePlanEffDate() {
    if ($('input[name=D_datePlan_eff_dateRule]').attr('checked')) {
        var _dD_date = new Date();
        //_dD_date.setDate(_dD_date.getDate() + 1);
        _dD_date.setDate(_dD_date.getDate() - 1);
        var _dPlan_eff_date = new Date();
        //_dPlan_eff_date.setDate(_dPlan_eff_date.getDate() + 3);
        _dPlan_eff_date.setDate(_dPlan_eff_date.getDate() - 3);

        $('#d_date').val(formatDateForReportSearch(_dD_date));
        $('#d_date2').attr('disabled', 'disabled');
        $('#plan_eff_date').val(formatDateForReportSearch(_dPlan_eff_date));
        $('#plan_eff_date2').attr('disabled', 'disabled');
        $('.date2span').hide();
    } else {
        $('#d_date').val('');
        $('#d_date2').attr('disabled', '');
        $('#d_date2').val('');
        $('#plan_eff_date').val('');
        $('#plan_eff_date2').attr('disabled', '');
        $('#plan_eff_date2').val('');
        $('.date2span').show();
    }
}

function formatDateForReportSearch(x_dDate) {
    var months = new Array('01', '02', '03', '04', '05', '06', '07', '08', '09', '10', '11', '12');
    return months[x_dDate.getMonth()] + "/" + ((x_dDate.getDate() < 10) ? "0" : "") + x_dDate.getDate() + "/" + x_dDate.getFullYear()
}

function report_type_onchange() {
    if ($('#report_type option:selected').val() == 'rwl_w_hs') {
        if ($('#handset_amount').attr('disabled') == true) {
            $('#handset_amount').removeAttr('disabled');
        }
    } else {
        $("#handset_amount option[value='']").attr('selected', 'selected');
        $('#handset_amount').attr('disabled', 'disabled');
    }
}

</script>
</head>
<body style="background-color:#ffffff" onload="setDDatePlanEffDate()">
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
                    <input type="button" name="orderRetrieveHistory" value="ORDER RETRIEVE HISTORY" class="button" onClick="chk_save4(this.form);"  width="200"/> 
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
                  <td height="0" class="row2">
                  <span class="explaintitle" style="font-size:7pt">Create Date /Modify Date</span></td>
                  <td height="0" class="row1">
                  <asp:TextBox ID="email_date" Font-Size="7pt" ReadOnly="false" MaxLength="10" runat="server" ></asp:TextBox>
                  <asp:ImageButton runat="server" ID="CalenderImageSDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                    (MM/DD/YYYY) TO 
                   <asp:TextBox ID="email_date2" Font-Size="7pt" ReadOnly="false" MaxLength="10" runat="server" ></asp:TextBox>
                    <asp:ImageButton runat="server" ID="CalenderImageEDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                    (MM/DD/YYYY)</td>
                </tr>
                <tr>
                    <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Daily Report Rule</span></td>
                    <td>
                    <input type="checkbox" ID="D_datePlan_eff_dateRule" runat="server" onclick="setDDatePlanEffDate()" name="D_datePlan_eff_dateRule"/>
                    <!--Use Delivery Date -1 or Plan Eff. Date -3 when one is earlier-->
                    <span style="font-size:8pt">Search by Expected Delivery date -1 date if expected Delivery Date is earlier than Rate Plan effective date & Rate Plan Effective Date - 3  if Rate Plan effective Date is earlier than expected Delivery Date.</span>
                    </td>
                </tr>
                <tr>
                    <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">
                        <asp:Label ID="Label1" runat="server" Text="Delivery Date"></asp:Label></span></td>
                    <td height="0" class="row1" nowrap>
                        <asp:TextBox ID="d_date" Font-Size="7pt" ReadOnly="false" MaxLength="10" runat="server" ></asp:TextBox>
                        <asp:ImageButton runat="server" ID="fromDeliveryDateImageButton" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                        (MM/DD/YYYY) 
                        <span class="date2span">TO 
                            <asp:TextBox ID="d_date2" Font-Size="7pt" ReadOnly="false" MaxLength="10" runat="server" ></asp:TextBox>
                            <asp:ImageButton runat="server" ID="toDeliveryDateImageButton" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                            (MM/DD/YYYY)
                        </span>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                                    ErrorMessage="*" ControlToValidate="d_date" Display="Dynamic" Enabled="True" ValidationExpression="^[0-1]\d\/[0-3]\d\/[1,2]\d{3}" Text="*"></asp:RegularExpressionValidator>
                        
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server"
                                ErrorMessage="RegularExpressionValidator" ControlToValidate="d_date2" Display="Dynamic" Enabled="True" ValidationExpression="^[0-1]\d\/[0-3]\d\/[1,2]\d{3}" Text="*"></asp:RegularExpressionValidator>
                    </td>
                    
                </tr>
				<tr>
                    <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">
                        <asp:Label ID="Label2" runat="server" Text="Rate Plan Effective Date"></asp:Label></span></td>
                    <td height="0" class="row1" nowrap>
                        <asp:TextBox ID="plan_eff_date" Font-Size="7pt" ReadOnly="false" MaxLength="10" runat="server" ></asp:TextBox>
                        <asp:ImageButton runat="server" ID="fromRatePlanEffectiveDateImageButton" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                        (MM/DD/YYYY) 
                        <span class="date2span">TO                     
                            <asp:TextBox ID="plan_eff_date2" Font-Size="7pt" ReadOnly="false" MaxLength="10" runat="server" ></asp:TextBox>
                            <asp:ImageButton runat="server" ID="toRatePlanEffectiveDateImageButton" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                            (MM/DD/YYYY)
                        </span>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server"
                                ErrorMessage="*" ControlToValidate="plan_eff_date" Display="Dynamic" Enabled="True" ValidationExpression="^[0-1]\d\/[0-3]\d\/[1,2]\d{3}" Text="*"></asp:RegularExpressionValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server"
                                ErrorMessage="RegularExpressionValidator" ControlToValidate="plan_eff_date2" Display="Dynamic" Enabled="True" ValidationExpression="^[0-1]\d\/[0-3]\d\/[1,2]\d{3}" Text="*"></asp:RegularExpressionValidator>
                    </td>
                    
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">MRT 
                    No </span></td>
                  <td width="77%" height="0" class="row1"> <input name="<%=WebFunc.qsMrt_noName %>" type="text" id="mrt_no" style="font-size:7pt" size="10" maxlength="8" onBlur="isNum(this);"/> 
                  </td>
                </tr>
                <tr>
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Handset Amount</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt">
                    <select name="handset_amount" id="handset_amount" style="font-size:7pt" >
                      <option value="" selected="selected"></option>
                      <option value="amount>0">HS Amount > $0</option>
                      <option value="amount=0">HS Amount = $0</option>
				    </select> <span style="font-size:8pt"> only for rwl_w_hs</span>
                  </span></td>
                </tr>
                <tr>
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Report Name</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt">
                    <select name="<%=WebFunc.qsReport_typeName %>" id="report_type" style="font-size:7pt" onchange="report_type_onchange()" >
                      <option value="">All except Change VAS/Customer Details</option>
                      <option value="rwl_suspend">Suspension (rwl_suspend)</option>
                      <option value="rwl_mod">3G (suspend or optout)Modification (rwl_mod)</option>
                      <option value="rwl_2g_mod">2G (suspend or optout)Modification (rwl_2g_mod)</option>
                      <option value="rwl_2g">New 2G Order (rwl_2g)</option>
                      <option value="rwl_wo_hs">New non-HS Order (rwl_wo_hs)</option>
                      <option value="rwl_w_hs">New HS Order (rwl_w_hs)</option>
                      <option value="rwl_del">3G Cancellation (rwl_del)</option>
                      <option value="rwl_2g_cxl">2G Cancellation (rwl_2g_cxl)</option>
                      <option value="rwl_vas">Change VAS (rwl_vas)</option>
                      <option value="rwl_go_wireless">GO wireless(rwl_go_wireless)</option>
                      <option value="rwl_cust">Change Customer Details (rwl_cust)</option>
                      <option value="rwl_fast">New Early Start Order (rwl_fast)</option>
                      <option value="rwl_NDS">New NDS Order (rwl_NDS)</option>
                      <option value="rwl_opt_out">OPT OUT Order(rwl_opt_out)</option>
                      <option value="rwl_mod_w_con">3G Modification With Contract(rwl_mod_w_con)</option>
                      <option value="rwl_2g_mod_w_con">2G Modification With Contract(rwl_2g_mod_w_con)</option>
                      <option value="rwl_ml">Mobile Lite (rwl_ml)</option>
                      <option value="rwl_ml_mod">Mobile Lite Modification Report(rwl_ml_mod)</option>
                      <option value="rwl_ml_del">Mobile Lite Cancellation(rwl_ml_del)</option>
					  </select>
                    </span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Status</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  
                    <select name="<%=WebFunc.qsOrder_statusName %>" id="order_status" style="font-size:7pt" onchange="order_status_change(this);" >
                      <option value="">All</option>
                      <option value="no_follow">NOT YET FOLLOWUP</option>
                      <option value="no_follow_t4">NOT YET FOLLOWUP T+4</option>
                      <option value="DONE">DONE</option>
                      <option value="WAITING">WAITING</option>
                      <option value="PENDING OPT OUT ORDER">PENDING OPT OUT ORDER</option>
                      <option value="FALLOUT">FALLOUT</option>
                      <option value="FALLOUT REPLIED">FALLOUT REPLIED</option>
                      <option value="MKTG AUTO ROLL FALLOUT">MKTG AUTO ROLL FALLOUT</option>
                      <option value="SYSTEM CODE">SYSTEM CODE</option>
                      <option value="AWAIT RATE PLAN ISSUE">AWAIT RATE PLAN ISSUE</option>
                    </select>
                    </span></td>
                </tr>
                
                <tr>
                    
                    <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Fallout Main Category 
                    </span></td>
                  <td height="27" class="row1">
                    <span class="gensmall" style="font-size:7pt"> 
                    <select name="fallout_main_category" id="fallout_main_category" style="font-size:7pt" disabled onChange="if (this.value=='A/C INFO'| this.value=='CUSTOMER INFO' | this.value=='ACTIVATION DATE' | this.value=='PAYMENT METHOD' | this.value=='WRONG VAS ENTITLEMENT' | this.value=='PROGRAM OFFER' | this.value=='SALES INFO' | this.value=='MOBILE/ SIM NO./ SERVICE NO.' | this.value=='BLACKLISTED CUSTOMER' | this.value=='WAITING' | this.value=='MKTG AUTO ROLL FALLOUT' | this.value=='STSTEM CODE NOT FOUND (REFER TO PRODUCT/MKTG)' | this.value=='SYSTEM CODE NOT FOUND BUT ORDER ISSUED') {document.all.fallout_main_category.disabled = false;document.all.fallout_reason.disabled = false;get_sub_cat_array(this.value);document.all.fallout_remark.disabled = false;document.all.fallout_remark.style.background='#FFFFFF';} else {document.all.fallout_reason.value ='';document.all.fallout_remark.value ='';document.all.fallout_main_category.disabled = true;document.all.fallout_reason.disabled = true;document.all.fallout_remark.disabled = true;document.all.fallout_remark.style.background='#DDDDDD';}if(this.value == '') {document.all.fallout_main_category.disabled = false;} ">
                        <option value=""></option>
                      </select>
                      
                       <input name="fallout_remark" type="text" id="fallout_remark" style="font-size:7pt; display:none;" size="100" maxlength="150" disabled class="disablerow" onBlur="chg_upper(this);" />
                    </span>
                    </td>
                </tr>
                
                <tr>    
                <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Fallout Reason</span></td>
                  <td height="27" class="row1">
                    <span class="gensmall" style="font-size:7pt"> 
                     <select name="fallout_reason" id="fallout_reason" runat="server" style="font-size:7pt" disabled ></select>
                    </span>
                    </td>
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