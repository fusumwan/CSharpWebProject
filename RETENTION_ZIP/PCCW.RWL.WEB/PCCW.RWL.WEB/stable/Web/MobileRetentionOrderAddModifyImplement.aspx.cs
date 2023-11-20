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
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Odbc;
using System.Globalization;
using System.Diagnostics;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using PCCW.RWL.WEB.UI.Order;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

using System.Reflection;


public partial class Web_MobileRetentionOrderAddModifyImplement : NEURON.WEB.UI.BasePage
{
    #region Logger Setup
    string _sRedirectUrl = string.Empty;
    EDFStatusProfile _oEDFStatusProfile = new EDFStatusProfile();

    #endregion
    string _sSku = string.Empty;
    string _sHs_model = string.Empty;
    string _sOld_sku = string.Empty;
    string _sOld_imei_no = string.Empty;

    // SIM Card
    string _sSim_item_name = string.Empty;
    string _sSim_item_code = string.Empty;
    string _sSim_item_number = string.Empty;
    string _sOld_sim_item_name = string.Empty;
    string _sOld_sim_item_code = string.Empty;
    string _sOld_sim_item_number = string.Empty;

    string _sEdf_no = string.Empty;
    string _sNew_Order_id = string.Empty;
    string _sOrder_id = string.Empty;
    string _sOld_order_id = string.Empty;
    SpecialCustomerEntity n_oSpecialCustomer = GetSpecialCustomer();
    DateTime n_dCdate = DateTime.Now;
    string[] n_sDateTimeList = { "dd/MM/yyyy HH:mm", "d/MM/yyyy HH:mm", "dd/M/yyyy HH:mm", "dd/MM/yyyy HH:mm:ss", "d/MM/yyyy HH:mm:ss", "dd/M/yyyy HH:mm:ss", "dd/MM/yyyy", "d/MM/yyyy", "dd/M/yyyy", "d/M/yyyy" };
    protected void Page_Load(object sender, EventArgs e)
    {
        
        CheckRefeshOrderPage();
        string _sHkid = WebFunc.qsHkid.Replace("'", "''") + WebFunc.qsHkid2.Replace("'", "''");
        _sOrder_id = (WebFunc.qsOrder_id != null) ? (Convert.ToInt32(WebFunc.qsOrder_id)).ToString() : "";
        _sOld_order_id = _sOrder_id;

        bool HaveIPhone = false;
        bool HaveIPad = false;

        #region Check IPhone 3 Concierge Service
        if (WebFunc.qsSku == "2421051" ||
            WebFunc.qsSku == "2420731" ||
            WebFunc.qsSku == "2420911" ||
            WebFunc.qsSku == "2420961" ||
            WebFunc.qsSku == "2420971" ||
            WebFunc.qsSku == "2420981"
            )
        {
            bool _bSpecialCustomer = false;
            if (n_oSpecialCustomer != null)
            {
                if (n_oSpecialCustomer.GetCount() != null)
                {
                    int _iCount = (int)n_oSpecialCustomer.GetCount();
                    if (_iCount > 0)
                    {
                        _bSpecialCustomer = true;
                    }
                }
            }
            if (FromRegisterControler.CheckAllSystemIPhoneOrderIPhone3(_sHkid, _sOrder_id) && _bSpecialCustomer == false)
            {
                HaveIPhone = true;
            }
        }
        #endregion

        
        #region Check IPhone 4 Concierge Service

        if (WebFunc.qsSku == "2421561" ||
           WebFunc.qsSku == "2421571"
           )
        {
            bool _bSpecialCustomer = false;
            if (n_oSpecialCustomer != null)
            {
                if (n_oSpecialCustomer.GetCount() != null)
                {
                    int _iCount = (int)n_oSpecialCustomer.GetCount();
                    if (_iCount > 0)
                    {
                        _bSpecialCustomer = true;
                    }
                }
            }
            if (FromRegisterControler.CheckAllSystemIPhoneOrderIPhone4(_sHkid, _sOrder_id) && _bSpecialCustomer == false)
            {
                HaveIPhone = true;

            }
        }
        #endregion

        #region Check IPad Concierge Service
        if (WebFunc.qsSku == "2421101" ||
            WebFunc.qsSku == "2421111" ||
            WebFunc.qsSku == "2421121"
            )
        {
            bool _bSpecialCustomer = false;
            if (n_oSpecialCustomer != null)
            {
                if (n_oSpecialCustomer.GetCount() != null)
                {
                    int _iCount = (int)n_oSpecialCustomer.GetCount();
                    if (_iCount > 0)
                    {
                        _bSpecialCustomer = true;
                    }
                }
            }
            if (FromRegisterControler.CheckAllSystemIPhoneOrderIPad(_sHkid, _sOrder_id) && _bSpecialCustomer == false)
            {
                HaveIPad = true;
                
            }
        }
        #endregion

        if (HaveIPhone && HaveIPad)
        {
            Response.Redirect("MobileOrderLockMessage.aspx?OrderLockMsg=Customer has already used IPhone Concierge Service!");
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
        RWLFramework.InitModel();

        if (!IsPostBack) InitFrame();

        /*
        string _sRemarkError = "ADD NEW ORDER ERROR";
        _oEDFStatusProfile.ToAddNewOrderError(WebFunc.qsOrder_id, RWLFramework.CurrentUser[this.Page].Uid, _sRemarkError.ToUpper().ToString(), exp.ToString());
        Logger.ErrorFormat("Insert Order Error:{0}", exp.ToString());
        RunJavascriptFunc("alert('Server busy!');");
        Response.Redirect("MobileRetentionMain.aspx");
        */

        IsModifyEDF(_sNew_Order_id, string.Empty, _sOld_sku, _sSku);
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


    protected static SpecialCustomerEntity GetSpecialCustomer()
    {
        string _sHkid = WebFunc.qsHkid.Replace("'", "''").Trim() + WebFunc.qsHkid2.Replace("'", "''").Trim();
        if (string.IsNullOrEmpty(_sHkid)) return null;
        SpecialCustomerEntity[] _oSpecialCustomerArr = SpecialCustomerBal.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), " hkid='" + _sHkid + "' ", null, null);
        if (_oSpecialCustomerArr != null)
        {
            if (_oSpecialCustomerArr.Length > 0)
                return _oSpecialCustomerArr[0];
        }
        return null;
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
        {
            Response.Redirect("MobileOrderLockMessage.aspx?OrderLockMsg=Cannot refesh the page!"); 
        }
    }

    #region Set HtmlControl Style By Javascript
    public void SetHtmlControlStyle(string x_sID, HtmlTextWriterStyle x_oStyle, string x_sValue, bool x_bStr)
    {
        Random ran = new Random();
        string _sScript = string.Empty;
        if (x_bStr)
            _sScript = string.Format("<script>if(document.getElementById('{0}')!=undefined) document.getElementById('{1}').style.{2}='{3}'; </script>", x_sID, x_sID, x_oStyle.ToString().ToLower(), x_sValue);
        else
            _sScript = string.Format("<script>if(document.getElementById('{0}')!=undefined) document.getElementById('{1}').style.{2}={3}; </script>", x_sID, x_sID, x_oStyle.ToString().ToLower(), x_sValue);
        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), _sScript, false);
    }
    #endregion

    #region Set HtmlContorl Attributes By Javascript
    public void SetHtmlControlAtt(string x_sID, HtmlTextWriterAttribute x_oAtt, string x_sValue, bool x_bStr)
    {
        string _sScript = string.Empty;
        if (x_oAtt == HtmlTextWriterAttribute.Class)
        {
            _sScript = string.Format("<script>if(document.getElementById('{0}')!=undefined) document.getElementById('{1}').className='{2}';</script>", x_sID, x_sID, x_sValue);
        }
        else
        {
            if (x_bStr)
                _sScript = string.Format("<script>if(document.getElementById('{0}')!=undefined) document.getElementById('{1}').{2}='{3}';</script>", x_sID, x_sID, x_oAtt.ToString().ToLower(), x_sValue);
            else
                _sScript = string.Format("<script>if(document.getElementById('{0}')!=undefined) document.getElementById('{1}').{2}={3};</script>", x_sID, x_sID, x_oAtt.ToString().ToLower(), x_sValue);
        }
        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), _sScript, false);
    }
    #endregion

    #region Set HtmlContorl Value By Javascript
    public void SetHtmlControlValue(string x_sID, string x_sValue, bool x_bStr)
    {
        string _sScript = string.Empty;
        if (x_bStr)
            _sScript = string.Format("<script>if(document.getElementById('{0}')!=undefined) document.getElementById('{1}').value='{2}';</script>", x_sID, x_sID, x_sValue);
        else
            _sScript = string.Format("<script>if(document.getElementById('{0}')!=undefined) document.getElementById('{1}').value={2};</script>", x_sID, x_sID, x_sValue);
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

    #region RegionName
    protected string RegionName(string x_sArea)
    {
        string _sAreaName = string.Empty;
        switch (x_sArea)
        {
            case "0":
                _sAreaName = "HK";
                break;
            case "1":
                _sAreaName = "KLN";
                break;
            case "2":
                _sAreaName = "NT";
                break;
            case "3":
                _sAreaName = "LT";
                break;
            default:
                _sAreaName = "HK";
                break;
        }
        return _sAreaName;
    }
    #endregion

    public void InitFrame()
    {
        string _sToday = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        string _sToday1 = DateTime.Now.ToString("yyyyMMdd");
        string _sToday2 = DateTime.Now.ToString("yyyy-MM-dd");
        

        int _iOld_order_id = -1;
        _sSku = WebFunc.qsSku.Trim();
        if (_sSku == "0")
            _sSku = string.Empty;
        _sHs_model = WebFunc.qsHs_model;
        _sOld_sku = string.Empty;
        _sOld_imei_no = string.Empty;

        // SIM Card
        //_sSim_item_name = WebFunc.qsSim_item_name;
        _sSim_item_code = WebFunc.qsSim_item_code;
        //_sSim_item_number = WebFunc.qsSim_item_number;
        //_sOld_sim_item_name = string.Empty;
        _sOld_sim_item_code = string.Empty;
        _sOld_sim_item_number = string.Empty;

        _sEdf_no = string.Empty;
        MobileRetentionOrderBal.BackUpOrder(((int)WebFunc.qsOrder_id), RWLFramework.CurrentUser[this.Page].Uid);
        string _sQuery = "SELECT TOP 1 sku,imei_no,edf_no,sim_item_code,sim_item_number FROM MobileRetentionOrder WITH (nolock) WHERE order_id='" + _sOld_order_id + "'";
        SqlDataReader _oOldDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
        if (_oOldDr.Read())
        {
            _sOld_sku = Func.FR(_oOldDr[MobileRetentionOrder.Para.sku]);
            _sOld_imei_no = Func.FR(_oOldDr[MobileRetentionOrder.Para.imei_no]);
            _sEdf_no = Func.FR(_oOldDr[MobileRetentionOrder.Para.edf_no]);
            _sOld_sim_item_code = Func.FR(_oOldDr[MobileRetentionOrder.Para.sim_item_code]);
            //_sOld_sim_item_number = Func.FR(_oOldDr[MobileRetentionOrder.Para.sim_item_number]);
        }
        _oOldDr.Close();
        _oOldDr.Dispose();

        MobileRetentionOrder _oMobileRetentionOrder = (MobileRetentionOrder)MobileRetentionOrderRepository.CreateEntityInstanceObject();
        RWLFramework.Control<FromRegisterControler>().SetAction_required(WebFunc.qsAction_required);
        RWLFramework.Control<FromRegisterControler>().SetAction_required2(WebFunc.qsAction_required2);

        BusinessTradeRepositoryBase _oBusinessTradeRepositoryBase = new BusinessTradeRepositoryBase(GetDB());
        IQueryable<BusinessTradeEntity> _oBusinessTradeList = from _sRwlTradeList in _oBusinessTradeRepositoryBase.BusinessTrades
                                                              where
                                                                  _sRwlTradeList.active == true && _sRwlTradeList.program == WebFunc.qsProgram.Trim() &&
                                                                  _sRwlTradeList.con_per == WebFunc.qsCon_per.Trim() && _sRwlTradeList.rate_plan == WebFunc.qsRate_plan.Trim() &&
                                                                  _sRwlTradeList.trade_field == WebFunc.qsTrade_field.Trim() && _sRwlTradeList.bundle_name == WebFunc.qsBundle_name.Trim()
                                                              select _sRwlTradeList;

        if (_oBusinessTradeList.Count<BusinessTradeEntity>() > 0 || "suspend".Equals(WebFunc.qsAction_required) || "opt_out".Equals(WebFunc.qsAction_required2))
        {
            //Logger.Debug("Success to get BusinessTradeEntity Object");
            //Logger.Debug("Find out the bank name");
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT bank_name FROM " + Configurator.MSSQLTablePrefix + "BankCode WHERE active=1 and bank_code='" + WebFunc.qsBank_code.Trim() + "'");
            if (_oDr.Read())
            {
                _oMobileRetentionOrder.SetBank_name(Func.FR(_oDr[BankCode.Para.bank_name]).ToString());
            }
            _oDr.Close();
            _oDr.Dispose();
            
            if (!WebFunc.qsHs_model.Trim().Equals(string.Empty) && !WebFunc.qsSku.Trim().Equals("0"))
                _oMobileRetentionOrder.SetSku(WebFunc.qsSku.Trim());
            else
                _oMobileRetentionOrder.SetSku(string.Empty);

            _oMobileRetentionOrder.SetHs_model(WebFunc.qsHs_model.Trim());

            if (!"".Equals(_oMobileRetentionOrder.GetHs_model()) && ("".Equals(WebFunc.qsSku.Trim()) || "0".Equals(WebFunc.qsSku.Trim())))
            {
                _oDr.Close();
                _oDr.Dispose();
                _oDr = ProductItemCodeBal.GetSearch(SYSConn<MSSQLConnect>.Connect(), "item_code", "active=1 and hs_model='" + WebFunc.qsHs_model + "'", null, null);
                if (_oDr.Read()) { _oMobileRetentionOrder.SetSku(Func.FR(_oDr[ProductItemCode.Para.item_code]).ToString()); }
                _oDr.Close();
                _oDr.Dispose();
            }

            if ("".Equals(_oMobileRetentionOrder.GetHs_model()) && !"".Equals(WebFunc.qsSku.Trim()))
            {
                _oDr.Close();
                _oDr.Dispose();
                _oDr = ProductItemCodeBal.GetSearch(SYSConn<MSSQLConnect>.Connect(), "hs_model", "active=1 and item_code='" + WebFunc.qsSku.Trim() + "'", null, null);
                if (_oDr.Read()) { _oMobileRetentionOrder.SetHs_model(Func.FR(_oDr["hs_model"]).ToString()); }
                _oDr.Close();
                _oDr.Dispose();
            }

            _oMobileRetentionOrder.SetD_address(WebFunc.qsD_address.ToUpper());
            _oMobileRetentionOrder.SetLog_date(DateTime.Now);
            _oMobileRetentionOrder.SetLanguage(WebFunc.qsLanguage);

            DateTime _dVas_eff_date;
            string _sVas_eff_date = string.Empty;
            if (Func.IsParseDateTime(HttpContext.Current.Request["vas_eff_date"]) && !Func.RQ(HttpContext.Current.Request["vas_eff_date"]).Equals(string.Empty))
                _sVas_eff_date = HttpContext.Current.Request["vas_eff_date"].ToString();

            if (DateTime.TryParseExact(_sVas_eff_date, n_sDateTimeList, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dVas_eff_date))
                _oMobileRetentionOrder.SetVas_eff_date(_dVas_eff_date);
            else
                _oMobileRetentionOrder.SetVas_eff_date(null);


            string _sNextBill = (Request["next_bill"] != null) ? Request["next_bill"].ToString().Trim() : string.Empty;
            bool _bNextBill = (_sNextBill == "on" || _sNextBill == "1") ? true : false;
            _oMobileRetentionOrder.SetNext_bill(_bNextBill);

            DateTime _dCon_eff_date;
            string _sCon_eff_date = string.Empty;
            if (Func.IsParseDateTime(HttpContext.Current.Request["con_eff_date"]) && !Func.RQ(HttpContext.Current.Request["con_eff_date"]).Equals(string.Empty))
                _sCon_eff_date = HttpContext.Current.Request["con_eff_date"].ToString();

            if (!_bNextBill && DateTime.TryParseExact(_sCon_eff_date, n_sDateTimeList, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dCon_eff_date))
                _oMobileRetentionOrder.SetCon_eff_date(_dCon_eff_date);
            else
                _oMobileRetentionOrder.SetCon_eff_date(null);

            _oMobileRetentionOrder.SetCust_type(WebFunc.qsCust_type.Trim());

            if (WebFunc.qsGiven_name.Trim() != string.Empty || WebFunc.qsFamily_name.Trim() != string.Empty)
            {
                _oMobileRetentionOrder.SetCust_name(((WebFunc.qsFamily_name.Trim() != string.Empty) ? WebFunc.qsFamily_name.Trim() + " " : string.Empty) + WebFunc.qsGiven_name.Trim());
            }
            else
                _oMobileRetentionOrder.SetCust_name(WebFunc.qsCust_name.Trim());
            _oMobileRetentionOrder.SetGiven_name(WebFunc.qsGiven_name.Trim());
            _oMobileRetentionOrder.SetFamily_name(WebFunc.qsFamily_name.Trim());

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
            _oMobileRetentionOrder.SetCdate(DateTime.Now);
            _oDr.Close();
            _oDr.Dispose();
            _oDr = null;

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

            _oMobileRetentionOrder.SetPremium(WebFunc.qsPremium);
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




            if ("Y".Equals(WebFunc.qsWaive))
                _oMobileRetentionOrder.SetWaive(true);
            else
                _oMobileRetentionOrder.SetWaive(false);


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



            _oMobileRetentionOrder.SetActive(true);
            if (RWLFramework.CurrentUser[this.Page].Uid != null) _oMobileRetentionOrder.SetCid(RWLFramework.CurrentUser[this.Page].Uid.ToString());

            if ("Y".Equals(WebFunc.qsSpecial_approval))
                _oMobileRetentionOrder.SetSpecial_approval("Y");
            else
                _oMobileRetentionOrder.SetSpecial_approval("N");


            if (int.TryParse(_sOld_order_id, out _iOld_order_id))
                _oMobileRetentionOrder.SetOld_ord_id(_iOld_order_id);

            //if (WebFunc.qsHs_model != string.Empty) { _oMobileRetentionOrder.SetImei_no(_sOld_imei_no); }
            _oMobileRetentionOrder.SetImei_no(string.Empty);
            //_oMobileRetentionOrder.SetEdf_no(_sEdf_no);
            _oMobileRetentionOrder.SetEdf_no(string.Empty);
            _oMobileRetentionOrder.SetImei_no(string.Empty);
            _oMobileRetentionOrder.SetSim_item_code(WebFunc.qsSim_item_code.Trim());
            _oMobileRetentionOrder.SetSim_item_name(WebFunc.qsSim_item_name.Trim());
            //_oMobileRetentionOrder.SetSim_item_number(WebFunc.qsSim_item_number.Trim());
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

            if (!string.IsNullOrEmpty(WebFunc.qsRef_salesmancode))
                _oMobileRetentionOrder.SetRef_salesmancode(WebFunc.qsRef_salesmancode);
            else
                _oMobileRetentionOrder.SetRef_salesmancode(null);


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

            _oMobileRetentionOrder.SetGo_wireless(WebFunc.qsGo_wireless);
            _oMobileRetentionOrder.SetSim_mrt_no(WebFunc.qsSim_mrt_no);
            _oMobileRetentionOrder.SetPreferred_languages(WebFunc.qsPreferred_languages);
            _oMobileRetentionOrder.SetRegister_address(WebFunc.qsRegister_address);
            _oMobileRetentionOrder.SetThird_party_credit_card(WebFunc.qsThird_party_credit_card);
            _oMobileRetentionOrder.SetThird_party_hkid(WebFunc.qsThird_party_hkid+WebFunc.qsThird_party_hkid2);
            _oMobileRetentionOrder.SetThird_party_id_type(WebFunc.qsThird_party_id_type);
            _oMobileRetentionOrder.SetOrg_mrt(WebFunc.qsOrg_mrt);
            _oMobileRetentionOrder.SetCooling_offer(WebFunc.qsCooling_offer);

            DateTime _dCooling_date;
            string _sCooling_date = string.Empty;
            if (Func.IsParseDateTime(HttpContext.Current.Request["cooling_date"]) && !Func.RQ(HttpContext.Current.Request["cooling_date"]).Equals(string.Empty))
                _sCooling_date = HttpContext.Current.Request["cooling_date"].ToString();

            if (DateTime.TryParseExact(_sCooling_date, n_sDateTimeList, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dCooling_date))
                _oMobileRetentionOrder.SetCooling_date(_dCooling_date);
            else
                _oMobileRetentionOrder.SetCooling_date(null);


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
            _oMobileRetentionOrder.SetDelivery_exchange_location(WebFunc.qsDelivery_exchange_location);
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

            //Save Vas
            Nullable<int> _iOrder_id = -1;
            int _iRegisteredAddress_id = -1;
            int _iBillingAddress_id = -1;
            int _iMobileOrderMNPDetail_id = -1;
            int _iMobileOrderThreeParty_id = -1;
            bool _bIssue = false;
            using (ISession<MSSQLConnect> _oSession = (new SessionFactory<MSSQLConnect>()).OpenSession())
            using (ITransaction _oTransaction = _oSession.BeginTransaction())
            {
                _oMobileRetentionOrder.SetOld_ord_id(_iOld_order_id);
                _iOrder_id = _oSession.InsertReturnID(_oMobileRetentionOrder, true);
                if (_iOrder_id != null)
                {
                    _oMobileRetentionOrder.SetOrder_id(_iOrder_id);
                    if (_oMobileRetentionOrder.GetOrder_id() != null)
                    {
                        if (_oMobileRetentionOrder.GetMrt_no() != null)
                        {
                            MobileRetentionOrderAddRuleExceptionListEntity _oMobileRetentionOrderAddRuleExceptionList =
                                (new MobileOrderViewControler()).FindExceptionAddRuleOrder(((int)_oMobileRetentionOrder.GetMrt_no()).ToString());
                            if (_oMobileRetentionOrderAddRuleExceptionList != null)
                            {
                                _oMobileRetentionOrderAddRuleExceptionList.SetDB(SYSConn<MSSQLConnect>.Connect());
                                _oMobileRetentionOrderAddRuleExceptionList.SetOrder_id(_iOrder_id);
                                _oMobileRetentionOrderAddRuleExceptionList.SetUsed(true);
                                _oSession.Update(_oMobileRetentionOrderAddRuleExceptionList);
                            }
                        }

                        MobileOrderAddress _oRegisteredAddress = GetRegisteredAddress((int)_iOrder_id);
                        MobileOrderAddress _oBillingAddress = ((_oMobileRetentionOrder.GetBill_medium_waive() == true) ? GetBillingAddress((int)_iOrder_id) : MobileOrderAddressRepository.CreateEntityInstanceObject(SYSConn<MSSQLConnect>.Connect()));
                        MobileOrderMNPDetail _oMobileOrderMNPDetail = new MobileOrderMNPDetail(SYSConn<MSSQLConnect>.Connect());
                        MobileOrderThreeParty _oMobileOrderThreeParty = new MobileOrderThreeParty(SYSConn<MSSQLConnect>.Connect());
                        _oMobileOrderMNPDetail = GetMobileOrderMNPDetail(ref _oMobileOrderMNPDetail, (int)_iOrder_id);
                        _oMobileOrderThreeParty = GetReceiveSIMBy3rdParty(ref _oMobileOrderThreeParty, (int)_iOrder_id);

                        _iRegisteredAddress_id = _oSession.InsertReturnID(_oRegisteredAddress, true);
                        _iBillingAddress_id = ((_oMobileRetentionOrder.GetBill_medium_waive() == true) ? _oSession.InsertReturnID(_oBillingAddress, true) : -1);
                        _iMobileOrderMNPDetail_id = _oSession.InsertReturnID(_oMobileOrderMNPDetail, true);
                        _iMobileOrderThreeParty_id = _oSession.InsertReturnID(_oMobileOrderThreeParty, true);

                        bool _bRegisteredAddress = (_iRegisteredAddress_id > 0) ? true : false;
                        bool _bBillingAddress = (_iBillingAddress_id > 0) ? true : false;
                        bool _bMobileOrderMNPDetail = (_iMobileOrderMNPDetail_id > 0) ? true : false;
                        bool _bMobileOrderThreeParty = (_iMobileOrderThreeParty_id > 0) ? true : false;



                        if (_bRegisteredAddress && ((_oMobileRetentionOrder.GetBill_medium_waive() == true && _bBillingAddress) || _oMobileRetentionOrder.GetBill_medium_waive() != true) && _bMobileOrderMNPDetail && _bMobileOrderThreeParty)
                        {
                            _oTransaction.Commit();
                            _oMobileRetentionOrder.SetOrder_id(_iOrder_id);
                            _bIssue = true;
                        }
                        else
                            _oTransaction.Rollback();
                    }
                }
            }

            if (WebFunc.qsSku == "2420731" ||
                WebFunc.qsSku == "2420911" ||
                WebFunc.qsSku == "2420961" ||
                WebFunc.qsSku == "2420971" ||
                WebFunc.qsSku == "2420981"
                )
            {
                if (n_oSpecialCustomer != null)
                {
                    if (n_oSpecialCustomer.GetCount() != null)
                    {
                        int _iCount = (int)n_oSpecialCustomer.GetCount();
                        if (_iCount > 0)
                        {
                            _iCount = _iCount - 1;
                            n_oSpecialCustomer.SetCount(_iCount);
                            n_oSpecialCustomer.Save();
                        }
                    }
                }
            }


            RWLFramework.Control<FromRegisterControler>().Release();
            _oMobileRetentionOrder.SetOrder_id(_iOrder_id);

            if (_oMobileRetentionOrder.GetCn_mrt_no() != null)
            {
                MobileNumberProfileEntity _oMobileNumberProfileEntity = GetMobileNumberProfile(((int)_oMobileRetentionOrder.GetCn_mrt_no()).ToString());
                _oMobileNumberProfileEntity.SetOrder_id(_iOrder_id);
                _oMobileNumberProfileEntity.SetStatus("USED");
                _oMobileNumberProfileEntity.Save();
            }


            _sNew_Order_id = _iOrder_id.ToString();

            if (_iOrder_id == null)
            {
                //Logger.Debug("Register this order from is not successfully with order id is null");
            }
            if (_iOrder_id == -1)
            {
                ///Logger.DebugFormat("Register this order from is not successfully with order id is {0}", _iOrder_id.ToString());
            }

            if (_iOrder_id != null && _iOrder_id != -1)
            {
                _oDr = null;
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
                                    MobileRetentionOrderBal.SetVas(ref _oMobileRetentionOrder, _sVas_field, _sVas_field_val, _sVasField1.Trim(), true);
                                }
                                else
                                {
                                    MobileRetentionOrderBal.SetVas(ref _oMobileRetentionOrder, _sVas_field, _sVas_field_val, string.Empty, false);
                                }
                            }
                            else
                            {
                                MobileRetentionOrderBal.DeleteVas(ref _oMobileRetentionOrder, _sVas_field);
                            }
                        }
                    }
                    _oDr.Close();
                    _oDr.Dispose();
                    _oDr = null;
                }

            }

            if (_iOrder_id != null)
            {
                _oMobileRetentionOrder.SetOrder_id(_iOrder_id);
                MobileRetentionOrderRepositoryBase _oMobileRetentionOrderRepositoryBase = new MobileRetentionOrderRepositoryBase(SYSConn<MSSQLConnect>.Connect());
                IQueryable<MobileRetentionOrderEntity> _oMobileRetentionOrderList = from sMobileRetentionOrderList in _oMobileRetentionOrderRepositoryBase.MobileRetentionOrders
                                                                                    where sMobileRetentionOrderList.order_id == _iOrder_id
                                                                                    select sMobileRetentionOrderList;

                MobileRetentionOrderEntity _oMobileRetentionOrderEntity = null;
                if (_oMobileRetentionOrderList.Count<MobileRetentionOrderEntity>() > 0)
                {
                    _oMobileRetentionOrderEntity = _oMobileRetentionOrderList.First<MobileRetentionOrderEntity>();
                }
                if (_oMobileRetentionOrderEntity != null)
                {
                    //Logger.Debug("If the order form have IMEI Code go to insert the IMEI in edf system.");
                    if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetGift_imei()) && _oMobileRetentionOrderEntity != null)
                    {
                        IMEI_StockBal.SaveByGift_imei(Func.IDAdd100000(_oMobileRetentionOrderEntity.GetOrder_id()),
                            null, n_dCdate.ToString("yyyyMMdd"), ((_oMobileRetentionOrderEntity.GetMrt_no() != null) ? (_oMobileRetentionOrderEntity.GetMrt_no()).ToString() : string.Empty), n_dCdate.ToString("yyyyMMdd"),
                            "SOLD", _oMobileRetentionOrder.GetGift_code(), _oMobileRetentionOrder.GetGift_imei());
                    }
                    if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetGift_imei2()) && _oMobileRetentionOrderEntity != null)
                    {
                        IMEI_StockBal.SaveByGift_imei(Func.IDAdd100000(_oMobileRetentionOrderEntity.GetOrder_id()),
                            null, n_dCdate.ToString("yyyyMMdd"), ((_oMobileRetentionOrderEntity.GetMrt_no() != null) ? (_oMobileRetentionOrderEntity.GetMrt_no()).ToString() : string.Empty), n_dCdate.ToString("yyyyMMdd"),
                            "SOLD", _oMobileRetentionOrder.GetGift_code2(), _oMobileRetentionOrder.GetGift_imei2());
                    }
                    if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetGift_imei3()) && _oMobileRetentionOrderEntity != null)
                    {
                        IMEI_StockBal.SaveByGift_imei(Func.IDAdd100000(_oMobileRetentionOrderEntity.GetOrder_id()),
                            null, n_dCdate.ToString("yyyyMMdd"), ((_oMobileRetentionOrderEntity.GetMrt_no() != null) ? (_oMobileRetentionOrderEntity.GetMrt_no()).ToString() : string.Empty), n_dCdate.ToString("yyyyMMdd"),
                            "SOLD", _oMobileRetentionOrder.GetGift_code3(), _oMobileRetentionOrder.GetGift_imei3());
                    }
                    if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetGift_imei4()) && _oMobileRetentionOrderEntity != null)
                    {
                        IMEI_StockBal.SaveByGift_imei(Func.IDAdd100000(_oMobileRetentionOrderEntity.GetOrder_id()),
                            null, n_dCdate.ToString("yyyyMMdd"), ((_oMobileRetentionOrderEntity.GetMrt_no() != null) ? (_oMobileRetentionOrderEntity.GetMrt_no()).ToString() : string.Empty), n_dCdate.ToString("yyyyMMdd"),
                            "SOLD", _oMobileRetentionOrder.GetGift_code4(), _oMobileRetentionOrder.GetGift_imei4());
                    }
                    if (!string.IsNullOrEmpty(_oMobileRetentionOrderEntity.GetAccessory_imei()) && _oMobileRetentionOrderEntity != null)
                    {
                        IMEI_StockBal.SaveByGift_imei(Func.IDAdd100000(_oMobileRetentionOrderEntity.GetOrder_id()),
                            null, n_dCdate.ToString("yyyyMMdd"), ((_oMobileRetentionOrderEntity.GetMrt_no() != null) ? (_oMobileRetentionOrderEntity.GetMrt_no()).ToString() : string.Empty), n_dCdate.ToString("yyyyMMdd"),
                            "SOLD", _oMobileRetentionOrder.GetAccessory_code(), _oMobileRetentionOrder.GetAccessory_imei());
                    }
                }
            }

            #region Release old Order
            //========= Release old Order =========
            if (_iOrder_id != null && _iOrder_id != -1)
            {
                MobileRetentionOrderEntity _oOldMobileRetentionOrderEntity = GetOldOrder(_iOld_order_id);
                OrderReleaseDetailEntity _oOrderReleaseDetailEntity = GetOrderReleaseDetail(_iOld_order_id);
                if (_oOldMobileRetentionOrderEntity != null && _oOrderReleaseDetailEntity != null)
                {
                    bool _bFlag = true;
                    _oOldMobileRetentionOrderEntity.SetActive(false);
                    _oOldMobileRetentionOrderEntity.SetDid(RWLFramework.CurrentUser[this.Page].Uid);
                    _oOldMobileRetentionOrderEntity.SetDdate(DateTime.Now);
                    _oOldMobileRetentionOrderEntity.SetOld_ord_id(0);
                    _oOrderReleaseDetailEntity.SetActive(false);
                    _oOrderReleaseDetailEntity.SetDid(RWLFramework.CurrentUser[this.Page].Uid);
                    _oOrderReleaseDetailEntity.SetDdate(DateTime.Now);
                    using (ISession<MSSQLConnect> _oSession = (new SessionFactory<MSSQLConnect>()).OpenSession())
                    using (ITransaction _oTransaction = _oSession.BeginTransaction())
                    {
                        if (_bFlag)
                            _bFlag = _oSession.Update(_oOldMobileRetentionOrderEntity);
                        if (_bFlag)
                            _bFlag = _oSession.Update(_oOrderReleaseDetailEntity);

                        if (_bFlag)
                            _oTransaction.Commit();
                        else
                            _oTransaction.Rollback();
                    }
                }
            }
            //============ End of release old Order ==============
            #endregion

            #region Copy HS/Free Gift/Accessory from old order
            //============ Copy HS/Free Gift/Accessory from old order ==============
            string _sCopyIMEIQuery = "UPDATE IMEI_Stock SET DUMMY4='" + Func.IDAdd100000(_iOrder_id) + "' WHERE Dummy2='CC RET' AND DUMMY4='" + Func.IDAdd100000(_iOld_order_id) + "'";
            SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_sCopyIMEIQuery);
            if (!_sEdf_no.Equals(string.Empty))
            {
                string _sRefNo = string.Empty;
                OdbcDataReader _oRefDr = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT SUNDAY_RA1_Serial.NextVal AS seq, to_char(sysdate, 'yymon') AS cdate FROM dual");
                if (_oRefDr.Read())
                    _sRefNo = Func.Right(Func.IDAdd100000(Convert.ToInt32(Func.FR(_oRefDr["seq"]).Trim())), 5) + "/A/" + Func.FR(_oRefDr["cdate"]).Trim().ToUpper();

                _oRefDr.Close();
                _oRefDr.Dispose();

                string _sAmentQuery = "INSERT INTO SUNDAY_Ament (Record_ID  ,eOrder_Update ,eOrder_U_Date ,Form_Name  ,REFERENCENO,Ament_Date, AMENT_BY ,Field_Name ,Change_From,Change_To ) Values ('" + _sRefNo + "','Y',to_date('" + _sToday2 + "','yyyy-mm-dd'),'CC RET','" + _sEdf_no + "',to_date('" + _sToday + "', 'dd/mm/yyyy hh24:mi:ss'),'" + RWLFramework.CurrentUser[this.Page].Uid + "' ,'E-Order ID','" + Func.IDAdd100000(_iOld_order_id) + "','" + Func.IDAdd100000(_iOrder_id) + "')";
                SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_sAmentQuery);
                string _sUpdateQuery = "UPDATE sunday_Form SET Agree_no='" + Func.IDAdd100000(_iOrder_id) + "' WHERE CREATED_BY='CC RET' and Agree_no='" + Func.IDAdd100000(_iOld_order_id) + "'";
                SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_sUpdateQuery);
            }
            //============ End of Copy HS/Free Gift/Accessory from old order ==============
            #endregion

            if (!_sOld_sku.Equals(_sSku))
            {
                /*================= Release old HS ==================*/
                OdbcDataReader _oDr2 = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT * FROM IMEI_Stock WHERE Dummy2='CC RET' AND DUMMY4='" + Func.IDAdd100000(_iOrder_id).ToString() + "' AND (IMEI not like 'FG%' or IMEI=' ' or IMEI is null)");
                while (_oDr2.Read())
                {
                    IMEIGiftStatusControl _oIMEIGiftStatusControl = new IMEIGiftStatusControl();
                    _oIMEIGiftStatusControl.SetImei_no(_sOld_imei_no);
                    _oIMEIGiftStatusControl.SetIMEI(Func.FR(_oDr2["IMEI"]));
                    _oIMEIGiftStatusControl.SetCreate_Date(Func.FR(_oDr2["Create_Date"]));
                    _oIMEIGiftStatusControl.SetDummy1(Func.FR(_oDr2["Dummy1"]));
                    _oIMEIGiftStatusControl.SetKit_Code(Func.FR(_oDr2["Kit_Code"]));
                    _oIMEIGiftStatusControl.SetModel(Func.FR(_oDr2["Model"]));
                    _oIMEIGiftStatusControl.SetStatus(Func.FR(_oDr2["Status"]));
                    _oIMEIGiftStatusControl.SetReferenceNo(Func.FR(_oDr2["ReferenceNo"]));
                    _oIMEIGiftStatusControl.SetDummy4(Func.FR(_oDr2["DUMMY4"]));
                    _oIMEIGiftStatusControl.SetToday(_sToday);
                    _oIMEIGiftStatusControl.SetToday1(_sToday1);
                    _oIMEIGiftStatusControl.SetUid(RWLFramework.CurrentUser[this.Page].Uid);
                    _oIMEIGiftStatusControl.SetDummy1(Func.FR(_oDr2["Dummy1"]));
                    _oIMEIGiftStatusControl.SetDummy2(Func.FR(_oDr2["Dummy2"]));
                    _oIMEIGiftStatusControl.SetSku(_sOld_sku);
                    _oIMEIGiftStatusControl.SetOrder_id(Func.IDAdd100000(_oMobileRetentionOrder.GetOrder_id()));
                    _oIMEIGiftStatusControl.ManagementGiftIMEIStatus(_oMobileRetentionOrder.GetDelivery_exchange_location());
                }
                _oDr2.Close();
                _oDr2.Dispose();
                /*'================= End of Release old HS ==================*/

                /*'================= Assign New HS ==================*/
                if (!"".Equals(_sEdf_no))
                {
                    if (!string.IsNullOrEmpty(_sSku) && !_sSku.Equals("0"))
                    {
                        IMEISoldAwaitControl _oIMEISoldAwaitControl = new IMEISoldAwaitControl();
                        _oIMEISoldAwaitControl.SetSku(_sSku);
                        _oIMEISoldAwaitControl.SetHs_model(_sHs_model);
                        _oIMEISoldAwaitControl.SetOrder_id(Func.IDAdd100000(_oMobileRetentionOrder.GetOrder_id()));
                        _oIMEISoldAwaitControl.SetEdf_no(_sEdf_no);
                        _oIMEISoldAwaitControl.SetStaff_no(_oMobileRetentionOrder.GetSku());
                        _oIMEISoldAwaitControl.SetToday1(_sToday1);
                        _oIMEISoldAwaitControl.SetToday(_sToday);
                        _oIMEISoldAwaitControl.SetUid(RWLFramework.CurrentUser[this.Page].Uid);
                        if (_oMobileRetentionOrder.GetMrt_no() != null)
                            _oIMEISoldAwaitControl.SetMrt_no(((int)_oMobileRetentionOrder.GetMrt_no()).ToString());
                        _oIMEISoldAwaitControl.ManagementProductSoldAwait(_oMobileRetentionOrder.GetDelivery_exchange_location());
                        _oMobileRetentionOrder.SetImei_no(_oIMEISoldAwaitControl.GetImei_no());
                        _oMobileRetentionOrder.Save();
                    }
                    else
                    {
                        MobileRetentionOrderBal.IMEIRelease(Func.IDSubtract100000(_oMobileRetentionOrder.GetOrder_id()));
                    }
                }
            }

            RWLviewrow1.SetOrderid((int)_oMobileRetentionOrder.GetOrder_id());
            RWLviewrow1.LoadOrder();
            RWLviewrow1.Visible = true;

            DetailInfo.Visible = false;
        }
        else
        {
            DetailInfo.Visible = true;
        }
        Session["ModifyOrder"] = string.Empty;
    }



    protected MobileOrderAddress GetRegisteredAddress(int x_iOrder_id)
    {
        MobileOrderAddress _oMobileOrderAddress = new MobileOrderAddress(SYSConn<MSSQLConnect>.Connect());
        _oMobileOrderAddress.address_type = "REGISTERED_ADDRESS";
        _oMobileOrderAddress.d_blk = MobileOrderAddressUserControl.RequestID("RegisteredAddressControl").qsD_blk.Trim();
        _oMobileOrderAddress.d_build = MobileOrderAddressUserControl.RequestID("RegisteredAddressControl").qsD_build.Trim();
        _oMobileOrderAddress.d_floor = MobileOrderAddressUserControl.RequestID("RegisteredAddressControl").qsD_floor.Trim();
        _oMobileOrderAddress.d_region = MobileOrderAddressUserControl.RequestID("RegisteredAddressControl").qsD_region.Trim();
        _oMobileOrderAddress.d_room = MobileOrderAddressUserControl.RequestID("RegisteredAddressControl").qsD_room.Trim();
        _oMobileOrderAddress.d_street = MobileOrderAddressUserControl.RequestID("RegisteredAddressControl").qsD_street.Trim();
        _oMobileOrderAddress.d_type = MobileOrderAddressUserControl.RequestID("RegisteredAddressControl").qsD_type.Trim();
        _oMobileOrderAddress.d_district = MobileOrderAddressUserControl.RequestID("RegisteredAddressControl").qsD_district.Trim();
        _oMobileOrderAddress.order_id = x_iOrder_id;

        return _oMobileOrderAddress;
    }

    protected MobileOrderAddress GetBillingAddress(int x_iOrder_id)
    {

        MobileOrderAddress _oMobileOrderAddress = new MobileOrderAddress(SYSConn<MSSQLConnect>.Connect());
        _oMobileOrderAddress.address_type = "BILLING_ADDRESS";
        _oMobileOrderAddress.d_blk = MobileOrderAddressUserControl.RequestID("BillingAddressControl").qsD_blk.Trim();
        _oMobileOrderAddress.d_build = MobileOrderAddressUserControl.RequestID("BillingAddressControl").qsD_build.Trim();
        _oMobileOrderAddress.d_floor = MobileOrderAddressUserControl.RequestID("BillingAddressControl").qsD_floor.Trim();
        _oMobileOrderAddress.d_region = MobileOrderAddressUserControl.RequestID("BillingAddressControl").qsD_region.Trim();
        _oMobileOrderAddress.d_room = MobileOrderAddressUserControl.RequestID("BillingAddressControl").qsD_room.Trim();
        _oMobileOrderAddress.d_street = MobileOrderAddressUserControl.RequestID("BillingAddressControl").qsD_street.Trim();
        _oMobileOrderAddress.d_type = MobileOrderAddressUserControl.RequestID("BillingAddressControl").qsD_type.Trim();
        _oMobileOrderAddress.d_district = MobileOrderAddressUserControl.RequestID("BillingAddressControl").qsD_district.Trim();
        _oMobileOrderAddress.order_id = x_iOrder_id;

        return _oMobileOrderAddress;
    }

    protected MobileOrderMNPDetail GetMobileOrderMNPDetail(ref MobileOrderMNPDetail x_oMobileOrderMNPDetail, int x_iOrder_id)
    {

        x_oMobileOrderMNPDetail.company_name = MobileOrderMNPDetailUserControl.RequestID("MobileOrderMNPDetailControl").qsCompany_name.Trim();
        x_oMobileOrderMNPDetail.hkid = MobileOrderMNPDetailUserControl.RequestID("MobileOrderMNPDetailControl").qsHkid.Trim() + MobileOrderMNPDetailUserControl.RequestID("MobileOrderMNPDetailControl").qsHkid2.Trim();
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
    protected void IsModifyEDF(string x_sOrder_id, string x_sEdf_no, string x_sOld_sku, string x_sSku)
    {
        int _iOrder_id;
        if (int.TryParse(x_sOrder_id, out _iOrder_id))
        {
            MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect());
            _oMobileRetentionOrder.SetOrder_id(_iOrder_id);
            if (_oMobileRetentionOrder.Retrieve())
            {
                //-- Check by record storing in database (_oCheckToEDF)----------------------
                MobileOrderAllowToEDFChk _oCheckToEDF = new MobileOrderAllowToEDFChk();
                _oCheckToEDF.SetSku(_oMobileRetentionOrder.GetSku());
                _oCheckToEDF.SetImei_no(_oMobileRetentionOrder.GetImei_no());
                _oCheckToEDF.SetSim_item_code(_oMobileRetentionOrder.GetSim_item_code());
                //_oCheckToEDF.SetSim_item_number(_oMobileRetentionOrder.GetSim_item_number());
                //-- Check by record storing in database (_oCheckToEDF)----------------------

                if (x_sEdf_no != string.Empty)
                {
                    Session["ModifyOrder"] = string.Empty;
                    Session["ModifyOrderWeblogProcess"] = "ModifyOrderWeblogProcess";
                    Response.Redirect("ModifyEDF.aspx?order_id=" + x_sOrder_id);
                }
                else if (x_sOld_sku != x_sSku ||
                    (
                    (_oMobileRetentionOrder.GetSim_item_code() != _sOld_sim_item_code) 
                    &&
                    _oCheckToEDF.allowToEDF())
                    )
                {
                    Session["ModifyOrder"] = string.Empty;
                    Session["IssueOrderWeblogProcess"] = "IssueOrderWeblogProcess";
                    Response.Redirect("MigrateToEDF.aspx?order_id=" + x_sOrder_id);
                }
            }
        }
    }

    #endregion

    #region Get Old Order
    protected MobileRetentionOrderEntity GetOldOrder(int x_iOld_order_id)
    {
        MobileRetentionOrderRepositoryBase _oMobileRetentionOrderRepositoryBase = new MobileRetentionOrderRepositoryBase(SYSConn<MSSQLConnect>.Connect());
        IQueryable<MobileRetentionOrderEntity> _oMobileRetentionOrderList = from sMobileRetentionOrderList in _oMobileRetentionOrderRepositoryBase.MobileRetentionOrders
                                                                            where sMobileRetentionOrderList.order_id == x_iOld_order_id
                                                                            select sMobileRetentionOrderList;

        MobileRetentionOrderEntity _oMobileRetentionOrderEntity = null;
        if (_oMobileRetentionOrderList.Count<MobileRetentionOrderEntity>() > 0)
        {
            _oMobileRetentionOrderEntity = _oMobileRetentionOrderList.First<MobileRetentionOrderEntity>();
            _oMobileRetentionOrderEntity.SetDB(SYSConn<MSSQLConnect>.Connect());
        }
        return _oMobileRetentionOrderEntity;
    }
    #endregion

    #region Get Release Order
    protected OrderReleaseDetailEntity GetOrderReleaseDetail(int x_iOrder_id)
    {
        OrderReleaseDetailRepositoryBase _oOrderReleaseDetailRepositoryBase = new OrderReleaseDetailRepositoryBase(SYSConn<MSSQLConnect>.Connect());
        IQueryable<OrderReleaseDetailEntity> _oOrderReleaseDetailList = from sOrderReleaseDetailList in _oOrderReleaseDetailRepositoryBase.OrderReleaseDetails
                                                                        where sOrderReleaseDetailList.order_id == x_iOrder_id
                                                                        select sOrderReleaseDetailList;

        OrderReleaseDetailEntity _oOrderReleaseDetailEntity = null;
        if (_oOrderReleaseDetailList.Count<OrderReleaseDetailEntity>() > 0)
        {
            _oOrderReleaseDetailEntity = _oOrderReleaseDetailList.First<OrderReleaseDetailEntity>();
            _oOrderReleaseDetailEntity.SetDB(SYSConn<MSSQLConnect>.Connect());
        }
        return _oOrderReleaseDetailEntity;
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
        _oDB.SetConnStr(Configurator.DBName.ORADNS + ((Configurator.IsUat()) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion
}
