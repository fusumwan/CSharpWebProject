<%@ Control Language="C#" AutoEventWireup="true" CodeFile="RetentionRecordOverView.ascx.cs" Inherits="UI_RetentionRecordOverView" %>

<style>
.new_rwl_imei_no, .new_edf_imei_no, .new_imei_imei_no
{
	display:none;
}

.RwlDiaglog
{
	background : gray;
}
</style>
  <script>
      $(document).ready(function() {
         $("[id$='but_chkimeiuseedf']").click(function() {
            $("#ShowImeiUseingEdf").dialog({
                  width: 300,
                  height: 200,
                  resizable: false,
                  show: 'fast',
                  hide: 'slow'
              }); 
          });
      });
      $(document).ready(function() {
          $("[id$='but_chkimeiuserwl']").click(function() {
            $("#ShowImeiUseingRwl").dialog({
                  width: 300,
                  height: 200,
                  resizable: false,
                  show: 'fast',
                  hide: 'slow'
              });
          });
      });
  </script>
<script language="javascript">

    //function highlightDifferentImei() {
    $(function() {
        var rwl_imei_no = $('.rwl_imei_no');
        var edf_imei_no = $('.edf_imei_no');
        var imei_imei_no = $('.imei_imei_no');

        if (rwl_imei_no.text() == edf_imei_no.text() && edf_imei_no.text() != imei_imei_no.text()) {
            imei_imei_no.css('color', 'red');
            $('.new_imei_imei_no').css('display', 'inline');
        } else if (edf_imei_no.text() == imei_imei_no.text() && edf_imei_no.text() != rwl_imei_no.text()) {
            rwl_imei_no.css('color', 'red');
            $('.new_rwl_imei_no').css('display', 'inline');
        } else if (imei_imei_no.text() == rwl_imei_no.text() && rwl_imei_no.text() != edf_imei_no.text()) {
            edf_imei_no.css('color', 'red');
            $('.new_edf_imei_no').css('display', 'inline');
        } else if (imei_imei_no.text() == rwl_imei_no.text() && rwl_imei_no.text() == edf_imei_no.text()) {
            // all same
        } else {
            // all different
        imei_imei_no.css('color', 'red');
        $('.new_imei_imei_no').css('display', 'inline');
        rwl_imei_no.css('color', 'red');
        $('.new_rwl_imei_no').css('display', 'inline');
        edf_imei_no.css('color', 'red');
        $('.new_edf_imei_no').css('display', 'inline');
        }
    });
</script>
<div id="ShowImeiUseingEdf"   title="EDF IMEI USAGE"></div>
<div id="ShowImeiUseingRwl"   title="RWL IMEI USAGE"></div>
<table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
				<tr>
					<td align="top">
	 					 <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
	 					    <tr>
								<td height="10" class="row2" align="center" colspan="2"><span class="explaintitle" >WEB LOG</span></td>
							</tr>	
						 	<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">WEB LOG RECORD ID:</span></td>
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
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle"><asp:Label ID="rwl_imei_no" CssClass="rwl_imei_no" runat="server"></asp:Label>&nbsp;<span class="new_rwl_imei_no"> -> <asp:TextBox ID="new_rwl_imei_noTextBox" runat="server"></asp:TextBox></span>
                                    </span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">WEB LOG ITEM CODE:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle"><asp:Label ID="rwl_sku"  runat="server"></asp:Label></span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">WEB LOG HANDSET MODEL:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle"><asp:Label ID="rwl_hs_model"  runat="server"></asp:Label></span></td>
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
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle"><asp:Label ID="edf_imei_no" CssClass="edf_imei_no" runat="server"></asp:Label>&nbsp;<span class="new_edf_imei_no"> ->  <asp:TextBox ID="new_edf_imei_noTextBox" runat="server" ></asp:TextBox></span></span></td>
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
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle"><asp:Label ID="imei_record_id"  runat="server"></asp:Label></span></td>
							</tr>

							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">IMEI STOCK EDF NUMBER:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle"><asp:Label ID="imei_edf_no"  runat="server"></asp:Label></span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">IMEI STOCK IMEI NUMBER:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle"><asp:Label ID="imei_imei_no" CssClass="imei_imei_no"  runat="server"></asp:Label>&nbsp;<span class="new_imei_imei_no"> -> <asp:TextBox ID="new_imei_imei_noTextBox" runat="server"></asp:TextBox></span>
                                    </span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">IMEI STOCK STATUS:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle"><asp:Label ID="imei_status"  runat="server"></asp:Label></span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">IMEI STOCK ITEM CODE:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle"><asp:Label ID="imei_sku"  runat="server"></asp:Label></span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">IMEI STOCK HANDSET MODEL:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle"><asp:Label ID="imei_hs_model"  runat="server"></asp:Label></span></td>
							</tr>
							<tr>
								<td height="10" width="25%" class="row1" align="center"><span class="explaintitle">IMEI STOCK REMARK:</span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle"><asp:Label ID="imei_remark"  runat="server"></asp:Label></span></td>
							</tr>
							<tr>
							    <td height="10" width="25%" class="row1" align="center"><span class="explaintitle"></span></td>
								<td height="10" width="75%" class="row1" align="center"> <span class="explaintitle">
								<input id="but_chkimeiuseedf" type="button" runat="server" class="button but_chkimeiuseedf" value="Check IMEI Using in EDF" />
								<input id="but_chkimeiuserwl" type="button" runat="server" class="button but_chkimeiuserwl" value="Check IMEI Using in Web Log" />
								</span>
								</td>
							</tr>
						 </table>
					</td>
				</tr>
			</table>