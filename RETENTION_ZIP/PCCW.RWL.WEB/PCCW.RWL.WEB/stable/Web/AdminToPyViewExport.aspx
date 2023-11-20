<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminToPyViewExport.aspx.cs" Inherits="AdminToPyViewExport" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Import Namespace="PCCW.RWL.CORE" %>
<%@ Import Namespace="NEURON.ENTITY.FRAMEWORK" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
                <table>
                <tr> 
                <td >&nbsp;</td>
                <td >Record ID</td>
                <td >Active</td>
                <td >Report Name</td>
                <td >Log Date<br />(MM/DD/YYYY HH:MM)</td>
                <td >Customer Name </td>
                <td >Account No.</td>
                <td >MRT No </td>
                <td >Autoroll </td>
                <td >PCD PAID Go Wireless</td>
                <td >Rate Plan</td>
                <td >Contract Period </td>
                <td >Trade Field</td>
                <td >Bundle Name</td>
                <td >Free Monthly Fee</td>
                <td >Rebate</td>
                <td >Cancel Auto Renewal</td>
                <td >HS Model</td>
                <td >Premium </td>
                <td >Rate Plan Effective Date<br>(MM/DD/YYYY)</td>
                <td >Contract Effective Date<br>(MM/DD/YYYY)</td>
                <td >Bill Cut Date</td>
                <td >Action Required</td>
                <td >Waive</td>
                <td >Suspend Date<br>(MM/DD/YYYY)</td>
                <td >Order Placed By</td>
                <td >Relationship</td>
                <td >HKID No/ Passport No</td>
                <td >Special Premium</td>
                <td >Special Premium1</td>
                <td >Special Premium2</td>
				<td >Special Premium3</td>
				<td >Special Premium4</td>
                <td >EDF No</td>
                <td >Delivery Date (MM/DD/YYYY)</td>
                <td >Customer Staff No </td>
                <td >Status</td>
				<td >Fallout Main Category</td>
                <td >Fallout Reason</td>
                <td >Fallout Remark</td>
                <td >Remarks to PY Operation</td>  
                <td >Old Order ID</td>
                <td >Staff No</td>
                <td >Monthly Payment Type</td>
	            <td >Credit Card Type</td>
	            <td >Credit Card No</td>
	            <td >Bank Account Holder Name</td>
	            <td >Credit Card Expiry Date</td>
	            <td >Extra Rebate Amount</td>
				<td >Extra Rebate</td>
	            <td >HS Amount</td>
				<td >HS Rebate Amount</td>
				<td >Redemption Notice</td>
				<td >Email Address</td>

                <% VasHeaderShow(); %>
                </tr>
                 <% SearchReportShow(); %>
            </table>
    </div>
    </form>
</body>
</html>
<% ExportExcel(); %>