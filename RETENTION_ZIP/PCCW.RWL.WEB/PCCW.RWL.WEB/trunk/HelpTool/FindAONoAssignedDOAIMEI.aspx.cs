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

public partial class HelpTools_FindAONoAssigned : System.Web.UI.Page
{
    EDFStatusProfile _oEDFStatusProfile = new EDFStatusProfile();
    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
        StringBuilder _sQuery=new StringBuilder();
        _sQuery.AppendLine("SELECT order_id+100000 'record_id' ,  order_id, sku, cdate,edf_no,imei_no,d_date,mrt_no,hs_model FROM MobileRetentionOrder WHERE cdate>='1/1/2010' AND");
        _sQuery.AppendLine("imei_no in ('AO','AWAIT') AND active=1");
        Response.Write(_sQuery.ToString() + "<br>");
        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery.ToString());
        while(_oDr.Read())
        {
            string _sRecordId = Func.FR(_oDr["record_id"]).Trim();
            string _sOrderId = Func.FR(_oDr["order_id"]).Trim();
            string _sSku = Func.FR(_oDr["sku"]).Trim();
            Response.Write("RECORDID : "+_sRecordId + "<br>");
            Response.Write("SKU : "+_sSku + "<br>");
            string _sQuery1 = "SELECT DUMMY4 FROM IMEI_Stock WHERE Kit_Code='" + _sSku + "'  AND  DUMMY4='" + _sRecordId + "' AND Status='STOCK'  AND Dummy2='CC RET' AND Dummy3='PLG'  ";
            OdbcDataReader _oDr2 = SYSConn<ODBCConnect>.Connect().GetSearch(_sQuery1);
            Response.Write(_sQuery1 + "<br>");
            if (!_oDr2.Read())
            {
                string _sImei_no = GetNormalImei(_sOrderId, _sRecordId, _sSku);
                if (_sImei_no != string.Empty)
                {
                    Response.Write("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!<br>");
                    Response.Write(_sImei_no + "<br>");
                    string _sQuery2 = "UPDATE IMEI_STOCK SET status='CANCEL'  WHERE DUMMY4='" + _sRecordId + "' AND Kit_Code='" + _sSku + "' AND Status in ('AO','AWAIT') AND DUMMY2='CC RET' AND rownum<=1";
                    Response.Write(_sQuery2 + "<br>");
                    bool _bUpdateAO = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_sQuery2);
                    string _sQuery3 = "UPDATE IMEI_STOCK SET status='STOCK' ,STAFF_RECD='', REFERENCENO='" + _sRecordId + "',DUMMY4='" + _sRecordId + "' WHERE  status='NORMAL'  AND IMEI='" + _sImei_no + "' AND kit_code='" + _sSku + "' AND DUMMY2='CC RET' AND rownum<=1";
                    Response.Write(_sQuery3 + "<br>");
                    bool _bUpdateStock = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_sQuery3);
                    Response.Write("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!<br>");
                }
            }
            _oDr2.Close();
            _oDr2.Dispose();
            Response.Write("====================================<br>");
        }
        _oDr.Close();
        _oDr.Dispose();
    }

    protected string GetNormalImei(string x_sOrder_id,string x_sRecord_id,string x_sSku)
    {
        string _sImei_no = string.Empty;
        bool n_sAllowInsertEDF = false;
        OdbcDataReader _oDr2 = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT IMEI FROM IMEI_Stock WHERE Dummy2='CC RET' AND Kit_Code='" + x_sSku + "' AND IMEI<>' ' and Status='NORMAL' order by IMEI ");
        while (_oDr2.Read() && _sImei_no.Trim().Equals(string.Empty))
        {
            _sImei_no = Func.FR(_oDr2["IMEI"]);
            n_sAllowInsertEDF = _oEDFStatusProfile.AllowAssignNormalIMEI(_sImei_no, x_sRecord_id);
            if (n_sAllowInsertEDF && _sImei_no != string.Empty)
            {

                
            }
            else
            {
                Response.Write("DOA IMEI :" + _sImei_no + "<br>");
                _sImei_no = string.Empty;
            }
        }
        _oDr2.Close();
        _oDr2.Dispose();

        return _sImei_no;
    }


}
