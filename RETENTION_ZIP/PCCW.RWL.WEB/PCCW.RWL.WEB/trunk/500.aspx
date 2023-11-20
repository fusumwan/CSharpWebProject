<%@ Page Language="C#" AutoEventWireup="true" CodeFile="500.aspx.cs" Inherits="_500" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
  <title></title>

  <link href="~/Resources/Styles/global.css" type="text/css" media="screen" rel="stylesheet" />
  <style type="text/css">
    body
    {
      margin: 1em;
    }
    .logo 
    {
    	margin-left: -1em;
    	margin-top: -1em;
    }
  </style>
</head>
<body>
  <form id="form1" runat="server">
  <div>
    <asp:Image ID="Image1" runat="server" ImageUrl="~/Resources/Images/pccw.gif" CssClass="logo" />
    <h2>
      <asp:Literal ID="Heading" runat="server"></asp:Literal></h2>
    <p style="width: 400px">
      <asp:Literal ID="Description" runat="server"></asp:Literal>
    </p>
    <p>
       <a href="javascript:window.location.reload()">Retry</a> | <asp:LinkButton ID="GoBackLink" runat="server" text="Go Back"></asp:LinkButton>
       </p>
    <p style="color: #999999">
      <asp:Literal ID="UserInformation" runat="server"></asp:Literal><br />
    </p>
  </div>
  </form>
</body>
</html>