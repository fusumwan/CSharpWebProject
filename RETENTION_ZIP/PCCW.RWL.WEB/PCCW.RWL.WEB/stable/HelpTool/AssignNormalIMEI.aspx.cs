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
using PCCW.RWL.CORE.WEBFUNC;
public partial class HelpTool_AssignNormalIMEI : System.Web.UI.Page
{
    string n_sUid = string.Empty;
    EDFStatusProfile _oEDFStatusProfile = new EDFStatusProfile();
OrderSerialNumberControl _oOrderSerialNumberControl = new OrderSerialNumberControl();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
    }

    public void AssignNORMALIMEI()
    {
        StringBuilder _oQuery1 = new StringBuilder();
        _oQuery1.Append("SELECT distinct sku FROM MobileRetentionOrder WHERE (imei_no='AO' OR imei_no='AWAIT') AND SKU is not null AND SKU!='' ");
        SqlDataReader _oDr1 = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery1.ToString());
        while (_oDr1.Read())
        {
            string _sSku = Func.FR(_oDr1["sku"]).Trim();
            if (!string.IsNullOrEmpty(_sSku))
            {
                StringBuilder _oQuery2 = new StringBuilder();
                _oQuery2.Append("SELECT * from IMEI_Stock where Kit_Code='" + _sSku + "' AND Dummy2='CC RET' AND Status in ('AWAIT','AO')  order by Create_Date");
                global::System.Data.Odbc.OdbcDataReader _oDr2 = GetORDB().GetSearch(_oQuery2.ToString());
                if (_oDr2.Read())
                {
                    string _sRecordID = Func.FR(_oDr2["DUMMY4"]).Trim();
                    string _sEdfNo = Func.FR(_oDr2["REFERENCENO"]).Trim();
                    string _sIMEI = Func.FR(_oDr2["IMEI"]).Trim();
                    string _sStatus = Func.FR(_oDr2["STATUS"]).Trim();
                    int _iOrder_id;
                    if (int.TryParse(_sRecordID, out _iOrder_id))
                    {
                        StringBuilder _oQuery3 = new StringBuilder();
                        _oQuery3.Append("SELECT * FROM IMEI_Stock Where Dummy2='CC RET' and Kit_Code='" + _sSku + "' and Status='NORMAL' and IMEI<>' ' and IMEI is not null order by IMEI");
                        OdbcDataReader _oDr3 = GetORDB().GetSearch(_oQuery3.ToString());
                        if (_oDr3.Read())
                        {
                            string _sIMEI_NS = Func.FR(_oDr3["IMEI"]).Trim();
                            string _sStatus_NS = Func.FR(_oDr3["STATUS"]).Trim();
                            bool _oUpdate = true;
                            StringBuilder _oQuery4 = new StringBuilder();
                            StringBuilder _oQuery5 = new StringBuilder();
                            if (_sStatus == "AO")
                            {
                                if (!GetIMEI_STOCK(_sRecordID, "AWAIT", _sSku) && !GetIMEI_STOCK(_sRecordID, "SOLD", _sSku))
                                {
                                    _oQuery4.Append("UPDATE IMEI_STOCK SET IMEI='" + _sIMEI_NS + "' , STATUS='STOCK' WHERE DUMMY4='" + _sRecordID + "' AND STATUS='AO' AND DUMMY2='CC RET' AND KIT_CODE='" + _sSku + "' AND ROWNUM<=1");
                                    _oUpdate = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery4.ToString());
                                }
                                else
                                {
                                    _oUpdate = false;
                                }
                            }
                            else if (_sStatus == "AWAIT")
                            {
                                if (!GetIMEI_STOCK(_sRecordID, "AO", _sSku) && !GetIMEI_STOCK(_sRecordID, "SOLD", _sSku))
                                {
                                    _oQuery4.Append("UPDATE IMEI_STOCK SET IMEI='" + _sIMEI_NS + "' , STATUS='STOCK' WHERE DUMMY4='" + _sRecordID + "' AND STATUS='AWAIT' AND DUMMY2='CC RET' AND KIT_CODE='" + _sSku + "' AND ROWNUM<=1");
                                    _oUpdate = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery4.ToString());
                                }
                                else
                                {
                                    _oUpdate = false;
                                }
                            }

                            if (_oUpdate)
                            {
                                _oQuery5.Append("UPDATE IMEI_STOCK SET  STATUS='',IMEI='',DUMMY2='',Kit_Code='',MODEL='' WHERE IMEI='" + _sIMEI_NS + "' AND STATUS='NORMAL' AND DUMMY2='CC RET' AND KIT_CODE='" + _sSku + "' AND ROWNUM<=1");
                                _oUpdate = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery5.ToString());
                                //Response.Write(_oQuery4.ToString() + "<br>");
                                //if (_oUpdate) { Response.Write(_oQuery5.ToString() + "<br>"); }
                            }
                        }
                        _oDr3.Close();
                        _oDr3.Dispose();
                    }
                }
                _oDr2.Close();
                _oDr2.Dispose();
            }
        }
        _oDr1.Close();
        _oDr1.Dispose();
    }


    protected bool GetIMEI_STOCK(string x_sRecordID, string x_sStatus,string x_sSku)
    {
        if (string.IsNullOrEmpty(x_sRecordID)) { return false; }
        if (string.IsNullOrEmpty(x_sStatus)) { return false; }
        if (string.IsNullOrEmpty(x_sSku)) { return false; }
        StringBuilder _oQuery2 = new StringBuilder();
        _oQuery2.Append("SELECT IMEI FROM IMEI_STOCK WHERE DUMMY4='" + x_sRecordID + "' AND Kit_Code='" + x_sSku + "' AND Dummy2='CC RET' AND Status='" + x_sStatus + "' ORDER BY Create_Date");
        global::System.Data.Odbc.OdbcDataReader _oDr2 = GetORDB().GetSearch(_oQuery2.ToString());
        if (_oDr2.Read())
        {
            _oDr2.Close();
            _oDr2.Dispose();
            return true;
        }
        _oDr2.Close();
        _oDr2.Dispose();

        return false;
    }

    #region Get Oracle DB
    protected ODBCConnect GetORDB()
    {
        ODBCConnect _oDB = new ODBCConnect();
        _oDB.SetConnStr(Configurator.DBName.ORADNS + ((Configurator.IsUat()) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion

    protected bool CheckIMEINoInDB(string x_sIMEI)
    {
        if (string.IsNullOrEmpty(x_sIMEI)) return false;
        x_sIMEI = x_sIMEI.Trim();
        OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT imei FROM sunday_Form  WHERE referenceNo is not null AND referenceNo<>'' AND imei='" + x_sIMEI + "' AND rownum<=1");
        if (_oDr.Read())
        {
            if (!Func.FR(_oDr["imei"]).Trim().Equals(string.Empty))
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
    #region GetDB
    protected MSSQLConnect GetDB()
    {
        MSSQLConnect _oDB = new MSSQLConnect();
        _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
        _oDB.bWithNoLock = true;
        return _oDB;
    }
    #endregion
}
