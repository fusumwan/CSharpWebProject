<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ManagementIMEI.aspx.cs" Inherits="Web_ManagementIMEI" %>

<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<%@ Register Src="../../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit.HTMLEditor" tagprefix="cc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<head id="Head1" runat="server">
<title>3G Retention - Web Log</title>       
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>

<link rel="stylesheet"  href="../../Resources/Styles/global.css" type="text/css" />
<link rel="stylesheet" href="../../Resources/Styles/MainPageStyle.css" type="text/css" />
<script language="javascript">
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
    <asp:Literal ID="NeuronJSLibrary" runat="server"></asp:Literal>
        <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
				<tr>
					<td align="top">
	 					 <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
						 	<tr>
								<td height="10" class="row2">&nbsp;</td>
								<td height="10" class="row2" align="center"><span class="explaintitle" style="font-size:8pt">IMEI MANAGEMENT</span></td>
								<td height="10" class="row2">&nbsp;</td>
							</tr>						 
						 	<tr>
								<td height="10" width="33%" class="row1" align="center"><span class="explaintitle"><asp:HyperLink ID="IMEIManagementTool" NavigateUrl="~/Web/IMEIManagement/IMEIManagementTool.aspx" Text="IMEI Management Tool" runat="server"></asp:HyperLink> </span></td>
								<td height="10" width="33%" class="row1" align="center"><span class="explaintitle"><asp:HyperLink ID="CheckWebLogAORecord" NavigateUrl="~/Web/IMEIManagement/CheckWebLogAORecord.aspx" Text="Check AO Record" runat="server"></asp:HyperLink></span></td>
								<td height="10" width="33%" class="row1" align="center"><span class="explaintitle"><asp:HyperLink ID="CheckWebLogAWAITRecord" NavigateUrl="~/Web/IMEIManagement/CheckWebLogAWAITRecord.aspx" Text="Check AWAIT Record" runat="server"></asp:HyperLink></span></td>
							</tr>
							<tr>
								<td height="10" width="33%" class="row1" align="center"><span class="explaintitle"><asp:HyperLink ID="AssignIMEILIST" NavigateUrl="~/Web/IMEIManagement/AssignIMEILIST.aspx" Text="Assign IMEI List" runat="server"></asp:HyperLink></span></td>
								<td height="10" width="33%" class="row1" align="center"><span class="explaintitle"><asp:HyperLink ID="UpdateOrderToEDF" NavigateUrl="~/Web/IMEIManagement/UpdateOrderToEDF.aspx" Text="Update Order To EDF" runat="server"></asp:HyperLink></span></td>
								<td height="10" width="33%" class="row1" align="center"><span class="explaintitle"><asp:HyperLink ID="UpdateOrderToEDFByBatch" NavigateUrl="~/Web/IMEIManagement/UpdateOrderToEDFByBatch.aspx" Text="Batch Update Order To EDF" runat="server"></asp:HyperLink></span></td>
							</tr>		
							<tr>
								<td height="10" width="33%" class="row1" align="center"><span class="explaintitle"><asp:HyperLink ID="AssignNewImeiToRecord" NavigateUrl="~/Web/IMEIManagement/AssignNewImeiToRecord.aspx" Text="Assign New IMEI To Order Record" runat="server"></asp:HyperLink></span></td>
								<td height="10" width="33%" class="row1" align="center"><span class="explaintitle"><asp:HyperLink ID="HyperLink1" NavigateUrl="~/Web/IMEIManagement/RwlImeiUpdate.aspx" Text="Update RWL IMEI Record" runat="server"></asp:HyperLink></span></td>
								<td height="10" width="33%" class="row1" align="center">&nbsp;</td>
							</tr>					 
						 </table>
					</td>
				</tr>
			</table>
    </div>
    </form>
</body>
</html>
