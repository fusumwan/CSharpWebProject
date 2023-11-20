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

public partial class HelpTools_FindNotMatchEDFRecord : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
       InitFrame();

    }

    public void InitFrame()
    {
        DateTime _oSearchTime = new DateTime(2010, 3, 14);
        string _sQuery = "SELECT referenceno,imei,agree_no FROM Sunday_form WHERE created_by='CC RET' and cancelled='N' ";
        _sQuery += "and create_date>=to_date('" + _oSearchTime.ToString("dd/MM/yyyy") + "','dd/MM/yyyy') and referenceno is not null and referenceno<>' ' and imei<>'AO' and imei<>'AWAIT' and imei<>' '";

        Response.Write(_sQuery + "<br>");
        /*
        OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(_sQuery);
        while (_oDr.Read())
        {
            string _sRecord_id = Func.FR(_oDr["agree_no"]);
            string _sReferenceno = Func.FR(_oDr["referenceno"]);
            string _sImei = Func.FR(_oDr["imei"]);
            int _iRecord_id;
            if (int.TryParse(_sRecord_id, out _iRecord_id))
            {
                string _sQueryWeblog = "Update MobileRetentionOrder set edf_no='" + _sReferenceno + "' and imei_no='" + _sImei + "' where order_id='" + Func.IDSubtract100000(_iRecord_id) + "'";
                Response.Write( _sQueryWeblog + "<br>");
                //if (SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_sQueryWeblog))
                {
                   // Response.Write("SUCCESS : " + _sQuery + "<br>");
                }
            }

        }
        _oDr.Close();
        _oDr.Dispose();
         */
    }

}
