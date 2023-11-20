using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.Sql;
using System.Data.SqlClient;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;



public partial class CheckCustomerSN : NEURON.WEB.UI.BasePage
{
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion
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
        bool _bSn_modify = false;
        bool _bSn_exist = false;
        bool _bSn_empty = false;
        string _sHiddenCust_sn = Func.RQ(Request["hidden"]).Trim();
        string _sCust_sn = Func.RQ(Request["cust_sn"]).Trim();
        string _sOrder_id = Func.RQ(Request["order_id"]).Trim();
        if (_sCust_sn.Equals(_sHiddenCust_sn)) { _bSn_modify = true; }
        if (_sCust_sn.Equals(string.Empty)) { _bSn_empty = true; }
        string _sFilter = "active=1 AND con_eff_date is not null AND con_per is not null AND dateadd(month, convert(float,con_per) -3,con_eff_date)>=getdate() AND active=1 AND cust_staff_no='" + _sCust_sn.Trim() + "'";
        if (!"".Equals(_sOrder_id)) { _sFilter = _sFilter + " AND order_id<>'" + _sOrder_id + "'"; }
        SqlDataReader _oReader = MobileRetentionOrderBal.GetSearch(GetDB(), "con_eff_date,con_per,dateadd(month, convert(float,con_per) -3,con_eff_date) ", _sFilter, null, null);
        if (_oReader != null)
        {
            if (_oReader.Read()) { _bSn_exist = true; }
            if (_oReader != null) _oReader.Close(); _oReader.Dispose();
        }


        if (_bSn_empty)
        {
            Response.Write("<script> alert(\"Please Enter Customer Staff No\")</script>");
            Response.Write("<script> if(window.opener.document.getElementById('cust_staff_no')!=undefined){     window.opener.document.form1.cust_staff_no.select(); } </script>");
            Response.Write("<script> if(window.opener.document.getElementById('check_sn_no')!=undefined){     window.opener.document.form1.check_sn_no.value=\"false\"; } </script>");
        }
        else if (_bSn_exist && !_bSn_modify)
        {
            check_staff_tensure_html();
            Response.Write("<script> alert(\"This Staff already issued an order!\")</script>");
            Response.Write("<script> if(window.opener.document.getElementById('cust_staff_no')!=undefined){     window.opener.document.form1.cust_staff_no.select(); } </script>");
            Response.Write("<script> if(window.opener.document.getElementById('check_sn_no')!=undefined){     window.opener.document.form1.check_sn_no.value=\"false\"; } </script>");
        }
        else
        {
            check_staff_tensure_html();
            Response.Write("<script> alert(\"PASS\")</script>");
            Response.Write("<script> if(window.opener.document.getElementById('check_sn_no')!=undefined){     window.opener.document.form1.check_sn_no.value=\"true\"; } </script>");
            Response.Write("<script> if(window.opener.document.getElementById('cust_staff_no')!=undefined){     window.opener.document.form1.cust_staff_no.readOnly=true; } </script>");

        }
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
        _oDB.SetConnStr(Configurator.DBName.ORADNS + ((Configurator.IsUat()) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion

    #region HTML for staff tensure msg
    protected void check_staff_tensure_html()
    {
        Response.Write("<script>var _sHkid;");
        Response.Write("_sHkid = $('#cust_staff_no', window.opener.document).val();");
        Response.Write("$('#check_cust_no_result', window.opener.document).css('display','inline');");
        Response.Write("try{");
        Response.Write("if((_sHkid>=0000703&&_sHkid<=1164813)||(_sHkid>=8030041&&_sHkid<=8177230)||(_sHkid>=9014200&& _sHkid<=9280470)){");
        Response.Write("$('#check_cust_no_result_over', window.opener.document).show();");
        Response.Write("$('#check_cust_no_result_below', window.opener.document).hide();");
        Response.Write("}else{");
        Response.Write("$('#check_cust_no_result_over', window.opener.document).hide();");
        Response.Write("$('#check_cust_no_result_below', window.opener.document).show();");
        Response.Write("}");
        Response.Write("$('#check_cust_no_result', window.opener.document).css('display','inline');");
        Response.Write("}catch(err){");
        Response.Write("$('#check_cust_no_result', window.opener.document).hide();");
        Response.Write("$('#check_cust_no_result_below', window.opener.document).hide();");
        Response.Write("$('#check_cust_no_result_over', window.opener.document).hide();");
        Response.Write("}");
        Response.Write("</script>");
    }
    #endregion

}
