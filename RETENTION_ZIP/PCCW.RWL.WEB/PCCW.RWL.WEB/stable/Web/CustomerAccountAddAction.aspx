<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerAccountAddAction.aspx.cs" Inherits="CustomerAccountAddAction" %>
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
</head>
<body>

    <form action="" method="post" name="form1" id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
                  <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <th height="28" colspan="4">&nbsp;<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span> (Order 
                    ID: <asp:Literal ID="order_id" runat="server"></asp:Literal>)</th>
                </tr>
                <tr> 
                  <td height="23" colspan="4" class="row2"><span class="explaintitle"> 
                    </span><span class="gensmall"> </span></td>
                </tr>
                <tr> 
                  <td width="21%" height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Account 
                    No 戶口號碼<br>
                    </span></td>
                  <td width="79%" height="0" class="row1"> <span class="gensmall" style="font-size:7pt"><asp:Literal ID="ac_no" runat="server"></asp:Literal></span> 
                  </td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">MRT 
                    No 登記流動電話號碼<br>
                    </span></td>
                  <td height="0" class="row1"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="mrt_no" runat="server"></asp:Literal></span> 
                  </td>
                </tr>
                <tr> 
                  <td width="23%" height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Change 
                    Customer Details<br>
                    </span></td>
                  <td width="77%" height="0" colspan="3" class="row1"> <span class="gensmall" style="font-size:9pt"><asp:Literal ID="remarks" runat="server"></asp:Literal> </span> 
                  </td>
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
