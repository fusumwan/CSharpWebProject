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

public partial class Web_IMEIManagement_ConciergeServiceIMEIChange : NEURON.WEB.UI.BasePage
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

    public void InitFrame()
    {
        NeuronJSLibrary.Text = JSScriptLibrary.JSScriptCommon;
        RWLFramework.DataBaseConfigSetting();
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
    protected void updateimei_Click(object sender, EventArgs e)
    {
        int _iRecordid;
        int _iRecordid2;
        if (find_record_id.Text.ToString().Equals(string.Empty) || 
            find_record_id2.Text.ToString().Equals(string.Empty))
        {
            RunJavascriptFunc("alert('Please enter record id!')", true);
        }

        if (int.TryParse(find_record_id.Text.ToString(), out _iRecordid) &&
            int.TryParse(find_record_id2.Text.ToString(), out _iRecordid2))
        {
            MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect(), _iRecordid-100000);
            MobileRetentionOrder _oMobileRetentionOrder2 = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect(), _iRecordid2-100000);
            
            if (!_oMobileRetentionOrder.Retrieve()){
                RunJavascriptFunc("alert('Cannot find any record int web log by this record id:"+_iRecordid.ToString()+"!')",true);
                return;
            }

            if (!_oMobileRetentionOrder2.Retrieve()){
                RunJavascriptFunc("alert('Cannot find any record in web log by this record id:" + _iRecordid2.ToString() + "!')",true);
                return;
            }

            if (!IsFindEdfRecord(_oMobileRetentionOrder.GetEdf_no()))
            {
                RunJavascriptFunc("alert('Cannot find any record in EDF system by this edf number:" + _oMobileRetentionOrder.GetEdf_no() + "!')",true);
                return;
            }

            if (!IsFindIMEIAORecord(_iRecordid2.ToString(), _oMobileRetentionOrder2.GetSku()))
            {
                RunJavascriptFunc("alert('Cannot find any ao record in IMEI record!')",true);
                return;
            }

            if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetEdf_no()))
            {
                RunJavascriptFunc("alert('The record id :"+_iRecordid.ToString()+"  don't has edf number!');",true);
                return;
            }

            if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetImei_no()))
            {
                RunJavascriptFunc("alert('The record id :" + _iRecordid.ToString() + "  don't has imei number!');", true);
            }

            if (_oMobileRetentionOrder2.GetImei_no()!="AO")
            {
                RunJavascriptFunc("alert('The record id :" + _iRecordid.ToString() + "  don't has imei number!');", true);
            }

            string _sImei_no = _oMobileRetentionOrder.GetImei_no();
            string _sSku = _oMobileRetentionOrder.GetSku();
            _oMobileRetentionOrder.SetImei_no("AWAIT");
            _oMobileRetentionOrder.Save();
            _oEDFStatusProfile.IMEIRelease(_sImei_no, _sSku, IMEISTATUS.SOLD);
            CreateAOAWAITRecord((int)_oMobileRetentionOrder.GetOrder_id(), IMEISTATUS.AWAIT);
            MobileRetentionOrderBal.BackUpOrder((int)_oMobileRetentionOrder.GetOrder_id(),RWLFramework.CurrentUser[this.Page].Uid);
            _oEDFStatusProfile.AddEDFAmentLog((int)_oMobileRetentionOrder.GetOrder_id(), RWLFramework.CurrentUser[this.Page].Uid);
            UpdateEDF((int)_oMobileRetentionOrder.GetOrder_id());
            EDFRWLCombineSynchronizationl _oAutoAOAssignImei = new EDFRWLCombineSynchronizationl();
            _oAutoAOAssignImei.SetUid(RWLFramework.CurrentUser[this.Page].Uid);
            UpdateImei(_iRecordid2, _sImei_no, _sSku, RWLFramework.CurrentUser[this.Page].Uid);
        }        
    }

    public void UpdateImei(int x_iRecord_ID, string x_sIMEI, string x_sSKU,string x_sUid)
    {

        if (string.IsNullOrEmpty(x_sIMEI)) return;
        if (string.IsNullOrEmpty(x_sSKU)) return;
        string _sQuery = "SELECT * FROM IMEI_STOCK WHERE DUMMY4='" + x_iRecord_ID + "' AND kit_code='" + x_sSKU + "' AND (STATUS='AO' or STATUS='AWAIT') ";
        OdbcDataReader _oChkDr = SYSConn<ODBCConnect>.Connect().GetSearch(_sQuery);
        if (!_oChkDr.Read())
        {
            Response.Write("<script>alert('Update Fail!');</script>");
            _oChkDr.Close();
            _oChkDr.Dispose();
            return;
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

        if (!string.IsNullOrEmpty(x_sUid) &&
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
            _oUpdateIMEIQuery.Append(" UPDATE IMEI_Stock SET STAFF_RECD='" + x_sUid + "' ");
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
                        _oSelectStockQuery.Append(" AND Status='STOCK' AND IMEI<>' ' and STAFF_RECD='" + x_sUid + "'");

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
                                _oUpdateIMEIStockQuery.Append(" AND STAFF_RECD='" + x_sUid + "' AND Status='STOCK'");
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
                            MobileRetentionOrderBal.BackUpOrder(Convert.ToInt32(Func.FR(_oDr[MobileRetentionOrder.Para.order_id]).Trim()), x_sUid);
                            #region === update EDF# & IMEI# ===
                            global::System.Text.StringBuilder _oUpdateEDFIMEISql = new global::System.Text.StringBuilder();
                            _oUpdateEDFIMEISql.Append(" UPDATE " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder ");
                            _oUpdateEDFIMEISql.Append(" SET imei_no='" + n_sImei_no + "',edf_no='" + n_sRefNo + "',");
                            _oUpdateEDFIMEISql.Append(" cid='" + x_sUid + "',cdate=getdate() ");
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
                                _oQuery.Append("INSERT INTO sunday_Form (IMEI_2, SS_TO_PLG_DATE, referenceNo,Agree_no,create_date, staffNo, staffName,  SalesManCode, Extn, Sales_channel, Applicat_Date, Customer_name, Customer_ID_Type, Customer_ID, Mobile_no, Contact_no, User_Name, Order_Amt, Delivery_charge, E_delivery_date, E_Delivery_period, Dummy2, Dummy3, Remark,ItemCode, program,Rate_plan,contract_period,Plan_code,FG_Code,FG_IMEI0,FreeGift1,FG_Desc1,FG_IMEI1,FreeGift2,FG_Desc2,FG_IMEI2,FreeGift3,FG_Desc3,FG_IMEI3,FreeGift4,FG_Desc4,FG_IMEI4,CASH_AMT, ItemDesc, IMEI, TRADE, REBATE, HS_PAYMENT_TYPE, HS_CARD_NO, HS_C_HOLDER_NAME, HS_EXPIRYDATE, HS_PAY_AMT,COMPANY_NAME,VAS, doc_receive, cancelled,fo_to_sales, payment_status,create_s,to_plg,issue,pending,created_by,PEND_DOC,Premium_Gift,Contact_No_R,ament_counter");
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
                                _oQuery.Append(n_sImei_no.Trim() + "','");
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

                                _oQuery.Append("0)");

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
                                    _oMobileRetentionOrderEntity.SetCid(x_sUid);
                                    _oMobileRetentionOrderEntity.SetCdate(DateTime.Now);
                                    _oSession.Update(_oMobileRetentionOrderEntity);
                                    _oTransaction.Commit();
                                }
                            }
                        }
                        #endregion
                    }
                    if (_oEDFStatusProfile.AllowUpdateWebLogEDFIMEI(n_sRefNo, n_sImei_no) && !string.IsNullOrEmpty(x_sUid) && !string.IsNullOrEmpty(Func.FR(_oDr[MobileRetentionOrder.Para.order_id]).Trim()))
                    {
                        string _sQueryUpdate = "UPDATE MobileRetentionOrder SET imei_no='" + n_sImei_no + "',edf_no='" + n_sRefNo + "',cid='" + x_sUid + "',cdate=getdate() WHERE order_id='" + Func.FR(_oDr[MobileRetentionOrder.Para.order_id]).Trim() + "'";
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
            _oUpdateIMEIStockSql.Append(" AND Status='STOCK' AND STAFF_RECD='" + x_sUid + "'");
            bool _bUpdated = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oUpdateIMEIStockSql.ToString());
            #endregion



        }
    }






    protected bool IsFindIMEIAORecord(string x_sRecordid,string x_sSku)
    {

        string SKU = x_sSku.ToString();
        if (string.IsNullOrEmpty(x_sRecordid)) return false;
        if (string.IsNullOrEmpty(SKU)) return false;

        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("SELECT IMEI FROM IMEI_STOCK WHERE REFERENCENO='" + x_sRecordid.ToString() + "' AND KIT_CODE='" + SKU + "' AND STATUS='AO' ");
        OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(_oQuery.ToString());
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

    protected bool IsFindEdfRecord(string x_sEdf)
    {
        if (string.IsNullOrEmpty(x_sEdf)) return false;
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("SELECT REFERENCENO FROM SUNDAY_FORM WHERE REFERENCENO='" + x_sEdf + "' AND cancelled='N' AND rownum<=1");
        OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(_oQuery.ToString());
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

    protected bool UpdateEDF(int x_IOrder_id)
    {
        bool bFlag = false;
        string _sRemarksEDF = string.Empty;
        string _sToday = DateTime.Now.ToString("yyy-MM-dd HH:mm:ss");
        string _sToday1 = DateTime.Now.ToString("yyyyMMdd");
        MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect());
        _oMobileRetentionOrder.SetOrder_id(x_IOrder_id);

        if (_oMobileRetentionOrder.Retrieve())
        {
            if (_oMobileRetentionOrder.GetEdf_no().Trim().Equals(string.Empty))
            {
                RunJavascriptFunc("alert('Record ID:" + Func.IDAdd100000(x_IOrder_id) + " no edf number!');");
            }
            else if (_oOrderSerialNumberControl.CheckEdfNoInDB(_oMobileRetentionOrder.GetEdf_no()))
            {
                OdbcDataReader _oReader = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT * FROM sunday_form WHERE referenceNo ='" + _oMobileRetentionOrder.GetEdf_no() + "'");
                if (_oReader.Read())
                {
                    _sRemarksEDF = Func.FR(_oReader["remark"]).Trim();
                }
                _oReader.Close();
                _oReader.Dispose();

                string _sAmount = string.Empty;
                if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetAmount()))
                    _sAmount = "0";
                else
                    _sAmount = _oMobileRetentionOrder.GetAmount();
                string _sExtra_d_charge = string.Empty;
                if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetExist_cust_plan()))
                    _sExtra_d_charge = "0";
                else
                    _sExtra_d_charge = _oMobileRetentionOrder.GetExist_cust_plan();
                string _sAccessory_price = string.Empty;
                if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetAccessory_price()))
                    _sAccessory_price = "0";
                else
                    _sAccessory_price = _oMobileRetentionOrder.GetAccessory_price();

                StringBuilder _oQuery = new StringBuilder();
                _oQuery.Append("UPDATE sunday_Form SET ");
                //_oQuery.Append("Applicat_date = to_date('" + ((_oMobileRetentionOrder.GetLog_date() != null) ? ((DateTime)_oMobileRetentionOrder.GetLog_date()).ToString("dd/MM/yyyy") : string.Empty) + "','dd/mm/yyyy'),");
                _oQuery.Append("customer_name = '" + _oMobileRetentionOrder.GetCustomerName().Trim().Replace("'", "`") + "',");
                _oQuery.Append("staffNo = '" + _oMobileRetentionOrder.staff_no + "',");
                _oQuery.Append("staffName = '" + _oMobileRetentionOrder.staff_name.Trim().Replace("'", "`") + "',");
                _oQuery.Append("SalesManCode = '" + _oMobileRetentionOrder.salesmancode + "',");
                _oQuery.Append("Extn = '" + _oMobileRetentionOrder.extn + "',");

                if (_oMobileRetentionOrder.id_type == "BRNO")
                    _oQuery.Append("customer_ID_type ='BR',");
                else
                    _oQuery.Append("customer_ID_type ='" + _oMobileRetentionOrder.id_type + "',");
                if (_oMobileRetentionOrder.id_type == "HKID")
                    _oQuery.Append("customer_id='" + Func.Left(_oMobileRetentionOrder.hkid, _oMobileRetentionOrder.hkid.Length - 1) + "(" + Func.Right(_oMobileRetentionOrder.hkid, 1) + ")',");
                else
                    _oQuery.Append("customer_id='" + _oMobileRetentionOrder.hkid + "',");

                _oQuery.Append("Mobile_no='" + _oMobileRetentionOrder.mrt_no + "',");
                _oQuery.Append("Contact_no='" + _oMobileRetentionOrder.contact_no + "',");
                Double _dTotal = 0.0;
                Double _dAmount2, _dAccessory_price, _dExtra_d_charge;
                if (Double.TryParse(_sAmount, out _dAmount2))
                    _dTotal += _dAmount2;
                if (Double.TryParse(_sAccessory_price, out _dAccessory_price))
                    _dTotal += _dAccessory_price;
                if (Double.TryParse(_sExtra_d_charge, out _dExtra_d_charge))
                    _dTotal += _dExtra_d_charge;

                _oQuery.Append("Order_Amt='" + ((_dTotal == 0.0) ? string.Empty : _dTotal.ToString()) + "',");
                _oQuery.Append("Delivery_charge='" + _oMobileRetentionOrder.extra_d_charge + "',");
                _oQuery.Append("E_delivery_date='" + ((_oMobileRetentionOrder.GetD_date() != null) ? ((DateTime)_oMobileRetentionOrder.GetD_date()).ToString("dd/MM/yyyy") : string.Empty) + "',");
                _oQuery.Append("E_Delivery_period='" + _oMobileRetentionOrder.d_time + "',");
                _oQuery.Append("Dummy2='" + _oMobileRetentionOrder.d_address.Trim().Replace("'", "`") + "',");

                if (_oMobileRetentionOrder.vip_case != "")
                    _oQuery.Append("Dummy3='" + _oMobileRetentionOrder.vip_case.Trim().Replace("'", "`") + "',");
                else
                    _oQuery.Append("Dummy3='',");
                _oQuery.Append("ItemCode='" + _oMobileRetentionOrder.sku + "',");
                _oQuery.Append("ItemDesc = '" + ((_oMobileRetentionOrder.hs_model.Length >= 50) ? Func.Left(_oMobileRetentionOrder.hs_model, 50) : _oMobileRetentionOrder.hs_model) + "',");
                _oQuery.Append("program = '" + _oMobileRetentionOrder.program + "',");
                _oQuery.Append("Rate_plan = '" + _oMobileRetentionOrder.rate_plan + "',");
                _oQuery.Append("contract_period = '" + _oMobileRetentionOrder.con_per + " MTH',");
                _oQuery.Append("Plan_code = '" + _oMobileRetentionOrder.accessory_code + "',");
                _oQuery.Append("FG_Code = '" + _oMobileRetentionOrder.accessory_desc + "',");
                _oQuery.Append("FG_IMEI0 = '" + _oMobileRetentionOrder.accessory_imei + "',");
                _oQuery.Append("FreeGift1 = '" + _oMobileRetentionOrder.gift_code + "',");
                _oQuery.Append("FG_Desc1 = '" + _oMobileRetentionOrder.gift_desc + "',");
                _oQuery.Append("FG_IMEI1 = '" + _oMobileRetentionOrder.gift_imei + "',");
                _oQuery.Append("FreeGift2 = '" + _oMobileRetentionOrder.gift_code2 + "',");
                _oQuery.Append("FG_Desc2 = '" + _oMobileRetentionOrder.gift_desc2 + "',");
                _oQuery.Append("FG_IMEI2 = '" + _oMobileRetentionOrder.gift_imei2 + "',");
                _oQuery.Append("FreeGift3 = '" + _oMobileRetentionOrder.gift_code3 + "',");
                _oQuery.Append("FG_Desc3 = '" + _oMobileRetentionOrder.gift_desc3 + "',");
                _oQuery.Append("FG_IMEI3 = '" + _oMobileRetentionOrder.gift_imei3 + "',");
                _oQuery.Append("FreeGift4 = '" + _oMobileRetentionOrder.gift_code4 + "',");
                _oQuery.Append("FG_Desc4 = '" + _oMobileRetentionOrder.gift_desc4 + "',");
                _oQuery.Append("FG_IMEI4 = '" + _oMobileRetentionOrder.gift_imei4 + "',");
                _oQuery.Append("CASH_AMT = '" + _oMobileRetentionOrder.accessory_price + "',");

                if (!_oMobileRetentionOrder.imei_no.Equals("AWAIT") && !_oMobileRetentionOrder.imei_no.Equals("AO"))
                    _oQuery.Append("IMEI = '" + _oMobileRetentionOrder.imei_no + "',");
                else
                    _oQuery.Append("IMEI = '',");

                _oQuery.Append("TRADE = '" + _oMobileRetentionOrder.trade_field + "',");
                _oQuery.Append("REBATE = '" + _oMobileRetentionOrder.rebate_amount + "',");

                if (_oMobileRetentionOrder.pay_method == "" || string.IsNullOrEmpty(_oMobileRetentionOrder.pay_method))
                    _oQuery.Append("HS_payment_type = '',");
                else if (_oMobileRetentionOrder.pay_method == "CREDIT CARD")
                    _oQuery.Append("HS_payment_type = 'CREDIT CARD FULL PAY',");
                else if (_oMobileRetentionOrder.pay_method == "CREDIT CARD INSTALLMENT")
                    _oQuery.Append("HS_payment_type = '" + _oMobileRetentionOrder.bank_code + "',");
                else
                    _oQuery.Append("HS_payment_type = 'COD',");

                _oQuery.Append("HS_CARD_NO='" + _oMobileRetentionOrder.card_no + "',");

                if (!string.IsNullOrEmpty(_oMobileRetentionOrder.card_holder))
                    _oQuery.Append("HS_C_HOLDER_NAME='" + _oMobileRetentionOrder.card_holder.Trim().Replace("'", "`") + "',");
                else
                    _oQuery.Append("HS_C_HOLDER_NAME='',");

                if (_oMobileRetentionOrder.card_exp_month != "" && !string.IsNullOrEmpty(_oMobileRetentionOrder.card_exp_month) && _oMobileRetentionOrder.card_exp_year != "" && !string.IsNullOrEmpty(_oMobileRetentionOrder.card_exp_year))
                {
                    _oQuery.Append("HS_EXPIRYDATE='" + _oMobileRetentionOrder.card_exp_month + Func.Right(_oMobileRetentionOrder.card_exp_year, 2) + "',");
                }
                else
                {
                    _oQuery.Append("HS_EXPIRYDATE='',");
                }
                /*
                if (_oMobileRetentionOrder.ord_place_rel.Trim().Replace("'", "`") != "" && _oMobileRetentionOrder.ord_place_rel.Trim().Replace("'", "`") != "sub")
                {
                    if (_sRemarksEDF.Trim().ToUpper() !=
                        (_oMobileRetentionOrder.remarks2EDF.Trim().Replace("'", "`") + " Order Placed By " + _oMobileRetentionOrder.ord_place_rel.Trim().Replace("'", "`") + ", " + _oMobileRetentionOrder.ord_place_by.Trim().Replace("'", "`") + ", " + _oMobileRetentionOrder.ord_place_hkid.Trim().Replace("'", "`")))
                    {
                        _oQuery.Append("Remark=Remark || ' " + _oMobileRetentionOrder.remarks2EDF.Trim().Replace("'", "`") + " Order Placed By " + _oMobileRetentionOrder.ord_place_rel.Trim().Replace("'", "`") + ", " + _oMobileRetentionOrder.ord_place_by.Trim().Replace("'", "`") + ", " + _oMobileRetentionOrder.ord_place_hkid.Trim().Replace("'", "`") + "',");
                    }
                }
                else
                {
                    _oQuery.Append("Remark=Remark || ' " + _oMobileRetentionOrder.remarks2EDF.Trim().Replace("'", "`") + "',");
                }
                */
                _oQuery.Append("HS_PAY_AMT='" + _oMobileRetentionOrder.amount + "',");

                if (_oMobileRetentionOrder.premium != "")
                    _oQuery.Append("Premium_Gift='" + _oMobileRetentionOrder.premium + "',");
                else
                    _oQuery.Append("Premium_Gift='N/A',");

                if (_oMobileRetentionOrder.ext_place_tel != "")
                    _oQuery.Append("Contact_No_R='" + _oMobileRetentionOrder.ext_place_tel + "',");
                else
                    _oQuery.Append("Contact_No_R='N/A',");

                if (_oMobileRetentionOrder.con_eff_date != null)
                {
                    _oQuery.Append("COMPANY_NAME='" + ((DateTime)_oMobileRetentionOrder.con_eff_date).ToString("MM/dd/yyyy") + "',");
                }
                else
                {
                    _oQuery.Append("COMPANY_NAME='',");
                }
                _oQuery.Append("VAS='" + _oMobileRetentionOrder.bundle_name + "',");
                _oQuery.Append("User_Name='" + _oMobileRetentionOrder.contact_person.Trim().Replace("'", "`") + "',");
                //_oQuery.Append("ament_counter = ament_counter + 1 ,");
                _oQuery.Append("agree_no='" + (_oMobileRetentionOrder.GetOrder_id() + 100000).ToString() + "' ");
                _oQuery.Append(" WHERE referenceNo ='" + _oMobileRetentionOrder.edf_no.Trim() + "'");
                
                bFlag = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery.ToString());
                if (bFlag)
                {

                }
                else
                {
                    RunJavascriptFunc("alert('Fail To Update EDF Record");
                }
            }
        }
        return bFlag;
    }



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
            _oQuery.Append(" Status='" + x_sStatus + "' AND ");
            _oQuery.Append(" DUMMY4='" + Func.IDAdd100000(_oMobileRetentionOrder.GetOrder_id()) + "'  ");

            OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(_oQuery.ToString());
            if (!_oDr.Read())
            {
                string _sQuery2 = "INSERT INTO IMEI_Stock (Kit_Code,Model,Status,DUMMY4,ReferenceNo,Create_Date,Create_By,StaffNo,Dummy2,Dummy3) VALUES ('" + _oMobileRetentionOrder.GetSku().Trim() + "','" + _oMobileRetentionOrder.GetHs_model().Trim() + "','" + x_sStatus + "','" + _sRecordId + "','" + _sEdf_no + "',to_date('" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "' , 'dd/mm/yyyy hh24:mi:ss'),'" + _oMobileRetentionOrder.GetStaff_no().Trim() + "','" + _oMobileRetentionOrder.GetStaff_no().Trim() + "','CC RET','" + _oMobileRetentionOrder.GetDelivery_exchange_location() + "') ";
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


    #region GetDB
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
        _oDB.SetConnStr(Configurator.DBName.ORADNS + ((Configurator.IsUat()) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion

}
