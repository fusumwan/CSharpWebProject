<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/RWLMenu.master" AutoEventWireup="true" CodeFile="OfferAutomation.aspx.cs" Inherits="Web_OfferAutomation" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Register Src="~/UI/MasterDetailCallListUploadMrtNo.ascx" TagName="MasterDetailCallListUploadMrtNo" TagPrefix="user" %>


<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="RWLHeaderContentPlace" Runat="Server">
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<link rel="stylesheet" href="../Resources/Styles/RWLFormStyle.css" type="text/css" />
<asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>

<script type="text/javascript" language="javascript">
    function DownloadSample() {
        document.location = "upload/OfferAutomationSample.xls";
        var DownloadFile = window.open("upload/OfferAutomationSample.xls", "DownloadFile");
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
              
              <table>
              <tr>
              <td>
              <Dna:AspxButton ID="BackBtn" runat="server" Text="Back" PostBackUrl="BasicBackEndManagement.aspx" />
              </td>
              <td>
              <Dna:AspxButton ID="CallListUploadBtn" runat="server" Text="Call List Upload" PostBackUrl="CallListUpload.aspx" />
              </td>
              </tr>
              </table>
              <br />
              
              
                      
                      
                      
                      
                      <table id="myFormBorder" class="myformborder" cellpadding="0" cellspacing="10">
              <tr>
              <td>
              <table id="stylized" class="myform" cellpadding="0" cellspacing="0" border="0">
              
              <tr>
              <td colspan="2" >
              <h1>Offer Automation Mapping Upload Form</h1>
              <p>This form is used for offer automation upload form.</p>
              </td>
              </tr>
              <tr>
              
                 <td class="myform_title" >
                <label class="myform_label">Upload File
                <span class="small">Please select the upload file</span>
                </label>
              </td>
              <td nowrap="nowrap">
              
              <table cellpadding="0" cellspacing="0" style=" margin:0 0 0 0; padding:0 0 0 0; width:auto; ">
              <tr>
              <td>
              <asp:FileUpload ID="ExcelUpload" runat="server" Width="500px" ValidationGroup="UploadOfferName" accept="*.xls"/>
              </td>
              <td>
              
              <table cellpadding="0" cellspacing="0" style=" margin:0 0 0 0; padding:0 0 0 0; width:auto; height:auto; " border="0">
              <tr>
              <td nowrap="nowrap" style=" height:auto;">
              <asp:RegularExpressionValidator ID="ExcelUploadRegularExpressionValidator" ControlToValidate="ExcelUpload" ErrorMessage=" * Please Kindly Select Excel File"
                CssClass="dismiss" runat="server" ValidationGroup="UploadOfferName" ValidationExpression="(.*\.([Xx][Ll][Ss])$)">
               </asp:RegularExpressionValidator>

              </td>
              </tr>
              <tr>
              <td nowrap="nowrap" style=" height:auto;">
              <asp:RequiredFieldValidator ID="ExcelUploadRequiredFieldValidator" 
           ControlToValidate="ExcelUpload" ErrorMessage=" * Please Kindly Select Excel File"
                CssClass="dismiss" runat="server" ValidationGroup="UploadOfferName"></asp:RequiredFieldValidator>
                </td>
              </tr>
              </table>
                
              </td>
              </tr>
              </table>
              </tr>
              
   
                      
  
              
              
               <tr>
              <td class="myform_title" >
                <label class="myform_label">Excel Version
                <span class="small">Please select the excel version</span>
                </label>
                </td>
                <td nowrap="nowrap">
                <table cellpadding="0" cellspacing="0" style=" margin:0 0 0 0; padding: 0 0 0 0; border:none; width:250px;">
                <tr>
                <td>
                <Dna:AspxRadioButtonList ID="excelversion" runat="server" RepeatLayout="Table" 
                        RepeatDirection="Horizontal" >
                <asp:ListItem Text="Excel 2003" Value="EXCEL2003" Selected="True"></asp:ListItem>
                <asp:ListItem Text="Excel 2007" Value="EXCEL2007"></asp:ListItem>
                </Dna:AspxRadioButtonList>
                </td>
                </tr>
                </table>
                </td>
              </tr>
              
              
                  

              
              
                   
                <tr>
              <td class="myform_title" >
                <label class="myform_label">Sample Format
                <span class="small">Please download the sample</span>
                </label>
                </td>
                <td nowrap="nowrap">
                <a href="upload/OfferAutomationSample.xls" >Download Sample Format </a>
                </td>
              </tr>
              
              
              
               <tr>
              <td class="myform_title" >
                <label class="myform_label">
                <span class="small"></span>
                </label>
                </td>
                <td nowrap="nowrap">
                <Dna:AspxButton ID="SubmitBtn" Text="Upload" runat="server" 
                        ValidationGroup="UploadOfferName" onclick="SubmitBtn_Click" />
                </td>
              </tr>
              </table>
              <br />
              

                   
<Dna:AspxGridView ID="AspxOfferAutomationGV" runat="server" AllowExpanding="true"
                      AllowPaging="True" PageSize="15" 
                      AllowSorting="True" DataKeyNames="id" EmptyDataText="Cannot Find Record"
    DataSourceID="OfferAutomationObj" AutoGenerateColumns="False"
                      EmptyShowHeader="true" onrowdeleting="AspxOfferAutomationGV_RowDeleting"  >
                      <PagerSettings Position="TopAndBottom" />
                       <AspxFilterSetting AllowFilter="True" />
                      <Columns>
                      
                      <asp:TemplateField>
                <ItemTemplate>
                
                <table id="EditCommandTable" cellpadding="0" border="0" style="height:100%; width:100%; background-color:White">
                <tr>
                <td nowrap="nowrap">
                <Dna:AspxButton ID="ExpandBut" runat="server" Text="Expand" CommandName="EXPAND" CommandArgument='<%# Eval("call_list_program_id") %>'>
                </Dna:AspxButton>
                <Dna:AspxButton  ID="EditBut" CommandName="Edit" Text="Edit" runat="server" CommandArgument='<%# ((GridViewRow)Container).RowIndex %>' />
                <Dna:AspxButton  ID="DeleteBut" CommandName="Delete" Text="Delete" runat="server" CommandArgument='<%# ((GridViewRow)Container).RowIndex %>' OnClientClick="return confirm('Are you sure you want to Delete?')" />
                </td>
                </tr>
                </table>
                </ItemTemplate>
                <EditItemTemplate>
                <table id="EditCommandTable" cellpadding="0" border="0" style="height:100%; width:100%; background-color:White">
                <tr>
                <td nowrap="nowrap">
                <Dna:AspxButton ID="UpdateBut" CommandName="Update" Text="Update" runat="server" OnClientClick="return confirm('Are you sure you want to Save?');" CommandArgument='<%# ((GridViewRow)Container).RowIndex %>' />
                <Dna:AspxButton ID="CancelBut" CommandName="Cancel" Text="Cancel" runat="server" CommandArgument='<%# ((GridViewRow)Container).RowIndex %>' />
                </td>
                </tr>
                </table>
                </EditItemTemplate>
                </asp:TemplateField>
                      <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" Visible="false" InsertVisible="false" />
            
            
            <Dna:AspxTemplateField FilterDataField="offer_name" SortExpression="offer_name" HeaderText="Offer Name" TypeCode="String">
            <ItemTemplate>
            <asp:Literal ID="offer_name" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "offer_name")%>'></asp:Literal>
            </ItemTemplate>
            <EditItemTemplate>
           <Dna:AspxTextBox ID="offer_name" runat="server" Text='<%# Bind(Container.DataItem, "offer_name")%>'></Dna:AspxTextBox>
           </EditItemTemplate>
           </Dna:AspxTemplateField>
            
            
            <Dna:AspxTemplateField FilterDataField="trade_field_id" SortExpression="trade_field_id" HeaderText="Trade Field Mapping ID" TypeCode="Int32">
            <ItemTemplate>
            <asp:Literal ID="trade_field_id" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "trade_field_id")%>'></asp:Literal>
            </ItemTemplate>
            <EditItemTemplate>
           <Dna:AspxTextBox ID="trade_field_id" runat="server" Text='<%# Bind(Container.DataItem, "trade_field_id")%>'></Dna:AspxTextBox>
           </EditItemTemplate>
           </Dna:AspxTemplateField>
            
            <Dna:AspxTemplateField FilterDataField="call_list_program_id" SortExpression="call_list_program_id" HeaderText="Call List Program ID" TypeCode="Int64">
            <ItemTemplate>
            <asp:Literal ID="call_list_program_id" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "call_list_program_id")%>'></asp:Literal>
            </ItemTemplate>
            <EditItemTemplate>
           <Dna:AspxTextBox ID="call_list_program_id" runat="server" Text='<%# Bind(Container.DataItem, "call_list_program_id")%>'></Dna:AspxTextBox>
           </EditItemTemplate>
           
           </Dna:AspxTemplateField>
              
              
                       <Dna:AspxTemplateField FilterDataField="active" SortExpression="active" HeaderText="Active" TypeCode="Boolean"
        GREATER_THAN="false"
        GREATER_AND_EQUAL_TO="false"
        SMALLER_THAN="false"
        SMALLER_AND_EQUAL_TO="false"
        LIKE="false"
        >
        <ItemTemplate>

        <Dna:AspxCheckBox ID="active" Enabled="false" Checked='<%# DataBinder.Eval(Container.DataItem, "active")%>' runat="server" />
        </ItemTemplate>
        <EditItemTemplate>
        <Dna:AspxCheckBox ID="active"  Checked='<%# Bind(Container.DataItem, "active")%>' runat="server" />
        </EditItemTemplate>
        </Dna:AspxTemplateField>

                                    
                </Columns>
                
               
                <MasterDetailTemplate>
                <table style="width:100%; padding: 3px 3px 3px 3px">
                <tr>
                <td align="center">
                 <user:MasterDetailCallListUploadMrtNo ID="MasterDetailCallListUploadMrtNo" runat="server" />
                </td>
                </tr>
               </table>
                   
                </MasterDetailTemplate>
                
                </Dna:AspxGridView>
              <br />
              
              
                
                                 <asp:SqlDataSource ID="OfferAutomationObj" runat="server" 
                      ConnectionString="<%$ ConnectionStrings:MobileRetentionOrderDB2 %>" 
                      DeleteCommand="DELETE FROM [OfferAutomation] WHERE [id] = @id" 
                      InsertCommand="INSERT INTO [OfferAutomation] ([offer_name], [trade_field_id], [call_list_program_id], [active]) VALUES (@offer_name, @trade_field_id, @call_list_program_id, @active)" 
                      SelectCommand="SELECT [id], [offer_name], [trade_field_id], [call_list_program_id], [active] FROM [OfferAutomation]" 
                      
                      UpdateCommand="UPDATE [OfferAutomation] SET [offer_name] = @offer_name, [trade_field_id] = @trade_field_id, [call_list_program_id] = @call_list_program_id, [active] = @active WHERE [id] = @id" 
                      oninit="OfferAutomationObj_Init" >
                       <DeleteParameters>
                           <asp:Parameter Name="id" Type="Int32" />
                       </DeleteParameters>
                       <UpdateParameters>
                           <asp:Parameter Name="offer_name" Type="String" />
                           <asp:Parameter Name="trade_field_id" Type="Int32" />
                           <asp:Parameter Name="call_list_program_id" Type="Int64" />
                           <asp:Parameter Name="active" Type="Boolean" />
                           <asp:Parameter Name="id" Type="Int32" />
                       </UpdateParameters>
                       <InsertParameters>
                           <asp:Parameter Name="offer_name" Type="String" />
                           <asp:Parameter Name="trade_field_id" Type="Int32" />
                           <asp:Parameter Name="call_list_program_id" Type="Int64" />
                           <asp:Parameter Name="active" Type="Boolean" />
                       </InsertParameters>
                      </asp:SqlDataSource>
                      
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
        

</td>
</tr>
</table>

              
</asp:Content>

