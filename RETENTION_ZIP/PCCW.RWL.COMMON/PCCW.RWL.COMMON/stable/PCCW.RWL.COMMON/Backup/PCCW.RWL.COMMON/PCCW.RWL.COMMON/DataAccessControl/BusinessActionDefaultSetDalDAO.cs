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
///-- Create date: <Create Date 2011-07-14>
///-- Description:	<Description,Table :[BusinessActionDefaultSet],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class BusinessActionDefaultSetDalDAO{
        
        #region RS
        public class BusinessActionDefaultSetRS
        {
            public bool n_bLob = false;
            public bool n_bS_premium2 = false;
            public bool n_bDisplay2 = false;
            public bool n_bMid = false;
            public bool n_bDisplay1 = false;
            public bool n_bCdate = false;
            public bool n_bBundle_name = false;
            public bool n_bBusiness_action_value_1 = false;
            public bool n_bTrade_field = false;
            public bool n_bS_premium = false;
            public bool n_bProgram = false;
            public bool n_bEdate = false;
            public bool n_bRebate = false;
            public bool n_bCon_per = false;
            public bool n_bNormal_rebate_type = false;
            public bool n_bPremium = false;
            public bool n_bBusiness_action_value_2 = false;
            public bool n_bEnabled2 = false;
            public bool n_bCid = false;
            public bool n_bBusiness_action_2 = false;
            public bool n_bBusiness_action_1 = false;
            public bool n_bRate_plan = false;
            public bool n_bFree_mon = false;
            public bool n_bEnabled1 = false;
            public bool n_bHs_model = false;
            public bool n_bActive = false;
            public bool n_bIssue_type = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bLob  || x_bSetShowALL || (BusinessActionDefaultSet.Para.lob.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bLob=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessActionDefaultSet.Para.lob);
                }
                if (this.n_bS_premium2  || x_bSetShowALL || (BusinessActionDefaultSet.Para.s_premium2.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bS_premium2=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessActionDefaultSet.Para.s_premium2);
                }
                if (this.n_bDisplay2  || x_bSetShowALL || (BusinessActionDefaultSet.Para.display2.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDisplay2=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessActionDefaultSet.Para.display2);
                }
                if (this.n_bMid  || x_bSetShowALL || (BusinessActionDefaultSet.Para.mid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessActionDefaultSet.Para.mid);
                }
                if (this.n_bDisplay1  || x_bSetShowALL || (BusinessActionDefaultSet.Para.display1.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDisplay1=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessActionDefaultSet.Para.display1);
                }
                if (this.n_bCdate  || x_bSetShowALL || (BusinessActionDefaultSet.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessActionDefaultSet.Para.cdate);
                }
                if (this.n_bBundle_name  || x_bSetShowALL || (BusinessActionDefaultSet.Para.bundle_name.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bBundle_name=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessActionDefaultSet.Para.bundle_name);
                }
                if (this.n_bBusiness_action_value_1  || x_bSetShowALL || (BusinessActionDefaultSet.Para.business_action_value_1.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bBusiness_action_value_1=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessActionDefaultSet.Para.business_action_value_1);
                }
                if (this.n_bTrade_field  || x_bSetShowALL || (BusinessActionDefaultSet.Para.trade_field.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bTrade_field=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessActionDefaultSet.Para.trade_field);
                }
                if (this.n_bS_premium  || x_bSetShowALL || (BusinessActionDefaultSet.Para.s_premium.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bS_premium=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessActionDefaultSet.Para.s_premium);
                }
                if (this.n_bProgram  || x_bSetShowALL || (BusinessActionDefaultSet.Para.program.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bProgram=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessActionDefaultSet.Para.program);
                }
                if (this.n_bEdate  || x_bSetShowALL || (BusinessActionDefaultSet.Para.edate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessActionDefaultSet.Para.edate);
                }
                if (this.n_bRebate  || x_bSetShowALL || (BusinessActionDefaultSet.Para.rebate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRebate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessActionDefaultSet.Para.rebate);
                }
                if (this.n_bCon_per  || x_bSetShowALL || (BusinessActionDefaultSet.Para.con_per.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCon_per=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessActionDefaultSet.Para.con_per);
                }
                if (this.n_bNormal_rebate_type  || x_bSetShowALL || (BusinessActionDefaultSet.Para.normal_rebate_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bNormal_rebate_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessActionDefaultSet.Para.normal_rebate_type);
                }
                if (this.n_bPremium  || x_bSetShowALL || (BusinessActionDefaultSet.Para.premium.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPremium=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessActionDefaultSet.Para.premium);
                }
                if (this.n_bBusiness_action_value_2  || x_bSetShowALL || (BusinessActionDefaultSet.Para.business_action_value_2.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bBusiness_action_value_2=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessActionDefaultSet.Para.business_action_value_2);
                }
                if (this.n_bEnabled2  || x_bSetShowALL || (BusinessActionDefaultSet.Para.enabled2.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEnabled2=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessActionDefaultSet.Para.enabled2);
                }
                if (this.n_bCid  || x_bSetShowALL || (BusinessActionDefaultSet.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessActionDefaultSet.Para.cid);
                }
                if (this.n_bBusiness_action_2  || x_bSetShowALL || (BusinessActionDefaultSet.Para.business_action_2.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bBusiness_action_2=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessActionDefaultSet.Para.business_action_2);
                }
                if (this.n_bBusiness_action_1  || x_bSetShowALL || (BusinessActionDefaultSet.Para.business_action_1.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bBusiness_action_1=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessActionDefaultSet.Para.business_action_1);
                }
                if (this.n_bRate_plan  || x_bSetShowALL || (BusinessActionDefaultSet.Para.rate_plan.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRate_plan=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessActionDefaultSet.Para.rate_plan);
                }
                if (this.n_bFree_mon  || x_bSetShowALL || (BusinessActionDefaultSet.Para.free_mon.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFree_mon=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessActionDefaultSet.Para.free_mon);
                }
                if (this.n_bEnabled1  || x_bSetShowALL || (BusinessActionDefaultSet.Para.enabled1.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEnabled1=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessActionDefaultSet.Para.enabled1);
                }
                if (this.n_bHs_model  || x_bSetShowALL || (BusinessActionDefaultSet.Para.hs_model.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bHs_model=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessActionDefaultSet.Para.hs_model);
                }
                if (this.n_bActive  || x_bSetShowALL || (BusinessActionDefaultSet.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessActionDefaultSet.Para.active);
                }
                if (this.n_bIssue_type  || x_bSetShowALL || (BusinessActionDefaultSet.Para.issue_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bIssue_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessActionDefaultSet.Para.issue_type);
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
        
        public BusinessActionDefaultSetDalDAO(){
        }
        ~BusinessActionDefaultSetDalDAO(){
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
            _oSearchUtils.SetTable(BusinessActionDefaultSet.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<BusinessActionDefaultSetEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, BusinessActionDefaultSetRS x_oFieldsToReturn,BusinessActionDefaultSetRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<BusinessActionDefaultSetEntity> _oBusinessActionDefaultSetList = new List<BusinessActionDefaultSetEntity>();
                
                while (_oDATA.Read())
                {
                    BusinessActionDefaultSet _oBusinessActionDefaultSet = new BusinessActionDefaultSet();
                    if ((true).Equals(x_oFieldsToReturn.n_bLob))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessActionDefaultSet.Para.lob])) { _oBusinessActionDefaultSet.SetLob((string)_oDATA[BusinessActionDefaultSet.Para.lob]); } else { _oBusinessActionDefaultSet.SetLob(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bS_premium2))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessActionDefaultSet.Para.s_premium2])) { _oBusinessActionDefaultSet.SetS_premium2((string)_oDATA[BusinessActionDefaultSet.Para.s_premium2]); } else { _oBusinessActionDefaultSet.SetS_premium2(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDisplay2))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessActionDefaultSet.Para.display2])) { _oBusinessActionDefaultSet.SetDisplay2((global::System.Nullable<bool>)_oDATA[BusinessActionDefaultSet.Para.display2]); } else { _oBusinessActionDefaultSet.SetDisplay2(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessActionDefaultSet.Para.mid])) { _oBusinessActionDefaultSet.SetMid((global::System.Nullable<int>)_oDATA[BusinessActionDefaultSet.Para.mid]); } else { _oBusinessActionDefaultSet.SetMid(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDisplay1))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessActionDefaultSet.Para.display1])) { _oBusinessActionDefaultSet.SetDisplay1((global::System.Nullable<bool>)_oDATA[BusinessActionDefaultSet.Para.display1]); } else { _oBusinessActionDefaultSet.SetDisplay1(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessActionDefaultSet.Para.cdate])) { _oBusinessActionDefaultSet.SetCdate((global::System.Nullable<DateTime>)_oDATA[BusinessActionDefaultSet.Para.cdate]); } else { _oBusinessActionDefaultSet.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bBundle_name))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessActionDefaultSet.Para.bundle_name])) { _oBusinessActionDefaultSet.SetBundle_name((string)_oDATA[BusinessActionDefaultSet.Para.bundle_name]); } else { _oBusinessActionDefaultSet.SetBundle_name(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bBusiness_action_value_1))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessActionDefaultSet.Para.business_action_value_1])) { _oBusinessActionDefaultSet.SetBusiness_action_value_1((string)_oDATA[BusinessActionDefaultSet.Para.business_action_value_1]); } else { _oBusinessActionDefaultSet.SetBusiness_action_value_1(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bTrade_field))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessActionDefaultSet.Para.trade_field])) { _oBusinessActionDefaultSet.SetTrade_field((string)_oDATA[BusinessActionDefaultSet.Para.trade_field]); } else { _oBusinessActionDefaultSet.SetTrade_field(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bS_premium))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessActionDefaultSet.Para.s_premium])) { _oBusinessActionDefaultSet.SetS_premium((string)_oDATA[BusinessActionDefaultSet.Para.s_premium]); } else { _oBusinessActionDefaultSet.SetS_premium(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bProgram))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessActionDefaultSet.Para.program])) { _oBusinessActionDefaultSet.SetProgram((string)_oDATA[BusinessActionDefaultSet.Para.program]); } else { _oBusinessActionDefaultSet.SetProgram(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessActionDefaultSet.Para.edate])) { _oBusinessActionDefaultSet.SetEdate((global::System.Nullable<DateTime>)_oDATA[BusinessActionDefaultSet.Para.edate]); } else { _oBusinessActionDefaultSet.SetEdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRebate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessActionDefaultSet.Para.rebate])) { _oBusinessActionDefaultSet.SetRebate((string)_oDATA[BusinessActionDefaultSet.Para.rebate]); } else { _oBusinessActionDefaultSet.SetRebate(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCon_per))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessActionDefaultSet.Para.con_per])) { _oBusinessActionDefaultSet.SetCon_per((string)_oDATA[BusinessActionDefaultSet.Para.con_per]); } else { _oBusinessActionDefaultSet.SetCon_per(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bNormal_rebate_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessActionDefaultSet.Para.normal_rebate_type])) { _oBusinessActionDefaultSet.SetNormal_rebate_type((string)_oDATA[BusinessActionDefaultSet.Para.normal_rebate_type]); } else { _oBusinessActionDefaultSet.SetNormal_rebate_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPremium))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessActionDefaultSet.Para.premium])) { _oBusinessActionDefaultSet.SetPremium((string)_oDATA[BusinessActionDefaultSet.Para.premium]); } else { _oBusinessActionDefaultSet.SetPremium(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bBusiness_action_value_2))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessActionDefaultSet.Para.business_action_value_2])) { _oBusinessActionDefaultSet.SetBusiness_action_value_2((string)_oDATA[BusinessActionDefaultSet.Para.business_action_value_2]); } else { _oBusinessActionDefaultSet.SetBusiness_action_value_2(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEnabled2))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessActionDefaultSet.Para.enabled2])) { _oBusinessActionDefaultSet.SetEnabled2((global::System.Nullable<bool>)_oDATA[BusinessActionDefaultSet.Para.enabled2]); } else { _oBusinessActionDefaultSet.SetEnabled2(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessActionDefaultSet.Para.cid])) { _oBusinessActionDefaultSet.SetCid((string)_oDATA[BusinessActionDefaultSet.Para.cid]); } else { _oBusinessActionDefaultSet.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bBusiness_action_2))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessActionDefaultSet.Para.business_action_2])) { _oBusinessActionDefaultSet.SetBusiness_action_2((string)_oDATA[BusinessActionDefaultSet.Para.business_action_2]); } else { _oBusinessActionDefaultSet.SetBusiness_action_2(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bBusiness_action_1))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessActionDefaultSet.Para.business_action_1])) { _oBusinessActionDefaultSet.SetBusiness_action_1((string)_oDATA[BusinessActionDefaultSet.Para.business_action_1]); } else { _oBusinessActionDefaultSet.SetBusiness_action_1(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRate_plan))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessActionDefaultSet.Para.rate_plan])) { _oBusinessActionDefaultSet.SetRate_plan((string)_oDATA[BusinessActionDefaultSet.Para.rate_plan]); } else { _oBusinessActionDefaultSet.SetRate_plan(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFree_mon))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessActionDefaultSet.Para.free_mon])) { _oBusinessActionDefaultSet.SetFree_mon((string)_oDATA[BusinessActionDefaultSet.Para.free_mon]); } else { _oBusinessActionDefaultSet.SetFree_mon(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEnabled1))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessActionDefaultSet.Para.enabled1])) { _oBusinessActionDefaultSet.SetEnabled1((global::System.Nullable<bool>)_oDATA[BusinessActionDefaultSet.Para.enabled1]); } else { _oBusinessActionDefaultSet.SetEnabled1(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bHs_model))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessActionDefaultSet.Para.hs_model])) { _oBusinessActionDefaultSet.SetHs_model((string)_oDATA[BusinessActionDefaultSet.Para.hs_model]); } else { _oBusinessActionDefaultSet.SetHs_model(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessActionDefaultSet.Para.active])) { _oBusinessActionDefaultSet.SetActive((global::System.Nullable<bool>)_oDATA[BusinessActionDefaultSet.Para.active]); } else { _oBusinessActionDefaultSet.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bIssue_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessActionDefaultSet.Para.issue_type])) { _oBusinessActionDefaultSet.SetIssue_type((string)_oDATA[BusinessActionDefaultSet.Para.issue_type]); } else { _oBusinessActionDefaultSet.SetIssue_type(global::System.String.Empty); }
                    }
                    _oBusinessActionDefaultSetList.Add(_oBusinessActionDefaultSet);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oBusinessActionDefaultSetList;
            }
            return new List<BusinessActionDefaultSetEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<BusinessActionDefaultSetEntity> OrderBy(string x_sSort, IQueryable<BusinessActionDefaultSetEntity> x_oBusinessActionDefaultSetBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case BusinessActionDefaultSet.Para.lob:
                if(x_bAsc)
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderBy(c => c.lob).Select(c => c);
                else
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderByDescending(c => c.lob).Select(c => c);
                break;
                case BusinessActionDefaultSet.Para.s_premium2:
                if(x_bAsc)
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderBy(c => c.s_premium2).Select(c => c);
                else
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderByDescending(c => c.s_premium2).Select(c => c);
                break;
                case BusinessActionDefaultSet.Para.display2:
                if(x_bAsc)
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderBy(c => c.display2).Select(c => c);
                else
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderByDescending(c => c.display2).Select(c => c);
                break;
                case BusinessActionDefaultSet.Para.mid:
                if(x_bAsc)
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderBy(c => c.mid).Select(c => c);
                else
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderByDescending(c => c.mid).Select(c => c);
                break;
                case BusinessActionDefaultSet.Para.display1:
                if(x_bAsc)
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderBy(c => c.display1).Select(c => c);
                else
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderByDescending(c => c.display1).Select(c => c);
                break;
                case BusinessActionDefaultSet.Para.cdate:
                if(x_bAsc)
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case BusinessActionDefaultSet.Para.bundle_name:
                if(x_bAsc)
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderBy(c => c.bundle_name).Select(c => c);
                else
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderByDescending(c => c.bundle_name).Select(c => c);
                break;
                case BusinessActionDefaultSet.Para.business_action_value_1:
                if(x_bAsc)
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderBy(c => c.business_action_value_1).Select(c => c);
                else
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderByDescending(c => c.business_action_value_1).Select(c => c);
                break;
                case BusinessActionDefaultSet.Para.trade_field:
                if(x_bAsc)
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderBy(c => c.trade_field).Select(c => c);
                else
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderByDescending(c => c.trade_field).Select(c => c);
                break;
                case BusinessActionDefaultSet.Para.s_premium:
                if(x_bAsc)
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderBy(c => c.s_premium).Select(c => c);
                else
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderByDescending(c => c.s_premium).Select(c => c);
                break;
                case BusinessActionDefaultSet.Para.program:
                if(x_bAsc)
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderBy(c => c.program).Select(c => c);
                else
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderByDescending(c => c.program).Select(c => c);
                break;
                case BusinessActionDefaultSet.Para.edate:
                if(x_bAsc)
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderBy(c => c.edate).Select(c => c);
                else
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderByDescending(c => c.edate).Select(c => c);
                break;
                case BusinessActionDefaultSet.Para.rebate:
                if(x_bAsc)
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderBy(c => c.rebate).Select(c => c);
                else
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderByDescending(c => c.rebate).Select(c => c);
                break;
                case BusinessActionDefaultSet.Para.con_per:
                if(x_bAsc)
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderBy(c => c.con_per).Select(c => c);
                else
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderByDescending(c => c.con_per).Select(c => c);
                break;
                case BusinessActionDefaultSet.Para.normal_rebate_type:
                if(x_bAsc)
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderBy(c => c.normal_rebate_type).Select(c => c);
                else
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderByDescending(c => c.normal_rebate_type).Select(c => c);
                break;
                case BusinessActionDefaultSet.Para.premium:
                if(x_bAsc)
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderBy(c => c.premium).Select(c => c);
                else
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderByDescending(c => c.premium).Select(c => c);
                break;
                case BusinessActionDefaultSet.Para.business_action_value_2:
                if(x_bAsc)
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderBy(c => c.business_action_value_2).Select(c => c);
                else
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderByDescending(c => c.business_action_value_2).Select(c => c);
                break;
                case BusinessActionDefaultSet.Para.enabled2:
                if(x_bAsc)
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderBy(c => c.enabled2).Select(c => c);
                else
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderByDescending(c => c.enabled2).Select(c => c);
                break;
                case BusinessActionDefaultSet.Para.cid:
                if(x_bAsc)
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderBy(c => c.cid).Select(c => c);
                else
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderByDescending(c => c.cid).Select(c => c);
                break;
                case BusinessActionDefaultSet.Para.business_action_2:
                if(x_bAsc)
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderBy(c => c.business_action_2).Select(c => c);
                else
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderByDescending(c => c.business_action_2).Select(c => c);
                break;
                case BusinessActionDefaultSet.Para.business_action_1:
                if(x_bAsc)
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderBy(c => c.business_action_1).Select(c => c);
                else
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderByDescending(c => c.business_action_1).Select(c => c);
                break;
                case BusinessActionDefaultSet.Para.rate_plan:
                if(x_bAsc)
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderBy(c => c.rate_plan).Select(c => c);
                else
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderByDescending(c => c.rate_plan).Select(c => c);
                break;
                case BusinessActionDefaultSet.Para.free_mon:
                if(x_bAsc)
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderBy(c => c.free_mon).Select(c => c);
                else
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderByDescending(c => c.free_mon).Select(c => c);
                break;
                case BusinessActionDefaultSet.Para.enabled1:
                if(x_bAsc)
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderBy(c => c.enabled1).Select(c => c);
                else
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderByDescending(c => c.enabled1).Select(c => c);
                break;
                case BusinessActionDefaultSet.Para.hs_model:
                if(x_bAsc)
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderBy(c => c.hs_model).Select(c => c);
                else
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderByDescending(c => c.hs_model).Select(c => c);
                break;
                case BusinessActionDefaultSet.Para.active:
                if(x_bAsc)
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case BusinessActionDefaultSet.Para.issue_type:
                if(x_bAsc)
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderBy(c => c.issue_type).Select(c => c);
                else
                    x_oBusinessActionDefaultSetBaseList = x_oBusinessActionDefaultSetBaseList.OrderByDescending(c => c.issue_type).Select(c => c);
                break;
            }
            return x_oBusinessActionDefaultSetBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<BusinessActionDefaultSetEntity> FindAll()
        {
            BusinessActionDefaultSetEntity[] _oBusinessActionDefaultSetsArr=  BusinessActionDefaultSetRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oBusinessActionDefaultSetsArr != null)
            {
                IList<BusinessActionDefaultSetEntity> _oBusinessActionDefaultSetsList = (IList<BusinessActionDefaultSetEntity>)_oBusinessActionDefaultSetsArr;
                return _oBusinessActionDefaultSetsList;
            }
            return new List<BusinessActionDefaultSetEntity>();
        }
        
        public static IList<BusinessActionDefaultSetEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<BusinessActionDefaultSetEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<BusinessActionDefaultSetEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<BusinessActionDefaultSetEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            BusinessActionDefaultSetRS x_oShowField = new BusinessActionDefaultSetRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            BusinessActionDefaultSetRS x_oSortField=new BusinessActionDefaultSetRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(BusinessActionDefaultSet.Para.mid.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(BusinessActionDefaultSet.Para.mid, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            BusinessActionDefaultSetRepositoryBase _oBusinessActionDefaultSetRepositoryBase = new BusinessActionDefaultSetRepositoryBase(GetDB());
            return _oBusinessActionDefaultSetRepositoryBase.GetCount();
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


