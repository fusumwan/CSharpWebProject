<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="false" CodeFile="CustomerAccountAdd.aspx.cs" Inherits="CustomerAccountAdd" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE" %>
<%@ Import Namespace="NEURON.ENTITY.FRAMEWORK" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<script type="text/javascript">

function chk_save(ThisForm){
	if(document.getElementById("form1").remarks.value==""){
		alert ("Please Enter Change Customer Details!");
		document.getElementById("form1").remarks.focus();
		event.returnValue=false;
		document.getElementById("form1").submit2.disabled=false;
	}

	if(event.returnValue!=false){
		if(confirm("Are you sure you want to Save?")==false){
			event.returnValue=false;
			document.getElementById("form1").submit2.disabled=false;
		}
		else{
		    document.getElementById("form1").action="CustomerAccountAddAction.aspx";
			ThisForm.submit();
	    }
	}
}

</script>
</head>
<body style="background-color:#ffffff">

    <form action="CustomerAccountAddAction.aspx" method="post" name="form1" id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
                  <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <th height="28" colspan="4">&nbsp;<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></th>
                </tr>
                <tr> 
                  <td height="23" colspan="4" class="row2"><input type="button" name="submit2" value="SAVE" class="mainoption"  onclick="chk_save(this.form);" onKeyDown="return false;" style="font-size:7pt"/> 
                    &nbsp;&nbsp; <input name="submit22" type="reset" class="button" value="RESET" /> 
                    &nbsp;&nbsp; <span class="explaintitle"> </span><span class="gensmall"> 
                    
                    </span></td>
                </tr>
                <tr> 
                  
                  <td width="21%" height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Account 
                    No 戶口號碼<br>
                    </span>
                    <input name="order_id" id="order_id" type="hidden" value='<%=Func.RQ(WebFunc.qsOrder_id) %>'/>
                    </td>
                  <td width="79%" height="0" class="row1"><span class="gensmall" style="font-size:7pt"><input id="ac_no" name="ac_no" type="hidden" runat="server" /><asp:Literal ID="ac_no_value" runat="server"></asp:Literal></span> 
                  </td>
                </tr>
                <tr> 
                  <td height="0" class="row2"><span class="explaintitle" style="font-size:7pt">MRT 
                    No 登記流動電話號碼<br>
                    </span></td>
                  <td height="0" class="row1"><span class="gensmall" style="font-size:7pt"><input id="mrt_no" name="mrt_no" type="hidden" runat="server" /><asp:Literal ID="mrt_no_value" runat="server"></asp:Literal></span> 
                  </td>
                </tr>
                <tr> 
                  <td width="23%" height="0" class="row2"><span class="explaintitle" style="font-size:7pt">Change 
                    Customer Details<br>
                    </span></td>
                  <td width="77%" height="0" colspan="3" class="row1"><textarea name="remarks" cols="50" rows="2" id="remarks" onBlur="chg_upper(this);"></textarea> 
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
<script type="text/javascript" src="/js/dopageunload.js" language="JavaScript"></script>
</html>
