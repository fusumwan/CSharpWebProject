<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/RWLMenu.master" AutoEventWireup="true" CodeFile="FoManagement.aspx.cs" Inherits="Web_FoManagement" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
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

              <user:AttachmentHandlerJs ID="AttachmentControl" runat="server" />
              <table cellpadding="0" cellspacing="0" border="0" style="margin:0 0 0 0; padding:0 0 0 0">
              <tr>
              <td>
              <Dna:AspxButton ID="BackBut" Text="Back" PostBackUrl="~/Web/MobileRetentionMain.aspx" runat="server" />
              </td>
              <td>&nbsp;</td>
              <td>
              <Dna:AspxButton ID="ExportExcelBut" Text="Export Excel" OnClientClick="AttachmentExport('Handler','CPE'); return false;" runat="server" />
              </td>
              </tr>
              </table>
              <br />
                    
             <Dna:AspxGridView ID="FoManagement_RP" runat="server" AllowPaging="True" PageSize="25"
                    DataKeyNames="SM_NO"  AllowSorting="True" EmptyDataText="There has no record" 
                    AutoGenerateColumns="False" EmptyShowHeader="true" UseSelectCommand="false"
                      onsorting="FoManagement_RP_Sorting" 
                      onfiltercommand="FoManagement_RP_FilterCommand" 
                      onpageindexchanging="FoManagement_RP_PageIndexChanging">
                    <AspxFilterSetting AllowFilter="true" />
                    <PagerSettings Position="TopAndBottom" />
                <Columns>
                <Dna:AspxTemplateField HeaderText="Record ID" FilterDataField="RECORD_ID" SortExpression="RECORD_ID" TypeCode="String">
                <ItemTemplate>
                <asp:Literal ID="RECORD_ID" Text='<%# DataBinder.Eval(Container.DataItem, "RECORD_ID")%>' runat="server"></asp:Literal>
                </ItemTemplate>
                </Dna:AspxTemplateField>
                <Dna:AspxTemplateField HeaderText="EDF NO" FilterDataField="SM_NO" SortExpression="SM_NO" TypeCode="String">
                <ItemTemplate>
                <asp:Literal ID="SM_NO" Text='<%# DataBinder.Eval(Container.DataItem, "SM_NO")%>' runat="server"></asp:Literal>
                </ItemTemplate>
                </Dna:AspxTemplateField>
                <Dna:AspxTemplateField HeaderText="Salesman ID" FilterDataField="SALESMAN_ID" SortExpression="SALESMAN_ID" TypeCode="String">
                <ItemTemplate>
                <asp:Literal ID="SALESMAN_ID" Text='<%# DataBinder.Eval(Container.DataItem, "SALESMAN_ID")%>' runat="server"></asp:Literal>
                </ItemTemplate>
                </Dna:AspxTemplateField>
                <Dna:AspxTemplateField HeaderText="Staff Name" FilterDataField="STAFF_NAME"  SortExpression="STAFF_NAME" TypeCode="String">
                <ItemTemplate>
                <asp:Literal ID="STAFF_NAME" Text='<%# DataBinder.Eval(Container.DataItem, "STAFF_NAME")%>' runat="server"></asp:Literal>
                </ItemTemplate>
                </Dna:AspxTemplateField>
                <Dna:AspxTemplateField HeaderText="Mobile NO" FilterDataField="MOBILE_NO"   SortExpression="MOBILE_NO" TypeCode="String">
                <ItemTemplate>
                <asp:Literal ID="MOBILE_NO" Text='<%# DataBinder.Eval(Container.DataItem, "MOBILE_NO")%>' runat="server"></asp:Literal>
                </ItemTemplate>
                </Dna:AspxTemplateField>
                <Dna:AspxTemplateField HeaderText="Fallout Date(DD/MM/YYYY)" SortExpression="FALLOUT_DATE" FilterDataField="FALLOUT_DATE" TypeCode="DateTime"
                EQUAL_TO="false"
                SMALLER_AND_EQUAL_TO="false"
                SMALLER_THAN="false"
                LIKE = "false"
                GREATER_AND_EQUAL_TO = "false"
                GREATER_THAN="false"
                >
                <ItemTemplate>
                <asp:Literal ID="FALLOUT_DATE" Text='<%# DataBinder.Eval(Container.DataItem, "FALLOUT_DATE","{0:dd/MM/yyy}")%>' runat="server"></asp:Literal>
                </ItemTemplate>
                </Dna:AspxTemplateField>
                <Dna:AspxTemplateField HeaderText="Status" SortExpression="Status" FilterDataField="Status" TypeCode="String">
                <ItemTemplate>
                <asp:Literal ID="Status" Text='<%# DataBinder.Eval(Container.DataItem, "Status")%>' runat="server"></asp:Literal>
                </ItemTemplate>
                </Dna:AspxTemplateField>
                </Columns>
                </Dna:AspxGridView >     
        
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

