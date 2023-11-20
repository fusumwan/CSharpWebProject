<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RetrieveSuViewExport.aspx.cs" Inherits="RetrieveSuViewExport" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Import Namespace="PCCW.RWL.CORE"%>
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
            <EW:RepeaterEx ID="admin_view_rp" runat="server"  EnableViewState="false" 
                onitemdatabound="admin_view_rp_ItemDataBound">
        <HeaderTemplate>
        <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
  <tr> 
    <td class="row1">&nbsp;</td>
    <td class="row1">Record ID</td>
    <td class="row1">Report Name</td>
    <td class="row1">Log Date<br />(MM/DD/YYYY HH:MM)</td>
    <td class="row1">Customer Name </td>
    <td class="row1">Account No.</td>
    <td class="row1">MRT No </td>
    <td class="row1">Action Required</td>
    <td class="row1">Waive</td>
    <td class="row1">Suspend Date (MM/DD/YYYY)</td>
    <td class="row1">Reasons</td>
    <td class="row1">Order Placed By</td>
    <td class="row1">Relationship</td>
    <td class="row1">HKID No/ Passport No</td>
    <td class="row1">Remarks to PY Operation</td>       
    <td class="row1">Old Order ID</td>
    <td class="row1">Staff No</td>
    <td class="row1">Extra Rebate Amount</td>
	<td class="row1">Extra Rebate</td>
  </tr>
        </HeaderTemplate>
        <ItemTemplate>
                    <tr> 
                  <td nowrap class="row2"><asp:Literal ID="viewid" runat="server"></asp:Literal></td>
                  <td nowrap class="row2"><%# Func.IDAdd100000(Convert.ToInt32(DataBinder.Eval(Container.DataItem, "order_id")))%></td>
                  <td nowrap class="row2"><%# DataBinder.Eval(Container.DataItem, "report_type")%></td>
                  <td nowrap class="row2"><%# DataBinder.Eval(Container.DataItem, "log_date")%></td>
                  <td nowrap class="row2"><%# DataBinder.Eval(Container.DataItem, "family_name") +" "+DataBinder.Eval(Container.DataItem, "given_name")%></td>
                  <td nowrap class="row2"><%# DataBinder.Eval(Container.DataItem, "ac_no")%></td>
                  <td nowrap class="row2"><%# DataBinder.Eval(Container.DataItem, "mrt_no")%></td>
                  <td nowrap class="row2"><%# DataBinder.Eval(Container.DataItem, "action_required")%></td>
                  <td nowrap class="row2"><asp:Literal ID="waive" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "waive")%>' ></asp:Literal></td>
                  <td nowrap class="row2"><%# DataBinder.Eval(Container.DataItem, "action_eff_date")%> </td>
                  <td nowrap class="row2"><%# DataBinder.Eval(Container.DataItem, "reasons")%></td>
                  <td nowrap class="row2"><%# DataBinder.Eval(Container.DataItem, "ord_place_by")%></td>
                  <td nowrap class="row2"><%# DataBinder.Eval(Container.DataItem, "ord_place_rel")%></td>
                  <td nowrap class="row2"><%# DataBinder.Eval(Container.DataItem, "ord_place_id_type")%>&nbsp;<%# DataBinder.Eval(Container.DataItem,"ord_place_hkid")%> </td>
               	  <td nowrap class="row2"><%# DataBinder.Eval(Container.DataItem, "remarks2PY")%></td>
                  <td nowrap class="row2"><asp:Literal ID="old_ord_id" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "old_ord_id")%>'></asp:Literal></td>
               	  <td nowrap class="row2"><%# DataBinder.Eval(Container.DataItem, "staff_no")%></td>
               	  <td nowrap class="row2"><%# DataBinder.Eval(Container.DataItem, "extra_rebate_amount")%></td>
				  <td nowrap class="row2"><%# DataBinder.Eval(Container.DataItem, "extra_rebate")%></td>
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
