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
using System.Text;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;


public partial class ReleaseOrderAction : NEURON.WEB.UI.BasePage
{

    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion
    ODBCConnect n_oORDB = null;
    MSSQLConnect n_oDB = null;
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

    #region InitFrame
    public void InitFrame()
    {
        StringBuilder _oQuery = new StringBuilder();
        OrderReleaseDetail _oOrderReleaseDetail = (OrderReleaseDetail)OrderReleaseDetailRepository.CreateEntityInstanceObject();
        int _iOrder_id;
        if (int.TryParse(Func.IDSubtract100000(WebFunc.qsOrder_id), out _iOrder_id))
        {
            MobileRetentionOrderEntity _oMobileRetentionOrderEntity = new MobileRetentionOrderEntity(SYSConn<MSSQLConnect>.Connect());
            _oMobileRetentionOrderEntity.SetOrder_id(_iOrder_id);
            _oMobileRetentionOrderEntity.Retrieve();
            if (_oMobileRetentionOrderEntity.GetOrder_id() != null && 
                _oMobileRetentionOrderEntity.GetFound() && 
                _oMobileRetentionOrderEntity.GetHs_model().Trim().Equals(string.Empty))
            {
                MobileRetentionOrderRepositoryBase _oMobileRetentionOrderRepositoryBase = MobileRetentionOrderRepositoryBase.Instance();
                IQueryable<MobileRetentionOrderEntity> _oMobileRetentionOrderEntityList = from sMobileRetentionOrderList in _oMobileRetentionOrderRepositoryBase.MobileRetentionOrders
                                                                                      where
                                                                                          sMobileRetentionOrderList.order_id == _iOrder_id
                                                                                      select sMobileRetentionOrderList;

                if (_oMobileRetentionOrderEntityList.Count<MobileRetentionOrderEntity>() > 0)
                {
                    if (WebFunc.qsOrder_id != null) _oOrderReleaseDetail.SetOrder_id(_iOrder_id);
                    if (WebFunc.qsActive != null) _oOrderReleaseDetail.SetActive(true);
                    _oOrderReleaseDetail.SetCid(RWLFramework.CurrentUser[this.Page].Uid);
                    _oOrderReleaseDetail.SetCdate(DateTime.Now);
                    using (ISession<MSSQLConnect> _oSession = (new SessionFactory<MSSQLConnect>()).OpenSession())
                    using (ITransaction _oTransaction = _oSession.BeginTransaction())
                    {
                        _oSession.Insert(_oOrderReleaseDetail);
                        _oTransaction.Commit();
                    }
                }
                else
                    Response.Redirect("ReleaseOrder.aspx?error=error");
            }
            else
                Response.Redirect("ReleaseOrder.aspx?error=cancel");
        }
        else
            Response.Redirect("ReleaseOrder.aspx?error=error");
    }
    #endregion

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
        _oDB.SetConnStr(Configurator.DBName.ORADNS+((Configurator.IsUat()) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion
}
