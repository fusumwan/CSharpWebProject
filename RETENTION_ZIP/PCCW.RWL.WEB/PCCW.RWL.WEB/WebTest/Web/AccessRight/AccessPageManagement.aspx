<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AccessPageManagement.aspx.cs" Inherits="Web_AccessPageManagement" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="~/UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7" />
   <meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<link href="../../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<link rel="stylesheet" href="../../Resources/Styles/MainPageStyle.css" type="text/css" />
<asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>

<script language="javascript">
    $(document).ready(function() {
        var GoPageAccessRighPageClick = function() {
            var PageAccessRightList = $(".PageAccessRightList");
            var PageAccessRightListVal = PageAccessRightList.val();
            if (PageAccessRightListVal != '') {
                var URL = PageAccessRightListVal + ".aspx";
                document.location = URL;
            }
        }
        $(".GoPageAccessRighPage").click(GoPageAccessRighPageClick);
    });
</script>

</head>
<body style="background-color:#ffffff">
<form id="form1" runat="server" >
<div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
<asp:Panel ID="Panel1" runat="server" CssClass="">
    <div>
        <div>
            <table cellpadding="3" cellspacing="3" width="100%">
                <tr>
                    <td>
                        <asp:ScriptManager ID="AddWebLogScriptManager" runat="server"></asp:ScriptManager>
                        <br />
                        <h2>&nbsp;&nbsp;Access Right Control System</h2>
                        <hr color="black"/>
                        <asp:DropDownList ID="PageAccessRightList" runat="server" CssClass="PageAccessRightList" AppendDataBoundItems="true">
                        <asp:ListItem Text="" Value=""></asp:ListItem>
                        <asp:ListItem Text="Profile Team Management" Value="ProfileTeamManagement"></asp:ListItem>
                        <asp:ListItem Text="Mobile Order Issue Order" Value="MobileOrderIssueOrderRestrictionControlPage"></asp:ListItem>
                        </asp:DropDownList>
                         <input type="button" id="GoPageAccessRighPage" runat="server" class="button GoPageAccessRighPage" value="GO" />
                        <hr color="black"/>
 
                        <h7>&nbsp;&nbsp;Access Page Register</h7><br /><br />

                        <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">  
                            <tr>
                                <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">
                                    Access Page:</span></td>
                                <td width="77%" height="25" class="row1"><asp:DropDownList ID="AccessPageDrp1" runat="server" DataValueField="id" DataTextField="access_page"  AppendDataBoundItems="true"></asp:DropDownList><asp:HiddenField ID="AccessPageDrp1Value" runat="server" /></td>
                            </tr>
                            <tr>
                                <td width="100%" height="25" class="row2" colspan="2"><span class="explaintitle" style="font-size:7pt"><asp:Button ID="AccessPageSearchBtn" runat="server" Text="Search" onclick="AccessPageSearchBtn_Click"  CssClass=button /></span>
                                </td>
                            </tr>
                        </table>
                        <br />
                        
                        <EW:GridViewEx ID="AccessPageGV" runat="server" AllowPaging="True"  PageSize="5" 
                            AutoGenerateColumns="False" CssClass="table-report" EmptyDataText="There has no record for you to assign page"  DataKeyNames="id" 
                            DataSourceID="AccessPageSqlDataSource" 
                            EmptyShowHeader="true" 
                             onrowcommand="AccessPageGV_RowCommand" 
                            FormViewID="AccessPageFV" 
                            onpageindexchanged="AccessPageGV_PageIndexChanged">
                            <Columns>
                            <asp:TemplateField>
                            <HeaderTemplate>
                            <asp:Button ID="InsertRecord" runat="server" CommandName="Insert" Text="Insert"  CssClass="button"  />
                            </HeaderTemplate>
                            <ItemTemplate>
                            <asp:Button ID="EditRecord" runat="server" CommandName="Edit" Text="Edit"  CssClass="button"  />
                                &nbsp;<asp:Button ID="DeleteRecord" runat="server" CommandName="Delete" Text="Delete"  CssClass="button"  />
                            </ItemTemplate>
                            <EditItemTemplate>
                            <asp:Button ID="UpdateRecord" runat="server" CommandName="Update" Text="Update" CssClass="button"   />
                                &nbsp;
                            <asp:Button ID="CancelRecord" runat="server" CommandName="Cancel" Text="Cancel"  CssClass="button"  />
                            </EditItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="access_page" HeaderText="Access Page" SortExpression="access_page" />
                            <asp:BoundField DataField="page_desc" HeaderText="Page Description" SortExpression="page_desc" />
                            <asp:BoundField DataField="id" HeaderText="ID" InsertVisible="False"   ReadOnly="True" SortExpression="id" />
                            <asp:BoundField DataField="cid" HeaderText="Create ID" SortExpression="cid" />
                            <asp:CheckBoxField DataField="active" HeaderText="Active"  SortExpression="active" /></Columns><PagerStyle Font-Size="12px" /></EW:GridViewEx>
                        <EW:FormViewEx ID="AccessPageFV" runat="server" CssClass="form-order" 
                            DataKeyNames="id" DataSourceID="AccessPageSqlDataSource" Visible="false" 
                            onitemcommand="AccessPageFV_ItemCommand" 
                            oniteminserted="AccessPageFV_ItemInserted">
                            <EditItemTemplate>
                            <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">  
                <tr> 
                    <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">
                        Access Page:</span></td>
                    <td width="77%" height="25" class="row1"><asp:TextBox ID="access_pageTextBox" runat="server" Text='<%# Bind("access_page") %>' /></td>
                </tr>  
                <tr> 
                    <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">
                        Page Description:</span></td>
                    <td width="77%" height="25" class="row1"><asp:TextBox ID="page_descTextBox" runat="server" MaxLength="250" Text='<%# Bind("page_description") %>' Width="250" /></td>
                </tr>  
                <tr> 
                    <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">
                        ID:</span></td>
                    <td width="77%" height="25" class="row1"><asp:Label  ID="idLabel1" runat="server" style="display:none" Text='<%# Eval("id") %>' /></td>
                </tr>  
                <tr> 
                    <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">
                        Create ID:</span></td>
                    <td width="77%" height="25" class="row1"><asp:TextBox ID="cidTextBox" runat="server" Text='<%# Bind("cid") %>' /></td>
                </tr>  
                <tr> 
                    <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">
                        Active:</span></td>
                    <td width="77%" height="25" class="row1"><asp:CheckBox ID="activeCheckBox" runat="server" Checked='<%# Bind("active") %>' /></td>
                </tr>  
                <tr> 
                    <td width="100%" height="25" class="row2" colspan="2"><span class="explaintitle" style="font-size:7pt"><asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" CssClass="button"   />
                        &nbsp;<asp:Button ID="UpdateCancelButton" runat="server" CausesValidation="False"  CommandName="Cancel" Text="Cancel" CssClass="button"   /></span></td></tr></table>
                            
                            </EditItemTemplate>
                            <InsertItemTemplate>
                            <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">  
                <tr> 
                    <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">
                        Access Page:</span></td>
                    <td width="77%" height="25" class="row1"><asp:TextBox ID="access_pageTextBox" runat="server" Text='<%# Bind("access_page") %>' /></td>
                </tr>  
                <tr> 
                    <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">
                        Page Description:</span></td>
                    <td width="77%" height="25" class="row1"><asp:TextBox ID="page_descTextBox" runat="server" MaxLength="250" Text='<%# Bind("page_desc") %>' Width="250" /></td>
                </tr>  
                <tr> 
                    <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">
                        Create ID:</span></td>
                    <td width="77%" height="25" class="row1"><asp:TextBox ID="cidTextBox" runat="server" oninit="cidTextBox_Init" ReadOnly="True" Text='<%# Bind("cid") %>' /></td>
                </tr>  
                <tr> 
                    <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">
                        Active:</span></td>
                    <td width="77%" height="25" class="row1"><asp:CheckBox ID="activeCheckBox" runat="server" Checked='<%# Bind("active") %>' OnInit="activeCheckBox_Init" />
                </td>
                </tr>  
                <tr> 
                    <td width="100%" height="25" class="row2" colspan="2"><span class="explaintitle" style="font-size:7pt"><asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" CssClass="button"/>
                        &nbsp;<asp:Button ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" CssClass="button"/></span></td></tr></table></InsertItemTemplate>
                    
                    
                <ItemTemplate>
                        <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">  
                <tr> 
                    <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">
                        Access Page Name:</span></td>
                    <td width="77%" height="25" class="row1"><asp:Label ID="access_pageLabel" runat="server" Text='<%# Bind("access_page") %>' /></td>
                </tr>
                <tr> 
                    <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">
                        Page Description:</span></td>
                    <td width="77%" height="25" class="row1"><asp:Label ID="page_descLabel" runat="server" Text='<%# Bind("page_desc") %>' /></td>
                </tr>
                <tr> 
                    <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">
                        ID:</span></td>
                    <td width="77%" height="25" class="row1"><asp:Label ID="idLabel" runat="server" style="display:none"  Text='<%# Eval("id") %>' /></td>
                </tr>
                <tr> 
                    <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">
                        Create ID:</span></td>
                    <td width="77%" height="25" class="row1"><asp:Label ID="cidLabel" runat="server" Text='<%# Bind("cid") %>' /></td>
                </tr>
                <tr> 
                    <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">
                        Active:</span></td>
                    <td width="77%" height="25" class="row1"><asp:CheckBox ID="activeCheckBox" runat="server"  Checked='<%# Bind("active") %>' /></td></tr>
                    </table></ItemTemplate></EW:FormViewEx>
                    
                        <asp:SqlDataSource ID="AccessPageSqlDataSource" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:MobileRetentionOrderDB2 %>" 
                            DeleteCommand="DELETE FROM [AccessPage] WHERE [id] = @id" 
                            InsertCommand="INSERT INTO [AccessPage] ([access_page],[page_desc], [cid], [active]) VALUES (@access_page,@page_desc, @cid, @active)" 
                            oninit="AccessPageSqlDataSource_Init" 
                            SelectCommand="SELECT [access_page],[page_desc], [id], [cid], [active] FROM [AccessPage]" 
                            UpdateCommand="UPDATE [AccessPage] SET [access_page] = @access_page,[page_desc]=@page_desc, [cid] = @cid, [active] = @active WHERE [id] = @id" 
                            onupdating="AccessPageSqlDataSource_Updating">
                            <DeleteParameters>
                                <asp:Parameter Name="id" Type="Int32" />
                            </DeleteParameters>
                            <UpdateParameters>
                                <asp:Parameter Name="access_page" Type="String" />
                                <asp:Parameter Name="page_desc" Type="String" />
                                <asp:Parameter Name="cid" Type="String" />
                                <asp:Parameter Name="active" Type="Boolean" />
                                <asp:Parameter Name="id" Type="Int32" />
                            </UpdateParameters>
                            <InsertParameters>
                                <asp:Parameter Name="access_page" Type="String" />
                                <asp:Parameter Name="page_desc" Type="String" />
                                <asp:Parameter Name="cid" Type="String" />
                                <asp:Parameter Name="active" Type="Boolean" />
                            </InsertParameters>
                        </asp:SqlDataSource>
                        <br />
                        <hr color="black"/>
                        <br />
                        <h7>&nbsp;&nbsp;Access Level Register</h7><br /><br />

                        <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">  
                            <tr>
                                <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">
                                    Access Page:</span></td>
                                <td width="77%" height="25" class="row1"><asp:DropDownList ID="AccessPageDrp2" runat="server"  AppendDataBoundItems="true" DataValueField="id" DataTextField="access_page"  ></asp:DropDownList><asp:HiddenField ID="AccessPageDrp2Value" runat="server" /></td>
                            </tr>
                            <tr>
                                <td width="100%" height="25" class="row2" colspan="2"><span class="explaintitle" style="font-size:7pt"><asp:Button ID="AccessPageProfileSearchBtn" runat="server" Text="Search" onclick="AccessPageProfileSearchBtn_Click" CssClass="button"/></span>
                            </td>
                        </tr>
                        </table><br />

                        <EW:GridViewEx ID="AccessPageProfileGV" runat="server" EmptyShowHeader="true" CssClass="table-report"  
                            AutoGenerateColumns="False" AllowPaging="True"   PageSize="5"  
                            FormViewID="AccessPageProfileFV" 
                            DataKeyNames="id"  
                            DataSourceID="AccessPageProfileSqlDataSource" 
                            onpageindexchanging="AccessPageProfileGV_PageIndexChanging" 
                            onrowcommand="AccessPageProfileGV_RowCommand" ><Columns><asp:TemplateField><HeaderTemplate><asp:Button ID="InsertRecord" runat="server" CommandName="Insert" Text="Insert" CssClass="button"/></HeaderTemplate><ItemTemplate><asp:Button ID="EditRecord" runat="server" CommandName="Edit" Text="Edit" CssClass="button"/>
                                &nbsp;<asp:Button ID="DeleteRecord" runat="server" CommandName="Delete" Text="Delete" CssClass="button"/></ItemTemplate><EditItemTemplate><asp:Button ID="UpdateRecord" runat="server" CommandName="Update" Text="Update" CssClass="button"/>
                                    &nbsp;<asp:Button ID="CancelRecord" runat="server" CommandName="Cancel" Text="Cancel" CssClass="button"/></EditItemTemplate></asp:TemplateField>
                                <asp:BoundField DataField="id" HeaderText="ID" InsertVisible="False"  
                                    ReadOnly="True" SortExpression="id" />
                                <asp:TemplateField HeaderText="Page Code"><ItemTemplate><asp:Label ID="access_page_id" Text='<%# this.GetAccessPageById(Eval("access_page_id").ToString()) %>' runat="server"> </asp:Label></ItemTemplate><EditItemTemplate><asp:Label ID="Label1" Text='<%# this.GetAccessPageById(Eval("access_page_id").ToString()) %>' runat="server"></asp:Label><asp:HiddenField ID="access_page_id" Value='<%# Bind("access_page_id") %>' runat="server" /></EditItemTemplate></asp:TemplateField>
                                <asp:TemplateField HeaderText="Level"><ItemTemplate><asp:DropDownList ID="AccessLevel" Enabled="false" AppendDataBoundItems="true" runat="server" SelectedValue='<%# Bind("access_level") %>'><asp:ListItem Text="" Value=""> </asp:ListItem><asp:ListItem Text="FL" Value="1"></asp:ListItem><asp:ListItem Text="UM" Value="10"></asp:ListItem><asp:ListItem Text="SM" Value="2"></asp:ListItem><asp:ListItem Text="HELP LEVEL" Value="3"></asp:ListItem><asp:ListItem Text="RELEASE RESTRICTION ONLY" Value="4"></asp:ListItem><asp:ListItem Text="VIEW ONLY LEVEL" Value="5"></asp:ListItem><asp:ListItem Text="PY LEVEL" Value="6"></asp:ListItem><asp:ListItem Text="FS LEVEL" Value="7"></asp:ListItem><asp:ListItem Text="SPECIAL UID" Value="100"></asp:ListItem><asp:ListItem Text="SU LEVEL" Value="65535"></asp:ListItem></asp:DropDownList></ItemTemplate><EditItemTemplate><asp:DropDownList ID="AccessLevel" Enabled="true" AppendDataBoundItems="true" runat="server" SelectedValue='<%# Bind("access_level") %>'><asp:ListItem Text="" Value=""></asp:ListItem><asp:ListItem Text="FL" Value="1"></asp:ListItem><asp:ListItem Text="UM" Value="10"></asp:ListItem><asp:ListItem Text="SM" Value="2"></asp:ListItem><asp:ListItem Text="HELP LEVEL" Value="3"></asp:ListItem><asp:ListItem Text="RELEASE RESTRICTION ONLY" Value="4"> </asp:ListItem><asp:ListItem Text="VIEW ONLY LEVEL" Value="5"></asp:ListItem><asp:ListItem Text="PY LEVEL" Value="6"></asp:ListItem><asp:ListItem Text="FS LEVEL" Value="7"></asp:ListItem><asp:ListItem Text="SPECIAL UID" Value="100"></asp:ListItem><asp:ListItem Text="SU LEVEL" Value="65535"></asp:ListItem></asp:DropDownList></EditItemTemplate></asp:TemplateField>
                                <asp:CheckBoxField DataField="active" HeaderText="Active" 
                                    SortExpression="active" /><asp:BoundField DataField="sp_uid" 
                                    HeaderText="Special UID" SortExpression="sp_uid" />
                                <asp:BoundField DataField="cid" HeaderText="Create ID" SortExpression="cid" /></Columns><PagerStyle Font-Size="12px" /></EW:GridViewEx>
                            
                        <EW:FormViewEx ID="AccessPageProfileFV" runat="server"  CssClass="form-order" 
                            DataSourceID="AccessPageProfileSqlDataSource" DataKeyNames="id" 
                            Visible="false" onitemcommand="AccessPageProfileFV_ItemCommand" 
                            oniteminserted="AccessPageProfileFV_ItemInserted"><EditItemTemplate>
                                <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">  
                            <tr>
                                <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">
                                    ID:</span></td>
                                <td width="77%" height="25" class="row1"><asp:Label 
                                ID="idLabel1" runat="server" Text='<%# Eval("id") %>' /></td>
                            </tr>
                            <tr>
                                <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">
                                    Page Code:</span></td>
                                <td width="77%" height="25" class="row1"><asp:DropDownList 
                                ID="AccessPageId" runat="server" AppendDataBoundItems="true" 
                                DataSource="<%# GetAccessPageList() %>" DataTextField="access_page" 
                                DataValueField="id" SelectedValue='<%# Bind("access_page_id") %>'>
                            </asp:DropDownList></td>
                            </tr>
                            <tr>
                                <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">Level:</span></td>
                                <td width="77%" height="25" class="row1"><asp:DropDownList ID="AccessLevel" runat="server" AppendDataBoundItems="true" SelectedValue='<%# Bind("access_level") %>'><asp:ListItem Text="" Value=""></asp:ListItem><asp:ListItem 
                                    Text="FL" Value="1"></asp:ListItem><asp:ListItem Text="UM" Value="10"></asp:ListItem><asp:ListItem 
                                    Text="SM" Value="2"></asp:ListItem><asp:ListItem Text="HELP LEVEL" Value="3"></asp:ListItem><asp:ListItem Text="RELEASE RESTRICTION ONLY" Value="4"></asp:ListItem><asp:ListItem Text="VIEW ONLY LEVEL" Value="5"></asp:ListItem><asp:ListItem 
                                    Text="PY LEVEL" Value="6"></asp:ListItem><asp:ListItem Text="FS LEVEL" 
                                    Value="7"></asp:ListItem><asp:ListItem Text="SPECIAL UID" Value="100"></asp:ListItem><asp:ListItem 
                                    Text="SU LEVEL" Value="65535"></asp:ListItem></asp:DropDownList></td>
                            </tr>
                            <tr>
                                <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">
                                    Active:</span></td>
                                <td width="77%" height="25" class="row1"><asp:CheckBox 
                                ID="activeCheckBox" runat="server" Checked='<%# Bind("active") %>' /></td>
                            </tr>
                            <tr>
                                <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">
                                    Special UID:</span></td>
                                <td width="77%" height="25" class="row1"><asp:TextBox ID="sp_uidTextBox" runat="server" 
                                Text='<%# Bind("sp_uid") %>' /></td>
                            </tr>
                            <tr>
                                <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">
                                    Create ID:</span></td>
                                <td width="77%" height="25" class="row1"><asp:TextBox ID="cidTextBox" runat="server" 
                                Text='<%# Bind("cid") %>' /></td>
                            </tr>
                            <tr>
                                <td width="100%" height="25" class="row2" colspan="2"><span class="explaintitle" style="font-size:7pt"><asp:Button ID="UpdateButton" runat="server" CausesValidation="True"  CommandName="Update" Text="Update" CssClass="button"/>
                                    &nbsp;<asp:Button ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" CssClass="button"/></td></tr></table></EditItemTemplate><InsertItemTemplate>
                                
                                
                                
                                <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">  
                            <tr>
                                <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">
                                    Page Code:</span></td>
                                <td width="77%" height="25" class="row1"><asp:DropDownList ID="AccessPageId" runat="server" DataTextField="access_page" DataValueField="id" DataSource='<%# GetAccessPageList() %>' AppendDataBoundItems="true" SelectedValue='<%# Bind("access_page_id") %>'></asp:DropDownList></td>
                            </tr>
                            <tr>
                                <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">
                                    Level:</span></td>
                                <td width="77%" height="25" class="row1"><asp:DropDownList ID="AccessLevel" AppendDataBoundItems="true" runat="server" SelectedValue='<%# Bind("access_level") %>' ><asp:ListItem Text="" Value=""></asp:ListItem><asp:ListItem Text="FL" Value="1"></asp:ListItem><asp:ListItem Text="UM" Value="10"></asp:ListItem><asp:ListItem Text="SM" Value="2"></asp:ListItem><asp:ListItem Text="HELP LEVEL" Value="3"></asp:ListItem><asp:ListItem Text="RELEASE RESTRICTION ONLY" Value="4"></asp:ListItem><asp:ListItem Text="VIEW ONLY LEVEL" Value="5"></asp:ListItem><asp:ListItem Text="PY LEVEL" Value="6"></asp:ListItem><asp:ListItem Text="FS LEVEL" Value="7"></asp:ListItem><asp:ListItem Text="SPECIAL UID" Value="100"></asp:ListItem><asp:ListItem Text="SU LEVEL" Value="65535"></asp:ListItem></asp:DropDownList></td>
                            </tr>
                            <tr>
                                <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">
                                    Active:</span></td>
                                <td width="77%" height="25" class="row1"><asp:CheckBox ID="activeCheckBox" runat="server" Checked='<%# Bind("active") %>' OnInit="activeCheckBox_Init" /></td>
                            </tr>
                            <tr>
                                <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">
                                    Special UID:</span></td>
                                <td width="77%" height="25" class="row1"><asp:TextBox ID="sp_uidTextBox" runat="server" Text='<%# Bind("sp_uid") %>' ></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">
                                    Create ID:</span></td>
                                <td width="77%" height="25" class="row1"><asp:TextBox ID="cidTextBox" runat="server" Text='<%# Bind("cid") %>' oninit="cidTextBox_Init" ReadOnly="True" /></td>
                            </tr>
                            <tr>
                                <td width="100%" height="25" class="row2" colspan="2"><span class="explaintitle" style="font-size:7pt"><asp:Button ID="InsertButton" runat="server" CausesValidation="True"  CommandName="Insert" Text="Insert" CssClass="button"/>
                                    &nbsp;<asp:Button ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" CssClass="button"/></td></tr></table>
                                </InsertItemTemplate><ItemTemplate>
                                <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">  
                            <tr>
                                <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">
                                    ID:</span></td>
                                <td width="77%" height="25" class="row1"><asp:Label 
                            ID="idLabel" runat="server" style="display:none" Text='<%# Eval("id") %>' /></td>
                            </tr>
                            <tr>
                                <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">
                                    Page Code:</span></td>
                                <td width="77%" height="25" class="row1"><asp:DropDownList 
                            ID="AccessPageId" runat="server" AppendDataBoundItems="true" 
                            DataSource="<%# GetAccessPageList() %>" DataTextField="access_page" 
                            DataValueField="id" SelectedValue='<%# Bind("access_page_id") %>'>
                        </asp:DropDownList></td>
                            </tr>
                            <tr>
                                <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">
                                    Level:</span></td>
                                <td width="77%" height="25" class="row1"><asp:DropDownList ID="AccessLevel" runat="server" 
                            AppendDataBoundItems="true" 
                            SelectedValue='<%# Bind("access_level") %>'><asp:ListItem Text="" Value=""></asp:ListItem><asp:ListItem 
                                Text="FL" Value="1"></asp:ListItem><asp:ListItem Text="UM" Value="10"></asp:ListItem><asp:ListItem 
                                Text="SM" Value="2"></asp:ListItem><asp:ListItem Text="HELP LEVEL" 
                                Value="3"></asp:ListItem><asp:ListItem Text="RELEASE RESTRICTION ONLY" 
                                Value="4"> </asp:ListItem><asp:ListItem Text="VIEW ONLY LEVEL" Value="5"></asp:ListItem><asp:ListItem 
                                Text="PY LEVEL" Value="6"></asp:ListItem><asp:ListItem Text="FS LEVEL" 
                                Value="7"></asp:ListItem><asp:ListItem Text="SPECIAL UID" Value="100"></asp:ListItem><asp:ListItem 
                                Text="SU LEVEL" Value="65535"></asp:ListItem></asp:DropDownList></td>
                            </tr>
                            <tr>
                                <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">
                                    Active:</span></td>
                                <td width="77%" height="25" class="row1"><asp:CheckBox 
                            ID="activeCheckBox" runat="server" Checked='<%# Bind("active") %>' 
                            Enabled="false" /></td>
                            </tr>
                            <tr>
                                <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">
                                    Special UID:</span></td>
                                <td width="77%" height="25" class="row1"><asp:Label ID="sp_uid" runat="server" Text='<%# Bind("sp_uid") %>' /></td>
                            </tr>
                            <tr>
                                <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">
                                    Create ID:</span></td>
                                <td width="77%" height="25" class="row1"><asp:Label ID="cidLabel" runat="server" Text='<%# Bind("cid") %>' /></td>
                            </tr>
                            <tr>
                                <td width="100%" height="25" class="row2" colspan="2"><span class="explaintitle" style="font-size:7pt"><asp:Button ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" CssClass="button"/>
                                    &nbsp;<asp:Button ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" Cssclass="button"/>
                                    &nbsp;<asp:Button ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" CssClass="button"/></td></tr></table></ItemTemplate></EW:FormViewEx>
                        
                        <br />
                        <asp:SqlDataSource ID="AccessPageProfileSqlDataSource" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:MobileRetentionOrderDB2 %>" 
                            DeleteCommand="DELETE FROM [AccessPageProfile] WHERE [id] = @id" 
                            InsertCommand="INSERT INTO [AccessPageProfile] ([access_page_id], [access_level], [active],[sp_uid], [cid],[cdate]) VALUES (@access_page_id, @access_level, @active,@sp_uid, @cid,getdate())" 
                            SelectCommand="SELECT [id], [access_page_id], [access_level], [active],[sp_uid], [cid] FROM [AccessPageProfile]  "
                            UpdateCommand="UPDATE [AccessPageProfile] SET [access_page_id] = @access_page_id, [access_level] = @access_level, [active] = @active,[sp_uid]=@sp_uid, [cid] = @cid WHERE [id] = @id" 
                            oninit="AccessPageProfileSqlDataSource_Init" 
                            onupdating="AccessPageProfileSqlDataSource_Updating" 
                            ondeleting="AccessPageProfileSqlDataSource_Deleting" >
                            <DeleteParameters>
                                <asp:Parameter Name="id" Type="Int32" />
                            </DeleteParameters>
                            <UpdateParameters>
                                <asp:Parameter Name="access_page_id" Type="Int32" />
                                <asp:Parameter Name="access_level" Type="String" />
                                <asp:Parameter Name="active" Type="Boolean" />
                                <asp:Parameter Name="sp_uid" Type="String" />
                                <asp:Parameter Name="cid" Type="String" />
                                <asp:Parameter Name="id" Type="Int32" />
                            </UpdateParameters>
                            <InsertParameters>
                                <asp:Parameter Name="access_page_id" Type="Int32" />
                                <asp:Parameter Name="access_level" Type="String" />
                                <asp:Parameter Name="active" Type="Boolean" />
                                <asp:Parameter Name="sp_uid" Type="String" />
                                <asp:Parameter Name="cid" Type="String" />
                            </InsertParameters>
                        </asp:SqlDataSource>
                    </td>
                </tr>
            </table>
        </div>
    </div>
    </asp:Panel>

     

<table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="../MobileRetentionMain.aspx">Main Page</a> &raquo; View 
<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
</table>                   

    </form>
</body>
</html>
