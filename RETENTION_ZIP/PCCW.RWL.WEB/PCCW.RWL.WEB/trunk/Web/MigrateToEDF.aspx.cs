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
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Odbc;
using System.Text;
using System.Globalization;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;
using log4net.Config;

public partial class MigrateToEDF : NEURON.WEB.UI.BasePage
{

    EDFStatusProfile _oEDFStatusProfile = new EDFStatusProfile();
    OrderSerialNumberControl _oOrderSerialNumberControl = new OrderSerialNumberControl();

    string n_sToday1 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
    string n_sMobileNumber = string.Empty;
    bool n_sAllowInsertEDF = true;
    bool _bInsert = false;
    string _sRemarkError = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        CheckRefeshOrderPage();

        if (!string.IsNullOrEmpty(WebFunc.qsMrt_no))
        {
            if (CheckDuplicateEDFMrt(WebFunc.qsMrt_no))
            {
                Response.Redirect("MobileOrderLockMessage.aspx?OrderLockMsg=The mobile number : " + WebFunc.qsMrt_no + " has been used in EDF system before!");
            }
        }

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


        MobileOrderLockControl.Instance().RemoveMobileOrderLock(n_sMobileNumber);
    }


    protected void CheckRefeshOrderPage()
    {
        bool _bFlag = true;
        if (Session["IssueOrderWeblogProcess"] != null)
        {
            if (Session["IssueOrderWeblogProcess"].ToString() != "IssueOrderWeblogProcess")
            {
                _bFlag = false;
            }
        }
        else
            _bFlag = false;

        if (!_bFlag)
        {
            Response.Redirect("MobileOrderLockMessage.aspx?OrderLockMsg=Cannot refesh the page!");
        }
    }

    protected string RE(object x_oObj, string x_sDateTimeFormat)
    {
        if (x_oObj == null) return string.Empty;
        if (x_oObj is DateTime || x_oObj is DateTime?)
        {
            string Format = (x_sDateTimeFormat.Equals(string.Empty)) ? "dd/MM/yyyy" : x_sDateTimeFormat;
            return Convert.ToDateTime(x_oObj).ToString(Format);
        }
        return x_oObj.ToString();
    }

    protected string RE(object x_oObj)
    {
        return RE(x_oObj, string.Empty);
    }
    protected void InitFrame()
    {
        string _sToday = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        string _sToday1 = DateTime.Now.ToString("yyyyMMdd");
        string _sTime1 = DateTime.Now.ToString("HH:mm:ss");
        string _sItemLocation = string.Empty;
        string _sDeliveryType = "HS";
        if (WebFunc.qsOrder_id != null)
        {
            _sRemarkError = "Back Up Order";
            int _iOrder_id = Convert.ToInt32(WebFunc.qsOrder_id);
            _oOrderSerialNumberControl.SetOrder_id(_iOrder_id);
            MobileRetentionOrderBal.BackUpOrder(_iOrder_id, RWLFramework.CurrentUser[this.Page].Uid);
            MobileRetentionOrder _oMobileRetentionOrder = (MobileRetentionOrder)MobileRetentionOrderRepository.CreateEntityInstanceObject();
            _oMobileRetentionOrder.SetOrder_id(_iOrder_id);
            if (!_oMobileRetentionOrder.Retrieve()) return;
            if (_oMobileRetentionOrder.GetMrt_no() != null)
                n_sMobileNumber = ((int)_oMobileRetentionOrder.GetMrt_no()).ToString();
            _sRemarkError = "Re-Active Order";
            _sItemLocation = _oMobileRetentionOrder.GetDelivery_exchange_location().Trim();
            if (_sItemLocation == string.Empty) _sItemLocation = "PLG";

            if ("re-act".Equals(WebFunc.qsAction))
            {
                _oMobileRetentionOrder.SetGift_code(null);
                _oMobileRetentionOrder.SetGift_code2(null);
                _oMobileRetentionOrder.SetGift_code3(null);
                _oMobileRetentionOrder.SetGift_code4(null);
                _oMobileRetentionOrder.SetAccessory_code(null);
                _oMobileRetentionOrder.SetGift_imei(null);
                _oMobileRetentionOrder.SetGift_imei2(null);
                _oMobileRetentionOrder.SetGift_imei3(null);
                _oMobileRetentionOrder.SetGift_imei4(null);
                _oMobileRetentionOrder.SetAccessory_imei(null);
                if (_oMobileRetentionOrder.GetEdf_no() != string.Empty)
                    _oMobileRetentionOrder.SetImei_no("AWAIT");
                else
                    _oMobileRetentionOrder.SetImei_no(string.Empty);

                _oMobileRetentionOrder.SetEdf_no(string.Empty);

                bool _bUpdate = false;
                using (ISession<MSSQLConnect> _oSession = (new SessionFactory<MSSQLConnect>()).OpenSession())
                using (ITransaction _oTransaction = _oSession.BeginTransaction())
                {
                    _bUpdate = _oSession.Update(_oMobileRetentionOrder);
                    if (_bUpdate)
                        _oTransaction.Commit();
                    else
                        _oTransaction.Rollback();
                }
                if (!_bUpdate)
                    throw new BusinessObjectNotFoundException("Re-Active Order Error: Update Retention Web Log order id:" + _iOrder_id.ToString() + " Fail!");
            }

            DateTime _dOldDate, _dNewDate;
            string _sActDate = string.Empty;
            int _iGo_wireless = 0;
            if (_oMobileRetentionOrder.GetD_date() != null)
            {
                _dOldDate = (DateTime)_oMobileRetentionOrder.GetD_date();
                _dNewDate = _dOldDate.AddDays(3);
                _sActDate = _dNewDate.ToString("dd/MM/yyyy HH:mm:ss");
            }

            if (_oMobileRetentionOrder.GetGo_wireless() != "NO" && !string.IsNullOrEmpty(_oMobileRetentionOrder.GetGo_wireless()))
                _iGo_wireless = 1;
            //Page.Request.FilePath.ToString();
            //-- Check by record storing in database (_oCheckToEDF)----------------------
            MobileOrderAllowToEDFChk _oCheckToEDF = new MobileOrderAllowToEDFChk();
            _oCheckToEDF.SetSku(_oMobileRetentionOrder.GetSku());
            _oCheckToEDF.SetImei_no(_oMobileRetentionOrder.GetImei_no());
            _oCheckToEDF.SetSim_item_code(_oMobileRetentionOrder.GetSim_item_code());
            _oCheckToEDF.SetSim_item_number(_oMobileRetentionOrder.GetSim_item_number());
            //-- Check by record storing in database (_oCheckToEDF)----------------------

            // if hv sku or sim
            #region sku!=null, _iGo_wireless, sim!=null
            if (
                ((!"".Equals(_oMobileRetentionOrder.GetSku().Trim()) && !"0".Equals(_oMobileRetentionOrder.GetSku().Trim())) || _iGo_wireless == 1 ||
               (
               "UPGRADE".Equals(_oMobileRetentionOrder.GetIssue_type().Trim()) ||
                "MOBILE_LITE".Equals(_oMobileRetentionOrder.GetIssue_type().Trim()) ||
                "OLD_MOBILE_LITE".Equals(_oMobileRetentionOrder.GetIssue_type().Trim())
                )
                )
||
                _oCheckToEDF.allowToEDF())
            {
                string _sRefNo = string.Empty;
                string _sImei_no = string.Empty;
                string _sSim_no = string.Empty;
                string _sHs_imei_no = string.Empty;
                SIMControl _oSIMControl = new SIMControl();

                // if hv sku
                #region If sku!=null, sim!=null
                if ((!"".Equals(_oMobileRetentionOrder.GetSku().Trim()) && !"0".Equals(_oMobileRetentionOrder.GetSku().Trim())) ||
                        (
                         "UPGRADE".Equals(_oMobileRetentionOrder.GetIssue_type().Trim()) ||
                        "MOBILE_LITE".Equals(_oMobileRetentionOrder.GetIssue_type().Trim()) ||
                        "OLD_MOBILE_LITE".Equals(_oMobileRetentionOrder.GetIssue_type().Trim())
                        )
                        || _oCheckToEDF.allowToEDF())
                {
                    #region If sku!=null
                    if ((!"".Equals(_oMobileRetentionOrder.GetSku().Trim())) && (!"0".Equals(_oMobileRetentionOrder.GetSku().Trim())))
                    {
                        _sDeliveryType = "HS";
                        _sRemarkError = "Get Normal IMEI Order";
                        OdbcDataReader _oDr2 = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT * FROM IMEI_Stock WHERE Dummy2='CC RET' AND Kit_Code='" + _oMobileRetentionOrder.GetSku().Trim() + "' AND IMEI<>' ' AND Status='NORMAL' AND DUMMY3='" + _sItemLocation + "' order by IMEI ");

                        // if hv imei in stock and the 1st imei
                        if (_oDr2.Read() && _sImei_no.Trim().Equals(string.Empty))
                        {
                            if (_sRefNo == string.Empty) { _sRefNo = _oOrderSerialNumberControl.ReferenceNumber; }
                            _sImei_no = Func.FR(_oDr2["IMEI"]);
                            n_sAllowInsertEDF = _oEDFStatusProfile.AllowAssignNormalIMEI(_sImei_no, Func.IDAdd100000(WebFunc.qsOrder_id));
                            if (n_sAllowInsertEDF && _sImei_no != string.Empty)
                            {
                                AoInStockControl _oAoInStockControl = new AoInStockControl();
                                _oAoInStockControl.SetImei_no(Func.FR(_oDr2["IMEI"]));
                                _oAoInStockControl.SetOrder_id(Func.RQ(WebFunc.qsOrder_id));
                                _oAoInStockControl.SetKit_Code(Func.FR(_oDr2["Kit_Code"]));
                                _oAoInStockControl.SetModel(Func.FR(_oDr2["Model"]));
                                _oAoInStockControl.SetStatus(Func.FR(_oDr2["Status"]));
                                _oAoInStockControl.SetReferenceNo(Func.FR(_oDr2["ReferenceNo"]));
                                _oAoInStockControl.SetDummy4(Func.FR(_oDr2["DUMMY4"]));
                                _oAoInStockControl.SetToday(_sToday);
                                _oAoInStockControl.SetUid(RWLFramework.CurrentUser[this.Page].Uid);
                                _oAoInStockControl.SetStock_In_Date(Func.FR(_oDr2["DUMMY4"]));
                                _oAoInStockControl.SetAment_Date(Func.FR(_oDr2["IMEI"]));
                                _oAoInStockControl.SetToday1(_sToday1);
                                _oAoInStockControl.SetStaff_no(_oMobileRetentionOrder.GetStaff_no());
                                _oAoInStockControl.SetCreateDate(Func.FR(_oDr2["Create_Date"]));
                                _oAoInStockControl.SetDummy1(Func.FR(_oDr2["Dummy1"]));
                                _oAoInStockControl.SetDummy2(Func.FR(_oDr2["Dummy2"]));
                                _oAoInStockControl.SetRefNo(_sRefNo);
                                if (_oMobileRetentionOrder.GetMrt_no() != null) _oAoInStockControl.SetMrt_no(Convert.ToInt32(_oMobileRetentionOrder.GetMrt_no()).ToString());
                                _oAoInStockControl.UpdateSoldStatus(ref _oMobileRetentionOrder);
                            }
                            else
                            {
                                _sImei_no = string.Empty;
                            }
                        }
                        else if (_oCheckToEDF.allowToEDF())
                        {
                            if (_sRefNo == string.Empty) { _sRefNo = _oOrderSerialNumberControl.ReferenceNumber; }
                        }
                        _oDr2.Close();
                        _oDr2.Dispose();

                        if (_sImei_no.Trim().Equals(string.Empty) && _oCheckToEDF.allowToEDF())
                        {
                            _sRemarkError = "Insert AWAIT order in STOCK table";
                            //=== if NO stock -> insert AWAIT order in STOCK table because need to up to EDF ===
                            //_sRefNo = string.Empty;
                            if (_sRefNo == string.Empty) { _sRefNo = _oOrderSerialNumberControl.ReferenceNumber; }
                            _sImei_no = "AWAIT";

                            // check if there is AO record
                            StringBuilder _oCheckAOImei_1 = new StringBuilder();
                            _oCheckAOImei_1.Append("SELECT IMEI FROM IMEI_Stock WHERE ");
                            _oCheckAOImei_1.Append(" kit_code='" + _oMobileRetentionOrder.GetSku() + "' ");
                            _oCheckAOImei_1.Append(" AND (Status='AO' OR Status='STOCK') ");
                            _oCheckAOImei_1.Append(" AND DUMMY4='" + Func.IDAdd100000(Convert.ToInt32(_oMobileRetentionOrder.GetOrder_id())) + "' ");
                            _oCheckAOImei_1.Append(" AND ReferenceNo='" + Func.IDAdd100000(Convert.ToInt32(_oMobileRetentionOrder.GetOrder_id())) + "' ");
                            _oCheckAOImei_1.Append(" AND Dummy2='CC RET'");
                            OdbcDataReader _oCheckAOImei_1Dr = SYSConn<ODBCConnect>.Connect().GetSearch(_oCheckAOImei_1.ToString());
                            if (_oCheckAOImei_1Dr.Read())
                            {
                                // update "AO" to "AWAIT"
                                StringBuilder _oUpdateAOImeiToAWAITQuery = new StringBuilder();
                                _oUpdateAOImeiToAWAITQuery.Append("UPDATE IMEI_Stock SET Status='AWAIT' WHERE ");
                                _oUpdateAOImeiToAWAITQuery.Append(" kit_code='" + _oMobileRetentionOrder.GetSku() + "' ");
                                _oUpdateAOImeiToAWAITQuery.Append(" AND Status='AO' ");
                                _oUpdateAOImeiToAWAITQuery.Append(" AND DUMMY4='" + Func.IDAdd100000(Convert.ToInt32(_oMobileRetentionOrder.GetOrder_id())) + "' ");
                                _oUpdateAOImeiToAWAITQuery.Append(" AND ReferenceNo='" + Func.IDAdd100000(Convert.ToInt32(_oMobileRetentionOrder.GetOrder_id())) + "' ");
                                _oUpdateAOImeiToAWAITQuery.Append(" AND Dummy2='CC RET'");

                                SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oUpdateAOImeiToAWAITQuery.ToString());

                            }
                            _oCheckAOImei_1Dr.Close();
                            _oCheckAOImei_1Dr.Dispose();


                            StringBuilder _oCheckAwaitImei = new StringBuilder();
                            _oCheckAwaitImei.Append("SELECT IMEI FROM IMEI_Stock WHERE ");
                            _oCheckAwaitImei.Append(" KIT_CODE='" + _oMobileRetentionOrder.GetSku() + "' ");
                            _oCheckAwaitImei.Append(" AND (Status='AWAIT' OR Status='STOCK') ");
                            _oCheckAwaitImei.Append(" AND DUMMY4='" + Func.IDAdd100000(Convert.ToInt32(_oMobileRetentionOrder.GetOrder_id())) + "' ");
                            _oCheckAwaitImei.Append(" AND Dummy2='CC RET'");
                            WebFunc.SaveQuery(this.Page, _oCheckAwaitImei.ToString());
                            OdbcDataReader _oCheckAODr = SYSConn<ODBCConnect>.Connect().GetSearch(_oCheckAwaitImei.ToString());
                            if (!_oCheckAODr.Read())
                            {
                                StringBuilder _oQuery = new StringBuilder();
                                _oQuery.Append("INSERT INTO IMEI_Stock (Kit_Code,Model,Status,DUMMY4,ReferenceNo,Create_Date,Create_By,StaffNo,Dummy2,Dummy3) values ('" + _oMobileRetentionOrder.GetSku() + "','" + _oMobileRetentionOrder.GetHs_model() + "','AWAIT','" + Func.IDAdd100000(Convert.ToInt32(_oMobileRetentionOrder.GetOrder_id())) + "','" + _sRefNo + "',to_date('" + n_sToday1 + "' , 'dd/mm/yyyy hh24:mi:ss'),'" + _oMobileRetentionOrder.GetStaff_no() + "','" + _oMobileRetentionOrder.GetStaff_no().Trim() + "','CC RET','"+_oMobileRetentionOrder.GetDelivery_exchange_location()+"' ) ");
                                SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery.ToString());
                                WebFunc.SaveQuery(this.Page, _oQuery.ToString());
                            }
                            _oCheckAODr.Close();
                            _oCheckAODr.Dispose();
                        }
                        else if (_sImei_no.Trim().Equals(string.Empty))
                        {
                            _sRemarkError = "Insert AO order in STOCK table";
                            //=== if NO stock -> insert AO order in STOCK table ===
                            _sRefNo = string.Empty;
                            _sImei_no = "AO";
                            StringBuilder _oCheckAOImei = new StringBuilder();
                            _oCheckAOImei.Append("SELECT IMEI FROM IMEI_Stock WHERE ");
                            _oCheckAOImei.Append(" KIT_CODE='" + _oMobileRetentionOrder.GetSku() + "' ");
                            _oCheckAOImei.Append(" AND (Status='AO' OR Status='STOCK') ");
                            _oCheckAOImei.Append(" AND DUMMY4='" + Func.IDAdd100000(Convert.ToInt32(_oMobileRetentionOrder.GetOrder_id())) + "' ");
                            _oCheckAOImei.Append(" AND Dummy2='CC RET'");
                            WebFunc.SaveQuery(this.Page, _oCheckAOImei.ToString());
                            OdbcDataReader _oCheckAODr = SYSConn<ODBCConnect>.Connect().GetSearch(_oCheckAOImei.ToString());
                            if (!_oCheckAODr.Read())
                            {

                                StringBuilder _oQuery = new StringBuilder();
                                _oQuery.Append("INSERT INTO IMEI_Stock (Kit_Code,Model,Status,DUMMY4,ReferenceNo,Create_Date,Create_By,StaffNo,Dummy2,Dummy3) values ('" + _oMobileRetentionOrder.GetSku() + "','" + _oMobileRetentionOrder.GetHs_model() + "','AO','" + Func.IDAdd100000(Convert.ToInt32(_oMobileRetentionOrder.GetOrder_id())) + "','" + Func.IDAdd100000(Convert.ToInt32(_oMobileRetentionOrder.GetOrder_id())) + "',to_date('" + n_sToday1 + "' , 'dd/mm/yyyy hh24:mi:ss'),'" + _oMobileRetentionOrder.GetStaff_no() + "','" + _oMobileRetentionOrder.GetStaff_no().Trim() + "','CC RET','"+_oMobileRetentionOrder.GetDelivery_exchange_location()+"' ) ");
                                bool _bFlag = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery.ToString());
                                WebFunc.SaveQuery(this.Page, _oQuery.ToString());
                            }
                            _oCheckAODr.Close();
                            _oCheckAODr.Dispose();
                        }
                    }
                    #endregion

                    #region If sim_item_number!=null, save edf_no to [sunday_sim_no]
                    if (
                        "MOBILE_LITE".Equals(_oMobileRetentionOrder.GetIssue_type().Trim()) ||
                        "OLD_MOBILE_LITE".Equals(_oMobileRetentionOrder.GetIssue_type().Trim())
                        )
                    {

                        if (_sRefNo == string.Empty) { _sRefNo = _oOrderSerialNumberControl.ReferenceNumber; }

                        _oSIMControl.SetDummy1("SIM CARD CC RET");
                        _oSIMControl.SetReferenceno(_sRefNo);
                        _oSIMControl.SetReserve(_oMobileRetentionOrder.GetSim_item_code());
                        //_sSim_no = _oMobileRetentionOrder.GetSim_item_number();
                        _oSIMControl.SetSim_no(_sSim_no);
                        if (_oSIMControl.isSIMAvaliable())
                        {
                            _oSIMControl.UpdateEDFNoToSIM();
                        }
                        else
                        {
                            // find another one 
                        }

                    }
                    #endregion

                }
                else
                {
                    if (_iGo_wireless.Equals(1))
                    {
                        _sRemarkError = "check NO actived order in EDF";
                        //=== check NO actived order in EDF ===
                        if (_sRefNo == string.Empty)
                        {
                            _sRefNo = GetN0ActivedInEDF(Func.IDAdd100000(Convert.ToInt32(_oMobileRetentionOrder.GetOrder_id())));
                        }
                    }
                }
                #endregion



                _sRemarkError = "NOT ALLOW INSERT";
                if (!n_sAllowInsertEDF)
                    _oEDFStatusProfile.ToEDFError(WebFunc.qsOrder_id, RWLFramework.CurrentUser[this.Page].Uid, _sRemarkError.ToUpper().ToString(), "");
                _sRemarkError = "NO EDF NO.";

                if (
                    (_oCheckToEDF.allowToEDF() && _oMobileRetentionOrder.GetSim_item_code() != string.Empty)
                    ||
                    _oMobileRetentionOrder.GetIssue_type().Equals("UPGRADE")
                    )
                {
                    if (_sRefNo == string.Empty)
                    {
                        _sRefNo = _oMobileRetentionOrder.GetEdf_no();
                        if (_sRefNo == string.Empty) { _sRefNo = _oOrderSerialNumberControl.ReferenceNumber; }
                    }
                }

                _sRefNo = _sRefNo.Trim();
                _sImei_no = _sImei_no.Trim();


                if (string.IsNullOrEmpty(_sRefNo))
                {
                    if (string.IsNullOrEmpty(_sImei_no) &&
                        !string.IsNullOrEmpty(_oMobileRetentionOrder.GetHs_model()))
                    {
                        _sImei_no = "AO";
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(_sImei_no) &&
                        !string.IsNullOrEmpty(_oMobileRetentionOrder.GetHs_model()))
                    {
                        _sImei_no = "AWAIT";
                    }
                }

                if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetHs_model()))
                    _sImei_no = string.Empty;

                _oMobileRetentionOrder.SetEdf_no(_sRefNo);
                _oMobileRetentionOrder.SetImei_no(_sImei_no);

                bool _bUpdateOrder = false;
                using (ISession<MSSQLConnect> _oSession = (new SessionFactory<MSSQLConnect>()).OpenSession())
                using (ITransaction _oTransaction = _oSession.BeginTransaction())
                {
                    if (_oMobileRetentionOrder.GetMrt_no() != null)
                        n_sMobileNumber = ((int)_oMobileRetentionOrder.GetMrt_no()).ToString();
                    _bUpdateOrder = _oSession.Update(_oMobileRetentionOrder);
                    if (_bUpdateOrder)
                        _oTransaction.Commit();
                    else
                        _oTransaction.Rollback();
                }

                if (!_bUpdateOrder)
                {
                    throw new BusinessObjectNotFoundException("UPDATE RECORD ID:" + _iOrder_id.ToString() + " ERROR!");
                }

                //=== have STOCK ===
                #region have STOCK
                if (!"".Equals(_sRefNo) && n_sAllowInsertEDF)
                {
                    _sRemarkError = "Select agree_no is in sunday_form";
                    string _sModel = string.Empty;
                    _sModel = _oMobileRetentionOrder.GetSim_item_name();
                    _bInsert = _oEDFStatusProfile.InsertEDF(_oMobileRetentionOrder, 3);
                    if (_oMobileRetentionOrder.GetMrt_no() != null)
                        n_sMobileNumber = ((int)_oMobileRetentionOrder.GetMrt_no()).ToString();
                }

                #endregion have STOCK
                _sRemarkError = "update EDF# & IMEI# In Web Log";
                //=== update EDF# & IMEI# ===

                StringBuilder _oAlertMsg = new StringBuilder();
                _oAlertMsg.Append("DONE!");
                if (_sRefNo != "") _oAlertMsg.Append("  EDF No:" + _sRefNo);
                if (_sImei_no != "") _oAlertMsg.Append("  IMEI No:" + _sImei_no);
                if (_sImei_no.Trim().ToUpper() == "AO")
                    RunJavascriptFunc("alert('" + _oAlertMsg.ToString() + "');");
                else
                    RunJavascriptFunc("alert('" + _oAlertMsg.ToString() + "');");
            }
            else
            {
                RunJavascriptFunc("alert('No Handset. Order has not transferred to EDF ');");
            }
            #endregion
            if ("re-act".Equals(WebFunc.qsAction))
            {
                RunJavascriptFunc("alert(\"Order Re-actived!\\nPlease re-confirm SRD / get Free Gift IMEI, if need.\");");
            }
            RWLviewrow1.SetOrderid(_iOrder_id);
            RWLviewrow1.LoadOrder();
            Session["IssueOrderWeblogProcess"] = string.Empty;
        }
    }

    #region CheckDuplicateEDFMrt
    protected bool CheckDuplicateEDFMrt(string x_sMrt)
    {
        if (string.IsNullOrEmpty(x_sMrt)) { return false; }
        x_sMrt = x_sMrt.Trim();
        DateTime _oSearchTime = DateTime.Now.AddDays(-7);
        string _sQuery = "SELECT mobile_no FROM Sunday_form WHERE created_by='CC RET' AND cancelled='N' ";
        _sQuery += " AND create_date>=to_date('" + _oSearchTime.ToString("dd/MM/yyyy") + "','dd/MM/yyyy') AND mobile_no='" + x_sMrt.Trim() + "' AND rownum<=1";
        OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(_sQuery);
        if (_oDr.Read())
        {
            _oDr.Close();
            _oDr.Dispose();
            return true;
        }
        _oDr.Close();
        _oDr.Dispose();
        return false;
    }
    #endregion


    #region GetDB
    protected MSSQLConnect GetDB()
    {
        MSSQLConnect _oDB = new MSSQLConnect();
        _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
        _oDB.bWithNoLock = true;
        return _oDB;
    }
    #endregion

    #region Get Edf
    private string GetN0ActivedInEDF(string x_sRecordID)
    {
        int _iRecordID;
       
        
        string _sRefNo = string.Empty;
        if (int.TryParse(x_sRecordID, out _iRecordID))
        {
            _oOrderSerialNumberControl.SetOrder_id(_iRecordID-100000);
            global::System.Data.Odbc.OdbcDataReader _oDr3 = SYSConn<ODBCConnect>.Connect().GetSearch("select referenceNo from sunday_Form Where CREATED_BY='CC RET' and Agree_no='" + x_sRecordID + " ' and cancelled='N'");
            if (!_oDr3.Read())
            {
                //=== get EDF# ===

                _sRefNo = _oOrderSerialNumberControl.ReferenceNumber;
            }
            _oDr3.Close();
            _oDr3.Dispose();
        }
        return _sRefNo;
    }


    #endregion

    #region Get Oracle DB
    protected ODBCConnect GetORDB()
    {
        ODBCConnect _oDB = new ODBCConnect();
        _oDB.SetConnStr(Configurator.DBName.ORADNS + ((Configurator.IsUat()) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion

    #region Set HtmlControl Style By Javascript
    public void SetHtmlControlStyle(string x_sID, HtmlTextWriterStyle x_oStyle, string x_sValue, bool x_bStr)
    {
        Random ran = new Random();
        string _sScript = string.Empty;
        if (x_bStr)
            _sScript = string.Format("<script>document.getElementById('{0}').style.{1}='{2}';</script>", x_sID, x_oStyle.ToString().ToLower(), x_sValue);
        else
            _sScript = string.Format("<script>document.getElementById('{0}').style.{1}={2};</script>", x_sID, x_oStyle.ToString().ToLower(), x_sValue);
        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), _sScript, false);
    }
    #endregion

    #region Set HtmlContorl Attributes By Javascript
    public void SetHtmlControlAtt(string x_sID, HtmlTextWriterAttribute x_oAtt, string x_sValue, bool x_bStr)
    {
        string _sScript = string.Empty;
        if (x_bStr)
            _sScript = string.Format("<script>document.getElementById('{0}').{1}='{2}';</script>", x_sID, x_oAtt.ToString().ToLower(), x_sValue);
        else
            _sScript = string.Format("<script>document.getElementById('{0}').{1}={2};</script>", x_sID, x_oAtt.ToString().ToLower(), x_sValue);
        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), _sScript, false);
    }
    #endregion

    #region Set HtmlContorl Value By Javascript
    public void SetHtmlControlValue(string x_sID, string x_sValue, bool x_bStr)
    {
        string _sScript = string.Empty;
        if (x_bStr)
            _sScript = string.Format("<script>document.getElementById('{0}').value='{1}';</script>", x_sID, x_sValue);
        else
            _sScript = string.Format("<script>document.getElementById('{0}').value={1};</script>", x_sID, x_sValue);
        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), _sScript, false);
    }
    #endregion

    #region Run Javascript Function
    public void RunJavascriptFunc(string x_sFunc)
    {
        string _sFunc = ((x_sFunc.IndexOf(';') > 0) ? x_sFunc : x_sFunc + ";");
        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sFunc + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), string.Format("<script>{0}</script>", _sFunc), false);
    }
    #endregion


    public bool IMEIRelease(string x_sIMEI)
    {
        if (string.IsNullOrEmpty(x_sIMEI)) return false;
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("UPDATE imei_stock SET referenceno='', status='NORMAL', staff_recd='', DUMMY4='', dummy1='' ");
        _oQuery.Append("WHERE imei='" + x_sIMEI + "' AND status='SOLD' AND dummy2='CC RET' AND rownum<=1");

        bool _bReleaseIMEI = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery.ToString());
        return _bReleaseIMEI;
    }
}
