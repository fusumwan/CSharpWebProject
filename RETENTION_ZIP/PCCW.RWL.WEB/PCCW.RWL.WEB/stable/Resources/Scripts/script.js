// JavaScript Document


var flag=0
function chg_staff_no(sobj,tobj) {
//alert('shit')
	if (flag==0) {
		if (sobj.options[sobj.selectedIndex].value == "DIRECT CALL") {
			tobj.value='321321'
			flag=1
		}
	}
}

function copyValue(sobj,tobj){
//	if(sobj.options[sobj.selectedIndex].value != "")
	  tobj.value=sobj.options[sobj.selectedIndex].value
}

function chk_dateRange(dtobj,frdt,todt,chkempty) {
	chk_date(dtobj,chkempty)
	dt1= Date.parse(dtobj.value);
	dt2= Date.parse(Date());
	dif=Math.ceil((dt1-dt2)/(1000*60*60*24))
	if ((dif>=frdt && dif<=todt) || (dif>=frdt && todt=='')) {
		return true
	}
	else {
		alert("Date is not in the accepted Range!")
//		dtobj.focus()
		return false
	}
}

function chk_date(dtobj,chkempty){
	var today = new Date()
	if(dtobj.value != "" || chkempty==1) {
		if(dtobj.value.match(/^\d{8}$/)==null) {
		}
		else {
			txt=dtobj.value.substring(0,2)+"/"+dtobj.value.substring(2,4)+"/"+dtobj.value.substring(4,8)
			dtobj.value=txt
		}
		dt="";
		if(today.getMonth()+1<10)
			dt="0"

		dt+=today.getMonth()+1;
		dt+="/";
		dt+="01/"
		dt+=today.getYear();

		//alert (dt);
		var datePat = /^(\d{1,2})(\/|-)(\d{1,2})\2(\d{2}|\d{4})$/;
		var matchArray = dtobj.value.match(datePat); // is the format ok?
		if (matchArray == null) {
			alert("Date is not in a valid format.")
			dtobj.value=dt;
			return false;
		}
		month = matchArray[1]; // parse date into variables
		day = matchArray[3];
		year = matchArray[4];
		if (month < 1 || month > 12) { // check month range
			alert("Month must be between 1 and 12.");
			dtobj.value=dt;
			return false;
		}
		if (day < 1 || day > 31) {
			alert("Day must be between 1 and 31.");
			dtobj.value=dt;
			return false;
		}
		if ((month==4 || month==6 || month==9 || month==11) && day==31) {
			alert("Month "+month+" doesn't have 31 days!")
			dtobj.value=dt;
			return false
		}
		if (month == 2) { // check for february 29th
			var isleap = (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
			if (day>29 || (day==29 && !isleap)) {
				alert("February " + year + " doesn't have " + day + " days!");
				dtobj.value=dt;
				return false;
			}
		}
	}
}

function chk_date2(date1, date2){

    if(date1.value != "")
    {
	check  = true;

	end_date = date1.value.split("/");
	start_date = date2.value.split("/");
	check = false;
	
	s1 = new Date(end_date[2], end_date[0]-1,end_date[1]);
	s2 = new Date(start_date[2] , start_date[0]-1 , start_date[1]);

	if(s1.getYear() == s2.getYear())
	{
	   if(s1.getMonth() == s2.getMonth())
	   {
		if(s1.getDate() >= s2.getDate())
		    check = true;
	   }
	   else if(s1.getMonth() > s2.getMonth())
		check = true;
 	}
	else if (s1.getYear() > s2.getYear())
	   check = true;

	if( check == false )
	{
	   alert ("End Date Error! End Date < Start Date");
	   date1.focus();
	   return false
	}
    }
    return true
}

function chg_upper(tobj){
	tobj.value=tobj.value.toUpperCase()
}

function chk_order(tobj){
	if(tobj.value.length !=0){
		tobj.value=tobj.value.toUpperCase();
		if(tobj.value.length ==12){
			tobj.value=Number(tobj.value);
			if(tobj.value=="NaN"){
				alert ("Invalid CXS Order Number!");
				tobj.value="";
			}
		}
		else{
			if(tobj.value.length ==6){
				tobj.value=tobj.value.toUpperCase();
				var numPat = /[T|V]\d{5}/;
				var matchArray = tobj.value.match(numPat); // is the format ok?
				if (matchArray==null){
					alert ("Invalid PC Order Number!");
					tobj.value="";
				}
			}	
			else{
				if(tobj.value.length ==9){
					tobj.value=tobj.value.toUpperCase();
					var numPat2 = /[YTO][B5][B6][IK]\/\d{4}/;
					var matchArray2 = tobj.value.match(numPat2);
					if (matchArray2==null){
						alert ("Invalid BBI Order / 56K Order Number!");
						tobj.value="";
					}
				}
				else{
					if(tobj.value.length ==10){
						tobj.value=tobj.value.toUpperCase();
						var numPat3 = /^OWORK\/\d{4}$|^[TF][B][B][I]\/\d{5}$/;
						var matchArray3 = tobj.value.match(numPat3);
						if (matchArray3==null){
							alert ("Invalid @WORK Order Number!");
							tobj.value="";
						}
					}
					else{
						if(tobj.value.length==11){
							tobj.value=tobj.value.toUpperCase();
							var numPat4 = /^FSA\d{8}$|^[TF][B][B][I]\/\d{5}[a-zA-Z]$/;
							var matchArray4 = tobj.value.match(numPat4);
							if(matchArray4==null){
								alert ("Invalid FSA Order Number!");
								tobj.value="";
							}
						}
						else{
							if(tobj.value.length ==16){
								tobj.value=tobj.value.toUpperCase();
								if(tobj.value.substr(0,3)=="CFO"){
									var numPat5 = /^CFO\d{4}\/\d{5}\/\d{2}$/;
									var matchArray5 = tobj.value.match(numPat5);
									if (matchArray5==null){
										alert ("Invalid Fax & Phone Order Number!");
										tobj.value="";
									}
								}
								else{
									if(tobj.value.substr(7,3)=="PCD"){
										var numPat6 = /\d{5}\/[YC]PCD\/\d{2}\/\w/;
										var matchArray6 = tobj.value.match(numPat6);
										if(matchArray6==null){
											alert ("Invalid PCD Order Number!");
											tobj.value="";
										}
									}
								}
							}
							else{
								alert ("Invalid Order Number Format!");
								tobj.value="";
							}
						}
					}
				}
			}
		}
	}
}

function chk_telno(tobj){
	if(tobj.value.length!=0){
		var numPat=/^\d{8}$/;
		var matchArray = tobj.value.match(numPat); // is the format ok?
		if (matchArray == null) {
			event.returnValue=false;
			alert("Invalid Contact Number!")
			tobj.value="";
			return false;
		}
	}
}

function chk_cur(tobj){
	var revPat=/^\d{1,}\.?\d{0,}$/;
	var matchArray = tobj.value.match(revPat);
	if (matchArray==null){
		alert ("Invalid Currency Format!");
		tobj.value="0";
		return false;
	}
}

function chk_hkid(sobj) {
	if (sobj.value.length!=0) {
		var hkidno=sobj.value.toUpperCase();
		sobj.value=hkidno;
		hkidno=hkidno.replace('(','');
		hkidno=hkidno.replace(')','');
		hkidno=hkidno.toUpperCase();
		var hkidnoL=hkidno.length;
		if (hkidnoL<8) {
			alert("Invalid HKID Card Number!");
			return false;
		}
		if (hkidnoL==8) {
			ch='';
			ch2=hkidno.charAt(0);
			isNine=0;
		}
		if (hkidnoL==9) {
			ch=hkidno.charAt(0);
			ch2=hkidno.charAt(1);
			isNine=1;
		}
		if (hkidnoL<8||hkidnoL>9) {
			alert("Invalid HKID Card Number!");
			return false;
		}
		if ((ch==''||(ch>='A'&&ch<='Z'))&&(ch2>='A'&&ch2<='Z')) {
		}
		else {
			alert("Invalid HKID Card Number!");
			return false;
		}
		if (ch.charAt(0)=="") {
			chk=58*9;
		}
		else {
			chk=(ch.charCodeAt(0)-55)*9;
		}
		chk+=(ch2.charCodeAt(0)-55)*8;
		for(i=(1+isNine); i<hkidnoL-1; i++) {
			if(hkidno.charAt(i)>='0'&&hkidno.charAt(i)<='9') {
				chk+=hkidno.charAt(i)*(8-i+isNine)
			}
			else {
				alert("Invalid HKID Card Number!");
				return false;
			}
		}
		chk2=Math.floor(chk/11)+1;
		chk2=chk2*11;
		chk3=chk2-chk;
		if (chk3==10) {
			chk3='A';
		}
		if (chk3==11) {
			chk3='0';
		}
		if (chk3!=hkidno.charAt(7+isNine)) {
			alert("Invalid HKID Card Number!");
			return false;
		}
		return true;
	}
}

function openWindow(url,width,height) {
	x = (640 - width)/2, y = (480 - height)/2;
	if (screen) {
		y = (screen.availHeight - height)/2;
		x = (screen.availWidth - width)/2;
	}
	window.open(url,'newWin','width='+width+',height='+height+',screenX='+x+',screenY='+y+',top='+y+',left='+x+',location=0,menu=0,tool=0,directories=0,scrollbars,toolbar=0,status=0,menubar=0,resizable=0,copyhistory=0,titlebar=0');
}

function replace(string,text,by) {
// Replaces text with by in string
// usage: onblur="this.form.txtCSS.value=replace(this.form.txtCSS.value,' ','');"
	var strLength = string.length, txtLength = text.length;
	if ((strLength == 0) || (txtLength == 0)) return string;
	var i = string.indexOf(text);
	if ((!i) && (text != string.substring(0,txtLength))) return string;
	if (i == -1) return string;
	var newstr = string.substring(0,i) + by;
	if (i+txtLength < strLength)
		newstr += replace(string.substring(i+txtLength,strLength),text,by);
	return newstr;
}

//P廨iode peut prendre les valeurs : yyyy (ann嶪) m (mois) ww (semaine) d (jour) h (heure) n (minute) s (seconde) 
function datediff(per,d1,d2) {
   var d = (d2.getTime()-d1.getTime())/1000
   switch(per) {
      case "yyyy": d/=12
      case "m": d*=12*7/365.25
      case "ww": d/=7
      case "d": d/=24
      case "h": d/=60
      case "n": d/=60
   }
   return Math.round(d);
}

function chk_time(objC){
	if(objC.value.length!=0){
		if(objC.value.match(/^\d{4}$/)==null) {
		}
		else {
			txt=objC.value.substring(0,2)+":"+objC.value.substring(2,4)
			objC.value=txt
		}
		if(objC.value.match(/^\d{2}:\d{2}$/)==null){
			alert ("Invalid Time format! HH:MM");
			objC.value="";
			objC.focus();
			return false;
		}
		if(parseInt(objC.value.substring(0,2))<0 || parseInt(objC.value.substring(0,2))>23) {
			alert ("Hour should be in the range 00-23");
			objC.value="";
			objC.focus();
			return false;
		}
		if(parseInt(objC.value.substring(3,5))<0 || parseInt(objC.value.substring(3,5))>59) {
			alert ("Minute should be in the range 00-59");
			objC.value="";
			objC.focus();
			return false;
		}
	}
}
