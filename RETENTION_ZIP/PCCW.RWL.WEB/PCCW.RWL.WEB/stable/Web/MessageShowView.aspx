<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MessageShowView.aspx.cs" Inherits="Web_MessageShowView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet"  href="../Resources/Styles/global.css" type="text/css" />
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />


<asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>

</head>
<body style="background-color:#ffffff">
    <form id="form1" runat="server">
    <div>
    
    
<table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
  <tr> 
    <th height="28" colspan="4">NEWS</th>
  </tr>
  <tr> 
    <td width="23%" height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Sender</span></td>

    <td width="77%" height="0" class="row1"> <span class="gensmall" style="font-size:7pt">
    <asp:Literal ID="staff_name" runat="server"></asp:Literal></span> 
    </td>
  </tr>
  <tr> 
    <td width="23%" height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Create 
      Date (dd/mm/yyyy)</span></td>
    <td width="77%" height="0" class="row1"> <span class="gensmall" style="font-size:7pt">
    <asp:Literal ID="cdate" runat="server"></asp:Literal>
    </span> 
    </td>
  </tr>
  <tr> 
    <td width="23%" height="0" class="row2">
    <span class="explaintitle" style="font-size:7pt">Subject</span>
    </td>
    <td width="77%" height="0" class="row1">
    <span class="gensmall" style="font-size:9pt">
    <asp:Literal ID="subject" runat="server"></asp:Literal>
    </span>
    </td>
  </tr>
  <tr> 
    <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">Message</span></td>
    <td height="28" class="row1"> <span class="gensmall" style="font-size:9pt"> 
      <asp:Literal ID="message" runat="server"></asp:Literal>
      </span> </td>
  </tr>
  <tr> 
    <td class="cat" colspan="2"><input name="button" type="button" onClick="window.close()" value="CLOSE" class="button" style="font-size:7pt" /></td>
  </tr>
</table>
</body>
</html>
    
    </div>
    </form>
</body>
</html>
