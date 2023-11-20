<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminModifyViewExport.aspx.cs" Inherits="AdminModifyViewExport" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>

<%@ Import Namespace="PCCW.RWL.CORE" %>
<%@ Import Namespace="NEURON.ENTITY.FRAMEWORK" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>3G Retention - Web Log</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <EW:RepeaterEx ID="admin_view_rp" runat="server" onitemdatabound="admin_view_rp_ItemDataBound"  EnableViewState="false">
    <HeaderTemplate>
<table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
  <tr> 
    <td class="row1">&nbsp;</td>
    <td class="row1">Record ID</td>
    <td class="row1">Sent Date<br />
      (MM/DD/YYYY)</td>
    <td class="row1">Report Name</td>
    <td class="row1">Log Date<br>(MM/DD/YYYY HH:MM)</td>
    <td class="row1">Customer Name </td>
    <td class="row1">Account No.</td>
    <td class="row1">MRT No </td>
    <td class="row1">Autoroll </td>
    <td class="row1">Rate Plan</td>
    <td class="row1">Contract Period </td>
    <td class="row1">Trade Field</td>
    <td class="row1">Bundle Name</td>
    <td class="row1">Free Monthly Fee</td>
    <td class="row1">Rebate</td>
    <td class="row1">Cancel Auto Renewal</td>
    <td class="row1">VAS Effective Date<br>(MM/DD/YYYY)</td>
    <td class="row1">Rate Plan Effective Date<br>(MM/DD/YYYY)</td>
    <td class="row1">Contract Effective Date<br>(MM/DD/YYYY)</td>
    <td class="row1">Action Required</td>
    <td class="row1">Waive</td>
    <td class="row1">Suspend Date<br>(MM/DD/YYYY)</td>
    <td class="row1">Existing Plan</td>
    <td class="row1">Reasons</td>
    <td class="row1">Staff No</td>
    <td class="row1">Salesman Code</td>
    <td class="row1">Status</td>
	<td class="row1">Fallout main category</td>
    <td class="row1">Fallout Reason</td>
    <td class="row1">Fallout Remark</td>
    <td class="row1">Fallout Reply</td>
    <td class="row1">Retrieved By</td>
    <td class="row1">Retrieved Date <br />(MM/DD/YYYY HH:MM)</td>
    <td class="row1">Last Updated By</td>
    <td class="row1">Last Update Date <br />(MM/DD/YYYY HH:MM)</td>
    <td class="row1">Order Placed By</td>
    <td class="row1">Relationship</td>
    <td class="row1">HKID No/ Passport No</td>
    <td class="row1">Remarks to PY Operation</td>
    <td class="row1">Old Order ID</td>
    <td class="row1">Extra Rebate Amount</td>
	<td class="row1">Extra Rebate</td>
    <td class="row1">HS Amount</td>
    <td class="row1">HS Rebate Amount</td>
    <td class="row1">Redemption Notice</td>
    <td class="row1">Special premium 1</td>
    <td class="row1">Special premium 2</td>
  </tr>
  
    </HeaderTemplate>
    
    <ItemTemplate>
         <tr> 
             <td nowrap ><asp:Literal ID="viewid" runat="server"></asp:Literal></td>
             <td nowrap ><%# Func.IDAdd100000(Convert.ToInt32(DataBinder.Eval(Container.DataItem,"order_id")))%></td>   
             <td nowrap ><%# DataBinder.Eval(Container.DataItem, "email_date")%></td>
             <td nowrap ><%# DataBinder.Eval(Container.DataItem, "report_type")%></td>
             <td nowrap ><%# DataBinder.Eval(Container.DataItem, "log_date")%></td>
             <td nowrap ><%# DataBinder.Eval(Container.DataItem, "family_name") +" "+DataBinder.Eval(Container.DataItem, "given_name")%></td>
             <td nowrap ><%# DataBinder.Eval(Container.DataItem, "ac_no")%></td>
             <td nowrap ><%# DataBinder.Eval(Container.DataItem, "mrt_no")%></td>
             <td nowrap ><asp:Literal ID="accept" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "accept")%>'></asp:Literal></td>
              
            <td nowrap ><%# DataBinder.Eval(Container.DataItem, "rate_plan")%></td>
            <td nowrap ><%# DataBinder.Eval(Container.DataItem, "con_per")%></td>
            <td nowrap ><%# DataBinder.Eval(Container.DataItem, "trade_field")%></td>
            <td nowrap ><%# DataBinder.Eval(Container.DataItem, "bundle_name")%></td>
            <td nowrap ><%# DataBinder.Eval(Container.DataItem, "free_mon")%></td>
            <td nowrap ><%# DataBinder.Eval(Container.DataItem, "rebate")%></td>
            <td nowrap ><%# DataBinder.Eval(Container.DataItem, "cancel_renew")%></td>
            
                <td nowrap ><%# DataBinder.Eval(Container.DataItem, "vas_eff_date")%>  </td>
                <td nowrap ><%# DataBinder.Eval(Container.DataItem, "plan_eff")%>&nbsp;<%# DataBinder.Eval(Container.DataItem, "plan_eff_date")%></td>
                <td nowrap ><%# DataBinder.Eval(Container.DataItem, "con_eff_date")%></td>
                <td nowrap ><%# DataBinder.Eval(Container.DataItem, "action_required")%></td>
                <td nowrap ><asp:Literal ID="waive" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "waive")%>'></asp:Literal></td>
                <td nowrap ><%# DataBinder.Eval(Container.DataItem, "action_eff_date")%></td>
                <td nowrap ><%# DataBinder.Eval(Container.DataItem, "exist_plan")%></td>
                <td nowrap ><%# DataBinder.Eval(Container.DataItem, "reasons")%></td>
                <td nowrap ><%# DataBinder.Eval(Container.DataItem, "staff_no")%></td>
                <td nowrap ><%# DataBinder.Eval(Container.DataItem, "salesmancode")%></td>
                <td nowrap ><%# DataBinder.Eval(Container.DataItem, "order_status")%></td>
				<td nowrap ><%# DataBinder.Eval(Container.DataItem, "fallout_main_category")%></td>
                <td nowrap ><%# DataBinder.Eval(Container.DataItem, "fallout_reason")%></td>
                <td nowrap ><%# DataBinder.Eval(Container.DataItem, "fallout_remark")%></td>
                <td nowrap ><%# DataBinder.Eval(Container.DataItem, "fallout_reply")%></td>
                <td nowrap ><%# DataBinder.Eval(Container.DataItem, "retrieve_sn")%></td>
                <td nowrap ><%# DataBinder.Eval(Container.DataItem, "retrieve_date")%></td>
                <td nowrap ><%# DataBinder.Eval(Container.DataItem, "admin_sn")%></td>
                <td nowrap ><%# DataBinder.Eval(Container.DataItem, "admin_date")%></td>
                
                <td nowrap ><%# DataBinder.Eval(Container.DataItem, "ord_place_by")%></td>
                <td nowrap ><%# DataBinder.Eval(Container.DataItem, "ord_place_rel")%></td>
                <td nowrap ><%# DataBinder.Eval(Container.DataItem, "ord_place_id_type")%>&nbsp;<%# DataBinder.Eval(Container.DataItem, "ord_place_hkid")%> </td>
                <td nowrap ><%# DataBinder.Eval(Container.DataItem, "remarks2PY")%></td>
                <td nowrap ><asp:Literal ID="old_ord_id" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "old_ord_id")%>'></asp:Literal></td>
                <td nowrap ><%# DataBinder.Eval(Container.DataItem, "extra_rebate_amount")%></td>
				<td nowrap ><%# DataBinder.Eval(Container.DataItem, "extra_rebate")%></td>
            <td nowrap ><%# DataBinder.Eval(Container.DataItem, "amount")%></td>
            <td nowrap ><%# DataBinder.Eval(Container.DataItem, "rebate_amount")%></td>
            <td nowrap ><%# DataBinder.Eval(Container.DataItem, "s_premium1")%></td>
            <td nowrap ><%# DataBinder.Eval(Container.DataItem, "s_premium2")%></td>
              </tr>           
    </ItemTemplate>
    
    <FooterTemplate>
    </FooterTemplate>
    </EW:RepeaterEx>
    </div>
    </form>
</body>
</html>
