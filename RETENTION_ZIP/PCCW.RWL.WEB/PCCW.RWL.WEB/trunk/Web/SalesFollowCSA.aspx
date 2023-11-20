<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SalesFollowCSA.aspx.cs" Inherits="SalesFollowCSA" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Import Namespace="PCCW.RWL.CORE" %>
<%@ Import Namespace="NEURON.ENTITY.FRAMEWORK" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
<script type="text/javascript">
<!--
function close_win(){
//	return window.location="/cccl/cccl_main.aspx";
	return top.location="../chk_login.asp"
}
//-->
</script>
<style type="text/css">
<!--
.row_red {background:#FFCC99}
.row_yellow {background:#FFFFbb}
-->
</style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
    <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
            <tr> 
                <th height="29" colspan="20">Followup Case (Fallout)</th>
            </tr>
            <tr>
              <td height="0" class="row2" colspan="20">&nbsp; </td>
            </tr>
            <tr>
                <td height="0" class="row3" colspan="20"><span class="explaintitle">Follow up By Sales</span></td>
            </tr>
            <tr>
                <td width="5%" height="0" class="row1">&nbsp;</td>
                <td width="8%" height="0" class="row1"><span class="explaintitle">Record ID </span></td>
                <td width="12%" height="37" class="row1"><span class="explaintitle">EDF No</span></td>
                <td width="12%" height="0" class="row1"><span class="explaintitle">Salesman ID</span></td>
                <td width="21%" height="0" class="row1"><span class="explaintitle">Salesman Code</span></td>
                <td width="21%" height="0" class="row1"><span class="explaintitle">Salesman Name</span></td>
                <td width="15%" height="0" class="row1"><span class="explaintitle">Mobile No</span></td>
                <td width="14%" height="0" class="row1"><span class="explaintitle">Fallout Date </span></td>
                <td width="14%" height="0" class="row1"><span class="explaintitle">Fallout Reason </span></td>
                <td width="14%" height="0" class="row1"><span class="explaintitle">Remark </span></td>
                <td width="14%" height="0" class="row1"><span class="explaintitle">Contract Effective Date</span></td>
            </tr>
           <EW:RepeaterEx ID="FOLLOW_SALES_RP" runat="server" 
                onitemdatabound="FOLLOW_SALES_RP_ItemDataBound">
           <ItemTemplate>
           <tr>
              <td height="0" class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="FONum" runat="server"></asp:Literal></span></td>
              <td height="0" class="row2"><span class="gensmall" style="font-size:7pt"><asp:HyperLink ID="Order_id_link" runat="server" NavigateUrl='<%#"SearchRetentionOrderViewDetail.aspx?order_id="+Func.IDAdd100000(Convert.ToInt32(DataBinder.Eval(Container.DataItem, "order_id")))%>'><%# Func.IDAdd100000(Convert.ToInt32(DataBinder.Eval(Container.DataItem, "order_id")))%></asp:HyperLink></span></td>
              <td height="0" class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "edf_no")%></span></td>
              <td height="0" class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "staff_no")%></span></td>
              <td height="0" class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "salesmancode")%></span></td>
              <td height="0" class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "staff_name")%></span></td>
              <td height="0" class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "mrt_no")%></span></td>
              <td height="0" class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "admin_date")%></span></td>
              <td height="0" class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "fallout_reason")%></span></td>
              <td height="0" class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "fallout_remark")%></span></td>
              <td height="0" class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "con_eff_date")%></span></td>
           </tr>
           </ItemTemplate>
           </EW:RepeaterEx>
             <tr> 
                <td height="0" class="row3" colspan="20"><span class="explaintitle">Follow Up By F&S PY Mobile Operation Team</span></td>
            </tr>
            <tr> 
              <td width="5%" height="0" class="row1">&nbsp;</td>
                <td width="8%" height="0" class="row1"><span class="explaintitle">Record ID </span></td>
                <td width="12%" height="37" class="row1"><span class="explaintitle">EDF No</span></td>
                <td width="12%" height="0" class="row1"><span class="explaintitle">Salesman ID</span></td>
                <td width="21%" height="0" class="row1"><span class="explaintitle">Salesman Code</span></td>
                <td width="21%" height="0" class="row1"><span class="explaintitle">Salesman Name</span></td>
                <td width="15%" height="0" class="row1"><span class="explaintitle">Mobile No</span></td>
                <td width="14%" height="0" class="row1"><span class="explaintitle">Fallout Date </span></td>
                <td width="14%" height="0" class="row1"><span class="explaintitle">Fallout Reason </span></td>
                <td width="14%" height="0" class="row1"><span class="explaintitle">Fallout Remark </span></td>
                <td width="14%" height="0" class="row1"><span class="explaintitle">Contract Effective Date</span></td>
            </tr>
            
            <EW:RepeaterEx ID="FoManagementLLOW_MOBILE_RP" runat="server" 
                onitemdatabound="FoManagementLLOW_MOBILE_RP_ItemDataBound">
           <ItemTemplate>
           <tr>
              <td height="0" class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="FONum" runat="server"></asp:Literal></span></td>
              <td height="0" class="row2"><span class="gensmall" style="font-size:7pt"><asp:HyperLink ID="Order_id_link" runat="server" NavigateUrl='<%#"SearchRetentionOrderViewDetail.aspx?order_id="+Func.IDAdd100000(Convert.ToInt32(DataBinder.Eval(Container.DataItem, "order_id")))%>'><%# Func.IDAdd100000(Convert.ToInt32(DataBinder.Eval(Container.DataItem, "order_id")))%></asp:HyperLink></span></td>
              <td height="0" class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "edf_no")%></span></td>
              <td height="0" class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "staff_no")%></span></td>
              <td height="0" class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "salesmancode")%></span></td>
              <td height="0" class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "staff_name")%></span></td>
              <td height="0" class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "mrt_no")%></span></td>
              <td height="0" class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "admin_date")%></span></td>
              <td height="0" class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "fallout_reason")%></span></td>
              <td height="0" class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "fallout_remark")%></span></td>
              <td height="0" class="row2"><span class="gensmall" style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "con_eff_date")%></span></td>
           </tr>
           </ItemTemplate>
           </EW:RepeaterEx>
           <tr> 
              <td class="cat" colspan="20">&nbsp;</td>
            </tr>
          </table>

<table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; View 
<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
</table>       
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
    </div>
    </form>
</body>
</html>
