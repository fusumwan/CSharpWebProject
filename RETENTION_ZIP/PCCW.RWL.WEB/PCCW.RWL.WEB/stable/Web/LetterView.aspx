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
                  <td height="23" colspan="4" class="row2"> <p><span class="gensmall" style="font-size:9pt">�p��Ȥ�W�椺�w������, 
                    �P�ƽгq���Ȥ�i�����촫�⤤�߿˨��X�ܨ���������§�~�Ӥ𶷴���H.<br />
                    (�u���o�H��_��Ӥ�+��P������i�@���w��) </span></p>
                    <p>V-logic ���⤤��:</p>
                    <p>���r�Wù����2-4��2000�~�s��19�� (���r�W�a�K��A�X�f �V �ɥN�s���ﭱ) <br />
                      �줽�ɶ� :</br>
                      <br />
                      �P���@�ܤ�*: �W��11�ɦܱߤW8��</br>
                      <br />
                      �P����: �U��1�ɦܤU��6��</br>
                      <br />
                      ��������: ��</br>
                      <br />
                      �Ȥ�d��:     2112 9922</br>
</p>
                    <p><br>
                      <span class="gensmall" style="font-size:9pt">�y�F�C�[����D20���[����s��13��1301�Ǧ�02�� (�y�F�C�a�K��B2�X�f�ΪF�K��N2�X�f) </span></br>
                      <br>
                      �줽�ɶ� :</br>
                      <br>
                      �P���@�ܤ�*: �W��11�ɦܱߤW8��</br>
                      <br>
                      �P����Τ�������: ��</br>
                      <br>
                      �Ȥ�d��:     2112 9922</br>
                    </p>
                    <p>Cascade ���⤤�� :
                    <p>�����W�J�a���ֹD3���d�J�q�ܾ���8 �� (�q�����߸U�~�s�ӹj�� / �q�����W�J�l���j��)<br />
                      �줽�ɶ� :</br>
  <br />
                      �P���@�ܤ�: �W�ȤQ�ɦܤC��</br>
  <br />
                      �P����: �U�ȤG�ɦܤC�� </br>
  <br />
                       �P����Τ�������: ��</br>
                      <br />
                     �Ȥ�d��: 28883115</br>
                    </p>
                    <p><br />
                        <span class="gensmall" style="font-size:9pt">�E�s�����]��37�������q�ܾ���9��(�Ӥl�p�X�s���׹ﭱ / �Ӥl�l�Ф��߹ﭱ / �����]��l���j��)</span></br>
                        <br />
                      �줽�ɶ� :</br>
  <br />
                      �P���@�ܤ�: �W�ȤQ�ɦܤC��</br>
  <br />
                     �P����: �U�ȤG�ɦܤC�� </br>
  <br />
                      �P����: �U�Ȥ@�ɦܤ���</br>
  <br />
                     ��������:�� </br>
  <br />
                      �Ȥ�d��: 2888 3115</br>
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
