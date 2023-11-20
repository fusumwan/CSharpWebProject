
var fallout_array = {
    'A/C INFO': 'A/C INFO',
    'CUSTOMER INFO': 'CUSTOMER INFO',
    'ACTIVATION DATE': 'ACTIVATION DATE',
    'PAYMENT METHOD': 'PAYMENT METHOD',
    'WRONG VAS ENTITLEMENT': 'WRONG VAS ENTITLEMENT',
    'PROGRAM OFFER': 'PROGRAM OFFER',
    'SALES INFO': 'SALES INFO',
    'MOBILE/ SIM NO./ SERVICE NO.': 'MOBILE/ SIM NO./ SERVICE NO.',
    'BLACKLISTED CUSTOMER': 'BLACKLISTED CUSTOMER'
};

var waiting_array = {
    'WAITING': 'WAITING'
};

var mktg_array = {
    'MKTG AUTO ROLL FALLOUT': 'MKTG AUTO ROLL FALLOUT'
};

var syscode_array = {
    'STSTEM CODE NOT FOUND (REFER TO PRODUCT/MKTG)': 'STSTEM CODE NOT FOUND (REFER TO PRODUCT/MKTG)',
    'SYSTEM CODE NOT FOUND BUT ORDER ISSUED': 'SYSTEM CODE NOT FOUND BUT ORDER ISSUED'
};

var fallout_acinfo_array = {
    'A/C SUSPEND': 'A/C SUSPEND',
    'FRAUD ACCOUNT': 'FRAUD ACCOUNT',
    'WRONG ACCOUNT CODE': 'WRONG ACCOUNT CODE'
};

var fallout_customerinfo_array = {
    'INVALID / WRONG CUSTOMER NAME': 'INVALID / WRONG CUSTOMER NAME',
    'CUSTOMER HAS SVC IN-PERSON INSTRUCTION': 'CUSTOMER HAS SVC IN-PERSON INSTRUCTION'
};

var fallout_activationdate_array = {
    'EXISTING SVC CONTRACT CONTRACT > RETENTION OFFER ALLOWANCE': 'EXISTING SVC CONTRACT CONTRACT > RETENTION OFFER ALLOWANCE',
    'WRONG CONTRACT EFFECTIVE DATE': 'WRONG CONTRACT EFFECTIVE DATE',
    'WRONG RATE PLAN EFFECTIVE DATE': 'WRONG RATE PLAN EFFECTIVE DATE',
    'OFFER ALREADY ADDED BY OTHERS CHANNEL': 'OFFER ALREADY ADDED BY OTHERS CHANNEL',
    'WRONG BILL CUT DATE': 'WRONG BILL CUT DATE'
};

var fallout_paymentmethod_array = {
    'INVALID CREDIT CARD NUMBER': 'INVALID CREDIT CARD NUMBER',
    'MISSING / WRONG CREDIT CARD EXPIRY DATE': 'MISSING / WRONG CREDIT CARD EXPIRY DATE',
    'MISSING / WRONG CREDIT CARD HOLDER NAME': 'MISSING / WRONG CREDIT CARD HOLDER NAME',
    'INVALID BANK ACCOUNT INFORMATION': 'INVALID BANK ACCOUNT INFORMATION',
    'MISSING / WRONG 3RD PARTY CREDIT CARD INFO.': 'MISSING / WRONG 3RD PARTY CREDIT CARD INFO.'
};

var fallout_wrongvasselected_array = {
    'PREMIUM': 'PREMIUM',
    'FOOTBALL UNLIMITED': 'FOOTBALL UNLIMITED',
    'FINANCE INFO': 'FINANCE INFO',
    'HORSE RACING': 'HORSE RACING',
    'NOW ON MOBILE': 'NOW ON MOBILE',
    'NOW TV': 'NOW TV',
    'NOW SPORT': 'NOW SPORT',
    'MOOV': 'MOOV',
    'WIFI': 'WIFI',
    'SMS': 'SMS',
    'MOBILE INTERNET PKG': 'MOBILE INTERNET PKG',
    'CONNECTING TONE': 'CONNECTING TONE',
    'SECRETARIAL SERVICE': 'SECRETARIAL SERVICE',
    'MOBILE MSN': 'MOBILE MSN',
    'ADDITIONAL CALL MINS': 'ADDITIONAL CALL MINS',
    'EXTRA VAS OFFER BY SALES': 'EXTRA VAS OFFER BY SALES',
    'STAFF SPONSORSHIP': 'STAFF SPONSORSHIP',
    'IDD/ CHINAROAMING': 'IDD/ CHINAROAMING',
    'FREE $12 LICENSE FEE': 'FREE $12 LICENSE FEE',
    'EXTRA REBATE AMOUNT': 'EXTRA REBATE AMOUNT',
    'EXISTING FREE VAS CANNOT c/F TO NEW RETENTION OFFER': 'EXISTING FREE VAS CANNOT c/F TO NEW RETENTION OFFER',
    'NEED SALES CLARIFY WHETHER TO CANCEL EXITING VAS OR NOT': 'NEED SALES CLARIFY WHETHER TO CANCEL EXITING VAS OR NOT'
};

var fallout_programoffer_array = {
    'WRONG BUNDLE CODE': 'WRONG BUNDLE CODE',
    'WRONG CONTRACT PERIOD': 'WRONG CONTRACT PERIOD',
    'WRONG RATE PLAN': 'WRONG RATE PLAN',
    'WRONG INCENTIVE': 'WRONG INCENTIVE',
    'MISSING IMEI': 'MISSING IMEI',
    'NOT ENTITLE FOR $0 HS OFFER RULE': 'NOT ENTITLE FOR $0 HS OFFER RULE',
    'WRONG TRADEFIELD CODE': 'WRONG TRADEFIELD CODE',
    'WRONG HS AMOUNT': 'WRONG HS AMOUNT',
    'WRONG SPECIFIC VAS FOR HS OFFER': 'WRONG SPECIFIC VAS FOR HS OFFER',
    'MISSING SPECIFIC VAS FOR HS OFFER': 'MISSING SPECIFIC VAS FOR HS OFFER'
};

var fallout_salesinfo_array = {
    'SALESMAN CODE NOT FOUND': 'SALESMAN CODE NOT FOUND'
};

var fallout_serviceno_array = {
    'WRONG MOB NO.': 'WRONG MOB NO.',
    'MOB NO. DE-ACTIVATED ALREADY': 'MOB NO. DE-ACTIVATED ALREADY'
}

var fallout_blacklist_array = {
    'MOB CUSTOMER BLACKLISTED': 'MOB CUSTOMER BLACKLISTED'
}

var waiting_waiting_array = {
    'PENDING CHANGE SERVICE PACK': 'PENDING CHANGE SERVICE PACK',
    'AWAITING FRAUD TEAM REPLY': 'AWAITING FRAUD TEAM REPLY',
    'AWAITING HELPDESK REPLY': 'AWAITING HELPDESK REPLY'
};


var mktg_mktg_array = {
    'ACCOUNT SUSPENDED': 'ACCOUNT SUSPENDED',
    'FRAUD ACCOUNT': 'FRAUD ACCOUNT',
    'MOB NO. DE-ACTIVATED ALREADY': 'MOB NO. DE-ACTIVATED ALREADY',
    'WRONG MOB NO.': 'WRONG MOB NO.',
    'CUSTOMER HAS SVC IN-PERSON INSTRUCTION': 'CUSTOMER HAS SVC IN-PERSON INSTRUCTION',
    'RETENTION CONTRACT EXTG': 'RETENTION CONTRACT EXTG',
    'OPT OUT CASE': 'OPT OUT CASE'
};

var syscode_product_array = {
    'STSTEM CODE NOT FOUND (REFER TO PRODUCT/MKTG)': 'STSTEM CODE NOT FOUND (REFER TO PRODUCT/MKTG)'
};

var syscode_orderissued_array = {
    'SYSTEM CODE NOT FOUND BUT ORDER ISSUED': 'SYSTEM CODE NOT FOUND BUT ORDER ISSUED'
};

function get_fallout_main_array(orderStatus) {
    var select = document.getElementById("fallout_main_category");
    if (orderStatus == 'FALLOUT') {
        select.options.length = 0;
        select.options[select.options.length] = new Option("", "");
        for (index in fallout_array) {
            select.options[select.options.length] = new Option(fallout_array[index], index);
        }
    }
    else if (orderStatus == 'WAITING') {
        select.options.length = 0;
        select.options[select.options.length] = new Option("", "");
        for (index in waiting_array) {
            select.options[select.options.length] = new Option(waiting_array[index], index);
        }
    }
    else if (orderStatus == 'MKTG AUTO ROLL FALLOUT') {
        select.options.length = 0;
        select.options[select.options.length] = new Option("", "");
        for (index in mktg_array) {
            select.options[select.options.length] = new Option(mktg_array[index], index);
        }
    }
    else if (orderStatus == 'SYSTEM CODE') {
        select.options.length = 0;
        select.options[select.options.length] = new Option("", "");
        for (index in syscode_array) {
            select.options[select.options.length] = new Option(syscode_array[index], index);
        }
    }
}

function get_sub_cat_array(falloutMain) {
    var select = document.getElementById("fallout_reason");
    if (falloutMain == 'A/C INFO') {
        select.options.length = 0;
        select.options[select.options.length] = new Option("", "");
        for (index in fallout_acinfo_array) {
            select.options[select.options.length] = new Option(fallout_acinfo_array[index], index);
        }
    }
    else if (falloutMain == 'CUSTOMER INFO') {
        select.options.length = 0;
        select.options[select.options.length] = new Option("", "");
        for (index in fallout_customerinfo_array) {
            select.options[select.options.length] = new Option(fallout_customerinfo_array[index], index);
        }
    }
    else if (falloutMain == 'ACTIVATION DATE') {
        select.options.length = 0;
        select.options[select.options.length] = new Option("", "");
        for (index in fallout_activationdate_array) {
            select.options[select.options.length] = new Option(fallout_activationdate_array[index], index);
        }
    }
    else if (falloutMain == 'PAYMENT METHOD') {
        select.options.length = 0;
        select.options[select.options.length] = new Option("", "");
        for (index in fallout_paymentmethod_array) {
            select.options[select.options.length] = new Option(fallout_paymentmethod_array[index], index);
        }
    }
    else if (falloutMain == 'WRONG VAS ENTITLEMENT') {
        select.options.length = 0;
        select.options[select.options.length] = new Option("", "");
        for (index in fallout_wrongvasselected_array) {
            select.options[select.options.length] = new Option(fallout_wrongvasselected_array[index], index);
        }
    }
    else if (falloutMain == 'PROGRAM OFFER') {
        select.options.length = 0;
        select.options[select.options.length] = new Option("", "");
        for (index in fallout_programoffer_array) {
            select.options[select.options.length] = new Option(fallout_programoffer_array[index], index);
        }
    }
    else if (falloutMain == 'SALES INFO') {
        select.options.length = 0;
        select.options[select.options.length] = new Option("", "");
        for (index in fallout_salesinfo_array) {
            select.options[select.options.length] = new Option(fallout_salesinfo_array[index], index);
        }
    }
    else if (falloutMain == 'MOBILE/ SIM NO./ SERVICE NO.') {
        select.options.length = 0;
        select.options[select.options.length] = new Option("", "");
        for (index in fallout_serviceno_array) {
            select.options[select.options.length] = new Option(fallout_serviceno_array[index], index);
        }
    }
    else if (falloutMain == 'BLACKLISTED CUSTOMER') {
        select.options.length = 0;
        select.options[select.options.length] = new Option("", "");
        for (index in fallout_blacklist_array) {
            select.options[select.options.length] = new Option(fallout_blacklist_array[index], index);
        }
    }
    else if (falloutMain == 'WAITING') {
        select.options.length = 0;
        select.options[select.options.length] = new Option("", "");
        for (index in waiting_waiting_array) {
            select.options[select.options.length] = new Option(waiting_waiting_array[index], index);
        }
    }
    else if (falloutMain == 'MKTG AUTO ROLL FALLOUT') {
        select.options.length = 0;
        select.options[select.options.length] = new Option("", "");
        for (index in mktg_mktg_array) {
            select.options[select.options.length] = new Option(mktg_mktg_array[index], index);
        }
    }
    else if (falloutMain == 'STSTEM CODE NOT FOUND (REFER TO PRODUCT/MKTG)') {
        select.options.length = 0;
        select.options[select.options.length] = new Option("", "");
        for (index in syscode_product_array) {
            select.options[select.options.length] = new Option(syscode_product_array[index], index);
        }
    }
    else if (falloutMain == 'SYSTEM CODE NOT FOUND BUT ORDER ISSUED') {
        select.options.length = 0;
        select.options[select.options.length] = new Option("", "");
        for (index in syscode_orderissued_array) {
            select.options[select.options.length] = new Option(syscode_orderissued_array[index], index);
        }
    }

}



function order_status_change(tobj) {

    if (tobj.value == 'FALLOUT' | tobj.value == 'WAITING' | tobj.value == 'MKTG AUTO ROLL FALLOUT' | tobj.value == 'SYSTEM CODE') {
        try {
            get_fallout_main_array(tobj.value);
        }
        catch (e) {
            alert(e);
        }
        if (document.getElementById('fallout_reason') != undefined) document.getElementById('fallout_reason').value = '';
        if (document.getElementById('fallout_remark') != undefined) document.getElementById('fallout_remark').value = '';
        if (document.getElementById('fallout_reason') != undefined) document.getElementById('fallout_main_category').value = '';
        if (document.getElementById('fallout_reason') != undefined) document.getElementById('fallout_reason').disabled = true;
        if (document.getElementById('fallout_remark') != undefined) document.getElementById('fallout_remark').disabled = true;
        if (document.getElementById('fallout_main_category') != undefined) document.getElementById('fallout_main_category').disabled = false;
        //if(document.getElementById('fallout_remark')!=undefined) document.getElementById('fallout_remark').style.background='#FFFFFF';
    }
    else {
        if (document.getElementById('fallout_reason') != undefined) document.getElementById('fallout_reason').value = '';
        if (document.getElementById('fallout_remark') != undefined) document.getElementById('fallout_remark').value = '';
        if (document.getElementById('fallout_main_category') != undefined) document.getElementById('fallout_main_category').value = '';
        if (document.getElementById('fallout_reason') != undefined) document.getElementById('fallout_reason').disabled = true;
        if (document.getElementById('fallout_remark') != undefined) document.getElementById('fallout_remark').disabled = true;
        if (document.getElementById('fallout_main_category') != undefined) document.getElementById('fallout_main_category').disabled = true;
        if (document.getElementById('fallout_remark') != undefined) document.getElementById('fallout_remark').style.background = '#DDDDDD';
    }
}
