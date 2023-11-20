<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RetrieveOptOutViewAction.aspx.cs" Inherits="RetrieveOptOutViewAction" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Import Namespace="PCCW.RWL.CORE" %>
<%@ Import Namespace="NEURON.ENTITY.FRAMEWORK" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
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
		//myWindow=window.open('RetrieveOptOutViewExport.aspx' ,'popup', 'toolbar=no, status=no, resizable=no, width=180, height=110, scrollbars=no, menu=no');
		        event.returnValue=true;
		}
	}
}

//-->
</script>

</head>
<body>

   <form action="RetrieveOptOutViewExport.aspx" method="post" name="form1" id="form1" runat="server">
   <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>

        <input type="hidden" name="record_cnt" id="record_cnt" runat="server" />
        <EW:RepeaterEx ID="admin_view_rp" runat="server" 
            onitemdatabound="admin_view_rp_ItemDataBound">
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

                      <asp:Button ID="submit2" Text="Export Selected to Excel" class="mainoption" style="font-size:7pt" OnClientClick="chk_save(this.form);" runat="server" PostBackUrl="~/Web/RetrieveOptOutViewExport.aspx" />
                    </p></td>
                </tr>
                <tr> 
                  <td class="row1"></td>
                  <td class="row1"></td>
                <td class="row1">&nbsp;</td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">Record 
                    ID</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">Report 
                    Name</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">Log 
                    Date<br />
                    (MM/DD/YYYY HH:MM)</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">Customer 
                    Name </span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">Account 
                    No.</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">MRT 
                    No </span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">Action 
                    Required</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">Waive</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">Suspend 
                    Date (MM/DD/YYYY)</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">Reasons</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">Order 
                    Placed By</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">Relationship</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">HKID 
                    No/ Passport No</span></td>
                 <td class="row1"><span class="explaintitle" style="font-size:7pt">Remarks to PY Operation</span></td>
                 <td class="row1"><span class="explaintitle" style="font-size:7pt">Old 
                    Order ID</span></td>
                 <td class="row1"><span class="explaintitle" style="font-size:7pt">Staff No</span></td>
                 
                 <td class="row1"><span class="explaintitle" style="font-size:7pt">Extra Rebate Amount</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Extra Rebate</span></td>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
                        <tr> 
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="viewid" runat="server"></asp:Literal></span></td>
                  <td nowrap class="row2"> <input type="checkbox" name="retrieve_id" id="retrieve_id" value="<%# DataBinder.Eval(Container.DataItem, "mid")%>" checked/></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><a href="#" onclick='window.open("HistoryReportViewImplement.aspx?order_id=<%# DataBinder.Eval(Container.DataItem,"order_id")%>","_blank","toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=yes, copyhistory=no, width=600, height=200")'>Order History</a></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><a href="#" onClick='window.open("AdminViewHistoryImplement.aspx?order_id=<%# DataBinder.Eval(Container.DataItem, "order_id")%>","_blank","toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=yes, copyhistory=no, width=600, height=200")'><%# Func.IDAdd100000(Convert.ToInt32(DataBinder.Eval(Container.DataItem, "order_id")))%></a></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "report_type")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "log_date")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "family_name") +" "+DataBinder.Eval(Container.DataItem, "given_name")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "ac_no")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "mrt_no")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "action_required")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"> <asp:Literal ID="waive" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "waive")%>' ></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "action_eff_date")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "reasons")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "ord_place_by")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "ord_place_rel")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "ord_place_id_type")%>&nbsp;<%# DataBinder.Eval(Container.DataItem, "ord_place_hkid")%></span></td>
               	  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "remarks2PY")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="old_ord_id" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "old_ord_id")%>' ></asp:Literal></span></td>
               	  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "staff_no")%></span></td>
               	  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "extra_rebate_amount")%></span></td>
				  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "extra_rebate")%></span></td>
               	  
               	  
                </tr>
        </ItemTemplate>
        <FooterTemplate>
                        <tr> 
                  <td class="cat" colspan="100">&nbsp;</td>
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
