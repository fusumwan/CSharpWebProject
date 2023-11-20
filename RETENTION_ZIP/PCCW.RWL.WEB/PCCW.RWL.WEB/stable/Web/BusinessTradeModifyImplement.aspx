<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BusinessTradeModifyImplement.aspx.cs" Inherits="BusinessTradeModifyImplement" %>
<%@ Register TagName="RWLMenu2" TagPrefix="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
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
<body style="background-color:#ffffff">

 <form action="BusinessTradeAddImplement.aspx" method="post" name="form1" id="form1"  runat="server">
 <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
              <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <th height="28" colspan="4">&nbsp;<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></th>
                </tr>
                <tr>
                  <td height="23" colspan="4" class="row2"><span class="explaintitle"> 
                    <input name="submit22" type="button" class="button" value="BACK TO SEARCH RECORD" onClick="location.href='BusinessTradeView.aspx'" style="font-size:7pt" /> </span></td>
                </tr>
                <tr>
                  <td height="25" class="row2"><span class="explaintitle" style="font-size:7pt">Program 
                    </span></td>
                  <td width="77%" height="25" class="row1"><span class="gensmall" style="font-size:7pt">
                  <asp:Literal ID="program" runat="server"></asp:Literal>
                    </span></td>
                </tr>
                <tr> 
                  <td width="23%" height="0" class="row2" ><span class="explaintitle" style="font-size:7pt">Rate 
                    Plan</span></td>
                  <td height="0" class="row1" > <span class="gensmall" style="font-size:7pt">
                  <asp:Literal ID="rate_plan" runat="server"></asp:Literal>
                  </span> 
                  </td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Contract 
                    Period </span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:Literal ID="con_per" runat="server"></asp:Literal>
                  </span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Plan 
                    Fee</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:Literal ID="plan_free" runat="server"></asp:Literal>
                  </span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Handset/ 
                    Premium</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt">
                  <asp:Literal ID="hs_model" runat="server"></asp:Literal> 
                  &nbsp;&nbsp;<asp:Literal ID="hs_model_name" runat="server"></asp:Literal> <asp:Literal ID="premium_1" runat="server"></asp:Literal></span></td>
                </tr>
                
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Premium 2</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:Literal ID="premium_2" runat="server"></asp:Literal></span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Trade 
                    Field</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:Literal ID="trade_field" runat="server"></asp:Literal>
                  </span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Bundle 
                    Name</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt">
                  <asp:Literal ID="bundle_name" runat="server"></asp:Literal>
                  </span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Rebate</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:Literal ID="rebate" runat="server"></asp:Literal>
                  </span></td>
                </tr>
                <tr> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">Cancel 
                    Auto Renewal</span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt">
                  <asp:Literal ID="cancel_renew" runat="server"></asp:Literal>
                  </span></td>
                </tr>
                <tr> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">Free 
                    Monthly Fee</span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt">
                  <asp:Literal ID="free_mon" runat="server"></asp:Literal>
                  </span></td>
                </tr>
                <tr> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">Normal Rebate Type</span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:Literal ID="normal_rebate_type" runat="server"></asp:Literal>
                    </span> </td>
                </tr>
                <tr> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">Channel</span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt">
                  <asp:Literal ID="channel" runat="server"></asp:Literal>
                  </span></td>
                </tr>
                 <tr> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">Start 
                    Date</span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt">
                  <asp:Literal ID="sdate" runat="server"></asp:Literal></span></td>
                </tr>
                <tr> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">End 
                    Date</span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt">
                  <asp:Literal ID="edate" runat="server"></asp:Literal></span></td>
                </tr>
                <tr> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">Issue 
                    Type</span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt">
                  <asp:Literal ID="issue_type" runat="server"></asp:Literal></span></td>
                </tr>
                <tr> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">Po  
                    Date</span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="po_date" runat="server"></asp:Literal>(MM/dd/yyy)</span></td>
                </tr>
                <tr> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">Remarks  
                    </span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="remarks" runat="server"></asp:Literal></span></td>
                </tr>
                
                <tr> 
                  <td class="cat" colspan="2">&nbsp;</td>
                </tr>
              </table>
              
              
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

