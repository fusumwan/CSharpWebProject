<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MobileManualAssignedHistoryControl.ascx.cs" Inherits="UI_MobileManualAssignedHistoryControl" %>
<asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional" >
<ContentTemplate>

<Dna:AspxGridView ID="MobileManualAssignedHistoryGW"  
               DataKeyNames="id" AllowSorting="true"  
               PageSize="25" AllowPaging="true"
               DataSourceID="MobileManualAssignedHistoryObj" runat="server"
               EmptyDataText="Have no history record."
               AutoGenerateColumns="False" 
        oninit="MobileManualAssignedHistoryGW_Init" >
              <PagerSettings Position="TopAndBottom" />
              <AspxFilterSetting AllowFilter="True" />
           <Columns>
              <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" Visible="false" />
               <Dna:AspxCheckBoxField DataField="StrNullToEmpty" HeaderText="StrNullToEmpty" 
                   SortExpression="StrNullToEmpty" Visible="false" />
                   <Dna:AspxTemplateField HeaderText="Record id" TypeCode="Int32">
                   <ItemTemplate>
                   <%# Func.IDAdd100000((int)Eval("order_id"))%>
                   </ItemTemplate>
                   </Dna:AspxTemplateField>
               <asp:BoundField DataField="order_id" HeaderText="Order ID" SortExpression="order_id" Visible="false" />
               <asp:BoundField DataField="imei_no" HeaderText="IMEI NUMBER" SortExpression="imei_no" />
               <asp:BoundField DataField="sku" HeaderText="Item Code" SortExpression="sku" />
               <asp:BoundField DataField="cid" HeaderText="Created BY" SortExpression="cid" />
               <Dna:AspxTemplateField FilterDataField = "cdate" HeaderText="Create Date" SortExpression="cdate" TypeCode="DateTime" FilterDataFormatString="dd/MM/yyyy">
               <ItemTemplate>
               <asp:Label ID="cdate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "cdate","{0:dd/MM/yyyy}")%>'></asp:Label>
               </ItemTemplate>
               </Dna:AspxTemplateField>
               
           </Columns>
       
       </Dna:AspxGridView>
       </ContentTemplate>
                  </asp:UpdatePanel>

   
    <asp:SqlDataSource ID="MobileManualAssignedHistoryObj" runat="server" 
        ConnectionString="<%$ ConnectionStrings:MobileRetentionOrderDB2 %>" 
        DeleteCommand="DELETE FROM [MobileManualAssignedHistory] WHERE [id] = @id" 
        InsertCommand="INSERT INTO [MobileManualAssignedHistory] ([order_id], [imei_no], [sku], [cid], [cdate]) VALUES (@order_id, @imei_no, @sku, @cid, @cdate)" 
        SelectCommand="SELECT [id], [order_id], [imei_no], [sku], [cid], [cdate] FROM [MobileManualAssignedHistory]" 
        
    UpdateCommand="UPDATE [MobileManualAssignedHistory] SET [order_id] = @order_id, [imei_no] = @imei_no, [sku] = @sku, [cid] = @cid, [cdate] = @cdate WHERE [id] = @id" 
    oninit="MobileManualAssignedHistoryObj_Init">
        <DeleteParameters>
            <asp:Parameter Name="id" Type="Int32" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="order_id" Type="Int32" />
            <asp:Parameter Name="imei_no" Type="String" />
            <asp:Parameter Name="sku" Type="String" />
            <asp:Parameter Name="cid" Type="String" />
            <asp:Parameter Name="cdate" Type="DateTime" />
            <asp:Parameter Name="id" Type="Int32" />
        </UpdateParameters>
        <InsertParameters>
            <asp:Parameter Name="order_id" Type="Int32" />
            <asp:Parameter Name="imei_no" Type="String" />
            <asp:Parameter Name="sku" Type="String" />
            <asp:Parameter Name="cid" Type="String" />
            <asp:Parameter Name="cdate" Type="DateTime" />
        </InsertParameters>
    </asp:SqlDataSource>
    <br />
        
        
                   