<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AssignIMEILIST.aspx.cs" Inherits="Web_IMEIManagement_AssignIMEILIST" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register Src="../../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
    <title>3G Retention - Web Log</title>
<link rel="stylesheet"  href="../../Resources/Styles/global.css" type="text/css" />
<link rel="stylesheet" href="../../Resources/Styles/MainPageStyle.css" type="text/css" />

<asp:Literal ID="NeuronJSLibrary" runat="server"></asp:Literal>
<asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
</head>
<body>
    <form id="form1" runat="server">
      <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
    <cc1:ToolkitScriptManager ID="AddWebLogScriptManager" runat="server" EnablePartialRendering="true" ScriptMode="Release" LoadScriptsBeforeUI="false" EnablePageMethods="true"></cc1:ToolkitScriptManager>
    <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
        <tr> 
        <th width="100%" height="28" colspan="30">&nbsp;<%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></th>
      </tr>
       <tr >
         <td class="row2">
         <asp:Button ID="BackMain" runat="server" Text="BACK"  CssClass="button" PostBackUrl="~/Web/IMEIManagement/ManagementIMEI.aspx" Font-Size="10px" />
         <asp:Button ID="AssignIMEIHistory" runat="server" Text="Assign IMEI History" CssClass="button" PostBackUrl="~/Web/IMEIManagement/AssignIMEIHistory.aspx" Font-Size="10px" />
         </td>
       </tr>
       <tr>
       <td  class="row2">
       
       </td>
       </tr>
       <tr>
       <td class="row3">
       <asp:Button ID="OrderAssignChk" runat="server" OnClientClick="return confirm('Are you sure you want to upload below order(s) to EDF?');" Text="Assign Order" CssClass="button" onclick="OrderAssignChk_Click" />
       </td>
       </tr>
       
       <tr>
       <td>
 <asp:GridView ID="MobileAssignListGW"  runat="server" DataKeyNames="Index" CssClass="table-report"  DataSourceID="MobileAssignListObj"  PageSize="10" AllowPaging="true" 
 EmptyDataText="Have no STOCK record."
AutoGenerateColumns="false"  >
<Columns>

<asp:TemplateField Visible="false">
<ItemTemplate>
<asp:CheckBox ID="chk_id" runat="server" />
<asp:HiddenField ID="Index" runat="server" value='<%# DataBinder.Eval(Container.DataItem,"Index") %>'></asp:HiddenField>
</ItemTemplate>
</asp:TemplateField>

<asp:TemplateField Visible="true">
<HeaderTemplate>
<asp:CheckBox ID="ChkAll" runat="server" oncheckedchanged="ChkAll_CheckedChanged" AutoPostBack="true" />
</HeaderTemplate>
<ItemTemplate>
<asp:CheckBox ID="assign_chk" runat="server" Enabled='<%# DataBinder.Eval(Container.DataItem,"Chk_enabled") %>' />
</ItemTemplate>
</asp:TemplateField>

<asp:TemplateField Visible="false">
<ItemTemplate>
<asp:HiddenField ID="MobileAssignList_edf_no" runat="server" value='<%# DataBinder.Eval(Container.DataItem,"MobileAssignList.edf_no") %>'></asp:HiddenField>
</ItemTemplate>
</asp:TemplateField>

<asp:TemplateField Visible="false">
<ItemTemplate>
<asp:Literal ID="MobileAssignList_active" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"MobileAssignList.active") %>'></asp:Literal>
</ItemTemplate>
</asp:TemplateField>


<asp:TemplateField Visible="true" HeaderText="RECORD ID">
<ItemTemplate>
<asp:HiddenField ID="MobileAssignList_order_id" runat="server" Value='<%# DataBinder.Eval(Container.DataItem,"MobileAssignList.order_id") %>' />
<asp:Literal ID="MobileAssignList_record_id" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"MobileAssignList.record_id") %>'></asp:Literal>
</ItemTemplate>
</asp:TemplateField>


<asp:TemplateField Visible="true" HeaderText="MODEL">
<ItemTemplate>
<asp:Literal ID="MobileAssignList_hs_model" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"MobileAssignList.hs_model") %>'></asp:Literal>
</ItemTemplate>
</asp:TemplateField>


<asp:TemplateField Visible="true" HeaderText="ITEM CODE">
<ItemTemplate>
<asp:Literal ID="MobileAssignList_sku" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"MobileAssignList.sku") %>'></asp:Literal>
</ItemTemplate>
</asp:TemplateField>

<asp:TemplateField Visible="true" HeaderText="IMEI NUMBER">
<ItemTemplate>
<asp:Literal ID="MobileAssignList_imei_no" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"MobileAssignList.imei_no") %>'></asp:Literal>
</ItemTemplate>
</asp:TemplateField>


<asp:TemplateField Visible="true" HeaderText="IMEI STATUS">
<ItemTemplate>
<asp:Literal ID="MobileAssignList_status" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"MobileAssignList.status") %>'></asp:Literal>
</ItemTemplate>
</asp:TemplateField>

<asp:TemplateField Visible="true" HeaderText="Delivery Date">
<ItemTemplate>
<asp:Literal ID="MobileAssignList_d_date" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"MobileAssignList.d_date","{0:dd/MM/yyyy}") %>'></asp:Literal>
</ItemTemplate>
</asp:TemplateField>

</Columns>
</asp:GridView>
<br />

<asp:ObjectDataSource ID="MobileAssignListObj" runat="server" 
 DataObjectTypeName="MobileAssignListView" TypeName="MobileAssignListViewDAO"
 DeleteMethod="DeleteMobileAssignListView" InsertMethod="InsertMobileAssignListView" EnablePaging="True" 
 SelectMethod="FindALL" UpdateMethod="UpdateMobileAssignListView" OldValuesParameterFormatString="original_{0}"  SelectCountMethod="CountAll" SortParameterName="x_sSortExpression"
 MaximumRowsParameterName="x_iPageSize"  StartRowIndexParameterName="x_iStartRow">
 </asp:ObjectDataSource>
   </td>
   </tr>
 </table>
<table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="../MobileRetentionMain.aspx">Main Page</a> &raquo; View 
<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
</table>           
    
    </div>
    </form>
</body>
</html>
