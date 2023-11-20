<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AORecordAssignDOAIMEI.aspx.cs" Inherits="HelpTools_AORecordAssignDOAIMEI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
   
     IMEI :
        <asp:TextBox ID="imei" runat="server" Width="211px"></asp:TextBox>
        <br />
        <asp:Button ID="Submit" runat="server" Text="Submit" onclick="Submit_Click" />
    </div>
    </form>
</body>
</html>
