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


public partial class SandBox_FindDuplicateEDFRecord : System.Web.UI.Page
{
    DateTime _oSearchTime = new DateTime(2010, 3, 17);
    protected void Page_Load(object sender, EventArgs e)
    {

        RWLFramework.DataBaseConfigSetting();
        Response.Write("<br>============================Check Duplicate EDF=================================</br>");
        CheckDuplicateEDF();
        Response.Write("<br>============================Check Duplicate IMEI=================================</br>");
        CheckDuplicateIMEI();
        Response.Write("<br>============================Check Duplicate WebLog MRT=================================</br>");
        CheckDuplicateWebLogMrt();
        Response.Write("<br>============================Check Duplicate EDF MRT=================================</br>");
        CheckDuplicateEDFMrt();
    }

    public void CheckDuplicateEDF()
    {
        string _sQuery = "SELECT referenceno FROM Sunday_form WHERE created_by='CC RET' and cancelled='N' ";
        _sQuery += "AND create_date>=to_date('" + _oSearchTime.ToString("dd/MM/yyyy") + "','dd/MM/yyyy') group by referenceno HAVING COUNT(referenceno)>1";
        OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(_sQuery);
        while (_oDr.Read())
        {
            Response.Write(Func.FR(_oDr["referenceno"]) + "<br>");
        }
        _oDr.Close();
        _oDr.Dispose();
    }

    public void CheckDuplicateIMEI()
    {
        string _sQuery = "SELECT imei FROM Sunday_form WHERE created_by='CC RET' and cancelled='N' ";
        _sQuery += "and create_date>=to_date('" + _oSearchTime.ToString("dd/MM/yyyy") + "','dd/MM/yyyy') group by imei HAVING COUNT(imei)>1";
        OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(_sQuery);
        while (_oDr.Read())
        {
            Response.Write(Func.FR(_oDr["imei"]) + "<br>");
        }
        _oDr.Close();
        _oDr.Dispose();
    }

    public void CheckDuplicateWebLogMrt()
    {
        string _sQuery = "SELECT mrt_no FROM MobileRetentionOrder WHERE active=1 and action_required<>'opt_out' and action_required<>'suspend' and log_date>='" + _oSearchTime.ToString("dd/MM/yyyy") + "' GROUP BY mrt_no HAVING COUNT(mrt_no)>1";
        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
        while (_oDr.Read())
        {
            Response.Write(Func.FR(_oDr["mrt_no"]) + "<br>");
        }
        _oDr.Close();
        _oDr.Dispose();
    }

    public void CheckDuplicateEDFMrt()
    {
        string _sQuery = "SELECT mobile_no FROM Sunday_form WHERE  created_by='CC RET' and cancelled='N' AND create_date>=to_date('" + _oSearchTime.ToString("dd/MM/yyyy") + "','dd/MM/yyyy')  GROUP BY mobile_no HAVING COUNT(mobile_no)>1";
        OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(_sQuery);
        while (_oDr.Read())
        {
            Response.Write(Func.FR(_oDr["mobile_no"]) + "<br>");
        }
        _oDr.Close();
        _oDr.Dispose();
    }
}
