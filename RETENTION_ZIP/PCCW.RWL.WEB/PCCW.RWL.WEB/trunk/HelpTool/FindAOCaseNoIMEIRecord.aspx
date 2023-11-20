<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FindAOCaseNoIMEIRecord.aspx.cs" Inherits="HelpTools_FindAOCaseNoIMEIRecord" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="orderid" runat="server"></asp:TextBox>
        <asp:Button ID="AddAOToEdf" runat="server" Text="Button" 
            onclick="AddAOToEdf_Click" />
        <asp:CheckBox ID="AllCheck" runat="server" />
        <br />
        <br />
    </div>
    </form>
</body>
</html>
