﻿using System;
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

public partial class SandBox_DeleteEDFRecord : System.Web.UI.Page
{
    EDFStatusProfile _oEDFStatusProfile = new EDFStatusProfile();
OrderSerialNumberControl _oOrderSerialNumberControl = new OrderSerialNumberControl();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
        InitFrame();
    }

    public void InitFrame()
    {
        //DeleteEDFRecord("60540/HR10MAR", "385999", " AND CANCELLED='N'");
    }

    public void DeleteEDFRecord(string edf, string record_id,string filter)
    {
        if (_oEDFStatusProfile.DeleteEDFRecord(edf, record_id,filter))
            Response.Write("DELETE : EDF: " + edf + "   RECORD ID : " + record_id + "<BR>");
        else
            Response.Write("DELETE FAIL : EDF: " + edf + "   RECORD ID : " + record_id + "<BR>");
    }
}
