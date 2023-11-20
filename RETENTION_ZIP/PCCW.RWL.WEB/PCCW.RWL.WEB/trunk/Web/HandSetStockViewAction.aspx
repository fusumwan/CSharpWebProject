<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HandSetStockViewAction.aspx.cs" Inherits="HandSetStockViewAction" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<meta http-equiv="Content-Style-Type" content="text/css" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
<script type="text/javascript">
<!--
function close_win(){
//	return window.location="/cccl/cccl_main.aspx";
	return top.location="../chk_login.asp"
}
//-->
</script>
</head>
<body>


    <form id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
    <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
		<tr> 
			<th colspan="100">Handset</th>
		</tr>
	  <tr>
		<td width="657" height="24" class="row2"><span class="explaintitle" style="font-size:7pt"> 
		  Product </span></td>
	            <td width="133" class="row2"><span class="explaintitle" style="font-size:7pt">Remaining</span></td>
	</tr>
				  

	
	<asp:PlaceHolder ID="stockplace" runat="server"></asp:PlaceHolder>
	<!--
		<tr>
	<td width="657" height="24" class="row1"> 
	<span class="gensmall" style="font-size:7pt">
	ASUS EEE PC 901-W004X 12GB/XP/PEARL WHITE/CHI
	</span></td>
	<td width="155" class="row1"><span class="gensmall" style="font-size:7pt"> 
	-1
	</span></td>
		</tr>
		-->
		  

		<tr> 
			<td class="cat" colspan="100">&nbsp;</td>
		</tr>
  </table>
            </table>
<table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; View 
<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
</table>       

            <div align="center" class="gensmall">&nbsp;</div>
<a name="bot" id="bot"></a></td></tr></table></td>
</tr></table>
    </div>
    </form>
</body>
</html>
