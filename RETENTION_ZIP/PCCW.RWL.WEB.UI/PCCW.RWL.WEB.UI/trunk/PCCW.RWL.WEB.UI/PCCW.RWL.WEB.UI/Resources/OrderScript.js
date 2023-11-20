$(document).ready(function() {

});


function PageLoadCompleteUpdateLogic(){
    PageLoadCompleteUpgardeOrderLogic();
    PageLoadCompleteRebateAmountLogic();
    PageLoadCompleteWinOrderLogic();
    c_action_required();
    CNMobileNumberInit();
    ChangeShowCNMrtNo();
    ChkAmountAndPaymethod();
    ChkIdTypeChange();
    RedemptionNoticeOptionAbled();
    add_amount();
}


/*******/

function ProgramAlertMsg(){ 
    var ProgramObj=GetJID("program");
    var IssueTypeObj = $("#issue_type");
    if(IssueTypeObj.val()=="UPGRADE" || IssueTypeObj.val()=="WIN"){
        if(
            ProgramObj.value=="3GSTPPLAN+0149A" || 
            ProgramObj.value=="3GSTPPLAN+0299A" || 	   
            ProgramObj.value=="3GSTPPLAN+0389A" ||  
            ProgramObj.value=="3GTOPUPSPLAN0149A" || 
            ProgramObj.value=="3GTOPUPSPLAN0299A" || 
            ProgramObj.value=="3GTOPUPSPLAN0389A" || 
            ProgramObj.value=="3GTOPUPTPLAN0119A" || 
            ProgramObj.value=="3GTOPUPTPLAN0269A" || 
            ProgramObj.value=="3GTOPUPTPLAN0359A" || 
            ProgramObj.value=="3GTTPPLAN+0119A" || 
            ProgramObj.value=="3GTTPPLAN+0269A" || 
            ProgramObj.value=="3GTTPPLAN+0359A"
        )
        {
            alert("請注意：若現有享用手機優惠或使用Super VAS Bundle 客戶，暫不支援升級或續約轉用Top Up Plan，同事可保留客戶資料稍後通知");
        }
    }
    return true;
}


function Vas1Change(){
    ChangeShowCNMrtNo();
    VasAlertMsg();
}
function Vas2Change(){
    
}


function VasAlertMsg(){
    var IDDNormalVas = document.getElementById("idd_normal_vas");
    var RoamingVas = document.getElementById("roaming_vas");
    var UpgsupVas = document.getElementById("upg_sup_vas");
    if (IDDNormalVas != undefined && RoamingVas != undefined) {
        if (IDDNormalVas.value == "YES") {
            alert("豁免按金享有IDD/ROAMING服務: 只適用於使用信用咭自動轉帳繳費或是現正使用其他LOB服務期滿一年或以上.(可在Eligibility Check system查核)");
        }
        else if (RoamingVas.value != "NO") {
            alert("豁免按金享有IDD/ROAMING服務: 只適用於使用信用咭自動轉帳繳費或是現正使用其他LOB服務期滿一年或以上.(可在Eligibility Check system查核)");
        }
    }
    
    if(UpgsupVas!=undefined)
    {
        if(UpgsupVas.value!="NO" && UpgsupVas.value!=""){
            alert("溫馨提示:如客人於Upgrade前已選購SuperVAS增值服務,並Upgrade到指定HS offer + min.VAS requirement (e.g. $38 VAS),客人需要額外多申請 $13 mini VAS x 3 以符合新手機之資格.");
        }
    }
}


/***** End of Change pull down after select S_Premium *****/
function SPremiumLoad() {
    document.getElementById('form1').load_s_premium.style.display = "inline"
    document.getElementById('form1').s_premium.disabled = true;
}

function SPremiumNoLoad() {
    document.getElementById('form1').load_s_premium.style.display = "none"
    document.getElementById('form1').s_premium.disabled = false;
}

function SPremium1Load() {
    document.getElementById('form1').load_s_premium1.style.display = "inline"
    document.getElementById('form1').s_premium1.disabled = true;
}

function SPremium1NoLoad() {
    document.getElementById('form1').load_s_premium1.style.display = "none"
    document.getElementById('form1').s_premium1.disabled = false;
}

function SPremium2Load() {
    document.getElementById('form1').load_s_premium2.style.display = "inline"
    document.getElementById('form1').s_premium2.disabled = true;
}

function SPremium2NoLoad() {
    document.getElementById('form1').load_s_premium2.style.display = "none"
    document.getElementById('form1').s_premium2.disabled = false;
}

function SPremium3Load() {
    document.getElementById('form1').load_s_premium3.style.display = "inline"
    document.getElementById('form1').s_premium3.disabled = true;
}

function SPremium3NoLoad() {
    document.getElementById('form1').load_s_premium3.style.display = "none"
    document.getElementById('form1').s_premium3.disabled = false;
}

function SPremium4Load() {
    document.getElementById('form1').load_s_premium4.style.display = "inline"
    document.getElementById('form1').s_premium4.disabled = true;
}

function SPremium4NoLoad() {
    document.getElementById('form1').load_s_premium4.style.display = "none"
    document.getElementById('form1').s_premium4.disabled = false;
}



/***** End of Change pull down after select S_Premium *****/






function CNMobileNumberInit(){
     var IssueTypeObj = GetJID('issue_type');
     var CnMrtNoShowObj = GetJID("cn_mrt_no_show");
    if(IssueTypeObj!=undefined && CnMrtNoShowObj!=undefined &&
    (
        IssueTypeObj.value=="UPGRADE"  || IssueTypeObj.value=="WIN" || 
        IssueTypeObj.value=="3G_RETENTION" 
    )){
        CnMrtNoShowObj.style.display="inline";
    }
    else{
        CnMrtNoShowObj.style.display="none";
    }
}




function PageLoadCompleteRebateAmountLogic(){
    copy2m_rebate_amount();
    copy2rebate_amount();
    copy2r_offer();
    update_extra_rebate();
    copy2extra_rebate();
    update_amount();
}




function vaild_sup_date_by_calendar() {
    if (vaild_sup_date()) {

    }
}


function vaild_plan_date_by_calendar() {
    if (vaild_plan_date()) {

    }
}





//For Lenovo
function c_accessory_info() {
    var bFlag = true;
    var AccessoryDescDrpObj = GetJID('accessory_desc1');
    var AccessoryDescObj = GetJID('accessory_desc');
    var AccessoryCodeObj = GetJID('accessory_code');
    var AccessoryImeiObj = GetJID('accessory_imei');
    var AccessoryPriceObj = GetJID('accessory_price');

    if (AccessoryDescDrpObj == undefined) { bFlag = false; }
    if (AccessoryDescObj == undefined) { bFlag = false; }
    if (AccessoryCodeObj == undefined) { bFlag = false; }
    if (AccessoryImeiObj == undefined) { bFlag = false; }
    if (AccessoryPriceObj == undefined) { bFlag = false; }

    if (bFlag) {
        if (AccessoryDescDrpObj.disabled == false) {
            for (var i = 0; i < AccessoryDescDrpObj.options.length; i++) {
                if (AccessoryDescDrpObj.options[i].value == "")
                    AccessoryDescDrpObj.options[i].selected = true;
            }
        }
        AccessoryDescObj.value = "";
        AccessoryCodeObj.value = "";
        AccessoryImeiObj.value = "";
        AccessoryPriceObj.value = "";
    }
}

function SetCalendarDateOfBirthFormatMode() {
    var CalendarBehavior = $find("CalendarDateOfBirthFormat");
    if (CalendarBehavior != undefined) {
        CalendarBehavior._switchMode("years", true);
    }
}

function SetUpgradeExistingContractEdateFormateMode(){
    var CalendarBehavior = $find("UpgradeExistingContractEdateCalendarExtender");
    if (CalendarBehavior!=undefined){
        CalendarBehavior._switchMode("years", true);
    }
}

function SetUpgradeExistingContractSdateFormateMode(){
    var CalendarBehavior = $find("UpgradeExistingContractSdateCalendarExtender");
    if (CalendarBehavior!=undefined){
        CalendarBehavior._switchMode("years", true);
    }
}

function hideLoadingBox() {
    $("#global-loading").hide();
};

function showLoadingBox() {
    $("#global-loading").css("display", "block");
};

function AddressFormChk() {
    var IssueType = $("#issue_type");
    if (IssueType.val() == "") { return true; }
    var RegisteredAddressControl = $(".RegisteredAddressControl");
    var BillingAddressControl = $(".BillingAddressControl");
    var SmsMrtShow = $(".sms_mrt_show");
    var BillMediumEmailShow = $(".bill_medium_email_show");
    var Flag = true;
    if (RegisteredAddressControl.css("display") != "none" && Flag) {
        Flag = AddressControlInputChk("RegisteredAddressControl");
    }
    if (BillingAddressControl.css("display") != "none" && Flag) {
        Flag = AddressControlInputChk("BillingAddressControl");
    }
    if (SmsMrtShow.css("display") != "none" && Flag) {
        if ($(".sms_mrt").val() == "") {
            Flag = false;
            alert("Please kindly input sms mobile number!");
        }
    }
    /*
    if (BillMediumEmailShow.css("display") != "none" && Flag) {
        if ($(".bill_medium_email").val() == "") {
            Flag = false;
            alert("Please kindly input bill medium email!");
        }
    }
    */
    return Flag;
}

function BillMediumChange(Val) {
    BillMediumChange(Val, true);
}

function BillMediumChange(Val, Remove) {
    var IssueTypeObj = $("#issue_type");
    if (Val == "0") {//SMS bill $0
        $(".bill_medium_waive").attr("checked", false);
        $(".bill_medium_waive").attr("disabled", true);
        $(".sms_mrt_show").show();
        //$(".bill_medium_email_show").hide();
        if (Remove == true) { $(".bill_medium_email").val(''); }
        UserControlVisible("same_register_address_show", false);
        UserControlVisible("BillingAddressControl", false);
        AddressControlClear("BillingAddressControl");
    }
    else if (Val == "1") {//Email bill $0
        $(".bill_medium_waive").attr("checked", false);
        $(".bill_medium_waive").attr("disabled", true);
        //$(".bill_medium_email_show").show();
        $(".sms_mrt_show").hide();
        if (Remove == true) { $(".sms_mrt").val(''); }
        UserControlVisible("same_register_address_show", false);
        UserControlVisible("BillingAddressControl", false);
        AddressControlClear("BillingAddressControl");
    }
    else if (Val == "2") {//Paper bill $10
        if(IssueTypeObj.val()=="MOBILE_LITE"){
            if (Remove == true) { $(".bill_medium_waive").attr("checked", false); }
            $(".bill_medium_waive").attr("checked", true);
            $(".bill_medium_waive").attr("disabled", false);
        }
        else  if(IssueTypeObj.val()=="UPGRADE" || IssueTypeObj.val()=="WIN"){
            if (Remove == true) { $(".bill_medium_waive").attr("checked", false); }
            //$(".bill_medium_waive").attr("checked", true);
            $(".bill_medium_waive").attr("disabled", false);
        }
        
            
        //$(".bill_medium_email_show").hide();
        $(".sms_mrt_show").hide();
        if (Remove == true) { $(".bill_medium_email").val(''); }
        if (Remove == true) { $(".sms_mrt").val(''); }
        UserControlVisible("same_register_address_show", true);
        UserControlVisible("BillingAddressControl", true);
    }
    else if (Val == "3") {//SMS bill $0 + Email bill $0
        $(".bill_medium_waive").attr("checked", false);
        $(".bill_medium_waive").attr("disabled", true);
        $(".bill_medium_email_show").show();
        $(".sms_mrt_show").show();
        UserControlVisible("same_register_address_show", false);
        UserControlVisible("BillingAddressControl", false);
        AddressControlClear("BillingAddressControl");
    }
    else {
        $(".bill_medium_waive").attr("checked", false);
        $(".bill_medium_waive").attr("disabled", true);
        //$(".bill_medium_email_show").hide();
        $(".sms_mrt_show").hide();
        if (Remove == true) { $(".bill_medium_email").val(''); }
        if (Remove == true) { $(".sms_mrt").val(''); }
        UserControlVisible("same_register_address_show", false);
        UserControlVisible("BillingAddressControl", false);
        AddressControlClear("BillingAddressControl");
    }
}


//===================================Function of MONTHLY PAYMENT METHOD ======================================================
function MonthlyPaymentAlert(i, show) {
    MonthlyPaymentAlert(i, show, true);
}
function MonthlyPaymentAlert(i, show, remove) {
    var ChangePaymentTypeObj = GetJID('change_payment_type');
    if (i == "change_payment_method") {
        if (show == true) {
            alert("更改月費付款方式只適用於登記本人（不接受第三者信用咭)");
        }
        MonthlyPaymentCreditCard(true, remove);
        MonthlyPaymentBankAccount(false, remove);
        ChangePaymentTypeSetVal("CREDIT CARD");

    }
    else {
        MonthlyPaymentCreditCard(false, remove);
        MonthlyPaymentBankAccount(false, remove);
    }
    if (ChangePaymentTypeObj != undefined) {
        ChangePaymentType(ChangePaymentTypeObj.value, remove);
    }
}

function MonthlyPayment(i) {
    MonthlyPaymentAlert(i);
}

function ChangePaymentTypeSetVal(val) {
    $('[name="change_payment_type"]').each(function() {
        var type = this.type;
        var tag = this.tagName.toLowerCase();
        if (type == 'radio') {
            if (this.value == val) {
                this.checked = true;
            }
        }
    });
}
function MonthPayMentMethodDefault(Val) {
    MonthPayMentMethodDefault(Val, false, false);
}

function MonthPayMentMethodDefaultSet(Val, Show, Remove) {
    MonthPayMentMethodDefault(Val, Show, Remove);
}

function MonthPayMentMethodDefault(Val, Show, Remove) {
    var MonthPayMentMethodShow = $(".monthly_payment_method_span :input");
    if (MonthPayMentMethodShow != undefined) {
        MonthPayMentMethodShow.each(function() {
            var type = this.type;
            var tag = this.tagName.toLowerCase();
            if (type == 'radio') {
                if (this.value == Val) {
                    this.checked = true;
                    MonthlyPaymentAlert(this.value, Show, Remove);
                }
            }
        });
    }
    else {
        alert("MonthPayMentMethodShow = undefined!");
    }
}


function UserControlVisible(ControlName, visible) {

    var UserControl = $("." + ControlName);
    if (UserControl != undefined) {
        if (visible == true || visible == "true") {
            //UserControl.style.display = "inline";
            UserControl.show();

            return;
        }
        else {
            //UserControl.style.display = "none";
            UserControl.hide();

            return;
        }
    }

    UserControl = GetJID(ControlName);
    if (UserControl != undefined) {
        if (visible == true || visible == "true") {
            UserControl.style.display = "inline";
            //UserControl.show();

            return;
        }
        else {
            UserControl.style.display = "none";
            //UserControl.hide();

            return;
        }
    }
}



function chk_date2(dtobj, chkempty, gtToday) {
    var today = new Date()
    if (dtobj.value != "" || chkempty == 1) {
        if (dtobj.value.match(/^\d{8}$/) == null) {
        }
        else {
            txt = dtobj.value.substring(0, 2) + "/" + dtobj.value.substring(2, 4) + "/" + dtobj.value.substring(4, 8)
            dtobj.value = txt
        }
        dt = "";
        //	if(today.getMonth()+1<10)
        //		dt="0"

        dt += today.getDate();
        dt += "/"
        dt += today.getMonth() + 1;
        dt += "/";
        dt += today.getYear();

        //alert (dt);
        var datePat = /^(\d{1,2})(\/|-)(\d{1,2})\2(\d{2}|\d{4})$/;
        var matchArray = dtobj.value.match(datePat); // is the format ok?
        if (matchArray == null) {
            alert("日期格式不正確!!")

            if (gtToday != 2)
                dtobj.value = dt;
            else
                dtobj.value = "";

            return false;
        }
        month = matchArray[3]; // parse date into variables
        day = matchArray[1];
        year = matchArray[4];
        if (month < 1 || month > 12) { // check month range
            alert("請選擇1至12內的數字作月份.");
            dtobj.value = dt;
            return false;
        }
        if (day < 1 || day > 31) {
            alert("請選擇1至31內的數字作日期");
            dtobj.value = dt;
            return false;
        }
        if ((month == 4 || month == 6 || month == 9 || month == 11) && day == 31) {
            alert("這個是 " + month + "月不會有31號")
            dtobj.value = dt;
            return false
        }
        if (month == 2) { // check for february 29th
            var isleap = (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
            if (day > 29 || (day == 29 && !isleap)) {
                alert("二月在 " + year + " 年不會有" + day + "日!");
                dtobj.value = dt;
                return false;
            }
        }
        var today = new Date()
        var myDate = new Date()

        myDate.setFullYear(year, month - 1, day)

        if (gtToday == 1) {
            if (myDate < today) {
                alert("輸入日子需要大於今天!")
                dtobj.value = dt;
                return false;
            }
        }

        if (gtToday == 2) {
            if (myDate >= today) {
                alert("輸入日子需要少於今天!!")
                dtobj.value = "";
                return false;
            }
        }

        return true;
    }
}

//---------------- All function about Date -------------------//
function en_plan_date(tval) {

    if (tval == "NBD") {
        GetJID('form1').plan_eff_date.disabled = true
        GetJID('form1').plan_eff_date.value = ""
        GetJID('form1').plan_eff_date.style.background = "#DDDDDD";
    }
    else {
        GetJID('form1').plan_eff_date.disabled = false
        GetJID('form1').plan_eff_date.value = ""
        GetJID('form1').plan_eff_date.style.background = "#FFFFFF";
    }
}



function chk_special_dd() {
    var tempdate = GetJID('form1').d_date.value.split("/")
    var ddate = new Date()
    var chk_date = ""
    //	var vaild_date = 20071129

    chk_date = tempdate[2] + tempdate[1] + tempdate[0]
    ddate.setFullYear(tempdate[2], tempdate[1] - 1, tempdate[0])

    if ((chk_date == '20071228' || chk_date == '20080102') && (GetJID('form1').d_time.value == "18-20" || GetJID('form1').d_time.value == "20-22"))
        return true

    if (((ddate.getDay() != 1 && ddate.getDay() != 4) || chk_date == '20071224' || chk_date == '20071231') && (GetJID('form1').d_time.value == "18-20" || GetJID('form1').d_time.value == "20-22"))
        return false
    else
        return true
}
//---------------- All function about Date -------------------//


//=================================PCD PAID==============================//
function ShowPCDGoWirelessTooChk() {
    if (GetJID("program") != undefined) {
        if (GetJID("program").value == "NETVIGATOR EVERYWHERE") {
            if (GetJID("pcd_paid_go_wireless_show") != undefined) GetJID("pcd_paid_go_wireless_show").style.display = 'inline';
            if (GetJID("pcd_paid_go_wireless") != undefined) GetJID("pcd_paid_go_wireless").value = "1";
        }
        else {

            if (GetJID("pcd_paid_go_wireless_show") != undefined) GetJID("pcd_paid_go_wireless_show").style.display = 'none';
            if (GetJID("pcd_paid_go_wireless") != undefined) GetJID("pcd_paid_go_wireless").value = "";
        }
    }
}

function click_pcd_paid_go_wireless() {
    if (GetJID("pcd_paid_go_wireless") != undefined) {
        if (GetJID("pcd_paid_go_wireless").checked) {
            GetJID("pcd_paid_go_wireless").value = "1";
            if (GetJID("form1").next_bill != undefined) GetJID("form1").next_bill.disabled = true;
            if (GetJID("form1").lob != undefined) GetJID("form1").lob.disabled = false
            if (GetJID("form1").lob != undefined) GetJID("form1").lob.style.background = "#FFFFbb";
            if (GetJID("form1").lob_ac != undefined) GetJID("form1").lob_ac.disabled = false
            if (GetJID("form1").lob_ac != undefined) GetJID("form1").lob_ac.style.background = "#FFFFbb";
            if (GetJID("form1").go_wireless_package_code != undefined) GetJID("form1").go_wireless_package_code.disabled = false
            if (GetJID("form1").go_wireless_package_code != undefined) GetJID("form1").go_wireless_package_code.value = ""
            if (GetJID("form1").go_wireless_package_code != undefined) GetJID("form1").go_wireless_package_code.style.background = "#FFFFbb";

        }
        else {
            GetJID("pcd_paid_go_wireless").value = "";
            if (GetJID("form1").next_bill != undefined) GetJID("form1").next_bill.disabled = false;
            if (GetJID("form1").lob != undefined) GetJID("form1").lob.disabled = true
            if (GetJID("form1").lob != undefined) GetJID("form1").lob.value = ""
            if (GetJID("form1").lob != undefined) GetJID("form1").lob.style.background = "#DDDDDD";
            if (GetJID("form1").lob_ac != undefined) GetJID("form1").lob_ac.disabled = true
            if (GetJID("form1").lob_ac != undefined) GetJID("form1").lob_ac.value = ""
            if (GetJID("form1").lob_ac != undefined) GetJID("form1").lob_ac.style.background = "#DDDDDD";
            if (GetJID("form1").go_wireless_package_code != undefined) GetJID("form1").go_wireless_package_code.disabled = true
            if (GetJID("form1").go_wireless_package_code != undefined) GetJID("form1").go_wireless_package_code.value = ""
            if (GetJID("form1").go_wireless_package_code != undefined) GetJID("form1").go_wireless_package_code.style.background = "#DDDDDD";
        }

    }
}

//=================================PCD PAID==============================//

//========================================Next Bill Cut Date========================================================
function click_nextbillcutdate(action_value) {

    var NextBillObj = GetJID("next_bill");
    var ConEffDateObj = GetJID("con_eff_date");
    var PlanEff_0Obj = GetJID("plan_eff_0");
    if (NextBillObj != undefined && ConEffDateObj != undefined) {


        if (action_value == "click") {
            if (NextBillObj.checked) {
                NextBillObj.value = "1";

                temp_con_eff_date = ConEffDateObj.value;
                ConEffDateObj.value = "";
                ConEffDateObj.disabled = true;

                ConEffDateObj.className = "disablerow";

                //Check Next Bill Date if Next Bill Cut Date is checked
                PlanEff_0Obj.checked = true;
                en_plan_date('NBD');

            } else {
                NextBillObj.value = "";
                //alert(temp_con_eff_date);
                ConEffDateObj.value = temp_con_eff_date;
                ConEffDateObj.disabled = false;
                ConEffDateObj.className = "highlightrow";
            }
        }
        else {
            if (action_value != "") {
                NextBillObj.checked = false;
                divstyle = GetJID("div_next_bill").style.visibility;
                if (divstyle.toLowerCase() == "visible" || divstyle == "") {
                    GetJID("div_next_bill").style.visibility = "hidden";
                    NextBillObj.value = "";
                    //alert(temp_con_eff_date);
                    ConEffDateObj.value = temp_con_eff_date;
                    ConEffDateObj.disabled = false;
                    ConEffDateObj.className = "highlightrow";
                }
                else {
                    //GetJID("div_next_bill").style.visibility = "visible";
                }

            }
            else if (action_value == "") {
                GetJID("div_next_bill").style.visibility = "visible";
            }
        }

    }
}

//========================================End Of Next Bill Cut Date========================================================


//-------------------------------------------------------------- BillCutDate ----------------------------------------------------//
function AutoSetBillCutDate() {
    try {
        var NowToday = new Date();
        var BillCutNumObj = GetJID('bill_cut_num');
        var BillCutDateObj = GetJID('bill_cut_date');
        var ConEffectiveDateObj = GetJID("con_eff_date");
        if (BillCutNumObj != undefined && BillCutNumObj != undefined && ConEffectiveDateObj != undefined) {
            var BillCutNumValue = BillCutNumObj.value;
            if (BillCutNumValue != "") {
                var BillCutNumIntValue = parseInt(BillCutNumValue,10);
                var CompDate = new Date();
                CompDate.setDate(BillCutNumIntValue);

                var ConEffectiveDate = new Date();
                if (ConEffectiveDateObj.value != "") {
                    var temp = new Array();
                    temp = ConEffectiveDateObj.value.split("/");
                    ConEffectiveDate = Date.parse(temp[1] + "/" + temp[0] + "/" + temp[2]);
                }
                //alert("(ConEffectiveDate > CompDate):"+(ConEffectiveDate > CompDate));
                //alert("NowToday>CompDate :"+(NowToday > CompDate ));
                //alert("NowToday.getDate():"+NowToday.getDate());
                //alert("CompDate.getDate():"+CompDate.getDate());
                //set Bill Cut Date
                if (NowToday > CompDate || (ConEffectiveDateObj.value != "" && (ConEffectiveDate > CompDate)) || NowToday.getDate() == CompDate.getDate()) {
                    var next_month = CompDate.getMonth() + 1;
                    var next_year = CompDate.getFullYear();
                    if (next_month > 11) {
                        next_month = 0;
                        next_year = next_year + 1;
                    }
                    CompDate.setMonth(next_month);
                    CompDate.setYear(next_year);

                } else {

                }
                if (CompDate.getDate() > 0 && CompDate.getDate() < 32) {
                    BillCutDateObj.value = CompDate.getDate() + "/" + (CompDate.getMonth() + 1) + "/" + CompDate.getFullYear();
                }
                else
                    BillCutDateObj.value = "";
            }
        }
    }
    catch (e) {
        ErrorLog(e, "AutoSetBillCutDate Error:");
    }
}

//--------------------------------------------------------------End BillCutDate ----------------------------------------------------//


//********************************************** Check Bill Cut Date *******************************//
function ValidBillCutDate() {
    return true;
}
/////////////////////////////////////////////////////////////////////////////////



function ParseDate(DateStr) {
            if (DateStr.indexOf(" ") > 0) {
                var tempDate = new Array();
                tempDate = DateStr.split(" ");
                DateStr = tempDate[0];
            }
            var temp1 = new Array()
            temp1 = DateStr.split("/")
            var Year = temp1[2];
            var Month = temp1[1];
            var Month = parseInt(Month,10) - 1;
            var Day = temp1[0];
            var new_date = new Date(Year, Month, Day)
            return new_date
}

/*
$(document).ready(function() {
$(".MobileOrderMNPDetailservice_activation_date").blur(ValidServiceActivationDate);
$(".MobileOrderMNPDetailservice_activation_date").change(ValidServiceActivationDate);
});
*/

function valid_thur(card_mon, card_yr) {

    if (card_mon != "" && card_yr != "") {
        var today = new Date()

        var valid_mon = (today.getMonth() + 4) % 12;
        if (valid_mon == 0) valid_mon = 12;
        if (today.getMonth() + 4 > 12) var valid_year = today.getYear() + 1;
        else var valid_year = today.getYear();

        if (card_mon == "08") var month = 8;
        else if (card_mon == "09") var month = 9;
        else var month = parseInt(card_mon,10);
        var year = parseInt(card_yr,10);

        valid_mon1 = valid_mon + 100 + ''
        valid_mon1 = valid_mon1.substring(1, 3)

        if (parseInt(valid_year + '' + valid_mon1,10) > parseInt(card_yr + '' + card_mon,10)) {
            alert("Invalid Vaild Thur!");
            return false
        }
        else
            return true
    }
}


function CheckMontlyPaymentMethod() {
    var ActionRequiredObj = GetJID('action_required');
    var ActionRequired2Obj = GetJID('action_required2');
    if(ActionRequiredObj!=undefined && ActionRequired2Obj!=undefined){
        if(ActionRequiredObj.checked!=true && ActionRequired2Obj.checked!=true){
        
            var Payment = GetJID('monthly_payment_method_1');
            if (Payment != undefined) {
                if (Payment.checked) {
                    var m_card_type = GetJID('m_card_type');
                    var m_card_no = GetJID('m_card_no');
                    var m_card_holder2 = GetJID('m_card_holder2');
                    var m_card_exp_month = GetJID('m_card_exp_month');
                    var m_card_exp_year = GetJID('m_card_exp_year');
                    var Flag = true;
                    if (m_card_type != undefined && Flag) {
                        if (m_card_type.disabled == false) {
                            if (m_card_type.value == "") {
                                alert("Please select credit card type!");
                                Flag = false;
                            }
                        }
                    }

                    if (m_card_no != undefined && Flag) {
                        if (m_card_no.disabled == false) {
                            if (m_card_no.value == "") {
                                alert("Please select credit no!");
                                Flag = false;
                            }
                        }
                    }
                    if (m_card_holder2 != undefined && Flag) {
                        if (m_card_holder2.disabled == false) {
                            if (m_card_holder2.value == "") {
                                alert("Please select credit card holder!");
                                Flag = false;
                            }
                        }
                    }
                    if (m_card_exp_month != undefined && Flag) {
                        if (m_card_exp_month.disabled == false) {
                            if (m_card_exp_month.value == "") {
                                alert("Please Enter Credit Card Expiry Date !");
                                Flag = false;
                            }
                        }
                    }
                    if (m_card_exp_year != undefined && Flag) {
                        if (m_card_exp_year.disabled == false) {
                            if (m_card_exp_year.value == "") {
                                alert("Please Enter Credit Card Expiry Date !");
                                Flag = false;
                            }
                        }
                    }

                    if (m_card_exp_month != undefined && m_card_exp_year != undefined && Flag) {
                        if (m_card_exp_month.disabled == false) {
                            if (m_card_exp_month.value != "" && m_card_exp_year.value != "") {
                                if (!valid_thur(m_card_exp_month.value, m_card_exp_year.value)) {
                                    Flag = false;
                                }
                            }
                        }
                    }

                    if (!checkCreditCard(GetJID('m_card_no').value, GetJID('m_card_type').value) && Flag) {
                        alert('Invalid token!');
                        Flag = false;
                    }
                    return Flag;
                }
            }
        }
    }
    return true;
}

function GetJID(ID) {
    var Obj = $('#' + ID);
    if (Obj != undefined) { return document.getElementById(Obj.attr('id')); }
    Obj = $('.' + ID);
    if (Obj != undefined) { return document.getElementById(Obj.attr('id')); }
    Obj = $("[id*=" + ID + "]");
    if (Obj != undefined) { return document.getElementById(Obj.attr('id')); }
    Obj = $("[name*=" + ID + "]");
    if (Obj != undefined) { return document.getElementByName(Obj.attr('name')); }
    Obj = document.getElementById(ID);
    if (Obj != undefined) { return Obj; }
    return null;
}


function MonthlyPaymentCreditCard(active, remove) {
    if (active == true) {
        if (GetJID('m_card_type') != undefined) GetJID('m_card_type').disabled = false
        if (GetJID('m_card_no') != undefined) GetJID('m_card_no').disabled = false

        if (GetJID('m_card_holder2') != undefined) GetJID('m_card_holder2').disabled = false
        if (GetJID('m_card_exp_month') != undefined) GetJID('m_card_exp_month').disabled = false
        if (GetJID('m_card_exp_year') != undefined) GetJID('m_card_exp_year').disabled = false
        if (GetJID('but_m_card_no') != undefined) GetJID('but_m_card_no').disabled = false;

        if (GetJID('m_card_type') != undefined) GetJID('m_card_type').style.background = "#FFFFbb";
        if (GetJID('m_card_no') != undefined) GetJID('m_card_no').style.background = "#FFFFbb";

        if (GetJID('m_card_holder2') != undefined) GetJID('m_card_holder2').style.background = "#FFFFbb";
        if (GetJID('m_card_exp_month') != undefined) GetJID('m_card_exp_month').style.background = "#FFFFbb";
        if (GetJID('m_card_exp_year') != undefined) GetJID('m_card_exp_year').style.background = "#FFFFbb";
    }
    else {
        if (GetJID('m_card_type') != undefined) GetJID('m_card_type').disabled = true
        if (GetJID('m_card_no') != undefined) GetJID('m_card_no').disabled = true;
        if (GetJID('m_card_holder2') != undefined) GetJID('m_card_holder2').disabled = true
        if (GetJID('m_card_exp_month') != undefined) GetJID('m_card_exp_month').disabled = true
        if (GetJID('m_card_exp_year') != undefined) GetJID('m_card_exp_year').disabled = true
        if (GetJID('but_m_card_no') != undefined) GetJID('but_m_card_no').disabled = true;

        if (remove == true) {
            if (GetJID('m_card_type') != undefined) {
                GetJID('m_card_type').value = "";
                GetJID('m_card_type').selectedIndex = 0;
            }
            if (GetJID('m_card_no') != undefined) GetJID('m_card_no').value = "";
            if (GetJID('m_card_holder2') != undefined) GetJID('m_card_holder2').value = ""
            if (GetJID('m_card_exp_month') != undefined) GetJID('m_card_exp_month').value = ""
            if (GetJID('m_card_exp_year') != undefined) GetJID('m_card_exp_year').value = ""
        }

        if (GetJID('m_card_type') != undefined) GetJID('m_card_type').style.background = "#DDDDDD";
        if (GetJID('m_card_no') != undefined) GetJID('m_card_no').style.background = "#DDDDDD";
        if (GetJID('m_card_holder2') != undefined) GetJID('m_card_holder2').style.background = "#DDDDDD";
        if (GetJID('m_card_exp_month') != undefined) GetJID('m_card_exp_month').style.background = "#DDDDDD";
        if (GetJID('m_card_exp_year') != undefined) GetJID('m_card_exp_year').style.background = "#DDDDDD";
    }
}

function MonthlyPaymentBankAccount(active, remove) {
    if (active == true) {
        if (GetJID('monthly_bank_account_bank_code') != undefined) GetJID('monthly_bank_account_bank_code').disabled = false
        if (GetJID('monthly_bank_account_branch_code') != undefined) GetJID('monthly_bank_account_branch_code').disabled = false

        if (GetJID('monthly_bank_account_no') != undefined) GetJID('monthly_bank_account_no').disabled = false
        if (GetJID('monthly_bank_account_id_type') != undefined) GetJID('monthly_bank_account_id_type').disabled = false
        if (GetJID('monthly_bank_account_hkid') != undefined) GetJID('monthly_bank_account_hkid').disabled = false
        if (GetJID('monthly_bank_account_hkid2') != undefined) GetJID('monthly_bank_account_hkid2').disabled = false;
        if (GetJID('monthly_bank_account_holder') != undefined) GetJID('monthly_bank_account_holder').disabled = false;

        if (GetJID('monthly_bank_account_bank_code') != undefined) GetJID('monthly_bank_account_bank_code').style.background = "#FFFFbb";
        if (GetJID('monthly_bank_account_branch_code') != undefined) GetJID('monthly_bank_account_branch_code').style.background = "#FFFFbb";

        if (GetJID('monthly_bank_account_no') != undefined) GetJID('monthly_bank_account_no').style.background = "#FFFFbb";
        if (GetJID('monthly_bank_account_id_type') != undefined) GetJID('monthly_bank_account_id_type').style.background = "#FFFFbb";
        if (GetJID('monthly_bank_account_hkid') != undefined) GetJID('monthly_bank_account_hkid').style.background = "#FFFFbb";
        if (GetJID('monthly_bank_account_hkid2') != undefined) GetJID('monthly_bank_account_hkid2').style.background = "#FFFFbb";
        if (GetJID('monthly_bank_account_holder') != undefined) GetJID('monthly_bank_account_holder').style.background = "#FFFFbb";
    }
    else {
        if (GetJID('monthly_bank_account_bank_code') != undefined) GetJID('monthly_bank_account_bank_code').disabled = true
        if (GetJID('monthly_bank_account_branch_code') != undefined) GetJID('monthly_bank_account_branch_code').disabled = true;
        if (GetJID('monthly_bank_account_no') != undefined) GetJID('monthly_bank_account_no').disabled = true
        if (GetJID('monthly_bank_account_id_type') != undefined) GetJID('monthly_bank_account_id_type').disabled = true
        if (GetJID('monthly_bank_account_hkid') != undefined) GetJID('monthly_bank_account_hkid').disabled = true
        if (GetJID('monthly_bank_account_hkid2') != undefined) GetJID('monthly_bank_account_hkid2').disabled = true;
        if (GetJID('monthly_bank_account_holder') != undefined) GetJID('monthly_bank_account_holder').disabled = true;

        if (remove == true) {
            if (GetJID('monthly_bank_account_bank_code') != undefined) GetJID('monthly_bank_account_bank_code').value = ""
            if (GetJID('monthly_bank_account_branch_code') != undefined) GetJID('monthly_bank_account_branch_code').value = "";
            if (GetJID('monthly_bank_account_no') != undefined) GetJID('monthly_bank_account_no').value = ""
            if (GetJID('monthly_bank_account_id_type') != undefined) GetJID('monthly_bank_account_id_type').value = ""
            if (GetJID('monthly_bank_account_hkid') != undefined) GetJID('monthly_bank_account_hkid').value = ""
            if (GetJID('monthly_bank_account_hkid2') != undefined) GetJID('monthly_bank_account_hkid2').value = ""
            if (GetJID('monthly_bank_account_holder') != undefined) GetJID('monthly_bank_account_holder').value = ""
        }

        if (GetJID('monthly_bank_account_bank_code') != undefined) GetJID('monthly_bank_account_bank_code').style.background = "#DDDDDD";
        if (GetJID('monthly_bank_account_branch_code') != undefined) GetJID('monthly_bank_account_branch_code').style.background = "#DDDDDD";
        if (GetJID('monthly_bank_account_no') != undefined) GetJID('monthly_bank_account_no').style.background = "#DDDDDD";
        if (GetJID('monthly_bank_account_id_type') != undefined) GetJID('monthly_bank_account_id_type').style.background = "#DDDDDD";
        if (GetJID('monthly_bank_account_hkid') != undefined) GetJID('monthly_bank_account_hkid').style.background = "#DDDDDD";
        if (GetJID('monthly_bank_account_hkid2') != undefined) GetJID('monthly_bank_account_hkid2').style.background = "#DDDDDD";
        if (GetJID('monthly_bank_account_holder') != undefined) GetJID('monthly_bank_account_holder').style.background = "#DDDDDD";
    }
}

function Monthly3rdPartyInfo(active, remove) {
    if (active == true) {
        if (GetJID('m_3rd_contact_no') != undefined) GetJID('m_3rd_contact_no').disabled = false
        if (GetJID('m_3rd_id_type') != undefined) GetJID('m_3rd_id_type').disabled = false

        if (GetJID('m_3rd_hkid') != undefined) GetJID('m_3rd_hkid').disabled = false
        if (GetJID('m_3rd_hkid2') != undefined) GetJID('m_3rd_hkid2').disabled = false

        if (GetJID('m_3rd_contact_no') != undefined) GetJID('m_3rd_contact_no').style.background = "#FFFFbb";
        if (GetJID('m_3rd_id_type') != undefined) GetJID('m_3rd_id_type').style.background = "#FFFFbb";
        if (GetJID('m_3rd_hkid') != undefined) GetJID('m_3rd_hkid').style.background = "#FFFFbb";
        if (GetJID('m_3rd_hkid2') != undefined) GetJID('m_3rd_hkid2').style.background = "#FFFFbb";

    }
    else {
        if (GetJID('m_3rd_contact_no') != undefined) GetJID('m_3rd_contact_no').disabled = true
        if (GetJID('m_3rd_id_type') != undefined) GetJID('m_3rd_id_type').disabled = true;
        if (GetJID('m_3rd_hkid') != undefined) GetJID('m_3rd_hkid').disabled = true
        if (GetJID('m_3rd_hkid2') != undefined) GetJID('m_3rd_hkid2').disabled = true


        if (remove == true) {
            if (GetJID('m_3rd_contact_no') != undefined) GetJID('m_3rd_contact_no').value = ""
            if (GetJID('m_3rd_id_type') != undefined) GetJID('m_3rd_id_type').value = "";
            if (GetJID('m_3rd_hkid') != undefined) GetJID('m_3rd_hkid').value = ""
            if (GetJID('m_3rd_hkid2') != undefined) GetJID('m_3rd_hkid2').value = ""

        }

        if (GetJID('m_3rd_contact_no') != undefined) GetJID('m_3rd_contact_no').style.background = "#DDDDDD";
        if (GetJID('m_3rd_id_type') != undefined) GetJID('m_3rd_id_type').style.background = "#DDDDDD";
        if (GetJID('m_3rd_hkid') != undefined) GetJID('m_3rd_hkid').style.background = "#DDDDDD";
        if (GetJID('m_3rd_hkid2') != undefined) GetJID('m_3rd_hkid2').style.background = "#DDDDDD";
    }
}



function ChangePaymentType(val, remove) {
    if (val == "CREDIT CARD") {
        MonthlyPaymentCreditCard(true, remove);
        MonthlyPaymentBankAccount(false, remove);
        ChangePaymentTypeSetVal("CREDIT CARD");
    }
    else if (val == "COD") {
        MonthlyPaymentCreditCard(false, remove);
        MonthlyPaymentBankAccount(false, remove);
        ChangePaymentTypeSetVal("COD");
    }
    else if (val == "BANK ACCOUNT") {
        MonthlyPaymentCreditCard(false, remove);
        MonthlyPaymentBankAccount(true, remove);
        ChangePaymentTypeSetVal("BANK ACCOUNT");
    }
}

function ChkChangePaymentType() {

    var MonthlyPaymentTypeObj = GetJID('monthly_payment_type');
    var MCardType = GetJID('m_card_type');
    var MCardNo = GetJID('m_card_no');
    var MCardHolder2 = GetJID('m_card_holder2');
    var MCardExpMonth = GetJID('m_card_exp_month');
    var MCardExpYear = GetJID('m_card_exp_year');

    if (MonthlyPaymentTypeObj != undefined && MCardNo != undefined &&
     MCardType != undefined && MCardHolder2 != undefined &&
     MCardExpMonth != undefined && MCardExpYear != undefined) {
        if (MonthlyPaymentTypeObj.value == "CHANGE TO CREDIT CARD") {
            if (MCardType.val() == "") {
                alert("Please kindly enter the card type!");
                return false;
            }
            if (MCardNo.vvalue == "") {
                alert("Please kindly enter the card no!");
                return false;
            }
            if (MCardHolder2.value == "") {
                alert("Please kindly enter the card expiry holder!");
                return false;
            }
            if (MCardExpMonth.value == "") {
                alert("Please kindly enter the card expiry month!");
                return false;
            }
            if (MCardExpYear.value == "") {
                alert("Please kindly enter the card expiry year!");
                return false;
            }
        }
    }
    return true;
}


function CreditCardChk1() {
    var ActionRequiredObj = GetJID('action_required');
    var ActionRequired2Obj = GetJID('action_required2');
    var CardNoObj = GetJID('card_no');
    var CardTypeObj = GetJID('card_type');
    var CardHolderObj = GetJID('card_holder');
    var CardExpMonthObj = GetJID('card_exp_month');
    var CardExpYearObj = GetJID('card_exp_year');
    var PayMethodObj = GetJID('pay_method');
    var ChangePaymentType = GetJID('change_payment_type');
    var MonthlyPaymentTypeObj = GetJID('monthly_payment_type');

    var Flag = true;
    if (ActionRequiredObj != undefined &&
     ActionRequired2Obj != undefined &&
     CardNoObj != undefined &&
     CardTypeObj != undefined &&
     CardHolderObj != undefined &&
     CardExpMonthObj != undefined &&
     CardExpYearObj != undefined &&
     PayMethodObj != undefined &&
     MonthlyPaymentTypeObj != undefined
     ) {

        if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) &&
    HsModelObj.value != "" &&
    (
        PayMethodObjvalue == "CREDIT CARD" ||
        PayMethodObj.value == "CREDIT CARD INSTALLMENT"
    )
    ) {
            if (CardNoObj.disabled == false) {
                if (CardNoObj.value == "") {
                    alert("Please kindly input DELIVERY INFORMATION card no!");
                    Flag = false;
                }
            }
            if (CardTypeObj.disabled == false) {
                if (CardTypeObj.value == "") {
                    alert("Please kindly input  DELIVERY INFORMATION card type!");
                    Flag = false;
                }
            }
            if (CardHolderObj.disabled == false) {
                if (CardHolderObj.value == "") {
                    alert("Please kindly input  DELIVERY INFORMATION card holder!");
                    Flag = false;
                }
            }
            if (CardExpMonthObj.disabled == false) {
                if (CardExpMonthObj.value == "") {
                    alert("Please kindly input  DELIVERY INFORMATION card exp month!");
                    Flag = false;
                }
            }
            if (CardExpYearObj.disabled == false) {
                if (CardExpYearObj.value == "") {
                    alert("Please kindly input  DELIVERY INFORMATION card exp year!");
                    Flag = false;
                }
            }
        }
    }
    return Flag;
}

function CreditCardChk2() {
    var ActionRequiredObj = GetJID('action_required');
    var ActionRequired2Obj = GetJID('action_required2');
    var CardNoObj = GetJID('m_card_no');
    var CardTypeObj = GetJID('m_card_type');
    var CardHolderObj = GetJID('m_card_holder');
    var CardExpMonthObj = GetJID('m_card_exp_month');
    var CardExpYearObj = GetJID('m_card_exp_year');
    var MonthPaymentMethod1 = GetJID('monthly_payment_method_1');
    var Flag = true;

    if (ActionRequiredObj != undefined &&
     ActionRequired2Obj != undefined &&
     CardNoObj != undefined &&
     CardTypeObj != undefined &&
     CardHolderObj != undefined &&
     CardExpMonthObj != undefined &&
     CardExpYearObj != undefined &&
     MonthPaymentMethod1 != undefined
     ) {
        if (MonthPaymentMethod1.checked == true && CardNoObj.value == "") {
            if (CardNoObj.disabled == false) {
                if (CardNoObj.value == "") {
                    alert("Please kindly input MONTHLY PAYMENT METHOD card no!");
                    Flag = false;
                }
            }
            if (CardTypeObj.disabled == false) {
                if (CardTypeObj.value == "") {
                    alert("Please kindly input MONTHLY PAYMENT METHOD card type!");
                    Flag = false;
                }
            }
            if (CardHolderObj.disabled == false) {
                if (CardHolderObj.value == "") {
                    alert("Please kindly input MONTHLY PAYMENT METHOD card holder!");
                    Flag = false;
                }
            }
            if (CardExpMonthObj.disabled == false) {
                if (CardExpMonthObj.value == "") {
                    alert("Please kindly input MONTHLY PAYMENT METHOD card exp month!");
                    Flag = false;
                }
            }
            if (CardExpYearObj.disabled == false) {
                if (CardExpYearObj.value == "") {
                    alert("Please kindly input MONTHLY PAYMENT METHOD card exp year!");
                    Flag = false;
                }
            }
        }
    }
    return Flag;
}



function vaild_sup_date() {
    GetJID('global-loading').style.display = "none";
    if (GetJID('form1').action_required.checked) {
        var temp1 = new Array()
        temp1 = GetJID('form1').action_eff_date.value.split("/")
        var action_eff_date = new Date()
        action_eff_date = Date.parse(temp1[1] + "/" + temp1[0] + "/" + temp1[2])

        var today = new Date()
        new_today = Date.parse(today.getMonth() + 1 + "/" + today.getDate() + "/" + today.getYear())

        if (((action_eff_date - new_today) / 86400000) < 1) {
            alert("生效日期需要大於T!")
            return false;
        }
        if (((action_eff_date - new_today) / 86400000) > 60) {
            alert("生效日期不能大於T+60!")
            return false;
        }

        return true;
    }
}




function valid_thur(card_mon, card_yr) {
    if (card_mon != "" && card_yr != "") {
        var today = new Date()

        var valid_mon = (today.getMonth() + 4) % 12;
        if (valid_mon == 0) valid_mon = 12;
        if (today.getMonth() + 4 > 12) var valid_year = today.getYear() + 1;
        else var valid_year = today.getYear();

        if (card_mon == "08") var month = 8;
        else if (card_mon == "09") var month = 9;
        else var month = parseInt(card_mon,10);
        var year = parseInt(card_yr,10);

        valid_mon1 = valid_mon + 100 + ''
        valid_mon1 = valid_mon1.substring(1, 3)

        if (parseInt(valid_year + '' + valid_mon1,10) > parseInt(card_yr + '' + card_mon,10)) {
            alert("Invalid Credit Card Expiry Date!");
            return false
        }
        else
            return true
    }
}


function GetXmlHttpObject() {
    var xmlHttp = null;
    try {
        // Firefox, Opera 8.0+, Safari
        xmlHttp = new XMLHttpRequest();
    }
    catch (e) {
        // Internet Explorer
        try {
            xmlHttp = new ActiveXObject("Msxml2.XMLHTTP");
        }
        catch (e) {
            xmlHttp = new ActiveXObject("Microsoft.XMLHTTP");
        }
    }
    return xmlHttp;
}


function chkHkidForIphone() {
    var isValidForIphone = 0;
    hkid = GetJID('form1').hkid.value + GetJID('form1').hkid2.value
    sku = GetJID('form1').sku.value
    id = (GetJID('MobileRetentionOrder_id') != null) ? GetJID("MobileRetentionOrder_id").value : "";
    if (hkid != "") {
        xmlhttp = GetXmlHttpObject();
        xmlhttp.onreadystatechange = function() {
            if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                if (xmlhttp.responseText == "false") {
                    //alert("repsonse false");
                    isValidForIphone = 1; //<-- Colin教啲不會pass 走,因為一定要set isValidForIphone
                } else if (xmlhttp.responseText == "true") {
                    //alert("repsonse true");
                    isValidForIphone = 2; //<-- Colin教啲不會pass 走,因為一定要set isValidForIphone
                }
            }
        }
        xmlhttp.open("GET", "AjaxFunc/CheckIphoneHKID.ashx?hkid=" + hkid + "&sku=" + sku + "&id=" + id, false);
        xmlhttp.send();
    }
    if (isValidForIphone > 0) {
        return isValidForIphone;
    }
}



//********************************************** Check Service Activation Date *******************************//
function ChkServiceActivationDate(){
     var IssueTypeObj = GetJID('issue_type');
    if(IssueTypeObj==undefined){ return true;}
    if(IssueTypeObj.value=="WIN"){
        var ServiceActivationDate = $(".MobileOrderMNPDetailControlservice_activation_date");
        var ConEffectiveDateObj = GetJID("con_eff_date");
        var PlanEffectiveDateObj = GetJID("plan_eff_date");
        var BillCutNumObj=GetJID("bill_cut_num");
        BillCutNumObj.value="6";
        ConEffectiveDateObj.value = ServiceActivationDate.val();
        
        AutoSetBillCutDate();
        AutoSetConEffDate();
        UpgradOrderPlanEffDateChange();
        ActionOfRatePlanEffectiveChange();
        PlanEffectiveDateObj.value = ServiceActivationDate.val();
    }
}

function ValidServiceActivationDate() {
    ChkServiceActivationDate();
    var ServiceActivationDate = $(".MobileOrderMNPDetailControlservice_activation_date");
    var ServiceActivationTime = $(".MobileOrderMNPDetailControlservice_activation_time");
    var CompanyName = $(".MobileOrderMNPDetailControlcompany_name");
    var DDateObj = GetJID("d_date");
    var ConEffectiveDateObj = GetJID("con_eff_date");
    var PlanEffectiveDateObj = GetJID("plan_eff_date");
    var IssueTypeObj = GetJID('issue_type');
    var ActionRequiredObj = GetJID('action_required');
    var ActionRequired2Obj = GetJID('action_required2');
    if(ActionRequiredObj!=undefined && ActionRequired2Obj!=undefined){
        if(ActionRequiredObj.checked!=true && ActionRequired2Obj.checked!=true){
            if (ServiceActivationDate != undefined &&
               DDateObj != undefined &&
               ConEffectiveDateObj != undefined &&
               PlanEffectiveDateObj != undefined) {
                if (ServiceActivationDate.val() != "" &&
                    DDateObj.value != '' &&
                    ConEffectiveDateObj.value != '' &&
                    PlanEffectiveDateObj.value != '') {
                    
                    var ServiceActivationDateTime = new Date();
                    ServiceActivationDateTime = ParseDate(ServiceActivationDate.val());
                    var D_DateTime = new Date();
                    D_DateTime = ParseDate(DDateObj.value);
                    var Con_Eff_DateTime = new Date();
                    Con_Eff_DateTime = ParseDate(ConEffectiveDateObj.value);
                    var Plan_Eff_DateTime = new Date();
                    Plan_Eff_DateTime = ParseDate(PlanEffectiveDateObj.value);
                    if(CompanyName.val()=="PCCW 2G"){
                        var WorkingDate = GetWorkingDateAfterIncludingSaturday(DDateObj.value, 4);
                        if (((ServiceActivationDateTime - WorkingDate) / 86400000) < 0) {
                            if(IssueTypeObj.value!="WIN"){
                                alert("Service Activation Date需要大於或等於Delivery Date+4日期(不計假期)!");
                                return false;
                            }
                        }
                        /*
                        if(((Con_Eff_DateTime - WorkingDate) / 86400000) < 0) {
                             if(IssueTypeObj.value=="WIN"){
                                    alert("PCCW 2G 升級 PCCW 3G, 服務生效日必須為送貨日 +4天");
                                    return false;
                             }
                         }
                         */
                         
                        if(((ServiceActivationDateTime - D_DateTime) / 86400000) <=3) {
                            if(IssueTypeObj.value=="WIN"){
                                   alert("PCCW 2G 升級 PCCW 3G, 服務生效日必須為送貨日 +4天");
                                   return false;
                            }
                        }
                    }
                    else if(CompanyName.val()=="PCCW 2G (PREPAID)"){
                        /*
                        var WorkingDate = GetWorkingDateAfterIncludingSaturday(DDateObj.value, 3);
                        if (((Con_Eff_DateTime - WorkingDate) / 86400000) < 0) {
                             if(IssueTypeObj.value=="WIN"){
                                alert("服務生效日必須為送貨日 +3天(不計假期)!");
                                return false;
                            }
                        }
                        */
                         if (((ServiceActivationDateTime - D_DateTime) / 86400000) <=2) {
                             if(IssueTypeObj.value=="WIN"){
                                alert("服務生效日必須為送貨日 +3天!");
                                return false;
                            }
                        }
                    }

                    if (((ServiceActivationDateTime - Con_Eff_DateTime) / 86400000) != 0) {
                        alert("Service Activation Date需要等於Contract Effective Date日期!");
                        return false;
                    }
                    
                    if (((Plan_Eff_DateTime - Con_Eff_DateTime) / 86400000) != 0) {
                        alert("Rate Plan Effective Date需要等於Contract Effective Date日期!");
                        return false;
                    }
                    
                    if(
                        IssueTypeObj.value=="WIN" || 
                        IssueTypeObj.value=="MOBILE_LITE"
                      ){
                        if(
                            ServiceActivationDate.val()=="23/01/2012" || 
                            ServiceActivationDate.val()=="24/01/2012" || 
                            ServiceActivationDate.val()=="25/01/2012" || 
                            ServiceActivationDate.val()=="26/01/2012" || 
                            (ServiceActivationDate.val()=="27/01/2012" && ServiceActivationTime.val()=="AM")
                        ){
                            alert("農曆新年以下時段將未能為客戶安排MNP攜號過台\r\n23 - 26 Jan 2012 AM/PM 及\r\n27 Jan 2012 AM\r\n");
                            return false;
                        }
                        
                        if (ServiceActivationDate.val()=="08/03/2012"){
                            alert("由於系統提升, 以下時段將未能為客戶安排MNP攜號過台!");
                            return false;
                        }
                    }
                }
            }
        } 
    }
    return true;
}

function GetWorkingDateAfterIncludingSaturday(D_Date, AddDate) {
    /* DD/MM/YYYY */
    var ResultDate = null;
    try {
        xmlhttp = GetXmlHttpObject();
        xmlhttp.onreadystatechange = function() {
            if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
                if (xmlhttp.responseText != "") {
                    ResultDate = ParseDate(xmlhttp.responseText);
                } else if (xmlhttp.responseText == "") {
                    ResultDate = null;
                }
            }
        }
        xmlhttp.open("GET", "AjaxFunc/GetWorkingDateAfterIncludingSaturday.ashx?D_Date=" + D_Date + "&AddDate=" + AddDate, false);
        xmlhttp.send();
    }
    catch (e) {
        alert(e);
    }
    return ResultDate;
}

function check_cust_id_iphone() {
    TradeHsListLoad();
    if (chkHkidForIphone() == 1 /*&& chkChangeHkid()*/) {
        alert("Customer has already used IPhone Concierge Service!");
        GetJID('form1').hkid.focus;
    } else if (chkHkidForIphone() == 2 /*|| !chkChangeHkid()*/) {
        alert("PASS");
    }
    TradeHsListNoLoad();
}




//---------------- All functions about copy value -------------------//
function copy2m_rebate_amount() {
    if (GetJID('form1').m_rebate_amount1.value.length != 0 && GetJID('form1').m_rebate_amount2.value.length != 0 && GetJID('form1').m_rebate_amount3.value.length != 0)
        GetJID('form1').m_rebate_amount.value = "$" + GetJID('form1').m_rebate_amount1.value + " x " + GetJID('form1').m_rebate_amount2.value + " + $" + GetJID('form1').m_rebate_amount3.value
}

function copy2rebate_amount() {
    if (GetJID('form1').rebate_amount1.value.length != 0 && GetJID('form1').rebate_amount2.value.length != 0 && GetJID('form1').rebate_amount3.value.length != 0)
        GetJID('form1').rebate_amount.value = "$" + GetJID('form1').rebate_amount1.value + " x " + GetJID('form1').rebate_amount2.value + " + $" + GetJID('form1').rebate_amount3.value
}

function copy2extra_rebate() {
    if (GetJID('form1').extra_rebate_amount1.value.length != 0 && GetJID('form1').extra_rebate_amount2.value.length != 0 && GetJID('form1').extra_rebate_amount3.value.length != 0)
        GetJID('form1').extra_rebate_amount.value = "$" + GetJID('form1').extra_rebate_amount1.value + " x " + GetJID('form1').extra_rebate_amount2.value + " + $" + GetJID('form1').extra_rebate_amount3.value
}

function copy2r_offer() {
    if (GetJID('form1').r_offer1.value.length != 0 && GetJID('form1').r_offer2.value.length != 0)
        GetJID('form1').r_offer.value = "$" + GetJID('form1').r_offer1.value + " + $" + GetJID('form1').r_offer2.value
} 

function update_extra_rebate() {
    if (GetJID('form1').extra_rebate_amount2.value.length != 0 && GetJID('form1').extra_rebate_amount2.value.length != 0 && GetJID('form1').extra_rebate_amount3.value.length != 0)
        GetJID('form1').extra_rebate.value = parseFloat(GetJID('form1').extra_rebate_amount1.value) * parseFloat(GetJID('form1').extra_rebate_amount2.value) + parseFloat(GetJID('form1').extra_rebate_amount3.value);
}

function update_amount() {
    if (GetJID('form1').r_offer1.value.length != 0 && GetJID('form1').r_offer2.value.length != 0)
        GetJID('form1').amount.value = parseFloat(GetJID('form1').r_offer1.value) + parseFloat(GetJID('form1').r_offer2.value);
    add_amount()
}

function copy_user() {
    GetJID('form1').contact_person.value =GetCustomerName();
    GetJID('form1').contact_no.value = GetJID('form1').mrt_no.value;
}

function copy_user2() {
    GetJID('form1').ord_place_by.value = GetCustomerName();
    GetJID('form1').ord_place_tel.value = GetJID('form1').mrt_no.value;
    GetJID('form1').ord_place_rel.selectedIndex = 1

    if (GetJID("id_type").options[GetJID("id_type").selectedIndex].value == "HKID") {
        GetJID('form1').ord_place_hkid2.disabled = false
        GetJID('form1').ord_place_id_type.selectedIndex = 1
    }
    else
        GetJID('form1').ord_place_hkid2.disabled = true
    if (GetJID("id_type").options[GetJID("id_type").selectedIndex].value == "PP") {
        GetJID('form1').ord_place_id_type.selectedIndex = 2
        GetJID('form1').ord_place_hkid2.disabled = true
    }
    GetJID('form1').ord_place_hkid.value = GetJID('form1').hkid.value;
    GetJID('form1').ord_place_hkid2.value = GetJID('form1').hkid2.value;
}

function copy_user3() {
    GetJID('form1').monthly_bank_account_holder.value = GetCustomerName();
    if (GetJID("id_type").options[GetJID("id_type").selectedIndex].value == "HKID") {
        GetJID('form1').monthly_bank_account_hkid2.disabled = false
        GetJID('form1').monthly_bank_account_id_type.selectedIndex = 1
    }
    else
        GetJID('form1').ord_place_hkid2.disabled = true

    if (GetJID("id_type").options[GetJID("id_type").selectedIndex].value == "PP") {
        GetJID('form1').monthly_bank_account_id_type.selectedIndex = 3
        GetJID('form1').monthly_bank_account_hkid2.disabled = true
    }
    GetJID('form1').monthly_bank_account_hkid.value = GetJID('form1').hkid.value;
    GetJID('form1').monthly_bank_account_hkid2.value = GetJID('form1').hkid2.value;
}


//---------------- End of All function about copy value -------------------//


//---------------- All function about check/copy value via table -------------------//
function check_remain_hs(tval,loc) {
    myWindow = window.open('HandSetManagement.aspx?location='+loc+'&sku=' + tval, 'popup', 'toolbar=no, status=no, resizable=no, width=180, height=110, scrollbars=no, menu=no')
}

function check_remain(tval) {
    myWindow = window.open('HandSetManagement.aspx?sku=' + tval, 'popup', 'toolbar=no, status=no, resizable=no, width=180, height=110, scrollbars=no, menu=no')
}

function check_gift(tval, nval, nval2) {
    myWindow = window.open('GiftDetail.aspx?sku=' + tval + '&check_imei=' + nval + '&gift=' + nval2, 'popup', 'toolbar=no, status=no, resizable=no, width=100, height=100, scrollbars=no, menu=no')
}

function check_r_gift(tval, nval, nval2, nval3) {
    myWindow = window.open('RGiftAction.aspx?sku=' + tval + '&check_imei=' + nval + '&gift=' + nval2 + '&imei=' + nval3, 'popup', 'toolbar=no, status=no, resizable=no, width=100, height=100, scrollbars=no, menu=no')
}

function check_mrt() {
    myWindow = window.open('ValidMobileNumberChecking.aspx?mrt_no=' + GetJID('form1').mrt_no.value, 'popup', 'toolbar=no, status=no, resizable=no, width=100, height=100, scrollbars=no, menu=no')
}

function check_cust_sn() {
    myWindow = window.open('CheckCustomerSN.aspx?cust_sn=' + GetJID('form1').cust_staff_no.value, 'popup', 'toolbar=no, status=no, resizable=no, width=100, height=100, scrollbars=no, menu=no')
}

function check_hkid_no() {
    myWindow = window.open('ValidCheckHKID.aspx?hkid=' + GetJID('form1').hkid.value + GetJID('form1').hkid2.value, 'popup', 'toolbar=no, status=no, resizable=no, width=100, height=100, scrollbars=no, menu=no')
}

function copy_stand(tval) {
    if (tval != "")
        myWindow = window.open('StandCopyControl.aspx?record_id=' + tval, 'popup', 'toolbar=no, status=no, resizable=no, width=100, height=100, scrollbars=no, menu=no')
}

function get_name(tval) {
    if (tval != "")
        myWindow = window.open('StaffFindDetail.aspx?staff_no=' + tval, 'popup', 'toolbar=no, status=no, resizable=no, width=100, height=100, scrollbars=no, menu=no')
}

function get_ref_id(tval) {
    if (tval != "")
        myWindow = window.open('ReferStaffReturn.aspx?staff_no=' + tval, 'popup', 'toolbar=no, status=no, resizable=no, width=100, height=100, scrollbars=no, menu=no')
}

function check_program_id() {
    myWindow = window.open('ProgramIDManagement.aspx?program_id=' + GetJID("ob_program_id").value, 'popup', 'toolbar=no, status=no, resizable=no, width=300, height=800, scrollbars=no, menu=no')
    //alert (GetJID("ob_program_id").value);
}
//---------------- End of All function about check/copy value via table -------------------//


function CheckMonthlyBankAccount() {
    var Flag = true;
    var MonthlyPaymentTypeObj = GetJID('monthly_payment_type');
    if(MonthlyPaymentTypeObj==undefined){
    alert('Error: MonthlyPaymentTypeObj undefined!'); return false; 
    }
    
    if(MonthlyPaymentTypeObj.value=="CHANGE TO BANK ACCOUNT"){

        var monthly_bank_account_bank_code = GetJID('monthly_bank_account_bank_code');
        var monthly_bank_account_branch_code = GetJID('monthly_bank_account_branch_code');
        var monthly_bank_account_no = GetJID('monthly_bank_account_no');
        var monthly_bank_account_holder = GetJID('monthly_bank_account_holder');
        var monthly_bank_account_id_type = GetJID('monthly_bank_account_id_type');
        var monthly_bank_account_hkid = GetJID('monthly_bank_account_hkid');
        var monthly_bank_account_hkid2 = GetJID('monthly_bank_account_hkid2');

        if (monthly_bank_account_bank_code == undefined) { alert('Error: monthly_bank_account_bank_code undefined!'); return false; }
        if (monthly_bank_account_branch_code == undefined) { alert('Error: monthly_bank_account_branch_code!'); return false; }
        if (monthly_bank_account_no == undefined) { alert('Error: monthly_bank_account_no undefined!'); return false; }
        if (monthly_bank_account_holder == undefined) { alert('Error: monthly_bank_account_holder undefined!'); return false; }
        if (monthly_bank_account_id_type == undefined) { alert('Error: monthly_bank_account_id_type undefined!'); return false; }
        if (monthly_bank_account_hkid == undefined) { alert('Error: monthly_bank_account_hkid undefined!'); return false; }
        if (monthly_bank_account_hkid2 == undefined) { alert('Error: monthly_bank_account_hkid2 undefined!'); return false; }

        if (monthly_bank_account_bank_code != undefined && Flag) {
            if (monthly_bank_account_bank_code.value == "") {
                alert('Please kindly enter the monthly payment bank code');
                Flag = false;
            }
        }
        if (monthly_bank_account_branch_code != undefined && Flag) {
            if (monthly_bank_account_branch_code.value == "") {
                alert('Please kindly enter the monthly payment branch code');
                Flag = false;
            }
        }
        if (monthly_bank_account_no != undefined && Flag) {
            if (monthly_bank_account_no.value == "") {
                alert('Please kindly enter the monthly payment account no');
                Flag = false;
            }
        }
        if (monthly_bank_account_holder != undefined && Flag) {
            if (monthly_bank_account_holder.value == "") {
                alert('Please kindly enter the monthly payment account holder');
                Flag = false;
            }
        }
        if (monthly_bank_account_id_type != undefined && Flag) {
            if (monthly_bank_account_id_type.value == "") {
                alert('Please kindly select the monthly payment id type');
                Flag = false;
            }
        }
        if (monthly_bank_account_hkid != undefined && Flag) {
            if (monthly_bank_account_hkid.value == "") {
                alert('Please kindly select the monthly payment hkid');
                Flag = false;
            }
        }
        if (monthly_bank_account_hkid2 != undefined && Flag) {
            if (monthly_bank_account_id_type.value == "HKID" &&
                monthly_bank_account_hkid2.value == "") {
                alert('Please kindly enter the monthly payment hkid bracket');
                Flag = false;
            }
        }
    }
    return Flag;
}



//-----------  Enable/Disable some fields of suspend -------------//
function en_action() {

    if (GetJID('form1').action_required.checked) {
        GetJID('form1').action_eff_date.disabled = false
        GetJID('form1').action_eff_date.style.background = "#FFFFbb";
        GetJID('form1').reasons.disabled = false
        GetJID('form1').reasons.size = 5;
        GetJID('form1').reasons.style.background = "#FFFFbb";
        GetJID('form1').action_required2.checked = false

        if (GetJID('no_suspend') != undefined) GetJID("no_suspend").style.display = "none"
        if (GetJID('no_suspend2') != undefined) GetJID("no_suspend2").style.display = "none"
        if (GetJID('no_suspend3') != undefined) GetJID("no_suspend3").style.display = "none"
        if (GetJID('no_suspend4') != undefined) GetJID("no_suspend4").style.display = "none"
        if (GetJID('no_opt_out') != undefined) GetJID("no_opt_out").style.display = "inline"




        GetJID('form1').program.disabled = false
        GetJID('form1').program.style.background = "#FFFFFF";
        GetJID('form1').rate_plan.disabled = false
        GetJID('form1').rate_plan.style.background = "#FFFFFF";
        GetJID('form1').normal_rebate_type.disabled = false;
        GetJID('form1').normal_rebate_type.style.background = "#FFFFFF";
        GetJID('form1').con_per.disabled = false
        GetJID('form1').con_per.style.background = "#FFFFFF";
        GetJID('form1').plan_eff_date.disabled = false
        GetJID('form1').plan_eff_date.style.background = "#FFFFFF";
        GetJID('form1').con_eff_date.disabled = false
        GetJID('form1').con_eff_date.style.background = "#FFFFFF";

    }
    else {

        GetJID('form1').action_eff_date.disabled = true
        GetJID('form1').action_eff_date.value = ""
        GetJID('form1').action_eff_date.style.background = "#DDDDDD";
        GetJID('form1').reasons.disabled = true
        GetJID('form1').reasons.value = ""
        GetJID('form1').reasons.style.background = "#DDDDDD";


        GetJID("no_suspend").style.display = "inline"
        GetJID("no_suspend2").style.display = "inline"
        GetJID("no_suspend3").style.display = "inline"
        GetJID("no_suspend4").style.display = "inline"
        GetJID("no_opt_out").style.display = "inline"
    }
}

//-----------  Enable/Disable some fields of OPT OUT -------------//
function en_action_opt() {

    if (GetJID('form1').action_required2.checked) {

        GetJID('form1').org_fee.style.background = "#FFFFFF";

        GetJID('form1').reasons.value = ""
        GetJID('form1').action_required.checked = false

        GetJID('form1').action_eff_date.disabled = true
        GetJID('form1').action_eff_date.value = ""
        GetJID('form1').action_eff_date.style.background = "#DDDDDD";
        GetJID('form1').reasons.disabled = true
        GetJID('form1').reasons.value = ""
        GetJID('form1').reasons.style.background = "#DDDDDD";

        //		GetJID("cust_type").value="";	
        GetJID("no_suspend").style.display = "none"
        GetJID("no_suspend2").style.display = "none"
        GetJID("no_suspend3").style.display = "none"
        GetJID("no_suspend4").style.display = "none"
        GetJID("no_opt_out").style.display = "none"


        GetJID('form1').program.disabled = false
        GetJID('form1').program.style.background = "#FFFFFF";
        GetJID('form1').rate_plan.disabled = false
        GetJID('form1').rate_plan.style.background = "#FFFFFF";

        GetJID('form1').normal_rebate_type.disabled = false;
        GetJID('form1').normal_rebate_type.style.background = "#FFFFFF";


        GetJID('form1').con_per.disabled = false
        GetJID('form1').con_per.style.background = "#FFFFFF";
        GetJID('form1').plan_eff_date.disabled = false
        GetJID('form1').plan_eff_date.style.background = "#FFFFFF";
        GetJID('form1').con_eff_date.disabled = false
        GetJID('form1').con_eff_date.style.background = "#FFFFFF";

    }
    else {

        GetJID('form1').reasons.disabled = true
        GetJID('form1').reasons.value = ""
        GetJID('form1').reasons.style.background = "#DDDDDD";

        GetJID('form1').org_fee.style.background = "#FFFFbb";

        GetJID("no_suspend").style.display = "inline"
        GetJID("no_suspend2").style.display = "inline"
        GetJID("no_suspend3").style.display = "inline"
        GetJID("no_suspend4").style.display = "inline"
        GetJID("no_opt_out").style.display = "inline"

    }
}



//-----------  End of Enable/Disable some fields -------------//


function CheckDateOfBirth() {
    var Issue_type = GetJID('issue_type');
    var date_of_birth = GetJID('date_of_birth');
    if (Issue_type != undefined && date_of_birth != undefined) {

        if ((Issue_type.value == 'MOBILE_LITE' || Issue_type.value == 'UPGRADE') && date_of_birth.value == '') {
            alert('Please kindly enter date of birth!');
            return false;
        }
        else {
            //alert("Issue_type.value=" + Issue_type.value);
            //alert("date_of_birth.value=" + date_of_birth.value);
        }
        
        if(date_of_birth.value !=""){
            var Today=new Date();
            if(DateCompareTo(ParseDate(date_of_birth.value),Today)==true){
                alert("Invalid date of birth!");
                return false;
            }
        }
    }
    else {
        alert("Issue_type=undefined or date_of_birth=undefined");
    }
    return true;
}

/**********************redemption notice option*********************/
var PremiumPreviousValue = "";
function PresetSPreimumPreviousValue(Val) {
    PremiumPreviousValue = Val;
}

var SPremiumPreviousValue = "";
function PresetSPreimumPreviousValue(Val) {
    SPreimumPreviousValue = Val;
}

var SPremium1PreviousValue = "";
function PresetSPreimum1PreviousValue(Val) {
    SPreimum1PreviousValue = Val;
}

var SPreimum2PreviousValue = "";
function PresetSPreimum2PreviousValue(Val) {
    SPreimum2PreviousValue = Val;
}

function RedemptionNoticeOptionAbled() {
    var PremiumObj = GetJID('premium');
    var SPremiumObj = GetJID('s_premium');
    var SPreimum1Obj = GetJID('s_premium1');
    var SPreimum2Obj = GetJID('s_premium2');
    var SPreimum3Obj = GetJID('s_premium3');
    var SPreimum4Obj = GetJID('s_premium4');
    var RedemptionNoticeOptionObj = GetJID('redemption_notice_option');

    if (PremiumObj == undefined) { return; }
    if (SPremiumObj == undefined) { return; }
    if (SPreimum1Obj == undefined) { return; }
    if (SPreimum2Obj == undefined) { return; }
    if (SPreimum3Obj == undefined) { return; }
    if (SPreimum4Obj == undefined) { return; }
    if (RedemptionNoticeOptionObj == undefined) { return; }

    var bFlag = false;
    if (PremiumObj.value != "") {
        
        if(RedemptionNoticeOptionObj.value=="" || RedemptionNoticeOptionObj.disabled!=false){RedemptionNoticeOptionObj.value = "SMS";}
        RedemptionNoticeOptionObj.disabled = false;
        bFlag = true;
    }
    if (SPremiumObj.value != "") {
        RedemptionNoticeOptionObj.disabled = false;
        if(RedemptionNoticeOptionObj.value=="" || RedemptionNoticeOptionObj.disabled!=false){RedemptionNoticeOptionObj.value = "SMS";}
        bFlag = true;
    }
    else if (SPreimum1Obj.value != "") {
        RedemptionNoticeOptionObj.disabled = false;
        if(RedemptionNoticeOptionObj.value=="" || RedemptionNoticeOptionObj.disabled!=false){RedemptionNoticeOptionObj.value = "SMS";}
        bFlag = true;
    }
    else if (SPreimum2Obj.value != "") {
        RedemptionNoticeOptionObj.disabled = false;
        if(RedemptionNoticeOptionObj.value=="" || RedemptionNoticeOptionObj.disabled!=false){RedemptionNoticeOptionObj.value = "SMS";}
        bFlag = true;
    }
    else if (SPreimum3Obj.value != "") {
        RedemptionNoticeOptionObj.disabled = false;
        if(RedemptionNoticeOptionObj.value=="" || RedemptionNoticeOptionObj.disabled!=false){RedemptionNoticeOptionObj.value = "SMS";}
        bFlag = true;
    }
    else if (SPreimum4Obj.value != "") {
        RedemptionNoticeOptionObj.disabled = false;
        if(RedemptionNoticeOptionObj.value=="" || RedemptionNoticeOptionObj.disabled!=false){RedemptionNoticeOptionObj.value = "SMS";}
        bFlag = true;
    }
    else {
    }

    if (bFlag == false) {
        RedemptionNoticeOptionObj.disabled = true;
        RedemptionNoticeOptionObj.selectedIndex = 0;
    }
    SPreimum2PreviousValue = SPreimum2Obj.value;
}

function CheckRedemptionNoticeOption() {
    var PremiumObj = GetJID('premium');
    var SPremiumObj = GetJID('s_premium');
    var SPreimum1Obj = GetJID('s_premium1');
    var SPreimum2Obj = GetJID('s_premium2');
    var SPreimum3Obj = GetJID('s_premium3');
    var SPreimum4Obj = GetJID('s_premium4');
    var RedemptionNoticeOptionObj = GetJID('redemption_notice_option');

    if (PremiumObj == undefined) { return; }
    if (SPremiumObj == undefined) { return; }
    if (SPreimum1Obj == undefined) { return; }
    if (SPreimum2Obj == undefined) { return; }
    if (SPreimum3Obj == undefined) { return; }
    if (SPreimum4Obj == undefined) { return; }
    if (RedemptionNoticeOptionObj == undefined) { return; }

    SPreimum2PreviousValue = SPreimum2Obj.value;
    if ((SPreimum1Obj.value != "" ||
        SPreimum2Obj.value != "" || 
        SPreimum3Obj.value != "" ||
        SPreimum4Obj.value != "" )
        &&
        RedemptionNoticeOptionObj.value == "") {
        alert("Please kindly select redemption notice!");
        return false;
    }
    return true;
}

/**********************redemption notice option*********************/

/*********************check delivery address***********************/
function CheckDeliveryAddress() {
    var ActionRequiredObj = GetJID('action_required');
    var ActionRequired2Obj = GetJID('action_required2');
    if(ActionRequiredObj==undefined){return true;}
    if(ActionRequired2Obj==undefined){return true;}
    if(!ActionRequiredObj.checked && !ActionRequired2Obj.checked){
        var IssueTypeObj = GetJID('issue_type');
        var D_DateObj = GetJID('d_date');
        var HsmodelObj = GetJID('hs_model');
        if (IssueTypeObj != undefined &&
        D_DateObj != undefined &&
        HsmodelObj != undefined) {
            if (IssueTypeObj.value == "MOBILE_LITE" || HsmodelObj.value != "") {
                if (GetDeliveryAddress() == false) {
                    return false;
                }
                if (D_DateObj.value == "") {
                    alert("Please kindly enter delivery date!");
                    return false;
                }
            }
        }
    }
    return true;
}

function GetDeliveryAddress() {
    var Flag = true;
    var Address = "";
    var D_AddressObj = GetJID('d_address');
    if (D_AddressObj != undefined) {
        Address=jQuery.trim(D_AddressObj.value);
        if(Address=="") Flag=false;
    }
    else {
        var D_typeObj = GetJID('d_type');
        var D_roomObj = GetJID('d_room');
        var D_floorObj = GetJID('d_floor');
        var D_blkObj = GetJID('d_blk');
        var D_buildObj = GetJID('d_build');
        var D_streetObj = GetJID('d_street');
        var D_districtObj = GetJID('d_district');
        var D_regionObj = GetJID('d_region');
        if (D_typeObj != undefined &&
          D_roomObj != undefined &&
          D_floorObj != undefined &&
          D_blkObj != undefined &&
          D_buildObj != undefined &&
          D_streetObj != undefined &&
          D_districtObj != undefined &&
          D_regionObj != undefined) {
            Address = D_typeObj.value + D_roomObj.value + D_floorObj.value + D_blkObj.value + D_buildObj.value + D_streetObj.value + D_districtObj.value + D_regionObj.value;
            Address = jQuery.trim(Address);
            if (Address == "") Flag = false;
        }
        else {
            Flag = false;
        }
    }

    if (Address == "") { alert("Please kindly enter address!"); }
    
    return Flag;
}
/***********************************************************************/
function CheckDateTimePattern(date, pattern, emsg) {

    var Flag = false;

    var pattern1=/^([1-9]|0[1-9]|[12][0-9]|3[01])[- /.]([1-9]|0[1-9]|1[012])[- /.](19|20)\d\d$/;
    switch (pattern) {
        case "DD/MM/YYYY":
            if (pattern1.test(date)) { Flag = true; }
            break;
    }
    if (Flag == false) {
        alert(emsg);
    }

    return Flag;
}

/************************Check Special Premium***********************/

function CheckSpecialPremium(){
    var s_premium1 = GetJID('s_premium1');
    var s_premium2 = GetJID('s_premium2');
    if(s_premium2.value!=""){
        if(s_premium1.value=="")
        {
            //alert("Please kindly select special premium 1!");
            //return false;
        }
    }
    return true;
}


function CheckSpecialPremiumLogic(){
    var s_premium1 = GetJID('s_premium1');
    var s_premium2 = GetJID('s_premium2');
    if(s_premium1!=undefined && s_premium2!=undefined){
        if(s_premium1.value!=""){
            s_premium2.disabled=false;
        }
        else{
            s_premium2.disabled=true;
        }
    }
}






//====================================MNP=====================//
function CheckMNPInformation(ID) {
    var IssueType = $("#issue_type");
    var ActionRequiredObj = GetJID('action_required');
    var ActionRequired2Obj = GetJID('action_required2');
    if(ActionRequiredObj!=undefined && ActionRequired2Obj!=undefined){
        if(ActionRequiredObj.checked!=true && ActionRequired2Obj.checked!=true){
            if (IssueType.val() == "") { return true; }
            if (IssueType.val() == "MOBILE_LITE") {
                var Company_name = $("." + ID + "company_name");
                var Id_type = $("." + ID + "id_type");
                var Service_activation_date = $("." + ID + "service_activation_date");
                var Hkid = $("." + ID + "hkid");
                var Hkid2 = $("." + ID + "hkid2");
                var Registered_name = $("." + ID + "registered_name");
                var Transfer_to_3g = $("." + ID + " input[id*=transfer_to_3g]");
                var Transfer_idd_deposit = $("." + ID + "transfer_idd_deposit");
                var Transfer_idd_roaming_deposit = $("." + ID + "transfer_idd_roaming_deposit");
                var Transfer_no_hk_id_holder_deposit = $("." + ID + "transfer_no_hk_id_holder_deposit");
                var Transfer_no_add_proof_deposit = $("." + ID + "transfer_no_add_proof_deposit");
                var Transfer_others_deposit = $("." + ID + "transfer_others_deposit");
                var Service_activation_time = $("." + ID + "service_activation_time");
                var Ticker_number = $("." + ID + "ticker_number");
                var Flag = true;

                if (Company_name.val() == "" && Flag) {
                    Flag = false;
                    alert("Please enter MNP company name!");
                }

                if (Id_type.val() == "" && Flag) {
                    Flag = false;
                    alert("Please select MNP ID type!");
                }

                if (Service_activation_date.val() == "" && Flag) {
                    Flag = false;
                    alert("Please enter MNP service activation date!");
                }

                if (Service_activation_time.val() == "" && Flag) {
                    Flag = false;
                    alert("Please enter MNP service activation time!");
                }
                
                if (Registered_name.val() == "" && Flag) {
                    Flag = false;
                    alert("Please enter MNP Registered Name!");
                }

                if (Transfer_to_3g.attr('checked') == true) {

                    if (Transfer_idd_deposit.val() == "" && Flag) {
                        Flag = false;
                        alert("Please enter MNP transfer idd deposit!");
                    }

                    if (Transfer_idd_roaming_deposit.val() == "" && Flag) {
                        Flag = false;
                        alert("Please enter MNP transfer idd roaming deposit!");
                    }

                    if (Transfer_no_hk_id_holder_deposit.val() == "" && Flag) {
                        Flag = false;
                        alert("Please enter MNP transfer no hk id holder deposit!");
                    }

                    if (Transfer_no_add_proof_deposit.val() == "" && Flag) {
                        Flag = false;
                        alert("Please enter MNP transfer no add proof deposit!");
                    }

                    if (Transfer_others_deposit.val() == "" && Flag) {
                        Flag = false;
                        alert("Please enter MNP transfer others deposit!");
                    }
                }

                if (Ticker_number.val() == "" && Flag) {
                    Flag = false;
                    alert("Please enter MNP ticker number!");
                }
                return Flag;
            }
        }
    }
    return true;
}


/*****************************************Win Order************************************************/
function WinOrderInit(){
     var IssueTypeObj =GetJID('issue_type');
        if(IssueTypeObj!=undefined){
            if(IssueTypeObj.value =="WIN"){
            
                GetJID("special_premium_1_show").style.display="none";
                GetJID("special_premium_2_show").style.display="none";
                GetJID("special_premium_3_show").style.display="none";
                GetJID("special_premium_4_show").style.display="none";
                GetJID("contract_effective_date_show").style.display="none";
                GetJID("plan_eff_show").style.display="none";
                GetJID("bill_cut_show").style.display="none";
                GetJID("action_of_rate_plan_effective_show").style.display="none";
                GetJID("prepayment_show").style.display="none";
                
        
                var ProgramObj=GetJID('program');
                var ExistingSmartPhoneModelShowObj=GetJID('existing_smart_phone_model_show');
                var ExistingSmartPhoneModelObj=GetJID('existing_smart_phone_model');
                var ExistingSmartPhoneIMEIShowObj=GetJID('existing_smart_phone_imei_show');
                var ExistingSmartPhoneIMEIObj=GetJID('existing_smart_phone_imei');
                if(ProgramObj!=undefined && 
                ExistingSmartPhoneModelShowObj!=undefined && 
                ExistingSmartPhoneModelObj!=undefined && 
                ExistingSmartPhoneIMEIShowObj!=undefined && 
                ExistingSmartPhoneIMEIObj!=undefined){ 
                
                    if(ProgramObj.value=="WEB & TALK (SMART SIM)" || 
                        ProgramObj.value=="WEB & TALK (SPECIAL SMART SIM)" || 
                        ProgramObj.value=="LOYAL KING+ (SMARTPHONE REB)" || 
                        ProgramObj.value=="PROJECT CREAM (SMARTPHONE REB)" || 
                        ProgramObj.value=="STAFF (SMARTPHONE REBATE)" || 
                        ProgramObj.value=="WEB & TALK (MASS SIM ONLY REB)"
                      ){
                        ExistingSmartPhoneModelShowObj.style.display="inline";
                        ExistingSmartPhoneModelObj.style.display="inline";
                        ExistingSmartPhoneIMEIShowObj.style.display="inline";
                        ExistingSmartPhoneIMEIObj.style.display="inline";
                    }
                    else{
                        ExistingSmartPhoneModelShowObj.style.display="none";
                        ExistingSmartPhoneModelObj.style.display="none";
                        ExistingSmartPhoneIMEIShowObj.style.display="none";
                        ExistingSmartPhoneIMEIObj.style.display="none";
                    }
                }
            
            
            
                var ShowRemarksToPyObj=GetJID('show_remarks_to_py_operation');
                if(ShowRemarksToPyObj!=undefined){
                    ShowRemarksToPyObj.style.display="none";
                }
                 var PlanEffDateObj = GetJID('plan_eff_date');
                 var ConEffDateObj = GetJID('con_eff_date');
                 var CustTypeObj = GetJID('cust_type');
                 if(CustTypeObj.value==""){
                    CustTypeObj.value="Healthy 3G user";
                 }
                 UpgradeTypeChange();
                 UpgradeExistingCustomerTypeChange();
                 UpgradeExistingPCCWCustomerChange();
                 

                 var WaivingShowObj= GetJID('waiving_show');
                 var ExistingCustomerTypeShowObj= GetJID('existing_customer_type_show');
                 var ObjProgramIdShowObj= GetJID('ob_program_id_show');
                 
                 var OriginalTariffFeeShowObj= GetJID('original_tariff_fee_show');
                 var ExistingContractEndMonthShowObj= GetJID('existing_contract_end_month_show');
                 var ActionRequiredShowObj= GetJID('action_required_show');
                 
                 var SuspendDateShowObj= GetJID('suspend_date_show');
                 var SuspendReasonsShowObj= GetJID('suspend_reasons_show');
                 var EasyWatchShowObj= GetJID('easywatch_show');
                 
                 var CustStaffNoShowObj= GetJID('cust_staff_no_show');
                 var OrgMrtShowObj= GetJID('org_mrt_show');
                 var PcdPaidGoWirelessShowObj= GetJID('pcd_paid_go_wireless_show');
                 
                 var LobTypeShowObj= GetJID('lob_type_show');
                 var LobAccountNoShowObj= GetJID('lob_account_no_show');
                 var GoWirelessPackageCodeShowObj= GetJID('go_wireless_package_code_show');
                 
                 var GoWirelessShowObj= GetJID('go_wireless_show');
                 var RegisterAddressShowObj= GetJID('register_address_show');
                 var CoolingOfferShowObj= GetJID('cooling_offer_show');
                 

                 if(WaivingShowObj!=undefined){ WaivingShowObj.style.display="none";}
                 if(ExistingCustomerTypeShowObj!=undefined){ ExistingCustomerTypeShowObj.style.display="none";}
                 if(ObjProgramIdShowObj!=undefined){ ObjProgramIdShowObj.style.display="none";}
                   
                if(OriginalTariffFeeShowObj!=undefined){ OriginalTariffFeeShowObj.style.display="none";}
                if(ExistingContractEndMonthShowObj!=undefined){ ExistingContractEndMonthShowObj.style.display="none";}
                if(ActionRequiredShowObj!=undefined){ ActionRequiredShowObj.style.display="none";}
                      
                if(SuspendDateShowObj!=undefined){ SuspendDateShowObj.style.display="none";}
                if(SuspendReasonsShowObj!=undefined){ SuspendReasonsShowObj.style.display="none";}
                if(EasyWatchShowObj!=undefined){ EasyWatchShowObj.style.display="none";}
                         
                if(CustStaffNoShowObj!=undefined){ CustStaffNoShowObj.style.display="none";}
                if(OrgMrtShowObj!=undefined){ OrgMrtShowObj.style.display="none";}
                if(PcdPaidGoWirelessShowObj!=undefined){ PcdPaidGoWirelessShowObj.style.display="none";}
                            
                if(LobTypeShowObj!=undefined){ LobTypeShowObj.style.display="none";}
                if(LobAccountNoShowObj!=undefined){ LobAccountNoShowObj.style.display="none";}
                if(GoWirelessPackageCodeShowObj!=undefined){ GoWirelessPackageCodeShowObj.style.display="none";}
                                
                if(GoWirelessShowObj!=undefined){ GoWirelessShowObj.style.display="none";}
                if(RegisterAddressShowObj!=undefined){ RegisterAddressShowObj.style.display="none";}
                if(CoolingOfferShowObj!=undefined){ CoolingOfferShowObj.style.display="none";}
                 
                 
                $(".upgrade_information_show").css("display","none");
                GetJID("upgrade_existing_pccw_customer_show").style.display="inline";
                GetJID("upgrade_card_ref_no_show").style.display="inline";
             }
         }
}


/*****************************************Upgrade Order********************************************/


function UpgradeOrderInit(){

        var IssueTypeObj =GetJID('issue_type');
        if(IssueTypeObj!=undefined){
            if(IssueTypeObj.value =="UPGRADE"){
            
                var ProgramObj=GetJID('program');
                var ExistingSmartPhoneModelShowObj=GetJID('existing_smart_phone_model_show');
                var ExistingSmartPhoneModelObj=GetJID('existing_smart_phone_model');
                var ExistingSmartPhoneIMEIShowObj=GetJID('existing_smart_phone_imei_show');
                var ExistingSmartPhoneIMEIObj=GetJID('existing_smart_phone_imei');
                var ActionOfRatePlanEffectiveShowObj=GetJID('action_of_rate_plan_effective_show');
                ActionOfRatePlanEffectiveShowObj.style.display="inline";
                
                if(ProgramObj!=undefined && 
                ExistingSmartPhoneModelShowObj!=undefined && 
                ExistingSmartPhoneModelObj!=undefined && 
                ExistingSmartPhoneIMEIShowObj!=undefined && 
                ExistingSmartPhoneIMEIObj!=undefined){ 
                
                    if(ProgramObj.value=="WEB & TALK (SMART SIM)" || 
                        ProgramObj.value=="WEB & TALK (SPECIAL SMART SIM)" || 
                        ProgramObj.value=="LOYAL KING+ (SMARTPHONE REB)" || 
                        ProgramObj.value=="PROJECT CREAM (SMARTPHONE REB)" || 
                        ProgramObj.value=="STAFF (SMARTPHONE REBATE)" || 
                        ProgramObj.value=="WEB & TALK (MASS SIM ONLY REB)"
                      ){
                        ExistingSmartPhoneModelShowObj.style.display="inline";
                        ExistingSmartPhoneModelObj.style.display="inline";
                        ExistingSmartPhoneIMEIShowObj.style.display="inline";
                        ExistingSmartPhoneIMEIObj.style.display="inline";
                    }
                    else{
                        ExistingSmartPhoneModelShowObj.style.display="none";
                        ExistingSmartPhoneModelObj.style.display="none";
                        ExistingSmartPhoneIMEIShowObj.style.display="none";
                        ExistingSmartPhoneIMEIObj.style.display="none";
                    }
                }
            
            
                var ShowRemarksToPyObj=GetJID('show_remarks_to_py_operation');
                if(ShowRemarksToPyObj!=undefined){
                    ShowRemarksToPyObj.style.display="none"
                }
                 var PlanEffDateObj = GetJID('plan_eff_date');
                 var ConEffDateObj = GetJID('con_eff_date');
                 var CustTypeObj = GetJID('cust_type');
                 if(CustTypeObj.value==""){
                    CustTypeObj.value="Healthy 3G user";
                 }
                 UpgradeTypeChange();
                 UpgradeExistingCustomerTypeChange();
                 UpgradeExistingPCCWCustomerChange();
                 

                 
                 var WaivingShowObj= GetJID('waiving_show');
                 var ExistingCustomerTypeShowObj= GetJID('existing_customer_type_show');
                 var ObjProgramIdShowObj= GetJID('ob_program_id_show');
                 
                 var OriginalTariffFeeShowObj= GetJID('original_tariff_fee_show');
                 var ExistingContractEndMonthShowObj= GetJID('existing_contract_end_month_show');
                 var ActionRequiredShowObj= GetJID('action_required_show');
                 
                 var SuspendDateShowObj= GetJID('suspend_date_show');
                 var SuspendReasonsShowObj= GetJID('suspend_reasons_show');
                 var EasyWatchShowObj= GetJID('easywatch_show');
                 
                 var CustStaffNoShowObj= GetJID('cust_staff_no_show');
                 var OrgMrtShowObj= GetJID('org_mrt_show');
                 var PcdPaidGoWirelessShowObj= GetJID('pcd_paid_go_wireless_show');
                 
                 var LobTypeShowObj= GetJID('lob_type_show');
                 var LobAccountNoShowObj= GetJID('lob_account_no_show');
                 var GoWirelessPackageCodeShowObj= GetJID('go_wireless_package_code_show');
                 
                 var GoWirelessShowObj= GetJID('go_wireless_show');
                 var RegisterAddressShowObj= GetJID('register_address_show');
                 var CoolingOfferShowObj= GetJID('cooling_offer_show');
                 

                 
                 if(WaivingShowObj!=undefined){ WaivingShowObj.style.display="none";}
                 if(ExistingCustomerTypeShowObj!=undefined){ ExistingCustomerTypeShowObj.style.display="none";}
                 if(ObjProgramIdShowObj!=undefined){ ObjProgramIdShowObj.style.display="none";}
                   
                if(OriginalTariffFeeShowObj!=undefined){ OriginalTariffFeeShowObj.style.display="none";}
                if(ExistingContractEndMonthShowObj!=undefined){ ExistingContractEndMonthShowObj.style.display="none";}
                if(ActionRequiredShowObj!=undefined){ ActionRequiredShowObj.style.display="none";}
                      
                if(SuspendDateShowObj!=undefined){ SuspendDateShowObj.style.display="none";}
                if(SuspendReasonsShowObj!=undefined){ SuspendReasonsShowObj.style.display="none";}
                if(EasyWatchShowObj!=undefined){ EasyWatchShowObj.style.display="none";}
                         
                if(CustStaffNoShowObj!=undefined){ CustStaffNoShowObj.style.display="none";}
                if(OrgMrtShowObj!=undefined){ OrgMrtShowObj.style.display="none";}
                if(PcdPaidGoWirelessShowObj!=undefined){ PcdPaidGoWirelessShowObj.style.display="none";}
                            
                if(LobTypeShowObj!=undefined){ LobTypeShowObj.style.display="none";}
                if(LobAccountNoShowObj!=undefined){ LobAccountNoShowObj.style.display="none";}
                if(GoWirelessPackageCodeShowObj!=undefined){ GoWirelessPackageCodeShowObj.style.display="none";}
                                
                if(GoWirelessShowObj!=undefined){ GoWirelessShowObj.style.display="none";}
                if(RegisterAddressShowObj!=undefined){ RegisterAddressShowObj.style.display="none";}
                if(CoolingOfferShowObj!=undefined){ CoolingOfferShowObj.style.display="none";}
                 
             }
             else{
                $(".upgrade_information_show").css("display","none");
             }
         }
}


function UpgradeTypeChange(){
    var UpgradeTypeValue =GetRadioButtonListVal('upgrade_type');
     var UpgradeSponsorshipsAmountObj=GetJID('upgrade_sponsorships_amount');
     if(UpgradeSponsorshipsAmountObj!=undefined){
         if(UpgradeTypeValue=="" || UpgradeTypeValue=="Mass Upgrade" || UpgradeTypeValue==null || UpgradeTypeValue==undefined){
             UpgradeSponsorshipsAmountObj.disabled=true;
         }
         else if (UpgradeTypeValue=="Staff Upgrade"){
             UpgradeSponsorshipsAmountObj.disabled=false;
         }
     }
}

function PageLoadCompleteWinOrderLogic(){
    var IssueTypeObj = GetJID("issue_type");
    if(IssueTypeObj!=undefined){
        if(IssueTypeObj.value=="WIN" ){
            WinOrderInit();
        }
    }
}

function PageLoadCompleteUpgardeOrderLogic(){
    var IssueTypeObj =GetJID('issue_type');
    if(IssueTypeObj!=undefined){
       if(IssueTypeObj.value =="UPGRADE" ){
            UpgradeOrderInit();
       }
       else{
            $(".upgrade_information_show").css("display","none");
       }
    }
}

function ChkWinOrder(){
    try{
        var IssueTypeObj =GetJID('issue_type');

        if(IssueTypeObj!=undefined){
            if(IssueTypeObj.value =="WIN"){

                var ActionOfRatePlanEffectiveShowObj=GetJID('action_of_rate_plan_effective_show');
                var ExistingSmartPhoneModelShowObj=GetJID('existing_smart_phone_model_show');
                var ExistingSmartPhoneIMEIShowObj=GetJID('existing_smart_phone_imei_show');
                
                var ActionOfRatePlanEffectiveObj=GetJID('action_of_rate_plan_effective');
                var ExistingSmartPhoneModelObj=GetJID('existing_smart_phone_model');
                var ExistingSmartPhoneIMEIObj=GetJID('existing_smart_phone_imei');
                var CardRefNoShowObj=GetJID("upgrade_card_ref_no_show");
                var CardRefNoObj=GetJID("card_ref_no");
                
                if(CTypeObj!=undefined && 
                HSRebateObj!=undefined && 
                UpgradeTypeObj!=undefined && 
                UpgradeSponsObj!=undefined && 
                UpgradeSdateObj!=undefined && 
                UpgradeEdateObj!=undefined && 
                ShowHSRebateObj!=undefined && 
                CardRefNoObj!=undefined){

                    if(ExistingSmartPhoneIMEIShowObj.style.display!="none"){
                        if(ExistingSmartPhoneIMEIObj.value==""){
                            alert("Please kindly enter existing smart phone IMEI!");
                            return false;
                        }
                    }
                    
                    if(ExistingSmartPhoneModelShowObj.style.display!="none"){
                         if(ExistingSmartPhoneModelObj.value==""){
                            alert("Please kindly select existing smart phone model!");
                            return false;
                        }
                    }
                    
                    if(ActionOfRatePlanEffectiveShowObj.style.display!="none"){
                        if(ActionOfRatePlanEffectiveObj.value==""){
                            alert("Please kindly select action of rate plan effective");
                            return false;
                        }
                    }
                    if(CardRefNoShowObj.style.display!="none"){
                        if(CardRefNoObj.value==""){
                            alert("請檢查Check Checking Serial");
                            return false;
                        }
                    }
                }
            }
        }
    }catch(e){
        alert(e);
    }
    return true;
}

function ChkUpgradeOrder(){
    try{
        var IssueTypeObj =GetJID('issue_type');

        if(IssueTypeObj!=undefined){
            if(IssueTypeObj.value =="UPGRADE"){
                var UpgradeTypeValue =GetRadioButtonListVal('upgrade_type');
                var UpgradeTypeObj = document.getElementsByName('upgrade_type');
                var CTypeObj=GetJID('upgrade_existing_customer_type');
                var HSRebateObj = GetJID('upgrade_handset_offer_rebate_schedule');
                var UpgradeSponsObj = GetJID('upgrade_sponsorships_amount');
                var UpgradeSdateObj = GetJID('upgrade_existing_contract_sdate');
                var UpgradeEdateObj = GetJID('upgrade_existing_contract_edate');
                var EContractDateShowObj = GetJID('upgrade_existing_contract_date_show');
                var ShowHSRebateObj = GetJID('upgrade_handset_offer_rebate_schedule_show');
                var UpgradeRebateCalculationObj=GetJID('upgrade_rebate_calculation');
                var ActionOfRatePlanEffectiveShowObj=GetJID('action_of_rate_plan_effective_show');
                ActionOfRatePlanEffectiveShowObj.style.display="inline";
                var ExistingSmartPhoneModelShowObj=GetJID('existing_smart_phone_model_show');
                var ExistingSmartPhoneIMEIShowObj=GetJID('existing_smart_phone_imei_show');
                
                var ActionOfRatePlanEffectiveObj=GetJID('action_of_rate_plan_effective');
                var ExistingSmartPhoneModelObj=GetJID('existing_smart_phone_model');
                var ExistingSmartPhoneIMEIObj=GetJID('existing_smart_phone_imei');
                var CardRefNoShowObj=GetJID("upgrade_card_ref_no_show");
                var CardRefNoObj=GetJID("card_ref_no");
                
                
                
                if(CTypeObj!=undefined && 
                HSRebateObj!=undefined && 
                UpgradeTypeObj!=undefined && 
                UpgradeSponsObj!=undefined && 
                UpgradeSdateObj!=undefined && 
                UpgradeEdateObj!=undefined && 
                ShowHSRebateObj!=undefined && 
                CardRefNoObj!=undefined){
                    if(CTypeObj.value==""){
                        alert("Please kindly select upgrade existing customer type");
                        return false;
                    }
                    if(CTypeObj.value!=""){
                         if(CTypeObj.value=="HS UPGRADE TO HS"){
                            if(HSRebateObj.value=="N/A"){
                                alert("Please kindly select handset offer rebate schedule");
                                return false;
                            }
                        }
                        
                        if(CTypeObj.value=="HS UPGRADE TO HS"){
                            ShowHSRebateObj.style.display="inline";
                        }
                        else{
                            ShowHSRebateObj.style.display="none";
                            UpgradeRebateCalculationObj.value="";
                            HSRebateObj.value="N/A";
                        }
                        
                        if(CTypeObj.value == "FTG CUSTOMER"){
                            ShowHSRebateObj.style.display="none";
                            HSRebateObj.value="N/A";
                        }
                    }

                    if(UpgradeTypeValue=="" || UpgradeTypeValue==null || UpgradeTypeValue==undefined){
                        alert("Please kindly select upgrade type");
                        return false;
                    }
                    if (UpgradeSponsObj.value ==""){
                        alert("Please kindly select sponsorships amounts");
                        return false;
                    }
                    
                    if(EContractDateShowObj.style.display!="none"){
                        if (UpgradeSdateObj.value == ""){
                            alert("Please kindly enter upgrade contract start date");
                            return false;
                        }
                        if (UpgradeEdateObj.value == ""){
                            alert("Please kindly enter upgrade contract end date");
                            return false;
                        }
                    }
                    
                    if(ExistingSmartPhoneIMEIShowObj.style.display!="none"){
                        if(ExistingSmartPhoneIMEIObj.value==""){
                            alert("Please kindly enter existing smart phone IMEI!");
                            return false;
                        }
                    }
                    
                    if(ExistingSmartPhoneModelShowObj.style.display!="none"){
                         if(ExistingSmartPhoneModelObj.value==""){
                            alert("Please kindly select existing smart phone model!");
                            return false;
                        }
                    }
                    
                    if(ActionOfRatePlanEffectiveShowObj.style.display!="none"){
                        if(ActionOfRatePlanEffectiveObj.value==""){
                            alert("Please kindly select action of rate plan effective");
                            return false;
                        }
                    }
                    if(CardRefNoShowObj.style.display!="none"){
                        if(CardRefNoObj.value==""){
                            alert("請檢查Check Checking Serial");
                            return false;
                        }
                    }

                    
                    if(ChkUpgradeRatePlanEffectiveDate()==false){
                        return false;
                    }
                    
                    if(ChkUpgradeExistingContractEdate()==false){
                        return false;
                    }
                }
                UpgradeExistingPCCWCustomerChangeFunc(true,true);                   
            }
        }
    }catch(e){
        alert(e);
    }
    return true;
}

function ChkUpgradeRatePlanEffectiveDate(){

}

function UpgradeExistingCustomerTypeChange()
{
    try{
         var CTypeObj=GetJID('upgrade_existing_customer_type');
         var ShowHSRebateObj = GetJID('upgrade_handset_offer_rebate_schedule_show');
          var HSRebateObj = GetJID('upgrade_handset_offer_rebate_schedule');
          var UpgradeRebateCalculationObj=GetJID('upgrade_rebate_calculation');
          var EContractDateShowObj = GetJID('upgrade_existing_contract_date_show');
          var UpgradeFtgTenureShowObj=GetJID('upgarde_ftg_tenure_show');
          var FtgTenureObj=GetJID("ftg_tenure");
          var UpgradeExistingContractSdateObj = GetJID("upgrade_existing_contract_sdate");
          var UpgradeExistingContractEdateObj = GetJID("upgrade_existing_contract_edate");
          
          
         if(CTypeObj!=undefined && ShowHSRebateObj!=undefined && HSRebateObj!=undefined){
            if(CTypeObj!=undefined){
                if(CTypeObj.value=="HS UPGRADE TO HS"){
                    ShowHSRebateObj.style.display="inline";
                    UpgradeExistingContractDateChange();
                }
                else{
                    ShowHSRebateObj.style.display="none";
                    UpgradeRebateCalculationObj.value="";
                    HSRebateObj.value="N/A";
                }
                if(CTypeObj.value == "FTG CUSTOMER"){
                    ShowHSRebateObj.style.display="none";
                    HSRebateObj.value="N/A";
                    UpgradeFtgTenureShowObj.style.display="inline";
                }
                else{
                    UpgradeFtgTenureShowObj.style.display="none";
                    FtgTenureObj.selectedIndex=0;
                }
                if(CTypeObj.value =="3G LITE CUSTOMER"){
                    alert("客戶必須為現有3G Lite 客戶");
                }

                if(CTypeObj.value =="3G LITE CUSTOMER" || CTypeObj.value == "FTG CUSTOMER"){
                    EContractDateShowObj.style.display="none";
                    UpgradeExistingContractSdateObj.value="";
                    UpgradeExistingContractEdateObj.value="";
                }
                else{
                    EContractDateShowObj.style.display="inline";
                }
            }
         }
    }
    catch(e){
         alert(e);
    }
}


function UpgradeFtgTenureChange(){
    var FtgTenureObj=GetJID("ftg_tenure");
    if (FtgTenureObj.value == "EQUAL OR GREATER THAN 9 MTHS"){
           alert("年資 >/=9個月的FTG客戶,需使用Retention月費計劃優惠");
           return false;
    }
    return true;  
}


function UpgradeExistingPCCWCustomerChange(){
    UpgradeExistingPCCWCustomerChangeFunc(false,false);
}
function UpgradeExistingPCCWCustomerChangeFunc(remove,show_alert){
    try{
        var UpgradeExistingPccwCustomerObj=GetJID('upgrade_existing_pccw_customer');
        var UpgradeServiceAccountNoShowObj=GetJID('upgrade_service_account_no_show');
        var UpgradeRegisterdMobileNoShowObj=GetJID('upgrade_registered_mobile_no_show');
        var UpgradeServiceTenureShowObj=GetJID('upgrade_service_tenure_show');
        
        var UpgradeServiceAccountNoObj=GetJID('upgrade_service_account_no');
        var UpgradeRegisterdMobileNoObj=GetJID('upgrade_registered_mobile_no');
        var UpgradeServiceTenureObj=GetJID('upgrade_service_tenure');
        
        
        if(UpgradeExistingPccwCustomerObj!=undefined && 
        UpgradeServiceAccountNoShowObj!=undefined && 
        UpgradeRegisterdMobileNoShowObj!=undefined && 
        UpgradeServiceTenureObj!=undefined){
            if(UpgradeExistingPccwCustomerObj.value=="NETVIGATOR" || UpgradeExistingPccwCustomerObj.value=="NOW"){
                UpgradeServiceAccountNoShowObj.style.display="inline";
                UpgradeServiceTenureShowObj.style.display="inline";
                if(UpgradeServiceAccountNoObj.value==""){
                    if(show_alert==true){alert("Please kindly enter the Service Account No 服務賬戶號碼");}
                    return false;
                }
                if(UpgradeServiceTenureObj.value==""){
                    if(show_alert==true){alert("Please kindly enter the Service Tenure 服務使用年期");}
                    return false;
                }
            }
            else{
                UpgradeServiceAccountNoShowObj.style.display="none";
                UpgradeServiceTenureShowObj.style.display="none";
                if(remove==true){
                    UpgradeServiceAccountNoObj.value="";
                    UpgradeServiceTenureObj.value="";
                }
            }
            if(UpgradeExistingPccwCustomerObj.value=="MOBILE" || UpgradeExistingPccwCustomerObj.value=="MOBILE ONE"){
                UpgradeRegisterdMobileNoShowObj.style.display="inline";
                if(UpgradeRegisterdMobileNoObj.value==""){
                    if(show_alert==true){alert("Please kindly enter the service Registered Mobile No 登記流動電話號碼");}
                    return false;
                }
            }
            else{
                UpgradeRegisterdMobileNoShowObj.style.display="none";
                if(remove==true){
                    UpgradeRegisterdMobileNoObj.value="";
                }
            }
        }
    }
    catch(e){
         alert(e);
    }
}

function UpgradeExistingContractDateChange()
{
    try{
        var SdateObj = GetJID('upgrade_existing_contract_sdate');
        var LogdateObj =  GetJID('log_date');
        var EdateObj = GetJID('upgrade_existing_contract_edate');
        var HSRebateObj = GetJID('upgrade_handset_offer_rebate_schedule');
        var ShowHSRebateObj = GetJID('upgrade_handset_offer_rebate_schedule_show');
        var UpgradeRebateCalculationObj=GetJID('upgrade_rebate_calculation');
        if(SdateObj!=undefined && EdateObj!=undefined && HSRebateObj!=undefined && ShowHSRebateObj!=undefined && LogdateObj!=undefined){
        
            if(EdateObj.value!="" && LogdateObj.value!="" && ShowHSRebateObj.style.display!="none"){
                
            
                var Sdate = ParseDate(SdateObj.value);
                var Edate = ParseDate(EdateObj.value);
                var Logdate = ParseDate(LogdateObj.value);
                var MonthDiff=0;
                if (DateCompareTo(Logdate, Edate) == false && UpgradeRebateCalculationObj!=undefined) {
                    MonthDiff=AddMatch(Logdate,Edate);
                    if(MonthDiff==21){
                        UpgradeRebateCalculationObj.value="ONE MONTH AFTER";
                    }
                    else if(MonthDiff==6 || MonthDiff==9 || MonthDiff==12 || MonthDiff==15 || MonthDiff==18){
                        UpgradeRebateCalculationObj.value="ON THE SAME MONTH OF";
                    }
                    else if(MonthDiff==7 || MonthDiff==10 || MonthDiff==13 || MonthDiff==16 || MonthDiff==19){
                        UpgradeRebateCalculationObj.value="ONE MONTHS BEFORE";
                    }
                    else if(MonthDiff==8 || MonthDiff==11 || MonthDiff==14 || MonthDiff==17 || MonthDiff==20){
                        UpgradeRebateCalculationObj.value="TWO MONTHS BEFORE";
                    }
                    else{
                        UpgradeRebateCalculationObj.value="";
                    }
                }
                
                
                var SdateTemp1 = ParseDate(LogdateObj.value);
                var SdateTemp2 = ParseDate(LogdateObj.value);
                var SdateTemp3 = ParseDate(LogdateObj.value);
                var SdateTemp4 = ParseDate(LogdateObj.value);
                var SdateTemp5 = ParseDate(LogdateObj.value);
                var SdateTemp6 = ParseDate(LogdateObj.value);
                var SdateTemp7 = ParseDate(LogdateObj.value);
                var SdateTemp8 = ParseDate(LogdateObj.value);
                var SdateTemp9 = ParseDate(LogdateObj.value);
                var SdateTemp10 = ParseDate(LogdateObj.value);
                var SdateTemp11= ParseDate(LogdateObj.value);
                HSRebateObj.value="N/A";
                
                SdateTemp1.addMonths(18);
                SdateTemp2.addMonths(20);
                SdateTemp3.addMonths(15);
                SdateTemp4.addMonths(18);
                SdateTemp5.addMonths(12);
                SdateTemp6.addMonths(15);
                SdateTemp7.addMonths(9);
                SdateTemp8.addMonths(12);
                SdateTemp9.addMonths(6);
                SdateTemp10.addMonths(9);
                SdateTemp11.addMonths(5);
                if( DateCompareTo(SdateTemp9, Edate) == true){
                    HSRebateObj.value="N/A";
                    return;
                }
                
                if( DateCompareTo(Edate,SdateTemp1) == true ){
                    HSRebateObj.value = "Start on the 19th bill upon new contract started";
                    return;
                }

                if( DateCompareTo(Edate,SdateTemp3) == true && DateCompareTo(SdateTemp4,Edate) == true){
                    HSRebateObj.value = "Start on the 16th bill upon new contract started";
                    return;
                }

                if( DateCompareTo(Edate,SdateTemp5) == true && DateCompareTo(SdateTemp6,Edate) == true){
                    HSRebateObj.value = "Start on the 13th bill upon new contract started";
                    return;
                }

                
                if( DateCompareTo(Edate,SdateTemp7) == true && DateCompareTo(SdateTemp8,Edate) == true){
                    HSRebateObj.value = "Start on the 10th bill upon new contract started";
                    return;
                }

                if( DateCompareTo(Edate,SdateTemp9) == true  && DateCompareTo(SdateTemp10,Edate) == true){
                    HSRebateObj.value = "Start on the 7th bill upon new contract started";
                    return;
                }
                
                if( DateCompareTo(SdateTemp11,Edate) == true){
                    HSRebateObj.value = "N/A";
                    alert("Existing contract should be remained at least 5 months!");
                    return;
                }
                
            }
        }
    }
    catch(e){
        alert(e);
    }
}


function AddMatch(Logdate,EDate) {
    for (i = 0; i < 21; i++) {
        if (DateCompareTo(Logdate, EDate) == false) {
            Logdate = Logdate.addMonths(1);
        }
        else {
            return i;
        }
    }
    return 21;
}

/******************************************[upgrade_existing_contract_edate]*******************************/

function ChkUpgradeExistingContractEdate(){
    var IssueTypeObj =GetJID('issue_type');
    if(IssueTypeObj!=undefined){
        if(IssueTypeObj.value =="UPGRADE" || IssueTypeObj.value =="WIN"){
            
            var CTypeObj=GetJID('upgrade_existing_customer_type');
            var SdateObj = GetJID('upgrade_existing_contract_sdate');
            var LogdateObj =  GetJID('log_date');
            var EdateObj = GetJID('upgrade_existing_contract_edate');
        
            var Sdate = ParseDate(SdateObj.value);
            var Edate = ParseDate(EdateObj.value);
            var Logdate = ParseDate(LogdateObj.value);
            
            if(CTypeObj.value=="SIM UPGRADE TO HS" || 
            CTypeObj.value=="SIM UPGRADE TO SIM" || 
            CTypeObj.value=="SIM UPGRADE TO HS"){
                var SdateTemp1 = ParseDate(LogdateObj.value);

                SdateTemp1.addMonths(5);
                if( DateCompareTo(SdateTemp1,Edate) == true ){
                    alert("客戶餘下之合約服務期, 必須大於5個月");
                    return false;
                }
            }
        }
   }
   return true;
}


/******************************************[monthly_payment_type]******************************************/

function ChkMonthlyPaymentType(){

        var ActionRequiredObj = GetJID('action_required');
        var ActionRequired2Obj = GetJID('action_required2');
        if(ActionRequiredObj==undefined){return true;}
        if(ActionRequired2Obj==undefined){return true;}
        if(!ActionRequiredObj.checked && !ActionRequired2Obj.checked){
            var MonthlyPaymentTypeObj = GetJID('monthly_payment_type');
            if(MonthlyPaymentTypeObj!=undefined){
                if(MonthlyPaymentTypeObj.value==""){
                    alert("Please kindly select monthly payment type");
                    return false;
                }
            }
        }
        return true;

}

function MonthlyPaymentTypeChange(){
    try{
        MonthlyPaymentTypeChangeRemove(true);
    
    }
    catch(e){
        alert(e);
    }
}

function MonthlyPaymentTypeChangeSetValueRemove(Value,Remove){
    try{
        var MonthlyPaymentTypeObj = GetJID('monthly_payment_type');
        if(MonthlyPaymentTypeObj!=undefined){
            MonthlyPaymentTypeObj.value=Value;
            MonthlyPaymentTypeChangeRemove(Remove);
        }
    }
    catch(e){
        alert(e);
    }
}

function MonthlyPaymentTypeChangeRemove(Remove){
    try{
        var MonthlyPaymentTypeObj = GetJID('monthly_payment_type');
        if(MonthlyPaymentTypeObj!=undefined){
            if(MonthlyPaymentTypeObj.value=="KEEP EXISTING COD"){
                MonthlyPaymentCreditCard(false,Remove);
                MonthlyPaymentBankAccount(false,Remove);
                Monthly3rdPartyInfo(false,Remove);
            }
            if(MonthlyPaymentTypeObj.value=="KEEP EXISTING CREDIT CARD"){
                MonthlyPaymentCreditCard(false,Remove);
                MonthlyPaymentBankAccount(false,Remove);
                Monthly3rdPartyInfo(false,Remove);
            }
            if(MonthlyPaymentTypeObj.value=="KEEP EXISTING BANK ACCOUNT"){
                MonthlyPaymentCreditCard(false,Remove);
                MonthlyPaymentBankAccount(false,Remove);
                Monthly3rdPartyInfo(false,Remove);
            }
            if(MonthlyPaymentTypeObj.value=="CHANGE TO COD"){
                MonthlyPaymentCreditCard(false,Remove);
                MonthlyPaymentBankAccount(false,Remove);
                Monthly3rdPartyInfo(false,Remove);
            }
            if(MonthlyPaymentTypeObj.value=="CHANGE TO CREDIT CARD"){
                MonthlyPaymentCreditCard(true,Remove);
                MonthlyPaymentBankAccount(false,Remove);
                Monthly3rdPartyInfo(false,Remove);
            }
            if(MonthlyPaymentTypeObj.value=="CHANGE TO BANK ACCOUNT"){
                MonthlyPaymentCreditCard(false,Remove);
                MonthlyPaymentBankAccount(true,Remove);
                Monthly3rdPartyInfo(false,Remove);
            }
            if(MonthlyPaymentTypeObj.value=="CHANGE TO 3RD PARTY CREDIT CARD"){
                MonthlyPaymentCreditCard(true,Remove);
                MonthlyPaymentBankAccount(false,Remove);
                Monthly3rdPartyInfo(true,Remove);
            }
            
        }
    }
    catch(e){
        alert(e);
    }
}

function ChkMonthlyPaymentTypeRelativeValue(){
    MonthlyPaymentTypeChangeRemove(false);

    var MonthlyPaymentTypeObj = GetJID('monthly_payment_type');
    if(MonthlyPaymentTypeObj!=undefined){
        if(MonthlyPaymentTypeObj.value=="KEEP EXISTING COD"){

        }
        if(MonthlyPaymentTypeObj.value=="KEEP EXISTING CREDIT CARD"){

        }
        if(MonthlyPaymentTypeObj.value=="KEEP EXISTING BANK ACCOUNT"){

        }
        if(MonthlyPaymentTypeObj.value=="CHANGE TO COD"){

        }
        if(MonthlyPaymentTypeObj.value=="CHANGE TO CREDIT CARD"){
            if(GetJID('m_card_no').value ==""){
                alert("Please kindly enter the monthly credit card number!");
                return false;
            }
            if(GetJID('m_card_type').value ==""){
                alert("Please kindly enter the monthly credit card type!");
                return false;
            }
            if(GetJID('m_card_holder2').value ==""){
                alert("Please kindly enter the monthly credit card holder name!");
                return false;
            }
            if(GetJID('m_card_exp_month').value ==""){
                alert("Please kindly enter the monthly credit card expiry month!");
                return false;
            }
            if(GetJID('m_card_exp_year').value ==""){
                alert("Please kindly enter the monthly credit card expiry year!");
                return false;
            }
        }
        if(MonthlyPaymentTypeObj.value=="CHANGE TO 3RD PARTY CREDIT CARD"){
            if(GetJID('m_card_no').value ==""){
                alert("Please kindly enter the monthly credit card number!");
                return false;
            }
            if(GetJID('m_card_type').value ==""){
                alert("Please kindly enter the monthly credit card type!");
                return false;
            }
            if(GetJID('m_card_holder2').value ==""){
                alert("Please kindly enter the monthly credit card holder name!");
                return false;
            }
            if(GetJID('m_card_exp_month').value ==""){
                alert("Please kindly enter the monthly credit card expiry month!");
                return false;
            }
            if(GetJID('m_card_exp_year').value ==""){
                alert("Please kindly enter the monthly credit card expiry year!");
                return false;
            }
            if(GetJID('m_3rd_contact_no').value ==""){
                alert("Please kindly enter the monthly credit card expiry year!");
                return false;
            }
            if(GetJID('m_3rd_id_type').value ==""){
                alert("Please kindly enter the monthly 3rd party id type!");
                return false;
            }
            if(GetJID('m_3rd_hkid').value ==""){
                alert("Please kindly enter the monthly 3rd party hkid!");
                return false;
            }
            if(GetJID('m_3rd_hkid2').value ==""){
                //alert("Please kindly enter the monthly 3rd party hkid2!");
                //return false;
            }
        }
        if(MonthlyPaymentTypeObj.value=="CHANGE TO BANK ACCOUNT"){
            if(GetJID('monthly_bank_account_bank_code').value ==""){
                alert("Please kindly enter the monthly bank account code!");
                return false;
            }
            if(GetJID('monthly_bank_account_branch_code').value ==""){
                alert("Please kindly enter the monthly bank branch code!");
                return false;
            }
            if(GetJID('monthly_bank_account_no').value ==""){
                alert("Please kindly enter the monthly bank account number!");
                return false;
            }
            if(GetJID('monthly_bank_account_id_type').value ==""){
                alert("Please kindly enter the monthly bank account type!");
                return false;
            }
            if(GetJID('monthly_bank_account_hkid').value ==""){
                alert("Please kindly enter the monthly bank account HK ID!");
                return false;
            }
        }
    }
    
    return true;
}

//=================[hkid]=========================//

function CheckBRNO(){
    if (!GetJID('form1').easywatch_type[1].checked && GetJID("id_type").options[GetJID("id_type").selectedIndex].value == "BRNO" && GetJID('form1').hkid.value.match(/^\d{8}-\d{3}$/) == null) {
        if (GetJID('form1').hkid.style.display != "none" && GetJID('form1').hkid.disabled == false) {
        }
        alert("BR No.is not in a valid format.!");
    } //11
}


///=================[con_eff_date]=======================///
function CheckConEffDate(){
    var ActionRequiredObj = GetJID('action_required');
    var ActionRequired2Obj = GetJID('action_required2');
    var ConEffDateObj = GetJID('con_eff_date');
    var IssueTypeObj = GetJID('issue_type');
    var NextBillObj = GetJID('next_bill');
    var HsmodelObj = GetJID('hs_model');
    if(IssueTypeObj!=undefined && ActionRequiredObj!=undefined && ActionRequired2Obj!=undefined && ConEffDateObj!=undefined){
        if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && ConEffDateObj.value == "" && !NextBillObj.checked) {

                alert("Please Enter Contract Effective Date!");
                if (ConEffDateObj.style.display != "none" && ConEffDateObj.disabled == false) {
                    //ConEffDateObj.focus();
                }
                return false;

        }
    }
    if(vaild_con_date()==false)
    {
        return false;
    }


    return true;
}


function vaild_con_date(){
    var Issue_type = GetJID('issue_type');
    if (Issue_type != undefined) {

        var temp1 = new Array()
        temp1 = GetJID('con_eff_date').value.split("/")
        var new_con_date = new Date()
        new_con_date = Date.parse(temp1[1] + "/" + temp1[0] + "/" + temp1[2])
        
         var log_date=new Date();
        if(GetJID("log_date").value!=""){
            temp1 = GetJID("log_date").value.split(" ")[0].split("/");
            log_date = Date.parse(temp1[1] + "/" + temp1[0] + "/" + temp1[2]);
        }
        
        if(log_date!=null){
            var today = new Date()
            new_today = Date.parse(today.getMonth() + 1 + "/" + today.getDate() + "/" + today.getYear())
            var D_DateObj=GetJID('d_date');
            var d_date = ParseDate(D_DateObj.value);
            if (Issue_type.value != "UPGRADE" && Issue_type.value != "WIN" ){
                if (((new_con_date - log_date) / 86400000) < 1) {
                    alert("合約生效日期需要大於LOG DATE!")
                    return false;
                }
            }
            if (Issue_type.value != "UPGRADE" && Issue_type.value != "WIN"  && Issue_type.value != "MOBILE_LITE") {
                if (((new_con_date - log_date) / 86400000) > 5 && GetJID('hs_model').value != "") {
                    alert("當選購手機時，合約生效日期一定要少於T+5!")
                    return false;
                }
            }
            if (Issue_type.value == "UPGRADE" || Issue_type.value == "WIN") {
                if (((new_con_date - d_date) / 86400000) > 30) {
                    alert("當選購手機時，合約生效日期一定要少於D+30!")
                    return false;
                }
            }
        }
    }
    return true;
}



function AutoSetConEffDate() {
    try {
        var BillCutNumObj = $('#bill_cut_num');
        var BillCutDateObj = $('#bill_cut_date');
        var ConEffectiveDateObj = $('#con_eff_date');
        var NextBillObj = $('#next_bill');
        var PlanEffDateObj = $('#bill_cut_date');
        if (BillCutNumObj != undefined && BillCutDateObj != undefined && ConEffectiveDateObj != undefined && NextBillObj != undefined && PlanEffDateObj != undefined) {

            if ($('#bill_cut_num').val() != null) {
                var ConEffDate = new Date();
                var BillCutDate = new Date();
                var PlanEffDate = new Date();
                if ($('#bill_cut_date').val() != "") {
                    var temp = new Array();
                    temp = $('#bill_cut_date').val().split("/");
                    PlanEffDate.setDate(temp[0]);
                    PlanEffDate.setMonth(temp[1] - 1);
                    PlanEffDate.setYear(temp[2]);
                    PlanEffDate.setDate(PlanEffDate.getDate() + 1);
                    if ($('#plan_eff_0:checked').val() == 'NBD') {
                        $('#plan_eff_date').val(PlanEffDate.getDate() + '/' + (PlanEffDate.getMonth() + 1) + '/' + PlanEffDate.getYear());
                    } /*else if ($('#plan_eff:checked').val() == 'OTHER') {
                        $('#plan_eff_date').val('');
                    }*/
                    if ($('#next_bill:checked').val() != null) {
                        $('#con_eff_date').val(PlanEffDate.getDate() + '/' + (PlanEffDate.getMonth() + 1) + '/' + PlanEffDate.getYear());
                    } /*else {
                        $('#con_eff_date').val('');
                    }*/
                }
            }
        }
    } catch (e) {
        ErrorLog(e, "AutoSetConEffDate Error:");
    }
}

function vaild_con_date_by_calendar() {
    if (CheckConEffDate()) {

    }
}

function ch_con_eff_date(tobj) {
    if (tobj.checked)
        GetJID('con_eff_date').value = "12/1/2009";
    else
        GetJID('con_eff_date').value = "";
}

//====================[d_date]================================///

function CheckDeliveryDateTime() {
    var IssueTypeObj = GetJID('issue_type');
    var ConEffectiveDateObj = GetJID('con_eff_date');
    var d_date = GetJID('d_date');
    var d_time = GetJID('d_time');
    var ActionRequiredObj = GetJID('action_required');
    var ActionRequired2Obj = GetJID('action_required2');
    var HsModelObj=GetJID('hs_model');
    
    if(ActionRequiredObj==undefined){return true;}
    if(ActionRequired2Obj==undefined){return true;}
    if(IssueTypeObj==undefined){return true;}
    if(!ActionRequiredObj.checked && !ActionRequired2Obj.checked){
        var ConEffDate=ParseDate(ConEffectiveDateObj.value);
        var D_Date =ParseDate(d_date.value);
        var Today = new Date();
        var New_today = Date.parse(Today.getMonth() + 1 + "/" + Today.getDate() + "/" + Today.getYear());
        var Flag = true;
        
        if (d_date == undefined) {
            alert("Error CheckDeliveryDateTime : d_date undefined!");
            Flag = false;
        }
        if (d_time == undefined) {
            alert("Error CheckDeliveryDateTime : d_time undefined!");
            Flag = false;
        }
        if (
            (
            d_date.style.display != "none" &&
            d_date.disabled == false &&
            d_date.readOnly != true
            )
            &&
           d_date.value == ""
           ) {
            alert('Please kindly enter the delivery day!');
            Flag = false;
        }

        if (
            (
            d_time.style.display != "none" &&
            d_time.disabled == false &&
            d_time.readOnly != true
            )
            &&
           d_time.value == ""
           ) {
            alert('Please kindly select the delivery day time!');
            Flag = false;
        }
        

         if (  (  (D_Date-New_today)  /86400000)  >=60){
            alert("提貨日需要少於T+60!");
            return false;
        }

        
        if(IssueTypeObj.value=="MOBILE_LITE" || IssueTypeObj.value=="UPGRADE"){
            if (((D_Date-ConEffDate)/86400000)>-1){
                alert ("提貨日需要小於合約生效日日期1天!");
                return false;
            }
        }
        else if (IssueTypeObj.value=="3G_RETENTION" || IssueTypeObj.value=="2G_RETENTION"){
        	if (((D_Date-ConEffDate)/86400000)<1){
        	    alert ("提貨日需要大於合約生效日日期再加一天!");
        	    return false;
        	}
        }
        
        
        if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && HsModelObj.value != "" && d_time.value == "") {
            alert("Please Enter Delivery Time!");
            return false;
        }
        

        if (d_date.value != "") {
            if (!CheckDateTimePattern(D_date.value, "DD/MM/YYYY", "Error: Delivery Date format is not correct!")) {
                return false;
            }
        }
        if ( ( (D_Date-Today) /86400000)  <=1 && ((D_Date  - Today) / 86400000)>0){
            var Log_dateObj=GetJID('log_date');
            if(Log_dateObj!=undefined && Log_dateObj.value!=""){
                var Log_dateStr= Log_dateObj.value.substr(0,10);
                var Log_date = ParseDate(Log_dateStr);
                if(Today.getHours()>=15 && Today.getMinutes()>0 ){
                    Today.setDate(Today.getDate() + 2);
                    if ( ((D_Date  - Today) / 86400000) < 0) {
                         alert("Cut Off Time 是15:00 因此提貨日需要大於T+2!");
                         return false;
                    }
                }
            }
        }
        return Flag;
    }
    return true;
}

///=================[plan_eff_date]=======================///

function CheckPlanEffDate(){
    var ActionRequiredObj = GetJID('action_required');
    var ActionRequired2Obj = GetJID('action_required2');
    var PlanEff1Obj = GetJID('plan_eff_1');
    var PlanEffDateObj = GetJID('plan_eff_date');
    if(ActionRequiredObj!=undefined && ActionRequired2Obj!=undefined && PlanEff1Obj!=undefined && PlanEffDateObj!=undefined){
        if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && PlanEff1Obj.checked && PlanEffDateObj.value == "") {
            alert("Please Enter Rate Plan Effective Date!");
            if (PlanEffDateObj.style.display != "none" && PlanEffDateObj.disabled == false) {
                //   document.getElementById('form1').plan_eff_date.focus();
            }
            return false;
        }
    }
    return true;
}

function vaild_plan_date() {
    var Issue_type = GetJID('issue_type');
    if (Issue_type != undefined) {
        var ConEffDateObj = GetJID('con_eff_date');
        var PlanEffDateObj = GetJID('plan_eff_date');
        if(ConEffDateObj!=undefined && PlanEffDateObj!=undefined){
            if(ConEffDateObj.value!="" && PlanEffDateObj.value!=""){
                if (Issue_type.value =="3G_RETENTION") {
                    var temp1 = new Array()
                    temp1 = PlanEffDateObj.value.split("/");
                    var new_plan_date = new Date()
                    new_plan_date = Date.parse(temp1[1] + "/" + temp1[0] + "/" + temp1[2]);
                    temp1 = ConEffDateObj.value.split("/");
                    var new_con_date = new Date()
                    new_con_date = Date.parse(temp1[1] + "/" + temp1[0] + "/" + temp1[2]);

                    if (((new_plan_date - new_con_date) / 86400000) < 0) {
                        alert("服務生效日需要大於或等於合約生效日!")
                        return false;
                    }
                }
            }
        }
    }
    return true;
}

function UpgradOrderPlanEffDateChange(){
    return true;
}


//================[waive]================================///
function ChkWaive(){
     var IssueTypeObj = GetJID('issue_type');
     if(IssueTypeObj!=undefined && IssueTypeObj.value!="UPGRADE" &&  IssueTypeObj.value!="WIN"){
         if (GetJID('fast_start').checked &&!GetJID('waive_0').checked && !GetJID('waive_1').checked) {
                alert("Please Select waiving!");
                return false;  
          }
      }
      return true;
}

//================[exist_cust_plan]==========================//
function ChkExistCustPlan(){
    var ActionRequiredObj = GetJID('action_required');
    var ActionRequired2Obj = GetJID('action_required2');
    var IssueTypeObj = GetJID('issue_type');
    if(IssueTypeObj!=undefined && IssueTypeObj.value!="UPGRADE" && IssueTypeObj.value!="WIN"){
         if ((ActionRequired2Obj.checked || ActionRequiredObj.checked) && GetJID('exist_cust_plan').options[GetJID('exist_cust_plan').selectedIndex].value == "") {
                alert("Please Select Existing Customer Type!");
                if (GetJID('exist_cust_plan').style.display != "none" && GetJID('exist_cust_plan').disabled == false) {
                    // document.getElementById('form1').exist_cust_plan.focus();
                }
               return false;
          } 
      }
      return true;
}

//================[org_fee]===================//
function ChkOrgFee(){
    var IssueTypeObj = GetJID('issue_type');
    if(IssueTypeObj!=undefined && IssueTypeObj.value!="UPGRADE" && IssueTypeObj.value!="WIN" && IssueTypeObj.value!="GO_WIRELESS"){
        if (document.getElementById('form1').org_fee.options[document.getElementById('form1').org_fee.selectedIndex].value == "" && !ActionRequired2Obj.checked) {
                alert("Please Select Original Tariff Fee!");
                if (document.getElementById('form1').org_fee.style.display != "none" && document.getElementById('form1').org_fee.disabled == false) {
                    //   document.getElementById('form1').org_fee.focus();
                }
                return false;
        }
    }
    return true;
}
//================[existing_contract_end_month]==================//
function ChkExistingContractEndMonth(){
    var IssueTypeObj = GetJID('issue_type');
    if(IssueTypeObj!=undefined && IssueTypeObj.value!="UPGRADE" && IssueTypeObj.value!="WIN" && IssueTypeObj.value!="GO_WIRELESS"){
        if ((document.getElementById('form1').existing_contract_end_month.value == "" || document.getElementById('form1').existing_contract_end_year.value == "") && document.getElementById("channel").value == "OB" && !document.getElementById("org_ftg").checked) {
            alert("Please Enter Existing Contract End Month!");
            if (document.getElementById('form1').existing_contract_end_month.style.display != "none" && document.getElementById('form1').existing_contract_end_month.disabled == false) {
                //      document.getElementById('form1').existing_contract_end_month.focus();
            }
            return false;
        }
    }
    return true;
}

//=============[action_eff_date]=================//
function ChkActionEffDate(){
    var ActionRequiredObj = GetJID('action_required');
    var IssueTypeObj = GetJID('issue_type');
    if(IssueTypeObj!=undefined && IssueTypeObj.value!="UPGRADE" && IssueTypeObj.value!="WIN"){
        if (ActionRequiredObj.checked && document.getElementById('form1').action_eff_date.value == "") {
            alert("Please Enter Suspend Date!");
            if (document.getElementById('form1').action_eff_date.style.display != "none" && document.getElementById('form1').action_eff_date.disabled == false) {
                //document.getElementById('form1').action_eff_date.focus();
            }
            return false;
        }
    }
    return true;
}

//============[reasons]=================//
function ChkReasons(){
    var ActionRequiredObj = GetJID('action_required');
    var IssueTypeObj = GetJID('issue_type');
    if(IssueTypeObj!=undefined && IssueTypeObj.value!="UPGRADE" && IssueTypeObj.value!="WIN"){
        if (ActionRequiredObj.checked && document.getElementById('form1').reasons.value == "") {
            alert("Please Select Suspend Reasons!");
            if (document.getElementById('form1').reasons.style.display != "none" && document.getElementById('form1').reasons.disabled == false) {
                // document.getElementById('form1').reasons.focus();
            }
            return false;
        } 
    }
    return true;
}

//===========[easywatch_type]===============//
function ChkEasyWatchType(){
    var ActionRequiredObj = GetJID('action_required');
    var IssueTypeObj = GetJID('issue_type');
    if(IssueTypeObj!=undefined && IssueTypeObj.value!="UPGRADE" && IssueTypeObj.value!="WIN"){
        if (!ActionRequiredObj.checked && document.getElementById('form1').program.value == "EASYWATCH BUNDLE" && !document.getElementById('form1').easywatch_type[0].checked && !document.getElementById('form1').easywatch_type[1].checked) {
                alert("Please select EASYWATCH Type !");
                return false;
        } 
    }
    return true;
}

//============[easywatch_ord_id]===================//
function ChkEasyWatchOrdId(){
    var IssueTypeObj = GetJID('issue_type');
    if(IssueTypeObj!=undefined && IssueTypeObj.value!="UPGRADE" && IssueTypeObj.value!="WIN"){
        if (document.getElementById('form1').easywatch_type[1].checked && document.getElementById('form1').easywatch_ord_id.value == "") {
            alert("Please Enter EASYWATCH Standalone order ID!");
            event.returnValue = false;
            document.getElementById('form1').submit2.disabled = false;
            bFlag = false;
        } 
    }
    return true;
}

//==========[cust_staff_no]==================//
function ChkCustStaffNo(){
    var ActionRequiredObj = GetJID('action_required');
    var IssueTypeObj = GetJID('issue_type');
    if(IssueTypeObj!=undefined && IssueTypeObj.value!="UPGRADE" && IssueTypeObj.value!="WIN"){
            if (!ActionRequiredObj.checked && document.getElementById('form1').cust_staff_no.value == "" && (document.getElementById('form1').program.value == "STAFF OFFER" || document.getElementById('form1').program.value == "STAFF REFERRAL" || document.getElementById('form1').program.value == "STAFF OFFER (IPHONE CONCIERGE SER)" || document.getElementById('form1').program.value == "STAFF OFFER (IPHONE REBATE)" || document.getElementById('form1').program.value == "STAFF OFFER(SMARTPHONE HS)" || document.getElementById('form1').program.value == "STAFF OFFER(SMARTPHONE REBATE)" || document.getElementById('form1').program.value == "STAFF OFFER(WEB & TALK+)")) {
                alert("Please Enter Customer Staff No !");
                if (document.getElementById('form1').cust_staff_no.style.display != "none" && document.getElementById('form1').cust_staff_no.disabled == false) {
                    //  document.getElementById('form1').cust_staff_no.focus();
                }
                return false;
            } 
            if (!ActionRequiredObj.checked && document.getElementById('form1').cust_staff_no.value == "" && (document.getElementById('form1').program.value == "STAFF OFFER" || document.getElementById('form1').program.value == "STAFF REFERRAL" || document.getElementById('form1').program.value == "STAFF OFFER (IPHONE CONCIERGE SER)" || document.getElementById('form1').program.value == "STAFF OFFER (IPHONE REBATE)" || document.getElementById('form1').program.value == "STAFF OFFER(SMARTPHONE HS)" || document.getElementById('form1').program.value == "STAFF OFFER(SMARTPHONE REBATE)" || document.getElementById('form1').program.value == "STAFF OFFER(WEB & TALK+)")) {
                alert("Check Customer Staff No !");
                return false;
            } 
    }
    return true;
}

//==========================[org_mrt]=============================//
function ChkOrgMrt(){
    var IssueTypeObj = GetJID('issue_type');
    if(IssueTypeObj!=undefined && IssueTypeObj.value=="GO_WIRELESS"){
        if (!ActionRequiredObj.checked && document.getElementById('form1').org_mrt.value == "" && document.getElementById('form1').submit_gw.disabled == true && !ActionRequired2Obj.checked) {
            alert("Please Enter GO Wireless MRT NO.!");
            if (document.getElementById('form1').org_mrt.style.display != "none" && document.getElementById('form1').org_mrt.disabled == false) {
                // document.getElementById('form1').org_mrt.focus();
            }
            return false;
        }
    }
    return true;
}

//=========================[pcd_paid_go_wireless]===================//
function ChkPcdPaidGoWireLess(){
    var IssueTypeObj = GetJID('issue_type');
    if(IssueTypeObj!=undefined && IssueTypeObj.value!="UPGRADE" && IssueTypeObj.value!="WIN"){
        if (document.getElementById("form1").pcd_paid_go_wireless.checked && (document.getElementById("form1").lob.value == "" || document.getElementById("form1").lob_ac.value == "" || document.getElementById("form1").go_wireless_package_code.value == "")) {
            alert("Please enter LOB Type, LOB Account No and Go Wireless Package Code!");
            return false;
        }
    }
    return true;
}

//============================[lob]==============================//
function ChkLob(){
    var ActionRequiredObj = GetJID('action_required');
    var IssueTypeObj = GetJID('issue_type');
    if(IssueTypeObj!=undefined && IssueTypeObj.value!="UPGRADE" && IssueTypeObj.value!="WIN"){
    if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && document.getElementById('form1').normal_rebate_type.selectedIndex==2 && document.getElementById('form1').lob.value == "") {
        alert("Please Select LOB Type!");
        if (document.getElementById('form1').lob.style.display != "none" && document.getElementById('form1').lob.disabled == false) {
            //document.getElementById('form1').lob.focus();
        }
        return false;
      } 
      
   }
   return true;
}

//===========================[lob_ac]=============================//
function ChkLobAc(){
    var ActionRequiredObj = GetJID('action_required');
    var IssueTypeObj = GetJID('issue_type');
    if(IssueTypeObj!=undefined && IssueTypeObj.value!="UPGRADE" && IssueTypeObj.value!="WIN"){
        if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && document.getElementById('form1').selectedIndex==2 && (document.getElementById('form1').lob_ac.value == "" || document.getElementById('form1').lob_ac.value == "0")) {
            alert("Please Enter LOB Account No !");
            if (document.getElementById('form1').lob_ac.style.display != "none" && document.getElementById('form1').lob_ac.disabled == false) {
                //  document.getElementById('form1').lob_ac.focus();
            }
            return false;
        } 
    }
    return true;
}


//============================[go_wireless]=========================//
function ChkGoWireless(){
     var ActionRequiredObj = GetJID('action_required');
    var IssueTypeObj = GetJID('issue_type');
    if(IssueTypeObj!=undefined && IssueTypeObj.value!="UPGRADE" && IssueTypeObj.value!="WIN"){
        if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && (document.getElementById('form1').go_wireless.value == "NO" && document.getElementById('form1').go_wireless.value == "") && document.getElementById('form1').program.value == "GO WIRELESS") {
                alert("Please Select Go Wireless Plan")
                return false;
        } //41.1    
     }
     return true;
}

//============================[register_address]======================//
function ChkRegisterAddress(){
    var ActionRequiredObj = GetJID('action_required');
    var ActionRequired2Obj = GetJID('action_required2');
    if(ActionRequiredObj!=undefined && ActionRequired2Obj!=undefined){
        if(ActionRequiredObj.checked!=true && ActionRequired2Obj.checked!=true){
            var ActionRequiredObj = GetJID('action_required');
            var IssueTypeObj = GetJID('issue_type');
            if(IssueTypeObj!=undefined && IssueTypeObj.value!="UPGRADE" && IssueTypeObj.value!="WIN"){
            var GoWireless = document.getElementById('go_wireless');
            var RegisterAddress = document.getElementById('register_address');
                if (GoWireless != undefined && RegisterAddress != undefined) {
                    if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && (GoWireless.value != "NO" && GoWireless.value != "") && RegisterAddress.value == "") {
                        alert("Please Select Register Address!")
                        return false;
                    } //41.2
                }
            }
        }
    }
    return true;
}


//==========================[action_of_rate_plan_effective]=============================//
function ActionOfRatePlanEffectiveChange(){
    var ConEffDateObj = GetJID('con_eff_date');
    var PlanEffDateObj = GetJID('plan_eff_date');
    var BillCutDateObj = GetJID('bill_cut_date');
    var ActionOfRatePlanEffectiveObj=GetJID('action_of_rate_plan_effective');
    if(PlanEffDateObj!=undefined && ConEffDateObj!=undefined && ActionOfRatePlanEffectiveObj!=undefined ){
        if(ActionOfRatePlanEffectiveObj.value=="START ON CONTRACT EFFECTIVE DATE"){
            PlanEffDateObj.value=ConEffDateObj.value;
        }
        if(ActionOfRatePlanEffectiveObj.value=="START ON NEXT BILL DATE"){
            AutoSetBillCutDate();AutoSetConEffDate();
        }
    }
}


//========================[r_offer]=============================//
function ChkROffer(){
    var ActionRequiredObj = GetJID('action_required');
    var ActionRequired2Obj = GetJID('action_required2');
    if(ActionRequiredObj!=undefined && ActionRequired2Obj!=undefined){
        if(ActionRequiredObj.checked!=true && ActionRequired2Obj.checked!=true){
            var ROfferObj=GetJID('r_offer');
            var IssueTypeObj = GetJID('issue_type');
            if(IssueTypeObj!=undefined && IssueTypeObj.value!="UPGRADE" && IssueTypeObj.value!="WIN"){
                if(ROfferObj!=undefined){
                    if(ROfferObj.value=="$0 + $0"){
                        alert("請確認客戶符合資格申請$0 + $0手機優惠 ");
                        return false;
                    }
                }
            }
        }
    }
    return true;
}



//========================[m_3rd_contact_no]=========================//
function Chk3rdContactNo(){
    var ActionRequiredObj = GetJID('action_required');
    var ActionRequired2Obj = GetJID('action_required2');
    if(ActionRequiredObj!=undefined && ActionRequired2Obj!=undefined){
        if(ActionRequiredObj.checked!=true && ActionRequired2Obj.checked!=true){

            var MonthlyPaymentTypeObj = GetJID('monthly_payment_type');
            if(MonthlyPaymentTypeObj!=undefined){ 
                if(MonthlyPaymentTypeObj.value=="CHANGE TO 3RD PARTY CREDIT CARD"){
                    var ThreerdContactNoObj=GetJID("m_3rd_contact_no");
                    if(ThreerdContactNoObj!=undefined){
                        if(ChkNumber(ThreerdContactNoObj,false,"Please kindly input number in  3rd party contact number field")==false){
                            return false;
                        }
                        if(ThreerdContactNoObj.value.length!=8)
                        {
                            alert("Please kindly enter 8 digits for 3rd contact number!");
                            return false;
                        }
                    }
                }
            }
        }
    }
    return true;
}



//=====================[m_3rd_hkid]======================//
function Chk3rdHkid(){
    var ThreerdIdTypeObj = GetJID("m_3rd_id_type");
    var ThreerdIdObj  = GetJID("m_3rd_hkid");
    var ThreerdId2Obj  = GetJID("m_3rd_hkid2");
    if(ThreerdIdTypeObj.value=="HKID"){
        return chk_hkid2(ThreerdIdObj.value + ThreerdId2Obj.value);
    }
    
    if (ThreerdIdObj.value.length != 0 && ThreerdIdTypeObj.value=="BRNO"){
        if (ThreerdIdObj.value.match(/^\d{8}(\-)\d{3}$/) == null && ThreerdIdObj.options[ThreerdIdTypeObj.selectedIndex].value == "BRNO")
        {    
            alert("BR No.is not in a valid format.!");
            return false;
        }
    }
    return true;
}


//=====================[amount]=========================//
function add_amount() {
    try {
        UpdateFirstMonthFee();
        var ExtraDChargeObj = GetJID("extra_d_charge");
        var AccessoryPriceObj = GetJID("accessory_price");
        var AccessoryDescDrpObj = GetJID("accessory_desc1");
        var PayMethodObj = GetJID("pay_method");
        var AmountObj = GetJID("amount");
        var TotalAmountObj = GetJID("total_amount");
        var GoWirelessObj = GetJID("go_wireless");
        var BundleNameObj = GetJID("bundle_name");
        var FirstMonthFeeObj=GetJID("first_month_fee");
        var FirstMonthLicenseFeeObj=GetJID("first_month_license_fee");
        
        var ExtraDChargeObjValue = "0";
        var AccessoryPriceObjValue = "0";
        var AmountObjValue = "0";

        if (ExtraDChargeObj != undefined) {
            if (ExtraDChargeObj.value == "" || ExtraDChargeObj.disabled == true) {
                ExtraDChargeObj.value = "0";
            }
            if (ExtraDChargeObj.value != "") { ExtraDChargeObjValue = ExtraDChargeObj.value; }
        }
        if (AccessoryPriceObj != undefined) {
            if (AccessoryPriceObj.disabled == false && AccessoryDescDrpObj.value != "" && AccessoryDescDrpObj.value == "AUTO NETWORK SELECTOR (ANS) iV E180" && PayMethodObj.value == "CASH" && (GoWirelessObj.value != "NO" || GoWirelessObj.value != "")) {
                AccessoryPriceObj.value = "840";
            }
            else if (AccessoryPriceObj.disabled == false && AccessoryDescDrpObj.value != "" && AccessoryDescDrpObj.value == "AUTO NETWORK SELECTOR (ANS) iV E180" && (GoWirelessObj.value != "NO" || GoWirelessObj.value != "")) {
                AccessoryPriceObj.value = "0";
            }
            if (BundleNameObj.value == "3GHSDPA0498(NET)HSBUNDLE" || BundleNameObj.value == "3GHSDPA0488(E180)HSBUNDLE" || BundleNameObj.value == "3GHSDPA0498HSBUNDLE") {
                AccessoryPriceObj.value = "0";
            }
            if (AccessoryPriceObj.value != "") { AccessoryPriceObjValue = AccessoryPriceObj.value; }
        }
        
        if (AmountObj != undefined) {
            if (AmountObj.value == "" || AmountObj.disabled == true) {
                AmountObj.value = "0";
            }

            if (AmountObj.value != "") { AmountObjValue = AmountObj.value; }
        }
        if (TotalAmountObj != undefined) {
            TotalAmountObj.value =parseInt(FirstMonthFeeObj.value,10)+parseInt(FirstMonthLicenseFeeObj.value,10)+ parseInt(AccessoryPriceObjValue,10) + parseInt(AmountObjValue,10) + parseInt(ExtraDChargeObjValue,10);
        }
    }
    catch (e) {
        ErrorLog(e, "add_amount()");
    }
    ChkAmountAndPaymethod();
}


function ChkAmountAndPaymethod(){
    var TotalAmountObj = GetJID("total_amount");
    var PayMethodObj = GetJID("pay_method");
    var CardNoObj = GetJID("card_no");
    var CardExpMonthObj=GetJID("card_exp_month");
    var CardExpYearObj = GetJID("card_exp_year");
    var CardHolderObj = GetJID("card_holder");
    
    if(TotalAmountObj!=undefined && PayMethodObj!=undefined){
        if(TotalAmountObj.value=="" || TotalAmountObj.value=="0"){
            PayMethodObj.disabled=true;
            PayMethodObj.value="CASH";
            CardNoObj.value="";
            CardNoObj.disabled=true;
            CardExpMonthObj.selectedIndex=0;
            CardExpMonthObj.disabled=true;
            CardExpYearObj.selectedIndex=0;
            CardExpYearObj.disabled=true;
            CardHolderObj.value="";
            CardHolderObj.disabled=true;
        }
        else{
            PayMethodObj.disabled=false;
            CardNoObj.disabled=false;
            CardExpMonthObj.disabled=false;
            CardExpYearObj.disabled=false;
            CardHolderObj.disabled=false;
        }
    }
}


//=====================[bill_medium_waive]===================//
function SameRegister(Obj) {
     var IssueTypeObj = $("#issue_type");
     var DateOfBirthObj = GetJID('date_of_birth');
     var Today=new Date();
     var DateOfBirth=ParseDate(DateOfBirthObj.value);
     DateOfBirth.setFullYear(DateOfBirth.getFullYear()+65);
     
    if(CheckDateOfBirth()==true){

        if(IssueTypeObj.val()=="MOBILE_LITE"){
            if (Obj.checked == true) {
                UserControlVisible("same_register_address_show", true);
                UserControlVisible("BillingAddressControl", true);
            }
            else {
                UserControlVisible("same_register_address_show", false);
                UserControlVisible("BillingAddressControl", false);
                AddressControlClear("BillingAddressControl");
            }
        }
        else if((IssueTypeObj.val()=="UPGRADE" || IssueTypeObj.val()=="WIN") && Obj.checked == true){
            if(DateCompareTo(DateOfBirth,Today)==true){
                alert("如客戶主動要求免費郵寄賬單, 客戶必須為其一:\r\n1) 65 歲或以上長者\r\n" +"2) 月費計劃>/=$298\r\n" +"3) SM Approval\r\n" );
                
                //Obj.checked = false;
                //return false;
            }
        }
    }
    else{
        Obj.checked = false;
    }
}


//=======================[ac_no]=============================//

function chk_ac() {
    if (document.getElementById('form1').ac_no.value.length != 0) {
        /*
        if(document.getElementById('form1').ac_no.value.match(/^\d{1}(\.)\d{9}\d{3}$/)==null || document.getElementById('form1').ac_no.value.substring(0,1)!="1"){
        alert ("戶口號碼格式不正確!");
        document.getElementById('form1').ac_no.value="";
        return false;
        }
        */
    }
    return true;
}


//=======================[exist_cust_plan]======================//
function ChkExistCustPlan(){

    return true;
}

//========================[org_ftg]===================//
function ChkOrgFtg(){
    return true;
}

//========================[c_action_required]============//
function c_action_required(){
    var ActionRequiredObj=GetJID("action_required");
    var ActionRequired2Obj=GetJID("action_required2");
    var SuspendDateShowObj = GetJID("suspend_date_show");
    var SuspendReasonsShowObj= GetJID("suspend_reasons_show");
    var WaivingShowObj=GetJID("waiving_show");
    var CustTypeShowObj=GetJID("cust_type_show");
    if(ActionRequiredObj.checked==true || ActionRequired2Obj.checked==true){
        SuspendDateShowObj.style.display="inline";
        SuspendReasonsShowObj.style.display="inline";
        WaivingShowObj.style.display="inline";
        CustTypeShowObj.style.display="inline";
    }
    else{
        SuspendDateShowObj.style.display="none";
        SuspendReasonsShowObj.style.display="none";
        WaivingShowObj.style.display="none";
        CustTypeShowObj.style.display="none";
    }
}

//===================[cn_mrt_no]=======================//
function GetCNMrtNo(){
    var CnMrtNoListObj = GetJID("cn_mrt_no_list");
    var  GetCnMrtNoObj=GetJID("get_cn_mrt_no");
    var  CnMrtNoObj = GetJID("cn_mrt_no");
    var Mrt_no = $.ajax({
             type: 'post',
             url: 'Handler/SqlHandler.ashx',
             data: "method=GETCNMRTNO&filter="+CnMrtNoListObj.value,
             dataType: 'text',
             cache: false,
             async: false
         }).responseText;
    if(Mrt_no!=""){
        
        CnMrtNoObj.value=Mrt_no;
        

        CnMrtNoObj.value=CnMrtNoListObj.value;
        GetCnMrtNoObj.disabled=true;
        
        CnMrtNoListObj.disabled=true;
        var PoolObj = GetJID("pool");
        PoolObj.disabled=true;
        CnMrtNoObj.disabled=true;
    }
    else{
        alert("Cannot Get Mobile number!");
        CnMrtNoObj.value="";
    }
}

function CNMrtNoRemove(MrtNo){
    if(MrtNo!=""){
    var CnMrtNoListObj = JSHtmlSelect("cn_mrt_no_list");
        CnMrtNoListObj.Remove(MrtNo,MrtNo);
    }
}

function CNMrtNoAdd(MrtNo){
    if(MrtNo!=""){
    var CnMrtNoListObj = JSHtmlSelect("cn_mrt_no_list");
        CnMrtNoListObj.Remove(MrtNo,MrtNo);
        CnMrtNoListObj.AddItem(MrtNo,MrtNo);
   }
}

function ReleaseCNMrtNo(){
    var  CnMrtNoObj = GetJID("cn_mrt_no");
    if(CnMrtNoObj.value!=""){
        var Mrt_no = $.ajax({
                     type: 'post',
                     url: 'Handler/SqlHandler.ashx',
                     data: "method=RELEASECNMRTNO&filter="+CnMrtNoObj.value,
                     dataType: 'text',
                     cache: false,
                     async: false
                 }).responseText;
        
        /*
       var CnMrtNoListObj = JSHtmlSelect("cn_mrt_no_list");
        CnMrtNoListObj.Remove(Mrt_no,Mrt_no);
        */
        CNMrtNoAdd(Mrt_no);
        var  GetCnMrtNoObj=GetJID("get_cn_mrt_no");
        GetCnMrtNoObj.disabled=false;
        var CnMrtNoListObj = GetJID("cn_mrt_no_list");
        CnMrtNoListObj.disabled=false;
        var PoolObj = GetJID("pool");
        PoolObj.disabled=false;
        CnMrtNoObj.disabled=false;
        alert("Release success!");
    }
}

function ChkCNMrtNoUsed(){
    var  CnMrtNoObj = GetJID("cn_mrt_no");
    var  GetCnMrtNoObj=GetJID("get_cn_mrt_no");
    var CnMrtNoListObj = GetJID("cn_mrt_no_list");
    var PoolObj = GetJID("pool");
    if(CnMrtNoObj.value!=""){
        GetCnMrtNoObj.disabled=true;
        CnMrtNoListObj.disabled=true;
        PoolObj.disabled=true;
        CnMrtNoObj.disabled=true;
    }
    else{
        GetCnMrtNoObj.disabled=false;
        CnMrtNoListObj.disabled=false;
        PoolObj.disabled=false;
        CnMrtNoObj.disabled=false;
    }
}


function ChkCnMrtNo(){
    var ActionRequiredObj = GetJID('action_required');
    var ActionRequired2Obj = GetJID('action_required2');
    if(ActionRequiredObj!=undefined && ActionRequired2Obj!=undefined){
        if(ActionRequiredObj.checked!=true && ActionRequired2Obj.checked!=true){
        
        
             var IssueTypeObj = GetJID("issue_type");
             var CnMrtNoShowObj=GetJID("cn_mrt_no_show");
            if(IssueTypeObj.value=="UPGRADE" || IssueTypeObj.value=="WIN"){
                 var CnMrtNoObj = GetJID("cn_mrt_no");
                 var Vas1Obj = GetJID("upg_1c2n_vas1");
                 var RatePlan = GetJID("rate_plan");
                 if(CnMrtNoShowObj.value==""){
                     if(Vas1Obj!=null && Vas1Obj!=undefined){
                        if(
                                Vas1Obj.value=="1-CARD-2-NUMBER BUNDLE($48) - MBP0001643" || 
                                Vas1Obj.value=="1-CARD-2-NUMBER BUNDLE($98) - MBP0001644" || 
                                Vas1Obj.value=="1-CARD-2-NUMBER BUNDLE($48)(18MTH) - MBP0001694" || 
                                Vas1Obj.value=="1-CARD-2-NUMBER BUNDLE($48)(24MTH) - MBP0001695" || 
                                Vas1Obj.value=="1-CARD-2-NUMBER BUNDLE($98)(18MTH) - MBP0001696" || 
                                Vas1Obj.value=="1-CARD-2-NUMBER BUNDLE($98)(24MTH) - MBP0001697"
                        ){
                            alert("Alert Message: 必須選擇一個 1C2N MRT");
                            return false;
                        }
                    }
                    if(RatePlan!=undefined){
                        if(RatePlan.value=="1-CARD-2-NUMBER0499"){
                             alert("Alert Message: 必須選擇一個 1C2N MRT");
                            return false;
                       }
                    }
                }
                return true;
            }
        }
    }
    return true;
}


function ChangeShowCNMrtNo(){
     var IssueTypeObj = GetJID("issue_type");
     var CnMrtNoShowObj=GetJID("cn_mrt_no_show");
     CnMrtNoShowObj.style.display="none";
    if(IssueTypeObj.value=="UPGRADE" || IssueTypeObj.value=="WIN"){
         var CnMrtNoObj = GetJID("cn_mrt_no");
         var Vas1Obj = GetJID("upg_1c2n_vas1");
         var RatePlan = GetJID("rate_plan");
         
        if(Vas1Obj!=null && Vas1Obj!=undefined){
           
            if(
                
                    Vas1Obj.value=="1-CARD-2-NUMBER BUNDLE($48) - MBP0001643" || 
                    Vas1Obj.value=="1-CARD-2-NUMBER BUNDLE($98) - MBP0001644" || 
                    Vas1Obj.value=="1-CARD-2-NUMBER BUNDLE($48)(18MTH) - MBP0001694" || 
                    Vas1Obj.value=="1-CARD-2-NUMBER BUNDLE($48)(24MTH) - MBP0001695" || 
                    Vas1Obj.value=="1-CARD-2-NUMBER BUNDLE($98)(18MTH) - MBP0001696" || 
                    Vas1Obj.value=="1-CARD-2-NUMBER BUNDLE($98)(24MTH) - MBP0001697"
                
            ){
                CnMrtNoShowObj.style.display="inline";
            }
        }
        if(RatePlan!=undefined){
            if(RatePlan.value=="1-CARD-2-NUMBER0499"){
                CnMrtNoShowObj.style.display="inline";       
           }
        }
        if(CnMrtNoShowObj.style.display=="none"){
            CnMrtNoObj.value="";
        }
    }
}


//=========================[card_ref_no]========================/
function ChkCardRefNo(){
    var ActionRequiredObj = GetJID('action_required');
    var ActionRequired2Obj = GetJID('action_required2');
    if(ActionRequiredObj!=undefined && ActionRequired2Obj!=undefined){
        if(ActionRequiredObj.checked!=true && ActionRequired2Obj.checked!=true){

            var IssueTypeObj = GetJID("issue_type");
            if(IssueTypeObj.value=="UPGRADE"){
                var  CardRefNoObj = GetJID("card_ref_no");
                if(CardRefNoObj!=undefined){
                    if(CardRefNoObj.value!="")
                    {
                        if(CardRefNoObj.value.length>0 && CardRefNoObj.value.length<6){
                            alert("Credit Checking Serial should be input 6 characters ");
                            return false;
                        }
                    }
                    else{
                        alert("Please kindly input Credit Checking Serial");
                        return false;
                    }
                }
            }
        }
    }
    return true;
}

//===================================[cust_type]===============================/
function ChkCustType(){
    var IssueTypeObj = GetJID("issue_type");
    if(IssueTypeObj.value=="3G_RETENTION"){
        var ActionRequiredObj = GetJID('action_required');
        var ActionRequired2Obj = GetJID('action_required2');
        if(ActionRequiredObj!=undefined && ActionRequired2Obj!=undefined){
            if(ActionRequiredObj.checked==true || ActionRequired2Obj.checked==true){
                var CustTypeObj = GetJID('cust_type');
                if(CustTypeObj!=undefined){
                    if(CustTypeObj.value==""){
                        alert("Please kindly select customer type!");
                        return false;
                    }
                }
            }
        }
    }
    return true;
}


//===============================[ord_place_id_type]============================//
function ChkOrdPlaceIdType(){
    var ActionRequiredObj = GetJID('action_required');
    var ActionRequired2Obj = GetJID('action_required2');
    var OrdPlaceIdTypeObj = GetJID('ord_place_id_type');
    var OrdPlaceHkid2Obj = GetJID('ord_place_hkid2');
    if(ActionRequiredObj!=undefined && ActionRequired2Obj!=undefined && 
    OrdPlaceIdTypeObj!=undefined && OrdPlaceHkid2Obj!=undefined){
    if ((!ActionRequiredObj.checked && !ActionRequired2Obj.checked) && 
    OrdPlaceIdTypeObj.options[OrdPlaceIdTypeObj.selectedIndex].value == "HKID" 
    && OrdPlaceHkid2Obj.value.length == 0) {
            alert("Please Enter brackets of HKID in Order Place Details! ");
            if (OrdPlaceHkid2Obj.style.display != "none" && OrdPlaceHkid2Obj.disabled == false) {
                // document.getElementById('form1').ord_place_hkid2.focus();
            }
            return false;
        }
    }
   return true;
}


//==========================[third_party_id_type]============================//

function chk_id2(tvar) {
    if (document.getElementById("third_party_id_type").options[document.getElementById("third_party_id_type").selectedIndex].value == "HKID") {
        document.getElementById('form1').third_party_hkid2.disabled = false;
        if (document.getElementById('form1').third_party_hkid2.value.length != 0)
            chk_hkid2(document.getElementById('form1').third_party_hkid.value + document.getElementById('form1').third_party_hkid2.value);
    }
    else {
        document.getElementById('form1').third_party_hkid2.value = '';
        document.getElementById('form1').third_party_hkid2.disabled = true;
        if (document.getElementById('form1').third_party_hkid.value.length != 0) {
            if (document.getElementById('form1').third_party_hkid.value.match(/^\d{8}(\-)\d{3}$/) == null && document.getElementById("third_party_id_type").options[document.getElementById("third_party_id_type").selectedIndex].value == "BRNO")
                alert("BR No.is not in a valid format.!");
        }
    }
}
//======================[id_type]=============================//
function chk_hkid2(sobj) {
    if (sobj.length != 0) {
        var hkidno = sobj.toUpperCase();
        sobj = hkidno;
        hkidno = hkidno.replace('(', '');
        hkidno = hkidno.replace(')', '');
        hkidno = hkidno.toUpperCase();
        var hkidnoL = hkidno.length;
        if (hkidnoL < 8) {
            alert("Invalid HKID Card Number!");
            return false;
        }
        if (hkidnoL == 8) {
            ch = '';
            ch2 = hkidno.charAt(0);
            isNine = 0;
        }
        if (hkidnoL == 9) {
            ch = hkidno.charAt(0);
            ch2 = hkidno.charAt(1);
            isNine = 1;
        }
        if (hkidnoL < 8 || hkidnoL > 9) {
            alert("Invalid HKID Card Number!");
            return false;
        }
        if ((ch == '' || (ch >= 'A' && ch <= 'Z')) && (ch2 >= 'A' && ch2 <= 'Z')) {
        }
        else {
            alert("Invalid HKID Card Number!");
            return false;
        }
        if (ch.charAt(0) == "") {
            chk = 58 * 9;
        }
        else {
            chk = (ch.charCodeAt(0) - 55) * 9;
        }
        chk += (ch2.charCodeAt(0) - 55) * 8;
        for (i = (1 + isNine); i < hkidnoL - 1; i++) {
            if (hkidno.charAt(i) >= '0' && hkidno.charAt(i) <= '9') {
                chk += hkidno.charAt(i) * (8 - i + isNine)
            }
            else {
                alert("Invalid HKID Card Number!");
                return false;
            }
        }
        chk2 = Math.floor(chk / 11) + 1;
        chk2 = chk2 * 11;
        chk3 = chk2 - chk;
        if (chk3 == 10) {
            chk3 = 'A';
        }
        if (chk3 == 11) {
            chk3 = '0';
        }
        if (chk3 != hkidno.charAt(7 + isNine)) {
            alert("Invalid HKID Card Number!");
            return false;
        }
        return true;
    }
}

function chk_id(tvar) {
    var IdTypeObj=GetJID("id_type");
    var HkidObj = GetJID("hkid");
    var Hkid2Obj = GetJID("hkid2");
    var OrdPlaceIdTypeObj = GetJID("ord_place_id_type");
    var OrdPlaceIdHkidObj = GetJID("ord_place_hkid");
    var OrdPlaceIdHkid2Obj = GetJID("ord_place_hkid2");
    var GenderObj = GetJID('gender');
    var FamilyNameObj = GetJID('family_name');
    if (IdTypeObj.options[IdTypeObj.selectedIndex].value == "HKID") {
        Hkid2Obj.disabled = false;
        if (Hkid2Obj.value.length != 0)
            chk_hkid2(HkidObj.value + Hkid2Obj.value);
    }
    else {
        Hkid2Obj.value = '';
        Hkid2Obj.disabled = true;
        if (HkidObj.value.length != 0) {
            if (HkidObj.value.match(/^\d{8}(\-)\d{3}$/) == null && IdTypeObj.options[IdTypeObj.selectedIndex].value == "BRNO")
                alert("BR No.is not in a valid format.!");
        }
    }

    if (OrdPlaceIdTypeObj.options[OrdPlaceIdTypeObj.selectedIndex].value == "HKID") {
        OrdPlaceIdHkid2Obj.disabled = false;
        if (OrdPlaceIdHkid2Obj.value.length != 0)
            chk_hkid2(OrdPlaceIdHkidObj.value + OrdPlaceIdHkid2Obj.value);
    }
    else {
        OrdPlaceIdHkid2Obj.value = '';
        OrdPlaceIdHkid2Obj.disabled = true;
    }
    
    if(tvar.id=="id_type"){
        ChkIdTypeChange();
    
    
        if(IdTypeObj.value!="BRNO"){
            var flag=true;
            if(GetJID("family_name").value!=""){
                flag=ChkWord(GetJID("family_name"),true,'Please input word only!');
                if(flag==false){ GetJID("family_name").value="";}
            }
            if(GetJID("given_name").value!=""){
                flag=ChkWord(GetJID("given_name"),true,'Please input word only!');
                if(flag==false){ GetJID("given_name").value="";}
            }
            if(GetJID("cust_name").value!=""){
                flag=ChkWord(GetJID("cust_name"),true,'Please input word only!');
                if(flag==false){ GetJID("cust_name").value="";}
            }
        }
    }
}

function ChkIdTypeChange(){
        var IdTypeObj=GetJID("id_type");
        var HkidObj = GetJID("hkid");
        var Hkid2Obj = GetJID("hkid2");
        var GenderObj = GetJID('gender');
        var FamilyNameObj = GetJID('family_name');

        if (IdTypeObj.options[IdTypeObj.selectedIndex].value == "BRNO") {
            FamilyNameObj.value="";
            GenderObj.value ="";
            GenderObj.disabled = true;
            FamilyNameObj.disabled=true;
        }
        else{
            GenderObj.disabled = false;
            FamilyNameObj.disabled=false;
        }
}


//=======================sim_item_code=================================//

function ChkSimItemCode() {
    var IssueTypeObj = GetJID("issue_type");
    if(IssueTypeObj.value=="MOBILE_LITE" || IssueTypeObj.value=="WIN" ){
        if ($("#sim_item_code").val() == "") {
            alert("請揀選合適的SIM Card Type!");
            return false;
        }
    }
    return true;
}

/*===================company_name=======================*/

function ChkCompanyNameChange(Name){
    var IssueTypeObj = GetJID("issue_type");
    var CompanyNameObj=$("."+Name+"company_name");
    if(IssueTypeObj.value=="WIN" ){
        if(CompanyNameObj.val()=="PCCW 2G (PREPAID)"){
            GetJID("first_month_fee_show").style.display="inline";
            GetJID("first_month_license_fee_show").style.display="inline";
        }
        else{
            GetJID("first_month_fee_show").style.display="none";
            GetJID("first_month_license_fee_show").style.display="none";
        }
    }
    else{
        GetJID("first_month_fee_show").style.display="none";
        GetJID("first_month_license_fee_show").style.display="none";
    }
    add_amount();
}
//================first_month_fee=====///
function UpdateFirstMonthFee(){
    var IssueTypeObj = GetJID("issue_type");
    var CompanyNameObj=$(".MobileOrderMNPDetailControlcompany_name");
    if(IssueTypeObj.value=="WIN" ){
        if(CompanyNameObj.val()=="PCCW 2G (PREPAID)"){
            var PlanFeeObj = GetJID("plan_fee");
            GetJID("first_month_fee").value=PlanFeeObj.value;
            if(GetJID("first_month_fee").value==""){
                GetJID("first_month_fee").value="0";
            }
            if(GetJID("first_month_license_fee").value=="" || 
                GetJID("first_month_license_fee").value=="0"){
                GetJID("first_month_license_fee").value="12";
            }
        }
        else{
            GetJID("first_month_fee").value="0";
            GetJID("first_month_license_fee").value="0";
        }
    }
    else{
        GetJID("first_month_fee").value="0";
        GetJID("first_month_license_fee").value="0";
    }
}
//==================family_name=================//
function ChkFamilyName(This,Msg){
    var IdTypeObj=GetJID("id_type");
    if(IdTypeObj.value!="BRNO"){
        return ChkWord(This,true,'Please input word only!')
    }
    return true;
}

//==================given_name=================//
function ChkGivenName(This,Msg){
    var IdTypeObj=GetJID("id_type");
    if(IdTypeObj.value!="BRNO"){
        return ChkWord(This,true,'Please input word only!')
    }
    return true;
}
//==================cust_name=================//
function ChkCustName(This,Msg){
    var IdTypeObj=GetJID("id_type");
    if(IdTypeObj.value!="BRNO"){
        return ChkWord(This,true,'Please input word only!')
    }
    return true;
}
//===============auto_vas_lock=============//
function SetAutoVasLock(Lock){
    var AutoVasLock=GetJID("auto_vas_lock");
    if(AutoVasLock!=null){
        return AutoVasLock.value=Lock;
    }
}

//===============accessory_waive================//
function AccessoryWaive(){
    var AccessoryPrice = GetJID("accessory_price");
    var AccessoryWaive=GetJID("accessory_waive");
    if(AccessoryWaive.checked==true){
        alert("請確認客戶符合$0預繳優惠!")
    }
    return true;
}


//============sim_item_name==============//
function SimItemNameChk(){
    var SimItemNameObj=GetJID("sim_item_name");
    var SimItemCodeObj=GetJID("sim_item_code");
    if(SimItemNameObj.value!=""){
        if(SimItemCodeObj.value==""){
            alert("Error: missing sim item code please kindly check!");
            return false;
        }
    }
    return true;
}

//============gift_desc=========//
function GiftDescChk(){
    var GiftDescObj = GetJID("gift_desc");
    var GiftCodeObj = GetJID("gift_code");
    if(GiftDescObj.value!=""){
        if(GiftCodeObj.value==""){
            alert("Error: missing gift code please kindly check!");
            return false;
        }
    }
    return true;
}

//============gift_desc=========//
function GiftDesc2Chk(){
    var GiftDescObj = GetJID("gift_desc2");
    var GiftCodeObj = GetJID("gift_code2");
    if(GiftDescObj.value!=""){
        if(GiftCodeObj.value==""){
            alert("Error: missing gift code please kindly check!");
            return false;
        }
    }
    return true;
}

//============gift_desc=========//
function GiftDesc3Chk(){
    var GiftDescObj = GetJID("gift_desc3");
    var GiftCodeObj = GetJID("gift_code3");
    if(GiftDescObj.value!=""){
        if(GiftCodeObj.value==""){
            alert("Error: missing gift code please kindly check!");
            return false;
        }
    }
    return true;
}

//============gift_desc=========//
function GiftDesc4Chk(){
    var GiftDescObj = GetJID("gift_desc4");
    var GiftCodeObj = GetJID("gift_code4");
    if(GiftDescObj.value!=""){
        if(GiftCodeObj.value==""){
            alert("Error: missing gift code please kindly check!");
            return false;
        }
    }
    return true;
}

//==============bill_cut_date===============//
function ChkBillCutDate(){
    var IssueTypeObj = GetJID("issue_type");
    if(IssueTypeObj.value!="WIN" ){
    
        var ActionRequiredObj = document.getElementById('action_required');
        var ActionRequired2Obj = document.getElementById('action_required2');
        var ProgramObj=document.getElementById('program');
        var BillCutDateObj = document.getElementById('bill_cut_date');
        var BillCutNumObj = document.getElementById('bill_cut_num');
        
        if (ActionRequiredObj != undefined && ActionRequired2Obj != undefined && BillCutDateObj != undefined && BillCutNumObj.value != undefined && ProgramObj != undefined) {
            if (!ActionRequiredObj.checked && !ActionRequired2Obj.checked && (BillCutDateObj.value == "" || BillCutNumObj.value == "") && ProgramObj.value != "GO WIRELESS") {
                if (BillCutDateObj.value == "") {
                    alert("Please enter Bill Cut Date");
                    return false;
                }
                if (BillCutNumObj.value == "") {
                    alert("Please enter Bill Cut Num");
                    return false;
                }
            }
        }
    }
    return true;
}