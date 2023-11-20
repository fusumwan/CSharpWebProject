var VasFieldMultiArr;
var Value1Arr;
var Value2Arr;

function resetForm(uid) {
    $('#BusinessVasDefaultSetFW :input', form1).each(function() {
        var type = this.type;
        var tag = this.tagName.toLowerCase();
        if (type == 'text' || type == 'password' || tag == 'textarea')
            this.value = "";
        else if (type == 'checkbox' || type == 'radio')
            this.checked = false;
        else if (tag == 'select')
            this.selectedIndex = -1;
    });
    $("#BusinessVasDefaultSetFW_BusinessVasDefaultSet_cidTextBox").val(uid);
    $("#BusinessVasDefaultSetFW_BusinessVasDefaultSet_activeCheckBox").attr('checked', true);
};

function clearFWVAS() {
    $("#BusinessVasDefaultSetFW_BusinessVasDefaultSet_value1TextBox").val('');
    $("#BusinessVasDefaultSetFW_BusinessVasDefaultSet_value2TextBox").val('');
    $("#BusinessVasDefaultSetFW_BusinessVasDefaultSet_enabled1CheckBox").attr('checked', false);
    $("#BusinessVasDefaultSetFW_BusinessVasDefaultSet_enabled2CheckBox").attr('checked', false);
    $("#BusinessVasDefaultSetFW_BusinessVasDefaultSet_display1CheckBox").attr('checked', false);
    $("#BusinessVasDefaultSetFW_BusinessVasDefaultSet_display2CheckBox").attr('checked', false);
}

function isNum(tobj) {
    if (tobj.value != "") {
        a = Number(tobj.value);
        if (!(a) && tobj.value != "0") {
            alert("Number Only!");
            tobj.value = "";
        }
    }
    else
        tobj.value = "";
}

function chk_save(ThisForm) {
    if (event.returnValue != false) {
        if (confirm("Are you sure you want to Save?") == false)
            event.returnValue = false;
        else
            ThisForm.submit();
    }
}

function copy2Hidden(name) {
    var selected = $("#BusinessVasDefaultSetFW_BusinessVasDefaultSet_" + name + "DropDownList option:selected");
    var output = "";
    //if (selected.val() != 0) {
    output = selected.val();
    //}
    $("#BusinessVasDefaultSetFW_BusinessVasDefaultSet_" + name + "TextBox").val(output);
}

function copy2vas2() {
    var selected = $("#BusinessVasDefaultSetFW_BusinessVasDefaultSet_vas1DropDownList option:selected");
    var output = "";
    if (selected.val() != 0) {
        if (checkMulti(selected.val())) {
            output = selected.val() + "1";
            $('.vas2_tr').show();
        } else {
            $("#BusinessVasDefaultSetFW_BusinessVasDefaultSet_enabled2CheckBox").attr('checked', false);
            $("#BusinessVasDefaultSetFW_BusinessVasDefaultSet_display2CheckBox").attr('checked', false);
            $('.vas2_tr').hide();
        }
    }
    $("#BusinessVasDefaultSetFW_BusinessVasDefaultSet_vas2TextBox").val(output);
}


function copy2GWHidden(name) {
    var selected = $('#BusinessVasDefaultSetGW select[id*=_BusinessVasDefaultSet_' + name + 'DropDownList]');
    var output = "";
    //if (selected.val() != 0) {
    output = selected.val();
    //}
    $('#BusinessVasDefaultSetGW input[id*=_BusinessVasDefaultSet_' + name + ']').val(output);
}

function copy2GWvas2() {
    var selected = $('#BusinessVasDefaultSetGW select[id*=_BusinessVasDefaultSet_vas1DropDownList]');
    var output = "";
    if (selected.val() != 0) {
        if (checkMulti(selected.val())) {
            output = selected.val() + "1";
            $('.vas2Component').attr('disabled', '');
        } else {
            $('#BusinessVasDefaultSetGW .vas2Component').attr('disabled', 'disabled');
            $('#BusinessVasDefaultSetGW input[id*=_BusinessVasDefaultSet_vas2]').val('');
            $('#BusinessVasDefaultSetGW input[id*=_BusinessVasDefaultSet_value2]').val('');
            $('#BusinessVasDefaultSetGW input[id*=_BusinessVasDefaultSet_enabled2]').attr('checked', false);
            $('#BusinessVasDefaultSetGW input[id*=_BusinessVasDefaultSet_display2]').attr('checked', false);
        }
    }
    $('#BusinessVasDefaultSetGW input[id*=_BusinessVasDefaultSet_vas2]').val(output);
}


function checkMulti(x_vas_field) {
    for (i = 0; i < VasFieldMultiArr.length; i++) {
        if (VasFieldMultiArr[i][0] == x_vas_field) {
            if (VasFieldMultiArr[i][1] == "true") {
                return true;
            } else {
                return false;
            }
        }
    }
    return false;
}

function GWvalue1DropdownlistDataBind() {
    x_vas_field = $('#BusinessVasDefaultSetGW input[id*=_BusinessVasDefaultSet_vas1]').val();
    x_value1 = $('#BusinessVasDefaultSetGW input[id*=_BusinessVasDefaultSet_value1]').val();
    $('#BusinessVasDefaultSetGW select[id*=_BusinessVasDefaultSet_value1DropDownList] > option').remove();
    jQuery.unique(Value1Arr);
    jQuery.each(Value1Arr, function() {
        if (this[0] == x_vas_field || this[0] == "") {
            $('#BusinessVasDefaultSetGW select[id*=_BusinessVasDefaultSet_value1DropDownList]').append(
                        $('<option></option>').val(this[1]).html(this[2])
                    );
            $('#BusinessVasDefaultSetGW select[id*=_BusinessVasDefaultSet_value1DropDownList] option[value=' + x_value1 + ']').attr('selected', 'selected');
        }
    });
}

function GWvalue2DropdownlistDataBind() {
    x_vas_field = $('#BusinessVasDefaultSetGW input[id*=_BusinessVasDefaultSet_vas1]').val();
    x_value2 = $('#BusinessVasDefaultSetGW input[id*=_BusinessVasDefaultSet_value2]').val();
    $('#BusinessVasDefaultSetGW select[id*=_BusinessVasDefaultSet_value2DropDownList] > option').remove();
    jQuery.unique(Value2Arr);
    jQuery.each(Value2Arr, function() {
        if (this[0] == x_vas_field || this[0] == "") {
            $('#BusinessVasDefaultSetGW select[id*=_BusinessVasDefaultSet_value2DropDownList]').append(
                        $('<option></option>').val(this[1]).html(this[2])
                    );
            $('#BusinessVasDefaultSetGW select[id*=_BusinessVasDefaultSet_value2DropDownList] option[value=' + x_value2 + ']').attr('selected', 'selected');
        }
    });
}

function FWvalue1DropdownlistDataBind() {
    //_sParentId = (x_s == "GW" ? "BusinessVasDefaultSetGW" : "BusinessVasDefaultSetFW");
    x_vas_field = $('#BusinessVasDefaultSetFW input[id*=_BusinessVasDefaultSet_vas1TextBox]').val();
    x_value1 = $('#BusinessVasDefaultSetFW input[id*=_BusinessVasDefaultSet_value1TextBox]').val();
    $('#BusinessVasDefaultSetFW select[id*=_BusinessVasDefaultSet_value1DropDownList] > option').remove();
    jQuery.unique(Value1Arr);
    jQuery.each(Value1Arr, function() {
        if (this[0] == x_vas_field || this[0] == "") {
            $('#BusinessVasDefaultSetFW select[id*=_BusinessVasDefaultSet_value1DropDownList]').append(
                        $('<option></option>').val(this[1]).html(this[2])
                    );
            //$('#BusinessVasDefaultSetFW select[id*=_BusinessVasDefaultSet_value1DropDownList] option[value=' + x_value1 + ']').attr('selected', 'selected');
        }
    });
}


function FWvalue2DropdownlistDataBind() {
    x_vas_field = $('#BusinessVasDefaultSetFW input[id*=_BusinessVasDefaultSet_vas1TextBox]').val();
    x_value2 = $('#BusinessVasDefaultSetFW input[id*=_BusinessVasDefaultSet_value2TextBox]').val();
    $('#BusinessVasDefaultSetFW select[id*=_BusinessVasDefaultSet_value2DropDownList] > option').remove();
    jQuery.unique(Value2Arr);
    jQuery.each(Value2Arr, function() {
        if (this[0] == x_vas_field || this[0] == "") {
            $('#BusinessVasDefaultSetFW select[id*=_BusinessVasDefaultSet_value2DropDownList]').append(
                        $('<option></option>').val(this[1]).html(this[2])
                    );
        }
    });
}


function clearVasBox() {
    vas_field = $('#BusinessVasDefaultSetFW input[id*=_BusinessVasDefaultSet_vas1TextBox]');
    value1 = $('#BusinessVasDefaultSetFW input[id*=_BusinessVasDefaultSet_value1TextBox]');
    value2 = $('#BusinessVasDefaultSetFW input[id*=_BusinessVasDefaultSet_value2TextBox]');

}

function chk_save() {
    // validate fields of form
    $("input[id*=_BusinessVasDefaultSet_program]").validate({
        rules: {
            name: {
                required: true,
                minlength: 2
            }
        },
        messages: {
            name: {
                required: "Please select the program name!",
                minlength: jQuery.format("At least {0} characters required!")
            }
        }
    })



    // check duplication


}
        