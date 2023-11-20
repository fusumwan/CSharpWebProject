<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReportAllFoCSA.aspx.cs" Inherits="ReportAllFoCSA" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE" %>
<%@ Import Namespace="NEURON.ENTITY.FRAMEWORK" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
	<head runat="server">
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
	</head>
<body>
    <form id="form1" runat="server">
    <div>
    <EW:RepeaterEx ID="fo_csa_rp" runat="server"  EnableViewState="false" 
            onitemdatabound="fo_csa_rp_ItemDataBound">
    <HeaderTemplate>
    <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
    <tr> 
    <td class="row1">&nbsp;</td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Record ID</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Create Date / Modify Date</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Report Name</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Log Date</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Customer Name </span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Account No.</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">MRT No </span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Autoroll </span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Rate Plan</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Contract Period </span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Trade Field</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Bundle Name</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Free Monthly Fee</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Cancel Auto Renewal</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">HS Model </span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Premium</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">VAS Effective Date</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Rate Plan Effective Date</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Contract Effective Date</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Action Required</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Waive</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Suspend Date</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Existing Plan</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Reasons</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Staff No</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Salesman Code</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Status</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Fallout Reason</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Fallout Remark</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Fallout Reply</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Retrieved By</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Retrieved Date</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Last Updated By</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Last Update Date</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Modified By</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Modified Date</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Order Placed By</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Relationship</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">HKID No/ Passport No</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Special Premium</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">AIG Free Gift</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Additional 800 Minutes</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">EDF No</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">SRD</span></td>
    </tr>
    </HeaderTemplate>
    <ItemTemplate>
    <tr>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="fo_csa_id" runat="server"></asp:Literal></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%# Func.IDAdd100000(Convert.ToInt32(DataBinder.Eval(Container.DataItem,"order_id")))%></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"email_date") %></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"report_type") %></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"log_date")%></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem, "family_name") +" "+DataBinder.Eval(Container.DataItem, "given_name")%></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"ac_no")%></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"mrt_no")%></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"> <asp:Literal ID="accept" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"accept")%>'></asp:Literal></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"rate_plan")%> </span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"con_per")%></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"trade_field")%></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"bundle_name")%></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"free_mon")%></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"cancel_renew")%></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"hs_model")%></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"premium")%></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"vas_eff_date")%></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"plan_eff_date")%></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"con_eff_date")%></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"action_required")%></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="waive" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"waive")%>'></asp:Literal></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"action_eff_date")%></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"exist_plan")%></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"reasons")%></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"staff_no")%></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"salesmancode")%></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"order_status")%></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"fallout_reason")%></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"fallout_remark")%></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"fallout_reply")%></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"retrieve_sn")%></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"retrieve_date")%></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"admin_sn")%></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"admin_date")%></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"mod_id")%></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"mod_date")%></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"ord_place_by")%></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"ord_place_rel")%></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"ord_place_id_type")%>  <%#DataBinder.Eval(Container.DataItem,"ord_place_hkid")%></span> </td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"s_premium")%></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:9px"><%#DataBinder.Eval(Container.DataItem,"aig_gift")%></span></td>
    <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"min_vas")%></span></td>
     <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"edf_no")%></span></td>
     <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%#DataBinder.Eval(Container.DataItem,"d_date")%></span></td>
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
