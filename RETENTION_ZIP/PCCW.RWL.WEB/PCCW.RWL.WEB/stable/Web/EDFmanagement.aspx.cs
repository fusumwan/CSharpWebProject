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
using System.Data.Odbc;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;

public partial class EDFmanagement : NEURON.WEB.UI.BasePage
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
            Logger.ErrorFormat("EDFmanagement ERROR :{0}", exp.ToString());
            Response.Redirect("MobileRetentionMain.aspx");
        }
    }

    public void InitFrame()
    {
        EDFStatusProfile _oEDFStatusProfile = new EDFStatusProfile();

        _oEDFStatusProfile.LoadData(WebFunc.qsEdf_no.Replace("'", "''").Trim());
        if (_oEDFStatusProfile.Found)
        {
            edf_status_placeholder.Visible = true;
            edf_status_no_record_placeholder.Visible = false;
            issue.Text = _oEDFStatusProfile.Issue;
            issue_date.Text = _oEDFStatusProfile.Issue_date;
            doc_receive.Text = _oEDFStatusProfile.Doc_receive;
            doc_r_date.Text = _oEDFStatusProfile.Doc_r_date;
            assign_sn.Text = _oEDFStatusProfile.Assign_sn;
            assign_date.Text = _oEDFStatusProfile.Assign_date;
            assign_name.Text = _oEDFStatusProfile.Assign_name;
            fo_to_sales.Text = _oEDFStatusProfile.Fo_to_sales;
            fo_date.Text = _oEDFStatusProfile.Fo_date;
            fallout_status.Text = _oEDFStatusProfile.STATUS;
            fallout_status_date.Text = _oEDFStatusProfile.STATUS_DATE;
            payment_status.Text = _oEDFStatusProfile.Payment_status;
            payment_status_date.Text = _oEDFStatusProfile.Payment_status_date;
            create_s.Text = _oEDFStatusProfile.Create_s;
            create_s_date.Text = _oEDFStatusProfile.Create_s_date;
            actual_del_date.Text = _oEDFStatusProfile.Actual_del_date;
            print_delivery.Text = _oEDFStatusProfile.Print_delivery;
            to_plg.Text = _oEDFStatusProfile.To_plg;
            to_plg_date.Text = _oEDFStatusProfile.To_plg_date;
            activated.Text = _oEDFStatusProfile.Activated;
            activated_date.Text = _oEDFStatusProfile.Activated_date;
            pending.Text = _oEDFStatusProfile.Pending;
            pend_date.Text = _oEDFStatusProfile.Pend_date;
            fail_reason.Text = _oEDFStatusProfile.Fail_reason;
            MNP_Rejection.Text = _oEDFStatusProfile.MNP_Rejection;
            MNP_rej_date.Text = _oEDFStatusProfile.MNP_rej_date;
            Mnp_rej_code.Text = _oEDFStatusProfile.MNP_rej_code;
            cancelled.Text = _oEDFStatusProfile.Cancelled;
            cancel_date.Text = _oEDFStatusProfile.Cancelled_date;
            pc_reason.Text = _oEDFStatusProfile.Pc_reason;
            last_update.Text = _oEDFStatusProfile.Last_update;
        }
        else
        {
            edf_status_no_record_placeholder.Visible = true;
            edf_status_placeholder.Visible = false;
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
        _oDB.SetConnStr(Configurator.DBName.ORADNS + ((!"".Equals(Configurator.IsUat())) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion
}
