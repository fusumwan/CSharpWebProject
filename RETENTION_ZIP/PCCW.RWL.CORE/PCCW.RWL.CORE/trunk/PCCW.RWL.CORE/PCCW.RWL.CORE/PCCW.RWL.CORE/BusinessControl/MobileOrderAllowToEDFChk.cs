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
namespace PCCW.RWL.CORE
{
    public class MobileOrderAllowToEDFChk
    {
        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        public class Type
        {
            public const string HS = "SKU";
            public const string SIM = "SIM_ITEM_CODE";
            //public const string PROGRAM = "PROGRAM"; 
        }



        #region global string
        protected string n_sSku = "";
        protected virtual string m_sSku
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

        protected string n_sImei_no = "";
        protected virtual string m_sImei_no
        {
            get
            {
                return this.n_sImei_no;
            }
            set
            {
                this.n_sImei_no = value;
            }
        }

        protected string n_sSim_item_code = "";
        protected virtual string m_sSim_item_code
        {
            get
            {
                return this.n_sSim_item_code;
            }
            set
            {
                this.n_sSim_item_code = value;
            }
        }


        protected string n_sSim_item_number = "";
        protected virtual string m_sSim_item_number
        {
            get
            {
                return this.n_sSim_item_number;
            }
            set
            {
                this.n_sSim_item_number = value;
            }
        }
        #endregion

        SessionFactory<MSSQLConnect> SessionFactory = new SessionFactory<MSSQLConnect>();
        public bool AllowMigrateEDF(string x_sRule_Name, string x_sType, string x_sState, string x_sSku, bool x_bActive)
        {
            MobileOrderMigrateRuleRepository _oMobileOrderMigrateRuleRepository =
                new MobileOrderMigrateRuleRepository(SYSConn<MSSQLConnect>.Connect());
            IQueryable<MobileOrderMigrateRuleEntity> _oMobileOrderMigrateRuleEntityList =
                from sMobileOrderMigrateRuleEntityList in _oMobileOrderMigrateRuleRepository.MobileOrderMigrateRules
                where sMobileOrderMigrateRuleEntityList.name == x_sRule_Name &&
                sMobileOrderMigrateRuleEntityList.type == x_sType &&
                sMobileOrderMigrateRuleEntityList.status == x_sState &&
                sMobileOrderMigrateRuleEntityList.sku == x_sSku &&
                sMobileOrderMigrateRuleEntityList.active == x_bActive
                select sMobileOrderMigrateRuleEntityList;
            if (_oMobileOrderMigrateRuleEntityList.Count<MobileOrderMigrateRuleEntity>() > 0)
            {
                return true;
            }
            return false;
        }

        public bool InsertNewRule(string x_sRule_Name, string x_sType, string x_sState, string x_sSku)
        {
            if (string.IsNullOrEmpty(x_sRule_Name)) return false;
            if (string.IsNullOrEmpty(x_sType)) return false;
            if (string.IsNullOrEmpty(x_sState)) return false;
            if (string.IsNullOrEmpty(x_sSku)) return false;
            ISession<MSSQLConnect> _oSession = null;
            using (_oSession = SessionFactory.OpenSession())
            using (ITransaction _oTransaction = _oSession.BeginTransaction())
            {
                bool _bRollBack = false;
                MobileOrderMigrateRuleEntity _oMobileOrderMigrateRuleEntity = new MobileOrderMigrateRuleEntity(SYSConn<MSSQLConnect>.Connect());
                _oMobileOrderMigrateRuleEntity.SetActive(true);
                _oMobileOrderMigrateRuleEntity.SetName(x_sRule_Name);
                _oMobileOrderMigrateRuleEntity.SetType(x_sType);
                _oMobileOrderMigrateRuleEntity.SetStatus(x_sState);
                _oMobileOrderMigrateRuleEntity.SetSku(x_sSku);
                if (_oSession.Insert(_oMobileOrderMigrateRuleEntity))
                    _bRollBack = true;
                if (!_bRollBack)
                    _oTransaction.Commit();
                else
                    _oTransaction.Rollback();
            }
            return true;
        }

        #region Get & Set
        //public string GetProgram() { return this.m_sProgram; }
        public string GetSku() { return this.m_sSku; }
        public string GetImei_no() { return this.m_sImei_no; }
        public string GetSim_item_code() { return this.m_sSim_item_code; }
        public string GetSim_item_number() { return this.m_sSim_item_number; }

        //public bool SetProgram(string value)
        //{
        //    this.m_sProgram = value;
        //    return true;
        //}
        public bool SetSku(string value)
        {
            this.m_sSku = value;
            return true;
        }
        public bool SetImei_no(string value)
        {
            this.m_sImei_no = value;
            return true;
        }
        public bool SetSim_item_code(string value)
        {
            this.m_sSim_item_code = value;
            return true;
        }
        public bool SetSim_item_number(string value)
        {
            this.m_sSim_item_number = value;
            return true;
        }
        #endregion

        #region Dictionary, List
        // Dictionary storing the field name and value
        // need to get SIM_ITEM_CODE, SKU
        public Dictionary<string, string> getInputFieldValuePair()
        {
            Dictionary<string, string> x_dPairs = new Dictionary<string, string>();
            x_dPairs.Add("SKU", GetSku());
            x_dPairs.Add("SIM_ITEM_CODE", GetSim_item_code());
            return x_dPairs;
        }

        // Dictionary storing the field name and value
        // need to get SIM_ITEM_NUMBER, SIM_NO
        public Dictionary<string, string> getInputValueStatusPair()
        {
            Dictionary<string, string> x_dPairs = new Dictionary<string, string>();
            if (GetSku() != string.Empty)
            {
                if(!x_dPairs.ContainsKey(GetSku()))
                    x_dPairs.Add(GetSku(), GetImei_no());
            }
            if (GetSim_item_code() != string.Empty)
            {
                if (!x_dPairs.ContainsKey(GetSim_item_code()))
                    x_dPairs.Add(GetSim_item_code(), GetSim_item_number());
            }
            //x_dPairs.Add("PROGRAM", GetProgram());
            return x_dPairs;
        }

        // List storing the rules name from database, used for Loop to check
        public List<string> getDistinctRulesName()
        {
            List<string> distinctRulesName = new List<string>();
            string _sQuery = "SELECT DISTINCT name FROM MobileOrderMigrateRule";
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);

            while (_oDr.Read())
            {
                distinctRulesName.Add(_oDr["name"].ToString());
            }
            _oDr.Close();
            _oDr.Dispose();
            return distinctRulesName;
        }
        #endregion

        // main method
        public bool allowToEDF()
        {
            bool _bFlag = false;
            bool _bPassFullSet = true;
            List<string> _lDistinctRulesName = getDistinctRulesName();
            Dictionary<string, string> _dFieldValuePair = getInputFieldValuePair();
            Dictionary<string, string> _dValueStatusPair = getInputValueStatusPair();

            //while (!_bFlag)
            //{
            foreach (string _sName in _lDistinctRulesName)
            {
                StringBuilder _oQuery1 = new StringBuilder();
                _oQuery1.Append("SELECT * FROM MobileOrderMigrateRule where ");
                _oQuery1.Append("name='" + _sName + "' and active=1");

                SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery1.ToString());
                _bPassFullSet = true;
                while (_oDr.Read() && _bPassFullSet == true)
                {
                    if (string.IsNullOrEmpty(_dFieldValuePair[Func.FR(_oDr["type"]).ToString()]))
                    {
                        _bPassFullSet = false;
                    }
                    else if (_dFieldValuePair[Func.FR(_oDr["type"]).ToString()] != Func.FR(_oDr["sku"]).ToString())
                    {
                        //if (_dValueStatusPair[_oDr["sku"].ToString()] != _oDr["status"].ToString())
                        //{
                        _bPassFullSet = false;
                        //}
                    }
                }
                _oDr.Close();
                _oDr.Dispose();
                _bFlag = _bPassFullSet;
                if (_bFlag) break;
            }
            //}
            return _bFlag;
        }

        public MobileOrderMigrateRuleEntity[] GetRuleList(string x_sRule_Name, string x_sType, string x_sState, string x_sSku, bool x_bActive)
        {
            MobileOrderMigrateRuleRepository _oMobileOrderMigrateRuleRepository =
               new MobileOrderMigrateRuleRepository(SYSConn<MSSQLConnect>.Connect());
            IQueryable<MobileOrderMigrateRuleEntity> _oMobileOrderMigrateRuleEntityList =
                from sMobileOrderMigrateRuleEntityList in _oMobileOrderMigrateRuleRepository.MobileOrderMigrateRules
                where ChkStr(sMobileOrderMigrateRuleEntityList.name, x_sRule_Name) &&
                ChkStr(sMobileOrderMigrateRuleEntityList.type, x_sType) &&
                ChkStr(sMobileOrderMigrateRuleEntityList.status, x_sState) &&
                ChkStr(sMobileOrderMigrateRuleEntityList.sku, x_sSku) &&
                sMobileOrderMigrateRuleEntityList.active == x_bActive
                select sMobileOrderMigrateRuleEntityList;
            if (_oMobileOrderMigrateRuleEntityList.Count<MobileOrderMigrateRuleEntity>() > 0)
            {
                return _oMobileOrderMigrateRuleEntityList.ToArray<MobileOrderMigrateRuleEntity>();
            }
            return new MobileOrderMigrateRuleEntity[0];
        }

        public bool ChkStr(string x_sStr1, string x_sStr2)
        {
            if (!string.IsNullOrEmpty(x_sStr2))
            {
                if (x_sStr1.Equals(x_sStr2))
                    return true;
                else
                    return false;
            }
            return true;
        }




        

        #region Get Sql DB
        protected MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            _oDB.bWithNoLock = true;
            return _oDB;
        }
        #endregion
    }
}
