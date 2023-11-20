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
public partial class HelpTool_FindOutCannotUploadOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();

        DateTime _oDateTime = DateTime.Now.AddMinutes(-10);
        DateTime _oPreDateTime = DateTime.Now.AddDays(-100);
        RWLFramework.DataBaseConfigSetting();
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append(" SELECT edf_no,order_id FROM MobileRetentionOrder with (nolock) ");
        _oQuery.Append(" WHERE edf_no is not null AND edf_no<>'' AND ( (log_date is not null AND log_date>'" + _oPreDateTime.ToString("dd/MM/yyyy HH:mm:ss") + "'  AND log_date<'" + _oDateTime.ToString("dd/MM/yyyy HH:mm:ss") + "' ) OR (cdate is not null AND cdate>'" + _oPreDateTime.ToString("dd/MM/yyyy HH:mm:ss") + "'  AND cdate<'" + _oDateTime.ToString("dd/MM/yyyy HH:mm:ss") + "' ) OR (edate is not null  AND  edate>'" + _oPreDateTime.ToString("dd/MM/yyyy HH:mm:ss") + "'  AND edate<'" + _oDateTime.ToString("dd/MM/yyyy HH:mm:ss") + "' )) and active=1 ");
        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
        while (_oDr.Read())
        {
            int _iOrder_id;
            if (int.TryParse(Func.FR(_oDr["order_id"]), out _iOrder_id))
            {
                string _sEdf_no = Func.FR(_oDr["edf_no"]).Trim();
                OdbcDataReader _oDr2 = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT IMEI FROM SUNDAY_FORM WHERE referenceno='" + _sEdf_no + "' AND ROWNUM<=1");
                if (!_oDr2.Read())
                {
                    Response.Write("EDF:"+_sEdf_no + " ORDER ID:"+_iOrder_id.ToString()+"<br>");
                }
                _oDr2.Close();
                _oDr2.Dispose();
            }
        }
        _oDr.Close();
        _oDr.Dispose();
    }
}
