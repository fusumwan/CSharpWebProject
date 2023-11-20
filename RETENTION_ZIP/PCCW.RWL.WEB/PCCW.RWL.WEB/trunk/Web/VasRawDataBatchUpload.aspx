<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VasRawDataBatchUpload.aspx.cs" Inherits="VasRawDataBatchUpload" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html>
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=big5"/>
<meta http-equiv="Content-Style-Type" content="text/css" />
<title>Call Center Staff Offer Clearance Program</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<style type="text/css">
    .style1
    {
        background: #ffeeff;
        height: 8px;
    }
    .style2
    {
        background: #ffeeff;
        height: 17px;
    }
    .style3
    {
        background: #ffeeff;
        height: 8px;
        width: 318px;
    }
    .style4
    {
        background: #ffeeff;
        height: 17px;
        width: 318px;
    }
</style>


<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>

<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>

<script type="text/javascript" src="../Resources/Scripts/calendarDateInput.js"></script>
<script type="text/javascript">



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


</script>
</head>

<body>
<a name="top" id="top"></a>



<form action="" method="post" enctype="multipart/form-data" name="form1" id="form1" runat="server">
<div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
              <table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
	              <td class="maintitle"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></td>
</tr>
<tr>
                  <td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; 
                    Import Records</td>
</tr>
</table>
   
              <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <th height="28" colspan="6">Import Records(VAS MAPPING)</th>
                </tr>
                <tr>
     			  <td valign="middle" class="style3"><span class="explaintitle">Import File 
                    Name :</span></td>
                  <td valign="middle"class="style1" >
                  <asp:FileUpload ID="FileUpload1" runat="server" Width="300" CssClass="button"  />

	              </td>
                </tr>
<tr>
      <td valign="middle" class="style4"><span class="explaintitle"></span></td>
      <td valign="middle" class="style2"><span class="explaintitle"> 
      <asp:Button ID="upload_btn" runat="server" Text="Upload" OnClientClick="this.disabled=false" CssClass="button" onclick="upload_btn_Click" />
      
        &nbsp;&nbsp;</span> 	
      </td>
</tr>

<tr>
      <td valign="middle" class="style4"><span class="explaintitle"></span></td>
      <td valign="middle" class="style2"><span class="explaintitle"> 
      <asp:HyperLink NavigateUrl="~/Web/upload/BundleMappingSample.xls" Text="BundleMappingSample" runat="server"></asp:HyperLink>
</span> 	
      </td>
</tr>


                <tr> 
                  <td class="cat" colspan="6" align="center">
                  </td>
                </tr>
              </table>
<table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; View 
<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
</table>       
 
</form>

            <div align="center" class="gensmall">&nbsp;</div>
<a name="bot" id="bot"></a>
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

</body>
</html>


<script type="text/javascript" src="/js/dopageunload.js" language="JavaScript"></script>
