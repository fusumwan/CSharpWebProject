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
public partial class SandBox_Default6 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        RWLFramework.DataBaseConfigSetting();
        MobileOrderVasRevision _oMobileOrderVasRevision = new MobileOrderVasRevision(SYSConn<MSSQLConnect>.Connect());
        SessionFactory<MSSQLConnect> _oSessionFactory = new SessionFactory<MSSQLConnect>();
        ISession<MSSQLConnect> _oSession = null;
        using (_oSession = _oSessionFactory.OpenSession())
        using (ITransaction _oTransaction = _oSession.BeginTransaction())
        {

                bool _bUpdate;
                _oMobileOrderVasRevision.active = true;
                _oMobileOrderVasRevision.cdate = DateTime.Now;
                _oMobileOrderVasRevision.fee = string.Empty;
                _oMobileOrderVasRevision.vas_field = "min_vas";
                _oMobileOrderVasRevision.order_id = 1;
                _oMobileOrderVasRevision.vas_id = 1;
                _oMobileOrderVasRevision.vas_value = "100";
                _bUpdate = _oSession.Insert(_oMobileOrderVasRevision);
                if (_bUpdate)
                {
                    _oTransaction.Commit();
                }

        }

    }
}
