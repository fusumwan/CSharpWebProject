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
using System.Data.Odbc;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

using log4net;

namespace PCCW.RWL.CORE
{

    public class BusinessDeliveryFalloutProfile
    {
        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        public string Query { get; set; }

        #region Get Sales Man List
        public global::System.Collections.Generic.List<string> Get_SalesManList()
        {
            return Get_SalesManList(n_sUid);
        }

        public global::System.Collections.Generic.List<string> Get_SalesManList(string x_sUid)
        {
            if (x_sUid == null) Logger.WarnFormat("User cannot be found the result with null({0}) value in this function.", "x_sUid");
            List<string> _oSalesmancodeList = new List<string>();
            SaleManCodeProfile _oSaleManCodeProfile = new SaleManCodeProfile();
            _oSaleManCodeProfile.SetUid(x_sUid);
            _oSalesmancodeList = _oSaleManCodeProfile.Get_SalemanCodeList();
            return _oSalesmancodeList;
        }
        #endregion

        #region Get Delivery Fallout Case
        public global::System.Data.Odbc.OdbcDataReader Get_Delivery_Fallout_Case()
        {
            return Get_Delivery_Fallout_Case(n_sUid, n_sLv, n_oSalemancodelist);
        }

        public global::System.Data.DataSet Get_Delivery_Fallout_CaseDS()
        {
            return Get_Delivery_Fallout_CaseDS(n_sUid, n_sLv, n_oSalemancodelist);
        }

        public global::System.Data.DataSet Get_Delivery_Fallout_CaseDS(
           string x_sUid, string x_sLv, global::System.Collections.Generic.List<string> x_oSalemancodelist)
        {
            this.Query = GetQuery(x_sUid, x_sLv, x_oSalemancodelist, string.Empty, "agree_no", "asc");
            return GetORDB().GetDS(Query.ToString());
        }

        public global::System.Data.Odbc.OdbcDataReader Get_Delivery_Fallout_Case(
            string x_sUid, string x_sLv, global::System.Collections.Generic.List<string> x_oSalemancodelist)
        {
            this.Query = GetQuery(x_sUid, x_sLv, x_oSalemancodelist, string.Empty, "agree_no", "asc");
            return GetORDB().GetSearch(Query.ToString());
        }

        public string GetQuery()
        {
            this.Query = GetQuery("agree_no", "asc");
            return this.Query;
        }

        public string GetQuery(string x_sOrderBy, string x_sSortDir)
        {
            this.Query = GetQuery(this.n_sUid, this.n_sLv, this.n_oSalemancodelist, string.Empty, x_sOrderBy, x_sSortDir);
            return this.Query;
        }

        public string GetQuery(string x_sFilterExpression, string x_sOrderBy, string x_sSortDir)
        {
            this.Query = GetQuery(this.n_sUid, this.n_sLv, this.n_oSalemancodelist, x_sFilterExpression, x_sOrderBy, x_sSortDir);
            return this.Query;
        }

        public string GetQuery(
            string x_sUid, string x_sLv, global::System.Collections.Generic.List<string> x_oSalemancodelist, string x_sFilterExpression, string x_sOrderBy, string x_sSortDir)
        {
            if (x_sUid == null) throw new InvalidOperationException("x_sUid");
            if (x_sLv == null) throw new InvalidOperationException("x_sLv");
            if (x_oSalemancodelist == null) throw new InvalidOperationException("x_sSalemancodeList");
            global::System.Text.StringBuilder _sQuery = new global::System.Text.StringBuilder();
            string _sSalesManList = Func.ExplodeList(x_oSalemancodelist, ",", true).Trim();
            _sQuery.Append(" SELECT * FROM SUNDAY_FORM WHERE CREATED_BY='CC RET' ");
            _sQuery.Append(" AND pending='Y' AND cancelled='N' AND actual_del_date IS NULL ");
            if (!"65535".Equals(x_sLv))
            {
                if (("10".Equals(x_sLv) || "4".Equals(x_sLv)) && !string.IsNullOrEmpty(_sSalesManList))
                    _sQuery.Append(" AND SalesManCode IN ( " + _sSalesManList + " )");
                else
                    _sQuery.Append(" AND STAFFNO='" + x_sUid + "' ");
            }

            string _sFilterQuery = (!string.IsNullOrEmpty(x_sFilterExpression)) ? x_sFilterExpression.Trim() : string.Empty;
            if (!string.IsNullOrEmpty(_sFilterQuery))
                _sQuery.Append(" AND " + _sFilterQuery);

            _sQuery.Append(" ORDER BY " + x_sOrderBy + " " + x_sSortDir);
            Query = _sQuery.ToString();
            return Query;
        }

        #endregion

        #region GetDB
        public static ODBCConnect GetORDB()
        {
            ODBCConnect _oDB = new ODBCConnect();
            _oDB.SetConnStr(Configurator.DBName.ORADNS + ((Configurator.IsUat()) ? "2" : string.Empty));
            return _oDB;
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


        protected global::System.Collections.Generic.List<string> n_oSalemancodelist = null;
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

        #region Constructor & Destructor
        public BusinessDeliveryFalloutProfile() { }

        public BusinessDeliveryFalloutProfile(string x_sUid, global::System.Collections.Generic.List<string> x_oSalemancodelist, string x_sLv)
        {
            m_sUid = x_sUid;
            m_oSalemancodelist = x_oSalemancodelist;
            m_sLv = x_sLv;
        }

        ~BusinessDeliveryFalloutProfile() { }

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

        #region Equals
        public bool Equals(BusinessDeliveryFalloutProfile x_oObj)
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
        public BusinessDeliveryFalloutProfile DeepClone()
        {
            BusinessDeliveryFalloutProfile BusinessDeliveryFalloutProfile_Clone = new BusinessDeliveryFalloutProfile();
            BusinessDeliveryFalloutProfile_Clone.SetUid(this.m_sUid);
            BusinessDeliveryFalloutProfile_Clone.SetSalemancodelist(this.m_oSalemancodelist);
            BusinessDeliveryFalloutProfile_Clone.SetLv(this.m_sLv);
            return BusinessDeliveryFalloutProfile_Clone;
        }
        #endregion Clone

    }
}
