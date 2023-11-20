<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdateIMEI.aspx.cs" Inherits="Web_UpdateIMEI" %>

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
    function LoadMain(OuterLoad) {
        var TextUpper = function() {
            $(this).val($(this).val().toUpperCase());
        }
        this.ShowMsg = function(ObjStr) {
            alert(ObjStr);
        }
        var CheckEDF = function() {
            if (jQuery.trim($(".find_edf_no").val()) == '') { 
                $(".find_edf_no").val('');
                alert("Please enter EDF number!"); 
            }
        }
        var CheckIMEI = function() {
            if (jQuery.trim($(".update_imei_no").val()) == '') {
                $(".update_imei_no").val('');
                alert("Please enter IMEI number!");
                return false;
            }
        }
        var CheckSku = function() {
             if (jQuery.trim($(".update_sku").val()) == '') {
                $(".update_sku").val('');
                alert("Please enter item code number!");
                return false;
            }
        }
        if (OuterLoad != true) {
            $(".find_edf_no").blur(TextUpper);
            $(".find_edf_no").blur(CheckEDF);
            $(".update_imei_no").blur(TextUpper);
            $(".update_imei_no").blur(CheckIMEI);
            $(".update_sku").blur(TextUpper);
            $(".update_sku").blur(CheckSku);
            $(".UpdateAllIMEI").click(CheckIMEI);
        }
    }
    $(document).ready(LoadMain);
    
</script>
    <style type="text/css">
        .style1
        {
            width: 30%;
        }
    </style>
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
					<td align="top">
	 					 <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
						 	<tr>
								<td height="10" class="row2"><asp:Button PostBackUrl="~/Web/IMEIManagement/ManagementIMEI.aspx"  CssClass="button" Text="Back" runat="server" /></td>
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
                                    <asp:Button ID="SearchEDF" CssClass="button"  ValidationGroup="findedf"   Text="Search" runat="server"  
                                        onclick="SearchEDF_Click" /></span></td>
							</tr>
							<tr>
								<td height="10" class="row1" align="center"><span class="explaintitle">UPDATE IMEI:</span></td>
								<td height="10" width="33%" class="row1" align=left> <span class="explaintitUPDATE IMEI:</span></td>
								<td height="10" width="33%" class="row1" align="left"> <span class="explaintitle"  align="left">
                                    IMEI:<br />
                                    <asp:TextBox ID="updated_imei_no" runat="server" ValidationGroup="updateimei"  CssClass="updated_imei_no" Width="281px"></asp:TextBox>
                                    <br />
                                    <asp:RequiredFieldValidator ID="updated_imei_no_required" ValidationGroup="updateimei" ControlToValidate="updated_imei_no" ErrorMessage="Please Enter IMEI Number" runat="server" Visible="true"></asp:RequiredFieldValidator>
                                    <br />
                                    ITEM CODE:<br />
                                    <asp:TextBox ID="update_sku" runat="server" ValidationGroup="updateimei"  CssClass="update_sku" Width="281px"></asp:TextBox>
                                    <br />
                                    <asp:RequiredFieldValidator ID="update_sku_required" ValidationGroup="updateimei"  ControlToValidate="update_sku" ErrorMessage="Please Enter Item Code" runat="server" Visible="true"></asp:RequiredFieldValidator>
                                    </td>
								<td height="10" width="33%" class="row1" align="center"><span class="explaintitle">
								<asp:Button ID="UpdateAllIMEI" CssClass="button UpdateAllIMEI"  ValidationGroup="updateimei"  Text="Update"  runat="server" 
                                        onclick="UpdateAllIMEI_Click"  />
								<asp:Button ID="ResetSearch" CssClass="button"  Text="Reset Search" runat="server" 
                                        onclick="ResetSearch_Click"  />
								</span></td>
							</tr>						 
						 </table>
					</td>
				</tr>
			</table>
			<user:RetentionRecordOverView ID="RetentionRecordOverView1" runat="server" />
    </div>
    </form>
</body>
</html>
