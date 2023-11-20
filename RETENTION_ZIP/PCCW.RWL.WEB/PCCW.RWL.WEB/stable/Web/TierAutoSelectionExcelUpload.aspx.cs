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
using System.IO;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using log4net;
using System.Reflection;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

public partial class TierAutoSelectionExcelUpload : NEURON.WEB.UI.BasePage
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
        TierViewControl.Instance().Release();
    }

    protected void submit_Click(object sender, EventArgs e)
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
                for (int i = 0; i < allowedExtensions.Length; i++){
                    if (_sFileExtension == allowedExtensions[i])
                        _bFileOK = true;
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
                    string _sExcelVersion = Request["excelversion"].ToString();
                    string _sServerFilePath = "~/Web/upload/" + ExcelUpload.FileName;
                    if (WebFunc.CheckFileExists(this.Page, _sServerFilePath)) { WebFunc.DeleteFile(this.Page, _sServerFilePath); }
                    ExcelUpload.PostedFile.SaveAs(_sFilePath);
                    TierViewControl.Instance().SetFilename(ExcelUpload.FileName);
                    if (WebFunc.CheckFileExists(this.Page, _sServerFilePath))
                    {
                        string _sSheetName = WebFunc.ExcelSheetName(_sFilePath, _sExcelVersion.Trim().ToUpper());
                        if (_sSheetName.Trim() != string.Empty)
                        {
                            DataSet _oDS = WebFunc.ExcelToDS(_sFilePath, _sExcelVersion.Trim().ToUpper(), _sSheetName, false);
                            AutoSelectionPropertyBal _oAutoSelectionPropertyBal = new AutoSelectionPropertyBal();
                            _oAutoSelectionPropertyBal.UploadTierExcel(_oDS);
                            WebFunc.DeleteFile(this.Page, _sServerFilePath);

                            string _sMsg = string.Empty;
                            _sMsg = "<script>alert('Upload Finlish!');</script>";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Success", _sMsg, false);
                            file_name.Text = ExcelUpload.FileName;

                            if (_oAutoSelectionPropertyBal.GetSuccessIn() > 0)
                                Response.Redirect("~/Web/TierTableUploadCheckResult.aspx");

                            upload_success_records.Text = _oAutoSelectionPropertyBal.GetSuccessIn().ToString();
                            upload_fail_records.Text = _oAutoSelectionPropertyBal.GetErrRecord().ToString();
                            duplicate_records.Text = _oAutoSelectionPropertyBal.GetDupRecord().ToString();
                        }
                        else
                        {
                            file_name.Text = ExcelUpload.FileName;
                            upload_success_records.Text = "0";
                            upload_fail_records.Text = "0";
                            duplicate_records.Text = "0";
                            string _sError = "<script>alert('ERROR : Cannot upload this excel file : \n ');</script>";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "ERROR", _sError, false);
                        }
                    }
                }
                catch (Exception exp)
                {
                    Logger.DebugFormat(exp.ToString());
                    string _sError = "<script>alert('ERROR : Excel file error! ');</script>";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "ERROR 10M", _sError, false);
                }
            }
            else
            {
                string _sError = "<script>alert('ERROR : Excel file size cannot larger than 10M! ');</script>";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ERROR 10M", _sError, false);
            }
        }
    }
}
