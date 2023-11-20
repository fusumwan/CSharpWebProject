<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReleaseOrder.aspx.cs" Inherits="ReleaseOrder" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
<script type="text/javascript">
function isNum(tobj){
	if (tobj.value!=""){
		if(tobj.value.match(/^\d{6}$/)==null){
			alert ("Invalid Order ID!");
			tobj.value = "";
			tobj.select();
			return false;
		}
	}
}

function chk_save(ThisForm){
	if(document.getElementById("form1").order_id.value=="" ){
		alert ("Please Enter Order ID!");
		document.getElementById("form1").order_id.focus();
		event.returnValue=false;
		document.getElementById("form1").submit2.disabled=false;
	}
	
	if(event.returnValue!=false){
		if(confirm("Are you sure you want to Save?")==false){
			event.returnValue=false;
			document.getElementById("form1").submit2.disabled=false;
		}
		else{
		
			document.getElementById("form1").submit2.disabled=true;
			document.getElementById("form1").action="ReleaseOrderAction.aspx";
			ThisForm.submit()
		}
	}
}

</script>
</head>
<body style="background-color:#ffffff">

    <form id="form1" action="" method="post" name="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
 
              <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <th height="28" colspan="4">&nbsp;<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></th>
                </tr>
                <tr> 
                  <td height="23" colspan="4" class="row2"> <input type="button" name="submit2" value="RELEASE" class="mainoption" onKeyDown="return false;" onClick="chk_save(this.form);"style="font-size:7pt"/> 
                    <span class="explaintitle"> </span><span class="gensmall"> 
                    </span></td>
                </tr>
                <tr> 
                  <td width="23%" height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Record ID</span></td>
                  <td width="77%" height="0" class="row1"> <input name="order_id" type="text" id="order_id" style="font-size:7pt" size="8" maxlength="6" onBlur="isNum(this)"/>
                  </td>
                </tr>
                <tr> 
                  <td class="cat" colspan="2">&nbsp;</td>
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

</body>
</html>
