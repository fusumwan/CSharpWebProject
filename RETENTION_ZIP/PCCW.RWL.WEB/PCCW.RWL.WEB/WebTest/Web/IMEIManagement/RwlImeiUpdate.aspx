<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/RWLMenu.master" AutoEventWireup="true" CodeFile="RwlImeiUpdate.aspx.cs" Inherits="Web_IMEIManagement_RwlImeiUpdate" %>
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
              <h1>IMEI Update Form</h1>
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
              <Dna:AspxTextBox  ID="edf_no" runat="server" ValidationGroup="AssignImeiGroup" Width="250px" onblur="ChkExistingOrder(this);"  
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
              <Dna:AspxTextBox  ID="imei_no"  runat="server" Width="250px"  onblur="ChkExistingIMEI(this);"
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
              </td>
              <td>

                      <Dna:AspxButton ID="SubmitBut" Text="Update" runat="server" OnClick="SubmitBut_OnClick" ValidationGroup="AssignImeiGroup" />
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
              
                  <br />
                  <br />
              
               <Dna:AspxGridView ID="MobileRetentionOrderGv" runat="server" AllowPaging="True" DataSourceID="MobileRetentionOrderObj"
                                            PageSize="15" DataKeyNames="order_id" AllowSorting="True" EmptyDataText="There has no record"
                                            AutoGenerateColumns="False" EmptyShowHeader="true" 
                                            UseSelectCommand="false"  >
                                            <AspxFilterSetting AllowFilter="true" />
                                            <PagerSettings Position="TopAndBottom" />
               <Columns>
              <Dna:AspxBoundField DataField="order_id" CLOSE_FILTER="true" InsertVisible="false" Visible="false"></Dna:AspxBoundField>
              
                <Dna:AspxTemplateField FilterDataField="log_date" SortExpression="log_date" HeaderText="Log Date"
                 TypeCode="DateTime" FilterDataFormatString="dd/MM/yyyy" LIKE="false">
                    <ItemTemplate>
                        <asp:Literal ID="log_date" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "log_date","{0:dd/MM/yyyy}")%>'></asp:Literal>
                    </ItemTemplate>
                </Dna:AspxTemplateField>
                      
                      
                <Dna:AspxTemplateField FilterDataField="edf_no" SortExpression="edf_no" HeaderText="EDF No."
                    TypeCode="String" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
                    SMALLER_AND_EQUAL_TO="false">
                    <ItemTemplate>
                        <table id="edf_no_tabl" border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td nowrap="nowrap">
                                    <asp:Literal ID="edf_no" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "edf_no")%>'></asp:Literal>

                                </td>
                            </tr>
                        </table>
                        
                    </ItemTemplate>
                 </Dna:AspxTemplateField>
                            
                            
                 <Dna:AspxTemplateField FilterDataField="imei_no" SortExpression="imei_no" HeaderText="Imei No."
                    TypeCode="String" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
                    SMALLER_AND_EQUAL_TO="false">
                    <ItemTemplate>
                        <table id="imei_no_tabl" border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td nowrap="nowrap">
                                    <asp:Literal ID="imei_no" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "imei_no")%>'></asp:Literal>

                                </td>
                            </tr>
                        </table>
                        
                    </ItemTemplate>
                 </Dna:AspxTemplateField>           
                 
                 
                 <Dna:AspxTemplateField FilterDataField="family_name" SortExpression="family_name" HeaderText="Family Name."
                    TypeCode="String" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
                    SMALLER_AND_EQUAL_TO="false">
                    <ItemTemplate>
                        <table id="imei_no_tabl" border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td nowrap="nowrap">
                                    <asp:Literal ID="imei_no" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "family_name")%>'></asp:Literal>

                                </td>
                            </tr>
                        </table>
                        
                    </ItemTemplate>
                 </Dna:AspxTemplateField>           
                 
                 
                 <Dna:AspxTemplateField FilterDataField="given_name" SortExpression="given_name" HeaderText="Given Name."
                    TypeCode="String" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
                    SMALLER_AND_EQUAL_TO="false">
                    <ItemTemplate>
                        <table id="given_tabl" border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td nowrap="nowrap">
                                    <asp:Literal ID="given" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "given_name")%>'></asp:Literal>

                                </td>
                            </tr>
                        </table>
                        
                    </ItemTemplate>
                 </Dna:AspxTemplateField>      
                            
              
               <Dna:AspxTemplateField FilterDataField="program" SortExpression="program" HeaderText="Program"
                    TypeCode="String" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
                    SMALLER_AND_EQUAL_TO="false">
                    <ItemTemplate>
                        <table id="program_tabl" border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td nowrap="nowrap">
                                    <asp:Literal ID="program" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "program")%>'></asp:Literal>
                                    


                                    
                                </td>
                            </tr>
                        </table>
                        
                   </ItemTemplate>
               </Dna:AspxTemplateField>
              
              <Dna:AspxTemplateField FilterDataField="rate_plan" SortExpression="rate_plan" HeaderText="Rate Plan"
                    TypeCode="String" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
                    SMALLER_AND_EQUAL_TO="false">
                    <ItemTemplate>
                        <table id="rate_plan_tabl" border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td nowrap="nowrap">
                                    <asp:Literal ID="rate_plan" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "rate_plan")%>'></asp:Literal>

                                </td>
                            </tr>
                        </table>
                        
                   </ItemTemplate>
               </Dna:AspxTemplateField>
              
              <Dna:AspxTemplateField FilterDataField="con_per" SortExpression="con_per" HeaderText="Contract Period"
                    TypeCode="String" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
                    SMALLER_AND_EQUAL_TO="false">
                    <ItemTemplate>
                        <table id="con_per_tabl" border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td nowrap="nowrap">
                                    <asp:Literal ID="con_per" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "con_per")%>'></asp:Literal>

                                </td>
                            </tr>
                        </table>
                        
                   </ItemTemplate>
               </Dna:AspxTemplateField>
               
               
               <Dna:AspxTemplateField FilterDataField="hs_model" SortExpression="hs_model" HeaderText="Handset"
                    TypeCode="String" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
                    SMALLER_AND_EQUAL_TO="false">
                    <ItemTemplate>
                        <table id="hs_model_tabl" border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td nowrap="nowrap">
                                    <asp:Literal ID="hs_model" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "hs_model")%>'></asp:Literal>

                                </td>
                            </tr>
                        </table>
                        
                   </ItemTemplate>
               </Dna:AspxTemplateField>
               
               <Dna:AspxTemplateField FilterDataField="sku" SortExpression="sku" HeaderText="Sku"
                    TypeCode="String" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
                    SMALLER_AND_EQUAL_TO="false">
                    <ItemTemplate>
                        <table id="sku_tabl" border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td nowrap="nowrap">
                                    <asp:Literal ID="sku" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "sku")%>'></asp:Literal>

                                </td>
                            </tr>
                        </table>
                        
                   </ItemTemplate>
               </Dna:AspxTemplateField>
              
              </Columns>
              </Dna:AspxGridView>
              <br />
              
              
              
                  <asp:SqlDataSource ID="MobileRetentionOrderObj" runat="server" 
                      ConnectionString="<%$ ConnectionStrings:MobileRetentionOrderDB2 %>" 
                      
                      SelectCommand="SELECT Top 100 [order_id],[log_date], [edf_no],[imei_no],[family_name], [given_name],  [program], [rate_plan], [con_per], [hs_model], [sku] FROM [MobileRetentionOrder] with(nolock)" 
                      oninit="MobileRetentionOrderObj_Init"></asp:SqlDataSource>
              
              
              
              
              
              
              
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

