<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HandSetView.aspx.cs" Inherits="HandSetView" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<style>
.highlightrow{background:#FFFFbb}
.disablerow{background:#DDDDDD}
</style>
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
<script type="text/javascript">

function ch_hs(){
	if (document.getElementById("form1").hs_model.options[document.getElementById("form1").hs_model.selectedIndex].value==""){
		document.getElementById("form1").premium.disabled = false
		document.getElementById("form1").premium1.disabled = false
	}
	else{
		document.getElementById("form1").premium.disabled = true
		document.getElementById("form1").premium1.disabled = true
	}
	
	if (document.getElementById("form1").premium.value=="")
		document.getElementById("form1").hs_model.disabled = false
	else
		document.getElementById("form1").hs_model.disabled = true
}

function copy2rebate_amount(){
	document.getElementById("form1").rebate_amount.value="$"+document.getElementById("form1").rebate_amount1.value+" x "+document.getElementById("form1").rebate_amount2.value+" + $"+document.getElementById("form1").rebate_amount3.value
}

function copy2extra_rebate(){
	document.getElementById("form1").extra_rebate_amount.value="$"+document.getElementById("form1").extra_rebate_amount1.value+" x "+document.getElementById("form1").extra_rebate_amount2.value+" + $"+document.getElementById("form1").extra_rebate_amount3.value
}

function copy2r_offer(){
	document.getElementById("form1").r_offer.value="$"+document.getElementById("form1").r_offer1.value+" + $"+document.getElementById("form1").r_offer2.value
}

function update_extra_rebate(){
	document.getElementById("form1").extra_rebate.value=parseFloat(document.getElementById("form1").extra_rebate_amount1.value)*parseFloat(document.getElementById("form1").extra_rebate_amount2.value)+parseFloat(document.getElementById("form1").extra_rebate_amount3.value);
}

function update_amount(){
	document.getElementById("form1").amount.value=parseFloat(document.getElementById("form1").r_offer1.value)+parseFloat(document.getElementById("form1").r_offer2.value);
}

function chk_null(tobj){
	if(tobj.value=="")
		tobj.value = "0";
}

function chk_save(ThisForm){
    document.getElementById("form1").action="HandSetViewImplement.aspx?sort=hs_model&order=asc";
	ThisForm.submit()
}

function isNum(tobj){
	if(tobj.value!=""){
	a= Number(tobj.value);
	if (!(a) && tobj.value!="0"){
		alert ("Number Only!");
		tobj.value = "0";
		}
	}
	else
		tobj.value = "0";
}
</script>
</head>
<body style="background-color:#ffffff">
<div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
<form id="form1" runat="server" action="HandSetViewImplement.aspx?sort=hs_model&amp;order=asc" method="post" name="form1">
<div>
<table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <th height="28" colspan="4">&nbsp;<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></th>
                </tr>
                <tr> 
                  <td height="23" colspan="4" class="row2"><input type="button" name="submit2" value="Search" class="mainoption"  onclick="chk_save(this.form);" onKeyDown="return false;" style="font-size:7pt"/>
                    &nbsp;&nbsp; &nbsp;&nbsp; <span class="explaintitle"> </span><span class="gensmall"> 
                    </span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Plan 
                    Fee</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:DropDownList ID="plan_fee" runat="server" AppendDataBoundItems="true" Font-Size="7pt" runat="server">
                  <asp:ListItem Text="ALL" Value=""></asp:ListItem>
                  </asp:DropDownList>
                  
                    </span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Contract 
                    Period </span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  
                  <asp:DropDownList ID="con_per" runat="server" Font-Size="7pt"></asp:DropDownList>
                    </span></td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Handset 
                    Model </span></td>
                  <td width="77%" height="0" class="row1"> 
                  <asp:DropDownList ID="hs_model" runat="server" Font-Size="7pt">
                  <asp:ListItem Text="ALL" Value=""></asp:ListItem>
                  </asp:DropDownList>
                  
                   </td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Handset Offer Type</span></td>
                  <td width="77%" height="0" class="row1"> 
                    <asp:DropDownList ID="offer_type_id" Font-Size="7pt" runat="server" AppendDataBoundItems="true"  >
                    <asp:ListItem Text="" Value=""></asp:ListItem>
                    </asp:DropDownList>
                    </td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Premium</span></td>
                  <td width="77%" height="0" class="row1"> 
                  
                  <asp:DropDownList ID="premium" runat="server" AppendDataBoundItems="true" Font-Size="7pt">
                  <asp:ListItem Text="ALL" Value=""></asp:ListItem>
                  </asp:DropDownList>
                  
                   </td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Rebate 
                    Amount </span></td>
                  <td width="77%" height="0" class="row1"> 
                    <input name="<%=WebFunc.qsRebate_amountName %>" type="text" id="rebate_amount"   style="font-size:7pt" size="20" maxlength="30" onblur="chg_upper(this)" readonly="readonly" runat="server"/> 
                  </td>
                </tr>
                <tr> 
                  <td width="23%" height="0" class="row2" ><span class="explaintitle" style="font-size:7pt">Retention 
                    Offer</span></td>
                  <td height="0" class="row1" > 
                    <input name="<%=WebFunc.qsR_offerName %>" type="text" id="r_offer" style="font-size:7pt" size="20" maxlength="30" onblur="chg_upper(this);" readonly="readonly" runat="server"/> 
                  </td>
                </tr>
                <tr> 
                  <td width="23%" height="0" class="row2" ><span class="explaintitle" style="font-size:7pt">Extra 
                    Rebate Amount</span></td>
                  <td height="0" class="row1" > 
                    <input name="<%=WebFunc.qsExtra_rebate_amountName %>" type="text" id="extra_rebate_amount" style="font-size:7pt" size="20" maxlength="30" onblur="chg_upper(this);" readonly="readonly" runat="server"/> 
                  </td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Extra 
                    Rebate</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt">
                  <input name="<%=WebFunc.qsExtra_rebateName %>" type="text" id="extra_rebate" style="font-size:7pt" size="5" maxlength="10" onblur="chg_upper(this);" runat="server"/>
                    </span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt"> 
                    Amount</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                    <input name="<%=WebFunc.qsAmountName %>" type="text" id="amount" style="font-size:7pt" size="5" maxlength="10" onblur="chg_upper(this);" runat="server"/>
                    </span></td>
                </tr>
                <tr> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">Normal Rebate</span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt"> 
                                    
                    <asp:DropDownList ID="normal_rebate_type" AppendDataBoundItems="true" runat="server" Font-Size="8pt" >
      
                  </asp:DropDownList>
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
<script type="text/javascript" src="/js/dopageunload.js" language="JavaScript"></script>
</body>
</html>
