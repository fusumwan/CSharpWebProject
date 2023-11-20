<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MobileOrderIssueOrderRestrictionControlPage.aspx.cs" Inherits="Web_AccessRight_MobileOrderIssueOrderAccessRightControlPage" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register Src="../../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
    <title>3G Retention - Web Log</title>
<link rel="stylesheet"  href="../../Resources/Styles/global.css" type="text/css" />
<link rel="stylesheet" href="../../Resources/Styles/MainPageStyle.css" type="text/css" />
<asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
</head>
<body >
    <form id="form1" runat="server">
      <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
    <cc1:ToolkitScriptManager ID="AddWebLogScriptManager" runat="server" EnablePartialRendering="true" ScriptMode="Release" LoadScriptsBeforeUI="false" EnablePageMethods="true"></cc1:ToolkitScriptManager>
    <TABLE width="100%" border="0" cellpadding="3" cellspacing="3" width="100%" >
       <tr>
       <td>
       <br />
       <H2>&nbsp;&nbsp;Mobile Order Issue Order Restriction Control Page</H2>
      <hr color="black"/>    
      <br />
       </td>
       </tr>
       <TR >
         <TD class="row2">
         <asp:Button ID="BackMain" runat="server" Text="BACK"  CssClass="button" PostBackUrl="~/Web/AccessRight/AccessPageManagement.aspx" Font-Size="10px" />
         <asp:Button ID="RestrictionList" runat="server" Text="Restriction List" CssClass="button" PostBackUrl="~/Web/AccessRight/MobileOrderIssueOrderRestrictionControlPage.aspx" Font-Size="10px" />
         <asp:Button ID="ColumnRestriction" runat="server" Text="Column Restriction" CssClass="button" PostBackUrl="~/Web/AccessRight/MobileOrderIssueOrderRestrictionColumnControlPage.aspx" Font-Size="10px" />
         <asp:Button ID="ColumnProfile" runat="server" Text="Mobile No. Restriction Profile" CssClass="button" PostBackUrl="~/Web/AccessRight/MobileOrderIssueOrderRestrictionColumnProfile.aspx" Font-Size="10px" />
         
         </TD>
       </TR>
       <TR>
       <TD>
       <asp:FormView ID="MobileOrderIssueRestrictionFW" runat="server" CssClass="table-report" 
               DataKeyNames="MobileOrderIssueRestriction_name,MobileOrderIssueRestriction_type,MobileOrderIssueRestriction_cid" 
               DataSourceID="MobileOrderIssueRestrictionObj" DefaultMode="Insert" 
               oniteminserted="MobileOrderIssueRestrictionFW_ItemInserted" 
               onitemcreated="MobileOrderIssueRestrictionFW_ItemCreated">

           <InsertItemTemplate>
                <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">  
                <tr>
                    <th colspan="2">
                    Assign New Issue Order Restriction Rule Name
                    </th>
                </tr>
                <tr>
                    <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">Name:</span></td>
                    <td width="77%" height="25" class="row1">
                    <asp:TextBox ID="MobileOrderIssueRestriction_name" runat="server" ValidationGroup="InsertMobileOrderIssueRestriction"  Text='<%# Bind("MobileOrderIssueRestriction_name") %>' />
                    <asp:RequiredFieldValidator ID="MobileOrderIssueRestriction_name_valid" runat="server" ControlToValidate="MobileOrderIssueRestriction_name" ValidationGroup="InsertMobileOrderIssueRestriction" ErrorMessage="Please kindly enter restriction name"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">Name:</span></td>
                    <td width="77%" height="25" class="row1">
                    <asp:TextBox ID="MobileOrderIssueRestriction_cid" runat="server" ValidationGroup="InsertMobileOrderIssueRestriction"  Text='<%# Bind("MobileOrderIssueRestriction_cid") %>' />
                    <asp:RequiredFieldValidator ID="MobileOrderIssueRestriction_cid_valid" runat="server" ControlToValidate="MobileOrderIssueRestriction_cid" ValidationGroup="InsertMobileOrderIssueRestriction" ErrorMessage="Please kindly enter staff no"></asp:RequiredFieldValidator>
                    </td>
                
                </tr>  
                <tr> 
                    <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">Type:</span></td>
                    <td width="77%" height="25" class="row1">
                    <asp:DropDownList ID="MobileOrderIssueRestriction_type" AppendDataBoundItems="true"  runat="server" ValidationGroup="InsertMobileOrderIssueRestriction" 
                    SelectedValue='<%# Bind("MobileOrderIssueRestriction_type") %>' >
                    <asp:ListItem Text="" Value=""></asp:ListItem>
                    <asp:ListItem Text="SPECIAL MOBILE NUMBER" Value="SPECIAL_MOBILE_NUMBER"></asp:ListItem>
                    </asp:DropDownList>
                    </td>
                </tr>  
                <tr>
                <td  colspan="3">
                <asp:Button ID="InsertButton" runat="server"  ValidationGroup="InsertMobileOrderIssueRestriction"  CausesValidation="True" CssClass="button" CommandName="INSERT" Text="INSERT" OnClientClick="return confirm('Are you sure you want to create a new record?');" />               
                </td>
                </tr>
                </table>
           </InsertItemTemplate>

       </asp:FormView>
        <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">  
 
                <tr>
                <td>
<asp:GridView ID="MobileOrderIssueRestrictionGW" runat="server"
DataKeyNames="MobileOrderIssueRestriction_restriction_id" 
DataSourceID="MobileOrderIssueRestrictionObj" EmptyDataText="There has no record" 
CssClass="table-report" 
AutoGenerateColumns="false" onrowupdating="MobileOrderIssueRestrictionGW_RowUpdating">
<Columns>

<asp:TemplateField Visible="true">
<ItemTemplate>
<asp:Button ID="EditBut" runat="server" CssClass="button" Text="EDIT" CommandName="EDIT" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
<asp:Button ID="SelectBut" runat="server" CssClass="button" Text="SELECT" CommandName="SELECT" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
</ItemTemplate>
<EditItemTemplate>
<asp:Button ID="UpdateBut" runat="server" Text="UPDATE"  CssClass="button"  CommandName="UPDATE" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
</EditItemTemplate>
</asp:TemplateField>

<asp:TemplateField Visible="false">
<ItemTemplate>
<asp:Literal ID="Index" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"Index") %>'></asp:Literal>
</ItemTemplate>
<EditItemTemplate>
<asp:TextBox ID="Index" runat="server" Text='<%# Bind("Index") %>'></asp:TextBox>
</EditItemTemplate>
<InsertItemTemplate>
<asp:TextBox ID="Index" runat="server" Text='<%# Bind("Index") %>'></asp:TextBox>
</InsertItemTemplate>
</asp:TemplateField>

<asp:TemplateField Visible="false">
<ItemTemplate>
<asp:HiddenField ID="MobileOrderIssueRestriction_restriction_id" runat="server" Value='<%# DataBinder.Eval(Container.DataItem,"MobileOrderIssueRestriction.restriction_id") %>' />
</ItemTemplate>
<EditItemTemplate>
<asp:HiddenField ID="MobileOrderIssueRestriction_restriction_id" runat="server" Value='<%# Bind(Container.DataItem,"MobileOrderIssueRestriction.restriction_id") %>' />
</EditItemTemplate>
<InsertItemTemplate>
<asp:HiddenField ID="MobileOrderIssueRestriction_restriction_id" runat="server" Value='<%# Bind(Container.DataItem,"MobileOrderIssueRestriction.restriction_id") %>' />
</InsertItemTemplate>
</asp:TemplateField>

<asp:TemplateField Visible="true" HeaderText="Restriction Name">
<ItemTemplate>
<asp:Literal ID="MobileOrderIssueRestriction_name" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"MobileOrderIssueRestriction.name") %>'></asp:Literal>
</ItemTemplate>
<EditItemTemplate>
<asp:TextBox ID="MobileOrderIssueRestriction_name" runat="server" Text='<%# Bind(Container.DataItem,"MobileOrderIssueRestriction_name") %>'></asp:TextBox>
</EditItemTemplate>
<InsertItemTemplate>
<asp:TextBox ID="MobileOrderIssueRestriction_name" runat="server" Text='<%# Bind(Container.DataItem,"MobileOrderIssueRestriction_name") %>'></asp:TextBox>
</InsertItemTemplate>
</asp:TemplateField>

<asp:TemplateField Visible="true" HeaderText="Create Date">
<ItemTemplate>
<asp:Literal ID="MobileOrderIssueRestriction_cdate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"MobileOrderIssueRestriction.cdate","{0:dd/MM/yyyy HH:mm:ss}") %>'></asp:Literal>
</ItemTemplate>
<EditItemTemplate>
<asp:Literal ID="MobileOrderIssueRestriction_cdate" runat="server" Text='<%# Bind(Container.DataItem,"MobileOrderIssueRestriction_cdate","{0:dd/MM/yyyy HH:mm:ss}") %>'></asp:Literal>
</EditItemTemplate>
<InsertItemTemplate>
<asp:TextBox ID="MobileOrderIssueRestriction_cdate" runat="server" Text='<%# Bind(Container.DataItem,"MobileOrderIssueRestriction_cdate","{0:dd/MM/yyyy HH:mm:ss}") %>'></asp:TextBox>
</InsertItemTemplate>
</asp:TemplateField>

<asp:TemplateField Visible="true" HeaderText="Staff No.">
<ItemTemplate>
<asp:Literal ID="MobileOrderIssueRestriction_cid" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"MobileOrderIssueRestriction.cid") %>'></asp:Literal>
</ItemTemplate>
<EditItemTemplate>
<asp:TextBox ID="MobileOrderIssueRestriction_cid" runat="server" Text='<%# Bind(Container.DataItem,"MobileOrderIssueRestriction_cid") %>'></asp:TextBox>
</EditItemTemplate>
<InsertItemTemplate>
<asp:TextBox ID="MobileOrderIssueRestriction_cid" runat="server" Text='<%# Bind(Container.DataItem,"MobileOrderIssueRestriction_cid") %>'></asp:TextBox>
</InsertItemTemplate>
</asp:TemplateField>

<asp:TemplateField Visible="true" HeaderText="Restriction Type">
<ItemTemplate>
<asp:Literal ID="MobileOrderIssueRestriction_type" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"MobileOrderIssueRestriction.type") %>'></asp:Literal>
</ItemTemplate>
<EditItemTemplate>
<asp:DropDownList ID="MobileOrderIssueRestriction_type" runat="server" SelectedValue='<%# Bind(Container.DataItem,"MobileOrderIssueRestriction_type") %>'>
<asp:ListItem Text="" Value=""></asp:ListItem>
<asp:ListItem Text="ALL" Value="ALL"></asp:ListItem>
<asp:ListItem Text="SPECIAL MOBILE NUMBER" Value="SPECIAL_MOBILE_NUMBER"></asp:ListItem>
</asp:DropDownList>
</EditItemTemplate>
<InsertItemTemplate>
<asp:DropDownList ID="MobileOrderIssueRestriction_type" runat="server" SelectedValue='<%# Bind(Container.DataItem,"MobileOrderIssueRestriction_type") %>'>
<asp:ListItem Text="" Value=""></asp:ListItem>
<asp:ListItem Text="ALL" Value="ALL"></asp:ListItem>
<asp:ListItem Text="SPECIAL MOBILE NUMBER" Value="SPECIAL_MOBILE_NUMBER"></asp:ListItem>
</asp:DropDownList>
</InsertItemTemplate>

</asp:TemplateField>
<asp:TemplateField Visible="true" HeaderText="Active">
<ItemTemplate>
<asp:CheckBox ID="MobileOrderIssueRestriction_active" runat="server" Checked='<%# DataBinder.Eval(Container.DataItem,"MobileOrderIssueRestriction.active") %>' Enabled="false" />
</ItemTemplate>
<EditItemTemplate>
<asp:CheckBox ID="MobileOrderIssueRestriction_active" runat="server" Checked='<%# Bind(Container.DataItem,"MobileOrderIssueRestriction_active") %>' />
</EditItemTemplate>
<InsertItemTemplate>
<asp:CheckBox ID="MobileOrderIssueRestriction_active" runat="server" Checked='<%# Bind("MobileOrderIssueRestriction_active") %>' />
</InsertItemTemplate>
</asp:TemplateField>

</Columns>
</asp:GridView>
<br />

<asp:ObjectDataSource ID="MobileOrderIssueRestrictionObj" runat="server" 
 DataObjectTypeName="PCCW.RWL.CORE.MobileOrderIssueRestrictionView" TypeName="PCCW.RWL.CORE.MobileOrderIssueRestrictionViewDAO"
 DeleteMethod="DeleteMobileOrderIssueRestrictionView" InsertMethod="InsertMobileOrderIssueRestrictionView" SelectCountMethod="CountAll" SortParameterName="x_sSortExpression"
 MaximumRowsParameterName="x_iPageSize"  StartRowIndexParameterName="x_iStartRow" EnablePaging="true"
 SelectMethod="FindALL" UpdateMethod="UpdateMobileOrderIssueRestrictionView" OldValuesParameterFormatString="original_{0}" >

 </asp:ObjectDataSource>
</td>
</tr>
</table>

       </TD>
       </TR>
    </TABLE>
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
