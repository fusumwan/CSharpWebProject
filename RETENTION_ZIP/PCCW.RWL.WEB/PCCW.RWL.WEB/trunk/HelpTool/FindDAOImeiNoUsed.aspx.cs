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

public partial class HelpTools_FindDAOImeiNoUsed : System.Web.UI.Page
{
    EDFStatusProfile _oEDFStatusProfile = new EDFStatusProfile();
    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();

    }
    protected void btn_doa_imei_Click(object sender, EventArgs e)
    {
        if (!imei_no.Text.ToString().Equals(string.Empty) && 
            !imei_no.Text.ToString().Equals("AO") && 
            !imei_no.Text.ToString().Equals("AWAIT"))
        {
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT imei_no FROM DOAProfileRecord WHERE active=1 and imei_no='" + imei_no.Text + "' AND used='" + ((used.Checked) ? "1" : "0") + "'");
            if (!_oDr.Read())
            {
                DOAProfileRecord _oDOAProfileRecord = new DOAProfileRecord(SYSConn<MSSQLConnect>.Connect());
                _oDOAProfileRecord.active = true;
                _oDOAProfileRecord.used = used.Checked;
                _oDOAProfileRecord.cid = "A8350006";
                _oDOAProfileRecord.cdate = DateTime.Now;
                _oDOAProfileRecord.status = status.SelectedValue.ToString().ToUpper().Trim();
                _oDOAProfileRecord.imei_no = imei_no.Text.ToString();
                DOAProfileRecordBal.InsertWithOutLastID(SYSConn<MSSQLConnect>.Connect(), _oDOAProfileRecord);
            }
            _oDr.Close();
            _oDr.Dispose();
        }
    }
}
