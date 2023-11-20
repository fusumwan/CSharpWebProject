using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.Xml;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-02-03>
///-- Description:	<Description,Class :TierSelectionItem, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class TierSelectionItem : IDisposable
    {

        #region Get NormalRebate Selected Value
        public static string Get_NormalRebateSelectedValue(Nullable<bool> x_bNormalRebate, string x_sRetenion_type)
        {
            return Get_NormalRebateSelectedValueProc(x_bNormalRebate, x_sRetenion_type);
        }

        public string Get_NormalRebateSelectedValue()
        {
            return Get_NormalRebateSelectedValueProc(this.GetNormal_rebate(), this.GetRetention_type());
        }

        protected static string Get_NormalRebateSelectedValueProc(Nullable<bool> x_bNormalRebate, string x_sRetenion_type)
        {
            if (x_bNormalRebate == null) return string.Empty;
            if (x_bNormalRebate == false && x_sRetenion_type == "0")
                return "N";
            else if (x_bNormalRebate == false && x_sRetenion_type == "2")
                return "L";
            else if (x_bNormalRebate == false && x_sRetenion_type == "3")
                return "S";
            else if (x_bNormalRebate == false && x_sRetenion_type == "4")
                return "T";
            else if (x_bNormalRebate == false && x_sRetenion_type == "5")
                return "O";
            else if (x_bNormalRebate == false && x_sRetenion_type == "6")
                return "M";
            else
                return "Y";
        }
        #endregion

        #region Get NormalRebate Type Str
        public static string Get_NormalRebate_Type_Str(bool x_bNormalRebate, string x_sRetention_type)
        {
            if (x_bNormalRebate == false && x_sRetention_type == "0")
                return "N";
            else if (x_bNormalRebate == false && x_sRetention_type == "2")
                return "L";
            else if (x_bNormalRebate == false && x_sRetention_type == "3")
                return "S";
            else if (x_bNormalRebate == false && x_sRetention_type == "4")
                return "T";
            else if (x_bNormalRebate == false && x_sRetention_type == "5")
                return "O";
            else if (x_bNormalRebate == false && x_sRetention_type == "6")
                return "M";
            else if (x_bNormalRebate == true && x_sRetention_type == "1")
                return string.Empty;


            return string.Empty;
        }
        #endregion

        #region Set NormalRebate Retenion Type
        public static void Set_NormalRebate_Retenion_type(string x_sType, out bool x_bNormalRebate, out string x_sRetenion_type)
        {
            if ("N".Equals(x_sType))
            {
                x_bNormalRebate = false;
                x_sRetenion_type = "0";
            }
            else if ("L".Equals(x_sType))
            {
                x_bNormalRebate = false;
                x_sRetenion_type = "2";
            }
            else if ("S".Equals(x_sType))
            {
                x_bNormalRebate = false;
                x_sRetenion_type = "3";
            }
            else if ("T".Equals(x_sType))
            {
                x_bNormalRebate = false;
                x_sRetenion_type = "4";
            }
            else if ("O".Equals(x_sType))
            {
                x_bNormalRebate = false;
                x_sRetenion_type = "5";
            }
            else if ("M".Equals(x_sType))
            {
                x_bNormalRebate = false;
                x_sRetenion_type = "6";
            }
            else
            {
                x_bNormalRebate = true;
                x_sRetenion_type = "1";
            }
        }
        #endregion


        protected AutoSelectionProperty n_oAutoSelectionProperty = null;
        #region m_oCdate
        public AutoSelectionProperty m_oAutoSelectionProperty
        {
            get
            {
                return this.n_oAutoSelectionProperty;
            }
            set
            {
                this.n_oAutoSelectionProperty = value;
            }
        }
        #endregion


        protected BusinessTrade n_oBusinessTrade =null;
        #region m_oBusinessTrade
        public BusinessTrade m_oBusinessTrade
        {
            get
            {
                return this.n_oBusinessTrade;
            }
            set
            {
                this.n_oBusinessTrade = value;
            }

        }
        #endregion


        protected global::System.Nullable<DateTime> n_dCdate = null;
        #region m_dCdate
        public global::System.Nullable<DateTime> m_dCdate
        {
            get
            {
                return this.n_dCdate;
            }
            set
            {
                this.n_dCdate = value;
            }
        }
        #endregion m_dCdate


        protected int n_iTradefield_mid = -1;
        #region m_iTradefield_mid
        public int m_iTradefield_mid
        {
            get
            {
                return this.n_iTradefield_mid;
            }
            set
            {
                this.n_iTradefield_mid = value;
            }
        }
        #endregion m_sTradefield_mid


        protected global::System.Nullable<DateTime> n_dStart_date = null;
        #region m_dStart_date
        public global::System.Nullable<DateTime> m_dStart_date
        {
            get
            {
                return this.n_dStart_date;
            }
            set
            {
                this.n_dStart_date = value;
            }
        }
        #endregion m_dStart_date


        protected string n_sCid = string.Empty;
        #region m_sCid
        public string m_sCid
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


        protected string n_sRetention_type = string.Empty;
        #region m_sRetention_type
        public string m_sRetention_type
        {
            get
            {
                return this.n_sRetention_type;
            }
            set
            {
                this.n_sRetention_type = value;
            }
        }
        #endregion m_sRetention_type


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


        protected string n_sExtra_offer = string.Empty;
        #region m_sExtra_offer
        public string m_sExtra_offer
        {
            get
            {
                return this.n_sExtra_offer;
            }
            set
            {
                this.n_sExtra_offer = value;
            }
        }
        #endregion m_sExtra_offer


        protected string n_sDid = string.Empty;
        #region m_sDid
        public string m_sDid
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


        protected string n_sTier = string.Empty;
        #region m_sTier
        public string m_sTier
        {
            get
            {
                return this.n_sTier;
            }
            set
            {
                this.n_sTier = value;
            }
        }
        #endregion m_sTier


        protected string n_sExtra_rebate_amount = string.Empty;
        #region m_sExtra_rebate_amount
        public string m_sExtra_rebate_amount
        {
            get
            {
                return this.n_sExtra_rebate_amount;
            }
            set
            {
                this.n_sExtra_rebate_amount = value;
            }
        }
        #endregion m_sExtra_rebate_amount


        protected global::System.Nullable<DateTime> n_dSdate = null;
        #region m_dSdate
        public global::System.Nullable<DateTime> m_dSdate
        {
            get
            {
                return this.n_dSdate;
            }
            set
            {
                this.n_dSdate = value;
            }
        }
        #endregion m_dSdate


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


        protected string n_sRebate = string.Empty;
        #region m_sRebate
        public string m_sRebate
        {
            get
            {
                return this.n_sRebate;
            }
            set
            {
                this.n_sRebate = value;
            }
        }
        #endregion m_sRebate


        protected string n_sPlan_fee = string.Empty;
        #region m_sPlan_fee
        public string m_sPlan_fee
        {
            get
            {
                return this.n_sPlan_fee;
            }
            set
            {
                this.n_sPlan_fee = value;
            }
        }
        #endregion m_sPlan_fee


        protected string n_sTrade_field = string.Empty;
        #region m_sTrade_field
        public string m_sTrade_field
        {
            get
            {
                return this.n_sTrade_field;
            }
            set
            {
                this.n_sTrade_field = value;
            }
        }
        #endregion m_sTrade_field


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


        protected bool n_bActive = false;
        #region m_bActive
        public bool m_bActive
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


        protected string n_sPeriod = string.Empty;
        #region m_sPeriod
        public string m_sPeriod
        {
            get
            {
                return this.n_sPeriod;
            }
            set
            {
                this.n_sPeriod = value;
            }
        }
        #endregion m_sPeriod


        protected global::System.Nullable<DateTime> n_dEdate = null;
        #region m_dEdate
        public global::System.Nullable<DateTime> m_dEdate
        {
            get
            {
                return this.n_dEdate;
            }
            set
            {
                this.n_dEdate = value;
            }
        }
        #endregion m_dEdate


        protected string n_sRemarks = string.Empty;
        #region m_sRemarks
        public string m_sRemarks
        {
            get
            {
                return this.n_sRemarks;
            }
            set
            {
                this.n_sRemarks = value;
            }
        }
        #endregion m_sRemarks


        protected string n_sPremium_1 = string.Empty;
        #region m_sPremium_1
        public string m_sPremium_1
        {
            get
            {
                return this.n_sPremium_1;
            }
            set
            {
                this.n_sPremium_1 = value;
            }
        }
        #endregion m_sPremium_1


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


        protected string n_sRebate_amount = string.Empty;
        #region m_sRebate_amount
        public string m_sRebate_amount
        {
            get
            {
                return this.n_sRebate_amount;
            }
            set
            {
                this.n_sRebate_amount = value;
            }
        }
        #endregion m_sRebate_amount


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


        protected string n_sObprogram = string.Empty;
        #region m_sObprogram
        public string m_sObprogram
        {
            get
            {
                return this.n_sObprogram;
            }
            set
            {
                this.n_sObprogram = value;
            }
        }
        #endregion m_sObprogram


        protected string n_sBundle_name = string.Empty;
        #region m_sBundle_name
        public string m_sBundle_name
        {
            get
            {
                return this.n_sBundle_name;
            }
            set
            {
                this.n_sBundle_name = value;
            }
        }
        #endregion m_sBundle_name


        protected global::System.Nullable<DateTime> n_dEnd_date = null;
        #region m_dEnd_date
        public global::System.Nullable<DateTime> m_dEnd_date
        {
            get
            {
                return this.n_dEnd_date;
            }
            set
            {
                this.n_dEnd_date = value;
            }
        }
        #endregion m_dEnd_date


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


        protected string n_sPremium_2 = string.Empty;
        #region m_sPremium_2
        public string m_sPremium_2
        {
            get
            {
                return this.n_sPremium_2;
            }
            set
            {
                this.n_sPremium_2 = value;
            }
        }
        #endregion m_sPremium_2


        protected bool n_bNormal_rebate = false;
        #region m_bNormal_rebate
        public bool m_bNormal_rebate
        {
            get
            {
                return this.n_bNormal_rebate;
            }
            set
            {
                this.n_bNormal_rebate = value;
            }
        }
        #endregion m_bNormal_rebate


        protected string n_sOb_early = string.Empty;
        #region m_sOb_early
        public string m_sOb_early
        {
            get
            {
                return this.n_sOb_early;
            }
            set
            {
                this.n_sOb_early = value;
            }
        }
        #endregion m_sOb_early


        protected bool n_bCancel_renew = false;
        #region m_bCancel_renew
        public bool m_bCancel_renew
        {
            get
            {
                return this.n_bCancel_renew;
            }
            set
            {
                this.n_bCancel_renew = value;
            }
        }
        #endregion m_bCancel_renew


        protected global::System.Nullable<DateTime> n_dPo_date = null;
        #region m_dPo_date
        public global::System.Nullable<DateTime> m_dPo_date
        {
            get
            {
                return this.n_dPo_date;
            }
            set
            {
                this.n_dPo_date = value;
            }
        }
        #endregion m_dPo_date


        protected string n_sR_offer = string.Empty;
        #region m_sR_offer
        public string m_sR_offer
        {
            get
            {
                return this.n_sR_offer;
            }
            set
            {
                this.n_sR_offer = value;
            }
        }
        #endregion m_sR_offer


        protected global::System.Nullable<DateTime> n_dDdate = null;
        #region m_dDdate
        public global::System.Nullable<DateTime> m_dDdate
        {
            get
            {
                return this.n_dDdate;
            }
            set
            {
                this.n_dDdate = value;
            }
        }
        #endregion m_dDdate


        protected string n_sExtra_rebate = string.Empty;
        #region m_sExtra_rebate
        public string m_sExtra_rebate
        {
            get
            {
                return this.n_sExtra_rebate;
            }
            set
            {
                this.n_sExtra_rebate = value;
            }
        }
        #endregion m_sExtra_rebate


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


        #region Constructor & Destructor
        public TierSelectionItem() { }

        public TierSelectionItem(AutoSelectionProperty x_oAutoSelectionProperty,BusinessTrade x_oBusinessTrade,  global::System.Nullable<DateTime> x_dCdate, int x_iTradefield_mid, System.Nullable<DateTime> x_dStart_date, string x_sCid, string x_sRetention_type, string x_sHs_model, string x_sExtra_offer, string x_sDid, string x_sTier, string x_sExtra_rebate_amount, System.Nullable<DateTime> x_dSdate, string x_sFree_mon, string x_sRebate, string x_sPlan_fee, string x_sTrade_field, string x_sChannel, bool x_bActive, string x_sPeriod, System.Nullable<DateTime> x_dEdate, string x_sRemarks, string x_sPremium_1, string x_sCon_per, string x_sRebate_amount, string x_sAmount, string x_sObprogram, string x_sBundle_name, System.Nullable<DateTime> x_dEnd_date, string x_sRate_plan, string x_sPremium_2, bool x_bNormal_rebate, string x_sOb_early, bool x_bCancel_renew, System.Nullable<DateTime> x_dPo_date, string x_sR_offer, System.Nullable<DateTime> x_dDdate, string x_sExtra_rebate, string x_sProgram)
        {
            m_oAutoSelectionProperty = x_oAutoSelectionProperty;
            x_oBusinessTrade = x_oBusinessTrade;
            m_dCdate = x_dCdate;
            m_iTradefield_mid = x_iTradefield_mid;
            m_dStart_date = x_dStart_date;
            m_sCid = x_sCid;
            m_sRetention_type = x_sRetention_type;
            m_sHs_model = x_sHs_model;
            m_sExtra_offer = x_sExtra_offer;
            m_sDid = x_sDid;
            m_sTier = x_sTier;
            m_sExtra_rebate_amount = x_sExtra_rebate_amount;
            m_dSdate = x_dSdate;
            m_sFree_mon = x_sFree_mon;
            m_sRebate = x_sRebate;
            m_sPlan_fee = x_sPlan_fee;
            m_sTrade_field = x_sTrade_field;
            m_sChannel = x_sChannel;
            m_bActive = x_bActive;
            m_sPeriod = x_sPeriod;
            m_dEdate = x_dEdate;
            m_sRemarks = x_sRemarks;
            m_sPremium_1 = x_sPremium_1;
            m_sCon_per = x_sCon_per;
            m_sRebate_amount = x_sRebate_amount;
            m_sAmount = x_sAmount;
            m_sObprogram = x_sObprogram;
            m_sBundle_name = x_sBundle_name;
            m_dEnd_date = x_dEnd_date;
            m_sRate_plan = x_sRate_plan;
            m_sPremium_2 = x_sPremium_2;
            m_bNormal_rebate = x_bNormal_rebate;
            m_sOb_early = x_sOb_early;
            m_bCancel_renew = x_bCancel_renew;
            m_dPo_date = x_dPo_date;
            m_sR_offer = x_sR_offer;
            m_dDdate = x_dDdate;
            m_sExtra_rebate = x_sExtra_rebate;
            m_sProgram = x_sProgram;
        }

        ~TierSelectionItem() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public AutoSelectionProperty GetAutoSelectionProperty() { return this.m_oAutoSelectionProperty; }
        public BusinessTrade GetBusinessTrade() { return this.m_oBusinessTrade; }
        public global::System.Nullable<DateTime> GetCdate() { return this.m_dCdate; }
        public int GetTradefield_mid() { return this.m_iTradefield_mid; }
        public global::System.Nullable<DateTime> GetStart_date() { return this.m_dStart_date; }
        public string GetCid() { return this.m_sCid; }
        public string GetRetention_type() { return this.m_sRetention_type; }
        public string GetHs_model() { return this.m_sHs_model; }
        public string GetExtra_offer() { return this.m_sExtra_offer; }
        public string GetDid() { return this.m_sDid; }
        public string GetTier() { return this.m_sTier; }
        public string GetExtra_rebate_amount() { return this.m_sExtra_rebate_amount; }
        public global::System.Nullable<DateTime> GetSdate() { return this.m_dSdate; }
        public string GetFree_mon() { return this.m_sFree_mon; }
        public string GetRebate() { return this.m_sRebate; }
        public string GetPlan_fee() { return this.m_sPlan_fee; }
        public string GetTrade_field() { return this.m_sTrade_field; }
        public string GetChannel() { return this.m_sChannel; }
        public bool GetActive() { return this.m_bActive; }
        public string GetPeriod() { return this.m_sPeriod; }
        public global::System.Nullable<DateTime> GetEdate() { return this.m_dEdate; }
        public string GetRemarks() { return this.m_sRemarks; }
        public string GetPremium_1() { return this.m_sPremium_1; }
        public string GetCon_per() { return this.m_sCon_per; }
        public string GetRebate_amount() { return this.m_sRebate_amount; }
        public string GetAmount() { return this.m_sAmount; }
        public string GetObprogram() { return this.m_sObprogram; }
        public string GetBundle_name() { return this.m_sBundle_name; }
        public global::System.Nullable<DateTime> GetEnd_date() { return this.m_dEnd_date; }
        public string GetRate_plan() { return this.m_sRate_plan; }
        public string GetPremium_2() { return this.m_sPremium_2; }
        public bool GetNormal_rebate() { return this.m_bNormal_rebate; }
        public string GetOb_early() { return this.m_sOb_early; }
        public bool GetCancel_renew() { return this.m_bCancel_renew; }
        public global::System.Nullable<DateTime> GetPo_date() { return this.m_dPo_date; }
        public string GetR_offer() { return this.m_sR_offer; }
        public global::System.Nullable<DateTime> GetDdate() { return this.m_dDdate; }
        public string GetExtra_rebate() { return this.m_sExtra_rebate; }
        public string GetProgram() { return this.m_sProgram; }

        public bool SetAutoSelectionProperty(AutoSelectionProperty value)
        {
            this.m_oAutoSelectionProperty = value;
            return true;
        }

        public bool SetBusinessTrade(BusinessTrade value)
        {
            this.m_oBusinessTrade = value;
            return true;
        }

        public bool SetCdate(global::System.Nullable<DateTime> value)
        {
            this.m_dCdate = value;
            return true;
        }
        public bool SetTradefield_mid(int value)
        {
            this.m_iTradefield_mid = value;
            return true;
        }
        public bool SetStart_date(global::System.Nullable<DateTime> value)
        {
            this.m_dStart_date = value;
            return true;
        }
        public bool SetCid(string value)
        {
            this.m_sCid = value;
            return true;
        }
        public bool SetRetention_type(string value)
        {
            this.m_sRetention_type = value;
            return true;
        }
        public bool SetHs_model(string value)
        {
            this.m_sHs_model = value;
            return true;
        }
        public bool SetExtra_offer(string value)
        {
            this.m_sExtra_offer = value;
            return true;
        }
        public bool SetDid(string value)
        {
            this.m_sDid = value;
            return true;
        }
        public bool SetTier(string value)
        {
            this.m_sTier = value;
            return true;
        }
        public bool SetExtra_rebate_amount(string value)
        {
            this.m_sExtra_rebate_amount = value;
            return true;
        }
        public bool SetSdate(global::System.Nullable<DateTime> value)
        {
            this.m_dSdate = value;
            return true;
        }
        public bool SetFree_mon(string value)
        {
            this.m_sFree_mon = value;
            return true;
        }
        public bool SetRebate(string value)
        {
            this.m_sRebate = value;
            return true;
        }
        public bool SetPlan_fee(string value)
        {
            this.m_sPlan_fee = value;
            return true;
        }
        public bool SetTrade_field(string value)
        {
            this.m_sTrade_field = value;
            return true;
        }
        public bool SetChannel(string value)
        {
            this.m_sChannel = value;
            return true;
        }
        public bool SetActive(bool value)
        {
            this.m_bActive = value;
            return true;
        }
        public bool SetPeriod(string value)
        {
            this.m_sPeriod = value;
            return true;
        }
        public bool SetEdate(global::System.Nullable<DateTime> value)
        {
            this.m_dEdate = value;
            return true;
        }
        public bool SetRemarks(string value)
        {
            this.m_sRemarks = value;
            return true;
        }
        public bool SetPremium_1(string value)
        {
            this.m_sPremium_1 = value;
            return true;
        }
        public bool SetCon_per(string value)
        {
            this.m_sCon_per = value;
            return true;
        }
        public bool SetRebate_amount(string value)
        {
            this.m_sRebate_amount = value;
            return true;
        }
        public bool SetAmount(string value)
        {
            this.m_sAmount = value;
            return true;
        }
        public bool SetObprogram(string value)
        {
            this.m_sObprogram = value;
            return true;
        }
        public bool SetBundle_name(string value)
        {
            this.m_sBundle_name = value;
            return true;
        }
        public bool SetEnd_date(global::System.Nullable<DateTime> value)
        {
            this.m_dEnd_date = value;
            return true;
        }
        public bool SetRate_plan(string value)
        {
            this.m_sRate_plan = value;
            return true;
        }
        public bool SetPremium_2(string value)
        {
            this.m_sPremium_2 = value;
            return true;
        }
        public bool SetNormal_rebate(bool value)
        {
            this.m_bNormal_rebate = value;
            return true;
        }
        public bool SetOb_early(string value)
        {
            this.m_sOb_early = value;
            return true;
        }
        public bool SetCancel_renew(bool value)
        {
            this.m_bCancel_renew = value;
            return true;
        }
        public bool SetPo_date(global::System.Nullable<DateTime> value)
        {
            this.m_dPo_date = value;
            return true;
        }
        public bool SetR_offer(string value)
        {
            this.m_sR_offer = value;
            return true;
        }
        public bool SetDdate(global::System.Nullable<DateTime> value)
        {
            this.m_dDdate = value;
            return true;
        }
        public bool SetExtra_rebate(string value)
        {
            this.m_sExtra_rebate = value;
            return true;
        }
        public bool SetProgram(string value)
        {
            this.m_sProgram = value;
            return true;
        }
        #endregion


        #region Equals
        public bool Equals(TierSelectionItem x_oObj)
        {
            if (x_oObj == null) { return false; }

            if (!this.m_oAutoSelectionProperty.Equals(x_oObj.m_oAutoSelectionProperty)) { return false; }
            if (!this.m_oBusinessTrade.Equals(x_oObj.m_oBusinessTrade)) { return false; }
            if (!this.m_dCdate.Equals(x_oObj.m_dCdate)) { return false; }
            if (!this.m_iTradefield_mid.Equals(x_oObj.m_iTradefield_mid)) { return false; }
            if (!this.m_dStart_date.Equals(x_oObj.m_dStart_date)) { return false; }
            if (!this.m_sCid.Equals(x_oObj.m_sCid)) { return false; }
            if (!this.m_sRetention_type.Equals(x_oObj.m_sRetention_type)) { return false; }
            if (!this.m_sHs_model.Equals(x_oObj.m_sHs_model)) { return false; }
            if (!this.m_sExtra_offer.Equals(x_oObj.m_sExtra_offer)) { return false; }
            if (!this.m_sDid.Equals(x_oObj.m_sDid)) { return false; }
            if (!this.m_sTier.Equals(x_oObj.m_sTier)) { return false; }
            if (!this.m_sExtra_rebate_amount.Equals(x_oObj.m_sExtra_rebate_amount)) { return false; }
            if (!this.m_dSdate.Equals(x_oObj.m_dSdate)) { return false; }
            if (!this.m_sFree_mon.Equals(x_oObj.m_sFree_mon)) { return false; }
            if (!this.m_sRebate.Equals(x_oObj.m_sRebate)) { return false; }
            if (!this.m_sPlan_fee.Equals(x_oObj.m_sPlan_fee)) { return false; }
            if (!this.m_sTrade_field.Equals(x_oObj.m_sTrade_field)) { return false; }
            if (!this.m_sChannel.Equals(x_oObj.m_sChannel)) { return false; }
            if (!this.m_bActive.Equals(x_oObj.m_bActive)) { return false; }
            if (!this.m_sPeriod.Equals(x_oObj.m_sPeriod)) { return false; }
            if (!this.m_dEdate.Equals(x_oObj.m_dEdate)) { return false; }
            if (!this.m_sRemarks.Equals(x_oObj.m_sRemarks)) { return false; }
            if (!this.m_sPremium_1.Equals(x_oObj.m_sPremium_1)) { return false; }
            if (!this.m_sCon_per.Equals(x_oObj.m_sCon_per)) { return false; }
            if (!this.m_sRebate_amount.Equals(x_oObj.m_sRebate_amount)) { return false; }
            if (!this.m_sAmount.Equals(x_oObj.m_sAmount)) { return false; }
            if (!this.m_sObprogram.Equals(x_oObj.m_sObprogram)) { return false; }
            if (!this.m_sBundle_name.Equals(x_oObj.m_sBundle_name)) { return false; }
            if (!this.m_dEnd_date.Equals(x_oObj.m_dEnd_date)) { return false; }
            if (!this.m_sRate_plan.Equals(x_oObj.m_sRate_plan)) { return false; }
            if (!this.m_sPremium_2.Equals(x_oObj.m_sPremium_2)) { return false; }
            if (!this.m_bNormal_rebate.Equals(x_oObj.m_bNormal_rebate)) { return false; }
            if (!this.m_sOb_early.Equals(x_oObj.m_sOb_early)) { return false; }
            if (!this.m_bCancel_renew.Equals(x_oObj.m_bCancel_renew)) { return false; }
            if (!this.m_dPo_date.Equals(x_oObj.m_dPo_date)) { return false; }
            if (!this.m_sR_offer.Equals(x_oObj.m_sR_offer)) { return false; }
            if (!this.m_dDdate.Equals(x_oObj.m_dDdate)) { return false; }
            if (!this.m_sExtra_rebate.Equals(x_oObj.m_sExtra_rebate)) { return false; }
            if (!this.m_sProgram.Equals(x_oObj.m_sProgram)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.m_oAutoSelectionProperty = null;
            this.m_oBusinessTrade = null;
            this.m_dCdate = null;
            this.m_iTradefield_mid = -1;
            this.m_dStart_date = null;
            this.m_sCid = string.Empty;
            this.m_sRetention_type = string.Empty;
            this.m_sHs_model = string.Empty;
            this.m_sExtra_offer = string.Empty;
            this.m_sDid = string.Empty;
            this.m_sTier = string.Empty;
            this.m_sExtra_rebate_amount = string.Empty;
            this.m_dSdate = null;
            this.m_sFree_mon = string.Empty;
            this.m_sRebate = string.Empty;
            this.m_sPlan_fee = string.Empty;
            this.m_sTrade_field = string.Empty;
            this.m_sChannel = string.Empty;
            this.m_bActive = false;
            this.m_sPeriod = string.Empty;
            this.m_dEdate = null;
            this.m_sRemarks = string.Empty;
            this.m_sPremium_1 = string.Empty;
            this.m_sCon_per = string.Empty;
            this.m_sRebate_amount = string.Empty;
            this.m_sAmount = string.Empty;
            this.m_sObprogram = string.Empty;
            this.m_sBundle_name = string.Empty;
            this.m_dEnd_date = null;
            this.m_sRate_plan = string.Empty;
            this.m_sPremium_2 = string.Empty;
            this.m_bNormal_rebate = false;
            this.m_sOb_early = string.Empty;
            this.m_bCancel_renew = false;
            this.m_dPo_date = null;
            this.m_sR_offer = string.Empty;
            this.m_dDdate = null;
            this.m_sExtra_rebate = string.Empty;
            this.m_sProgram = string.Empty;
        }
        #endregion Release


        #region DeepClone
        public TierSelectionItem DeepClone()
        {
            TierSelectionItem TierSelectionItem_Clone = new TierSelectionItem();
            TierSelectionItem_Clone.SetAutoSelectionProperty(this.m_oAutoSelectionProperty);
            TierSelectionItem_Clone.SetBusinessTrade(this.m_oBusinessTrade);
            TierSelectionItem_Clone.SetCdate(this.m_dCdate);
            TierSelectionItem_Clone.SetTradefield_mid(this.m_iTradefield_mid);
            TierSelectionItem_Clone.SetStart_date(this.m_dStart_date);
            TierSelectionItem_Clone.SetCid(this.m_sCid);
            TierSelectionItem_Clone.SetRetention_type(this.m_sRetention_type);
            TierSelectionItem_Clone.SetHs_model(this.m_sHs_model);
            TierSelectionItem_Clone.SetExtra_offer(this.m_sExtra_offer);
            TierSelectionItem_Clone.SetDid(this.m_sDid);
            TierSelectionItem_Clone.SetTier(this.m_sTier);
            TierSelectionItem_Clone.SetExtra_rebate_amount(this.m_sExtra_rebate_amount);
            TierSelectionItem_Clone.SetSdate(this.m_dSdate);
            TierSelectionItem_Clone.SetFree_mon(this.m_sFree_mon);
            TierSelectionItem_Clone.SetRebate(this.m_sRebate);
            TierSelectionItem_Clone.SetPlan_fee(this.m_sPlan_fee);
            TierSelectionItem_Clone.SetTrade_field(this.m_sTrade_field);
            TierSelectionItem_Clone.SetChannel(this.m_sChannel);
            TierSelectionItem_Clone.SetActive(this.m_bActive);
            TierSelectionItem_Clone.SetPeriod(this.m_sPeriod);
            TierSelectionItem_Clone.SetEdate(this.m_dEdate);
            TierSelectionItem_Clone.SetRemarks(this.m_sRemarks);
            TierSelectionItem_Clone.SetPremium_1(this.m_sPremium_1);
            TierSelectionItem_Clone.SetCon_per(this.m_sCon_per);
            TierSelectionItem_Clone.SetRebate_amount(this.m_sRebate_amount);
            TierSelectionItem_Clone.SetAmount(this.m_sAmount);
            TierSelectionItem_Clone.SetObprogram(this.m_sObprogram);
            TierSelectionItem_Clone.SetBundle_name(this.m_sBundle_name);
            TierSelectionItem_Clone.SetEnd_date(this.m_dEnd_date);
            TierSelectionItem_Clone.SetRate_plan(this.m_sRate_plan);
            TierSelectionItem_Clone.SetPremium_2(this.m_sPremium_2);
            TierSelectionItem_Clone.SetNormal_rebate(this.m_bNormal_rebate);
            TierSelectionItem_Clone.SetOb_early(this.m_sOb_early);
            TierSelectionItem_Clone.SetCancel_renew(this.m_bCancel_renew);
            TierSelectionItem_Clone.SetPo_date(this.m_dPo_date);
            TierSelectionItem_Clone.SetR_offer(this.m_sR_offer);
            TierSelectionItem_Clone.SetDdate(this.m_dDdate);
            TierSelectionItem_Clone.SetExtra_rebate(this.m_sExtra_rebate);
            TierSelectionItem_Clone.SetProgram(this.m_sProgram);
            return TierSelectionItem_Clone;
        }
        #endregion Clone

        void global::System.IDisposable.Dispose()
        {
            this.Dispose();
        }
        public void Dispose()
        {
        }
    }
}
