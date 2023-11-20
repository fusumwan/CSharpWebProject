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
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2011-07-13>
///-- Description:	<Description,Table :[BusinessTradeExperience],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class BusinessTradeExperienceDalDAO{
        
        #region RS
        public class BusinessTradeExperienceRS
        {
            public bool n_bRec_no = false;
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
                if (this.n_bRec_no  || x_bSetShowALL || (BusinessTradeExperience.Para.rec_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRec_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTradeExperience.Para.rec_no);
                }
                if (this.n_bMid  || x_bSetShowALL || (BusinessTradeExperience.Para.mid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTradeExperience.Para.mid);
                }
                if (this.n_bChannel  || x_bSetShowALL || (BusinessTradeExperience.Para.channel.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bChannel=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTradeExperience.Para.channel);
                }
                if (this.n_bCdate  || x_bSetShowALL || (BusinessTradeExperience.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTradeExperience.Para.cdate);
                }
                if (this.n_bBundle_name  || x_bSetShowALL || (BusinessTradeExperience.Para.bundle_name.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bBundle_name=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTradeExperience.Para.bundle_name);
                }
                if (this.n_bHs_model_name  || x_bSetShowALL || (BusinessTradeExperience.Para.hs_model_name.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bHs_model_name=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTradeExperience.Para.hs_model_name);
                }
                if (this.n_bTrade_field  || x_bSetShowALL || (BusinessTradeExperience.Para.trade_field.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bTrade_field=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTradeExperience.Para.trade_field);
                }
                if (this.n_bDid  || x_bSetShowALL || (BusinessTradeExperience.Para.did.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTradeExperience.Para.did);
                }
                if (this.n_bPremium_1  || x_bSetShowALL || (BusinessTradeExperience.Para.premium_1.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPremium_1=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTradeExperience.Para.premium_1);
                }
                if (this.n_bSdate  || x_bSetShowALL || (BusinessTradeExperience.Para.sdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTradeExperience.Para.sdate);
                }
                if (this.n_bRebate  || x_bSetShowALL || (BusinessTradeExperience.Para.rebate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRebate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTradeExperience.Para.rebate);
                }
                if (this.n_bPremium_2  || x_bSetShowALL || (BusinessTradeExperience.Para.premium_2.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPremium_2=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTradeExperience.Para.premium_2);
                }
                if (this.n_bRetention_type  || x_bSetShowALL || (BusinessTradeExperience.Para.retention_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRetention_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTradeExperience.Para.retention_type);
                }
                if (this.n_bExtra_offer  || x_bSetShowALL || (BusinessTradeExperience.Para.extra_offer.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bExtra_offer=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTradeExperience.Para.extra_offer);
                }
                if (this.n_bEdate  || x_bSetShowALL || (BusinessTradeExperience.Para.edate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTradeExperience.Para.edate);
                }
                if (this.n_bProgram  || x_bSetShowALL || (BusinessTradeExperience.Para.program.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bProgram=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTradeExperience.Para.program);
                }
                if (this.n_bCon_per  || x_bSetShowALL || (BusinessTradeExperience.Para.con_per.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCon_per=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTradeExperience.Para.con_per);
                }
                if (this.n_bRate_plan  || x_bSetShowALL || (BusinessTradeExperience.Para.rate_plan.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRate_plan=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTradeExperience.Para.rate_plan);
                }
                if (this.n_bDdate  || x_bSetShowALL || (BusinessTradeExperience.Para.ddate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTradeExperience.Para.ddate);
                }
                if (this.n_bNormal_rebate_type  || x_bSetShowALL || (BusinessTradeExperience.Para.normal_rebate_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bNormal_rebate_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTradeExperience.Para.normal_rebate_type);
                }
                if (this.n_bActive  || x_bSetShowALL || (BusinessTradeExperience.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTradeExperience.Para.active);
                }
                if (this.n_bFree_mon  || x_bSetShowALL || (BusinessTradeExperience.Para.free_mon.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFree_mon=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTradeExperience.Para.free_mon);
                }
                if (this.n_bCid  || x_bSetShowALL || (BusinessTradeExperience.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTradeExperience.Para.cid);
                }
                if (this.n_bCancel_renew  || x_bSetShowALL || (BusinessTradeExperience.Para.cancel_renew.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCancel_renew=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTradeExperience.Para.cancel_renew);
                }
                if (this.n_bOb_early  || x_bSetShowALL || (BusinessTradeExperience.Para.ob_early.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOb_early=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTradeExperience.Para.ob_early);
                }
                if (this.n_bNormal_rebate  || x_bSetShowALL || (BusinessTradeExperience.Para.normal_rebate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bNormal_rebate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTradeExperience.Para.normal_rebate);
                }
                if (this.n_bHs_model  || x_bSetShowALL || (BusinessTradeExperience.Para.hs_model.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bHs_model=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTradeExperience.Para.hs_model);
                }
                if (this.n_bPlan_fee  || x_bSetShowALL || (BusinessTradeExperience.Para.plan_fee.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPlan_fee=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTradeExperience.Para.plan_fee);
                }
                if (this.n_bPo_date  || x_bSetShowALL || (BusinessTradeExperience.Para.po_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPo_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTradeExperience.Para.po_date);
                }
                if (this.n_bRemarks  || x_bSetShowALL || (BusinessTradeExperience.Para.remarks.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRemarks=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTradeExperience.Para.remarks);
                }
                if (this.n_bIssue_type  || x_bSetShowALL || (BusinessTradeExperience.Para.issue_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bIssue_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessTradeExperience.Para.issue_type);
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
        
        public BusinessTradeExperienceDalDAO(){
        }
        ~BusinessTradeExperienceDalDAO(){
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
            _oSearchUtils.SetTable(BusinessTradeExperience.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<BusinessTradeExperienceEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, BusinessTradeExperienceRS x_oFieldsToReturn,BusinessTradeExperienceRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<BusinessTradeExperienceEntity> _oBusinessTradeExperienceList = new List<BusinessTradeExperienceEntity>();
                
                while (_oDATA.Read())
                {
                    BusinessTradeExperience _oBusinessTradeExperience = new BusinessTradeExperience();
                    if ((true).Equals(x_oFieldsToReturn.n_bRec_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTradeExperience.Para.rec_no])) { _oBusinessTradeExperience.SetRec_no((global::System.Nullable<int>)_oDATA[BusinessTradeExperience.Para.rec_no]); } else { _oBusinessTradeExperience.SetRec_no(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTradeExperience.Para.mid])) { _oBusinessTradeExperience.SetMid((global::System.Nullable<int>)_oDATA[BusinessTradeExperience.Para.mid]); } else { _oBusinessTradeExperience.SetMid(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bChannel))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTradeExperience.Para.channel])) { _oBusinessTradeExperience.SetChannel((string)_oDATA[BusinessTradeExperience.Para.channel]); } else { _oBusinessTradeExperience.SetChannel(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTradeExperience.Para.cdate])) { _oBusinessTradeExperience.SetCdate((global::System.Nullable<DateTime>)_oDATA[BusinessTradeExperience.Para.cdate]); } else { _oBusinessTradeExperience.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bBundle_name))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTradeExperience.Para.bundle_name])) { _oBusinessTradeExperience.SetBundle_name((string)_oDATA[BusinessTradeExperience.Para.bundle_name]); } else { _oBusinessTradeExperience.SetBundle_name(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bHs_model_name))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTradeExperience.Para.hs_model_name])) { _oBusinessTradeExperience.SetHs_model_name((string)_oDATA[BusinessTradeExperience.Para.hs_model_name]); } else { _oBusinessTradeExperience.SetHs_model_name(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bTrade_field))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTradeExperience.Para.trade_field])) { _oBusinessTradeExperience.SetTrade_field((string)_oDATA[BusinessTradeExperience.Para.trade_field]); } else { _oBusinessTradeExperience.SetTrade_field(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTradeExperience.Para.did])) { _oBusinessTradeExperience.SetDid((string)_oDATA[BusinessTradeExperience.Para.did]); } else { _oBusinessTradeExperience.SetDid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPremium_1))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTradeExperience.Para.premium_1])) { _oBusinessTradeExperience.SetPremium_1((string)_oDATA[BusinessTradeExperience.Para.premium_1]); } else { _oBusinessTradeExperience.SetPremium_1(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTradeExperience.Para.sdate])) { _oBusinessTradeExperience.SetSdate((global::System.Nullable<DateTime>)_oDATA[BusinessTradeExperience.Para.sdate]); } else { _oBusinessTradeExperience.SetSdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRebate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTradeExperience.Para.rebate])) { _oBusinessTradeExperience.SetRebate((string)_oDATA[BusinessTradeExperience.Para.rebate]); } else { _oBusinessTradeExperience.SetRebate(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPremium_2))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTradeExperience.Para.premium_2])) { _oBusinessTradeExperience.SetPremium_2((string)_oDATA[BusinessTradeExperience.Para.premium_2]); } else { _oBusinessTradeExperience.SetPremium_2(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRetention_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTradeExperience.Para.retention_type])) { _oBusinessTradeExperience.SetRetention_type((string)_oDATA[BusinessTradeExperience.Para.retention_type]); } else { _oBusinessTradeExperience.SetRetention_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bExtra_offer))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTradeExperience.Para.extra_offer])) { _oBusinessTradeExperience.SetExtra_offer((string)_oDATA[BusinessTradeExperience.Para.extra_offer]); } else { _oBusinessTradeExperience.SetExtra_offer(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTradeExperience.Para.edate])) { _oBusinessTradeExperience.SetEdate((global::System.Nullable<DateTime>)_oDATA[BusinessTradeExperience.Para.edate]); } else { _oBusinessTradeExperience.SetEdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bProgram))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTradeExperience.Para.program])) { _oBusinessTradeExperience.SetProgram((string)_oDATA[BusinessTradeExperience.Para.program]); } else { _oBusinessTradeExperience.SetProgram(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCon_per))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTradeExperience.Para.con_per])) { _oBusinessTradeExperience.SetCon_per((string)_oDATA[BusinessTradeExperience.Para.con_per]); } else { _oBusinessTradeExperience.SetCon_per(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRate_plan))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTradeExperience.Para.rate_plan])) { _oBusinessTradeExperience.SetRate_plan((string)_oDATA[BusinessTradeExperience.Para.rate_plan]); } else { _oBusinessTradeExperience.SetRate_plan(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTradeExperience.Para.ddate])) { _oBusinessTradeExperience.SetDdate((global::System.Nullable<DateTime>)_oDATA[BusinessTradeExperience.Para.ddate]); } else { _oBusinessTradeExperience.SetDdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bNormal_rebate_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTradeExperience.Para.normal_rebate_type])) { _oBusinessTradeExperience.SetNormal_rebate_type((string)_oDATA[BusinessTradeExperience.Para.normal_rebate_type]); } else { _oBusinessTradeExperience.SetNormal_rebate_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTradeExperience.Para.active])) { _oBusinessTradeExperience.SetActive((global::System.Nullable<bool>)_oDATA[BusinessTradeExperience.Para.active]); } else { _oBusinessTradeExperience.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFree_mon))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTradeExperience.Para.free_mon])) { _oBusinessTradeExperience.SetFree_mon((string)_oDATA[BusinessTradeExperience.Para.free_mon]); } else { _oBusinessTradeExperience.SetFree_mon(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTradeExperience.Para.cid])) { _oBusinessTradeExperience.SetCid((string)_oDATA[BusinessTradeExperience.Para.cid]); } else { _oBusinessTradeExperience.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCancel_renew))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTradeExperience.Para.cancel_renew])) { _oBusinessTradeExperience.SetCancel_renew((global::System.Nullable<bool>)_oDATA[BusinessTradeExperience.Para.cancel_renew]); } else { _oBusinessTradeExperience.SetCancel_renew(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOb_early))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTradeExperience.Para.ob_early])) { _oBusinessTradeExperience.SetOb_early((string)_oDATA[BusinessTradeExperience.Para.ob_early]); } else { _oBusinessTradeExperience.SetOb_early(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bNormal_rebate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTradeExperience.Para.normal_rebate])) { _oBusinessTradeExperience.SetNormal_rebate((global::System.Nullable<bool>)_oDATA[BusinessTradeExperience.Para.normal_rebate]); } else { _oBusinessTradeExperience.SetNormal_rebate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bHs_model))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTradeExperience.Para.hs_model])) { _oBusinessTradeExperience.SetHs_model((string)_oDATA[BusinessTradeExperience.Para.hs_model]); } else { _oBusinessTradeExperience.SetHs_model(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPlan_fee))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTradeExperience.Para.plan_fee])) { _oBusinessTradeExperience.SetPlan_fee((string)_oDATA[BusinessTradeExperience.Para.plan_fee]); } else { _oBusinessTradeExperience.SetPlan_fee(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPo_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTradeExperience.Para.po_date])) { _oBusinessTradeExperience.SetPo_date((global::System.Nullable<DateTime>)_oDATA[BusinessTradeExperience.Para.po_date]); } else { _oBusinessTradeExperience.SetPo_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRemarks))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTradeExperience.Para.remarks])) { _oBusinessTradeExperience.SetRemarks((string)_oDATA[BusinessTradeExperience.Para.remarks]); } else { _oBusinessTradeExperience.SetRemarks(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bIssue_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessTradeExperience.Para.issue_type])) { _oBusinessTradeExperience.SetIssue_type((string)_oDATA[BusinessTradeExperience.Para.issue_type]); } else { _oBusinessTradeExperience.SetIssue_type(global::System.String.Empty); }
                    }
                    _oBusinessTradeExperienceList.Add(_oBusinessTradeExperience);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oBusinessTradeExperienceList;
            }
            return new List<BusinessTradeExperienceEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<BusinessTradeExperienceEntity> OrderBy(string x_sSort, IQueryable<BusinessTradeExperienceEntity> x_oBusinessTradeExperienceBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case BusinessTradeExperience.Para.rec_no:
                if(x_bAsc)
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderBy(c => c.rec_no).Select(c => c);
                else
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderByDescending(c => c.rec_no).Select(c => c);
                break;
                case BusinessTradeExperience.Para.mid:
                if(x_bAsc)
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderBy(c => c.mid).Select(c => c);
                else
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderByDescending(c => c.mid).Select(c => c);
                break;
                case BusinessTradeExperience.Para.channel:
                if(x_bAsc)
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderBy(c => c.channel).Select(c => c);
                else
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderByDescending(c => c.channel).Select(c => c);
                break;
                case BusinessTradeExperience.Para.cdate:
                if(x_bAsc)
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case BusinessTradeExperience.Para.bundle_name:
                if(x_bAsc)
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderBy(c => c.bundle_name).Select(c => c);
                else
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderByDescending(c => c.bundle_name).Select(c => c);
                break;
                case BusinessTradeExperience.Para.hs_model_name:
                if(x_bAsc)
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderBy(c => c.hs_model_name).Select(c => c);
                else
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderByDescending(c => c.hs_model_name).Select(c => c);
                break;
                case BusinessTradeExperience.Para.trade_field:
                if(x_bAsc)
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderBy(c => c.trade_field).Select(c => c);
                else
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderByDescending(c => c.trade_field).Select(c => c);
                break;
                case BusinessTradeExperience.Para.did:
                if(x_bAsc)
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderBy(c => c.did).Select(c => c);
                else
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderByDescending(c => c.did).Select(c => c);
                break;
                case BusinessTradeExperience.Para.premium_1:
                if(x_bAsc)
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderBy(c => c.premium_1).Select(c => c);
                else
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderByDescending(c => c.premium_1).Select(c => c);
                break;
                case BusinessTradeExperience.Para.sdate:
                if(x_bAsc)
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderBy(c => c.sdate).Select(c => c);
                else
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderByDescending(c => c.sdate).Select(c => c);
                break;
                case BusinessTradeExperience.Para.rebate:
                if(x_bAsc)
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderBy(c => c.rebate).Select(c => c);
                else
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderByDescending(c => c.rebate).Select(c => c);
                break;
                case BusinessTradeExperience.Para.premium_2:
                if(x_bAsc)
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderBy(c => c.premium_2).Select(c => c);
                else
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderByDescending(c => c.premium_2).Select(c => c);
                break;
                case BusinessTradeExperience.Para.retention_type:
                if(x_bAsc)
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderBy(c => c.retention_type).Select(c => c);
                else
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderByDescending(c => c.retention_type).Select(c => c);
                break;
                case BusinessTradeExperience.Para.extra_offer:
                if(x_bAsc)
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderBy(c => c.extra_offer).Select(c => c);
                else
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderByDescending(c => c.extra_offer).Select(c => c);
                break;
                case BusinessTradeExperience.Para.edate:
                if(x_bAsc)
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderBy(c => c.edate).Select(c => c);
                else
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderByDescending(c => c.edate).Select(c => c);
                break;
                case BusinessTradeExperience.Para.program:
                if(x_bAsc)
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderBy(c => c.program).Select(c => c);
                else
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderByDescending(c => c.program).Select(c => c);
                break;
                case BusinessTradeExperience.Para.con_per:
                if(x_bAsc)
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderBy(c => c.con_per).Select(c => c);
                else
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderByDescending(c => c.con_per).Select(c => c);
                break;
                case BusinessTradeExperience.Para.rate_plan:
                if(x_bAsc)
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderBy(c => c.rate_plan).Select(c => c);
                else
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderByDescending(c => c.rate_plan).Select(c => c);
                break;
                case BusinessTradeExperience.Para.ddate:
                if(x_bAsc)
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderBy(c => c.ddate).Select(c => c);
                else
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderByDescending(c => c.ddate).Select(c => c);
                break;
                case BusinessTradeExperience.Para.normal_rebate_type:
                if(x_bAsc)
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderBy(c => c.normal_rebate_type).Select(c => c);
                else
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderByDescending(c => c.normal_rebate_type).Select(c => c);
                break;
                case BusinessTradeExperience.Para.active:
                if(x_bAsc)
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case BusinessTradeExperience.Para.free_mon:
                if(x_bAsc)
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderBy(c => c.free_mon).Select(c => c);
                else
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderByDescending(c => c.free_mon).Select(c => c);
                break;
                case BusinessTradeExperience.Para.cid:
                if(x_bAsc)
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderBy(c => c.cid).Select(c => c);
                else
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderByDescending(c => c.cid).Select(c => c);
                break;
                case BusinessTradeExperience.Para.cancel_renew:
                if(x_bAsc)
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderBy(c => c.cancel_renew).Select(c => c);
                else
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderByDescending(c => c.cancel_renew).Select(c => c);
                break;
                case BusinessTradeExperience.Para.ob_early:
                if(x_bAsc)
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderBy(c => c.ob_early).Select(c => c);
                else
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderByDescending(c => c.ob_early).Select(c => c);
                break;
                case BusinessTradeExperience.Para.normal_rebate:
                if(x_bAsc)
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderBy(c => c.normal_rebate).Select(c => c);
                else
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderByDescending(c => c.normal_rebate).Select(c => c);
                break;
                case BusinessTradeExperience.Para.hs_model:
                if(x_bAsc)
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderBy(c => c.hs_model).Select(c => c);
                else
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderByDescending(c => c.hs_model).Select(c => c);
                break;
                case BusinessTradeExperience.Para.plan_fee:
                if(x_bAsc)
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderBy(c => c.plan_fee).Select(c => c);
                else
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderByDescending(c => c.plan_fee).Select(c => c);
                break;
                case BusinessTradeExperience.Para.po_date:
                if(x_bAsc)
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderBy(c => c.po_date).Select(c => c);
                else
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderByDescending(c => c.po_date).Select(c => c);
                break;
                case BusinessTradeExperience.Para.remarks:
                if(x_bAsc)
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderBy(c => c.remarks).Select(c => c);
                else
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderByDescending(c => c.remarks).Select(c => c);
                break;
                case BusinessTradeExperience.Para.issue_type:
                if(x_bAsc)
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderBy(c => c.issue_type).Select(c => c);
                else
                    x_oBusinessTradeExperienceBaseList = x_oBusinessTradeExperienceBaseList.OrderByDescending(c => c.issue_type).Select(c => c);
                break;
            }
            return x_oBusinessTradeExperienceBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<BusinessTradeExperienceEntity> FindAll()
        {
            BusinessTradeExperienceEntity[] _oBusinessTradeExperiencesArr=  BusinessTradeExperienceRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oBusinessTradeExperiencesArr != null)
            {
                IList<BusinessTradeExperienceEntity> _oBusinessTradeExperiencesList = (IList<BusinessTradeExperienceEntity>)_oBusinessTradeExperiencesArr;
                return _oBusinessTradeExperiencesList;
            }
            return new List<BusinessTradeExperienceEntity>();
        }
        
        public static IList<BusinessTradeExperienceEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<BusinessTradeExperienceEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<BusinessTradeExperienceEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<BusinessTradeExperienceEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            BusinessTradeExperienceRS x_oShowField = new BusinessTradeExperienceRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            BusinessTradeExperienceRS x_oSortField=new BusinessTradeExperienceRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(BusinessTradeExperience.Para.mid.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(BusinessTradeExperience.Para.mid, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            BusinessTradeExperienceRepositoryBase _oBusinessTradeExperienceRepositoryBase = new BusinessTradeExperienceRepositoryBase(GetDB());
            return _oBusinessTradeExperienceRepositoryBase.GetCount();
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


