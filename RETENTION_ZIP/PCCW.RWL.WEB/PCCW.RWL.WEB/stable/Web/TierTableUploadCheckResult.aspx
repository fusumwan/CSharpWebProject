<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TierTableUploadCheckResult.aspx.cs" Inherits="TierTableUploadCheckResult" %>
<%@ Register Assembly="Neuron.Net.EntityFramework" Namespace="NEURON.WEB.UI" TagPrefix="EW" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>3G Retention - Web Log</title>
    
    <meta http-equiv="Content-Type" content="text/html; charset=big5" />
<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<script type="text/javascript">


</script>
<style>
.highlightrow{background:#FFFFbb}
    .style1
    {
        width: 307px;
        background: #d9e2ec;
    }
    .ReportTdStyle{
         vertical-align:middle;
    }
</style>
</head>
<body style="background-color:#ffffff">

    <form id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>

        <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <th height="28" colspan="50">&nbsp;<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></th>
                </tr>
                <tr> 
                  <td height="23" colspan="4" class="row2">
                  <asp:Button ID="confirmupload" CssClass="mainoption" Text="Confirm Upload" 
                          Font-Size="7pt" runat="server" onclick="confirmupload_Click" />  
                  <asp:Button ID="cancelupload" CssClass="mainoption" Text="Cancel Upload" 
                          Font-Size="7pt" PostBackUrl="~/Web/TierAutoSelectionExcelUpload.aspx" 
                          runat="server" />
                  <asp:Button ID="successexport" CssClass="mainoption" Text="Success Export" 
                          runat="server" Font-Size="7pt" onclick="successexport_Click" Visible="false" />
                   <asp:Button ID="errorexport" CssClass="mainoption" Text="Error Export" 
                          runat="server" Font-Size="7pt" onclick="errorexport_Click"  Visible="false" />
                   <asp:Button ID="duplicateexport" CssClass="mainoption" Text="Duplicate Export" 
                          runat="server" Font-Size="7pt" onclick="duplicateexport_Click" Visible="false"  />
                  </td>
                </tr>
                <tr> 
                  <td height="23" colspan="4" class="row2">
                  Success Record
                  </td>
                </tr>
                <tr> 
                  <td height="23" colspan="4" class="row2">
                  <EW:GridViewEx ID="success_record_gv" runat="server" AllowSorting="True" DataSourceID="FindSuccessObjectDataSource"
                    ForeColor="#333333" GridLines="None" Width="100%" 
                        AutoGenerateColumns="False" CellPadding="4">
                  
                  <Columns>


                            <asp:TemplateField HeaderText="id"  Visible="false">
                            <ItemTemplate>
                            <asp:Literal ID="id" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.id") %>' runat="server"></asp:Literal>
                            </ItemTemplate>    

                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="OB Program"  ControlStyle-CssClass="ReportTdStyle">
                            <ItemTemplate>
                            <asp:Literal ID="obprogram" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.obprogram") %>' runat="server"></asp:Literal>
                            </ItemTemplate>    

                            </asp:TemplateField>
                            
                            <asp:TemplateField HeaderText="Period"  ControlStyle-CssClass="ReportTdStyle">
                            <ItemTemplate>
                            <asp:Literal ID="period" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.period") %>' runat="server"></asp:Literal>
                            </ItemTemplate>    

                            </asp:TemplateField>
                            
                            <asp:TemplateField HeaderText="Plan Fee"  ControlStyle-CssClass="ReportTdStyle">
                            <ItemTemplate>
                            <asp:Literal ID="plan_fee" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.plan_fee") %>' runat="server"></asp:Literal>
                            </ItemTemplate>    

                            </asp:TemplateField>
                            
                            <asp:TemplateField HeaderText="Tier" ControlStyle-CssClass="ReportTdStyle">
                            <ItemTemplate>
                            <asp:Literal ID="tier" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.tier") %>' runat="server"></asp:Literal>
                            </ItemTemplate>    

                            </asp:TemplateField>
                            
                            
                            
                            <asp:TemplateField HeaderText="Tradefield Mid" ControlStyle-CssClass="ReportTdStyle">
                            <ItemTemplate>
                            <asp:Literal ID="tradefield_mid" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.tradefield_mid") %>' runat="server"></asp:Literal>
                            </ItemTemplate>    

                            </asp:TemplateField>
                                
                            <asp:TemplateField HeaderText="Channel" ControlStyle-CssClass="ReportTdStyle">
                            <ItemTemplate>
                            <asp:Literal ID="channel" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.channel") %>' runat="server"></asp:Literal>
                            </ItemTemplate>    

                            </asp:TemplateField>
                                
                                
                            <asp:TemplateField HeaderText="Start Date" ControlStyle-CssClass="ReportTdStyle">
                                <ItemTemplate>
                                    
                                <asp:Literal ID="start_date" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.start_date", "{0:dd/MM/yyyy}") %>' runat="server"></asp:Literal>
                                </ItemTemplate>
                                
                            </asp:TemplateField>


                            <asp:TemplateField HeaderText="End Date" ControlStyle-CssClass="ReportTdStyle" >
                                <ItemTemplate>
                                <asp:Literal ID="end_date" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.end_date", "{0:dd/MM/yyyy}") %>' runat="server"></asp:Literal>
                                </ItemTemplate>

                            </asp:TemplateField>
                            
                            

                            <asp:TemplateField HeaderText="Uid"  ControlStyle-CssClass="ReportTdStyle">
                            <ItemTemplate>
                            <asp:Literal ID="uid" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.uid") %>' runat="server"></asp:Literal>
                            </ItemTemplate>    
                            
                            </asp:TemplateField>
                            
                                
                            <asp:TemplateField HeaderText="Po Date" ControlStyle-CssClass="ReportTdStyle">
                                <ItemTemplate>
                                <asp:Literal ID="po_date" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.po_date", "{0:dd/MM/yyyy}") %>' runat="server"></asp:Literal>
                                </ItemTemplate>
                                
                            </asp:TemplateField>
                                
                                
                                
                            <asp:TemplateField HeaderText="Remarks" ControlStyle-CssClass="ReportTdStyle">
                            <ItemTemplate>
                            <asp:Literal ID="remarks" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.remarks") %>' runat="server"></asp:Literal>
                            </ItemTemplate>
                            </asp:TemplateField>
                                
                                
                              
                            <asp:TemplateField HeaderText="Program" ControlStyle-CssClass="ReportTdStyle">
                            <ItemTemplate>
                            <asp:Literal ID="program" Text='<%# DataBinder.Eval(Container.DataItem,"BusinessTrade.program") %>' runat="server"></asp:Literal>
                            </ItemTemplate>
                            </asp:TemplateField>
                            
                            <asp:TemplateField HeaderText="Normal rebate type" ControlStyle-CssClass="ReportTdStyle">
                            <ItemTemplate>
                            <asp:Literal ID="normal_rebate_type" Text='<%# DataBinder.Eval(Container.DataItem,"BusinessTrade.normal_rebate_type") %>' runat="server"></asp:Literal>
                            </ItemTemplate>
                            </asp:TemplateField>
                            
                            <asp:TemplateField HeaderText="Rate plan" ControlStyle-CssClass="ReportTdStyle">
                            <ItemTemplate>
                            <asp:Literal ID="rate_plan" Text='<%# DataBinder.Eval(Container.DataItem,"BusinessTrade.rate_plan") %>' runat="server"></asp:Literal>
                            </ItemTemplate>
                            </asp:TemplateField>
							
							<asp:TemplateField HeaderText="Con per" ControlStyle-CssClass="ReportTdStyle">
                            <ItemTemplate>
                            <asp:Literal ID="con_per" Text='<%# DataBinder.Eval(Container.DataItem,"BusinessTrade.con_per") %>' runat="server"></asp:Literal>
                            </ItemTemplate>
                            </asp:TemplateField>
							
							<asp:TemplateField HeaderText="Rebate" ControlStyle-CssClass="ReportTdStyle">
                            <ItemTemplate>
                            <asp:Literal ID="rebate" Text='<%# DataBinder.Eval(Container.DataItem,"BusinessTrade.rebate") %>' runat="server"></asp:Literal>
                            </ItemTemplate>
                            </asp:TemplateField>
							
							<asp:TemplateField HeaderText="free_mon" ControlStyle-CssClass="ReportTdStyle">
                            <ItemTemplate>
                            <asp:Literal ID="free_mon" Text='<%# DataBinder.Eval(Container.DataItem,"BusinessTrade.free_mon") %>' runat="server"></asp:Literal>
                            </ItemTemplate>
                            </asp:TemplateField>
                            
							<asp:TemplateField HeaderText="Hs model" ControlStyle-CssClass="ReportTdStyle">
                            <ItemTemplate>
                            <asp:Literal ID="hs_model" Text='<%# DataBinder.Eval(Container.DataItem,"BusinessTrade.hs_model") %>' runat="server"></asp:Literal>
                            </ItemTemplate>
                            </asp:TemplateField>
							
							<asp:TemplateField HeaderText="HS model name" ControlStyle-CssClass="ReportTdStyle">
                            <ItemTemplate>
                            <asp:Literal ID="hs_model_name" Text='<%# DataBinder.Eval(Container.DataItem,"BusinessTrade.hs_model_name") %>' runat="server"></asp:Literal>
                            </ItemTemplate>
                            </asp:TemplateField>
							
							<asp:TemplateField HeaderText="Premium 1" ControlStyle-CssClass="ReportTdStyle">
                            <ItemTemplate>
                            <asp:Literal ID="premium_1" Text='<%# DataBinder.Eval(Container.DataItem,"BusinessTrade.premium_1") %>' runat="server"></asp:Literal>
                            </ItemTemplate>
                            </asp:TemplateField>
							
							<asp:TemplateField HeaderText="Premium 2" ControlStyle-CssClass="ReportTdStyle">
                            <ItemTemplate>
                            <asp:Literal ID="premium_2" Text='<%# DataBinder.Eval(Container.DataItem,"BusinessTrade.premium_2") %>' runat="server"></asp:Literal>
                            </ItemTemplate>
                            </asp:TemplateField>
							
							<asp:TemplateField HeaderText="Trade field" ControlStyle-CssClass="ReportTdStyle">
                            <ItemTemplate>
                            <asp:Literal ID="trade_field" Text='<%# DataBinder.Eval(Container.DataItem,"BusinessTrade.trade_field") %>' runat="server"></asp:Literal>
                            </ItemTemplate>
                            </asp:TemplateField>
							
							<asp:TemplateField HeaderText="Bundle name" ControlStyle-CssClass="ReportTdStyle">
                            <ItemTemplate>
                            <asp:Literal ID="bundle_name" Text='<%# DataBinder.Eval(Container.DataItem,"BusinessTrade.bundle_name") %>' runat="server"></asp:Literal>
                            </ItemTemplate>
                            </asp:TemplateField>
							
							<asp:TemplateField HeaderText="Plan fee" ControlStyle-CssClass="ReportTdStyle">
                            <ItemTemplate>
                            <asp:Literal ID="plan_fee" Text='<%# DataBinder.Eval(Container.DataItem,"BusinessTrade.plan_fee") %>' runat="server"></asp:Literal>
                            </ItemTemplate>
                            </asp:TemplateField>
							
							<asp:TemplateField HeaderText="Channel" ControlStyle-CssClass="ReportTdStyle">
                            <ItemTemplate>
                            <asp:Literal ID="channel" Text='<%# DataBinder.Eval(Container.DataItem,"BusinessTrade.channel") %>' runat="server"></asp:Literal>
                            </ItemTemplate>
                            </asp:TemplateField>
							
							<asp:TemplateField HeaderText="Sdate (DD-MM-YYYY)" ControlStyle-CssClass="ReportTdStyle">
                            <ItemTemplate>
                            <asp:Literal ID="sdate" Text='<%# DataBinder.Eval(Container.DataItem,"BusinessTrade.sdate","{0:dd-MM-yyyy}") %>' runat="server"></asp:Literal>
                            </ItemTemplate>
                            </asp:TemplateField>
							
							<asp:TemplateField HeaderText="Edate (DD-MM-YYYY)" ControlStyle-CssClass="ReportTdStyle">
                            <ItemTemplate>
                            <asp:Literal ID="edate" Text='<%# DataBinder.Eval(Container.DataItem,"BusinessTrade.edate","{0:dd-MM-yyyy}") %>' runat="server"></asp:Literal>
                            </ItemTemplate>
                            </asp:TemplateField>
							
							<asp:TemplateField HeaderText="Cid" ControlStyle-CssClass="ReportTdStyle">
                            <ItemTemplate>
                            <asp:Literal ID="cid" Text='<%# DataBinder.Eval(Container.DataItem,"BusinessTrade.cid") %>' runat="server"></asp:Literal>
                            </ItemTemplate>
                            </asp:TemplateField>
							
							<asp:TemplateField HeaderText="Cdate" ControlStyle-CssClass="ReportTdStyle">
                            <ItemTemplate>
                            <asp:Literal ID="cdate" Text='<%# DataBinder.Eval(Container.DataItem,"BusinessTrade.cdate") %>' runat="server"></asp:Literal>
                            </ItemTemplate>
                            </asp:TemplateField>
							
                        </Columns>
                  
                  <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <RowStyle BackColor="#EFF3FB" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#FFDDF1" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" CssClass="explaintitle" />
                        <EditRowStyle BackColor="#DDDDDD" />
                        <AlternatingRowStyle BackColor="White" />
                  </EW:GridViewEx>
                  
                  <asp:ObjectDataSource ID="FindSuccessObjectDataSource" runat="server" 
        TypeName="PCCW.RWL.CORE.TierViewItemDAO"  SelectMethod="FindSuccess" >

    </asp:ObjectDataSource>
                  </td>
                </tr>
                <tr> 
                  <td height="23" colspan="4" class="row2">
                  Error Record
                  </td>
                </tr>
                <tr> 
                  <td height="23" colspan="4" class="row2">
                  <EW:GridViewEx ID="error_record_gv" runat="server" AllowSorting="True"  DataSourceID="FindErrorObjectDataSource"
                    ForeColor="#333333" GridLines="None" Width="100%" 
                        AutoGenerateColumns="False" CellPadding="4" >
                  <Columns>


                            <asp:TemplateField HeaderText="id"  Visible="false">
                            <ItemTemplate>
                            <asp:Literal ID="id" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.id") %>' runat="server"></asp:Literal>
                            </ItemTemplate>    

                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="OB Program" >
                            <ItemTemplate>
                            <asp:Literal ID="obprogram" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.obprogram") %>' runat="server"></asp:Literal>
                            </ItemTemplate>    

                            </asp:TemplateField>
                            
                            <asp:TemplateField HeaderText="Period" >
                            <ItemTemplate>
                            <asp:Literal ID="period" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.period") %>' runat="server"></asp:Literal>
                            </ItemTemplate>    

                            </asp:TemplateField>
                            
                            <asp:TemplateField HeaderText="Plan Fee" >
                            <ItemTemplate>
                            <asp:Literal ID="plan_fee" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.plan_fee") %>' runat="server"></asp:Literal>
                            </ItemTemplate>    

                            </asp:TemplateField>
                            
                            <asp:TemplateField HeaderText="Tier">
                            <ItemTemplate>
                            <asp:Literal ID="tier" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.tier") %>' runat="server"></asp:Literal>
                            </ItemTemplate>    

                            </asp:TemplateField>
                            
                            
                            
                            <asp:TemplateField HeaderText="Tradefield Mid">
                            <ItemTemplate>
                            <asp:Literal ID="tradefield_mid" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.tradefield_mid") %>' runat="server"></asp:Literal>
                            </ItemTemplate>    

                            </asp:TemplateField>
                                
                            <asp:TemplateField HeaderText="Channel">
                            <ItemTemplate>
                            <asp:Literal ID="channel" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.channel") %>' runat="server"></asp:Literal>
                            </ItemTemplate>    

                            </asp:TemplateField>
                                
                                
                            <asp:TemplateField HeaderText="Start Date">
                                <ItemTemplate>
                                    
                                <asp:Literal ID="start_date" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.start_date", "{0:dd/MM/yyyy}") %>' runat="server"></asp:Literal>
                                </ItemTemplate>
                                
                            </asp:TemplateField>


                            <asp:TemplateField HeaderText="End Date" >
                                <ItemTemplate>
                                <asp:Literal ID="end_date" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.end_date", "{0:dd/MM/yyyy}") %>' runat="server"></asp:Literal>
                                </ItemTemplate>

                            </asp:TemplateField>
                            
                            

                            <asp:TemplateField HeaderText="Uid" >
                            <ItemTemplate>
                            <asp:Literal ID="uid" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.uid") %>' runat="server"></asp:Literal>
                            </ItemTemplate>    
                            
                            </asp:TemplateField>
                            
                                
                            <asp:TemplateField HeaderText="Po Date">
                                <ItemTemplate>
                                <asp:Literal ID="po_date" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.po_date", "{0:dd/MM/yyyy}") %>' runat="server"></asp:Literal>
                                </ItemTemplate>
                                
                            </asp:TemplateField>
                                
                                
                                
                            <asp:TemplateField HeaderText="Remarks">
                            <ItemTemplate>
                            <asp:Literal ID="remarks" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.remarks") %>' runat="server"></asp:Literal>
                            </ItemTemplate>
                            </asp:TemplateField>
                                
                            
                        </Columns>
                  <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <RowStyle BackColor="#EFF3FB" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#FFDDF1" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" CssClass="explaintitle" />
                        <EditRowStyle BackColor="#DDDDDD" />
                        <AlternatingRowStyle BackColor="White" />
                  </EW:GridViewEx>
                  <asp:ObjectDataSource ID="FindErrorObjectDataSource" runat="server" 
        TypeName="PCCW.RWL.CORE.TierViewItemDAO"  SelectMethod="FindError" ></asp:ObjectDataSource>
                  </td>
                </tr>
                <tr> 
                  <td height="23" colspan="4" class="row2">
                  Duplicate Record
                  </td>
                </tr>
                <tr> 
                  <td height="23" colspan="4" class="row2">
                  <EW:GridViewEx ID="duplicate_record_gv" runat="server" AllowSorting="True" DataSourceID="FindDuplicateObjectDataSource" 
                    ForeColor="#333333" GridLines="None" Width="100%" 
                        AutoGenerateColumns="False" CellPadding="4">
                  
                  
                  <Columns>


                            <asp:TemplateField HeaderText="id"  Visible="false">
                            <ItemTemplate>
                            <asp:Literal ID="id" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.id") %>' runat="server"></asp:Literal>
                            </ItemTemplate>    

                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="OB Program" >
                            <ItemTemplate>
                            <asp:Literal ID="obprogram" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.obprogram") %>' runat="server"></asp:Literal>
                            </ItemTemplate>    

                            </asp:TemplateField>
                            
                            <asp:TemplateField HeaderText="Period" >
                            <ItemTemplate>
                            <asp:Literal ID="period" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.period") %>' runat="server"></asp:Literal>
                            </ItemTemplate>    

                            </asp:TemplateField>
                            
                            <asp:TemplateField HeaderText="Plan Fee" >
                            <ItemTemplate>
                            <asp:Literal ID="plan_fee" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.plan_fee") %>' runat="server"></asp:Literal>
                            </ItemTemplate>    

                            </asp:TemplateField>
                            
                            <asp:TemplateField HeaderText="Tier">
                            <ItemTemplate>
                            <asp:Literal ID="tier" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.tier") %>' runat="server"></asp:Literal>
                            </ItemTemplate>    

                            </asp:TemplateField>
                            
                            
                            
                            <asp:TemplateField HeaderText="Tradefield Mid">
                            <ItemTemplate>
                            <asp:Literal ID="tradefield_mid" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.tradefield_mid") %>' runat="server"></asp:Literal>
                            </ItemTemplate>    

                            </asp:TemplateField>
                                
                            <asp:TemplateField HeaderText="Channel">
                            <ItemTemplate>
                            <asp:Literal ID="channel" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.channel") %>' runat="server"></asp:Literal>
                            </ItemTemplate>    

                            </asp:TemplateField>
                                
                                
                            <asp:TemplateField HeaderText="Start Date">
                                <ItemTemplate>
                                    
                                <asp:Literal ID="start_date" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.start_date", "{0:dd/MM/yyyy}") %>' runat="server"></asp:Literal>
                                </ItemTemplate>
                                
                            </asp:TemplateField>


                            <asp:TemplateField HeaderText="End Date" >
                                <ItemTemplate>
                                <asp:Literal ID="end_date" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.end_date", "{0:dd/MM/yyyy}") %>' runat="server"></asp:Literal>
                                </ItemTemplate>

                            </asp:TemplateField>
                            
                            

                            <asp:TemplateField HeaderText="Uid" >
                            <ItemTemplate>
                            <asp:Literal ID="uid" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.uid") %>' runat="server"></asp:Literal>
                            </ItemTemplate>    
                            
                            </asp:TemplateField>
                            
                                
                            <asp:TemplateField HeaderText="Po Date">
                                <ItemTemplate>
                                <asp:Literal ID="po_date" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.po_date", "{0:dd/MM/yyyy}") %>' runat="server"></asp:Literal>
                                </ItemTemplate>
                                
                            </asp:TemplateField>
                                
                                
                                
                            <asp:TemplateField HeaderText="Remarks">
                            <ItemTemplate>
                            <asp:Literal ID="remarks" Text='<%# DataBinder.Eval(Container.DataItem,"AutoSelectionProperty.remarks") %>' runat="server"></asp:Literal>
                            </ItemTemplate>
                            </asp:TemplateField>
                                
                            
                        </Columns>
                  
                  <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <RowStyle BackColor="#EFF3FB" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#FFDDF1" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" CssClass="explaintitle" />
                        <EditRowStyle BackColor="#DDDDDD" />
                        <AlternatingRowStyle BackColor="White" />
                  </EW:GridViewEx>
                  <asp:ObjectDataSource ID="FindDuplicateObjectDataSource" runat="server" 
        TypeName="PCCW.RWL.CORE.TierViewItemDAO"  SelectMethod="FindDuplicate" ></asp:ObjectDataSource>
                  </td>
                </tr>
                
               
                <tr>
                   <td height="0" class="style1"><span class="explaintitle" style="font-size:7pt">Upload Success Records: </span></td>
                   <td width="77%" height="0" class="row1"><span class="explaintitle" style="font-size:7pt"> <asp:Literal ID="upload_success_records" runat="server"></asp:Literal></span></td>
                </tr>
                <tr>
                   <td height="0" class="style1"><span class="explaintitle" style="font-size:7pt">Upload Fail Records: </span></td>
                   <td width="77%" height="0" class="row1"><span class="explaintitle" style="font-size:7pt"> <asp:Literal ID="upload_fail_records" runat="server"></asp:Literal></span></td>
                </tr>
                <tr>
                   <td height="0" class="style1"><span class="explaintitle" style="font-size:7pt">Duplicate Records: </span></td>
                   <td width="77%" height="0" class="row1"><span class="explaintitle" style="font-size:7pt"> <asp:Literal ID="duplicate_records" runat="server"></asp:Literal></span></td>
                </tr>
                <tr>
                   <td height="0" class="style1"><span class="explaintitle" style="font-size:7pt">Cannot Find TraidField Mid: </span></td>
                   <td width="77%" height="0" class="row1"><span class="explaintitle" style="font-size:7pt"> <asp:Literal ID="nofindmid" runat="server"></asp:Literal></span></td>
                </tr>
                <tr>
                   <td height="0" class="style1"><span class="explaintitle" style="font-size:7pt">Tier Planfee not equal to TraidField Mid's Planfee: </span></td>
                   <td width="77%" height="0" class="row1"><span class="explaintitle" style="font-size:7pt"> <asp:Literal ID="notequal_planfee" runat="server"></asp:Literal></span></td>
                </tr>
                <tr> 
                  <td class="cat" colspan="50">&nbsp;</td>
                </tr>
              </table>
    </div>
    </form>
    

</table>  


<table width="100%" cellspacing="2" cellpadding="3" border="0">
<tr>
<td class="nav"><a href="MobileRetentionMain.aspx">Main Page</a> &raquo; View 
<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></td>
</tr>
</table>       


</body>
</html>
