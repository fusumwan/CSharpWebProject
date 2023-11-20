using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Odbc;
using System.Globalization;
using System.Text;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;
public partial class Web_IncompleteDeliveryDateReport : System.Web.UI.Page
{
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

    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion

    [Serializable]
    public class InCompleteDeliveryOrder
    {
        protected string n_sRecordId = string.Empty;
        [DataObjectField(true)]
        public string RecordId
        {
            get
            {
                return this.n_sRecordId;
            }
            set
            {
                this.n_sRecordId = value;
            }
        }

        protected string n_sCancelled = string.Empty;
        [DataObjectField(true)]
        public string Cancelled
        {
            get
            {
                return this.n_sCancelled;
            }
            set
            {
                this.n_sCancelled = value;
            }
        }

        protected string n_sReferenceno = string.Empty;
        [DataObjectField(true)]
        public string Referenceno
        {
            get
            {
                return this.n_sReferenceno;
            }
            set
            {
                this.n_sReferenceno = value;
            }
        }
        protected string n_sOrderid = string.Empty;
        [DataObjectField(true)]
        public string Orderid
        {
            get
            {
                return this.n_sOrderid;
            }
            set
            {
                this.n_sOrderid = value;
            }
        }

        protected string n_sMrt_no = string.Empty;
        [DataObjectField(true)]
        public string Mrt_no
        {
            get
            {
                return this.n_sMrt_no;
            }
            set
            {
                this.n_sMrt_no = value;
            }
        }

        protected string n_sSku = string.Empty;
        [DataObjectField(true)]
        public string Sku
        {
            get
            {
                return this.n_sSku;
            }
            set
            {
                this.n_sSku = value;
            }
        }

        protected string n_sHs_model = string.Empty;
        [DataObjectField(true)]
        public string Hs_model
        {
            get
            {
                return this.n_sHs_model;
            }
            set
            {
                this.n_sHs_model = value;
            }
        }

        protected string n_sPay_method = string.Empty;
        [DataObjectField(true)]
        public string Pay_method
        {
            get
            {
                return this.n_sPay_method;
            }
            set
            {
                this.n_sPay_method = value;
            }
        }

        protected string n_sStaff_no = string.Empty;
        [DataObjectField(true)]
        public string Staff_no
        {
            get
            {
                return this.n_sSku;
            }
            set
            {
                this.n_sSku = value;
            }
        }

        protected string n_sSalesmancode = string.Empty;
        [DataObjectField(true)]
        public string Salesmancode
        {
            get
            {
                return this.n_sSalesmancode;
            }
            set
            {
                this.n_sSalesmancode = value;
            }
        }
        protected string n_sChannel = string.Empty;
        [DataObjectField(true)]
        public string Channel
        {
            get
            {
                return this.n_sChannel;
            }
            set
            {
                this.n_sChannel = value;
            }
        }

        protected DateTime? n_dD_date = null;
        [DataObjectField(true)]
        public DateTime? D_date
        {
            get
            {
                return this.n_dD_date;
            }
            set
            {
                this.n_dD_date = value;
            }
        }

        protected Double? n_dPassDate = null;
        [DataObjectField(true)]
        public Double? PassDate
        {
            get
            {
                return this.n_dPassDate;
            }
            set
            {
                this.n_dPassDate = value;
            }
        }
    }


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
        RWLFramework.DataBaseConfigSetting();
        RWLFramework.InitModel();
        RWLFramework.CurrentUser[this.Page].SetUid(n_sSessionUid);
        RWLFramework.CurrentUser[this.Page].SetLv(n_sSessionLv);
        RWLFramework.CurrentUser[this.Page].SetArprog(n_sSessionArprog);
        RWLFramework.CurrentUser[this.Page].SetChannel(n_sSessionChannel);
        if (!IsPostBack)
        {
            BindData();
        }
    }

    #region BindData
    public void BindData()
    {
        string _sOrderList = string.Empty;
        SaleManCodeProfile _oSaleManCodeProfile = new SaleManCodeProfile();
        List<InCompleteDeliveryOrder> _oInCompleteDeliveryOrderArr = new List<InCompleteDeliveryOrder>();
        Hashtable _oEDFInCompleteDeliveryOrderList = new Hashtable();
        OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT referenceNo,cancelled,Agree_no FROM SUNDAY_Form WHERE (actual_del_date IS NULL OR actual_del_date = '') AND (TO_DATE(E_Delivery_Date,'DD/MM/YYYY') BETWEEN '06-JUN-2009' AND (sysdate-2)) AND created_by='CC RET' AND cancelled<>'Y' AND E_Delivery_Date IS NOT NULL AND e_delivery_date <> '//'  ORDER BY cancelled");
        while (_oDr.Read())
        {
            long _lOrderid;
            if (long.TryParse(Func.FR(_oDr["Agree_no"]), out _lOrderid))
            {
                InCompleteDeliveryOrder _oInCompleteDeliveryOrder = new InCompleteDeliveryOrder();
                _oInCompleteDeliveryOrder.Cancelled = Func.FR(_oDr["cancelled"]).ToString();
                _oInCompleteDeliveryOrder.Orderid = Func.IDSubtract100000((int)_lOrderid).ToString();
                _oInCompleteDeliveryOrder.RecordId = _lOrderid.ToString();
                _oInCompleteDeliveryOrder.Referenceno = Func.FR(_oDr["referenceNo"]).ToString();
                if (!_oEDFInCompleteDeliveryOrderList.ContainsKey(_oInCompleteDeliveryOrder.Orderid.ToString()))
                {
                    if (!_sOrderList.Equals(string.Empty)) { _sOrderList += ","; }
                    _sOrderList += "'" + _oInCompleteDeliveryOrder.Orderid.ToString() + "'";
                    _oEDFInCompleteDeliveryOrderList.Add(_oInCompleteDeliveryOrder.Orderid, _oInCompleteDeliveryOrder);
                }
            }
        }
        _oDr.Close();
        _oDr.Dispose();

        if (!_sOrderList.Equals(string.Empty))
        {
            StringBuilder _oQuery = new StringBuilder();
            _oSaleManCodeProfile.SetUid(RWLFramework.CurrentUser[this.Page].Uid);
            _oSaleManCodeProfile.SetLv(RWLFramework.CurrentUser[this.Page].Lv);
            string _sSalesManCodeList = Func.ExplodeList(_oSaleManCodeProfile.Get_SalemanCodeList(), ",", true);
            _oQuery.Append(" SELECT ");
            _oQuery.Append(" a.order_id, ");
            _oQuery.Append(" a.mrt_no, ");
            _oQuery.Append(" a.edf_no, ");
            _oQuery.Append(" a.sku, ");
            _oQuery.Append(" a.hs_model, ");
            _oQuery.Append(" a.pay_method, ");
            _oQuery.Append(" a.staff_no, ");
            _oQuery.Append(" a.salesmancode, ");
            _oQuery.Append(" a.channel,  ");
            _oQuery.Append(" a.d_date ");
            _oQuery.Append("  FROM dbo.MobileRetentionOrder a with (nolock), dbo.MobileOrderReport b with (nolock) WHERE a.d_date IS NOT NULL AND a.order_id=b.order_id AND a.active=1 AND b.active=1 AND a.order_id IN (" + _sOrderList + ") AND a.hs_model IS NOT NULL AND a.hs_model <>'' AND b.report_type <> 'rwl_del' AND b.order_status <> 'FALLOUT' AND b.order_status <> 'FALLOUT REPLIED' AND a.imei_no <> 'AO' AND a.imei_no <> 'AWAIT'");
            if (!RWLFramework.CurrentUser[this.Page].Lv.Equals("65535"))
            {
                if (RWLFramework.CurrentUser[this.Page].Lv.Equals("10") || RWLFramework.CurrentUser[this.Page].Lv.Equals("4"))
                {
                    if (!string.IsNullOrEmpty(_sSalesManCodeList))
                        _oQuery.Append(" AND a.salesmancode IN (" + _sSalesManCodeList + ") ");
                }
                else
                    _oQuery.Append(" AND a.staff_no='" + RWLFramework.CurrentUser[this.Page].Uid + "'");
            }



            SqlDataReader _oDr2 = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
            while (_oDr2.Read())
            {
                string _sOrderId = Func.FR(_oDr2["order_id"]);
                string _sMrt_no = Func.FR(_oDr2["mrt_no"]);
                string _sEdf_no = Func.FR(_oDr2["edf_no"]);
                string _sSku = Func.FR(_oDr2["sku"]);
                string _sHs_model = Func.FR(_oDr2["hs_model"]);
                string _sPay_method = Func.FR(_oDr2["pay_method"]);
                string _sStaff_no = Func.FR(_oDr2["staff_no"]);
                string _sSalesmancode = Func.FR(_oDr2["salesmancode"]);
                string _sChannel = Func.FR(_oDr2["channel"]);
                DateTime? _oD_date = (DateTime?)_oDr2["d_date"];
                if (_oEDFInCompleteDeliveryOrderList.ContainsKey(_sOrderId))
                {
                    InCompleteDeliveryOrder _oInCompleteDeliveryOrder = (InCompleteDeliveryOrder)_oEDFInCompleteDeliveryOrderList[_sOrderId];
                    if (_oD_date != null && _oInCompleteDeliveryOrder.Referenceno.ToUpper().Trim().Equals(_sEdf_no.ToUpper().Trim()) && _oInCompleteDeliveryOrder.Orderid.ToUpper().Trim().Equals(_sOrderId.ToUpper().Trim()))
                    {
                        _oInCompleteDeliveryOrder.Mrt_no = _sMrt_no;
                        _oInCompleteDeliveryOrder.Sku = _sSku;
                        _oInCompleteDeliveryOrder.Hs_model = _sHs_model;
                        _oInCompleteDeliveryOrder.Pay_method = _sPay_method;
                        _oInCompleteDeliveryOrder.Staff_no = _sStaff_no;
                        _oInCompleteDeliveryOrder.Salesmancode = _sSalesmancode;
                        _oInCompleteDeliveryOrder.Channel = _sChannel;
                        _oInCompleteDeliveryOrder.D_date = _oD_date;
                        _oInCompleteDeliveryOrder.PassDate = Math.Round((Double)Func.DateDiff("day", (DateTime)_oInCompleteDeliveryOrder.D_date, DateTime.Now), 0);
                        _oInCompleteDeliveryOrderArr.Add(_oInCompleteDeliveryOrder);
                    }
                }
            }
            _oDr2.Close();
            _oDr2.Dispose();
            SearchResultGw.DataSource = _oInCompleteDeliveryOrderArr;
        }
        SearchResultGw.DataBind();
    }
    #endregion

}
