<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdateOrderStatusMobileLiteViewImplement.aspx.cs" Inherits="UpdateOrderStatusMobileLiteViewImplement" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE" %>
<%@ Import Namespace="NEURON.ENTITY.FRAMEWORK" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<style>
.disablerow{background:#DDDDDD}
</style>
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
<script type="text/javascript" src="../Resources/Scripts/fallout_items.js" language="javascript"></script>
<script type="text/javascript">
<!--
function close_win(){
//	return window.location="/cccl/cccl_main.asp";
	return top.location="../chk_login.asp"
}


function select_all(){
    var RecordCnt = document.getElementById('record_cnt');
    var UpdateStatus = document.getElementsByName('update_status');
    
    if(RecordCnt==undefined) return false;
    if(UpdateStatus==undefined) return false;
	if ('1'!=RecordCnt.value){
		for (i=0;i<UpdateStatus.length;++ i){
			UpdateStatus[i].checked=true;
		}	
	}
	else{
		UpdateStatus.checked=true;
	}
}

function select_none(){
try{
    var RecordCnt = document.getElementById('record_cnt');
    var UpdateStatus = document.getElementsByName('update_status');

    if(RecordCnt==undefined) return false;
    if(UpdateStatus==undefined) return false;

        if(UpdateStatus!=undefined){
	        if ('1'!=RecordCnt.value){
		        for (i=0;i<UpdateStatus.length;++ i){
			        UpdateStatus[i].checked=false;
			     }
	        }
	        else{
		        UpdateStatus.checked=false
		    }
        }
        
    }
    catch(e){
    alert(e);
    }    

}

function chk_save(ThisForm){
    try{
        var OrderStatus = document.getElementById('order_status');
        var UpdateStatus = document.getElementsByName('update_status');
        var FalloutReason = document.getElementById('fallout_reason');
        var RecordCnt = document.getElementById('record_cnt');
        var Submit2 = document.getElementById('submit2');
        var FalloutMainCategory=document.getElementById('fallout_main_category');
        var FalloutReason=document.getElementById('fallout_reason');

        if(OrderStatus==undefined) { 
            return false;
        }
        if(UpdateStatus==undefined) { 
            return false;
        }
        if(FalloutReason == undefined) { 
        return false;
        }
        if(Submit2==undefined){
        return false;
        }
        if(FalloutMainCategory==undefined){
        return false;
        }
        if(FalloutReason==undefined){
        return false;
        }


	    if(OrderStatus.value=="" ){
		    alert ("Please Select Order Status!");

		    event.returnValue=false;
		    Submit2.disabled=false;
	    }
	    else if((OrderStatus.value=="FALLOUT" || OrderStatus.value=="WAITING" || OrderStatus.value=="MKTG AUTO ROLL FALLOUT" || OrderStatus.value=="SYSTEM CODE") && FalloutMainCategory.value==""){
		    alert ("Please Enter Fallout Main Category!");
		    FalloutMainCategory.focus();
		    event.returnValue=false;
		    Submit2.disabled=false;
	    }
	    else if(FalloutMainCategory.value=="WAITING" && FalloutReason.value==""){
		    alert ("Please Enter Fallout Reason!");
		    FalloutReason.focus();
		    event.returnValue=false;
		    Submit2.disabled=false;
	    }
	    else if(OrderStatus.value=="FALLOUT" && FalloutReason.value==""){
		    alert ("Please Enter Fallout Reason!");
		    FalloutReason.focus();
		    event.returnValue=false;
		    Submit2.disabled=false;
	    }
	    else if(FalloutMainCategory.value=="MKTG AUTO ROLL FALLOUT" && FalloutReason.value==""){
		    alert ("Please Enter Fallout Reason!");
		    FalloutReason.focus();
		    event.returnValue=false;
		    Submit2.disabled=false;
	    }
	    else if(OrderStatus.value=="SYSTEM CODE" && FalloutReason.value==""){
		    alert ("Please Enter Fallout Reason!");
		    FalloutReason.focus();
		    event.returnValue=false;
		    Submit2.disabled=false;
	    }
	    else if(OrderStatus.value!=""){
    //	else if(document.getElementById('form1').order_status.value!="FALLOUT"){
		    if ('1'!=RecordCnt.value){
			    fallout=0
    			
			    for (i=0;i<UpdateStatus.length;++ i)
			    {
				    if (UpdateStatus[i].checked)
					    fallout++
			    }
    			
			    if (fallout==0){
				    alert ("At least Select 1 Order!");
				    event.returnValue=false;
				    Submit2.disabled=false;
			    }
		    }
		    else{
			    if (!document.all.update_status.checked){
				    alert ("Select 1 Order!");
				    event.returnValue=false;
				    Submit2.disabled=false;
			    }
		    }
	    }
	    
	    if(event.returnValue!=false){
		    if(confirm("Are you sure ?")==false){
			    event.returnValue=false;
			    Submit2.disabled=false;
		    }
		    else{
		        document.getElementById('form1').action="UpdateOrderStatusImplement.aspx";
			    ThisForm.submit();
			}
	    }
    }
    catch(e){
        event.returnValue=false;
        alert(e);
    }
}


//-->
</script>

</head>
<body>

    <form id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
        <input type="hidden" name="record_cnt" id="record_cnt" runat="server" />

                <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
              <tr>
                <th height="28" colspan="101"><span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></th>
              </tr>
                              <tr> 
                  <td height="23" colspan="100" class="row2"> <p> 
                      <input name="submit22" type="button" class="button" value="BACK TO SEARCH" onClick="location.href='AdminView.aspx'" style="font-size:7pt" />
                    </p>
                    <p> 
                      <input name="submit222" type="button" class="button" value="Select All" onClick="select_all();" style="font-size:7pt" />
                      <input name="submit223" type="button" class="button" value="Select None" onClick="select_none();" style="font-size:7pt" />
                    </p>
                    <p><span class="gensmall" style="font-size:7pt">Update Order 
                      Status : 
                      <select name="order_status" id="order_status" style="font-size:7pt" onChange="order_status_change(this);">
                        <option value=""></option>
                        <option value="DONE">DONE</option>
                        <option value="FALLOUT">FALLOUT</option>
                         <option value="WAITING">WAITING</option>
                         <option value="PENDING COOLING OFFER">PENDING COOLING OFFER</option>
                         <option value="PENDING OPT OUT ORDER">PENDING OPT OUT ORDER</option>
                         <option value="MKTG AUTO ROLL FALLOUT">MKTG AUTO ROLL FALLOUT</option>
                         <option value="SYSTEM CODE">SYSTEM CODE</option>
                        <option value="AWAIT RATE PLAN ISSUE">AWAIT RATE PLAN ISSUE</option>
                     </select>
                     <br />
                      Fallout Main Category : 
                      <select name="fallout_main_category" id="fallout_main_category" style="font-size:7pt" disabled onChange="if (this.value=='A/C INFO'| this.value=='CUSTOMER INFO' | this.value=='ACTIVATION DATE' | this.value=='PAYMENT METHOD' | this.value=='WRONG VAS ENTITLEMENT' | this.value=='PROGRAM OFFER' | this.value=='SALES INFO' | this.value=='MOBILE/ SIM NO./ SERVICE NO.' | this.value=='BLACKLISTED CUSTOMER' | this.value=='WAITING' | this.value=='MKTG AUTO ROLL FALLOUT' | this.value=='STSTEM CODE NOT FOUND (REFER TO PRODUCT/MKTG)' | this.value=='SYSTEM CODE NOT FOUND BUT ORDER ISSUED') {document.all.fallout_main_category.disabled = false;document.all.fallout_reason.disabled = false;get_sub_cat_array(this.value);document.all.fallout_remark.disabled = false;document.all.fallout_remark.style.background='#FFFFFF';} else {document.all.fallout_reason.value ='';document.all.fallout_remark.value ='';document.all.fallout_main_category.disabled = true;document.all.fallout_reason.disabled = true;document.all.fallout_remark.disabled = true;document.all.fallout_remark.style.background='#DDDDDD';}if(this.value == '') {document.all.fallout_main_category.disabled = false;} ">
                        <option value=""></option>
                      </select>
                      <br />
                      <br />
                      Update Fallout Reason : 
                      <select name="fallout_reason" id="fallout_reason" runat="server" style="font-size:7pt" disabled ></select>
                      <br />
                      Update Fallout Rmark : 
                      <input name="fallout_remark" type="text" id="fallout_remark" style="font-size:7pt" size="100" maxlength="150" disabled class="disablerow" onBlur="chg_upper(this);" />
                      <br />
                      </span> 
                      <input type="submit" name="submit2" value="Update Selected" class="mainoption"  onclick="chk_save(this.form);" onKeyDown="return false;" />
                    </p>
                    <br /> </td>
                </tr>

              <tr>
                <td class="row1">&nbsp;</td>
                <td class="row1">&nbsp;</td>
                <td class="row1">&nbsp;</td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Record ID</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Sent Date<br />(MM/DD/YYYY)</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Report Name</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Log Date<br />(MM/DD/YY HH:MM)</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Customer Name </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Account No.</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">MRT No </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Autoroll </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">PCD PAID Go Wireless</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Rate Plan</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Contract Period </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Trade Field</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Bundle Name</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Free Monthly Fee</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Cancel Auto Renewal</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">HS Model </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Premium </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">VAS Effective Date<br /> (MM/DD/YY)</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Rate Plan Effective Date<br />(MM/DD/YY)</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Contract Effective Date<br />(MM/DD/YY)</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Bill Cut Date</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Action Required</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Waive</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Suspend Date (MM/DD/YYYY)</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Existing Plan</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Reasons</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Staff No</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Salesman Code</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Status</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Fallout Main Category</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Fallout Reason</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Fallout Remark</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Fallout Reply</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Retrieved By</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Retrieved Date<br />(MM/DD/YY HH:MM)</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Last Updated By</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Last Update Date<br />(MM/DD/YY HH:MM)</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Order Placed By</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Relationship</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">HKID No/ Passport No</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Special Premium</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">AIG</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">EDF No</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">SRD (MM/DD/YYYY)</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Customer Staff No </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Remarks to PY Operation</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Old Order ID</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Monthly Payment Type</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Credit Card Type</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Credit Card No</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Bank Account Holder Name</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Credit Card Expiry Date</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Extra Rebate Amount</span></td>
	            <td class="row1"><span class="explaintitle" style="font-size:7pt">Extra Rebate</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">HS Amount</span></td>
	            <td class="row1"><span class="explaintitle" style="font-size:7pt">HS Rebate Amount</span></td>
                 <% VasHeaderShow(); %>
			  </tr>
			  <tr>
			  <% SearchReportShow(); %>
    </tr>

                  <tr>
                <td class="cat" colspan="101">&nbsp;</td>
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
    <script>document.getElementById('fallout_reason').value="";</script>
</body>
</html>
