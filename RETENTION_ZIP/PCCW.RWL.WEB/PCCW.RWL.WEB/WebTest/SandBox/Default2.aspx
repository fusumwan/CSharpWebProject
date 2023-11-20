<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="SandBox_Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language="javascript">



    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
   <asp:TextBox ID="Txt1" Text="" runat="server" ></asp:TextBox>
    
  <Dna:AspxDropDownList ID="AspxDropDownList1" runat="server"  
            HitMessage="Please Kindly Select" AutoPostBack="true" 
            onselectedindexchanged="AspxDropDownList1_SelectedIndexChanged">
        <asp:ListItem Text="Choose 0" Value="0"></asp:ListItem>
        <asp:ListItem Text="Choose 1" Value="1"></asp:ListItem>
        <asp:ListItem Text="Choose 2" Value="2"></asp:ListItem>
        <asp:ListItem Text="Choose 3" Value="3"></asp:ListItem>
        <asp:ListItem Text="Choose 4" Value="4"></asp:ListItem>
        </Dna:AspxDropDownList>
    </div>
    </form>
</body>
</html>
