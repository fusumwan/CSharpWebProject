<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RetrieveCustomerViewExport.aspx.cs" Inherits="RetrieveCustomerViewExport" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
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
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Record ID</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Report Name</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Account  No.</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">MRT No </span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Change Customer Details</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Staff No</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Extra Rebate Amount</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Extra Rebate</span></td>
    
  </tr>
        </HeaderTemplate>
        
        <ItemTemplate>
                 <tr> 
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="viewid" runat=server></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "order_id")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "report_type")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "ac_no")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "mrt_no")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "remarks")%></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "staff_no")%></span></td>
                   <td nowrap class="row2"><span class="gensmall"  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "extra_rebate_amount")%></span></td>
				<td nowrap class="row2"><span  class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "extra_rebate")%></span></td>
                
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
