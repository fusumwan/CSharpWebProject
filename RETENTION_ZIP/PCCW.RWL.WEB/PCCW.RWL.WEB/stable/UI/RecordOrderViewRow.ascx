<%@ Control Language="C#" AutoEventWireup="true" CodeFile="RecordOrderViewRow.ascx.cs" Inherits="RecordOrderViewRow" %>
<link rel="stylesheet"  href="../Resources/Styles/global.css" type="text/css" />

<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
<script type="text/javascript" language="javascript">
function ShowSuspend(bSus){
    if(bSus==true){
        document.getElementById("no_suspend").style.display = "inline";
    }else{
        document.getElementById("no_suspend").style.display = "none";
    }
}
</script>
            <table width="100%" border="0" cellpadding="3" cellspacing="1" class="form-simple">
              <tr class="strow">
                <td align="center" colspan="5" width="100%" height="28"  ><span style="font-size:12pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span> (<asp:Literal ID="webid" runat="server"></asp:Literal>)</td>
              </tr>
              <tr class="strow">
                <td colspan="5" height="23" ><span > </span> 
                  <span > 
                  <input type="button" name="submit23" value="Add New" onClick="location.href='MobileRetentionOrderAddView.aspx'" style="font-size:10pt"/>
                  <input name="submit22" type="button" value="Search Record" onClick="location.href='SearchRetentionOrderView.aspx'" style="font-size:10pt" />
                  </span></td>
              </tr>
                    <tr class="strow">
                        <td  colspan="4" height="0" style="background-color:#dddddd">
                            <span style="font-size:10pt; font-weight:bold; color:Red">CUSTOMER DATA</span></td>
                    </tr>
                    <tr class="strow">
                        <td  height="0" width="21%">
                            <span style="font-size:10pt">Old Order ID</span></td>
                        <td  colspan="3" height="0">
                            <span style="font-size:10pt">
                            <asp:Literal ID="old_ord_id" runat="server" ></asp:Literal>
                            </span>
                        </td>
                    </tr>
                    <tr class="strow">
                        <td  height="0" width="21%">
                            <span style="font-size:10pt">EDF No </span>
                        </td>
                        <td  colspan="3" height="0">
                            <span style="font-size:10pt">
                            <asp:Literal ID="edf_no" runat="server"></asp:Literal>
                            </span>
                        </td>
                    </tr>
                    <tr class="strow">
                        <td  height="0" width="21%">
                            <span style="font-size:10pt">Log Date 登入時間</span></td>
                        <td  colspan="3" height="0">
                            <span style="font-size:10pt">
                            <asp:Literal ID="log_date" runat="server"></asp:Literal>(DD/MM/YYYY HH:MM)</span>
                        </td>
                    </tr>
                    <tr class="strow">
                        <td height="0" width="21%">
                            <span style="font-size:10pt">Language</span>
                        </td>
                        <td colspan="3" height="0">
                           <span style="font-size:10pt">
                            <asp:Literal ID="language" runat="server"></asp:Literal>
                           </span>
                        </td>
                    </tr>
                    <tr class="strow">
                        <td  height="0">
                            <span style="font-size:10pt">Customer Type 客戶類別 </span>
                        </td>
                        <td  colspan="3" height="0">
                            <span style="font-size:10pt">
                            <asp:Literal ID="cust_type" runat="server"></asp:Literal>
                            </span>
                        </td>
                    </tr>
                    <tr class="strow">
                        <td  height="0">
                            <span style="font-size:10pt">Customer Name 客戶姓名 </span>
                        </td>
                        <td  colspan="3" height="0">
                            <span style="font-size:10pt">
                            <asp:Literal ID="cust_name" runat="server"></asp:Literal>
                            </span>
                        </td>
                    </tr>
                    <tr class="strow">
                        <td  height="0">
                            <span style="font-size:10pt">Gender </span>
                        </td>
                        <td  colspan="3" height="0">
                            <span style="font-size:10pt">
                            <asp:Literal ID="gender" runat="server"></asp:Literal>
                            </span>
                        </td>
                    </tr>
                    
                    <tr class="strow">
                        <td  height="0">
                            <span style="font-size:10pt">Date Of Birth </span>
                        </td>
                        <td  colspan="3" height="0">
                            <span style="font-size:10pt">
                            <asp:Literal ID="date_of_birth" runat="server"></asp:Literal>
                            </span>
                        </td>
                    </tr>
                    
                    <tr class="strow">
                        <td  height="0">
                            <span style="font-size:10pt">Account No. 戶口號碼</span></td>
                        <td  colspan="3" height="0">
                            <span style="font-size:10pt">
                            <asp:Literal ID="ac_no" runat="server"></asp:Literal>
                            </span>
                        </td>
                    </tr>
                    <tr class="strow">
                        <td  height="0">
                            <span style="font-size:10pt">MRT No 登記流動電話號碼</span></td>
                        <td  colspan="3" height="0">
                            <span style="font-size:10pt">
                            <asp:Literal ID="mrt_no" runat="server"></asp:Literal>
                            </span>
                        </td>
                    </tr>
                    <tr class="strow">
                        <td  height="0">
                            <span style="font-size:10pt">HKID No/ BR No/ Passport No 
                            香港身份證號碼/護照號碼</span></td>
                        <td  colspan="3" height="0">
                            <span style="font-size:10pt">
                            <asp:Literal ID="hkid" runat="server"></asp:Literal>
                            </span>
                        </td>
                    </tr>
                    <tr class="strow">
                        <td height="0">
                            <span style="font-size:10pt">
                            Registered Address
                            </span>
                        </td>
                        <td colspan="3" height="0">
                            <span style="font-size:10pt">
                            <asp:Literal ID="registered_address" runat="server"></asp:Literal>
                            </span>
                        </td>
                    </tr>
                    
                    <tr class="strow">
                        <td height="0">
                            <span style="font-size:10pt">
                            Bill Medium
                            </span>
                        </td>
                        <td colspan="2">
                             <span style="font-size:10pt">
                            <asp:Literal ID="bill_medium" runat="server"></asp:Literal>
                            </span>
                        </td>
                        <td>
                        <span style="font-size:10pt">Waive:
                            <asp:Literal ID="bill_medium_waive" runat="server"></asp:Literal>
                            </span>
                        </td>
                    </tr>
                    
                    <tr class="strow">
                        <td height="0">
                            <span style="font-size:10pt">
                            Bill Medium Email
                            </span>
                        </td>
                        <td colspan="3">
                            <span style="font-size:10pt">
                            <asp:Literal ID="bill_medium_email" runat="server"></asp:Literal>
                            </span>
                        </td>
                    </tr>
                    <tr class="strow">
                        <td height="0">
                            <span style="font-size:10pt">
                            SMS Mrt
                            </span>
                        </td>
                        <td>
                            <span style="font-size:10pt">
                            <asp:Literal ID="sms_mrt" runat="server"></asp:Literal>
                            </span>
                        </td>
                    </tr>
                    <tr class="strow">
                        <td height="0">
                            <span style="font-size:10pt">
                                Billing Address
                            </span>
                        </td>
                        <td height="0">
                             <span style="font-size:10pt">
                                <asp:Literal ID="billing_address" runat="server"></asp:Literal>
                            </span>
                        </td>
                    </tr>
                    
                    
                    
                    <tr class="strow">
                        <td  height="0">
                            <span style="font-size:10pt">VIP Customer </span>
                        </td>
                        <td  colspan="3" height="0"><span style="font-size:10pt">
                            <asp:Literal ID="vip_case" runat="server"></asp:Literal></span>
                        </td>
                    </tr>
                    
                    <tr class="strow">
                        <td  height="0">
                            <span style="font-size:10pt">Special Handling Dummy Code </span>
                        </td>
                        <td  colspan="3" height="0"><span style="font-size:10pt">
                            <asp:Literal ID="special_handling_dummy_code" runat="server"></asp:Literal></span>
                        </td>
                    </tr>
                    
                    <tr class="strow">
                        <td  height="27">
                            <span style="font-size:10pt">Penalty Waiving 罰款豁免</span></td>
                        <td  colspan="3" height="27">
                            <span style="font-size:10pt">
                            <asp:Literal ID="waive" runat="server"></asp:Literal>
                            </span>
                        </td>
                    </tr>
                    <tr class="strow">
                        <td  height="0">
                            <span style="font-size:10pt">Existing Customer Type</span></td>
                        <td  colspan="3" height="0">
                            <span style="font-size:10pt">
                            <asp:Literal ID="exist_cust_plan" runat="server"></asp:Literal>
                            </span>
                        </td>
                    </tr>
                    <tr class="strow">
                        <td  height="0">
                            <span style="font-size:10pt">Original Tariff Fee</span></td>
                        <td  colspan="3" height="0">
                            <span style="font-size:10pt">
                            <asp:Literal ID="org_fee" runat="server"></asp:Literal>
                            </span>
                        </td>
                    </tr>
                    <tr class="strow">
                        <td  height="27">
                            <span style="font-size:10pt">Action Required </span>
                        </td>
                        <td  colspan="3" height="27">
                            <span style="font-size:10pt">
                            <asp:Literal ID="action_required" runat="server"></asp:Literal>
                            </span>
                        </td>
                    </tr>
                    <tr class="strow">
                        <td  height="27">
                            <span style="font-size:10pt">OB Program ID </span>
                        </td>
                        <td  colspan="3" height="27">
                            <span style="font-size:10pt">
                            <asp:Literal ID="ob_program_id" runat="server"></asp:Literal>
                            </span>
                        </td>
                    </tr>
                    <tr class="strow">
                        <td  height="27">
                            <span style="font-size:10pt">Existing Contract End Month</span></td>
                        <td  colspan="3" height="27">
                            <span style="font-size:10pt">
                            <asp:Literal ID="existing_contract_end_date" runat="server"></asp:Literal>
                            </span>
                        </td>
                    </tr>
                    <tr class="strow">
                        <td  height="0">
                            <span style="font-size:10pt">Suspend Date生效日期</span></td>
                        <td  colspan="3" height="0">
                            <span style="font-size:10pt">
                            <asp:Literal ID="action_eff_date" runat="server"></asp:Literal>
                            (DD/MM/YYYY)</span></td>
                    </tr>
                    <tr class="strow">
                        <td  height="0">
                            <span style="font-size:10pt">Existing Plan<br />
                            </span>
                        </td>
                        <td  colspan="3" height="0">
                            <span style="font-size:10pt">
                            <asp:Literal ID="exist_plan" runat="server"></asp:Literal>
                            </span>
                        </td>
                    </tr>
                    <tr class="strow">
                        <td  height="0">
                            <span style="font-size:10pt">Suspend Reasons<br />
                            </span>
                        </td>
                        <td  colspan="3" height="0">
                            <span style="font-size:10pt">
                            <asp:Literal ID="reasons" runat="server"></asp:Literal>
                            </span>
                        </td>
                    </tr>
     
		</table>
		
		

		
		
	 <table id="no_suspend" width="100%" border="0" cellpadding="3" cellspacing="1" class="form-simple">
	 <tr class="strow">
		<td height="0"  colspan="4" style="background-color:#dddddd"><span style="font-size:10pt; font-weight:bold; color:Red">Upgrade Order</span></td>
	  </tr>
	 <tr class="strow">
		<td width="22%" height="0" ><span style="font-size:10pt">Upgrade Type</span></td>
		<td height="0"  colspan="3"><span style="font-size:10pt"><asp:Literal ID="upgrade_type" runat="server"></asp:Literal></span> 
		</td>
	  </tr>
	  
	  <tr class="strow">
		<td width="22%" height="0" ><span style="font-size:10pt">Upgrade Sponsorships Amount</span></td>
		<td height="0"  colspan="3"><span style="font-size:10pt"><asp:Literal ID="upgrade_sponsorships_amount" runat="server"></asp:Literal></span> 
		</td>
	  </tr>
	  
	  <tr class="strow">
		<td width="22%" height="0" ><span style="font-size:10pt">Upgrade Existing Contract Start Date</span></td>
		<td height="0"  colspan="3"><span style="font-size:10pt"><asp:Literal ID="upgrade_existing_contract_sdate" runat="server"></asp:Literal></span> 
		</td>
	  </tr>
	  
	  <tr class="strow">
		<td width="22%" height="0" ><span style="font-size:10pt">Upgrade Existing Contract End Date</span></td>
		<td height="0"  colspan="3"><span style="font-size:10pt"><asp:Literal ID="upgrade_existing_contract_edate" runat="server"></asp:Literal></span> 
		</td>
	  </tr>
	  
	  <tr class="strow">
		<td width="22%" height="0" ><span style="font-size:10pt">Upgrade Existing Customer Type</span></td>
		<td height="0"  colspan="3"><span style="font-size:10pt"><asp:Literal ID="upgrade_existing_customer_type" runat="server"></asp:Literal></span> 
		</td>
	  </tr>
	  
	  <tr class="strow">
		<td width="22%" height="0" ><span style="font-size:10pt">Upgrade Handset Offer Rebate Schedule</span></td>
		<td height="0"  colspan="3"><span style="font-size:10pt"><asp:Literal ID="upgrade_handset_offer_rebate_schedule" runat="server"></asp:Literal></span> 
		</td>
	  </tr>
	  
	  <tr class="strow">
		<td width="22%" height="0" ><span style="font-size:10pt">Upgrade Existing PCCW Customer</span></td>
		<td height="0"  colspan="3"><span style="font-size:10pt"><asp:Literal ID="upgrade_existing_pccw_customer" runat="server"></asp:Literal></span> 
		</td>
	  </tr>
	  
	  <tr class="strow">
		<td width="22%" height="0" ><span style="font-size:10pt">FTG Tenure</span></td>
		<td height="0"  colspan="3"><span style="font-size:10pt"><asp:Literal ID="ftg_tenure" runat="server"></asp:Literal></span> 
		</td>
	  </tr>
	  
	  
	  <tr class="strow">
		<td width="22%" height="0" ><span style="font-size:10pt">Upgrade Service Account No</span></td>
		<td height="0"  colspan="3"><span style="font-size:10pt"><asp:Literal ID="upgrade_service_account_no" runat="server"></asp:Literal></span> 
		</td>
	  </tr>
	  
	  
	  <tr class="strow">
		<td width="22%" height="0" ><span style="font-size:10pt">Upgrade Registered Mobile No</span></td>
		<td height="0"  colspan="3"><span style="font-size:10pt"><asp:Literal ID="upgrade_registered_mobile_no" runat="server"></asp:Literal></span> 
		</td>
	  </tr>
	  
	  <tr class="strow">
		<td width="22%" height="0" ><span style="font-size:10pt">Upgrade Service Tenure</span></td>
		<td height="0"  colspan="3"><span style="font-size:10pt"><asp:Literal ID="upgrade_service_tenure" runat="server"></asp:Literal></span> 
		</td>
	  </tr>
	  
	   <tr class="strow">
		<td width="22%" height="0" ><span style="font-size:10pt">Credit Checking Serial</span></td>
		<td height="0"  colspan="3"><span style="font-size:10pt"><asp:Literal ID="card_ref_no" runat="server"></asp:Literal></span> 
		</td>
	  </tr>
	  
	  
	  <tr class="strow">
		<td width="22%" height="0" ><span style="font-size:10pt">Upgrade Rebate Calulation</span></td>
		<td height="0"  colspan="3"><span style="font-size:10pt"><asp:Literal ID="upgrade_rebate_calculation" runat="server"></asp:Literal></span> 
		</td>
	  </tr>
	 
	  <tr class="strow">
		<td height="0"  colspan="4" style="background-color:#dddddd"><span style="font-size:10pt; font-weight:bold; color:Red">MNP Information 
		  </span></td>
	  </tr>
	  <tr class="strow">
		<td width="22%" height="0" ><span style="font-size:10pt">2N Company Name</span></td>
		<td height="0"  colspan="3"> <span style="font-size:10pt"><asp:Literal ID="company_name" runat="server"></asp:Literal></span> 
		</td>
	  </tr>
	  <tr class="strow">
		<td width="22%" height="0" ><span style="font-size:10pt">2N Registered Name</span></td>
		<td height="0"  colspan="3"> <span style="font-size:10pt"><asp:Literal ID="registered_name" runat="server"></asp:Literal></span> 
		</td>
	  </tr>
	  
	  <tr class="strow">
		<td width="22%" height="0" ><span style="font-size:10pt">HKID no</span></td>
		<td height="0"  colspan="3"> <span style="font-size:10pt"><asp:Literal ID="mnp_hkid" runat="server"></asp:Literal></span> 
		</td>
	  </tr>
	  
	  <tr class="strow">
		<td width="22%" height="0" ><span style="font-size:10pt">2G IDD / Roaming Deposit Transfer to 3G</span></td>
		<td height="0"  colspan="3"> <span style="font-size:10pt"><asp:Literal ID="transfer_to_3g" runat="server"></asp:Literal></span> 
		</td>
	  </tr>
	  
	  <tr class="strow">
		<td width="22%" height="0" ><span style="font-size:10pt">Transfer IDD deposit</span></td>
		<td height="0"  colspan="3"> <span style="font-size:10pt"><asp:Literal ID="transfer_idd_deposit" runat="server"></asp:Literal></span> 
		</td>
	  </tr>
	  
	  <tr class="strow">
	    <td width="22%" height="0" ><span style="font-size:10pt">Transfer IDD & roaming deposit</span></td>
		<td height="0"  colspan="3"> <span style="font-size:10pt"><asp:Literal ID="transfer_idd_roaming_deposit" runat="server"></asp:Literal></span> 
		</td>
	  </tr>
	  
	  <tr class="strow">
	    <td width="22%" height="0" ><span style="font-size:10pt">Transfer Non-HK ID holder deposit</span></td>
		<td height="0"  colspan="3"> <span style="font-size:10pt"><asp:Literal ID="transfer_no_hk_id_holder_deposit" runat="server"></asp:Literal></span> 
		</td>
	  </tr>
	  
	  <tr class="strow">
	    <td width="22%" height="0" ><span style="font-size:10pt">Transfer no address proof deposit</span></td>
		<td height="0"  colspan="3"><span style="font-size:10pt"><asp:Literal ID="transfer_no_add_proof_deposit" runat="server"></asp:Literal></span></td>
	  </tr>
	  
	  <tr class="strow">
	    <td width="22%" height="0" ><span style="font-size:10pt">Transfer others deposit</span></td>
		<td height="0"  colspan="3"> <span style="font-size:10pt"><asp:Literal ID="transfer_others_deposit" runat="server"></asp:Literal></span></td>
	  </tr>
	  
	  <tr class="strow">
	    <td width="22%" height="0" ><span style="font-size:10pt">Service Activation Date (AM/PM)</span></td>
		<td height="0"  colspan="3"> <span style="font-size:10pt">
		<asp:Literal ID="service_activation_date" runat="server"></asp:Literal>
		<asp:Literal ID="service_activation_time" runat="server"></asp:Literal>
		</span> 
		</td>
	  </tr>
	  
	  <tr class="strow">
	    <td width="22%" height="0" ><span style="font-size:10pt">Ticker number</span></td>
		<td height="0"  colspan="3"> <span style="font-size:10pt"><asp:Literal ID="ticker_number" runat="server"></asp:Literal></span> 
		</td>
	  </tr>
	  
	  <tr class="strow">
		<td height="0"  colspan="4" style="background-color:#dddddd"><span style="font-size:10pt; font-weight:bold; color:Red">OFFER 
		  </span></td>
	  </tr>
	  <tr class="strow">
		<td width="22%" height="0" ><span style="font-size:10pt">Program 計劃</span></td>
		<td height="0"  colspan="3"> <span style="font-size:10pt"><asp:Literal ID="program" runat="server"></asp:Literal></span> 
		</td>
	  </tr>
	  <tr class="strow">
		<td height="0"  ><span style="font-size:10pt">Rate Plan</span></td>
    <td height="0"   colspan="3"> <span style="font-size:10pt"><asp:Literal ID="rate_plan" runat="server"></asp:Literal></span> 
      <span style="font-size:10pt"> - 
      
      <asp:Literal ID="normal_rebate_type" runat="server"></asp:Literal>
      
      </span> </td>
	  </tr>
   	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt">Special Approval<br />
		  </span></td>
		<td height="0"  colspan="3"> <span style="font-size:10pt">
		<asp:Literal ID="special_approval" runat="server"></asp:Literal>
		</span> 
		</td>
	  </tr>

	  <tr class="strow">
		
    <td height="0"  ><span style="font-size:10pt">Easywatch</span></td>
		
    <td height="0"   colspan="3">
    <span style="font-size:10pt"> 
    <asp:Literal ID="easywatch_type" runat="server"></asp:Literal>
    </span> 
    </td>
	  </tr>
	  <tr class="strow">
		<td height="0"  ><span style="font-size:10pt">Autoroll</span></td>
		<td height="0" colspan="3"  > <p><span style="font-size:10pt"> 
			
			<asp:Literal ID="accept" runat="server"></asp:Literal>
			
			</span></p></td>
	  </tr>
	  
	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt">PCD PAID Go Wireless</span></td>
		<td height="0" colspan="3" ><span style="font-size:10px"> 
		<asp:Literal ID="pcd_paid_go_wireless" runat="server"></asp:Literal>
		   </span></td>
	  </tr>
	  
	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt">LOB 
		  Type 現有服務類別</span></td>
		<td height="0" colspan="3" ><span style="font-size:10px"> 
		<asp:Literal ID="lob" runat="server"></asp:Literal>
		   </span></td>
	  </tr>
	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt">LOB 
		  Account No 現有服務戶口號碼</span><span > </span></td>
		<td height="0" colspan="3" ><span style="font-size:10px"> 
		<asp:Literal ID="lob_ac" runat="server"></asp:Literal>
		
		   </span></td>
	  </tr>
	  
	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt">Go Wireless Package Code</span><span > </span></td>
		<td height="0" colspan="3" ><span style="font-size:10px"> 
		<asp:Literal ID="go_wireless_package_code" runat="server"></asp:Literal>
		
		   </span></td>
	  </tr>
	  
	  <tr class="strow">
		<td height="27"  ><span style="font-size:10pt">Contract 
		  Period 合約期</span></td>
		<td height="27"  colspan="3"><span style="font-size:10pt"> 
		  <asp:Literal ID="con_per" runat="server"></asp:Literal></span></td>
	  </tr>
	  <tr class="strow">
		<td height="27"  ><span style="font-size:10pt">Rebate</span></td>
		<td height="27" colspan="3" ><span style="font-size:10pt"> 
		<asp:Literal ID="rebate" runat="server"></asp:Literal>
		  </span></td>
	  </tr>
	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt">Special Sim</span></td>
		<td height="0" colspan="3"><span style="font-size:10px"> 
		  </span><span style="font-size:10pt">
		  <asp:Literal ID="sim_item_name" runat="server"></asp:Literal><br />
		  <asp:Literal ID="sim_item_code" runat="server"></asp:Literal><br />
		  <asp:Literal ID="sim_item_number" runat="server"></asp:Literal>
		  </span><span style="font-size:10px"> 
		  </span></td>
	  </tr>
	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt">HS 
		  Model 手機型號</span></td>
		<td height="0" colspan="3"><span style="font-size:10px"> 
		  </span><span style="font-size:10pt">
		  <asp:Literal ID="hs_model" runat="server"></asp:Literal>
		  
		  </span><span style="font-size:10px"> 
		  </span></td>
	  </tr>
	  
	  	  <tr class="strow">
		<td width="22%" height="0" ><span style="font-size:10pt">Existing Smart Phone Model</span></td>
		<td height="0"  colspan="3"><span style="font-size:10pt"><asp:Literal ID="existing_smart_phone_model" runat="server"></asp:Literal></span> 
		</td>
	  </tr>
	 
	 <tr class="strow">
		<td width="22%" height="0" ><span style="font-size:10pt">Existing Smart Phone Imei</span></td>
		<td height="0"  colspan="3"><span style="font-size:10pt"><asp:Literal ID="existing_smart_phone_imei" runat="server"></asp:Literal></span> 
		</td>
	  </tr>
	  
	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt">SKU 
		  Item Code</span></td>
		<td height="0" colspan="3"><span style="font-size:10px"> 
		  </span><span style="font-size:10pt">
		  <asp:Literal ID="sku" runat="server"></asp:Literal>
		  </span><span style="font-size:10px"> 
		  </span></td>
	  </tr>
	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt"><span style="font-size:10pt">IMEI</span></span></td>
		<td height="0" colspan="3"><span style="font-size:10px"> 
		  </span><span style="font-size:10pt"><asp:Literal ID="imei_no" runat="server"></asp:Literal></span><span style="font-size:10px"> 
		  </span></td>
	  </tr>
	  
	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt"><span style="font-size:10pt">1C2N Mobile no</span></span></td>
		<td height="0" colspan="3"><span style="font-size:10px"> 
		  </span><span style="font-size:10pt"><asp:Literal ID="cn_mrt_no" runat="server"></asp:Literal></span><span style="font-size:10px"> 
		  </span></td>
	  </tr>
	  
	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt"><span style="font-size:10pt">Pool</span></span></td>
		<td height="0" colspan="3"><span style="font-size:10px"> 
		  </span><span style="font-size:10pt"><asp:Literal ID="pool" runat="server"></asp:Literal></span><span style="font-size:10px"> 
		  </span></td>
	  </tr>
	  
	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt">Premium 
		  禮品</span></td>
		<td height="0" colspan="3" ><span style="font-size:10px"> 
		  <span style="font-size:10pt">
		  <asp:Literal ID="premium" runat="server"></asp:Literal>
		  </span> 
		  </span></td>
	  </tr>
		<tr class="strow">
		  <td height="0" ><span style="font-size:10pt">Special Premium 
			<br>
			</span></td>
		  <td height="0" colspan="3" ><span style="font-size:10px"> 
			</span><span style="font-size:10pt"><asp:Literal ID="s_premium" runat="server"></asp:Literal></span><span style="font-size:10px"> 
			</span></td>
		</tr>
		<tr class="strow">
		  <td height="0" ><span style="font-size:10pt">Special 
			Premium Delivery Date<br>
			</span></td>
		  
    <td height="0" colspan="3" > <span style="font-size:10pt"><asp:Literal ID="sp_d_date" runat="server"></asp:Literal>
      <span style="font-size:10px">(DD/MM/YYYY)</span> </span></td>
		</tr>
		<tr class="strow">
		  
		<td height="0" ><span style="font-size:10pt">Special 
		  Premium Quota Reference No</span></td>
		  <td height="0" colspan="3" > <span style="font-size:10pt"><asp:Literal ID="sp_ref_no" runat="server"></asp:Literal></span> 
		  </td>
		</tr>
	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt">POS 
		  Reference No</span></td>
		<td height="0"  colspan="3"> <span style="font-size:10pt">
		<asp:Literal ID="pos_ref_no" runat="server"></asp:Literal>
		</span> 
		</td>
	  </tr>
	  
	  <tr class="strow">
		  <td height="0" ><span style="font-size:10pt">Special Premium 1
			</span></td>
		  <td height="0" colspan="3" ><span style="font-size:10px"> 
			</span><span style="font-size:10pt"><asp:Literal ID="s_premium1" runat="server"></asp:Literal>
			</span></td>
		</tr>
	  
	  
	  
		<tr class="strow">
		  <td height="0" ><span style="font-size:10pt">Special Premium 2
			</span></td>
		  <td height="0" colspan="3" ><span style="font-size:10px"> 
			</span><span style="font-size:10pt"><asp:Literal ID="s_premium2" runat="server"></asp:Literal>
			</span></td>
		</tr>
		
		<tr class="strow">
		  <td height="0" ><span style="font-size:10pt">Special Premium 3
			</span></td>
		  <td height="0" colspan="3" ><span style="font-size:10px"> 
			</span><span style="font-size:10pt"><asp:Literal ID="s_premium3" runat="server"></asp:Literal>
			</span></td>
		</tr>
		
		<tr class="strow">
		  <td height="0" ><span style="font-size:10pt">Special Premium 4
			</span></td>
		  <td height="0" colspan="3" ><span style="font-size:10px"> 
			</span><span style="font-size:10pt"><asp:Literal ID="s_premium4" runat="server"></asp:Literal>
			</span></td>
		</tr>
		
		<tr class="strow">
		  <td height="0" ><span style="font-size:10pt">Redemption Notice
			</span></td>
		  <td height="0" colspan="3" ><span style="font-size:10px"> 
			</span><span style="font-size:10pt"><asp:Literal ID="redemption_notice_option" runat="server"></asp:Literal>
			</span></td>
		</tr>
	  <tr class="strow">
		<td height="27"  ><span style="font-size:10pt">Trade 
		  Field</span></td>
		<td height="27"  colspan="3"><span style="font-size:10pt"> 
		  <asp:Literal ID="trade_field" runat="server"></asp:Literal></span></td>
	  </tr>
	  <tr class="strow">
		<td height="27"  ><span style="font-size:10pt">Bundle 
		  Name</span></td>
		<td height="27" colspan="3" ><span style="font-size:10pt"> 
		  <asp:Literal ID="bundle_name" runat="server"></asp:Literal></span></td>
	  </tr>
	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt">Monthly 
		  Rebate Amount </span></td>
		<td height="0" colspan="3" ><span style="font-size:10px"> 
		  </span><span style="font-size:10pt"> 
		   <asp:Literal ID="m_rebate_amount" runat="server"></asp:Literal>
		  </span><span style="font-size:10px"> </span></td>
	  </tr>
	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt">HS 
		  Rebate Amount 手機回贈總額</span></td>
		<td height="0" colspan="3" ><span style="font-size:10px"> 
		  </span><span style="font-size:10pt"> 
		  <asp:Literal ID="rebate_amount" runat="server"></asp:Literal>
		  </span><span style="font-size:10px"> </span></td>
	  </tr>
	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt">Retention 
		  Offer 續約優惠</span></td>
		<td height="0" colspan="3" ><span style="font-size:10px"> 
		  </span><span style="font-size:10pt"> 
		  <asp:Literal ID="r_offer" runat="server"></asp:Literal>
		  </span><span style="font-size:10px"> </span></td>
	  </tr>
	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt">Extra 
		  Rebate Amount 額外回贈總額</span></td>
		<td height="0" colspan="3" ><span style="font-size:10pt"> 
		   <asp:Literal ID="extra_rebate_amount" runat="server"></asp:Literal>
		  </span><span style="font-size:10px"> </span></td>
	  </tr>
	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt">Extra 
		  Rebate額外回贈</span></td>
		<td height="0" colspan="3" ><span style="font-size:10px"> 
		  </span><span style="font-size:10pt"> 
		  <asp:Literal ID="extra_rebate" runat="server"></asp:Literal>
		  </span><span style="font-size:10px"> 
		  </span></td>
	  </tr>
	  <tr class="strow">
		<td height="27"  ><span style="font-size:10pt">Free 
		  Monthly Fee免費月份費用</span></td>
		<td height="27"  colspan="3"><span style="font-size:10pt"> 
		<asp:Literal ID="free_mon" runat="server"></asp:Literal>
		   </span></td>
	  </tr>
	  <tr class="strow">
		<td height="27"  ><span style="font-size:10pt">Cancel 
		  Auto Renewal 取消自動續約</span></td>
		<td height="27" colspan="3" ><span style="font-size:10pt"> 
		<asp:Literal ID="cancel_renew" runat="server"></asp:Literal>
		  </span></td>
	  </tr>
	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt">GO Wireless</span></td>
		<td height="0" ><span style="font-size:10pt"><asp:Literal ID="go_wireless" runat="server"></asp:Literal></span> 
		</td>
		<td height="0" ><span style="font-size:10pt">Preferred Lanuages<br />
		  </span></td>
		<td height="0" ><span style="font-size:10px"> 
		<asp:Literal ID="preferred_languages" runat="server"></asp:Literal>
		
		  </span></td>
	  </tr>
	  
	  <tr class="strow">
		<td height="27"  ><span style="font-size:10pt">Register Address</span></td>
		<td height="27" colspan="3" ><span style="font-size:10pt"> 
		<asp:Literal ID="register_address" runat="server"></asp:Literal>
		  </span></td>
	  </tr>

	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt">Free 
		  Gift Code免費禮品條碼</span></td>
		<td height="0" >
		<span style="font-size:10pt">
		<asp:Literal ID="gift_code" runat="server"></asp:Literal>
		</span> 
		</td>
		<td height="0" ><span style="font-size:10pt">Free 
		  Gift IMEI<br />
		  </span></td>
		<td height="0" ><span style="font-size:10px"> 
		<asp:Literal ID="gift_imei" runat="server"></asp:Literal>
		  </span></td>
	  </tr>
	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt">Free 
		  Gift Description免費禮品評術</span></td>
		<td height="0" colspan="3" ><span style="font-size:10pt">
		<asp:Literal ID="gift_desc" runat="server"></asp:Literal>
		</span> 
		</td>
	  </tr>
	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt">Free 
		  Gift Code2免費禮品條碼2</span></td>
		<td height="0" ><span style="font-size:10pt">
		<asp:Literal ID="gift_code2" runat="server"></asp:Literal>
		</span> 
		</td>
		<td height="0" ><span style="font-size:10pt">Free 
		  Gift 2 IMEI<br />
		  </span></td>
		<td height="0" ><span style="font-size:10px"> 
		<asp:Literal ID="gift_imei2" runat="server"></asp:Literal>
		  </span></td>
	  </tr>
	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt">Free 
		  Gift Description2免費禮品評術2</span></td>
		<td height="0" colspan="3" ><span style="font-size:10pt">
		<asp:Literal ID="gift_desc2" runat="server"></asp:Literal>
		</span> 
		</td>
	  </tr>
	   <tr class="strow">
		<td height="0" ><span style="font-size:10pt">Free 
		  Gift Code 3 免費禮品條碼3</span></td>
		<td height="0" ><span style="font-size:10pt">
		<asp:Literal ID="gift_code3" runat="server"></asp:Literal>
		</span> 
		</td>
		<td height="0" ><span style="font-size:10pt">Free 
		  Gift 3 IMEI<br />
		  </span></td>
		<td height="0" ><span style="font-size:10px"> 
		<asp:Literal ID="gift_imei3" runat="server"></asp:Literal>
		  </span></td>
	  </tr>
	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt">Free 
		  Gift Description3免費禮品評術3</span></td>
		<td height="0" colspan="3" ><span style="font-size:10pt">
		<asp:Literal ID="gift_desc3" runat="server"></asp:Literal>
		</span> 
		</td>
	  </tr>
	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt">Free 
		  Gift Code2免費禮品條碼4</span></td>
		<td height="0" ><span style="font-size:10pt">
		<asp:Literal ID="gift_code4" runat="server"></asp:Literal>
		</span> 
		</td>
		<td height="0" ><span style="font-size:10pt">Free 
		  Gift 4 IMEI<br />
		  </span></td>
		<td height="0" ><span style="font-size:10px"> 
		
		<asp:Literal ID="gift_imei4" runat="server"></asp:Literal>
		
		  </span></td>
	  </tr>
	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt">Free 
		  Gift Description4免費禮品評術4</span></td>
		<td height="0" colspan="3" ><span style="font-size:10pt">
		<asp:Literal ID="gift_desc4" runat="server"></asp:Literal>
		</span> 
		</td>
	  </tr>
<tr class="strow">
		<td height="0" ><span style="font-size:10pt">Accessory 
		  Code 配件條碼</span></td>
		<td height="0" ><span style="font-size:10pt"> 
		<asp:Literal ID="accessory_code" runat="server"></asp:Literal>
		  </span> </td>
		<td height="0" ><span style="font-size:10pt">Accessory 
		  IMEI<br />
		  </span></td>
		<td height="0" ><span style="font-size:10px"> 
		<asp:Literal ID="accessory_imei" runat="server"></asp:Literal>
		  </span></td>
	  </tr>
	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt">Price 
		  of Accessory配件價金額</span></td>
		<td height="0" colspan="3" >
		 <span style="font-size:10pt"> 
		  $  <asp:Literal ID="accessory_price" runat="server"></asp:Literal></span></td>
	  </tr>
		   <tr id="aig_gift_show" class="strow" runat="server">
		  <td height="0" ><span style="font-size:10pt">AIG Free Gift</span></td>
		  <td height="0" colspan="3" ><span style="font-size:10px"> 
		  <asp:Literal ID="aig_gift" runat="server"></asp:Literal>
			</span></td>
		</tr>
	  <tr class="strow">
		<td height="0"  colspan="4" style="background-color:#dddddd"><span style="font-size:10pt; font-weight:bold; color:Red">VAS 
		  </span></td>
	  </tr>

                <asp:PlaceHolder ID="GiftVasCreate_Holder" Visible="false"  runat="server"></asp:PlaceHolder>

                <tr class="strow">
                    <td  height="27">
                        <span style="font-size:10pt">Early Start</span></td>
                    <td  colspan="3" height="27">
                        <span style="font-size:10pt">
                        <asp:Literal ID="fast_start" runat="server"></asp:Literal>
                        </span>
                    </td>
                </tr>
                <tr class="strow">
                    <td  height="0">
                        <span style="font-size:10pt">VAS Effective Date增值服務生效期</span></td>
                    <td  colspan="3" height="0">
                        <span style="font-size:10pt">
                        <asp:Literal ID="vas_eff_date" runat="server"></asp:Literal>
                        (DD/MM/YYYY)</span> 
                    </td>
                </tr>
                <tr class="strow">
                    <td  height="0">
                        <span style="font-size:10pt">Contract Effective Date合約生效期</span></td>
                    <td  colspan="3" height="0">
                        <span style="font-size:10pt">
                        <asp:Literal ID="con_eff_date" runat="server"></asp:Literal>

                        <span style="font-size:10px">(DD/MM/YYYY)</span> </span>
                    </td>
                </tr>
                <tr class="strow" style="display:none">
                    <td  height="0">
                        <span style="font-size:10pt">Next Bill Cut Date</span></td>
                    <td  colspan="3" height="0">
                        <span style="font-size:10pt">
                        <asp:Literal ID="next_bill" runat="server"></asp:Literal>
                        </span>
                    </td>
                </tr>
                <tr class="strow">
                    <td  height="0">
                        <span style="font-size:10pt">Rate Plan Effective Date</span></td>
                    <td  colspan="3" height="0">
                        <span style="font-size:10pt">
                        <%--<asp:Literal ID="plan_eff" runat="server"></asp:Literal>--%>
                        <asp:Literal ID="plan_eff_date" runat="server"></asp:Literal>
                        <span style="font-size:10px">(DD/MM/YYYY)</span> </span>
                    </td>
                </tr>
                
                <tr class="strow">
                    <td  height="0">
                        <span style="font-size:10pt">Bill Cut Date</span></td>
                    <td  colspan="3" height="0">
                        <span style="font-size:10pt">
                        <asp:Literal ID="bill_cut_date" runat="server"></asp:Literal>
                        <span style="font-size:10px">(DD/MM/YYYY)</span> </span>
                    </td>
                </tr>
                
                <tr class="strow">
		<td width="22%" height="0" ><span style="font-size:10pt">Action Of Rate Plan Effective</span></td>
		<td height="0"  colspan="3"><span style="font-size:10pt"><asp:Literal ID="action_of_rate_plan_effective" runat="server"></asp:Literal></span> 
		</td>
	  </tr>
	  
                
                
                <tr class="strow">
		<td height="0" ><span style="font-size:10pt">Cooling Offer</span></td>
    <td height="0"  colspan="3"> <span style="font-size:10pt"> 
    <asp:Literal ID="cooling_offer" runat="server"></asp:Literal>
	  </tr>

	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt">2nd Contract Effective date(DD/MM/YYYY)</span></td>
            <td height="0"  colspan="3"> 
            <span style="font-size:10pt"> 
              <asp:Literal ID="cooling_date" runat="server"></asp:Literal>
	          </tr>
                <tr class="strow">
                    <td  colspan="4" height="0" style="background-color:#dddddd">
                        <span style="font-size:10pt; font-weight:bold; color:Red">Monthly Payment Type </span>
                    </td>
                </tr>
                <tr class="strow">
                    <td >
                     <span style="font-size:10pt">Prepayment</span>
                    </td>
                    <td olspan="3" height="0">
                        <span style="font-size:10pt"><asp:Literal ID="prepayment" runat="server"></asp:Literal></span>
                    </td>
                </tr>
                <tr class="strow">
                    <td >
                        <span style="font-size:10pt">Monthly Payment Type </span>
                    </td>
                    <td  colspan="3" height="0">
                        <span style="font-size:10pt">
                        <asp:Literal ID="monthly_payment_type" runat="server"></asp:Literal>
                        </span>
                    </td>
                </tr>

                <tr class="strow">
                    <td  height="0">
                        <span style="font-size:10pt">Credit Card Type 信用卡類別</span></td>
                    <td  height="0">
                        <span style="font-size:10px"></span><span >
                        </span><span style="font-size:10px"></span>
                        <span ></span><span style="font-size:10pt">
                        <asp:Literal ID="m_card_type" runat="server"></asp:Literal>
                        </span><span ></span><span 
                            style="font-size:10px"></span>
                    </td>
                    <td  height="0">
                        <span style="font-size:10pt">Credit Card No. </span>
                    </td>
                    <td  height="0">
                        <span style="font-size:10px"></span><span >
                        </span><span ></span><span 
                            style="font-size:10pt"></span><span style="font-size:10pt">
                        <asp:Literal ID="m_card_no" runat="server"></asp:Literal>
                        </span><span style="font-size:10px"></span>
                        <span style="font-size:10px"></span>
                    </td>
                </tr>
                <tr class="strow">
                    <td  height="0">
                        <span style="font-size:10pt">Credit Card Holder Name 
                        信用卡持有人姓名<br />
                        </span>
                    </td>
                    <td  height="0">
                        <span style="font-size:10pt">
                        <asp:Literal ID="m_card_holder2" runat="server"></asp:Literal>
                        </span>
                    </td>
                    <td  height="0">
                        <span style="font-size:10pt">Credit Card Expiry Date </span>
                    </td>
                    <td  height="0">
                        <span style="font-size:10px"></span><span >
                        <asp:Literal ID="m_card_exp_month" runat="server"></asp:Literal>
                        </span><span style="font-size:10pt"></span>
                        <span >/ </span><span style="font-size:10pt">
                        <asp:Literal ID="m_card_exp_year" runat="server"></asp:Literal>
                        </span><span >(MM/YY) </span><span style="font-size:10px"></span>
                    </td>
                </tr>
                
                <tr class="strow">
                    <td  height="0">
                        <span style="font-size:10pt">3rd party contact number </span>
                    </td>
                    <td  height="0" nowrap="nowrap">
                        <span style="font-size:12px">
                        <asp:Literal id="m_3rd_contact_no" runat="server"></asp:Literal>
                        </span>
                        
                    </td>
                    <td  height="0" nowrap="nowrap">
                    <span style="font-size:12px">HKID/BR NO/PASSPORT:</span>
                          <asp:Literal ID="m_3rd_id_type" runat="server"></asp:Literal>
                          <asp:Literal ID="m_3rd_hkid" runat="server"></asp:Literal>
                          <asp:Literal ID="m_3rd_hkid2" runat="server"></asp:Literal>
                    </td>
                    <td  height="0">

                    </td>
                </tr>
                
                
                <tr class="strow">
                    <td  height="0">
                        <span style="font-size:10pt">Account Number 戶口號碼</span>
                    </td>
                    <td  height="0" nowrap="nowrap">
                        <span style="font-size:10px">
                        <asp:Literal ID="monthly_bank_account_bank_code" runat="server"></asp:Literal>
                        </span>
                        &nbsp;
                        <span style="font-size:10px">
                        <asp:Literal ID="monthly_bank_account_branch_code" runat="server"></asp:Literal>
                        </span>
                        &nbsp;
                        <span style="font-size:10px">
                        <asp:Literal ID="monthly_bank_account_no" runat="server"></asp:Literal>
                        </span>
                    </td>
                    <td  height="0">
                       
                    </td>
                    <td  height="0">

                    </td>
                </tr>
                
                <tr class="strow">
                    <td  height="0">
                        <span style="font-size:10pt">Bank Account Holder Name </span>
                    </td>
                    <td  height="0" nowrap="nowrap">
                        <span style="font-size:12px">
                        <asp:Literal ID="monthly_bank_account_holder" runat="server"></asp:Literal>
                        </span>
                        
                    </td>
                    <td  height="0" nowrap="nowrap">
                    <span style="font-size:12px">HKID/BR NO/PASSPORT:</span>
                          <asp:Literal ID="monthly_bank_account_id_type" runat="server"></asp:Literal>
                          <asp:Literal ID="monthly_bank_account_hkid" runat="server"></asp:Literal>
                          <asp:Literal ID="monthly_bank_account_hkid2" runat="server"></asp:Literal>
                    </td>
                    <td  height="0">

                    </td>
                </tr>
                
                
                
                
                <tr class="strow">
                    <td  colspan="4" height="0">
                        <span style="font-size:10pt">ORDER PLACE DETAILS 合約承諾人資料</span></td>
                </tr>
                <tr class="strow">
                    <td >
                        <span style="font-size:10pt">Order Placed By 合約承諾人</span></td>
                    <td  colspan="3" height="0">
                        <span style="font-size:10pt">
                        <asp:Literal ID="ord_place_by" runat="server"></asp:Literal>
                        </span>
                    </td>
                </tr>
                <tr class="strow">
                    <td >
                        <span style="font-size:10pt">Relationship 與登記人關係 </span>
                    </td>
                    <td  colspan="3" height="0">
                        <span style="font-size:10pt">
                        <asp:Literal ID="ord_place_rel" runat="server"></asp:Literal>
                        </span>
                    </td>
                </tr>
                <tr class="strow">
                    <td >
                        <span style="font-size:10pt">HKID No/ Passport No 香港身份證號碼 
                        /護照號碼<br />
                        </span>
                    </td>
                    <td  colspan="3" height="0">
                        <span style="font-size:10pt">
                        <asp:Literal ID="ord_place_id_type" runat="server"></asp:Literal>&nbsp;<asp:Literal ID="ord_place_hkid" runat="server"></asp:Literal>
                        </span>
                    </td>
                </tr>
                <tr class="strow">
                    <td >
                        <span style="font-size:10pt">Contact No 聯絡電話號碼<br />
                        </span>
                    </td>
                    <td  colspan="3" height="0">
                        <span style="font-size:10pt">
                        <asp:Literal ID="ord_place_tel" runat="server"></asp:Literal>
                        </span>
                    </td>
                </tr>
                
                <tr class="strow">
                    <td  colspan="4" height="0" style="background-color:#dddddd">
                        <span style="font-size:10pt; font-weight:bold; color:Red">DELIVERY INFORMATION 送貨資料</span></td>
                </tr>
                <tr class="strow">
                    <td  height="0">
                        <span style="font-size:10pt">Delivery Address 送貨地址</span></td>
                    <td  colspan="3" height="0">
                        <span style="font-size:10px"></span><span 
                            style="font-size:10pt">
                        <asp:Literal ID="d_address" runat="server"></asp:Literal>
                        </span><span style="font-size:10px"></span>
                    </td>
                </tr>
                <tr class="strow">
                    <td  height="0">
                        <span style="font-size:10pt">Delivery Date &amp; Time 送貨日期和時間</span></td>
                    <td  height="0" width="29%">
                        <span style="font-size:10px"></span><span 
                            style="font-size:10pt"></span><span style="font-size:10pt">
                        <asp:Literal ID="d_date" runat="server"></asp:Literal>
                        (<span style="font-size:10px">DD/MM/YYYY)</span>
                        <asp:Literal ID="d_time" runat="server"></asp:Literal>
                        </span>
                    </td>
                    <td  height="0" width="23%">
                        <span style="font-size:10pt">Delivery Charge for special 
                        region </span>
                    </td>
                    <td  width="27%">
                        <span style="font-size:10px">$ </span><span 
                            style="font-size:10pt">
                        <asp:Literal ID="extra_d_charge" runat="server"></asp:Literal>
                        </span><span style="font-size:10px"></span>
                    </td>
                </tr>
                
                <tr class="strow">
                    <td  height="0">
                        <span style="font-size:10pt">Receive SIM by 3rd party </span>
                    </td>
                    <td  colspan="3" height="0">
                        <span style="font-size:10px">
                        <asp:Literal ID="three_party" runat="server"></asp:Literal>
                        </span>
                    </td>
                </tr>
                
                <tr class="strow">
                    <td height="0">
                        <span style="font-size:10pt">Arthurization Person</span>
                    </td>
                    <td colspan="3">
                        <span style="font-size:10px">
                        <asp:Literal ID="arthurization_person" runat="server"></asp:Literal>
                        </span>
                    </td>
                </tr>
                
                <tr class="strow">
                    <td height="0">
                        <span style="font-size:10pt">Hkid</span>
                    </td>
                    <td colspan="3">
                        <span style="font-size:10px">
                        <asp:Literal ID="tpy_hkid" runat="server"></asp:Literal>
                        </span>
                    </td>
                </tr>
                
                <tr class="strow">
                    <td height="0">
                        <span style="font-size:10pt">Contact number</span>
                    </td>
                    <td colspan="3">
                        <span style="font-size:10px">
                        <asp:Literal ID="tpy_contact_no" runat="server"></asp:Literal>
                        </span>
                    </td>
                </tr>
                
                <tr class="strow">
                    <td  height="0">
                        <span style="font-size:10pt">Contact Person聯絡人 </span>
                    </td>
                    <td  colspan="3" height="0">
                        <span style="font-size:10px"></span><span 
                            style="font-size:10pt">
                        <asp:Literal ID="contact_person" runat="server"></asp:Literal>
                        </span><span style="font-size:10px"></span>
                    </td>
                </tr>
                <tr class="strow">
                    <td  height="0">
                        <span style="font-size:10pt">Contact No. 聯絡電話</span></td>
                    <td  colspan="3" height="0">
                        <span style="font-size:10px"></span><span 
                            style="font-size:10pt">
                        <asp:Literal ID="contact_no" runat="server"></asp:Literal>
                        </span><span style="font-size:10pt">
                        <asp:Literal ID="ext_place_tel" runat="server"></asp:Literal>
                        </span>
                    </td>
                </tr>
                <tr id="show_third_party" runat="server">
                    <td  height="0">
                        <span style="font-size:10pt">3rd Party Credit Card<br>
                        <br>
                        
                        </br>
                        </br>
                        </span>
                    </td>
                    <td  height="0">
                        <span style="font-size:10px"></span><span 
                            style="font-size:10pt"><asp:Literal ID="third_party_credit_card" runat="server"></asp:Literal></span><span style="font-size:10px">
                        </span><span style="font-size:10px"></span>
                    </td>
                    <td  height="0">
                        <span style="font-size:10pt">3rd HKID/BR No/Passport<br>
                        <br></br>
                        </br>
                        </span>
                    </td>
                    <td  height="0">
                        <span style="font-size:10px"></span><span 
                            style="font-size:10pt"><asp:Literal id="third_party_id_type" runat="server" runat="server"></asp:Literal>&nbsp;<asp:Literal id="third_party_hkid" runat="server" runat="server"></asp:Literal></span><span style="font-size:10px">
                        </span><span style="font-size:10px"></span>
                    </td>
                </tr>
                
                
                <tr class="strow">
                    <td  height="0">
                        <span style="font-size:10pt">Payment Method 繳費方法</span></td>
                    <td  colspan="3" height="0">
                        <span style="font-size:10px"></span><span 
                            style="font-size:10pt">
                        <asp:Literal ID="pay_method" runat="server"></asp:Literal>
                        </span><span style="font-size:10px"></span>
                        <span style="font-size:10px"></span>
                    </td>
                </tr>
                <tr class="strow">
                    <td  height="0">
                        <span style="font-size:10pt">Credit Card Type 信用卡類別</span></td>
                    <td  height="0">
                        <span style="font-size:10px"></span><span >
                        </span><span style="font-size:10px"></span>
                        <span ></span><span style="font-size:10pt">
                        <asp:Literal ID="card_type" runat="server"></asp:Literal>
                        </span><span ></span><span 
                            style="font-size:10px"></span>
                    </td>
                    <td  height="0">
                        <span style="font-size:10pt">Credit Card No. </span>
                    </td>
                    <td  height="0">
                        <span style="font-size:10px"></span><span >
                        </span><span ></span><span 
                            style="font-size:10pt"></span><span style="font-size:10pt">
                        <asp:Literal ID="card_no" runat="server"></asp:Literal>
                        </span><span style="font-size:10px"></span>
                        <span style="font-size:10px"></span>
                    </td>
                </tr>
                <tr class="strow">
                    <td  height="0">
                        <span style="font-size:10pt">Credit Card Holder Name 
                        信用卡持有人姓名<br />
                        </span>
                    </td>
                    <td  height="0">
                        <span style="font-size:10px"></span><span >
                        </span><span style="font-size:10pt">
                        <asp:Literal ID="card_holder" runat="server"></asp:Literal>
                        </span><span ></span><span 
                            style="font-size:10px"></span>
                    </td>
                    <td  height="0">
                        <span style="font-size:10pt">Credit Card Expiry Date </span>
                    </td>
                    <td  height="0">
                        <span style="font-size:10px"></span><span >
                        </span><span style="font-size:10pt">
                        <asp:Literal ID="card_exp_month" runat="server"></asp:Literal>
                        </span><span >/ </span><span 
                            style="font-size:10pt">
                        <asp:Literal ID="card_exp_year" runat="server"></asp:Literal>
                        </span><span >(MM/YY) </span><span 
                            style="font-size:10px"></span>
                    </td>
                </tr>
                <tr class="strow">
                    <td  height="0">
                        <span style="font-size:10pt">Bank Name銀行名稱</span></td>
                    <td  colspan="3" height="0">
                        <span style="font-size:10pt">
                        <asp:Literal ID="bank_name" runat="server"></asp:Literal>
                        Bank Code:<asp:Literal ID="bank_code" runat="server"></asp:Literal>
                        </span>
                    </td>
                </tr>
                <tr class="strow">
                    <td  height="0">
                        <span style="font-size:10pt">HS Amount手機總額</span></td>
                    <td  colspan="3" height="0">
                        <span style="font-size:10pt">
                        <asp:Literal ID="amount" runat="server"></asp:Literal>
                        </span>
                    </td>
                </tr>
                
                
                <tr class="strow">
                    <td  height="0">
                        <span style="font-size:10pt">Collection Type</span></td>
                    <td  colspan="3" height="0">
                        <span style="font-size:10pt">
                        <asp:Literal ID="delivery_collection_type" runat="server"></asp:Literal>
                        </span>
                    </td>
                </tr>
                
                <tr class="strow">
                    <td  height="0">
                        <span style="font-size:10pt">Exchange</span></td>
                    <td  colspan="3" height="0">
                        <span style="font-size:10pt">
                        <asp:Literal ID="delivery_exchange" runat="server"></asp:Literal>
                        </span>
                    </td>
                </tr>
                
                <tr class="strow">
                    <td  height="0">
                        <span style="font-size:10pt">Option</span></td>
                    <td  colspan="3" height="0">
                        <span  style="font-size:10pt">
                        <asp:Literal ID="delivery_exchange_option" runat="server"></asp:Literal>
                        </span>
                    </td>
                </tr>
                
                <tr class="strow">
                    <td  height="0">
                        <span style="font-size:10pt">Location</span></td>
                    <td  colspan="3" height="0">
                        <span style="font-size:10pt">
                        <asp:Literal ID="delivery_exchange_location" runat="server"></asp:Literal>
                        </span>
                    </td>
                </tr>

</table>
<table id="no_opt_out" width="100%" border="0" cellpadding="3" cellspacing="1" class="form-simple">
	  <tr class="strow">
		<td height="0"  colspan="4"><span style="font-size:10pt">&nbsp;</span></td>
	  </tr>
	  <tr class="strow">
		<td width="22%" height="0" ><span style="font-size:10pt">Remarks 備註 </span></td>
		<td height="0"  colspan="3"> <span style="font-size:10pt">
		<asp:Literal ID="remarks" runat="server"></asp:Literal>
		</span> 
		</td>
	  </tr>
		<tr class="strow">
		  <td height="0" ><span style="font-size:10pt">Remarks to EDF</span></td>
		  <td height="0"  colspan="3"> <span style="font-size:10pt">
		  <asp:Literal ID="remarks2EDF" runat="server"></asp:Literal>
		  </span> 
		  </td>
		</tr>
		<tr class="strow">
		  <td height="0" ><span style="font-size:10pt">Remarks 
			to PY Operation</span></td>
		  <td height="0"  colspan="3"> <span style="font-size:10pt">
		  <asp:Literal ID="remarks2PY" runat="server"></asp:Literal>
		  </span> 
		  </td>
		</tr>
	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt">Staff 
		  No </span></td>
		<td height="0" colspan="3" ><span style="font-size:10pt"><asp:Literal ID="staff_no" runat="server"></asp:Literal></span> 
		</td>
	  </tr>
	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt">Staff 
		  Name</span></td>
		<td height="0" colspan="3" ><span style="font-size:10pt"><asp:Literal ID="staff_name" runat="server"></asp:Literal></span></td>
	  </tr>
	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt">Teamcode</span></td>
		<td height="0" colspan="3" ><span style="font-size:10pt"><asp:Literal ID="teamcode" runat="server"></asp:Literal></span></td>
	  </tr>
	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt">Team 
		  Leader</span></td>
		<td height="0" colspan="3" ><span style="font-size:10pt"><asp:Literal ID="tl_name" runat="server"></asp:Literal></span></td>
	  </tr>
	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt">Salesman 
		  Code </span></td>
		<td height="0" colspan="3" ><span style="font-size:10pt"><asp:Literal ID="salesmancode" runat="server"></asp:Literal></span></td>
	  </tr>
	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt">Channel</span></td>
		<td height="0" colspan="3" ><span style="font-size:10pt"><asp:Literal ID="channel" runat="server"></asp:Literal></span></td>
	  </tr>
		<tr class="strow">
		  <td height="0" ><span style="font-size:10pt">Extn</span></td>
		  <td height="0" colspan="3" ><span style="font-size:10pt"><asp:Literal ID="extn" runat="server"></asp:Literal></span></td>
		</tr>
	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt">Refer Staff No</span></td>
		<td height="0" colspan="3" ><span style="font-size:10pt"><asp:Literal ID="ref_staff_no" runat="server"></asp:Literal></span></td>
	  </tr>
	  <tr class="strow">
		<td height="0" ><span style="font-size:10pt">Refer Salesman 
		  Code </span></td>
		<td height="0" colspan="3" ><span style="font-size:10pt"><asp:Literal ID="ref_salesmancode" runat="server"></asp:Literal></span></td>
	  </tr>
	  


          <tr class="strow">
              <td class="cat" colspan="5">
                  &nbsp;</td>
          </tr>

            </table>
            

            
            