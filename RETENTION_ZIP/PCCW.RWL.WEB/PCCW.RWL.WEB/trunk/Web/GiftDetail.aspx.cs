using System;
using System.Collections;
using System.Configuration;
using System.Data;
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
using System.Globalization;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using log4net;
using System.Reflection;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

public partial class GiftDetail : NEURON.WEB.UI.BasePage
{
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion
    string[] n_sDateTimeList = { "dd/MM/yyyy hh24:mi:ss"};
    string[] n_sDateTimeList2 = { "yyyyMMdd" };
    
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
        string _sToday = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        string _sToday1 = DateTime.Now.ToString("ddMMyyyy");
        string _sTime1 = DateTime.Now.ToString("HH:mm:ss");
        string _sQuery1 = "SELECT * FROM IMEI_Stock WHERE Dummy2='CC RET' AND Status='NORMAL' AND Kit_Code='" + Request.QueryString["sku"].ToString().Trim() + "' AND IMEI<>' '";
        OdbcDataReader _oReader = SYSConn<ODBCConnect>.Connect().GetSearch(_sQuery1);
        if (_oReader != null)
        {
            if (_oReader.Read())
            {
                string _sAment_Date = string.Empty;
                if (Convert.IsDBNull(_oReader["Dummy1"]) || "".Equals(_oReader["Dummy1"].ToString().Trim()))
                {
                    if(!Convert.IsDBNull(_oReader["Create_Date"]) && _oReader["Create_Date"]!=null){
                        DateTime _dAment_Date=(DateTime)_oReader["Create_Date"];
                        _sAment_Date=_dAment_Date.ToString("yyyyMMdd");
                    }
                    else
                        _sAment_Date = Func.FR(_oReader["Dummy1"]).ToString();
                }
                else
                    _sAment_Date = Func.FR(_oReader["Dummy1"]).ToString();

                SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("INSERT INTO IMEI_Stock_hist (Kit_Code,Model,Status,ReferenceNo,DUMMY4,Create_Date,Create_By,Dummy1,Dummy2,Stock_In_Date,IMEI,Ament_Date) values ('" + Func.FR(_oReader["Kit_Code"]).ToString().Trim() + "','" + Func.FR(_oReader["Model"]).ToString() + "','" + Func.FR(_oReader["Status"]).ToString() + "','" + Func.FR(_oReader["ReferenceNo"]).ToString() + "','" + Func.FR(_oReader["DUMMY4"]).ToString() + "',to_date('" + _sToday + "' , 'dd/mm/yyyy hh24:mi:ss'),'" + RWLFramework.CurrentUser[this.Page].Uid + "','" + Func.FR(_oReader["Dummy1"]).ToString() + "','" + Func.FR(_oReader["Dummy2"]).ToString() + "','" + Func.FR(_oReader["Stock_In_Date"]).ToString() + "','" + Func.FR(_oReader["IMEI"]).ToString().Trim() + "',to_date('" + _sAment_Date + "' , 'yyyymmdd')) ");
                string _sQuery2 = "UPDATE IMEI_Stock SET STAFF_RECD='" + _sTime1 + "', Dummy1='" + _sToday1 + "', StaffNo='" + RWLFramework.CurrentUser[this.Page].Uid + "',Status='SOLD', Completed_Date='" + _sToday1 + "' WHERE IMEI='" + Func.FR(_oReader["IMEI"]).ToString().Trim() + "' AND Dummy2='CC RET' AND Status='NORMAL' AND Kit_Code='" + Func.RQ(Request["sku"]).ToString().Trim() + "'";
                bool _bFlag= SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_sQuery2);

                StringBuilder _oScript = new StringBuilder();

                _oScript.AppendLine("<script>if(window.opener.document.form1." + Func.RQ(Request["check_imei"]).ToString() + "!=undefined) {window.opener.document.form1." + Func.RQ(Request["check_imei"]).ToString() + ".value=\"" + Func.FR(_oReader["IMEI"]).ToString() + "\";}</script>");
                _oScript.AppendLine("<script>if(window.opener.document.form1.get_" + Func.RQ(Request["check_imei"]).ToString() + "!=undefined) {window.opener.document.form1.get_" + Func.RQ(Request["check_imei"]).ToString() + ".disabled=true;}</script>");
                _oScript.AppendLine("<script>if(window.opener.document.form1.get_" + Func.RQ(Request["check_imei"]).ToString() + "!=undefined) {window.opener.document.form1.get_" + Func.RQ(Request["check_imei"]).ToString() + ".style.display=\"none\";}</script>");
                _oScript.AppendLine("<script>if(window.opener.document.form1." + Func.RQ(Request["gift"]).ToString() + "!=undefined) {window.opener.document.form1." + Func.RQ(Request["gift"]).ToString() + ".disabled=true;}</script>");
                _oScript.AppendLine("<script>if(window.opener.document.form1.r_" + Func.RQ(Request["check_imei"]).ToString() + "!=undefined) {window.opener.document.form1.r_" + Func.RQ(Request["check_imei"]).ToString() + ".disabled=false;}</script>");
                _oScript.AppendLine("<script>if(window.opener.document.form1.r_" + Func.RQ(Request["check_imei"]).ToString() + "!=undefined) {window.opener.document.form1.r_" + Func.RQ(Request["check_imei"]).ToString() + ".style.display=\"inline\";}</script>");

                Response.Write(_oScript.ToString());
            }
            else
            {

                StringBuilder _oScript = new StringBuilder();

                _oScript.AppendLine("<script>if(window.opener.document.form1." + Func.RQ(Request["check_imei"]).ToString() + "!=undefined) {window.opener.document.form1." + Func.RQ(Request["check_imei"]).ToString() + ".value=\"\";}</script>");
                _oScript.AppendLine("<script>if(window.opener.document.form1.get_" + Func.RQ(Request["check_imei"]).ToString() + "!=undefined) {window.opener.document.form1.get_" + Func.RQ(Request["check_imei"]).ToString() + ".disabled=false;}</script>");
                _oScript.AppendLine("<script>if(window.opener.document.form1.get_" + Func.RQ(Request["check_imei"]).ToString() + "!=undefined) {window.opener.document.form1.get_" + Func.RQ(Request["check_imei"]).ToString() + ".style.display=\"inline\";}</script>");
                _oScript.AppendLine("<script>if(window.opener.document.form1." + Func.RQ(Request["gift"]).ToString() + "!=undefined) {window.opener.document.form1." + Func.RQ(Request["gift"]).ToString() + ".disabled=false;}</script>");
                _oScript.AppendLine("<script>if(window.opener.document.form1.r_" + Func.RQ(Request["check_imei"]).ToString() + "!=undefined) {window.opener.document.form1.r_" + Func.RQ(Request["check_imei"]).ToString() + ".disabled=true;}</script>");
                _oScript.AppendLine("<script>if(window.opener.document.form1.r_" + Func.RQ(Request["check_imei"]).ToString() + "!=undefined) {window.opener.document.form1.r_" + Func.RQ(Request["check_imei"]).ToString() + ".style.display=\"none\";}</script>");
                _oScript.AppendLine("<script>alert(\"NO STOCK\")</script>");

                 Response.Write(_oScript.ToString());

            }
        }
        _oReader.Close();
        _oReader.Dispose();

    }

    #region GetDB
    protected MSSQLConnect GetDB()
    {
        MSSQLConnect _oDB = new MSSQLConnect();
        _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
        _oDB.bWithNoLock = true;
        return _oDB;
    }
    #endregion

    #region Get Oracle DB
    protected ODBCConnect GetORDB()
    {
        ODBCConnect _oDB = new ODBCConnect();
        _oDB.SetConnStr(Configurator.DBName.ORADNS+((Configurator.IsUat()) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion
}
