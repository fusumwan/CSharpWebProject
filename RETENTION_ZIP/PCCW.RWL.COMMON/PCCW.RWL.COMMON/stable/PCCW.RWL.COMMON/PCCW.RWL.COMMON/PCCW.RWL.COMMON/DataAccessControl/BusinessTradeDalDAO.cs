using System;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
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
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2011-07-13>
///-- Description:	<Description,Table :[BusinessTrade],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class BusinessTradeDalDAO{
        
        #region RS
        public class BusinessTradeRS
        {
            public bool n_bMid = false;
            public bool n_bChannel = false;
            public bool n_bCdate = false;
            public bool n_bBundle_name = false;
            public bool n_bHs_model_name = false;
            public bool n_bTrade_field = false;
            public bool n_bDid = false;
            public bool n_bPremium_1 = false;
            public bool n_bSdate = false;
            public bool n_bRebate = false;
            public bool n_bPremium_2 = false;
            public bool n_bRetention_type = false;
            public bool n_bExtra_offer = false;
            public bool n_bEdate = false;
            public bool n_bProgram = false;
            public bool n_bCon_per = false;
            public bool n_bRate_plan = false;
            public bool n_bDdate = false;
            public bool n_bNormal_rebate_type = false;
            public bool n_bActive = false;
            public bool n_bFree_mon = false;
            public bool n_bCid = false;
            public bool n_bCancel_renew = false;
            public bool n_bOb_early = false;
            public bool n_bNormal_rebate = false;
            public bool n_bHs_model = false;
            public bool n_bPlan_fee = false;
            public bool n_bPo_date = false;
            public bool n_bRemarks = false;
            public bool n_bIssue_type = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bMid  || x_bSetShowALL || (BusinessTrade.Para.mid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTrade.Para.mid);
                }
                if (this.n_bChannel  || x_bSetShowALL || (BusinessTrade.Para.channel.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bChannel=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTrade.Para.channel);
                }
                if (this.n_bCdate  || x_bSetShowALL || (BusinessTrade.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTrade.Para.cdate);
                }
                if (this.n_bBundle_name  || x_bSetShowALL || (BusinessTrade.Para.bundle_name.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bBundle_name=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTrade.Para.bundle_name);
                }
                if (this.n_bHs_model_name  || x_bSetShowALL || (BusinessTrade.Para.hs_model_name.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bHs_model_name=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTrade.Para.hs_model_name);
                }
                if (this.n_bTrade_field  || x_bSetShowALL || (BusinessTrade.Para.trade_field.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bTrade_field=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTrade.Para.trade_field);
                }
                if (this.n_bDid  || x_bSetShowALL || (BusinessTrade.Para.did.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTrade.Para.did);
                }
                if (this.n_bPremium_1  || x_bSetShowALL || (BusinessTrade.Para.premium_1.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPremium_1=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTrade.Para.premium_1);
                }
                if (this.n_bSdate  || x_bSetShowALL || (BusinessTrade.Para.sdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTrade.Para.sdate);
                }
                if (this.n_bRebate  || x_bSetShowALL || (BusinessTrade.Para.rebate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRebate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTrade.Para.rebate);
                }
                if (this.n_bPremium_2  || x_bSetShowALL || (BusinessTrade.Para.premium_2.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPremium_2=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTrade.Para.premium_2);
                }
                if (this.n_bRetention_type  || x_bSetShowALL || (BusinessTrade.Para.retention_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRetention_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTrade.Para.retention_type);
                }
                if (this.n_bExtra_offer  || x_bSetShowALL || (BusinessTrade.Para.extra_offer.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bExtra_offer=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTrade.Para.extra_offer);
                }
                if (this.n_bEdate  || x_bSetShowALL || (BusinessTrade.Para.edate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTrade.Para.edate);
                }
                if (this.n_bProgram  || x_bSetShowALL || (BusinessTrade.Para.program.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bProgram=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTrade.Para.program);
                }
                if (this.n_bCon_per  || x_bSetShowALL || (BusinessTrade.Para.con_per.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCon_per=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTrade.Para.con_per);
                }
                if (this.n_bRate_plan  || x_bSetShowALL || (BusinessTrade.Para.rate_plan.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRate_plan=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTrade.Para.rate_plan);
                }
                if (this.n_bDdate  || x_bSetShowALL || (BusinessTrade.Para.ddate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTrade.Para.ddate);
                }
                if (this.n_bNormal_rebate_type  || x_bSetShowALL || (BusinessTrade.Para.normal_rebate_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bNormal_rebate_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTrade.Para.normal_rebate_type);
                }
                if (this.n_bActive  || x_bSetShowALL || (BusinessTrade.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTrade.Para.active);
                }
                if (this.n_bFree_mon  || x_bSetShowALL || (BusinessTrade.Para.free_mon.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFree_mon=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTrade.Para.free_mon);
                }
                if (this.n_bCid  || x_bSetShowALL || (BusinessTrade.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTrade.Para.cid);
                }
                if (this.n_bCancel_renew  || x_bSetShowALL || (BusinessTrade.Para.cancel_renew.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCancel_renew=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTrade.Para.cancel_renew);
                }
                if (this.n_bOb_early  || x_bSetShowALL || (BusinessTrade.Para.ob_early.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOb_early=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTrade.Para.ob_early);
                }
                if (this.n_bNormal_rebate  || x_bSetShowALL || (BusinessTrade.Para.normal_rebate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bNormal_rebate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTrade.Para.normal_rebate);
                }
                if (this.n_bHs_model  || x_bSetShowALL || (BusinessTrade.Para.hs_model.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bHs_model=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTrade.Para.hs_model);
                }
                if (this.n_bPlan_fee  || x_bSetShowALL || (BusinessTrade.Para.plan_fee.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPlan_fee=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTrade.Para.plan_fee);
                }
                if (this.n_bPo_date  || x_bSetShowALL || (BusinessTrade.Para.po_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPo_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTrade.Para.po_date);
                }
                if (this.n_bRemarks  || x_bSetShowALL || (BusinessTrade.Para.remarks.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRemarks=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTrade.Para.remarks);
                }
                if (this.n_bIssue_type  || x_bSetShowALL || (BusinessTrade.Para.issue_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bIssue_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTrade.Para.issue_type);
                }
                return _oFR.ToString();
            }
            
            public string FieldsToReturn()
            {
                return this.FieldsToReturn(string.Empty,false);
            }
            
        }
        #endregion
        #region Constructor
        
        public BusinessTradeDalDAO(){
        }
        ~BusinessTradeDalDAO(){
            this.Release();
        }
        #endregion
        
        #region Search Engine
        public static global::System.Data.SqlClient.SqlDataReader DrSearch(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, string x_sFieldsToReturn,string x_sSortByField,bool x_bAscDirection)
        {
            SearchUtils _oSearchUtils = new SearchUtils();
            _oSearchUtils.SetSearchItems(x_oSearchItems);
            _oSearchUtils.SetRowFilter(x_sRowFilter);
            _oSearchUtils.SetStart(x_lStart);
            _oSearchUtils.SetLimit(x_lLimit);
            _oSearchUtils.SetFieldsToReturn(x_sFieldsToReturn);
            _oSearchUtils.SetOrderByField(x_sSortByField);
            _oSearchUtils.SetAscDirection(x_bAscDirection);
            _oSearchUtils.SetTable(BusinessTrade.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<BusinessTradeEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, BusinessTradeRS x_oFieldsToReturn,BusinessTradeRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<BusinessTradeEntity> _oBusinessTradeList = new List<BusinessTradeEntity>();
                
                while (_oDATA.Read())
                {
                    BusinessTrade _oBusinessTrade = new BusinessTrade();
                    if ((true).Equals(x_oFieldsToReturn.n_bMid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTrade.Para.mid])) { _oBusinessTrade.SetMid((global::System.Nullable<int>)_oDATA[BusinessTrade.Para.mid]); } else { _oBusinessTrade.SetMid(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bChannel))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTrade.Para.channel])) { _oBusinessTrade.SetChannel((string)_oDATA[BusinessTrade.Para.channel]); } else { _oBusinessTrade.SetChannel(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTrade.Para.cdate])) { _oBusinessTrade.SetCdate((global::System.Nullable<DateTime>)_oDATA[BusinessTrade.Para.cdate]); } else { _oBusinessTrade.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bBundle_name))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTrade.Para.bundle_name])) { _oBusinessTrade.SetBundle_name((string)_oDATA[BusinessTrade.Para.bundle_name]); } else { _oBusinessTrade.SetBundle_name(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bHs_model_name))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTrade.Para.hs_model_name])) { _oBusinessTrade.SetHs_model_name((string)_oDATA[BusinessTrade.Para.hs_model_name]); } else { _oBusinessTrade.SetHs_model_name(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bTrade_field))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTrade.Para.trade_field])) { _oBusinessTrade.SetTrade_field((string)_oDATA[BusinessTrade.Para.trade_field]); } else { _oBusinessTrade.SetTrade_field(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTrade.Para.did])) { _oBusinessTrade.SetDid((string)_oDATA[BusinessTrade.Para.did]); } else { _oBusinessTrade.SetDid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPremium_1))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTrade.Para.premium_1])) { _oBusinessTrade.SetPremium_1((string)_oDATA[BusinessTrade.Para.premium_1]); } else { _oBusinessTrade.SetPremium_1(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTrade.Para.sdate])) { _oBusinessTrade.SetSdate((global::System.Nullable<DateTime>)_oDATA[BusinessTrade.Para.sdate]); } else { _oBusinessTrade.SetSdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRebate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTrade.Para.rebate])) { _oBusinessTrade.SetRebate((string)_oDATA[BusinessTrade.Para.rebate]); } else { _oBusinessTrade.SetRebate(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPremium_2))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTrade.Para.premium_2])) { _oBusinessTrade.SetPremium_2((string)_oDATA[BusinessTrade.Para.premium_2]); } else { _oBusinessTrade.SetPremium_2(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRetention_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTrade.Para.retention_type])) { _oBusinessTrade.SetRetention_type((string)_oDATA[BusinessTrade.Para.retention_type]); } else { _oBusinessTrade.SetRetention_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bExtra_offer))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTrade.Para.extra_offer])) { _oBusinessTrade.SetExtra_offer((string)_oDATA[BusinessTrade.Para.extra_offer]); } else { _oBusinessTrade.SetExtra_offer(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTrade.Para.edate])) { _oBusinessTrade.SetEdate((global::System.Nullable<DateTime>)_oDATA[BusinessTrade.Para.edate]); } else { _oBusinessTrade.SetEdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bProgram))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTrade.Para.program])) { _oBusinessTrade.SetProgram((string)_oDATA[BusinessTrade.Para.program]); } else { _oBusinessTrade.SetProgram(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCon_per))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTrade.Para.con_per])) { _oBusinessTrade.SetCon_per((string)_oDATA[BusinessTrade.Para.con_per]); } else { _oBusinessTrade.SetCon_per(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRate_plan))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTrade.Para.rate_plan])) { _oBusinessTrade.SetRate_plan((string)_oDATA[BusinessTrade.Para.rate_plan]); } else { _oBusinessTrade.SetRate_plan(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTrade.Para.ddate])) { _oBusinessTrade.SetDdate((global::System.Nullable<DateTime>)_oDATA[BusinessTrade.Para.ddate]); } else { _oBusinessTrade.SetDdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bNormal_rebate_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTrade.Para.normal_rebate_type])) { _oBusinessTrade.SetNormal_rebate_type((string)_oDATA[BusinessTrade.Para.normal_rebate_type]); } else { _oBusinessTrade.SetNormal_rebate_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTrade.Para.active])) { _oBusinessTrade.SetActive((global::System.Nullable<bool>)_oDATA[BusinessTrade.Para.active]); } else { _oBusinessTrade.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFree_mon))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTrade.Para.free_mon])) { _oBusinessTrade.SetFree_mon((string)_oDATA[BusinessTrade.Para.free_mon]); } else { _oBusinessTrade.SetFree_mon(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTrade.Para.cid])) { _oBusinessTrade.SetCid((string)_oDATA[BusinessTrade.Para.cid]); } else { _oBusinessTrade.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCancel_renew))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTrade.Para.cancel_renew])) { _oBusinessTrade.SetCancel_renew((global::System.Nullable<bool>)_oDATA[BusinessTrade.Para.cancel_renew]); } else { _oBusinessTrade.SetCancel_renew(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOb_early))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTrade.Para.ob_early])) { _oBusinessTrade.SetOb_early((string)_oDATA[BusinessTrade.Para.ob_early]); } else { _oBusinessTrade.SetOb_early(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bNormal_rebate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTrade.Para.normal_rebate])) { _oBusinessTrade.SetNormal_rebate((global::System.Nullable<bool>)_oDATA[BusinessTrade.Para.normal_rebate]); } else { _oBusinessTrade.SetNormal_rebate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bHs_model))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTrade.Para.hs_model])) { _oBusinessTrade.SetHs_model((string)_oDATA[BusinessTrade.Para.hs_model]); } else { _oBusinessTrade.SetHs_model(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPlan_fee))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTrade.Para.plan_fee])) { _oBusinessTrade.SetPlan_fee((string)_oDATA[BusinessTrade.Para.plan_fee]); } else { _oBusinessTrade.SetPlan_fee(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPo_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTrade.Para.po_date])) { _oBusinessTrade.SetPo_date((global::System.Nullable<DateTime>)_oDATA[BusinessTrade.Para.po_date]); } else { _oBusinessTrade.SetPo_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRemarks))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTrade.Para.remarks])) { _oBusinessTrade.SetRemarks((string)_oDATA[BusinessTrade.Para.remarks]); } else { _oBusinessTrade.SetRemarks(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bIssue_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTrade.Para.issue_type])) { _oBusinessTrade.SetIssue_type((string)_oDATA[BusinessTrade.Para.issue_type]); } else { _oBusinessTrade.SetIssue_type(global::System.String.Empty); }
                    }
                    _oBusinessTradeList.Add(_oBusinessTrade);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oBusinessTradeList;
            }
            return new List<BusinessTradeEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<BusinessTradeEntity> OrderBy(string x_sSort, IQueryable<BusinessTradeEntity> x_oBusinessTradeBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case BusinessTrade.Para.mid:
                if(x_bAsc)
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderBy(c => c.mid).Select(c => c);
                else
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderByDescending(c => c.mid).Select(c => c);
                break;
                case BusinessTrade.Para.channel:
                if(x_bAsc)
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderBy(c => c.channel).Select(c => c);
                else
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderByDescending(c => c.channel).Select(c => c);
                break;
                case BusinessTrade.Para.cdate:
                if(x_bAsc)
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case BusinessTrade.Para.bundle_name:
                if(x_bAsc)
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderBy(c => c.bundle_name).Select(c => c);
                else
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderByDescending(c => c.bundle_name).Select(c => c);
                break;
                case BusinessTrade.Para.hs_model_name:
                if(x_bAsc)
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderBy(c => c.hs_model_name).Select(c => c);
                else
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderByDescending(c => c.hs_model_name).Select(c => c);
                break;
                case BusinessTrade.Para.trade_field:
                if(x_bAsc)
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderBy(c => c.trade_field).Select(c => c);
                else
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderByDescending(c => c.trade_field).Select(c => c);
                break;
                case BusinessTrade.Para.did:
                if(x_bAsc)
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderBy(c => c.did).Select(c => c);
                else
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderByDescending(c => c.did).Select(c => c);
                break;
                case BusinessTrade.Para.premium_1:
                if(x_bAsc)
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderBy(c => c.premium_1).Select(c => c);
                else
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderByDescending(c => c.premium_1).Select(c => c);
                break;
                case BusinessTrade.Para.sdate:
                if(x_bAsc)
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderBy(c => c.sdate).Select(c => c);
                else
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderByDescending(c => c.sdate).Select(c => c);
                break;
                case BusinessTrade.Para.rebate:
                if(x_bAsc)
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderBy(c => c.rebate).Select(c => c);
                else
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderByDescending(c => c.rebate).Select(c => c);
                break;
                case BusinessTrade.Para.premium_2:
                if(x_bAsc)
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderBy(c => c.premium_2).Select(c => c);
                else
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderByDescending(c => c.premium_2).Select(c => c);
                break;
                case BusinessTrade.Para.retention_type:
                if(x_bAsc)
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderBy(c => c.retention_type).Select(c => c);
                else
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderByDescending(c => c.retention_type).Select(c => c);
                break;
                case BusinessTrade.Para.extra_offer:
                if(x_bAsc)
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderBy(c => c.extra_offer).Select(c => c);
                else
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderByDescending(c => c.extra_offer).Select(c => c);
                break;
                case BusinessTrade.Para.edate:
                if(x_bAsc)
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderBy(c => c.edate).Select(c => c);
                else
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderByDescending(c => c.edate).Select(c => c);
                break;
                case BusinessTrade.Para.program:
                if(x_bAsc)
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderBy(c => c.program).Select(c => c);
                else
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderByDescending(c => c.program).Select(c => c);
                break;
                case BusinessTrade.Para.con_per:
                if(x_bAsc)
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderBy(c => c.con_per).Select(c => c);
                else
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderByDescending(c => c.con_per).Select(c => c);
                break;
                case BusinessTrade.Para.rate_plan:
                if(x_bAsc)
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderBy(c => c.rate_plan).Select(c => c);
                else
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderByDescending(c => c.rate_plan).Select(c => c);
                break;
                case BusinessTrade.Para.ddate:
                if(x_bAsc)
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderBy(c => c.ddate).Select(c => c);
                else
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderByDescending(c => c.ddate).Select(c => c);
                break;
                case BusinessTrade.Para.normal_rebate_type:
                if(x_bAsc)
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderBy(c => c.normal_rebate_type).Select(c => c);
                else
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderByDescending(c => c.normal_rebate_type).Select(c => c);
                break;
                case BusinessTrade.Para.active:
                if(x_bAsc)
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case BusinessTrade.Para.free_mon:
                if(x_bAsc)
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderBy(c => c.free_mon).Select(c => c);
                else
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderByDescending(c => c.free_mon).Select(c => c);
                break;
                case BusinessTrade.Para.cid:
                if(x_bAsc)
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderBy(c => c.cid).Select(c => c);
                else
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderByDescending(c => c.cid).Select(c => c);
                break;
                case BusinessTrade.Para.cancel_renew:
                if(x_bAsc)
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderBy(c => c.cancel_renew).Select(c => c);
                else
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderByDescending(c => c.cancel_renew).Select(c => c);
                break;
                case BusinessTrade.Para.ob_early:
                if(x_bAsc)
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderBy(c => c.ob_early).Select(c => c);
                else
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderByDescending(c => c.ob_early).Select(c => c);
                break;
                case BusinessTrade.Para.normal_rebate:
                if(x_bAsc)
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderBy(c => c.normal_rebate).Select(c => c);
                else
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderByDescending(c => c.normal_rebate).Select(c => c);
                break;
                case BusinessTrade.Para.hs_model:
                if(x_bAsc)
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderBy(c => c.hs_model).Select(c => c);
                else
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderByDescending(c => c.hs_model).Select(c => c);
                break;
                case BusinessTrade.Para.plan_fee:
                if(x_bAsc)
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderBy(c => c.plan_fee).Select(c => c);
                else
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderByDescending(c => c.plan_fee).Select(c => c);
                break;
                case BusinessTrade.Para.po_date:
                if(x_bAsc)
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderBy(c => c.po_date).Select(c => c);
                else
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderByDescending(c => c.po_date).Select(c => c);
                break;
                case BusinessTrade.Para.remarks:
                if(x_bAsc)
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderBy(c => c.remarks).Select(c => c);
                else
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderByDescending(c => c.remarks).Select(c => c);
                break;
                case BusinessTrade.Para.issue_type:
                if(x_bAsc)
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderBy(c => c.issue_type).Select(c => c);
                else
                    x_oBusinessTradeBaseList = x_oBusinessTradeBaseList.OrderByDescending(c => c.issue_type).Select(c => c);
                break;
            }
            return x_oBusinessTradeBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<BusinessTradeEntity> FindAll()
        {
            BusinessTradeEntity[] _oBusinessTradesArr=  BusinessTradeRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oBusinessTradesArr != null)
            {
                IList<BusinessTradeEntity> _oBusinessTradesList = (IList<BusinessTradeEntity>)_oBusinessTradesArr;
                return _oBusinessTradesList;
            }
            return new List<BusinessTradeEntity>();
        }
        
        public static IList<BusinessTradeEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<BusinessTradeEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<BusinessTradeEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<BusinessTradeEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            BusinessTradeRS x_oShowField = new BusinessTradeRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            BusinessTradeRS x_oSortField=new BusinessTradeRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(BusinessTrade.Para.mid.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(BusinessTrade.Para.mid, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            BusinessTradeRepositoryBase _oBusinessTradeRepositoryBase = new BusinessTradeRepositoryBase(GetDB());
            return _oBusinessTradeRepositoryBase.GetCount();
        }
        #endregion
        
        #region GetDB
        public static MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return _oDB;
        }
        #endregion
        #region
        public void Release(){}
        #endregion
    }
}


