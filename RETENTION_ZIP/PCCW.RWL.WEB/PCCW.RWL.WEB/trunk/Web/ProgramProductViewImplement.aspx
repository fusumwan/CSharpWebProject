<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProgramProductViewImplement.aspx.cs" Inherits="ProgramProductViewImplement" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %> 
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<%@ Import Namespace="NEURON.ENTITY.FRAMEWORK" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<meta http-equiv="Content-Style-Type" content="text/css" />
<title>Quota System</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
 <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
<script language="javascript">
function rec_release(record)
{
  xmlHttp=GetXmlHttpObject()
 // if (xmlHttp==null)
  //{
  //  alert ("Your browser does not support AJAX!");
  //  return;
 // } 
  var url="rwl_prog_release.aspx";
  url=url+"?q="+record;
  url=url+"&sid="+Math.random();
  xmlHttp.onreadystatechange=stateChanged;
  xmlHttp.open("GET",url,true);
  xmlHttp.send(null);

}

function stateChanged() 
{ 
   if (xmlHttp.readyState==4)
   { 
       //document.getElementById("txtHint").innerHTML=xmlHttp.responseText;	
       //alert(xmlHttp.responseText)
  	var ab = document.getElementById("trquota"+xmlHttp.responseText)
        tquota.deleteRow(ab.rowIndex)	
	
   }
}

function GetXmlHttpObject()
{
  var xmlHttp=null;
  try
    {
    // Firefox, Opera 8.0+, Safari
    xmlHttp=new XMLHttpRequest();
    }
  catch (e)
    {
    // Internet Explorer
    try
      {
      xmlHttp=new ActiveXObject("Msxml2.XMLHTTP");
      }
    catch (e)
      {
      xmlHttp=new ActiveXObject("Microsoft.XMLHTTP");
      }
    }
  return xmlHttp;
}

</script>

<style type="text/css">

.style1 {color: #FF0000}

</style>
</head>
<body>
    <form id="form1" action="cnas_viewC.aspx"  runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>

    
    <table class="bodyline" width="100%" cellspacing="0" cellpadding="0" border="0">
<tr>
<td valign="top">
      <table width="100%" border="0" cellspacing="0" cellpadding="2">
        <tr>
          <td align="right" class="topnav">&nbsp;<a href="javascript:location.href='quotas_main.aspx';"></a>&nbsp;</td>
</tr>
</table>
<table width="100%" border="0" cellspacing="0" cellpadding="10">
<tr>
<td>

              <table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
	              <td height="38" class="maintitle">Program ID</td>
</tr>
<tr>
                  <td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; 
                    View Log Record </td>
</tr>
</table>              
              <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline" name="tquota" id="tquota">
		<tbody id="myTableTBody" name="myTableTBody">
                <tr> 
                  <th height="28" colspan="28">Product Record</th>
                </tr>
                <tr> 
                  <td height="23" colspan="28" class="row2"> <span class="gensmall"> 
                    Program ID: <%=WebFunc.qsProgram%><br>
                    Staff Number: <%=WebFunc.qsStaff_no%><br>
                    Log Date: <%=WebFunc.qsCdate%> TO <%=WebFunc.qsCdate%><br>

                    <br>
                    </span> <span class="gensmall">Number of Records: <span class="gensmall" id="rc"> 
                    <asp:Literal ID="record_count" runat="server"></asp:Literal>
                    <br>
                    </span></span> <input name="submit22" type="button" class="button" value="BACK" onClick="history.go(-1);"/> 
                    &nbsp;&nbsp; </td>
                </tr>
                
                <EW:RepeaterEx ID="admin_view_rp" runat="server">
                <HeaderTemplate>
                <tr > 
                  <td class="row1">&nbsp;</td>
                  <td class="row1"><span class="explaintitle">Program ID</span></td>
                  <td class="row1"><span class="explaintitle">Call List Type</span></td>
                  <td class="row1"><span class="explaintitle">Program Name</span></td>
                  <td class="row1"><span class="explaintitle">Center</span></td>
                  <td class="row1"><span class="explaintitle">Expiry Month</span></td>
                  <td class="row1"><span class="explaintitle">Type</span></td>
                  <td class="row1"><span class="explaintitle">Remarks</span></td>
                  <td class="row1"><span class="explaintitle">Call List Size</span></td>
                  <td class="row1"><span class="explaintitle">Call List Upload Date</span></td>
                  <td class="row1"><span class="explaintitle">Start Date</span></td>
                  <td class="row1"><span class="explaintitle">End Date</span></td>
                  <td class="row1"><span class="explaintitle">Return Date</span></td>
                  <td class="row1"><span class="explaintitle">Create Date</span></td>
                  <td class="row1"><span class="explaintitle">&nbsp;</span></td>
                  </tr>
                  </HeaderTemplate>
                  
                  <ItemTemplate>
                  <tr name='trquota<%# DataBinder.Eval(Container.DataItem,"id")%>' id ='trquota<%# DataBinder.Eval(Container.DataItem,"id")%>'> 
                  <td nowrap="nowrap" class="row2"><span class="gensmall"><asp:Literal ID="viewid" runat="server"></asp:Literal></span></td>
                  <td nowrap="nowrap" class="row2"><span class="gensmall"><%# DataBinder.Eval(Container.DataItem,"program_id")%></span></td>
                  <td nowrap="nowrap" class="row2"><span class="gensmall"><%# DataBinder.Eval(Container.DataItem,"call_list_type")%></span></td>
                  <td nowrap="nowrap" class="row2"><span class="gensmall"><%# DataBinder.Eval(Container.DataItem,"program_name")%></span></td>
                  <td nowrap="nowrap" class="row2"><span class="gensmall"><%# DataBinder.Eval(Container.DataItem,"center")%></span></td>
                  <td nowrap="nowrap" class="row2"><span class="gensmall"><%# DataBinder.Eval(Container.DataItem,"expiry_month")%></span></td>
                  <td nowrap="nowrap" class="row2"><span class="gensmall"><%# DataBinder.Eval(Container.DataItem,"type")%></span></td>
                  <td nowrap="nowrap" class="row2"><span class="gensmall"><%# DataBinder.Eval(Container.DataItem,"remarks")%></span></td>
                  <td nowrap="nowrap" class="row2"><span class="gensmall"><%# DataBinder.Eval(Container.DataItem,"call_list_size")%></span></td>
                  <td nowrap="nowrap" class="row2"><span class="gensmall"><%# DataBinder.Eval(Container.DataItem,"upload_date")%></span></td>
                  <td nowrap="nowrap" class="row2"><span class="gensmall"><%# DataBinder.Eval(Container.DataItem,"sdate")%></span></td>
                  <td nowrap="nowrap" class="row2"><span class="gensmall"><%# DataBinder.Eval(Container.DataItem,"edate")%></span></td>
                  <td nowrap="nowrap" class="row2"><span class="gensmall"><%# DataBinder.Eval(Container.DataItem,"return_date")%></span></td>
                  <td nowrap="nowrap" class="row2"><span class="gensmall"><%# DataBinder.Eval(Container.DataItem,"cdate")%></span></td>
                  <td nowrap="nowrap" class="row2"><input type="button" value="Delete" name="release" class="button" onclick="rec_release('<%# DataBinder.Eval(Container.DataItem,"id")%>')"></td>
                  </tr>
                  </ItemTemplate>
                  </EW:RepeaterEx>
                <tr> 
                  <td class="cat" colspan="28">&nbsp;</td>
                </tr>
	      </tbody>
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
    </div>
    </form>
</body>
</html>
