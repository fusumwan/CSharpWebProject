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

public partial class SandBox_EDFSolvedErrorRecord : System.Web.UI.Page
{
    EDFStatusProfile _oEDFStatusProfile = new EDFStatusProfile();
    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
        InitFrame();
    }

    protected void InitFrame()
    {
        /*
        if (IMEIRelease("355195030757735"))
        {
            Response.Write("Release Success<br>");
        }
        */
        IMEIRelease("355195030757735", "STOCK");
        IMEIRelease("355195030842784", "STOCK");
        IMEIRelease("355195030842685", "STOCK");
        IMEIRelease("355195030855588", "STOCK");
        IMEIRelease("355195030856156", "STOCK");
        IMEIRelease("355195030842693", "STOCK");
        IMEIRelease("355195030842156", "STOCK");
        IMEIRelease("355195030855570", "STOCK");
        IMEIRelease("355195030855075", "STOCK");
        IMEIRelease("355195030842859", "STOCK");
        IMEIRelease("355195030855901", "STOCK");
        IMEIRelease("355195030856016", "STOCK");
        IMEIRelease("355195030841646", "STOCK");
        IMEIRelease("355195030855513", "STOCK");
        IMEIRelease("355195030841976", "STOCK");
        IMEIRelease("355195030842016", "STOCK");
        IMEIRelease("355195030842289", "STOCK");
        IMEIRelease("355195030013865", "STOCK");
        IMEIRelease("355195030020944", "STOCK");
        IMEIRelease("355195030844061", "STOCK");
        IMEIRelease("355195030697725", "STOCK");
        IMEIRelease("355195030857881", "STOCK");
        IMEIRelease("355195030758378", "STOCK");
        IMEIRelease("355195030697774", "STOCK");
        IMEIRelease("355195030697980", "STOCK");
        IMEIRelease("359051028203784", "STOCK");
        IMEIRelease("359387033397256", "STOCK");
        IMEIRelease("359473032573087", "STOCK");
        IMEIRelease("357215030178977", "STOCK");
        IMEIRelease("357215030173218", "STOCK");
        IMEIRelease("355195030842024", "STOCK");
        IMEIRelease("359473031621036", "STOCK");
        IMEIRelease("359351038892612", "STOCK");
        IMEIRelease("358749030153126", "STOCK");
        IMEIRelease("351531047112205", "STOCK");
        IMEIRelease("351531043696482", "STOCK");
        IMEIRelease("358749030131932", "STOCK");
        IMEIRelease("358424035472919", "STOCK");
        IMEIRelease("358424035941731", "STOCK");
        IMEIRelease("358749033320524", "STOCK");
        IMEIRelease("359470023586342", "STOCK");
        IMEIRelease("351531043549806", "STOCK");
        IMEIRelease("357232031564501", "STOCK");
        IMEIRelease("355195030855315", "STOCK");
        IMEIRelease("355195030856032", "STOCK");
        IMEIRelease("355195030868664", "STOCK");
        IMEIRelease("355195030021090", "STOCK");
        IMEIRelease("354957031598025", "STOCK");
        IMEIRelease("359470022945259", "STOCK");
        IMEIRelease("359470023135744", "STOCK");
        IMEIRelease("359473031621499", "STOCK");
        IMEIRelease("012158006545737", "STOCK");
        IMEIRelease("012025009858880", "STOCK");
        IMEIRelease("357215030613841", "STOCK");
        IMEIRelease("351514049437234", "STOCK");

        
        //DeleteEDFRecord("60744/HR10APR", "386645", " AND CANCELLED='N'");
        //DeleteEDFRecord("60416/HR10MAR", "384988", " AND CANCELLED='N'");
        /*
        if (RWL_EDFIMEIRelease("269213"))
        {
            Response.Write("EDF IMEI in '269213' order<br>");
        }
        */
        /*
        if (RWL_EDFIMEIRelease("284988"))
        {
            Response.Write("EDF IMEI in '284988' order<br>");
        }
        */
    }

    public bool IMEIRelease(string x_sIMEI)
    {
        return IMEIRelease(x_sIMEI,"SOLD");
    }

    public bool IMEIRelease(string x_sIMEI,string x_sStatus)
    {
        if (string.IsNullOrEmpty(x_sIMEI)) return false;
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("UPDATE imei_stock SET referenceno='', status='NORMAL', staff_recd='', DUMMY4='', dummy1='' ");
        _oQuery.Append("WHERE imei='" + x_sIMEI + "' AND status='" + x_sStatus + "' AND dummy2='CC RET' AND rownum<=1");

        bool _bReleaseIMEI = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery.ToString());
        return _bReleaseIMEI;
    }

    public void DeleteEDFRecord(string edf, string record_id, string filter)
    {
        if (_oEDFStatusProfile.DeleteEDFRecord(edf, record_id, filter))
            Response.Write("DELETE : EDF: " + edf + "   RECORD ID : " + record_id + "<BR>");
        else
            Response.Write("DELETE FAIL : EDF: " + edf + "   RECORD ID : " + record_id + "<BR>");
    }

    #region Release IMEI
    public static bool RWL_EDFIMEIRelease(string x_sOrder_id)
    {
        if (x_sOrder_id.Equals(string.Empty)) return false;
        string _sQuery9 = "UPDATE " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder SET ";
        _sQuery9 += " edf_no='', ";
        _sQuery9 += " imei_no='' ";
        _sQuery9 += " where order_id='" + x_sOrder_id + "'";
        return SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_sQuery9);
    }
    #endregion

}
