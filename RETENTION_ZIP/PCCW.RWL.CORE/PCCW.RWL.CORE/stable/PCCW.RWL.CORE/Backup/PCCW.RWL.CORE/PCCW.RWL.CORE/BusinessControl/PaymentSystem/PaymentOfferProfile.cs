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
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-01-09>
///-- Description:	<Description,Class :[PaymentOfferProfile],Data Relation Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class PaymentOfferProfile
    {
        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Get Plan Fee
        public string Get_PlanFee(string x_sRate_plan){
            if (x_sRate_plan == null) Logger.WarnFormat("User cannot be found the result with null({0}) value in this function.", "x_sRate_plan");
            string _sPlan_fee_rs = string.Empty;
            string _sQuery = "SELECT plan_fee FROM " + Configurator.MSSQLTablePrefix + "RetentionPlan with (nolock) WHERE active=1 AND plan_code='" + x_sRate_plan.Trim() + "'";
            _sPlan_fee_rs = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar(_sQuery.ToString());
            if (_sPlan_fee_rs == string.Empty)
                return "0";
            else
                return SYSConn<MSSQLConnect>.Connect().GetExecuteScalar(_sQuery.ToString());
        }
        #endregion

        #region Get Offer ,rebate_amount, extra_rebate, extra_rebate_amount,amount
        public Hashtable Get_AllOfferList(
            string x_sProgram, string x_sCon_per, string x_sPlan_fee_rs,
            string x_sNormal_rebate_type, string x_sHsmodel, string x_sPayment, string x_sHs_offer_type_id)
        {
            //if (x_sCon_per == null) throw new ArgumentNullException("x_sCon_per");
            //if (x_sPlan_fee_rs == null) throw new ArgumentNullException("x_sPlan_fee_rs");
            //if (x_sNormal_rebate_type == null) throw new ArgumentNullException("x_sNormal_rebate_type");
            //if (x_sHsmodel == null) throw new ArgumentNullException("x_sHsmodel");
            //if (x_sPayment == null) throw new ArgumentNullException("x_sPayment");
            global::System.Collections.Generic.List<string> _oOfferList = new global::System.Collections.Generic.List<string>();
            global::System.Collections.Generic.List<string> _oRebate_amountList = new global::System.Collections.Generic.List<string>();
            global::System.Collections.Generic.List<string> _oAmountList = new global::System.Collections.Generic.List<string>();
            global::System.Collections.Generic.List<string> _oExtra_rebateList = new global::System.Collections.Generic.List<string>();
            global::System.Collections.Generic.List<string> _oExtra_rebate_amountList = new global::System.Collections.Generic.List<string>();
            global::System.Collections.Generic.List<string> _oOffer_type_idList = new global::System.Collections.Generic.List<string>();
            Hashtable _oAllList = new Hashtable();
            global::System.Text.StringBuilder _sQuery = new global::System.Text.StringBuilder();
            _sQuery.Append("SELECT DISTINCT a.r_offer,a.offer_type_id,a.rebate_amount,a.amount,a.extra_rebate,a.extra_rebate_amount FROM " + Configurator.MSSQLTablePrefix + "RebateGroup b with (nolock), ");
            _sQuery.Append(" (SELECT plan_fee,offer_type_id, con_per, hs_model,rebate_gp,normal_rebate,r_offer,rebate_amount,amount,extra_rebate,extra_rebate_amount FROM " + Configurator.MSSQLTablePrefix + "HandSetOfferedBasket with (nolock) ");
            _sQuery.Append(" WHERE active=1  AND (edate is null OR edate >getdate()-1) AND sdate<=getdate() ");
            _sQuery.Append(" AND con_per='" + x_sCon_per.Trim() + "'");
            _sQuery.Append(" AND plan_fee='" + x_sPlan_fee_rs.Trim() + "'");
            _sQuery.Append(" AND normal_rebate_type='" + x_sNormal_rebate_type.Trim() + "'");
            _sQuery.Append(" AND hs_model='" + x_sHsmodel.Trim() + "'");
            _sQuery.Append(" AND (payment='" + x_sPayment.Trim() + "' OR payment='ALL')");
            _sQuery.Append(" ) a WHERE b.active=1 AND a.rebate_gp=b.gp ");
            _sQuery.Append(" AND b.program='" + x_sProgram.Trim() + "'");
            if (!string.IsNullOrEmpty(x_sHs_offer_type_id))
                _sQuery.Append(" AND a.offer_type_id='" + x_sHs_offer_type_id + "' ");

            global::System.Data.SqlClient.SqlDataReader _oReader = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery.ToString());
            if (_oReader != null){
                while (_oReader.Read()){
                    _oOfferList.Add(_oReader[HandSetOfferedBasket.Para.r_offer].ToString());
                    _oRebate_amountList.Add(_oReader[HandSetOfferedBasket.Para.rebate_amount].ToString());
                    _oAmountList.Add(_oReader[HandSetOfferedBasket.Para.amount].ToString());
                    _oExtra_rebateList.Add(_oReader[HandSetOfferedBasket.Para.extra_rebate].ToString());
                    _oExtra_rebate_amountList.Add(_oReader[HandSetOfferedBasket.Para.extra_rebate_amount].ToString());
                    _oOffer_type_idList.Add(_oReader[HandSetOfferedBasket.Para.offer_type_id].ToString());
                }
                if (_oReader != null) _oReader.Close(); _oReader.Dispose();
            }
            _oAllList.Add(HandSetOfferedBasket.Para.r_offer, _oOfferList);
            _oAllList.Add(HandSetOfferedBasket.Para.rebate_amount, _oRebate_amountList);
            _oAllList.Add(HandSetOfferedBasket.Para.amount, _oAmountList);
            _oAllList.Add(HandSetOfferedBasket.Para.extra_rebate, _oExtra_rebateList);
            _oAllList.Add(HandSetOfferedBasket.Para.extra_rebate_amount, _oExtra_rebate_amountList);
            _oAllList.Add(HandSetOfferedBasket.Para.offer_type_id, _oOffer_type_idList);
            return _oAllList;
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

        protected string n_sCon_per = string.Empty;
        #region m_sCon_per
        public string m_sCon_per
        {
            get
            {
                return this.n_sCon_per;
            }
            set
            {
                this.n_sCon_per = value;
            }
        }
        #endregion m_sCon_per


        protected string n_sNormal_rebate_type = string.Empty;
        #region m_sNormal_rebate
        public string m_sNormal_rebate
        {
            get
            {
                return this.n_sNormal_rebate_type;
            }
            set
            {
                this.n_sNormal_rebate_type = value;
            }
        }
        #endregion m_sNormal_rebate


        protected string n_sProgram = string.Empty;
        #region m_sProgram
        public string m_sProgram
        {
            get
            {
                return this.n_sProgram;
            }
            set
            {
                this.n_sProgram = value;
            }
        }
        #endregion m_sProgram


        protected string n_sPayment = string.Empty;
        #region m_sPayment
        public string m_sPayment
        {
            get
            {
                return this.n_sPayment;
            }
            set
            {
                this.n_sPayment = value;
            }
        }
        #endregion m_sPayment


        protected string n_sHs_model = string.Empty;
        #region m_sHs_model
        public string m_sHs_model
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
        #endregion m_sHs_model


        protected string n_sRate_plan = string.Empty;
        #region m_sRate_plan
        public string m_sRate_plan
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


        protected string n_sFree_mon = string.Empty;
        #region m_sFree_mon
        public string m_sFree_mon
        {
            get
            {
                return this.n_sFree_mon;
            }
            set
            {
                this.n_sFree_mon = value;
            }
        }
        #endregion m_sFree_mon


        protected string n_sChannel = string.Empty;
        #region m_sChannel
        public string m_sChannel
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
        #endregion m_sChannel
        
        #region Constructor & Destructor
        public PaymentOfferProfile() { }

        public PaymentOfferProfile(string x_sCon_per, string x_sNormal_rebate_type, string x_sProgram, string x_sPayment, string x_sHs_model, string x_sRate_plan, string x_sFree_mon, string x_sChannel)
        {
            m_sCon_per = x_sCon_per;
            m_sNormal_rebate = x_sNormal_rebate_type;
            m_sProgram = x_sProgram;
            m_sPayment = x_sPayment;
            m_sHs_model = x_sHs_model;
            m_sRate_plan = x_sRate_plan;
            m_sFree_mon = x_sFree_mon;
            m_sChannel = x_sChannel;
        }

        ~PaymentOfferProfile() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public string GetCon_per() { return this.m_sCon_per; }
        public string GetNormal_rebate() { return this.m_sNormal_rebate; }
        public string GetProgram() { return this.m_sProgram; }
        public string GetPayment() { return this.m_sPayment; }
        public string GetHs_model() { return this.m_sHs_model; }
        public string GetRate_plan() { return this.m_sRate_plan; }
        public string GetFree_mon() { return this.m_sFree_mon; }
        public string GetChannel() { return this.m_sChannel; }

        public bool SetCon_per(string value)
        {
            this.m_sCon_per = value;
            return true;
        }
        public bool SetNormal_rebate(string value)
        {
            this.m_sNormal_rebate = value;
            return true;
        }
        public bool SetProgram(string value)
        {
            this.m_sProgram = value;
            return true;
        }
        public bool SetPayment(string value)
        {
            this.m_sPayment = value;
            return true;
        }
        public bool SetHs_model(string value)
        {
            this.m_sHs_model = value;
            return true;
        }
        public bool SetRate_plan(string value)
        {
            this.m_sRate_plan = value;
            return true;
        }
        public bool SetFree_mon(string value)
        {
            this.m_sFree_mon = value;
            return true;
        }
        public bool SetChannel(string value)
        {
            this.m_sChannel = value;
            return true;
        }
        #endregion
        
        #region Equals
        public bool Equals(PaymentOfferProfile x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.m_sCon_per.Equals(x_oObj.m_sCon_per)) { return false; }
            if (!this.m_sNormal_rebate.Equals(x_oObj.m_sNormal_rebate)) { return false; }
            if (!this.m_sProgram.Equals(x_oObj.m_sProgram)) { return false; }
            if (!this.m_sPayment.Equals(x_oObj.m_sPayment)) { return false; }
            if (!this.m_sHs_model.Equals(x_oObj.m_sHs_model)) { return false; }
            if (!this.m_sRate_plan.Equals(x_oObj.m_sRate_plan)) { return false; }
            if (!this.m_sFree_mon.Equals(x_oObj.m_sFree_mon)) { return false; }
            if (!this.m_sChannel.Equals(x_oObj.m_sChannel)) { return false; }
            return true;
        }
        #endregion Equals

        #region Release
        public void Release()
        {
            this.m_sCon_per = string.Empty;
            this.m_sNormal_rebate = string.Empty;
            this.m_sProgram = string.Empty;
            this.m_sPayment = string.Empty;
            this.m_sHs_model = string.Empty;
            this.m_sRate_plan = string.Empty;
            this.m_sFree_mon = string.Empty;
            this.m_sChannel = string.Empty;
        }
        #endregion Release

        #region DeepClone
        public PaymentOfferProfile DeepClone()
        {
            PaymentOfferProfile PaymentOfferProfile_Clone = new PaymentOfferProfile();
            PaymentOfferProfile_Clone.SetCon_per(this.m_sCon_per);
            PaymentOfferProfile_Clone.SetNormal_rebate(this.m_sNormal_rebate);
            PaymentOfferProfile_Clone.SetProgram(this.m_sProgram);
            PaymentOfferProfile_Clone.SetPayment(this.m_sPayment);
            PaymentOfferProfile_Clone.SetHs_model(this.m_sHs_model);
            PaymentOfferProfile_Clone.SetRate_plan(this.m_sRate_plan);
            PaymentOfferProfile_Clone.SetFree_mon(this.m_sFree_mon);
            PaymentOfferProfile_Clone.SetChannel(this.m_sChannel);
            return PaymentOfferProfile_Clone;
        }
        #endregion Clone

    }
}
