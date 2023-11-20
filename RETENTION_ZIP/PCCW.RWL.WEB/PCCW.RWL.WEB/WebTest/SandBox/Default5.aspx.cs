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
public partial class SandBox_Default5 : System.Web.UI.Page
{
    MobileOrderAddress _oRegisteredAddress = new MobileOrderAddress();
    MobileOrderAddress _oBillingAddress = new MobileOrderAddress();
    MobileOrderMNPDetail _oMobileOrderMNPDetail = new MobileOrderMNPDetail();
    MobileOrderThreeParty _oMobileOrderThreeParty = new MobileOrderThreeParty();
    List<MobileOrderVasEntity> _oMobileOrderVasArr = new List<MobileOrderVasEntity>();
    SundayActivation _oSundayActivation = new SundayActivation();
    protected void Page_Load(object sender, EventArgs e)
    {
        string _sPath = Request.ApplicationPath;
        _sPath = "";
        this.HeaderScripts.Text = string.Format(
     @"<script type=""text/javascript"" src=""{0}/Resources/Scripts/jquery-1.3.2.min.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/global.js""></script>
        <!--[if lte IE 6]><script defer type=""text/javascript"" src=""{0}/Resources/Scripts/pngfix.js""></script><![endif]-->
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/norefresh.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/script.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/jquery-ui-1.8.2.custom.min.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/jquery.alerts.js""></script>
        <link rel=""stylesheet"" href=""{0}/Resources/Styles/jquery.alerts.css"" type=""text/css"" />"
    , _sPath);

        RWLFramework.DataBaseConfigSetting();

        MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect(), 8003);
        GetMobileRetentionOrderLeftJoinTableData((int)_oMobileRetentionOrder.GetOrder_id(), _oMobileRetentionOrder.GetEdf_no());
         _oSundayActivation = SetSundayActivation(_oMobileRetentionOrder);
         if (_oSundayActivation.IsFound())
             _oSundayActivation.Save();
         else
         {
             _oSundayActivation.CreateRecord();
         }
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
        if (!string.IsNullOrEmpty(x_sEdf_no))
            _oSundayActivation.Load(x_sEdf_no);
    }


    public SundayActivation SetSundayActivation(MobileRetentionOrder x_oMobileRetentionOrder)
    {
        _oSundayActivation.SetREFERENCENO(x_oMobileRetentionOrder.GetEdf_no());
        if (!string.IsNullOrEmpty(x_oMobileRetentionOrder.GetChange_payment_type()))
        {
            if (x_oMobileRetentionOrder.GetChange_payment_type().Length >= 15)
                _oSundayActivation.SetMP_CARD_OWNER(x_oMobileRetentionOrder.GetChange_payment_type().Substring(0, 15));
            else
                _oSundayActivation.SetMP_CARD_OWNER(x_oMobileRetentionOrder.GetChange_payment_type());
        }
        _oSundayActivation.SetMP_3_PARTY_NAME(x_oMobileRetentionOrder.GetM_card_type());


        _oSundayActivation.SetREGION_CITY(x_oMobileRetentionOrder.GetRebate());
        string _sBank_code = x_oMobileRetentionOrder.GetMonthly_bank_account_bank_code() + " " +
                        x_oMobileRetentionOrder.GetMonthly_bank_account_branch_code() + " " +
                        x_oMobileRetentionOrder.GetMonthly_bank_account_no();

        if (!string.IsNullOrEmpty(x_oMobileRetentionOrder.GetM_card_no()))
            _oSundayActivation.SetMP_CARDNO(x_oMobileRetentionOrder.GetM_card_no());
        else if (!string.IsNullOrEmpty(x_oMobileRetentionOrder.GetMonthly_bank_account_bank_code().Trim()) &&
            !string.IsNullOrEmpty(x_oMobileRetentionOrder.GetMonthly_bank_account_branch_code().Trim()) &&
            !string.IsNullOrEmpty(x_oMobileRetentionOrder.GetMonthly_bank_account_no().Trim()))
        {
            _oSundayActivation.SetMP_CARDNO(_sBank_code);
        }
        else
            _oSundayActivation.SetMP_CARDNO(x_oMobileRetentionOrder.GetM_card_no().Trim());

        string _sHolder_name = string.Empty;
        if (x_oMobileRetentionOrder.GetChange_payment_type().ToUpper().Equals("CREDIT CARD"))
            _sHolder_name = x_oMobileRetentionOrder.GetM_card_holder2();
        else if (x_oMobileRetentionOrder.GetChange_payment_type().ToUpper().Equals("BANK ACCOUNT"))
            _sHolder_name = x_oMobileRetentionOrder.GetMonthly_bank_account_holder();

        _oSundayActivation.SetMP_C_HOLDER_NAME(_sHolder_name);

        _oSundayActivation.SetMP_3_PARTY_ID(x_oMobileRetentionOrder.GetMonthly_bank_account_hkid() + x_oMobileRetentionOrder.GetMonthly_bank_account_hkid2());
        string _sM_card_exp_year = string.Empty;
        if (x_oMobileRetentionOrder.GetM_card_exp_year().Length >= 4)
            _sM_card_exp_year = x_oMobileRetentionOrder.GetM_card_exp_year().Substring(2, 2);

        _oSundayActivation.SetMP_EXPIRYDATE(x_oMobileRetentionOrder.GetM_card_exp_month() + _sM_card_exp_year);
        if (!string.IsNullOrEmpty(x_oMobileRetentionOrder.GetBill_medium()))
        {
            if (x_oMobileRetentionOrder.GetBill_medium().Equals("0"))
                _oSundayActivation.SetCUSTOMER_GROUP("SMS bill $0");
            else if (x_oMobileRetentionOrder.GetBill_medium().Equals("1"))
                _oSundayActivation.SetCUSTOMER_GROUP("Email bill $0");
            else if (x_oMobileRetentionOrder.GetBill_medium().Equals("2"))
                _oSundayActivation.SetCUSTOMER_GROUP("Paper bill $10");
            else if (x_oMobileRetentionOrder.GetBill_medium().Equals("3"))
                _oSundayActivation.SetCUSTOMER_GROUP("SMS bill $0 + Email bill $0");
        }
        _oSundayActivation.SetSMS_SUPPRESS(x_oMobileRetentionOrder.GetSms_mrt());
        _oSundayActivation.SetEMAIL(x_oMobileRetentionOrder.GetBill_medium_email());

        string _sBilling_Address = MobileOrderAddressBal.GetAddress(_oBillingAddress).Trim().ToUpper();
        _oSundayActivation.SetBILL_ADDRESS_1(_sBilling_Address.Trim().ToUpper().Replace("'", "`").Replace("``", "`"));

        string _sBill_medium_waive = ((x_oMobileRetentionOrder.GetBill_medium_waive() == true) ? "1" : "0");
        _oSundayActivation.SetEMAIL_BILL(_sBill_medium_waive);
        string _sPrepayment = ((x_oMobileRetentionOrder.GetPrepayment_waive() == true) ? "1" : "0");
        _oSundayActivation.SetPAYMENT_TYPE(_sPrepayment);
        string _sExtra_rebate = x_oMobileRetentionOrder.GetExtra_rebate();
        _oSundayActivation.SetSTUDENT_BIRTH_D(_sExtra_rebate);

        _oSundayActivation.SetBILL_CU_NAME(_oMobileOrderMNPDetail.GetCompany_name());
        _oSundayActivation.SetN2_REGISTERED_NAME(_oMobileOrderMNPDetail.GetRegistered_name());
        _oSundayActivation.SetTICKET_NO(_oMobileOrderMNPDetail.GetTicker_number());

        _oSundayActivation.SetAGREEMENT_DATE(_oMobileOrderMNPDetail.GetService_activation_time());
        _oSundayActivation.SetAGREEMENT_NO(x_oMobileRetentionOrder.GetMonthly_bank_account_id_type());

        string _sRegisteredAddress = MobileOrderAddressBal.GetAddress(_oRegisteredAddress).Trim().ToUpper();

        _oSundayActivation.SetADDRESS_1(_sRegisteredAddress.Trim().ToUpper().Replace("'", "`").Replace("``", "`"));
        _oSundayActivation.SetID_NO_TYPE(_oMobileOrderMNPDetail.GetId_type());
        _oSundayActivation.SetID_NO(_oMobileOrderMNPDetail.GetHkid());
        _oSundayActivation.SetBILL_ADDRESS_3(x_oMobileRetentionOrder.GetUpgrade_handset_offer_rebate_schedule());

        _oSundayActivation.SetBANK_ACCOUNT(x_oMobileRetentionOrder.GetUpgrade_existing_customer_type());
        _oSundayActivation.SetCREATE_DATE(x_oMobileRetentionOrder.GetUpgrade_existing_contract_sdate());
        _oSundayActivation.SetSMARK_EXP_DATE(x_oMobileRetentionOrder.GetUpgrade_existing_contract_edate());
        _oSundayActivation.SetPREPAID_SIM_TO_POSTPAID(x_oMobileRetentionOrder.GetUpgrade_existing_pccw_customer());
        _oSundayActivation.SetOLD_SUB_HK_ID(x_oMobileRetentionOrder.GetUpgrade_service_account_no());
        _oSundayActivation.SetJOINT_PROMOTION_CODE(x_oMobileRetentionOrder.GetUpgrade_service_tenure());

        _oSundayActivation.SetHANDSET_DESC(x_oMobileRetentionOrder.GetExisting_smart_phone_model());
        _oSundayActivation.SetIMEI(x_oMobileRetentionOrder.GetExisting_smart_phone_imei());
        _oSundayActivation.SetDNO(x_oMobileRetentionOrder.GetAction_of_rate_plan_effective());
        if (x_oMobileRetentionOrder.GetBill_cut_date() != null)
            _oSundayActivation.SetFAX(((DateTime)x_oMobileRetentionOrder.GetBill_cut_date()).ToString(""));

        _oSundayActivation.SetVAS_NAME15(x_oMobileRetentionOrder.GetMonthly_payment_type());
        _oSundayActivation.SetCONTACT_PERSON(FindVasValue1("upg_auto_vas"));
        _oSundayActivation.SetOWNER_NAME(FindVasValue1("upg_con_vas"));
        _oSundayActivation.SetBANK_NAME(FindVasValue1("upg_cou1_vas"));
        _oSundayActivation.SetOLD_SUB_NAME_MNP(FindVasValue1("upg_data_vas"));
        _oSundayActivation.SetREG_BUILDING(FindVasValue1("upg_fin_vas"));
        _oSundayActivation.SetREG_ESTATE(FindVasValue1("upg_gprs_vas"));
        _oSundayActivation.SetREG_ST_NAME(FindVasValue1("upg_idd_vas"));
        _oSundayActivation.SetREG_DISTRICT(FindVasValue1("upg_lice_vas"));
        _oSundayActivation.SetBIL_BUILDING(FindVasValue1("upg_min_vas"));
        _oSundayActivation.SetBIL_ESTATE(FindVasValue1("upg_moov_vas"));
        _oSundayActivation.SetBIL_ST_NAME(FindVasValue1("upg_net_vas"));
        _oSundayActivation.SetBIL_DISTRICT(FindVasValue1("upg_now_vas"));
        _oSundayActivation.SetVAS_NAME1(FindVasValue1("upg_oth1_vas"));
        _oSundayActivation.SetVAS_NAME2(FindVasValue1("upg_oth2_vas"));
        _oSundayActivation.SetVAS_NAME3(FindVasValue1("upg_oth3_vas"));
        _oSundayActivation.SetVAS_NAME4(FindVasValue1("upg_oth4_vas"));
        _oSundayActivation.SetVAS_NAME5(FindVasValue1("upg_oth5_vas"));
        _oSundayActivation.SetVAS_NAME6(FindVasValue1("upg_oth6_vas"));
        _oSundayActivation.SetVAS_NAME7(FindVasValue1("upg_sec_vas"));
        _oSundayActivation.SetVAS_NAME8(FindVasValue1("upg_sms1_vas"));
        _oSundayActivation.SetVAS_NAME9(FindVasValue1("upg_sms2_vas"));
        _oSundayActivation.SetVAS_NAME10(FindVasValue1("upg_sms3_vas"));
        _oSundayActivation.SetVAS_NAME11(FindVasValue1("upg_smsb_vas"));
        _oSundayActivation.SetVAS_NAME12(FindVasValue1("upg_spo_vas"));
        _oSundayActivation.SetVAS_PRICE13(FindVasValue1("upg_sup_vas"));
        _oSundayActivation.SetVAS_PRICE14(FindVasValue1("upg_wifi_vas"));


        return _oSundayActivation;
    }
}
