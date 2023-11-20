<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EDFmanagement.aspx.cs" Inherits="EDFmanagement" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<meta http-equiv="Content-Style-Type" content="text/css" />

<title>3G Fallout Log Sales Reply</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>

</head>
<body>

    <form id="form1" runat="server">
    <div>
    <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <th height="28" colspan="4">EDF Status Details </th>
                </tr>
                <tr> 
                  <td height="23" colspan="4" class="row2"> <span class="explaintitle"> 
                    </span></td>
                </tr>
                <asp:Panel ID="edf_status_placeholder" runat="server" Visible=false>
                <tr> 
                  <td width="25%" class="row1"><span class="explaintitle">Print by Order Team</span></td>
                  <td width="25%" class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="issue" runat="server"></asp:Literal></span></td>
                  <td width="25%" class="row1"><span class="explaintitle">Date 
                    </span></td>
                  <td width="25%" class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="issue_date" runat="server"></asp:Literal></span></td>
                </tr>
                <tr> 
                  <td class="row1"><span class="explaintitle">Document Receive</span></td>
                  <td class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="doc_receive" runat="server"></asp:Literal></span></td>
                  <td class="row1"><span class="explaintitle">Date </span></td>
                  <td class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="doc_r_date" runat="server"></asp:Literal></span></td>
                </tr>

		<tr> 
                  <td class="row1"><span class="explaintitle">Assign Staff No</span></td>
                  <td class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="assign_sn" runat="server"></asp:Literal></span></td>
                  <td class="row1"><span class="explaintitle">Date </span></td>
                  <td class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="assign_date" runat="server"></asp:Literal></span></td>
                </tr>
		<tr> 
                  <td class="row1"><span class="explaintitle">&nbsp;</span></td>
                  <td class="row2"><span class="gensmall" style="font-size:7pt"></span></td>
                  <td class="row1"><span class="explaintitle">Assign Name</span></td>
                  <td class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="assign_name" runat="server"></asp:Literal></span></td>
                </tr>
		<tr> 
                  <td class="row1"><span class="explaintitle">Fallout To Sales</span></td>
                  <td class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="fo_to_sales" runat="server"></asp:Literal></span></td>
                  <td class="row1"><span class="explaintitle">Date</span></td>
                  <td class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="fo_date" runat="server"></asp:Literal></span></td>
                </tr>
		<tr> 
                  <td class="row1"><span class="explaintitle">Fallout Status</span></td>
                  <td class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="fallout_status" runat="server"></asp:Literal></span></td>
                  <td class="row1"><span class="explaintitle">Date</span></td>
                  <td class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="fallout_status_date" runat="server"></asp:Literal></span></td>
                </tr>
                <tr> 
                  <td class="row1"><span class="explaintitle">Payment Status</span></td>
                  <td class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="payment_status" runat="server"></asp:Literal></span></td>
                  <td class="row1"><span class="explaintitle">Payment Status Date</span></td>
                  <td class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="payment_status_date" runat="server"></asp:Literal></span></td>
                </tr>
                <tr> 
                  <td class="row1"><span class="explaintitle">BOSS Issued </span></td>
                  <td class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="create_s" runat="server"></asp:Literal></span></td>
                  <td class="row1"><span class="explaintitle">Date </span></td>
                  <td class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="create_s_date" runat="server"></asp:Literal></span></td>
                </tr>
                <tr> 
                  <td class="row1"><span class="explaintitle">Actual Delivery 
                    Date </span></td>
                  <td class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="actual_del_date" runat="server"></asp:Literal></span></td>
                  <td class="row1"><span class="explaintitle">Print Delivery Note</span></td>
                  <td class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="print_delivery" runat="server"></asp:Literal></span></td>
                </tr>

		</table>
	       <br><br>

		  <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <th height="28" colspan="4">EDF Back End Status Details </th>
                </tr>
                
                
                <tr> 
                  <td class="row1" width="25%"><span class="explaintitle">To PLG</span></td>
                  <td class="row2" width="25%"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="to_plg" runat="server"></asp:Literal></span></td>
                  <td class="row1" width="25%"><span class="explaintitle">Date </span></td>	
                  <td class="row2" width="25%"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="to_plg_date" runat="server"></asp:Literal></span></td>
                </tr>
                <tr> 
                  <td class="row1"><span class="explaintitle">BOSS Activated</span></td>
                  <td class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="activated" runat="server"></asp:Literal></span></td>
                  <td class="row1"><span class="explaintitle">Date </span></td>
                  <td class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="activated_date" runat="server"></asp:Literal></span></td>
                </tr>
                <tr> 
                  <td class="row1"><span class="explaintitle">Failed Delivery</span></td>
                  <td class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="pending" runat="server"></asp:Literal></span></td>
                  <td class="row1"><span class="explaintitle">Date</span></td>
                  <td class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="pend_date" runat="server"></asp:Literal></span></td>
                </tr>
                <tr> 
                  <td class="row1"><span class="explaintitle">Failed Reason</span></td>
                  <td class="row2" colspan="3"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="fail_reason" runat="server"></asp:Literal></span></td>
                </tr>
                <tr> 
                  <td class="row1"><span class="explaintitle">MNP Rejection</span></td>
                  <td class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="MNP_Rejection" runat="server"></asp:Literal></span></td>
                  <td class="row1"><span class="explaintitle">Date</span></td>
                  <td class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="MNP_rej_date" runat="server"></asp:Literal></span></td>
                </tr>
                <tr> 
                  <td class="row1"><span class="explaintitle">Reject Code</span></td>
                  <td class="row2" colspan="3"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="Mnp_rej_code" runat="server"></asp:Literal></span></td>
                </tr>
		<tr> 
                  <td class="row1"><span class="explaintitle">Cancelled</span></td>
                  <td class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="cancelled" runat="server"></asp:Literal></span></td>
                  <td class="row1"><span class="explaintitle">Date</span></td>
                  <td class="row2"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="cancel_date" runat="server"></asp:Literal></span></td>
                </tr>
                <tr> 
                  <td class="row1"><span class="explaintitle">Pending/Cancelled Reason</span></td>
                  <td class="row2" colspan="3"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="pc_reason" runat="server"></asp:Literal></span></td>
                </tr>
                <tr> 
                  <td width="25%" class="row1"><span class="explaintitle">Last 
                    Update </span></td>
                  <td class="row2"  colspan="3"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="last_update" runat="server"></asp:Literal></span></td>
                </tr>
				</asp:Panel>
				
				<asp:Panel ID="edf_status_no_record_placeholder" runat="server">
                <tr> 
                  <td height="113" colspan="4" align="center" class="row1"><span class="explaintitle">RECORD 
                    NOT FOUND!</span></td>
                </tr>
				</asp:Panel>
                <tr> 
                  <td class="cat" colspan="4"><input name="button" type="button" onclick="window.close()" value="CLOSE" class="button" style="font-size:7pt" /> 
    </td>
                </tr>
              </table>
    </div>
    </form>
</body>
</html>
