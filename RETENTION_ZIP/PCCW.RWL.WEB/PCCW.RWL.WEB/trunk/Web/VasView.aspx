<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/RWLMenu.master" AutoEventWireup="true" CodeFile="VasView.aspx.cs" Inherits="Web_VasView" %>

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

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="RWLContentPlace" Runat="Server">

 <cc1:ToolkitScriptManager ID="AddWebLogScriptManager" runat="server" EnablePartialRendering="true"
        ScriptMode="Release" LoadScriptsBeforeUI="false" EnablePageMethods="true">
    </cc1:ToolkitScriptManager>
    <table width="100%" cellspacing="10">
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
                                                    <Dna:AspxButton ID="BackBut" Text="Back" PostBackUrl="~/Web/VasControlMain.aspx" runat="server" />
                                                </td>
                                                <td>
                                                
                                                </td>
                                            </tr>
                                             <tr>
                                                <td nowrap="nowrap">
                                              <Dna:AspxTextBox ID="GvPageSize" Text="15" runat="server" Width="60px" HintMessage="Please kindly Enter The Page Size" ></Dna:AspxTextBox>
                                              </td>
                                                <td>
                                                 <Dna:AspxButton ID="PageSizeRefresh"  Text="PageSize Refresh" runat="server" onclick="PageSizeRefresh_Click"  />
                                                </td>
                                                <td>
                                                </td>
                                                
                                            </tr>

                                        </table>
                                        <br />

                                        <Dna:AspxGridView ID="BundleMappingGW" runat="server" AllowPaging="True" DataSourceID="BundleMappingObj"
                                            PageSize="15" DataKeyNames="id" AllowSorting="True" EmptyDataText="There has no record"
                                            AutoGenerateColumns="False" EmptyShowHeader="true" 
                                            UseSelectCommand="false" onrowupdating="BundleMappingGW_RowUpdating" 
                                            onrowdatabound="BundleMappingGW_RowDataBound" 
                                            onrowcancelingedit="BundleMappingGW_RowCancelingEdit" 
                                            onrowcommand="BundleMappingGW_RowCommand" 
                                            onrowupdated="BundleMappingGW_RowUpdated" >
                                            <AspxFilterSetting AllowFilter="true" />
                                            <PagerSettings Position="TopAndBottom" />
                                            <Columns>
                                                <asp:TemplateField>
                                                    <ItemTemplate>
                                                        <table id="EditCommandTable" cellpadding="0" border="0" style="height: 100%; width: 100%;
                                                            background-color: White">
                                                            <tr>
                                                                <td nowrap="nowrap">
                                                                    <Dna:AspxButton ID="EditBut" CommandName="Edit" Text="Edit" runat="server" />
                                                                    <Dna:AspxButton ID="DeleteBut" CommandName="Delete" Text="Delete" runat="server"
                                                                        OnClientClick="return confirm('Are you sure to delete this record?');" CommandArgument='<%# ((GridViewRow)Container).RowIndex %>' />
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <table id="EditCommandTable" cellpadding="0" border="0" style="height: 100%; width: 100%;
                                                            background-color: White">
                                                            <tr>
                                                                <td nowrap="nowrap">
                                                                    <Dna:AspxButton ID="UpdateBut" CommandName="Update" Text="Update" runat="server"
                                                                        OnClientClick="return confirm('Are you sure you want to Save?');" />
                                                                    <Dna:AspxButton ID="CancelBut" CommandName="Cancel" Text="Cancel" runat="server" />
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </EditItemTemplate>
                                                </asp:TemplateField>

                                                <Dna:AspxBoundField DataField="id" CLOSE_FILTER="true" InsertVisible="false" Visible="false"></Dna:AspxBoundField>
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
                                                    <EditItemTemplate>
                                                        <Dna:AspxDropDownList ID="program" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="10" 
                                                            Width="350" DataTextField="program" DataValueField="program" DataSource='<%# ProgramDataBind() %>'  
                                                            CheckAndInsertBoundValue="true" UnBoundSelectedText='<%# DataBinder.Eval(Container.DataItem,"program") %>' UnBoundSelectedValue='<%# DataBinder.Eval(Container.DataItem,"program") %>'  SelectedValue='<%# Bind(Container.DataItem, "program")%>'  >
                                                        </Dna:AspxDropDownList>
                                                      
                                                    </EditItemTemplate>
                                                </Dna:AspxTemplateField>
                                                
                                                <Dna:AspxTemplateField FilterDataField="normal_rebate_type" SortExpression="normal_rebate_type" HeaderText="Normal Rebate Type"
                                                    TypeCode="String" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
                                                    SMALLER_AND_EQUAL_TO="false">
                                                    <ItemTemplate>
                                                        <table id="program_tabl" border="0" cellpadding="0" cellspacing="0">
                                                            <tr>
                                                                <td nowrap="nowrap">
                                                                    <asp:Literal ID="normal_rebate_type" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "normal_rebate_type")%>'></asp:Literal>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <Dna:AspxDropDownList ID="normal_rebate_type" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="10" 
                                                            Width="200" DataTextField="Key" DataValueField="Value" DataSource='<%# NormalRebateTypeDataBind() %>'
                                                            CheckAndInsertBoundValue="true" 
                                                            
                                                            SelectedValue='<%# Bind(Container.DataItem, "normal_rebate_type")%>'>
                                                        </Dna:AspxDropDownList>
                                                      
                                                    </EditItemTemplate>
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
                                                    <EditItemTemplate>
                                                        <Dna:AspxDropDownList ID="rate_plan" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="10" 
                                                            Width="300" DataTextField="rate_plan" DataValueField="rate_plan" DataSource='<%# RatePlanDataBind() %>'
                                                            CheckAndInsertBoundValue="true" UnBoundSelectedText='<%# DataBinder.Eval(Container.DataItem,"rate_plan") %>' UnBoundSelectedValue='<%# DataBinder.Eval(Container.DataItem,"rate_plan") %>'  SelectedValue='<%# Bind(Container.DataItem, "rate_plan")%>'>
                                                        </Dna:AspxDropDownList>
                                                    </EditItemTemplate>
                                                </Dna:AspxTemplateField>

                                                <Dna:AspxTemplateField FilterDataField="hs_model" SortExpression="hs_model" HeaderText="HandSet Model"
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
                                                    <EditItemTemplate>
                                                        <Dna:AspxDropDownList ID="hs_model" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="10" 
                                                            Width="550px" DataTextField="hs_model" DataValueField="hs_model" DataSource='<%# HsModelDataBind() %>'
                                                            CheckAndInsertBoundValue="true" UnBoundSelectedText='<%# DataBinder.Eval(Container.DataItem,"hs_model") %>' UnBoundSelectedValue='<%# DataBinder.Eval(Container.DataItem,"hs_model") %>'  SelectedValue='<%# Bind(Container.DataItem, "hs_model")%>'>
                                                        </Dna:AspxDropDownList>
                                                    </EditItemTemplate>
                                                </Dna:AspxTemplateField>
      
                                                <Dna:AspxTemplateField FilterDataField="bundle_name" SortExpression="bundle_name"
                                                    HeaderText="Bundle Name" TypeCode="String" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false"
                                                    SMALLER_THAN="false" SMALLER_AND_EQUAL_TO="false">
                                                    <ItemTemplate>
                                                    <table id="bundle_name_tabl" border="0" cellpadding="0" cellspacing="0">
                                                            <tr>
                                                                <td nowrap="nowrap">
                                                        <asp:Literal ID="bundle_name" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "bundle_name")%>'></asp:Literal>
                                                        </td>
                                                                </tr>
                                                        </table>
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <Dna:AspxDropDownList ID="bundle_name" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="10" 
                                                            Width="300" DataTextField="bundle_name" DataValueField="bundle_name" DataSource='<%# BundleNameDataBind() %>'
                                                            CheckAndInsertBoundValue="true" UnBoundSelectedText='<%# DataBinder.Eval(Container.DataItem,"bundle_name") %>' UnBoundSelectedValue='<%# DataBinder.Eval(Container.DataItem,"bundle_name") %>'  SelectedValue='<%# Bind(Container.DataItem, "bundle_name")%>'>
                                                        </Dna:AspxDropDownList>
                                                    </EditItemTemplate>
                                                </Dna:AspxTemplateField>
                                                <Dna:AspxTemplateField FilterDataField="issue_type" SortExpression="issue_type" HeaderText="Issue Type"
                                                    TypeCode="String" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
                                                    SMALLER_AND_EQUAL_TO="false">
                                                    <ItemTemplate>
                                                        <asp:Literal ID="issue_type" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "issue_type")%>'></asp:Literal>
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <Dna:AspxDropDownList ID="issue_type" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="4" 
                                                            Width="100" CheckAndInsertBoundValue="true" UnBoundSelectedText='<%# DataBinder.Eval(Container.DataItem,"issue_type") %>' UnBoundSelectedValue='<%# DataBinder.Eval(Container.DataItem,"issue_type") %>'  SelectedValue='<%# Bind(Container.DataItem, "issue_type")%>'>
                                                            <asp:ListItem Text="3G_RETENTION" Value="3G_RETENTION"></asp:ListItem>
                                                            <asp:ListItem Text="2G_RETENTION" Value="2G_RETENTION"></asp:ListItem>
                                                            <asp:ListItem Text="GO_WIRELESS" Value="GO_WIRELESS"></asp:ListItem>
                                                            <asp:ListItem Text="MOBILE_LITE" Value="MOBILE_LITE"></asp:ListItem>
                                                            <asp:ListItem Text="UPGRADE" Value="UPGRADE"></asp:ListItem>
                                                        </Dna:AspxDropDownList>
                                                    </EditItemTemplate>
                                                </Dna:AspxTemplateField>
                                                
                                                <Dna:AspxTemplateField FilterDataField="vas_name" SortExpression="vas_name" HeaderText="Vas Name"
                                                    TypeCode="String" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
                                                    SMALLER_AND_EQUAL_TO="false">
                                                    <ItemTemplate>
                                                    <table id="vas_name_tabl" border="0" cellpadding="0" cellspacing="0">
                                                            <tr>
                                                                <td nowrap="nowrap">
                                                    
                                                        <asp:Literal ID="vas_name" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "vas_name")%>'></asp:Literal>
                                                        <asp:Literal ID="vas_field" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "vas_field")%>' Visible="false"></asp:Literal>
                                                                </td>
                                                             </tr>
                                                      </table>
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <Dna:AspxDropDownList ID="vas_field" runat="server" AppendDataBoundItems="true" Font-Size="12px" Rows="10" 
                                                            Width="150" DataTextField="vas_name" DataValueField="vas_field" DataSource='<%# VasFieldDataBind() %>'
                                                            CheckAndInsertBoundValue="true" UnBoundSelectedText='<%# DataBinder.Eval(Container.DataItem,"vas_name") %>' UnBoundSelectedValue='<%# DataBinder.Eval(Container.DataItem,"vas_field") %>'  SelectedValue='<%# Bind(Container.DataItem, "vas_field")%>'  >
                                                        </Dna:AspxDropDownList>
                                                    </EditItemTemplate>
                                                </Dna:AspxTemplateField>
                                                
                                                
                                                <Dna:AspxTemplateField FilterDataField="cid" SortExpression="cid" HeaderText="User ID"
                                                    TypeCode="String">
                                                    <ItemTemplate>
                                                        <asp:Literal ID="cid" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "cid")%>'></asp:Literal>
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <Dna:AspxTextBox ID="cid" runat="server" Text='<%# Bind(Container.DataItem, "cid")%>' MaxLength="60" Font-Size="12px" Width="100px"></Dna:AspxTextBox>
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
                                                                                    runat="server" HintMessage="Please kindly Enter The Create Date" />
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
                                                        <asp:Literal ID="edate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "edate","{0:dd/MM/yyyy}")%>'></asp:Literal>
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <table id="EdateTbl" runat="server" cellpadding="0" cellspacing="0">
                                                            <tr>
                                                                <td nowrap="nowrap">
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
                                                <br />
                                                
                                                
                                        <asp:SqlDataSource ID="BundleMappingObj" runat="server" 
                                            ConnectionString="<%$ ConnectionStrings:MobileRetentionOrderDB2 %>" 
                                            DeleteCommand="DELETE FROM [BundleMapping] WHERE [id] = @id" 
                                            InsertCommand="INSERT INTO [BundleMapping] ([program], [rate_plan], [hs_model], [active], [vas_field], [normal_rebate], [retention_rebate], [bundle_name], [cid], [sdate], [edate], [normal_rebate_type], [issue_type]) VALUES (@program, @rate_plan, @hs_model, @active, @vas_field, @normal_rebate, @retention_rebate, @bundle_name, @cid, @sdate, @edate, @normal_rebate_type, @issue_type)" 
                                            SelectCommand="SELECT [id],[program],[rate_plan],[hs_model],[bundle_name],[retention_rebate],[normal_rebate],[vas_field],[vas_name],[active],[cid],[sdate],[edate],[normal_rebate_type],[issue_type] FROM (SELECT [id],'vas_name'=(SELECT TOP 1 a.vas_name FROM BusinessVas a WHERE a.vas_field=isnull(b.vas_field,'')) , 'program'=isnull([program],''),'rate_plan'=isnull([rate_plan],''),'hs_model'=isnull([hs_model],''),'active'=isnull([active],''),'vas_field'=isnull([vas_field],''),'normal_rebate'=isnull([normal_rebate],1), 'retention_rebate'=isnull([retention_rebate],1),'bundle_name'=isnull([bundle_name],''), 'cid'=isnull([cid],''), 'sdate'=isnull([sdate],''), 'edate'=isnull([edate],''),'normal_rebate_type'=isnull([normal_rebate_type],''),'issue_type'=isnull([issue_type],'') FROM [BundleMapping] b) BundleMappingView"
                                            UpdateCommand="UPDATE [BundleMapping] SET [program] = @program, [rate_plan] = @rate_plan, [hs_model] = @hs_model, [active] = @active, [vas_field] = @vas_field, [normal_rebate] = @normal_rebate, [retention_rebate] = @retention_rebate, [bundle_name] = @bundle_name, [cid] = @cid, [sdate] = @sdate, [edate] = @edate, [normal_rebate_type] = @normal_rebate_type, [issue_type] = @issue_type WHERE [id] = @id" 
                                            oninit="BundleMappingObj_Init" oninserting="BundleMappingObj_Inserting" 
                                            onupdating="BundleMappingObj_Updating">
                                            <DeleteParameters>
                                                <asp:Parameter Name="id" Type="Int32" />
                                            </DeleteParameters>
                                            <UpdateParameters>
                                                <asp:Parameter Name="program" Type="String" />
                                                <asp:Parameter Name="rate_plan" Type="String" />
                                                <asp:Parameter Name="hs_model" Type="String" />
                                                <asp:Parameter Name="active" Type="Boolean" />
                                                <asp:Parameter Name="vas_field" Type="String" />
                                                <asp:Parameter Name="normal_rebate" Type="Int32" />
                                                <asp:Parameter Name="retention_rebate" Type="Int32" />
                                                <asp:Parameter Name="bundle_name" Type="String" />
                                                <asp:Parameter Name="cid" Type="String" />
                                                <asp:Parameter Name="sdate" Type="DateTime" />
                                                <asp:Parameter Name="edate" Type="DateTime" />
                                                <asp:Parameter Name="normal_rebate_type" Type="String" />
                                                <asp:Parameter Name="issue_type" Type="String" />
                                                <asp:Parameter Name="id" Type="Int32" />
                                            </UpdateParameters>
                                            <InsertParameters>
                                                <asp:Parameter Name="program" Type="String" />
                                                <asp:Parameter Name="rate_plan" Type="String" />
                                                <asp:Parameter Name="hs_model" Type="String" />
                                                <asp:Parameter Name="active" Type="Boolean" />
                                                <asp:Parameter Name="vas_field" Type="String" />
                                                <asp:Parameter Name="normal_rebate" Type="Int32" />
                                                <asp:Parameter Name="retention_rebate" Type="Int32" />
                                                <asp:Parameter Name="bundle_name" Type="String" />
                                                <asp:Parameter Name="cid" Type="String" />
                                                <asp:Parameter Name="sdate" Type="DateTime" />
                                                <asp:Parameter Name="edate" Type="DateTime" />
                                                <asp:Parameter Name="normal_rebate_type" Type="String" />
                                                <asp:Parameter Name="issue_type" Type="String" />
                                            </InsertParameters>
                                        </asp:SqlDataSource>



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


