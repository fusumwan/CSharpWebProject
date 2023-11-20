<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AssignMobileIMEI.aspx.cs" Inherits="AssignMobileIMEI" %>
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

<asp:Literal ID="NeuronJSLibrary" runat="server"></asp:Literal>
<body>
    <form id="form1" runat="server">
  <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
  <div>
  <asp:ScriptManager ID="AddWebLogScriptManager" runat="server"></asp:ScriptManager>
     <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
     <tr> 
        <th width="100%" height="28" colspan="30">&nbsp;<%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></th>
      </tr>
      <tr class="row2">
     <td><asp:Button ID="BackMain" runat="server" Text="BACK" CssClass="button" PostBackUrl="~/Web/MobileRetentionMain.aspx" Font-Size="10px" /></td>
     </tr>
     <tr class="row2">
     <td>RECORD_ID:<asp:TextBox ID="RecordID" runat="server"  ValidationGroup="AssignIMEI" ></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidatorRecordID" ValidationGroup="AssignIMEI" ControlToValidate="RecordID" runat="server" CssClass="explaintitle" ErrorMessage="Please enter record id"></asp:RequiredFieldValidator>
     
     </td>
     </tr>
         
      <tr>
       <td  class="row2">IMEI:
         <asp:TextBox ID="IMEI" runat="server"  ValidationGroup="AssignIMEI" ></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidatorIMEI"  ValidationGroup="AssignIMEI" ControlToValidate="IMEI" runat="server" CssClass="explaintitle" ErrorMessage="Please enter imei number"></asp:RequiredFieldValidator>
         </td>
      </tr>
         <tr>
     <td  class="row2">SKU:<asp:TextBox ID="SKU" runat="server"  ValidationGroup="AssignIMEI" ></asp:TextBox>
     <asp:RequiredFieldValidator ID="RequiredFieldValidatorSKU"  ValidationGroup="AssignIMEI" ControlToValidate="SKU" runat="server" CssClass="explaintitle" ErrorMessage="Please enter sku code"></asp:RequiredFieldValidator>
     </td>
     </tr>
       <tr>
       <td  class="row1"><asp:Button ID="AssignBut" runat="server" Text="Assign IMEI"  ValidationGroup="AssignIMEI"  CssClass="button"  Font-Size="10px"  
               onclick="AssignBut_Click" /></td>
       </tr>
       <tr>
       <td>
       <EW:GridViewEx ID="MobileManualAssignedHistoryGW"  DataKeyNames="id" CssClass="table-report"  PageSize="5" AllowPaging="true"
               DataSourceID="MobileManualAssignedHistoryObjSource" runat="server" EmptyDataText="Have no history record."
               AutoGenerateColumns="False">
           <Columns>
              <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" Visible="false" />
               <asp:CheckBoxField DataField="StrNullToEmpty" HeaderText="StrNullToEmpty" 
                   SortExpression="StrNullToEmpty" Visible="false" />
                   <asp:TemplateField HeaderText="Record id">
                   <ItemTemplate>
                   
                   <%# Func.IDAdd100000((int)Eval("order_id"))%>
                   </ItemTemplate>
                   </asp:TemplateField>
               <asp:BoundField DataField="order_id" HeaderText="Order ID" SortExpression="order_id" Visible=false />
               <asp:BoundField DataField="imei_no" HeaderText="IMEI NUMBER" SortExpression="imei_no" />
               <asp:BoundField DataField="sku" HeaderText="Item Code" SortExpression="sku" />
               <asp:BoundField DataField="cid" HeaderText="Created BY" SortExpression="cid" />
               <asp:BoundField DataField="cdate" HeaderText="Created Date" SortExpression="cdate" />
               
           </Columns>
       
       </EW:GridViewEx>
       <br />
       <asp:ObjectDataSource ID="MobileManualAssignedHistoryObjSource" runat="server" EnablePaging="True" SelectMethod="FindAll"
        TypeName="PCCW.RWL.CORE.MobileManualAssignedHistoryDalDAO" SelectCountMethod="CountAll" SortParameterName="x_sSortExpression"
        MaximumRowsParameterName="x_iPageSize"  StartRowIndexParameterName="x_iStartRow">
        </asp:ObjectDataSource>
       </td>
       </tr>
     </table>
    </div>
    </form>
</body>
</html>
