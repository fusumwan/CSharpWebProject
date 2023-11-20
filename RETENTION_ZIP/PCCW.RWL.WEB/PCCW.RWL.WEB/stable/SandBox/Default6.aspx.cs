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
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
public partial class SandBox_Default6 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
        BusinessVasNameRecord _oBusinessVasNameRecord = new BusinessVasNameRecord(SYSConn<MSSQLConnect>.Connect(), 1);
        SessionFactory<MSSQLConnect> _oSessionFactory = new SessionFactory<MSSQLConnect>();
        ISession<MSSQLConnect> _oSession = null;
        using (_oSession = _oSessionFactory.OpenSession())
        using (ITransaction _oTransaction = _oSession.BeginTransaction())
        {
            if (_oBusinessVasNameRecord.GetFound())
            {
                bool _bUpdate;
                _oBusinessVasNameRecord.active = true;
                _bUpdate=_oSession.Update(_oBusinessVasNameRecord);
                if (_bUpdate)
                {
                    _oTransaction.Rollback();
                }
            }
        }
    }
}
