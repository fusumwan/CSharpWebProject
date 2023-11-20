<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/RWLMenu.master" AutoEventWireup="true" CodeFile="BasicBackEndManagement.aspx.cs" Inherits="Web_BasicBackEndManagement" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="RWLHeaderContentPlace" Runat="Server">
    <meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
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
                  <td class="nav">Main Page » &nbsp;</td>
                <td align="right" class="nav"> 
                  <a href="MessageViewAction.aspx" runat="server" id="MessageViewAction">
                    <img src="images/pc_25_01.gif" height="20" /></a>
                </td>
                </tr>
              </table>
              <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
              <tr> 
              <td>









<table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
				<tr>
					<td align="top">
	 					 <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
						 	<tr>
								<td height="10" class="row2">&nbsp;</td>
								<td height="10" class="row2" align="center"><span class="explaintitle" style="font-size:8pt">Back End Management</span></td>
								<td height="10" class="row2">&nbsp;</td>
							</tr>						 
						 	<tr>
								<td height="10" width="33%" class="row1" align="center"><span class="explaintitle"><a href="MobileNumberProfileView.aspx">Add Mobile Number</a></span></td>
								<td height="10" width="33%" class="row1" align="center"><span class="explaintitle"><a href="OfferAutomation.aspx">Offer Automation</a></span></td>
								<td height="10" width="33%" class="row1" align="center"><span class="explaintitle"><a href="ProgramRebateMapping.aspx">Program Rebate Mapping</a></span></td>
							</tr>
							<tr>
								<td height="10" width="33%" class="row1" align="center"><span class="explaintitle"><a href="MonthlyPaymentMethod.aspx">Monthly Payment Method Mapping</a></span></td>
								<td height="10" width="33%" class="row1" align="center"><span class="explaintitle"></span></td>
								<td height="10" width="33%" class="row1" align="center"><span class="explaintitle"></span></td>
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



