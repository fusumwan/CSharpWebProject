using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Text;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using NEURON.ENTITY.FRAMEWORK.STOCK;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;

public partial class SandBox_Default19 : System.Web.UI.Page
{
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
        Session["lv"] = "65535";
        Session["uid"] = "A8350006";
        Session["arprog"] = "RWLN";
        RWLFramework.DataBaseConfigSetting();


        UpdateEDF(385328);
        UpdateEDF(385339);
        UpdateEDF(385658);
        UpdateEDF(385772);
        UpdateEDF(385856);
        UpdateEDF(386508);
        UpdateEDF(386522);
        UpdateEDF(386818);
        UpdateEDF(387184);
        UpdateEDF(388067);

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

                Response.Write(x_IOrder_id.ToString() + " No EDF<br>");
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
                _oQuery.Append("customer_name = '" + _oMobileRetentionOrder.cust_name.Trim().Replace("'", "`") + "',");
                _oQuery.Append("staffNo = '" + _oMobileRetentionOrder.GetStaff_no().Trim() + "',");
                _oQuery.Append("staffName = '" + _oMobileRetentionOrder.GetStaff_name().Trim().Replace("'", "`") + "',");
                _oQuery.Append("SalesManCode = '" + _oMobileRetentionOrder.GetSalesmancode().Trim() + "',");
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

                _oQuery.Append("SIM_CARD_TYPE='" + _oMobileRetentionOrder.sim_item_name + "',");
                _oQuery.Append("SIM_ITEM_CODE='" + _oMobileRetentionOrder.sim_item_code + "',");
                //_oQuery.Append("SIM_CARD_NO='" + MobileRetentionOrderBal.GetSim_Number(_oMobileRetentionOrder) + "',");


                _oQuery.Append("User_Name='" + _oMobileRetentionOrder.contact_person.Trim().Replace("'", "`") + "',");
                //_oQuery.Append("ament_counter = ament_counter + 1 ,");
                _oQuery.Append("agree_no='" + (_oMobileRetentionOrder.GetOrder_id() + 100000).ToString() + "' ");
                _oQuery.Append(" WHERE referenceNo ='" + _oMobileRetentionOrder.edf_no.Trim() + "'");
                //Response.Write(_oQuery.ToString());
                Response.Write("<br>");
                bFlag = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery.ToString());
                if (bFlag)
                {
                    Response.Write("SUCCESS : " + x_IOrder_id.ToString() + " <br>");
                }
                else
                {
                    Response.Write("FAIL : " + x_IOrder_id.ToString() + " <br>");
                }
            }
        }
        return bFlag;
    }


    /*
    protected void LoseDataRetrieve()
    {
        MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect());
        _oMobileRetentionOrder.SetOrder_id(277347);
        if (_oMobileRetentionOrder.Retrieve())
        {
            DateTime Logdate = new DateTime(2010, 3, 11, 19, 57, 0);
            _oMobileRetentionOrder.SetLog_date(Logdate);
            _oMobileRetentionOrder.SetCust_name("FUNG HAU TSZ TELLY");
            _oMobileRetentionOrder.SetAc_no(string.Empty);
            _oMobileRetentionOrder.SetMrt_no(66990511);
            _oMobileRetentionOrder.SetHkid("G4871587");
            _oMobileRetentionOrder.SetProgram("Mass Retention");
            _oMobileRetentionOrder.SetRate_plan("3GRETENT0198A");
            _oMobileRetentionOrder.SetCon_per("24");
            _oMobileRetentionOrder.SetFast_start(false);
            _oMobileRetentionOrder.SetActive(true);
            _oMobileRetentionOrder.SetCid("80133879");
            _oMobileRetentionOrder.SetCon_eff_date(new DateTime(2010, 3, 16));
            _oMobileRetentionOrder.SetCdate(new DateTime(2010, 03, 16, 12, 30, 6));
            _oMobileRetentionOrder.SetHs_model("PCCW-SONY ERI W595 COSMOPOLITAN WHITE (2GB CARD)");
            _oMobileRetentionOrder.SetRebate_amount("$0 x 23 + $0");
            _oMobileRetentionOrder.SetD_address("FT 905 9/F BLOCK B HONG FUNG HSE  CHEUNG HONG EST  Tsing Yi NT");
            _oMobileRetentionOrder.SetD_date(new DateTime(2010, 3, 17));
            _oMobileRetentionOrder.SetD_time("AM");
            _oMobileRetentionOrder.SetExtra_d_charge("0");
            _oMobileRetentionOrder.SetContact_person("FUNG HAU TSZ TELLY");
            _oMobileRetentionOrder.SetContact_no("66990511");
            _oMobileRetentionOrder.SetAmount("0");
            _oMobileRetentionOrder.SetPay_method("CASH");
            _oMobileRetentionOrder.SetR_offer("$0+$0");
            _oMobileRetentionOrder.SetStaff_no("80133192");
            _oMobileRetentionOrder.SetStaff_name("OTTO LIU XU MING");
            _oMobileRetentionOrder.SetTeamcode("GZOB_D06");
            _oMobileRetentionOrder.SetSku("2613891");
            _oMobileRetentionOrder.SetTrade_field("3GRET0198HSOFFER24M");
            _oMobileRetentionOrder.SetSalesmancode("LCS2");
            _oMobileRetentionOrder.SetExtn("29469229");
            _oMobileRetentionOrder.SetId_type("HKID");
            _oMobileRetentionOrder.SetChannel("OB");
            _oMobileRetentionOrder.SetWaive(false);
            _oMobileRetentionOrder.SetBundle_name("RET[08]0198HSBUN24M");
            _oMobileRetentionOrder.SetTl_name("HO ZHEN(ZENNO)");
            _oMobileRetentionOrder.SetRetrieve_cnt(0);
            _oMobileRetentionOrder.SetOrd_place_by("FUNG HAU TSZ TELLY");
            _oMobileRetentionOrder.SetOrd_place_rel("sub");
            _oMobileRetentionOrder.SetOrd_place_hkid("G4871587");
            _oMobileRetentionOrder.SetOrd_place_id_type("HKID");
            _oMobileRetentionOrder.SetOrd_place_tel("68002899");
            _oMobileRetentionOrder.SetExist_cust_plan("MASS");
            _oMobileRetentionOrder.SetOrg_fee("US$198");
            _oMobileRetentionOrder.SetSpecial_approval("N");
            _oMobileRetentionOrder.SetOb_program_id("7364");
            _oMobileRetentionOrder.SetExisting_contract_end_date("Aug-10");
            _oMobileRetentionOrder.Save();
        }
    }
     */
}
