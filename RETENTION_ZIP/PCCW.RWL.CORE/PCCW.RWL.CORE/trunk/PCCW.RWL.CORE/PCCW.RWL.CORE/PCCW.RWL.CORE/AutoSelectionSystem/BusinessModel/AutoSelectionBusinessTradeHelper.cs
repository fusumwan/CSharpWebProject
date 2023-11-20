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


/// <summary>
/// Summary description for AutoSelectionBusinessTradeHelper
/// </summary>
/// 
namespace PCCW.RWL.CORE
{
    public class AutoSelectionBusinessTradeHelper
    {
        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
	    public AutoSelectionBusinessTradeHelper()
	    {
		    //
		    // TODO: Add constructor logic here
		    //
	    }
        
        public static List<TierSelectionItem> GetTierSelectionList(string x_sUid)
        {
            if (string.IsNullOrEmpty(x_sUid)) Logger.WarnFormat("User cannot be found the List<TierSelectionItem> with null or empty ({0}) value in this function.", "x_sUid");
            Staffinfo_new _oStaffinfo_new = new Staffinfo_new(SYSConn<MSSQLConnect>.Connect());
            _oStaffinfo_new = RWLFramework.Control<FromRegisterControler>().Get_StaffInfoEntity(x_sUid);
            string _sChannel = RWLFramework.Control<FromRegisterControler>().Get_Channel_By_TeamCode(_oStaffinfo_new.GetTeamcode());
            #region Create View AutoSelectionBusinessTrade

            #endregion
            List<TierSelectionItem> _oTierSelectionItemList = new List<TierSelectionItem>();
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("SELECT [AutoSelectionProperty].[remarks] AS AUTOSELECTIONPROPERTY_REMARKS,");
            _oQuery.Append(" [AutoSelectionProperty].[id] AS AUTOSELECTIONPROPERTY_ID,");
            _oQuery.Append(" [AutoSelectionProperty].[period] AS AUTOSELECTIONPROPERTY_PERIOD,");
            _oQuery.Append(" [AutoSelectionProperty].[start_date] AS AUTOSELECTIONPROPERTY_START_DATE,");
			_oQuery.Append(" [AutoSelectionProperty].[obprogram] AS AUTOSELECTIONPROPERTY_OBPROGRAM,");
			_oQuery.Append(" [AutoSelectionProperty].[channel] AS AUTOSELECTIONPROPERTY_CHANNEL,");
			_oQuery.Append(" [AutoSelectionProperty].[tier] AS AUTOSELECTIONPROPERTY_TIER,");
			_oQuery.Append(" [AutoSelectionProperty].[tradefield_mid] AS AUTOSELECTIONPROPERTY_TRADEFIELD_MID,");
			_oQuery.Append(" [AutoSelectionProperty].[uid] AS AUTOSELECTIONPROPERTY_UID,");
			_oQuery.Append(" [AutoSelectionProperty].[plan_fee] AS AUTOSELECTIONPROPERTY_PLAN_FEE,");
			_oQuery.Append(" [AutoSelectionProperty].[end_date] AS AUTOSELECTIONPROPERTY_END_DATE,");
			_oQuery.Append(" [AutoSelectionProperty].[po_date] AS AUTOSELECTIONPROPERTY_PO_DATE,");
			_oQuery.Append(" [BusinessTrade].[mid] AS BUSINESSTRADE_MID,");
			_oQuery.Append(" [BusinessTrade].[channel] AS BUSINESSTRADE_CHANNEL,");
			_oQuery.Append(" [BusinessTrade].[cdate] AS BUSINESSTRADE_CDATE,");
			_oQuery.Append(" [BusinessTrade].[bundle_name] AS BUSINESSTRADE_BUNDLE_NAME,");
			_oQuery.Append(" [BusinessTrade].[hs_model_name] AS BUSINESSTRADE_HS_MODEL_NAME,");
			_oQuery.Append(" [BusinessTrade].[trade_field] AS BUSINESSTRADE_TRADE_FIELD,");
			_oQuery.Append(" [BusinessTrade].[did] AS BUSINESSTRADE_DID,");
			_oQuery.Append(" [BusinessTrade].[premium_1] AS BUSINESSTRADE_PREMIUM_1,");
			_oQuery.Append(" [BusinessTrade].[sdate] AS BUSINESSTRADE_SDATE,");
			_oQuery.Append(" [BusinessTrade].[rebate] AS BUSINESSTRADE_REBATE,");
			_oQuery.Append(" [BusinessTrade].[premium_2] AS BUSINESSTRADE_PREMIUM_2,");
			_oQuery.Append(" [BusinessTrade].[po_date] AS BUSINESSTRADE_PO_DATE,");
			_oQuery.Append(" [BusinessTrade].[normal_rebate_type] AS BUSINESSTRADE_NORMAL_REBATE_TYPE,");
			_oQuery.Append(" [BusinessTrade].[extra_offer] AS BUSINESSTRADE_EXTRA_OFFER,");
			_oQuery.Append(" [BusinessTrade].[edate] AS BUSINESSTRADE_EDATE,");
			_oQuery.Append(" [BusinessTrade].[program] AS BUSINESSTRADE_PROGRAM,");
			_oQuery.Append(" [BusinessTrade].[ob_early] AS BUSINESSTRADE_OB_EARLY,");
			_oQuery.Append(" [BusinessTrade].[con_per] AS BUSINESSTRADE_CON_PER,");
			_oQuery.Append(" [BusinessTrade].[ddate] AS BUSINESSTRADE_DDATE,");
			_oQuery.Append(" [BusinessTrade].[active] AS BUSINESSTRADE_ACTIVE,");
			_oQuery.Append(" [BusinessTrade].[free_mon] AS BUSINESSTRADE_FREE_MON,");
			_oQuery.Append(" [BusinessTrade].[cid] AS BUSINESSTRADE_CID,");
			_oQuery.Append(" [BusinessTrade].[cancel_renew] AS BUSINESSTRADE_CANCEL_RENEW,");
			_oQuery.Append(" [BusinessTrade].[rate_plan] AS BUSINESSTRADE_RATE_PLAN,");
			_oQuery.Append(" [BusinessTrade].[normal_rebate] AS BUSINESSTRADE_NORMAL_REBATE,");
			_oQuery.Append(" [BusinessTrade].[hs_model] AS BUSINESSTRADE_HS_MODEL,");
			_oQuery.Append(" [BusinessTrade].[plan_fee] AS BUSINESSTRADE_PLAN_FEE,");
			_oQuery.Append(" [BusinessTrade].[remarks] AS BUSINESSTRADE_REMARKS ");
			_oQuery.Append(" FROM AutoSelectionProperty INNER JOIN BusinessTrade ");
			_oQuery.Append(" ON [AutoSelectionProperty].tradefield_mid=[BusinessTrade].mid ");
			_oQuery.Append(" AND [AutoSelectionProperty].plan_fee=[BusinessTrade].plan_fee  WHERE ");
            _oQuery.Append(" ([AutoSelectionProperty].start_date<getdate() and [AutoSelectionProperty].end_date>getdate()) and ( ");
            _oQuery.Append(" ([BusinessTrade].channel=[AutoSelectionProperty].channel and [AutoSelectionProperty].channel='" + _sChannel + "') or ");
            _oQuery.Append(" ([BusinessTrade].channel=[AutoSelectionProperty].channel and [AutoSelectionProperty].channel='ALL') or ");
            _oQuery.Append(" ([BusinessTrade].channel='ALL' and [AutoSelectionProperty].channel='" + _sChannel + "') or ");
            _oQuery.Append(" ([BusinessTrade].channel='ALL' and [AutoSelectionProperty].channel='ALL') )");
            SqlDataReader _oReader = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
            while (_oReader.Read()){
                AutoSelectionProperty _oAutoSelectionProperty = AutoSelectionPropertyRepository.CreateEntityInstanceObject();
                BusinessTrade _oBusinessTrade = BusinessTradeRepository.CreateEntityInstanceObject();
                if (!global::System.Convert.IsDBNull(_oReader["AUTOSELECTIONPROPERTY_REMARKS"])) { _oAutoSelectionProperty.SetRemarks((string)_oReader["AUTOSELECTIONPROPERTY_REMARKS"]); } else { _oAutoSelectionProperty.SetRemarks(string.Empty); }
                if (!global::System.Convert.IsDBNull(_oReader["AUTOSELECTIONPROPERTY_ID"])) { _oAutoSelectionProperty.SetId((global::System.Nullable<int>)_oReader["AUTOSELECTIONPROPERTY_ID"]); } else { _oAutoSelectionProperty.SetId(null); }
                if (!global::System.Convert.IsDBNull(_oReader["AUTOSELECTIONPROPERTY_PERIOD"])) { _oAutoSelectionProperty.SetPeriod((string)_oReader["AUTOSELECTIONPROPERTY_PERIOD"]); } else { _oAutoSelectionProperty.SetPeriod(string.Empty); }
                if (!global::System.Convert.IsDBNull(_oReader["AUTOSELECTIONPROPERTY_START_DATE"])) { _oAutoSelectionProperty.SetStart_date((global::System.Nullable<DateTime>)_oReader["AUTOSELECTIONPROPERTY_START_DATE"]); } else { _oAutoSelectionProperty.SetStart_date(null); }
                if (!global::System.Convert.IsDBNull(_oReader["AUTOSELECTIONPROPERTY_OBPROGRAM"])) { _oAutoSelectionProperty.SetObprogram((string)_oReader["AUTOSELECTIONPROPERTY_OBPROGRAM"]); } else { _oAutoSelectionProperty.SetObprogram(string.Empty); }
                if (!global::System.Convert.IsDBNull(_oReader["AUTOSELECTIONPROPERTY_CHANNEL"])) { _oAutoSelectionProperty.SetChannel((string)_oReader["AUTOSELECTIONPROPERTY_CHANNEL"]); } else { _oAutoSelectionProperty.SetChannel(string.Empty); }
                if (!global::System.Convert.IsDBNull(_oReader["AUTOSELECTIONPROPERTY_TIER"])) { _oAutoSelectionProperty.SetTier((string)_oReader["AUTOSELECTIONPROPERTY_TIER"]); } else { _oAutoSelectionProperty.SetTier(string.Empty); }
                if (!global::System.Convert.IsDBNull(_oReader["AUTOSELECTIONPROPERTY_TRADEFIELD_MID"])) { _oAutoSelectionProperty.SetTradefield_mid((global::System.Nullable<int>)_oReader["AUTOSELECTIONPROPERTY_TRADEFIELD_MID"]); } else { _oAutoSelectionProperty.SetTradefield_mid(null); }
                if (!global::System.Convert.IsDBNull(_oReader["AUTOSELECTIONPROPERTY_UID"])) { _oAutoSelectionProperty.SetUid((string)_oReader["AUTOSELECTIONPROPERTY_UID"]); } else { _oAutoSelectionProperty.SetUid(string.Empty); }
                if (!global::System.Convert.IsDBNull(_oReader["AUTOSELECTIONPROPERTY_PLAN_FEE"])) { _oAutoSelectionProperty.SetPlan_fee((string)_oReader["AUTOSELECTIONPROPERTY_PLAN_FEE"]); } else { _oAutoSelectionProperty.SetPlan_fee(string.Empty); }
                if (!global::System.Convert.IsDBNull(_oReader["AUTOSELECTIONPROPERTY_END_DATE"])) { _oAutoSelectionProperty.SetEnd_date((global::System.Nullable<DateTime>)_oReader["AUTOSELECTIONPROPERTY_END_DATE"]); } else { _oAutoSelectionProperty.SetEnd_date(null); }
                if (!global::System.Convert.IsDBNull(_oReader["AUTOSELECTIONPROPERTY_PO_DATE"])) { _oAutoSelectionProperty.SetPo_date((global::System.Nullable<DateTime>)_oReader["AUTOSELECTIONPROPERTY_PO_DATE"]); } else { _oAutoSelectionProperty.SetPo_date(null); }

                if (!global::System.Convert.IsDBNull(_oReader["BUSINESSTRADE_MID"])) { _oBusinessTrade.SetMid( (global::System.Nullable<int>)_oReader["BUSINESSTRADE_MID"]); } else { _oBusinessTrade.SetMid(null); }
                if (!global::System.Convert.IsDBNull(_oReader["BUSINESSTRADE_CHANNEL"])) { _oBusinessTrade.SetChannel( (string)_oReader["BUSINESSTRADE_CHANNEL"]); } else { _oBusinessTrade.SetChannel(string.Empty); }
                if (!global::System.Convert.IsDBNull(_oReader["BUSINESSTRADE_CDATE"])) { _oBusinessTrade.SetCdate((global::System.Nullable<DateTime>)_oReader["BUSINESSTRADE_CDATE"]); } else { _oBusinessTrade.SetCdate(null); }
                if (!global::System.Convert.IsDBNull(_oReader["BUSINESSTRADE_BUNDLE_NAME"])) { _oBusinessTrade.SetBundle_name((string)_oReader["BUSINESSTRADE_BUNDLE_NAME"]); } else { _oBusinessTrade.SetBundle_name(string.Empty); }
                if (!global::System.Convert.IsDBNull(_oReader["BUSINESSTRADE_HS_MODEL_NAME"])) { _oBusinessTrade.SetHs_model_name((string)_oReader["BUSINESSTRADE_HS_MODEL_NAME"]); } else { _oBusinessTrade.SetHs_model_name(string.Empty); }
                if (!global::System.Convert.IsDBNull(_oReader["BUSINESSTRADE_TRADE_FIELD"])) { _oBusinessTrade.SetTrade_field((string)_oReader["BUSINESSTRADE_TRADE_FIELD"]); } else { _oBusinessTrade.SetTrade_field(string.Empty); }
                if (!global::System.Convert.IsDBNull(_oReader["BUSINESSTRADE_DID"])) { _oBusinessTrade.SetDid((string)_oReader["BUSINESSTRADE_DID"]); } else { _oBusinessTrade.SetDid(string.Empty); }
                if (!global::System.Convert.IsDBNull(_oReader["BUSINESSTRADE_PREMIUM_1"])) { _oBusinessTrade.SetPremium_1((string)_oReader["BUSINESSTRADE_PREMIUM_1"]); } else { _oBusinessTrade.SetPremium_1(string.Empty); }
                if (!global::System.Convert.IsDBNull(_oReader["BUSINESSTRADE_SDATE"])) { _oBusinessTrade.SetSdate((global::System.Nullable<DateTime>)_oReader["BUSINESSTRADE_SDATE"]); } else { _oBusinessTrade.SetSdate(null); }
                if (!global::System.Convert.IsDBNull(_oReader["BUSINESSTRADE_REBATE"])) { _oBusinessTrade.SetRebate((string)_oReader["BUSINESSTRADE_REBATE"]); } else { _oBusinessTrade.SetRebate(string.Empty); }
                if (!global::System.Convert.IsDBNull(_oReader["BUSINESSTRADE_PREMIUM_2"])) { _oBusinessTrade.SetPremium_2( (string)_oReader["BUSINESSTRADE_PREMIUM_2"]); } else { _oBusinessTrade.SetPremium_2(string.Empty); }
                if (!global::System.Convert.IsDBNull(_oReader["BUSINESSTRADE_PO_DATE"])) { _oBusinessTrade.SetPo_date((global::System.Nullable<DateTime>)_oReader["BUSINESSTRADE_PO_DATE"]); } else { _oBusinessTrade.SetPo_date(null); }
                if (!global::System.Convert.IsDBNull(_oReader["BUSINESSTRADE_NORMAL_REBATE_TYPE"])) { _oBusinessTrade.SetNormal_rebate_type((string)_oReader["BUSINESSTRADE_NORMAL_REBATE_TYPE"]); } else { _oBusinessTrade.SetNormal_rebate_type(string.Empty); }
                if (!global::System.Convert.IsDBNull(_oReader["BUSINESSTRADE_EXTRA_OFFER"])) { _oBusinessTrade.SetExtra_offer((string)_oReader["BUSINESSTRADE_EXTRA_OFFER"]); } else { _oBusinessTrade.SetExtra_offer(string.Empty); }
                if (!global::System.Convert.IsDBNull(_oReader["BUSINESSTRADE_EDATE"])) { _oBusinessTrade.SetEdate((global::System.Nullable<DateTime>)_oReader["BUSINESSTRADE_EDATE"]); } else { _oBusinessTrade.SetEdate(null); }
                if (!global::System.Convert.IsDBNull(_oReader["BUSINESSTRADE_PROGRAM"])) { _oBusinessTrade.SetProgram((string)_oReader["BUSINESSTRADE_PROGRAM"]); } else { _oBusinessTrade.SetProgram(string.Empty); }
                if (!global::System.Convert.IsDBNull(_oReader["BUSINESSTRADE_OB_EARLY"])) { _oBusinessTrade.SetOb_early((string)_oReader["BUSINESSTRADE_OB_EARLY"]); } else { _oBusinessTrade.SetOb_early(string.Empty); }
                if (!global::System.Convert.IsDBNull(_oReader["BUSINESSTRADE_CON_PER"])) { _oBusinessTrade.SetCon_per((string)_oReader["BUSINESSTRADE_CON_PER"]); } else { _oBusinessTrade.SetCon_per(string.Empty); }
                if (!global::System.Convert.IsDBNull(_oReader["BUSINESSTRADE_DDATE"])) { _oBusinessTrade.SetDdate((global::System.Nullable<DateTime>)_oReader["BUSINESSTRADE_DDATE"]); } else { _oBusinessTrade.SetDdate(null); }
                if (!global::System.Convert.IsDBNull(_oReader["BUSINESSTRADE_ACTIVE"])) { _oBusinessTrade.SetActive((global::System.Nullable<bool>)_oReader["BUSINESSTRADE_ACTIVE"]); } else { _oBusinessTrade.SetActive(null); }
                if (!global::System.Convert.IsDBNull(_oReader["BUSINESSTRADE_FREE_MON"])) { _oBusinessTrade.SetFree_mon((string)_oReader["BUSINESSTRADE_FREE_MON"]); } else { _oBusinessTrade.SetFree_mon(string.Empty); }
                if (!global::System.Convert.IsDBNull(_oReader["BUSINESSTRADE_CID"])) { _oBusinessTrade.SetCid((string)_oReader["BUSINESSTRADE_CID"]); } else { _oBusinessTrade.SetCid(string.Empty); }
                if (!global::System.Convert.IsDBNull(_oReader["BUSINESSTRADE_CANCEL_RENEW"])) { _oBusinessTrade.SetCancel_renew((global::System.Nullable<bool>)_oReader["BUSINESSTRADE_CANCEL_RENEW"]); } else { _oBusinessTrade.SetCancel_renew(null); }
                if (!global::System.Convert.IsDBNull(_oReader["BUSINESSTRADE_RATE_PLAN"])) { _oBusinessTrade.SetRate_plan((string)_oReader["BUSINESSTRADE_RATE_PLAN"]); } else { _oBusinessTrade.SetRate_plan(string.Empty); }
                if (!global::System.Convert.IsDBNull(_oReader["BUSINESSTRADE_NORMAL_REBATE"])) { _oBusinessTrade.SetNormal_rebate( (global::System.Nullable<bool>)_oReader["BUSINESSTRADE_NORMAL_REBATE"]); } else { _oBusinessTrade.SetNormal_rebate(null); }
                if (!global::System.Convert.IsDBNull(_oReader["BUSINESSTRADE_HS_MODEL"])) { _oBusinessTrade.SetHs_model((string)_oReader["BUSINESSTRADE_HS_MODEL"]); } else { _oBusinessTrade.SetHs_model(string.Empty); }
                if (!global::System.Convert.IsDBNull(_oReader["BUSINESSTRADE_PLAN_FEE"])) { _oBusinessTrade.SetPlan_fee((string)_oReader["BUSINESSTRADE_PLAN_FEE"]); } else { _oBusinessTrade.SetPlan_fee(string.Empty); }
                if (!global::System.Convert.IsDBNull(_oReader["BUSINESSTRADE_REMARKS"])) { _oBusinessTrade.SetRemarks((string)_oReader["BUSINESSTRADE_REMARKS"]); } else { _oBusinessTrade.SetRemarks(string.Empty); }

                TierSelectionItem _oTierSelectionItem = ConvertToTierSelecionItem(_oAutoSelectionProperty, _oBusinessTrade);
                _oTierSelectionItemList.Add(_oTierSelectionItem);
            }
            _oReader.Close();
            _oReader.Dispose();
            return _oTierSelectionItemList;
        }

        #region Convert To Tier SelecionItem
        public static TierSelectionItem ConvertToTierSelecionItem(AutoSelectionProperty x_oAutoSelectionProperty, BusinessTrade x_oBusinessTrade)
        {
            if (x_oAutoSelectionProperty == null) Logger.WarnFormat("User cannot be found the result with null({0}) value in this function.", "x_oAutoSelectionProperty");
            if (x_oBusinessTrade == null) Logger.WarnFormat("User cannot be found the result with null({0}) value in this function.", "x_oBusinessTrade");
            TierSelectionItem _oTierSelectionItem = new TierSelectionItem();
            if (x_oBusinessTrade.GetFound()){
                _oTierSelectionItem.SetPeriod(x_oAutoSelectionProperty.GetPeriod());
                _oTierSelectionItem.SetObprogram(x_oAutoSelectionProperty.GetObprogram());
                _oTierSelectionItem.SetTradefield_mid((int)x_oAutoSelectionProperty.GetTradefield_mid());
                _oTierSelectionItem.SetTier(x_oAutoSelectionProperty.GetTier());
                _oTierSelectionItem.SetStart_date(x_oAutoSelectionProperty.GetStart_date());
                _oTierSelectionItem.SetEnd_date(x_oAutoSelectionProperty.GetEnd_date());
                _oTierSelectionItem.SetPo_date(x_oAutoSelectionProperty.GetPo_date());
                if (x_oBusinessTrade != null){
                    _oTierSelectionItem.SetActive((bool)x_oBusinessTrade.GetActive());
                    _oTierSelectionItem.SetBundle_name(x_oBusinessTrade.GetBundle_name());
                    _oTierSelectionItem.SetCancel_renew((bool)x_oBusinessTrade.GetCancel_renew());
                    _oTierSelectionItem.SetCdate(x_oBusinessTrade.GetCdate());
                    _oTierSelectionItem.SetChannel(x_oBusinessTrade.GetChannel());
                    _oTierSelectionItem.SetCid(x_oBusinessTrade.GetCid());
                    _oTierSelectionItem.SetCon_per(x_oBusinessTrade.GetCon_per());
                    _oTierSelectionItem.SetDdate(x_oBusinessTrade.GetDdate());
                    _oTierSelectionItem.SetDid(x_oBusinessTrade.GetDid());
                    _oTierSelectionItem.SetEdate(x_oBusinessTrade.GetEdate());
                    _oTierSelectionItem.SetExtra_offer(x_oBusinessTrade.GetExtra_offer());
                    _oTierSelectionItem.SetFree_mon(x_oBusinessTrade.GetFree_mon());
                    _oTierSelectionItem.SetHs_model(x_oBusinessTrade.GetHs_model());

                    _oTierSelectionItem.SetNormal_rebate((bool)x_oBusinessTrade.GetNormal_rebate());
                    _oTierSelectionItem.SetOb_early(x_oBusinessTrade.GetOb_early());
                    _oTierSelectionItem.SetPlan_fee(x_oBusinessTrade.GetPlan_fee());
                    _oTierSelectionItem.SetPremium_1(x_oBusinessTrade.GetPremium_1());
                    _oTierSelectionItem.SetPremium_2(x_oBusinessTrade.GetPremium_2());
                    _oTierSelectionItem.SetProgram(x_oBusinessTrade.GetProgram());
                    _oTierSelectionItem.SetRate_plan(x_oBusinessTrade.GetRate_plan());
                    _oTierSelectionItem.SetRebate(x_oBusinessTrade.GetRebate());
                    _oTierSelectionItem.SetRemarks(x_oBusinessTrade.GetRemarks());
                    
                    _oTierSelectionItem.SetSdate(x_oBusinessTrade.GetSdate());
                    _oTierSelectionItem.SetTrade_field(x_oBusinessTrade.GetTrade_field());
                    _oTierSelectionItem.SetBundle_name(x_oBusinessTrade.GetBundle_name());
                }
                _oTierSelectionItem.SetAutoSelectionProperty(x_oAutoSelectionProperty);
                _oTierSelectionItem.SetBusinessTrade(x_oBusinessTrade);
            }
            return _oTierSelectionItem;
        }
        #endregion
		
		#region
		
		#endregion
    }
}
