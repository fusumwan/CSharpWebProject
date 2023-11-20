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

public partial class HelpTools_CreateAO_AWAITRecord : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
    }

    protected void CreateAORecord(int x_iOrder_id, string x_sStatus)
    {
        MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect(), x_iOrder_id);
        if (_oMobileRetentionOrder.GetFound())
        {
            string _sRecordId = Func.IDAdd100000(x_iOrder_id);
            string _sEdf_no = _sRecordId;
            if (x_sStatus != "AO")
            {
                _sEdf_no = _oMobileRetentionOrder.GetEdf_no();
            }
            string _sQuery2 = "INSERT INTO IMEI_Stock (Kit_Code,Model,Status,DUMMY4,ReferenceNo,Create_Date,Create_By,StaffNo,Dummy2,Dummy3) VALUES ('" + _oMobileRetentionOrder.GetSku().Trim() + "','" + _oMobileRetentionOrder.GetHs_model().Trim() + "','" + x_sStatus + "','" + _sRecordId + "','" + _sEdf_no + "',to_date('" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "' , 'dd/mm/yyyy hh24:mi:ss'),'" + _oMobileRetentionOrder.GetStaff_no().Trim() + "','" + _oMobileRetentionOrder.GetStaff_no().Trim() + "','CC RET','"+_oMobileRetentionOrder.GetDelivery_exchange_location()+"' ) ";
            bool _bInsertAO = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_sQuery2);
            if (_bInsertAO)
            {
                Response.Write("<script>alert('success!');</script>");
            }
            else
            {
                Response.Write("<script>alert('Fail!');</script>");
            }
        }
    }
    protected void CreateAOBut_Click(object sender, EventArgs e)
    {
        int _iOrder_id;
        if (int.TryParse(order_id.Text.ToString(), out _iOrder_id))
        {
            CreateAORecord(_iOrder_id, "AO");
        }
    }
    protected void CreateAWAITBut_Click(object sender, EventArgs e)
    {
        int _iOrder_id;
        if (int.TryParse(order_id.Text.ToString(), out _iOrder_id))
        {
            CreateAORecord(_iOrder_id, "AWAIT");
        }
    }
}
