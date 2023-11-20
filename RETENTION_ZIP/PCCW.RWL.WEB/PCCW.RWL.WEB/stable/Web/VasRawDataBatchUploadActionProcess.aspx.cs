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
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Text;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using log4net;
using System.Reflection;
using System.Globalization;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;


public partial class VasRawDataBatchUploadActionProcess : NEURON.WEB.UI.BasePage
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

    protected string DR(object x_oObj)
    {
        if (x_oObj == null) return string.Empty;
        return x_oObj.ToString();
    }

    public void InitFrame()
    {
        string[] _oFormat = new string[] { 
        "MM/dd/yyyy", "MM/dd/yyyy HH:mm","MM/dd/yyyy H:mm","MM/dd/yyyy H:m","MM/dd/yyyy H:mm:ss","MM/dd/yyyy H:m:ss",  "MM/dd/yyyy HH:mm:ss",
        "MM/dd/yyyy tt ", "MM/dd/yyyy HH:mm tt ","MM/dd/yyyy H:mm tt","MM/dd/yyyy H:m tt","MM/dd/yyyy H:mm:ss tt","MM/dd/yyyy H:m:ss tt",  "MM/dd/yyyy HH:mm:ss tt",
        "MM/dd/yyyy tt ", "MM/dd/yyyy hh:mm tt ","MM/dd/yyyy h:mm tt","MM/dd/yyyy h:m tt","MM/dd/yyyy h:mm:ss tt","MM/dd/yyyy h:m:ss tt",  "MM/dd/yyyy hh:mm:ss tt",
        "MM/dd/yyyy tt ", "MM/dd/yyyy tt hh:mm ","MM/dd/yyyy tt h:mm","MM/dd/yyyy tt h:m","MM/dd/yyyy tt h:mm:ss","MM/dd/yyyy tt h:m:ss",  "MM/dd/yyyy tt hh:mm:ss",


        "M/dd/yyyy", "M/dd/yyyy HH:mm", "M/dd/yyyy H:mm", "M/dd/yyyy H:m","M/dd/yyyy H:mm:ss", "M/dd/yyyy H:m:ss", "M/dd/yyyy HH:mm:ss",
        "M/dd/yyyy tt", "M/dd/yyyy HH:mm tt", "M/dd/yyyy H:mm tt", "M/dd/yyyy H:m tt","M/dd/yyyy H:mm:ss tt", "M/dd/yyyy H:m:ss tt", "M/dd/yyyy HH:mm:ss tt",
        "M/dd/yyyy tt", "M/dd/yyyy hh:mm tt", "M/dd/yyyy h:mm tt", "M/dd/yyyy h:m tt","M/dd/yyyy h:mm:ss tt", "M/dd/yyyy h:m:ss tt", "M/dd/yyyy h:mm:ss tt",
        "M/dd/yyyy tt", "M/dd/yyyy hh:mm", "M/dd/yyyy tt h:mm", "M/dd/yyyy tt h:m","M/dd/yyyy tt h:mm:ss", "M/dd/yyyy tt h:m:ss", "M/dd/yyyy tt h:mm:ss",


        "MM/d/yyyy", "MM/d/yyyy HH:mm","MM/d/yyyy H:mm","MM/d/yyyy H:m","MM/d/yyyy H:mm:ss","MM/d/yyyy H:m:ss", "MM/d/yyyy HH:mm:ss",
        "MM/d/yyyy tt", "MM/d/yyyy HH:mm tt","MM/d/yyyy H:mm tt","MM/d/yyyy H:m tt","MM/d/yyyy H:mm:ss tt","MM/d/yyyy H:m:ss tt", "MM/d/yyyy HH:mm:ss tt",
        "MM/d/yyyy tt", "MM/d/yyyy hh:mm tt","MM/d/yyyy h:mm tt","MM/d/yyyy h:m tt","MM/d/yyyy h:mm:ss tt","MM/d/yyyy h:m:ss tt", "MM/d/yyyy hh:mm:ss tt",
        "MM/d/yyyy tt", "MM/d/yyyy tt hh:mm","MM/d/yyyy tt h:mm","MM/d/yyyy tt h:m","MM/d/yyyy tt h:mm:ss","MM/d/yyyy h:m:ss tt", "MM/d/yyyy tt hh:mm:ss",

        "M/d/yyyy", "M/d/yyyy HH:mm","M/d/yyyy H:mm","M/d/yyyy H:m","M/d/yyyy H:mm:ss","M/d/yyyy H:m:ss", "M/d/yyyy HH:mm:ss",
        "M/d/yyyy tt", "M/d/yyyy HH:mm tt","M/d/yyyy H:mm tt","M/d/yyyy H:m tt","M/d/yyyy H:mm:ss tt","M/d/yyyy H:m:ss tt", "M/d/yyyy HH:mm:ss tt",
        "M/d/yyyy tt", "M/d/yyyy hh:mm tt","M/d/yyyy h:mm tt","M/d/yyyy h:m tt","M/d/yyyy h:mm:ss tt","M/d/yyyy h:m:ss tt", "M/d/yyyy hh:mm:ss tt",
        "M/d/yyyy tt", "M/d/yyyy tt hh:mm","M/d/yyyy tt h:mm","M/d/yyyy tt h:m","M/d/yyyy tt h:mm:ss","M/d/yyyy tt h:m:ss", "M/d/yyyy tt hh:mm:ss"
        };

        try
        {
            string _sUpload = "Web/upload";
            string _sFileName = Func.RQ(Request["FileName"]).Trim();
            string _sServerFilePath = "~/" + _sUpload + "/" + _sFileName;
            if (WebFunc.CheckFileExists(this.Page, _sServerFilePath))
            {
                String _sPath = Server.MapPath("~/Web/upload/");
                string _sFilePath = _sPath + _sFileName;
                string _sSheetName = WebFunc.ExcelSheetName(_sFilePath, WebFunc.EXCELVersion.EXCEL2003);
                DataSet _oDs = WebFunc.ExcelToDS(_sFilePath, WebFunc.EXCELVersion.EXCEL2003, _sSheetName, true);
                foreach (DataRow _oDr in _oDs.Tables[0].Rows)
                {
                    bool _bUpdate = false;

                    BundleMapping _oBundleMapping = BundleMappingRepositoryBase.CreateEntityInstanceObject();
                    if (_oDr["id"] != null)
                    {

                        string _sId = DR(_oDr["id"]).Trim().Replace("'", string.Empty).Replace(",", string.Empty);
                        int _iId;
                        if (int.TryParse(_sId, out _iId))
                        {
                            _oBundleMapping.SetId(_iId);
                            _oBundleMapping.Load(_iId);
                            if (_oBundleMapping.Retrieve())
                            {
                                _bUpdate = true;
                            }
                        }

                    }
                    string _sActive = DR(_oDr["active"]).Trim().Replace("'", string.Empty).Replace(",", string.Empty);
                    bool _bActive;
                    if (bool.TryParse(_sActive, out _bActive))
                    {
                        _oBundleMapping.SetActive(_bActive);
                    }

                    string _sBundle_name = DR(_oDr["bundle_name"]).Trim().Replace("'", string.Empty).Replace(",", string.Empty);
                    _oBundleMapping.SetBundle_name(_sBundle_name);
                    {
                        DateTime _dCdate;
                        if (DateTime.TryParseExact(DR(_oDr["cdate"]), _oFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dCdate))
                            _oBundleMapping.SetCdate(_dCdate);
                        else
                            _oBundleMapping.SetCdate(null);
                    }
                    string _sCid = DR(_oDr["cid"]).Trim().Replace("'", string.Empty).Replace(",", string.Empty);
                    _oBundleMapping.SetCid(_sCid);

                    {
                        DateTime _dDdate;
                        if (DateTime.TryParseExact(DR(_oDr["ddate"]), _oFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dDdate))
                            _oBundleMapping.SetDdate(_dDdate);
                        else
                            _oBundleMapping.SetDdate(null);
                    }
                    string _sDid = DR(_oDr["did"]).Trim().Replace("'", string.Empty).Replace(",", string.Empty);
                    _oBundleMapping.SetDid(_sDid);

                    {
                        DateTime _dEDate;
                        if (DateTime.TryParseExact(DR(_oDr["edate"]), _oFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dEDate))
                            _oBundleMapping.SetEdate(_dEDate);
                        else
                            _oBundleMapping.SetEdate(null);
                    }

                    string _sNormal_rebate_type = DR(_oDr["normal_rebate_type"]).Trim().Replace("'", string.Empty).Replace(",", string.Empty);
                    _oBundleMapping.SetNormal_rebate_type(_sNormal_rebate_type);

                     string _sProgram = DR(_oDr["program"]).Trim().Replace("'", string.Empty).Replace(",", string.Empty);
                    _oBundleMapping.SetProgram(_sProgram);

                    string _sRate_plan = DR(_oDr["rate_plan"]).Trim().Replace("'", string.Empty).Replace(",", string.Empty);
                    _oBundleMapping.SetRate_plan(_sRate_plan);

                    string _sHs_model= DR(_oDr["hs_model"]).Trim().Replace("'", string.Empty).Replace(",", string.Empty);
                    _oBundleMapping.SetHs_model(_sHs_model);

                    string _sIssue_type = DR(_oDr["issue_type"]).Trim().Replace("'", string.Empty).Replace(",", string.Empty);
                    _oBundleMapping.SetIssue_type(_sIssue_type);

                    {
                        DateTime _dSdate;
                        if (DateTime.TryParseExact(DR(_oDr["sdate"]), _oFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dSdate))
                            _oBundleMapping.SetSdate(_dSdate);
                        else
                        {
                            _oBundleMapping.SetSdate(null);
                        }
                    }

                    string _sVas_field = DR(_oDr["vas_field"]).Trim().Replace("'", string.Empty).Replace(",", string.Empty);
                    _oBundleMapping.SetVas_field(_sVas_field);

                    if((_oBundleMapping.GetProgram().Equals(string.Empty) && 
                        _oBundleMapping.GetRate_plan().Equals(string.Empty) && 
                        _oBundleMapping.GetHs_model().Equals(string.Empty) && 
                        _oBundleMapping.GetIssue_type().Equals(string.Empty) && 
                        _oBundleMapping.GetBundle_name().Equals(string.Empty) &&
                        _oBundleMapping.GetNormal_rebate_type().Equals(string.Empty)) || 
                        _oBundleMapping.GetVas_field().Equals(string.Empty))
                    {
                        //no need to cater the empty excel row
                    }
                    else  if (_bUpdate)
                    {
                        _oBundleMapping.Save();
                    }
                    else
                    {
                        BundleMappingBal.InsertWithOutLastID(SYSConn<MSSQLConnect>.Connect(), _oBundleMapping);
                    }

                }
            }
        }
        catch (Exception Exp)
        {
            string Error = Exp.ToString();

        }
    }

    #region GetDB
    public static MSSQLConnect GetDB()
    {
        MSSQLConnect _oDB = new MSSQLConnect();
        _oDB.bWithNoLock = true;
        _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion


    public void RunJavascriptFunc(string x_sFunc)
    {
        string _sFunc = ((x_sFunc.IndexOf(';') > 0) ? x_sFunc : x_sFunc + ";");
        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sFunc + (new Random()).Next(1, 1000).ToString()+Guid.NewGuid().ToString(), string.Format("<script>{0}</script>", _sFunc), false);
    }

}
