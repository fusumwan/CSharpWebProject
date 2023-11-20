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

public partial class SandBox_FindNoEDFRecord : System.Web.UI.Page
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
    protected void Page_Load(object sender, EventArgs e)
    {
        DateTime _oDateTime = DateTime.Now;
        DateTime _oPreDateTime = DateTime.Now.AddDays(-1);
        RWLFramework.DataBaseConfigSetting();
        FindNoEdfNoAndInsert();
    }


    protected void FindNoEdfNoAndInsert()
    {
        DateTime _oDateTime = new DateTime(2010, 3,22);
        DateTime _oPreDateTime = _oDateTime.AddDays(-1);
        RWLFramework.DataBaseConfigSetting();
        string _sQuery = "SELECT edf_no,order_id FROM MobileRetentionOrder with (nolock) WHERE edf_no is not null AND edf_no<>'' AND log_date>'" + _oPreDateTime.ToString("dd/MM/yyyy") + "'  AND log_date<'" + _oDateTime.ToString("dd/MM/yyyy") + " 23:59:59'";
        Response.Write(_sQuery + "<br>");
        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
        while (_oDr.Read())
        {
            int x_iOrder_id;
            if (int.TryParse(Func.FR(_oDr["order_id"]), out x_iOrder_id)){
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

                if (!CheckEdfNoInDB(_oMobileRetentionOrder.GetEdf_no()) && _oMobileRetentionOrder.GetActive()==true)
                {
                    Response.Write("InsertAndCheckEDFRecord("+x_iOrder_id.ToString() + ");<BR>");
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
