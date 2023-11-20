<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TierAutoSelectionViewAndModify.aspx.cs" Inherits="TierAutoSelectionViewAndModify" %>
<%@ Register TagPrefix="RWLMenu2" TagName="RWLMenu2" Src="~/UI/RWLControlMenu.ascx" %>
<%@ Register Src="../UI/GlobalNavigation.ascx" TagName="GlobalNavigation" TagPrefix="uc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Import Namespace="PCCW.RWL.CORE.WEBFUNC" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>3G Retention - Web Log</title>
    
<meta http-equiv="Content-Type" content="text/html; charset=big5" />

<link rel="stylesheet" href="../Resources/Styles/MainPageStyle.css" type="text/css" />
<link href="../Resources/Styles/global.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../Resources/Scripts/script.js" language="JavaScript"></script>
<script type="text/javascript" src="../Resources/Scripts/norefresh.js" language="JavaScript"></script>
  <asp:Literal ID="HeaderScripts" runat="server"></asp:Literal>
<script type="text/javascript"></script>

</head>
<body style="background-color:#ffffff">
    <form id="form1" runat="server">
    <div id="page-header"><uc1:GlobalNavigation ID="GlobalNavigation1" runat="server" /></div>
    <div>
<asp:ScriptManager ID="AddWebLogScriptManager" runat="server"></asp:ScriptManager>

    <table width="100%" border="0" cellpadding="3" cellspacing="1" class="forumline">
                <tr> 
                  <th height="28" colspan="4">&nbsp;<span class="explaintitle" style="font-size:8pt"><%=global::PCCW.RWL.CORE.Configurator.GetTitle() %></span></th>
                </tr>
                <tr> 
                  <td height="23" colspan="4" class="row2">

                  <asp:Button ID="BACK" CssClass="mainoption" Text="BACK" Font-Size="7pt" runat="server" PostBackUrl="~/Web/TierAutoSelectionExcelUpload.aspx" />
                    <span class="explaintitle"> </span><span class="gensmall"> 
                    </span></td>
                </tr>
                
                <tr>
                <td height="23" colspan="4" class="row2" align="center">
                
                    
                
                    <asp:GridView ID="TierViewGV" runat="server" AllowSorting="True" 
                    ForeColor="#333333" GridLines="None" Width="100%" 
                        AutoGenerateColumns="False" CellPadding="4" DataKeyNames="id" 
                        DataSourceID="TierSource" onrowupdating="TierViewGV_RowUpdating" >
                        
                        <Columns>
                            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" 
                                ShowSelectButton="True" />
                            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                                ReadOnly="True" SortExpression="id" Visible="False" />

                            
                            <asp:TemplateField HeaderText="OB Program" SortExpression="obprogram">
                            <ItemTemplate>
                            <asp:Literal ID="obprogram" Text='<%# DataBinder.Eval(Container.DataItem,"obprogram") %>' runat="server"></asp:Literal>
                            </ItemTemplate>    
                            <EditItemTemplate>
                            <asp:TextBox ID="obprogram" Text='<%# Bind("obprogram") %>' runat="server" Font-Size="7pt" Width="100"></asp:TextBox>
                            </EditItemTemplate>
                            </asp:TemplateField>
                            
                            <asp:TemplateField HeaderText="Period" SortExpression="period">
                            <ItemTemplate>
                            <asp:Literal ID="period" Text='<%# DataBinder.Eval(Container.DataItem,"period") %>' runat="server"></asp:Literal>
                            </ItemTemplate>    
                            <EditItemTemplate>
                            <asp:TextBox ID="period" Text='<%# Bind("period") %>' runat="server" Font-Size="7pt" Width="100"></asp:TextBox>
                            </EditItemTemplate>
                            </asp:TemplateField>
                            
                            <asp:TemplateField HeaderText="Plan Fee" SortExpression="plan_fee">
                            <ItemTemplate>
                            <asp:Literal ID="plan_fee" Text='<%# DataBinder.Eval(Container.DataItem,"plan_fee") %>' runat="server"></asp:Literal>
                            </ItemTemplate>    
                            <EditItemTemplate>
                            <asp:TextBox ID="plan_fee" Text='<%# Bind("plan_fee") %>' runat="server" Font-Size="7pt" Width="100"></asp:TextBox>
                            </EditItemTemplate>
                            </asp:TemplateField>
                            
                            <asp:TemplateField HeaderText="Tier" SortExpression="tier">
                            <ItemTemplate>
                            <asp:Literal ID="tier" Text='<%# DataBinder.Eval(Container.DataItem,"tier") %>' runat="server"></asp:Literal>
                            </ItemTemplate>    
                            <EditItemTemplate>
                            <asp:TextBox ID="tier" Text='<%# Bind("tier") %>' runat="server" Font-Size="7pt" Width="100"></asp:TextBox>
                            </EditItemTemplate>
                            </asp:TemplateField>
                            
                            
                            
                            <asp:TemplateField HeaderText="Tradefield Mid" SortExpression="tradefield_mid">
                            <ItemTemplate>
                            <asp:Literal ID="tradefield_mid" Text='<%# DataBinder.Eval(Container.DataItem,"tradefield_mid") %>' runat="server"></asp:Literal>
                            </ItemTemplate>    
                            <EditItemTemplate>
                            <asp:TextBox ID="tradefield_mid" Text='<%# Bind("tradefield_mid") %>' runat="server" Font-Size="7pt" Width="100" ReadOnly="true"></asp:TextBox>
                            </EditItemTemplate>
                            </asp:TemplateField>
                                
                            <asp:TemplateField HeaderText="Channel" SortExpression="Channel">
                            <ItemTemplate>
                            <asp:Literal ID="channel" Text='<%# DataBinder.Eval(Container.DataItem,"channel") %>' runat="server"></asp:Literal>
                            </ItemTemplate>    
                            <EditItemTemplate>
                            <asp:TextBox ID="channel" Text='<%# Bind("channel") %>' runat="server" Font-Size="7pt" Width="100" ReadOnly="true"></asp:TextBox>
                            </EditItemTemplate>
                            </asp:TemplateField>
                                
                                
                            <asp:TemplateField HeaderText="Start Date" SortExpression="start_date">
                                <ItemTemplate>
                                    
                                <asp:Literal ID="start_date" Text='<%# DataBinder.Eval(Container.DataItem,"start_date", "{0:dd/MM/yyyy}") %>' runat="server"></asp:Literal>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    
                                <asp:TextBox ID="start_date" Text='<%# Bind("start_date", "{0:dd/MM/yyyy}") %>' runat="server" Font-Size="7pt" Width="50"  MaxLength="10"></asp:TextBox>

                                <asp:RequiredFieldValidator runat="server" ID="rfv1"
                                ErrorMessage="Please enter a date in the DD/MM/YYYY format"
                                ControlToValidate="start_date" Display="Dynamic"
                                EnableClientScript="true" />
                                <asp:ImageButton runat="server" ID="CalenderImageSDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                                <cc1:CalendarExtender runat="server" 
                                ID="CalendarSDateFormat"
                                TargetControlID="start_date"
                                Format="dd/MM/yyyy"
                                PopupButtonID="CalenderImageSDate" />
                                </EditItemTemplate>
                            </asp:TemplateField>


                            <asp:TemplateField HeaderText="End Date" SortExpression="end_date">
                                <ItemTemplate>
                                <asp:Literal ID="end_date" Text='<%# DataBinder.Eval(Container.DataItem,"end_date", "{0:dd/MM/yyyy}") %>' runat="server"></asp:Literal>
                                </ItemTemplate>
                                <EditItemTemplate>
                                <asp:TextBox ID="end_date" Text='<%# Bind("end_date", "{0:dd/MM/yyyy}") %>' runat="server" Font-Size="7pt" Width="50"  MaxLength="10"></asp:TextBox>

                                <asp:RequiredFieldValidator runat="server" ID="rfv2"
                                ErrorMessage="Please enter a date in the DD/MM/YYYY format"
                                ControlToValidate="end_date" Display="Dynamic"
                                EnableClientScript="true" />
                                
                                
                                <asp:ImageButton runat="server" ID="CalenderImageEDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                                <cc1:CalendarExtender runat="server" 
                                ID="CalendarEDateFormat"
                                TargetControlID="end_date"
                                Format="dd/MM/yyyy"
                                PopupButtonID="CalenderImageEDate" />
                                </EditItemTemplate>
                            </asp:TemplateField>
                            
                            

                            <asp:TemplateField HeaderText="Uid" SortExpression="Uid">
                            <ItemTemplate>
                            <asp:Literal ID="uid" Text='<%# DataBinder.Eval(Container.DataItem,"uid") %>' runat="server"></asp:Literal>
                            </ItemTemplate>    
                            <EditItemTemplate>
                            <asp:TextBox ID="uid" Text='<%# Bind("uid") %>' Font-Size="7pt" Width="50" runat="server"></asp:TextBox>
                            </EditItemTemplate>
                            </asp:TemplateField>
                            
                                
                            <asp:TemplateField HeaderText="Po Date" SortExpression="po_date">
                                <ItemTemplate>
                                <asp:Literal ID="po_date" Text='<%# DataBinder.Eval(Container.DataItem,"po_date", "{0:dd/MM/yyyy}") %>' runat="server"></asp:Literal>
                                </ItemTemplate>
                                <EditItemTemplate>
                                <asp:TextBox ID="po_date" Text='<%# Bind("po_date", "{0:dd/MM/yyyy}") %>' runat="server" Font-Size="7pt" Width="50"   MaxLength="10"></asp:TextBox>
                                
                                
                                <asp:RequiredFieldValidator runat="server" ID="rfv3"
                                ErrorMessage="Please enter a date in the DD/MM/YYYY format"
                                ControlToValidate="po_date" Display="Dynamic"
                                EnableClientScript="true" />
                                <asp:ImageButton runat="server" ID="CalenderImagePDate" ImageUrl="~/Resources/Images/calendar.png"  OnClientClick="return false;"/>
                                <cc1:CalendarExtender runat="server" 
                                ID="CalendarPDateFormat"
                                TargetControlID="po_date"
                                Format="dd/MM/yyyy"
                                PopupButtonID="CalenderImagePDate" />
                                </EditItemTemplate>
                            </asp:TemplateField>
                                
                                
                                
                            <asp:TemplateField HeaderText="Remarks" SortExpression="Remarks">
                            <ItemTemplate>
                            <asp:Literal ID="remarks" Text='<%# DataBinder.Eval(Container.DataItem,"remarks") %>' runat="server"></asp:Literal>
                            </ItemTemplate>    
                            <EditItemTemplate>
                            <asp:TextBox ID="remarks" Text='<%# Bind("remarks") %>' Font-Size="7pt" Width="250" runat="server"></asp:TextBox>
                            </EditItemTemplate>
                            </asp:TemplateField>
                                
                            
                        </Columns>
                        
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <RowStyle BackColor="#EFF3FB" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#FFDDF1" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" CssClass="explaintitle" />
                        <EditRowStyle BackColor="#DDDDDD" />
                        <AlternatingRowStyle BackColor="White" />
                    </asp:GridView>
                    <br />
                   
                    <asp:SqlDataSource ID="TierSource" runat="server" 
                        DeleteCommand="DELETE FROM [AutoSelectionProperty] WHERE [id] = @id" 
                        InsertCommand="INSERT INTO [AutoSelectionProperty] ([obprogram], [period], [plan_fee], [tier], [tradefield_mid], [channel], [start_date], [end_date], [uid], [po_date], [remarks]) VALUES (@obprogram, @period, @plan_fee, @tier, @tradefield_mid, @channel, @start_date, @end_date, @uid, @po_date, @remarks)" 
                        SelectCommand="SELECT * FROM [AutoSelectionProperty]" 
                        UpdateCommand="UPDATE [AutoSelectionProperty] SET [obprogram] = @obprogram, [period] = @period, [plan_fee] = @plan_fee, [tier] = @tier, [tradefield_mid] = @tradefield_mid, [channel] = @channel, [start_date] = @start_date, [end_date] = @end_date, [uid] = @uid, [po_date] = @po_date, [remarks] = @remarks WHERE [id] = @id" 
                        oninit="TierSource_Init" onupdating="TierSource_Updating" >
                        <DeleteParameters>
                            <asp:Parameter Name="id" Type="Int32" />
                        </DeleteParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="obprogram" Type="String" />
                            <asp:Parameter Name="period" Type="String" />
                            <asp:Parameter Name="plan_fee" Type="String" />
                            <asp:Parameter Name="tier" Type="String" />
                            <asp:Parameter Name="tradefield_mid" Type="Int32" />
                            <asp:Parameter Name="channel" Type="String" />
                            <asp:Parameter DbType="DateTime" Name="start_date"/>
                            <asp:Parameter DbType="DateTime" Name="end_date" />
                            <asp:Parameter Name="uid" Type="String" />
                            <asp:Parameter DbType="DateTime" Name="po_date" />
                            <asp:Parameter Name="remarks" Type="String" />
                            <asp:Parameter Name="id" Type="Int32" />
                        </UpdateParameters>
                        <InsertParameters>
                            <asp:Parameter Name="obprogram" Type="String" />
                            <asp:Parameter Name="period" Type="String" />
                            <asp:Parameter Name="plan_fee" Type="String" />
                            <asp:Parameter Name="tier" Type="String" />
                            <asp:Parameter Name="tradefield_mid" Type="Int32" />
                            <asp:Parameter Name="channel" Type="String" />
                            <asp:Parameter DbType="DateTime" Name="start_date" />
                            <asp:Parameter DbType="DateTime" Name="end_date" />
                            <asp:Parameter Name="uid" Type="String" />
                            <asp:Parameter DbType="DateTime" Name="po_date" />
                            <asp:Parameter Name="remarks" Type="String" />
                        </InsertParameters>
                    </asp:SqlDataSource>
                
                    
                
                </td>
                </tr>
                <tr> 
                  <td class="cat" colspan="4">&nbsp;</td>
                </tr>   
      </table>
    
    
    </div>
    </form>
</body>
</html>
