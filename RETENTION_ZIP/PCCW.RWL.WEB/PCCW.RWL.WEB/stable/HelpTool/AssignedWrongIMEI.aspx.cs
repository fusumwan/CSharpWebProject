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

public partial class HelpTools_AssignedWrongIMEI : System.Web.UI.Page
{
    bool RunUpdateSQL = false;
    EDFStatusProfile _oEDFStatusProfile = new EDFStatusProfile();
OrderSerialNumberControl _oOrderSerialNumberControl = new OrderSerialNumberControl();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
        //AssignIMEINoStockOutD();
        AssignIMEINotInImeiStock();
    }

    public void AssignIMEINotInImeiStock()
    {
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("SELECT order_id+100000 as 'record_id',edf_no,imei_no,log_date,d_date FROM MobileRetentionOrder WHERE active=1 AND hs_model<>'' AND hs_model is not null AND (imei_no is not null or imei_no<>'') AND (edf_no is not null or edf_no<>'') AND ");
        _oQuery.Append("log_date >='13/3/2010 23:59:59'");
        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
        while (_oDr.Read())
        {
            if (Func.FR(_oDr["imei_no"]).Trim() != string.Empty &&
                Func.FR(_oDr["imei_no"]).Trim()!="AO" &&
                Func.FR(_oDr["imei_no"]).Trim()!="AWAIT")
            {
                OdbcDataReader _oImeiStockDr = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT IMEI FROM IMEI_STOCK WHERE IMEI='" + Func.FR(_oDr["imei_no"]).Trim() + "'");
                if (!_oImeiStockDr.Read())
                {
                    _oImeiStockDr.Close();
                    _oImeiStockDr.Dispose();
                    Response.Write("Cannot Find IMEI in IMEI_STOCK : " + Func.FR(_oDr["imei_no"]).Trim() + "<br>");
                }
                _oImeiStockDr.Close();
                _oImeiStockDr.Dispose();
            }
        }
        _oDr.Close();
        _oDr.Dispose();
    }

    public void AssignIMEINoStockOutD()
    {
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("SELECT order_id+100000 as 'record_id',order_id,hs_model,sku,edf_no,imei_no,log_date,d_date FROM MobileRetentionOrder WHERE active=1 AND hs_model<>'' AND hs_model is not null AND (imei_no is not null or imei_no<>'') AND (edf_no is not null or edf_no<>'') AND ");
        _oQuery.Append("log_date >='13/5/2010 23:59:59'");
        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
        while (_oDr.Read())
        {
            if (Func.FR(_oDr["imei_no"]).Trim() != string.Empty &&
                Func.FR(_oDr["imei_no"]).Trim() != "AO" &&
                Func.FR(_oDr["imei_no"]).Trim() != "AWAIT")
            {
                OdbcDataReader _oImeiStockDr = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT IMEI,DUMMY4,mobile_no,ReferenceNo,Status,KIT_CODE,MODEL FROM IMEI_STOCK WHERE IMEI='" + Func.FR(_oDr["imei_no"]).Trim() + "' and (DUMMY4 is null or DUMMY4=' ' ) ");

                int _iRow = 0;
                if (_oImeiStockDr.Read())
                {
                    _iRow += 1;
                    Response.Write("======================" + _iRow.ToString() + "==========================<br>");
                    Response.Write("WEB LOG => EDF: " + Func.FR(_oDr["edf_no"]) + "<br>");
                    Response.Write("WEB LOG => RECORDID: " + Func.FR(_oDr["record_id"]) + "<br>");
                    Response.Write("WEB LOG => ORDERID: " + Func.FR(_oDr["order_id"]) + "<br>");
                    Response.Write("WEB LOG => IMEI: " + Func.FR(_oDr["imei_no"]) + "<br>");
                    Response.Write("WEB LOG => SKU: " + Func.FR(_oDr["sku"]) + "<br>");
                    Response.Write("WEB LOG => MODEL: " + Func.FR(_oDr["hs_model"]) + "<br>");
                    Response.Write("<br>");
                    Response.Write("IMEI STOCK => REFERENCE NO:" + Func.FR(_oImeiStockDr["ReferenceNo"]) + "<br>");
                    Response.Write("IMEI STOCK => DUMMY4:" + Func.FR(_oImeiStockDr["DUMMY4"]) + "<br>");
                    Response.Write("IMEI STOCK => STATUS:" + Func.FR(_oImeiStockDr["Status"]) + "<br>");
                    Response.Write("IMEI STOCK => IMEI:" + Func.FR(_oImeiStockDr["IMEI"]) + "<br>");
                    Response.Write("IMEI STOCK => KIT_CODE:" + Func.FR(_oImeiStockDr["KIT_CODE"]) + "<br>");
                    Response.Write("IMEI STOCK => MODEL:" + Func.FR(_oImeiStockDr["MODEL"]) + "<br>");
                    Response.Write("<br>");
                    string _sSunSelect = "SELECT agree_no,ReferenceNo,imei,itemcode,itemdesc,ACTUAL_DEL_DATE FROM sunday_form WHERE cancelled='N' and ReferenceNo='" + Func.FR(_oDr["edf_no"]) + "' ";
                    OdbcDataReader _oSunDr1 = SYSConn<ODBCConnect>.Connect().GetSearch(_sSunSelect);
                    if (_oSunDr1.Read())
                    {
                        Response.Write("EDF FORM => REFERENCE NO:" + Func.FR(_oSunDr1["ReferenceNo"]) + "<br>");
                        Response.Write("EDF FORM => RECORDID:" + Func.FR(_oSunDr1["agree_no"]) + "<br>");
                        Response.Write("EDF FORM  => IMEI:" + Func.FR(_oSunDr1["IMEI"]) + "<br>");
                        Response.Write("EDF FORM  => ITEM CODE:" + Func.FR(_oSunDr1["itemcode"]) + "<br>");
                        Response.Write("EDF FORM  => MODEL:" + Func.FR(_oSunDr1["itemdesc"]) + "<br>");
                        try
                        {
                            Response.Write("EDF FORM => DELIVERY DATE : " + ((_oSunDr1["ACTUAL_DEL_DATE"] != null) ? (((DateTime)((global::System.Nullable<DateTime>)_oSunDr1["ACTUAL_DEL_DATE"]))).ToString("dd/MM/yyyy") : "") + "<br>");
                        }
                        catch (Exception exp)
                        {
                            Response.Write("EDF FORM => DELIVERY DATE : <br>");
                        }
                    }
                    _oSunDr1.Close();
                    _oSunDr1.Dispose();
                    Response.Write("<br>");
                    Response.Write("================================================<br>");
                }
                _oImeiStockDr.Close();
                _oImeiStockDr.Dispose();
            }
        }
        _oDr.Close();
        _oDr.Dispose();
    }


    #region IN_AO_CASE_PAGE
    public void IN_AO_CASE_PAGE()
    {
        string n_sToday = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        string n_sToday1 = DateTime.Now.ToString("yyyyMMdd");
        string n_sTime1 = DateTime.Now.AddMinutes(-10).ToString("HH:mm:ss");
        int _iHour = Convert.ToInt32(DateTime.Now.AddMinutes(-10).ToString("HH"));
        int _iMinute = Convert.ToInt32(DateTime.Now.AddMinutes(-10).ToString("mm"));
        int _iSecond = Convert.ToInt32(DateTime.Now.AddMinutes(-10).ToString("ss"));

        string _sQuery = "SELECT IMEI_Stock.DUMMY4,IMEI_Stock.KIT_CODE, IMEI_Stock.MODEL MODEL,IMEI_Stock.ReferenceNo,IMEI_Stock.IMEI,IMEI_Stock.Status  FROM IMEI_Stock left join sunday_form SUNDAY_form on IMEI_Stock.DUMMY4 =  SUNDAY_form.agree_no  WHERE IMEI_Stock.Dummy2='CC RET' AND ";
        _sQuery += " (IMEI_Stock.Status='AO' or IMEI_Stock.Status='AWAIT' or IMEI_Stock.Status='STOCK') AND (IMEI_Stock.Status is not null AND IMEI_Stock.Status<>' ') AND IMEI_Stock.MODEL<>' ' AND IMEI_Stock.MODEL is not null   ";
        _sQuery += " AND IMEI_Stock.IMEI  not like '%FG%' ";
        _sQuery += " AND IMEI_Stock.ReferenceNo is not null AND (SUNDAY_form.Cancelled ='N' or SUNDAY_form.Cancelled is null) and IMEI_Stock.DUMMY4 is not null ORDER BY IMEI_Stock.DUMMY4  ";
        global::System.Data.Odbc.OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(_sQuery);

        int _iRow = 0;
        while (_oDr.Read())
        {

            int _iRecordID;
            if (int.TryParse(Func.FR(_oDr["DUMMY4"]), out _iRecordID))
            {
                int _iOrderId = _iRecordID - 100000;
                MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect(), _iOrderId);
                if (_oMobileRetentionOrder.GetOrder_id() != null &&
                    _oMobileRetentionOrder.GetImei_no().Trim() != string.Empty &&
                    _oMobileRetentionOrder.GetImei_no().ToUpper().Trim() != "AWAIT" &&
                    _oMobileRetentionOrder.GetImei_no().ToUpper().Trim() != "AO" && 
                    _oMobileRetentionOrder.GetImei_no().ToUpper().Trim() !=Func.FR(_oDr["IMEI"]) && 
                    _oMobileRetentionOrder.GetEdf_no() != string.Empty)
                {
                    _iRow += 1;
                    Response.Write("======================" + _iRow.ToString() + "==========================<br>");
                    Response.Write("WEB LOG => EDF: " + _oMobileRetentionOrder.GetEdf_no() + "<br>");
                    Response.Write("WEB LOG => RECORDID: " + _iRecordID.ToString() + "<br>");
                    Response.Write("WEB LOG => ORDERID: " + _iOrderId.ToString() + "<br>");
                    Response.Write("WEB LOG => IMEI: " + _oMobileRetentionOrder.GetImei_no() + "<br>");
                    Response.Write("WEB LOG => SKU: " + _oMobileRetentionOrder.GetSku() + "<br>");
                    Response.Write("WEB LOG => MODEL: " + _oMobileRetentionOrder.GetHs_model() + "<br>");
                    Response.Write("<br>");
                    Response.Write("IMEI STOCK => REFERENCE NO:" + Func.FR(_oDr["ReferenceNo"]) + "<br>");
                    Response.Write("IMEI STOCK => DUMMY4:" + Func.FR(_oDr["DUMMY4"]) + "<br>");
                    Response.Write("IMEI STOCK => STATUS:" + Func.FR(_oDr["Status"]) + "<br>");
                    Response.Write("IMEI STOCK => IMEI:" + Func.FR(_oDr["IMEI"]) + "<br>");
                    Response.Write("IMEI STOCK => KIT_CODE:" + Func.FR(_oDr["KIT_CODE"]) + "<br>");
                    Response.Write("IMEI STOCK => MODEL:" + Func.FR(_oDr["MODEL"]) + "<br>");
                    Response.Write("<br>");
                    string _sSunSelect = "SELECT agree_no,ReferenceNo,imei,itemcode,itemdesc,ACTUAL_DEL_DATE FROM sunday_form WHERE cancelled='N' and ReferenceNo='" + _oMobileRetentionOrder.GetEdf_no() + "' ";
                    OdbcDataReader _oSunDr1 = SYSConn<ODBCConnect>.Connect().GetSearch(_sSunSelect);
                    if (_oSunDr1.Read())
                    {
                        Response.Write("EDF FORM => REFERENCE NO:" + Func.FR(_oSunDr1["ReferenceNo"]) + "<br>");
                        Response.Write("EDF FORM => RECORDID:" + Func.FR(_oSunDr1["agree_no"]) + "<br>");
                        Response.Write("EDF FORM  => IMEI:" + Func.FR(_oSunDr1["IMEI"]) + "<br>");
                        Response.Write("EDF FORM  => ITEM CODE:" + Func.FR(_oSunDr1["itemcode"]) + "<br>");
                        Response.Write("EDF FORM  => MODEL:" + Func.FR(_oSunDr1["itemdesc"]) + "<br>");
                        try
                        {
                            Response.Write("EDF FORM => DELIVERY DATE : " + ((_oSunDr1["ACTUAL_DEL_DATE"] != null) ? (((DateTime)((global::System.Nullable<DateTime>)_oSunDr1["ACTUAL_DEL_DATE"]))).ToString("dd/MM/yyyy") : "") + "<br>");
                        }
                        catch (Exception exp)
                        {
                            Response.Write("EDF FORM => DELIVERY DATE : <br>");
                        }
                    }
                    _oSunDr1.Close();
                    _oSunDr1.Dispose();


                   // Response.Write("===========SQL============<br>");
                    /*
                    bool _bSunSelectChecking = false;
                    string _sSunSelect = "SELECT agree_no,ReferenceNo,imei,itemcode FROM sunday_form WHERE cancelled='N' and ReferenceNo='" + Func.FR(_oDr["ReferenceNo"]) + "' ";
                    OdbcDataReader _oSunDr = SYSConn<ODBCConnect>.Connect().GetSearch(_sSunSelect);
                    if (_oSunDr.Read())
                    {
                        string _sAgree_no = Func.FR(_oSunDr["agree_no"]).Trim();
                        string _sReferenceNo = Func.FR(_oSunDr["ReferenceNo"]).Trim();
                        string _sImei = Func.FR(_oSunDr["Imei"]).Trim();
                        string _sItemCode = Func.FR(_oSunDr["itemcode"]).Trim();
                        int _iCheckRecordid;
                        if(int.TryParse(_sAgree_no,out _iCheckRecordid)){
                            MobileRetentionOrder _oCheckMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect(), _iCheckRecordid-100000);

                            if (Func.IDAdd100000(_oCheckMobileRetentionOrder.GetOrder_id()).ToString().Equals(_sAgree_no) &&
                                _sReferenceNo.Equals(_oCheckMobileRetentionOrder.GetEdf_no()) &&
                                _sImei.Equals(_oCheckMobileRetentionOrder.GetImei_no()) &&
                                _sItemCode.Equals(_oCheckMobileRetentionOrder.GetSku()))
                            {
                                if (!UseIMEIInSundayForm(Func.FR(_oDr["IMEI"])))
                                {
                                    IMEIRelease(Func.FR(_oDr["IMEI"]).Trim(), Func.FR(_oDr["KIT_CODE"]), Func.FR(_oDr["Status"]));

                                }
                            }
                        }
                    }
                    _oSunDr.Close();
                    _oSunDr.Dispose();
                    */
                    Response.Write("================================================<br>");
                }
            }
        }
        _oDr.Close();
        _oDr.Dispose();

    }

    public bool UseIMEIInSundayForm(string x_sImei)
    {
        if (string.IsNullOrEmpty(x_sImei)) return false;
        string _sQuery = "SELECT IMEI FROM Sunday_form WHERE IMEI='"+x_sImei+"' AND cancelled='N'";
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


    public  bool RWL_EDFIMEIRelease(string x_sOrder_id)
    {
        if (x_sOrder_id.Equals(string.Empty)) return false;
        string _sQuery9 = "UPDATE " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder SET ";
        _sQuery9 += " edf_no='', ";
        _sQuery9 += " imei_no='' ";
        _sQuery9 += " where order_id='" + x_sOrder_id + "'";

        Response.Write(_sQuery9+"<br>");
        if (RunUpdateSQL)
        {
            return SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_sQuery9);
        }
        return false;
    }


    public bool IMEIRelease(string x_sIMEI)
    {
        if (string.IsNullOrEmpty(x_sIMEI)) return false;
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("UPDATE imei_stock SET referenceno='', status='NORMAL', staff_recd='', DUMMY4='', dummy1='' ");
        _oQuery.Append("WHERE imei='" + x_sIMEI + "' AND status='SOLD' AND dummy2='CC RET' AND rownum<=1");

        Response.Write(_oQuery.ToString() + "<br>");
        if (RunUpdateSQL)
        {
            bool _bReleaseIMEI = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery.ToString());
            return _bReleaseIMEI;
        }
        return false;
    }

    public bool IMEIRelease(string x_sIMEI, string x_sKIT_CODE)
    {
        if (string.IsNullOrEmpty(x_sIMEI)) return false;
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("UPDATE imei_stock SET referenceno='', status='NORMAL', staff_recd='', DUMMY4='', dummy1='' ");
        _oQuery.Append("WHERE imei='" + x_sIMEI + "' AND kit_code='" + x_sKIT_CODE + "' AND status='SOLD' AND dummy2='CC RET' AND rownum<=1");

        Response.Write(_oQuery.ToString() + "<br>");
        if (RunUpdateSQL)
        {
            bool _bReleaseIMEI = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery.ToString());
            return _bReleaseIMEI;
        }
        return false;
    }

    public bool IMEIRelease(string x_sIMEI, string x_sKIT_CODE, string x_sStatus)
    {
        if (string.IsNullOrEmpty(x_sIMEI)) return false;
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("UPDATE imei_stock SET referenceno='', status='NORMAL', staff_recd='', DUMMY4='', dummy1='' ");
        _oQuery.Append("WHERE imei='" + x_sIMEI + "' AND kit_code='" + x_sKIT_CODE + "' AND status='" + x_sStatus + "' AND dummy2='CC RET' AND rownum<=1");

        Response.Write(_oQuery.ToString() + "<br>");
        if (RunUpdateSQL)
        {
            bool _bReleaseIMEI = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery.ToString());
            return _bReleaseIMEI;
        }
        return false;
    }

    #endregion IN_AO_CASE_PAGE
}
