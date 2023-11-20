<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminCustomerViewExport.aspx.cs" Inherits="AdminCustomerViewExport" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>

<%@ Import Namespace="PCCW.RWL.CORE" %>
<%@ Import Namespace="NEURON.ENTITY.FRAMEWORK" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
<script type="text/javascript">
<!--
function close_win(){
//	return window.location="/cccl/cccl_main.asp";
    return top.location ="~/Logout.aspx"
}
//-->
</script>

</head>
<body>

    <form id="form1" runat="server">
    <div>
    <EW:RepeaterEx ID="admin_view_rp" runat="server"  EnableViewState="false">
    <HeaderTemplate>
     <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
              <tr> 
                <td class="row1">&nbsp;</td>
                <td class="row1">Record ID</td>
                <td class="row1">Report Name</td>
                <td class="row1">Account No.</td>
                <td class="row1">MRT No </td>
                <td class="row1">Change Customer Details</td>
                <td class="row1">Status</td>
				<td class="row1">Fallout main category</td>
                <td class="row1">Fallout Reason</td>
                <td class="row1">Fallout Remark</td>
                <td class="row1">Staff No</td>
                <td class="row1">Extra Rebate Amount</td>
				<td class="row1">Extra Rebate</td>
                <td class="row1">HS Amount</td>
				<td class="row1">HS Rebate Amount</td>
              </tr>
              
    </HeaderTemplate>
    <ItemTemplate>
    <tr> 
                <td nowrap class="row2"><asp:Literal ID="viewid" runat="server"></asp:Literal></td>
                <td nowrap class="row2"><%# Func.IDSubtract100000(Convert.ToInt32(DataBinder.Eval(Container.DataItem,"order_id")))%></td>
                <td nowrap class="row2"><%# DataBinder.Eval(Container.DataItem, "report_type")%></td>
                <td nowrap class="row2"><%# DataBinder.Eval(Container.DataItem,"ac_no")%></td>
                <td nowrap class="row2"><%# DataBinder.Eval(Container.DataItem,"mrt_no")%></td>
                <td nowrap class="row2"><%# DataBinder.Eval(Container.DataItem,"remarks")%></td>
                <td nowrap class="row2"><%# DataBinder.Eval(Container.DataItem,"order_status")%></td>
				<td nowrap class="row2"><%# DataBinder.Eval(Container.DataItem,"fallout_main_category")%></td>
                <td nowrap class="row2"><%# DataBinder.Eval(Container.DataItem,"fallout_reason")%></td>
                <td nowrap class="row2"><%# DataBinder.Eval(Container.DataItem,"fallout_remark")%></td>
                <td nowrap class="row2"><%# DataBinder.Eval(Container.DataItem,"staff_no")%></td>
                <td nowrap class="row2"><%# DataBinder.Eval(Container.DataItem, "extra_rebate_amount")%></td>
				<td nowrap class="row2"><%# DataBinder.Eval(Container.DataItem, "extra_rebate")%></td>
				<td nowrap class="row2"><%# DataBinder.Eval(Container.DataItem, "amount")%></td>
				<td nowrap class="row2"><%# DataBinder.Eval(Container.DataItem, "rebate_amount")%></td>
                
                
              </tr>

    </ItemTemplate>
    <FooterTemplate>              
            </table>
    </FooterTemplate>
    </EW:RepeaterEx>
    </div>
    </form>

</body>
</html>

