using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Xml.Linq;
using System.Data.Odbc;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using NEURON.ENTITY.FRAMEWORK;

using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
/// <summary>
/// Summary description for EDFHelper
/// </summary>
namespace PCCW.RWL.CORE
{
    public class EDFHelper
    {
        public EDFHelper() { }

        public static string[,] GetEDFField(int x_iEdfXSize,int x_iEDFYSize)
        {
            string[,] edfField = new string[x_iEdfXSize, x_iEDFYSize];
            edfField[0, 0] = "Sales Channel";
            edfField[1, 0] = "Application Date";
            edfField[2, 0] = "Customer Name";
            edfField[3, 0] = "Mobile No";
            edfField[4, 0] = "Contact No";
            edfField[5, 0] = "Order Amount";
            edfField[6, 0] = "Delivery Charge";
            edfField[7, 0] = "Expected Delivery Date";
            edfField[8, 0] = "Expected Delivery Period";
            edfField[9, 0] = "Delivery Address";
            edfField[10, 0] = "Remark";
            edfField[11, 0] = "Item Code";
            edfField[12, 0] = "Description";
            edfField[13, 0] = "Handset Payment Type";
            edfField[14, 0] = "Handset Credit Card No";
            edfField[15, 0] = "Handset Card Holder Name";
            edfField[16, 0] = "Handset Expiry Date (mmyy)";
            edfField[17, 0] = "Handset Payment Amount";
            edfField[18, 0] = "Contact Person";
            edfField[19, 0] = "Free Gift Code";
            edfField[20, 0] = "Free Gift Description";
            edfField[21, 0] = "Program";
            edfField[22, 0] = "Rate Plan";
            edfField[23, 0] = "Contract Period";
            edfField[24, 0] = "Free Gift Code 1";
            edfField[25, 0] = "Free Gift Description 1";
            edfField[26, 0] = "Accessory Cost";
            edfField[27, 0] = "IMEI";
            edfField[28, 0] = "Trade Field";
            edfField[29, 0] = "Rebate Table";
            edfField[30, 0] = "Free Gift Code 2";
            edfField[31, 0] = "Free Gift Description 2";
            edfField[32, 0] = "Customer HKID TYPE";
            edfField[33, 0] = "Customer HKID /Passport/BR No";
            edfField[34, 0] = "Free Gift Code 3";
            edfField[35, 0] = "Free Gift Description 3";
            edfField[36, 0] = "Free Gift Code 4";
            edfField[37, 0] = "Free Gift Description 4";
            edfField[38, 0] = "Free Gift IMEI 0";
            edfField[39, 0] = "Free Gift IMEI 1";
            edfField[40, 0] = "Free Gift IMEI 2";
            edfField[41, 0] = "Free Gift IMEI 3";
            edfField[42, 0] = "Free Gift IMEI 4";
            edfField[43, 0] = "VIP Customer";
            edfField[44, 0] = "Contract effective date";
            edfField[45, 0] = "Bundle name";
            edfField[46, 0] = "Sim card type";
            edfField[47, 0] = "Sim item code";
            edfField[48, 0] = "Delivery Collection Type";
            edfField[49, 0] = "Delivery Exchange";
            edfField[50, 0] = "Delivery Exchange Option";
            edfField[51, 0] = "Delivery Exchange Location";



            edfField[52, 0] = "Service Activation Date";
            edfField[53, 0] = "Date of birth (dd/mm/yyyy)";
            edfField[54, 0] = "$12 license fee (YES / NO)";
            edfField[55, 0] = "2G IDD / Roaming Deposit Transfer to 3G";
            edfField[56, 0] = "Transfer IDD deposit";
            edfField[57, 0] = "Transfer IDD & roaming deposit";
            edfField[58, 0] = "Transfer Non-HK ID holder deposit";
            edfField[59, 0] = "Transfer no address proof deposit";
            edfField[60, 0] = "Transfer others deposit";





            edfField[61, 0] = "Monthly Payment Type";
            edfField[62, 0] = "Credit Card Type";
            edfField[63, 0] = "Credit Card No";
            edfField[64, 0] = "Card Holder Name";
            edfField[65, 0] = "3rd party ID";
            edfField[66, 0] = "Expiry Date (mmyy)";
            edfField[67, 0] = "Bill Medium";
            edfField[68, 0] = "SMS MRT";
            edfField[69, 0] = "Email Address";
            edfField[70, 0] = "Billing Address";
            edfField[71, 0] = "Waive paper bill indicator";
            edfField[72, 0] = "Prepayment";
            edfField[73, 0] = "Extra Rebate";
            edfField[74, 0] = "2N Company name";
            edfField[75, 0] = "2N Registered name";
            edfField[76, 0] = "Ticker number";
            edfField[77, 0] = "Registered address";


            edfField[78, 0] = "VAS1";
            edfField[79, 0] = "VAS2";
            edfField[80, 0] = "VAS3";
            edfField[81, 0] = "Mobile Internet Package";
            edfField[82, 0] = "SMS";

            edfField[83, 0] = "SS Language";

            edfField[84, 0] = "Service Activation Date (AM/PM)";
            edfField[85, 0] = "Bank Holder ID Type";
            edfField[86, 0] = "Monthly Rebate Amount";
            edfField[87, 0] = "2N HK ID No Type";
            edfField[88, 0] = "2N HK ID No";
            edfField[89, 0] = "Action of Rate Plan Effective";
            edfField[90, 0] = "2ND HANDSET REBATE SCHEDULE";


            edfField[91, 0] = "EXISTING CUSTOMER TYPE";
            edfField[92, 0] = "EXISTING CONTRACT START DATE";
            edfField[93, 0] = "EXISTING CONTRACT END DATE";
            edfField[94, 0] = "EXISTING PCCW CUSTOMER";
            edfField[95, 0] = "SERVICE ACCOUNT NO";
            edfField[96, 0] = "SERVICE TENURE";

            edfField[97, 0] = "SMARTPHONE MODEL";
            edfField[98, 0] = "SMARTPHONE IMEI";
            edfField[99, 0] = "NEXT BILL CUT DATE";
            edfField[100, 0] = "RATE PLAN EFFECTIVE DATE";
            edfField[101, 0] = "BILL CUT DATE";
            edfField[102, 0] = "MTHLY PAYMENT TYPE";
            edfField[103, 0] = "A AUTOPAY REBATE";
            edfField[104, 0] = "A CONNECTING TONE SERVICE";
            edfField[105, 0] = "A COUPON OFFER 1";
            edfField[106, 0] = "A DATA ROAMING";
            edfField[107, 0] = "A FINANCIAL INFO";
            edfField[108, 0] = "A GPRS MOBILE DATA SERVICE";
            edfField[109, 0] = "A IDD & ROAMING";
            edfField[110, 0] = "A $12 LICENSE FEE";
            edfField[111, 0] = "A ADDITIONAL MINUTES UPG";
            edfField[112, 0] = "A MOOV ON MOBILE";
            edfField[113, 0] = "A MOBILE INTERNET PKG";
            edfField[114, 0] = "A NOW ON MOBILE";
            edfField[115, 0] = "A OTHER 1";
            edfField[116, 0] = "A OTHER 2";
            edfField[117, 0] = "A OTHER 3";
            edfField[118, 0] = "A OTHER 4";
            edfField[119, 0] = "A OTHER 5";
            edfField[120, 0] = "A OTHER 6";
            edfField[121, 0] = "A SECRETARIAL SERVICE";
            edfField[122, 0] = "A SMS PACKAGE 1";
            edfField[123, 0] = "A SMS PACKAGE 2";
            edfField[124, 0] = "A SMS PACKAGE 3";
            edfField[125, 0] = "A SMS BOXX SERVICE";
            edfField[126, 0] = "A SPORT ON MOBILE";
            edfField[127, 0] = "A SUPERVAS SERVICE";
            edfField[128, 0] = "A WIFI";
            edfField[129, 0] = "1C2N(CHN) MRT";
            edfField[130, 0] = "Credit Check Reference No";
            edfField[131, 0] = "Staff No";
            edfField[132, 0] = "Promotion 3";
            edfField[133, 0] = "Promotion 4";
            edfField[134, 0] = "A COUPON OFFER 2";
            edfField[135, 0] = "A PREMIUM OFFER 1";
            edfField[136, 0] = "A PREMIUM OFFER 2";


            edfField[137, 0] = "Card Holder ID";
            edfField[138, 0] = "A [EXISTING] SUPERVAS SERVICE";
            edfField[139, 0] = "A 1C2N BUNDLE";
            edfField[140, 0] = "A MOBILE MSN";
            edfField[141, 0] = "A Premium Offer 3";
            edfField[142, 0] = "A Premium Offer 4";
            edfField[143, 0] = "Additional 200 mins";
            edfField[144, 0] = "Additional 450 mins";
            edfField[145, 0] = "Registered Mobile No";



            return edfField;

        }
    }
}
