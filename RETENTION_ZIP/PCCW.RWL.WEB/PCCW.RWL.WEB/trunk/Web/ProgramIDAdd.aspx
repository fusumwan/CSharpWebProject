<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProgramIDAdd.aspx.cs" Inherits="ProgramIDAdd" %>
<%@ Register TagPrefix="RWLMenu" TagName="RWLMenu" Src="~/UI/RWLControlMenu.ascx" %> 
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<%@ Import Namespace="NEURON.ENTITY.FRAMEWORK" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
<script type="text/javascript" src="../Resources/Scripts/calendarDateInput.js"></script>
<script type="text/javascript" src="../Resources/Scripts/creditcard.js"></script>
<script language="javascript">
function GetXmlHttpObject(){  
	var xmlHttp;
	if (window.XMLHttpRequest){ 
    	xmlHttp = new XMLHttpRequest(); 
	}else  if (window.ActiveXObject) {
	    try{
			 	xmlHttp=new ActiveXObject("Msxml2.XMLHTTP");      
		}catch(e){
			try{
				 xmlHttp=new ActiveXObject("Microsoft.XMLHTTP");
			}catch(e){
				 alert("Your browser does not support AJAX!");
			 	return false;
		 	}
		 }
	 }
	return xmlHttp;
}

function ajaxadd(uid){
	var xmlHttp=GetXmlHttpObject();
	var expiry_month=document.getElementById("expiry_month_m").value+"/"+document.getElementById("expiry_month_y").value
	var url = 'ProgramIDAddAction.aspx?program_id='+document.getElementById("program_id").value+"&call_list_type="+document.getElementById("call_list_type").value+"&program_name="+document.getElementById("program_name").value+"&center="+document.getElementById("center").value+"&expiry_month="+expiry_month+"&type="+document.getElementById("type").value+"&call_list_size="+document.getElementById("call_list_size").value+"&remarks="+document.getElementById("remarks").value+"&sdate="+document.getElementById("sdate").value+"&edate="+document.getElementById("edate").value+"&return_date="+document.getElementById("return_date").value+"&upload_date="+document.getElementById("upload_date").value+"&cid="+uid+"&time="+Math.random();
	//alert(url)
	xmlHttp.onreadystatechange=function(){
		if(xmlHttp.readyState==4){
		
		
		
   		//var vas_name= new Array()
	    //vas_name = xmlHttp.responseText;
		alert(xmlHttp.responseText);
		myWindow=window.open('ProgramIDManagement.aspx?program_id='+document.getElementById("program_id").value,'popup', 'toolbar=no, status=no, resizable=no, width=100, height=650, scrollbars=no, menu=no')
		/*
	    for(i = 0; i<vas_name.length-1; i++){
		  document.getElementById(vas_name[i]).disabled =false;
		  citem[i]=vas_name[i].charAt(vas_name[i].lenght-1);
		        if ((vas_name[i].charAt(vas_name[i].length-1))!=1){
		          document.getElementById("program_name").value=vas_name[0];
			    }
		 }
		 */
	}
  }	
	xmlHttp.open('GET',url,true);
	xmlHttp.send(null);
}
</script>

</head>
<body>

    <form id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>

    

    
    <table  border="0" cellpadding="3" cellspacing="1" class="forumline" width="100%">

					<th colspan="6" height="0" >New Program ID</th>
						
						<tr align="left">
							<td colspan="6" height="0" class="row2"><input type="button" name="save" id="save" class="mainoption" value="ADD" onClick="ajaxadd(<%=Session["uid"] %>)"/></td>
						</tr>
						
						<tr align="left">
							<td colspan="3" height="0" class="row2"><span class="explaintitle"  style="font-size:8pt">Program ID</span></td>
							<td colspan="3" height="0" class="row1"><input type="text" name="program_id" id="program_id" size="5" maxlength="4" /></td>
						</tr>
						
						<tr align="left">
							<td colspan="3" height="0" class="row2"><span class="explaintitle"  style="font-size:8pt">Call List Type</span></td>
							<td colspan="3" height="0" class="row1"><input type="text" name="call_list_type" id="call_list_type" size="10" maxlength="9"  onchange="chg_upper(this);"  /></td>
						</tr>
						
						<tr >
							<td colspan="3" height="0" class="row2"><span class="explaintitle"  style="font-size:8pt">Program Name</span></td>
							<td colspan="3" height="0" class="row1"><input type="text" name="program_name" id="program_name" size="100" maxlength="99" onChange="chg_upper(this);" /></td>
						</tr>
						
						<tr align="left">
							<td colspan="3" height="0" class="row2"><span class="explaintitle"  style="font-size:8pt">Center</span></td>
							<td colspan="3" height="0" class="row1">
							<asp:DropDownList ID="center" AppendDataBoundItems="true" runat="server" CssClass="mainoption">
							<asp:ListItem Text=""></asp:ListItem>
							</asp:DropDownList>	
							</td>
						</tr>

						<tr align="left">
							<td colspan="3" height="0" class="row2"><span class="explaintitle"  style="font-size:8pt">Expiry Month</span></td>
							<td colspan="3" height="0" class="row1">
								<select name="expiry_month_m" id="expiry_month_m" class="mainoption" >
									<option value=""></option>
									<option value="JAN">JAN</option>
									<option value="FEB">FEB</option>
									<option value="MAR">MAR</option>
									<option value="APR">APR</option>
									<option value="MAY">MAY</option>
									<option value="JUN">JUN</option>
									<option value="JUL">JUL</option>
									<option value="AUG">AUG</option>
									<option value="SEPT">SEPT</option>
									<option value="OCT">OCT</option>
									<option value="NOV">NOV</option>
									<option value="DEC">DEC</option>
								</select>
								<select name="expiry_month_y" id="expiry_month_y" class="mainoption" >
									<option value=""></option>
									<option value="2008">2008</option>
									<option value="2009">2009</option>
									<option value="2010">2010</option>
									<option value="2011">2011</option>
									<option value="2012">2012</option>
									<option value="2013">2013</option>
									<option value="2014">2014</option>
									<option value="2015">2015</option>
								</select>
							</td>
						</tr>

						<tr align="left">
							<td colspan="3" height="0" class="row2"><span class="explaintitle"  style="font-size:8pt">Type</span></td>
							<td colspan="3" height="0" class="row1"><input type="text" name="type" id="type" size="5" maxlength="4" /></td>
						</tr>

						<tr align="left">
							<td colspan="3" height="0" class="row2"><span class="explaintitle"  style="font-size:8pt">Call List Size</span></td>
							<td colspan="3" height="0" class="row1"><input type="text" name="call_list_size" id="call_list_size" size="6" maxlength="5" /></td>
						</tr>


						<tr align="left">
							<td colspan="3" height="0" class="row2"><span class="explaintitle"  style="font-size:8pt">Remarks</span></td>
               			   <td height="0" colspan="3" class="row1"><textarea name="remarks" cols="50" rows="2" id="remarks" onBlur="chg_upper(this)"></textarea></td>
						</tr>


						<tr align="left">
							<td colspan="3" height="0" class="row2"><span class="explaintitle"  style="font-size:8pt">Start Date</span></td>
               			   <td height="0" colspan="3" class="row1"><script language="javascript">DateInput('sdate', false, 'DD/MM/YYYY')</script></td>
						</tr>

						<tr align="left">
							<td colspan="3" height="0" class="row2"><span class="explaintitle"  style="font-size:8pt">End Date</span></td>
               			   <td height="0" colspan="3" class="row1"><script language="javascript">DateInput('edate', false, 'DD/MM/YYYY')</script></td>
						</tr>

						<tr align="left">
							<td colspan="3" height="0" class="row2"><span class="explaintitle"  style="font-size:8pt">Return Date</span></td>
               			   <td height="0" colspan="3" class="row1"><script language="javascript">DateInput('return_date', false, 'DD/MM/YYYY')</script></td>
						</tr>

						<tr align="left">
							<td colspan="3" height="0" class="row2"><span class="explaintitle"  style="font-size:8pt">Upload Date</span></td>
               			   <td height="0" colspan="3" class="row1"><script language="javascript">DateInput('upload_date', false, 'DD/MM/YYYY')</script></td>
						</tr>

				</table>
				
				

    </div>
    </form>
</body>
</html>