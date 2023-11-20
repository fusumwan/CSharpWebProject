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
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Odbc;
using System.Globalization;
using System.Text;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;
using log4net.Config;

public partial class Web_ModifyEDF : NEURON.WEB.UI.BasePage
{
    string _sRemarkError = string.Empty;
    EDFStatusProfile _oEDFStatusProfile = new EDFStatusProfile();
    OrderSerialNumberControl _oOrderSerialNumberControl = new OrderSerialNumberControl();
    MobileOrderAddress _oRegisteredAddress = new MobileOrderAddress();
    MobileOrderAddress _oBillingAddress = new MobileOrderAddress();
    MobileOrderMNPDetail _oMobileOrderMNPDetail = new MobileOrderMNPDetail();
    MobileOrderThreeParty _oMobileOrderThreeParty = new MobileOrderThreeParty();
    List<MobileOrderVasEntity> _oMobileOrderVasArr = new List<MobileOrderVasEntity>();
    SundayActivation _oSundayActivation = new SundayActivation();
    string x_sMobileNumber = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        CheckRefeshOrderPage();
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
        RWLFramework.InitModel();
        try
        {
            if (!IsPostBack) InitFrame();
        }
        catch (Exception ex)
        {
            ILog log = LogManager.GetLogger(WebFunc.qsOrder_id.ToString());
            BasicConfigurator.Configure();
            log4net.GlobalContext.Properties["order_id"] = WebFunc.qsOrder_id.ToString();
            log4net.GlobalContext.Properties["cid"] = RWLFramework.CurrentUser[this.Page].Uid;
            log4net.GlobalContext.Properties["ClientIP"] = Request.UserHostAddress;
            log4net.GlobalContext.Properties["Exception"] = ex.ToString();
            log4net.GlobalContext.Properties["Path"] = Request.RawUrl;
            log.Error(ex.StackTrace.ToString());
            Server.Transfer("~/500.aspx");
        }
    }
    public void InitFrame()
    {
        record_id.Text = Func.IDAdd100000(WebFunc.qsOrder_id);
        if (WebFunc.qsOrder_id != null)
        {
            _oEDFStatusProfile.CheckIMEISTOCK(WebFunc.qsOrder_id);
			ModifyEDF();
        }
        RWLviewrow1.SetOrderid((int)WebFunc.qsOrder_id);
        RWLviewrow1.LoadOrder();
        MobileOrderLockControl.Instance().RemoveMobileOrderLock(x_sMobileNumber);
    }
    protected void CheckRefeshOrderPage()
    {
        bool _bFlag = true;
        if (Session["ModifyOrderWeblogProcess"] != null)
        {
            if (Session["ModifyOrderWeblogProcess"].ToString() != "ModifyOrderWeblogProcess")
            {
                _bFlag = false;
            }
        }
        else
            _bFlag = false;

        if (!_bFlag) { 
            Response.Redirect("MobileOrderLockMessage.aspx?OrderLockMsg=Cannot refesh the page!");
        }
    }

    protected void AssignIMEIControl(int? x_iOrder_id, string x_sUid)
    {
        if (x_iOrder_id == null) return;
        int _iRecordID = (int)x_iOrder_id + 100000;
        MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect());
        _oMobileRetentionOrder.SetOrder_id(x_iOrder_id);
        if (_oMobileRetentionOrder.Retrieve())
        {
            if (_oMobileRetentionOrder.GetFound() == true)
            {
                AssignIMEIControl _oAssignIMEIControl = new AssignIMEIControl();
                if (
                    (_oMobileRetentionOrder.GetImei_no().Trim().Equals("AO") || _oMobileRetentionOrder.GetImei_no().Trim().Equals("AWAIT"))
                    &&
                    !_oMobileRetentionOrder.GetSku().Equals(string.Empty)
                    &&
                    !string.IsNullOrEmpty(x_sUid)
                    )
                {
                    string _sIMEI = SYSConn<ODBCConnect>.Connect().GetExecuteScalar("SELECT IMEI FROM IMEI_STOCK WHERE STATUS='STOCK' AND DUMMY4='" + _iRecordID.ToString() + "' AND ROWNUM<=1");
                    if (!string.IsNullOrEmpty(_sIMEI))
                    {
                        if (_oAssignIMEIControl.UploadStockOrder(_iRecordID, x_sUid, _sIMEI, _oMobileRetentionOrder.GetSku()))
                        {
                            //Response.Write("<script>alert(\"Success Sync To EDF!\")</script>");
                            (new MobileAssignListViewDAO()).Reset();
                        }
                    }
                }
            }
        }
    }

    protected void ModifyEDF()
    {
        bool bFlag = false;
        bool bIssue = false;
        string _sToday = DateTime.Now.ToString("yyy-MM-dd HH:mm:ss");
        string _sToday1 = DateTime.Now.ToString("yyyy-MM-dd");
        string _sRemarksEDF = string.Empty;
        MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect(), WebFunc.qsOrder_id);
        if (!_oMobileRetentionOrder.GetFound()) return;
        if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetEdf_no())) return;
        if (!_oOrderSerialNumberControl.CheckEdfNoInDB(_oMobileRetentionOrder.GetEdf_no()) && _oMobileRetentionOrder.GetOrder_id() != null)
        {
            if (!_oEDFStatusProfile.InsertEDF((int)_oMobileRetentionOrder.GetOrder_id(),3)) { return; }
        }
        if (_oMobileRetentionOrder.GetMrt_no() != null)
            x_sMobileNumber = ((int)_oMobileRetentionOrder.GetMrt_no()).ToString();
        GetMobileRetentionOrderLeftJoinTableData((int)_oMobileRetentionOrder.GetOrder_id(), _oMobileRetentionOrder.GetEdf_no());
        //start
        if (_oEDFStatusProfile.AllowUpdateEDFIMEI(_oMobileRetentionOrder.GetEdf_no(), _oMobileRetentionOrder.GetImei_no(), Func.IDAdd100000(_oMobileRetentionOrder.GetOrder_id())))
        {

            OdbcDataReader _oReader = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT * FROM sunday_form WHERE referenceNo ='" + _oMobileRetentionOrder.GetEdf_no() + "'");
            if (_oReader.Read())
            {
                if (Func.FR(_oReader["cancelled"]).ToUpper().Equals("Y"))
                {
                    Response.Write("<script>window.close()</script>");
                    //Response.End();
                }
                //int _iEdfXSize = 78;
                //int _iEdfYSize = 6;
                if (Func.FR(_oReader["issue"]).ToUpper().Equals("Y"))
                {
                    bIssue = true;
                    _oEDFStatusProfile.AddEDFAmentLog((int)_oMobileRetentionOrder.GetOrder_id(), RWLFramework.CurrentUser[this.Page].Uid, bIssue);
 

                    _sRemarksEDF = Func.FR(_oReader["remark"]).Trim();
                }// if issue is equal to 'Y'
            }
            _oReader.Close();
            _oReader.Dispose();
            bFlag = _oEDFStatusProfile.UpdateEDF((int)_oMobileRetentionOrder.GetOrder_id(), RWLFramework.CurrentUser[this.Page].Uid, Request.ServerVariables["REMOTE_ADDR"].ToString(), !bIssue);
        }
        Session["ModifyOrderWeblogProcess"] = string.Empty;
        if (bFlag)
        {
            Response.Write("<script>alert(\"Updated EDF(" + _oMobileRetentionOrder.GetEdf_no() + ")\")</script>");
            AssignIMEIControl(WebFunc.qsOrder_id, RWLFramework.CurrentUser[this.Page].Uid);
        }
        else
        {
            Response.Write("<script>alert(\"SYSTEM ERROR: Update Failed EDF(" + _oMobileRetentionOrder.GetEdf_no() + ")\")</script>");
        }
        if (!bFlag)
            _oEDFStatusProfile.ModifyEDFError(WebFunc.qsOrder_id, RWLFramework.CurrentUser[this.Page].Uid, _sRemarkError,"");
        
    }

    protected void GetMobileRetentionOrderLeftJoinTableData(int x_iOrder_id, string x_sEdf_no)
    {
        _oRegisteredAddress = new MobileOrderAddress(SYSConn<MSSQLConnect>.Connect(), x_iOrder_id, "REGISTERED_ADDRESS");
        _oBillingAddress = new MobileOrderAddress(SYSConn<MSSQLConnect>.Connect(), x_iOrder_id, "BILLING_ADDRESS");
        _oMobileOrderMNPDetail = new MobileOrderMNPDetail();
        _oMobileOrderThreeParty = new MobileOrderThreeParty();
        MobileOrderMNPDetailEntity[] _oMobileOrderMNPDetailArr = MobileOrderMNPDetailRepository.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), 0, "order_id='" + x_iOrder_id.ToString() + "'", null, null);
        if (_oMobileOrderMNPDetailArr != null)
        {
            if (_oMobileOrderMNPDetailArr.Length > 0)
            {
                _oMobileOrderMNPDetail = (MobileOrderMNPDetail)_oMobileOrderMNPDetailArr[0];
            }
        }
        MobileOrderThreePartyEntity[] _oMobileOrderThreePartyArr = MobileOrderThreePartyRepository.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), 0, "order_id='" + x_iOrder_id.ToString() + "'", null, null);
        if (_oMobileOrderThreePartyArr != null)
        {
            if (_oMobileOrderThreePartyArr.Length > 0)
            {
                _oMobileOrderThreeParty = (MobileOrderThreeParty)_oMobileOrderThreePartyArr[0];
            }
        }

        _oMobileOrderVasArr = MobileOrderVasRepository.GetListObj(SYSConn<MSSQLConnect>.Connect(), -1, "order_id='" + x_iOrder_id.ToString() + "'", null, null);
        if(!string.IsNullOrEmpty(x_sEdf_no))
            _oSundayActivation.Load(x_sEdf_no);
    }

    protected string FindVasValue1(string x_sVas_Field)
    {
        if (_oMobileOrderVasArr != null)
        {
            for (int i = 0; i < _oMobileOrderVasArr.Count; i++)
            {
                if (_oMobileOrderVasArr[i].vas_field.ToUpper().Trim().Equals(x_sVas_Field.ToUpper().Trim()))
                    return _oMobileOrderVasArr[i].vas_value;
            }
        }
        return string.Empty;
    }

    protected bool ModifySIM(string x_sEDF, string x_sSim_item_code, string x_sSim_item_name)
    {
        if (string.IsNullOrEmpty(x_sEDF)) return false;
        string _sSim_item_number = MobileRetentionOrderBal.GetSim_Number(x_sEDF).Trim();
        string _sSim_item_code = SYSConn<ODBCConnect>.Connect().GetExecuteScalar("SELECT RESERVE FROM sunday_sim_no WHERE  referenceno='" + x_sEDF + "' AND sim_no='" + _sSim_item_number.Trim() + "' AND rownum<=1");
        if (x_sSim_item_code != _sSim_item_code)
        {
            SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("UPDATE sunday_sim_no SET REFERENCENO='' WHERE  RESERVE='" + _sSim_item_code + "' AND REFERENCENO='" + x_sEDF + "' AND sim_no='" + _sSim_item_number.Trim() + "' AND DUMMY1='SIM CARD CC RET' AND rownum<=1");
            SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("UPDATE sunday_form SET SIM_CARD_NO='', SIM_CARD_TYPE='" + x_sSim_item_name + "',SIM_ITEM_CODE='" + x_sSim_item_code + "' WHERE REFERENCENO='" + x_sEDF + "' AND SIM_CARD_NO='" + _sSim_item_number.Trim() + "' AND CREATED_BY='CC RET' AND rownum<=1");
            return true;
        }
        return false;
    }

    #region Get Sql DB
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
        _oDB.SetConnStr(Configurator.DBName.ORADNS + ((!"".Equals(Configurator.IsUat())) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion
}
