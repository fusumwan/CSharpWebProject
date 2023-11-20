<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CreateAO_AWAITRecord.aspx.cs" Inherits="HelpTools_CreateAO_AWAITRecord" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        RECORD ID:
    
    <asp:TextBox ID="order_id"  runat="server"></asp:TextBox>
        <asp:Button ID="CreateAOBut" runat="server" Text="Create AO" 
            onclick="CreateAOBut_Click" />
            <asp:Button ID="CreateAWAITBut" runat="server" Text="Create AWAIT" 
            onclick="CreateAWAITBut_Click" />
    </div>
    </form>
</body>
</html>
