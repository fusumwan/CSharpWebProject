using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
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

public partial class HelpTools_InsertDAOImei : System.Web.UI.Page
{
    EDFStatusProfile _oEDFStatusProfile = new EDFStatusProfile();
    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
    }
}
