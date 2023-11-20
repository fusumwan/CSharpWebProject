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

public partial class HelpTools_ErrorIMEIStatus : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {

        RWLFramework.DataBaseConfigSetting();

        StringBuilder _oQuery=new StringBuilder();
        _oQuery.Append("SELECT * FROM imei_stock");
        _oQuery.Append("WHERE MODEL is null or MODEL=' ' AND dummy2='CC RET' AND Dummy3='PLG' AND status='AO'");
        //OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch();
    }
}
