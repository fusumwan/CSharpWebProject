<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ConciergeServiceIMEIChange.aspx.cs" Inherits="Web_IMEIManagement_ConciergeServiceIMEIChange" %>
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
    <asp:Literal ID="NeuronJSLibrary" runat="server"></asp:Literal>
</head>
<body>
    <form id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
        <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
              <tr> 
                <th width="100%" height="28" colspan="30">&nbsp;<%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></th>
              </tr>
              <tr>
					<td height="10" class="row2"><asp:Button ID="Button1" PostBackUrl="~/Web/IMEIManagement/ManagementIMEI.aspx"  CssClass="button" Text="Back" runat="server" /></td>
					<td height="10" class="row2" align="center">&nbsp;</td>
					<td height="10" class="row2">&nbsp;</td>
		      </tr>
              <tr>
				<td height="10" class="row1" align="center"><span class="explaintitle">REMOVE IMEI RECORD:</span></td>
				<td height="10" width="33%" class="row1" align="left"> <span class="explaintitle">RECORD ID:<br />
                <asp:TextBox ID="find_record_id" CssClass="find_record_id" runat="server" Width="281px" ValidationGroup="findrecordid" ></asp:TextBox><br />
                <asp:RequiredFieldValidator ID="find_record_id_required" ValidationGroup="findrecordid" ControlToValidate="find_record_id" ErrorMessage="Please Enter Web Log Record ID Number" runat="server" Visible="true"></asp:RequiredFieldValidator>
                </span></td>
				<td height="10" width="33%" class="row1" align="center">
				<span class="explaintitle"></span>
				</td>
			  </tr>
			  <tr>
				<td height="10" class="row1" align="center"><span class="explaintitle">ASSIGN IMEI RECORD:</span></td>
				<td height="10" width="33%" class="row1" align="left"> <span class="explaintitle">RECORD ID:<br />
                <asp:TextBox ID="find_record_id2" CssClass="find_record_id2" runat="server" Width="281px" ValidationGroup="find_record_id2" ></asp:TextBox><br />
                <asp:RequiredFieldValidator ID="find_record_id2_required" ValidationGroup="findrecordid2" ControlToValidate="find_record_id2" ErrorMessage="Please Enter Web Log Record ID Number" runat="server" Visible="true"></asp:RequiredFieldValidator>
                </span></td>
				<td height="10" width="33%" class="row1" align="center">
				<span class="explaintitle"></span>
				</td>
			  </tr>
			  <tr>
			    <td height="10" class="row1" align="center"><span class="explaintitle"></span></td>
				<td height="10" width="33%" class="row1" align="left"> <span class="explaintitle">
                <asp:Button ID="updateimei" Text="Update IMEI" CssClass="button" runat="server" 
                        onclick="updateimei_Click" />
                </span></td>
				<td height="10" width="33%" class="row1" align="center">
				<span class="explaintitle"></span>
				</td>
			  </tr>
        </table>
         
    </div>
    </form>
</body>
</html>
