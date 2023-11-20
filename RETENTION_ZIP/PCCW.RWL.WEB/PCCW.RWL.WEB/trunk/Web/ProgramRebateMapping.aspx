<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/RWLMenu.master" AutoEventWireup="true" CodeFile="ProgramRebateMapping.aspx.cs" Inherits="Web_ProgramRebateMapping" %>
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
              <user:AttachmentHandlerJs ID="AttachmentControl" runat="server" />
        <table id="Table1"  runat="server" cellpadding="1" cellspacing="3" >
      <tr>
      <td nowrap="nowrap">
       <Dna:AspxButton ID="Back"  Text="Back" PostBackUrl="MobileRetentionMain.aspx" runat="server"  />
      </td>
<td>
              <Dna:AspxButton ID="ExportExcelBut" Text="Export Excel" OnClientClick="AttachmentExport('Handler','ProgramRebateMapping'); return false;" runat="server" />
              </td>
      </tr>
       </table>
       
       <table id="myFormBorder" class="myformborder" cellpadding="0" cellspacing="10">
              <tr>
              <td>
              <table id="stylized" class="myform" cellpadding="0" cellspacing="0" border="0">
              
              <tr>
              <td colspan="2" >
              <h1>Program Rebate Mapping Form</h1>
              <p>This form is used for assign program rebate.</p>
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
                       <asp:ListItem Text="WIN" Value="WIN"></asp:ListItem>
                       <asp:ListItem Text="MOBILE_LITE" Value="MOBILE_LITE"></asp:ListItem>
                       <asp:ListItem Text="UPGRADE" Value="UPGRADE"></asp:ListItem>
                       </Dna:AspxDropDownList>
              </td>

              </tr>
              
              
              <tr>
              <td class="myform_title">
                <label class="myform_label">Use Rebate Mapping
                <span class="small">Is it active the rebate mapping?</span>
                </label>
              </td>
              <td >
              <table id="Table2" runat="server" cellpadding="0" cellspacing="0" style="border:Solid 1px #98B5D6; margin:0 0 0 0; padding:0 0 0 0; width:auto; ">
              <tr>
              <td style="background-color:White">

              <Dna:AspxCheckBox ID="use_rebate_mapping" runat="server" />
              
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
                CssClass="dismiss" runat="server" ValidationGroup="ProgramRebateMappingGroup"></asp:RequiredFieldValidator>
                </td>
                <td>
              
                
                </td>
                </tr>
                </table>
                

                
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
                CssClass="dismiss" runat="server" ValidationGroup="ProgramRebateMappingGroup"></asp:RequiredFieldValidator>
                </td>
                <td>
                 
                </td>
                </tr>
                </table>

                
              </td>

              </tr>
              
               <tr>
              <td class="myform_title" >
                <label class="myform_label">
                <span class="small"></span>
                </label>
                </td>
                <td nowrap="nowrap" >
                <Dna:AspxButton ID="SubmitBtn" Text="Create" runat="server" 
                        ValidationGroup="ProgramRebateMappingGroup" onclick="SubmitBtn_Click"/>
                
                </td>
              </tr>
              
              
              
              </table>
              </td>
              </tr>
              
              
              
             
              
              </table>
       <br />
       
       <Dna:AspxGridView ID="AspxProgramRebateMappingGV" runat="server" 
                      AllowPaging="True" PageSize="15" DataSourceID="ProgramRebateMappingObj"
                      AllowSorting="True" DataKeyNames="id" EmptyDataText="Cannot Find Record"
                       AutoGenerateColumns="False" oninit="AspxProgramRebateMappingGV_Init" 
                      onrowupdating="AspxProgramRebateMappingGV_RowUpdating" >
                       <AspxFilterSetting AllowFilter="true" />
                                            <PagerSettings Position="TopAndBottom" />
      <Columns>
                <asp:TemplateField>
                <ItemTemplate>
                
                <table id="EditCommandTable" cellpadding="0" border="0" style="height:100%; width:100%; background-color:White">
                <tr>
                <td nowrap="nowrap">
                <Dna:AspxButton  ID="EditBut" CommandName="Edit" Text="Edit" runat="server" />
                <Dna:AspxButton ID="DeleteBut" CommandName="Delete" Text="Delete" runat="server" OnClientClick="return confirm('Are you sure to delete this record?');" CommandArgument='<%# ((GridViewRow)Container).RowIndex %>' />
                </td>
                </tr>
                </table>
                </ItemTemplate>
                <EditItemTemplate>
                <table id="EditCommandTable" cellpadding="0" border="0" style="height:100%; width:100%; background-color:White">
                <tr>
                <td nowrap="nowrap">
                <Dna:AspxButton ID="UpdateBut" CommandName="Update" Text="Update" runat="server" OnClientClick="return confirm('Are you sure you want to Save?');" />
                <Dna:AspxButton ID="CancelBut" CommandName="Cancel" Text="Cancel" runat="server" />
                </td>
                </tr>
                </table>
                </EditItemTemplate>
                </asp:TemplateField>
                 <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" Visible="true" InsertVisible="false" />
                
                <Dna:AspxTemplateField FilterDataField="program" SortExpression="program" HeaderText="Program"
                TypeCode="String" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
                SMALLER_AND_EQUAL_TO="false">
                <ItemTemplate>
                    <table id="program_tabl" border="0" cellpadding="0" cellspacing="0" width="100%">
                        <tr>
                            <td nowrap="nowrap" align="left">
                                <asp:Literal ID="program" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "program")%>'></asp:Literal>
                            </td>
                        </tr>
                    </table>
                    
                </ItemTemplate>
                <EditItemTemplate>
                    <Dna:AspxDropDownList ID="program" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="10" 
                        Width="350" DataTextField="program" DataValueField="program" DataSource='<%# ProgramDataBind() %>'
                        CheckAndInsertBoundValue="true" UnBoundSelectedText='<%# DataBinder.Eval(Container.DataItem,"program") %>' UnBoundSelectedValue='<%# DataBinder.Eval(Container.DataItem,"program") %>'  SelectedValue='<%# Bind(Container.DataItem, "program")%>'   >
                    </Dna:AspxDropDownList>
                    <asp:HiddenField ID="id" runat="server" Value='<%# Bind(Container.DataItem, "id")%>'>
                    </asp:HiddenField>
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
                </table>
                </ItemTemplate>
                <EditItemTemplate>
                    <Dna:AspxDropDownList ID="issue_type" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="4" 
                        Width="100"  CheckAndInsertBoundValue="true" UnBoundSelectedText='<%# DataBinder.Eval(Container.DataItem,"program") %>' UnBoundSelectedValue='<%# DataBinder.Eval(Container.DataItem,"program") %>' SelectedValue='<%# Bind(Container.DataItem, "issue_type")%>'>
                        <asp:ListItem Text="3G_RETENTION" Value="3G_RETENTION"></asp:ListItem>
                        <asp:ListItem Text="2G_RETENTION" Value="2G_RETENTION"></asp:ListItem>
                        <asp:ListItem Text="GO_WIRELESS" Value="GO_WIRELESS"></asp:ListItem>
                        <asp:ListItem Text="MOBILE_LITE" Value="MOBILE_LITE"></asp:ListItem>
                        <asp:ListItem Text="UPGRADE" Value="UPGRADE"></asp:ListItem>
                    </Dna:AspxDropDownList>
                </EditItemTemplate>
            </Dna:AspxTemplateField>
      
      
      <Dna:AspxTemplateField FilterDataField="use_rebate_mapping" SortExpression="use_rebate_mapping" HeaderText="Use"
            TypeCode="Boolean" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
            SMALLER_AND_EQUAL_TO="false" LIKE="false">
            <ItemTemplate>
                <Dna:AspxCheckBox ID="use_rebate_mapping" Enabled="false" Checked='<%# DataBinder.Eval(Container.DataItem, "use_rebate_mapping")%>'
                    runat="server" />
            </ItemTemplate>
            <EditItemTemplate>
                <Dna:AspxCheckBox ID="use_rebate_mapping" Checked='<%# Bind(Container.DataItem, "use_rebate_mapping")%>'
                    runat="server" />
            </EditItemTemplate>
        </Dna:AspxTemplateField>
      
      
      
      
      <Dna:AspxTemplateField FilterDataField="active" SortExpression="active" HeaderText="Active"
            TypeCode="Boolean" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
            SMALLER_AND_EQUAL_TO="false" LIKE="false">
            <ItemTemplate>
                <Dna:AspxCheckBox ID="active" Enabled="false" Checked='<%# DataBinder.Eval(Container.DataItem, "active")%>'
                    runat="server" />
            </ItemTemplate>
            <EditItemTemplate>
                <Dna:AspxCheckBox ID="active" Checked='<%# Bind(Container.DataItem, "active")%>'
                    runat="server" />
            </EditItemTemplate>
        </Dna:AspxTemplateField>
      
      
      
     
                                                
                                                
                                                
                                                <Dna:AspxTemplateField FilterDataField="sdate" SortExpression="sdate" HeaderText="Start Date"
                                                    TypeCode="DateTime" FilterDataFormatString="dd/MM/yyyy" LIKE="false">
                                                    <ItemTemplate>
                                                        <table id="sdate_tabl" border="0" cellpadding="0" cellspacing="0" width="100%">
                                                            <tr>
                                                                <td nowrap="nowrap" align="left">
                                                        <asp:Literal ID="sdate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "sdate","{0:dd/MM/yyyy}")%>'></asp:Literal>
                                                                </td>
                                                            </tr>
                                                         </table>
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <table id="SdateTbl" runat="server" cellpadding="0" cellspacing="0">
                                                            <tr>
                                                                <td nowrap="nowrap" align="left">
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
                                                        <asp:Literal ID="edate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "edate","{0:dd/MM/yyyy}")%>'></asp:Literal>
                                                                </td>
                                                            </tr>
                                                         </table>
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
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
      
      
      
      </Columns>
      </Dna:AspxGridView>
              
                  <asp:SqlDataSource ID="ProgramRebateMappingObj" runat="server" 
                      ConnectionString="<%$ ConnectionStrings:MobileRetentionOrderDB2 %>" 
                      DeleteCommand="DELETE FROM [ProgramRebateMapping] WHERE [id] = @id" 
                      InsertCommand="INSERT INTO [ProgramRebateMapping] ([program], [issue_type], [use_rebate_mapping], [active], [edate], [sdate]) VALUES (@program, @issue_type, @use_rebate_mapping, @active, @edate, @sdate)" 
                      SelectCommand="SELECT [id], [program], [issue_type], [use_rebate_mapping],  [active], [edate], [sdate] FROM [ProgramRebateMapping]" 
                      
                      UpdateCommand="UPDATE [ProgramRebateMapping] SET [program] = @program, [issue_type] = @issue_type, [use_rebate_mapping] = @use_rebate_mapping, [active] = @active, [edate] = @edate, [sdate] = @sdate WHERE [id] = @id" 
                      oninit="ProgramRebateMappingObj_Init">
                      <DeleteParameters>
                          <asp:Parameter Name="id" Type="Int32" />
                      </DeleteParameters>
                      <UpdateParameters>
                          <asp:Parameter Name="program" Type="String" />
                          <asp:Parameter Name="issue_type" Type="String" />
                          <asp:Parameter Name="use_rebate_mapping" Type="Boolean" />

                          <asp:Parameter Name="active" Type="Boolean" />
                          <asp:Parameter Name="edate" Type="DateTime" />
                          <asp:Parameter Name="sdate" Type="DateTime" />
                          <asp:Parameter Name="id" Type="Int32" />
                      </UpdateParameters>
                      <InsertParameters>
                          <asp:Parameter Name="program" Type="String" />
                          <asp:Parameter Name="issue_type" Type="String" />
                          <asp:Parameter Name="use_rebate_mapping" Type="Boolean" />

                          <asp:Parameter Name="active" Type="Boolean" />
                          <asp:Parameter Name="edate" Type="DateTime" />
                          <asp:Parameter Name="sdate" Type="DateTime" />
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
        
              

</asp:Content>

