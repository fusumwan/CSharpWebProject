<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RetrieveMobileLiteModifiedExport.aspx.cs" Inherits="RetrieveMobileLiteModifiedExport" %>

<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Import Namespace="PCCW.RWL.CORE" %>
<%@ Import Namespace="NEURON.ENTITY.FRAMEWORK" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>3G Retention - Web Log</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">


              <tr>
                <td class="row1">&nbsp;</td>
                <td class="row1">Web Log id</td>
                <td class="row1">Create Date<br />(MM/DD/YYYY HH:MM)</td>
                <td class="row1">EDF</td>
                <td class="row1">MRT</td>
                <td class="row1">Gender</td>
                <td class="row1">Registered Customer Name </td>
                <td class="row1">Registered Customer ID </td>
                <td class="row1">Date of Birth </td>
                <td class="row1">Registered address</td>
                <td class="row1">Billing address</td>
                <td class="row1">Monthly Payment Type</td>
                <td class="row1">Card number</td>
                <td class="row1">Card holder name</td>
                <td class="row1">Card Expiry date</td>x
                <td class="row1">SIM card number</td>
                <td class="row1">SIM Item Code</td>
                <td class="row1">Rateplan</td>
                <td class="row1">Tradefield</td>
                <td class="row1">Bundle Name</td>
                <td class="row1">Free Monthly Fee</td>
                <td class="row1">Total rebate amount</td>
                <td class="row1">HS model</td>
                <td class="row1">HS amount</td>
                <td class="row1">HS rebate</td>
                <td class="row1">Status</td>
				<td class="row1">Fallout main category</td>
                <td class="row1">Fallout Reason</td>
                <td class="row1">Fallout Remark</td>
                <td class="row1">Fallout Reply</td>
                <td class="row1">Remarks to PY Operation</td>                
                <td class="row1">Delivery Date (MM/DD/YYYY)</td>
                <td class="row1">Service activation date</td>
                <td class="row1">2N Company Name</td>
                <td class="row1">2N Registered Name</td>
                <td class="row1">2N HKID</td>
                <td class="row1">2N Trasfer to 3G (YES/NO)</td>
                <td class="row1">2N Transfer IDD deposit</td>
                <td class="row1">2N Transfer IDD & roaming deposit</td>
                <td class="row1">2N Transfer Non-HK ID holder deposit</td>
                <td class="row1">2N Transfer no address proof deposit</td>
                <td class="row1">2N Transfer others deposit</td>
                <td class="row1">2N Service Ticket number</td>
                <td class="row1">3rd Party</td>
                <td class="row1">Bank Account Holder Name</td>
                <td class="row1">Credit Card ID Type</td>
                <td class="row1">Credit Card number</td>
                <td class="row1">Credit Card type</td>
                <td class="row1">Credit Card expiry date</td>
                <td class="row1">Bill Medium</td>
                <td class="row1">Prepayment Waived</td> 
                <td class="row1">3rd Party Receive SIM</td>
                 <% VasHeaderShow(); %>
                 <td class="row1">Channel</td>
                 <td class="row1">Staff No</td>
                 <td class="row1">Salesman Code</td>
			  </tr>
    
                <% SearchReportShow(); %>
    

            </table>
    </div>
    </form>
</body>
</html>
<% ExportExcel(); %>