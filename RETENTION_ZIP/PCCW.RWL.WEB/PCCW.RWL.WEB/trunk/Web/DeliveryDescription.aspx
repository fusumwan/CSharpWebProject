<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeliveryDescription.aspx.cs" Inherits="DeliveryDescription" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<head runat="server">
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>PLAN DETAILS</title>
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
</head>
<body>
<h5>Cascade/PowerLogistic Delivery Service Appointment Reference Table<br>
(Exclude Sunday & Public Holidays)</h5>
<table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
  <tr> 
    <td height="0" class="row3" colspan="2" align="center">Hong Kong (港島區)</td>
  </tr>
  <tr> 
    <td width="25%" height="0" class="row2"><span class="explaintitle" style="font-size:7pt">
    AM (10:00-13:00) or<br />
PM (14:00-16:00) or<br />
PM (16:00-18:00) or<br />
Evening (18:00-20:00)<br />
Evening (20:00-22:00)
    </span></td>
    <td width="75%" height="0" class="row1"> ADMIRALTY (金鐘),CAUSEWAY BAY (銅鑼灣),CENTRAL DISTRICT (中環),CHAI WAN (柴灣), KENNEDY TOWN (堅尼地城),NORTH POINT (北角),QUARRY BAY (則魚涌),
SAI WAN HO (西灣河), SAI WAN (西灣),SAI YING PUN (西營盤),SHAU KEI WAN (筲箕灣),
SHEK TONG TSUI (石塘咀),SHEUNG WAN (上環),SIU SAI WAN (小西灣),TAI HANG (大坑),
WAN CHAI (灣仔),WESTERN DISTRICT (香港西區)</td>
  </tr>
  <tr> 
    <td width="25%" height="22"  class="row2"><span class="explaintitle" style="font-size:7pt">
    AM (11:00-13:00) or <br />
PM (14:00-16:00) or<br />
PM (16:00-18:00) or<br />
Evening (18:00-20:00)<br />
Evening (20:00-22:00)
    
      </span></td>
    <td width="75%" height="22" class="row1">ABERDEEN (香港仔),AP LEI CHAU (鴨脷洲),BEL-AIR (貝沙灣),CHUNG HOM KOK (舂坎角),
HAPPY VALLEY (跑馬地),JARDINE'S LOOKOUT (渣甸山),MID-LEVELS (半山區),
MOUNT DAVIS (摩星嶺), PEAK (山頂),POK FU LAM (薄扶林),REPULSE BAY (淺水灣),
SHEK O (石澳),SHOUSON HILL (壽臣山),SO KON PO (掃桿埔), STANLEY (赤柱),
WAH FU (華富),WONG CHUK HANG (黃竹坑)</td>
  </tr>
  <tr> 
    <td height="0" class="row3" colspan="2" align="center">Kowloon (九龍區)</td>
  </tr>
  <tr> 
    <td width="25%" height="22"  class="row2"><span class="explaintitle" style="font-size:7pt">
    AM (10:00-13:00) or <br />
PM (14:00-16:00) or<br />
PM (16:00-18:00) or<br />
Evening (18:00-20:00)<br />
Evening (20:00-22:00)
    
    </span></td>
    <td width="75%" height="22" class="row1">BEACON HILL (筆架山),CHEUNG SHA WAN (長沙灣),CHOI HUNG (彩虹),
DIAMOND HILL (鑽石山),HO MAN TIN (何文田),HUNG HOM (紅磡),JORDAN (佐敦),
KING'S PARK (京士柏),KOWLOON BAY (九龍灣),KOWLOON CITY (九龍城),
KOWLOON TONG (九龍塘),KWUN TONG (觀塘),LAI CHI KOK (荔枝角),LAM TIN (藍田),
LEI YUE MUN (鯉魚門),MA TAU KOK (馬頭角),MA TAU WAI (馬頭圍),MONG KOK (旺角),
NGAU CHI WAN (牛池灣),NGAU TAU KOK (牛頭角),PRINCE EDWARD (太子),
SAN PO KONG (新蒲崗),SAU MAU PING (秀茂坪),SHAM SHUI PO (深水步),
SHEK KIP MEI (石硤尾),TAI KOK TSUI (大角咀),TAI WO PING (大窩坪),
TIU KENG LENG (調景嶺),TO KWA WAN (土瓜灣),TSIM SHA TSUI (尖沙咀),
TSZ WAN SHAN (慈雲山),WANG TAU HOM (橫頭磡),WONG TAI SIN (黃大仙),
YAU MA TEI (油麻地),YAU TONG (油塘),YAU YAT CHUEN (又一村)</td>
  </tr>
  <tr> 
    <td width="25%" height="22" class="row2"><span class="explaintitle" style="font-size:7pt">
    
    AM (11:00-13:00) or <br />
PM (14:00-16:00) or <br />
PM (16:00-18:00) or <br />
Evening (18:00-20:00) <br />
Evening (20:00-22:00)
    
      </span></td>
    <td width="75%" height="22" class="row1">CHA KWO LING (茶果嶺),CLEAR WATER BAY (清水灣),FEI NGO SHAN (飛鵝山),
MA YAU TONG (馬游塘),SAI KUNG (西貢), TSEUNG KWAN O (將軍澳)</td>
  </tr>
  <tr> 
    <td height="0" class="row3" colspan="2" align="center">New Territories (新界區)</td>
  </tr>
  <tr> 
    <td width="23%" height="22"  class="row2"><span class="explaintitle" style="font-size:7pt">
    
    AM (11:00-13:00) or <br />
PM (14:00-16:00) or <br />
PM (16:00-18:00) or <br />
Evening (18:00-20:00) <br />
Evening (20:00-22:00)
    </span></td>
    <td width="77%" height="22" class="row1">FO TAN (火炭),KWAI CHUNG (葵涌),KWAI FONG (葵芳),LAI KING (荔景),SHA TIN (沙田),
SHAM TSENG (深井),SIU LEK YUEN (小瀝源),TAI WAI (大圍),TSING YI (青衣),
TSUEN WAN (荃灣),TUEN MUN (屯門),YUEN CHAU KOK (圓洲角)</td>
  </tr>
  <tr> 
    <td width="23%"  class="row2"><span class="explaintitle" style="font-size:7pt">
    
    
    AM (11:00-13:00) or <br />
PM (14:00-16:00) or<br />
PM (16:00-18:00) or<br />
Evening (18:00-20:00)<br />
Evening (20:00-22:00)<br />
* Ma Wan delivery schedule upto 20:00 only
    
      </span></td>
    <td height="24" class="row1"> AIRPORT (機場),CHEK LAP KOK (赤鱲角),FAIRVIEW PARK (錦綉花園),FANLING (粉嶺),
KAM TIN (錦田),LAU FAU SHAN (流浮山),LUK KENG (鹿頸),LUNG YEUK TAU (龍躍頭),
MA MEI HA (馬尾下),MA ON SHAN (馬鞍山),MA WAN (馬灣)*,PENNY'S BAY (竹篙灣),
PING SHAN (屏山),SHA TAU KOK Non-restricted area (沙頭角非禁區),SHEK KONG (石崗),SHEUNG SHUI (上水),
TA KWU LING (打鼓嶺),TAI PO (大埔),TAI PO LAM CHUEN (大埔林村),TIN SHUI WAI (天水圍),
TSING LUNG TAU (青龍頭),TUNG CHUNG (東涌),WU KAU TANG (烏蛟騰),YUEN LONG (元朗), YUEN LONG PAT HEUNG (元朗八鄉),YUEN LONG SAN TIN (元朗新田)
<br> <!--<span class="style1">[NOTICE : 送貨往 "*" 的地區，須收取送貨費 - 港幣 $100 元正]</span>--></td>
  </tr>
  <tr> 
    <td height="0" class="row3" colspan="2" align="center">LT - OUTLYING ISLAND (離島區)</td>
  </tr>
  <tr> 
    <td width="23%"  class="row2"><span class="explaintitle" style="font-size:7pt">
    
    [PM ONLY] <br />
PM (14:00-18:00)<br />
PM (16:00-20:00)
    
      </span></td>
    <td height="24" class="row1"> CHEUNG CHAU (長洲),PENG CHAU (坪洲),DISCOVERY BAY (愉景灣),LANTAU ISLAND (大嶼山),
LAMMA ISLAND (南丫島),MUI WO (梅窩), PUI O (貝澳),SILVER MINE BAY (銀礦灣),
TAI O (大澳)….<br>
<!--<span class="style1">[NOTICE : 所有送貨往離島區域，須要收取送貨費 - 港幣 $250 元正] </span>--></td>
  </tr>
</table>
<br>
<table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
  <tr> 
    <td height="0" class="row3" colspan="3" align="center">Delivery Charge</td>
  </tr>
<!--   <tr> 
    <td width="25%" height="22"  class="row2">&nbsp;</td>
    <td width="37%" height="22" class="row1">Under $500</td>
    <td width="38%" height="22" class="row1">$500 or above</td>
  </tr>
 -->  <tr> 
    <td width="25%"  class="row2"><span class="explaintitle" style="font-size:7pt">HK Island (港島區)/ Kowloon (九龍區)/ New Territories (新界區)/OUTLYING ISLAND (離島)</span></td>
    <td height="24" class="row1">$0</td>
<!--     <td height="24" class="row1">$0 </td>
 -->  </tr>
  <!--<tr> 
    <td width="25%"  class="row2"><span class="explaintitle" style="font-size:7pt">AIRPORT (機場),
CHEK LAP KOK (赤鱲角),
MA WAN (馬灣),
PENNY'S BAY (竹篙灣),
TUNG CHUNG (東涌)</span></td>
    <td height="24" class="row1">$100 </td>-->
<!--     <td height="24" class="row1">$0 </td>
 -->  </tr>
  <!--<tr> 
    <td width="25%"  class="row2"><span class="explaintitle" style="font-size:7pt">OUTLYING ISLAND (離島)</span></td>
    <td height="24" class="row1">$250</td>
<!--     <td height="24" class="row1">$250 </td>
   </tr>-->
</table>
<br>
<input name="button" type="button" onClick="window.close()" value="CLOSE" class="button" style="font-size:7pt"></div>
</body>
</html>

