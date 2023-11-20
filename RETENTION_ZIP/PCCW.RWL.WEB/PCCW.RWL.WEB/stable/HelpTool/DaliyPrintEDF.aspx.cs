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

public partial class SandBox_DaliyPrintEDF : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
        InitFrame();
    }

    protected void InitFrame()
    {
        DateTime _dD_date = new DateTime(2010, 3, 31);
        RWLFramework.DataBaseConfigSetting();
        string _sQuery = "SELECT order_id+100000 as 'record_id',order_id,edf_no,imei_no FROM MobileRetentionOrder with (nolock) WHERE edf_no is not null AND edf_no<>'' AND d_date>'" + _dD_date.AddDays(-1).ToString("dd/MM/yyyy 23:59:59") + "'  AND d_date<'" + _dD_date.ToString("dd/MM/yyyy") + " 23:59:59'";
        Response.Write(_sQuery + "<br>");
        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
        while (_oDr.Read())
        {
            int x_iOrder_id;
            if (int.TryParse(Func.FR(_oDr["order_id"]), out x_iOrder_id))
            {
                // Response.Write("FIND ID: " + x_iOrder_id.ToString() + "<br>");
                FindRecordIDEdfNoRecord(x_iOrder_id);
            }
        }
        _oDr.Close();
        _oDr.Dispose();
    }

    protected void FindRecordIDEdfNoRecord(int x_iOrder_id)
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
            if (!"".Equals(_oMobileRetentionOrder.GetEdf_no()))
            {
                if (_oMobileRetentionOrder.GetLog_date() != null)
                    _sToday = ((DateTime)_oMobileRetentionOrder.GetLog_date()).ToString("dd/MM/yyyy HH:mm:ss");

                if (!CheckEdfNoInDB(_oMobileRetentionOrder.GetEdf_no()))
                {
                    Response.Write("InsertAndCheckEDFRecord(" + x_iOrder_id.ToString() + ");<BR>");
                }
                else
                {

                }
            }
        }
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
