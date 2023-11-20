<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminForViewExport.aspx.cs" Inherits="AdminForViewExport" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>

<%@ Import Namespace="PCCW.RWL.CORE" %>
<%@ Import Namespace="NEURON.ENTITY.FRAMEWORK" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>3G Retention - Web Log</title>
    <meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
</head>

<body>
    <form id="form1" runat="server">
    <div>

    
    <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
  <tr> 
    <td class="row1">&nbsp;</td>
    <td class="row1">Record ID</td>
    <td class="row1">Report Name</td>
    <td class="row1">Log Date<br />(MM/DD/YYYY HH:MM)</td>
    <td class="row1">Customer Name </td>
    <td class="row1">Account No.</td>
    <td class="row1">MRT No</td>
    <td class="row1">Autoroll</td>
    <td class="row1">PCD PAID Go Wireless</td>
    <td class="row1">Rate Plan</td>
    <td class="row1">Contract Period </td>
    <td class="row1">Trade Field</td>
    <td class="row1">Bundle Name</td>
    <td class="row1">Free Monthly Fee</td>
    <td class="row1">Rebate</td>
    <td class="row1">Cancel Auto Renewal</td>
    <td class="row1">HS Model</td>
    <td class="row1">Premium</td>
    <td class="row1">Rate Plan Effective Date<br>(MM/DD/YYYY)</td>
    <td class="row1">Contract Effective Date<br>(MM/DD/YYYY)</td>
    <td class="row1">Action Required</td>
    <td class="row1">Waive</td>
    <td class="row1">Suspend Date (MM/DD/YYYY)</td>
    <td class="row1">Order Placed By</td>
    <td class="row1">Relationship</td>
    <td class="row1">HKID No/Passport No</td>
    <td class="row1">Status</td>
	<td class="row1">Fallout main category</td>
    <td class="row1">Fallout Reason</td>
    <td class="row1">Fallout Remark</td>
    <td class="row1">Fallout Reply</td>
    <td class="row1">Special Premium</td>
    <td class="row1">Special Premium1</td>
    <td class="row1">Special Premium2</td>
	<td class="row1">Special Premium3</td>
	<td class="row1">Special Premium4</td>
    <td class="row1">EDF No</td>
    <td class="row1">Delivery Date (MM/DD/YYYY)</td>
	<td class="row1">Customer Staff No </td>
    <td class="row1">Remarks to PY Operation</td>
    <td class="row1">Old Order ID</td>
    <td class="row1">Staff No</td>
    <td class="row1">Extra Rebate Amount</td>
	<td class="row1">Extra Rebate</td>
    <td class="row1">HS Amount</td>
	<td class="row1">HS Rebate Amount</td>
	<td class="row1">Email Address</td>
                
      <% VasHeaderShow(); %>

  </tr>
  <% SearchReportShow(); %>
  

            </table>
    </div>
    </form>
</body>
</html>
<% ExportExcel(); %>