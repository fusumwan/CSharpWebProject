<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DOAIMEIManagement.aspx.cs" Inherits="Web_IMEIManagement_DOAIMEIManagement" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


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

<script type="text/javascript" language="javascript">
</script>

</head>
<body>
    <form id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
    <asp:Literal ID="NeuronJSLibrary" runat="server"></asp:Literal>
    
    <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
	 	<tr>
			<td height="10" class="row2"><asp:Button ID="Button1" PostBackUrl="~/Web/IMEIManagement/ManagementIMEI.aspx"  CssClass="button" Text="Back" runat="server" /></td>
			<td height="10" class="row2" align="center"><span class="explaintitle" style="font-size:8pt">Search record by EDF number</span></td>
			<td height="10" class="row2">&nbsp;</td>
		</tr>						 
	 	<tr>
			<td height="10" class="row1" align="center"><span class="explaintitle">SEARCH EDF:</span></td>
			<td height="10" width="33%" class="row1" align="left"> <span class="explaintitle">
                EDF:<br />
                <asp:TextBox ID="find_edf_no" CssClass="find_edf_no" runat="server" Width="281px"  ></asp:TextBox>
                <br />
                
                <asp:RequiredFieldValidator ID="find_edf_no_required" ValidationGroup="findedf" ControlToValidate="find_edf_no" ErrorMessage="Please Enter EDF Number" runat="server" Visible="true"></asp:RequiredFieldValidator>
                </span></td>
			<td height="10" width="33%" class="row1" align="center"><span class="explaintitle">
                <asp:Button ID="SearchEDF" CssClass="button"  ValidationGroup="findedf"   
                    Text="Search" runat="server" onclick="SearchEDF_Click"  
                     /></span></td>
		</tr>
	</table>
    
                <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
				<tr>
					<td align="top">
	 					 <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
	 					    <tr>
								<td height="10" class="row2" align="center" colspan="2"><span class="explaintitle" >WEB LOG</span></td>
							</tr>	
						 	<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">WEB LOG RECORD ID:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle">
								<asp:TextBox ID="rwl_record_id"  Width="300"  runat="server" Enabled="false"  ValidationGroup="updateweblog" ></asp:TextBox>
								<asp:RequiredFieldValidator ID="rwl_record_id_required" ValidationGroup="updateweblog" ControlToValidate="rwl_record_id" ErrorMessage="Please Enter Record Number" runat="server" Visible="true"></asp:RequiredFieldValidator>
								</span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">WEB LOG ORDERID:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle">
								<asp:TextBox ID="rwl_order_id"  Width="300"  runat="server" Enabled="false"  ValidationGroup="updateweblog" ></asp:TextBox>
								<asp:RequiredFieldValidator ID="rwl_order_id_required" ValidationGroup="updateweblog" ControlToValidate="rwl_order_id" ErrorMessage="Please Enter Order id Number" runat="server" Visible="true"></asp:RequiredFieldValidator>
								</span></td>
							</tr>		
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">WEB LOG EDF NUMBER:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle">
								<asp:TextBox ID="rwl_edf_no"  Width="300"  runat="server"  ValidationGroup="updateweblog" ></asp:TextBox>
								<asp:RequiredFieldValidator ID="rwl_edf_no_required" ValidationGroup="updateweblog" ControlToValidate="rwl_edf_no" ErrorMessage="Please Enter EDF Number" runat="server" Visible="true"></asp:RequiredFieldValidator>
								</span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">WEB LOG IMEI NUMBER:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle">
								<asp:TextBox ID="rwl_imei_no"  Width="300"  runat="server" ValidationGroup="updateweblog" ></asp:TextBox>
								<asp:RequiredFieldValidator ID="rwl_imei_no_required" ValidationGroup="updateweblog" ControlToValidate="rwl_imei_no" ErrorMessage="Please Enter IMEI Number" runat="server" Visible="true"></asp:RequiredFieldValidator>
								</span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">WEB LOG ITEM CODE:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle">
								<asp:TextBox ID="rwl_sku"  Width="300" runat="server" ValidationGroup="updateweblog" ></asp:TextBox>
								<asp:RequiredFieldValidator ID="rwl_sku_required" ValidationGroup="updateweblog" ControlToValidate="rwl_sku" ErrorMessage="Please Enter Item Code" runat="server" Visible="true"></asp:RequiredFieldValidator>
								</span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">WEB LOG HANDSET MODEL:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle">
								<asp:TextBox ID="rwl_hs_model"  Width="300"  runat="server" ValidationGroup="updateweblog" ></asp:TextBox>
								<asp:RequiredFieldValidator ID="rwl_hs_model_required" ValidationGroup="updateweblog" ControlToValidate="rwl_hs_model" ErrorMessage="Please Enter Handset Model Name" runat="server" Visible="true"></asp:RequiredFieldValidator>
								</span></td>
							</tr>
							<tr>
							    <td height="10" width="25%" class="row1" align="center"><span class="explaintitle"></span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle">
                                    <asp:Button ID="ButUpdateWebLogRecord" Text="Update Web Record"  ValidationGroup="updateweblog" Width="150" CssClass="button" runat="server" onclick="ButUpdateWebLogRecord_Click"  /></span></td>
							</tr>
						 </table>
					</td>
				</tr>
			</table>
			<table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
				<tr>
					<td align="top">
	 					 <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
						 	<tr>
								<td height="10" class="row2" align="center" colspan="2"><span class="explaintitle" style="font-size:8pt">EDF FORM</span></td>
							</tr>
						 	<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">EDF RECORID:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle">
								<asp:TextBox ID="edf_record_id"  Width="300"  runat="server" ValidationGroup="updateedf" ></asp:TextBox>
								<asp:RequiredFieldValidator ID="edf_record_id_required" ValidationGroup="updateedf" ControlToValidate="edf_record_id" ErrorMessage="Please Enter Record Id" runat="server" Visible="true"></asp:RequiredFieldValidator>
								</span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">EDF EDF NUMBER:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle">
								<asp:TextBox ID="edf_edf_no"  Width="300"  runat="server"></asp:TextBox>
								<asp:RequiredFieldValidator ID="edf_edf_no_required" ValidationGroup="updateedf" ControlToValidate="edf_edf_no" ErrorMessage="Please Enter EDF Number" runat="server" Visible="true"></asp:RequiredFieldValidator>
								</span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">EDF IMEI NUMBER:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle">
								<asp:TextBox ID="edf_imei_no"  Width="300"  runat="server"></asp:TextBox>
								<asp:RequiredFieldValidator ID="edf_imei_no_required" ValidationGroup="updateedf" ControlToValidate="edf_imei_no" ErrorMessage="Please Enter IMEI Number" runat="server" Visible="true"></asp:RequiredFieldValidator>
								</span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">EDF ITEM CODE:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle">
								<asp:TextBox ID="edf_sku"  Width="300"  runat="server" ValidationGroup="updateedf" ></asp:TextBox>
								<asp:RequiredFieldValidator ID="edf_sku_required" ValidationGroup="updateedf" ControlToValidate="edf_sku" ErrorMessage="Please Enter Item Code" runat="server" Visible="true"></asp:RequiredFieldValidator>
								</span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">EDF HANDSET MODEL:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle">
								<asp:TextBox ID="edf_hs_model"  Width="300"  runat="server" ValidationGroup="updateedf" ></asp:TextBox>
								<asp:RequiredFieldValidator ID="edf_hs_model_required" ValidationGroup="updateedf" ControlToValidate="edf_hs_model" ErrorMessage="Please Enter Handset Model" runat="server" Visible="true"></asp:RequiredFieldValidator>
								</span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">EDF REMARK:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle">
								<asp:TextBox ID="edf_remark"  Width="300"  runat="server" ValidationGroup="updateedf" ></asp:TextBox>
								</span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">EDF DN REMARK:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle">
								<asp:TextBox ID="edf_dn_remark"  Width="300"  runat="server" ValidationGroup="updateedf" ></asp:TextBox>
								</span></td>
							</tr>
							<tr>
							    <td height="10" width="25%" class="row1" align="center"><span class="explaintitle"></span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle">
                                 <asp:Button ID="ButUpdateEdfRecord" Text="Update EDF Record" Width="150"  ValidationGroup="updateedf" CssClass="button" runat="server" onclick="ButUpdateEdfRecord_Click" /></span></td>
							</tr>
						 </table>
					</td>
				</tr>
			</table>
			<table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
				<tr>
					<td align="top">
	 					 <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
						 	<tr>
								<td height="10" class="row2" align="center" colspan="2"><span class="explaintitle" style="font-size:8pt">IMEI STOCK</span></td>
							</tr>						 
						 	<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">IMEI STOCK RECORID:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle">
								<asp:TextBox ID="imei_record_id"  Width="300"   runat="server" ValidationGroup="updateimei" ></asp:TextBox>
								<asp:RequiredFieldValidator ID="imei_record_id_required" ValidationGroup="updateimei" ControlToValidate="imei_record_id" ErrorMessage="Please Enter Record Id" runat="server" Visible="true"></asp:RequiredFieldValidator>
								</span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">IMEI STOCK EDF NUMBER:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle">
								<asp:TextBox ID="imei_edf_no"  Width="300"  runat="server" ValidationGroup="updateimei" ></asp:TextBox>
								<asp:RequiredFieldValidator ID="imei_edf_no_required" ValidationGroup="updateimei" ControlToValidate="imei_edf_no" ErrorMessage="Please Enter EDF Number" runat="server" Visible="true"></asp:RequiredFieldValidator>
								</span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">IMEI STOCK IMEI NUMBER:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle">
								<asp:TextBox ID="imei_imei_no"  Width="300"   runat="server" ValidationGroup="updateimei" ></asp:TextBox>
								<asp:RequiredFieldValidator ID="imei_imei_no_required" ValidationGroup="updateimei" ControlToValidate="imei_imei_no" ErrorMessage="Please Enter IMEI Number" runat="server" Visible="true"></asp:RequiredFieldValidator>
								</span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">IMEI STOCK STATUS:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle">
								<asp:TextBox ID="imei_status"  Width="300"  runat="server" ValidationGroup="updateimei" ></asp:TextBox>
								<asp:RequiredFieldValidator ID="imei_status_required" ValidationGroup="updateimei" ControlToValidate="imei_status" ErrorMessage="Please Enter IMEI Status" runat="server" Visible="true"></asp:RequiredFieldValidator>
								</span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">IMEI STOCK ITEM CODE:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle">
								<asp:TextBox ID="imei_sku"  Width="300"  runat="server" ValidationGroup="updateimei" ></asp:TextBox>
								<asp:RequiredFieldValidator ID="imei_sku_required" ValidationGroup="updateimei" ControlToValidate="imei_sku" ErrorMessage="Please Enter Item Code" runat="server" Visible="true"></asp:RequiredFieldValidator>
								</span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">IMEI STOCK HANDSET MODEL:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle">
								<asp:TextBox ID="imei_hs_model"  Width="300"  runat="server" ValidationGroup="updateimei" ></asp:TextBox>
								<asp:RequiredFieldValidator ID="imei_hs_model_required" ValidationGroup="updateimei" ControlToValidate="imei_hs_model" ErrorMessage="Please Enter Handset Model" runat="server" Visible="true"></asp:RequiredFieldValidator>
								</span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">IMEI STOCK REMARK:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle">
								<asp:TextBox ID="imei_remark" Width="300" runat="server"></asp:TextBox>
								</span></td>
							</tr>
							<tr>
							    <td height="10" width="25%" class="row1" align="center"><span class="explaintitle"></span></td>
								<td height="10" width="75%" class="row1" align="center">
								<span class="explaintitle">
								<asp:Button ID="ButUpdateImeiRecord" Text="Update IMEI Record" Width="150" runat="server" ValidationGroup="updateimei"  CssClass="button" onclick="ButUpdateImeiRecord_Click" />
								</span>
								</td>
							</tr>
						 </table>
					</td>
				</tr>
			</table>
    <table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="../MobileRetentionMain.aspx">Main Page</a> &raquo; View 
<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
</table>   
    </div>
    </form>
</body>
</html>
