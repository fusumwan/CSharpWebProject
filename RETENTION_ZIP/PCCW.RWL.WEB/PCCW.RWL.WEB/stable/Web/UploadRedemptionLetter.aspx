<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UploadRedemptionLetter.aspx.cs" Inherits="UploadRedemptionLetter" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
</head>
<body>

    <form id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
                  <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <th height="28" ><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %> - Upload Redemption letters 
                    Customer list </th>
                </tr>
	<tr class="row1">
		<td>
		Select a  file to upload 
	   <asp:FileUpload ID="FileUpload1" runat="server"/>
	   </p>
                    <p> Points To Note: <a href="Redemption_letters.xls" target="_blank"><br>
                      </a></p>
                    <ul>
                      <li>The File size of uploaded file should not exceed 10MB.</li>
                      <li>The uploaded file will be deleted from the server immediately 
                        after all the data in the file imported to the database. 
                        The server WILL NOT preserve any uploaded file. <br>
                      </li>
                      <li>The file should be in the format of the template.<a href="Redemption_letters.xls" target="_blank">(Download 
                        the Template Here)</a> </li>
                      <li>DO NOT rename the rows in the template as the name tell 
                        the system what is inside the file. </li>
                      <li>The Sheet name of the SpreadSheet should be &quot;Sheet1&quot; 
                        (the default name). All the data should be prepared in 
                        this sheet.</li>
                    </ul>
                    <div align="center">
                    <asp:Button ID="upload_but" Text="Upload" runat="server" 
                            onclick="upload_but_Click"/>
                    </div>
		<br>
	  </td>
	</tr>
                <tr> 
                  <td class="cat" >&nbsp;</td>
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
