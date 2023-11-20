<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SimAOCase.aspx.cs" Inherits="Web_SimAOCase" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet"  href="../Resources/Styles/global.css" type="text/css" />
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />


<asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>

</head>
<body  style="background-color:#ffffff">
    <form id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
    <asp:ScriptManager ID="AddWebLogScriptManager" runat="server"></asp:ScriptManager>
    <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
        <tr> 
          <th height="28" colspan="4">&nbsp;<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></th>
        </tr>
        <tr> 
            <td height="23" colspan="4" class="row2"> 
            SIM AO CASES
            </td>
        </tr>
        <tr>
            <td height="23" colspan="4">
                <EW:GridViewEx ID="SimAoGV" runat="server" EmptyShowHeader="true" 
                AutoGenerateColumns="False" CssClass="table-report" EmptyDataText="There has no record for you reference"  
                DataKeyNames="order_id" >
                <Columns>
                <asp:TemplateField>
                <ItemTemplate>
                <asp:Literal ID="viewid" runat="server" Text='<%# AddOne(((GridViewRow)Container).RowIndex) %>' ></asp:Literal>
                </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Mobile Numbers">
                <ItemTemplate>
                <asp:HiddenField ID="order_id" runat="server" value='<%# DataBinder.Eval(Container.DataItem, "order_id") %>'></asp:HiddenField>
                <asp:Label ID="mrt_no" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "mrt_no")%>'></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Sim Item Name">
                <ItemTemplate>
                <asp:Label ID="sim_item_name" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "sim_item_name")%>'></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Sim Item Number">
                <ItemTemplate>
                <asp:Label ID="sim_item_number" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "sim_item_number")%>'></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Sim Item Code">
                <ItemTemplate>
                <asp:Label ID="sim_item_code" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "sim_item_code")%>'></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
                </Columns>
                </EW:GridViewEx>
            </td>
        </tr> 
              <tr> 
                <td class="cat" colspan="9">&nbsp;</td>
              </tr>
     </table>                
    
    <table width="100%" cellspacing="2" cellpadding="3" border="0">
    <tr>
    <td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; View 
    <span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
    </tr>
    </table>     
    </div>
    </form>
</body>
</html>
