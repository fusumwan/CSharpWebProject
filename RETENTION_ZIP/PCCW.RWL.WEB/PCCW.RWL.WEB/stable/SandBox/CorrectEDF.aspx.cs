using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Odbc;
using System.Globalization;
using System.Text;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
public partial class SandBox_Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
        EDFStatusProfile _oEDFStatusProfile = new EDFStatusProfile();
OrderSerialNumberControl _oOrderSerialNumberControl = new OrderSerialNumberControl();
        
        string _sRecordID = "461755";
        string _sEdf = "80089/HR10OCT";

        int Recordid;
        if (int.TryParse(_sRecordID, out Recordid))
        {
            bool _bIMEI = false;
            bool _bDeleteEDF = false;
            int _iOrder_id=Recordid-100000;
            if (_bDeleteEDF)
            {
               bool _bDeleted=  _oEDFStatusProfile.DeleteEDFRecord(_sEdf, Recordid.ToString(), string.Empty);
            }
            else
            {
               bool _bInserted= _oEDFStatusProfile.InsertEDF(_iOrder_id);
            }
            if (_bIMEI)
            {
                MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect(), Recordid - 100000);
                if (_oMobileRetentionOrder.GetFound() == true && _oMobileRetentionOrder.GetActive() == true)
                {
                    if (_oMobileRetentionOrder.GetImei_no() == "AO")
                    {
                        CreateAO((int)_oMobileRetentionOrder.GetOrder_id());
                    }
                    else if (_oMobileRetentionOrder.GetImei_no() == "AWAIT")
                    {
                        CreateAWAIT((int)_oMobileRetentionOrder.GetOrder_id());
                    }
                }
            }
        }
    }

    protected bool CreateAO(int _iOrder_id)
    {
        if (_iOrder_id>0)
        {
            string n_sToday1 = DateTime.Now.ToString("yyyyMMdd");
            MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect(), _iOrder_id);
            StringBuilder _oCheckAOImei = new StringBuilder();
            _oCheckAOImei.Append("SELECT IMEI FROM IMEI_Stock WHERE ");
            _oCheckAOImei.Append(" kit_code='" + _oMobileRetentionOrder.GetSku() + "' ");
            _oCheckAOImei.Append(" AND Model='" + _oMobileRetentionOrder.GetHs_model() + "' ");
            _oCheckAOImei.Append(" AND Status='AO' ");
            _oCheckAOImei.Append(" AND DUMMY4='" + Func.IDAdd100000(Convert.ToInt32(_oMobileRetentionOrder.GetOrder_id())) + "' ");
            _oCheckAOImei.Append(" AND ReferenceNo='" + Func.IDAdd100000(Convert.ToInt32(_oMobileRetentionOrder.GetOrder_id())) + "' ");
            _oCheckAOImei.Append(" AND Dummy2='CC RET'");
            OdbcDataReader _oCheckAODr = SYSConn<ODBCConnect>.Connect().GetSearch(_oCheckAOImei.ToString());
            if (!_oCheckAODr.Read())
            {
                _oCheckAODr.Close();
                _oCheckAODr.Dispose();
                if (SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("INSERT INTO IMEI_Stock (Kit_Code,Model,Status,DUMMY4,ReferenceNo,Create_Date,Create_By,StaffNo,Dummy2,Dummy3) values ('" + _oMobileRetentionOrder.GetSku() + "','" + _oMobileRetentionOrder.GetHs_model() + "','AO','" + Func.IDAdd100000(Convert.ToInt32(_oMobileRetentionOrder.GetOrder_id())) + "','" + Func.IDAdd100000(Convert.ToInt32(_oMobileRetentionOrder.GetOrder_id())) + "',to_date('" + n_sToday1 + "' , 'dd/mm/yyyy hh24:mi:ss'),'" + _oMobileRetentionOrder.GetStaff_no() + "','" + _oMobileRetentionOrder.GetStaff_no() + "','CC RET','PLG') "))
                {
                    Response.Write("CREATE AO<br>");
                    return true;
                }
                else
                    return false;
            }
            else
            {
                _oCheckAODr.Close();
                _oCheckAODr.Dispose();
                return false;
            }
        }
        return true;
    }

    protected bool CreateAWAIT(int _iOrder_id)
    {

        if (_iOrder_id > 0)
        {
            string n_sToday1 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect(), _iOrder_id);
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("SELECT IMEI FROM IMEI_STOCK WHERE ");
            _oQuery.Append(" Kit_Code='" + _oMobileRetentionOrder.GetSku() + "'  ");
            _oQuery.Append(" AND Status='AWAIT' ");
            _oQuery.Append(" AND DUMMY4='" + Func.IDAdd100000(_iOrder_id) + "' ");
            _oQuery.Append(" AND ReferenceNo='" + _oMobileRetentionOrder.GetEdf_no() + "' ");
            _oQuery.Append(" AND Create_By='" + _oMobileRetentionOrder.GetStaff_no() + "' ");
            _oQuery.Append(" AND StaffNo='" + _oMobileRetentionOrder.GetStaff_no() + "'");
            _oQuery.Append(" AND Dummy2='CC RET' ");
            _oQuery.Append(" AND Dummy3='PLG' ");
            OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(_oQuery.ToString());
            if (!_oDr.Read())
            {
                if (SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("INSERT into IMEI_Stock (Kit_Code,Model,Status,DUMMY4,ReferenceNo,Create_Date,Create_By,StaffNo,Dummy2,Dummy3) values ('" + _oMobileRetentionOrder.GetSku() + "','" + _oMobileRetentionOrder.GetHs_model() + "','AWAIT','" + Func.IDAdd100000(_iOrder_id) + "','" + _oMobileRetentionOrder.GetEdf_no() + "',to_date('" + n_sToday1 + "' , 'dd/mm/yyyy hh24:mi:ss'),'" + _oMobileRetentionOrder.GetStaff_no() + "','" + _oMobileRetentionOrder.GetStaff_no() + "','CC RET','PLG') "))
                {
                    Response.Write("CREATE AWAIT<br>");
                    _oDr.Close();
                    _oDr.Dispose();
                    return true;
                }
                else
                {
                    _oDr.Close();
                    _oDr.Dispose();
                    return false;
                }
            }
            
        }
        return false;
    }
}
