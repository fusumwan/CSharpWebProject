<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HandSetUploadAction.aspx.cs" Inherits="HandSetUploadAction" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<meta http-equiv="Content-Style-Type" content="text/css" />
<title>Call Center Staff Offer eOrder System</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
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
<script language="javascript">

function back_main(ThisForm){
		if(event.returnValue!=false){
					document.getElementById('form1').action="HandSetUpload.aspx";
					document.getElementById('form1').submit();
		}
	}


</script>
</head>
<body onLoad="chk_focus()">
<a name="top" id="top"></a>
<form action="HandSetUploadActionProcess.aspx?fn=" method="post" name="form1" id="form1" runat="server">
<div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
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
                
                <asp:Panel ID="Check1" runat="server" >
                
                
                <tr> 
                  <td height="23" colspan="44" class="row2"><span class="gensmall">File Name : 
                  <asp:Literal ID="ServerDirFileName" runat="server"></asp:Literal>
                    <br>
                    Total of records: <asp:Literal ID="RecordCount" runat="server"></asp:Literal>
                    <br>
					<asp:Button ID="Import" Text="IMPORT" runat="server" />
					<input type="button" name="BACK" value="BACK"   onClick="back_main(this.form);" style="font-size:7pt"/>					</td>
			    </tr>
                
                <tbody  ><tbody  ><tr align="center" valign="middle">
                
                <asp:Panel ID="FieldNameList" runat="server"></asp:Panel>
                <asp:GridView ID="vas_gv" runat="server" AutoGenerateColumns="true"></asp:GridView>
                <asp:Panel ID="RecordValueList" runat="server">
                  <tr>
                  <td align="center" valign="bottom" nowrap="nowrap" class="row2" colspan="44" ><span class="gensmall"><strong><font color="#FF0000">
                  <asp:Label ID="msg" runat="server" Text='There will not show the record detail which total of records over than 50000~!!!!!!!'></asp:Label>
                  </font></strong></span></td>
				  </tr>
                </asp:Panel>
                
                
                </tr>
                
                </asp:Panel>
                <asp:Panel ID="Check2" runat="server" Visible="false">
                  <tr>
				  <td align="center" valign="bottom" nowrap="nowrap" class="row2" colspan="44" ><span class="gensmall"><strong><font color="#FF0000">Upload File Error~!!Pls Check~!! </font></strong></span></td>
				  </tr> 
                </asp:Panel>
 
                
                </td>

			   </tr> 
                  <td class="cat" colspan="44" >&nbsp;</td>
                </tr>
              </table>
<table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; View 
<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
</table>       
               </form>
</body>
</html>
