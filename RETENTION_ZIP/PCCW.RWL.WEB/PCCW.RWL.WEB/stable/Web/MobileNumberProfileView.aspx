<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/RWLMenu.master" AutoEventWireup="true" CodeFile="MobileNumberProfileView.aspx.cs" Inherits="Web_MobileNumberProfileView" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
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
              
              
              
      <table id="Table1"  runat="server" cellpadding="1" cellspacing="3" >
      <tr>
      <td nowrap="nowrap">
       <Dna:AspxButton ID="Back"  Text="Back" PostBackUrl="BasicBackEndManagement.aspx" runat="server"  />
      </td>

      </tr>
       </table>
              
              
     
<Dna:AspxGridView ID="AspxMobileNumberProfileGV" runat="server" 
                      AllowPaging="True" PageSize="15"
                      AllowSorting="True" DataKeyNames="id" EmptyDataText="Cannot Find Record"
                       AutoGenerateColumns="False"
                      oninit="AspxMobileNumberProfileGV_Init" 
    
    DataSourceID="MobileNumberProfileObj" 
                      onrowcommand="AspxMobileNumberProfileGV_RowCommand" 
                      onrowupdating="AspxMobileNumberProfileGV_RowUpdating"  >
                      <PagerSettings Position="TopAndBottom" />
                       <AspxFilterSetting AllowFilter="True" />
                      <Columns>
                
                <asp:TemplateField>
                <ItemTemplate>
                
                <table id="EditCommandTable" cellpadding="0" border="0" style="height:100%; width:100%; background-color:White">
                <tr>
                <td nowrap="nowrap">
                <Dna:AspxButton  ID="EditBut" CommandName="Edit" Text="Edit" runat="server" />
                <Dna:AspxButton ID="DisableBut" CommandName="Disable" Text="Disable" runat="server" OnClientClick="return confirm('Are you sure to disable this record?');" CommandArgument='<%# ((GridViewRow)Container).RowIndex %>' />
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

               <Dna:AspxTemplateField FilterDataField="record_id" HeaderText="Record ID" SortExpression="record_id"  TypeCode="Int32">
                <ItemTemplate>
                <table id="record_id_tbl" cellpadding="0" cellspacing="0" border="0" style=" border:none; margin:0 0 0 0; padding:0 0 0 0; width:100%">
                <tr>
                <td nowrap="nowrap" align="left">
                <asp:Literal ID="record_id" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "record_id")%>' ></asp:Literal>
                </td>
                </tr>
                </table>
                </ItemTemplate>
                <EditItemTemplate>
                <table id="record_id_tbl" cellpadding="0" cellspacing="0" border="0" style=" border:none; margin:0 0 0 0; padding:0 0 0 0; width:100%">
                <tr>
                <td nowrap="nowrap" align="left">
                 <asp:Literal ID="record_id" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "record_id")%>' ></asp:Literal>
                 <asp:HiddenField ID="order_id" runat="server" Value='<%# Bind(Container.Dataltem,"order_id") %>' />
                </td>
                </tr>
                </table>
                </EditItemTemplate>
                  </Dna:AspxTemplateField>
                  
<Dna:AspxTemplateField FilterDataField="mrt_no" HeaderText="Mobile Number" SortExpression="mrt_no"  TypeCode="Int32">
                <ItemTemplate>
                <table id="mrt_no_tbl" cellpadding="0" cellspacing="0" border="0" style=" border:none; margin:0 0 0 0; padding:0 0 0 0; width:100%">
                <tr>
                <td nowrap="nowrap" align="left">
                <asp:Literal ID="mrt_no" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "mrt_no")%>' ></asp:Literal>
                </td>
                </tr>
                </table>
                </ItemTemplate>
                <EditItemTemplate>
                
                <Dna:AspxTextBox ID="mrt_no" runat="server" Text='<%# Bind(Container.DataItem, "mrt_no")%>' InnerHintMessage="Please kindly Enter MobileNo" HintMessage="Please kindly Enter MobileNo"
                MaxLength="60" Font-Size="12px" Width="240px" ></Dna:AspxTextBox>
                </EditItemTemplate>
                </Dna:AspxTemplateField>


                <Dna:AspxTemplateField FilterDataField="status" HeaderText="Status" SortExpression="status"  TypeCode="String"
                GREATER_THAN="false"
                GREATER_AND_EQUAL_TO="false"
                SMALLER_THAN="false"
                SMALLER_AND_EQUAL_TO="false"
                LIKE="false"
                >
                <ItemTemplate>
                <table id="status_tbl" cellpadding="0" cellspacing="0" border="0" style=" border:none; margin:0 0 0 0; padding:0 0 0 0; width:100%">
                <tr>
                <td nowrap="nowrap" align="left">
                <asp:Literal ID="status" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "status")%>' ></asp:Literal>
                </td>
                </tr>
                </table>
                </ItemTemplate>
                <EditItemTemplate>
                
                                        <Dna:AspxDropDownList ID="status" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="4" 
                                                            Width="150" DataTextField="status" DataValueField="status" 
                                                             CheckAndInsertBoundValue="true" UnBoundSelectedText='<%# DataBinder.Eval(Container.DataItem,"status") %>' UnBoundSelectedValue='<%# DataBinder.Eval(Container.DataItem,"status") %>'  SelectedValue='<%# Bind(Container.DataItem, "status")%>'>
                                        <asp:ListItem Text="AVALIABLE" Value="AVALIABLE"></asp:ListItem>            
                                        <asp:ListItem Text="USED" Value="USED"></asp:ListItem>
                                        <asp:ListItem Text="HOLDED" Value="HOLDED"></asp:ListItem>      
                                        <asp:ListItem Text="CANCELED" Value="CANCELED"></asp:ListItem>      
                                        </Dna:AspxDropDownList>
                </EditItemTemplate>
                </Dna:AspxTemplateField>


                
                <Dna:AspxTemplateField FilterDataField="edf_no" HeaderText="Edf Number" SortExpression="edf_no"  TypeCode="String">
                <ItemTemplate>
                <table id="edf_no_tbl" cellpadding="0" cellspacing="0" border="0" style=" border:none; margin:0 0 0 0; padding:0 0 0 0; width:100%">
                <tr>
                <td nowrap="nowrap" align="left">
                <asp:Literal ID="edf_no" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "edf_no")%>' ></asp:Literal>
                </td>
                </tr>
                </table>
                </ItemTemplate>
                <EditItemTemplate>
                
                <Dna:AspxTextBox ID="edf_no" runat="server" Text='<%# Bind(Container.DataItem, "edf_no")%>' InnerHintMessage="Please kindly Enter Edf Number" HintMessage="Please kindly Enter Edf Number"
                MaxLength="60" Font-Size="12px" Width="240px" ></Dna:AspxTextBox>
                </EditItemTemplate>
                </Dna:AspxTemplateField>

                


                <Dna:AspxTemplateField FilterDataField="pool" HeaderText="Pool" SortExpression="pool"  TypeCode="String"
                GREATER_THAN="false"
                GREATER_AND_EQUAL_TO="false"
                SMALLER_THAN="false"
                SMALLER_AND_EQUAL_TO="false"
                LIKE="false"
                >
                <ItemTemplate>
                <table id="pool_tbl" cellpadding="0" cellspacing="0" border="0" style=" border:none; margin:0 0 0 0; padding:0 0 0 0; width:100%">
                <tr>
                <td nowrap="nowrap" align="left">
                <asp:Literal ID="pool" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "pool")%>' ></asp:Literal>
                </td>
                </tr>
                </table>
                </ItemTemplate>
                <EditItemTemplate>
                
                
                
                <Dna:AspxDropDownList ID="pool" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="2" 
                                    Width="150" DataTextField="pool" DataValueField="pool" 
                                     CheckAndInsertBoundValue="true" UnBoundSelectedText='<%# DataBinder.Eval(Container.DataItem,"pool") %>' UnBoundSelectedValue='<%# DataBinder.Eval(Container.DataItem,"pool") %>'  SelectedValue='<%# Bind(Container.DataItem, "pool")%>'>
                <asp:ListItem Text="GUANGZHOU" Value="GUANGZHOU"></asp:ListItem>            
                <asp:ListItem Text="SHANGHAI" Value="SHANGHAI"></asp:ListItem>           
                </Dna:AspxDropDownList>
                </EditItemTemplate>
                </Dna:AspxTemplateField>



                <Dna:AspxTemplateField FilterDataField="mrt_group" HeaderText="Group" SortExpression="mrt_group"  TypeCode="String"
                GREATER_THAN="false"
                GREATER_AND_EQUAL_TO="false"
                SMALLER_THAN="false"
                SMALLER_AND_EQUAL_TO="false"
                LIKE="false"
                >
                <ItemTemplate>
                <table id="mrt_group_tbl" cellpadding="0" cellspacing="0" border="0" style=" border:none; margin:0 0 0 0; padding:0 0 0 0; width:100%">
                <tr>
                <td nowrap="nowrap" align="left">
                <asp:Literal ID="mrt_group" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "mrt_group")%>' ></asp:Literal>
                </td>
                </tr>
                </table>
                </ItemTemplate>
                <EditItemTemplate>
                
                                        <Dna:AspxDropDownList ID="mrt_group" AppendDataBoundItems="true" runat="server" Font-Size="12px" Rows="2" 
                                                            Width="150" DataTextField="mrt_group" DataValueField="mrt_group" 
                                                             CheckAndInsertBoundValue="true" UnBoundSelectedText='<%# DataBinder.Eval(Container.DataItem,"mrt_group") %>' UnBoundSelectedValue='<%# DataBinder.Eval(Container.DataItem,"mrt_group") %>'  SelectedValue='<%# Bind(Container.DataItem, "mrt_group")%>'>
                                        <asp:ListItem Text="3GMOBILE" Value="3GMOBILE"></asp:ListItem>            
                                        <asp:ListItem Text="2GMOBILE" Value="2GMOBILE"></asp:ListItem>           
                                        </Dna:AspxDropDownList>
                </EditItemTemplate>
                </Dna:AspxTemplateField>

         <Dna:AspxTemplateField FilterDataField="cid" HeaderText="UserID" SortExpression="cid"  TypeCode="String">
                <ItemTemplate>
                <table id="cid_tbl" cellpadding="0" cellspacing="0" border="0" style=" border:none; margin:0 0 0 0; padding:0 0 0 0; width:100%">
                <tr>
                <td nowrap="nowrap" align="left">
                <asp:Literal ID="cid" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "cid")%>' ></asp:Literal>
                </td>
                </tr>
                </table>
                </ItemTemplate>
                <EditItemTemplate>
                <asp:Literal ID="cid" runat="server" Text='<%# Bind(Container.DataItem, "cid")%>' ></asp:Literal>

                </EditItemTemplate>
                </Dna:AspxTemplateField>


<Dna:AspxTemplateField FilterDataField="cdate" SortExpression="cdate" HeaderText="cdate"
            TypeCode="DateTime" FilterDataFormatString="dd/MM/yyyy" LIKE="false">
            <ItemTemplate>
                <asp:Literal ID="cdate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "cdate","{0:dd/MM/yyyy}")%>'></asp:Literal>
            </ItemTemplate>
            <EditItemTemplate>
                <table id="CdateTbl" runat="server" cellpadding="0" cellspacing="0">
                    <tr>
                        <td nowrap="nowrap">
                            <table cellpadding="0" cellspacing="0" border="0">
                                <tr>
                                    <td>
                                    
                                        <asp:Literal ID="cdate" Text='<%# Bind(Container.DataItem, "cdate","{0:dd/MM/yyyy}")%>'
                                            runat="server"  />
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




  <asp:SqlDataSource ID="MobileNumberProfileObj" runat="server" 
                      ConnectionString="<%$ ConnectionStrings:MobileRetentionOrderDB2 %>" 
                      DeleteCommand="DELETE FROM [MobileNumberProfile] WHERE [id] = @id" 
                      InsertCommand="INSERT INTO [MobileNumberProfile] ([order_id], [mrt_no], [status], [edf_no],  [did], [cdate], [cid], [mrt_group], [pool], [active]) VALUES (@order_id, @mrt_no, @status, @edf_no,  @did, @cdate, @cid, @mrt_group, @pool, @active)" 
                      SelectCommand="SELECT [id],[record_id], [order_id], [mrt_no], [status], [edf_no], [did], [cdate], [cid], [mrt_group], [pool] FROM [MobileNumberProfileView] WHERE active = 1" 
                      UpdateCommand="UPDATE [MobileNumberProfile] SET [order_id] = @order_id, [mrt_no] = @mrt_no, [status] = @status, [edf_no] = @edf_no, [did] = @did, [cdate] = @cdate, [cid] = @cid, [mrt_group] = @mrt_group, [pool] = @pool WHERE [id] = @id" 
                      oninit="MobileNumberProfileObj_Init" >
      <DeleteParameters>
          <asp:Parameter Name="id" Type="Int32" />
      </DeleteParameters>
      <UpdateParameters>
          <asp:Parameter Name="order_id" Type="Int32" />
          <asp:Parameter Name="mrt_no" Type="Int32" />
          <asp:Parameter Name="status" Type="String" />
          <asp:Parameter Name="edf_no" Type="String" />
          <asp:Parameter Name="ddate" Type="DateTime" />
          <asp:Parameter Name="did" Type="String" />
          <asp:Parameter Name="cdate" Type="DateTime" />
          <asp:Parameter Name="cid" Type="String" />
          <asp:Parameter Name="mrt_group" Type="String" />
          <asp:Parameter Name="pool" Type="String" />
          <asp:Parameter Name="active" Type="Boolean" />
          <asp:Parameter Name="id" Type="Int32" />
      </UpdateParameters>
      <InsertParameters>
          <asp:Parameter Name="order_id" Type="Int32" />
          <asp:Parameter Name="mrt_no" Type="Int32" />
          <asp:Parameter Name="status" Type="String" />
          <asp:Parameter Name="edf_no" Type="String" />
          <asp:Parameter Name="ddate" Type="DateTime" />
          <asp:Parameter Name="did" Type="String" />
          <asp:Parameter Name="cdate" Type="DateTime" />
          <asp:Parameter Name="cid" Type="String" />
          <asp:Parameter Name="mrt_group" Type="String" />
          <asp:Parameter Name="pool" Type="String" />
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



