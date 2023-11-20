<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="SandBox_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <asp:RadioButtonList ID="upgrade_type" RepeatDirection="Horizontal" AppendDataBoundItems="true" runat="server">
                 <asp:ListItem Text="Mass Upgrade" Value="Mass Upgrade" onclick="UpgradeTypeChange()" ></asp:ListItem>
                 <asp:ListItem Text="Staff Upgrade" Value="Staff Upgrade" onclick="UpgradeTypeChange()" ></asp:ListItem>
                 </asp:RadioButtonList>
    <script language="javascript">
        function GetRadioButtonListVal(RadioButtonListID) {
            var a = null;
            var f = document.forms[0];
            var e = f.elements[RadioButtonListID];

            for (var i = 0; i < e.length; i++) {
                if (e[i].checked) {
                    a = e[i].value;
                    break;
                }
            }
            return a;
        }
        function OnGo() {
            alert(GetRadioButtonListVal('upgrade_type'));
        }
    </script>
    
    <input type="button" onclick="OnGo()" value="aaa" />
    </div>
    </form>
</body>
</html>
