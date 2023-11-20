<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GiftCodeViewAction.aspx.cs" Inherits="GiftCodeViewAction" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
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
		document.location.href='GiftBasketcode_delC.aspx?id='+id;
	}
}

function chk_save(ThisForm){
	if(ThisForm.gift_desc.value==""){
		alert ("Please Enter Free Gift Description!");
		event.returnValue=false;
		ThisForm.submit1.disabled=false;
	}
	else if(ThisForm.gift_code.value==""){
		alert ("Please Enter Free Gift Code!");
		event.returnValue=false;
		ThisForm.submit1.disabled=false;
	}
	else if(ThisForm.sdate.value==""){
		alert ("Please Enter Start Date!");
		event.returnValue=false;
		ThisForm.submit1.disabled=false;
	}

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


  <form method="post" name="form1" id="form1" runat=server >
  <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
  <div>
  <asp:ScriptManager ID="AddWebLogScriptManager" runat="server"></asp:ScriptManager>
    
    <cc1:CalendarExtender runat="server" 
        ID="CalendarSDateFormat"
        TargetControlID="txtGIFT_SDATE_ADD"
        Format="MM/dd/yyyy"
        PopupButtonID="CalenderImageSDate" /> 
              
        <cc1:CalendarExtender runat="server" 
        ID="CalendarEDateFormat"
        TargetControlID="txtGIFT_EDATE_ADD"
        Format="MM/dd/yyyy"
        PopupButtonID="CalenderImageEDate" />
   
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
                <td width="8%" class="row1"><span class="explaintitle" >Free 
                  Gift Description</span></td>
                <td width="8%" class="row1"><span class="explaintitle">Free Gift 
                  Code</span></td>
                <td width="8%" class="row1"><span class="explaintitle">Free Gift 
                  Type</span></td>
                <td width="8%" class="row1"><span class="explaintitle">Start Date<br />
                  </span><span class="gensmall" style="font-size:9px">(MM/DD/YYYY)</span></td>
                <td width="8%" class="row1"><span class="explaintitle">End Date<br />
                  </span><span class="gensmall" style="font-size:9px">(MM/DD/YYYY)</span></td>
                <td width="8%" class="row1"><span class="explaintitle">Modify</span></td>
                 <td width="5%" class="row1"><span class="explaintitle"> Delete</span></td>
                <td width="60%" class="row1"><span class="explaintitle"></span></td>
              </tr>
              

               <tr> 
                  <td width="3%" nowrap="nowrap" class="row2"></td>
                  <td width="8%" nowrap="nowrap" class="row2" ><asp:TextBox ID="txtGIFT_DESC_ADD" runat="server" Text='' MaxLength="60" Font-Size="7pt" Width="300"></asp:TextBox></td>
                  <td width="8%" nowrap="nowrap" class="row2"><asp:TextBox ID="txtGIFT_CODE_ADD" runat="server" Text='' MaxLength="10" Font-Size="7pt"></asp:TextBox></td>
                  <td width="8%" nowrap="nowrap" class="row2"><asp:TextBox ID="txtGIFT_GP_ADD" runat="server" Text='' MaxLength="20" Font-Size="7pt"></asp:TextBox></td>
                  <td width="8%" nowrap="nowrap" class="row2" align="center">
                  <asp:TextBox ID="txtGIFT_SDATE_ADD" runat="server" Text='' MaxLength="10" Font-Size="7pt" ReadOnly="false" ></asp:TextBox>
                <asp:ImageButton runat="server" ID="CalenderImageSDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                  </td>
                   <td width="8%" nowrap="nowrap" class="row2" align="center">
                   <asp:TextBox ID="txtGIFT_EDATE_ADD" runat="server" Text='' MaxLength="10" Font-Size="7pt" ReadOnly="false" ></asp:TextBox>
                   <asp:ImageButton runat="server" ID="CalenderImageEDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                   </td>
                 <td width="8%" nowrap="nowrap" class="row2" align="center"><span class="gensmall"> 
                 <asp:Button id="submitbut" CommandName="ADD" CssClass="button" 
                         CommandArgument="ADD" Text="ADD" runat=server onclick="submitbut_Click" />
                    <b></b></span></td>
                   <td width="5%" nowrap="nowrap" class="row2" align="center"><span class="gensmall"></span></td>
                  <td width="5%" nowrap="nowrap" class="row2" align="center"><span class="gensmall"></span></td>
                </tr>


                
                
              <tr> 
                <td class="row3" colspan="9">&nbsp;</td>
              </tr>
              
<EW:RepeaterEx ID="GiftBasket_RP" runat="Server" onitemcommand="GiftBasket_ItemCommand"  onitemdatabound="GiftBasket_ItemDataBound"  >

<ItemTemplate>
<tr>
<td width="3%" nowrap="nowrap" class="row2"><asp:Label ID="GiftNum" runat="server"></asp:Label><asp:Label ID="txtmid" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "mid")%>' Visible=false></asp:Label></td>
<td width="8%" nowrap="nowrap" class="row2" align="center"><asp:TextBox ID="txtGIFT_DESC" Text='<%# DataBinder.Eval(Container.DataItem, "gift_desc")%>' runat="server" Visible="true" Width="100%"></asp:TextBox></td>
<td width="8%" nowrap="nowrap" class="row2" align="center"><asp:TextBox ID="txtGIFT_CODE" Text='<%# DataBinder.Eval(Container.DataItem, "gift_code")%>' runat="server" Visible="true" Width="100%"></asp:TextBox></td>
<td width="8%" nowrap="nowrap" class="row2" align="center"><asp:TextBox ID="txtGIFT_GP" Text='<%# DataBinder.Eval(Container.DataItem, "gift_gp")%>' runat="server" Visible="true" Width="100%"></asp:TextBox></td>
<td width="8%" nowrap="nowrap" class="row2" align="center"><asp:TextBox ID="txtSDATE" Text='<%# DataBinder.Eval(Container.DataItem, "sdate")%>' runat="server" Visible="true" MaxLength="10" Width="100%"></asp:TextBox></td>
<td width="8%" nowrap="nowrap" class="row2" align="center"><asp:TextBox ID="txtEDATE" Text='<%# DataBinder.Eval(Container.DataItem, "edate")%>' runat="server" Visible="true" MaxLength="10" Width="100%"></asp:TextBox></td>
<td width="8%" nowrap="nowrap" class="row2" align="center"><asp:Button ID="rwl_planbtn" runat="server" Text="Modify" CommandArgument="Modify" CssClass="button" CommandName="Modify" OnClientClick="return confirm('Are you sure you want to Save?');" /></td>
<td width="8%" nowrap="nowrap" class="row2" align="center"><asp:LinkButton ID="rwl_planlink" CommandName="Delete" CommandArgument="Delete" runat=server Text="x" OnClientClick="return confirm('Are you sure you want to Delete?');"></asp:LinkButton></td>
<td width="5%" nowrap="nowrap" class="row2" align="center"><span class="gensmall"></span></td>
</tr>
</ItemTemplate>
</EW:RepeaterEx>


              
              
              <tr> 
                <td class="cat" colspan="9">&nbsp;</td>
              </tr>
            </table>
            </div>
            </form>
            
            
            
            
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
