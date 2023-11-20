<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HandSetCountViewAction.aspx.cs" Inherits="HandSetCountViewAction" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<meta http-equiv="Content-Style-Type" content="text/css" />
<title>3G Retention - Web Log</title>
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
<script type="text/javascript">
<!--
function close_win(){
//	return window.location="/cccl/cccl_main.aspx";
return top.location="~/Logout.aspx"
}
//-->
</script>
</head>
<body>



    <form id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
    <asp:PlaceHolder ID="hs_count_placeholder" runat="server"></asp:PlaceHolder>    
    </div>
    </form>
    
<table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; View 
<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
</table>       

<div align="center" class="gensmall">&nbsp;</div>
<a name="bot" id="bot"></a>
</body>
</html>
