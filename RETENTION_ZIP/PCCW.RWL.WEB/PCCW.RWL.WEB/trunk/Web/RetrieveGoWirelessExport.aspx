<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RetrieveGoWirelessExport.aspx.cs" Inherits="Web_RetrieveGoWirelessExport" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
		<head id="Head1" runat="server">
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
	</head>
<body>

    <EW:RepeaterEx ID="admin_view_rp" runat="server" onitemdatabound="admin_view_rp_ItemDataBound"  EnableViewState="false">
    <HeaderTemplate>
    <table width="100%" border="0" cellpadding="3" cellspacing="1" >

                <tr> 
                  <td ></td>

                  <td ><span  >Record ID</span></td>
                  <td ><span  >Sent Date<br />
                    (MM/DD/YYYY)</span></td>
                  <td ><span  >Report Name</span></td>
                  <td ><span  >Log Date<br />
                    (MM/DD/YYYY)</span></td>
                  <td ><span  >GO Wireless</span></td>
                  <td ><span  >EDF No</span></td>
                  <td ><span  >Staff No</span></td>
                  <td ><span  >Customer Name </span></td>
                  <td ><span  >HKID No/ Passport No</span></td>
                  <td ><span  >MRT No </span></td>
                  <td ><span  >Rate  Plan</span></td>
                  <td ><span  >Trade Field</span></td>
                  <td ><span  >Retrieved By</span></td>
                  <td ><span  >Retrieved Date <br />
                    (MM/DD/YYYY HH:MM)</span></td>
                  <td ><span  >Last Updated By</span></td>
                  <td ><span  >Last Update Date <br />
                    (MM/DD/YYYY HH:MM)</span></td>
                  <td ><span  >Register Address</span></td>
                  <td ><span  >New Sim imei</span></td>
                  <td ><span  >Go Wireless MRT</span></td>
                  <td ><span  >New ANS imei</span></td>
                  <td ><span  >Preferred Languages</span></td>
                  <td ><span  >Payment Type</span></td>
                  <td ><span  >Pre-pay Amount</span></td>
                  <td ><span  >3rd Party Credit Card</span></td>
                  <td ><span  >3rd Party HKID/Passport</span></td>
                  <td ><span  >Bank Account Holder Name </span></td>
                  <td ><span  >Credit card no.</span></td>
			      <td ><span  >Credit Card Expiry Date </span></td>
                  <td ><span  >Actvation Date<br />
                    (MM/DD/YYYY) </span></td>
                    <td ><span>Org MRT NO.</span></td>
                    <td ><span>Remarks to PY Operation</span></td>
                    <td ><span>Go Wireless VAS</span></td>
                    
                    <td ><span>Monthly Payment Type</span></td>
				  <td ><span>Credit Card Type</span></td>
				  <td ><span>Credit Card No</span></td>
				  <td><span>Bank Account Holder Name</span></td>
				  <td><span>Credit Card Expiry Date</span></td>
				  
				  
				   <td><span>Extra Rebate Amount</span></td>
				<td><span >Extra Rebate</span></td>
                    
                </tr>
    </HeaderTemplate>
    <ItemTemplate>
                    <tr> 
                  <td ><span ><asp:Literal ID="viewid" runat=server></asp:Literal></span></td>

                  <td ><span ><%# Func.IDAdd100000(Convert.ToInt32(DataBinder.Eval(Container.DataItem, "order_id")))%></span></td>
                  

                  
                  <td ><span ><%# DataBinder.Eval(Container.DataItem, "email_date")%></span></td>
                  <td ><span ><%# DataBinder.Eval(Container.DataItem, "report_type")%></span></td>
                  <td ><span ><%# DataBinder.Eval(Container.DataItem, "log_date")%></span></td>
                  <td ><span ><%# DataBinder.Eval(Container.DataItem, "go_wireless")%></span></td>
                  
                  
                  <td ><span ><%# DataBinder.Eval(Container.DataItem, "edf_no")%></span></td>
                  <td ><span ><%# DataBinder.Eval(Container.DataItem, "staff_no")%></span></td>
                  <td ><span ><%# DataBinder.Eval(Container.DataItem, "family_name") +" "+DataBinder.Eval(Container.DataItem, "given_name")%></span></td>
                  <td ><span ><%# DataBinder.Eval(Container.DataItem, "ord_place_id_type")%>&nbsp; <%# DataBinder.Eval(Container.DataItem, "ord_place_id_type")%></span></td>
                  <td ><span ><%# DataBinder.Eval(Container.DataItem, "mrt_no")%></span></td>
                  
                  <td ><span ><%# DataBinder.Eval(Container.DataItem, "rate_plan")%></span></td>
                  <td ><span ><%# DataBinder.Eval(Container.DataItem, "trade_field")%></span></td>
                  <td ><span ><%# DataBinder.Eval(Container.DataItem, "retrieve_sn")%></span></td>
                  <td ><span ><%# DataBinder.Eval(Container.DataItem, "retrieve_date")%></span></td>
                  <td ><span ><%# DataBinder.Eval(Container.DataItem, "admin_sn")%></span></td>
                  
                  <td ><span ><%# DataBinder.Eval(Container.DataItem, "admin_date")%></span></td>
                  <td ><span ><%# DataBinder.Eval(Container.DataItem, "register_address")%></span></td>
                  <td ><span ><%# DataBinder.Eval(Container.DataItem, "gift_imei")%></span></td>
                  <td ><span ><%# DataBinder.Eval(Container.DataItem, "sim_mrt_no")%></span></td>
                  <td ><span ><%# DataBinder.Eval(Container.DataItem, "accessory_imei")%></span></td>
                  
                  <td ><span ><%# DataBinder.Eval(Container.DataItem, "preferred_languages")%></span></td>
                  <td ><span ><%# DataBinder.Eval(Container.DataItem, "pay_method")%></span></td>
                  <td ><span ><%# DataBinder.Eval(Container.DataItem, "accessory_price")%></span></td>
                  <td ><span ><%# DataBinder.Eval(Container.DataItem, "third_party_credit_card")%></span></td>
                  <td ><span ><%# DataBinder.Eval(Container.DataItem, "third_party_id_type")%>&nbsp;<%# DataBinder.Eval(Container.DataItem, "third_party_hkid")%></span></td>
                  
                  <td ><span ><%# DataBinder.Eval(Container.DataItem, "card_holder")%></span></td>
                  <td ><span ><%# DataBinder.Eval(Container.DataItem, "card_no")%></span></td>
                  <td ><span ><%# DataBinder.Eval(Container.DataItem, "card_exp_month")%></span><span >  / </span><span ><%# DataBinder.Eval(Container.DataItem, "card_exp_year")%></span><span > (MM/YY) </span></td>
                  <td ><span ><%# DataBinder.Eval(Container.DataItem, "con_eff_date")%><%# NextBill(DataBinder.Eval(Container.DataItem, "next_bill")) %></span></td>
                  
                  <td ><span ><%# DataBinder.Eval(Container.DataItem, "org_mrt")%></span></td>
                  <td ><span ><%# DataBinder.Eval(Container.DataItem, "remarks2PY")%></span></td>
                  <td ><span ><%# GetVasValue("gowireless_vas",DataBinder.Eval(Container.DataItem, "order_id"))%></span></td>
                  
                  
                  <td><span><%# DataBinder.Eval(Container.DataItem, "monthly_payment_method")%></span></td>
                  <td><span><%# DataBinder.Eval(Container.DataItem, "m_card_type")%></span></td>
                  <td><span>'<%# DataBinder.Eval(Container.DataItem, "m_card_no")%></span></td>
                  <td><span><%# DataBinder.Eval(Container.DataItem, "m_card_holder2")%></span></td>
                  <td><span><%# DataBinder.Eval(Container.DataItem, "m_card_exp_month")%> / <%# DataBinder.Eval(Container.DataItem, "m_card_exp_year")%></span></td>
                   <td><span><%# DataBinder.Eval(Container.DataItem, "extra_rebate_amount")%></span></td>
				<td><span><%# DataBinder.Eval(Container.DataItem, "extra_rebate")%></span></td>
                </tr>
    </ItemTemplate>
    <FooterTemplate>

              </table>
    </FooterTemplate>
    </EW:RepeaterEx>
</body>
</html>
