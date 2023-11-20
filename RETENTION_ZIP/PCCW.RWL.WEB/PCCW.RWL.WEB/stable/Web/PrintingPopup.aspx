<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PrintingPopup.aspx.cs" Inherits="Web_PrintingPopup" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<link rel="stylesheet" href="../Resources/Styles/RWLFormStyle.css" type="text/css" />

  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
    <style type="text/css">
        .style1
        {
            background: #d9e2ec;
            width: 246px;
        }
    </style>
    <script language="javascript">

        function PrintPDF(uat, order_id) {

            var myWindow2 = window.open('http://136.139.22.21:8080/rwl' + uat + '/servlet/GenerateRWLForm?order_id=' + order_id, 'popupw1', 'toolbar=no, status=no, resizable=no, scrollbars=auto, menu=no');

        }
        function PrintPDF2(uat, order_id) {
            var myWindow2 = window.open('http://136.139.22.21:8080/rwl' + uat + '/servlet/GenerateRWLCL?order_id=' + order_id, 'popupw2', 'toolbar=no, status=no, resizable=no, scrollbars=auto, menu=no');

        }
    </script>
</head>
<body>

    <form id="form1" runat="server">
    <div>


  <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <th height="28" colspan="2">View Order Form</th>
                </tr>
                <tr> 
                  <td height="23" colspan="1" class="style1"> 
                  Mobile Application Form
                  </td>
                  <td height="23" colspan="1" class="row2"> 
                  
                   <input id="Print1" runat="server" type="button" class="button" value="Print As PDF" />

                  </td>
                  </tr>
                  <tr> 
                  <td height="23" colspan="1" class="style1"> 
                  Confirmation Letter
                  </td>
                  <td height="23" colspan="1" class="row2"> 
                  <input id="Print2" runat="server" type="button" class="button" value="Print As PDF" />

                  </td>
                  </tr>
                  <tr> 
                  <td class="cat" colspan="3">&nbsp;</td>
                </tr>
              </table>
                  

    

    
    </div>
    </form>
</body>
</html>
