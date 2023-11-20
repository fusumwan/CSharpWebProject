<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HistoryReportViewImplement.aspx.cs" Inherits="HistoryReportViewImplement" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Import Namespace="PCCW.RWL.CORE" %>
<%@ Import Namespace="NEURON.ENTITY.FRAMEWORK" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<meta http-equiv="Content-Style-Type" content="text/css" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
<script type="text/javascript">
<!--
function close_win(){
//	return window.location="/cccl/cccl_main.asp";
	return top.location="~/Logout.aspx"
}
//-->
</script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    

    
    <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
              <tr> 
                
    <th height="28" colspan="100"> Order History (<%=Func.IDAdd100000(WebFunc.qsOrder_id)%>)</th>
    <th height="28" colspan="100"></th>
              </tr>
              <tr> 
                <td height="23" colspan="100" class="row2">&nbsp; <span class="explaintitle" style="font-size:9pt">Order Report</span></td>
                <td height="23" colspan="100" class="row2">&nbsp; </td>
              </tr>
              <tr> 
              
              
                <td class="row1">&nbsp;</td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Create Date (MM/DD/YYYY HH:MM)</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Create SN</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Delete Date (MM/DD/YYYY HH:MM)</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Delete SN</span></td>
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
                <td class="row1"><span class="explaintitle" style="font-size:7pt">FTG</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Original Tariff Fee</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Autoroll</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Program </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Rate Plan</span></td>
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
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Early Start</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">VAS Effective Date (MM/DD/YYYY)</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Rate Plan Effective Date (MM/DD/YYYY)</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Contract Effective Date (MM/DD/YYYY)</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">POS Reference No</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">HS Model </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">SKU Item Code</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">IMEI No</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Premium</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Special Premium</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Special Premium1</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Special Premium2</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Special Premium3</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Special Premium4</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Special Premium Delivery Date (MM/DD/YYYY) </span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Special Premium Quota Reference No</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Delivery Address </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Delivery Date (MM/DD/YYYY) &amp; Time </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Delivery Charge for special region </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Contact Person </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Contact No. </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">2nd Contact No. </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Payment Method </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Credit Card Type </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Credit Card No. </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Bank Account Holder Name </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Credit Card Expiry Date </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Bank Code</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Bank Name</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">HS Amount</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Remarks</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Action Required</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Waive</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Suspend Date (MM/DD/YYYY)</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Existing Plan</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Reasons</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Staff No</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Staff Name</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Teamcode</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Team Leader</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Salesman Code</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Channel</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Refer Staff No</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Refer Salesmancode</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Order Placed By</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Relationship</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">HKID No/ Passport No</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Contact No</span></td>
		        <td class="row1"><span class="explaintitle" style="font-size:7pt">Monthly Payment Type </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Monthly Payment Credit Card Type </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Monthly Payment Credit Card No. </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Monthly Payment Bank Account Holder Name </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Monthly Payment Credit Card Expiry Date </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">OB Program ID</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Bill Cut Date</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Change Payment Type</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Gender</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Date Of Birth</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Redemption Notice</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Email Address</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Accessory Waive</span></td>
                <% VasHeaderShow(); %>
              </tr>
              <tr> 
                <td class="row3" colspan="100"><span class="explaintitle" style="font-size:7pt">Current</span></td>
                <td class="row3" colspan="100"></td>
              </tr>
              <% SearchReportShow1(); %>
              
              <tr> 
                <td class="row3" colspan="100"><span class="explaintitle" style="font-size:7pt">History</span></td>
                 <td class="row3" colspan="100"></td>
             </tr>
             <% SearchReportShow2(); %>

              <tr> 
                <td class="cat" colspan="100">&nbsp;</td>
                <td class="cat" colspan="100">&nbsp;</td>
              </tr>
 
            </table>

            
            <br>
  <input name="button" type="button" onClick="window.close()" value="CLOSE" class="button" style="font-size:7pt">
    </div>
    </form>
</body>
</html>
