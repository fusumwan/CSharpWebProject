<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/RWLMenu.master" AutoEventWireup="true" CodeFile="BankCodeMapping.aspx.cs" Inherits="Web_BankCodeMapping" %>
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
              <Dna:AspxButton ID="BackBut" Text="Back" PostBackUrl="~/Web/MobileRetentionMain.aspx" runat="server" />
              </td>
              <td>&nbsp;</td>

              </tr>
              </table>
              <br />




                  <Dna:AspxGridView ID="BankCodeGV" runat="server" AllowPaging="True" PageSize="15"
                      AllowSorting="True" DataKeyNames="mid" EmptyDataText="Cannot Find Record"
    DataSourceID="BankCodeObj" AutoGenerateColumns="False" UseSelectCommand="true"
                      EmptyShowHeader="true" oninit="BankCodeGV_Init"  >
                      <PagerSettings Position="TopAndBottom" />
                       
                  <AspxFilterSetting AllowFilter="True" />
                      <Columns>
                <asp:TemplateField>
                <ItemTemplate>
                
                <table id="EditCommandTable" cellpadding="0" border="0" style="height:100%; width:100%; background-color:White">
                <tr>
                <td nowrap="nowrap">
                <Dna:AspxButton  ID="EditBut" CommandName="Edit" Text="Edit" runat="server" />
                <Dna:AspxButton ID="DeleteBut" CommandName="Delete" Text="Delete" runat="server" OnClientClick="return confirm('Are you sure to delete this record?');" CommandArgument='<%# ((GridViewRow)Container).RowIndex %>' />
                </td>
                </tr>
                </table>
                </ItemTemplate>
                <EditItemTemplate>
                <table id="EditCommandTable" cellpadding="0" border="0" style="height:100%; width:100%; background-color:White">
                <tr>
                <td nowrap="nowrap">
                <Dna:AspxButton ID="UpdateBut" CommandName="Update" Text="Update" runat="server" OnClientClick="return confirm('Are you sure you want to Save?');" />
                <Dna:AspxButton ID="CancelBut" CommandName="Cancel" Text="Cancel" runat="server" />
                </td>
                </tr>
                </table>
                </EditItemTemplate>
                </asp:TemplateField>
                
                
                 <asp:BoundField DataField="mid" HeaderText="ID" InsertVisible="False"
                    ReadOnly="True" SortExpression="mid" />
                
                
                <Dna:AspxTemplateField FilterDataField="bank_name" SortExpression="bank_name" HeaderText="Bank Name" TypeCode="String">
                <ItemTemplate>
                <asp:Literal ID="bank_name" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "bank_name")%>' 
                 ></asp:Literal>
                </ItemTemplate>
                <EditItemTemplate>
                <Dna:AspxTextBox ID="bank_name" runat="server"  Text='<%# Bind(Container.DataItem, "bank_name")%>' InnerHintMessage="Please kindly Enter Bank Name" HintMessage="Please kindly Enter Bank Name"
                MaxLength="60" Font-Size="12px" Width="200px"></Dna:AspxTextBox>
                </EditItemTemplate>
                </Dna:AspxTemplateField>
                
                <Dna:AspxTemplateField FilterDataField="bank_code" SortExpression="bank_code" HeaderText="Bank Code" TypeCode="String">
                <ItemTemplate>
                <asp:Literal ID="bank_code" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "bank_code")%>' 
                 ></asp:Literal>
                </ItemTemplate>
                <EditItemTemplate>
                <Dna:AspxTextBox ID="bank_code" runat="server"  Text='<%# Bind(Container.DataItem, "bank_code")%>' InnerHintMessage="Please kindly Enter Bank Code" HintMessage="Please kindly Enter Bank Code"
                MaxLength="60" Font-Size="12px" Width="200px"></Dna:AspxTextBox>
                </EditItemTemplate>
                </Dna:AspxTemplateField>
                
                
                <Dna:AspxTemplateField FilterDataField="installment_period" SortExpression="installment_period" HeaderText="Installment Period" TypeCode="String">
                <ItemTemplate>
                <asp:Literal ID="installment_period" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "installment_period")%>' 
                 ></asp:Literal>
                </ItemTemplate>
                <EditItemTemplate>
                <Dna:AspxTextBox ID="installment_period" runat="server"  Text='<%# Bind(Container.DataItem, "installment_period")%>'  HintMessage="Please kindly Enter Installment Period"
                MaxLength="60" Font-Size="12px" Width="100px"></Dna:AspxTextBox>
                </EditItemTemplate>
                </Dna:AspxTemplateField>
                
                <Dna:AspxTemplateField FilterDataField="min_amount" SortExpression="min_amount" HeaderText="Min Amount" TypeCode="String">
                <ItemTemplate>
                <asp:Literal ID="min_amount" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "min_amount")%>' 
                 ></asp:Literal>
                </ItemTemplate>
                <EditItemTemplate>
                <Dna:AspxTextBox ID="min_amount" runat="server"  Text='<%# Bind(Container.DataItem, "min_amount")%>'  HintMessage="Please kindly Enter Min Amount"
                MaxLength="10" Font-Size="12px" Width="100px"></Dna:AspxTextBox>
                </EditItemTemplate>
                </Dna:AspxTemplateField>
                
                <Dna:AspxTemplateField FilterDataField="active" SortExpression="active" HeaderText="Active" TypeCode="Boolean"
                GREATER_THAN="false"
                GREATER_AND_EQUAL_TO="false"
                SMALLER_THAN="false"
                SMALLER_AND_EQUAL_TO="false"
                LIKE="false"
                >
                <ItemTemplate>
        
                <Dna:AspxCheckBox ID="active" Enabled="false" Checked='<%# DataBinder.Eval(Container.DataItem, "active")%>' runat="server" />
                </ItemTemplate>
                <EditItemTemplate>
                <Dna:AspxCheckBox ID="active"  Checked='<%# Bind(Container.DataItem, "active")%>' runat="server" />
                </EditItemTemplate>
                </Dna:AspxTemplateField>
                
                
                </Columns>
                </Dna:AspxGridView>




                  <asp:SqlDataSource ID="BankCodeObj" runat="server" 
                      ConnectionString="<%$ ConnectionStrings:MobileRetentionOrderDB2 %>" 
                      DeleteCommand="DELETE FROM [BankCode] WHERE [mid] = @mid" 
                      InsertCommand="INSERT INTO [BankCode] ([bank_name], [bank_code], [installment_period], [min_amount], [active]) VALUES (@bank_name, @bank_code, @installment_period, @min_amount, @active)" 
                      SelectCommand="SELECT [mid], [bank_name], [bank_code], [installment_period], [min_amount], [active] FROM [BankCode]" 
                      
                      UpdateCommand="UPDATE [BankCode] SET [bank_name] = @bank_name, [bank_code] = @bank_code, [installment_period] = @installment_period, [min_amount] = @min_amount, [active] = @active WHERE [mid] = @mid" 
                      oninit="BankCodeObj_Init">
            <DeleteParameters>
                <asp:Parameter Name="mid" Type="Int32" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="bank_name" Type="String" />
                <asp:Parameter Name="bank_code" Type="String" />
                <asp:Parameter Name="installment_period" Type="String" />
                <asp:Parameter Name="min_amount" Type="String" />
                <asp:Parameter Name="active" Type="Boolean" />
                <asp:Parameter Name="mid" Type="Int32" />
            </UpdateParameters>
            <InsertParameters>
                <asp:Parameter Name="bank_name" Type="String" />
                <asp:Parameter Name="bank_code" Type="String" />
                <asp:Parameter Name="installment_period" Type="String" />
                <asp:Parameter Name="min_amount" Type="String" />
                <asp:Parameter Name="active" Type="Boolean" />
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

