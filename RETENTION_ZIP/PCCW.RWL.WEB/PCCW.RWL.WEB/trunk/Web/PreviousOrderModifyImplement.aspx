<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PreviousOrderModifyImplement.aspx.cs" Inherits="PreviousOrderModifyImplement" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Register TagPrefix="RWLviewrow" TagName="RWLviewrow" Src="~/UI/RecordOrderViewRow.ascx" %> 
<%@ Import Namespace="PCCW.RWL.CORE" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<%@ Import Namespace="NEURON.ENTITY.FRAMEWORK" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Style-Type" content="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=big5" />
<title>3G Retention - Web Log</title>
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>


</head>
<body style="background-color:#ffffff">
    <form id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>

              <table id="incorrect" width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline" runat="server">
              <tr> 
                <th width="100%" height="28">&nbsp;<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></th>
              </tr>
              <tr> 
                <td height="23" class="row2" align="center" ><span class="explaintitle">Plan 
                  Code / Contract Period / Trade Field / Bundle Name Incorrect!<br>
                  </span><span class="gensmall"> 
                  <input type="button" name="submit22" value="Back to Modify" class="mainoption" onClick="location.href='PreviousOrderModify.aspx?order_id=<%=WebFunc.qsOrder_id%>';this.disabled=false"/>
                  </span> </td>
              </tr>
              </table>

              <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">

                
                <tr> 
                  <td colspan="4" height="23" class="row2"><span class="explaintitle"> 
                    <input name="submit222" type="button" class="button" value="BACK To Search" onClick="location.href='SearchRetentionOrderView.aspx'" style="font-size:7pt" />
                    </span></td>
                </tr>
                <RWLviewrow:RWLviewrow ID="RWLviewrow1" runat="server" Visible="false" />
                
                                <tr> 
                  <td colspan="4" class="cat">&nbsp;</td>
                </tr>
              </table>

             
              <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline" runat="server">
              <tr> 
                <td class="cat">&nbsp;</td>
              </tr>
            </table>
             
    </div>
    </form>
</body>
</html>
