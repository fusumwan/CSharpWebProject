<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/RWLMenu.master" AutoEventWireup="true" CodeFile="DeliveryAddress.aspx.cs" Inherits="Web_DeliveryAddress" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Register Src="~/UI/MasterDetailDeliveryTime.ascx" TagName="MasterDetailDeliveryTime" TagPrefix="user" %>
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

              </td>
              </tr>
              </table>
              <br />




     
              <Dna:AspxGridView ID="DeliveryLocationGv" runat="server" AllowPaging="True" PageSize="10"
               AllowExpanding="true"
               DataSourceID="DeliveryLocationObj"
                    DataKeyNames="id"  AllowSorting="True" EmptyDataText="There has no record" 
                    AutoGenerateColumns="False" EmptyShowHeader="true" UseSelectCommand="false" 
                      oninit="DeliveryLocationGv_Init">
                    <AspxFilterSetting AllowFilter="true" />
                    <PagerSettings Position="TopAndBottom" />
                <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
<Dna:AspxButton ID="ExpandBut" runat="server" Text="Expand" CommandName="EXPAND" CommandArgument='<%# Eval("location") %>'>
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
                <asp:BoundField DataField="id" Visible="false"  InsertVisible="true" />
                
                
                <Dna:AspxTemplateField FilterDataField="location" SortExpression="location" HeaderText="Location"
                                                    TypeCode="String" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
                                                    SMALLER_AND_EQUAL_TO="false">
                                                    <ItemTemplate>

                                                        <asp:Literal ID="location" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "location")%>'></asp:Literal>
                                                    
            
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <Dna:AspxDropDownList ID="location" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="10" 
                                                            Width="150" DataTextField="location" DataValueField="location" DataSource='<%# LocationDataBind() %>'
                                                            CheckAndInsertBoundValue="true" UnBoundSelectedText='<%# DataBinder.Eval(Container.DataItem,"location") %>' UnBoundSelectedValue='<%# DataBinder.Eval(Container.DataItem,"location") %>'  SelectedValue='<%# Bind(Container.DataItem, "location")%>'>
                                                        </Dna:AspxDropDownList>
                                                    </EditItemTemplate>
                                                </Dna:AspxTemplateField>
                                                
                
                
                <Dna:AspxTemplateField FilterDataField="area" SortExpression="area" HeaderText="Area"
                                                    TypeCode="String" GREATER_THAN="false" GREATER_AND_EQUAL_TO="false" SMALLER_THAN="false"
                                                    SMALLER_AND_EQUAL_TO="false">
                                                    <ItemTemplate>

                                                        <asp:Literal ID="area" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "area")%>'></asp:Literal>
           
                                                    </ItemTemplate>
                                                    <EditItemTemplate>
                                                        <Dna:AspxDropDownList ID="area" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="10" 
                                                            Width="100px" 
                                                            CheckAndInsertBoundValue="true" UnBoundSelectedText='<%# DataBinder.Eval(Container.DataItem,"area") %>' UnBoundSelectedValue='<%# DataBinder.Eval(Container.DataItem,"area") %>'  SelectedValue='<%# Bind(Container.DataItem, "area")%>'>
                                                        <asp:ListItem Text="HK" Value="HK"></asp:ListItem>
                                                        <asp:ListItem Text="KLN" Value="KLN"></asp:ListItem>
                                                        <asp:ListItem Text="NT" Value="NT"></asp:ListItem>
                                                        <asp:ListItem Text="LT" Value="LT"></asp:ListItem>
                                                        </Dna:AspxDropDownList>
                                                    </EditItemTemplate>
                                                </Dna:AspxTemplateField>
                                                
                                                
                       <Dna:AspxTemplateField FilterDataField="fee" SortExpression="fee" HeaderText="Fee" TypeCode="String">
                    <ItemTemplate>
                        <asp:Literal ID="fee" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "fee")%>'></asp:Literal>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <Dna:AspxTextBox ID="fee" runat="server" Text='<%# Bind(Container.DataItem, "fee")%>' MaxLength="6" Font-Size="12px" Width="50px"></Dna:AspxTextBox>
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
                
                 <table style="width:100%; background-color:White"  cellpadding="10" >
                 <tr>
                 <td align="left">
                 
                   <user:MasterDetailDeliveryTime ID="MasterDetailDeliveryTimeUserControl" runat="server" />
                 
                 </td>
                 </table>
                </MasterDetailTemplate>
                
                </Dna:AspxGridView>



              
                  <asp:SqlDataSource ID="DeliveryLocationObj" runat="server" 
                      ConnectionString="<%$ ConnectionStrings:MobileRetentionOrderDB %>" 
                      DeleteCommand="DELETE FROM [DeliveryLocation] WHERE [id] = @id" 
                      InsertCommand="INSERT INTO [DeliveryLocation] ([location], [area], [fee], [active]) VALUES (@location, @area, @fee, @active)" 
                      SelectCommand="SELECT [id], [location],[area], [fee], [active] FROM [DeliveryLocation]" 
                      
                      UpdateCommand="UPDATE [DeliveryLocation] SET [location] = @location, [area] = @area, [fee] = @fee, [active] = @active WHERE [id] = @id" 
                      oninit="DeliveryLocationObj_Init">
                      <DeleteParameters>
                          <asp:Parameter Name="id" Type="Int32" />
                      </DeleteParameters>
                      <UpdateParameters>
                          <asp:Parameter Name="location" Type="String" />
                          <asp:Parameter Name="area" Type="String" />
                          <asp:Parameter Name="fee" Type="String" />
                          <asp:Parameter Name="active" Type="Boolean" />
                          <asp:Parameter Name="id" Type="Int32" />
                      </UpdateParameters>
                      <InsertParameters>
                          <asp:Parameter Name="location" Type="String" />
                          <asp:Parameter Name="area" Type="String" />
                          <asp:Parameter Name="fee" Type="String" />
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

