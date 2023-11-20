<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminViewHistoryImplement.aspx.cs" Inherits="AdminViewHistoryImplement" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
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
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<script type="text/javascript">
<!--
function close_win(){
//	return window.location="/cccl/cccl_main.asp";
	return top.location="../chk_login.asp"
}
//-->
</script>

</head>
<body>
    <form id="form1" runat="server">
    <div>

    <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
  <tr> 
    <th height="28" colspan="100"> Status History (<%=Func.IDAdd100000(WebFunc.qsOrder_id)%>)</th>
  </tr>
  <tr> 
    <td height="23" colspan="100" class="row2">&nbsp; </td>
  </tr>
  <tr> 
    <td class="row1">&nbsp;</td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Status ID</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Sent Date<br />
      (MM/DD/YYYY)</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Report Name</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Order Status</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Reason</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Remark</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Reply</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Retrieve SN</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Retrieve 
      Date<br>(MM/DD/YYYY HH:MM)</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Created by</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Create Date<br>(MM/DD/YYYY HH:MM)</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Deleted by</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Delete Date<br>(MM/DD/YYYY HH:MM)</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Re-send To PY by</span></td>
    <td class="row1"><span class="explaintitle" style="font-size:7pt">Re-send To PY Date<br>(MM/DD/YYYY HH:MM)</span></td>
  </tr>

   <tr> 
    <td height="23" colspan="100" class="row3"><span class="explaintitle" style="font-size:7pt">Current Status</span></td>
  </tr>
    <EW:RepeaterEx ID="admin_view_rp1" runat="server" >
    <ItemTemplate>
    <tr>
    <td nowrap class="row2"><span  style="font-size:7pt"><asp:Literal ID="viewid" runat="server"></asp:Literal></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "mid")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "email_date")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><asp:Literal ID="report_type" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "report_type")%>'></asp:Literal></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "order_status")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "fallout_reason")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "fallout_remark")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "fallout_reply")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "retrieve_sn")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "retrieve_date")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "cid")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "cdate")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "did")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "ddate")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "reactive_sn")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "reactive_date")%></span></td>
    </tr>
    </ItemTemplate>
    </EW:RepeaterEx>
    
   <tr> 
    <td height="23" colspan="100" class="row3"><span class="explaintitle" style="font-size:7pt">Status History</span></td>
  </tr>
    <EW:RepeaterEx ID="admin_view_rp2" runat="server" 
            onitemdatabound="admin_view_rp2_ItemDataBound">
    <ItemTemplate>
    <tr>
    <td nowrap class="row2"><span  style="font-size:7pt"><asp:Literal ID="viewid" runat="server"></asp:Literal></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "rec_no")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "email_date")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><asp:Literal ID="report_type" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "report_type")%>'></asp:Literal></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "order_status")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "fallout_reason")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "fallout_remark")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "fallout_reply")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "retrieve_sn")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "retrieve_date")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "cid")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "cdate")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "did")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "ddate")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "reactive_sn")%></span></td>
    <td nowrap class="row2"><span  style="font-size:7pt"><%# DataBinder.Eval(Container.DataItem, "reactive_date")%></span></td>
    </tr>
    </ItemTemplate>
    </EW:RepeaterEx>
  <tr> 
    <td class="cat" colspan="100">&nbsp;</td>
  </tr>
</table>
<br>
  <input name="button" type="button" onClick="window.close()" value="CLOSE" class="button" style="font-size:7pt">
    </div>
    </form>
</body>
</html>
