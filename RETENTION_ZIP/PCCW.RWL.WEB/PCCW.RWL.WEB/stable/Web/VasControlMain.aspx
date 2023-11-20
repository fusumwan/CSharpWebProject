<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VasControlMain.aspx.cs" Inherits="VasControlMain" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<html>
<head runat="server">


<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>

<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
</head>
	<body>
		<form  id="form1" runat="server">
		<div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
	  		<table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
				<tr>
					<td align="top">
	 					 <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
						 	<tr>
								<td height="10" class="row2">&nbsp;</td>
								<td height="10" class="row2" align="center"><span class="explaintitle" style="font-size:8pt">VAS CONTROL</span></td>
								<td height="10" class="row2">&nbsp;</td>
							</tr>						 
						 	<tr>
								<td height="10" width="33%" class="row1" align="center"><span class="explaintitle"><a href="VasAddRelationMapping.aspx">Add Vas Rules</a></span></td>
								<td height="10" width="33%" class="row1" align="center"><span class="explaintitle"><a href="VasView.aspx">Search Vas Rules</a></span></td>
								<td height="10" width="33%" class="row1" align="center"><span class="explaintitle"><a href="VasAssignNew.aspx">Create Vas</a><br /><a href="VasAssignValue.aspx">Assign Vas Value</a></span></td>
							</tr>
							<tr>
								<td height="10" width="33%" class="row1" align="center"><span class="explaintitle"><a href="VasModifyView.aspx">Modify Vas</a></span></td>
								<td height="10" width="33%" class="row1" align="center"><span class="explaintitle"><a href="VasDescriptionNew.aspx">Create Vas Desc</a></span></td>
								<td height="10" width="33%" class="row1" align="center"><span class="explaintitle"><a href="BusinessVasAutoSelect.aspx">Vas Auto Select</a></span></td>
							</tr>						 
						 </table>
					</td>
				</tr>
			</table>
		</form>
	</body>
</html>

				
