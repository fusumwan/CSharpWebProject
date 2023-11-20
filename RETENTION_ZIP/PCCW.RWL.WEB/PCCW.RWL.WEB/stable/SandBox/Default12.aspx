<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/RWLMenu.master" AutoEventWireup="true" CodeFile="Default12.aspx.cs" Inherits="SandBox_Default12" %>

<asp:Content ID="Content1" ContentPlaceHolderID="RWLHeaderContentPlace" Runat="Server">

     <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<meta http-equiv="Content-Style-Type" content="text/css" />
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />

<style type="text/css">
<!--
.row_red {background:#FFCC99}
.row_yellow {background:#FFFFbb}
-->
</style>

<asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>

<script type="text/javascript">
<!--
    function none() {
        event.returnValue = false;
    }

    function close_win() {
        //return window.location = "~/Board.aspxx"
        return top.location ="~/Logout.aspx"
    }
//-->
</script>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="RWLContentPlace" Runat="Server">


</asp:Content>

