<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TotalAllMappingReport.aspx.cs" Inherits="TotalAllMappingReport" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<script type="text/javascript">


</script>
</head>

         
<body style="background-color:#ffffff">

    <form id="form1" action="ViewArpuModuleProcess.aspx" method="post" name="newform" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
              <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <th height="28" colspan="4">Download 
                  All Mapping Table</th>
                </tr>
                <tr> 
                  <td height="23" class="row2"></td>
                </tr>
                <tr> 
                  <td height="25" class="row1" align="center"><span class="explaintitle">
                  <asp:LinkButton ID="BusinessTradeLink" PostBackUrl="~/Web/MappingDownloadMenu.aspx?table_name=BusinessTrade" runat="server">Trade Field Mapping</asp:LinkButton>
                  </span></td>
                </tr>
                <tr> 
                  <td height="25" class="row1" align="center"><span class="explaintitle"><a href="MappingDownloadMenu.aspx?<%=WebFunc.qsTable_Name %>=HandSetOfferedBasket">Handset Rebate Mapping </a></span></td>
                </tr>
                <tr> 
                  <td height="25" class="row1" align="center"><span class="explaintitle"><a href="MappingDownloadMenu.aspx?<%=WebFunc.qsTable_Name %>=ProductItemCode">Handset  / Premium Item Code Mapping </a></span></td>
                </tr>
                <tr> 
                  <td height="25" class="row1" align="center"><span class="explaintitle"><a href="MappingDownloadMenu.aspx?<%=WebFunc.qsTable_Name %>=GiftBasket">Free 
                    Gift Mapping </a></span></td>
                </tr>
                <tr> 
                  <td height="25" class="row1" align="center"><span class="explaintitle"><a href="MappingDownloadMenu.aspx?<%=WebFunc.qsTable_Name %>=Accessory">Accessory 
                    Mapping </a></span></td>
                </tr>
                <tr> 
                  <td height="25" class="row1" align="center"><span class="explaintitle"><a href="MappingDownloadMenu.aspx?<%=WebFunc.qsTable_Name %>=RetentionPlan">Plan 
                    Code & Plan Fee Mapping </a></span></td>
                </tr>
                <tr> 
                  <td height="25" class="row1" align="center"><span class="explaintitle"><a href="MappingDownloadMenu.aspx?<%=WebFunc.qsTable_Name %>=RebateGroup">Handset 
                    Program Group Mapping </a></span></td>
                </tr>
                <tr> 
                  <td height="25" class="row1" align="center"><span class="explaintitle"><a href="MappingDownloadMenu.aspx?<%=WebFunc.qsTable_Name %>=SpecialPremium">Special 
                    Premium Mapping </a></span></td>
                </tr>
                <tr> 
                  <td height="25" class="row1" align="center"><span class="explaintitle"><a href="MappingDownloadMenu.aspx?<%=WebFunc.qsTable_Name %>=BankCode">BankCode 
                    Mapping </a></span></td>
                </tr>
                <tr> 
                  <td height="25" class="row1" align="center"><span class="explaintitle"><a href="MappingDownloadMenu.aspx?<%=WebFunc.qsTable_Name %>=MobileOrderMonthlyFee">Free 
                    Monthly Fee Mapping</a></span></td>
                </tr>
                 <tr> 
                  <td height="25" class="row1" align="center"><span class="explaintitle"><a href="MappingDownloadMenu.aspx?<%=WebFunc.qsTable_Name %>=TariffFeeSchedule">Existing 
                    Customer Type &amp; Original Tariff Fee Mapping</a></span></td>
                </tr>
                <tr> 
                  <td height="25" class="row1" align="center"><span class="explaintitle"><a href="MappingDownloadMenu.aspx?<%=WebFunc.qsTable_Name %>=MobileOrderFallout">PY 
                    Operations Fallout Reason</a></span></td>
                </tr>
                 <tr> 
                  <td height="25" class="row1" align="center"><span class="explaintitle"><a href="MappingDownloadMenu.aspx?<%=WebFunc.qsTable_Name %>=SuspendEventDetail">Suspend Reason</a></span></td>
                </tr>
                 <tr> 
                  <td height="25" class="row1" align="center"><span class="explaintitle"><a href="MappingDownloadMenu.aspx?<%=WebFunc.qsTable_Name %>=BusinessVas">VAS</a></span></td>
                </tr>
                 <tr> 
                  <td height="25" class="row1" align="center"><span class="explaintitle"><a href="MappingDownloadMenu.aspx?<%=WebFunc.qsTable_Name %>=BusinessVasDescription">VAS 
                    Fee Description</a></span></td>
                </tr>
                <tr> 
                  <td height="25" class="row1" align="center"><span class="explaintitle"><a href="MappingDownloadMenu.aspx?<%=WebFunc.qsTable_Name %>=AutoSelectionProperty">Tier Table</a></span></td>
                </tr>
                <tr> 
                  <td height="25" class="row1" align="center"><span class="explaintitle"><a href="MappingDownloadMenu.aspx?<%=WebFunc.qsTable_Name %>=BundleMapping">BundleMapping Table</a></span></td>
                </tr>
               <tr> 
                  <td class="cat" colspan="2">&nbsp;</td>
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

    
</body>
</html>
