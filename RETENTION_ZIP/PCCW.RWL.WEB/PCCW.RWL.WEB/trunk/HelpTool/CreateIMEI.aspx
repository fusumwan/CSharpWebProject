<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CreateIMEI.aspx.cs" Inherits="SandBox_Default9" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <script language="javascript">
     function SetTxt(){
    document.getElementById('txt').value="2";
    alert(document.getElementById('txt').value);
    event.returnValue=false;
    }
    </script>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <select id="sel">
    <option value="1" selected="selected">1</option>
    <option value="2">2</option>
    <option value="3">3</option>
    </select>
    

    </div>
    </form>
</body>
</html>
