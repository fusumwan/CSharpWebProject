<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VasViewImplement.aspx.cs" Inherits="VasViewImplement" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>

<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../Resources/Scripts/calendarDateInput.js"></script>
<script type="text/javascript" src="../Resources/Scripts/creditcard.js"></script>
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<script type="text/javascript">
function sort_by(sort_type){
		
		document.getElementById('form1').action="VasViewImplement.aspx?sort_by="+sort_type+"&view=1&order_by=1";
		//alert(document.getElementById('form1').action="VasAddRelationMapping.aspx?sort_by="+sort_type+"&view=1&order_by=1")
		document.getElementById('form1').submit();
	}
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>

    		<asp:Button ID="ExportExcel" Text="Export Excel" runat="server" CssClass="button" 
                        onclick="ExportExcel_Click" />
                  <hr />
    <asp:Label ID="ADDED_MSG" Text="ADDED" Visible="false" runat="server"></asp:Label>
    <asp:Label ID="VAS_RULE_MSG" Text = "VAS Rule is already in the list" Visible="false" runat="server"></asp:Label>
    <asp:Label ID="DELETE_MSG" Text = "Delete" Visible="false" runat="server"></asp:Label>
    
    <EW:RepeaterEx ID="vas_rp" runat="server" DataSourceID="VasViewObjectDataSource">
    <HeaderTemplate>
    <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
              <tr> 
                <td width="3%" class="row1"><input name="submit2234" type="button" class="button" value="BACK" onClick="history.go(-1);" style="font-size:7pt" /></td>
                <td width="10%" class="row1"><span class="explaintitle" style="font-size:8pt">Program</span></td>
                <td width="10%" class="row1"><span class="explaintitle" style="font-size:8pt">Rebate Type</span></td>
                <td width="10%" class="row1"><span class="explaintitle" style="font-size:8pt">Rate Plan</span></td>
                <td width="10%" class="row1"><span class="explaintitle" style="font-size:8pt">Bundle Name </span></td>
                <td width="10%" class="row1"><span class="explaintitle" style="font-size:8pt">Hs model </span></td>
                <td width="10%" class="row1"><span class="explaintitle" style="font-size:8pt">Issue Type </span></td>
                <td width="10%" class="row1"><span class="explaintitle" style="font-size:8pt">VAS </span></td>
                
                <td width="5%" class="row1"><span class="explaintitle" style="font-size:8pt">Start Date</span><span style="font-size:7pt">(DD/MM/YYYY)</span></td>
                <td width="5%" class="row1"><span class="explaintitle" style="font-size:8pt">End Date</span><span style="font-size:7pt">(DD/MM/YYYY)</span></td>
                <td width="5%" class="row1"><span class="explaintitle"> Active</span></td>
                <td width="5%" class="row1"><span class="explaintitle"> Delete</span></td>
              </tr>
    </HeaderTemplate>
    <ItemTemplate>
      <tr> 
          <td width="3%" nowrap="nowrap" class="row2"><span class="explaintitle" style="font-size:8pt"><asp:Literal ID="viewid" runat="server"></asp:Literal><asp:Literal ID="id" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "BundleMapping.id")%>' Visible="false"></asp:Literal></span></td>
          <td width="10%" nowrap="nowrap" class="row2"><span class="explaintitle" style="font-size:7pt"><a href="VasBundleMappingModify.aspx?id=<%# DataBinder.Eval(Container.DataItem, "BundleMapping.id")%>"><%# DataBinder.Eval(Container.DataItem, "BundleMapping.program")%></a></span></td>
          <td width="10%" nowrap="nowrap" class="row2"><span class="explaintitle" style="font-size:7pt"><a href="VasBundleMappingModify.aspx?id=<%# DataBinder.Eval(Container.DataItem, "BundleMapping.id")%>">
          <asp:Literal ID="normal_rebate_type" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"normal_rebate_type")%>'></asp:Literal>
          </a></span></td>
          <td width="10%" nowrap="nowrap" class="row2"><span class="explaintitle" style="font-size:9pt"><a href="VasBundleMappingModify.aspx?id=<%# DataBinder.Eval(Container.DataItem,"BundleMapping.id")%>"><%# DataBinder.Eval(Container.DataItem, "BundleMapping.rate_plan")%></a></span></td>
           <td width="10%" nowrap="nowrap" class="row2"><span class="explaintitle" style="font-size:9pt"><a href="VasBundleMappingModify.aspx?id=<%# DataBinder.Eval(Container.DataItem,"BundleMapping.id")%>">
            <asp:Literal ID="bundle_name" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"bundle_name")%>'></asp:Literal>
            </a></span></td>
            
            <td width="10%" nowrap="nowrap" class="row2"><span class="explaintitle" style="font-size:9pt"><a href="VasBundleMappingModify.aspx?id=<%# DataBinder.Eval(Container.DataItem,"BundleMapping.id")%>">
            <asp:Literal ID="hs_model" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"hs_model")%>'></asp:Literal>
            </a>
            </span>
            </td>
            <td width="10%" nowrap="nowrap" class="row2" align="center"><span class="explaintitle"><a href="VasBundleMappingModify.aspx?id=<%# DataBinder.Eval(Container.DataItem,"BundleMapping.id")%>">
                <asp:Literal ID="issue_type" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"BundleMapping.issue_type")%>'></asp:Literal>	
             </a></span></td>
             
             <td width="10%" nowrap="nowrap" class="row2" align="center"><span class="explaintitle"><a href="VasBundleMappingModify.aspx?id=<%# DataBinder.Eval(Container.DataItem,"BundleMapping.id")%>">
                <asp:Literal ID="vas_name" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"vas_name")%>'></asp:Literal>	
             </a></span></td>
             <td width="10%" nowrap="nowrap" class="row2" align="center"><span class="gensmall"><a href="VasBundleMappingModify.aspx?id=<%# DataBinder.Eval(Container.DataItem,"BundleMapping.id")%>"><asp:Literal ID="sdate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"BundleMapping.sdate", "{0:dd/MM/yyyy}")%>'></asp:Literal></a></span></td>                 
             <td width="10%" nowrap="nowrap" class="row2" align="center"><span class="gensmall"><a href="VasBundleMappingModify.aspx?id=<%# DataBinder.Eval(Container.DataItem,"BundleMapping.id")%>"><asp:Literal ID="edate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"BundleMapping.edate", "{0:dd/MM/yyyy}")%>'></asp:Literal></a></span></td>                 
             <td width="10%" nowrap="nowrap" class="row2" align="center"><span class="gensmall"><a href="VasRevisionDelete.aspx?id=<%# DataBinder.Eval(Container.DataItem,"BundleMapping.id")%>"><asp:Literal ID="Literal1" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"BundleMapping.active")%>'></asp:Literal></a>
             <td width="10%" nowrap="nowrap" class="row2" align="center"><span class="gensmall"><a href="VasRevisionDelete.aspx?id=<%# DataBinder.Eval(Container.DataItem,"BundleMapping.id")%>">X</a>
             </span>
          </td> 
     </tr>
    </ItemTemplate>
    <FooterTemplate>
    </table>
    </FooterTemplate>
    </EW:RepeaterEx>
    
    
    </div>
    <asp:ObjectDataSource ID="VasViewObjectDataSource" runat="server" 
        TypeName="PCCW.RWL.CORE.BundleMappingDAO"  SelectMethod="Find"
        onselecting="VasViewObjectDataSource_Selecting" 
        oninit="VasViewObjectDataSource_Init" >

    </asp:ObjectDataSource>
    </form>
</body>
</html>
