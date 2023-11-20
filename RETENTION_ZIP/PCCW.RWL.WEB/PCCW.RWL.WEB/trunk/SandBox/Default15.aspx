<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default15.aspx.cs" Inherits="SandBox_Default15" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <style> 
    table { 
    border-bottom-style: solid; 
    border-bottom-width: 10px; 
    border-bottom-color: EEEEEE; /* lt gray*/ 
    border-right-style: solid; 
    border-right-width: 10px; 
    border-right-color: EEEEEE; /* lt gray*/ 
    } 
    
    .DrpCss
    {
    border-bottom-style: solid; 
    border-bottom-width: 10px; 
    border-bottom-color: EEEEEE; /* lt gray*/ 
    border-right-style: solid; 
    border-right-width: 10px; 
    border-right-color: EEEEEE; /* lt gray*/
    background-image:  url("../Images/silk/arrow_left.png");
    }
    
    </style> 
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:DropDownList ID="drp1" runat="server" CssClass="DrpCss">
    <asp:ListItem Text="12222222" Value="1"></asp:ListItem>
    <asp:ListItem Text="222222222" Value="2"></asp:ListItem>
    </asp:DropDownList>

    <table border="1">
    <tr>
    <td>1</td>
    <td>2</td>
    </tr>
    <tr>
    <td>1</td>
    <td>2</td>
    </tr>
    </table>
    
    
    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" 
              BorderColor="Black" 
              BorderStyle="Solid" 
              CellSpacing="1" 
              Font-Names="Verdana" 
              Font-Size="9pt" 
              ForeColor="Black" 
              Height="250px" 
              Width="500px" 
              NextPrevFormat="ShortMonth" 
              SelectionMode="Day">
              <SelectedDayStyle BackColor="DarkOrange" 
                     ForeColor="White" />
   <DayStyle BackColor="Orange" 
             Font-Bold="True" 
             ForeColor="White" />
   <NextPrevStyle Font-Bold="True" 
                  Font-Size="8pt" 
                  ForeColor="White" />
   <DayHeaderStyle Font-Bold="True" 
                   Font-Size="8pt" 
                   ForeColor="#333333" 
                   Height="8pt" />
   <TitleStyle BackColor="Firebrick" 
               BorderStyle="None" 
               Font-Bold="True" 
               Font-Size="12pt"
   ForeColor="White" Height="12pt" />
   <OtherMonthDayStyle BackColor="NavajoWhite" 
                       Font-Bold="False" 
                       ForeColor="DarkGray" />

              </asp:Calendar>

    </div>
    </form>
</body>
</html>
