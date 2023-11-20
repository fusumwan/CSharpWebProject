<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PreviousOrderModifyNoCheck.aspx.cs" Inherits="PreviousOrderModifyNoCheck" Trace="false" %>
<%@ Register TagPrefix="RWLMenu" TagName="RWLMenu" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<%@ Import Namespace="NEURON.ENTITY.FRAMEWORK" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="HEAD" runat="server">
   <meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<user:MobileOrderScriptControl ID="MobileOrderScript" runat="server" OrderPageType="PreviousOrderModifyNoCheckScripts" />
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../Resources/Scripts/creditcard.js"></script>
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
<link href="../Resources/Scripts/CalendarControl/CalendarControl.css" rel="Stylesheet" type="text/css" />
<script type="text/javascript" src="../Resources/Scripts/CalendarControl/CalendarControl.js" language="javascript"></script>
<style type="text/css">
.highlightrow{background:#FFFFbb}
.disablerow{background:#DDDDDD}
    .style1
    {
        height: 21px;
        background: #d9e2ec;
    }
    .style2
    {
        height: 21px;
        background: #f9f9f9;
    }
</style>

<script type="text/javascript">
</script>

<script language="javascript">
    function CallCeks(btnCard, Val1, Val2, Val3) {
        document.getElementById('ActiveCreditId').value = btnCard;
        window.open('http://136.139.31.226/cekswebservice/StartCeksSession.ashx?V0=' + Val1 + '&V1=' + Val2 + '&V2=' + Val3, '', 'toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=yes, copyhistory=no, width=550, height=350');
    }
</script>

<asp:Literal ID="load_hl_holder" runat="server"></asp:Literal>
</head>
<body style="background-color:#ffffff" onLoad="load_hl()">
    <form id="form1" runat="server" name="form1">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>

    <asp:Literal ID="ch_g_code_holder" runat="server"></asp:Literal>
    <asp:Literal ID="ch_g_type_holder" runat="server"></asp:Literal>
    <asp:Literal ID="ch_a_code_holder" runat="server"></asp:Literal>
    <asp:Literal ID="vaild_date_holder" runat="server"></asp:Literal>
    <asp:Literal ID="vaild_amount_holder" runat="server"></asp:Literal>
    
    <input type="hidden" id="re_confirm" runat="server" />
    <input type="hidden" id="issue_type" runat="server" />
    <input id="iphone_concierge_order" type="hidden" runat="server" />
        <p>&nbsp;
            </p>

    	<cc1:ToolkitScriptManager ID="AddWebLogScriptManager" runat="server"  EnablePartialRendering="true" ScriptMode="Release" LoadScriptsBeforeUI="false" EnablePageMethods="true" AsyncPostBackTimeout="900">
        </cc1:ToolkitScriptManager>
    	<script type="text/javascript" language="javascript">   
	var pageRequestManager = Sys.WebForms.PageRequestManager.getInstance();                
	pageRequestManager.add_endRequest(EndRequestHandler);   
	    
	function EndRequestHandler(sender, args)   
	{   
	   if (args.get_error() != undefined && args.get_error().httpStatusCode == '500')   
	   {   
	       // 一般Server端的錯誤處理   
	       var errorMessage = args.get_error().message   
	       args.set_errorHandled(true);   
	       //alert("...\n"+errorMessage);   
	    }   
	   else if(args.get_error() != undefined)   
	   {   
	        // 特別針對Client端的PageRequestManagerParserErrorException處理   
	        if(args.get_error().message.substring(0,51) == "Sys.WebForms.PageRequestManagerParserErrorException")   
	        {   
	            alert("系統查詢忙碌，請重新查詢");   
	            args.set_errorHandled(true);   
	            setTimeout('__doPostBack(\'btn_Query\',\'\')', 0);
	            ChangeTab('TBL1','Tab1');    
	        }   
	   }   
	}   
	</script> 
<asp:Literal ID="NeuronJSLibrary" runat="server"></asp:Literal>
<asp:Literal ID="BankCodeArrScript" runat="server"></asp:Literal>
<asp:Literal ID="VasSetScript" runat="server"></asp:Literal>
<input type="hidden" id="ActiveCreditId" name="ActiveCreditId" value="" />
    <input type="hidden" id="MobileRetentionOrder_id" value='<%=WebFunc.qsOrder_id.ToString()%>' />

    <div>
<table width="100%" border="0" style="margin:0px 0px 0px 0px">
        <tr>
          <td width="100%" border="0" style="margin:0px 0px 0px 0px">&nbsp;
		  <table width="800" border="0" cellpadding="3" cellspacing="1" class="forumline">
            <tr>
              <td onclick="ChangeTab('TBL1','Tab1')"  style="cursor:hand; background-color:#cedcec" align="center"><span id="Tab1" style="font-style:normal; font-size:small; font-family:Arial; color:Black">
                  Customer Information</span></td>
              <td onclick="ChangeTab('TBL2','Tab2')"  style="cursor:hand;background-color:#cedcec" align="center"><span id="Tab2" style="font-style:normal; font-size:small; font-family:Arial; color:Black">
                  Offer Information</span></td>
              <td onclick="ChangeTab('TBL3','Tab3')"   style="cursor:hand;background-color:#cedcec" align="center"><span id="Tab3" style="font-style:normal; font-size:small; font-family:Arial; color:Black">
                  Vas Information</span></td>
              <td onclick="ChangeTab('TBL4','Tab4')"  style="cursor:hand;background-color:#cedcec" align="center"><span id="Tab4" style="font-style:normal; font-size:small; font-family:Arial; color:Black">
                  Delivery Information</span></td>
              <td onclick="ChangeTab('TBL5','Tab5')" style="cursor:hand;background-color:#cedcec" align="center"><span id="Tab5" style="font-style:normal; font-size:small; font-family:Arial; color:Black">
                  Remark</span></td>
            </tr>
          </table></td>
        </tr>
        <tr>
          <td border="0" style="margin:0px 0px 0px 0px">
	<table border="0" id="TBL1" width="100%" style=" margin:0px 0px 0px 0px;">
            <tr>
              <td>
    <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr>
                  <th height="28" colspan="2">&nbsp;<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span> <%=Convert.ToInt32(WebFunc.qsOrder_id).ToString() %></th>
                </tr>
                <tr> 
                  <td height="23" colspan="2" class="row2"> <input type="button" name="submit23" value="Check MRT No" class="mainoption"  onclick="check_mrt()"  style="font-size:7pt;display:none"/> 
                    <input name="check_mrt_no" type="hidden" id="check_mrt_no" value="false"/> 
                    <input type="button" name="submit2" id="submit2" value="SAVE" class="mainoption"  onclick="chk_save(this.form)"  style="font-size:7pt"/> 
                    <input name="supp2" type="button" class="mainoption"  value="EDF Status" onClick="" id="edf_status" runat="server"/> 
                    <input name="submit22" type="button" class="button" value="BACK To Search" onClick="location.href='SearchRetentionOrderView.aspx'"  /> 
                      <asp:Literal ID="FalloutReply" Text="Fallout Reply" runat="server"></asp:Literal>
                     <input name="fo_reply" type="text" id="fo_reply" size="100" maxlength="250" onBlur="chg_upper(this);" runat="server"/>	

                      <span class="gensmall"> 
                    </span></td>
                </tr>
                <tr> 
                  <td height="19" class="row3" colspan="2"><span class="explaintitle" style="font-size:7pt">
                      CUSTOMER DATA</span></td>
                </tr>
                <tr> 
                  <td width="23%" height="0" class="row2"><span class="explaintitle" style="font-size:7pt"> 
                      Log Date 登入時間</span></td>
                  <td width="77%" height="0" class="row1"> <input name="<%=WebFunc.qsLog_dateName %>" type="text" id="log_date" runat="server" style="font-size:7pt" size="18" maxlength="20" value="" readonly/> 
                    <span class="gensmall" style="font-size:9px">(DD/MM/YYYY HH:MM)</span></td>
                </tr>

                <tr > 
                  <td width="23%" height="0" class ="row2"><span class="explaintitle" style="font-size:7pt">
                      Language 語言</span></td>
                  <td width="77%" height="0" class ="row1"> 
                  <select name="<%=WebFunc.qsLanguageName %>" id="language" style="font-size:7pt" runat="server">
                  <option value="CHINESE" selected="selected">CHINESE</option>
                  <option value="ENGLISH" >ENGLISH</option>
                  </select>
                  </td>
                </tr>

                
                <tr> 
                  <td height="0" class="row2">
                  <span class="explaintitle" style="font-size:7pt">
                      Customer Name 客戶姓名
                    </span></td>

                  <td height="0" class="row1" nowrap="nowrap"> 
                  
                  <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                    <select name="<%=WebFunc.qsGenderName %>" id="gender" style="font-size:8pt" runat="server">
                      <option value=""></option>
                      <option value="MR">Mr</option>
                      <option value="MS">Ms</option>
                      <option value="MRS">Mrs</option>
                      <option value="MISS">Miss</option>
                   </select>
                    Family Name:<input name="family_name" id="family_name" type="text" class="highlightrow" runat="server" style="font-size:8pt" size="50" maxlength="50" onblur="chg_upper(this);chk_cc(this);ChkFamilyName(this,'Please input word only!')"/>
                    Given Name:<input name="given_name" id="given_name" type="text" class="highlightrow" runat="server" style="font-size:8pt" size="50" maxlength="50" onblur="chg_upper(this);chk_cc(this);ChkGivenName(this,'Please input word only!')"/>
                  <input name="<%=WebFunc.qsCust_nameName %>" class="highlightrow" type="hidden" id="cust_name" runat="server" style="font-size:7pt" size="50" maxlength="50" onblur="chg_upper(this);chk_cc(this);ChkCustName(this,'Please input word only!')"/>
                  </ContentTemplate>
                  </asp:UpdatePanel>
                  </td>
                </tr>


				<tr id="date_of_birth_show" runat="server">
                <td height="0" class ="row2"><span class="explaintitle"  style="font-size:7pt">Date Of Birth(DD/MM/YYYY)</span></td>
                  <td height="0" class ="row1"> 
                  <asp:UpdatePanel ID="update_panel_date_of_birth" runat="server"  UpdateMode="Conditional">
                    <ContentTemplate>
                    <asp:TextBox ID="date_of_birth" Font-Size="7pt" runat="server" ReadOnly="true"></asp:TextBox>
					<asp:ImageButton runat="server" ID="DateOfBirthImage" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
					 <cc1:CalendarExtender runat="server" 
                    ID="CalendarDateOfBirthFormat" OnClientShowing="SetCalendarDateOfBirthFormatMode"
                    TargetControlID="date_of_birth"
                    Format="dd/MM/yyyy"
                    PopupButtonID="DateOfBirthImage"  Animated="False" /> 
                    </ContentTemplate>
				  </asp:UpdatePanel>
                  </td>
                </tr>
                
                <tr  id="ac_no_show" runat="server" > 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Account No. 戶口號碼</span></td>
                  <td height="0" class="row1"> <input name="<%=WebFunc.qsAc_noName %>" type="text" class="highlightrow" id="ac_no" style="font-size:7pt" size="18" maxlength="14" onblur="chk_ac();" runat="server"/>                  </td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">MRT No 
                      登記流動電話號碼<br>
                    </span></td>
                  <td height="0" class="row1"> <input class="highlightrow" name="<%=WebFunc.qsMrt_noName %>" type="text" id="mrt_no" style="font-size:7pt" size="10" maxlength="8" onblur="chk_mobile(this);" runat="server" value=""  />                  </td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">HKID 
                      No/ BR No/ Passport No <br />
                      香港身份證號碼/護照號碼<br>
                    </span></td>
                  <td height="0" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                    <ContentTemplate>
                    <select name="<%=WebFunc.qsId_typeName %>" id="id_type" onChange="chk_id(this);" style="font-size:7pt"  class="highlightrow" runat="server">
                      <option value=""></option>
                      <option value="HKID">HKID</option>
                      <option value="BRNO">BR No</option>
                      <option value="PP">Passport</option>
                    </select>
                    <input name="<%=WebFunc.qsId_typeName %>" type="text" id="id_type1" class="highlightrow" readonly disabled style="display:none;font-size:7pt" size="6" maxlength="1" runat="server"/>
                    <input name="<%=WebFunc.qsHkidName %>" type="text" id="hkid" size="15" maxlength="20" onblur="chg_upper(this);chk_id(this);"   style="font-size:7pt" class="highlightrow" runat="server"/>
                        ( 
                    <input name="<%=WebFunc.qsHkid2Name %>" type="text" id="hkid2" size="2" maxlength="1" onblur="chg_upper(this);chk_id(this);"  style="font-size:7pt"  class="highlightrow" runat="server"/>
                        ) 
					<input name="hidden_hkid" type=hidden id="hidden_hkid" runat="server"/>
                        
                    </ContentTemplate>

                </asp:UpdatePanel>

                    </span></td>
                </tr>
                 <user:MobileOrderAddressUserControl ID="RegisteredAddressControl" runat="server" TableTagVisable="false" DrpClass="disablerow" Enabled="true" TitleNameLbl="Registered Address"
                 TitleFontSize=7  TdOneClass="row2" TdTwoClass="row1" RblClass="highlightrow" TxtClass="explaintitle" ToolkitScriptManagerID="AddWebLogScriptManager" 
                 LoadingImgSrc="../Web/images/loading.gif"
                 DTypeClass="RegisterAddressDTypeClass" 
                 DRegionClass="RegisterAddressDRegionClass" 
                 DDistrictClass="RegisterAddressDDistrictClass" 
                 DRoomClass="RegisterAddressDRoomClass" 
                 DFloorClass="RegisterAddressDFloorClass" 
                 DBlkClass="RegisterAddressDBlkClass" 
                 DBuildClass="RegisterAddressDBuildClass" 
                 DStreetClass="RegisterAddressDStreetClass" 
                  />
                <tr id="bill_medium_show" class="bill_medium_show">
                <td  height="0" class ="row2" >
                <span class="explaintitle" style="font-size:7pt">Bill Medium</span>
                </td>
                <td height="0" class ="row1" >
                <span class="explaintitle" style="font-size:7pt">
                <select id="bill_medium" name="bill_medium" runat="server" class="bill_medium" onchange="BillMediumChange(this.value,true)" >
                <option value=""></option>
                <option value="0">SMS bill $0</option>
                <option value="1">Email bill $0</option>
                <option value="2">Paper bill $10</option>
                <option value="3">SMS bill $0 + Email bill $0</option>
                </select>
                    Waive
                <input id="bill_medium_waive" name="bill_medium_waive" class="bill_medium_waive"  runat="server" type="checkbox" onclick='SameRegister(this)' value="true" disabled="disabled" />
                </span>
                </td>
                </tr>
                <tr id="sms_mrt_show" class="sms_mrt_show" style="display:none">
                <td height="0" class ="row2" >
                <span class="explaintitle" style="font-size:7pt">SMS Mrt</span>
                </td>
                <td height="0" class ="row1" >
                <input id="sms_mrt" name="sms_mrt" class="sms_mrt"  runat="server" type="text" size="30" maxlength="100" />
                </td>
                </tr>
                <tr id="bill_medium_email_show" class="bill_medium_email_show" >
                <td height="0" class ="row2" >
                <span class="explaintitle" style="font-size:7pt">Email Address</span>
                </td>
                <td height="0" class ="row1" >
                <input id="bill_medium_email" name="bill_medium_email" class="bill_medium_email" runat="server" type="text" size="30" maxlength="100" />
                </td>

                </tr>
                
                <tr id="same_register_address_show" class="same_register_address_show">
				  <td height="0"  class ="row2"><span class="explaintitle" style="font-size:7pt">
                      Billing Address</span></td>
				  <td height="0"  class ="row1"><span class="explaintitle" style="font-size:7pt">
				      Same as Registered Address? ( Yes<input id="same_register_address_0" name="same_register_address" onclick="CopyRegisterAddress('RegisteredAddressControl','BillingAddressControl')" type="radio" />
				      No<input id="same_register_address_1" name="same_register_address" checked="checked" type="radio" />
				      )
				  </span>
				  </td>
				</tr>
                <user:MobileOrderAddressUserControl ID="BillingAddressControl" TableTagVisable="false" runat="server"  DrpClass="disablerow" Enabled="true" TitleNameLbl=""
                 TitleFontSize="7"  TdOneClass="row2" TdTwoClass="row1" RblClass="highlightrow" TxtClass="explaintitle" ToolkitScriptManagerID="AddWebLogScriptManager" 
                 LoadingImgSrc="../Web/images/loading.gif" 
                 DTypeClass="BillingAddressDTypeClass" 
                 DRegionClass="BillingAddressDRegionClass" 
                 DDistrictClass="BillingAddressDDistrictClass" 
                 DRoomClass="BillingAddressDRoomClass" 
                 DFloorClass="BillingAddressDFloorClass" 
                 DBlkClass="BillingAddressDBlkClass" 
                 DBuildClass="BillingAddressDBuildClass" 
                 DStreetClass="BillingAddressDStreetClass" 
                 />
				<tr id="vip_case_show" runat="server">
				  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">VIP Customer </span></td>
				  <td height="0" class="row1">
				  <asp:TextBox ID="vip_case"  Width="204px" MaxLength="200" runat="server"></asp:TextBox>
				  </td>
				</tr>
				
				<tr id="special_handling_dummy_code_show" runat="server">
				   <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Special Handling Dummy Code</span></td>
				   <td height="0" class="row1">
				   <asp:DropDownList ID="special_handling_dummy_code" runat="server">
				   <asp:ListItem Text="" Value=""></asp:ListItem>
				   <asp:ListItem Text="E-NOTICE SUPPRESS - MSP0020041" Value="E-NOTICE SUPPRESS - MSP0020041"></asp:ListItem>
				   <asp:ListItem Text="SEND APPLICATION FORM BY POST - MSP0020042" Value="SEND APPLICATION FORM BY POST - MSP0020042"></asp:ListItem>
				   </asp:DropDownList>
				   </td>
                </tr>
               
               <tr id="existing_customer_type_show" runat="server"> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Existing Customer Type</span></td>
                  <td height="0" class="row1"> 
                  <asp:DropDownList ID="exist_cust_plan" CssClass="highlightrow" Font-Size="7pt" 
                          runat="server" AutoPostBack="true" onselectedindexchanged="exist_cust_plan_SelectedIndexChanged" AppendDataBoundItems="true" onChange="OrgFeeListLoad();">
                          <asp:ListItem Text="" Value=""></asp:ListItem>
                          </asp:DropDownList>

                    <span class="gensmall" style="font-size:7pt"><img src="images/loading.gif" name="load_org_fee" id="load_org_fee" style="display:none" /><span class="explaintitle">
                    </td>
                </tr>
                
                 <tr id="original_tariff_fee_show" runat="server"> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">
                      Original Tariff Fee<br>
                    </span></td><td height="0" class="row1"> 
                  <asp:UpdatePanel ID="org_fee_update_plan" runat="server">
                  <ContentTemplate>
                  <asp:DropDownList ID="org_fee" CssClass="highlightrow" Font-Size="7pt" runat="server">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>

                  </ContentTemplate>

                  </asp:UpdatePanel>
                  
                    </td>
                </tr>
                 <tr id="ob_program_id_show" runat="server">
				  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">OB 
                      Program ID</span></td>
				  <td height="0" class="row1">
				  <% ObModifyCreate(); %>
	
					</td>
				</tr>
				<tr id="existing_contract_end_month_show" runat="server">
				  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">
                      Existing Contract End Month</span></td>
				  <td height="0" class="row1">
					<select name="<%=WebFunc.qsExisting_contract_end_monthName %>"  id="existing_contract_end_month" style="font-size:7pt" runat="server"  onchange="CheckExistingDate()">
					<option value=""></option>
					<option value="JAN">JAN</option>
					<option value="FEB">FEB</option>
					<option value="MAR">MAR</option>
					<option value="APR">APR</option>
					<option value="MAY">MAY</option>
					<option value="JUN">JUN</option>
					<option value="JUL">JUL</option>
					<option value="AUG">AUG</option>
					<option value="SEP">SEP</option>
					<option value="OCT">OCT</option>
					<option value="NOV">NOV</option>
					<option value="DEC">DEC</option>
					</select>/
					<select name="<%=WebFunc.qsExisting_contract_end_yearName %>" id="existing_contract_end_year" style="font-size:7pt" runat="server"  onchange="CheckExistingDate()">
 					<option value=""></option>
					<option value="2008">2008</option>
					<option value="2009">2009</option>
					<option value="2010">2010</option>
					<option value="2011">2011</option>
					<option value="2012">2012</option>
					</select>
					
                    <input type="checkbox" name="<%=WebFunc.qsOrg_ftgName %>" id="org_ftg" value="ftg" runat="server"/></span>FTG</span>
				  </td>
				</tr>

               <tr id="action_required_show" runat="server"> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">
                      Action Required </span></td>
                  <td height="27" class="row1"><span class="gensmall" style="font-size:7pt"> 
                    <span class="explaintitle">

                    <input type="checkbox" name="<%=WebFunc.qsAction_requiredName %>" id="action_required" runat="server" value="suspend" onclick="en_action();c_all();c_action_required()" />

                      Suspend
                    <input type="checkbox" name="<%=WebFunc.qsAction_requiredName2 %>" id="action_required2" runat="server" value="opt_out" disabled="disabled" onclick="en_action_opt();c_all_opt();c_action_required()"/>
					  OPT OUT	


					  </span>
					  </td>
                </tr>
                <tr id="waiving_show" runat="server" > 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">
                      Penalty Waiving 罰款豁免<br>
                    </span></td>
                  <td height="27" class="row1">
                  
                    <asp:RadioButtonList ID="waive" runat="server" AppendDataBoundItems="true" AutoPostBack="false" RepeatDirection="Horizontal">
                    <asp:ListItem Text="Y" Value="Y" class="gensmall" style="font-size:7pt"></asp:ListItem>
                    <asp:ListItem Text="N" Value="N" class="gensmall" style="font-size:7pt"></asp:ListItem>
                    </asp:RadioButtonList>
                    
                    </td>
                </tr>
                
                <tr id="cust_type_show"> 
                  <td height="0" class="row2">
                  <span class="explaintitle" style="font-size:7pt">Customer Type 客戶類別</span>
                  </td>
                  <td id="no_cust_type" height="0" class="row1"><span class="gensmall" style="font-size:7pt">
                    <select name="<%=WebFunc.qsCust_typeName %>" id="cust_type" style="font-size:7pt" runat="server">
                      <option value=""></option>
                      <option value="PCCW Mobile 2G">PCCW Mobile 2G</option>
                        <option value="PCCW Mobile 3G">PCCW Mobile 3G</option>
                        <option value="Mobile Lite">Mobile Lite</option>
                        <option value="Netvigator Everywhere">Netvigator Everywhere</option>
                    </select>
                    </span> </td>
                </tr>
                
               <tr id="suspend_date_show" runat="server"> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt"> 
                      Suspend Date 生效日期<br>
                    </span></td>
                  <td height="0" class="row1"> 
                  <input name="<%=WebFunc.qsAction_eff_dateName %>" type="text" id="action_eff_date" style="font-size:10pt" size="12" maxlength="10"  onchange="vaild_sup_date()"  class="disablerow" disabled="disabled" onfocus="showCalendarControl(this,'vaild_sup_date_by_calendar();');"/> 
                    <span class="gensmall" style="font-size:9px">(DD/MM/YYYY)</span></td>
                </tr>
                
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" >Existing Plan<br>
                    </span></td>
                  <td height="0" class="row1"><span class="gensmall"><asp:Literal ID="exist_plan" runat="server"></asp:Literal> </span> 
                  </td>
                </tr>
                
                <tr id="suspend_reasons_show" runat="server"> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Suspend 
                      Reasons<br>
                    </span></td>
                  <td height="0" class="row1"> 

                  <asp:ListBox ID="reasons" Font-Size="7pt" AppendDataBoundItems="true" CssClass="disablerow" Enabled=false SelectionMode=Multiple runat="server">
                  </asp:ListBox>


                    </td>
                </tr>
			  </table>
                
				
                 </td>
            </tr>
          </table>
				
				
				<table border="0" id="TBL2" width="100%" style=" margin:0px 0px 0px 0px;">

              <tr>
                <td>
              <table id="no_suspend" width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
               <tr> 
                  <td height="0" class="row3" colspan="4"><span class="explaintitle" style="font-size:7pt">Upgrade Information</span></td>
                </tr>
                <tr id="upgrade_type_show" class="upgrade_information_show">
                <td width="25%" height="0" class="row3">
                 <span class="explaintitle"  style="font-size:7pt">Upgrade Type</span>
                 </td>
                 <td height="0">
                 <asp:RadioButtonList ID="upgrade_type" RepeatDirection="Horizontal" AppendDataBoundItems="true" runat="server">
                 <asp:ListItem Text="Mass Upgrade" Value="Mass Upgrade" onclick="UpgradeTypeChange()" ></asp:ListItem>
                 <asp:ListItem Text="Staff Upgrade" Value="Staff Upgrade" onclick="UpgradeTypeChange()"  ></asp:ListItem>
                 </asp:RadioButtonList>
                 </td>
                 <td height="0">
                 <table border="0">
                 <tr>
                 <td>
                 <span style="color:Red;">
                 Sponsorships Amount
                 </span>
                 </td>
                 <td>
                 <asp:DropDownList ID="upgrade_sponsorships_amount" runat="server" AppendDataBoundItems="true">
                 <asp:ListItem Text="$0" Value="$0"></asp:ListItem>
                 <asp:ListItem Text="$110" Value="$110"></asp:ListItem>
                 <asp:ListItem Text="$150" Value="$150"></asp:ListItem>
                 </asp:DropDownList>
                 </td>
                 
                 </tr>
                 
                 </table>
                
                </td>
                <td></td>
                
                </tr>
                
                
                
                <tr id="upgrade_existing_customer_type_show" class="upgrade_information_show">
                <td width="25%" height="0" class="row3">
                 <span  class="explaintitle"  style="font-size:7pt">Existing Contract Type</span>
                 </td>
                 <td>
                 <asp:DropDownList ID="upgrade_existing_customer_type" onchange="UpgradeExistingCustomerTypeChange()" runat="server" AppendDataBoundItems="true">
                 <asp:ListItem Text="" Value=""></asp:ListItem>
                 <asp:ListItem Text="HS UPGRADE TO HS" Value="HS UPGRADE TO HS"></asp:ListItem>
                 <asp:ListItem Text="SIM UPGRADE TO SIM" Value="SIM UPGRADE TO SIM"></asp:ListItem>
                 <asp:ListItem Text="SIM UPGRADE TO HS" Value="SIM UPGRADE TO HS"></asp:ListItem>
                 <asp:ListItem Text="FTG CUSTOMER" Value="FTG CUSTOMER"></asp:ListItem>
                 <asp:ListItem Text="3G LITE CUSTOMER" Value="3G LITE CUSTOMER"></asp:ListItem>
                 </asp:DropDownList>
                 </td>
                 <td>
                 </td>
                 <td>
                 </td>
                </tr>
                

                <tr id="upgarde_ftg_tenure_show" class="upgrade_information_show">
                <td width="25%" height="0" class="row3">
                 <span  class="explaintitle"  style="font-size:7pt">FTG Tenure</span>
                 </td>
                 <td>
                 <asp:DropDownList ID="ftg_tenure" runat="server" AppendDataBoundItems="true" onchange="UpgradeFtgTenureChange()">
                 <asp:ListItem Text="" Value=""></asp:ListItem>
                 <asp:ListItem Text="3GRETEXT CUSTOMER" Value="3GRETEXT CUSTOMER"></asp:ListItem>
                 <asp:ListItem Text="LESS THAN 9 MTHS" Value="LESS THAN 9 MTHS"></asp:ListItem>
                 <asp:ListItem Text="EQUAL OR GREATER THAN 9 MTHS" Value="EQUAL OR GREATER THAN 9 MTHS"></asp:ListItem>
                 </asp:DropDownList>
                 
                 </td>
                 <td>
                 </td>
                 <td>
                 </td>
                </tr>     
                
                <tr id="upgrade_existing_contract_date_show" class="upgrade_information_show">
                <td width="25%" height="0" class="row3">
                 <span  class="explaintitle"  style="font-size:7pt">Existing Contract Period 現有服務合約期</span>
                 </td>
                 <td nowrap="nowrap">
                 From:<asp:TextBox ID="upgrade_existing_contract_sdate"  runat="server"></asp:TextBox>
                 <asp:ImageButton runat="server" ID="UpgradeExistingContractSdateImageButton" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
					 <cc1:CalendarExtender runat="server" 
        ID="UpgradeExistingContractSdateCalendarExtender"
        TargetControlID="upgrade_existing_contract_sdate" OnClientShowing="SetUpgradeExistingContractSdateFormateMode"
        Format="dd/MM/yyyy" 
        PopupButtonID="UpgradeExistingContractSdateImageButton" Animated="False" /> 
        
        To:<asp:TextBox ID="upgrade_existing_contract_edate" runat="server"></asp:TextBox>
                 <asp:ImageButton runat="server" ID="UpgradeExistingContractEdateImageButton" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
					 <cc1:CalendarExtender runat="server" 
        ID="UpgradeExistingContractEdateCalendarExtender"
        TargetControlID="upgrade_existing_contract_edate" OnClientShowing="SetUpgradeExistingContractEdateFormateMode"
        Format="dd/MM/yyyy" 
        PopupButtonID="UpgradeExistingContractEdateImageButton" Animated="False" /> 
        
                 
                 </td>
                 <td>
                 </td>
                 <td>
                 </td>
                 
                </tr>
                
                
                <tr id="upgrade_handset_offer_rebate_schedule_show" class="upgrade_information_show upgrade_handset_offer_rebate_schedule_show" runat="server">
                <td width="25%" height="0" class="row3">
                 <span  class="explaintitle"  style="font-size:7pt">New Handset Offer Rebate Schedule</span>
                 </td>
                 <td>
                 <asp:DropDownList ID="upgrade_handset_offer_rebate_schedule" onchange="UpgradeExistingContractDateChange()" runat="server" AppendDataBoundItems="true">
                 <asp:ListItem Text="N/A" Value="N/A"></asp:ListItem>
                 <asp:ListItem Text="Start on the 7th bill upon new contract started" Value="Start on the 7th bill upon new contract started"></asp:ListItem>
                 <asp:ListItem Text="Start on the 10th bill upon new contract started" Value="Start on the 10th bill upon new contract started"></asp:ListItem>
                 <asp:ListItem Text="Start on the 13th bill upon new contract started" Value="Start on the 13th bill upon new contract started"></asp:ListItem>
                 <asp:ListItem Text="Start on the 16th bill upon new contract started" Value="Start on the 16th bill upon new contract started"></asp:ListItem>
                 <asp:ListItem Text="Start on the 19th bill upon new contract started" Value="Start on the 19th bill upon new contract started"></asp:ListItem>
                 </asp:DropDownList>
                 </td>
                 <td>
                 </td>
                 <td>
                 </td>
                 
                </tr>
                
                
                
                 <tr id="upgrade_rebate_calculation_show" class="upgrade_information_show" runat="server">
                 <td width="25%" height="0" class="row3">
                 <span  ></span>
                 </td>
                 <td>
                 <input id="upgrade_rebate_calculation" style="width:300px"  type="text" runat="server" name="upgrade_rebate_calculation" readonly="readonly" />
                 
                 </td>
                 <td>
                 </td>
                 <td>
                 </td>
                 </tr>
                 
                
                <tr id="upgrade_existing_pccw_customer_show" class="upgrade_information_show">
                <td width="25%" height="0" class="row3">
                 <span  class="explaintitle"  style="font-size:7pt">Existing PCCW Customer 現有電訊盈科客戶</span>
                 </td>
                 <td>
                 <asp:DropDownList ID="upgrade_existing_pccw_customer" onchange="UpgradeExistingPCCWCustomerChange()" runat="server" AppendDataBoundItems="true">
                 <asp:ListItem Text="" Value=""></asp:ListItem>
                 <asp:ListItem Text="NO" Value="NO"></asp:ListItem>
                 <asp:ListItem Text="NETVIGATOR" Value="NETVIGATOR"></asp:ListItem>
                 <asp:ListItem Text="NOW" Value="NOW"></asp:ListItem>
                 <asp:ListItem Text="MOBILE" Value="MOBILE"></asp:ListItem>
                 <asp:ListItem Text="MOBILE ONE" Value="MOBILE ONE"></asp:ListItem>
                 </asp:DropDownList>
                 </td>
                 <td>
                 </td>
                 <td>
                 </td>
                </tr>
                
                
                <tr id="upgrade_service_account_no_show" style="display:none" class="upgrade_information_show">
                <td width="25%" height="0" class="row3">
                 <span  class="explaintitle"  style="font-size:7pt">Service Account No 服務賬戶號碼</span>
                 </td>
                 <td>
                 <input type="text" id="upgrade_service_account_no" maxlength="20" runat="server" />
                 </td>
                 <td>
                 </td>
                 <td>
                 </td>
                </tr>
                
                <tr id="upgrade_registered_mobile_no_show" style="display:none" class="upgrade_information_show">
                <td width="25%" height="0" class="row3">
                 <span  class="explaintitle"  style="font-size:7pt">Registered Mobile No 登記流動電話號碼</span>
                 </td>
                 <td>
                 <input type="text" id="upgrade_registered_mobile_no" maxlength="20" runat="server" />
                 </td>
                 <td>
                 </td>
                 <td>
                 </td>
                </tr>
                
                <tr id="upgrade_service_tenure_show" style="display:none" class="upgrade_information_show">
                 <td width="25%" height="0" class="row3">
                 <span  class="explaintitle"  style="font-size:7pt">Service Tenure 服務使用年期</span>
                 </td>
                 <td>
                 <asp:DropDownList ID="upgrade_service_tenure" AppendDataBoundItems="true" runat="server">
                 <asp:ListItem Text="NO" Value="NO"></asp:ListItem>
                 <asp:ListItem Text="LESS THAN 2 YEARS" Value="LESS THAN 2 YEARS"></asp:ListItem>
                 <asp:ListItem Text="OVER 2 YEARS" Value="OVER 2 YEARS"></asp:ListItem>
                 
                 <asp:ListItem Text="NEW ACCOUNT" Value="NEW ACCOUNT"></asp:ListItem>
                 </asp:DropDownList>
                 </td>
                 <td>
                 </td>
                 <td>
                 </td>
                </tr>
                
                
                
                <tr id="upgrade_card_ref_no_show" class="upgrade_information_show">
                 <td width="25%" height="0" class="row3">
                 <span  class="explaintitle"  style="font-size:7pt">Credit Checking Serial</span>
                 </td>
                 <td>
                 <input id="card_ref_no" name="card_ref_no" runat="server"  maxlength="6" onblur="ChkCardRefNo()"/>
                 </td>
                 <td>
                 </td>
                 <td>
                 </td>
                </tr>
                
                

                
                <tr> 
                  <td height="0" class="row3" colspan="4"><span class="explaintitle" style="font-size:7pt">
                      MNP Information </span></td>
                </tr>
                <user:MobileOrderMNPDetailUserControl ID="MobileOrderMNPDetailControl" TableTagVisable="false" runat="server"  DrpClass="disablerow" Enabled="true" TitleNameLbl=""
     TitleFontSize="7"  TdOneClass="row2" TdTwoClass="row1" TxtClass="explaintitle" RblClass="highlightrow" ToolkitScriptManagerID="AddWebLogScriptManager" CalendarImgSrc="~/Resources/Images/calendar.png"/>
                
                <tr> 
                  <td height="0" class="row3" colspan="4"><span class="explaintitle" style="font-size:7pt">
                      OFFER </span></td>
                </tr>
               <tr id="show_plan_fee" style="display:inline" runat="server">
                 <td width="25%" height="0" class="row2" >
                 <span class="explaintitle" style="font-size:7pt">
                     Plan Fee</span></td>
                    <td height="0" class="row1" >
                    <asp:UpdatePanel ID="plan_fee_update_plan" runat="server">
                    <ContentTemplate>
                    <asp:DropDownList ID="plan_fee" runat="server" Font-Size="7pt" AutoPostBack="true"
                            AppendDataBoundItems="true" onChange="PlanFeeLoad();" 
                            onselectedindexchanged="plan_fee_SelectedIndexChanged">
                    <asp:ListItem Text="" Value=""></asp:ListItem>
                    </asp:DropDownList>
                    <img src="images/loading.gif" name="load_plan_fee" id="load_plan_fee" style="display:none" />
                    </ContentTemplate>
                    </asp:UpdatePanel>
					</td>
                </tr>

                
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Program 
                      計劃</span></td>
                  <td height="0" colspan="3" class="row1"> 
                  <asp:UpdatePanel ID="Updatepanel_program" runat="server">
                  <ContentTemplate>
                  <asp:Literal ID="program_flag" runat="server"></asp:Literal>
                  
                  <asp:DropDownList ID="program" CssClass="highlightrow" Font-Size="7pt"   
                          runat="server" onselectedindexchanged="program_SelectedIndexChanged" 
                          AutoPostBack="True" AppendDataBoundItems="true"  onChange="PlanListLoad();">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>
                  <img src="images/loading.gif" name="load_program" id="load_program" style="display:none" />
                  </ContentTemplate>
                  </asp:UpdatePanel></td>
                </tr>


                <tr id="easywatch_type_show" style="display:none" runat="server"> 

                  <td height="25" class="row2"><span class="explaintitle" style="font-size:7pt">
                      Easywatch Type </span></td>
                  <td height="25" colspan="3" class="row1"> 
                  
                 
                    
                  <span class="gensmall" style="font-size:7pt"> 
                  <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>   
                    <asp:RadioButtonList ID="easywatch_type" runat="server" AppendDataBoundItems="true" RepeatDirection="Horizontal" AutoPostBack=true CssClass="highlightrow" Font-Size="7pt" onselectedindexchanged="easywatch_type_SelectedIndexChanged" >
                    <asp:ListItem Text="Standalone" Value="standalone" style="font-size:7pt"></asp:ListItem>
                    <asp:ListItem Text="Combo offer   Easywatch Standlone Order ID"  Value="combo" style="font-size:7pt"></asp:ListItem>
                    </asp:RadioButtonList>

                    <input name="<%=WebFunc.qsEasywatch_ord_idName %>" runat="server"  class="highlightrow" type="text" id="easywatch_ord_id" style="font-size:7pt" size="8" maxlength="6"  onblur="chk_ord_id(this);" onChange="document.getElementById('form1').check_easy_id.value='false';" />
                    <input id="Button1" type="button" name="submit234" value="Copy Customer Name and HKID" class="mainoption" runat="server"  onclick="copy_stand(document.getElementById('form1').easywatch_ord_id.value)"  style="font-size:7pt"/>
                    <input name="check_easy_id" type="hidden" id="check_easy_id" value="false" runat="server"/> 
                    </ContentTemplate>
                    </asp:UpdatePanel>	 
                    </td>
                </tr>
                <tr id="cust_staff_no_show" style="display:none" runat="server"> 
                    <td height="25" class="row2"><span class="explaintitle" style="font-size:7pt">
                        Customer Staff No </span></td>
                    <td height="25" colspan="3" class="row1">
                    <asp:UpdatePanel ID="UpdatePanel11" runat="server">
                    <ContentTemplate>      
                    <input name="<%=WebFunc.qsCust_staff_noName %>"  class="highlightrow" type="text" id="cust_staff_no" runat="server" style="font-size:7pt" size="12" maxlength="10" onblur="if(this.value.length<5){this.value='';alert('Staff No. at least have 5 characters long');}" /> 
                    <input id="Button2" type="button" name="submit23" value="Check Staff No" class="mainoption"  onclick="check_cust_sn()"  style="font-size:7pt" runat="server"/> 
                        &nbsp;<table cellpadding="4px" cellspacing=0 border="2" bordercolor="red" id="check_cust_no_result" style="display:none"><tr><td id="check_cust_no_result_over" style="display:none;font-size:7pt;">
                            Staff Tenure <font style="color:red;font-size:10pt;">OVER</font> 2 years</td><td id="check_cust_no_result_below" style="display:none;font-size:7pt;">
                                Staff Tenure <font style="color:red;font-size:10pt;">BELOW</font> 2 years</td></tr></table>
                    <input name="check_sn_no" type="hidden" id="check_sn_no" value="false" runat="server"/>			
                    <input name="hidden_cust_staff_no" type=hidden id="hidden_cust_staff_no" runat="server"/>
                    </ContentTemplate>
                    </asp:UpdatePanel>	 
                    </td>
                </tr>
                    
                <tr id="org_mrt_show" style="display:none"  runat="server"> 
                
                  <td height="25" class="row2"><span class="explaintitle" style="font-size:7pt">ORG 
                      MRT NO.</span></td>
                  <td height="25" colspan="3" class="row1"> 
                  <asp:UpdatePanel ID="UpdatePanel28" runat="server">
                    <ContentTemplate>  
                  <input name="org_mrt"  class="highlightrow" type="text" id="org_mrt" style="font-size:7pt" size="10" maxlength="8"  onchange="chk_mobile(this)" runat="server" /> 
                  <asp:Button id="submit_gw" Text="Check Go Wireless MRT NO" CssClass="mainoption"  Font-Size="7pt" runat="server"  onclick="submit_gw_Click" OnClientClick="LoadChkGW()" />
					<img src="images/loading.gif" name="load_go_wireless" id="load_go_wireless"  runat="server" style="display:none"  />
                      </ContentTemplate>
                    </asp:UpdatePanel>	 
                     
                     </td>
                    
                </tr>

                    
                    
                     
                <tr> 
                  <td width="25%" height="0" class="row2" ><span class="explaintitle" style="font-size:7pt">
                      Rebate Type</span></td>
                  <td height="0" colspan="3" class="row1" > 
                  <asp:UpdatePanel ID="normal_rebate_list_update_plan" runat="server">
                  <ContentTemplate>
                  
                  <asp:Literal ID="normal_rebate_type_flag" runat="server"></asp:Literal>

                  <asp:DropDownList ID="normal_rebate_type" AppendDataBoundItems="true" runat="server" Font-Size="8pt" AutoPostBack="true" onchange="NormalPlanListLoad()" onselectedindexchanged="normal_rebate_type_SelectedIndexChanged">

                  </asp:DropDownList>
                  </ContentTemplate>
 
                  </asp:UpdatePanel>
                  
                  			 
                     </td>
                </tr>
                <tr> 
                  <td width="25%" height="0" class="row2" ><span class="explaintitle" style="font-size:7pt">
                      Rate Plan </span></td>
                  <td height="0" colspan="3" class="row1" >
                  
                  <asp:UpdatePanel ID="rate_plan_update_plan" runat="server">
                  <ContentTemplate>
                  <asp:Literal ID="rate_plan_flag" runat="server"></asp:Literal>
                  <asp:DropDownList ID="rate_plan" CssClass="highlightrow" Font-Size="7pt" 
                          runat="server" AppendDataBoundItems="true" AutoPostBack="true"
                          onChange="ConListLoad();c_accessory_info();" 
                          onselectedindexchanged="rate_plan_SelectedIndexChanged">
                          <asp:ListItem Text="" Value=""></asp:ListItem>
                          </asp:DropDownList>
                          <span class="gensmall" style="font-size:7pt"><img src="images/loading.gif" name="load_plan" id="load_plan" style="display:none" /></span>
                  </ContentTemplate>
                  </asp:UpdatePanel>
                   </td>
				</tr>
				

                
				 <tr id="special_approval_show" runat="server"> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">
                      Special Approval<br>
                    </span></td>
                  <td height="27" colspan="3" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:UpdatePanel ID="special_approval_update_panel" runat="server">
        <ContentTemplate>
                  <asp:RadioButtonList ID="special_approval" RepeatDirection=Horizontal AppendDataBoundItems="true" CssClass="highlightrow" runat="server" Font-Size="7pt" disabled="disabled">
                  <asp:ListItem Value="Y" ><span class="gensmall" style="font-size:7pt"> Y</span></asp:ListItem>
                  <asp:ListItem Selected="True" Value="N" ><span class="gensmall" style="font-size:7pt"> 
                      N </span></asp:ListItem>
                  </asp:RadioButtonList>
                  </ContentTemplate>
                  </asp:UpdatePanel>                    
                    </span></td>
                </tr>
				
                 <tr id="autoroll_show" runat="server"> 
                  <td width="25%" height="0" class="row2" ><span class="explaintitle" style="font-size:7pt">
                      Autoroll</span></td>
                  <td height="0" colspan="3" class="row1" > 
                  <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                  <ContentTemplate>
                  <span class="gensmall"> 
                    <input type="radio" name="<%=WebFunc.qsAcceptName %>" id="accept_0" value="Y" disabled="disabled" runat="server"/>
                      Accept 
                    <input type="radio" name="<%=WebFunc.qsAcceptName %>" id="accept_1" value="no_comment" disabled="disabled" runat="server"/>
                      No Comment</span>
                    </ContentTemplate>
                  </asp:UpdatePanel> 
                    
                    </td>
                </tr>
                
                <tr id = "pcd_paid_go_wireless_show" style="display:none">                     
                  <td height="27" class="row2" ><span class="explaintitle" style="font-size:7pt">PCD 
                      PAID Go Wireless</span></td>
                  <td height="27" class="row1" colspan="3" ><input type="checkbox" value="1" name="<%=WebFunc.qsPcd_paid_go_wirelessName %>" id="pcd_paid_go_wireless" onClick="click_pcd_paid_go_wireless();" runat="server"/></td>                    
                </tr>   
                
                <tr> 
                  <td height="28"  class="row2"><span class="explaintitle" style="font-size:7pt">
                      Contract Period 合約期<br>
                    </span></td>
                  <td height="28" colspan="3" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:UpdatePanel ID="con_per_update_panel" runat="server">
                  <ContentTemplate>
                  <asp:Literal ID="con_per_flag" runat="server"></asp:Literal>
                  <asp:DropDownList ID="con_per" runat="server" CssClass="highlightrow" 
                          Font-Size="7pt" AppendDataBoundItems="true"  AutoPostBack="true" 
                          onChange="HsListLoad();" 
                          onselectedindexchanged="con_per_SelectedIndexChanged">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>
                  <img src="images/loading.gif" name="load_con" id="load_con" style="display:none" /> 
                  </ContentTemplate>
                  </asp:UpdatePanel> 

                    
                    </span></td>
                </tr>
                <tr  id="rebate_show" runat="server">
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">
                      Rebate</span></td>
                  <td height="27" colspan="3" class="row1"><span class="gensmall" style="font-size:7pt">
                  
                  
                  <asp:UpdatePanel ID="rebate_update_panel" runat="server">
                  <ContentTemplate>
                  <asp:Literal ID="rebate_flag" runat="server"></asp:Literal>
                  <asp:DropDownList ID="rebate"  runat="server"  Font-Size="7pt" 
                          AppendDataBoundItems="true" AutoPostBack="true" 
                          onChange="TradeRListLoad();" 
                          onselectedindexchanged="rebate_SelectedIndexChanged">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  
                  </asp:DropDownList>
                  <img src="images/loading.gif" name="load_rebate" id="load_rebate" style="display:none" /> 
                  </ContentTemplate>
                  </asp:UpdatePanel>               
                    
                    </span></td>
                </tr>
                <tr  id="free_monthly_fee_show" runat="server"> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Free 
                      Monthly Fee 免費月份費用<br>
                    </span></td>
                  <td height="27" colspan="3" class="row1"><span class="gensmall" style="font-size:7pt"><span class="gensmall" style="font-size:7pt">
                    <asp:UpdatePanel ID="free_mon_update_panel" runat="server">
                    <ContentTemplate>
                    <asp:Literal ID="free_mon_flag" runat="server"></asp:Literal>
                    <asp:DropDownList ID="free_mon"  runat="server" Font-Size="7pt" 
                            AppendDataBoundItems="true" AutoPostBack="true" 
                            onChange="TradeFListLoad();"
                            onselectedindexchanged="free_mon_SelectedIndexChanged">
                    <asp:ListItem Text="" Value=""></asp:ListItem>
                    </asp:DropDownList>
                    <img src="images/loading.gif" name="load_free" id="load_free" style="display:none" /> 
                    </ContentTemplate>
                    </asp:UpdatePanel>
                    
                  </span>
                    </span></td>
                </tr>
                <tr id="lob_type_show" runat="server"> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">LOB 
                      Type 現有服務類別<br>
                    </span></td>
                  <td height="0" colspan="3" class="row1"><span class="gensmall" style="font-size:9px"> 
                 <asp:UpdatePanel ID="UpdatePanel25" runat="server">
                    <ContentTemplate>
                    <asp:DropDownList ID="lob" CssClass="disablerow" Enabled=false Font-Size="7pt" runat="server">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  <asp:ListItem Text="PCD" Value="PCD"></asp:ListItem>
                  <asp:ListItem Text="Now TV" Value="Now TV"></asp:ListItem>
                  <asp:ListItem Text="Mobile" Value="Mobile"></asp:ListItem>
                  <asp:ListItem Text="LTS" Value="LTS"></asp:ListItem>
                  </asp:DropDownList>
                    
                    </ContentTemplate>
                    </asp:UpdatePanel>
                    </span></td>
                </tr>
                 <tr id="lob_account_no_show" runat="server"> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">LOB 
                      Account No 現有服務戶口號碼<br>
                    </span><span class="explaintitle"> </span></td>
                  <td height="0" colspan="3" class="row1"><span class="gensmall" style="font-size:9px"> 
                  
                  
                  <asp:UpdatePanel ID="UpdatePanel26" runat="server">
                  <ContentTemplate>
                    <input runat="server" type="text" name="<%=WebFunc.qsLob_acName %>" class="disablerow" disabled  id="lob_ac" size="15" maxlength="15"  style="font-size:7pt"  onblur="isNum(this);"/>
                     </ContentTemplate>
                     </asp:UpdatePanel>
                    
                    </span></td>
                </tr>
                
                <tr id="go_wireless_package_code_show" runat="server" > 
                  <td height="0" class="row2"><span class="explaintitle"  style="font-size:7pt">Go 
                      Wireless Package Code<br>
                    </span><span > </span></td>
                  <td height="0" colspan="3" class="row1"><span class="gensmall"  style="font-size:9px"> 
                    <input type="text" name="<%=WebFunc.qsGo_wireless_package_codeName %>" class="disablerow" disabled  id="go_wireless_package_code" size="15" maxlength="100"  style="font-size:7pt" runat="server" />
                    </span></td>
                </tr>
                
                
                
                <tr id="hs_model_show" runat="server"> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">HS Model 手機型號</span></td>
                  <td height="0" colspan="3" class="row1"><span class="gensmall" style="font-size:9px"> 
                  <asp:UpdatePanel ID="hs_model_update_panel" runat="server">
                  <ContentTemplate>
                  <asp:Literal ID="hs_model_flag" runat="server"></asp:Literal>
                  <asp:DropDownList ID="hs_model"  runat="server"  Font-Size="7pt" 
                          AppendDataBoundItems="true" AutoPostBack="true" 
                          onChange="TradeHsListLoad();" 
                          onselectedindexchanged="hs_model_SelectedIndexChanged">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>
                  <img src="images/loading.gif" name="load_hs" id="load_hs" style="display:none" /></span><span class="gensmall" style="font-size:9px"> 
                  </ContentTemplate>
                  </asp:UpdatePanel>
                  <input id="btnChkHkidIphone" type="button"  class="mainoption"   name="btnChkHkidIphone" value="Check HKID For IPhone Concierge Service" onclick="check_cust_id_iphone()"  style="font-size:8pt" runat="server"/> 
                  </span><span class="gensmall" style="font-size:7pt">
                    </span></td>
                </tr>
                
                <tr id="existing_smart_phone_model_show" runat="server" style="display:none"> 
                  <td height="0" class="row2">
                  <span class="explaintitle" style="font-size:7pt">Existing Smart Phone Model</span>
                  </td>
                  <td height="0" colspan="3" class="row1">
                  <span class="gensmall" style="font-size:9px">
                  <asp:DropDownList ID="existing_smart_phone_model" AppendDataBoundItems="true" runat="server">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  <asp:ListItem Text="IPAD" Value="IPAD"></asp:ListItem>
                  <asp:ListItem Text="IPAD 2" Value="IPAD 2"></asp:ListItem>
                  <asp:ListItem Text="IPHONE 3G" Value="IPHONE 3G"></asp:ListItem>
                  <asp:ListItem Text="IPHONE 4" Value="IPHONE 4"></asp:ListItem>
                  <asp:ListItem Text="SAMSUNG GALAXY S" Value="SAMSUNG GALAXY S"></asp:ListItem>
                  <asp:ListItem Text="SAMSUNG GALAXY TAB" Value="SAMSUNG GALAXY TAB"></asp:ListItem>
                  <asp:ListItem Text="SAMSUNG GALAXY S II" Value="SAMSUNG GALAXY S II"></asp:ListItem>
                  <asp:ListItem Text="HS SRP $2000-$2999" Value="HS SRP $2000-$2999"></asp:ListItem>
                  <asp:ListItem Text="HS SRP $3000 ABOVE" Value="HS SRP $3000 ABOVE"></asp:ListItem>
                  </asp:DropDownList>
                  </span>
                  </td>
                </tr>
                
                <tr id="existing_smart_phone_imei_show" runat="server" style="display:none"> 
                  <td height="0" class="row2">
                  <span class="explaintitle" style="font-size:7pt">Exising Smart Phone IMEI</span>
                  </td>
                  <td height="0" colspan="3" class="row1">
                  <span class="gensmall" style="font-size:9px"> 
                  <input type="text" name="existing_smart_phone_imei" id="existing_smart_phone_imei" style="font-size:7pt" maxlength="15" runat="server" />
                  </span>
                  </td>
                </tr>
                
                
                <tr id="sku_item_code_show" runat="server"> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">SKU Item Code</span></td>
                  <td height="0" colspan="3" class="row1"><span class="gensmall" style="font-size:9px"> 
                  <asp:UpdatePanel ID="update_panel_sku" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                    <input type="text" name="<%=WebFunc.qsSkuName %>" id="sku" style="font-size:8pt" size="10" maxlength="10"  onblur="isNum(this);" readonly="readonly" runat="server" />
                    </ContentTemplate>
                    </asp:UpdatePanel>
                    <input type="button"  class="buttonlink-washed"   name="submit232" value="?"   onclick="check_remain_hs(document.getElementById('sku').value, document.getElementById('delivery_exchange_location').value)"  style="font-size:8pt"/>
                     </span></td>
                </tr>
                
                <tr id="delivery_exchange_location_show" runat="server" >
				  <td height="0" class="row2">
				  <span class="explaintitle" style="font-size:7pt">location</span>
				  </td>
				  <td height="0" colspan="3" class="row1">
						<input id="delivery_exchange_location" name="delivery_exchange_location" type="text" runat="server" />
				  </td>
				</tr>
                
                <tr id="sim_show" style="display:none" runat="server">
                    <td height="0" class="row2"><span class="explaintitle" style="font-size:8pt">Special Sim</span></td>
                    <td height="0" colspan="3" class="row1">
                        <span class="gensmall" style="font-size:9px">
                            <asp:UpdatePanel ID="update_panel_sim_item" runat="server" UpdateMode="Conditional">
                            <ContentTemplate>
                                Sim Card Name:
                                <asp:Literal ID="sim_item_name_flag" runat="server"></asp:Literal>
                                <asp:DropDownList  id="sim_item_name1" name="sim_item_name1" style="font-size:7pt"  class="disablerow" runat="server" onchange="$('#sim_item_code').val($('#sim_item_name1 option:selected').val());$('#sim_item_name').val($('#sim_item_name1 option:selected').text())" OnSelectedIndexChanged="sim_item_name1_selectedIndexChanged" AutoPostBack="true" >
                                    <asp:ListItem Text="" Value=""></asp:ListItem>
                                </asp:DropDownList>
                                <asp:HiddenField ID="sim_item_name" runat="server" />
                                <asp:Button ID="check_sim_card" name="check_sim_card" runat="server" Text="?" AutoPostBack="true" OnClick="check_sim_number_click" style="font-size:7pt"  />
                                <br />Sim Card Number:
                                <asp:Literal ID="sim_item_number_flag" runat="server"></asp:Literal>
                                <asp:TextBox id="sim_item_number" name="sim_item_number" style="font-size:7pt"  class="disablerow" runat="server" disabled="true"></asp:TextBox>
                                Sim Item Code:
                                <asp:Literal ID="sim_item_code_flag" runat="server"></asp:Literal>
                                <asp:TextBox id="sim_item_code" name="sim_item_code" style="font-size:7pt"  class="disablerow" runat="server"  disabled="true"></asp:TextBox>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </span>
                    </td>
                </tr>
                
                <tr id="cn_mrt_no_show" runat="server">
                <td height="0" class="row2">
                <span class="explaintitle"  style="font-size:7pt">1C2N (CHN) MRT</span>
                </td>
                  <td height="0" colspan="3" class="row1"  nowrap="nowrap">
                  <asp:UpdatePanel ID="update_panel_cn_mrt_no" runat="server"  UpdateMode="Conditional">
                  <ContentTemplate>
                  <span class="Fs2"  style="font-size:9px">
                  <input id="cn_mrt_no" name="cn_mrt_no" maxlength="11" readonly="readonly" type="text" runat="server" />
                  <input id="get_cn_mrt_no" onclick="GetCNMrtNo()"  type="button" class="buttonlink-washed" value="<<" runat="server" />
                  <input id="release_cn_mrt_no" onclick="ReleaseCNMrtNo()"  type="button" class="buttonlink-washed" value="Release" runat="server" />
                  <asp:DropDownList ID="pool" AutoPostBack="true" AppendDataBoundItems="true" runat="server" 
                          onselectedindexchanged="pool_SelectedIndexChanged">
                  <asp:ListItem Text="GUANGZHOU" Value="GUANGZHOU"></asp:ListItem>
                  <asp:ListItem Text="SHANGHAI" Value="SHANGHAI"></asp:ListItem>
                  </asp:DropDownList>
                  <br />
                  <select id="cn_mrt_no_list" name="cn_mrt_no_list" runat="server">
                  
                  </select>
                  </span>
                  </ContentTemplate>
                  </asp:UpdatePanel>
                  
                  </td>
                </tr>
                
                <tr id="premium_show" runat="server"> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Premium 
                      禮品<br>
                    </span></td>
                  <td height="0" colspan="3" class="row1"><span class="gensmall" style="font-size:9px"> 
                  
                  <asp:UpdatePanel ID="premium_update_panel" runat="server">
                  <ContentTemplate>
                  <asp:Literal ID="premium_flag" runat="server"></asp:Literal>
                  <asp:DropDownList ID="premium"  runat="server"  Font-Size="7pt" AppendDataBoundItems="true" AutoPostBack="true"
                          onChange="TradePmuListLoad();" 
                          onselectedindexchanged="premium_SelectedIndexChanged">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>
                  <img src="images/loading.gif" name="load_pmu" id="load_pmu" style="display:none" />
                  </ContentTemplate>
                  
                  </asp:UpdatePanel>
                      
                    </span><span class="gensmall" style="font-size:9px"> 
                    </span></td>
                </tr>
                
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" >IMEI</span></td>
                  <td height="0" colspan="3" class="row1"><span class="gensmall" style="font-size:9px"> 
                    <input type="text" name="imei_no" id="imei_no"  size="20" maxlength="30" runat="server" />
                    </span></td>
                </tr>
                
               <tr id="special_premium_show" runat="server"> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Special 
                      Premium <br>
                    </span></td>
                  <td height="0" colspan="3" class="row1">
                  <span class="gensmall" style="font-size:9px"> 
                  
                  <asp:UpdatePanel ID="s_premium_update_panel" runat="server">
                  <ContentTemplate>
                  <asp:DropDownList ID="s_premium"  runat="server"  Font-Size="7pt"  AutoPostBack="true" AppendDataBoundItems="true" 
                          onselectedindexchanged="s_premium_SelectedIndexChanged">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>
                  

                    
                    <input type="button" name="submit233" value="Check HKID" class="mainoption"  onclick="check_hkid_no()"  style="font-size:7pt"/>
                    <input runat="server" name="check_hkid" type="hidden" id="check_hkid" value="false"/>
                    
                    </ContentTemplate>
                  </asp:UpdatePanel>
                    </span></td>
                </tr>
               <tr  id="special_premium_delivery_date_show" runat="server"> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Special 
                      Premium Delivery Date<br>
                    </span></td>
                  <td height="0" colspan="3" class="row1"> <input name="<%=WebFunc.qsSp_d_dateName %>" type="text" id="sp_d_date" style="font-size:7pt" size="12" maxlength="10" onblur="chk_date2(this,0,0);" onfocus="showCalendarControl(this,'');" /> 
                    <span class="gensmall" style="font-size:9px">(DD/MM/YYYY)</span></td>
                </tr>
                <tr  id="special_premium_quota_reference_no_show" runat="server"> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Special 
                      Premium Quota Reference No</span></td>
                  <td height="0" colspan="3" class="row1"> <input name="sp_ref_no" type="text" id="sp_ref_no" style="font-size:7pt" size="30" maxlength="30" onblur="chg_upper(this);chk_cc(this)"/>                  </td>
                </tr>
                <tr  id="pos_reference_no_show" runat="server"> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">POS 
                      Reference No</span></td>
                  <td height="0" colspan="3" class="row1"> <input name="<%=WebFunc.qsPos_ref_noName %>" type="text" id="pos_ref_no" style="font-size:7pt" size="30" maxlength="30" onblur="chg_upper(this);chk_cc(this)"/>                  </td>
                </tr>
                
                
                <tr  id="special_premium_1_show" runat="server"> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Special Premium 1</span></td>
                  <td height="0" colspan="3" class="row1"><span class="gensmall" style="font-size:9px"> 
                  <asp:UpdatePanel ID="UpdatePanel30" runat="server">
                  <ContentTemplate>
                  <asp:DropDownList ID="s_premium1" runat="server" onChange="SPremium1Load();"  Font-Size="7pt" AutoPostBack="true"  onselectedindexchanged="s_premium1_SelectedIndexChanged">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>
                  </ContentTemplate>
                </asp:UpdatePanel>
                <img src="images/loading.gif" name="load_s_premium1" id="load_s_premium1" style="display:none" />
                </span>
                </td>
                </tr>

				 <tr  id="special_premium_2_show" runat="server"> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Special Premium 2</span></td>
                  <td height="0" colspan="3" class="row1"><span class="gensmall" style="font-size:9px"> 
                  <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                  <ContentTemplate>
                  <asp:DropDownList ID="s_premium2" runat="server" onChange="SPremium2Load();"  Font-Size="7pt" AutoPostBack="true"  onselectedindexchanged="s_premium2_SelectedIndexChanged">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>
                  </ContentTemplate>
                </asp:UpdatePanel>
                <img src="images/loading.gif" name="load_s_premium2" id="load_s_premium2" style="display:none" /> 
                </span>
                </td>
                </tr>
                
                <tr  id="special_premium_3_show" runat="server"> 
                  <td height="0" class="row2"><span class="explaintitle"  style="font-size:7pt">Special Premium 3</span></td>
                  <td height="0" colspan="3" class="row1"><span class="gensmall" style="font-size:9px"> 
                  <asp:UpdatePanel ID="update_panel_s_premium3" runat="server" UpdateMode="Conditional">
                  <ContentTemplate>
                  <asp:DropDownList ID="s_premium3"  onChange="SPremium3Load();"  runat="server"  Font-Size="7pt" AutoPostBack="true"  onselectedindexchanged="s_premium3_SelectedIndexChanged">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>
                  </ContentTemplate>
                  </asp:UpdatePanel>
                  <img src="images/loading.gif" name="load_s_premium3" id="load_s_premium3" style="display:none" /> 
                   </span></td>
                </tr>

                <tr  id="special_premium_4_show" runat="server"> 
                  <td height="0" class="row2"><span class="explaintitle"  style="font-size:7pt">Special Premium 4</span></td>
                  <td height="0" colspan="3" class="row1"><span class="gensmall" style="font-size:9px"> 
                  <asp:UpdatePanel ID="update_panel_s_premium4" runat="server" UpdateMode="Conditional">
                  <ContentTemplate>
                  <asp:DropDownList ID="s_premium4"  onChange="SPremium4Load();"  runat="server"  Font-Size="7pt" AutoPostBack="true"  onselectedindexchanged="s_premium4_SelectedIndexChanged">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>
                  </ContentTemplate>
                  </asp:UpdatePanel>
                  <img src="images/loading.gif" name="load_s_premium4" id="load_s_premium4" style="display:none" /> 
                   </span></td>
                </tr>

                
                <tr id="redemption_notice_option_show" runat="server">
                <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Redemption Notice
                    </span></td>
                  <td height="0" colspan="3" class="row1"><span class="gensmall" style="font-size:9px"> 
                  <select id="redemption_notice_option" name="redemption_notice_option" runat="server" disabled="disabled">
                  <option value="" ></option>
                  <option value="SMS" >SMS</option>
                  <option value="REDEMPTION LETTER" >REDEMPTION LETTER</option>
                  </select>
                  </td>
                </tr>

                <tr  id="trade_field_show" runat="server"> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">Trade 
                      Field</span></td>
                  <td height="27" colspan="3" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:Label ID="trade_field_flag" runat="server"></asp:Label>
                  <asp:UpdatePanel ID="trade_field_update_panel" runat="server">
                  <ContentTemplate>
                  <asp:DropDownList ID="trade_field" Font-Size="7pt" runat="server" 
                          onselectedindexchanged="trade_field_SelectedIndexChanged">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>
                  </ContentTemplate>
                  
                  </asp:UpdatePanel>

                    </span>
                    
                    <input name="old_trade_field" type="hidden" id="old_trade_field" value="" runat="server"/>
                    </td>
                </tr>
                <tr> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">
                      Bundle Name</span></td>
                  <td height="27" colspan="3" class="row1"><span class="gensmall" style="font-size:7pt"> 
                  <asp:Label ID="bundle_name_flag" runat="server"></asp:Label>
                  <asp:UpdatePanel ID="bundle_name_update_panel" runat="server">
                  <ContentTemplate>
                  <asp:DropDownList ID="bundle_name" Font-Size="7pt" runat="server" 
                          onselectedindexchanged="bundle_name_SelectedIndexChanged">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>
                  </ContentTemplate>
                  </asp:UpdatePanel>

                    </span>
                    
                    <input name="old_bundle_name" type="hidden" id="old_bundle_name" runat="server" />
                    </td>
                </tr>
                
                <tr>
                  <td height="27" class="row2" ><span  class="explaintitle" style="font-size:7pt">
                      HandSet Offer Type</span></td>
                  <td height="27" colspan="3" class="row1"><span  class="explaintitle" style="font-size:7pt"> 
                  <asp:UpdatePanel ID="update_panel_hs_offer_type_id" runat="server" UpdateMode="Conditional">
                  <ContentTemplate>
                  <asp:DropDownList ID="hs_offer_type_id" Font-Size="7pt" runat="server"  AutoPostBack="true" AppendDataBoundItems="true" onselectedindexchanged="hs_offer_type_id_SelectedIndexChanged">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>
                  <input name="old_hs_offer_type_id" type="hidden" id="old_hs_offer_type_id" runat="server" visible="false" />
                  </ContentTemplate>
                  </asp:UpdatePanel>
                    </span></td>
                </tr>
                
                <tr  id="monthly_rebate_amount_show" runat="server"> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Monthly 
                      Rebate Amount </span></td>
                  <td height="0" colspan="3" class="row1"><span class="gensmall" style="font-size:9px"> 
                    </span><span class="gensmall" style="font-size:7pt"> </span><span class="gensmall" style="font-size:9px"> 
                    </span><span class="gensmall" style="font-size:7pt"> 
                    <input name="<%=WebFunc.qsM_rebate_amountName %>" type="text" id="m_rebate_amount" size="30" maxlength="30"  style="font-size:7pt" />
                    </span><span class="gensmall" style="font-size:9px"> 

                    </span><span class="gensmall" style="font-size:7pt">$ 
                    <input name="m_rebate_amount1" type="text" id="m_rebate_amount1" size="8" maxlength="10"  style="font-size:7pt" onblur="isNum(this);copy2m_rebate_amount()" />
                      X 
                    <input name="m_rebate_amount2" type="text" id="m_rebate_amount2" size="8" maxlength="10"  style="font-size:7pt" onblur="isNum(this);copy2m_rebate_amount()" />
                      + $ 
                    <input name="m_rebate_amount3" type="text" id="m_rebate_amount3" size="8" maxlength="10"  style="font-size:7pt" onblur="isNum(this);copy2m_rebate_amount()" />
                    </span><span class="gensmall" style="font-size:9px"> </span><span class="gensmall" style="font-size:7pt"> 
                    </span><span class="gensmall" style="font-size:9px"> </span></td>
                </tr>
                <tr id="hs_rebate_amount_show" runat="server">
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">HS 
                      Rebate Amount 手機回贈總額<br>
                    </span></td>
                  <td height="0" colspan="3" class="row1">
                  <span class="gensmall" style="font-size:7pt"> 
                    <asp:UpdatePanel ID="rebate_amount_update_panel"  UpdateMode="Conditional" runat="server">
                    <ContentTemplate>
                    
                    <input name="<%=WebFunc.qsRebate_amountName %>" type="text" id="rebate_amount" size="30" maxlength="30"  style="font-size:7pt"  runat="server"/>

                    <asp:DropDownList ID="rebate_amount4" Font-Size="7pt" 
                            onChange="copyValue(this,this.form.rebate_amount)" runat="server" 
                            onselectedindexchanged="rebate_amount4_SelectedIndexChanged">
                    <asp:ListItem Text="" Value=""></asp:ListItem>
                    </asp:DropDownList>
                        $ 
                    <input name="rebate_amount1" type="text" id="rebate_amount1" size="8" maxlength="10"  style="font-size:7pt" onblur="isNum(this);copy2rebate_amount()" disabled runat="server"/>
                        X 
                    <input name="rebate_amount2" type="text" id="rebate_amount2" size="8" maxlength="10"  style="font-size:7pt" onblur="isNum(this);copy2rebate_amount()" disabled runat="server"/>
                        + $ 
                    <input name="rebate_amount3" type="text" id="rebate_amount3" size="8" maxlength="10"  style="font-size:7pt" onblur="isNum(this);copy2rebate_amount()" disabled runat="server"/>
                    </ContentTemplate>
                    </asp:UpdatePanel>
                     </span></td>
                </tr>
                <tr  id="retention_offer_show" runat="server"> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Retention Offer 續約優惠</span></td>
                  <td height="0" colspan="3" class="row1" nowrap="nowrap">
                  <span class="gensmall" style="font-size:9px"> 
                    
                    <asp:UpdatePanel ID="r_offer4_update_panel" UpdateMode="Conditional" runat="server">
                    <ContentTemplate>

                    <input name="<%=WebFunc.qsR_offerName %>" type="text" id="r_offer" size="30" maxlength="30"  style="font-size:7pt"  runat="server"/>

                    
                    <asp:DropDownList ID="r_offer4" Font-Size="7pt" runat="server" 
                            onChange="copyValue(this,this.form.r_offer)" 
                            onselectedindexchanged="r_offer4_SelectedIndexChanged">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList> $ 
                    <input name="r_offer1" type="text" id="r_offer1" size="8" maxlength="10"  style="font-size:7pt" onblur="isNum(this);copy2r_offer();update_amount()" disabled runat="server"/>
                        + $ 
                    <input name="r_offer2" type="text" id="r_offer2" size="8" maxlength="10"  style="font-size:7pt" onblur="isNum(this);copy2r_offer();update_amount()" disabled runat="server"/>
                        
                    </ContentTemplate>
                  </asp:UpdatePanel>
                  </span>
                  <span  style="font-size:9px; color:Red">(HS Price + Prepayement)</span>
                    </td>
                </tr>
                <tr  id="exta_rebate_amount_show" runat="server"> 
                  <td height="0" class="row2">
                  <span class="explaintitle" style="font-size:7pt">Extra Rebate Amount 額外回贈總額</span>
                  </td>
                  <td height="0" colspan="3" class="row1" nowrap="nowrap">
                  <span class="gensmall" style="font-size:9px"> 
                    <table id="extra_rebate_amount4_tbl" cellpadding="0" cellspacing="0" border="0" >
                    <tr>
                    <td>
                    <asp:UpdatePanel ID="extra_rebate_amount4_update_panel" UpdateMode="Conditional" runat="server">
                    <ContentTemplate>

                    <input name="<%=WebFunc.qsExtra_rebate_amountName %>" type="text" id="extra_rebate_amount" size="30" maxlength="30"  style="font-size:7pt"  runat="server"/>

                    
                    <asp:DropDownList ID="extra_rebate_amount4"  runat="server" Font-Size="7pt" 
                            onChange="copyValue(this,this.form.extra_rebate_amount)" 
                            onselectedindexchanged="extra_rebate_amount4_SelectedIndexChanged">
                    <asp:ListItem Text="" Value=""></asp:ListItem>
                    </asp:DropDownList>
                    </ContentTemplate>
                      </asp:UpdatePanel>
                    </td>
                    <td>
                    <asp:UpdatePanel ID="update_panel_extra_rebate" runat="server">
                    <ContentTemplate>
                    <span class="gensmall" style="font-size:7pt"> $ 
                    <input runat="server" name="extra_rebate_amount1" type="text" id="extra_rebate_amount1" size="8" maxlength="10"  style="font-size:7pt" onblur="isNum(this);update_extra_rebate();copy2extra_rebate()" disabled/>
                        X 
                    <input runat="server" name="extra_rebate_amount2" type="text" id="extra_rebate_amount2" size="8" maxlength="10"  style="font-size:7pt" onblur="isNum(this);update_extra_rebate();copy2extra_rebate()" disabled/>
                        + $ 
                    <input runat="server" name="extra_rebate_amount3" type="text" id="extra_rebate_amount3" size="8" maxlength="10"  style="font-size:7pt" onblur="isNum(this);update_extra_rebate();copy2extra_rebate()" disabled/>
                    </span>
                    </ContentTemplate>
                    </asp:UpdatePanel>
                    </td>
                    </tr>
                    </table>
                    </span>
                    </td>
                </tr>
                <tr id="extra_rebate_show" runat="server"> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Extra 
                      Rebate 額外回贈<br>
                    </span></td>
                  <td height="0" colspan="3" class="row1"><span class="gensmall" style="font-size:9px"> 
                    </span><span class="gensmall" style="font-size:7pt"> </span><span class="gensmall" style="font-size:9px"> 
                    </span><span class="gensmall" style="font-size:7pt"> </span><span class="gensmall" style="font-size:9px"> 
                    <asp:UpdatePanel ID="extra_rebate4_update_panel" runat="server">
                    <ContentTemplate>
                    <asp:DropDownList ID="extra_rebate4" Font-Size="7pt" runat="server" 
                            onChange="copyValue(this,this.form.extra_rebate)" 
                            onselectedindexchanged="extra_rebate4_SelectedIndexChanged">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>

                    
                    </span><span class="gensmall" style="font-size:7pt"> $ 
                    <input name="<%=WebFunc.qsExtra_rebateName %>" type="text" id="extra_rebate" size="8" maxlength="10"  style="font-size:7pt" onblur="isNum(this);" runat="server" />
                    </span><span class="gensmall" style="font-size:9px"> </span><span class="gensmall" style="font-size:7pt"> 
                    </span><span class="gensmall" style="font-size:9px"> </span>
                    
                    </ContentTemplate>
                  </asp:UpdatePanel>
                    
                    </td>
                </tr>
                 <tr  id="cancel_auto_renewal_show" runat="server"> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">
                      Cancel Auto Renewal 取消自動續約<br>
                    </span></td>
                  <td height="27" colspan="3" class="row1">
                  
                  <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                    <ContentTemplate>
                  <span class="gensmall" style="font-size:7pt"> 
                    <input type="radio" name="<%=WebFunc.qsCancel_renewName %>" id="cancel_renew_0" value="Y" runat="server"/>
                        Y 
                    <input type="radio" name="<%=WebFunc.qsCancel_renewName %>" id="cancel_renew_1" value="NIL" checked runat="server" />
                        NIL </span>
                    </ContentTemplate>
                  </asp:UpdatePanel>
                    </td>
                </tr>
                
                <tr id="go_wireless_show" runat="server"> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">GO 
                      Wireless<br>
                    </span></td>
                  <td height="27"  class="row1">
                  <input name="org_go_wireless" type="text" id="org_go_wireless" runat="server" size="50" maxlength="100" readonly/> 
                  <asp:DropDownList ID="go_wireless" AppendDataBoundItems="true" runat="server" 
                          onselectedindexchanged="go_wireless_SelectedIndexChanged" onchange="LoadGetSimMrt();wireless();">
                  <asp:ListItem Text="NO" Value="NO"></asp:ListItem>
                  <asp:ListItem Text="$38 (30mth-Contract)" Value="$38 (30mth-Contract)" ></asp:ListItem>
                  <asp:ListItem Text="$0 (24mth-Contract)" Value="$0 (24mth-Contract)" ></asp:ListItem>
                  </asp:DropDownList>
                 
                 
                 <input id="release_sim_mrt" type="button" name="release_sim_mrt" value="Release" class="mainoption"  onclick="ajax_del_mrt()" runat="server"/>
  				 <input type="text" name="sim_mrt" id="sim_mrt"  value="" size="9"  runat="server" readonly="readonly"/>
  				 <img src="images/loading.gif" name="load_get_sim_mrt" id="load_get_sim_mrt" style="display:none" />
				  </td>
				  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">
                      Preferred Languages<br>
                    </span></td>
                  <td height="0" class="row1"><span class="gensmall" style="font-size:9px">
                  

                  
                   <asp:RadioButtonList ID="preferred_languages"  RepeatDirection="Horizontal" CssClass="highlightrow" runat="server" AppendDataBoundItems="true" Enabled=false   >
                  <asp:ListItem Text="CHINESE" Value="CHINESE" Selected="True"></asp:ListItem>
                  <asp:ListItem Text="ENGLISH" Value="ENGLISH"></asp:ListItem>
                  </asp:RadioButtonList>
                  
				 
                    </span></td>

                </tr>
				
				<tr  id="register_address_show" runat="server"> 
                  <td height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">
                      Register Address<br>
                    </span></td>
                  <td height="27" colspan="3" class="row1"> 
				   <input type="text" name="register_address" id="register_address" style="font-size:7pt" size="150" maxlength="200"  onblur="chg_upper(this)" runat="server"/>
				  </td>
                </tr>
                <tr  id="free_gift_description_show" runat="server"> 
                  <td height="27" class="row2"><span class="explaintitle" style="font-size:7pt">Free 
                      Gift Description 免費禮品評術<br>
                    </span></td>
                  <td height="27" colspan="3" class="row1"> 
                  
                  <asp:UpdatePanel ID="UpdatePanel29" runat="server">
                    <ContentTemplate>
                  <asp:DropDownList ID="DropDownList1" Font-Size="7pt" runat="server" 
                          onChange="copyValue(this,this.form.gift_desc);ch_g_code(this,this.form.gift_code);ch_g_type(this.form.gift_code,1)" 
                          runat="server" 
                          onselectedindexchanged="gift_desc1_SelectedIndexChanged">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>

                    <span class="gensmall" style="font-size:9px"> 
                    <input type="text" name="<%=WebFunc.qsGift_descName %>" id="Text1" style="font-size:7pt" size="50" maxlength="50" readonly runat="server"/>
                    </span> 
                    
                    </ContentTemplate>
                  </asp:UpdatePanel>
                    </td>
                </tr>
                
                <tr> 
                  <td height="27" class="row2"><span class="explaintitle" style="font-size:7pt">Free 
                      Gift Description 免費禮品評術<br>
                    </span></td>
                  <td height="27" colspan="3" class="row1"> 
                  
                  <asp:UpdatePanel ID="update_panel_gift_desc1" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                  <asp:DropDownList ID="gift_desc1" Font-Size="7pt" runat="server" AppendDataBoundItems="true" 
                          onChange="copyValue(this,this.form.gift_desc);ch_g_code(this,this.form.gift_code);ch_g_type(this.form.gift_code,1)" 
                          onselectedindexchanged="gift_desc1_SelectedIndexChanged">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>
                  

                    
                    <span class="gensmall" style="font-size:9px"> 
                    <input type="text" name="<%=WebFunc.qsGift_descName %>" id="gift_desc" style="font-size:7pt" size="50" maxlength="50" readonly runat="server"/>
                    </span> 
                    
                    </ContentTemplate>
                  </asp:UpdatePanel>
                    </td>
                </tr>
                <tr> 
                
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Free 
                      Gift Code 免費禮品條碼<br/>
                    </span></td>
                  <td height="0" class="row1"> 
                  
 <asp:UpdatePanel ID="update_panel_gift_code" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                  <input name="<%=WebFunc.qsGift_codeName %>" type="text" id="gift_code" style="font-size:7pt" size="10" maxlength="10" readonly runat="server"/> 
                    <span class="gensmall" style="font-size:9px"> 
                    <input runat="server" type="button" name="submit2325" id="submit2325" value="?" class="mainoption"  onclick="check_remain(document.getElementById('form1').gift_code.value)"  style="font-size:7pt"/>
                    <input runat="server" id="get_gift_imei" type="button" name="submit2322" value="Get Quota" class="mainoption"  onclick="check_gift(document.getElementById('form1').gift_code.value,'gift_imei','gift_desc1');"  style="font-size:7pt"/>
                    <input runat="server" id="r_gift_imei" type="button" name="submit2322" value="Release" class="mainoption"  onclick="check_r_gift(document.getElementById('form1').gift_code.value,'gift_imei','gift_desc1',document.getElementById('form1').gift_imei.value);document.getElementById('form1').gift_code.value='';document.getElementById('form1').gift_desc.value=''; "  style="font-size:7pt;display:none" disabled />
                    </span>
</ContentTemplate>
                    
                      </asp:UpdatePanel>
                  
                     </td>
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Free 
                      Gift IMEI<br/>
                    </span></td>
                  <td height="0" class="row1">
                  <asp:UpdatePanel ID="update_panel_gift_imei" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                  <span class="gensmall" style="font-size:9px"> 
                    <input type="text" name="<%=WebFunc.qsGift_imeiName %>" id="gift_imei" style="font-size:7pt" size="20" maxlength="30" readonly runat="server"/>
                    </span>
                    
                    </ContentTemplate>
                    
                      </asp:UpdatePanel>
                    </td>
                    
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Free Gift Description2 免費禮品評術2
                    </span></td>
                  <td height="0" colspan="3" class="row1"> 
                                    <asp:UpdatePanel ID="update_panel_gift_desc21" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                    
                  <asp:DropDownList ID="gift_desc21" Font-Size="7pt" AppendDataBoundItems="true" 
                          onChange="copyValue(this,this.form.gift_desc2);ch_g_code(this,this.form.gift_code2);ch_g_type(this.form.gift_code2,2)" 
                          runat="server"  
                          onselectedindexchanged="gift_desc21_SelectedIndexChanged">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>

                    
                    <span class="gensmall" style="font-size:9px"> 
                    <input type="text" name="<%=WebFunc.qsGift_desc2Name %>" id="gift_desc2" style="font-size:7pt" size="50" maxlength="50" readonly runat="server"/>
                    </span> 
                    </ContentTemplate>
                  </asp:UpdatePanel>
                    
                    
                    
                    </td>
                </tr>
                <tr> 
               
                  <td height="0" class="row2">
               
                  <span class="explaintitle" style="font-size:7pt">Free Gift Code2 免費禮品條碼2</span></td>
                  <td height="0" class="row1"> 
                   <asp:UpdatePanel ID="update_panel_gift_code2" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                  <input name="<%=WebFunc.qsGift_code2Name %>" type="text" id="gift_code2" style="font-size:7pt" size="10" maxlength="10" readonly=readonly runat="server"/> 
                    <span class="gensmall" style="font-size:9px"> 
                    <input runat="server" type="button" name="submit23252" id="submit23252" value="?" class="mainoption"  onclick="check_remain(document.getElementById('form1').gift_code2.value)"  style="font-size:7pt"/>
                    </span> <span class="gensmall" style="font-size:9px"> 
                    <input runat="server" id="get_gift_imei2" type="button" name="submit2323" value="Get Quota" class="mainoption"  onclick="check_gift(document.getElementById('form1').gift_code2.value,'gift_imei2','gift_desc21');"  style="font-size:7pt"/>
                    <input runat="server" id="r_gift_imei2" type="button" name="submit23232" value="Release " class="mainoption"  onclick="check_r_gift(document.getElementById('form1').gift_code2.value,'gift_imei2','gift_desc21',document.getElementById('form1').gift_imei2.value);document.getElementById('form1').gift_code2.value='';document.getElementById('form1').gift_desc2.value='';" style="font-size:7pt;display:none" disabled />
                    </span> 
                    </ContentTemplate>
                    </asp:UpdatePanel>
                    
                    </td>
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Free 
                      Gift 2 IMEI</span></td>
                  <td height="0" class="row1">
                  
                  <asp:UpdatePanel ID="update_panel_gift_imei2" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                  <span class="gensmall" style="font-size:9px"> 
                    <input type="text" name="<%=WebFunc.qsGift_imei2Name %>" id="gift_imei2" style="font-size:7pt" size="20" maxlength="30" readonly runat="server"/>
                    </span>
                    
                    </ContentTemplate>
                    </asp:UpdatePanel>
                    </td>
                    
                    
                     
                </tr>
                <tr  style="display:none" > 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Free Gift Description3 免費禮品評術3
                    </span></td>
                  <td height="0" colspan="3" class="row1"> 

                  <asp:UpdatePanel ID="update_panel_gift_desc31" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                  <asp:DropDownList ID="gift_desc31" Font-Size="7pt" AppendDataBoundItems="true" 
                          onChange="copyValue(this,this.form.gift_desc3);ch_g_code(this,this.form.gift_code3);ch_g_type(this.form.gift_code3,3)" 
                          runat="server"  
                          onselectedindexchanged="gift_desc31_SelectedIndexChanged">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>

                    
                     <span class="gensmall" style="font-size:9px"> 
                    <input type="text" name="<%=WebFunc.qsGift_desc3Name %>" id="gift_desc3" style="font-size:7pt" size="50" maxlength="50" readonly runat="server"/>
                    </span>
                    
                    </ContentTemplate>
                    </asp:UpdatePanel>
                    
                     </td>
                </tr>
                <tr  style="display:none" > 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Free 
                      Gift Code3 免費禮品條碼3<br>
                    </span></td>
                  <td height="0" class="row1"> 
                  <asp:UpdatePanel ID="update_panel_gift_code3" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                  <input runat="server" name="<%=WebFunc.qsGift_code3Name %>" type="text" id="gift_code3" style="font-size:7pt" size="10" maxlength="10" readonly/> 
                    <span class="gensmall" style="font-size:9px"> 
                    <input id="Button3" runat="server" type="button" name="submit23252"  value="?" class="mainoption"  onclick="check_remain(document.getElementById('form1').gift_code3.value)"  style="font-size:7pt"/>
                    </span> <span class="gensmall" style="font-size:9px"> 
                    <input runat="server" id="get_gift_imei3" type="button" name="submit2323" value="Get Quota" class="mainoption"  onclick="check_gift(document.getElementById('form1').gift_code3.value,'gift_imei3','gift_desc31');"  style="font-size:7pt"/>
                    <input runat="server" id="r_gift_imei3" type="button" name="submit23232" value="Release " class="mainoption"  onclick="check_r_gift(document.getElementById('form1').gift_code3.value,'gift_imei3','gift_desc31',document.getElementById('form1').gift_imei3.value);document.getElementById('form1').gift_code3.value='';document.getElementById('form1').gift_desc3.value='';" style="font-size:7pt;display:none" disabled />
                    </span> 
                    </ContentTemplate>
                    </asp:UpdatePanel>
                    
                    </td>
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Free 
                      Gift 3 IMEI</span></td>
                  <td height="0" class="row1">
                  
                  
                  <span class="gensmall" style="font-size:9px"> 
                  <asp:UpdatePanel ID="update_panel_gift_imei3" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                    <input type="text" name="<%=WebFunc.qsGift_imei3Name %>" id="gift_imei3" style="font-size:7pt" size="20" maxlength="30" readonly runat="server"/>
                    </ContentTemplate>
                    </asp:UpdatePanel>
                    </span>
                    
                    </td>
                </tr>
                <tr  style="display:none" > 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Free 
                      Gift Description4 免費禮品評術4<br>
                    </span></td>
                  <td height="0" colspan="3" class="row1"> 
                  <asp:UpdatePanel ID="update_panel_gift_desc41" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                  <asp:DropDownList ID="gift_desc41" runat="server" UpdateMode="Conditional"  Font-Size="7pt" AppendDataBoundItems="true" 
                          onChange="copyValue(this,this.form.gift_desc4);ch_g_code(this,this.form.gift_code4);ch_g_type(this.form.gift_code4,4)" 
                           onselectedindexchanged="gift_desc41_SelectedIndexChanged">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>

                    
                    <span class="gensmall" style="font-size:9px"> 
                    <input type="text" name="<%=WebFunc.qsGift_desc4Name %>" id="gift_desc4" style="font-size:7pt" size="50" maxlength="50" readonly runat="server"/>
                    </span> 
                    </ContentTemplate>
                    </asp:UpdatePanel>
                    
                    </td>
                </tr>
                <tr  style="display:none" > 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Free 
                      Gift Code4 免費禮品條碼4<br>
                    </span></td>
                  <td height="0" class="row1"> 
                   <asp:UpdatePanel ID="update_panel_gift_code4" runat="server" UpdateMode="Conditional" >
                    <ContentTemplate>
                  <input name="<%=WebFunc.qsGift_code4Name %>" type="text" id="gift_code4" style="font-size:7pt" size="10" maxlength="10" readonly runat="server"/> 
                    <span class="gensmall" style="font-size:9px"> 
                    <input type="button" name="submit23252" id="submit232521" value="?" class="mainoption"  onclick="check_remain(document.getElementById('form1').gift_code4.value)"  style="font-size:7pt" runat="server"/>
                    </span> <span class="gensmall" style="font-size:9px"> 
                    <input id="get_gift_imei4" runat="server"  type="button" name="submit2323" value="Get Quota" class="mainoption"  onclick="check_gift(document.getElementById('form1').gift_code4.value,'gift_imei4','gift_desc41');"  style="font-size:7pt" runat="server"/>
                    <input id="r_gift_imei4" runat="server"  type="button" name="submit23232" value="Release " class="mainoption"  onclick="check_r_gift(document.getElementById('form1').gift_code4.value,'gift_imei4','gift_desc41',document.getElementById('form1').gift_imei4.value);document.getElementById('form1').gift_code4.value='';document.getElementById('form1').gift_desc4.value='';" style="font-size:7pt;display:none" disabled runat="server" />
                    </span> 
                    </ContentTemplate>
                    </asp:UpdatePanel>
                    
                    </td>
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Free 
                      Gift 4 IMEI</span></td>
                  <td height="0" class="row1">
                  <asp:UpdatePanel ID="update_panel_gift_imei4" runat="server" UpdateMode="Conditional" >
                    <ContentTemplate>
                  <span class="gensmall" style="font-size:9px"> 
                    <input type="text" name="<%=WebFunc.qsGift_imei4Name %>" id="gift_imei4" style="font-size:7pt" size="20" maxlength="30" readonly runat="server"/>
                    </span>
                    </ContentTemplate>
     
                    </asp:UpdatePanel>
                    </td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">
                      Accessory Description 配件評術<br>
                    </span></td>
                  <td height="0" colspan="3" class="row1"> 
                  <asp:UpdatePanel ID="update_panel_accessory_desc1"  UpdateMode="Conditional" runat="server">
                    <ContentTemplate>
                  <asp:DropDownList ID="accessory_desc1" runat="server" Font-Size="7pt" AppendDataBoundItems="true"  AutoPostBack="true"
                          onChange="copyValue(this,this.form.accessory_desc);ch_a_code(this);check_hs_model();" 
                          onselectedindexchanged="accessory_desc1_SelectedIndexChanged">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>
                  
                    
                    <span class="gensmall" style="font-size:9px"> 
                    <input type="text" name="<%=WebFunc.qsAccessory_descName %>" id="accessory_desc" style="font-size:7pt" size="50" maxlength="50" readonly runat="server"/>
                         Waive Pre-payment
                    <asp:CheckBox ID="accessory_waive" runat="server" onclick="AccessoryWaive()" AutoPostBack="true" 
                            oncheckedchanged="accessory_waive_CheckedChanged" />
                            </span> 
                    
                    </ContentTemplate>
                    </asp:UpdatePanel>
                    </td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">
                      Accessory Code 配件條碼</span></td>
                  <td height="0" class="row1"> 
                  <asp:UpdatePanel ID="update_panel_accessory_code" UpdateMode="Conditional" runat="server">
                    <ContentTemplate>
                  <input runat="server" name="<%=WebFunc.qsAccessory_codeName %>" type="text" id="accessory_code" style="font-size:7pt" size="10" maxlength="10" readonly/> 
                    <span class="gensmall" style="font-size:9px"> 
                    <input runat="server" type="button" name="submit23253" id="submit23253" value="?" class="mainoption"  onclick="check_remain(document.getElementById('form1').accessory_code.value)"  style="font-size:7pt"/>
                    <input runat="server" id="get_accessory_imei" type="button" name="submit2324" value="Get Quota" class="mainoption"  onclick="check_gift(document.getElementById('form1').accessory_code.value,'accessory_imei','accessory_desc1');"  style="font-size:7pt"/>
                    <input runat="server" id="r_accessory_imei" type="button" name="submit23242" value="Release" class="mainoption"  onclick="check_r_gift(document.getElementById('form1').accessory_code.value,'accessory_imei','accessory_desc1',document.getElementById('form1').accessory_imei.value);document.getElementById('form1').accessory_code.value='';document.getElementById('form1').accessory_desc.value='';document.getElementById('form1').total_amount.value=document.getElementById('form1').amount.value;document.getElementById('form1').accessory_price.value='0';"  style="font-size:7pt;display:none" disabled=disabled />
                    </span> 
                    </ContentTemplate>
                    </asp:UpdatePanel>
                    </td>
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">
                      Accessory IMEI</span></td>
                  <td height="0" class="row1"><span class="gensmall" style="font-size:9px"> 
                    <asp:UpdatePanel ID="update_panel_accessory_imei" UpdateMode="Conditional" runat="server">
                    <ContentTemplate>
                    <input type="text" name="<%=WebFunc.qsAccessory_imeiName %>" id="accessory_imei" style="font-size:7pt" size="20" maxlength="30" readonly runat="server" />
                    </span>
                    </ContentTemplate>
                    </asp:UpdatePanel>
                    </td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Price 
                      of Accessory 配件價金額<br>
                    </span></td>
                  <td height="0" colspan="3" class="row1"> <span class="gensmall" style="font-size:7pt"> 
                      $ 
                    <input name="<%=WebFunc.qsAccessory_priceName %>" type="text" id="accessory_price" size="8" maxlength="10"  style="font-size:7pt" value="0" readonly runat="server"/>
                    </span>
                    </td>
                </tr>
                <tr id="aig_gift_show" style="display:none" runat="server"> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">AIG 
                      Free Gift</span></td>
                  <td height="0" colspan="3" class="row1"><span class="gensmall" style="font-size:9px"> 
                    <asp:UpdatePanel ID="UpdatePanel23" runat="server">
                    <ContentTemplate>
                    <asp:DropDownList ID="aig_gift" runat="server" Font-Size="7pt" onChange="" 
                          onselectedindexchanged="aig_gift_SelectedIndexChanged">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>

                    </ContentTemplate>
                    </asp:UpdatePanel>
                    
                    </span></td>
                </tr>
                </table>
				
				
				
			  </td>
              </tr>
            </table>

<table border="0" id="TBL3" width="100%" style="margin:0px 0px 0px 0px;">
              <tr>
                <td>
				
				
				
				
				
				
            
                <table id="no_suspend2" width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <td height="0" class="row3" colspan="4"><span class="explaintitle" style="font-size:7pt">
                      VAS 
                    </span></td>
                </tr>      

				<tr>
				<td class="row3" colspan="4" id="giftheight" valign="top" runat="server">
				<table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
				  
				<asp:Literal ID="GiftHtmlVasCreate_Literal" runat="server"></asp:Literal>

				</table>
				</td>
				</tr>

                <tr style="display:none"> 
                  <td width="25%" height="27"  class="row2"><span class="explaintitle" style="font-size:7pt">
                      Early Start</span></td>
                  <td height="27" colspan="3" class="row1"> <input runat="server" type="checkbox" name="fast_start" id="fast_start" value="Y" onclick="ch_con_eff_date(this)" />                  </td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" >VAS Effective Date 增值服務生效期</span></td>
                  <td height="0" class="row1" colspan="3"> 
					<asp:UpdatePanel ID="updatepanel_vas_eff_date" runat="server">
                    <ContentTemplate> 
					<span class="gensmall" > 
                    <asp:Literal ID="vas_eff_date" runat="server" Text=""></asp:Literal>
                    </span> 
					</ContentTemplate>
					</asp:UpdatePanel>
					</td>
                </tr>
                
                
               <tr id="contract_effective_date_show" runat="server"> 
                  <td width="25%" height="0" class="row2"><span class="explaintitle" style="font-size:7pt">
                      Contract Effective Date 合約生效期<br>
                    </span></td>
                    
                  <td height="0" colspan="2" class="row1">
					<asp:UpdatePanel ID="updatepanel_con_eff_date_flag" runat="server">
					<ContentTemplate> 
					<asp:Label ID="con_eff_date_flag" runat="server"></asp:Label>

                  <input runat="server" class="highlightrow" name="<%=WebFunc.qsCon_eff_dateName %>" id="con_eff_date" type="text"  style="font-size:7pt" size="12" maxlength="10" onchange="chk_date2(this,0,0);vaild_con_date();" onfocus="showCalendarControl(this,'vaild_con_date_by_calendar();');" />
                    <span id="next_bill_label" style="display:none" runat="server">Next Bill Cut Date</span>
                    <span class="gensmall" style="font-size:9px">(DD/MM/YYYY)</span>
					</ContentTemplate>
					</asp:UpdatePanel>
					</td>
                    
                    <td height="0" colspan="1" class="row1">
					<div id="div_next_bill" runat="server"><span class="gensmall" style="font-size:7pt;"> 
					<asp:UpdatePanel ID="updatepanel_next_bill" runat="server">
					<ContentTemplate> 
					<input type="checkbox" name="<%=WebFunc.qsNext_billName %>" id="next_bill" value="on" onClick="hideCalendarControl();click_nextbillcutdate('click');AutoSetConEffDate();" runat="server"/>Next 
                        Bill Cut Date
					</ContentTemplate>
					</asp:UpdatePanel>
				</span></div> 
				
				
				</td>
                </tr>
                <tr id="plan_eff_show" runat="server"> 
                  <td width="25%" height="0" class="row2"><span class="explaintitle" style="font-size:7pt">
                      Rate Plan Effective Date</span></td>
                  <td height="0" colspan="3" class="row1" nowrap="nowrap"> <span class="gensmall" style="font-size:7pt"> 
					<asp:UpdatePanel ID="updatepanel_plan_eff_flag" runat="server">
					<ContentTemplate> 
					<asp:Label ID="plan_eff_flag" runat="server" runat="server"></asp:Label>
                    <asp:RadioButtonList ID="plan_eff" runat="server"  RepeatDirection="Horizontal"  AppendDataBoundItems="true">
                    <asp:ListItem Text="Next Bill Date" Value="NBD" Selected="True" onclick="hideCalendarControl();en_plan_date(this.value);AutoSetConEffDate();" style="font-size:7pt"></asp:ListItem>
                    <asp:ListItem Text="Other" Value="OTHER" onclick="hideCalendarControl();en_plan_date(this.value)" style="font-size:7pt"></asp:ListItem>
                    </asp:RadioButtonList>
					</ContentTemplate>
					</asp:UpdatePanel>
					
                    <input id="plan_eff_date" name="<%=WebFunc.qsPlan_eff_dateName %>" type="text" runat="server" style="font-size:7pt" size="12" maxlength="10" onblur="chk_date2(this,0,0);vaild_plan_date();UpgradOrderPlanEffDateChange()"  class="disablerow" disabled="disabled" onfocus="showCalendarControl(this,'vaild_plan_date_by_calendar();');"/>

					  (DD/MM/YYYY)</span> </td>
                </tr>
				
				<tr id="bill_cut_show" runat="server"> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Bill Cut Date<br>
                    </span></td>
					<td height="0" colspan="3" class="row1" nowrap="nowrap">
					<asp:UpdatePanel ID="updatepanel_bill_cut_date" runat="server">
					<ContentTemplate> 					
					<input class="highlightrow" name="bill_cut_date" type="text" id="bill_cut_date" size="12" maxlength="10" readonly="readonly" onchange="ValidBillCutDate();" runat="server"/> 
					</ContentTemplate>
					</asp:UpdatePanel>
                    <span style="font-size:9px">(DD/MM/YYYY)</span>
                    <div id="div1"><span > 
                    
                    <asp:UpdatePanel ID="updatepanel_bill_cut_num" runat="server">
					<ContentTemplate> 	
					<select name="bill_cut_num"  id="bill_cut_num" onchange="hideCalendarControl();AutoSetBillCutDate();AutoSetConEffDate();UpgradOrderPlanEffDateChange();ActionOfRatePlanEffectiveChange()" runat="server">
                      <option value=""> </option>
                      <option value="6"> 6 </option>
                      <option value="9"> 9 </option>
                      <option value="13"> 13 </option>
                      <option value="16"> 16 </option>
                      <option value="23"> 23 </option>
                    </select>
                    </ContentTemplate>
					</asp:UpdatePanel>
                    </span>
                    </div>
					
				 </td>
                    
                </tr>
                
                <tr id="action_of_rate_plan_effective_show" runat="server" style="display:none"> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Action Of Rate Plan Effective</span></td>
                  <td height="0" colspan="3" class="row1"> 
                     <asp:DropDownList ID="action_of_rate_plan_effective" onchange="ActionOfRatePlanEffectiveChange()" AppendDataBoundItems="true" runat="server">
                     <asp:ListItem Text="" Value=""></asp:ListItem> 
                     <asp:ListItem Text="START ON NEXT BILL DATE" Value="START ON NEXT BILL DATE"></asp:ListItem> 
                     <asp:ListItem Text="START ON CONTRACT EFFECTIVE DATE" Value="START ON CONTRACT EFFECTIVE DATE"></asp:ListItem> 
                     </asp:DropDownList>
                  </td>
                </tr>
				
				<tr id="cooling_offer_show" runat="server"> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Cooling 
                      Offer</span></td>
                  <td height="0" colspan="3" class="row1"> <span class="gensmall" style="font-size:7pt"> 
                    <input type="checkbox" name="<%=WebFunc.qsCooling_offerName %>" id="cooling_offer" value="YES" onClick="click_cooling()" runat="server"/>YES</span> </td>
                </tr>
                <tr id="snd_contract_effective_show" style="display:none" runat="server" > 
                  <td height="0" class="row2"><span  class="explaintitle" style="font-size:7pt">2nd 
                      Contract Effective Date</span></td>
                  <td height="0" colspan="3" class="row1"> 
                   <span  style="font-size:10pt">
                   <input runat="server" name="<%=WebFunc.qsCooling_dateName %>" id="cooling_date" type="text"  style="font-size:10pt" size="12" maxlength="10" onchange="chk_date2(this,0,0);" onfocus="showCalendarControl(this,'');" />
                   </span>
                </tr>
				<tr id="monthly_payment_method_show" runat="server"> 
                <td width="25%" height="0" class="row3" colspan="4"><span class="explaintitle" style="font-size:7pt">
                    Monthly Payment Type </span></td>
                </tr>
                <tr id="monthly_payment_type_show" runat="server"> 
                  <td width="25%" height="0" class="row2"><span class="explaintitle" style="font-size:7pt">
                      Monthly Payment Type </span></td>
                  <td height="0" colspan="3" class="row1"><span class="gensmall" style="font-size:7pt"> 
				  <asp:UpdatePanel ID="update_panel_monthly_payment_method" runat="server"  UpdateMode="Conditional">
                    <ContentTemplate>
                    <asp:DropDownList ID="monthly_payment_type" onchange="MonthlyPaymentTypeChange()" runat="server" AppendDataBoundItems="true">
                    <asp:ListItem Text="" Value=""></asp:ListItem>
                    <asp:ListItem Text="KEEP EXISTING COD" Value="KEEP EXISTING COD"></asp:ListItem>
                    <asp:ListItem Text="KEEP EXISTING CREDIT CARD" Value="KEEP EXISTING CREDIT CARD"></asp:ListItem>
                    <asp:ListItem Text="KEEP EXISTING BANK ACCOUNT" Value="KEEP EXISTING BANK ACCOUNT"></asp:ListItem>
                    <asp:ListItem Text="CHANGE TO COD" Value="CHANGE TO COD"></asp:ListItem>
                    <asp:ListItem Text="CHANGE TO CREDIT CARD" Value="CHANGE TO CREDIT CARD"></asp:ListItem>
                    <asp:ListItem Text="CHANGE TO BANK ACCOUNT" Value="CHANGE TO BANK ACCOUNT"></asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <span style="display:none">
				  <input type="radio"  style="display:none" name="monthly_payment_method" id="monthly_payment_method_0" value="keep_existing_payment_method"  checked onclick="MonthlyPayment(this.value)" runat="server"/>Keep 
                        Existing Payment Method 
				  <input type="radio"  style="display:none" name="monthly_payment_method" id="monthly_payment_method_1"  value= "change_payment_method" onclick="MonthlyPayment(this.value)" runat="server" />Change 
                        Payment Method
                        </span>
				</ContentTemplate>
				  	  </asp:UpdatePanel>
				  	  </span> </td>
                </tr>
                <tr id="change_payment_type_show"  style="display:none" class="change_payment_type_show" runat="server">
                <td width="25%" height="0" class="row2"><span class="explaintitle" style="font-size:8pt">
                    Change Payment Type</span></td>
                <td height="0" colspan="3" class="row1">
                      <asp:UpdatePanel ID="update_panel_change_payment_type" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                      <span  style="font-size:8pt" class="change_payment_type_span explaintitle" > 
				  	  <input type="radio" name="change_payment_type" class="change_payment_type" id="change_payment_type_0" value="COD"  onclick="ChangePaymentType(this.value,true)" runat="server"/>COD
				  	  <input type="radio" name="change_payment_type" class="change_payment_type" id="change_payment_type_1"  value= "CREDIT CARD" onclick="ChangePaymentType(this.value,true)" runat="server"/>CREDIT 
                        CARD
					  <input type="radio" name="change_payment_type" class="change_payment_type" id="change_payment_type_2" value="BANK ACCOUNT" onclick="ChangePaymentType(this.value,true)" runat="server"/>BANK 
                        ACCOUNT
				  	  </span>
				  	  </ContentTemplate>
				  	  </asp:UpdatePanel>
                   </td>
                </tr>
                <tr id="prepayment_show" class="prepayment_show">
                <td  height="0" class="row2">
                <span class="explaintitle" style="font-size:8pt">
                    Prepayment
                </span>
                </td>
                
                <td  height="0" class="row1">Waive
                <input id="prepayment_waive" name="prepayment_waive" type="checkbox" value="true" checked="checked"  runat="server" />
                </td>
                </tr>
                
                <tr id="credit_card_type_show" runat="server"> 
                  <td width="25%" height="0" class="row2"><span class="explaintitle" style="font-size:7pt">
                      Credit Card Type 信用卡類別<br>
                    </span></td>
                  <td height="0" class="row1"><span class="gensmall" style="font-size:9px"> 
                    </span><span class="gensmall" > </span><span class="gensmall" style="font-size:9px"> 
                    </span><span class="gensmall" > 
                    
                    

                    <asp:UpdatePanel ID="update_panel_m_card_type" runat="server" UpdateMode="Conditional">
                    <ContentTemplate> 
                    <select  runat="server" name="<%=WebFunc.qsM_card_typeName %>" id="m_card_type" style="font-size:7pt" class="disablerow"  disabled="disabled" >
                      <option value=""></option>
                      <option value="Visa">Visa</option>
                      <option value="MasterCard">MasterCard</option>
                      <option value="AmEx">American Express</option>
                      
                    </select>
					</ContentTemplate>
				  	  </asp:UpdatePanel>
                    </span><span class="gensmall" style="font-size:9px"> </span></td>
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Credit 
                      Card No. </span></td>
                  <td height="0" class="row1"><span class="gensmall" style="font-size:9px"> 
                    </span><span class="gensmall" > </span><span class="gensmall" > 
					<asp:UpdatePanel ID="update_panel_m_card_no" runat="server"  UpdateMode="Conditional">
                    <ContentTemplate> 
                    <asp:TextBox ID="m_card_no" runat="server" Text=""  CssClass="m_card_no" OnBlur="if(!checkCreditCard(document.getElementById('m_card_no').value,document.getElementById('m_card_type').value)){alert('Invalid token!');}" />
                    <input type="button" id="but_m_card_no" runat="server" value="Get Token" disabled="disabled" />
     				</ContentTemplate>
				  	</asp:UpdatePanel>
                    </span>
                    </td>
                </tr>
                <tr id="credit_card_holder_name_show" runat="server"> 
                  <td width="25%" height="0" class="row2">
                  <span class="explaintitle" style="font-size:7pt">
                      Credit Card Holder Name 信用卡持有人姓名
                  </span>
                  </td>
                  <td height="0" class="row1"><span class="gensmall" style="font-size:9px"> 
                    </span><span class="gensmall">
					<asp:UpdatePanel ID="update_panel_m_card_holder2" runat="server" UpdateMode="Conditional">
                    <ContentTemplate> 
                    <input runat="server" name="<%=WebFunc.qsM_card_holder2Name %>" type="text" id="m_card_holder2" class="disablerow"  onblur="chg_upper(this);chk_cc(this);ChkWord(this,true,'Please input word only!')" size="30" maxlength="100"  style="font-size:7pt"  disabled="disabled" />
                    </ContentTemplate>
				  	  </asp:UpdatePanel>
					</span><span class="gensmall" style="font-size:9px"> </span></td>
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Credit 
                      Card Expiry Date </span></td>
                  <td height="0" class="row1"><span class="gensmall" style="font-size:9px"> 
                    </span><span class="gensmall">
                    <asp:UpdatePanel ID="update_panel_m_card_exp" runat="server" UpdateMode="Conditional">
                    <ContentTemplate> 
                     <select  runat="server" name="<%=WebFunc.qsM_card_exp_monthName %>" id="m_card_exp_month" class="disablerow" disabled onblur="valid_thur(this.form.m_card_exp_month.value,this.form.m_card_exp_year.value);" style="font-size:7pt;">
                      <option value=""> </option>
                      <option value="01"> 01 </option>
                      <option value="02"> 02 </option>
                      <option value="03"> 03 </option>
                      <option value="04"> 04 </option>
                      <option value="05"> 05 </option>
                      <option value="06"> 06 </option>
                      <option value="07"> 07 </option>
                      <option value="08"> 08 </option>
                      <option value="09"> 09 </option>
                      <option value="10"> 10 </option>
                      <option value="11"> 11 </option>
                      <option value="12"> 12 </option>
                    </select>
				        /
				    <select runat="server"  name="<%=WebFunc.qsM_card_exp_yearName %>"  id="m_card_exp_year" class="disablerow"  disabled onblur="valid_thur(this.form.m_card_exp_month.value,this.form.m_card_exp_year.value);" style="font-size:7pt">
                      <option value=""> </option>
                      <option value="2008"> 08 </option>
                      <option value="2009"> 09 </option>
                      <option value="2010"> 10 </option>
                      <option value="2011"> 11 </option>
                      <option value="2012"> 12 </option>
                      <option value="2013"> 13 </option>
                      <option value="2014"> 14 </option>
                      <option value="2015"> 15 </option>
                      <option value="2016"> 16 </option>
                      <option value="2017"> 17 </option>
                      <option value="2018"> 18 </option>
                      <option value="2019"> 19 </option>
                      <option value="2020"> 20 </option>
                      <option value="2021"> 21 </option>
                      <option value="2022"> 22 </option>
                      <option value="2023"> 23 </option>
                      <option value="2024"> 24 </option>
                      <option value="2025"> 25 </option>
                    </select>
					</ContentTemplate>
				  	  </asp:UpdatePanel>
                      (MM/YY) </span><span class="gensmall" style="font-size:9px">  
                    </span></td>
                </tr>
			
                <tr id="monthly_3rd_party_credit_card_info_show" class="monthly_3rd_party_credit_card_info_show">
			        <td width="25%" height="0" class="row2">
			          <span class="explaintitle" style="font-size:7pt">3rd party contact number</span>
			          </td>
			          <td height="0" class="row3">
                      <span class="explaintitle" style="font-size:8px"> 
                        <input id="m_3rd_contact_no" name="m_3rd_contact_no" onblur="Chk3rdContactNo();" type="text" runat="server"/>
                      </span>
                  </td>
			          <td height="0" class="row1" nowrap="nowrap" colspan="2">
                      <span class="row1" style="font-size:9px"> 
                        HKID/BR NO/PASSPORT
                        <select name="m_3rd_id_type" id="m_3rd_id_type" onchange="Chk3rdHkid();" style="font-size:8pt"  class="highlightrow" runat="server">
                      	<option value=""></option>
                      	<option value="HKID">HKID</option>
                      	<option value="BRNO">BR No</option>
                      	<option value="PP">Passport</option>
                    	</select>
                    	<input name="m_3rd_hkid" type="text" id="m_3rd_hkid" size="15" maxlength="20" onblur="chg_upper(this);Chk3rdHkid();"   style="font-size:8pt" class="highlightrow" runat="server"/>
                        ( 
                    	<input name="m_3rd_hkid2" type="text" id="m_3rd_hkid2" size="2" maxlength="1" onblur="chg_upper(this);Chk3rdHkid();"  style="font-size:8pt"  class="highlightrow" runat="server"/>
                        ) 
                      </span>
                  </td>
			    </tr>
				<tr id="monthly_bank_account_show" class="monthly_bank_account_show">
			     <td width="25%" height="0" class="row2">
			          <span class="explaintitle" style="font-size:7pt">Account Number 戶口號碼</span>
                  </td>
                  <td height="0" class="row1" colspan=3>
                      <span class="gensmall" style="font-size:9px"> 
                          <table id="Table1" border="0" cellpadding="0" cellspacing="0" runat="server">
                              <tr>
                                  <td align="center">
                                    <input id="monthly_bank_account_bank_code" size="6" maxlength="3" runat="server" type="text" />
                                  </td>
                                  <td align="center">
                                    <input id="monthly_bank_account_branch_code" size="6" maxlength="3" runat="server" type="text" />
                                  </td>
                                  <td align="center">
                                    <input id="monthly_bank_account_no" size="20" maxlength="10" runat="server" type="text" />
                                  </td>
                              </tr>
                              <tr>
                                  <td>
                                      Bank Code
                                  </td>
                                  <td>
                                      Branch Code
                                  </td>
                                  <td>
                                      Account No
                                  </td>
                              </tr>
                          </table>
                      </span>
                  </td>
			    </tr>
			    <tr id="monthly_bank_account_holder_show" class="monthly_bank_account_holder_show">
			        <td width="25%" height="0" class="row2">
			          <span class="explaintitle" style="font-size:7pt">Bank Account Holder Name</span>
					  <input type="button"   name="Button22" value="Copy From>>" class="button" onclick="copy_user3();" />
                  </td>
                  <td height="0" class="row1">
                      <span class="explaintitle" style="font-size:7pt"> 
                        <input id="monthly_bank_account_holder" type="text" runat="server"/>
                      </span>
                  </td>
                  <td height="0" class="row1" nowrap="nowrap" colspan="2">
                      <span class="explaintitle" style="font-size:7pt">
                        HKID/BR NO/PASSPORT
                        <select name="monthly_bank_account_id_type" id="monthly_bank_account_id_type" onChange="chk_id(this);" style="font-size:8pt"  class="highlightrow" runat="server">
                      	<option value=""></option>
                      	<option value="HKID">HKID</option>
                      	<option value="BRNO">BR No</option>
                      	<option value="PP">Passport</option>
                    	</select>
                    	<input name="monthly_bank_account_hkid" type="text" id="monthly_bank_account_hkid" size="15" maxlength="20" onblur="chg_upper(this);chk_id(this);"   style="font-size:8pt" class="highlightrow" runat="server"/>
                        ( 
                    	<input name="monthly_bank_account_hkid2" type="text" id="monthly_bank_account_hkid2" size="2" maxlength="1" onblur="chg_upper(this);chk_id(this);"  style="font-size:8pt"  class="highlightrow" runat="server"/>
                        ) 
                      </span>
                  </td>
			    </tr>
				
                <tr> 
                  <td width="25%" height="0" class="row3" colspan="4"><span class="explaintitle" style="font-size:7pt">
                      ORDER PLACE DETAILS 合約承諾人資料</span></td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Order 
                      Placed By 合約承諾人<br>
                    </span><span class="explaintitle"> 
                    <input type="button" name="Button22" value="Copy From>>" class="button" onclick="copy_user2();" />
                    </span><span class="explaintitle" style="font-size:7pt"> </span></td>
                  <td height="0" colspan="3" class="row1"> 
				  <asp:UpdatePanel ID="updatepanel_Ord_place_by" runat="server">
                    <ContentTemplate> 
				  <input runat="server"  name="<%=WebFunc.qsOrd_place_byName %>" type="text" id="ord_place_by" style="font-size:7pt" size="50" maxlength="100" onblur="chg_upper(this);chk_cc(this)" class="highlightrow"/>                  
				  </ContentTemplate>
					</asp:UpdatePanel>
				  </td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">
                      Relationship 與登記人關係 </span></td>
                  <td height="0" colspan="3" class="row1"><span class="gensmall" style="font-size:7pt"> 
 
                    <asp:UpdatePanel ID="updatepanel_Ord_place_rel" runat="server">
                    <ContentTemplate>  
                    <select  runat="server" name="<%=WebFunc.qsOrd_place_relName %>" id="ord_place_rel" style="font-size:7pt"   class="highlightrow">
                      <option value=""></option>
                      <option value="sub">Sub 本人</option>
                      <option value="secretary">Secretary</option>
                      <option value="parents">Parents 父母</option>
                      <option value="daughter">Daughter 女</option>
                      <option value="son">Son 子</option>
                      <option value="spouse">Spouse 配偶</option>
                    </select>
					</ContentTemplate>
					</asp:UpdatePanel>
                    </span> </td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">HKID 
                      No/ Passport No 香港身份證號碼 /護照號碼<br>
                    </span></td>
                  <td height="0" colspan="3" class="row1"><span class="gensmall" style="font-size:7pt">                     
                    
					<asp:UpdatePanel ID="updatepanel_Ord_place_id_type" runat="server">
                    <ContentTemplate> 
					<select runat="server"  name="<%=WebFunc.qsOrd_place_id_typeName %>" id="ord_place_id_type" onChange="chk_id(this);" style="font-size:7pt"   class="highlightrow" >
                      <option value=""></option>
                      <option value="HKID">HKID</option>
                      <option value="PP">Passport</option>
                    </select>
                    <input runat="server"  name="<%=WebFunc.qsOrd_place_hkidName %>" type="text" id="ord_place_hkid" size="15" maxlength="20" onblur="chg_upper(this);chk_id(this);"   style="font-size:7pt"   class="highlightrow"/>
                        ( 
                    <input runat="server"  name="<%=WebFunc.qsOrd_place_hkid2Name %>" type="text" id="ord_place_hkid2" size="2" maxlength="1" onblur="chg_upper(this);chk_id(this);"  style="font-size:7pt"    class="highlightrow"/>
                        ) 
					  </ContentTemplate>
					</asp:UpdatePanel>
					  </span></td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Contact 
                      No 聯絡電話號碼<br>
                    </span></td>
                  <td height="0" colspan="3" class="row1"> 
				  <asp:UpdatePanel ID="updatepanel_Ord_place_tel" runat="server">
                    <ContentTemplate>  
				  <input runat="server"  name="<%=WebFunc.qsOrd_place_telName %>" type="text" id="ord_place_tel" style="font-size:7pt" size="10" maxlength="8" onblur="chk_telno(this);"   class="highlightrow"/> 
				  </ContentTemplate>
					</asp:UpdatePanel>
				  
				  </td>
                </tr>
                </table>
</td>
</tr>
</table>


<table border="0" id="TBL4" width="100%" style="margin:0px 0px 0px 0px;">
              <tr>
                <td>

                <asp:UpdatePanel ID="update_panel_delivery" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                <table id="no_suspend3" width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                
                <tr> 
                  <td height="0" class="row3" colspan="4">
                  <span class="explaintitle" style="font-size:7pt">
                      DELIVERY INFORMATION 送貨資料
                      </span></td>
                </tr>
                <tr>                
                  <td height="0" class="row2">
                    <span class="explaintitle" style="font-size:7pt">
                      Delivery Address 送貨地址
                    </span>
                    <asp:Button ID="CopyRegisterAddToDeliveryAdd" runat="server" Text="Copy From" CssClass="button" onclick="CopyRegisterAddToDeliveryAdd_Click" />
                    </td>
                  <td height="0" colspan="3" class="row1">
                    <asp:Literal ID="d_address_flag" runat="server"></asp:Literal>
                    <input type="text" name="d_address" id="d_address"  size="100" maxlength="300"  onblur="chg_upper(this);chk_cc(this)"  runat="server"/>
                    </td>
                </tr>
                <tr> 
                  <td height="0" class="row2">
                  <span class="explaintitle" style="font-size:7pt">
                      Delivery Date &amp; Time 送貨日期和時間
                      
                    </span></td>
                  <td width="25%" height="0" class="row1"><span class="gensmall" style="font-size:9px"> 
                    </span><span class="gensmall" style="font-size:7pt"> 

                    </span><span class="gensmall" style="font-size:9px"> </span><span class="gensmall" style="font-size:7pt">
                    <asp:Literal ID="d_date_flag" runat="server"></asp:Literal>
                    
                  <asp:TextBox id="d_date" runat="server" onfocus="showCalendarControl(this,'vaild_sup_date_by_calendar();');"  onblur="chk_date2(this,0,0);vaild_sup_date()" onchange="chk_date2(this,0,0);vaild_sup_date()" ></asp:TextBox>
                  <asp:Literal ID="d_time_flag" runat="server"></asp:Literal>
                  <asp:DropDownList ID="d_time" runat="server" Font-Size="7pt" disablied="disabled" 
                          CssClass="disablerow" onChange="Xmas()" AppendDataBoundItems="true"
                          onselectedindexchanged="d_time_SelectedIndexChanged">
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  </asp:DropDownList>
                  
                  </span>
                    
                    
                      &nbsp;&nbsp;</td>
                  <td width="17%" height="0" class="row2"><span class="explaintitle" style="font-size:7pt">
                      Delivery Charge for special region </span></td>
                  <td width="33%" class="row1">

                  <span class="gensmall" style="font-size:9px">$ 
                  <asp:Literal ID="extra_d_charge_flag" runat="server"></asp:Literal>
                    <input runat="server" type="text" name="<%=WebFunc.qsExtra_d_chargeName %>" class="disablerow" disabled=disabled  id="extra_d_charge" style="font-size:7pt" value="0" size="7" maxlength="5"  onblur="isNum(this);" onChange="add_amount()"/>
                    </span><span class="explaintitle" style="font-size:7pt"> 
                    <input runat="server" name="delivery_ref" type="button" class="button" id="delivery_ref" style="font-size:7pt" value="Delivery Service Appointment Reference" onclick="window.open('DeliveryDescription.aspx','_blank','toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=yes, copyhistory=no, width=700, height=400');"/>
                    </span>

                    <span class="gensmall" style="font-size:9px"> </span></td>
                </tr>
                <user:MobileOrderThreePartyUserControl ID="MobileOrderThreePartyControl" TableTagVisable="false" runat="server"  DrpClass="disablerow" Enabled="true" TitleNameLbl=""
                    TitleFontSize="7"  TdOneClass="row2" TdTwoClass="row1" TxtClass="explaintitle" RblClass="highlightrow" ToolkitScriptManagerID="AddWebLogScriptManager"/>
                
                <tr id="contact_person_show" name="contact_person_show" class="contact_person_show" > 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Contact 
                      Person 聯絡人<br>
                    </span><span class="explaintitle"> 
                    <input type="button" name="Button2" value="Copy From>>" class="button" onclick="copy_user();" />
                    </span><span class="explaintitle"> </span></td>
                  <td height="0" colspan="3" class="row1"><span class="gensmall" style="font-size:9px"> 
                  <asp:Literal ID="contact_person_flag" runat="server"></asp:Literal>
                    <input runat="server" type="text" name="<%=WebFunc.qsContact_personName %>" class="disablerow" disabled  id="contact_person" style="font-size:7pt" size="30" maxlength="100"  onblur="chg_upper(this);chk_cc(this)"/>

                    </span></td>
                </tr>
                <tr id="contact_no_show" name="contact_no_show" class="contact_no_show" > 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Contact 
                      No. 聯絡電話<br>
                    </span><span class="explaintitle"> </span></td>
                  <td height="0" colspan="3" class="row1"><span class="gensmall" style="font-size:9px"> 
                  <asp:Literal ID="contact_no_flag" runat="server"></asp:Literal>
                    <input runat="server" type="text" name="<%=WebFunc.qsContact_noName %>" class="disablerow" disabled  id="contact_no" size="10" maxlength="8"  style="font-size:7pt"  onblur="chk_telno(this);"/>2nd 
                      no.
                    <input runat="server" name="<%=WebFunc.qsExt_place_telName %>"  type="text" id="ext_place_tel" size="10" maxlength="8"  class="disablerow"  style="font-size:7pt" onblur="chk_telno(this);" disabled/>
                    </span>

                    </td>
                
                </tr>
                <tr id="show_third_party" runat="server"> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">3rd 
                      Party Credit Card<br>
                    </span></td>
                  <td height="0" class="row1"><span class="gensmall" style="font-size:9px"> 
                  
                  
                  
					<input type="radio" name="third_party_credit_card" id="third_party_credit_card_0" runat="server"  value="YES"  onclick="third_party()"/>
					  YES
					<input type="radio" name="third_party_credit_card" id="third_party_credit_card_1" runat="server" value="NO" checked onclick="third_party()" />
					  NO</span></td>
					
					
					<td  class="row2">
					<span class="explaintitle" style="font-size:7pt">3rd HKID/BR No/Passport</span>
					</td>
                  <td height="0"  class="row1"><span class="gensmall" style="font-size:7pt"> 
                    <select name="third_party_id_type" id="third_party_id_type" runat="server" onChange="chk_id2(this);" style="font-size:7pt" disabled  class="disablerow">
                      <option value=""></option>
                      <option value="HKID">HKID</option>
                      <option value="BRNO">BR No</option>
                      <option value="PP">Passport</option>
                    </select>
                    <input name="third_party_hkid" type="text" id="third_party_hkid" runat="server" size="15" maxlength="20" onBlur="chg_upper(this);chk_id2(this);"   style="font-size:7pt" disabled class="disablerow"/>
                      ( 
                    <input name="third_party_hkid2" type="text" id="third_party_hkid2" runat="server" size="2" maxlength="1" onBlur="chg_upper(this);chk_id2(this);"  style="font-size:7pt" disabled  class="disablerow"/>
                      ) </span></td>
					
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Payment 
                      Method 繳費方法<br>
                    </span></td>
                  <td height="0" colspan="3" class="row1"><span class="gensmall" style="font-size:9px"> 
                  <asp:Literal ID="pay_method_flag" runat="server"></asp:Literal>
                    <asp:DropDownList ID="pay_method" CssClass="disablerow" Enabled="false" 
                          Font-Size="7pt" runat="server" AppendDataBoundItems="true" AutoPostBack="true"
                          onselectedindexchanged="pay_method_SelectedIndexChanged">
                    <asp:ListItem Text="" Value=""></asp:ListItem>
                    <asp:ListItem Text="CASH" Value="CASH"></asp:ListItem>
                    <asp:ListItem Text="CREDIT CARD" Value="CREDIT CARD"></asp:ListItem>
                    <asp:ListItem Text="CREDIT CARD INSTALLMENT" Value="CREDIT CARD INSTALLMENT"></asp:ListItem>
                    </asp:DropDownList>     

                    
                    </span><span class="gensmall" style="font-size:7pt"><img src="images/loading.gif" name="load_pay" id="load_pay" style="display:none" /></span><span class="gensmall" style="font-size:9px"> 
                    </span><span class="gensmall" style="font-size:9px"> </span></td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Credit 
                      Card Type 信用卡類別<br>
                    </span></td>
                  <td height="0" class="row1"><span class="gensmall" style="font-size:9px"> 
                    </span><span class="gensmall" > </span><span class="gensmall" style="font-size:9px"> 
                    </span><span class="gensmall" > 
                  <asp:Literal ID="card_type_flag" runat="server"></asp:Literal>
                  <asp:DropDownList runat="server" ID="card_type" Font-Size="7pt" AppendDataBoundItems="true" AutoPostBack="false" CssClass="disablerow card_type" Enabled=false>
                  <asp:ListItem Text="" Value=""></asp:ListItem>
                  <asp:ListItem Text="Visa" Value="Visa"></asp:ListItem>
                  <asp:ListItem Text="MasterCard" Value="MasterCard"></asp:ListItem>
                  <asp:ListItem Text="American Express" Value="AmEx"></asp:ListItem>
                  </asp:DropDownList>
 
                    </span><span class="gensmall" style="font-size:9px"> </span></td>
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Credit 
                      Card No. </span></td>
                  <td height="0" class="row1"><span class="gensmall" style="font-size:9px"> 
                    </span><span class="gensmall" > </span><span class="gensmall" > 
					<asp:Literal ID="card_no_flag" runat="server"></asp:Literal>

     				<asp:TextBox ID="card_no" runat="server" Text=""  CssClass="card_no"  OnBlur="if(!checkCreditCard(document.getElementById('card_no').value,document.getElementById('card_type').value)){alert('Invalid token!');}" />
                    <input type="button" id="but_card_no" runat="server" value="Get Token"/>


                    </span><span class="explaintitle"  style="font-size:7pt"> 
                    </span><span class="gensmall" style="font-size:7pt">&nbsp;&nbsp;&nbsp;</span><span class="gensmall" style="font-size:9px"> 
                    </span><span class="gensmall" style="font-size:9px"> </span></td>
                </tr>
                <tr> 
                  <td height="0" class="row2">
                  <span class="explaintitle" style="font-size:7pt">
                      Credit Card Holder Name 信用卡持有人姓名
                  
                                                    </span>
                                                </td>
                                                <td height="0" class="row1">
                                                    <span class="gensmall" style="font-size: 9px"></span><span class="gensmall">
                                                        <asp:Literal ID="card_holder_flag" runat="server"></asp:Literal>
                                                        <input runat="server" name="<%=WebFunc.qsCard_holderName %>" type="text" id="card_holder"
                                                            class="disablerow" disabled="disabled" onblur="chg_upper(this);chk_cc(this)"
                                                            size="30" maxlength="100" style="font-size: 7pt" />
                                                    </span><span class="gensmall" style="font-size: 9px"></span>
                                                </td>
                                                <td height="0" class="row2">
                                                    <span class="explaintitle" style="font-size: 7pt">Credit Card Expiry Date </span>
                                                </td>
                                                <td height="0" class="row1">
                                                    <span class="gensmall" style="font-size: 9px"></span><span class="gensmall">
                                                        <asp:Literal ID="card_exp_month_flag" runat="server"></asp:Literal>
                                                        <asp:DropDownList ID="card_exp_month" runat="server" CssClass="disablerow" Enabled="false"
                                                            onblur="valid_thur(this.form.card_exp_month.value,this.form.card_exp_year.value);"
                                                            Font-Size="7pt">
                                                            <asp:ListItem Text="" Value=""></asp:ListItem>
                                                            <asp:ListItem Text="01" Value="01"></asp:ListItem>
                                                            <asp:ListItem Text="02" Value="02"></asp:ListItem>
                                                            <asp:ListItem Text="03" Value="03"></asp:ListItem>
                                                            <asp:ListItem Text="04" Value="04"></asp:ListItem>
                                                            <asp:ListItem Text="05" Value="05"></asp:ListItem>
                                                            <asp:ListItem Text="06" Value="06"></asp:ListItem>
                                                            <asp:ListItem Text="07" Value="07"></asp:ListItem>
                                                            <asp:ListItem Text="08" Value="08"></asp:ListItem>
                                                            <asp:ListItem Text="09" Value="09"></asp:ListItem>
                                                            <asp:ListItem Text="10" Value="10"></asp:ListItem>
                                                            <asp:ListItem Text="11" Value="11"></asp:ListItem>
                                                            <asp:ListItem Text="12" Value="12"></asp:ListItem>
                                                        </asp:DropDownList>
                                                        /
                                                        <asp:Literal ID="card_exp_year_flag" runat="server"></asp:Literal>
                                                        <asp:DropDownList ID="card_exp_year" runat="server" CssClass="disablerow" Enabled="false"
                                                            onblur="valid_thur(this.form.card_exp_month.value,this.form.card_exp_year.value);"
                                                            Font-Size="7pt">
                                                            <asp:ListItem Text="" Value=""></asp:ListItem>
                                                            <asp:ListItem Text="2007" Value="2007"></asp:ListItem>
                                                            <asp:ListItem Text="2008" Value="2008"></asp:ListItem>
                                                            <asp:ListItem Text="2009" Value="2009"></asp:ListItem>
                                                            <asp:ListItem Text="2010" Value="2010"></asp:ListItem>
                                                            <asp:ListItem Text="2011" Value="2011"></asp:ListItem>
                                                            <asp:ListItem Text="2012" Value="2012"></asp:ListItem>
                                                            <asp:ListItem Text="2013" Value="2013"></asp:ListItem>
                                                            <asp:ListItem Text="2014" Value="2014"></asp:ListItem>
                                                            <asp:ListItem Text="2015" Value="2015"></asp:ListItem>
                                                            <asp:ListItem Text="2016" Value="2016"></asp:ListItem>
                                                            <asp:ListItem Text="2017" Value="2017"></asp:ListItem>
                                                            <asp:ListItem Text="2018" Value="2018"></asp:ListItem>
                                                            <asp:ListItem Text="2019" Value="2019"></asp:ListItem>
                                                            <asp:ListItem Text="2020" Value="2020"></asp:ListItem>
                                                            <asp:ListItem Text="2021" Value="2021"></asp:ListItem>
                                                            <asp:ListItem Text="2022" Value="2022"></asp:ListItem>
                                                            <asp:ListItem Text="2023" Value="2023"></asp:ListItem>
                                                            <asp:ListItem Text="2024" Value="2024"></asp:ListItem>
                                                            <asp:ListItem Text="2025" Value="2025"></asp:ListItem>
                                                        </asp:DropDownList>
                                                        (MM/YY) </span><span class="gensmall" style="font-size: 9px"></span>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td height="0" class="row2">
                                                    <span class="explaintitle" style="font-size: 7pt">Bank Name 銀行名稱<br>
                                                    </span>
                                                </td>
                                                <td height="0" class="row1" colspan="3">
                                                    <span class="gensmall" style="font-size: 9px">
                                                        <asp:Literal ID="bank_code_flag" runat="server"></asp:Literal>
                                                        <asp:DropDownList ID="bank_name" runat="server" Font-Size="8pt" CssClass="disablerow"
                                                            Enabled="false" onChange="ChangeBankName(this)" AppendDataBoundItems="true">
                                                            <asp:ListItem Text="" Value=""></asp:ListItem>
                                                        </asp:DropDownList>
                                                        Installment Period
                                                        <select id="installment_period" runat="server" onchange="ChangeInstallmentPeriod(this)"
                                                            style="font-size: 8pt">
                                                        </select>
                                                        Bank Code
                                                        <input id="bank_code" runat="server" type="text" readonly="readonly" />
                                                    </span>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td height="0" class="row2">
                                                    <span class="explaintitle" style="font-size: 7pt">HS Amount 手機總額 </span>
                                                </td>
                                                <td height="0" colspan="3" class="row1">
                                                    <span class="gensmall" style="font-size: 9px">$
                                                        <input type="text" name="<%=WebFunc.qsAmountName %>" id="amount" size="5" maxlength="6"
                                                            style="font-size: 7pt" onblur="isNum(this);" value="0" readonly="readonly" runat="server" />
                                                    </span>
                                                </td>
                                            </tr>
                                            <tr id="first_month_fee_show">
                                                <td height="0" class="row2">
                                                    <span class="explaintitle" style="font-size: 7pt">First month fee </span>
                                                </td>
                                                <td height="0" colspan="3" class="row1">
                                                    <span class="gensmall" style="font-size: 9px">$
                                                        <input type="text" name="<%=WebFunc.qsFirst_month_feeName %>" id="first_month_fee"
                                                            size="5" maxlength="6" style="font-size: 7pt" onblur="isNum(this);" value="0"
                                                            readonly="readonly" runat="server" />
                                                    </span>
                                                </td>
                                            </tr>
                                            <tr id="first_month_license_fee_show">
                                                <td height="0" class="row2">
                                                    <span class="explaintitle" style="font-size: 7pt">First month license fee </span>
                                                </td>
                                                <td height="0" colspan="3" class="row1">
                                                    <span class="gensmall" style="font-size: 9px">$
                                                        <input type="text" name="<%=WebFunc.qsFirst_month_license_feeName %>" id="first_month_license_fee"
                                                            size="5" maxlength="6" style="font-size: 7pt" onblur="isNum(this);" value="0"
                                                            readonly="readonly" runat="server" />
                                                    </span>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td height="0" class="row2">
                                                    <span class="explaintitle" style="font-size: 7pt">Amount 總額<br>
                                                    </span>
                                                </td>
                                                <td height="0" colspan="3" class="row1">
                                                    <span class="gensmall" style="font-size: 9px">$
                                                        <input runat="server" type="text" name="total_amount" id="total_amount" value="0"
                                                            size="5" maxlength="6" style="font-size: 7pt" onblur="isNum(this);" readonly />
                                                    </span>
                                                </td>
                                            </tr>
                                        </table>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <table id="no_suspend4" width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                                    <tr id="delivery_collection_type_show" runat="server" style="display: none">
                                        <td height="0" class="row2">
                                            <span class="explaintitle" style="font-size: 8pt">Collection Type</span>
                                        </td>
                                        <td height="0" colspan="3" class="row1">
                                            <span class="gensmall" style="font-size: 9px">
                                                <select id="delivery_collection_type" name="delivery_collection_type" runat="server">
                                                    <option value=""></option>
                                                    <option value="DELIVERY" selected="selected">DELIVERY</option>
                                                    <option value="EXCHANGE">EXCHANGE</option>
                                                </select>
                                            </span>
                                        </td>
                                    </tr>
                                    <tr id="delivery_exchange_show" runat="server" style="display: none">
                                        <td height="0" class="row2">
                                            <span class="explaintitle" style="font-size: 8pt">Exchange</span>
                                        </td>
                                        <td height="0" colspan="3" class="row1">
                                            <span class="gensmall" style="font-size: 9px">
                                                <select id="delivery_exchange" name="delivery_exchange" runat="server">
                                                    <option value=""></option>
                                                    <option value="RETURN ANS E182E">RETURN ANS E182E</option>
                                                </select>
                                            </span>
                                        </td>
                                    </tr>
                                    <tr id="delivery_exchange_option_show" runat="server" style="display: none">
                                        <td height="0" class="row2">
                                            <span class="explaintitle" style="font-size: 8pt">Option</span>
                                        </td>
                                        <td height="0" colspan="3" class="row1">
                                            <span class="gensmall" style="font-size: 9px">
                                                <select id="delivery_exchange_option" runat="server">
                                                    <option value=""></option>
                                                    <option value="Y">Y</option>
                                                    <option value="N">N</option>
                                                </select>
                                            </span>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                    <table border="0" id="TBL5" width="100%" style="margin: 0px 0px 0px 0px;">
                        <tr>
                            <td>
                                <asp:UpdatePanel ID="no_opt_out_updateplanel" runat="server">
                                    <ContentTemplate>
                                        <table id="no_opt_out" width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                                            <tr>
                                                <td height="0" class="row3" colspan="3">
                                                    <span id="Span1" runat="server" class="explaintitle" style="font-size: 7pt">&nbsp;</span>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td width="22%" height="0" class="row2">
                                                    <span id="Span2" runat="server" class="explaintitle" style="font-size: 7pt">Remarks
                                                        備註<br>
                                                    </span>
                                                </td>
                                                <td height="0" colspan="2" class="row1">
                                                    <textarea runat="server" name="<%=WebFunc.qsRemarksName %>" cols="50" rows="2" id="remarks"
                                                        onblur="chg_upper(this);chk_cc(this)"></textarea>
                                                </td>
                                            </tr>
                                            <tr id="remarks2edf_show" runat="server">
                                                <td width="22%" height="0" class="row2">
                                                    <span id="Span3" runat="server" class="explaintitle" style="font-size: 7pt">Remarks
                                                        to EDF<br>
                                                    </span>
                                                </td>
                                                <td height="0" colspan="2" class="row1">
                                                    <textarea runat="server" name="<%=WebFunc.qsRemarks2EDFName %>" cols="50" rows="2"
                                                        id="remarks2EDF" onblur="chg_upper(this);chk_cc(this)" class="disablerow" disabled></textarea>
                                                </td>
                                            </tr>
                                            <tr id="show_remarks_to_py_operation" class="show_remarks_to_py_operation">
                                                <td width="22%" height="0" class="row2">
                                                    <span class="explaintitle" style="font-size: 7pt">Remarks to PY Operation<br>
                                                    </span>
                                                </td>
                                                <td height="0" colspan="2" class="row1">
                                                    <textarea runat="server" name="<%=WebFunc.qsRemarks2PYName %>" cols="50" rows="2"
                                                        id="remarks2PY" onblur="chg_upper(this);chk_cc(this)"></textarea>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td height="25" class="row2">
                                                    <span class="explaintitle" style="font-size: 7pt">Staff No </span>
                                                </td>
                                                <td width="49%" height="25" class="row1">
                                                    <input runat="server" name="<%=WebFunc.qsStaff_noName %>" type="text" id="staff_no"
                                                        style="font-size: 7pt" size="12" maxlength="10" value="" />
                                                    <span class="gensmall" style="font-size: 7pt">
                                                        <input runat="server" name="ch_cust_button" id="ch_cust_button" type="button" class="button"
                                                            value="Change Staff Info" onclick="get_name(document.getElementById('form1').staff_no.value)" />
                                                    </span>
                                                </td>
                                                <td width="51%" height="25" colspan="1" class="row1">
                                                    <span class="explaintitle" style="font-size: 7pt">Referrer Staff ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                        <span class="explaintitle" style="font-size: 7pt">
                                                            <input runat="server" name="<%=WebFunc.qsRef_staff_noName %>" type="text" id="ref_staff_no"
                                                                style="font-size: 7pt" size="12" maxlength="10" />
                                                        </span>
                                                        <input name="refer_button" type="button" class="button" value="Check" onclick="get_ref_id(document.getElementById('form1').ref_staff_no.value)" />
                                                    </span>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td height="0" class="row2">
                                                    <span class="explaintitle" style="font-size: 7pt">Staff Name</span>
                                                </td>
                                                <td height="0" width="49%" class="row1">
                                                    <input runat="server" name="<%=WebFunc.qsStaff_nameName %>" type="text" id="staff_name"
                                                        style="font-size: 7pt" size="50" maxlength="100" value="" readonly="readonly"
                                                        runat="server" />
                                                </td>
                                                <td width="51%" height="25" colspan="1" class="row1">
                                                    <span class="explaintitle" style="font-size: 7pt">Referrer Salesmancode <span class="explaintitle"
                                                        style="font-size: 7pt">
                                                        <input name="<%=WebFunc.qsRef_salesmancodeName %>" type="text" id="ref_salesmancode"
                                                            style="font-size: 7pt" size="10" maxlength="10" value="" readonly="readonly"
                                                            runat="server" />
                                                    </span></span>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td height="0" class="row2">
                                                    <span class="explaintitle" style="font-size: 7pt">Teamcode</span>
                                                </td>
                                                <td height="0" colspan="2" class="row1">
                                                    <input name="<%=WebFunc.qsTeamcodeName %>" type="text" id="teamcode" style="font-size: 7pt"
                                                        size="12" maxlength="10" value="NONE" readonly runat="server" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td height="0" class="row2">
                                                    <span class="explaintitle" style="font-size: 7pt">Team Leader</span>
                                                </td>
                                                <td height="0" colspan="2" class="row1">
                                                    <input name="<%=WebFunc.qsTl_nameName %>" type="text" id="tl_name" style="font-size: 7pt"
                                                        size="50" maxlength="100" value="" readonly runat="server" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td height="0" class="row2">
                                                    <span class="explaintitle" style="font-size: 7pt">Channel</span>
                                                </td>
                                                <td height="0" colspan="2" class="row1">
                                                    <input name="<%=WebFunc.qsChannelName %>" type="text" id="channel" style="font-size: 7pt"
                                                        size="5" maxlength="4" value="" readonly runat="server" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td height="0" class="row2">
                                                    <span class="explaintitle" style="font-size: 7pt">Salesman Code </span>
                                                </td>
                                                <td height="0" colspan="2" class="row1">
                                                    <input name="<%=WebFunc.qsSalesmancodeName %>" type="text" id="salesmancode" style="font-size: 7pt"
                                                        size="5" maxlength="4" value="" readonly runat="server" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td height="0" class="row2">
                                                    <span class="explaintitle" style="font-size: 7pt">Extn</span>
                                                </td>
                                                <td height="0" colspan="2" class="row1">
                                                    <input runat="server" name="<%=WebFunc.qsExtnName %>" type="text" id="extn" style="font-size: 7pt"
                                                        size="9" maxlength="8" value="" readonly />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="cat" colspan="3">
                                                    &nbsp;
                                                </td>
                                            </tr>
                                        </table>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
    </div>
    <table width="100%" cellspacing="2" cellpadding="3" border="0">
        <tr>
            <td class="nav">
                <a href="MobileRetentionMain.aspx">Main Page</a> &raquo; View <span class="explaintitle"
                    style="font-size: 8pt">
                    <%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
