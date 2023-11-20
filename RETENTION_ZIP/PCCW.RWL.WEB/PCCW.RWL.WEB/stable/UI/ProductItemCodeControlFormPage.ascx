<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProductItemCodeControlFormPage.ascx.cs" Inherits="Web_ProductItemCodeControlFormPage" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<link rel="stylesheet" href="../Resources/Styles/RWLFormStyle.css" type="text/css" />
<script language="javascript">


    function ValidateSku(source, args) {
        //var SkuObj = document.getElementById("ctl00_RWLContentPlace_ProductItemCodeControlFormPage_item_code");
        var SkuObj = document.getElementById('<%= item_code.ClientID %>');
        SkuObj.value = jQuery.trim(SkuObj.value);
        var ResultMsg = $.ajax({
            type: 'post',
            url: 'Handler/SqlHandler.ashx',
            data: "method=ITEMCODECHK&filter=" + SkuObj.value,
            dataType: 'text',
            cache: false,
            async: false
        }).responseText;
        if (ResultMsg != "") {
            args.IsValid = false;
        } else {
            args.IsValid = true;
        }
    }    

</script>

<asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional" >
<ContentTemplate>
        <table id="myFormBorder" class="myformborder" cellpadding="0" cellspacing="10">
              <tr>
              <td>
              <table id="stylized" class="myform" cellpadding="0" cellspacing="0" border="0">
              <tr>
              <td colspan="3" >
              <h1>Product Register Form</h1>
              <p>This form is used for register product.</p>
              </td>
              </tr>
              <tr>
              
              <td class="myform_title">
                <label class="myform_label">HandSet
                <span class="small">Add model name</span>
                </label>
              </td>
              <td>
              <Dna:AspxTextBox  ID="hs_model" runat="server" ValidationGroup="AssignImeiGroup" Width="250px"  MaxLength="50"
              InnerHintMessage="Please kindly Enter The Hs model" HintMessage="Please kindly Enter The Hs model"></Dna:AspxTextBox>
              </td>
               <td nowrap="nowrap">
               <asp:RequiredFieldValidator ID="HsModelRequiredFieldValidator" ControlToValidate="hs_model" ErrorMessage=" * Please kindly Enter Handset Model Name"
                CssClass="dismiss" runat="server" ValidationGroup="AssignImeiGroup" >
               </asp:RequiredFieldValidator>
                
                
              </td>
              </tr>
              
              <tr>
              <td class="myform_title">
                <label class="myform_label">Item Code
                <span class="small">Add a Item code</span>
                </label>
              </td>
              <td>
              <Dna:AspxTextBox  ID="item_code"  runat="server" Width="250px" 
              InnerHintMessage="Please kindly Enter The Item code" HintMessage="Please kindly Enter The Item code"></Dna:AspxTextBox>
              <asp:CustomValidator ID="ItemCodeRequiredFieldValidator" ClientValidationFunction="ValidateSku" ControlToValidate = "item_code" ErrorMessage=" * The item code has been used"
              CssClass="dismiss" runat="server" ValidationGroup="AssignImeiGroup"></asp:CustomValidator>
              
              </td>
               <td nowrap="nowrap" class="myform_title">

              </td>
              </tr>
              
              <tr>
              <td class="myform_title">
                <label class="myform_label">Last Stock
                <span class="small">Is it last stock?</span>
                </label>
              </td>
              <td >
              <table id="CheckBoxTbl" runat="server" cellpadding="0" cellspacing="0" style="border:Solid 1px #98B5D6; margin:0 0 0 0; padding:0 0 0 0; width:auto; ">
              <tr>
              <td style="background-color:White">

              <Dna:AspxCheckBox ID="last_stock" runat="server" />
              
              </td>
              </tr>
              </table>
                

              </td>
              <td>
              </td>
              </tr>     
              
              <tr>
              <td>
                <label class="myform_label">Type
                <span class="small">Select the type of product</span>
                </label>
              </td>
              <td align="left">
             
                      <Dna:AspxDropDownList ID="drpType" DataTextField="TYPE" DataValueField="TYPE" runat="server" Width="200px" HitMessage="Please Kindly Select" Font-Size="12px" >
                      <asp:ListItem Text="" Value=""></asp:ListItem>
                      <asp:ListItem Text="HS" Value="HS"></asp:ListItem>
                      <asp:ListItem Text="PMU" Value="PMU"></asp:ListItem>
                      <asp:ListItem Text="SIM" Value="SIM"></asp:ListItem>
                      <asp:ListItem Text="SPMU" Value="SPMU"></asp:ListItem>
                      </Dna:AspxDropDownList>
              </td>
              <td>
              </td>
              </tr>
             
              
              
              <tr>
              <td>
                <label class="myform_label">Quota
                <span class="small">Set product quota</span>
                </label>
              </td>
              <td>

                              <Dna:AspxTextBox  ID="quota"  runat="server" Width="50px"  
              HintMessage="Please kindly Enter The Quota"></Dna:AspxTextBox>
                
              </td>
              <td>
              </td>
              </tr>
              
              <tr>
              <td>
                <label class="myform_label">Start Date
                <span class="small">Set start date</span>&nbsp;</label></td>
              <td align="left">


                <table cellpadding="0" cellspacing="0" border="0" >
                <tr>
                <td>
                <Dna:AspxTextBox ID="sdate" Width="100px"  Text='<%# Bind(Container.DataItem, "sdate","{0:dd/MM/yyyy}")%>' runat="server"  HintMessage="Please kindly Enter The Start Date" />
                </td>
                <td>
                <asp:ImageButton runat="server" ID="CalenderImageSDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>

                                <cc1:CalendarExtender runat="server" 
                                    ID="CalendarSDateFormat"
                                    TargetControlID="sdate"
                                    Format="dd/MM/yyyy"
                                    PopupButtonID="CalenderImageSDate" ></cc1:CalendarExtender>
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

                      <Dna:AspxButton ID="ProductAdd" Text="Product Add" runat="server" onclick="ProductAdd_Click" ValidationGroup="AssignImeiGroup" />
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

</ContentTemplate>
</asp:UpdatePanel>