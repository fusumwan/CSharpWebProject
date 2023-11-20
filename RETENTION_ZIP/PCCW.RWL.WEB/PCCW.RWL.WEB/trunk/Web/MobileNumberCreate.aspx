<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/RWLMenu.master" AutoEventWireup="true" CodeFile="MobileNumberCreate.aspx.cs" Inherits="Web_MobileNumberCreate" %>

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
  
  <script language="javascript">

      function chk_mobile(objC) {
          if (objC.value.length != 0) {
              if (objC.value.match(/^\d{11}$/) == null) {
                  jAlert("Invalid Contact Number!", "System Message");
                  //objC.select();
                  return false;
              }
              return true;
          }
          else
              return false;
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
              <td>


       <table id="Table1"  runat="server" cellpadding="1" cellspacing="3" >
      <tr>
      <td nowrap="nowrap">
       <Dna:AspxButton ID="Back"  Text="Back" PostBackUrl="BasicBackEndManagement.aspx" runat="server"  />
      </td>
      <td>
      <Dna:AspxButton ID="MobileNumberList"  Text="List Out Mobile Number" PostBackUrl="MobileNumberProfileView.aspx" runat="server"  />
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
              <h1>Mobile Number Create Form</h1>
              <p>This form is used for create mobile number.</p>
              </td>
              </tr>
              <tr>
              
              <td class="myform_title">
                <label class="myform_label">Mobile Number
                <span class="small">Enter The Mobile Number</span>
                </label>
              </td>
              <td nowrap="nowrap">
              <Dna:AspxTextBox  ID="mrt_no" runat="server" ValidationGroup="AssignImeiGroup" Width="250px" onblur="chk_mobile(this)"  MaxLength="11"
              InnerHintMessage="Please kindly Enter The Mobile Number" HintMessage="Please kindly Enter The Mobile Number"></Dna:AspxTextBox>
              <asp:RequiredFieldValidator ID="MrtNoRequiredFieldValidator" ControlToValidate="mrt_no" ErrorMessage=" * Please kindly Enter The Mobile Number"
                CssClass="dismiss" runat="server" ValidationGroup="AssignMobileNumberGroup" >
               </asp:RequiredFieldValidator>
              </td>
               <td nowrap="nowrap">
               
                
                
              </td>
              </tr>
              
              <tr>
              <td class="myform_title">
                <label class="myform_label">Pool
                <span class="small">Select The Mobile Number Pool</span>
                </label>
              </td>
              <td nowrap="nowrap">
              <Dna:AspxDropDownList ID="pool" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="2" Width="150" >
                <asp:ListItem Text="GUANGZHOU" Value="GUANGZHOU" Selected="True"></asp:ListItem>            
                <asp:ListItem Text="SHANGHAI" Value="SHANGHAI"></asp:ListItem>         
             </Dna:AspxDropDownList>
              </td>
              </tr>
              
            <tr>
              <td class="myform_title">
                <label class="myform_label">Mobile Group
                <span class="small">Select The Mobile Number Group</span>
                </label>
              </td>
              <td nowrap="nowrap">
              <Dna:AspxDropDownList ID="mrt_group" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="2" Width="150" DataTextField="mrt_group" DataValueField="mrt_group">
                                        <asp:ListItem Text="3GMOBILE" Value="3GMOBILE" Selected="True"></asp:ListItem>            
                                        <asp:ListItem Text="2GMOBILE" Value="2GMOBILE"></asp:ListItem>           
                                        </Dna:AspxDropDownList>
              </td>
              </tr>
              
                           
              <tr>
              <td>
              </td>
              <td>

                      <Dna:AspxButton ID="SubmitBut" Text="Submit" runat="server" OnClick="SubmitBut_OnClick" ValidationGroup="AssignMobileNumberGroup" />
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
