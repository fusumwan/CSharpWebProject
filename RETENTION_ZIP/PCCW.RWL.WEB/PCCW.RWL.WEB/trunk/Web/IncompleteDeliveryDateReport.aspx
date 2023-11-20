<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/RWLMenu.master" AutoEventWireup="true" CodeFile="IncompleteDeliveryDateReport.aspx.cs" Inherits="Web_IncompleteDeliveryDateReport" %>

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
                  <td class="nav">Main Page » &nbsp;</td>
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
              </tr>
              </table>



            <br />



              <Dna:AspxGridView ID="SearchResultGw"  runat="server" AutoGenerateColumns="False"  Width="1200" 
               DataKeyNames="RecordId" 
              EmptyDataText=" Sorry! No Incomplete Delivery Data Offer."   >
              <PagerSettings Position="TopAndBottom" />

            <Columns>
            
            <Dna:AspxTemplateField HeaderText="ORDER ID" FilterDataField="RecordId" TypeCode="String" >
            <ItemTemplate>
            <asp:LinkButton runat="server" ID="AGREE_NO" PostBackUrl='<%# String.Format("./SearchRetentionOrderViewDetail.aspx?order_id={0}", DataBinder.Eval(Container.DataItem,"RecordId")) %>' Text='<%# DataBinder.Eval(Container.DataItem,"Orderid") %>'></asp:LinkButton>
            </ItemTemplate>
            </Dna:AspxTemplateField>
            
            
            <Dna:AspxTemplateField HeaderText="MRT" FilterDataField="Mrt_no" TypeCode="String" >
            <ItemTemplate>
            <asp:Label ID="MOBILE_NO" Text='<%# DataBinder.Eval(Container.DataItem,"Mrt_no") %>'  runat="server"></asp:Label>
            </ItemTemplate>
            </Dna:AspxTemplateField>
            
            <Dna:AspxTemplateField HeaderText="EDF No"  FilterDataField="Referenceno" TypeCode="String" >
            <ItemTemplate>
            <asp:Label ID="REFERENCENO" Text='<%# DataBinder.Eval(Container.DataItem,"Referenceno") %>' runat="server"></asp:Label>
            </ItemTemplate>
            </Dna:AspxTemplateField>
            
            <Dna:AspxTemplateField HeaderText="Sku"  FilterDataField="Sku" TypeCode="String" >
            <ItemTemplate>
            <asp:Label ID="ITEMCODE" Text='<%# DataBinder.Eval(Container.DataItem,"Sku") %>' runat="server"></asp:Label>
            </ItemTemplate>
            </Dna:AspxTemplateField>

            <Dna:AspxTemplateField HeaderText="HS Model"   FilterDataField="Hs_model" TypeCode="String" >
            <ItemTemplate>
            <asp:Label ID="HANDSET" Text='<%# DataBinder.Eval(Container.DataItem,"Hs_model") %>' runat="server"></asp:Label>
            </ItemTemplate>
            </Dna:AspxTemplateField>
            
            <Dna:AspxTemplateField HeaderText="Salesman ID"   FilterDataField="Staff_no" TypeCode="String" >
            <ItemTemplate>
            <asp:Label ID="STAFFNO" Text='<%# DataBinder.Eval(Container.DataItem,"Staff_no") %>' runat="server"></asp:Label>
            </ItemTemplate>
            </Dna:AspxTemplateField>
            
            <Dna:AspxTemplateField HeaderText="Salesman Code"   FilterDataField="Salesmancode" TypeCode="String" >
            <ItemTemplate>
            <asp:Label ID="SALESMANCODE" Text='<%# DataBinder.Eval(Container.DataItem,"Salesmancode") %>' runat="server"></asp:Label>
            </ItemTemplate>
            </Dna:AspxTemplateField>
            
            <Dna:AspxTemplateField HeaderText="Salesman Channel"    FilterDataField="Channel" TypeCode="String" >
            <ItemTemplate>
            <asp:Label ID="SALES_CHANNEL" Text='<%# DataBinder.Eval(Container.DataItem,"Channel") %>' runat="server"></asp:Label>
            </ItemTemplate>
            </Dna:AspxTemplateField>
            
            <Dna:AspxTemplateField HeaderText="Expected Delivery Date"   FilterDataField="D_date" TypeCode="DateTime" FilterDataFormatString="dd/MM/yyyy" 
            EQUAL_TO="false"
                SMALLER_AND_EQUAL_TO="false"
                SMALLER_THAN="false"
                LIKE = "false"
                GREATER_AND_EQUAL_TO = "false"
                GREATER_THAN="false"
            >
            <ItemTemplate>
            <asp:Label ID="E_DELIVERY_DATE" Text='<%# DataBinder.Eval(Container.DataItem,"D_date") %>' runat="server"></asp:Label>
            </ItemTemplate>
            </Dna:AspxTemplateField>
            
            <Dna:AspxTemplateField HeaderText="Pass Date"   FilterDataField="PassDate" TypeCode="DateTime"  FilterDataFormatString="dd/MM/yyyy" 
            EQUAL_TO="false"
                SMALLER_AND_EQUAL_TO="false"
                SMALLER_THAN="false"
                LIKE = "false"
                GREATER_AND_EQUAL_TO = "false"
                GREATER_THAN="false"
             >
            <ItemTemplate>
            <asp:Label ID="PASS_DATE" Text='<%# DataBinder.Eval(Container.DataItem,"PassDate") %>' runat="server"></asp:Label>
            </ItemTemplate>
            </Dna:AspxTemplateField>
            
            <Dna:AspxTemplateField HeaderText="Force To Cancel"   FilterDataField="Cancelled" TypeCode="String"  >
            <ItemTemplate>
            <asp:Label ID="CANCELLED" Text='<%# DataBinder.Eval(Container.DataItem,"Cancelled") %>' runat="server"></asp:Label>
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



