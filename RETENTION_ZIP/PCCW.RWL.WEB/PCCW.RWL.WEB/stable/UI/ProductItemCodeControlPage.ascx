<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProductItemCodeControlPage.ascx.cs" Inherits="Web_ProductItemCodeControlPage" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>


<table id="Table1"  runat="server" cellpadding="3" cellspacing="3" >
      <tr>
      <td style="font-size:12px; font-family:Tahoma">
       Page Size :
      </td>
      <td nowrap="nowrap">
      <Dna:AspxTextBox ID="GvPageSize" Text="15" runat="server" Width="50px" HintMessage="Please kindly Enter The Page Size" ></Dna:AspxTextBox>
      </td>
      <td>
      <Dna:AspxButton ID="PageSizeRefresh"  Text="PageSize Refresh" runat="server" onclick="PageSizeRefresh_Click"  />
      </td>
      </tr>
       </table>


                  <Dna:AspxGridView ID="AspxProductItemCodeGV" runat="server" AllowPaging="True" PageSize="15"
                      AllowSorting="True" DataKeyNames="mid" EmptyDataText="Cannot Find Record"
    DataSourceID="ProductItemCodeObj" AutoGenerateColumns="False" UseSelectCommand="true"
                      EmptyShowHeader="true" 
    onrowupdating="AspxProductItemCodeGV_RowUpdating" oninit="AspxProductItemCodeGV_Init" 
                      onunload="AspxProductItemCodeGV_Unload" onrowcommand="AspxProductItemCodeGV_RowCommand" >
                      <PagerSettings Position="TopAndBottom" />
                      <Columns>
                <asp:TemplateField>
                <ItemTemplate>
                
                <table id="EditCommandTable" cellpadding="0" border="0" style="height:100%; width:100%; background-color:White">
                <tr>
                <td nowrap="nowrap">
                <Dna:AspxButton  ID="EditBut" CommandName="Edit" Text="Edit" runat="server" CommandArgument='<%# ((GridViewRow)Container).RowIndex %>' />
                <Dna:AspxButton  ID="DeleteBut" CommandName="Delete" Text="Delete" runat="server" CommandArgument='<%# ((GridViewRow)Container).RowIndex %>' />
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
                <Dna:AspxTemplateField FilterDataField="hs_model" HeaderText="Hand Set" SortExpression="hs_model"  TypeCode="String"
                GREATER_THAN="false"
                GREATER_AND_EQUAL_TO="false"
                SMALLER_THAN="false"
                SMALLER_AND_EQUAL_TO="false"
                >
                <ItemTemplate>
                
                <table id="hs_model_tbl" cellpadding="0" cellspacing="0" border="0" style=" border:none; margin:0 0 0 0; padding:0 0 0 0; width:100%">
                <tr>
                <td nowrap="nowrap" align="left">
                <asp:Literal ID="hs_model" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "hs_model")%>' ></asp:Literal>
                </td>
                </tr>
                </table>
                
                
                </ItemTemplate>
                <EditItemTemplate>
                <table id="hs_model_tbl" cellpadding="0" cellspacing="0" border="0" style=" border:none; margin:0 0 0 0; padding:0 0 0 0; width:100%">
                <tr>
                <td nowrap="nowrap" align="left">
                <Dna:AspxTextBox ID="hs_model" runat="server" Text='<%# Bind(Container.DataItem, "hs_model")%>' InnerHintMessage="Please kindly Enter Hsmodel" HintMessage="Please kindly Enter Hsmodel"
                MaxLength="100" Font-Size="12px" Width="500px" ></Dna:AspxTextBox>
                </td>
                </tr>
                </table>
                
                </EditItemTemplate>
                </Dna:AspxTemplateField>
                
                
                <Dna:AspxTemplateField FilterDataField="item_code" SortExpression="item_code" HeaderText="Sku" TypeCode="String">
                <ItemTemplate>
                
                <table id="item_code_tbl" cellpadding="0" cellspacing="0" border="0" style=" border:none; margin:0 0 0 0; padding:0 0 0 0; width:100%">
                <tr>
                <td nowrap="nowrap" align="left">
                <asp:Literal ID="item_code" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "item_code")%>' ></asp:Literal>
                </td>
                </tr>
                </table>
                
                </ItemTemplate>
                <EditItemTemplate>
                <Dna:AspxTextBox ID="item_code" runat="server"  Text='<%# Bind(Container.DataItem, "item_code")%>' InnerHintMessage="Please kindly Enter Sku" HintMessage="Please kindly Enter Sku"
                MaxLength="60" Font-Size="12px" Width="200px"></Dna:AspxTextBox>
                </EditItemTemplate>
                </Dna:AspxTemplateField>
                
                
                <Dna:AspxTemplateField FilterDataField="last_stock" SortExpression="last_stock" HeaderText="Last Stock" TypeCode="Boolean"
                GREATER_THAN="false"
                GREATER_AND_EQUAL_TO="false"
                SMALLER_THAN="false"
                SMALLER_AND_EQUAL_TO="false"
                LIKE="false"
                >
                <ItemTemplate>
        
                <Dna:AspxCheckBox ID="last_stock" Enabled="false" Checked='<%# DataBinder.Eval(Container.DataItem, "last_stock")%>' runat="server" />
                </ItemTemplate>
                <EditItemTemplate>
                <Dna:AspxCheckBox ID="last_stock"  Checked='<%# Bind(Container.DataItem, "last_stock")%>' runat="server" />
                </EditItemTemplate>
                </Dna:AspxTemplateField>

                
                
                
  
                <Dna:AspxTemplateField FilterDataField="type" SortExpression="type" HeaderText="type" TypeCode="String" 
                GREATER_THAN="false"
                GREATER_AND_EQUAL_TO="false"
                SMALLER_THAN="false"
                SMALLER_AND_EQUAL_TO="false"
                >
                <ItemTemplate>
                <table id="type_tbl" cellpadding="0" cellspacing="0" border="0" style=" border:none; margin:0 0 0 0; padding:0 0 0 0; width:100%">
                <tr>
                <td nowrap="nowrap" align="left">
                 <asp:Literal ID="type" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "type")%>' ></asp:Literal>
                </td>
                </tr>
                </table>
                
                </ItemTemplate>
                <EditItemTemplate>
                <Dna:AspxDropDownList ID="type" runat="server"  Font-Size="12px" Width="150" DataTextField="TYPE" DataValueField="TYPE" DataSource='<%# TypeDataBind() %>' SelectedValue='<%# Bind(Container.DataItem, "type")%>' >
                </Dna:AspxDropDownList>

                </EditItemTemplate>
                </Dna:AspxTemplateField>
                
                <Dna:AspxTemplateField FilterDataField="quota" SortExpression="quota" HeaderText="Quota" TypeCode="String">
                <ItemTemplate>
                <asp:Literal ID="quota" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "quota")%>' ></asp:Literal>
                </ItemTemplate>
                <EditItemTemplate>
                <Dna:AspxTextBox ID="quota" runat="server"  Text='<%# Bind(Container.DataItem, "quota")%>'  
                MaxLength="60" Font-Size="12px" Width="100px"></Dna:AspxTextBox>
                </EditItemTemplate>
                </Dna:AspxTemplateField>
                


                <Dna:AspxTemplateField FilterDataField="sdate" SortExpression="sdate" HeaderText="Start Date" TypeCode="DateTime" FilterDataFormatString="dd/MM/yyyy"
                LIKE="false"
                >
                <ItemTemplate>
                <table id="sdate_tbl" cellpadding="0" cellspacing="0" border="0" style=" border:none; margin:0 0 0 0; padding:0 0 0 0; width:100%">
                <tr>
                <td nowrap="nowrap" align="left">
                <asp:Literal ID="sdate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "sdate","{0:dd/MM/yyyy}")%>' ></asp:Literal>
                </td>
                </tr>
                </table>
                </ItemTemplate>
                <EditItemTemplate>
                <table id="SdateTbl" runat="server" cellpadding="0" cellspacing="0" class="SdateTbl">
                <tr>
                <td nowrap="nowrap">
<table cellpadding="0" cellspacing="0" border="0" >
<tr>
<td>
<Dna:AspxTextBox ID="sdate" Width="100px"  Text='<%# Bind(Container.DataItem, "sdate","{0:dd/MM/yyyy}")%>' runat="server"  HintMessage="Please kindly Enter The Start Date" />
</td>
<td>
<asp:ImageButton runat="server" ID="CalenderImageSDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>

                <cc1:CalendarExtender runat="server" 
                    ID="CalendarSDateFormat"
                    TargetControlID="sdate"
                    Format="dd/MM/yyyy"
                    PopupButtonID="CalenderImageSDate" ></cc1:CalendarExtender>
</td>
</tr>
</table>
                
                
                
                </td>
                </tr>
                </table>

                </EditItemTemplate>
                
                </Dna:AspxTemplateField>
                
            </Columns>
                      
                      <AspxFilterSetting AllowFilter="True" />
                  </Dna:AspxGridView>
                  

                  
                  <asp:SqlDataSource ID="ProductItemCodeObj" runat="server" 
                    ConnectionString=""
                      DeleteCommand="DELETE FROM [ProductItemCode] WHERE [mid] = @mid" 
                      InsertCommand="INSERT INTO [ProductItemCode] ([type], [hs_model], [item_code], [quota], [cdate], [cid],  [edate], [sdate], [last_stock], [did], [ddate]) VALUES (@type, @hs_model, @item_code, @quota, @cdate, @cid, @edate, @sdate, @last_stock, @did, @ddate)" 
                      SelectCommand="SELECT  [mid],'type' = case when type is null then '' else type end,[hs_model],[item_code],rtrim(ltrim(quota)) as 'QUOTA','last_stock'=isnull(last_stock,0),[sdate],[edate],[active],[cid],[cdate],[did],[ddate] FROM [ProductItemCode] WHERE active=1" 
                      
    UpdateCommand="UPDATE [ProductItemCode] SET [type] = @type, [hs_model] = @hs_model, [item_code] = @item_code, [quota] = @quota, [cdate] = @cdate, [cid] = @cid,  [edate] = @edate, [sdate] = @sdate, [last_stock] = @last_stock, [did] = @did, [ddate] = @ddate WHERE [mid] = @mid" 
    oninit="ProductItemCodeObj_Init">
                      <DeleteParameters>
                          <asp:Parameter Name="mid" Type="Int32" />
                      </DeleteParameters>
                      <UpdateParameters>
                          <asp:Parameter Name="type" Type="String" />
                          <asp:Parameter Name="hs_model" Type="String" />
                          <asp:Parameter Name="item_code" Type="String" />
                          <asp:Parameter Name="quota" Type="String" />
                          <asp:Parameter Name="cdate" Type="DateTime" />
                          <asp:Parameter Name="cid" Type="String" />
                          <asp:Parameter Name="edate" Type="DateTime" />
                          <asp:Parameter Name="sdate" Type="DateTime" />
                          <asp:Parameter Name="last_stock" Type="Boolean" />
                          <asp:Parameter Name="did" Type="String" />
                          <asp:Parameter Name="ddate" Type="DateTime" />
                          <asp:Parameter Name="mid" Type="Int32" />
                      </UpdateParameters>
                      <InsertParameters>
                          <asp:Parameter Name="type" Type="String" />
                          <asp:Parameter Name="hs_model" Type="String" />
                          <asp:Parameter Name="item_code" Type="String" />
                          <asp:Parameter Name="quota" Type="String" />
                          <asp:Parameter Name="cdate" Type="DateTime" />
                          <asp:Parameter Name="cid" Type="String" />
                          <asp:Parameter Name="edate" Type="DateTime" />
                          <asp:Parameter Name="sdate" Type="DateTime" />
                          <asp:Parameter Name="last_stock" Type="Boolean" />
                          <asp:Parameter Name="did" Type="String" />
                          <asp:Parameter Name="ddate" Type="DateTime" />
                      </InsertParameters>
                  </asp:SqlDataSource>
        
