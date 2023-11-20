using System;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Text;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.SERIAL;
public partial class HelpTools_AORecordAssignDOAIMEI : System.Web.UI.Page
{
    EDFStatusProfile _oEDFStatusProfile = new EDFStatusProfile();
    OrderSerialNumberControl _oOrderSerialNumberControl = new OrderSerialNumberControl();

    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
        
    }

    protected void RemoveEDF(string x_sIMEI)
    {
        if (!string.IsNullOrEmpty(x_sIMEI))
        {
            string _sQuery = "SELECT DUMMY4 FROM IMEI_STOCK WHERE imei='" + x_sIMEI + "' AND status='STOCK'  and DUMMY2='CC RET' and COMPLETED_DATE='20100423'";
            OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(_sQuery);
            if (_oDr.Read())
            {
                Response.Write(x_sIMEI);
                Response.Write("<br>");
                int  _iRecord_id;
                if (int.TryParse(Func.FR(_oDr["DUMMY4"]), out _iRecord_id))
                {
                    string _sOrder_id = Func.IDSubtract100000(_iRecord_id);
                    string _sEdf = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar("SELECT edf_no FROM MobileRetentionOrder WHERE imei_no<>'' and  order_id='" + _sOrder_id + "'");
                    if (!_sEdf.Trim().Equals(string.Empty))
                    {
                        Response.Write(_sEdf);
                        Response.Write("<br>");
                        _oEDFStatusProfile.DeleteEDFRecord(_sEdf, Func.FR(_oDr["DUMMY4"]), " AND IMEI='" + x_sIMEI + "'");
                        string _sQuery1 = "UPDATE MobileRetentionOrder SET edf_no='' , imei_no='AO' WHERE order_id='" + _sOrder_id + "'";
                        bool _bUpdate1 = SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_sQuery1);
                    }
                }
            }
            _oDr.Close();
            _oDr.Dispose();
        }
    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        string _sSku = _oEDFStatusProfile.GetIMEISku(imei.Text.ToString().Trim(),"NORMAL");
        if (_sSku != string.Empty)
        {
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("SELECT mrt_no,order_id,'record_id'=order_id+100000 FROM MobileRetentionOrder WHERE (imei_no='AO' OR imei_no='AWAIT') AND hs_model<>'' AND hs_model is not null AND sku='" + _sSku + "' AND active=1 order by cdate asc");
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
            if (_oDr.Read())
            {
                string _sRecordID = Func.FR(_oDr["record_id"]);
                string _sOrder_id = Func.FR(_oDr["order_id"]);
                string _sMrt_no = Func.FR(_oDr["mrt_no"]);
                if (_oEDFStatusProfile.HaveAOIMEI_STOCK(_sRecordID, _sSku))
                {
                    Response.Write(_sRecordID);
                    Response.Write("<br>");
                    UpdateAssignEDF(_sOrder_id, _sRecordID, _sMrt_no,imei.Text.ToString(), _sSku);
                }
            }
            _oDr.Close();
            _oDr.Dispose();
        }
    }

    protected void UpdateAssignEDF(string _sOrder_id, string _sRecordID, string _sMrt_no, string _sIMEI, string _sSku)
    {
        int _iOrder_id;
        if (int.TryParse(_sOrder_id, out _iOrder_id))
        {
            string _sToday = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            string _sToday1 = DateTime.Now.ToString("yyyyMMdd");
            string _sTime1 = DateTime.Now.ToString("HH:mm:ss");

            string _sEDF = _oOrderSerialNumberControl.ReferenceNumber;
            //string _sQuery = "UPDATE MobileRetentionOrder SET edf_no='" + _sEDF + "' , imei_no='" + _sIMEI + "' WHERE order_id='" + _sOrder_id + "'";
            //bool _bUpdate1=SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_sQuery);
            string _sQuery = "UPDATE IMEI_Stock SET Status='STOCK', Dummy1='" + _sToday1 + "'  , DUMMY4='" + _sRecordID + "', ReferenceNo='" + _sRecordID + "', StaffNo='',Mobile_no='" + _sMrt_no + "' ,Completed_Date='" + _sToday1 + "'  WHERE IMEI='" + _sIMEI + "' AND Status='NORMAL'";
            bool _bUpdate2 = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_sQuery);
            _oEDFStatusProfile.DeleteAOAWAITIMEI(_sRecordID);
            InsertEDF(_iOrder_id);
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
            if (!"".Equals(_oMobileRetentionOrder.GetEdf_no()) && 
                _oMobileRetentionOrder.GetActive() == true)
            {
                if (_oMobileRetentionOrder.GetLog_date() != null)
                    _sToday = ((DateTime)_oMobileRetentionOrder.GetLog_date()).ToString("dd/MM/yyyy HH:mm:ss");

                if (_oMobileRetentionOrder.GetEdf_no()!=string.Empty)
                {
                    OdbcDataReader _oDr3 = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT referenceNo FROM sunday_Form WHERE CREATED_BY='CC RET' and Agree_no='" + Func.IDAdd100000(x_iOrder_id).ToString() + "' and cancelled='N' ");
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
                        _oQuery.Append("INSERT INTO sunday_Form (IMEI_2, SS_TO_PLG_DATE, referenceNo,Agree_no,create_date, staffNo, staffName,  SalesManCode, Extn, Sales_channel, Applicat_Date, Customer_name, Customer_ID_Type, Customer_ID, Mobile_no, Contact_no, User_Name, Order_Amt, Delivery_charge, E_delivery_date, E_Delivery_period, Dummy2, Dummy3, Remark,ItemCode, program,Rate_plan,contract_period,Plan_code,FG_Code,FG_IMEI0,FreeGift1,FG_Desc1,FG_IMEI1,FreeGift2,FG_Desc2,FG_IMEI2,FreeGift3,FG_Desc3,FG_IMEI3,FreeGift4,FG_Desc4,FG_IMEI4,CASH_AMT, ItemDesc, IMEI, TRADE, REBATE, HS_PAYMENT_TYPE, HS_CARD_NO, HS_C_HOLDER_NAME, HS_EXPIRYDATE, HS_PAY_AMT,COMPANY_NAME,VAS, doc_receive, cancelled,fo_to_sales, payment_status,create_s,to_plg,issue,pending,created_by,PEND_DOC,Premium_Gift,Contact_No_R,ament_counter");
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
                        _oQuery.Append(_oMobileRetentionOrder.GetCust_name().Trim().Replace("'", "`") + "','");
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
                        _oQuery.Append(_oMobileRetentionOrder.GetImei_no() + "','");
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
        return bFlag;
    }

    protected void FindNOAOEDF()
    {
        DateTime _oDateTime = DateTime.Now.AddDays(-1);
        DateTime _oPreDateTime = _oDateTime.AddDays(-200);
        RWLFramework.DataBaseConfigSetting();
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("SELECT order_id,edf_no,imei_no,hs_model,sku,cdate,d_date,active FROM MobileRetentionOrder WHERE ");
        _oQuery.Append("cdate>='" + _oPreDateTime.ToString("dd/MM/yyyy") + "' AND cdate<='" + _oDateTime.ToString("dd/MM/yyyy 23:59:59") + "' AND cdate is not null AND active=1 AND (sku is not null AND sku<>'') AND ");
        _oQuery.Append("hs_model<>'' AND hs_model is not null AND (imei_no='AO' or imei_no='AWAIT') AND imei_no is not null AND (edf_no='' AND edf_no is not null) ");

        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
        while (_oDr.Read())
        {
            int _iOrder_id;
            if (int.TryParse(Func.FR(_oDr["order_id"]), out _iOrder_id))
            {
                string _sRecordId = Func.IDAdd100000(_iOrder_id);
                MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect(), _iOrder_id);
                if (_oMobileRetentionOrder.GetFound() &&
                    !_oMobileRetentionOrder.GetSku().Trim().Equals(string.Empty) &&
                    !_oMobileRetentionOrder.GetHs_model().Trim().Equals(string.Empty) &&
                    _oMobileRetentionOrder.GetEdf_no().Trim().Equals(string.Empty) &&
                    !_oMobileRetentionOrder.GetImei_no().Trim().Equals(string.Empty))
                {
                    _oMobileRetentionOrder.SetImei_no("AO");
                    _oMobileRetentionOrder.Save();
                    string _sQuery1 = "SELECT DUMMY4 FROM IMEI_Stock WHERE Kit_Code='" + _oMobileRetentionOrder.GetSku().Trim() + "'  AND  DUMMY4='" + _sRecordId + "' AND (Status='STOCK' OR Status='AO' OR Status='AWAIT') AND Dummy2='CC RET' AND Dummy3='PLG' ";
                    OdbcDataReader _oDr2 = SYSConn<ODBCConnect>.Connect().GetSearch(_sQuery1);
                    if (!_oDr2.Read())
                    {
                        string _sQuery2 = "INSERT INTO IMEI_Stock (Kit_Code,Model,Status,DUMMY4,ReferenceNo,Create_Date,Create_By,StaffNo,Dummy2,Dummy3) VALUES ('" + _oMobileRetentionOrder.GetSku().Trim() + "','" + _oMobileRetentionOrder.GetHs_model().Trim() + "','AO','" + _sRecordId + "','" + _sRecordId + "',to_date('" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "' , 'dd/mm/yyyy hh24:mi:ss'),'" + _oMobileRetentionOrder.GetStaff_no().Trim() + "','" + _oMobileRetentionOrder.GetStaff_no().Trim() + "','CC RET','PLG') ";
                        bool _bInsertAO = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_sQuery2);
                    }
                    _oDr2.Close();
                    _oDr2.Dispose();
                }
            }
        }
        _oDr.Close();
        _oDr.Dispose();
    }





}
