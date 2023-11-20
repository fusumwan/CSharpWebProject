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


public partial class HelpTools_FindAssigedIMEIButSTOCKCase : System.Web.UI.Page
{
    bool RunUpdateSQL = false;
    bool ShowSQL = false;
    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
        if (!IsPostBack) { InitFrame(); }
    }

    protected void InitFrame()
    {
        int _iDay = 0;
        string n_sToday = DateTime.Now.AddDays(_iDay).ToString("dd/MM/yyyy HH:mm:ss");
        string n_sToday1 = DateTime.Now.AddDays(_iDay).ToString("yyyyMMdd");
        string n_sTime1 = DateTime.Now.AddMinutes(-30).ToString("HH:mm:ss");
        int _iHour = Convert.ToInt32(DateTime.Now.AddMinutes(-30).ToString("HH"));
        int _iMinute = Convert.ToInt32(DateTime.Now.AddMinutes(-30).ToString("mm"));
        int _iSecond = Convert.ToInt32(DateTime.Now.AddMinutes(-30).ToString("ss"));

        string _sQuery = "SELECT IMEI_Stock.DUMMY4,IMEI_Stock.KIT_CODE, IMEI_Stock.MODEL MODEL,IMEI_Stock.ReferenceNo,IMEI_Stock.IMEI,IMEI_Stock.Status  FROM IMEI_Stock left join sunday_form SUNDAY_form on IMEI_Stock.DUMMY4 =  SUNDAY_form.agree_no  WHERE IMEI_Stock.Dummy2='CC RET' AND ";
        _sQuery += " (IMEI_Stock.Status='AO' or IMEI_Stock.Status='AWAIT' or IMEI_Stock.Status='STOCK') AND (IMEI_Stock.Status is not null AND IMEI_Stock.Status<>' ') AND IMEI_Stock.MODEL<>' ' AND IMEI_Stock.MODEL is not null   ";
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
                    _oMobileRetentionOrder.GetImei_no() != string.Empty && 
                    _oMobileRetentionOrder.GetImei_no().ToUpper() != "AWAIT" && 
                    _oMobileRetentionOrder.GetImei_no().ToUpper() != "AO" && 
                    _oMobileRetentionOrder.GetEdf_no() != string.Empty)
                {
                    _iRow += 1;
                    Response.Write("=========" + _iRow.ToString() + "===============<br>");
                    Response.Write("WEB LOG => RECORDID: " + _iRecordID.ToString() + "<br>");
                    Response.Write("WEB LOG => ORDERID: " + _iOrderId.ToString() + "<br>");
                    Response.Write("WEB LOG => EDF: " + _oMobileRetentionOrder.GetEdf_no() + "<br>");
                    Response.Write("WEB LOG => IMEI: " + _oMobileRetentionOrder.GetImei_no() + "<br>");
                    Response.Write("WEB LOG => SKU: " + _oMobileRetentionOrder.GetSku() + "<br>");
                    Response.Write("WEB LOG => HS_MODEL: " + _oMobileRetentionOrder.GetHs_model() + "<br>");
                    Response.Write("<br>");
                    Response.Write("IMEI STOCK => REFERENCE NO:" + Func.FR(_oDr["ReferenceNo"]) + "<br>");
                    Response.Write("IMEI STOCK => DUMMY4:" + Func.FR(_oDr["DUMMY4"]) + "<br>");
                    Response.Write("IMEI STOCK => STATUS:" + Func.FR(_oDr["Status"]) + "<br>");
                    Response.Write("IMEI STOCK => IMEI:" + Func.FR(_oDr["IMEI"]) + "<br>");
                    Response.Write("IMEI STOCK => KIT_CODE:" + Func.FR(_oDr["KIT_CODE"]) + "<br>");
                    Response.Write("IMEI STOCK => MODEL:" + Func.FR(_oDr["MODEL"]) + "<br>");
                    if (ShowSQL)
                    {
                        Response.Write("===========SQL============<br>");
                    }
                    if (Func.FR(_oDr["KIT_CODE"]).Trim().Equals(_oMobileRetentionOrder.GetSku().Trim()) &&
                        Func.FR(_oDr["MODEL"]).Trim().Equals(_oMobileRetentionOrder.GetHs_model().Trim()))
                    {
                        //'=== update status ===
                        global::System.Text.StringBuilder _oUpdateIMEIStockQuery = new StringBuilder();
                        _oUpdateIMEIStockQuery.Append(" UPDATE IMEI_Stock SET ");
                        _oUpdateIMEIStockQuery.Append(" Status='SOLD',STAFF_RECD=null, Dummy1='" + n_sToday1 + "', ");

                        if (!Func.FR(_oDr["ReferenceNo"]).Trim().Equals(_oMobileRetentionOrder.GetEdf_no().Trim()))
                            _oUpdateIMEIStockQuery.Append(" ReferenceNo='" + _oMobileRetentionOrder.GetEdf_no().Trim() + "', ");
                        _oUpdateIMEIStockQuery.Append(" StaffNo='" + _oMobileRetentionOrder.GetStaff_no() + "' ,");
                        _oUpdateIMEIStockQuery.Append(" Mobile_no='" + _oMobileRetentionOrder.GetMrt_no() + "' ,Completed_Date='" + n_sToday1 + "' ");
                        _oUpdateIMEIStockQuery.Append(" WHERE Dummy2='CC RET' and IMEI='" + _oMobileRetentionOrder.GetImei_no() + "' ");
                        _oUpdateIMEIStockQuery.Append(" AND DUMMY4='" + _iRecordID.ToString() + "' ");
                        _oUpdateIMEIStockQuery.Append(" AND Kit_Code='" + _oMobileRetentionOrder.GetSku() + "' ");
                        _oUpdateIMEIStockQuery.Append("  AND Status='" + Func.FR(_oDr["Status"]) + "' AND rownum<=1");
                        if (ShowSQL)
                        {
                            Response.Write(_oUpdateIMEIStockQuery.ToString() + "<br>");
                        }
                        if (RunUpdateSQL)
                        {
                            bool _bUpdateImei = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oUpdateIMEIStockQuery.ToString());
                            if (_bUpdateImei)
                                Response.Write("UPDATE SUCCESS!<br>");
                            else
                                Response.Write("UPDATE FAIL!<BR>");
                        }
                        Response.Write("====================<br>");
                    }
                }
            }
        }
        _oDr.Close();
        _oDr.Dispose();
    }
}
