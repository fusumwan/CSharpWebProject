<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProfileTeamStatusHistory.aspx.cs" Inherits="Web_ProfileTeamStatusHistory" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="../../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet"  href="../../Resources/Styles/global.css" type="text/css" />
<link rel="stylesheet" href="../../Resources/Styles/MainPageStyle.css" type="text/css" />
<asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>

</head>
<body>
    <form id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <cc1:ToolkitScriptManager ID="AddWebLogScriptManager" runat="server" EnablePartialRendering="true" ScriptMode="Release" LoadScriptsBeforeUI="false" EnablePageMethods="true"></cc1:ToolkitScriptManager>
    <div>
    <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
              <tr> 
                <th width="100%" height="28" colspan="30">&nbsp;<%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></th>
              </tr>
              <tr> 
                <td height="40" colspan="26" class="row2"><span class="gensmall" id="rc"><br />
                 <asp:Button ID="BackBut" Text="BACK" CssClass="button" PostBackUrl="~/Web/AccessRight/ProfileTeamManagement.aspx" runat="server"/>
                  </span>
                </td>
              </tr>
              
              <tr>
              <td>
              
              
                  <asp:GridView ID="ProfileTeamRecordHistoryGV" AutoGenerateColumns="false" AllowPaging="true" AllowSorting="true" PageSize=10 DataSourceID="ProfileTeamRecordHistoryObj" DataKeyNames="his_id" runat="server"  CssClass="table-report" EmptyDataText="There has no history record" >
                  <Columns>
                  <asp:TemplateField HeaderText="ACTION TYPE">
                  <ItemTemplate>
                  <asp:Literal ID="action_type" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "action_type") %>'></asp:Literal>
                  <asp:HiddenField ID="his_id" runat="server" Value='<%# DataBinder.Eval(Container.DataItem,"his_id") %>' />
                  </ItemTemplate>
                  </asp:TemplateField>
                  
                  <asp:TemplateField HeaderText="SALESMAN CODE">
                  <ItemTemplate>
                  <asp:Literal ID="salesman_code" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "salesman_code") %>'></asp:Literal>
                  </ItemTemplate>
                  </asp:TemplateField>
                  
                  <asp:TemplateField HeaderText="STAFF NO">
                  <ItemTemplate>
                  <asp:Literal ID="staff_no" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "staff_no") %>'></asp:Literal>
                  </ItemTemplate>
                  </asp:TemplateField>
                  
                  <asp:TemplateField HeaderText="START DATE">
                  <ItemTemplate>
                  <asp:Literal ID="sdate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "sdate","{0:dd/MM/yyyy HH:mm:ss}") %>'></asp:Literal>
                  </ItemTemplate>
                  </asp:TemplateField>
                  
                  <asp:TemplateField HeaderText="END DATE">
                  <ItemTemplate>
                  <asp:Literal ID="edate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "edate","{0:dd/MM/yyyy HH:mm:ss}") %>'></asp:Literal>
                  </ItemTemplate>
                  </asp:TemplateField>
                  
                  <asp:TemplateField HeaderText="CREATED BY">
                  <ItemTemplate>
                  <asp:Literal ID="cid" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "cid") %>'></asp:Literal>
                  </ItemTemplate>
                  </asp:TemplateField>
                  
                  <asp:TemplateField HeaderText="CREATE DATE">
                  <ItemTemplate>
                  <asp:Literal ID="cdate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "cdate","{0:dd/MM/yyyy HH:mm:ss}") %>'></asp:Literal>
                  </ItemTemplate>
                  </asp:TemplateField>
                  
                  <asp:TemplateField HeaderText="DELETE ID">
                  <ItemTemplate>
                  <asp:Literal ID="did" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "did") %>'></asp:Literal>
                  </ItemTemplate>
                  </asp:TemplateField>
                  
                  <asp:TemplateField HeaderText="DELETE DATE">
                  <ItemTemplate>
                  <asp:Literal ID="ddate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ddate","{0:dd/MM/yyyy HH:mm:ss}") %>'></asp:Literal>
                  </ItemTemplate>
                  </asp:TemplateField>
                  
                  <asp:TemplateField HeaderText="Remark">
                  <ItemTemplate>
                  <asp:Literal ID="remark" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "remark") %>'></asp:Literal>
                  </ItemTemplate>
                  </asp:TemplateField>
                  
                  <asp:TemplateField HeaderText="Active">
                  <ItemTemplate>
                  <asp:Literal ID="active" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "active") %>'></asp:Literal>
                  </ItemTemplate>
                  </asp:TemplateField>
                  
                  </Columns>
                  </asp:GridView>
                  <br />
                  <asp:SqlDataSource ID="ProfileTeamRecordHistoryObj" runat="server" 
                      ConnectionString="<%$ ConnectionStrings:MobileRetentionOrderDB2 %>" 
                      
                      SelectCommand="SELECT [his_id], [rec_no], [action_type], [salesman_code], [cdate], [cid], [edate], [sdate], [staff_no], [did], [ddate], [remark], [active] FROM [ProfileTeamRecordHistory] ORDER BY his_id DESC" 
                      oninit="ProfileTeamRecordHistoryObj_Init"></asp:SqlDataSource>
              </td>
              </tr>
     </table>
    
    <table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; View 
<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
</table>  
    </div>
    </form>
</body>
</html>
