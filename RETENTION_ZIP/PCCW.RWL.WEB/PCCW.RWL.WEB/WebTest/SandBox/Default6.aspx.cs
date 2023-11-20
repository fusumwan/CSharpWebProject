using System;
using System.Collections.Generic;
using System.Threading;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Text;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

public partial class SandBox_Default6 : System.Web.UI.Page
{
    EDFStatusProfile _oEDFStatusProfile = new EDFStatusProfile();
    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();



    }
}
