<%@ Page Language="C#" AutoEventWireup="true" CodeFile="K610iSpecial.aspx.cs" Inherits="K610iSpecial" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Import Namespace="PCCW.RWL.CORE" %>
<%@ Import Namespace="NEURON.ENTITY.FRAMEWORK" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
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
<script type="text/javascript">
<!--
function close_win(){
//	return window.location="/cccl/cccl_main.aspx";
	return top.location="../chk_login.asp"
}
//-->
</script>
</head>
<body>

    <form id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
         <EW:RepeaterEx ID="k610i_rp" runat="server" 
             onitemdatabound="k610i_rp_ItemDataBound">
         <HeaderTemplate>
          <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
              <tr> 
                <th colspan="100"><span class="explaintitle" style="font-size:8pt">Special Tracking</span></th>
              </tr>
              <tr> 
                <td height="0" class="row1"><span class="explaintitle" style="font-size:7pt">Order 
                    ID</span></td>
                <td height="0" class="row1"><span class="explaintitle" style="font-size:7pt">EDF No </span></td>
                <td height="0" class="row1"><span class="explaintitle" style="font-size:7pt">Actual 
                    Delivery Date</span></td>
                <td height="0" class="row1"><span class="explaintitle" style="font-size:7pt">No of 
                    Modification</span></td>
              </tr>
         </HeaderTemplate>
         <ItemTemplate>
         <tr> 
                <td class="row2"><span class="gensmall"><a href="SearchRetentionOrderViewDetail.aspx?order_id=<%# Func.IDAdd100000(Convert.ToInt32(DataBinder.Eval(Container.DataItem, "order_id")))  %>"><%# Func.IDAdd100000(Convert.ToInt32(DataBinder.Eval(Container.DataItem, "order_id")))  %></a></span></td>
                <td class="row2"><span class="gensmall"><asp:Literal ID="edf_no" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "edf_no")%>'></asp:Literal></span></td>
                <td class="row2"><span class="gensmall"><asp:Literal ID="actual_del_date" runat="server" ></asp:Literal></span></td>
                <td class="row2"><span class="gensmall"><asp:Literal ID="cnt" runat="server" ></asp:Literal></span></td>
         </tr>
         </ItemTemplate>
         <FooterTemplate>
          <tr><td class="cat" colspan="100">&nbsp;</td></tr>
          </table>
         </FooterTemplate>
         </EW:RepeaterEx>

              
             

    </div>
    </form>
    
    
<table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; View 
<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
</table>       

            <div align="center" class="gensmall">&nbsp;</div>
<a name="bot" id="bot"></a>
</body>
</html>
