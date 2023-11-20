<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HandSetUpload.aspx.cs" Inherits="HandSetUpload" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=big5"/>
<meta http-equiv="Content-Style-Type" content="text/css" />
<title>Call Center Staff Offer Clearance Program</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
<script type="text/javascript" src="../Resources/Scripts/calendarDateInput.js"></script>
<script type="text/javascript">

function test(selected,idn)
{
idd = parseInt(idn.charAt(idn.indexOf("h")+1))+1
for(i=idd;i<5;i++)
      id = "path" + i;
      document.getElementById(id).options.length = 1;
      document.write(id)
}

function SaveChk(){
 var tp1 = document.getElementById("attach").value.split(".");
    if (tp1[1] != "xls"){
       alert("The attachment is not a excel file~!!");
       event.returnValue=false;
	   }
}

function chk_save(){
	 var tp1 = document.getElementById("attach").value.split(".");
    if (tp1[1] != "xls"){
       alert("The attachment is not a excel file~!!");
	   }
	else { 
	    document.form1.action="HandSetUploadAction.aspx";
	    document.form1.submit();
    }
}
</script>
    <style type="text/css">
        .style1
        {
            background: #f9f9f9;
            width: 312px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
     <a name="top" id="top"></a>
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
    <form action="" method="post" enctype="multipart/form-data" name="form1" id="form2" onSubmit="chk_save();this.disabled=false">
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
                      <th height="28" colspan="6">Import Records(HS Record)</th>
                    </tr>
                    <tr>
     			      <td height="49" valign="middle" class="style1"><span class="explaintitle">Import File 
                        Name :</span></td>
                      <td valign="middle"class="row1" nowrap="nowrap">
                      <span class="explaintitle">
                      <asp:FileUpload ID="ExcelUpload" Width="200px" CssClass="button" runat="server" />
                      <asp:RadioButtonList ID="excelversion" RepeatDirection="Horizontal" AppendDataBoundItems="true" CssClass="highlightrow" runat="server" Font-Size="7pt">
                      <asp:ListItem Text="EXCEL2003" Value="EXCEL2003" style="font-size:7pt" Selected="True"></asp:ListItem>
                      <asp:ListItem Text="EXCEL2007" Value="EXCEL2007" style="font-size:7pt"></asp:ListItem>
                      </asp:RadioButtonList> 
                      </span>
	                  </td>
                    </tr>
                    <tr>
                        <td valign="middle" class="style1"><span class="explaintitle">Upload Data To :</span></td>
                        <td valign="middle"class="row1" nowrap="nowrap"><span class="explaintitle">
                            <asp:RadioButtonList ID="uploadto" RepeatDirection="Horizontal" AppendDataBoundItems="true" CssClass="highlightrow" runat="server" Font-Size="7pt">
                                <asp:ListItem Text="UAT DATABASE" Value="true" style="font-size:7pt" Selected="True"></asp:ListItem>
                                <asp:ListItem Text="PRODUCTION DATABASE" Value="false" style="font-size:7pt"></asp:ListItem>
                            </asp:RadioButtonList>                             
                        </span></td>
                    </tr>
    <tr>
          <td height="30" valign="middle" class="style1"><span class="explaintitle"></span></td>
            
          <td height="30" valign="middle" class="row1" ><span class="explaintitle"> 
            <asp:Button ID="Submit" runat="server" Text="Upload"
                  onclick="Submit_Click" />
            &nbsp;&nbsp;</span> 	
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
    <a name="bot" id="bot"></a></td>
    </tr></table>

    </td>
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
    </div>
    </form>
</body>
</html>
