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
using log4net;
using System.Reflection;
using System.Globalization;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

public partial class VasAddRelationMappingImplement : NEURON.WEB.UI.BasePage
{
    string[] n_sDateTimeList = new string[] { 
        "MM/dd/yyyy", "MM/dd/yyyy HH:mm","MM/dd/yyyy H:mm","MM/dd/yyyy H:m","MM/dd/yyyy H:mm:ss","MM/dd/yyyy H:m:ss",  "MM/dd/yyyy HH:mm:ss",
        "MM/dd/yyyy tt ", "MM/dd/yyyy HH:mm tt ","MM/dd/yyyy H:mm tt","MM/dd/yyyy H:m tt","MM/dd/yyyy H:mm:ss tt","MM/dd/yyyy H:m:ss tt",  "MM/dd/yyyy HH:mm:ss tt",
        "MM/dd/yyyy tt ", "MM/dd/yyyy hh:mm tt ","MM/dd/yyyy h:mm tt","MM/dd/yyyy h:m tt","MM/dd/yyyy h:mm:ss tt","MM/dd/yyyy h:m:ss tt",  "MM/dd/yyyy hh:mm:ss tt",
        "MM/dd/yyyy tt ", "MM/dd/yyyy tt hh:mm ","MM/dd/yyyy tt h:mm","MM/dd/yyyy tt h:m","MM/dd/yyyy tt h:mm:ss","MM/dd/yyyy tt h:m:ss",  "MM/dd/yyyy tt hh:mm:ss",


        "M/dd/yyyy", "M/dd/yyyy HH:mm", "M/dd/yyyy H:mm", "M/dd/yyyy H:m","M/dd/yyyy H:mm:ss", "M/dd/yyyy H:m:ss", "M/dd/yyyy HH:mm:ss",
        "M/dd/yyyy tt", "M/dd/yyyy HH:mm tt", "M/dd/yyyy H:mm tt", "M/dd/yyyy H:m tt","M/dd/yyyy H:mm:ss tt", "M/dd/yyyy H:m:ss tt", "M/dd/yyyy HH:mm:ss tt",
        "M/dd/yyyy tt", "M/dd/yyyy hh:mm tt", "M/dd/yyyy h:mm tt", "M/dd/yyyy h:m tt","M/dd/yyyy h:mm:ss tt", "M/dd/yyyy h:m:ss tt", "M/dd/yyyy h:mm:ss tt",
        "M/dd/yyyy tt", "M/dd/yyyy hh:mm", "M/dd/yyyy tt h:mm", "M/dd/yyyy tt h:m","M/dd/yyyy tt h:mm:ss", "M/dd/yyyy tt h:m:ss", "M/dd/yyyy tt h:mm:ss",


        "MM/d/yyyy", "MM/d/yyyy HH:mm","MM/d/yyyy H:mm","MM/d/yyyy H:m","MM/d/yyyy H:mm:ss","MM/d/yyyy H:m:ss", "MM/d/yyyy HH:mm:ss",
        "MM/d/yyyy tt", "MM/d/yyyy HH:mm tt","MM/d/yyyy H:mm tt","MM/d/yyyy H:m tt","MM/d/yyyy H:mm:ss tt","MM/d/yyyy H:m:ss tt", "MM/d/yyyy HH:mm:ss tt",
        "MM/d/yyyy tt", "MM/d/yyyy hh:mm tt","MM/d/yyyy h:mm tt","MM/d/yyyy h:m tt","MM/d/yyyy h:mm:ss tt","MM/d/yyyy h:m:ss tt", "MM/d/yyyy hh:mm:ss tt",
        "MM/d/yyyy tt", "MM/d/yyyy tt hh:mm","MM/d/yyyy tt h:mm","MM/d/yyyy tt h:m","MM/d/yyyy tt h:mm:ss","MM/d/yyyy h:m:ss tt", "MM/d/yyyy tt hh:mm:ss",

        "M/d/yyyy", "M/d/yyyy HH:mm","M/d/yyyy H:mm","M/d/yyyy H:m","M/d/yyyy H:mm:ss","M/d/yyyy H:m:ss", "M/d/yyyy HH:mm:ss",
        "M/d/yyyy tt", "M/d/yyyy HH:mm tt","M/d/yyyy H:mm tt","M/d/yyyy H:m tt","M/d/yyyy H:mm:ss tt","M/d/yyyy H:m:ss tt", "M/d/yyyy HH:mm:ss tt",
        "M/d/yyyy tt", "M/d/yyyy hh:mm tt","M/d/yyyy h:mm tt","M/d/yyyy h:m tt","M/d/yyyy h:mm:ss tt","M/d/yyyy h:m:ss tt", "M/d/yyyy hh:mm:ss tt",
        "M/d/yyyy tt", "M/d/yyyy tt hh:mm","M/d/yyyy tt h:mm","M/d/yyyy tt h:m","M/d/yyyy tt h:mm:ss","M/d/yyyy tt h:m:ss", "M/d/yyyy tt hh:mm:ss"
        };

    private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
    BundleMappingRepositoryBase n_oBundleMappingRepositoryBase = BundleMappingRepositoryBase.Instance();
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
        if (!IsPostBack) InitFrame();
    }

    public void InitFrame()
    {
        DateTime _dOldsdate;
        DateTime.TryParseExact(Func.RQ(Request["sdate"]), n_sDateTimeList, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dOldsdate);
        DateTime _dOldedate;
        DateTime.TryParseExact(Func.RQ(Request["edate"]), n_sDateTimeList, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dOldedate);

        Nullable<DateTime> _dSdate = null;
        Nullable<DateTime> _dEdate = null;

        if (_dOldsdate != null)
            _dSdate = _dOldsdate;

        if (_dOldedate != null)
            _dEdate = _dOldedate;

        string _sId = Func.RQ(WebFunc.qsId).ToString();
        string _sRate_plan = Func.RQ(Request["rate_plan"+_sId]);
        string _sBundle_name = Func.RQ(Request["bundle_name"+_sId]);
        string _sHs_model = Func.RQ(Request["hs_model" + _sId]);
        string _sVas_field = Func.RQ(Request["vas_field"+_sId]);
        string _sProgram =Func.RQ(Request["program"+_sId]);
        string _sModflag = Func.RQ(Request["modflag"+_sId]);
        string _sNormal_rebate_type = Func.RQ(Request["normal_rebate_type"+_sId]);
        string _sIssue_type = Func.RQ(Request["issue_type" + _sId]);

        int _iView = 1;
        if ("1".Equals(_sModflag))
        {
            IQueryable<BundleMappingEntity> _oBundleMappingList = from sBundleMappingList in n_oBundleMappingRepositoryBase.BundleMappings
                                                                          where
                                                                              sBundleMappingList.id.ToString() == _sId
                                                                          select sBundleMappingList;
            if (_oBundleMappingList.Count<BundleMappingEntity>() > 0)
            {
                BundleMappingEntity _oItem = _oBundleMappingList.First<BundleMappingEntity>();
                _oItem.SetDB(GetDB());
                _oItem.SetRate_plan(_sRate_plan);
                _oItem.SetBundle_name(_sBundle_name);
                _oItem.SetHs_model(_sHs_model);
                _oItem.SetVas_field(_sVas_field);
                _oItem.SetProgram(_sProgram);
                _oItem.SetNormal_rebate_type(_sNormal_rebate_type);
                _oItem.SetSdate(_dSdate);
                _oItem.SetEdate(_dEdate);
                _oItem.SetIssue_type(_sIssue_type);
                _oItem.SetCdate(DateTime.Now);
                _oItem.SetCid(RWLFramework.CurrentUser[this.Page].Uid);
                
                using (ISession<MSSQLConnect> _oSession = (new SessionFactory<MSSQLConnect>()).OpenSession())
                using (ITransaction _oTransaction = _oSession.BeginTransaction())
                {
                    _oSession.Update(_oItem.Save());
                    _oTransaction.Commit();
                }
                _iView = 1;
            }
        }
        else
        {


            SqlDataReader _oDr = BundleMappingBal.GetSearch(GetDB(), null, " active=1 AND hs_model='"+_sHs_model+"' AND program='" + _sProgram.ToString() + "' and normal_rebate_type='" + _sNormal_rebate_type + "' and bundle_name='" + _sBundle_name.ToString() + "' and rate_plan='" + _sRate_plan.ToString() + "' and vas_field='" + _sVas_field.ToString() + "'", null, null);
            if (!_oDr.Read())
            {
                BundleMapping _oBundleMapping = new BundleMapping(GetDB());
                _oBundleMapping.SetRate_plan(_sRate_plan);
                _oBundleMapping.SetBundle_name(_sBundle_name);
                _oBundleMapping.SetHs_model(_sHs_model);
                _oBundleMapping.SetVas_field(_sVas_field);
                _oBundleMapping.SetActive(true);
                _oBundleMapping.SetCid(RWLFramework.CurrentUser[this.Page].Uid);
                _oBundleMapping.SetCdate(DateTime.Now);
                _oBundleMapping.SetProgram(_sProgram);
                _oBundleMapping.SetNormal_rebate_type(_sNormal_rebate_type);
                _oBundleMapping.SetSdate(_dSdate);
                _oBundleMapping.SetEdate(_dEdate);
                _oBundleMapping.SetIssue_type(_sIssue_type);
                using(ISession<MSSQLConnect> _oSession=(new SessionFactory<MSSQLConnect>()).OpenSession())
                using (ITransaction _oTransaction = _oSession.BeginTransaction())
                {
                    int _iOrderID= _oSession.InsertReturnID(_oBundleMapping, true);
                    if (_iOrderID > 0)
                        _oTransaction.Commit();
                    else
                        _oTransaction.Rollback();
                }
                _iView = 1;
            }
            else
                _iView = 0;

            _oDr.Close();
            _oDr.Dispose();
        }
        RWLFramework.PreLoadDataToMemory(true);

        Response.Redirect("VasAddRelationMapping.aspx?Success=YES");

        /*
        if (_iView == 0)
            Response.Redirect("VasView.aspx?view=" + _iView.ToString() + "&pass=pass&repeatset=repeatset");
        else
            Response.Redirect("VasView.aspx?view=" + _iView.ToString() + "&pass=pass&repeatset=");
         */
    }


    #region GetDB
    public static MSSQLConnect GetDB()
    {
        MSSQLConnect _oDB = new MSSQLConnect();
        _oDB.bWithNoLock = true;
        _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion
}
