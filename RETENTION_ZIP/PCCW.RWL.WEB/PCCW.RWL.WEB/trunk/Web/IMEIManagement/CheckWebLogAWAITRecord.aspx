<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CheckWebLogAWAITRecord.aspx.cs" Inherits="Web_IMEIManagement_CheckWebLogAWAITRecord" %>

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
                <th width="100%" height="28" colspan="30">&nbsp;<%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></th>
              </tr>
              
              <tr>
					<td height="10" class="row2"><asp:Button ID="Button1" PostBackUrl="~/Web/IMEIManagement/ManagementIMEI.aspx"  CssClass="button" Text="Back" runat="server" /></td>
					<td height="10" class="row2" align="center"><span class="explaintitle" style="font-size:8pt">Search web log await record by record id number</span></td>
					<td height="10" class="row2">&nbsp;</td>
		      </tr>
		      
              <tr>
				<td height="10" class="row1" align="center"><span class="explaintitle">SEARCH WEB AWAIT RECORD:</span></td>
				<td height="10" width="33%" class="row1" align="left"> <span class="explaintitle">RECORD ID:<br />
                <asp:TextBox ID="find_record_id" CssClass="find_record_id" runat="server" Width="281px" ValidationGroup="findrecordid" ></asp:TextBox><br />
                <asp:RequiredFieldValidator ID="find_record_id_required" ValidationGroup="findrecordid" ControlToValidate="find_record_id" ErrorMessage="Please Enter Web Log Record ID Number" runat="server" Visible="true"></asp:RequiredFieldValidator>
                </span></td>
				<td height="10" width="33%" class="row1" align="center">
				<span class="explaintitle">
				<asp:Button ID="SearchWebLog" CssClass="button"  ValidationGroup="findrecordid"   
                        Text="Search" runat="server" onclick="SearchWebLog_Click"  /></span>
				</td>
			  </tr>
               </table>

              <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
				<tr>
					<td align="top">
	 					 <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
	 					    <tr>
								<td height="10" class="row2" align="center" colspan="2"><span class="explaintitle" style="font-size:8pt">WEB LOG</span></td>
							</tr>	
						 	<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle" style="font-size:8pt">WEB LOG RECORD ID:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle"><asp:Label ID="rwl_record_id"  runat="server"></asp:Label></span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">WEB LOG ORDERID:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle"><asp:Label ID="rwl_order_id"  runat="server"></asp:Label></span></td>
							</tr>		
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">WEB LOG EDF NUMBER:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle"><asp:Label ID="rwl_edf_no"  runat="server"></asp:Label></span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">WEB LOG IMEI NUMBER:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle"><asp:Label ID="rwl_imei_no"  runat="server"></asp:Label></span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">WEB LOG ITEM CODE:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle"><asp:Label ID="rwl_sku"  runat="server"></asp:Label></span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">WEB LOG HANDSET MODEL:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle"><asp:Label ID="rwl_hs_model"  runat="server"></asp:Label></span></td>
							</tr>
							<tr>
							    <td height="10" width="25%" class="row1" align="center"><span class="explaintitle">
                                    <asp:Button ID="but_InsertAwaitCase" runat="server" Text="Insert Await Case" 
                                        Enabled="false" CssClass="button" onclick="but_InsertAwaitCase_Click" /></span></td>
								<td height="10" width="75%" class="row1" align="center"><span class="explaintitle"></span></td>
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
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle"><asp:Label ID="edf_record_id"  runat="server"></asp:Label></span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">EDF EDF NUMBER:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle"><asp:Label ID="edf_edf_no"  runat="server"></asp:Label></span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">EDF IMEI NUMBER:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle"><asp:Label ID="edf_imei_no"  runat="server"></asp:Label></span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">EDF ITEM CODE:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle"><asp:Label ID="edf_sku"  runat="server"></asp:Label></span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">EDF HANDSET MODEL:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle"><asp:Label ID="edf_hs_model"  runat="server"></asp:Label></span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">EDF EXPECTED DELIVERY :</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle"><asp:Label ID="edf_expect_delivery"  runat="server"></asp:Label></span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">EDF ACTURAL DELIVERY:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle"><asp:Label ID="edf_actural_delivery"  runat="server"></asp:Label></span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">EDF REMARK:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle"><asp:Label ID="edf_remark"  runat="server"></asp:Label></span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">EDF DN REMARK:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle"><asp:Label ID="edf_dn_remark"  runat="server"></asp:Label></span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">
                                    <asp:Button ID="but_InsertEDFRecord" text="Insert Edf Record" CssClass="button" 
                                        runat="server" onclick="but_InsertEDFRecord_Click" /></span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle"></span></td>
							</tr>
						 </table>
					</td>
				</tr>
			</table>
<table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
	 					    <tr>
								<td height="10" class="row2" align="center" colspan="2"><span class="explaintitle" style="font-size:8pt">IMEI RECORD</span></td>
							</tr>	
<tr><td>


<asp:GridView ID="IMEISTOCKGW" runat="server"  
        AutoGenerateColumns="False" CssClass="table-report" DataKeyNames="REFERENCENO"
          
        EmptyDataText="There has no IMEI record assigned for this web log record"  OnRowEditing="IMEISTOCKGW_RowEditing"   
        Font-Size="12px" 
         onrowdeleting="IMEISTOCKGW_RowDeleting" 
        onrowupdating="IMEISTOCKGW_RowUpdating" 
        onrowcancelingedit="IMEISTOCKGW_RowCancelingEdit" >
          
<Columns>
<asp:TemplateField>
<ItemTemplate>
<asp:Button ID="But_Edit" runat="server" Text="EDIT" CssClass="button" CommandName="Edit" />
<asp:Button ID="But_Delete" runat="server" Text="DELETE" CssClass="button" CommandName = "Delete" />
</ItemTemplate>
<EditItemTemplate>
<asp:Button ID="But_Update" runat="server" Text="UPDATE" ValidationGroup="gw" CssClass="button" CommandName="Update" />
<asp:Button ID="But_Cancel" runat="server" Text="CANCEL" CssClass="button" CommandName="Cancel" />
</EditItemTemplate>
</asp:TemplateField>

<asp:TemplateField HeaderText="REFERECE NO.">
<ItemTemplate>
<asp:Label CssClass="explaintitle" ID="referenceno" runat="server" Text='<%# Eval("REFERENCENO") %>'></asp:Label>
</ItemTemplate>
<EditItemTemplate>
<asp:Label CssClass="explaintitle" ID="referenceno" runat="server" Text='<%# Bind(Container.DataItem,"REFERENCENO") %>'></asp:Label>
</EditItemTemplate>
</asp:TemplateField>

<asp:TemplateField HeaderText="IMEI.">
<ItemTemplate>
<asp:Label CssClass="explaintitle" ID="imei" runat="server" Text='<%# Eval("IMEI") %>'></asp:Label>
</ItemTemplate>
<EditItemTemplate>
<asp:Label CssClass="explaintitle" ID="imei" runat="server" Text='<%# Bind(Container.DataItem,"IMEI") %>'></asp:Label>
</EditItemTemplate>
</asp:TemplateField>

<asp:TemplateField HeaderText="CREATE BY">
<ItemTemplate>
<asp:Label CssClass="explaintitle" ID="create_by" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"CREATE_BY") %>'></asp:Label>
</ItemTemplate>
<EditItemTemplate>
<asp:TextBox CssClass="explaintitle" ID="create_by" ValidationGroup="gw" runat="server" Text='<%# Bind(Container.DataItem,"CREATE_BY") %>'></asp:TextBox>
<asp:RequiredFieldValidator Enabled=false ID="create_by_required" ValidationGroup="gw" ControlToValidate="create_by" ErrorMessage="Please Enter Uid" runat="server" Visible="true"></asp:RequiredFieldValidator>
</EditItemTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText="MODEL">
<ItemTemplate>
<asp:Label CssClass="explaintitle" ID="model" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"MODEL") %>'></asp:Label>
</ItemTemplate>
<EditItemTemplate>
<asp:Label CssClass="explaintitle" ID="model" runat="server" Text='<%# Bind(Container.DataItem,"MODEL") %>'></asp:Label>
</EditItemTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText="ITEM CODE">
<ItemTemplate>
<asp:Label CssClass="explaintitle" ID="kit_code" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"KIT_CODE") %>'></asp:Label>
</ItemTemplate>
<EditItemTemplate>
<asp:Label CssClass="explaintitle" ID="kit_code" runat="server" Text='<%# Bind(Container.DataItem,"KIT_CODE") %>'></asp:Label>
</EditItemTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText="RECORD ID">
<ItemTemplate>
<asp:Label CssClass="explaintitle" ID="DUMMY4" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"DUMMY4") %>'></asp:Label>
</ItemTemplate>
<EditItemTemplate>
<asp:TextBox ID="DUMMY4" runat="server" Text='<%# Bind(Container.DataItem,"DUMMY4") %>'></asp:TextBox>
<asp:RequiredFieldValidator Enabled="false" ID="record_id_required" ValidationGroup="gw" ControlToValidate="DUMMY4" ErrorMessage="Please Enter Record ID" runat="server" Visible="true"></asp:RequiredFieldValidator>
</EditItemTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText="IMEI STATUS">
<ItemTemplate>
<asp:Label CssClass="explaintitle" ID="status" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"STATUS") %>'></asp:Label>
</ItemTemplate>
<EditItemTemplate>
<asp:Label CssClass="explaintitle" ID="status" runat="server" Text='<%# Bind(Container.DataItem,"STATUS") %>'></asp:Label>
</EditItemTemplate>
</asp:TemplateField>

</Columns>
</asp:GridView>              
              
              </td>
              </tr>
              </table>
              
    </div>
    </form>
</body>
</html>
