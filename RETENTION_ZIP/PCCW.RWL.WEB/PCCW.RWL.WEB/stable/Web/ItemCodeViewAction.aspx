<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/RWLMenu.master" AutoEventWireup="true" CodeFile="ItemCodeViewAction.aspx.cs" Inherits="Web_ItemCodeViewAction" %>
<%@ Register Src="../UI/ProductItemCodeControlPage.ascx" TagName="ProductItemCodeControlPage" TagPrefix="uc1" %>
<%@ Register Src="../UI/ProductItemCodeControlFormPage.ascx"TagName="ProductItemCodeControlFormPage" TagPrefix="uc1" %>
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
  <script language="javascript">
      function ShowForm() {
          var ShowFormPageDiv = document.getElementById('ShowFormPageDiv');
          var ShowListRecordDiv = document.getElementById('ShowListRecordDiv');
         
          var ProductItemCodeControlFormPageTbl = document.getElementById('ProductItemCodeControlFormPageTbl');
          var ProductItemCodeControlPageTbl = document.getElementById('ProductItemCodeControlPageTbl');
          ShowFormPageDiv.style.display = "none";
          ProductItemCodeControlFormPageTbl.style.display = "inline";
          ShowListRecordDiv.style.display = "inline";
          ProductItemCodeControlPageTbl.style.display = "none";
      }

      function ShowList() {
          var ShowFormPageDiv = document.getElementById('ShowFormPageDiv');
          var ShowListRecordDiv = document.getElementById('ShowListRecordDiv');

          var ProductItemCodeControlFormPageTbl = document.getElementById('ProductItemCodeControlFormPageTbl');
          var ProductItemCodeControlPageTbl = document.getElementById('ProductItemCodeControlPageTbl');
          ShowFormPageDiv.style.display = "inline";
          ProductItemCodeControlFormPageTbl.style.display = "none";
          ShowListRecordDiv.style.display = "none";
          ProductItemCodeControlPageTbl.style.display = "inline";
      }
  </script>

  
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
              
              
              
              
              
              
              
              
              
              
      
       <table id="ProductItemCodeControlTbl" cellpadding="0" cellspacing="0" border="0">
      <tr>
      
      <td>
      <Dna:AspxButton ID="BackBut" Text="Back" PostBackUrl="~/Web/MobileRetentionMain.aspx" runat="server" />
      &nbsp;
      </td>
      
      <td>
      <div id="ShowFormPageDiv">
      <Dna:AspxButton ID="ShowFormPage" Text="Create Record" runat="server" OnClientClick="ShowForm();return false;" />
      </div>
      </td>
      
      <td>
      <div id="ShowListRecordDiv" style="display:none">
      <Dna:AspxButton ID="ShowListRecord" Text="List Out Record" runat="server" 
              OnClientClick="ShowList();" onclick="ShowListRecord_Click"  />
      </div>
      </td>
      
      </tr>
      </table>
      
      
      <br />
      <table id="ProductItemCodeControlFormPageTbl" cellpadding="0" cellspacing="0" border="0" style="display:none;">
      <tr>
      <td>
      
      
      
      <uc1:ProductItemCodeControlFormPage ID="ProductItemCodeControlFormPage" runat="server"></uc1:ProductItemCodeControlFormPage>
      </td>
      </tr>
      </table>

        
        <table id="ProductItemCodeControlPageTbl" cellpadding="0" cellspacing="0" border="0">
      <tr>
      <td>
        <uc1:ProductItemCodeControlPage ID="ProductItemCodeControlPage" runat="server" />
        </td>
      </tr>
      </table>
        
        
        
        
        
        
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

