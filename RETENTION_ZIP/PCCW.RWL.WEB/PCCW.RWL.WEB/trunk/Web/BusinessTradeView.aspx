<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/RWLMenu.master" AutoEventWireup="true" CodeFile="BusinessTradeView.aspx.cs" Inherits="Web_BusinessTradeView" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="RWLHeaderContentPlace" Runat="Server">
    <meta http-equiv="Content-Style-Type" content="text/css" />
    <meta http-equiv="Content-Type" content="text/html; charset=big5" />
    <title>3G Retention - Web Log</title>
    <link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
    <link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
    <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
    <link rel="stylesheet" href="../Resources/Styles/RWLFormStyle.css" type="text/css" />


    <style type="text/css">

    </style>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="RWLContentPlace" Runat="Server">

    <table width="100%" cellspacing="10" >
        <tr>
            <td>
                <table width="100%" class="bodyline" border="0" cellspacing="0" cellpadding="10">
                    <tr>
                        <td>
                            <table width="100%" cellspacing="2" cellpadding="3" border="0">
                                <tr>
                                    <td colspan="2" class="maintitle">
                                        <span class="explaintitle" style="font-size: 8pt">
                                            <%=global::PCCW.RWL.CORE.Configurator.GetTitle() %>
                                        </span>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="nav">
                                        Main Page &raquo; &nbsp;
                                    </td>
                                    <td align="right" class="nav">
                                        <a href="MessageViewAction.aspx" runat="server" id="MessageViewAction">
                                            <img src="images/pc_25_01.gif" height="20" /></a>
                                    </td>
                                </tr>
                            </table>
                            <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                                <tr>
                                    <td>
                                        <table cellpadding="5" cellspacing="0" border="0" style="margin: 0 0 0 0; padding: 0 0 0 0">
                                            <tr>
                                            <td>
                                                <Dna:AspxButton ID="Search" Text="Search" PostBackUrl="BusinessTradeViewImplement.aspx" runat="server" />
                                            </td>
                                            
                                                <td>
                                                    <Dna:AspxButton ID="BackBut" Text="Back"  PostBackUrl="MobileRetentionMain.aspx" runat="server" />
                                                </td>

                                            </tr>
                                            
                                        </table>
                                        <br />


      <table id="myFormBorder" class="myformborder" cellpadding="0" cellspacing="5" >
              <tr>
              <td>
              <table id="stylized" class="myform" cellpadding="0" cellspacing="0" border="0" >
              
              <tr>
              <td colspan="3" >
              <h1>Retention View / Modify Trade Field Mapping Searching Form</h1>
              <p>This form is used for View / Modify Trade Field Mapping </p>
              </td>
              </tr>
              
              
              <tr>
              <td>
                <label class="myform_label">Issue Type
                <span class="small">Please kindly select the issue type</span>
                </label>
              </td>
              <td align="left">
             
                       <Dna:AspxDropDownList ID="issue_type" AppendDataBoundItems="true" Rows="4" runat="server" Font-Size="12px" 
                       Width="100" DataTextField="issue_type" DataValueField="issue_type" AutoPostBack="true" >
                       <asp:ListItem Text="ALL" Value=""></asp:ListItem>
                       <asp:ListItem Text="3G_RETENTION" Value="3G_RETENTION"></asp:ListItem>
                       <asp:ListItem Text="2G_RETENTION" Value="2G_RETENTION"></asp:ListItem>
                       <asp:ListItem Text="GO_WIRELESS" Value="GO_WIRELESS"></asp:ListItem>
                       <asp:ListItem Text="MOBILE_LITE" Value="MOBILE_LITE"></asp:ListItem>
                       <asp:ListItem Text="WIN" Value="WIN"></asp:ListItem>
                       <asp:ListItem Text="UPGRADE" Value="UPGRADE"></asp:ListItem>
                       </Dna:AspxDropDownList>
              </td>
              <td>
              </td>
              </tr>
              
              
              
              <tr>
              <td>
                <label class="myform_label">Program
                <span class="small">Please kindly select the program</span>
                </label>
              </td>
              <td align="left">
             
                       <Dna:AspxDropDownList ID="program" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="10" 
                       Width="350" DataTextField="program" DataValueField="program" >
                           
                       </Dna:AspxDropDownList>
              </td>
              <td>
              </td>
              </tr>
              
              
              <tr>
              <td>
                <label class="myform_label">Normal Rebate Type
                <span class="small">Please kindly select the normal rebate type</span>
                </label>
              </td>
              <td align="left">
             
                       <Dna:AspxDropDownList ID="normal_rebate_type" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="10" 
                       Width="350" DataTextField="normal_rebate_type" DataValueField="normal_rebate_type" >
                           
                       </Dna:AspxDropDownList>
              </td>
              <td>
              </td>
              </tr>
              
              
              <tr>
              <td>
                <label class="myform_label">Rate Plan
                <span class="small">Please kindly select the rate plan</span>
                </label>
              </td>
              <td align="left">
             
                       <Dna:AspxDropDownList ID="rate_plan" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="10" 
                       Width="350" DataTextField="rate_plan" DataValueField="rate_plan" >
                           
                           <asp:ListItem>Unbound</asp:ListItem>
                           
                       </Dna:AspxDropDownList>
              </td>
              <td>
              </td>
              </tr>
              
              
              <tr>
              <td>
                <label class="myform_label">Contract Period
                <span class="small">Please kindly select the contract period</span>
                </label>
              </td>
              <td align="left">
             
                       <Dna:AspxDropDownList ID="con_per" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="10" 
                       Width="100" DataTextField="con_per" DataValueField="con_per" >
                           
                       </Dna:AspxDropDownList>
              </td>
              <td>
              </td>
              </tr>
              
              
              
              
              
              
              
               <tr>
              <td>
                <label class="myform_label">Handset / Premium
                <span class="small">Please kindly select the Handset / Premium</span>
                </label>
              </td>
              <td align="left" nowrap="nowrap">
                    <Dna:AspxRadioButtonList ID="hs_model" runat="server" Font-Size="8px" Font-Names="Arial"  AppendDataBoundItems="true" RepeatDirection="Horizontal">
                    <asp:ListItem Text="NO Handset/Premium" Value="N"></asp:ListItem>
                    <asp:ListItem Text="Handset" Value="Y"></asp:ListItem>
                    <asp:ListItem Text="Premium" Value="P"></asp:ListItem>
                    <asp:ListItem Text="Handset  & Premium" Value="A"></asp:ListItem>
                    </Dna:AspxRadioButtonList>
              
              </td>
              <td>
              </td>
              </tr>
              
              
              <tr>
              <td>
                <label class="myform_label">Trade Field
                <span class="small">Please kindly select the trade field</span>
                </label>
              </td>
              <td align="left">
             
                       <Dna:AspxDropDownList ID="trade_field" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="10" 
                       Width="200" DataTextField="trade_field" DataValueField="trade_field" >
                           
                       </Dna:AspxDropDownList>
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
                        <td class="cat" colspan="3">
                            <span class="explaintitle">&nbsp; </span>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

