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


public partial class SandBox_Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append(" SELECT referenceno,agree_no,imei FROM sunday_form WHERE create_date>=to_date('01/03/2010','dd/mm/yyyy') and create_date<=to_date('23/07/2010','dd/mm/yyyy') ");
        _oQuery.Append(" AND referenceno is not null AND referenceno!=' '  AND cancelled='N' AND created_by='CC RET' ");
        OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(_oQuery.ToString());
        while (_oDr.Read())
        {
            string _sEdf_no = Func.FR(_oDr["referenceno"]).Trim();
            int _iRecordID;
            if (int.TryParse(Func.FR(_oDr["agree_no"]), out _iRecordID))
            {
                SqlDataReader _oDr2 = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT edf_no FROM MobileRetentionOrder WHERE order_id='" + (_iRecordID - 100000).ToString() + "'");
                if (_oDr2.Read())
                {
                    if (_sEdf_no != string.Empty && Func.FR(_oDr2["edf_no"]) != _sEdf_no)
                    {
                        Response.Write("OrderID:" + (_iRecordID - 100000).ToString() + "<br>");
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
