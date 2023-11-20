<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/RWLMenu.master" AutoEventWireup="true" CodeFile="BusinessVasAutoSelectRule.aspx.cs" Inherits="Web_BusinessVasAutoSelectRule" %>

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
    <cc1:ToolkitScriptManager ID="AddWebLogScriptManager" runat="server" EnablePartialRendering="true"
        ScriptMode="Release" LoadScriptsBeforeUI="false" EnablePageMethods="true">
    </cc1:ToolkitScriptManager>
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
                                        <user:AttachmentHandlerJs ID="AttachmentControl" runat="server" />
                                        <table cellpadding="5" cellspacing="0" border="0" style="margin: 0 0 0 0; padding: 0 0 0 0">
                                            <tr>
                                                <td>
                                                    <Dna:AspxButton ID="BackBut" Text="Back" 
                                                        PostBackUrl="~/Web/BusinessVasAutoSelect.aspx" runat="server" />
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
              <h1>Retention Vas Auto Selection Setting Form</h1>
              <p>This form is used for Vas Auto Selection </p>
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
                <label class="myform_label">Rate Plan
                <span class="small">Please kindly select the rate plan</span>
                </label>
              </td>
              <td align="left">
             
                       <Dna:AspxDropDownList ID="rate_plan" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="10" 
                       Width="150" DataTextField="rate_plan" DataValueField="rate_plan" >
                           
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
                <label class="myform_label">Handset model
                <span class="small">Please kindly select the Handset model</span>
                </label>
              </td>
              <td align="left">
             
                       <Dna:AspxDropDownList ID="hs_model" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="10" 
                       Width="550" DataTextField="hs_model" DataValueField="hs_model" >
                           
                       </Dna:AspxDropDownList>
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
              
              <tr>
              <td>
                <label class="myform_label">Bundle Name
                <span class="small">Please kindly select the bundle name</span>
                </label>
              </td>
              <td align="left">
             
                       <Dna:AspxDropDownList ID="bundle_name" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="10" 
                       Width="200" DataTextField="bundle_name" DataValueField="bundle_name" >
                           
                       </Dna:AspxDropDownList>
              </td>
              <td>
              </td>
              </tr>
              
              <tr>
              <td>
                <label class="myform_label">Issue Type
                <span class="small">Please kindly select the issue type</span>
                </label>
              </td>
              <td align="left">
             
                       <Dna:AspxDropDownList ID="issue_type" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="10" 
                       Width="100" DataTextField="issue_type" DataValueField="issue_type" >
                       <asp:ListItem Text="3G_RETENTION" Value="3G_RETENTION"></asp:ListItem>
                       <asp:ListItem Text="2G_RETENTION" Value="2G_RETENTION"></asp:ListItem>
                       <asp:ListItem Text="GO_WIRELESS" Value="GO_WIRELESS"></asp:ListItem>
                       <asp:ListItem Text="MOBILE_LITE" Value="MOBILE_LITE"></asp:ListItem>
                       <asp:ListItem Text="UPGRADE" Value="UPGRADE"></asp:ListItem>
                       </Dna:AspxDropDownList>
              </td>
              <td>
              </td>
              </tr>
              
              
              <tr>
              <td class="myform_title">
                <label class="myform_label">Active
                <span class="small">Is it active?</span>
                </label>
              </td>
              <td >
              <table id="Table1" runat="server" cellpadding="0" cellspacing="0" style="border:Solid 1px #98B5D6; margin:0 0 0 0; padding:0 0 0 0; width:auto; ">
              <tr>
              <td style="background-color:White">

              <Dna:AspxCheckBox ID="active" runat="server" />
              
              </td>
              </tr>
              </table>
                

              </td>
              <td>
              </td>
              </tr>     

              
              <tr>
              <td class="myform_title">
                <label class="myform_label">Create User ID
                <span class="small">Your user id</span>
                </label>
              </td>
              <td>
              <Dna:AspxTextBox  ID="cid"  runat="server" Width="100px"  
             HintMessage="Please kindly Enter The User Id"></Dna:AspxTextBox>

              </td>
               <td >

              </td>
              </tr>
              
              <tr>
              <td>
                <label class="myform_label">VAS Name
                    <span class="small">Please kindly select the vas name</span>
                </label>
              </td>
              <td align="left">
             
                       <Dna:AspxDropDownList ID="vas1" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="10"
                       Width="300" DataTextField="vas_name" DataValueField="vas_field" AutoPostBack="true"
                           onselectedindexchanged="vas1_SelectedIndexChanged" >

                           

                       </Dna:AspxDropDownList>
              </td>
              <td>
              </td>
              </tr>
              
              
              
              <tr>
              <td>
                <label class="myform_label">VAS 1
                <span class="small">Please kindly select the vas drop down list one</span>
                </label>
              </td>
              <td align="left">
             
                       <Dna:AspxDropDownList ID="value1_drp" DataTextField="vas_value" DataValueField="vas_value" Rows="10"
                                                            AppendDataBoundItems="true" runat="server" Font-Size="12px" Width="300">

                           

                        </Dna:AspxDropDownList>
                        <br />
                        <table id="Table2" runat="server" cellpadding="0" cellspacing="0" style="border:Solid 1px #98B5D6; margin:0 0 0 0; padding:0 0 0 0; width:200px; ">
                      <tr>


                      <td style="background-color:White" nowrap="nowrap">
<span class="small">Display : </span>
   </td>
                      <td style="background-color:White" nowrap="nowrap">
                            <Dna:AspxCheckBox ID="display1" runat="server" />
                      
                      </td>
                      <td style="background-color:White" nowrap="nowrap">
<span class="small">Enabled : </span>
</td>
<td style="background-color:White" nowrap="nowrap">
                            <Dna:AspxCheckBox ID="enabled1" runat="server" />
                      
                      </td>
                      </tr>
                      </table>
                        
              </td>
              <td>
                    
              
              </td>
              </tr>
              
              
              
              <tr>
              <td>
                <label class="myform_label">VAS 2
                <span class="small">Please kindly select the vas drop down list two</span>
                </label>
              </td>
              <td align="left">
             <Dna:AspxDropDownList ID="value2_drp" DataTextField="vas_desc" DataValueField="fee" Rows="10"
                                                            AppendDataBoundItems="true" runat="server" Font-Size="12px" Width="300">

                        

                        </Dna:AspxDropDownList><br />
                       <table id="Table3" runat="server" cellpadding="0" cellspacing="0" style="border:Solid 1px #98B5D6; margin:0 0 0 0; padding:0 0 0 0; width:200px; ">
                      <tr>

                      <td style="background-color:White;" nowrap="nowrap">
                      <span class="small">Display : </span>
                         </td>
                      <td style="background-color:White" nowrap="nowrap">
                            <Dna:AspxCheckBox ID="display2" runat="server" />
                      
                      </td>
                      <td style="background-color:White;" nowrap="nowrap">
                      <span class="small"> Enabled : </span>
                         </td>
                      <td style="background-color:White" nowrap="nowrap">
                            <Dna:AspxCheckBox ID="enabled2" runat="server" />
                      
                      </td>
                      </tr>
                      </table>
              </td>
              <td>
                    
              
              </td>
              </tr>
              
              
         
              
              <tr>
              <td>
                <label class="myform_label">End Date
                <span class="small">Set end date</span>&nbsp;</label></td>
              <td align="left">


                <table cellpadding="0" cellspacing="0" border="0" >
                <tr>
                <td>
                <Dna:AspxTextBox ID="edate" Width="100px"  runat="server"  HintMessage="Please kindly Enter The End Date" />
                </td>
                <td>
                <asp:ImageButton runat="server" ID="CalenderImageEDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>

                                <cc1:CalendarExtender runat="server" 
                                    ID="CalendarEDateFormat"
                                    TargetControlID="edate"
                                    Format="dd/MM/yyyy"
                                    PopupButtonID="CalenderImageEDate" ></cc1:CalendarExtender>
                </td>
                </tr>
                </table>
                
                
                  <br />

                
              </td>
              <td>
              </td>
              </tr>
              
              
              <tr>
              <td>
              </td>
              <td>

                      <Dna:AspxButton ID="VasRuleAdd" Text="Vas Rule Add" runat="server" 
                          onclick="VasRuleAdd_Click"  />
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
                        <td class="cat" colspan="3">
                            <span class="explaintitle">&nbsp; </span>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

