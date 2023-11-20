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


public partial class HelpTools_FindAOCaseNoIMEIRecord : System.Web.UI.Page
{
    EDFStatusProfile _oEDFStatusProfile = new EDFStatusProfile();
OrderSerialNumberControl _oOrderSerialNumberControl = new OrderSerialNumberControl();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
    }

    protected void AddAOToEdfProcess(string _sOrder_id)
    {

            bool _bAO = true;
            StringBuilder _sQuery = new StringBuilder();
            _sQuery.Append("SELECT order_id+100000 'record_id' ,  order_id, sku,staff_no, cdate,edf_no,imei_no,d_date,mrt_no,hs_model FROM MobileRetentionOrder WHERE ");
            if (!AllCheck.Checked && !string.IsNullOrEmpty(_sOrder_id))
                _sQuery.Append(" order_id='" + _sOrder_id.ToString() + "' AND ");
            else
                _sQuery.Append(" cdate>='1/1/2010' AND ");

            _sQuery.Append(" imei_no in ('AO','AWAIT','') and hs_model<>'' and sku<>'' AND active=1");
            Response.Write(_sQuery.ToString() + "<br>");
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery.ToString());
            while (_oDr.Read())
            {
                string _sRecordId = Func.FR(_oDr["record_id"]).Trim();
                string _sOrderId = Func.FR(_oDr["order_id"]).Trim();
                string _sSku = Func.FR(_oDr["sku"]).Trim();
                string _sHs_model = Func.FR(_oDr["hs_model"]).Trim();
                string _sStaff_no = Func.FR(_oDr["staff_no"]).Trim();
                string _sEdf_no = Func.FR(_oDr["edf_no"]).Trim();
                string _sImei_no = Func.FR(_oDr["imei_no"]).Trim();
                Response.Write("HS:" + _sHs_model + "<br>");
                Response.Write("EDF:" + _sEdf_no + "<br>");
                Response.Write("IMEI:" + _sImei_no + "<br>");
                if (!_sHs_model.Equals(string.Empty) && string.IsNullOrEmpty(_sImei_no) && !string.IsNullOrEmpty(_sOrderId))
                {
                    if (string.IsNullOrEmpty(_sEdf_no))
                    {
                        _bAO = true;
                        string _sUpdateQuery = "Update MobileRetentionOrder set imei_no='AO' where order_id='" + _sOrderId + "'";
                        SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_sUpdateQuery);
                        Response.Write(_sUpdateQuery.ToString() + "<br>");
                    }
                    else
                    {
                        _bAO = false;
                        string _sUpdateQuery = "Update MobileRetentionOrder set imei_no='AWAIT' where order_id='" + _sOrderId + "'";
                        SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_sUpdateQuery);
                        Response.Write(_sUpdateQuery.ToString() + "<br>");
                    }
                }

                if (!string.IsNullOrEmpty(_sRecordId) &&
                    !string.IsNullOrEmpty(_sOrderId) &&
                    !string.IsNullOrEmpty(_sSku) &&
                    !string.IsNullOrEmpty(_sHs_model) &&
                    !string.IsNullOrEmpty(_sStaff_no))
                {
                    string _sQuery1 = "SELECT DUMMY4 FROM IMEI_Stock WHERE Kit_Code='" + _sSku + "'  AND  DUMMY4='" + _sRecordId + "' AND (Status='STOCK' OR Status='AO' OR Status='AWAIT') AND Dummy2='CC RET' AND Dummy3='PLG' ";
                    OdbcDataReader _oDr2 = SYSConn<ODBCConnect>.Connect().GetSearch(_sQuery1);
                    if (!_oDr2.Read())
                    {
                        string _sQuery2 = "INSERT INTO IMEI_Stock (Kit_Code,Model,Status,DUMMY4,ReferenceNo,Create_Date,Create_By,StaffNo,Dummy2,Dummy3) VALUES ('" + _sSku.Trim() + "','" + _sHs_model + "','" + ((_bAO) ? "AO" : "AWAIT") + "','" + _sRecordId + "','" + _sRecordId + "',to_date('" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "' , 'dd/mm/yyyy hh24:mi:ss'),'" + _sStaff_no.Trim() + "','" + _sStaff_no.Trim() + "','CC RET','PLG') ";
                        Response.Write(_sQuery2);
                        bool _bInsertAO = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_sQuery2);
                    }
                    _oDr2.Close();
                    _oDr2.Dispose();
                }
            }
            _oDr.Close();
            _oDr.Dispose();


    }

    protected void AddAOToEdf_Click(object sender, EventArgs e)
    {
        AddAOToEdfProcess(orderid.Text);
    }


}
