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

public partial class HelpTool_InsertIPhoneOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();

        InsertAndCheckEDFRecord(358205);

        /*
        InsertAndCheckEDFRecord(268589);
        InsertAndCheckEDFRecord(275039);
        InsertAndCheckEDFRecord(278456);
        InsertAndCheckEDFRecord(278670);
        InsertAndCheckEDFRecord(286205);
        InsertAndCheckEDFRecord(286649);
        InsertAndCheckEDFRecord(286677);
        InsertAndCheckEDFRecord(286806);
        InsertAndCheckEDFRecord(287832);
        InsertAndCheckEDFRecord(290340);
        InsertAndCheckEDFRecord(292189);
        InsertAndCheckEDFRecord(292699);
        InsertAndCheckEDFRecord(295258);
        InsertAndCheckEDFRecord(296439);
        InsertAndCheckEDFRecord(296575);
        InsertAndCheckEDFRecord(297326);
        InsertAndCheckEDFRecord(297539);
        InsertAndCheckEDFRecord(297685);
        InsertAndCheckEDFRecord(297730);
        InsertAndCheckEDFRecord(297854);
        InsertAndCheckEDFRecord(298021);
        InsertAndCheckEDFRecord(298938);
        InsertAndCheckEDFRecord(298939);
        InsertAndCheckEDFRecord(298942);
        InsertAndCheckEDFRecord(299484);
        InsertAndCheckEDFRecord(300163);
        InsertAndCheckEDFRecord(300164);
        InsertAndCheckEDFRecord(300183);
        InsertAndCheckEDFRecord(300939);
        InsertAndCheckEDFRecord(302026);
        InsertAndCheckEDFRecord(303203);
        InsertAndCheckEDFRecord(304499);
        InsertAndCheckEDFRecord(304735);
        InsertAndCheckEDFRecord(305174);
        InsertAndCheckEDFRecord(309305);
        InsertAndCheckEDFRecord(312693);
        InsertAndCheckEDFRecord(312770);
        InsertAndCheckEDFRecord(312907);
        InsertAndCheckEDFRecord(312921);
        InsertAndCheckEDFRecord(313106);
        InsertAndCheckEDFRecord(313539);
        InsertAndCheckEDFRecord(314653);
        InsertAndCheckEDFRecord(315160);
        InsertAndCheckEDFRecord(315350);
        InsertAndCheckEDFRecord(320017);
        InsertAndCheckEDFRecord(336210);
        InsertAndCheckEDFRecord(336213);
        InsertAndCheckEDFRecord(336232);
        InsertAndCheckEDFRecord(336277);
        InsertAndCheckEDFRecord(336609);
        InsertAndCheckEDFRecord(336660);
        InsertAndCheckEDFRecord(336684);
        InsertAndCheckEDFRecord(336950);
        InsertAndCheckEDFRecord(336995);
        InsertAndCheckEDFRecord(337019);
        InsertAndCheckEDFRecord(337140);
        InsertAndCheckEDFRecord(337438);
        InsertAndCheckEDFRecord(337447);
        InsertAndCheckEDFRecord(337478);
        InsertAndCheckEDFRecord(337603);
        InsertAndCheckEDFRecord(337607);
        InsertAndCheckEDFRecord(337787);
        InsertAndCheckEDFRecord(337834);
        InsertAndCheckEDFRecord(337836);
        InsertAndCheckEDFRecord(337993);
        InsertAndCheckEDFRecord(337996);
        InsertAndCheckEDFRecord(338004);
        InsertAndCheckEDFRecord(338023);
        InsertAndCheckEDFRecord(338043);
        InsertAndCheckEDFRecord(338116);
        InsertAndCheckEDFRecord(338139);
        InsertAndCheckEDFRecord(338257);
        InsertAndCheckEDFRecord(338284);
        InsertAndCheckEDFRecord(338326);
        InsertAndCheckEDFRecord(338340);
        InsertAndCheckEDFRecord(338588);
        InsertAndCheckEDFRecord(338610);
        InsertAndCheckEDFRecord(338855);
        InsertAndCheckEDFRecord(338866);
        InsertAndCheckEDFRecord(339086);
        InsertAndCheckEDFRecord(339111);
        InsertAndCheckEDFRecord(339116);
        InsertAndCheckEDFRecord(339256);
        InsertAndCheckEDFRecord(339283);
        InsertAndCheckEDFRecord(339389);
        InsertAndCheckEDFRecord(339418);
        InsertAndCheckEDFRecord(339587);
        InsertAndCheckEDFRecord(340082);
        InsertAndCheckEDFRecord(340266);
        InsertAndCheckEDFRecord(340465);
        InsertAndCheckEDFRecord(340473);
        InsertAndCheckEDFRecord(340621);
        InsertAndCheckEDFRecord(341056);
        InsertAndCheckEDFRecord(341129);
        InsertAndCheckEDFRecord(341621);
        InsertAndCheckEDFRecord(341725);
        InsertAndCheckEDFRecord(341726);
        InsertAndCheckEDFRecord(341801);
        InsertAndCheckEDFRecord(341926);
        InsertAndCheckEDFRecord(342007);
        InsertAndCheckEDFRecord(342015);
        InsertAndCheckEDFRecord(342032);
        InsertAndCheckEDFRecord(342484);
        InsertAndCheckEDFRecord(342520);
        InsertAndCheckEDFRecord(342540);
        InsertAndCheckEDFRecord(342580);
        InsertAndCheckEDFRecord(342612);
        InsertAndCheckEDFRecord(342730);
        InsertAndCheckEDFRecord(342759);
        InsertAndCheckEDFRecord(342806);
        InsertAndCheckEDFRecord(342824);
        InsertAndCheckEDFRecord(342869);
        InsertAndCheckEDFRecord(342882);
        InsertAndCheckEDFRecord(342886);
        InsertAndCheckEDFRecord(343001);
        InsertAndCheckEDFRecord(343025);
        InsertAndCheckEDFRecord(343110);
        InsertAndCheckEDFRecord(343120);
        InsertAndCheckEDFRecord(343207);
        InsertAndCheckEDFRecord(343217);
        InsertAndCheckEDFRecord(343288);
        InsertAndCheckEDFRecord(343335);
        InsertAndCheckEDFRecord(343353);
        InsertAndCheckEDFRecord(343362);
        InsertAndCheckEDFRecord(343390);
        InsertAndCheckEDFRecord(343449);
        InsertAndCheckEDFRecord(343451);
        InsertAndCheckEDFRecord(343514);
        InsertAndCheckEDFRecord(343608);
        InsertAndCheckEDFRecord(343618);
        InsertAndCheckEDFRecord(343664);
        InsertAndCheckEDFRecord(343673);
        InsertAndCheckEDFRecord(343683);
        InsertAndCheckEDFRecord(343692);
        InsertAndCheckEDFRecord(343696);
        InsertAndCheckEDFRecord(343780);
        InsertAndCheckEDFRecord(343825);
        InsertAndCheckEDFRecord(343885);
        InsertAndCheckEDFRecord(343892);
        InsertAndCheckEDFRecord(344085);
        InsertAndCheckEDFRecord(344093);
        InsertAndCheckEDFRecord(344105);
        InsertAndCheckEDFRecord(344125);
        InsertAndCheckEDFRecord(344162);
        InsertAndCheckEDFRecord(344172);
        InsertAndCheckEDFRecord(344188);
        InsertAndCheckEDFRecord(344198);
        InsertAndCheckEDFRecord(344364);
        InsertAndCheckEDFRecord(344503);
        InsertAndCheckEDFRecord(344635);
        InsertAndCheckEDFRecord(344637);
        InsertAndCheckEDFRecord(344734);
        InsertAndCheckEDFRecord(344775);
        InsertAndCheckEDFRecord(344803);
        InsertAndCheckEDFRecord(344804);
        InsertAndCheckEDFRecord(344847);
        InsertAndCheckEDFRecord(344866);
        InsertAndCheckEDFRecord(344944);
        InsertAndCheckEDFRecord(345121);
        InsertAndCheckEDFRecord(345189);
        InsertAndCheckEDFRecord(345222);
        InsertAndCheckEDFRecord(345236);
        InsertAndCheckEDFRecord(345264);
        InsertAndCheckEDFRecord(345270);
        InsertAndCheckEDFRecord(345371);
        InsertAndCheckEDFRecord(345494);
        InsertAndCheckEDFRecord(345511);
        InsertAndCheckEDFRecord(345622);
        InsertAndCheckEDFRecord(345685);
        InsertAndCheckEDFRecord(345980);
        InsertAndCheckEDFRecord(346130);
        InsertAndCheckEDFRecord(346403);
        InsertAndCheckEDFRecord(346983);
        InsertAndCheckEDFRecord(347994);
        InsertAndCheckEDFRecord(350511);
        InsertAndCheckEDFRecord(350879);
        InsertAndCheckEDFRecord(351642);
        InsertAndCheckEDFRecord(352977);
        */
    }


    protected void InsertAndCheckEDFRecord(int x_iOrder_id)
    {
        if (InsertEDF(x_iOrder_id))
        {
            Response.Write(x_iOrder_id.ToString() + "  Success!<BR>");
        }
        else
        {
            Response.Write(x_iOrder_id.ToString() + "  FAIL!<BR>");
        }
    }

    protected void Search()
    {


    }

    private string GetEdf()
    {
        string _sEDF = string.Empty;
        bool _bFlag = true;
        int _iTime = 10;
        while (_bFlag && _iTime > 0)
        {
            _sEDF = GenEdf();
            if (!CheckEdfNoInDB(_sEDF))
            {
                _bFlag = false;
            }
            _iTime -= 1;
        }
        return _sEDF;
    }

    private string GenEdf()
    {
        string _sRefNo = string.Empty;
        global::System.Data.Odbc.OdbcDataReader _oDr3 = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT SUNDAY_R1_Serial.NextVal as seq, to_char(sysdate, 'yymon') as cdate FROM dual");
        if (_oDr3.Read())
        {
            //=== get EDF# ===
            _sRefNo = Func.Right(Func.IDAdd100000(Convert.ToInt32(Func.FR(_oDr3["seq"]).Trim())), 5) + "/HR" + Func.FR(_oDr3["cdate"]).Trim().ToUpper();
        }
        _oDr3.Close();
        _oDr3.Dispose();
        return _sRefNo;
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

                _oMobileRetentionOrder.SetEdf_no(GetEdf());
                _oMobileRetentionOrder.Save();

                    _oMobileRetentionOrder.SetImei_no("AWAIT");
                    _oMobileRetentionOrder.Save();

                    bool _oUpdateImeiStock =
                    SYSConn<ODBCConnect>
                    .Connect()
                    .ExplicitNonQuery("UPDATE IMEI_STOCK SET REFERENCENO='" + _oMobileRetentionOrder.GetEdf_no() + "', STATUS='AWAIT' WHERE DUMMY4='" + Func.IDAdd100000(x_iOrder_id) + "' AND STATUS='AO' AND KIT_CODE='" + _oMobileRetentionOrder.GetSku() + "' AND ROWNUM<=1");


                Response.Write(x_iOrder_id.ToString() + " No EDF<br>");
            }
            else
            {
                /*
                if (_oMobileRetentionOrder.GetImei_no() == "AWAIT" ||
                    _oMobileRetentionOrder.GetImei_no() == "AO" ||
                    _oMobileRetentionOrder.GetImei_no()=="")
                {
                    bool _oUpdateEDFIMEI =
                           SYSConn<ODBCConnect>
                           .Connect()
                           .ExplicitNonQuery("UPDATE SUNDAY_FORM SET IMEI='' WHERE REFERENCENO='" + _oMobileRetentionOrder.GetEdf_no() + "' AND Created_by='CC RET' AND rownum<=1'");

                    bool _oUpdateImeiStock =
                    SYSConn<ODBCConnect>
                    .Connect()
                    .ExplicitNonQuery("UPDATE IMEI_STOCK SET REFERENCENO='" + _oMobileRetentionOrder.GetEdf_no() + "', STATUS='AWAIT' WHERE DUMMY4='" + Func.IDAdd100000(x_iOrder_id) + "' AND STATUS='AO' AND KIT_CODE='" + _oMobileRetentionOrder.GetSku() + "' AND ROWNUM<=1");
                }
                */
            }

            if (_oMobileRetentionOrder.GetImei_no().Equals("AWAIT") &&
                _oMobileRetentionOrder.GetActive() == true)
            {

                OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT STATUS,IMEI FROM IMEI_STOCK WHERE STATUS='STOCK' and  referenceno='" + _oMobileRetentionOrder.GetEdf_no() + "' ");
                if (_oDr.Read())
                {
                    CancelAOAWAIT(x_iOrder_id);
                }
                _oDr.Close();
                _oDr.Dispose();
                
                //CancelAOAWAIT(x_iOrder_id);
                //AllowInsertAWAITIMEI(x_iOrder_id);
            }
            else
            {
               // CancelAOAWAIT(x_iOrder_id);
            }

            #region have STOCK
            if (!"".Equals(_oMobileRetentionOrder.GetEdf_no()))
            {
                if (_oMobileRetentionOrder.GetLog_date() != null)
                    _sToday = ((DateTime)_oMobileRetentionOrder.GetLog_date()).ToString("dd/MM/yyyy HH:mm:ss");

                if (AllowInsertEDFIMEI(_oMobileRetentionOrder.GetEdf_no()))
                {
                    OdbcDataReader _oDr3 = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT referenceNo FROM sunday_Form WHERE referenceNo='" + _oMobileRetentionOrder.GetEdf_no() + "' AND CREATED_BY='CC RET' and Agree_no='" + Func.IDAdd100000(x_iOrder_id).ToString() + "'  ");
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
                        if (!_oMobileRetentionOrder.GetImei_no().Equals("AWAIT"))
                            _oQuery.Append(_oMobileRetentionOrder.GetImei_no() + "','");
                        else
                            _oQuery.Append("','");

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
                        _oQuery.Append("'N','" + ((_oMobileRetentionOrder.GetActive() == true) ? "N" : "Y") + "','N','PNS','N','N','N','N','CC RET','EORDER',");

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
                        if (_oMobileRetentionOrder.GetSim_item_number().Trim() != "AO")
                        {
                            _oQuery.Append("''");
                        }
                        else
                        {
                            _oQuery.Append("''");
                        }

                        _oQuery.Append(")");

                        bFlag = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery.ToString());
                        if (_oMobileRetentionOrder.GetEdf_no() != "")
                        {
                            bFlag = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("UPDATE sunday_form SET created_by='CC RET' where referenceno='" + _oMobileRetentionOrder.GetEdf_no() + "'");
                        }
                        #endregion
                        bool _bUpdate = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("UPDATE IMEI_Stock SET ReferenceNo='" + _oMobileRetentionOrder.GetEdf_no() + "' WHERE Dummy2='CC RET' AND DUMMY4='" + Func.IDAdd100000(_oMobileRetentionOrder.GetOrder_id()) + "'");
                    }
                    _oDr3.Close();
                    _oDr3.Dispose();
                }
            }
            #endregion
 
        }

        Response.Write("EDF:" + _oMobileRetentionOrder.GetEdf_no().Trim() + "<br>");

        return bFlag;
    }

    public bool AllowInsertEDFIMEI(string x_sEDF)
    {


        if (string.IsNullOrEmpty(x_sEDF)) return false;

        x_sEDF = x_sEDF.Trim();


        OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT referenceNo,  imei FROM sunday_Form  WHERE  referenceNo='" + x_sEDF + "' AND cancelled='N' AND rownum<=1");
        if (!_oDr.Read())
        {
            _oDr.Close();
            _oDr.Dispose();
            return true;
        }
        _oDr.Close();
        _oDr.Dispose();


        return false;
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

    protected void CancelAOAWAIT(int _iOrder_id)
    {
        MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect(), _iOrder_id);
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("UPDATE IMEI_STOCK SET STATUS='CANCEL' WHERE ");
        _oQuery.Append(" Kit_Code='" + _oMobileRetentionOrder.GetSku() + "'  ");
        _oQuery.Append(" AND DUMMY4='" + Func.IDAdd100000(_iOrder_id) + "' ");
        //_oQuery.Append(" AND ReferenceNo='" + _oMobileRetentionOrder.GetEdf_no() + "' ");
        _oQuery.Append(" AND Dummy2='CC RET' AND (STATUS='AWAIT' OR STATUS='AO') ");
        _oQuery.Append(" AND ROWNUM<=1");
        bool _bCancel=SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery.ToString());
    }

    protected void AllowInsertAWAITIMEI(int _iOrder_id)
    {

        string n_sToday1 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect(), _iOrder_id);
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("SELECT IMEI FROM IMEI_STOCK WHERE ");
        _oQuery.Append(" Kit_Code='" + _oMobileRetentionOrder.GetSku() + "'  ");
        _oQuery.Append(" AND (Status='AWAIT' or Status='STOCK') ");
        _oQuery.Append(" AND DUMMY4='" + Func.IDAdd100000(_iOrder_id) + "' ");
        _oQuery.Append(" AND ReferenceNo='" + _oMobileRetentionOrder.GetEdf_no() + "' ");
        _oQuery.Append(" AND Dummy2='CC RET' ");
        OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(_oQuery.ToString());
        if (!_oDr.Read())
        {
            if (SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("INSERT into IMEI_Stock (Kit_Code,Model,Status,DUMMY4,ReferenceNo,Create_Date,Create_By,StaffNo,Dummy2,Dummy3) values ('" + _oMobileRetentionOrder.GetSku() + "','" + _oMobileRetentionOrder.GetHs_model() + "','AWAIT','" + Func.IDAdd100000(_iOrder_id) + "','" + _oMobileRetentionOrder.GetEdf_no() + "',to_date('" + n_sToday1 + "' , 'dd/mm/yyyy hh24:mi:ss'),'" + _oMobileRetentionOrder.GetStaff_no() + "','" + _oMobileRetentionOrder.GetStaff_no() + "','CC RET','"+_oMobileRetentionOrder.GetDelivery_exchange_location()+"' ) "))
            {
                //RunJavascriptFunc("alert('Insert Success!')", true);
                Response.Write("Insert AWAIT success!<br>");
            }
        }
        _oDr.Close();
        _oDr.Dispose();
    }

    protected bool CheckEdfNoInDB(string x_sEdfNo)
    {
        if (string.IsNullOrEmpty(x_sEdfNo)) return false;
        x_sEdfNo = x_sEdfNo.Trim();
        OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(" SELECT referenceNo FROM sunday_Form  WHERE referenceNo='" + x_sEdfNo + "' AND rownum<=1");
        if (_oDr.Read())
        {
            if (!Func.FR(_oDr["referenceNo"]).Trim().Equals(string.Empty))
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
}
