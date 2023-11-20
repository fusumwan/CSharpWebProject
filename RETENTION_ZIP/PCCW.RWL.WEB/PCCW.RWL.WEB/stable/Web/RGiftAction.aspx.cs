using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.Odbc;
using System.Text;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.Odbc;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Globalization;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;


public partial class Web_RGiftAction : NEURON.WEB.UI.BasePage
{
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion
    string[] n_sDateTimeList = { "dd/mm/yyyy hh24:mi:ss" };
    string[] n_sDateTimeList2 = { "yyyymmdd" };
    string n_sToday = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
    string n_sToday1 = DateTime.Now.ToString("yyyyMMdd");
    protected void Page_Load(object sender, EventArgs e)
    {
        this.HeaderScripts.Text = string.Format(
        @"<script type=""text/javascript"" src=""{0}/Resources/Scripts/jquery-1.3.2.min.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/global.js""></script>
        <!--[if lte IE 6]><script defer type=""text/javascript"" src=""{0}/Resources/Scripts/pngfix.js""></script><![endif]-->
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/norefresh.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/script.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/jquery-ui-1.8.2.custom.min.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/jquery.alerts.js""></script>
        <link rel=""stylesheet"" href=""{0}/Resources/Styles/jquery.alerts.css"" type=""text/css"" />"
       , Request.ApplicationPath);

        WebFunc.PrivilegeCheck(this.Page);
    }

    public void InitFrame()
    {
        string _sImei = Func.RQ(Request["imei"]).Trim();
        string _sSku = Func.RQ(Request["sku"]).Trim();
        string _sQuery1 = "SELECT * FROM IMEI_Stock WHERE Dummy2='CC RET' and Status='SOLD' and Kit_Code='" +_sSku+ "' and IMEI='" +_sImei+ "'";
        OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(_sQuery1);
        if (_oDr.Read())
        {
            string _sAment_Date = string.Empty;
            if (Convert.IsDBNull(_oDr["Dummy1"]) || "".Equals(_oDr["Dummy1"].ToString().Trim()))
            {
                if (!Convert.IsDBNull(_oDr["Create_Date"]) && _oDr["Create_Date"] != null)
                {
                    DateTime _dAment_Date = (DateTime)_oDr["Create_Date"];
                    _sAment_Date = _dAment_Date.ToString("yyyyMMdd");
                }
                else
                    _sAment_Date = Func.FR(_oDr["Dummy1"]).ToString();
            }
            else
                _sAment_Date = _oDr["Dummy1"].ToString();

            string _sQuery2 = "INSERT INTO IMEI_Stock_hist (Kit_Code,Model,Status,ReferenceNo,DUMMY4,Create_Date,Create_By,Dummy1,Dummy2,Stock_In_Date,IMEI,Ament_Date) values ('" + Func.FR(_oDr["Kit_Code"]) + "','" + Func.FR(_oDr["Model"]) + "','" + Func.FR(_oDr["Status"]) + "','" + Func.FR(_oDr["ReferenceNo"]) + "','" + Func.FR(_oDr["DUMMY4"]) + "',to_date('" + n_sToday + "' , 'dd/mm/yyyy hh24:mi:ss'),'" + RWLFramework.CurrentUser[this.Page].Uid + "','" + Func.FR(_oDr["Dummy1"]) + "','" + Func.FR(_oDr["Dummy2"]) + "','" + Func.FR(_oDr["Stock_In_Date"]) + "','" + Func.FR(_oDr["IMEI"]) + "',to_date('" + _sAment_Date + "' , 'yyyymmdd')) ";
            bool _bFlag1 = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_sQuery2);
            string _sQuery3 = "UPDATE IMEI_Stock SET Status='NORMAL', Dummy1='" + n_sToday1 + "', ReferenceNo=null, StaffNo=null ,Mobile_no=null ,Completed_Date=null, DUMMY4=null where IMEI='" + _sImei + "' and Dummy2='CC RET' and Kit_Code='" + _sSku + "' ";
            bool _bFlag2 = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_sQuery3);
            string _sQuery4 = "UPDATE MobileRetentionOrder SET gift_desc=null, gift_imei=null,gift_code=null where active=1 and gift_imei='" + _sImei + "' and gift_code='" + _sSku + "'";
            bool _bFlag3 = SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_sQuery4);
            string _sQuery5 = "UPDATE MobileRetentionOrder SET gift_desc2=null, gift_imei2=null,gift_code2=null where active=1 and gift_imei2='" + _sImei + "' and gift_code2='" + _sSku + "'";
            bool _bFlag4 = SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_sQuery5);
            string _sQuery6 = "UPDATE MobileRetentionOrder SET gift_desc3=null, gift_imei3=null,gift_code3=null where active=1 and gift_imei3='" + _sImei + "' and gift_code3='" + _sSku + "'";
            bool _bFlag5 = SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_sQuery6);
            string _sQuery7 = "UPDATE MobileRetentionOrder SET gift_desc4=null, gift_imei4=null,gift_code4=null where active=1 and gift_imei4='" + _sImei + "' and gift_code4='" + _sSku + "'";
            bool _bFlag6 = SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_sQuery7);
            string _sQuery8 = "UPDATE MobileRetentionOrder SET accessory_desc=null,accessory_price=0, accessory_imei=null,accessory_code=null where active=1 and accessory_imei='" + _sImei + "' and accessory_code='" + _sSku + "'";
            bool _bFlag7 = SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_sQuery8);

            StringBuilder _oScript = new StringBuilder();

            _oScript.AppendLine("<script>window.opener.document.form1." + Func.RQ(Request["check_imei"]).ToString() + ".value=\"\";</script>");
            _oScript.AppendLine("<script>window.opener.document.form1.get_" + Func.RQ(Request["check_imei"]).ToString() + ".disabled=false;</script>");
            _oScript.AppendLine("<script>window.opener.document.form1.r_" + Func.RQ(Request["check_imei"]).ToString() + ".disabled=true;</script>");
            _oScript.AppendLine("<script>window.opener.document.form1." + Func.RQ(Request["gift"]).ToString() + ".disabled=false;</script>");
            _oScript.AppendLine("<script>window.opener.document.form1.r_" + Func.RQ(Request["check_imei"]).ToString() + ".style.display=\"none\";</script>");
            _oScript.AppendLine("<script>window.opener.document.form1.get_" + Func.RQ(Request["check_imei"]).ToString() + ".style.display=\"inline\";</script>");
            Response.Write(_oScript.ToString());
        }
        else
        {
            StringBuilder _oScript = new StringBuilder();
            _oScript.AppendLine("<script>alert(\"Cannot release\")</script>");
            Response.Write(_oScript.ToString());
        }
        _oDr.Close();
        _oDr.Dispose();
    }
}
