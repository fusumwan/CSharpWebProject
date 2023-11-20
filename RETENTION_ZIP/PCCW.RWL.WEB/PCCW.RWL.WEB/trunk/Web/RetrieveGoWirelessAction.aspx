<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RetrieveGoWirelessAction.aspx.cs" Inherits="Web_RetrieveGoWirelessAction" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Register TagName="RWLMenu2"  TagPrefix="RWLMenu2" Src="~/UI/RWLControlMenu.ascx"%>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
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
//	return window.location="/cccl/cccl_main.asp";
	return top.location="../chk_login.asp"
}


function select_all(){
    var RecordCnt = document.getElementById('record_cnt');
    var RetrieveId = document.getElementsByName('retrieve_id');
    
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
    var RetrieveId = document.getElementsByName('retrieve_id');

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
var RecordCnt = document.getElementById('record_cnt');
var RetrieveId = document.getElementsByName('retrieve_id');
var Submit2 = document.getElementById('submit2');

if(RecordCnt==undefined) return false;
if(RetrieveId==undefined) return false;

	if ('1'!=RetrieveId.value){
		fallout=0
		for (i=0;i<RetrieveId.length;++ i)
		{
			if (RetrieveId[i].checked)
				fallout++
		}
		if (fallout==0){
			alert ("At least Select 1 Order!");
			event.returnValue=false;
			Submit2.disabled=false;
		}
	}
	else{
		if (!document.all.retrieve_id.checked){
			alert ("Select 1 Order!");
			event.returnValue=false;
			Submit2.disabled=false;
		}
	}

	if(event.returnValue!=false){
		if(confirm("Are you sure ?")==false){
			event.returnValue=false;
			Submit2.disabled=false;
		}
		else{
		//myWindow=window.open('RetrieveGoWirelessExport.aspx' ,'popup', 'toolbar=no, status=no, resizable=no, width=180, height=110, scrollbars=no, menu=no');
		        event.returnValue=true;
		}
	}
}

//-->
</script>


</head>
<body>
    <form id="form1" action="RetrieveGoWirelessExport.aspx" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>

    <input id="record_cnt" runat="server" name="record_cnt" type="hidden" />
    
    
     <EW:RepeaterEx ID="admin_view_rp" runat="server" 
            onitemdatabound="admin_view_rp_ItemDataBound" >
    <HeaderTemplate>
    <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <th height="28" colspan="100"><span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></th>
                </tr>
                <tr> 
                  <td height="23" colspan="100" class="row2"> <p> 
                      <input name="submit22" type="button" class="button" value="BACK" onClick="history.go(-1);" style="font-size:7pt" />
                      <input name="submit222" type="button" class="button" value="Select All" onClick="select_all();" style="font-size:7pt" />
                      <input name="submit223" type="button" class="button" value="Select None" onClick="select_none();" style="font-size:7pt" />

                      <asp:Button ID="submit2" Text="Export Selected to Excel" class="mainoption" style="font-size:7pt" OnClientClick="chk_save(this.form);" runat="server" PostBackUrl="~/Web/RetrieveGoWirelessExport.aspx" />
                    </p></td>
                </tr>
                <tr> 
                  <td class="row1"></td>
                  <td class="row1"></td>
                   <td class="row1">&nbsp;</td>
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
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">Actvation Date<br />(MM/DD/YYYY) </span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">Org MRT NO.</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">Remarks to PY Operation</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">Go Wireless VAS</span></td>
                    
	              <td class="row1"><span class="explaintitle" style="font-size:7pt">Monthly Payment Type</span></td>
				  <td class="row1"><span class="explaintitle" style="font-size:7pt">Credit Card Type</span></td>
				  <td class="row1"><span class="explaintitle" style="font-size:7pt">Credit Card No</span></td>
				  <td class="row1"><span class="explaintitle" style="font-size:7pt">Bank Account Holder Name</span></td>
				  <td class="row1"><span class="explaintitle" style="font-size:7pt">Credit Card Expiry Date</span></td>
				  <td class="row1"><span class="explaintitle" style="font-size:7pt">Extra Rebate Amount</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Extra Rebate</span></td>
				  <td class="row1"><span class="explaintitle" style="font-size:7pt">HS Amount</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">HS Rebate Amount</span></td>
				  
                </tr>
    </HeaderTemplate>
    <ItemTemplate>
                    <tr> 
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="viewid" runat=server></asp:Literal></span></td>
                  <td nowrap class="row2"> <input type="checkbox" name="retrieve_id" id="retrieve_id" value='<%# DataBinder.Eval(Container.DataItem, "mid")%>' checked/> </td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="MobileRetentionOrder_id" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "order_id")%>' Visible="false"></asp:Literal><a href="#" onclick='window.open("HistoryReportViewImplement.aspx?order_id=<%# DataBinder.Eval(Container.DataItem,"order_id")%>","_blank","toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=yes, copyhistory=no, width=600, height=200")'>Order History</a></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><a href="#" onClick='window.open("AdminViewHistoryImplement.aspx?order_id=<%# DataBinder.Eval(Container.DataItem, "order_id")%>","_blank","toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=yes, copyhistory=no, width=600, height=200")'><%# Func.IDAdd100000(Convert.ToInt32(DataBinder.Eval(Container.DataItem, "order_id")))%></a></span></td>
                  

                  
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "email_date")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "report_type")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "log_date")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "go_wireless")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "edf_no")%></span></td>
                  

                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "staff_no")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "family_name") +" "+DataBinder.Eval(Container.DataItem, "given_name")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "ord_place_id_type")%>&nbsp; <%# DataBinder.Eval(Container.DataItem, "ord_place_id_type")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "mrt_no")%></span></td>
                  
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "rate_plan")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "trade_field")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "retrieve_sn")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "retrieve_date")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "admin_sn")%></span></td>
                  
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "admin_date")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "register_address")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "gift_imei")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "sim_mrt_no")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "accessory_imei")%></span></td>
                  
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "preferred_languages")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "pay_method")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "accessory_price")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "third_party_credit_card")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "third_party_id_type")%>&nbsp;<%# DataBinder.Eval(Container.DataItem, "third_party_hkid")%></span></td>
                  
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "card_holder")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "card_no")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "card_exp_month")%></span><span class="gensmall" >  / </span><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "card_exp_year")%></span><span class="gensmall" > (MM/YY) </span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "con_eff_date")%><%# NextBill(DataBinder.Eval(Container.DataItem, "next_bill")) %></span></td>
                  
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "org_mrt")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "remarks2PY")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# GetVasValue("gowireless_vas",DataBinder.Eval(Container.DataItem, "order_id"))%></span></td>
                  
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "monthly_payment_method")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "m_card_type")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "m_card_no")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "m_card_holder2")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "m_card_exp_month")%> / <%# DataBinder.Eval(Container.DataItem, "m_card_exp_year")%></span></td>
                  <td nowrap class="row2"><span class="gensmall"  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "extra_rebate_amount")%></span></td>
				<td nowrap class="row2"><span  class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "extra_rebate")%></span></td>
				<td nowrap class="row2"><span class="gensmall"  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "amount")%></span></td>
				<td nowrap class="row2"><span  class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "rebate_amount")%></span></td>
                </tr>
    </ItemTemplate>
    <FooterTemplate>
                    <tr> 
                  <td class="cat" colspan="100">&nbsp;</td>
                </tr>
              </table>
    </FooterTemplate>
    </EW:RepeaterEx>
<table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; View 
<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
</table>       
    
    
    </div>
    </form>
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
</body>
</html>
