<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChangeStaffNoCurrentAccessRight.aspx.cs" Inherits="Web_ChangeStaffNoCurrentAccessRight" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="Back" PostBackUrl="~/Web/MobileRetentionMain.aspx" />
    
    <br />
        Staff Number:
        <asp:Label ID="StaffNo" runat="server"></asp:Label>
        <br />
        <asp:Button runat="server" Text="Change LV" onclick="Unnamed1_Click"  />
        <asp:DropDownList ID="ChangeLv" runat="server" AppendDataBoundItems="true">
        <asp:ListItem Value="1">FL</asp:ListItem>
        <asp:ListItem Value="10">UM</asp:ListItem>
        <asp:ListItem Value="2">SM LEVEL</asp:ListItem>
        <asp:ListItem Value="3">HELP</asp:ListItem>
        <asp:ListItem Value="6">PY LEVEL</asp:ListItem>
        <asp:ListItem Value="65535">SU</asp:ListItem>
        <asp:ListItem Value="7">FS LEVEL</asp:ListItem>
        </asp:DropDownList>
        <br />
    </div>
    </form>
    
    <table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td ><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; View 
<%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></td>
</tr>
</table>       
</body>
</html>
