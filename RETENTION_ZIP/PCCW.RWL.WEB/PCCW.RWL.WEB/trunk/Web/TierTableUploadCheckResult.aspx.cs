using System;
using System.Collections;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using log4net;
using System.Reflection;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
public partial class TierTableUploadCheckResult : NEURON.WEB.UI.BasePage
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

    public void InitFrame()
    {
        upload_success_records.Text = TierViewControl.Instance().GetSuccessIn().Count.ToString();
        upload_fail_records.Text = TierViewControl.Instance().GetErrRecord().Count.ToString();
        duplicate_records.Text = TierViewControl.Instance().GetDupRecord().Count.ToString();
        nofindmid.Text = TierViewControl.Instance().NoFindMid;
        notequal_planfee.Text = TierViewControl.Instance().NotEqualPlanFee;
    }

    protected void confirmupload_Click(object sender, EventArgs e)
    {
        ISessionFactory<MSSQLConnect> _oSessionFactory = new SessionFactory<MSSQLConnect>();
        using (ISession<MSSQLConnect> _oSession = _oSessionFactory.OpenSession())
        using (ITransaction _oTransaction = _oSession.BeginTransaction())
        {
            bool _bRollBack = false;
            IList<TierViewItem> _oTierViewItemList = TierViewControl.Instance().GetSuccessIn();
            for (int i = 0; i < _oTierViewItemList.Count; i++)
            {
                if (!_oSession.Insert(_oTierViewItemList[i].AutoSelectionProperty))
                {
                    _bRollBack = true;
                    break;
                }
            }
            if (_bRollBack)
            {
                _oTransaction.Rollback();
                string _sError = "<script>alert('ERROR : Cannot insert these records!\n ');</script>";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ERROR", _sError, false);
                Response.Redirect("TierAutoSelectionExcelUpload.aspx");
            }
            else
            {
                string _sError = "<script>alert('Insert Finlish! \n ');</script>";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ERROR", _sError, false);
                _oTransaction.Commit();
                Response.Redirect("TierAutoSelectionExcelUpload.aspx");
            }
        }
    }
    protected void errorexport_Click(object sender, EventArgs e)
    {
        try
        {
            error_record_gv.ExportExcel("TierErrorExcel.xls");
        }
        catch (Exception Exp)
        {

        }
    }
    protected void duplicateexport_Click(object sender, EventArgs e)
    {
        try
        {
            duplicate_record_gv.ExportExcel("TierDuplicateExcel.xls");
        }
        catch (Exception Exp)
        {

        }
    }
    protected void successexport_Click(object sender, EventArgs e)
    {
        try
        {
            success_record_gv.ExportExcel("TierSuccessExport.xls");
        }
        catch (Exception Exp)
        {

        }
    }
}
