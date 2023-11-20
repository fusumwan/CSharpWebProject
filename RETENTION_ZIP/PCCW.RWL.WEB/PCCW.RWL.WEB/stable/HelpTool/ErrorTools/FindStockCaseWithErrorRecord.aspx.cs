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
using log4net;
using System.Reflection;

public partial class HelpTool_FindStockCaseWithErrorRecord : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
        EDFStatusProfile _oEDFStatusProfile = new EDFStatusProfile();
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("SELECT * FROM IMEI_STOCK WHERE DUMMY2='CC RET' AND STATUS='STOCK' ");

        OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(_oQuery.ToString());
        while (_oDr.Read())
        {
            string _sRecord_id=Func.FR(_oDr["DUMMY4"]).Trim();
            int _iRecordId;
            if (int.TryParse(_sRecord_id, out _iRecordId))
            {
                string _sStatus = Func.FR(_oDr["STATUS"]).Trim();
                string _sIMEI = Func.FR(_oDr["IMEI"]).Trim();
                string _sEDF = Func.FR(_oDr["REFERENCENO"]).Trim();
                StringBuilder _oQuery2 = new StringBuilder();
                _oQuery2.Append("SELECT * FROM MobileRetentionOrder WHERE active=1 AND order_id='" + (_iRecordId-100000).ToString() + "' ");
                SqlDataReader _oDr2 = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery2.ToString());
                if (_oDr2.Read())
                {
                    if (Func.FR(_oDr2["edf_no"]).Trim().Equals(_sEDF) &&
                        Func.FR(_oDr2["imei_no"]).Trim().Equals(_sIMEI))
                    {
                        SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("UPDATE IMEI_STOCK SET STATUS='SOLD' WHERE DUMMY2='CC RET' AND STATUS='STOCK' AND IMEI='"+_sIMEI+"' AND referenceno='"+_sEDF+"' AND DUMMY4='" + _iRecordId.ToString() + "' AND ROWNUM<=1");

                    }
                }
                _oDr2.Close();
                _oDr2.Dispose();
            }
        }
        _oDr.Close();
        _oDr.Dispose();
    }
}
