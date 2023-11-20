<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdateOrderToEDFByBatch.aspx.cs" Inherits="Web_IMEIManagement_UpdateOrderToEDFByBatch" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="~/UI/GlobalNavigation.ascx"TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet"  href="../../Resources/Styles/global.css"type="text/css" />
<link rel="stylesheet" href="../../Resources/Styles/MainPageStyle.css" type="text/css" />
<asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<script language="javascript">
    function BackMainPage() {
        document.location.href = "../MobileRetentionMain.aspx";
    }
</script>

    <style type="text/css">
        .style1
        {
            background: #d9e2ec;
            width: 147px;
        }
    </style>

</head>
<body style="background-color:#ffffff">
    <form id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
    <asp:ScriptManager ID="AddWebLogScriptManager" runat="server"></asp:ScriptManager>
    <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
      <tr> 
        <th width="100%" height="28" colspan="30">&nbsp;<%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></th>
      </tr>
     <tr> 
        <td class="style1"> 
        <input name="submit22" type="button" class="button" value="BACK" onClick="BackMainPage();"/>
        </td>
        <td class="row2"> 
  
        </td>
    </tr>
     <tr> 
        <td class="style1"> 
        <asp:Button ID="SearchOrder" runat="server" Text="Search Order"  
                ValidationGroup="search_group" CssClass="button" onclick="SearchOrder_Click" />
        </td>
        <td class="row2"> 
  
        </td>
    </tr>
    
    
     
     <tr>
            <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">
                <asp:Label ID="Label1" runat="server" Text="Delivery Date"></asp:Label></span></td>
            <td height="0" class="row1">
                <asp:TextBox ID="d_date" Font-Size="7pt" ReadOnly="false" MaxLength="10" runat="server"  ValidationGroup="search_group" ></asp:TextBox>
                <asp:ImageButton runat="server" ID="fromDeliveryDateImageButton" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                (DD/MM/YYYY) TO 
                <asp:TextBox ID="d_date2" Font-Size="7pt" ReadOnly="false" MaxLength="10" runat="server"  ValidationGroup="search_group" ></asp:TextBox>
                <asp:ImageButton runat="server" ID="toDeliveryDateImageButton" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                (DD/MM/YYYY)
                <asp:RequiredFieldValidator ID="RequiredDDateValue" ControlToValidate="d_date" ValidationGroup="search_group" runat="server" ErrorMessage="Required Expect Delivery Date"></asp:RequiredFieldValidator>
            </td>
        </tr>
        
        <tr>
        <td colspan="2" align="center">
        <asp:GridView ID="ReportMsg" runat="server" 
         CssClass="table-report"  
        AutoGenerateColumns="false"  >
        <Columns>
        <asp:TemplateField>
        <HeaderTemplate>
        <asp:Button ID="CLEAR_EVENT" Text="CLEAR EVENT" CssClass="button" runat="server" 
                onclick="CLEAR_EVENT_Click" />
        <asp:Literal ID="TITLE" runat="server">UPLOAD EVENT</asp:Literal>
        </HeaderTemplate>
        <ItemTemplate>
         <asp:Literal ID="Event_log" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"Event_log") %>'></asp:Literal>
        </ItemTemplate>
        </asp:TemplateField>
        </Columns>
        
        </asp:GridView>
        
        </td>
        </tr>
        
        <tr>
        <td colspan="2" align="center">
        <asp:GridView ID="MobileOrderSyncSearchGV" runat="server" DataKeyNames="Index" DataSourceID="MobileOrderSyncSearchObj"
         CssClass="table-report"  EmptyDataText="Have no record."
        AutoGenerateColumns="false"  >
        <Columns>
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
        
        <asp:TemplateField Visible="true">
        <HeaderTemplate>
        <asp:Button ID="OrderUpdateChk" runat="server" 
                OnClientClick="return confirm('Are you sure you want to update below order(s) to EDF?');" 
                Text="Update Order" CssClass="button" onclick="OrderUpdateChk_Click"  />
        </HeaderTemplate>
        <ItemTemplate>
        <asp:CheckBox ID="assign_chk" runat="server"  />
        </ItemTemplate>
        </asp:TemplateField>

        
        <asp:TemplateField Visible="true" HeaderText="RECORD ID">
        <ItemTemplate>
        <asp:Literal ID="Record_id" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"Record_id") %>'></asp:Literal>
        </ItemTemplate>
        <EditItemTemplate>
        <asp:TextBox ID="Record_id" runat="server" Text='<%# Bind(Container.DataItem,"Record_id") %>'></asp:TextBox>
        </EditItemTemplate>
        <InsertItemTemplate>
        <asp:TextBox ID="Record_id" runat="server" Text='<%# Bind(Container.DataItem,"Record_id") %>'></asp:TextBox>
        </InsertItemTemplate>
        </asp:TemplateField>
        
        
        
        <asp:TemplateField Visible="true" HeaderText="RWL EDF NO.">
        <ItemTemplate>
        <asp:Literal ID="MobileOrderSyncSearch_edf_no" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"MobileOrderSyncSearch.edf_no") %>'></asp:Literal>
        </ItemTemplate>
        <EditItemTemplate>
        <asp:TextBox ID="MobileOrderSyncSearch_edf_no" runat="server" Text='<%# Bind(Container.DataItem,"MobileOrderSyncSearch_edf_no") %>'></asp:TextBox>
        </EditItemTemplate>
        <InsertItemTemplate>
        <asp:TextBox ID="MobileOrderSyncSearch_edf_no" runat="server" Text='<%# Bind(Container.DataItem,"MobileOrderSyncSearch_edf_no") %>'></asp:TextBox>
        </InsertItemTemplate>
        </asp:TemplateField>
        
        <asp:TemplateField Visible="true" HeaderText="RWL HS ITEM CODE.">
        <ItemTemplate>
        <asp:Literal ID="MobileOrderSyncSearch_sku" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"MobileOrderSyncSearch.sku") %>'></asp:Literal>
        </ItemTemplate>
        <EditItemTemplate>
        <asp:TextBox ID="MobileOrderSyncSearch_sku" runat="server" Text='<%# Bind(Container.DataItem,"MobileOrderSyncSearch_sku") %>'></asp:TextBox>
        </EditItemTemplate>
        <InsertItemTemplate>
        <asp:TextBox ID="MobileOrderSyncSearch_sku" runat="server" Text='<%# Bind(Container.DataItem,"MobileOrderSyncSearch_sku") %>'></asp:TextBox>
        </InsertItemTemplate>
        </asp:TemplateField>
        
        <asp:TemplateField Visible="true" HeaderText="RWL IMEI NO.">
        <ItemTemplate>
        <asp:Literal ID="MobileOrderSyncSearch_imei_no" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"MobileOrderSyncSearch.imei_no") %>'></asp:Literal>
        </ItemTemplate>
        <EditItemTemplate>
        <asp:TextBox ID="MobileOrderSyncSearch_imei_no" runat="server" Text='<%# Bind(Container.DataItem,"MobileOrderSyncSearch_imei_no") %>'></asp:TextBox>
        </EditItemTemplate>
        <InsertItemTemplate>
        <asp:TextBox ID="MobileOrderSyncSearch_imei_no" runat="server" Text='<%# Bind(Container.DataItem,"MobileOrderSyncSearch_imei_no") %>'></asp:TextBox>
        </InsertItemTemplate>
        </asp:TemplateField>
        
        <asp:TemplateField Visible="true" HeaderText="RWL SIM ITEM NAME">
        <ItemTemplate>
        <asp:Literal ID="MobileOrderSyncSearch_sim_item_name" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"MobileOrderSyncSearch.sim_item_name") %>'></asp:Literal>
        </ItemTemplate>
        <EditItemTemplate>
        <asp:TextBox ID="MobileOrderSyncSearch_sim_item_name" runat="server" Text='<%# Bind(Container.DataItem,"MobileOrderSyncSearch_sim_item_name") %>'></asp:TextBox>
        </EditItemTemplate>
        <InsertItemTemplate>
        <asp:TextBox ID="MobileOrderSyncSearch_sim_item_name" runat="server" Text='<%# Bind(Container.DataItem,"MobileOrderSyncSearch_sim_item_name") %>'></asp:TextBox>
        </InsertItemTemplate>
        </asp:TemplateField>
        
        <asp:TemplateField Visible="true" HeaderText="RWL SIM ITEM CODE">
        <ItemTemplate>
        <asp:Literal ID="MobileOrderSyncSearch_sim_item_code" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"MobileOrderSyncSearch.sim_item_code") %>'></asp:Literal>
        </ItemTemplate>
        <EditItemTemplate>
        <asp:TextBox ID="MobileOrderSyncSearch_sim_item_code" runat="server" Text='<%# Bind(Container.DataItem,"MobileOrderSyncSearch_sim_item_code") %>'></asp:TextBox>
        </EditItemTemplate>
        <InsertItemTemplate>
        <asp:TextBox ID="MobileOrderSyncSearch_sim_item_code" runat="server" Text='<%# Bind(Container.DataItem,"MobileOrderSyncSearch_sim_item_code") %>'></asp:TextBox>
        </InsertItemTemplate>
        </asp:TemplateField>
        
        <asp:TemplateField Visible="true" HeaderText="EDF SIM ITEM CODE">
        <ItemTemplate>
        <asp:Literal ID="Edf_sim_item_code" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"Edf_sim_item_code") %>'></asp:Literal>
        </ItemTemplate>
        <EditItemTemplate>
        <asp:TextBox ID="Edf_sim_item_code" runat="server" Text='<%# Bind(Container.DataItem,"Edf_sim_item_code") %>'></asp:TextBox>
        </EditItemTemplate>
        <InsertItemTemplate>
        <asp:TextBox ID="Edf_sim_item_code" runat="server" Text='<%# Bind(Container.DataItem,"Edf_sim_item_code") %>'></asp:TextBox>
        </InsertItemTemplate>
        </asp:TemplateField>
        
        <asp:TemplateField Visible="true" HeaderText="EXPECT DELIVERY DATE">
        <ItemTemplate>
        <asp:Literal ID="MobileOrderSyncSearch_d_date" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"MobileOrderSyncSearch.d_date","{0:dd/MM/yyyy}") %>'></asp:Literal>
        </ItemTemplate>
        <EditItemTemplate>
        <asp:TextBox ID="MobileOrderSyncSearch_d_date" runat="server" Text='<%# Bind(Container.DataItem,"MobileOrderSyncSearch_d_date","{0:dd/MM/yyyy}") %>'></asp:TextBox>
        </EditItemTemplate>
        <InsertItemTemplate>
        <asp:TextBox ID="MobileOrderSyncSearch_d_date" runat="server" Text='<%# Bind(Container.DataItem,"MobileOrderSyncSearch_d_date","{0:dd/MM/yyyy}" ) %>'></asp:TextBox>
        </InsertItemTemplate>
        
        </asp:TemplateField>
        </Columns>
        </asp:GridView>
        <br />

        <asp:ObjectDataSource ID="MobileOrderSyncSearchObj" runat="server" 
         DataObjectTypeName="PCCW.RWL.CORE.MobileOrderSyncSearchView" TypeName="PCCW.RWL.CORE.MobileOrderSyncSearchViewDAO"
         DeleteMethod="DeleteMobileOrderSyncSearchView" InsertMethod="InsertMobileOrderSyncSearchView" 
         SelectMethod="FindALL" UpdateMethod="UpdateMobileOrderSyncSearchView" 
                OldValuesParameterFormatString="original_{0}" 
                onselecting="MobileOrderSyncSearchObj_Selecting" >
         </asp:ObjectDataSource>


        
        </td>
        </tr>
        
     
      
     </table>
      <cc1:CalendarExtender runat="server" 
        ID="deliveryDateCalendarExtender"
        TargetControlID="d_date"
        Format="dd/MM/yyyy"
        PopupButtonID="fromDeliveryDateImageButton" />
        
        <cc1:CalendarExtender runat="server" 
        ID="deliveryDateCalendarExtender2"
        TargetControlID="d_date2"
        Format="dd/MM/yyyy"
        PopupButtonID="toDeliveryDateImageButton" /> 
    </div>
    </form>
    
<table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="../MobileRetentionMain.aspx">Main Page</a> &raquo; View 
<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
</table>
    
</body>
</html>
