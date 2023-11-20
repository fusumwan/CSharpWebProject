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
public partial class SandBox_CheckduplicateMRT : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
        InitFrame();
    }


    protected void InitFrame()
    {
        RWLFramework.DataBaseConfigSetting();
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("select edf_no,imei_no,order_id,mrt_no from MobileRetentionOrder where (action_required is null or action_required='') and action_required<>'opt_out' and action_required<>'suspend' and mrt_no in ");
        _oQuery.Append("(");
        _oQuery.Append("select mrt_no from MobileRetentionOrder with(nolock) where active=1 and (action_required is null or action_required='') and action_required<>'opt_out' and action_required<>'suspend'  and ");
        _oQuery.Append("log_date>'13/3/2010 23:59:59' group by mrt_no having count(mrt_no)>1 ");
        _oQuery.Append(")   ");
        _oQuery.Append("order by mrt_no");
        Response.Write(_oQuery.ToString() + "<br>");
        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
        while (_oDr.Read())
        {
            int x_iOrder_id;
            if (int.TryParse(Func.FR(_oDr["order_id"]), out x_iOrder_id))
            {
                // Response.Write("FIND ID: " + x_iOrder_id.ToString() + "<br>");
                FindRecordIDAgreeNoRecord(x_iOrder_id);
            }
        }
        _oDr.Close();
        _oDr.Dispose();
    }

    protected void FindRecordIDAgreeNoRecord(int x_iOrder_id)
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
            if (string.IsNullOrEmpty(_oMobileRetentionOrder.GetEdf_no()))
            {
                if (_oMobileRetentionOrder.GetLog_date() != null)
                    _sToday = ((DateTime)_oMobileRetentionOrder.GetLog_date()).ToString("dd/MM/yyyy HH:mm:ss");

                if (!CheckAgreeNoInDB(Func.IDAdd100000(_oMobileRetentionOrder.GetOrder_id())))
                {
                    //Response.Write("InsertAndCheckEDFRecord(" + x_iOrder_id.ToString() + ");<BR>");
                    Response.Write(x_iOrder_id.ToString() + "&nbsp;&nbsp;&nbsp;&nbsp;" + _oMobileRetentionOrder .GetMrt_no()+ "<br>");
                }
                else
                {

                }
            }
        }
    }


    protected bool CheckAgreeNoInDB(string x_sAgree_no)
    {
        if (string.IsNullOrEmpty(x_sAgree_no)) return false;
        x_sAgree_no = x_sAgree_no.Trim();
        OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(" SELECT agree_no FROM sunday_Form  WHERE agree_no='" + x_sAgree_no + "' AND rownum<=1");
        if (_oDr.Read())
        {
            if (!Func.FR(_oDr["agree_no"]).Trim().Equals(string.Empty))
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
