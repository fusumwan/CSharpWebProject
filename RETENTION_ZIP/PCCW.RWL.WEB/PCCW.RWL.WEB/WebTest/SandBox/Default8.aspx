<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default8.aspx.cs" Inherits="SandBox_Default8" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AutoGenerateColumns="False" DataKeyNames="mid" DataSourceID="SqlDataSource1" 
            ondatabinding="GridView1_DataBinding" ondatabound="GridView1_DataBound" 
            onpageindexchanged="GridView1_PageIndexChanged" 
            onpageindexchanging="GridView1_PageIndexChanging" 
            onrowcancelingedit="GridView1_RowCancelingEdit" 
            onrowcommand="GridView1_RowCommand" onrowcreated="GridView1_RowCreated" 
            onrowdatabound="GridView1_RowDataBound" onrowdeleted="GridView1_RowDeleted" 
            onrowdeleting="GridView1_RowDeleting" onrowediting="GridView1_RowEditing" 
            onrowupdated="GridView1_RowUpdated" onrowupdating="GridView1_RowUpdating" 
            onselectedindexchanged="GridView1_SelectedIndexChanged" 
            onselectedindexchanging="GridView1_SelectedIndexChanging">
            <Columns>
                <asp:BoundField DataField="mid" HeaderText="mid" InsertVisible="False" 
                    ReadOnly="True" SortExpression="mid" />
                <asp:BoundField DataField="accessory_desc" HeaderText="accessory_desc" 
                    SortExpression="accessory_desc" />
                <asp:BoundField DataField="accessory_code" HeaderText="accessory_code" 
                    SortExpression="accessory_code" />
                <asp:BoundField DataField="accessory_price" HeaderText="accessory_price" 
                    SortExpression="accessory_price" />
                <asp:CheckBoxField DataField="active" HeaderText="active" 
                    SortExpression="active" />
                <asp:BoundField DataField="edate" HeaderText="edate" SortExpression="edate" />
                <asp:BoundField DataField="sdate" HeaderText="sdate" SortExpression="sdate" />
                <asp:CheckBoxField DataField="last_stock" HeaderText="last_stock" 
                    SortExpression="last_stock" />
                <asp:BoundField DataField="quota" HeaderText="quota" SortExpression="quota" />
            </Columns>
        </asp:GridView>
        <br />
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:MobileRetentionOrderDB_UATConnectionString %>" 
            DeleteCommand="DELETE FROM [Accessory] WHERE [mid] = @mid" 
            InsertCommand="INSERT INTO [Accessory] ([accessory_desc], [accessory_code], [accessory_price], [active], [edate], [sdate], [last_stock], [quota]) VALUES (@accessory_desc, @accessory_code, @accessory_price, @active, @edate, @sdate, @last_stock, @quota)" 
            SelectCommand="SELECT [mid], [accessory_desc], [accessory_code], [accessory_price], [active], [edate], [sdate], [last_stock], [quota] FROM [Accessory]" 
            UpdateCommand="UPDATE [Accessory] SET [accessory_desc] = @accessory_desc, [accessory_code] = @accessory_code, [accessory_price] = @accessory_price, [active] = @active, [edate] = @edate, [sdate] = @sdate, [last_stock] = @last_stock, [quota] = @quota WHERE [mid] = @mid">
            <DeleteParameters>
                <asp:Parameter Name="mid" Type="Int32" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="accessory_desc" Type="String" />
                <asp:Parameter Name="accessory_code" Type="String" />
                <asp:Parameter Name="accessory_price" Type="String" />
                <asp:Parameter Name="active" Type="Boolean" />
                <asp:Parameter Name="edate" Type="DateTime" />
                <asp:Parameter Name="sdate" Type="DateTime" />
                <asp:Parameter Name="last_stock" Type="Boolean" />
                <asp:Parameter Name="quota" Type="String" />
                <asp:Parameter Name="mid" Type="Int32" />
            </UpdateParameters>
            <InsertParameters>
                <asp:Parameter Name="accessory_desc" Type="String" />
                <asp:Parameter Name="accessory_code" Type="String" />
                <asp:Parameter Name="accessory_price" Type="String" />
                <asp:Parameter Name="active" Type="Boolean" />
                <asp:Parameter Name="edate" Type="DateTime" />
                <asp:Parameter Name="sdate" Type="DateTime" />
                <asp:Parameter Name="last_stock" Type="Boolean" />
                <asp:Parameter Name="quota" Type="String" />
            </InsertParameters>
        </asp:SqlDataSource>
        <br />
    
    </div>
    </form>
</body>
</html>
