



/*****  End of Change pull down after select HS Model *****/

function chk_hs_sp2() {
    /*
    var HsModelObj = document.getElementById('hs_model');
    var AmountObj = document.getElementById('amount');
    var Spremium2Obj = document.getElementById('s_premium2');
    if (HsModelObj != undefined && AmountObj != undefined && Spremium2Obj != undefined) {
    if (HsModelObj.value == "PCCW-LG GU285 BK" && AmountObj.value == "0" && Spremium2Obj.value != '') { 
    alert("請注意: 若現有3G客戶已享用 LG GU285 $0 upfront 手機優惠，不可同時享用Family Pack 優惠。");
    }
    }
    */
}


/*****  Cooling Offer *****/
function click_cooling() {
    var CoolingOfferObj = document.getElementById('cooling_offer');
    if (CoolingOfferObj != undefined) {
        if (CoolingOfferObj.checked == true) {
            document.getElementById("snd_contract_effective_show").style.display = "inline";
        }
        else {
            document.getElementById("snd_contract_effective_show").style.display = "none";
        }
    }
}




function DRegionHiddenAutoSave() {
    var DRegionHidden = document.getElementById('d_region_hidden');
    var DRegionValue = GetRadioButtonListVal('d_region');
    if (DRegionHidden != undefined) {
        DRegionHidden.value = DRegionValue;
    }
}

function DRegionCheckAutoPostBack() {
    var DRegionHidden = document.getElementById('d_region_hidden');
    var DRegionValue = GetRadioButtonListVal("d_region");
    if (DRegionHidden != undefined) {

        if (DRegionHidden.value == null || DRegionValue == null) {
            event.returnValue = false;
            DistrictNoLoad();
        }

        var flag = (DRegionHidden.value == DRegionValue);
        if (flag == true) {

            event.returnValue = false;
            DistrictNoLoad();
        }
    }
}


var alertfunction = false;

function HidePlanFee() {
    if (document.getElementById('show_plan_fee') != undefined) {
        document.getElementById('show_plan_fee').style.display = "none";
    }
}
function ShowPlanFee() {
    if (document.getElementById('show_plan_fee') != undefined) {
        document.getElementById('show_plan_fee').style.display = "inline";
    }
}
function delivery_style(i) {
    //alertfunction
    if (alertfunction) { alert("delivery_style()"); }
    try {
        if (i == "yes") {
            /*
            if(document.getElementById('d_type') != undefined) document.getElementById('form1').d_type.disabled = false
            if(document.getElementById('d_room') != undefined) document.getElementById('form1').d_room.disabled = false
            if(document.getElementById('d_floor') != undefined) document.getElementById('form1').d_floor.disabled = false
            if(document.getElementById('d_blk') != undefined) document.getElementById('form1').d_blk.disabled = false
            if(document.getElementById('d_build') != undefined) document.getElementById('form1').d_build.disabled = false
            if(document.getElementById('d_street') != undefined) document.getElementById('form1').d_street.disabled = false
            if(document.getElementById('d_district') != undefined) document.getElementById('form1').d_district.disabled = false
            */

            //AspRadioButtonListEnable("d_region",true);

            //if(document.getElementById('d_region_0') != undefined) document.getElementById('form1').d_region_0.disabled = false
            //if(document.getElementById('d_region_1') != undefined) document.getElementById('form1').d_region_1.disabled = false
            //if(document.getElementById('d_region_2') != undefined) document.getElementById('form1').d_region_2.disabled = false
            //if(document.getElementById('d_region_3') != undefined) document.getElementById('form1').d_region_3.disabled = false
            if (document.getElementById('d_address') != undefined) document.getElementById('form1').d_address.disabled = false;
            if (document.getElementById('d_date') != undefined) document.getElementById('form1').d_date.disabled = false;
            // if(document.getElementById('d_date_Day_ID') != undefined) document.getElementById('form1').d_date_Day_ID.disabled = false
            // if(document.getElementById('d_date_Month') != undefined) document.getElementById('form1').d_date_Month.disabled = false
            // if(document.getElementById('d_date_Year_ID') != undefined) document.getElementById('form1').d_date_Year_ID.disabled = false


            if (document.getElementById('d_time') != undefined) document.getElementById('form1').d_time.disabled = false
            if (document.getElementById('extra_d_charge') != undefined) document.getElementById('form1').extra_d_charge.disabled = false
            if (document.getElementById('contact_person') != undefined) document.getElementById('form1').contact_person.disabled = false
            if (document.getElementById('contact_no') != undefined) document.getElementById('form1').contact_no.disabled = false
            if (document.getElementById('ext_place_tel') != undefined) document.getElementById('form1').ext_place_tel.disabled = false;
            if (document.getElementById('pay_method') != undefined) document.getElementById('form1').pay_method.disabled = false
            if (document.getElementById('remarks2EDF') != undefined) document.getElementById('form1').remarks2EDF.disabled = false
            if (document.getElementById('r_offer4') != undefined) document.getElementById('form1').r_offer4.disabled = false
            if (document.getElementById('rebate_amount4') != undefined) document.getElementById('form1').rebate_amount4.disabled = false

            /*
            if(document.getElementById('d_type') != undefined) document.getElementById('form1').d_type.style.background="#FFFFFF";
            if(document.getElementById('d_room') != undefined) document.getElementById('form1').d_room.style.background="#FFFFFF";
            if(document.getElementById('d_floor') != undefined) document.getElementById('form1').d_floor.style.background="#FFFFFF";
            if(document.getElementById('d_blk') != undefined) document.getElementById('form1').d_blk.style.background="#FFFFFF";
            if(document.getElementById('d_build') != undefined) document.getElementById('form1').d_build.style.background="#FFFFFF";
            if(document.getElementById('d_street') != undefined) document.getElementById('form1').d_street.style.background="#FFFFFF";
            if(document.getElementById('d_district') != undefined) document.getElementById('form1').d_district.style.background="#FFFFbb";
		           
				   
		           if(document.getElementsByName('d_region') != undefined){
            var d_region=document.getElementsByName("d_region");
            for(i =0 ; i < d_region.length;i++){
            d_region[i].style.background="#FFFFbb";
            }
            }
            */

            //if(document.getElementById('d_region_0') != undefined) document.getElementById('form1').d_region_0.style.background="#FFFFbb";
            //if(document.getElementById('d_region_1') != undefined) document.getElementById('form1').d_region_1.style.background="#FFFFbb";
            //if(document.getElementById('d_region_2') != undefined) document.getElementById('form1').d_region_2.style.background="#FFFFbb";
            //if(document.getElementById('d_region_3') != undefined) document.getElementById('form1').d_region_3.style.background="#FFFFbb";

            if (document.getElementById('d_date') != undefined) document.getElementById('form1').d_date.style.background = "#FFFFbb";

            //if(document.getElementById('d_date_Day_ID') != undefined) document.getElementById('form1').d_date_Day_ID.style.background="#FFFFbb";
            //if(document.getElementById('d_date_Month') != undefined) document.getElementById('form1').d_date_Month.style.background="#FFFFbb";
            //if(document.getElementById('d_date_Year_ID') != undefined) document.getElementById('form1').d_date_Year_ID.style.background="#FFFFbb";


            if (document.getElementById('d_time') != undefined) document.getElementById('form1').d_time.style.background = "#FFFFbb";
            if (document.getElementById('extra_d_charge') != undefined) document.getElementById('form1').extra_d_charge.style.background = "#FFFFbb";
            if (document.getElementById('contact_person') != undefined) document.getElementById('form1').contact_person.style.background = "#FFFFbb";
            if (document.getElementById('contact_no') != undefined) document.getElementById('form1').contact_no.style.background = "#FFFFbb";
            if (document.getElementById('ext_place_tel') != undefined) document.getElementById('form1').ext_place_tel.style.background = "#FFFFbb";
            if (document.getElementById('pay_method') != undefined) document.getElementById('form1').pay_method.style.background = "#FFFFbb";
            if (document.getElementById('amount') != undefined) document.getElementById('form1').amount.style.background = "#FFFFbb";
            if (document.getElementById('remarks2EDF') != undefined) document.getElementById('form1').remarks2EDF.style.background = "#FFFFFF";

        }
        else if (i == "no") {
            /*
            if(document.getElementById('d_type') != undefined) document.getElementById('form1').d_type.value = ""
            if(document.getElementById('d_room') != undefined) document.getElementById('form1').d_room.value = ""
            if(document.getElementById('d_floor') != undefined) document.getElementById('form1').d_floor.value = ""
            if(document.getElementById('d_blk') != undefined) document.getElementById('form1').d_blk.value = ""
            if(document.getElementById('d_build') != undefined) document.getElementById('form1').d_build.value = ""
            if(document.getElementById('d_street') != undefined) document.getElementById('form1').d_street.value = ""
            if(document.getElementById('d_district') != undefined) document.getElementById('form1').d_district.value = ""
		            
            if(document.getElementsByName('d_region') != undefined){
            var d_region=document.getElementsByName("d_region");
            for(i =0 ; i < d_region.length;i++){
            d_region[i].checked=false;
            }
            }
            */
            //if(document.getElementById('d_region_0') != undefined) document.getElementById('form1').d_region_0.checked = false
            //if(document.getElementById('d_region_1') != undefined) document.getElementById('form1').d_region_1.checked = false
            //if(document.getElementById('d_region_2') != undefined) document.getElementById('form1').d_region_2.checked = false
            //if(document.getElementById('d_region_3') != undefined) document.getElementById('form1').d_region_3.checked = false
            if (document.getElementById('d_address') != undefined) document.getElementById('form1').d_address.value = "";
            if (document.getElementById('d_time') != undefined) document.getElementById('form1').d_time.value = ""
            if (document.getElementById('extra_d_charge') != undefined) document.getElementById('form1').extra_d_charge.value = ""
            if (document.getElementById('contact_person') != undefined) document.getElementById('form1').contact_person.value = ""
            if (document.getElementById('contact_no') != undefined) document.getElementById('form1').contact_no.value = ""
            if (document.getElementById('ext_place_tel') != undefined) document.getElementById('form1').ext_place_tel.value = ""
            if (document.getElementById('pay_method') != undefined) document.getElementById('form1').pay_method.value = ""
            if (document.getElementById('remarks2EDF') != undefined) document.getElementById('form1').remarks2EDF.value = ""

            /*
            if(document.getElementById('d_type') != undefined) document.getElementById('form1').d_type.disabled =true;
            if(document.getElementById('d_room') != undefined) document.getElementById('form1').d_room.disabled = true;
            if(document.getElementById('d_floor') != undefined) document.getElementById('form1').d_floor.disabled = true;
            if(document.getElementById('d_blk') != undefined) document.getElementById('form1').d_blk.disabled = true;
            if(document.getElementById('d_build') != undefined) document.getElementById('form1').d_build.disabled = true;
            if(document.getElementById('d_street') != undefined) document.getElementById('form1').d_street.disabled = true;
            if(document.getElementById('d_district') != undefined) document.getElementById('form1').d_district.disabled = true;
		            
            AspRadioButtonListEnable("d_region",false);
            */
            // if(document.getElementById('d_region_0') != undefined) document.getElementById('form1').d_region_0.disabled = true;
            // if(document.getElementById('d_region_1') != undefined) document.getElementById('form1').d_region_1.disabled = true;
            // if(document.getElementById('d_region_2') != undefined) document.getElementById('form1').d_region_2.disabled = true;
            // if(document.getElementById('d_region_3') != undefined) document.getElementById('form1').d_region_3.disabled = true;
            if (document.getElementById('d_address') != undefined) document.getElementById('form1').d_address.disabled = true;
            if (document.getElementById('d_date') != undefined) document.getElementById('form1').d_date.disabled = true;

            //if(document.getElementById('d_date_Day_ID') != undefined) document.getElementById('form1').d_date_Day_ID.disabled = true;
            //if(document.getElementById('d_date_Month') != undefined) document.getElementById('form1').d_date_Month.disabled = true;
            //if(document.getElementById('d_date_Year_ID') != undefined) document.getElementById('form1').d_date_Year_ID.disabled = true;

            if (document.getElementById('d_time') != undefined) document.getElementById('form1').d_time.disabled = true;
            if (document.getElementById('extra_d_charge') != undefined) document.getElementById('form1').extra_d_charge.disabled = true;
            if (document.getElementById('contact_person') != undefined) document.getElementById('form1').contact_person.disabled = true
            if (document.getElementById('contact_no') != undefined) document.getElementById('form1').contact_no.disabled = true
            if (document.getElementById('ext_place_tel') != undefined) document.getElementById('form1').ext_place_tel.disabled = true
            if (document.getElementById('pay_method') != undefined) document.getElementById('form1').pay_method.disabled = true
            if (document.getElementById('remarks2EDF') != undefined) document.getElementById('form1').remarks2EDF.disabled = true

            /*
            if(document.getElementById('d_type') != undefined) document.getElementById('form1').d_type.style.background="#DDDDDD";
            if(document.getElementById('d_room') != undefined) document.getElementById('form1').d_room.style.background="#DDDDDD";
            if(document.getElementById('d_floor') != undefined) document.getElementById('form1').d_floor.style.background="#DDDDDD";
            if(document.getElementById('d_blk') != undefined) document.getElementById('form1').d_blk.style.background="#DDDDDD";
            if(document.getElementById('d_build') != undefined) document.getElementById('form1').d_build.style.background="#DDDDDD";
            if(document.getElementById('d_street') != undefined) document.getElementById('form1').d_street.style.background="#DDDDDD";
		            
		            
            if(document.getElementsByName('d_region') != undefined){
            var d_region=document.getElementsByName("d_region");
            for(i =0 ; i < d_region.length;i++){
            d_region[i].style.background="#DDDDDD";
            }
            }
            */
            //if(document.getElementById('d_region_0') != undefined) document.getElementById('form1').d_region_0.style.background="#DDDDDD";
            // if(document.getElementById('d_region_1') != undefined) document.getElementById('form1').d_region_1.style.background="#DDDDDD";
            // if(document.getElementById('d_region_2') != undefined) document.getElementById('form1').d_region_2.style.background="#DDDDDD";
            //if(document.getElementById('d_region_3') != undefined) document.getElementById('form1').d_region_3.style.background="#DDDDDD";


            //if(document.getElementById('d_district') != undefined) document.getElementById('form1').d_district.style.background="#DDDDDD";

            if (document.getElementById('d_date') != undefined) document.getElementById('form1').d_date.style.background = "#DDDDDD";

            //if(document.getElementById('d_date_Day_ID') != undefined) document.getElementById('form1').d_date_Day_ID.style.background="#DDDDDD";
            //if(document.getElementById('d_date_Month') != undefined) document.getElementById('form1').d_date_Month.style.background="#DDDDDD";
            //if(document.getElementById('d_date_Year_ID') != undefined) document.getElementById('form1').d_date_Year_ID.style.background="#DDDDDD";
            if (document.getElementById('d_time') != undefined) document.getElementById('form1').d_time.style.background = "#DDDDDD";
            if (document.getElementById('extra_d_charge') != undefined) document.getElementById('form1').extra_d_charge.style.background = "#DDDDDD";
            if (document.getElementById('contact_person') != undefined) document.getElementById('form1').contact_person.style.background = "#DDDDDD";
            if (document.getElementById('contact_no') != undefined) document.getElementById('form1').contact_no.style.background = "#DDDDDD";
            if (document.getElementById('ext_place_tel') != undefined) document.getElementById('form1').ext_place_tel.style.background = "#DDDDDD";
            if (document.getElementById('pay_method') != undefined) document.getElementById('form1').pay_method.style.background = "#DDDDDD";
            if (document.getElementById('amount') != undefined) document.getElementById('form1').amount.style.background = "#FFFFFF";
            if (document.getElementById('remarks2EDF') != undefined) document.getElementById('form1').remarks2EDF.style.background = "#DDDDDD";

        }
    } catch (e) {
        alert(e);
    }


}

function LoadGetSimMrt() {
    if (document.getElementById("load_get_sim_mrt") != undefined) document.getElementById("load_get_sim_mrt").style.display = "inline";
}

function NoLoadGetSimMrt() {
    if (document.getElementById("load_get_sim_mrt") != undefined) document.getElementById("load_get_sim_mrt").style.display = "none";
}

function LoadChkGW() {
    document.getElementById("load_go_wireless").style.display = "inline";
    document.getElementById("submit_gw").disabled = true;
    document.getElementById("org_mrt").readOnly = true;
}
function NoLoadChkGW() {
    document.getElementById("load_go_wireless").style.display = "none";
    document.getElementById("submit_gw").disabled = false;
    document.getElementById("org_mrt").readOnly = false;
}

function HiddenTier() {
    if (document.getElementById('tier_show') != undefined) document.getElementById('tier_show').style.display = 'none';
}

function ShowTier() {
    if (document.getElementById('tier_show') != undefined) document.getElementById('tier_show').style.display = 'inline';
}


function CheckExistingDate() {

    var today = new Date();
    var eMonth = document.getElementById("existing_contract_end_month").value;
    var eYear = document.getElementById("existing_contract_end_year").value;



    var eMonthNum = 0;
    var eYearNum = parseInt(eYear,10);
    var chkDate = new Date();
    var flag = false;
    switch (eMonth) {
        case "JAN":
            eMonthNum = 0;
            break;
        case "FEB":
            eMonthNum = 1;
            break;
        case "MAR":
            eMonthNum = 2;
            break;
        case "APR":
            eMonthNum = 3;
            break;
        case "MAY":
            eMonthNum = 4;
            break;
        case "JUN":
            eMonthNum = 5;
            break;
        case "JUL":
            eMonthNum = 6;
            break;
        case "AUG":
            eMonthNum = 7;
            break;
        case "SEP":
            eMonthNum = 8;
            break;
        case "OCT":
            eMonthNum = 9;
            break;
        case "NOV":
            eMonthNum = 10;
            break;
        case "DEC":
            eMonthNum = 11;
            break;
        default:
            eMonthNum = 99;
            break;
    }


    if (eMonthNum < today.getMonth() && eYearNum < today.getFullYear()) {
        flag = true;
    }
    else if (eMonthNum < today.getMonth() && eYearNum == today.getFullYear()) {
        flag = true;
    }
    else if (eMonthNum != 99 && eYearNum < today.getFullYear()) {
        flag = true;
    }

    if (flag) {

        document.getElementById("existing_contract_end_month").selectedIndex = 0;
        document.getElementById("existing_contract_end_year").selectedIndex = 0;
        document.getElementById("existing_contract_end_month").value = "";
        document.getElementById("existing_contract_end_year").value = "";
        alert("如客戶現有之合約已經過期, 只需要選擇 FTG (Free-To-Go) 而不需選擇合約到期月份.");
    }
}



function Xmas() {
    if (document.getElementById("d_date").value == '') {
        alert("Please Select Delivery Date First");
        document.getElementById("d_time").value = "";
    }
    else if ((document.getElementById("d_date").value == '24/12/2008' || document.getElementById("d_date").value == '31/12/2008') && (document.getElementById("d_time").value == '20-22' || document.getElementById("d_time").value == '18-20')) {
        alert("假期前夕" + document.getElementById("d_time").value + "這時段不設送貨");
        document.getElementById("d_time").value = "";
    }
}


/*****  MCAM Bundle Rebate *****/
function ch_mcam(action) {
    if (action == "enable") {
        document.getElementById("mcam_vas1").disabled = false
        document.getElementById("mcam_vas").disabled = false
    }
    else {
        document.getElementById("mcam_vas1").value = "";
        document.getElementById("mcam_vas1").disabled = true
        document.getElementById("mcam_vas").value = "NO";
        document.getElementById("mcam_vas").disabled = true
    }
}
//-------------------  End of Hard Code in VAS selection ------------------//

function LoadDDistrictTime() {
    if (document.getElementById('load_d_district_time') != undefined) document.getElementById('load_d_district_time').style.display = "inline";
}

function NoLoadDDistrictTime() {
    if (document.getElementById('load_d_district_time') != undefined) document.getElementById('load_d_district_time').style.display = "none";
}



//-------------------  Offer Selection Control -------------------//

function DistrictNoLoad() {
    document.getElementById('form1').d_district_loading.style.display = "none"
    document.getElementById('form1').d_region.disabled = false;
}
function DistrictLoad() {
    document.getElementById('form1').d_district_loading.style.display = "inline"
    document.getElementById('form1').d_region.disabled = true;
}



/*****  Change pull down after select Contract Period *****/

function PlanFeeNoLoad() {

    document.getElementById('form1').load_plan_fee.style.display = "none"
    document.getElementById('form1').plan_fee.disabled = false;
}
function PlanFeeLoad() {
    document.getElementById('form1').load_plan_fee.style.display = "inline"
    document.getElementById('form1').plan_fee.disabled = true;
}


function TierNoLoad() {
    document.getElementById('form1').load_tier.style.display = "none"
    document.getElementById('form1').tier.disabled = false;
}
function TierLoad() {
    document.getElementById('form1').load_tier.style.display = "inline"
    document.getElementById('form1').tier.disabled = true;
}



function HsListNoLoad() {
    document.getElementById('form1').load_con.style.display = "none"
    document.getElementById('form1').con_per.disabled = false;
}
function HsListLoad() {
    document.getElementById('form1').load_con.style.display = "inline"
    document.getElementById('form1').con_per.disabled = true;
}
/***** End of Change pull down after select Contract Period *****/


/***** Change pull down after select Rebate ******/
function TradeRListNoLoad() {
    document.getElementById('form1').load_rebate.style.display = "none"
    document.getElementById('form1').rebate.disabled = false;
}
function TradeRListLoad() {
    document.getElementById('form1').load_rebate.style.display = "inline"
    document.getElementById('form1').rebate.disabled = true;
}
/*****  End of Change pull down after select Rebate *****/



/*****  End of Change pull down after select Free Monthly Fee *****/
function TradeFListNoLoad() {
    document.getElementById('form1').load_free.style.display = "none"
    document.getElementById('form1').free_mon.disabled = false;
}
function TradeFListLoad() {
    document.getElementById('form1').load_free.style.display = "inline"
    document.getElementById('form1').free_mon.disabled = true;
}
/*****  End of Change pull down after select Free Monthly Fee *****/


/*****  End of Change pull down after select HS Model *****/
function TradeHsListNoLoad() {
    document.getElementById('form1').load_hs.style.display = "none"
    document.getElementById('form1').hs_model.disabled = false;
}
function TradeHsListLoad() {
    document.getElementById('form1').load_hs.style.display = "inline"
    document.getElementById('form1').hs_model.disabled = true;
}
/*****  End of Change pull down after select HS Model *****/


/***** End of Change pull down after select Payment Method *****/
function TradePayListNoLoad() {
    document.getElementById('form1').load_pay.style.display = "none"
    document.getElementById('form1').pay_method.disabled = false;
}
function TradePayListLoad() {
    document.getElementById('form1').load_pay.style.display = "inline"
    document.getElementById('form1').pay_method.disabled = true;
}
/*****  End of Change pull down after select Payment Method *****/


/***** End of Change pull down after select Premium *****/
function TradePmuListNoLoad() {
    document.getElementById('form1').load_pmu.style.display = "none"
    document.getElementById('form1').premium.disabled = false;
}
function TradePmuListLoad() {
    document.getElementById('form1').load_pmu.style.display = "inline"
    document.getElementById('form1').premium.disabled = true;
}

/*****  End of Change pull down after select Premium *****/

/***** Change pull down after select Rate Plan *****/
function ConListNoLoad() {
    document.getElementById('form1').load_plan.style.display = "none"
    document.getElementById('form1').rate_plan.disabled = false;
}

function ConListLoad() {
    document.getElementById('form1').load_plan.style.display = "inline"
    document.getElementById('form1').rate_plan.disabled = true;
}
/*****  End of Change pull down after select Rate Plan *****/


/***** Change pull down after select Program / Retention Type *****/
function PlanListNoLoad() {
    document.getElementById('form1').load_program.style.display = "none"
    document.getElementById('form1').program.disabled = false;
}
function PlanListLoad() {
    document.getElementById('form1').load_program.style.display = "inline"
    document.getElementById('form1').program.disabled = true;
}

function NormalPlanListLoad() {
    PlanListLoad();
    setTimeout("PlanListNoLoad();", 1000);
}
/***** End of Change pull down after select Program / Retention Type *****/


//---------------------------  End of Offer Selection Control -----------------------------//

/*****  Change pull down after select Existing Customer Type ****/

function OrgFeeListNoLoad() {
    document.getElementById('form1').load_org_fee.style.display = "none"
    document.getElementById('form1').exist_cust_plan.disabled = false;
}
function OrgFeeListLoad() {
    document.getElementById('form1').load_org_fee.style.display = "inline"
    document.getElementById('form1').exist_cust_plan.disabled = true;
}

/*****  End of Change pull down after select Existing Customer Type *****/




//---------------- Clear Pull down -------------------//

function c_all() {
    if (document.getElementById('program') != undefined) document.getElementById('form1').program.value = ""
    if (document.getElementById('normal_rebate_type') != undefined) document.getElementById('normal_rebate_type').selectedIndex = 0;

    if (document.getElementById('rate_plan') != undefined) document.getElementById('form1').rate_plan.value = ""
    if (document.getElementById('accept_0') != undefined) document.getElementById('form1').accept_0.checked = false
    if (document.getElementById('accept_1') != undefined) document.getElementById('form1').accept_1.checked = false
    if (document.getElementById('con_per') != undefined) document.getElementById('form1').con_per.value = ""
    if (document.getElementById('rebate') != undefined) document.getElementById('form1').rebate.value = ""
    if (document.getElementById('free_mon') != undefined) document.getElementById('form1').free_mon.value = ""
    if (document.getElementById('lob') != undefined) document.getElementById('form1').lob.value = ""
    if (document.getElementById('lob_ac') != undefined) document.getElementById('form1').lob_ac.value = ""
    if (document.getElementById('go_wireless_package_code') != undefined) document.getElementById('form1').go_wireless_package_code.value = ""
    if (document.getElementById('hs_model') != undefined) document.getElementById('form1').hs_model.value = ""
    if (document.getElementById('premium') != undefined) document.getElementById('form1').premium.value = ""
    if (document.getElementById('sku') != undefined) document.getElementById('form1').sku.value = ""
    if (document.getElementById('sim_item_name1') != undefined) document.getElementById('form1').sim_item_name1.value = ""

    if (document.getElementById('trade_field') != undefined) document.getElementById('form1').trade_field.value = ""
    if (document.getElementById('bundle_name') != undefined) document.getElementById('form1').bundle_name.value = ""
    if (document.getElementById('m_rebate_amount') != undefined) document.getElementById('form1').m_rebate_amount.value = ""
    if (document.getElementById('rebate_amount') != undefined) document.getElementById('form1').rebate_amount.value = ""
    if (document.getElementById('r_offer') != undefined) document.getElementById('form1').r_offer.value = ""
    if (document.getElementById('extra_rebate_amount') != undefined) document.getElementById('form1').extra_rebate_amount.value = ""
    if (document.getElementById('extra_rebate') != undefined) document.getElementById('form1').extra_rebate.value = ""
    if (document.getElementById('cancel_renew_0') != undefined) document.getElementById('form1').cancel_renew_0.checked = false
    if (document.getElementById('cancel_renew_1') != undefined) document.getElementById('form1').cancel_renew_1.checked = false
    if (document.getElementById('gift_desc') != undefined) document.getElementById('form1').gift_desc.value = ""
    if (document.getElementById('gift_code') != undefined) document.getElementById('form1').gift_code.value = ""
    if (document.getElementById('gift_imei') != undefined) document.getElementById('form1').gift_imei.value = ""
    if (document.getElementById('gift_desc2') != undefined) document.getElementById('form1').gift_desc2.value = ""
    if (document.getElementById('gift_code2') != undefined) document.getElementById('form1').gift_code2.value = ""
    if (document.getElementById('gift_imei2') != undefined) document.getElementById('form1').gift_imei2.value = ""
    if (document.getElementById('accessory_desc') != undefined) document.getElementById('form1').accessory_desc.value = ""
    if (document.getElementById('accessory_code') != undefined) document.getElementById('form1').accessory_code.value = ""
    if (document.getElementById('accessory_imei') != undefined) document.getElementById('form1').accessory_imei.value = ""
    if (document.getElementById('accessory_price') != undefined) document.getElementById('form1').accessory_price.value = ""
    if (document.getElementById('now_vas') != undefined) document.getElementById('form1').now_vas.value = "NO"
    if (document.getElementById('foot_vas') != undefined) document.getElementById('form1').foot_vas.value = "NO"
    if (document.getElementById('fin_vas') != undefined) document.getElementById('form1').fin_vas.value = "NO"
    if (document.getElementById('horse_vas') != undefined) document.getElementById('form1').horse_vas.value = "NO"
    if (document.getElementById('moov_vas') != undefined) document.getElementById('form1').moov_vas.value = "NO"
    if (document.getElementById('gprs_vas') != undefined) document.getElementById('form1').gprs_vas[0].value = "NO"
    if (document.getElementById('gprs_vas') != undefined) document.getElementById('form1').gprs_vas[1].value = ""
    if (document.getElementById('wifi_vas') != undefined) document.getElementById('form1').wifi_vas.value = "NO"
    if (document.getElementById('sms_vas') != undefined) document.getElementById('form1').sms_vas[0].value = "NO"
    if (document.getElementById('sms_vas') != undefined) document.getElementById('form1').sms_vas[1].value = ""
    if (document.getElementById('msn_vas') != undefined) document.getElementById('form1').msn_vas.value = "NO"
    if (document.getElementById('ct_vas') != undefined) document.getElementById('form1').ct_vas.value = "NO"
    if (document.getElementById('min_vas') != undefined) document.getElementById('form1').min_vas.value = "NO"
    if (document.getElementById('license_waiver') != undefined) document.getElementById('form1').license_waiver.value = "NO"
    if (document.getElementById('fast_start') != undefined) document.getElementById('form1').fast_start.checked = false
    if (document.getElementById('pcd_paid_go_wireless') != undefined) document.getElementById('form1').pcd_paid_go_wireless.checked = false

    if (document.getElementById('plan_eff_date') != undefined) document.getElementById('form1').plan_eff_date.value = ""
    if (document.getElementById('con_eff_date') != undefined) document.getElementById('form1').con_eff_date.value = ""
    if (document.getElementById('pos_ref_no') != undefined) document.getElementById('form1').pos_ref_no.value = ""
    if (document.getElementById('ord_place_by') != undefined) document.getElementById('form1').ord_place_by.value = ""
    if (document.getElementById('ord_place_rel') != undefined) document.getElementById('form1').ord_place_rel.value = ""
    if (document.getElementById('ord_place_id_type') != undefined) document.getElementById('form1').ord_place_id_type.value = ""
    if (document.getElementById('ord_place_hkid') != undefined) document.getElementById('form1').ord_place_hkid.value = ""
    if (document.getElementById('ord_place_hkid2') != undefined) document.getElementById('form1').ord_place_hkid2.value = ""
    if (document.getElementById('ord_place_tel') != undefined) document.getElementById('form1').ord_place_tel.value = ""
    if (document.getElementById('d_time') != undefined) document.getElementById('form1').d_time.value = ""
    if (document.getElementById('contact_person') != undefined) document.getElementById('form1').contact_person.value = ""
    if (document.getElementById('contact_no') != undefined) document.getElementById('form1').contact_no.value = ""
    if (document.getElementById('ext_place_tel') != undefined) document.getElementById('form1').ext_place_tel.value = ""
    if (document.getElementById('pay_method') != undefined) document.getElementById('form1').pay_method.value = ""
    if (document.getElementById('card_type') != undefined) document.getElementById('form1').card_type.value = ""
    if (document.getElementById('card_holder') != undefined) document.getElementById('form1').card_holder.value = ""
    if (document.getElementById('bank_code') != undefined) document.getElementById('form1').bank_code.value = ""
    if (document.getElementById('amount') != undefined) document.getElementById('form1').amount.value = ""
    if (document.getElementById('total_amount') != undefined) document.getElementById('form1').total_amount.value = ""
    if (document.getElementById('card_exp_month') != undefined) document.getElementById('form1').card_exp_month.value = ""
    if (document.getElementById('card_exp_year') != undefined) document.getElementById('form1').card_exp_year.value = ""
    if (document.getElementById('card_no') != undefined) document.getElementById('form1').card_no.value = ""

    if (document.getElementById('extra_d_charge') != undefined) document.getElementById('form1').extra_d_charge.value = ""
    if (document.getElementById('d_type') != undefined) document.getElementById('form1').d_type.value = ""
    if (document.getElementById('d_room') != undefined) document.getElementById('form1').d_room.value = ""
    if (document.getElementById('d_floor') != undefined) document.getElementById('form1').d_floor.value = ""
    if (document.getElementById('d_blk') != undefined) document.getElementById('form1').d_blk.value = ""
    if (document.getElementById('d_build') != undefined) document.getElementById('form1').d_build.value = ""
    if (document.getElementById('d_street') != undefined) document.getElementById('form1').d_street.value = ""
    if (document.getElementById('d_district') != undefined) document.getElementById('form1').d_district.value = ""

    if (document.getElementById('d_time') != undefined) document.getElementById('form1').d_time.value = ""
    if (document.getElementById('extra_d_charge') != undefined) document.getElementById('form1').extra_d_charge.value = ""
    if (document.getElementById('contact_person') != undefined) document.getElementById('form1').contact_person.value = ""
    if (document.getElementById('contact_no') != undefined) document.getElementById('form1').contact_no.value = ""
    if (document.getElementById('ext_place_tel') != undefined) document.getElementById('form1').ext_place_tel.value = ""
    if (document.getElementById('pay_method') != undefined) document.getElementById('form1').pay_method.value = ""
    if (document.getElementById('form1').d_date_Day_ID != undefined) { document.getElementById('form1').d_date_Day_ID.value = ""; }
    if (document.getElementById('form1').d_date_Month != undefined) { document.getElementById('form1').d_date_Month.value = ""; }
    if (document.getElementById('form1').d_date_Year_ID != undefined) { document.getElementById('form1').d_date_Year_ID.value = ""; }
}

//---------------- End of Clear Pull down -------------------//


function c_all_opt() {
    if (document.getElementById('program') != undefined) document.getElementById('form1').program.value = ""
    if (document.getElementById('normal_rebate_type') != undefined) document.getElementById('normal_rebate_type').selectedIndex = 0;

    if (document.getElementById('rate_plan') != undefined) document.getElementById('form1').rate_plan.value = ""
    if (document.getElementById('accept_0') != undefined) document.getElementById('form1').accept_0.checked = false
    if (document.getElementById('accept_1') != undefined) document.getElementById('form1').accept_1.checked = false
    if (document.getElementById('con_per') != undefined) document.getElementById('form1').con_per.value = ""
    if (document.getElementById('rebate') != undefined) document.getElementById('form1').rebate.value = ""
    if (document.getElementById('free_mon') != undefined) document.getElementById('form1').free_mon.value = ""
    if (document.getElementById('lob') != undefined) document.getElementById('form1').lob.value = ""
    if (document.getElementById('lob_ac') != undefined) document.getElementById('form1').lob_ac.value = ""
    if (document.getElementById('hs_model') != undefined) document.getElementById('form1').hs_model.value = ""
    if (document.getElementById('premium') != undefined) document.getElementById('form1').premium.value = ""
    if (document.getElementById('sku') != undefined) document.getElementById('form1').sku.value = ""
    if (document.getElementById('sim_item_name1') != undefined) document.getElementById('form1').sim_item_name1.value = ""
    if (document.getElementById('sim_item_name') != undefined) document.getElementById('form1').sim_item_name.value = ""
    if (document.getElementById('sim_item_code') != undefined) document.getElementById('form1').sim_item_code.value = ""
    if (document.getElementById('sim_item_number') != undefined) document.getElementById('form1').sim_item_number.value = ""
    //	if(document.getElementById('imei_no') != undefined)  document.getElementById('form1').imei_no.value = ""
    if (document.getElementById('trade_field') != undefined) document.getElementById('form1').trade_field.value = ""
    if (document.getElementById('bundle_name') != undefined) document.getElementById('form1').bundle_name.value = ""
    if (document.getElementById('m_rebate_amount') != undefined) document.getElementById('form1').m_rebate_amount.value = ""
    if (document.getElementById('rebate_amount') != undefined) document.getElementById('form1').rebate_amount.value = ""
    if (document.getElementById('r_offer') != undefined) document.getElementById('form1').r_offer.value = ""
    if (document.getElementById('extra_rebate_amount') != undefined) document.getElementById('form1').extra_rebate_amount.value = ""
    if (document.getElementById('extra_rebate') != undefined) document.getElementById('form1').extra_rebate.value = ""
    if (document.getElementById('cancel_renew_0') != undefined) document.getElementById('form1').cancel_renew_0.checked = false
    if (document.getElementById('cancel_renew_1') != undefined) document.getElementById('form1').cancel_renew_1.checked = false
    if (document.getElementById('gift_desc') != undefined) document.getElementById('form1').gift_desc.value = ""
    if (document.getElementById('gift_code') != undefined) document.getElementById('form1').gift_code.value = ""
    if (document.getElementById('gift_imei') != undefined) document.getElementById('form1').gift_imei.value = ""
    if (document.getElementById('gift_desc2') != undefined) document.getElementById('form1').gift_desc2.value = ""
    if (document.getElementById('gift_code2') != undefined) document.getElementById('form1').gift_code2.value = ""
    if (document.getElementById('gift_imei2') != undefined) document.getElementById('form1').gift_imei2.value = ""
    if (document.getElementById('accessory_desc') != undefined) document.getElementById('form1').accessory_desc.value = ""
    if (document.getElementById('accessory_code') != undefined) document.getElementById('form1').accessory_code.value = ""
    if (document.getElementById('accessory_imei') != undefined) document.getElementById('form1').accessory_imei.value = ""
    if (document.getElementById('accessory_price') != undefined) document.getElementById('form1').accessory_price.value = ""
    if (document.getElementById('now_vas') != undefined) document.getElementById('form1').now_vas.value = "NO"
    if (document.getElementById('foot_vas') != undefined) document.getElementById('form1').foot_vas.value = "NO"
    if (document.getElementById('fin_vas') != undefined) document.getElementById('form1').fin_vas.value = "NO"
    if (document.getElementById('horse_vas') != undefined) document.getElementById('form1').horse_vas.value = "NO"
    if (document.getElementById('moov_vas') != undefined) document.getElementById('form1').moov_vas.value = "NO"
    if (document.getElementById('gprs_vas') != undefined) document.getElementById('form1').gprs_vas[0].value = "NO"
    if (document.getElementById('gprs_vas') != undefined) document.getElementById('form1').gprs_vas[1].value = ""
    if (document.getElementById('wifi_vas') != undefined) document.getElementById('form1').wifi_vas.value = "NO"
    if (document.getElementById('sms_vas') != undefined) document.getElementById('form1').sms_vas[0].value = "NO"
    if (document.getElementById('sms_vas') != undefined) document.getElementById('form1').sms_vas[1].value = ""
    if (document.getElementById('msn_vas') != undefined) document.getElementById('form1').msn_vas.value = "NO"
    if (document.getElementById('ct_vas') != undefined) document.getElementById('form1').ct_vas.value = "NO"
    if (document.getElementById('min_vas') != undefined) document.getElementById('form1').min_vas.value = "NO"
    if (document.getElementById('license_waiver') != undefined) document.getElementById('form1').license_waiver.value = "NO"
    if (document.getElementById('fast_start') != undefined) document.getElementById('form1').fast_start.checked = false
    if (document.getElementById('pcd_paid_go_wireless') != undefined) document.getElementById('form1').pcd_paid_go_wireless.checked = false
    //	if(document.getElementById('vas_eff_date') != undefined) document.getElementById('form1').vas_eff_date.value = ""
    if (document.getElementById('plan_eff_date') != undefined) document.getElementById('form1').plan_eff_date.value = ""
    if (document.getElementById('con_eff_date') != undefined) document.getElementById('form1').con_eff_date.value = ""
    if (document.getElementById('pos_ref_no') != undefined) document.getElementById('form1').pos_ref_no.value = ""
    if (document.getElementById('ord_place_by') != undefined) document.getElementById('form1').ord_place_by.value = ""
    if (document.getElementById('ord_place_rel') != undefined) document.getElementById('form1').ord_place_rel.value = ""
    if (document.getElementById('ord_place_id_type') != undefined) document.getElementById('form1').ord_place_id_type.value = ""
    if (document.getElementById('ord_place_hkid') != undefined) document.getElementById('form1').ord_place_hkid.value = ""
    if (document.getElementById('ord_place_hkid2') != undefined) document.getElementById('form1').ord_place_hkid2.value = ""
    if (document.getElementById('ord_place_tel') != undefined) document.getElementById('form1').ord_place_tel.value = ""
    if (document.getElementById('d_time') != undefined) document.getElementById('form1').d_time.value = ""
    if (document.getElementById('contact_person') != undefined) document.getElementById('form1').contact_person.value = ""
    if (document.getElementById('contact_no') != undefined) document.getElementById('form1').contact_no.value = ""
    if (document.getElementById('ext_place_tel') != undefined) document.getElementById('form1').ext_place_tel.value = ""
    if (document.getElementById('pay_method') != undefined) document.getElementById('form1').pay_method.value = ""
    if (document.getElementById('card_type') != undefined) document.getElementById('form1').card_type.value = ""
    if (document.getElementById('card_holder') != undefined) document.getElementById('form1').card_holder.value = ""
    if (document.getElementById('bank_code') != undefined) document.getElementById('form1').bank_code.value = ""
    if (document.getElementById('amount') != undefined) document.getElementById('form1').amount.value = ""
    if (document.getElementById('total_amount') != undefined) document.getElementById('form1').total_amount.value = ""
    if (document.getElementById('card_exp_month') != undefined) document.getElementById('form1').card_exp_month.value = ""
    if (document.getElementById('card_exp_year') != undefined) document.getElementById('form1').card_exp_year.value = ""
    if (document.getElementById('card_no') != undefined) document.getElementById('form1').card_no.value = ""
    /*
    if(document.getElementById('card_no1') != undefined) document.getElementById('form1').card_no1.value = ""
    if(document.getElementById('card_no2') != undefined) document.getElementById('form1').card_no2.value = ""
    if(document.getElementById('card_no3') != undefined) document.getElementById('form1').card_no3.value = ""
    if(document.getElementById('card_no4') != undefined) document.getElementById('form1').card_no4.value = ""
    */
    if (document.getElementById('m_card_exp_month') != undefined) document.getElementById('form1').m_card_exp_month.value = ""
    if (document.getElementById('m_card_exp_year') != undefined) document.getElementById('form1').m_card_exp_year.value = ""
    if (document.getElementById('m_card_no') != undefined) document.getElementById('form1').m_card_no.value = ""
    /*
    if(document.getElementById('m_card_no1') != undefined) document.getElementById('form1').m_card_no1.value = ""
    if(document.getElementById('m_card_no2') != undefined) document.getElementById('form1').m_card_no2.value = ""
    if(document.getElementById('m_card_no3') != undefined) document.getElementById('form1').m_card_no3.value = ""
    if(document.getElementById('m_card_no4') != undefined) document.getElementById('form1').m_card_no4.value = ""
    */
    if (document.getElementById('extra_d_charge') != undefined) document.getElementById('form1').extra_d_charge.value = ""
    if (document.getElementById('d_type') != undefined) document.getElementById('form1').d_type.value = ""
    if (document.getElementById('d_room') != undefined) document.getElementById('form1').d_room.value = ""
    if (document.getElementById('d_floor') != undefined) document.getElementById('form1').d_floor.value = ""
    if (document.getElementById('d_blk') != undefined) document.getElementById('form1').d_blk.value = ""
    if (document.getElementById('d_build') != undefined) document.getElementById('form1').d_build.value = ""
    if (document.getElementById('d_street') != undefined) document.getElementById('form1').d_street.value = ""
    if (document.getElementById('d_district') != undefined) document.getElementById('form1').d_district.value = ""
    /*
    if(document.getElementById('d_region_0') != undefined) document.getElementById('form1').d_region_0.checked = false
    if(document.getElementById('d_region_1') != undefined) document.getElementById('form1').d_region_1.checked = false
    if(document.getElementById('d_region_2') != undefined) document.getElementById('form1').d_region_2.checked = false
    if(document.getElementById('d_region_3') != undefined) document.getElementById('form1').d_region_3.checked = false
    */
    if (document.getElementById('d_time') != undefined) document.getElementById('form1').d_time.value = ""
    if (document.getElementById('extra_d_charge') != undefined) document.getElementById('form1').extra_d_charge.value = ""
    if (document.getElementById('contact_person') != undefined) document.getElementById('form1').contact_person.value = ""
    if (document.getElementById('contact_no') != undefined) document.getElementById('form1').contact_no.value = ""
    if (document.getElementById('ext_place_tel') != undefined) document.getElementById('form1').ext_place_tel.value = ""
    if (document.getElementById('pay_method') != undefined) document.getElementById('form1').pay_method.value = ""
    if (document.getElementById('form1').d_date_Day_ID != undefined) { document.getElementById('form1').d_date_Day_ID.value = ""; }
    if (document.getElementById('form1').d_date_Month != undefined) { document.getElementById('form1').d_date_Month.value = ""; }
    if (document.getElementById('form1').d_date_Year_ID != undefined) { document.getElementById('form1').d_date_Year_ID.value = ""; }
}

//---------------- End of Clear Pull down -------------------//

function chk_null(tobj) {
    if (tobj.value == "")
        tobj.value = "0";
}

function chk_mobile(objC) {
    if (objC.value.length != 0) {
        if (objC.value.match(/^\d{8}$/) == null) {
            alert("不正確的電話號碼!");
            objC.select();
            return false;
        }
        else if (objC.value.substring(0, 1) != "5" && objC.value.substring(0, 1) != "6" && objC.value.substring(0, 1) != "7" && objC.value.substring(0, 1) != "8" && objC.value.substring(0, 1) != "9") {
            alert("錯誤的電話號碼! 電話號碼第一個字必須 5或6或7或8或9!");
            objC.select();
            return false;
        }
        return true;
    }
    else
        return false;
}

function chg_upper(object) {
    object.value = object.value.toUpperCase();
}

function chk_cc(elem) {
    var pattern = /^([a-zA-Z0-9]|_|\.|'|,|\/|\s|-|&|\(|\))*/;
    if (pattern.test(elem.value)) {
        return true;
    }
    else {
        alert('輸入格式錯誤');
        elem.focus();
        return false;
    }
}

function chk_ord_id(tobj) {
    if (tobj.value != "") {
        if (tobj.value.match(/^\d{6}$/) == null) {
            alert("帳單號碼錯誤!");
            tobj.value = "";
            tobj.select();
            return false;
        }
        else if (document.getElementById('form1').check_easy_id.value != "true") {
            alert("請由獨立的帳單複製客戶名稱和身份証號碼!");
            //			alert("Please Copy Customer Name and HKID from Standalone Order!");
        }
    }
    else {
        alert("Please Enter Easywatch Standalone Order ID!")
        return false;
    }
}




function testCreditCard1() {
    if (document.getElementById('m_card_no1') != undefined &&
		document.getElementById('m_card_no2') != undefined &&
		document.getElementById('m_card_no3') != undefined &&
		document.getElementById('m_card_no4') != undefined) {
        myCardType = document.getElementById('m_card_type').value;
        myCardNo = document.getElementById('m_card_no1').value + document.getElementById('m_card_no2').value + document.getElementById('m_card_no3').value + document.getElementById('m_card_no4').value;
        if (checkCreditCard(myCardNo, myCardType)) {
            return true
        }
        else {
            alert(ccErrors[ccErrorNo])
            return false
        }
    }
}




function testCreditCard() {
    if (document.getElementById('card_no1') != undefined &&
		document.getElementById('card_no2') != undefined &&
		document.getElementById('card_no3') != undefined &&
		document.getElementById('card_no4') != undefined) {
        myCardType = document.getElementById('card_type').value;
        myCardNo = document.getElementById('card_no1').value + document.getElementById('card_no2').value + document.getElementById('card_no3').value + document.getElementById('card_no4').value;
        if (checkCreditCard(myCardNo, myCardType)) {
            return true
        }
        else {
            alert(ccErrors[ccErrorNo])
            return false
        }
    }
}









/***************Allow To Change Special Approval******************************/


/******************End of Allow To Change Special Approval**************************/


//=========================================Change VAS Rules===================================================================



//=====================================End of Change rules=================================================

function wireless() {


    if (document.getElementById('form1').go_wireless.value != "NO" && document.getElementById('form1').go_wireless.value != "") {
        if (document.getElementById('gift_desc1') != undefined) document.getElementById('gift_desc1').disabled = false;
        if (document.getElementById('accessory_desc1') != undefined) document.getElementById('accessory_desc1').disabled = false;
        if (document.getElementById('preferred_languages_0') != undefined) document.getElementById('preferred_languages_0').disabled = false;
        if (document.getElementById('preferred_languages_1') != undefined) document.getElementById('preferred_languages_1').disabled = false;
        if (document.getElementById('register_address') != undefined) document.getElementById('register_address').disabled = false;
    }
    else {
        if (document.getElementById('preferred_languages_0') != undefined) document.getElementById('preferred_languages_0').disabled = true;
        if (document.getElementById('preferred_languages_1') != undefined) document.getElementById('preferred_languages_1').disabled = true;
        if (document.getElementById('register_address') != undefined) {
            document.getElementById('register_address').disabled = false;
            document.getElementById('register_address').value = "";
        }
        add_amount();
    }
}



//For Lenovo S10
function check_hs_model() {
    var HsModelObj = document.getElementById('hs_model');
    var AccessoryDescDrpObj = document.getElementById('accessory_desc1');
    if (HsModelObj != undefined && AccessoryDescDrpObj != undefined) {
        var HsModelValue = '';
        if (HsModelObj.selectedIndex >= 0 && HsModelObj.selectedIndex < HsModelObj.options.length) {
            HsModelValue = HsModelObj.options[HsModelObj.selectedIndex].value;
        }
        else {
            HsModelValue = HsModelObj.value;
        }
        var AccessoryDescValue = '';
        if (AccessoryDescDrpObj.selectedIndex >= 0 && AccessoryDescDrpObj.selectedIndex < AccessoryDescDrpObj.options.length) {
            AccessoryDescValue = AccessoryDescDrpObj.options[AccessoryDescDrpObj.selectedIndex].value;
        }
        else {
            AccessoryDescValue = AccessoryDescDrpObj.value;
        }
        if ((HsModelValue == "LENOVO S10-2 (6 CELL/BLACK COLOR/EN XP HOME)" || HsModelValue == "LENOVO S10-2 (6 CELL/BLACK COLOR/TC XP HOME)") && (AccessoryDescValue == "LENOVO S10-2 (6 CELL/BLACK COLOR/EN XP HOME)" || AccessoryDescValue == "LENOVO S10-2 (6 CELL/BLACK COLOR/TC XP HOME)")) {
            alert("Lenovo S10 is already selected in Handset. Please select another Accessory");
        }

        if (HsModelValue.value == "SAMSUNG NP-N135 (6 CELL/WHITE COLOR/XP HOME)" && AccessoryDescDrpObj.value == "SAMSUNG NP-N135 (6 CELL/WHITE COLOR/XP HOME)") {
            alert("SAMSUNG NP-N135 is already selected in Handset. Please select another Accessory");
        }
    }
}

function ErrorLog(e, num) {
    var str = "An exception occurred in the script. \n Error name: " + e.name + "\n";
    str += ". Error description: " + e.description + "\n";
    str += ". Error number: " + e.number + "\n";
    str += ". Error message: " + e.message + "\n";
    str += ". Error lineNumber: " + e.line + "\n";
    //philip errorlog
    //alert("num : "+ num+"\n"+str);
}

function ChkFreeGiftStatus() {
    var GiftDescDrpObj = document.getElementById('gift_desc1');
    var GiftImeiObj = document.getElementById('gift_imei');
    var GiftDescDrp2Obj = document.getElementById('gift_desc21');
    var GiftImei2Obj = document.getElementById('gift_imei2');
    var GiftDescDrp3Obj = document.getElementById('gift_desc31');
    var GiftImei3Obj = document.getElementById('gift_imei3');
    var GiftDescDrp4Obj = document.getElementById('gift_desc41');
    var GiftImei4Obj = document.getElementById('gift_imei4');
    var AccessoryDescDrpObj = document.getElementById('accessory_desc1');
    var AccessoryImeiObj = document.getElementById('accessory_imei');
    var HsModelObj = document.getElementById('hs_model');
    if (HsModelObj.value == "") {
        GiftDescDrpObj.disabled = true;
        GiftImeiObj.disabled = true;
        GiftDescDrp2Obj.disabled = true;
        GiftImei2Obj.disabled = true;
        GiftDescDrp3Obj.disabled = true;
        GiftImei3Obj.disabled = true;
        GiftDescDrp4Obj.disabled = true;
        GiftImei4Obj.disabled = true;
        AccessoryDescDrpObj.disabled = true;
        AccessoryImeiObj.disabled = true;
    }

}

function callback_check_sim_number_for_js(res) {
    if (res != null) {
        //var result = res.get_message();
        var result = res.value;
        var ori_name = $("#sim_item_name1").val();
        //var ori_number = $("#sim_item_number").val();
        var ori_number = ($("#sim_item_number").val() == "AO" ? "" : $("#sim_item_number").val());
        if (result == "0") {
            //alert("Sorry, all SIM Card (Item Code: " + ori_name + ") are not avaliable at this moment,\nso this order cannot complete.");
            $("#sim_item_number").val("");
            //bFlag = false;
        } else if (result == "1") {
            alert("SIM Card: " + ori_number + " is ordered.");
            //bFlag = true;
        } else {
            alert("SIM Card: " + ori_number + " is not avaliable at this moment,\nanother SIM Card: " + result + " is filled in.");
            $("#sim_item_number").val(result);
            //bFlag = false;
        }
    } else {
        return;
    }
}

function chk_save(ThisForm) {
    var bFlag = true;
    var bShowError = true;

    var GiftDescObj = document.getElementById('gift_desc');
    var GiftDescDrpObj = document.getElementById('gift_desc1');
    var GiftDescDrp2Obj = document.getElementById('gift_desc2');
    var GiftDescDrp3Obj = document.getElementById('gift_desc3');
    var GiftDescDrp4Obj = document.getElementById('gift_desc4');
    var GiftCodeObj = document.getElementById('gift_code');
    var GiftCode2Obj = document.getElementById('gift_code2');
    var GiftCode3Obj = document.getElementById('gift_code3');
    var GiftCode4Obj = document.getElementById('gift_code4');
    var GiftImeiObj = document.getElementById('gift_imei');
    var GiftImei2Obj = document.getElementById('gift_imei2');
    var GiftImei3Obj = document.getElementById('gift_imei3');
    var GiftImei4Obj = document.getElementById('gift_imei4');

    var AccessoryDescDrpObj = document.getElementById('accessory_desc1');
    var ActionRequiredObj = document.getElementById('action_required');
    var ActionRequired2Obj = document.getElementById('action_required2');
    var HsModelObj = document.getElementById('hs_model');
    var AmountObj = document.getElementById('amount');
    var OrdPlaceByObj = document.getElementById('ord_place_by');
    var StaffNameObj = document.getElementById('staff_name');
    var D_DistrictObj = document.getElementById('d_district');
    var ConFlagObj = document.getElementById('Con_flag');
    var DeliFlag = document.getElementById('Deli_flag');
    var ProgramObj = document.getElementById('program');
    var BillCutDateObj = document.getElementById('bill_cut_date');
    var BillCutNumObj = document.getElementById('bill_cut_num');
    var SubmitObj = document.getElementById('submit2');
    var IssueTypeObj = document.getElementById('issue_type');
    document.getElementById('form1').submit2.disabled = true;
    var SimItemCodeObj = document.getElementById('sim_item_code');
    var MobileOrderThreeParty = document.getElementById("MobileOrderThreePartyControl_three_party");
    var bMobileOrderThreeParty = false;
    if (MobileOrderThreeParty != undefined) {
        if (MobileOrderThreeParty.checked == true) {
            bMobileOrderThreeParty = true;
        }
    }

    //1
    if (bFlag) {
        try {
            if (!ActionRequiredObj.checked && !ActionRequired2Obj.checked && !HsModelObj.value != "" && StaffNameObj.value == "" && document.getElementById('form1').extn.value == "" && document.getElementById('form1').salesmancode.value == "") {
                alert("NO Staff Info in EDF!\nOrder cannot be saved!\nPlease contact your UM!");
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            }
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 1); }

        }
    }
    //2
    if (bFlag) {
        try {
            if (document.getElementById('form1').ref_staff_no.value != "" && document.getElementById('form1').ref_salesmancode.value == "") {
                alert("Please check the salesmancode !");
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            }
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 2); }
        }
    }
    //3
    if (bFlag) {
        try {
            if (!document.getElementById('form1').easywatch_type[1].checked && GetCustomerName() == "") {
                alert("Please Enter Customer Name!");

                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            }
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 3); }
        }
    }

    if (bFlag) {
        try {
            if (!ChkGender()) {
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            }
        }
        catch (e) {
            if (bShowError) { ErrorLog(e, 3.1); }
        }
    }

    if (bFlag) {
        try {
            if (document.getElementById('form1').easywatch_type[1].checked && GetCustomerName() == "") {
                alert("No Customer Name!\nPlease Copy Customer Name from standalone Order ID!");
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            }
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 4); }
        }
    }
    //5
    if (bFlag) {
        try {
            if (!document.getElementById('form1').easywatch_type[1].checked && document.getElementById("id_type").options[document.getElementById("id_type").selectedIndex].value == "") {
                alert("Please Select ID Type!");
                if (document.getElementById('form1').id_type.style.display != "none" && document.getElementById('form1').id_type.disabled == false) {
                    //document.getElementById("id_type").focus();
                }
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            }
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 5); }
        }
    }
    if (bFlag) {
        try {
            if (!document.getElementById('form1').easywatch_type[1].checked && document.getElementById('form1').hkid.value.length == 0) {
                alert("Please Enter HKID/BR No./Passport No!");
                if (document.getElementById('form1').hkid.style.display != "none" && document.getElementById('form1').hkid.disabled == false) {
                    // document.getElementById('form1').hkid.focus();
                }
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //7
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 7); }
        }
    }
    if (bFlag) {
        try {
            if (document.getElementById('form1').easywatch_type[1].checked && document.getElementById('form1').hkid.value.length == 0) {
                alert("No HKID/BR No./Passport No!\nPlease Copy HKID/BR No./Passport No from standalone Order ID!");
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //8
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 8); }
        }
    }
    if (bFlag) {
        try {
            if (!document.getElementById('form1').easywatch_type[1].checked && document.getElementById("id_type").options[document.getElementById("id_type").selectedIndex].value == "HKID" && document.getElementById('form1').hkid2.value.length == 0) {
                alert("Please Enter brackets of HKID!");
                if (document.getElementById('form1').hkid2.style.display != "none" && document.getElementById('form1').hkid2.disabled == false) {
                    //    document.getElementById('form1').hkid2.focus();
                }
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //9
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 9); }
        }
    }
    if (bFlag) {
        try {
            if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && document.getElementById('form1').bundle_name.value == "") {
                alert("Please Enter Bundle Name!");
                event.returnValue = false;
                //document.getElementbyId('form1').submit2.disabled=false;
                bFlag = false;
            } //14
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 14); }
        }
    }
    if (bFlag) {
        try {
            if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && document.getElementById('form1').trade_field.value == "") {
                alert("Please Enter Trade Field!!");
                event.returnValue = false;
                //document.getElementbyId('form1').submit2.disabled=false;
                bFlag = false;
            } //15
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 15); }
        }
    }
    if (bFlag) {
        try {
            if (!document.getElementById('form1').easywatch_type[1].checked && document.getElementById("id_type").options[document.getElementById("id_type").selectedIndex].value == "HKID" && !chk_hkid2(document.getElementById('form1').hkid.value + document.getElementById('form1').hkid2.value)) {
                document.getElementById('form1').hkid.value = "";
                if (document.getElementById('form1').hkid.style.display != "none" && document.getElementById('form1').hkid.disabled == false) {
                    // document.getElementById('form1').hkid.focus();
                }
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //10
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 10); }
        }
    }


    if (bFlag) {
        try {
            if (document.getElementById('form1').mrt_no.value == "") {
                alert("Please Enter MRT No!");
                if (document.getElementById('form1').mrt_no.style.display != "none" && document.getElementById('form1').mrt_no.disabled == false) {
                    // document.getElementById('form1').mrt_no.focus();
                }
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //13
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 13); }
        }
    }
    if (bFlag) {
        try {
            if (ActionRequiredObj.checked && !document.getElementById('form1').waive_0.checked && !document.getElementById('form1').waive_1.checked) {
                alert("Please Select Waiving!");
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //16
        }
        catch (e) {
            if (bShowError) { ErrorLog(e, 16); }

        }
    }
    if (bFlag) {
        try {
            if (!ChkExistCustPlan()) {
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //17
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 17); }
        }
    }
    if (bFlag) {
        try {
            if (!ChkOrgFee()) {
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            }
            else if (!ChkExistingContractEndMonth()) {
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //18
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 18); }

        }
    }
    if (bFlag) {
        try {
            if (!ChkActionEffDate()) {
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //19
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 19); }

        }
    }
    if (bFlag) {
        try {
            if ((ActionRequiredObj.checked && !vaild_sup_date())) {

                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //20
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 20); }

        }
    }
    if (bFlag) {
        try {
            if (!ChkReasons()) {
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //21
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 21); }

        }
    }
    if (bFlag) {
        try {
            if (!ActionRequiredObj.checked && document.getElementById('form1').program.value == "" && !ActionRequired2Obj.checked) {
                alert("Please Enter Program!");
                if (document.getElementById('form1').program.style.display != "none" && document.getElementById('form1').program.disabled == false) {
                    // document.getElementById('form1').program.focus();
                }
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //22
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 22); }

        }
    }
    if (bFlag) {
        try {
            if (!ChkEasyWatchType()) {
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //24
        }
        catch (e) {
            if (bShowError) { ErrorLog(e, 24); }
        }
    }
    if (bFlag) {
        try {
            if (!ChkEasyWatchOrdId()) {
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //25
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 25); }

        }
    }
    if (bFlag) {
        try {
            if (document.getElementById('form1').easywatch_ord_id.value != "" && document.getElementById('form1').check_easy_id.value != "true") {
                alert("Please Copy Customer Name and HKID from Standalone Order!");
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //26
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 26); }

        }
    }
    if (bFlag) {
        try {
            if (!ChkCustStaffNo()) {
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //27
        }
        catch (e) {
            if (bShowError) { ErrorLog(e, 27); }
        }
    }
    if (bFlag) {
        try {
            if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && document.getElementById('form1').rate_plan.value == "") {
                alert("Please Enter Rate Plan!");
                if (document.getElementById('form1').rate_plan.style.display != "none" && document.getElementById('form1').rate_plan.disabled == false) {
                    //  document.getElementById('form1').rate_plan.focus();
                }
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //29
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 29); }

        }
    }
    if (bFlag) {
        try {
            if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) &&
            document.getElementById('form1').normal_rebate_type.selectedIndex < 0) {
                alert("Please Select Retention /Retention+ /Loyal Retention+ /Special Retention/ T-5 Upselling/Sim Only T-5 Upselling/Special Marker Retention!");
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //30
        }
        catch (e) {
            if (bShowError) { ErrorLog(e, 30); }
        }
    }
    if (bFlag) {
        try {
            if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && (document.getElementById("rate_plan").value == "3GFTRIAL0098A" || document.getElementById("rate_plan").value == "3GFTRIAL0198A" || document.getElementById("rate_plan").value == "3GFTRIAL0298A") && (!document.getElementById('form1').accept_1.checked && !document.getElementById('form1').accept_0.checked)) {
                alert("Please Select Autoroll !");
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //32
        }
        catch (e) {
            if (bShowError) { ErrorLog(e, 32); }
        }
    }
    if (bFlag) {
        try {
            if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && document.getElementById('form1').s_premium.value != "" && document.getElementById('form1').pos_ref_no.value == "") {
                if (document.getElementById("program").value != "NETVIGATOR EVERYWHERE") {
                    alert("Please Enter POS Reference No!");
                    if (document.getElementById('form1').pos_ref_no.style.display != "none" && document.getElementById('form1').pos_ref_no.disabled == false) {
                        // document.getElementById('form1').pos_ref_no.focus();
                    }
                    event.returnValue = false;
                    document.getElementById('form1').submit2.disabled = false;
                    bFlag = false;
                }
            } //33
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 33); }

        }
    }
    if (bFlag) {
        try {
            if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && document.getElementById('form1').s_premium.value == "37 inch Sony LCD TV" && document.getElementById('form1').sp_ref_no.value == "") {
                alert("Please Enter Special Premium Quota Reference No!");
                if (document.getElementById('form1').sp_ref_no.style.display != "none" && document.getElementById('form1').sp_ref_no.disabled == false) {
                    // document.getElementById('form1').sp_ref_no.focus();
                }
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //34
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 34); }

        }
    }
    if (bFlag) {
        try {
            if (document.getElementById('form1').bundle_name.value == "3GRET0138HSBUNDLE24M" && document.getElementById('form1').premium.options[document.getElementById('form1').premium.selectedIndex].value == "WELLCOME COUPON $800" && document.getElementById('form1').sku.value == "") {
                alert("Wrong Bundle Name with $800 Coupon~~!");
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //82
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 82); }

        }
    }
    if (bFlag) {
        try {
            if (document.getElementById('form1').bundle_name.value == "3GRET0198HSBundle18M" && document.getElementById('form1').premium.options[document.getElementById('form1').premium.selectedIndex].value == "WELLCOME COUPON $800" && document.getElementById('form1').sku.value == "") {
                alert("Wrong Bundle Name with $800 Coupon~~!");
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //83
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 83); }

        }
    }
    if (bFlag) {
        try {
            if (document.getElementById('form1').bundle_name.value == "3GRET0298HSBundle18M" && document.getElementById('form1').premium.options[document.getElementById('form1').premium.selectedIndex].value == "WELLCOME COUPON $200" && document.getElementById('form1').sku.value == "") {
                alert("Wrong Bundle Name with $200 Coupon~~!");
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //84
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 84); }

        }
    }
    if (bFlag) {
        try {
            if (document.getElementById('form1').bundle_name.value == "3GRET0498HSBundle18M" && document.getElementById('form1').premium.options[document.getElementById('form1').premium.selectedIndex].value == "WELLCOME COUPON $400" && document.getElementById('form1').sku.value == "") {
                alert("Wrong Bundle Name with $400 Coupon~~!");
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //85
        }
        catch (e) {
            if (bShowError) { ErrorLog(e, 85); }
        }
    }

    if (bFlag) {
        try {
            if (document.getElementById('form1').program.value == "GO WIRELESS TOO(UPSELL)" && (document.getElementById("form1").lob.value == "" || document.getElementById("form1").lob_ac.value == "")) {
                alert("Please enter both LOB Type and LOB Account No !");
                event.returnValue = false;
                document.getElementById("form1").submit2.disabled = false;
            }
        } //85.1
        catch (e) {
            if (bShowError) { ErrorLog(e, 85.1); }
        }
    }
    if (bFlag) {
        try {
            if (!ChkPcdPaidGoWireLess()) {
                event.returnValue = false;
                document.getElementById("form1").submit2.disabled = false;
            }
        } //85.2
        catch (e) {
            if (bShowError) { ErrorLog(e, 85.2); }
        }
    }
    if (bFlag) {
        try {
            if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && document.getElementById('form1').s_premium.value != "" && document.getElementById('form1').check_hkid.value == "false") {
                alert("Check HKID 1st!");
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //35
        }
        catch (e) {
            if (bShowError) { ErrorLog(e, 35); }
        }
    }
    if (bFlag) {
        try {
            if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && document.getElementById('form1').trade_field.value == "") {
                alert("Please Enter Trade Field!");
                if (document.getElementById('form1').trade_field.style.display != "none" && document.getElementById('form1').trade_field.disabled == false) {
                    //   document.getElementById('form1').trade_field.focus();
                }
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //36
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 36); }

        }
    }

    if (bFlag) {
        try {
            if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && document.getElementById('form1').bundle_name.value == "") {
                alert("Please Enter Bundle Name!");
                if (document.getElementById('form1').bundle_name.style.display != "none" && document.getElementById('form1').bundle_name.disabled == false) {
                    //  document.getElementById('form1').bundle_name.focus();
                }
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //37
        }
        catch (e) {
            if (bShowError) { ErrorLog(e, 37); }
        }
    }
    if (bFlag) {
        try {
            if (!ChkLob()) {
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //38
        }
        catch (e) {
            if (bShowError) { ErrorLog(e, 38); }
        }
    }
    if (bFlag) {
        try {
            if (!ChkLobAc()) {
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //39
        }
        catch (e) {
            if (bShowError) { ErrorLog(e, 39); }
        }
    }
    if (bFlag) {
        try {
            if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && document.getElementById('form1').con_per.value == "") {
                alert("Please Enter Contract Period!");
                if (document.getElementById('form1').con_per.style.display != "none" && document.getElementById('form1').con_per.disabled == false) {
                    //   document.getElementById('form1').con_per.focus();
                }
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //31
        }
        catch (e) {
            if (bShowError) { ErrorLog(e, 31); }
        }
    }
    if (bFlag) {
        try {
            if (document.getElementById('form1').sku.value == "2420551" && document.getElementById('form1').rate_plan.value == "3GRETENT0298A" && document.getElementById('form1').program.value == "Mass Retention") {
                alert("SAMSUNG 32 INCH LCD TV only for 3GRETMRE0298A")
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //40
        }
        catch (e) {
            if (bShowError) { ErrorLog(e, 40); }
        }
    }
    if (bFlag) {
        try {
            if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && (document.getElementById('form1').gift_code.value == "2004191" || document.getElementById('form1').gift_code2.value == "2004191" || document.getElementById('form1').gift_code3.value == "2004191" || document.getElementById('form1').gift_code4.value == "2004191") && document.getElementById('form1').sku.value != "2401971" && document.getElementById('form1').sku.value != "2401981" && document.getElementById('form1').sku.value != "2402441" && document.getElementById('form1').sku.value != "2402451") {
                alert("Select HS E65! or Release PQI 2GB Pen Drive Free Gift")
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //41
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 41); }

        }
    }
    if (bFlag) {
        try {
            if (!ChkGoWireless()) {
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //41.1
        }
        catch (e) {
            if (bShowError) { ErrorLog(e, 41.1); }
        }
    }
    if (bFlag) {
        try {
            if (!ChkRegisterAddress()) {
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //41.2
        }
        catch (e) {
            if (bShowError) { ErrorLog(e, 41.2); }
        }
    }

    if (bFlag) {
        try {
            if (ConFlagObj != undefined) {
                if (ConFlagObj.value == "0") {
                    if (document.getElementById('form1').trade_field.value.toUpperCase() != document.getElementById('form1').old_trade_field.value.toUpperCase() || document.getElementById('form1').bundle_name.value.toUpperCase() != document.getElementById('form1').old_bundle_name.value.toUpperCase()) {
                        alert("HS / Premium incorrect!")
                        event.returnValue = false;
                        document.getElementById('form1').submit2.disabled = false;
                    }
                }
            }
        } //42.1
        catch (e) {
            if (bShowError) { ErrorLog(e, 42.1); }
        }
    }

    if (bFlag) {
        try {
            if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && (document.getElementById('form1').go_wireless.value != "NO" && document.getElementById('form1').go_wireless.value != "") && (document.getElementById('form1').gift_code.value == "" || document.getElementById('form1').accessory_code.value == "") && AccessoryImeiObj.value == "") {
                alert("Get Free Gift Quota And Accessory, Please!");
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //41.3
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 41.3); }

        }
    }
    if (bFlag) {
        try {
            if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && document.getElementById('form1').gift_code.value != "" && document.getElementById('form1').gift_imei.value == "") {
                alert("Get Free Gift Quota, Please!");
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //42
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 42); }

        }
    }
    if (bFlag) {
        try {
            if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && document.getElementById('form1').gift_code2.value != "" && document.getElementById('form1').gift_imei2.value == "") {
                alert("Get Free Gift 2 Quota, Please!");
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //43
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 43); }

        }
    }
    if (bFlag) {
        try {
            if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && document.getElementById('form1').gift_code3.value != "" && document.getElementById('form1').gift_imei3.value == "") {
                alert("Get Free Gift 3 Quota, Please!");
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //44
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 44); }

        }
    }
    if (bFlag) {
        try {
            if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && document.getElementById('form1').gift_code4.value != "" && document.getElementById('form1').gift_imei4.value == "") {
                alert("Get Free Gift 4 Quota, Please!");
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //45
        }
        catch (e) {
            if (bShowError) { ErrorLog(e, 45); }
        }
    }
    if (bFlag) {
        try {
            if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && document.getElementById('form1').accessory_desc.value != "" && document.getElementById('form1').accessory_imei.value == "") {
                alert("Get Accessory Quota, Please!");
                if (document.getElementById('form1').accessory_desc.style.display != "none" && document.getElementById('form1').accessory_desc.disabled == false) {
                    //  document.getElementById('form1').accessory_desc.focus();
                }
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //46
        }
        catch (e) {
            if (bShowError) { ErrorLog(e, 46); }
        }
    }

    if (ConFlagObj != undefined) {
        if (ConFlagObj.value == "1") {
            if (bFlag) {
                try {
                    if (!CheckConEffDate()) {
                        event.returnValue = false;
                        document.getElementById('form1').submit2.disabled = false;
                        bFlag = false;
                    }//47
                }
                catch (e) {
                    if (bShowError) { ErrorLog(e, 47); }
                }
            }

            if (bFlag) {
                try {
                    if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && document.getElementById('form1').plan_eff_1.checked && document.getElementById('form1').plan_eff_date.value == "") {
                        alert("Please Enter Rate Plan Effective Date!");
                        if (document.getElementById('form1').plan_eff_date.style.display != "none" && document.getElementById('form1').plan_eff_date.disabled == false) {
                            //   document.getElementById('form1').plan_eff_date.focus();
                        }
                        event.returnValue = false;
                        document.getElementById('form1').submit2.disabled = false;
                        bFlag = false;
                    } //49
                }
                catch (e) {

                    if (bShowError) { ErrorLog(e, 49); }

                }
            }
            
        }
    }

    if (bFlag) {
        try {
            if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && !vaild_plan_date()) {
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //51
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 51); }

        }
    }
    
    if (bFlag) {
        try {
            if (!ChkWaive()) {
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //52
        }
        catch (e) {
            if (bShowError) { ErrorLog(e, 52); }
        }
    }
    if (bFlag) {
        try {
            if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && OrdPlaceByObj.value.length == 0) {
                alert("Please Enter Order Place By!");
                if (OrdPlaceByObj.style.display != "none" && OrdPlaceByObj.disabled == false) {
                    //OrdPlaceByObj.focus();
                }
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //54
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 54); }

        }
    }
    if (bFlag) {
        try {
            if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && document.getElementById('form1').ord_place_rel.options[document.getElementById('form1').ord_place_rel.selectedIndex].value == "") {
                alert("Please Select Relationship in Order Place Details!");
                if (document.getElementById('form1').ord_place_rel.style.display != "none" && document.getElementById('form1').ord_place_rel.disabled == false) {
                    //  document.getElementById('form1').ord_place_rel.focus();
                }
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //55
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 55); }

        }
    }
    if (bFlag) {
        try {
            if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && document.getElementById('form1').ord_place_id_type.options[document.getElementById('form1').ord_place_id_type.selectedIndex].value == "") {
                alert("Please Select ID Type in Order Place Details!");
                if (document.getElementById('form1').ord_place_id_type.style.display != "none" && document.getElementById('form1').ord_place_id_type.disabled == false) {
                    //   document.getElementById('form1').ord_place_id_type.focus();
                }
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //56
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 56); }

        }
    }
    if (bFlag) {
        try {
            if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && document.getElementById('form1').ord_place_hkid.value.length == 0) {
                alert("Please Enter HKID/Passport No in Order Place Details!");
                if (document.getElementById('form1').ord_place_hkid.style.display != "none" && document.getElementById('form1').ord_place_hkid.disabled == false) {
                    //  document.getElementById('form1').ord_place_hkid.focus();
                }
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //57
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 57); }

        }
    }
    if (bFlag) {
        try {
            if (!ChkOrdPlaceIdType()){
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //58
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 58); }

        }
    }
    if (bFlag) {
        try {
            if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && document.getElementById('form1').ord_place_id_type.options[document.getElementById('form1').ord_place_id_type.selectedIndex].value == "HKID" && !chk_hkid2(document.getElementById('form1').ord_place_hkid.value + document.getElementById('form1').ord_place_hkid2.value)) {
                document.getElementById('form1').ord_place_hkid.value = "";
                if (document.getElementById('form1').ord_place_hkid.style.display != "none" && document.getElementById('form1').ord_place_hkid.disabled == false) {
                    //  document.getElementById('form1').ord_place_hkid.focus();
                }
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //59
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 59); }

        }
    }
    if (bFlag) {
        try {
            if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && document.getElementById('form1').ord_place_tel.value == "") {
                alert("Please Enter Contact No. in Order Place Details!");
                //   document.getElementById('form1').ord_place_tel.focus();
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //60
        }
        catch (e) {
            if (bShowError) { ErrorLog(e, 60); }
        }
    }

    if (DeliFlag != undefined) {
        if (DeliFlag.value == "1") {
            if (bFlag) {
                try {
                    if ((!document.getElementById('form1').action_required.checked && !document.getElementById('form1').action_required2.checked) && document.getElementById('form1').hs_model.value != "" && document.getElementById('form1').d_address.value == "") {
                        alert("Please Enter Delivery Address!");
                        //document.getElementById('form1').d_district.focus();
                        event.returnValue = false;
                        document.getElementById('form1').submit2.disabled = false;
                    }
                }
                catch (e) {
                    if (bShowError) { ErrorLog(e, 62.1); }
                }
            } //if

            if (bFlag) {
                try {
                    if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) &&
                    (HsModelObj.value != "" || SimItemCodeObj.value != "" || (IssueTypeObj.value == "UPGRADE" || IssueTypeObj.value == "WIN")) &&
                    !vaild_date()) {
                        event.returnValue = false;
                        document.getElementById('form1').submit2.disabled = false;
                        bFlag = false;
                    } //64
                }
                catch (e) {
                    if (bShowError) { ErrorLog(e, 64); }
                }
            } //if
 
            if (bFlag) {
                try {
                    if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && HsModelObj.value != "" && document.getElementById('form1').extra_d_charge.value == "") {
                        alert("Please Enter Delivery Charge for special region !");
                        if (document.getElementById('form1').extra_d_charge.style.display != "none" && document.getElementById('form1').extra_d_charge.disabled == false) {
                            //  document.getElementById('form1').extra_d_charge.focus();
                        }
                        event.returnValue = false;
                        document.getElementById('form1').submit2.disabled = false;
                        bFlag = false;
                    } //66
                }
                catch (e) {

                    if (bShowError) { ErrorLog(e, 66); }

                }
            } //if
            if (bFlag) {
                try {
                    if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && HsModelObj.value != "" && document.getElementById('form1').contact_person.value == "") {
                        if (bMobileOrderThreeParty == false) {
                            alert("Please Enter Contact Person!");
                            if (document.getElementById('form1').contact_person.style.display != "none" && document.getElementById('form1').contact_person.disabled == false) {
                                //  document.getElementById('form1').contact_person.focus();
                            }
                            event.returnValue = false;
                            document.getElementById('form1').submit2.disabled = false;
                            bFlag = false;
                        }
                    } //67
                }
                catch (e) {

                    if (bShowError) { ErrorLog(e, 67); }

                }
            } //if
            if (bFlag) {
                try {
                    if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && HsModelObj.value != "" && document.getElementById('form1').contact_no.value == "") {
                        if (bMobileOrderThreeParty == false) {
                            alert("Please Enter Contact No. !");
                            if (document.getElementById('form1').contact_no.style.display != "none" && document.getElementById('form1').contact_no.disabled == false) {
                                // document.getElementById('form1').contact_no.focus();
                            }
                            event.returnValue = false;
                            document.getElementById('form1').submit2.disabled = false;
                            bFlag = false;
                        }
                    } //68
                }
                catch (e) {

                    if (bShowError) { ErrorLog(e, 68); }

                }
            } //if
            if (bFlag) {
                try {
                    if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && HsModelObj.value != "" && document.getElementById('form1').pay_method.value == "") {
                        alert("Please Enter Payment Method!");
                        if (document.getElementById('form1').pay_method.style.display != "none" && document.getElementById('form1').pay_method.disabled == false) {
                            //   document.getElementById('form1').pay_method.focus();
                        }
                        event.returnValue = false;
                        document.getElementById('form1').submit2.disabled = false;
                        bFlag = false;
                    } //69
                }
                catch (e) {

                    if (bShowError) { ErrorLog(e, 69); }

                }
            } //if




            if (bFlag) {
                try {
                    if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && HsModelObj.value != "" && document.getElementById('form1').pay_method.value == "CREDIT CARD INSTALLMENT" && document.getElementById('form1').bank_code.value == "") {
                        alert("Please Select Bank Code!");
                        if (document.getElementById('form1').bank_code.style.display != "none" && document.getElementById('form1').bank_code.disabled == false) {
                            //  document.getElementById('form1').bank_code.focus();
                        }
                        event.returnValue = false;
                        document.getElementById('form1').submit2.disabled = false;
                        bFlag = false;
                    } //74
                }
                catch (e) {

                    if (bShowError) { ErrorLog(e, 74); }

                }
            } //if
        }
    }

    if (bFlag) {
        try {
            if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && HsModelObj.value != "" && AmountObj.value == "") {
                alert("Please Enter Amount!");
                if (AmountObj.style.display != "none" && AmountObj.disabled == false) {
                    // AmountObj.focus();
                }
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            } //75
        }
        catch (e) {

            if (bShowError) { ErrorLog(e, 75); }

        }
    }

    if (DeliFlag != undefined) {
        if (DeliFlag.value == "1") {
            if (bFlag) {
                try {
                    if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && HsModelObj.value != "" && document.getElementById('form1').pay_method.value == "CREDIT CARD INSTALLMENT" && document.getElementById('form1').bank_code.value != "" && !vaild_amount()) {
                        event.returnValue = false;
                        document.getElementById('form1').submit2.disabled = false;
                        bFlag = false;
                    } //76
                }
                catch (e) {

                    if (bShowError) { ErrorLog(e, 76); }

                }
            }
        }
    }

    //For Lenovo S10-2
    if (bFlag) {
        try {
            if (AccessoryDescDrpObj != undefined && HsModelObj != undefined) {
                var HsModelValue = HsModelObj.options[HsModelObj.selectedIndex].value;
                var AccessoryDescValue = AccessoryDescDrpObj.options[AccessoryDescDrpObj.selectedIndex].value;
                if ((HsModelValue == "LENOVO S10-2 (6 CELL/BLACK COLOR/EN XP HOME)" || HsModelValue == "LENOVO S10-2 (6 CELL/BLACK COLOR/TC XP HOME)") && (AccessoryDescValue == "LENOVO S10-2 (6 CELL/BLACK COLOR/EN XP HOME)" || AccessoryDescValue == "LENOVO S10-2 (6 CELL/BLACK COLOR/TC XP HOME)")) {
                    alert("Lenovo S10 is already selected in Handset. Please select another Accessory");
                    event.returnValue = false;
                    document.getElementbyId('form1').submit2.disabled = false;
                    bFlag = false;
                }
            } //87
        }
        catch (e) {
            if (bShowError) { ErrorLog(e, 87); }
        }
    }

    //88
    if (bFlag) {
        try {
            if (!ChkBillCutDate()) {
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            }
        }
        catch (e) {
            if (bShowError) { ErrorLog(e, 88); }
        }
    }

    if (bFlag) {
        try {
            var Fo_reply = document.getElementById("fo_reply");
            if (Fo_reply != undefined) {
                if (Fo_reply.value == "" && Fo_reply.style.display != "none") {
                    alert("Please Enter Fallout Reply Remarks!");
                    //event.returnValue=false;
                    bFlag = false;
                }
            }
        } //90
        catch (e) {
            if (bShowError) { ErrorLog(e, 90); }
        }
    }
    if (bFlag) {
        try {
            /*
            if (HsModelObj.value == "PCCW-LG GU285 BK" && AmountObj.value == "0" && S_premium2Obj.value != ''){
            alert("請注意: 若現有3G客戶已享用 LG GU285 $0 upfront 手機優惠，不可同時享用Family Pack 優惠。");
            event.returnValue=false;
            //document.getElementById('form1').submit2.disabled=false;
            bFlag=false;
            }
            */
        } //92
        catch (e) {
            if (bShowError) { ErrorLog(e, 92); }
        }
    }
    else {
        document.getElementById('form1').submit2.disabled = false;
    }
    if (bFlag) {
        try {
            if (!ValidBillCutDate()) {
                event.returnValue = false;
                bFlag = false;
            }
        } //93
        catch (e) {
            if (bShowError) { ErrorLog(e, 93); }
        }
    }

    if (bFlag) {//94
        try {
            if (ProgramObj.value == "GO WIRELESS" &&
	        (
		        GiftDescObj.value == "" || GiftCodeObj.value == "" || GiftImeiObj.value == "" ||
		        AccessoryDescObj.value == "" || AccessoryCodeObj.value == "" || AccessoryImeiObj.value == ""
	        )
	        ) {
                if (GiftDescObj.value == "" || GiftCodeObj.value == "" || GiftImeiObj.value == "") {
                    alert("Please enter free gift and gift imei!");
                }
                else if (AccessoryDescObj.value == "" || AccessoryCodeObj.value == "" || AccessoryImeiObj.value == "") {
                    alert("Please enter accessory and accessory imei!");
                }
                event.returnValue = false;
                document.getElementById("form1").submit2.disabled = false;
            }
        }
        catch (e) {
            if (bShowError) { ErrorLog(e, 94); }
        }
    }

    // check iphone <--> HKID
    if (bFlag) {
        try {

            var iphone_concierge_order = document.getElementById('iphone_concierge_order');
            if (iphone_concierge_order != undefined) {
                if (iphone_concierge_order.value != "1") {
                    if (chkHkidForIphone() == 1 /*&& chkChangeHkid()*/) {
                        alert("Customer has already used IPhone Concierge Service!");
                        event.returnValue = false;
                        document.getElementById('form1').submit2.disabled = false;
                        bFlag = false;
                    }
                }
            }

        } //96
        catch (e) {
            if (bShowError) { ErrorLog(e, 96); }
        }
    }

    if (bFlag) {
        try {
            if (document.getElementById('bank_name').value != "" && document.getElementById('bank_code').value == "") {
                alert("Please enter bank code");
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            }
        } //97
        catch (e) {
            if (bShowError) { ErrorLog(e, 97); }

        }
    }
    if (bFlag) {
        var Issue_value = document.getElementById('issue_value');
        try {
            if (Issue_value != undefined) {
                if (Issue_value.value == 'MOBILE_LITE') {
                    if (!CheckMNPInformation('MobileOrderMNPDetailControl')) {
                        event.returnValue = false;
                        bFlag = false;
                    }
                }
            }
        } //102
        catch (e) {
            if (bShowError) { ErrorLog(e, 102); }
        }
    }


    if (bFlag) {
        try {
            if (!checkCreditCard(document.getElementById('card_no').value, document.getElementById('card_type').value)) {
                alert('Invalid token!');
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            }
        } //98
        catch (e) {
            if (bShowError) { ErrorLog(e, 98); }
        }
    }
    if (bFlag) {
        try {
            if (!checkCreditCard(document.getElementById('m_card_no').value, document.getElementById('m_card_type').value)) {
                alert('Invalid token!');
                event.returnValue = false;
                document.getElementById('form1').submit2.disabled = false;
                bFlag = false;
            }
        } //99
        catch (e) {
            if (bShowError) { ErrorLog(e, 99); }
        }
    }

    if (bFlag) {
        try {
            if (!ValidServiceActivationDate()) {
                event.returnValue = false;
                bFlag = false;
            }
        } //101
        catch (e) {
            if (bShowError) { ErrorLog(e, 101); }
        }
    }
    if (bFlag) {
        var Issue_type = document.getElementById('issue_type');
        try {
            if (Issue_type != undefined) {
                if (Issue_type.value == 'MOBILE_LITE') {
                    if (!CheckMNPInformation('MobileOrderMNPDetailControl')) {
                        event.returnValue = false;
                        bFlag = false;
                    }
                }
            }
        } //102
        catch (e) {
            if (bShowError) { ErrorLog(e, 102); }
        }
    }
    if (bFlag) {
        try {
            if (!CheckMontlyPaymentMethod()) {
                event.returnValue = false;
                bFlag = false;
            }
        } //103
        catch (e) {
            if (bShowError) { ErrorLog(e, 103); }
        }
    }
    if (bFlag) {
        try {
            if (!ChkChangePaymentType()) {
                event.returnValue = false;
                bFlag = false;
            }
        } //104
        catch (e) {
            if (bShowError) { ErrorLog(e, 104); }
        }
    }
    if (bFlag) {
        try {
            if (!AddressFormChk()) {
                event.returnValue = false;
                bFlag = false;
            }
        } //105
        catch (e) {
            if (bShowError) { ErrorLog(e, 105); }
        }
    }
    if (bFlag) {
        try {
            if (!CreditCardChk1()) {
                event.returnValue = false;
                bFlag = false;
            }
        } //106
        catch (e) {
            if (bShowError) { ErrorLog(e, 106); }
        }
    }
    if (bFlag) {
        try {
            if (!CreditCardChk2()) {
                event.returnValue = false;
                bFlag = false;
            }
        } //107
        catch (e) {
            if (bShowError) { ErrorLog(e, 107); }
        }
    }

    if (bFlag) {
        try {
            if (!CheckThreeParty('MobileOrderThreePartyControl')) {
                event.returnValue = false;
                bFlag = false;
            }
        } //108
        catch (e) {
            if (bShowError) { ErrorLog(e, 108); }
        }
    }

    if (bFlag) {
        try {
            if (document.getElementById("bill_medium_show").style.display != "none" && document.getElementById("bill_medium").value == "") {
                alert("Please kindly select bill medium!");
                event.returnValue = false;
                bFlag = false;
            }
        } //109
        catch (e) {
            if (bShowError) { ErrorLog(e, 109); }
        }
    }

    if (bFlag) {
        try {
            if (!ChkSimItemCode()) {
                event.returnValue = false;
                bFlag = false;
            }
        } //110
        catch (e) {
            if (bShowError) { ErrorLog(e, 110); }
        }
    }

    if (bFlag) {
        try {
            if (!CheckMonthlyBankAccount()) {
                event.returnValue = false;
                bFlag = false;
            }
        } //111
        catch (e) {
            if (bShowError) { ErrorLog(e, 111); }
        }
    }

    if (bFlag) {
        try {
            if (!Chk3rdContactNo()) {
                event.returnValue = false;
                bFlag = false;
            }
        } //112
        catch (e) {
            if (bShowError) { ErrorLog(e, 112); }
        }
    }

    if (bFlag) {
        try {
            if (!CheckDeliveryDateTime()) {
                event.returnValue = false;
                bFlag = false;
            }
        } //113
        catch (e) {
            if (bShowError) { ErrorLog(e, 113); }
        }
    }
    if (bFlag) {
        try {
            if (!CheckDateOfBirth()) {
                event.returnValue = false;
                bFlag = false;
            }
        } //114
        catch (e) {
            if (bShowError) { ErrorLog(e, 114); }
        }
    }
    if (bFlag) {
        try {
            if (!CheckRedemptionNoticeOption()) {
                event.returnValue = false;
                bFlag = false;
            }
        } //115
        catch (e) {
            if (bShowError) { ErrorLog(e, 115); }
        }
    }

    if (bFlag) {
        try {
            if (!CheckDeliveryAddress()) {
                event.returnValue = false;
                bFlag = false;
            }
        } //116
        catch (e) {
            if (bShowError) { ErrorLog(e, 116); }
        }
    }

    if (bFlag) {
        try {
            if (!CheckSpecialPremium()) {
                event.returnValue = false;
                bFlag = false;
            }
        } //118
        catch (e) {
            if (bShowError) { ErrorLog(e, 118); }
        }
    }



    if (bFlag) {
        try {
            if (!ChkUpgradeOrder()) {
                event.returnValue = false;
                bFlag = false;
            }
        } //120
        catch (e) {
            if (bShowError) { ErrorLog(e, 120); }
        }
    }

    if (bFlag) {
        try {
            if (!ChkMonthlyPaymentType()) {
                event.returnValue = false;
                bFlag = false;
            }
        } //121
        catch (e) {
            if (bShowError) { ErrorLog(e, 121); }
        }
    }

    if (bFlag) {
        try {
            if (!ChkCustomerName()) {
                event.returnValue = false;
                bFlag = false;
            }
        } //122
        catch (e) {
            if (bShowError) { ErrorLog(e, 122); }
        }
    }

    if (bFlag) {
        try {
            if (!ChkMonthlyPaymentTypeRelativeValue()) {
                event.returnValue = false;
                bFlag = false;
            }
        } //123
        catch (e) {
            if (bShowError) { ErrorLog(e, 123); }
        }
    }

    if (bFlag) {
        try {
            if (!ChkCnMrtNo()) {
                event.returnValue = false;
                bFlag = false;
            }
        } //124
        catch (e) {
            if (bShowError) { ErrorLog(e, 124); }
        }
    }

    if (bFlag) {
        try {
            if (!ChkCardRefNo()) {
                event.returnValue = false;
                bFlag = false;
            }
        } //125
        catch (e) {
            if (bShowError) { ErrorLog(e, 125); }
        }
    }

    if (bFlag) {
        try {
            if (!ChkCustType()) {
                event.returnValue = false;
                bFlag = false;
            }
        } //126
        catch (e) {
            if (bShowError) { ErrorLog(e, 126); }
        }
    }

    if (bFlag) {
        try {
            if (!UpgradeFtgTenureChange()) {
                event.returnValue = false;
                bFlag = false;
            }
        } //127
        catch (e) {
            if (bShowError) { ErrorLog(e, 127); }
        }
    }

    if (bFlag) {
        try {
            if (!ProgramAlertMsg()) {
                event.returnValue = false;
                bFlag = false;
            }
        } //128
        catch (e) {
            if (bShowError) { ErrorLog(e, 128); }
        }
    }

    if (bFlag) {
        try {
            if (!SimItemNameChk()) {
                event.returnValue = false;
                bFlag = false;
            }
        } //129
        catch (e) {
            if (bShowError) { ErrorLog(e, 129); }
        }
    }

    if (bFlag) {
        try {
            if (!GiftDescChk()) {
                event.returnValue = false;
                bFlag = false;
            }
        } //130
        catch (e) {
            if (bShowError) { ErrorLog(e, 130); }
        }
    }

    if (bFlag) {
        try {
            if (!GiftDescChk2()) {
                event.returnValue = false;
                bFlag = false;
            }
        } //131
        catch (e) {
            if (bShowError) { ErrorLog(e, 131); }
        }
    }



    if (bFlag) {
        try {
            if (!GiftDescChk3()) {
                event.returnValue = false;
                bFlag = false;
            }
        } //132
        catch (e) {
            if (bShowError) { ErrorLog(e, 132); }
        }
    }
    
    if (bFlag) {
        try {
            if (!GiftDescChk4()) {
                event.returnValue = false;
                bFlag = false;
            }
        } //133
        catch (e) {
            if (bShowError) { ErrorLog(e, 133); }
        }
    }
    
    
    if (event.returnValue != false && bFlag) {
        if (confirm("Are you sure you want to Save?") == false) {
            event.returnValue = false;
            document.getElementById('form1').submit2.disabled = false;
        }
        else {
            document.getElementById('form1').action = "PreviousOrderModifyImplement.aspx?order_id=" + document.getElementById("MobileRetentionOrder_id").value;
            for (i = 0; i < document.getElementById('form1').elements.length; i++) {
                document.getElementById('form1').elements[i].disabled = false;
                document.getElementById('form1').elements[i].readOnly = false;
            }
            ThisForm.submit();
        }
    }
    else {
        if (SubmitObj != undefined) SubmitObj.disabled = false;
    }
}



function chkChangeHkid() {
    newHkid = document.getElementById('form1').hkid.value + document.getElementById('form1').hkid2.value
    oldHkid = document.getElementById('form1').hidden_hkid.value
    if (newHkid == oldHkid) {
        return false;
    } else {
        return true;
    }
}



function third_party() {
    if (document.getElementById('form1').third_party_credit_card[0].checked == true) {
        document.getElementById('form1').third_party_id_type.disabled = false;
        document.getElementById('form1').third_party_hkid.disabled = false;
        document.getElementById('form1').third_party_hkid2.disabled = false;

        document.getElementById('form1').third_party_id_type.style.background = "#FFFFbb";
        document.getElementById('form1').third_party_hkid.style.background = "#FFFFbb";
        document.getElementById('form1').third_party_hkid2.style.background = "#FFFFbb";

    }
    else {
        document.getElementById('form1').third_party_id_type.disabled = true;
        document.getElementById('form1').third_party_hkid.disabled = true;
        document.getElementById('form1').third_party_hkid2.disabled = true;

        document.getElementById('form1').third_party_id_type.value = "";
        document.getElementById('form1').third_party_hkid.value = "";
        document.getElementById('form1').third_party_hkid2.value = "";

        document.getElementById('form1').third_party_id_type.style.background = "#DDDDDD";
        document.getElementById('form1').third_party_hkid.style.background = "#DDDDDD";
        document.getElementById('form1').third_party_hkid2.style.background = "#DDDDDD";
    }
}


function HideAllTable() {
    HideTable("TBL1", "Tab1");
    HideTable("TBL2", "Tab2");
    HideTable("TBL3", "Tab3");
    HideTable("TBL4", "Tab4");
    HideTable("TBL5", "Tab5");
}
function ChangeTab(tablename, tabname) {

    HideAllTable();

    ShowTable(tablename, tabname);
}


function ShowTable(tablename, tabname) {
    if (document.getElementById(tablename) != undefined) document.getElementById(tablename).style.display = "inline";
    if (document.getElementById(tabname) != undefined) document.getElementById(tabname).style.color = "#FFFFFF";
}

function HideTable(tablename, tabname) {
    if (document.getElementById(tablename) != undefined) document.getElementById(tablename).style.display = "none";
    if (document.getElementById(tabname) != undefined) document.getElementById(tabname).style.color = "#000000";
}
