<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminSuViewExport.aspx.cs" Inherits="AdminSuViewExport" %>
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
    <EW:RepeaterEx ID="admin_view_rp" runat="server" onitemdatabound="admin_view_rp_ItemDataBound"  EnableViewState="false">
    <HeaderTemplate>
    
<table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
  <tr> 
    <td >&nbsp;</td>
    <td >Record ID</td>
    <td >Report Name</td>
    <td >Log Date<br />(MM/DD/YYYY HH:MM)</td>
    <td >Customer 
      Name </td>
    <td >Account 
      No.</td>
    <td >MRT No </td>
    <td >Action Required</td>
    <td >Waive</td>
    <td >Suspend Date (MM/DD/YYYY)</td>
    <td >Reasons</td>
    <td >Order Placed 
      By</td>
    <td >Relationship</td>
    <td >HKID No/Passport No</td>
    <td >Remarks to PY Operation</td>            
    <td >Old Order ID</td>
    <td >Staff No</td>
    <td >Extra Rebate Amount</td>
	<td >Extra Rebate</td>
    <td >HS Amount</td>
	<td >HS Rebate Amount</td>
    
  </tr>
    </HeaderTemplate>
    <ItemTemplate>
    <tr>
             <td nowrap ><asp:Literal ID="viewid" runat="server"></asp:Literal></td>
             <td nowrap ><%# Func.IDAdd100000(Convert.ToInt32(DataBinder.Eval(Container.DataItem,"order_id")))%></td>   
             <td nowrap ><%# DataBinder.Eval(Container.DataItem, "report_type")%></td>
             <td nowrap ><%# DataBinder.Eval(Container.DataItem, "log_date")%></td>
             <td nowrap ><%# DataBinder.Eval(Container.DataItem, "family_name") +" "+DataBinder.Eval(Container.DataItem, "given_name")%></td>
             <td nowrap ><%# DataBinder.Eval(Container.DataItem, "ac_no")%></td>
             <td nowrap ><%# DataBinder.Eval(Container.DataItem, "mrt_no")%></td>
             <td nowrap ><%# DataBinder.Eval(Container.DataItem, "action_required")%></td>
             <td nowrap ><asp:Literal ID="waive" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "waive")%>'></asp:Literal></td>
             <td nowrap ><%# DataBinder.Eval(Container.DataItem, "reasons")%></td>
             <td nowrap ><%# DataBinder.Eval(Container.DataItem, "action_eff_date")%></td>
             <td nowrap ><%# DataBinder.Eval(Container.DataItem, "ord_place_by")%></td>
             <td nowrap ><%# DataBinder.Eval(Container.DataItem, "ord_place_rel")%></td>
             <td nowrap ><%# DataBinder.Eval(Container.DataItem, "ord_place_id_type")%>&nbsp;<%# DataBinder.Eval(Container.DataItem, "ord_place_hkid")%> </td>  
             <td nowrap ><%# DataBinder.Eval(Container.DataItem, "remarks2PY")%></td>
             <td nowrap ><asp:Literal ID="old_ord_id" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "old_ord_id")%>'></asp:Literal></td>
             <td nowrap ><%# DataBinder.Eval(Container.DataItem, "staff_no")%></td>
             <td nowrap ><%# DataBinder.Eval(Container.DataItem, "extra_rebate_amount")%></td>
			 <td nowrap ><%# DataBinder.Eval(Container.DataItem, "extra_rebate")%></td>
             <td nowrap ><%# DataBinder.Eval(Container.DataItem, "amount")%></td>
			 <td nowrap ><%# DataBinder.Eval(Container.DataItem, "rebate_amount")%></td>
                
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
