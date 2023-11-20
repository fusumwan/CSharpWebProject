<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminCustomerViewAction.aspx.cs" Inherits="AdminCustomerViewAction" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
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
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
<script type="text/javascript">
<!--
function close_win(){
//	return window.location="/cccl/cccl_main.asp";
    return top.location ="~/Logout.aspx"
}
//-->
</script>
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
</head>
<body>

    <form id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
    <EW:RepeaterEx ID="admin_view_rp" runat="server">
    <HeaderTemplate>
     <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
              <tr> 
                <th height="28" colspan="100"><span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></th>
              </tr>
              <tr> 
                <td height="23" colspan="100" class="row2"><input name="submit22" type="button" class="button" value="BACK" onclick="history.go(-1);" style="font-size:7pt" /> 
                </td>
              </tr>
              <tr> 
                <td class="row1">&nbsp;</td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Record 
                  ID</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Report 
                  Name</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Account 
                  No.</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">MRT 
                  No </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Change 
                  Customer Details</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Status</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Fallout Main Catagory</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Fallout Reason</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Fallout Remark</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Staff No</span></td>
                 <td class="row1"><span class="explaintitle" style="font-size:7pt">Extra Rebate Amount</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Extra Rebate</span></td>
                 <td class="row1"><span class="explaintitle" style="font-size:7pt">HS Amount</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">HS Rebate Amount</span></td>
                
              </tr>
    </HeaderTemplate>
    <ItemTemplate>
    <tr> 
                <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="viewid" runat="server"></asp:Literal></span></td>
                <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><a href="#" onClick='window.open("AdminViewHistoryImplement.aspx?order_id=<%# DataBinder.Eval(Container.DataItem,"order_id")%>","_blank","toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=yes, copyhistory=no, width=600, height=200")'><%# Func.IDAdd100000(Convert.ToInt32(DataBinder.Eval(Container.DataItem,"order_id")))%></a></span></td>
                <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "report_type")%></span></td>
                <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem,"ac_no")%></span></td>
                <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem,"mrt_no")%></span></td>
                <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem,"remarks")%></span></td>
                <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem,"order_status")%></span></td>
				<td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem,"fallout_main_category")%></span></td>
                <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem,"fallout_reason")%></span></td>
                <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem,"fallout_remark")%></span></td>
                <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem,"staff_no")%></span></td>
                <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "extra_rebate_amount")%></span></td>
				<td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "extra_rebate")%></span></td>
				<td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "amount")%></span></td>
				<td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "rebate_amount")%></span></td>
                
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
