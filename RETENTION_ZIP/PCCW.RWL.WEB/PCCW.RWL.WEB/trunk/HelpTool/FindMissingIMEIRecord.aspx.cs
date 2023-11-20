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

public partial class HelpTool_FindMissingIMEIRecord : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append(" SELECT order_id,edf_no,imei_no,cdate FROM MobileRetentionOrder WHERE ");
        _oQuery.Append(" imei_no is not null AND ");
        _oQuery.Append(" imei_no<>'' AND ");
        _oQuery.Append(" (imei_no!='AO' AND imei_no!='AWAIT') AND ");
        _oQuery.Append(" cdate>='1/7/2010' AND cdate<='15/9/2010 23:59:59' ORDER BY cdate DESC");
        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
        while (_oDr.Read())
        {
            StringBuilder _oQuery2 = new StringBuilder();
            _oQuery2.Append("SELECT referenceno,IMEI FROM Sunday_form WHERE referenceno='" + Func.FR(_oDr["edf_no"]) + "' AND ROWNUM<=1");
            OdbcDataReader _oODr = SYSConn<ODBCConnect>.Connect().GetSearch(_oQuery2.ToString());
            while (_oODr.Read())
            {
                if (Func.FR(_oODr["IMEI"]) != Func.FR(_oDr["imei_no"]))
                {
                    Response.Write(Func.FR(_oDr["edf_no"]) + ":                     WEB LOG IMEI NO:" + Func.FR(_oDr["imei_no"]) + "          EDF IMEI NO:" + Func.FR(_oODr["IMEI"]) + "    <br>");
                }
                else
                {
                   // Response.Write(Func.FR(_oDr["order_id"]) + ":IMEI_NO:" + Func.FR(_oDr["imei_no"]) + " IMEI :" + Func.FR(_oODr["IMEI"]) + " <br>");

                }
            }
            _oODr.Close();
            _oODr.Dispose();
        }
        _oDr.Close();
        _oDr.Dispose();
        
    }
}
