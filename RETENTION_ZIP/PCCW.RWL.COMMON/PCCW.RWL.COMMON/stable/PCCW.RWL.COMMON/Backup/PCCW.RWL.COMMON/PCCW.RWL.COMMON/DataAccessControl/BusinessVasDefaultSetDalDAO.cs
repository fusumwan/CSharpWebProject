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
///-- Create date: <Create Date 2011-07-15>
///-- Description:	<Description,Table :[BusinessVasDefaultSet],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class BusinessVasDefaultSetDalDAO{
        
        #region RS
        public class BusinessVasDefaultSetRS
        {
            public bool n_bDisplay2 = false;
            public bool n_bMid = false;
            public bool n_bCdate = false;
            public bool n_bBundle_name = false;
            public bool n_bValue2 = false;
            public bool n_bCid = false;
            public bool n_bValue1 = false;
            public bool n_bProgram = false;
            public bool n_bEdate = false;
            public bool n_bActive = false;
            public bool n_bTrade_field = false;
            public bool n_bCon_per = false;
            public bool n_bDisplay1 = false;
            public bool n_bEnabled2 = false;
            public bool n_bVas2 = false;
            public bool n_bRate_plan = false;
            public bool n_bEnabled1 = false;
            public bool n_bHs_model = false;
            public bool n_bVas1 = false;
            public bool n_bIssue_type = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bDisplay2  || x_bSetShowALL || (BusinessVasDefaultSet.Para.display2.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDisplay2=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVasDefaultSet.Para.display2);
                }
                if (this.n_bMid  || x_bSetShowALL || (BusinessVasDefaultSet.Para.mid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVasDefaultSet.Para.mid);
                }
                if (this.n_bCdate  || x_bSetShowALL || (BusinessVasDefaultSet.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVasDefaultSet.Para.cdate);
                }
                if (this.n_bBundle_name  || x_bSetShowALL || (BusinessVasDefaultSet.Para.bundle_name.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bBundle_name=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVasDefaultSet.Para.bundle_name);
                }
                if (this.n_bValue2  || x_bSetShowALL || (BusinessVasDefaultSet.Para.value2.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bValue2=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVasDefaultSet.Para.value2);
                }
                if (this.n_bCid  || x_bSetShowALL || (BusinessVasDefaultSet.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVasDefaultSet.Para.cid);
                }
                if (this.n_bValue1  || x_bSetShowALL || (BusinessVasDefaultSet.Para.value1.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bValue1=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVasDefaultSet.Para.value1);
                }
                if (this.n_bProgram  || x_bSetShowALL || (BusinessVasDefaultSet.Para.program.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bProgram=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVasDefaultSet.Para.program);
                }
                if (this.n_bEdate  || x_bSetShowALL || (BusinessVasDefaultSet.Para.edate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVasDefaultSet.Para.edate);
                }
                if (this.n_bActive  || x_bSetShowALL || (BusinessVasDefaultSet.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVasDefaultSet.Para.active);
                }
                if (this.n_bTrade_field  || x_bSetShowALL || (BusinessVasDefaultSet.Para.trade_field.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bTrade_field=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVasDefaultSet.Para.trade_field);
                }
                if (this.n_bCon_per  || x_bSetShowALL || (BusinessVasDefaultSet.Para.con_per.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCon_per=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVasDefaultSet.Para.con_per);
                }
                if (this.n_bDisplay1  || x_bSetShowALL || (BusinessVasDefaultSet.Para.display1.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDisplay1=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVasDefaultSet.Para.display1);
                }
                if (this.n_bEnabled2  || x_bSetShowALL || (BusinessVasDefaultSet.Para.enabled2.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEnabled2=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVasDefaultSet.Para.enabled2);
                }
                if (this.n_bVas2  || x_bSetShowALL || (BusinessVasDefaultSet.Para.vas2.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bVas2=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVasDefaultSet.Para.vas2);
                }
                if (this.n_bRate_plan  || x_bSetShowALL || (BusinessVasDefaultSet.Para.rate_plan.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRate_plan=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVasDefaultSet.Para.rate_plan);
                }
                if (this.n_bEnabled1  || x_bSetShowALL || (BusinessVasDefaultSet.Para.enabled1.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEnabled1=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVasDefaultSet.Para.enabled1);
                }
                if (this.n_bHs_model  || x_bSetShowALL || (BusinessVasDefaultSet.Para.hs_model.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bHs_model=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVasDefaultSet.Para.hs_model);
                }
                if (this.n_bVas1  || x_bSetShowALL || (BusinessVasDefaultSet.Para.vas1.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bVas1=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVasDefaultSet.Para.vas1);
                }
                if (this.n_bIssue_type  || x_bSetShowALL || (BusinessVasDefaultSet.Para.issue_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bIssue_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVasDefaultSet.Para.issue_type);
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
        
        public BusinessVasDefaultSetDalDAO(){
        }
        ~BusinessVasDefaultSetDalDAO(){
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
            _oSearchUtils.SetTable(BusinessVasDefaultSet.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<BusinessVasDefaultSetEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, BusinessVasDefaultSetRS x_oFieldsToReturn,BusinessVasDefaultSetRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<BusinessVasDefaultSetEntity> _oBusinessVasDefaultSetList = new List<BusinessVasDefaultSetEntity>();
                
                while (_oDATA.Read())
                {
                    BusinessVasDefaultSet _oBusinessVasDefaultSet = new BusinessVasDefaultSet();
                    if ((true).Equals(x_oFieldsToReturn.n_bDisplay2))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVasDefaultSet.Para.display2])) { _oBusinessVasDefaultSet.SetDisplay2((global::System.Nullable<bool>)_oDATA[BusinessVasDefaultSet.Para.display2]); } else { _oBusinessVasDefaultSet.SetDisplay2(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVasDefaultSet.Para.mid])) { _oBusinessVasDefaultSet.SetMid((global::System.Nullable<int>)_oDATA[BusinessVasDefaultSet.Para.mid]); } else { _oBusinessVasDefaultSet.SetMid(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVasDefaultSet.Para.cdate])) { _oBusinessVasDefaultSet.SetCdate((global::System.Nullable<DateTime>)_oDATA[BusinessVasDefaultSet.Para.cdate]); } else { _oBusinessVasDefaultSet.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bBundle_name))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVasDefaultSet.Para.bundle_name])) { _oBusinessVasDefaultSet.SetBundle_name((string)_oDATA[BusinessVasDefaultSet.Para.bundle_name]); } else { _oBusinessVasDefaultSet.SetBundle_name(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bValue2))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVasDefaultSet.Para.value2])) { _oBusinessVasDefaultSet.SetValue2((string)_oDATA[BusinessVasDefaultSet.Para.value2]); } else { _oBusinessVasDefaultSet.SetValue2(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVasDefaultSet.Para.cid])) { _oBusinessVasDefaultSet.SetCid((string)_oDATA[BusinessVasDefaultSet.Para.cid]); } else { _oBusinessVasDefaultSet.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bValue1))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVasDefaultSet.Para.value1])) { _oBusinessVasDefaultSet.SetValue1((string)_oDATA[BusinessVasDefaultSet.Para.value1]); } else { _oBusinessVasDefaultSet.SetValue1(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bProgram))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVasDefaultSet.Para.program])) { _oBusinessVasDefaultSet.SetProgram((string)_oDATA[BusinessVasDefaultSet.Para.program]); } else { _oBusinessVasDefaultSet.SetProgram(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVasDefaultSet.Para.edate])) { _oBusinessVasDefaultSet.SetEdate((global::System.Nullable<DateTime>)_oDATA[BusinessVasDefaultSet.Para.edate]); } else { _oBusinessVasDefaultSet.SetEdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVasDefaultSet.Para.active])) { _oBusinessVasDefaultSet.SetActive((global::System.Nullable<bool>)_oDATA[BusinessVasDefaultSet.Para.active]); } else { _oBusinessVasDefaultSet.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bTrade_field))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVasDefaultSet.Para.trade_field])) { _oBusinessVasDefaultSet.SetTrade_field((string)_oDATA[BusinessVasDefaultSet.Para.trade_field]); } else { _oBusinessVasDefaultSet.SetTrade_field(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCon_per))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVasDefaultSet.Para.con_per])) { _oBusinessVasDefaultSet.SetCon_per((string)_oDATA[BusinessVasDefaultSet.Para.con_per]); } else { _oBusinessVasDefaultSet.SetCon_per(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDisplay1))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVasDefaultSet.Para.display1])) { _oBusinessVasDefaultSet.SetDisplay1((global::System.Nullable<bool>)_oDATA[BusinessVasDefaultSet.Para.display1]); } else { _oBusinessVasDefaultSet.SetDisplay1(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEnabled2))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVasDefaultSet.Para.enabled2])) { _oBusinessVasDefaultSet.SetEnabled2((global::System.Nullable<bool>)_oDATA[BusinessVasDefaultSet.Para.enabled2]); } else { _oBusinessVasDefaultSet.SetEnabled2(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bVas2))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVasDefaultSet.Para.vas2])) { _oBusinessVasDefaultSet.SetVas2((string)_oDATA[BusinessVasDefaultSet.Para.vas2]); } else { _oBusinessVasDefaultSet.SetVas2(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRate_plan))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVasDefaultSet.Para.rate_plan])) { _oBusinessVasDefaultSet.SetRate_plan((string)_oDATA[BusinessVasDefaultSet.Para.rate_plan]); } else { _oBusinessVasDefaultSet.SetRate_plan(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEnabled1))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVasDefaultSet.Para.enabled1])) { _oBusinessVasDefaultSet.SetEnabled1((global::System.Nullable<bool>)_oDATA[BusinessVasDefaultSet.Para.enabled1]); } else { _oBusinessVasDefaultSet.SetEnabled1(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bHs_model))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVasDefaultSet.Para.hs_model])) { _oBusinessVasDefaultSet.SetHs_model((string)_oDATA[BusinessVasDefaultSet.Para.hs_model]); } else { _oBusinessVasDefaultSet.SetHs_model(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bVas1))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVasDefaultSet.Para.vas1])) { _oBusinessVasDefaultSet.SetVas1((string)_oDATA[BusinessVasDefaultSet.Para.vas1]); } else { _oBusinessVasDefaultSet.SetVas1(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bIssue_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVasDefaultSet.Para.issue_type])) { _oBusinessVasDefaultSet.SetIssue_type((string)_oDATA[BusinessVasDefaultSet.Para.issue_type]); } else { _oBusinessVasDefaultSet.SetIssue_type(global::System.String.Empty); }
                    }
                    _oBusinessVasDefaultSetList.Add(_oBusinessVasDefaultSet);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oBusinessVasDefaultSetList;
            }
            return new List<BusinessVasDefaultSetEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<BusinessVasDefaultSetEntity> OrderBy(string x_sSort, IQueryable<BusinessVasDefaultSetEntity> x_oBusinessVasDefaultSetBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case BusinessVasDefaultSet.Para.display2:
                if(x_bAsc)
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderBy(c => c.display2).Select(c => c);
                else
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderByDescending(c => c.display2).Select(c => c);
                break;
                case BusinessVasDefaultSet.Para.mid:
                if(x_bAsc)
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderBy(c => c.mid).Select(c => c);
                else
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderByDescending(c => c.mid).Select(c => c);
                break;
                case BusinessVasDefaultSet.Para.cdate:
                if(x_bAsc)
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case BusinessVasDefaultSet.Para.bundle_name:
                if(x_bAsc)
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderBy(c => c.bundle_name).Select(c => c);
                else
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderByDescending(c => c.bundle_name).Select(c => c);
                break;
                case BusinessVasDefaultSet.Para.value2:
                if(x_bAsc)
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderBy(c => c.value2).Select(c => c);
                else
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderByDescending(c => c.value2).Select(c => c);
                break;
                case BusinessVasDefaultSet.Para.cid:
                if(x_bAsc)
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderBy(c => c.cid).Select(c => c);
                else
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderByDescending(c => c.cid).Select(c => c);
                break;
                case BusinessVasDefaultSet.Para.value1:
                if(x_bAsc)
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderBy(c => c.value1).Select(c => c);
                else
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderByDescending(c => c.value1).Select(c => c);
                break;
                case BusinessVasDefaultSet.Para.program:
                if(x_bAsc)
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderBy(c => c.program).Select(c => c);
                else
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderByDescending(c => c.program).Select(c => c);
                break;
                case BusinessVasDefaultSet.Para.edate:
                if(x_bAsc)
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderBy(c => c.edate).Select(c => c);
                else
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderByDescending(c => c.edate).Select(c => c);
                break;
                case BusinessVasDefaultSet.Para.active:
                if(x_bAsc)
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case BusinessVasDefaultSet.Para.trade_field:
                if(x_bAsc)
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderBy(c => c.trade_field).Select(c => c);
                else
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderByDescending(c => c.trade_field).Select(c => c);
                break;
                case BusinessVasDefaultSet.Para.con_per:
                if(x_bAsc)
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderBy(c => c.con_per).Select(c => c);
                else
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderByDescending(c => c.con_per).Select(c => c);
                break;
                case BusinessVasDefaultSet.Para.display1:
                if(x_bAsc)
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderBy(c => c.display1).Select(c => c);
                else
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderByDescending(c => c.display1).Select(c => c);
                break;
                case BusinessVasDefaultSet.Para.enabled2:
                if(x_bAsc)
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderBy(c => c.enabled2).Select(c => c);
                else
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderByDescending(c => c.enabled2).Select(c => c);
                break;
                case BusinessVasDefaultSet.Para.vas2:
                if(x_bAsc)
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderBy(c => c.vas2).Select(c => c);
                else
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderByDescending(c => c.vas2).Select(c => c);
                break;
                case BusinessVasDefaultSet.Para.rate_plan:
                if(x_bAsc)
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderBy(c => c.rate_plan).Select(c => c);
                else
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderByDescending(c => c.rate_plan).Select(c => c);
                break;
                case BusinessVasDefaultSet.Para.enabled1:
                if(x_bAsc)
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderBy(c => c.enabled1).Select(c => c);
                else
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderByDescending(c => c.enabled1).Select(c => c);
                break;
                case BusinessVasDefaultSet.Para.hs_model:
                if(x_bAsc)
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderBy(c => c.hs_model).Select(c => c);
                else
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderByDescending(c => c.hs_model).Select(c => c);
                break;
                case BusinessVasDefaultSet.Para.vas1:
                if(x_bAsc)
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderBy(c => c.vas1).Select(c => c);
                else
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderByDescending(c => c.vas1).Select(c => c);
                break;
                case BusinessVasDefaultSet.Para.issue_type:
                if(x_bAsc)
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderBy(c => c.issue_type).Select(c => c);
                else
                    x_oBusinessVasDefaultSetBaseList = x_oBusinessVasDefaultSetBaseList.OrderByDescending(c => c.issue_type).Select(c => c);
                break;
            }
            return x_oBusinessVasDefaultSetBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<BusinessVasDefaultSetEntity> FindAll()
        {
            BusinessVasDefaultSetEntity[] _oBusinessVasDefaultSetsArr=  BusinessVasDefaultSetRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oBusinessVasDefaultSetsArr != null)
            {
                IList<BusinessVasDefaultSetEntity> _oBusinessVasDefaultSetsList = (IList<BusinessVasDefaultSetEntity>)_oBusinessVasDefaultSetsArr;
                return _oBusinessVasDefaultSetsList;
            }
            return new List<BusinessVasDefaultSetEntity>();
        }
        
        public static IList<BusinessVasDefaultSetEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<BusinessVasDefaultSetEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<BusinessVasDefaultSetEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }

        public static IList<BusinessVasDefaultSetEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem, string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, x_sRowFilter, false);
        }

        public static IList<BusinessVasDefaultSetEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem, string x_sRowFilter, bool x_bAscDirection)
        {
            BusinessVasDefaultSetRS x_oShowField = new BusinessVasDefaultSetRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            BusinessVasDefaultSetRS x_oSortField = new BusinessVasDefaultSetRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(BusinessVasDefaultSet.Para.mid.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression))
            {
                x_oSortField.FieldsToReturn(x_sSortExpression, false);
            }
            x_oSortField.FieldsToReturn(BusinessVasDefaultSet.Para.mid, false);
            return SearchList(x_oSearchItem, x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize), x_oShowField, x_oSortField, x_bAscDirection);
        }


        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            BusinessVasDefaultSetRepositoryBase _oBusinessVasDefaultSetRepositoryBase = new BusinessVasDefaultSetRepositoryBase(GetDB());
            return _oBusinessVasDefaultSetRepositoryBase.GetCount();
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


