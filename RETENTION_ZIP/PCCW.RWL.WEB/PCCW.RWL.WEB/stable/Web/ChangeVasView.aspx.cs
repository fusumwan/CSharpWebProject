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


public partial class ChangeVasView : NEURON.WEB.UI.BasePage
{

    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion
    SqlDataReader n_oDr = null;
    SqlDataReader n_oDr2 = null;
    SqlDataReader n_oDr3 = null;
    int n_iPlan_fee = 0;
    List<string> n_oSalesmancodeList = new List<string>();
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
        try
        {
            if (!IsPostBack) InitFrame();
        }
        catch(Exception exp)
        {
            string error = exp.ToString();
            Logger.ErrorFormat("ChangeVasView {0}", exp.ToString());
            Response.Redirect("ChangeVasSearch.aspx");
        }
    }

    #region InitFrame
    public void InitFrame()
    {
        int _iMod_flag = 0;
        int _iShow_mod_flag = 0;
        int _iFo_flag = 0;

        n_oDr3 = MobileOrderReportBal.GetSearch(SYSConn<MSSQLConnect>.Connect(), " top 1 order_status,report_type ", " order_id='" + ((WebFunc.qsOrder_id != null) ? Func.IDSubtract100000(WebFunc.qsOrder_id).ToString() : string.Empty) + "'", null, "mid desc, email_date desc");
        if (n_oDr3.Read())
        {
            if ("DONE".Equals(Func.FR(n_oDr3[MobileOrderReport.Para.order_status]).ToString().Trim()) && !"rwl_vas".Equals(Func.FR(n_oDr3[MobileOrderReport.Para.report_type]).ToString().Trim()))
                _iMod_flag = 1;
            else if ("AWAIT RATE PLAN ISSUE".Equals(Func.FR(n_oDr3[MobileOrderReport.Para.order_status]).ToString().Trim()) && !"rwl_vas".Equals(Func.FR(n_oDr3[MobileOrderReport.Para.report_type]).ToString().Trim()))
                _iMod_flag = 1;
            else if ("FALLOUT".Equals(Func.FR(n_oDr3[MobileOrderReport.Para.order_status]).ToString().Trim()) && !"rwl_vas".Equals(Func.FR(n_oDr3[MobileOrderReport.Para.report_type]).ToString().Trim()))
            {
                _iMod_flag = 0;
                _iShow_mod_flag = 1;
            }
            else if ("FALLOUT".Equals(Func.FR(n_oDr3[MobileOrderReport.Para.order_status]).ToString().Trim()) && "rwl_vas".Equals(Func.FR(n_oDr3[MobileOrderReport.Para.report_type]).ToString().Trim()))
            {
                _iMod_flag=1;
                _iFo_flag =1;
            }
        }
        n_oDr3.Close();
        n_oDr3.Dispose();

        n_oDr = MobileRetentionOrderBal.GetSearch(SYSConn<MSSQLConnect>.Connect(), " top 1 datediff(d,getdate(),d_date) as date_diff,datediff(d,getdate(),con_eff_date) as con_diff,* ", " order_id='" + ((WebFunc.qsOrder_id != null) ? Func.IDSubtract100000(WebFunc.qsOrder_id).ToString() : string.Empty) + "'", null, null);
        if (n_oDr.Read()){
            if ("5".Equals(RWLFramework.CurrentUser[this.Page].Lv) || "6".Equals(RWLFramework.CurrentUser[this.Page].Lv) || "suspend".Equals(RWLFramework.CurrentUser[this.Page].Lv))
                _iMod_flag = 0;

            SaleManCodeProfile _oSaleManCodeProfile = new SaleManCodeProfile();
            _oSaleManCodeProfile.SetLv(RWLFramework.CurrentUser[this.Page].Lv);
            _oSaleManCodeProfile.SetUid(RWLFramework.CurrentUser[this.Page].Uid);
            n_oSalesmancodeList = _oSaleManCodeProfile.Get_SalemanCodeList();

            if (RWLFramework.CurrentUser[this.Page].Uid.Equals(Func.FR(n_oDr[MobileRetentionOrder.Para.staff_no]).Trim()) || ("10".Equals(RWLFramework.CurrentUser[this.Page].Lv) || "4".Equals(RWLFramework.CurrentUser[this.Page].Lv)) && n_oSalesmancodeList.Contains(Func.FR(n_oDr[MobileRetentionOrder.Para.salesmancode]).Trim()))
                _iMod_flag = 0;
            if (Func.IsParseBool(Func.FR(n_oDr[MobileRetentionOrder.Para.active]).Trim()))
                if (!Convert.ToBoolean(Func.FR(n_oDr[MobileRetentionOrder.Para.active]))) _iMod_flag = 0;
        }
        //_iMod_flag=1;
        if (n_oDr.HasRows)
        {
            if ((1).Equals(_iMod_flag))
            {
                form1.Visible = true;
                show_mod_flag_tbl.Visible = false;
                notfound.Visible = false;
                form1.Attributes["Action"] = "ChangeVasAction.aspx?order_id=" + ((WebFunc.qsOrder_id != null) ? Func.IDSubtract100000(WebFunc.qsOrder_id).ToString() : string.Empty) + (((1).Equals(_iFo_flag)) ? "&action=reply" : string.Empty);
                order_id.Value = ((WebFunc.qsOrder_id != null) ? Func.RQ(WebFunc.qsOrder_id).ToString() : string.Empty);
                order_id_text.Text = ((WebFunc.qsOrder_id != null) ? Func.RQ(WebFunc.qsOrder_id).ToString() : string.Empty);
                if ((1).Equals(_iFo_flag))
                {
                    falloutreply.Visible = true;
                    fallout_reply.Visible = true;
                }
                else
                {
                    falloutreply.Visible = false;
                    fallout_reply.Visible = false;
                }
                mrt_no.Text = Func.FR(n_oDr[MobileRetentionOrder.Para.mrt_no]).Trim();
                program.Text = Func.FR(n_oDr[MobileRetentionOrder.Para.program]).Trim();
                rate_plan.Text = Func.FR(n_oDr[MobileRetentionOrder.Para.rate_plan]).Trim();
                normal_rebate_type.Text= Func.FR(n_oDr[MobileRetentionOrder.Para.normal_rebate_type]).Trim();
                con_per.Text = Func.FR(n_oDr[MobileRetentionOrder.Para.con_per]).Trim();
                rebate.Text = Func.FR(n_oDr[MobileRetentionOrder.Para.rebate]).Trim();
                free_mon.Text = Func.FR(n_oDr[MobileRetentionOrder.Para.free_mon]).Trim();
                n_oDr3.Close();
                n_oDr3.Dispose();

                StringBuilder _oQuery = new StringBuilder();
                _oQuery.Append("SELECT c.vas_desc as vas_desc, c.fee as fee, a.vas_field as vas_field, a.vas_value as vas_value ,b.multi as multi, b.vas_name as vas_name, b.vas_chi_name as vas_chi_name  ");
                _oQuery.Append("FROM " + Configurator.MSSQLTablePrefix + "MobileOrderVas a INNER JOIN " + Configurator.MSSQLTablePrefix + "BusinessVas b ON a.vas_id=b.id ");
                _oQuery.Append("LEFT JOIN "+Configurator.MSSQLTablePrefix+"BusinessVasDescription c ON (a.multi_id=c.id and a.multi_id is not null and a.multi_id!='') ");
                _oQuery.Append("WHERE a.order_id = '" + Func.FR(n_oDr["order_id"]) + "' and a.active=1");
                n_oDr3 = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
                vas_placeholder.Controls.Clear();
                while (n_oDr3.Read()){
                    string _sVas_value = string.Empty;
                    string _sVas_desc = string.Empty;
                    vas_r("<tr>");
                    vas_r("<td height=\"28\"  class=\"row2\"><span class=\"explaintitle\">");
                    vas_r(Func.FR(n_oDr3["vas_name"]) + " " + Func.LatinToBig5(Func.FR(n_oDr3["vas_chi_name"])).Trim());
                    vas_r("</span></td>");
                    vas_r("<td height=\"28\" class=\"row1\" colspan=\"3\"><span class=\"gensmall\" >");
                    bool _bMultiFlag = false;
                    if (Func.IsParseBool(Func.FR(n_oDr3["multi"])))
                        if (Convert.ToBoolean(Func.FR(n_oDr3["multi"]))) _bMultiFlag = true;

                    if (_bMultiFlag)
                    {
                        if (!"".Equals(Func.FR(n_oDr3[MobileOrderVas.Para.vas_field])))
                        {
                            _sVas_value = Func.FR(n_oDr3[MobileOrderVas.Para.vas_value]).Trim();
                            _sVas_desc = Func.FR(n_oDr3[BusinessVasDescription.Para.vas_desc]).Trim();
                        }
                    }
                    else
                    {
                        _sVas_value = Func.FR(n_oDr3[MobileOrderVas.Para.vas_value]).Trim();
                        _sVas_desc = string.Empty;
                    }

                    vas_r("<SELECT name=\"" + Func.FR(n_oDr3[MobileOrderVas.Para.vas_field]) + "\" id=\"" + Func.FR(n_oDr3[MobileOrderVas.Para.vas_field]) + "\" onChange=\"chk_vas()\" >");
                    vas_r("<option value=\"\"></option>");
                    BusinessVasEntity[] _oBusinessVass = BusinessVasBal.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), "active=1 and vas_field='" + Func.FR(n_oDr3[MobileOrderVas.Para.vas_field]) + "'", null, BusinessVas.Para.id);
                    if (_oBusinessVass != null){
                        for (int i = 0; i < _oBusinessVass.Length; i++){
                            vas_r("<option value=\"" + _oBusinessVass[i].vas_value + "\" " + ((_sVas_value.ToUpper().Trim().Equals(Func.FR(_oBusinessVass[i].vas_value).Trim().ToUpper())) ? "selected" : string.Empty) + ">" + Func.FR(_oBusinessVass[i].vas_value).ToUpper() + "</option>");
                        }
                    }
                    vas_r("</SELECT>");
                    if (_bMultiFlag)
                    {
                        vas_r("<SELECT name=\"" + Func.FR(n_oDr3[MobileOrderVas.Para.vas_field]).Trim() + "1\" id=\"" + Func.FR(n_oDr3[MobileOrderVas.Para.vas_field]).Trim() + "1\" >");
                        vas_r("<option value=\"\"></option>");

                        n_oDr2 = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT distinct vas_desc, fee from " + Configurator.MSSQLTablePrefix + "BusinessVasDescription with (nolock) where active=1 and vas='" + Func.FR(n_oDr3[MobileOrderVas.Para.vas_field]) + "'");
                        while (n_oDr2.Read())
                        {
                            vas_r("<option value=\"" + Func.FR(n_oDr2[BusinessVasDescription.Para.fee]).Trim() + "\" " + ((_sVas_desc.Equals(Func.FR(n_oDr2[BusinessVasDescription.Para.vas_desc]).Trim())) ? "selected" : string.Empty) + ">" + Func.FR(n_oDr2[BusinessVasDescription.Para.vas_desc]).Trim() + "</option>");
                        }
                        vas_r("</select>");
                        n_oDr2.Close();
                        n_oDr2.Dispose();
                    }
                    vas_r("</span></td>");
                    vas_r("</tr>");
                }
                n_oDr3.Close();
                n_oDr3.Dispose();
            }
            else
            {

                form1.Visible = false;
                show_mod_flag_tbl.Visible = true;
                notfound.Visible = false;
                show_mod_flag_placeholder.Controls.Clear();
                if ((1).Equals(_iShow_mod_flag))
                {
                    sh_r("<INPUT type=\"button\" name=\"submit22\" value=\"Modify Order\" class=\"mainoption\" onClick=\"location.href='SearchRetentionOrderViewDetail.aspx?order_id=" + ((WebFunc.qsOrder_id != null) ? Func.IDSubtract100000(WebFunc.qsOrder_id).ToString() : string.Empty) + "';this.disabled=false\"/>");
                }
                else
                {
                    sh_r("Cannot change VAS!! <br />");
                    sh_r("Please check the following items: <br />");
                    sh_r("<span class=\"gensmall\">1) New Create Order Status = DONE and<br />");
                    sh_r("2) Non-suspend Order and <br />");
                    sh_r("3) Orders under your team and<br />");
                    sh_r("4) Order has not Cancelled and<br />");
                    sh_r("5) Await Rate Plan Issue Order</span>");
                }
            }
        }
        else{
            form1.Visible = false;
            show_mod_flag_tbl.Visible = false;
            notfound.Visible = true;
        }
    }

    public void vas_r(params string[] x_sObj)
    {
        for (int i = 0; i < x_sObj.Length; i++)
            if (!string.IsNullOrEmpty(x_sObj[i])) { vas_placeholder.Controls.Add(new LiteralControl(x_sObj[i])); }
    }
    public void sh_r(params string[] x_sObj)
    {
        for (int i = 0; i < x_sObj.Length; i++)
            if (!string.IsNullOrEmpty(x_sObj[i])) { show_mod_flag_placeholder.Controls.Add(new LiteralControl(x_sObj[i])); }
    }
    #endregion

    #region GenJavascript
    public void GenJavascript()
    {
        if (n_oDr == null) InitFrame();
        wr("<script type=\"text/javascript\">");
        wr("function load_hl(){");
        if (n_oDr.HasRows)
        {
            n_iPlan_fee = 0;
            RetentionPlanEntity[] _oRetentionPlans = RetentionPlanBal.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), "active=1 and plan_code='" + Func.FR(n_oDr[MobileRetentionOrder.Para.rate_plan]) + "'", null, null);
            if (_oRetentionPlans != null){
                foreach (RetentionPlan _oRetentionPlan in _oRetentionPlans){
                    if (_oRetentionPlan.plan_fee != null){
                        if (int.TryParse(((double)_oRetentionPlan.plan_fee).ToString(), out n_iPlan_fee)){
                            if (n_iPlan_fee > 198) { wr("document.getElementById('form1').now_hd_vas.disabled = true"); }
                        }
                    }
                }
            }
            wr("\n");
            wr("\n");
            if(n_oDr[MobileOrderVas.Para.order_id] != DBNull.Value){
                MobileOrderVasEntity[] _oMobileOrderVass = MobileOrderVasBal.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), "active = 1 and vas_field='now_vas' and order_id='" + Func.FR(n_oDr[MobileOrderVas.Para.order_id]) + "'", null, null);
                if (_oMobileOrderVass != null){
                    foreach (MobileOrderVasEntity _oMobileOrderVas in _oMobileOrderVass){
                        if (!string.IsNullOrEmpty(_oMobileOrderVas.vas_value.Trim())){
                            if ("YES".Equals(_oMobileOrderVas.vas_value.Trim()) || "50%".Equals(Func.FR(_oMobileOrderVas.vas_value.Trim()))){
                                wr("document.getElementById('form1').now_hd_vas.disabled = true");
                            }
                        }
                    }
                }
            }
            if (n_oDr[MobileOrderVas.Para.order_id] != DBNull.Value){
                MobileOrderVasEntity[] _oMobileOrderVass = MobileOrderVasBal.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), "active=1 and vas_field='now_hd_vas' and order_id='" + Func.FR(n_oDr[MobileOrderVas.Para.order_id]) + "'", null, null);
                if (_oMobileOrderVass != null){
                    foreach (MobileOrderVasEntity _oMobileOrderVas in _oMobileOrderVass){
                        if (!string.IsNullOrEmpty(_oMobileOrderVas.vas_value.Trim())){
                            if ("YES".Equals(Func.FR(_oMobileOrderVas.vas_value.Trim()))){
                                wr("document.getElementById('form1').now_vas.disabled = true");
                            }
                        }
                    }
                }
            }
        }
        wr("}");

        wr("//------------------  Hard Code in VAS selection ----------------//");
        if (n_oDr.HasRows)
        {
            wr("function chk_vas(){");
            wr("	if ('" + Func.FR(n_oDr[MobileRetentionOrder.Para.program]).ToUpper().Trim() + "'!='EASYWATCH STANDALONE'){");
            wr("		enable_vas()");
            wr("		ch_mcam(\"disable\")");
            wr("		ch_min_vas()");
            wr("		ch_min_vas300()");
            wr("		ch_min_vas400()");
            wr("		ch_min_vas500()");
            wr("		ch_license()");
            wr("		ch_vmin_vas()");
            wr("		//ch_imin_vas400()");
            wr("		//ch_aig_gift()");
            wr("	}");
            wr("	else{");
            wr("		c_vas()");
            wr("		ch_mcam(\"enable\")");
            wr("		//ch_imin_vas400()");
            wr("	}");
            wr("}");

            wr("/*****  Disable all VAS *****/");
            wr("function c_vas(){");

            
            n_oDr2 = BusinessVasBal.GetSearch(GetDB(), "distinct vas_field", "active = 1", null, null);
            while (n_oDr2.Read())
            {
                wr("	document.getElementById(\"" + Func.FR(n_oDr2[BusinessVas.Para.vas_field]).Trim() + "\").disabled = true");
            }
            n_oDr2.Close();
            n_oDr2.Dispose();
            n_oDr2 = BusinessVasBal.GetSearch(GetDB(), "distinct vas_field", "active=1 and multi=1", null, null);
            while (n_oDr2.Read())
            {
                wr("	document.getElementById(\"" + Func.FR(n_oDr2[BusinessVas.Para.vas_field]).Trim() + "1\").disabled = true");
            }
            wr("}");
            wr("/*****  Enable all VAS *****/");
            wr("function enable_vas(){");
            wr("<%");
            n_oDr2.Close();
            n_oDr2.Dispose();
            n_oDr2 = BusinessVasBal.GetSearch(GetDB(), "distinct vas_field", "active = 1", null, null);
            while (n_oDr2.Read())
            {
                wr("	document.getElementById(\"" + Func.FR(n_oDr2[BusinessVas.Para.vas_field]).Trim() + "\").disabled = false");
            }
            n_oDr2.Close();
            n_oDr2.Dispose();
            n_oDr2 = BusinessVasBal.GetSearch(GetDB(), "distinct vas_field", "active = 1 and multi=1", null, null);
            while (n_oDr2.Read())
            {
                wr("	document.getElementById(\"" + Func.FR(n_oDr2[BusinessVas.Para.vas_field]).Trim() + "1\").disabled = false");
            }
            n_oDr2.Close();
            n_oDr2.Dispose();
            wr("}");
            wr("/*****  MCAM Bundle Rebate *****/");
            wr("function ch_mcam(action){");
            wr("	if (action==\"enable\"){");
            wr("		document.getElementById(\"mcam_vas1\").disabled = false");
            wr("		document.getElementById(\"mcam_vas\").disabled = false");
            wr("	}");
            wr("	else{");
            wr("		document.getElementById(\"mcam_vas1\").value=\"\";");
            wr("		document.getElementById(\"mcam_vas1\").disabled = true");
            wr("		document.getElementById(\"mcam_vas\").value=\"NO\";");
            wr("		document.getElementById(\"mcam_vas\").disabled = true");
            wr("	}");
            wr("}");
            wr("/*****  Additional Video Call Minutes *****/");
            wr("function ch_vmin_vas(){");
            wr("	if ('" + Func.FR(n_oDr[MobileRetentionOrder.Para.program]).Trim().ToUpper() + "'=='EASYWATCH BUNDLE' ){");
            wr("		document.getElementById(\"vmin_vas1\").disabled = false");
            wr("		document.getElementById(\"vmin_vas\").disabled = false");
            wr("	}");
            wr("	else{");
            wr("		document.getElementById(\"vmin_vas1\").value=\"\";");
            wr("		document.getElementById(\"vmin_vas1\").disabled = true");
            wr("		document.getElementById(\"vmin_vas\").value=\"NO\";");
            wr("		document.getElementById(\"vmin_vas\").disabled = true");
            wr("	}");
            wr("}");
            wr("/*****  $12 License Fee Waiver *****/");
            wr("function ch_license(){");
            wr("	if (('" + Func.FR(n_oDr[MobileRetentionOrder.Para.rate_plan]).Trim().ToUpper() + "'=='3GRETENT0035A' && '" + Func.FR(n_oDr[MobileRetentionOrder.Para.con_per]).Trim().ToUpper() + "'=='12') || '" + Func.FR(n_oDr[MobileRetentionOrder.Para.bundle_name]).Trim().ToUpper() + "'=='3GRLOB0088RPBUNDLE18M (FREE $30)'  || '" + Func.FR(n_oDr[MobileRetentionOrder.Para.bundle_name]).Trim().ToUpper() + "'=='3GRETSTA0035RPBUNDLE'){");
            wr("		document.getElementById('form1').license_waiver.disabled = false");
            wr("	}");
            wr("	else{");
            wr("		document.getElementById('form1').license_waiver.value=\"NO\";");
            wr("		document.getElementById('form1').license_waiver.disabled = true");
            wr("	}");
            wr("}");
            wr("/*****  Additional 500 Minutes *****/");
            wr("function ch_min_vas500(){");
            wr("	if ('" + Func.FR(n_oDr[MobileRetentionOrder.Para.bundle_name]).Trim().ToUpper() + "'=='3GRETDISCRPBUNDLE12M' || ('" + Func.FR(n_oDr[MobileRetentionOrder.Para.bundle_name]).Trim().ToUpper() + "'=='3GRET0098DISCRPBUNDLE12M'  &&'" + Func.FR(n_oDr[MobileRetentionOrder.Para.program]).Trim().ToUpper() + "'=='P6 RETENTION' )){");
            wr("		document.getElementById('form1').min_vas500.disabled = false");
            wr("	}");
            wr("	else{");
            wr("		document.getElementById('form1').min_vas500.disabled = true");
            wr("		document.getElementById('form1').min_vas500.value = \"NO\"");
            wr("	}");
            wr("}");
            wr("/*****  Additional 300 Minutes *****/");
            wr("function ch_min_vas300(){");
            wr("	if ('" + Func.FR(n_oDr[MobileRetentionOrder.Para.bundle_name]).Trim().ToUpper() + "'=='3GRET0035PMUBUNDLE24M' ){");
            wr("//	if ('" + Func.FR(n_oDr[MobileRetentionOrder.Para.bundle_name]).Trim().ToUpper() + "'=='3GRET0035PMUBUNDLE24M' || '" + Func.FR(n_oDr[MobileRetentionOrder.Para.bundle_name]).Trim().ToUpper() + "'=='3GRET0035RPBUNDLE12M' ){");
            wr("		document.getElementById('form1').min_vas300.disabled = false");
            wr("	}");
            wr("	else{");
            wr("		document.getElementById('form1').min_vas300.disabled = true");
            wr("		document.getElementById('form1').min_vas300.value = \"NO\"");
            wr("	}");
            wr("}");
            wr("/*****  Additional 400 Minutes *****/");
            wr("function ch_min_vas400(){");
            wr("	if ('" + Func.FR(n_oDr[MobileRetentionOrder.Para.program]).Trim().ToUpper() + "'!='EASYWATCH BUNDLE' && ('" + Func.FR(n_oDr[MobileRetentionOrder.Para.rate_plan]).Trim().ToUpper() + "'=='3GRETENT0138A' || '" + Func.FR(n_oDr[MobileRetentionOrder.Para.rate_plan]).Trim().ToUpper() + "'=='3GRETENT0198A' || '" + Func.FR(n_oDr[MobileRetentionOrder.Para.rate_plan]).Trim().ToUpper() + "'=='3GRETENT0298A' || '" + Func.FR(n_oDr[MobileRetentionOrder.Para.rate_plan]).Trim().ToUpper() + "'=='3GRETENT0498A')){");
            wr("		document.getElementById('form1').min_vas400.disabled = false");
            wr("	//	document.getElementById('form1').min_vas400.options[1].selected = true");
            wr("	}");
            wr("	else{");
            wr("		document.getElementById('form1').min_vas400.disabled = true");
            wr("		document.getElementById('form1').min_vas400.value = \"NO\"");
            wr("	}");
            wr("}");
            wr("/*****  Intra-Additional 400 Minutes *****/");
            wr("function ch_imin_vas400(){");
            wr("	if ('" + Func.FR(n_oDr[MobileRetentionOrder.Para.program]).Trim().ToUpper() + "'=='EASYWATCH BUNDLE'){");
            wr("		document.getElementById('form1').imin_vas400.disabled = false");
            wr("	//	document.getElementById('form1').min_vas400.options[1].selected = true");
            wr("	}");
            wr("	else{");
            wr("		document.getElementById('form1').imin_vas400.disabled = true");
            wr("		document.getElementById('form1').imin_vas400.value = \"NO\"");
            wr("	}");
            wr("}");
            wr("/*****  Additional 800 Minutes *****/");
            wr("function ch_min_vas(){");
            wr("	if ('" + Func.FR(n_oDr[MobileRetentionOrder.Para.program]).Trim().ToUpper() + "'!='EASYWATCH BUNDLE' &&('" + Func.FR(n_oDr[MobileRetentionOrder.Para.rate_plan]).Trim().ToUpper() + "'=='3GRETENT0138A' || '" + Func.FR(n_oDr[MobileRetentionOrder.Para.bundle_name]).Trim().ToUpper() + "'=='3GRLOB0088RPBUNDLE18M (FREE $30)' || '" + Func.FR(n_oDr[MobileRetentionOrder.Para.bundle_name]).Trim().ToUpper() + "'=='3GRLOB0088RPBUNDLE15M (FREE $30)' || '" + Func.FR(n_oDr[MobileRetentionOrder.Para.bundle_name]).Trim().ToUpper() + "'=='3GRLOB0088HSBUNDLE24M' || '" + Func.FR(n_oDr[MobileRetentionOrder.Para.bundle_name]).Trim().ToUpper() + "'=='3GRETENT0138MFO(1)HSBUNDLE18M' || '" + Func.FR(n_oDr[MobileRetentionOrder.Para.bundle_name]).Trim().ToUpper() + "'=='3GRLOB0138PMUBUNDLE15M (FREE $53)' || '" + Func.FR(n_oDr[MobileRetentionOrder.Para.bundle_name]).Trim().ToUpper() + "'=='3GRLOB0138PMUBUNDLE15M (FREE $23)' || '" + Func.FR(n_oDr[MobileRetentionOrder.Para.bundle_name]).Trim().ToUpper() + "'=='3GRLOB0138PMUBUNDLE18M (FREE $0)' || '" + Func.FR(n_oDr[MobileRetentionOrder.Para.bundle_name]).Trim().ToUpper() + "'=='3GRLOB0198HSBUNDLE24M' || '" + Func.FR(n_oDr[MobileRetentionOrder.Para.bundle_name]).Trim().ToUpper() + "'=='3GRLOB0138HSBUNDLE24M' || '" + Func.FR(n_oDr[MobileRetentionOrder.Para.bundle_name]).Trim().ToUpper() + "'=='3GRLOB0138HSBUNDLE18M' || '" + Func.FR(n_oDr[MobileRetentionOrder.Para.bundle_name]).Trim().ToUpper() + "'=='3GRLOB0088HSBUNDLE24M')){");
            wr("		document.getElementById('form1').min_vas.disabled = false");
            wr("	}");
            wr("	else{");
            wr("		document.getElementById('form1').min_vas.disabled = true");
            wr("	//	document.getElementById('form1').min_vas.value=\"NO\"");
            wr("	}");
            wr("	if ('" + Func.FR(n_oDr["channel"]).Trim().ToUpper() + "'=='OB' ){");
            wr("		if ('" + Func.FR(n_oDr[MobileRetentionOrder.Para.program]).Trim() + "'=='New Sim Only Retention' && ('" + Func.FR(n_oDr[MobileRetentionOrder.Para.rate_plan]).Trim().ToUpper() + "'=='3GRETLOB0138A' || '" + Func.FR(n_oDr[MobileRetentionOrder.Para.rate_plan]).Trim().ToUpper() + "'=='3GRETLOB0198A') && '" + Func.FR(n_oDr[MobileRetentionOrder.Para.premium]).Trim()+ "'!=''){");
            wr("			document.getElementById('form1').min_vas.disabled = true");
            wr("		//	document.getElementById('form1').min_vas.value=\"NO\"");
            wr("		}");
            wr("	}");
            wr("	else{");
            wr("		if ('" + Func.FR(n_oDr[MobileRetentionOrder.Para.program]).Trim().ToUpper() + "'=='New Sim Only Retention' && ('" + Func.FR(n_oDr[MobileRetentionOrder.Para.rate_plan]).Trim().ToUpper() + "'=='3GRETLOB0138A' || '" + Func.FR(n_oDr[MobileRetentionOrder.Para.rate_plan]).Trim().ToUpper() + "'=='3GRETLOB0198A') && '" + Func.FR(n_oDr[MobileRetentionOrder.Para.premium]).Trim() + "'!=''){");
            wr("			document.getElementById('form1').min_vas.disabled = false");
            wr("		}");
            wr("	}");
            wr("	");
            wr("	if ('" + Func.FR(n_oDr[MobileRetentionOrder.Para.rebate]).Trim().ToUpper() + "'=='69' && '" + Func.FR(n_oDr[MobileRetentionOrder.Para.program]).Trim().ToUpper() + "'=='Mass Retention' && ('" + Func.FR(n_oDr[MobileRetentionOrder.Para.con_per]).Trim().ToUpper() + "'=='12' || '" + Func.FR(n_oDr[MobileRetentionOrder.Para.con_per]).Trim().ToUpper() + "'=='18') ) {");
            wr("		//document.all.min_vas.options[1].selected = true");
            wr("	}");
            wr("	else{");
            wr("		//document.all.min_vas.options[2].selected = true");
            wr("	}");
            wr("}");
            
        }
        n_oDr.Close();
        n_oDr.Dispose();
        wr("</script>");

    }

    public void wr(string x_sCode)
    {
        Response.Write(x_sCode);
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
