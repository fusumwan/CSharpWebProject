using System;
using System.Collections;
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
using System.Xml.Linq;
using System.Data.Sql;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Text;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using log4net;
using System.Reflection;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

public partial class CustomerAccountAddAction : NEURON.WEB.UI.BasePage
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
        try
        {
            if (!IsPostBack) { InitFrame(); }
        }
        catch (Exception exp)
        {
            Logger.ErrorFormat("CustomerAccountAddAction ERROR :{0}", exp.ToString());
            Response.Redirect("MobileRetentionMain.aspx");
        }
    }

    #region InitFrame
    public void InitFrame()
    {
        CustomerAccount _oCustomerAccount = (CustomerAccount)CustomerAccountRepository.CreateEntityInstanceObject();
        if (WebFunc.qsOrder_id != null)
        {
            using (ISession<MSSQLConnect> _oSession = (new SessionFactory<MSSQLConnect>()).OpenSession())
            using (ITransaction _oTransaction = _oSession.BeginTransaction())
            {
                _oCustomerAccount.SetDB(SYSConn<MSSQLConnect>.Connect());
                _oCustomerAccount.SetOrder_id(Convert.ToInt32(Func.IDSubtract100000(WebFunc.qsOrder_id)));
                _oCustomerAccount.SetAc_no(WebFunc.qsAc_no);
                _oCustomerAccount.SetMrt_no(WebFunc.qsMrt_no);
                _oCustomerAccount.SetRemarks(WebFunc.qsRemarks);
                _oCustomerAccount.SetCid(RWLFramework.CurrentUser[this.Page].Uid);
                _oCustomerAccount.SetCdate(DateTime.Now);
                if (_oSession.Insert(_oCustomerAccount))
                {
                    string _sToday = DateTime.Now.ToString("dd/MM/yyyy");
                    MobileOrderReport _oMobileOrderReport = (MobileOrderReport)MobileOrderReportRepository.CreateEntityInstanceObject();
                    if (WebFunc.qsOrder_id != null) _oMobileOrderReport.SetOrder_id(Convert.ToInt32(Func.IDSubtract100000(WebFunc.qsOrder_id)));
                    _oMobileOrderReport.SetDB(SYSConn<MSSQLConnect>.Connect());
                    _oMobileOrderReport.SetEmail_date(DateTime.Now);
                    _oMobileOrderReport.SetReport_type("rwl_cust");
                    _oMobileOrderReport.SetActive(true);

                    if (_oSession.Insert(_oMobileOrderReport))
                        _oTransaction.Commit();
                    else
                        _oTransaction.Rollback();
                }
            }
            SqlDataReader _oReader = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT top 1 * FROM " + Configurator.MSSQLTablePrefix + "CustomerAccount WHERE order_id='" + ((WebFunc.qsOrder_id != null) ? Func.IDSubtract100000(WebFunc.qsOrder_id) : string.Empty) + "' ORDER BY id desc");
            if (_oReader.Read()){
                if (!Func.IsDBNullOrEmpty(_oReader[CustomerAccount.Para.order_id]))
                    order_id.Text = _oReader[CustomerAccount.Para.order_id].ToString();

                if (!Func.IsDBNullOrEmpty(_oReader[CustomerAccount.Para.ac_no]))
                    ac_no.Text = _oReader[CustomerAccount.Para.ac_no].ToString();

                if (!Func.IsDBNullOrEmpty(_oReader[CustomerAccount.Para.mrt_no]))
                    mrt_no.Text = _oReader[CustomerAccount.Para.mrt_no].ToString();

                if (!Func.IsDBNullOrEmpty(_oReader[CustomerAccount.Para.remarks]))
                    remarks.Text = _oReader[CustomerAccount.Para.remarks].ToString().Replace("\n", "<br>");
            }
            if (_oReader != null) _oReader.Close(); _oReader.Dispose();
        }
    }
    #endregion

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
