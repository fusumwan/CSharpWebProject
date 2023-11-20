<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BankCodMapping.aspx.cs" Inherits="Web_BankCodMapping" %>

<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit.HTMLEditor" tagprefix="cc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<head id="Head1" runat="server">
<title>3G Retention - Web Log</title>       
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>

<link rel="stylesheet"  href="../Resources/Styles/global.css" type="text/css" />
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />

</head>
<body>
    <form id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div id="page-content"><asp:ScriptManager ID="AddWebLogScriptManager" runat="server"></asp:ScriptManager>
<table width="100%" border="0" cellpadding="3" cellspacing="1" >
<tr>
<td colspan="2" class="maintitle"><span  style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
  <tr> 
    <td height="40" colspan="26" > <input name="submit22" type="button" class="button" value="BACK" onClick="history.go(-1);"/> 
    </td>
  </tr>
  <tr>
  <td>
  
      <asp:FormView ID="BankCodeFormView" runat="server" 
          DataSourceID="BankCodeObjSouce"   CssClass="form-order" 
          DataKeyNames="BankCode_active,BankCode_bank_name,BankCode_installment_period,BankCode_bank_code,BankCode_min_amount" 
          DefaultMode="Insert" oniteminserted="BankCodeFormView_ItemInserted" >
          <EditItemTemplate>

              BankCode_active:
              <asp:Label ID="BankCode_activeLabel1" runat="server" 
                  Text='<%# Eval("BankCode_active") %>' />
              <br />
              BankCode_bank_name:
              <asp:Label ID="BankCode_bank_nameLabel1" runat="server" 
                  Text='<%# Eval("BankCode_bank_name") %>' />
              <br />
              BankCode_installment_period:
              <asp:Label ID="BankCode_installment_periodLabel1" runat="server" 
                  Text='<%# Eval("BankCode_installment_period") %>' />
              <br />
              BankCode_bank_code:
              <asp:Label ID="BankCode_bank_codeLabel1" runat="server" 
                  Text='<%# Eval("BankCode_bank_code") %>' />
              <br />
              BankCode_min_amount:
              <asp:Label ID="BankCode_min_amountLabel1" runat="server" 
                  Text='<%# Eval("BankCode_min_amount") %>' />
              <br />
              <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" 
                  CommandName="Update" Text="Update" />
              &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" 
                  CausesValidation="False" CommandName="Cancel" Text="Cancel" />
          </EditItemTemplate>
          <InsertItemTemplate>

              BankCode_active:
              <asp:TextBox ID="BankCode_activeTextBox" runat="server" 
                  Text='<%# Bind("BankCode_active") %>' />
              <br />

              BankCode_bank_name:
              <asp:TextBox ID="BankCode_bank_nameTextBox" runat="server" 
                  Text='<%# Bind("BankCode_bank_name") %>' />
              <br />
              BankCode_installment_period:
              <asp:TextBox ID="BankCode_installment_periodTextBox" runat="server" 
                  Text='<%# Bind("BankCode_installment_period") %>' />
              <br />
              BankCode_bank_code:
              <asp:TextBox ID="BankCode_bank_codeTextBox" runat="server" 
                  Text='<%# Bind("BankCode_bank_code") %>' />
              <br />
              BankCode_min_amount:
              <asp:TextBox ID="BankCode_min_amountTextBox" runat="server" 
                  Text='<%# Bind("BankCode_min_amount") %>' />
              <br />
              <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" 
                  CommandName="Insert" Text="Insert" />
              &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" 
                  CausesValidation="False" CommandName="Cancel" Text="Cancel" />
          </InsertItemTemplate>
          <ItemTemplate>

              BankCode_active:
              <asp:Label ID="BankCode_activeLabel" runat="server" 
                  Text='<%# Eval("BankCode_active") %>' />
              <br />

              BankCode_bank_name:
              <asp:Label ID="BankCode_bank_nameLabel" runat="server" 
                  Text='<%# Eval("BankCode_bank_name") %>' />
              <br />
              BankCode_installment_period:
              <asp:Label ID="BankCode_installment_periodLabel" runat="server" 
                  Text='<%# Eval("BankCode_installment_period") %>' />
              <br />
              BankCode_bank_code:
              <asp:Label ID="BankCode_bank_codeLabel" runat="server" 
                  Text='<%# Eval("BankCode_bank_code") %>' />
              <br />
              BankCode_min_amount:
              <asp:Label ID="BankCode_min_amountLabel" runat="server" 
                  Text='<%# Eval("BankCode_min_amount") %>' />
              <br />
              <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" 
                  CommandName="Edit" Text="Edit" />
              &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" 
                  CommandName="Delete" Text="Delete" />
              &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" 
                  CommandName="New" Text="New" />
          </ItemTemplate>
      </asp:FormView>
  
  </td>
  </tr>
  
    
  <tr> 
  <td>
  
<asp:GridView ID="BankCodeGW" runat="server" DataKeyNames="Index" DataSourceID="BankCodeObjSouce" CssClass="table-report"  PageSize="5"
AutoGenerateColumns="false"  >
<Columns>
<asp:TemplateField>
<ItemTemplate>
<asp:Button ID="But_Edit" Text="Edit" CommandName="Edit" CssClass=button  runat="server" />
</ItemTemplate>
<EditItemTemplate>
<asp:Button ID="But_Update"  Text="Update" CommandName="Update" CssClass=button  runat="server" />
<asp:Button ID="But_Cancel"  Text="Cancel" CommandName="Cancel" CssClass=button  runat="server" />
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
<asp:Literal ID="BankCode_mid" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"BankCode.mid") %>'></asp:Literal>
</ItemTemplate>
<EditItemTemplate>
<asp:TextBox ID="BankCode_mid" runat="server" Text='<%# Bind(Container.DataItem,"BankCode_mid") %>'></asp:TextBox>
</EditItemTemplate>
<InsertItemTemplate>
<asp:TextBox ID="BankCode_mid" runat="server" Text='<%# Bind(Container.DataItem,"BankCode_mid") %>'></asp:TextBox>
</InsertItemTemplate>
</asp:TemplateField>
<asp:TemplateField Visible="true">
<ItemTemplate>
<asp:Literal ID="BankCode_active" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"BankCode.active") %>'></asp:Literal>
</ItemTemplate>
<EditItemTemplate>
<asp:TextBox ID="BankCode_active" runat="server" Text='<%# Bind(Container.DataItem,"BankCode_active") %>'></asp:TextBox>
</EditItemTemplate>
<InsertItemTemplate>
<asp:TextBox ID="BankCode_active" runat="server" Text='<%# Bind(Container.DataItem,"BankCode_active") %>'></asp:TextBox>
</InsertItemTemplate>
</asp:TemplateField>

<asp:TemplateField Visible="true">
<ItemTemplate>
<asp:Literal ID="BankCode_bank_name" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"BankCode.bank_name") %>'></asp:Literal>
</ItemTemplate>
<EditItemTemplate>
<asp:TextBox ID="BankCode_bank_name" runat="server" Text='<%# Bind(Container.DataItem,"BankCode_bank_name") %>'></asp:TextBox>
</EditItemTemplate>
<InsertItemTemplate>
<asp:TextBox ID="BankCode_bank_name" runat="server" Text='<%# Bind(Container.DataItem,"BankCode_bank_name") %>'></asp:TextBox>
</InsertItemTemplate>
</asp:TemplateField>
<asp:TemplateField Visible="true">
<ItemTemplate>
<asp:Literal ID="BankCode_installment_period" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"BankCode.installment_period") %>'></asp:Literal>
</ItemTemplate>
<EditItemTemplate>
<asp:TextBox ID="BankCode_installment_period" runat="server" Text='<%# Bind(Container.DataItem,"BankCode_installment_period") %>'></asp:TextBox>
</EditItemTemplate>
<InsertItemTemplate>
<asp:TextBox ID="BankCode_installment_period" runat="server" Text='<%# Bind(Container.DataItem,"BankCode_installment_period") %>'></asp:TextBox>
</InsertItemTemplate>
</asp:TemplateField>
<asp:TemplateField Visible="true">
<ItemTemplate>
<asp:Literal ID="BankCode_bank_code" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"BankCode.bank_code") %>'></asp:Literal>
</ItemTemplate>
<EditItemTemplate>
<asp:TextBox ID="BankCode_bank_code" runat="server" Text='<%# Bind(Container.DataItem,"BankCode_bank_code") %>'></asp:TextBox>
</EditItemTemplate>
<InsertItemTemplate>
<asp:TextBox ID="BankCode_bank_code" runat="server" Text='<%# Bind(Container.DataItem,"BankCode_bank_code") %>'></asp:TextBox>
</InsertItemTemplate>
</asp:TemplateField>
<asp:TemplateField Visible="true">
<ItemTemplate>
<asp:Literal ID="BankCode_min_amount" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"BankCode.min_amount") %>'></asp:Literal>
</ItemTemplate>
<EditItemTemplate>
<asp:TextBox ID="BankCode_min_amount" runat="server" Text='<%# Bind(Container.DataItem,"BankCode_min_amount") %>'></asp:TextBox>
</EditItemTemplate>
<InsertItemTemplate>
<asp:TextBox ID="BankCode_min_amount" runat="server" Text='<%# Bind(Container.DataItem,"BankCode_min_amount") %>'></asp:TextBox>
</InsertItemTemplate>
</asp:TemplateField>
</Columns>
</asp:GridView>




  </td>
</tr>
</table>
    
    <asp:ObjectDataSource ID="BankCodeObjSouce" runat="server" 
 DataObjectTypeName="PCCW.RWL.CORE.BankCodeView" TypeName="PCCW.RWL.CORE.BankCodeViewDAO"
 DeleteMethod="DeleteBankCodeView" InsertMethod="InsertBankCodeView"
 SelectMethod="FindALL" UpdateMethod="UpdateBankCodeView" OldValuesParameterFormatString="original_{0}" >
 </asp:ObjectDataSource>
    <table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="MobileRetentionMain.aspx">Main Page Page</a> &raquo; View 
<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
</table>           
    
    </div>
    </form>
</body>
</html>
