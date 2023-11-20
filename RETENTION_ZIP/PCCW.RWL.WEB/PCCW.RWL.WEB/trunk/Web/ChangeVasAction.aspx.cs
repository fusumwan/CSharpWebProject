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



public partial class ChangeVasAction : NEURON.WEB.UI.BasePage
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
        if(!IsPostBack) InitFrame();
    }

    #region InitFrame
    public void InitFrame()
    {
        int? _iOrderID = null;
        if (WebFunc.qsOrder_id != null)
        {
            if (Func.IsParseInt(Func.IDSubtract100000(WebFunc.qsOrder_id).ToString()))
            {
                _iOrderID=Convert.ToInt32(Func.IDSubtract100000(WebFunc.qsOrder_id));
                MobileRetentionOrder _oMobileRetentionOrder = (MobileRetentionOrder)MobileRetentionOrderRepository.CreateEntityInstanceObject();
                _oMobileRetentionOrder.SetOrder_id(Convert.ToInt32(Func.IDSubtract100000(WebFunc.qsOrder_id)));
                if (!_oMobileRetentionOrder.Retrieve()) return;
                if (_oMobileRetentionOrder.GetFound())
                {
                    MobileRetentionOrderBal.BackUpOrder((int)WebFunc.qsOrder_id, string.Empty);
                    using (ISession<MSSQLConnect> _oSession = (new SessionFactory<MSSQLConnect>()).OpenSession())
                    using (ITransaction _oTransaction = _oSession.BeginTransaction())
                    {
                        _oMobileRetentionOrder.SetCid(RWLFramework.CurrentUser[this.Page].Uid);
                        _oMobileRetentionOrder.SetEdate(DateTime.Now);
                        _oSession.Update(_oMobileRetentionOrder);
                        SqlDataReader _oReader = BusinessVasBal.GetSearch(SYSConn<MSSQLConnect>.Connect(), "distinct vas_field , multi", "active=1", null, null);
                        if (_oReader != null){
                            while (_oReader.Read()){
                                if (Request[_oReader[BusinessVas.Para.vas_field].ToString()] != null && Request[_oReader[BusinessVas.Para.vas_field].ToString()] != "NO")
                                {
                                    if ((true).Equals(Convert.ToBoolean(_oReader[BusinessVas.Para.multi].ToString())) && Request[_oReader[BusinessVas.Para.vas_field].ToString() + "1"] != null)
                                    {
                                        string _sVasField1 = Request[_oReader[BusinessVas.Para.vas_field].ToString() + "1"].ToString();
                                        MobileRetentionOrderBal.SaveVas(ref _oMobileRetentionOrder, _oReader[BusinessVas.Para.vas_field].ToString(), Request[_oReader[BusinessVas.Para.vas_field].ToString()].ToString(), _sVasField1, true);
                                    }
                                    else
                                        MobileRetentionOrderBal.SaveVas(ref _oMobileRetentionOrder, _oReader[BusinessVas.Para.vas_field].ToString(), Request[_oReader[BusinessVas.Para.vas_field].ToString()].ToString(), string.Empty, false);
                                }
                                else if (Request[_oReader[BusinessVas.Para.vas_field].ToString()] == "NO" || Request[_oReader[BusinessVas.Para.vas_field].ToString()]==string.Empty)
                                {
                                    MobileRetentionOrderBal.DeleteVas(ref _oMobileRetentionOrder, _oReader[BusinessVas.Para.vas_field].ToString());
                                }
                            }
                            _oReader.Close();
                            _oReader.Dispose();
                        }
                        _oTransaction.Commit();
                    }

                    SqlDataReader _oDr = MobileRetentionOrderBal.GetSearch(GetDB(), "top 1 * ", " order_id='" + ((WebFunc.qsOrder_id != null) ? Func.IDSubtract100000(WebFunc.qsOrder_id).ToString() : string.Empty) + "'", null, null);
                    bool _bDr = _oDr.Read();
                    if (_oDr.HasRows)
                    {
                        mrt_no.Text = Func.FR(_oDr[MobileRetentionOrder.Para.mrt_no]).Trim();
                        program.Text = Func.FR(_oDr[MobileRetentionOrder.Para.program]).Trim();
                        rate_plan.Text = Func.FR(_oDr[MobileRetentionOrder.Para.rate_plan]).Trim();
                        normal_rebate_type.Text = Func.FR(_oDr[MobileRetentionOrder.Para.normal_rebate_type]).Trim();
                        con_per.Text = Func.FR(_oDr[MobileRetentionOrder.Para.con_per]).Trim();
                        rebate.Text = Func.FR(_oDr[MobileRetentionOrder.Para.rebate]).Trim();
                        free_mon.Text = Func.FR(_oDr[MobileRetentionOrder.Para.free_mon]).Trim();
                    }
                    SqlDataReader _oDr2 = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT TOP 1 mrt_no,program,rate_plan,normal_rebate_type,con_per,rebate,free_mon FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionPreviousOrder with (nolock) WHERE rec_no='" + ((WebFunc.qsOrder_id != null) ? Func.IDSubtract100000(WebFunc.qsOrder_id).ToString() : string.Empty) + "' ORDER BY ddate DESC");
                    bool _bDr2 = _oDr2.Read();

                    int _iAdded = 0;
                    if (WebFunc.qsActive.Equals("reply") && !Func.RQ(Request["fo_reply"]).Equals(string.Empty))
                    {
                        StringBuilder _sQuery3 = new StringBuilder();
                        _sQuery3.Append("insert into " + Configurator.MSSQLTablePrefix + "MobileOrderReportHistory(rec_no,order_id,email_date,report_type,order_status,fallout_reason,fallout_reply,fallout_remark,retrieve_sn,retrieve_date,active,cid,cdate,did,ddate,sent_again ) ");
                        _sQuery3.Append(" select mid,order_id,email_date,report_type,order_status,fallout_reason,fallout_reply,fallout_remark,retrieve_sn,retrieve_date,active,cid,cdate,'" + RWLFramework.CurrentUser[this.Page].Uid + "',getdate(),sent_again from " + Configurator.MSSQLTablePrefix + "MobileOrderReport ");
                        _sQuery3.Append(" where order_id='" + ((WebFunc.qsOrder_id != null) ? Func.IDSubtract100000(WebFunc.qsOrder_id).ToString() : string.Empty) + "' and order_status='FALLOUT' and active=1");
                        MobileOrderReportBal.UpdateOrderStatus("FALLOUT REPLIED", DateTime.Now, null, RWLFramework.CurrentUser[this.Page].Uid, null, Func.FR(WebFunc.qsFallout_reply), WebFunc.qsOrder_id);
                    }
                    else
                    {
                        if (_oDr.HasRows && _oDr2.HasRows)
                        {
                            for (int i = 0; i < _oDr2.FieldCount - 1; i++)
                            {
                                if (!_oDr[_oDr2.GetName(i)].ToString().Equals(_oDr2[_oDr2.GetName(i)].ToString()) && _iAdded == 0)
                                {
                                    _iAdded += 1;
                                    if ("reply".Equals(WebFunc.qsAction))
                                    {
                                        StringBuilder _sQuery4 = new StringBuilder();
                                        _sQuery4.Append("INSERT INTO " + Configurator.MSSQLTablePrefix + "MobileOrderReportHistory(rec_no,order_id,email_date,report_type,order_status,fallout_reason,fallout_reply,fallout_remark,retrieve_sn,retrieve_date,active,cid,cdate,did,ddate,sent_again ) ");
                                        _sQuery4.Append(" SELECT mid,order_id,email_date,report_type,order_status,fallout_reason,fallout_reply,fallout_remark,retrieve_sn,retrieve_date,active,cid,cdate,'" + RWLFramework.CurrentUser[this.Page].Uid + "',getdate(),sent_again  from " + Configurator.MSSQLTablePrefix + "MobileOrderReport ");
                                        _sQuery4.Append("order_id='" + ((WebFunc.qsOrder_id != null) ? Func.IDSubtract100000(WebFunc.qsOrder_id).ToString() : string.Empty) + "' and order_status='FALLOUT' and active=1");
                                        SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_sQuery4.ToString());
                                        MobileOrderReportBal.UpdateOrderStatus("FALLOUT REPLIED", DateTime.Now, null, RWLFramework.CurrentUser[this.Page].Uid, null, Func.FR(WebFunc.qsFallout_reply), WebFunc.qsOrder_id);
                                    }
                                    else
                                    {
                                        MobileOrderReport _oMobileOrderReport = new MobileOrderReport();
                                        _oMobileOrderReport.SetOrder_id(_iOrderID);
                                        _oMobileOrderReport.SetEmail_date(DateTime.Now);
                                        _oMobileOrderReport.SetReport_type("rwl_vas");
                                        _oMobileOrderReport.SetActive(true);
                                        MobileOrderReportBal.InsertWithOutLastID(GetDB(), _oMobileOrderReport);
                                    }
                                }
                            }
                        }
                    }
                    _oDr.Close();
                    _oDr.Dispose();
                    _oDr2.Close();
                    _oDr2.Dispose();
                }
            }
        }

        if (WebFunc.qsOrder_id != null){
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("SELECT c.vas_desc as vas_desc, c.fee as fee, a.vas_field as vas_field, a.vas_value as vas_value ,b.multi as multi, b.vas_name as vas_name, b.vas_chi_name as vas_chi_name  ");
            _oQuery.Append("FROM " + Configurator.MSSQLTablePrefix + "MobileOrderVas a INNER JOIN " + Configurator.MSSQLTablePrefix + "BusinessVas b ON a.vas_id=b.id ");
            _oQuery.Append("LEFT JOIN " + Configurator.MSSQLTablePrefix + "BusinessVasDescription c ON (a.multi_id=c.id and a.multi_id is not null and a.multi_id!='') ");
            _oQuery.Append("WHERE a.order_id = '" + Func.IDSubtract100000(WebFunc.qsOrder_id).ToString() + "' and a.active=1");
            SqlDataReader _oDr3 = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
            while (_oDr3.Read()){
                wr("<tr>");
                wr("<td height=\"28\"  class=\"row2\"><span class=\"explaintitle\" style=\"font-size:7pt\">");
                wr(Func.FR(_oDr3[BusinessVas.Para.vas_name]) + " " + Func.FR(_oDr3[BusinessVas.Para.vas_chi_name]));
                wr("</span></td>");
                wr("<td height=\"28\" class=\"row1\" colspan=\"3\"><span class=\"gensmall\" >");
                bool _bMulti = false;
                if (Func.IsParseBool(Func.FR(_oDr3[BusinessVas.Para.multi])))
                    if (Convert.ToBoolean(Func.FR(_oDr3[BusinessVas.Para.multi]).Trim())) _bMulti = true;

                string _sVas_value = string.Empty;
                string _sVas_desc = string.Empty;
                if (_bMulti){
                    if (!"".Equals(Func.FR(_oDr3[BusinessVas.Para.vas_value])))
                    {
                        _sVas_value = Func.FR(_oDr3[BusinessVas.Para.vas_value]).Trim();
                        _sVas_desc = Func.FR(_oDr3[BusinessVasDescription.Para.vas_desc]).Trim();
                    }
                }
                else{
                    _sVas_value = Func.FR(_oDr3[BusinessVas.Para.vas_value]);
                    _sVas_desc = string.Empty;
                }
                wr(_sVas_value + " " + _sVas_desc);
                wr("</span></td>");
                wr("</tr>");
            }
            _oDr3.Close();
            _oDr3.Dispose();
        }
    }
    #endregion

    public void wr(params string[] x_sObj)
    {
        for (int i = 0; i < x_sObj.Length; i++)
            if (!string.IsNullOrEmpty(x_sObj[i])) { vas_placeholder.Controls.Add(new LiteralControl(x_sObj[i])); }
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
        _oDB.SetConnStr(Configurator.DBName.ORADNS+((Configurator.IsUat()) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion
}
