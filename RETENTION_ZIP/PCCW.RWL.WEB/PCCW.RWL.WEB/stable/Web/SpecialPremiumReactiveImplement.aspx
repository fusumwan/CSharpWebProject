<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SpecialPremiumReactiveImplement.aspx.cs" Inherits="SpecialPremiumReactiveImplement" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
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
                <th width="100%" height="28" colspan="30">&nbsp;<%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></th>
              </tr>
              <tr> 
                <td height="40" colspan="26" class="row2"> <span class="gensmall"> 
                  </span><span class="gensmall"><span class="gensmall" id="rc"><br />
                  </span></span> <input name="submit22" type="button" class="button" value="BACK" onClick="BackMainPage();"/> 
				  
                </td>
              </tr>
              <tr> 
                <td width="3%" class="row1">&nbsp;</td>
                <td width="8%" class="row1"><span class="explaintitle" style="font-size:7pt">Rate 
                  Plan</span></td>
                <td width="8%" class="row1"><span class="explaintitle" style="font-size:7pt">Contract 
                  Period </span></td>
                <td width="8%" class="row1"><span class="explaintitle" style="font-size:7pt">Special 
                  Premium </span></td>
                <td width="8%" class="row1"><span class="explaintitle">Modify</span></td>
                 <td width="5%" class="row1"><span class="explaintitle"> </span></td>
                <td width="60%" class="row1"><span class="explaintitle"></span></td>
              </tr>
              
 
              
              <tr> 
                <td class="row3" colspan="26">&nbsp;</td>
              </tr>
              
              
              
<EW:RepeaterEx ID="RWL_s_premium_RP" runat="Server"  onitemcommand="RWL_s_premium_RP_ItemCommand"  onitemdatabound="RWL_s_premium_RP_ItemDataBound">
<ItemTemplate>
<tr>
<td width="3%" nowrap="nowrap" class="row2"><asp:Label ID="SPremiumNum" runat="server"></asp:Label><asp:Label ID="txtmid" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "mid")%>' Visible="false"></asp:Label></td>
<td width="8%" nowrap="nowrap" class="row2" align="center">
<asp:DropDownList ID="drps_premium_RATE_PLAN" runat="server"  Font-Size="7pt" Width="150" DataTextField="rate_plan" DataValueField="rate_plan" Enabled="false">
</asp:DropDownList><asp:Label ID="txts_premium_RATE_PLAN" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "rate_plan") %>' Visible="false"></asp:Label> </td>
<td width="8%" nowrap="nowrap" class="row2" align="center">
<asp:DropDownList ID="drps_premium_CON_PER" runat="server"  Font-Size="7pt" Width="150" DataTextField="con_per" DataValueField="con_per" Enabled="false"   >
</asp:DropDownList><asp:Label ID="txts_premium_CON_PER" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "con_per") %>' Visible="false"></asp:Label>  </td>

<td width="8%" nowrap="nowrap" class="row2" align="left"><asp:Literal ID="txtSpecialPremium" Text='<%# DataBinder.Eval(Container.DataItem, "s_premium")%>' runat="server" Visible="true" ></asp:Literal></td>
<td width="8%" nowrap="nowrap" class="row2" align="center"><asp:Button ID="SpecialPremiumbtn" runat="server" Text="Re-Active" CommandArgument="Reactive" CssClass="button" CommandName="Reactive" OnClientClick="return confirm('Are you sure you want to Re-Active?');" /></td>
<td width="8%" nowrap="nowrap" class="row2" align="center"></td>
<td width="5%" nowrap="nowrap" class="row2" align="center"><span class="gensmall"></span></td>
</tr>
</ItemTemplate>
</EW:RepeaterEx>
              
              
              </div></form>
              
              
              <tr> 
                <td class="cat" colspan="7">&nbsp;</td>
              </tr>
            </table>
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
