<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MasterDetailCallListUploadMrtNo.ascx.cs" Inherits="UI_MasterDetailCallListUploadMrtNo" %>
<Dna:AspxGridView  ID="CallListUploadMrtNoGv" runat="server" AllowPaging="True"
    AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="id" EmptyDataText="Cannot find record!"
    DataSourceID="CallListUploadMrtNoObj" 
    onrowdeleting="CallListUploadMrtNoGv_RowDeleting" AllowExpanding="False">
    <PagerSettings Position="TopAndBottom" />
        <AspxFilterSetting AllowFilter="True" />
                <Columns>
                <asp:TemplateField>
                <ItemTemplate>
                
                <table id="EditCommandTable" cellpadding="0" border="0" style="height:100%; width:100%; background-color:White">
                <tr>
                <td nowrap="nowrap">
                <Dna:AspxButton  ID="DeleteBut" CommandName="DELETE" Text="Delete" runat="server" CommandArgument='<%# ((GridViewRow)Container).RowIndex %>' OnClientClick="return confirm('Are you sure you want to Delete?')" />
                </td>
                </tr>
                </table>
                </ItemTemplate>
                </asp:TemplateField>
    
    

        <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
            ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="mrt_no" HeaderText="mrt_no" 
            SortExpression="mrt_no" />
        <asp:BoundField DataField="call_list_program_id" HeaderText="call_list_program_id" 
            SortExpression="call_list_program_id" />
        <Dna:AspxTemplateField FilterDataField="cdate" SortExpression="cdate" HeaderText="Create Date"
            TypeCode="DateTime" FilterDataFormatString="dd/MM/yyyy" LIKE="false">
            <ItemTemplate>
                <asp:Literal ID="cdate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "cdate","{0:dd/MM/yyyy}")%>'></asp:Literal>
                </ItemTemplate>
                </Dna:AspxTemplateField>
    </Columns>
</Dna:AspxGridView >
<asp:SqlDataSource ID="CallListUploadMrtNoObj" runat="server" 
    ConnectionString="<%$ ConnectionStrings:MobileRetentionOrderDB2 %>" 
    
    SelectCommand="SELECT [id], [call_list_program_id], [mrt_no],[cdate] FROM [CallListUploadMrtNo] WHERE ([call_list_program_id] = @call_list_program_id)" 
    oninit="CallListUploadMrtNoObj_Init" 
    DeleteCommand="DELETE FROM [CallListUploadMrtNo] WHERE [id] = @id" 
    InsertCommand="INSERT INTO [CallListUploadMrtNo] ([call_list_program_id], [mrt_no], [cdate]) VALUES (@call_list_program_id, @mrt_no, @cdate)" 
    UpdateCommand="UPDATE [CallListUploadMrtNo] SET [call_list_program_id] = @call_list_program_id, [mrt_no] = @mrt_no, [cdate] = @cdate WHERE [id] = @id">
   
       <SelectParameters>
        <asp:Parameter Name="call_list_program_id" Type="Int64"/>
    </SelectParameters>
    <DeleteParameters>
        <asp:Parameter Name="id" Type="Int64" />
    </DeleteParameters>
    <UpdateParameters>
        <asp:Parameter Name="call_list_program_id" Type="Int64" />
        <asp:Parameter Name="mrt_no" Type="String" />
        <asp:Parameter Name="cdate" Type="DateTime" />
        <asp:Parameter Name="id" Type="Int64" />
    </UpdateParameters>
    <InsertParameters>
        <asp:Parameter Name="call_list_program_id" Type="Int64" />
        <asp:Parameter Name="mrt_no" Type="String" />
        <asp:Parameter Name="cdate" Type="DateTime" />
    </InsertParameters>
</asp:SqlDataSource>
