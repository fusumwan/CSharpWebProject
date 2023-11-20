<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default5.aspx.cs" Inherits="SandBox_Default5" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
      
      <script language="javascript">
          $.ajax({
              type: "POST",
              url: 'WebService.asmx/HelloWorld',
              dataType: "json",
              contentType: "application/json; charset=utf-8",
              success: function(data) {
                  alert("Data:" + data);
              }
          })
      
      </script>
      
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>
