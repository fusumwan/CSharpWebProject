<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VasDescriptionNew.aspx.cs" Inherits="VasDescriptionNew" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<%@ Import Namespace="PCCW.RWL.CORE" %>
<%@ Import Namespace="NEURON.ENTITY.FRAMEWORK" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>3G Retention - Web Log</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<script language="javascript">
<!--
function BackVasMain(){
document.location.href="VasControlMain.aspx";
}

-->
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
<asp:ScriptManager ID="AddWebLogScriptManager" runat="server"></asp:ScriptManager>
    
    <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
            <tr>
              <th height="28" colspan="4">&nbsp;Create Vas Desc</th>
            </tr>
            <tr>
          <td height="23" colspan="3" class="row2">
              <asp:Button ID="VasMainPage" runat="server" Text="Vas Main Page" CssClass="mainoption" PostBackUrl="~/Web/VasControlMain.aspx" />
          </td>
          <td class="row2">
          </td>
        </tr>
            <tr>
            <td>
            <input value="Back" id="back" type="button" class="button" onclick="BackVasMain()"  />
            </td>
            </tr>
            <tr>
            <td>
            <asp:UpdatePanel ID="vasform_pd" runat="server">
            <ContentTemplate>
            
            
                <asp:FormView ID="vas_desc_form" runat="server" BackColor="#D1DDF1" 
                    BorderColor="#D1DDF1" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                    CellSpacing="2" DataKeyNames="id" DataSourceID="vas_desc_source" 
                    GridLines="Both" oniteminserting="vas_desc_form_ItemInserting">
                    <FooterStyle BackColor="#D1DDF1" ForeColor="#8C4510" />
                    <RowStyle BackColor="#D1DDF1" ForeColor="#8C4510" />
                    <InsertItemTemplate>
                        VAS:
                        <asp:DropDownList ID="vas" DataSource='<%# VasBindData()  %>' AppendDataBoundItems="true" runat="server" DataTextField="vas_field" DataValueField="vas_field" SelectedValue='<%# Bind("vas") %>'></asp:DropDownList>
                        <br />
                        FEE:
                        <asp:TextBox ID="feeTextBox" runat="server" Text='<%# Bind("fee") %>' />
                        <asp:RequiredFieldValidator ID="RequiredFee" ControlToValidate="feeTextBox" runat="server" ErrorMessage="Required Fee" ValidationGroup="InsertVas"></asp:RequiredFieldValidator>
                        <br />
                        VAS DESCRIPTION:
                        <asp:TextBox ID="vas_descTextBox" runat="server" 
                            Text='<%# Bind("vas_desc") %>' />
<asp:RequiredFieldValidator ID="RequiredVasDesc" ControlToValidate="vas_descTextBox" runat="server" ErrorMessage="Required Vas Description" ValidationGroup="InsertVas"></asp:RequiredFieldValidator>
                        <br />
                        <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" 
                            CommandName="Insert" Text="Insert"  ValidationGroup="InsertVas" />
                    </InsertItemTemplate>
                    <PagerStyle ForeColor="#D1DDF1" HorizontalAlign="Center" />
                    <HeaderStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="White" />
                    <EditRowStyle BackColor="#EFF3FB" Font-Bold="True" ForeColor="Black" />
                </asp:FormView>
                </ContentTemplate>
                
                </asp:UpdatePanel>
                
            </td>
            </tr>
            <tr>
              <td height="23" colspan="4" class="row2" align="center">
              <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                  <asp:GridView ID="vas_desc_gv" AutoGenerateColumns="False" runat="server" 
                      AllowSorting="True" CellPadding="4" DataKeyNames="id" 
                      DataSourceID="vas_desc_source" ForeColor="#333333" GridLines="None" 
                      Width="100%" onrowupdating="vas_desc_gv_RowUpdating">
                      <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                      <RowStyle BackColor="#EFF3FB" />
                      <Columns>
                          <asp:CommandField  ShowEditButton="True" />
                          <asp:BoundField DataField="id" HeaderText="ID" InsertVisible="False" 
                              ReadOnly="True" SortExpression="id" Visible="False" />
                                 
                          <asp:TemplateField HeaderText="VAS FIELD" HeaderStyle-ForeColor="White">
                          <ItemTemplate>
                          <asp:Literal ID="vas" Text='<%# DataBinder.Eval(Container.DataItem,"vas") %>' runat="server"></asp:Literal>
                          </ItemTemplate>
                          <EditItemTemplate>
                          
                          <asp:DropDownList ID="vas" DataSource='<%# VasBindData()  %>' runat="server" DataTextField="vas_field" DataValueField="vas_field" SelectedValue='<%# Bind("vas") %>'></asp:DropDownList>
                          </EditItemTemplate>
                          </asp:TemplateField>
                          <asp:BoundField DataField="fee" HeaderText="VAS FEE" SortExpression="fee" />
                          <asp:BoundField DataField="vas_desc" HeaderText="VAS DESCRITION" 
                              SortExpression="vas_desc" />
                          <asp:CheckBoxField DataField="active" HeaderText="ACTIVE" 
                              SortExpression="active" />
                      </Columns>
                      <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                      <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                      <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                      <EditRowStyle BackColor="#2461BF" />
                      <AlternatingRowStyle BackColor="White" />
                  
                  </asp:GridView>
              
                  <asp:SqlDataSource ID="vas_desc_source" runat="server" 
                      DeleteCommand="DELETE FROM [BusinessVasDescription] WHERE [id] = @id" 
                      InsertCommand="INSERT INTO [BusinessVasDescription] ([vas], [fee], [vas_desc],[active]) VALUES (@vas, @fee, @vas_desc,1)" 
                      SelectCommand="SELECT [id], [vas], [fee], [vas_desc], [active] FROM [BusinessVasDescription] ORDER BY [vas] desc" 
                      
                      UpdateCommand="UPDATE [BusinessVasDescription] SET [vas] = @vas, [fee] = @fee, [vas_desc] = @vas_desc, [active] = @active WHERE [id] = @id" 
                      oninit="vas_desc_source_Init" ondeleted="vas_desc_source_Deleted" 
                      oninserted="vas_desc_source_Inserted" onupdated="vas_desc_source_Updated">
                      <DeleteParameters>
                          <asp:Parameter Name="id" Type="Int32" />
                      </DeleteParameters>
                      <UpdateParameters>
                          <asp:Parameter Name="vas" Type="String" />
                          <asp:Parameter Name="fee" Type="String" />
                          <asp:Parameter Name="vas_desc" Type="String" />
                          <asp:Parameter Name="active" Type="Boolean" />
                          <asp:Parameter Name="id" Type="Int32" />
                      </UpdateParameters>
                      <InsertParameters>
                          <asp:Parameter Name="vas" Type="String" />
                          <asp:Parameter Name="fee" Type="String" />
                          <asp:Parameter Name="vas_desc" Type="String" />
                      </InsertParameters>
                  </asp:SqlDataSource>
                  </ContentTemplate>
                  </asp:UpdatePanel>              
                  <br />
              </td>
            </tr>
    </table>
    </div>
    </form>
</body>
</html>
