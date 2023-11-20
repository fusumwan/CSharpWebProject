<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HandSetViewImplement.aspx.cs" Inherits="HandSetViewImplement" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<meta http-equiv="Content-Style-Type" content="text/css" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
<script type="text/javascript">
<!--
function close_win(){
//	return window.location="/cccl/cccl_main.aspx";
	return top.location="../chk_login.asp"
}
function SelectAllCheckboxes(Chk) {
    $("#hsmodel_tbl input[id*='hs_del']:checkbox").attr('checked', Chk.checked);
}


//-->
</script>

</head>
<body>


    
    <form runat="server" action="" method="post" name="form1" id="form1">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
    <asp:ScriptManager ID="AddWebLogScriptManager" runat="server"></asp:ScriptManager>
            <table width="100%" border="0" cellpadding="3" cellspacing="1" id="hsmodel_tbl" class="forumline">
              <tr> 
                <th height="28" colspan="17"><span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></th>
              </tr>
              <tr> 
                  <td height="27" colspan="17" class="row2">
                  <span class="gensmall">
                    <input name="backtosearch" type="button" class="button" value="BACK TO SEARCH" onClick="location.href='HandSetView.aspx'" style="font-size:7pt" />
                    <asp:Button Text="Delete Selected" ID="TradeDelActionButton" CssClass="mainoption"  runat="server" onclick="TradeDelActionButton_Click" />
                    <user:AttachmentHandlerJs ID="AttachmentControl" runat="server" />
                    <input id="ExportExcelBut" onclick="AttachmentExport('Handler','HandSetMapping')" class="mainoption" value="Export Excel" type="button" />
                    <br>
                    <br>
                    <span class="gensmall"> New End Date: 
                    <asp:TextBox ID="edate" Font-Size="7pt" MaxLength="10" runat="server" ReadOnly="true"></asp:TextBox>
                    <asp:ImageButton runat="server" ID="CalenderImageDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                    <span class="gensmall" style="font-size:9px">(MM/DD/YYYY)</span>
                    <span class="explaintitle"></span><span class="gensmall"> </span>
                    <span class="explaintitle"> <asp:Button Text="Update Selected" ID="TakeUpdateAction" CssClass="mainoption"  runat="server" onclick="TakeUpdateAction_Click" /></span></td>
              </tr>
              <EW:RepeaterEx ID="hsmodel_rp" runat="server"  onitemdatabound="RepeaterID_ItemDataBound">
              <HeaderTemplate>
              
              <tr> 
                <td class="row1">&nbsp;</td>

                  <td class="row1" align="center" id ="rowid" runat="server"><input id="chkall" onclick="SelectAllCheckboxes(this)"  type="checkbox" />  </td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">
				  <a href="HandSetViewImplement.aspx?sort=plan_fee&amp;order=asc"><img src="images/up02.gif" width="10" height="10"></a> 
                  Plan Fee 
 				  <a href="HandSetViewImplement.aspx?sort=plan_fee&amp;order=desc"><img src="images/dwn02.gif" width="10" height="10"></a>
					</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">
				  <a href="HandSetViewImplement.aspx?sort=normal_rebate_type&amp;order=asc"><img src="images/up02.gif" width="10" height="10"></a> 
                    Normal Rebate Type
					<a href="HandSetViewImplement.aspx?sort=normal_rebate_type&amp;order=desc"><img src="images/dwn02.gif" width="10" height="10"></a>
					</span></td>
					
					<td class="row1"><span class="explaintitle" style="font-size:7pt">
				  <a href="HandSetViewImplement.aspx?sort=offer_type_id&amp;order=asc"><img src="images/up02.gif" width="10" height="10"></a> 
                    Handset Offer Type
					<a href="HandSetViewImplement.aspx?sort=offer_type_id&amp;order=desc"><img src="images/dwn02.gif" width="10" height="10"></a>
					</span></td>
					
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">
				  <a href="HandSetViewImplement.aspx?sort=rebate_gp&amp;order=asc"><img src="images/up02.gif" width="10" height="10"></a> 
                    Offer Group 
					<a href="HandSetViewImplement.aspx?sort=rebate_gp&amp;order=desc"><img src="images/dwn02.gif" width="10" height="10"></a>
					</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">
				  <a href="HandSetViewImplement.aspx?sort=con_per&amp;order=asc"><img src="images/up02.gif" width="10" height="10"></a> 
                    Contract Period 
					<a href="HandSetViewImplement.aspx?sort=con_per&amp;order=desc"><img src="images/dwn02.gif" width="10" height="10"></a>
					</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">
				  <a href="HandSetViewImplement.aspx?sort=hs_model&amp;order=asc"><img src="images/up02.gif" width="10" height="10"></a> 
                    Handset Model
					<a href="HandSetViewImplement.aspx?sort=hs_model&amp;order=desc"><img src="images/dwn02.gif" width="10" height="10"></a>
					</span></td>

                  <td class="row1"><span class="explaintitle" style="font-size:7pt">
				  <a href="HandSetViewImplement.aspx?sort=premium&amp;order=asc"><img src="images/up02.gif" width="10" height="10"> </a>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Premium 
					<a href="HandSetViewImplement.aspx?sort=premium&amp;order=desc"><img src="images/dwn02.gif" width="10" height="10"></a> 
                    </span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">
				  <a href="HandSetViewImplement.aspx?sort=rebate_amount&amp;order=asc"><img src="images/up02.gif" width="10" height="10"></a> 
                    Rebate Amount 
					<a href="HandSetViewImplement.aspx?sort=rebate_amount&amp;order=desc"><img src="images/dwn02.gif" width="10" height="10"></a>
					</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">
				  <a href="HandSetViewImplement.aspx?sort=r_offer&amp;order=asc"><img src="images/up02.gif" width="10" height="10"></a> 
                    Retention Offer
					<a href="HandSetViewImplement.aspx?sort=r_offer&amp;order=desc"><img src="images/dwn02.gif" width="10" height="10"></a>
					</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">
				  <a href="HandSetViewImplement.aspx?sort=extra_rebate_amount&amp;order=asc"><img src="images/up02.gif" width="10" height="10"></a> 
                    Extra Rebate Amount
					<a href="HandSetViewImplement.aspx?sort=extra_rebate_amount&amp;order=desc"> 
                    <img src="images/dwn02.gif" width="10" height="10"></a>
					</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">
				  <a href="HandSetViewImplement.aspx?sort=extra_rebate&amp;order=asc"><img src="images/up02.gif" width="10" height="10"></a> 
                    Extra Rebate 
					<a href="HandSetViewImplement.aspx?sort=extra_rebate&amp;order=desc"><img src="images/dwn02.gif" width="10" height="10"></a>
					</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt"> 
                    <a href="HandSetViewImplement.aspx?sort=amount&amp;order=asc"><img src="images/up02.gif" width="10" height="10"> 
                    </a>Amount 
					<a href="HandSetViewImplement.aspx?sort=amount&amp;order=desc"><img src="images/dwn02.gif" width="10" height="10"></a>
					</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">
				  <a href="HandSetViewImplement.aspx?sort=payment&amp;order=asc"><img src="images/up02.gif" width="10" height="10"></a> 
                    Payment Method 
					<a href="HandSetViewImplement.aspx?sort=payment&amp;order=desc"><img src="images/dwn02.gif" width="10" height="10"></a>
					</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">
				  <a href="HandSetViewImplement.aspx?sort=sdate&amp;order=asc"><img src="images/up02.gif" width="10" height="10"></a> 
                    Start Date 
					<a href="HandSetViewImplement.aspx?sort=sdate&amp;order=desc"><img src="images/dwn02.gif" width="10" height="10"></a>
					</span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">
				  <a href="HandSetViewImplement.aspx?sort=edate&amp;order=asc"><img src="images/up02.gif" width="10" height="10"></a> 
                    End Date 
					<a href="HandSetViewImplement.aspx?sort=edate&amp;order=desc"><img src="images/dwn02.gif" width="10" height="10"></a>
                    </span></td>
              </tr>
</HeaderTemplate>
<ItemTemplate>
              <tr> 
                <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="hsviewid" runat="server"></asp:Literal></span></td>
                 <td nowrap class="row2" align="center"><input type="checkbox" ID="hs_del" name="hs_del" value='<%# DataBinder.Eval(Container.DataItem, "mid")%>'  runat="server" /><%# DataBinder.Eval(Container.DataItem, "mid")%></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><a href="HandSetViewSaveDuplicate.aspx?mid=<%# DataBinder.Eval(Container.DataItem, "mid")%>"><%# DataBinder.Eval(Container.DataItem, "plan_fee")%></a></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="normal_rebate_type" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "normal_rebate_type")%>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="offer_type_id" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "offer_type_id")%>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="rebate_gp" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "rebate_gp")%>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="con_per" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "con_per")%>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="hs_model" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "hs_model")%>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="premium" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "premium")%>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="rebate_amount" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "rebate_amount")%>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="r_offer" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "r_offer")%>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="extra_rebate_amount" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "extra_rebate_amount")%>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt">$<asp:Literal ID="extra_rebate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "extra_rebate")%>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt">$<asp:Literal ID="amount" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "amount")%>'></asp:Literal></span></td>
                  <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="payment" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "payment")%>'></asp:Literal></span></td>
                 <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="sdate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "sdate")%>'></asp:Literal></span></td>
                <td nowrap class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="edate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "edate")%>'></asp:Literal></span></td>
              </tr>
              </ItemTemplate>
              </EW:RepeaterEx>

              <tr> 
                <td class="cat" colspan="17">&nbsp;</td>
              </tr>
            </table>
 <table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="MobileRetentionMain.aspx">Main Page View 
<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
</table>       
<cc1:CalendarExtender runat="server" 
        ID="CalendarDateFormat"
        TargetControlID="edate"
        Format="MM/dd/yyyy"
        PopupButtonID="CalenderImageDate" /> 
    </div>
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
