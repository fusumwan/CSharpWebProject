<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/RWLMenu.master" AutoEventWireup="true" CodeFile="AssignNewImeiToRecord.aspx.cs" Inherits="Web_IMEIManagement_AssignNewImeiToRecord" %>
<%@ Register Src="~/UI/AssignNewImeiFormControl.ascx"TagName="AssignNewImeiFormControl" TagPrefix="uc1" %>

<%@ Register Src="~/UI/MobileManualAssignedHistoryControl.ascx" TagName="MobileManualAssignedHistoryControl" TagPrefix="uc1" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="RWLHeaderContentPlace" Runat="Server">
    <meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet" href="../../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<link href="../../Resources/Styles/RWLFormStyle.css" rel="stylesheet" type="text/css" />


  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
  <script language="javascript">
      function ShowForm() {
          var ShowFormPageDiv = document.getElementById('ShowFormPageDiv');
          var ShowListRecordDiv = document.getElementById('ShowListRecordDiv');

          var AssignNewImeiFormControlTbl = document.getElementById('AssignNewImeiFormControlTbl');
          var MobileManualAssignedHistoryControlTbl = document.getElementById('MobileManualAssignedHistoryControlTbl');
          ShowFormPageDiv.style.display = "none";
          AssignNewImeiFormControlTbl.style.display = "inline";
          ShowListRecordDiv.style.display = "inline";
          MobileManualAssignedHistoryControlTbl.style.display = "none";
      }

      function ShowList() {
          var ShowFormPageDiv = document.getElementById('ShowFormPageDiv');
          var ShowListRecordDiv = document.getElementById('ShowListRecordDiv');

          var AssignNewImeiFormControlTbl = document.getElementById('AssignNewImeiFormControlTbl');
          var MobileManualAssignedHistoryControlTbl = document.getElementById('MobileManualAssignedHistoryControlTbl');
          ShowFormPageDiv.style.display = "inline";
          AssignNewImeiFormControlTbl.style.display = "none";
          ShowListRecordDiv.style.display = "none";
          MobileManualAssignedHistoryControlTbl.style.display = "inline";
      }
  </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="RWLContentPlace" Runat="Server">
      <asp:Literal ID="NeuronJSLibrary" runat="server"></asp:Literal>
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
                  <a href="../MessageViewAction.aspx" runat="server" id="MessageViewAction">
                   <img src="../images/pc_25_01.gif" height="20" /></a>
                </td>
                </tr>
              </table>
              <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
              <tr> 
              <td>
      
      
       <table id="ProductItemCodeControlTbl" cellpadding="0" cellspacing="0" border="0">
       <tr>
      <td>
      <Dna:AspxButton ID="BackBtn" runat="server" Text="Back" PostBackUrl="ManagementIMEI.aspx" />
      &nbsp;
      </td>
      <td>
      <div id="ShowFormPageDiv" runat="server"  style="display:none">
      <Dna:AspxButton ID="ShowFormPage" Text="Assign Record" runat="server" 
              onclick="ShowFormPage_Click" />
      </div>
      <div id="ShowListRecordDiv" runat="server" >
      <Dna:AspxButton ID="ShowListRecord" Text="List Out Assign History Record" runat="server" 
               onclick="ShowListRecord_Click"  />
      </div>
      </td>
      </tr>
      </table>
      <br />
      <table id="AssignNewImeiFormControlTbl" runat="server"  cellpadding="0" cellspacing="0" border="0" >
      <tr>
      <td>

      <uc1:AssignNewImeiFormControl ID="AssignNewImeiFormControl" runat="server" />
       </td>
      </tr>
      </table>

        
      <table id="MobileManualAssignedHistoryControlTbl" runat="server"  cellpadding="0" cellspacing="0" border="0" style="display:none;">
      <tr>
      <td>
      <uc1:MobileManualAssignedHistoryControl ID="MobileManualAssignedHistoryControl" runat="server" />
      
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


