<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/RWLMenu.master" AutoEventWireup="true" CodeFile="CallListUpload.aspx.cs" Inherits="Web_CallListUpload" %>
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
<script type="text/javascript" language="javascript">
    function DownloadSample() {
        document.location = "upload/CallListUploadMrtNoSample.xls";
        var DownloadFile = window.open("upload/CallListUploadMrtNoSample.xls", "DownloadFile");
    }
</script>


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
              <Dna:AspxButton ID="BackBtn" runat="server" Text="Back" PostBackUrl="BasicBackEndManagement.aspx" />
              </td>
              <td>
              <Dna:AspxButton ID="OfferAutomationBtn" runat="server" Text="Offer Automation" PostBackUrl="OfferAutomation.aspx" />
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
              <h1>Call List Upload Form</h1>
              <p>This form is used for upload mobile number.</p>
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
              <asp:FileUpload ID="ExcelUpload" runat="server" Width="500px" ValidationGroup="UploadCallistGroup" accept="*.xls"/>
              </td>
              <td>
              
              
              <table cellpadding="0" cellspacing="0" style=" margin:0 0 0 0; padding:0 0 0 0; width:auto; height:auto; " border="0">
              <tr>
              <td nowrap="nowrap" style=" height:auto;">
              <asp:RegularExpressionValidator ID="ExcelUploadRegularExpressionValidator" ControlToValidate="ExcelUpload" ErrorMessage=" * Please Kindly Select Excel File"
                CssClass="dismiss" runat="server" ValidationGroup="UploadCallistGroup" ValidationExpression="(.*\.([Xx][Ll][Ss])$)">
               </asp:RegularExpressionValidator>

              </td>
              </tr>
              <tr>
              <td nowrap="nowrap" style=" height:auto;">
              <asp:RequiredFieldValidator ID="ExcelUploadRequiredFieldValidator" 
           ControlToValidate="ExcelUpload" ErrorMessage=" * Please Kindly Select Excel File"
                CssClass="dismiss" runat="server" ValidationGroup="UploadCallistGroup"></asp:RequiredFieldValidator>
                </td>
              </tr>
              </table>
                
              </td>
              </tr>
              </table>
              </tr>
              
              
              <tr>
              <td class="myform_title" >
                <label class="myform_label">Call List Program ID
                <span class="small">Please enter the call list program id</span>
                </label>
                </td>
                <td nowrap="nowrap">
                <table cellpadding="0" cellspacing="0" style=" margin:0 0 0 0; padding: 0 0 0 0; border:none; width:250px;">
                <tr>
                <td>
                <Dna:AspxTextBox ID="call_list_program_id" runat="server"></Dna:AspxTextBox>
                  <asp:RequiredFieldValidator ID="CallListProgramIDRequiredFieldValidator" 
           ControlToValidate="call_list_program_id" ErrorMessage=" * Please Kindly Enter Call List Program ID"
                CssClass="dismiss" runat="server" ValidationGroup="UploadCallistGroup"></asp:RequiredFieldValidator>
                
                </td>
                </tr>
                </table>
                </td>
              </tr>
              
              
              
              
               <tr>
              <td class="myform_title" >
                <label class="myform_label">Issue type
                <span class="small">Please select the Issue type</span>
                </label>
                </td>
                <td nowrap="nowrap">
                <table cellpadding="0" cellspacing="0" style=" margin:0 0 0 0; padding: 0 0 0 0; border:none; width:250px;">
                <tr>
                <td>
                <Dna:AspxDropDownList ID="issue_type" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="4" 
                                                            Width="100"  CheckAndInsertBoundValue="true" >
                                                            <asp:ListItem Text="3G_RETENTION" Value="3G_RETENTION" Selected="True"></asp:ListItem>
                                                            <asp:ListItem Text="2G_RETENTION" Value="2G_RETENTION"></asp:ListItem>
                                                            <asp:ListItem Text="GO_WIRELESS" Value="GO_WIRELESS"></asp:ListItem>
                                                            <asp:ListItem Text="MOBILE_LITE" Value="MOBILE_LITE"></asp:ListItem>
                                                            <asp:ListItem Text="UPGRADE" Value="UPGRADE"></asp:ListItem>
                                                        </Dna:AspxDropDownList>
                </td>
                </tr>
                </table>
                </td>
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
              <td>
                <label class="myform_label">Start Date
                <span class="small">Set start date</span>&nbsp;</label></td>
              <td align="left">


                <table cellpadding="0" cellspacing="0" border="0" >
                <tr>
                <td>

                <Dna:AspxCalendar ID="sdate" runat="server" WithBorder="true" />
                </td>
                <td>
  <asp:RequiredFieldValidator ID="SdateRequiredFieldValidator" 
           ControlToValidate="sdate" ErrorMessage=" * Please kindly Enter The Start Date" 
                CssClass="dismiss" runat="server" ValidationGroup="UploadCallistGroup"></asp:RequiredFieldValidator>
                </td>
                <td>
              
                
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
                <label class="myform_label">End Date
                <span class="small">Set end date</span>&nbsp;</label></td>
              <td align="left">


                <table cellpadding="0" cellspacing="0" border="0" >
                <tr>
                <td>

               <Dna:AspxCalendar ID="edate" runat="server" WithBorder="true" />
                </td>
                <td>
<asp:RequiredFieldValidator ID="EdateRequiredFieldValidator" 
           ControlToValidate="sdate" ErrorMessage=" * Please kindly Enter The End Date"
                CssClass="dismiss" runat="server" ValidationGroup="UploadCallistGroup"></asp:RequiredFieldValidator>
                </td>
                <td>
                 
                </td>
                </tr>
                </table>
                
                
                  <br />

                
              </td>
              <td>
              </td>
              </tr>
              
              
              
              
              
                <tr>
              <td class="myform_title" >
                <label class="myform_label">Sample Format
                <span class="small">Please download the sample</span>
                </label>
                </td>
                <td nowrap="nowrap">
                <a href="upload/CallListUploadMrtNoSample.xls" >Download Sample Format </a>
                
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
                        ValidationGroup="UploadCallistGroup" onclick="SubmitBtn_Click"/>
                
                </td>
              </tr>
              </table>
              <br />
              
                   
<Dna:AspxGridView ID="AspxCallListUploadProfileGV" runat="server" 
                      AllowPaging="True" PageSize="15"
                      AllowSorting="True" DataKeyNames="id" EmptyDataText="Cannot Find Record"
    DataSourceID="CallListUploadProfileObj" AutoGenerateColumns="False"
                      EmptyShowHeader="true" 
                      onrowupdating="AspxCallListUploadProfileGV_RowUpdating"  >
                      <PagerSettings Position="TopAndBottom" />
                       <AspxFilterSetting AllowFilter="True" />
                      <Columns>
                      
                      <asp:TemplateField>
                <ItemTemplate>
                
                <table id="EditCommandTable" cellpadding="0" border="0" style="height:100%; width:100%; background-color:White">
                <tr>
                <td nowrap="nowrap">
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
            <Dna:AspxTemplateField FilterDataField="call_list_program_id" SortExpression="call_list_program_id" HeaderText="Call List Program ID" TypeCode="Int64">
            <ItemTemplate>
            <asp:Literal ID="call_list_program_id" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "call_list_program_id")%>'></asp:Literal>
            </ItemTemplate>
            <EditItemTemplate>
           <Dna:AspxTextBox ID="call_list_program_id" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "call_list_program_id")%>'></Dna:AspxTextBox>
           </EditItemTemplate>
           
           </Dna:AspxTemplateField>
           
           
           
           <Dna:AspxTemplateField FilterDataField="issue_type" SortExpression="issue_type" HeaderText="Issue Type"
                                                    TypeCode="String" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
                                                    SMALLER_AND_EQUAL_TO="false">
                                                    <ItemTemplate>
                                                    <table id="issue_type_tabl" border="0" cellpadding="0" cellspacing="0" width="100%">
                                                            <tr>
                                                                <td nowrap="nowrap" align="left">
                                                    
                                                                <asp:Literal ID="issue_type" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "issue_type")%>'></asp:Literal>
                                                            </td>
                                                        </tr>
                                                        </table></ItemTemplate>
                                                        <EditItemTemplate>
                                                        
                                                        
                                                        
                                                        
                                                        <Dna:AspxDropDownList ID="issue_type" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="4" 
                                                            Width="100"  CheckAndInsertBoundValue="true" UnBoundSelectedText='<%# Bind(Container.DataItem,"issue_type") %>' UnBoundSelectedValue='<%# DataBinder.Eval(Container.DataItem,"issue_type") %>' SelectedValue='<%# Bind(Container.DataItem, "issue_type")%>'>
                                                            <asp:ListItem Text="3G_RETENTION" Value="3G_RETENTION"></asp:ListItem>
                                                            <asp:ListItem Text="2G_RETENTION" Value="2G_RETENTION"></asp:ListItem>
                                                            <asp:ListItem Text="GO_WIRELESS" Value="GO_WIRELESS"></asp:ListItem>
                                                            <asp:ListItem Text="MOBILE_LITE" Value="MOBILE_LITE"></asp:ListItem>
                                                            <asp:ListItem Text="UPGRADE" Value="UPGRADE"></asp:ListItem>
                                                            </Dna:AspxDropDownList>
                                                            </EditItemTemplate>
                                                            </Dna:AspxTemplateField>
             <Dna:AspxTemplateField FilterDataField="sdate" SortExpression="sdate" HeaderText="Start Date"
            TypeCode="DateTime" FilterDataFormatString="dd/MM/yyyy" LIKE="false">
            <ItemTemplate>
                <asp:Literal ID="sdate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "sdate","{0:dd/MM/yyyy}")%>'></asp:Literal>
                </ItemTemplate>
                <EditItemTemplate>
                
                <table id="SdateTbl" runat="server" cellpadding="0" cellspacing="0">
                    <tr>
                        <td nowrap="nowrap">
                            <table cellpadding="0" cellspacing="0" border="0">
                                <tr>
                                    <td>
                                        <Dna:AspxTextBox ID="sdate" Width="100px" Text='<%# Bind(Container.DataItem, "sdate","{0:dd/MM/yyyy}")%>'
                                                                                    runat="server" HintMessage="Please kindly Enter The Start Date" />
                                    </td>
                                    <td>
                                                                                <asp:ImageButton runat="server" ID="CalenderImageSDate" ImageUrl="~/Resources/Images/calendar.png"
                                                                                    OnClientClick="return false;" />
                                                                                <cc1:CalendarExtender runat="server" ID="CalendarSDateFormat" TargetControlID="sdate"
                                                                                    Format="dd/MM/yyyy" PopupButtonID="CalenderImageSDate">
                                                                                </cc1:CalendarExtender>
                                                                            </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </EditItemTemplate>
        </Dna:AspxTemplateField>
        
        
         <Dna:AspxTemplateField FilterDataField="edate" SortExpression="edate" HeaderText="End Date"
                                                    TypeCode="DateTime" FilterDataFormatString="dd/MM/yyyy" LIKE="false">
                                                    <ItemTemplate>
                                                        <table id="edate_tabl" border="0" cellpadding="0" cellspacing="0" width="100%">
                                                            <tr>
                                                                <td nowrap="nowrap" align="left">
                                                        <asp:Literal ID="edate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "edate","{0:dd/MM/yyyy}")%>'></asp:Literal></td></tr></table></ItemTemplate><EditItemTemplate>
                                                        <table id="EdateTbl" runat="server" cellpadding="0" cellspacing="0">
                                                            <tr>
                                                                <td nowrap="nowrap" align="left">
                                                                    <table cellpadding="0" cellspacing="0" border="0">
                                                                        <tr>
                                                                            <td>
                                                                                <Dna:AspxTextBox ID="edate" Width="100px" Text='<%# Bind(Container.DataItem, "edate","{0:dd/MM/yyyy}")%>'
                                                                                    runat="server" HintMessage="Please kindly Enter The End Date" />
                                                                            </td>
                                                                            <td>
                                                                                <asp:ImageButton runat="server" ID="CalenderImageEDate" ImageUrl="~/Resources/Images/calendar.png"
                                                                                    OnClientClick="return false;" />
                                                                                <cc1:CalendarExtender runat="server" ID="CalendarEDateFormat" TargetControlID="edate"
                                                                                    Format="dd/MM/yyyy" PopupButtonID="CalenderImageEDate">
                                                                                </cc1:CalendarExtender>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </td>
                                                            </tr>
                                                        </table>
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
                </Dna:AspxGridView>
              
              
              <asp:SqlDataSource ID="CallListUploadProfileObj" runat="server" 
                      ConnectionString="<%$ ConnectionStrings:MobileRetentionOrderDB2 %>" 
                      DeleteCommand="DELETE FROM [CallListUploadProfile] WHERE [id] = @id" 
                      InsertCommand="INSERT INTO [CallListUploadProfile] ([call_list_program_id], [issue_type], [sdate], [edate], [active]) VALUES (@call_list_program_id, @issue_type, @sdate, @edate, @active)" 
                      SelectCommand="SELECT [id], [call_list_program_id], [issue_type], [sdate], [edate], [active] FROM [CallListUploadProfile]" 
                      
                      UpdateCommand="UPDATE [CallListUploadProfile] SET [call_list_program_id] = @call_list_program_id, [issue_type] = @issue_type, [sdate] = @sdate, [edate] = @edate, [active] = @active WHERE [id] = @id" 
                      oninit="CallListUploadProfileObj_Init" >
                  <DeleteParameters>
                      <asp:Parameter Name="id" Type="Int64" />
                  </DeleteParameters>
                  <UpdateParameters>
                      <asp:Parameter Name="call_list_program_id" Type="Int64"/>
                      <asp:Parameter Name="issue_type" Type="String" />
                      <asp:Parameter Name="sdate" Type="DateTime" />
                      <asp:Parameter Name="edate" Type="DateTime" />
                      <asp:Parameter Name="active" Type="Boolean" />
                      <asp:Parameter Name="id" Type="Int64" />
                  </UpdateParameters>
                  <InsertParameters>
                      <asp:Parameter Name="call_list_program_id" Type="Int64"/>
                      <asp:Parameter Name="issue_type" Type="String" />
                      <asp:Parameter Name="sdate" Type="DateTime" />
                      <asp:Parameter Name="edate" Type="DateTime" />
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

