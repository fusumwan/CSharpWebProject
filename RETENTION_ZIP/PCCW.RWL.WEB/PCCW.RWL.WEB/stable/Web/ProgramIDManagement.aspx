<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProgramIDManagement.aspx.cs" Inherits="ProgramIDManagement" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>3G Retention - Web Log</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
    <script type="text/javascript" src="../Resources/Scripts/calendarDateInput.js"></script>
<script type="text/javascript" src="../Resources/Scripts/creditcard.js"></script>
</head>
<body>
    <form name="newform" id ="newform" runat="server">
      <table width="100%" border="0" cellspacing="0" cellpadding="2">
        <tr>
          <td align="right" class="topnav">&nbsp;&nbsp;</td>
		</tr>
		</table>

			<table class="bodyline" width="100%" height="650" cellspacing="1" cellpadding="1" border="1">
				<tr>
					<td height="0" class="row2" width="20%"><span class="mainoption"  style="font-size:10pt">Program ID</span></td>
					<td height="0" class="row1"  width="80%"><span class="mainoption" style="font-size:11pt"><asp:Literal ID="program_id" runat=server></asp:Literal></span></td>
				</tr>
				<tr>
					<td height="0" class="row2"width="20%"><span class="mainoption"  style="font-size:10pt">Call List Type</span></td>
					<td height="0" class="row1" width="80%"><span class="mainoption"  style="font-size:11pt"><asp:Literal ID="call_list_type" runat=server></asp:Literal></span></td>
				</tr>
				<tr>
					<td height="0" class="row2" width="20%"><span class="mainoption"  style="font-size:10pt">Program Name</span></td>
					<td height="0" class="row1" width="80%"><span class="mainoption"  style="font-size:11pt"><asp:Literal ID="program_name" runat=server></asp:Literal></span></td>
				</tr>
				<tr>
					<td height="0" class="row2" width="20%"><span class="mainoption"  style="font-size:10pt">Center</span></td>
					<td height="0" class="row1" width="80%"><span class="mainoption"  style="font-size:11pt"><asp:Literal ID="center" runat=server></asp:Literal></span></td>
				</tr>
				<tr>
					<td height="0" class="row2" width="20%"><span class="mainoption"  style="font-size:10pt">Expriy Month</span></td>
					<td height="0" class="row1" width="80%"><span class="mainoption"  style="font-size:11pt"><asp:Literal ID="expiry_month" runat=server></asp:Literal></span></td>
				</tr>
				<tr>
					<td height="0" class="row2" width="20%"><span class="mainoption"  style="font-size:10pt">Type</span></td>
					<td height="0" class="row1" width="80%"><span class="mainoption"  style="font-size:11pt"><asp:Literal ID="type" runat=server></asp:Literal></span></td>
				</tr>
				<tr>
					<td height="0" class="row2" width="20%"><span class="mainoption"  style="font-size:10pt">Remarks</span></td>
					<td height="0" class="row1" width="80%"><span class="mainoption"  style="font-size:11pt"><asp:Literal ID="remarks" runat=server></asp:Literal></span></td>
				</tr>
				<tr>
					<td height="0" class="row2" width="20%"><span class="mainoption"  style="font-size:10pt">Call List Upload Date</span></td>
					<td height="0" class="row1" width="80%"><span class="mainoption"  style="font-size:9pt"><asp:Literal ID="upload_date" runat=server></asp:Literal></span></td>
				</tr>
				<tr>
					<td height="0" class="row2" width="20%"><span class="mainoption"  style="font-size:10pt">Start Date</span></td>
					<td height="0" class="row1" width="80%"><span class="mainoption"  style="font-size:9pt"><asp:Literal ID="sdate" runat=server></asp:Literal></span></td>
				</tr>
			</table>
		</form>
</body>
</html>
