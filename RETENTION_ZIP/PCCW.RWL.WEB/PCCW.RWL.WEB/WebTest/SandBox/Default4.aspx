<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="SandBox_Default4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" language="javascript">

        Date.prototype.addMonths = function(n) {
            this.setMonth(this.getMonth() + n);
            return this;
        }
        function ParseDate(DateStr) {
            if (DateStr.indexOf(" ") > 0) {
                var tempDate = new Array();
                tempDate = DateStr.split(" ");
                DateStr = tempDate[0];
            }
            var temp1 = new Array()
            temp1 = DateStr.split("/")
            var Year = temp1[2];
            var Month = temp1[1];
            var Month = parseInt(Month) - 1;
            var Day = temp1[0];
            var new_date = new Date(Year, Month, Day)
            return new_date
        }
        function DateCompareTo(Date1, Date2) {

            if (((Date1 - Date2) / 86400000) >= 0) {
                return true;
            }
            return false;
        }

        var SdateTemp1 = ParseDate("1/1/2011");
        var SdateTemp2 = ParseDate("1/5/2011");
        function AddMatch(Logdate,EDate) {
            for (i = 0; i < 21; i++) {
                if (DateCompareTo(Logdate, EDate) == false) {
                    Logdate = Logdate.addMonths(1);
                }
                else {
                    return i;
                }
            }
            return 0;
        }



    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>

    </div>
    </form>
</body>
</html>
