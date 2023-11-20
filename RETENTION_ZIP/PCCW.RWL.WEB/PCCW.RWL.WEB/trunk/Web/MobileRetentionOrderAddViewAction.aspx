<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MobileRetentionOrderAddViewAction.aspx.cs" Inherits="MobileRetentionOrderAddViewAction" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>3G Retention - Web Log</title>
      <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:HiddenField ID="AutoSelection" runat="server" />
    <asp:HiddenField ID="NoRefresh" runat="server" />
    <asp:HiddenField ID="AllPageInScreen" runat="server" />
    </div>
    </form>
</body>
</html>
