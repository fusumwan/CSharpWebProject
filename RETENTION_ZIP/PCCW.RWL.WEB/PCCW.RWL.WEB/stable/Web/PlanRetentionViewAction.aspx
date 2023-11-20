<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/RWLMenu.master" AutoEventWireup="true" CodeFile="PlanRetentionViewAction.aspx.cs" Inherits="Web_PlanRetentionViewAction" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Register Src="~/UI/MasterDetailRetentionPlanUsage.ascx" TagName="MasterDetailRetentionPlanUsage" TagPrefix="user" %>
<%@ Register Src="~/UI/MasterDetailRetentionPlanUsageCreate.ascx" TagName="MasterDetailRetentionPlanUsageCreate" TagPrefix="user" %>

<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="RWLHeaderContentPlace" Runat="Server">
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>

<script language="javascript" type="text/javascript">
    function GetUserControl(ID) {
        return document.getElementById($('input[id*="' + ID + '"]').attr('id'));
    }

    function UpdatePanelRefesh(ID) {
        $("span[id*='" + ID + "']").each(function(){
            __doPostBack($(this).attr('id'), '');
        });
    }
    function ShowInsertUsageField() {
        $(".InsertUsageField").each(function() {
            $(this).show(100);
        });
    }

    

    function InsertUsageFormInit() {
        $(".InsertUsageField").each(function() {
            $(this).hide();
        });

        $('input[id*="InsertUsage"]').click(function() {
            $('#UsageForm').slideDown('slow', function() {
                setTimeout("ShowInsertUsageField()", 100);
            });



            return false;
        });
        $('input[id*="CloseUsage"]').click(function() {
            $(".InsertUsageField").each(function() {
                $(this).hide();
            });
            $('#UsageForm').slideUp('slow', function() {

            });
            return false;
        });
    }

    $(document).ready(function() {
        InsertUsageFormInit();
    });


</script>

<style>
.InsertUsageTd:hover{

}
.InsertUsageField{

}
</style>

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
              <Dna:AspxButton ID="BackBtn" runat="server" Text="Back" PostBackUrl="MobileRetentionMain.aspx" />
              </td>
              <td>
              <Dna:AspxButton ID="CreateRatePlanMappingRecord" runat="server" Text="Create Rate Plan Mapping Record" PostBackUrl="PlanRetentionViewCreateAction.aspx"/>
              </td>
              </tr>
              </table>
              <br />
              
              
                      

              
              <Dna:AspxGridView ID="RatePlanGv" runat="server" AllowPaging="True" PageSize="10"
               AllowExpanding="true"
               DataSourceID="RatePlanObj"
                    DataKeyNames="id"  AllowSorting="True" EmptyDataText="There has no record" 
                    AutoGenerateColumns="False" EmptyShowHeader="true" UseSelectCommand="false">
                    <AspxFilterSetting AllowFilter="true" />
                    <PagerSettings Position="TopAndBottom" />
                <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
<Dna:AspxButton ID="ExpandBut" runat="server" Text="Expand" CommandName="EXPAND" CommandArgument='<%# Eval("plan_code") %>'>
                </Dna:AspxButton>
                                    <Dna:AspxButton ID="EditBut" CommandName="Edit" Text="Edit" runat="server" />
                                    <Dna:AspxButton ID="DeleteBut" CommandName="Delete" Text="Delete" runat="server"
                                        OnClientClick="return confirm('Are you sure to delete this record?');" CommandArgument='<%# ((GridViewRow)Container).RowIndex %>' />

                    </ItemTemplate>
                    <EditItemTemplate>

                                    <Dna:AspxButton ID="UpdateBut" CommandName="Update" Text="Update" runat="server"
                                        OnClientClick="return confirm('Are you sure you want to Save?');" />
                                    <Dna:AspxButton ID="CancelBut" CommandName="Cancel" Text="Cancel" runat="server" />

                    </EditItemTemplate>
                </asp:TemplateField>

                
                
                
                
                <Dna:AspxTemplateField FilterDataField="plan_code" SortExpression="plan_code" HeaderText="Plan Code"
                                                    TypeCode="String" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
                                                    SMALLER_AND_EQUAL_TO="false">
                                                    <ItemTemplate>
                                                    <table id="plan_code_tabl" border="0" cellpadding="0" cellspacing="0">
                                                            <tr>
                                                                <td nowrap="nowrap">
                                                        <asp:Literal ID="plan_code" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "plan_code")%>'></asp:Literal>
                                                    
                                                                </td>
                                                                </tr>
                                                                </table>
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <Dna:AspxDropDownList ID="plan_code" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="10" 
                                                            Width="300" DataTextField="rate_plan" DataValueField="rate_plan" DataSource='<%# RatePlanDataBind() %>'
                                                            CheckAndInsertBoundValue="true" UnBoundSelectedText='<%# DataBinder.Eval(Container.DataItem,"plan_code") %>' UnBoundSelectedValue='<%# DataBinder.Eval(Container.DataItem,"plan_code") %>'  SelectedValue='<%# Bind(Container.DataItem, "plan_code")%>'>
                                                        </Dna:AspxDropDownList>
                                                    </EditItemTemplate>
                                                </Dna:AspxTemplateField>
                                                
                                                
                    <Dna:AspxTemplateField FilterDataField="plan_fee" SortExpression="plan_fee" HeaderText="Plan Fee" TypeCode="String">
                    <ItemTemplate>
                        <asp:Literal ID="plan_fee" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "plan_fee")%>'></asp:Literal>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <Dna:AspxTextBox ID="plan_fee" runat="server" Text='<%# Bind(Container.DataItem, "plan_fee")%>' MaxLength="60" Font-Size="12px" Width="100px"></Dna:AspxTextBox>
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
                
                </Columns>
                <MasterDetailTemplate>
                
                 <table style="width:100%;" cellspacing="10">
                 <tr>
                 <td align="left">
                 <user:MasterDetailRetentionPlanUsageCreate ID="MasterDetailRetentionPlanUsageCreateControl" runat="server" />
                 </td>
                 </tr>
                <tr>
                <td align="center">
                
                
                <user:MasterDetailRetentionPlanUsage ID="MasterDetailRetentionPlanUsageControl" runat="server" />
                </td>
                </tr>
                </table>
                
                
                </MasterDetailTemplate>
                
                </Dna:AspxGridView>

                <asp:SqlDataSource ID="RatePlanObj" runat="server" 
                      ConnectionString="<%$ ConnectionStrings:MobileRetentionOrderDB2 %>" 
                      DeleteCommand="DELETE FROM [RetentionPlan] WHERE [id] = @id" 
                      InsertCommand="INSERT INTO [RetentionPlan] ([plan_code], [plan_fee], [active]) VALUES (@plan_code, @plan_fee, @active)" 
                      SelectCommand="SELECT [id], [plan_code], [plan_fee], [active] FROM [RetentionPlan]" 
                      
                      UpdateCommand="UPDATE [RetentionPlan] SET [plan_code] = @plan_code, [plan_fee] = @plan_fee, [active] = @active WHERE [id] = @id" 
                      oninit="RatePlanObj_Init">
                    <DeleteParameters>
                        <asp:Parameter Name="id" Type="Int32" />
                    </DeleteParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="plan_code" Type="String" />
                        <asp:Parameter Name="plan_fee" Type="Double" />
                        <asp:Parameter Name="active" Type="Boolean" />
                        <asp:Parameter Name="id" Type="Int32" />
                    </UpdateParameters>
                    <InsertParameters>
                        <asp:Parameter Name="plan_code" Type="String" />
                        <asp:Parameter Name="plan_fee" Type="Double" />
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
</asp:Content>

