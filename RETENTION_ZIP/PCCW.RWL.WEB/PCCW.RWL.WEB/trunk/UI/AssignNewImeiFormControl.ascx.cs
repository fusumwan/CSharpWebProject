using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Text;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using log4net;
using System.Reflection;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

public partial class UI_AssignNewImeiFormControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void AssignIMEIToRecordBtn_Click(object sender, EventArgs e)
    {
        string _sRecord_ID = record_id.Text;
        string _sMrt_no = mrt_no.Text;
        string _sImei_no = imei_no.Text;
        string _sSku = sku.Text;
        int _iRecord_ID;
        if (int.TryParse(_sRecord_ID, out _iRecord_ID))
        {
            int _iOrder_id = Convert.ToInt32(Func.IDSubtract100000(_iRecord_ID));
            MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect(), _iOrder_id);
            if (_oMobileRetentionOrder.GetFound())
            {
                if (!ChkIMEIUsing(_sImei_no, _sSku))
                {
                    return;
                }

                

                if (_oMobileRetentionOrder.GetMrt_no() != null)
                {
                    if (((int)_oMobileRetentionOrder.GetMrt_no()).ToString() != _sMrt_no)
                    {
                        jAlert("Enter Wrong Mobile Number!");
                        return;
                    }
                }

                if (!"MOBILE_LITE".Equals(_oMobileRetentionOrder.GetIssue_type()))
                {
                    if (AssignAOOrder(ref _oMobileRetentionOrder) ||
                        AssignAwaitOrder(ref _oMobileRetentionOrder))
                    {
                        return;
                    }
                }
                else
                {
                    jAlert("Cannot Cater The Mobile Lite Order!");
                }
            }
        }
    }

    




    protected bool AssignAwaitOrder(ref MobileRetentionOrder x_oMobileRetentionOrder)
    {
        string _sImei_no = imei_no.Text;
        string _sSku = sku.Text;
        if (!"MOBILE_LITE".Equals(x_oMobileRetentionOrder.GetIssue_type()))
        {
            if (!string.IsNullOrEmpty(x_oMobileRetentionOrder.GetEdf_no()))
            {
                if (ChkImeiStatus(ref x_oMobileRetentionOrder, "AWAIT"))
                {
                    UpdateImei(((int)x_oMobileRetentionOrder.GetOrder_id())+100000, _sImei_no, _sSku);
                }
            }
        }
        return false;
    }

    protected bool AssignAOOrder(ref MobileRetentionOrder x_oMobileRetentionOrder)
    {
        string _sImei_no = imei_no.Text;
        string _sSku = sku.Text;
        if (!"MOBILE_LITE".Equals(x_oMobileRetentionOrder.GetIssue_type()))
        {
            if (string.IsNullOrEmpty(x_oMobileRetentionOrder.GetEdf_no()))
            {
                if (ChkImeiStatus(ref x_oMobileRetentionOrder, "AO"))
                {
                    UpdateImei(((int)x_oMobileRetentionOrder.GetOrder_id()) + 100000, _sImei_no, _sSku);
                }
            }
        }
        return false;
    }

    public bool ChkIMEIUsing(string x_sIMEI, string x_sSKU)
    {
        if (string.IsNullOrEmpty(x_sIMEI)) return false;
        if (string.IsNullOrEmpty(x_sSKU)) return false;
        string _sQuery = "SELECT * FROM IMEI_STOCK WHERE DUMMY2='CC RET' AND kit_code='" + x_sSKU + "' AND (STATUS='SOLD' or STATUS='STOCK') AND IMEI='" + x_sIMEI + "' ";
        OdbcDataReader _oChkDr = SYSConn<ODBCConnect>.Connect().GetSearch(_sQuery);
        if (_oChkDr.Read())
        {
            jAlert("Error : IMEI has been used!");
            _oChkDr.Close();
            _oChkDr.Dispose();
            return false;
        }
        _oChkDr.Close();
        _oChkDr.Dispose();
        return true;
    }


    public bool UpdateImei(int x_iRecord_ID, string x_sIMEI, string x_sSKU)
    {
        AssignIMEIControl _oAssignIMEIControl = new AssignIMEIControl();
        if (string.IsNullOrEmpty(x_sIMEI)) return false;
        if (string.IsNullOrEmpty(x_sSKU)) return false;
        string _sQuery = "SELECT * FROM IMEI_STOCK WHERE DUMMY4='" + x_iRecord_ID.ToString() + "' AND kit_code='" + x_sSKU + "' AND (STATUS='AO' or STATUS='AWAIT') ";
        OdbcDataReader _oChkDr = SYSConn<ODBCConnect>.Connect().GetSearch(_sQuery);
        if (!_oChkDr.Read())
        {
            jAlert("Update Fail!");
            _oChkDr.Close();
            _oChkDr.Dispose();
            return false;
        }
        _oChkDr.Close();
        _oChkDr.Dispose();

        _sQuery = "SELECT * FROM IMEI_STOCK WHERE DUMMY4='" + x_iRecord_ID.ToString() + "' AND kit_code='" + x_sSKU + "' AND (IMEI is  null or IMEI=' ') ";
        _oChkDr = SYSConn<ODBCConnect>.Connect().GetSearch(_sQuery);
        if (!_oChkDr.Read())
        {
            jAlert("Update Fail!");
            _oChkDr.Close();
            _oChkDr.Dispose();
            return false;
        }
        _oChkDr.Close();
        _oChkDr.Dispose();

        StringBuilder _oUpdateStockQuery = new StringBuilder();
        _oUpdateStockQuery.Append("UPDATE IMEI_STOCK SET IMEI='" + x_sIMEI + "', STATUS='STOCK' WHERE (STATUS='AO' OR STATUS='AWAIT') AND DUMMY4='" + x_iRecord_ID.ToString() + "' AND kit_code='" + x_sSKU + "' AND (IMEI is  null or IMEI=' ') AND ROWNUM<=1");
        bool _bUpdateStockQuery = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oUpdateStockQuery.ToString());
        bool _bUploadStockOrder = _oAssignIMEIControl.UploadStockOrder(x_iRecord_ID, RWLFramework.CurrentUser[this.Page].Uid, x_sIMEI, x_sSKU);

        if (!_bUpdateStockQuery || !_bUploadStockOrder)
            jAlert("Update Fail!");

        if (_bUploadStockOrder)
        {
            MobileManualAssignedHistory _oMobileManualAssignedHistory = new MobileManualAssignedHistory(SYSConn<MSSQLConnect>.Connect());
            _oMobileManualAssignedHistory.SetOrder_id(x_iRecord_ID - 100000);
            _oMobileManualAssignedHistory.SetImei_no(x_sIMEI);
            _oMobileManualAssignedHistory.SetSku(x_sSKU);
            _oMobileManualAssignedHistory.SetCid(RWLFramework.CurrentUser[this.Page].Uid);
            _oMobileManualAssignedHistory.SetCdate(DateTime.Now);
            if (MobileManualAssignedHistoryBal.InsertWithOutLastID(SYSConn<MSSQLConnect>.Connect(), _oMobileManualAssignedHistory))
            {

                MobileRetentionOrderBal.BackUpOrder(x_iRecord_ID - 100000, RWLFramework.CurrentUser[this.Page].Uid);
            }
            
            jAlert("Update Sucess!");
        }
        return true;
    }


    protected bool ChkImeiStatus(ref MobileRetentionOrder x_oMobileRetentionOrder,string _sStatus)
    {
        if (_sStatus.Trim().ToUpper().Equals("AWAIT") ||
            _sStatus.Trim().ToUpper().Equals("AO"))
        {
            if (_sStatus.Trim().ToUpper().Equals("AWAIT"))
            {
                if(string.IsNullOrEmpty(x_oMobileRetentionOrder.GetEdf_no()))
                {
                    jAlert("Error : Order Missing Edf number!");
                    return false;
                }

                if (x_oMobileRetentionOrder.GetImei_no().Trim().ToUpper()=="AWAIT" && 
                    !string.IsNullOrEmpty(x_oMobileRetentionOrder.GetEdf_no()))
                {
                    return true;
                }
                else
                    return false;
            }
            if (_sStatus.Trim().ToUpper().Equals("AO"))
            {
                if (x_oMobileRetentionOrder.GetImei_no().Trim().ToUpper() == "AO" &&
                    string.IsNullOrEmpty(x_oMobileRetentionOrder.GetEdf_no()))
                {
                    return true;
                }
                else
                    return false;
            }
        }
        return false;
    }


    #region RegisterJavaScript
    protected void jAlert(string x_sMsg)
    {
        string _sAlertMsg = String.Format("jAlert('{0}','System Message');", x_sMsg);
        RegisterJavaScript(string.Empty, _sAlertMsg, true);
    }

    protected void RegisterJavaScript(string x_sID, string x_sScript, bool x_bIncludeScript)
    {
        if (x_bIncludeScript) x_sScript = "<script>" + x_sScript + "</script>";
        ScriptManager.RegisterStartupScript(this.Page, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), x_sScript, false);
    }
    #endregion


    #region GetDB
    protected MSSQLConnect GetDB()
    {
        MSSQLConnect _oDB = new MSSQLConnect();
        _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
        _oDB.bWithNoLock = true;
        return _oDB;
    }
    #endregion

    #region Get Oracle DB
    protected ODBCConnect GetORDB()
    {
        ODBCConnect _oDB = new ODBCConnect();
        _oDB.SetConnStr(Configurator.DBName.ORADNS + ((Configurator.IsUat()) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion
}
