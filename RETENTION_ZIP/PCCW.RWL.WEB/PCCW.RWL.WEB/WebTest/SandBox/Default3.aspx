<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="SandBox_Default3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language="javascript">
        function SetFrame() {
            document.getElementById('iframe1').src = "Default4.aspx";
            document.getElementById('iframe2').src = "Default4.aspx";
        }
    
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <iframe id="iframe1" runat="server" frameborder="1" style="border-width:10px; width:300px; height:100px" ></iframe>
    <br />
    <iframe id="iframe2" runat="server" frameborder="1" style="border-width:10px; width:300px; height:100px" ></iframe>
    <br />
    <input id="Btn" runat="server" type="button" value="Btn" onclick="SetFrame()" />
    </div>
    </form>
</body>
</html>
