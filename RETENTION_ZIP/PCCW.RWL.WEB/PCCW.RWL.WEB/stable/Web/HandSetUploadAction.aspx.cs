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
using log4net;
using System.Reflection;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

public partial class HandSetUploadAction : NEURON.WEB.UI.BasePage
{
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion

    DataSet _oDataSet = null;
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

    public void RunJavascriptFunc(string x_sFunc)
    {
        string _sFunc = ((x_sFunc.IndexOf(';') > 0) ? x_sFunc : x_sFunc + ";");
        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sFunc + (new Random()).Next(1, 1000).ToString()+Guid.NewGuid().ToString(), string.Format("<script>{0}</script>", _sFunc), false);
    }

    #region InitFrame
    protected void InitFrame()
    {
        string _sUpload = "Web/upload";
        String _sPath = Server.MapPath("~/Web/upload/");
        string _sFileName = Func.RQ(Request["FileName"]).Trim();
        string _sFilePath = _sPath + _sFileName;
        string _sExcelVersion = Func.RQ(Request["excelversion"]).Trim();
        string _sServerFilePath = "~/" + _sUpload + "/" + _sFileName;
        string _sIsUat = Func.RQ(Request["uat"]).Trim();
        bool _bIsUat = bool.Parse(_sIsUat);
        ServerDirFileName.Text = _sFileName;
        form1.Attributes["form1"] = "HandSetUploadActionProcess.aspx?fn=" + _sFileName + "&uat=" + _sIsUat;
        Import.PostBackUrl = "HandSetUploadActionProcess.aspx?fn=" + _sFileName + "&excelversion=" + _sExcelVersion + "&uat=" + _sIsUat;
        if (WebFunc.CheckFileExists(this.Page, _sServerFilePath)){
            string _sSheetName = WebFunc.ExcelSheetName(_sFilePath, _sExcelVersion.Trim().ToUpper());
            string _sField = "mid,r_offer,extra_rebate_amount,cdate,amount,cid,did,edate,payment,con_per,ddate,premium,extra_rebate,rebate_gp,normal_rebate_type,hs_model,active,rebate_amount,plan_fee,item_code,sdate";

            try
            {
                _oDataSet = WebFunc.ExcelToDS(_sFilePath, _sField, _sExcelVersion, _sSheetName, true,string.Empty);
                if (_oDataSet != null)
                {
                    RecordCount.Text = _oDataSet.Tables[0].Rows.Count.ToString();
                    if (_oDataSet.Tables[0].Rows.Count < 50000)
                    {
                        vas_gv.DataSource = _oDataSet;
                        vas_gv.DataBind();
                        vas_gv.Visible = true;
                        RecordValueList.Visible = false;
                    }
                    else
                    {
                        vas_gv.Visible = false;
                        RecordValueList.Visible = true;
                    }
                }
                else
                    vas_gv.Visible = false;

            }
            catch (Exception exp)
            {
                msg.Text = "Please check the excel file format!";
                WebFunc.RegisterScriptEX(this.Page, "Please check the excel file format!");
                Import.Visible = true;
            }
        }
    }
    #endregion

    public void FieldNameListAdd(string x_sObj)
    {
        FieldNameList.Controls.Add(new LiteralControl(x_sObj));
    }

    #region GetDB
    public static MSSQLConnect GetDB(bool x_bIsUat)
    {
        MSSQLConnect _oDB = new MSSQLConnect();
        _oDB.bWithNoLock = true;
        _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((x_bIsUat) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion
}
