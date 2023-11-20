<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/RWLMenu.master" AutoEventWireup="true" CodeFile="FallOutDeltailCase.aspx.cs" Inherits="Web_FallOutDeltailCase" %>
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
              <Dna:AspxButton ID="ExportExcelBut" Text="Export Excel" OnClientClick="AttachmentExport('Handler','FallOutDeltailCase'); return false;" runat="server" />
              </td>
              </tr>
              </table>
              <br />
        
            <Dna:AspxGridView ID="FallOutDeltailCaseGV" runat="server" AllowPaging="True" PageSize="25" 
                    DataKeyNames="referenceNo"  AllowSorting="True" EmptyDataText="There has no record" UseSelectCommand="false"
                    AutoGenerateColumns="False" EmptyShowHeader="true" 
                    onpageindexchanging="FallOutDeltailCaseGV_PageIndexChanging" 
                    onsorting="FallOutDeltailCaseGV_Sorting" 
                    onfiltercommand="FallOutDeltailCaseGV_FilterCommand">
            <AspxFilterSetting AllowFilter="true" />
            <PagerSettings Position="TopAndBottom" />
            <Columns>
            
            <Dna:AspxTemplateField HeaderText="Record ID" SortExpression="agree_no" >
            <ItemTemplate>
            <asp:HyperLink ID="Order_id_link" runat="server" NavigateUrl='<%#"SearchRetentionOrderViewDetail.aspx?order_id="+DataBinder.Eval(Container.DataItem, "Agree_no")%>'><%# DataBinder.Eval(Container.DataItem, "agree_no")%></asp:HyperLink>
            </ItemTemplate>
            </Dna:AspxTemplateField>
            
            <Dna:AspxTemplateField HeaderText="EDF No." SortExpression="referenceno" FilterDataField="referenceno" TypeCode="String">
            <ItemTemplate>
            <%# DataBinder.Eval(Container.DataItem, "referenceNo")%>
            </ItemTemplate>
            </Dna:AspxTemplateField>
            
            <Dna:AspxTemplateField HeaderText="Salesman ID" SortExpression="staffno" FilterDataField="staffNo" TypeCode="String">
            <ItemTemplate>
            <%# DataBinder.Eval(Container.DataItem, "staffNo")%>
            </ItemTemplate>
            </Dna:AspxTemplateField>
            
            <Dna:AspxTemplateField HeaderText="Salesman Name" SortExpression="staffName" FilterDataField="staffName" TypeCode="String">
            <ItemTemplate>
            <%# DataBinder.Eval(Container.DataItem, "staffName")%>
            </ItemTemplate>
            </Dna:AspxTemplateField>
            
            <Dna:AspxTemplateField HeaderText="Mobile No" SortExpression="mobile_no" FilterDataField="mobile_no" TypeCode="String">
            <ItemTemplate>
            <%# DataBinder.Eval(Container.DataItem, "mobile_no")%>
            </ItemTemplate>
            </Dna:AspxTemplateField>
            
            <Dna:AspxTemplateField HeaderText="Fallout Date" SortExpression="pend_date" FilterDataField="pend_date" TypeCode="DateTime" 
                EQUAL_TO="false"
                SMALLER_AND_EQUAL_TO="false"
                SMALLER_THAN="false"
                LIKE = "false"
                GREATER_AND_EQUAL_TO = "false"
                GREATER_THAN="false"
            >
            <ItemTemplate>
            <%# DataBinder.Eval(Container.DataItem, "pend_date","{0:dd/MM/yyyy}")%>
            </ItemTemplate>
            </Dna:AspxTemplateField>
            
            <Dna:AspxTemplateField HeaderText="Reason" SortExpression="fail_reason" FilterDataField="fail_reason" TypeCode="String">
            <ItemTemplate>
            <%# DataBinder.Eval(Container.DataItem, "fail_reason")%>
            </ItemTemplate>
            </Dna:AspxTemplateField>
            
            </Columns>
            </Dna:AspxGridView>
                
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

