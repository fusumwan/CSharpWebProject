
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VasModifyView.aspx.cs" Inherits="VasModifyView" %>
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
        <style type="text/css">
            .style3
            {
                width: 152px;
                background: #f9f9f9;
            }
            .style4
            {
                width: 170px;
                background: #d9e2ec;
            }
        </style>
    </head>
<body>
    <form id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
<asp:ScriptManager ID="AddWebLogScriptManager" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="vasupdate" runat="server">
    <ContentTemplate>
    <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <th height="28" colspan="2">&nbsp;Modify Vas</th>
                </tr>
                <tr>
          <td height="23" class="row2">
              <asp:Button ID="VasMainPage" runat="server" Text="Vas Main Page" CssClass="mainoption" PostBackUrl="~/Web/VasControlMain.aspx" />
          </td>
          <td class="row2">
          </td>
        </tr>
                <tr>
                <td>
                <asp:DropDownList ID="vas_field" AppendDataBoundItems="true" AutoPostBack="true" 
                        DataTextField="vas_field" DataValueField="vas_field" runat="server" 
                        onselectedindexchanged="vas_field_SelectedIndexChanged"></asp:DropDownList>
                </td>
                </tr>
                <tr>
                <td>
                    <table class="forumline">
                        <tr>
                            <td class="style4" align="center">
                                Vas Name</td>
                            <td class="style3">
                                <asp:TextBox ID="vas_name" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style4" align="center">
                                Vas Chinese Name</td>
                            <td class="style3">
                                <asp:TextBox ID="vas_chi_name" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style4" align="center">
                                Multi</td>
                            <td class="style3">
                                <asp:CheckBox ID="multi" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="style4" align="center">
                                Active</td>
                            <td class="style3">
                                <asp:CheckBox ID="active" runat="server" />
                            </td>
                        </tr>
                    </table>
                            <asp:Button ID="Submit" runat="server" Text="Change" CssClass="button" onclick="Submit_Click" />
                    <br />
                </td>
                </tr>
                <tr> 
                  <td height="23" colspan="2" class="row2" align="center">
        <asp:GridView ID="vas_modify" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="id"
                          ForeColor="#333333" GridLines="None" Width="100%" 
                          DataSourceID="vas_source" oninit="vas_modify_Init" 
                          ondatabinding="vas_modify_DataBinding" 
                          onrowdatabound="vas_modify_RowDataBound" AllowSorting="True" 
                          onrowupdating="vas_modify_RowUpdating" 
                          onrowcommand="vas_modify_RowCommand">
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#EFF3FB" />
            <Columns>
                <asp:CommandField  ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="id" HeaderText="Vas Id Name" ReadOnly="True" 
                    SortExpression="id" InsertVisible="False" Visible="false" />
                    
                    <asp:TemplateField HeaderText="Vas Name" HeaderStyle-CssClass="explaintitle">
                    <ItemTemplate>
                    <asp:Literal ID="vas_name" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"vas_name") %>'></asp:Literal>
                    </ItemTemplate>
                    <EditItemTemplate>
                    <asp:Literal ID="vas_name" runat="server" Text='<%# Bind(Container.DataItem,"vas_name") %>' ></asp:Literal>
                    
                    </EditItemTemplate>
                    </asp:TemplateField>
                    
                    <asp:TemplateField HeaderText="Vas Field" HeaderStyle-CssClass="explaintitle">
                    <ItemTemplate>
                    <asp:Literal ID="vas_field" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"vas_field") %>' ></asp:Literal>
                    </ItemTemplate>
                    <EditItemTemplate>
                     <asp:Literal ID="vas_field" runat="server" Text='<%# Bind(Container.DataItem,"vas_field") %>' ></asp:Literal>
                    </EditItemTemplate>
                    </asp:TemplateField>
                    
                    
                <asp:BoundField DataField="vas_value" HeaderText="Vas Value" 
                    SortExpression="vas_value" />
                 <asp:TemplateField HeaderText="Vas Chinese Name" SortExpression="vas_chi_name">
                 <ItemTemplate>
                 <asp:Literal ID="vas_chi_name" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"vas_chi_name")%>'></asp:Literal>
                 </ItemTemplate>
                 <EditItemTemplate>
                 <asp:Literal ID="vas_chi_name" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"vas_chi_name")%>'></asp:Literal>
                 </EditItemTemplate>
                 </asp:TemplateField>

                <asp:CheckBoxField DataField="active" HeaderText="Active" 
                    SortExpression="active" />
            </Columns>
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" CssClass="explaintitle" />
            <EditRowStyle BackColor="#2461BF" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
                      <br />
                      <asp:SqlDataSource ID="vas_source" runat="server" 
                          onupdating="vas_source_Updating" >
                          <DeleteParameters>
                              <asp:Parameter Name="id" Type="Int32" />
                          </DeleteParameters>
                          <UpdateParameters>
                              <asp:Parameter Name="vas_field" Type="String" />
                              <asp:Parameter Name="vas_value" Type="String" />
                              <asp:Parameter Name="vas_name" Type="String" />
                              <asp:Parameter Name="vas_chi_name" Type="String" />
                              <asp:Parameter Name="active" Type="Boolean" />

                              <asp:Parameter Name="id" Type="Int32" />
                          </UpdateParameters>
                          <InsertParameters>
                              <asp:Parameter Name="vas_field" Type="String" />
                              <asp:Parameter Name="vas_value" Type="String" />
                              <asp:Parameter Name="vas_name" Type="String" />
                              <asp:Parameter Name="vas_chi_name" Type="String" />
                              <asp:Parameter Name="active" Type="Boolean" />
                          </InsertParameters>
                      </asp:SqlDataSource>
        </td>
        </tr>
     </table>   
    </ContentTemplate>
    </asp:UpdatePanel>
    </div>
<table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; View 
<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
</table>       
    </form>
    </body>
</html>
