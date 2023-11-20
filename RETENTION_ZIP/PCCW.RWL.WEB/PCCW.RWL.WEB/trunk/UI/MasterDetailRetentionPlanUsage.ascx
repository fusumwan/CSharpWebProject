<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MasterDetailRetentionPlanUsage.ascx.cs" Inherits="UI_MasterDetailRetentionPlanUsage" %>
<asp:UpdatePanel ID="Up1" RenderMode="Inline" UpdateMode="Conditional" runat="server">
<ContentTemplate>
<table style=" background-color:White">
<tr>
<td>
<Dna:AspxGridView  ID="RetentionPlanUsageGv" runat="server" AllowPaging="True" PageSize="5"
    AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="id" EmptyDataText="Cannot find record!"
    DataSourceID="RetentionPlanUsageObj" AllowExpanding="False">
    <PagerSettings Position="TopAndBottom" />
        <AspxFilterSetting AllowFilter="True" />
                <Columns>
                
                <asp:TemplateField>
                <ItemTemplate>
                <table id="EditCommandTable" cellpadding="0" border="0" style="height:100%; width:100%; background-color:White">
                <tr>
                <td nowrap="nowrap">
                
                <Dna:AspxButton  ID="EditBut" CommandName="Edit" Text="Edit" runat="server" CommandArgument='<%# ((GridViewRow)Container).RowIndex %>' />
                
                <Dna:AspxButton  ID="DeleteBut" CommandName="DELETE" Text="Delete" runat="server" CommandArgument='<%# ((GridViewRow)Container).RowIndex %>' OnClientClick="return confirm('Are you sure you want to Delete?')" />
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
                  <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                
                
                
                <Dna:AspxTemplateField FilterDataField="rate_plan" SortExpression="rate_plan" HeaderText="Rate Plan"
                TypeCode="String" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
                SMALLER_AND_EQUAL_TO="false">
                <ItemTemplate>
                <table id="rate_plan_tabl" border="0" cellpadding="0" cellspacing="0">
                        <tr>
                            <td nowrap="nowrap">
                    <asp:Literal ID="rate_plan" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "rate_plan")%>'></asp:Literal>
                
                            </td>
                            </tr>
                            </table>
                </ItemTemplate>
                <EditItemTemplate>
                    <Dna:AspxDropDownList ID="rate_plan" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="10" 
                        Width="300" DataTextField="rate_plan" DataValueField="rate_plan" DataSource='<%# RatePlanDataBind() %>'
                        CheckAndInsertBoundValue="true" UnBoundSelectedText='<%# DataBinder.Eval(Container.DataItem,"rate_plan") %>' UnBoundSelectedValue='<%# DataBinder.Eval(Container.DataItem,"rate_plan") %>'  SelectedValue='<%# Bind(Container.DataItem, "rate_plan")%>'>
                    </Dna:AspxDropDownList>
                </EditItemTemplate>
            </Dna:AspxTemplateField>
                
                
                <Dna:AspxTemplateField FilterDataField="rate_plan_vas" HeaderText="Rate Plan Vas" SortExpression="rate_plan_vas_"  TypeCode="String"
                GREATER_THAN="false"
                GREATER_AND_EQUAL_TO="false"
                SMALLER_THAN="false"
                SMALLER_AND_EQUAL_TO="false">
                <ItemTemplate>
                <table id="rate_plan_vas_tbl" cellpadding="0" cellspacing="0" border="0" style=" border:none; margin:0 0 0 0; padding:0 0 0 0; width:100%">
                <tr>
                <td nowrap="nowrap" align="left">
                <asp:Literal ID="rate_plan_vas" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "rate_plan_vas")%>' ></asp:Literal>
                </td>
                </tr>
                </table>
                
                </ItemTemplate>
                <EditItemTemplate>
                <table id="rate_plan_vas_tbl" cellpadding="0" cellspacing="0" border="0" style=" border:none; margin:0 0 0 0; padding:0 0 0 0; width:100%">
                <tr>
                <td nowrap="nowrap" align="left">
                <Dna:AspxDropDownList ID="rate_plan_vas" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="10" 
                        Width="300" DataTextField="rate_plan_vas" DataValueField="rate_plan_vas" DataSource='<%# RatePlanVasDataBind() %>'
                        CheckAndInsertBoundValue="true" UnBoundSelectedText='<%# DataBinder.Eval(Container.DataItem,"rate_plan_vas") %>' 
                        UnBoundSelectedValue='<%# DataBinder.Eval(Container.DataItem,"rate_plan_vas") %>'  
                        SelectedValue='<%# Bind(Container.DataItem, "rate_plan_vas")%>'>
                    </Dna:AspxDropDownList>
                

                </td>
                </tr>
                </table>
                
                </EditItemTemplate>
                </Dna:AspxTemplateField>
                
                
                
                
                
                <Dna:AspxTemplateField FilterDataField="rate_plan_vas_value" HeaderText="Rate Plan Vas Value" SortExpression="rate_plan_vas_value"  TypeCode="String"
                GREATER_THAN="false"
                GREATER_AND_EQUAL_TO="false"
                SMALLER_THAN="false"
                SMALLER_AND_EQUAL_TO="false"
                >
                <ItemTemplate>
                
                <table id="rate_plan_vas_value_tbl" cellpadding="0" cellspacing="0" border="0" style=" border:none; margin:0 0 0 0; padding:0 0 0 0; width:100%">
                <tr>
                <td nowrap="nowrap" align="left">
                <asp:Literal ID="rate_plan_vas_value" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "rate_plan_vas_value")%>' ></asp:Literal>
                </td>
                </tr>
                </table>
                
                
                </ItemTemplate>
                <EditItemTemplate>
                <table id="rate_plan_vas_value_tbl" cellpadding="0" cellspacing="0" border="0" style=" border:none; margin:0 0 0 0; padding:0 0 0 0; width:100%">
                <tr>
                <td nowrap="nowrap" align="left">
                <Dna:AspxTextBox ID="rate_plan_vas_value" runat="server" Text='<%# Bind(Container.DataItem, "rate_plan_vas_value")%>' InnerHintMessage="Please kindly Enter Rate Plan Vas Value" HintMessage="Please kindly Enter Rate Plan Vas Value"
                MaxLength="200" Font-Size="12px" Width="600px" ></Dna:AspxTextBox>
                </td>
                </tr>
                </table>
                
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
                
</td>
</tr>
</table>
</ContentTemplate>
</asp:UpdatePanel>
                
<asp:SqlDataSource ID="RetentionPlanUsageObj" runat="server" 
    ConnectionString="<%$ ConnectionStrings:MobileRetentionOrderDB2 %>" 
    DeleteCommand="DELETE FROM [RetentionPlanUsage] WHERE [id] = @id" 
    InsertCommand="INSERT INTO [RetentionPlanUsage] ([rate_plan], [rate_plan_vas], [rate_plan_vas_value], [active]) VALUES (@rate_plan, @rate_plan_vas, @rate_plan_vas_value, @active)" 
    SelectCommand="SELECT id, rate_plan, rate_plan_vas, rate_plan_vas_value, active FROM dbo.RetentionPlanUsage WHERE (rate_plan = @rate_plan)" 
    
    UpdateCommand="UPDATE [RetentionPlanUsage] SET [rate_plan] = @rate_plan, [rate_plan_vas] = @rate_plan_vas, [rate_plan_vas_value] = @rate_plan_vas_value, [active] = @active WHERE [id] = @id" 
    oninit="RetentionPlanUsageObj_Init">
    
    
    <SelectParameters>
        <asp:Parameter Name="rate_plan" Type="String" />
    </SelectParameters>
    
    
    <DeleteParameters>
        <asp:Parameter Name="id" Type="Int32" />
    </DeleteParameters>
    <UpdateParameters>
        <asp:Parameter Name="rate_plan" Type="String" />
        <asp:Parameter Name="rate_plan_vas" Type="String" />
        <asp:Parameter Name="rate_plan_vas_value" Type="String" />
        <asp:Parameter Name="active" Type="Boolean" />
        <asp:Parameter Name="id" Type="Int32" />
    </UpdateParameters>
    <InsertParameters>
        <asp:Parameter Name="rate_plan" Type="String" />
        <asp:Parameter Name="rate_plan_vas" Type="String" />
        <asp:Parameter Name="rate_plan_vas_value" Type="String" />
        <asp:Parameter Name="active" Type="Boolean" />
    </InsertParameters>
</asp:SqlDataSource>
