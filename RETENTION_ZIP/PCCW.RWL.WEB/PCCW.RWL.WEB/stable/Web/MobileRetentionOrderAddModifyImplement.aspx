<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MobileRetentionOrderAddModifyImplement.aspx.cs" Inherits="Web_MobileRetentionOrderAddModifyImplement" %>
<%@ Register TagPrefix="RWLMenu" TagName="RWLMenu" Src="~/UI/RWLControlMenu.ascx" %> 
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Register TagPrefix="RWLviewrow" TagName="RWLviewrow" Src="~/UI/RecordOrderViewRow.ascx" %> 
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
	<head id="Head1" runat="server">
	<meta http-equiv="Content-Style-Type" content="text/css" />
	<meta http-equiv="Content-Type" content="text/html; charset=big5" />
	<title>3G Retention - Web Log</title>
	  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<link rel="stylesheet"  href="../Resources/Styles/global.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
	<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
	</head>
<body  style="background-color:#ffffff" class="page-regular">
    <form id="form1" runat="server"><div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div id="page-content">
    <table  class="form-simple" width="100%" cellspacing="0" cellpadding="0" border="0">
	<tr class="strow">
	<td valign="top">
		  <table width="100%" border="0" cellspacing="0" cellpadding="2">
			<tr class="strow">
			  <td align="right" >&nbsp;<a href="javascript:close_win();"><b>X</b></a>&nbsp;</td>
	        </tr>
	        </table>
	<table width="100%" border="0" cellspacing="0" cellpadding="10">
	<tr class="strow">
	<td>
				  <table width="100%" cellspacing="2" cellpadding="3" border="0">
	<tr class="strow">
					  
					<td ><span  style="font-size:10pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
	</tr>
	<tr class="strow">
					  
					
                <td >
                
</td></tr></table>  
	             <RWLviewrow:RWLviewrow ID="RWLviewrow1" runat="server" Visible="false" />
	
					  <table width="100%" cellspacing="2" cellpadding="3" border="0">
	<tr class="strow">
					  <asp:PlaceHolder ID="DetailInfo" runat="server">
					  
			            <table width="100%" border="0" cellpadding="3" cellspacing="1"  class="form-simple">
                          <tr class="strow"> 
                            <th width="100%" height="28">&nbsp;</th>
                          </tr>
                          <tr class="strow"> 
                            <td height="23"  align="center" ><span >Plan 
                              Code / Contract Period / Trade Field / Bundle Name Incorrect!<br>
                              </span><span > 
                              <input type="button" name="submit2" value="Add New" onClick="location.href='MobileRetentionOrderCreate.aspx'"/>
                              </span> </td>
                          </tr>
                          <tr class="strow"> 
                            <td >&nbsp;</td>
                          </tr>
                        </table>
					  
					  </asp:PlaceHolder>
					  
	</tr>
	</table>
        <table width="100%" cellspacing="2" cellpadding="3" border="0" class="form-simple">
        <tr > 
        <td ><a href="MobileRetentionMain.aspx">Main Page</a> <span  ><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
        </tr>
        </table>  
	
	              
	</td>
	</tr>
	</table>
	
	</td>
	</tr>
	</table>

    </div>
    </form>
</body>
</html>
<script type="text/javascript" src="/js/dopageunload.js" language="JavaScript"></script>