using System;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml.Linq;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Xml;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using PCCW.RWL.COMMON;
using PCCW.RWL.CORE;

public partial class SandBox_Default9 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.HeaderScripts.Text = string.Format(
        @"<script type=""text/javascript"" src=""{0}/Resources/Scripts/jquery-1.3.2.min.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/global.js""></script>
        <!--[if lte IE 6]><script defer type=""text/javascript"" src=""{0}/Resources/Scripts/pngfix.js""></script><![endif]-->
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/norefresh.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/script.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/jquery-ui-1.8.2.custom.min.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/jquery.alerts.js""></script>
        <link rel=""stylesheet"" href=""{0}/Resources/Styles/jquery.alerts.css"" type=""text/css"" />"
       , Request.ApplicationPath);
	   
        RWLFramework.DataBaseConfigSetting();
        MobileOrderThreeParty _oMobileOrderThreeParty = new MobileOrderThreeParty(SYSConn<MSSQLConnect>.Connect());
        _oMobileOrderThreeParty.arthurization_person = "aaa";
        _oMobileOrderThreeParty.contact_no = "1232131";
        _oMobileOrderThreeParty.hkid = "adfasdfsaF";
       int _iOldID=  MobileOrderThreePartyRepository.InsertReturnLastID_SP(SYSConn<MSSQLConnect>.Connect(), _oMobileOrderThreeParty);
       if (_iOldID > 0)
       {

       }
    }
}
