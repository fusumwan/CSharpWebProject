<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RetrieveMobileLiteFalloutAction.aspx.cs" Inherits="RetrieveMobileLiteFalloutAction" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Import Namespace="PCCW.RWL.CORE" %>
<%@ Import Namespace="NEURON.ENTITY.FRAMEWORK" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<style>
.disablerow{background:#DDDDDD}
</style>
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
<script type="text/javascript">
<!--
function close_win(){
	return top.location="../chk_login.asp"
}


function select_all(){
    var RecordCnt = document.getElementById('record_cnt');
    var RetrieveId = document.getElementsByName('retrieve_id');
    
    if(RecordCnt==undefined) return false;
    if(RetrieveId==undefined) return false;
	if ('1'!=RecordCnt.value){
		for (i=0;i<RetrieveId.length;++ i){
			RetrieveId[i].checked=true;
		}	
			
	}
	else{
		RetrieveId.checked=true;
	}
}
function select_none(){
    var RecordCnt = document.getElementById('record_cnt');
    var RetrieveId = document.getElementsByName('retrieve_id');

    if(RecordCnt==undefined) return false;
    if(RetrieveId==undefined) return false;
	if ('1'!=RecordCnt.value){
		for (i=0;i<RetrieveId.length;++ i){
			RetrieveId[i].checked=false;
		}
	}
	else{
		RetrieveId.checked=false;
    }
}


function ErrorLog(e,num){
    var str="An exception occurred in the script. \n Error name: " + e.name+"\n";
    str+=". Error description: " + e.description+"\n";
    str+=". Error number: " + e.number+"\n";
    str+=". Error message: " + e.message+"\n";
    str+=". Error lineNumber: " +e.line+"\n";
    alert("num : "+ num+"\n"+str);
}


function chk_save(ThisForm){
    try{
    
    var RecordCnt = document.getElementById('record_cnt');
    var RetrieveId = document.getElementsByName('retrieve_id');
    var Submit2 = document.getElementById('submit2');
    
    if(RecordCnt==undefined) return false;
    if(RetrieveId==undefined) return false;
    if(Submit2==undefined) return false;
    
	    if ('1'!=RecordCnt.value){
		    fallout=0

		    for (i=0;i<RetrieveId.length;++ i)
		    {
			    if (RetrieveId[i].checked)
				    fallout++
		    }

		    if (fallout==0){
			    alert ("At least Select 1 Order!");
			    event.returnValue=false;
			    Submit2.disabled=false;
		    }
	    }
	    else{

		    if (!document.all.retrieve_id.checked){
			    alert ("Select 1 Order!");
			    event.returnValue=false;
			    Submit2.disabled=false;
		    }
	    }

	    if(event.returnValue!=false){
		    if(confirm("Are you sure ?")==false){
			    event.returnValue=false;
			    Submit2.disabled=false;
		    }
		    else{
		        //var typeorder = document.getElementById("typeorder").value;
		        
		        //myWindow=window.open('RetrieveOrderViewExport.aspx?report_type='+typeorder ,'popup', 'toolbar=no, status=no, resizable=no, width=180, height=110, scrollbars=no, menu=no');
		        event.returnValue=true;
    			
			    }
	    }
    }
    catch(e){
    event.returnValue=false;
    ErrorLog(e,1);
    }
}

//-->
</script>

</head>
<body >

    <form id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>

        <input type="hidden" name="record_cnt" id="record_cnt" runat="server" />

    <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
 
<tr>
                <th height="28" colspan="151"><span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></th>
              </tr>
              <tr>
                <td height="23" colspan="151" class="row2">
                <input name="submit22" type="button" class="button" value="BACK" onClick="history.go(-1);" style="font-size:7pt" />
                          <input name="submit222" type="button" class="button" value="Select All" onClick="select_all();" style="font-size:7pt" />
                          <input name="submit223" type="button" class="button" value="Select None" onClick="select_none();" style="font-size:7pt" />
                          <asp:Button ID="submit2" Text="Export Selected to Excel" class="mainoption" style="font-size:7pt" OnClientClick="chk_save(this.form);" runat="server" PostBackUrl="~/Web/RetrieveMobileLiteExport.aspx" />
                          
                </td>
              </tr>

                <tr> 
                <td class="row1"></td>                
                 <td class="row1"><span class="explaintitle" style="font-size:7pt">&nbsp;</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Web Log id</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Create Date<br />(MM/DD/YYYY HH:MM)</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">EDF</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">MRT</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Gender</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Registered Customer Name </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Registered Customer ID </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Date of Birth </span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Registered address</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Billing address</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Monthly Payment Type</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Card number</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Card type</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Card holder name</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Card Expiry date</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">SIM card number</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">SIM Item Code</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Rateplan</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Tradefield</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Bundle Name</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Free Monthly Fee</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Total rebate amount</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">HS model</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">HS amount</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">HS rebate</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Status</span></td>
				<td class="row1"><span class="explaintitle" style="font-size:7pt">Fallout Main Category</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Fallout Reason</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Fallout Remark</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Fallout Reply</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Remarks to PY Operation</span></td>                
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Delivery Date (MM/DD/YYYY)</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">2N Service activation date</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">2N Company Name</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">2N Registered Name</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">2N HKID</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">2N Trasfer to 3G (YES/NO)</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">2N Transfer IDD deposit</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">2N Transfer IDD & roaming deposit</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">2N Transfer Non-HK ID holder deposit</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">2N Transfer no address proof deposit</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">2N Transfer others deposit</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">2N Service Ticket number</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">3rd Party</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Bank Account Holder Name</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Credit Card ID Type</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Credit Card number</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Credit Card type</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Credit Card expiry date</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Bill Medium</span></td>
                <td class="row1"><span class="explaintitle" style="font-size:7pt">Prepayment Waived</span></td> 
                <td class="row1"><span class="explaintitle" style="font-size:7pt">3rd Party Receive SIM</span></td>
                 <% VasHeaderShow(); %>
                 <td class="row1"><span class="explaintitle" style="font-size:7pt">Channel</span></td>
                 <td class="row1"><span class="explaintitle" style="font-size:7pt">Staff No</span></td>
                 <td class="row1"><span class="explaintitle" style="font-size:7pt">Salesman Code</span></td>
				</tr>

                <% SearchReportShow(); %>

               <tr>
                <td class="cat" colspan="151">&nbsp;</td>
              </tr>
            </table>
    
    </div>
    </form>
<table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; View 
<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
</table>       
                <table width="100%" border="0" cellspacing="2" cellpadding="2">
      <tr> 
        <td width="20%"><div align="center"></div></td>
        <td width="60%"><div align="center"></div></td>
        <td width="20%"><div align="center"></div></td>
      </tr>
      <tr> 
        <td width="20%"><div align="center"></div></td>
        <td width="60%"><div align="center"></div></td>
        <td width="20%"><div align="center"></div></td>
      </tr>
    </table>
</body>
</html>
