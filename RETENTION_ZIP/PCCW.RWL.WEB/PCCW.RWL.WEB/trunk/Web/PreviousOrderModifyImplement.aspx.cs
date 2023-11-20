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
using PCCW.RWL.WEB.UI.Order;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;



public partial class PreviousOrderModifyImplement : NEURON.WEB.UI.BasePage
{


    string[] n_sDateTimeList = { "dd/MM/yyyy HH:mm", "d/MM/yyyy HH:mm", "dd/M/yyyy HH:mm", "dd/MM/yyyy HH:mm:ss", "d/MM/yyyy HH:mm:ss", "dd/M/yyyy HH:mm:ss", "dd/MM/yyyy", "d/MM/yyyy", "dd/M/yyyy", "d/M/yyyy" };
    string _sOld_sku = string.Empty;
    string _sSku = string.Empty;

    string _sOld_sim_no = string.Empty;
    string _sSim_no = string.Empty;
    string _sOld_sim_code = string.Empty;
    string _sSim_code = string.Empty;
    bool _bNewEDFOrder = false;
    bool _bUpdateFail = false;
    string x_sMobileNumber = string.Empty;
    bool _bInsertNewHS = false;
    bool _bInsertNewSim = false;
    
    EDFStatusProfile _oEDFStatusProfile = new EDFStatusProfile();
    
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
        if (!IsPostBack) InitFrame();
        IsModifyEDF(Func.IDSubtract100000(WebFunc.qsOrder_id));
    }

    protected void CheckMobileOrderBeforeSave(MobileRetentionOrder x_oMobileRetentionOrder)
    {
        if (x_oMobileRetentionOrder.GetIssue_type().Equals("MOBILE_LITE") ||
            (
            x_oMobileRetentionOrder.GetIssue_type().Equals("UPGRADE") &&
            (x_oMobileRetentionOrder.GetHs_model() != string.Empty || x_oMobileRetentionOrder.GetSim_item_name() != string.Empty)
            )
            ||
            !string.IsNullOrEmpty(x_oMobileRetentionOrder.GetHs_model()))
        {
            if (string.IsNullOrEmpty(x_oMobileRetentionOrder.GetD_address().Trim()))
                Response.Redirect("MobileOrderLockMessage.aspx?OrderLockMsg=Error: Please kindly enter the delivery address!");
            if (x_oMobileRetentionOrder.GetD_date() == null)
                Response.Redirect("MobileOrderLockMessage.aspx?OrderLockMsg=Error: Please kindly enter the delivery date!");
        }
    }

    protected void CheckRefeshOrderPage()
    {

        bool _bFlag = true;
        if (Session["ModifyOrder"] != null)
        {
            if (Session["ModifyOrder"].ToString() != "ModifyOrder")
            {
                _bFlag = false;
            }
        }
        else
            _bFlag = false;

        if (!_bFlag)
            Response.Redirect("MobileOrderLockMessage.aspx?OrderLockMsg=Cannot refesh the page!"); 
    }

    public void SendPY()
    {
        #region Send Modification of Suspension report to PY Operation(CS Admin)
        /*================= Send Modification of Suspension report to PY Operation(CS Admin) ==================*/
        string _sSuspend_mod = string.Empty;
        string _sQuery2 = "SELECT action_required,issue_type FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) WHERE order_id='" + Func.RQ(Func.IDSubtract100000(WebFunc.qsOrder_id)) + "'";
        string _sIssue_type = string.Empty;
        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery2);
        if (_oDr.Read())
        {
            _sIssue_type = Func.FR(_oDr["issue_type"]).Trim().ToUpper();
            _sSuspend_mod = Func.FR(_oDr[MobileRetentionOrder.Para.action_required]).ToString();
            _oDr.Close();
            _oDr.Dispose();
        }
        if (_sSuspend_mod.Trim().Equals("suspend") || _sSuspend_mod.Trim().Equals("opt_out"))
        {
            RwlReportSYSControl _oRwlReportSYSControl = RwlReportSYSControl.Instance();
            _oRwlReportSYSControl.SetOrder_id(Func.IDSubtract100000(WebFunc.qsOrder_id));
            _oRwlReportSYSControl.SetUid(RWLFramework.CurrentUser[this.Page].Uid);
            _oRwlReportSYSControl.SetNow(DateTime.Now);
            _oRwlReportSYSControl.HistoryRecordCreate(_sIssue_type);
        }
        _oDr.Close();
        _oDr.Dispose();
        /*================= End of Send Modification of Suspension report to PY Operation(CS Admin) ==================*/
        #endregion

    }

    public bool IsNoEDFIMEIHsOrder(string x_sOrder_id)
    {
        if (string.IsNullOrEmpty(x_sOrder_id)) { return false; }
        string _sId = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar("SELECT order_id from MobileRetentionOrder where hs_model is not null and hs_model<>'' and (edf_no is null or edf_no='') and (imei_no is null or imei_no='') and order_id='" + x_sOrder_id + "'");
        if (_sId.Trim().Equals(string.Empty)) return false;
        return true;
    }

    public void InitFrame()
    {
        if (WebFunc.qsOrder_id == null) return;
        string _sToday = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        string _sToday1 = DateTime.Now.ToString("yyyyMMdd");
        string _sToday2 = DateTime.Now.ToString("yyyy-MM-dd");
        string _sHr_model = "";
        
        MobileRetentionOrder _oMobileRetentionOrder = (MobileRetentionOrder)MobileRetentionOrderRepository.CreateEntityInstanceObject();
        _oMobileRetentionOrder.SetOrder_id(Convert.ToInt32(Func.IDSubtract100000(WebFunc.qsOrder_id)));
        if (!_oMobileRetentionOrder.Retrieve()) return;

        _oMobileRetentionOrder.SetDelivery_exchange_location(WebFunc.qsDelivery_exchange_location);

        string _sImei_no = _oMobileRetentionOrder.GetImei_no();

        string _sQuery = "SELECT * FROM " + Configurator.MSSQLTablePrefix + "BusinessTrade with (nolock) WHERE active=1 AND program='" + WebFunc.qsProgram.Trim() + "' AND con_per='" + WebFunc.qsCon_per.Trim() + "' AND rate_plan='" + WebFunc.qsRate_plan.Trim() + "' AND trade_field='" + WebFunc.qsTrade_field.Trim() + "' AND bundle_name='" + WebFunc.qsBundle_name.Trim() + "'";
        SqlDataReader _oDr3 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
        if (_oDr3.Read() || WebFunc.qsAction_required.Equals("on") || WebFunc.qsAction_required.Equals("suspend"))
        {
            SendPY();
            string _sBank_name = string.Empty;
            MobileRetentionOrderBal.BackUpOrder(Convert.ToInt32(Func.IDSubtract100000(WebFunc.qsOrder_id)), RWLFramework.CurrentUser[this.Page].Uid);
            string _sQuery6 = "SELECT bank_name FROM " + Configurator.MSSQLTablePrefix + "BankCode with (nolock) WHERE active=1 AND bank_code='" + WebFunc.qsBank_code + "'";
            _sBank_name = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar(_sQuery6);
            _sSku = WebFunc.qsSku.Trim();
            if (_sSku.Equals( "0"))
            {
                _sSku = string.Empty;
            }
            //_sSim_no = WebFunc.qsSim_item_number;
            _sOld_sim_code = _oMobileRetentionOrder.GetSim_item_code();
            _sSim_code = WebFunc.qsSim_item_code;
            string _sHs_model = WebFunc.qsHs_model;
            _oMobileRetentionOrder.SetHs_model(_sHs_model);

            //=== find SKU ===
            if (Func.RQ(WebFunc.qsHs_model).Equals(string.Empty) && (Func.RQ(WebFunc.qsSku).Equals(string.Empty) || Func.RQ(WebFunc.qsSku) == "0"))
            {
                string _sQuerySql = "SELECT item_code FROM " + Configurator.MSSQLTablePrefix + "ProductItemCode with (nolock) WHERE active=1 AND hs_model='" + Func.RQ(WebFunc.qsHs_model) + "'";
                _sSku = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar(_sQuerySql);
            }

            //=== find HS name ===
            if (Func.RQ(WebFunc.qsHs_model).Equals(string.Empty) && Func.RQ(WebFunc.qsSku) != string.Empty)
            {
                string _sQuery7 = "SELECT hs_model FROM " + Configurator.MSSQLTablePrefix + "ProductItemCode with (nolock) WHERE active=1 AND item_code='" + Func.RQ(WebFunc.qsSku) + "'";
                _sHs_model = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar(_sQuery7);
            }
            #region Release old HS & Assign New HS

            //'================= Release old HS & Assign New HS ==================
            string _sQuery8 = "SELECT TOP 1 * FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) WHERE order_id='" + Func.RQ(Func.IDSubtract100000(WebFunc.qsOrder_id)).ToString() + "'";

            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery8);
            if (_oDr.Read())
            {
                if (IsNoEDFIMEIHsOrder(Func.IDSubtract100000(WebFunc.qsOrder_id)))
                {
                    _bInsertNewHS = true;
                }
                else
                {
                    _sOld_sku = Func.FR(_oDr["sku"]);
                }
                #region *changed sku *add new HS *add new SIM
                if (_sOld_sku != _sSku || _bInsertNewHS)
                {
                    string _sSql = "UPDATE " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder SET ";
                    _sSql += " imei_no=null ";
                    _sSql += " where order_id='" + Func.IDSubtract100000(WebFunc.qsOrder_id) + "'";
                    SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_sSql);

                    /*================= Release old HS ==================*/
                    OdbcDataReader _oDr2 = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT * FROM IMEI_Stock WHERE Dummy2='CC RET' AND DUMMY4='" + (Convert.ToInt32(WebFunc.qsOrder_id)).ToString() + "' AND (IMEI not like 'FG%' or IMEI=' ' or IMEI is null)");
                    while (_oDr2.Read())
                    {
                        IMEIGiftStatusControl _oIMEIGiftStatusControl = new IMEIGiftStatusControl();
                        _oIMEIGiftStatusControl.SetImei_no(_sImei_no);
                        _oIMEIGiftStatusControl.SetIMEI(Func.FR(_oDr2["IMEI"]));
                        _oIMEIGiftStatusControl.SetCreate_Date(Func.FR(_oDr2["Create_Date"]));
                        _oIMEIGiftStatusControl.SetDummy1(Func.FR(_oDr2["Dummy1"]));
                        _oIMEIGiftStatusControl.SetKit_Code(Func.FR(_oDr2["Kit_Code"]));
                        _oIMEIGiftStatusControl.SetModel(Func.FR(_oDr2["Model"]));
                        _sHr_model = Func.FR(_oDr2["Model"]);
                        _oIMEIGiftStatusControl.SetStatus(Func.FR(_oDr2["Status"]));
                        _oIMEIGiftStatusControl.SetReferenceNo(Func.FR(_oDr2["ReferenceNo"]));
                        _oIMEIGiftStatusControl.SetDummy4(Func.FR(_oDr2["DUMMY4"]));
                        _oIMEIGiftStatusControl.SetToday(_sToday);
                        _oIMEIGiftStatusControl.SetToday1(_sToday1);
                        _oIMEIGiftStatusControl.SetUid(RWLFramework.CurrentUser[this.Page].Uid);
                        _oIMEIGiftStatusControl.SetDummy1(Func.FR(_oDr2["Dummy1"]));
                        _oIMEIGiftStatusControl.SetDummy2(Func.FR(_oDr2["Dummy2"]));
                        _oIMEIGiftStatusControl.SetDummy3(Func.FR(_oDr2["Dummy3"]));
                        _oIMEIGiftStatusControl.SetSku(_oMobileRetentionOrder.GetSku());
                        _oIMEIGiftStatusControl.SetOrder_id(Func.IDAdd100000(_oMobileRetentionOrder.GetOrder_id()));
                        _oIMEIGiftStatusControl.ManagementGiftIMEIStatus(_oMobileRetentionOrder.GetDelivery_exchange_location());
                    }
                    _oDr2.Close();
                    _oDr2.Dispose();
                    /*'================= End of Release old HS ==================*/

                    /*'================= Assign New HS ==================*/
                    if (!Convert.IsDBNull(_oDr["edf_no"]) && !"".Equals(_oDr["edf_no"].ToString()))
                    {
                        if (
                            (
                            (!string.IsNullOrEmpty(Func.FR(_oDr["sku"]).ToString()) && Func.FR(_oDr["sku"]).ToString() != "0") ||
                            !string.IsNullOrEmpty(Func.FR(_oDr["sim_item_code"]).ToString())
                            )
                            ||
                            (
                            _oMobileRetentionOrder.GetIssue_type().Equals("UPGRADE") &&
                            _sOld_sku==string.Empty && _sSku!=string.Empty
                            )
                            )
                        {
                            IMEISoldAwaitControl _oIMEISoldAwaitControl = new IMEISoldAwaitControl();
                            _oIMEISoldAwaitControl.SetSku(_sSku);
                            _oIMEISoldAwaitControl.SetHs_model(_sHs_model);
                            _oIMEISoldAwaitControl.SetOrder_id(Func.IDAdd100000(_oMobileRetentionOrder.GetOrder_id()));
                            _oIMEISoldAwaitControl.SetEdf_no(_oMobileRetentionOrder.GetEdf_no());
                            _oIMEISoldAwaitControl.SetStaff_no(Func.FR(_oDr["staff_no"]));
                            _oIMEISoldAwaitControl.SetToday1(_sToday1);
                            _oIMEISoldAwaitControl.SetToday(_sToday);
                            _oIMEISoldAwaitControl.SetUid(RWLFramework.CurrentUser[this.Page].Uid);
                            _oIMEISoldAwaitControl.SetEdf_no(_oMobileRetentionOrder.GetEdf_no());
                            _oIMEISoldAwaitControl.SetMrt_no(Func.FR(_oDr["mrt_no"]));
                            _oIMEISoldAwaitControl.ManagementProductSoldAwait(_oMobileRetentionOrder.GetDelivery_exchange_location());
                            _oMobileRetentionOrder.SetImei_no(_oIMEISoldAwaitControl.GetImei_no());
                        }
                        else
                        {
                            MobileRetentionOrderBal.IMEIRelease(Func.IDSubtract100000(WebFunc.qsOrder_id));
                        }
                    }
                }
                #endregion
                /*	================= End of Assign New HS ==================		*/
            }
            _oDr.Close();
            _oDr.Dispose();

            //================= End of Release old HS & Assign New HS ==================

            _oMobileRetentionOrder.SetHs_model(WebFunc.qsHs_model);
            if (_oMobileRetentionOrder.GetIssue_type() != "UPGRADE")
            {
                if (_oMobileRetentionOrder.GetHs_model().Trim().Equals(string.Empty))
                {
                    if (_oMobileRetentionOrder.GetSim_item_code().Trim() == "")
                    {
                        if (_oMobileRetentionOrder.GetEdf_no() != string.Empty)
                        {
                            EDFStatusProfile.EDFOrderDelete((int)WebFunc.qsOrder_id, RWLFramework.CurrentUser[this.Page].Uid, string.Empty);
                        }
                        _oMobileRetentionOrder.SetEdf_no(string.Empty);
                    }
                    _oMobileRetentionOrder.SetImei_no(string.Empty);
                }
            }

            #endregion SIM Item

            #region set other for _oMobileRetentionOrder
            DateTime _dLog_date;
            string _sLog_date = string.Empty;
            if (Func.IsParseDateTime(HttpContext.Current.Request["log_date"]) && !Func.RQ(HttpContext.Current.Request["log_date"]).Equals(string.Empty))
                _sLog_date = HttpContext.Current.Request["log_date"].ToString();

            if (DateTime.TryParseExact(_sLog_date, n_sDateTimeList, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dLog_date))
                _oMobileRetentionOrder.SetLog_date(_dLog_date);
            else
                _oMobileRetentionOrder.SetLog_date(null);

            _oMobileRetentionOrder.SetLanguage(WebFunc.qsLanguage);

            DateTime _dVas_eff_date;
            string _sVas_eff_date = string.Empty;
            if (Func.IsParseDateTime(HttpContext.Current.Request["vas_eff_date"]) && !Func.RQ(HttpContext.Current.Request["vas_eff_date"]).Equals(string.Empty))
            {
                _sVas_eff_date = HttpContext.Current.Request["vas_eff_date"].ToString();
                if (DateTime.TryParseExact(_sVas_eff_date, n_sDateTimeList, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dVas_eff_date))
                    _oMobileRetentionOrder.SetVas_eff_date(_dVas_eff_date);
                else
                    _oMobileRetentionOrder.SetVas_eff_date(null);
            }
            else
                _oMobileRetentionOrder.SetVas_eff_date(null);

            string _sNextBill = (Request["next_bill"] != null) ? Request["next_bill"].ToString().Trim() : string.Empty;
            bool _bNextBill = (_sNextBill == "on" || _sNextBill == "1") ? true : false;
            _oMobileRetentionOrder.SetNext_bill(_bNextBill);

            DateTime _dCon_eff_date;
            string _sCon_eff_date = string.Empty;
            if (Func.IsParseDateTime(HttpContext.Current.Request["con_eff_date"]) && !Func.RQ(HttpContext.Current.Request["con_eff_date"]).Equals(string.Empty))
            {
                _sCon_eff_date = HttpContext.Current.Request["con_eff_date"].ToString();

                if (!_bNextBill && DateTime.TryParseExact(_sCon_eff_date, n_sDateTimeList, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dCon_eff_date))
                    _oMobileRetentionOrder.SetCon_eff_date(_dCon_eff_date);
                else
                    _oMobileRetentionOrder.SetCon_eff_date(null);
            }
            else
                _oMobileRetentionOrder.SetCon_eff_date(null);

            _oMobileRetentionOrder.SetCust_type(WebFunc.qsCust_type.Trim());
            if (WebFunc.qsGiven_name.Trim() != string.Empty || WebFunc.qsFamily_name.Trim() != string.Empty)
            {
                _oMobileRetentionOrder.SetCust_name(((WebFunc.qsFamily_name.Trim() != string.Empty) ? WebFunc.qsFamily_name.Trim() + " " : string.Empty) + WebFunc.qsGiven_name.Trim());
            }
            else
                _oMobileRetentionOrder.SetCust_name(WebFunc.qsCust_name.Trim());
            _oMobileRetentionOrder.SetFamily_name(WebFunc.qsFamily_name.Trim());
            _oMobileRetentionOrder.SetGiven_name(WebFunc.qsGiven_name.Trim());

            _oMobileRetentionOrder.SetAc_no(WebFunc.qsAc_no.Trim());
            _oMobileRetentionOrder.SetMrt_no(Convert.ToInt32(WebFunc.qsMrt_no.Trim()));
            _oMobileRetentionOrder.SetId_type(WebFunc.qsId_type.Trim());
            _oMobileRetentionOrder.SetHkid(WebFunc.qsHkid.Replace("'", "''") + WebFunc.qsHkid2.Replace("'", "''"));
            _oMobileRetentionOrder.SetVip_case(WebFunc.qsVip_case.Trim());
            _oMobileRetentionOrder.SetProgram(WebFunc.qsProgram.Trim());
            _oMobileRetentionOrder.SetCust_staff_no(WebFunc.qsCust_staff_no.Trim());
            _oMobileRetentionOrder.SetEasywatch_type(WebFunc.qsEasywatch_type.Trim());
            _oMobileRetentionOrder.SetEasywatch_ord_id(WebFunc.qsEasywatch_ord_id.Trim());
            _oMobileRetentionOrder.SetRate_plan(WebFunc.qsRate_plan.Trim());

            _oMobileRetentionOrder.SetNormal_rebate_type(WebFunc.qsNormal_rebate_type);
            
            _oMobileRetentionOrder.SetLob(WebFunc.qsLob.Trim());
            _oMobileRetentionOrder.SetLob_ac(WebFunc.qsLob_ac.Trim());
            _oMobileRetentionOrder.SetCon_per(WebFunc.qsCon_per.Trim());
            _oMobileRetentionOrder.SetFree_mon(WebFunc.qsFree_mon.Trim());
            _oDr.Close();
            _oDr.Dispose();

            

            if (!"".Equals(WebFunc.qsFast_start) && "Y".Equals(WebFunc.qsFast_start))
                _oMobileRetentionOrder.SetFast_start(true);
            else
                _oMobileRetentionOrder.SetFast_start(false);

            DateTime _dPlan_eff_date;
            string _sPlan_eff_date = string.Empty;
            if (Func.IsParseDateTime(HttpContext.Current.Request["plan_eff_date"]) && !Func.RQ(HttpContext.Current.Request["con_eff_date"]).Equals(string.Empty))
                _sPlan_eff_date = HttpContext.Current.Request["plan_eff_date"].ToString();

            if (DateTime.TryParseExact(_sPlan_eff_date, n_sDateTimeList, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dPlan_eff_date))
                _oMobileRetentionOrder.SetPlan_eff_date(_dPlan_eff_date);
            else
                _oMobileRetentionOrder.SetPlan_eff_date(null);

            if (!"".Equals(WebFunc.qsM_rebate_amount))
                _oMobileRetentionOrder.SetM_rebate_amount(WebFunc.qsM_rebate_amount.Replace("'", "''").Trim().ToLower());
            else
                _oMobileRetentionOrder.SetM_rebate_amount(null);

            if (!"".Equals(WebFunc.qsRebate_amount))
                _oMobileRetentionOrder.SetRebate_amount(WebFunc.qsRebate_amount.Replace("'", "''").Trim());
            else
                _oMobileRetentionOrder.SetRebate_amount(null);

            if (!"".Equals(WebFunc.qsR_offer))
                _oMobileRetentionOrder.SetR_offer(WebFunc.qsR_offer.Replace("'", "''").Trim());
            else
                _oMobileRetentionOrder.SetR_offer(null);

            if (!"".Equals(WebFunc.qsExtra_rebate))
                _oMobileRetentionOrder.SetExtra_rebate(WebFunc.qsExtra_rebate.Replace("'", "''").Trim().ToLower());
            else
                _oMobileRetentionOrder.SetExtra_rebate(null);

            if (!"".Equals(WebFunc.qsExtra_rebate_amount))
                _oMobileRetentionOrder.SetExtra_rebate_amount(WebFunc.qsExtra_rebate_amount.Replace("'", "''").Trim().ToLower());
            else
                _oMobileRetentionOrder.SetExtra_rebate_amount(null);

            _oMobileRetentionOrder.SetD_address(WebFunc.qsD_address.ToUpper());
            _oMobileRetentionOrder.SetVip_case(WebFunc.qsVip_case);


            DateTime _dD_date;
            string _sD_date = string.Empty;
            if (Func.IsParseDateTime(HttpContext.Current.Request["d_date"]) && !Func.RQ(HttpContext.Current.Request["d_date"]).Equals(string.Empty))
                _sD_date = HttpContext.Current.Request["d_date"].ToString();

            if (DateTime.TryParseExact(_sD_date, n_sDateTimeList, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dD_date))
                _oMobileRetentionOrder.SetD_date(_dD_date);
            else
                _oMobileRetentionOrder.SetD_date(null);

            _oMobileRetentionOrder.SetD_time(WebFunc.qsD_time);
            _oMobileRetentionOrder.SetExtra_d_charge(WebFunc.qsExtra_d_charge);
            _oMobileRetentionOrder.SetContact_person(WebFunc.qsContact_person);
            _oMobileRetentionOrder.SetContact_no(WebFunc.qsContact_no);
            _oMobileRetentionOrder.SetCard_type(WebFunc.qsCard_type);
            _oMobileRetentionOrder.SetCard_holder(WebFunc.qsCard_holder);
            _oMobileRetentionOrder.SetCard_exp_month(WebFunc.qsCard_exp_month);
            _oMobileRetentionOrder.SetCard_exp_year(WebFunc.qsCard_exp_year);
            _oMobileRetentionOrder.SetMonthly_payment_method(WebFunc.qsMonthly_payment_method);


            _oMobileRetentionOrder.SetM_card_type(WebFunc.qsM_card_type);
            _oMobileRetentionOrder.SetM_card_holder2(WebFunc.qsM_card_holder2);
            if ("".Equals(WebFunc.qsM_card_holder2.Replace("'", "''")))
                _oMobileRetentionOrder.SetM_card_holder2(null);
            else
                _oMobileRetentionOrder.SetM_card_holder2(WebFunc.qsM_card_holder2.Replace("'", "''"));

            if ("".Equals(WebFunc.qsM_card_exp_month))
                _oMobileRetentionOrder.SetM_card_exp_month(null);
            else
                _oMobileRetentionOrder.SetM_card_exp_month(WebFunc.qsM_card_exp_month.Replace("'", "''").Trim());

            if ("".Equals(WebFunc.qsM_card_exp_year))
                _oMobileRetentionOrder.SetM_card_exp_year(null);
            else
                _oMobileRetentionOrder.SetM_card_exp_year(WebFunc.qsM_card_exp_year.Replace("'", "''").Trim());

            /*
             if ("".Equals(WebFunc.qsM_card_no1.Replace("'", "''")))
                 _oMobileRetentionOrder.SetM_card_no(null);
             else
             {
                 string _sCardNo = WebFunc.qsM_card_no1.Replace("'", "''") + WebFunc.qsM_card_no2.Replace("'", "''") + WebFunc.qsM_card_no3.Replace("'", "''") + WebFunc.qsM_card_no4.Replace("'", "''");
                 _oMobileRetentionOrder.SetM_card_no(_sCardNo);
             }
         */

            _oMobileRetentionOrder.SetM_card_no(WebFunc.qsM_card_no);


            _oMobileRetentionOrder.SetAmount(WebFunc.qsAmount);
            _oMobileRetentionOrder.SetPay_method(WebFunc.qsPay_method);

            //_oMobileRetentionOrder.SetCard_no(WebFunc.qsCard_no1.Replace("'", "''") + WebFunc.qsCard_no2.Replace("'", "''") + WebFunc.qsCard_no3.Replace("'", "''") + WebFunc.qsCard_no4.Replace("'", "''"));

            _oMobileRetentionOrder.SetCard_no(WebFunc.qsCard_no);
            
            _oMobileRetentionOrder.SetBank_code(WebFunc.qsBank_code);
            _oMobileRetentionOrder.SetBank_name(WebFunc.qsBank_name);
            _oMobileRetentionOrder.SetRemarks(WebFunc.qsRemarks);
            _oMobileRetentionOrder.SetRemarks2EDF(WebFunc.qsRemarks2EDF);
            _oMobileRetentionOrder.SetRemarks2PY(WebFunc.qsRemarks2PY);
            _oMobileRetentionOrder.SetStaff_no(WebFunc.qsStaff_no.Trim());
            _oMobileRetentionOrder.SetStaff_name(WebFunc.qsStaff_name.Trim());
            _oMobileRetentionOrder.SetTeamcode(WebFunc.qsTeamcode);
            _oMobileRetentionOrder.SetSalesmancode(WebFunc.qsSalesmancode);
            _oMobileRetentionOrder.SetExtn(WebFunc.qsExtn);
            _oMobileRetentionOrder.SetTrade_field(WebFunc.qsTrade_field);
            _oMobileRetentionOrder.SetCancel_renew(WebFunc.qsCancel_renew);
            _oMobileRetentionOrder.SetPremium(WebFunc.qsPremium.Replace("'", "''"));
            _oMobileRetentionOrder.SetAction_eff_date(WebFunc.qsAction_eff_date);

            if (!string.IsNullOrEmpty(WebFunc.qsGift_imei))
            {
                _oMobileRetentionOrder.SetGift_code(WebFunc.qsGift_code);
                _oMobileRetentionOrder.SetGift_desc(WebFunc.qsGift_desc);
                _oMobileRetentionOrder.SetGift_imei(WebFunc.qsGift_imei);
            }
            else
            {
                _oMobileRetentionOrder.SetGift_code(null);
                _oMobileRetentionOrder.SetGift_desc(null);
                _oMobileRetentionOrder.SetGift_imei(null);
            }

            if (!string.IsNullOrEmpty(WebFunc.qsGift_imei2))
            {
                _oMobileRetentionOrder.SetGift_code2(WebFunc.qsGift_code2);
                _oMobileRetentionOrder.SetGift_desc2(WebFunc.qsGift_desc2);
                _oMobileRetentionOrder.SetGift_imei2(WebFunc.qsGift_imei2);
            }
            else
            {
                _oMobileRetentionOrder.SetGift_code2(null);
                _oMobileRetentionOrder.SetGift_desc2(null);
                _oMobileRetentionOrder.SetGift_imei2(null);
            }

            if (!string.IsNullOrEmpty(WebFunc.qsGift_imei3))
            {
                _oMobileRetentionOrder.SetGift_code3(WebFunc.qsGift_code3);
                _oMobileRetentionOrder.SetGift_desc3(WebFunc.qsGift_desc3);
                _oMobileRetentionOrder.SetGift_imei3(WebFunc.qsGift_imei3);
            }
            else
            {
                _oMobileRetentionOrder.SetGift_code3(null);
                _oMobileRetentionOrder.SetGift_desc3(null);
                _oMobileRetentionOrder.SetGift_imei3(null);
            }

            if (!string.IsNullOrEmpty(WebFunc.qsGift_imei4))
            {
                _oMobileRetentionOrder.SetGift_code4(WebFunc.qsGift_code4);
                _oMobileRetentionOrder.SetGift_desc4(WebFunc.qsGift_desc4);
                _oMobileRetentionOrder.SetGift_imei4(WebFunc.qsGift_imei4);
            }
            else
            {
                _oMobileRetentionOrder.SetGift_code4(null);
                _oMobileRetentionOrder.SetGift_desc4(null);
                _oMobileRetentionOrder.SetGift_imei4(null);
            }

            if (!string.IsNullOrEmpty(WebFunc.qsAccessory_imei))
            {
                _oMobileRetentionOrder.SetAccessory_code(WebFunc.qsAccessory_code);
                _oMobileRetentionOrder.SetAccessory_desc(WebFunc.qsAccessory_desc);
                _oMobileRetentionOrder.SetAccessory_price(WebFunc.qsAccessory_price);
                _oMobileRetentionOrder.SetAccessory_imei(WebFunc.qsAccessory_imei);
            }
            else
            {
                _oMobileRetentionOrder.SetAccessory_code(null);
                _oMobileRetentionOrder.SetAccessory_desc(null);
                _oMobileRetentionOrder.SetAccessory_imei(null);
                _oMobileRetentionOrder.SetAccessory_price(null);
            }


            _oMobileRetentionOrder.SetChannel(WebFunc.qsChannel);
            string _sAction_required = (WebFunc.qsAction_required.Trim().ToLower() == "on" || WebFunc.qsAction_required.Trim() == "1" || WebFunc.qsAction_required.Trim().ToLower() == "suspend") ? "suspend" : string.Empty;
            string _sAction_required2 = (WebFunc.qsAction_required2.Trim().ToLower() == "on" || WebFunc.qsAction_required2.Trim() == "1" || WebFunc.qsAction_required2.Trim().ToLower() == "opt_out") ? "opt_out" : string.Empty;

            if ("suspend".Equals(_sAction_required))
                _oMobileRetentionOrder.SetAction_required(_sAction_required);
            else if ("opt_out".Equals(_sAction_required2))
                _oMobileRetentionOrder.SetAction_required(_sAction_required2);
            else if ("opt_out".Equals(_sAction_required))
                _oMobileRetentionOrder.SetAction_required(_sAction_required);
            else
                _oMobileRetentionOrder.SetAction_required(string.Empty);



            if (Func.RB(Request["waive"]))
            {
                if ("Y".Equals(Func.RQ(Request["waive"])))
                    _oMobileRetentionOrder.SetWaive(true);
                else
                    _oMobileRetentionOrder.SetWaive(false);
            }
            else
            {
                _oMobileRetentionOrder.SetWaive(null);
            }


            DateTime _dAction_eff_date;
            string _sAction_eff_date = string.Empty;
            if (Func.IsParseDateTime(HttpContext.Current.Request["action_eff_date"]) && !Func.RQ(HttpContext.Current.Request["action_eff_date"]).Equals(string.Empty))
                _sAction_eff_date = HttpContext.Current.Request["action_eff_date"].ToString();

            if (DateTime.TryParseExact(_sAction_eff_date, n_sDateTimeList, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dAction_eff_date))
                _oMobileRetentionOrder.SetAction_eff_date(_dAction_eff_date);
            else
                _oMobileRetentionOrder.SetAction_eff_date(null);

            _oMobileRetentionOrder.SetBundle_name(WebFunc.qsBundle_name);
            _oMobileRetentionOrder.SetHs_offer_type_id(WebFunc.qsHs_offer_type_id);
            if (!"".Equals(WebFunc.qsAccept))
                _oMobileRetentionOrder.SetAccept(WebFunc.qsAccept);
            else
                _oMobileRetentionOrder.SetAccept(null);

            if (!"".Equals(WebFunc.qsRebate))
                _oMobileRetentionOrder.SetRebate(WebFunc.qsRebate);
            else
                _oMobileRetentionOrder.SetRebate(null);

            _oMobileRetentionOrder.SetExist_plan(WebFunc.qsExist_plan);
            _oMobileRetentionOrder.SetReasons(WebFunc.qsReasons);
            _oMobileRetentionOrder.SetTl_name(WebFunc.qsTl_name);
            _oMobileRetentionOrder.SetOrd_place_by(WebFunc.qsOrd_place_by);
            _oMobileRetentionOrder.SetOrd_place_rel(WebFunc.qsOrd_place_rel);
            _oMobileRetentionOrder.SetOrd_place_hkid(WebFunc.qsOrd_place_hkid.Replace("'", "''") + WebFunc.qsOrd_place_hkid2.Replace("'", "''"));
            _oMobileRetentionOrder.SetOrd_place_id_type(WebFunc.qsOrd_place_id_type);
            _oMobileRetentionOrder.SetOrd_place_tel(WebFunc.qsOrd_place_tel);
            _oMobileRetentionOrder.SetS_premium(WebFunc.qsS_premium);
            _oMobileRetentionOrder.SetS_premium2(WebFunc.qsS_premium2);


            DateTime _dSp_d_date;
            string _sSp_d_date = string.Empty;
            if (Func.IsParseDateTime(HttpContext.Current.Request["sp_d_date"]) && !Func.RQ(HttpContext.Current.Request["sp_d_date"]).Equals(string.Empty))
                _sSp_d_date = HttpContext.Current.Request["sp_d_date"].ToString();

            if (DateTime.TryParseExact(_sSp_d_date, n_sDateTimeList, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dSp_d_date))
                _oMobileRetentionOrder.SetSp_d_date(_dSp_d_date);
            else
                _oMobileRetentionOrder.SetSp_d_date(null);

            _oMobileRetentionOrder.SetSp_ref_no(WebFunc.qsSp_ref_no);
            _oMobileRetentionOrder.SetAig_gift(WebFunc.qsAig_gift);
            _oMobileRetentionOrder.SetExist_cust_plan(WebFunc.qsExist_cust_plan);
            _oMobileRetentionOrder.SetOrg_fee(WebFunc.qsOrg_fee);
            _oMobileRetentionOrder.SetOrg_ftg(WebFunc.qsOrg_ftg);

            if ("NBD".Equals(WebFunc.qsPlan_eff))
                _oMobileRetentionOrder.SetPlan_eff("Next Bill Date");
            else
                _oMobileRetentionOrder.SetPlan_eff(null);

            if (RWLFramework.CurrentUser[this.Page].Uid != null) _oMobileRetentionOrder.SetCid(RWLFramework.CurrentUser[this.Page].Uid.ToString());

            if ("Y".Equals(WebFunc.qsSpecial_approval))
                _oMobileRetentionOrder.SetSpecial_approval("Y");
            else
                _oMobileRetentionOrder.SetSpecial_approval("N");

            if ("".Equals(WebFunc.qsExt_place_tel))
                _oMobileRetentionOrder.SetExt_place_tel(null);
            else
                _oMobileRetentionOrder.SetExt_place_tel(WebFunc.qsExt_place_tel);

            if ("".Equals(WebFunc.qsOb_program_id))
                _oMobileRetentionOrder.SetOb_program_id(null);
            else
                _oMobileRetentionOrder.SetOb_program_id(WebFunc.qsOb_program_id);

            if ("".Equals(WebFunc.qsExisting_contract_end_month) && "".Equals(WebFunc.qsExisting_contract_end_year))
                _oMobileRetentionOrder.SetExisting_contract_end_date(null);
            else
                _oMobileRetentionOrder.SetExisting_contract_end_date(WebFunc.qsExisting_contract_end_month + "/" + WebFunc.qsExisting_contract_end_year);

            if (!"".Equals(WebFunc.qsRef_staff_no))
                _oMobileRetentionOrder.SetRef_staff_no(WebFunc.qsRef_staff_no);
            else
                _oMobileRetentionOrder.SetRef_staff_no(null);

            if (!"".Equals(WebFunc.qsRef_salesmancode))
                _oMobileRetentionOrder.SetRef_salesmancode(WebFunc.qsRef_salesmancode);
            else
                _oMobileRetentionOrder.SetRef_salesmancode(null);

            if (WebFunc.qsPcd_paid_go_wireless != null)
                _oMobileRetentionOrder.SetPcd_paid_go_wireless(WebFunc.qsPcd_paid_go_wireless);
            else
                _oMobileRetentionOrder.SetPcd_paid_go_wireless(null);


            string _sPcd_paid_go_wireless = (Request["pcd_paid_go_wireless"] != null) ? Request["pcd_paid_go_wireless"].ToString().Trim() : string.Empty;
            bool _bPcd_paid_go_wireless = (_sPcd_paid_go_wireless == "on" || _sPcd_paid_go_wireless == "1") ? true : false;
            _oMobileRetentionOrder.SetPcd_paid_go_wireless(_bPcd_paid_go_wireless);
            _oMobileRetentionOrder.SetBill_cut_num(WebFunc.qsBill_cut_num);

            DateTime _dBill_cut_date;
            string _sBill_cut_date = string.Empty;
            if (Func.IsParseDateTime(HttpContext.Current.Request["bill_cut_date"]) && !Func.RQ(HttpContext.Current.Request["bill_cut_date"]).Equals(string.Empty))
                _sBill_cut_date = HttpContext.Current.Request["bill_cut_date"].ToString();

            if (DateTime.TryParseExact(_sBill_cut_date, n_sDateTimeList, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dBill_cut_date))
                _oMobileRetentionOrder.SetBill_cut_date(_dBill_cut_date);
            else
                _oMobileRetentionOrder.SetBill_cut_date(null);


            if (!string.IsNullOrEmpty(WebFunc.qsGo_wireless_package_code))
                _oMobileRetentionOrder.SetGo_wireless_package_code(WebFunc.qsGo_wireless_package_code);
            else
                _oMobileRetentionOrder.SetGo_wireless_package_code(null);


            _oMobileRetentionOrder.SetSku(_sSku);
            _oMobileRetentionOrder.SetCooling_offer(WebFunc.qsCooling_offer);
            _oMobileRetentionOrder.SetGo_wireless(WebFunc.qsGo_wireless);
            _oMobileRetentionOrder.SetSim_mrt_no(WebFunc.qsSim_mrt_no);
            _oMobileRetentionOrder.SetPreferred_languages(WebFunc.qsPreferred_languages);
            _oMobileRetentionOrder.SetRegister_address(WebFunc.qsRegister_address);
            _oMobileRetentionOrder.SetThird_party_credit_card(WebFunc.qsThird_party_credit_card);
            _oMobileRetentionOrder.SetThird_party_hkid(WebFunc.qsThird_party_hkid + WebFunc.qsThird_party_hkid2);
            _oMobileRetentionOrder.SetThird_party_id_type(WebFunc.qsThird_party_id_type);
            _oMobileRetentionOrder.SetOrg_mrt(WebFunc.qsOrg_mrt);
            
            DateTime _dCooling_date;
            string _sCooling_date = string.Empty;
            if (Func.IsParseDateTime(HttpContext.Current.Request["cooling_date"]) && !Func.RQ(HttpContext.Current.Request["cooling_date"]).Equals(string.Empty))
                _sCooling_date = HttpContext.Current.Request["cooling_date"].ToString();

            if (DateTime.TryParseExact(_sCooling_date, n_sDateTimeList, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dCooling_date))
                _oMobileRetentionOrder.SetCooling_date(_dCooling_date);
            else
                _oMobileRetentionOrder.SetCooling_date(null);


            _oMobileRetentionOrder.SetSim_item_code(WebFunc.qsSim_item_code);
            _oMobileRetentionOrder.SetSim_item_name(WebFunc.qsSim_item_name);
            //_oMobileRetentionOrder.SetSim_item_number(WebFunc.qsSim_item_number);

            if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetEdf_no()))
            {
                if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetImei_no()) &&
                    !string.IsNullOrEmpty(_oMobileRetentionOrder.GetHs_model()))
                {
                    _oMobileRetentionOrder.imei_no = "AO";
                }
            }
            else
            {
                if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetImei_no()) &&
                    !string.IsNullOrEmpty(_oMobileRetentionOrder.GetHs_model()))
                {
                    _oMobileRetentionOrder.imei_no = "AWAIT";
                }
            }

            if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetHs_model()) && 
                string.IsNullOrEmpty(_oMobileRetentionOrder.GetEdf_no()))
                _oMobileRetentionOrder.imei_no = string.Empty;

            if (_sSku.Trim() != _sOld_sku.Trim())
            {
                _oMobileRetentionOrder.SetEdate(DateTime.Now);
            }

            _oMobileRetentionOrder.SetBill_medium(WebFunc.qsBill_medium);
            _oMobileRetentionOrder.SetIssue_type(WebFunc.qsIssue_type);
            if (WebFunc.qsIssue_type.Equals("MOBILE_LITE") ||
                WebFunc.qsIssue_type.Equals("WIN") ||
                WebFunc.qsIssue_type.Equals("UPGRADE"))
            {
                if (!WebFunc.qsBill_medium.Equals(string.Empty))
                {
                    _oMobileRetentionOrder.SetBill_medium(WebFunc.qsBill_medium);
                    /*
                    if (!WebFunc.qsBill_medium.Equals(string.Empty) && 
                        !WebFunc.qsBill_medium.Equals("0") && 
                        !WebFunc.qsBill_medium.Equals("2"))
                        _oMobileRetentionOrder.SetBill_medium_email(WebFunc.qsBill_medium_email);
                    else
                        _oMobileRetentionOrder.SetBill_medium_email(string.Empty);
                    */
                    if (WebFunc.qsBill_medium_waive == true)
                        _oMobileRetentionOrder.SetBill_medium_waive(true);
                    else
                        _oMobileRetentionOrder.SetBill_medium_waive(false);

                    if (!WebFunc.qsBill_medium.Equals("2"))
                        _oMobileRetentionOrder.SetSms_mrt(WebFunc.qsSms_mrt);
                    else
                        _oMobileRetentionOrder.SetSms_mrt(string.Empty);
                }
            }
            _oMobileRetentionOrder.SetBill_medium_email(WebFunc.qsBill_medium_email);
            if (WebFunc.qsPrepayment_waive == true)
                _oMobileRetentionOrder.SetPrepayment_waive(true);
            else
                _oMobileRetentionOrder.SetPrepayment_waive(false);

            if (WebFunc.qsMonthly_payment_method != "keep_existing_payment_method")
                _oMobileRetentionOrder.SetChange_payment_type(WebFunc.qsChange_payment_type);
            else
                _oMobileRetentionOrder.SetChange_payment_type(string.Empty);

            _oMobileRetentionOrder.SetGender(WebFunc.qsGender);

            _oMobileRetentionOrder.SetMonthly_bank_account_bank_code(WebFunc.qsMonthly_bank_account_bank_code);
            _oMobileRetentionOrder.SetMonthly_bank_account_branch_code(WebFunc.qsMonthly_bank_account_branch_code);
            _oMobileRetentionOrder.SetMonthly_bank_account_no(WebFunc.qsMonthly_bank_account_no);
            _oMobileRetentionOrder.SetMonthly_bank_account_holder(WebFunc.qsMonthly_bank_account_holder);
            _oMobileRetentionOrder.SetMonthly_bank_account_id_type(WebFunc.qsMonthly_bank_account_id_type);
            _oMobileRetentionOrder.SetMonthly_bank_account_hkid(WebFunc.qsMonthly_bank_account_hkid);
            _oMobileRetentionOrder.SetMonthly_bank_account_hkid2(WebFunc.qsMonthly_bank_account_hkid2);
            
            _oMobileRetentionOrder.SetDelivery_collection_type(WebFunc.qsDelivery_collection_type);
            _oMobileRetentionOrder.SetDelivery_exchange(WebFunc.qsDelivery_exchange);
            
            _oMobileRetentionOrder.SetDelivery_exchange_option(WebFunc.qsDelivery_exchange_option);

            _oMobileRetentionOrder.SetRedemption_notice_option(WebFunc.qsRedemption_notice_option);
            _oMobileRetentionOrder.SetS_premium1(WebFunc.qsS_premium1);
            DateTime _dDate_of_birth;
            string _sDate_of_birth = string.Empty;
            if (Func.IsParseDateTime(HttpContext.Current.Request[MobileRetentionOrder.Para.date_of_birth]) && !Func.RQ(HttpContext.Current.Request[MobileRetentionOrder.Para.date_of_birth]).Equals(string.Empty))
                _sDate_of_birth = HttpContext.Current.Request[MobileRetentionOrder.Para.date_of_birth].ToString();

            if (DateTime.TryParseExact(_sDate_of_birth, n_sDateTimeList, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dDate_of_birth))
                _oMobileRetentionOrder.SetDate_of_birth(_dDate_of_birth);
            else
                _oMobileRetentionOrder.SetDate_of_birth(null);

            if (_oMobileRetentionOrder.GetActive() == null)
                _oMobileRetentionOrder.SetActive(true);
            if (_oMobileRetentionOrder.GetCdate() == null)
                _oMobileRetentionOrder.SetCdate(_oMobileRetentionOrder.GetLog_date());

            _oDr = BusinessVasBal.GetSearch(SYSConn<MSSQLConnect>.Connect(), "distinct vas_field , multi", "active=1", null, null);
            if (_oDr != null)
            {
                while (_oDr.Read())
                {
                    string _sVas_field = Func.FR(_oDr[BusinessVas.Para.vas_field]).ToString().Trim();
                    if (Request[_sVas_field] != null)
                    {
                        string _sVas_field_val = Request[_sVas_field].ToString().Trim();
                        if (!_sVas_field_val.Equals(string.Empty) && !_sVas_field_val.ToUpper().Trim().Equals("NO"))
                        {
                            string _sMulti = Func.FR(_oDr[BusinessVas.Para.multi]).ToString().Trim();
                            bool _bMulti;
                            if (!bool.TryParse(_sMulti, out _bMulti)) { _bMulti = false; }
                            if ((true).Equals(_bMulti) && Request[_sVas_field + "1"] != null)
                            {
                                string _sVasField1 = Request[_sVas_field + "1"].ToString();
                                MobileRetentionOrderBal.SaveVas(ref _oMobileRetentionOrder, _sVas_field, _sVas_field_val, _sVasField1, true);
                            }
                            else
                                MobileRetentionOrderBal.SaveVas(ref _oMobileRetentionOrder, _sVas_field, _sVas_field_val, string.Empty, false);
                        }
                        else
                        {
                            MobileRetentionOrderBal.DeleteVas(ref _oMobileRetentionOrder, _sVas_field);
                        }
                    }
                }
                _oDr.Close();
                _oDr.Dispose();
            }


            DateTime _dUpgrade_existing_contract_sdate;
            string _sUpgrade_existing_contract_sdate = string.Empty;
            if (Func.IsParseDateTime(HttpContext.Current.Request[MobileRetentionOrder.Para.upgrade_existing_contract_sdate]) && !Func.RQ(HttpContext.Current.Request[MobileRetentionOrder.Para.upgrade_existing_contract_sdate]).Equals(string.Empty))
                _sUpgrade_existing_contract_sdate = HttpContext.Current.Request[MobileRetentionOrder.Para.upgrade_existing_contract_sdate].ToString();

            if (DateTime.TryParseExact(_sUpgrade_existing_contract_sdate, n_sDateTimeList, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dUpgrade_existing_contract_sdate))
                _oMobileRetentionOrder.SetUpgrade_existing_contract_sdate(_dUpgrade_existing_contract_sdate);
            else
                _oMobileRetentionOrder.SetUpgrade_existing_contract_sdate(null);

            DateTime _dUpgrade_existing_contract_edate;
            string _sUpgrade_existing_contract_edate = string.Empty;
            if (Func.IsParseDateTime(HttpContext.Current.Request[MobileRetentionOrder.Para.upgrade_existing_contract_edate]) && !Func.RQ(HttpContext.Current.Request[MobileRetentionOrder.Para.upgrade_existing_contract_edate]).Equals(string.Empty))
                _sUpgrade_existing_contract_edate = HttpContext.Current.Request[MobileRetentionOrder.Para.upgrade_existing_contract_edate].ToString();

            if (DateTime.TryParseExact(_sUpgrade_existing_contract_edate, n_sDateTimeList, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dUpgrade_existing_contract_edate))
                _oMobileRetentionOrder.SetUpgrade_existing_contract_edate(_dUpgrade_existing_contract_edate);
            else
                _oMobileRetentionOrder.SetUpgrade_existing_contract_edate(null);


            _oMobileRetentionOrder.SetMonthly_payment_type(WebFunc.qsMonthly_payment_type);
            _oMobileRetentionOrder.SetUpgrade_type(WebFunc.qsUpgrade_type);
            _oMobileRetentionOrder.SetUpgrade_sponsorships_amount(WebFunc.qsUpgrade_sponsorships_amount);
            _oMobileRetentionOrder.SetUpgrade_existing_customer_type(WebFunc.qsUpgrade_existing_customer_type);
            _oMobileRetentionOrder.SetUpgrade_handset_offer_rebate_schedule(WebFunc.qsUpgrade_handset_offer_rebate_schedule);

            if (_oMobileRetentionOrder.GetAction_of_rate_plan_effective() == "START ON CONTRACT EFFECTIVE DATE")
            {
                _oMobileRetentionOrder.SetPlan_eff_date(_oMobileRetentionOrder.GetCon_eff_date());
            }
            _oMobileRetentionOrder.SetUpgrade_existing_pccw_customer(WebFunc.qsUpgrade_existing_pccw_customer);
            _oMobileRetentionOrder.SetUpgrade_service_account_no(WebFunc.qsUpgrade_service_account_no);
            _oMobileRetentionOrder.SetUpgrade_service_tenure(WebFunc.qsUpgrade_service_tenure);
            _oMobileRetentionOrder.SetUpgrade_registered_mobile_no(WebFunc.qsUpgrade_registered_mobile_no);
            _oMobileRetentionOrder.SetAction_of_rate_plan_effective(WebFunc.qsAction_of_rate_plan_effective);
            _oMobileRetentionOrder.SetExisting_smart_phone_model(WebFunc.qsExisting_smart_phone_model);
            _oMobileRetentionOrder.SetExisting_smart_phone_imei(WebFunc.qsExisting_smart_phone_imei);
            _oMobileRetentionOrder.SetUpgrade_rebate_calculation(WebFunc.qsUpgrade_rebate_calculation);
            _oMobileRetentionOrder.SetM_3rd_contact_no(WebFunc.qsM_3rd_contact_no);
            _oMobileRetentionOrder.SetM_3rd_hkid(WebFunc.qsM_3rd_hkid);
            _oMobileRetentionOrder.SetM_3rd_hkid2(WebFunc.qsM_3rd_hkid2);
            _oMobileRetentionOrder.SetM_3rd_id_type(WebFunc.qsM_3rd_id_type);

            _oMobileRetentionOrder.SetS_premium3(WebFunc.qsS_premium3);
            _oMobileRetentionOrder.SetS_premium4(WebFunc.qsS_premium4);

            if (WebFunc.qsCn_mrt_no != null)
            {
                _oMobileRetentionOrder.SetCn_mrt_no(WebFunc.qsCn_mrt_no);
                _oMobileRetentionOrder.SetPool(WebFunc.qsPool);
                
            }
            _oMobileRetentionOrder.SetCard_ref_no(WebFunc.qsCard_ref_no);
            _oMobileRetentionOrder.SetFtg_tenure(WebFunc.qsFtg_tenure);
            _oMobileRetentionOrder.SetFirst_month_fee(WebFunc.qsFirst_month_fee);
            _oMobileRetentionOrder.SetFirst_month_license_fee(WebFunc.qsFirst_month_license_fee);
            _oMobileRetentionOrder.SetSpecial_handling_dummy_code(WebFunc.qsSpecial_handling_dummy_code);
			_oMobileRetentionOrder.SetAccessory_waive(WebFunc.qsAccessory_waive);

            CheckMobileOrderBeforeSave(_oMobileRetentionOrder);

            #endregion

            MobileOrderAddress _oRegisteredAddress = new MobileOrderAddress(SYSConn<MSSQLConnect>.Connect(), (int)_oMobileRetentionOrder.GetOrder_id(), "REGISTERED_ADDRESS");
            MobileOrderAddress _oBillingAddress = new MobileOrderAddress(SYSConn<MSSQLConnect>.Connect(), (int)_oMobileRetentionOrder.GetOrder_id(), "BILLING_ADDRESS");
            MobileOrderMNPDetail _oMobileOrderMNPDetail = new MobileOrderMNPDetail();
            MobileOrderThreeParty _oMobileOrderThreeParty = new MobileOrderThreeParty();
           
            long? _lRegisteredAddress_id = null;
            long? _lBillingAddress_id = null;
            long? _lMnp_id = null;
            long? _lTpy_id = null;


            MobileOrderMNPDetailEntity[] _oMobileOrderMNPDetailArr = MobileOrderMNPDetailRepository.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), 0, "order_id='" + ((int)_oMobileRetentionOrder.GetOrder_id()).ToString() + "'", null, null);
            if (_oMobileOrderMNPDetailArr != null)
            {
                if (_oMobileOrderMNPDetailArr.Length > 0)
                {
                    _oMobileOrderMNPDetail = (MobileOrderMNPDetail)_oMobileOrderMNPDetailArr[0];
                }
            }
            MobileOrderThreePartyEntity[] _oMobileOrderThreePartyArr = MobileOrderThreePartyRepository.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), 0, "order_id='" + ((int)_oMobileRetentionOrder.GetOrder_id()).ToString() + "'", null, null);
            if (_oMobileOrderThreePartyArr != null)
            {
                if (_oMobileOrderThreePartyArr.Length > 0)
                {
                    _oMobileOrderThreeParty = (MobileOrderThreeParty)_oMobileOrderThreePartyArr[0];
                }
            }

            if (_oRegisteredAddress.GetAddress_id() == null)
            {
                _oRegisteredAddress=GetRegisteredAddress(ref _oRegisteredAddress,(int)_oMobileRetentionOrder.GetOrder_id());
                _lRegisteredAddress_id=MobileOrderAddressBal.InsertReturnLastID_SP(SYSConn<MSSQLConnect>.Connect(), _oRegisteredAddress);
                _oRegisteredAddress.SetAddress_id(_lRegisteredAddress_id);
            }

            if (_oBillingAddress.GetAddress_id() == null)
            {
                _oBillingAddress = GetBillingAddress(ref _oBillingAddress, (int)_oMobileRetentionOrder.GetOrder_id());
                _lBillingAddress_id = MobileOrderAddressBal.InsertReturnLastID_SP(SYSConn<MSSQLConnect>.Connect(), _oBillingAddress);
                _oBillingAddress.SetAddress_id(_lBillingAddress_id);
            }

            if (_oMobileOrderMNPDetail.GetMnp_id() == null)
            {
                _oMobileOrderMNPDetail = GetMobileOrderMNPDetail(ref _oMobileOrderMNPDetail, (int)_oMobileRetentionOrder.GetOrder_id());
                _lMnp_id = MobileOrderMNPDetailBal.InsertReturnLastID_SP(SYSConn<MSSQLConnect>.Connect(), _oMobileOrderMNPDetail);
                _oMobileOrderMNPDetail.SetMnp_id(_lMnp_id);
            }

            if (_oMobileOrderThreeParty.GetTpy_id() == null)
            {
                _oMobileOrderThreeParty = GetReceiveSIMBy3rdParty(ref _oMobileOrderThreeParty, (int)_oMobileRetentionOrder.GetOrder_id());
                _lTpy_id = MobileOrderThreePartyBal.InsertReturnLastID_SP(SYSConn<MSSQLConnect>.Connect(), _oMobileOrderThreeParty);
                _oMobileOrderThreeParty.SetTpy_id(_lTpy_id);
            }

            using (ISession<MSSQLConnect> _oSession = (new SessionFactory<MSSQLConnect>()).OpenSession())
            using (ITransaction _oTransaction = _oSession.BeginTransaction())
            {
                if (_oMobileRetentionOrder.GetOrder_id() != null)
                {
                    bool _bRegisteredAddress = false;
                    bool _bBillingAddress = false;
                    bool _bMobileOrderMNPDetail = false;
                    bool _bMobileOrderThreeParty = false;
                    bool _bOrderSave = false;


                    
                    _lRegisteredAddress_id = _oRegisteredAddress.GetAddress_id();
                    _lBillingAddress_id = _oBillingAddress.GetAddress_id();

                    GetRegisteredAddress(ref _oRegisteredAddress,(int)_oMobileRetentionOrder.GetOrder_id());
                    GetBillingAddress(ref _oBillingAddress, (int)_oMobileRetentionOrder.GetOrder_id());
                    GetMobileOrderMNPDetail(ref _oMobileOrderMNPDetail,(int)_oMobileRetentionOrder.GetOrder_id());
                    GetReceiveSIMBy3rdParty(ref _oMobileOrderThreeParty,(int)_oMobileRetentionOrder.GetOrder_id());

                    _oRegisteredAddress.SetAddress_id(_lRegisteredAddress_id);
                    _oRegisteredAddress.SetOrder_id(_oMobileRetentionOrder.GetOrder_id());

                    if (_oRegisteredAddress.GetAddress_id() != null)
                        _bRegisteredAddress = _oSession.Update(_oRegisteredAddress);
                    else
                        _bRegisteredAddress = true;
                    
                    _oBillingAddress.SetAddress_id(_lBillingAddress_id);
                    _oBillingAddress.SetOrder_id(_oMobileRetentionOrder.GetOrder_id());

                    if (_oBillingAddress.GetAddress_id() != null)
                        _bBillingAddress = _oSession.Update(_oBillingAddress);
                    else
                        _bBillingAddress = true;
                    

                    if (_oMobileOrderMNPDetail.GetMnp_id() != null)
                        _bMobileOrderMNPDetail = _oSession.Update(_oMobileOrderMNPDetail);
                    else
                        _bMobileOrderMNPDetail = true;

                    if (_oMobileOrderThreeParty.GetTpy_id() != null)
                        _bMobileOrderThreeParty = _oSession.Update(_oMobileOrderThreeParty);
                    else
                        _bMobileOrderThreeParty = true;

                    _bOrderSave=_oSession.Update(_oMobileRetentionOrder);

                    if (_bRegisteredAddress && 
                        _bBillingAddress && 
                        _bMobileOrderMNPDetail && 
                        _bMobileOrderThreeParty)
                        _oTransaction.Commit();
                    else
                        _oTransaction.Rollback();
                }
            }
            if (_oMobileRetentionOrder.GetCn_mrt_no() != null)
            {
                MobileNumberProfileEntity _oMobileNumberProfileEntity = GetMobileNumberProfile(((int)_oMobileRetentionOrder.GetCn_mrt_no()).ToString());
                _oMobileNumberProfileEntity.SetOrder_id((int)_oMobileRetentionOrder.GetOrder_id());
                _oMobileNumberProfileEntity.SetStatus("USED");
                _oMobileNumberProfileEntity.Save();
            }


            if (_oMobileRetentionOrder.GetMrt_no() != null)
                x_sMobileNumber = ((int)_oMobileRetentionOrder.GetMrt_no()).ToString();
            /*========save sim mrt no================*/
  
                MobileGoWirelessDetailEntity[] _oMobileGoWirelessDetails = MobileGoWirelessDetailRepository.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), "mrt_no='" + WebFunc.qsSim_mrt_no + "'", null, null);
                if (_oMobileGoWirelessDetails != null)
                {
                    for (int i = 0; i < _oMobileGoWirelessDetails.Length; i++)
                        _oMobileGoWirelessDetails[i].SetOrder_id(int.Parse(Func.IDSubtract100000(WebFunc.qsOrder_id)));
                }

            /*========end of saving sim mrt no==========*/

            /*================= Send Fallout replied report to PY Operation(CS Admin) ==================*/
            string _sQuery11 = "SELECT top 1 * FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) WHERE order_id='" + Func.RQ(Func.IDSubtract100000(WebFunc.qsOrder_id)) + "'";

            _oDr.Close();
            _oDr.Dispose();
            _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery11);
            if (_oDr.Read())
            {
                string _sQuery12 = "SELECT * FROM " + Configurator.MSSQLTablePrefix + "MobileOrderReport with (nolock) WHERE order_id='" + Func.RQ(Func.IDSubtract100000(WebFunc.qsOrder_id)) + "' AND order_status='FALLOUT' AND active=1";
                SqlDataReader _oDr4 = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT * FROM " + Configurator.MSSQLTablePrefix + "MobileOrderReport with (nolock) WHERE order_id='" + Func.RQ(Func.IDSubtract100000(WebFunc.qsOrder_id)) + "' AND order_status='FALLOUT' AND active=1");
                if (_oDr4.Read())
                {
                    /*====== if entered fallout replied -> send report ======*/
                    if (WebFunc.qsFo_reply != string.Empty)
                    {
                        string _sQuery13 = "INSERT into " + Configurator.MSSQLTablePrefix + "MobileOrderReportHistory(rec_no,order_id,email_date,report_type,order_status,fallout_reason,fallout_reply,fallout_remark,retrieve_sn,retrieve_date,active,cid,cdate,did,ddate,sent_again ) ";
                        _sQuery13 += " SELECT mid,order_id,email_date,report_type,order_status,fallout_reason,fallout_reply,fallout_remark,retrieve_sn,retrieve_date,active,cid,cdate,'" + RWLFramework.CurrentUser[this.Page].Uid + "',getdate(),sent_again  FROM " + Configurator.MSSQLTablePrefix + "MobileOrderReport ";
                        _sQuery13 += " WHERE order_id='" + Func.RQ(Func.IDSubtract100000(WebFunc.qsOrder_id)) + "' AND order_status='FALLOUT' AND active=1";
                        SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_sQuery13);
                        SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery("UPDATE " + Configurator.MSSQLTablePrefix + "MobileOrderReport SET order_status='FALLOUT REPLIED', retrieve_sn=null, retrieve_date=null, fallout_reply='" + Func.RQ(WebFunc.qsFo_reply).Replace("'", "''") + "',cdate=getdate(),cid='" + RWLFramework.CurrentUser[this.Page].Uid + "' WHERE order_id='" + Func.RQ(Func.IDSubtract100000(WebFunc.qsOrder_id)) + "' AND order_status='FALLOUT' AND active=1");
                    }
                    else
                    {
                        /*====== Compare MobileRetentionPreviousOrder & MobileRetentionOrder ======*/
                        SqlDataReader _oDr2 = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT top 1 * FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionPreviousOrder with (nolock) WHERE rec_no='" + Func.RQ(Func.IDSubtract100000(WebFunc.qsOrder_id)) + "' order by ddate desc");
                        int _iFallout_repty = 0;
                        if (_oDr2.Read())
                        {
                            for (int i = 0; i < _oDr.FieldCount; i++)
                            {
                                if (_oDr.GetName(i) != "cid" && _oDr.GetName(i) != "cdate" && _oDr.GetName(i) != "ddate" && _oDr.GetName(i) != "did" && _oDr.GetName(i) != "order_id")
                                {
                                    if (_oDr[_oDr.GetName(i)].ToString() != _oDr2[_oDr.GetName(i)].ToString())
                                        _iFallout_repty = 1;
                                }
                            }
                        }
                        _oDr2.Close();
                        _oDr2.Dispose();
                        /*====== if field(s) changed -> send report ======*/
                        if (_iFallout_repty == 1)
                        {
                            string _sQuer12 = "INSERT into " + Configurator.MSSQLTablePrefix + "MobileOrderReportHistory(rec_no,order_id,email_date,report_type,order_status,fallout_reason,fallout_reply,fallout_remark,retrieve_sn,retrieve_date,active,cid,cdate,did,ddate,sent_again ) ";
                            _sQuer12 += " SELECT mid,order_id,email_date,report_type,order_status,fallout_reason,fallout_reply,fallout_remark,retrieve_sn,retrieve_date,active,cid,cdate,'" + RWLFramework.CurrentUser[this.Page].Uid + "',getdate(),sent_again  FROM " + Configurator.MSSQLTablePrefix + "MobileOrderReport ";
                            _sQuer12 += " WHERE order_id='" + Func.RQ(Func.IDSubtract100000(WebFunc.qsOrder_id)) + "' AND order_status='FALLOUT' AND active=1";
                            SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_sQuer12);
                            SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery("UPDATE " + Configurator.MSSQLTablePrefix + "MobileOrderReport SET order_status='FALLOUT REPLIED', retrieve_sn=null, retrieve_date=null, fallout_reply='" + Func.RQ(WebFunc.qsFo_reply).Replace("'", "''") + "',cdate=getdate(),cid='" + RWLFramework.CurrentUser[this.Page].Uid + "' WHERE order_id='" + Func.RQ(Func.IDSubtract100000(WebFunc.qsOrder_id)) + "' AND order_status='FALLOUT' AND active=1");
                        }
                    }
                }
                _oDr4.Close();
                _oDr4.Dispose();
            }
            _oDr.Close();
            _oDr.Dispose();
            /*================= End of Send Fallout replied report to PY Operation(CS Admin) ==================*/
            incorrect.Visible = false;
        }
        else
        {
            incorrect.Visible = true;
        }
        _oDr3.Close();
        _oDr3.Dispose();

        

        RWLviewrow1.SetOrderid((int)_oMobileRetentionOrder.GetOrder_id());
        RWLviewrow1.LoadOrder();
        RWLviewrow1.Visible = true;

        if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetEdf_no()) &&
           ( _oMobileRetentionOrder.issue_type == "MOBILE_LITE" || 
            _oMobileRetentionOrder.issue_type == "UPGRADE"))
        {
            _bNewEDFOrder = true;

        }
    }


    protected MobileOrderAddress GetRegisteredAddress(ref MobileOrderAddress x_oMobileOrderAddress, int x_iOrder_id)
    {
        x_oMobileOrderAddress.address_type = "REGISTERED_ADDRESS";
        x_oMobileOrderAddress.d_blk = MobileOrderAddressUserControl.RequestID("RegisteredAddressControl").qsD_blk.Trim();
        x_oMobileOrderAddress.d_build = MobileOrderAddressUserControl.RequestID("RegisteredAddressControl").qsD_build.Trim();
        x_oMobileOrderAddress.d_floor = MobileOrderAddressUserControl.RequestID("RegisteredAddressControl").qsD_floor.Trim();
        x_oMobileOrderAddress.d_region = MobileOrderAddressUserControl.RequestID("RegisteredAddressControl").qsD_region.Trim();
        x_oMobileOrderAddress.d_room = MobileOrderAddressUserControl.RequestID("RegisteredAddressControl").qsD_room.Trim();
        x_oMobileOrderAddress.d_street = MobileOrderAddressUserControl.RequestID("RegisteredAddressControl").qsD_street.Trim();
        x_oMobileOrderAddress.d_type = MobileOrderAddressUserControl.RequestID("RegisteredAddressControl").qsD_type.Trim();
        x_oMobileOrderAddress.d_district = MobileOrderAddressUserControl.RequestID("RegisteredAddressControl").qsD_district.Trim();
        x_oMobileOrderAddress.order_id = x_iOrder_id;

        return x_oMobileOrderAddress;
    }

    protected MobileOrderAddress GetBillingAddress(ref MobileOrderAddress x_oMobileOrderAddress, int x_iOrder_id)
    {
        x_oMobileOrderAddress.address_type = "BILLING_ADDRESS";
        x_oMobileOrderAddress.d_blk = MobileOrderAddressUserControl.RequestID("BillingAddressControl").qsD_blk.Trim();
        x_oMobileOrderAddress.d_build = MobileOrderAddressUserControl.RequestID("BillingAddressControl").qsD_build.Trim();
        x_oMobileOrderAddress.d_floor = MobileOrderAddressUserControl.RequestID("BillingAddressControl").qsD_floor.Trim();
        x_oMobileOrderAddress.d_region = MobileOrderAddressUserControl.RequestID("BillingAddressControl").qsD_region.Trim();
        x_oMobileOrderAddress.d_room = MobileOrderAddressUserControl.RequestID("BillingAddressControl").qsD_room.Trim();
        x_oMobileOrderAddress.d_street = MobileOrderAddressUserControl.RequestID("BillingAddressControl").qsD_street.Trim();
        x_oMobileOrderAddress.d_type = MobileOrderAddressUserControl.RequestID("BillingAddressControl").qsD_type.Trim();
        x_oMobileOrderAddress.d_district = MobileOrderAddressUserControl.RequestID("BillingAddressControl").qsD_district.Trim();
        x_oMobileOrderAddress.order_id = x_iOrder_id;

        return x_oMobileOrderAddress;
    }

    protected MobileOrderMNPDetail GetMobileOrderMNPDetail(ref MobileOrderMNPDetail x_oMobileOrderMNPDetail,int x_iOrder_id)
    {

        x_oMobileOrderMNPDetail.company_name = MobileOrderMNPDetailUserControl.RequestID("MobileOrderMNPDetailControl").qsCompany_name.Trim();
        x_oMobileOrderMNPDetail.hkid = MobileOrderMNPDetailUserControl.RequestID("MobileOrderMNPDetailControl").qsHkid + MobileOrderMNPDetailUserControl.RequestID("MobileOrderMNPDetailControl").qsHkid2.Trim();
        x_oMobileOrderMNPDetail.registered_name = MobileOrderMNPDetailUserControl.RequestID("MobileOrderMNPDetailControl").qsRegistered_name.Trim();
        string _sService_activation_date = Func.RQ(HttpContext.Current.Request[MobileOrderMNPDetailUserControl.RequestID("MobileOrderMNPDetailControl").UserControlRequestIDName + "service_activation_date"]);
        DateTime _dService_activation_date;
        if (DateTime.TryParseExact(_sService_activation_date, n_sDateTimeList, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dService_activation_date))
            x_oMobileOrderMNPDetail.SetService_activation_date(_dService_activation_date);
        else
            x_oMobileOrderMNPDetail.SetService_activation_date(null);

        x_oMobileOrderMNPDetail.service_activation_time = MobileOrderMNPDetailUserControl.RequestID("MobileOrderMNPDetailControl").qsService_activation_time.Trim();
        x_oMobileOrderMNPDetail.ticker_number = MobileOrderMNPDetailUserControl.RequestID("MobileOrderMNPDetailControl").qsTicker_number.Trim();
        x_oMobileOrderMNPDetail.transfer_to_3g = MobileOrderMNPDetailUserControl.RequestID("MobileOrderMNPDetailControl").qsTransfer_to_3g;
        if (x_oMobileOrderMNPDetail.transfer_to_3g == true)
        {
            x_oMobileOrderMNPDetail.transfer_idd_deposit = MobileOrderMNPDetailUserControl.RequestID("MobileOrderMNPDetailControl").qsTransfer_idd_deposit;
            x_oMobileOrderMNPDetail.transfer_idd_roaming_deposit = MobileOrderMNPDetailUserControl.RequestID("MobileOrderMNPDetailControl").qsTransfer_idd_roaming_deposit;
            x_oMobileOrderMNPDetail.transfer_no_add_proof_deposit = MobileOrderMNPDetailUserControl.RequestID("MobileOrderMNPDetailControl").qsTransfer_no_add_proof_deposit;
            x_oMobileOrderMNPDetail.transfer_no_hk_id_holder_deposit = MobileOrderMNPDetailUserControl.RequestID("MobileOrderMNPDetailControl").qsTransfer_no_hk_id_holder_deposit;
            x_oMobileOrderMNPDetail.transfer_others_deposit = MobileOrderMNPDetailUserControl.RequestID("MobileOrderMNPDetailControl").qsTransfer_others_deposit;
        }
        else
        {
            x_oMobileOrderMNPDetail.transfer_to_3g = false;
            x_oMobileOrderMNPDetail.transfer_idd_deposit = null;
            x_oMobileOrderMNPDetail.transfer_idd_roaming_deposit = null;
            x_oMobileOrderMNPDetail.transfer_no_add_proof_deposit = null;
            x_oMobileOrderMNPDetail.transfer_no_hk_id_holder_deposit = null;
            x_oMobileOrderMNPDetail.transfer_others_deposit = null;
        }

        x_oMobileOrderMNPDetail.id_type = MobileOrderMNPDetailUserControl.RequestID("MobileOrderMNPDetailControl").qsId_type.Trim();
        x_oMobileOrderMNPDetail.order_id = x_iOrder_id;

        return x_oMobileOrderMNPDetail;
    }

    protected MobileOrderThreeParty GetReceiveSIMBy3rdParty(ref  MobileOrderThreeParty x_oMobileOrderThreeParty, int x_iOrder_id)
    {

        x_oMobileOrderThreeParty.three_party = MobileOrderThreePartyUserControl.RequestID("MobileOrderThreePartyControl").qsThree_party;
        if (x_oMobileOrderThreeParty.three_party == true)
        {
            x_oMobileOrderThreeParty.arthurization_person = MobileOrderThreePartyUserControl.RequestID("MobileOrderThreePartyControl").qsArthurization_person.Trim();
            x_oMobileOrderThreeParty.contact_no = MobileOrderThreePartyUserControl.RequestID("MobileOrderThreePartyControl").qsContact_no.Trim();
            x_oMobileOrderThreeParty.hkid = MobileOrderThreePartyUserControl.RequestID("MobileOrderThreePartyControl").qsHkid.Trim() + MobileOrderThreePartyUserControl.RequestID("MobileOrderThreePartyControl").qsHkid2.Trim();
            x_oMobileOrderThreeParty.plural = MobileOrderThreePartyUserControl.RequestID("MobileOrderThreePartyControl").qsPlural.Trim();
            x_oMobileOrderThreeParty.type = MobileOrderThreePartyUserControl.RequestID("MobileOrderThreePartyControl").qsType.Trim();
            x_oMobileOrderThreeParty.id_type = MobileOrderThreePartyUserControl.RequestID("MobileOrderThreePartyControl").qsId_type.Trim();
        }
        else
        {
            x_oMobileOrderThreeParty.three_party = false;
            x_oMobileOrderThreeParty.arthurization_person = string.Empty;
            x_oMobileOrderThreeParty.contact_no = string.Empty;
            x_oMobileOrderThreeParty.hkid = string.Empty;
            x_oMobileOrderThreeParty.plural = string.Empty;
            x_oMobileOrderThreeParty.type = string.Empty;
            x_oMobileOrderThreeParty.id_type = string.Empty;
        }
        x_oMobileOrderThreeParty.order_id = x_iOrder_id;

        return x_oMobileOrderThreeParty;
    }




    #region IsModifyEDF
    protected void IsModifyEDF(string x_sOrder_id)
    {
        string _sRe_confirm = Func.RQ(Request["re_confirm"]);
        string _sEdf_no = string.Empty;
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("SELECT top 1 edf_no FROM MobileRetentionOrder with (nolock) WHERE order_id='" + x_sOrder_id + "'");
        _sEdf_no = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar(_oQuery.ToString());
        /*
            if (_sSku != string.Empty)
                SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("UPDATE IMEI_Stock SET STAFF_RECD='' Where Dummy2='CC RET' AND Status='STOCK'  AND STAFF_RECD!='RWLAUTO' ");
        */
        if (_sEdf_no != string.Empty)
        {
            if (incorrect.Visible != true)
            {
                Session["ModifyOrder"] = string.Empty;
                Session["ModifyOrderWeblogProcess"] = "ModifyOrderWeblogProcess";
                if(_sRe_confirm!="TRUE")
                    Response.Redirect("ModifyEDF.aspx?order_id=" + x_sOrder_id);
                else
                    Response.Redirect("ModifyEDF.aspx?re_confirm=TRUE&order_id=" + x_sOrder_id);
            }
        }
        else if (_sOld_sku != _sSku || _bInsertNewHS || _sOld_sim_code != _sSim_code || _bNewEDFOrder==true)
        {
            if (incorrect.Visible != true)
            {
                Session["ModifyOrder"] = string.Empty;
                Session["IssueOrderWeblogProcess"] = "IssueOrderWeblogProcess";
                if (_sRe_confirm != "TRUE")
                    Response.Redirect("MigrateToEDF.aspx?order_id=" + x_sOrder_id);
                else
                    Response.Redirect("MigrateToEDF.aspx?re_confirm=TRUE&order_id=" + x_sOrder_id);
            }
        }
        else
        {
            MobileOrderLockControl.Instance().RemoveMobileOrderLock(x_sMobileNumber);
            if (WebFunc.qsOrder_id != null)
            {
                int _iRecordID = (int)WebFunc.qsOrder_id;
                AssignIMEIControl(_iRecordID - 100000, RWLFramework.CurrentUser[this.Page].Uid);
            }
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


    #endregion


    public MobileNumberProfileEntity GetMobileNumberProfile(string x_sMrt_no)
    {
        MobileNumberProfileEntity[] _oMobileNumberProfileArr = MobileNumberProfileRepository.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), 1, "MRT_no='" + x_sMrt_no + "'", null, null);
        if (_oMobileNumberProfileArr != null)
        {
            if (_oMobileNumberProfileArr.Length > 0)
            {
                return _oMobileNumberProfileArr[0];
            }
        }

        return new MobileNumberProfileEntity();
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
