using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Globalization;
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

public partial class Web_SpecialPremiumImportAction : NEURON.WEB.UI.BasePage
{

    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion

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

    protected void Page_Load(object sender, EventArgs e){
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
    }

    protected void submit_Click(object sender, EventArgs e){
        Boolean _bFileOK = false;
        String _sPath = Server.MapPath("~/Web/upload/");
        string _sFilePath = string.Empty;
        if (ExcelUpload.PostedFile != null){
            if (ExcelUpload.HasFile){
                _sFilePath += _sPath + ExcelUpload.FileName;
                String _sFileExtension = System.IO.Path.GetExtension(ExcelUpload.FileName).ToLower();
                String[] allowedExtensions = { ".xls" };
                for (int i = 0; i < allowedExtensions.Length; i++){
                    if (_sFileExtension == allowedExtensions[i])
                        _bFileOK = true;
                }
            }

            if (ExcelUpload.PostedFile.ContentLength > 10240000)
                _bFileOK = false;
            if (_bFileOK){
                try{
                    string _sExcelVersion = Request["excelversion"].ToString();
                    string _sServerFilePath = "~/Web/upload/" + ExcelUpload.FileName;
                    if (WebFunc.CheckFileExists(this.Page, _sServerFilePath)) { WebFunc.DeleteFile(this.Page, _sServerFilePath); }
                    ExcelUpload.PostedFile.SaveAs(_sFilePath);
                    if (WebFunc.CheckFileExists(this.Page, _sServerFilePath)) { InsertSpecialPremiumField(_sFilePath, _sExcelVersion); }
                } catch (Exception exp){
                    Logger.DebugFormat(exp.ToString());
                    string _sError = "<SCRIPT>alert('ERROR : Excel file error! ');</SCRIPT>";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "ERROR 10M", _sError, false);
                }
            }
            else {
                string _sError = "<SCRIPT>alert('ERROR : Excel file size cannot larger than 10M! ');</SCRIPT>";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ERROR 10M", _sError, false);
            }
        }
    }

    #region DuplicateRecord
    public bool bDuplicateRecord(SpecialPremium x_oSpecialPremium){
        global::System.Collections.Generic.List<SearchItem> _oSearchItemList = new global::System.Collections.Generic.List<SearchItem>();
        if (!string.IsNullOrEmpty(x_oSpecialPremium.GetRate_plan())) _oSearchItemList.Add(new SearchItem(SpecialPremium.Para.rate_plan, x_oSpecialPremium.GetRate_planTable().IsNullable, (new global::System.Collections.Generic.List<string> { x_oSpecialPremium.rate_plan.ToString().Trim() }), string.Empty, " AND ", string.Empty));
        if (!string.IsNullOrEmpty(x_oSpecialPremium.GetCon_per())) _oSearchItemList.Add(new SearchItem(SpecialPremium.Para.con_per, x_oSpecialPremium.GetCon_perTable().IsNullable, (new global::System.Collections.Generic.List<string> { x_oSpecialPremium.con_per.ToString().Trim() }), string.Empty, " AND ", string.Empty));
        if (!string.IsNullOrEmpty(x_oSpecialPremium.GetS_premium())) _oSearchItemList.Add(new SearchItem(SpecialPremium.Para.s_premium, x_oSpecialPremium.GetS_premiumTable().IsNullable, (new global::System.Collections.Generic.List<string> { x_oSpecialPremium.s_premium.ToString().Trim() }), string.Empty, " AND ", string.Empty));
        if (!string.IsNullOrEmpty(x_oSpecialPremium.GetCid())) _oSearchItemList.Add(new SearchItem(SpecialPremium.Para.cid, x_oSpecialPremium.GetCidTable().IsNullable, (new global::System.Collections.Generic.List<string> { x_oSpecialPremium.cid.ToString().Trim() }), string.Empty, " AND ", string.Empty));
        global::System.Data.SqlClient.SqlDataReader _oReader = BusinessTradeDal.DrSearch(_oSearchItemList,string.Empty, -1, -1, string.Empty, string.Empty, true);
        if (_oReader != null) { if (_oReader.Read()) { _oReader.Close(); _oReader.Dispose(); return true; } }
        if (_oReader != null) _oReader.Close(); _oReader.Dispose();
        return false;
    }
    #endregion

    public void InsertSpecialPremiumField(string _sFilePath, string _sExcelVersion){
        string _sSheetName = WebFunc.ExcelSheetName(_sFilePath, _sExcelVersion.Trim().ToUpper());
        if (_sSheetName.Trim() != string.Empty)
        {
            DataSet _oDS = WebFunc.ExcelToDS(_sFilePath, _sExcelVersion.Trim().ToUpper(), _sSheetName, false);
            Hashtable _oFields = WebFunc.GetExcelFieldListByDataSet(_oDS);
            bool _bRollBack = false;

            int _iRow = 0;
            foreach (DataRow _oRw in _oDS.Tables[0].Rows)
            {
                if (_iRow.Equals(0)) { _iRow += 1; continue; }
                _iRow += 1;
                SpecialPremium _oSpecialPremium = new SpecialPremium(SYSConn<MSSQLConnect>.Connect());
                bool _bUpdate = false;
                if (_oFields.Contains(SpecialPremium.Para.mid))
                {
                    string _sMid = _oRw[((ExcelFieldCharacter)_oFields[SpecialPremium.Para.mid]).DataSetPoint].ToString().Trim();
                    int _iMid;
                    if (int.TryParse(_sMid, out _iMid))
                    {
                        _oSpecialPremium.SetMid(_iMid);
                        if (_oSpecialPremium.Retrieve())
                        {
                            _bUpdate = true;
                        }
                    }
                }


                if (_oFields.Contains(SpecialPremium.Para.rate_plan))
                    _oSpecialPremium.SetRate_plan(_oRw[((ExcelFieldCharacter)_oFields[SpecialPremium.Para.rate_plan]).DataSetPoint].ToString().Trim());
                if (_oFields.Contains(SpecialPremium.Para.con_per))
                    _oSpecialPremium.SetCon_per(_oRw[((ExcelFieldCharacter)_oFields[SpecialPremium.Para.con_per]).DataSetPoint].ToString().Trim());
                if (_oFields.Contains(SpecialPremium.Para.rate_plan))
                    _oSpecialPremium.SetS_premium(_oRw[((ExcelFieldCharacter)_oFields[SpecialPremium.Para.s_premium]).DataSetPoint].ToString().Trim());
                if (_oFields.Contains(SpecialPremium.Para.cid))
                    _oSpecialPremium.SetCid(_oRw[((ExcelFieldCharacter)_oFields[SpecialPremium.Para.cid]).DataSetPoint].ToString().Trim());


                if (_oFields.Contains(SpecialPremium.Para.active))
                {
                    string _sActive = _oRw[((ExcelFieldCharacter)_oFields[SpecialPremium.Para.active]).DataSetPoint].ToString().Trim();
                    bool _bActive;
                    if (bool.TryParse(_sActive, out _bActive))
                    {
                        _oSpecialPremium.SetActive(_bActive);
                    }
                }

                {
                    DateTime _dCdate;
                    if (DateTime.TryParseExact(_oRw[((ExcelFieldCharacter)_oFields[SpecialPremium.Para.cdate]).DataSetPoint].ToString().Trim(), _oFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dCdate))
                        _oSpecialPremium.SetCdate(_dCdate);
                    else
                        _oSpecialPremium.SetCdate(null);
                }

                if (_bUpdate)
                {
                    _oSpecialPremium.Save();
                }
                else if (!bDuplicateRecord(_oSpecialPremium))
                {
                    SpecialPremiumBal.InsertWithOutLastID(SYSConn<MSSQLConnect>.Connect(),  _oSpecialPremium);
                }
            }

            string _sMsg = string.Empty;
            _sMsg = "<SCRIPT>alert('Upload Finlish!');</SCRIPT>";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Success", _sMsg, false);



        }
        else
        {
            string _sError = "<SCRIPT>alert('ERROR : Cannot upload this excel file : \n ');</SCRIPT>";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "ERROR", _sError, false);
        }
    }
}
