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


public partial class Web_IMEIManagement_CheckWebLogAWAITRecord : NEURON.WEB.UI.BasePage
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

    #region InitFrame
    public void InitFrame()
    {
        NeuronJSLibrary.Text = JSScriptLibrary.JSScriptCommon;
        RWLFramework.DataBaseConfigSetting();
    }
    #endregion

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

    protected void SearchWebLog_Click(object sender, EventArgs e)
    {
        SearchRecordID(find_record_id.Text.ToString());
    }

    protected void SearchRecordID(string RecordID)
    {
        int _iRecordID;
        int _iOrder_id = -1;
        if (string.IsNullOrEmpty(find_record_id.Text.ToString()))
        {
            RunJavascriptFunc("alert('Please enter the record id number!');", true);
            return;
        }
        if (int.TryParse(RecordID, out _iRecordID))
        {
            _iOrder_id = _iRecordID - 100000;
            MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect(), _iOrder_id);
            if (_oMobileRetentionOrder.Retrieve())
            {
                if (_oMobileRetentionOrder.GetImei_no().Trim().ToUpper().Equals(IMEISTATUS.AWAIT))
                {
                    rwl_record_id.Text = _iRecordID.ToString();
                    rwl_order_id.Text = _iOrder_id.ToString();
                    rwl_imei_no.Text = _oMobileRetentionOrder.GetImei_no().ToString();
                    rwl_edf_no.Text = _oMobileRetentionOrder.GetEdf_no().ToString();
                    rwl_hs_model.Text = _oMobileRetentionOrder.GetHs_model().ToString();
                    rwl_sku.Text = _oMobileRetentionOrder.GetSku().ToString();
                    if (rwl_edf_no.Text.ToString() != string.Empty)
                        BindData(rwl_edf_no.Text.ToString(), rwl_sku.Text.ToString());
                    else
                        BindData(rwl_record_id.Text.ToString(), rwl_sku.Text.ToString());

                    FindEdfRecord(_oMobileRetentionOrder.GetEdf_no());
                    
                }
                else
                {
                    RunJavascriptFunc("alert('This is not a AWAIT record!')", true);
                }
            }
            else
            {
                RunJavascriptFunc("alert('Cannot find this record!')", true);
            }

        }
        else
        {
            RunJavascriptFunc("alert('Please kindly input the correct record id!');", true);
        }
    }

    protected void FindEdfRecord(string EDFNO)
    {
        if (string.IsNullOrEmpty(EDFNO))
        {
            RunJavascriptFunc("ALERT('Cannot find EDF record in EDF system!')", true);
        }
        else
        {
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("SELECT REFERENCENO,IMEI,AGREE_NO,ITEMCODE,ITEMDESC,E_DELIVERY_DATE,ACTUAL_DEL_DATE,REMARK,DN_REMARK FROM SUNDAY_FORM WHERE REFERENCENO='" + EDFNO + "'");
            OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(_oQuery.ToString());
            if (_oDr.Read())
            {
                edf_edf_no.Text = Func.FR(_oDr["REFERENCENO"]);
                edf_imei_no.Text = Func.FR(_oDr["IMEI"]);
                edf_record_id.Text = Func.FR(_oDr["AGREE_NO"]);
                edf_sku.Text = Func.FR(_oDr["ITEMCODE"]);
                edf_hs_model.Text = Func.FR(_oDr["ITEMDESC"]);
                edf_actural_delivery.Text = Func.FR(_oDr["ACTUAL_DEL_DATE"]);
                edf_expect_delivery.Text = Func.FR(_oDr["E_DELIVERY_DATE"]);
                edf_remark.Text = Func.FR(_oDr["REMARK"]);
                edf_dn_remark.Text = Func.FR(_oDr["DN_REMARK"]);
                but_InsertEDFRecord.Enabled = false;
            }
            else
            {
                but_InsertEDFRecord.Enabled = true;
                RunJavascriptFunc("ALERT('Cannot find EDF record in EDF system!')", true);
            }
            _oDr.Close();
            _oDr.Dispose();
        }
    }

    protected void BindData(string EDFNO, string SKU)
    {
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("SELECT REFERENCENO,IMEI,CREATE_BY,MODEL,KIT_CODE,DUMMY4,STATUS FROM IMEI_STOCK WHERE REFERENCENO='" + EDFNO.ToString() + "' AND KIT_CODE='" + SKU + "' AND (STATUS='AWAIT' OR STATUS='STOCK') ");
        DataSet _oDS = SYSConn<ODBCConnect>.Connect().GetDS(_oQuery.ToString());
        if (_oDS == null)
            but_InsertAwaitCase.Enabled = false;
        else if (_oDS.Tables.Count <= 0)
            but_InsertAwaitCase.Enabled = false;
        else
            but_InsertAwaitCase.Enabled = true;

        IMEISTOCKGW.DataSource = _oDS;
        IMEISTOCKGW.DataBind();
    }

    protected void but_InsertEDFRecord_Click(object sender, EventArgs e)
    {
        int _iOrder_id;
        if (int.TryParse(rwl_order_id.Text, out _iOrder_id))
        {
            InsertAndCheckEDFRecord(_iOrder_id);
        }
    }

    protected void InsertAndCheckEDFRecord(int x_iOrder_id)
    {
        if (InsertEDF(x_iOrder_id))
        {
            RunJavascriptFunc("alert('Insert Edf Record Success!')", true);
            SearchRecordID(Func.IDAdd100000(x_iOrder_id).ToString());
        }
    }



    protected bool InsertEDF(int x_iOrder_id)
    {
        bool bFlag = false;
        string _sRemarksEDF = string.Empty;
        string _sToday = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        string _sToday1 = DateTime.Now.ToString("yyyyMMdd");
        string _sTime1 = DateTime.Now.ToString("HH:mm:ss");
        MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect());
        _oMobileRetentionOrder.SetOrder_id(x_iOrder_id);
        if (_oMobileRetentionOrder.Retrieve())
        {
            if (_oMobileRetentionOrder.GetEdf_no().Trim().Equals(string.Empty))
            {

                Response.Write(x_iOrder_id.ToString() + " No EDF<br>");
            }
            #region have STOCK
            if (!"".Equals(_oMobileRetentionOrder.GetEdf_no()) && _oMobileRetentionOrder.GetActive() == true)
            {
                if (_oMobileRetentionOrder.GetLog_date() != null)
                    _sToday = ((DateTime)_oMobileRetentionOrder.GetLog_date()).ToString("dd/MM/yyyy HH:mm:ss");

                if (AllowInsertEDFIMEI(_oMobileRetentionOrder.GetEdf_no(), _oMobileRetentionOrder.GetImei_no()))
                {
                    OdbcDataReader _oDr3 = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT referenceNo FROM sunday_Form WHERE referenceNo='" + _oMobileRetentionOrder.GetEdf_no() + "' AND CREATED_BY='CC RET' and Agree_no='" + Func.IDAdd100000(x_iOrder_id).ToString() + "' and cancelled='N' ");
                    if (!_oDr3.Read())
                    {
                        int _iAmount = 0;
                        int _iTempAmount;
                        if (int.TryParse(_oMobileRetentionOrder.GetAmount(), out _iTempAmount))
                        {
                            _iAmount = _iTempAmount;
                        }

                        int _iAccessory_price = 0;
                        int _iTempAccessory_price;
                        if (int.TryParse(_oMobileRetentionOrder.GetAccessory_price(), out _iTempAccessory_price))
                        {
                            _iAccessory_price = _iTempAccessory_price;
                        }

                        StringBuilder _oQuery = new StringBuilder();
                        #region Insert into sunday From
                        _oQuery.Append("INSERT INTO sunday_Form (IMEI_2, SS_TO_PLG_DATE, referenceNo,Agree_no,create_date, staffNo, staffName,  SalesManCode, Extn, Sales_channel, Applicat_Date, Customer_name, Customer_ID_Type, Customer_ID, Mobile_no, Contact_no, User_Name, Order_Amt, Delivery_charge, E_delivery_date, E_Delivery_period, Dummy2, Dummy3, Remark,ItemCode, program,Rate_plan,contract_period,Plan_code,FG_Code,FG_IMEI0,FreeGift1,FG_Desc1,FG_IMEI1,FreeGift2,FG_Desc2,FG_IMEI2,FreeGift3,FG_Desc3,FG_IMEI3,FreeGift4,FG_Desc4,FG_IMEI4,CASH_AMT, ItemDesc, IMEI, TRADE, REBATE, HS_PAYMENT_TYPE, HS_CARD_NO, HS_C_HOLDER_NAME, HS_EXPIRYDATE, HS_PAY_AMT,COMPANY_NAME,VAS, doc_receive, cancelled,fo_to_sales, payment_status,create_s,to_plg,issue,pending,created_by,PEND_DOC,Premium_Gift,Contact_No_R,ament_counter,sim_card_type,sim_item_code,sim_card_no");
                        _oQuery.Append(" ) VALUES ('" + _oMobileRetentionOrder.GetSim_mrt_no() + "',to_date('" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "' , 'dd/mm/yyyy hh24:mi:ss'),   '" + _oMobileRetentionOrder.GetEdf_no() + "' ,");
                        _oQuery.Append("'" + Func.IDAdd100000(x_iOrder_id).Trim() + "',");
                        _oQuery.Append("to_date('" + _sToday.Trim() + "' , 'dd/mm/yyyy hh24:mi:ss') ,");

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
                        _oQuery.Append(_oMobileRetentionOrder.GetD_address().Trim().Replace("'", "`").ToUpper() + "','");

                        if (!_oMobileRetentionOrder.GetVip_case().Equals(string.Empty))
                            _oQuery.Append(_oMobileRetentionOrder.GetVip_case().Trim().Replace("'", "`") + "','");
                        else
                            _oQuery.Append("','");

                        if (!_oMobileRetentionOrder.GetOrd_place_by().Equals(string.Empty) && !_oMobileRetentionOrder.GetOrd_place_rel().Trim().Equals("sub"))
                        {
                            if (!_oMobileRetentionOrder.GetRemarks2EDF().Equals(string.Empty))
                            {
                                string _sRemark = _oMobileRetentionOrder.GetRemarks2EDF().Trim().Replace("'", "`") + " Order Placed By " + _oMobileRetentionOrder.GetOrd_place_rel().Trim().Replace("'", "`") + ", " + _oMobileRetentionOrder.GetOrd_place_by().Trim().Replace("'", "`") + ", " + _oMobileRetentionOrder.GetOrd_place_hkid().Trim().Replace("'", "`") + "','";
                                _oQuery.Append(_sRemark.Trim().ToUpper());
                            }
                            else
                            {
                                string _sRemark = " Order Placed By " + _oMobileRetentionOrder.GetOrd_place_rel().Trim().Replace("'", "`") + ", " + _oMobileRetentionOrder.GetOrd_place_by().Trim().Replace("'", "`") + ", " + _oMobileRetentionOrder.GetOrd_place_hkid().Trim().Replace("'", "`") + "','";
                                _oQuery.Append(_sRemark.Trim().ToUpper());
                            }
                        }
                        else
                        {
                            if (!_oMobileRetentionOrder.GetRemarks2EDF().Trim().ToUpper().Equals(string.Empty))
                                _oQuery.Append(_oMobileRetentionOrder.GetRemarks2EDF().Trim().Replace("'", "`").Trim().ToUpper() + "','");
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
                        if (!_oMobileRetentionOrder.GetImei_no().Equals("AWAIT") &&
                            !_oMobileRetentionOrder.GetImei_no().Equals("AO"))
                        {
                            _oQuery.Append(_oMobileRetentionOrder.GetImei_no().Trim() + "','");
                        }
                        else
                        {
                            _oQuery.Append("','");
                        }
                        /*
                        if (!_oMobileRetentionOrder.GetImei_no().Equals("AWAIT"))
                            _oQuery.Append(_oMobileRetentionOrder.GetImei_no() + "','");
                        else
                            _oQuery.Append("','");
                        */
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

                        bFlag = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery.ToString());
                        if (_oMobileRetentionOrder.GetEdf_no() != "")
                        {
                            bFlag = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("UPDATE sunday_form SET created_by='CC RET' where referenceno='" + _oMobileRetentionOrder.GetEdf_no() + "'");
                        }
                        #endregion
                        bool _bUpdate = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("UPDATE IMEI_Stock SET ReferenceNo='" + _oMobileRetentionOrder.GetEdf_no() + "' WHERE Dummy2='CC RET' AND DUMMY4='" + Func.IDAdd100000(_oMobileRetentionOrder.GetOrder_id()) + "' AND Dummy3='" + _oMobileRetentionOrder.GetDelivery_exchange_location() + "' ");
                    }
                    _oDr3.Close();
                    _oDr3.Dispose();
                }
            }
            #endregion
        }
        return bFlag;
    }

    public bool AllowInsertEDFIMEI(string x_sEDF, string x_sIMEI)
    {

        if (string.IsNullOrEmpty(x_sEDF) && string.IsNullOrEmpty(x_sIMEI)) return false;
        if (string.IsNullOrEmpty(x_sEDF)) return false;
        if (string.IsNullOrEmpty(x_sIMEI)) return false;
        x_sEDF = x_sEDF.Trim();
        x_sIMEI = x_sIMEI.Trim();

        OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT referenceNo,  imei FROM sunday_Form  WHERE  referenceNo='" + x_sEDF + "' AND imei='" + x_sIMEI + "' AND cancelled='N' AND rownum<=1");
        if (!_oDr.Read())
        {
            _oDr.Close();
            _oDr.Dispose();
            return true;
        }
        _oDr.Close();
        _oDr.Dispose();
        return true;
    }


    public bool AllowAssignNormalIMEI(string x_sCurrentEDF, string x_sAssignIMEI, string x_sRecord_id)
    {
        bool _bFlag = true;

        if (string.IsNullOrEmpty(x_sCurrentEDF) && string.IsNullOrEmpty(x_sAssignIMEI)) return false;
        if (string.IsNullOrEmpty(x_sCurrentEDF)) return false;
        if (string.IsNullOrEmpty(x_sAssignIMEI)) return false;
        if (x_sAssignIMEI.Trim().ToUpper().Equals("AO") || x_sAssignIMEI.Trim().ToUpper().Equals("AWAIT")) return false;

        OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT referenceNo ,agree_no FROM sunday_Form  WHERE imei='" + x_sAssignIMEI + "'  AND referenceNo is not null AND referenceNo<>' ' AND cancelled='N' AND rownum<=1");
        if (_oDr.Read())
        {
            _bFlag = false;
        }
        _oDr.Close();
        _oDr.Dispose();
        return _bFlag;
    }


    protected int GetIMEIAWAITRecordCount()
    {
        string EDFNO = rwl_edf_no.Text.ToString();
        string SKU = rwl_sku.Text.ToString();
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("SELECT count(1) count FROM IMEI_STOCK WHERE REFERENCENO='" + EDFNO.ToString() + "' AND KIT_CODE='" + SKU + "' AND STATUS='AWAIT' ");
        string _sCount = SYSConn<ODBCConnect>.Connect().GetExecuteScalar(_oQuery.ToString());
        int _iCount = 0;
        if (int.TryParse(_sCount, out _iCount))
        {
            return _iCount;
        }
        return _iCount;
    }

    protected void IMEISTOCKGW_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        if (e.RowIndex > -1)
        {
            string RecordID = rwl_record_id.Text.ToString().Trim();
            string EdfNo = rwl_edf_no.Text.ToString().Trim();
            string Sku = rwl_sku.Text.ToString().Trim();
            if (EdfNo.Equals(string.Empty)) { EdfNo = RecordID; }
            GridView _oGridView = (GridView)sender;
            GridViewRow _oGridViewRow = (GridViewRow)_oGridView.Rows[e.RowIndex];
            TextBox _oCreate_by = (TextBox)_oGridViewRow.FindControl("create_by");
            TextBox _oDUMMY4 = (TextBox)_oGridViewRow.FindControl("DUMMY4");
            StringBuilder _oQuery = new StringBuilder();
            if (_oCreate_by == null || _oDUMMY4 == null) { e.Cancel = true; return; }
            if (!_oCreate_by.Text.ToString().Trim().Equals(string.Empty) &&
                !_oDUMMY4.Text.ToString().Trim().Equals(string.Empty))
            {
                _oQuery.Append("UPDATE  IMEI_STOCK SET CREATE_BY='" + _oCreate_by.Text.ToString() + "' , DUMMY4='" + _oDUMMY4.Text.ToString() + "'  WHERE REFERENCENO='" + EdfNo.ToString() + "' AND KIT_CODE='" + Sku.ToString() + "' AND STATUS='AWAIT' AND DUMMY2='CC RET' AND ROWNUM<=1");
                if (SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery.ToString()))
                    RunJavascriptFunc("alert('Update Success!')", true);
                else
                    RunJavascriptFunc("alert('Update Fail!')", true);
            }
            else
            {
                if (_oCreate_by.Text.ToString().Trim().Equals(string.Empty))
                {
                    RunJavascriptFunc("alert('Create by text box cannot empty!')", true);
                }
                if (_oDUMMY4.Text.ToString().Trim().Equals(string.Empty))
                {
                    RunJavascriptFunc("alert('Record id text box cannot empty!')", true);
                }
            }
        }
        IMEISTOCKGW.EditIndex = -1;
        if (rwl_edf_no.Text.ToString() != string.Empty)
            BindData(rwl_edf_no.Text.ToString(), rwl_sku.Text.ToString());
        else
            BindData(rwl_record_id.Text.ToString(), rwl_sku.Text.ToString());
    }
    protected void IMEISTOCKGW_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        if (GetIMEIAWAITRecordCount() <= 0)
        {
            RunJavascriptFunc("alert('Cannot delete this record!')", true);
            return;
        }

        if (e.RowIndex > -1)
        {
            GridView _oGridView = (GridView)sender;
            GridViewRow _oGridViewRow = (GridViewRow)_oGridView.Rows[e.RowIndex];
            Label _oCreate_by = (Label)_oGridViewRow.FindControl("create_by");
            Label _oDUMMY4 = (Label)_oGridViewRow.FindControl("DUMMY4");
            Label _oReferenceno = (Label)_oGridViewRow.FindControl("referenceno");
            Label _oModel = (Label)_oGridViewRow.FindControl("model");
            Label _oKit_code = (Label)_oGridViewRow.FindControl("kit_code");
            Label _oImei = (Label)_oGridViewRow.FindControl("imei");
            Label _oStatus = (Label)_oGridViewRow.FindControl("status");
            string CreateBy = _oCreate_by.Text.ToString().Trim();
            string RecordID = _oDUMMY4.Text.ToString().Trim();
            string EdfNo = _oReferenceno.Text.ToString().Trim();
            string Model = _oModel.Text.ToString().Trim();
            string Sku = _oKit_code.Text.ToString().Trim();
            string Status = _oStatus.Text.ToString().Trim();
            string IMEI = _oImei.Text.ToString().Trim();

            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("UPDATE IMEI_STOCK SET DUMMY4='',REFERENCENO='',KIT_CODE='',STATUS='',IMEI='',DUMMY2='',DUMMY3='' WHERE ");
            if (RecordID != string.Empty)
                _oQuery.Append("DUMMY4='" + RecordID.ToString() + "' AND ");
            else
                _oQuery.Append("DUMMY4=' ' AND ");

            if (EdfNo != string.Empty)
                _oQuery.Append("REFERENCENO='" + EdfNo.ToString() + "' AND ");
            else
                _oQuery.Append("REFERENCENO=' ' AND ");

            if (Sku.ToString() != string.Empty)
                _oQuery.Append("KIT_CODE='" + Sku.ToString() + "' AND ");
            else
                _oQuery.Append("(KIT_CODE=' ' or KIT_CODE is null) AND ");


            if (Status.ToString() != string.Empty)
                _oQuery.Append("STATUS='" + Status.ToString() + "' AND ");
            else
                _oQuery.Append("(STATUS=' ' or STATUS is null) AND ");

            if (IMEI.ToString() != string.Empty)
                _oQuery.Append("IMEI='" + IMEI.ToString() + "' AND ");
            else
                _oQuery.Append("(IMEI=' ' or IMEI is null) AND ");

            _oQuery.Append("DUMMY2='CC RET' ");
            _oQuery.Append(" AND ");
            _oQuery.Append("ROWNUM<=1");
            if (SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery.ToString()))
            {
                RunJavascriptFunc("alert('Delete Success!')", true);
            }
            if (rwl_edf_no.Text.ToString() != string.Empty)
                BindData(rwl_edf_no.Text.ToString(), rwl_sku.Text.ToString());
            else
                BindData(rwl_record_id.Text.ToString(), rwl_sku.Text.ToString());
        }
    }
    protected void IMEISTOCKGW_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        IMEISTOCKGW.EditIndex = -1;
        if (rwl_edf_no.Text.ToString() != string.Empty)
            BindData(rwl_edf_no.Text.ToString(), rwl_sku.Text.ToString());
        else
            BindData(rwl_record_id.Text.ToString(), rwl_sku.Text.ToString());
    }
    protected void IMEISTOCKGW_RowEditing(object sender, GridViewEditEventArgs e)
    {
        IMEISTOCKGW.EditIndex = e.NewEditIndex;
        if (rwl_edf_no.Text.ToString() != string.Empty)
            BindData(rwl_edf_no.Text.ToString(), rwl_sku.Text.ToString());
        else
            BindData(rwl_record_id.Text.ToString(), rwl_sku.Text.ToString());
    }

    protected void but_InsertAwaitCase_Click(object sender, EventArgs e)
    {
        int _iOrder_id;
        if (int.TryParse(rwl_order_id.Text.ToString(), out _iOrder_id))
        {
            if (_oEDFStatusProfile.InsertAwaitCase(_iOrder_id))
            {
                RunJavascriptFunc("alert('Insert Success!')", true);
            }
            if (rwl_edf_no.Text.ToString() != string.Empty)
                BindData(rwl_edf_no.Text.ToString(), rwl_sku.Text.ToString());
            else
                BindData(rwl_record_id.Text.ToString(), rwl_sku.Text.ToString());
        }
    }
}
