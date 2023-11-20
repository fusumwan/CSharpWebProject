<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MasterDetailDeliveryTime.ascx.cs" Inherits="UI_MasterDetailDeliveryTime" %>


              <Dna:AspxGridView ID="DeliveryTimeGv" runat="server" AllowPaging="True" PageSize="10"
               AllowExpanding="true"
               DataSourceID="DeliveryTimeObj"
                    DataKeyNames="id"  AllowSorting="True" EmptyDataText="There has no record" 
                    AutoGenerateColumns="False" EmptyShowHeader="true" UseSelectCommand="false" >
                    <AspxFilterSetting AllowFilter="true" />
                    <PagerSettings Position="TopAndBottom" />
                <Columns>
                 <asp:TemplateField>
                    <ItemTemplate>
                                    <Dna:AspxButton ID="EditBut" CommandName="Edit" Text="Edit" runat="server" />
                                    <Dna:AspxButton ID="DeleteBut" CommandName="Delete" Text="Delete" runat="server"
                                        OnClientClick="return confirm('Are you sure to delete this record?');" CommandArgument='<%# ((GridViewRow)Container).RowIndex %>' />

                    </ItemTemplate>
                    <EditItemTemplate>

                                    <Dna:AspxButton ID="UpdateBut" CommandName="Update" Text="Update" runat="server"
                                        OnClientClick="return confirm('Are you sure you want to Save?');" />
                                    <Dna:AspxButton ID="CancelBut" CommandName="Cancel" Text="Cancel" runat="server" />

                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="id" Visible="false"  InsertVisible="true" />
                <asp:BoundField DataField="location" Visible="false"  InsertVisible="true" />
                   
                <Dna:AspxTemplateField FilterDataField="period" SortExpression="period" HeaderText="Period"
                                                    TypeCode="String" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
                                                    SMALLER_AND_EQUAL_TO="false">
                                                    <ItemTemplate>

                                                        <asp:Literal ID="period" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "period")%>'></asp:Literal>
                                                    
            
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <Dna:AspxDropDownList ID="period" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="4" 
                                                            CheckAndInsertBoundValue="true" UnBoundSelectedText='<%# DataBinder.Eval(Container.DataItem,"period") %>' UnBoundSelectedValue='<%# DataBinder.Eval(Container.DataItem,"period") %>'  SelectedValue='<%# Bind(Container.DataItem, "period")%>'>
                                                        <asp:ListItem Text="10-13" Value="10-13"></asp:ListItem>
                                                        <asp:ListItem Text="11-13" Value="11-13"></asp:ListItem>
                                                        <asp:ListItem Text="14-16" Value="14-16"></asp:ListItem>
                                                        <asp:ListItem Text="16-18" Value="16-18"></asp:ListItem>
                                                        <asp:ListItem Text="14-18" Value="14-18"></asp:ListItem>
                                                        <asp:ListItem Text="16-20" Value="16-20"></asp:ListItem>
                                                        <asp:ListItem Text="18-20" Value="18-20"></asp:ListItem>
                                                        <asp:ListItem Text="20-22" Value="20-22"></asp:ListItem>
                                                        </Dna:AspxDropDownList>
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

                


<asp:SqlDataSource ID="DeliveryTimeObj" runat="server" 
    ConnectionString="<%$ ConnectionStrings:MobileRetentionOrderDB2 %>" 
    DeleteCommand="DELETE FROM [DeliveryTime] WHERE [id] = @id" 
    InsertCommand="INSERT INTO [DeliveryTime] ([location], [period], [active]) VALUES (@location, @period, @active)" 
    SelectCommand="SELECT [id], [location], [period], [active] FROM [DeliveryTime] WHERE location=@location " 
    
    UpdateCommand="UPDATE [DeliveryTime] SET [period] = @period, [active] = @active WHERE [id] = @id" 
    oninit="DeliveryTimeObj_Init">
    <SelectParameters>
    <asp:Parameter Name="location" Type="String"/>
    </SelectParameters>
    <DeleteParameters>
        <asp:Parameter Name="id" Type="Int32" />
    </DeleteParameters>
    <UpdateParameters>
        <asp:Parameter Name="period" Type="String" />
        <asp:Parameter Name="active" Type="Boolean" />
        <asp:Parameter Name="id" Type="Int32" />
    </UpdateParameters>
    <InsertParameters>
        <asp:Parameter Name="location" Type="String" />
        <asp:Parameter Name="period" Type="String" />
        <asp:Parameter Name="active" Type="Boolean" />
    </InsertParameters>
</asp:SqlDataSource>
