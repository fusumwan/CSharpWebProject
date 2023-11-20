<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MasterDetailRetentionPlanUsageCreate.ascx.cs" Inherits="UI_MasterDetailRetentionPlanUsageCreate" %>
<link rel="stylesheet" href="../Resources/Styles/RWLFormStyle.css" type="text/css" />
<script language="javascript" type="text/javascript">
    
</script>

<table>
<tr>
<td class="InsertUsageTD">
<Dna:AspxButton ID="InsertUsage" Text="Insert Usage Mapping" runat="server" />
</td>
<td class="InsertUsageTD">
<Dna:AspxButton ID="CloseUsage" Text="Close" runat="server" />
</td>
</tr>
</table>

<div id="UsageForm" style="display:none">
<asp:UpdatePanel ID="Up2" runat="server" RenderMode="Inline" UpdateMode="Conditional" >
<ContentTemplate>

        
        
        <table id="myFormBorder" class="myformborder" cellpadding="0" cellspacing="5" >
              <tr>
              <td>
              <table id="stylized" class="myform" cellpadding="0" cellspacing="0" border="0" >
              
              <tr>
              <td colspan="2" >
              <h1>Retention Plan Code Usage Form</h1>
              <p>This form is used for create rate plan usage mapping </p>
              </td>
              </tr>
              
              
              
              
             
              <tr>
              <td>
                <label class="myform_label">Rate Plan
                <span class="small">Please do not create duplicate rate plan usage record</span>
                </label>
              </td>
              <td align="left">
                      <table>
                      <tr>
                      <td class="InsertUsageField">
                       <Dna:AspxDropDownList ID="rate_plan" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="10" 
                       Width="350px" DataTextField="rate_plan" DataValueField="rate_plan"  ValidationGroup="RatePlanVasGroup">
                       </Dna:AspxDropDownList>  
                       
                       </td>
                       </table>
              </td>
              </tr>
              
              
              <tr>
              <td>
                <label class="myform_label">Rate Plan Vas
                <span class="small">If you input a new value in the field not need to select the drop down list</span>
                </label>
              </td>
              <td align="left" nowrap="nowrap">
              <table>
                      <tr>
                      <td class="InsertUsageField">
               <Dna:AspxTextBox ID="rate_plan_vas_new" runat="server"></Dna:AspxTextBox>
              </td>
              <td>
              &nbsp;
              </td>
              <td  class="InsertUsageField">
              <Dna:AspxDropDownList ID="rate_plan_vas" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="10" onchange="copyValue(this,GetUserControl('rate_plan_vas_new'));" 
                       Width="350px" DataTextField="rate_plan_vas" DataValueField="rate_plan_vas"  ValidationGroup="RatePlanVasGroup">
                       </Dna:AspxDropDownList>  
              </td>
              </tr>
              </table>
              
                       
                       
              </td>
              </tr>
              
              
              <tr>
              <td>
                <label class="myform_label">Rate Plan Vas Value
                <span class="small">Only allow one rate plan vas value for rate plan vas</span>
                </label>
              </td>
              <td align="left">
              
              
                        <table>
                      <tr>
                      <td class="InsertUsageField">
                       <Dna:AspxTextBox ID="rate_plan_vas_value" runat="server" ValidationGroup="RatePlanVasGroup"></Dna:AspxTextBox>
                       <asp:RequiredFieldValidator ID="PlanFeeRequiredFieldValidator" EnableClientScript="true" ErrorMessage="* Please kindly Enter The Rate Plan Vas Value" runat="server" ControlToValidate="rate_plan_vas_value" ValidationGroup="RatePlanVasGroup">
                       </asp:RequiredFieldValidator>
                       </td>
                       </tr>
                       </table>
                       
                       
              </td>
              </tr>
              
              
              <tr>
              <td></td>
              <td align="left">
              
              
              <Dna:AspxButton ID="CreateRecord" runat="server" Text="Create Record"  ValidationGroup="RatePlanVasGroup"
                      onclick="CreateRecord_Click" />
              </td>
              </tr>
              
              </table>
              
              
              
              
              
                </td>
                </tr>
                </table>
         
</ContentTemplate>
</asp:UpdatePanel>
</div>