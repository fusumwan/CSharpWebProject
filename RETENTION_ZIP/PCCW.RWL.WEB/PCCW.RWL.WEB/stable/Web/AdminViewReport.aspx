<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminViewReport.aspx.cs" Inherits="AdminViewReport" %>

<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>

<%@ Import Namespace="PCCW.RWL.CORE" %>
<%@ Import Namespace="NEURON.ENTITY.FRAMEWORK" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>3G Retention - Web Log</title>
    <meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
<table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
  <tr> 
                <td class="row1">&nbsp;</td>
                 <%// FieldHeaderShow(); %>
                 <%// VasHeaderShow(); %>
                 <% HeaderShow(); %>
                 </tr>
                 <% SearchReportShow(); %>
            </table>
    
    </div>
    </form>
</body>
</html>
<% ExportExcel(); %>
