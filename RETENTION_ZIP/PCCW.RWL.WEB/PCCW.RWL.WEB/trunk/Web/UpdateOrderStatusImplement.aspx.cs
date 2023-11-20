using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Text;
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



public partial class UpdateOrderStatusImplement : NEURON.WEB.UI.BasePage
{
    private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
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
        if (!IsPostBack) InitFrame();
    }

    protected string[] GetFalloutMobileOrderList(){
        List<string> _oListOrder = new List<string>();
        if (!string.IsNullOrEmpty(WebFunc.qsUpdate_status.Trim()))
        {
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append(" SELECT order_id FROM " + Configurator.MSSQLTablePrefix + "MobileOrderReport ");
            _oQuery.Append(" WHERE mid in (" + WebFunc.qsUpdate_status.Trim() + ") ");
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
            while (_oDr.Read()){
                if (!Func.FR(_oDr["order_id"]).Equals(string.Empty))
                    _oListOrder.Add(Func.FR(_oDr["order_id"]));
            }
            _oDr.Close();
            _oDr.Dispose();
        }
       return _oListOrder.ToArray();
    }
    protected string[] GetMobileReportFalloutList(string[] x_oListOrder)
    {
        if (x_oListOrder == null) { return new string[0]; }
        if (x_oListOrder.Length == 0) { return new string[0]; }
        string _sQuery = "SELECT mid FROM " + Configurator.MSSQLTablePrefix + "MobileOrderReport where active=1 and order_id in (" + string.Join(",", x_oListOrder) + ") AND retrieve_date is not null and order_status like 'FALLOUT%' ";
        List<string> _oListReportOrder = new List<string>();
        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
        while (_oDr.Read()){
            if (!Func.FR(_oDr["mid"]).Equals(string.Empty))
                _oListReportOrder.Add(Func.FR(_oDr["mid"]));
        }
        _oDr.Close();
        _oDr.Dispose();
        return _oListReportOrder.ToArray();
    }
    #region InitFrame
    protected void InitFrame(){
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("INSERT INTO " + Configurator.MSSQLTablePrefix + "MobileOrderReportHistory(rec_no,order_id,email_date,report_type,order_status,fallout_main_category,fallout_reason,fallout_remark,fallout_reply,retrieve_sn,retrieve_date,active,cid,cdate,did,ddate,reactive_sn,reactive_date ) ");
        _oQuery.Append(" SELECT mid,order_id,email_date,report_type,order_status,fallout_main_category,fallout_reason,fallout_remark,fallout_reply,retrieve_sn,retrieve_date,active,cid,cdate,'" + RWLFramework.CurrentUser[this.Page].Uid + "',getdate(),reactive_sn,reactive_date  from " + Configurator.MSSQLTablePrefix + "MobileOrderReport  where mid in ("+ WebFunc.qsUpdate_status.Trim()+ ")");
        SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_oQuery.ToString());
        if (!string.IsNullOrEmpty(WebFunc.qsUpdate_status.Trim()))
        {
            string _sMidList = string.Empty;
            string[] _sMidArr=    GetMobileReportFalloutList(GetFalloutMobileOrderList());
            if (_sMidArr != null){ _sMidList = string.Join(",", _sMidArr); }
            _oQuery = new StringBuilder();
            _oQuery.Append("UPDATE " +Configurator.MSSQLTablePrefix+ "MobileOrderReport SET order_status='" +WebFunc.qsOrder_status.Trim()+ "', ");
            _oQuery.Append(" fallout_main_category='" + WebFunc.qsFallout_main_category.Trim().Replace("'", "''") + "',");
            _oQuery.Append(" fallout_reason='" + WebFunc.qsFallout_reason.Trim().Replace("'", "''") + "',");
            _oQuery.Append(" fallout_remark='" + WebFunc.qsFallout_remark.Trim().Replace("'", "''") + "',");
            _oQuery.Append(" fallout_reply='',");
            _oQuery.Append(" cid='" + RWLFramework.CurrentUser[this.Page].Uid + "',cdate=getdate() ");
            //_oQuery.Append("  WHERE mid in (" +WebFunc.qsUpdate_status.Trim()+") or mid IN (SELECT mid FROM " +Configurator.MSSQLTablePrefix+ "MobileOrderReport where active=1 and order_id in (SELECT order_id FROM " +Configurator.MSSQLTablePrefix + "MobileOrderReport WHERE mid in (" +WebFunc.qsUpdate_status.Trim()+ ")) AND retrieve_date is not null and order_status like 'FALLOUT%')");
            _oQuery.Append("  WHERE mid in (" + WebFunc.qsUpdate_status.Trim() + ((_sMidList!=string.Empty)?","+_sMidList:"") + ")");
            
            SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_oQuery.ToString());
            if (WebFunc.qsOrder_status.Trim() == "DONE")
            {
                SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT old_ord_id FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where old_ord_id<>'0' and order_id in (SELECT order_id FROM " + Configurator.MSSQLTablePrefix + "MobileOrderReport WHERE active=1 AND mid in (" + WebFunc.qsUpdate_status.Trim() + "))");
                while (_oDr.Read())
                {
                    SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery("UPDATE " + Configurator.MSSQLTablePrefix + "MobileOrderReport SET order_status='DONE', fallout_main_category=null,fallout_reason=null, fallout_remark=null, fallout_reply=null, cid='" + RWLFramework.CurrentUser[this.Page].Uid + "', cdate=getdate() WHERE order_id ='" + Func.FR(_oDr["old_ord_id"]) + "'");
                    MobileOrderReport _oMobileOrderReport = new MobileOrderReport(SYSConn<MSSQLConnect>.Connect());
                    _oMobileOrderReport.SetOrder_id(Convert.ToInt32(Func.FR(_oDr["old_ord_id"])));
                    _oMobileOrderReport.SetEmail_date(DateTime.Now);
                    _oMobileOrderReport.SetReport_type("rwl_del");
                    _oMobileOrderReport.SetOrder_status("DONE");
                    _oMobileOrderReport.SetRetrieve_sn("auto");
                    _oMobileOrderReport.SetRetrieve_date(DateTime.Now);
                    _oMobileOrderReport.SetActive(true);
                    _oMobileOrderReport.SetCid("auto");
                    _oMobileOrderReport.SetCdate(DateTime.Now);
                    using(ISession<MSSQLConnect> _oSession=(new SessionFactory<MSSQLConnect>()).OpenSession())
                    using (ITransaction _oTransaction = _oSession.BeginTransaction())
                    {
                        _oSession.Insert(_oMobileOrderReport);
                        _oTransaction.Commit();
                    }
                }
                _oDr.Close();
                _oDr.Dispose();
            }
        }
    }
    #endregion
}
