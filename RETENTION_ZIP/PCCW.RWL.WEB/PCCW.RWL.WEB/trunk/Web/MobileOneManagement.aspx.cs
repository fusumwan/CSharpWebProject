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
using log4net;
using System.Reflection;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

public partial class Web_MobileOneManagement : NEURON.WEB.UI.BasePage
{
    MobileOneLevel n_oMobileOneLevel = MobileOneLevel.Instance();
    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
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

    protected void InitFrame()
    {
       NeuronJSLibrary.Text= NEURON.WEB.UI.HTMLCONTROL.JSCONTROL.JSScriptLibrary.JSScriptCommon;
       
       search_result.Visible = false;
       But_Delete.Visible = false;
       But_Disable.Visible = false;
       But_Enable.Visible = false;

       result_id.Value = "";
       result_cmpgn_id.Value = "";
       result_campaign_name.Value = "";
       result_ct_type.Value = "";
       result_active.Value = "";
    }

    protected void But_Add_Click(object sender, EventArgs e)
    {
        if (txt_hk_id.Text != string.Empty && txt_mobile_number.Text != string.Empty)
        {
            string _sMobileLevelDesc = n_oMobileOneLevel.GetMobileLevelDesc(txt_mobile_number.Text).Trim();
            if (_sMobileLevelDesc.Trim()==string.Empty)
            {
                RunJavascriptFunc("alert('ERROR: This moible number has already assigned mobile one group!')");
            }
            if (drp_mobile_type.SelectedValue == "MobileOneT1")
            {
                /*for mobileOneT1*/
                StringBuilder _oMobileOneT1Query = new StringBuilder();
                _oMobileOneT1Query.Append("INSERT into campaign ");
                _oMobileOneT1Query.Append("(key_value,key_value_type,target_level,cmpgn_id,cntct_grp_cd,sales_ch,campaign_name,value_prop_id,promotion_start_d,promotion_end_d,market_segment,lob,campaign_type,source_file_name,active,cdate,hkid)");
                _oMobileOneT1Query.Append("values");
                _oMobileOneT1Query.Append("('" + txt_mobile_number.Text.ToString() + "','T','L','0909225916','1000016884','I','PPMOB_ACQ_090619_090619_MOB_3G_CREAM','MP_FM01007',getdate(),null,'CONSUMER','MOB','OTHERS','0909225916_1000016884','1',getdate(),'" + txt_hk_id.Text.ToString() + "')");

                if (GetCRMDB().ExplicitNonQuery(_oMobileOneT1Query.ToString()))
                    RunJavascriptFunc("alert('Assign Success!')");
                else
                    RunJavascriptFunc("alert('Assign Fail!')");

            }
            else if (drp_mobile_type.SelectedValue == "MobileOneT2")
            {
                /*for mobileOneT2*/
                StringBuilder _oMobileOneT23Query = new StringBuilder();
                _oMobileOneT23Query.Append("INSERT into campaign ");
                _oMobileOneT23Query.Append("(key_value,key_value_type,target_level,cmpgn_id,cntct_grp_cd,sales_ch,campaign_name,value_prop_id,promotion_start_d,promotion_end_d,market_segment,lob,campaign_type,source_file_name,active,cdate,hkid)");
                _oMobileOneT23Query.Append("values ('" + txt_mobile_number.Text.ToString() + "','T','L','0909225916','1000016882','I','PPMOB_OTH_090922_090922_MOB_IB_3G_MOB1','MP_FM0S001',getdate(),null,'CONSUMER','MOB','OTHERS','0909225916_1000016882','1',getdate(),'" + txt_hk_id.Text.ToString() + "')");
                if (GetCRMDB().ExplicitNonQuery(_oMobileOneT23Query.ToString()))
                    RunJavascriptFunc("alert('Assign Success!')");
                else
                    RunJavascriptFunc("alert('Assign Fail!')");
            }
            else if (drp_mobile_type.SelectedValue == "MobileOneT3")
            {
                /*for mobileOneT3*/
                StringBuilder _oMobileOneT23Query = new StringBuilder();
                _oMobileOneT23Query.Append("INSERT into campaign ");
                _oMobileOneT23Query.Append("(key_value,key_value_type,target_level,cmpgn_id,cntct_grp_cd,sales_ch,campaign_name,value_prop_id,promotion_start_d,promotion_end_d,market_segment,lob,campaign_type,source_file_name,active,cdate,hkid)");
                _oMobileOneT23Query.Append("values ('" + txt_mobile_number.Text.ToString() + "','T','L','0909225916','1000016883','I','PPMOB_OTH_090922_090922_MOB_IB_3G_MOB1','MP_FM0S001',getdate(),null,'CONSUMER','MOB','OTHERS','0909225916_1000016883','1',getdate(),'" + txt_hk_id.Text.ToString() + "')");
                if (GetCRMDB().ExplicitNonQuery(_oMobileOneT23Query.ToString()))
                    RunJavascriptFunc("alert('Assign Success!')");
                else
                    RunJavascriptFunc("alert('Assign Fail!')");
            }
        }
    }

    protected void But_Search_Click(object sender, EventArgs e)
    {
        if (txt_search_mrt.Text != string.Empty)
        {
            StringBuilder _oSearchQuery = new StringBuilder();
            _oSearchQuery.Append("SELECT TOP 1 c.key_value key_value, c.key_value_type key_value_type, ct.description description,");
            _oSearchQuery.Append(" c.cmpgn_id cmpgn_id, c.hkid hkid, ct.type type, ");
            _oSearchQuery.Append(" c.cdate cdate, c.id id, c.campaign_name campaign_name, c.active active");
            _oSearchQuery.Append(" FROM " + Configurator.MSSQLTablePrefix + "campaign c with(nolock)");
            _oSearchQuery.Append(" LEFT JOIN " + Configurator.MSSQLTablePrefix + "campaign_type ct with(nolock) ON ");
            _oSearchQuery.Append(" c.cmpgn_id = ct.cmpgn_id AND ");
            _oSearchQuery.Append(" c.cntct_grp_cd = ct.cntct_grp_cd ");
            _oSearchQuery.Append(" WHERE c.active=1 AND ct.type is not null AND ct.type = 'mobileOne' AND c.key_value ='" + txt_search_mrt.Text.ToString().Trim() + "'");

            DataSet _oDS = GetCRMDB().GetDS(_oSearchQuery.ToString());
            if (_oDS != null)
            {
                IDSQuery _oDSDr = IDSQuery.CreateDsCriteria(_oDS, string.Empty);
                if (_oDSDr.Read())
                {
                    result_mrt.Text = _oDSDr["key_value"].ToString();
                    result_hkid.Text = _oDSDr["hkid"].ToString();
                    //result_type.Text = MobileOneLevel.Instance().GetMobileLevelDesc(_oDSDr["type"].ToString());
                    result_type.Text = _oDSDr["description"].ToString();
                    result_cdate.Text = _oDSDr["cdate"].ToString();
                    if (result_type.Text.Trim().ToLower().Equals("mobileone"))
                    {
                        result_type.Text = "MobileOne Premier";
                    }
                    else if (result_type.Text.Trim().ToLower().Equals("mobileonet1"))
                    {
                        result_type.Text = "MobileOne T2";
                    }
                    else if (result_type.Text.Trim().ToLower().Equals("mobileonet2"))
                    {
                        result_type.Text = "MobileOne T3";
                    }
                    result_id.Value = _oDSDr["id"].ToString();
                    result_cmpgn_id.Value = _oDSDr["cmpgn_id"].ToString();
                    result_campaign_name.Value = _oDSDr["campaign_name"].ToString();
                    result_ct_type.Value = _oDSDr["type"].ToString();
                    result_active.Value = _oDSDr["active"].ToString();

                    search_result.Visible = true;
                    But_Delete.Visible = true;
                    if (_oDSDr["active"]=="True")
                    {
                        But_Disable.Visible = true;
                        But_Enable.Visible = false;
                    }
                    else
                    {
                        But_Disable.Visible = false;
                        But_Enable.Visible = true;
                    }
                }
                else
                {
                    search_result.Visible = false;
                    But_Delete.Visible = false;
                    But_Disable.Visible = false;
                    But_Enable.Visible = false;

                    result_id.Value = "";
                    result_cmpgn_id.Value = "";
                    result_campaign_name.Value = "";
                    result_ct_type.Value = "";
                    result_active.Value = "";
                }
                _oDSDr.Close();

            }
        }
    }

    protected void But_Delete_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(result_cmpgn_id.Value.Trim())) { return; }
        if (string.IsNullOrEmpty(result_mrt.Text.Trim())) { return; }
        if (string.IsNullOrEmpty(result_hkid.Text.Trim())) { return; }
        if (string.IsNullOrEmpty(result_active.Value.Trim())) { return; }
        StringBuilder _oDeleteQuery = new StringBuilder();
        _oDeleteQuery.Append("DELETE FROM campaign");

        _oDeleteQuery.Append(" WHERE cmpgn_id = '" + result_cmpgn_id.Value.Trim() + "' AND");
        _oDeleteQuery.Append(" key_value = '" + result_mrt.Text.Trim() + "' AND");
        _oDeleteQuery.Append(" hkid = '" + result_hkid.Text.Trim() + "' AND");
        _oDeleteQuery.Append(" active = " +((result_active.Value.Trim().ToLower()=="true")?"1":"0"));

        string sql = _oDeleteQuery.ToString();


        if (GetCRMDB().ExplicitNonQuery(_oDeleteQuery.ToString()))
        {
            RunJavascriptFunc("alert('Delete Success!')");

            search_result.Visible = false;
            But_Delete.Visible = false;
            But_Disable.Visible = false;
            But_Enable.Visible = false;

            result_id.Value = "";
            result_cmpgn_id.Value = "";
            result_campaign_name.Value = "";
            result_ct_type.Value = "";
            
            result_active.Value = "";
        }
        else
        {
            RunJavascriptFunc("alert('Delete Fail!')");
        }

    }

    protected void But_Disable_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(result_cmpgn_id.Value.Trim())) { return; }
        if (string.IsNullOrEmpty(result_mrt.Text.Trim())) { return; }
        if (string.IsNullOrEmpty(result_hkid.Text.Trim())) { return; }
        if (string.IsNullOrEmpty(result_active.Value.Trim())) { return; }
        StringBuilder _oDisableQuery = new StringBuilder();
        _oDisableQuery.Append("UPDATE campaign");
        _oDisableQuery.Append(" SET campaign.active = 0");

        _oDisableQuery.Append(" WHERE cmpgn_id = '" + result_cmpgn_id.Value.Trim() + "' AND");
        _oDisableQuery.Append(" key_value = '" + result_mrt.Text.Trim() + "' AND");
        _oDisableQuery.Append(" hkid = '" + result_hkid.Text.Trim() + "' AND");
        _oDisableQuery.Append(" active = " + ((result_active.Value.Trim().ToLower() == "true") ? "1" : "0"));

        string sql = _oDisableQuery.ToString();

        if (GetCRMDB().ExplicitNonQuery(_oDisableQuery.ToString()))
        {
            RunJavascriptFunc("alert('Update Success! (Disable)')");
            But_Disable.Visible = false;
            But_Enable.Visible = true;
        }
        else
        {
            RunJavascriptFunc("alert('Update Fail! (Disable)')");
        }

    }


    protected void But_Enable_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(result_cmpgn_id.Value.Trim())) { return; }
        if (string.IsNullOrEmpty(result_mrt.Text.Trim())) { return; }
        if (string.IsNullOrEmpty(result_hkid.Text.Trim())) { return; }
        if (string.IsNullOrEmpty(result_active.Value.Trim())) { return; }
        StringBuilder _oEnableQuery = new StringBuilder();
        _oEnableQuery.Append("UPDATE campaign");
        _oEnableQuery.Append(" SET campaign.active = 1");

        _oEnableQuery.Append(" WHERE cmpgn_id = '" + result_cmpgn_id.Value.Trim() + "' AND");
        _oEnableQuery.Append(" key_value = '" + result_mrt.Text.Trim() + "' AND");
        _oEnableQuery.Append(" hkid = '" + result_hkid.Text.Trim() + "' AND");
        _oEnableQuery.Append(" active = " + ((result_active.Value.Trim().ToLower() == "true") ? "1" : "0"));

        string sql = _oEnableQuery.ToString();

        if (GetCRMDB().ExplicitNonQuery(_oEnableQuery.ToString()))
        {
            RunJavascriptFunc("alert('Update Success! (Enable)')");
            But_Disable.Visible = true;
            But_Enable.Visible = false;
        }
        else
        {
            RunJavascriptFunc("alert('Update Fail! (Enable)')");
        }

    }

    #region GetDB
    public static MSSQLConnect GetCRMDB()
    {
        MSSQLConnect _oDB = new MSSQLConnect();
        _oDB.bWithNoLock = true;
        _oDB.SetConnStr(Configurator.DBName.CRM);
        return _oDB;
    }
    #endregion

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
        return RunJavascriptFunc(x_sFunc, true);
    }
    #endregion
}
