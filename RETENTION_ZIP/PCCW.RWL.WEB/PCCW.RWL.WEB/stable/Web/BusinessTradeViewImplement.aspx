<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BusinessTradeViewImplement.aspx.cs" Inherits="BusinessTradeViewImplement" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    

<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<meta http-equiv="Content-Style-Type" content="text/css" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<script type="text/javascript">
<!--
function close_win(){
//	return window.location="/cccl/cccl_main.aspx";
	return top.location="~/Logout.aspx"
}


function SelectAllCheckboxes(Chk) {
    $("#tradefield_tbl input[id*='trade_del']:checkbox").attr('checked', Chk.checked);
}

//-->
</script>
</head>
<body>
    <form id="form1" runat="server" action="" method="post" name="form1">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>   
    <asp:ScriptManager ID="AddWebLogScriptManager" runat="server"></asp:ScriptManager>
            <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline" id="tradefield_tbl">
              <tr> 
                <th height="28" colspan="50"><span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></th>
              </tr>
              <tr> 
                  <td height="27" colspan="50" class="row2"> <span class="gensmall">
                    <input name="submit22" type="button" class="button" value="BACK TO SEARCH" onclick="location.href='BusinessTradeView.aspx'" style="font-size:7pt" />
                    </span> &nbsp;&nbsp; <br>
                    <br>
                    <span class="explaintitle">
                    <asp:Button Text="Delete Selected" ID="TradeDelActionButton" CssClass="button"  runat="server" onclick="TradeDelActionButton_Click" />
                    <user:AttachmentHandlerJs ID="AttachmentControl" runat="server" />
                    <input id="ExportExcelBut" onclick="AttachmentExport('Handler','BusinessTradeView')" class="mainoption" value="Export Excel" type="button" />
                    <br>
                    <br>
                    </span>
                    <span class="gensmall"> New End Date: 
                    <asp:TextBox ID="edate" Font-Size="7pt" MaxLength="10" runat="server" ReadOnly="true"></asp:TextBox>
                    <asp:ImageButton runat="server" ID="CalenderImageDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                    <span class="gensmall" style="font-size:9px">(MM/DD/YYYY)</span>
                    <span class="explaintitle"> 
                    <asp:Button Text="Update Selected" ID="TakeUpdateAction" CssClass="mainoption"  runat="server" onclick="TakeUpdateAction_Click" />
                    </span>
                    </td>
              </tr>

           <EW:RepeaterEx ID="rwl_trade_rp" runat="server"  onitemdatabound="rwl_trade_rp_ItemDataBound">
              <HeaderTemplate>
              <tr> 
                <td class="row1">&nbsp;</td>
			<td class="row1" align="center"><span class="explaintitle"><input id="chkall" onclick="SelectAllCheckboxes(this)"  type="checkbox" /> </span></td>
			
							<td class="row1"><span class="explaintitle" style="font-size:7pt">
				  <a href="BusinessTradeViewImplement.aspx?sort=issue_type&amp;order=asc"><img src="images/up02.gif" width="10" height="10"></a>
				  Issue Type
				  <a href="BusinessTradeViewImplement.aspx?sort=issue_type&amp;order=desc"><img src="images/dwn02.gif" width="10" height="10"></a>
				  </span></td>  
				  
			<td class="row1"><span class="explaintitle" style="font-size:7pt">
				  <a href="BusinessTradeViewImplement.aspx?sort=program&amp;order=asc"><img src="images/up02.gif" width="10" height="10"></a> 
                    Program
					<a href="BusinessTradeViewImplement.aspx?sort=program&amp;order=desc"><img src="images/dwn02.gif" width="10" height="10"></a> 
                    </span></td>
                 
                 <!--
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">
				  <a href="BusinessTradeViewImplement.aspx?sort=normal_rebate&amp;order=asc"><img src="images/up02.gif" width="10" height="10"></a> 
                    Normal Rebate 
					<a href="BusinessTradeViewImplement.aspx?sort=normal_rebate&amp;order=desc"><img src="images/dwn02.gif" width="10" height="10"></a>
					</span></td>
                  -->
                  
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">
				  <a href="BusinessTradeViewImplement.aspx?sort=rate_plan&amp;order=asc"><img src="images/up02.gif" width="10" height="10"></a>
				  Rate Plan
				  <a href="BusinessTradeViewImplement.aspx?sort=rate_plan&amp;order=desc"><img src="images/dwn02.gif" width="10" height="10"></a>
				  </span></td>  
				  
				  
				  <td class="row1"><span class="explaintitle" style="font-size:7pt">
				  <a href="BusinessTradeViewImplement.aspx?sort=normal_rebate_type&amp;order=asc"><img src="images/up02.gif" width="10" height="10"></a>
				  Rebate Type
				  <a href="BusinessTradeViewImplement.aspx?sort=normal_rebate_type&amp;order=desc"><img src="images/dwn02.gif" width="10" height="10"></a>
				  </span></td>

				  
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">
				  <a href="BusinessTradeViewImplement.aspx?sort=plan_fee&amp;order=asc"><img src="images/up02.gif" width="10" height="10"></a>
				  Plan Fee
				  <a href="BusinessTradeViewImplement.aspx?sort=plan_fee&amp;order=desc"><img src="images/dwn02.gif" width="10" height="10"></a>
				  </span></td>  
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">
				  <a href="BusinessTradeViewImplement.aspx?sort=con_per&amp;order=asc"><img src="images/up02.gif" width="10" height="10"></a>
				  Contract Period 
				  <a href="BusinessTradeViewImplement.aspx?sort=con_per&amp;order=desc"><img src="images/dwn02.gif" width="10" height="10"></a>
				  </span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">
				  <a href="BusinessTradeViewImplement.aspx?sort=rebate&amp;order=asc"><img src="images/up02.gif" width="10" height="10"></a>
				  Reabte
				  <a href="BusinessTradeViewImplement.aspx?sort=rebate&amp;order=desc"><img src="images/dwn02.gif" width="10" height="10"></a>
				  </span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">
				  <a href="BusinessTradeViewImplement.aspx?sort=free_mon&amp;order=asc"><img src="images/up02.gif" width="10" height="10"></a>
				  Free Monthly Fee
				  <a href="BusinessTradeViewImplement.aspx?sort=free_mon&amp;order=desc"><img src="images/dwn02.gif" width="10" height="10"></a>
					</span></td>  
					
	
					
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">
				  <a href="BusinessTradeViewImplement.aspx?sort=hs_model&amp;order=asc"><img src="images/up02.gif" width="10" height="10"></a>
				  Handset/Premium
				  <a href="BusinessTradeViewImplement.aspx?sort=hs_model&amp;order=desc"><img src="images/dwn02.gif" width="10" height="10"></a>
				  </span></td>  
				  
				  <td class="row1"><span class="explaintitle" style="font-size:7pt">
				  <a href="BusinessTradeViewImplement.aspx?sort=permium_2&amp;order=asc"><img src="images/up02.gif" width="10" height="10"></a>
				  Premium 2
				  <a href="BusinessTradeViewImplement.aspx?sort=premium_2&amp;order=desc"><img src="images/dwn02.gif" width="10" height="10"></a>
				  </span></td>
				  
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">
				  <a href="BusinessTradeViewImplement.aspx?sort=trade_field&amp;order=asc"><img src="images/up02.gif" width="10" height="10"></a>
				  Trade Field
				  <a href="BusinessTradeViewImplement.aspx?sort=trade_field&amp;order=desc"><img src="images/dwn02.gif" width="10" height="10"></a>
				  </span></td>
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">
				  <a href="BusinessTradeViewImplement.aspx?sort=bundle_name&amp;order=asc"><img src="images/up02.gif" width="10" height="10"></a>
				  Bundle Name
					<a href="BusinessTradeViewImplement.aspx?sort=bundle_name&amp;order=desc"><img src="images/dwn02.gif" width="10" height="10"></a>
					</span></td>  
                  
                  <!--
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">
				  <a href="BusinessTradeViewImplement.aspx?sort=cancel_renew&amp;order=asc"><img src="images/up02.gif" width="10" height="10"></a>
				  Cancel Auto Renewal
					<a href="BusinessTradeViewImplement.aspx?sort=cancel_renew&amp;order=desc"><img src="images/dwn02.gif" width="10" height="10"></a>
					</span></td>  
					-->
					
                  <td class="row1"><span class="explaintitle" style="font-size:7pt"> 
                    <a href="BusinessTradeViewImplement.aspx?sort=channel&amp;order=asc"><img src="images/up02.gif" width="10" height="10"></a> 
                    Channel<a href="BusinessTradeViewImplement.aspx?sort=channel&amp;order=desc"><img src="images/dwn02.gif" width="10" height="10"></a> 
                    </span></td>  
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">
				  <a href="BusinessTradeViewImplement.aspx?sort=sdate&amp;order=asc"><img src="images/up02.gif" width="10" height="10"></a>
				  Start Date
					<a href="BusinessTradeViewImplement.aspx?sort=sdate&amp;order=desc"><img src="images/dwn02.gif" width="10" height="10"></a>
					</span></td>  
                  <td class="row1"><span class="explaintitle" style="font-size:7pt">
				  <a href="BusinessTradeViewImplement.aspx?sort=edate&amp;order=asc"><img src="images/up02.gif" width="10" height="10"></a>
				  End Date
				 <a href="BusinessTradeViewImplement.aspx?sort=edate&amp;order=desc"> <img src="images/dwn02.gif" width="10" height="10"></a>
					</span></td>
					
					<td class="row1"><span class="explaintitle" style="font-size:7pt">
				  <a href="BusinessTradeViewImplement.aspx?sort=po_date&amp;order=asc"><img src="images/up02.gif" width="10" height="10"></a>
				  Po Date
				 <a href="BusinessTradeViewImplement.aspx?sort=po_date&amp;order=desc"> <img src="images/dwn02.gif" width="10" height="10"></a>
					</span></td>
					
					<td class="row1"><span class="explaintitle" style="font-size:7pt">
				  <a href="BusinessTradeViewImplement.aspx?sort=remarks&amp;order=asc"><img src="images/up02.gif" width="10" height="10"></a>
				  Remarks
				 <a href="BusinessTradeViewImplement.aspx?sort=remarks&amp;order=desc"> <img src="images/dwn02.gif" width="10" height="10"></a>
					</span></td>
					
              </tr>
              
              </HeaderTemplate>

              
                            <ItemTemplate>
              
              
              <tr> 
                <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="tradeid" runat="server"></asp:Literal></span></td>
                <td nowrap="nowrap" class="row2" align="center"><span class="gensmall" style="font-size:7pt"><asp:CheckBox ID="trade_del" Text='<%# DataBinder.Eval(Container.DataItem, "mid")%>' runat="server" value='<%# DataBinder.Eval(Container.DataItem, "mid")%>'/></span></td>
                      <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "issue_type")%></span></td>
                <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><a href="BusinessTradeViewDetail.aspx?mid=<%# DataBinder.Eval(Container.DataItem, "mid")%>"><%# DataBinder.Eval(Container.DataItem, "program")%></a></span></td>
                
                <!--
                <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="normal_rebate_type" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "normal_rebate_type")%>'></asp:Literal></span> </td>
                -->
                <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "rate_plan")%></span></td>
                <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "normal_rebate_type")%></span></td>
                <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "plan_fee")%></span></td>
                <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "con_per")%></span></td>
                <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "rebate")%></span></td>
                <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "free_mon")%></span></td>
          
                <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "hs_model")%>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <%# DataBinder.Eval(Container.DataItem, "hs_model_name")%>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <%# DataBinder.Eval(Container.DataItem, "Premium_1")%> </span></td>
                <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "premium_2")%></span></td>
                <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "trade_field")%></span></td>
                <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "bundle_name")%></span></td>
                
                <!--
                <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "cancel_renew")%></span></td>
                -->
                
                <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "channel")%></span></td>
                <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "sdate")%></span></td>
                <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "edate")%></span></td>
                <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "po_date")%></span></td>
                <td nowrap="nowrap" class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "remarks")%></span></td>
			  </tr>
              </ItemTemplate>
              

              
              </EW:RepeaterEx>

              
              <tr> 
                <td class="cat" colspan="70">&nbsp;</td>
              </tr>
            </table>
<table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; View 
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
<a name="bot" id="bot"></a></td></tr></table></td>

</tr></table>
</body>
</html>
