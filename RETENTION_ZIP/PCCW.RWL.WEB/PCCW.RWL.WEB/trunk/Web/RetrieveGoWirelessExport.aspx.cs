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
using System.Text;
using System.Xml.Linq;
using System.Globalization;
using System.Data.Sql;
using System.Data.SqlClient;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;

public partial class Web_RetrieveGoWirelessExport : NEURON.WEB.UI.BasePage
{
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion


    protected void Page_Load(object sender, EventArgs e)
    {
        WebFunc.PrivilegeCheck(this.Page);
        if (!IsPostBack) InitFrame();
        WebFunc.ExportExcel(this.Page, "RetrieveGoWirelessExport.xls");
    }

    #region InitFrame
    protected void InitFrame()
    {


        VasControl _oVasControl = VasControl.Instance();
        _oVasControl.ReLoadDataToMemory();

        

        string _sRetrieve_id=string.Empty;
        if (Request["retrieve_id"] != null) { _sRetrieve_id = Request["retrieve_id"].ToString(); }
        if (!_sRetrieve_id.Equals(string.Empty))
        {
            /*
            StringBuilder _oInsertQuery = new StringBuilder();
            _oInsertQuery.Append("INSERT INTO " + Configurator.MSSQLTablePrefix + "MobileOrderReportHistory (rec_no,order_id,email_date,report_type,order_status,fallout_reason,fallout_reply,fallout_remark,retrieve_sn,retrieve_date,active,cid,cdate,did,ddate,reactive_sn,reactive_date ,gw_retrieve_sn,gw_retrieve_date) ");
            _oInsertQuery.Append(" SELECT mid,order_id,email_date,report_type,order_status,fallout_reason,fallout_reply,fallout_remark,retrieve_sn,retrieve_date,active,cid,cdate,'" + RWLFramework.CurrentUser[this.Page].Uid + "',getdate(),reactive_sn,reactive_date,gw_retrieve_sn,gw_retrieve_date  FROM " + Configurator.MSSQLTablePrefix + "MobileOrderReport ");
            _oInsertQuery.Append(" WHERE mid in (" + _sRetrieve_id + ")");
            */
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("SELECT a.*, b.mid , b.email_date, b.report_type, b.fallout_remark, b.fallout_reply, b.order_status, b.fallout_main_category , b.fallout_reason, b.retrieve_sn, b.retrieve_date, b.cid as admin_sn, b.cdate as admin_date from " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder a with (nolock), " + Configurator.MSSQLTablePrefix + "MobileOrderReport b with (nolock) where a.order_id=b.order_id and a.active=1 and b.active=1 and b.mid in (" + _sRetrieve_id + ")");
            _oQuery.Append(" and a.program<>'MOBILE LITE (SIM ONLY)' and a.program<>'MOBILE LITE (HS OFFER)'");

            /* Added on 16DEC2010 by Ben
* Normal Search: by D_date, Plan_eff_date
* Special PY Rule: D_date+1 if D_date is earlier, Plan_eff_date+3 if Plan_eff_date is earlier */

            _oQuery.Append(PYReportFunc.appendDDate_PlanEffDateToReportSQL((DateTime?)WebFunc.qsD_date, (DateTime?)WebFunc.qsD_date2, (DateTime?)WebFunc.qsPlan_eff_date, (DateTime?)WebFunc.qsPlan_eff_date2, (HttpContext.Current.Request["D_datePlan_eff_dateRule"] != null)));

            /* End */

            /* Added on 31DEC2010 by Ben
* For rwl_w_hs : amount>0 or amount=0 */

            string _sHandset_amount = (HttpContext.Current.Request["handset_amount"] == null ? "" : HttpContext.Current.Request["handset_amount"]);
            _oQuery.Append(PYReportFunc.appendHSAmountSQL(_sHandset_amount));

            /* End */

            SqlDataReader _oDr = GetDB().GetSearch(_oQuery.ToString());
            admin_view_rp.DataSource = _oDr;
            admin_view_rp.DataBind();

            if (_oDr != null)
            {
                _oDr.Close();
                _oDr.Dispose();
            }
            

        }

        if (!RWLFramework.CurrentUser[this.Page].Uid.Equals("A8350006") &&
            !RWLFramework.CurrentUser[this.Page].Uid.Equals("1022243"))
        {
            RecordRetrieve();
        }
    }
    #endregion

    #region RecordRetrieve
    protected void RecordRetrieve()
    {
        if (!WebFunc.qsRetrieve_id.Equals(string.Empty))
        {
            StringBuilder _oQuery1 = new StringBuilder();
            _oQuery1.Append("INSERT INTO " + Configurator.MSSQLTablePrefix + "MobileOrderReportHistory(rec_no,order_id,email_date,report_type,order_status,fallout_reason,fallout_reply,fallout_remark,retrieve_sn,retrieve_date,active,cid,cdate,did,ddate,idd_vas,ext_place_tel,reactive_sn,reactive_date) ");
            _oQuery1.Append("SELECT mid,order_id,email_date,report_type,order_status,fallout_reason,fallout_reply,fallout_remark,retrieve_sn,retrieve_date,active,cid,cdate,'" + RWLFramework.CurrentUser[this.Page].Uid.ToString() + "',getdate(),idd_vas,ext_place_tel ,reactive_sn,reactive_date  FROM " + Configurator.MSSQLTablePrefix + "MobileOrderReport ");
            _oQuery1.Append(" WHERE mid in (" + WebFunc.qsRetrieve_id.ToString() + ") ");
            SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_oQuery1.ToString());

            StringBuilder _oQuery2 = new StringBuilder();
            _oQuery2.Append("UPDATE " + Configurator.MSSQLTablePrefix + "MobileOrderReport SET retrieve_sn='" + RWLFramework.CurrentUser[this.Page].Uid.ToString() + "',retrieve_date=getdate() WHERE mid in (" + WebFunc.qsRetrieve_id.ToString() + ")");
            SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_oQuery2.ToString());
        }
    }
    #endregion

    protected void admin_view_rp_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (!e.Item.ItemIndex.Equals(-1))
        {
            int _iOrderID = e.Item.ItemIndex + 1;
            Literal _oViewid = (Literal)e.Item.FindControl("viewid");
            _oViewid.Text = _iOrderID.ToString();
        }
    }

    public string GetVasValue(object x_oVas, object x_oOrder_id)
    {
        if (x_oOrder_id == null) return string.Empty;
        if (x_oVas == null) return string.Empty;
        string x_sVas = x_oVas.ToString();
        int x_iOrder_id;
        if (int.TryParse(x_oOrder_id.ToString(), out x_iOrder_id))
            return VasControl.GetVasValue(x_iOrder_id, x_sVas);

        return string.Empty;
    }

    public string NextBill(object x_oValue)
    {
        bool _bValue;
        if (x_oValue == null) return string.Empty;
        if (bool.TryParse(x_oValue.ToString(), out _bValue))
        {
            if (_bValue) return "Next Bill Cut Date";
        }
        return string.Empty;
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
}
