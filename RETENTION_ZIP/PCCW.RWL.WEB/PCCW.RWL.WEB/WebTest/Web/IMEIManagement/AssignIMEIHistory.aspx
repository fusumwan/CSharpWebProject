<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/RWLMenu.master" AutoEventWireup="true" CodeFile="AssignIMEIHistory.aspx.cs" Inherits="Web_IMEIManagement_AssignIMEIHistory" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="RWLHeaderContentPlace" Runat="Server">
    <meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet" href="../../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
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
                  <a href="../MessageViewAction.aspx" runat="server" id="MessageViewAction">
                    <img src="../images/pc_25_01.gif" height="20" /></a>
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
              <Dna:AspxButton ID="BackBut" Text="Back" PostBackUrl="AssignIMEILIST.aspx" runat="server" />
              </td>
              <td>&nbsp;</td>
              <td>
              <Dna:AspxButton ID="ExportExcelBut" Text="Export Excel" OnClientClick="AttachmentExport('Handler','MobileAssignListHistory'); return false;" runat="server" />
              </td>
              </tr>
              </table>
              <br />
     
                 <Dna:AspxGridView 
                    ID="MobileAssignListHistoryGV" 
                    runat="server" AllowPaging="True" 
                    AllowSorting="True" PageSize="20"  
                    AutoGenerateColumns="False"
                    EmptyShowHeader="true" 
                    DataKeyNames="mid" DataSourceID="MobileAssignListHistoryObj" 
                      oninit="MobileAssignListHistoryGV_Init">
               <PagerSettings Position="TopAndBottom" />
                 <AspxFilterSetting AllowFilter="true" />
               <Columns>
                   <Dna:AspxTemplateField Visible="false">
                   <ItemTemplate>
                   <asp:Literal ID="mid" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"mid") %>'></asp:Literal>
                   </ItemTemplate>
                   </Dna:AspxTemplateField>
                   
                   <Dna:AspxTemplateField Visible="false">
                   <ItemTemplate>
                   <asp:Literal ID="order_id" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"order_id") %>'></asp:Literal>
                   </ItemTemplate>
                   </Dna:AspxTemplateField>
                   
                   <Dna:AspxTemplateField FilterDataField="edf_no" TypeCode="String" Visible="true" HeaderText='EDF NO.' SortExpression="edf_no">
                   <ItemTemplate>
                   <asp:Literal ID="edf_no" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"edf_no") %>'></asp:Literal>
                   </ItemTemplate>
                   </Dna:AspxTemplateField>

                   <Dna:AspxTemplateField  FilterDataField="record_id" TypeCode="String" Visible="true" HeaderText='RECORD ID' SortExpression="record_id">
                   <ItemTemplate>
                   <asp:Literal ID="record_id" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"record_id") %>'></asp:Literal>
                   </ItemTemplate>
                   </Dna:AspxTemplateField>
                   
                   <Dna:AspxTemplateField FilterDataField="hs_model" TypeCode="String"  Visible="true" HeaderText='HS MODEL' SortExpression="hs_model">
                   <ItemTemplate>
                   <asp:Literal ID="hs_model" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"hs_model") %>'></asp:Literal>
                   </ItemTemplate>
                   </Dna:AspxTemplateField>
                   
                   <Dna:AspxTemplateField  FilterDataField="d_date" TypeCode="DateTime" FilterDataFormatString="dd/MM/yyyy" Visible="true" HeaderText='DELIVERY DATE' SortExpression="d_date">
                   <ItemTemplate>
                   <asp:Literal ID="d_date" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"d_date","{0:dd/MM/yyyy HH:mm:ss}") %>'></asp:Literal>
                   </ItemTemplate>
                   </Dna:AspxTemplateField>
                   
                   <Dna:AspxTemplateField  FilterDataField="imei_no" TypeCode="String" Visible="true" HeaderText='IMEI NO.' SortExpression="imei_no">
                   <ItemTemplate>
                   <asp:Literal ID="imei_no" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"imei_no") %>'></asp:Literal>
                   </ItemTemplate>
                   </Dna:AspxTemplateField>
                   
                   
                   <Dna:AspxTemplateField  FilterDataField="uid" TypeCode="String" Visible="true" HeaderText='STAFF NO.' SortExpression="uid">
                   <ItemTemplate>
                   <asp:Literal ID="uid" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"uid") %>'></asp:Literal>
                   </ItemTemplate>
                   </Dna:AspxTemplateField>
                   
                   
                   <Dna:AspxTemplateField  FilterDataField="cdate" TypeCode="DateTime" Visible="true" HeaderText='CREATE DATE' SortExpression="cdate">
                   <ItemTemplate>
                   <asp:Literal ID="cdate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"cdate","{0:dd/MM/yyyy HH:mm:ss}") %>'></asp:Literal>
                   </ItemTemplate>
                   </Dna:AspxTemplateField>
                   
                   <asp:CheckBoxField DataField="active" HeaderText="Active" ></asp:CheckBoxField>

               </Columns>
           </Dna:AspxGridView>
       <br />
           <asp:SqlDataSource ID="MobileAssignListHistoryObj" runat="server" 
               ConnectionString="<%$ ConnectionStrings:MobileRetentionOrderDB2 %>" 
               SelectCommand="SELECT * FROM [MobileAssignListHistory]" 
               oninit="MobileAssignListHistoryObj_Init" >
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




