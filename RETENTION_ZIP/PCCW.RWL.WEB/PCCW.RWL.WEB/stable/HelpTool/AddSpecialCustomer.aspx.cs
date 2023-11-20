using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.Xml;
using System.Data.Odbc;
using System.Linq;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using System.IO;
public partial class HelpTools_AddSpecialCustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
        string _sTesting = string.Empty;
        MemoryStream ms = new MemoryStream();

        SpecialCustomer _oSpecialCustomer = new SpecialCustomer(SYSConn<MSSQLConnect>.Connect());
        _oSpecialCustomer.SetActive(true);
        _oSpecialCustomer.SetHkid("K684252");
        _oSpecialCustomer.SetCid("80188519");
        _oSpecialCustomer.SetCdate(DateTime.Now);
        _oSpecialCustomer.SetCount(1);
        _oSpecialCustomer.SetStatus("IPHONE_CUSTOMER_MAX_ISSUE_ORDER");
        SpecialCustomerBal.InsertWithOutLastID(SYSConn<MSSQLConnect>.Connect(), _oSpecialCustomer);

    }
}
