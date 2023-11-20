<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UploadRedemptionLetterImplement.aspx.cs" Inherits="UploadRedemptionLetterImplement" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>3G Retention - Web Log</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
<script language="JavaScript" src="../Resources/Scripts/script.js" type="text/javascript"></script>
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
</head>
<body>

    <form id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
    <EW:RepeaterEx ID="letter_rp" runat="server" 
            onitemdatabound="letter_rp_ItemDataBound">
    <HeaderTemplate>
                  <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  
                <th height="28" colspan="10" ><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %> - Upload Redemption letters Customer list</th>
                </tr>
	<tr>
		<td class="row2"><span class="explaintitle">lett_sent_date</span></td>
		<td class="row2"><span class="explaintitle">mob_num</span></td>
		<td class="row2"><span class="explaintitle">accnt_cd</span></td>
		<td class="row2"><span class="explaintitle">doc_id</span></td>
		<td class="row2"><span class="explaintitle">name</span></td>
		<td class="row2"><span class="explaintitle">prem_desc</span></td>
		<td class="row2"><span class="explaintitle">Remarks</span></td>
	</tr>
    </HeaderTemplate>
    <ItemTemplate>
    	<tr>
		<td class="row1"><span class="gensmall"><asp:Literal ID="lett_sent_date" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"lett_sent_date")%>'></asp:Literal></span></td>
		<td class="row1"><span class="gensmall"><asp:Literal ID="mob_num" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "mob_num")%>'></asp:Literal></span></td>
		<td class="row1"><span class="gensmall"><asp:Literal ID="accnt_cd" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "accnt_cd")%>'></asp:Literal></span></td>
		<td class="row1"><span class="gensmall"><asp:Literal ID="doc_id" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "doc_id")%>'></asp:Literal></span></td>
		<td class="row1"><span class="gensmall"><asp:Literal ID="name" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "name")%>'></asp:Literal></span></td>
		<td class="row1"><span class="gensmall"><asp:Literal ID="prem_desc" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "prem_desc")%>'></asp:Literal></span></td>
		<td class="row1"><span class="gensmall"><asp:Literal ID="Remarks" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "Remarks")%>'></asp:Literal></span></td>
	</tr>
    </ItemTemplate>
    <FooterTemplate>
                    <tr> 
                  <td class="cat" colspan="10" >&nbsp;</td>
                </tr>
              </table>
    </FooterTemplate>
    </EW:RepeaterEx>
 <table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; View 
<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
</table>       
    </div>
    </form>
</body>
</html>
