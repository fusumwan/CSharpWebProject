using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Text;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using NEURON.WEB.UI.HTMLCONTROL.JSCONTROL;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;

public partial class Web_UpdateIMEI : NEURON.WEB.UI.BasePage
{
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion
    #region SessionUid
    string n_sSessionUid
    {
        get
        {
            if (Session["uid"] != null)
            {
                return Session["uid"].ToString();
            }
            else
                return string.Empty;
        }
    }
    #endregion

    #region SessionLv
    string n_sSessionLv
    {
        get
        {
            if (Session["lv"] != null)
            {
                return Session["lv"].ToString();
            }
            else
                return string.Empty;
        }
    }
    #endregion

    #region SessionArprog
    string n_sSessionArprog
    {
        get
        {
            if (Session["arprog"] != null)
            {
                return Session["arprog"].ToString();
            }
            else
                return string.Empty;
        }
    }
    #endregion

    #region SessionChannel
    string n_sSessionChannel
    {
        get
        {
            if (Session["channel"] != null)
            {
                return Session["channel"].ToString();
            }
            else
                return string.Empty;
        }
    }
    #endregion
    EDFStatusProfile _oEDFStatusProfile = new EDFStatusProfile();
OrderSerialNumberControl _oOrderSerialNumberControl = new OrderSerialNumberControl();
    

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

        if (!IsPostBack) { InitFrame(); }
    }

    public void InitRetentionRecord()
    {

    }

    public void InitFrame()
    {
        NeuronJSLibrary.Text = JSScriptLibrary.JSScriptCommon;
        EnabledUpdate(false);
    }

    protected bool CheckSKU(string x_sSku)
    {
        ProductItemCodeRepository _oProductItemCodeRepository = new ProductItemCodeRepository(SYSConn<MSSQLConnect>.Connect());
        IQueryable<ProductItemCodeEntity> _oProductItemCodeList = from ProductItemCodeList in _oProductItemCodeRepository.ProductItemCodes
                                                                  where ProductItemCodeList.item_code == x_sSku
                                                                  select ProductItemCodeList;
        if (_oProductItemCodeList.Count<ProductItemCodeEntity>() > 0)
        {
           ProductItemCodeEntity _oProductItemCodeEntity=  _oProductItemCodeList.First<ProductItemCodeEntity>();
           if (_oProductItemCodeEntity != null)
           {
               return true;
           }
        }
        return false;
    }

    protected string GetHsmodelSku(string x_sSku)
    {
        ProductItemCodeRepository _oProductItemCodeRepository = new ProductItemCodeRepository(SYSConn<MSSQLConnect>.Connect());
        IQueryable<ProductItemCodeEntity> _oProductItemCodeList = from ProductItemCodeList in _oProductItemCodeRepository.ProductItemCodes
                                                                  where ProductItemCodeList.item_code == x_sSku
                                                                  select ProductItemCodeList;
        if (_oProductItemCodeList.Count<ProductItemCodeEntity>() > 0)
        {
            ProductItemCodeEntity _oProductItemCodeEntity = _oProductItemCodeList.First<ProductItemCodeEntity>();
            if (_oProductItemCodeEntity != null)
            {
                return _oProductItemCodeEntity.hs_model.ToString();
            }
        }
        return string.Empty;
    }

    protected void EnabledUpdate(bool x_bDisabled)
    {
        updated_imei_no.Enabled = x_bDisabled;
        updated_imei_no.BackColor = (x_bDisabled) ? System.Drawing.Color.White : System.Drawing.Color.Yellow;
        update_sku.Enabled = x_bDisabled;
        update_sku.BackColor = (x_bDisabled) ? System.Drawing.Color.White : System.Drawing.Color.Yellow;
        UpdateAllIMEI.Enabled = x_bDisabled;
        ResetSearch.Enabled = x_bDisabled;
        find_edf_no.Enabled = !x_bDisabled;
        find_edf_no.BackColor = (x_bDisabled) ? System.Drawing.Color.Yellow : System.Drawing.Color.White;
        SearchEDF.Enabled = !x_bDisabled;
    }

    protected void SearchEDFRecord(string x_sEdf_no)
    {

        bool _bFlag = true;
        string _sErrorMessage = string.Empty;
        EnabledUpdate(false);
        if (string.IsNullOrEmpty(x_sEdf_no.ToString().Trim()))
        {
            string _sAlertMsg = "alert('Please enter the EDF number!');";
            RunJavascriptFunc(_sAlertMsg, true);
            return;
        }
        string _sRwl_order_id = string.Empty;
        string _sRwl_record_id = string.Empty;
        string _sRwl_edf_no = string.Empty;
        string _sRwl_imei_no = string.Empty;
        string _sRwl_sku = string.Empty;
        string _sRwl_hs_model = string.Empty;

        string _sEdf_record_id = string.Empty;
        string _sEdf_edf_no = string.Empty;
        string _sEdf_imei_no = string.Empty;
        string _sEdf_sku = string.Empty;
        string _sEdf_hs_model = string.Empty;
        string _sEdf_expect_delivery = string.Empty;
        string _sEdf_actural_delivery = string.Empty;
        string _sEdf_remark = string.Empty;
        string _sEdf_dn_remark = string.Empty;

        string _sImei_record_id = string.Empty;
        string _sImei_edf_no = string.Empty;
        string _sImei_imei_no = string.Empty;
        string _sImei_status = string.Empty;
        string _sImei_sku = string.Empty;
        string _sImei_hs_model = string.Empty;
        string _sImei_remark = string.Empty;

        string _sEdf_no = x_sEdf_no.ToString().Trim();
        if (_bFlag)
        {
            string _sQueryRWLStr = "SELECT TOP 1 order_id,order_id+100000 'record_id',edf_no,imei_no,sku,hs_model FROM MobileRetentionOrder WHERE edf_no='" + _sEdf_no + "' ";
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQueryRWLStr);
            if (_oDr.Read())
            {
                _sRwl_order_id = Func.FR(_oDr["order_id"]);
                _sRwl_record_id = Func.FR(_oDr["record_id"]);
                _sRwl_edf_no = Func.FR(_oDr["edf_no"]);
                _sRwl_imei_no = Func.FR(_oDr["imei_no"]);
                _sRwl_sku = Func.FR(_oDr["sku"]);
                _sRwl_hs_model = Func.FR(_oDr["hs_model"]);
            }
            else
            {
                _bFlag = false;
                string _sAlertMsg = "alert('Cannot not find this EDF number is Retention Web Log!');";
                RunJavascriptFunc(_sAlertMsg, true);
            }
            _oDr.Close();
            _oDr.Dispose();
        }
        if (_bFlag)
        {
            string _sQueryEDFStr = "SELECT agree_no, referenceno,imei, itemcode, itemdesc, e_delivery_date, actual_del_date,remark, dn_remark FROM SUNDAY_FORM WHERE referenceno='" + _sEdf_no + "'  AND  created_by ='CC RET'  AND rownum<=1";
            OdbcDataReader _oEDFDr = SYSConn<ODBCConnect>.Connect().GetSearch(_sQueryEDFStr);
            if (_oEDFDr.Read())
            {
                _sEdf_record_id = Func.FR(_oEDFDr["agree_no"]);
                _sEdf_edf_no = Func.FR(_oEDFDr["referenceno"]);
                _sEdf_imei_no = Func.FR(_oEDFDr["imei"]);
                _sEdf_sku = Func.FR(_oEDFDr["itemcode"]);
                _sEdf_hs_model = Func.FR(_oEDFDr["itemdesc"]);
                if (_oEDFDr["e_delivery_date"] != null)
                {
                    _sEdf_expect_delivery = Func.FR(_oEDFDr["e_delivery_date"]);
                }
                if (_oEDFDr["actual_del_date"] != null)
                {
                    if (!string.IsNullOrEmpty(_oEDFDr["actual_del_date"].ToString()))
                    {
                        _sEdf_actural_delivery = ((DateTime)_oEDFDr["actual_del_date"]).ToString("dd/MM/yyyy");
                    }
                }
                _sEdf_remark = Func.FR(_oEDFDr["remark"]);
                _sEdf_dn_remark = Func.FR(_oEDFDr["dn_remark"]);
            }
            else
            {
                _bFlag = false;
                string _sAlertMsg = "alert('Cannot not find this EDF number is EDF System!');";
                RunJavascriptFunc(_sAlertMsg, true);
            }
            _oEDFDr.Close();
            _oEDFDr.Dispose();
        }
        if (_bFlag)
        {
            string _sQueryIMEIStr = "SELECT DUMMY4, referenceno, imei, status, kit_code, model, remark FROM IMEI_STOCK WHERE dummy2='CC RET' and (referenceno='" + _sEdf_edf_no + "' or DUMMY4='" + _sRwl_record_id + "') AND rownum<=1 ";
            OdbcDataReader _oIMEIDr = SYSConn<ODBCConnect>.Connect().GetSearch(_sQueryIMEIStr);
            if (_oIMEIDr.Read())
            {
                _sImei_record_id = Func.FR(_oIMEIDr["DUMMY4"]);
                _sImei_edf_no = Func.FR(_oIMEIDr["referenceno"]);
                _sImei_imei_no = Func.FR(_oIMEIDr["imei"]);
                _sImei_status = Func.FR(_oIMEIDr["status"]);
                _sImei_sku = Func.FR(_oIMEIDr["kit_code"]);
                _sImei_hs_model = Func.FR(_oIMEIDr["model"]);
                _sImei_remark = Func.FR(_oIMEIDr["remark"]);
            }
            else
            {
                _bFlag = false;
                string _sAlertMsg = "alert('Cannot not find this EDF/RecordID is IMEI STOCK System!');";
                RunJavascriptFunc(_sAlertMsg, true);
            }
            _oIMEIDr.Close();
            _oIMEIDr.Dispose();
        }

        if (_bFlag)
        {

            RetentionRecordOverView1._rwl_edf_no.Text = _sRwl_edf_no;
            RetentionRecordOverView1._rwl_hs_model.Text = _sRwl_hs_model;
            RetentionRecordOverView1._rwl_imei_no.Text = _sRwl_imei_no;
            RetentionRecordOverView1._rwl_order_id.Text = _sRwl_order_id;
            RetentionRecordOverView1._rwl_record_id.Text = _sRwl_record_id;
            RetentionRecordOverView1._rwl_sku.Text = _sRwl_sku;

            RetentionRecordOverView1._edf_actural_delivery.Text = _sEdf_actural_delivery;
            RetentionRecordOverView1._edf_dn_remark.Text = _sEdf_dn_remark;
            RetentionRecordOverView1._edf_edf_no.Text = _sEdf_edf_no;
            RetentionRecordOverView1._edf_expect_delivery.Text = _sEdf_expect_delivery;
            RetentionRecordOverView1._edf_hs_model.Text = _sEdf_hs_model;
            RetentionRecordOverView1._edf_imei_no.Text = _sEdf_imei_no;
            RetentionRecordOverView1._edf_record_id.Text = _sEdf_record_id;
            RetentionRecordOverView1._edf_remark.Text = _sEdf_remark;
            RetentionRecordOverView1._edf_sku.Text = _sEdf_sku;

            RetentionRecordOverView1._imei_edf_no.Text = _sImei_edf_no;
            RetentionRecordOverView1._imei_hs_model.Text = _sImei_hs_model;
            RetentionRecordOverView1._imei_imei_no.Text = _sImei_imei_no;
            RetentionRecordOverView1._imei_record_id.Text = _sImei_record_id;
            RetentionRecordOverView1._imei_remark.Text = _sImei_remark;
            RetentionRecordOverView1._imei_sku.Text = _sImei_sku;
            RetentionRecordOverView1._imei_status.Text = _sImei_status;
            EnabledUpdate(true);
        }
        else
            EnabledUpdate(false);
    }
    

    protected void SearchEDF_Click(object sender, EventArgs e)
    {
        
        SearchEDFRecord(find_edf_no.Text.ToString());
    }

    #region PageLoadComplete
    protected void Page_LoadComplete(object sender, EventArgs e)
    {
        SetHtmlControlStyle("global-loading", HtmlTextWriterStyle.Display, "none", true, true, true);
    }
    #endregion

    #region Set HtmlControl Style By Javascript
    public string SetHtmlControlStyle(string x_sID, HtmlTextWriterStyle x_oStyle, string x_sValue, bool x_bStr, bool x_bIncludeScript, bool x_bRunRegister)
    {
        Random ran = new Random();
        string _sScript = string.Empty;
        if (x_bStr)
            _sScript = string.Format("if(ChkID('{0}')){1}GetID('{2}').style.{3}='{4}';{5}", x_sID, "{", x_sID, x_oStyle.ToString().ToLower(), x_sValue, "}");
        else
            _sScript = string.Format("if(ChkID('{0}')){1}GetID('{2}').style.{3}={4};{5}", x_sID, "{", x_sID, x_oStyle.ToString().ToLower(), x_sValue, "}");

        if (x_bIncludeScript) _sScript = "<script>" + _sScript + "</script>";
        if (x_bRunRegister)
            ScriptManager.RegisterStartupScript(this, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), _sScript, false);

        return _sScript;
    }
    #endregion

    #region RegisterJavaScript
    protected void RegisterJavaScript(string x_sID, string x_sScript, bool x_bIncludeScript)
    {
        if (x_bIncludeScript) x_sScript = "<script>" + x_sScript + "</script>";
        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), x_sScript, false);
    }
    #endregion

    #region Run Javascript Function
    public string RunJavascriptFunc(string x_sFunc, bool x_bIncludeScript)
    {
        string _sFunc = ((x_sFunc.IndexOf(';') > 0) ? x_sFunc : x_sFunc + ";");
        if (x_bIncludeScript) _sFunc = "<script>" + _sFunc + "</script>";
            ScriptManager.RegisterStartupScript(this, this.GetType(), x_sFunc + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), _sFunc, false);
        return _sFunc;
    }

    public string RunJavascriptFunc(string x_sFunc)
    {
        return RunJavascriptFunc(x_sFunc, false);
    }
    #endregion

    protected void UpdateAllIMEI_Click(object sender, EventArgs e)
    {
        bool _bFlag = true;
        int _iOrder_id;
        string _sHsmodel = GetHsmodelSku(update_sku.Text.ToString());
        if (RetentionRecordOverView1._rwl_order_id.Text.Trim() == string.Empty)
        {
            _bFlag = false;
            string _sAlertMsg = "alert('Retention order id cannot empty!');";
            RunJavascriptFunc(_sAlertMsg, true);
        }

        if (RetentionRecordOverView1._rwl_edf_no.Text.Trim() == string.Empty)
        {
            _bFlag = false;
            string _sAlertMsg = "alert('Retention EDF number cannot empty!');";
            RunJavascriptFunc(_sAlertMsg, true);
        }

        if (RetentionRecordOverView1._edf_edf_no.Text.Trim() == string.Empty)
        {
            _bFlag = false;
            string _sAlertMsg = "alert('EDF number cannot empty!');";
            RunJavascriptFunc(_sAlertMsg, true);
        }

        if (RetentionRecordOverView1._imei_edf_no.Text.Trim() == string.Empty)
        {
            _bFlag = false;
            string _sAlertMsg = "alert('IMEI STOCK EDF number cannot empty!');";
            RunJavascriptFunc(_sAlertMsg, true);
        }

        if (RetentionRecordOverView1._rwl_imei_no.Text.Trim() == string.Empty)
        {
            _bFlag = false;
            string _sAlertMsg = "alert('Retention IMEI number cannot empty!');";
            RunJavascriptFunc(_sAlertMsg, true);
        }

        if (RetentionRecordOverView1._edf_imei_no.Text.Trim() == string.Empty)
        {
            _bFlag = false;
            string _sAlertMsg = "alert('EDF IMEI number cannot empty!');";
            RunJavascriptFunc(_sAlertMsg, true);
        }

        if (RetentionRecordOverView1._imei_imei_no.Text.Trim() == string.Empty)
        {
            _bFlag = false;
            string _sAlertMsg = "alert('IMEI STOCK IMEI number cannot empty!');";
            RunJavascriptFunc(_sAlertMsg, true);
        }

        if (RetentionRecordOverView1._rwl_record_id.Text.Trim() == string.Empty)
        {
            _bFlag = false;
            string _sAlertMsg = "alert('Retention record Id(order_id+100000) cannot empty!');";
            RunJavascriptFunc(_sAlertMsg, true);
        }

        if (RetentionRecordOverView1._edf_record_id.Text.Trim() == string.Empty)
        {
            _bFlag = false;
            string _sAlertMsg = "alert('EDF record Id(agree_no) cannot empty!');";
            RunJavascriptFunc(_sAlertMsg, true);
        }

        if (RetentionRecordOverView1._imei_record_id.Text.Trim() == string.Empty)
        {
            _bFlag = false;
            string _sAlertMsg = "alert('IMEI STOCK record id(DUMMY4) cannot empty!')";
            RunJavascriptFunc(_sAlertMsg, true);
        }

        if (RetentionRecordOverView1._rwl_sku.Text.Trim() == string.Empty)
        {
            _bFlag = false;
            string _sAlertMsg = "alert('Retention sku(item code) cannot empty!')";
            RunJavascriptFunc(_sAlertMsg, true);
        }

        if (RetentionRecordOverView1._edf_sku.Text.Trim() == string.Empty)
        {
            _bFlag = false;
            string _sAlertMsg = "alert('EDF item code cannot empty!')";
            RunJavascriptFunc(_sAlertMsg, true);
        }

        if (RetentionRecordOverView1._imei_sku.Text.Trim() == string.Empty)
        {
            _bFlag = false;
            string _sAlertMsg = "alert('IMEI STOCK kit_code(item code/sku) cannot empty!')";
            RunJavascriptFunc(_sAlertMsg, true);
        }

        if (CheckSKU(update_sku.Text.ToString()) && _sHsmodel == string.Empty)
        {
            _bFlag = false;
            string _sAlertMsg = "alert('This item code cannot find in database!')";
            RunJavascriptFunc(_sAlertMsg, true);
        }

        if (!int.TryParse(RetentionRecordOverView1._rwl_order_id.Text.Trim(), out _iOrder_id))
        {
            if (_bFlag)
            {
                MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect(), _iOrder_id);
                if (_oMobileRetentionOrder.Retrieve())
                {
                    _oMobileRetentionOrder.SetImei_no(updated_imei_no.Text.ToString());
                    _oMobileRetentionOrder.SetSku(update_sku.Text.ToString());
                    _oMobileRetentionOrder.SetHs_model(_sHsmodel.ToString());
                    _oMobileRetentionOrder.Save();
                    MobileRetentionOrderBal.BackUpOrder(_iOrder_id, RWLFramework.CurrentUser[this.Page].Uid);
                    bool _bRelease = IMEIRelease(RetentionRecordOverView1._rwl_imei_no.Text.ToString(), RetentionRecordOverView1._rwl_sku.Text.ToString());
                    CreateAOAWAITRecord(_iOrder_id, IMEISTATUS.AWAIT);
                    //_oEDFStatusProfile.AddEDFAmentLog(_iOrder_id, n_sSessionUid);
                    UpdateImei(_iOrder_id, updated_imei_no.Text, update_sku.Text);
                }
            }
        }
        else
        {
            _bFlag = false;
            string _sAlertMsg = "alert('Retention order id must be integer!');";
            RunJavascriptFunc(_sAlertMsg, true);
        }
    }

    #region UpdateIMEI
    public bool UpdateImei(int x_iRecord_ID, string x_sIMEI, string x_sSKU)
    {

        if (string.IsNullOrEmpty(x_sIMEI)) return false;
        if (string.IsNullOrEmpty(x_sSKU)) return false;
        string _sQuery = "SELECT * FROM IMEI_STOCK WHERE DUMMY4='" + x_iRecord_ID + "' AND kit_code='" + x_sSKU + "' AND (STATUS='AO' or STATUS='AWAIT') ";
        OdbcDataReader _oChkDr = SYSConn<ODBCConnect>.Connect().GetSearch(_sQuery);
        if (!_oChkDr.Read())
        {
            Response.Write("<script>alert('Update Fail!');</script>");
            _oChkDr.Close();
            _oChkDr.Dispose();
            return false;
        }
        _oChkDr.Close();
        _oChkDr.Dispose();


        SessionFactory<MSSQLConnect> _oSessionFactory = new SessionFactory<MSSQLConnect>();
        string n_sToday = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        string n_sToday1 = DateTime.Now.ToString("yyyyMMdd");
        string n_sTime1 = DateTime.Now.AddMinutes(-30).ToString("HH:mm:ss");
        int _iHour = Convert.ToInt32(DateTime.Now.AddMinutes(-30).ToString("HH"));
        int _iMinute = Convert.ToInt32(DateTime.Now.AddMinutes(-30).ToString("mm"));
        int _iSecond = Convert.ToInt32(DateTime.Now.AddMinutes(-30).ToString("ss"));

        if (!string.IsNullOrEmpty(RWLFramework.CurrentUser[this.Page].Uid) &&
            !x_sIMEI.Equals(string.Empty) &&
            !x_sIMEI.Equals("AO") &&
            !x_sIMEI.Equals("AWAIT") &&
            x_iRecord_ID > 0)
        {
            StringBuilder _oUpdateIMEIStock = new StringBuilder();
            _oUpdateIMEIStock.Append("UPDATE IMEI_STOCK SET IMEI='" + x_sIMEI + "', staff_recd='',status='STOCK' WHERE KIT_CODE='" + x_sSKU + "' AND DUMMY4='" + x_iRecord_ID + "' AND rownum<=1");
            bool _bUpdateIMEIStock = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oUpdateIMEIStock.ToString());
            #region ================= Control only one staff can update status ==================
            global::System.Text.StringBuilder _oUpdateIMEIQuery = new StringBuilder();
            _oUpdateIMEIQuery.Append(" UPDATE IMEI_Stock SET STAFF_RECD='" + RWLFramework.CurrentUser[this.Page].Uid + "' ");
            _oUpdateIMEIQuery.Append(" Where Dummy2='CC RET' AND Status='STOCK' ");
            _oUpdateIMEIQuery.Append(" AND (STAFF_RECD is null or STAFF_RECD='') AND DUMMY4='" + x_iRecord_ID + "'");
            bool _bUpdateSuccess = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oUpdateIMEIQuery.ToString());
            #endregion ================= End of control only one staff can update status ==================

            global::System.Text.StringBuilder _oSelectOrderQuery = new StringBuilder();
            _oSelectOrderQuery.Append(" SELECT datediff(d,getdate(),d_date) as date_diff,");
            _oSelectOrderQuery.Append(" CONVERT(VARCHAR,log_date,103) log_date, * FROM ");
            _oSelectOrderQuery.Append(Configurator.MSSQLTablePrefix + "MobileRetentionOrder ");
            _oSelectOrderQuery.Append(" with (nolock) WHERE active=1 ");
            _oSelectOrderQuery.Append(" AND (imei_no='AWAIT' OR imei_no='Await' OR imei_no='AO') ");
            _oSelectOrderQuery.Append(" AND d_date is not null");
            _oSelectOrderQuery.Append(" AND Order_id+100000 = '" + x_iRecord_ID + "'");
            global::System.Data.SqlClient.SqlDataReader _oDr =
                SYSConn<MSSQLConnect>.Connect().GetSearch(_oSelectOrderQuery.ToString());
            while (_oDr.Read())
            {
                if (Func.FR(_oDr[MobileRetentionOrder.Para.order_id]).Equals(string.Empty)) { continue; }
                string _sRecordId = Func.IDAdd100000(Convert.ToInt32(Func.FR(_oDr[MobileRetentionOrder.Para.order_id])));
                _oOrderSerialNumberControl.SetOrder_id(Convert.ToInt32(Func.FR(_oDr[MobileRetentionOrder.Para.order_id])));
                if (_sRecordId == string.Empty) Logger.WarnFormat("User cannot be found the result with empty({0}) value in this function.", "_sRecordId");
                {
                    #region Update Imei stock
                    string n_sImei_no = string.Empty;
                    string n_sRefNo = string.Empty;
                    if (Func.FR(_oDr[MobileRetentionOrder.Para.sku]).Trim() != string.Empty && !Func.FR(_oDr[MobileRetentionOrder.Para.sku]).Trim().Equals("0"))
                    {
                        #region === check Stock ===
                        global::System.Text.StringBuilder _oSelectStockQuery = new StringBuilder();
                        _oSelectStockQuery.Append(" SELECT * FROM IMEI_Stock ");
                        _oSelectStockQuery.Append(" WHERE Dummy2='CC RET' AND ");
                        _oSelectStockQuery.Append(" Kit_Code='" + Func.FR(_oDr[MobileRetentionOrder.Para.sku]).Trim() + "' ");
                        _oSelectStockQuery.Append(" AND DUMMY4='" + Func.IDAdd100000(Convert.ToInt32(Func.FR(_oDr[MobileRetentionOrder.Para.order_id]))) + "' ");
                        _oSelectStockQuery.Append(" AND Status='STOCK' AND IMEI<>' ' and STAFF_RECD='" + RWLFramework.CurrentUser[this.Page].Uid + "'");

                        global::System.Data.Odbc.OdbcDataReader _oDr2 = SYSConn<ODBCConnect>.Connect().GetSearch(_oSelectStockQuery.ToString());
                        #region _oDr2
                        if (_oDr2.Read())
                        {
                            string _sAment_Date = string.Empty;
                            n_sImei_no = Func.FR(_oDr2["IMEI"]).Trim();
                            //=== get EDF# ===
                            if (string.IsNullOrEmpty(Func.FR(_oDr[MobileRetentionOrder.Para.edf_no])))
                            {
                                n_sRefNo = _oOrderSerialNumberControl.ReferenceNumber;
                            }
                            else
                                n_sRefNo = Func.FR(_oDr[MobileRetentionOrder.Para.edf_no]).Trim();

                            if (global::System.Convert.IsDBNull(_oDr2["Dummy1"]) || "".Equals(_oDr2["Dummy1"].ToString().Trim()))
                            {
                                DateTime _dAment_Date;
                                int _IOrdinal = _oDr2.GetOrdinal("Create_Date");
                                _dAment_Date = _oDr2.GetDateTime(_IOrdinal);
                                _sAment_Date = _dAment_Date.ToString("yyyyMMdd");
                                //if(DateTime.TryParseExact(_oDr2["Create_Date"].ToString()
                                // _sAment_Date = DateTime.ParseExact(_oDr2["Create_Date"].ToString(), "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces).ToString("yyyyMMdd");

                            }
                            else
                                _sAment_Date = _oDr2["Dummy1"].ToString();
                            if (!n_sRefNo.Equals(string.Empty) && !n_sImei_no.Equals(string.Empty))
                            {
                                //'=== back up ===
                                global::System.Text.StringBuilder _oBackUpIMEIStockQuery = new StringBuilder();
                                _oBackUpIMEIStockQuery.Append(" INSERT INTO IMEI_Stock_hist ");
                                _oBackUpIMEIStockQuery.Append(" (Kit_Code,Model,Status,ReferenceNo,Create_Date,");
                                _oBackUpIMEIStockQuery.Append(" Create_By,Dummy1,Dummy2,Dummy3,Stock_In_Date,IMEI,Ament_Date) ");
                                _oBackUpIMEIStockQuery.Append(" VALUES ('" + Func.FR(_oDr2["Kit_Code"]) + "','");
                                _oBackUpIMEIStockQuery.Append(Func.FR(_oDr2["Model"]) + "','" + Func.FR(_oDr2["Status"]) + "','");
                                _oBackUpIMEIStockQuery.Append(n_sRefNo + "',to_date('" + n_sToday + "' , 'dd/mm/yyyy hh24:mi:ss'),'auto','");
                                _oBackUpIMEIStockQuery.Append(Func.FR(_oDr2["Dummy1"]) + "','" + Func.FR(_oDr2["Dummy2"]) + "','");
                                _oBackUpIMEIStockQuery.Append(Func.FR(_oDr2["Dummy3"]) + "','" + Func.FR(_oDr2["Stock_In_Date"]) + "','");
                                _oBackUpIMEIStockQuery.Append(Func.FR(_oDr2["IMEI"]) + "',to_date('" + _sAment_Date + "' , 'yyyymmdd')) ");
                                bool _bBack_upImei = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oBackUpIMEIStockQuery.ToString());
                                //'=== update status ===
                                global::System.Text.StringBuilder _oUpdateIMEIStockQuery = new StringBuilder();
                                _oUpdateIMEIStockQuery.Append(" UPDATE IMEI_Stock SET ");
                                _oUpdateIMEIStockQuery.Append(" Status='SOLD',STAFF_RECD=null, Dummy1='" + n_sToday1 + "', ");
                                _oUpdateIMEIStockQuery.Append(" ReferenceNo='" + n_sRefNo + "', StaffNo='" + Func.FR(_oDr[MobileRetentionOrder.Para.staff_no]) + "' ,");
                                _oUpdateIMEIStockQuery.Append(" Mobile_no='" + Func.FR(_oDr[MobileRetentionOrder.Para.mrt_no]) + "' ,Completed_Date='" + n_sToday1 + "' ");
                                _oUpdateIMEIStockQuery.Append(" WHERE Dummy2='CC RET' and IMEI='" + n_sImei_no + "' ");
                                _oUpdateIMEIStockQuery.Append(" AND DUMMY4='" + Func.IDAdd100000(Convert.ToInt32(Func.FR(_oDr[MobileRetentionOrder.Para.order_id]))) + "' ");
                                _oUpdateIMEIStockQuery.Append(" AND Kit_Code='" + Func.FR(_oDr[MobileRetentionOrder.Para.sku]) + "' ");
                                _oUpdateIMEIStockQuery.Append(" AND STAFF_RECD='" + RWLFramework.CurrentUser[this.Page].Uid + "' AND Status='STOCK'");
                                bool _bUpdateImei = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oUpdateIMEIStockQuery.ToString());
                            }
                        }
                        else
                            n_sRefNo = Func.FR(_oDr[MobileRetentionOrder.Para.edf_no]).Trim();
                        _oDr2.Close();
                        _oDr2.Dispose();
                        #endregion
                        #endregion
                    }
                    #endregion

                    MobileRetentionOrderRepositoryBase _oMobileRetentionOrderRepositoryBase =
                    new MobileRetentionOrderRepositoryBase(SYSConn<MSSQLConnect>.Connect());

                    if (string.IsNullOrEmpty(Func.FR(_oDr[MobileRetentionOrder.Para.edf_no]).Trim()) &&
                        !string.IsNullOrEmpty(n_sRefNo))
                    {
                        if (_oEDFStatusProfile.AllowInsertEDFIMEI(n_sRefNo, n_sImei_no))
                        {
                            //=== back up ===
                            MobileRetentionOrderBal.BackUpOrder(Convert.ToInt32(Func.FR(_oDr[MobileRetentionOrder.Para.order_id]).Trim()), RWLFramework.CurrentUser[this.Page].Uid);
                            #region === update EDF# & IMEI# ===
                            global::System.Text.StringBuilder _oUpdateEDFIMEISql = new global::System.Text.StringBuilder();
                            _oUpdateEDFIMEISql.Append(" UPDATE " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder ");
                            _oUpdateEDFIMEISql.Append(" SET imei_no='" + n_sImei_no + "',edf_no='" + n_sRefNo + "',");
                            _oUpdateEDFIMEISql.Append(" cid='" + RWLFramework.CurrentUser[this.Page].Uid + "',cdate=getdate() ");
                            _oUpdateEDFIMEISql.Append(" WHERE order_id='" + Func.FR(_oDr[MobileRetentionOrder.Para.order_id]) + "'");
                            bool _bUpdateWebLog = SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_oUpdateEDFIMEISql.ToString());
                            #endregion
                            int _iAmount = 0;
                            if (string.IsNullOrEmpty(Func.FR(_oDr[MobileRetentionOrder.Para.amount]).Trim()))
                                _iAmount = 0;
                            else
                                _iAmount = Convert.ToInt32(Func.FR(_oDr[MobileRetentionOrder.Para.amount]).Trim());

                            int _iAccessory_price = 0;
                            if (string.IsNullOrEmpty(Func.FR(_oDr[MobileRetentionOrder.Para.accessory_price]).Trim()))
                                _iAccessory_price = 0;
                            else
                                _iAccessory_price = Convert.ToInt32(Func.FR(_oDr[MobileRetentionOrder.Para.accessory_price]).Trim());

                            global::System.Text.StringBuilder _oSelectSundayFormSql = new global::System.Text.StringBuilder();
                            _oSelectSundayFormSql.Append(" SELECT referenceNo from sunday_Form ");
                            _oSelectSundayFormSql.Append(" WHERE CREATED_BY='CC RET' AND Agree_no='" + _sRecordId + "' AND cancelled='N' ");
                            global::System.Data.Odbc.OdbcDataReader _oDr2 = SYSConn<ODBCConnect>.Connect().GetSearch(_oSelectSundayFormSql.ToString());
                            if (!_oDr2.Read() &&
                                _bUpdateWebLog &&
                                _oEDFStatusProfile.AllowInsertEDFIMEI(n_sRefNo, n_sImei_no))
                            {
                                MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect(), Convert.ToInt32(Func.FR(_oDr[MobileRetentionOrder.Para.order_id])));
                                global::System.Text.StringBuilder _oQuery = new global::System.Text.StringBuilder();
                                #region Insert into sunday From
                                _oQuery.Append("INSERT INTO sunday_Form (IMEI_2, SS_TO_PLG_DATE, referenceNo,Agree_no,create_date, staffNo, staffName,  SalesManCode, Extn, Sales_channel, Applicat_Date, Customer_name, Customer_ID_Type, Customer_ID, Mobile_no, Contact_no, User_Name, Order_Amt, Delivery_charge, E_delivery_date, E_Delivery_period, Dummy2, Dummy3, Remark,ItemCode, program,Rate_plan,contract_period,Plan_code,FG_Code,FG_IMEI0,FreeGift1,FG_Desc1,FG_IMEI1,FreeGift2,FG_Desc2,FG_IMEI2,FreeGift3,FG_Desc3,FG_IMEI3,FreeGift4,FG_Desc4,FG_IMEI4,CASH_AMT, ItemDesc, IMEI, TRADE, REBATE, HS_PAYMENT_TYPE, HS_CARD_NO, HS_C_HOLDER_NAME, HS_EXPIRYDATE, HS_PAY_AMT,COMPANY_NAME,VAS, doc_receive, cancelled,fo_to_sales, payment_status,create_s,to_plg,issue,pending,created_by,PEND_DOC,Premium_Gift,Contact_No_R,ament_counter,sim_card_type,sim_item_code,sim_card_no");
                                _oQuery.Append(" ) VALUES ('" + _oMobileRetentionOrder.GetSim_mrt_no() + "',to_date('" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "' , 'dd/mm/yyyy hh24:mi:ss'),   '" + n_sRefNo.Trim() + "' ,");
                                _oQuery.Append("'" + Func.IDAdd100000(_oMobileRetentionOrder.GetOrder_id()).Trim() + "',");
                                _oQuery.Append("to_date('" + n_sToday.Trim() + "' , 'dd/mm/yyyy hh24:mi:ss') ,");

                                _oQuery.Append("'" + _oMobileRetentionOrder.GetStaff_no() + "','");
                                _oQuery.Append(_oMobileRetentionOrder.GetStaff_name() + "','");
                                _oQuery.Append(_oMobileRetentionOrder.GetSalesmancode() + "','");
                                _oQuery.Append(_oMobileRetentionOrder.GetExtn() + "','PCCW.PCCS',");
                                if (_oMobileRetentionOrder.GetLog_date() != null)
                                    _oQuery.Append("to_date('" + Convert.ToDateTime(_oMobileRetentionOrder.GetLog_date()).ToString("dd/MM/yyyy") + "','dd/mm/yyyy'),'");
                                else
                                    _oQuery.Append("','");

                                _oQuery.Append(_oMobileRetentionOrder.GetCustomerName().Trim().Replace("'", "`") + "','");
                                if ("BRNO".Equals(_oMobileRetentionOrder.GetId_type()))
                                    _oQuery.Append("BR','");
                                else
                                    _oQuery.Append(_oMobileRetentionOrder.GetId_type().Trim() + "','");

                                if ("HKID".Equals(_oMobileRetentionOrder.GetId_type()))
                                    _oQuery.Append(Func.Left(_oMobileRetentionOrder.GetHkid().Trim(), _oMobileRetentionOrder.GetHkid().Length - 1) + "(" + Func.Right(_oMobileRetentionOrder.GetHkid().Trim(), 1) + ")','");
                                else
                                    _oQuery.Append(_oMobileRetentionOrder.GetHkid().Trim() + "','");

                                _oQuery.Append(_oMobileRetentionOrder.GetMrt_no().ToString() + "','");
                                _oQuery.Append(_oMobileRetentionOrder.GetContact_no() + "','");
                                _oQuery.Append(_oMobileRetentionOrder.GetContact_person().Trim().Replace("'", "`") + "','");
                                _oQuery.Append((_iAmount + _iAccessory_price).ToString() + "','");
                                _oQuery.Append(_oMobileRetentionOrder.GetExtra_d_charge() + "','");
                                if (_oMobileRetentionOrder.GetD_date() != null)
                                    _oQuery.Append(Convert.ToDateTime(_oMobileRetentionOrder.GetD_date()).ToString("dd/MM/yyyy") + "','");
                                else
                                    _oQuery.Append("','");
                                if (!string.IsNullOrEmpty(_oMobileRetentionOrder.GetD_time()))
                                    _oQuery.Append(_oMobileRetentionOrder.GetD_time() + "','");
                                else
                                    _oQuery.Append("','");
                                _oQuery.Append(_oMobileRetentionOrder.GetD_address().Trim().Replace("'", "`") + "','");

                                if (!_oMobileRetentionOrder.GetVip_case().Equals(string.Empty))
                                    _oQuery.Append(_oMobileRetentionOrder.GetVip_case().Trim().Replace("'", "`") + "','");
                                else
                                    _oQuery.Append("','");

                                if (!_oMobileRetentionOrder.GetOrd_place_by().Equals(string.Empty) && !_oMobileRetentionOrder.GetOrd_place_rel().Trim().Equals("sub"))
                                {
                                    if (!_oMobileRetentionOrder.GetRemarks2EDF().Equals(string.Empty))
                                        _oQuery.Append(_oMobileRetentionOrder.GetRemarks2EDF().Trim().Replace("'", "`") + " Order Placed By " + _oMobileRetentionOrder.GetOrd_place_rel().Trim().Replace("'", "`") + ", " + _oMobileRetentionOrder.GetOrd_place_by().Trim().Replace("'", "`") + ", " + _oMobileRetentionOrder.GetOrd_place_hkid().Trim().Replace("'", "`") + "','");
                                    else
                                        _oQuery.Append(" Order Placed By " + _oMobileRetentionOrder.GetOrd_place_rel().Trim().Replace("'", "`") + ", " + _oMobileRetentionOrder.GetOrd_place_by().Trim().Replace("'", "`") + ", " + _oMobileRetentionOrder.GetOrd_place_hkid().Trim().Replace("'", "`") + "','");
                                }
                                else
                                {
                                    if (!_oMobileRetentionOrder.GetRemarks2EDF().Equals(string.Empty))
                                        _oQuery.Append(_oMobileRetentionOrder.GetRemarks2EDF().Trim().Replace("'", "`") + "','");
                                    else
                                        _oQuery.Append("','");
                                }

                                _oQuery.Append(_oMobileRetentionOrder.GetSku().Trim() + "','");
                                _oQuery.Append(_oMobileRetentionOrder.GetProgram().Trim() + "','");
                                _oQuery.Append(_oMobileRetentionOrder.GetRate_plan().Trim() + "','");
                                _oQuery.Append(_oMobileRetentionOrder.GetCon_per().Trim() + " MTH','");
                                _oQuery.Append(_oMobileRetentionOrder.GetAccessory_code().Trim() + "','");
                                _oQuery.Append(_oMobileRetentionOrder.GetAccessory_desc().Trim() + "','");
                                _oQuery.Append(_oMobileRetentionOrder.GetAccessory_imei() + "','");

                                _oQuery.Append(_oMobileRetentionOrder.GetGift_code() + "','");
                                _oQuery.Append(_oMobileRetentionOrder.GetGift_desc() + "','");
                                _oQuery.Append(_oMobileRetentionOrder.GetGift_imei() + "','");
                                _oQuery.Append(_oMobileRetentionOrder.GetGift_code2() + "','");
                                _oQuery.Append(_oMobileRetentionOrder.GetGift_desc2() + "','");
                                _oQuery.Append(_oMobileRetentionOrder.GetGift_imei2() + "','");
                                _oQuery.Append(_oMobileRetentionOrder.GetGift_code3() + "','");
                                _oQuery.Append(_oMobileRetentionOrder.GetGift_desc3() + "','");
                                _oQuery.Append(_oMobileRetentionOrder.GetGift_imei3() + "','");
                                _oQuery.Append(_oMobileRetentionOrder.GetGift_code4() + "','");
                                _oQuery.Append(_oMobileRetentionOrder.GetGift_desc4() + "','");
                                _oQuery.Append(_oMobileRetentionOrder.GetGift_imei4() + "','");

                                _oQuery.Append(_oMobileRetentionOrder.GetAccessory_price() + "','");
                                _oQuery.Append(_oMobileRetentionOrder.GetHs_model() + "','");


                                //IMEI
                                if (!n_sImei_no.Equals("AWAIT") &&
                                    !n_sImei_no.Equals("AO"))
                                {
                                    _oQuery.Append(n_sImei_no.Trim() + "','");
                                }
                                else
                                {
                                    _oQuery.Append("','");
                                }

                                _oQuery.Append(_oMobileRetentionOrder.GetTrade_field() + "','");
                                _oQuery.Append(_oMobileRetentionOrder.GetRebate_amount() + "','");

                                if (_oMobileRetentionOrder.GetPay_method().Equals("CREDIT CARD INSTALLMENT"))
                                    _oQuery.Append(_oMobileRetentionOrder.GetBank_code().Trim() + "','");
                                else if (_oMobileRetentionOrder.GetPay_method().Equals("CASH"))
                                    _oQuery.Append("COD','");
                                else if (_oMobileRetentionOrder.GetPay_method().Equals("CREDIT CARD"))
                                    _oQuery.Append("CREDIT CARD FULL PAY','");
                                else
                                    _oQuery.Append(_oMobileRetentionOrder.GetPay_method().Trim() + "','");

                                _oQuery.Append(_oMobileRetentionOrder.GetCard_no().Trim() + "','");
                                _oQuery.Append(_oMobileRetentionOrder.GetCard_holder().Trim() + "','");
                                _oQuery.Append(_oMobileRetentionOrder.GetCard_exp_month() + Func.Right(_oMobileRetentionOrder.GetCard_exp_year(), 2).Trim() + "','");
                                _oQuery.Append(_oMobileRetentionOrder.GetAmount().Trim() + "','");
                                if (_oMobileRetentionOrder.GetCon_eff_date() != null)
                                    _oQuery.Append(Convert.ToDateTime(_oMobileRetentionOrder.GetCon_eff_date()).ToString("MM/dd/yyyy") + "','");
                                else
                                    _oQuery.Append("','");

                                _oQuery.Append(_oMobileRetentionOrder.GetBundle_name().Trim() + "',");
                                _oQuery.Append("'N','N','N','PNS','N','N','N','N','CC RET','EORDER',");

                                if ("".Equals(_oMobileRetentionOrder.GetPremium()))
                                    _oQuery.Append("'N/A',");
                                else
                                    _oQuery.Append("'" + _oMobileRetentionOrder.GetPremium().Trim() + "',");


                                if ("".Equals(_oMobileRetentionOrder.GetExt_place_tel()))
                                    _oQuery.Append("'N/A',");
                                else
                                    _oQuery.Append("'" + _oMobileRetentionOrder.GetExt_place_tel().Trim() + "',");

                                _oQuery.Append("0,");


                                _oQuery.Append("'" + _oMobileRetentionOrder.GetSim_item_name() + "',");
                                _oQuery.Append("'" + _oMobileRetentionOrder.GetSim_item_code().Trim() + "',");
                                _oQuery.Append("''");

                                _oQuery.Append(")");

                                bool _bInsertSuccess = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery.ToString());
                                if (!_bInsertSuccess)
                                    _oEDFStatusProfile.ToEDFError(_oMobileRetentionOrder.GetOrder_id(), "AUTO UPDATE", "", "");

                                if (_bInsertSuccess)
                                {
                                    Response.Write("<script>alert('Insert Success!');</script>");
                                }

                                #endregion
                            }
                            _oDr2.Close();
                            _oDr2.Dispose();
                        }
                    }
                    else
                    {
                        string _sRefNo1 = string.Empty;
                        bool _bAllEDFIMEI = _oEDFStatusProfile.AllowUpdateWebLogEDFIMEI(Func.FR(_oDr[MobileRetentionOrder.Para.edf_no]).Trim(), n_sImei_no);
                        if (_bAllEDFIMEI)
                        {
                            global::System.Text.StringBuilder _oSelectRecordIDSql = new global::System.Text.StringBuilder();
                            _oSelectRecordIDSql.Append(" SELECT RECORD_ID From SUNDAY_AMENT ");
                            _oSelectRecordIDSql.Append(" WHERE ReferenceNo='" + Func.FR(_oDr[MobileRetentionOrder.Para.edf_no]).Trim() + "' ");
                            _oSelectRecordIDSql.Append(" And Field_Name='IMEI' And SUPPORT_PRINT is Null");
                            global::System.Data.Odbc.OdbcDataReader _oDr3 = SYSConn<ODBCConnect>.Connect().GetSearch(_oSelectRecordIDSql.ToString());
                            #region _oDr3
                            if (_oDr3.Read())
                            {
                                #region Update Sunday_Ament
                                global::System.Text.StringBuilder _oUpdateSundayAmentSql = new global::System.Text.StringBuilder();
                                _oUpdateSundayAmentSql.Append(" UPDATE SUNDAY_Ament SET ");
                                _oUpdateSundayAmentSql.Append(" Ament_Date=to_date('" + n_sToday.Trim() + "' ,");
                                _oUpdateSundayAmentSql.Append(" 'dd/mm/yyyy hh24:mi:ss'),AMENT_BY='auto',");
                                _oUpdateSundayAmentSql.Append(" Change_To='" + n_sImei_no.Trim() + "' Where Record_ID='" + Func.FR(_oDr3["record_id"]) + "'");
                                SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oUpdateSundayAmentSql.ToString());
                                #endregion
                            }
                            else
                            {

                                global::System.Text.StringBuilder _oInertSundayAmentSql = new global::System.Text.StringBuilder();

                                _sRefNo1 = _oOrderSerialNumberControl.ReferenceNumber;
                                _oInertSundayAmentSql.Append(" INSERT INTO SUNDAY_Ament (Record_ID  ,Form_Name  ,");
                                _oInertSundayAmentSql.Append(" REFERENCENO,Ament_Date, AMENT_BY ,Field_Name ,Change_From,Change_To ) ");
                                _oInertSundayAmentSql.Append(" Values ('" + _sRefNo1 + "','CC RET','" + Func.FR(_oDr[MobileRetentionOrder.Para.edf_no]) + "',");
                                _oInertSundayAmentSql.Append(" to_date('" + n_sToday + "', 'dd/mm/yyyy hh24:mi:ss'),'auto' ,");
                                _oInertSundayAmentSql.Append(" 'IMEI','" + n_sImei_no + "','" + Func.FR(_oDr["imei_no"]) + "')");
                                bool _bSundayAment = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oInertSundayAmentSql.ToString());


                            }
                            _oDr3.Close();
                            _oDr3.Dispose();
                        }
                            #endregion
                        #region Update Sunday_Form
                        if (_bAllEDFIMEI)
                        {
                            global::System.Text.StringBuilder _oQuery = new global::System.Text.StringBuilder();
                            _oQuery.Append("UPDATE sunday_Form SET ");
                            //** log_date is converted from datetime to string by sql **//
                            _oQuery.Append("Applicat_date = to_date('" + Func.FR(_oDr["log_date"]).ToString() + "','dd/mm/yyyy'),");
                            _oQuery.Append("IMEI = '" + n_sImei_no.Trim() + "',");
                            _oQuery.Append("ament_counter = ament_counter + 1 ,");
                            _oQuery.Append("last_update='" + n_sToday + " auto' ");
                            _oQuery.Append("WHERE referenceNo ='" + Func.FR(_oDr[MobileRetentionOrder.Para.edf_no]) + "'");
                            bool _bSundayFromUpdate = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery.ToString());

                            Response.Write("<script>alert('Update Success!');</script>");
                        }
                        #endregion

                        #region Update MobileRetentionOrder
                        IQueryable<MobileRetentionOrderEntity> _oRwlOrderList =
                        from sRwlOrderList in _oMobileRetentionOrderRepositoryBase.MobileRetentionOrders
                        where
                        sRwlOrderList.edf_no == Func.FR(_oDr[MobileRetentionOrder.Para.edf_no])
                        select sRwlOrderList;
                        if (_oRwlOrderList.Count<MobileRetentionOrderEntity>() > 0)
                        {
                            ISession<MSSQLConnect> _oSession = null;
                            using (_oSession = _oSessionFactory.OpenSession())
                            using (ITransaction _oTransaction = _oSession.BeginTransaction())
                            {
                                n_sRefNo = Func.FR(_oDr[MobileRetentionOrder.Para.edf_no]);
                                if (!string.IsNullOrEmpty(n_sRefNo) && !string.IsNullOrEmpty(n_sImei_no) &&
                                    !n_sImei_no.Trim().ToUpper().Equals("AO") &&
                                    !n_sImei_no.Trim().ToUpper().Equals("AWAIT"))
                                {
                                    MobileRetentionOrderEntity _oMobileRetentionOrderEntity = _oRwlOrderList.First<MobileRetentionOrderEntity>();
                                    _oMobileRetentionOrderEntity.SetDB(SYSConn<MSSQLConnect>.Connect());
                                    _oMobileRetentionOrderEntity.SetEdf_no(n_sRefNo);
                                    _oMobileRetentionOrderEntity.SetImei_no(n_sImei_no);
                                    _oMobileRetentionOrderEntity.SetCid(RWLFramework.CurrentUser[this.Page].Uid);
                                    _oMobileRetentionOrderEntity.SetCdate(DateTime.Now);
                                    _oSession.Update(_oMobileRetentionOrderEntity);
                                    _oTransaction.Commit();
                                }
                            }
                        }
                        #endregion
                    }
                    if (_oEDFStatusProfile.AllowUpdateWebLogEDFIMEI(n_sRefNo, n_sImei_no) && !string.IsNullOrEmpty(RWLFramework.CurrentUser[this.Page].Uid) && !string.IsNullOrEmpty(Func.FR(_oDr[MobileRetentionOrder.Para.order_id]).Trim()))
                    {
                        string _sQueryUpdate = "UPDATE MobileRetentionOrder SET imei_no='" + n_sImei_no + "',edf_no='" + n_sRefNo + "',cid='" + RWLFramework.CurrentUser[this.Page].Uid + "',cdate=getdate() WHERE order_id='" + Func.FR(_oDr[MobileRetentionOrder.Para.order_id]).Trim() + "'";
                        SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_sQueryUpdate);
                    }
                }
            }
            _oDr.Close();
            _oDr.Dispose();
            #region Update IMEI Stock
            global::System.Text.StringBuilder _oUpdateIMEIStockSql = new global::System.Text.StringBuilder();
            _oUpdateIMEIStockSql.Append(" UPDATE IMEI_Stock SET STAFF_RECD=null ");
            _oUpdateIMEIStockSql.Append(" WHERE Dummy2='CC RET' ");
            _oUpdateIMEIStockSql.Append(" AND Status='STOCK' AND STAFF_RECD='" + RWLFramework.CurrentUser[this.Page].Uid + "'");
            bool _bUpdated = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oUpdateIMEIStockSql.ToString());
            #endregion

        }
        return false;
    }
    #endregion




    protected void CreateAOAWAITRecord(int x_iOrder_id, string x_sStatus)
    {
        MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect(), x_iOrder_id);
        if (_oMobileRetentionOrder.GetFound())
        {
            string _sRecordId = Func.IDAdd100000(x_iOrder_id);
            string _sEdf_no = _sRecordId;
            if (x_sStatus != "AO")
            {
                _sEdf_no = _oMobileRetentionOrder.GetEdf_no();
            }
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("SELECT * FROM IMEI_STOCK WHERE ");
            _oQuery.Append(" IMEI='' AND ");
            _oQuery.Append(" KIT_CODE='" + _oMobileRetentionOrder.GetSku() + "' AND ");
            _oQuery.Append(" Status='" +x_sStatus + "' AND ");
            _oQuery.Append(" DUMMY4='" + Func.IDAdd100000(_oMobileRetentionOrder.GetOrder_id()) + "' AND ");
            
            OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(_oQuery.ToString());
            if (!_oDr.Read())
            {
                string _sQuery2 = "INSERT INTO IMEI_Stock (Kit_Code,Model,Status,DUMMY4,ReferenceNo,Create_Date,Create_By,StaffNo,Dummy2,Dummy3) VALUES ('" + _oMobileRetentionOrder.GetSku().Trim() + "','" + _oMobileRetentionOrder.GetHs_model().Trim() + "','" + x_sStatus + "','" + _sRecordId + "','" + _sEdf_no + "',to_date('" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "' , 'dd/mm/yyyy hh24:mi:ss'),'" + _oMobileRetentionOrder.GetStaff_no().Trim() + "','" + _oMobileRetentionOrder.GetStaff_no().Trim() + "','CC RET','" + _oMobileRetentionOrder.GetDelivery_exchange_location() + "' ) ";
                bool _bInsertAO = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_sQuery2);
                if (_bInsertAO)
                {
                    Response.Write("<script>alert('success!');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Fail!');</script>");
                }
            }
            _oDr.Close();
            _oDr.Dispose();
        }
    }

    protected void CreateAORecord(int x_iOrder_id, string x_sStatus)
    {
        MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect(), x_iOrder_id);
        if (_oMobileRetentionOrder.GetFound())
        {
            string _sRecordId = Func.IDAdd100000(x_iOrder_id);
            string _sEdf_no = _sRecordId;
            if (x_sStatus != "AO")
            {
                _sEdf_no = _oMobileRetentionOrder.GetEdf_no();
            }
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("SELECT * FROM IMEI_STOCK WHERE ");
            _oQuery.Append(" IMEI='' AND ");
            _oQuery.Append(" KIT_CODE='" + _oMobileRetentionOrder.GetSku() + "' AND ");
            _oQuery.Append(" Status='" + x_sStatus + "' AND ");
            _oQuery.Append(" DUMMY4='" + Func.IDAdd100000(_oMobileRetentionOrder.GetOrder_id()) + "' AND ");

            OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(_oQuery.ToString());
            if (!_oDr.Read())
            {
                string _sQuery2 = "INSERT INTO IMEI_Stock (Kit_Code,Model,Status,DUMMY4,ReferenceNo,Create_Date,Create_By,StaffNo,Dummy2,Dummy3) VALUES ('" + _oMobileRetentionOrder.GetSku().Trim() + "','" + _oMobileRetentionOrder.GetHs_model().Trim() + "','" + x_sStatus + "','" + _sRecordId + "','" + _sEdf_no + "',to_date('" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "' , 'dd/mm/yyyy hh24:mi:ss'),'" + _oMobileRetentionOrder.GetStaff_no().Trim() + "','" + _oMobileRetentionOrder.GetStaff_no().Trim() + "','CC RET','" + _oMobileRetentionOrder.GetDelivery_exchange_location() + "' ) ";
                bool _bInsertAO = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_sQuery2);
                if (_bInsertAO)
                {
                    Response.Write("<script>alert('success!');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Fail!');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Fail!');</script>");
            }
            _oDr.Close();
            _oDr.Dispose();
        }
    }

    public bool IMEIRelease(string x_sIMEI, string x_sKIT_CODE)
    {
        if (string.IsNullOrEmpty(x_sIMEI)) return false;
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("UPDATE imei_stock SET referenceno='', status='NORMAL', staff_recd='', DUMMY4='', dummy1='' ");
        _oQuery.Append("WHERE imei='" + x_sIMEI + "' AND kit_code='" + x_sKIT_CODE + "' AND status='SOLD' AND dummy2='CC RET' AND rownum<=1");

        bool _bReleaseIMEI = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery.ToString());
        return _bReleaseIMEI;
    }


    protected void ResetSearch_Click(object sender, EventArgs e)
    {
        EnabledUpdate(false);
        ClearData();
    }



    protected bool CheckIMEINoInDB(string x_sIMEI)
    {
        if (string.IsNullOrEmpty(x_sIMEI)) return false;
        x_sIMEI = x_sIMEI.Trim();
        OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT imei FROM sunday_Form  WHERE referenceNo is not null AND referenceNo<>'' AND imei='" + x_sIMEI + "' AND rownum<=1");
        if (_oDr.Read())
        {
            if (!Func.FR(_oDr["imei"]).Trim().Equals(string.Empty))
            {
                _oDr.Close();
                _oDr.Dispose();
                return true;
            }
        }
        _oDr.Close();
        _oDr.Dispose();
        return false;
    }

    protected void ClearData()
    {
        RetentionRecordOverView1._rwl_edf_no.Text = string.Empty;
        RetentionRecordOverView1._rwl_hs_model.Text = string.Empty;
        RetentionRecordOverView1._rwl_imei_no.Text = string.Empty;
        RetentionRecordOverView1._rwl_order_id.Text = string.Empty;
        RetentionRecordOverView1._rwl_record_id.Text = string.Empty;
        RetentionRecordOverView1._rwl_sku.Text = string.Empty;

        RetentionRecordOverView1._edf_actural_delivery.Text = string.Empty;
        RetentionRecordOverView1._edf_dn_remark.Text = string.Empty;
        RetentionRecordOverView1._edf_edf_no.Text = string.Empty;
        RetentionRecordOverView1._edf_expect_delivery.Text = string.Empty;
        RetentionRecordOverView1._edf_hs_model.Text = string.Empty;
        RetentionRecordOverView1._edf_imei_no.Text = string.Empty;
        RetentionRecordOverView1._edf_record_id.Text = string.Empty;
        RetentionRecordOverView1._edf_remark.Text = string.Empty;
        RetentionRecordOverView1._edf_sku.Text = string.Empty;

        RetentionRecordOverView1._imei_edf_no.Text = string.Empty;
        RetentionRecordOverView1._imei_hs_model.Text = string.Empty;
        RetentionRecordOverView1._imei_imei_no.Text = string.Empty;
        RetentionRecordOverView1._imei_record_id.Text = string.Empty;
        RetentionRecordOverView1._imei_remark.Text = string.Empty;
        RetentionRecordOverView1._imei_sku.Text = string.Empty;
        RetentionRecordOverView1._imei_status.Text = string.Empty;
    }
}
