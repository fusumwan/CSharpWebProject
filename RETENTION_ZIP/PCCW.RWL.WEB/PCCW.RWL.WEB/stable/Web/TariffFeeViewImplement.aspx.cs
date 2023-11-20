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
using System.Globalization;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;


public partial class TariffFeeViewImplement : NEURON.WEB.UI.BasePage
{
    MSSQLConnect n_oDB = null;
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
        if (!IsPostBack)
        {
            BindData();
        }
    }

    public void BindData()
    {
        if (n_oDB == null) { (n_oDB = new MSSQLConnect()).SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty)); }
        TariffFeeSchedule_VIEW_RP.DataSource = n_oDB.GetDS("SELECT id,program,fee,org_fee FROM "+Configurator.MSSQLTablePrefix+"TariffFeeSchedule WHERE active=1 order by id");
        TariffFeeSchedule_VIEW_RP.DataBind();
    }


    protected void submitbut_Click(object sender, EventArgs e)
    {
        TariffFeeSchedule _oTariffFeeSchedule = (TariffFeeSchedule)TariffFeeScheduleRepository.CreateEntityInstanceObject();
        _oTariffFeeSchedule.SetProgram(txtPROGRAM_ADD.Text);
        _oTariffFeeSchedule.SetOrg_fee(Convert.ToInt32(txtORG_FEE_ADD.Text.ToString()));
        _oTariffFeeSchedule.SetFee(txtFEE_ADD.Text);
        _oTariffFeeSchedule.SetActive(true);
        if (RWLFramework.CurrentUser[this.Page].Uid != null) _oTariffFeeSchedule.SetCid(RWLFramework.CurrentUser[this.Page].Uid.ToString());
        _oTariffFeeSchedule.SetCdate(DateTime.Now);
        if (n_oDB == null) { (n_oDB = new MSSQLConnect()).SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty)); }

        if (TariffFeeScheduleRepository.InsertWithOutLastID(n_oDB, _oTariffFeeSchedule))
        {
            BindData();
            txtPROGRAM_ADD.Text = string.Empty;
            txtORG_FEE_ADD.Text = string.Empty;
            txtFEE_ADD.Text = string.Empty;
        }
        else
        {
            WebFunc.RegisterScriptEX(this.Page, "Insert Error!");
        }

    }
    protected void TariffFeeSchedule_VIEW_RP_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (n_oDB == null) { (n_oDB = new MSSQLConnect()).SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty)); }
        if ("Modify".Equals(e.CommandName))
        {
            Label _txtid = (Label)e.Item.FindControl("txtid");
            int _iTarrff_id = Convert.ToInt32(_txtid.Text);
            TextBox _txtPROGRAM = (TextBox)e.Item.FindControl("txtPROGRAM");
            TextBox _txtFEE = (TextBox)e.Item.FindControl("txtFEE");
            TextBox _txtORG_FEE = (TextBox)e.Item.FindControl("txtORG_FEE");

            TariffFeeSchedule _oTariffFeeSchedule = new TariffFeeSchedule(n_oDB, _iTarrff_id);
            if (_txtPROGRAM.Text != string.Empty) { _oTariffFeeSchedule.SetProgram(_txtPROGRAM.Text); }
            if (_txtFEE.Text != string.Empty) { _oTariffFeeSchedule.SetFee(_txtFEE.Text); }
            if (_txtORG_FEE.Text != string.Empty) { _oTariffFeeSchedule.SetOrg_fee(Convert.ToInt32(_txtORG_FEE.Text.ToString())); }

            if (RWLFramework.CurrentUser[this.Page].Uid!= null) _oTariffFeeSchedule.SetCid(RWLFramework.CurrentUser[this.Page].Uid.ToString());
            _oTariffFeeSchedule.SetCdate(DateTime.Now);
            _oTariffFeeSchedule.SetActive(true);
            if (_oTariffFeeSchedule.Save())
            {
                TariffFeeBackup(_iTarrff_id);
                BindData();
            }
            else
            {
                WebFunc.RegisterScriptEX(this.Page, "Modify Error!");
            }
        }
        else if ("Delete".Equals(e.CommandName))
        {
            Label _txtid = (Label)e.Item.FindControl("txtid");
            int _iTarrff_id = Convert.ToInt32(_txtid.Text);
            if (TariffFeeScheduleRepository.Delete(n_oDB, _iTarrff_id))
            {
                TariffFeeBackup(_iTarrff_id);
                BindData();
            }
        }
    }

    protected bool TariffFeeBackup(int x_iId)
    {
        string _sQueryBK="insert into TariffFeeScheduleRevision (rec_no, program, org_fee, fee, active, cid, cdate) ";
        _sQueryBK+= " select id, program, org_fee, fee, active, '" +RWLFramework.CurrentUser[this.Page].Uid+ "',getdate() from TariffFeeSchedule ";
        _sQueryBK += " where id='" +x_iId.ToString()+ "'";
        return SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_sQueryBK);
    }

    protected void TariffFeeSchedule_VIEW_RP_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (!e.Item.ItemIndex.Equals(-1))
        {
            int orderID = e.Item.ItemIndex + 1;
            Label _TariffNum = (Label)e.Item.FindControl("TariffNum");
            _TariffNum.Text = orderID.ToString();
        }
    }
}
