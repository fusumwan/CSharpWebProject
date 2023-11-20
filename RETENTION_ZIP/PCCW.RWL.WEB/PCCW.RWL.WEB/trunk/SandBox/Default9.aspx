<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default9.aspx.cs" Inherits="SandBox_Default9" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
    <title>3G Retention - Web Log</title>
    <link rel="stylesheet"  href="../Resources/Styles/global.css" type="text/css" />
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />

<asp:Literal ID="NeuronJSLibrary" runat="server"></asp:Literal>
<asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
</head>


<body>
    <form id="form1" runat="server">
      <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
    <cc1:ToolkitScriptManager ID="AddWebLogScriptManager" runat="server" EnablePartialRendering="true" ScriptMode="Release" LoadScriptsBeforeUI="false" EnablePageMethods="true"></cc1:ToolkitScriptManager>
    
    <asp:Panel ID="PCCW" runat="server">
        <user:MobileOrderAddressUserControl ID="RegisterAddress" runat="server" TableTagVisable="true" DrpClass="disablerow" Enabled="true" TitleNameLbl="Delivery Address 送貨地址"
     TitleFontSize=8  TdOneClass="Ts1" TdTwoClass="Ts2" RblClass="highlightrow" ToolkitScriptManagerID="AddWebLogScriptManager" 
     LoadingImgSrc="../Web/images/loading.gif"
     DTypeClass="RegisterAddressDTypeClass" 
     DRegionClass="RegisterAddressDRegionClass" 
     DDistrictClass="RegisterAddressDDistrictClass" 
     DRoomClass="RegisterAddressDRoomClass" 
     DFloorClass="RegisterAddressDFloorClass" 
     DBlkClass="RegisterAddressDBlkClass" 
     DBuildClass="RegisterAddressDBuildClass" 
     DStreetClass="RegisterAddressDStreetClass" 
      />
    
    </asp:Panel>
    
    </div>
    </form>
</body>
</html>
