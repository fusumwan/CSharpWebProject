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

public partial class Web_OfferAutomation : System.Web.UI.Page
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
        OfferAutomationObjConnecton();
    }

    private void InitFrame()
    {

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
    protected void OfferAutomationObjConnecton()
    {
        OfferAutomationObj.ConnectionString = GetDB().ConnectionStr;
    }

    protected void OfferAutomationObj_Init(object sender, EventArgs e)
    {
        OfferAutomationObjConnecton();
    }
    protected void uploadto_SelectedIndexChanged(object sender, EventArgs e)
    {
        OfferAutomationObjConnecton();
        AspxOfferAutomationGV.DataBind();
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
                        if(PCCW.RWL.CORE.Configurator.IsUat())
                            ExcelVersion(ExcelUpload.FileName, _sExcelVersion, "true");
                        else
                            ExcelVersion(ExcelUpload.FileName, _sExcelVersion, "false");
                        AspxOfferAutomationGV.DataBind();
                        
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

    private void ExcelVersion(string x_sFileName, string x_sExcelVersion, string x_sIsUat)
    {


        try
        {
            string _sUpload = "Web/upload";
            string _sFileName = x_sFileName;
            string _sExcelVersion = x_sExcelVersion;
            string _sServerFilePath = "~/" + _sUpload + "/" + _sFileName;


            if (WebFunc.CheckFileExists(this.Page, _sServerFilePath) )
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
                        OfferAutomation _oOfferAutomation = OfferAutomationRepository.CreateEntityInstanceObject(GetDB());
                        bool _bUpdate = false;
                        if (_oDr["id"] != null)
                        {
                            string _sId = DR(_oDr[OfferAutomation.Para.id]).Trim().Replace("'", string.Empty).Replace(",", string.Empty);
                            int _iId;
                            if (int.TryParse(_sId, out _iId))
                            {
                                _oOfferAutomation.SetFound(false);
                                _oOfferAutomation.Load(_iId);
                                if (_oOfferAutomation.GetFound())
                                {
                                    _bUpdate = true;
                                }
                            }
                        }
                        


                        string _sOffer_name = DR(_oDr[OfferAutomation.Para.offer_name]).Trim().Replace("'", string.Empty).Replace(",", string.Empty);
                        _oOfferAutomation.SetOffer_name(_sOffer_name);
                        string _sActive = DR(_oDr[OfferAutomation.Para.active]).Trim().Replace("'", string.Empty).Replace(",", string.Empty);
                        bool _bActive;
                        if (bool.TryParse(_sActive, out _bActive))
                        {
                            _oOfferAutomation.SetActive(_bActive);
                        }

                        int _iTrade_field_id;
                        string _sTrade_field_id = DR(_oDr[OfferAutomation.Para.trade_field_id]).Trim().Replace("'", string.Empty).Replace(",", string.Empty);
                        if (int.TryParse(_sTrade_field_id, out _iTrade_field_id))
                        {
                            _oOfferAutomation.SetTrade_field_id(_iTrade_field_id);
                        }

                        int _iCall_list_program_id;
                        string _sCall_list_program_id = DR(_oDr[OfferAutomation.Para.call_list_program_id]).Trim().Replace("'", string.Empty).Replace(",", string.Empty);
                        if (int.TryParse(_sCall_list_program_id, out _iCall_list_program_id))
                        {
                            _oOfferAutomation.SetCall_list_program_id(_iCall_list_program_id);
                        }

                        if (_bUpdate)
                        {
                            if (!_oSession.Update(_oOfferAutomation))
                            {
                                _bRollBack = false;
                                break;
                            }
                        }
                        else
                        {
                            if (_oSession.Insert(_oOfferAutomation))
                            {
                                _bRollBack = false;
                                break;
                            }
                        }
                    }

                   
                    if (!_bRollBack && _oDs.Tables[0].Rows.Count > 0)
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

    protected void AspxOfferAutomationGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        if (e.RowIndex > -1)
        {
            GridView _oGridView = (GridView)sender;
            GridViewRow _oGridViewRow = (GridViewRow)_oGridView.Rows[e.RowIndex];


            string _sId= AspxOfferAutomationGV.DataKeys[e.RowIndex]["id"].ToString();
            int _iId;
            if (int.TryParse(_sId, out _iId))
            {
                OfferAutomation _oOfferAutomation = new OfferAutomation(SYSConn<MSSQLConnect>.Connect(), _iId);
                if (_oOfferAutomation.GetCall_list_program_id() != null)
                {
                    long _lCall_list_program_id = (long)_oOfferAutomation.GetCall_list_program_id();
                    StringBuilder _oQuery1 = new StringBuilder();
                    StringBuilder _oQuery2= new StringBuilder();
                    _oQuery1.Append("Delete From CallListUploadMrtNo WHERE call_list_program_id='" + _lCall_list_program_id.ToString() + "' ");
                    _oQuery2.Append("Delete From CallListUploadProfile WHERE call_list_program_id='" + _lCall_list_program_id.ToString() + "' ");
                    SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_oQuery1.ToString());
                    SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_oQuery2.ToString());

                    _oOfferAutomation.Delete();
                    AspxOfferAutomationGV.DataBind();
                }


            }
        }

    
    }
}
