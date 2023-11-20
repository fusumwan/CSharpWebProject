using System;
using System.Collections;
using System.Collections.ObjectModel;
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
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using log4net;
using System.Reflection;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;


public partial class ProgramIDAddAction : NEURON.WEB.UI.BasePage
{
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {


        WebFunc.PrivilegeCheck(this.Page);
        if (!IsPostBack) { InitFrame(); }
    }

    public void InitFrame()
    {
        int _iProgram_id = (WebFunc.qsProgram_id!=null)? (int)WebFunc.qsProgram_id : -1;
        string _sCall_list_type = WebFunc.qsCall_list_type;
        string _sProgram_name = WebFunc.qsProgram_name;
        string _sCenter = WebFunc.qsCenter;
        string _sExpiry_month = string.Empty;
        if (WebFunc.qsExpiry_month != "/")
            _sExpiry_month = WebFunc.qsExpiry_month;
        else
            _sCenter = string.Empty;

        string _sType = (WebFunc.qsType.Trim()!=string.Empty)? WebFunc.qsType.Trim() : "''";
        string _sCall_list_size = string.Empty;
        if (WebFunc.qsCall_list_type != string.Empty)
            _sCall_list_size = "'" + WebFunc.qsCall_list_size + "'";
        else
            _sCall_list_type = "''";

        string _sRemarks = string.Empty;
        if (WebFunc.qsRemarks != string.Empty)
            _sRemarks = "'" + WebFunc.qsRemarks + "'";
        else
            _sRemarks = "''";

        string _sCid = string.Empty;
        if (WebFunc.qsCid != string.Empty)
            _sCid = "'" + WebFunc.qsCid.Trim() + "'";
        else
            _sCid = "''";
        string _sProd_status = string.Empty;

        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT * FROM " + Configurator.MSSQLTablePrefix + "RetentionProgramKey WHERE program_id=" + _iProgram_id.ToString() + " and active=1");
        if (!_oDr.Read())
        {
            RetentionProgramKey _oRetentionProgramKey = (RetentionProgramKey)RetentionProgramKeyRepository.CreateEntityInstanceObject();
            _oRetentionProgramKey.SetProgram_id(_iProgram_id);
            _oRetentionProgramKey.SetCall_list_type(_sCall_list_type);
            _oRetentionProgramKey.SetProgram_name(_sProgram_name);
            _oRetentionProgramKey.SetCenter(_sCenter);
            _oRetentionProgramKey.SetExpiry_month(_sExpiry_month);
            _oRetentionProgramKey.SetType(_sType);
            _oRetentionProgramKey.SetCall_list_size(_sCall_list_size);
            _oRetentionProgramKey.SetRemarks(_sRemarks);
            _oRetentionProgramKey.SetSdate(WebFunc.qsSdate);
            _oRetentionProgramKey.SetEdate(WebFunc.qsEdate);
            _oRetentionProgramKey.SetReturn_date(WebFunc.qsReturn_date);
            _oRetentionProgramKey.SetUpload_date(WebFunc.qsUpload_date);
            _oRetentionProgramKey.SetCid(_sCid);
            _oRetentionProgramKey.SetCdate(DateTime.Now);
            _oRetentionProgramKey.SetActive(true);
            int _iLastID = -1;
            using(ISession<MSSQLConnect> _oSession=(new SessionFactory<MSSQLConnect>()).OpenSession())
            using (ITransaction _oTransaction = _oSession.BeginTransaction())
            {
                _iLastID=_oSession.InsertReturnID(_oRetentionProgramKey, true);
                _oTransaction.Commit();
            }
            if (_iLastID != -1) _sProd_status = " has been Created.";
        }
        else
            _sProd_status = " in existing record.";
        _oDr.Close();
        _oDr.Dispose();
        Response.Clear();

        RetentionProgramKeyEntity[] _oRetentionProgramKeys = RetentionProgramKeyBal.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), "program_id=" + _iProgram_id.ToString() + " and active=1", null, null);
        if (_oRetentionProgramKeys != null)
        {
            foreach (RetentionProgramKey _oRetentionProgramKey in _oRetentionProgramKeys)
            {
                Response.Write("The Program ID " + _sProd_status);
                Response.Write("Program ID:" + Func.FR(_oRetentionProgramKey.program_id));
                Response.Write("Call List Type:" + Func.FR(_oRetentionProgramKey.call_list_type));
                Response.Write("Program Name:" + Func.FR(_oRetentionProgramKey.program_name));
                Response.Write("Center:" + Func.FR(_oDr[_oRetentionProgramKey.center]));
                Response.Write("Expriy Month:" + Func.FR(_oDr[_oRetentionProgramKey.expiry_month]));
                Response.Write("Type:" + Func.FR(_oDr[_oRetentionProgramKey.type]));
                Response.Write("Remarks:" + Func.FR(_oDr[_oRetentionProgramKey.remarks]));
                if(_oRetentionProgramKey.upload_date!=null)
                    Response.Write("Call List Upload Date:" + ((DateTime)_oRetentionProgramKey.upload_date).ToString("dd-MM-yyyy"));
                if(_oRetentionProgramKey.sdate!=null)
                    Response.Write("Start Date:" + ((DateTime)_oRetentionProgramKey.sdate).ToString("dd-MM-yyyy"));
                if (_oRetentionProgramKey.edate!=null)
                    Response.Write("End Date:" + ((DateTime)_oRetentionProgramKey.edate).ToString("dd-MM-yyyy"));
                if (_oRetentionProgramKey.return_date!=null)
                    Response.Write("Return Date:" + ((DateTime)_oRetentionProgramKey.return_date).ToString("dd-MM-yyyy"));
                if (_oRetentionProgramKey.cdate !=null)
                    Response.Write("Create Date:" + ((DateTime)_oRetentionProgramKey.cdate).ToString("dd-MM-yyyy"));
                Response.Write("Create Staff:" + Func.FR(_oDr[_oRetentionProgramKey.cid]));
            }
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
