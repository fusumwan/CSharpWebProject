﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default9.aspx.cs" Inherits="SandBox_Default9" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <script language="javascript">
        function ChkWord(This, Remove, Msg) {
            var pattern = /^[a-zA-Z.\-\s]+$/;
            if (This.value.match(pattern)) {
                return true;
            }
            else {

                if (Remove == true) { This.value = ""; }
                if (Msg != undefined && Msg != "") { alert(Msg); }
                return false;
            }
        }
    </script>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <input id="ServiceActivationDate" type="text"  value='' onblur="ChkWord(this,false,'please input word')" />
    </div>
    </form>
</body>
</html>
