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
using System.Linq;
using System.Linq.Expressions;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

using log4net;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-03-Sat>
///-- Description:	<Description,Class :CustomerCallListDocumentDAO, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class CustomerCallListDocumentDAO
    {
        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        #region Init Customer Detail Information
        public void InitCust(string x_sMrt_no)
        {
            if (x_sMrt_no == null) Logger.WarnFormat("User cannot be found the result with null({0}) value in this function.", "x_sMrt_no");

            Crm_rpt_2G_action_rpt_GLRepository _oCrm_rpt_2G_action_rpt_GLRepository = new Crm_rpt_2G_action_rpt_GLRepository(GetCRMDB());
            IQueryable<Crm_rpt_2G_action_rpt_GLEntity> _oCustList = from sCustList in _oCrm_rpt_2G_action_rpt_GLRepository.Crm_rpt_2G_action_rpt_GLs
                                                                  where
                                                                      sCustList.mobile_no == x_sMrt_no
                                                                  select sCustList;

            if (_oCustList.Count<Crm_rpt_2G_action_rpt_GLEntity>() > 0)
            {
                Crm_rpt_2G_action_rpt_GLEntity _oCust = _oCustList.First<Crm_rpt_2G_action_rpt_GLEntity>();
                this.n_bActive = (bool)_oCust.GetActive();
                this.n_iId = (int)_oCust.GetId();
                this.n_sAcc_no = (string)_oCust.GetCustomer_code();
                this.n_sAddr_1 = (string)_oCust.GetAddr_1();
                this.n_sAddr_2 = (string)_oCust.GetAddr_2();
                this.n_sAddr_3 = (string)_oCust.GetAddr_3();
                this.n_sAddr_4 = (string)_oCust.GetAddr_4();
                this.n_sCid = (string)_oCust.GetCid();
                this.n_sContact_number = (string)_oCust.GetContact_number();
                this.n_sContract_id = (string)_oCust.GetContract_id();
                this.n_sCustomer_code = (string)_oCust.GetCustomer_code();
                this.n_sCustomer_group = (string)_oCust.GetCustomer_group();
                this.n_sCustomer_name = (string)_oCust.GetCustomer_name_formartted();
                this.n_sDid = (string)_oCust.GetDid();
                this.n_sMobile_no = (string)_oCust.GetMobile_no();
                this.n_sPayment_method = (string)_oCust.GetPayment_method();
                this.n_sRate_plan = (string)_oCust.GetRate_plan();
                this.n_sHkid = (string)_oCust.GetId_number().Substring(0, 5);
            }
            if (string.IsNullOrEmpty(this.n_sCustomer_name))
            {
                Crm_cust_numManagerBase _oCrm_cust_numManagerBase = new Crm_cust_numManagerBase(GetCRMDB());

                IQueryable<Crm_cust_numBase> _oCrmCustList = from sCrmCustList in _oCrm_cust_numManagerBase.Crm_cust_nums
                                                             where
                                                                 sCrmCustList.cust_num == x_sMrt_no
                                                             select sCrmCustList;
                if (_oCrmCustList.Count<Crm_cust_numBase>() > 0)
                {
                    Crm_cust_numBase _oCrm_cust_numBase = _oCrmCustList.First<Crm_cust_numBase>();
                    Crm_customerManagerBase _oCrm_customerManagerBase = new Crm_customerManagerBase(GetCRMDB());
                    IQueryable<Crm_customerBase> _oCrmCustom = from sCrmCustomList in _oCrm_customerManagerBase.Crm_customers
                                                               where
                                                                   sCrmCustomList.cust_id == _oCrm_cust_numBase.cust_id
                                                               select sCrmCustomList;

                    if (_oCrmCustom.Count<Crm_customerBase>() > 0)
                    {
                        Crm_customerBase _oCrm_CustomBase = _oCrmCustom.First<Crm_customerBase>();
                        this.n_bActive = (bool)_oCrm_CustomBase.GetActive();
                        this.n_sHkid = _oCrm_CustomBase.GetHkid_br();
                        this.n_sMobile_no = x_sMrt_no;
                        this.n_sCustomer_name = _oCrm_CustomBase.GetCust_name();
                    }
                }
            }
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

        protected static MSSQLConnect GetCRMDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.CRM + (((Configurator.IsUat()) ? "2" : string.Empty)));
            _oDB.bWithNoLock = true;
            return _oDB;
        }
        #endregion

        protected string n_sVip_customer = string.Empty;
        #region m_sVip_customer
        protected string m_sVip_customer
        {
            get
            {
                return this.n_sVip_customer;
            }
            set
            {
                this.n_sVip_customer = value;
            }
        }
        #endregion m_sVip_customer


        protected string n_sCustomer_code = string.Empty;
        #region m_sCustomer_code
        protected string m_sCustomer_code
        {
            get
            {
                return this.n_sCustomer_code;
            }
            set
            {
                this.n_sCustomer_code = value;
            }
        }
        #endregion m_sCustomer_code


        protected string n_sCid = string.Empty;
        #region m_sCid
        protected string m_sCid
        {
            get
            {
                return this.n_sCid;
            }
            set
            {
                this.n_sCid = value;
            }
        }
        #endregion m_sCid


        protected string n_sDid = string.Empty;
        #region m_sDid
        protected string m_sDid
        {
            get
            {
                return this.n_sDid;
            }
            set
            {
                this.n_sDid = value;
            }
        }
        #endregion m_sDid


        protected string n_sCustomer_group = string.Empty;
        #region m_sCustomer_group
        protected string m_sCustomer_group
        {
            get
            {
                return this.n_sCustomer_group;
            }
            set
            {
                this.n_sCustomer_group = value;
            }
        }
        #endregion m_sCustomer_group


        protected string n_sHkid = string.Empty;
        #region m_sHkid
        protected string m_sHkid
        {
            get
            {
                return this.n_sHkid;
            }
            set
            {
                this.n_sHkid = value;
            }
        }
        #endregion m_sHkid


        protected string n_sAcc_no = string.Empty;
        #region m_sAcc_no
        protected string m_sAcc_no
        {
            get
            {
                return this.n_sAcc_no;
            }
            set
            {
                this.n_sAcc_no = value;
            }
        }
        #endregion m_sAcc_no


        protected string n_sAddr_4 = string.Empty;
        #region m_sAddr_4
        protected string m_sAddr_4
        {
            get
            {
                return this.n_sAddr_4;
            }
            set
            {
                this.n_sAddr_4 = value;
            }
        }
        #endregion m_sAddr_4


        protected string n_sCustomer_name = string.Empty;
        #region m_sCustomer_name
        protected string m_sCustomer_name
        {
            get
            {
                return this.n_sCustomer_name;
            }
            set
            {
                this.n_sCustomer_name = value;
            }
        }
        #endregion m_sCustomer_name


        protected string n_sAddr_1 = string.Empty;
        #region m_sAddr_1
        protected string m_sAddr_1
        {
            get
            {
                return this.n_sAddr_1;
            }
            set
            {
                this.n_sAddr_1 = value;
            }
        }
        #endregion m_sAddr_1


        protected string n_sRate_plan = string.Empty;
        #region m_sRate_plan
        protected string m_sRate_plan
        {
            get
            {
                return this.n_sRate_plan;
            }
            set
            {
                this.n_sRate_plan = value;
            }
        }
        #endregion m_sRate_plan


        protected string n_sContact_number = string.Empty;
        #region m_sContact_number
        protected string m_sContact_number
        {
            get
            {
                return this.n_sContact_number;
            }
            set
            {
                this.n_sContact_number = value;
            }
        }
        #endregion m_sContact_number


        protected int n_iId = -1;
        #region m_iId
        protected int m_iId
        {
            get
            {
                return this.n_iId;
            }
            set
            {
                this.n_iId = value;
            }
        }
        #endregion m_iId


        protected string n_sPayment_method = string.Empty;
        #region m_sPayment_method
        protected string m_sPayment_method
        {
            get
            {
                return this.n_sPayment_method;
            }
            set
            {
                this.n_sPayment_method = value;
            }
        }
        #endregion m_sPayment_method


        protected string n_sAddr_3 = string.Empty;
        #region m_sAddr_3
        protected string m_sAddr_3
        {
            get
            {
                return this.n_sAddr_3;
            }
            set
            {
                this.n_sAddr_3 = value;
            }
        }
        #endregion m_sAddr_3


        protected string n_sAddr_2 = string.Empty;
        #region m_sAddr_2
        protected string m_sAddr_2
        {
            get
            {
                return this.n_sAddr_2;
            }
            set
            {
                this.n_sAddr_2 = value;
            }
        }
        #endregion m_sAddr_2


        protected bool n_bActive = false;
        #region m_bActive
        protected bool m_bActive
        {
            get
            {
                return this.n_bActive;
            }
            set
            {
                this.n_bActive = value;
            }
        }
        #endregion m_bActive


        protected string n_sMobile_no = string.Empty;
        #region m_sMobile_no
        protected string m_sMobile_no
        {
            get
            {
                return this.n_sMobile_no;
            }
            set
            {
                this.n_sMobile_no = value;
            }
        }
        #endregion m_sMobile_no


        protected string n_sContract_id = string.Empty;
        #region m_sContract_id
        protected string m_sContract_id
        {
            get
            {
                return this.n_sContract_id;
            }
            set
            {
                this.n_sContract_id = value;
            }
        }
        #endregion m_sContract_id


        protected string n_sHkid2 = string.Empty;
        #region m_sHkid2
        protected string m_sHkid2
        {
            get
            {
                return this.n_sHkid2;
            }
            set
            {
                this.n_sHkid2 = value;
            }
        }
        #endregion m_sHkid2



        

        #region Constructor & Destructor
        public CustomerCallListDocumentDAO() { }

        public CustomerCallListDocumentDAO(string x_sVip_customer, string x_sCustomer_code, string x_sCid, string x_sDid, string x_sCustomer_group, string x_sHkid, string x_sAcc_no, string x_sAddr_4, string x_sCustomer_name, string x_sAddr_1, string x_sRate_plan, string x_sContact_number, int x_iId, string x_sPayment_method, string x_sAddr_3, string x_sAddr_2, bool x_bActive, string x_sMobile_no, string x_sContract_id, string x_sHkid2)
        {
            m_sVip_customer = x_sVip_customer;
            m_sCustomer_code = x_sCustomer_code;
            m_sCid = x_sCid;
            m_sDid = x_sDid;
            m_sCustomer_group = x_sCustomer_group;
            m_sHkid = x_sHkid;
            m_sAcc_no = x_sAcc_no;
            m_sAddr_4 = x_sAddr_4;
            m_sCustomer_name = x_sCustomer_name;
            m_sAddr_1 = x_sAddr_1;
            m_sRate_plan = x_sRate_plan;
            m_sContact_number = x_sContact_number;
            m_iId = x_iId;
            m_sPayment_method = x_sPayment_method;
            m_sAddr_3 = x_sAddr_3;
            m_sAddr_2 = x_sAddr_2;
            m_bActive = x_bActive;
            m_sMobile_no = x_sMobile_no;
            m_sContract_id = x_sContract_id;
            m_sHkid2 = x_sHkid2;
        }

        ~CustomerCallListDocumentDAO() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public string GetVip_customer() { return this.m_sVip_customer; }
        public string GetCustomer_code() { return this.m_sCustomer_code; }
        public string GetCid() { return this.m_sCid; }
        public string GetDid() { return this.m_sDid; }
        public string GetCustomer_group() { return this.m_sCustomer_group; }
        public string GetHkid() { return this.m_sHkid; }
        public string GetAcc_no() { return this.m_sAcc_no; }
        public string GetAddr_4() { return this.m_sAddr_4; }
        public string GetCustomer_name() { return this.m_sCustomer_name; }
        public string GetAddr_1() { return this.m_sAddr_1; }
        public string GetRate_plan() { return this.m_sRate_plan; }
        public string GetContact_number() { return this.m_sContact_number; }
        public int GetId() { return this.m_iId; }
        public string GetPayment_method() { return this.m_sPayment_method; }
        public string GetAddr_3() { return this.m_sAddr_3; }
        public string GetAddr_2() { return this.m_sAddr_2; }
        public bool GetActive() { return this.m_bActive; }
        public string GetMobile_no() { return this.m_sMobile_no; }
        public string GetContract_id() { return this.m_sContract_id; }
        public string GetHkid2() { return this.m_sHkid2; }

        public bool SetVip_customer(string value)
        {
            this.m_sVip_customer = value;
            return true;
        }
        public bool SetCustomer_code(string value)
        {
            this.m_sCustomer_code = value;
            return true;
        }
        public bool SetCid(string value)
        {
            this.m_sCid = value;
            return true;
        }
        public bool SetDid(string value)
        {
            this.m_sDid = value;
            return true;
        }
        public bool SetCustomer_group(string value)
        {
            this.m_sCustomer_group = value;
            return true;
        }
        public bool SetHkid(string value)
        {
            this.m_sHkid = value;
            return true;
        }
        public bool SetAcc_no(string value)
        {
            this.m_sAcc_no = value;
            return true;
        }
        public bool SetAddr_4(string value)
        {
            this.m_sAddr_4 = value;
            return true;
        }
        public bool SetCustomer_name(string value)
        {
            this.m_sCustomer_name = value;
            return true;
        }
        public bool SetAddr_1(string value)
        {
            this.m_sAddr_1 = value;
            return true;
        }
        public bool SetRate_plan(string value)
        {
            this.m_sRate_plan = value;
            return true;
        }
        public bool SetContact_number(string value)
        {
            this.m_sContact_number = value;
            return true;
        }
        public bool SetId(int value)
        {
            this.m_iId = value;
            return true;
        }
        public bool SetPayment_method(string value)
        {
            this.m_sPayment_method = value;
            return true;
        }
        public bool SetAddr_3(string value)
        {
            this.m_sAddr_3 = value;
            return true;
        }
        public bool SetAddr_2(string value)
        {
            this.m_sAddr_2 = value;
            return true;
        }
        public bool SetActive(bool value)
        {
            this.m_bActive = value;
            return true;
        }
        public bool SetMobile_no(string value)
        {
            this.m_sMobile_no = value;
            return true;
        }
        public bool SetContract_id(string value)
        {
            this.m_sContract_id = value;
            return true;
        }
        public bool SetHkid2(string value)
        {
            this.m_sHkid2 = value;
            return true;
        }
        #endregion


        

        #region Equals
        public bool Equals(CustomerCallListDocumentDAO x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.m_sVip_customer.Equals(x_oObj.m_sVip_customer)) { return false; }
            if (!this.m_sCustomer_code.Equals(x_oObj.m_sCustomer_code)) { return false; }
            if (!this.m_sCid.Equals(x_oObj.m_sCid)) { return false; }
            if (!this.m_sDid.Equals(x_oObj.m_sDid)) { return false; }
            if (!this.m_sCustomer_group.Equals(x_oObj.m_sCustomer_group)) { return false; }
            if (!this.m_sHkid.Equals(x_oObj.m_sHkid)) { return false; }
            if (!this.m_sAcc_no.Equals(x_oObj.m_sAcc_no)) { return false; }
            if (!this.m_sAddr_4.Equals(x_oObj.m_sAddr_4)) { return false; }
            if (!this.m_sCustomer_name.Equals(x_oObj.m_sCustomer_name)) { return false; }
            if (!this.m_sAddr_1.Equals(x_oObj.m_sAddr_1)) { return false; }
            if (!this.m_sRate_plan.Equals(x_oObj.m_sRate_plan)) { return false; }
            if (!this.m_sContact_number.Equals(x_oObj.m_sContact_number)) { return false; }
            if (!this.m_iId.Equals(x_oObj.m_iId)) { return false; }
            if (!this.m_sPayment_method.Equals(x_oObj.m_sPayment_method)) { return false; }
            if (!this.m_sAddr_3.Equals(x_oObj.m_sAddr_3)) { return false; }
            if (!this.m_sAddr_2.Equals(x_oObj.m_sAddr_2)) { return false; }
            if (!this.m_bActive.Equals(x_oObj.m_bActive)) { return false; }
            if (!this.m_sMobile_no.Equals(x_oObj.m_sMobile_no)) { return false; }
            if (!this.m_sContract_id.Equals(x_oObj.m_sContract_id)) { return false; }
            if (!this.m_sHkid2.Equals(x_oObj.m_sHkid2)) { return false; }
            return true;
        }
        #endregion Equals

        #region Release
        public void Release()
        {
            this.m_sVip_customer = string.Empty;
            this.m_sCustomer_code = string.Empty;
            this.m_sCid = string.Empty;
            this.m_sDid = string.Empty;
            this.m_sCustomer_group = string.Empty;
            this.m_sHkid = string.Empty;
            this.m_sAcc_no = string.Empty;
            this.m_sAddr_4 = string.Empty;
            this.m_sCustomer_name = string.Empty;
            this.m_sAddr_1 = string.Empty;
            this.m_sRate_plan = string.Empty;
            this.m_sContact_number = string.Empty;
            this.m_iId = -1;
            this.m_sPayment_method = string.Empty;
            this.m_sAddr_3 = string.Empty;
            this.m_sAddr_2 = string.Empty;
            this.m_bActive = false;
            this.m_sMobile_no = string.Empty;
            this.m_sContract_id = string.Empty;
            this.m_sHkid2 = string.Empty;
        }
        #endregion Release

        #region DeepClone
        public CustomerCallListDocumentDAO DeepClone()
        {
            CustomerCallListDocumentDAO CustomerCallListDocumentDAO_Clone = new CustomerCallListDocumentDAO();
            CustomerCallListDocumentDAO_Clone.SetVip_customer(this.m_sVip_customer);
            CustomerCallListDocumentDAO_Clone.SetCustomer_code(this.m_sCustomer_code);
            CustomerCallListDocumentDAO_Clone.SetCid(this.m_sCid);
            CustomerCallListDocumentDAO_Clone.SetDid(this.m_sDid);
            CustomerCallListDocumentDAO_Clone.SetCustomer_group(this.m_sCustomer_group);
            CustomerCallListDocumentDAO_Clone.SetHkid(this.m_sHkid);
            CustomerCallListDocumentDAO_Clone.SetAcc_no(this.m_sAcc_no);
            CustomerCallListDocumentDAO_Clone.SetAddr_4(this.m_sAddr_4);
            CustomerCallListDocumentDAO_Clone.SetCustomer_name(this.m_sCustomer_name);
            CustomerCallListDocumentDAO_Clone.SetAddr_1(this.m_sAddr_1);
            CustomerCallListDocumentDAO_Clone.SetRate_plan(this.m_sRate_plan);
            CustomerCallListDocumentDAO_Clone.SetContact_number(this.m_sContact_number);
            CustomerCallListDocumentDAO_Clone.SetId(this.m_iId);
            CustomerCallListDocumentDAO_Clone.SetPayment_method(this.m_sPayment_method);
            CustomerCallListDocumentDAO_Clone.SetAddr_3(this.m_sAddr_3);
            CustomerCallListDocumentDAO_Clone.SetAddr_2(this.m_sAddr_2);
            CustomerCallListDocumentDAO_Clone.SetActive(this.m_bActive);
            CustomerCallListDocumentDAO_Clone.SetMobile_no(this.m_sMobile_no);
            CustomerCallListDocumentDAO_Clone.SetContract_id(this.m_sContract_id);
            CustomerCallListDocumentDAO_Clone.SetHkid2(this.m_sHkid2);
            return CustomerCallListDocumentDAO_Clone;
        }
        #endregion Clone

    }
}
