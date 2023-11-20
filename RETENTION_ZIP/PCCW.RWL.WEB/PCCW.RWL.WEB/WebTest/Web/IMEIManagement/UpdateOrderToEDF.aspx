<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdateOrderToEDF.aspx.cs" Inherits="Web_IMEIManagement_UpdateOrderToEDF" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="~/UI/GlobalNavigation.ascx"TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet"  href="../../Resources/Styles/global.css"type="text/css" />
<link rel="stylesheet" href="../../Resources/Styles/MainPageStyle.css" type="text/css" />
<asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<script language="javascript">
    function BackMainPage() {
        document.location.href = "../MobileRetentionMain.aspx";
    }
</script>

    <style type="text/css">
        .style1
        {
            background: #d9e2ec;
            width: 147px;
        }
    </style>

</head>
<body style="background-color:#ffffff">
<form id="form1" runat="server">
<div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
<div>
<asp:ScriptManager ID="AddWebLogScriptManager" runat="server"></asp:ScriptManager>


<table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
  <tr> 
    <th width="100%" height="28" colspan="30">&nbsp;<%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></th>
  </tr>
  <tr> 
    <td class="style1"> 
     <input name="submit22" type="button" class="button" value="BACK" onClick="BackMainPage();"/>
    </td>
      <td class="row2"> 
  
        </td>
  </tr>
  <tr>
  <td  class="style1"> 
  <span class="title">Reference No(EDF No.)</span>
  </td>
    <td class="row2"> 
        <input name="edf_no" id="edf_no" type="text"  runat="server" />
        <asp:Button ID="update_chk" Text="Update Order Between EDF And RWL" 
            CssClass="button" runat="server" onclick="update_chk_Click" />
    </td>
  </tr>
  
</table>

</div>
</form>
<table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="../MobileRetentionMain.aspx">Main Page</a> &raquo; View 
<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
</table>
</body>
</html>
