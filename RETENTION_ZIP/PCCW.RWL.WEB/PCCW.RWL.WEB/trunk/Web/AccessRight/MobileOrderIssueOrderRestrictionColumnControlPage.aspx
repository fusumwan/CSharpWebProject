<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MobileOrderIssueOrderRestrictionColumnControlPage.aspx.cs" Inherits="Web_AccessRight_MobileOrderIssueOrderRestrictionColumnControlPage" %>

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
       <H2>&nbsp;&nbsp;Mobile Order Issue Order Restriction Column Control Page</H2>
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
       <asp:FormView ID="MobileOrderIssueRestrictionColumnFV" runat="server"  CssClass="table-report" DefaultMode="Insert" 
               DataKeyNames="MobileOrderIssueRestrictionColumn_restriction_id,MobileOrderIssueRestrictionColumn_restriction_column,MobileOrderIssueRestrictionColumn_cid,MobileOrderIssueRestrictionColumn_restriction_value" 
               DataSourceID="MobileOrderIssueRestrictionColumnObj" 
               onitemcreated="MobileOrderIssueRestrictionColumnFV_ItemCreated">
           <InsertItemTemplate>
           <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">  
                <tr>
                    <th colspan="2">
                    Assign New Issue Order Restriction Column Name
                    </th>
                </tr>
                
                <tr>
                    <td width="23%" height="25" class="row2">
                    <span class="explaintitle" style="font-size:7pt">
                    Restriction Name
                    </span>
                    </td>
                    <td width="77%" height="25" class="row1">
                    <asp:DropDownList ID="MobileOrderIssueRestrictionColumn_restriction_id" runat="server"  ValidationGroup="MobileOrderIssueRestrictionColumnValid"  DataTextField='name' DataValueField='restriction_id' DataSource='<%# GetRestrictionDS() %>'   Display="Static" InitialValue="0" 
                     SelectedValue='<%# Bind("MobileOrderIssueRestrictionColumn_restriction_id") %>' >
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ValidationGroup="MobileOrderIssueRestrictionColumnFVValid" ID="MobileOrderIssueRestrictionColumn_restriction_id_valid" runat="server" ControlToValidate="MobileOrderIssueRestrictionColumn_restriction_id" ErrorMessage="Please kindy select the restriction name">
                    </asp:RequiredFieldValidator>
                    </td>
                </tr>
                
                <tr>
                    <td width="23%" height="25" class="row2">
                    <span class="explaintitle" style="font-size:7pt">
                    Restriction Column
                    </span>
                    </td>
                    <td width="77%" height="25" class="row1">
                    <asp:DropDownList ID="MobileOrderIssueRestrictionColumn_restriction_column" runat="server"  ValidationGroup="MobileOrderIssueRestrictionColumnValid" 
                     SelectedValue='<%# Bind("MobileOrderIssueRestrictionColumn_restriction_column") %>' >
                    <asp:ListItem Text='' Value=''></asp:ListItem>
                    <asp:ListItem Text='SUSPEND' Value='action_eff_date'></asp:ListItem>
                    <asp:ListItem Text='TRADE FIELD' Value='trade_field'></asp:ListItem>
                    <asp:ListItem Text='CHECK ORDER RELEASED' Value='order_id'></asp:ListItem>
                    <asp:ListItem Text='CONTACT EFFECT DATE' Value='con_eff_date'></asp:ListItem>
                    <asp:ListItem Text='BILL CUT DATE' Value='bill_cut_date'></asp:ListItem>
                    </asp:DropDownList>
                    
                    <asp:RequiredFieldValidator ValidationGroup="MobileOrderIssueRestrictionColumnFVValid" ID="MobileOrderIssueRestrictionColumn_restriction_column_valid" runat="server" ControlToValidate="MobileOrderIssueRestrictionColumn_restriction_column" ErrorMessage="Please kindy select the restriction column">
                    </asp:RequiredFieldValidator>
                    
                    </td>
                </tr>
                
                <tr>
                    <td  width="23%" height="25" class="row2">
                    <span class="explaintitle" style="font-size:7pt">
                    Staff No.
                    </span>
                    </td>
                    <td  width="77%" height="25" class="row1">
                    <asp:TextBox ID="MobileOrderIssueRestrictionColumn_cid" runat="server"  ValidationGroup="MobileOrderIssueRestrictionColumnValid"  Text='<%# Bind("MobileOrderIssueRestrictionColumn_cid") %>' BackColor="Yellow">
                    </asp:TextBox>
                    
                    <asp:RequiredFieldValidator ValidationGroup="MobileOrderIssueRestrictionColumnFVValid" ID="MobileOrderIssueRestrictionColumn_cid_valid" ControlToValidate="MobileOrderIssueRestrictionColumn_cid" runat="server"  ErrorMessage="Please kindy select the staff no">
                    </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td  width="23%" height="25" class="row2">
                    <span class="explaintitle" style="font-size:7pt">
                    Restriction Value
                    </span>
                    </td>
                    <td  width="77%" height="25" class="row1">
                    <asp:DropDownList ID="MobileOrderIssueRestrictionColumn_restriction_value"  
                    ValidationGroup="MobileOrderIssueRestrictionColumnFVValid"  runat="server" 
                    SelectedValue='<%# Bind("MobileOrderIssueRestrictionColumn_restriction_value") %>'>
                    <asp:ListItem Text="" Value=""></asp:ListItem>
                    <asp:ListItem Text="0" Value="0"></asp:ListItem>
                    <asp:ListItem Text="1" Value="1"></asp:ListItem>
                    <asp:ListItem Text="2" Value="2"></asp:ListItem>
                    <asp:ListItem Text="3" Value="3"></asp:ListItem>
                    <asp:ListItem Text="4" Value="4"></asp:ListItem>
                    <asp:ListItem Text="5" Value="5"></asp:ListItem>
                    <asp:ListItem Text="6" Value="6"></asp:ListItem>
                    <asp:ListItem Text="7" Value="7"></asp:ListItem>
                    <asp:ListItem Text="8" Value="8"></asp:ListItem>
                    <asp:ListItem Text="9" Value="9"></asp:ListItem>
                    <asp:ListItem Text="10" Value="10"></asp:ListItem>
                    <asp:ListItem Text="11" Value="11"></asp:ListItem>
                    <asp:ListItem Text="12" Value="12"></asp:ListItem>
                    <asp:ListItem Text="13" Value="13"></asp:ListItem>
                    <asp:ListItem Text="14" Value="14"></asp:ListItem>
                    <asp:ListItem Text="15" Value="15"></asp:ListItem>
                    <asp:ListItem Text="16" Value="16"></asp:ListItem>
                    <asp:ListItem Text="17" Value="17"></asp:ListItem>
                    <asp:ListItem Text="18" Value="18"></asp:ListItem>
                    <asp:ListItem Text="19" Value="19"></asp:ListItem>
                    <asp:ListItem Text="20" Value="20"></asp:ListItem>
                    <asp:ListItem Text="21" Value="21"></asp:ListItem>
                    <asp:ListItem Text="22" Value="22"></asp:ListItem>
                    <asp:ListItem Text="23" Value="23"></asp:ListItem>
                    <asp:ListItem Text="24" Value="24"></asp:ListItem>
                    <asp:ListItem Text="25" Value="25"></asp:ListItem>
                    <asp:ListItem Text="26" Value="26"></asp:ListItem>
                    <asp:ListItem Text="27" Value="27"></asp:ListItem>
                    <asp:ListItem Text="28" Value="28"></asp:ListItem>
                    <asp:ListItem Text="29" Value="29"></asp:ListItem>
                    <asp:ListItem Text="30" Value="30"></asp:ListItem>

                    </asp:DropDownList>
                    
                    <asp:RequiredFieldValidator ValidationGroup="MobileOrderIssueRestrictionColumnFVValid" 
                    ID="MobileOrderIssueRestrictionColumn_restriction_value_valid" 
                    ControlToValidate="MobileOrderIssueRestrictionColumn_restriction_value" 
                    runat="server" 
                    ErrorMessage="Please kindy enter the staff no.">
                    </asp:RequiredFieldValidator>
                    </td>
                </tr>
                
                <tr>
                   <td>
                   <asp:Button ID="InsertBut"  
                           ValidationGroup="MobileOrderIssueRestrictionColumnFVValid"  
                           CommandName="INSERT" Text="INSERT" CssClass="button" runat="server" 
                           onclick="InsertBut_Click" />
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
                <asp:DropDownList AutoPostBack="true"  
                        ID="MobileOrderIssueRestrictionColumn_restriction_id" DataTextField='name' 
                        DataValueField='restriction_id'   runat="server" AppendDataBoundItems="true" 
                        onselectedindexchanged="MobileOrderIssueRestrictionColumn_restriction_id_SelectedIndexChanged" > 
                </asp:DropDownList>
                </td>
                </tr>
                <tr>
                <td>
                <asp:GridView ID="MobileOrderIssueRestrictionColumnGV" runat="server" 
                    DataKeyNames="Index" DataSourceID="MobileOrderIssueRestrictionColumnObj"
                    CssClass="table-report" AutoGenerateColumns="False" 
                        onrowupdating="MobileOrderIssueRestrictionColumnGV_RowUpdating"  >
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


<asp:TemplateField Visible="False">
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


<asp:TemplateField Visible="true">
<ItemTemplate>
<asp:HiddenField ID="MobileOrderIssueRestrictionColumn_mid" runat="server" Value='<%# DataBinder.Eval(Container.DataItem,"MobileOrderIssueRestrictionColumn.mid") %>' />
</ItemTemplate>
<EditItemTemplate>

<asp:HiddenField ID="MobileOrderIssueRestrictionColumn_mid" runat="server" Value='<%# Bind(Container.DataItem,"MobileOrderIssueRestrictionColumn_mid") %>' />
</EditItemTemplate>
<InsertItemTemplate>
<asp:HiddenField ID="MobileOrderIssueRestrictionColumn_mid" runat="server" Value='<%# Bind(Container.DataItem,"MobileOrderIssueRestrictionColumn_mid") %>' />
</InsertItemTemplate>
</asp:TemplateField>


<asp:TemplateField Visible="true" HeaderText="Restriction Name">
<ItemTemplate>
<asp:DropDownList ID="MobileOrderIssueRestrictionColumn_restriction_id" DataTextField='name' DataValueField='restriction_id' DataSource='<%# GetRestrictionDS() %>'  runat="server" AppendDataBoundItems="true" SelectedValue='<%# DataBinder.Eval(Container.DataItem,"MobileOrderIssueRestrictionColumn.restriction_id") %>' Enabled="false"> 
</asp:DropDownList>
</ItemTemplate>
<EditItemTemplate>
<asp:DropDownList ID="MobileOrderIssueRestrictionColumn_restriction_id" DataTextField='name' DataValueField='restriction_id'  DataSource='<%# GetRestrictionDS() %>' runat="server" AppendDataBoundItems="true" SelectedValue='<%# Bind(Container.DataItem,"MobileOrderIssueRestrictionColumn_restriction_id") %>'> 
</asp:DropDownList>
<asp:RequiredFieldValidator ValidationGroup="MobileOrderIssueRestrictionColumnValidGV" ID="MobileOrderIssueRestrictionColumn_restriction_id_valid" runat="server" ControlToValidate="MobileOrderIssueRestrictionColumn_restriction_id" ErrorMessage="Please kindy select the restriction name" Display="Static" InitialValue="0">
</asp:RequiredFieldValidator>
</EditItemTemplate>
<InsertItemTemplate>
<asp:DropDownList ID="MobileOrderIssueRestrictionColumn_restriction_id" DataTextField='name' DataValueField='restriction_id'  DataSource='<%# GetRestrictionDS() %>'  runat="server" AppendDataBoundItems="true" SelectedValue='<%# Bind(Container.DataItem,"MobileOrderIssueRestrictionColumn_restriction_id") %>'> 
</asp:DropDownList>
<asp:RequiredFieldValidator ValidationGroup="MobileOrderIssueRestrictionColumnValidGV" ID="MobileOrderIssueRestrictionColumn_restriction_id_valid" runat="server" ControlToValidate="MobileOrderIssueRestrictionColumn_restriction_id" ErrorMessage="Please kindy select the restriction name">
</asp:RequiredFieldValidator>
</InsertItemTemplate>
</asp:TemplateField>


<asp:TemplateField Visible="true" HeaderText="Restriction Column">
<ItemTemplate>
<asp:DropDownList ID="MobileOrderIssueRestrictionColumn_restriction_column" runat="server" SelectedValue='<%# DataBinder.Eval(Container.DataItem,"MobileOrderIssueRestrictionColumn.restriction_column") %>' AppendDataBoundItems="true" Enabled="false">
<asp:ListItem Text='' Value=''></asp:ListItem>
<asp:ListItem Text='SUSPEND' Value='action_eff_date'></asp:ListItem>
<asp:ListItem Text='TRADE FIELD' Value='trade_field'></asp:ListItem>
<asp:ListItem Text='CHECK ORDER RELEASED' Value='order_id'></asp:ListItem>
<asp:ListItem Text='CONTACT EFFECT DATE' Value='con_eff_date'></asp:ListItem>
<asp:ListItem Text='BILL CUT DATE' Value='bill_cut_date'></asp:ListItem>
</asp:DropDownList>
</ItemTemplate>
<EditItemTemplate>
<asp:DropDownList ID="MobileOrderIssueRestrictionColumn_restriction_column" runat="server" SelectedValue='<%# Bind(Container.DataItem,"MobileOrderIssueRestrictionColumn_restriction_column") %>' AppendDataBoundItems="true">
<asp:ListItem Text='' Value=''></asp:ListItem>
<asp:ListItem Text='SUSPEND' Value='action_eff_date'></asp:ListItem>
<asp:ListItem Text='TRADE FIELD' Value='trade_field'></asp:ListItem>
<asp:ListItem Text='CHECK ORDER RELEASED' Value='order_id'></asp:ListItem>
<asp:ListItem Text='CONTACT EFFECT DATE' Value='con_eff_date'></asp:ListItem>
<asp:ListItem Text='BILL CUT DATE' Value='bill_cut_date'></asp:ListItem>
</asp:DropDownList>
<asp:RequiredFieldValidator ValidationGroup="MobileOrderIssueRestrictionColumnValidGV" ID="MobileOrderIssueRestrictionColumn_restriction_column_valid" runat="server" ControlToValidate="MobileOrderIssueRestrictionColumn_restriction_column" ErrorMessage="Please kindy select the restriction column">
</asp:RequiredFieldValidator>
</EditItemTemplate>
<InsertItemTemplate>
<asp:DropDownList ID="MobileOrderIssueRestrictionColumn_restriction_column" runat="server" SelectedValue='<%# Bind(Container.DataItem,"MobileOrderIssueRestrictionColumn_restriction_column") %>' AppendDataBoundItems="true">
<asp:ListItem Text='' Value=''></asp:ListItem>
<asp:ListItem Text='SUSPEND' Value='action_eff_date'></asp:ListItem>
<asp:ListItem Text='TRADE FIELD' Value='trade_field'></asp:ListItem>
<asp:ListItem Text='CHECK ORDER RELEASED' Value='order_id'></asp:ListItem>
<asp:ListItem Text='CONTACT EFFECT DATE' Value='con_eff_date'></asp:ListItem>
<asp:ListItem Text='BILL CUT DATE' Value='bill_cut_date'></asp:ListItem>
</asp:DropDownList>
<asp:RequiredFieldValidator ValidationGroup="MobileOrderIssueRestrictionColumnValidGV" ID="MobileOrderIssueRestrictionColumn_restriction_column_valid" runat="server" ControlToValidate="MobileOrderIssueRestrictionColumn_restriction_column" ErrorMessage="Please kindy select the restriction column">
</asp:RequiredFieldValidator>
</InsertItemTemplate>
</asp:TemplateField>



<asp:TemplateField Visible="true"  HeaderText="Restriction Value">
<ItemTemplate>
<asp:Literal ID="MobileOrderIssueRestrictionColumn_restriction_value" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"MobileOrderIssueRestrictionColumn.restriction_value") %>'></asp:Literal>
</ItemTemplate>
<EditItemTemplate>
                    <asp:DropDownList ID="MobileOrderIssueRestrictionColumn_restriction_value"  
                    ValidationGroup="MobileOrderIssueRestrictionColumnValid"  runat="server" 
                    SelectedValue='<%# Bind("MobileOrderIssueRestrictionColumn_restriction_value") %>'>
                    <asp:ListItem Text="" Value=""></asp:ListItem>
                    <asp:ListItem Text="0" Value="0"></asp:ListItem>
                    <asp:ListItem Text="1" Value="1"></asp:ListItem>
                    <asp:ListItem Text="2" Value="2"></asp:ListItem>
                    <asp:ListItem Text="3" Value="3"></asp:ListItem>
                    <asp:ListItem Text="4" Value="4"></asp:ListItem>
                    <asp:ListItem Text="5" Value="5"></asp:ListItem>
                    <asp:ListItem Text="6" Value="6"></asp:ListItem>
                    <asp:ListItem Text="7" Value="7"></asp:ListItem>
                    <asp:ListItem Text="8" Value="8"></asp:ListItem>
                    <asp:ListItem Text="9" Value="9"></asp:ListItem>
                    <asp:ListItem Text="10" Value="10"></asp:ListItem>
                    <asp:ListItem Text="11" Value="11"></asp:ListItem>
                    <asp:ListItem Text="12" Value="12"></asp:ListItem>
                    <asp:ListItem Text="13" Value="13"></asp:ListItem>
                    <asp:ListItem Text="14" Value="14"></asp:ListItem>
                    <asp:ListItem Text="15" Value="15"></asp:ListItem>
                    <asp:ListItem Text="16" Value="16"></asp:ListItem>
                    <asp:ListItem Text="17" Value="17"></asp:ListItem>
                    <asp:ListItem Text="18" Value="18"></asp:ListItem>
                    <asp:ListItem Text="19" Value="19"></asp:ListItem>
                    <asp:ListItem Text="20" Value="20"></asp:ListItem>
                    <asp:ListItem Text="21" Value="21"></asp:ListItem>
                    <asp:ListItem Text="22" Value="22"></asp:ListItem>
                    <asp:ListItem Text="23" Value="23"></asp:ListItem>
                    <asp:ListItem Text="24" Value="24"></asp:ListItem>
                    <asp:ListItem Text="25" Value="25"></asp:ListItem>
                    <asp:ListItem Text="26" Value="26"></asp:ListItem>
                    <asp:ListItem Text="27" Value="27"></asp:ListItem>
                    <asp:ListItem Text="28" Value="28"></asp:ListItem>
                    <asp:ListItem Text="29" Value="29"></asp:ListItem>
                    <asp:ListItem Text="30" Value="30"></asp:ListItem>

                    </asp:DropDownList>
                    
                    <asp:RequiredFieldValidator ValidationGroup="MobileOrderIssueRestrictionColumnValidGV" 
                    ID="MobileOrderIssueRestrictionColumn_restriction_value_valid" 
                    ControlToValidate="MobileOrderIssueRestrictionColumn_restriction_value" 
                    runat="server" 
                    ErrorMessage="Please kindy select the staff no."></asp:RequiredFieldValidator>
</EditItemTemplate>
<InsertItemTemplate>
<asp:TextBox ID="MobileOrderIssueRestrictionColumn_restriction_value" runat="server" Text='<%# Bind(Container.DataItem,"MobileOrderIssueRestrictionColumn_restriction_value") %>'></asp:TextBox>
</InsertItemTemplate>
</asp:TemplateField>


<asp:TemplateField Visible="true"  HeaderText="Action Type">
<ItemTemplate>
<asp:Literal ID="MobileOrderIssueRestrictionColumn_action_type" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"MobileOrderIssueRestrictionColumn.action_type") %>'></asp:Literal>
</ItemTemplate>
<EditItemTemplate>
                    <asp:DropDownList ID="MobileOrderIssueRestrictionColumn_action_type"  runat="server" 
                    SelectedValue='<%# Bind("MobileOrderIssueRestrictionColumn_action_type") %>'>
                    <asp:ListItem Text="EQUAL" Value="EQUAL"></asp:ListItem>
                    <asp:ListItem Text="DATEADD_MONTH" Value="DATEADD_MONTH"></asp:ListItem>
                    <asp:ListItem Text="SELECT" Value="SELECT"></asp:ListItem>
                    </asp:DropDownList>

</EditItemTemplate>
<InsertItemTemplate>

<asp:DropDownList ID="MobileOrderIssueRestrictionColumn_action_type"  runat="server" 
                    SelectedValue='<%# Bind("MobileOrderIssueRestrictionColumn_action_type") %>'>
                    <asp:ListItem Text="EQUAL" Value="EQUAL"></asp:ListItem>
                    <asp:ListItem Text="DATEADD_MONTH" Value="DATEADD_MONTH"></asp:ListItem>
                    <asp:ListItem Text="SELECT" Value="SELECT"></asp:ListItem>
                    </asp:DropDownList>
</InsertItemTemplate>
</asp:TemplateField>



<asp:TemplateField Visible="true" HeaderText="Staff No.">
<ItemTemplate>
<asp:Literal ID="MobileOrderIssueRestrictionColumn_cid" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"MobileOrderIssueRestrictionColumn.cid") %>'></asp:Literal>
</ItemTemplate>
<EditItemTemplate>
<asp:TextBox ID="MobileOrderIssueRestrictionColumn_cid" BackColor="Yellow" runat="server" Text='<%# Bind(Container.DataItem,"MobileOrderIssueRestrictionColumn_cid") %>' ReadOnly="true"></asp:TextBox>
</EditItemTemplate>
<InsertItemTemplate>
<asp:TextBox ID="MobileOrderIssueRestrictionColumn_cid" runat="server" Text='<%# Bind(Container.DataItem,"MobileOrderIssueRestrictionColumn_cid") %>'></asp:TextBox>
</InsertItemTemplate>
</asp:TemplateField>



<asp:TemplateField Visible="true" HeaderText="Create Date">
<ItemTemplate>
<asp:Literal ID="MobileOrderIssueRestrictionColumn_cdate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"MobileOrderIssueRestrictionColumn.cdate","{0:dd/MM/yyyy HH:mm:ss}") %>'></asp:Literal>
</ItemTemplate>
<EditItemTemplate>
<asp:Literal ID="MobileOrderIssueRestrictionColumn_cdate" runat="server" Text='<%# Bind(Container.DataItem,"MobileOrderIssueRestrictionColumn_cdate","{0:dd/MM/yyyy HH:mm:ss}") %>' ></asp:Literal>

</EditItemTemplate>
<InsertItemTemplate>
<asp:TextBox ID="MobileOrderIssueRestrictionColumn_cdate" runat="server" Text='<%# Bind(Container.DataItem,"MobileOrderIssueRestrictionColumn_cdate","{0:dd/MM/yyyy HH:mm:ss}") %>' ReadOnly="true"></asp:TextBox>
 <asp:ImageButton runat="server" ID="CalenderImageCDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
 <asp:RequiredFieldValidator ValidationGroup="MobileOrderIssueRestrictionColumnValidGV" 
ID="MobileOrderIssueRestrictionColumn_restriction_value_cdate" 
ControlToValidate="MobileOrderIssueRestrictionColumn_cdate" 
runat="server" 
ErrorMessage="Please kindy select the staff no.">
</asp:RequiredFieldValidator>

</InsertItemTemplate>
</asp:TemplateField>



<asp:TemplateField Visible="true" HeaderText="Active">
<ItemTemplate>
<asp:CheckBox ID="MobileOrderIssueRestrictionColumn_active" runat="server" Checked='<%# DataBinder.Eval(Container.DataItem,"MobileOrderIssueRestrictionColumn.active") %>' Enabled="false" />
</ItemTemplate>
<EditItemTemplate>
<asp:CheckBox ID="MobileOrderIssueRestrictionColumn_active" runat="server" Checked='<%# Bind(Container.DataItem,"MobileOrderIssueRestrictionColumn_active") %>' />
</EditItemTemplate>
<InsertItemTemplate>
<asp:CheckBox ID="MobileOrderIssueRestrictionColumn_active" runat="server" Checked='<%# Bind(Container.DataItem,"MobileOrderIssueRestrictionColumn_active") %>' />
</InsertItemTemplate>
</asp:TemplateField>
</Columns>
</asp:GridView>
<br />
<asp:ObjectDataSource ID="MobileOrderIssueRestrictionColumnObj" runat="server" 
 DataObjectTypeName="PCCW.RWL.CORE.MobileOrderIssueRestrictionColumnView" TypeName="PCCW.RWL.CORE.MobileOrderIssueRestrictionColumnViewDAO"
 DeleteMethod="DeleteMobileOrderIssueRestrictionColumnView" 
                        InsertMethod="InsertMobileOrderIssueRestrictionColumnView" 
                        SelectCountMethod="CountAll" SortParameterName="x_sSortExpression"
 MaximumRowsParameterName="x_iPageSize"  StartRowIndexParameterName="x_iStartRow" 
                        EnablePaging="true" 
 SelectMethod="FindALL" UpdateMethod="UpdateMobileOrderIssueRestrictionColumnView" 
                        OldValuesParameterFormatString="original_{0}" 
                        onselecting="MobileOrderIssueRestrictionColumnObj_Selecting" >
 </asp:ObjectDataSource>
 
                    <br />
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
