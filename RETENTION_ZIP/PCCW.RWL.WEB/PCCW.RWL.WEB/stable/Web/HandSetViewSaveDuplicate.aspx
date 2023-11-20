<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HandSetViewSaveDuplicate.aspx.cs" Inherits="HandSetViewSaveDuplicate" %>
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
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
<script type="text/javascript">

/*
function ch_hs(){
	if (document.getElementById("form1").hs_model.options[document.getElementById("form1").hs_model.selectedIndex].value==""){
		document.getElementById("form1").premium.disabled = false
		document.getElementById("form1").premium1.disabled = false
	}
	else{
		document.getElementById("form1").premium.disabled = true
		document.getElementById("form1").premium1.disabled = true
	}
	
	if (document.getElementById("form1").premium.value==""){
		document.getElementById("form1").hs_model.disabled = false
		document.getElementById("form1").rebate_amount.disabled = false
		document.getElementById("form1").rebate_amount1.disabled = false
		document.getElementById("form1").rebate_amount2.disabled = false
		document.getElementById("form1").rebate_amount3.disabled = false
		document.getElementById("form1").extra_rebate_amount.disabled = false
		document.getElementById("form1").extra_rebate_amount1.disabled = false
		document.getElementById("form1").extra_rebate_amount2.disabled = false
		document.getElementById("form1").extra_rebate_amount3.disabled = false
		document.getElementById("form1").r_offer.disabled = false
		document.getElementById("form1").r_offer1.disabled = false
		document.getElementById("form1").r_offer2.disabled = false
		document.getElementById("form1").extra_rebate.disabled = false
		document.getElementById("form1").amount.disabled = false
	}
	else{
		document.getElementById("form1").hs_model.disabled = true
		document.getElementById("form1").rebate_amount.disabled = true
		document.getElementById("form1").rebate_amount1.disabled = true
		document.getElementById("form1").rebate_amount2.disabled = true
		document.getElementById("form1").rebate_amount3.disabled = true
		document.getElementById("form1").extra_rebate_amount.disabled = true
		document.getElementById("form1").extra_rebate_amount1.disabled = true
		document.getElementById("form1").extra_rebate_amount2.disabled = true
		document.getElementById("form1").extra_rebate_amount3.disabled = true
		document.getElementById("form1").r_offer.disabled = true
		document.getElementById("form1").r_offer1.disabled = true
		document.getElementById("form1").r_offer2.disabled = true
		document.getElementById("form1").extra_rebate.disabled = true
		document.getElementById("form1").amount.disabled = true
	}
}

function copy2rebate_amount(){
	if (document.getElementById("form1").rebate_amount1.value.length!=0 && document.getElementById("form1").rebate_amount2.value.length!=0 && document.getElementById("form1").rebate_amount3.value.length!=0)
		document.getElementById("form1").rebate_amount.value="$"+document.getElementById("form1").rebate_amount1.value+" x "+document.getElementById("form1").rebate_amount2.value+" + $"+document.getElementById("form1").rebate_amount3.value
}

function copy2extra_rebate(){
	if (document.getElementById("form1").extra_rebate_amount2.value.length!=0 && document.getElementById("form1").extra_rebate_amount2.value.length!=0  && document.getElementById("form1").extra_rebate_amount3.value.length!=0 )
		document.getElementById("form1").extra_rebate_amount.value="$"+document.getElementById("form1").extra_rebate_amount1.value+" x "+document.getElementById("form1").extra_rebate_amount2.value+" + $"+document.getElementById("form1").extra_rebate_amount3.value
}

function copy2r_offer(){
	if (document.getElementById("form1").r_offer1.value.length!=0 && document.getElementById("form1").r_offer2.value.length!=0)
		document.getElementById("form1").r_offer.value="$"+document.getElementById("form1").r_offer1.value+" + $"+document.getElementById("form1").r_offer2.value
}

function update_extra_rebate(){
	if (document.getElementById("form1").extra_rebate_amount2.value.length!=0 && document.getElementById("form1").extra_rebate_amount2.value.length!=0  && document.getElementById("form1").extra_rebate_amount3.value.length!=0 )
		document.getElementById("form1").extra_rebate.value=parseFloat(document.getElementById("form1").extra_rebate_amount1.value)*parseFloat(document.getElementById("form1").extra_rebate_amount2.value)+parseFloat(document.getElementById("form1").extra_rebate_amount3.value);
}

function update_amount(){
	if (document.getElementById("form1").r_offer1.value.length!=0 && document.getElementById("form1").r_offer2.value.length!=0)
		document.getElementById("form1").amount.value=parseFloat(document.getElementById("form1").r_offer1.value)+parseFloat(document.getElementById("form1").r_offer2.value);
}

*/

function ReadOnlyRelease(){
for(i = 0; i<document.getElementById('form1').elements.length;i++){ document.getElementById('form1').elements[i].readOnly =false;}

}

function ch_hs(){
	if (document.getElementById("hs_view_form_hs_model1").options[document.getElementById("hs_view_form_hs_model1").selectedIndex].value==""){
		document.getElementById("hs_view_form_premium").disabled = false
		document.getElementById("hs_view_form_premium1").disabled = false
	}
	else{
		document.getElementById("hs_view_form_premium").disabled = true
		document.getElementById("hs_view_form_premium1").disabled = true
	}
	
	if (document.getElementById("hs_view_form_premium").value==""){
		document.getElementById("hs_view_form_hs_model1").disabled = false
		document.getElementById("hs_view_form_rebate_amount").disabled = false
		document.getElementById("rebate_amount1").disabled = false
		document.getElementById("rebate_amount2").disabled = false
		document.getElementById("rebate_amount3").disabled = false
		document.getElementById("hs_view_form_extra_rebate_amount").disabled = false
		document.getElementById("hs_view_form_extra_rebate_amount_value").disabled = false
		document.getElementById("extra_rebate_amount1").disabled = false
		document.getElementById("extra_rebate_amount2").disabled = false
		document.getElementById("extra_rebate_amount3").disabled = false
		document.getElementById("hs_view_form_r_offer").disabled = false
		document.getElementById("hs_view_form_r_offer_value").disabled = false
		document.getElementById("r_offer1").disabled = false
		document.getElementById("r_offer2").disabled = false
		document.getElementById("hs_view_form_extra_rebate").disabled = false
		document.getElementById("hs_view_form_amount").disabled = false
		document.getElementById("hs_view_form_amount_amount_value").disabled = false
	}
	else{
		document.getElementById("hs_view_form_hs_model1").disabled = true
		document.getElementById("hs_view_form_rebate_amount").disabled = true
		document.getElementById("rebate_amount1").disabled = true
		document.getElementById("rebate_amount2").disabled = true
		document.getElementById("rebate_amount3").disabled = true
		document.getElementById("hs_view_form_extra_rebate_amount").disabled = true
		document.getElementById("hs_view_form_extra_rebate_amount_value").disabled = true
		document.getElementById("extra_rebate_amount1").disabled = true
		document.getElementById("extra_rebate_amount2").disabled = true
		document.getElementById("extra_rebate_amount3").disabled = true
		document.getElementById("hs_view_form_r_offer").disabled = true
		document.getElementById("hs_view_form_r_offer_value").disabled = true
		document.getElementById("r_offer1").disabled = true
		document.getElementById("r_offer2").disabled = true
		document.getElementById("hs_view_form_extra_rebate").disabled = true
		document.getElementById("hs_view_form_amount").disabled = true
		document.getElementById("hs_view_form_amount_amount_value").disabled = true
	}
}

function copy2rebate_amount(){
    if (document.getElementById("rebate_amount1").value.length != 0 && document.getElementById("rebate_amount2").value.length != 0 && document.getElementById("rebate_amount3").value.length != 0) {
        document.getElementById("hs_view_form_rebate_amount").value = "$" + document.getElementById("rebate_amount1").value + " x " + document.getElementById("rebate_amount2").value + " + $" + document.getElementById("rebate_amount3").value
        document.getElementById("hs_view_form_rebate_amount_value").value = document.getElementById("hs_view_form_rebate_amount").value
    }
}

function copy2extra_rebate(){
    if (document.getElementById("extra_rebate_amount2").value.length != 0 && document.getElementById("extra_rebate_amount2").value.length != 0 && document.getElementById("extra_rebate_amount3").value.length != 0) {
        document.getElementById("hs_view_form_extra_rebate_amount").value = "$" + document.getElementById("extra_rebate_amount1").value + " x " + document.getElementById("extra_rebate_amount2").value + " + $" + document.getElementById("extra_rebate_amount3").value
        document.getElementById("hs_view_form_extra_rebate_amount_value").value = document.getElementById("hs_view_form_extra_rebate_amount").value 
    }
}

function copy2r_offer(){
    if (document.getElementById("r_offer1").value.length != 0 && document.getElementById("r_offer2").value.length != 0) {
        document.getElementById("hs_view_form_r_offer").value = "$" + document.getElementById("r_offer1").value + " + $" + document.getElementById("r_offer2").value
        document.getElementById("hs_view_form_r_offer_value").value = document.getElementById("hs_view_form_r_offer").value 
    }
}

function update_extra_rebate(){
    if (document.getElementById("extra_rebate_amount2").value.length != 0 && document.getElementById("extra_rebate_amount2").value.length != 0 && document.getElementById("extra_rebate_amount3").value.length != 0) {
        document.getElementById("hs_view_form_extra_rebate").value = parseFloat(document.getElementById("extra_rebate_amount1").value) * parseFloat(document.getElementById("extra_rebate_amount2").value) + parseFloat(document.getElementById("extra_rebate_amount3").value);
    }
}

function update_amount(){
    if (document.getElementById("r_offer1").value.length != 0 && document.getElementById("r_offer2").value.length != 0) {
        document.getElementById("hs_view_form_amount").value = parseFloat(document.getElementById("r_offer1").value) + parseFloat(document.getElementById("r_offer2").value);
    }
}



function GetTradeID(){
    
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

    <form action="" method="post" name="form1" id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
    <asp:ScriptManager ID="AddWebLogScriptManager" runat="server"></asp:ScriptManager>
<asp:FormView ID="hs_view_form" runat="server" Width="884px" 
            DataSourceID="hs_view_source"   ondatabound="hs_view_form_DataBound" 
            onitemcommand="hs_view_form_ItemCommand" 
            oniteminserting="hs_view_form_ItemInserting">

<ItemTemplate>
                  <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <th height="28" colspan="4">&nbsp;<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></th>
                </tr>
                <tr> 
                  <td height="23" colspan="4" class="row2"><span class="explaintitle"> 
                    </span><span class="gensmall"> 
                    <asp:Button id="MODIFY" Text="MODIFY" runat="server" CssClass="mainoption" Font-Size="7pt" runat="server" CausesValidation="False"  CommandName="Edit" />
                    </span><span class="explaintitle"> 

                    </span><span class="gensmall"> 
                    <asp:Button id="DUPLICATE" Text="DUPLICATE" runat="server" CssClass="mainoption" Font-Size="7pt" runat="server" CausesValidation="False"  CommandName="Duplicate"  />
                    </span><span class="explaintitle"> 

                    </span><span class="gensmall"> 
                    <asp:Button ID="back" Text="BACK" runat="server" CssClass="mainoption" Font-Size="7pt" runat="server" CausesValidation="False"  CommandName="Back"  />
                    
                    </span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Plan 
                      Fee</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt">
                  <asp:Literal ID="plan_fee" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "plan_fee") %>'></asp:Literal>
                    </span></td>
                </tr>
                <tr> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">Normal Rebate Type</span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:Literal ID="normal_rebate_type" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "normal_rebate_type") %>'></asp:Literal>
                   </span> </td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Offer 
                      Group</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:Literal ID="rebate_gp" runat="server"  Text='<%# DataBinder.Eval(Container.DataItem, "rebate_gp") %>'></asp:Literal>
                    </span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">
                      Contract Period </span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt">
                  <asp:Literal ID="con_per" runat="server"  Text='<%# DataBinder.Eval(Container.DataItem, "con_per") %>'></asp:Literal>
                    </span></td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Handset 
                      Model </span></td>
                  <td width="77%" height="0" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:Literal ID="hs_model" runat="server"  Text='<%# DataBinder.Eval(Container.DataItem, "hs_model") %>'></asp:Literal>
                   </span></td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Handset Offer Type</span></td>
                  <td width="77%" height="0" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:Literal ID="offer_type_id" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "offer_type_id") %>'></asp:Literal>
					</span></td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Premium</span></td>
                  <td width="77%" height="0" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:Literal ID="premium" runat="server"  Text='<%# DataBinder.Eval(Container.DataItem, "premium") %>'></asp:Literal>
					</span></td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Rebate 
                      Amount </span></td>
                  <td width="77%" height="0" class="row1"> <span class="gensmall" style="font-size:7pt">
                  <asp:Literal ID="rebate_amount" runat="server"  Text='<%# DataBinder.Eval(Container.DataItem, "rebate_amount") %>'></asp:Literal>
                    </span> 
                  </td>
                </tr>
                <tr> 
                  <td width="23%" height="0" class="row2" ><span class="explaintitle" style="font-size:7pt">
                      Retention Offer</span></td>
                  <td height="0" class="row1" > <span class="gensmall" style="font-size:7pt">
                  <asp:Literal ID="r_offer" runat="server"  Text='<%# DataBinder.Eval(Container.DataItem, "r_offer") %>'></asp:Literal>
				  </span></td>
                </tr>
                <tr> 
                  <td width="23%" height="0" class="row2" ><span class="explaintitle" style="font-size:7pt">
                      Extra Rebate Amount</span></td>
                  <td height="0" class="row1" > <span class="gensmall" style="font-size:7pt">
                  <asp:Literal ID="extra_rebate_amount" runat="server"  Text='<%# DataBinder.Eval(Container.DataItem, "extra_rebate_amount") %>'></asp:Literal>
                    </span> 
                  </td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Extra 
                      Rebate</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt">$ 
                  <asp:Literal ID="extra_rebate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "extra_rebate") %>'></asp:Literal>
                    </span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt"> 
                      Amount</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:Literal ID="amount" runat="server"  Text='<%# DataBinder.Eval(Container.DataItem, "amount") %>'></asp:Literal>
                    </span></td>
                </tr>
                <tr> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">
                      Payment Method </span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt">
                  <asp:Literal ID="payment" runat="server"  Text='<%# DataBinder.Eval(Container.DataItem, "payment") %>'></asp:Literal>
                  </span></td>
                </tr>
                <tr style="display:none"> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">
                      Issue Type</span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt">
                  <asp:Literal ID="issue_type" runat="server"  Text='<%# DataBinder.Eval(Container.DataItem, "issue_type") %>'></asp:Literal>
                  </span></td>
                </tr>
                 <tr> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">Start 
                      Date</span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt">
                  <asp:Literal ID="sdate" runat="server"  Text='<%# DataBinder.Eval(Container.DataItem, "sdate") %>'></asp:Literal>
                  </span></td>
                </tr>
                <tr> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">End 
                      Date</span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt">
                  <asp:Literal ID="edate" runat="server"  Text='<%# DataBinder.Eval(Container.DataItem, "edate") %>'></asp:Literal>
                  </span></td>
                </tr>
                <tr> 
                  <td class="cat" colspan="2">&nbsp; </td>
                </tr>
              </table>
</ItemTemplate>
<EditItemTemplate>
<table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <th height="28" colspan="2">&nbsp;<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></th>
                </tr>
                <tr> 
                  <td height="23" colspan="2" class="row2">
                  
                  <asp:Button ID="savemodify" CssClass="mainoption" Text="SAVE" Font-Size="7pt"  runat="server" CommandArgument="Save" CommandName="Save"/>
                 
                      &nbsp;&nbsp; <input name="submit22" type="reset" class="button" value="RESET" />
                      &nbsp;&nbsp; <span class="gensmall"> 
                  <asp:Button ID="backview" CssClass="mainoption" Text="BACK" Font-Size="7pt"  runat="server" CommandArgument="View" CommandName="View"/>
                    
                    </span><span class="explaintitle"> </span><span class="gensmall"> 
                    </span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Plan 
                      Fee</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:Literal ID="mid" runat="server" Text='<%#  Bind("mid") %>' Visible=false runat="server"></asp:Literal>
                  <asp:Literal ID="plan_fee" runat="server" Text='<%#  Bind("plan_fee") %>' Visible="true"></asp:Literal>
                  <asp:DropDownList ID="plan_fee1" runat="server" Font-Size="7pt" >
                  </asp:DropDownList>
                    </select>
                    </span></td>
                </tr>
                <tr> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">
                      Normal Rebate Type</span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:Literal ID="normal_rebate_type_value" runat="server" Visible="false" Text='<%# Bind("normal_rebate_type") %>'></asp:Literal>
                    <asp:DropDownList ID="normal_rebate_type" AppendDataBoundItems="true" 
                          runat="server" Font-Size="8pt"  
                          SelectedValue='<%# Bind("normal_rebate_type") %>' 
                          DataTextField="normal_rebate_type" DataValueField="normal_rebate_type" 
                          oninit="normal_rebate_type_Init">
        
                  </asp:DropDownList>
					</span> </td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Offer Group</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:Literal ID="rebate_gp" runat="server" Visible="false" Text='<%# Bind("rebate_gp") %>'></asp:Literal>
                  <asp:DropDownList ID="rebate_gp1" AppendDataBoundItems="true" Font-Size="7pt" runat="server">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>

                    </span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Contract Period </span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:TextBox ID="con_per" runat="server" Font-Size="7pt" MaxLength="5" onBlur="isNum(this);" 
                          Text='<%#  Bind("con_per") %>' ReadOnly="True"></asp:TextBox>
                    <asp:DropDownList ID="con_per1" Font-Size="7pt" onclick="copyValue(this,document.getElementById('hs_view_form$con_per'))" runat="server" AppendDataBoundItems="true">
                    </asp:DropDownList>

                    </span></td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Handset 
                      Model </span></td>
                  <td width="77%" height="0" class="row1"> 
				  <asp:Literal ID="hs_model" runat="server" Visible="false" Text='<%# Bind("hs_model") %>'></asp:Literal>
                  <asp:DropDownList ID="hs_model1" runat="server" AppendDataBoundItems="true" Font-Size="7pt" onChange="ch_hs()"></asp:DropDownList>
                   </td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Handset Offer Type</span></td>
                  <td width="77%" height="0" class="row1"> 
                  <asp:Hiddenfield ID="offer_type_id" runat="server" Value='<%#  Bind("offer_type_id") %>' ></asp:Hiddenfield>
                    <asp:DropDownList ID="offer_type_id1" Font-Size="7pt" onChange="copyValue(this,document.getElementById('hs_view_form$offer_type_id'))" runat="server" AppendDataBoundItems="true">
                    </asp:DropDownList>
                  </td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Premium</span></td>
                  <td width="77%" height="0" class="row1"> 
                  <asp:TextBox ID="premium" 
                          Text='<%#  Bind("premium") %>' runat="server" 
                          maxlength="100" onBlur="chg_upper(this);" onChange="ch_hs()" Font-Size="7pt" 
                          ReadOnly="True"></asp:TextBox>
                  <asp:DropDownList ID="premium1" Font-Size="7pt" runat="server" onChange="copyValue(this,document.getElementById('hs_view_form$premium'));ch_hs();"></asp:DropDownList>
                  </td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Rebate 
                      Amount </span></td>
                  <td width="77%" height="0" class="row1"> <span class="gensmall" style="font-size:7pt">
                      $ 
                    <input name="rebate_amount5" type="text" id="rebate_amount1" size="5" maxlength="5" style="font-size:7pt" onBlur="isNum(this);copy2rebate_amount()" />
                      X 
                    <input name="rebate_amount5" type="text" id="rebate_amount2" size="5" maxlength="5" style="font-size:7pt" onBlur="isNum(this);copy2rebate_amount()" />
                      + $ 
                    <input name="rebate_amount5" type="text" id="rebate_amount3" size="5" maxlength="5" style="font-size:7pt" onBlur="isNum(this);copy2rebate_amount()" />
                    </span> 
                    <asp:TextBox ID="rebate_amount_value"  Text='<%#  Bind("rebate_amount") %>' Font-Size="7pt"  size="20" maxlength="30"  ReadOnly=true   runat="server"></asp:TextBox>
                    <asp:TextBox ID="rebate_amount" Text='<%#  Bind("rebate_amount") %>' Font-Size="7pt"  size="20" maxlength="30" style="visibility:hidden"  runat="server" />                     

                  </td>
                </tr>
                <tr> 
                  <td width="23%" height="0" class="row2" ><span class="explaintitle" style="font-size:7pt">
                      Retention Offer</span></td>
                  <td height="0" class="row1" > <span class="gensmall" style="font-size:7pt">$ 
                    <input name="r_offer5" type="text" id="r_offer1" size="5" maxlength="5"  style="font-size:7pt" onBlur="isNum(this);update_amount();copy2r_offer()" />
                      + $ 
                    <input name="r_offer5" type="text" id="r_offer2" size="5" maxlength="5"  style="font-size:7pt" onBlur="isNum(this);update_amount();copy2r_offer()" />
                    </span> &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; 
                    <asp:TextBox ID="r_offer_value"  Text='<%#  Bind("r_offer") %>'  Font-Size="7pt"  size="20" maxlength="30" ReadOnly=true  runat="server"></asp:TextBox>
                    <asp:TextBox ID="r_offer"  Text='<%#  Bind("r_offer") %>' Font-Size="7pt"  size="20" maxlength="30" style="visibility:hidden"  runat="server"/> 
                  </td>
                </tr>
                <tr> 
                  <td width="23%" height="0" class="row2" ><span class="explaintitle" style="font-size:7pt">
                      Extra Rebate Amount</span></td>
                  <td height="0" class="row1" > <span class="gensmall" style="font-size:7pt">$ 
                    <input name="extra_rebate_amount5" type="text" id="extra_rebate_amount1" size="5" maxlength="5"  style="font-size:7pt" onBlur="isNum(this);update_extra_rebate();copy2extra_rebate()" />
                      X 
                    <input name="extra_rebate_amount5" type="text" id="extra_rebate_amount2" size="5" maxlength="5"  style="font-size:7pt" onBlur="isNum(this);update_extra_rebate();copy2extra_rebate()" />
                      + $ 
                    <input name="extra_rebate_amount5" type="text" id="extra_rebate_amount3" size="5" maxlength="5"  style="font-size:7pt" onBlur="update_extra_rebate();isNum(this);copy2extra_rebate()" />
                    </span> 
                      <asp:TextBox ID="extra_rebate_amount_value"   Text='<%#  Bind("extra_rebate_amount") %>'  Font-Size="7pt"  size="20" maxlength="30" ReadOnly=true  runat="server"/> 
                      <asp:TextBox ID="extra_rebate_amount"   Text='<%#  Bind("extra_rebate_amount") %>' Font-Size="7pt"  size="20" maxlength="30" style="visibility:hidden"  runat="server"/> 
                  </td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Extra 
                      Rebate</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt">$ 
                  
                  <asp:TextBox ID="extra_rebate"  Text='<%#  Bind("extra_rebate") %>' Font-Size="7pt"  size="20" maxlength="10" ReadOnly=true runat="server"/> 

                    </span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt"> 
                      Amount</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                      $
						<asp:TextBox ID="amount"  Text='<%#  Bind("amount") %>' Font-Size="7pt"  size="20" maxlength="10" onBlur="chg_upper(this);" runat="server" /> 
                                   
                    </span></td>
                </tr>
                <tr> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">
                      Payment Method </span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt"> 
				  
				  <asp:Literal ID="payment" runat="server" Visible="false" Text='<%# Bind("payment") %>'></asp:Literal>
				  
                  <asp:RadioButtonList ID="payment1" runat="server" AppendDataBoundItems="true" 
                          RepeatDirection="Horizontal">
                  <asp:ListItem Text="Any Payment Method " Value="ALL"></asp:ListItem>
                  <asp:ListItem Text="Credit Card" Value="CREDIT CARD"></asp:ListItem>
                  <asp:ListItem Text="Cash" Value="CASH"></asp:ListItem>
                  </asp:RadioButtonList>
                    </span></td>
                </tr>
                <tr style="display:none"> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">
                      Issue Type</span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt"> 
				  
				  <asp:Literal ID="issue_type" runat="server" Visible="false" Text='<%# Bind("issue_type") %>'></asp:Literal>
				  
                  <asp:DropDownList ID="issue_type1" runat="server" DataSource='<%# IssueTypeDataBind() %>'  SelectedValue='<%# Bind("issue_type") %>'  DataTextField="Key" DataValueField="Value" AppendDataBoundItems="true" Enabled="true" >
                  </asp:DropDownList>
                    </span></td>
                </tr>
                 <tr> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">Start 
                      Date</span></td>
                  <td height="28" class="row1">
                    <span class="gensmall">
                     <asp:TextBox ID="sdate"  Text='<%#  Bind("sdate") %>' Font-Size="7pt"   size="10" maxlength="10" onBlur="chk_date(this,1);" runat="server"></asp:TextBox>
                    <asp:ImageButton runat="server" ID="CalenderImageSDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                    </span>
                    <span class="gensmall" style="font-size:9px">(DD/MM/YYYY)</span></td>
                </tr>
                <tr> 
                  <td height="28"  class="row2"><span class="explaintitle"  style="font-size:7pt">End 
                      Date</span></td>
                  <td height="28" class="row1">
                  <span class="gensmall">
                  <asp:TextBox ID="edate" runat="server" size="10" maxlength="10" Font-Size="7pt"  onBlur="chk_date(this,0);" Text='<%#  Bind("edate") %> '></asp:TextBox>
                  <asp:ImageButton runat="server" ID="CalenderImageEDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                    </span>
                    <span class="gensmall" style="font-size:9px">(DD/MM/YYYY)</span>
                    </td>
                </tr>
               <tr> 
                  <td class="cat" colspan="2">&nbsp; </td>
                </tr>
              </table>
              <cc1:CalendarExtender runat="server" 
        ID="CalendarSDateFormat"
        TargetControlID="sdate"
        Format="dd/MM/yyyy"
        PopupButtonID="CalenderImageSDate" /> 
              
              <cc1:CalendarExtender runat="server" 
        ID="CalendarEDateFormat"
        TargetControlID="edate"
        Format="dd/MM/yyyy"
        PopupButtonID="CalenderImageEDate" />
              
</EditItemTemplate>
<EmptyDataTemplate>
 <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <th height="28" colspan="4">&nbsp;<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></th>
                </tr>
                <tr> 
                  <td height="23" colspan="4" class="row2"><span class="explaintitle"> 
                    </span><span class="gensmall"> 
                    <input type="button" name="MODIFY" value="MODIFY" id="MODIFY" runat="server" class="mainoption"  style="font-size:7pt"/>
                    </span><span class="explaintitle"> 

                    </span><span class="gensmall"> 
                    <asp:Button id="DUPLICATE" Text="DUPLICATE" runat="server" CssClass="mainoption" Font-Size="7pt" runat="server" CausesValidation="False"  CommandName="Duplicate"  />

                    </span><span class="explaintitle"> 

                    </span><span class="gensmall"> 
                    <input name="submit22" type="button" class="button" value="BACK" onclick="history.go(-1);" style="font-size:7pt" />
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
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">
                      Normal Rebate Type</span></td>
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
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">
                      Contract Period </span></td>
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
                  <td width="23%" height="0" class="row2" ><span class="explaintitle" style="font-size:7pt">
                      Retention Offer</span></td>
                  <td height="0" class="row1" > <span class="gensmall" style="font-size:7pt">
                  <asp:Literal ID="r_offer" runat="server"></asp:Literal>
				  </span></td>
                </tr>
                <tr> 
                  <td width="23%" height="0" class="row2" ><span class="explaintitle" style="font-size:7pt">
                      Extra Rebate Amount</span></td>
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
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">
                      Payment Method </span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt">
                  <asp:Literal ID="payment" runat="server"></asp:Literal>
                  </span></td>
                </tr>
                <tr style="display:none"> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">
                      Issue Type</span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt"> 
				  
				  <asp:Literal ID="issue_type" runat="server" Visible="false" ></asp:Literal>
	
                    </span></td>
                </tr>
                 <tr> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">Start 
                      Date</span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt">
                  <asp:Literal ID="sdate" runat="server"></asp:Literal>
                  </span></td>
                </tr>
                <tr> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">End 
                      Date</span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt">
                  <asp:Literal ID="edate" runat="server"></asp:Literal>
                  </span></td>
                </tr>
                <tr> 
                  <td class="cat" colspan="2">&nbsp; </td>
                </tr>
              </table>
</EmptyDataTemplate>
<InsertItemTemplate>
 <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <th height="28" colspan="4">&nbsp;<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></th>
                </tr>
                <tr> 
                  <td height="23" colspan="4" class="row2"><span class="explaintitle"> 
                    </span><span class="gensmall"> 
                     <asp:Button ID="insert" Text="INSERT" CssClass="mainoption" runat="server" OnClientClick="ReadOnlyRelease()" Font-Size="7pt" CommandName="Insert" />
                   </span><span class="explaintitle"> 
                    </span><span class="gensmall"> 
                    &nbsp;&nbsp; <input name="submit22" type="reset" class="button" value="RESET" /> 
                    </span><span class="explaintitle"> 
                    </span><span class="gensmall"> 
                   <asp:Button ID="backview" Text="BACK" CssClass="mainoption" CommandName="View" Font-Size="7pt" runat="server" />
                    </span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Plan 
                      Fee</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:TextBox ID="mid" runat="server" Text='<%#  Bind("mid") %>' Visible="false" runat="server"></asp:TextBox>
                  <asp:Literal ID="mid_text" runat="server" Text='<%#  Bind("mid") %>' Visible="false" runat="server"></asp:Literal>
                  <asp:Literal ID="plan_fee" runat="server" Text='' Visible="true"></asp:Literal>
                  <asp:DropDownList ID="plan_fee1" runat="server" Font-Size="7pt" SelectedValue='<%#  Bind("plan_fee") %>'>
                  </asp:DropDownList>
                    </select>
                    </span></td>
                </tr>
                <tr> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">
                      Normal Rebate Type</span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:Literal ID="normal_rebate_type_value" runat="server" Visible="false"></asp:Literal>
                  
                  <asp:DropDownList ID="normal_rebate_type"  AppendDataBoundItems="true" 
                          runat="server" Font-Size="8pt" 
                          SelectedValue='<%#  Bind("normal_rebate_type") %>' 
                          DataTextField="normal_rebate_type" DataValueField="normal_rebate_type" 
                          oninit="normal_rebate_type_Init">
 
                  </asp:DropDownList>
					</span> </td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Offer 
                      Group</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:Literal ID="rebate_gp" runat="server" Visible="false"></asp:Literal>
                  <asp:DropDownList ID="rebate_gp1" AppendDataBoundItems="true" Font-Size="7pt" runat="server" SelectedValue='<%# Bind("rebate_gp") %>'>
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>
                    </span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">
                      Contract Period </span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:TextBox ID="con_per" runat="server" Font-Size="7pt" MaxLength="5" 
                          onBlur="isNum(this);" 
                           ReadOnly="True"></asp:TextBox>
                    <asp:DropDownList ID="con_per1" Font-Size="7pt" SelectedValue='<%#  Bind("con_per") %>' onclick="copyValue(this,document.getElementById('hs_view_form$con_per'))" runat="server" AppendDataBoundItems="true">
                    </asp:DropDownList>
                    </span></td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Handset 
                      Model </span></td>
                  <td width="77%" height="0" class="row1"> 
				  <asp:Literal ID="hs_model" runat="server" Visible="false" ></asp:Literal>
                  <asp:DropDownList ID="hs_model1" runat="server" SelectedValue='<%# Bind("hs_model") %>' AppendDataBoundItems="true" Font-Size="7pt" onChange="ch_hs()"></asp:DropDownList>
                   </td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Handset Offer Type</span></td>
                  <td width="77%" height="0" class="row1"> 
                  <asp:Hiddenfield ID="offer_type_id" runat="server"></asp:Hiddenfield>
                    <asp:DropDownList ID="offer_type_id1" Font-Size="7pt" SelectedValue='<%#  Bind("offer_type_id") %>' onChange="copyValue(this,document.getElementById('hs_view_form$offer_type_id'))" runat="server" AppendDataBoundItems="true">
                    </asp:DropDownList>
                  </td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Premium</span></td>
                  <td width="77%" height="0" class="row1"> 
                  <asp:TextBox ID="premium"  runat="server" 
                          maxlength="100" onBlur="chg_upper(this);" onChange="ch_hs()" Font-Size="7pt" 
                          ReadOnly="True"></asp:TextBox>
                  <asp:DropDownList ID="premium1" Font-Size="7pt" runat="server" SelectedValue='<%#  Bind("premium") %>' onChange="copyValue(this,document.getElementById('hs_view_form$premium'));ch_hs();"></asp:DropDownList>
                  </td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Rebate 
                      Amount </span></td>
                  <td width="77%" height="0" class="row1"> <span class="gensmall" style="font-size:7pt">
                      $ 
                    <input name="rebate_amount5" type="text" id="rebate_amount1" size="5" maxlength="5" style="font-size:7pt" onBlur="isNum(this);copy2rebate_amount()" />
                      X 
                    <input name="rebate_amount5" type="text" id="rebate_amount2" size="5" maxlength="5" style="font-size:7pt" onBlur="isNum(this);copy2rebate_amount()" />
                      + $ 
                    <input name="rebate_amount5" type="text" id="rebate_amount3" size="5" maxlength="5" style="font-size:7pt" onBlur="isNum(this);copy2rebate_amount()" />
                    </span> 
                    <asp:TextBox ID="rebate_amount" Text='<%#  Bind("rebate_amount") %>' Font-Size="7pt"  size="20" maxlength="30"  runat="server"/> 

                  </td>
                </tr>
                <tr> 
                  <td width="23%" height="0" class="row2" ><span class="explaintitle" style="font-size:7pt">
                      Retention Offer</span></td>
                  <td height="0" class="row1" > <span class="gensmall" style="font-size:7pt">$ 
                    <input name="r_offer5" type="text" id="r_offer1" size="5" maxlength="5"  style="font-size:7pt" onBlur="isNum(this);update_amount();copy2r_offer()" />
                      + $ 
                    <input name="r_offer5" type="text" id="r_offer2" size="5" maxlength="5"  style="font-size:7pt" onBlur="isNum(this);update_amount();copy2r_offer()" />
                    </span> &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; 
                    <asp:TextBox ID="r_offer"  Text='<%#  Bind("r_offer") %>' Font-Size="7pt"  size="20" maxlength="30" runat="server"/> 
                  </td>
                </tr>
                <tr> 
                  <td width="23%" height="0" class="row2" >
                  <span class="explaintitle" style="font-size:7pt">Extra Rebate Amount</span></td>
                  <td height="0" class="row1" > <span class="gensmall" style="font-size:7pt">$ 
                    <input name="extra_rebate_amount5" type="text" id="extra_rebate_amount1" size="5" maxlength="5"  style="font-size:7pt" onBlur="isNum(this);update_extra_rebate();copy2extra_rebate()" />
                      X 
                    <input name="extra_rebate_amount5" type="text" id="extra_rebate_amount2" size="5" maxlength="5"  style="font-size:7pt" onBlur="isNum(this);update_extra_rebate();copy2extra_rebate()" />
                      + $ 
                    <input name="extra_rebate_amount5" type="text" id="extra_rebate_amount3" size="5" maxlength="5"  style="font-size:7pt" onBlur="isNum(this);update_extra_rebate();copy2extra_rebate()" />
                    </span> 
                      <asp:TextBox ID="extra_rebate_amount"  Text='<%#  Bind("extra_rebate_amount") %>' Font-Size="7pt"  size="20" maxlength="30"  runat="server"/> 
                  </td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Extra 
                      Rebate</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt">$ 
                  <asp:TextBox ID="extra_rebate"  Text='<%#  Bind("extra_rebate") %>' Font-Size="7pt"  size="20" maxlength="10" runat="server"/> 
                    </span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt"> 
                      Amount</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                      $
                        <asp:TextBox ID="amount"  Text='<%#  Bind("amount") %>' Font-Size="7pt"  size="20" maxlength="10" onBlur="chg_upper(this);" runat="server"/> 
                  
                    </span></td>
                </tr>
                <tr> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">
                      Payment Method </span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt"> 
				  
				  <asp:Literal ID="payment" runat="server" Visible="false"></asp:Literal>
				  
                  <asp:RadioButtonList ID="payment1" runat="server" AppendDataBoundItems="true" SelectedValue='<%# Bind("payment") %>'  RepeatDirection="Horizontal">
                  <asp:ListItem Text="Any Payment Method " Value="ALL"></asp:ListItem>
                  <asp:ListItem Text="Credit Card" Value="CREDIT CARD"></asp:ListItem>
                  <asp:ListItem Text="Cash" Value="CASH"></asp:ListItem>
                  </asp:RadioButtonList>
                    </span></td>
                </tr>
                <tr style="display:none"> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">
                      Issue Type</span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt"> 
				  
				  <asp:Literal ID="issue_type" runat="server" Visible="false" Text='<%# Bind("issue_type") %>'></asp:Literal>
				  
                  <asp:DropDownList ID="issue_type1" runat="server" DataSource='<%# IssueTypeDataBind() %>'  SelectedValue='<%# Bind("issue_type") %>'   DataTextField="Key" DataValueField="Value" AppendDataBoundItems="true" Enabled="true" >
                  </asp:DropDownList>
                    </span></td>
                </tr>
                
                 <caption>

                     </tr>
                     <tr>
                         <td class="row2" height="28">
                             <span class="explaintitle" style="font-size:7pt">Start Date</span></td>
                         <td class="row1" height="28">
                         <span class="gensmall">
                             <asp:TextBox ID="sdate"  runat="server" Font-Size="7pt" maxlength="10" 
                                 onBlur="chk_date(this,1);" size="10" 
                                 Text='<%#  Bind("sdate","{0:dd/MM/yyyy}") %>'></asp:TextBox>
                             <asp:ImageButton runat="server" ID="CalenderImageSDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                             <span class="gensmall" style="font-size:9px">(DD/MM/YYYY)</span></td>
                     </tr>
                     <tr>
                         <td class="row2" height="28">
                             <span class="explaintitle" style="font-size:7pt">End Date</span></td>
                         <td class="row1" height="28">
                             <span class="explaintitle"></span><span class="gensmall">
                             <span class="gensmall">
                             <asp:TextBox ID="edate" runat="server" Font-Size="7pt" maxlength="10" 
                                 onBlur="chk_date(this,0);" size="10" 
                                 Text='<%#  Bind("edate","{0:dd/MM/yyyy}") %> '></asp:TextBox>
                                 <asp:ImageButton runat="server" ID="CalenderImageEDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                             </span>
                             <span class="gensmall" style="font-size:9px">(DD/MM/YYYY)</span></td>
                     </tr>
                     <tr>
                         <td class="cat" colspan="2">
                             &nbsp;
                         </td>
                     </tr>
                </caption>
              </table>
              
              <cc1:CalendarExtender runat="server" 
        ID="CalendarSDateFormat"
        TargetControlID="sdate"
        Format="dd/MM/yyyy"
        PopupButtonID="CalenderImageSDate" /> 
              
              <cc1:CalendarExtender runat="server" 
        ID="CalendarEDateFormat"
        TargetControlID="edate"
        Format="dd/MM/yyyy"
        PopupButtonID="CalenderImageEDate" />
              
</InsertItemTemplate>

</asp:FormView>
    
        <asp:SqlDataSource ID="hs_view_source" runat="server"   
            SelectCommand="SELECT [mid], [plan_fee], [rebate_gp],[normal_rebate_type], [amount], [rebate_amount], [r_offer],[offer_type_id], [premium], [hs_model], [con_per], [active],[issue_type], CONVERT(varchar(10),[edate],103) [edate], CONVERT(varchar(10),[sdate],103) [sdate], [payment], [extra_rebate_amount], [extra_rebate], [item_code], CONVERT(varchar(10),[ddate],101) [ddate], [did], CONVERT(varchar(10),[cdate],101) [cdate], [cid] FROM [HandSetOfferedBasket] WHERE ([mid] = @mid)" 
            oninit="hs_view_source_Init" >
            <SelectParameters>
                <asp:QueryStringParameter DefaultValue="" Name="mid" 
                    QueryStringField="mid" Type="Int32" />
            </SelectParameters>

        </asp:SqlDataSource>
        
  
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
