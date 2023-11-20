<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GoWirelessUpdateStatusViewImplement.aspx.cs" Inherits="GoWirelessUpdateStatusViewImplement" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
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
<style>
.disablerow{background:#DDDDDD}
</style>
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
<script type="text/javascript">
<!--
function close_win(){
	return top.location="~/Logout.aspx"
}


function select_all(){
    var RecordCnt = document.getElementById('record_cnt');
    var RetrieveId = document.getElementsByName('update_status');
    
    if(RecordCnt==undefined) return false;
    if(RetrieveId==undefined) return false;
	if ('1'!=RecordCnt.value){
		for (i=0;i<RetrieveId.length;++ i){
			RetrieveId[i].checked=true;
		}	
			
	}
	else{
		RetrieveId.checked=true;
	}
}
function select_none(){
    var RecordCnt = document.getElementById('record_cnt');
    var RetrieveId = document.getElementsByName('update_status');

    if(RecordCnt==undefined) return false;
    if(RetrieveId==undefined) return false;
	if ('1'!=RecordCnt.value){
		for (i=0;i<RetrieveId.length;++ i)
			RetrieveId[i].checked=false
	}
	else{
		RetrieveId.checked=false
    }
}

function chk_save(ThisForm){
if(document.getElementById('record_cnt')==undefined) return false;

	if(document.getElementById('form1').order_status.value=="" ){
		alert ("Please Select Order Status!");
		event.returnValue=false;
		document.getElementById('form1').submit2.disabled=false;
	}
	else if(document.getElementById('form1').order_status.value=="FALLOUT" && document.getElementById('form1').fallout_reason.value==""){
		alert ("Please Enter Fallout Reason!");
		document.getElementById('form1').fallout_reason.focus();
		event.returnValue=false;
		document.getElementById('form1').submit2.disabled=false;
	}
	else if(document.getElementById('form1').order_status.value!=""){
		if ('1'!=document.getElementById('record_cnt').value){
			fallout=0
			for (i=0;i<document.all.update_status.length;++ i)
			{
				if (document.all.update_status[i].checked)
					fallout++
			}
			if (fallout==0){
				alert ("At least Select 1 Order!");
				event.returnValue=false;
				document.getElementById('form1').submit2.disabled=false;
			}
		}
		else{
			if (!document.all.update_status.checked){
				alert ("Select 1 Order!");
				event.returnValue=false;
				document.getElementById('form1').submit2.disabled=false;
			}
		}
	}


	if(event.returnValue!=false){
		if(confirm("Are you sure ?")==false){
			event.returnValue=false;
			document.getElementById('form1').submit2.disabled=false;
		}
		else{
			
			document.getElementById('form1').action="UpdateOrderStatusImplement.aspx";
			ThisForm.submit();
			
	    }
	}
}

//-->
</script>
</head>
<body>
<form action="UpdateOrderStatusImplement.aspx" method="post" name="form1" id="form1" runat="server">
<div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <input type="hidden" id="record_cnt" runat="server" />

    <table class="bodyline" width="100%" cellspacing="0" cellpadding="0" border="0">
  <tr> 
    <td valign="top"> <table width="100%" border="0" cellspacing="0" cellpadding="2">
        <tr> 
          <td align="right" class="topnav">&nbsp;<a href="javascript:close_win();"><b>X</b></a>&nbsp;</td>
        </tr>
      </table>
      <table width="100%" border="0" cellspacing="0" cellpadding="10">
        <tr> 
          <td> <table width="100%" cellspacing="2" cellpadding="3" border="0">
              <tr> 
                <td colspan="2" class="maintitle"><span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
              </tr>
              <tr> 
                <td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; Retrieve 
                  Order - CS Admin<br /> 
                
                </td>
                <td align="right" class="nav">&nbsp;</td>
              </tr>
            </table>
            
            <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr>
                  <th height="28" colspan="100"><span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></th>
                </tr>
                <tr>
                  <td height="23" colspan="100" class="row2"> <p> 
                      <input name="submit22" type="button" class="button" value="BACK TO SEARCH" onClick="location.href='AdminView.asp'" style="font-size:7pt" />
                    </p>
                    <p> 
                      <input name="submit222" type="button" class="button" value="Select All" onClick="select_all();" style="font-size:7pt" />
                      <input name="submit223" type="button" class="button" value="Select None" onClick="select_none();" style="font-size:7pt" />
                    </p>
                    <p><span class="gensmall" style="font-size:7pt">Update Order 
                      Status : 
                      <select name="order_status" id="order_status" style="font-size:7pt" onChange="if (this.value=='FALLOUT'|this.value=='WAITING') {document.all.fallout_reason.disabled = false;document.all.fallout_remark.disabled = false;document.all.fallout_remark.style.background='#FFFFFF';} else {document.all.fallout_reason.value ='';document.all.fallout_remark.value ='';document.all.fallout_reason.disabled = true;document.all.fallout_remark.disabled = true;document.all.fallout_remark.style.background='#DDDDDD';}">
                        <option value=""></option>
                        <option value="DONE">DONE</option>
                        <option value="FALLOUT">FALLOUT</option>
    	                <option value="DONE W/GO WIRELESS">DONE W/GO WIRELESS</option>
	                    <option value="WAITING W/GO WIRELESS">WAITING W/GO WIRELESS</option>
                        <option value="WAITING">WAITING</option>
				        <option value="PENDING OPT OUT ORDER"> PENDING OPT OUT ORDER</option>
                        <option value="AWAIT RATE PLAN ISSUE">AWAIT RATE PLAN ISSUE</option>
                     </select>
                      <br />
                      Update Fallout Reason : 
                      <asp:DropDownList ID="fallout_reason" Font-Size="7pt" Enabled="false" runat="server">
                      </asp:DropDownList>
                      <br />
                      Update Fallout Rmark : 
                      <input name="fallout_remark" type="text" id="fallout_remark" style="font-size:7pt" size="100" maxlength="150" disabled class="disablerow" onBlur="chg_upper(this);" />
                      <br />
                      </span> 
                      <input type="submit" name="submit2" value="Update Selected" class="mainoption"  onclick="chk_save(this.form);" onKeyDown="return false;" />
                    </p>
                    <br />
                    </td>
                </tr>
                <EW:RepeaterEx ID="admin_view_rp" runat="server" onitemdatabound="admin_view_rp_ItemDataBound" >
                <HeaderTemplate>
                <tr> 
                  <td class="row1">&nbsp;</td>
                  <td class="row1"><span class="explaintitle"> </span></td>
                  <td class="row1"><span class="explaintitle"> </span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">Record ID</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">Sent Date<br />
                    (MM/DD/YYYY)</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">Report Name</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">Log Date<br />
                    (MM/DD/YYYY)</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">GO Wireless</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">EDF No</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">Staff No</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">Customer Name </span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">HKID No/ Passport No</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">MRT No </span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">Rate  Plan</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">Trade Field</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">Retrieved By</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">Retrieved Date <br />
                    (MM/DD/YYYY HH:MM)</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">Last Updated By</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">Last Update Date <br />
                    (MM/DD/YYYY HH:MM)</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">Register Address</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">New Sim imei</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">Go Wireless MRT</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">New ANS imei</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">Preferred Languages</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">Payment Type</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">Pre-pay Amount</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">3rd Party Credit Card</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">3rd Party HKID/Passport</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">Bank Account Holder Name </span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">Credit card no.</span></td>
			      <td class="row1"><span class="explaintitle" style="font-size:7pt">Credit Card Expiry Date </span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">Actvation Date<br />
                    (MM/DD/YYYY) </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Remarks to PY Operation</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Status</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Go Wireless VAS</span></td>
				
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Extra Rebate Amount</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Extra Rebate</span></td>
				
				<td class="row1"><span class="explaintitle" style="font-size:7pt">HS Amount</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">HS Rebate Amount</span></td>
				
				</tr>
				</HeaderTemplate>
				<ItemTemplate>
                <tr> 
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="viewid" runat="server"></asp:Literal></span></td>
                  <td nowrap class="row2">
                    <asp:CheckBox ID="update_status" runat="server" Checked="true" runat="server" />
                    <asp:Literal ID="mid" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container.DataItem,"mid") %>'></asp:Literal>
                  </td>
                <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><a href="#" onclick='window.open("HistoryReportViewImplement.aspx?order_id=<%=Func.RQ(WebFunc.qsOrder_id)%>","_blank","toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=yes, copyhistory=no, width=600, height=200")'>Order History</a></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><a href="#" onclick='window.open("AdminViewHistoryImplement.aspx?order_id=<%=Func.RQ(WebFunc.qsOrder_id)%>","_blank","toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=yes, copyhistory=no, width=600, height=200")'><%=Func.IDAdd100000(WebFunc.qsOrder_id)%></a></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="email_date" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"email_date") %>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="report_type" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"report_type") %>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="log_date" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"log_date") %>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="go_wireless" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"go_wireless") %>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="edf_no" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"edf_no") %>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="staff_no" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"staff_no") %>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="cust_name" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "family_name") +" "+DataBinder.Eval(Container.DataItem, "given_name") %>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="ord_place_id_type" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"ord_place_id_type") %>'></asp:Literal>&nbsp;<asp:Literal ID="ord_place_hkid" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"ord_place_hkid") %>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="mrt_no" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"mrt_no") %>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="rate_plan" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"mrt_no") %>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="trade_field" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"trade_field") %>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="retrieve_sn" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"retrieve_sn") %>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="retrieve_date" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"retrieve_date") %>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="admin_sn" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"admin_sn") %>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="admin_date" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"admin_date") %>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="register_address" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"register_address") %>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="gift_imei" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"gift_imei") %>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="sim_mrt_no" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"sim_mrt_no") %>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="accessory_imei" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"accessory_imei") %>'></asp:Literal></span></td>
 				  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="preferred_languages" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"preferred_languages") %>'><</asp:Literal>/span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="pay_method" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"pay_method") %>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt">$<asp:Literal ID="accessory_price" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"accessory_price") %>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="third_party_credit_card" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"third_party_credit_card") %>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="third_party_id_type" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"third_party_id_type") %>'></asp:Literal>&nbsp; <asp:Literal ID="third_party_hkid" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"third_party_hkid") %>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="card_holder" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"card_holder") %>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="card_no" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"card_holder") %>'></asp:Literal></span></td>
				  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="card_exp_month" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"card_exp_month") %>'></asp:Literal></span><span class="gensmall" >  / </span><span class="gensmall" style="font-size:7pt"><asp:Literal ID="card_exp_year" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"card_exp_year") %>'></asp:Literal></span><span class="gensmall" > (MM/YY) </span></td>
				  
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="d_date" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"d_date") %>' Visible="false"></asp:Literal><asp:Literal ID="newdate" runat="server"></asp:Literal></span></td>
    			  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="remarks2PY" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"remarks2PY") %>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="order_status" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"order_status") %>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="gowireless_vas" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"gowireless_vas") %>'></asp:Literal></span></td>
				  <td nowrap class="row2"><span class="gensmall"  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "extra_rebate_amount")%></span></td>
				<td nowrap class="row2"><span  class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "extra_rebate")%></span></td>
				<td nowrap class="row2"><span class="gensmall"  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "amount")%></span></td>
				<td nowrap class="row2"><span  class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "rebate_amount")%></span></td>
                
				<tr> 
				</ItemTemplate>
				</EW:RepeaterEx>
				
                  <td class="cat" colspan="100">&nbsp;</td>
                </tr>
              </table>
            
            <table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; View 
<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
</table>       
            <div align="center" class="gensmall">&nbsp;</div>
            <a name="bot" id="bot"></a></td>
        </tr>
      </table></td>
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
  </tr>
</table>
    </form>

</body>
</html>
