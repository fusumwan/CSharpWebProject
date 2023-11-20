<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeFile="ChangeVasView.aspx.cs" Inherits="ChangeVasView" %>
<%@ Register TagName="RWLMenu2" TagPrefix="RWLMenu2" Src="~/UI/RWLControlMenu.ascx"  %>
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
<style>
.highlightrow{background:#FFFFbb}
.disablerow{background:#DDDDDD}
input{font:7pt Verdana,Arial,Helvetica,sans-serif}
select{background:#ffffff;font:7pt Verdana,Arial,Helvetica,sans-serif}
.explaintitle{font-size:7pt;font-weight:bold;color:#5c81b1}
</style>
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<script type="text/javascript">
function chk_save(ThisForm){
document.getElementById("form1").submit2.disabled=true;
	if(event.returnValue!=false){
		if(confirm("Are you sure you want to Save?")==false){
			event.returnValue=false;
			document.getElementById("form1").submit2.disabled=false;
		}
		else{
			document.getElementById("form1").submit2.disabled=true;
			document.getElementById("form1").action="ChangeVasAction.aspx";
			for(i=0;i<document.getElementById('form1').elements.length;i++){
                document.getElementById('form1').elements[i].disabled=false;
            }
			ThisForm.submit();
		}
	}
}

</script>
</head>
<body>

<% GenJavascript(); %>
    <form id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
    		  <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
			<tr> 
			  <th height="28" colspan="4">&nbsp;<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span> (Order 
				ID: <asp:Literal ID="order_id_text" runat="server"></asp:Literal> )</th>
			</tr>
			<tr>
			<td height="23" colspan="4" class="row2">
			   <asp:Button ID="BACK" Text="BACK" PostBackUrl="~/Web/MobileRetentionMain.aspx" CssClass="button" runat="server" />
			</td>
			
			</tr>
			<tr> 
			  <td height="23" colspan="4" class="row2"> <input id="order_id" type="hidden" name="order_id" runat="server" />
			  <input type="button" name="submit2" value="SAVE" class="mainoption"  onclick="chk_save(this.form);" onKeyDown="return false;" />


			  <br />
				
			<asp:Literal ID="falloutreply" runat="server" Text='Fallout Reply'></asp:Literal>
				<input name="<%=WebFunc.qsFallout_replyName %>" type="text" id="fallout_reply"  size="100" maxlength="250" onBlur="chg_upper(this);" runat="server"/>	
					  </td>
					</tr>
					<tr> 
					  <td width="27%" height="0" class="row2"><span class="explaintitle" >MRT 
						No 登記流動電話號碼</span></td>
					  <td width="73%" height="0" colspan="3" class="row1"> <span class="gensmall" style="font-size:7pt"><asp:Literal ID="mrt_no" runat="server"></asp:Literal></span> 
					  </td>
					</tr>
					<tr> 
					  <td height="0" class="row2"><span class="explaintitle" >Program 
						計劃 </span></td>
					  <td height="0" class="row1" colspan="3"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="program" runat="server"></asp:Literal> </span> 
					  </td>
					</tr>
					<tr> 
					  <td width="16%" height="0" class="row2" ><span class="explaintitle" >Rate 
						Plan</span></td>
					  <td class="row1"  colspan="3"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="rate_plan" runat="server"></asp:Literal></span> 
						<span class="gensmall" style="font-size:7pt"> - 
						<asp:Literal ID="normal_rebate_type" runat="server"></asp:Literal>
						</span></td>
					</tr>
					<tr> 
					  <td height="27"  class="row2"><span class="explaintitle" >Contract 
						Period 合約期</span></td>
					  <td class="row1" colspan="3"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="con_per" runat="server"></asp:Literal></span> 
					  </td>
					</tr>
					<tr> 
					  <td height="27"  class="row2"><span class="explaintitle" >Rebate</span></td>
					  <td class="row1" colspan="3"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="rebate" runat="server"></asp:Literal></span> 
					  </td>
					</tr>
					<tr> 
					  <td height="27"  class="row2"><span class="explaintitle" >Free 
						Monthly Fee 免費月份費用<br />
						</span></td>
					  <td class="row1" colspan="3"><span class="gensmall" style="font-size:7pt"><asp:Literal ID="free_mon" runat="server"></asp:Literal></span> 
					  </td>
					</tr>
					<asp:PlaceHolder ID="vas_placeholder" runat="server"></asp:PlaceHolder>
					<tr> 
					  <td class="cat" colspan="4">&nbsp;</td>
					</tr>
				  </table>
    </div>
    </form>
    
    
    <table id="show_mod_flag_tbl" width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline" runat="server">
			<tr> 
			  <th height="28" colspan="4"></th>
			</tr>
			<tr> 
			<td height="100" colspan="4" class="row1" align="center"> 
			<asp:PlaceHolder ID="show_mod_flag_placeholder" runat="server"></asp:PlaceHolder>
					</td>
			</tr>
			<tr> 
			  <td class="cat" colspan="4"></td>
			</tr>
		 </table>
		 
		 
		 <table runat="server" id="notfound" width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
			<tr> 
			  <th height="28" colspan="4"></th>
			</tr>
			<tr> 
			    <td height="100" colspan="4" class="row1" align="center"> <span class="gensmall">
                  <input name="submit223" type="button" class="button" value="BACK" onClick="history.go(-1);" style="font-size:7pt" />
                  </span> <br />
                  Record NOT found!</td>
			</tr>
			<tr> 
			  <td class="cat" colspan="4"></td>
			</tr>
		 </table>
		 
		 
<table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; View 
<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
</table>       
</body>
</html>
