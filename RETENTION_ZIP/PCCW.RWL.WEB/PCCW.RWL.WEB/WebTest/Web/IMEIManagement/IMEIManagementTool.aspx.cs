using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using log4net;
using System.Reflection;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

public partial class Web_IMEIManagement_IMEIManagementTool : System.Web.UI.Page
{
    EDFStatusProfile _oEDFStatusProfile = new EDFStatusProfile();
    string _sOld_IMEI = string.Empty;

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
        if (!IsPostBack)
        {
            InitFrame();
        }
    }

    public void InitFrame()
    {

    }

    public void SubmitBut_OnClick(object sender, EventArgs e)
    {
        string _sEdf_no = edf_no.Text;
        string _sImei_no = imei_no.Text;

        string _sStatus = status.SelectedValue;
        string _sUid = RWLFramework.CurrentUser.Uid;

        if (sku_hs_model.Text == string.Empty)
        {
            RegisterJavaScript("jAlert('ERROR : There are missing sku number!','System Message');");
            return;
        }

        if (!IMEIManagementTool.ChkExistingOrder(_sEdf_no))
        {
            RegisterJavaScript("jAlert('ERROR : This EDF number is not existing in our system!','System Message');");
            return;
        }
        if (!IMEIManagementTool.ChkExistingIMEI(_sImei_no))
        {
            RegisterJavaScript("jAlert('ERROR : This IMEI number is not existing in our system!','System Message');");
            return;
        }

        if (PCCW.RWL.CORE.IMEIManagementTool.ChkExistingIMEIStatus(_sImei_no) != "3G_RETENTION")
        {
            RegisterJavaScript("jAlert('ERROR : Please kindly enter IMEI with normal status!','System Message');");
            return;
        }

        MobileRetentionOrderRepository _oMobileRetentionOrderRepository=new MobileRetentionOrderRepository(SYSConn<MSSQLConnect>.Connect());

        IQueryable<MobileRetentionOrderEntity> _oMobileRetentionOrderEntityArr = from RWLs in _oMobileRetentionOrderRepository.MobileRetentionOrders
                                                                                 where RWLs.edf_no == _sEdf_no
                                                                                 select RWLs;
        if (_oMobileRetentionOrderEntityArr.Count<MobileRetentionOrderEntity>() > 0)
        {
            bool _bBackUpOrder = false;
            bool _bIMEI_Stock = false;
            bool _bIMEIQuery1 = false;
            bool _bIMEIQuery2 = false;
            bool _bOrderSave = false;
            bool _bUpdateEDF = false;
            MobileRetentionOrderEntity _oMobileRetentionOrderEntity = _oMobileRetentionOrderEntityArr.First<MobileRetentionOrderEntity>();
            _bBackUpOrder=MobileRetentionOrderBal.BackUpOrder((int)_oMobileRetentionOrderEntity.GetOrder_id(), _sUid);
            _bIMEI_Stock=IMEI_StockBal.CreateImeiHistory((int)_oMobileRetentionOrderEntity.GetOrder_id(), _oMobileRetentionOrderEntity.GetImei_no(), _sUid);
            _sOld_IMEI  = _oMobileRetentionOrderEntity.GetImei_no();
            _oMobileRetentionOrderEntity.SetImei_no(_sImei_no);

            if (_sOld_IMEI.Trim() == _sImei_no.Trim())
            {
                RegisterJavaScript("jAlert('ERROR : Old IMEI Cannot Same As New IMEI !','System Message');");
                return;
            }

            string _sSku = _oMobileRetentionOrderEntity.GetSku().Trim();
            string _sNewIMEISku = IMEIManagementTool.ChkExistingIMEISku(_sImei_no).Trim();
            if (_sNewIMEISku != _sSku)
            {
                RegisterJavaScript("jAlert('ERROR : New IMEI'sku is match to current order's sku!','System Message');");
                return;
            }

            if (PCCW.RWL.CORE.IMEIManagementTool.ChkExistingIMEIStatus(_sOld_IMEI) != "SOLD")
            {
                RegisterJavaScript("jAlert('ERROR : Old IMEI Status is not SOLD!','System Message');");
                return;
            }

            string _sRecordID = (((int)_oMobileRetentionOrderEntity.GetOrder_id()) + 100000).ToString();

            StringBuilder _oIMEIQuery1=new StringBuilder();
            
            _oIMEIQuery1.Append("UPDATE IMEI_STOCK SET ");
            if (_sStatus == "Onsite Reject (Re-use)")
            {
                _oIMEIQuery1.Append(" STATUS='NORMAL'  AND referenceno='' AND DUMMY4='' ");
            }
            else
            {
                _oIMEIQuery1.Append(" STATUS='SOLD'  ");
            }

            _oIMEIQuery1.Append(" WHERE DUMMY2='CC RET' AND IMEI='" + _sOld_IMEI + "' AND DUMMY4='" + _sRecordID + "' AND ROWNUM<=1");

            StringBuilder _oIMEIQuery2 = new StringBuilder();
            _oIMEIQuery2.Append("UPDATE IMEI_STOCK SET ");



            if (_sStatus == "Normal DOA" || _sStatus == "Exchange DOA")
            {
                _oIMEIQuery2.Append(" STATUS='DOA' , ");
            }
            else
            {
                _oIMEIQuery2.Append(" STATUS='SOLD' , ");
            }

            _oIMEIQuery2.Append(" DUMMY2='CC RET' , referenceno='" + _oMobileRetentionOrderEntity.GetEdf_no() + "', DUMMY='" + _sRecordID + "' ");
            _oIMEIQuery2.Append(" WHERE DUMMY2='CC RET' AND IMEI='" + _sImei_no + "'  AND ROWNUM<=1");

            _bIMEIQuery1=SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oIMEIQuery1.ToString());
            _bIMEIQuery2=SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oIMEIQuery2.ToString());
            _oMobileRetentionOrderEntity.SetDB(SYSConn<MSSQLConnect>.Connect());
            _bOrderSave=_oMobileRetentionOrderEntity.Save();

            _bUpdateEDF=_oEDFStatusProfile.UpdateEDF((int)_oMobileRetentionOrderEntity.GetOrder_id());

            if (_bBackUpOrder && _bIMEI_Stock &&
                _bIMEIQuery1 && _bIMEIQuery2 &&
                _bOrderSave && _bUpdateEDF)
            {

                RegisterJavaScript("jAlert('Update Sucess!','System Message');");
            }
            else
            {
                if (!_bBackUpOrder)
                {
                    RegisterJavaScript("jAlert('ERROR : Cannot Back Up Order !','System Message');");
                }

                if (!_bIMEI_Stock)
                {
                    RegisterJavaScript("jAlert('ERROR : Cannot Create IMEI History !','System Message');");
                }

                if (!_bIMEIQuery1)
                {
                    RegisterJavaScript("jAlert('ERROR : Cannot Update Old IMEI Record !','System Message');");
                }

                if (!_bIMEIQuery2)
                {
                    RegisterJavaScript("jAlert('ERROR : Cannot Update New IMEI Record !','System Message');");
                }
                if (!_bOrderSave)
                {
                    RegisterJavaScript("jAlert('ERROR : Cannot Update RWL Order!','System Message');");
                }
                if (!_bUpdateEDF)
                {
                    RegisterJavaScript("jAlert('ERROR : Cannot Update EDF Order!','System Message');");
                }
            }

        }

    }

    #region RegisterJavaScript
    protected void RegisterJavaScript(string x_sScript){

        RegisterJavaScript(string.Empty, x_sScript, true);
    }
    protected void RegisterJavaScript(string x_sID, string x_sScript, bool x_bIncludeScript)
    {
        if (x_bIncludeScript) x_sScript = "<script>" + x_sScript + "</script>";
        ScriptManager.RegisterStartupScript(this.Page, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), x_sScript, false);
    }
    #endregion

}
