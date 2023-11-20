using System;
using System.Collections;
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
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;



public partial class SyncDeliveryTimeProcess : NEURON.WEB.UI.BasePage
{

    private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
    protected void Page_Load(object sender, EventArgs e)
    {


        InitFrame();
    }

    public void InitFrame()
    {
        Response.Clear();
        if (WebFunc.qsUpdate.ToUpper().Trim() != "YES")
        {
            string _sQuery = "select top 1  location,am,pm,pm6_8,pm7_9,delivery_fee from csc." +Configurator.MSSQLTablePrefix+ "DeliveryTimeRecord with (nolock) where active=1 and location='" +WebFunc.qsLocation.Trim()+ "'";
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
            while (_oDr.Read())
            {
                Response.Write("|");
                bool _bAm;
                if (bool.TryParse(Func.FR(_oDr[DeliveryTimeRecord.Para.am]).Trim(), out _bAm))
                {
                    if (_bAm)
                    {
                        Response.Write("AM");
                        Response.Write("|");
                    }
                }
                bool _bPm;
                if (bool.TryParse(Func.FR(_oDr[DeliveryTimeRecord.Para.pm]).Trim(), out _bPm))
                {
                    if (_bPm)
                    {
                        Response.Write("PM");
                        Response.Write("|");
                    }
                }
                bool _bPm6_8;
                if (bool.TryParse(Func.FR(_oDr[DeliveryTimeRecord.Para.pm6_8]).Trim(), out _bPm6_8))
                {
                    if (_bPm6_8)
                    {
                        Response.Write("18-20");
                        Response.Write("|");
                    }
                }
                bool _bPm7_9;
                if (bool.TryParse(Func.FR(_oDr[DeliveryTimeRecord.Para.pm7_9]).Trim(), out _bPm7_9))
                {
                    if (_bPm7_9)
                    {
                        Response.Write("20-22");
                        Response.Write("|");
                    }
                }
                Response.Write("__|");
                Response.Write(Func.FR(_oDr[DeliveryTimeRecord.Para.delivery_fee]).Trim());
            }
            
            _oDr.Close();
            _oDr.Dispose();
        }
        else if (WebFunc.qsUpdate == "YES")
        {
            string _sQuery = "select location from csc." +Configurator.MSSQLTablePrefix+ "DeliveryTimeRecord with (nolock) where active=1 and area='" +WebFunc.qsArea+ "' order by location";
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
            while (_oDr.Read())
            {
                Response.Write(Func.FR(_oDr[DeliveryTimeRecord.Para.location]).Trim());
                Response.Write("@");
            }
            _oDr.Close();
            _oDr.Dispose();
        }
    }


    #region GetDB
    protected MSSQLConnect GetDB()
    {
        MSSQLConnect _oDB = new MSSQLConnect();
        _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
        _oDB.bWithNoLock = true;
        return _oDB;
    }
    #endregion


}
