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
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

public partial class HelpTool_ReleaseCancelOrderIMEI : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();


        /*
        ReleaseOrderIMEI("21366/HR10SEP");
        ReleaseOrderIMEI("21540/HR10SEP");
        ReleaseOrderIMEI("79109/HR10AUG");
        ReleaseOrderIMEI("21532/HR10SEP");
        ReleaseOrderIMEI("21493/HR10SEP");
        */
        /*
        ReleaseOrderIMEI("21485/HR10SEP");
        ReleaseOrderIMEI("82879/HR10SEP");
        ReleaseOrderIMEI("21436/HR10SEP");
        ReleaseOrderIMEI("82865/HR10SEP");
        
        ReleaseOrderIMEI("52308/HR10SEP");
        ReleaseOrderIMEI("82852/HR10SEP");
        ReleaseOrderIMEI("82839/HR10SEP");
        ReleaseOrderIMEI("82838/HR10SEP");
        ReleaseOrderIMEI("41305/HR10SEP");
        ReleaseOrderIMEI("82832/HR10SEP");
        ReleaseOrderIMEI("82831/HR10SEP");
        ReleaseOrderIMEI("82825/HR10SEP");
        ReleaseOrderIMEI("21373/HR10SEP");
        ReleaseOrderIMEI("41299/HR10SEP");
        ReleaseOrderIMEI("41295/HR10SEP");
        ReleaseOrderIMEI("52268/HR10SEP");
        ReleaseOrderIMEI("82797/HR10SEP");
        ReleaseOrderIMEI("82788/HR10SEP");
        ReleaseOrderIMEI("82778/HR10SEP");
        ReleaseOrderIMEI("41270/HR10SEP");
        ReleaseOrderIMEI("82757/HR10SEP");
        */
    }

    public void ReleaseOrderIMEI(string x_sEdf_no)
    {
        string _sToday = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        string _sToday1 = DateTime.Now.ToString("yyyyMMdd");
        string _sToday2 = DateTime.Now.ToString("yyyy-MM-dd");
        OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT * FROM IMEI_STOCK WHERE referenceno='" + x_sEdf_no + "'");
        if (_oDr.Read())
        {
            string _sIMEI = Func.FR(_oDr["IMEI"]).Trim();
            string _sRecord_ID = Func.FR(_oDr["DUMMY4"]).Trim();
            string _sKit_Code = Func.FR(_oDr["Kit_Code"]).Trim();
            string _sModel = Func.FR(_oDr["Model"]).Trim();
            string _sStatus = Func.FR(_oDr["Status"]).Trim();
            string _sReferenceNo = Func.FR(_oDr["ReferenceNo"]).Trim();
            string _sDummy1 = Func.FR(_oDr["Dummy1"]).Trim();
            string _sDummy2 = Func.FR(_oDr["Dummy2"]).Trim();
            string _sDummy3 = Func.FR(_oDr["Dummy3"]).Trim();
            string _sStock_In_Date = Func.FR(_oDr["Stock_In_Date"]).Trim();
            string _sDummy4 = Func.FR(_oDr["DUMMY4"]).Trim();
            string _sAment_date = DateTime.Now.ToString("yyyymmdd");
            if (!string.IsNullOrEmpty(_sIMEI))
            {
                string _sQuery2 = "SELECT * FROM IMEI_STOCK WHERE referenceno!='" + x_sEdf_no + "' and IMEI='" + _sIMEI + "' AND (STATUS='SOLD' or STATUS='STOCK') ";
                OdbcDataReader _oDr2 = SYSConn<ODBCConnect>.Connect().GetSearch(_sQuery2);
                if (!_oDr2.Read())
                {
                    //'===== assign to waiting list (AO / AWAIT) -> release old & assign new =====
                    bool _bUpdate1 = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(" UPDATE IMEI_Stock SET Status='CANCEL', Dummy1='',IMEI='A" + _sIMEI + "' WHERE Dummy2='CC RET' AND (IMEI not like 'FG%' OR IMEI=' ' OR IMEI is null) AND DUMMY4='" + _sRecord_ID + "' and imei='" + _sIMEI + "'  AND rownum<=1");
                    bool _bUpdate2 = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("INSERT INTO IMEI_Stock_hist (Kit_Code,Model,Status,ReferenceNo,Create_Date,Create_By,Dummy1,Dummy2,Dummy3,Stock_In_Date,DUMMY4,IMEI,Ament_Date) values ('" + _sKit_Code + "','" + _sModel + "','" + _sKit_Code + "','" + _sReferenceNo + "',to_date('" + _sToday + "' , 'dd/mm/yyyy hh24:mi:ss'),'" + string.Empty + "','" + _sDummy1 + "','" + _sDummy2 + "','" + _sDummy3 + "','" + _sStock_In_Date + "','" + _sDummy4 + "','" + _sIMEI + "',to_date('" + _sAment_date + "' , 'yyyymmdd')) ");
                    global::System.Data.Odbc.OdbcDataReader _oDr4 = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT * from IMEI_Stock where Kit_Code='" + _sKit_Code+ "' AND Dummy2='CC RET' AND Status in ('AWAIT','AO')  order by Create_Date");
                    if (_oDr4.Read())
                    {
                        string _sQueryUp = " UPDATE IMEI_Stock set Status='STOCK', IMEI='" + _sIMEI + "', Completed_Date='" + _sToday1 + "' where Dummy2='CC RET' and (IMEI not like 'FG%' or IMEI=' ' or IMEI is null) and DUMMY4='" + _oDr4["DUMMY4"].ToString().Trim() + "' and Kit_Code='" + _sKit_Code + "' and Status in ('AWAIT','AO') AND rownum<=1";
                        bool _bUpdate3 = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_sQueryUp);
                    }
                    _oDr4.Close();
                    _oDr4.Dispose();
                }
                _oDr2.Close();
                _oDr2.Dispose();
            }
        }
        _oDr.Close();
        _oDr.Dispose();
    }



}
