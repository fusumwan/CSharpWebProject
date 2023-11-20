<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Test.aspx.cs" Inherits="Web_Test" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
	
	
	
	
	
	
	
	
<style> .select-free { position:absolute; z-index:10;/*any value*/ overflow:hidden;/*must have*/ width:33em;/*must have for any value*/; } .select-free iframe { display:none;/*sorry for IE5*/ display/**/:block;/*sorry for IE5*/ position:absolute;/*must have*/ top:0;/*must have*/ left:0;/*must have*/ z-index:-1;/*must have*/ filter:mask();/*must have*/ width:3000px;/*must have for any big value*/ height:3000px/*must have for any big value*/; } .select-free .bd{border:solid 1px #aaaaaa;padding:12px;} </style> 

<script>
function Testing(){
	jAlert("Testing!");
}
</script>

</HEAD>
<BODY>

<input type="button" onclick="Testing()" value="Testing">
<div class="select-free" id="dd3"><div class="bd"> 

<select>
<option value="1">1</option>
<option value="2">2</option>
</select>
</div><!--[if lte IE 6.5]><iframe>


</iframe><![endif]--></div>
</BODY>
</html>
