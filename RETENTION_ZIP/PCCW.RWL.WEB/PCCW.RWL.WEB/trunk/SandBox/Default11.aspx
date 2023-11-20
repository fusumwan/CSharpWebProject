<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default11.aspx.cs" Inherits="SandBox_Default11" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet"  href="../Resources/Styles/global.css" type="text/css" />
<link rel="stylesheet"  href="../Resources/Styles/rwlstyle.css" type="text/css" />
<asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <cc1:ToolkitScriptManager ID="AddWebLogScriptManager" runat="server" EnablePartialRendering="true" ScriptMode="Release" LoadScriptsBeforeUI="false" EnablePageMethods="true"></cc1:ToolkitScriptManager>
     <select id="Jscontrol" runat="server">
     <option value='b'>b</option>
     </select>
     
     
     <script>
         document.getElementById('Jscontrol').options.length = 0;
         document.getElementById('Jscontrol').options[0] = new Option('a', 'a');
     </script>
    </div>
    </form>
</body>
</html>
