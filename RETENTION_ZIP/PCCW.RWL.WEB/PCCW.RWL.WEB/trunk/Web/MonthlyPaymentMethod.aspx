<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/RWLMenu.master" AutoEventWireup="true" CodeFile="MonthlyPaymentMethod.aspx.cs" Inherits="Web_MonthlyPaymentMethod" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="RWLHeaderContentPlace" Runat="Server">

    <meta http-equiv="Content-Style-Type" content="text/css" />
    <meta http-equiv="Content-Type" content="text/html; charset=big5" />
    <title>3G Retention - Web Log</title>
    <link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
    <link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
    <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="RWLContentPlace" Runat="Server">
<cc1:ToolkitScriptManager ID="AddWebLogScriptManager"  runat="server" EnablePartialRendering="true" ScriptMode="Release" LoadScriptsBeforeUI="false" EnablePageMethods="true"></cc1:ToolkitScriptManager>
<table width="100%" cellspacing="10" >
<tr>
<td>
<table width="100%" class="bodyline" border="0"   cellspacing="0" cellpadding="10">
<tr>
<td>
              <table width="100%" cellspacing="2" cellpadding="3" border="0">
                <tr> 
                  <td colspan="2" class="maintitle">
                      <span class="explaintitle" style="font-size:8pt">
                            <%=global::PCCW.RWL.CORE.Configurator.GetTitle() %>
                      </span>
                  </td>
                </tr>
                <tr>
                  <td class="nav">Main Page &raquo; &nbsp;</td>
                <td align="right" class="nav"> 
                  <a href="MessageViewAction.aspx" runat="server" id="MessageViewAction">
                    <img src="images/pc_25_01.gif" height="20" /></a>
                </td>
                </tr>
              </table>
              
              
              
              <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
              <tr> 
              <td>


              <table cellpadding="0" cellspacing="0" border="0" style="margin:0 0 0 0; padding:0 0 0 0">
              <tr>
              <td>
              <Dna:AspxButton ID="BackBut" Text="Back" PostBackUrl="~/Web/BasicBackEndManagement.aspx" runat="server" />
              </td>
              <td>&nbsp;</td>

              </tr>
              </table>
              <br />
              
                    <Dna:AspxGridView ID="MonthlyPaymentMethodMappingGV" runat="server" AllowPaging="True"
                      AllowSorting="True" DataKeyNames="id" EmptyDataText="Cannot Find Record"
                      DataSourceID="MonthlyPaymentMethodMappingObj" AutoGenerateColumns="False"
                      EmptyShowHeader="true" AllowExpanding="False"   >
                      <PagerSettings Position="TopAndBottom" /> 
                      <AspxFilterSetting AllowFilter="True" />
                      <Columns>
                      <asp:TemplateField>
                            <ItemTemplate>
                                <table id="EditCommandTable" cellpadding="0" border="0" style="height: 100%; width: 100%;
                                    background-color: White">
                                    <tr>
                                        <td nowrap="nowrap" align="left">
                                            <Dna:AspxButton ID="EditBut" CommandName="Edit" Text="Edit" runat="server" />
                                            <Dna:AspxButton ID="DeleteBut" CommandName="Delete" Text="Delete" runat="server"
                                                OnClientClick="return confirm('Are you sure to delete this record?');" CommandArgument='<%# ((GridViewRow)Container).RowIndex %>' />
                                        </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <table id="EditCommandTable" cellpadding="0" border="0" style="height: 100%; width: 100%;
                                    background-color: White">
                                    <tr>
                                        <td nowrap="nowrap" align="left">
                                            <Dna:AspxButton ID="UpdateBut" CommandName="Update" Text="Update" runat="server"
                                                OnClientClick="return confirm('Are you sure you want to Save?');" />
                                            <Dna:AspxButton ID="CancelBut" CommandName="Cancel" Text="Cancel" runat="server" />
                                        </td>
                                    </tr>
                                </table>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        
                        <Dna:AspxTemplateField FilterDataField="id" SortExpression="id" HeaderText="id"
                            Visible="false" TypeCode="String" LIKE="false">
                            <ItemTemplate>
                                <asp:Literal ID="id" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "id")%>'></asp:Literal>
                            </ItemTemplate>
                            <EditItemTemplate>
                            </EditItemTemplate>
                        </Dna:AspxTemplateField>
                        
                        <Dna:AspxTemplateField FilterDataField="issue_type" SortExpression="issue_type" HeaderText="Issue Type"
                            TypeCode="String" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
                            SMALLER_AND_EQUAL_TO="false">
                            <ItemTemplate>
                            <table id="issue_type_tabl" border="0" cellpadding="0" cellspacing="0" width="100%">
                                    <tr>
                                        <td nowrap="nowrap" align="left">
                            
                                <asp:Literal ID="issue_type" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "issue_type")%>'></asp:Literal>
                                        </td>
                                    </tr>
                            </table>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <Dna:AspxDropDownList ID="issue_type" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="4" 
                                    Width="200px"  CheckAndInsertBoundValue="true" UnBoundSelectedText='<%# DataBinder.Eval(Container.DataItem,"issue_type") %>' UnBoundSelectedValue='<%# DataBinder.Eval(Container.DataItem,"issue_type") %>' SelectedValue='<%# Bind(Container.DataItem, "issue_type")%>'>
                                    <asp:ListItem Text="3G_RETENTION" Value="3G_RETENTION"></asp:ListItem>
                                    <asp:ListItem Text="2G_RETENTION" Value="2G_RETENTION"></asp:ListItem>
                                    <asp:ListItem Text="GO_WIRELESS" Value="GO_WIRELESS"></asp:ListItem>
                                    <asp:ListItem Text="MOBILE_LITE" Value="MOBILE_LITE"></asp:ListItem>
                                    <asp:ListItem Text="UPGRADE" Value="UPGRADE"></asp:ListItem>
                                    <asp:ListItem Text="WIN" Value="WIN"></asp:ListItem>
                                </Dna:AspxDropDownList>
                            </EditItemTemplate>
                        </Dna:AspxTemplateField>
                        
                        <Dna:AspxTemplateField FilterDataField="program" SortExpression="program" HeaderText="Program"
                            TypeCode="String" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
                            SMALLER_AND_EQUAL_TO="false">
                            <ItemTemplate>
                                <table id="program_tabl" border="0" cellpadding="0" cellspacing="0" width="100%">
                                    <tr>
                                        <td nowrap="nowrap" align="left">
                                            <asp:Literal ID="program" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "program")%>'></asp:Literal>
                                        </td>
                                    </tr>
                                </table>
                                
                            </ItemTemplate>
                            <EditItemTemplate>
                                <Dna:AspxDropDownList ID="program" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="10" 
                                    Width="500px" DataTextField="program" DataValueField="program" DataSource='<%# ProgramDataBind() %>'
                                    CheckAndInsertBoundValue="true" UnBoundSelectedText='<%# DataBinder.Eval(Container.DataItem,"program") %>' UnBoundSelectedValue='<%# DataBinder.Eval(Container.DataItem,"program") %>'  SelectedValue='<%# Bind(Container.DataItem, "program")%>'   >
                                </Dna:AspxDropDownList>


                            </EditItemTemplate>
                        </Dna:AspxTemplateField>
                        
                        
                        <Dna:AspxTemplateField FilterDataField="payment_type" SortExpression="payment_type" HeaderText="Payment Type"
                            TypeCode="String" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
                            SMALLER_AND_EQUAL_TO="false">
                            <ItemTemplate>
                                <table id="payment_type_tabl" border="0" cellpadding="0" cellspacing="0" width="100%">
                                    <tr>
                                        <td nowrap="nowrap" align="left">
                                            <asp:Literal ID="payment_type" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "payment_type")%>'></asp:Literal>
                                        </td>
                                    </tr>
                                </table>
                                
                            </ItemTemplate>
                            <EditItemTemplate>
                                <Dna:AspxDropDownList ID="payment_type" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="2" 
                                    Width="200px" CheckAndInsertBoundValue="true" 
                                    UnBoundSelectedText='<%# DataBinder.Eval(Container.DataItem,"payment_type") %>' UnBoundSelectedValue='<%# DataBinder.Eval(Container.DataItem,"payment_type") %>'  SelectedValue='<%# Bind(Container.DataItem, "payment_type")%>'   >
                                <asp:ListItem Text="MONTHLY PAYMENT" Value="MONTHLY PAYMENT"></asp:ListItem>
                                <asp:ListItem Text="PREPAYMENT" Value="PREPAYMENT"></asp:ListItem>
                                </Dna:AspxDropDownList>
                            </EditItemTemplate>
                        </Dna:AspxTemplateField>
                        
                        <Dna:AspxTemplateField FilterDataField="credit_card_group" SortExpression="credit_card_group" HeaderText="Credit Card Group"
                            TypeCode="Boolean" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
                            SMALLER_AND_EQUAL_TO="false" LIKE="false">
                            <ItemTemplate>
                                <Dna:AspxCheckBox ID="credit_card_group" Enabled="false" Checked='<%# DataBinder.Eval(Container.DataItem, "credit_card_group")%>'
                                    runat="server" />
                            </ItemTemplate>
                            <EditItemTemplate>
                                <Dna:AspxCheckBox ID="credit_card_group" Checked='<%# Bind(Container.DataItem, "credit_card_group")%>'
                                    runat="server" />
                            </EditItemTemplate>
                        </Dna:AspxTemplateField>

                        
                         <Dna:AspxTemplateField FilterDataField="third_party_credit_card" SortExpression="credit_card_group" HeaderText="3rd Party Credit Card"
                            TypeCode="Boolean" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
                            SMALLER_AND_EQUAL_TO="false" LIKE="false">
                            <ItemTemplate>
                                <Dna:AspxCheckBox ID="third_party_credit_card" Enabled="false" Checked='<%# DataBinder.Eval(Container.DataItem, "third_party_credit_card")%>'
                                    runat="server" />
                            </ItemTemplate>
                            <EditItemTemplate>
                                <Dna:AspxCheckBox ID="third_party_credit_card" Checked='<%# Bind(Container.DataItem, "third_party_credit_card")%>'
                                    runat="server" />
                            </EditItemTemplate>
                        </Dna:AspxTemplateField>
                        
                        <Dna:AspxTemplateField FilterDataField="cash_group" SortExpression="cash_group" HeaderText="Cash Group"
                            TypeCode="Boolean" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
                            SMALLER_AND_EQUAL_TO="false" LIKE="false">
                            <ItemTemplate>
                                <Dna:AspxCheckBox ID="cash_group" Enabled="false" Checked='<%# DataBinder.Eval(Container.DataItem, "cash_group")%>'
                                    runat="server" />
                            </ItemTemplate>
                            <EditItemTemplate>
                                <Dna:AspxCheckBox ID="cash_group" Checked='<%# Bind(Container.DataItem, "cash_group")%>'
                                    runat="server" />
                            </EditItemTemplate>
                        </Dna:AspxTemplateField>
                        
                        <Dna:AspxTemplateField FilterDataField="bank_account_group" SortExpression="bank_account_group" HeaderText="Bank Account Group"
                            TypeCode="Boolean" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
                            SMALLER_AND_EQUAL_TO="false" LIKE="false">
                            <ItemTemplate>
                                <Dna:AspxCheckBox ID="bank_account_group" Enabled="false" 
                                Checked='<%# DataBinder.Eval(Container.DataItem, "bank_account_group")%>' runat="server" />
                            </ItemTemplate>
                            <EditItemTemplate>
                                <Dna:AspxCheckBox ID="bank_account_group" 
                                Checked='<%# Bind(Container.DataItem, "bank_account_group")%>' runat="server" />
                            </EditItemTemplate>
                        </Dna:AspxTemplateField>
                        
                        
                        <Dna:AspxTemplateField FilterDataField="active" SortExpression="active" HeaderText="Active"
                            TypeCode="Boolean" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
                            SMALLER_AND_EQUAL_TO="false" LIKE="false">
                            <ItemTemplate>
                                <Dna:AspxCheckBox ID="active" Enabled="false" Checked='<%# DataBinder.Eval(Container.DataItem, "active")%>'
                                    runat="server" />
                            </ItemTemplate>
                            <EditItemTemplate>
                                <Dna:AspxCheckBox ID="active" Checked='<%# Bind(Container.DataItem, "active")%>'
                                    runat="server" />
                            </EditItemTemplate>
                        </Dna:AspxTemplateField>
                        
                      </Columns>
                      </Dna:AspxGridView>


                  <asp:SqlDataSource ID="MonthlyPaymentMethodMappingObj" runat="server" 
                      ConnectionString="<%$ ConnectionStrings:MobileRetentionOrderDB2 %>" 
                      DeleteCommand="DELETE FROM [MonthlyPaymentMethodMapping] WHERE [id] = @id" 
                      InsertCommand="INSERT INTO [MonthlyPaymentMethodMapping] ([issue_type], [program], [payment_type], [credit_card_group], [active], [bank_account_group], [cash_group], [third_party_credit_card]) VALUES (@issue_type, @program, @payment_type, @credit_card_group, @active, @bank_account_group, @cash_group, @third_party_credit_card)" 
                      oninit="MonthlyPaymentMethodMappingObj_Init" 
                      SelectCommand="SELECT [id], [issue_type], [program], [payment_type], [credit_card_group], [active], [bank_account_group], [cash_group], [third_party_credit_card] FROM [MonthlyPaymentMethodMapping]" 
                      UpdateCommand="UPDATE [MonthlyPaymentMethodMapping] SET [issue_type] = @issue_type, [program] = @program, [payment_type] = @payment_type, [credit_card_group] = @credit_card_group, [active] = @active, [bank_account_group] = @bank_account_group, [cash_group] = @cash_group, [third_party_credit_card] = @third_party_credit_card WHERE [id] = @id">
                      <DeleteParameters>
                          <asp:Parameter Name="id" Type="Int32" />
                      </DeleteParameters>
                      <UpdateParameters>
                          <asp:Parameter Name="issue_type" Type="String" />
                          <asp:Parameter Name="program" Type="String" />
                          <asp:Parameter Name="payment_type" Type="String" />
                          <asp:Parameter Name="credit_card_group" Type="Boolean" />
                          <asp:Parameter Name="active" Type="Boolean" />
                          <asp:Parameter Name="bank_account_group" Type="Boolean" />
                          <asp:Parameter Name="cash_group" Type="Boolean" />
                          <asp:Parameter Name="third_party_credit_card" Type="Boolean" />
                          <asp:Parameter Name="id" Type="Int32" />
                      </UpdateParameters>
                      <InsertParameters>
                          <asp:Parameter Name="issue_type" Type="String" />
                          <asp:Parameter Name="program" Type="String" />
                          <asp:Parameter Name="payment_type" Type="String" />
                          <asp:Parameter Name="credit_card_group" Type="Boolean" />
                          <asp:Parameter Name="active" Type="Boolean" />
                          <asp:Parameter Name="bank_account_group" Type="Boolean" />
                          <asp:Parameter Name="cash_group" Type="Boolean" />
                          <asp:Parameter Name="third_party_credit_card" Type="Boolean" />
                      </InsertParameters>
                  </asp:SqlDataSource>



        </td>
        </tr>
        </table>
    
        </td>
        </tr>
        <tr> 
                <td class="cat" colspan="3"><span class="explaintitle">&nbsp; </span></td>
              </tr>
        </table>
        </td>
        </tr>
        
        </table>


</asp:Content>

