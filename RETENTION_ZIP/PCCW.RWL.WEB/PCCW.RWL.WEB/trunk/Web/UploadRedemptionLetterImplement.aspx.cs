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
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;


public partial class UploadRedemptionLetterImplement : NEURON.WEB.UI.BasePage
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
       if(!IsPostBack) InitFrame();
    }

    #region InitFrame
    protected void InitFrame()
    {
        if (Session["upfile"] == null) Response.Redirect("UploadRedemptionLetter.aspx");
        if ("".Equals(Session["upfile"].ToString())) Response.Redirect("UploadRedemptionLetter.aspx");
        if (WebFunc.CheckFileExists(this.Page, "~/letter/"+Session["upfile"].ToString()))
        {
            DataSet _oDS = WebFunc.ExcelToDS(Server.MapPath("~/letter/") + Session["upfile"].ToString(), WebFunc.EXCELVersion.EXCEL2003, "Sheet1$", true);
            letter_rp.DataSource = _oDS;
            letter_rp.DataBind();
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

    protected void letter_rp_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (!(-1).Equals(e.Item.ItemIndex))
        {
            EventLetterDetail _oEventLetterDetail = (EventLetterDetail)EventLetterDetailRepository.CreateEntityInstanceObject();
            _oEventLetterDetail.SetLett_sent_date(((Literal)e.Item.FindControl("lett_sent_date")).Text);
            _oEventLetterDetail.SetMob_num(((Literal)e.Item.FindControl("mob_num")).Text);
            _oEventLetterDetail.SetAccnt_cd(((Literal)e.Item.FindControl("accnt_cd")).Text);
            _oEventLetterDetail.SetDoc_id(((Literal)e.Item.FindControl("doc_id")).Text);
            _oEventLetterDetail.SetName(((Literal)e.Item.FindControl("name")).Text);
            _oEventLetterDetail.SetPrem_desc(((Literal)e.Item.FindControl("prem_desc")).Text);
            _oEventLetterDetail.SetRemarks(((Literal)e.Item.FindControl("Remarks")).Text);
            using(ISession<MSSQLConnect> _oSession=(new SessionFactory<MSSQLConnect>()).OpenSession())
            using (ITransaction _oTransaction = _oSession.BeginTransaction())
            {
                _oSession.Insert(_oEventLetterDetail);
                _oTransaction.Commit();
            }
        }
    }
}
