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
using System.ComponentModel;
using System.Globalization;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using NEURON.WEB.UI.HTMLCONTROL.JSCONTROL;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;

public partial class Web_IMEIManagement_UpdateOrderToEDFByBatch : NEURON.WEB.UI.BasePage
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
    [global::System.Serializable]
    protected class EventLog
    {
        protected string n_sEvent_log = global::System.String.Empty;
        #region Event_log
        [DataObjectField(true)]
        public virtual string Event_log
        {
            get
            {
                return this.n_sEvent_log;
            }
            set
            {
                this.n_sEvent_log = value;
            }
        }
        #endregion Edf_sim_item_code
    }

    EDFStatusProfile _oEDFStatusProfile = new EDFStatusProfile();

    StringBuilder RegisterJSScript = new StringBuilder();
    string[] _oFormat = new string[] { 
        "dd/MM/yyyy","dd/M/yyyy","d/MM/yyyy",  "d/M/yyyy"
        };
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
        if (!IsPostBack) { InitFrame(); }
    }
    public void InitFrame()
    {

    }

    #region PageLoadComplete
    protected void Page_LoadComplete(object sender, EventArgs e)
    {
        RegisterJavaScript(string.Empty, RegisterJSScript.ToString(), true);
    }
    #endregion

    #region Run Javascript Function
    public string RunJavascriptFunc(string x_sFunc, bool x_bIncludeScript, bool x_bRunRegister)
    {
        string _sFunc = ((x_sFunc.IndexOf(';') > 0) ? x_sFunc : x_sFunc + ";");
        if (x_bIncludeScript) _sFunc = "<script>" + _sFunc + "</script>";
        if (x_bRunRegister)
            ScriptManager.RegisterStartupScript(this, this.GetType(), x_sFunc + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), _sFunc, false);
        else
            RegisterJSScript.AppendLine(_sFunc);
        return _sFunc;
    }


    public string RunJavascriptFunc(string x_sFunc)
    {
        return RunJavascriptFunc(x_sFunc, false, false);
    }
    #endregion

    #region RegisterJavaScript
    protected void RegisterJavaScript(string x_sID, string x_sScript, bool x_bIncludeScript)
    {
        if (x_bIncludeScript) x_sScript = "<script>" + x_sScript + "</script>";
        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), x_sScript, false);
    }
    #endregion



    protected void MobileOrderSyncSearchObj_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
        if (!string.IsNullOrEmpty(d_date.Text.ToString().Trim()))
        {
            DateTime _dD_date;
            if (DateTime.TryParseExact(d_date.Text.ToString().Trim(), _oFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dD_date))
            {
                DateTime _dD_date2;
                if (DateTime.TryParseExact(d_date2.Text.ToString().Trim(), _oFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dD_date2))
                {
                    e.InputParameters["x_sFilterExpression"] = "d_date is not null AND d_date>='" + _dD_date.ToString("dd/MMM/yyyy 00:00:00") + "' AND d_date<='" + _dD_date2.ToString("dd/MMM/yyyy 23:59:59") + "'";
                }
                else
                {
                    e.InputParameters["x_sFilterExpression"] = " d_date is not null AND d_date>='" + _dD_date.ToString("dd/MMM/yyyy 00:00:00") + "' AND d_date<='" + _dD_date.ToString("dd/MMM/yyyy 23:59:59") + "' ";
                }
            }
        }
        else
            e.InputParameters["x_sFilterExpression"] = string.Empty;
    }
    protected void SearchOrder_Click(object sender, EventArgs e)
    {
        MobileOrderSyncSearchGV.DataBind();
    }
    protected void OrderUpdateChk_Click(object sender, EventArgs e)
    {
        List<EventLog> _oEventLogArr = new List<EventLog>();
        AssignIMEIControl _oAssignIMEIControl = new AssignIMEIControl();
        CheckBox _oChkrow = null;
        Literal _oRecordID = null;
        Literal _oEdf = null;
        foreach (GridViewRow _oGvr in this.MobileOrderSyncSearchGV.Rows)
        {
            _oChkrow = (CheckBox)_oGvr.Cells[0].FindControl("assign_chk");
            _oRecordID = (Literal)_oGvr.Cells[1].FindControl("record_id");
            _oEdf = (Literal)_oGvr.Cells[2].FindControl("MobileOrderSyncSearch_edf_no");
            if (_oEdf != null)
            {
                int _iRecordID;
                if (_oChkrow != null &&
                    _oRecordID != null &&
                    int.TryParse(_oRecordID.Text.ToString(), out _iRecordID))
                {
                    if (_oChkrow.Enabled == true &&
                        _oChkrow.Checked == true)
                        _oEventLogArr=UpdateOrder(_iRecordID, _oEventLogArr);
                }
            }
        }

        ReportMsg.DataSource = _oEventLogArr;
        ReportMsg.DataBind();
        MobileOrderSyncSearchGV.DataBind();
    }

    protected List<EventLog> UpdateOrder(int x_iRecordID, List<EventLog> x_oEventLogArr)
    {
        if(x_oEventLogArr==null)
            x_oEventLogArr = new List<EventLog>();
        int _iOrderID = x_iRecordID - 100000;
        if (_iOrderID > 0)
        {
            MobileRetentionOrderEntity _oMobileRetentionOrderEntity = new MobileRetentionOrderEntity(SYSConn<MSSQLConnect>.Connect(), _iOrderID);
            if (_oMobileRetentionOrderEntity != null)
            {
                if (_oMobileRetentionOrderEntity.GetFound())
                {
                    if (_oMobileRetentionOrderEntity.GetOrder_id() != null && RWLFramework.CurrentUser[this.Page].Uid != string.Empty)
                    {
                        if (_oEDFStatusProfile.UpdateEDF((int)_oMobileRetentionOrderEntity.GetOrder_id(), RWLFramework.CurrentUser[this.Page].Uid, Request.ServerVariables["REMOTE_ADDR"].ToString()))
                        {
                            x_oEventLogArr.Add(new EventLog() { Event_log = "Success : Reference No:" + _oMobileRetentionOrderEntity.GetEdf_no() + " Order Updated!" });
                        }
                        else
                        {
                            x_oEventLogArr.Add(new EventLog() { Event_log = "Error : Order Id:" + ((int)_oMobileRetentionOrderEntity.GetOrder_id()).ToString() + "' failure to update the EDF record)" });
                        }
                    }
                    else
                    {
                        if (_oMobileRetentionOrderEntity.GetOrder_id() == null)
                        {
                            x_oEventLogArr.Add(new EventLog() { Event_log = "Error : Order ID is null value" });
                        }
                        else if (string.IsNullOrEmpty(RWLFramework.CurrentUser[this.Page].Uid))
                        {
                            x_oEventLogArr.Add(new EventLog() { Event_log = "Error : Uid is null value" });
                        }
                        else
                        {
                            x_oEventLogArr.Add(new EventLog() { Event_log = "Error : Order Id:" + ((int)_oMobileRetentionOrderEntity.GetOrder_id()).ToString() + "' failure to update the EDF record" });
                        }
                    }
                }
                else
                {
                    x_oEventLogArr.Add(new EventLog() { Event_log = "Error : Cannot find reference number :" + _oMobileRetentionOrderEntity.GetEdf_no() });
                }
            }
        }
        else
            x_oEventLogArr.Add(new EventLog() { Event_log = "Error : Please kindly enter the reference number" });

        return x_oEventLogArr;
    }

    protected void CLEAR_EVENT_Click(object sender, EventArgs e)
    {
        ReportMsg.DataSource = new List<EventLog>();
        ReportMsg.DataBind();
    }
}
