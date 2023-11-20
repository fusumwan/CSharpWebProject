using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.Xml;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;

namespace PCCW.RWL.CORE
{
    public class MobileCsaOperationCenter
    {
        #region Get Sales Man List
        public global::System.Collections.Generic.List<string> Get_SalesManList()
        {
            return Get_SalesManList(n_sUid);
        }

        public global::System.Collections.Generic.List<string> Get_SalesManList(string x_sUid)
        {
            if (x_sUid == null) throw new ArgumentNullException("x_sUid");
            List<string> _oSalesmancodeList = new List<string>();
            SaleManCodeProfile _oSaleManCodeProfile = new SaleManCodeProfile();
            _oSaleManCodeProfile.SetUid(x_sUid);
            _oSalesmancodeList = _oSaleManCodeProfile.Get_SalemanCodeList();
            return _oSalesmancodeList;
        }
        #endregion

        #region Follow up By Sales
        public global::System.Data.SqlClient.SqlDataReader Get_FollowUp_Sales()
        {
            return Get_FollowUp_Sales(n_sLv, n_sUid, n_oSalemancodelist);
        }

        public global::System.Data.SqlClient.SqlDataReader Get_FollowUp_Sales(string x_sLv, string x_sUid, global::System.Collections.Generic.List<string> x_oSalesManList)
        {
            if (x_sUid == null) throw new ArgumentNullException("x_sUid");
            if (x_sLv == null) throw new ArgumentNullException("x_sLv");
            if (x_oSalesManList == null) throw new ArgumentNullException("x_oSalesManList");
            global::System.Text.StringBuilder _sQuery = new global::System.Text.StringBuilder();
            string _sSalesManList = Func.ExplodeList(x_oSalesManList, ",",true).Trim();

            _sQuery.Append("SELECT a.order_id, a.edf_no, a.mrt_no, a.salesmancode, a.staff_no, a.staff_name, a.con_eff_date, b.order_status, b.fallout_reason, b.fallout_remark, b.cdate as admin_date from MobileRetentionOrder a WITH (nolock), MobileOrderReport b WITH (nolock) WHERE a.order_id=b.order_id AND b.active=1 AND b.order_status='WAITING'");
            _sQuery.Append("AND a.order_id NOT IN (SELECT a.order_id FROM MobileRetentionOrder a WITH (nolock), MobileOrderReport b WITH (nolock) WHERE a.order_id=b.order_id AND b.active=1 AND b.order_status='DONE')");
            _sQuery.Append("AND a.order_id NOT IN (SELECT a.order_id FROM MobileRetentionOrder a WITH (nolock), MobileOrderReport b WITH (nolock) WHERE a.order_id=b.order_id AND b.active=1 AND b.report_type='rwl_del')");
            if (!"65535".Equals(x_sLv))
            {
                if ("10".Equals(x_sLv) || "4".Equals(x_sLv))
                {
                    if (_sSalesManList != string.Empty)
                        _sQuery.Append(" AND a.salesmancode IN  ( " + _sSalesManList + " )");
                    else
                        _sQuery.Append(" AND a.salesmancode =" + _sSalesManList + " ");
                }
                else
                    _sQuery.Append(" AND a.staff_no='" + x_sUid + "'");
            }
            _sQuery.Append(" AND a.active=1 ");
            _sQuery.Append(" ORDER BY a.order_id ");
            return SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery.ToString());
        }
        #endregion

        #region Get Follow up By F&S PY Mobile Operations
        public global::System.Data.SqlClient.SqlDataReader Get_FS_Mobile_Operations(){
            return Get_FS_Mobile_Operations(n_sLv, n_sUid, n_oSalemancodelist);
        }

        public global::System.Data.SqlClient.SqlDataReader Get_FS_Mobile_Operations(
            string x_sLv, string x_sUid, List<string> x_oSalesManList)
        {
            if (x_sLv == null) throw new ArgumentNullException("x_sLv");
            if (x_sUid == null) throw new ArgumentNullException("x_sUid");
            if (x_oSalesManList == null) throw new ArgumentNullException("x_sSalesManList");
            global::System.Text.StringBuilder _sQuery = new global::System.Text.StringBuilder();
            string _sSalesManList = Func.ExplodeList(x_oSalesManList, ",",true);
            //_sQuery.Append("SELECT a.order_id, a.edf_no, a.mrt_no, a.salesmancode, a.staff_no, a.staff_name, a.con_eff_date, b.order_status, b.fallout_reason, b.fallout_remark, b.cdate as admin_date FROM MobileRetentionOrder a WITH (nolock), MobileOrderReport b WITH (nolock) WHERE a.order_id=b.order_id AND b.active=1 AND b.order_status='FALLOUT' AND b.fallout_reason IN (SELECT fo_reason FROM MobileOrderFallout with (nolock) WHERE follow_by='SALES')");
            _sQuery.Append("SELECT a.order_id, a.edf_no, a.mrt_no, a.salesmancode, a.staff_no, a.staff_name, a.con_eff_date, b.order_status, b.fallout_reason, b.fallout_remark, b.cdate as admin_date FROM MobileRetentionOrder a WITH (nolock), MobileOrderReport b WITH (nolock) WHERE a.order_id=b.order_id AND b.active=1 AND b.order_status='FALLOUT' ");
            
            if (!"65535".Equals(x_sLv)){
                if (("10".Equals(x_sLv) || "4".Equals(x_sLv)) && !string.IsNullOrEmpty(_sSalesManList))
                    _sQuery.Append(" AND a.salesmancode IN  ( " + _sSalesManList + " )");
                else
                    _sQuery.Append(" AND a.staff_no='" + x_sUid + "'");
            }
            _sQuery.Append(" AND a.active=1");
            return SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery.ToString());
        }
        #endregion
        protected string n_sUid = string.Empty;
        #region m_sUid
        protected string m_sUid
        {
            get
            {
                return this.n_sUid;
            }
            set
            {
                this.n_sUid = value;
            }
        }
        #endregion m_sUid

        protected global::System.Collections.Generic.List<string> n_oSalemancodelist = new global::System.Collections.Generic.List<string>();
        #region m_oSalemancodelist
        protected global::System.Collections.Generic.List<string> m_oSalemancodelist
        {
            get
            {
                return this.n_oSalemancodelist;
            }
            set
            {
                this.n_oSalemancodelist = value;
            }
        }
        #endregion m_oSalemancodelist

        protected string n_sLv = string.Empty;
        #region m_sLv
        protected string m_sLv
        {
            get
            {
                return this.n_sLv;
            }
            set
            {
                this.n_sLv = value;
            }
        }
        #endregion m_sLv

        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Constructor & Destructor
        public MobileCsaOperationCenter() { }

        public MobileCsaOperationCenter(string x_sUid, global::System.Collections.Generic.List<string> x_oSalemancodelist, string x_sLv)
        {
            m_sUid = x_sUid;
            m_oSalemancodelist = x_oSalemancodelist;
            m_sLv = x_sLv;
        }

        ~MobileCsaOperationCenter() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public string GetUid() { return this.m_sUid; }
        public global::System.Collections.Generic.List<string> GetSalemancodelist() { return this.m_oSalemancodelist; }
        public string GetLv() { return this.m_sLv; }

        public bool SetUid(string value)
        {
            this.m_sUid = value;
            return true;
        }
        public bool SetSalemancodelist(List<string> value)
        {
            this.m_oSalemancodelist = value;
            return true;
        }
        public bool SetLv(string value)
        {
            this.m_sLv = value;
            return true;
        }
        #endregion
        
        #region Get DB
        protected static MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            _oDB.bWithNoLock = true;
            return _oDB;
        }
        #endregion

        #region Equals
        public bool Equals(MobileCsaOperationCenter x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.m_sUid.Equals(x_oObj.m_sUid)) { return false; }
            if (!this.m_oSalemancodelist.Equals(x_oObj.m_oSalemancodelist)) { return false; }
            if (!this.m_sLv.Equals(x_oObj.m_sLv)) { return false; }
            return true;
        }
        #endregion Equals

        #region Release
        public void Release()
        {
            this.m_sUid = string.Empty;
            this.m_oSalemancodelist = null;
            this.m_sLv = string.Empty;
        }
        #endregion Release

        #region DeepClone
        public MobileCsaOperationCenter DeepClone()
        {
            MobileCsaOperationCenter MobileCsaOperationCenter_Clone = new MobileCsaOperationCenter();
            MobileCsaOperationCenter_Clone.SetUid(this.m_sUid);
            MobileCsaOperationCenter_Clone.SetSalemancodelist(this.m_oSalemancodelist);
            MobileCsaOperationCenter_Clone.SetLv(this.m_sLv);
            return MobileCsaOperationCenter_Clone;
        }
        #endregion Clone

    }
}
