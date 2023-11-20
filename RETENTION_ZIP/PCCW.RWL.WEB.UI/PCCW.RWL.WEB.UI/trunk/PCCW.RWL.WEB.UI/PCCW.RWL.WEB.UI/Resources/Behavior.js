Date.prototype.addMonths = function(n) {
    this.setMonth(this.getMonth() + n);
    return this;
}

function DateCompareTo(Date1, Date2) {

    if (((Date1 - Date2) / 86400000) >= 0) {
        return true;
    }
    return false;
}

function isNum(tobj) {
    if (tobj.value != "") {
        a = Number(tobj.value);
        if (!(a) && tobj.value != "0") {
            alert("只可輸入數字!");
            tobj.value = "0";
        }
    }
}


function AspRadioButtonListEnable(ID, Enable) {

    if (document.getElementById(ID) != undefined) {
        var RadioButtonListID = document.getElementById(ID);
        var RadioButtonListName = document.getElementsByName(ID);

        for (j = 0; j < RadioButtonListName.length; j++) {
            RadioButtonListName[j].disabled = !Enable;
        }
        for (j = 0; j < RadioButtonListID.rows[0].cells.length; j++) {
            RadioButtonListID.rows[0].cells[j].childNodes[0].disabled = !Enable;
        }
    }
}


//*hyphen underscore*//
function ChkWord(This, Remove, Msg) {
    var pattern = /^[a-zA-Z.\-\_\''\s]+$/;
    if (This.value.match(pattern)) {
        return true;
    }
    else {
        
        if (Remove==true) { This.value = ""; }
        if (Msg != undefined && Msg != "") { alert(Msg); }
        return false;
    }
}

function ChkNumber(This, Remove, Msg) {
    var pattern = /^[0-9]+$/;
    if (This.value.match(pattern)) {
        return true;
    }
    else {
        if (Remove==true) { This.value = ""; }
        if (Msg != undefined && Msg != "") { alert(Msg); }
        return false;
    }
}

function ChkHKID(ID) {
    var Id_type = $("." + ID + "id_type");
    var Hkid = $("." + ID + "hkid");
    var Hkid2 = $("." + ID + "hkid2");
    if (Id_type != undefined && Hkid != undefined && Hkid2 != undefined) {
        if (Id_type.val() == "HKID") {
            Hkid2.attr("disabled", false);
            if (Hkid2.val().length != 0)
                ControlCheckHKID(Hkid.val() + Hkid2.val());
        }
        else {
            Hkid2.val('');
            Hkid2.attr("disabled", false);
            if (Hkid2.val().length != 0) {
                if (Hkid.val().match(/^\d{8}(\-)\d{3}$/) == null && Id_type.options[Id_type.selectedIndex].value == "BRNO")
                    alert("BR No.is not in a valid format.!");
            }
        }
    }
}

function ControlCheckHKID(sobj) {
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


function SaveClientID(IDName) {
    var Hidden = $("." + IDName + "Hidden");
    var HiddenName = $("." + IDName + "HiddenName");
    var UserControl = $("." + IDName);
    var IDHiddenName = Hidden.attr('name');
    if (HiddenName != Hidden.attr('id')) {
        var Name = IDHiddenName.replace(new RegExp("__" + IDName + "Hidden__", 'g'), '');
        if (Name != '') {
            HiddenName.val(Name);
        }
    }
    HiddenName.attr('name', IDName + "HiddenName");

}


function GetCustomerName() {
    var FamilyName = "";
    var GivenName = "";
    var FamilyNameObj = document.getElementById('family_name');
    var GivenNameObj = document.getElementById('given_name');

    if (FamilyNameObj != null && FamilyNameObj != undefined) {
        FamilyName = FamilyNameObj.value;
    }
    if (GivenNameObj != null && GivenNameObj != undefined) {
        GivenName = GivenNameObj.value;
    }
    if (FamilyName != " " && FamilyName != null && FamilyName != undefined) {
        return FamilyName + " " + GivenName;
    }
    else {
        return jQuery.trim(GivenName);
    }
}

function ChkCustomerName() {
    var FamilyName = "";
    var GivenName = "";
    var FamilyNameObj = document.getElementById('family_name');
    var GivenNameObj = document.getElementById('given_name');
    var IdType = document.getElementById('id_type');
    if (FamilyNameObj != null && FamilyNameObj != undefined) {
        FamilyName = jQuery.trim(FamilyNameObj.value);
    }
    if (GivenNameObj != null && GivenNameObj != undefined) {
        GivenName = jQuery.trim(GivenNameObj.value);
    }
    if (IdType.value != "BRNO") {
        if (FamilyName == "") {
            alert("Please kindly enter the family name!");
            return false;
        }
        if (GivenName == "") {
            alert("Please kindly enter the given name!");
            return false;
        }
    }
    return true;
}

function chg_upper(Obj) {
    if (Obj == undefined) { return; }
    Obj.value = Obj.value.toUpperCase();

}

function AddressDRegionSet(ID, value) {
    var DRegion = $("." + ID + "DRegionClass");
    if (DRegion != undefined) {
        DRegion.val(value);
    }
}

function AddressDRegionHiddenAutoSave(ID) {
    var DRegionHidden = $("." + ID + "DRegionHidden");
    var DRegionValue = GetAddressControlDropListValByClassName(ID + "DRegionClass");
    if (DRegionHidden != undefined) {
        
        DRegionHidden.val(DRegionValue);
    }
    else{
        //alert('ERROR: DRegionHidden is undefined !');
    }
}

function AddressDRegionCheckAutoPostBack(ID, LoadingID) {
    var DRegionHidden = $("." + ID + "DRegionHidden");
    var DRegionValue = GetAddressControlDropListValByClassName(ID + "DRegionClass");
    if (DRegionHidden != undefined) {
        if (DRegionHidden.val() == null || DRegionValue == null) {
            //alert('ERROR: AddressDRegionCheckAutoPostBack : event.returnValue = false');
            event.returnValue = false;
            AddressDistrictNoLoad(LoadingID, $("." + ID + "DRegionClass").attr('id'));
        }
        var flag = (DRegionHidden.val() == DRegionValue);
        if (flag == true) {
            //alert('ERROR: AddressDRegionCheckAutoPostBack : DRegionHidden.val() == DRegionValue [DRegionHidden.val()=' + DRegionHidden.val() + ' || DRegionValue=' + DRegionValue + ']');
            event.returnValue = false;
            AddressDistrictNoLoad(LoadingID, $("." + ID + "DRegionClass").attr('id'));
        }
    }
}


function GetRadioButtonListVal(RadioButtonListID) {
    var a = null;
    var f = document.forms[0];
    var e = f.elements[RadioButtonListID];

    for (var i = 0; i < e.length; i++) {
        if (e[i].checked) {
            a = e[i].value;
            break;
        }
    }
    return a;
}

function GetAddressControlDropListValByClassName(ClassName) {
    var RegionVal = "";
    $('.' + ClassName + ' :input').each(function() {
        var type = this.type;
        var tag = this.tagName.toLowerCase();
        if (type == 'text' || type == 'password' || tag == 'textarea') {
            // this.value = "";
        } else if (type == 'checkbox' || type == 'radio') {
            if (this.checked == true) {
                RegionVal = this.value;
            }
        } else if (tag == 'select') {
         //   this.selectedIndex = -1;
        }
    });

    return RegionVal;
}

function AddressControlInputChk(ID) {
    var IssueType = $("#issue_type");
    if (IssueType.val() == "") { return true; }
    var DTypeClass = $("." + ID + "DTypeClass");
    var DRegionClass = $("." + ID + "DRegionClass");
    var DDistrictClass = $("." + ID + "DDistrictClass");
    var DRoomClass = $("." + ID + "DRoomClass");
    var DFloorClass = $("." + ID + "DFloorClass");
    var DBlkClass = $("." + ID + "DBlkClass");
    var DBuildClass = $("." + ID + "DBuildClass");
    var DStreetClass = $("." + ID + "DStreetClass");
    var AddressUpdatePanelUpdate = $("." + ID + "AddressUpdatePanelUpdate");
    var DDistrictDefault = $("." + ID + "DDistrictDefault");
    var Flag = false;
    
    var RegionVal = GetAddressControlDropListValByClassName(ID + "DRegionClass");

    if (DTypeClass.val() != "" || RegionVal != "" || DDistrictClass.val() != "" || DRoomClass.val()!="" ||
   DFloorClass.val() != "" || DBlkClass.val() != "" || DBuildClass.val() != "" || DStreetClass.val()!="") {
        Flag = true;
    }

    if (Flag == false) {
        alert("Please kindly input the address!");
    }
    
    return Flag;
}

function AddressControlClear(ID) {
    var DTypeClass = $("." + ID + "DTypeClass");
    var DRegionClass = $("." + ID + "DRegionClass");
    var DDistrictClass = $("." + ID + "DDistrictClass");
    var DRoomClass = $("." + ID + "DRoomClass");
    var DFloorClass = $("." + ID + "DFloorClass");
    var DBlkClass = $("." + ID + "DBlkClass");
    var DBuildClass = $("." + ID + "DBuildClass");
    var DStreetClass = $("." + ID + "DStreetClass");
    var AddressUpdatePanelUpdate = $("." + ID + "AddressUpdatePanelUpdate");
    var DDistrictDefault = $("." + ID + "DDistrictDefault");

    DTypeClass.val('');
    $('.' + ID + 'DRegionClass :input').each(function() {
        var type = this.type;
        var tag = this.tagName.toLowerCase();
        if (type == 'text' || type == 'password' || tag == 'textarea')
            this.value = "";
        else if (type == 'checkbox' || type == 'radio') {
            this.checked = false;
        } else if (tag == 'select')
            this.selectedIndex = -1;
    });

    DDistrictClass.selectedIndex = -1;
    DDistrictClass.val('');
    DRoomClass.val('');
    DFloorClass.val('');
    DBlkClass.val('');
    DBuildClass.val('');
    DStreetClass.val('');
    DDistrictDefault.val('');
}

function CopyRegisterAddress(ID1, ID2) {
    /* 
    var ID1 = "RegisterAddress";
    var ID2 = "BillingAddress";
    */
    var DTypeClass1 = $("." + ID1 + "DTypeClass");
    var DRegionClass1 = $("." + ID1 + "DRegionClass");
    var DDistrictClass1 = $("." + ID1 + "DDistrictClass");
    var DRoomClass1 = $("." + ID1 + "DRoomClass");
    var DFloorClass1 = $("." + ID1 + "DFloorClass");
    var DBlkClass1 = $("." + ID1 + "DBlkClass");
    var DBuildClass1 = $("." + ID1 + "DBuildClass");
    var DStreetClass1 = $("." + ID1 + "DStreetClass");
    var AddressUpdatePanelUpdate1 = $("." + ID1 + "AddressUpdatePanelUpdate");
    var DDistrictDefault1 = $("." + ID1 + "DDistrictDefault");
    
    var DTypeClass2 = $("." + ID2 + "DTypeClass");
    var DRegionClass2 = $("." + ID2 + "DRegionClass");
    var DDistrictClass2 = $("." + ID2 + "DDistrictClass");
    var DRoomClass2 = $("." + ID2 + "DRoomClass");
    var DFloorClass2 = $("." + ID2 + "DFloorClass");
    var DBlkClass2 = $("." + ID2 + "DBlkClass");
    var DBuildClass2 = $("." + ID2 + "DBuildClass");
    var DStreetClass2 = $("." + ID2 + "DStreetClass");
    var AddressUpdatePanelUpdate2 = $("." + ID2 + "AddressUpdatePanelUpdate");
    var DDistrictDefault2 = $("." + ID2 + "DDistrictDefault");
    
    /*
    var option = jQuery("new option");
    option.attr("text", DDistrictClass1.val());
    option.attr("value", DDistrictClass1.val());
    option.attr("selected", "true");
    DDistrictDefault2.append(option);
    */
    /*
    if (DDistrictClass1.val() != undefined) {
        alert(DDistrictDefault2.attr('name'));
        var DDistrict2 = document.getElementsByName(DDistrictDefault2.attr('name'));
        if (DDistrict2 != undefined) {
            if (DDistrict2.options != undefined) {
                DDistrict2.options.length = 0;
                DDistrict2.options[0] = new Option(DDistrictClass1.val(), DDistrictClass1.val());
            }
        }
    }
    */
    var find = false;
    var DRegionClass1Select = 0;
    var DRegionClass1Selected = 0;
    $('.' + ID1 + 'DRegionClass :input').each(function() {
        var type = this.type;
        var tag = this.tagName.toLowerCase();
        if (type == 'text' || type == 'password' || tag == 'textarea')
            this.value = "";
        else if (type == 'checkbox' || type == 'radio') {
            if (find == false) {
                DRegionClass1Select += 1;
                if (this.checked) {
                    find = true;
                    DRegionClass1Selected = DRegionClass1Select;
                }
            }
        } else if (tag == 'select')
            this.selectedIndex = -1;
    });
    var DRegionClass2Select = 0;
    var DRegionClass2Selected = 0;
    $('.' + ID2 + 'DRegionClass :input').each(function() {
        var type = this.type;
        var tag = this.tagName.toLowerCase();
        if (type == 'text' || type == 'password' || tag == 'textarea')
            this.value = "";
        else if (type == 'checkbox' || type == 'radio') {
            DRegionClass2Select += 1;
            this.checked = false;
            if (DRegionClass1Select == DRegionClass2Select) {
                this.checked = true;
                var DRegionClass2Selected = DRegionClass2Select;
            }
        } else if (tag == 'select')
            this.selectedIndex = -1;
    });


    DTypeClass2.val(DTypeClass1.val());
    DRoomClass2.val(DRoomClass1.val());
    DFloorClass2.val(DFloorClass1.val());
    DBlkClass2.val(DBlkClass1.val());
    DBuildClass2.val(DBuildClass1.val());
    DStreetClass2.val(DStreetClass1.val());
    

    if (DRegionClass1Selected > 0) {

        DDistrictDefault2.val(DDistrictClass1.val());
        __doPostBack(AddressUpdatePanelUpdate2.attr('name'), '');
        //setTimeout('__doPostBack(\'BillingAddressControl$d_district\',\'\')', 0)
    }
}

function AddressLoadDDistrictTime(Id) {
    if (document.getElementById(Id) != undefined) document.getElementById(Id).style.display = "inline";
}

function AddressNoLoadDDistrictTime(Id) {
    if (document.getElementById(Id) != undefined) document.getElementById(Id).style.display = "none";
}


/*****  Change pull down region select d_distract *****/
function AddressDistrictNoLoad(Id, RegionId) {
    var Name = "";
    if (document.getElementById(RegionId) != undefined) { document.getElementById(RegionId).name; }
    if (document.getElementById(Id) != undefined) { document.getElementById(Id).style.display = "none"; }
    var d_region = document.getElementsByName(Name);
    if (d_region != undefined) {
        for (i = 0; i < d_region.length; i++) {
            d_region[i].disabled = false;
        }
    }
}

function AddressDistrictLoad(Id, RegionId) {
    var Name = "";
    if (document.getElementById(RegionId) != undefined) { Name = document.getElementById(RegionId).name; }
    if (document.getElementById(Id) != undefined) { document.getElementById(Id).style.display = "inline"; }
    var d_region = document.getElementsByName(Name);
    if (d_region != undefined) {
        for (i = 0; i < d_region.length; i++) {
            d_region[i].disabled = true;
        }
    }
}


function TransferTo3GShow(Chk) {
    if (Chk == true) {
        $(".transfer_to_3g_show").show();
    }
    else {
        $(".transfer_to_3g_show").hide();
        $('.transfer_to_3g_show :input').each(function() {
            var type = this.type;
            var tag = this.tagName.toLowerCase();
            if (type == 'text') {
                this.value = '';
            }
        });
    }
}



function ServiceActivationDateClearChk(ID) {
    var ServiceActivationDate = $("." + ID + "service_activation_date");
    var ServiceActivationTime = $("." + ID + "service_activation_time");
    if (ServiceActivationDate != undefined && ServiceActivationTime != undefined) {
        ServiceActivationDate.val('');
        ServiceActivationTime.val('');
    }
}

function ReceiveSIMBy3rdPartyDetailShowChk(Chk) {
    var ReceiveSIMBy3rdPartyDetailShow = $(".ReceiveSIMBy3rdPartyDetailShow");
    var ContactPersonShow = $(".contact_person_show");
    var ContactNoShow = $(".contact_no_show");
    
    if (ReceiveSIMBy3rdPartyDetailShow != undefined) {
        if (Chk == true) {
            ReceiveSIMBy3rdPartyDetailShow.show();
            $(".contact_person_show :input").each(function() {
                var type = this.type;
                var tag = this.tagName.toLowerCase();
                if (type == 'text') {
                    this.value = '';
                }
            });
            ContactPersonShow.hide();
            $(".contact_no_show :input").each(function() {
                var type = this.type;
                var tag = this.tagName.toLowerCase();
                if (type == 'text') {
                    this.value = '';
                }
            });
            ContactNoShow.hide();
        }
        else {
            ReceiveSIMBy3rdPartyDetailShow.hide();
            ContactPersonShow.show();
            ContactNoShow.show();
        }
    }
}



function CopyCustomData(ID) {
    var Company_name = $("." + ID + "company_name");
    var Id_type = $("." + ID + "id_type");
    var Service_activation_date = $("." + ID + "service_activation_date");
    var Hkid = $("." + ID + "hkid");
    var Hkid2 = $("." + ID + "hkid2");
    var Registered_name = $("." + ID + "registered_name");
    var Transfer_to_3g = $("." + ID + "transfer_to_3g");
    var Transfer_idd_deposit = $("." + ID + "transfer_idd_deposit");
    var Transfer_idd_roaming_deposit = $("." + ID + "transfer_idd_roaming_deposit");
    var Transfer_no_hk_id_holder_deposit = $("." + ID + "transfer_no_hk_id_holder_deposit");
    var Transfer_no_add_proof_deposit = $("." + ID + "transfer_no_add_proof_deposit");
    var Transfer_others_deposit = $("." + ID + "transfer_others_deposit");
    var Service_activation_time = $("." + ID + "service_activation_time");
    var Ticker_number = $("." + ID + "ticker_number");


    var _Id_type = $("#id_type");
    var _Hkid = $("#hkid");
    var _Hkid2 = $("#hkid2");

    Registered_name.val(GetCustomerName());
    Id_type.val(_Id_type.val());
    Hkid.val(_Hkid.val());
    Hkid2.val(_Hkid2.val());
    return false;
}


function CheckThreeParty(ID) {
    var IssueType = $("#issue_type");
    if (IssueType.val() == "") { return true; }
    
    var ReceiveSIMBy3rdPartyDetailShow = $(".ReceiveSIMBy3rdPartyDetailShow");
    var Three_party = $("."+ID+"three_party");
    var Plural = $("." + ID + "plural");
    var Arthurization_person = $("." + ID + "arthurization_person");
    var Id_type = $("." + ID + "id_type");
    var Hkid = $("." + ID + "hkid");
    var Hkid2 = $("." + ID + "hkid2");
    var Contact_no = $("." + ID + "contact_no");
    var Flag = true;
    
    if (Three_party != undefined &&
    Plural != undefined &&
    Arthurization_person != undefined &&
    Id_type != undefined &&
    Hkid != undefined &&
    Hkid2 != undefined &&
    Contact_no != undefined) {

        if (ReceiveSIMBy3rdPartyDetailShow.css("display") != "none") {
            if (Plural.val() == "" && Flag) {
                Flag = false;
                alert("Please kindly input [Receive SIM by 3rd part] plural!");
            }
            if (Id_type.val() == "" && Flag) {
                Flag = false;
                alert("Please kindly input  [Receive SIM by 3rd part] Id_type!");
            }
            if (Hkid.val() == "" && Flag) {
                Flag = false;
                alert("Please kindly input  [Receive SIM by 3rd part] hkid!");
            }
            if (Id_type.val() == "HKID") {
                if (Hkid2.val() == "" && Flag) {
                    Flag = false;
                    alert("Please kindly input  [Receive SIM by 3rd part] hkid2!");
                }
            }
            if (Contact_no.val() == "" && Flag) {
                Flag = false;
                alert("Please kindly input  [Receive SIM by 3rd part] contact number!");
            }
        }
    }
    return Flag;
}

function ChkGender() {
    var Id_type = document.getElementById('id_type');
    var gender = document.getElementById('gender');
    if (Id_type != undefined && gender != undefined) {
        if (Id_type.value != "BRNO") {
            if (gender.options[gender.selectedIndex].value == "") {
                alert("Please Enter Gender!");
                if (gender.style.display != "none" && gender.disabled == false) {
                    //document.getElementById('form1').gender.focus();
                }
                return false;
            }
        }
    }
    return true;
}
