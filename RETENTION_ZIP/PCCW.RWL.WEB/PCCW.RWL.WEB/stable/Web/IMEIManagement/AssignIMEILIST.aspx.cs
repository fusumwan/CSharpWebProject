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
using System.Text;
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

public partial class Web_IMEIManagement_AssignIMEILIST : NEURON.WEB.UI.BasePage
{
    
    private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
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
        WebFunc.PrivilegeCheck(this.Page);
        (new MobileAssignListViewDAO()).Reset();
    }

    protected void InitFrame()
    {
        (new MobileAssignListViewDAO()).Reset();
    }

    protected void OrderAssignChk_Click(object sender, EventArgs e)
    {
        AssignIMEIControl _oAssignIMEIControl = new AssignIMEIControl();
        CheckBox _oChkrow = null;
        Literal _oRecordID=null;
        HiddenField _oOrderID = null;
        Literal _oIMEI = null;
        Literal _oSku = null;
        foreach (GridViewRow _oGvr in this.MobileAssignListGW.Rows)
        {
            _oChkrow = (CheckBox)_oGvr.Cells[0].FindControl("assign_chk");
            _oRecordID = (Literal)_oGvr.Cells[1].FindControl("MobileAssignList_record_id");
            _oOrderID = (HiddenField)_oGvr.FindControl("MobileAssignList_order_id");
            _oSku = (Literal)_oGvr.Cells[3].FindControl("MobileAssignList_sku");
            _oIMEI = (Literal)_oGvr.Cells[4].FindControl("MobileAssignList_imei_no");
            int _iRecordID;
            int _iOrderID;
            if (_oChkrow != null && 
                _oRecordID!=null && 
                int.TryParse(_oRecordID.Text.ToString(),out _iRecordID) && 
                int.TryParse(_oOrderID.Value.ToString(),out _iOrderID))
            {
                if (_oChkrow.Enabled == true &&
                    _oChkrow.Checked == true)
                {
                    if (_oAssignIMEIControl.UploadStockOrder(_iRecordID, RWLFramework.CurrentUser[this.Page].Uid, _oIMEI.Text.ToString(), _oSku.Text.ToString()))
                    {
                        AddHistory(_iOrderID);
                        /*
                        StringBuilder _oQuery = new StringBuilder();
                        _oQuery.Append(" SELECT TOP 1 IMEI_NO FROM "+Configurator.MSSQLTablePrefix+"MobileRetentionOrder WHERE ");
                        _oQuery.Append(" ORDER_ID=" + ((int)_iOrderID).ToString());
                        string _sImei_no = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar(_oQuery.ToString()).Trim().ToUpper();
                        if (!_sImei_no.Equals("AWAIT") &&
                            !_sImei_no.Equals("AO") &&
                            !_sImei_no.Equals(string.Empty))
                        {
                            AddHistory(_iOrderID);
                        }
                         */
                    }
                }
            }
        }
        (new MobileAssignListViewDAO()).Reset();
        MobileAssignListGW.DataBind();
    }

    protected bool AddHistory(int? x_iOrderID){
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append(" INSERT INTO " + Configurator.MSSQLTablePrefix + "MobileAssignListHistory ");
        _oQuery.Append(" SELECT order_id,order_id+100000,d_date,'SOLD',hs_model,imei_no,edf_no,active,'" + RWLFramework.CurrentUser[this.Page].Uid + "',getdate() ");
        _oQuery.Append(" FROM MobileRetentionOrder WITH (NOLOCK) WHERE order_id=@order_id AND order_id IS NOT NULL");
        bool _bResult = false;
        using (SqlConnection _oConn = SYSConn<MSSQLConnect>.Connect().GetConnection())
        {
            SqlCommand _oCmd = new SqlCommand(_oQuery.ToString(), _oConn);
            _oCmd.Parameters.Add("@order_id", SqlDbType.Int).Value = x_iOrderID;
            try{
                _oConn.Open();
                _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
            }
            catch(Exception error){
                throw new BusinessObjectNotFoundException("ASSIGN IMEI LIST: ERROR: " + error.ToString());
            }
            finally
            {
                _oConn.Close();
                _oCmd.Dispose();
                _oConn.Dispose();
            }
        }
        return _bResult;
    }

    protected void ChkAll_CheckedChanged(object sender, EventArgs e)
    {
        CheckBox _oChkAll = (CheckBox)sender;
        CheckBox _oChkrow = null;
        foreach (GridViewRow _oGvr in this.MobileAssignListGW.Rows)
        {
            _oChkrow = (CheckBox)_oGvr.Cells[0].FindControl("assign_chk");
            if(_oChkrow.Enabled==true)
                _oChkrow.Checked = _oChkAll.Checked;
        }
    }
}
