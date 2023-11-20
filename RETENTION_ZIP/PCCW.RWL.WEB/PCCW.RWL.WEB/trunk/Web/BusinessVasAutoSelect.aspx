<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/RWLMenu.master" AutoEventWireup="true"
    CodeFile="BusinessVasAutoSelect.aspx.cs" Inherits="Web_BusinessVasAutoSelect" %>

<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="RWLHeaderContentPlace" runat="Server">
    <meta http-equiv="Content-Style-Type" content="text/css" />
    <meta http-equiv="Content-Type" content="text/html; charset=big5" />
    <title>3G Retention - Web Log</title>
    <link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
    <link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
    <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="RWLContentPlace" runat="Server">
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
                                            <img alt="" src="images/pc_25_01.gif" height="20" /></a>
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
                                                    <Dna:AspxButton ID="BackBut" Text="Back" PostBackUrl="~/Web/VasControlMain.aspx" runat="server" />
                                                </td>
                                                    
                                                <td>
                                                    <Dna:AspxButton ID="ReloadMemoryBut" Text="Reload Memory"  runat="server"  onclick="ReloadMemoryBut_Click" />
                                                </td>
                                                <td>
                                                    <Dna:AspxButton ID="InsertVasAutoSelectRule" Text="Insert Vas Auto Select Rule" PostBackUrl="BusinessVasAutoSelectRule.aspx"  runat="server"  />
                                                </td>
                                                <td>
                                                         <Dna:AspxButton ID="ExportExcelBut" Text="Export Excel" OnClientClick="AttachmentExport('Handler','BusinessVasDefaultSet'); return false;" runat="server" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td nowrap="nowrap" align="left">
                                              <Dna:AspxTextBox ID="GvPageSize" Text="15" runat="server" Width="60px" HintMessage="Please kindly Enter The Page Size" ></Dna:AspxTextBox>
                                              </td>
                                                <td>
                                                 <Dna:AspxButton ID="PageSizeRefresh"  Text="PageSize Refresh" runat="server" onclick="PageSizeRefresh_Click"  />
                                                </td>
                                                <td>
                                                </td>
                                                <td>
                                                </td>
                                            </tr>
                                        </table>
                                        <br />
                                        <Dna:AspxGridView ID="BusinessVasDefaultSetGW" runat="server" AllowPaging="True" EnableViewState="true"
                                            PageSize="15" DataKeyNames="mid" AllowSorting="True" EmptyDataText="There has no record"
                                            AutoGenerateColumns="False" EmptyShowHeader="true" 
                                            UseSelectCommand="false" OnFilterCommand="BusinessVasDefaultSetGW_FilterCommand"
                                            OnPageIndexChanging="BusinessVasDefaultSetGW_PageIndexChanging" OnSorting="BusinessVasDefaultSetGW_Sorting"
                                            OnRowEditing="BusinessVasDefaultSetGW_RowEditing" OnRowUpdating="BusinessVasDefaultSetGW_RowUpdating"
                                            OnRowCancelingEdit="BusinessVasDefaultSetGW_RowCancelingEdit" OnRowCommand="BusinessVasDefaultSetGW_RowCommand"
                                            OnRowCreated="BusinessVasDefaultSetGW_RowCreated" OnDataBound="BusinessVasDefaultSetGW_DataBound"
                                            OnRowDataBound="BusinessVasDefaultSetGW_RowDataBound" 
                                            onrowdeleting="BusinessVasDefaultSetGW_RowDeleting">
                                            <AspxFilterSetting AllowFilter="true" />
                                            <PagerSettings Position="TopAndBottom" />
                                            <Columns>
                                                <asp:TemplateField>
                                                    <ItemTemplate>
                                                        <table id="EditCommandTable" cellpadding="0" border="0" style="height: 100%; width: 100%;
                                                            background-color: White">
                                                            <tr>
                                                                <td nowrap="nowrap" align="left">
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
                                                                <td nowrap="nowrap" align="left">
                                                                    <Dna:AspxButton ID="UpdateBut" CommandName="Update" Text="Update" runat="server"
                                                                        OnClientClick="return confirm('Are you sure you want to Save?');" />
                                                                    <Dna:AspxButton ID="CancelBut" CommandName="Cancel" Text="Cancel" runat="server" />
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </EditItemTemplate>
                                                </asp:TemplateField>
                                                <Dna:AspxTemplateField FilterDataField="mid" SortExpression="mid" HeaderText="mid"
                                                    Visible="false" TypeCode="String" LIKE="false">
                                                    <ItemTemplate>
                                                        <asp:Literal ID="mid" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "mid")%>'></asp:Literal>
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                    </EditItemTemplate>
                                                </Dna:AspxTemplateField>
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
                                                        <asp:HiddenField ID="mid" runat="server" Value='<%# Bind(Container.DataItem, "mid")%>'>
                                                        </asp:HiddenField>
                                                    </EditItemTemplate>
                                                </Dna:AspxTemplateField>
                                                <Dna:AspxTemplateField FilterDataField="rate_plan" SortExpression="rate_plan" HeaderText="Rate Plan"
                                                    TypeCode="String" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
                                                    SMALLER_AND_EQUAL_TO="false">
                                                    <ItemTemplate>
                                                    
                                                    <table id="rate_plan_tabl" border="0" cellpadding="0" cellspacing="0" width="100%">
                                                            <tr>
                                                                <td nowrap="nowrap" align="left">
                                                        <asp:Literal ID="rate_plan" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "rate_plan")%>'></asp:Literal>
                                                                </td>
                                                            </tr>
                                                     </table>
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <Dna:AspxDropDownList ID="rate_plan" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="10" 
                                                            Width="150" DataTextField="rate_plan" DataValueField="rate_plan" DataSource='<%# RatePlanDataBind() %>'
                                                             CheckAndInsertBoundValue="true" UnBoundSelectedText='<%# DataBinder.Eval(Container.DataItem,"rate_plan") %>' UnBoundSelectedValue='<%# DataBinder.Eval(Container.DataItem,"rate_plan") %>'  SelectedValue='<%# Bind(Container.DataItem, "rate_plan")%>'>
                                                        </Dna:AspxDropDownList>
                                                    </EditItemTemplate>
                                                </Dna:AspxTemplateField>
                                                <Dna:AspxTemplateField FilterDataField="con_per" SortExpression="con_per" HeaderText="Contract Period"
                                                    TypeCode="String" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
                                                    SMALLER_AND_EQUAL_TO="false">
                                                    <ItemTemplate>
                                                    <table id="con_per_tabl" border="0" cellpadding="0" cellspacing="0" width="100%">
                                                            <tr>
                                                                <td nowrap="nowrap" align="left">
                                                        <asp:Literal ID="con_per" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "con_per")%>'></asp:Literal>
                                                                </td>
                                                            </tr>
                                                    </table>
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <Dna:AspxDropDownList ID="con_per" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="10" 
                                                            Width="150" DataTextField="con_per" DataValueField="con_per" DataSource='<%# ConPerDataBind() %>'
                                                             CheckAndInsertBoundValue="true" UnBoundSelectedText='<%# DataBinder.Eval(Container.DataItem,"con_per") %>' UnBoundSelectedValue='<%# DataBinder.Eval(Container.DataItem,"con_per") %>' SelectedValue='<%# Bind(Container.DataItem, "con_per")%>'>
                                                        </Dna:AspxDropDownList>
                                                    </EditItemTemplate>
                                                </Dna:AspxTemplateField>
                                                <Dna:AspxTemplateField FilterDataField="hs_model" SortExpression="hs_model" HeaderText="HandSet Model"
                                                    TypeCode="String" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
                                                    SMALLER_AND_EQUAL_TO="false">
                                                    <ItemTemplate>
                                                       <table id="hs_model_tabl" border="0" cellpadding="0" cellspacing="0" width="100%">
                                                            <tr>
                                                                <td nowrap="nowrap" align="left">
                                                        <asp:Literal ID="hs_model" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "hs_model")%>'></asp:Literal>
                                                                </td>
                                                             </tr>
                                                        </table>
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <Dna:AspxDropDownList ID="hs_model" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="10" 
                                                            Width="550px" DataTextField="hs_model" DataValueField="hs_model" DataSource='<%# HsModelDataBind() %>'
                                                             CheckAndInsertBoundValue="true" UnBoundSelectedText='<%# DataBinder.Eval(Container.DataItem,"hs_model") %>' UnBoundSelectedValue='<%# DataBinder.Eval(Container.DataItem,"hs_model") %>' SelectedValue='<%# Bind(Container.DataItem, "hs_model")%>'>
                                                        </Dna:AspxDropDownList>
                                                    </EditItemTemplate>
                                                </Dna:AspxTemplateField>
                                                <Dna:AspxTemplateField FilterDataField="trade_field" SortExpression="trade_field" 
                                                    HeaderText="Trade Field" TypeCode="String" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false"
                                                    SMALLER_THAN="false" SMALLER_AND_EQUAL_TO="false">
                                                    <ItemTemplate>
                                                      <table id="trade_field_tabl" border="0" cellpadding="0" cellspacing="0" width="100%">
                                                            <tr>
                                                                <td nowrap="nowrap" align="left">
                                                        <asp:Literal ID="trade_field" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "trade_field")%>'></asp:Literal>
                                                                </td>
                                                                </tr>
                                                        </table>
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <Dna:AspxDropDownList ID="trade_field" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="10" 
                                                            Width="150" DataTextField="trade_field" DataValueField="trade_field" DataSource='<%# TradeFieldDataBind() %>'
                                                             CheckAndInsertBoundValue="true" UnBoundSelectedText='<%# DataBinder.Eval(Container.DataItem,"trade_field") %>' UnBoundSelectedValue='<%# DataBinder.Eval(Container.DataItem,"trade_field") %>' SelectedValue='<%# Bind(Container.DataItem, "trade_field")%>'>
                                                        </Dna:AspxDropDownList>
                                                    </EditItemTemplate>
                                                </Dna:AspxTemplateField>
                                                <Dna:AspxTemplateField FilterDataField="bundle_name" SortExpression="bundle_name"
                                                    HeaderText="Bundle Name" TypeCode="String" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false"
                                                    SMALLER_THAN="false" SMALLER_AND_EQUAL_TO="false">
                                                    <ItemTemplate>
                                                    <table id="bundle_name_tabl" border="0" cellpadding="0" cellspacing="0" width="100%">
                                                            <tr>
                                                                <td nowrap="nowrap" align="left">
                                                        <asp:Literal ID="bundle_name" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "bundle_name")%>'></asp:Literal>
                                                        </td>
                                                                </tr>
                                                        </table>
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <Dna:AspxDropDownList ID="bundle_name" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="10" 
                                                            Width="150" DataTextField="bundle_name" DataValueField="bundle_name" DataSource='<%# BundleNameDataBind() %>'
                                                             CheckAndInsertBoundValue="true" UnBoundSelectedText='<%# DataBinder.Eval(Container.DataItem,"bundle_name") %>' UnBoundSelectedValue='<%# DataBinder.Eval(Container.DataItem,"bundle_name") %>' SelectedValue='<%# Bind(Container.DataItem, "bundle_name")%>'>
                                                        </Dna:AspxDropDownList>
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
                                                            <asp:ListItem Text="WIN" Value="WIN"></asp:ListItem>
                                                            <asp:ListItem Text="MOBILE_LITE" Value="MOBILE_LITE"></asp:ListItem>
                                                            <asp:ListItem Text="UPGRADE" Value="UPGRADE"></asp:ListItem>
                                                        </Dna:AspxDropDownList>
                                                    </EditItemTemplate>
                                                </Dna:AspxTemplateField>
                                                <Dna:AspxTemplateField FilterDataField="vas_name" SortExpression="vas_name" HeaderText="Vas Name"
                                                    TypeCode="String" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
                                                    SMALLER_AND_EQUAL_TO="false">
                                                    <ItemTemplate>
                                                    <table id="vas1_tabl" border="0" cellpadding="0" cellspacing="0" width="100%">
                                                            <tr>
                                                                <td nowrap="nowrap" align="left">
                                                               <asp:Literal ID="vas_name" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "vas_name")%>'></asp:Literal> 
                                                        <asp:Literal ID="vas1" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "vas1")%>' Visible="false"></asp:Literal>
                                                                </td>
                                                            </tr>
                                                    </table>
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <Dna:AspxDropDownList ID="vas1" runat="server" AppendDataBoundItems="true" Font-Size="12px" Rows="10" AutoPostBack="true"
                                                            Width="150" DataTextField="vas_name" DataValueField="vas_field" DataSource='<%# Vas1DataBind() %>'
                                                             CheckAndInsertBoundValue="true" UnBoundSelectedText='<%# DataBinder.Eval(Container.DataItem,"vas_name") %>' UnBoundSelectedValue='<%# DataBinder.Eval(Container.DataItem,"vas1") %>' SelectedValue='<%# Bind(Container.DataItem, "vas1")%>' OnSelectedIndexChanged="vas1_SelectedIndexChanged">
                                                        </Dna:AspxDropDownList>
                                                    </EditItemTemplate>
                                                </Dna:AspxTemplateField>
                                                <Dna:AspxTemplateField FilterDataField="value1" SortExpression="value1" HeaderText="Value DropDown One"
                                                    TypeCode="String">
                                                    <ItemTemplate>
                                                    <table id="value1_tabl" border="0" cellpadding="0" cellspacing="0" width="100%">
                                                            <tr>
                                                                <td nowrap="nowrap" align="left">
                                                        <asp:Literal ID="value1" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "value1")%>'></asp:Literal>
                                                                </td>
                                                            </tr>
                                                    </table>
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <asp:HiddenField ID="value1" runat="server" Value='<%# Bind(Container.DataItem, "value1")%>' />
                                                        <Dna:AspxDropDownList ID="value1_drp" DataTextField="vas_value" DataValueField="vas_value"
                                                            AppendDataBoundItems="true" runat="server" Font-Size="12px" Width="150">
                                                        </Dna:AspxDropDownList>
                                                    </EditItemTemplate>
                                                </Dna:AspxTemplateField>
                                                <Dna:AspxTemplateField FilterDataField="display1" SortExpression="display1" HeaderText="Display One"
                                                    TypeCode="Boolean" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
                                                    SMALLER_AND_EQUAL_TO="false" LIKE="false">
                                                    <ItemTemplate>
                                                        <Dna:AspxCheckBox ID="display1" Enabled="false" Checked='<%# DataBinder.Eval(Container.DataItem, "display1")%>' runat="server" />
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <Dna:AspxCheckBox ID="display1" Checked='<%# Bind(Container.DataItem, "display1")%>'
                                                            runat="server" />
                                                    </EditItemTemplate>
                                                </Dna:AspxTemplateField>
                                                <Dna:AspxTemplateField FilterDataField="enabled1" SortExpression="enabled1" HeaderText="Enabled One"
                                                    TypeCode="Boolean" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
                                                    SMALLER_AND_EQUAL_TO="false" LIKE="false">
                                                    <ItemTemplate>
                                                        <Dna:AspxCheckBox ID="enabled1" Enabled="false" Checked='<%# DataBinder.Eval(Container.DataItem, "enabled1")%>'
                                                            runat="server" />
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <Dna:AspxCheckBox ID="enabled1" Checked='<%# Bind(Container.DataItem, "enabled1")%>'
                                                            runat="server" />
                                                    </EditItemTemplate>
                                                </Dna:AspxTemplateField>
                                                <Dna:AspxTemplateField FilterDataField="value2" SortExpression="value2" HeaderText="Value DropDown Two"
                                                    TypeCode="String">
                                                    <ItemTemplate>
                                                        <table id="value2_tabl" border="0" cellpadding="0" cellspacing="0" width="100%">
                                                            <tr>
                                                                <td nowrap="nowrap" align="left">
                                                        <asp:Literal ID="value2" runat="server" Text='<%# GetVasDesc(DataBinder.Eval(Container.DataItem, "vas1").ToString(), DataBinder.Eval(Container.DataItem, "value2").ToString())%>'></asp:Literal>
                                                                </td>
                                                            </tr>
                                                         </table>
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <asp:HiddenField ID="value2" runat="server" Value='<%# Bind(Container.DataItem, "value2")%>' />
                                                        <Dna:AspxDropDownList ID="value2_drp" AppendDataBoundItems="true" runat="server" Font-Size="12px"
                                                            Width="300px" DataTextField="vas_desc" DataValueField="fee">
                                                        </Dna:AspxDropDownList>
                                                    </EditItemTemplate>
                                                </Dna:AspxTemplateField>
                                                <Dna:AspxTemplateField FilterDataField="display2" SortExpression="display2" HeaderText="Display Two"
                                                    TypeCode="Boolean" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
                                                    SMALLER_AND_EQUAL_TO="false" LIKE="false">
                                                    <ItemTemplate>
                                                        <Dna:AspxCheckBox ID="display2" Enabled="false" Checked='<%# DataBinder.Eval(Container.DataItem, "display2")%>' runat="server" />
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <Dna:AspxCheckBox ID="display2" Checked='<%# Bind(Container.DataItem, "display2")%>' runat="server" />
                                                    </EditItemTemplate>
                                                </Dna:AspxTemplateField>
                                                <Dna:AspxTemplateField FilterDataField="enabled2" SortExpression="enabled2" HeaderText="Enabled Two"
                                                    TypeCode="Boolean" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
                                                    SMALLER_AND_EQUAL_TO="false" LIKE="false">
                                                    <ItemTemplate>
                                                        <Dna:AspxCheckBox ID="enabled2" Enabled="false" Checked='<%# DataBinder.Eval(Container.DataItem, "enabled2")%>' runat="server" />
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <Dna:AspxCheckBox ID="enabled2" Checked='<%# Bind(Container.DataItem, "enabled2")%>'
                                                            runat="server" />
                                                    </EditItemTemplate>
                                                </Dna:AspxTemplateField>
                                                <Dna:AspxTemplateField FilterDataField="cid" SortExpression="cid" HeaderText="User ID"
                                                    TypeCode="String">
                                                    <ItemTemplate>
                                                    <table id="cid_tabl" border="0" cellpadding="0" cellspacing="0" width="100%">
                                                            <tr>
                                                                <td nowrap="nowrap" align="left">
                                                        <asp:Literal ID="cid" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "cid")%>'></asp:Literal>
                                                                </td>
                                                            </tr>
                                                     </table>
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
                                                
                                                <Dna:AspxTemplateField FilterDataField="cdate" SortExpression="cdate" HeaderText="Create Date"
                                                    TypeCode="DateTime" FilterDataFormatString="dd/MM/yyyy" LIKE="false">
                                                    <ItemTemplate>
                                                    <table id="cdate_tabl" border="0" cellpadding="0" cellspacing="0" width="100%">
                                                            <tr>
                                                                <td nowrap="nowrap" align="left">
                                                        <asp:Literal ID="cdate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "cdate","{0:dd/MM/yyyy}")%>'></asp:Literal>
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
                                                                                <Dna:AspxTextBox ID="cdate" Width="100px" Text='<%# Bind(Container.DataItem, "cdate","{0:dd/MM/yyyy}")%>'
                                                                                    runat="server" HintMessage="Please kindly Enter The Create Date" />
                                                                            </td>
                                                                            <td>
                                                                                <asp:ImageButton runat="server" ID="CalenderImageCDate" ImageUrl="~/Resources/Images/calendar.png"
                                                                                    OnClientClick="return false;" />
                                                                                <cc1:CalendarExtender runat="server" ID="CalendarCDateFormat" TargetControlID="cdate"
                                                                                    Format="dd/MM/yyyy" PopupButtonID="CalenderImageCDate">
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
