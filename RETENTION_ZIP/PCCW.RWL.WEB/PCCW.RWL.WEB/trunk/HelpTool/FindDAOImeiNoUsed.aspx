<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FindDAOImeiNoUsed.aspx.cs" Inherits="HelpTools_FindDAOImeiNoUsed" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="imei_no" runat="server" Width="298px"></asp:TextBox>
        <asp:CheckBox ID="used" runat="server" Checked="true" />
        <br />
        <asp:DropDownList ID="status" runat="server" AppendDataBoundItems=true>
            <asp:ListItem>NORMAL</asp:ListItem>
            <asp:ListItem>AO</asp:ListItem>
            <asp:ListItem>AWAIT</asp:ListItem>
            <asp:ListItem>STOCK</asp:ListItem>
            <asp:ListItem>CANCEL</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="btn_doa_imei" runat="server" Text="Button" 
            onclick="btn_doa_imei_Click" />
    </div>
    </form>
</body>
</html>
