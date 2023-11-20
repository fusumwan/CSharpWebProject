<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BusinessTradeAdd.aspx.cs" Inherits="BusinessTradeAdd" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
<script type="text/javascript">

function chk_null(tobj){
	if(tobj.value=="")
		tobj.value = "0";
}

function chk_date2(dtobj,chkempty,gtToday){
	var today = new Date()
	if(dtobj.value != "" || chkempty==1) {
		if(dtobj.value.match(/^\d{8}$/)==null) {
		}
		else {
			txt=dtobj.value.substring(0,2)+"/"+dtobj.value.substring(2,4)+"/"+dtobj.value.substring(4,8)
			dtobj.value=txt
		}
		dt="";
	//	if(today.getMonth()+1<10)
	//		dt="0"

		dt+=today.getDate();
		dt+="/"
		dt+=today.getMonth()+1;
		dt+="/";
		dt+=today.getYear();

		//alert (dt);
		var datePat = /^(\d{1,2})(\/|-)(\d{1,2})\2(\d{2}|\d{4})$/;
		var matchArray = dtobj.value.match(datePat); // is the format ok?
		if (matchArray == null) {
			alert("Date is not in a valid format.")
			
			if (gtToday!=2)
				dtobj.value=dt;
			else
				dtobj.value="";
				
			return false;
		}
		month = matchArray[3]; // parse date into variables
		day = matchArray[1];
		year = matchArray[4];
		if (month < 1 || month > 12) { // check month range
			alert("Month must be between 1 and 12.");
			dtobj.value=dt;
			return false;
		}
		if (day < 1 || day > 31) {
			alert("Day must be between 1 and 31.");
			dtobj.value=dt;
			return false;
		}
		if ((month==4 || month==6 || month==9 || month==11) && day==31) {
			alert("Month "+month+" doesn't have 31 days!")
			dtobj.value=dt;
			return false
		}
		if (month == 2) { // check for february 29th
			var isleap = (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
			if (day>29 || (day==29 && !isleap)) {
				alert("February " + year + " doesn't have " + day + " days!");
				dtobj.value=dt;
				return false;
			}
		}
		var today = new Date()
		var myDate = new Date()

		myDate.setFullYear(year,month-1,day) 
		
		if (gtToday==1){
			if (myDate<today){
				alert ("Input Date should greater than Today!")
				dtobj.value=dt;
				return false;
			}
		}

		if (gtToday==2){
			if (myDate>=today){
				alert ("Input Date should smaller than Today!")
				dtobj.value="";
				return false;
			}
		}

		return true;
	}
}

function chk_save(ThisForm){
document.getElementById("form1").action="BusinessTradeAddImplement.aspx";
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


    <form action="BusinessTradeAddImplement.aspx" method="post" name="form1" id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
           <asp:ScriptManager ID="AddWebLogScriptManager" runat="server"></asp:ScriptManager>
              <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <th height="28" colspan="4">&nbsp;<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></th>
                </tr>
                <tr> 
                  <td height="23" colspan="4" class="row2"><input type="button" name="submit2" value="SAVE" class="mainoption"  onclick="chk_save(this.form);" onKeyDown="return false;" style="font-size:7pt"/> 
                   <input name="submit22" type="reset" class="mainoption" value="RESET" style="font-size:7pt"/> 
                   <input name="submit222" type="button" class="mainoption" value="BACK TO SEARCH" onclick="location.href='BusinessTradeView.aspx'" style="font-size:7pt" /> 
                   <asp:Button ID="importsubmit" Text="IMPORT TRADE FIELD" CssClass="mainoption" Font-Size="7pt" runat="server" PostBackUrl="~/Web/BusinessTradeUpload.aspx" />
                    <span class="explaintitle"> </span><span class="gensmall"> 
                    </span></td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Program 
                    </span></td>
                  <td width="77%" height="0" class="row1"> <input name="<%=WebFunc.qsProgramName %>" type="text" id="program" style="font-size:7pt" size="30" maxlength="30" onblur="chg_upper(this);"/> 
                    
                    <asp:DropDownList ID="program1" runat="server" AppendDataBoundItems="true" onclick="copyValue(this,this.form.program)" Font-Size="7pt">
                    <asp:ListItem Text="" Value=""></asp:ListItem>
                    </asp:DropDownList>
                   
                </tr>
                <tr> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">Normal 
                    Rebate</span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt">                   

					
					<asp:DropDownList ID="normal_rebate_type" AppendDataBoundItems="true" runat="server" Font-Size="8pt" >
       
                    </asp:DropDownList>
					 </td>
                </tr>
                <tr> 
                  <td width="23%" height="0" class="row2" ><span class="explaintitle" style="font-size:7pt">Rate 
                    Plan</span></td>
                  <td height="0" class="row1" > <input name="<%=WebFunc.qsRate_planName %>" type="text" id="rate_plan" style="font-size:7pt" size="30" maxlength="30" onblur="chg_upper(this);"/> 
                    <asp:DropDownList ID="rate_plan1" Font-Size="7pt" AppendDataBoundItems="true" onclick="copyValue(this,this.form.rate_plan)" runat="server">
                    <asp:ListItem Text="" Value=""></asp:ListItem>
                    </asp:DropDownList>
                    </td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Contract 
                    Period </span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                    <input name="<%=WebFunc.qsCon_perName %>" type="text" id="con_per" style="font-size:7pt" size="5" maxlength="5" onblur="isNum(this);"/>
                   <asp:DropDownList ID="con_per1" AppendDataBoundItems="true" Font-Size="7pt" runat="server"  onclick="copyValue(this,this.form.con_per)">
                   <asp:ListItem Text="" Value=""></asp:ListItem>
                   </asp:DropDownList>
                   

                    
                    </span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Plan 
                    Fee</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                    <input name="plan_fee" type="text" id="plan_fee" style="font-size:7pt" size="5" maxlength="5" onblur="isNum(this);"/>
                    <asp:DropDownList ID="plan_fee1" Font-Size="7pt" runat="server" AppendDataBoundItems="true" onclick="copyValue(this,this.form.plan_fee)">
                    <asp:ListItem Text="" Value=""></asp:ListItem>
                    </asp:DropDownList>

                    </span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Rebate</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt">
                    <input name="<%=WebFunc.qsRebateName %>" type="text" id="rebate" style="font-size:7pt" size="5" maxlength="5" onblur="isNum(this);"/>
                    <asp:DropDownList ID="rebate1" runat="server" AppendDataBoundItems="true" Font-Size="7pt"  onclick="copyValue(this,this.form.rebate)">
                    <asp:ListItem Text="" Value=""></asp:ListItem>
                    </asp:DropDownList>

                    
                    </span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Free 
                    Monthly Fee</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                    <input name="<%=WebFunc.qsFree_monName %>" type="text" id="free_mon" style="font-size:7pt" size="10" maxlength="10" />
                    <asp:DropDownList ID="free_mon1" Font-Size="7pt" AppendDataBoundItems="true" runat="server"  onclick="copyValue(this,this.form.free_mon)">
                    <asp:ListItem Text="" Value=""></asp:ListItem>
                    </asp:DropDownList>

                    </span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Handset/ 
                    Premium</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                    <input type="radio" name="<%=WebFunc.qsHs_modelName %>" value="" checked="checked" onclick="if (this.checked) {document.getElementById('form1').hs_model_name.disabled = true;document.getElementById('form1').premium_1.disabled = true} "/>
                    NO Handset/Premium 
                    <input type="radio" name="<%=WebFunc.qsHs_modelName %>" value="Y" onclick="if (this.checked) {document.getElementById('form1').hs_model_name.disabled = false;document.getElementById('form1').premium_1.disabled = true} "/>
                    Handset 
                    <input type="radio" name="<%=WebFunc.qsHs_modelName %>" value="P" onclick="if (this.checked) {document.getElementById('form1').hs_model_name.disabled = true;document.getElementById('form1').premium_1.disabled = false} "/>
                    Premium
                    <input type="radio" name="<%=WebFunc.qsHs_modelName %>" value="A" onclick="if (this.checked) {document.getElementById('form1').hs_model_name.disabled = false;document.getElementById('form1').premium_1.disabled = false} "/>
                   Handset & Premium<br />
                    Handset Model 
                   
                    <asp:DropDownList ID="hs_model_name" runat="server" Font-Size="7pt" AppendDataBoundItems="true" Enabled="false">
                    <asp:ListItem Text="" Value=""></asp:ListItem>
                    </asp:DropDownList>

                    
                    <br />
                    Premium 
                    
                    <asp:DropDownList ID="premium_1" runat="server" AppendDataBoundItems="true" Font-Size="7pt" Enabled="false">
                    <asp:ListItem Text="" Value=""></asp:ListItem>
                    </asp:DropDownList>

                    </span></td>
                </tr>
                
                
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Premium 2
                    Field</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                    <input name="<%=WebFunc.qsPremium_2Name %>" type="text" id="premium_2" style="font-size:7pt" size="40" maxlength="40" onblur="chg_upper(this);"/>
                    
                    <asp:DropDownList ID="premium_21" AppendDataBoundItems="true" Font-Size="7pt" runat="server" onclick="copyValue(this,this.form.premium_2)">
                    <asp:ListItem Text="" Value=""></asp:ListItem>
                    </asp:DropDownList>
                    
                    </span></td>
                </tr>
                
                
                
                
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Trade 
                    Field</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                    <input name="<%=WebFunc.qsTrade_fieldName %>" type="text" id="trade_field" style="font-size:7pt" size="40" maxlength="40" onblur="chg_upper(this);"/>
                    
                    <asp:DropDownList ID="trade_field1" AppendDataBoundItems="true" Font-Size="7pt" runat="server" onclick="copyValue(this,this.form.trade_field)">
                    <asp:ListItem Text="" Value=""></asp:ListItem>
                    </asp:DropDownList>
 
                    
                    </span></td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Bundle 
                    Name</span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                    <input name="<%=WebFunc.qsBundle_nameName %>" type="text" id="bundle_name" style="font-size:7pt" size="50" maxlength="50" onblur="chg_upper(this);"/>
                    
                    <asp:DropDownList ID="bundle_name1" runat="server" AppendDataBoundItems="true" Font-Size="7pt" onclick="copyValue(this,this.form.bundle_name)">
                    <asp:ListItem Text="" Value=""></asp:ListItem>
                    </asp:DropDownList>

                    
                    </span></td>
                </tr>
                <tr style="display:none;"> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">Cancel 
                    Auto Renewal</span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt"> 
                    <input type="radio" name="<%=WebFunc.qsCancel_renewName %>" value="Y"/>
                    Y 
                    <input type="radio" name="<%=WebFunc.qsCancel_renewName %>" value="NIL" checked />
                    NIL </span></td>
                </tr>
                <tr> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">Channel</span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt"> 
                    <input type="radio" name="<%=WebFunc.qsChannelName %>" value="IB"/>
                    IB 
                    <input type="radio" name="<%=WebFunc.qsChannelName %>" value="OB" />
                    OB
                    <input type="radio" name="<%=WebFunc.qsChannelName %>" value="ALL" checked />
                    ALL</span></td>
                </tr>
       <tr> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">Start 
                    Date</span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt"> 
                    </span><span class="explaintitle"> </span><span class="gensmall"><span class="gensmall">
                    <asp:TextBox ID="sdate" Font-Size="7pt" MaxLength="10" runat="server" ReadOnly="false"></asp:TextBox>
                     <asp:ImageButton runat="server" ID="CalenderImageSDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                    </span><span class="gensmall" style="font-size:9px">(MM/DD/YYYY)<input id="clear_date1" class="button" type="button" value="Clear" onclick="document.getElementById('sdate').value='';" /></span></span></td>
                </tr>
                <tr> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">End 
                    Date</span></td>
                  <td height="28" class="row1"><span class="explaintitle"> </span><span class="gensmall"><span class="gensmall">
                    <asp:TextBox ID="edate" Font-Size="7pt" MaxLength="10" runat="server" ReadOnly="false"></asp:TextBox>
                    <asp:ImageButton runat="server" ID="CalenderImageEDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                    </span><span class="gensmall" style="font-size:9px">(MM/DD/YYYY)<input id="clear_date2" class="button" type="button" value="Clear" onclick="document.getElementById('edate').value='';" /></span></span><span class="explaintitle"></span></td>
                </tr>
                
                <tr>
                <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">Issue Type </span></td>
                  <td height="28" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:DropDownList ID="issue_type" runat="server" DataTextField="Key" DataValueField="Value" AppendDataBoundItems="true">
                  </asp:DropDownList>
                  
                  </span>
                  </td>
                </tr>
                <tr> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">PO 
                    Date</span></td>
                  <td height="28" class="row1"><span class="explaintitle"> </span><span class="gensmall"><span class="gensmall">
                    <asp:TextBox ID="po_date" Font-Size="7pt" MaxLength="10" runat="server" ReadOnly="false"></asp:TextBox>
                    <asp:ImageButton runat="server" ID="CalenderImagePDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                    </span><span class="gensmall" style="font-size:9px">(MM/DD/YYYY)<input id="clear_date3" class="button" type="button" value="Clear" onclick="document.getElementById('po_date').value='';" /></span></span><span class="explaintitle"></span></td>
                </tr>
                
                <tr> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">Remarks</span></td>
                  <td height="28" class="row1"><span class="explaintitle"> </span><span class="gensmall"><span class="gensmall">
                    <asp:TextBox ID="remarks" Font-Size="7pt" Width="500" runat="server" ></asp:TextBox>
                    
                    </span></span></td>
                </tr>
                
               <tr> 
                  <td class="cat" colspan="2">&nbsp;</td>
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
        
        <cc1:CalendarExtender runat="server" 
        ID="CalendarPDateFormat"
        TargetControlID="po_date"
        Format="MM/dd/yyyy"
        PopupButtonID="CalenderImagePDate" />
              
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
