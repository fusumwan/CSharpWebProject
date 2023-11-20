using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using log4net;
using System.Reflection;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

public partial class Web_DeliveryAddress : System.Web.UI.Page
{
    DataSet _oLocationDS=null;
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
        //WebFunc.PrivilegeCheck(this.Page);
        if (!IsPostBack) 
            InitFrame();

        

        DeliveryLocationObj.ConnectionString = SYSConn<MSSQLConnect>.Connect().ConnectionStr;
    }

    protected void InitFrame(){

    }

    protected DataSet LocationDataBind(){
        if(_oLocationDS==null){
            StringBuilder _oQuery=new StringBuilder();
            _oQuery.Append("SELECT distinct location FROM DeliveryLocation");
            _oLocationDS=SYSConn<MSSQLConnect>.Connect().GetDS(_oQuery.ToString());
        }
        return _oLocationDS; 
    }
    protected void DeliveryLocationGv_Init(object sender, EventArgs e)
    {

    }
    protected void DeliveryLocationObj_Init(object sender, EventArgs e)
    {
        DeliveryLocationObj.ConnectionString = SYSConn<MSSQLConnect>.Connect().ConnectionStr;
    }
    protected void DeliveryLocationGv_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        if (e.RowIndex > 0)
        {
            GridView _oGridView = (GridView)sender;
            GridViewRow _oGridViewRow = (GridViewRow)_oGridView.Rows[e.RowIndex];

            int _iId;
            string _sId = DeliveryLocationGv.DataKeys[e.RowIndex]["id"].ToString();
            if (int.TryParse(_sId, out _iId))
            {
                string _sArea = DeliveryLocationGv.DataKeys[e.RowIndex]["area"].ToString();
            }
        }
    }
}
