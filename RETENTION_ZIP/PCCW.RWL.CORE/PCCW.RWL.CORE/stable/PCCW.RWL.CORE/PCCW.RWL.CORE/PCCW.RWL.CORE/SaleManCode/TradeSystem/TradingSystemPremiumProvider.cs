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
///-- Description:	<Description,Class :[TradingSystemPremiumProvider],Data Relation Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class TradingSystemPremiumProvider
    {
        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
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

        protected string n_sPremium = string.Empty;
        #region m_sPremium
        public string m_sPremium
        {
            get
            {
                return this.n_sPremium;
            }
            set
            {
                this.n_sPremium = value;
            }
        }
        #endregion m_sPremium


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

        #region Constructor + Destructor
        public TradingSystemPremiumProvider() { }

        public TradingSystemPremiumProvider(string x_sCon_per, string x_sNormal_rebate_type, string x_sProgram, string x_sPremium, string x_sHs_model, string x_sRate_plan, string x_sFree_mon, string x_sChannel)
        {
            m_sCon_per = x_sCon_per;
            m_sNormal_rebate = x_sNormal_rebate_type;
            m_sProgram = x_sProgram;
            m_sPremium = x_sPremium;
            m_sHs_model = x_sHs_model;
            m_sRate_plan = x_sRate_plan;
            m_sFree_mon = x_sFree_mon;
            m_sChannel = x_sChannel;
        }

        ~TradingSystemPremiumProvider() { }

        #endregion Constructor + Destructor

        #region Get + Set
        public string GetCon_per() { return this.m_sCon_per; }
        public string GetNormal_rebate() { return this.m_sNormal_rebate; }
        public string GetProgram() { return this.m_sProgram; }
        public string GetPremium() { return this.m_sPremium; }
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
        public bool SetPremium(string value)
        {
            this.m_sPremium = value;
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

        #region Get DB
        protected static MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            _oDB.bWithNoLock = true;
            return _oDB;
        }
        #endregion

        #region Get Plan Fee
        public IQueryable<RetentionPlanEntity> Get_PlanFeeList(string x_sRatePlan)
        {
            if (x_sRatePlan == null) throw new ArgumentNullException("x_sRatePlan");
            RetentionPlanRepositoryBase _oRetentionPlanRepositoryBase = new RetentionPlanRepositoryBase(GetDB());
            IQueryable<RetentionPlanEntity> _oRwlPlanQA = from sRwlPlan in _oRetentionPlanRepositoryBase.RetentionPlans where sRwlPlan.active == true && sRwlPlan.plan_code == x_sRatePlan.Trim() select sRwlPlan;
            return _oRwlPlanQA;
        }
        #endregion

        #region Equals
        public bool Equals(TradingSystemPremiumProvider x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.m_sCon_per.Equals(x_oObj.m_sCon_per)) { return false; }
            if (!this.m_sNormal_rebate.Equals(x_oObj.m_sNormal_rebate)) { return false; }
            if (!this.m_sProgram.Equals(x_oObj.m_sProgram)) { return false; }
            if (!this.m_sPremium.Equals(x_oObj.m_sPremium)) { return false; }
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
            this.m_sPremium = string.Empty;
            this.m_sHs_model = string.Empty;
            this.m_sRate_plan = string.Empty;
            this.m_sFree_mon = string.Empty;
            this.m_sChannel = string.Empty;
        }
        #endregion Release

        #region DeepClone
        public TradingSystemPremiumProvider DeepClone()
        {
            TradingSystemPremiumProvider TradingSystemPremiumProvider_Clone = new TradingSystemPremiumProvider();
            TradingSystemPremiumProvider_Clone.SetCon_per(this.m_sCon_per);
            TradingSystemPremiumProvider_Clone.SetNormal_rebate(this.m_sNormal_rebate);
            TradingSystemPremiumProvider_Clone.SetProgram(this.m_sProgram);
            TradingSystemPremiumProvider_Clone.SetPremium(this.m_sPremium);
            TradingSystemPremiumProvider_Clone.SetHs_model(this.m_sHs_model);
            TradingSystemPremiumProvider_Clone.SetRate_plan(this.m_sRate_plan);
            TradingSystemPremiumProvider_Clone.SetFree_mon(this.m_sFree_mon);
            TradingSystemPremiumProvider_Clone.SetChannel(this.m_sChannel);
            return TradingSystemPremiumProvider_Clone;
        }
        #endregion Clone

    }
}
