<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VasRawDataBatchUploadActionProcess.aspx.cs" Inherits="VasRawDataBatchUploadActionProcess" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<meta http-equiv="Content-Style-Type" content="text/css" />
<title>3G Retention</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<script type="text/javascript">
<!--
function close_win(){
	return window.location="MobileRetentionMain.aspx";
}

function chk_time(objC){
	if(objC.value.length!=0){
		if(objC.value.match(/^\d{2}:\d{2}$/)==null){
			alert ("Invalid Time format! MM:SS");
			objC.value="";
			objC.focus();
			return false;
		}
	}
}

function chk_focus(){
//	document.getElementById('form1').serv_no.focus();
}
//-->
</script>

</head>
<body onLoad="chk_focus()">
<a name="top" id="top"></a>
    <form id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
    <table class="bodyline" width="100%" cellspacing="0" cellpadding="0" border="0">
<tr>
<td valign="top">
      <table width="100%" border="0" cellspacing="0" cellpadding="2">
        <tr>
          <td align="right" class="topnav">&nbsp;<a href="javascript:close_win();"><b>X</b></a>&nbsp;</td>
</tr>
</table>
<table width="100%" border="0" cellspacing="0" cellpadding="10">
<tr>
<td>

              <table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
	              <td class="maintitle">3G Retention</td>
</tr>
<tr>
                  <td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; 
                    Import Records</td>
</tr>
</table>              
              <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <th height="28" colspan="33">Import Records VAS Mapping </th>
                </tr>
                <tr>
     			  <td height="100" align="center" valign="middle" class="row1"><span class="explaintitle">Import 
                    Success ~!!!</span></td>
				</tr>
                <tr> 
                  <td class="cat" colspan="33" >&nbsp;</td>
                </tr>
              </table>
 <table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; View 
<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
</table>       


            <div align="center" class="gensmall">&nbsp;</div>
<a name="bot" id="bot"></a></td></tr></table></td>
<table width="100%" border="0" cellspacing="2" cellpadding="2">
  <tr>
    <td width="20%"><div align="center"></div></td>
    <td width="60%"><div align="center"></div></td>
    <td width="20%"><div align="center"></div></td>
  </tr>
  <tr>
    <td width="20%"><div align="center"></div></td>
    <td width="60%"><div align="center"></div></td>
    <td width="20%"><div align="center"></div></td>
  </tr>
</table>
</tr></table>
<br>
<br>
    </div>
    </form>
</body>
</html>
