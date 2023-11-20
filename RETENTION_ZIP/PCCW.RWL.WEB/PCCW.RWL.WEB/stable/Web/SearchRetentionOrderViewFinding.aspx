<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SearchRetentionOrderViewFinding.aspx.cs" Inherits="SearchRetentionOrderViewFinding" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE" %>
<%@ Import Namespace="NEURON.ENTITY.FRAMEWORK" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>3G Retention - Web Log</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<link href="../Resources/Scripts/CalendarControl/CalendarControl.css" rel="Stylesheet" type="text/css" />
<script src="../Resources/Scripts/CalendarControl/CalendarControl.js" language="javascript"></script>
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<script type="text/javascript">
<!--
function close_win(){
//	return window.location="/cccl/cccl_main.asp";
	return top.location="~/Logout.aspx"
}
function HideLoading(){
document.getElementById("LoadingData").style.display="none";
}
//-->
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>

            <asp:Button ID="BackSearch" runat="server" Text="Back" CssClass="button" PostBackUrl="~/Web/SearchRetentionOrderView.aspx" />      
            <span id="LoadingData" style="font-size:larger">Loading......................................</span> 
              <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
              <tr> 
                <td class="row1">&nbsp;</td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Record ID</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Cancelled</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Status</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">EDF No</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Old Order ID</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Log Date<br />(MM/DD/YYYY HH:MM)</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Customer Name </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Customer Type </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Account No.</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Issue Type</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">MRT No </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">HKID No </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">VIP Customer</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Existing Customer Type</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Original Tariff Fee</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Autoroll</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">PCD Paid Go Wireless</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Program</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Rate Plan</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Nomal Rebate Type</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">LOB Type</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">LOB Account No</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Contract Period </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Trade Field</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Bundle Name</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Rebate</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Monthly Rebate Amount </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">HS Rebate Amount </span></td>
                 <td class="row1"><span class="explaintitle" style="font-size:7pt">Retention Offer</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Extra Rebate</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Extra Rebate Amount</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Free Monthly Fee</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Cancel Auto Renewal</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Free Gift Code</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Free Gift IMEI</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Free Gift Description</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Free Gift Code2</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Free Gift IMEI2</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Free Gift Description2</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Free Gift Code3</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Free Gift IMEI3</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Free Gift Description3</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Free Gift Code4</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Free Gift IMEI4</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Free Gift Description4</span></td>
               <td class="row1"><span class="explaintitle" style="font-size:7pt">Accessory Code</span></td>
               <td class="row1"><span class="explaintitle" style="font-size:7pt">Accessory IMEI</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Accessory Description</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Price of Accessory</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">AIG Free Gift</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Special Approval</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Early  Start</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">VAS Effective Date<br> (MM/DD/YYYY)</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Rate Plan Effective Date<br>(MM/DD/YYYY)</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Contract Effective Date<br>(MM/DD/YYYY)</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Bill Cut Date</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">POS Reference No</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">HS Model </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">SKU Item Code</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">IMEI No</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Premium</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Special Premium</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Special Premium Delivery Date<br>(MM/DD/YYYY)</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Special Premium Quota Reference No</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Special Premium1</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Special Premium2</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Special Premium3</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Special Premium4</span></td>
               <td class="row1"><span class="explaintitle" style="font-size:7pt">Delivery Address </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Delivery Date (MM/DD/YYYY) &amp; Time </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Delivery Charge for special region </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Contact Person </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Contact No. </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Payment Method </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Credit Card Type </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Credit Card No. </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Credit Card Holder Name </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Credit Card Expiry Date </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Bank Code</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Bank Name</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">HS Amount</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Remarks</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Remarks to EDF</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Remarks to PY Operation</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Action Required</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Waive</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Suspend Date<br> (MM/DD/YYYY)</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Existing Plan</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Reasons</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Staff No</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Staff Name</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Teamcode</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Team Leader</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Salesman Code</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Refer Staff No</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Refer SalesmanCode</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Channel</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">OB Program ID</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Existing Contract End Month</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Order Placed By</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Relationship</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">HKID No/ Passport No</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Contact No</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">2nd. Contact  No. </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Monthly Payment Method </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Monthly Payment Credit Card Type </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Monthly Payment Credit Card No. </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Monthly Payment Credit Card Holder Name </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Monthly Payment Credit Card Expiry Date </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">SIM Card Name </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">SIM Item Code </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Redemption Notice Option</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Email</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Accessory Waive</span></td>
                <% VasHeaderShow(); %>
              </tr>
              <% SearchReportShow(); %>
              </table>
              
              

<table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; View 
<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
</table>       
    </div>
    </form>
</body>
</html>
