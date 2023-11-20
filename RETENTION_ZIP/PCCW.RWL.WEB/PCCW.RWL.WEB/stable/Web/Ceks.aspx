<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Ceks.aspx.cs" Inherits="Web_Ceks" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>

    <script src="../Resources/Scripts/creditcard.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="ccard_no" runat="server" Text="" OnBlur="if(!validateToken(document.getElementById('ccard_no').value))alert('Invalid token!');" />
        <input type="hidden" id="ActiveCreditId" name="ActiveCreditId" value="" />
        <input type="button" onclick="document.getElementById('ActiveCreditId').value='ccard_no';window.open('http://136.139.31.226/cekswebservice-uat/StartCeksSession.ashx?V0=2&V1=GWTS&V2=<%=Session["uid"]%>')"
            value="Get Token"/>
    </div>
    </form>
</body>
</html>
