<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MessageViewAction.aspx.cs" Inherits="MessageViewAction" %>


<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit.HTMLEditor" tagprefix="cc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<head runat="server">
<title>3G Retention - Web Log</title>       
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>

<link rel="stylesheet"  href="../Resources/Styles/global.css" type="text/css" />
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />

<script language="javascript">
    function isNum(tobj) {
        if (tobj.value != "") {
            a = Number(tobj.value);
            if (!(a) && tobj.value != "0") {
                alert("Number Only!");
                tobj.value = "";
            }
        }
        else
            tobj.value = "";
    }

    function chk_del(id) {
        if (confirm("Are you sure you want to Delete?") == false) {
            event.returnValue = false;
            document.newform.submit2.disabled = false;
        }
        else {
            document.location.href = 'MessageDelete.aspx?mid=' + id;
        }
    }

    function chk_save(ThisForm) {
        if (event.returnValue != false) {
            if (confirm("Are you sure you want to Save?") == false)
                event.returnValue = false;
            else
                ThisForm.submit()
        }
    }
</script>
</head>
<body  style="background-color:#ffffff">



    <form id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
<div id="page-content">
<asp:ScriptManager ID="AddWebLogScriptManager" runat="server"></asp:ScriptManager>


<table width="100%" border="0" cellpadding="3" cellspacing="1" >
<tr>
<td colspan="2" class="maintitle"><span  style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
  <tr> 
    <td height="40" colspan="26" > <input name="submit22" type="button" class="button" value="BACK" onClick="history.go(-1);"/> 
    </td>
  </tr>
  <tr>
  <td>
  <asp:FormView ID="EventMsgDetailFormView" runat="server"  CssClass="form-order"  DefaultMode="Insert"  
          oniteminserting="EventMsgDetailFormView_ItemInserting" 
          DataKeyNames="EventMsgDetail_cid,EventMsgDetail_access_right,EventMsgDetail_message,EventMsgDetail_edate,EventMsgDetail_subject,EventMsgDetail_sdate" 
          DataSourceID="EventMsgDetailObjSource" 
          oniteminserted="EventMsgDetailFormView_ItemInserted">
  <InsertItemTemplate>
    <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">  
                <tr> 
                    <td width="23%" height="25" class="row2" colspan="2"><span class="explaintitle" style="font-size:7pt"><asp:Button ID="InsertButton" runat="server" CssClass=button CausesValidation="True" ValidationGroup="FormViewGw"
          CommandName="Insert" Text="Insert" />&nbsp;<asp:Button ID="InsertCancelButton" runat="server" CssClass=button 
          CausesValidation="False" CommandName="Cancel" Text="Cancel" /></span>
                    </td>
                </tr>
                <tr> 
                    <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">Subject:</span></td>
                    <td width="77%" height="25" class="row1"><asp:TextBox ID="EventMsgDetail_subject" runat="server" Text='<%# Bind("EventMsgDetail_subject") %>' /> <asp:RequiredFieldValidator runat="server" ID="SubjectRequiredFieldValidator"  ValidationGroup="FormViewGw" 
ErrorMessage="Please enter subject"
ControlToValidate="EventMsgDetail_subject" Display="Dynamic" 
EnableClientScript="true" />
                    </td>
                </tr>
                <tr> 
                    <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">Access Right:</span></td>
                    <td width="77%" height="25" class="row1"><asp:DropDownList ID="EventMsgDetail_access_right" runat="server" SelectedValue='<%# Bind(Container.DataItem,"EventMsgDetail_access_right") %>'>
<asp:ListItem Text="" Value=""></asp:ListItem>
<asp:ListItem Text="ALL" Value="all"></asp:ListItem>
<asp:ListItem Text="FL" Value="fl"></asp:ListItem>
<asp:ListItem Text="CSA" Value="csa"></asp:ListItem>
<asp:ListItem Text="SU" Value="su"></asp:ListItem>
</asp:DropDownList>
                    </td>
                </tr>
                <tr> 
                    <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">Start Date:</span></td>
                    <td width="77%" height="25" class="row1"><asp:TextBox ID="EventMsgDetail_sdate" runat="server"  ValidationGroup="FormViewGw"   Text='<%# Bind("EventMsgDetail_sdate","{0:dd/MM/yyyy}") %>'></asp:TextBox>

<asp:ImageButton runat="server" ID="CalenderImageSDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
<cc1:CalendarExtender runat="server" 
ID="CalendarSDateFormat"
TargetControlID="EventMsgDetail_sdate"
Format="dd/MM/yyyy"
PopupButtonID="CalenderImageSDate" ></cc1:CalendarExtender>
<asp:RequiredFieldValidator runat="server" ID="SdateRequiredFieldValidator"  ValidationGroup="FormViewGw" 
ErrorMessage="Please enter a date in the DD/MM/YYYY format"
ControlToValidate="EventMsgDetail_sdate" Display="Dynamic"
EnableClientScript="true" /></td>
                </tr>
                <tr> 
                    <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">End Date:</span></td>
                    <td width="77%" height="25" class="row1"><asp:TextBox ID="EventMsgDetail_edate" runat="server"  Text='<%# Bind(Container.DataItem,"EventMsgDetail_edate","{0:dd/MM/yyyy}") %>'></asp:TextBox>

<asp:ImageButton runat="server" ID="CalenderImageEDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
<cc1:CalendarExtender runat="server" 
ID="CalendarEDateFormat"
TargetControlID="EventMsgDetail_edate"
Format="dd/MM/yyyy"
PopupButtonID="CalenderImageEDate" ></cc1:CalendarExtender>
           <asp:HiddenField ID="cid" runat="server" Value='<%# Bind("EventMsgDetail_cid") %>' /></td>
                </tr>
                <tr> 
                    <td width="23%" height="25" class="row2"><span class="explaintitle" style="font-size:7pt">Message:</span></td>
                    <td width="77%" height="25" class="row1"><asp:TextBox ID="EventMsgDetail_message" Width=500 Height=200 runat="server" TextMode=MultiLine Text='<%# Bind("EventMsgDetail_message") %>' Enabled="true"></asp:TextBox></td>
                </tr>
             </table>
      
      
  </InsertItemTemplate>

  </asp:FormView>

  
  </td>
  </tr>
  
  <tr> 
  <td>
  

  
<EW:GridViewEx ID="EventMsgDetailGw" runat="server"  
          DataSourceID="EventMsgDetailObjSource" EnableViewState=true
AllowPaging="True"  PageSize="5"  DataKeyNames="Index,EventMsgDetail_mid" 
AutoGenerateColumns="False" CssClass="table-report" 
          EmptyDataText="There has no record for you"    Font-Size="12px" onrowupdating="EventMsgDetailGw_RowUpdating"
 >
<Columns>
<asp:TemplateField>
<ItemTemplate>
<asp:Button ID="But_Edit" Text="Edit" CommandName="Edit" CssClass=button  runat="server" />
<asp:Button ID="But_Delete" Text="Delete" CommandName="Delete" CssClass=button runat="server" />
</ItemTemplate>
<EditItemTemplate>
<asp:Button ID="But_Update"  Text="Update" CommandName="Update" CssClass=button  runat="server" />
<asp:Button ID="But_Cancel"  Text="Cancel" CommandName="Cancel" CssClass=button  runat="server" />
</EditItemTemplate>
</asp:TemplateField>

<asp:TemplateField Visible="false">
<ItemTemplate>
<asp:Literal ID="Index" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"Index") %>'></asp:Literal>
</ItemTemplate>
<EditItemTemplate>
<asp:HiddenField ID="Index" runat="server" Value='<%# Bind(Container.DataItem,"Index") %>'></asp:HiddenField>
</EditItemTemplate>
<InsertItemTemplate>
<asp:HiddenField ID="Index" runat="server"  Value ='<%# Bind(Container.DataItem,"Index") %>'></asp:HiddenField>
</InsertItemTemplate>
</asp:TemplateField>



<asp:TemplateField Visible="true">
<ItemTemplate>
<asp:HiddenField ID="EventMsgDetail_mid" runat="server" Value='<%# DataBinder.Eval(Container.DataItem,"EventMsgDetail.mid") %>'></asp:HiddenField>
</ItemTemplate>
<EditItemTemplate>
<asp:HiddenField ID="EventMsgDetail_mid" runat="server" Value='<%# Bind(Container.DataItem,"EventMsgDetail_mid") %>'></asp:HiddenField>
</EditItemTemplate>
<InsertItemTemplate>
<asp:HiddenField ID="EventMsgDetail_mid" runat="server"  Value ='<%# Bind(Container.DataItem,"EventMsgDetail_mid") %>'></asp:HiddenField>
</InsertItemTemplate>
</asp:TemplateField>


<asp:TemplateField Visible="true" HeaderText="SUBJECT">
<ItemTemplate>
<asp:Literal ID="EventMsgDetail_subject" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"EventMsgDetail.subject") %>'></asp:Literal>
</ItemTemplate>
<EditItemTemplate>
<asp:TextBox ID="EventMsgDetail_subject" runat="server" Text='<%# Bind(Container.DataItem,"EventMsgDetail_subject") %>'></asp:TextBox>
<asp:RequiredFieldValidator runat="server" ID="SubjectRequiredFieldValidator"  ValidationGroup="GridViewEdit" 
ErrorMessage="Please enter a date in the DD/MM/YYYY format"
ControlToValidate="EventMsgDetail_subject" Display="Dynamic" 
EnableClientScript="true" />
</EditItemTemplate>
</asp:TemplateField>

<asp:TemplateField Visible="true" HeaderText="MESSAGE ">
<ItemTemplate>
<asp:Literal ID="EventMsgDetail_message" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"EventMsgDetail.message") %>'></asp:Literal>
</ItemTemplate>
<EditItemTemplate>
<asp:TextBox TextMode="MultiLine" ID="EventMsgDetail_message" runat="server" Text='<%# Bind(Container.DataItem,"EventMsgDetail_message") %>'></asp:TextBox>
</EditItemTemplate>
</asp:TemplateField>

<asp:TemplateField Visible="true" HeaderText="ACCESS RIGHT">
<ItemTemplate>
<asp:Literal ID="EventMsgDetail_access_right" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"EventMsgDetail.access_right") %>'></asp:Literal>
</ItemTemplate>
<EditItemTemplate>
<asp:DropDownList ID="EventMsgDetail_access_right" runat="server" SelectedValue='<%# Bind(Container.DataItem,"EventMsgDetail_access_right") %>'>
<asp:ListItem Text="" Value=""></asp:ListItem>
<asp:ListItem Text="ALL" Value="all"></asp:ListItem>
<asp:ListItem Text="FL" Value="fl"></asp:ListItem>
<asp:ListItem Text="CSA" Value="csa"></asp:ListItem>
<asp:ListItem Text="SU" Value="su"></asp:ListItem>
</asp:DropDownList>
</EditItemTemplate>
</asp:TemplateField>

<asp:TemplateField Visible="true" HeaderText="START DATE(DD/MM/YYYY)">
<ItemTemplate>
<asp:Literal ID="EventMsgDetail_sdate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"EventMsgDetail.sdate","{0:dd/MM/yyyy}") %>'></asp:Literal>
</ItemTemplate>
<EditItemTemplate>
<asp:TextBox ID="EventMsgDetail_sdate" runat="server"  ValidationGroup="GridViewEdit"   Text='<%# Bind(Container.DataItem,"EventMsgDetail_sdate","{0:dd/MM/yyyy}") %>'></asp:TextBox>
<asp:RequiredFieldValidator runat="server" ID="SdateRequiredFieldValidator"  ValidationGroup="GridViewEdit" 
ErrorMessage="Please enter a date in the DD/MM/YYYY format"
ControlToValidate="EventMsgDetail_sdate" Display="Dynamic"
EnableClientScript="true" />
<asp:ImageButton runat="server" ID="CalenderImageSDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
<cc1:CalendarExtender runat="server" 
ID="CalendarSDateFormat"
TargetControlID="EventMsgDetail_sdate"
Format="dd/MM/yyyy"
PopupButtonID="CalenderImageSDate" ></cc1:CalendarExtender>
</EditItemTemplate>
</asp:TemplateField>

<asp:TemplateField Visible="true" HeaderText="END DATE(DD/MM/YYYY)">
<ItemTemplate>
<asp:Literal ID="EventMsgDetail_edate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"EventMsgDetail.edate","{0:dd/MM/yyyy}") %>'></asp:Literal>
</ItemTemplate>
<EditItemTemplate>
<asp:TextBox ID="EventMsgDetail_edate" runat="server"  ValidationGroup="GridViewEdit" Text='<%# Bind(Container.DataItem,"EventMsgDetail_edate","{0:dd/MM/yyyy}") %>'></asp:TextBox>

<asp:RequiredFieldValidator runat="server" ID="EdateRequiredFieldValidator" ValidationGroup="GridViewEdit" 
ErrorMessage="Please enter a date in the DD/MM/YYYY format"
ControlToValidate="EventMsgDetail_edate" Display="Dynamic" Enabled="false" 
EnableClientScript="true" />
<asp:ImageButton runat="server" ID="CalenderImageEDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
<cc1:CalendarExtender runat="server" 
ID="CalendarEDateFormat"
TargetControlID="EventMsgDetail_edate"
Format="dd/MM/yyyy"
PopupButtonID="CalenderImageEDate" ></cc1:CalendarExtender>
</EditItemTemplate>
</asp:TemplateField>

<asp:TemplateField Visible="true" HeaderText="ACTIVE">
<ItemTemplate>
<asp:CheckBox ID="EventMsgDetail_active" runat="server" Checked='<%# DataBinder.Eval(Container.DataItem,"EventMsgDetail.active") %>' Enabled=false />
</ItemTemplate>
<EditItemTemplate>
<asp:CheckBox ID="EventMsgDetail_active" runat="server" Checked='<%# Bind(Container.DataItem,"EventMsgDetail_active") %>'  />
</EditItemTemplate>
</asp:TemplateField>

<asp:TemplateField Visible="false">
<ItemTemplate>
<asp:Literal ID="EventMsgDetail_did" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"EventMsgDetail.did") %>'></asp:Literal>
</ItemTemplate>
<EditItemTemplate>
<asp:TextBox ID="EventMsgDetail_did" runat="server" Text='<%# Bind(Container.DataItem,"EventMsgDetail_did") %>'></asp:TextBox>
</EditItemTemplate>
</asp:TemplateField>

<asp:TemplateField Visible="false">
<ItemTemplate>
<asp:Literal ID="EventMsgDetail_cid" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"EventMsgDetail.cid") %>'></asp:Literal>
</ItemTemplate>
<EditItemTemplate>
<asp:TextBox ID="EventMsgDetail_cid" runat="server" Text='<%# Bind(Container.DataItem,"EventMsgDetail_cid") %>'></asp:TextBox>
</EditItemTemplate>
</asp:TemplateField>

<asp:TemplateField Visible="false">
<ItemTemplate>
<asp:Literal ID="EventMsgDetail_ddate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"EventMsgDetail.ddate","{0:dd/MM/yyyy}") %>'></asp:Literal>
</ItemTemplate>
<EditItemTemplate>
<asp:TextBox ID="EventMsgDetail_ddate" runat="server" Text='<%# Bind(Container.DataItem,"EventMsgDetail_ddate","{0:dd/MM/yyyy}") %>'></asp:TextBox>
</EditItemTemplate>
</asp:TemplateField>

<asp:TemplateField Visible="false" HeaderText="CREATE DATE(DD/MM/YYYY)">
<ItemTemplate>
<asp:Literal ID="EventMsgDetail_cdate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"EventMsgDetail.cdate") %>'></asp:Literal>
</ItemTemplate>

<EditItemTemplate>
<asp:TextBox ID="EventMsgDetail_cdate" runat="server" Text='<%# Bind("EventMsgDetail_cdate","{0:dd/MM/yyyy}") %>'></asp:TextBox>
</EditItemTemplate>
</asp:TemplateField>


</Columns>
</EW:GridViewEx>
<br />

</td>
</tr>
</table>
 <asp:ObjectDataSource ID="EventMsgDetailObjSource" runat="server" 
 DataObjectTypeName="PCCW.RWL.CORE.EventMsgDetailView" TypeName="PCCW.RWL.CORE.EventMsgDetailViewDAO"
 DeleteMethod="DeleteEventMsgDetailView" InsertMethod="InsertEventMsgDetailView"
 SelectMethod="FindALL" UpdateMethod="UpdateEventMsgDetailView" 
        OldValuesParameterFormatString="original_{0}" 
        oninit="EventMsgDetailObjSource_Init" >
 
 </asp:ObjectDataSource>
<table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="MobileRetentionMain.aspx">Main Page Page</a> &raquo; View 
<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
</table>                

    </div>
    </form>
</body>
</html>
