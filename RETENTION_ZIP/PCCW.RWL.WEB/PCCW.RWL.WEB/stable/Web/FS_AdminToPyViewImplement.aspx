<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FS_AdminToPyViewImplement.aspx.cs" Inherits="AdminToPyViewImplement" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
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
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
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
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>

    
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
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Record 
                  ID</span></td>
                 <td class="row1"><span class="explaintitle" style="font-size:7pt">Active
			      </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Sent 
                  Date<br />
                  (MM/DD/YYYY)</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Report 
                  Name</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Log 
                  Date<br />
                  (MM/DD/YY HH:MM)</span></td>
                    <td class="row1"><span class="explaintitle" style="font-size:7pt">Gender</span></td>
                    <td class="row1"><span class="explaintitle" style="font-size:7pt">Customer Name</span></td>
                    <td class="row1"><span class="explaintitle" style="font-size:7pt">Date of Birth</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Account 
                  No.</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">MRT 
                  No </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Autoroll </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">PCD PAID Go Wireless</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Rate Plan</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Contract 
                  Period </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Trade 
                  Field</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Bundle 
                  Name</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Free 
                  Monthly Fee</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Rebate</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Cancel 
                  Auto Renewal</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">HS 
                  Model </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Premium </span></td>
                
                <td class="row1"><span class="explaintitle" style="font-size:7pt">VAS 
                  Effective Date<br />
                  (MM/DD/YY)</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Rate 
                  Plan Effective Date<br />
                  (MM/DD/YY)</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Contract Effective Date<br /> (MM/DD/YY)</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Bill Cut Date</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Action Required</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Waive</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Suspend Date (MM/DD/YYYY)</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Existing  Plan</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Reasons</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Staff No</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Salesman Code</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Status</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Fallout Reason</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Fallout Remark</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Fallout Reply</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Retrieved By</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Retrieved Date<br /> (MM/DD/YY HH:MM)</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Last Updated By</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Last Update Date<br /> (MM/DD/YY HH:MM)</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Order Placed By</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Relationship</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">HKID No/ Passport No</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Special Premium</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Special Premium1</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Special Premium2</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Special Premium3</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Special Premium4</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">EDF No</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Delivery Date (MM/DD/YYYY)</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Customer Staff No </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Remarks to PY Operation</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Old  Order ID</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Staff No</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Monthly Payment Type</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Credit Card Type</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Credit Card No</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Bank Account Holder Name</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Credit Card Expiry Date</span></td>
				
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Extra Rebate Amount</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Extra Rebate</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">HS Amount</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">HS Rebate Amount</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Prepayment Waived</span></td>
				
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Email Address</span></td>
    
               <% VasHeaderShow(); %>
			  </tr>
			     <% SearchReportShow(); %>
            </table>
    
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
