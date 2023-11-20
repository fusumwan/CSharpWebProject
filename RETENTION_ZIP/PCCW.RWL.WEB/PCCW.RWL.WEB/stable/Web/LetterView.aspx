<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LetterView.aspx.cs" Inherits="LetterView" %>
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

function chk_save(ThisForm){
	if(document.getElementById('form1').mrt_no.value==""){
		alert ("Please Enter MRT No!");
		document.getElementById('form1').mrt_no.focus();
		event.returnValue=false;
		document.getElementById('form1').submit2.disabled=false;
	}

	document.getElementById('form1').action="LetterViewAction.aspx";

	if(event.returnValue!=false)
		ThisForm.submit()
}

</script>

</head>
<body style="background-color:#ffffff">

    <form id="form1" action="LetterViewAction.aspx" method="post" name="newform" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
              <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <th height="28" colspan="4">&nbsp;<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></th>
                </tr>
				</tr>
   <tr> 
                  <td height="23" colspan="4" class="row2"> 
                  <asp:Button ID="BACK" Text="BACK" runat="server" CssClass="mainotion" PostBackUrl="~/Web/MobileRetentionMain.aspx" Font-Size="7pt" /> 
                    <span class="explaintitle"> </span><span class="gensmall"> 
                    </span></td>
                </tr>
                <tr> 
                  <td height="23" colspan="4" class="row2"> <p><span class="gensmall" style="font-size:9pt">如於客戶名單內已有紀錄, 
                    同事請通知客戶可直接到換領中心親身出示身份証換領禮品而毋須換領信.<br />
                    (只限發信日起兩個月+兩星期內方可作此安排) </span></p>
                    <p>V-logic 換領中心:</p>
                    <p>銅鑼灣羅素街2-4號2000年廣場19樓 (銅鑼灣地鐵站A出口 – 時代廣場對面) <br />
                      辦公時間 :</br>
                      <br />
                      星期一至六*: 上午11時至晚上8時</br>
                      <br />
                      星期日: 下午1時至下午6時</br>
                      <br />
                      公眾假期: 休息</br>
                      <br />
                      客戶查詢:     2112 9922</br>
</p>
                    <p><br>
                      <span class="gensmall" style="font-size:9pt">尖沙咀加拿芬道20號加拿芬廣場13樓1301室至02室 (尖沙咀地鐵站B2出口或東鐵站N2出口) </span></br>
                      <br>
                      辦公時間 :</br>
                      <br>
                      星期一至六*: 上午11時至晚上8時</br>
                      <br>
                      星期日及公眾假期: 休息</br>
                      <br>
                      客戶查詢:     2112 9922</br>
                    </p>
                    <p>Cascade 換領中心 :
                    <p>香港灣仔軒尼詩道3號駱克電話機樓8 樓 (電車路喜萬年酒樓隔離 / 電車路灣仔郵局隔離)<br />
                      辦公時間 :</br>
  <br />
                      星期一至五: 上午十時至七時</br>
  <br />
                      星期六: 下午二時至七時 </br>
  <br />
                       星期日及公眾假期: 休息</br>
                      <br />
                     客戶查詢: 28883115</br>
                    </p>
                    <p><br />
                        <span class="gensmall" style="font-size:9pt">九龍旺角弼街37號旺角電話機樓9樓(太子聯合廣場斜對面 / 太子始創中心對面 / 旺角弼街郵局隔離)</span></br>
                        <br />
                      辦公時間 :</br>
  <br />
                      星期一至五: 上午十時至七時</br>
  <br />
                     星期六: 下午二時至七時 </br>
  <br />
                      星期日: 下午一時至六時</br>
  <br />
                     公眾假期:休息 </br>
  <br />
                      客戶查詢: 2888 3115</br>
                    </p></td>
                </tr>
				
				
                <tr> 
                  <td height="23" colspan="4" class="row2"> <input type="button" name="submit2" value="SEARCH" class="mainoption"  onclick="chk_save(this.form);" onKeyDown="return false;" style="font-size:7pt"/> 
                    <span class="explaintitle"> </span><span class="gensmall"> 
                    </span></td>
                </tr>
                <tr> 
                  <td width="23%" height="0" class="row2"><span class="explaintitle" style="font-size:7pt">MRT</span></td>
                  <td width="77%" height="0" class="row1"> <input name="mrt_no" type="text" id="mrt_no" style="font-size:7pt" size="10" maxlength="8" onBlur="chk_telno(this);"/>
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
<script type="text/javascript" src="/js/dopageunload.js" language="JavaScript"></script>
</body>
</html>
