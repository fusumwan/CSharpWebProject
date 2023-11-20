<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminOptOutViewImplement.aspx.cs" Inherits="AdminOptOutViewImplement" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register TagName="RWLMenu2" TagPrefix="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE" %>
<%@ Import Namespace="NEURON.ENTITY.FRAMEWORK" %>
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
//	return window.location="/cccl/cccl_main.asp";
    return top.location ="~/Logout.aspx"
}

function select_all(){
    var RecordCnt = document.getElementById('record_cnt');
    var RetrieveId = document.getElementsByName('retrieve_id');
    
    if(RecordCnt==undefined) return false;
    if(RetrieveId==undefined) return false;
	if ('1'!=RecordCnt.value){
		for (i=0;i<RetrieveId.length;++ i)
			document.all.retrieve_id[i].checked=true
	}
	else
		document.all.retrieve_id.checked=true
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
		        myWindow=window.open('RetrieveOptOutViewExport.aspx' ,'popup', 'toolbar=no, status=no, resizable=no, width=180, height=110, scrollbars=no, menu=no');
		        event.returnValue=false;
	   }
	}
}

//-->
</script>
</head>
<body>

    <form id="form1" action="RetrieveOptOutViewExport.aspx" runat="server" method="post" name="newform" >
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>

    <input id="record_cnt" runat="server" name="record_cnt" type="hidden" />
    <EW:RepeaterEx ID="admin_view_rp" runat="server" 
            onitemdatabound="admin_view_rp_ItemDataBound">
    <HeaderTemplate>
                    <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                  <tr>
                    <th height="28" colspan="101"><span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></th>
                  </tr>
                  <tr>
                    <td height="23" colspan="101" class="row2"><input name="submit22" type="button" class="button" value="BACK" onClick="history.go(-1);" style="font-size:7pt" />
                    </td>
                  </tr>
                  <tr>
                    <td class="row1">&nbsp;</td>
                    <td class="row1">&nbsp;</td>
                    <td class="row1"><span class="explaintitle" style="font-size:7pt">Record ID</span></td>
                    <td class="row1"><span class="explaintitle" style="font-size:7pt">Sent Date(MM/DD/YYYY)</span></td>
                    <td class="row1"><span class="explaintitle" style="font-size:7pt">Report  Name</span></td>
                    <td class="row1"><span class="explaintitle" style="font-size:7pt">Log Date(MM/DD/YY HH:MM)</span></td>
                    <td class="row1"><span class="explaintitle" style="font-size:7pt">Customer  Name </span></td>
                    <td class="row1"><span class="explaintitle" style="font-size:7pt">Account No.</span></td>
                    <td class="row1"><span class="explaintitle" style="font-size:7pt">MRT No </span></td>
                    <td class="row1"><span class="explaintitle" style="font-size:7pt">Autoroll </span></td>
                    <td class="row1"><span class="explaintitle" style="font-size:7pt">PCD PAID Go Wireless</span></td>
                    <td class="row1"><span class="explaintitle" style="font-size:7pt">Rate Plan</span></td>
                    <td class="row1"><span class="explaintitle" style="font-size:7pt">Contract Period </span></td>
                    <td class="row1"><span class="explaintitle" style="font-size:7pt">Trade Field</span></td>
                    <td class="row1"><span class="explaintitle" style="font-size:7pt">Bundle Name</span></td>
                    <td class="row1"><span class="explaintitle" style="font-size:7pt">Rebate</span></td>
                    <td class="row1"><span class="explaintitle" style="font-size:7pt">Cancel Auto Renewal</span></td>
                    <td class="row1"><span class="explaintitle" style="font-size:7pt">Action  Required</span></td>
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
                    <td class="row1"><span class="explaintitle" style="font-size:7pt">Retrieved Date(MM/DD/YY HH:MM)</span></td>
                    <td class="row1"><span class="explaintitle" style="font-size:7pt">Last Updated By</span></td>
                    <td class="row1"><span class="explaintitle" style="font-size:7pt">Last Update Date(MM/DD/YY HH:MM)</span></td>
                    <td class="row1"><span class="explaintitle" style="font-size:7pt">Order Placed By</span></td>
                    <td class="row1"><span class="explaintitle" style="font-size:7pt">Relationship</span></td>
                    <td class="row1"><span class="explaintitle" style="font-size:7pt">HKID No/ Passport No</span></td>
                    <td class="row1"><span class="explaintitle" style="font-size:7pt">Delivery Date (MM/DD/YYYY)</span></td>
                    <td class="row1"><span class="explaintitle" style="font-size:7pt">Customer Staff No </span></td>
                    <td class="row1"><span class="explaintitle" style="font-size:7pt">Remarks to PY Operation</span></td>
                    <td class="row1"><span class="explaintitle" style="font-size:7pt">Old Order ID</span></td>
                    <td class="row1"><span class="explaintitle" style="font-size:7pt">Extra Rebate Amount</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Extra Rebate</span></td>
                    <td class="row1"><span class="explaintitle" style="font-size:7pt">HS Amount</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">HS Rebate Amount</span></td>
                  </tr>
    </HeaderTemplate>
    <ItemTemplate>
    
                      <tr>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="viewid" runat="server"></asp:Literal></span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><a href="#" onclick='window.open("HistoryReportViewImplement.aspx?order_id=<%# DataBinder.Eval(Container.DataItem, "order_id")%>","_blank","toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=yes, copyhistory=no, width=600, height=200")'>Order History</a></span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><a href="#" onClick='window.open("AdminViewHistoryImplement.aspx?order_id=<%# DataBinder.Eval(Container.DataItem, "order_id")%>","_blank","toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=yes, copyhistory=no, width=600, height=200")'><%# Func.IDAdd100000(Convert.ToInt32(DataBinder.Eval(Container.DataItem, "order_id")))%></a></span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"> <%# DataBinder.Eval(Container.DataItem, "email_date")%> </span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "report_type")%></span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "log_date")%></span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "family_name") +" "+DataBinder.Eval(Container.DataItem, "given_name")%></span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "ac_no")%></span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "mrt_no")%></span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="accept" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "accept")%>'></asp:Literal></span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "rwl_pcd_paid_go_wireless")%></span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "rate_plan")%></span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "con_per")%></span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "trade_field")%></span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "bundle_name")%></span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "rebate")%></span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "cancel_renew")%></span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "action_required")%></span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "action_eff_date")%> </span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "exist_plan")%></span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "reasons")%></span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "staff_no")%></span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "salesmancode")%></span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "order_status")%></span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "fallout_main_category")%></span></td>
					<td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "fallout_reason")%></span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "fallout_remark")%></span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "fallout_reply")%></span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "retrieve_sn")%></span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "retrieve_date")%></span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "admin_sn")%></span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "admin_date")%></span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "ord_place_by")%></span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "ord_place_rel")%></span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "ord_place_id_type")%>&nbsp;<%# DataBinder.Eval(Container.DataItem, "ord_place_hkid")%></span> </td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "d_date")%> </span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "cust_staff_no")%></span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "remarks2PY")%></span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="old_ord_id" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "old_ord_id")%>'></asp:Literal></span></td>
                    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "extra_rebate_amount")%></span></td>
				    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "extra_rebate")%></span></td>
				    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "amount")%></span></td>
				    <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "rebate_amount")%></span></td>
                  </tr>
    
    </ItemTemplate>
    <FooterTemplate>
                      <tr>
                    <td class="cat" colspan="101">&nbsp;</td>
                  </tr>
                </table>
    </FooterTemplate>
    </EW:RepeaterEx>
    
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
</body>
</html>
