<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MigrateToEDF.aspx.cs" Inherits="MigrateToEDF" %>
<%@ Register TagPrefix="RWLMenu" TagName="RWLMenu" Src="~/UI/RWLControlMenu.ascx" %> 
<%@ Register TagPrefix="RWLviewrow" TagName="RWLviewrow" Src="~/UI/RecordOrderViewRow.ascx" %> 
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>3G Retention - Web Log</title>
    <link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
    <link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
      <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
    <script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
    <script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>

    <meta http-equiv="Content-Style-Type" content="text/css" />
    <meta http-equiv="Content-Type" content="text/html; charset=big5" />
    <link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
    <script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
    <script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>

</head>
<body  style="background-color:#ffffff">
<form id="form1" runat="server">
<div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
<div>
    <table width="100%" cellspacing="2" cellpadding="3" border="0">
    <tr>                
    <td class="nav"></td>
    </tr>
    </table>              
            <RWLviewrow:RWLviewrow ID="RWLviewrow1" runat="server" />
<table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; View 
<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
</table>       
</div>
</form>
<script type="text/javascript" src="/js/dopageunload.js" language="JavaScript"></script>
</body>
</html>
