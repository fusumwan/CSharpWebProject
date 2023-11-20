using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Text;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using NEURON.WEB.UI.HTMLCONTROL.JSCONTROL;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
public partial class Web_IMEIManagement_CheckWebLogAORecord : NEURON.WEB.UI.BasePage
{
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion
    #region SessionUid
    string n_sSessionUid
    {
        get
        {
            if (Session["uid"] != null)
            {
                return Session["uid"].ToString();
            }
            else
                return string.Empty;
        }
    }
    #endregion

    #region SessionLv
    string n_sSessionLv
    {
        get
        {
            if (Session["lv"] != null)
            {
                return Session["lv"].ToString();
            }
            else
                return string.Empty;
        }
    }
    #endregion

    #region SessionArprog
    string n_sSessionArprog
    {
        get
        {
            if (Session["arprog"] != null)
            {
                return Session["arprog"].ToString();
            }
            else
                return string.Empty;
        }
    }
    #endregion

    #region SessionChannel
    string n_sSessionChannel
    {
        get
        {
            if (Session["channel"] != null)
            {
                return Session["channel"].ToString();
            }
            else
                return string.Empty;
        }
    }
    #endregion
    EDFStatusProfile _oEDFStatusProfile = new EDFStatusProfile();

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

        if (!IsPostBack) { InitFrame(); }
    }

    public void InitFrame()
    {
        NeuronJSLibrary.Text = JSScriptLibrary.JSScriptCommon;
        RWLFramework.DataBaseConfigSetting();
    }

    #region PageLoadComplete
    protected void Page_LoadComplete(object sender, EventArgs e)
    {
        SetHtmlControlStyle("global-loading", HtmlTextWriterStyle.Display, "none", true, true, true);
    }
    #endregion

    #region Set HtmlControl Style By Javascript
    public string SetHtmlControlStyle(string x_sID, HtmlTextWriterStyle x_oStyle, string x_sValue, bool x_bStr, bool x_bIncludeScript, bool x_bRunRegister)
    {
        Random ran = new Random();
        string _sScript = string.Empty;
        if (x_bStr)
            _sScript = string.Format("if(ChkID('{0}')){1}GetID('{2}').style.{3}='{4}';{5}", x_sID, "{", x_sID, x_oStyle.ToString().ToLower(), x_sValue, "}");
        else
            _sScript = string.Format("if(ChkID('{0}')){1}GetID('{2}').style.{3}={4};{5}", x_sID, "{", x_sID, x_oStyle.ToString().ToLower(), x_sValue, "}");

        if (x_bIncludeScript) _sScript = "<script>" + _sScript + "</script>";
        if (x_bRunRegister)
            ScriptManager.RegisterStartupScript(this, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), _sScript, false);

        return _sScript;
    }
    #endregion

    #region RegisterJavaScript
    protected void RegisterJavaScript(string x_sID, string x_sScript, bool x_bIncludeScript)
    {
        if (x_bIncludeScript) x_sScript = "<script>" + x_sScript + "</script>";
        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), x_sScript, false);
    }
    #endregion

    #region Run Javascript Function
    public string RunJavascriptFunc(string x_sFunc, bool x_bIncludeScript)
    {
        string _sFunc = ((x_sFunc.IndexOf(';') > 0) ? x_sFunc : x_sFunc + ";");
        if (x_bIncludeScript) _sFunc = "<script>" + _sFunc + "</script>";
        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sFunc + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), _sFunc, false);
        return _sFunc;
    }

    public string RunJavascriptFunc(string x_sFunc)
    {
        return RunJavascriptFunc(x_sFunc, false);
    }
    #endregion

    #region SearchRecordID
    protected void SearchRecordID(string RecordID)
    {
        int _iRecordID;
        int _iOrder_id = -1;
        if (string.IsNullOrEmpty(find_record_id.Text.ToString()))
        {
            RunJavascriptFunc("alert('Please enter the record id number!');",true);
            return;
        }
        if (int.TryParse(RecordID, out _iRecordID))
        {
            _iOrder_id = _iRecordID - 100000;
            MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect(), _iOrder_id);
            if (_oMobileRetentionOrder.Retrieve())
            {
                if (_oMobileRetentionOrder.GetImei_no().Trim().ToUpper().Equals(IMEISTATUS.AO))
                {
                    rwl_record_id.Text = _iRecordID.ToString();
                    rwl_order_id.Text = _iOrder_id.ToString();
                    rwl_imei_no.Text = _oMobileRetentionOrder.GetImei_no().ToString();
                    rwl_edf_no.Text = _oMobileRetentionOrder.GetEdf_no().ToString();
                    rwl_hs_model.Text = _oMobileRetentionOrder.GetHs_model().ToString();
                    rwl_sku.Text = _oMobileRetentionOrder.GetSku().ToString();
                    if (rwl_edf_no.Text.ToString() != string.Empty)
                        BindData(rwl_edf_no.Text.ToString(), rwl_sku.Text.ToString());
                    else
                        BindData(rwl_record_id.Text.ToString(), rwl_sku.Text.ToString());
                }
                else
                {
                    RunJavascriptFunc("alert('This is not a AO record!')",true);
                }
            }
            else
            {
                RunJavascriptFunc("alert('Cannot find this record!')",true);
            }
        }
        else{
            RunJavascriptFunc("alert('Please kindly input the correct record id!');",true);
        }
    }
    #endregion
    protected void SearchWebLog_Click(object sender, EventArgs e)
    {
        SearchRecordID(find_record_id.Text.ToString());
    }
    protected void IMEISTOCKGW_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        switch(e.CommandName.ToUpper().ToString().Trim())
        {
            case "EDIT":
                {

                }
                break;
            case "UPDATE":
                {

                }
                break;
            case "DELETE":
                {

                }
                break;
        }
    }

    #region BindData
    protected void BindData(string EDFNO,string SKU)
    {
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("SELECT REFERENCENO,IMEI,CREATE_BY,MODEL,KIT_CODE,DUMMY4,STATUS FROM IMEI_STOCK WHERE REFERENCENO='" + EDFNO.ToString() + "' AND KIT_CODE='" + SKU + "' AND STATUS='AO' ");
        DataSet _oDS = SYSConn<ODBCConnect>.Connect().GetDS(_oQuery.ToString());
        if (_oDS == null)
            but_InsertAoCase.Enabled = false;
        else if (_oDS.Tables.Count<=0)
            but_InsertAoCase.Enabled = false;
        else
            but_InsertAoCase.Enabled = true;
        
        IMEISTOCKGW.DataSource = _oDS;
        IMEISTOCKGW.DataBind();
    }
    #endregion

    
    protected int GetIMEIAORecordCount()
    {
        string EDFNO= rwl_edf_no.Text.ToString();
        string SKU = rwl_sku.Text.ToString();
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("SELECT count(1) count FROM IMEI_STOCK WHERE REFERENCENO='" + EDFNO.ToString() + "' AND KIT_CODE='" + SKU + "' AND (STATUS='AO' OR STATUS='STOCK') ");
        string _sCount= SYSConn<ODBCConnect>.Connect().GetExecuteScalar(_oQuery.ToString());
        int _iCount=0;
        if(int.TryParse(_sCount,out _iCount)){
            return _iCount;
        }
        return _iCount;
    }



    protected void IMEISTOCKGW_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        if (e.RowIndex > -1)
        {
            string RecordID = rwl_record_id.Text.ToString().Trim();
            string EdfNo = rwl_edf_no.Text.ToString().Trim();
            string Sku = rwl_sku.Text.ToString().Trim();
            if (EdfNo.Equals(string.Empty)) { EdfNo = RecordID; }
            GridView _oGridView = (GridView)sender;
            GridViewRow _oGridViewRow = (GridViewRow)_oGridView.Rows[e.RowIndex];
            TextBox _oCreate_by = (TextBox)_oGridViewRow.FindControl("create_by");
            TextBox _oDUMMY4 = (TextBox)_oGridViewRow.FindControl("DUMMY4");
            StringBuilder _oQuery = new StringBuilder();
            if (_oCreate_by == null || _oDUMMY4 == null) { e.Cancel = true; return; }
            if (!_oCreate_by.Text.ToString().Trim().Equals(string.Empty) &&
                !_oDUMMY4.Text.ToString().Trim().Equals(string.Empty))
            {
                _oQuery.Append("UPDATE  IMEI_STOCK SET CREATE_BY='" + _oCreate_by.Text.ToString() + "' , DUMMY4='" + _oDUMMY4.Text.ToString() + "'  WHERE REFERENCENO='" + EdfNo.ToString() + "' AND KIT_CODE='" + Sku.ToString() + "' AND STATUS='AO' AND DUMMY2='CC RET'  AND ROWNUM<=1");
                if (SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery.ToString()))
                    RunJavascriptFunc("alert('Update Success!')", true);
                else
                    RunJavascriptFunc("alert('Update Fail!')", true);

            }
            else
            {
                if (_oCreate_by.Text.ToString().Trim().Equals(string.Empty))
                {
                    RunJavascriptFunc("alert('Create by text box cannot empty!')",true);
                }
                if (_oDUMMY4.Text.ToString().Trim().Equals(string.Empty))
                {
                    RunJavascriptFunc("alert('Record id text box cannot empty!')",true);
                }
            }
        }
        IMEISTOCKGW.EditIndex = -1;
        if (rwl_edf_no.Text.ToString() != string.Empty)
            BindData(rwl_edf_no.Text.ToString(), rwl_sku.Text.ToString());
        else
            BindData(rwl_record_id.Text.ToString(), rwl_sku.Text.ToString());
    }

    protected void IMEISTOCKGW_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        if (GetIMEIAORecordCount()<=0)
        {
            RunJavascriptFunc("alert('Cannot delete this record!')", true);
            return;
        }

        if (e.RowIndex > -1)
        {
            GridView _oGridView = (GridView)sender;
            GridViewRow _oGridViewRow = (GridViewRow)_oGridView.Rows[e.RowIndex];
            Label _oCreate_by = (Label)_oGridViewRow.FindControl("create_by");
            Label _oDUMMY4 = (Label)_oGridViewRow.FindControl("DUMMY4");
            Label _oReferenceno = (Label)_oGridViewRow.FindControl("referenceno");
            Label _oModel = (Label)_oGridViewRow.FindControl("model");
            Label _oKit_code = (Label)_oGridViewRow.FindControl("kit_code");
            Label _oImei = (Label)_oGridViewRow.FindControl("imei");
            Label _oStatus = (Label)_oGridViewRow.FindControl("status");
            string CreateBy = _oCreate_by.Text.ToString().Trim();
            string RecordID = _oDUMMY4.Text.ToString().Trim();
            string EdfNo = _oReferenceno.Text.ToString().Trim();
            string Model = _oModel.Text.ToString().Trim();
            string Sku = _oKit_code.Text.ToString().Trim();
            string Status = _oStatus.Text.ToString().Trim();
            string IMEI = _oImei.Text.ToString().Trim();

            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("UPDATE IMEI_STOCK SET DUMMY4='',REFERENCENO='',KIT_CODE='',STATUS='',IMEI='',DUMMY2='',DUMMY3='' WHERE ");
            if(RecordID!=string.Empty)
                _oQuery.Append("DUMMY4='" + RecordID.ToString() + "' AND ");
            else
                _oQuery.Append("DUMMY4=' ' AND ");

            if (EdfNo!=string.Empty)
                _oQuery.Append("REFERENCENO='" + EdfNo.ToString() + "' AND ");
            else
                _oQuery.Append("REFERENCENO=' ' AND ");

            if (Sku.ToString() != string.Empty)
                _oQuery.Append("KIT_CODE='" + Sku.ToString() + "' AND ");
            else
                _oQuery.Append("(KIT_CODE=' ' or KIT_CODE is null) AND ");


            if(Status.ToString()!=string.Empty)
                _oQuery.Append("STATUS='" + Status.ToString() + "' AND ");
            else
                _oQuery.Append("(STATUS=' ' or STATUS is null) AND ");

            if(IMEI.ToString()!=string.Empty)
                _oQuery.Append("IMEI='" + IMEI.ToString() + "' AND ");
            else
                _oQuery.Append("(IMEI=' ' or IMEI is null) AND ");

            _oQuery.Append("DUMMY2='CC RET' ");
            _oQuery.Append("AND ");
            _oQuery.Append("ROWNUM<=1");
            if (SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery.ToString()))
            {
                RunJavascriptFunc("alert('Delete Success!')",true);
            }
            if (rwl_edf_no.Text.ToString() != string.Empty)
                BindData(rwl_edf_no.Text.ToString(), rwl_sku.Text.ToString());
            else
                BindData(rwl_record_id.Text.ToString(), rwl_sku.Text.ToString());
        }

    }

    protected void IMEISTOCKGW_RowEditing(object sender, GridViewEditEventArgs e)
    {
        IMEISTOCKGW.EditIndex = e.NewEditIndex;
        if (rwl_edf_no.Text.ToString() != string.Empty)
            BindData(rwl_edf_no.Text.ToString(), rwl_sku.Text.ToString());
        else
            BindData(rwl_record_id.Text.ToString(), rwl_sku.Text.ToString());
    }

    protected void IMEISTOCKGW_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        IMEISTOCKGW.EditIndex = -1;
        if (rwl_edf_no.Text.ToString() != string.Empty)
            BindData(rwl_edf_no.Text.ToString(), rwl_sku.Text.ToString());
        else
            BindData(rwl_record_id.Text.ToString(), rwl_sku.Text.ToString());
    }
    protected void but_InsertAoCase_Click(object sender, EventArgs e)
    {
        int _iOrder_id;
        if (int.TryParse(rwl_order_id.Text.ToString(), out _iOrder_id))
        {
            string n_sToday1 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect(), _iOrder_id);
            StringBuilder _oCheckAOImei = new StringBuilder();
            _oCheckAOImei.Append("SELECT IMEI FROM IMEI_Stock WHERE ");
            _oCheckAOImei.Append(" kit_code='" + _oMobileRetentionOrder.GetSku() + "' ");
            _oCheckAOImei.Append(" AND Model='" + _oMobileRetentionOrder.GetHs_model() + "' ");
            _oCheckAOImei.Append(" AND Status='AO' ");
            _oCheckAOImei.Append(" AND DUMMY4='" + Func.IDAdd100000(Convert.ToInt32(_oMobileRetentionOrder.GetOrder_id())) + "' ");
            _oCheckAOImei.Append(" AND ReferenceNo='" + Func.IDAdd100000(Convert.ToInt32(_oMobileRetentionOrder.GetOrder_id())) + "' ");
            _oCheckAOImei.Append(" AND Dummy2='CC RET'");
            OdbcDataReader _oCheckAODr = SYSConn<ODBCConnect>.Connect().GetSearch(_oCheckAOImei.ToString());
            if (!_oCheckAODr.Read())
            {
                if (SYSConn<ODBCConnect>.Connect().ExplicitNonQuery("INSERT INTO IMEI_Stock (Kit_Code,Model,Status,DUMMY4,ReferenceNo,Create_Date,Create_By,StaffNo,Dummy2,Dummy3) values ('" + _oMobileRetentionOrder.GetSku() + "','" + _oMobileRetentionOrder.GetHs_model() + "','AO','" + Func.IDAdd100000(Convert.ToInt32(_oMobileRetentionOrder.GetOrder_id())) + "','" + Func.IDAdd100000(Convert.ToInt32(_oMobileRetentionOrder.GetOrder_id())) + "',to_date('" + n_sToday1 + "' , 'dd/mm/yyyy hh24:mi:ss'),'" + _oMobileRetentionOrder.GetStaff_no() + "','" + _oMobileRetentionOrder.GetStaff_no() + "','CC RET','"+_oMobileRetentionOrder.GetDelivery_exchange_location()+"' ) "))
                    RunJavascriptFunc("alert('Insert Success!')", true);
                else
                    RunJavascriptFunc("alert('Insert Fail!')", true);
            }
            else
            {
                RunJavascriptFunc("alert('Duplicate record!')", true);
            }
            _oCheckAODr.Close();
            _oCheckAODr.Dispose();
        }
        if (rwl_edf_no.Text.ToString() != string.Empty)
            BindData(rwl_edf_no.Text.ToString(), rwl_sku.Text.ToString());
        else
            BindData(rwl_record_id.Text.ToString(), rwl_sku.Text.ToString());
    }
}
