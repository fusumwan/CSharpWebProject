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
using System.Xml.Linq;
using System.Linq;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-01-09>
///-- Description:	<Description,Class :[SaleManCodeProfile],Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class SaleManCodeProfile
    {
        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Get Sale man code list
        /// <summary>
        /// 
        ///select top 10 * from [cssdb].dbo.ock_deputy;
        ///select top 10 * from [cssdb].dbo.ock_teamlist;
        /// </summary>
        /// <returns></returns>
        public global::System.Collections.Generic.List<string> Get_SalemanCodeList()
        {
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append(" SELECT distinct salesman_code FROM [cssdb].[csc].[boc_info]  WHERE active=1 AND ");
            _oQuery.Append(" salesman_code is not null AND salesman_code<>'' AND ");
            _oQuery.Append(" (leader1_sn='" + n_sUid.ToString() + "' OR leader2_sn='" + n_sUid.ToString() + "' OR leader3_sn='" + n_sUid.ToString() + "' OR sm_id='" + n_sUid.ToString() + "')");
            _oQuery.Append(" AND sdate<=getdate() AND (edate>=getdate() OR edate is null) ");

            _oQuery.Append(" UNION ");
            _oQuery.Append(" SELECT distinct salesman_code FROM ProfileTeamRecord WHERE active=1 AND STAFF_no='" + n_sUid.ToString() + "' ");
            _oQuery.Append(" AND (sdate IS NULL OR sdate<=getdate()) AND (edate>=getdate() OR edate is null) ");

            global::System.Collections.Generic.List<string> n_sSalesmancodeList = new global::System.Collections.Generic.List<string>();
            global::System.Data.SqlClient.SqlDataReader _oReader = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
            n_sSalesmancodeList.Clear();
            if (_oReader != null)
            {
                while (_oReader.Read())
                    n_sSalesmancodeList.Add(_oReader["salesman_code"].ToString());
            }
            if (_oReader != null) _oReader.Close();
            return n_sSalesmancodeList;
        }



        public static List<string> GetAllSalemanCode()
        {
            List<string> _oSalemanCodeList = new List<string>();
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append(" SELECT '' AS 'salesman_code' ");
            _oQuery.Append(" UNION ");
            _oQuery.Append(" SELECT DISTINCT salesman_code FROM csc.boc_info WHERE  ");
            _oQuery.Append(" salesman_code IS NOT NULL AND salesman_code<>''  ");
            _oQuery.Append(" ORDER BY salesman_code ASC");
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect("CSSDB").GetSearch(_oQuery.ToString());
            while (_oDr.Read())
                _oSalemanCodeList.Add(Func.FR(_oDr["salesman_code"]));

            _oDr.Close();
            _oDr.Dispose();
            return _oSalemanCodeList;
        }

        #endregion
        protected global::System.Collections.Generic.List<string> n_oSalesmancodeList = null;
        #region m_oSalesmancodeList
        protected global::System.Collections.Generic.List<string> m_oSalesmancodeList
        {
            get
            {
                return this.n_oSalesmancodeList;
            }
            set
            {
                this.n_oSalesmancodeList = value;
            }
        }
        #endregion m_oSalesmancodeList


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

        protected string n_sLv = global::System.String.Empty;
        #region Lv
        public string Lv
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
        #endregion Lv

        #region Constructor & Destructor
        public SaleManCodeProfile() { }

        public SaleManCodeProfile(List<string> x_oSalesmancodeList, string x_sUid, string x_sLv)
        {
            m_oSalesmancodeList = x_oSalesmancodeList;
            m_sUid = x_sUid;
            Lv = x_sLv;
        }

        ~SaleManCodeProfile() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public global::System.Collections.Generic.List<string> GetSalesmancodeList() { return this.m_oSalesmancodeList; }
        public string GetUid() { return this.m_sUid; }
        public string GetLv() { return this.Lv; }

        public bool SetSalesmancodeList(List<string> value)
        {
            this.m_oSalesmancodeList = value;
            return true;
        }
        public bool SetUid(string value)
        {
            this.m_sUid = value;
            return true;
        }
        public bool SetLv(string value)
        {
            this.Lv = value;
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
        public bool Equals(SaleManCodeProfile x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.m_oSalesmancodeList.Equals(x_oObj.m_oSalesmancodeList)) { return false; }
            if (!this.m_sUid.Equals(x_oObj.m_sUid)) { return false; }
            if (!this.Lv.Equals(x_oObj.Lv)) { return false; }
            return true;
        }
        #endregion Equals

        #region Release
        public void Release()
        {
            this.m_oSalesmancodeList = null;
            this.m_sUid = string.Empty;
            this.Lv = string.Empty;
        }
        #endregion Release


        #region DeepClone
        public SaleManCodeProfile DeepClone()
        {
            SaleManCodeProfile SaleManCodeProfile_Clone = new SaleManCodeProfile();
            SaleManCodeProfile_Clone.SetSalesmancodeList(this.m_oSalesmancodeList);
            SaleManCodeProfile_Clone.SetUid(this.m_sUid);
            SaleManCodeProfile_Clone.SetLv(this.Lv);
            return SaleManCodeProfile_Clone;
        }
        #endregion Clone

    }
}
