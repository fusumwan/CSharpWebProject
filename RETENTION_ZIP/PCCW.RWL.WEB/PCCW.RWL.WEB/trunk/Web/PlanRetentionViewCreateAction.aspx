<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/RWLMenu.master" AutoEventWireup="true" CodeFile="PlanRetentionViewCreateAction.aspx.cs" Inherits="Web_PlanRetentionViewCreateAction" %>
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
              
              
              <table>
              <tr>
              <td>
              <Dna:AspxButton ID="BackBtn" runat="server" Text="Back" PostBackUrl="MobileRetentionMain.aspx" />
              </td>
              <td>
              <Dna:AspxButton ID="RatePlanMapping" runat="server" Text="Rate Plan Mapping Table" PostBackUrl="PlanRetentionViewAction.aspx"/>
              </td>
              </tr>
              </table>
              <br />
              
              
              

        <table id="myFormBorder" class="myformborder" cellpadding="0" cellspacing="5" >
              <tr>
              <td>
              <table id="stylized" class="myform" cellpadding="0" cellspacing="0" border="0" >
              
              <tr>
              <td colspan="2" >
              <h1>Retention Plan Code Form</h1>
              <p>This form is used for create plan code(rate_plan) and plan fee mapping </p>
              </td>
              </tr>
              
              
              
              <tr>
              <td>
                <label class="myform_label">Plan Fee
                <span class="small">Please Kindly Enter The Plan Fee in integer</span>
                </label>
              </td>
              <td align="left">
             
                       <Dna:AspxTextBox ID="plan_fee" runat="server" ValidationGroup="RatePlanGroup"></Dna:AspxTextBox>
                       <asp:RequiredFieldValidator ID="PlanFeeRequiredFieldValidator" EnableClientScript="true" ErrorMessage="* Please kindly Enter The Plan Fee" runat="server" ControlToValidate="plan_fee" ValidationGroup="RatePlanGroup">
                       
                       </asp:RequiredFieldValidator>
              </td>

              </tr>
             
              <tr>
              <td>
                <label class="myform_label">Rate Plan
                <span class="small">Please do not create duplicate rate plan mapping record</span>
                </label>
              </td>
              <td align="left">
             
                       <Dna:AspxDropDownList ID="rate_plan" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="10" 
                       Width="350px" DataTextField="rate_plan" DataValueField="rate_plan"  ValidationGroup="RatePlanGroup">
                       </Dna:AspxDropDownList>
                       
                       
                       
              </td>
               
              </tr>
              
              <tr>
              <td></td>
              <td>
              <Dna:AspxButton ID="CreateRecord" runat="server" Text="Create Record"  ValidationGroup="RatePlanGroup"
                      onclick="CreateRecord_Click" />
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

