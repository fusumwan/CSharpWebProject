<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FreeMonthViewImplement.aspx.cs" Inherits="FreeMonthViewImplement" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    

<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
<script type="text/javascript">
function isNum(tobj){
	if(tobj.value!=""){
	a= Number(tobj.value);
	if (!(a) && tobj.value!="0"){
		alert ("Number Only!");
		tobj.value = "";
		}
	}
	else
		tobj.value = "";
}

function chk_del(id) {
	if(confirm("Are you sure you want to Delete?")==false){
		event.returnValue=false;
		document.getElementById('form1').submit2.disabled=false;
	}
	else {
		document.location.href='rwl_free_mon_delC.aspx?id='+id;
	}
}

function chk_save(ThisForm){
	if(event.returnValue!=false){
		if(confirm("Are you sure you want to Save?")==false)
			event.returnValue=false;
		else
			ThisForm.submit()
	}
}

function BackMainPage() {
    document.location.href = "MobileRetentionMain.aspx";
}
</script>
</head>
<body style="background-color:#ffffff">



<form id="form1" runat="server">
<div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
<div>  
            <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
              <tr> 
                <th width="100%" height="28" colspan="7">&nbsp;<%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></th>
              </tr>
              <tr> 
                <td height="40" colspan="7" class="row2"> <span class="gensmall"> 
                  </span><span class="gensmall"><span class="gensmall" id="rc"><br />
                  </span></span> <input name="submit22" type="button" class="button" value="BACK" onClick="BackMainPage();"/> 
                </td>
              </tr>
              <tr> 
                <td width="3%" class="row1">&nbsp;</td>
                <td width="8%" class="row1"><span class="explaintitle" style="font-size:7pt">Free Monthly Fee</span></td>
                <td width="8%" class="row1"><span class="explaintitle" style="font-size:7pt">No 
                  of Free Month</span></td>
                <td width="8%" class="row1"><span class="explaintitle" style="font-size:7pt">Last 
                  month fee</span></td>
                <td width="8%" class="row1"><span class="explaintitle">Modify</span></td>
                 <td width="5%" class="row1"><span class="explaintitle"> Delete</span></td>
                <td width="60%" class="row1"><span class="explaintitle"></span></td>
              </tr>
              





               <tr> 
                  <td width="3%" nowrap="nowrap" class="row2"></td>
                 <td width="8%" nowrap="nowrap" class="row2" >
                  <asp:DropDownList ID="drpFREE_MON_ADD" runat="server"  Font-Size="7pt" Width="150" >
                  </asp:DropDownList>
                  </td>
                  <td width="8%" nowrap="nowrap" class="row2">
                  <asp:TextBox ID="txtMON_ADD" runat="server" Text='' MaxLength="60" Width="200px" Font-Size="7pt" onblur="isNum(this);"></asp:TextBox>
                  </td>
                  <td width="8%" nowrap="nowrap" class="row2">
                  <asp:TextBox ID="txtFEE_ADD" runat="server" Text='' MaxLength="60" Width="200px" Font-Size="7pt" onblur="isNum(this);"></asp:TextBox>
                  </td>
                 <td width="8%" nowrap="nowrap" class="row2" align="center"><span class="gensmall"> 
                 <asp:Button id="submitbut" CommandName="ADD" CssClass="button" 
                         CommandArgument="ADD" Text="ADD" runat="server" onclick="submitbut_Click" />
                    <b></b></span></td>
                   <td width="5%" nowrap="nowrap" class="row2" align="center"><span class="gensmall"></span></td>
                  <td width="5%" nowrap="nowrap" class="row2" align="center"><span class="gensmall"></span></td>
                </tr>
              



              
              
              
              <tr> 
                <td class="row3" colspan="7">&nbsp;</td>
              </tr>
              
              
              
              
              
              
              

<EW:RepeaterEx ID="MobileOrderMonthlyFee_VIEW_RP" runat="Server"  onitemcommand="MobileOrderMonthlyFee_VIEW_RP_ItemCommand"   onitemdatabound="MobileOrderMonthlyFee_VIEW_RP_ItemDataBound" >
<ItemTemplate>
<tr>
<td width="3%" nowrap="nowrap" class="row2"><asp:Label ID="FreeMonNum" runat="server"></asp:Label><asp:Label ID="txtmid" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "mid")%>' Visible="false"></asp:Label></td>
<td width="8%" nowrap="nowrap" class="row2" align="center">
<asp:DropDownList ID="drpFREE_MON" runat="server"  Font-Size="7pt"  Width="150" DataTextField="free_mon" DataValueField="free_mon"  >
</asp:DropDownList>
<asp:Label ID="txtFREE_MON" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "free_mon") %>' Visible="false"></asp:Label> </td>
<td width="8%" nowrap="nowrap" class="row2" align="left"><asp:TextBox ID="txtMON" Text='<%# DataBinder.Eval(Container.DataItem, "mon")%>' runat="server" Visible="true" Width="200" MaxLength="60"></asp:TextBox></td>
<td width="8%" nowrap="nowrap" class="row2" align="left"><asp:TextBox ID="txtFEE" Text='<%# DataBinder.Eval(Container.DataItem, "fee")%>' runat="server" Visible="true" Width="200" MaxLength="60"></asp:TextBox></td>
<td width="8%" nowrap="nowrap" class="row2" align="center"><asp:Button ID="RWL_FREEMONbtn" runat="server" Text="Modify" CommandArgument="Modify" CssClass="button" CommandName="Modify" OnClientClick="return confirm('Are you sure you want to Save?');" /></td>
<td width="8%" nowrap="nowrap" class="row2" align="center"><asp:LinkButton ID="RWL_FREEMONlink" CommandName="Delete" CommandArgument="Delete" runat="server" Text="x" OnClientClick="return confirm('Are you sure you want to Delete?');"></asp:LinkButton></td>
<td width="5%" nowrap="nowrap" class="row2" align="center"><span class="gensmall"></span></td>
</tr>
</ItemTemplate>
</EW:RepeaterEx>


              
              <tr> 
                <td class="cat" colspan="7">&nbsp;</td>
              </tr>
            </table>
            
            
            </div></form>
            
<table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; View 
<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
</table>       
</td></tr></table></td>
</tr></table>
</body>
</html>
