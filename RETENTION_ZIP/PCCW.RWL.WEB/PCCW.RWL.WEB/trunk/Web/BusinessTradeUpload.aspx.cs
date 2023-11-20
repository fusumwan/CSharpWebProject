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
using System.IO;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using log4net;
using System.Reflection;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using System.Text;

public partial class BusinessTradeUpload : NEURON.WEB.UI.BasePage
{
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion
    string[] n_sDateTimeList = new string[] { 
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
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (_sFileExtension == allowedExtensions[i])
                        _bFileOK = true;
                }
            }

            if (ExcelUpload.PostedFile.ContentLength > 10240000)
                _bFileOK = false;
            if (_bFileOK)
            {
                try
                {
                    string _sExcelVersion = Request["excelversion"].ToString();
                    string _sServerFilePath = "~/Web/upload/" + ExcelUpload.FileName;
                    if (WebFunc.CheckFileExists(this.Page, _sServerFilePath)) { WebFunc.DeleteFile(this.Page, _sServerFilePath); }
                    ExcelUpload.PostedFile.SaveAs(_sFilePath);
                    if (WebFunc.CheckFileExists(this.Page, _sServerFilePath)) { InsertTradField(_sFilePath, _sExcelVersion); }
                }
                catch (Exception exp)
                {
                    Logger.DebugFormat(exp.ToString());
                    string _sError = "<SCRIPT>alert('ERROR : Excel file error! ');</SCRIPT>";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "ERROR 10M", _sError, false);
                }
            }
            else
            {
                string _sError = "<SCRIPT>alert('ERROR : Excel file size cannot larger than 10M! ');</SCRIPT>";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ERROR 10M", _sError, false);
            }
        }
    }
    #region DuplicateRecord
    public bool bDuplicateRecord(BusinessTrade x_oBusinessTrade)
    {
        global::System.Collections.Generic.List<SearchItem> _oSearchItemList = new global::System.Collections.Generic.List<SearchItem>();
        if (!string.IsNullOrEmpty(x_oBusinessTrade.GetProgram())) _oSearchItemList.Add(new SearchItem(BusinessTrade.Para.program, x_oBusinessTrade.GetProgramTable().IsNullable, (new global::System.Collections.Generic.List<string> { x_oBusinessTrade.program.ToString().Trim() }), string.Empty, " AND ", string.Empty));
        if (!string.IsNullOrEmpty(x_oBusinessTrade.GetNormal_rebate_type())) _oSearchItemList.Add(new SearchItem(BusinessTrade.Para.normal_rebate_type, x_oBusinessTrade.GetNormal_rebate_typeTable().IsNullable, (new global::System.Collections.Generic.List<string> { x_oBusinessTrade.normal_rebate_type.ToString().Trim() }), string.Empty, " AND ", string.Empty));

        if (!string.IsNullOrEmpty(x_oBusinessTrade.GetRate_plan())) _oSearchItemList.Add(new SearchItem(BusinessTrade.Para.rate_plan, x_oBusinessTrade.GetRate_planTable().IsNullable, (new global::System.Collections.Generic.List<string> { x_oBusinessTrade.rate_plan.ToString().Trim() }), string.Empty, " AND ", string.Empty));
        if (!string.IsNullOrEmpty(x_oBusinessTrade.GetCon_per())) _oSearchItemList.Add(new SearchItem(BusinessTrade.Para.con_per, x_oBusinessTrade.GetCon_perTable().IsNullable, (new global::System.Collections.Generic.List<string> { x_oBusinessTrade.con_per.ToString().Trim() }), string.Empty, " AND ", string.Empty));

        if (!string.IsNullOrEmpty(x_oBusinessTrade.GetRebate())) _oSearchItemList.Add(new SearchItem(BusinessTrade.Para.rebate, x_oBusinessTrade.GetRebateTable().IsNullable, (new global::System.Collections.Generic.List<string> { x_oBusinessTrade.rebate.ToString().Trim() }), string.Empty, " AND ", string.Empty));
        if (!string.IsNullOrEmpty(x_oBusinessTrade.GetFree_mon())) _oSearchItemList.Add(new SearchItem(BusinessTrade.Para.free_mon, x_oBusinessTrade.GetFree_monTable().IsNullable, (new global::System.Collections.Generic.List<string> { x_oBusinessTrade.free_mon.ToString().Trim() }), string.Empty, " AND ", string.Empty));

        if (!string.IsNullOrEmpty(x_oBusinessTrade.GetHs_model())) _oSearchItemList.Add(new SearchItem(BusinessTrade.Para.hs_model, x_oBusinessTrade.GetHs_modelTable().IsNullable, (new global::System.Collections.Generic.List<string> { x_oBusinessTrade.hs_model.ToString().Trim() }), string.Empty, " AND ", string.Empty));
        if (!string.IsNullOrEmpty(x_oBusinessTrade.GetHs_model_name())) _oSearchItemList.Add(new SearchItem(BusinessTrade.Para.hs_model_name, x_oBusinessTrade.GetHs_model_nameTable().IsNullable, (new global::System.Collections.Generic.List<string> { x_oBusinessTrade.hs_model_name.ToString().Trim() }), string.Empty, " AND ", string.Empty));

        if (!string.IsNullOrEmpty(x_oBusinessTrade.GetPremium_1())) _oSearchItemList.Add(new SearchItem(BusinessTrade.Para.premium_1, x_oBusinessTrade.GetPremium_1Table().IsNullable, (new global::System.Collections.Generic.List<string> { x_oBusinessTrade.premium_1.ToString().Trim() }), string.Empty, " AND ", string.Empty));
        if (!string.IsNullOrEmpty(x_oBusinessTrade.GetPremium_2())) _oSearchItemList.Add(new SearchItem(BusinessTrade.Para.premium_2, x_oBusinessTrade.GetPremium_2Table().IsNullable, (new global::System.Collections.Generic.List<string> { x_oBusinessTrade.premium_2.ToString().Trim() }), string.Empty, " AND ", string.Empty));

        if (!string.IsNullOrEmpty(x_oBusinessTrade.GetTrade_field())) _oSearchItemList.Add(new SearchItem(BusinessTrade.Para.trade_field, x_oBusinessTrade.GetTrade_fieldTable().IsNullable, (new global::System.Collections.Generic.List<string> { x_oBusinessTrade.trade_field.ToString().Trim() }), string.Empty, " AND ", string.Empty));
        if (!string.IsNullOrEmpty(x_oBusinessTrade.GetBundle_name())) _oSearchItemList.Add(new SearchItem(BusinessTrade.Para.bundle_name, x_oBusinessTrade.GetBundle_nameTable().IsNullable, (new global::System.Collections.Generic.List<string> { x_oBusinessTrade.bundle_name.ToString().Trim() }), string.Empty, " AND ", string.Empty));

        if (!string.IsNullOrEmpty(x_oBusinessTrade.GetPlan_fee())) _oSearchItemList.Add(new SearchItem(BusinessTrade.Para.plan_fee, x_oBusinessTrade.GetPlan_feeTable().IsNullable, (new global::System.Collections.Generic.List<string> { x_oBusinessTrade.plan_fee.ToString().Trim() }), string.Empty, " AND ", string.Empty));
        if (!string.IsNullOrEmpty(x_oBusinessTrade.GetChannel())) _oSearchItemList.Add(new SearchItem(BusinessTrade.Para.channel, x_oBusinessTrade.GetChannelTable().IsNullable, (new global::System.Collections.Generic.List<string> { x_oBusinessTrade.channel.ToString().Trim() }), string.Empty, " AND ", string.Empty));

        if (x_oBusinessTrade.GetSdate() != null) _oSearchItemList.Add(new SearchItem(BusinessTrade.Para.sdate, x_oBusinessTrade.GetSdateTable().IsNullable, (new global::System.Collections.Generic.List<string> { Convert.ToDateTime(x_oBusinessTrade.GetSdate()).ToString("dd-MM-yyyy").Trim() }), string.Empty, " AND ", string.Empty));
        if (x_oBusinessTrade.GetEdate() != null) _oSearchItemList.Add(new SearchItem(BusinessTrade.Para.edate, x_oBusinessTrade.GetEdateTable().IsNullable, (new global::System.Collections.Generic.List<string> { Convert.ToDateTime(x_oBusinessTrade.GetEdate()).ToString("dd-MM-yyyy").Trim() }), string.Empty, " AND ", string.Empty));

        global::System.Data.SqlClient.SqlDataReader _oReader = BusinessTradeDal.DrSearch(_oSearchItemList, string.Empty, -1, -1, string.Empty, string.Empty, true);
        if (_oReader != null) { if (_oReader.Read()) { _oReader.Close(); _oReader.Dispose(); return true; } }
        if (_oReader != null) _oReader.Close(); _oReader.Dispose();

        return false;
    }
    #endregion
    public void InsertTradField(string _sFilePath, string _sExcelVersion)
    {
        string _sErrorMsg = string.Empty;
        string _sSheetName = WebFunc.ExcelSheetName(_sFilePath, _sExcelVersion.Trim().ToUpper(), ref _sErrorMsg);
        if (_sSheetName.Trim() != string.Empty || _sErrorMsg.Trim() == string.Empty)
        {
            if (_sSheetName.Trim() == string.Empty)
            {
                _sSheetName = "Sheet1$";
            }
            bool _bFlag = true;
            StringBuilder _oFilter = new StringBuilder();
            /*
            _oFilter.Append(" (program!='' AND program IS NOT NULL) OR  ");
            _oFilter.Append(" (normal_rebate_type!='' AND normal_rebate_type IS NOT NULL) OR  ");
            _oFilter.Append(" (rate_plan!='' AND rate_plan IS NOT NULL) OR  ");
            _oFilter.Append(" (con_per!='' AND con_per IS NOT NULL) OR  ");
            _oFilter.Append(" (rebate!='' AND rebate IS NOT NULL) OR  ");
            _oFilter.Append(" (free_mon!='' AND free_mon IS NOT NULL) OR  ");
            _oFilter.Append(" (hs_model!='' AND hs_model IS NOT NULL) OR  ");
            _oFilter.Append(" (hs_model_name!='' AND hs_model_name IS NOT NULL) OR  ");
            _oFilter.Append(" (premium_1!='' AND premium_1 IS NOT NULL) OR  ");
            _oFilter.Append(" (premium_2!='' AND premium_2 IS NOT NULL) OR  ");
            _oFilter.Append(" (trade_field!='' AND trade_field IS NOT NULL) OR  ");
            _oFilter.Append(" (bundle_name!='' AND bundle_name IS NOT NULL) ");
            */
            DataSet _oDS = WebFunc.ExcelToDS(_sFilePath, _sExcelVersion.Trim().ToUpper(), _sSheetName, false, _oFilter.ToString());

            if (_oDS == null)
            {
                _bFlag = false;
            }
            else
            {
                if (_oDS.Tables[0].Rows.Count == 0)
                {
                    _bFlag = false;
                }
            }
            if (_bFlag)
            {
                Hashtable _oFields = WebFunc.GetExcelFieldListByDataSet(_oDS);
                bool _bRollBack = false;
                int _iRow = 0;
                foreach (DataRow _oRw in _oDS.Tables[0].Rows)
                {
                    if (_iRow.Equals(0)) { _iRow += 1; continue; }
                    _iRow += 1;

                    BusinessTrade _oBusinessTrade = new BusinessTrade(SYSConn<MSSQLConnect>.Connect());
                    bool _bUpdate = false;
                    if (_oFields.Contains(BusinessTrade.Para.mid))
                    {
                        string _sMid = _oRw[((ExcelFieldCharacter)_oFields[BusinessTrade.Para.mid]).DataSetPoint].ToString().Trim();
                        int _iMid;
                        if (int.TryParse(_sMid, out _iMid))
                        {
                            _oBusinessTrade.SetMid(_iMid);
                            if (_oBusinessTrade.Retrieve())
                            {
                                _bUpdate = true;
                            }
                        }
                    }

                    if (_oFields.Contains(BusinessTrade.Para.program))
                        _oBusinessTrade.SetProgram(_oRw[((ExcelFieldCharacter)_oFields[BusinessTrade.Para.program]).DataSetPoint].ToString().Trim());
                    if (_oFields.Contains(BusinessTrade.Para.normal_rebate_type))
                        _oBusinessTrade.SetNormal_rebate_type(_oRw[((ExcelFieldCharacter)_oFields[BusinessTrade.Para.normal_rebate_type]).DataSetPoint].ToString().Trim());
                    if (_oFields.Contains(BusinessTrade.Para.rate_plan))
                        _oBusinessTrade.SetRate_plan(_oRw[((ExcelFieldCharacter)_oFields[BusinessTrade.Para.rate_plan]).DataSetPoint].ToString().Trim());
                    if (_oFields.Contains(BusinessTrade.Para.con_per))
                        _oBusinessTrade.SetCon_per(_oRw[((ExcelFieldCharacter)_oFields[BusinessTrade.Para.con_per]).DataSetPoint].ToString().Trim());
                    if (_oFields.Contains(BusinessTrade.Para.rebate))
                        _oBusinessTrade.SetRebate(_oRw[((ExcelFieldCharacter)_oFields[BusinessTrade.Para.rebate]).DataSetPoint].ToString().Trim());
                    if (_oFields.Contains(BusinessTrade.Para.free_mon))
                        _oBusinessTrade.SetFree_mon(_oRw[((ExcelFieldCharacter)_oFields[BusinessTrade.Para.free_mon]).DataSetPoint].ToString().Trim());
                    if (_oFields.Contains(BusinessTrade.Para.hs_model))
                        _oBusinessTrade.SetHs_model(_oRw[((ExcelFieldCharacter)_oFields[BusinessTrade.Para.hs_model]).DataSetPoint].ToString().Trim());
                    if (_oFields.Contains(BusinessTrade.Para.hs_model_name))
                        _oBusinessTrade.SetHs_model_name(_oRw[((ExcelFieldCharacter)_oFields[BusinessTrade.Para.hs_model_name]).DataSetPoint].ToString().Trim());
                    if (_oFields.Contains(BusinessTrade.Para.premium_1))
                        _oBusinessTrade.SetPremium_1(_oRw[((ExcelFieldCharacter)_oFields[BusinessTrade.Para.premium_1]).DataSetPoint].ToString().Trim());
                    if (_oFields.Contains(BusinessTrade.Para.premium_2))
                        _oBusinessTrade.SetPremium_2(_oRw[((ExcelFieldCharacter)_oFields[BusinessTrade.Para.premium_2]).DataSetPoint].ToString().Trim());
                    if (_oFields.Contains(BusinessTrade.Para.trade_field))
                        _oBusinessTrade.SetTrade_field(_oRw[((ExcelFieldCharacter)_oFields[BusinessTrade.Para.trade_field]).DataSetPoint].ToString().Trim());
                    if (_oFields.Contains(BusinessTrade.Para.bundle_name))
                        _oBusinessTrade.SetBundle_name(_oRw[((ExcelFieldCharacter)_oFields[BusinessTrade.Para.bundle_name]).DataSetPoint].ToString().Trim());
                    if (_oFields.Contains(BusinessTrade.Para.plan_fee))
                        _oBusinessTrade.SetPlan_fee(_oRw[((ExcelFieldCharacter)_oFields[BusinessTrade.Para.plan_fee]).DataSetPoint].ToString().Trim());
                    if (_oFields.Contains(BusinessTrade.Para.channel))
                        _oBusinessTrade.SetChannel(_oRw[((ExcelFieldCharacter)_oFields[BusinessTrade.Para.channel]).DataSetPoint].ToString().Trim());
                    if (_oFields.Contains(BusinessTrade.Para.cid))
                        _oBusinessTrade.SetCid(_oRw[((ExcelFieldCharacter)_oFields[BusinessTrade.Para.cid]).DataSetPoint].ToString().Trim());
                    if (_oFields.Contains(BusinessTrade.Para.remarks))
                        _oBusinessTrade.SetRemarks(_oRw[((ExcelFieldCharacter)_oFields[BusinessTrade.Para.remarks]).DataSetPoint].ToString().Trim());
                    if (_oFields.Contains(BusinessTrade.Para.issue_type))
                    {
                        _oBusinessTrade.SetIssue_type(_oRw[((ExcelFieldCharacter)_oFields[BusinessTrade.Para.issue_type]).DataSetPoint].ToString().Trim());
                        if (string.IsNullOrEmpty(_oBusinessTrade.GetIssue_type()) ||
                            (
                            !_oBusinessTrade.GetIssue_type().Trim().Equals("3G_RETENTION") &&
                            !_oBusinessTrade.GetIssue_type().Trim().Equals("2G_RETENTION") &&
                            !_oBusinessTrade.GetIssue_type().Trim().Equals("MOBILE_LITE") &&
                            !_oBusinessTrade.GetIssue_type().Trim().Equals("GO_WIRELESS") &&
                            !_oBusinessTrade.GetIssue_type().Trim().Equals("UPGRADE") &&
                            !_oBusinessTrade.GetIssue_type().Trim().Equals("WIN")) 
                            )
                        {
                            _oBusinessTrade.SetIssue_type("3G_RETENTION");
                        }
                    }
                    if (_oFields.Contains(BusinessTrade.Para.cdate))
                    {
                        DateTime _dCdate;
                        if (_oRw[((ExcelFieldCharacter)_oFields[BusinessTrade.Para.cdate]).DataSetPoint].ToString().Trim() != string.Empty && DateTime.TryParseExact(_oRw[((ExcelFieldCharacter)_oFields[BusinessTrade.Para.cdate]).DataSetPoint].ToString(), n_sDateTimeList, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AllowWhiteSpaces, out _dCdate))
                            _oBusinessTrade.SetCdate(_dCdate);
                        else
                            _oBusinessTrade.SetCdate(null);
                    }
                    if (_oFields.Contains(BusinessTrade.Para.sdate))
                    {
                        DateTime _dSdate;
                        if (_oRw[((ExcelFieldCharacter)_oFields[BusinessTrade.Para.sdate]).DataSetPoint].ToString().Trim() != string.Empty && DateTime.TryParseExact(_oRw[((ExcelFieldCharacter)_oFields[BusinessTrade.Para.sdate]).DataSetPoint].ToString(), n_sDateTimeList, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AllowWhiteSpaces, out _dSdate))
                            _oBusinessTrade.SetSdate(_dSdate);
                        else
                            _oBusinessTrade.SetSdate(null);
                    }
                    if (_oFields.Contains(BusinessTrade.Para.edate))
                    {
                        DateTime _dEdate;
                        if (_oRw[((ExcelFieldCharacter)_oFields[BusinessTrade.Para.edate]).DataSetPoint].ToString().Trim() != string.Empty && DateTime.TryParseExact(_oRw[((ExcelFieldCharacter)_oFields[BusinessTrade.Para.edate]).DataSetPoint].ToString(), n_sDateTimeList, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AllowWhiteSpaces, out _dEdate))
                            _oBusinessTrade.SetEdate(_dEdate);
                        else
                            _oBusinessTrade.SetEdate(null);
                    }
                    if (_oFields.Contains(BusinessTrade.Para.po_date))
                    {
                        DateTime _dPo_date;
                        if (_oRw[((ExcelFieldCharacter)_oFields[BusinessTrade.Para.po_date]).DataSetPoint].ToString().Trim() != string.Empty && DateTime.TryParseExact(_oRw[((ExcelFieldCharacter)_oFields[BusinessTrade.Para.po_date]).DataSetPoint].ToString(), n_sDateTimeList, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AllowWhiteSpaces, out _dPo_date))
                            _oBusinessTrade.SetSdate(_dPo_date);
                    }

                    if (_oFields.Contains(BusinessTrade.Para.active))
                    {
                        string _sActive = _oRw[((ExcelFieldCharacter)_oFields[BusinessTrade.Para.active]).DataSetPoint].ToString().Trim();
                        bool _bActive;
                        if (bool.TryParse(_sActive, out _bActive))
                        {
                            _oBusinessTrade.SetActive(_bActive);
                        }
                    }
                    else
                        _oBusinessTrade.SetActive(true);


                    _oBusinessTrade.SetCancel_renew(false);
                    if (_oBusinessTrade.GetChannel().Equals(string.Empty))
                        _oBusinessTrade.SetChannel("ALL");

                    if (
                        !string.IsNullOrEmpty(_oBusinessTrade.GetProgram()) ||
                        !string.IsNullOrEmpty(_oBusinessTrade.GetNormal_rebate_type()) ||
                        !string.IsNullOrEmpty(_oBusinessTrade.GetRate_plan()) ||
                        !string.IsNullOrEmpty(_oBusinessTrade.GetCon_per()) ||
                        !string.IsNullOrEmpty(_oBusinessTrade.GetRebate()) ||
                        !string.IsNullOrEmpty(_oBusinessTrade.GetFree_mon()) ||
                        !string.IsNullOrEmpty(_oBusinessTrade.GetHs_model()) ||
                        !string.IsNullOrEmpty(_oBusinessTrade.GetHs_model_name()) ||
                        !string.IsNullOrEmpty(_oBusinessTrade.GetTrade_field()) ||
                        !string.IsNullOrEmpty(_oBusinessTrade.GetBundle_name()) ||
                        !string.IsNullOrEmpty(_oBusinessTrade.GetChannel())
                        )
                    {
                        if (_bUpdate)
                            _oBusinessTrade.Save();
                        else
                            BusinessTradeBal.InsertWithOutLastID(SYSConn<MSSQLConnect>.Connect(), _oBusinessTrade);
                    }
                }

                string _sMsg = string.Empty;
                _sMsg = "<SCRIPT>alert('Upload Finlish!');</SCRIPT>";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Success", _sMsg, false);
            }
            else
            {
                string _sError = "<script>alert('Excel no data!');</script>";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ERROR", _sError, false);
            }
        }
        else
        {
            string _sError = "<SCRIPT>alert('ERROR : Cannot upload this excel file [SheetName]:" + _sSheetName + " ');</SCRIPT>";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "ERROR", _sError, false);
        }
        SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery("UPDATE businesstrade SET edate = null WHERE edate<'02-01-1990'");
    }
}
