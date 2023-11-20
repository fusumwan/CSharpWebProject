<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default17.aspx.cs" Inherits="SandBox_Default17" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script language="javascript" type="text/javascript">
// <!CDATA[

        
// ]]>
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table id="Tbl1" border="1" onclick="javascript:setTimeout('__doPostBack(\'Tbl1\',\'\')', 0)" >
    <tr>
    <td>a</td>
    <td>b</td>
    <td>c</td>
    </tr>
    <tr>
    <td>z</td>
    <td>x</td>
    <td>c</td>
    </tr>
    <tr>
    <td>q</td>
    <td>w</td>
    <td>e</td>
    </tr>
    </table>
    
    <input id="But1" runat="server" name="But1" type="button" value="PostBack" onserverclick="But1_Click"  />
    <select id="Sel1" runat="server" name="Sel1" onchange="javascript:setTimeout('__doPostBack(\'Sel1\',\'\')', 0)" onserverchange="Sel1_Click">
    <option value=""></option>
    <option value="a">a</option>
    <option value="b">b</option>
    </select>
    </div>
    </form>
</body>
</html>
