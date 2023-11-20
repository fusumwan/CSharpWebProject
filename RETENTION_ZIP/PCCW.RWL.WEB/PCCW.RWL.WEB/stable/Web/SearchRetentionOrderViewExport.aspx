<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SearchRetentionOrderViewExport.aspx.cs" Inherits="SearchRetentionOrderViewExport" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Import Namespace="PCCW.RWL.CORE" %>
<%@ Import Namespace="NEURON.ENTITY.FRAMEWORK" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<meta http-equiv="Content-Style-Type" content="text/css" />
<title>3G Retention - Web Log</title>
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
<script type="text/javascript">
<!--
function close_win(){
//	return window.location="/cccl/cccl_main.asp";
	return top.location="~/Logout.aspx"
}
//-->
</script>
    <style type="text/css">
        .style1
        {
            background: #eaedf4;
            width: 36px;
        }
        .style2
        {
            background: #d9e2ec;
            width: 36px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
              <tr> 
                <td><span>Record ID</span></td>
                <td><span>Cancelled</span></td>
                <td><span>Status</span></td>
                <td><span>EDF No</span></td>
                <td><span>Old Order ID</span></td>
                <td><span>Log Date<br />(MM/DD/YYYY HH:MM)</span></td>
                <td><span>Customer Name </span></td>
                <td><span>Customer Type </span></td>
                <td><span>Account No.</span></td>
                <td><span>Issue Type</span></td>
                <td><span>MRT No </span></td>
                <td><span>HKID No </span></td>
                <td><span>VIP Customer</span></td>
                <td><span>Existing Customer Type</span></td>
                <td><span>Original Tariff Fee</span></td>
                <td><span>Autoroll</span></td>
                <td><span>PCD Paid Go Wireless</span></td>
                <td><span>Program</span></td>
                <td><span>Rate Plan</span></td>
                <td><span>Normal Rebate Type</span></td>
                <td><span>LOB Type</span></td>
                <td><span>LOB Account No</span></td>
                <td><span>Contract Period </span></td>
                <td><span>Trade Field</span></td>
                <td><span>Bundle Name</span></td>
                <td><span>Rebate</span></td>
                <td><span>Monthly Rebate Amount </span></td>
                <td><span>HS Rebate Amount </span></td>
                 <td><span>Retention Offer</span></td>
                <td><span>Extra Rebate</span></td>
                <td><span>Extra Rebate Amount</span></td>
                <td><span>Free Monthly Fee</span></td>
                <td><span>Cancel Auto Renewal</span></td>
                <td><span>Free Gift Code</span></td>
                <td><span>Free Gift IMEI</span></td>
                <td><span>Free Gift Description</span></td>
                <td><span>Free Gift Code2</span></td>
                <td><span>Free Gift IMEI2</span></td>
                <td><span>Free Gift Description2</span></td>
                <td><span>Free Gift Code3</span></td>
                <td><span>Free Gift IMEI3</span></td>
                <td><span>Free Gift Description3</span></td>
                <td><span>Free Gift Code4</span></td>
                <td><span>Free Gift IMEI4</span></td>
                <td><span>Free Gift Description4</span></td>
                <td><span>Accessory Code</span></td>
                <td><span>Accessory IMEI</span></td>
                <td><span>Accessory Description</span></td>
                <td><span>Price of Accessory</span></td>
                <td><span>AIG Free Gift</span></td>
                <td><span>Special Approval</span></td>
                <td><span>Early  Start</span></td>
                <td><span>VAS Effective Date<br> (MM/DD/YYYY)</span></td>
                <td><span>Rate Plan Effective Date<br>(MM/DD/YYYY)</span></td>
                <td><span>Contract Effective Date<br>(MM/DD/YYYY)</span></td>
                <td><span>Bill Cut Date</span></td>
                <td><span>POS Reference No</span></td>
                <td><span>HS Model </span></td>
                <td><span>SKU Item Code</span></td>
                <td><span>IMEI No</span></td>
				<td><span>Premium</span></td>
				<td><span>Special Premium</span></td>
				<td><span>Special Premium Delivery Date<br>(MM/DD/YYYY)</span></td>
				<td><span>Special Premium Quota Reference No</span></td>
				<td><span>Special Premium1</span></td>
				<td><span>Special Premium2</span></td>
				<td><span>Special Premium3</span></td>
				<td><span>Special Premium4</span></td>
                <td><span>Delivery Address </span></td>
                <td><span>Delivery Date  (MM/DD/YYYY) &amp; Time </span></td>
                <td><span>Delivery Charge for special region </span></td>
                <td><span>Contact Person </span></td>
                <td><span>Contact No. </span></td>
                <td><span>Payment Method </span></td>
                <td><span>Credit Card Type </span></td>
                <td><span>Credit Card No. </span></td>
                <td><span>Credit Card Holder Name </span></td>
                <td><span>Credit Card Expiry Date </span></td>
                <td><span>Bank Code</span></td>
                <td><span>Bank Name</span></td>
                <td><span>HS Amount</span></td>
                <td><span>Remarks</span></td>
                <td><span>Remarks to EDF</span></td>
                <td><span>Remarks to PY Operation</span></td>
                <td><span>Action Required</span></td>
                <td><span>Waive</span></td>
                <td><span>Suspend Date<br> (MM/DD/YYYY)</span></td>
                <td><span>Existing Plan</span></td>
                <td><span>Reasons</span></td>
                <td><span>Staff No</span></td>
                <td><span>Staff Name</span></td>
                <td><span>Teamcode</span></td>
                <td><span>Team Leader</span></td>
                <td><span>Salesman Code</span></td>
                <td><span>Refer Staff No</span></td>
                <td><span>Refer SalesmanCode</span></td>
                <td><span>Channel</span></td>
                <td><span>OB Program ID</span></td>
                <td><span>Existing Contract End Month</span></td>
                <td><span>Order Placed By</span></td>
                <td><span>Relationship</span></td>
                <td><span>HKID No/ Passport No</span></td>
                <td><span>Contact No</span></td>
                <td><span>2nd. Contact  No. </span></td>
                <td><span>Monthly Payment Method </span></td>
                <td><span>Monthly Payment Credit Card Type </span></td>
                <td><span>Monthly Payment Credit Card No. </span></td>
                <td><span>Monthly Payment Credit Card Holder Name </span></td>
                <td><span>Monthly Payment Credit Card Expiry Date </span></td>
                <td><span>SIM Card Name </span></td>
                <td><span>SIM Item Code </span></td>
                <td><span>Redemption Notice Option</span></td>
                <td><span>Email</span></td>
                <td><span>Accessory Waive</span></td>
                <% VasHeaderShow(); %>
              </tr>
              <% SearchReportShow(); %>
              </table>
   
    </div>
    </form>
</body>
</html>
<% ExportExcel(); %>
