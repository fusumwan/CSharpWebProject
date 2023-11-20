<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HandSetManagement.aspx.cs" Inherits="HandSetManagement" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>HS</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table width="155" height="54" border="0" cellpadding="3"  cellspacing="2" dwcopytype="CopyTableRow">
  <tr>
    <td width="63" height="24" class="row1"><span class="explaintitle" style="font-size:7pt"> 
      Product </span></td>
<td width="74" class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="product" runat="server"></asp:Literal></span></td>
</tr>
<tr>
    <td height="24" class="row1"><span class="explaintitle" style="font-size:7pt">Remaining</span></td>
	<td width="155" class="row2"><span class="gensmall" style="font-size:7pt"> <asp:Literal ID="hs_count" runat="server"></asp:Literal></span></td>
	
	
</tr>
<tr>
    <td height="24" class="row1"><span class="explaintitle" style="font-size:7pt">Location</span></td>
	<td width="155" class="row2"><span class="gensmall" style="font-size:7pt"> <asp:Literal ID="location" runat="server"></asp:Literal></span></td>
	
	
</tr>


</table>

<br>
  <input name="button" type="button" onClick="window.close()" value="CLOSE" class="button" style="font-size:7pt"></div> </form> 

    </div>
    </form>
</body>
</html>
