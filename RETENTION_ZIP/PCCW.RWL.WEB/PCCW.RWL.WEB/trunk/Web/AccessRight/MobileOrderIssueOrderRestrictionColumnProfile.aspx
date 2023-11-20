<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MobileOrderIssueOrderRestrictionColumnProfile.aspx.cs" Inherits="Web_AccessRight_MobileOrderIssueOrderRestrictionColumnProfile" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
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
       <H2>&nbsp;&nbsp;Mobile Order Issue Order Restriction Mobile List Control Page</H2>
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
       <asp:FormView ID="MobileOrderIssueRestrictionProfileFV" runat="server" CssClass="table-report" DefaultMode="Insert" 
               DataSourceID="MobileOrderIssueRestrictionProfileObj" 
               
               DataKeyNames="MobileOrderIssueRestrictionProfile_mrt_no,MobileOrderIssueRestrictionProfile_cid,MobileOrderIssueRestrictionProfile_restriction_id" 
               onitemcreated="MobileOrderIssueRestrictionProfileFV_ItemCreated">
           <InsertItemTemplate>

                <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">  
                <tr>
                    <th colspan="2">
                    Assign New Mobile Number Into Order Restriction List
                    </th>
                </tr>
                <tr>
                    <td width="23%" height="25" class="row2">
                    <span class="explaintitle" style="font-size:7pt">
                    Restriction Name
                    </span>
                    </td>
                    <td width="77%" height="25" class="row1">
                    <asp:DropDownList ID="MobileOrderIssueRestrictionProfile_restriction_id" runat="server"   ValidationGroup="MobileOrderIssueRestrictionProfileValid"  DataTextField='name' DataValueField='restriction_id' DataSource='<%# GetRestrictionDS() %>'  
                     SelectedValue='<%# Bind("MobileOrderIssueRestrictionProfile_restriction_id") %>' >
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ValidationGroup="MobileOrderIssueRestrictionProfileValid" ID="MobileOrderIssueRestrictionProfile_restriction_id_valid" runat="server" ControlToValidate="MobileOrderIssueRestrictionProfile_restriction_id" Display="Static" InitialValue="0" ErrorMessage="Please kindy select the restriction name">
                    </asp:RequiredFieldValidator>
                    </td>
                </tr>
                
                <tr>
                    <td width="23%" height="25" class="row2">
                    <span class="explaintitle" style="font-size:7pt">
                    Mobile Number
                    </span>
                    </td>
                    <td width="77%" height="25" class="row1">
                    <asp:TextBox ID="MobileOrderIssueRestrictionProfile_mrt_no"  ValidationGroup="MobileOrderIssueRestrictionProfileValid"  runat="server" Text='<%# Bind("MobileOrderIssueRestrictionProfile_mrt_no") %>' />
                    <asp:RequiredFieldValidator ValidationGroup="MobileOrderIssueRestrictionProfileValid" ID="MobileOrderIssueRestrictionProfile_mrt_no_valid" runat="server" ControlToValidate="MobileOrderIssueRestrictionProfile_mrt_no" ErrorMessage="Please kindy enter the mobile number"></asp:RequiredFieldValidator>
                    
                    </td>
                </tr>
                
                 <tr>
                    <td width="23%" height="25" class="row2">
                    <span class="explaintitle" style="font-size:7pt">
                    Staff No.
                    </span>
                    </td>
                    <td width="77%" height="25" class="row1">
                    <asp:TextBox ID="MobileOrderIssueRestrictionProfile_cid" BackColor="Yellow"  ValidationGroup="MobileOrderIssueRestrictionProfileValid" runat="server" Text='<%# Bind("MobileOrderIssueRestrictionProfile_cid") %>' />
                    <asp:RequiredFieldValidator ValidationGroup="MobileOrderIssueRestrictionProfileValid" ID="MobileOrderIssueRestrictionProfile_cid_valid" runat="server" ControlToValidate="MobileOrderIssueRestrictionProfile_cid" ErrorMessage="Please kindy enter the mobile number"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                
                <tr>
                   <td>
                   <asp:Button ID="InsertBut"  ValidationGroup="MobileOrderIssueRestrictionProfileValid"  CommandName="INSERT" Text="INSERT" CssClass="button" runat="server" />
                   </td>
                   <td>
                   </td>
                </tr>
                </table>
           </InsertItemTemplate>
       </asp:FormView>
        <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">  
                        <tr>
                <td align="left">Restriction Name:
                <asp:DropDownList AutoPostBack="true" AppendDataBoundItems="true" 
                        ID="MobileOrderIssueRestrictionProfile_restriction_id" 
                        DataTextField='name' DataValueField='restriction_id'  runat="server" 
                        onselectedindexchanged="MobileOrderIssueRestrictionProfile_restriction_id_SelectedIndexChanged"> 
                </asp:DropDownList>
                </td>
                </tr>
                <tr>
                <td>

<asp:GridView ID="MobileOrderIssueRestrictionProfileGV" runat="server" DataKeyNames="Index" DataSourceID="MobileOrderIssueRestrictionProfileObj"
CssClass="table-report"
AutoGenerateColumns="false" onrowupdating="MobileOrderIssueRestrictionProfileGV_RowUpdating"  >
<Columns>

<asp:TemplateField Visible="true">
<ItemTemplate>
<asp:Button ID="EditBut" runat="server" CssClass="button" Text="EDIT" CommandName="EDIT" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
</ItemTemplate>
<EditItemTemplate>
<asp:Button ID="UpdateBut" runat="server" Text="UPDATE"  CssClass="button"  CommandName="UPDATE" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
<asp:Button ID="CancelBut" runat="server" Text="CANCEL"  CssClass="button"  CommandName="CANCEL" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
</EditItemTemplate>
</asp:TemplateField>

<asp:TemplateField Visible="false">
<ItemTemplate>
<asp:Literal ID="Index" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"Index") %>'></asp:Literal>
</ItemTemplate>
<EditItemTemplate>
<asp:TextBox ID="Index" runat="server" Text='<%# Bind(Container.DataItem,"Index") %>'></asp:TextBox>
</EditItemTemplate>
<InsertItemTemplate>
<asp:TextBox ID="Index" runat="server" Text='<%# Bind(Container.DataItem,"Index") %>'></asp:TextBox>
</InsertItemTemplate>
</asp:TemplateField>

<asp:TemplateField Visible="false">
<ItemTemplate>
<asp:HiddenField ID="MobileOrderIssueRestrictionProfile_mid" runat="server" Value='<%# DataBinder.Eval(Container.DataItem,"MobileOrderIssueRestrictionProfile.mid") %>' />
</ItemTemplate>
<EditItemTemplate>
<asp:HiddenField ID="MobileOrderIssueRestrictionProfile_mid" runat="server" Value='<%# Bind(Container.DataItem,"MobileOrderIssueRestrictionProfile_mid") %>' />
</EditItemTemplate>
<InsertItemTemplate>
<asp:HiddenField ID="MobileOrderIssueRestrictionProfile_mid" runat="server" Value='<%# Bind(Container.DataItem,"MobileOrderIssueRestrictionProfile_mid") %>' />
</InsertItemTemplate>
</asp:TemplateField>


<asp:TemplateField Visible="true" HeaderText="Restriction Name">
<ItemTemplate>
<asp:DropDownList ID="MobileOrderIssueRestrictionProfile_restriction_id" runat="server"  ValidationGroup="MobileOrderIssueRestrictionProfileGVValid"  DataTextField='name' DataValueField='restriction_id' DataSource='<%# GetRestrictionDS() %>'  
SelectedValue='<%# DataBinder.Eval(Container.DataItem,"MobileOrderIssueRestrictionProfile_restriction_id") %>'  Enabled="false">
</asp:DropDownList>
</ItemTemplate>
<EditItemTemplate>
<asp:DropDownList ID="MobileOrderIssueRestrictionProfile_restriction_id" runat="server"  ValidationGroup="MobileOrderIssueRestrictionProfileGVValid"  DataTextField='name' DataValueField='restriction_id' DataSource='<%# GetRestrictionDS() %>'  
SelectedValue='<%# Bind(Container.DataItem,"MobileOrderIssueRestrictionProfile_restriction_id") %>'  >
</asp:DropDownList>
<asp:RequiredFieldValidator ValidationGroup="MobileOrderIssueRestrictionProfileGVValid" ID="MobileOrderIssueRestrictionProfile_restriction_id_valid" runat="server" ControlToValidate="MobileOrderIssueRestrictionProfile_restriction_id"  Display="Static" InitialValue="0" ErrorMessage="Please kindy select the restriction name">
</asp:RequiredFieldValidator>

</EditItemTemplate>
<InsertItemTemplate>
<asp:DropDownList ID="MobileOrderIssueRestrictionProfile_restriction_id" runat="server"  ValidationGroup="MobileOrderIssueRestrictionProfileGVValid"  DataTextField='name' DataValueField='restriction_id' DataSource='<%# GetRestrictionDS() %>'  
SelectedValue='<%# Bind(Container.DataItem,"MobileOrderIssueRestrictionProfile_restriction_id") %>' >
</asp:DropDownList></InsertItemTemplate>
</asp:TemplateField>

<asp:TemplateField Visible="true" HeaderText="Mobile Number">
<ItemTemplate>
<asp:Literal ID="MobileOrderIssueRestrictionProfile_mrt_no" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"MobileOrderIssueRestrictionProfile.mrt_no") %>'></asp:Literal>
</ItemTemplate>
<EditItemTemplate>
<asp:TextBox ID="MobileOrderIssueRestrictionProfile_mrt_no" runat="server" Text='<%# Bind(Container.DataItem,"MobileOrderIssueRestrictionProfile_mrt_no") %>'></asp:TextBox>
<asp:RequiredFieldValidator ValidationGroup="MobileOrderIssueRestrictionProfileGVValid" ID="MobileOrderIssueRestrictionProfile_mrt_no_valid" runat="server" ControlToValidate="MobileOrderIssueRestrictionProfile_mrt_no" ErrorMessage="Please kindy enter the mobile number"></asp:RequiredFieldValidator>
</EditItemTemplate>
<InsertItemTemplate>
<asp:TextBox ID="MobileOrderIssueRestrictionProfile_mrt_no" runat="server" Text='<%# Bind(Container.DataItem,"MobileOrderIssueRestrictionProfile_mrt_no") %>'></asp:TextBox>
</InsertItemTemplate>
</asp:TemplateField>


<asp:TemplateField Visible="true" HeaderText="Staff No.">
<ItemTemplate>
<asp:Literal ID="MobileOrderIssueRestrictionProfile_cid" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"MobileOrderIssueRestrictionProfile.cid") %>'></asp:Literal>
</ItemTemplate>
<EditItemTemplate>
<asp:TextBox ID="MobileOrderIssueRestrictionProfile_cid" runat="server" Text='<%# Bind(Container.DataItem,"MobileOrderIssueRestrictionProfile_cid") %>'></asp:TextBox>
 <asp:RequiredFieldValidator ValidationGroup="MobileOrderIssueRestrictionProfileGVValid" ID="MobileOrderIssueRestrictionProfile_cid_valid" runat="server" ControlToValidate="MobileOrderIssueRestrictionProfile_cid" ErrorMessage="Please kindy enter the mobile number"></asp:RequiredFieldValidator>
</EditItemTemplate>
<InsertItemTemplate>
<asp:TextBox ID="MobileOrderIssueRestrictionProfile_cid" runat="server" Text='<%# Bind(Container.DataItem,"MobileOrderIssueRestrictionProfile_cid") %>'></asp:TextBox>
</InsertItemTemplate>
</asp:TemplateField>



<asp:TemplateField Visible="true" HeaderText="Create Date">
<ItemTemplate>
<asp:Literal ID="MobileOrderIssueRestrictionProfile_cdate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"MobileOrderIssueRestrictionProfile.cdate","{0:dd/MM/yyyy HH:mm:ss}") %>'></asp:Literal>
</ItemTemplate>
<EditItemTemplate>
<asp:Literal ID="MobileOrderIssueRestrictionProfile_cdate" runat="server" Text='<%# Bind(Container.DataItem,"MobileOrderIssueRestrictionProfile_cdate","{0:dd/MM/yyyy HH:mm:ss}") %>'></asp:Literal>
</EditItemTemplate>
<InsertItemTemplate>
<asp:TextBox ID="MobileOrderIssueRestrictionProfile_cdate" runat="server" Text='<%# Bind(Container.DataItem,"MobileOrderIssueRestrictionProfile_cdate","{0:dd/MM/yyyy HH:mm:ss}") %>'></asp:TextBox>
</InsertItemTemplate>
</asp:TemplateField>


<asp:TemplateField Visible="true" HeaderText="Active">
<ItemTemplate>
<asp:CheckBox ID="MobileOrderIssueRestrictionProfile_active" runat="server" Checked='<%# DataBinder.Eval(Container.DataItem,"MobileOrderIssueRestrictionProfile.active") %>' Enabled="true" />
</ItemTemplate>
<EditItemTemplate>
<asp:CheckBox ID="MobileOrderIssueRestrictionProfile_active" runat="server" Checked='<%# Bind(Container.DataItem,"MobileOrderIssueRestrictionProfile_active") %>' />
</EditItemTemplate>
<InsertItemTemplate>
<asp:CheckBox ID="MobileOrderIssueRestrictionProfile_active" runat="server" Checked='<%# Bind(Container.DataItem,"MobileOrderIssueRestrictionProfile_active") %>' />
</InsertItemTemplate>
</asp:TemplateField>




</Columns>
</asp:GridView>
<br />

<asp:ObjectDataSource ID="MobileOrderIssueRestrictionProfileObj" runat="server" 
 DataObjectTypeName="PCCW.RWL.CORE.MobileOrderIssueRestrictionProfileView" TypeName="PCCW.RWL.CORE.MobileOrderIssueRestrictionProfileViewDAO"
 DeleteMethod="DeleteMobileOrderIssueRestrictionProfileView" 
                        InsertMethod="InsertMobileOrderIssueRestrictionProfileView" 
                        SelectCountMethod="CountAll" SortParameterName="x_sSortExpression"
 MaximumRowsParameterName="x_iPageSize"  StartRowIndexParameterName="x_iStartRow" 
                        EnablePaging="true" FilterExpression=""
 SelectMethod="FindALL" UpdateMethod="UpdateMobileOrderIssueRestrictionProfileView" 
                        OldValuesParameterFormatString="original_{0}" 
                        onselecting="MobileOrderIssueRestrictionProfileObj_Selecting" >
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
