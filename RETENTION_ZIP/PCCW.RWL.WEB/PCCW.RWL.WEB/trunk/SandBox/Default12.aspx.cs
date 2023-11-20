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
using System.Data.Linq;

public partial class SandBox_Default12 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
        Test1();
    }


    protected void Test1()
    {
        BusinessVasNameRecordRepository _oBusinessVasNameRecordRepository = new BusinessVasNameRecordRepository(SYSConn<MSSQLConnect>.Connect());
        Table<BusinessVasNameRecordEntity> BusinessVasNameRecordEntityArr=  _oBusinessVasNameRecordRepository.GetTable<BusinessVasNameRecordEntity>();
        foreach (BusinessVasNameRecordEntity item in BusinessVasNameRecordEntityArr)
        {
            Response.Write("name:" + item.vas_field.ToString()+"<br>");
        }
    }
}
