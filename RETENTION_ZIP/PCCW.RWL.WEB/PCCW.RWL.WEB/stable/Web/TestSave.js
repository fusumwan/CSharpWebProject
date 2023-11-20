


function ErrorLog(e,num){
    var str="An exception occurred in the script. \n Error name: " + e.name+"\n";
    str+=". Error description: " + e.description+"\n";
    str+=". Error number: " + e.number+"\n";
    str+=". Error message: " + e.message+"\n";
    str+=". Error lineNumber: " +e.line+"\n";
    alert("num : "+ num+"\n"+str);
}

function test_save(ThisForm){
var bFlag=true;
var bShowError=true;



var ActionRequiredObj=document.getElementById('action_required');
var ActionRequired2Obj=document.getElementById('action_required2');
var HsModelObj=document.getElementById('hs_model');
var AmountObj = document.getElementById('amount');
var OrdPlaceByObj=document.getElementById('ord_place_by');
var StaffNameObj=document.getElementById('staff_name');
var D_DistrictObj=document.getElementById('d_district');



    //1
    if(bFlag){
        try{
            if (!ActionRequiredObj.checked && !ActionRequired2Obj.checked && !HsModelObj.value != "" && StaffNameObj.value == "" && document.getElementById('form1').extn.value == "" && document.getElementById('form1').salesmancode.value == "") {
	            alert ("NO Staff Info in EDF!\nOrder cannot be saved!\nPlease contact your UM!");
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,1);}
	        
	    }
	}
	//2
	if(bFlag){
	    try{
	        if(document.getElementById('form1').ref_staff_no.value!="" && document.getElementById('form1').ref_salesmancode.value==""){
		        alert ("Please check the salesmancode !");
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }
	    }
	    catch(e){
	        if(bShowError) { ErrorLog(e,2);}
	    }
	}//3
	if(bFlag){
	    try{
	        if(!document.getElementById('form1').easywatch_type[1].checked && document.getElementById('form1').cust_name.value==""){
		        alert ("Please Enter Customer Name!");
		        if(document.getElementById('form1').cust_name.style.display!="none" && document.getElementById('form1').cust_name.disabled==false){
		        //document.getElementById('form1').cust_name.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,3);}
	    }
	}//4
	
	if(bFlag){
	    try{
	        if(document.getElementById('form1').easywatch_type[1].checked && document.getElementById('form1').cust_name.value==""){
		        alert ("No Customer Name!\nPlease Copy Customer Name from standalone Order ID!");
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,4);}
	    }
	}//5
	if(bFlag){
	    try{
	        if(!document.getElementById('form1').easywatch_type[1].checked && document.getElementById("id_type").options[document.getElementById("id_type").selectedIndex].value==""){
		        alert ("Please Select ID Type!");
		        if(document.getElementById('form1').id_type.style.display!="none" && document.getElementById('form1').id_type.disabled==false){
		        //document.getElementById("id_type").focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,5);}
	    }
	}
	if(bFlag){
	    try{
	        if(!document.getElementById('form1').easywatch_type[1].checked && document.getElementById('form1').hkid.value.length==0){
		        alert ("Please Enter HKID/BR No./Passport No!");
		        if(document.getElementById('form1').hkid.style.display!="none" && document.getElementById('form1').hkid.disabled==false){
		       // document.getElementById('form1').hkid.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//7
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,7);}
	    }
	}
	if(bFlag){
	    try{
	        if(document.getElementById('form1').easywatch_type[1].checked && document.getElementById('form1').hkid.value.length==0){
		        alert ("No HKID/BR No./Passport No!\nPlease Copy HKID/BR No./Passport No from standalone Order ID!");
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//8
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,8);}
	    }
	}
	if(bFlag){
	    try{
	        if(!document.getElementById('form1').easywatch_type[1].checked && document.getElementById("id_type").options[document.getElementById("id_type").selectedIndex].value=="HKID" && document.getElementById('form1').hkid2.value.length==0){
		        alert ("Please Enter brackets of HKID!");
		        if(document.getElementById('form1').hkid2.style.display!="none" && document.getElementById('form1').hkid2.disabled==false){
		    //    document.getElementById('form1').hkid2.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//9
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,9);}
	    }
	}
	if(bFlag){
	    try{
	        if(!document.getElementById('form1').easywatch_type[1].checked && document.getElementById("id_type").options[document.getElementById("id_type").selectedIndex].value=="HKID" && !chk_hkid2(document.getElementById('form1').hkid.value+document.getElementById('form1').hkid2.value)){
		        document.getElementById('form1').hkid.value="";
		        if(document.getElementById('form1').hkid.style.display!="none" && document.getElementById('form1').hkid.disabled==false){
		       // document.getElementById('form1').hkid.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//10
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,10);}
	    }
	}
	if(bFlag){
	    try{
	        if(!document.getElementById('form1').easywatch_type[1].checked && document.getElementById("id_type").options[document.getElementById("id_type").selectedIndex].value=="BRNO" && document.getElementById('form1').hkid.value.match(/^\d{8}-\d{3}$/)==null){
		        document.getElementById('form1').hkid.value="";
		        if(document.getElementById('form1').hkid.style.display!="none" && document.getElementById('form1').hkid.disabled==false){
		      //  document.getElementById('form1').hkid.focus();
		        }
		        alert ("BR No.is not in a valid format.!");
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//11
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,11);}
	    }
	}
	if(bFlag){
	    try{
	        if(!chk_ac()){
	            if(document.getElementById('form1').ac_no.style.display!="none" && document.getElementById('form1').ac_no.disabled==false){
		       // document.getElementById('form1').ac_no.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//12
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,12);}
	    }
	}
	if(bFlag){
	    try{
	        if(document.getElementById('form1').mrt_no.value==""){
		        alert ("Please Enter MRT No!");
		        if(document.getElementById('form1').mrt_no.style.display!="none" && document.getElementById('form1').mrt_no.disabled==false){
		       // document.getElementById('form1').mrt_no.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//13
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,13);}
	    }
	}
	if(bFlag){
	    try{
	        if(document.getElementById('form1').bundle_name.value==""){
	            alert ("Please Enter Bundle Name!");
		        event.returnValue=false;
		        //document.getElementbyId('form1').submit2.disabled=false;
		        bFlag=false;
	        }//14
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,14);}
	    }
	}
	if(bFlag){
	    try{
	        if(document.getElementById('form1').trade_field.value==""){
	            alert ("Please Enter Trade Field!!");
		        event.returnValue=false;
		        //document.getElementbyId('form1').submit2.disabled=false;
		        bFlag=false;
	        }//15
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,15);}
	    }
	}
	if(bFlag){
	    try{
	        if(ActionRequiredObj.checked && !ActionRequired2Obj.checked && !document.getElementById('form1').waive_0.checked  && !document.getElementById('form1').waive_1.checked){
		        alert ("Please Select Waiving!");
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//16
	    }
	    catch(e){
	        if(bShowError) { ErrorLog(e,16);}

	    }
	}
	if(bFlag){
	    try{
	        if((ActionRequired2Obj.checked || ActionRequiredObj.checked) && document.getElementById('form1').exist_cust_plan.options[document.getElementById('form1').exist_cust_plan.selectedIndex].value==""){
		        alert ("Please Select Existing Customer Type!");
		        if(document.getElementById('form1').exist_cust_plan.style.display!="none" && document.getElementById('form1').exist_cust_plan.disabled==false){
		       // document.getElementById('form1').exist_cust_plan.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//17
	    }
	    catch(e){
	        if(bShowError) { ErrorLog(e,17);}
	    }
	}
	if(bFlag){
	    try{
	        if(document.getElementById('form1').gw_value.value!="1"){
	            if(document.getElementById('form1').org_fee.options[document.getElementById('form1').org_fee.selectedIndex].value=="" && !ActionRequired2Obj.checked){
		            alert ("Please Select Original Tariff Fee!");
		            if(document.getElementById('form1').org_fee.style.display!="none" && document.getElementById('form1').org_fee.disabled==false){
		         //   document.getElementById('form1').org_fee.focus();
		            }
		            event.returnValue=false;
		            document.getElementById('form1').submit2.disabled=false;
		            bFlag=false;
	            }
	            else if(document.getElementById('form1').ob_program_id.value=="" && document.getElementById("channel").value=="OB"){
				        alert ("Please Enter OB Program ID!");
				        if(document.getElementById('form1').ob_program_id.style.display!="none" && document.getElementById('form1').ob_program_id.disabled==false){
				     //   document.getElementById('form1').ob_program_id.focus();
				        }
				        event.returnValue=false;
				        document.getElementById('form1').submit2.disabled=false;
				        bFlag=false;
	            }
	            else if((document.getElementById('form1').existing_contract_end_month.value=="" ||document.getElementById('form1').existing_contract_end_year.value=="" )&& document.getElementById("channel").value=="OB" && !document.getElementById("org_ftg").checked){
				            alert ("Please Enter Existing Contract End Month!");
				            if(document.getElementById('form1').existing_contract_end_month.style.display!="none" && document.getElementById('form1').existing_contract_end_month.disabled==false){
				      //      document.getElementById('form1').existing_contract_end_month.focus();
				            }
				            event.returnValue=false;
				            document.getElementById('form1').submit2.disabled=false;
				            bFlag=false;
	            }
	        }//18
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,18);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if(ActionRequiredObj.checked && document.getElementById('form1').action_eff_date.value==""){
		        alert ("Please Enter Suspend Date!");
		        if(document.getElementById('form1').action_eff_date.style.display!="none" && document.getElementById('form1').action_eff_date.disabled==false){
		        //document.getElementById('form1').action_eff_date.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//19
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,19);}
	        
	    }
    }
	if(bFlag){
	    try{
	        if((ActionRequiredObj.checked && !vaild_sup_date())){

		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//20
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,20);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if(ActionRequiredObj.checked && document.getElementById('form1').reasons.value==""){
		        alert ("Please Select Suspend Reasons!");
		        if(document.getElementById('form1').reasons.style.display!="none" && document.getElementById('form1').reasons.disabled==false){
		       // document.getElementById('form1').reasons.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//21
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,21);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if(!ActionRequiredObj.checked && document.getElementById('form1').program.value=="" && !ActionRequired2Obj.checked){
		        alert ("Please Enter Program!");
		        if(document.getElementById('form1').program.style.display!="none" && document.getElementById('form1').program.disabled==false){
		       // document.getElementById('form1').program.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//22
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,22);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if(document.getElementById('form1').gw_value.value=="1"){
	            if(!ActionRequiredObj.checked && document.getElementById('form1').org_mrt.value=="" && document.getElementById('form1').submit_gw.disabled==true && !ActionRequired2Obj.checked){
		            alert ("Please Enter GO Wireless MRT NO.!");
		            
		            if(document.getElementById('form1').org_mrt.style.display!="none" && document.getElementById('form1').org_mrt.disabled==false){
		           // document.getElementById('form1').org_mrt.focus();
		            }
		            event.returnValue=false;
		            document.getElementById('form1').submit2.disabled=false;
		            bFlag=false;
	            }
	        }//23
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,23);}
	        
	    }
    }
	if(bFlag){
	    try{
	        if(!ActionRequiredObj.checked && document.getElementById('form1').program.value=="EASYWATCH BUNDLE" && !document.getElementById('form1').easywatch_type[0].checked && !document.getElementById('form1').easywatch_type[1].checked){
		        alert ("Please select EASYWATCH Type !");
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//24
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,24);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if(document.getElementById('form1').easywatch_type[1].checked && document.getElementById('form1').easywatch_ord_id.value==""){
		        alert ("Please Enter EASYWATCH Standalone order ID!");
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//25
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,25);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if(document.getElementById('form1').easywatch_ord_id.value!="" && document.getElementById('form1').check_easy_id.value!="true"){
		        alert ("Please Copy Customer Name and HKID from Standalone Order!");
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//26
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,26);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if(!ActionRequiredObj.checked && document.getElementById('form1').cust_staff_no.value=="" && (document.getElementById('form1').program.value=="STAFF OFFER" || document.getElementById('form1').program.value=="STAFF REFERRAL")){
		        alert ("Please Enter Customer Staff No !");
		        if(document.getElementById('form1').cust_staff_no.style.display!="none" && document.getElementById('form1').cust_staff_no.disabled==false){
		      //  document.getElementById('form1').cust_staff_no.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//27
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,27);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if(!ActionRequiredObj.checked && document.getElementById('form1').cust_staff_no.value!="" && document.getElementById('form1').check_sn_no.value=="false"){
		        alert ("Check Customer Staff No !");
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//28
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,28);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked )&& document.getElementById('form1').rate_plan.value==""){
		        alert ("Please Enter Rate Plan!");
		        if(document.getElementById('form1').rate_plan.style.display!="none" && document.getElementById('form1').rate_plan.disabled==false){
		      //  document.getElementById('form1').rate_plan.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//29
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,29);}
	        
	    }
    }
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && !document.getElementById('form1').normal_rebate_list_0.checked && !document.getElementById('form1').normal_rebate_list_1.checked && !document.getElementById('form1').normal_rebate_list_2.checked&& !document.getElementById('form1').normal_rebate_list_3.checked&& !document.getElementById('form1').normal_rebate_list_4.checked&& !document.getElementById('form1').normal_rebate_list_5.checked){
		        alert ("Please Select Retention /Retention+ /Loyal Retention+ /Special Retention/ T-5 Upselling/Sim Only T-5 Upselling !");
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//30
	    }
	   catch(e){

	        if(bShowError) { ErrorLog(e,30);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && document.getElementById('form1').con_per.value==""){
		        alert ("Please Enter Contract Period!");
		        if(document.getElementById('form1').con_per.style.display!="none" && document.getElementById('form1').con_per.disabled==false){
		     //   document.getElementById('form1').con_per.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//31
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,31);}
	        
	    }
	}
	if(bFlag){
	     try{
	         if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && (document.getElementById("rate_plan").value=="3GFTRIAL0098A" || document.getElementById("rate_plan").value=="3GFTRIAL0198A" || document.getElementById("rate_plan").value=="3GFTRIAL0298A") && (!document.getElementById('form1').accept_1.checked && !document.getElementById('form1').accept_0.checked)){
		        alert ("Please Select Autoroll !");
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//32
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,32);}
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && document.getElementById('form1').s_premium.value!="" && document.getElementById('form1').pos_ref_no.value=="") {
		        alert ("Please Enter POS Reference No!");
		        if(document.getElementById('form1').pos_ref_no.style.display!="none" && document.getElementById('form1').pos_ref_no.disabled==false){
		       // document.getElementById('form1').pos_ref_no.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//33
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,33);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && document.getElementById('form1').s_premium.value=="37 inch Sony LCD TV" && document.getElementById('form1').sp_ref_no.value=="") {
		        alert ("Please Enter Special Premium Quota Reference No!");
		        if(document.getElementById('form1').sp_ref_no.style.display!="none" && document.getElementById('form1').sp_ref_no.disabled==false){
		       // document.getElementById('form1').sp_ref_no.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//34
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,34);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && document.getElementById('form1').s_premium.value!="" && document.getElementById('form1').check_hkid.value=="false"){
		        alert ("Check HKID 1st!");
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//35
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,35);}
	        
	    }
    }
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && document.getElementById('form1').trade_field.value==""){
		        alert ("Please Enter Trade Field!");
		        if(document.getElementById('form1').trade_field.style.display!="none" && document.getElementById('form1').trade_field.disabled==false){
		     //   document.getElementById('form1').trade_field.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//36
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,36);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && document.getElementById('form1').bundle_name.value==""){
		        alert ("Please Enter Bundle Name!");
		        if(document.getElementById('form1').bundle_name.style.display!="none" && document.getElementById('form1').bundle_name.disabled==false){
		      //  document.getElementById('form1').bundle_name.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//37
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,37);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && document.getElementById('form1').normal_rebate_list_1.checked && document.getElementById('form1').lob.value==""){
		        alert ("Please Select LOB Type !");
		        if(document.getElementById('form1').lob.style.display!="none" && document.getElementById('form1').lob.disabled==false){
		      //  document.getElementById('form1').lob.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//38
	    }
	    catch(e){
	    

	        if(bShowError) { ErrorLog(e,38);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && document.getElementById('form1').normal_rebate_list_1.checked && (document.getElementById('form1').lob_ac.value=="" || document.getElementById('form1').lob_ac.value=="0")){
		        alert ("Please Enter LOB Account No !");
		        if(document.getElementById('form1').lob_ac.style.display!="none" && document.getElementById('form1').lob_ac.disabled==false){
		      //  document.getElementById('form1').lob_ac.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//39
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,39);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if(document.getElementById('form1').sku.value=="2420551" && document.getElementById('form1').rate_plan.value=="3GRETENT0298A" && document.getElementById('form1').program.value=="Mass Retention" ){
		        alert("SAMSUNG 32 INCH LCD TV only for 3GRETMRE0298A")
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//40
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,40);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && (document.getElementById('form1').gift_code.value=="2004191" || document.getElementById('form1').gift_code2.value=="2004191" || document.getElementById('form1').gift_code3.value=="2004191" || document.getElementById('form1').gift_code4.value=="2004191") && document.getElementById('form1').sku.value!="2401971" && document.getElementById('form1').sku.value!="2401981" && document.getElementById('form1').sku.value!="2402441" && document.getElementById('form1').sku.value!="2402451" ){
		        alert("Select HS E65! or Release PQI 2GB Pen Drive Free Gift")
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//41
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,41);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && document.getElementById('form1').gift_code.value!="" && document.getElementById('form1').gift_imei.value=="" ){
		        alert ("Get Free Gift Quota, Please!");
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//42
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,42);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && document.getElementById('form1').gift_code2.value!="" && document.getElementById('form1').gift_imei2.value=="" ){
		        alert ("Get Free Gift 2 Quota, Please!");
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//43
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,43);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && document.getElementById('form1').gift_code3.value!="" && document.getElementById('form1').gift_imei3.value=="" ){
		        alert ("Get Free Gift 3 Quota, Please!");
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//44
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,44);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && document.getElementById('form1').gift_code4.value!="" && document.getElementById('form1').gift_imei4.value=="" ){
		        alert ("Get Free Gift 4 Quota, Please!");
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//45
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,45);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && document.getElementById('form1').accessory_desc.value!="" && document.getElementById('form1').accessory_imei.value=="" ){
		        alert ("Get Accessory Quota, Please!");
		        if(document.getElementById('form1').accessory_desc.style.display!="none" && document.getElementById('form1').accessory_desc.disabled==false){
		      //  document.getElementById('form1').accessory_desc.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//46
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,46);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && document.getElementById('form1').con_eff_date.value==""  && !document.getElementById('form1').next_bill.checked){
		        alert ("Please Enter Contract Effective Date!");
		        if(document.getElementById('form1').con_eff_date.style.display!="none" && document.getElementById('form1').con_eff_date.disabled==false){
		     //   document.getElementById('form1').con_eff_date.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//47
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,47);}
	        
	    }
    }
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && !vaild_con_date()){
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//48
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,48);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && document.getElementById('form1').plan_eff_1.checked && document.getElementById('form1').plan_eff_date.value==""){
		        alert ("Please Enter Rate Plan Effective Date!");
		        if(document.getElementById('form1').plan_eff_date.style.display!="none" && document.getElementById('form1').plan_eff_date.disabled==false){
		     //   document.getElementById('form1').plan_eff_date.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//49
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,49);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if(!ActionRequiredObj.checked && !document.getElementById('form1').checked && !document.getElementById('form1').plan_eff_0.checked && !document.getElementById('form1').plan_eff_1.checked){ 
	            alert ("Please Enter Rate Plan Effective Date!");
	            event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//50
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,50);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && !vaild_plan_date()){
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//51
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,51);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if(document.getElementById('form1').fast_start.checked && !document.getElementById('form1').waive_0.checked && !document.getElementById('form1').waive_1.checked){
		        alert ("Please Select waiving!");
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//52
	    }
	   catch(e){

	        if(bShowError) { ErrorLog(e,52);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && HsModelObj.value!="" && document.getElementById('form1').sku.value==""){
		        alert ("Error! Sku Item Code is null! Please Select HS Model Again!!");
		        if(document.getElementById('form1').sku.style.display!="none" && document.getElementById('form1').sku.disabled==false){
		     //   document.getElementById('form1').sku.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//53
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,53);}
	        
	    }
	}
	if(bFlag){
	    try{

	        

	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked )  && OrdPlaceByObj.value.length==0){
		        alert ("Please Enter Order Place By!");
		        if(OrdPlaceByObj.style.display!="none" && OrdPlaceByObj.disabled==false){
		            //OrdPlaceByObj.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//54
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,54);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked )  && document.getElementById('form1').ord_place_rel.options[document.getElementById('form1').ord_place_rel.selectedIndex].value==""){
		        alert ("Please Select Relationship in Order Place Details!");
		        if(document.getElementById('form1').ord_place_rel.style.display!="none" && document.getElementById('form1').ord_place_rel.disabled==false){
		      //  document.getElementById('form1').ord_place_rel.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//55
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,55);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked )  && document.getElementById('form1').ord_place_id_type.options[document.getElementById('form1').ord_place_id_type.selectedIndex].value==""){
		        alert ("Please Select ID Type in Order Place Details!");
		        if(document.getElementById('form1').ord_place_id_type.style.display!="none" && document.getElementById('form1').ord_place_id_type.disabled==false){
		     //   document.getElementById('form1').ord_place_id_type.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//56
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,56);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked )  && document.getElementById('form1').ord_place_hkid.value.length==0){
		        alert ("Please Enter HKID/Passport No in Order Place Details!");
		        if(document.getElementById('form1').ord_place_hkid.style.display!="none" && document.getElementById('form1').ord_place_hkid.disabled==false){
		      //  document.getElementById('form1').ord_place_hkid.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//57
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,57);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked )  && document.getElementById('form1').ord_place_id_type.options[document.getElementById('form1').ord_place_id_type.selectedIndex].value=="HKID" && document.getElementById('form1').ord_place_hkid2.value.length==0){
		        alert ("Please Enter brackets of HKID in Order Place Details! ");
		        if(document.getElementById('form1').ord_place_hkid2.style.display!="none" && document.getElementById('form1').ord_place_hkid2.disabled==false){
		       // document.getElementById('form1').ord_place_hkid2.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//58
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,58);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked )  && document.getElementById('form1').ord_place_id_type.options[document.getElementById('form1').ord_place_id_type.selectedIndex].value=="HKID" && !chk_hkid2(document.getElementById('form1').ord_place_hkid.value+document.getElementById('form1').ord_place_hkid2.value)){
		        document.getElementById('form1').ord_place_hkid.value="";
		        if(document.getElementById('form1').ord_place_hkid.style.display!="none" && document.getElementById('form1').ord_place_hkid.disabled==false){
		      //  document.getElementById('form1').ord_place_hkid.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//59
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,59);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked )  && document.getElementById('form1').ord_place_tel.value==""){
		        alert ("Please Enter Contact No. in Order Place Details!");
		     //   document.getElementById('form1').ord_place_tel.focus();
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//60
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,60);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && HsModelObj.value!="" && D_DistrictObj.value=="") {
		        alert ("Please Enter Delivery Address!");
		        if(D_DistrictObj.style.display!="none" && D_DistrictObj.disabled==false){
		               //D_DistrictObj.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//61
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,61);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && HsModelObj.value!="" && !document.getElementById('form1').d_region_0.checked && !document.getElementById('form1').d_region_1.checked && !document.getElementById('form1').d_region_2.checked){
		        alert ("Please Enter Delivery Region!");
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//62
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,62);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && HsModelObj.value!="" && document.getElementById('form1').d_date.value==""){
		        alert ("Please Enter Delivery Date!");
     	        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//63
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,63);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && HsModelObj.value!="" && !vaild_date()){
		        event.returnValue=false;
		        
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//64
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,64);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && HsModelObj.value!="" && document.getElementById('form1').d_time.value==""){
		        alert ("Please Enter Delivery Time!");
		        if(document.getElementById('form1').d_time.style.display!="none" && document.getElementById('form1').d_time.disabled==false){
		      //  document.getElementById('form1').d_time.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//65
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,65);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && HsModelObj.value!="" && document.getElementById('form1').extra_d_charge.value==""){
		        alert ("Please Enter Delivery Charge for special region !");
		        if(document.getElementById('form1').extra_d_charge.style.display!="none" && document.getElementById('form1').extra_d_charge.disabled==false){
		      //  document.getElementById('form1').extra_d_charge.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//66
	    }
	   catch(e){

	        if(bShowError) { ErrorLog(e,66);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && HsModelObj.value!="" && document.getElementById('form1').contact_person.value==""){
		        alert ("Please Enter Contact Person!");
		        if(document.getElementById('form1').contact_person.style.display!="none" && document.getElementById('form1').contact_person.disabled==false){
		      //  document.getElementById('form1').contact_person.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//67
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,67);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && HsModelObj.value!="" && document.getElementById('form1').contact_no.value==""){
		        alert ("Please Enter Contact No. !");
		        if(document.getElementById('form1').contact_no.style.display!="none" && document.getElementById('form1').contact_no.disabled==false){
		       // document.getElementById('form1').contact_no.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//68
	    }
	    catch(e){
	
	        if(bShowError) { ErrorLog(e,68);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && HsModelObj.value!="" && document.getElementById('form1').pay_method.value==""){
		        alert ("Please Enter Payment Method!");
		        if(document.getElementById('form1').pay_method.style.display!="none" && document.getElementById('form1').pay_method.disabled==false){
		     //   document.getElementById('form1').pay_method.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//69
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,69);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && HsModelObj.value!="" && (document.getElementById('form1').pay_method.value=="CREDIT CARD" || document.getElementById('form1').pay_method.value=="CREDIT CARD INSTALLMENT") && document.getElementById('form1').card_type.value==""){
		        alert ("Please Enter Credit Card Type!");
		        if(document.getElementById('form1').card_type.style.display!="none" && document.getElementById('form1').card_type.disabled==false){
		      //  document.getElementById('form1').card_type.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//70
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,70);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && HsModelObj.value!="" && (document.getElementById('form1').pay_method.value=="CREDIT CARD" || document.getElementById('form1').pay_method.value=="CREDIT CARD INSTALLMENT") && (document.getElementById('form1').card_no1.value=="" || document.getElementById('form1').card_no2.value=="" || document.getElementById('form1').card_no3.value=="" || document.getElementById('form1').card_no4.value=="")){
		        alert ("Please Enter Credit Card No.!");
		        if(document.getElementById('form1').card_no1.style.display!="none" && document.getElementById('form1').card_no1.disabled==false){
		      //  document.getElementById('form1').card_no1.focus();
		        }
		        
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//71
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,71);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && HsModelObj.value!="" && (document.getElementById('form1').pay_method.value=="CREDIT CARD" || document.getElementById('form1').pay_method.value=="CREDIT CARD INSTALLMENT") && document.getElementById('form1').card_holder.value==""){
		        alert ("Please Enter Bank Account Holder Name!");
		        if(document.getElementById('form1').card_holder.style.display!="none" && document.getElementById('form1').card_holder.disabled==false){
		      //  document.getElementById('form1').card_holder.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//72
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,72);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && HsModelObj.value!="" && (document.getElementById('form1').pay_method.value=="CREDIT CARD" || document.getElementById('form1').pay_method.value=="CREDIT CARD INSTALLMENT") && (document.getElementById('form1').card_exp_year.value=="" || document.getElementById('form1').card_exp_month.value=="")){
		        alert ("Please Enter Credit Card Expiry Date!");
		        if(document.getElementById('form1').card_exp_month.style.display!="none" && document.getElementById('form1').card_exp_month.disabled==false){
		       // document.getElementById('form1').card_exp_month.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//73
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,73);}
	        
	    }
	}

	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && HsModelObj.value!="" && document.getElementById('form1').pay_method.value=="CREDIT CARD INSTALLMENT" && document.getElementById('form1').bank_code.value==""){
		        alert ("Please Select Bank Name!");
		        if(document.getElementById('form1').bank_code.style.display!="none" && document.getElementById('form1').bank_code.disabled==false){
		      //  document.getElementById('form1').bank_code.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//74
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,74);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if( (!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) &&   HsModelObj.value!=""   &&  AmountObj.value=="" ){
		        alert ("Please Enter Amount!");
		        if(AmountObj.style.display!="none" && AmountObj.disabled==false){
		       // AmountObj.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//75
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,75);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked ) && HsModelObj.value!="" && document.getElementById('form1').pay_method.value=="CREDIT CARD INSTALLMENT" && document.getElementById('form1').bank_code.value!="" && !vaild_amount()){
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//76
	    }
	    catch(e){
	        if(bShowError) { ErrorLog(e,76);}
	    }
	}

	if(bFlag){
	    try{
	       var HsModelSelect=HsModelObj.options[HsModelObj.selectedIndex].text;
	       var HsModelFlag=true;
	       switch(HsModelSelect){
	            case "PCCW-NOKIA 6120 CLASSIC - BLACK (512MB MICRO SD)":
	            HsModelFlag=false;
	            break;
	            case "PCCW-NOKIA 6120 CLASSIC - PINK (512MB MICRO SD)":
	            HsModelFlag=false;
	            break;
	            case "PCCW-NOKIA 6120 CLASSIC - WHITE (512MB MICRO SD)": 
	            HsModelFlag=false;
	            break;
	            case "AUTO NETWORK SELECTOR (ANS) - E180":
	            HsModelFlag=false;
	            break;
	            case "PCCW-SAMSUNG J208 WH": 
	            HsModelFlag=false;
	            break;
	            case "PCCW-SAMSUNG J208 SLIVER": 
	            HsModelFlag=false;
	            break;
	            case "PCCW-SONY ERI K530i THUNDER BK (256MB CARD)": 
	            HsModelFlag=false;
	            break;
	            case "PCCW-SONY ERI K530i WARM SL (256MB CARD)": 
	            HsModelFlag=false;
	            break; 
	            case  "PCCW-NOKIA 3120 CLASSIC GRAPHITE": 
	            HsModelFlag=false;
	            break; 
	            case "PCCW-NOKIA 3120 CLASSIC PLUM": 
	            HsModelFlag=false;
	            break; 
	            case "PCCW-SONY ERI K660I LIME ON WHITE (1GB CARD)": 
	            HsModelFlag=false;
	            break; 
	            case "PCCW-LG KT520 SILVER": 
	            HsModelFlag=false;
	            break; 
	            case "PCCW-NOKIA 6120 CLASSIC - BLACK (512MB MICRO SD)": 
	            HsModelFlag=false;
	            break; 
	            case "PCCW-NOKIA 6120 CLASSIC - WHITE (512MB MICRO SD)": 
	            HsModelFlag=false;
	            break; 
	            case "PCCW-NOKIA 6120 CLASSIC - PINK (512MB MICRO SD)": 
	            HsModelFlag=false;
	            break; 
	            case "PCCW-SONY ERI K660I WINE ON BLACK (1GB CARD)": 
	            HsModelFlag=false;
	            break; 
	            case "PCCW-NOKIA 3120 CLASSIC GRAPHITE": 
	            HsModelFlag=false;
	            break; 
	            case "PCCW-NOKIA 3120 CLASSIC PLUM":
	            HsModelFlag=false;
	            break; 
	            case "PCCW-SONY ERI K660I WINE ON BLACK (1GB CARD)": 
	            HsModelFlag=false;
	            break; 
	            case "PCCW-SONY ERI K660I LIME ON WHITE (1GB CARD)": 
	            HsModelFlag=false;
	            break; 
	            case "PCCW-NOKIA 6120 CLASSIC - PINK (512MB MICRO SD)": 
	            HsModelFlag=false;
	            break; 
	            case "PCCW-NOKIA 6120 CLASSIC - WHITE (512MB MICRO SD)": 
	            HsModelFlag=false;
	            break; 
	            case "PCCW-NOKIA 6120 CLASSIC - BLACK (512MB MICRO SD)": 
	            HsModelFlag=false;
	            break; 
	            case "PCCW-SONY ERI K660I WINE ON BLACK (1GB CARD)": 
	            HsModelFlag=false;
	            break; 
	            case "PCCW-SONY ERI K660I LIME ON WHITE (1GB CARD)": 
	            HsModelFlag=false;
	            break; 
	            case "PCCW-SONY ERI K660I WINE ON BLACK (1GB CARD)":
	            HsModelFlag=false;
	            break;  
	            case "PCCW-NOKIA 3120 CLASSIC GRAPHITE": 
	            HsModelFlag=false;
	            break; 
	            case "PCCW-NOKIA 3120 CLASSIC PLUM": 
	            HsModelFlag=false;
	            break; 
	            case "PCCW LG KP275 BLACK":
	            HsModelFlag=false;
	            break; 
	       }

	        if((!ActionRequiredObj.checked && !ActionRequired2Obj.checked )  &&  HsModelObj.value!=""  &&  HsModelFlag && (parseFloat(AmountObj.value)>="8000" || parseFloat(AmountObj.value)<="0")){
		        alert ("Amount should >$0 and <$8000");
		        if(AmountObj.style.display!="none" && AmountObj.disabled==false){
		       //     AmountObj.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//77

	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,77);}
	        
	    }
    }

	if(bFlag){
	     try{
	         if(!document.getElementById("action_required").checked && !document.getElementById("action_required2").checked && ( (document.getElementById("d_date").value=='24/12/2008' || document.getElementById("d_date").value=='31/12/2008') && (document.getElementById("d_time").value=='20-22' || document.getElementById("d_time").value=='18-20') ) ){
                alert("假期前夕"+document.getElementById("d_time").value+"這時段不設送貨");
                if(document.getElementById('form1').d_time.style.display!="none" && document.getElementById('form1').d_time.disabled==false){
	         //   document.getElementById("d_time").focus();
	            }
	            event.returnValue=false;
	            document.getElementById('form1').submit2.disabled=false;
	            bFlag=false;
	         }//78
	     }
	    catch(e){

	        if(bShowError) { ErrorLog(e,78);}
	        
	    }
	}

	if(bFlag){
	    try{
	        if(document.getElementById('form1').monthly_payment_method_1.checked==true && (document.getElementById('form1').m_card_no1.value=="" || document.getElementById('form1').m_card_no2.value=="" || document.getElementById('form1').m_card_no3.value=="" || document.getElementById('form1').m_card_no4.value=="")){
		        alert ("Please Enter Credit Card No.!");
		        if(document.getElementById('form1').m_card_no1.style.display!="none" && document.getElementById('form1').m_card_no1.disabled==false){
		      //  document.getElementById('form1').m_card_no1.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//79
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,79);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if(document.getElementById('form1').monthly_payment_method_1.checked==true && document.getElementById('form1').m_card_holder2.value==""){
		        alert ("Please Enter Bank Account Holder Name!");
		        if(document.getElementById('form1').m_card_holder2.style.display!="none" && document.getElementById('form1').m_card_holder2.disabled==false){
		      //  document.getElementById('form1').m_card_holder2.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//80
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,80);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if(document.getElementById('form1').monthly_payment_method_1.checked==true && (document.getElementById('form1').m_card_exp_year.value=="" || document.getElementById('form1').m_card_exp_month.value=="")){
		        alert ("Please Enter Credit Card Expiry Date!");
		        if(document.getElementById('form1').m_card_exp_month.style.display!="none" && document.getElementById('form1').m_card_exp_month.disabled==false){
		      //  document.getElementById('form1').m_card_exp_month.focus();
		        }
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//81
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,81);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if(document.getElementById('form1').bundle_name.value=="3GRET0138HSBUNDLE24M" && document.getElementById('form1').premium.options[document.getElementById('form1').premium.selectedIndex].value=="WELLCOME COUPON $800"&& document.getElementById('form1').sku.value==""){
		        alert ("Wrong Bundle Name with $800 Coupon~~!");
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//82
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,82);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if(document.getElementById('form1').bundle_name.value=="3GRET0198HSBundle18M" &&document.getElementById('form1').premium.options[document.getElementById('form1').premium.selectedIndex].value=="WELLCOME COUPON $800"&& document.getElementById('form1').sku.value==""){
		        alert ("Wrong Bundle Name with $800 Coupon~~!");
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//83
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,83);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if(document.getElementById('form1').bundle_name.value=="3GRET0298HSBundle18M" &&document.getElementById('form1').premium.options[document.getElementById('form1').premium.selectedIndex].value=="WELLCOME COUPON $200"&& document.getElementById('form1').sku.value==""){
		        alert ("Wrong Bundle Name with $200 Coupon~~!");
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//84
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,84);}
	        
	    }
	}
	if(bFlag){
	    try{
	        if(document.getElementById('form1').bundle_name.value=="3GRET0498HSBundle18M" &&document.getElementById('form1').premium.options[document.getElementById('form1').premium.selectedIndex].value=="WELLCOME COUPON $400"&& document.getElementById('form1').sku.value==""){
		        alert ("Wrong Bundle Name with $400 Coupon~~!");
		        event.returnValue=false;
		        document.getElementById('form1').submit2.disabled=false;
		        bFlag=false;
	        }//85
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,85);}
	        
	    }
	}
	if(bFlag){
	    try{
	       var GiftDesc1=document.getElementById('gift_desc1');
	       var PlanFee=document.getElementById('plan_fee');
	        if(GiftDesc1.options[GiftDesc1.selectedIndex].value=="SAMSUNG-HANDSOME-MOVIE EXCHANGE COUPON X2"){
	            var value = PlanFee.options[PlanFee.selectedIndex].value.replace("$","");
		        if(PlanFee.options[PlanFee.selectedIndex].value=="" || value<198){
		        alert ("此禮品優惠必須選購Samsung手機及同時使用$198或以上之月費計劃!");
		        event.returnValue=false;
		        document.getElementbyId('form1').submit2.disabled=false;
		        bFlag=false;
		        }
	        }//86
	    }
	    catch(e){

	        if(bShowError) { ErrorLog(e,86);}
	        
	    }
	}


	
	if(event.returnValue!=false && bFlag){
		if(confirm("Are you sure you want to Save?")==false){
			event.returnValue=false;
			document.getElementById('form1').submit2.disabled=false;
			
		}
		else{
			document.getElementById('form1').submit2.disabled=true;
			document.getElementById('form1').action="MobileRetentionOrderCreateImplement.aspx";
			for(i = 0; i<document.getElementById('form1').elements.length;i++){ 
			    document.getElementById('form1').elements[i].disabled=false;
			    document.getElementById('form1').elements[i].readOnly=false;
			}
			ThisForm.submit()
		}
	}
}