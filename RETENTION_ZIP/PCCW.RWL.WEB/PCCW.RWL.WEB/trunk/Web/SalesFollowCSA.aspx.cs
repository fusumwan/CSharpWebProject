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
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;

public partial class SalesFollowCSA : NEURON.WEB.UI.BasePage
{
    MSSQLConnect n_oDB = null;
    MobileCsaOperationCenter _oMobileCsaOperationCenter = new MobileCsaOperationCenter();
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
        if (!IsPostBack){
            BindData();
        }
    }

    public void BindData()
    {
        if (n_oDB == null) { (n_oDB = new MSSQLConnect()).SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty)); }
        if(RWLFramework.CurrentUser[this.Page].Lv!=null) _oMobileCsaOperationCenter.SetLv(RWLFramework.CurrentUser[this.Page].Lv.ToString());
        if (RWLFramework.CurrentUser[this.Page].Uid != null) _oMobileCsaOperationCenter.SetUid(RWLFramework.CurrentUser[this.Page].Uid.ToString());
        _oMobileCsaOperationCenter.SetSalemancodelist(_oMobileCsaOperationCenter.Get_SalesManList());
        FOLLOW_SALES_RP.DataSource = _oMobileCsaOperationCenter.Get_FS_Mobile_Operations();
        FOLLOW_SALES_RP.DataBind();
        FoManagementLLOW_MOBILE_RP.DataSource = _oMobileCsaOperationCenter.Get_FollowUp_Sales();
        FoManagementLLOW_MOBILE_RP.DataBind();
    }
    protected void FOLLOW_SALES_RP_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (!e.Item.ItemIndex.Equals(-1))
        {
            int _iOrderID = e.Item.ItemIndex + 1;
            Literal _oViewid = (Literal)e.Item.FindControl("FONum");
            _oViewid.Text = _iOrderID.ToString();
        }
    }
    protected void FoManagementLLOW_MOBILE_RP_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (!e.Item.ItemIndex.Equals(-1))
        {
            int _iOrderID = e.Item.ItemIndex + 1;
            Literal _oViewid = (Literal)e.Item.FindControl("FONum");
            _oViewid.Text = _iOrderID.ToString();

        }
    }
}
