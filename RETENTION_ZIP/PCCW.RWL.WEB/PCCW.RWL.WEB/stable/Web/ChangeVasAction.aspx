<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChangeVasAction.aspx.cs" Inherits="ChangeVasAction" %>
<%@ Register TagName="RWLMenu2" TagPrefix="RWlMenu2" Src="~/UI/RWLControlMenu.ascx" %>
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
<style>
.highlightrow{background:#FFFFbb}
.disablerow{background:#DDDDDD}
input{font:7pt Verdana,Arial,Helvetica,sans-serif}
select{background:#ffffff;font:7pt Verdana,Arial,Helvetica,sans-serif}
.explaintitle{font-size:7pt;font-weight:bold;color:#5c81b1}
</style>
</head>
<body style="background-color:#ffffff">

    <form action="CustomerAccountAddAction.aspx" method="post" name="newform" id="form1"  runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
                  <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <th height="28" colspan="4">&nbsp;<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></th>
                </tr>
                <tr> 
                  <td height="23" colspan="4" class="row2"><span class="explaintitle"> 
                    </span><span class="gensmall"> </span></td>
                </tr>
                <tr> 
                  <td width="21%" height="0" class="row2"><span class="explaintitle" >MRT 
                    No 登記流動電話號碼</span></td>
                  <td width="79%" height="0" colspan="3" class="row1"> <span class="gensmall" style="font-size:7pt"><asp:Literal ID="mrt_no" runat="server"></asp:Literal></span> 
                  </td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" >Program 
                    計劃 </span></td>
                  <td height="0" class="row1" colspan="3"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="program" runat="server"></asp:Literal></span> 
                  </td>
                </tr>
                <tr> 
                  <td height="0" class="row2" ><span class="explaintitle" >Rate 
                    Plan</span></td>
                  <td class="row1"  colspan="3"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="rate_plan" runat="server"></asp:Literal></span> 
                    <span class="gensmall" style="font-size:7pt"> - 
                    <asp:Literal ID="normal_rebate_type" runat="server"></asp:Literal>
                    </span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" >Contract 
                    Period 合約期</span></td>
                  <td class="row1" colspan="3"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="con_per" runat="server"></asp:Literal></span> 
                  </td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" >Rebate</span></td>
                  <td class="row1" colspan="3"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="rebate" runat="server"></asp:Literal></span> 
                  </td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" >Free 
                    Monthly Fee 免費月份費用<br />
                    </span></td>
                  <td class="row1" colspan="3"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="free_mon" runat="server"></asp:Literal></span> 
                  </td>
                </tr>
                <asp:PlaceHolder ID="vas_placeholder" runat="server"></asp:PlaceHolder>
                <tr> 
                  <td class="cat" colspan="4">&nbsp;</td>
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
