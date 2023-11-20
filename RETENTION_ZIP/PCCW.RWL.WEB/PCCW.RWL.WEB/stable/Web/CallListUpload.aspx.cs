using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;
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
using System.Globalization;


public partial class Web_CallListUpload : System.Web.UI.Page
{

    string[] _oFormat = new string[] { 
        "dd/MM/yyyy", "dd/MM/yyyy HH:mm","dd/MM/yyyy H:mm","dd/MM/yyyy H:m","dd/MM/yyyy H:mm:ss","dd/MM/yyyy H:m:ss",  "dd/MM/yyyy HH:mm:ss",
        "dd/MM/yyyy tt ", "dd/MM/yyyy HH:mm tt ","dd/MM/yyyy H:mm tt","dd/MM/yyyy H:m tt","dd/MM/yyyy H:mm:ss tt","dd/MM/yyyy H:m:ss tt",  "dd/MM/yyyy HH:mm:ss tt",
        "dd/MM/yyyy tt ", "dd/MM/yyyy hh:mm tt ","dd/MM/yyyy h:mm tt","dd/MM/yyyy h:m tt","dd/MM/yyyy h:mm:ss tt","dd/MM/yyyy h:m:ss tt",  "dd/MM/yyyy hh:mm:ss tt",
        "dd/MM/yyyy tt ", "dd/MM/yyyy tt hh:mm ","dd/MM/yyyy tt h:mm","dd/MM/yyyy tt h:m","dd/MM/yyyy tt h:mm:ss","dd/MM/yyyy tt h:m:ss",  "dd/MM/yyyy tt hh:mm:ss",


        "dd/M/yyyy", "dd/M/yyyy HH:mm", "dd/M/yyyy H:mm", "dd/M/yyyy H:m","dd/M/yyyy H:mm:ss", "dd/M/yyyy H:m:ss", "dd/M/yyyy HH:mm:ss",
        "dd/M/yyyy tt", "dd/M/yyyy HH:mm tt", "dd/M/yyyy H:mm tt", "dd/M/yyyy H:m tt","dd/M/yyyy H:mm:ss tt", "dd/M/yyyy H:m:ss tt", "dd/M/yyyy HH:mm:ss tt",
        "dd/M/yyyy tt", "dd/M/yyyy hh:mm tt", "dd/M/yyyy h:mm tt", "dd/M/yyyy h:m tt","dd/M/yyyy h:mm:ss tt", "dd/M/yyyy h:m:ss tt", "dd/M/yyyy h:mm:ss tt",
        "dd/M/yyyy tt", "dd/M/yyyy hh:mm", "dd/M/yyyy tt h:mm", "dd/M/yyyy tt h:m","dd/M/yyyy tt h:mm:ss", "dd/M/yyyy tt h:m:ss", "dd/M/yyyy tt h:mm:ss",


        "dd/M/yyyy", "dd/M/yyyy HH:mm","dd/M/yyyy H:mm","dd/M/yyyy H:m","dd/M/yyyy H:mm:ss","dd/M/yyyy H:m:ss", "dd/M/yyyy HH:mm:ss",
        "dd/M/yyyy tt", "dd/M/yyyy HH:mm tt","dd/M/yyyy H:mm tt","dd/M/yyyy H:m tt","dd/M/yyyy H:mm:ss tt","dd/M/yyyy H:m:ss tt", "dd/M/yyyy HH:mm:ss tt",
        "dd/M/yyyy tt", "dd/M/yyyy hh:mm tt","dd/M/yyyy h:mm tt","dd/M/yyyy h:m tt","dd/M/yyyy h:mm:ss tt","dd/M/yyyy h:m:ss tt", "dd/M/yyyy hh:mm:ss tt",
        "dd/M/yyyy tt", "dd/M/yyyy tt hh:mm","dd/M/yyyy tt h:mm","dd/M/yyyy tt h:m","dd/M/yyyy tt h:mm:ss","dd/M/yyyy h:m:ss tt", "dd/M/yyyy tt hh:mm:ss",

        "d/M/yyyy", "d/M/yyyy HH:mm","d/M/yyyy H:mm","d/M/yyyy H:m","d/M/yyyy H:mm:ss","d/M/yyyy H:m:ss", "d/M/yyyy HH:mm:ss",
        "d/M/yyyy tt", "d/M/yyyy HH:mm tt","d/M/yyyy H:mm tt","d/M/yyyy H:m tt","d/M/yyyy H:mm:ss tt","d/M/yyyy H:m:ss tt", "d/M/yyyy HH:mm:ss tt",
        "d/M/yyyy tt", "d/M/yyyy hh:mm tt","d/M/yyyy h:mm tt","d/M/yyyy h:m tt","d/M/yyyy h:mm:ss tt","d/M/yyyy h:m:ss tt", "d/M/yyyy hh:mm:ss tt",
        "d/M/yyyy tt", "d/M/yyyy tt hh:mm","d/M/yyyy tt h:mm","d/M/yyyy tt h:m","d/M/yyyy tt h:mm:ss","d/M/yyyy tt h:m:ss", "d/M/yyyy tt hh:mm:ss"
        };

    SessionFactory<MSSQLConnect> _oSessionFactory = new SessionFactory<MSSQLConnect>();
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

        RWLFramework.DataBaseConfigSetting();
        //WebFunc.PrivilegeCheck(this.Page);
        if (!IsPostBack) InitFrame();
        CallListUploadProfileConnection();
    }

    private void InitFrame()
    {
       
    }
    protected void SubmitBtn_Click(object sender, EventArgs e)
    {
        Boolean _bFileOK = false;
        String _sPath = Server.MapPath("~/Web/upload/");
        string _sFilePath = string.Empty;
        if (ExcelUpload.PostedFile != null)
        {
            if (ExcelUpload.HasFile)
            {
                _sFilePath += _sPath + ExcelUpload.FileName;
                String _sFileExtension = System.IO.Path.GetExtension(ExcelUpload.FileName).ToLower();
                String[] allowedExtensions = { ".xls" };

                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (_sFileExtension == allowedExtensions[i])
                    {
                        _bFileOK = true;
                    }
                }
            }

            if (ExcelUpload.PostedFile.ContentLength > 10240000)
            {
                _bFileOK = false;
            }
            if (_bFileOK)
            {
                try
                {
                    string _sExcelVersion = excelversion.SelectedValue;

                    string _sServerFilePath = "~/Web/upload/" + ExcelUpload.FileName;
                    if (WebFunc.CheckFileExists(this.Page, _sServerFilePath)) { WebFunc.DeleteFile(this.Page, _sServerFilePath); }
                    ExcelUpload.PostedFile.SaveAs(_sFilePath);
                    if (WebFunc.CheckFileExists(this.Page, _sServerFilePath))
                    {
                        if (PCCW.RWL.CORE.Configurator.IsUat())
                            ExcelVersion(ExcelUpload.FileName, _sExcelVersion, "true");
                        else
                            ExcelVersion(ExcelUpload.FileName, _sExcelVersion, "false");
                        AspxCallListUploadProfileGV.DataBind();
                    }
                }
                catch (Exception exp)
                {
                    string _sError = string.Format("<script>ALERT('ERROR : Cannot upload this excel file :  {0} ');</script>", exp.ToString());
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "ERROR" + exp.ToString(), _sError, false);
                }
            }
            else
            {
                string _sError = "<script>ALERT('ERROR : Excel file size cannot larger than 10M! ');</script>";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ERROR 10M", _sError, false);
            }
        }
    }
    protected string DR(object x_oObj)
    {
        if (x_oObj == null) return string.Empty;
        return x_oObj.ToString();
    }

    public MSSQLConnect GetDB()
    {
        return SYSConn<MSSQLConnect>.Connect();
    }

    private void ExcelVersion(string x_sFileName, string x_sExcelVersion, string x_sIsUat)
    {

         try
         {
             string _sUpload = "Web/upload";
             string _sFileName = x_sFileName;
             string _sExcelVersion = x_sExcelVersion;
             string _sServerFilePath = "~/" + _sUpload + "/" + _sFileName;
             long _lCallListProgramID = 0;

             if (WebFunc.CheckFileExists(this.Page, _sServerFilePath) && long.TryParse(call_list_program_id.Text, out _lCallListProgramID))
             {
                 String _sPath = Server.MapPath("~/Web/upload/");
                 string _sFilePath = _sPath + _sFileName;
                 string _sSheetName = WebFunc.ExcelSheetName(_sFilePath, _sExcelVersion.Trim().ToUpper());
                 StringBuilder _oFilter = new StringBuilder();
                 DataSet _oDs = WebFunc.ExcelToDS(_sFilePath, " * ", _sExcelVersion.Trim().ToUpper(), _sSheetName, true, _oFilter.ToString());
                 
                 
                   ISession<MSSQLConnect> _oSession = null;
                    using (_oSession = _oSessionFactory.OpenSession())
                    using (ITransaction _oTransaction = _oSession.BeginTransaction())
                    {
                        
                        bool _bRollBack = false;
                        foreach (DataRow _oDr in _oDs.Tables[0].Rows)
                        {
                            CallListUploadMrtNo _oCallListUploadMrtNo = CallListUploadMrtNoRepository.CreateEntityInstanceObject(GetDB());
                            string _sMrt_no = DR(_oDr[CallListUploadMrtNo.Para.mrt_no]).Trim().Replace("'", string.Empty).Replace(",", string.Empty);
                            if (!string.IsNullOrEmpty(_sMrt_no))
                            {
                                _oCallListUploadMrtNo.SetCall_list_program_id(_lCallListProgramID);
                                _oCallListUploadMrtNo.SetMrt_no(_sMrt_no);
                                _oCallListUploadMrtNo.SetCdate(DateTime.Now);

                                if (!_oSession.Insert(_oCallListUploadMrtNo))
                                {
                                    _bRollBack = true;
                                    break;
                                }
                            }
                        }

                        CallListUploadProfile _oCallListUploadProfile = CallListUploadProfileRepository.CreateEntityInstanceObject(GetDB());
                        _oCallListUploadProfile.SetCall_list_program_id(_lCallListProgramID);
                        _oCallListUploadProfile.SetActive(true);
                        DateTime _dSdate;

                        if (DateTime.TryParseExact(sdate.DateTimeValue, _oFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dSdate))
                        {
                            _oCallListUploadProfile.SetSdate(_dSdate);
                        }
                        DateTime _dEdate;
                        if (DateTime.TryParseExact(edate.DateTimeValue, _oFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dEdate))
                        {
                            _oCallListUploadProfile.SetEdate(_dEdate);
                        }
                        _oCallListUploadProfile.SetIssue_type(issue_type.SelectedValue);
                        if (!_oSession.Insert(_oCallListUploadProfile))
                        {
                            _bRollBack = true;
                        }

                        if (!_bRollBack && _oDs.Tables[0].Rows.Count>0)
                            _oTransaction.Commit();
                        else
                            _oTransaction.Rollback();

                    }
             }
         }
         catch (Exception Exp)
         {
             string Error = Exp.ToString();

         }
    }


    protected void AspxCallListUploadProfileGV_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            GridView _oGridView = (GridView)sender;
            GridViewRow _oGridViewRow = (GridViewRow)_oGridView.Rows[e.RowIndex];

            TextBox _oCall_list_program_id = (TextBox)_oGridViewRow.FindControl("call_list_program_id");
            TextBox _oSdate = (TextBox)_oGridViewRow.FindControl("sdate");
            TextBox _oEdate = (TextBox)_oGridViewRow.FindControl("edate");

            string _sCall_list_program_id = _oCall_list_program_id.Text;
            string _sSdate = _oSdate.Text;
            string _sEdate = _oEdate.Text;

            long _lCall_list_program_id;
            if (long.TryParse(_oCall_list_program_id.Text, out _lCall_list_program_id))
                e.NewValues["call_list_program_id"] = _lCall_list_program_id;
            else
                e.NewValues["call_list_program_id"] = null;

            DateTime _dSdate;
            if (DateTime.TryParseExact(_sSdate, _oFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dSdate))
                e.NewValues["sdate"] = _dSdate;
            else
                e.NewValues["sdate"] = null;

            DateTime _dEdate;
            if (DateTime.TryParseExact(_sEdate, _oFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dEdate))
                e.NewValues["edate"] = _dEdate;
            else
                e.NewValues["edate"] = null;

        }
    }

    protected void CallListUploadProfileConnection()
    {
        CallListUploadProfileObj.ConnectionString = GetDB().ConnectionStr;
    }

    protected void CallListUploadProfileObj_Init(object sender, EventArgs e)
    {
        CallListUploadProfileConnection();
    }
    protected void uploadto_SelectedIndexChanged(object sender, EventArgs e)
    {
        CallListUploadProfileConnection();
        CallListUploadProfileObj.DataBind();
    }
}
