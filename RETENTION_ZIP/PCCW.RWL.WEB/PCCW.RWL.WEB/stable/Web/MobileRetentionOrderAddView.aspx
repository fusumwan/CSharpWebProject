<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/RWLMenu.master" AutoEventWireup="true" CodeFile="MobileRetentionOrderAddView.aspx.cs" Inherits="Web_MobileRetentionOrderAddView" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="RWLHeaderContentPlace" Runat="Server">
    <meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<link rel="stylesheet" href="../Resources/Styles/RWLFormStyle.css" type="text/css" />

  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
  
<script type="text/javascript">
function chk_mobile_use(objC) {
    var ResultMsg = $.ajax({
        type: 'post',
        url: 'Handler/SqlHandler.ashx',
        data: "method=CHKMRTNO&filter=" + objC.value,
        dataType: 'text',
        cache: false,
        async: false
    }).responseText;
    if (ResultMsg != "") {
        return confirm(ResultMsg);
    }
}


function chk_mobile(objC){
	if(objC.value.length!=0){
		if(objC.value.match(/^\d{8}$/)==null){
		    jAlert("Invalid Contact Number!", "System Message");
			//objC.select();
			return false;
		}
		else if(objC.value.substring(0,1)!="5"&& objC.value.substring(0,1)!="6" && objC.value.substring(0,1)!="7" && objC.value.substring(0,1)!="8" && objC.value.substring(0,1)!="9"){

		    jAlert("Invalid Contact Number! Please begins with 5/6/7/8/9!", "System Message");
			//objC.select();
			return false;
		}
		return true;
	}
	else
		return false;
}

function chk_mrt() {
    var objC = document.getElementById('ctl00_RWLContentPlace_mrt');
    if (objC.value == "") {
        jAlert("Please Enter MRT No!", "System Message");
        document.getElementById('loading').style.display = "none";
        event.returnValue = false;
        return false;
	}
	else{
	    event.returnValue = true;
	    return true;
	}
}

function chk_save() {
    var Obj = document.getElementById('ctl00_RWLContentPlace_mrt');
    if (chk_mrt() == false || chk_mobile(Obj) == false || chk_mobile_use(Obj) ==false) {
        event.returnValue = false;
        return false;
    }
    else {
        document.getElementById('loading').style.display = "inline";
    }
	
	 return true; 
}

function chk_gsave()
{
    document.getElementById('ctl00_RWLContentPlace_mrt').value = "";
	 document.getElementById('loading').style.display="inline";
	 return true;
}

function chk_msave() {
    document.getElementById('ctl00_RWLContentPlace_mrt').value = "";
    document.getElementById('loading').style.display = "inline";
    return true;
}

</script>
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="RWLContentPlace" Runat="Server">


<cc1:ToolkitScriptManager ID="AddWebLogScriptManager"  runat="server" EnablePartialRendering="true" ScriptMode="Release" LoadScriptsBeforeUI="false" EnablePageMethods="true"></cc1:ToolkitScriptManager>
<table width="100%" cellspacing="10" >
<tr>
<td>

             
<table width="100%" class="bodyline" border="0"   cellspacing="0" cellpadding="10">
<tr>
<td>
              <table width="100%" cellspacing="2" cellpadding="3" border="0">
                <tr> 
                  <td colspan="2" class="maintitle">
                      <span class="explaintitle" style="font-size:8pt">
                            <%=global::PCCW.RWL.CORE.Configurator.GetTitle() %>
                      </span>
                  </td>
                </tr>
                <tr>
                  <td class="nav">Main Page &raquo; &nbsp;</td>
                <td align="right" class="nav"> 
                  <a href="MessageViewAction.aspx" runat="server" id="MessageViewAction">
                    <img src="images/pc_25_01.gif" height="20" /></a>
                </td>
                </tr>
              </table>

                   <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
              <tr> 
     <td align="center">
     <br />
     <br />
        <table id="myFormBorder" class="myformborder" cellpadding="0" cellspacing="10">
              <tr>
              <td>
              <table id="stylized" class="myform" cellpadding="0" cellspacing="0" border="0">
              
              <tr>
              <td colspan="3" >
              <h1>Choose Register Form Platform</h1>
              <p>This form is used for select form platform.</p>
              </td>
              </tr>
              <tr>
              <td class="myform_title">
                <label class="myform_label">Form Type
                <span class="small">Which form platform is used to register new order?</span>
                </label>
              </td>
              <td nowrap="nowrap" align="left">
<table border="0" cellpadding="0" cellspacing="0" style="width:440px">
<tr>
<td nowrap="nowrap" align="left">
<Dna:AspxButton  ID="Rwl3GSubmit" Text="3G RETENTION"  CssClass="buttonlink-washed" Width="120px"   Font-Size="10pt" runat="server" OnClientClick="chk_save();" PostBackUrl="~/Web/MobileRetentionOrderAddViewAction.aspx?ISSUE_TYPE=3G_RETENTION" />
<Dna:AspxButton ID="Rwl2GSubmit" Text="2G RETENTION" Enabled="true" CssClass="buttonlink-washed" Width="120px" Font-Size="10pt" runat="server" OnClientClick="chk_save();" PostBackUrl="~/Web/MobileRetentionOrderAddViewAction.aspx?ISSUE_TYPE=2G_RETENTION"/>
<Dna:AspxButton ID="WinSubmit" Text="WIN" Enabled="true" CssClass="buttonlink-washed"  Font-Size="10pt" runat="server" OnClientClick="chk_save();" PostBackUrl="~/Web/MobileRetentionOrderAddViewAction.aspx?ISSUE_TYPE=WIN"/>
<Dna:AspxButton  ID="MobileLiteSubmit" Text="MOBILE LITE" CssClass="buttonlink-washed" Width="100px" Font-Size="10pt" runat="server" OnClientClick="chk_save();" PostBackUrl="~/Web/MobileRetentionOrderAddViewAction.aspx?ISSUE_TYPE=MOBILE_LITE" />
<Dna:AspxButton ID="UpgradeSubmit" Text="UPGRADE" CssClass="buttonlink-washed" Width="100px" Font-Size="10pt" runat="server" OnClientClick="chk_save();" PostBackUrl="~/Web/MobileRetentionOrderAddViewAction.aspx?ISSUE_TYPE=UPGRADE"/>
</td>
</tr>
<tr>
<td align="left" style="height:20px">
<img src="images/loading.gif" name="loading" id="loading" style="display:none" />
</td>
</tr>
</table>
              </td>
               <td nowrap="nowrap">

                

              </td>
              </tr>
              
              
              <tr>
              <td class="myform_title">
                <label class="myform_label">Mobile Number
                <span class="small">Enter the mobile number</span>
                </label>
              </td>
              <td align="left">
              
              <Dna:AspxTextBox  ID="mrt"  runat="server" Width="100px"  maxlength="8" onBlur="chk_mobile(this);"
              HintMessage="Please kindly Enter The Mobile Number"></Dna:AspxTextBox>

              </td>
               <td nowrap="nowrap" class="myform_title">

              </td>
              </tr>
              
              <tr>
              <td class="myform_title">
                <label class="myform_label">Order Page Style
                <span class="small">Click to show all pages in screen?</span>
                </label>
              </td>
              <td align="left">
              <table id="CheckBoxTbl" runat="server" cellpadding="0" cellspacing="0" style="border:Solid 1px #98B5D6; margin:0 0 0 0; padding:0 0 0 0; width:auto; ">
              <tr>
              <td style="background-color:White">

              <Dna:AspxCheckBox ID="AllPageInScreen" runat="server" />
              
              </td>
              </tr>
              </table>
                

              </td>
              <td>
              </td>
              </tr>     
              

              
              </table>
              </td>
              </tr>
              </table>
<br />
     <br />
</td>
        </tr>
        </table>
        </td>
        </tr>
        <tr> 
                <td class="cat" colspan="3"><span class="explaintitle">&nbsp; </span></td>
              </tr>
        </table>
        </td>
        </tr>
        
        </table>
        
</asp:Content>

