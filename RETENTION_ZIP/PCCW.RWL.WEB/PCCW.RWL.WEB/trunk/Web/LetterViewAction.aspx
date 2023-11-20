<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LetterViewAction.aspx.cs" Inherits="LetterViewAction" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
<title>3G Retention - Web Log</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
<script language="JavaScript" src="../Resources/Scripts/script.js" type="text/javascript"></script>
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
</head>
<body style="background-color:#ffffff" >
    <form id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
              <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  
                <th height="28" colspan="7" ><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %> - Redemption letters Customer listt</th>
                </tr>
                
                <EW:RepeaterEx ID="EventLetterDetail_rp" runat="server">
                <HeaderTemplate>
				<tr>
					<td class="row2"><span class="explaintitle">Letter Sent out Date</span></td>
					<td class="row2"><span class="explaintitle">MRT</span></td>
					<td class="row2"><span class="explaintitle">Account No</span></td>
					<td class="row2"><span class="explaintitle">HKID</span></td>
					<td class="row2"><span class="explaintitle">Customer Name</span></td>
					<td class="row2"><span class="explaintitle">Premium</span></td>
					<td class="row2"><span class="explaintitle">Remarks</span></td>
				</tr>
				</HeaderTemplate>
                <ItemTemplate>
	                <tr>
		                <td class="row1"><span class="gensmall"><%# DataBinder.Eval(Container.DataItem, "lett_sent_date")%></span></td>
		                <td class="row1"><span class="gensmall"><%# DataBinder.Eval(Container.DataItem, "mob_num")%></span></td>
		                <td class="row1"><span class="gensmall"><%# DataBinder.Eval(Container.DataItem, "accnt_cd")%></span></td>
		                <td class="row1"><span class="gensmall"><%# DataBinder.Eval(Container.DataItem, "doc_id")%></span></td>
		                <td class="row1"><span class="gensmall"><%# DataBinder.Eval(Container.DataItem, "name")%></span></td>
		                <td class="row1"><span class="gensmall"><%# DataBinder.Eval(Container.DataItem, "prem_desc")%></span></td>
		                <td class="row1"><span class="gensmall"><%# DataBinder.Eval(Container.DataItem, "Remarks")%></span></td>
	                </tr>
	                </ItemTemplate>
                </EW:RepeaterEx>

                <tr> 
                  <td class="cat" colspan="10" >&nbsp;</td>
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
    </div>
    </form>
</body>
</html>
