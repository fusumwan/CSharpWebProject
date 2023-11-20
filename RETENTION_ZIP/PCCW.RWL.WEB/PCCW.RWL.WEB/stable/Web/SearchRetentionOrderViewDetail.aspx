<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SearchRetentionOrderViewDetail.aspx.cs" Inherits="SearchRetentionOrderViewDetail" %>
<%@ Register TagName="RWLMenu2" TagPrefix="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register TagPrefix="RWLviewrow" TagName="RWLviewrow" Src="~/UI/RecordOrderViewRow.ascx" %> 
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
<script type="text/javascript" language="JavaScript">
    function isCancelOrder() {
        if (document.getElementById('form1').del_remark != undefined) { if (confirm('Are you sure you want to delete this order?')) { if (document.getElementById('form1').del_remark.value != '') { document.getElementById('form1').submit(); } else { alert('Enter Cancel Remark?'); } } }
    }


    function PrintPDF(uat, order_id) {
       /*
        myWindow = window.open('http://136.139.22.21:8080/rwl' + uat + '/servlet/GenerateRWLForm?order_id=' + order_id, 'popup', 'toolbar=no, status=no, resizable=no, scrollbars=auto, menu=no');
*/
        myWindow = window.open('PrintingPopup.aspx?uat=' + uat + '&order_id=' + order_id, 'popup', 'toolbar=no, status=no, resizable=no, scrollbars=auto, menu=no,width=300,height=120');
    }

</script>

</head>
<body style="background-color:#ffffff">

    <form id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
    <asp:PlaceHolder ID="rwl_view_placeholder" runat="server"></asp:PlaceHolder>
     <RWLviewrow:RWLviewrow ID="RWLviewrow1" runat="server" Visible="false" />
    </div>
    </form>
<table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; View 
<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
</table>       
</body>
</html>
