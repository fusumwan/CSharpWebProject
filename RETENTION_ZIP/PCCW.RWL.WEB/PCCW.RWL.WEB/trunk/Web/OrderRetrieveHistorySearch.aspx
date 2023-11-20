<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderRetrieveHistorySearch.aspx.cs" Inherits="Web_OrderRetrieveHistorySearch" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE" %>
<%@ Import Namespace="NEURON.ENTITY.FRAMEWORK" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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

function chk_search(ThisForm) {

    if (event.returnValue != false)
        ThisForm.submit()

}
</script>
</head>
<body style="background-color:#ffffff">
    <form id="form2" action="OrderRetrieveHistorySearch.aspx" method="post" name="newform" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
    <asp:ScriptManager ID="AddWebLogScriptManager" runat="server"></asp:ScriptManager>
              <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <th height="28" colspan="4">&nbsp;<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></th>
                </tr>
                <tr> 
                  <td height="23" colspan="4" class="row2">
                    <input type="button" name="submitSearch" value="SEARCH RETRIEVE HISTORY" class="mainoption"  onclick="chk_search(this.form);" onKeyDown="return false;" style="font-size:7pt"/> 
                    <input name="submit22" type="button" class="button" value="BACK TO SEARCH ORDER" onClick="location.href='AdminView.aspx'" style="font-size:7pt" />
                    </td>
                </tr>
                <tr> 
                  <td width="23%" height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Record 
                    ID</span></td>
                  <td width="77%" height="0" class="row1"> <input name="<%=WebFunc.qsOrder_idName %>" type="text" id="order_id" style="font-size:7pt" size="10" maxlength="10" onBlur="isNum(this);"/>
                    TO 
                    <input name="order_id2" type="text" id="<%=WebFunc.qsOrder_id2Name %>" style="font-size:7pt" size="10" maxlength="10" onBlur="isNum(this);"/></td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Sent Date</span></td>
                  <td height="0" class="row1">
                  <asp:TextBox ID="email_date" Font-Size="7pt" ReadOnly="false" MaxLength="10" runat="server" ></asp:TextBox>
                  <asp:ImageButton runat="server" ID="fromEmailDateImageButton" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                    (MM/DD/YYYY) TO 
                   <asp:TextBox ID="email_date2" Font-Size="7pt" ReadOnly="false" MaxLength="10" runat="server" ></asp:TextBox>
                    <asp:ImageButton runat="server" ID="toEmailDateImageButton" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                    (MM/DD/YYYY)</td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Report 
                    Name</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                    <select name="<%=WebFunc.qsReport_typeName %>" id="Select1" style="font-size:7pt" >
                      <option value="">All except Change VAS/Customer Details</option>
                      <option value="rwl_suspend">Suspension (rwl_suspend)</option>
                      <option value="rwl_mod">Modification (rwl_mod)</option>
                      <option value="rwl_wo_hs">New non-HS Order (rwl_wo_hs)</option>
                      <option value="rwl_w_hs">New HS Order (rwl_w_hs)</option>
                      <option value="rwl_del">Cancellation (rwl_del)</option>
                      <option value="rwl_vas">Change VAS (rwl_vas)</option>
                      <option value="rwl_go_wireless">GO wireless(rwl_go_wireless)</option>
                      <option value="rwl_cust">Change Customer Details (rwl_cust)</option>
                      <option value="rwl_fast">New Early Start Order (rwl_fast)</option>
                      <option value="rwl_NDS">New NDS Order (rwl_NDS)</option>
                      <option value="rwl_opt_out">OPT OUT Order(rwl_opt_out)</option>
                      <option value="rwl_mod_w_con">Modification With Contract(rwl_mod_w_con)</option>
                      <option value="rwl_ml">Mobile Lite (rwl_ml)</option>
                      <option value="rwl_ml_mod">Mobile Lite Modification Report(rwl_ml_mod)</option>
                      <option value="rwl_ml_del">Mobile Lite Cancellation(rwl_ml_del)</option>
					  </select>
                    </span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Status 
                    </span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  
                    <select name="<%=WebFunc.qsOrder_statusName %>" id="order_status" style="font-size:7pt" >
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
                  <td width="23%" height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Retrieve SN</span></td>
                  <td width="77%" height="0" class="row1"> <input name="<%=WebFunc.qsRetrieve_snName %>" type="text" id="retrieve_sn" style="font-size:7pt" size="10" maxlength="10"/></td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Retrieve Date</span></td>
                  <td height="0" class="row1">
                  <asp:TextBox ID="retrieve_date" Font-Size="7pt" ReadOnly="false" MaxLength="10" runat="server" ></asp:TextBox>
                  <asp:ImageButton runat="server" ID="fromRetrieveDateImageButton" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                    (MM/DD/YYYY) TO 
                   <asp:TextBox ID="retrieve_date2" Font-Size="7pt" ReadOnly="false" MaxLength="10" runat="server" ></asp:TextBox>
                    <asp:ImageButton runat="server" ID="toRetrieveDateImageButton" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                    (MM/DD/YYYY)</td>
                </tr>
                
                
                <tr> 
                  <td width="23%" height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Resend to PY by</span></td>
                  <td width="77%" height="0" class="row1"> <input name="<%=WebFunc.qsReactive_snName %>" type="text" id="reactive_sn" style="font-size:7pt" size="10" maxlength="10"/></td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Resend to PY Date</span></td>
                  <td height="0" class="row1">
                  <asp:TextBox ID="reactive_date" Font-Size="7pt" ReadOnly="false" MaxLength="10" runat="server" ></asp:TextBox>
                  <asp:ImageButton runat="server" ID="fromReactiveDateImageButton" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                    (MM/DD/YYYY) TO 
                   <asp:TextBox ID="reactive_date2" Font-Size="7pt" ReadOnly="false" MaxLength="10" runat="server" ></asp:TextBox>
                    <asp:ImageButton runat="server" ID="toReactiveDateImageButton" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                    (MM/DD/YYYY)</td>
                </tr>
                
                
                
                
              </table>
     </div><br /><br />       
<!-------------------------------------------------------------------------------------------------->
<!--------------------End of Search AND Start of the report ---------------------------------------->
<!-------------------------------------------------------------------------------------------------->
    <div>
    <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
   <tr> 
    <td height="23" colspan="100" class="row3"><span class="explaintitle" style="font-size:7pt">Status History</span></td>
  <tr> 
    <td class="row1">&nbsp;</td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Order ID</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Sent Date<br />
      (MM/DD/YYYY)</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Report Name</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Order Status</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Reason</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Remark</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Reply</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Retrieve SN</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Retrieve 
      Date<br>(MM/DD/YYYY HH:MM)</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Created by</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Create Date<br>(MM/DD/YYYY HH:MM)</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Deleted by</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Delete Date<br>(MM/DD/YYYY HH:MM)</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Re-send To PY by</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Re-send To PY Date<br>(MM/DD/YYYY HH:MM)</span></td>
  </tr>
    

  </tr>
    <EW:RepeaterEx ID="order_retrieve_history_rp" runat="server" 
            onitemdatabound="order_retrieve_history_rp_ItemDataBound">
    <ItemTemplate>
    <tr>
    <td nowrap class="row2"><span  style="font-size:7pt"><%/*asp:Literal ID="viewid" runat="server"></asp:Literal */ %></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# Func.IDAdd100000(Convert.ToInt32(DataBinder.Eval(Container.DataItem, "order_id")))%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "email_date")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><asp:Literal ID="report_type" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "report_type")%>'></asp:Literal></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "order_status")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "fallout_reason")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "fallout_remark")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "fallout_reply")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "retrieve_sn")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "retrieve_date")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "cid")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "cdate")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "did")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "ddate")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "reactive_sn")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "reactive_date")%></span></td>
    </tr>
    </ItemTemplate>
    </EW:RepeaterEx>
  <tr> 
    <td class="cat" colspan="100">&nbsp;</td>
  </tr>
</table>
    </div>
    
    <cc1:CalendarExtender runat="server" 
        ID="EmailDateCalendarExtender1"
        TargetControlID="email_date"
        Format="MM/dd/yyyy"
        PopupButtonID="fromEmailDateImageButton" /> 
              
    <cc1:CalendarExtender runat="server" 
        ID="EmailDateCalendarExtender2"
        TargetControlID="email_date2"
        Format="MM/dd/yyyy"
        PopupButtonID="toEmailDateImageButton" />
        
    <cc1:CalendarExtender runat="server" 
        ID="RetrieveDateCalendarExtender1"
        TargetControlID="retrieve_date"
        Format="MM/dd/yyyy"
        PopupButtonID="fromRetrieveDateImageButton" /> 
              
    <cc1:CalendarExtender runat="server" 
        ID="RetrieveDateCalendarExtender2"
        TargetControlID="retrieve_date2"
        Format="MM/dd/yyyy"
        PopupButtonID="toRetrieveDateImageButton" />
          
    <cc1:CalendarExtender runat="server" 
        ID="ReactiveDateCalendarExtender3"
        TargetControlID="reactive_date"
        Format="MM/dd/yyyy"
        PopupButtonID="fromReactiveDateImageButton" /> 
              
    <cc1:CalendarExtender runat="server" 
        ID="ReactiveDateCalendarExtender4"
        TargetControlID="reactive_date2"
        Format="MM/dd/yyyy"
        PopupButtonID="toReactiveDateImageButton" />
    </form>
</body>
</html>
