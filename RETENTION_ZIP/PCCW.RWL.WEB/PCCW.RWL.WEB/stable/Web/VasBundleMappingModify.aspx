<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VasBundleMappingModify.aspx.cs" Inherits="VasBundleMappingModify" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
<script type="text/javascript" src="../Resources/Scripts/calendarDateInput.js"></script>
<script type="text/javascript" src="../Resources/Scripts/creditcard.js"></script>
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<script type="text/javascript" language="JavaScript">
function add_save123(i){
		//alert("kkk")
	if(event.returnValue!=false){
		if(confirm("Are you sure you want to ADD NEW This VAS?")==false){
			event.returnValue=false;
				}
			else{
		document.getElementById('form1').add_save.disabled=true;
		document.getElementById('form1').action="VasAddRelationMappingImplement.aspx?id="+i+"&kkk=kkk";
		document.getElementById('form1').submit();
			}
		}
	}
//===================================================================================================


function add_mod123(i){
	if(event.returnValue!=false){
		if(confirm("Are you sure you want to UPDATE This VAS?")==false){
			event.returnValue=false;
				}
			else{
		document.getElementById('form1').add_mod.disabled=true;
		document.getElementById('form1').action="VasAddRelationMappingImplement.aspx?id="+i+"&modflag=1";
		document.getElementById('form1').submit()}
		}
	}


function chk_date(dtobj,chkempty,gtToday){
	var today = new Date()
	if(dtobj.value != "" || chkempty==1) {
		if(dtobj.value.match(/^\d{8}$/)==null) {
		}
		else {
			txt=dtobj.value.substring(0,2)+"/"+dtobj.value.substring(2,4)+"/"+dtobj.value.substring(4,8)
			dtobj.value=txt
		}
		dt="";
	//	if(today.getMonth()+1<10)
	//		dt="0"

		dt+=today.getDate();
		dt+="/"
		dt+=today.getMonth()+1;
		dt+="/";
		dt+=today.getYear();

		//alert (dt);
		var datePat = /^(\d{1,2})(\/|-)(\d{1,2})\2(\d{2}|\d{4})$/;
		var matchArray = dtobj.value.match(datePat); // is the format ok?
		if (matchArray == null) {
			alert("Date is not in a valid format.")
			
			if (gtToday!=2)
				dtobj.value=dt;
			else
				dtobj.value="";
				
			return false;
		}
		month = matchArray[3]; // parse date into variables
		day = matchArray[1];
		year = matchArray[4];
		if (month < 1 || month > 12) { // check month range
			alert("Month must be between 1 and 12.");
			dtobj.value=dt;
			return false;
		}
		if (day < 1 || day > 31) {
			alert("Day must be between 1 and 31.");
			dtobj.value=dt;
			return false;
		}
		if ((month==4 || month==6 || month==9 || month==11) && day==31) {
			alert("Month "+month+" doesn't have 31 days!")
			dtobj.value=dt;
			return false
		}
		if (month == 2) { // check for february 29th
			var isleap = (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
			if (day>29 || (day==29 && !isleap)) {
				alert("February " + year + " doesn't have " + day + " days!");
				dtobj.value=dt;
				return false;
			}
		}
		var today = new Date()
		var myDate = new Date()

		myDate.setFullYear(year,month-1,day) 
		
		if (gtToday==1){
			if (myDate<today){
				alert ("Input Date should greater than Today!")
				dtobj.value=dt;
				return false;
			}
		}

		if (gtToday==2){
			if (myDate>=today){
				alert ("Input Date should smaller than Today!")
				dtobj.value="";
				return false;
			}
		}
		return true;
	}
}

</script>

</head>
<body>
    <form id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
    <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
        <tr>
          <th height="28"width="100%"> <span class="explaintitle" style="font-size:8pt">VAS CONTROL</span></th>
        </tr>	
	    <tr>
	        <td>
            <asp:GridView ID="vas_gp" runat="server" AllowSorting="True" Width="100%" 
                BorderWidth="1px" BorderColor="Black" CssClass="table-report" 
                AutoGenerateColumns="False" DataKeyNames="id" 
                DataSourceID="vas_source" 
                ondatabound="vas_gp_DataBound" onrowdatabound="vas_gp_RowDataBound">
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:TemplateField>
                    <HeaderTemplate>
                    <asp:Button Text="BACK" CssClass="mainoption" PostBackUrl="~/Web/VasView.aspx" runat="server" />
                    </HeaderTemplate>
                    <ItemTemplate>
                    
                    </ItemTemplate>
                    </asp:TemplateField>

                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                        ReadOnly="True" SortExpression="id" Visible="false" />
                    
                    <asp:TemplateField HeaderText="program">
                    <ItemTemplate>
                    <asp:Literal ID="program" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"program") %>'></asp:Literal>
                    </ItemTemplate>
                    <EditItemTemplate>
                    <asp:DropDownList ID="program" runat="server" DataSource='<%# ProgramBind() %>' AppendDataBoundItems="true" DataTextField="program" DataValueField="program" SelectedValue='<%# Bind(Container.DataItem,"program") %>'></asp:DropDownList>
                    </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="normal rebate type">
                    <ItemTemplate>
                    <asp:Literal ID="normal_rebate_type" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"normal_rebate_type") %>'  Visible="true"></asp:Literal>
                    </ItemTemplate>
                    <EditItemTemplate>
                    <asp:DropDownList ID="normal_rebate_type" AppendDataBoundItems="true" 
                            runat="server" Font-Size="8pt" DataTextField="normal_rebate_type" 
                            DataValueField="normal_rebate_type" 
                            SelectedValue='<%# Bind(Container.DataItem,"normal_rebate_type") %>' 
                            oninit="normal_rebate_type_Init" >
  
                  </asp:DropDownList>
                    </EditItemTemplate>
                    </asp:TemplateField>
                    
                    
                    <asp:TemplateField HeaderText="Issue type">
                    <ItemTemplate>
                    <asp:Literal ID="issue_type" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"issue_type") %>'  Visible="true"></asp:Literal>
                    </ItemTemplate>
                    <EditItemTemplate>
                    <asp:DropDownList ID="issue_type" AppendDataBoundItems="true" 
                            runat="server" Font-Size="8pt" DataTextField="issue_type" 
                            DataValueField="issue_type" 
                            SelectedValue='<%# Bind(Container.DataItem,"issue_type") %>' 
                            oninit="issue_type_Init"  >
  
                  </asp:DropDownList>
                    </EditItemTemplate>
                    </asp:TemplateField>
                    
                    <asp:BoundField DataField="rate_plan" HeaderText="rate plan"  SortExpression="rate_plan" />
                    <asp:BoundField DataField="bundle_name" HeaderText="bundle name" SortExpression="bundle_name" />

                    <asp:TemplateField HeaderText="hs model">
                    <ItemTemplate>
                    <asp:Literal ID="hs_model" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"hs_model") %>'  Visible="true"></asp:Literal>
                    </ItemTemplate>
                    <EditItemTemplate>
                    <asp:DropDownList ID="hs_model" AppendDataBoundItems="true" 
                            runat="server" Font-Size="8pt" DataTextField="hs_model" 
                            DataValueField="hs_model" DataSource='<%# DrpHsmodel() %>' 
                            SelectedValue='<%# Bind(Container.DataItem,"hs_model") %>' >
                  </asp:DropDownList>
                    </EditItemTemplate>
                    </asp:TemplateField>
                    
                    
                    <asp:TemplateField HeaderText="vas_field">
                    <ItemTemplate>
                    <asp:Literal ID="vas_field" Text='<%# DataBinder.Eval(Container.DataItem,"vas_field") %>' runat="server"></asp:Literal>
                    </ItemTemplate>
                    <EditItemTemplate>
                    <asp:DropDownList ID="vas_field" runat="server" DataSource='<%# VasFieldBind() %>' AppendDataBoundItems="true" DataTextField="vas_name" DataValueField="vas_field" SelectedValue='<%# Bind(Container.DataItem,"vas_field") %>'></asp:DropDownList>
                    </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="sdate" HeaderText="sdate" SortExpression="sdate" />
                    <asp:BoundField DataField="edate" HeaderText="edate" SortExpression="edate" />
                </Columns>
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                
                <EditRowStyle BackColor="#999999" />
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            </asp:GridView>
            </td>
        </tr>
        <tr>
        <asp:SqlDataSource ID="vas_source" runat="server" 
             oninit="vas_source_Init" >
            <SelectParameters>
                <asp:QueryStringParameter Name="id" QueryStringField="id" />
            </SelectParameters>
            <DeleteParameters>
                <asp:Parameter Name="id" Type="Int32" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="program" Type="String" />
                <asp:Parameter Name="rate_plan" Type="String" />
                <asp:Parameter Name="vas_field" Type="String" />
                <asp:Parameter Name="normal_rebate_type" Type="String" />
                <asp:Parameter Name="bundle_name" Type="String" />
                <asp:Parameter Name="hs_model" Type="String" />
                <asp:Parameter Name="issue_type" Type="String" />
                <asp:Parameter Name="edate" Type="DateTime" />
                <asp:Parameter Name="sdate" Type="DateTime" />
                <asp:Parameter Name="id" Type="Int32" />
            </UpdateParameters>
            <InsertParameters>
                <asp:Parameter Name="program" Type="String" />
                <asp:Parameter Name="rate_plan" Type="String" />
                <asp:Parameter Name="vas_field" Type="String" />
                <asp:Parameter Name="normal_rebate_type" Type="String" />
                <asp:Parameter Name="bundle_name" Type="String" />
                <asp:Parameter Name="hs_model" Type="String" />
                <asp:Parameter Name="issue_type" Type="String" />
                <asp:Parameter Name="edate" Type="DateTime" />
                <asp:Parameter Name="sdate" Type="DateTime" />
            </InsertParameters>
        </asp:SqlDataSource>
        
        
        </tr>
        </table>
    
    
    </div>
    </form>
</body>
</html>
