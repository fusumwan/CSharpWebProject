<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SearchRetentionOrderView.aspx.cs" Inherits="SearchRetentionOrderView" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>

<link rel="Stylesheet" href="../Resources/Styles/global.css" type="text/css" />

<asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<link href="../Resources/Scripts/CalendarControl/CalendarControl.css" rel="Stylesheet" type="text/css" />
<script src="../Resources/Scripts/CalendarControl/CalendarControl.js" language="javascript"></script>
    <style type="text/css">


/* form-simple */
/*
div.form-simple fieldset
{
    margin: 0px;
    padding: 0px 0px 25px 0px;
    border: 0px;
    border-top: solid 1px #999999;
}

div.form-simple legend
{
    font-size: 1.4em;
    font-weight: bold;
    padding: 0px 5px;
    margin: 0px;
}
*/

table.form-simple
{
	padding: 0px;
	margin: 0px;
	border-collapse: collapse;
    border: hidden 1px white;
}

table.form-simple th,
table.form-simple td
{
	padding: 8px 5px 5px 5px;
	vertical-align: top;
}

table.form-simple tbody th,
table.form-simple tbody td
{
	border-top: solid 1px #cccccc;
	border-bottom: solid 1px #cccccc;
}

table.form-simple th
{
	text-align: right;
}

table.form-simple .form-value
{
	border-bottom: solid 1px #b4b4b4;
    width: 150px;
    min-height: 1.2em;
}

table.form-simple table td
{
	padding: 0px;
	border: 0px;
}

    </style>
<script type="text/javascript">
function chk_null(tobj){ 
	if(tobj.value=="")
		tobj.value = "0";
}

function SetReadOnly(ObjID){
    document.getElementById(ObjID).readOnly=true;
}
/*
document.getElementById("staff_no").readOnly=false;
*/

function en_action(){
	if (document.getElementById('form1').action_required.checked){
		document.getElementById('form1').action_required2.checked = false
	}
}

//-----------  Enable/Disable some fields of OPT OUT -------------//
function en_action_opt(){
	
	if (document.getElementById('form1').action_required2.checked){
		document.getElementById('form1').action_required.checked = false
	}
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

function chk_save(ThisForm){

	if(document.getElementById('form1').format.value=="WEB"){
		document.getElementById('form1').action="SearchRetentionOrderViewFinding.aspx";
	}else if(document.getElementById('form1').format.value=="EXCEL"){
		document.getElementById('form1').action="SearchRetentionOrderViewExport.aspx";
   }
	ThisForm.submit();

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
<body style="background-color:#ffffff" class="page-regular">


 <form name="form1" id="form1" runat="server" >
 <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div id="page-content">

            <cc1:ToolkitScriptManager ID="ToolkitAddWebLogScriptManager" runat="server"></cc1:ToolkitScriptManager>
  
 <table class="bodyline" width="100%" cellspacing="0" cellpadding="0" border="0">
<tr >
<td valign="top">

    <table width="100%" border="0" cellpadding="3" cellspacing="1" class="form-simple">
                <tr > 
                  <td height="28" colspan="4" align="center">&nbsp;<span  style="font-size:12pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
                </tr>
                <tr > 
                  <td height="23" colspan="4" > 
                  
                  <input type="button" name="submitform" id="submitform" value="SEARCH"   onclick="chk_save(this.form);" onKeyDown="return false;" style="font-size:10px" class="buttonlink-washed"   runat="server" disabled="disabled"/> 
                  <asp:Button ID="RefreshBut" Text="REFREASH" runat="server" class="buttonlink-washed" 
                          Font-Size="10px" onclick="Refresh_Click"  />
                  
                  
                  
                    <span > </span><span > 
                    </span></td>
                </tr>
                </table>
                
                
                
                
    
    <cc1:Accordion ID="Accordion1" runat="server" AutoSize="None" SelectedIndex="0" 
    FadeTransitions="true"
    TransitionDuration="250"
    FramesPerSecond="40"
    RequireOpenedPane="false"
    SuppressHeaderPostbacks="false" >
    <Panes>            

        <cc1:AccordionPane ID="p1" runat="server"  >

        <Header>
                <table width="100%" border="0" cellpadding="3" cellspacing="1" class="form-simple" style="cursor:hand">
                <tr > 
                  <td height="0"  colspan="6" style=" background-color:#DDDDDD"  >
                  <span  style="font-size:10px; color:White">
                      BASE SEARCH
                  </span>
                  </td>
                </tr>
                </table>
                        </Header>
        <Content>
                <table width="100%" border="0" cellpadding="3" cellspacing="1" class="form-simple">
                <tr id="issue_type_show">
                <td><span style="font-size:10px">Issue Type</span></td>
                <td width="75%" height="0" colspan="3" >
                <span  style="font-size:10px">
                <select id="issue_type" name="issue_type">
                <option value="">ALL</option>
                <option value="3G_RETENTION">3G RETENTION</option>
                <option value="2G_RETENTION">2G RETENTION</option>
                <option value="WIN">WIN</option>
                <option value="MOBILE_LITE">MOBILE LITE</option>
                <option value="UPGRADE">UPGRADE</option>
                </select>
                </span>
                </td>
                </tr>
                
                <tr id="existing_customer_type_show" style="display:none" > 
                  <td height="0" ><span  style="font-size:10px">Customer Type </span></td>
                  <td width="75%" height="0" colspan="3" ><span  style="font-size:10px">
                    <select name="<%=WebFunc.qsCust_typeName %>" id="cust_type" style="font-size:10px" >
                      <option value=""></option>
                      <option value="Healthy 3G user">Healthy 3G user</option>
                      <option value="Wap User">Wap User</option>
                      <option value="Voice User">Voice User</option>
                      <option value="2nd P6">2nd P6</option>
                      <option value="mobileOne">mobileOne</option>
                      <option value="mobileOneT2">mobileOneT2</option>
                      <option value="mobileOneT3">mobileOneT3</option>
                      <option value="PCCW Mobile 2G">PCCW Mobile 2G</option>
                        <option value="PCCW Mobile 3G">PCCW Mobile 3G</option>
                        <option value="Mobile Lite">Mobile Lite</option>
                        <option value="Netvigator Everywhere">Netvigator Everywhere</option>
                    </select>
                    </span> </td>
                </tr>
                
                 <tr > 
                  <td height="27"  ><span  style="font-size:10px">Action Required </span></td>
                  <td height="27"  colspan="3" >
                  <span  style="font-size:10px"> 
                    <input type="checkbox" name="<%=WebFunc.qsAction_requiredName %>" id="action_required" value="suspend" onClick="en_action();" />
                    Suspend
                    <input type="checkbox" name="action_required2" id="action_required2" value="opt_out" disabled="disabled" onClick="en_action_opt();" />
					  OPT OUT
					 </span>
				  </td>
                </tr>
                
                <tr > 
                  <td height="0" ><span  style="font-size:10px">Log Date</span></td>
                  <td height="0"  colspan="3" > <input name="<%=WebFunc.qsLog_dateName %>" type="text" id="log_date" style="font-size:10px" size="12" maxlength="10" onBlur="chk_date2(this,0,0);" value="" onfocus="showCalendarControl(this,'');" />
                      (DD/MM/YYYY) TO 
                    <input name="log_date2" type="text" id="log_date2" style="font-size:10px" size="12" maxlength="10" onBlur="chk_date2(this,0,0);"  onfocus="showCalendarControl(this,'');" />
                      (DD/MM/YYYY)</td>
                </tr>
                
                <tr > 
                  <td height="0" ><span  style="font-size:10px">Contract Effective Date</span></td>
                  <td height="0" > <input name="<%=WebFunc.qsCon_eff_dateName %>" type="text" id="con_eff_date" style="font-size:10px" size="12" maxlength="10" onBlur="chk_date2(this,0,0);" onfocus="showCalendarControl(this,'');" />
                      (DD/MM/YYYY) TO 
                    <input name="con_eff_date2" type="text" id="con_eff_date2" style="font-size:10px" size="12" maxlength="10" onBlur="chk_date2(this,0,0);" onfocus="showCalendarControl(this,'');" />
                      (DD/MM/YYYY)</td>
                </tr>
                
                <tr > 
                  <td height="0" ><span  style="font-size:10px">Rate Plan Effective Date</span></td>
                  <td height="0" > <input name="<%=WebFunc.qsPlan_eff_dateName %>" type="text" id="plan_eff_date" style="font-size:10px" size="12" maxlength="10" onBlur="chk_date2(this,0,0);" onfocus="showCalendarControl(this,'');" />
                      (DD/MM/YYYY) TO 
                    <input name="plan_eff_date2" type="text" id="plan_eff_date2" style="font-size:10px" size="12" maxlength="10" onBlur="chk_date2(this,0,0);" onfocus="showCalendarControl(this,'');" />
                      (DD/MM/YYYY)</td>
                </tr>
                
                <tr > 
                  <td height="0" ><span  style="font-size:10px">Expected Delivery Date </span></td>
                  <td height="0" > <input name="<%=WebFunc.qsD_dateName %>" type="text" id="d_date" style="font-size:10px" size="12" maxlength="10" onBlur="chk_date2(this,0,0);" onfocus="showCalendarControl(this,'');" />
                      (DD/MM/YYYY) TO 
                    <input name="d_date2" type="text" id="d_date2" style="font-size:10px" size="12" maxlength="10" onBlur="chk_date2(this,0,0);" onfocus="showCalendarControl(this,'');" />
                      (DD/MM/YYYY)</td>
                </tr>
                
                <tr > 
                  <td height="0" ><span  style="font-size:10px">Suspend Date</span></td>
                  <td height="0" width="75%"   colspan="3" > <input name="<%=WebFunc.qsAction_eff_dateName %>" type="text" id="action_eff_date" style="font-size:10px" size="12" maxlength="10" onBlur="chk_date2(this,0,0);" onfocus="showCalendarControl(this,'');" />
                      (DD/MM/YYYY) TO 
                    <input name="action_eff_date2" type="text" id="action_eff_date2" style="font-size:10px" size="12" maxlength="10" onBlur="chk_date2(this,0,0);" onfocus="showCalendarControl(this,'');" />
                      (DD/MM/YYYY)</td>
                </tr>
                
                <tr > 
                  <td height="0"  ><span  style="font-size:10px">Record ID</span></td>
                  <td width="75%" height="0" colspan="3" > <input name="<%=WebFunc.qsOrder_idName %>" type="text" id="order_id" style="font-size:10px" size="6" maxlength="6" onBlur="isNum(this);"/>
                      TO 
                    <input name="<%=WebFunc.qsOrder_id2Name %>" type="text" id="order_id2" style="font-size:10px" size="6" maxlength="6" onBlur="chg_upper(this);"/></td>
                </tr>
                
                <tr>
                  <td height="0"><span style="font-size:10px">EDF Number</span></td>
                  <td width="75%" height="0" colspan="3">
                  <input name="<%=WebFunc.qsEdf_noName %>" type="text" id="edf_no"  size="13" maxlength="13" />
                  </td> 
                </tr>
                
                
                 <tr > 
                  <td height="0" ><span  style="font-size:10px">Customer Name </span></td>
                  <td  width="75%" height="0"  colspan="3" > <input name="<%=WebFunc.qsCust_nameName %>" type="text" id="cust_name" style="font-size:10px" size="50" maxlength="100" onBlur="chg_upper(this);"/> 
                  </td>
                </tr>
                
                <tr > 
                  <td height="0" ><span  style="font-size:10px">HKID No/ BR No/ Passport No</span></td>
                  <td  width="75%"  height="0"  colspan="3" > <input name="<%=WebFunc.qsHkidName %>" type="text" id="hkid" style="font-size:10px" size="20" maxlength="21" onBlur="chg_upper(this);"/> 
                  </td>
                </tr>
                
                
                <tr > 
                  <td height="0" ><span  style="font-size:10px">MRT Number </span></td>
                  <td  width="75%" height="0"  colspan="3" > <input name="<%=WebFunc.qsMrt_noName %>" type="text" id="mrt_no" style="font-size:10px" size="10" maxlength="8" onBlur="isNum(this);"/> 
                  </td>
                </tr>
               
               <tr>
                  <td height="0"><span style="font-size:10px">Contact Number</span></td>
                  <td width="75%" height="0" colspan="3">
                  <input name="<%=WebFunc.qsContact_noName %>" type="text" id="contact_no" size="8" maxlength="8" />
                  </td> 
                </tr>
                
                 <tr id="ac_no_show" style="display:none" > 
                  <td height="0" ><span  style="font-size:10px">Account Number</span></td>
                  <td  width="75%" height="0"  colspan="3" > <input name="<%=WebFunc.qsAc_noName %>" type="text" id="ac_no" style="font-size:10px" size="10" maxlength="10" onBlur="chg_upper(this);"/></td>
                </tr>
                
                <tr id="bill_medium_email_show" style="display:none" > 
                  <td height="0" ><span  style="font-size:10px">Bill Medium Email</span></td>
                  <td  width="75%" height="0"  colspan="3" > <input name="<%=WebFunc.qsBill_medium_emailName %>" type="text" id="bill_medium_email" style="font-size:10px" size="10" maxlength="10" onBlur="chg_upper(this);"/></td>
                </tr>

                <tr id="exist_cust_plan_show" style="display:none" > 
                  <td height="0" ><span  style="font-size:10px">Existing Customer Type</span></td>
                  <td height="0"  width="75%"  colspan="3" >
                  <input type="hidden" id="exist_cust_plan" name="exist_cust_plan" />
                  <asp:DropDownList ID="exist_cust_plan_value"  AppendDataBoundItems="true" Font-Size="10px" runat="server" onclick="copyValue(this,this.form.exist_cust_plan)">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>
                  </td>
                </tr>
                <tr id="org_fee_show"> 
                  <td height="0" ><span  style="font-size:10px">Original Tariff Fee</span></td>
                  <td height="0"  width="75%"  colspan="3" >
                  <input type="hidden" id="org_fee" name="org_fee" />
                  <asp:DropDownList ID="org_fee_value"  AppendDataBoundItems="true"  Font-Size="10px" runat="server" onclick="copyValue(this,this.form.org_fee)">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>
                  </td>
                </tr>
                
				<tr id="existing_contract_end_month_show" style="display:none" > 
                  <td height="0" ><span  style="font-size:10px">Existing Contract End Month</span></td>
                  <td height="0"   width="75%" colspan="3" >
					<select name="<%=WebFunc.qsExisting_contract_end_monthName %>"  id="existing_contract_end_month" style="font-size:10px">
					<option value=""></option>
					<option value="JAN">JAN</option>
					<option value="FEB">FEB</option>
					<option value="MAR">MAR</option>
					<option value="APR">APR</option>
					<option value="MAY">MAY</option>
					<option value="JUN">JUN</option>
					<option value="JUL">JUL</option>
					<option value="AUG">AUG</option>
					<option value="SEP">SEP</option>
					<option value="OCT">OCT</option>
					<option value="NOV">NOV</option>
					<option value="DEC">DEC</option>
					</select>/
					<select name="<%=WebFunc.qsExisting_contract_end_yearName %>" id="existing_contract_end_year" style="font-size:10px">
 					<option value=""></option>
					<option value="2008">2008</option>
					<option value="2009">2009</option>
					<option value="2010">2010</option>
					<option value="2011">2011</option>
					<option value="2012">2012</option>
					</select>
					</td>
                </tr>
                
                
                <tr id="org_ftg_show"> 
                  <td height="0" ><span  style="font-size:10px">FTG</span></td>
                  <td height="0"  width="75%"  colspan="3" ><span  style="font-size:10px">
                    <input type="checkbox" name="<%=WebFunc.qsOrg_ftgName %>" id="org_ftg" value="ftg" />FTG</span></td>
                </tr>
                
                 <tr > 
                  <td height="0" ><span  style="font-size:10px">Staff No </span></td>
                  <td width="75%" height="0" colspan="3" > <input name="<%=WebFunc.qsStaff_noName %>" type="text" id="staff_no" style="font-size:10px" size="12" maxlength="10" value=""  /> 
                  </td>
                </tr>
                
                
                <tr > 
                  <td height="0" >
                  <span  style="font-size:10px">Program</span>
                  </td>
                  <td width="77%" height="0"  colspan="3" > 
                  
                  <input type="text" id="program" name="program" maxlength="30" size="30" />
                  
                  <asp:DropDownList ID="program_value" Font-Size="10px" AppendDataBoundItems="true" runat="server" onchange="copyValue(this,this.form.program)">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>

                    </td>
                </tr>
                
                <tr >
                  <td width="23%" height="0"  ><span  style="font-size:10px">Rate Plan</span></td>
                  <td height="0"  colspan="3" >
                  <input type="text" id="rate_plan" name="rate_plan"  maxlength="30" size="30" />
                  <asp:DropDownList ID="rate_plan_value" AppendDataBoundItems="true" runat="server" onchange="copyValue(this,this.form.rate_plan)">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList> 

                     </td>
                </tr>
                
                <tr >
                  <td height="27"  ><span  style="font-size:10px">Contract Period </span></td>
                  <td height="27"  colspan="3" ><span  style="font-size:10px"> 
                  <input type="text" id="Text2" name="con_per"  maxlength="30" size="30" />
                  <asp:DropDownList ID="con_per_value" AppendDataBoundItems="true" runat="server" onchange="copyValue(this,this.form.con_per)">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>
                    </span></td>
                </tr>
                
                <tr > 
                  <td height="27"  ><span  style="font-size:10px">Free Monthly Fee</span></td>
                  <td height="27"  colspan="3" >
                  <span  style="font-size:10px"> 
                  <input type="text" id="free_mon" name="free_mon"  maxlength="30" size="30" />
                  <asp:DropDownList ID="free_mon_value" AppendDataBoundItems="true" runat="server" onchange="copyValue(this,this.form.free_mon)">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>
                    </span></td>
                </tr>
                
                <tr > 
                  <td height="0" ><span  style="font-size:10px">Handset Model</span></td>
                  <td width="75%" height="0" colspan="3" >
                  <input type="hidden" id="hs_model" name="hs_model" />
                  <asp:DropDownList ID="hs_model_value" runat="server" Font-Size="10pt" onchange="copyValue(this,this.form.hs_model)">
                  <asp:ListItem Text="ALL" Value=""></asp:ListItem>
                  </asp:DropDownList>
                  </td>
                </tr>
                
                
                <tr > 
                  <td height="0" ><span  style="font-size:10px">Item code</span></td>
                  <td width="75%" height="0" colspan="3" >
                  <input type="text" id="sku" name="sku" />
                  </td>
                </tr>
                
                
                <tr > 
                  <td height="27"  ><span  style="font-size:10px">Premium</span></td>
                  <td height="27"  colspan="3" ><span  style="font-size:10px">
                  
                    <select name="<%=WebFunc.qsPremiumName %>" id="premium" style="font-size:10px" >
                      <option value=""></option>
                      <option value="Y">Yes</option>
                      <option value="N">No</option>
                    </select>
                    </span></td>
                </tr>
                
                <tr > 
                  <td height="0" ><span  style="font-size:10px">Special Premium 1 <br>  </span></td>
                  <td height="0" colspan="3"  ><span  style="font-size:9px"> 
                  
                  <input type="text" id="s_premium1" name="s_premium1"  maxlength="30" size="30" />
                  
                  <asp:DropDownList ID="s_premium1_value" AppendDataBoundItems="true" runat="server" Font-Size="10px" onchange="copyValue(this,this.form.s_premium1)">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>

                    </span></td>
                </tr>
                
                <tr > 
                  <td height="0" ><span  style="font-size:10px">Special Premium 2 <br>  </span></td>
                  <td height="0" colspan="3"  ><span  style="font-size:9px"> 
                  
                  <input type="text" id="s_premium2" name="s_premium2"  maxlength="30" size="30" />
                  
                  <asp:DropDownList ID="s_premium2_value" AppendDataBoundItems="true" runat="server" Font-Size="10px"  onchange="copyValue(this,this.form.s_premium2)">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>

                    </span></td>
                </tr>
                
                 <tr >
				  <td height="0" ><span  style="font-size:10px">Salesman code</span></td>
                  <td width="75%" height="0" colspan="3" >
                  <input type="hidden" id="salesmancode" name="salesmancode" />
                  <asp:DropDownList ID="salesmancode_value" Font-Size="10px" AppendDataBoundItems="true" runat="server" onclick="copyValue(this,this.form.salesmancode)">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>
				</tr>
				
                <tr > 
                  <td height="0" ><span  style="font-size:10px">Teamcode</span></td>
                  <td width="75%" height="0" colspan="3" >
                  <input type="hidden" id="teamcode" name="teamcode" />
                  <asp:DropDownList ID="teamcode_value" Font-Size="10px" AppendDataBoundItems="true" runat="server" onclick="copyValue(this,this.form.teamcode)">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>
                  </td>
                </tr>
                
                
                <tr >
				<td height="0" ><span  style="font-size:10px">Order Status</span></td>
                  <td width="75%" height="0" colspan="3" >
                  <select id="order_status" name="order_status" runat="server">
                  <option value=""></option>
                  <option value="FALLOUT">FALLOUT</option>
                  <option value="PENDING OPT OUT ORDER">PENDING OPT OUT ORDER</option>
                  <option value="DONE W/GO WIRELESS">DONE W/GO WIRELESS</option>
                  <option value="FALLOUT REPLIED">FALLOUT REPLIED</option>
                  <option value="WAITING">WAITING</option>
                  <option value="DONE">DONE</option>
                  <option value="PENDING COOLING OFFER">PENDING COOLING OFFER</option>
                  </select>
				</tr>
				
				<tr > 
                  <td height="0" ><span  style="font-size:10px">OB Program ID</span></td>
                  <td height="0"  width="75%"  colspan="3" >
                  <input type="text" id="ob_program_id" name="ob_program_id" />
                  <asp:DropDownList ID="ob_program_id_value"  Font-Size="10px" AppendDataBoundItems=true runat="server"  onclick="copyValue(this,this.form.ob_program_id)">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>                    
                  </td>
                </tr>
                

                
				<tr > 
                  <td height="27"  ><span  style="font-size:10px">Channel</span></td>
                  <td height="27" colspan="3" ><span  style="font-size:10px"> 
                    <input type="radio" name="<%=WebFunc.qsChannelName %>" value="" checked />
                      ALL 
                    <input type="radio" name="<%=WebFunc.qsChannelName %>" value="IB"/>
                      IB 
                    <input type="radio" name="<%=WebFunc.qsChannelName %>" value="OB"/>
                      OB 
				</span></td>
                </tr>
                
                
                </table>
                       </Content>
        </cc1:AccordionPane> 
                
     </Panes>
    </cc1:Accordion>           
                
     <cc1:Accordion ID="Accordion2" runat="server" AutoSize="None" SelectedIndex="0" 
    FadeTransitions="true"
    TransitionDuration="250"
    FramesPerSecond="40"
    RequireOpenedPane="false"
    SuppressHeaderPostbacks="false" >
    <Panes>                
                
        <cc1:AccordionPane ID="P2" runat="server"  >

        <Header>
                
                <table width="100%" border="0" cellpadding="3" cellspacing="1" class="form-simple"  style="cursor:hand">
                <tr > 
                  <td height="0"  colspan="6"  style=" background-color:#DDDDDD"  ><span  style="font-size:10px; color:White">
                     Other</span></td>
                </tr>
                </table>
       </Header>
        <Content>
                
                
                <table width="100%" border="0" cellpadding="3" cellspacing="1" class="form-simple">
                
                
                
                <tr > 
                  <td height="27"  ><span  style="font-size:10px">Handset</span></td>
                  <td height="27"  colspan="3" ><span  style="font-size:10px"> 
                    <select name="<%=WebFunc.qsHs %>" id="hs" style="font-size:10px" >
                      <option value=""></option>
                      <option value="Y">Yes</option>
                      <option value="N">No</option>
                    </select>
                    </span></td>
                </tr>
               
               
                
                
                <tr > 
                  <td height="0" ><span  style="font-size:10px">Special Approval</span></td>
                  <td width="77%" height="0"  colspan="3" > 
                    <select name="<%=WebFunc.qsSpecial_approvalName %>" id="special_approval" style="font-size:10px" >
                      <option value=""></option>
                      <option value="Y">Yes</option>
                      <option value="N">No</option>
                    </select>
				</td>
                </tr>
               
                
                <tr > 
                  <td height="0" ><span  style="font-size:10px">PCD Paid Go Wireless<br></span></td>
                  <td height="0" colspan="3"  >
                  <span  style="font-size:9px"> 
                  <input type="checkbox" name="pcd_paid_go_wireless" id="pcd_paid_go_wireless" value="1" />
                  </span>
                  </td>
                </tr>
                
				  <tr > 
                  <td height="28"  ><span  style="font-size:10px">Now Sports</span></td>
                  <td height="28"  colspan="3" ><span  style="font-size:10px"> 
                    <select name="<%=WebFunc.qsNow_vasName %>" id="now_vas" style="font-size:10px" >
                      <option value=""></option>
                      <option value="NO">NO</option>
                      <option value="YES">YES</option>
                      <option value="50%">50%</option>
                    </select>
                    </span></td>
                </tr>
                <tr > 
                  <td height="27"  ><span  style="font-size:10px">Football Unlimited</span></td>
                  <td height="27"  colspan="3" ><span  style="font-size:10px"> 
                    <select name="<%=WebFunc.qsFoot_vasName %>" id="foot_vas" style="font-size:10px" >
                      <option value=""></option>
                      <option value="NO">NO</option>
                      <option value="YES">YES</option>
                      <option value="50%">50%</option>
                    </select>
                    </span></td>
                </tr>
                <tr > 
                  <td height="27"  ><span  style="font-size:10px">Finance Info</span></td>
                  <td height="27"  colspan="3" ><span  style="font-size:10px"> 
                    <select name="<%=WebFunc.qsFin_vasName %>" id="fin_vas" style="font-size:10px" >
                      <option value=""></option>
                      <option value="NO">NO</option>
                      <option value="YES">YES</option>
                      <option value="50%">50%</option>
                    </select>
                    </span></td>
                </tr>
                <tr > 
                  <td height="27"  ><span  style="font-size:10px">Horse Racing</span></td>
                  <td height="27"  colspan="3" ><span  style="font-size:10px"> 
                    <select name="<%=WebFunc.qsHorse_vasName %>" id="horse_vas" style="font-size:10px" >
                      <option value=""></option>
                      <option value="NO">NO</option>
                      <option value="YES">YES</option>
                      <option value="50%">50%</option>
                    </select>
                    </span></td>
                </tr>
                <tr > 
                  <td height="27"  ><span  style="font-size:10px">MOOV</span></td>
                  <td height="27"  colspan="3" ><span  style="font-size:10px"> 
                    <select name="<%=WebFunc.qsMoov_vasName %>" id="moov_vas" style="font-size:10px" >
                      <option value=""></option>
                      <option value="NO">NO</option>
                      <option value="YES">YES</option>
                      <option value="50%">50%</option>
                    </select>
                    </span></td>
                </tr>
                <tr > 
                  <td height="27"  ><span  style="font-size:10px">GPRS</span></td>
                  <td height="27"  colspan="3" ><span  style="font-size:10px"> 
                    <select name="<%=WebFunc.qsGprs_vasName %>" id="gprs_vas" style="font-size:10px" >
                      <option value=""></option>
                      <option value="NO">NO</option>
                      <option value="YES">YES</option>
                      <option value="50%">50%</option>
                    </select>
                    <br />
                    <select name="<%=WebFunc.qsGprs_vas2Name %>" id="gprs_vas2" style="font-size:10px" >
                      <option value=""></option>
                      <option value="48">$48 3MB</option>
                      <option value="88">$88 10MB</option>
                      <option value="198">$198 30MB</option>
                      <option value="388">$388 80MB</option>
                    </select>
                    </span></td>
                </tr>
                <tr > 
                  <td height="27"  ><span  style="font-size:10px">WiFi</span></td>
                  <td height="27"  colspan="3" ><span  style="font-size:10px"> 
                    <select name="<%=WebFunc.qsWifi_vasName %>" id="wifi_vas" style="font-size:10px" >
                      <option value=""></option>
                      <option value="NO">NO</option>
                      <option value="YES">YES</option>
                      <option value="50%">50%</option>
                    </select>
                    </span></td>
                </tr>
                <tr > 
                  <td height="27"  ><span  style="font-size:10px">VAS MIN</span></td>
                  <td height="27"  colspan="3" ><span  style="font-size:10px"> 
                    <select name="<%=WebFunc.qsMin_vasName %>" id="min_vas" style="font-size:10px" >
                      <option value=""></option>
                      <option value="min_vas200">200mins</option>
                      <option value="min_vas300">300mins</option>
                      <option value="min_vas400">400mins</option>
                      <option value="min_vas500">500mins</option>
                      <option value="min_vas600">600mins</option>
                      <option value="min_vas">800mins</option>
                      <option value="min_vas_add">1300mins(Local)+300mins(Intra)</option>
                    </select>
                    </span></td>
                </tr>
                <tr > 
                  <td height="27"  ><span  style="font-size:10px">SMS</span></td>
                  <td height="27"  colspan="3" ><span  style="font-size:10px"> 
                    <select name="<%=WebFunc.qsSms_vasName %>" id="sms_vas" style="font-size:10px">
                      <option value=""></option>
                      <option value="NO">NO</option>
                      <option value="YES">YES</option>
                      <option value="50%">50%</option>
                    </select>
                    <br />
                    <select name="<%=WebFunc.qsSms_vas2Name %>" id="sms_vas2" style="font-size:10px" >
                      <option value=""></option>
                      <option value="35">$35/100</option>
                      <option value="45">$45/140</option>
                    </select>
                    </span></td>
                </tr>
                <tr > 
                  <td height="27"  ><span  style="font-size:10px">Mobile MSN</span></td>
                  <td height="27"  colspan="3" ><span  style="font-size:10px"> 
                    <select name="<%=WebFunc.qsMsn_vasName %>" id="msn_vas" style="font-size:10px" >
                      <option value=""></option>
                      <option value="NO">NO</option>
                      <option value="YES">YES</option>
                      <option value="50%">50%</option>
                    </select>
                    </span></td>
                </tr>
                <tr > 
                  <td height="27"   ><span  style="font-size:10px">Connection Tone </span></td>
                  <td height="27"  colspan="3" ><span  style="font-size:10px"> 
                    <select name="<%=WebFunc.qsCt_vasName %>" id="ct_vas" style="font-size:10px" >
                      <option value=""></option>
                      <option value="NO">NO</option>
                      <option value="YES">YES</option>
                      <option value="50%">50%</option>
                    </select>
                    </span></td>
                </tr>               
                <tr > 
                  <td height="0" ><span  style="font-size:10px">VAS Effective Date</span></td>
                  <td height="0" > <input name="<%=WebFunc.qsVas_eff_dateName %>" type="text" id="vas_eff_date" style="font-size:10px" size="12" maxlength="10" onBlur="chk_date2(this,0,0);" onfocus="showCalendarControl(this,'');" />
                      (DD/MM/YYYY) TO 
                    <input name="vas_eff_date2" type="text" id="vas_eff_date2" style="font-size:10px" size="12" maxlength="10" onBlur="chk_date2(this,0,0);" onfocus="showCalendarControl(this,'');" />
                      (DD/MM/YYYY)</td>
                </tr>

                 <tr > 
                  <td height="27"  ><span  style="font-size:10px">Early Start</span></td>
                  <td height="27" colspan="3"  ><span  style="font-size:10px"> 
                    <span >
                    <input type="checkbox" name="<%=WebFunc.qsFast_startName %>" id="fast_start" value="Y" />
                    </span></span></td>
                </tr>
                <tr > 
                  <td height="0" ><span  style="font-size:10px">POS Reference No</span></td>
                  <td width="77%" height="0"  colspan="3" > <input name="<%=WebFunc.qsPos_ref_noName %>" type="text" id="pos_ref_no" style="font-size:10px" size="30" maxlength="30" onBlur="chg_upper(this);"/> 
                  </td>
                </tr>
                
                
                <tr >
                  <td height="27"  ><span  style="font-size:10px">PAYMENT METHOD</span></td>
                  <td height="27" ><span  style="font-size:10px"> 
                    <select name="<%=WebFunc.qsPay_methodName%>" id="pay_method" style="font-size:10px" >
                      <option value=""></option>
                      <option value="CASH">CASH</option>
                      <option value="CREDIT CARD">CREDIT CARD</option>
                      <option value="CREDIT CARD INSTALLMENT">CREDIT CARD INSTALLMENT</option>
                    </select>
                    </span>
                   </td>
                </tr>
                <tr >
                  <td height="27"  ><span  style="font-size:10px">MONTHLY PAYMENT TYPE</span></td>
                  <td height="27" ><span  style="font-size:10px"> 
                    <select name="monthly_payment_method" id="monthly_payment_method" style="font-size:10px" >
                      <option value=""></option>
                      <option value="keep_existing_payment_method">Keep Existing Payment Method </option>
                      <option value="change_payment_method">Change Payment Method</option>
                    </select>
                    </span>
                   </td>
                </tr>
				
                </table>
       </Content>
        </cc1:AccordionPane>
                
                 </Panes>
    </cc1:Accordion>     
                
     <cc1:Accordion ID="Accordion3" runat="server" AutoSize="None" SelectedIndex="0" 
    FadeTransitions="true"
    TransitionDuration="250"
    FramesPerSecond="40"
    RequireOpenedPane="false"
    SuppressHeaderPostbacks="false" >
    <Panes>             
                
        <cc1:AccordionPane ID="P3" runat="server"  >

        <Header>
                
                <table width="100%" border="0" cellpadding="3" cellspacing="1" class="form-simple"  style="cursor:hand">
               <tr > 
                  <td height="0"  colspan="6" style=" background-color:#DDDDDD"  ><span  style="font-size:10px; color:White">
                      VIEW METHOD 
                    </span></td>
                </tr>
                </table>
                
                  </Header>
        <Content>
                
                
                <table width="100%" border="0" cellpadding="3" cellspacing="1" class="form-simple">
                
				               <tr > 
                  <td height="27"  ><span  style="font-size:10px">Format</span></td>
                  <td height="27" ><span  style="font-size:10px"> 
                    <select name="<%=WebFunc.qsFormatName %>" id="format" style="font-size:10px" >
                      <option value="WEB">WEB</option>
                      <option value="EXCEL">EXCEL</option>
                    </select>
                    </span>
                   </td>
                </tr>
                
                </table>
                
                
                </Content>
        
        
        </cc1:AccordionPane>
                
      </Panes>
    </cc1:Accordion>                
                


              <table width="100%" border="0" cellpadding="3" cellspacing="1" class="form-simple">
                <tr > 
                  <td class="cat" colspan="2">&nbsp;</td>
                </tr>
              </table>
              
              
<table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; View 
<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
</table>


</td>
</tr>
</table>

    </div>
    </form>
             

</body>

</html>
