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
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;


public partial class DeliveryAddressModifyImplement : NEURON.WEB.UI.BasePage
{
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion
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

        WebFunc.PrivilegeCheck(this.Page);
        try
        {
            if (!IsPostBack) { 
                InitFrame();
            }
        }
        catch (Exception exp)
        {
            Logger.ErrorFormat("DeliveryAddressModifyImplement ERROR :{0}", exp.ToString());
            Response.Redirect("MobileRetentionMain.aspx");
        }
        Response.Redirect("DeliveryAddress.aspx");
    }
    public void InitFrame()
    {
        int _iAm = 0;
        int _iPm = 0;
        int _iPm6_8 = 0;
        int _iPm7_9 = 0;
        int _iPm8_10 = 0;
        string _sLocation = WebFunc.qsLocation;
        string _sLocation_am = (Request[_sLocation + ",am"] != null) ? Request[_sLocation + ",am"].ToString() : string.Empty;
        string _sLocation_pm = (Request[_sLocation + ",pm"] != null) ? Request[_sLocation + ",pm"].ToString() : string.Empty;
        string _sLocation_pm6_8 = (Request[_sLocation + ",pm6_8"] != null) ? Request[_sLocation + ",pm6_8"].ToString() : string.Empty;
        string _sLocation_pm7_9 = (Request[_sLocation + ",pm7_9"] != null) ? Request[_sLocation + ",pm7_9"].ToString() : string.Empty;
        string _sLocation_pm8_10 = (Request[_sLocation + ",pm8_10"] != null) ? Request[_sLocation + ",pm8_10"].ToString() : string.Empty;
        string _sAreas = (Request[_sLocation + ",area"] != null) ? Request[_sLocation + ",area"].ToString() : string.Empty;
        string _sDelivery_fee = (Request[_sLocation + ",delivery_fee"] != null) ? Request[_sLocation + ",delivery_fee"].ToString() : string.Empty;
        if ("on".Equals(_sLocation_am))
            _iAm = 1;
        else
            _iAm = 0;

        if ("on".Equals(_sLocation_pm))
            _iPm = 1;
        else
            _iPm = 0;

        if ("on".Equals(_sLocation_pm6_8))
            _iPm6_8 = 1;
        else
            _iPm6_8 = 0;

        if ("on".Equals(_sLocation_pm7_9))
            _iPm7_9 = 1;
        else
            _iPm7_9 = 0;

        if ("on".Equals(_sLocation_pm8_10))
            _iPm8_10 = 1;
        else
            _iPm8_10 = 0;

        DeliveryTimeRecordRepositoryBase _oDeliveryTimeRecordRepositoryBase = new DeliveryTimeRecordRepositoryBase(GetDB());
        IQueryable<DeliveryTimeRecordEntity> _oDeliveryTimeRecordList = from sDeliveryTimeRecordList in _oDeliveryTimeRecordRepositoryBase.DeliveryTimeRecords where sDeliveryTimeRecordList.location.Trim() == _sLocation.Trim() select sDeliveryTimeRecordList;

        if (_oDeliveryTimeRecordList.Count<DeliveryTimeRecordEntity>() > 0)
        {
            DeliveryTimeRecordEntity[] _oItemList = _oDeliveryTimeRecordList.ToArray();
            using (ISession<MSSQLConnect> _oSession = (new SessionFactory<MSSQLConnect>()).OpenSession())
            using (ITransaction _oTransaction = _oSession.BeginTransaction())
            {
                bool _bRollBack = false;
                for (int i = 0; i < _oItemList.Length; i++)
                {
                    _oItemList[i].SetDB(GetDB());
                    _oItemList[i].SetAm(Convert.ToBoolean(_iAm));
                    _oItemList[i].SetPm(Convert.ToBoolean(_iPm));
                    _oItemList[i].SetPm6_8(Convert.ToBoolean(_iPm6_8));
                    _oItemList[i].SetPm7_9(Convert.ToBoolean(_iPm7_9));
                    _oItemList[i].SetPm8_10(Convert.ToBoolean(_iPm8_10));
                    _oItemList[i].SetArea(_sAreas);
                    int _iDelivery_fee;
                    if (int.TryParse(_sDelivery_fee.Trim(), out _iDelivery_fee))
                        _oItemList[i].SetDelivery_fee(_iDelivery_fee);
                    else
                        _oItemList[i].SetDelivery_fee(null);

                    if (!_oSession.Update(_oItemList[i]))
                    {
                        _bRollBack = true;
                        break;
                    }
                }

                if (!_bRollBack)
                    _oTransaction.Commit();
                else
                    _oTransaction.Rollback();
            }
        }

        LocationTimeMemory.Instance().Release();
        LocationTimeMemory.Instance().PreLoadDataToMemory(true);
        
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

    #region Get Oracle DB
    protected ODBCConnect GetORDB()
    {
        ODBCConnect _oDB = new ODBCConnect();
        _oDB.SetConnStr(Configurator.DBName.ORADNS + ((!"".Equals(Configurator.IsUat())) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion
}
