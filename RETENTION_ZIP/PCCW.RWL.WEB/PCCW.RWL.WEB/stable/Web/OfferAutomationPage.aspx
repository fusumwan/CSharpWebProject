<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/RWLMenu.master" AutoEventWireup="true" CodeFile="OfferAutomationPage.aspx.cs" Inherits="Web_OfferAutomationPage" %>
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
              <td>
              
              
              
              
               <table cellpadding="0" cellspacing="0" border="0" style="margin:0 0 0 0; padding:0 0 0 0">
              <tr>
              <td>
              <Dna:AspxButton ID="BackBut" Text="Back" 
                      PostBackUrl="~/Web/MobileRetentionMain.aspx" runat="server" />
              </td>
              </tr>
              </table>
              <br />
                    
              
              
        <table id="myFormBorder" class="myformborder" cellpadding="0" cellspacing="10">
              <tr>
              <td>
              <table id="stylized" class="myform" cellpadding="0" cellspacing="0" border="0">
              
              <tr>
              <td colspan="3" >
              <h1>Offer Automation Form</h1>
              <p>This form is used for auto select offer.</p>
              </td>
              </tr>
              
              <tr>
              <td class="myform_title">
                <label class="myform_label">Offer Automation Name
                <span class="small">Please kindly select the offer type</span>
                </label>
              </td>
              <td nowrap="nowrap">
              <Dna:AspxDropDownList ID="offer_name" AutoPostBack="true" DataTextField="offer_name" DataValueField="trade_field_id" runat="server" AppendDataBoundItems="true">
              </Dna:AspxDropDownList>
              
              </td>
               <td nowrap="nowrap">
               
                
                
              </td>
              </tr>
              
              
              <tr>
              <td class="myform_title">

              </td>
              <td nowrap="nowrap">

              <Dna:AspxButton ID="SubmitBit" Text="Submit"  runat="server" 
                      onclick="SubmitBit_Click" />
                      
                      <Dna:AspxButton ID="SkipBit" Text="Skip" runat="server" 
                      onclick="SkipBit_Click" />
                      
              </td>
               <td nowrap="nowrap">
               
                
                
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

