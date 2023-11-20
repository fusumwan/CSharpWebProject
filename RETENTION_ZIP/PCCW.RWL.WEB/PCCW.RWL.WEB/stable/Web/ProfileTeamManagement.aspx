<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProfileTeamManagement.aspx.cs" Inherits="Web_ProfileTeamManagement" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet"  href="../Resources/Styles/global.css" type="text/css" />
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>

<script type="text/javascript">

function BackMainPage() {
    document.location.href = "MobileRetentionMain.aspx";
}

</script>

</head>
<body>
<form id="form1" runat="server">
<div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
<div>
<cc1:ToolkitScriptManager ID="AddWebLogScriptManager" runat="server" EnablePartialRendering="true" ScriptMode="Release" LoadScriptsBeforeUI="false" EnablePageMethods="true"></cc1:ToolkitScriptManager>
<table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
              <tr> 
                <th width="100%" height="28" colspan="30">&nbsp;<%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></th>
              </tr>
              <tr> 
                <td height="40" colspan="26" class="row2"><span class="gensmall" id="rc"><br />
                  <input name="submit22" type="button" class="button" value="BACK" onclick="BackMainPage();"/>
                  </span>
                </td>
              </tr>
              
              <tr>
              <td>
              <asp:FormView ID="ProfileTeamFV" runat="server" DefaultMode="Insert"  DataKeyNames="id"
                       Width="100%"  ValidationGroup="ProfileTeamFVValid"  
                      onitemcommand="ProfileTeamFV_ItemCommand" 
                      oniteminserting="ProfileTeamFV_ItemInserting" 
                      onitemcreated="ProfileTeamFV_ItemCreated">
              <InsertItemTemplate>
              <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">  
                <tr>
                    <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">Staff Number:</span></td>
                    <td width="77%" height="25" class="row1" nowrap="nowrap">
                        <asp:TextBox ID="staff_no" runat="server" Text='<%# Bind("staff_no") %>' ValidationGroup="ProfileTeamFVValid" />
                        <asp:RequiredFieldValidator ID="staff_no_valid" ControlToValidate="staff_no" ValidationGroup="ProfileTeamFVValid" ErrorMessage="Please kindly enter the staff number" runat="server"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td width="23%" height="25" class="row2">
                        <span class="explaintitle" style="font-size:7pt">Sales Man Code</span>
                    </td>
                    <td width="77%" height="25" class="row1" nowrap="nowrap">
                        <asp:DropDownList ID="salesman_code" runat="server" AppendDataBoundItems="true" ValidationGroup="ProfileTeamFVValid" DataSource='<%# GetAllSalemanCode() %>' SelectedValue='<%# Bind("salesman_code") %>' >
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="salesman_code_valid" Display="Static" InitialValue="" ValidationGroup="ProfileTeamFVValid"  ControlToValidate="salesman_code" ErrorMessage="Please kindly select the salesman code" runat="server"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td width="23%" height="25" class="row2">
                        <span class="explaintitle" style="font-size:7pt">Start Date(DD/MM/YYY)</span>
                    </td>
                     <td width="77%" height="25" class="row1" nowrap="nowrap">
                        <asp:TextBox ID="sdate" runat="server" Text='<%# Bind("sdate") %>' ValidationGroup="ProfileTeamFVValid" />
                        <asp:ImageButton runat="server" ID="CalenderImageSDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                        <asp:RegularExpressionValidator runat="server" ID="sdate_valid" ValidationGroup="ProfileTeamFVValid" ErrorMessage="Please kindly enter a correct start day."  ControlToValidate="sdate" ValidationExpression="^(([0-2]\d|[3][0-1])\/([0]\d|[1][0-2])\/[2][0]\d{2})$|^(([0-2]\d|[3][0-1])\/([0]\d|[1][0-2])\/[2][0]\d{2}\s([0-1]\d|[2][0-3])\:[0-5]\d\:[0-5]\d)$"></asp:RegularExpressionValidator>
                        <cc1:CalendarExtender runat="server" 
                        ID="CalendarSDateFormat"
                        TargetControlID="sdate"
                        Format="dd/MM/yyyy"
                        PopupButtonID="CalenderImageSDate"/>
                    </td>
                </tr>
                <tr>
                    <td width="23%" height="25" class="row2">
                        <span class="explaintitle" style="font-size:7pt">End Date(DD/MM/YYY)</span>
                    </td>
                     <td width="77%" height="25" class="row1" nowrap="nowrap">
                        <asp:TextBox ID="edate" runat="server" Text='<%# Bind("edate") %>' ValidationGroup="ProfileTeamFVValid" />
                        <asp:ImageButton runat="server" ID="CalenderImageEDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                        <asp:RegularExpressionValidator runat="server" ID="edate_valid" ValidationGroup="ProfileTeamFVValid" ControlToValidate="edate" ErrorMessage="Please kindly enter a correct end day." ValidationExpression="^(([0-2]\d|[3][0-1])\/([0]\d|[1][0-2])\/[2][0]\d{2})$|^(([0-2]\d|[3][0-1])\/([0]\d|[1][0-2])\/[2][0]\d{2}\s([0-1]\d|[2][0-3])\:[0-5]\d\:[0-5]\d)$"></asp:RegularExpressionValidator>
                        <cc1:CalendarExtender runat="server" 
                        ID="CalendarEDateFormat"
                        TargetControlID="edate"
                        Format="dd/MM/yyyy"
                        PopupButtonID="CalenderImageEDate"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="INSERT" runat="server" Text="INSERT" ValidationGroup="ProfileTeamFVValid" CommandName="insert" CssClass="button" />
                    </td>
                    <td>
                    
                    </td>
                </tr>
                </table>
              </InsertItemTemplate>
              </asp:FormView>
              
              </td>
              
              </tr>
              
              <tr>
              <td>
              
<EW:GridViewEx ID="ProfileTeamRecordGV" CssClass="table-report" EmptyShowHeader="true" 
                      EmptyDataText="There has no record for you to change team detail data"  
                      runat="server" DataKeyNames="id"   ValidationGroup="ProfileTeamRecordGVValid" 
AutoGenerateColumns="False" onrowcommand="ProfileTeamRecordGV_RowCommand" 
                      onrowediting="ProfileTeamRecordGV_RowEditing" 
                      onrowupdating="ProfileTeamRecordGV_RowUpdating" 
                      onrowcancelingedit="ProfileTeamRecordGV_RowCancelingEdit" 
                      onrowdeleting="ProfileTeamRecordGV_RowDeleting"  >
<Columns>
<asp:TemplateField Visible="true">
<ItemTemplate>
<asp:Button ID="EditBut" CssClass="button" runat="server" Text="EDIT" CommandName="EDIT" />
<asp:Button ID="DeleteBut" CssClass="button" runat="server" Text="DELETE" CommandName="DELETE" />
</ItemTemplate>
<EditItemTemplate>
<asp:Button ID="UdpateBut" CssClass="button" runat="server" Text="UDPATE"  ValidationGroup="ProfileTeamRecordGVValid" CommandName="Update" />
<asp:Button ID="CancelBut" CssClass="button" runat="server" Text="CANCEL" CommandName="CANCEL" />
</EditItemTemplate>
<InsertItemTemplate>
<asp:Button ID="InsertBut" CssClass="button" runat="server" Text="INSERT"  ValidationGroup="ProfileTeamRecordGVValid" CommandName="INSERT" />
<asp:Button ID="CancelBut" CssClass="button" runat="server" Text="CANCEL" CommandName="CANCEL" />
</InsertItemTemplate>
</asp:TemplateField>

<asp:TemplateField Visible="true"  HeaderText="STAFF NO.">
<ItemTemplate>
<asp:Literal ID="staff_no" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"staff_no") %>'></asp:Literal>
<asp:HiddenField ID="id" runat="server" Value='<%# DataBinder.Eval(Container.DataItem,"id") %>' />
</ItemTemplate>
<EditItemTemplate>
<asp:HiddenField ID="id" runat="server" Value='<%# Bind(Container.DataItem,"id") %>' />
<asp:TextBox ID="staff_no" runat="server" Text='<%# Bind(Container.DataItem,"staff_no") %>'  ValidationGroup="ProfileTeamRecordGVValid" ></asp:TextBox>
<asp:RequiredFieldValidator ID="staff_no_valid" ControlToValidate="staff_no" ValidationGroup="ProfileTeamRecordGVValid" ErrorMessage="Please kindly enter the staff number" runat="server"></asp:RequiredFieldValidator>
</EditItemTemplate>
<InsertItemTemplate>
<asp:HiddenField ID="id" runat="server" Value='<%# Bind(Container.DataItem,"id") %>' />
<asp:TextBox ID="staff_no" runat="server" Text='<%# Bind(Container.DataItem,"staff_no") %>'></asp:TextBox>
</InsertItemTemplate>
</asp:TemplateField>



<asp:TemplateField Visible="true"  HeaderText="SALESMAN CODE">
<ItemTemplate>
<asp:Literal ID="salesman_code" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"salesman_code") %>'></asp:Literal>
</ItemTemplate>
<EditItemTemplate>
<asp:DropDownList ID="salesman_code" runat="server" AppendDataBoundItems="true" ValidationGroup="ProfileTeamRecordGVValid" DataSource='<%# GetAllSalemanCode() %>' SelectedValue='<%# Bind(Container.DataItem,"salesman_code") %>' >
</asp:DropDownList>
 <asp:RequiredFieldValidator ID="salesman_code_valid" Display="Static" InitialValue="" ValidationGroup="ProfileTeamRecordGVValid"  ControlToValidate="salesman_code" ErrorMessage="Please kindly select the salesman code" runat="server"></asp:RequiredFieldValidator>
</EditItemTemplate>
<InsertItemTemplate>
<asp:TextBox ID="salesman_code" runat="server" Text='<%# Bind(Container.DataItem,"salesman_code") %>'></asp:TextBox>
</InsertItemTemplate>
</asp:TemplateField>



<asp:TemplateField Visible="true"  HeaderText="START DATE">
<ItemTemplate>
<asp:Literal ID="sdate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"sdate","{0:dd/MM/yyyy}") %>'></asp:Literal>
</ItemTemplate>
<EditItemTemplate>
<asp:TextBox ID="sdate" runat="server" Text='<%# Bind(Container.DataItem,"sdate","{0:dd/MM/yyyy}") %>'  ValidationGroup="ProfileTeamRecordGVValid" ></asp:TextBox>
 <asp:ImageButton runat="server" ID="CalenderImageSDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                        <asp:RegularExpressionValidator runat="server" ID="sdate_valid" ValidationGroup="ProfileTeamRecordGVValid" ErrorMessage="Please kindly enter a correct start day."  ControlToValidate="sdate" ValidationExpression="^(([0-2]\d|[3][0-1])\/([0]\d|[1][0-2])\/[2][0]\d{2})$|^(([0-2]\d|[3][0-1])\/([0]\d|[1][0-2])\/[2][0]\d{2}\s([0-1]\d|[2][0-3])\:[0-5]\d\:[0-5]\d)$"></asp:RegularExpressionValidator>
                        <cc1:CalendarExtender runat="server" 
                        ID="CalendarSDateFormat"
                        TargetControlID="sdate"
                        Format="dd/MM/yyyy"
                        PopupButtonID="CalenderImageSDate"/>
</EditItemTemplate>
<InsertItemTemplate>
<asp:TextBox ID="sdate" runat="server" Text='<%# Bind(Container.DataItem,"sdate","{0:dd/MM/yyyy}") %>'></asp:TextBox>
</InsertItemTemplate>
</asp:TemplateField>


<asp:TemplateField Visible="true"  HeaderText="END DATE">
<ItemTemplate>
<asp:Literal ID="edate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"edate","{0:dd/MM/yyyy}") %>'></asp:Literal>
</ItemTemplate>
<EditItemTemplate>
<asp:TextBox ID="edate" runat="server" Text='<%# Bind(Container.DataItem,"edate","{0:dd/MM/yyyy}") %>'  ValidationGroup="ProfileTeamRecordGVValid" ></asp:TextBox>
<asp:ImageButton runat="server" ID="CalenderImageEDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                        <asp:RegularExpressionValidator runat="server" ID="edate_valid" ValidationGroup="ProfileTeamRecordGVValid" ControlToValidate="edate" ErrorMessage="Please kindly enter a correct end day." ValidationExpression="^(([0-2]\d|[3][0-1])\/([0]\d|[1][0-2])\/[2][0]\d{2})$|^(([0-2]\d|[3][0-1])\/([0]\d|[1][0-2])\/[2][0]\d{2}\s([0-1]\d|[2][0-3])\:[0-5]\d\:[0-5]\d)$"></asp:RegularExpressionValidator>
                        <cc1:CalendarExtender runat="server" 
                        ID="CalendarEDateFormat"
                        TargetControlID="edate"
                        Format="dd/MM/yyyy"
                        PopupButtonID="CalenderImageEDate"/>
</EditItemTemplate>
<InsertItemTemplate>
<asp:TextBox ID="edate" runat="server" Text='<%# Bind(Container.DataItem,"edate","{0:dd/MM/yyyy}") %>'></asp:TextBox>
</InsertItemTemplate>
</asp:TemplateField>

<asp:TemplateField Visible="true" HeaderText="ACTIVE">
<ItemTemplate>
<asp:CheckBox ID="active" runat="server" Enabled="false" Checked='<%# CheckActive(DataBinder.Eval(Container.DataItem,"active")) %>'></asp:CheckBox>
</ItemTemplate>
<EditItemTemplate>
<asp:CheckBox ID="active" runat="server" Checked='<%# Bind(Container.DataItem,"active") %>'></asp:CheckBox>
</EditItemTemplate>
<InsertItemTemplate>
<asp:CheckBox ID="active" runat="server" Checked='<%# Bind(Container.DataItem,"active") %>'></asp:CheckBox>
</InsertItemTemplate>
</asp:TemplateField>



</Columns>
</EW:GridViewEx>

<br />


              
              </td>
              </tr>
                <tr> 
                <td class="cat" colspan="9">&nbsp;</td>
              </tr>
            </table>
</div>
</form>
    
<table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; View 
<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
</table>              

</body>
</html>
