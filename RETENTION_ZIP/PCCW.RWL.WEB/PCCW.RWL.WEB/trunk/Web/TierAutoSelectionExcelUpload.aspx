<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TierAutoSelectionExcelUpload.aspx.cs" Inherits="TierAutoSelectionExcelUpload" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    

<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<script type="text/javascript">


</script>
<style>
.highlightrow{background:#FFFFbb}
    .style1
    {
        width: 307px;
        background: #d9e2ec;
    }
</style>
</head>
<body style="background-color:#ffffff">
    <form id="form1" action="" method="post" name="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
    <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <th height="28" colspan="4">&nbsp;<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></th>
                </tr>
                <tr> 
                  <td height="23" colspan="4" class="row2">
                  <asp:Button ID="submit" CssClass="mainoption" Text="Upload" Font-Size="7pt" runat="server"  onclick="submit_Click"/>  
                  <asp:Button ID="viewmodify" CssClass="mainoption" Text="View & Modify" Font-Size="7pt" runat="server" PostBackUrl="~/Web/TierAutoSelectionViewAndModify.aspx" />
                    <span class="explaintitle"> </span><span class="gensmall"> 
                    </span></td>
                </tr>
                <tr> 
                  <td height="0" class="style1"><span class="explaintitle" style="font-size:7pt">
                      Upload Tier Excel File (Under 10M): 
                    </span></td>
                  <td width="77%" height="0" class="row1"> &nbsp;<asp:FileUpload ID="ExcelUpload" runat="server" CssClass="mainoption" /></td>
                </tr>
                <tr> 
                  <td height="0" class="style1"><span class="explaintitle" style="font-size:7pt">Excel Version : 
                    </span></td>
                  <td width="77%" height="0" class="row1">
                  <asp:RadioButtonList ID="excelversion" RepeatDirection="Horizontal" AppendDataBoundItems="true" CssClass="highlightrow" runat="server" Font-Size="7pt">
                  <asp:ListItem Text="EXCEL2003" Value="EXCEL2003" style="font-size:7pt" Selected="True"></asp:ListItem>
                  <asp:ListItem Text="EXCEL2007" Value="EXCEL2007" style="font-size:7pt"></asp:ListItem>
                  </asp:RadioButtonList> 
                  </td>
                </tr>
                <tr>
                   <td height="0" class="style1"><span class="explaintitle" style="font-size:7pt">File Name: </span></td>
                   <td width="77%" height="0" class="row1"><span class="explaintitle" style="font-size:7pt"> <asp:Literal ID="file_name" runat="server"></asp:Literal></span></td>
                </tr>
                <tr>
                   <td height="0" class="style1"><span class="explaintitle" style="font-size:7pt">Upload Success Records: </span></td>
                   <td width="77%" height="0" class="row1"><span class="explaintitle" style="font-size:7pt"> <asp:Literal ID="upload_success_records" runat="server"></asp:Literal></span></td>
                </tr>
                <tr>
                   <td height="0" class="style1"><span class="explaintitle" style="font-size:7pt">Upload Fail Records: </span></td>
                   <td width="77%" height="0" class="row1"><span class="explaintitle" style="font-size:7pt"> <asp:Literal ID="upload_fail_records" runat="server"></asp:Literal></span></td>
                </tr>
                <tr>
                   <td height="0" class="style1"><span class="explaintitle" style="font-size:7pt">Duplicate Records: </span></td>
                   <td width="77%" height="0" class="row1"><span class="explaintitle" style="font-size:7pt"> <asp:Literal ID="duplicate_records" runat="server"></asp:Literal></span></td>
                </tr>
                
                <tr> 
                  <td class="cat" colspan="2">&nbsp;</td>
                </tr>
              </table>    
    </div>
    </form>   
<table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; View 
<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
</table>       
</body>
</html>
