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


public partial class SandBox_FindNoEDFIMEIRecord : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
    }

    public void initFrame()
    {
        /*
SELECT order_id+100000,edf_no,imei_no,log_date,d_date from MobileRetentionOrder WHERE active=1 AND hs_model<>'' and hs_model is not null and (imei_no is null or imei_no='') and (edf_no is null or edf_no ='') and 
log_date >='13/3/2010 23:59:59';
         */
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("SELECT order_id+100000 as 'record_id',edf_no,imei_no,log_date,d_date FROM MobileRetentionOrder WHERE active=1 AND hs_model<>'' AND hs_model is not null AND (imei_no is null or imei_no='') AND (edf_no is null or edf_no ='') AND ");
        _oQuery.Append("log_date >='13/3/2010 23:59:59'");
        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
        while (_oDr.Read())
        {
            Response.Write(Func.FR(_oDr["record_id"]) + "<br>");
        }
        _oDr.Close();
        _oDr.Dispose();


    }
}
