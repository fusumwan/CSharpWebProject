using System;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml.Linq;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Xml;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-07-02>
///-- Description:	<Description,Table :[AutoSelectionProperty],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [AutoSelectionProperty] Business layer
    /// </summary>
    
    
    public class AutoSelectionPropertyBals:Collection<AutoSelectionProperty>{}
    public class AutoSelectionPropertyBal: AutoSelectionPropertyBalBase{
        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        string[] n_sDateTimeList = { "dd-MM-yyyy", "d-MM-yyyy", "dd-M-yyyy", "d-M-yyyy hh:mm:ss", "d-MM-yyyy hh:mm:ss", "dd-MMM-yyyy", "d-MMM-yyyy", "dd-MMM-yyyy hh:mm:ss", "d-MMM-yyyy hh:mm:ss" }; 

        #region Parameters
        protected static BusinessTradeRepositoryBase n_oBusinessTradeRepositoryBase = BusinessTradeRepositoryBase.Instance();
        protected int m_iDupRecord = 0;
        protected int m_iErrRecord = 0;
        protected int m_iSuccessIn = 0;
        protected string m_sNotEqualPlanFee = string.Empty;
        protected string m_sNoFindMid = string.Empty;
        #endregion

        TierExcelPara m_oTierExcelPara = new TierExcelPara();
        TierViewControl m_oTierViewControl = TierViewControl.Instance();
        
        #region Upload Tier Excel
        public bool UploadTierExcel(global::System.Data.DataSet x_oDs){
           
            return true;
        }
        #endregion

        #region Set Error Record
        private void SetErrorRecord(AutoSelectionProperty x_oAutoSelectionProperty, BusinessTrade x_oBusinessTrade)
        {
            TierViewItem _oTierViewItem = new TierViewItem();
            _oTierViewItem.SetAutoSelectionProperty(x_oAutoSelectionProperty);
            _oTierViewItem.SetBusinessTrade(x_oBusinessTrade);
            _oTierViewItem.SetErrorRecord(true);
            m_oTierViewControl.GetErrRecord().Add(_oTierViewItem);
            m_iErrRecord += 1;

        }
        #endregion

        #region Convert To Tier SelecionItem
        public TierSelectionItem ConvertToTierSelecionItem(AutoSelectionProperty x_oAutoSelectionProperty)
        {
            TierSelectionItem _oTierSelectionItem = new TierSelectionItem();
            BusinessTrade _oBusinessTrade = x_oAutoSelectionProperty.GetBusinessTradeAutoSelectionProperty();
            if (_oBusinessTrade.GetFound())
            {
                _oTierSelectionItem.SetPeriod(x_oAutoSelectionProperty.GetPeriod().Trim());
                _oTierSelectionItem.SetObprogram(x_oAutoSelectionProperty.GetObprogram().Trim());
                _oTierSelectionItem.SetTradefield_mid((int)x_oAutoSelectionProperty.GetTradefield_mid());
                _oTierSelectionItem.SetTier(x_oAutoSelectionProperty.GetTier().Trim());
                _oTierSelectionItem.SetStart_date(x_oAutoSelectionProperty.GetStart_date());
                _oTierSelectionItem.SetEnd_date(x_oAutoSelectionProperty.GetEnd_date());
                _oTierSelectionItem.SetPo_date(x_oAutoSelectionProperty.GetPo_date());
                if (_oBusinessTrade != null)
                {
                    if(_oBusinessTrade.GetActive()!=null)
                        _oTierSelectionItem.SetActive((bool)_oBusinessTrade.GetActive());
                    _oTierSelectionItem.SetBundle_name(_oBusinessTrade.GetBundle_name().Trim());
                    if (_oBusinessTrade.GetCancel_renew()!=null)
                        _oTierSelectionItem.SetCancel_renew((bool)_oBusinessTrade.GetCancel_renew());
                    _oTierSelectionItem.SetCdate(_oBusinessTrade.GetCdate());
                    _oTierSelectionItem.SetChannel(_oBusinessTrade.GetChannel().Trim());
                    _oTierSelectionItem.SetCid(_oBusinessTrade.GetCid().Trim());
                    _oTierSelectionItem.SetCon_per(_oBusinessTrade.GetCon_per().Trim());
                    _oTierSelectionItem.SetDdate(_oBusinessTrade.GetDdate());
                    _oTierSelectionItem.SetDid(_oBusinessTrade.GetDid().Trim());
                    _oTierSelectionItem.SetEdate(_oBusinessTrade.GetEdate());
                    _oTierSelectionItem.SetExtra_offer(_oBusinessTrade.GetExtra_offer().Trim());
                    _oTierSelectionItem.SetFree_mon(_oBusinessTrade.GetFree_mon().Trim());
                    _oTierSelectionItem.SetHs_model(_oBusinessTrade.GetHs_model().Trim());

                    if(_oBusinessTrade.GetNormal_rebate()!=null)
                        _oTierSelectionItem.SetNormal_rebate((bool)_oBusinessTrade.GetNormal_rebate());
                    _oTierSelectionItem.SetOb_early(_oBusinessTrade.GetOb_early().Trim());
                    _oTierSelectionItem.SetPlan_fee(_oBusinessTrade.GetPlan_fee().Trim());

                    _oTierSelectionItem.SetPremium_1(_oBusinessTrade.GetPremium_1().Trim());
                    _oTierSelectionItem.SetPremium_2(_oBusinessTrade.GetPremium_2().Trim());
                    _oTierSelectionItem.SetProgram(_oBusinessTrade.GetProgram().Trim());
                    _oTierSelectionItem.SetRate_plan(_oBusinessTrade.GetRate_plan().Trim());
                    _oTierSelectionItem.SetRebate(_oBusinessTrade.GetRebate().Trim());
                    _oTierSelectionItem.SetRemarks(_oBusinessTrade.GetRemarks().Trim());
                    _oTierSelectionItem.SetRetention_type(_oBusinessTrade.GetRetention_type().Trim());
                    _oTierSelectionItem.SetSdate(_oBusinessTrade.GetSdate());
                    _oTierSelectionItem.SetTrade_field(_oBusinessTrade.GetTrade_field().Trim());
                    _oTierSelectionItem.SetBundle_name(_oBusinessTrade.GetBundle_name().Trim());
                }
                _oTierSelectionItem.SetAutoSelectionProperty(x_oAutoSelectionProperty);
                _oTierSelectionItem.SetBusinessTrade(_oBusinessTrade);
            }
            return _oTierSelectionItem;
        }
        #endregion

        #region Con_per_Premium_ch
        protected void Con_per_Premium_ch(ref TierSelectionItem x_oTierSelectionItem, ref Rwl_offerchk x_oRwl_offerchk)
        {
            
        }
        #endregion

        #region Con_per_TradeField_ch
        protected void Con_per_TradeField_ch(ref TierSelectionItem x_oTierSelectionItem, ref Rwl_offerchk x_oRwl_offerchk)
        {
            
        }
        #endregion

        #region Con_per_BundleName_ch
        protected void Con_per_BundleName_ch(ref TierSelectionItem x_oTierSelectionItem, ref Rwl_offerchk x_oRwl_offerchk)
        {
 
        }
        #endregion

        #region Con_per_Rebate_ch
        protected void Con_per_Rebate_ch(ref TierSelectionItem x_oTierSelectionItem, ref Rwl_offerchk x_oRwl_offerchk)
        {
            
        }
        #endregion

        #region Con_per_Free_ch
        protected void Con_per_Free_ch(ref TierSelectionItem x_oTierSelectionItem, ref Rwl_offerchk x_oRwl_offerchk)
        {
           
        }
        #endregion

        #region Con_per_SPremium
        protected void Con_per_SPremium(ref TierSelectionItem x_oTierSelectionItem, ref Rwl_offerchk x_oRwl_offerchk)
        {
           
        }
        #endregion

        #region Con_per_HandSet
        protected void Con_per_HandSet(ref TierSelectionItem x_oTierSelectionItem, ref Rwl_offerchk x_oRwl_offerchk)
        {
           
        }
        #endregion

        #region bChkTierExcelTitle
        public bool bChkTierExcelTitle(DataSet x_oDs)
        {
            return true;
        }
        #endregion

        #region DuplicateRecord
        public bool bDuplicateRecord(AutoSelectionProperty x_oAutoSelectionProperty)
        {
 
            return false;
        }
        #endregion

        #region bChkProgramField
        public bool bChkProgramField(string x_sProgram)
        {
                return false;
        }
        #endregion

        #region bChkRatePlanField
        public bool bChkRatePlanField(ref TierSelectionItem x_oTierSelectionItem, string x_sProgram, string x_sNormal_rebate, string x_sChannel)
        {
               return false;
        }
        #endregion

        #region GetDB
        public static MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.bWithNoLock = true;
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return _oDB;
        }
        #endregion

        public int GetDupRecord()
        {
            return this.m_iDupRecord;
        }

        public int GetErrRecord()
        {
            return this.m_iErrRecord;
        }

        public int GetSuccessIn()
        {
            return this.m_iSuccessIn;
        }

        public string GetNotEqualPlanFee()
        {
            return this.m_sNotEqualPlanFee;
        }

        public string GetNoFindMid()
        {
            return this.m_sNoFindMid;
        }

        #region Rwl_offerchk Class
        public class Rwl_offerchk
        {

            protected bool n_bSPremium = false;
            #region m_bSPremium
            public bool m_bSPremium
            {
                get
                {
                    return this.n_bSPremium;
                }
                set
                {
                    this.n_bSPremium = value;
                }
            }
            #endregion m_bSPremium


            protected bool n_bExtra_rebate = false;
            #region m_bExtra_rebate
            public bool m_bExtra_rebate
            {
                get
                {
                    return this.n_bExtra_rebate;
                }
                set
                {
                    this.n_bExtra_rebate = value;
                }
            }
            #endregion m_bExtra_rebate


            protected bool n_bBundle = false;
            #region m_bBundle
            public bool m_bBundle
            {
                get
                {
                    return this.n_bBundle;
                }
                set
                {
                    this.n_bBundle = value;
                }
            }
            #endregion m_bBundle


            protected bool n_bHandSet = false;
            #region m_bHandSet
            public bool m_bHandSet
            {
                get
                {
                    return this.n_bHandSet;
                }
                set
                {
                    this.n_bHandSet = value;
                }
            }
            #endregion m_bHandSet


            protected bool n_bRebate = false;
            #region m_bRebate
            public bool m_bRebate
            {
                get
                {
                    return this.n_bRebate;
                }
                set
                {
                    this.n_bRebate = value;
                }
            }
            #endregion m_bRebate


            protected bool n_bAmount = false;
            #region m_bAmount
            public bool m_bAmount
            {
                get
                {
                    return this.n_bAmount;
                }
                set
                {
                    this.n_bAmount = value;
                }
            }
            #endregion m_bAmount


            protected bool n_bExtra_rebate_amount = false;
            #region m_bExtra_rebate_amount
            public bool m_bExtra_rebate_amount
            {
                get
                {
                    return this.n_bExtra_rebate_amount;
                }
                set
                {
                    this.n_bExtra_rebate_amount = value;
                }
            }
            #endregion m_bExtra_rebate_amount


            protected bool n_bFlag = false;
            #region m_bFlag
            public bool m_bFlag
            {
                get
                {
                    return this.n_bFlag;
                }
                set
                {
                    this.n_bFlag = value;
                }
            }
            #endregion m_bFlag


            protected string n_sSku = string.Empty;
            #region m_sSku
            public string m_sSku
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
            #endregion m_sSku


            protected bool n_bRebate_amount = false;
            #region m_bRebate_amount
            public bool m_bRebate_amount
            {
                get
                {
                    return this.n_bRebate_amount;
                }
                set
                {
                    this.n_bRebate_amount = value;
                }
            }
            #endregion m_bRebate_amount


            protected bool n_bFreeMon = false;
            #region m_bFreeMon
            public bool m_bFreeMon
            {
                get
                {
                    return this.n_bFreeMon;
                }
                set
                {
                    this.n_bFreeMon = value;
                }
            }
            #endregion m_bFreeMon


            protected bool n_bTradeField = false;
            #region m_bTradeField
            public bool m_bTradeField
            {
                get
                {
                    return this.n_bTradeField;
                }
                set
                {
                    this.n_bTradeField = value;
                }
            }
            #endregion m_bTradeField


            protected string n_sNormal_rebate_selected = string.Empty;
            #region m_sNormal_rebate_selected
            public string m_sNormal_rebate_selected
            {
                get
                {
                    return this.n_sNormal_rebate_selected;
                }
                set
                {
                    this.n_sNormal_rebate_selected = value;
                }
            }
            #endregion m_sNormal_rebate_selected


            protected bool n_bR_offer = false;
            #region m_bR_offer
            public bool m_bR_offer
            {
                get
                {
                    return this.n_bR_offer;
                }
                set
                {
                    this.n_bR_offer = value;
                }
            }
            #endregion m_bR_offer


            protected bool n_bPremium = false;
            #region m_bPremium
            public bool m_bPremium
            {
                get
                {
                    return this.n_bPremium;
                }
                set
                {
                    this.n_bPremium = value;
                }
            }
            #endregion m_bPremium


            protected string n_sAmount = string.Empty;
            #region m_sAmount
            public string m_sAmount
            {
                get
                {
                    return this.n_sAmount;
                }
                set
                {
                    this.n_sAmount = value;
                }
            }
            #endregion m_sAmount


            #region Constructor & Destructor
            public Rwl_offerchk() { }

            public Rwl_offerchk(bool x_bSPremium, bool x_bExtra_rebate, bool x_bBundle, bool x_bHandSet, bool x_bRebate, bool x_bAmount, bool x_bExtra_rebate_amount, bool x_bFlag, string x_sSku, bool x_bRebate_amount, bool x_bFreeMon, bool x_bTradeField, string x_sNormal_rebate_selected, bool x_bR_offer, bool x_bPremium, string x_sAmount)
            {
                m_bSPremium = x_bSPremium;
                m_bExtra_rebate = x_bExtra_rebate;
                m_bBundle = x_bBundle;
                m_bHandSet = x_bHandSet;
                m_bRebate = x_bRebate;
                m_bAmount = x_bAmount;
                m_bExtra_rebate_amount = x_bExtra_rebate_amount;
                m_bFlag = x_bFlag;
                m_sSku = x_sSku;
                m_bRebate_amount = x_bRebate_amount;
                m_bFreeMon = x_bFreeMon;
                m_bTradeField = x_bTradeField;
                m_sNormal_rebate_selected = x_sNormal_rebate_selected;
                m_bR_offer = x_bR_offer;
                m_bPremium = x_bPremium;
                m_sAmount = x_sAmount;
            }

            ~Rwl_offerchk() { }

            #endregion Constructor & Destructor

            #region Get & Set
            public bool GetSPremium() { return this.m_bSPremium; }
            public bool GetExtra_rebate() { return this.m_bExtra_rebate; }
            public bool GetBundle() { return this.m_bBundle; }
            public bool GetHandSet() { return this.m_bHandSet; }
            public bool GetRebate() { return this.m_bRebate; }
            public string GetAmount() { return this.m_sAmount; }
            public bool GetExtra_rebate_amount() { return this.m_bExtra_rebate_amount; }
            public bool GetFlag() { return this.m_bFlag; }
            public string GetSku() { return this.m_sSku; }
            public bool GetRebate_amount() { return this.m_bRebate_amount; }
            public bool GetFreeMon() { return this.m_bFreeMon; }
            public bool GetTradeField() { return this.m_bTradeField; }
            public string GetNormal_rebate_selected() { return this.m_sNormal_rebate_selected; }
            public bool GetR_offer() { return this.m_bR_offer; }
            public bool GetPremium() { return this.m_bPremium; }
            public bool GetbAmount() { return this.m_bAmount; }

            public bool SetSPremium(bool value)
            {
                this.m_bSPremium = value;
                return true;
            }
            public bool SetExtra_rebate(bool value)
            {
                this.m_bExtra_rebate = value;
                return true;
            }
            public bool SetBundle(bool value)
            {
                this.m_bBundle = value;
                return true;
            }
            public bool SetHandSet(bool value)
            {
                this.m_bHandSet = value;
                return true;
            }
            public bool SetRebate(bool value)
            {
                this.m_bRebate = value;
                return true;
            }
            public bool SetbAmount(bool value)
            {
                this.m_bAmount = value;
                return true;
            }
            public bool SetExtra_rebate_amount(bool value)
            {
                this.m_bExtra_rebate_amount = value;
                return true;
            }
            public bool SetFlag(bool value)
            {
                this.m_bFlag = value;
                return true;
            }
            public bool SetSku(string value)
            {
                this.m_sSku = value;
                return true;
            }
            public bool SetRebate_amount(bool value)
            {
                this.m_bRebate_amount = value;
                return true;
            }
            public bool SetFreeMon(bool value)
            {
                this.m_bFreeMon = value;
                return true;
            }
            public bool SetTradeField(bool value)
            {
                this.m_bTradeField = value;
                return true;
            }
            public bool SetNormal_rebate_selected(string value)
            {
                this.m_sNormal_rebate_selected = value;
                return true;
            }
            public bool SetR_offer(bool value)
            {
                this.m_bR_offer = value;
                return true;
            }
            public bool SetPremium(bool value)
            {
                this.m_bPremium = value;
                return true;
            }
            public bool SetAmount(string value)
            {
                this.m_sAmount = value;
                return true;
            }
            #endregion

            #region ResultFlag
            public bool ResultFlag()
            {
                if (GetFlag())
                {
                    if (GetPremium() && (!GetTradeField() || !GetBundle()))
                        SetFlag(false);
                    else
                        SetFlag(true);
                }

                if (GetFlag())
                {
                    if (GetSPremium() && (!GetTradeField() || !GetBundle()))
                        SetFlag(false);
                    else
                        SetFlag(true);
                }

                if (GetFlag())
                {
                    if (GetHandSet() && (!GetTradeField() || !GetBundle()))
                        SetFlag(false);
                    else
                        SetFlag(true);
                }
                if (GetFlag())
                {
                    if (GetRebate() && (!GetTradeField() || !GetBundle()))
                        SetFlag(false);
                    else
                        SetFlag(true);
                }
                return this.m_bFlag;
            }
            #endregion

            #region Equals
            public bool Equals(Rwl_offerchk x_oObj)
            {
                if (x_oObj == null) { return false; }
                if (!this.m_bSPremium.Equals(x_oObj.m_bSPremium)) { return false; }
                if (!this.m_bExtra_rebate.Equals(x_oObj.m_bExtra_rebate)) { return false; }
                if (!this.m_bBundle.Equals(x_oObj.m_bBundle)) { return false; }
                if (!this.m_bHandSet.Equals(x_oObj.m_bHandSet)) { return false; }
                if (!this.m_bRebate.Equals(x_oObj.m_bRebate)) { return false; }
                if (!this.m_bAmount.Equals(x_oObj.m_bAmount)) { return false; }
                if (!this.m_bExtra_rebate_amount.Equals(x_oObj.m_bExtra_rebate_amount)) { return false; }
                if (!this.m_bFlag.Equals(x_oObj.m_bFlag)) { return false; }
                if (!this.m_sSku.Equals(x_oObj.m_sSku)) { return false; }
                if (!this.m_bRebate_amount.Equals(x_oObj.m_bRebate_amount)) { return false; }
                if (!this.m_bFreeMon.Equals(x_oObj.m_bFreeMon)) { return false; }
                if (!this.m_bTradeField.Equals(x_oObj.m_bTradeField)) { return false; }
                if (!this.m_sNormal_rebate_selected.Equals(x_oObj.m_sNormal_rebate_selected)) { return false; }
                if (!this.m_bR_offer.Equals(x_oObj.m_bR_offer)) { return false; }
                if (!this.m_bPremium.Equals(x_oObj.m_bPremium)) { return false; }
                if (!this.m_sAmount.Equals(x_oObj.m_sAmount)) { return false; }
                return true;
            }
            #endregion Equals

            #region Release
            public void Release()
            {
                this.m_bSPremium = false;
                this.m_bExtra_rebate = false;
                this.m_bBundle = false;
                this.m_bHandSet = false;
                this.m_bRebate = false;
                this.m_bAmount = false;
                this.m_bExtra_rebate_amount = false;
                this.m_bFlag = false;
                this.m_sSku = string.Empty;
                this.m_bRebate_amount = false;
                this.m_bFreeMon = false;
                this.m_bTradeField = false;
                this.m_sNormal_rebate_selected = string.Empty;
                this.m_bR_offer = false;
                this.m_bPremium = false;
                this.m_sAmount = string.Empty;
            }
            #endregion Release

            #region DeepClone
            public Rwl_offerchk DeepClone()
            {
                Rwl_offerchk Rwl_offerchk_Clone = new Rwl_offerchk();
                Rwl_offerchk_Clone.SetSPremium(this.m_bSPremium);
                Rwl_offerchk_Clone.SetExtra_rebate(this.m_bExtra_rebate);
                Rwl_offerchk_Clone.SetBundle(this.m_bBundle);
                Rwl_offerchk_Clone.SetHandSet(this.m_bHandSet);
                Rwl_offerchk_Clone.SetRebate(this.m_bRebate);
                Rwl_offerchk_Clone.SetbAmount(this.m_bAmount);
                Rwl_offerchk_Clone.SetExtra_rebate_amount(this.m_bExtra_rebate_amount);
                Rwl_offerchk_Clone.SetFlag(this.m_bFlag);
                Rwl_offerchk_Clone.SetSku(this.m_sSku);
                Rwl_offerchk_Clone.SetRebate_amount(this.m_bRebate_amount);
                Rwl_offerchk_Clone.SetFreeMon(this.m_bFreeMon);
                Rwl_offerchk_Clone.SetTradeField(this.m_bTradeField);
                Rwl_offerchk_Clone.SetNormal_rebate_selected(this.m_sNormal_rebate_selected);
                Rwl_offerchk_Clone.SetR_offer(this.m_bR_offer);
                Rwl_offerchk_Clone.SetPremium(this.m_bPremium);
                Rwl_offerchk_Clone.SetAmount(this.m_sAmount);
                return Rwl_offerchk_Clone;
            }
            #endregion Clone
        }
        #endregion

        #region Constructor
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public AutoSelectionPropertyBal() : base(){
        }
        ~AutoSelectionPropertyBal(){
            base.Release();
        }
        #endregion

        
        
    }
}


