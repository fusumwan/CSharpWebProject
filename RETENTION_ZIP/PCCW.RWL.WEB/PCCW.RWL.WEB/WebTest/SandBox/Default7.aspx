<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default7.aspx.cs" Inherits="SandBox_Default7" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></cc1:ToolkitScriptManager>
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
 
                <asp:DropDownList ID="DropDownList1" runat="server" 
                    onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Text="Apple" Value="Apple"></asp:ListItem>
                <asp:ListItem Text="BBB" Value="BBB"></asp:ListItem>
                </asp:DropDownList>
                <br />
                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="DropDownList2_SelectedIndexChanged">
                </asp:DropDownList>
 
            </ContentTemplate>
        </asp:UpdatePanel>
        
        
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
