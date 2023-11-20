<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HandSetMappingAdd.aspx.cs" Inherits="HandSetMappingAdd" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
<script type="text/javascript">


function ch_hs(){
	if (document.getElementById('form1').hs_model.options[document.getElementById('form1').hs_model.selectedIndex].value==""){
		document.getElementById('form1').premium.disabled = false
		document.getElementById('form1').premium1.disabled = false
	}
	else{
		document.getElementById('form1').premium.disabled = true
		document.getElementById('form1').premium1.disabled = true
	}
	if (document.getElementById('form1').premium.value==""){
		document.getElementById('form1').hs_model.disabled = false
		document.getElementById('form1').rebate_amount.disabled = false
		document.getElementById('form1').rebate_amount1.disabled = false
		document.getElementById('form1').rebate_amount2.disabled = false
		document.getElementById('form1').rebate_amount3.disabled = false
		document.getElementById('form1').extra_rebate_amount.disabled = false
		document.getElementById('form1').extra_rebate_amount1.disabled = false
		document.getElementById('form1').extra_rebate_amount2.disabled = false
		document.getElementById('form1').extra_rebate_amount3.disabled = false
		document.getElementById('form1').r_offer.disabled = false
		document.getElementById('form1').r_offer1.disabled = false
		document.getElementById('form1').r_offer2.disabled = false
		document.getElementById('form1').extra_rebate.disabled = false
		document.getElementById('form1').amount.disabled = false
	}
	else{
		document.getElementById('form1').hs_model.disabled = true
		document.getElementById('form1').rebate_amount.disabled = true
		document.getElementById('form1').rebate_amount1.disabled = true
		document.getElementById('form1').rebate_amount2.disabled = true
		document.getElementById('form1').rebate_amount3.disabled = true
		document.getElementById('form1').extra_rebate_amount.disabled = true
		document.getElementById('form1').extra_rebate_amount1.disabled = true
		document.getElementById('form1').extra_rebate_amount2.disabled = true
		document.getElementById('form1').extra_rebate_amount3.disabled = true
		document.getElementById('form1').r_offer.disabled = true
		document.getElementById('form1').r_offer1.disabled = true
		document.getElementById('form1').r_offer2.disabled = true
		document.getElementById('form1').extra_rebate.disabled = true
		document.getElementById('form1').amount.disabled = true
	}
}

function copy2rebate_amount(){
	if (document.getElementById('form1').rebate_amount1.value.length!=0 && document.getElementById('form1').rebate_amount2.value.length!=0 && document.getElementById('form1').rebate_amount3.value.length!=0)
		document.getElementById('form1').rebate_amount.value="$"+document.getElementById('form1').rebate_amount1.value+" x "+document.getElementById('form1').rebate_amount2.value+" + $"+document.getElementById('form1').rebate_amount3.value
}

function copy2extra_rebate(){
	if (document.getElementById('form1').extra_rebate_amount1.value.length!=0 && document.getElementById('form1').extra_rebate_amount2.value.length!=0  && document.getElementById('form1').extra_rebate_amount3.value.length!=0 )
		document.getElementById('form1').extra_rebate_amount.value="$"+document.getElementById('form1').extra_rebate_amount1.value+" x "+document.getElementById('form1').extra_rebate_amount2.value+" + $"+document.getElementById('form1').extra_rebate_amount3.value
}

function copy2r_offer(){
	if (document.getElementById('form1').r_offer1.value.length!=0 && document.getElementById('form1').r_offer2.value.length!=0)
		document.getElementById('form1').r_offer.value="$"+document.getElementById('form1').r_offer1.value+" + $"+document.getElementById('form1').r_offer2.value
}

function update_extra_rebate(){
	if (document.getElementById('form1').extra_rebate_amount2.value.length!=0 && document.getElementById('form1').extra_rebate_amount2.value.length!=0  && document.getElementById('form1').extra_rebate_amount3.value.length!=0 )
		document.getElementById('form1').extra_rebate.value=parseFloat(document.getElementById('form1').extra_rebate_amount1.value)*parseFloat(document.getElementById('form1').extra_rebate_amount2.value)+parseFloat(document.getElementById('form1').extra_rebate_amount3.value);
}

function update_amount(){
	if (document.getElementById('form1').r_offer1.value.length!=0 && document.getElementById('form1').r_offer2.value.length!=0)
		document.getElementById('form1').amount.value=parseFloat(document.getElementById('form1').r_offer1.value)+parseFloat(document.getElementById('form1').r_offer2.value);
}

function chk_null(tobj){
	if(tobj.value=="")
		tobj.value = "0";
}

function chk_save(ThisForm){
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

    <form id="form1" action="HandSetMappingAddAction.aspx" runat="server" name="form1">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
    <asp:ScriptManager ID="AddWebLogScriptManager" runat="server"></asp:ScriptManager>
    <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <th height="28" colspan="4">&nbsp;<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></th>
                </tr>
                <tr> 
                  <td height="23" colspan="4" class="row2"><input type="button" name="submit2" value="SAVE" class="mainoption"  onclick="chk_save(this.form);" onKeyDown="return false;" style="font-size:7pt"/> 
                    &nbsp;&nbsp; <input name="submit22" type="reset" class="button" value="RESET" />
                    &nbsp;&nbsp; <span class="gensmall">
                    <input name="backtosearch" type="button" class="button" value="BACK TO SEARCH" onclick="location.href='HandSetView.aspx'" style="font-size:7pt" />
                    </span><span class="explaintitle"> </span><span class="gensmall">
                    </span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Plan 
                    Fee</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:DropDownList ID="plan_fee" runat="server" AppendDataBoundItems="true"></asp:DropDownList>
                    </span></td>
                </tr>
                <tr> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">Normal Rebate</span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:DropDownList ID="normal_rebate_type" AppendDataBoundItems="true" runat="server" Font-Size="8pt">
                  </asp:DropDownList>
                  
                  </span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Offer Group</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:DropDownList ID="rebate_gp" AppendDataBoundItems="true" runat="server" Font-Size="7pt">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>
                    </span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Contract 
                    Period </span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:DropDownList ID="con_per" Font-Size="7pt" runat="server" AppendDataBoundItems="true"></asp:DropDownList>

                    </span></td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Handset 
                    Model </span></td>
                  <td width="77%" height="0" class="row1"> 
                  <asp:DropDownList ID="hs_model" AppendDataBoundItems="true" Font-Size="7pt" onchange="ch_hs()" runat="server">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>
                  </td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Handset Offer Type</span></td>
                  <td width="77%" height="0" class="row1"> 
                    <asp:DropDownList ID="offer_type_id" name="<%=WebFunc.qsOffer_Type_Id %>" Font-Size="7pt" runat="server" AppendDataBoundItems="true" onchange="ch_hs()" >
                    <asp:ListItem Text="" Value=""></asp:ListItem>
                    </asp:DropDownList>
                    </td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Premium</span></td>
                  <td width="77%" height="0" class="row1">
                    <asp:DropDownList ID="premium" Font-Size="7pt" runat="server" AppendDataBoundItems="true" onchange="ch_hs()" >
                    <asp:ListItem Text="" Value=""></asp:ListItem>
                    </asp:DropDownList>
                    </td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Rebate 
                    Amount </span></td>
                  <td width="77%" height="0" class="row1"> <span class="gensmall" style="font-size:7pt">$ 
                    <input name="<%=WebFunc.qsRebate_amount5Name %>" type="text" id="rebate_amount1" size="5" maxlength="5" value="0"  style="font-size:7pt" onblur="isNum(this);copy2rebate_amount()" />
                    X 
                    <input name="<%=WebFunc.qsRebate_amount5Name %>" type="text" id="rebate_amount2" size="5" maxlength="5" value="0"   style="font-size:7pt" onblur="isNum(this);copy2rebate_amount()" />
                    + $ 
                    <input name="<%=WebFunc.qsRebate_amount5Name %>" type="text" id="rebate_amount3" size="5" maxlength="5" value="0"   style="font-size:7pt" onblur="isNum(this);copy2rebate_amount()" />
                    </span> 
                    <input name="<%=WebFunc.qsRebate_amountName %>" type="text" id="rebate_amount"  style="font-size:7pt" size="20" maxlength="30" readonly/> 
                  </td>
                </tr>
                <tr> 
                  <td width="23%" height="0" class="row2" ><span class="explaintitle" style="font-size:7pt">Retention 
                    Offer</span></td>
                  <td height="0" class="row1" > <span class="gensmall" style="font-size:7pt">$ 
                    <input name="<%=WebFunc.qsR_offer5Name %>" type="text" id="r_offer1" size="5" maxlength="5"  value="0"  style="font-size:7pt" onblur="isNum(this);update_amount();copy2r_offer()" />
                    + $ 
                    <input name="<%=WebFunc.qsR_offer5Name %>" type="text" id="r_offer2" size="5" maxlength="5"  value="0"  style="font-size:7pt" onblur="isNum(this);update_amount();copy2r_offer()" />
                    </span> &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; 
                    <input name="<%=WebFunc.qsR_offerName %>" type="text" id="r_offer" style="font-size:7pt" size="20" maxlength="30" readonly/> 
                  </td>
                </tr>
                <tr> 
                  <td width="23%" height="0" class="row2" ><span class="explaintitle" style="font-size:7pt">Extra 
                    Rebate Amount</span></td>
                  <td height="0" class="row1" > <span class="gensmall" style="font-size:7pt">$ 
                    <input name="<%=WebFunc.qsExtra_rebate_amount5Name %>" type="text" id="extra_rebate_amount1" value="0"  size="5" maxlength="5"  style="font-size:7pt" onblur="isNum(this);update_extra_rebate();copy2extra_rebate()" />
                    X 
                    <input name="<%=WebFunc.qsExtra_rebate_amount5Name %>" type="text" id="extra_rebate_amount2" value="0"  size="5" maxlength="5"  style="font-size:7pt" onblur="isNum(this);update_extra_rebate();copy2extra_rebate()" />
                    + $ 
                    <input name="<%=WebFunc.qsExtra_rebate_amount5Name %>" type="text" id="extra_rebate_amount3" value="0"  size="5" maxlength="5"  style="font-size:7pt" onblur="isNum(this);update_extra_rebate();copy2extra_rebate()" />
                    </span> 
                    <input name="<%=WebFunc.qsExtra_rebate_amountName %>" type="text" id="extra_rebate_amount"  style="font-size:7pt" size="20" maxlength="30" readonly/> 
                  </td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Extra 
                    Rebate</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt">$ 
                    <input name="<%=WebFunc.qsExtra_rebateName %>" type="text" value="0" id="extra_rebate" style="font-size:7pt" size="5" maxlength="10" onblur="chg_upper(this);"/>
                    </span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt"> 
                    Amount</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                    $
                    <input name="<%=WebFunc.qsAmountName %>" type="text" id="amount" value="0" style="font-size:7pt" size="5" maxlength="10" onblur="chg_upper(this);"/>
                    </span></td>
                </tr>
                <tr> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">Payment 
                    Method </span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt"> 
                    <input type="radio" name="<%=WebFunc.qsPaymentName %>" value="ALL" checked/>
                    Any Payment Method 
                    <input type="radio" name="<%=WebFunc.qsPaymentName %>" value="CREDIT CARD" />
                    Credit Card 
                    <input type="radio" name="<%=WebFunc.qsPaymentName %>" value="CASH" />
                    Cash</span></td>
                </tr>
                <tr style="display:none">
                <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">Issue Type </span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:DropDownList ID="issue_type" DataTextField="Key" DataValueField="Value"  runat="server" AppendDataBoundItems="true">
                  </asp:DropDownList>
                  
                  </span>
                  </td>
                </tr>
                 <tr> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">Start 
                    Date</span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt"> 
                    </span><span class="explaintitle"> </span><span class="gensmall"><span class="gensmall"> 
                    <span class="gensmall">
                    <asp:TextBox ID="sdate" Font-Size="7pt" MaxLength="10" runat="server" ReadOnly="false"></asp:TextBox>
                     <asp:ImageButton runat="server" ID="CalenderImageSDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                    </span> </span><span class="gensmall" style="font-size:9px">(MM/DD/YYYY)<input id="clear_date1" class="button" type="button" value="Clear" onclick="document.getElementById('sdate').value='';" /></span></span></td>
                </tr>
                <tr> 
                  <td height="28"  class="row2"><span class="explaintitle"  style="font-size:7pt">End 
                    Date</span></td>
                  <td height="28" class="row1"><span class="explaintitle"> </span><span class="gensmall"><span class="gensmall">
                    <asp:TextBox ID="edate" Font-Size="7pt" MaxLength="10" runat="server" ReadOnly="false"></asp:TextBox>
                    <asp:ImageButton runat="server" ID="CalenderImageEDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                    </span><span class="gensmall" style="font-size:9px">(MM/DD/YYYY)</span><input id="clear_date2" class="button" type="button" value="Clear" onclick="document.getElementById('edate').value='';" /></span><span class="explaintitle"></span></td>
                </tr>
                <tr> 
                  <td class="cat" colspan="2">&nbsp; </td>
                </tr>
              </table>
              
        <cc1:CalendarExtender runat="server" 
        ID="CalendarSDateFormat"
        TargetControlID="sdate"
        Format="MM/dd/yyyy"
        PopupButtonID="CalenderImageSDate" /> 
              
        <cc1:CalendarExtender runat="server" 
        ID="CalendarEDateFormat"
        TargetControlID="edate"
        Format="MM/dd/yyyy"
        PopupButtonID="CalenderImageEDate" />

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
