<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HandSetMappingAddAction.aspx.cs" Inherits="HandSetMappingAddAction" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>

</head>
<body style="background-color:#ffffff">

    <form  action="BusinessTradeAddImplement.aspx" method="post" name="form1" id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
    <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <th height="28" colspan="4">&nbsp;<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></th>
                </tr>
                <tr> 
                  <td height="23" colspan="4" class="row2"><span class="explaintitle"> 
                    </span><span class="gensmall"> 
                    <input type="button" name="addnew" value="Add New" class="mainoption" onclick="location.href='HandSetMappingAdd.aspx'"/>
                    <input name="backtosearch" type="button" class="button" value="BACK TO SEARCH" onclick="location.href='HandSetView.aspx'" style="font-size:7pt" />
                    </span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Plan 
                    Fee</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt">
                  <asp:Literal ID="plan_fee" runat="server"></asp:Literal>
                    </span></td>
                </tr>
                <tr> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">Normal Rebate Type</span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:Literal ID="normal_rebate_type" runat="server"></asp:Literal>
                   </span> </td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Offer 
                    Group</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:Literal ID="rebate_gp" runat="server"></asp:Literal>
                    </span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Contract 
                    Period </span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:Literal ID="con_per" runat="server"></asp:Literal>
                    </span></td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Handset 
                    Model </span></td>
                  <td width="77%" height="0" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:Literal ID="hs_model" runat="server"></asp:Literal>
                   </span></td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Handset Offer Type</span></td>
                  <td width="77%" height="0" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:Literal ID="offer_type_id" runat="server"></asp:Literal>
					</span></td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Premium</span></td>
                  <td width="77%" height="0" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:Literal ID="premium" runat="server"></asp:Literal>
					</span></td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Rebate 
                    Amount </span></td>
                  <td width="77%" height="0" class="row1"> <span class="gensmall" style="font-size:7pt">
                  <asp:Literal ID="rebate_amount" runat="server"></asp:Literal>
                    </span> 
                  </td>
                </tr>
                <tr> 
                  <td width="23%" height="0" class="row2" ><span class="explaintitle" style="font-size:7pt">Retention 
                    Offer</span></td>
                  <td height="0" class="row1" > <span class="gensmall" style="font-size:7pt">
                  <asp:Literal ID="r_offer" runat="server"></asp:Literal>
				  </span></td>
                </tr>
                <tr> 
                  <td width="23%" height="0" class="row2" ><span class="explaintitle" style="font-size:7pt">Extra 
                    Rebate Amount</span></td>
                  <td height="0" class="row1" > <span class="gensmall" style="font-size:7pt">
                  <asp:Literal ID="extra_rebate_amount" runat="server"></asp:Literal>
                    </span> 
                  </td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Extra 
                    Rebate</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt">$ 
                  <asp:Literal ID="extra_rebate" runat="server"></asp:Literal>
                    </span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt"> 
                    Amount</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:Literal ID="amount" runat="server"></asp:Literal>
                    </span></td>
                </tr>
                <tr> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">Payment 
                    Method </span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt">
                  <asp:Literal ID="payment" runat="server"></asp:Literal></span></td>
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
                  <asp:Literal ID="edate" runat="server"></asp:Literal>
                 </span></td>
                </tr>
                
                <tr style="display:none;"> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">Issue Type 
                    </span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt">
                  <asp:Literal ID="issue_type" runat="server"></asp:Literal>
                 </span></td>
                </tr>
                
                <tr> 
                  <td class="cat" colspan="2">&nbsp; </td>
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
