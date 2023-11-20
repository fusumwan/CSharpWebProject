<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MobileOrderLockMessage.aspx.cs" Inherits="Web_MobileOrderLockMessage" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    

<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet"  href="../Resources/Styles/global.css" type="text/css" />
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<script>
function BackMainPage() {
    document.location.href = "MobileRetentionMain.aspx";
}
</script>
</head>
<body>
    <form id="form1" runat="server"><div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
    
            <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
              <tr> 
                <th width="100%" height="28" colspan="30">&nbsp;<%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></th>
              </tr>
              <tr> 
              
               <td height="40" colspan="26" class="row2"> <span class="gensmall"> 
                  </span><span class="gensmall"><span class="gensmall" id="rc"><br />
                  </span></span> <input name="submit22" type="button" class="button" value="BACK" onClick="BackMainPage();"/>

                </td>
              </tr>
              <tr>
                  <td class="topictitle">
                  <asp:Label ID="ErrorMessage" runat="server"></asp:Label>

                  </td>
              </tr>
              <tr> 
                <td class="cat" colspan="9">&nbsp;</td>
              </tr>
            </table>
    </div>
    </form>
</body>
</html>
