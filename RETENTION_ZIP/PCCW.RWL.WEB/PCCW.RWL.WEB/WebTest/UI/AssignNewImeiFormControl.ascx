<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AssignNewImeiFormControl.ascx.cs" Inherits="UI_AssignNewImeiFormControl" %>

<script language="javascript">

    function chk_mobile(objC) {
        if (objC.value.length != 0) {
            if (objC.value.match(/^\d{8}$/) == null) {
                alert("Invalid Contact Number!");
                objC.select();
                return false;
            }
            else if (objC.value.substring(0, 1) != "5" && objC.value.substring(0, 1) != "6" && objC.value.substring(0, 1) != "7" && objC.value.substring(0, 1) != "8" && objC.value.substring(0, 1) != "9") {
                alert("Invalid Contact Number! Please begins with 5/6/7/8/9!");
                objC.select();
                return false;
            }
            return true;
        }
        else
            return false;
    }
</script>

<asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional" >
<ContentTemplate>


        <table id="myFormBorder" class="myformborder" cellpadding="0" cellspacing="10">
              <tr>
              <td>
              <table id="stylized" class="myform" cellpadding="0" cellspacing="0" border="0">
              
              <tr>
              <td colspan="3">
              <h1>IMEI Assign/Register Form</h1>
              <p>This form is used for assign the imei to order.</p>
              </td>
              </tr>
              <tr>
              
              <td>
                <label  class="myform_label">Record ID
                <span class="small">Retention Order ID</span>
                </label>
              </td>
              <td>
              
               <asp:TextBox ID="record_id" CssClass="myform_text" runat="server" ValidationGroup="AssignImeiGroup"></asp:TextBox>
               
              </td>
              <td nowrap="nowrap">
              <asp:RequiredFieldValidator ID="ReceordIDRequiredFieldValidator" ControlToValidate="record_id" ErrorMessage=" * Please kindly Enter Record ID"
                CssClass="dismiss" runat="server" ValidationGroup="AssignImeiGroup" >
                </asp:RequiredFieldValidator>
              </td>
              </tr>
              
              <tr>
              <td>
                <label  class="myform_label">Mobile Number
                <span class="small">Retention/EDF Mobile Number</span>
                </label>
              </td>
              <td>
                <asp:TextBox ID="mrt_no" CssClass="myform_text" onblur="chk_mobile(this);" runat="server" ValidationGroup="AssignImeiGroup" ></asp:TextBox>
                
              </td>
              <td nowrap="nowrap">
              <asp:RequiredFieldValidator ID="MobileNoRequiredFieldValidator" ControlToValidate="mrt_no" ErrorMessage=" * Please kindly Enter Mobile Number"
                CssClass="dismiss" runat="server" ValidationGroup="AssignImeiGroup" >
                </asp:RequiredFieldValidator>
              </td>
              </tr>
              
              <tr>
              <td>
                <label  class="myform_label">IMEI
                <span class="small">Edf IMEI Number</span>
                </label>
              </td>
              <td>
                <asp:TextBox ID="imei_no" CssClass="myform_text" runat="server" ValidationGroup="AssignImeiGroup" ></asp:TextBox>

              </td>
              <td nowrap="nowrap">
              <asp:RequiredFieldValidator ID="ImeiNoRequiredFieldValidator" ControlToValidate="imei_no" ErrorMessage=" * Please kindly Enter Imei Number"
                CssClass="dismiss" runat="server" ValidationGroup="AssignImeiGroup" >
                </asp:RequiredFieldValidator>
              </td>
              
              </tr>
              
              <tr>
              <td>
                <label  class="myform_label">Sku
                <span class="small">Product Item Code</span>
                </label>
              </td>
              <td>
                <asp:TextBox ID="sku" CssClass="myform_text" runat="server" ValidationGroup="AssignImeiGroup" ></asp:TextBox>
                
                
              </td>
              <td nowrap="nowrap">
              <asp:RequiredFieldValidator ID="SkuRequiredFieldValidator" ControlToValidate="sku" ErrorMessage=" * Please kindly Enter Item Code"
                CssClass="dismiss" runat="server" ValidationGroup="AssignImeiGroup" >
                </asp:RequiredFieldValidator>
              </td>
              </tr>     
              
              <tr>
              <td ></td>
              <td align="center">
                <Dna:AspxButton ID="AssignIMEIToRecordBtn" Text="Assign IMEI To Order Record"  ValidationGroup="AssignImeiGroup" 
                      runat="server" onclick="AssignIMEIToRecordBtn_Click" />
              </td>
              <td ></td>
              </tr>

              
              </table>
              </td>
              </tr>
              </table>
</ContentTemplate>
</asp:UpdatePanel>
