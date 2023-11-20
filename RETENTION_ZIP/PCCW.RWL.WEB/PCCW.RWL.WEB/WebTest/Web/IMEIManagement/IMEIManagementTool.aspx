<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/RWLMenu.master" AutoEventWireup="true" CodeFile="IMEIManagementTool.aspx.cs" Inherits="Web_IMEIManagement_IMEIManagementTool" %>
<%@ Register Src="../../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="RWLHeaderContentPlace" Runat="Server">

<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet" href="../../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<link rel="stylesheet" href="../../Resources/Styles/RWLFormStyle.css" type="text/css" />

<asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
  
 <script language="javascript" type="text/javascript">
     function ChkExistingOrder(This) {
         if (This.value == "" ||
         This.value == undefined) {
             return false;
         }
         var Result = $.ajax({
             type: 'post',
             url: '../Handler/IMEIManagementTool.ashx',
             data: "method=ChkExistingOrder&edf_no="+This.value,
             dataType: 'text',
             cache: false,
             async: false
         }).responseText;

         if (Result == "TRUE") {
             return true;
         }
         else {
             jAlert('This EDF number is not existing in our system', 'System Message');
             return false;
         }
     }

     function ChkExistingIMEI(This) {
         if (This.value == "" ||
         This.value == undefined) {
             return false;
         }
         var Result = $.ajax({
             type: 'post',
             url: '../Handler/IMEIManagementTool.ashx',
             data: "method=ChkExistingIMEI&imei_no=" + This.value,
             dataType: 'text',
             cache: false,
             async: false
         }).responseText;

         if (Result == "TRUE") {
             var ImeiError = $("span[id*='ImeiError']");
             if (ImeiError != null && ImeiError != undefined) {
                 ImeiError.fadeOut(200);
                 ImeiError.html('');
                 document.getElementById(ImeiError.attr('id')).style.display = "none";
             }

             return true;
         }
         else {

             var ImeiError = $("span[id*='ImeiError']");
             if (ImeiError != null && ImeiError != undefined) {
                 ImeiError.fadeIn(200);
                 ImeiError.html(" * This IMEI number is not existing in our system");
             }
             jAlert('This IMEI number is not existing in our system', 'System Message');
             return false;
         }

     }


     function ChkExistingIMEIStatus(This) {
         if (This.value == "" ||
         This.value == undefined) {
             return false;
         }
         var Result = $.ajax({
             type: 'post',
             url: '../Handler/IMEIManagementTool.ashx',
             data: "method=ChkExistingIMEIStatus&imei_no=" + This.value,
             dataType: 'text',
             cache: false,
             async: false
         }).responseText;
         if (Result != "") {
             if (Result == "3G_RETENTION") {
                 var ImeiError = $("span[id*='ImeiError']");
                 if (ImeiError != null && ImeiError != undefined) {
                     ImeiError.fadeOut(200);
                     ImeiError.html('');
                     document.getElementById(ImeiError.attr('id')).style.display = "none";
                 }
                 return true;
             }
             else {
                 var ImeiError = $("span[id*='ImeiError']");
                 if (ImeiError != null && ImeiError != undefined) {
                     ImeiError.fadeIn(200);
                     ImeiError.css("font-weight", "normal");
                     ImeiError.html(" * Please kindly enter IMEI with normal status");
                 }
                 jAlert('Error : Please kindly enter IMEI with normal status!', 'System Message');
                 return false;
             }
         }
     }

     function GetSkuHsmodel(This) {
         if (This.value == "" ||
         This.value == undefined) {
             return false;
         }
         var Result = $.ajax({
             type: 'post',
             url: '../Handler/IMEIManagementTool.ashx',
             data: "method=GetSkuHsmodel&edf_no=" + This.value,
             dataType: 'text',
             cache: false,
             async: false
         }).responseText;
         var sku_hs_model = $("span[id*='sku_hs_model']");
         if (sku_hs_model != null && sku_hs_model != undefined)
             sku_hs_model.html(Result);
         else {
             alert("Error");
         }
     }
     
 
 </script> 
  


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="RWLContentPlace" Runat="Server">
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
                  <a href="../MessageViewAction.aspx" runat="server" id="MessageViewAction">
                    <img src="../images/pc_25_01.gif" height="20" alt="" /></a>
                </td>
                </tr>
              </table>
              <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
              <tr> 
              <td>


        <table id="myFormBorder" class="myformborder" cellpadding="0" cellspacing="10">
              <tr>
              <td>
              <table id="stylized" class="myform" cellpadding="0" cellspacing="0" border="0">
              
              <tr>
              <td colspan="3" >
              <h1>IMEI Management Form</h1>
              <p>This form is used for amend imei record.</p>
              </td>
              </tr>
              <tr>
              
              <td class="myform_title">
                <label class="myform_label">EDF Number
                <span class="small">Enter The EDF Number</span>
                </label>
              </td>
              <td nowrap="nowrap">
              <Dna:AspxTextBox  ID="edf_no" runat="server" ValidationGroup="AssignImeiGroup" Width="250px" onblur="ChkExistingOrder(this);GetSkuHsmodel(this)"  
              InnerHintMessage="Please kindly Enter The EDF Number" HintMessage="Please kindly Enter The EDF Number"></Dna:AspxTextBox>
              <asp:RequiredFieldValidator ID="HsModelRequiredFieldValidator" ControlToValidate="edf_no" ErrorMessage=" * Please kindly Enter The EDF Number"
                CssClass="dismiss" runat="server" ValidationGroup="AssignImeiGroup" >
               </asp:RequiredFieldValidator>
              </td>
               <td nowrap="nowrap">
               
                
                
              </td>
              </tr>
              
              <tr>
              <td class="myform_title">
                <label class="myform_label">New IMEI Number
                <span class="small">Enter A New IMEI Number</span>
                </label>
              </td>
              <td nowrap="nowrap">
              <Dna:AspxTextBox  ID="imei_no"  runat="server" Width="250px"  onblur="ChkExistingIMEI(this);ChkExistingIMEIStatus(this);"
              InnerHintMessage="Please kindly Enter The IMEI number" HintMessage="Please kindly Enter The IMEI Number"></Dna:AspxTextBox>
              <div>
            <span id="ImeiError" style="color:Red; font-size:12px; font-weight:normal; font-family:Verdana;display: block;float:right;cursor: pointer;" runat="server"></span></div>
            <asp:RequiredFieldValidator ID="IMEINoRequiredFieldValidator" ControlToValidate="imei_no" ErrorMessage=" * Please kindly Enter The IMEI Number"
                CssClass="dismiss" runat="server" ValidationGroup="AssignImeiGroup" >
               </asp:RequiredFieldValidator>
               
              </td>
               <td nowrap="nowrap" class="myform_title">

              </td>
              </tr>
              

              
              <tr>
              <td>
                <label class="myform_label">New SKU
                <span class="small">Enter A New SKU Code </span>
                </label>
              </td>
              <td align="left" >
              
                   <asp:Label ID="sku_hs_model" runat="server"></asp:Label>
                   
              </td>
              <td>
              </td>
              </tr>
             
              
              
              <tr>
              <td >
                <label class="myform_label">DOA Type
                <span class="small">Select DOA Type</span>
                </label>
              </td>
              <td>

              <Dna:AspxDropDownList ID="status" Font-Size="12px" Font-Names="Times New Roman"   runat="server" Width="250px" >
              <asp:ListItem Text="Normal DOA" Value="Normal DOA" Selected="True"></asp:ListItem>
              <asp:ListItem Text="Exchange DOA" Value="Exchange DOA"></asp:ListItem>
              <asp:ListItem Text="Onsite Reject (Return)" Value="Onsite Reject (Return)"></asp:ListItem>
              <asp:ListItem Text="Onsite Reject (Re-use)" Value="Onsite Reject (Re-use)"></asp:ListItem>
              </Dna:AspxDropDownList >
                
              </td>
              <td>
              </td>
              </tr>
              
             
              
              <tr>
              <td>
              </td>
              <td>

                      <Dna:AspxButton ID="SubmitBut" Text="Submit" runat="server" OnClick="SubmitBut_OnClick" ValidationGroup="AssignImeiGroup" />
              </td>
              <td>
              
              </td>
               <td>
              </td>
              </tr>

              
              </table>
              </td>
              </tr>
              </table>
              
              
              
              
              
              
              
              
              
              
              
              
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

