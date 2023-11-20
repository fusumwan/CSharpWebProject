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

public partial class SearchRetentionOrderViewDetail : NEURON.WEB.UI.BasePage
{
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion
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

    protected void Page_LoadComplete(object sender, EventArgs e)
    {

    }

    #region InitFrame
    public void InitFrame()
    {
        if ("pass".Equals(Request["pass"]))
            RunJavascriptFunc("alert('Order" + WebFunc.qsOrder_id + " Will Send To PY Again')");
        int _iCancel_flag = 1;
        int _iMod_flag = 1;
        int _iFo_flag = 0;
        int _iEDF_Fo_flag = 0;
        int _iReact_flag = 0;
        int _iCsa_flag = 0;
        int _iAdd_flag = 0;
        int _iVas_fo_flag = 0;
        string _bStatus = string.Empty;
        string _sEdf = string.Empty;
        string _sIssue_type = string.Empty;
        string _sHsmodel = string.Empty;
        bool _bHaveActualDeliveryDate = false;
        List<string> _oSalesmancodeList = new List<string>();
        string _sSalesmancode = string.Empty;
        SqlDataReader _oDr = OrderReleaseDetailRepository.GetSearch(SYSConn<MSSQLConnect>.Connect(), "TOP 1 *", "order_id='" + Func.IDSubtract100000(WebFunc.qsOrder_id) + "' and active=1", null, null);
        if (_oDr.Read()) { _iAdd_flag = 1; }
        _oDr.Close();
        _oDr.Dispose();
        _oDr = MobileRetentionOrderBal.GetSearch(SYSConn<MSSQLConnect>.Connect(), "TOP 1 datediff(d,getdate(),d_date) as date_diff,datediff(d,getdate(),con_eff_date) as con_diff,*", "order_id='" + Func.IDSubtract100000(WebFunc.qsOrder_id) + "'", null, null);
        if (_oDr.Read())
        {
            _sEdf = Func.FR(_oDr[MobileRetentionOrder.Para.edf_no]);
            _sIssue_type = Func.FR(_oDr[MobileRetentionOrder.Para.issue_type]);
            _sHsmodel = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar("SELECT TOP 1 hs_model FROM MobileRetentionOrder with (nolock) WHERE order_id='" + Func.IDSubtract100000(WebFunc.qsOrder_id) + "'").Trim();
            _sSalesmancode = Func.FR(_oDr[ProfileTeamDetail.Para.salesmancode]).ToUpper().Trim();
            
            //=== If status=FALLOUT -> allow modify, if VAS fallout -> go to VAS fallout replied page ===
            SqlDataReader _oDr2 = MobileOrderReportBal.GetSearch(SYSConn<MSSQLConnect>.Connect(), "TOP 1 * ", "active=1 AND order_status='FALLOUT' AND order_id='" + Func.IDSubtract100000(WebFunc.qsOrder_id) + "'", null, " mid desc, email_date desc");
            if (_oDr2.Read())
            {
                _bStatus = "1|";
                if ("rwl_vas".Equals(Func.FR(_oDr2[MobileOrderReport.Para.report_type]).Trim()))
                    _iVas_fo_flag = 1;
                else
                    _iFo_flag = 1;
            }
            _oDr2.Close();
            _oDr2.Dispose();

            if (_sIssue_type == "UPGRADE")
            {
                EDFStatusProfile _oEDFStatusProfile = new EDFStatusProfile();
                _oEDFStatusProfile.LoadData(_sEdf);
                if (_oEDFStatusProfile.Fo_to_sales == "Y")
                {
                    _iEDF_Fo_flag = 1;
                }
            }

            //Take out Cancel Remark and Cancel button if order is opt out and done
            string _sQuery = "SELECT TOP 1 * FROM MobileOrderReport with (nolock) where active=1 and order_status='DONE' and report_type='rwl_opt_out' and order_id='" + Func.IDSubtract100000(WebFunc.qsOrder_id) + "'";
            _oDr2 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
            if (_oDr2.Read())
            {
                _iCancel_flag = 0;
            }
            _oDr2.Close();
            _oDr2.Dispose();


            //=== Check Actual Delivery Date ===
            OdbcDataReader _oOr2 = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT referenceNO,actual_del_date FROM SUNDAY_Form WHERE referenceNO='" + _sEdf + "' and  actual_del_date is not null");
            if (_oOr2.Read())
            {
                if (!_sEdf.Equals(string.Empty) && !Func.FR(_oOr2["actual_del_date"]).Trim().Equals(string.Empty))
                {
                    _bStatus += "8|";
                    _iCancel_flag = 0;
                    _iMod_flag = 0;
                    _bHaveActualDeliveryDate = true;
                }
            }
            _oOr2.Close();
            _oOr2.Dispose();


            //=== If status=FALLOUT REPILED -> cannot modify ===
            _oDr2 = MobileOrderReportBal.GetSearch(SYSConn<MSSQLConnect>.Connect(), "TOP 1 * ", "active=1 and order_status='FALLOUT REPLIED' and order_id='" + Func.IDSubtract100000(WebFunc.qsOrder_id) + "'", null, " mid desc, email_date desc");
            if (_oDr2.Read())
            {
                _bStatus += "2|";
                _iMod_flag = 0;
                _iFo_flag = 0;
            }
            _oDr2.Close();
            _oDr2.Dispose();

            //=== access right = CS Admin / View Only -> cannot modify/cancel/add ===
            if ("5".Equals(RWLFramework.CurrentUser[this.Page].Lv) || "6".Equals(RWLFramework.CurrentUser[this.Page].Lv))
            {
                _bStatus += "4|";
                _iMod_flag = 0;
                _iCancel_flag = 0;
                _iFo_flag = 0;
                _iAdd_flag = 0;
            }

            
            SaleManCodeProfile _oSaleManCodeProfile = new SaleManCodeProfile();
            _oSaleManCodeProfile.SetLv(RWLFramework.CurrentUser[this.Page].Lv);
            _oSaleManCodeProfile.SetUid(RWLFramework.CurrentUser[this.Page].Uid);
            _oSalesmancodeList = _oSaleManCodeProfile.Get_SalemanCodeList();

            //=== No access right control ===
            if (!"5".Equals(RWLFramework.CurrentUser[this.Page].Lv) && !"6".Equals(RWLFramework.CurrentUser[this.Page].Lv) &&
                "suspend".Equals(Func.FR(_oDr["action_required"]).Trim()) ||
                "3GRET0098AUTOREN12M".Equals(Func.FR(_oDr["trade_field"]).Trim()) ||
                "3GRET0198AUTOREN12M".Equals(Func.FR(_oDr[MobileRetentionOrder.Para.trade_field]).Trim()) ||
                "3GRET0298AUTOREN12M".Equals(Func.FR(_oDr[MobileRetentionOrder.Para.trade_field]).Trim()) ||
                "NA".Equals(Func.FR(_oDr[MobileRetentionOrder.Para.trade_field]).Trim()))
            {
                _bStatus += "6|";
                _iMod_flag = 1;
            }

            //=== Check Opt Out ===
            SqlDataReader _oDr6 = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT o.action_required, r.order_status FROM MobileRetentionOrder o INNER JOIN MobileOrderReport r ON o.order_id=r.order_id WHERE o.action_required IS NOT NULL AND o.action_required <>'' AND o.action_required='opt_out' AND r.order_status='DONE' AND o.order_id='" + Func.IDSubtract100000(WebFunc.qsOrder_id) + "'");
            if (_oDr6.Read())
            {
                _iCancel_flag = 0;
            }
            _oDr6.Close();
            _oDr6.Dispose();

            //=== Check Contract Effective Date ===
            int _iCon_diff;
            if (!string.IsNullOrEmpty(Func.FR(_oDr["con_diff"])))
            {
                if (int.TryParse(Func.FR(_oDr["con_diff"]), out _iCon_diff))
                {
                    if (_iCon_diff <= 0) { _iCancel_flag = 0; }
                }
            }

            if (!"".Equals(Func.FR(_oDr[MobileRetentionOrder.Para.edf_no])))
            {
                //=== Check Delivery Date ===
                int _iDate_diff;
                if (int.TryParse(Func.FR(_oDr["date_diff"]), out _iDate_diff))
                {
                    _bStatus += "7|";
                    if ((_iDate_diff < 1 || (_iDate_diff == 1 && DateTime.Now.Hour >= 15)) )
                    {
                        _iCancel_flag = 0;
                        if (!_bHaveActualDeliveryDate && _iDate_diff <= -2)
                        {
                            _iMod_flag = 1;
                        }
                        else if(!_bHaveActualDeliveryDate)
                        {
                            _iMod_flag = 0;
                        }
                    }
                    else
                    {
                        _iMod_flag = 1;
                    }
                    if (_iDate_diff.Equals(0))
                        _iMod_flag = 0;
                }

                //=== Check Cancelled in EDF ===
                _oOr2 = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT referenceNO FROM SUNDAY_Form WHERE referenceNO='" + Func.FR(_oDr[MobileRetentionOrder.Para.edf_no]) + "' and cancelled='Y' ");
                if (_oOr2.Read())
                {
                    _bStatus += "9|";
                    _iCancel_flag = 0;
                    _iMod_flag = 0;
                    _iReact_flag = 1;
                }
                _oOr2.Close();
                _oOr2.Dispose();
            }
            else
            {
                if (Func.FR(_oDr[MobileRetentionOrder.Para.hs_model]).Equals(string.Empty) || Convert.IsDBNull(_oDr[MobileRetentionOrder.Para.hs_model]))
                {

                    SqlDataReader _oDr3 = MobileOrderReportBal.GetSearch(SYSConn<MSSQLConnect>.Connect(), "order_status", "order_id='" + Func.IDSubtract100000(WebFunc.qsOrder_id) + "' and active=1", null, null);
                    if (_oDr3.Read())
                    {
                        _iMod_flag = 0;
                        SqlDataReader _oDr4 = MobileOrderReportBal.GetSearch(SYSConn<MSSQLConnect>.Connect(), "TOP 1 order_status,report_type", " order_id='" + Func.IDSubtract100000(WebFunc.qsOrder_id) + "'  and active=1 and order_status='FALLOUT'", null, "mid desc,email_date desc");
                        if (_oDr4.Read())
                        {
                            _bStatus += "10|";
                            if (!"rwl_vas".Equals(Func.FR(_oDr4[MobileOrderReport.Para.report_type])))
                                _iMod_flag = 1;
                        }
                        if (_oDr4 != null) { _oDr4.Close(); _oDr4.Dispose(); }
                    }
                }
            }

            if (RWLFramework.CurrentUser[this.Page].Lv == "1")
            {
                //=== if order is retrieved -> FL cannot modify ===
                if (CheckRetrieved())
                {
                    _iMod_flag = 0;
                }
            }

            if (ModifyFlagInit() && !_sHsmodel.Trim().ToString().Equals(string.Empty) && _iMod_flag!=0)
                _iMod_flag = 1;
            else
            {
                //=== if status ==DONE -> cannot modify ===

                if (_sHsmodel.Trim().Equals(string.Empty))
                {
                    _oDr2 = MobileOrderReportBal.GetSearch(SYSConn<MSSQLConnect>.Connect(), "TOP 1 * ", "active=1 and (order_status='DONE' or order_status='AWAIT RATE PLAN ISSUE') and order_id='" + Func.IDSubtract100000(WebFunc.qsOrder_id) + "'", null, " mid desc, email_date desc");
                    if (_oDr2.Read())
                    {
                        _bStatus += "3|";
                        _iMod_flag = 0;
                    }
                    _oDr2.Close();
                    _oDr2.Dispose();
                }
            }
            if (!("65535".Equals(RWLFramework.CurrentUser[this.Page].Lv)
               || Func.FR(_oDr[ProfileTeamDetail.Para.staff_no]).Trim().Equals(RWLFramework.CurrentUser[this.Page].Uid)
               ||
               (
               "10".Equals(RWLFramework.CurrentUser[this.Page].Lv) &&
               _oSalesmancodeList.Contains(Func.FR(_oDr[ProfileTeamDetail.Para.salesmancode]).ToUpper().Trim())
               )
               ))
            {
                _bStatus += "5[staff_no:" + Func.FR(_oDr[ProfileTeamDetail.Para.staff_no]).Trim() + " % Salesmancodelist count:" + _oSalesmancodeList.Count + " % Salemancode:" + Func.FR(_oDr[ProfileTeamDetail.Para.salesmancode]).Trim() + " ]|";
                _iMod_flag = 0;
                _iCancel_flag = 0;
                _iFo_flag = 0;
                _iAdd_flag = 0;
            }
            if (_oDr2 != null) { _oDr2.Close(); _oDr2.Dispose(); }
        }

        if (RWLFramework.CurrentUser[this.Page].Uid == "A8350006")
        {
            wr("<pre>");
            wr("SessionUID : " + Session["uid"].ToString() + "<br>");
            wr("SessionLV : " + Session["lv"].ToString() + "<br>");
            wr("UID : " + RWLFramework.CurrentUser[this.Page].Uid.ToString() + "<br>");
            wr("LV : " + RWLFramework.CurrentUser[this.Page].Lv.ToString() + "<br>");
            wr("_bStatus : " + _bStatus.ToString() + "<br>");
            wr("_iCancel_flag : " + _iCancel_flag.ToString() + "<br>");
            wr("_iMod_flag : " + _iMod_flag.ToString() + "<br>");
            wr("_iFo_flag : " + _iFo_flag.ToString() + "<br>");
            wr("_iReact_flag : " + _iReact_flag.ToString() + "<br>");
            wr("_iCsa_flag : " + _iCsa_flag.ToString() + "<br>");
            wr("_iAdd_flag : " + _iAdd_flag.ToString() + "<br>");
            wr("_sActive : " + Func.FR(_oDr["active"]).Trim() + "<br>");
            wr("</pre>");
        }
        wr("<table width=\"100%\" border=\"0\" cellpadding=\"3\" cellspacing=\"1\" class=\"forumline\">");
        wr("<tr>");
        wr("<th height=\"28\" colspan=\"4\">&nbsp;<span class=\"explaintitle\" style=\"font-size:8pt\">" + global::PCCW.RWL.CORE.Configurator.GetTitle() + "(" + WebFunc.qsOrder_id + ")</th>");
        wr("</tr>");
        wr("<tr>");
        wr("<td height=\"23\" colspan=\"4\" class=\"row2\"><span class=\"gensmall\">");
        wr("<input name=\"submit223\" type=\"button\" class=\"button\" value=\"BACK\" onClick=\"history.go(-1);\" style=\"font-size:7pt\" />");

        if (!"5".Equals(RWLFramework.CurrentUser[this.Page].Lv) && !"6".Equals(RWLFramework.CurrentUser[this.Page].Lv))
        {
            /*
            if ("2420251".Equals(WebFunc.qsSku) || "2420261".Equals(WebFunc.qsSku) || "2420271".Equals(WebFunc.qsSku))
                wr("<input type=\"button\" name=\"submit22\" value=\"Print NDS SA\" class=\"mainoption\" onClick=\"location.href='http://136.139.22.21:8080/rwl" + ((Configurator.IsUat()) ? "uat" : string.Empty) + "/servlet/GenerateM3GTFormNet?dbname=MobileRetentionOrderDB" + ((Configurator.IsUat()) ? "_UAT" : string.Empty) + "&order_id=" + Func.IDSubtract100000(WebFunc.qsOrder_id) + "';this.disabled=false\"/>");
            else if(_oDr.HasRows){
                
                if (!"".Equals(Func.FR(_oDr[MobileRetentionOrder.Para.hs_model]).Trim()))
                    wr("<input type=\"button\" name=\"submit22\" value=\"Print SA\" class=\"mainoption\" onClick=\"location.href='http://136.139.22.21:8080/rwl" + ((Configurator.IsUat()) ? "uat" : string.Empty) + "/servlet/GenerateMHSRFormNet?dbname=MobileRetentionOrderDB" + ((Configurator.IsUat()) ? "_UAT" : string.Empty) + "&order_id=" + Func.IDSubtract100000(WebFunc.qsOrder_id) + "';this.disabled=false\"/>");
                else if ("GO WIRELESS".Equals(Func.FR(_oDr[MobileRetentionOrder.Para.program]).Trim()))
                    wr("<input type=\"button\" name=\"submit22\" value=\"Print Go Wireless\" class=\"mainoption\" onClick=\"location.href='http://136.139.22.21:8080/rwl" + ((Configurator.IsUat()) ? "uat" : string.Empty) + "/servlet/GenerateGWFormNet?dbname=MobileRetentionOrderDB" + ((Configurator.IsUat()) ? "_UAT" : string.Empty) + "&order_id=" + Func.IDSubtract100000(WebFunc.qsOrder_id) + "';this.disabled=false\"/>");
                wr("<input type=\"button\" name=\"submit22\" value=\"Print PLG\" class=\"mainoption\" onClick=\"location.href='http://136.139.22.21:8080/rwl" + ((Configurator.IsUat()) ? "uat" : string.Empty) + "/servlet/GenerateSDNFormNet?dbname=MobileRetentionOrderDB" + ((Configurator.IsUat()) ? "_UAT" : string.Empty) + "&order_id=" + Func.IDSubtract100000(WebFunc.qsOrder_id) + "';this.disabled=false\"/>");
            }
             */
            //wr("<input type=\"button\" name=\"submit22\" value=\"Print As PDF\" class=\"mainoption\" onClick=\"location.href='http://136.139.22.21:8080/rwl" + ((Configurator.IsUat()) ? "uat" : string.Empty) + "/servlet/GenerateRWLForm?order_id=" + Func.IDSubtract100000(WebFunc.qsOrder_id) + "';this.disabled=false\"/>");
            wr("<input type=\"button\" name=\"submit22\" value=\"Print As PDF\" class=\"mainoption\" onClick=\"PrintPDF('" + ((Configurator.IsUat()) ? "uat" : string.Empty) + "','" + ((int)WebFunc.qsOrder_id).ToString() + "')\";this.disabled=false\"/>");


        }

        wr("<input name=\"supp2\" type=\"button\" class=\"mainoption\"  value=\"EDF Status\" onClick=\"window.open('EDFmanagement.aspx?edf_no=" + _sEdf.Trim() + "','_blank','toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=yes, copyhistory=no, width=500, height=620');\"/>");
        wr("<input name=\"supp22\" type=\"button\" class=\"mainoption\"  value=\"Order History\" onClick=\"window.open('HistoryReportViewImplement.aspx?order_id=" + Func.IDSubtract100000(WebFunc.qsOrder_id) + "','_blank','toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=yes, copyhistory=no, width=800, height=400');\"/>");
        wr("<input name=\"supp222\" type=\"button\" class=\"mainoption\"  value=\"Status History\" onClick=\"window.open('AdminViewHistoryImplement.aspx?order_id=" + Func.IDSubtract100000(WebFunc.qsOrder_id) + "','_blank','toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=yes, copyhistory=no, width=600, height=200');\"/>");

        bool _bActive = false;
        if (_oDr.HasRows)
        {
            string _sActive = (Func.FR(_oDr[MobileRetentionOrder.Para.active]).Trim() != string.Empty) ? Func.FR(_oDr[MobileRetentionOrder.Para.active]).Trim() : "False";
            _bActive = Convert.ToBoolean(_sActive);
        }

        if (_oDr.HasRows)
        {
            if (_sIssue_type != "UPGRADE")
            {

                if ((_bActive && _iMod_flag.Equals(1)) ||
                    _iFo_flag.Equals(1) || _iEDF_Fo_flag.Equals(1) ||
                    Func.FR(_oDr[MobileRetentionOrder.Para.action_required]).Equals("opt_out"))
                {
                    wr("<input type=\"button\" name=\"submit2\" value=\"Modify Order\" class=\"mainoption\" onClick=\"location.href='PreviousOrderModify.aspx?order_id=" + Func.RQ(WebFunc.qsOrder_id).Trim() + "';this.disabled=false\"/>");
                }
            }
            else
            {
                if (_bHaveActualDeliveryDate == false)
                {
                    if ((_bActive && _iMod_flag.Equals(1)) ||
                      _iFo_flag.Equals(1) || _iEDF_Fo_flag.Equals(1) ||
                      Func.FR(_oDr[MobileRetentionOrder.Para.action_required]).Equals("opt_out"))
                    {
                        wr("<input type=\"button\" name=\"submit2\" value=\"Modify Order\" class=\"mainoption\" onClick=\"location.href='PreviousOrderModify.aspx?order_id=" + Func.RQ(WebFunc.qsOrder_id).Trim() + "';this.disabled=false\"/>");
                    }
                }
            }
        }

        if (_iVas_fo_flag.Equals(1))
        {
            wr("<input type=\"button\" name=\"submit2\" value=\"Reply VAS Fallout\" class=\"mainoption\" onClick=\"location.href='ChangeVasView.aspx?order_id=" + Func.RQ(WebFunc.qsOrder_id) + "';this.disabled=false\"/>");
        }
        if (_oDr.HasRows)
        {
            if (_iReact_flag.Equals(1) && _bActive)
            {
                Session["IssueOrderWeblogProcess"] = "IssueOrderWeblogProcess";
                wr("<input type=\"button\" name=\"submit12\" value=\"Re-Active Order\" class=\"mainoption\" onClick=\"location.href='MigrateToEDF.aspx?action=re-act&order_id=" + Func.IDSubtract100000(WebFunc.qsOrder_id) + "';this.disabled=false\" />");
            }
            if (_iAdd_flag.Equals(1) && _bActive && _sHsmodel.Trim() == string.Empty)
            {
                wr("<br>Order Released!");
                wr("<input type=\"button\" name=\"submit12\" value=\"Add New Order\" class=\"mainoption\" onClick=\"location.href='MobileRetentionOrderAddModify.aspx?order_id=" + Func.RQ(WebFunc.qsOrder_id) + "';this.disabled=false\" />");
                if ("65535".Equals(RWLFramework.CurrentUser[this.Page].Lv) || "80173792".Equals(RWLFramework.CurrentUser[this.Page].Uid) || "435925".Equals(RWLFramework.CurrentUser[this.Page].Uid) || "846162".Equals(RWLFramework.CurrentUser[this.Page].Uid) || "A3150498".Equals(RWLFramework.CurrentUser[this.Page].Uid) || "1003052".Equals(RWLFramework.CurrentUser[this.Page].Uid) || "310540".Equals(RWLFramework.CurrentUser[this.Page].Uid) || "1003052".Equals(RWLFramework.CurrentUser[this.Page].Uid))
                    wr("<input type=\"button\" name=\"submit12\" value=\"re-active released order\" class=\"mainoption\" onClick=\"if(confirm('Are you sure?')){location.href='ReActiveOrderAction.aspx?order_id=" + Func.IDSubtract100000(WebFunc.qsOrder_id) + "'}\" />");
            }
        }
        wr("<br>");
        if (_oDr.HasRows)
        {
            if (_bActive)
            {
                if (_sIssue_type != "UPGRADE")
                {
                    if ((1).Equals(_iCancel_flag) || (1).Equals(_iFo_flag))
                    {
                        form1.Action = "OrderDeleteImplement.aspx?order_id=" + ((int)WebFunc.qsOrder_id).ToString();
                        if (RWLFramework.CurrentUser[this.Page].Lv != "1")
                        {
                            wr("Cancel Remark:");
                            wr("<input name=\"del_remark\" type=\"text\" id=\"del_remark\" style=\"font-size:7pt\" size=\"100\" maxlength=\"250\" onBlur=\"chg_upper(this);\"/>");
                            wr("<input type=\"button\" name=\"submit1\" value=\"Cancel Order\" class=\"mainoption\" onClick=\"if(document.getElementById('form1').del_remark!=undefined){ if(confirm('Are you sure you want to delete this order?')){if(document.getElementById('form1').del_remark.value!=''){  document.getElementById('form1').action='OrderDeleteImplement.aspx?order_id=" + (Convert.ToInt32(WebFunc.qsOrder_id)).ToString() + "';    document.getElementById('form1').submit();} else{ alert('Enter Cancel Remark?');}}}\" />");
                        }
                    }
                }
            }
            else
            {
                wr("<br>");
                wr("Order Cancelled !!<br>");
                wr("Cancel Remark: " + Func.FR(_oDr[MobileRetentionOrder.Para.del_remark]) + " <br />");
            }
        }

        bool _bReportTypeHasRow = false;
        {
            SqlDataReader _oDr2 = MobileOrderReportBal.GetSearch(SYSConn<MSSQLConnect>.Connect(), "top 1 report_type,order_status,fallout_reason,cdate,fallout_reply,fallout_remark,sent_again,retrieve_date", "active=1 and order_id='" + ((_oDr.HasRows) ? Func.FR(_oDr["order_id"]) : string.Empty) + "' ", null, "mid desc, email_date desc");
            if (_oDr2.Read())
            {
                _bReportTypeHasRow = true;
                wr("<br>Action Required:");
                if ("SuspendEventDetail".Equals(Func.FR(_oDr2[MobileOrderReport.Para.report_type]).Trim()))
                    wr("Suspension");
                else if ("rwl_fast".Equals(Func.FR(_oDr2[MobileOrderReport.Para.report_type]).Trim()))
                    wr("Early Start");
                else if ("rwl".Equals(Func.FR(_oDr2[MobileOrderReport.Para.report_type]).Trim()))
                    wr("New Order");
                else if ("rwl_mod".Equals(Func.FR(_oDr2[MobileOrderReport.Para.report_type]).Trim()))
                    wr("Modification");
                else if ("rwl_NDS".Equals(Func.FR(_oDr2[MobileOrderReport.Para.report_type]).Trim()))
                    wr("New NDS Order");
                else if ("rwl_wo_hs".Equals(Func.FR(_oDr2[MobileOrderReport.Para.report_type]).Trim()))
                    wr("New non-HS Order");
                else if ("rwl_w_hs".Equals(Func.FR(_oDr2[MobileOrderReport.Para.report_type]).Trim()))
                    wr("New HS Order");
                else if ("rwl_del".Equals(Func.FR(_oDr2[MobileOrderReport.Para.report_type]).Trim()))
                    wr("Cancellation");
                else if ("rwl_vas".Equals(Func.FR(_oDr2[MobileOrderReport.Para.report_type]).Trim()))
                    wr("Change VAS");
                else
                    wr(Func.FR(_oDr2[MobileOrderReport.Para.report_type]).Trim());

                wr("<br>");
                wr("Status: " + Func.FR(_oDr2[MobileOrderReport.Para.order_status]).Trim() + " <br>");
                wr("Reason: " + Func.FR(_oDr2[MobileOrderReport.Para.fallout_reason]).Trim() + "<br>");
                wr("Remark: " + Func.FR(_oDr2[MobileOrderReport.Para.fallout_remark]).Trim() + "<br />");
                wr("Reply: " + Func.FR(_oDr2[MobileOrderReport.Para.fallout_reply]).Trim() + "<br>");
                wr("Last Update Date: " + Func.FR(_oDr2[MobileOrderReport.Para.cdate]).Trim() + "<br>");
            }

            if ("65535".Equals(RWLFramework.CurrentUser[this.Page].Lv)
                ||
                ("A3150498".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                || "310540".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                 || "1003052".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                || "1003052".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                || "1046317".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                || "80217243".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                || "1061498".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                || "80131600".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                || "A3310038".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                || "1074418".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                || "431270".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                || "A9320054".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                || "A8350006".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                || "80173792".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                || "80134455".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                || "80241334".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                || "935817".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                || "A9280001".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                || "A3290006".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                || "655357".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                || "452599".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                || "A1010061".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                || "80173792".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                || "314187".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                || "400895".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                || "A3280062".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                || "A4300029".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                || "A2300030".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                || "A2180025".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A4180011".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A8180027".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A8180043".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A8180055".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "1250497".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "1250505".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A2320059".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A4320048".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A9320096".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A2180025".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A4180011".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A8180027".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A8180043".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A8180055".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "1250497".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "1250505".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "1222090".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "1106186".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "454157".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "1079763".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "442434".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "797407".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A3150515".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "1222090".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "1106186".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "1003052".Equals(RWLFramework.CurrentUser[this.Page].Uid) 
                    || "1268507".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "1250497".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A2180025".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A4180011".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A8180055".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A9180015 ".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A0150009".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "80116718".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "80076680".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A3370030".Equals(RWLFramework.CurrentUser[this.Page].Uid) 
                    || "1020874".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                )
                &&
                _oSalesmancodeList.Contains(Func.FR(_oDr[ProfileTeamDetail.Para.salesmancode]).ToUpper().Trim())
                )
            {
                wr("<br />");
                wr("<br />");
                wr("********For Project Owner Only********<br />");
                wr("<input type=\"button\" name=\"submit2\" value=\"Modify Order without checking\" class=\"mainoption\" onClick=\"location.href='PreviousOrderModifyNoCheck.aspx?order_id=" + Convert.ToInt32(WebFunc.qsOrder_id).ToString() + "';this.disabled=false\"/>");
                wr("<input type=\"button\" name=\"submit1\" value=\"Cancel Order\" class=\"mainoption\" onClick=\"if(confirm('Are you sure you want to delete this order?')){location.href='OrderDeleteImplement.aspx?order_id=" + Convert.ToInt32(WebFunc.qsOrder_id).ToString() + "';this.disabled=false;}\" />");

                if (_bReportTypeHasRow && Func.RQ(Request["pass"]).ToString() != "pass" &&
                    (_oDr2["sent_again"] == null || Func.FR(_oDr2["sent_again"]) == "0" || Func.FR(_oDr2["sent_again"]).ToUpper() == "FALSE" || Func.FR(_oDr2["sent_again"]) == string.Empty) && 
                    (_oDr2["retrieve_date"] != null && Func.FR(_oDr2["retrieve_date"]) != string.Empty) && 
                    ("A8350006".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "1022243".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A3150498".Equals(RWLFramework.CurrentUser[this.Page].Uid) 
                    || "310540".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                     || "1003052".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "1003052".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "1046317".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "80217243".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "1061498".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "80131600".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A3310038".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "1074418".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "431270".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A9320054".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A8350006".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "80173792".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "80134455".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "80241334".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "935817".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A9280001".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A3290006".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "655357".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "452599".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A1010061".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "314187".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A3280062".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A2180025".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A4180011".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A8180027".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A8180043".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A8180055".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "1250497".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "1250505".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A2320059".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A4320048".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A9320096".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A2180025".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A4180011".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A8180027".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A8180043".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A8180055".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "1250497".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "1250505".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "1222090".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "1106186".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "454157".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "1079763".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "442434".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                     || "797407".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                     || "A3150515".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                     || "1222090".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "1106186".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "1003052".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "1268507".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "1250497".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A2180025".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A4180011".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A8180055".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A9180015 ".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "A0150009".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || "80116718".Equals(RWLFramework.CurrentUser[this.Page].Uid) 
                    || "80076680".Equals(RWLFramework.CurrentUser[this.Page].Uid) 
                    || "A3370030".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                     || "1020874".Equals(RWLFramework.CurrentUser[this.Page].Uid)
                    || SpecialModifyID()
                    ))
                {
                    wr("<input type=\"button\" name=\"submit14\" value=\"Send  Report To PY Again\" class=\"mainoption\" onClick=\"location.href='SendToPYReport.aspx?order_id=" + Convert.ToInt32(WebFunc.qsOrder_id).ToString() + "';this.disabled=false\" />");
                }
                wr("</span>");
            }
            _oDr2.Close();
            _oDr2.Dispose();
        }


        wr("</td>");
        wr("</tr>");
        if (_oDr != null) _oDr.Close(); _oDr.Dispose();
        if (Func.IDSubtract100000(WebFunc.qsOrder_id) != null)
        {
            RWLviewrow1.Visible = true;
            if (WebFunc.qsOrder_id != null)
            {
                RWLviewrow1.SetOrderid(Convert.ToInt32(Func.IDSubtract100000(WebFunc.qsOrder_id)));
            }
            RWLviewrow1.LoadOrder();
        }
    }

    public bool ModifyFlagInit()
    {
        try
        {
            int _iCon_flag = 1;
            int _iDeli_flag = 1;
            string _sQuery = "SELECT TOP 1 datediff(d,getdate(),d_date) AS date_diff,datediff(d,getdate(),con_eff_date) AS con_diff,* FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder WITH (nolock) WHERE order_id='" + Func.IDSubtract100000(WebFunc.qsOrder_id) + "'";
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
            if (_oDr.Read())
            {
                if (!Func.FR(_oDr["con_diff"]).Equals(string.Empty))
                {
                    if (Func.IsParseInt(_oDr["con_diff"].ToString()))
                    {
                        if (Convert.ToInt32(_oDr["con_diff"].ToString()) < 3)
                            _iCon_flag = 0;
                    }
                }

                if (!Func.FR(_oDr["edf_no"]).Equals(string.Empty))
                {
                    int _iDateDiff;
                    if (int.TryParse(Func.FR(_oDr["date_diff"]), out _iDateDiff))
                    {
                        if ((_iDateDiff > -2 && _iDateDiff < 1) || (_iDateDiff == 1 && DateTime.Now.Hour >= 15))
                            _iDeli_flag = 0;

                        SqlDataReader _oPDr = SYSConn<MSSQLConnect>.Connect("CSSDB").GetSearch("SELECT TOP 1 p_date FROM [CSSDB].[dbo].pccwmsns_holiday with (nolock) WHERE active=1 AND p_date=getdate()");
                        if (_oPDr.Read()) { _iDeli_flag = 0; }
                        _oPDr.Close();
                        _oPDr.Dispose();

                        if (DateTime.Now.DayOfWeek.ToString().ToUpper().Equals("SUNDAY"))
                            _iDeli_flag = 0;

                        /*
                        SqlDataReader _oPDr2 = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT TOP 1 d_date FROM MobileRetentionOrder o  WHERE o.order_id='220504' AND datediff(d,o.d_date,getdate())>0 AND datediff(d,o.d_date,getdate()) IN (SELECT count(*) FROM [CSSDB].[dbo]." + ((Configurator.IsUat()) ? "uat_" : string.Empty) + "pccwmsns_holiday WHERE p_date>o.d_date AND p_date<getdate())");
                        if (_oPDr2.Read()) { _iDeli_flag = 0; }
                        _oPDr2.Close();
                        _oPDr2.Dispose();
                        */
                        string _sOrder_id = Func.IDSubtract100000(WebFunc.qsOrder_id);
                        if (_sOrder_id != string.Empty)
                        {
                            StringBuilder _oHQuery = new StringBuilder();
                            _oHQuery.Append("SELECT TOP 1 o.d_date,datediff(d,o.d_date,getdate()) FROM MobileRetentionOrder o ");
                            _oHQuery.Append(" inner join ");
                            _oHQuery.Append(" (SELECT top 1 p_date FROM [CSSDB].[dbo].pccwmsns_holiday WHERE p_date<getdate() order by p_date desc) b ");
                            _oHQuery.Append(" on  b.p_date is not null and datediff(d,b.p_date,getdate())>=2 ");
                            _oHQuery.Append(" WHERE o.order_id='" + _sOrder_id + "' AND datediff(d,getdate(),o.d_date)>1 ");

                            SqlDataReader _oPDr2 = SYSConn<MSSQLConnect>.Connect().GetSearch(_oHQuery.ToString());
                            if (!_oPDr2.Read())
                            {
                                StringBuilder _oHQuery2 = new StringBuilder();
                                _oHQuery2.Append("SELECT TOP 1 o.d_date,datediff(d,o.d_date,getdate()) FROM MobileRetentionOrder o ");
                                _oHQuery2.Append(" inner join ");
                                _oHQuery2.Append(" (SELECT top 1 p_date FROM [CSSDB].[dbo].pccwmsns_holiday WHERE p_date<getdate() order by p_date desc) b ");
                                _oHQuery2.Append(" on  b.p_date is not null and datediff(d,b.p_date,getdate())>=2 ");
                                _oHQuery2.Append(" WHERE o.order_id='" + _sOrder_id + "' AND datediff(d,o.d_date,getdate())>1 ");
                                SqlDataReader _oPDr3 = SYSConn<MSSQLConnect>.Connect().GetSearch(_oHQuery2.ToString());
                                if (!_oPDr3.Read())
                                {
                                    _iDeli_flag = 0;
                                }
                                _oPDr3.Close();
                                _oPDr3.Dispose();
                            }


                            _oPDr2.Close();
                            _oPDr2.Dispose();
                        }

                        OdbcDataReader _oODr = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT referenceNO FROM SUNDAY_Form Where referenceNO='" + Func.FR(_oDr["edf_no"]) + "' AND cancelled='Y'");
                        if (_oODr.Read()) { _iDeli_flag = 0; }
                        _oODr.Close();
                        _oODr.Dispose();

                        OdbcDataReader _oODr2 = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT referenceNO FROM SUNDAY_Form Where referenceNO='" + Func.FR(_oDr["edf_no"]) + "' AND  (actual_del_date IS NULL OR actual_del_date='')");
                        if (!_oODr2.Read()) { _iDeli_flag = 0; }
                        _oODr2.Close();
                        _oODr2.Dispose();
                    }
                }

                string _sQuery2 = "SELECT order_status FROM " + Configurator.MSSQLTablePrefix + "MobileOrderReport WITH (nolock) WHERE order_id='" + Func.IDSubtract100000(WebFunc.qsOrder_id) + "' AND active=1 ";
                SqlDataReader _oDr2 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery2);
                if (_oDr2.Read())
                {
                    _iCon_flag = 0;
                }
                _oDr2.Close();
                _oDr2.Dispose();
                string _sQuery3 = "SELECT top 1 * FROM " + Configurator.MSSQLTablePrefix + "MobileOrderReport where active=1 and order_status='FALLOUT' and order_id='" + Func.IDSubtract100000(WebFunc.qsOrder_id) + "'";
                SqlDataReader _oDr3 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery3);
                if (_oDr3.Read())
                {
                    _iDeli_flag = 1;
                    _iCon_flag = 1;
                }
                _oDr3.Close();
                _oDr3.Dispose();
            }
            _oDr.Close();
            _oDr.Dispose();


            //=== If status=FALLOUT REPILED -> cannot modify ===
            _oDr = MobileOrderReportBal.GetSearch(SYSConn<MSSQLConnect>.Connect(), "TOP 1 * ", "active=1 and order_status='FALLOUT REPLIED' and order_id='" + Func.IDSubtract100000(WebFunc.qsOrder_id) + "'", null, " mid desc, email_date desc");
            if (_oDr.Read())
            {
                _iDeli_flag = 0;
                _iCon_flag = 0;
            }
            _oDr.Close();
            _oDr.Dispose();

            if (_iCon_flag == 1 || _iDeli_flag == 1)
                return true;
            else
                return false;
        }
        catch (Exception exp)
        {

        }
        return false;
    }
    public bool SpecialModifyID()
    {
        if (
            "844415".Equals(RWLFramework.CurrentUser[this.Page].Uid) ||
            "1051770".Equals(RWLFramework.CurrentUser[this.Page].Uid)
            )
        {
            return true;
        }
        return false;
    }

    public bool CheckRetrieved()
    {
        SqlDataReader _oDr = MobileOrderReportBal.GetSearch(SYSConn<MSSQLConnect>.Connect(), "TOP 1 * ", "active=1 and retrieve_date is not null and order_id='" + Func.IDSubtract100000(WebFunc.qsOrder_id) + "'", null, null);
        if (_oDr.Read())
        {
            _oDr.Close();
            _oDr.Dispose();
            return true;
        }
        _oDr.Close();
        _oDr.Dispose();
        return false;
    }


    #endregion

    public void wr(params string[] x_sObj)
    {
        for (int i = 0; i < x_sObj.Length; i++)
            if (!string.IsNullOrEmpty(x_sObj[i])) { rwl_view_placeholder.Controls.Add(new LiteralControl(x_sObj[i])); }
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

    #region Get Oracle DB
    protected ODBCConnect GetORDB()
    {
        ODBCConnect _oDB = new ODBCConnect();
        _oDB.SetConnStr(Configurator.DBName.ORADNS + ((Configurator.IsUat()) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion

    #region Run Javascript Function
    public void RunJavascriptFunc(string x_sFunc)
    {
        string _sFunc = ((x_sFunc.IndexOf(';') > 0) ? x_sFunc : x_sFunc + ";");
        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sFunc + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), string.Format("<script>{0}</script>", _sFunc), false);
    }
    #endregion
}
